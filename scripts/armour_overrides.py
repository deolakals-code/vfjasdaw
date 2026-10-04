"""Hand-decoded bodies of EquipItemData.CalcDef / CalcMdef / CalcFlee (libil2cpp, arm64, read from the disassembly).

symexec cannot follow their `switch (body.BattleCustomize)` jump tables (the decoded cases keep only the impossible `> 3` path), so the four branches are
transcribed here from `python dis_android.py 0x18f3138 / 0x18f3adc / 0x18f2a68` with the jump tables read from the .so:

  BattleCustomize = ItemData.ability & 3   (ItemData$$get_BattleCustomize) : 0 normal armour, 1 light, 2 heavy, 3 none (an empty body slot goes the same way)
  CheckArmorAbility(item, type) = ((item.ability & 3) eq type)               (ItemDBData$$CheckArmorAbility)

  Def  = ((base + gear) * rate) // 100 + const
         base: normal Lv + Vit | light int(Lv*0.8 + Vit*0.25) | heavy int(Lv*1.2 + 2*Vit) | none int(Lv*0.4 + Vit/10)      (float32 constants read from .rodata: 0.8f, 1.2f, 0.4f are written with their float32 values)
         gear = shield Function (sub type 17) + Option + Special + Body Function
  Mdef = same with Int, bMdef / bMdefRate
  Flee = int(rate * int(base)) + const
         base: normal Lv + Agi | light 1.25*Lv + 1.75*Agi + 30 | heavy 0.5*Lv + 0.75*Agi - 15 | none 1.5*Lv + 2*Agi + 75

The skill terms (added 2026-10-03, missing-data/09 item 2: the first version modelled only the bonus lines and so ignored learned masteries, which are inputs since missing-data/07):
  The part of the Def / Mdef body that runs BEFORE the jump table is straight-line code that symexec did decode: `rate` and `const` are taken verbatim from the decoded lets
  (skills/damage/stats/decoded/weapon/EquipItemData$$CalcDef|CalcMdef.json), only the lost `0` (= base + gear) is put back. They hold
    rate  = 100 + bDefRate + SkillBufferParam(DefRate) (Orgaslash 56 / Berserk 46 buffers change it) ; with a shield (sub type 17) and ForceShield 259 (Mdef: MagicalShield 261) learned
            + MasteryParam(DefRate | MdefRate, that mastery) ; -25 with an Arrow sub weapon (type 19)
    const = bDef + SkillBufferParam(Def) + [DefUp 483 learned] MasteryParam(DefRate | MdefRate, DefUp) * Lv // 100 + [KnowledgeOfDefense 492 learned] MasteryParam(.., it) * Lv // 100
            + [shield and ForceShield / MagicalShield learned] MasteryParam(Def | Mdef, that mastery)
  CalcFlee has no decoded lets at all (everything sits behind the switch); its straight-line prologue was read from the disassembly (0x18f2ab0..0x18f2c08):
    constant, rate = GetBonusConstant_AvatarConstan_Rate(bFlee 24, bAvatarFlee 183, bFleeRate 25)   (constant = bFlee + bAvatarFlee, rate = 1 + bFleeRate / 100, float)
    FleeUp 486 learned:      constant += MasteryParam(Flee 19, FleeUp)          ShinobiWay 1217 learned: constant += MasteryParam(Flee 19, ShinobiWay)
    rate += SkillBufferParam(SkillBufferId.FleeRate 12) / 100.0 ;  constant += SkillBufferParam(SkillBufferId.Flee 13)
    result = int(rate * int(base)) + constant

Skill buffers (Orgaslash / Berserk and the buffer parameters) are not inputs of the calculator yet: they read as absent (0), which is what the client does without them.
Label: Code (decoded), not checked in game. check() asserts the evidence (decoded structure, disassembly immediates) so a new build fails loudly.
"""
import json
import re

LV = "IPlayerStatusCalculator.get_Lv(PlayerStatusBase.get_SecondaryStatus())"
STAT = {"vit": "IPlayerStatusCalculator.get_Vit(PlayerStatusBase.get_SecondaryStatus())",
        "int": "IPlayerStatusCalculator.get_Int(PlayerStatusBase.get_SecondaryStatus())",
        "agi": "IPlayerStatusCalculator.get_Agi(PlayerStatusBase.get_SecondaryStatus())"}
BON = "BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), BonusType.{})"
AB = "(ItemData.get_BattleCustomize(EquipItemData.get_Body(this)) & 255)"
SUB = "EquipItemData.get_SubWeapon(this)"
GEAR = (f"(({SUB}.Type eq 17 ? {SUB}.Function : 0) + EquipItemData.get_Option(this).Function + EquipItemData.get_Special(this).Function"
        " + EquipItemData.get_Body(this).Function)")
DECODED = r"D:\toram reverse data\skills\damage\stats\decoded\weapon" + "\\"
ML = "PlayerStatusBase.get_SkillManager().SkillMasteryList"
LEARNED = "System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue(" + ML + ", {}, out)"
PARAM = "SkillMasteryBase.GetMasteryParam(MasteryId.{}, " + ML + "[SkillId.{}])"
SBP = "SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), SkillBufferId.{})"


