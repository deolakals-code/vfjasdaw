"""Re-decode the stat functions (groups player, weapon) whose text mentions GetMasteryParam, with the receivers kept (symexec.MASTERY_RECV), in place.

Why: `SkillMasteryBase.GetMasteryParam(id)` is a virtual call on the mastery that the preceding `SkillMasteryList.TryGetValue(uid, out m)` returned; the old text dropped the receiver, so the
calculator could not tell which learned skill a number belongs to. `harvest_stats.py` now sets the flag for new harvests; this script upgrades the files already on disk without a full harvest
(resumable harvest skips files that exist). Also covers `PlayerSecondaryStatus.get_Stable` (calls the abstract `CalcStable` on `mainWeaponCalculator`).
Run (cwd D:\\toram_re):  python "D:\\toram reverse data\\scripts\\redecode_stats_receivers.py"      then patch index.json entries if paths changed, then `render_stats.py`.
"""
import sys, os, json, glob, re, time

sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import symexec as S
S.MASTERY_RECV = True
import build_variables as B

OUT = r"D:\toram reverse data\skills\damage\stats\decoded"
by = {n: a for a, n in S.names.items()}
n = 0
for p in sorted(glob.glob(os.path.join(OUT, "player", "*.json")) + glob.glob(os.path.join(OUT, "weapon", "*.json"))):
    t = open(p, encoding="utf-8").read()
    if "GetMasteryParam" not in t and "WeaponTypeCalculatorBase" not in t:          # mastery receivers, or calls on a weapon calculator
        continue
    old = json.loads(t)
    a = by[old["name"]]
    t0 = time.time()
    rec = {"name": old["name"], "rva": hex(a), **B.decode(a)}
    json.dump(rec, open(p, "w", encoding="utf-8"), ensure_ascii=False)
    n += 1
    print(f"{time.time() - t0:5.1f}s {old['name']} trunc={rec.get('truncated')} receivers={len(re.findall(r'SkillMasteryList[[]', json.dumps(rec)))}", flush=True)
print("redecoded", n)
