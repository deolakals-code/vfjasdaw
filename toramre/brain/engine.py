"""The chain engine: a worklist of open items (frontier). Each item is solved from the knowledge base if a stored rule
still fits, otherwise by synthesis; a strong result is learned (kb), anything else stays on the frontier with the reason
and the next link to follow (owner classes and their constructor RVAs)."""
import hashlib
import json
import os
import time

from toramre.core import paths, versions as V
from toramre.watch import framing
from . import grammar as G, guard, kb, synth


def table_versions(table, bundle="BynaryData"):
    """Distinct contents of a master table over every kept version -> {sha: (first version, bytes)}."""
    out = {}
    for v in V.list_versions(bundle):
        p = os.path.join(paths.DECODED, bundle, v, table + ".dec")
        if not os.path.exists(p):
            continue
        guard.check_path(p)
        b = open(p, "rb").read()
        guard.check_data(f"{bundle}/{v}/{table}", b)
        out.setdefault(hashlib.sha1(b).hexdigest()[:12], (v, b))
    return out


def frontier(bundle="BynaryData"):
    """Open items: tables of the newest version that are neither fixed-width nor already known (or whose known schema
    stopped fitting)."""
    vs = V.list_versions(bundle)
    if not vs:
        return []
    newest = os.path.join(paths.DECODED, bundle, vs[-1])
    items = []
    for fn in sorted(os.listdir(newest)):
        t = fn[:-4]
        d = open(os.path.join(newest, fn), "rb").read()
        known = kb.load(t)
        if known and G.fits(d, known["schema"]):
            continue
        fr = None if known else framing.master_frame(d)
        if fr and fr[1] >= 16 and fr[2] <= 512:
            continue  # plausible fixed-width framing (count >= 16 records of <= 512 bytes)
        why = ("known schema no longer fits" if known else
               f"heuristic framing only ({fr[1]} records x {fr[2]} bytes)" if fr else "variable width")
        items.append({"table": t, "bytes": len(d), "why": why})
    return items


def solve(table, learn=True):
    vers = table_versions(table)
    blobs = [b for _, b in vers.values()]
    known = kb.load(table)
    if known and all(G.fits(b, known["schema"]) for b in blobs):
        kb.record("kb-reuse", True)
        return {"table": table, "status": "known", "schema": known["schema"], "strategy": known["strategy"]}
    t0 = time.time()
    found = synth.synthesize(blobs, table=table)
    res = {"table": table, "seconds": round(time.time() - t0, 1), "versions": len(vers)}
    if found and found[0][2] == "strong":
        s, how, conf, st = found[0]
        typed = s if how == "code-hint" else synth.refine(s, blobs)
        entry = {"schema": typed, "strategy": how, "confidence": conf, "stats": st, "describe": G.describe(typed),
                 "evidence": {"rule": "exact-EOF on every distinct version", "versions": sorted(v for v, _ in vers.values()),
                              "label": "Code-checked layout; field types Inferred" if how != "code-hint"
                              else "Code (constructor signature of the owner class) + exact-EOF"},
                 "alternatives": [G.describe(f[0]) for f in found[1:4]]}
        if learn:
            kb.save(table, entry)
        kb.record(how, True)
        res.update(status="learned", **{k: entry[k] for k in ("strategy", "describe", "stats")})
        return res
    for f in found[:1]:
        kb.record(f[1], False)
    from . import hints
    owners = hints.owners(table)
    idx = hints.index()
    res.update(status="open", candidates=[{"describe": G.describe(f[0]), "strategy": f[1], "confidence": f[2], "stats": f[3]}
                                          for f in found[:3]],
               next=[{"class": c, "file": idx[c]["path"], "ctors": [", ".join(f"{t} {n}" for t, n in sig) for sig in idx[c]["ctors"]][:2]}
                     for c in owners[:4]],
               why=("only weak fits (could be coincidence)" if found else "no layout found by anchor-fit, small-search or code-hint")
               + "; next: decode the loader body of the owner class (scripts/symexec on the machine with libil2cpp.so)")
    return res


def run(tables=None, learn=True, out=None):
    items = [{"table": t} for t in tables] if tables else frontier()
    results = [solve(it["table"], learn=learn) for it in items]
    out = out or os.path.join(paths.STATE, "frontier.json")
    os.makedirs(os.path.dirname(out), exist_ok=True)
    json.dump(results, open(out, "w"), indent=1, ensure_ascii=False)
    return results


def decode_table(table, version=None, bundle="BynaryData"):
    """Parse one table with its learned schema -> (names or None, records)."""
    known = kb.load(table)
    if not known:
        raise KeyError(f"{table}: no learned schema")
    v = version or V.list_versions(bundle)[-1]
    d = open(os.path.join(paths.DECODED, bundle, v, table + ".dec"), "rb").read()
    return known["schema"].get("names"), G.parse(d, known["schema"])
