"""Compact per-skill digest for writing human explanations. usage: python digest.py <uid|tree:Name> [...]   (--all-tree-order prints uids of a tree)"""
import json, os, re, sys, collections
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import render_docs as R

recs, byuid = R.recs, R.byuid
NOISE = re.compile(r"(, \?x\d)+\)|, 0, \?x\d\)|stkp\(-?\d+\)|\?blr, ")
BORING_SET = {"ActionRange", "Element", "SkillIndividualFlag", "SkillParam", "IsInheritance", "attackDir", "charaDir", "attackDirection", "checkPos", "placePosition",
              "targetPos", "twinStormEffectColorR", "twinStormEffectColorG", "twinStormEffectColorB", "setEffect", "state", "isHit", "isFirst", "lastUsedSkill"}


def cl(s, n=400):
    s = R._lv(str(s))
    s = NOISE.sub(lambda m: ")" if m.group(0).endswith(")") else "", s)
    s = re.sub(r"meta\(0x[0-9a-f]+, [^()]*\)", "meta", s)
    return s if len(s) <= n else s[:n] + "…"


def nm(u):
    r = byuid.get(int(u))
    return f"{u}:{(r.get('name_en') or r.get('name_th') or r.get('class') or '?') if r else '?'}"


def refs(text):
    return sorted({m for m in re.findall(r"CreateSkill\((\d+)", text)})


_NOISE_T = re.compile(r"\(mainWeaponType & 0xfffffffe\) (ne|eq) 12|EquipItemData\.get_SubWeaponItemType\(0\) eq 19|EquipItemData\.get_SubWeaponItemType\(0\) ne 19")


def sw(w, n=150):
    """compact condition: first OR-branch, weapon-type boilerplate removed"""
    br = w.split(" OR ")[0]
    terms = [x.strip() for x in br.split(" AND ")]
    terms = [x for x in terms if x and not _NOISE_T.fullmatch(x.strip())]
    s = " AND ".join(terms) + (f"  (+{len(w.split(' OR ')) - 1} alt)" if " OR " in w else "")
    return cl(s, n)


_S = None


def mob_decode(cls):
    """symbolic ctor / GetValue of a monster-side buff class (fields written, return value)"""
    global _S
    import run_skills as RS
    if _S is None:
        RS.init(); _S = RS._G["S"]
    inv = collections.defaultdict(list)
    for a, n in _S.names.items():
        if n.startswith(cls + "$$"): inv[n.split("$$")[1]].append(a)
    out = []
    for m in (".ctor", "GetValue", "Update", "get_Value"):
        for a in inv.get(m, [])[:2]:
            try:
                ex = _S.Ex(a, max_paths=60, max_ins=6000); paths = ex.run(); summ = RS.summarize(ex, paths)
            except Exception as e:
                out.append(f"{m}:ERR {e!r}"); continue
            for st, sm in list(zip(paths, summ))[:2]:
                fl = "; ".join(f"{k}={cl(v, 100)}" for k, v in list(sm["fields"].items())[:8])
                rt = cl(RS.clean(_S.render(st.ret[0])), 160) if st.ret is not None else ""
                out.append(f"{m}({fl}{' ret ' + rt if rt and m != '.ctor' else ''})")
    return " ".join(out)[:900]



_XC = {}


def xdecode(cls):
    """symbolic run of an action class that no skill id maps to (pursuit / partner / minion actions): fields, template terms, calls per method"""
    import run_skills as RS
    global _S
    if _S is None:
        RS.init(); _S = RS._G["S"]
    if not RS._G.get("m"): RS.init()
    RS.work((-1, cls))
    fp = os.path.join(RS.OUTDIR, f"{-1:04d}_{cls}.json")
    res = json.load(open(fp, encoding="utf-8"))
    os.remove(fp)
    out = []
    for mk, v in res["methods"].items():
        name = mk.split("@")[0]
        flds, tpls, calls = {}, [], []
        for p_ in v.get("paths", []):
            for k, x in p_["fields"].items():
                if k not in BORING_SET and k != "ActionRange": flds.setdefault(k, cl(x, 140))
            for tt in p_["tpl"]:
                s = f"{tt[0]}[{tt[1]}]={cl(tt[2], 140)}"
                if s not in tpls: tpls.append(s)
            for c in p_["calls"]:
                if not any(d in c[0] for d in ("TypeInfo", "get_", "op_", "Dictionary", "List", "System.", "0x165", "UnityEngine")) and c[0] not in calls: calls.append(c[0])
        if flds or tpls or calls:
            out.append(f"   {name}: " + "; ".join(f"{k}={x}" for k, x in list(flds.items())[:12]) + (" | TPL " + "; ".join(tpls[:6]) if tpls else "") + (" | calls " + ", ".join(calls[:8]) if calls else ""))
    return "\n".join(out[:16])