def _fn(name, cases, lets):
    return {"id": name, "kind": "stat_fn", "impls": [{"name": name, "params": [["PlayerStatusBase", "status"]], "static": False, "returns": "int", "cases": cases, "lets": lets}]}


def _decoded(name):
    return json.load(open(DECODED + name.replace(".", "$$", 1) + ".json", encoding="utf-8"))


def _defence(name, stat, bonus, rate_bonus):
    """Def / Mdef: the decoded lets (rate, const incl. masteries and buffer parameters) + the hand-decoded base per body ability"""
    d = _decoded(name)
    case = d["cases"][0]["value"]
    assert case.count("(0 * ") == 1 and "// 100) + _t" in case and d["cases"][0]["common"] == [f"{AB} hi 3"], case[:200]          # the decoder kept only the impossible `> 3` path; its `0` is base + gear
    s = STAT[stat]
    base = {0: f"({LV} + {s})", 1: f"int({LV} * 0.800000011920929 + {s} * 0.25)", 2: f"int({LV} * 1.2000000476837158 + 2 * {s})", 3: f"int({LV} * 0.4000000059604645 + {s} / 10)"}
    lets = dict(d["lets"])
    lets["_gear"] = GEAR
    cases = [{"value": case.replace("(0 * ", f"(({b} + _gear) * ", 1), "common": [f"{AB} eq {k}"], "variants": []} for k, b in base.items()]
    cases.append({"value": "0", "common": [], "variants": []})
    return _fn(name, cases, lets)


def _flee(name):
    agi = STAT["agi"]
    lets = {
        "_fu": LEARNED.format(486), "_sw": LEARNED.format(1217),
        "_const": (f"({BON.format('bFlee')} + {BON.format('bAvatarFlee')} + ((_fu & 1) ne 0 ? {PARAM.format('Flee', 'FleeUp')} : 0) + ((_sw & 1) ne 0 ? {PARAM.format('Flee', 'ShinobiWay')} : 0)"
                   f" + {SBP.format('Flee')})"),
        "_rate": f"(1 + {BON.format('bFleeRate')} / 100 + {SBP.format('FleeRate')} / 100)",
    }
    base = {0: f"({LV} + {agi})", 1: f"int({LV} * 1.25 + {agi} * 1.75 + 30)", 2: f"int({LV} * 0.5 + {agi} * 0.75 - 15)", 3: f"int({LV} * 1.5 + {agi} * 2 + 75)"}
    cases = [{"value": f"int(_rate * {b}) + _const", "common": [f"{AB} eq {k}"], "variants": []} for k, b in base.items()]
    cases.append({"value": "0", "common": [], "variants": []})
    return _fn(name, cases, lets)


def overrides():
    return {
        "EquipItemData.CalcDef": _defence("EquipItemData.CalcDef", "vit", "bDef", "bDefRate"),
        "EquipItemData.CalcMdef": _defence("EquipItemData.CalcMdef", "int", "bMdef", "bMdefRate"),
        "EquipItemData.CalcFlee": _flee("EquipItemData.CalcFlee"),
    }


# Evidence: decoded structure of the Def / Mdef lets (the masteries and buffers the terms rest on) and the immediates of the hand-read Flee prologue
DECODED_NEEDLES = {
    "EquipItemData.CalcDef": ["SkillMasteryList, 259, out", "SkillMasteryList, 483, out", "SkillMasteryList, 492, out", "MasteryId.DefRate", "MasteryId.Def,", "SkillBufferId.DefRate", "SkillBufferId.Def)", "SkillId.ForceShield",
                              "SkillId.DefUp", "SkillId.KnowledgeOfDefense", "BerserkBuf.GetParam(24)", ", 56, out", ", 46, out"],
    "EquipItemData.CalcMdef": ["SkillMasteryList, 261, out", "SkillMasteryList, 483, out", "SkillMasteryList, 492, out", "MasteryId.MdefRate", "MasteryId.Mdef,", "SkillBufferId.MdefRate", "SkillBufferId.Mdef)", "SkillId.MagicalShield",
                               "SkillId.DefUp", "SkillId.KnowledgeOfDefense", "BerserkBuf.GetParam(26)", ", 56, out", ", 46, out"],
}
FLEE_IMMEDIATES = ["#0x18", "#0xb7", "#0x19", "#0x1e6", "#0x4c1", "#0x13", "#0xc", "#0xd"]          # bFlee, bAvatarFlee, bFleeRate, FleeUp, ShinobiWay, MasteryId.Flee, SkillBufferId.FleeRate, SkillBufferId.Flee


def check():
    import dis_android as D
    for name, needles in DECODED_NEEDLES.items():
        text = json.dumps(_decoded(name), ensure_ascii=False)
        for n in needles:
            assert n in text, f"{name}: `{n}` no longer in the decoded body: review armour_overrides.py"
    by_name = {n: a for a, n in D.names.items()}
    s, e = D.func(by_name["EquipItemData$$CalcFlee"])
    dis = " ".join(f"{i.mnemonic} {i.op_str}" for i in D.md.disasm(D.b[s - D.OFF:e - D.OFF], s))
    for n in FLEE_IMMEDIATES:
        assert re.search(re.escape(n) + r"\b", dis), f"CalcFlee: immediate {n} no longer present: review armour_overrides.py"
    return len(DECODED_NEEDLES) + 1
