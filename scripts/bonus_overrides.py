"""Hand-decoded bodies of client functions whose symexec output is unusable (libil2cpp, arm64, read from the disassembly with `python dis_android.py 0xRVA`).

BonusManager.CulcConvertAtk 0x20bb9d0 / CulcConvertMAtk 0x20bbc84  (callers: WeaponTypeCalculatorBase.CalcAtk / CalcMatk, nobody else)
  The decoder only saw an enumerator loop (`MoveNext(out)`, every term `* 0`). The code builds Dictionary<BonusType,int> {bType_k -> primaryStatus.stat_k} for
  k = Str, Int, Vit, Agi, Dex (PlayerPrimaryStatus +0x14..+0x24: the allocated points, not the totals) and adds up
      sum_k  getDataBonusValue(bType_k) / 1000.0f * stat_k          (float32)
  getDataBonusValue = sum of every bonus parameter of that type (same number as GetBonusValue).
  ATK: bType 166..170 = bStrToAtk bIntToAtk bVitToAtk bAgiToAtk bDexToAtk; MATK: 171..175 = bStrToMAtk ... bDexToMAtk.
  Return value = (int)total (truncation, NaN-guarded); the two `out` ints are the positive and the negative part, unused by CalcAtk / CalcMatk.
  The result is the `baseAtkUp` / `baseMatkUp` argument of every weapon calculator's calcAtkParam / calcMatkParam: it is added to the stat sum BEFORE the
  ATK% / MATK% rate multiplies it (OneHundSwordCalculator.calcAtkParam 0x18f6484: int(rate * ((a + baseAtkUp + b) + 2 * c)) + atk).
  NOTE: README missing-data/02 named `ConversionAction.CheckApplicationConversion` as the owner of these lines; that is the skill "Conversion" (ATK <-> MATK
  conversion, weapon types 10 11 13 16 via the mask 0x4b) and has nothing to do with bStrToAtk.

BonusManager.GetCalcBonusValue 0x20ba524 (callers: PlayerSecondaryStatus.CalcHpRecovery / CalcMpRecovery and other "base * rate + constant" stats)
  The decoder kept only the empty-enumerator path (`int(baseVal)`). Code: for every BonusData whose type list contains rateType or constType, for every parameter
      const += value if param.type == constType ;  rate += value if param.type == rateType      (const starts at 0, rate at 100.0)
  result = (int)(const + rate / 100.0f * baseVal).  So natural HP recovery = int(bHpRecovery + (100 + bHpRecoveryRate) / 100 * (min(CalcBaseMaxHp, 99999) // 25 + 10)).

PlayerSecondaryStatus.CalcHpRecovery 0x2051d14 / CalcMpRecovery 0x2051fe0  (Details rows HpRecovery / MpRecovery)
  The decoder merged the two branches of `isBattle` (the `tbz w22` test) and lost the 1.0 start of the multiplier, so it always returned the in-battle case = 0.
  HP: base = min(CalcBaseMaxHp, 99999) // 25 + 10 ; MP: base = max(0, min(CalcBaseMaxMp, 2000)) // 100 + 1
      c  = GetCalcBonusValue(base, rate, const)                    rate/const = bHpRecoveryRate/bHpRecovery (35/34), bMpRecoveryRate/bMpRecovery (37/36)
      flat = LifeRecovery buffer (SkillId 226 HP / 227 MP) GetParam(15 HP / 17 MP), 0 without it
      in battle:      int(m * c) + flat,  m = 0 unless mastery 199 (HP) / 201 (MP) is learned: GetMasteryParam(Value) / 100
      out of battle:  int(v + m * c) + flat,  m = 1 (+ GetMasteryParam(Percent) / 100 when mastery 196 / 197 is learned) (+ HealingSong 0x301 GetParam(16 HP / 18 MP) / 100;
                      MP also adds buffer 232 GetParam(17) / 100), v = GetMasteryParam(Value) when that mastery is learned else 0
      HP is 0 while skill buffer 1064 is in selfSkillBufList.

PlayerSecondaryStatus.get_AtkMpRecovery 0x204daa0  (Details row AtkMpRecovery)
  The text had one `?` residue (ccmp / cinc). Everything else symexec decoded (skills/damage/stats/decoded/player), so the override is that decoded body with the residue replaced:
      `?ccmp eq 0` in the Rampage branch = (main weapon type eq 10 && sub weapon type eq 10)   (0x204dd78: cmp w21, #10 / ccmp w20, #10 -> divisor 1 + eq; w20 = main, w21 = sub)
  Result (no buffs): int(m * (r * base + c)),  base = min(CalcBaseMaxMp, 2000) // 100 + 10,  m = 1
      r = 1 + sum(bAtkMpRecoveryRate) / 100 + GemCartBufferManager.GetBufferValue(GemCartBufferId.AtkMpRecoveryUpRate) / 100          (registlet 21 SilentRecharge: Lv * 5)
      c = sum(bAtkMpRecovery) + [OneChance 133 learned and (main weapon type 16 or sub weapon type 16 or main type 0)] MasteryParam(Value, OneChance)
  The terms that need a running skill buffer (CallGolem, GlaiveTigger, CollectQigong + CollectQigongExtreme 1094, Shukuchi, Rampage, buffer parameters) stay in the text and read as absent without one.
  History: the first version kept only the bonus lines and ignored OneChance and the registlet (found 2026-10-03 while giving the missing-data/09 mastery verdicts).

GodspeedLocus.CalcFirstAttackRate / AfterShield.GetNormalResist (skill-only terms of the FirstAttackRate and NormalShield rows)
  Both were "not decoded" for the exporter although symexec reads them: CalcFirstAttackRate = 0 unless mastery 648 is learned, then MasteryParam(FirstAttackRate)
  (+10 with a one-handed sword in both hands); GetNormalResist = MasteryParam(NormalResist) while skill buffer 525 (AfterShield) runs and is not on cooldown, else 0.
  A naked character has neither, so both read 0 and the row is the item line + 100 (FirstAttackRate) or the item line (NormalShield).

AvoidActionManager.get_MaxAvoidCount (row AvoidStack): = IPlayerStatusCalculator.get_AvoidStack(SecondaryStatus) // 1000 (symexec reads it; it was not in the exported set).

BonusManager.GetEquipElement 0x20ba3b0 (callers: PlayerSecondaryStatus.CalcBaseMaxMp via EquipType.Weapon; PlayerStatusBase.GetEquipElement / GetEquipSubWeaponElement for the damage side)
  The decoder returned 0 (the LINQ lambda and the BonusData list field were opaque). Code: `equipBonusList[type]` (Dictionary<EquipType, BonusData>, +0x20) -> `.bonusList` (+0x20)
  .FirstOrDefault(x => x.Type == 0x41) (lambda `<GetEquipElement>b__71_0`: `cmp w8, #0x41`, 0x41 = 65 = BonusType.bElement) -> `.Value` (+0x14), 0 when the slot holds no item / no element line.
  So the weapon element is the value of the weapon's own bElement stat line (ElementType: 0 None, 1 Fire, 2 Water, 3 Wind, 4 Earth, 5 Light, 6 Dark, 7 Normal, 8 Mana; 11-13 Frame / Ice / Thunder).
  The calculator keeps one summed `bonus` dict, which has no slot split: the element is therefore its own input per slot (`weaponElement` = EquipType 1, `subWeaponElement` = EquipType 2).
  CalcBaseMaxMp reads it as `weapon element eq 8` (Mana): + int(INT / 2.5) MaxMP.

ConversionAction.GetMasteryValue / CheckApplicationConversion (callers: WeaponTypeCalculatorBase.CalcMatk, ATK <-> MATK conversion of the skill Conversion 867)
  Both were outside the exported set (CheckApplicationConversion sat in the `absent` rule and read 0). Code (decode_fn): GetMasteryValue(lv, id) = id eq 28 (MasteryId.Value) ? lv * lv : 0;
  CheckApplicationConversion(type) = (type - 10) <= 6 ? (0x4b >> (type - 10)) & 1 : 0 = main weapon types 10 11 13 16.

KnightWill.GetParam(type, isEquipShield) 0x235c108 (caller: PlayerSecondaryStatus.GetDisplayBonusCalcHate, HateRate; the other types are read by the skill actions)
  The decoder saw a jump table it could not follow (`(0 << shield)`, one path without a value). Code: a 6-entry byte table at rodata 0x949a9f ([6, 0, 11, 16, 22, 0]) picks, with Lv = skillData.Level (+0x18):
  type 0 AssaultAttackSkillRate Lv * 30, 1 ParryTrigger Lv, 2 RageSwordSkillRate Lv * 25, 3 BindStrikeSkillRate Lv * 20 ((Lv + Lv * 4) << 2), 4 P_DeffenceRecoveryLimit Lv * 50, 5 HateRate Lv; type > 5 -> 0.
  The result is shifted left by (isEquipShield & 1): doubled with a shield as sub weapon (item type 17).

SkillUtil.CheckSkillMainEquipLimit(equipItemData, masterData, out int) 0x23a69f8 (caller: PlayerSecondaryStatus.get_Cspd for Cast Mastery 1033; the weapon-limit test of a learned mastery)
  `mask` = SkillMasterData.EqLimit (+0x24, a 32-bit SkillEqLimitFlag: the SkillMaster record stores it as an int, the old export read only its low half as `EqLimit` and the high half as `SkillType`).
  mask == 0x1800ff (AllWeapon) -> true. A sub weapon is equipped and mask has SubWeaponExclusion (0x40000) -> false. Main weapon type 0 (bare hands) with Hand | MainHand (0x10000001) -> true.
  Main type 10 / 11 / 12 / 13 / 14 -> mask & 2 / 4 / 8 / 0x10 / 0x20; 15 Magictool -> mask & 0x1000040 (Magictool | MainMagictool); 16 Knuckle -> mask & 0x800080 (Knuckle | MainKnuckle);
  9 Halberd -> mask & 0x80000; 8 Katana -> mask & 0x2100000 (Katana | SubMagictool). Anything else false. The `out` int (the part of the mask that matched) is not read by get_Cspd.

Label: Code. The unit of the stored value (1000 = +1.0 x stat, while the item text prints `STR{0}%`) is not confirmed in game.
"""

