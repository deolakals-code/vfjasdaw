"""Thai skill pages: skills/damage/explained_th/<tree>.md, generated from skill_reference.json only (no hand-written text).

One section per skill (same split as details/): header facts, in-game description, what the code does (roles, MP, ailments,
buffs, passive bonuses, who else reads the skill), in-game level notes. render_calc_th.py then appends the numeric blocks.
Run after render_details.py; then run render_calc_th.py.
"""
import collections, csv, glob, json, os, re
import render_calc_th as C
import render_details as D

R, D_OUT = C.R, os.path.join(C.R.OUT, "explained_th")
DAMAGE_TYPE = {r["uid"]: r for r in json.load(open(os.path.join(R.OUT, "damage_type.json"), encoding="utf-8"))}  # build_damage_type.py
COV = {int(r["uid"]): r for r in csv.DictReader(open(os.path.join(R.OUT, "coverage.csv"), encoding="utf-8-sig"))}

ROLE_TH = {
    "attack (deals damage)": "โจมตี (สร้างดาเมจ)", "buff (self)": "บัพตัวเอง", "buff (party / others)": "บัพปาร์ตี้/ผู้อื่น",
    "applies status ailment": "ทำให้ติดสถานะผิดปกติ", "heal / recovery": "ฟื้นฟู", "placed object / trap / summon": "วางวัตถุ/กับดัก/อัญเชิญ",
    "circle / song area": "สร้างพื้นที่ (วง/เพลง)", "passive mastery": "พาสซีฟ", "boosts normal-attack damage": "เพิ่มดาเมจตีปกติ",
    "modifies normal-attack behaviour": "เปลี่ยนการทำงานของตีปกติ", "utility / system action": "แอ็กชันระบบ/อรรถประโยชน์",
    "no client action class (system / production / unreleased)": "ไม่มีคลาสแอ็กชันฝั่ง client",
    "changes attack pattern (motion / combo chain; heuristic)": "เปลี่ยนรูปแบบการโจมตี (อนุมานจาก hook ของบัพ)",
}
STATE_TH = {"complete": "แกะครบจากโค้ด", "consumer-only": "ไม่มีคลาสของตัวเอง ผลอยู่ในโค้ดที่อ่านสกิลนี้",
            "no-client-code": "ไม่มีโค้ดฝั่ง client", "partial": "แกะได้บางส่วน"}
