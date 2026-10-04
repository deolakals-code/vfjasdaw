"""The character "Status -> Details" screen, decoded: every row it shows and the expression behind each value.

UIPlayerStatusDetailPanel builds the screen with Add*Status methods; every row is one call
    AddDataStatus(statusType, value, formatType, defaultValue, maxValue, minValue, subValue)
so the rows are read straight out of the calls (value = the expression, in terms of PlayerSecondaryStatus getters, BonusManager, buffs).
The Calc*Value helpers the panel uses for combined values are decoded the same way.

Run (cwd D:\\toram_re, Bash):  SYM_ENUMS=1 python "D:\\toram reverse data\\scripts\\decode_status_panel.py"
Writes D:\\toram reverse data\\player_status\\detail_panel.json   (+ a readable detail_panel.md)
"""
import os, sys, json, re

sys.path.insert(0, r"D:\toram_re")
os.environ.setdefault("SYM_ENUMS", "1")
import symexec as S
S.NAME_ENUMS = True
S.MASTERY_RECV = True          # GetMasteryParam keeps its receiver SkillMasteryList[uid] (player_status.clean turns it into MasteryParam(uid, id))
from run_skills import clean
import decode_fn as DF

OUT = r"D:\toram reverse data\player_status"
os.makedirs(OUT, exist_ok=True)
DUMP = open(r"D:\toram_re\dump_android\dump.cs", encoding="utf-8", errors="ignore").read()
CLS = "UIPlayerStatusDetailPanel"
ROWS = ["AddBasicStatus", "AddHpStatus", "AddBattleStatus", "AddCriticalStatus", "AddSpeedStatus", "AddRangeAttackStatus", "AddHateToRespawnStatus",
        "AddElementKillerStatus", "AddElementShieldStatus", "AddResistStatus", "AddBarrierStatus", "AddAbsoluteStatus", "AddBreakerStatus", "AddDamageStatus",
        "AddGrantStopStatus"]
HELPERS = ["CalcSubAtkValue", "CalcPhysicsResistBreakerValue", "CalcMagicResistBreakerValue", "CalcPowerDmgCutValue", "CalcMagicDmgCutValue", "CalcShortRangeValue",
           "CalcLongRangeValue", "CalcExpValue", "CalcPetExpValue", "CalcDropValue", "CalcAvoidBreakerValue", "CalcGuardBreakerValue",
           "CalcPhysicalPursuitValue", "CalcMagicPursuitValue"]


def paths_of(name, mp=2000, mi=200000):
    hits = DF.find(f"{CLS}$${name}")
    if len(hits) != 1: return None
    ex = S.Ex(hits[0], max_paths=mp, max_ins=mi)
    return ex, ex.run()


def calls_of(st):
    out = []
    for e in st.ev:
        if e[0] != "call": continue
        out.append((clean(e[1]), [clean(S.render(x)) for x in e[2]]))
    return out


def main():
    only = sys.argv[sys.argv.index("--only") + 1].split(",") if "--only" in sys.argv else None
    path = os.path.join(OUT, "detail_panel.json")
    result = json.load(open(path, encoding="utf-8")) if only else {"class": CLS, "methods": {}, "helpers": {}}          # --only: merge the named methods / helpers into the stored file
    for name in [n for n in ROWS if only is None or n in only]:
        got = paths_of(name)
        if not got: result["methods"][name] = {"error": "not found"}; continue
        ex, paths = got
        rows, seen = [], set()
        for st in paths:
            conds = [clean(c) for c in st.cond]
            for nm, args in calls_of(st):
                if not nm.endswith("AddDataStatus"): continue
                key = (tuple(args), tuple(conds))
                if key in seen: continue
                seen.add(key)
                rows.append({"args": args, "when": conds})
        result["methods"][name] = {"rows": rows, "paths": len(paths), "truncated": bool(ex.truncated)}
        print(f"{name:26} rows {len(rows):3}  paths {len(paths):4}  truncated {ex.truncated}")
    for name in [n for n in HELPERS if only is None or n in only]:
        got = paths_of(name)
        if not got: result["helpers"][name] = {"error": "not found"}; continue
        ex, paths = got
        cases = []
        is_float = re.search(rf"float {name}\(", DUMP) is not None          # a float function returns in s0 = ret[1]; ret[0] is whatever the last call left in w0
        for st in paths:
            ret = None if st.ret is None else clean(S.render(st.ret[1 if is_float else 0]))
            cases.append({"when": [clean(c) for c in st.cond], "ret": ret})
        result["helpers"][name] = {"cases": cases[:40], "paths": len(paths), "truncated": bool(ex.truncated)}
        print(f"{name:30} paths {len(paths):4}  truncated {ex.truncated}")
    json.dump(result, open(path, "w", encoding="utf-8"), ensure_ascii=False, indent=1)


if __name__ == "__main__":
    main()