import re

BON = "BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), BonusType.{})"
STATS = ("str", "int", "vit", "agi", "dex")


def _convert(name, target):
    terms = " + ".join(f"({BON.format(f'b{s.capitalize()}To{target}')} / 1000) * status.{s}" for s in STATS)
    return {"id": name, "kind": "stat_fn", "impls": [{"name": name, "params": [["PlayerPrimaryStatus", "status"], ["int", "plusValue"], ["int", "minusValue"]],
                                                       "static": False, "returns": "int", "cases": [{"value": f"int({terms})", "common": [], "variants": []}], "lets": {}}]}


def _calc_bonus_value(name):
    # rateType / constType are runtime arguments, not constants: read them through the evaluator's name lookup
    value = ("int(BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), constType) + "
             "((100 + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), rateType)) / 100) * baseVal)")
    return {"id": name, "kind": "stat_fn", "impls": [{"name": name, "params": [["int", "baseVal"], ["BonusType", "rateType"], ["BonusType", "constType"]],
                                                       "static": False, "returns": "int", "cases": [{"value": value, "common": [], "variants": []}], "lets": {}}]}


def _recovery(name, kind):
    hp = kind == "Hp"
    base = ("((PlayerSecondaryStatus.CalcBaseMaxHp(this) lt 0x1869f ? PlayerSecondaryStatus.CalcBaseMaxHp(this) : 0x1869f) // 25) + 10" if hp else
            "(max(0, (PlayerSecondaryStatus.CalcBaseMaxMp(this) lt 2000 ? PlayerSecondaryStatus.CalcBaseMaxMp(this) : 2000)) // 100) + 1")
    mastery_battle, mastery_idle = (199, 196) if hp else (201, 197)
    flat_buf, flat_param = (226, 15) if hp else (227, 17)
    song_param = 16 if hp else 18
    sbm = "PlayerStatusBase.get_SkillBufferManager()"
    ml = "PlayerStatusBase.get_SkillManager().SkillMasteryList"
    lets = {"_c": f"BonusManager.GetCalcBonusValue(PlayerStatusBase.get_BonusManager(), {base}, BonusType.b{kind}RecoveryRate, BonusType.b{kind}Recovery)",
            "_flat": f"((SkillBufferManager.TryGetBuf({sbm}, {flat_buf}, out) & 1) ne 0 ? SkillBufferDataBase.GetParam({flat_param}) : 0)",
            "_mb": f"(System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue({ml}, {mastery_battle}, out) & 1) ne 0",
            "_mi": f"(System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue({ml}, {mastery_idle}, out) & 1) ne 0",
            "_song": f"((SkillBufferManager.TryGetBuf({sbm}, 769, out) & 1) ne 0 ? (SkillBufferDataBase.GetParam({song_param}) / 100) : 0)"}
    extra = "" if hp else f" + ((SkillBufferManager.TryGetBuf({sbm}, 232, out) & 1) ne 0 ? (SkillBufferDataBase.GetParam(17) / 100) : 0)"
    lets["_m"] = f"((_mi ? (MasteryParam({mastery_idle}, 27) / 100) : 0) + 1 + _song{extra})"          # MasteryParam(uid, MasteryId): Percent 27, Value 28
    battle = f"int((_mb ? (MasteryParam({mastery_battle}, 28) / 100) : 0) * _c) + _flat"
    idle = f"int((_mi ? MasteryParam({mastery_idle}, 28) : 0) + _m * _c) + _flat"
    if hp:
        guard = "System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList, 1064)"
        battle, idle = f"({guard} ? 0 : {battle})", f"({guard} ? 0 : {idle})"
    return {"id": name, "kind": "stat_fn", "impls": [{"name": name, "params": [["bool", "isBattle"]], "static": False, "returns": "int", "lets": lets,
                                                       "cases": [{"value": battle, "common": ["(isBattle & 1) ne 0"], "variants": []},
                                                                 {"value": idle, "common": ["(isBattle & 1) eq 0"], "variants": []}]}]}


