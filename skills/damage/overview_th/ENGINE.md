# Damage engine in one page (ENGINE)

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
