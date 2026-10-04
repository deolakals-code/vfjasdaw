"""Character status ("Status -> Details" screen) computed from the decoded client functions.

Inputs: level, the nine primary stats (allocated points), the main weapon's type and base values, and equipment / buff bonuses as numbers.
Every row of the Details screen (player_status/detail_panel.json, written by decode_status_panel.py) is evaluated with the export's own evaluator
(calc_engine.Evaluator) over the 1,164 decoded stat functions (skills/damage/stats/decoded). Whatever the character does not have - no skill
buffs, no masteries, no gear bonus - is absent, which the client code reads as 0 / false; bonuses the player enters replace that.

Run (cwd D:\\toram_re):  python "D:\\toram reverse data\\scripts\\player_status.py"            prints a sample character
                         python "D:\\toram reverse data\\scripts\\player_status.py" --coverage  which rows evaluate and which leaf blocks the rest
Labels: Code (decoded from libil2cpp.so); nothing here is checked against an in-game screen.
"""
import sys, os, re, json, glob, csv, collections

sys.path.insert(0, r"D:\toram_re")
import calc_engine as CE

BASE = r"D:\toram reverse data\skills\damage"
PANEL = r"D:\toram reverse data\player_status\detail_panel.json"


def load_functions():
    G = json.load(open(os.path.join(BASE, "variables.json"), encoding="utf-8"))
    V = dict(G["vars"])
    for f in glob.glob(os.path.join(BASE, "stats", "decoded", "*", "*.json")):
        j = json.load(open(f, encoding="utf-8"))
        name = j["name"].replace("$$", ".")
        V[name] = {"id": name, "kind": "stat_fn", "impls": [dict(j, **{"class": name.rsplit(".", 1)[0]})]}
    panel = json.load(open(PANEL, encoding="utf-8"))
    for nm, h in panel["helpers"].items():          # the screen's own Calc*Value helpers
        full = f"UIPlayerStatusDetailPanel.{nm}"
        cases = [{"value": c["ret"], "common": c["when"], "variants": []} for c in h["cases"] if c["ret"] is not None]          # a null ret is a path the decoder lost
        V[full] = {"id": full, "kind": "stat_fn", "impls": [{"name": full, "params": [], "static": False, "returns": "float", "cases": cases, "lets": {}}]}
    import armour_overrides          # hand-decoded Def / Mdef / Flee (the decoder lost their jump-table branches)
    V.update(armour_overrides.overrides())
    import bonus_overrides           # hand-decoded BonusManager.CulcConvertAtk / CulcConvertMAtk (STR..DEX -> ATK / MATK stat lines)
    V.update(bonus_overrides.overrides())
    import rate_patches              # equipment ATK% / MATK% / ASPD% / HIT% / CSPD% (the decoder lost the bonus part of the rate accumulators)
    rate_patches.apply(V)
    return {"vars": V}


G = load_functions()

# ItemDBData.ItemType -> weapon calculator class (createWeaponCalculator's jump table is not decoded; anything else is the bare-hand one)
CALC_OF_TYPE = {8: "Katana", 9: "Halberd", 10: "OneHundSword", 11: "TwoHundSword", 12: "Bow", 13: "Bowgun", 14: "Rod", 15: "Magictool",
                16: "Knuckle", 17: "Shield", 18: "ShortSword", 19: "Arrow", 23: "NinjutsuScroll"}
CONSTS = {}                 # `ArmorAbility.Light` -> 1 ... every enum constant of the client (metadata/constants.tsv), keyed by its last class segment
for ln in open(r"D:\toram reverse data\metadata\constants.tsv", encoding="utf-8").read().splitlines()[1:]:
    p = ln.split("\t")
    if len(p) == 4 and p[2] == "i32":
        CONSTS[f"{re.split(r'[/.]', p[0])[-1]}.{p[1]}"] = int(p[3])