def _helper(name, expr, params=()):
    return {"id": name, "kind": "stat_fn", "impls": [{"name": name, "params": [list(p) for p in params], "static": False, "returns": "float",
                                                       "cases": [{"value": expr, "common": [], "variants": []}], "lets": {}}]}


DECODED_PLAYER = r"D:\toram reverse data\skills\damage\stats\decoded\player" + "\\"
MAIN_T = "EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator)"
SUB_T = "EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator)"


def _atkmp():
    """get_AtkMpRecovery as decoded, with its single residue replaced (see the docstring); asserts that no other `?` residue is left"""
    import json
    d = json.load(open(DECODED_PLAYER + "PlayerSecondaryStatus$$get_AtkMpRecovery.json", encoding="utf-8"))
    both10 = f"({MAIN_T} eq 10 && {SUB_T} eq 10)"
    assert sum(v.count("?ccmp eq 0") for v in d["lets"].values()) == 1, "the ccmp residue moved: review bonus_overrides.py"
    lets = {k: v.replace("?ccmp eq 0", both10) for k, v in d["lets"].items()}
    cases = [dict(c, value=c["value"].replace("?ccmp eq 0", both10)) for c in d["cases"]]
    assert not re.search(r"\?[a-z]\w*", json.dumps([lets, cases])), "another decoder residue appeared in get_AtkMpRecovery"
    return {"id": "PlayerSecondaryStatus.get_AtkMpRecovery", "kind": "stat_fn", "impls": [{"name": "PlayerSecondaryStatus.get_AtkMpRecovery", "params": [], "static": False,
                                                                                        "returns": "int", "cases": cases, "lets": lets}]}


