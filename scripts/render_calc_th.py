import il2
"""Per-skill numeric calculation blocks (Thai) appended under each skill of skills/damage/explained_th/*.md.

For every skill: damage split per hit (calc method / hit variable such as `type`, `isFirst`, `attackCount`),
every template step with its Lv1..10 values, and a per-stack / per-charge table inside the hit when a step reads a
charge or stack variable. Stat-dependent terms are tabulated at sample stat values. Also buff values that scale with
a stack counter, and hit-count fields.
Blocks sit between `<!-- calc:begin uid=N -->` / `<!-- calc:end -->` markers, so reruns replace them in place.
Reads skill_reference.json (via render_docs); run after render_details.py.
"""
import collections, glob, itertools, math, os, re, sys
sys.path.insert(0, os.path.dirname(os.path.abspath(__file__)))
import render_docs as R
from refutil import pretty, ITEMTYPE, PRIMARY, BONUS
import exprsimp as X
ITEMTYPE_ID = {v: k for k, v in ITEMTYPE.items()}

TH_DIR = os.path.join(R.OUT, "explained_th")
LVS = range(1, 11)
STAT_SAMPLES = (100, 255)
SKILL_SAMPLES = (1, 10)
SAMPLES = {"sk_": SKILL_SAMPLES, "fn_": (100, 300), "rf_": (0, 15), "ew_": (0, 1)}

HIT_VARS = {"type", "attackType", "attackCount", "nowAttackCount", "isFirst", "isFirstAttack", "isFirstAttck", "isFristAttck", "first",
            "damageCount", "hitCount", "LoopParam", "lineAttack", "singleAttack", "direction", "attackDir", "comboType",
            "criticalAttackCount", "mainTarget", "change", "state", "isCounter", "isGuard", "arrowNum"}
METHOD_TH = {
    "calcPlayerToMobDamage": "ดาเมจหลัก", "calcFirstDamage": "ฮิต 1", "CalcFirstDamage": "ฮิต 1", "CalcFirstDamageData": "ฮิต 1",
    "calcSecondDamage": "ฮิต 2", "CalcSecondDamage": "ฮิต 2", "CalcSecondDamageData": "ฮิต 2", "calcAnyDamage": "ฮิตถัดไป (ใช้ร่วมทุกฮิตหลังฮิตแรก)",
    "calcRampageFinish": "ท่าปิดของ Rampage", "RecalcAvoidDamage": "คำนวณใหม่เมื่อเป้าหลบ", "CalcDamage": "ดาเมจ (เมธอดเสริม)",
    "via PlayerAttackBase$$HitReactionAssign": "ฮิตรีแอ็กชัน (`HitReactionAssign`)",
    "via NormalAttackAction$$calcPlayerToMobDamage": "สูตรโจมตีปกติ (`NormalAttackAction`)",
}
PART_TH = {"main": "หลัก", "sub": "รอง", "first": "ครั้งแรก", "frist": "ครั้งแรก (สะกดผิดในโค้ด)", "second": "ครั้งที่ 2", "decoy": "ร่างแยก", "bonus": "โบนัส", "pursuit": "ไล่ตาม",
           "range": "ระยะ", "singleAttack": "โจมตีเดี่ยว", "ex": "EX", "target": "เป้าหลัก", "heavenlyStar": "HeavenlyStar", "finish": "ท่าปิด",
           "powerWave": "power wave", "add": "เพิ่ม", "second_": "ครั้งที่ 2"}
STEP_TH = {
    "SkillRate": "ตัวคูณสกิล", "SkillConstantDamage": "ดาเมจคงที่ของสกิล", "BaseDamage": "ดาเมจฐาน", "Def": "หักป้องกันเป้า",
    "CriticalRate": "ตัวคูณคริติคอลเพิ่ม", "FirstAttack": "ดาเมจคงที่ตีแรก", "FirstAttackRate": "ตัวคูณตีแรก", "ExpRate": "Proration",
    "LastDamageRate": "ตัวคูณดาเมจสุดท้าย", "StableRate": "ความเสถียร", "ElementBonusRate": "โบนัสธาตุ", "BufferConstantDamage": "ดาเมจคงที่จากบัพ",
    "TypeDamageRate": "ตัวคูณประเภทดาเมจ", "GemDamageRate": "ตัวคูณเจม", "AutoSkillRate": "ตัวคูณสกิลอัตโนมัติ", "AutoSkillConstant": "ดาเมจคงที่สกิลอัตโนมัติ",
    "NormalAttackPowerWave": "power wave ตีปกติ", "NormalElementDamageResistRate": "ต้านธาตุ", "DistanceResistRate": "ต้านตามระยะ",
    "SpecialLastDamageRate": "ตัวคูณสุดท้ายพิเศษ", "AbnormalDamageIncreaseRate": "เพิ่มดาเมจเป้าติดสถานะ", "LastConstantDamage": "ดาเมจคงที่สุดท้าย",
    "GuardPower": "พลังการ์ด", "DamageLimit": "เพดานดาเมจ", "MinDamage": "ดาเมจต่ำสุด", "MaxDamage": "ดาเมจสูงสุด",
    "SpecificWeaponLastDamage": "ตัวคูณสุดท้ายตามอาวุธ", "NormalAttackTreasureHuntLastDamageRate": "ตัวคูณล่าสมบัติ",
}
OP_TH = {"AddRate": "×, บวกเข้าช่อง", "SetRate": "×, ตั้งค่าทับ", "AddConstant": "+", "SetConstant": "+, ตั้งค่าทับ", "SetCalcValue": "ตั้งค่า"}
STEP_ORDER = {v: k for k, v in R.ENUM.get("SkillCalcTemplate/CalcStep", {}).items()}
PCT_STEPS = {"SkillRate", "CriticalRate", "FirstAttackRate", "LastDamageRate"}
WEAP = {"OneHandSword": "ดาบมือเดียว", "TwoHandSword": "ดาบสองมือ", "Bow": "ธนู", "Bowgun": "โบว์กัน", "Rod": "ไม้เท้า", "Magictool": "อุปกรณ์เวท",
        "Knuckle": "สนับมือ", "Halberd": "ทวน", "Katana": "คาตานะ", "Shield": "โล่", "ShortSword": "มีด", "Arrow": "ลูกธนู", "NinjutsuBook": "ม้วนนินจุตสึ",
        "Null": "มือเปล่า", "Hand": "มือเปล่า"}
