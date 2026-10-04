import json, os, sys, glob, tempfile
import run_skills as R
scr = os.environ["SCR"]
old_out = R.OUTDIR
R.init()
R.OUTDIR = scr
fac = {int(k): v for k, v in json.load(open(r"D:\toram_re\state\_factory_map.json")).items()}
same = diff = 0
for uid in [int(x) for x in sys.argv[1:]]:
    if uid not in fac: print(uid, "no factory"); continue
    R.work((uid, fac[uid]))
    new = json.load(open(os.path.join(scr, f"{uid:04d}_{fac[uid]}.json"), encoding="utf-8"))
    po = glob.glob(os.path.join(old_out, f"{uid:04d}_*.json"))
    if not po: print(uid, "no old file"); continue
    old = json.load(open(po[0], encoding="utf-8"))
    for d in (old, new): d.pop("sec", None)
    if old == new: same += 1; print(uid, "identical")
    else:
        diff += 1
        ks = [k for k in set(old["methods"]) | set(new["methods"]) if old["methods"].get(k) != new["methods"].get(k)]
        print(uid, "DIFF methods:", ks[:4], "buffs equal:", old.get("buffs") == new.get("buffs"))
print("same", same, "diff", diff)
