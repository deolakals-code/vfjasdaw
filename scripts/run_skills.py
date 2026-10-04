"""Batch: symbolic-execute the damage/buff related methods of every skill Action class.
usage: python run_skills.py [uid ...]      -> D:\\toram_re\\skillrecipes\\<uid>_<Class>.json
"""
import sys, os, json, re, struct, bisect, time, traceback
from multiprocessing import Pool

MAXP = int(os.environ.get("SYM_PATHS", 80))
MAXI = int(os.environ.get("SYM_INS", 5000))
OUTDIR = os.environ.get("SYM_OUT", r"D:\toram_re\skillrecipes")
os.makedirs(OUTDIR, exist_ok=True)

_G = {}


def init():
    import symexec as S
    _G["S"] = S
    m = {}
    for a, n in S.names.items():
        if "$$" in n:
            c, mm = n.split("$$", 1)
            m.setdefault(c, []).append((a, mm))
    _G["m"] = m
    tgt = {a for a, n in S.names.items()
           if n.split("$$")[0] == "SkillCalcTemplate" and n.split("$$")[-1] in S.TPL}
    buf = {a for a, n in S.names.items() if n.split("$$")[-1] in (
        "AddSelfBuffer", "AddBuffer", "AddBuf", "AddSkillBuffer", "AddPartyBuffer", "AddBufferData") }
    _G["tgt"], _G["buf"] = tgt, buf


def has_call(rva, targets):
    S = _G["S"]
    i = bisect.bisect_right(S.starts, rva)
    end = min(S.starts[i] if i < len(S.starts) else rva + 0x400, rva + 0x8000)
    for off in range(rva, end, 4):
        w = struct.unpack_from("<I", S.b, off - S.OFF)[0]
        if w >> 26 == 0b100101:
            imm = w & 0x3ffffff
            if imm >> 25: imm -= 1 << 26
            if off + imm * 4 in targets: return True
    return False


ISINST = re.compile(r"\(\[\(\[\[actarAction\+0x0\]\+0xc8\] \+ \(meta\(0\) << 3\)\)\+-0x8\] eq meta\(0\) \? actarAction : 0\)")


def clean(s):
    s = re.sub(r"<(\w+)>k__BackingField", r"\1", s)
    s = ISINST.sub("player", s)
    s = re.sub(r"PlayerAttackBase\.GetWeaponType\(player, [^)]*\)", "WeaponType", s)
    s = s.replace("this.Level", "Lv").replace("this.", "")
    return s


def summarize(ex, paths, dedupe=False):
    S = _G["S"]
    R = S.render
    out = []
    seen = set()
    for st in paths:
        final = {}
        for e in st.ev:
            if e[0] == "set": final[e[1]] = R(e[2])
        tpl = [(e[1], str(e[2]), clean(R(e[3])), [clean(c) for c in e[4]]) for e in st.ev if e[0] == "tpl"]
        calls = []
        for e in st.ev:
            if e[0] == "call":
                nm = e[1]
                if any(k in nm for k in ("TypeInfo", "il2cpp")): continue
                calls.append((nm, [clean(R(x)) for x in e[2][:4]], [clean(R(x)) for x in e[3][:2]]))
        rec = {"cond": [clean(c) for c in st.cond], "fields": {clean(k): clean(v) for k, v in final.items()},
               "tpl": tpl, "calls": calls[:80], "n": st.n, "trunc": any(e[0] == "truncated" for e in st.ev)}
        if dedupe:   # raised caps explode into identical paths (NormalAttackAction 19 MB -> 2.7 GB)
            sig = json.dumps([rec["cond"], rec["fields"], rec["tpl"], rec["calls"], rec["trunc"]], sort_keys=True)
            if sig in seen: continue
            seen.add(sig)
        out.append(rec)
    return out