STATS = {"Str": "STR", "Dex": "DEX", "Int": "INT", "Agi": "AGI", "Vit": "VIT", "Luk": "LUK", "Crt": "CRT", "Men": "MEN", "Tec": "TEC"}
JUNK = re.compile(r"UnityEngine|op_Inequality|\?x\d|\+0x|meta\(|vtab|stkp|GetComponent|\?v\d|\?idx|\?stack|IsBlank")
HIT_INDEX = ("attackCount", "nowAttackCount")
STACK_NAMES = ("chargeLevel", "stackLevel", "chargeValue", "count", "stack")
MISNAMED = "CharacterActionManagerBase.set_DefaultMoveSpeed()"   # decoder's name for a virtual getter; in these texts it returns the charge/stack level
SAMPLE_RX = re.compile(r"\b(ew_\d+|rf_item|fn_sub|fn_main|pt_[A-Z]{3}|st_(?:Str|Dex|Int|Agi|Vit|Luk|Crt|Men|Tec)|sk_\d+)\b")


def skname(u):
    r = R.byuid.get(int(u))
    return f"{u} {r.get('name_en') or r.get('class') or ''}".strip() if r else str(u)


def wname(n):
    n = str(n)
    if n.lstrip("-").isdigit(): n = ITEMTYPE.get(int(n), n)
    return WEAP.get(n, n)


def wre(n):
    return r"(?<![\w.])" + re.escape(n) + r"(?![\w\[])"


# ---------- text preparation for evaluation
def prep(t):
    t = R.sanitize(t)
    t = re.sub(r"System\.Math\.(Max|Min|Abs)\(", lambda m: m.group(1).lower() + "(", t)
    t = re.sub(r"\[\?blr\+(0x[0-9a-f]+)\]", lambda m: PRIMARY.get(m.group(1), m.group(0)), t)
    t = re.sub(r"primaryStat@(0x[0-9a-f]+)", lambda m: PRIMARY.get(m.group(1), m.group(0)), t)
    t = re.sub(r"base([A-Z]{3})~", r"pt_\1", t)
    t = re.sub(r"IPlayerStatusCalculator\.get_(\w+)\([^()]*\)", r"status.\1", t)
    t = re.sub(r"status\.(\w+)", r"st_\1", t)
    t = re.sub(r"SkillManager\.GetSkillLv\((?:[^()]|\([^()]*\))*?(\d+), 1(?:, 0)?\)", r"sk_\1", t)
    t = re.sub(r"SkillLv\((\d+)\)", r"sk_\1", t)
    t = _collapse(t, "NinjaSkillBase.GetNinjutsuTraining(", "(sk_1227 + sk_1228)")   # Code: GetSkillLv(1227) + GetSkillLv(1228) @0x2356734
    t = _collapse(t, "NinjaSkillBase.GetNinko(", "fn_sub")                            # Code: subWeapon is NinjutsuBook ? subWeapon.Function : 0 @0x23566c4
    t = re.sub(r"\[(?:EquipItemData\.get_SubWeapon\(0\)|GetSubWeaponType\.out1\(\))\+0x42\]", "fn_sub", t)
    t = t.replace("[weaponItem+0x42]", "fn_main")
    t = _collapse(t, "ItemData.get_Refine(", "rf_item")
    t = re.sub(r"(main|sub)Weapon==(\w+)", lambda m: f"ew_{ITEMTYPE_ID.get(m.group(2), m.group(2))}", t)   # refutil's form of ExistWeaponType
    t = re.sub(r"\(\(?PlayerAttackBase\.ExistWeaponType\((?:actarAction|player), (\d+)[^()]*\) & 1\)", r"(ew_\1", t)
    t = re.sub(r"PlayerAttackBase\.ExistWeaponType\((?:actarAction|player), (\d+)[^()]*\)", r"ew_\1", t)
    t = t.replace("frintp(", "_ceil(")
    t = re.sub(r"(?<![\w.])(\w+)\[(\d+)\]", r"\1__\2", t)   # array element field `skillRate[1]`
    return t.replace(MISNAMED, "STACKV")


FUNCS = {"mul64": X.mul64, "_ceil": math.ceil}


def env_for(rec, lv, pick=None, extra=None):
    env = {"Lv": lv, "lv": lv, **FUNCS, **(extra or {})}
    for name, its in R.set_variants(rec).items():
        if name in HIT_VARS: continue   # per-hit state, never a fixed value
        cand = R._base_variants(name, its)
        it = (pick or {}).get(name) or next((i for i in cand if i["when"] == "always"), cand[0])
        v = R.evaluate(prep(it["text"]), **env)
        if v is not None and name not in (extra or {}): env[re.sub(r"\[(\d+)\]", r"__\1", name)] = v
    return env


def sample_vars(rec, text):
    found = set(SAMPLE_RX.findall(prep(text)))
    pool = R.set_variants(rec)
    for n, its in pool.items():
        if re.search(wre(n), text):
            for i in its: found |= set(SAMPLE_RX.findall(prep(i["text"])))
    return sorted(found)[:2]


def sample_label(k, v):
    if k.startswith("pt_"): return f"{k[3:]}(แต้มที่ลง)={v}"
    if k.startswith("st_"): return f"{STATS[k[3:]]} รวม={v}"
    if k.startswith("rf_"): return f"ค่าตีบวก (Refine)={v}"
    if k.startswith("ew_"): return ("ใส่" if v else "ไม่ใส่") + " " + wname(int(k[3:]))
    if k.startswith("fn_"): return f"ค่าฐานอาวุธ{'รอง' if k == 'fn_sub' else 'หลัก'} (`ItemData.Function`)={v}"
    return f"Lv สกิล {skname(k[3:])}={v}"


