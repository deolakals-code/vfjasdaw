"""Symbolic-execute the crafting-skill consumer functions with no skill-id path filter and print every path.
usage: python run_craft_consumers.py Fn$$Name [...]  (defaults to the 9 open crafting skills' consumers)"""
import sys, json, collections
import run_skills as R

DEFAULT = ["SmithProcessingDialog$$UpdateTotal", "UILibraryList$$getNextReleaseSkillCount", "SmithGrantInfoWindow$$CalcUnderstandSkill",
           "SyntheticMedicine$$getMaterialRate", "UIColorSynthesisMainManager$$GetColorSkillLevels",
           "UIColorSynthesisSelectEquipPanel$$IsTargetUnlocked", "UIStockColorCreatePanel$$GetPrintSuccessRate"]

if __name__ == "__main__":
    R.init(); S = R._G["S"]
    byname = collections.defaultdict(list)
    for a, n in S.names.items(): byname[n].append(a)
    out = {}
    for fn in (sys.argv[1:] or DEFAULT):
        for a in byname.get(fn, [])[:1]:
            ex = S.Ex(a, max_paths=2000, max_ins=200000)
            paths = ex.run(); summ = R.summarize(ex, paths)
            res = []
            for st, sm in zip(paths, summ):
                res.append({"cond": sm["cond"], "ret": R.clean(S.render(st.ret[0])) if st.ret is not None else None,
                            "calls": [c[0] for c in sm["calls"]]})
            out[fn] = {"npaths": len(paths), "truncated": bool(ex.truncated), "paths": res}
            print(fn, hex(a), len(paths), "truncated" if ex.truncated else "ok", flush=True)
        else:
            if fn not in byname: print(fn, "NOT FOUND")
    json.dump(out, open(r"D:\toram_re\craft_consumers.json", "w", encoding="utf-8"), ensure_ascii=False, indent=1)
