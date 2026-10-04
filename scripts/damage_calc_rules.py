"""Machine form of the skill damage rows (missing-data/08): rewrite rules that turn the decoder's call text of a damage term into the canonical input names of build_buff_values.canon().

build_overview.machine_alt() calls rewrite() before canon(). Everything a caster can type in or the page can ask for becomes a plain identifier:
  SkillManager.GetSkillLv(.., SkillId.X|N, ..)            -> the form canon() turns into SkillLv_<uid>
  gemCart(ID[k])                                           -> Registlet_<ID>_<k>      (value k of the equipped registlet ID, kind registlet)
  <Buf>.GetParam(n)                                        -> Buff_<Buf>_<n>          (parameter of a running buff, kind state)
  IMobStatusCalculator.CalcX(mob), target.X, MobActionManagerBase.get_X(mob)
                                                           -> Target_<X>              (the monster side, kind target)
  lastUsedSkill.X, weaponItem.X                            -> LastUsedSkill_X, Weapon_X (state)
  any other `Class.Method(...)` engine helper (balanced call) -> Engine_<Class>_<Method> (kind state, text says which helper): the value depends on the fight, not on the character
What stays unsupported (the page cannot ask for it, canon() reports it): raw field offsets `[this+0x..]`, `?x` decoder residue, rounding calls the evaluator grammar lacks (frintp, floor, mul64).
Label: Code (decoded) - these are names for runtime inputs, not values.
"""
import re

SKILL_LV = re.compile(r"SkillManager\.GetSkillLv\((?:[^()]|\((?:[^()]|\([^()]*\))*\))*?,\s*(?:SkillId\.(\w+)|(\d+))\s*,\s*[^(),]*\)")
GEMCART = re.compile(r"gemCart\((\d+)\[(\d+)\]\)")
BUFF_PARAM = re.compile(r"(?<![\w.])([A-Za-z_]\w*)\.GetParam\((\d+)\)")
TARGET_CALC = re.compile(r"IMobStatusCalculator\.(\w+)\(MobActionManagerBase\.get_MobBattleStatus\(\w+\)\)")
TARGET_GET = re.compile(r"MobActionManagerBase\.get_(\w+)\(\w+\)")
TARGET_FIELD = re.compile(r"(?<![\w.])target\.(\w+)")
STATE_FIELD = re.compile(r"(?<![\w.])(lastUsedSkill|weaponItem)\.(\w+)")
ROUND = re.compile(r"(?<![\w.])(frintp|floor)\(")
GAME_STATUS = re.compile(r"PlayerStatusBase\.get_GameStatus\(\)\.(\w+)")
ABNORMAL = re.compile(r"System\.Collections\.Generic\.Dictionary<[^>]*>\.ContainsKey\(abnormalList, \(?AbnormalType\.(\w+)\)?\)")
BUFF_COUNT = re.compile(r"TryGetBuf<object>\.out\d?\(PlayerStatusBase\.get_SkillBufferManager\(\), (?:SkillId\.(\w+)|(\d+))\)\.Count")
BUFF_ACTIVE = re.compile(r"\(?SkillBufferManager\.(?:TryGetBuf|ContainsBuffer)\(PlayerStatusBase\.get_SkillBufferManager\(\), (?:SkillId\.(\w+)|(\d+))(?:, out)?\) & 1\)?|SkillBufferManager\.ContainsBuffer\(PlayerStatusBase\.get_SkillBufferManager\(\), (?:SkillId\.(\w+)|(\d+))\)")
STATUS_EXTRA = re.compile(r"(?<![\w.])status\.(Stable|SubEqAtk|SubAtk|EqAtk|CriticalDmg|Def|Mdef|Crt|CrtRate)\b")
EQUIP_FIELD = re.compile(r"\(\(System\.Collections\.Generic\.Dictionary<Int32Enum, object>\.TryGetValue\(equipItem, (\d), out\) & 1\) ne 0 \? equipItem\[\1\] : 0\)(\)*)\.Function")          # ((TryGetValue(equipItem, N, out) & 1) ne 0 ? equipItem[N] : 0)).Function = ATK of the weapon in slot N (1 main, 2 sub); `.Type` is turned into WeaponType / SubWeaponType by build_buff_values.norm first
CALL = re.compile(r"(?<![\w.])([A-Z]\w*(?:<[^<>()]*>)?(?:\.[A-Za-z_]\w*(?:<[^<>()]*>)?|\.out\d)+)\(")
KEEP = re.compile(r"^(System\.Math\.|BonusManager\.GetBonusValue|SkillMasteryBase\.GetMasteryParam|ItemData\.get_Refine|EquipItemData\.get_|SkillManager\.GetSkillLv|PlayerStatusBase\.get_)")
NOT_CALLS = {"System.Math.Max", "System.Math.Min", "System.Math.Abs"}


def balanced_end(text, open_idx):
    d = 0
    for i in range(open_idx, len(text)):
        d += text[i] == "("
        d -= text[i] == ")"
        if d == 0:
            return i
    return -1


