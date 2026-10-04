"""Overview tab data ("คำอธิบายโดยรวม"): where each skill's damage multiplier comes from, per-weapon splits, states during the cast
(invincibility, super armor, damage cut), buffs and cross-skill links, name variants / patterns.

Reads  skills/damage/{calc_spec, skill_reference.json, coverage.csv, buff_owner_index.json, variables.json, engine.json} and D:\\toram_re\\skillrecipes.
Writes skills/damage/overview/overview.json (viewer) and skills/damage/overview_th/*.md (one page per tree + README + ENGINE).
Run from anywhere: python build_overview.py            (idempotent, a few seconds)
                   python build_overview.py --selftest
Labels: Code = decoded from libil2cpp.so, Inferred = reading of the decoded values, Text = in-game text.
"""
import os, re, sys, csv, json, glob, ast, itertools, collections

sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))

import calc_engine as CE
import exprsimp as X

BASE = r"D:\toram reverse data\skills\damage"
RECIPES = r"D:\toram_re\skillrecipes"
DAMAGE_TYPE = {r["uid"]: r for r in json.load(open(os.path.join(BASE, "damage_type.json"), encoding="utf-8"))}  # build_damage_type.py
OUT_JSON = os.path.join(BASE, "overview", "overview.json")
OUT_MD = os.path.join(BASE, "overview_th")
LVS = range(1, 11)

ITEMTYPE = {0: "Null", 7: "Warhammer", 8: "Katana", 9: "Halberd", 10: "OneHandSword", 11: "TwoHandSword", 12: "Bow", 13: "Bowgun", 14: "Rod",
            15: "Magictool", 16: "Knuckle", 17: "Shield", 18: "ShortSword", 19: "Arrow", 23: "NinjutsuBook"}
WEAP = {"OneHandSword": "ดาบมือเดียว", "TwoHandSword": "ดาบสองมือ", "Bow": "ธนู", "Bowgun": "โบว์กัน", "Rod": "ไม้เท้า", "Magictool": "อุปกรณ์เวท",
        "Knuckle": "สนับมือ", "Halberd": "ทวน", "Katana": "คาตานะ", "Shield": "โล่", "ShortSword": "มีด", "Arrow": "ลูกธนู", "NinjutsuBook": "ม้วนนินจุตสึ",
        "Null": "มือเปล่า/ไม่ถือ", "Hand": "มือเปล่า", "Warhammer": "Warhammer", "OTHER": "อื่นๆ"}
STEP_TH = {"SkillRate": "ตัวคูณสกิล", "SkillConstantDamage": "ดาเมจคงที่ของสกิล", "BufferConstantDamage": "ดาเมจคงที่จากบัพ", "BaseDamage": "ดาเมจฐาน",
           "Def": "หักป้องกันเป้า", "CriticalRate": "ตัวคูณคริเพิ่ม", "FirstAttack": "ดาเมจคงที่ตีแรก", "FirstAttackRate": "ตัวคูณตีแรก", "ExpRate": "Proration",
           "LastDamageRate": "ตัวคูณดาเมจสุดท้าย", "StableRate": "ความเสถียร", "ElementBonusRate": "โบนัสธาตุ", "TypeDamageRate": "ตัวคูณประเภทดาเมจ",
           "GemDamageRate": "ตัวคูณเจม", "AutoSkillRate": "ตัวคูณสกิลอัตโนมัติ", "AutoSkillConstant": "ดาเมจคงที่สกิลอัตโนมัติ",
           "NormalAttackPowerWave": "power wave ตีปกติ", "NormalElementDamageResistRate": "ต้านธาตุ", "DistanceResistRate": "ต้านตามระยะ",
           "SpecialLastDamageRate": "ตัวคูณสุดท้ายพิเศษ", "AbnormalDamageIncreaseRate": "เพิ่มดาเมจเป้าติดสถานะ", "LastConstantDamage": "ดาเมจคงที่สุดท้าย",
           "SpecificWeaponLastDamage": "ตัวคูณสุดท้ายตามอาวุธ", "NormalAttackTreasureHuntLastDamageRate": "ตัวคูณล่าสมบัติ"}
PCT_STEPS = {"SkillRate", "CriticalRate", "FirstAttackRate", "LastDamageRate", "StableRate"}
CONST_STEPS = {"SkillConstantDamage", "BufferConstantDamage", "FirstAttack", "AutoSkillConstant", "LastConstantDamage"}
STEP_ORDER = ["SkillConstantDamage", "BufferConstantDamage", "FirstAttack", "SkillRate", "FirstAttackRate", "ExpRate", "LastDamageRate"]
ATTACK_TH = {"Physics": "กายภาพ (ใช้ ATK)", "Magic": "เวท (ใช้ MATK)"}
SLOT_TH = {"Skill": "ช่องสกิลกายภาพ", "Magic": "ช่องเวท", "Normal": "ช่องตีปกติ"}
STAT_TH = {"baseSTR": "STR(ที่ลงเอง)", "baseDEX": "DEX(ที่ลงเอง)", "baseINT": "INT(ที่ลงเอง)", "baseAGI": "AGI(ที่ลงเอง)", "baseVIT": "VIT(ที่ลงเอง)",
           "status.Str": "STRรวม", "status.Dex": "DEXรวม", "status.Int": "INTรวม", "status.Agi": "AGIรวม", "status.Vit": "VITรวม"}
EXTRA_TH = {"target.ExpDefSkill": "proration ช่องสกิลของเป้า", "target.ExpDefMagic": "proration ช่องเวทของเป้า", "target.ExpDefNormal": "proration ช่องตีปกติของเป้า",
            "targetExpRegister": "proration ที่เก็บไว้ตอนร่าย"}
GEMCART = re.compile(r"gemCart\((\d+), \[(\d+)\]\)")
JUNK = re.compile(r"UnityEngine\.(?!Object\.op_(?:Equality|Inequality)\(MobActionManagerBase)|\?x\d|\+0x|meta\(|vtab|stkp|GetComponent|\?v\d|\?idx|IsBlank|SkillBufferManager\.TryGetBuf<|\?mi|\?blr")
WATOM = re.compile(r"^\(?(mainWeapon|subWeapon|WeaponType|weaponType|SubWeaponType|subWeaponType)\s+(==|!=|eq|ne)\s+(\w+)\)?$")
CMP_TH = {"ne": "≠", "eq": "=", "gt": ">", "ge": "≥", "lt": "<", "le": "≤", "hi": ">", "ls": "≤", "lo": "<", "hs": "≥"}
CMP_NEG = {"ne": "eq", "eq": "ne", "gt": "le", "le": "gt", "lt": "ge", "ge": "lt", "hi": "ls", "ls": "hi", "lo": "hs", "hs": "lo"}
MAIN_TARGET = re.compile(r"UnityEngine\.Object\.op_Equality\(MobActionManagerBase\.get_gameObject\(mobAction\), UnityEngine\.Component\.get_gameObject\(targetAction\)\)")

# buff parameter groups (SkillBufferId names)
DEFENSE = {"PowerDmgCut", "MagicDmgCut", "BaseDamageCut", "BaseDamageCutRate", "MobLastDamageRateBuf", "MobLastDamageRateSupport", "MobLastDamageRateUnique",
           "Guard", "GuardRate", "AvoidUp", "AvoidStack", "AbnormalRegist", "AbnormalAvoid", "LimitRegistDamage", "KnockbackDistReduceRate", "Def", "Mdef",
           "DefRate", "MdefRate", "MaxHpUp", "MaxHpUpRate", "RateDamageResist", "ReceiveDarkElementDmgRate", "ReceiveLightElementDmgRate", "Flee", "FleeRate"}
OFFENSE = {"AtkUp", "AtkUpRate", "MatkUp", "MAtkUpRate", "EqAtk", "EqAtkUpRate", "BaseEqAtk", "BaseEqAtkUpRate", "CrtUp", "CrtUpRate", "CrtDmg", "CrtDamageUp",
           "CrtDamageUpRate", "MagicCrtDamage", "SkillConstantDamage", "NormalAttackRate", "NormalAttackConstantDamage", "LastDmgUpRate", "LastDamageRateDecimal",
           "PhysicalPursuitSkillRate", "MagiclPursuitSkillRate", "PowerResistBreaker", "MagicResistBreaker", "TargetDefDown", "TargetMdefDown", "HitUp", "HitRate",
           "FirstAttackRate", "ShortRangeRate", "LongRangeRate", "Stable", "LastDmgDownRate"}
SPEED = {"Aspd", "AspdRate", "CspdUp", "CspdUpRate", "MotionSpeed", "MotionSpeedRate", "MoveSpeed"}
CAST_KW = re.compile(r"คงกระพัน|อมตะ|ไม่ได้รับความเสียหาย|ไม่รับความเสียหาย|ลดความเสียหาย|ความเสียหาย.{0,12}ลด|ไม่สะดุด|ไม่ถูกขัด|เกราะ|ไม่ตาย|เคลื่อนที่ได้|ต้านทาน|หลบ")


def jload(p):
    return json.load(open(p, encoding="utf-8"))


# ------------------------------------------------------------------ data
class Data:
    def __init__(self):
        self.ref = {x["uid"]: x for x in jload(os.path.join(BASE, "skill_reference.json"))}
        self.spec = {}
        for f in glob.glob(os.path.join(BASE, "calc_spec", "[0-9]*.json")):
            s = jload(f); self.spec[s["uid"]] = s
        self.vars = jload(os.path.join(BASE, "variables.json"))["vars"]
        self.bufown = jload(os.path.join(BASE, "buff_owner_index.json"))
        self.cls2uid = {}
        with open(os.path.join(BASE, "coverage.csv"), encoding="utf-8-sig") as fh:
            for r in csv.DictReader(fh):
                if r["class"]: self.cls2uid[r["class"]] = int(r["uid"])
        for u, x in self.ref.items():
            for k in ("class", "mastery_class"):
                if x.get(k): self.cls2uid.setdefault(x[k], u)
        for bc, o in self.bufown.items():
            if o.get("owners"): self.cls2uid.setdefault(bc, o["owners"][0])
        self.name2uid = {x["name_en"]: u for u, x in self.ref.items() if x.get("name_en")}
        self.abn = {v["id"].split(".")[1]: v.get("gloss_th") for v in self.vars.values() if v["kind"] == "abnormal"}
        self.abn_id = {v["value"]: v.get("gloss_th") for v in self.vars.values() if v["kind"] == "abnormal" and isinstance(v.get("value"), int)}
        self.bufparam = {v["id"].split(".")[1]: v.get("gloss_th") for v in self.vars.values() if v["kind"] == "buff_param"}
        self.hookgloss = {k: v.get("gloss_en") for k, v in self.vars.items() if v["kind"] in ("skill_hook", "engine_fn")}
        src = open(os.path.join(os.path.dirname(os.path.abspath(__file__)), "render_explained_th.py"), encoding="utf-8").read()
        m = re.search(r"^TREE_TH = (\{.*?^\})", src, re.M | re.S)
        self.tree_th = ast.literal_eval(m.group(1)) if m else {}
        self.recipes = {}
        for f in glob.glob(os.path.join(RECIPES, "[0-9]*.json")):
            d = jload(f); self.recipes[d["uid"]] = d

    def sname(self, u):
        r = self.ref.get(int(u))
        rc = self.recipes.get(int(u), {}).get("cls")
        if not r: return rc or str(u)
        return short_name(r.get("name_th")) or r.get("name_en") or r.get("class") or rc or str(u)


