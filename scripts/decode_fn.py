"""Symbolically execute any client method by name and print its paths.
usage (cwd D:\\toram_re): python decode_fn.py <substring | Class$$Method> [max_paths] [max_ins]
Lists matching names when the argument is ambiguous.
"""
import sys, json, os, re
import symexec as S
S.NAME_ENUMS = bool(os.environ.get("SYM_ENUMS"))
if os.environ.get("SYM_INLINE"):
    _rx = re.compile(os.environ["SYM_INLINE"])
    S.INLINE = lambda n: bool(_rx.search(n))
from run_skills import clean


def find(q):
    if q.startswith("0x"): return [int(q, 16)]
    ex = [a for a, n in S.names.items() if n == q]
    return ex or [a for a, n in S.names.items() if q in n]


def run(a, mp=400, mi=40000):
    ex = S.Ex(a, max_paths=mp, max_ins=mi)
    paths = ex.run()
    out = []
    for st in paths:
        sets = {}
        for e in st.ev:
            if e[0] == "set": sets[e[1]] = clean(S.render(e[2]))
        calls = [clean(e[1]) + "(" + ", ".join(clean(S.render(x)) for x in e[2][:5]) + ")" for e in st.ev
                 if e[0] == "call" and not any(k in e[1] for k in ("TypeInfo", "il2cpp"))]
        ret = None
        if st.ret is not None: ret = [clean(S.render(st.ret[0])), clean(S.render(st.ret[1]))]
        out.append({"cond": [clean(c) for c in st.cond], "ret": ret, "sets": sets, "calls": calls,
                    "trunc": any(e[0] == "truncated" for e in st.ev)})
    return ex, out


if __name__ == "__main__":
    q = sys.argv[1]
    mp = int(sys.argv[2]) if len(sys.argv) > 2 else 400
    mi = int(sys.argv[3]) if len(sys.argv) > 3 else 40000
    hits = find(q)
    if len(hits) != 1:
        for a in hits[:60]: print(hex(a), S.names[a])
        print(len(hits), "matches"); sys.exit()
    ex, out = run(hits[0], mp, mi)
    print(S.names[hits[0]], "params", [(t, n) for t, n in S.D2.SIG.get(hits[0], (False, []))[1]], "paths", len(out), "truncated", ex.truncated)
    for i, p in enumerate(out):
        print(f"--- path {i}")
        for c in p["cond"]: print("  if", c[:240])
        if p["sets"]: print("  sets", json.dumps(p["sets"], ensure_ascii=False)[:600])
        if p["calls"]: print("  calls", "; ".join(p["calls"])[:600])
        print("  ret", p["ret"])