PARAM_TH = {
    "AbnormalAvoid": "หลบสถานะผิดปกติ", "AbnormalRegist": "ต้านสถานะผิดปกติ", "Aspd": "ความเร็วโจมตี +", "AspdRate": "ความเร็วโจมตี %",
    "AtkUp": "ATK +", "AtkUpRate": "ATK %", "AttackMprecoveryUp": "MP ฟื้นต่อการโจมตี", "AttackMprecoveryUpRate": "MP ฟื้นต่อการโจมตี %",
    "AvoidStack": "จำนวนหลบสะสม", "AvoidUp": "หลบ +", "BaseDamageCut": "ลดดาเมจฐาน", "BaseEqAtk": "ATK อาวุธฐาน +", "BaseEqAtkUpRate": "ATK อาวุธฐาน %",
    "Count": "ตัวนับ/stack", "CrtDamageUp": "ดาเมจคริ +", "CrtDamageUpRate": "ดาเมจคริ %", "CrtDmg": "ดาเมจคริ", "CrtUp": "อัตราคริ +",
    "CrtUpRate": "อัตราคริ %", "CspdUp": "ความเร็วร่าย +", "CspdUpRate": "ความเร็วร่าย %", "Def": "DEF +", "DefRate": "DEF %", "EqAtk": "ATK อาวุธ +",
    "EqAtkUpRate": "ATK อาวุธ %", "FirstAidCost": "MP ของปฐมพยาบาล", "FirstAttackRate": "ตัวคูณตีแรก", "Flee": "หลบ +", "FleeRate": "หลบ %",
    "Guard": "อัตราการ์ด", "GuardRate": "อัตราการ์ด %", "HateRate": "ความเกลียดชัง %", "HitRate": "ความแม่น %", "HitUp": "ความแม่น +",
    "HpRecoveryRate": "HP ฟื้นธรรมชาติ %", "HpRecoveryUp": "HP ฟื้นธรรมชาติ +", "KnockbackDistReduceRate": "ลดระยะกระเด็น %",
    "LastDamageRateDecimal": "ตัวคูณดาเมจสุดท้าย (ทศนิยม)", "LastDmgDownRate": "ลดดาเมจสุดท้ายที่ทำ %", "LastDmgUpRate": "ดาเมจสุดท้ายที่ทำ %",
    "LimitRegistDamage": "ต้านเพดานดาเมจ", "LongRangeRate": "ดาเมจระยะไกล %", "MAtkUpRate": "MATK %", "MagicCrtDamage": "ดาเมจคริเวท",
    "MagicDmgCut": "ลดดาเมจเวทที่ได้รับ", "MagicResistBreaker": "เจาะเวท", "MagiclPursuitSkillRate": "ตัวคูณโจมตีไล่ตามเวท", "MatkUp": "MATK +",
    "MaxHpUp": "HP สูงสุด +", "MaxHpUpRate": "HP สูงสุด %", "MaxMpUp": "MP สูงสุด +", "Mdef": "MDEF +", "MdefRate": "MDEF %",
    "MobLastDamageRateBuf": "ตัวคูณดาเมจที่ได้รับจากมอน (หมวดบัพ)", "MobLastDamageRateSupport": "ตัวคูณดาเมจที่ได้รับจากมอน (หมวดซัพพอร์ต)",
    "MobLastDamageRateUnique": "ตัวคูณดาเมจที่ได้รับจากมอน (หมวดเฉพาะ)", "MotionSpeed": "ความเร็วท่าทาง +", "MotionSpeedRate": "ความเร็วท่าทาง %",
    "MoveSpeed": "ความเร็วเคลื่อนที่", "MpRecoveryRate": "MP ฟื้นธรรมชาติ %", "MpRecoveryUp": "MP ฟื้นธรรมชาติ +",
    "NormalAttackConstantDamage": "ดาเมจคงที่ตีปกติ", "NormalAttackRate": "ตัวคูณตีปกติ %", "Percent": "ค่าเปอร์เซ็นต์ทั่วไป",
    "PhysicalPursuitSkillRate": "ตัวคูณโจมตีไล่ตามกายภาพ", "PowerDmgCut": "ลดดาเมจกายภาพที่ได้รับ", "PowerResistBreaker": "เจาะกายภาพ",
    "RateDamageResist": "ตัวคูณดาเมจที่ได้รับ", "ReceiveDarkElementDmgRate": "ดาเมจธาตุมืดที่ได้รับ %", "ReceiveLightElementDmgRate": "ดาเมจธาตุแสงที่ได้รับ %",
    "ShortRangeRate": "ดาเมจระยะใกล้ %", "SkillConstantDamage": "ดาเมจคงที่สกิล", "Stable": "ความเสถียร", "TargetDefDown": "ลด DEF เป้า",
    "TargetMdefDown": "ลด MDEF เป้า", "Value": "ค่าทั่วไป (ความหมายขึ้นกับโค้ดที่อ่าน)", "Value2": "ค่าทั่วไปตัวที่ 2",
}
MASTERY_TH = {
    "Agi": "AGI", "Aspd": "ความเร็วโจมตี +", "AspdRate": "ความเร็วโจมตี %", "AtkRate": "ATK %", "Avoid": "หลบ", "Crt": "อัตราคริ", "CrtDmg": "ดาเมจคริ",
    "CrtRate": "อัตราคริ %", "Cspd": "ความเร็วร่าย +", "CspdRate": "ความเร็วร่าย %", "CutDmgRate": "ลดดาเมจที่ได้รับ %", "DamageTransferRate": "อัตราโอนดาเมจ",
    "Def": "DEF", "DefRate": "DEF %", "EqAtkRate": "ATK อาวุธ %", "FirstAttackRate": "ตัวคูณตีแรก", "Flee": "หลบ", "Guard": "อัตราการ์ด",
    "GuardPower": "พลังการ์ด", "Hit": "ความแม่น", "HitRate": "ความแม่น %", "LastDmgRate": "ดาเมจสุดท้าย %", "LimitLvDown": "ลดเพดานเลเวล",
    "LimitTimeUp": "เพิ่มเวลาจำกัด", "Matk": "MATK", "MatkRate": "MATK %", "MaxHp": "HP สูงสุด", "MaxHpRate": "HP สูงสุด %", "MaxMp": "MP สูงสุด",
    "Mdef": "MDEF", "MdefRate": "MDEF %", "MobAttackLastDamageRate": "ดาเมจสุดท้ายที่ได้รับจากมอน", "NormalResist": "ต้านธาตุปกติ",
    "Percent": "ค่าเปอร์เซ็นต์", "PowerResistBreaker": "เจาะกายภาพ", "SkillAttackRate": "ตัวคูณโจมตีสกิล", "SkillRate": "ตัวคูณสกิล",
    "Stable": "ความเสถียร", "Trigger": "โอกาสทำงาน %", "Value": "ค่าทั่วไป",
}
ABN_TH = {"Flinch": "ผงะ", "Tumble": "ล้มคว่ำ", "Stun": "สตัน", "KnockBack": "กระเด็น", "Poison": "พิษ", "Paralysis": "อัมพาต", "Blindness": "ตาบอด",
          "Ignition": "ไฟไหม้", "Freeze": "แช่แข็ง", "Breaking": "เกราะแตก", "Slow": "ช้า", "Stop": "หยุดนิ่ง", "Fear": "หวาดกลัว", "Dizzy": "มึนงง",
          "Weak": "อ่อนแอ", "Collapse": "ล่มสลาย", "Confusion": "สับสน", "Silent": "ใบ้", "Bleed": "เลือดไหล", "Sleep": "หลับ", "Flash": "ตาพร่า",
          "Curse": "คำสาป", "Charm": "มนตร์เสน่ห์", "Sick": "ป่วย", "MagicFlinch": "ผงะ (เวท)", "Dispel": "ลบบัพ"}