GEMCART_BUFFER_NAME = {v: k.split(".", 1)[1] for k, v in CONSTS.items() if k.startswith("GemCartBufferId.")}          # GemCartBufferId value -> name
REGISTLET_VALUE = collections.defaultdict(dict)          # (GemCartBufferId name, registlet id) -> {level: value}: the `value` effects of registlet/effects_by_level.csv (what GemCartBufferBase.GetValue(id) returns)
for _r in csv.DictReader(open(r"D:\toram reverse data\registlet\effects_by_level.csv", encoding="utf-8-sig")):
    if _r["source"] == "value":
        REGISTLET_VALUE[(_r["key"], int(_r["id"]))][int(_r["level"])] = float(_r["value"])
BONUS_BY_ID = {v["value"]: k.split(".", 1)[1] for k, v in G["vars"].items() if v.get("kind") == "bonus_type" and isinstance(v.get("value"), int)}
for _k, _v in CONSTS.items():
    if _k.startswith("BonusType."):
        BONUS_BY_ID.setdefault(_v, _k.split(".", 1)[1])

# names a naked character does not have: the client code reads a missing dictionary entry / buff / mastery as "not there"
ABSENT = re.compile(r"TryGetValue|TryGetBuf|TryGetBuff|TryGetEquipBuffer|ContainsBuffer|ContainsKey|GetSkillBufferParam|GetMasteryParam|GetBuffValue|GetEnhanceParam|"
                    r"\.out2$|GetBonusValue$|GetBonusPercentValue$|GetCristaBonus|get_Item$|\.Contains$|Enumerator.*\.MoveNext|GameEventManager\.Get\w+Rate|PartyManager\.get_GroupAvatarMemberNum|"
                    r"Enumerable\.Contains|GemCartBag\.GetIDEquipGemCart|GemCartBufferBase\.OnGetValue|GemCartBufferBase\.GetValue|GemCartBufferManager\.GetGemCartBuffer")


def item(type_, function=0, stable=0, refine=0, ability=0):
    """an equipped ItemData as the client code reads it: Type, Function (weapon ATK / armour DEF), dbData.Stable, Refine"""
    return {"Type": type_, "Function": function, "Slot": 0, "Refine": refine, "ability": ability, "dbData": {"Stable": stable, "Range": 0}, "dbData.Stable": stable}          # the decoder writes `.dbData.Stable` after a call as one dotted field name