def short_name(n):
    n = re.sub(r"\[[A-Z0-9]+\]", "|", n or "")
    return " / ".join(p.strip() for p in n.split("|") if p.strip()) or (n or "")


# ------------------------------------------------------------------ conditions
def neg(a):
    a = a.strip()
    if a.startswith("!"): return a[1:]
    m = re.match(r"^(.*)\s(ne|eq|gt|ge|lt|le|hi|ls|lo|hs)\s(\S+)$", a)
    if m: return f"{m.group(1)} {CMP_NEG[m.group(2)]} {m.group(3)}"
    return "!" + a


NORM_W = re.compile(r"^\((main|sub)Weapon==(\w+) & 1\) (ne|eq) 0$")
WTOKEN = re.compile(r"[Ww]eapon|ItemType|EquipType")
WEXPR = [(re.compile(r"PlayerAttackBase\.ExistWeaponType\(\w+, (?:ItemType\.)?(\w+)[^()]*\)"), lambda m: f"((mainWeapon == {W_NAME(m.group(1))}) || (subWeapon == {W_NAME(m.group(1))}))"),
         (re.compile(r"ItemType\.(\w+)"), lambda m: m.group(1)),
         (re.compile(r"PlayerStatusBase\.GetEquip\(PlayerActionManagerBase\.get_PlayerStatus\(\), EquipType\.Weapon\)\.Type"), lambda m: "mainWeaponType"),
         (re.compile(r"EquipItemData\.get_SubWeapon\(PlayerStatusBase\.get_EquipItemData\(\)\)\.Type"), lambda m: "subWeaponType"),
         (re.compile(r"EquipItemData\.get_SubWeaponItemType\(PlayerStatusBase\.get_EquipItemData\(\)\)"), lambda m: "subWeaponType"),
         (re.compile(r"EquipItemData\.WeaponTypeCalculatorBase\.get_WeaponType\(PlayerStatusBase\.get_EquipItemData\(\)\.mainWeaponCalculator\)"), lambda m: "mainWeaponType"),
         (re.compile(r"EquipItemData\.WeaponTypeCalculatorBase\.get_WeaponType\(PlayerStatusBase\.get_EquipItemData\(\)\.subWeaponCalculator\)"), lambda m: "subWeaponType"),
         (re.compile(r"PlayerAttackBase\.GetWeaponType\(actarAction, out\)"), lambda m: "mainWeaponType"),
         (re.compile(r"PlayerAttackBase\.GetSubWeaponType\(actarAction\)"), lambda m: "subWeaponType")]
ITEM_ID = {v: k for k, v in ITEMTYPE.items()}
SUB_OK = {"Shield", "Arrow", "Magictool", "ShortSword", "OneHandSword", "NinjutsuBook", "Knuckle"}   # weapons that can sit in the sub slot


def W_NAME(x):
    return ITEMTYPE.get(int(x), x) if str(x).isdigit() else x


def scen_env(main, sub):
    m, s_ = ITEM_ID.get(main, -1), ITEM_ID.get(sub, -1)
    e = {"mainWeaponType": m, "WeaponType": m, "weaponType": m, "subWeaponType": s_, "SubWeaponType": s_, "mainWeapon": main, "subWeapon": sub}
    e.update({k: k for k in ITEM_ID})
    return e


def atom_weapon(a):
    a = a.strip()
    m = NORM_W.match(a)
    if m: return m.group(1), m.group(3) == "ne", m.group(2)
    m = WATOM.match(a)
    if not m: return None
    var, op, val = m.groups()
    if val.isdigit(): val = ITEMTYPE.get(int(val), val)
    return ("sub" if var.lower().startswith("sub") else "main"), op in ("==", "eq"), val


_TRUTH = {}


def atom_truth(a, scen):
    """True / False for one atom under a weapon scenario, None when it is not a weapon condition or cannot be evaluated (memoised)"""
    k = (a, scen.get("main"), scen.get("sub"))
    if k not in _TRUTH: _TRUTH[k] = _atom_truth(a, scen)
    return _TRUTH[k]


def _atom_truth(a, scen):
    w = atom_weapon(a)
    if w:
        side, eq, val = w
        return (scen[side] == val) == eq
    if not WTOKEN.search(a) or "env" not in scen: return None
    t = a.strip()
    neg_ = t.startswith("!")
    if neg_: t = t[1:]
    for rx, fn in WEXPR: t = rx.sub(fn, t)
    t = t.replace("subWeapon == Arrow ?", "subWeapon == Arrow ?")
    try:
        r = CE.Evaluator(env=scen["env"]).truth(t)
    except Exception:
        return None
    return (not r) if neg_ else bool(r)


def eval_when(when, scen):
    """-> (possible, [remaining atom lists of the clauses that survive the weapon test])"""
    if not when or when == "always": return True, [[]]
    alive = []
    for clause in re.split(r"\s+OR\s+", when):
        rem, ok = [], True
        for a in re.split(r"\s+AND\s+", clause):
            r = atom_truth(a, scen)
            if r is None: rem.append(a.strip()); continue
            if not r: ok = False; break
        if ok: alive.append(rem)
    return bool(alive), alive


def merge_complements(clauses):
    cl = [tuple(sorted(c)) for c in clauses]
    cl = list(dict.fromkeys(cl))
    changed = True
    while changed:
        changed = False
        for a, b in itertools.combinations(cl, 2):
            if len(a) != len(b): continue
            da, db = set(a) - set(b), set(b) - set(a)
            if len(da) == 1 and len(db) == 1 and neg(next(iter(da))) == next(iter(db)):
                new = tuple(sorted(set(a) & set(b)))
                cl = [c for c in cl if c not in (a, b)] + [new]
                cl = list(dict.fromkeys(cl)); changed = True; break
    return cl


SIMPLE = re.compile(r"^!?\(?([A-Za-z_][\w.]*(?:\[\d+\])?)\s+(ne|eq|gt|ge|lt|le|hi|ls|lo|hs)\s+(-?[\w.]+)\)?$")
HIT_VARS = {"type", "attackType", "attackCount", "nowAttackCount", "isFirst", "isFirstAttack", "isFirstAttck", "isFristAttck", "first", "damageCount", "hitCount",
            "LoopParam", "lineAttack", "singleAttack", "direction", "attackDir", "comboType", "criticalAttackCount", "mainTarget", "change", "state", "isCounter",
            "isGuard", "arrowNum", "forceMiss", "isRange"}
METHOD_TH = {"calcPlayerToMobDamage": "ดาเมจหลัก", "calcFirstDamage": "ฮิต 1", "CalcFirstDamage": "ฮิต 1", "calcSecondDamage": "ฮิต 2", "CalcSecondDamage": "ฮิต 2",
             "calcAnyDamage": "ฮิตถัดไป", "calcRampageFinish": "ท่าปิด Rampage", "RecalcAvoidDamage": "คำนวณใหม่เมื่อเป้าหลบ", "CalcDamage": "ดาเมจ (เมธอดเสริม)"}


def is_main_target(a):
    return bool(MAIN_TARGET.search(a))


def is_hit_atom(a):
    if is_main_target(a): return False
    m = SIMPLE.match(a.strip())
    return bool(m and m.group(1) in HIT_VARS)


SILENT = re.compile(r"^BuffEffectActive ne 0$|\.Length\b")


def atom_th(a):
    """-> Thai text, or None when the atom is decoder plumbing that cannot be shown simply; '' for atoms that carry no information"""
    a = a.strip()
    if SILENT.match(a): return ""
    if is_main_target(a):
        return "ตัวที่โดนไม่ใช่เป้าหลัก" if a.startswith("!") or re.search(r"\) (?:& 1\) )?eq 0$", a) else "ตัวที่โดนคือเป้าหลัก"
    m = SIMPLE.match(a)
    if m and not JUNK.search(a):
        v, op, val = m.groups()
        if a.startswith("!"): op = CMP_NEG[op]
        return f"{v} {CMP_TH[op]} {val}"
    return None


def cond_text(alive):
    """OR of ANDs -> short Thai text; '' when unconditional. Atoms that are decoder plumbing are dropped and flagged with (+เงื่อนไขอื่น)."""
    if not alive or any(not c for c in alive): return ""
    cl = merge_complements(alive)
    if any(not c for c in cl): return ""
    out = []
    for c in cl:
        t, dropped = [], False
        for a in c:
            x = atom_th(a)
            if x: t.append(x)
            elif x is None: dropped = True
        t = [x for x in t if x != "ตัวที่โดนคือเป้าหลัก" or "ตัวที่โดนไม่ใช่เป้าหลัก" not in t]
        s = " และ ".join(dict.fromkeys(t))
        if dropped: s = (s + " " if s else "") + "(+เงื่อนไขอื่น)"
        out.append(s)
    out = list(dict.fromkeys(out))
    txt = " หรือ ".join(f"({o})" if len(out) > 1 and " และ " in o else o for o in out)
    return txt if len(txt) <= 200 else txt[:197] + "…"


# ------------------------------------------------------------------ formulas
NAME_RX = re.compile(r"(?<![\w.])[A-Za-z_]\w*(?:\[\d+\])?")


def lv_values(text):
    out = []
    for lv in LVS:
        try: out.append(CE.Evaluator(env={"Lv": lv, "lv": lv}).eval(text))
        except Exception: return None
    return out


