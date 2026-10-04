"""Schema synthesis: find a schema that consumes every kept version of a table to the exact last byte.

Strategies (cheapest first; every candidate is verified by `grammar.parse` on ALL versions before it is accepted):
  anchor-fit   find record starts from an id that grows record by record, then explain the record lengths with
               one or two count fields (len = base + w1*n1 [+ w2*n2])
  small-search enumerate short record grammars (fixed fields, lists, strings) for small tables
Then `refine` splits raw blocks into typed fields from column statistics (types are Inferred, the layout is Code-checked
by the exact-EOF rule only when it holds on every version).
"""
import itertools
import struct

from . import grammar as G

CW = {"u8": 1, "u16": 2, "u32": 4}
MAX_REC = 4096   # longest record searched for an anchor
MAX_GAP = 64     # id gap allowed between consecutive records


def _rd(d, i, k):
    f, w = G.FIXED[k]
    return struct.unpack_from(f, d, i)[0] if 0 <= i and i + w <= len(d) else None


def headers(d):
    """(prefix, count kind, n) candidates, most plausible first."""
    out = []
    for k in ("u32", "u16", "u8"):
        for p in range(0, 5):
            n = _rd(d, p, k)
            if n and 1 < n <= len(d) // 2:
                out.append((p, k, n))
    return out


def chain(d, h, n, a, k):
    """Record starts from an id at record offset `a` (width k) that grows from record to record.
    Order of preference per step: the usual record length with id+1, the nearest id+1, the usual length with any larger id
    (id ranges jump, e.g. 10386 -> 30001 in GuildQuestMaster), the nearest id within MAX_GAP."""
    v = _rd(d, h + a, k)
    if v is None:
        return None
    starts, s, seen = [h], h, {}
    while len(starts) < n:
        hi = min(len(d) - a - CW[k] + 1, s + MAX_REC)
        usual = [L for L, _ in sorted(seen.items(), key=lambda kv: -kv[1])[:3]]
        at = lambda s2: _rd(d, s2 + a, k)  # noqa: E731
        nxt = next((s + L for L in usual if s + L < hi and at(s + L) == v + 1), None)
        if nxt is None:
            nxt = next((s2 for s2 in range(s + 1, hi) if at(s2) == v + 1), None)
        if nxt is None:
            nxt = next((s + L for L in usual if s + L < hi and (at(s + L) or 0) > v), None)
        if nxt is None:
            nxt = next((s2 for s2 in range(s + 1, hi) if at(s2) is not None and v < at(s2) <= v + MAX_GAP), None)
        if nxt is None:
            return None
        seen[nxt - s] = seen.get(nxt - s, 0) + 1
        v = at(nxt)
        starts.append(nxt)
        s = nxt
    return starts


def _fit_one(recs):
    """Explain record lengths by one count field. Yields (c, kind, w, base)."""
    L = [len(r) for r in recs]
    minl = min(L)
    for kind, cw in CW.items():
        for c in range(0, minl - cw + 1):
            cnt = [_rd(r, c, kind) for r in recs]
            pairs = {}
            for n_, l_ in zip(cnt, L):
                pairs.setdefault(n_, l_)
            if len(pairs) < 2:
                continue
            (n0, l0), (n1, l1) = sorted(pairs.items())[:2]
            if (l1 - l0) % (n1 - n0):
                continue
            w = (l1 - l0) // (n1 - n0)
            base = l0 - w * n0
            if w < 1 or base < c + cw:
                continue
            if all(l_ == base + w * n_ for n_, l_ in zip(cnt, L)):
                yield c, kind, w, base


def _fit_tag(recs, max_cases=16):
    """Record length decided by a tag byte (tagged union). Yields a schema record."""
    L = [len(r) for r in recs]
    for c in range(0, min(L)):
        m = {}
        ok = True
        for r, l_ in zip(recs, L):
            if m.setdefault(r[c], l_) != l_:
                ok = False
                break
        if ok and 1 < len(m) <= max_cases:
            yield [*_raw(c), {"t": "switch", "tag": "u8", "cases": {str(k): _raw(v - c - 1) for k, v in sorted(m.items())}}]