class Character:
    def __init__(self, lv=100, str_=0, int_=0, vit=0, agi=0, dex=0, crt=0, luk=0, men=0, tec=0, bonus=None,
                 weapon=None, sub=None, body=None, option=None, special=None, skills=None, weapon_element=0, sub_element=0, cast_active=0, equip_skills=None, equip_skill_flags=None, registlet=None, party_members=1, option_avoid=0):
        self.primary = {"lv": lv, "str": str_, "int": int_, "vit": vit, "agi": agi, "dex": dex, "crt": crt, "luk": luk, "men": men, "tec": tec}
        self.bonus = dict(bonus or {})          # BonusType name -> value typed in by the player
        # gear as typed in: item(type, atk_or_def, stable, refine); nothing equipped = type 0 (bare hands)
        self.weapon = weapon or item(0)
        self.sub = sub or item(0)
        self.body = body or item(20, ability=3)          # no armour: ability 3 in the client's switch
        self.option = option or item(21)
        self.special = special or item(22)
        self.skills = {int(k): int(v) for k, v in (skills or {}).items()}          # learned skill / mastery uid -> level (SkillMasteryList / SkillManager.GetSkillLv)
        self.weapon_element = weapon_element          # ElementType value of the main weapon's own bElement line (BonusManager.GetEquipElement(Weapon)); 8 = Mana
        self.sub_element = sub_element
        # skills granted by gear-side settings (SkillManager.equipSkillList: star gem / avatar / ninja skill, SkillData.Flag 1 / 2 / 3): uid -> level, optional uid -> flag
        self.equip_skills = {int(k): int(v) for k, v in (equip_skills or {}).items()}
        self.equip_skill_flags = {int(k): int(v) for k, v in (equip_skill_flags or {}).items()}
        # equipped registlets (GemCartBufferManager.gemCartBufList): id -> level; party_members = PartyManager.LoginFieldUserPartyMemberNum (self included)
        self.registlet = {int(k): int(v) for k, v in (registlet or {}).items() if int(v) > 0}
        self.party_members = int(party_members)
        # OptionsSystem.Avoid (AvoidType 0 Manual, 1 Auto, 2 NonActive): the player's own client setting (OptionManager.OptionsSystem +0x54; the ctor never writes it, so an untouched profile is 0)
        self.option_avoid = int(option_avoid)
        self.cast_active = cast_active          # CastMastery.SetActive flag (only read by the AtkRate term of Cast Mastery)

    def evaluator(self):
        bonus = self.bonus
        equip = equip_buffer_table(bonus)

        def name_of(t):
            return BONUS_BY_ID.get(t, str(t)) if isinstance(t, int) else str(t).split(".")[-1]

        def val(t):
            return bonus.get(name_of(t), 0)

        gear = {"mainWeaponCalculator": {"cls": CALC_OF_TYPE.get(self.weapon["Type"], "Hund"), "item": self.weapon},
                "subWeaponCalculator": {"cls": CALC_OF_TYPE.get(self.sub["Type"], "Hund"), "item": self.sub}}
        env = {
            "PlayerStatusBase.get_EquipItemData": lambda *a: gear,
            "EquipItemData.get_Weapon": lambda *a: self.weapon,
            "EquipItemData.get_SubWeapon": lambda *a: self.sub,
            "EquipItemData.get_Body": lambda *a: self.body,
            "EquipItemData.get_Option": lambda *a: self.option,
            "EquipItemData.get_Special": lambda *a: self.special,
            "EquipItemData.get_WeaponItemType": lambda *a: self.weapon["Type"],
            "EquipItemData.get_SubWeaponItemType": lambda *a: self.sub["Type"],
            "ItemData.get_Refine": lambda it, *a: it.get("Refine", 0) if isinstance(it, dict) else 0,
            "ItemData.get_BattleCustomize": lambda it, *a: (it.get("ability", 0) & 3) if isinstance(it, dict) else 3,
            "ItemDBData.CheckArmorAbility": lambda it, t, *a: int(isinstance(it, dict) and (it.get("ability", 0) & 3) == t),
            "PlayerStatusBase.get_PrimaryStatus": lambda *a: self.primary,
            "BonusManager.GetBonusValue": lambda m, t, *r: val(t),
            "BonusManager.GetBonusPercentValue": lambda m, t, *r: val(t) / 100,
            # equipment buffer lines (BonusType 135..165) live in BonusData.buffList; GetBuffValue sums them, GetBonusTime is the time-limited multiplier (1 = none)
            "BonusManager.GetBuffValue": lambda m, t, *r: val(t),
            "BonusManager.GetAvatarBonusValue": lambda m, t, *r: val(t),          # avatar lines are typed in under their own names (bAvatarRespawn ...)
            # system option "Avoid" (OptionsSystem.SystemOptionType 37): the player's own client setting, read as 0; it shifts AvoidStack left by one when 0
            "Singleton.get_Instance": lambda *a: {"OptionsSystem.Avoid": 0},
            # EquipBuffManager.IsGrantStopAbnormal(type): (type - 1) < 3 and IsVilidEquipBuff(type + 162), AbnormalType 1 Flinch 2 Tumble 3 Stun -> buffers 163 164 165
            # EquipBuffManager.GetParam(type): the buffer's own GetParam() (pursuits, HelpMaster, ItemDelay: Value; the breakers return the weapon slot type: modelled as 0), 0 without the buffer
            "EquipBuffManager.GetParam": lambda m, t, *r: equip.get(t, {}).get("GetParam", 0),
            "EquipBuffManager.IsGrantStopAbnormal": lambda m, t, *r: int(1 <= t <= 3 and (t + 162) in equip),
            "BonusManager.GetBonusTime": lambda *a: 1,
            # GetBonusConstant_Rate(constantType, rateType, out constant, out rate): the constants of one type are summed, the rates add up to a
            # multiplier that starts at 1 (CalcBaseSecondaryStatus is  rate * base + constant, so a character with no bonus must come out as base)
            "GetBonusConstant_Rate.constant": lambda m, c, r, *x: val(c),
            "GetBonusConstant_Rate.out4": lambda m, c, r, *x: 1 + val(r) / 100,
            "GetBonusConstant_AvatarConstan_Rate.constant": lambda m, c, a, *x: val(c) + val(a),
            # GetMaxBonusConstant_Rate (0x20bb164): constant = sum(type) + 10 * sum(typeTo10) + avatar term, rate = 1 + sum(rateType) / 100
            "GetMaxHpBonusConstant_Rate.maxHpConstant": lambda *x: val("bMaxHp") + 10 * val("bMaxHpTo10"),
            "GetMaxMpBonusConstant_Rate.maxMpConstant": lambda *x: val("bMaxMp") + 10 * val("bMaxMpTo10"),
            "GetMaxHpBonusConstant_Rate.out1": lambda *x: val("bMaxHp") + 10 * val("bMaxHpTo10"),
            "GetMaxHpBonusConstant_Rate.out2": lambda *x: 1 + val("bMaxHpRate") / 100,
            "GetMaxMpBonusConstant_Rate.out1": lambda *x: val("bMaxMp") + 10 * val("bMaxMpTo10"),
            "GetMaxMpBonusConstant_Rate.out2": lambda *x: 1 + val("bMaxMpRate") / 100,
        }
        skills, eq_skills, flags = self.skills, self.equip_skills, self.equip_skill_flags

        def skill_lv(uid, check=True):
            """SkillManager.GetSkillLv(id, checkEquipSkill) 0x2391784: -1 = not available. An equip skill with Flag 3 (NinjaSkill) is looked up as skill 1218 instead."""
            uid = int(uid)
            while True:
                eq = -1
                if uid in eq_skills:
                    if flags.get(uid, 0) == 3:
                        uid = 1218
                        continue
                    eq = eq_skills[uid]
                break
            if skills.get(uid, 0) > 0:
                return max(skills[uid], eq if check else -1)
            if check or 1281 <= uid <= 1343:
                return eq
            return -1

        def mastery_lv(uid):
            """level of SkillMasteryList[uid]: CreateMasteryList copies the learned masteries, then adds the equip-skill masteries the learned list does not have (no max)"""
            uid = int(uid)
            if skills.get(uid, 0) > 0:
                return skills[uid]
            return eq_skills.get(uid, 0) if str(uid) in MASTERY_TABLE else 0

        wiz = [max(0, skill_lv(u)) for u in sorted(WIZARD_TREE)]          # GetAllSkillLvInTree / GetSkillNumInTree: every skill of the tree, sum of max(0, lv) / count of lv > 0
        inputs = {"WizardTreeLevelSum": sum(wiz), "WizardTreeSkillCount": sum(1 for v in wiz if v > 0), "CastMasteryActive": self.cast_active}
        env.update({
            "SkillEqLimit": lambda u, *r: EQ_LIMIT.get(int(u), 0),
            # GemCartBufferManager: ContainsBuffer / GetBufferLevel read the equipped registlet; GetValue(buffer, Value) of 37 (Shared Destiny) is max(0, party members - 1)
            "GemCartBufferManager.ContainsBuffer": lambda m, i, *r: int(self.registlet.get(int(i), 0) > 0),
            "GemCartBufferManager.GetBufferLevel": lambda m, i, *r: self.registlet.get(int(i), 0),
            "GemCartBufferManager.GetGemCartBuffer": lambda m, i, *r: {"id": int(i), "level": self.registlet.get(int(i), 0)},
            "GemCartBufferBase.GetValue": lambda b, vid, *r: (max(0, self.party_members - 1) if b.get("id") == 37 and b.get("level", 0) > 0 else 0) if isinstance(b, dict) else 0,
            # GemCartBufferManager.GetBufferValue(id) 0x2177f04 = float SUM over the equipped registlets of GemCartBufferBase.GetValue(id) (fadd in the loop); value per level from registlet/effects_by_level.csv (source `value`)
            "GemCartBufferManager.GetBufferValue": lambda m, bid, *r: sum(REGISTLET_VALUE.get((GEMCART_BUFFER_NAME.get(int(bid), ""), rid), {}).get(lv, 0) for rid, lv in self.registlet.items()),
            "MasteryLearned": lambda u, *r: int(mastery_lv(u) > 0),
            "MasteryLv": lambda u, *r: mastery_lv(u),
            "SkillLv": lambda u, *r: skill_lv(u),
            "MasteryParam": lambda u, pid, *r: mastery_param(int(u), int(pid), mastery_lv(u), inputs),
            "optionAvoid": self.option_avoid, "weaponElement": self.weapon_element, "subWeaponElement": self.sub_element, **inputs,
        })
        env.update({k: v for k, v in CONSTS.items() if k not in G["vars"]})
        # the decoder writes `gear.subWeaponCalculator.item.Type` as one dotted field name
        for side, it in (("mainWeaponCalculator", self.weapon), ("subWeaponCalculator", self.sub)):
            for f, v in it.items():
                gear[f"{side}.item.{f}"] = v
        env["out"] = 0
        env["fcvt"] = lambda x: x          # decoder residue: int <-> float conversion
        env["item"] = env["WeaponTypeCalculatorBase.item"] = self.weapon          # unbound `item` outside a calculator call is the main weapon
        env["serverBonusList"] = [0, 0, 0, 0]          # event / server EXP (0, 1) and drop (2, 3) bonuses: none
        env["serverBonusList.Length"] = 4
        env["allBonusList.Count"] = 0
        E = CE.Evaluator(env, G)
        E.rawzero = []
        E.equip_buffers = equip
        for n in ("this", "secondaryStatus", "playerStatus", "actionManager"):
            E.env[n] = {"guildStatusBoostType": 0, "lv": self.primary["lv"]}
        E.env["guildStatusBoostType"] = 0
        E.env["guildStatusBoostRate"] = 0
        return E


