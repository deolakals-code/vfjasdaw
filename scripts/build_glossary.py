"""Final glossary: variables.json (+ skill_variables.json) from variables_raw.json, enums, game text and gloss_manual.
usage (cwd D:\\toram_re): python build_glossary.py
Output (D:\\toram reverse data\\skills\\damage): variables.json  {"meta":.., "vars": {id: entry}}, skill_variables.json {uid: {...}}
Every symbol that appears in any skill formula must resolve to an entry (checked at the end, listed as residual otherwise).
"""
import os, re, json, csv, collections, sys, datetime
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import dis2 as D2
from spec_tidy import tidy
import gloss_manual as G
from refutil import pretty

OUT = r"D:\toram reverse data\skills\damage"
DATA = r"D:\toram reverse data"
CALLTOK = re.compile(r"(?<![\w.])([A-Za-z_][\w`<>]*(?:\.[A-Za-z_][\w`<>]*)*)\.([A-Za-z_]\w*)\(")
ENUM_NAMES = ("BonusType", "SkillBufferId", "SkillId", "AbnormalType", "ElementType", "SkillAttackType", "MasteryId", "GemCartBufferId",
              "CalcStep", "ItemType", "SkillTreeType", "SkillHitReactionType", "SkillBufferFlag", "CountBufferBase.CountType")
ENUMTOK = re.compile(r"\b(" + "|".join(re.escape(e.split(".")[-1]) for e in ENUM_NAMES) + r")\.(\w+)")
ELEMENT_TH = {"None": "ไม่มีธาตุ", "Fire": "ไฟ", "Water": "น้ำ", "Wind": "ลม", "Earth": "ดิน", "Light": "แสง", "Dark": "มืด", "Neutral": "กลาง"}
STEP_TH = {"BaseDamage": "ดาเมจฐาน", "SkillConstantDamage": "ดาเมจคงที่ของสกิล", "BufferConstantDamage": "ดาเมจคงที่จากบัพ", "Def": "หักป้องกันมอน (ค่าติดลบ)",
           "FirstAttack": "ดาเมจคงที่ตีแรก", "CriticalRate": "ตัวคูณคริติคอล (เมื่อคริ)", "ElementBonusRate": "โบนัสธาตุ", "SkillRate": "ตัวคูณสกิล",
           "StableRate": "ความเสถียร", "ExpRate": "proration (ExpRate)", "TypeDamageRate": "ตัวคูณประเภทดาเมจ", "LastDamageRate": "ตัวคูณดาเมจสุดท้าย",
           "DistanceResistRate": "ต้านระยะ", "GemDamageRate": "ตัวคูณเจม", "AbnormalDamageIncreaseRate": "ดาเมจเพิ่มเมื่อติดสถานะ",
           "DamageLimit": "เพดานดาเมจ", "MinDamage": "ดาเมจต่ำสุด", "MaxDamage": "ดาเมจสูงสุด", "HitCheck": "เช็กโดน", "CriticalCheck": "เช็กคริ"}


ALIASES = {}
ALIAS_TOK = re.compile(r"\b(?:status|target)\.\w+|\bbase(?:STR|INT|VIT|AGI|DEX|CRT|LUK|MEN|TEC)\b")
PRIM_ALIAS = {"str": "baseSTR", "int": "baseINT", "vit": "baseVIT", "agi": "baseAGI", "dex": "baseDEX", "crt": "baseCRT", "luk": "baseLUK", "men": "baseMEN", "tec": "baseTEC"}
MOBSTATUS_TH = {"localExpDefNormal": "proration ปัจจุบันของมอนในช่องตีปกติ (%, เริ่ม 100, ถูกบีบอยู่ระหว่าง 50-250)",
                "localExpDefSkill": "proration ปัจจุบันของมอนในช่องสกิลกายภาพ (%)",
                "localExpDefMagic": "proration ปัจจุบันของมอนในช่องเวท (%)"}


