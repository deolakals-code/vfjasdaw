import sys, json, os, re
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import symexec as S
from refutil import ENUM, evaluate

OUT = r"D:\toram_re\masteryrecipes"
os.makedirs(OUT, exist_ok=True)
MID = ENUM.get("MasteryId", {})
mm = {int(k): v for k, v in json.load(open(r"D:\toram_re\state\_mastery_map.json")).items()}
byclass = {}
for a, n in S.names.items():
    if "$$" in n:
        c, m = n.split("$$", 1)
        byclass.setdefault(c, []).append((a, m))


def fix(v):
    v = re.sub(r"\[this\.skillData\+0x18\]", "Lv", v)
    v = re.sub(r"\[this\.skillData\+0x1c\]", "skillId", v)
    v = v.replace("this.<Level>k__BackingField", "Lv")
    return v


res = {}
for uid, cls in sorted(mm.items()):
    rec = {"uid": uid, "class": cls, "params": [], "other": {}}
    for a, m in byclass.get(cls, []):
        if m == "GetMasteryParam":
            ex = S.Ex(a, max_paths=80); ps = ex.run()
            for st in ps:
                if st.ret is None: continue
                conds = list(st.cond)
                ids = [c for c in conds if c.startswith("id eq ")]
                rec["params"].append({"cond": [fix(c) for c in conds], "value": fix(S.render(st.ret[0])), "valuef": fix(S.render(st.ret[1]))})
        elif m not in (".ctor", "get_SkillId"):
            ex = S.Ex(a, max_paths=40); ps = ex.run()
            rec["other"][m] = [{"cond": [fix(c) for c in st.cond],
                                "fields": {e[1]: fix(S.render(e[2])) for e in st.ev if e[0] == "set"},
                                "ret": fix(S.render(st.ret[0])) if st.ret else None} for st in ps][:6]
    # by-level tables
    tab = {}
    for p in rec["params"]:
        m = re.findall(r"id eq (\d+)", " ".join(p["cond"]))
        if not m: continue
        neg = [c for c in p["cond"] if c.startswith("id ne")]
        k = int(m[-1])
        vals = [evaluate(p["value"], Lv=lv) for lv in range(1, 11)]
        tab[MID.get(k, str(k))] = {"id": k, "expr": p["value"], "by_level": vals if all(v is not None for v in vals) else None}
    rec["by_id"] = tab
    json.dump(rec, open(os.path.join(OUT, f"{uid:04d}_{cls}.json"), "w", encoding="utf-8"), ensure_ascii=False)
    res[uid] = tab
print(len(res))
for u in (36, 68, 75):
    print(u, mm[u], json.dumps(res[u], ensure_ascii=False)[:400])
