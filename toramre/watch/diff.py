"""Compare consecutive versions of every history bundle and produce tagged events."""
import os

from toramre.core import paths, versions
from . import framing
from .tags import Event

ROW_LIMIT = 20  # ids listed per event


def _is_text(bundle):
    return bundle.startswith("GameScene_")


def _read(root, bundle, ver, table):
    return open(os.path.join(root, bundle, ver, table + ".dec"), "rb").read()


def _row_diff(a_rows, b_rows):
    ka = {(r[0], r[1], r[2]): r[3] for r in a_rows}
    kb = {(r[0], r[1], r[2]): r[3] for r in b_rows}
    added = sorted(set(kb) - set(ka), key=str)
    removed = sorted(set(ka) - set(kb), key=str)
    changed = sorted((k for k in set(ka) & set(kb) if ka[k] != kb[k]), key=str)
    return added, removed, changed


def _ids(keys):
    shown = [str(k[0]) for k in keys[:ROW_LIMIT]]
    return ",".join(shown) + (f",+{len(keys) - ROW_LIMIT}" if len(keys) > ROW_LIMIT else "")


def _schema_diff(ev, bundle, t, va, vb, a, b):
    """Record-level diff with a learned schema (toramre brain). Records are keyed by their first field (the id)."""
    from toramre.brain import grammar as G, kb
    known = kb.load(t)
    if not known:
        return False
    sch = known["schema"]
    if not G.fits(a, sch):
        return False
    if not G.fits(b, sch):
        ev.append(Event("LAYOUT_BROKEN", bundle, t, va, vb, "learned schema no longer fits (exact-EOF): relearn with `toramre brain solve`"))
        return True
    key = lambda r: repr(r[0])  # noqa: E731
    ra = {key(r): r for r in G.parse(a, sch)}
    rb = {key(r): r for r in G.parse(b, sch)}
    add = sorted(set(rb) - set(ra))
    rem = sorted(set(ra) - set(rb))
    chg = sorted(k for k in set(ra) & set(rb) if ra[k] != rb[k])
    names = sch.get("names") or []
    fields = set()
    for k in chg:
        for i, (x, y) in enumerate(zip(ra[k], rb[k])):
            if x != y:
                fields.add(names[i] if i < len(names) else f"#{i}")
    ids = lambda ks: ",".join(ks[:ROW_LIMIT]) + (f",+{len(ks) - ROW_LIMIT}" if len(ks) > ROW_LIMIT else "")  # noqa: E731
    ev.append(Event("CHANGED", bundle, t, va, vb,
                    f"+{len(add)} -{len(rem)} ~{len(chg)} records (schema); fields changed: {', '.join(sorted(fields)) or '-'}; "
                    f"added[{ids(add)}] changed[{ids(chg)}]"))
    return True


def compare_tables(bundle, va, vb, snap_a, snap_b, root):
    """Events between version va and vb of one bundle (snap_* = {table: {bytes, sha}})."""
    ev = []
    text = _is_text(bundle)
    for t in sorted(set(snap_a) | set(snap_b)):
        if t not in snap_a:
            ev.append(Event("NEW", bundle, t, va, vb, "table added"))
            continue
        if t not in snap_b:
            ev.append(Event("REMOVED", bundle, t, va, vb, "table removed"))
            continue
        if snap_a[t]["sha"] == snap_b[t]["sha"]:
            continue
        a, b = _read(root, bundle, va, t), _read(root, bundle, vb, t)
        if text:
            ra, rb = framing.text_rows(a), framing.text_rows(b)
            if ra and not rb:
                ev.append(Event("LAYOUT_BROKEN", bundle, t, va, vb, "text table no longer parses (exact-EOF)"))
            elif ra and rb:
                add, rem, chg = _row_diff(ra[1], rb[1])
                ev.append(Event("TEXT_CHANGED", bundle, t, va, vb,
                                f"+{len(add)} -{len(rem)} ~{len(chg)} rows; added[{_ids(add)}] changed[{_ids(chg)}]"))
            else:
                ev.append(Event("TEXT_CHANGED", bundle, t, va, vb, f"{len(a)} -> {len(b)} bytes"))
        elif _schema_diff(ev, bundle, t, va, vb, a, b):
            pass
        else:
            fa, fb = framing.master_frame(a), framing.master_frame(b)
            if fa and not fb:
                ev.append(Event("LAYOUT_BROKEN", bundle, t, va, vb,
                                "fixed-width framing lost (heuristic framing: check the table's own parser)"))
            elif fa and fb and fa[2] != fb[2]:
                ev.append(Event("CHANGED", bundle, t, va, vb,
                                f"framing width {fa[2]} -> {fb[2]} (records {fa[1]} -> {fb[1]}; heuristic, may be a count change)"))
            elif fa and fb:
                ra = [a[fa[0] + i * fa[2]: fa[0] + (i + 1) * fa[2]] for i in range(fa[1])]
                rb = [b[fb[0] + i * fb[2]: fb[0] + (i + 1) * fb[2]] for i in range(fb[1])]
                chg = [i for i in range(min(len(ra), len(rb))) if ra[i] != rb[i]]
                ev.append(Event("CHANGED", bundle, t, va, vb,
                                f"records {fa[1]} -> {fb[1]}, {len(chg)} records differ (idx {chg[:ROW_LIMIT]})"))
            else:
                ev.append(Event("CHANGED", bundle, t, va, vb, f"variable width, {len(a)} -> {len(b)} bytes"))
    return ev


def diff_snapshot(snap, root=None, since=None):
    """Events for every consecutive version pair. `since` = only pairs whose newer version is that version or later."""
    root = root or paths.DECODED
    out = []
    for b, vers in snap["bundles"].items():
        order = [v for v in versions.list_versions(b, root) if v in vers]
        for va, vb in zip(order, order[1:]):
            if since and versions.rank(vb) < versions.rank(since):
                continue
            out += compare_tables(b, va, vb, vers[va], vers[vb], root)
    return out


def diff_extra(old, new):
    """Facts outside the data layer, e.g. the libil2cpp.so hash."""
    ev = []
    for k in sorted(set(old) | set(new)):
        if old.get(k) != new.get(k):
            tag = "BINARY_CHANGED" if k.endswith("sha256") else "CHANGED"
            ev.append(Event(tag, "extra", k, str(old.get(k))[:12], str(new.get(k))[:12], "differs from stored baseline"))
    return ev