# ---------- conditions -> Thai
def _norm_atom(a):
    a = a.strip()
    a = re.sub(r"^\((main|sub)Weapon==(\w+) & 1\) (ne|eq) 0$", lambda m: f"{m.group(1)}Weapon {'==' if m.group(3) == 'ne' else '!='} {m.group(2)}", a)
    a = re.sub(r"^(main|sub)Weapon==(\w+)$", r"\1Weapon == \2", a)
    a = re.sub(r"^!(main|sub)Weapon==(\w+)$", r"\1Weapon != \2", a)
    a = re.sub(r"^WeaponType (eq|ne) (\d+)$", lambda m: f"mainWeapon {'==' if m.group(1) == 'eq' else '!='} {ITEMTYPE.get(int(m.group(2)), m.group(2))}", a)
    return a


def _atom_th(a):
    m = re.fullmatch(r"(main|sub)Weapon(?:Type)? ?(==|!=) ?(\w+)", a)
    if m: return ("W", m.group(1), m.group(2), wname(m.group(3)))
    m = re.fullmatch(r"\(\(1 << (main|sub)WeaponType\) & (0x[0-9a-f]+)\) (ne|eq) 0", a)
    if m:
        bits = int(m.group(2), 16)
        names = "/".join(wname(i) for i in range(32) if bits >> i & 1)
        return f"อาวุธ{'หลัก' if m.group(1) == 'main' else 'รอง'}{'เป็น' if m.group(3) == 'ne' else 'ไม่ใช่'} {names}"
    m = re.fullmatch(r"(!?)has(Buff|GemCart)\((\w+)\)", a)
    if m:
        nm = m.group(3)
        if m.group(2) == "Buff" and nm.isdigit() and int(nm) in R.byuid: nm = skname(nm)   # unnamed SkillBufferId = skill uid
        return ("ไม่มี" if m.group(1) else "มี") + ("บัพ " if m.group(2) == "Buff" else "เจมคาร์ท ") + nm
    m = re.fullmatch(r"(.+?) (eq|ne|lt|gt|le|ge|lo|hs|hi|ls) (-?\w+)", a)
    if m:
        v, op, n = m.groups()
        if v == "MobaMode": return None if op == "eq" else "โหมด MOBA"
        if re.search(r"(main|sub)WeaponType$", v): return None
        if re.search(r"TryGet\w*(<[^>]*>)?\.out\d\(\)$", v) and n == "0":
            return "มีบัพ/ค่าที่โค้ดค้นหาอยู่" if op == "ne" else "ไม่มีบัพ/ค่าที่โค้ดค้นหา"
        v2 = re.sub(r"SkillManager\.GetSkillLv\((?:[^()]|\([^()]*\))*?(\d+), 1(?:, 0)?\)", lambda mm: "Lv สกิล " + skname(mm.group(1)), v)
        if n == "0" and op in ("eq", "ne") and re.fullmatch(r"(is|check|has|use)\w*|first|change|lineAttack|singleAttack|powerWaveEnable", v):
            return f"`{v}`" if op == "ne" else f"ไม่ `{v}`"
        sym = {"eq": "=", "ne": "≠", "lt": "<", "gt": ">", "le": "≤", "ge": "≥", "lo": "<", "hs": "≥", "hi": ">", "ls": "≤"}[op]
        return f"`{v2} {sym} {n}`"
    return f"`{a}`"


def _hit_atom(a, guards=False):
    m = re.fullmatch(r"(\w+) (eq|ne|lt|gt|le|ge) (-?\w+)", a.strip())
    if m and m.group(1) in HIT_VARS: return m
    if guards:   # `1 lt damageCount`: loop guard written the other way round
        r = re.fullmatch(r"-?\d+ (?:lt|gt|le|ge) (\w+)", a.strip())
        return r if r and r.group(1) in HIT_VARS else None
    return None


def _conj_th(atoms):
    weq, wne, out = {}, {}, []
    for a in atoms:
        t = _atom_th(a)
        if t is None: continue
        if isinstance(t, tuple):
            (weq if t[2] == "==" else wne).setdefault(t[1], [])
            if t[3] not in (weq if t[2] == "==" else wne)[t[1]]: (weq if t[2] == "==" else wne)[t[1]].append(t[3])
        elif t not in out: out.append(t)
    ws = []
    for side in ("main", "sub"):
        who = "อาวุธหลัก" if side == "main" else "อาวุธรอง"
        if weq.get(side): ws.append(f"{who} {'/'.join(weq[side])}")
        elif wne.get(side): ws.append(f"{who}อื่น (ไม่ใช่ {'/'.join(wne[side])})")
    return frozenset(ws + out), ws + out


def cond_th(whens, drop_hit=True):
    """raw `when` strings (ANDed together) -> Thai; hit variables are dropped (they name the hit instead)"""
    conjs = [[]]
    for w in whens:
        if not w or w in ("always", "base"): continue
        ds = pretty(w).split(" OR ")
        conjs = [c + [d] for c in conjs for d in ds][:16]
    cands = []
    for c in conjs:
        atoms = [_norm_atom(a) for a in " AND ".join(c).split(" AND ") if a.strip()]
        atoms = [a for a in atoms if not JUNK.search(a) and not (drop_hit and _hit_atom(a, True))]
        key, parts = _conj_th(atoms)
        if key not in [k for k, _ in cands]: cands.append((key, parts))
    if any(not k for k, _ in cands): return ""
    cands = [(k, p) for k, p in cands if not any(k2 < k for k2, _ in cands)]   # absorption: A or (A and B) = A
    if len(cands) > 1 and any("โหมด MOBA" not in k for k, _ in cands): cands = [(k, p) for k, p in cands if "โหมด MOBA" not in k]
    texts = [" และ ".join(p[:4]) + (" และ …" if len(p) > 4 else "") for _, p in cands]
    if len(texts) > 4: texts = texts[:4] + ["…(เงื่อนไขเต็มดูใน details)"]
    return " หรือ ".join(texts)