TREE_TH = {  # the client's tree text is Japanese for most trees; Thai names as used in the Thai client UI
    "BladeSkill": "สกิลดาบ", "ShootSkill": "สกิลยิง", "MagicSkill": "สกิลเวทมนตร์", "MarshallSkill": "สกิลมาร์เชียล", "GuardSkill": "สกิลการ์ด",
    "SurvivalSkill": "สกิลเอาตัวรอด", "SupportSkill": "สกิลสนับสนุน", "ShieldSkill": "สกิลโล่", "KnifeSkill": "สกิลมีดสั้น", "MerchantSkill": "สกิลพ่อค้า",
    "SmithSkill": "สกิลช่างตีเหล็ก", "AlchemySkill": "สกิลเล่นแร่แปรธาตุ", "LuckSkill": "สกิลฟาลังซ์", "TamerSkill": "สกิลเทมเมอร์", "BattleSkill": "สกิลต่อสู้",
    "KnightSkill": "สกิลอัศวิน", "HunterSkill": "สกิลฮันเตอร์", "GolemSkill": "สกิลโกเล็ม", "MononofuSkill": "สกิลโมโนโนฟุ", "DualSword": "สกิลดาบคู่",
    "PartisanSkill": "สกิลพาร์ทิซาน", "SpriteSkill": "สกิลสไปรท์", "Minstrel": "สกิลมินสเตรล", "DancerSkill": "สกิลแดนเซอร์", "PriestSkill": "สกิลนักบวช",
    "MagicBladeSkill": "สกิลเมจิกเบลด", "28": "ทรี 28 (สกิล NPC/ผู้ช่วย)", "PetSkill": "สกิลสัตว์เลี้ยง", "HalberdSkill": "สกิลหอกวายุ",
    "AssassinSkill": "สกิลนักฆ่า", "WizardSkill": "สกิลจอมเวทย์", "DarkPowerSkill": "สกิลพลังมืด", "BareHandSkill": "สกิลมือเปล่า",
    "NecromancerSkill": "สกิลเนโครแมนเซอร์", "CrusherSkill": "สกิลครัชเชอร์", "37": "ทรี 37 (ไม่มีชื่อ ยังไม่เปิดใช้)", "NinjaSkill": "สกิลนินจา",
    "EventSkill": "สกิลอีเวนต์", "AvatarSkill_1": "สกิลอีเวนต์/คอลแลบ", "DebugSkill": "สกิลดีบั๊ก",
}
SLOT_TH = {"Skill": "ช่องสกิลกายภาพ", "Magic": "ช่องเวท", "Normal": "ช่องตีปกติ", "dynamic": "ช่องที่เลือกตอนร่าย (กายภาพ/เวท)", "none": "ไม่มีช่อง"}
MODE_TH = {"first_hit_per_target": "เปลี่ยนค่าเฉพาะฮิตแรกต่อเป้าต่อการร่าย", "every_hit": "เปลี่ยนค่าทุกฮิต", "custom_check": "สกิลเช็กเองว่าจะเปลี่ยนค่าหรือไม่",
           "first_hit_and_flag": "ฮิตแรกและต้องมีธง", "never": "ไม่เปลี่ยนค่า proration"}


