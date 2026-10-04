"""Shared damage-engine spec: skills/damage/engine.json
usage (cwd D:\\toram_re): python build_engine.py   (after build_glossary)

 steps          : CalcStep enum (id, name, kind constant/rate/check) in execution order
 get_damage     : the per-step arithmetic of SkillCalcTemplate.GetDamage (hand-verified from the disassembly at RVA 0x21FF504; the
                  loop form cannot be summarised by the symbolic executor, label Code)
 template_terms : what PlayerAttackBase.TemplateAssignment puts into each step (decoded, with conditions) -> glossary ids
 helpers        : glossary ids of every function that feeds a step (base damage, DEF, stability, crit, element, proration, last damage ...)
 status         : glossary ids of the player / mob stat getters the formulas read
"""
import os, re, json
import il2
import dis2 as D2

OUT = r"D:\toram reverse data\skills\damage"
CONSTANT = {"BaseDamage", "SkillConstantDamage", "BufferConstantDamage", "Def", "FirstAttack", "AutoSkillConstant", "LastConstantDamage", "DamageLimit", "MinDamage", "MaxDamage"}
GET_DAMAGE = [
    "d = BaseDamage + SkillConstantDamage + BufferConstantDamage + Def(negative) + FirstAttack ; d = max(d, 0)",
    "d = int(d * CriticalRate)                       # only when the hit is a critical",
    "d = int(d * ElementBonusRate) ; d = int(d * NormalElementDamageResistRate) ; d = int(d * NormalAttackPowerWave)",
    "d = int(d * SkillRate) ; d = int(d * FirstAttackRate) ; d = int(d * AutoSkillRate) ; d = int(d * StableRate)",
    "d = d + AutoSkillConstant",
    "d = int(d * ExpRate)                            # proration",
    "d = int(d * TypeDamageRate) ; d = int(d * LastDamageRate) ; d = int(d * DistanceResistRate)",
    "d = int(d * SpecialLastDamageRate) ; d = int(d * GemDamageRate) ; d = int(d * AbnormalDamageIncreaseRate)",
    "d = max(d, 0) + LastConstantDamage",
    "if guarded: d = int(d * GuardPower / 100)       # GuardPower default 25",
    "d = int(d * NormalAttackTreasureHuntLastDamageRate)",
    "d = min(d, DamageLimit) ; d = max(d, MinDamage) ; d = min(d, MaxDamage) ; d = int(d * SpecificWeaponLastDamage)",
    "if d <= 0: d = 1       # a miss returns 0 before this; a MetalSlime-flag target returns 1",
]
NOTES = ["Several AddRate / AddConstant into the same step are SUMMED; SetRate / SetConstant replace the slot.",
         "An empty Rate slot is x1 and an empty Constant slot is +0. Every Rate step truncates to int (C# (int) cast).",
         "Evidence: calc Reverse/dual_sword/formula.md section 1.2 (hand-verified against the assembly) and skills/damage/VALIDATION.md."]


def main():
    G = json.load(open(os.path.join(OUT, "variables.json"), encoding="utf-8"))["vars"]
    steps = [{"id": k, "name": v, "kind": "constant" if v in CONSTANT else "rate" if v.endswith(("Rate", "Wave", "Damage")) and v not in CONSTANT else "check" if v.endswith("Check") else "other"}
             for k, v in sorted(D2.STEP.items())]
    terms = []
    for im in G["PlayerAttackBase.TemplateAssignment"]["impls"]:
        for ev in im.get("events", []):
            if ev["kind"] == "tpl": terms.append({"term": ev["name"], "value": ev["value"], "when": ev["when"], "lets": {k: x for k, x in im["lets"].items() if k in ev["value"]}})
    helpers = sorted(k for k, e in G.items() if e["kind"] == "engine_fn")
    status = sorted(k for k, e in G.items() if e["kind"] in ("player_stat", "mob_stat"))
    eng = {"version": 1, "steps": steps, "get_damage": GET_DAMAGE, "notes": NOTES, "template_terms": terms, "helpers": helpers, "status": status,
           "evidence": {"GetDamage": f"RVA {il2.method_rva('SkillCalcTemplate', 'GetDamage'):#x} (hand-verified)", "TemplateAssignment": f"RVA {il2.method_rva('PlayerAttackBase', 'TemplateAssignment', 'SkillAttackType attackType'):#x} (decoded: variables.json PlayerAttackBase.TemplateAssignment)"}}
    json.dump(eng, open(os.path.join(OUT, "engine.json"), "w", encoding="utf-8"), ensure_ascii=False, indent=1)
    print(len(steps), "steps;", len(terms), "template terms;", len(helpers), "helpers;", len(status), "status getters")


if __name__ == "__main__":
    main()
