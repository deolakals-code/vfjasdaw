"""Symbolic-execute every function that reads a skill by constant id (skill_consumers.json) and keep the paths guarded by that skill.
usage: python run_consumers.py  -> consumer_effects.json {uid: [{fn, paths:[{cond,ret,fields,tpl,calls}], truncated}]}
"""
import os, re, sys, json, collections
from multiprocessing import Pool
import run_skills as R

OUT = r"D:\toram_re\consumer_effects.json"
MAXP = int(os.environ.get("SYM_PATHS", 300))
MAXI = int(os.environ.get("SYM_INS", 30000))
SKIP = ("get_deltaTime", "op_Implicit", "op_Equality", "op_Inequality", "Dictionary", "List`", "TypeInfo", "il2cpp", "GetSkillLv", "TryGetBuf", "ContainsBuffer")
UI = re.compile(r"^(UI|Ui)|Manager\$\$(Initialize|Setup|Refresh|Update)List|SkillTreeList|ExSkillList")


def work(job):
    fn, uids, addr = job
    S = R._G["S"]
    res = {}
    try:
        ex = S.Ex(addr, max_paths=MAXP, max_ins=MAXI)
        paths = ex.run()
        summ = R.summarize(ex, paths)
        for st, sm in zip(paths, summ):
            conds = sm["cond"]
            for uid in uids:
                rx = re.compile(rf"(TryGetBuf|GetSkillLv|ContainsBuffer)\(.{{0,240}}?\b{uid}\b")
                retstr = R.clean(S.render(st.ret[0])) if st.ret is not None else ""
                if not any(rx.search(c) for c in conds) and not rx.search(retstr): continue
                ent = {"cond": conds[:10], "fields": {k: v[:240] for k, v in list(sm["fields"].items())[:12]},
                       "tpl": [(t[0], t[1], t[2][:240]) for t in sm["tpl"]][:8],
                       "calls": [c[0] for c in sm["calls"] if not any(x in c[0] for x in SKIP)][:14]}
                if st.ret is not None:
                    ent["ret"] = retstr[:1500]
                res.setdefault(uid, []).append(ent)
        return fn, {u: {"paths": p[:40], "npaths": len(p)} for u, p in res.items()}, bool(ex.truncated), None
    except Exception as e:
        return fn, {}, False, repr(e)


if __name__ == "__main__":
    cons = json.load(open(r"D:\toram_re\skill_consumers.json", encoding="utf-8"))
    fn_uids = collections.defaultdict(set)
    for u, lst in cons.items():
        for c in lst:
            if not UI.search(c["fn"]): fn_uids[c["fn"]].add(int(u))
    R.init()
    S = R._G["S"]
    byname = collections.defaultdict(list)
    for a, n in S.names.items(): byname[n].append(a)
    jobs = [(fn, sorted(us), a) for fn, us in fn_uids.items() for a in byname.get(fn, [])[:1]]
    print(len(jobs), "functions", flush=True)
    out = collections.defaultdict(list)
    errs = 0
    with Pool(10, initializer=R.init) as p:
        for fn, per_uid, trunc, err in p.imap_unordered(work, jobs):
            if err: errs += 1; continue
            for u, d in per_uid.items():
                out[u].append({"fn": fn, "truncated": trunc, **d})
    json.dump({str(k): v for k, v in sorted(out.items())}, open(OUT, "w", encoding="utf-8"), ensure_ascii=False)
    print("wrote", OUT, len(out), "uids,", errs, "function errors")