def abn_th(n):
    n = str(n).strip()
    if not n.lstrip("-").isdigit(): return f"`{n}`"
    en = C.R.ENUM.get("AbnormalType", {}).get(int(n)) or str(n)
    return f"{ABN_TH.get(en, en)} ({en})"


def values(rec, text):
    """'a, b, … (Lv1…10)' or a formula fragment"""
    res = C.sampled(rec, text)
    if res and all(res_[1] is not None for res_ in res):
        if len(res) == 1 and not res[0][0]:
            v = res[0][1]
            if len(set(v)) == 1: return R.fmt(v[0])
            lin = C.fit_linear(v)
            return (f"**{lin}** → " if lin else "") + ", ".join(R.fmt(x) for x in v) + " (Lv1…10)"
        return " · ".join(f"[{lab}] " + ", ".join(R.fmt(x) for x in v) for lab, v in res) + " (Lv1…10)"
    return C.show(text, rec)


def header(rec):
    uid = rec["uid"]
    name = re.sub(r"\[N2?\]|\[[A-Z]\]", " / ", rec.get("name_th") or rec.get("class") or str(uid)).strip(" /")
    en = rec.get("name_en") or rec.get("class") or ""
    L = [f"### {name}" + (f" ({en})" if en and en != name else "") + f" · uid {uid}", ""]
    if rec.get("icon"): L += [f'<img src="../../{rec["icon"]}" width="40" alt="icon">', ""]
    facts = []
    if rec.get("tree_type") is not None and rec.get("in_skill_tree"):
        facts.append(f"ทรี: {TREE_TH.get(str(rec['tree_type']), R.clean_tree(rec.get('tree')))} (ขั้น {rec.get('tree_lv')})")
    if rec.get("max_level"): facts.append(f"เลเวลสูงสุด: {rec['max_level']}")
    if rec.get("eq_limit"): facts.append("อาวุธ: " + ", ".join(C.WEAP.get(w, w) for w in rec["eq_limit"]))
    if rec.get("premise_uid"):
        p = R.byuid.get(rec["premise_uid"], {})
        facts.append(f"ต้องเรียนก่อน: {p.get('name_th') or rec['premise_uid']}")
    if rec.get("flags"): facts.append("ธง: " + ", ".join(rec["flags"]))
    if not rec.get("in_skill_tree"): facts.append("แอ็กชันภายใน (ไม่อยู่ในทรีสกิล)")
    if facts: L += ["- " + " · ".join(facts)]
    cov = COV.get(uid)
    cls = rec.get("class") or rec.get("mastery_class")
    if cls: L.append(f"- คลาสในโค้ด: `{cls}`" + (f" · สถานะการแกะ: {STATE_TH.get(cov['state'], cov['state'])}" if cov else ""))
    elif cov: L.append(f"- {STATE_TH.get(cov['state'], cov['state'])}" + (f" (`{cov['reason']}`)" if cov.get("reason") else ""))
    if rec.get("desc_th"): L += ["", "> " + rec["desc_th"].replace("\n", "\n> ")]
    return L