EQB = "TryGetEquipBuffer<object>.out2(PlayerStatusBase.get_EquipBuffManager(), {}).Value"


FIRST_ATTACK = ("((System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue(PlayerStatusBase.get_SkillManager().SkillMasteryList, 648, out) & 1) ne 0 ? "
                "(EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) eq 10 && "
                "EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator) eq 10 ? "
                "MasteryParam(648, 30) + 10 : MasteryParam(648, 30)) : 0)")          # GodspeedLocus (648) FirstAttackRate = MasteryId 30
NORMAL_RESIST = ("((SkillBufferManager.TryGetBuf<AfterShieldBuf>(PlayerStatusBase.get_SkillBufferManager(), 525, out) & 1) ne 0 ? "
                 "MasteryParam(525, 49) : 0)")          # AfterShield (525) NormalResist = MasteryId 49


def _status_fn(name, expr, returns="int"):
    return {"id": name, "kind": "stat_fn", "impls": [{"name": name, "params": [["PlayerStatusBase", "status"]], "static": False, "returns": returns,
                                                       "cases": [{"value": expr, "common": [], "variants": []}], "lets": {}}]}


EQUIP_LIMIT = ("(mask eq 1573119 ? 1 : ((EquipItemData.get_SubWeaponItemType(equip) ne 0 && (mask & 262144) ne 0) ? 0 : "
               "((EquipItemData.get_WeaponItemType(equip) eq 0 && (mask & 268435457) ne 0) ? 1 : "
               "((EquipItemData.get_WeaponItemType(equip) eq 10 && (mask & 2) ne 0) || (EquipItemData.get_WeaponItemType(equip) eq 11 && (mask & 4) ne 0) || "
               "(EquipItemData.get_WeaponItemType(equip) eq 12 && (mask & 8) ne 0) || (EquipItemData.get_WeaponItemType(equip) eq 13 && (mask & 16) ne 0) || "
               "(EquipItemData.get_WeaponItemType(equip) eq 14 && (mask & 32) ne 0) || (EquipItemData.get_WeaponItemType(equip) eq 15 && (mask & 16777280) ne 0) || "
               "(EquipItemData.get_WeaponItemType(equip) eq 16 && (mask & 8388736) ne 0) || (EquipItemData.get_WeaponItemType(equip) eq 9 && (mask & 524288) ne 0) || "
               "(EquipItemData.get_WeaponItemType(equip) eq 8 && (mask & 34603008) ne 0) ? 1 : 0))))")