def cam(s):
    return re.sub(r"(?<=[a-z0-9])(?=[A-Z])", " ", s).replace("_", " ")


def load_texts():
    th = {}
    p = os.path.join(DATA, "TORAM ONLINE BIGDATA", "readable", "text", "GameScene_th", "ItemProperty_th.tsv")
    for r in csv.DictReader(open(p, encoding="utf-8"), delimiter="\t"):
        th.setdefault(int(r["id"]), r["text"])
    return th


ITEMPROP = load_texts()
SK = {s["uid"]: s for s in json.load(open(os.path.join(DATA, "skills", "skills_full.json"), encoding="utf-8"))}
import render_explained_th as RE   # PARAM_TH / MASTERY_TH / ABN_TH


def method_gloss(cls, m):
    """auto gloss for the standard skill-class hooks; returns (th, en) or None"""
    if m == "PayHp": return (f"{cls}: จุดที่สกิลจ่าย/ลงทะเบียนต้นทุน HP (ในโค้ดเรียกว่า PayHp; อ่านนิยามจริงด้านล่าง)", f"{cls}: HP-payment hook")
    if m == "CheckPayHp": return (f"{cls}: ตรวจว่า HP พอจ่ายต้นทุนของสกิลนี้ไหม (true = ร่ายได้)", f"{cls}: can the HP cost be paid")
    if m == "ActionStart": return (f"{cls}: ตอนเริ่มทำงานของสกิล", f"{cls}: skill start")
    if m == "ActionPreparation": return (f"{cls}: ขั้นเตรียมก่อนปล่อยสกิล", f"{cls}: preparation")
    if m == "OnInitialize": return (f"{cls}: ตั้งค่าเริ่มต้นของสกิล (ตัวคูณ ดาเมจคงที่ ระยะ ...)", f"{cls}: initial values")
    if m.lower() == "calcplayertomobdamage": return (f"{cls}: สูตรดาเมจผู้เล่น→มอนสเตอร์ (ใส่ค่าลง template)", f"{cls}: player→mob damage template")
    if m == "Damaged": return (f"{cls}: เมื่อผู้เล่นถูกโจมตีขณะสกิลทำงาน", f"{cls}: on damaged")
    if m == "Updata": return (f"{cls}: อัปเดตทุกเฟรม/ทุกจังหวะของบัพ", f"{cls}: per-tick update")
    if m == "GetParam": return (f"{cls}: ตารางพารามิเตอร์ของบัพ (SkillBufferId → ค่า)", f"{cls}: buff parameter table")
    if m == ".ctor": return (f"{cls}: ตัวสร้าง (ค่าเริ่มต้นของฟิลด์)", f"{cls}: constructor")
    if m in ("Next", "NextSkip"): return (f"{cls}: เพิ่มสแตก/ตัวนับ", f"{cls}: increment counter")
    if m in ("Prev", "PrevSkip"): return (f"{cls}: ลดสแตก/ตัวนับ", f"{cls}: decrement counter")
    return None


def function_gloss(sym, entry_kind):
    cls, _, m = sym.rpartition(".")
    for tab, pre in ((G.PLAYER_STAT, G.P), (G.MOB_STAT, G.M)):
        if sym.startswith(pre) and m in tab: return tab[m]
    if sym in G.ENGINE: return G.ENGINE[sym]
    if sym in G.OUTPARAM: return G.OUTPARAM[sym]
    mg = method_gloss(cls.split(".")[-1], m)
    if mg: return mg
    if m.startswith("get_"): return (f"ค่า {cam(m[4:])} ของ {cls.split('.')[-1]}", f"{cam(m[4:])} of {cls.split('.')[-1]}")
    if m.startswith(("Calc", "calc")): return (f"คำนวณ {cam(m[4:]).lower()} ({cls.split('.')[-1]})", f"calculate {cam(m[4:]).lower()}")
    if m.startswith(("Check", "check")): return (f"ตรวจ {cam(m[5:]).lower()} ({cls.split('.')[-1]})", f"check {cam(m[5:]).lower()}")
    if m.startswith(("Is", "Can", "Enough", "Exist", "Contains")): return (f"เงื่อนไข {cam(m).lower()} ({cls.split('.')[-1]})", f"predicate {cam(m).lower()}")
    return (f"{cls.split('.')[-1]}.{m}", f"{cam(m)} ({cls.split('.')[-1]})")