def ROUND_FIX(text):
    """frintp(Y) = ceil(Y) = int(Y) + (Y gt int(Y)); floor(Y) = int(Y) - (Y lt int(Y)): the evaluator grammar has only int / min / max / abs (innermost call first, so nesting works)"""
    while True:
        ms = list(ROUND.finditer(text))
        if not ms:
            return text
        m = ms[-1]
        end = balanced_end(text, m.end() - 1)
        if end < 0:
            return text
        y = text[m.end():end]
        rep = f"(int({y}) + (({y}) gt int({y})))" if m.group(1) == "frintp" else f"(int({y}) - (({y}) lt int({y})))"
        text = text[:m.start()] + rep + text[end + 1:]


def rewrite(expr, skill_uid, consts=None):
    """-> (expression, {input name: {kind, th}}) ; skill_uid maps 'SkillId.Name' -> uid"""
    extra = {}

    def reg(name, kind, th):
        extra.setdefault(name, {"kind": kind, "th": th})
        return name

    def lv(m):
        u = skill_uid(m.group(1)) if m.group(1) else int(m.group(2))
        return f"SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), {u}, 1)" if u is not None else m.group(0)
    t = re.sub(r"\bBuffEffectActive\b", "1", expr)          # a buff row is only shown while its buff runs
    for k, v in (consts or {}).items():          # the skill's own static data (skillMaster.SkillTreeType ...)
        t = re.sub(rf"(?<![\w.]){re.escape(k)}\b", str(v), t)
    t = ROUND_FIX(t)
    t = EQUIP_FIELD.sub(lambda m: reg("Weapon_Function" if m.group(1) == "1" else "SubWeapon_Function", "state", "ATK ของอาวุธหลัก" if m.group(1) == "1" else "ATK ของอาวุธรอง") + m.group(2), t)
    t = SKILL_LV.sub(lv, t)
    t = GAME_STATUS.sub(lambda m: reg(f"Game_{m.group(1)}", "state", f"สถานะผู้เล่นระหว่างเล่น: {m.group(1)}"), t)
    t = ABNORMAL.sub(lambda m: reg(f"Target_Abnormal_{m.group(1)}", "flag", f"เป้าหมายติดสถานะ {m.group(1)}"), t)
    t = BUFF_COUNT.sub(lambda m: reg(f"BuffCount_{(skill_uid(m.group(1)) if m.group(1) else int(m.group(2)))}", "state", f"จำนวนสแตกของบัพ #{(skill_uid(m.group(1)) if m.group(1) else m.group(2))} (ค่าระหว่างเล่น)"), t)
    t = BUFF_ACTIVE.sub(lambda m: reg(f"BuffActive_{(skill_uid(m.group(1) or m.group(3)) if (m.group(1) or m.group(3)) else int(m.group(2) or m.group(4)))}", "flag", f"บัพ #{(skill_uid(m.group(1) or m.group(3)) if (m.group(1) or m.group(3)) else m.group(2) or m.group(4))} ทำงานอยู่"), t)
    t = STATUS_EXTRA.sub(lambda m: reg(f"Status_{m.group(1)}", "stat", f"{m.group(1)} รวม (จากหน้าสถานะ)"), t)
    t = GEMCART.sub(lambda m: reg(f"Registlet_{m.group(1)}_{m.group(2)}", "registlet", f"โบนัสรีจิสเลต #{m.group(1)} [{m.group(2)}]"), t)
    t = BUFF_PARAM.sub(lambda m: reg(f"Buff_{m.group(1)}_{m.group(2)}", "state", f"พารามิเตอร์บัพ {m.group(1)} #{m.group(2)} (ค่าระหว่างเล่น)"), t)
    t = TARGET_CALC.sub(lambda m: reg(f"Target_{m.group(1).removeprefix('Calc')}", "target", f"มอนสเตอร์: {m.group(1).removeprefix('Calc')}"), t)
    t = TARGET_GET.sub(lambda m: reg(f"Target_{m.group(1)}", "target", f"มอนสเตอร์: {m.group(1)}") if m.group(1) not in ("MobBattleStatus", "MobStatus", "BuffManager", "CharacterActionManagerBase", "transform") else m.group(0), t)
    t = TARGET_FIELD.sub(lambda m: reg(f"Target_{m.group(1)}", "target", f"มอนสเตอร์: {m.group(1)}"), t)
    t = STATE_FIELD.sub(lambda m: reg(f"{m.group(1)[0].upper() + m.group(1)[1:] if m.group(1) == 'lastUsedSkill' else 'Weapon'}_{m.group(2)}", "state", f"{m.group(1)}.{m.group(2)} (ค่าระหว่างเล่น)"), t)
    # remaining engine helpers: replace a whole balanced call by a named runtime input
    out, i = "", 0
    for m in CALL.finditer(t):
        if m.start() < i:
            continue
        name = m.group(1)
        if name in NOT_CALLS or KEEP.match(name):
            continue
        end = balanced_end(t, m.end() - 1)
        if end < 0:
            continue
        ident = "Engine_" + re.sub(r"\W+", "_", name).strip("_")
        out += t[i:m.start()] + reg(ident, "state", f"ค่าจากเอนจิน: {name} (ค่าระหว่างเล่น)")
        i = end + 1
    return out + t[i:], extra