def linear(vals):
    if vals is None or len(vals) < 3: return None
    d = vals[1] - vals[0]
    if all(abs((vals[i + 1] - vals[i]) - d) < 1e-9 for i in range(len(vals) - 1)):
        b = vals[0] - d
        return d, b
    return None


def fnum(v):
    if isinstance(v, float) and abs(v - round(v)) < 1e-9: v = int(round(v))
    if isinstance(v, float): return f"{v:.2f}".rstrip("0").rstrip(".")
    return str(v)


CTX = {}


def pretty(text):
    try:
        t, subs = X.simplify(text)
    except Exception:
        t, subs = text, []
    for n, s in subs: t = re.sub(rf"\b{re.escape(n)}\b", f"({s})", t)
    t = t.replace("//", "÷")
    for k in sorted(STAT_TH, key=len, reverse=True): t = t.replace(k, STAT_TH[k])
    for k, v in EXTRA_TH.items(): t = t.replace(k, v)
    t = GEMCART.sub(lambda m: f"โบนัสคริสตัล#{m.group(1)}[{m.group(2)}]", t)
    if len(t) > 170: t = t[:167] + "…(ย่อ)"
    return re.sub(r"\s+", " ", t).strip()


class Resolver:
    """Substitutes skill fields (`skillRate`, `targetFixAddDamage` ...) into a term formula for one weapon scenario."""

    def __init__(self, spec):
        self.f = collections.defaultdict(list)
        for it in spec.get("fields", []):
            if it.get("kind") in ("set", "info") and it.get("formula") is not None:
                self.f[it["name"]].append(it)

    def cands(self, name, scen):
        out = []
        for it in self.f.get(name, []):
            ok, alive = eval_when(it.get("when", "always"), scen)
            if ok: out.append((it, alive))
        return out

    def expand(self, text, scen, depth=0, skip=(), conds=()):
        """-> list of (formula text, conditions of the fields that were substituted); symbolic names stay when nothing can be substituted.
        Per-hit variables (HIT_VARS) are never substituted: their value depends on which hit is being computed."""
        return [(t, cs) for t, cs, _ in self.expand3(text, scen, depth, skip, conds)]

    def expand3(self, text, scen, depth=0, skip=(), conds=(), raws=()):
        """expand() that also returns, per alternative, the raw condition clauses (lists of decoder atoms, OR of ANDs) of every substituted field: the machine form needs the atoms, not the Thai text"""
        names = [n for n in dict.fromkeys(NAME_RX.findall(text)) if n in self.f and n not in skip and n not in ("Lv", "lv") and n not in HIT_VARS]
        if not names or depth >= 3: return [(text, tuple(conds), tuple(raws))]
        per = []
        for n in names:
            base = []
            for it, alive in self.cands(n, scen):
                if re.search(rf"(?<![\w.]){re.escape(n)}(?![\w\[])", it["formula"]): continue    # self-referencing modifier
                base.append(((it["formula"], cond_text(alive)), json.dumps([alive, cond_text(alive)], ensure_ascii=False)))
            seen = {}
            for k, a in base: seen.setdefault(k, a)          # first raw wins; same dedupe key (formula, text) and order as before, so the output set is unchanged
            base = [(b, c, a) for (b, c), a in seen.items()]
            per.append([(n, b, c, a) for b, c, a in base] if base else [(n, None, "", "")])
        alts = []
        for combo in itertools.product(*per):
            t, cs, rs = text, list(conds), list(raws)
            for n, b, c, a in combo:
                if b is not None: t = re.sub(rf"(?<![\w.]){re.escape(n)}(?![\w\[])", lambda m, b=b: f"({b})", t)
                if c and c not in cs: cs.append(c)
                if a and a not in rs: rs.append(a)
            alts.append((t, tuple(cs), tuple(rs)))
            if len(alts) >= 6: break
        out = []
        for t, cs, rs in dict.fromkeys(alts):
            out += self.expand3(t, scen, depth + 1, skip, cs, rs) if t != text else [(t, cs, rs)]
        return list(dict.fromkeys(out))[:6]

    def modifiers(self, text, scen):
        mods = []
        for n in dict.fromkeys(NAME_RX.findall(text)):
            for it, alive in self.cands(n, scen):
                if re.search(rf"(?<![\w.]){re.escape(n)}(?![\w\[])", it["formula"]):
                    mods.append((n, it["formula"], cond_text(alive)))
        return mods


def unwrap(t):
    """drop outer parentheses that wrap the whole text"""
    while t.startswith("(") and t.endswith(")"):
        depth = 0
        for i, ch in enumerate(t):
            depth += ch == "("
            depth -= ch == ")"
            if depth == 0 and i < len(t) - 1: return t
        t = t[1:-1].strip()
    return t


def balanced(t):
    d = 0
    for ch in t:
        d += ch == "("
        d -= ch == ")"
        if d < 0: return False
    return d == 0


def pct_source(t):
    """multiplier formula -> the same formula in percent: `(A) / 100` -> A, otherwise (t) * 100 and let exprsimp fold it"""
    u = unwrap(t.strip())
    m = re.match(r"^(.*) / 100$", u)
    if m and balanced(m.group(1)): return unwrap(m.group(1))
    return f"({u}) * 100"


def pct_formula(t):
    """multiplier text -> percent text: `(x) / 100` -> `x`, `0.01 × x` -> `x`"""
    t = unwrap(t.strip())
    m = re.match(r"^\((.*)\) / 100$", t) or re.match(r"^(.*) / 100$", t)
    if m: return m.group(1).strip()
    m = re.match(r"^0\.01 × (.*)$", t)
    if m: return m.group(1).strip()
    return f"({t}) × 100"


def present(step, text, res, scen):
    """one scenario -> list of alternatives {formula, values, lin}"""
    alts = []
    for t, cs, raws in res.expand3(text, scen):
        vals = lv_values(t)
        if vals is not None and step in PCT_STEPS: vals = [v * 100 for v in vals]
        lin = linear(vals)
        f = pretty(pct_source(t) if step in PCT_STEPS else t)
        if CTX.get("D"): f = names_th(CTX["D"], f)
        if step in PCT_STEPS: f += " %"
        _WHY.clear()
        calc = machine_alt(pct_source(t) if step in PCT_STEPS else t, raws, cs)
        alts.append({"formula": f, "values": [fnum(v) for v in vals] if vals else None, "lin": [fnum(lin[0]), fnum(lin[1])] if lin else None,
                     "when": "; ".join(cs)[:160], "calc": calc, **({"calc_why": list(_WHY)} if calc is None else {})})
    return alts


_WHY = []          # names that made the last machine_alt() give up (copied into the alternative as calc_why)


_BV = []
_TREE = {}


def skill_uid(name):
    v = _BV[0].D.vars.get("SkillId." + name)
    return v["value"] if v else None


def skill_consts(uid):
    """static data of the skill being rendered, for `skillMaster.X` in its formulas"""
    if uid is None: return {}
    if not _TREE:
        for r in csv.DictReader(open(os.path.join(BASE, "..", "skills.csv"), encoding="utf-8-sig")): _TREE[int(r["SkillUid"])] = int(r["SkillTreeType"])
    return {"skillMaster.SkillId": uid, **({"skillMaster.SkillTreeType": _TREE[uid]} if uid in _TREE else {})}
BADX = []
BAD = collections.Counter()          # why a machine form could not be built: name -> alternatives (printed by main)


def machine_alt(expr, raws, texts=None):
    """Machine form of one alternative, the same object build_buff_values gives a buff parameter: {"e": expression, "w": [conditions], "wt": [condition text that is not machine-evaluable]}
    plus {"inputs": {...}} at group level. Returns {"e", "w", "wt", "inputs"} or None when the expression holds something the page cannot ask for (raw offsets, engine objects).
    build_buff_values is imported on first use (it imports this module at top level)."""
    if not _BV:
        import build_buff_values as BV
        _BV.append(BV)
    BV = _BV[0]
    import damage_calc_rules as R
    expr, extra = R.rewrite(BV.norm(BV.inline_helpers(BV.MATH.sub(lambda m: m.group(1).lower() + "(", expr))), skill_uid, skill_consts(CTX.get("uid")))          # norm first: it turns the equipment-slot probe into WeaponType / SubWeaponType before the rules rewrite calls          # lower-case Math.Max/Min first: the decoded helper body of Min is an unsigned byte compare
    (ce,), inputs, bad = BV.canon([BV.norm(expr)])
    inputs.update({k: v for k, v in extra.items() if k in inputs})
    if bad:
        BAD.update(bad)
        _WHY[:] = sorted(bad)[:6]
        if os.environ.get("DUMP_BAD"): BADX.append([sorted(bad), expr])
        return None
    w, wt = [], []
    for raw in raws:          # [clause list of a substituted field, its Thai text]
        clauses, txt = json.loads(raw)
        w_i, ok = [], True
        for clause in clauses:
            atoms = [a for a in clause if not BV.NOISE.search(a) and a.strip() != "BuffEffectActive ne 0"]          # the buff is running whenever its row is shown
            if not atoms: w_i = []; break          # an unconditional clause makes the whole OR true
            cond, extra_c = R.rewrite(BV.norm(BV.inline_helpers(BV.MATH.sub(lambda m: m.group(1).lower() + "(", " && ".join(f"({a})" for a in atoms)))), skill_uid, skill_consts(CTX.get("uid")))
            (cc,), ic, badc = BV.canon([BV.norm(cond)])
            if badc: ok = False; break
            ic.update({k: v for k, v in extra_c.items() if k in ic})
            inputs.update(ic); w_i.append(f"({cc})")
        if ok and w_i: w.append(" || ".join(w_i))
        elif not ok: wt.append(txt)
    return {"e": ce, "w": w, **({"wt": wt} if wt else {}), "inputs": inputs}


def sub_label(s):
    return "อื่นๆ" if s == "OTHER" else WEAP.get(s, s)


def scen_label(group):
    """list of (main, sub) -> compact Thai label"""
    mains = collections.defaultdict(set)
    for m, sb in group: mains[m].add(sb)
    allsubs = SUBS_ALL.get("set", set())
    parts = []
    for m, subs in mains.items():
        mn = WEAP.get(m, m)
        rest = allsubs - subs
        if subs == allsubs: parts.append(mn)
        elif m == "OneHandSword" and subs == {"OneHandSword"}: parts.append("ดาบคู่ (ดาบมือเดียว 2 เล่ม)")
        elif rest and len(rest) <= 2 and len(subs) > len(rest): parts.append(f"{mn} + มือรองที่ไม่ใช่ " + "/".join(sub_label(x) for x in sorted(rest)))
        else: parts.append(f"{mn} + มือรอง " + "/".join(sub_label(x) for x in sorted(subs)))
    return " | ".join(parts)