ENV_HANDLED = {"GemCartBufferManager.GetBufferValue", "GemCartBufferManager.ContainsBuffer", "GemCartBufferManager.GetBufferLevel", "GemCartBufferManager.GetGemCartBuffer", "GemCartBufferBase.GetValue", "MasteryLv", "SkillEqLimit", "MasteryLearned", "SkillLv", "MasteryParam", "BonusManager.GetBuffValue", "BonusManager.GetBonusTime", "BonusManager.GetAvatarBonusValue", "EquipBuffManager.GetParam", "EquipBuffManager.IsGrantStopAbnormal"}          # answered by evaluator() itself: the exporter does not follow them into fns
VIRTUAL = "EquipItemData.WeaponTypeCalculatorBase."
NOT_IN_BATTLE = re.compile(r"get_IsBattleActive$")
SK = r"PlayerStatusBase\.get_SkillManager\(\)"
SKILL_KEY = r"(?:SkillId\.(\w+)|(\d+))"
MASTERY_LEVEL = re.compile(SK + r"\.SkillMasteryList\[SkillId\.(\w+)\]\.skillData\.Level")          # level of a mastery the character may have learned: SkillLv(uid)
MASTERY_LEARNED = re.compile(r"System\.Collections\.Generic\.Dictionary<Int32Enum, object>\.TryGetValue\(" + SK + r"\.SkillMasteryList, " + SKILL_KEY + r", (?:out|stkp\(-?\d+\)|\(this \+ \d+\))\)")          # bool: mastery learned (the out argument is a local, a stack slot or a field of the calculator)
MASTERY_PARAM = re.compile(r"SkillMasteryBase\.GetMasteryParam\(MasteryId\.(\w+), " + SK + r"\.SkillMasteryList\[SkillId\.(\w+)\]\)")          # receiver recovered by symexec.MASTERY_RECV
KNIGHT_WILL = re.compile(r"KnightWill\.GetParam\(" + SK + r"\.SkillMasteryList\[SkillId\.KnightWill\], BonusType\.(\w+), ")          # receiver = the learned mastery (the override takes its level); the type is the nested enum KnightWill.BonusType
KNIGHT_WILL_TYPE = {"AssaultAttackSkillRate": 0, "ParryTrigger": 1, "RageSwordSkillRate": 2, "BindStrikeSkillRate": 3, "P_DeffenceRecoveryLimit": 4, "HateRate": 5}
MASTER_DATA = re.compile(SK + r"\.SkillMasteryList\[SkillId\.(\w+)\]\.skillData\.MasterData")          # the SkillMasterData of a skill, only ever passed to CheckSkillMainEquipLimit: its EqLimit mask
SKILL_LV = re.compile(r"SkillManager\.GetSkillLv\(" + SK + r", " + SKILL_KEY + r", (?:True|\d+)\)")
FLOAT_BITS = re.compile(r"\b0x3f800000\b")          # the decoder prints the float constant 1.0 as its bit pattern (the only float pattern in the stat functions)
BARRIER = re.compile(r"GetBarrierValue$")          # barrier of a buffer that is not running
ABSENT_BUFFER = re.compile(r"TryGetEquipBuffer.*\.out2$")
TRY_EQUIP_BUFFER = re.compile(r"EquipBuffManager\.TryGetEquipBuffer(<[^>]*>)?$")          # the bool of `TryGetEquipBuffer<T>(manager, id, out buf)`
EQUIP_BUFFERS = json.load(open(r"D:\toram reverse data\player_status\equip_buffers.json", encoding="utf-8"))["buffers"]


