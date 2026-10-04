"""Compare two states of the same kind of entry: {id: {field: value}} where a value is a number or a list of numbers
(per level). -> per-entry change lists with verdicts."""
from . import polarity


def pct(before, after):
    if before in (0, None) or after is None:
        return None
    return (after - before) / abs(before) * 100.0


def _num(x):
    return isinstance(x, (int, float)) and not isinstance(x, bool)


def field_change(kind, field, before, after, context=None):
    """One field. Lists are compared per level (index+1). -> dict or None when equal."""
    if before == after:
        return None
    if isinstance(before, (list, tuple)) or isinstance(after, (list, tuple)):
        b, a = list(before or []), list(after or [])
        levels = []
        for i in range(max(len(b), len(a))):
            x = b[i] if i < len(b) else None
            y = a[i] if i < len(a) else None
            if x == y:
                continue
            ok = _num(x) and _num(y)
            levels.append({"level": i + 1, "before": x, "after": y, "delta": (y - x) if ok else None,
                           "pct": pct(x, y) if ok else None,
                           "verdict": polarity.verdict(kind, field, x, y, context) if ok else "NEUTRAL"})
        if not levels:
            return None
        return {"field": field, "levels": levels, "verdict": polarity.combine(l["verdict"] for l in levels)}
    ok = _num(before) and _num(after)
    return {"field": field, "before": before, "after": after, "delta": (after - before) if ok else None,
            "pct": pct(before, after) if ok else None,
            "verdict": polarity.verdict(kind, field, before, after, context) if ok else "NEUTRAL"}


def compare(kind, old, new, id_field_ctx=None):
    """old/new: {id: {field: value}}. -> {"changed": {id: {...}}, "added": [ids], "removed": [ids]}."""
    changed = {}
    for k in sorted(set(old) & set(new), key=str):
        ctx = {**old[k], **new[k]}
        chs = []
        for f in sorted(set(old[k]) | set(new[k])):
            c = field_change(kind, f, old[k].get(f), new[k].get(f), ctx)
            if c:
                chs.append(c)
        if chs:
            changed[k] = {"changes": chs, "verdict": polarity.combine(c["verdict"] for c in chs)}
    return {"changed": changed, "added": sorted(set(new) - set(old), key=str), "removed": sorted(set(old) - set(new), key=str)}


def summarize_levels(change):
    """One line for a per-level change, e.g. 'Lv1-10: +10 to +30 (+6% to +12%)' or 'Lv10: 400 -> 450'."""
    lv = change["levels"]
    if all(l["delta"] is not None for l in lv):
        ds = [l["delta"] for l in lv]
        lo, hi = min(ds), max(ds)
        span = f"Lv{lv[0]['level']}" if len(lv) == 1 else f"Lv{lv[0]['level']}-{lv[-1]['level']}"
        f = lambda v: f"{v:+g}"  # noqa: E731
        return f"{span}: {f(lo)}" if lo == hi else f"{span}: {f(lo)} to {f(hi)}"
    return f"{len(lv)} levels changed"