def enum_entry(en, nm):
    kind, th, label = "enum", None, "Code"
    if en == "BonusType":
        kind = "bonus_type"
        v = next((k for k, n in D2.C["BonusType"]["consts"].items() if n == nm), None)
        txt = ITEMPROP.get(v)
        th = re.sub(r"\{0\}", "ค่า", txt) if txt else None
        if th: th = f"โบนัส «{th}» (id {v} ตรงกับข้อความไอเทม)"
    elif en == "SkillBufferId":
        kind = "buff_param"; th = RE.PARAM_TH.get(nm)
    elif en == "SkillId":
        kind = "skill"
        v = next((k for k, n in D2.C["SkillId"]["consts"].items() if n == nm), None)
        s = SK.get(v) or {}
        th = re.sub(r"\[N2?\]", " ", str(s.get("name_th") or "")).strip() or None
    elif en == "AbnormalType":
        kind = "abnormal"; th = RE.ABN_TH.get(nm)
    elif en == "ElementType":
        kind = "element"; th = ELEMENT_TH.get(nm)
    elif en == "MasteryId":
        kind = "mastery"; th = RE.MASTERY_TH.get(nm)
    elif en == "CalcStep":
        kind = "engine_step"; th = STEP_TH.get(nm)
    cn = {"CountType": "CountBufferBase.CountType"}.get(en, en)
    val = next((k for k, n in D2.C.get(cn, {}).get("consts", {}).items() if n == nm), None)
    return {"kind": kind, "cls": en, "member": nm, "gloss_th": th or f"{cam(nm)}", "gloss_en": cam(nm), "label": label, "value": val}


def kind_of(sym, consumers):
    cls = sym.rpartition(".")[0]
    if cls == "IPlayerStatusCalculator": return "player_stat"
    if cls == "IMobStatusCalculator": return "mob_stat"
    if sym in consumers: return "skill_hook"
    if re.search(r"\.out\d?$|\.out\d$", sym) or ".out" in sym.rsplit(".", 1)[-1] or sym.rsplit(".", 1)[-1].startswith("out"): return "out_param"
    if cls.startswith(("UnityEngine", "System", "Toram.Common")): return "builtin"
    if cls in ("PlayerAttackBase", "SkillActionBase", "SkillCalcTemplate") or cls.endswith("Calculator") or cls.startswith("EquipItemData"): return "engine_fn"
    return "helper_fn"


