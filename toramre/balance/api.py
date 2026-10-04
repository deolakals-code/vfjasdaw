"""Balance changes for the viewer, the CLI and `watch`: one list of entries per skill / item / recipe / registlet.

Sources and how far back each goes (state of the repo on 2026-10-04):
  data   decoded master tables, every kept version          (skill 2 distinct, item 8, recipe 9, registlet 1)
  text   Skill_<lang> notes where only numbers changed       (15 th versions)
  rate   skill multipliers per level, current build only     (snapshots: history starts at the first snapshot)
  buff   skill buff tables per level, current build only     (same)
"""
import os

from toramre.core import paths, versions as V
from toramre.watch import framing
from . import diff, history, polarity, snapshot, textnums


def data_entries(kind):
    """[{source, kind, id, from, to, verdict, changes, added}] from the master tables."""
    out = []
    for va, vb, d in history.changes(kind):
        for k, e in d["changed"].items():
            out.append({"source": "data", "kind": kind, "id": str(k), "from": va, "to": vb, "verdict": e["verdict"],
                        "changes": e["changes"]})
        for k in d["added"]:
            out.append({"source": "data", "kind": kind, "id": str(k), "from": va, "to": vb, "verdict": "ADDED", "changes": []})
        for k in d["removed"]:
            out.append({"source": "data", "kind": kind, "id": str(k), "from": va, "to": vb, "verdict": "REMOVED", "changes": []})
    return out


def text_entries(lang="th"):
    """Skill texts where only the numbers changed (description kind 1, level notes kind 2)."""
    out, prev, pv = [], None, None
    name = f"GameScene_{lang}"
    for v in V.list_versions(name):
        p = os.path.join(paths.DECODED, name, v, f"Skill_{lang}.dec")
        if not os.path.exists(p):
            continue
        with open(p, "rb") as fh:
            t = framing.text_rows(fh.read())
        if not t:
            continue
        cur = {(r[0], r[1]): r[3] for r in t[1] if r[1] in (1, 2)}
        if prev is not None:
            for key in set(cur) & set(prev):
                nums = textnums.compare(prev[key], cur[key])
                if nums:
                    changes = [{"field": f"text:{n['context'] or 'value'}", "before": n["before"], "after": n["after"],
                                "delta": n["delta"], "pct": n["pct"], "verdict": n["verdict"]} for n in nums]
                    out.append({"source": "text", "kind": "skill", "id": str(key[0]), "from": pv, "to": v,
                                "verdict": polarity.combine(c["verdict"] for c in changes), "changes": changes})
        prev, pv = cur, v
    return out


def snapshot_entries(old_label, new_label, directory=None):
    old, new = snapshot.load(old_label, directory), snapshot.load(new_label, directory)
    out = []
    for kind, res in snapshot.compare(old, new).items():
        for k, e in res["changed"].items():
            out.append({"source": kind, "kind": "skill", "id": str(k), "from": old_label, "to": new_label,
                        "verdict": e["verdict"], "changes": e["changes"]})
    return out


def all_entries(kinds=("skill", "item", "recipe", "registlet"), lang="th", snapshots=None, directory=None):
    out = []
    for k in kinds:
        try:
            out += data_entries(k)
        except KeyError:
            continue
    out += text_entries(lang)
    labels = snapshots if snapshots is not None else snapshot.labels(directory)
    for a, b in zip(labels, labels[1:]):
        out += snapshot_entries(a, b, directory)
    return out


def for_entity(entries, kind, ident):
    return [e for e in entries if e["kind"] == kind and e["id"] == str(ident)]


def latest_verdict(entries, kind):
    """{id: verdict of its newest change}: for the BUFF / NERF badges in lists."""
    order = {}
    for e in entries:
        if e["kind"] != kind or e["verdict"] in ("ADDED", "REMOVED"):
            continue
        rank = (V.rank(e["to"]), e["to"])
        if e["id"] not in order or rank >= order[e["id"]][0]:
            order[e["id"]] = (rank, e["verdict"])
    return {k: v[1] for k, v in order.items()}


def describe(e):
    """One line for alerts: 'recipe 30005: releaseLv 300 -> 270 (-10%)'."""
    c = e["changes"][0] if e["changes"] else None
    if not c:
        return f"{e['kind']} {e['id']}: {e['verdict'].lower()}"
    if "levels" in c:
        l = c["levels"][0]
        txt = f"{c['field']} Lv{l['level']} {l['before']} -> {l['after']}" + (f" (+{len(c['levels']) - 1} more levels)" if len(c["levels"]) > 1 else "")
    else:
        pc = f" ({c['pct']:+.0f}%)" if c.get("pct") is not None else ""
        txt = f"{c['field']} {c['before']} -> {c['after']}{pc}"
    more = f", +{len(e['changes']) - 1} more fields" if len(e["changes"]) > 1 else ""
    return f"{e['kind']} {e['id']}: {txt}{more}"


def events(since=None, lang="th", directory=None):
    """BUFF / NERF / MIXED watch events (neutral and added/removed entries are left to the table-level alerts)."""
    from toramre.watch.tags import Event
    out = []
    for e in all_entries(lang=lang, directory=directory):
        if e["verdict"] not in ("BUFF", "NERF", "MIXED"):
            continue
        if since and V.rank(e["to"]) < V.rank(since):
            continue
        out.append(Event(e["verdict"], f"balance/{e['kind']}", e["id"], e["from"], e["to"], f"[{e['source']}] " + describe(e)))
    return out