def hit_keys(when):
    if when == "always": return {()}
    keys = set()
    for d in pretty(when).split(" OR "):
        at = [m for m in (_hit_atom(a) for a in d.split(" AND ")) if m]
        eqs = {m.group(1) for m in at if m.group(2) == "eq"}
        pos = tuple(sorted({f"{m.group(1)} = {m.group(3)}" for m in at if m.group(2) == "eq"} |
                           {f"{m.group(1)} {'≠' if m.group(2) == 'ne' else m.group(2)} {m.group(3)}" for m in at if m.group(2) != "eq" and m.group(1) not in eqs}))
        keys.add(pos)
    return keys


# ---------- formula display
def _collapse(s, prefix, label):
    start = 0
    while True:
        i = s.find(prefix, start)
        if i < 0: return s
        j = s.find("(", i)   # the call's own opening paren (prefix may contain nested ones)
        if j < 0: return s
        d, k = 0, j
        while k < len(s):
            d += s[k] == "("
            d -= s[k] == ")"
            if d == 0: break
            k += 1
        s = s[:i] + label + s[k + 1:]
        start = i + len(label)


def thai(s):
    s = s.replace(MISNAMED, "ระดับชาร์จ/stack")
    s = _collapse(s, "System.Linq.Enumerable.Count<", "จำนวนเป้าในลิสต์ที่ตรงเงื่อนไข")
    s = _collapse(s, f"vtab({il2.stub('object_new'):#x}(", "player")
    s = _collapse(s, "MobActionManagerBase.get_MobBattleStatus(", "เป้า")
    s = re.sub(r"base([A-Z]{3})~", r"\1(แต้มที่ลง)", s)
    s = re.sub(r"primaryStat@(0x[0-9a-f]+)", lambda m: PRIMARY.get(m.group(1), m.group(0)).replace("base", "").replace("~", "(แต้มที่ลง)"), s)
    s = re.sub(r"status\.(\w+)", lambda m: STATS.get(m.group(1), m.group(1)) + "รวม", s)
    s = re.sub(r"IMobStatusCalculator\.get_ExpDef(Skill|Magic|Normal)\(เป้า\)", r"proration_\1ของเป้า", s)
    s = re.sub(r"IMobStatusCalculator\.(?:Calc|get_)(Mdef|Def)\(เป้า\)", lambda m: m.group(1).upper() + "ของเป้า", s)
    s = re.sub(r"PlayerStatusBase\.GetBonusValueWithBuf\((\d+)\)", lambda m: "โบนัส " + BONUS.get(int(m.group(1)), m.group(1)), s)
    s = re.sub(r"MathUtil\.DistanceToDisplayMeter\(0, \?\w+\)", "ระยะเป็นเมตร", s)
    s = s.replace("TryGetValue.out2()", "ค่าจากตาราง/บัพที่โค้ดค้นหา")
    s = re.sub(r"SkillManager\.GetSkillLv\((\d+), 1\)", lambda m: f"Lv[{skname(m.group(1))}]", s)
    s = re.sub(r"SkillManager\.GetSkillTreeLv\((\d+)\)", r"Lvทรี[\1]", s)
    s = re.sub(r"\bSkillLv\((\d+)\)", lambda m: f"Lv[{skname(m.group(1))}]", s)
    return s


def _fx(text):
    t = pretty(R._lv(text))
    # generic-typed calls do not parse: name them before folding
    t = _collapse(t, "System.Linq.Enumerable.Count<", "_TARGET_COUNT_")
    t = _collapse(t, f"vtab({il2.stub('object_new'):#x}(", "player")
    t = _collapse(t, "MobActionManagerBase.get_MobBattleStatus(", "_TGT_")
    f, names = X.simplify(t)
    back = lambda s: thai(s.replace("_TARGET_COUNT_", "จำนวนเป้าในลิสต์ที่ตรงเงื่อนไข").replace("_TGT_", "เป้า"))
    return back(f), [(a, back(b)) for a, b in names]


def show(expr, rec, depth=2):
    """markdown fragment: simplified formula, named repeated sub-terms, and the definitions of the fields it reads"""
    f, names = _fx(expr)
    out = f"`{f}`" + "".join(f" · `{a} = {b}`" for a, b in names)
    pool, defs, seen, todo = R.set_variants(rec), [], set(), [expr]
    for _ in range(depth):
        nxt = []
        for t in todo:
            for n in pool:
                if n in seen or n in HIT_VARS or not re.search(wre(n), t): continue
                seen.add(n)
                vs = list({i["text"]: i for i in pool[n]}.values())[:4]
                parts = []
                for i in vs:
                    vf, vn = _fx(i["text"])
                    if vf == n: continue
                    c = cond_th([i["when"]])
                    parts.append(f"`{vf}`" + "".join(f" (`{a} = {b}`)" for a, b in vn) + (f" [{c}]" if c else ""))
                    nxt.append(i["text"])
                if parts: defs.append(f"`{n}` = " + " หรือ ".join(parts))
        todo = nxt
    return out + (" — โดยที่ " + " ; ".join(defs) if defs else "")


def fit_linear(vals):
    if not vals or any(not isinstance(v, (int, float)) for v in vals): return None
    b = vals[1] - vals[0]
    a = vals[0] - b
    if any(abs(a + b * lv - v) > 1e-6 for lv, v in zip(LVS, vals)): return None
    a, b = round(a, 4), round(b, 4)
    if b == 0: return R.fmt(a)
    bb = "" if b == 1 else R.fmt(abs(b)) + "×"
    if not a: return ("−" if b < 0 else "") + f"{bb}Lv"
    return f"{R.fmt(a)} {'+' if b > 0 else '−'} {bb}Lv"


def fmt_cell(step, v):
    if v is None or v == "": return "–"
    if step in PCT_STEPS: return R.fmt(round(v * 100, 2)) + "%"
    return R.fmt(round(v, 4) if isinstance(v, float) else v)


def step_of(name):
    m = re.match(r"(\w+)\[(\w+)\]", name)
    return (m.group(1), m.group(2)) if m else ("", name)