def equip_buffer_table(bonus):
    """EquipBuffManager as the client builds it (CreateBuff): one buffer per BonusType 135..165 the gear carries, lines of one type combined by SumValue.
    The typed form has no per-slot split, so the total is what the first line plus every SumValue would give (add; caps; floor 0 for the pursuits)."""
    out = {}
    for bid, b in EQUIP_BUFFERS.items():
        total = bonus.get(b["bonus"], 0)
        if not total:
            continue
        value = min(total, b["cap"]) if b["cap"] is not None else max(total, b["floor"]) if b["floor"] is not None else total
        out[int(bid)] = {"Value": value, "CalcValue": total if b["calcValue"] else 0, "IsValid": 1, "GetParam": value if b["getParam"] == "Value" else 0}
    return out


MASTERY_JSON = json.load(open(r"D:\toram reverse data\player_status\mastery_table.json", encoding="utf-8"))
MASTERY_TABLE = MASTERY_JSON["masteries"]
EQ_LIMIT = {int(k): v for k, v in MASTERY_JSON["skillEqLimit"].items()}
WIZARD_TREE = {int(r["SkillUid"]) for r in csv.DictReader(open(r"D:\toram reverse data\skills\skills.csv", encoding="utf-8-sig")) if r["SkillTreeType"] == "32"}          # PlayerSecondaryStatus.get_Cspd: GetAllSkillLvInTree(0x20) / GetSkillNumInTree(0x20)
_PARAM_OF = {}