def _fit_tag_count(recs, max_cases=16):
    """Tagged union followed by a counted list: tag at c, a fixed case per tag, then count + elements, then a common tail.
    Each tag group is explained by `_fit_one`; the groups must agree on count width, element width and tail."""
    L = [len(r) for r in recs]
    for c in range(0, min(L)):
        groups = {}
        for r in recs:
            groups.setdefault(r[c], []).append(r)
        if not 1 < len(groups) <= max_cases:
            continue
        sols = {}
        for tag, rs in groups.items():
            sols[tag] = {(kind, w, base - cc - CW[kind]): cc for cc, kind, w, base in _fit_one(rs) if cc > c}
        common = set.intersection(*(set(v) for v in sols.values())) if all(sols.values()) else set()
        for kind, w, tail in sorted(common):
            cases = {str(t): _raw(sols[t][(kind, w, tail)] - c - 1) for t in sorted(groups)}
            yield [*_raw(c), {"t": "switch", "tag": "u8", "cases": cases},
                   {"t": "list", "count": kind, "elem": [{"t": "raw", "n": w}]}, *_raw(tail)]


def _fit_two(recs, max_w=48):
    """Two lists: count1 at c1, its elements right after it, count2 at q bytes after list 1. Yields a schema record."""
    L = [len(r) for r in recs]
    minl = min(L)
    for k1, cw1 in CW.items():
        for c1 in range(0, minl - cw1 + 1):
            n1 = [_rd(r, c1, k1) for r in recs]
            if len(set(n1)) < 2 or max(n1) > 4096:
                continue
            for w1 in range(1, max_w + 1):
                if any(c1 + cw1 + w1 * a > len(r) for a, r in zip(n1, recs)):
                    break
                for k2, cw2 in CW.items():
                    for q in range(0, 33):
                        n2 = [_rd(r, c1 + cw1 + w1 * a + q, k2) for a, r in zip(n1, recs)]
                        if None in n2 or len(set(n2)) < 2:
                            continue
                        rest = [l_ - w1 * a for l_, a in zip(L, n1)]
                        pairs = {}
                        for b_, r_ in zip(n2, rest):
                            pairs.setdefault(b_, r_)
                        (m0, r0), (m1, r1) = sorted(pairs.items())[:2]
                        if (r1 - r0) % (m1 - m0):
                            continue
                        w2 = (r1 - r0) // (m1 - m0)
                        base = r0 - w2 * m0
                        if w2 < 1 or base < c1 + cw1 + q + cw2:
                            continue
                        if all(r_ == base + w2 * b_ for b_, r_ in zip(n2, rest)):
                            tail = base - (c1 + cw1 + q + cw2)
                            yield [*_raw(c1), {"t": "list", "count": k1, "elem": [{"t": "raw", "n": w1}]}, *_raw(q),
                                   {"t": "list", "count": k2, "elem": [{"t": "raw", "n": w2}]}, *_raw(tail)]


def _raw(n):
    return [{"t": "raw", "n": n}] if n > 0 else []


def anchor_fit(versions, two=True, limit=40):
    """versions: list of bytes (distinct contents). Yields verified schemas."""
    d = max(versions, key=len)
    tried = 0
    for p, hk, n in headers(d):
        h = p + CW[hk]
        for k in ("u32", "u16", "u8"):
            if k == "u8" and n > 255:
                continue
            for a in range(0, 16):
                st = chain(d, h, n, a, k)
                if not st:
                    continue
                tried += 1
                if tried > limit:
                    return
                recs = [d[st[i]:st[i + 1]] for i in range(n - 1)] + [d[st[-1]:]]
                header = {"prefix": p, "count": hk}
                if len({len(r) for r in recs}) == 1:
                    cands = [[{"t": "raw", "n": len(recs[0])}]]
                else:
                    cands = [[*_raw(c), {"t": "list", "count": kind, "elem": [{"t": "raw", "n": w}]}, *_raw(base - c - CW[kind])]
                             for c, kind, w, base in _fit_one(recs)]
                    cands += list(_fit_tag(recs))
                    cands += list(itertools.islice(_fit_tag_count(recs), 50))
                    if two:
                        cands += list(itertools.islice(_fit_two(recs), 200))
                for rec in cands:
                    s = {"header": header, "record": rec}
                    if all(G.fits(v, s) for v in versions):
                        yield s, "anchor-fit"