SUBS_ALL = {}


def weapon_names_in(a):
    """weapon item-type names mentioned by one atom (names, ItemType.X, small integers next to a weapon variable)"""
    out = set()
    if not WTOKEN.search(a): return out
    for m in re.finditer(r"\b(OneHandSword|TwoHandSword|Bow|Bowgun|Rod|Magictool|Knuckle|Halberd|Katana|Shield|ShortSword|Arrow|NinjutsuBook|Null)\b", a): out.add(m.group(1))
    for m in re.finditer(r"(?:\b(?:eq|ne|==|!=)\s+|ExistWeaponType\(\w+, )(\d{1,2})\b", a):
        n = int(m.group(1))
        if n in ITEMTYPE and n != 0: out.add(ITEMTYPE[n])
    return out


def scenarios(spec, ref):
    lim = [x for x in (ref.get("eq_limit") or []) if isinstance(x, str) and x in WEAP]
    names, used = set(), False
    for sec in ("terms", "fields", "effects"):
        for it in spec.get(sec, []):
            for a in re.split(r"\s+(?:AND|OR)\s+", it.get("when") or ""):
                if WTOKEN.search(a):
                    used = True
                    names |= weapon_names_in(a)
    if not used: return [{"main": "ANY", "sub": "ANY"}], False
    mains = lim or sorted(names - {"Null", "Arrow", "Shield"}) + ["OTHER"]
    subs = sorted((names & SUB_OK) | {"Null"}) + ["OTHER"]
    subs = list(dict.fromkeys(subs))[:9]   # ponytail: sub-weapon names capped at 9 + OTHER, raise if a skill names more
    out = [{"main": m, "sub": s_, "env": scen_env(m, s_)} for m in mains for s_ in subs]
    return out, True


# ------------------------------------------------------------------ damage section
def parse_args(call):
    m = re.match(r"^[\w.$]+\((.*)\)$", call.strip())
    if not m: return []
    out, depth, cur = [], 0, ""
    for ch in m.group(1):
        if ch in "([": depth += 1          # not `<` `>`: the shifts `<<` `>>` are not generics and cut `(x << 2), playerAction` at the wrong comma (ailment chance rows showed ", playerAction")
        if ch in ")]": depth -= 1
        if ch == "," and depth == 0: out.append(cur.strip()); cur = ""
        else: cur += ch
    out.append(cur.strip())
    return out


def split_ternary(text):
    """`(c ? a : b)` at top level -> (c, a, b) else None"""
    t = unwrap(text.strip())
    depth, q, col = 0, None, None
    for i, ch in enumerate(t):
        depth += ch in "(["
        depth -= ch in ")]"
        if depth == 0 and ch == "?" and q is None: q = i
        elif depth == 0 and ch == ":" and q is not None and col is None: col = i
    if q is None or col is None: return None
    return t[:q].strip(), t[q + 1:col].strip(), t[col + 1:].strip()


def expand_ternaries(terms):
    """a term whose formula is `(hitVar op K ? A : B)` is two terms, one per hit case"""
    out = []
    for t in terms:
        sp = split_ternary(t["formula"])
        m = SIMPLE.match(sp[0]) if sp else None
        if sp and m and m.group(1) in HIT_VARS:
            c = sp[0]
            for f, cond in ((sp[1], c), (sp[2], neg(c))):
                w = t.get("when", "always")
                nw = cond if w in ("", "always") else " OR ".join(f"{cl} AND {cond}" for cl in re.split(r"\s+OR\s+", w))
                out.append({**t, "formula": f, "when": nw})
        else: out.append(t)
    return out


def weapon_cond(scen, scs):
    """the weapon scenarios of one group -> one machine condition over WeaponType / SubWeaponType (item type ids), None when the group is every scenario or a name has no id"""
    mains = {s["main"] for s in scs} - {"OTHER", "ANY"}
    subs = {s["sub"] for s in scs} - {"OTHER", "ANY"}

    def side(var, name, named):
        if name == "ANY": return ""
        if name == "OTHER": return "(" + " && ".join(f"{var} != {ITEM_ID[n]}" for n in sorted(named, key=ITEM_ID.get)) + ")" if named else ""
        return f"{var} == {ITEM_ID[name]}" if name in ITEM_ID else None
    all_subs = {s["sub"] for s in scs}
    by_main = collections.OrderedDict()
    for m, s_ in dict.fromkeys(scen): by_main.setdefault(m, set()).add(s_)
    terms = []
    for m, ss in by_main.items():
        a = side("WeaponType", m, mains)
        if a is None: return None
        if ss >= all_subs:          # every sub weapon: the main weapon alone decides
            terms.append(a or "1")
            continue
        for s_ in ss:
            b = side("SubWeaponType", s_, subs)
            if b is None: return None
            terms.append(" && ".join(x for x in (a, b) if x) or "1")
    wc = " || ".join(f"({x})" for x in dict.fromkeys(terms))
    members = set(scen)
    for sc in scs:          # self-check: the condition holds for exactly the scenarios of the group (OTHER = a weapon type no scenario names, 99)
        if "ANY" in (sc["main"], sc["sub"]): continue
        env = {"WeaponType": ITEM_ID.get(sc["main"], 99), "SubWeaponType": ITEM_ID.get(sc["sub"], 99)}
        assert bool(CE.Evaluator(env=env).truth(wc)) == ((sc["main"], sc["sub"]) in members), (wc, sc)
    return wc


def with_weapon_calc(alts, scen, scs):
    """copy the alternatives and fold the group's weapon condition into every machine form (`w`), registering the two selector inputs"""
    wc = weapon_cond(scen, scs) if scen else ""
    out = []
    for a in alts:
        c = a.get("calc")
        if c is not None:
            c = {"alts": [{"e": c["e"], "w": ([wc] if wc and wc != "1" else []) + c["w"], **({"wt": c["wt"]} if c.get("wt") else {})}],
                 "inputs": {**c["inputs"], **({"WeaponType": {"kind": "weapon", "th": "อาวุธหลัก"}, "SubWeaponType": {"kind": "weapon", "th": "อาวุธรอง"}} if wc and wc != "1" else {})}}
            if wc is None: c["partial"] = True          # a weapon the scenario names has no item type id: the group condition is missing
        out.append({**a, "calc": c})
    return out


def damage_section(D, uid, spec, ref):
    CTX["uid"] = uid
    res = Resolver(spec)
    scs, scenario_split = scenarios(spec, ref)
    SUBS_ALL["set"] = {s["sub"] for s in scs}
    SUBS_ALL["named"] = {s["sub"] for s in scs if s["sub"] not in ("OTHER", "ANY")}
    rows = collections.OrderedDict()
    for t in expand_ternaries(spec.get("terms", [])):
        step = t["step"]
        if t["method"].startswith("via "): continue
        per, clauses = [], []
        for sc in scs:
            ok, alive = eval_when(t.get("when", "always"), sc)
            if not ok: continue
            per.append((sc, present(step, t["formula"], res, sc), res.modifiers(t["formula"], sc)))
            clauses += alive
        if not per: continue
        # split every surviving clause into hit atoms (which hit this term belongs to) and the rest (extra condition)
        by_hit = collections.OrderedDict()
        for c in clauses:
            hk = tuple(sorted(a for a in c if is_hit_atom(a)))
            by_hit.setdefault(hk, []).append([a for a in c if not is_hit_atom(a)])
        hk_merged = merge_complements([list(k) for k in by_hit])
        groups = collections.OrderedDict()
        for sc, alts, mods in per:
            key = json.dumps([[{k: v for k, v in a.items() if k not in ("calc", "calc_why")} for a in alts], mods], ensure_ascii=False, sort_keys=True)          # the machine form never splits a group
            groups.setdefault(key, {"scen": [], "alts": alts, "mods": mods})["scen"].append((sc["main"], sc["sub"]))
        gl = []
        for g in groups.values():
            label = scen_label(g["scen"]) if scenario_split and len(groups) > 1 else ""
            gl.append({"weapons": label, "alts": with_weapon_calc(g["alts"], g["scen"] if scenario_split and len(groups) > 1 else None, scs), "mods": [{"var": a, "formula": names_th(D, pretty(b)), "when": c} for a, b, c in g["mods"]]})
        for hk in hk_merged:
            others = [o for k, os_ in by_hit.items() if set(hk) <= set(k) for o in os_]
            note = "" if any(not o for o in others) else cond_text(others)
            ix = re.match(r"^\(?\w+\[(\d+)\]", t["formula"].strip())
            rows.setdefault((t["method"], cond_text([list(hk)])), []).append(
                {"step": step, "step_th": STEP_TH.get(step, step), "op": t["op"], "note": note, "groups": gl, "idx": int(ix.group(1)) if ix else None})
    hits = []
    for (method, cond), rs in rows.items():
        rs.sort(key=lambda r: STEP_ORDER.index(r["step"]) if r["step"] in STEP_ORDER else 99)
        m = re.match(r"^Calc(\w+?)Damage$", method)
        hits.append({"method": method, "title": METHOD_TH.get(method) or (f"ท่า {m.group(1)}" if m else method), "cond": cond, "rows": rs})
    # ailments (weapon dependent chance)
    ail = []
    for e in spec.get("effects", []):
        if e["name"] != "PlayerAttackBase.checkAbnormalPercent": continue
        a = parse_args(e["formula"])
        if len(a) < 2: continue
        try: aid = int(a[0])
        except ValueError: continue
        per = []
        for sc in scs:
            ok, alive = eval_when(e.get("when", "always"), sc)
            if ok: per.append((sc, present("Percent", a[1], res, sc)))
        groups = collections.OrderedDict()
        for sc, alts in per: groups.setdefault(json.dumps([{k: v for k, v in a.items() if k not in ("calc", "calc_why")} for a in alts], ensure_ascii=False), {"scen": [], "alts": alts})["scen"].append((sc["main"], sc["sub"]))
        for g in groups.values():
            split_ = scenario_split and len(groups) > 1
            ail.append({"type": D.abn_id.get(aid, f"AbnormalType {aid}"), "weapons": scen_label(g["scen"]) if split_ else "", "alts": with_weapon_calc(g["alts"], g["scen"] if split_ else None, scs)})
    seen, ail2 = set(), []
    for x in ail:
        k = json.dumps(x, ensure_ascii=False)
        if k not in seen: seen.add(k); ail2.append(x)
    split = any(len(r["groups"]) > 1 for h in hits for r in h["rows"]) or any(a["weapons"] for a in ail2)
    return {"split": split, "hits": hits, "ailments": ail2, "scenarios": len(scs)}