def mastery_param(uid, pid, lv, inputs):
    """GetMasteryParam(MasteryId pid) of the learned mastery `uid` at level lv: the by-level table of build_mastery_table.py (0 = not learned / parameter not handled by the class)"""
    m = MASTERY_TABLE.get(str(uid))
    if not lv or not m:
        return 0
    pr = _PARAM_OF.setdefault(uid, {p["id"]: p for p in m["params"].values()}).get(pid)
    if pr is None:
        return 0
    lv = min(lv, m["maxLv"])
    if pr["byLevel"] is not None:
        return pr["byLevel"][lv - 1]
    return CE.Evaluator({"Lv": lv, "id": pid, "System.Math.Max": max, **inputs}, {"vars": {}}).eval(pr["expr"])


DECODER_ARGS = re.compile(r",\s*meta\(0x[0-9a-f]+,\s*[^()]*\(\)\)|,\s*\?x\d")          # the generic-method MethodInfo argument and unused trailing argument registers of a call
RAW_ITEM_STABLE = re.compile(r"\[\[WeaponTypeCalculatorBase\.item\+0x28\]\+0x40\]")          # ItemData.dbData (0x28) -> ItemDBData.Stable (0x40), dump.cs
RAW_OPTION_AVOID = re.compile(r"\[\[Singleton<OptionManager>\.get_Instance\(\)\+0x28\]\+0x54\]")          # OptionManager.OptionsSystem (+0x28) .Avoid (+0x54), dump.cs: AvoidStack shifts left by 1 only when it is 0 (Manual)
RAW_ITEM_FUNCTION = re.compile(r"\[WeaponTypeCalculatorBase\.item\+0x42\]")          # ItemData.<Function>k__BackingField (0x42, short) = weapon ATK / armour DEF, dump.cs; was taken as 0 until 2026-10-03
RAW_ITEM_TYPE = re.compile(r"\[WeaponTypeCalculatorBase\.item\+0x38\]")          # ItemData.<Type>k__BackingField (0x38, int) = ItemType of the weapon, dump.cs; was taken as 0 until 2026-10-03 (CalcAtk: one-handed sword +5 mastery ATK%)
RAW_ABSENT_BUF = re.compile(r"\[TryGetBuf\.buf\((?:[^()]|\([^()]*\))*\)\+0x[0-9a-f]+\]")          # a field of a buffer that is not running (guarded by `buf ne 0`)
RAW_LOAD = re.compile(r"\[[^\[\]]*\+0x[0-9a-f]+\]")          # any other raw memory load the decoder could not name