# ---------- evaluation
def stack_info(rec, text):
    hv = next((n for n in HIT_INDEX if re.search(rf"\b{n}\b", text)), None)
    if hv:
        per_lv = None
        for n in ("maxAttackCount", "damageCount", "LoopParam", "hitCount"):
            for i in R.set_variants(rec).get(n, []):
                got = [R.evaluate(prep(i["text"]), **env_for(rec, lv)) for lv in LVS]
                if per_lv is None and None not in got and 0 < max(got) <= 20: per_lv = [int(x) for x in got]
        return hv, list(range(1, (max(per_lv) if per_lv else 5) + 1)), per_lv
    var = next((n for n in STACK_NAMES if re.search(rf"\b{n}\b", text)), None)
    if not var and MISNAMED in text: var = MISNAMED
    if not var: return None
    capx = r"(?:min|System\.Math\.Min)\((?:" + re.escape(var) + "|" + re.escape(MISNAMED) + r"), (\d+)\)"
    cap = re.search(capx, text) or next((m for i in R.set_variants(rec).get(var, []) for m in [re.search(capx, i["text"])] if m), None)
    if cap: return var, list(range(0, int(cap.group(1)) + 1)), None
    if var == "chargeValue": return var, [0, 25, 50, 75, 100], None
    per_lv = None
    for b in rec.get("buffs", {}).values():
        for ent in b["ctors"]:
            for k, vs in (ent.get("fields_resolved") or ent["fields"]).items():
                if re.fullmatch(r"(?i)max(ChargeLevel|Stack|Count)?", k) and vs and per_lv is None:
                    got = [R.evaluate(vs[0]["expr"], Lv=lv, lv=lv) for lv in LVS]
                    if None not in got and 0 < max(got) <= 20: per_lv = [int(x) for x in got]
    return var, list(range(1, (max(per_lv) if per_lv else 5) + 1)), per_lv


def variants(rec, it):
    """[(whens, text_with_field_variants_inlined, branch_note)] for one template item"""
    pool = R.set_variants(rec)
    used = [n for n in pool if re.search(wre(n), it["text"]) and n not in STACK_NAMES and len({i["text"] for i in pool[n]}) > 1]
    combos = [{}]
    for n in used[:3]:
        opts = list({i["text"]: i for i in pool[n]}.values())[:4]
        combos = [dict(c, **{n: (k, o)}) for c in combos for k, o in enumerate(opts, 1)][:8]
    out, seen = [], set()
    for c in combos:
        t = it["text"]
        for n, (k, o) in c.items():
            if not re.search(wre(n), o["text"]):
                t = re.sub(wre(n), lambda m, x=o["text"]: "(" + x + ")", t)
        if t in seen: continue
        seen.add(t)
        whens = [o["when"] for k, o in c.values()] + [it["when"]]
        note = ", ".join(f"กิ่งที่ {k} ของ `{n}`" for n, (k, o) in c.items() if o["when"] == "always" and len({i["text"] for i in pool[n]}) > 1)
        out.append((whens, t, note))
    return out


def _eval(rec, text, extra=None):
    vals = [R.evaluate(prep(text), **env_for(rec, lv, None, extra)) for lv in LVS]
    return None if None in vals else [round(v, 4) if isinstance(v, float) else v for v in vals]


def sampled(rec, text):
    """[(sample_label, values)] ; stat / other-skill terms get sample values, insensitive sample vars are dropped"""
    v = _eval(rec, text)
    if v is not None: return [("", v)]
    found = set(SAMPLE_RX.findall(prep(text)))
    for n, its in R.set_variants(rec).items():
        if re.search(wre(n), text):
            cand = R._base_variants(n, its)
            found |= set(SAMPLE_RX.findall(prep(next((i for i in cand if i["when"] == "always"), cand[0])["text"])))
    svars = sorted(found)[:3]
    if not svars: return []
    res = []
    for combo in itertools.product(*[SAMPLES.get(s[:3], STAT_SAMPLES) for s in svars]):
        extra = dict(zip(svars, combo))
        vals = _eval(rec, text, extra)
        if vals is None: return []
        res.append((extra, vals))
    live = [s for s in svars if any(v1 != v2 for e1, v1 in res for e2, v2 in res
                                    if e1[s] != e2[s] and all(e1[o] == e2[o] for o in svars if o != s))]
    out = collections.OrderedDict()
    for e, v in res:
        lab = ", ".join(sample_label(k, e[k]) for k in live)
        out.setdefault(lab, v)
    return list(out.items())


# ---------- rendering
_GV = {}
_ALIAS_TOK = re.compile(r"\b(?:status|target)\.\w+|\bbase(?:STR|INT|VIT|AGI|DEX|CRT|LUK|MEN|TEC)\b")
_CALL_TOK = re.compile(r"(?<![\w.])([A-Za-z_][\w`<>]*(?:\.[A-Za-z_][\w`<>]*)*)\.([A-Za-z_]\w*)\(")
_ENUM_TOK = re.compile(r"\b(BonusType|SkillBufferId|SkillId|AbnormalType|ElementType|MasteryId|GemCartBufferId)\.(\w+)")


def var_legend(text):
    """names + Thai meaning of the runtime variables a formula reads (from skills/damage/variables.json)"""
    if not _GV:
        import json
        p = os.path.join(R.OUT, "variables.json")
        _GV["d"] = json.load(open(p, encoding="utf-8")) if os.path.exists(p) else {}
    d = _GV["d"]
    V, AL = d.get("vars", {}), (d.get("meta") or {}).get("aliases", {})
    if not V: return ""
    from spec_tidy import tidy
    t = tidy(str(text))
    ids = []
    for m in _ALIAS_TOK.finditer(pretty(t)):
        vid = AL.get(m.group(0)) or AL.get(m.group(0).split(".")[0])
        if vid and vid in V and vid not in ids: ids.append((m.group(0), vid))
    for m in re.finditer(r"\.(localExpDef(?:Normal|Skill|Magic))\b", t):
        ids.append((m.group(1), f"MobStatus.{m.group(1)}"))
    for m in _CALL_TOK.finditer(t):
        vid = f"{m.group(1)}.{m.group(2)}"
        if vid in V and V[vid].get("kind") in ("player_stat", "mob_stat", "engine_fn", "helper_fn", "out_param") and vid not in [i[1] for i in ids]: ids.append((vid, vid))
    for m in _ENUM_TOK.finditer(t):
        vid = f"{m.group(1)}.{m.group(2)}"
        if vid in V and vid not in [i[1] for i in ids]: ids.append((vid, vid))
    out = []
    for shown, vid in ids[:6]:
        g = (V[vid].get("gloss_th") or "")[:70]
        out.append(f"`{shown}` = {g}")
    return (" — ตัวแปร: " + "; ".join(out) + (f" …(+{len(ids) - 6})" if len(ids) > 6 else "") + " (ดูแท็บ Variables)") if out else ""