# ------------------------------------------------------------------ casting states / buffs / links
def walk_calls(rec):
    """yield (where, call name, args list, path cond) for the action and its buff classes"""
    srcs = [("", rec["methods"])] + [(bn + ".", b) for bn, b in rec.get("buffs", {}).items()]
    for pre, ms in srcs:
        for mk, m in ms.items():
            if not isinstance(m, dict) or "paths" not in m: continue
            where = pre + mk.split("@")[0]
            for p in m["paths"]:
                for c in p.get("calls", []):
                    yield where, c[0].replace("virtual ", ""), (c[1] if len(c) > 1 else []), p.get("cond", []), p.get("fields", {})


EXTRA_STATES = {   # decoded outside the skill's own action (the mastery / buff class that owns the effect); Code
    978: [("invincible", "ตอนโดนดาเมจ มีโอกาสติดคงกระพัน 2 วินาที: โอกาส % = int(AGI(ที่ลงเอง) ÷ 3.5) + 2×Lv + 10, ต้องถือทวน (Halberd) เป็นอาวุธหลัก, ใช้ได้ไม่เกิน 1 ครั้งต่อ 10 วินาที (เวลาจริง)",
           "GodSpearHandlingMastary.CheckEffectiveIveinvincible + HandlingerOfGodspeedBuf.DamageFunction -> AddTimeInvincibility(2, 0)")],
}


def cast_states(D, uid, ref):
    out, seen = [], set()
    rec = D.recipes.get(uid)

    def add(kind, text, ev, cond):
        k = (kind, text)
        if k in seen: return
        seen.add(k)
        out.append({"kind": kind, "text": text, "evidence": ev, "label": "Code", "cond": cond})

    if rec:
        for where, name, args, cond, fields in walk_calls(rec):
            wc = cond_text([[c for c in cond if atom_weapon(c)]]) if any(atom_weapon(c) for c in cond) else ""
            if name.endswith("AddInvincibilityTemporarilyInAction"):
                t = args[-1] if args else "?"
                add("invincible", f"คงกระพัน (สถานะ Invincibility) ตั้งแต่เริ่มท่า จนถอดตอนจบท่า — เพดาน {t} วินาที", f"{where}: {name}", wc)
            elif name.endswith("AddTimeInvincibility"):
                add("invincible", f"คงกระพันตามเวลา {args[0] if args else '?'} วินาที (ถอดเมื่อจบท่า/ครบเวลา)", f"{where}: {name}", wc)
            elif name.endswith("AddSkillMotionInvincibility") or name.endswith("AddMotionInvincibility"):
                add("invincible", "คงกระพันตามช่วงของแอนิเมชันท่า (motion) จนกว่าท่าจบ", f"{where}: {name}", wc)
            elif name.endswith("EndSuperArmor"):
                add("super_armor", "Super Armor: ไม่สะดุด/ไม่ถูกขัดเมื่อโดนตี จนกว่าจะเรียก EndSuperArmor", f"{where}: {name}", wc)
            elif name.endswith("AddAbnormalState") and "AbnormalStateManager" in name and args and str(args[0]).isdigit():
                n = int(args[0])
                if n in (25, 26, 27, 252): add("invincible", f"ใส่สถานะ {D.abn_id.get(n, n)} ให้ตัวเอง", f"{where}: {name}", wc)
            for k, v in fields.items():
                if k == "isSuperArmor" and str(v) == "1" and "Buf" in where:
                    add("super_armor", "Super Armor: ไม่สะดุด/ไม่ถูกขัดเมื่อโดนตี (ธงบัพ isSuperArmor = 1)", f"{where}: set {k}", "")
                if k == "IsSkillGuard" and str(v) == "1":
                    add("guard", "ท่านี้นับเป็น Guard ของสกิล (IsSkillGuard = 1)", f"{where}: set {k}", "")
    for kind, text, ev in EXTRA_STATES.get(uid, []):
        add(kind, text, ev, "")
    return out


def names_th(D, text):
    """readable names for decoder calls inside buff / hook formulas"""
    t = re.sub(r"SkillBufferDataBase\.GetParam\([^()]*?\[(?:SkillId\.)?(\w+)\], SkillBufferId\.(\w+)\)",
               lambda m: f"{m.group(2)} ของบัพ {D.sname(D.name2uid[m.group(1)]) if m.group(1) in D.name2uid else D.sname(int(m.group(1))) if m.group(1).isdigit() else m.group(1)}", text)
    t = re.sub(r"SkillBufferManager\.GetSkillBufferParam\(PlayerStatusBase\.get_SkillBufferManager\(\), SkillBufferId\.(\w+)\)", r"ค่า \1 รวมจากบัพทุกตัว", t)
    t = re.sub(r"EquipBuffManager\.GetParam\(PlayerStatusBase\.get_EquipBuffManager\(\), BonusType\.(\w+)\)", r"โบนัสอุปกรณ์ \1", t)
    t = re.sub(r"TryGetBuf(?:<\w+>)?\.(?:out2|buf)\(PlayerStatusBase\.get_SkillBufferManager\(\), (\d+)(?:, \(this \+ \d+\))?\)\.(\w+)",
               lambda m: f"{m.group(2)} ของบัพ {D.sname(int(m.group(1)))}", t)
    t = re.sub(r"SkillMasteryBase\.GetMasteryParam\(MasteryId\.(\w+)\)", r"ค่า \1 ของมาสเตอรี่", t)
    t = re.sub(r"SkillManager\.GetSkillLv\([^()]*?(\d+), 1(?:, 0)?\)", lambda m: f"Lv สกิล {D.sname(int(m.group(1)))}", t)
    return t


def buff_effects(D, ref):
    res = []
    for cls, b in (ref.get("buffs") or {}).items():
        for p in b.get("get_param") or []:
            pid = p["bonus"]
            grp = "defense" if pid in DEFENSE else "offense" if pid in OFFENSE else "speed" if pid in SPEED else "other"
            val = p["value"]
            vals = lv_values(re.sub(r"\bCount\b", "1", val)) if "Count" in val else lv_values(val)
            res.append({"buff": cls, "id": pid, "id_th": D.bufparam.get(pid) or pid, "group": grp, "formula": names_th(D, pretty(val)),
                        "values": [fnum(v) for v in vals] if vals else None, "when": cond_text([[c for c in p.get("when", [])]]) if p.get("when") else ""})
    nonzero = {r["id"] for r in res if r["formula"] not in ("0", "0.0")}
    dedup, seen = [], {}
    for r in res:
        if r["formula"] in ("0", "0.0") and r["id"] in nonzero: continue
        k = (r["id"], r["formula"])
        if k not in seen: seen[k] = r; dedup.append(r)
        elif seen[k]["when"] != r["when"]: seen[k]["when"] = ""
    return dedup


def passive_effects(D, spec):
    ps = (spec or {}).get("passives") or {}
    out = []
    for k, v in (ps.get("bonuses") or {}).items():
        vals = v.get("by_level")
        out.append({"id": k, "id_th": (D.vars.get(f"MasteryId.{k}") or {}).get("gloss_th") or k, "formula": pretty(str(v.get("expr"))),
                    "values": [fnum(x) for x in vals] if isinstance(vals, list) and len(vals) >= 10 else None})
    return out


def action_flags(cls):
    f = FLAGS.get(cls) if cls else None
    if not f: return None
    return {k: f[k] for k in ("IsInterruptable", "IsHitRigidity", "IsMoveAssistContinue") if k in f}


def buff_names(ref):
    return list((ref.get("buffs") or {}).keys())


def self_buffer_targets(D, uid):
    rec = D.recipes.get(uid)
    out = []
    if not rec: return out
    for where, name, args, cond, fields in walk_calls(rec):
        if name.endswith("AddSelfBuffer") and len(args) >= 2:
            a = str(args[1]).strip()
            tgt = int(a) if a.isdigit() else D.name2uid.get(a.replace("SkillId.", ""))
            if tgt and tgt != uid and tgt not in out: out.append(tgt)
    return out


def links(D, uid, ref, spec):
    reads = []
    for v in (spec or {}).get("variables", []):
        m = re.match(r"^(?:SkillId|MasteryId)\.(\w+)$", v)
        if m:
            t = D.name2uid.get(m.group(1))
            if t and t != uid: reads.append({"uid": t, "name": D.sname(t), "kind": v.split(".")[0]})
    for it in (spec or {}).get("fields", []) + (spec or {}).get("terms", []):
        for m in re.finditer(r"(?:GetSkillLv|TryGetBuf(?:<\w+>)?|ContainsBuffer)\([^()]*?(?:\([^()]*\)[^()]*?)*?,\s*(\d{1,4})\b", it.get("formula", "")):
            t = int(m.group(1))
            if t in D.ref and t != uid and all(r["uid"] != t for r in reads): reads.append({"uid": t, "name": D.sname(t), "kind": "SkillId"})
    read_by = []
    for c in ref.get("consumers") or []:
        m = re.match(r"^([\w.<>`]+)\$\$(\w+) \((\w+)\)$", c)
        if not m: continue
        cls, fn, via = m.groups()
        owner = D.cls2uid.get(cls.split(".")[0])
        gl = D.hookgloss.get(f"{cls}.{fn}") or ""
        read_by.append({"fn": f"{cls}.{fn}", "via": via, "self": owner == uid, "owner": owner if owner and owner != uid else None,
                        "owner_name": D.sname(owner) if owner and owner != uid else None, "what": re.sub(r"\s*\(.*\)$", "", gl)})
    return {"reads": reads[:20], "read_by": read_by, "gives_buff_of": [{"uid": t, "name": D.sname(t)} for t in self_buffer_targets(D, uid)]}


def variants_of(ref):
    n = ref.get("name_th") or ""
    parts = [p.strip() for p in re.split(r"\[[A-Z0-9]+\]", n) if p.strip()]
    tags = re.findall(r"\[([A-Z0-9]+)\]", n)
    if len(parts) < 2: return []
    return [{"tag": tags[i] if i < len(tags) else "", "name": p} for i, p in enumerate(parts)]