def main():
    raw = json.load(open(os.path.join(OUT, "variables_raw.json"), encoding="utf-8"))
    cons = json.load(open(r"D:\toram_re\skill_consumers.json", encoding="utf-8"))
    consumers = {c["fn"].replace("$$", ".") for lst in cons.values() for c in lst}
    refp = os.environ.get("SKILL_REF", os.path.join(OUT, "skill_reference.json"))
    ref = json.load(open(refp, encoding="utf-8"))
    V = {}
    ALIASES.clear()
    for m, (th, en) in G.PLAYER_STAT.items():
        if m.startswith("get_"): ALIASES[f"status.{m[4:]}"] = f"IPlayerStatusCalculator.{m}"
    for m, (th, en) in G.MOB_STAT.items():
        if m.startswith("get_"): ALIASES[f"target.{m[4:]}"] = f"IMobStatusCalculator.{m}"
    for k, nm in PRIM_ALIAS.items(): ALIASES[nm] = f"PlayerPrimaryStatus.{k}"
    for sym, v in raw.items():
        cls, _, m = sym.rpartition(".")
        th, en = function_gloss(sym, None)
        ent = {"id": sym, "kind": kind_of(sym, consumers), "cls": cls, "member": m, "gloss_th": th, "gloss_en": en, "label": "Code" if v["impls"] else "Inferred",
               "leaf": not v["impls"], "used_by": v["used_by"], "impls": v["impls"]}
        if sym.startswith(("IPlayerStatusCalculator.get_AntiVirus", "IMobStatusCalculator.get_DamagePercent", "IPlayerStatusCalculator.get_ElementPower")): ent["label"] = "Inferred"
        V[sym] = ent
    for k, nm in PRIM_ALIAS.items():
        V[f"PlayerPrimaryStatus.{k}"] = {"id": f"PlayerPrimaryStatus.{k}", "kind": "player_stat", "cls": "PlayerPrimaryStatus", "member": k, "alias": nm,
                                         "gloss_th": f"แต้ม {k.upper()} ที่ผู้เล่นลงเอง (ไม่รวมอุปกรณ์/บัพ) — เรียกในสูตรว่า {nm}", "gloss_en": f"Allocated {k.upper()} points (field PlayerPrimaryStatus.{k})",
                         "label": "Code", "leaf": True, "used_by": [], "impls": []}
    for nm, th in MOBSTATUS_TH.items():
        V[f"MobStatus.{nm}"] = {"id": f"MobStatus.{nm}", "kind": "mob_stat", "cls": "MobStatus", "member": nm, "gloss_th": th, "gloss_en": f"Mob current proration ({nm})",
                                "label": "Code", "leaf": True, "used_by": [], "impls": []}
    for al, vid in ALIASES.items():
        if vid in V: V[vid].setdefault("alias", al)
    # enum tokens in function bodies + skill formulas
    tok_users = collections.defaultdict(set)
    skill_syms = collections.defaultdict(lambda: {"calls": set(), "enums": set()})

    def scan(uid, o):
        if isinstance(o, str):
            t = tidy(o)
            for _ in range(2): t = re.sub(r"<[^<>()]*>", "", t)
            t = re.sub(r"\b\w+>\.", "Collection.", t)
            for m in CALLTOK.finditer(t): skill_syms[uid]["calls"].add(f"{m.group(1)}.{m.group(2)}")
            for m in ENUMTOK.finditer(t): skill_syms[uid]["enums"].add(f"{m.group(1)}.{m.group(2)}")
            for m in ALIAS_TOK.finditer(pretty(t)):
                a = m.group(0)
                skill_syms[uid]["calls"].add(ALIASES.get(a) or ALIASES.get(m.group(1)) or a)
            for m in re.finditer(r"\.(localExpDef(?:Normal|Skill|Magic))\b", t): skill_syms[uid]["calls"].add(f"MobStatus.{m.group(1)}")
        elif isinstance(o, dict):
            for x in o.values(): scan(uid, x)
        elif isinstance(o, list):
            for x in o: scan(uid, x)

    for r in ref:
        for key in ("methods", "buffs", "mastery"):
            if key in r: scan(r["uid"], r[key])
    for uid, d in skill_syms.items():
        for e in d["enums"]: tok_users[e].add(uid)
    body_enums = set()
    for sym, v in raw.items():
        txt = json.dumps([i.get("cases") for i in v["impls"]] + [i.get("events") for i in v["impls"]] + [i.get("lets") for i in v["impls"]], ensure_ascii=False)
        for m in ENUMTOK.finditer(txt): body_enums.add(f"{m.group(1)}.{m.group(2)}")
    for e in sorted(set(tok_users) | body_enums):
        en, _, nm = e.partition(".")
        ent = enum_entry(en, nm)
        ent.update({"id": e, "used_by": sorted(tok_users.get(e, ())), "leaf": True, "impls": []})
        V[e] = ent
    # static arrays (tables baked into the client) that formulas mention
    sa_path = os.path.join(OUT, "static_arrays.json")
    if os.path.exists(sa_path):
        SA = json.load(open(sa_path, encoding="utf-8"))
        blob_txt = json.dumps([[i.get("cases"), i.get("events"), i.get("lets")] for e in V.values() for i in e["impls"]], ensure_ascii=False)
        for key, a in SA.items():
            if key in blob_txt or key in V:
                shown = ", ".join(a["names"] if a["names"] else [str(x) for x in a["values"]])
                V[key] = {"id": key, "kind": "static_array", "cls": key.rpartition(".")[0], "member": key.rpartition(".")[2],
                          "gloss_th": f"ตารางค่าคงที่ในไคลเอนต์ ({a['n']} ค่า): {shown}", "gloss_en": f"client static {a['type']}[{a['n']}]: {shown}",
                          "label": "Code", "leaf": True, "used_by": [], "impls": [], "values": a["values"], "names": a["names"], "elem_type": a["type"]}
    # refs (what each function mentions) for the viewer links
    for sym, ent in V.items():
        txt = json.dumps([i.get("cases") for i in ent["impls"]] + [i.get("events") for i in ent["impls"]] + [i.get("lets") for i in ent["impls"]], ensure_ascii=False)
        rs = {f"{m.group(1)}.{m.group(2)}" for m in CALLTOK.finditer(txt)} | {f"{m.group(1)}.{m.group(2)}" for m in ENUMTOK.finditer(txt)}
        rs |= {k for k in V if V[k]["kind"] == "static_array" and k in txt}
        ent["refs"] = sorted(r for r in rs if r in V and r != sym)
    # symbols seen in skill formulas that have no decoded code: auto leaf entries so no id dangles
    auto_leaf = []
    for uid, d in skill_syms.items():
        for x in d["calls"]:
            if x not in V:
                cls, _, m = x.rpartition(".")
                th, en = function_gloss(x, None)
                V[x] = {"id": x, "kind": "builtin" if cls.startswith(("System", "UnityEngine", "Toram", "Collection", "Singleton")) else "out_param" if ".out" in x or m.startswith("out") else "leaf_unknown",
                        "cls": cls, "member": m, "gloss_th": th, "gloss_en": en, "label": "Inferred", "leaf": True, "used_by": [], "impls": [], "refs": []}
                auto_leaf.append(x)
    # per-skill index
    SV, missing = {}, collections.Counter()
    cons_by_uid = collections.defaultdict(list)
    for u, lst in cons.items():
        for c in lst:
            f = c["fn"].replace("$$", ".")
            if f in V and f not in cons_by_uid[int(u)]: cons_by_uid[int(u)].append(f)
    for r in ref:
        uid = r["uid"]
        d = skill_syms.get(uid, {"calls": set(), "enums": set()})
        ids = sorted(x for x in d["calls"] | d["enums"] if x in V)
        for x in d["calls"] | d["enums"]:
            if x not in V: missing[x] += 1
        SV[uid] = {"vars": ids, "hooks": sorted(cons_by_uid.get(uid, []))}
    for sym, ent in V.items():
        ent["used_by"] = sorted(set(ent["used_by"]) | {u for u, d in SV.items() if sym in d["vars"] or sym in d["hooks"]})
    meta = {"aliases": ALIASES, "generated": datetime.datetime.now().isoformat(timespec="seconds"), "n_vars": len(V),
            "kinds": dict(collections.Counter(e["kind"] for e in V.values())), "unresolved_symbols": dict(missing.most_common(40)), "auto_leaf": sorted(set(auto_leaf))[:80]}
    json.dump({"meta": meta, "vars": V}, open(os.path.join(OUT, "variables.json"), "w", encoding="utf-8"), ensure_ascii=False)
    json.dump({str(k): v for k, v in SV.items()}, open(os.path.join(OUT, "skill_variables.json"), "w", encoding="utf-8"), ensure_ascii=False)
    print(json.dumps(meta, ensure_ascii=False, indent=1))


if __name__ == "__main__":
    main()