def _small_items():
    fixed = [{"t": "raw", "n": n} for n in (1, 2, 3, 4, 5, 6, 8)]
    lists = [{"t": "list", "count": c, "elem": [{"t": "raw", "n": w}]} for c in ("u8", "u16", "u32") for w in (1, 2, 3, 4, 5, 6, 8)]
    strs = [{"t": "str", "len": c} for c in ("v7", "u8", "u16", "u32")]
    return strs + lists + fixed


def small_search(versions, max_items=3, max_bytes=4096):
    """Enumerate record grammars of up to `max_items` items for small tables."""
    if max(len(v) for v in versions) > max_bytes:
        return
    items = _small_items()
    hdrs = [{"prefix": 0, "count": "none"}] + [{"prefix": p, "count": k} for p, k, _ in headers(max(versions, key=len))]
    for size in range(1, max_items + 1):
        for rec in itertools.product(items, repeat=size):
            if not any(it["t"] in ("list", "str") for it in rec):
                continue  # all-fixed records are the framing heuristic's job
            for h in hdrs:
                s = {"header": h, "record": list(rec)}
                if all(G.fits(v, s) for v in versions):
                    yield s, "small-search"


def null_rate(schema, versions, samples=48, seed=7):
    """Share of byte-shuffled copies of the newest version that the schema also fits. A schema that fits shuffled bytes
    explains nothing; the evidence of a fit is how unlikely it is by chance."""
    import random
    rnd = random.Random(seed)
    d = bytearray(max(versions, key=len))
    hits = 0
    for i in range(samples):
        rnd.shuffle(d)
        hits += G.fits(bytes(d), schema)
        if hits >= 3:
            return hits / (i + 1)
    return hits / samples


BIG_RAW = 64  # a raw block longer than this explains nothing


def _items_raw(items, sizes):
    for it in items:
        if it["t"] == "raw":
            sizes.append(it["n"])
        elif it["t"] == "list":
            _items_raw(it["elem"], sizes)
        elif it["t"] == "switch":
            for c in it["cases"].values():
                _items_raw(c, sizes)
    return sizes


def unexplained(schema, versions):
    """Bytes held by over-long raw blocks, summed over the parsed newest version (switch cases counted as declared)."""
    d = max(versions, key=len)
    recs = len(G.parse(d, schema))
    big = sum(n for n in _items_raw(schema["record"], []) if n > BIG_RAW)
    return min(len(d), big * max(1, recs if big else 0)) / max(1, len(d))


def score(schema, versions):
    """Lower is better: fits by chance? -> share of bytes left in giant raw blocks -> more records explained ->
    a counted header -> shorter description (MDL-style tie break)."""
    counted = schema["header"].get("count", "none") != "none"
    recs = len(G.parse(max(versions, key=len), schema))
    return (round(null_rate(schema, versions), 2), round(unexplained(schema, versions), 2), _switch_cases(schema["record"]),
            -recs, 0 if counted else 1, len(G.describe(schema)))