def game_text(ref):
    lines = []
    for ln in re.split(r"[\n]", ref.get("desc_th") or ""):
        if CAST_KW.search(ln): lines.append(("คำอธิบาย", ln.strip()))
    for n in ref.get("notes") or []:
        for ln in (n.get("text") or "").split("\n"):
            if CAST_KW.search(ln): lines.append((f"Lv{n.get('level')}", ln.strip().lstrip("*")))
    return [{"src": s, "text": t} for s, t in lines]


# ------------------------------------------------------------------ curated patterns (Code, read from the decoded actions; mapping of names Inferred)
def _balanced_replace(text, name, repl):
    """replace every `name(...)` (balanced parentheses) in text"""
    out, i = "", 0
    while True:
        j = text.find(name + "(", i)
        if j < 0: return out + text[i:]
        k, depth = j + len(name), 0
        while k < len(text):
            if text[k] == "(": depth += 1
            elif text[k] == ")":
                depth -= 1
                if depth == 0: break
            k += 1
        out += text[i:j] + repl
        i = k + 1


def _helper_expr(D, key):
    """decoded `Get<X>Bonus` helper -> short expression over `mode` / `Lv631` (Code)"""
    if key not in D.vars: return "0"      # e.g. IchijhinnokazeBuf.GetNagiBonus returns the constant 0 (decoded, not in the glossary)
    im = D.vars[key]["impls"][0]
    c = im["cases"][0]["value"]
    for n, t in (im.get("lets") or {}).items(): c = c.replace(n, "(" + t + ")")
    m = re.search(r"Level \* (\d+)", c)
    if m: return f"{m.group(1)} * Lv631"
    m = re.search(r"max\(\(\(.*?NowAttackMode \* (0x[0-9a-f]+)\) \+ (\d+)\), 0\)", c)
    if m:
        k = int(m.group(1), 16); k = k - (1 << 32) if k >= 1 << 31 else k
        return f"max(({k} * mode) + {m.group(2)}, 0)"
    m = re.search(r"NowAttackMode \* (\d+)", c)
    if m: return f"{m.group(1)} * mode"
    return "0"


def pattern_ichijhinnokaze(D):
    sp = D.spec.get(637)
    if not sp: return None
    res = Resolver(sp)
    sc = {"main": "Katana", "sub": "ANY"}
    subs = [("Nagi (凪)", "skillRates[0]", "Nagi"), ("Kariwatashi", "skillRates[1]", "Kariwatashi"), ("Hibari", "skillRates[2]", "Hibari"),
            ("Ibuki", "skillRates[3]", "Ibuki"), ("Arahae", "skillRates[4]", "Arahae")]
    rows = []
    for nm, var, key in subs:
        txt = res.expand(var, sc)[0][0]
        for owner in ("IchijhinnokazeBuf", "IchijhinnokazeAratame"):
            txt = _balanced_replace(txt, f"{owner}.Get{key}Bonus", "(" + _helper_expr(D, f"{owner}.Get{key}Bonus") + ")")
        vals = []
        for lv in LVS:
            try: vals.append(CE.Evaluator(env={"Lv": lv, "mode": 0, "Lv631": 0}).eval(txt))
            except Exception: vals = None; break
        f = pretty(txt).replace("mode", "โหมด").replace("Lv631", "Lv(Aratame)")
        rows.append({"name": nm, "rate": f + " %", "values": [fnum(v) for v in vals] if vals else None})
    return {"title": "ท่าที่ออกจากแพตเทิร์นของ Ichijhinnokaze (ลมกระโชก)",
            "lines": [
                "สถานะตั้งรับ (IchijhinnokazeBuf) มีโหมด A/B/C (NowAttackMode = 0/1/2) ตัวนับสูงสุด 3 — Code",
                "คีย์ที่กดตอนอยู่ในสถานะนี้ ออกท่า 5 แบบ (action 637 IchijhinnokazeAttackAction): " + ", ".join(n for n, _, _ in subs) + " — Code",
                "ชื่อไทยในเกม ลมสงบนิ่ง / ลมเหนือ / ลมตะวันออก / ลมตะวันตก / ลมใต้ ตรงกับ 5 ท่านี้ตามลำดับในโค้ด — Inferred (จับคู่ตามลำดับ ไม่ใช่ชื่อในโค้ด)",
                "ท่ารวม «สี่ฤดูกาล» = Setsunakenran (刹那絢爛): เปิดเมื่อถือคาตานะ + บัพ UnannouncedDestination เปิดอยู่ + บัพ Ichijhinnokaze อยู่ในโหมด activeSkill = 3 + มีเป้าหมาย — Code; "
                "การจับคู่ชื่อ «สี่ฤดูกาล» = Setsunakenran — Inferred",
                "ตอน Setsunakenran ท่าย่อยถูกบวกตัวคูณเพิ่ม (บวกเข้า skillRates): Kariwatashi +1200, Hibari +1550, Ibuki +1450, Arahae +1350 — Code",
                "โบนัสตามโหมด (ตาราง: โหมด A, ยังไม่มี Aratame): บวกเข้าท่านั้นๆ ตามสูตรด้านล่าง — Code",
                "สกิลเสริม Ichijhinnokaze Aratame (uid 631) บวกต่อ Lv: Nagi +50, Kariwatashi +30, Hibari +45, Ibuki +45, Arahae +35 — Code"],
            "table": rows}


def pattern_godhand(D):
    sp = D.spec.get(1158) or {}
    fields = []
    for b in sp.get("buffs") or []:
        for c in b.get("ctors") or []:
            fields = (c.get("fields") or {}).get("damageDownRate") or fields
    table = []
    for lv in LVS:
        val = None
        for f in fields:
            try:
                if CE.Evaluator(env={"Lv": lv, "lv": lv}).when(f["when"]): val = f["formula"]; break
            except Exception: pass
        table.append(val)
    ok = all(v is not None for v in table)
    return {"title": "ลดดาเมจระหว่างก็อดแฮนด์ (จากบัพ GodHandBuf)",
            "lines": [
                "ขณะบัพทำงาน (isSkillEnd = 0): `MobLastDamageRateUnique` = damageDownRate (ตั้งใน GodHandBuf..ctor ตามค่า lv ของบัพ) — Code",
                "damageDownRate ตามค่า lv ที่ส่งเข้าบัพ (1…10): " + (", ".join(str(v) for v in table) if ok else "?") + " — Code (lv 7/8/9 ต่ำกว่า lv 10 และ lv ≤ 6 = 90: รูปแบบนี้ผิดปกติ จึงไม่ฟันธงว่าคือเลเวลสกิลโดยตรง — Inferred)",
                "ถ้าเรียนร่างแกร่งดุจเทพ (GodRigidBody, uid 1161): `MobLastDamageRateBuf` = CutDmgRate ของมาสเตอรี่ = 90 ขณะ isSkillEnd = 0 — Code",
                "MobAttackBase.CalcLastDamage อ่าน GodHandBuf.GetParam(5) (= Unique) และ GetParam(6) (= Buf เมื่อมี GodRigidBody) และเลือกค่าที่มากกว่าเมื่อเทียบกับแหล่งลดดาเมจอื่น — Inferred จากรูปแบบ `a >= b ? a : b` ใน CalcLastDamage",
                "สถานะตายแล้วรอด 1 ครั้ง (DeathExemption) และต้านสถานะผิดปกติ (AbnormalRegist = ค่า Value ของ GodRigidBody) อยู่ในหัวข้อ 5 และ 3 — Code"],
            "table": [{"name": f"lv {i + 1}", "rate": "damageDownRate", "values": [str(table[i])] * 10 if table[i] is not None else None} for i in range(10)] if False else []}


CURATED = {629: pattern_ichijhinnokaze, 1158: pattern_godhand}


# ------------------------------------------------------------------ text rendering
HOOK_NOTE = {  # meaning of decoded consumer hooks that matter for the "link" lines (Code: the decoded body; wording is a reading of it)
    "GodHandBuf.Initalize": "เมื่อเริ่มบัพ ก็อดแฮนด์ ถ้าเรียนสกิลนี้ ตั้งสิทธิ์ «รอดตาย 1 ครั้ง» (isDeathExemption = 1)",
    "GodHandBuf.DeathExemption": "ตอนจะตายระหว่างบัพ ก็อดแฮนด์ ถ้าเรียนสกิลนี้และยังมีสิทธิ์ จะรอดตาย แล้วสิทธิ์หมด (isDeathExemption → 0)",
    "GoliathTakeShotAction.EnemyDamage": "สกิล Goliath Take Shot อ่านเลเวลสกิลนี้ตอนทำดาเมจใส่ศัตรู (ผลต่อชาร์จ/ดาเมจ ดู README ของสกิลนั้น)",
}
LV_SAMPLE = (0, 4, 9)


def vals_txt(a, unit=""):
    v = a.get("values")
    if not v: return ""
    if len(set(v)) == 1: return f"= **{v[0]}{unit}** คงที่ทุก Lv"
    return "→ " + " · ".join(f"Lv{i + 1} {v[i]}{unit}" for i in LV_SAMPLE)


def alt_line(step, alts):
    unit = "%" if step in PCT_STEPS else ""
    out = []
    for a in alts:
        if a.get("values") and len(set(a["values"])) == 1: out.append(vals_txt(a, unit))
        elif a.get("values"): out.append(f"`{a['formula']}` {vals_txt(a, unit)}")
        else: out.append(f"`{a['formula']}` (ขึ้นกับค่าสถานะ/สถานการณ์จริง)")
        if len(alts) > 1 and a.get("when"): out[-1] += f" — เมื่อ {a['when']}"
    return out[0] if len(out) == 1 else " หรือ ".join(f"[{x}]" for x in out)


def buff_line(b):
    base = f"{b['id_th']} (`{b['id']}`) "
    if b.get("values"):
        v = b["values"]
        base += vals_txt(b) if len(set(v)) == 1 else f"`{b['formula']}` " + vals_txt(b)
    else: base += f"= `{b['formula']}`"
    return base + (f" — เมื่อ {b['when']}" if b.get("when") else "")