def clean(text, rawzero):
    """decoder residue -> evaluable text. Raw loads left after the known ones are taken as 0 and listed in `rawzero` (a row that used one is flagged)"""
    text = DECODER_ARGS.sub("", text)
    text = MASTERY_PARAM.sub(lambda m: f"MasteryParam({CONSTS['SkillId.' + m.group(2)]}, {CONSTS['MasteryId.' + m.group(1)]})", text)
    text = MASTERY_LEARNED.sub(lambda m: f"MasteryLearned({CONSTS['SkillId.' + m.group(1)] if m.group(1) else m.group(2)})", text)
    text = SKILL_LV.sub(lambda m: f"SkillLv({CONSTS['SkillId.' + m.group(1)] if m.group(1) else m.group(2)})", text)
    text = KNIGHT_WILL.sub(lambda m: f"KnightWill.GetParam(SkillLv({CONSTS['SkillId.KnightWill']}), {KNIGHT_WILL_TYPE[m.group(1)]}, ", text)
    text = MASTER_DATA.sub(lambda m: f"SkillEqLimit({CONSTS['SkillId.' + m.group(1)]})", text)
    text = MASTERY_LEVEL.sub(lambda m: f"MasteryLv({CONSTS['SkillId.' + m.group(1)]})", text)
    text = FLOAT_BITS.sub("1.0", text)
    text = RAW_ITEM_STABLE.sub("item.dbData.Stable", RAW_ABSENT_BUF.sub("0", text))
    text = RAW_OPTION_AVOID.sub("optionAvoid", text)
    text = RAW_ITEM_FUNCTION.sub("item.Function", text)
    text = RAW_ITEM_TYPE.sub("item.Type", text)
    while True:
        m = RAW_LOAD.search(text)
        if not m: return text
        rawzero.append(m.group(0))
        text = text[:m.start()] + "0" + text[m.end():]


class Absent(dict):
    """what `TryGetEquipBuffer(...).out2` gives when no such equip buffer exists: every field reads 0"""
    def __contains__(self, k): return True
    def __getitem__(self, k): return 0
OBJECT_GETTERS = re.compile(r"^(Singleton<\w+>\.get_Instance|PlayerDataManager\.get_\w+|PlayerActionManagerBase\.get_PlayerStatus|PlayerStatusBase\.get_(EquipItemData|BonusManager|SkillBufferManager|SkillManager|GameStatus|BattleStatus|SecondaryStatus|\w*Manager))$")