def analyze_buf(cls):
    S = _G["S"]
    out = {}
    ms = [(a, mm) for a, mm in _G["m"].get(cls, []) if mm not in ("get_SkillId",)][:14]
    for k, (a, mm) in enumerate(ms):
        try:
            ex = S.Ex(a, max_paths=60, max_ins=4000)
            paths = ex.run()
            if ex.truncated:
                ex = S.Ex(a, max_paths=20000, max_ins=100000)
                paths = ex.run()
            sm = summarize(ex, paths)
            for st, p_ in zip(paths, sm):
                if st.ret is not None:
                    p_["ret"] = [clean(S.render(st.ret[0])), clean(S.render(st.ret[1]))]
            out[f"{mm}@{a:#x}"] = {"paths": sm, "truncated": ex.truncated, "params": [(t, n) for t, n in S.D2.SIG.get(a, (False, []))[1]]}
        except Exception as e:
            out[f"{mm}@{a:#x}"] = {"error": repr(e)}
    return out


def work(job):
    uid, cls = job
    S = _G["S"]
    EX = S.MergeEx if os.environ.get("SYM_MERGE") else S.Ex   # forward-merging executor for path-explosion skills (uid 0, 17)
    res = {"uid": uid, "cls": cls, "methods": {}}
    t0 = time.time()
    cand = []
    mlist = list(_G["m"].get(cls, []))
    for k, v in _G["m"].items():
        if k.startswith(cls + "."):
            mlist += [(a, k[len(cls):] + "::" + mm) for a, mm in v]
    for a, mm in mlist:
        base = mm.split("::")[-1]
        if base.startswith(("get_", "set_", ".cctor", ".ctor", "add_", "remove_")) or base in ("Equals", "GetHashCode", "ToString"):
            continue
        cand.append((a, mm))
    seen = set()
    chain = set(S.D2.chain(cls)) - {"SkillActionBase", "Object"}
    queue = list(cand)
    depth = {a: 0 for a, _ in cand}
    while queue:
        a, mm = queue.pop(0)
        if a in seen: continue
        seen.add(a)
        try:
            ex = EX(a, max_paths=MAXP, max_ins=MAXI)
            paths = ex.run()
            if ex.truncated:   # caps hide data (PROJECT.md rule 4): retry once with the raised caps
                ex = EX(a, max_paths=20000, max_ins=100000)
                paths = ex.run()
            res["methods"][mm + f"@{a:#x}"] = {"paths": summarize(ex, paths, dedupe=True), "truncated": ex.truncated}
            if depth[a] < 3:
                for st in paths:
                    for e in st.ev:
                        if e[0] == "call" and len(e) > 5:
                            t = e[5]; nm = e[1]; c2, _, m2 = nm.partition("$$")
                            if t in seen or t in depth: continue
                            if m2 == "TemplateAssignment" or m2.startswith("TemplateAssignment"): continue
                            if (c2 in chain or c2.startswith(cls + ".")) and (has_call(t, _G["tgt"]) or has_call(t, _G["buf"])):
                                depth[t] = depth[a] + 1
                                queue.append((t, f"via {nm}"))
        except Exception as e:
            res["methods"][mm + f"@{a:#x}"] = {"error": repr(e)}
    bufs = set()
    for mkey, v in res["methods"].items():
        for p_ in v.get("paths", []):
            for c in p_["calls"]:
                nm = c[0]
                if nm.endswith("$$.ctor"):
                    c2 = nm[:-len("$$.ctor")]
                    if c2.endswith(("Buf", "Buffer", "Bufa")) or "SkillBufferDataBase" in S.D2.chain(c2) or "CountBufferBase" in S.D2.chain(c2):
                        bufs.add(c2)
    res["buffs"] = {}
    for bcls in sorted(bufs)[:8]:
        res["buffs"][bcls] = analyze_buf(bcls)
    res["sec"] = round(time.time() - t0, 1)
    path = os.path.join(OUTDIR, f"{uid:04d}_{cls}.json")
    json.dump(res, open(path, "w", encoding="utf-8"), ensure_ascii=False)
    return uid, cls, res["sec"], len(cand)


if __name__ == "__main__":
    fac = {int(k): v for k, v in json.load(open(r"D:\toram_re\state\_factory_map.json")).items()}
    ids = [int(x) for x in sys.argv[1:]] or sorted(fac)
    jobs = [(i, fac[i]) for i in ids if i in fac]
    with Pool(10, initializer=init) as p:
        for r in p.imap_unordered(work, jobs):
            print(*r, flush=True)