def value_line(label, step, cond, vals):
    lin = fit_linear([round(v * 100, 4) for v in vals] if step in PCT_STEPS else list(vals))
    if lin and step in PCT_STEPS: lin = f"({lin})%" if "Lv" in lin else lin + "%"
    return f"- {label}" + (f" [{cond}]" if cond else "") + ": " + (f"**{lin}** → " if lin else "") + ", ".join(fmt_cell(step, v) for v in vals) + " (Lv1…10)"


def _join(*xs): return " · ".join(x for x in xs if x)


def _or(cs):
    """A or (A · B) = A"""
    if "" in cs: return ""
    return " หรือ ".join(c for c in cs if not any(o != c and o in c for o in cs))


def stack_table(rec, label, text, st, cond):
    var, ks, per_lv = st
    step = label[1]
    vn = "ระดับชาร์จ/stack" if var == MISNAMED else (f"ฮิตที่ ({var})" if var in HIT_INDEX else var)
    tables = collections.OrderedDict()
    for k in ks:
        t = text.replace(MISNAMED, str(k))
        if var != MISNAMED: t = re.sub(wre(var), str(k), t)
        for sl, vals in sampled(rec, t):
            if per_lv: vals = [v if k <= per_lv[i] else None for i, v in enumerate(vals)]
            tables.setdefault(sl, []).append((k, vals))
    L = [f"- {label[0]}" + (f" [{cond}]" if cond else "") + f": ขึ้นกับ `{vn}` — สูตร {show(text, rec)}"]
    if not tables:
        return L + ["  - (ส่วนที่เหลือขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้ ใช้สูตรด้านบน)"]
    for sl, rows in tables.items():
        L += ["", f"  *{sl}*" if sl else "", "", "  | " + vn + " | " + " | ".join(f"Lv{i}" for i in LVS) + " |", "  |---|" + "---|" * len(LVS)]
        L += [f"  | {k} | " + " | ".join(fmt_cell(step, v) for v in vals) + " |" for k, vals in rows]
    if per_lv: L += ["", "  ระดับสูงสุดต่อเลเวลสกิล: " + ", ".join(f"Lv{i}={v}" for i, v in zip(LVS, per_lv)) + " (`–` = เลเวลนั้นชาร์จไม่ถึง)"]
    return L + [""]


def step_lines(rec, its):
    L, zero_only = [], True
    by_step = collections.OrderedDict()
    for it in its: by_step.setdefault(it["name"], []).append(it)
    for name in sorted(by_step, key=lambda n: STEP_ORDER.get(step_of(n)[1], 99)):
        op, step = step_of(name)
        label = f"{STEP_TH.get(step, step)} (`{step}`, {OP_TH.get(op, op)})"
        seen, merged, stacks = set(), collections.OrderedDict(), collections.OrderedDict()
        for it in by_step[name]:
            if it["text"] in seen: continue
            seen.add(it["text"])
            for whens, text, note in variants(rec, it):
                cond = _join(cond_th(whens), note)
                st = stack_info(rec, text)
                if st:
                    zero_only = False
                    cs = stacks.setdefault(re.sub(r"[()\s]", "", show(text, rec)), (text, st, []))[2]
                    if cond not in cs: cs.append(cond)
                    continue
                res = sampled(rec, text)
                if not res:
                    zero_only = False
                    L.append(f"- {label}" + (f" [{cond}]" if cond else "") + f": {show(text, rec)} (ขึ้นกับค่าในสถานการณ์จริง ทำตารางไม่ได้){var_legend(text)}")
                    continue
                for sl, vals in res:
                    if any(vals): zero_only = False
                    c = _join(cond, sl)
                    merged.setdefault(tuple(vals), ([], text))
                    if c not in merged[tuple(vals)][0]: merged[tuple(vals)][0].append(c)
        for vals, (cs, text) in merged.items():
            L.append(value_line(label, step, _or(cs), vals))
            if not fit_linear(list(vals)) and len(set(vals)) > 1: L.append(f"  - สูตร: {show(text, rec)}")
        for text, st, cs in stacks.values():
            L += stack_table(rec, (label, step), text, st, _or(cs))
    return L, zero_only


def part_name(its):
    names = []
    for it in its:
        for m in re.finditer(r"\b([a-z][A-Za-z]*?)(SkillRate|FixAddDamage|ConstantDamage)\b", it["text"]):
            p = m.group(1)
            if p in ("skill", "fix", "base", "charge") or p in names: continue
            names.append(p)
    return ", ".join(f"{PART_TH.get(p, p)} (`{p}…`)" for p in names)


ARR_RX = re.compile(r"(?<![\w.])(\w+)\[(\d+)\]")


def array_extras(rec, its):
    """other per-hit array fields at the same index (e.g. physicsResist[1], passed to TemplateAssignment)"""
    idx = {m.group(2) for it in its for m in ARR_RX.finditer(it["text"])}
    used = {m.group(0) for it in its for m in ARR_RX.finditer(it["text"])}
    L = []
    for n, vs in R.set_variants(rec).items():
        m = ARR_RX.fullmatch(n)
        if not m or m.group(2) not in idx or n in used: continue
        res = sampled(rec, n)
        val = " · ".join((f"[{lab}] " if lab else "") + ", ".join(fmt_cell("", v) for v in vals) for lab, vals in res) + " (Lv1…10)" if res else show(n, rec)
        L.append(f"- ค่าอื่นของฮิตนี้ `{n}`: {val}")
    return L


