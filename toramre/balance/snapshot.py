"""Snapshots of the values that exist only for the build that was decoded: skill multipliers (rate / flat per level) and
buff tables (duration, parameters per level), from skills/damage/skill_levels.csv and buff_values.json.
They are the "before" of the NEXT update; the repo has no older build, so history starts with the first snapshot."""
import csv
import json
import os
import time

from toramre.core import paths

DIR = os.path.join(os.path.dirname(os.path.abspath(__file__)), "snapshots")
SKILL_DIR = os.path.join(paths.REPO, "skills", "damage")


def _nums(row, prefix, n=10):
    vals = [row.get(f"{prefix}_L{i}", "") for i in range(1, n + 1)]
    out = []
    for v in vals:
        try:
            out.append(float(v) if "." in v else int(v))
        except ValueError:
            out.append(None)
    while out and out[-1] is None:
        out.pop()
    return out


def read_rates(skill_dir=None):
    """{uid: {"rate": [...], "flat": [...]}} (only skills that have values)."""
    p = os.path.join(skill_dir or SKILL_DIR, "skill_levels.csv")
    out = {}
    if not os.path.exists(p):
        return out
    with open(p, encoding="utf-8-sig", newline="") as f:
        for r in csv.DictReader(f):
            e = {k: v for k, v in (("rate", _nums(r, "rate")), ("flat", _nums(r, "flat"))) if v}
            if e:
                out[r["uid"]] = e
    return out


def read_buffs(skill_dir=None):
    """{uid: {"<Class>/timer": [...], "<Class>/param:<Name>": [...]}} for buffs whose values are a plain per-level table."""
    p = os.path.join(skill_dir or SKILL_DIR, "buff_values.json")
    out = {}
    if not os.path.exists(p):
        return out
    with open(p, encoding="utf-8") as fh:
        data = json.load(fh)
    for uid, classes in data.get("skills", {}).items():
        e = {}
        for cls, d in classes.items():
            t = (d.get("timer") or {})
            if t.get("status") == "table" and t.get("v"):
                e[f"{cls}/timer"] = t["v"]
            for name, pv in (d.get("params") or {}).items():
                if pv.get("status") == "table" and pv.get("v"):
                    e[f"{cls}/param:{name}"] = pv["v"]
        if e:
            out[uid] = e
    return out


def take(label, build=None, data_version=None, skill_dir=None):
    return {"label": label, "build": build or "unknown", "data_version": data_version, "taken": time.strftime("%Y-%m-%d %H:%M"),
            "rate": read_rates(skill_dir), "buff": read_buffs(skill_dir)}


def path(label, directory=None):
    return os.path.join(directory or DIR, f"{label}.json")


def save(snap, directory=None):
    d = directory or DIR
    os.makedirs(d, exist_ok=True)
    with open(path(snap["label"], d), "w", encoding="utf-8") as f:
        json.dump(snap, f, ensure_ascii=False, separators=(",", ":"), sort_keys=True)
    return path(snap["label"], d)


def load(label, directory=None):
    with open(path(label, directory), encoding="utf-8") as f:
        return json.load(f)


def labels(directory=None):
    d = directory or DIR
    if not os.path.isdir(d):
        return []
    items = [load(f[:-5], d) for f in os.listdir(d) if f.endswith(".json")]
    return [s["label"] for s in sorted(items, key=lambda s: s["taken"])]


def compare(old, new):
    """Compare two snapshots -> {"rate": compare-result, "buff": compare-result}."""
    from . import diff
    return {k: diff.compare(k, old[k], new[k]) for k in ("rate", "buff")}
