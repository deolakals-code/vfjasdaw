"""Calculators for the viewer. Only what runs without the author's D:\\ layout is wired:
  proration   proration_calculator/calculator.py (pure Python state machine, formula source: calc Reverse/proration)
Not wired yet (their scripts load files from fixed D:\\ paths): damage (scripts/calc_engine.py) and Details status
(scripts/player_status.py); `capabilities()` says so instead of failing.
Claims: a value the user saw in the game next to what the calculator gave -> state/claims.json."""
import importlib.util
import json
import os
import threading
import time

from toramre.core import paths

CALC_PATH = os.path.join(paths.REPO, "proration_calculator", "calculator.py")
CLAIMS = os.path.join(paths.STATE, "claims.json")
SLOT_OF_FIELD = {"proration_normal": "Normal", "proration_physical": "Skill", "proration_magic": "Magic"}
_mod = None
_lock = threading.Lock()


def _calc():
    global _mod
    if _mod is None:
        spec = importlib.util.spec_from_file_location("proration_calculator_calculator", CALC_PATH)
        m = importlib.util.module_from_spec(spec)
        spec.loader.exec_module(m)
        _mod = m
    return _mod


def _fixed_paths(rel):
    """'' when the script exists and has no fixed D:\\ path, else the reason."""
    p = os.path.join(paths.REPO, *rel.split("/"))
    if not os.path.exists(p):
        return "file missing"
    with open(p, encoding="utf-8", errors="replace") as f:
        return "reads fixed D:\\ paths; not usable outside the author's layout yet" if "D:" + chr(92) in f.read() else ""


def capabilities():
    out = {"proration": {"available": os.path.exists(CALC_PATH), "reason": "", "source": "proration_calculator/calculator.py"}}
    for name, rel in (("damage", "scripts/calc_engine.py"), ("status", "scripts/player_status.py")):
        why = _fixed_paths(rel)
        out[name] = {"available": not why, "reason": why, "source": rel}
    return out


def proration(steps, hits):
    """steps = (normal, skill, magic) step sizes; hits = list of 'Normal' | 'Skill' | 'Magic'.
    -> [{"hit", "slot", "state_before", "state_after", "multiplier_before", "multiplier_after"}]. The game's order of use
    (state before or after the hit's own update) is an open point in calc Reverse/proration/evidence.md: both are returned."""
    m = _calc()
    if len(steps) != 3 or any(not isinstance(s, int) or s < 0 or s > 1000 for s in steps):
        raise ValueError("steps must be three integers 0..1000: normal, skill, magic")
    if not hits or len(hits) > 200 or any(h not in m.SLOTS for h in hits):
        raise ValueError(f"hits must be 1..200 entries of {', '.join(m.SLOTS)}")
    ps = m.ProrationSteps(*steps)
    before, out = {s: 100 for s in m.SLOTS}, []
    for i, slot in enumerate(hits, 1):
        after = m.calc_exp_def(before, ps, slot)
        out.append({"hit": i, "slot": slot, "state_before": dict(before), "state_after": dict(after),
                    "multiplier_before": m.damage_multiplier(before, slot), "multiplier_after": m.damage_multiplier(after, slot)})
        before = after
    return out


def steps_for_monster(row):
    return tuple(int(row.get(f, 0) or 0) for f in SLOT_OF_FIELD)


def load_claims(path=None):
    p = path or CLAIMS
    if not os.path.exists(p):
        return []
    with open(p, encoding="utf-8") as f:
        return json.load(f)


def add_claim(tool, inputs, computed, seen, note="", path=None):
    """Store a pair (computed, seen in game). status: 'In-game' when they match within 0.5%, else 'Mismatch' (a bug to chase)."""
    if tool not in ("proration", "damage", "status"):
        raise ValueError("unknown tool")
    try:
        computed, seen = float(computed), float(seen)
    except (TypeError, ValueError):
        raise ValueError("computed and seen must be numbers")
    ok = abs(computed - seen) <= max(abs(seen) * 0.005, 1e-9)
    entry = {"tool": tool, "inputs": inputs, "computed": computed, "seen": seen, "status": "In-game" if ok else "Mismatch",
             "note": str(note)[:300], "at": time.strftime("%Y-%m-%d %H:%M:%S")}
    p = path or CLAIMS
    with _lock:
        claims = load_claims(p)
        claims.append(entry)
        os.makedirs(os.path.dirname(p), exist_ok=True)
        tmp = p + ".tmp"
        with open(tmp, "w", encoding="utf-8") as f:
            json.dump(claims, f, ensure_ascii=False, indent=1)
        os.replace(tmp, p)
    return entry