def hit_groups(rec):
    groups, common = collections.OrderedDict(), collections.OrderedDict()
    for m, it0 in R.all_items(rec):
        if it0["kind"] != "tpl": continue
        for it in split_hit_ternary(it0):
            ai = ARR_RX.search(it["text"])
            ks = {(f"ช่อง [{ai.group(2)}] ของอาร์เรย์ต่อฮิต",)} if ai else hit_keys(it["when"])
            if () in ks and len(ks) > 1: ks.discard(())
            if len(ks) == 1: groups.setdefault(m, collections.OrderedDict()).setdefault(next(iter(ks)), []).append(it)
            else: common.setdefault(m, []).append(it)
    return groups, common


def split_hit_ternary(it):
    """`(isFirst eq 0 ? a : b)` inside a template -> one item per hit-variable value"""
    m = next((m for m in re.finditer(r"\b(\w+) (eq|ne) (-?\d+) \?", it["text"]) if m.group(1) in HIT_VARS), None)
    if not m: return [it]
    v, k = m.group(1), int(m.group(3))
    out = []
    order = ((k, "eq"), (1 if k == 0 else 0, "ne"))
    if re.search("first|frist", v, re.I) and k == 0: order = order[::-1]   # first-hit flag set -> listed as hit 1
    for val, op in order:
        atom = f"{v} {op} {k}"
        w = atom if it["when"] == "always" else " OR ".join(f"{d} AND {atom}" for d in it["when"].split(" OR "))
        t = re.sub(rf"\b{v}\b", str(val), it["text"])
        t = re.sub(r"\((-?\d+) (eq|ne) (-?\d+) \? (\w+) : (\w+)\)",
                   lambda mm: mm.group(4) if (mm.group(1) == mm.group(3)) == (mm.group(2) == "eq") else mm.group(5), t)
        out.append(dict(it, text=t, when=w))
    return out


def hit_title(m, key, n_in_method, its):
    d = METHOD_TH.get(m) or (("ส่วน " + (re.sub(r"^[cC]alc(Damage)?|Damage(Data)?$", "", m) or m)) if m.lower().startswith("calc") else "")
    t = f"`{m.replace('via ', '').split('$$')[-1]}`" + (f" ({d})" if d and not d.startswith("ฮิต ") else "")
    if key: t += " — " + ", ".join(f"`{k}`" for k in key)
    elif n_in_method > 1: t += " — กรณีที่เหลือ"
    pn = part_name(its)
    return t + (f" · ส่วน {pn}" if pn else "")


def buff_stack_lines(rec):
    L = []
    for bc, b in rec.get("buffs", {}).items():
        fields = {}
        for ent in b["ctors"]:
            for k, vs in (ent.get("fields_resolved") or ent["fields"]).items(): fields.setdefault(k, vs)
        mx = next((vs[0]["expr"] for k, vs in fields.items() if re.fullmatch(r"(?i)max(ChargeLevel|Stack|Count)?", k) and vs), None)
        seen = set()
        for g in b["get_param"]:
            e = g["value"]
            mv = re.search(r"\b(Count|chargeLevel|stack\w*|chargeValue)\b", e)
            if not mv or re.fullmatch(r"\(*\s*(int\()?" + mv.group(1) + r"\s*\)*", e) or (g["bonus"], e) in seen: continue
            seen.add((g["bonus"], e))
            var = mv.group(1)
            top = [R.evaluate(mx, Lv=lv, lv=lv) for lv in LVS] if mx else None
            top = [int(x) for x in top] if top and None not in top and 0 < max(top) <= 20 else None
            L += ["", f"- บัพ `{bc}` — `{g['bonus']}` ตามจำนวน `{var}`: {show(e, rec)}", "",
                  f"  | {var} | " + " | ".join(f"Lv{i}" for i in LVS) + " |", "  |---|" + "---|" * len(LVS)]
            for k in range(1, (max(top) if top else 5) + 1):
                vals = []
                for i, lv in enumerate(LVS):
                    v = R.evaluate(prep(re.sub(rf"\b{var}\b", str(k), e)), Lv=lv, lv=lv)
                    vals.append("–" if v is None or (top and k > top[i]) else R.fmt(round(v, 3)))
                L.append(f"  | {k} | " + " | ".join(vals) + " |")
    return L


def hitcount_lines(rec):
    L, seen = [], set()
    for m, it in R.all_items(rec):
        if it["kind"] != "set" or it["name"] not in ("LoopParam", "damageCount", "hitCount", "maxAttackCount", "attackNum", "arrowNum", "maxHitCount"): continue
        k = (it["name"], it["text"], it["when"])
        if k in seen: continue
        seen.add(k)
        vals = [R.evaluate(prep(it["text"]), **env_for(rec, lv)) for lv in LVS]
        c = cond_th([it["when"]], drop_hit=False)
        L.append(f"- `{it['name']}` (ตั้งใน `{m}`)" + (f" [{c}]" if c else "") + ": " +
                 (", ".join(R.fmt(v) for v in vals) + " (Lv1…10)" if None not in vals else f"{show(it['text'], rec)}"))
    return L