def render(D, uid, rec):
    L = []
    ref = D.ref[uid]
    L.append(f"### {short_name(ref.get('name_th'))} ({ref.get('name_en') or ref.get('class') or ''}) · uid {uid}")
    lim = ref.get("eq_limit") or []
    L.append(f"- ทรี: {rec['tree_th']} · เลเวลสูงสุด: {ref.get('max_level')} · อาวุธที่ใช้ได้: {', '.join(WEAP.get(w, str(w)) for w in lim) if lim else 'ไม่จำกัด/ไม่ระบุ'}")
    dm = rec["damage"]
    if dm and dm["hits"]:
        pr = (D.spec.get(uid) or {}).get("proration") or {}
        dt = DAMAGE_TYPE.get(uid) or {}
        slot = SLOT_TH.get(pr.get("slot")) or dt.get("note") or pr.get("slot") or "-"
        L.append(f"- ประเภทดาเมจ: {dt.get('th') or pr.get('attack_type') or '-'} · Proration: {slot} ({pr.get('mode', '-')})")
    L.append("")
    if rec["variants"]:
        L.append("**ชื่อ/รูปแบบของสกิล (จากข้อความในเกม):** " + " · ".join(f"[{v['tag'] or 'N'}] {v['name']}" for v in rec["variants"]))
        L.append("")
    L.append("#### 1) ตัวคูณดาเมจมาจากไหน")
    if dm and dm["hits"]:
        L.append("- สูตรโดยรวม (คร่าว): ดาเมจ ≈ [ (ฐาน ATK/MATK − DEF เป้า) + ค่าคงที่สกิล ] × ตัวคูณสกิล% × Proration × ตัวคูณสุดท้ายต่างๆ (ดู ENGINE.md) — Code")
        if rec["sources"]: L.append("- ตัวคูณสกิลขึ้นกับ: " + ", ".join(rec["sources"]))
        for h in dm["hits"]:
            L.append(f"- **{h['title']}**" + (f" — {h['cond']}" if h["cond"] else ""))
            for r in h["rows"]:
                for g in r["groups"]:
                    wp = f"[{g['weapons']}] " if g["weapons"] else ""
                    ix = f"[ช่องที่ {r['idx'] + 1} ของอาร์เรย์ต่อฮิต] " if r.get("idx") is not None else ""
                    L.append(f"  - {r['step_th']} (`{r['step']}`, {r['op']}) {ix}{wp}{alt_line(r['step'], g['alts'])}" + (f" — เมื่อ {r['note']}" if r.get("note") else ""))
                    for m in g["mods"]: L.append(f"    - ตัวปรับ `{m['var']}`: `{m['formula']}`" + (f" เมื่อ {m['when']}" if m["when"] else ""))
        if dm["ailments"]:
            L.append("- สถานะผิดปกติที่ติดเป้า:")
            for a in dm["ailments"]:
                L.append(f"  - {a['type']} {('[' + a['weapons'] + '] ') if a['weapons'] else ''}โอกาส {alt_line('Percent', a['alts'])}")
    else:
        L.append("- สกิลนี้ไม่มี damage term ที่ถอดได้ (บัพ/พาสซีฟ/ซัพพอร์ต หรือคำนวณฝั่งอื่น)")
    deps = rec["links"]["reads"]
    if deps: L.append("- อ่านค่าจากสกิลอื่นในสูตร/เงื่อนไข: " + ", ".join(f"{d['name']} ({d['kind'].replace('Id', '')})" for d in deps))
    L.append("")
    if dm and dm["split"]:
        L.append("#### 2) แยกตามอาวุธ")
        L.append("ค่าต่างกันตามอาวุธหลัก/รอง — ดูบรรทัดที่มี [อาวุธ] ในหัวข้อ 1 (บรรทัดที่ไม่มีวงเล็บอาวุธ ใช้เหมือนกันทุกแบบ) — Code")
        L.append("")
    L.append("#### 3) ระหว่างใช้สกิล")
    any_state = False
    for s in rec["cast_states"]:
        any_state = True
        L.append(f"- {s['text']}" + (f" (เฉพาะ {s['cond']})" if s["cond"] else "") + f" — Code · `{s['evidence']}`")
    fl = rec.get("flags")
    if fl:
        any_state = True
        m = {0: "ไม่", 1: "ใช่"}
        L.append(f"- ธงของท่า: IsInterruptable = {m.get(fl.get('IsInterruptable'), fl.get('IsInterruptable'))} · IsHitRigidity = {m.get(fl.get('IsHitRigidity'), fl.get('IsHitRigidity'))} "
                 f"— Code (ค่าตามโค้ด; ความหมายตามชื่อ ยังไม่ยืนยันในเกม — Inferred)")
    defs = [b for b in rec["buffs"] if b["group"] == "defense"]
    if defs:
        any_state = True
        L.append("- บัพป้องกันระหว่างบัพทำงาน — Code:")
        if any(b["id"].startswith("MobLastDamageRate") for b in defs):
            L.append("  - (`MobLastDamageRate*` เข้าสูตรดาเมจที่มอนทำใส่ผู้เล่นใน `MobAttackBase.CalcLastDamage` — ค่านี้คือส่วนลดดาเมจที่ได้รับ; หน่วยและการรวมกับบัพอื่นยังไม่ยืนยัน — Inferred)")
        for b in defs: L.append(f"  - {buff_line(b)}")
    for p in rec["passives"]:
        any_state = True
        L.append(f"- พาสซีฟ/มาสเตอรี่: {p['id_th']} (`{p['id']}`) " + (vals_txt(p) if p.get("values") else f"= `{p['formula']}`") + " — Code")
    for g in rec["game_text"]:
        any_state = True
        L.append(f"- ข้อความในเกม ({g['src']}): {g['text']} — Text")
    if rec["game_text"] and not any(c["kind"] in ("invincible", "super_armor") for c in rec["cast_states"]):
        hooks = [r["fn"] for r in rec["links"]["read_by"] if not r["owner"] and re.match(r"^(MobAttackBase|PlayerActionManager\.Damaged|PlayerBattleManager|MobaPlayer)", r["fn"])]
        L.append("- ผลตามข้อความข้างบนไม่ได้ตั้งผ่านการเรียกสถานะใน action; ฟังก์ชันที่อ่านบัพ/สกิลนี้เกี่ยวกับดาเมจที่ได้รับ: "
                 + (", ".join(f"`{h}`" for h in hooks) if hooks else "ยังไม่พบ (ดู 'ที่ยังไม่รู้' ใน README)") + " — Inferred")
    if not any_state: L.append("- ไม่พบสถานะพิเศษระหว่างท่าใน action นี้")
    L.append("")
    other = [b for b in rec["buffs"] if b["group"] != "defense"]
    if other:
        L.append("#### 4) บัพที่ได้จากสกิลนี้")
        for b in other: L.append(f"- {buff_line(b)}")
        L.append("")
    lk = rec["links"]
    L.append("#### 5) เชื่อมกับสกิลอื่น")
    ok = False
    for g in lk["gives_buff_of"]:
        ok = True; L.append(f"- สกิลนี้ใส่บัพของสกิล {g['name']} (uid {g['uid']}) — Code")
    for r in rec["boosted_by"]:
        ok = True
        L.append(f"- ได้รับการเสริมจากสกิล {r['name']} (uid {r['uid']}): `{r['fn']}` ({r['via']})" + (f" — {HOOK_NOTE[r['fn']]}" if r["fn"] in HOOK_NOTE else f" — {r['what']}" if r["what"] else "") + " — Code")
    for r in lk["read_by"]:
        if r["self"]: continue
        ok = True
        who = f"{r['owner_name']} (uid {r['owner']})" if r["owner"] else "ระบบ/เอนจิน"
        L.append(f"- ถูกอ่านโดย {who} ผ่าน `{r['fn']}` ({r['via']})" + (f" — {HOOK_NOTE[r['fn']]}" if r["fn"] in HOOK_NOTE else f" — {r['what']}" if r["what"] else "") + " — Code")
    if not ok: L.append("- ไม่พบ")
    L.append("")
    if rec.get("pattern"):
        p = rec["pattern"]
        L.append(f"#### 6) {p['title']}")
        for ln in p["lines"]: L.append(f"- {ln}")
        for r in p["table"]: L.append(f"  - {r['name']}: `{r['rate']}`" + (f" {vals_txt({'values': r['values']})}" if r["values"] else ""))
        L.append("")
    return "\n".join(L)


ENGINE_MD = """# Damage engine in one page (ENGINE)

Source: `engine.json` (hand-verified `SkillCalcTemplate.GetDamage`; the RVA is in `engine.json` evidence) + `CORE_FORMULAS.md`. Label **Code**.

## Rough formula

```
d = BaseDamage + SkillConstantDamage + BufferConstantDamage + Def(negative) + FirstAttack ; d = max(d, 0)
d = d x CriticalRate                      (only on a critical hit; this skill's own critical bonus)
d = d x ElementBonus x ElementResist x PowerWave
d = d x SkillRate                         <- the skill's own multiplier (%)
d = d x FirstAttackRate x AutoSkillRate x StableRate
d = d + AutoSkillConstant
d = d x ExpRate                           <- proration (slot Skill / Magic / Normal)
d = d x TypeDamageRate x LastDamageRate x DistanceResist x SpecialLastDamage x GemDamage x AbnormalDamageIncrease
d = d + LastConstantDamage ; cap by DamageLimit / MinDamage / MaxDamage ; x SpecificWeaponLastDamage
```

Every Rate step is truncated to an integer. `AddRate` / `AddConstant` written into the same slot are **summed**; `SetRate` / `SetConstant` **replace** the slot.

## Where the multiplier comes from

| Part | Comes from |
|---|---|
| BaseDamage | player ATK (physical) or MATK (magic), computed per weapon type (`CORE_FORMULAS.md`) minus the target's DEF/MDEF |
| SkillRate, SkillConstantDamage | the skill itself: `skillRate`, `fixAddDamage` and similar fields, usually linear in Lv, sometimes plus STR/DEX/INT and weapon-dependent |
| BufferConstantDamage, LastDamageRate, StableRate | buffs / masteries / other skills read by the damage code (see section 5 of each skill) |
| ExpRate | proration of the target for the skill's slot |
| the rest | player/mob stats, gems, element, distance (no skill involvement) |

## Reading a skill entry

1. **ตัวคูณดาเมจมาจากไหน**: each hit (calc method), each step of the formula, with Lv values. A `[weapon]` prefix means that value is used only with that main/sub weapon.
2. **แยกตามอาวุธ**: present when any value depends on the equipped weapons.
3. **ระหว่างใช้สกิล**: invincibility / super armor calls decoded from the action, defensive buff parameters, and in-game text that mentions them.
4. **บัพที่ได้**: the other buff parameters (offence, speed, ...).
5. **เชื่อมกับสกิลอื่น**: buffs of other skills this skill adds, and other skills / engine functions that read this skill.
6. **แพตเทิร์น/พิเศษ**: only for skills with a hand-checked decoded chain (currently Ichijhinnokaze, GodHand).
"""