def refine(schema, versions):
    """Split raw blocks into typed fields by column statistics (Inferred types)."""
    cols = {}

    def collect(items, recs, path):
        for idx, it in enumerate(items):
            if it["t"] == "raw":
                cols.setdefault(path + (idx,), []).extend(r[idx] for r in recs)
            elif it["t"] == "list":
                collect(it["elem"], [e for r in recs for e in r[idx]], path + (idx,))
            elif it["t"] == "switch":
                for k, case in it["cases"].items():
                    collect(case, [r[idx][1] for r in recs if str(r[idx][0]) == k], path + (idx, k))

    recs = [r for v in versions for r in G.parse(v, schema)]
    collect(schema["record"], recs, ())

    def split(blocks):
        n = len(blocks[0]) if blocks else 0
        out, o = [], 0
        hi = lambda j: [b[j] for b in blocks]  # noqa: E731
        while o < n:
            if (o + 4 <= n and o % 2 == 0 and set(hi(o + 3)) <= {0, 0xff}
                    and all(b < 0x20 or b >= 0xe0 for b in hi(o + 2)) and len(set(hi(o))) > 1):
                out.append({"t": "i32"}); o += 4
            elif o + 2 <= n and all(b < 0x20 or b >= 0xe0 for b in hi(o + 1)) and len(set(hi(o))) > 2:
                out.append({"t": "i16"}); o += 2
            else:
                out.append({"t": "u8"}); o += 1
        return out

    def rebuild(items, path):
        out = []
        for idx, it in enumerate(items):
            if it["t"] == "raw":
                out += split(cols.get(path + (idx,), [])) or [it]
            elif it["t"] == "list":
                out.append({**it, "elem": rebuild(it["elem"], path + (idx,))})
            elif it["t"] == "switch":
                out.append({**it, "cases": {k: rebuild(c, path + (idx, k)) for k, c in it["cases"].items()}})
            else:
                out.append(it)
        return out

    typed = {"header": schema["header"], "record": rebuild(schema["record"], ())}
    return typed if all(G.fits(v, typed) for v in versions) else schema


def code_hint(table, versions):
    """Verify record layouts built from the owner class's constructor / fields (text -> code link)."""
    from . import hints
    d = max(versions, key=len)
    hdrs = [{"prefix": p, "count": k} for p, k, _ in headers(d)] + [{"prefix": 0, "count": "none"}]
    for cls, names, rec in hints.candidates(table):
        for h in hdrs:
            s = {"header": h, "record": rec}
            if all(G.fits(v, s) for v in versions):
                s["names"] = names
                s["owner"] = cls
                yield s, "code-hint"


def _has_variable(items):
    return any(it["t"] in ("list", "str", "switch") for it in items)


def _switch_cases(items):
    n = 0
    for it in items:
        if it["t"] == "switch":
            n += len(it["cases"]) + sum(_switch_cases(c) for c in it["cases"].values())
        elif it["t"] == "list":
            n += _switch_cases(it["elem"])
    return n


def confidence(schema, versions):
    """'strong' only when the fit cannot be a coincidence: no shuffled copy fits, many records, nothing left in giant
    raw blocks, and either a variable part that every record had to satisfy or a counted header over many records."""
    d = max(versions, key=len)
    recs = len(G.parse(d, schema))
    nr = null_rate(schema, versions)
    counted = schema["header"].get("count", "none") != "none"
    var = _has_variable(schema["record"])
    cases = _switch_cases(schema["record"])
    distinct_sizes = len({len(v) for v in versions})
    ok = (nr == 0 and recs >= 16 and unexplained(schema, versions) == 0 and cases * 8 <= recs
          and (var or (counted and recs >= 64))
          and (counted or distinct_sizes >= 2))  # records-until-EOF on one size proves little
    return ("strong" if ok else "weak"), {"records": recs, "null_rate": nr, "switch_cases": cases, "counted": counted}


def synthesize(versions, table=None, max_candidates=30):
    """-> [(schema, strategy, confidence, stats)] verified on every version; strong first, then by score."""
    found, seen = [], set()
    # code-hint first (it also names the fields); the others in the order of their past success (kb/stats.json)
    from . import kb
    st = kb.stats()
    rate = lambda name: (st.get(name, {}).get("solved", 0) + 1) / (st.get(name, {}).get("tried", 0) + 2)  # noqa: E731
    rest = sorted([("anchor-fit", lambda: anchor_fit(versions)), ("small-search", lambda: small_search(versions))],
                  key=lambda g: -rate(g[0]))
    gens = ([code_hint(table, versions)] if table else []) + [make() for _, make in rest]
    for gen in gens:
        local = 0
        for s, how in itertools.islice(gen, 200):
            key = G.describe(s)
            if key in seen:
                continue
            seen.add(key)
            conf, st = confidence(s, versions)
            found.append((s, how, conf, st))
            local += 1
            if local >= max_candidates and any(f[2] == "strong" for f in found):
                break
        if any(f[2] == "strong" for f in found):
            break
    found.sort(key=lambda f: (f[2] != "strong", f[1] != "code-hint", score(f[0], versions)))
    return found