def eval_absent(E, expr, missing):
    """evaluate; a leaf the naked character lacks (matching ABSENT) is 0, anything else is recorded in `missing` and re-raised"""
    original = E.call
    original_ast = E.ast
    E.ast = lambda text: original_ast(clean(text, E.rawzero))

    def call(nm, args, sc, lets):
        if nm.startswith("IPlayerStatusCalculator."):
            nm = "PlayerSecondaryStatus." + nm.split(".", 1)[1]
        calc = None
        if nm.startswith("EquipItemData.") and "Calculator" in nm and args:          # a method of a weapon calculator: it reads `item` of its receiver
            try:
                calc = E.ev(args[0], sc, lets)
            except CE.Unresolved:
                pass
            if not (isinstance(calc, dict) and "cls" in calc) and nm.startswith(VIRTUAL):
                # `this.calcAspdParam(...)` inside a calculator method: the decoder drops the receiver, so the first argument is a data argument. The receiver is the
                # calculator the outer call entered (E.env["this"]); without this every weapon type ran OneHundSwordCalculator's calcAspdParam / CalcStable (fixed 2026-10-03)
                calc = E.env.get("this")
            if isinstance(calc, dict) and "cls" in calc:
                concrete = f"EquipItemData.{calc['cls']}Calculator.{nm[len(VIRTUAL):]}"          # virtual call: the concrete class's own method, else the base one
                if nm.startswith(VIRTUAL) and concrete in E.V:
                    nm = concrete
                saved = {k: E.env.get(k) for k in ("item", "WeaponTypeCalculatorBase.item", "this")}
                E.env["item"] = E.env["WeaponTypeCalculatorBase.item"] = calc["item"]
                E.env["this"] = calc
                try:
                    return original(nm, args, sc, lets)
                finally:
                    for k, v in saved.items():
                        E.env[k] = v
        if nm not in E.env:
            if OBJECT_GETTERS.search(nm):
                return {}
            if TRY_EQUIP_BUFFER.search(nm) or ABSENT_BUFFER.search(nm):
                try:
                    found = getattr(E, "equip_buffers", {}).get(E.ev(args[1], sc, lets))
                except (CE.Unresolved, IndexError):
                    found = None
                if TRY_EQUIP_BUFFER.search(nm):
                    return int(found is not None)
                return dict(found) if found is not None else Absent()
            if ABSENT.search(nm) or NOT_IN_BATTLE.search(nm) or BARRIER.search(nm):
                return 0
        return original(nm, args, sc, lets)
    E.call = call
    try:
        return E.eval(expr)
    except CE.Unresolved as u:
        missing[str(u)] += 1
        return None
    except Exception as ex:
        missing[f"{type(ex).__name__}:{str(ex)[:60]}"] += 1
        return None
    finally:
        E.call = original
        E.ast = original_ast


def rows_of(panel):
    out = []
    for method, m in panel["methods"].items():
        for r in m.get("rows", []):
            a = r["args"]
            if len(a) < 4: continue
            out.append({"method": method, "type": a[1].split(".")[-1], "expr": a[2], "format": a[3].split(".")[-1], "when": r["when"]})
    for s in ("Crt", "Luk", "Men", "Tec"):          # the screen shows five primary stats; the other four totals are the same getters (the buff calculator needs them)
        out.append({"method": "AddPrimaryExtra", "type": s.upper(), "expr": f"PlayerSecondaryStatus.get_{s}(secondaryStatus)", "format": "Int", "when": []})
    return out


def compute(ch):
    panel = json.load(open(PANEL, encoding="utf-8"))
    E = ch.evaluator()
    missing = collections.Counter()
    result = []
    for r in rows_of(panel):
        one = collections.Counter()
        E.rawzero.clear()
        v = eval_absent(E, r["expr"], one)
        missing.update(one)
        result.append({**r, "value": v, "error": next(iter(one), None), "assumed0": len(E.rawzero)})
    return result, missing


if __name__ == "__main__":
    ch = Character(lv=200, str_=100, int_=100, vit=150, agi=100, dex=255, weapon=item(12, 300, 10, 9), sub=item(19, 50, 5), body=item(20, 200, 0, 9))
    res, missing = compute(ch)
    ok = [r for r in res if r["value"] is not None]
    print(f"rows {len(res)}  evaluated {len(ok)}")
    for r in res[:60]:
        print(f"{r['method'][3:]:22} {r['type']:20} {r['value']}  {r.get('error') or ''}")
    print("blocking leaves:", missing.most_common(25))