def digest(r, full=False, rel=True):
    L = []
    uid = r["uid"]
    L.append(f"##### {uid} {r.get('name_th')} | {r.get('name_en')} | class={r.get('class') or r.get('mastery_class')} | tree={r.get('tree_type')} tier={r.get('tree_lv')} | {r.get('category')} maxLv={r.get('max_level')}")
    if r.get("premise_uid"): L.append(f"requires {nm(r['premise_uid'])}")
    if r.get("eq_limit"): L.append("weapons " + ",".join(r["eq_limit"]))
    if r.get("flags"): L.append("flags " + ",".join(r["flags"]))
    L.append("roles: " + " | ".join(r.get("roles", [])))
    if r.get("desc_th"): L.append("DESC: " + r["desc_th"].replace("\n", " / "))
    for n in r.get("notes") or []:
        L.append(f"NOTE Lv{n.get('level')}: " + (n.get("text") or "").replace("\n", " "))
    p = r.get("proration") or {}
    if p: L.append(f"proration slot={p.get('slot')} mode={p.get('mode')} type={p.get('attack_type')}" + (f" spawns={p['child_actions']}" if p.get("child_actions") else ""))
    seen = set()
    for m, v in r.get("methods", {}).items():
        out = []
        for it in v["items"]:
            if it["kind"] == "set" and it["name"] in BORING_SET: continue
            if it["kind"] == "set" and it["name"] == "ActionRange": continue
            key = (it["kind"], it["name"], it["text"], it["when"])
            if key in seen: continue
            seen.add(key)
            bl = it.get("by_level")
            b = f" ->{bl}" if isinstance(bl, list) else (f" ={bl}" if bl is not None else "")
            w = "" if it["when"] == "always" else f"  [if {sw(it['when'])}]"
            txt = re.sub(r"(Add|Remove)(Self)?Buffer\((\d+)", lambda m: f"{m.group(1)}{m.group(2) or ''}Buffer({nm(m.group(3))}", cl(it['text'], 300))
            out.append(f"   {it['kind']} {it['name']} = {txt}{b}{w}")
        if out:
            L.append(f" method {m}{' (TRUNC)' if v.get('truncated') else ''}:")
            L += out[:60]
    for bc, b in r.get("buffs", {}).items():
        if bc == "SkillBufferDataBase" and not b["get_param"]: continue
        L.append(f" BUFF {bc} hooks={','.join(b.get('hooks', [])[:8])} flags={ {k: x for k, x in (b.get('flags') or {}).items() if x} }")
        for c in b["ctors"][:3]:
            for k, vs in (c.get("fields_resolved") or c["fields"]).items():
                for x in vs[:3]:
                    bl = x.get("by_level")
                    L.append(f"    ctor {k} = {cl(x['expr'], 160)}" + (f" ->{bl}" if isinstance(bl, list) else "") + ("" if x["when"] == "always" else f" [if {cl(x['when'], 80)}]"))
        for g in b["get_param"]:
            L.append(f"    param {g['bonus']} = {cl(g['value'], 200)}" + (f" [if {'; '.join(cl(w, 80) for w in g['when'])}]" if g["when"] else ""))
        for k, items in b.get("other", {}).items():
            L.append(f"    hook {k}: " + "; ".join(f"{i['name']}={cl(i['text'], 120)}" for i in items[:4]))
    m = r.get("mastery")
    if m:
        for k, b in m["bonuses"].items():
            L.append(f" MASTERY {k} = {cl(b['expr'], 200)}" + (f" ->{b['by_level']}" if b.get("by_level") else ""))
    ce = r.get("consumer_effects") or []
    DROP = ("get_Instance", "GetPlayerDataManager", "get_SkillManager", "get_gameObject", "get_BuffManager", "0x165", "get_SkillBufferManager", "op_Implicit",
            "op_Equality", "op_Inequality", "SkillFactory$$CreateSkill", "get_Size", "Initialize", "SetMainTarget", "Dictionary", "List`", "System.")
    mobs = set()
    for c in ce:
        allcalls = list(dict.fromkeys(x for p_ in c["paths"] for x in p_["calls"]))
        for x in allcalls:
            m = re.match(r"(MobBuffer\.[\w.]+?)\$\$", x)
            if m: mobs.add(m.group(1))
        keep = [x for x in allcalls if not any(d in x for d in DROP)]
        rets, seen2 = [], set()
        for p_ in c["paths"]:
            rr = p_.get("ret")
            if not rr or rr in seen2 or "op_" in rr or len(rr) > 400: continue
            if re.match(r"^[\w.<>]+\(", rr) and not re.match(r"^(min|max|int)\(", rr): continue
            if not re.search(r"[0-9]", rr): continue
            seen2.add(rr); rets.append((p_["cond"], rr, p_["fields"], p_["tpl"]))
        L.append(f" CONSUMER {c['fn']} ({c['npaths']} paths)  calls: {', '.join(keep[:14])}")
        for cond, rr, flds, tpl in rets[:4]:
            conds = [cl(x, 110) for x in cond if "+0x" not in x][:2]
            L.append("   - " + (" & ".join(conds) if conds else "always") + f" => ret {cl(rr, 260)}" + "".join(f" | set {k}={cl(v, 120)}" for k, v in list(flds.items())[:3]))
        for p_ in c["paths"]:
            if p_["tpl"] and not rets:
                L.append("   - tpl " + "; ".join(f"{t3[0]}[{t3[1]}]={cl(t3[2], 120)}" for t3 in p_["tpl"][:3])); break
    for cls in sorted(mobs):
        L.append(" MOBBUFF " + cls + ": " + mob_decode(cls))
    cons = [c for c in r.get("consumers", []) if c.split(" (")[0] not in {x["fn"] for x in ce}]
    if cons: L.append(" reads (no effect decoded): " + ", ".join(cons[:10]))
    allt = json.dumps([r.get("methods"), r.get("consumer_effects")], ensure_ascii=False)
    rf = refs(allt)
    if rf: L.append(" references skills: " + ", ".join(nm(u) for u in rf))
    have = {(x.get("class") or "") for x in recs}
    xs = set()
    for blob in (json.dumps(r.get("methods"), ensure_ascii=False), json.dumps(r.get("consumer_effects"), ensure_ascii=False)):
        for m in re.finditer(r"([A-Z]\w+(?:Action|Attack))(?:\$\$|\.)\.?ctor", blob):
            if m.group(1) not in have and m.group(1) not in ("SkillActionBase", r.get("class")): xs.add(m.group(1))
    for c in sorted(xs)[:4]:
        L.append(f" RELATED CLASS {c} (no skill id):")
        L.append(xdecode(c))
    if rel:
        stem = re.sub(r"Action$", "", r.get("class") or r.get("mastery_class") or "")
        if len(stem) > 4:
            for x in recs:
                c = x.get("class") or ""
                if x["uid"] != uid and not x.get("in_skill_tree") and c.startswith(stem):
                    L.append("--- related internal action:")
                    L.append(digest(x, rel=False))
    return "\n".join(L)


if __name__ == "__main__":
    args = sys.argv[1:]
    if args and args[0] == "--list":
        key = args[1]
        for r in sorted([x for x in recs if str(x.get("tree_type") or "(internal)" if x.get("in_skill_tree") else "(internal)") == key or (key == "internal" and not x.get("in_skill_tree"))],
                        key=lambda r: (r.get("tree_lv") or 0, r["uid"])):
            print(r["uid"], end=" ")
        print(); sys.exit()
    for a in args:
        r = byuid.get(int(a))
        print(digest(r) if r else f"no uid {a}")
        print()
