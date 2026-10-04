"""Value history from the decoded master tables: {id: {field: value}} per kept version, through the learned schemas
(toramre/brain/kb). Only distinct contents are parsed; versions with the same content share a state."""
import hashlib
import os

from toramre.brain import grammar as G, kb
from toramre.core import paths, versions as V

# kind -> (table, key field, fields to keep or None = all numeric)
KINDS = {
    "skill": ("SkillMaster", "SkillUid"),
    "item": ("ItemMaster", "Id"),
    "recipe": ("RecipeMaster", "recipeId"),
    "registlet": ("RegistletMaster", "Id"),
}
_cache = {}


def _records(kind, blob, schema):
    names = schema["names"]
    out = {}
    for r in G.parse(blob, schema):
        row = dict(zip(names, r))
        if kind == "recipe":
            mats = row.pop("materialDatas", [])
            row["materials"] = sum(m[3] for m in mats)           # total amount of materials
            row["material_kinds"] = len(mats)
        out[row[KINDS[kind][1]]] = {k: v for k, v in row.items() if k != KINDS[kind][1]}
    return out


def states(kind, bundle="BynaryData"):
    """-> [(version, {id: fields})] oldest first, one entry per kept version (equal content parsed once)."""
    table, _ = KINDS[kind]
    entry = kb.load(table)
    if not entry or not entry["schema"].get("names"):
        raise KeyError(f"{table}: no learned schema with field names (toramre brain solve)")
    out, seen = [], {}
    for v in V.list_versions(bundle):
        p = os.path.join(paths.DECODED, bundle, v, table + ".dec")
        if not os.path.exists(p):
            continue
        with open(p, "rb") as fh:
            blob = fh.read()
        h = hashlib.sha1(blob).hexdigest()
        if (kind, h) not in _cache:
            _cache[(kind, h)] = _records(kind, blob, entry["schema"])
        out.append((v, _cache[(kind, h)]))
    return out


def changes(kind):
    """-> [(from_version, to_version, compare-result)] for every consecutive pair whose content differs."""
    from . import diff
    res, st = [], states(kind)
    for (va, a), (vb, b) in zip(st, st[1:]):
        if a is b:
            continue
        d = diff.compare(kind, a, b)
        if d["changed"] or d["added"] or d["removed"]:
            res.append((va, vb, d))
    return res