_VARS = {}


def glossary():
    if not _VARS:
        import json
        p = os.path.join(C.R.OUT, "variables.json")
        if os.path.exists(p): _VARS.update(json.load(open(p, encoding="utf-8")))
        sp = os.path.join(C.R.OUT, "skill_variables.json")
        _VARS["_skill"] = json.load(open(sp, encoding="utf-8")) if os.path.exists(sp) else {}
    return _VARS


def _short(t, n=170):
    t = re.sub(r"\s+", " ", str(t))
    return t if len(t) <= n else t[:n - 1] + "…"


def hook_lines(rec):
    """other code that reads this skill: what it does with it, taken from the decoded definition (variables.json)"""
    g = glossary()
    V, S = g.get("vars"), g.get("_skill", {})
    if not V: return []
    uid = str(rec["uid"])
    en = rec.get("name_en") or ""
    out = []
    for fn in (S.get(uid) or {}).get("hooks", []):
        e = V.get(fn)
        if not e: continue
        bits = []
        for im in e.get("impls", []):
            mine = [ev for ev in im.get("events", []) if f"SkillId.{en}" in " ".join(ev["when"]) + ev["value"] or f"SkillId.{en}" in ev["name"]]
            for ev in mine[:3]:
                w = f" เมื่อ {_short(' AND '.join(ev['when']), 120)}" if ev["when"] else ""
                bits.append(f"[{ev['kind']}] `{_short(ev['name'], 60)}` = `{_short(ev['value'], 90)}`{w}")
            if not bits and im.get("cases") and im.get("returns") not in (None, "void"):
                c = im["cases"][0]
                bits.append(f"คืนค่า `{_short(c['value'], 160)}`" + (f" ({len(im['cases'])} กรณี)" if len(im["cases"]) > 1 else ""))
        L1 = f"- ตัวอ่านสกิลนี้ `{fn}` — {_short(e.get('gloss_th') or '', 110)}" + (": " + "; ".join(bits[:3]) if bits else "")
        out.append(L1 + " (นิยามเต็มในแท็บ Variables)")
    return out


def stack_text(b, fields):
    """how a counter buff (CountBufferBase style) moves: start value + the update expressions found in its own methods"""
    ups = []
    for mname, its in b.get("other", {}).items():
        for it in its:
            if it.get("kind") == "set" and mname in ("Next", "NextSkip", "Prev", "PrevSkip"):
                ups.append(f"{mname}(): `{it['name']}` = `{it['text']}`")
    init = fields.get("Count")
    t = ""
    if init: t += f"; ค่าตั้งต้น `{init[0]['expr']}`"
    if ups: t += "; " + "; ".join(ups)
    ca = b.get("child_args") or {}
    for child, a in ca.items():
        if "max" in a: t += f"; สแตกสูงสุด (`Max`) = {a['max']} ตามที่ `{child}` ส่งให้ตัวสร้างของ `{b.get('base_name', 'บัพฐาน')}`"
    return t


def child_stack(rec, bc):
    """derived buff of a counter buff: describe it by the base buff's counter instead of calling it a marker"""
    b = rec.get("buffs", {}).get(bc) or {}
    for ent in b.get("ctors", []):
        base = ent.get("base_ctor")
        if base and base["class"] in rec.get("buffs", {}):
            bb = rec["buffs"][base["class"]]
            if any(g["bonus"] == "Count" for g in bb.get("get_param", [])):
                a = dict(zip(base.get("params", []), base.get("args", [])))
                mx = a.get("max")
                return f"บัพนับสแตก (สืบจาก `{base['class']}`): ตัวนับ `Count` เริ่ม 0 เพิ่มทีละ 1 ด้วย `Next()` และสูงสุด {mx if mx is not None else '`Max`'}; โค้ดอื่นอ่านจำนวนสแตกผ่านพารามิเตอร์ `Count` (ดูค่าที่ใช้จริงในสูตรของสกิลที่อ้างถึง)"
    return None