def block(rec):
    groups, common = hit_groups(rec)
    body, zeros, n = [], [], 0
    for m, g in groups.items():
        if () in g and len(g) > 1: common.setdefault(m, []).extend(g.pop(()))   # no hit variable: shared by every hit
    for m, g in groups.items():
        for key, its in g.items():
            lines, zero = step_lines(rec, its)
            if zero:
                zeros.append(hit_title(m, key, len(g), its))
                continue
            n += 1
            body += ["", f"**ฮิต {n}: {hit_title(m, key, len(g), its)}**"] + lines + array_extras(rec, its)
    if zeros: body += ["", "**กิ่งที่ค่าเป็น 0 ทุกขั้น** (กิ่ง default ในโค้ด ไม่ทำดาเมจ): " + " ; ".join(zeros)]
    for m, its in common.items():
        lines, _ = step_lines(rec, its)
        body += ["", f"**ใช้ร่วมทุกฮิตของ {METHOD_TH.get(m, m)}**"] + lines
    bs, hc = buff_stack_lines(rec), hitcount_lines(rec)
    if not (body or bs or hc): return None
    L = [f"<!-- calc:begin uid={rec['uid']} -->", f"#### การคำนวณแบบตัวเลข — {rec.get('name_en') or rec.get('class') or rec['uid']} (uid {rec['uid']})"]
    p = rec.get("proration") or {}
    if p.get("slot") and body: L.append(f"Proration: ช่อง `{p['slot']}` โหมด `{p['mode']}`")
    L += body
    if hc: L += ["", "**จำนวนฮิต / ตัวนับ**"] + hc
    if bs: L += ["", "**ค่าบัพที่ขึ้นกับจำนวน stack**"] + bs
    L.append("<!-- calc:end -->")
    return "\n".join(L)


PREFACE = """<!-- calc:preface -->
> **วิธีอ่านหัวข้อ "การคำนวณแบบตัวเลข"** (สร้างอัตโนมัติด้วย `scripts/render_calc_th.py` จาก `skill_reference.json` แก้มือจะถูกเขียนทับ)
> ดาเมจต่อฮิตเดินตามขั้น `SkillCalcTemplate/CalcStep` 0→40 ตามลำดับ (Code: `SkillCalcTemplate.GetDamage`) ขั้น `+` บวกเข้าดาเมจ ขั้น `×` คูณแล้วปัดเศษทิ้ง (int) ทันทีทุกขั้น
> ลำดับหลัก: ดาเมจฐาน(7) + คงที่สกิล(8) + คงที่บัพ(9) − ป้องกันเป้า(10) + ตีแรก(11) → ×คริ(13) → ×ธาตุ(15) → ×ตัวคูณสกิล(18) → ×ตีแรก(19) → ×เสถียร(21) → +คงที่ออโต้(22) → ×Proration(23) → ×ประเภท(24) → ×ดาเมจสุดท้าย(25) → … → เพดาน/ขั้นต่ำ(35–37)
> "ฮิต N" = template ดาเมจแต่ละก้อน (ทอยคริแยกกัน) แยกตามเมธอดและตัวแปรฮิตในโค้ด (`type`, `isFirst`, `attackCount` …) ชื่อฮิต/ส่วนมาจากชื่อในโค้ด (Inferred) ตัวเลขคำนวณจากโค้ด (Code) โดยตั้งเจม/บัพเสริม = 0
> ค่าหลายก้อนในขั้นเดียวกันแบบ "บวกเข้าช่อง" จะบวกกันก่อนคูณ ส่วน "ตั้งค่าทับ" แทนที่ค่าเดิม ค่าที่ขึ้นกับสเตตัสแสดงเป็นตัวอย่างที่ 100 / 255 (และ Lv สกิลอื่น 1 / 10) ใช้สูตรที่แนบไว้คำนวณค่าอื่นเอง
<!-- calc:preface-end -->
"""


def main():
    uid_block = {r["uid"]: b for r in R.recs if (b := block(r))}
    placed, pages = set(), 0
    for fn in sorted(glob.glob(os.path.join(TH_DIR, "*.md"))):
        src = open(fn, encoding="utf-8").read()
        src = re.sub(r"\n*<!-- calc:begin uid=\d+ -->.*?<!-- calc:end -->", "", src, flags=re.S)
        src = re.sub(r"<!-- calc:preface -->.*?<!-- calc:preface-end -->\n", "", src, flags=re.S)
        lines = src.split("\n")
        heads = [i for i, l in enumerate(lines) if l.startswith("### ")]
        out = lines[:heads[0]] if heads else lines
        for hi, start in enumerate(heads):
            end = heads[hi + 1] if hi + 1 < len(heads) else len(lines)
            seg = lines[start:end]
            uids = [int(u) for u in re.findall(r"uid (\d+)", lines[start])]
            blocks = [uid_block[u] for u in uids if u in uid_block and u not in placed]
            if blocks:
                cut = len(seg)
                while cut > 1 and seg[cut - 1].strip() in ("", "---"): cut -= 1
                seg = seg[:cut] + [""] + "\n\n".join(blocks).split("\n") + seg[cut:]
                placed.update(u for u in uids if u in uid_block)
            out += seg
        text = "\n".join(out)
        if any(u in placed for u in (int(x) for x in re.findall(r"calc:begin uid=(\d+)", text))):
            i = text.find("\n---\n")
            text = text[:i + 5] + "\n" + PREFACE + text[i + 5:] if i >= 0 else PREFACE + text
            pages += 1
        text = re.sub(r"\n{3,}", "\n\n", text)
        open(fn, "w", encoding="utf-8").write(text)
    missing = sorted(set(uid_block) - placed)
    print(f"blocks {len(uid_block)} / recs {len(R.recs)}; placed {len(placed)} in {pages} pages; not placed {len(missing)}: {missing}")


def selftest():
    b = block(R.byuid[1155])
    assert "| 5 | 2350% |" in b and "2800% |" in b, "GoliathTakeShot charge 5"
    b = block(R.byuid[555])
    assert "**(300 + 45×Lv)%**" in b and "**(200 + 30×Lv)%**" in b and "**(100 + 15×Lv)%**" in b, "VerticalAir per-hit arrays"
    b = block(R.byuid[976])
    assert b.index("**300**") < b.index("**30×Lv**"), "DragonicCharge: first-target hit (300) before range hits (30xLv)"
    b = block(R.byuid[76])
    assert "| 5 | – | – | – | – | – | – | – | – | – | 4500% |" in b, "CrossFire bowgun charge 5 only at Lv10"
    assert "**(150 + 5×Lv)%**" in block(R.byuid[33]), "HardHit 2H multiplier"
    print("selftest ok")


if __name__ == "__main__":
    selftest() if "--selftest" in sys.argv else main()