KNIGHT_WILL = ("((type eq 0 ? (lv * 30) : (type eq 1 ? lv : (type eq 2 ? (lv * 25) : (type eq 3 ? (lv * 20) : (type eq 4 ? (lv * 50) : (type eq 5 ? lv : 0)))))) << (isEquipShield & 1))")
EQUIP_ELEMENT ="(type eq 1 ? weaponElement : (type eq 2 ? subWeaponElement : 0))"


def _typed_fn(name, params, expr, static=True):
    return {"id": name, "kind": "stat_fn", "impls": [{"name": name, "params": [list(p) for p in params], "static": static, "returns": "int",
                                                       "cases": [{"value": expr, "common": [], "variants": []}], "lets": {}}]}


def overrides():
    return {
        "KnightWill.GetParam": _typed_fn("KnightWill.GetParam", [["int", "lv"], ["KnightWill.BonusType", "type"], ["bool", "isEquipShield"]], KNIGHT_WILL),
        "SkillUtil.CheckSkillMainEquipLimit": _typed_fn("SkillUtil.CheckSkillMainEquipLimit", [["EquipItemData", "equip"], ["int", "mask"]], EQUIP_LIMIT),
        "BonusManager.GetEquipElement": _typed_fn("BonusManager.GetEquipElement", [["EquipType", "type"]], EQUIP_ELEMENT, static=False),
        "ConversionAction.GetMasteryValue": _typed_fn("ConversionAction.GetMasteryValue", [["int", "lv"], ["MasteryId", "id"]], "(id eq 28 ? (lv * lv) : 0)"),
        "ConversionAction.CheckApplicationConversion": _typed_fn("ConversionAction.CheckApplicationConversion", [["int", "type"]],
                                                                  "((type ge 10 && type le 16) ? ((75 >> (type - 10)) & 1) : 0)"),          # unsigned `(type - 10) <= 6` (b.hi): types 10..16
        "AvoidActionManager.get_MaxAvoidCount": _helper("AvoidActionManager.get_MaxAvoidCount", "IPlayerStatusCalculator.get_AvoidStack(PlayerStatusBase.get_SecondaryStatus()) // 1000", ()),
        "GodspeedLocus.CalcFirstAttackRate": _status_fn("GodspeedLocus.CalcFirstAttackRate", FIRST_ATTACK),
        "AfterShield.GetNormalResist": _status_fn("AfterShield.GetNormalResist", NORMAL_RESIST),
        "PlayerSecondaryStatus.get_AtkMpRecovery": _atkmp(),
        "PlayerSecondaryStatus.CalcHpRecovery": _recovery("PlayerSecondaryStatus.CalcHpRecovery", "Hp"),
        "PlayerSecondaryStatus.CalcMpRecovery": _recovery("PlayerSecondaryStatus.CalcMpRecovery", "Mp"),
        "BonusManager.GetCalcBonusValue": _calc_bonus_value("BonusManager.GetCalcBonusValue"),
        "BonusManager.CulcConvertAtk": _convert("BonusManager.CulcConvertAtk", "Atk"),
        "BonusManager.CulcConvertMAtk": _convert("BonusManager.CulcConvertMAtk", "MAtk"),
    }