def how(rec):
    L = []
    roles = [ROLE_TH.get(r, r) for r in rec.get("roles") or []]
    if roles: L.append("- บทบาท: " + ", ".join(dict.fromkeys(roles)))
    seen = set()
    for m, it in D.items(rec, "set", lambda n: n in ("baseMp", "mp", "costMp", "cost")):
        if (it["text"], it["when"]) in seen: continue
        seen.add((it["text"], it["when"]))
        c = C.cond_th([it["when"]])
        L.append(f"- MP ที่ใช้" + (f" [{c}]" if c else "") + f": {values(rec, it['text'])}")
    nt = [int(it["text"]) for m, it in D.items(rec, "info") if it["name"] == "templates" and str(it["text"]).isdigit()]
    if any(it["kind"] == "tpl" for m, it in R.all_items(rec)):
        L.append("- ดาเมจ: สร้าง template ดาเมจ" + (f" {sum(nt)} ก้อน" if nt else "") + " (แต่ละก้อนทอยคริแยก) ตัวเลขทุกฮิตอยู่ในหัวข้อ \"การคำนวณแบบตัวเลข\" ด้านล่าง")
    p = rec.get("proration") or {}
    dt = DAMAGE_TYPE.get(rec["uid"]) or {}
    if dt.get("attack_type") not in (None, "", "-") and (dt["attack_type"] != "None" or "attack (deals damage)" in (rec.get("roles") or [])):
        L.append(f"- ประเภทดาเมจ: {dt['th']}" + (f" — เงื่อนไข: {dt['variants']}" if dt["variants"] else ""))
    if p.get("slot"):
        mode = p.get("mode", "")
        L.append(f"- Proration: {SLOT_TH.get(p['slot'], p['slot'])} · {MODE_TH.get(mode.split(' ')[0], mode)}")
    seen = set()
    for m, it in D.items(rec, "set", lambda n: C_AIL.search(n)):
        if (it["name"], it["text"], it["when"]) in seen: continue
        seen.add((it["name"], it["text"], it["when"]))
        c = C.cond_th([it["when"]])
        L.append(f"- โอกาสติดสถานะ `{it['name']}`" + (f" [{c}]" if c else "") + f": {values(rec, it['text'])} %")
    types = []
    for m, it in D.items(rec, "call", lambda n: n in ("PlayerAttackBase.checkAbnormalPercent", "SkillDamageData.SetAbnormalType")):
        t = it["text"]
        a = D.split_args(t[t.index("(") + 1:t.rindex(")")]) if "(" in t else []
        if a and abn_th(a[0]) not in types: types.append(abn_th(a[0]))
    if types: L.append("- สถานะที่ทำให้ติด: " + ", ".join(types))
    for bc, b in rec.get("buffs", {}).items():
        fields = {}
        for ent in b["ctors"]:
            for k, vs in (ent.get("fields_resolved") or ent["fields"]).items(): fields.setdefault(k, vs)
        dur = fields.get("LeftTime")
        s = f"- บัพ `{bc}`"
        if dur:
            s += " ระยะเวลา " + " / ".join(values_expr(v["expr"]) + " วินาที" + (f" [{C.cond_th([v['when']])}]" if v.get("when", "always") != "always" and C.cond_th([v['when']]) else "") for v in dur[:3])
        parts, gseen = [], set()
        muts = {it["name"] for lst in b.get("other", {}).values() for it in lst if it.get("kind") == "set"}
        for g in b["get_param"]:
            e = g["value"]
            if any(re.search(rf"\b{re.escape(m)}\b", e) for m in muts):    # value read from a field the buff updates at run time: not a constant
                parts.append(f"{PARAM_TH.get(g['bonus'], g['bonus'])} (`{g['bonus']}`) = `{e}` (ตัวนับที่เปลี่ยนตามเหตุการณ์)" + stack_text(b, fields))
                continue
            for fk, vs in fields.items():
                if vs and re.search(rf"\b{re.escape(fk)}\b", e): e = re.sub(rf"\b{re.escape(fk)}\b", "(" + vs[0]["expr"] + ")", e)
            if (g["bonus"], e) in gseen: continue
            gseen.add((g["bonus"], e))
            v = values_expr(e)
            if v in ("0",): continue
            parts.append(f"{PARAM_TH.get(g['bonus'], g['bonus'])} (`{g['bonus']}`) = {v}")
        if parts: s += ": " + " · ".join(parts)
        elif not dur:
            sc = child_stack(rec, bc)
            s += (": " + sc) if sc else ": บัพแบบมี/ไม่มี (marker) ไม่มีค่าตัวเลข โค้ดอื่นเช็กแค่ว่ามีบัพนี้อยู่"
        L.append(s)
    m = rec.get("mastery")
    if m and m.get("bonuses"):
        for k, v in m["bonuses"].items():
            bl = v.get("by_level")
            txt = (", ".join(R.fmt(x) for x in bl) + " (Lv1…10)") if isinstance(bl, list) and bl else f"`{C._fx(v['expr'])[0]}`"
            L.append(f"- พาสซีฟ {MASTERY_TH.get(k, k)} (`{k}`): {txt}")
    L += hook_lines(rec)
    return L