def tree_key(ref):
    return str(ref.get("tree_type")) if ref.get("tree_type") is not None else "(internal)"


def _no_calc(o):
    if isinstance(o, dict): return {k: _no_calc(v) for k, v in o.items() if k not in ("calc", "calc_why")}
    if isinstance(o, list): return [_no_calc(x) for x in o]
    return o


def sources_of(dm):
    if not dm or not dm["hits"]: return []
    txt = json.dumps(_no_calc(dm["hits"]), ensure_ascii=False)          # the machine form is not display text
    out = []
    stats = sorted({v for v in STAT_TH.values() if v in txt})
    if re.search(r"\bLv\b", txt): out.append("เลเวลสกิล (Lv)")
    if stats: out.append("สถานะ " + "/".join(stats))
    if dm["split"]: out.append("อาวุธหลัก/รองที่ถือ")
    if re.search(r"บัพ|มาสเตอรี่|Lv สกิล", txt): out.append("บัพ/มาสเตอรี่/สกิลอื่น")
    return out


FLAGS = {}


def build():
    global FLAGS
    D = Data()
    CTX["D"] = D
    fp = os.path.join(BASE, "overview", "action_flags.json")
    FLAGS = jload(fp) if os.path.exists(fp) else {}
    out = {}
    for uid, ref in sorted(D.ref.items()):
        sp = D.spec.get(uid)
        rec = {"uid": uid, "name_th": ref.get("name_th"), "name_en": ref.get("name_en"), "tree": tree_key(ref),
               "tree_th": D.tree_th.get(tree_key(ref)) or str(ref.get("tree") or tree_key(ref)), "max_level": ref.get("max_level"),
               "eq_limit": ref.get("eq_limit") or [], "roles": ref.get("roles") or [], "cls": ref.get("class")}
        rec["damage"] = damage_section(D, uid, sp, ref) if sp else None
        rec["sources"] = sources_of(rec["damage"])
        rec["cast_states"] = cast_states(D, uid, ref)
        rec["flags"] = action_flags(ref.get("class"))
        rec["buffs"] = buff_effects(D, ref)
        rec["passives"] = passive_effects(D, sp)
        rec["links"] = links(D, uid, ref, sp)
        rec["variants"] = variants_of(ref)
        rec["game_text"] = game_text(ref)
        rec["boosted_by"] = []
        if uid in CURATED:
            try: rec["pattern"] = CURATED[uid](D)
            except Exception as e: rec["pattern"] = None; print("pattern failed", uid, e)
        out[str(uid)] = rec
    for u, r in out.items():
        for e in r["links"]["read_by"]:
            if e["owner"] and str(e["owner"]) in out:
                out[str(e["owner"])]["boosted_by"].append({"uid": int(u), "name": short_name(D.sname(int(u))), "fn": e["fn"], "via": e["via"], "what": e["what"]})
    for u, r in out.items(): r["text"] = render(D, int(u), r)
    return out


def write(out):
    os.makedirs(os.path.dirname(OUT_JSON), exist_ok=True)
    cnt = collections.Counter()
    for r in out.values():
        cnt["skills"] += 1
        cnt["with_damage_terms"] += bool(r["damage"] and r["damage"]["hits"])
        cnt["weapon_split"] += bool(r["damage"] and r["damage"]["split"])
        cnt["cast_state_code"] += bool(r["cast_states"])
        cnt["defense_buff"] += any(b["group"] == "defense" for b in r["buffs"])
        cnt["game_text_state"] += bool(r["game_text"])
        cnt["has_link"] += bool(r["links"]["read_by"] or r["links"]["gives_buff_of"] or r["links"]["reads"])
        cnt["variants"] += bool(r["variants"])
        cnt["ailment"] += bool(r["damage"] and r["damage"]["ailments"])
    json.dump({"meta": dict(cnt), "skills": out}, open(OUT_JSON, "w", encoding="utf-8"), ensure_ascii=False)
    os.makedirs(OUT_MD, exist_ok=True)
    for f in glob.glob(os.path.join(OUT_MD, "*.md")): os.remove(f)
    trees = collections.OrderedDict()
    for r in out.values(): trees.setdefault((r["tree"], r["tree_th"]), []).append(r)
    idx = ["# คำอธิบายโดยรวมของสกิล (overview_th)", "", "สร้างโดย `scripts/build_overview.py` จาก `calc_spec/`, `skill_reference.json`, `skillrecipes/`, `variables.json` (label: Code / Inferred / Text).",
           "อ่านวิธีอ่านหน้าสกิลที่ [ENGINE.md](ENGINE.md)", "", "| ทรี | สกิล | มี damage term | แยกอาวุธ | คงกระพัน/Super Armor | บัพป้องกัน |", "|---|---|---|---|---|---|"]
    for (key, th), rs in trees.items():
        fn = re.sub(r"[^\w.-]", "_", key.strip("#()")) or "misc"
        rs.sort(key=lambda r: r["uid"])
        body = [f"# {th} ({len(rs)} สกิล)", "", "สรุปโดยรวมต่อสกิล: ตัวคูณดาเมจมาจากไหน / แยกอาวุธ / สถานะระหว่างท่า / บัพ / เชื่อมสกิลอื่น. วิธีอ่าน: [ENGINE.md](ENGINE.md)", ""]
        for r in rs: body += [r["text"], "", "---", ""]
        open(os.path.join(OUT_MD, fn + ".md"), "w", encoding="utf-8").write("\n".join(body))
        idx.append(f"| [{th}]({fn}.md) | {len(rs)} | {sum(bool(r['damage'] and r['damage']['hits']) for r in rs)} | {sum(bool(r['damage'] and r['damage']['split']) for r in rs)} | "
                   f"{sum(any(s['kind'] in ('invincible', 'super_armor') for s in r['cast_states']) for r in rs)} | {sum(any(b['group'] == 'defense' for b in r['buffs']) for r in rs)} |")
    idx += ["", "## Coverage", "", "| item | skills |", "|---|---|"] + [f"| {k} | {v} |" for k, v in cnt.items()]
    txt_inv = [u for u, r in out.items() if any(re.search("คงกระพัน|อมตะ", g["text"]) for g in r["game_text"])]
    code_inv = {u for u, r in out.items() if any(c["kind"] == "invincible" for c in r["cast_states"])}
    gap = [u for u in txt_inv if u not in code_inv]
    resid = collections.Counter()
    for r in out.values():
        for ln in r["text"].split("\n"):
            for k, rx in (("raw offset +0x..", r"\+0x[0-9a-f]+"), ("unresolved ?x/?v/?mi", r"\?(?:x|v|mi|blr|idx)\w*"), ("UnityEngine plumbing", r"UnityEngine\.")):
                if re.search(rx, ln): resid[k] += 1
    idx += ["", "## Cross-check: in-game text vs decoded code", "",
            f"- skills whose in-game text says invincible (คงกระพัน/อมตะ): {len(txt_inv)}; of them with a decoded invincibility call/effect: {len(txt_inv) - len(gap)}",
            "- text but no call in the action (effect lives in an engine hook that reads the buff; see section 3 of the skill): "
            + (", ".join(f"{short_name(out[u]['name_th'] or out[u]['name_en'] or '')} ({u})" for u in gap) or "none"),
            f"- decoded invincibility without matching in-game text: {len(code_inv - set(txt_inv))} skills (not an error: the text may omit it)",
            "", "## Open items (Inferred / not decoded)", "",
            "- `IsInterruptable` / `IsHitRigidity`: values decoded for every action class (`overview/action_flags.json`); what they do in game is read from the names only.",
            "- `MobLastDamageRate*` (damage-cut buff parameters): consumed in `MobAttackBase.CalcLastDamage`; unit and stacking with other cuts not verified in game. GodHand `damageDownRate` by buff lv (7 -> 45, 8 -> 57, 9 -> 72, else 90) is as decoded and looks non-monotonic.",
            "- Ichijhinnokaze: the mapping of the Thai names (ลมสงบนิ่ง ... สี่ฤดูกาล) to Nagi / Kariwatashi / Hibari / Ibuki / Arahae / Setsunakenran is by order (Inferred); the input pattern that sets `activeSkill = 3` (key sequence) is not decoded.",
            "- Shift (1039) / ImprovisationSong (773): protection is applied by engine hooks that read the buff; durations and exact rules not decoded here.",
            "- Skills with several name variants ([N2], [F][A][W]...) are listed by name only, except Ichijhinnokaze; the other variants are not split into their own formulas.",
            "- Weapon scenarios use: main weapon in the skill's equip limit (or every weapon named in its conditions), sub weapon in {none, other, and the sub weapons named in its conditions}. Conditions that are not weapon tests stay as text.",
            "", "## Residual markers left in the generated text (decoder output not yet readable)", ""] + [f"- {k}: {v} lines" for k, v in resid.items()]
    open(os.path.join(OUT_MD, "README.md"), "w", encoding="utf-8").write("\n".join(idx) + "\n")
    open(os.path.join(OUT_MD, "ENGINE.md"), "w", encoding="utf-8").write(ENGINE_MD)
    return cnt


def selftest(out):
    m = out["44"]
    assert m["damage"]["split"], "MeteorBreaker must split by weapon"
    t = m["text"]
    assert "ดาบสองมือ" in t and "ดาบมือเดียว" in t and "คงกระพัน" in t and "มึนงง" in t, "MeteorBreaker text"
    g = out["1158"]
    assert any(b["group"] == "defense" for b in g["buffs"]), "GodHand defensive buff"
    assert any(r["owner"] == 1158 for r in out["1161"]["links"]["read_by"]), "GodRigidBody -> GodHand link"
    assert out["629"].get("pattern"), "Ichijhinnokaze pattern"
    assert "982" in out and out["982"]["damage"]["hits"], "ThorHammer"
    print("selftest ok")


if __name__ == "__main__":
    o = build()
    c = write(o)
    print(json.dumps(c, ensure_ascii=False))
    print("machine form unsupported:", BAD.most_common(40))
    if os.environ.get("DUMP_BAD"): json.dump(BADX, open(os.environ["DUMP_BAD"], "w", encoding="utf-8"), ensure_ascii=False)
    if "--selftest" in sys.argv: selftest(o)
