"""Symbolic-execute arbitrary methods and print paths. usage: python run_methods.py Class$$Method [...] [--paths N] [--ins N]"""
import sys
import run_skills as R

args = [a for a in sys.argv[1:] if not a.startswith("--")]
mp = int(sys.argv[sys.argv.index("--paths") + 1]) if "--paths" in sys.argv else 120
mi = int(sys.argv[sys.argv.index("--ins") + 1]) if "--ins" in sys.argv else 8000
args = [a for a in args if not a.isdigit()]
R.init()
S = R._G["S"]
byname = {}
for a, n in S.names.items():
    byname.setdefault(n, []).append(a)
for name in args:
    for a in byname.get(name, []):
        ex = S.Ex(a, max_paths=mp, max_ins=mi)
        paths = ex.run()
        print(f"##### {name} @{a:#x} paths={len(paths)} truncated={ex.truncated}")
        for i, p in enumerate(R.summarize(ex, paths)):
            print(f"-- path {i} cond: {p['cond'][:6]}")
            for k, v in p["fields"].items():
                print(f"     set {k} = {v[:200]}")
            for t in p["tpl"]:
                print(f"     tpl {t[0]}[{t[1]}] = {t[2][:200]}")
            for c in p["calls"]:
                if any(x in c[0] for x in ("get_deltaTime", "op_Implicit", "op_Equality", "op_Inequality", "Dictionary", "List`")): continue
                print(f"     call {c[0]} args={[x[:60] for x in c[1]]}")