def values_expr(e):
    vals = [R.evaluate(C.prep(e), Lv=lv, lv=lv, **C.FUNCS) for lv in C.LVS]
    if None not in vals:
        vals = [round(x, 3) if isinstance(x, float) else x for x in vals]
        if len(set(vals)) == 1: return R.fmt(vals[0])
        lin = C.fit_linear(vals)
        return (f"{lin} → " if lin else "") + ", ".join(R.fmt(x) for x in vals) + " (Lv1…10)"
    return f"`{C._fx(e)[0]}`"


def notes(rec):
    if not rec.get("notes"): return []
    return ["", "**โน้ตในเกม (ข้อความจากเกม):**"] + [f"- Lv{n.get('level')}: {(n.get('text') or '').replace(chr(10), ' ')}" for n in rec["notes"]]


C_AIL = re.compile(r"(Percent|abnormalRate|Parcent)$")


def main():
    trees = collections.OrderedDict()
    for r in R.recs:
        key = str(r.get("tree_type") or ("(internal actions)" if not r.get("in_skill_tree") else "(no tree)"))
        trees.setdefault(key, []).append(r)
    os.makedirs(D_OUT, exist_ok=True)
    keep = set()
    for key, rs in trees.items():
        rs.sort(key=lambda r: (r.get("tree_lv") or 0, r["uid"]))
        fn = re.sub(r"[^\w.-]+", "_", key) + ".md"
        keep.add(fn)
        title = TREE_TH.get(key) or ("แอ็กชันภายใน" if key == "(internal actions)" else R.clean_tree(rs[0].get("tree")) or key)
        body = [f"# {title} (`{key}`) — คำอธิบายทีละสกิล (ภาษาไทย)", "",
                "สร้างอัตโนมัติด้วย `scripts/render_explained_th.py` จาก `skill_reference.json` (ข้อมูลโค้ด client ชุดล่าสุด) ไม่มีข้อความเขียนมือ "
                "แก้ไฟล์นี้ตรง ๆ จะถูกเขียนทับ ตัวเลขทั้งหมดคำนวณจากโค้ด (Code) ความหมายของชื่อ field/บทบาทแปลจากชื่อในโค้ด (Inferred) "
                "ยังไม่ได้เทียบกับตัวเลขในเกม ข้อมูลดิบทุกเส้นทางอยู่ใน `../details/" + fn + "`", "", "---", ""]
        for r in rs:
            body += header(r) + ["", "**ทำงานยังไง (จากโค้ด):**"] + (how(r) or ["- ไม่มีข้อมูลการทำงานในโค้ดฝั่ง client"]) + notes(r) + ["", ""]
        open(os.path.join(D_OUT, fn), "w", encoding="utf-8").write("\n".join(body))
    for f in glob.glob(os.path.join(D_OUT, "*.md")):
        if os.path.basename(f) not in keep: os.remove(f)
    print("explained_th:", sum(len(v) for v in trees.values()), "skills in", len(keep), "pages")


if __name__ == "__main__":
    main()