# Evidence: every hand-written body above rests on immediates read from the disassembly. check() fails loudly when a function moved or its constants changed
# (a new build): the answer is then "review this entry", not "ignore".
EVIDENCE = {
    "BonusManager$$CulcConvertAtk": ["#0xa6", "#0xa7", "#0xa8", "#0xa9", "#0xaa", "#0x447a0000"],
    "BonusManager$$CulcConvertMAtk": ["#0xab", "#0xac", "#0xad", "#0xae", "#0xaf", "#0x447a0000"],
    "BonusManager$$GetCalcBonusValue": ["#0x42c80000"],
    "BonusManager$$GetMaxBonusConstant_Rate": ["#0xa"],
    "PlayerSecondaryStatus$$CalcHpRecovery": ["#0x23", "#0x22", "#0xc7", "#0xc4", "#0xe2", "#0x301"],
    "PlayerSecondaryStatus$$CalcMpRecovery": ["#0x25", "#0x24", "#0xc9", "#0xc5", "#0xe3", "#0xe8", "#0x7d0"],
    "PlayerSecondaryStatus$$get_AtkMpRecovery": ["#0x26", "#0x27", "#0x7d0", "#0x461", "#0x241", "#0x85", "#0x29", "#0x26b", "#0x33", "#0x32", "#0xa"],
    "BonusManager$$GetEquipElement": ["#0x20", "#0x14"],
    "BonusManager.<>c$$<GetEquipElement>b__71_0": ["#0x41", "#0x10"],
    "ConversionAction$$CheckApplicationConversion": ["#0x4b", "#0xa"],
    "ConversionAction$$GetMasteryValue": ["#0x1c"],
    "KnightWill$$GetParam": ["#0x1e", "#0x19", "#0x32", "#0x18", "#5"],
    "SkillUtil$$CheckSkillMainEquipLimit": ["#0x18", "#0xff", "#0x40000", "#0x1000", "#0x100", "#0x800080", "#0x80000", "#0x2100000", "#0x24"],
}


def check():
    import re
    import dis_android as D
    by_name = {n: a for a, n in D.names.items()}
    for name, needles in EVIDENCE.items():
        assert name in by_name, f"{name}: function not found in script.json (renamed or removed): review bonus_overrides.py"
        s, e = D.func(by_name[name])
        text = " ".join(f"{i.mnemonic} {i.op_str}" for i in D.md.disasm(D.b[s - D.OFF:e - D.OFF], s))
        for n in needles:
            assert re.search(re.escape(n) + r"\b", text), f"{name}: immediate {n} no longer present: review the hand-decoded body"
    return len(EVIDENCE)


if __name__ == "__main__":
    import sys
    sys.path.insert(0, r"D:\toram_re")
    print("evidence ok:", check(), "functions")
