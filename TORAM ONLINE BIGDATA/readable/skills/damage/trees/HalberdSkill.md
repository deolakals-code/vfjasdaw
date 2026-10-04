# ハルバードスキル (`HalberdSkill`)

22 entries. See ../README.md for how to read these blocks.

### เฟลชสเต็ป (FlashStub) · uid 961

<img src="../../icons/sk_961.png" width="40" alt="icon"> 
**Tree:** ハルバードスキル (`HalberdSkill`, tier 1) · **Type:** Attack · **Max Lv:** 10 · **Weapons:** OneHandSword, Halberd · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `FlashStubAction`

> โจมตีศัตรูอย่างแม่นยำด้วยการเคลื่อนไหวที่รวดเร็ว

<details><summary>In-game level notes</summary>

- Lv9: *เพิ่มความเร็วในการใช้

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 1.05 | 1.1 | 1.15 | 1.2 | 1.25 | 1.3 | 1.35 | 1.4 | 1.45 | 1.5 |
| Flat dmg + | 55 | 60 | 65 | 70 | 75 | 80 | 85 | 90 | 95 | 100 |

**Role:** attack (deals damage)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` sets: `(((Lv + (Lv << 2)) + 50))`
- `SkillRate` sets: `(((((Lv * 5) + 100) + gemCart(111[4])) / 100))`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 961

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `skillRate` = `((((Lv * 5) + 100) + gemCart(111[4])) / 100)`
- set `fixAddDamage` = `((Lv + (Lv << 2)) + 50)` → Lv1..10: [55, 60, 65, 70, 75, 80, 85, 90, 95, 100]

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`

**`calcPlayerToMobDamage`** (2 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)`
- template `SetRate[SkillRate]` = `skillRate`
- template `SetConstant[SkillConstantDamage]` = `fixAddDamage`
- info `templates` = `1`

</details>

---

### แคนนอนสเปียร์ (CannonSpear) · uid 962

<img src="../../icons/sk_962.png" width="40" alt="icon"> 
**Tree:** ハルバードスキル (`HalberdSkill`, tier 1) · **Type:** Attack · **Max Lv:** 10 · **Weapons:** Halberd · **Requires:** เฟลชสเต็ป · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `CannonSpearAction`

> โจมตีด้วยการปาหอกวายุ
> ระยะโจมตีจะเพิ่มขึ้นเมื่อเลเวลเพิ่มขึ้น

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 110 | 120 | 130 | 140 | 150 | 160 | 170 | 180 | 190 | 200 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `skillRate[0]` — isFristAttck ne 0 AND skillRate.Length ne 0 OR PlayerAttackBase.checkAbnormalPercent(this, 1, gemCart(112[2]), playerAction) AND isFristAttck ne 0 AND skillRate.Length ne 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 1, gemCart(112[2]), playerAction) AND isFristAttck ne 0 AND skillRate.Length ne 0
- SkillRate × `skillRate[1]` — isFristAttck eq 0 AND skillRate.Length hi 1

**Role:** attack (deals damage) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `((((Lv + (Lv << 2)) << 1) + 100))`
- `SkillRate` multiplies by (adds into): `skillRate[0]` | `skillRate[1]`
- `ExpRate` sets: `(target.ExpDefSkill / 100)` | `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**Mechanics recovered from code**

- **Range** (`range`): `MathUtil.DisplayMeterToDistance(((((Lv - 1) + (((Lv - 1) & 0x8000) >> 15)) >> 1) + 8))`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 962

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (3 paths)

- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `range` = `MathUtil.DisplayMeterToDistance(((((Lv - 1) + (((Lv - 1) & 0x8000) >> 15)) >> 1) + 8))`
- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `rangeRad` = `MathUtil.DisplayMeterToDistance((Lv lo 6 ? 1 : 2))`
- set `skillRate[0]` = `((Lv + 40) / 100)` → Lv1..10: [0.41, 0.42, 0.43, 0.44, 0.45, 0.46, 0.47, 0.48, 0.49, 0.5] — when skillRate.Length ne 0 AND skillRate.Length ne 1 OR skillRate.Length eq 1 AND skillRate.Length ne 0
- set `skillRate[1]` = `((((Lv + (Lv << 2)) << 1) + 150) / 100)` → Lv1..10: [1.6, 1.7, 1.8, 1.9, 2.0, 2.1, 2.2, 2.3, 2.4, 2.5] — when skillRate.Length ne 0 AND skillRate.Length ne 1
- set `fixAddDamage` = `(((Lv + (Lv << 2)) << 1) + 100)` → Lv1..10: [110, 120, 130, 140, 150, 160, 170, 180, 190, 200] — when skillRate.Length ne 0 AND skillRate.Length ne 1
- set `isFristAttck` = `1` = 1 — when skillRate.Length ne 0 AND skillRate.Length ne 1

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`

**`ActionStart`** (1 path)

- set `target` = `target`

**`NextRangeHit`** (2 paths)

- set `isFristAttck` = `0` = 0

**`calcPlayerToMobDamage`** (32 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)`
- template `SetRate[ExpRate]` = `(target.ExpDefSkill / 100)` — when isFristAttck ne 0 AND skillRate.Length ne 0 OR isFristAttck ne 0 AND skillRate.Length eq 0 OR isFristAttck eq 0 AND skillRate.Length hi 1
- template `AddRate[SkillRate]` = `skillRate[0]` — when isFristAttck ne 0 AND skillRate.Length ne 0 OR PlayerAttackBase.checkAbnormalPercent(this, 1, gemCart(112[2]), playerAction) AND isFristAttck ne 0 AND skillRate.Length ne 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 1, gemCart(112[2]), playerAction) AND isFristAttck ne 0 AND skillRate.Length ne 0
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage` — when isFristAttck ne 0 AND skillRate.Length ne 0 OR isFristAttck eq 0 AND skillRate.Length hi 1 OR PlayerAttackBase.checkAbnormalPercent(this, 1, gemCart(112[2]), playerAction) AND isFristAttck ne 0 AND skillRate.Length ne 0
- calls `PlayerAttackBase.SetBufferConstantDamage` = `SetBufferConstantDamage(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 2)` — when isFristAttck ne 0 AND skillRate.Length ne 0 OR isFristAttck eq 0 AND skillRate.Length hi 1 OR PlayerAttackBase.checkAbnormalPercent(this, 1, gemCart(112[2]), playerAction) AND isFristAttck ne 0 AND skillRate.Length ne 0
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(1, gemCart(112[2]), playerAction)` — when PlayerAttackBase.checkAbnormalPercent(this, 1, gemCart(112[2]), playerAction) AND isFristAttck ne 0 AND skillRate.Length ne 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 1, gemCart(112[2]), playerAction) AND isFristAttck ne 0 AND skillRate.Length ne 0
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(1, 0)` — when PlayerAttackBase.checkAbnormalPercent(this, 1, gemCart(112[2]), playerAction) AND isFristAttck ne 0 AND skillRate.Length ne 0
- info `templates` = `1`
- template `AddRate[SkillRate]` = `skillRate[1]` — when isFristAttck eq 0 AND skillRate.Length hi 1
- template `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` — when isFristAttck ne 0 AND skillRate.Length ne 0 OR isFristAttck ne 0 AND skillRate.Length eq 0 OR isFristAttck eq 0 AND skillRate.Length hi 1

</details>

---

### เดดลี่สเปียร์ (DeadlySpear) · uid 963

<img src="../../icons/sk_963.png" width="40" alt="icon"> 
**Tree:** ハルバードスキル (`HalberdSkill`, tier 1) · **Type:** Attack · **Max Lv:** 10 · **Weapons:** OneHandSword, Halberd · **Requires:** เฟลชสเต็ป · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `DeadlySpearAction`

> แทงศัตรูได้แม่นยำและสร้างความเสียหายอย่างรุนแรง
> แม้การใช้สกิลกินเวลานานแต่จะเพิกเฉยต่อการป้องกันได้ในระดับหนึ่ง
> ทำให้มีโอกาสมากที่จะเกิดความเสียหายจากคริติคอลอย่างรุนแรง
> ถ้าสกิลนี้ติดคริติคอล จะลดการ MP ที่ใช้ของสกิลถัดไปลงครึ่งหนึ่ง

<details><summary>In-game level notes</summary>

- Lv9: *พลัง+20
- Lv10: *ลดอัตราคริติคอล

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [mainWeapon == OneHandSword] | 1.1 | 1.1 | 1.15 | 1.2 | 1.25 | 1.3 | 1.35 | 1.4 | 1.45 | 1.5 |
| SkillRate × [mainWeapon != OneHandSword] | 1.3 | 1.3 | 1.35 | 1.4 | 1.45 | 1.5 | 1.55 | 1.6 | 1.65 | 1.7 |
| Flat dmg + | 83 | 86 | 89 | 92 | 95 | 98 | 101 | 104 | 107 | 110 |

**Role:** attack (deals damage) · buff (self)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` sets: `(((Lv + (Lv << 1)) + 80))`
- `SkillRate` sets: `(((((((Lv hi 2 ? Lv : 2) - 2) * 5) + 130) + -20) / 100))`

**Mechanics recovered from code**

- **Extra critical chance (%)** (`criticalPercent`): `50` = 50 _(when mainWeapon == OneHandSword)_; `300` = 300 _(when mainWeapon != OneHandSword)_
- **Resistance value** (`resist`): `((int((Lv * 0.3)) + (int((Lv * 0.3)) << 2)) + 10)` → Lv1..10 [10, 10, 10, 15, 15, 15, 20, 20, 20, 25]
- **Cast time modifier** (`CastTime`): `(int(((11 - Lv) * 0.3)) * 0.5)` → Lv1..10 [1.5, 1.0, 1.0, 1.0, 0.5, 0.5, 0.5, 0.0, 0.0, 0.0]

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 963

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (2 paths)

- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `fixAddDamage` = `((Lv + (Lv << 1)) + 80)` → Lv1..10: [83, 86, 89, 92, 95, 98, 101, 104, 107, 110]
- set `criticalPercent` = `50` = 50 — when mainWeapon == OneHandSword
- set `skillRate` = `((((((Lv hi 2 ? Lv : 2) - 2) * 5) + 130) + -20) / 100)` → Lv1..10: [1.1, 1.1, 1.15, 1.2, 1.25, 1.3, 1.35, 1.4, 1.45, 1.5] — when mainWeapon == OneHandSword
- set `resist` = `((int((Lv * 0.3)) + (int((Lv * 0.3)) << 2)) + 10)` → Lv1..10: [10, 10, 10, 15, 15, 15, 20, 20, 20, 25]
- set `CastTime` = `(int(((11 - Lv) * 0.3)) * 0.5)` → Lv1..10: [1.5, 1.0, 1.0, 1.0, 0.5, 0.5, 0.5, 0.0, 0.0, 0.0]
- set `criticalPercent` = `300` = 300 — when mainWeapon != OneHandSword
- set `skillRate` = `(((((Lv hi 2 ? Lv : 2) - 2) * 5) + 130) / 100)` → Lv1..10: [1.3, 1.3, 1.35, 1.4, 1.45, 1.5, 1.55, 1.6, 1.65, 1.7] — when mainWeapon != OneHandSword

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`calcPlayerToMobDamage`** (2 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)`
- set `isCritical` = `(PlayerAttackBase.checkCriticalPercent(this, (((criticalPercent * status.Critical) // 100) + status.Critical), mobAction) & 1)`
- template `SetRate[SkillRate]` = `skillRate`
- template `SetConstant[SkillConstantDamage]` = `fixAddDamage`
- info `templates` = `1`

**`ActionHit`** (4 paths)

- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(963, Lv, Id)` — when MobaMode eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND isCritical ne 0

</details>

**Buffs**

**Buff `DeadlySpearBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).

<details><summary>Effect applied in `PlayerAttackBase$$CalcCostMp` (300 guarded paths, truncated)</summary>

- when `(SkillBufferManager.TryGetBuf<object>(?blr, 105, stkp(-56), meta(0x399f9d8, Method$SkillBufferManager.TryGetBuf<MagicImpactBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `300`
  - set `CostMpType` = `6`
  - calls `InflexibilityBuf$$CheckMpHalving`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `MultipleHuntBuf$$CheckMode`, `virtual PlayerAttackBase.get_ActionID`, `AbnormalStateManager$$Contains`, `AshuraAuraBuf$$CheckMpIncrease`
- when `(SkillBufferManager.TryGetBuf<object>(?blr, 105, stkp(-56), meta(0x399f9d8, Method$SkillBufferManager.TryGetBuf<MagicImpactBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `200`
  - set `CostMpType` = `2`
  - calls `InflexibilityBuf$$CheckMpHalving`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `MultipleHuntBuf$$CheckMode`, `virtual PlayerAttackBase.get_ActionID`, `AbnormalStateManager$$Contains`, `AshuraAuraBuf$$CheckMpIncrease`
- when `(SkillBufferManager.TryGetBuf<object>(?blr, 105, stkp(-56), meta(0x399f9d8, Method$SkillBufferManager.TryGetBuf<MagicImpactBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `200`
  - set `CostMpType` = `2`
  - calls `InflexibilityBuf$$CheckMpHalving`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `MultipleHuntBuf$$CheckMode`, `virtual PlayerAttackBase.get_ActionID`, `AbnormalStateManager$$Contains`, `AshuraAuraBuf$$CheckMpIncrease`
- when `(SkillBufferManager.TryGetBuf<object>(?blr, 105, stkp(-56), meta(0x399f9d8, Method$SkillBufferManager.TryGetBuf<MagicImpactBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `200`
  - set `CostMpType` = `2`
  - calls `InflexibilityBuf$$CheckMpHalving`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `MultipleHuntBuf$$CheckMode`, `virtual PlayerAttackBase.get_ActionID`, `AbnormalStateManager$$Contains`
- when `(SkillBufferManager.TryGetBuf<object>(?blr, 105, stkp(-56), meta(0x399f9d8, Method$SkillBufferManager.TryGetBuf<MagicImpactBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `200`
  - set `CostMpType` = `4`
  - calls `InflexibilityBuf$$CheckMpHalving`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `MultipleHuntBuf$$CheckMode`, `virtual PlayerAttackBase.get_ActionID`, `AbnormalStateManager$$Contains`, `AshuraAuraBuf$$CheckMpIncrease`
- when `(SkillBufferManager.TryGetBuf<object>(?blr, 105, stkp(-56), meta(0x399f9d8, Method$SkillBufferManager.TryGetBuf<MagicImpactBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `100`
  - set `CostMpType` = `0`
  - calls `InflexibilityBuf$$CheckMpHalving`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `MultipleHuntBuf$$CheckMode`, `virtual PlayerAttackBase.get_ActionID`, `AbnormalStateManager$$Contains`, `AshuraAuraBuf$$CheckMpIncrease`
- when `(SkillBufferManager.TryGetBuf<object>(?blr, 105, stkp(-56), meta(0x399f9d8, Method$SkillBufferManager.TryGetBuf<MagicImpactBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `100`
  - set `CostMpType` = `0`
  - calls `InflexibilityBuf$$CheckMpHalving`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `MultipleHuntBuf$$CheckMode`, `virtual PlayerAttackBase.get_ActionID`, `AbnormalStateManager$$Contains`, `AshuraAuraBuf$$CheckMpIncrease`
- when `(SkillBufferManager.TryGetBuf<object>(?blr, 105, stkp(-56), meta(0x399f9d8, Method$SkillBufferManager.TryGetBuf<MagicImpactBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `100`
  - set `CostMpType` = `0`
  - calls `InflexibilityBuf$$CheckMpHalving`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `MultipleHuntBuf$$CheckMode`, `virtual PlayerAttackBase.get_ActionID`, `AbnormalStateManager$$Contains`

</details>

<details><summary>Effect applied in `PlayerAttackBase$$RemoveAfterSkillBuf` (300 guarded paths, truncated)</summary>

- when `TryGetValue.out2() ne 0` AND `PlayerAttackBase.get_ActionID() ne 517`
  - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 1129, 0, ?x3)`
  - set `_motionSpeed` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `appliedQuicklyMotionSpeedValue` = `255`
  - set `appliedQuicklyType` = `(((appliedQuicklyType | 2) | 16) | 8)`
  - calls `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$ContainsNotApplicableSkill`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `virtual PlayerAttackBase.get_ActionID`
- when `TryGetValue.out2() ne 0` AND `PlayerAttackBase.get_ActionID() ne 517`
  - returns `SkillBufferManager.TryGetBuf(?blr, 1129, stkp(-88), 0)`
  - set `_motionSpeed` = `((SkillActionBase.get_MotionSpeed(this, 0, ?mi, ?x3) - CharacterActionManagerBase.set_DefaultMoveSpeed()) gt 50 ? (SkillActionBase.get_MotionSpeed(this, 0, ?mi, ?x3) - CharacterActionManagerBase.set_DefaultMoveSpeed()) : 50)`
  - set `appliedQuicklyMotionSpeedValue` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `appliedQuicklyType` = `((appliedQuicklyType | 2) | 16)`
  - calls `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$ContainsNotApplicableSkill`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `virtual PlayerAttackBase.get_ActionID`
- when `TryGetValue.out2() ne 0` AND `PlayerAttackBase.get_ActionID() ne 517`
  - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 1129, 0, ?x3)`
  - set `_motionSpeed` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `appliedQuicklyMotionSpeedValue` = `255`
  - set `appliedQuicklyType` = `(((appliedQuicklyType | 2) | 16) | 8)`
  - calls `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$ContainsNotApplicableSkill`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `virtual PlayerAttackBase.get_ActionID`
- when `TryGetValue.out2() ne 0` AND `PlayerAttackBase.get_ActionID() ne 517`
  - returns `SkillBufferManager.TryGetBuf(?blr, 1129, stkp(-88), 0)`
  - set `_motionSpeed` = `((SkillActionBase.get_MotionSpeed(this, 0, ?mi, ?x3) - CharacterActionManagerBase.set_DefaultMoveSpeed()) gt 50 ? (SkillActionBase.get_MotionSpeed(this, 0, ?mi, ?x3) - CharacterActionManagerBase.set_DefaultMoveSpeed()) : 50)`
  - set `appliedQuicklyMotionSpeedValue` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `appliedQuicklyType` = `((appliedQuicklyType | 2) | 16)`
  - calls `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$ContainsNotApplicableSkill`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `virtual PlayerAttackBase.get_ActionID`
- when `TryGetValue.out2() ne 0` AND `PlayerAttackBase.get_ActionID() ne 517`
  - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 1129, 0, ?x3)`
  - set `_motionSpeed` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `appliedQuicklyMotionSpeedValue` = `255`
  - set `appliedQuicklyType` = `(((appliedQuicklyType | 2) | 16) | 8)`
  - calls `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$ContainsNotApplicableSkill`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `virtual PlayerAttackBase.get_ActionID`
- when `TryGetValue.out2() ne 0` AND `PlayerAttackBase.get_ActionID() ne 517`
  - returns `SkillBufferManager.TryGetBuf(?blr, 1129, stkp(-88), 0)`
  - set `_motionSpeed` = `((SkillActionBase.get_MotionSpeed(this, 0, ?mi, ?x3) - CharacterActionManagerBase.set_DefaultMoveSpeed()) gt 50 ? (SkillActionBase.get_MotionSpeed(this, 0, ?mi, ?x3) - CharacterActionManagerBase.set_DefaultMoveSpeed()) : 50)`
  - set `appliedQuicklyMotionSpeedValue` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `appliedQuicklyType` = `((appliedQuicklyType | 2) | 16)`
  - calls `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$ContainsNotApplicableSkill`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `virtual PlayerAttackBase.get_ActionID`
- when `TryGetValue.out2() ne 0` AND `PlayerAttackBase.get_ActionID() ne 517`
  - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 1129, 0, ?x3)`
  - set `_motionSpeed` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `appliedQuicklyMotionSpeedValue` = `255`
  - set `appliedQuicklyType` = `(((appliedQuicklyType | 2) | 16) | 8)`
  - calls `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$ContainsNotApplicableSkill`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `virtual PlayerAttackBase.get_ActionID`
- when `TryGetValue.out2() ne 0` AND `PlayerAttackBase.get_ActionID() ne 517`
  - returns `SkillBufferManager.TryGetBuf(?blr, 1129, stkp(-88), 0)`
  - set `_motionSpeed` = `((SkillActionBase.get_MotionSpeed(this, 0, ?mi, ?x3) - CharacterActionManagerBase.set_DefaultMoveSpeed()) gt 50 ? (SkillActionBase.get_MotionSpeed(this, 0, ?mi, ?x3) - CharacterActionManagerBase.set_DefaultMoveSpeed()) : 50)`
  - set `appliedQuicklyMotionSpeedValue` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `appliedQuicklyType` = `((appliedQuicklyType | 2) | 16)`
  - calls `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$ContainsNotApplicableSkill`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `SkillBufferManager$$RemoveBuffer`, `virtual PlayerAttackBase.get_ActionID`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `MobaPlayerActionManager$$ReceiveAttack (GetSkillLv)`
- `PlayerAttackBase$$CalcCostMp (ContainsBuffer)`
- `PlayerAttackBase$$RemoveAfterSkillBuf (ContainsBuffer)`

---

### ฮัลเบิร์ทมาสเตอรี่ (HalberdMastery) · uid 964

<img src="../../icons/sk_964.png" width="40" alt="icon"> 
**Tree:** ハルバードスキル (`HalberdSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 10 · **Weapons:** Halberd · **Flags:** StarGem · **Client class:** `HalberdMastery` (passive mastery)

> ใช้หอกวายุได้ชำนาญขึ้น
> เพิ่มพลังโจมตีเมื่อใช้หอกวายุ

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| EqAtkRate | 3 | 6 | 9 | 12 | 15 | 18 | 21 | 24 | 27 | 30 |
| AtkRate | 1 | 1 | 2 | 2 | 2 | 2 | 2 | 3 | 3 | 3 |


---

### ควิกออร่า (QuickAura) · uid 965

<img src="../../icons/sk_965.png" width="40" alt="icon"> 
**Tree:** ハルバードスキル (`HalberdSkill`, tier 1) · **Type:** Buffer · **Max Lv:** 10 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem · **Client class:** `QuickAuraAction`

> เพิ่มความเร็วของตัวเองด้วยพลังใจ
> ใช้ HP แทน MP ในใช้สกิล
> ASPD จะเพิ่มขึ้นชั่วขณะ

<details><summary>In-game level notes</summary>

- Lv9: *HP ที่ใช้-5% *ระยะเวลาแสดงผล+120 วิ

</details>

**Role:** buff (party / others)

This action never changes monster proration: ExpType None: no proration slot.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 965

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `time` = `(mainWeapon == Halberd ? 300 : 180)`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (1 path)

- calls `SkillBufferManager.AddBuffer` = `AddBuffer(965, Lv, time)`

**`OnInheritance`** (1 path)

- set `IsInheritance` = `1` = 1

</details>

---

### ดราก้อนเทล (DragonTail) · uid 966

<img src="../../icons/sk_966.png" width="40" alt="icon"> 
**Tree:** ハルバードスキル (`HalberdSkill`, tier 2) · **Type:** Attack · **Max Lv:** 30 · **Weapons:** Halberd · **Requires:** แคนนอนสเปียร์ · **Flags:** MercenaryCanUseSkill · **Client class:** `DragonTailAction`

> ควงหอกวายุกวาดล้างศัตรู
> ลดความเสียหายที่ได้รับ (2 ครั้ง) ระหว่างใช้สกิล
> มีโอกาสทำให้เป้าหมาย[ล้มคว่ำ]
> สร้างความเสียหายให้บอสไม่ได้

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.73 | 0.76 | 0.79 | 0.82 | 0.85 | 0.88 | 0.91 | 0.94 | 0.97 | 1 |
| SkillRate × | 2.2 | 2.4 | 2.6 | 2.8 | 3 | 3.2 | 3.4 | 3.6 | 3.8 | 4 |
| Flat dmg + | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |
| Flat dmg + | 65 | 80 | 95 | 110 | 125 | 140 | 155 | 170 | 185 | 200 |

**Role:** attack (deals damage) · buff (self) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `((1) eq 0 ? ((((Lv << 4) - Lv) + 50)) : (100))`
- `SkillRate` multiplies by (adds into): `((1) eq 0 ? (((((Lv * 20) + 200) + gemCart(212[4])) / 100)) : ((((Lv + (Lv << 1)) + 70) / 100)))`
- `ExpRate` sets: `(target.ExpDefSkill / 100)` | `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**Mechanics recovered from code**

- **Second-part multiplier** (`secondSkillRate`): `((((Lv * 20) + 200) + gemCart(212[4])) / 100)`
- **Second-part flat damage** (`secondFixAddDamage`): `(((Lv << 4) - Lv) + 50)` → Lv1..10 [65, 80, 95, 110, 125, 140, 155, 170, 185, 200]
- **Tumble chance (%)** (`tumblePercent`): `((Lv + (Lv << 2)) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 966

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(100)`
- set `fristRadius` = `MathUtil.DisplayMeterToDistance((Lv lo 6 ? 1.5 : 2))`
- set `secondRadius` = `MathUtil.DisplayMeterToDistance(((((Lv - 1) // 3) * 0.5) + 2.5))`
- set `secondSkillRate` = `((((Lv * 20) + 200) + gemCart(212[4])) / 100)`
- set `fristSkillRate` = `(((Lv + (Lv << 1)) + 70) / 100)` → Lv1..10: [0.73, 0.76, 0.79, 0.82, 0.85, 0.88, 0.91, 0.94, 0.97, 1.0]
- set `fristFixAddDamage` = `100` = 100
- set `secondFixAddDamage` = `(((Lv << 4) - Lv) + 50)` → Lv1..10: [65, 80, 95, 110, 125, 140, 155, 170, 185, 200]
- set `tumblePercent` = `((Lv + (Lv << 2)) << 1)` → Lv1..10: [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]
- set `isFristAttck` = `1` = 1

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`

**`ActionStart`** (2 paths)

- set `secondBufFunc` = `System.Delegate.Combine(secondBufFunc, new System.Action)` — when UnityEngine.Object.op_Inequality(actarAction)
- calls `DragonTailBuf..ctor` = `.ctor(Lv, 1)` — when UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new DragonTailBuf, Id)` — when UnityEngine.Object.op_Inequality(actarAction)

**`NextRangeHit`** (2 paths)

- set `isFristAttck` = `0` = 0

**`calcPlayerToMobDamage`** (24 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)`
- template `SetRate[ExpRate]` = `(target.ExpDefSkill / 100)`
- template `AddRate[SkillRate]` = `(isFristAttck eq 0 ? secondSkillRate : fristSkillRate)`
- template `AddConstant[SkillConstantDamage]` = `(isFristAttck eq 0 ? secondFixAddDamage : fristFixAddDamage)`
- calls `PlayerAttackBase.SetBufferConstantDamage` = `SetBufferConstantDamage(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 2)`
- info `templates` = `1`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(2, tumblePercent, playerAction)` — when !MobActionManagerBase.CheckMultiFlag(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 2, tumblePercent, playerAction) AND isFristAttck eq 0 OR !MobActionManagerBase.CheckMultiFlag(mobAction) AND !PlayerAttackBase.checkAbnormalPercent(this, 2, tumblePercent, playerAction) AND isFristAttck eq 0
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(2, 0)` — when !MobActionManagerBase.CheckMultiFlag(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 2, tumblePercent, playerAction) AND isFristAttck eq 0
- template `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**`.<>c__DisplayClass30_0::<ActionStart>b__0`** (1 path)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(CharacterActionManagerBase.get_IsLocalDead())`

**`.<>c__DisplayClass30_0::<ActionStart>b__1`** (1 path)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(CharacterActionManagerBase.get_IsLocalDead())`
- calls `DragonTailBuf..ctor` = `.ctor([<>c__DisplayClass30_0.<>4__this+0x14], 2)`
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new DragonTailBuf, [<>c__DisplayClass30_0.<>4__this+0x10])`

</details>

**Buffs**

**Buff `DragonTailBuf`**
- `MobLastDamageRateUnique` = `0` _(when BuffEffectActive eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MobLastDamageRateUnique | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |

- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `IsDamageCancel` = `1` = 1 when count eq 1 OR count eq 2 AND count ne 1 OR count ne 1 AND count ne 2
  - `damageCut` = `(((Lv << 2) + lv) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100] when count eq 2 AND count ne 1
  - `damageCut` = `50` = 50 when count eq 1
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:DragonTailBuf$$.ctor<-DragonTailAction$$ActionStart` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

---

### วานิชเรย์ (PunishRay) · uid 967

<img src="../../icons/sk_967.png" width="40" alt="icon"> 
**Tree:** ハルバードスキル (`HalberdSkill`, tier 2) · **Type:** Attack · **Max Lv:** 30 · **Weapons:** OneHandSword, Halberd · **Requires:** เดดลี่สเปียร์ · **Flags:** MercenaryCanUseSkill · **Client class:** `PunishRayAction`

> ใช้หอกวายุร่ายเวทแทนไม้เท้า
> พลังโจมตีเวทมนตร์ที่ศัตรูได้รับจะขึ้นอยู่กับ ATK
> อัตราคริติคอลของ 3 สกิลถัดไปจะเพิ่มขึ้น

<details><summary>In-game level notes</summary>

- Lv9: *พลัง×2

</details>

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((mainWeapon == Halberd ? (((Lv * Lv) + 25) + ((Lv * Lv) + 25)) : ((Lv * Lv) + 25)) / 100))`
- SkillRate × `((((status.Int lt 0 ? (status.Int + 3) : status.Int) >> 2) / 100))`
- Flat dmg + `fixAddDamage`

**Role:** attack (deals damage) · buff (self)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `fixAddDamage`
- `BaseDamage` sets: `PlayerAttackBase.calcBaseDamage(playerAction, mobAction, 1, [skillMaster+0x24], (PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) & 1))`
- `SkillRate` multiplies by (adds into): `(((mainWeapon == Halberd ? (((Lv * Lv) + 25) + ((Lv * Lv) + 25)) : ((Lv * Lv) + 25)) / 100))` | `((((status.Int lt 0 ? (status.Int + 3) : status.Int) >> 2) / 100))`

**Mechanics recovered from code**

- **Alternate skill multiplier (%)** (`bonusSkillRate`): `(((status.Int lt 0 ? (status.Int + 3) : status.Int) >> 2) / 100)`
- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`; `-1` = -1 _(when (isPlayer & 1) ne 0)_

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 967

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `Element` = `7` = 7
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`
- set `skillRate` = `((mainWeapon == Halberd ? (((Lv * Lv) + 25) + ((Lv * Lv) + 25)) : ((Lv * Lv) + 25)) / 100)`
- set `bonusSkillRate` = `(((status.Int lt 0 ? (status.Int + 3) : status.Int) >> 2) / 100)`
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`ActionStart`** (8 paths)

- set `AtkParam` = `status.Atk`
- set `isHit` = `1` = 1
- calls `PunishRayBuf..ctor` = `.ctor(Lv, 15)` — when PlayerAttackBase.CheckSkillParamFlag(this, 1024) AND isHit ne 0
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new PunishRayBuf, Id)` — when PlayerAttackBase.CheckSkillParamFlag(this, 1024) AND isHit ne 0

**`ActionSkillEvent`** (6 paths)

- calls `PunishRayBuf..ctor` = `.ctor(Lv, EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator))` — when IsInstanceOf(actarAction, MobaPlayerActionManager) ne 1 AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND isHit ne 0 AND param eq 100
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new PunishRayBuf, Id)` — when IsInstanceOf(actarAction, MobaPlayerActionManager) ne 1 AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND isHit ne 0 AND param eq 100

**`calcPlayerToMobDamage`** (2 paths)

- template `SetConstant[BaseDamage]` = `PlayerAttackBase.calcBaseDamage(playerAction, mobAction, 1, [skillMaster+0x24], (PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) & 1))`
- template `AddRate[SkillRate]` = `skillRate`
- template `AddRate[SkillRate]` = `bonusSkillRate`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- info `templates` = `1`

**`InitializeEnchantedSpell`** (2 paths)

- set `CastTime` = `-1` = -1 — when (isPlayer & 1) ne 0

</details>

**Buffs**

**Buff `PunishRayBuf`**
- Buff hook methods: `BusterLanceReset`
- `CrtUp` = `critical[max(Count)]` _(when BuffEffectActive ne 0; max(Count) lo critical.Length)_
- Buff fields set in the constructor (all recovered):
  - `temporaryCount` = `-1` = -1
- Hook `BusterLanceReset`: `Count`=-1
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:PunishRayBuf$$.ctor<-PunishRayAction$$ActionSkillEvent` (no direct constructor call in the skill's own code).
- Buff hook methods: `Next`, `NextSkip`, `Prev`, `PrevSkip`, `get_Count`, `get_Max`, `get_Peak`, `set_Count`, `set_Max`
- `Count` = `(0)`
- Buff fields set in the constructor (all recovered):
  - `Count` = `0`
  - `Max` = `max`
- Hook `set_Count`: `Count`=value
- Hook `set_Max`: `Max`=value
- Hook `Next`: `Count`=System.Math.Min((Count + 1), Max)
- Hook `NextSkip`: `Count`=System.Math.Min((Count + count), Max)
- Hook `Prev`: `Count`=System.Math.Max((Count - 1), 0)
- Hook `PrevSkip`: `Count`=System.Math.Max((Count - count), 0)

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `MobaPlayerActionManager$$ReceiveAttack (GetSkillLv)`

---

### วอร์ครายสทรักเกิ้ล (AdversityRoar) · uid 968

<img src="../../icons/sk_968.png" width="40" alt="icon"> 
**Tree:** ハルバードスキル (`HalberdSkill`, tier 2) · **Type:** Buffer · **Max Lv:** 30 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ควิกออร่า · **Client class:** `AdversityRoarAction`

> ตะโกนขอชีวิตในตอนตกภาวะที่นั่งลำบาก
> ฟื้นฟู MP ได้เล็กน้อย
> ยิ่งปริมาณ HP ที่มีน้อยเท่าไหร่ปริมาณการฟื้นฟูจะยิ่งเพิ่มมากขึ้น

<details><summary>In-game level notes</summary>

- Lv9: *เวลาชาร์จน้อยลง

</details>

**Role:** utility / system action

This action never changes monster proration: ExpType None: no proration slot.

**Mechanics recovered from code**

- **MP recovered** (`mpRecovery`): `((120 + (Lv << 1)) + (Lv << 2))` → Lv1..10 [126, 132, 138, 144, 150, 156, 162, 168, 174, 180] _(when PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon == Halberd OR PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon != Halberd)_; `(((Lv * 10) + ((120 + (Lv << 1)) + (Lv << 2))) + 20)` → Lv1..10 [156, 172, 188, 204, 220, 236, 252, 268, 284, 300] _(when PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon == Halberd OR PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon != Halberd)_; `(120 + (Lv << 1))` → Lv1..10 [122, 124, 126, 128, 130, 132, 134, 136, 138, 140] _(when PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon == Halberd OR PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon != Halberd)_
- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, ((6 - frintp((Lv / 3))) + -1), PlayerActionManagerBase.get_PlayerStatus())` _(when PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon == Halberd OR PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon == Halberd OR PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon == Halberd)_; `PlayerAttackBase.CalcCastTime(this, (6 - frintp((Lv / 3))), PlayerActionManagerBase.get_PlayerStatus())` _(when PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon != Halberd OR PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon != Halberd OR PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon != Halberd)_

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 968

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (16 paths)

- set `ActionRange` = `-1` = -1
- set `mpRecovery` = `((120 + (Lv << 1)) + (Lv << 2))` → Lv1..10: [126, 132, 138, 144, 150, 156, 162, 168, 174, 180] — when PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon == Halberd OR PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon != Halberd
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, ((6 - frintp((Lv / 3))) + -1), PlayerActionManagerBase.get_PlayerStatus())` — when PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon == Halberd OR PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon == Halberd OR PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon == Halberd
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, (6 - frintp((Lv / 3))), PlayerActionManagerBase.get_PlayerStatus())` — when PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon != Halberd OR PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon != Halberd OR PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon != Halberd
- set `mpRecovery` = `(((Lv * 10) + ((120 + (Lv << 1)) + (Lv << 2))) + 20)` → Lv1..10: [156, 172, 188, 204, 220, 236, 252, 268, 284, 300] — when PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon == Halberd OR PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon != Halberd
- set `mpRecovery` = `(120 + (Lv << 1))` → Lv1..10: [122, 124, 126, 128, 130, 132, 134, 136, 138, 140] — when PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon == Halberd OR PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon != Halberd
- set `mpRecovery` = `(((Lv * 10) + (120 + (Lv << 1))) + 20)` → Lv1..10: [152, 164, 176, 188, 200, 212, 224, 236, 248, 260] — when PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon == Halberd OR PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 85 AND mainWeapon != Halberd
- set `mpRecovery` = `(120 + (Lv << 2))` → Lv1..10: [124, 128, 132, 136, 140, 144, 148, 152, 156, 160] — when PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 85 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 70 AND mainWeapon == Halberd OR PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 85 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 70 AND mainWeapon != Halberd
- set `mpRecovery` = `(((Lv * 10) + (120 + (Lv << 2))) + 20)` → Lv1..10: [154, 168, 182, 196, 210, 224, 238, 252, 266, 280] — when PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 85 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 70 AND mainWeapon == Halberd OR PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 85 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 70 AND mainWeapon != Halberd
- set `mpRecovery` = `120` = 120 — when PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 85 AND mainWeapon == Halberd OR PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 55 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 85 AND mainWeapon != Halberd
- set `mpRecovery` = `(((Lv * 10) + 120) + 20)` → Lv1..10: [150, 160, 170, 180, 190, 200, 210, 220, 230, 240] — when PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 85 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 55 AND mainWeapon == Halberd OR PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 70 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) hi 85 AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 55 AND mainWeapon != Halberd

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`OnInheritance`** (1 path)

- set `IsInheritance` = `1` = 1

</details>

---

### ไดฟ์อิมแพ็ค (DiveImpact) · uid 969

<img src="../../icons/sk_969.png" width="40" alt="icon"> 
**Tree:** ハルバードスキル (`HalberdSkill`, tier 3) · **Type:** Object · **Max Lv:** 70 · **Weapons:** Halberd · **Requires:** ดราก้อนเทล · **Flags:** MercenaryCanUseSkill · **Client class:** `DiveImpactAction`

> ใช้หอกกระแทกผืนดินให้แตกเป็นผุยผง
> หลังใช้สกิลจะทำให้จุดที่โจมตีเกิดการระเบิด เพิ่มค่าความเสียหาย
> และมีโอกาสทำให้เป้าหมายติด "ตาพร่า" 
> ตัวเองจะติดไร้พ่ายระหว่างใช้สกิล

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + [isEquipConvergenceGemCart ne 0 AND isFirstAttck ne 0 OR isEquipConvergenceGemCart eq 0 AND isFirstAttck ne 0] | 220 | 240 | 260 | 280 | 300 | 320 | 340 | 360 | 380 | 400 |
| Flat dmg + [isEquipConvergenceGemCart ne 0 AND isFirstAttck eq 0 OR isEquipConvergenceGemCart eq 0 AND isFirstAttck eq 0 OR PlayerAttackBase.checkAbnormalPercent(this, 33, flashPercent, playerAction) AND isEquipConvergenceGemCart ne 0 AND isFirstAttck eq 0] | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((1) eq 0 ? (((((Lv * 40) + status.Int) + 200) / 100)) : ((((status.Str / 2.5) + ((Lv * 20) + 200)) / 100)))`
- SkillRate × `((1) eq 0 ? (((((Lv * 40) + status.Int) + 200) / 100)) : ((((status.Str / 2.5) + ((Lv * 20) + 200)) / 100)))`

**Role:** attack (deals damage) · applies status ailment · placed object / trap / summon

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv * 20) + 200))` | `0`
- `SkillRate` multiplies by (adds into): `((1) eq 0 ? (((((Lv * 40) + status.Int) + 200) / 100)) : ((((status.Str / 2.5) + ((Lv * 20) + 200)) / 100)))`
- `ExpRate` sets: `(target.ExpDefSkill / 100)` | `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**Mechanics recovered from code**

- **Second-part multiplier** (`secondSkillRate`): `((((Lv * 40) + status.Int) + 200) / 100)`
- **Loop / hit-repeat count** (`LoopParam`): `motionSpeed`; `int((((SkillActionBase.get_MotionSpeed(this) / 100) + (SkillActionBase.get_MotionSpeed(this) / 100)) * 10))`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 969

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `fristSkillRate` = `(((status.Str / 2.5) + ((Lv * 20) + 200)) / 100)`
- set `secondSkillRate` = `((((Lv * 40) + status.Int) + 200) / 100)`
- set `fixAddDamage` = `((Lv * 20) + 200)` → Lv1..10: [220, 240, 260, 280, 300, 320, 340, 360, 380, 400]
- set `fristRadius` = `MathUtil.DisplayMeterToDistance(int(((Lv * 0.25) + 2.5)))`
- set `secondRadius` = `MathUtil.DisplayMeterToDistance(int(((Lv * 0.25) + 4.5)))`
- set `flashPercent` = `((Lv + (Lv << 2)) << 1)` → Lv1..10: [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]
- set `isFirstAttck` = `1` = 1
- set `gemCartBuf` = `GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 306)`
- set `isEquipConvergenceGemCart` = `(GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 306) ne 0 ? 1 : 0)`
- set `SkillIndividualFlag` = `(GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 306) ne 0 ? 1 : 0)`

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `LoopParam` = `motionSpeed`
- set `targetPos` = `castTime`
- set `ActionRange` = `-1` = -1

**`OtherPlayerAttackStartReceive`** (2 paths)

- set `isEquipConvergenceGemCart` = `(SkillIndividualFlag ne 0 ? 1 : 0)`

**`ActionStart`** (6 paths)

- set `LoopParam` = `int((((SkillActionBase.get_MotionSpeed(this) / 100) + (SkillActionBase.get_MotionSpeed(this) / 100)) * 10))`
- set `placePosition` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x` — when !UnityEngine.Object.op_Inequality(actarAction) AND isEquipConvergenceGemCart ne 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isEquipConvergenceGemCart ne 0 OR PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isEquipConvergenceGemCart ne 0
- set `placePosition.y` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y` — when !UnityEngine.Object.op_Inequality(actarAction) AND isEquipConvergenceGemCart ne 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isEquipConvergenceGemCart ne 0 OR PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isEquipConvergenceGemCart ne 0
- set `placePosition.z` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z` — when !UnityEngine.Object.op_Inequality(actarAction) AND isEquipConvergenceGemCart ne 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isEquipConvergenceGemCart ne 0 OR PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isEquipConvergenceGemCart ne 0
- set `targetManager` = `UnityEngine.GameObject.GetComponent<CharacterActionManagerBase>(target)` — when !UnityEngine.Object.op_Inequality(actarAction) AND isEquipConvergenceGemCart ne 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isEquipConvergenceGemCart ne 0 OR PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isEquipConvergenceGemCart ne 0
- set `placePosition` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x` — when !UnityEngine.Object.op_Inequality(actarAction) AND isEquipConvergenceGemCart eq 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isEquipConvergenceGemCart eq 0 OR PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isEquipConvergenceGemCart eq 0
- set `placePosition.y` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y` — when !UnityEngine.Object.op_Inequality(actarAction) AND isEquipConvergenceGemCart eq 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isEquipConvergenceGemCart eq 0 OR PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isEquipConvergenceGemCart eq 0
- set `placePosition.z` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z` — when !UnityEngine.Object.op_Inequality(actarAction) AND isEquipConvergenceGemCart eq 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isEquipConvergenceGemCart eq 0 OR PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isEquipConvergenceGemCart eq 0

**`calcPlayerToMobDamage`** (40 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)`
- template `SetRate[ExpRate]` = `(target.ExpDefSkill / 100)` — when isEquipConvergenceGemCart ne 0 AND isFirstAttck ne 0 OR isEquipConvergenceGemCart eq 0 AND isFirstAttck ne 0 OR isEquipConvergenceGemCart ne 0 AND isFirstAttck eq 0
- template `AddRate[SkillRate]` = `(isFirstAttck eq 0 ? secondSkillRate : fristSkillRate)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage` — when isEquipConvergenceGemCart ne 0 AND isFirstAttck ne 0 OR isEquipConvergenceGemCart eq 0 AND isFirstAttck ne 0
- calls `PlayerAttackBase.SetBufferConstantDamage` = `SetBufferConstantDamage(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 2)` — when isEquipConvergenceGemCart ne 0 AND isFirstAttck ne 0 OR isEquipConvergenceGemCart eq 0 AND isFirstAttck ne 0 OR isEquipConvergenceGemCart ne 0 AND isFirstAttck eq 0
- info `templates` = `1`
- template `AddConstant[SkillConstantDamage]` = `0` — when isEquipConvergenceGemCart ne 0 AND isFirstAttck eq 0 OR isEquipConvergenceGemCart eq 0 AND isFirstAttck eq 0 OR PlayerAttackBase.checkAbnormalPercent(this, 33, flashPercent, playerAction) AND isEquipConvergenceGemCart ne 0 AND isFirstAttck eq 0
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(33, flashPercent, playerAction)` — when PlayerAttackBase.checkAbnormalPercent(this, 33, flashPercent, playerAction) AND isEquipConvergenceGemCart ne 0 AND isFirstAttck eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 33, flashPercent, playerAction) AND isEquipConvergenceGemCart ne 0 AND isFirstAttck eq 0 OR PlayerAttackBase.checkAbnormalPercent(this, 33, flashPercent, playerAction) AND isEquipConvergenceGemCart eq 0 AND isFirstAttck eq 0
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(33, 0)` — when PlayerAttackBase.checkAbnormalPercent(this, 33, flashPercent, playerAction) AND isEquipConvergenceGemCart ne 0 AND isFirstAttck eq 0 OR PlayerAttackBase.checkAbnormalPercent(this, 33, flashPercent, playerAction) AND isEquipConvergenceGemCart eq 0 AND isFirstAttck eq 0
- template `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` — when isEquipConvergenceGemCart ne 0 AND isFirstAttck ne 0 OR isEquipConvergenceGemCart eq 0 AND isFirstAttck ne 0 OR isEquipConvergenceGemCart ne 0 AND isFirstAttck eq 0

**`NextRangeHit`** (2 paths)

- set `isFirstAttck` = `0` = 0
- set `isRangeBonus` = `0` = 0

</details>

---

### สไตร์คสเต็ป (StrikeStub) · uid 970

<img src="../../icons/sk_970.png" width="40" alt="icon"> 
**Tree:** ハルバードスキル (`HalberdSkill`, tier 3) · **Type:** Attack · **Max Lv:** 70 · **Weapons:** OneHandSword, Halberd · **Requires:** เดดลี่สเปียร์ · **Flags:** MercenaryCanUseSkill · **Client class:** `StrikeStubAction`

> โจมตีศัตรูด้วยการเคลื่อนไหวอย่างรวดเร็ว
> ค่าความเสียหายจะเพิ่มขึ้นเมื่อเป้าหมายติดสภาวะผิดปกติ
> มีโอกาสเกิดคริติคอลได้ยาก

<details><summary>In-game level notes</summary>

- Lv9: *พลังสกิล+300 *ค่าความเสียหายของสภาวะผิดปกติx2
- Lv10: *ลดอัตราคริติคอล

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [mainWeapon != OneHandSword AND mainWeapon == Halberd & AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND damageCount lt 1 OR AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) eq 1 AND damageCount lt 1 OR 1 ge damageCount AND AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND damageCount ge 1] | 2.11 | 2.32 | 2.53 | 2.74 | 2.95 | 3.16 | 3.37 | 3.58 | 3.79 | 4 |
| SkillRate × [mainWeapon == OneHandSword OR mainWeapon != Halberd AND mainWeapon != OneHandSword & AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND damageCount lt 1 OR AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) eq 1 AND damageCount lt 1 OR 1 ge damageCount AND AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND damageCount ge 1] | 2.01 | 2.12 | 2.23 | 2.34 | 2.45 | 2.56 | 2.67 | 2.78 | 2.89 | 3 |
| SkillRate × [AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) lt 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND damageCount lt 1 OR AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) lt 1 AND IsInstanceOf(playerAction, PlayerActionManager) eq 1 AND damageCount lt 1 OR 1 ge damageCount AND AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) lt 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND damageCount ge 1] | 1.91 | 1.92 | 1.93 | 1.94 | 1.95 | 1.96 | 1.97 | 1.98 | 1.99 | 2 |
| Flat dmg + [mainWeapon != OneHandSword AND mainWeapon == Halberd] | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 |
| Flat dmg + [mainWeapon == OneHandSword OR mainWeapon != Halberd AND mainWeapon != OneHandSword] | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((((Lv + 190) / 100)) + (((((Lv + (Lv << 2)) << 1) + ((Lv + (Lv << 2)) << 1)) / 100)))` — AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND damageCount lt 1 OR AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) eq 1 AND damageCount lt 1 OR 1 ge damageCount AND AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND damageCount ge 1 & mainWeapon != OneHandSword AND mainWeapon == Halberd & AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND damageCount lt 1 OR AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) eq 1 AND damageCount lt 1 OR 1 ge damageCount AND AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND damageCount ge 1
- SkillRate × `((((Lv + 190) / 100)) + (((((Lv + (Lv << 2)) << 1) + ((Lv + (Lv << 2)) << 1)) / 100)))` — AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND damageCount lt 1 OR AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) eq 1 AND damageCount lt 1 OR 1 ge damageCount AND AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND damageCount ge 1 & mainWeapon == OneHandSword OR mainWeapon != Halberd AND mainWeapon != OneHandSword & AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND damageCount lt 1 OR AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) eq 1 AND damageCount lt 1 OR 1 ge damageCount AND AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND damageCount ge 1
- SkillRate × `(((status.Str // 5) / 100))`
- SkillRate × `(((Lv + 190) / 100))` — AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND damageCount lt 1 OR AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) eq 1 AND damageCount lt 1 OR 1 ge damageCount AND AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND damageCount ge 1 & AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) lt 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND damageCount lt 1 OR AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) lt 1 AND IsInstanceOf(playerAction, PlayerActionManager) eq 1 AND damageCount lt 1 OR 1 ge damageCount AND AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) lt 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND damageCount ge 1

**Role:** attack (deals damage) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(200)`
- `SkillRate` multiplies by (adds into): `((((Lv + 190) / 100)) + (((((Lv + (Lv << 2)) << 1) + ((Lv + (Lv << 2)) << 1)) / 100)))` | `(((status.Str // 5) / 100))` | `(((Lv + 190) / 100))`

**Mechanics recovered from code**

- **Extra critical chance (%)** (`criticalPercent`): `(100 - (Lv + (Lv << 2)))` → Lv1..10 [95, 90, 85, 80, 75, 70, 65, 60, 55, 50] _(when mainWeapon != OneHandSword AND mainWeapon == Halberd OR mainWeapon != Halberd AND mainWeapon != OneHandSword)_; `((100 - (Lv + (Lv << 2))) * 0.5)` → Lv1..10 [47.5, 45.0, 42.5, 40.0, 37.5, 35.0, 32.5, 30.0, 27.5, 25.0] _(when mainWeapon == OneHandSword)_
- **Ailment chance (%)** (`abnormalRate`): `((((Lv + (Lv << 2)) << 1) + ((Lv + (Lv << 2)) << 1)) / 100)` → Lv1..10 [0.2, 0.4, 0.6, 0.8, 1.0, 1.2, 1.4, 1.6, 1.8, 2.0] _(when mainWeapon != OneHandSword AND mainWeapon == Halberd)_; `(((Lv + (Lv << 2)) << 1) / 100)` → Lv1..10 [0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1.0] _(when mainWeapon == OneHandSword OR mainWeapon != Halberd AND mainWeapon != OneHandSword)_
- **Alternate skill multiplier (%)** (`bonusSkillRate`): `((status.Str // 5) / 100)`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 970

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (3 paths)

- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `fixAddDamage` = `200` = 200 — when mainWeapon != OneHandSword AND mainWeapon == Halberd
- set `skillRate` = `((Lv + 190) / 100)` → Lv1..10: [1.91, 1.92, 1.93, 1.94, 1.95, 1.96, 1.97, 1.98, 1.99, 2.0]
- set `criticalPercent` = `(100 - (Lv + (Lv << 2)))` → Lv1..10: [95, 90, 85, 80, 75, 70, 65, 60, 55, 50] — when mainWeapon != OneHandSword AND mainWeapon == Halberd OR mainWeapon != Halberd AND mainWeapon != OneHandSword
- set `abnormalRate` = `((((Lv + (Lv << 2)) << 1) + ((Lv + (Lv << 2)) << 1)) / 100)` → Lv1..10: [0.2, 0.4, 0.6, 0.8, 1.0, 1.2, 1.4, 1.6, 1.8, 2.0] — when mainWeapon != OneHandSword AND mainWeapon == Halberd
- set `bonusSkillRate` = `((status.Str // 5) / 100)`
- set `fixAddDamage` = `100` = 100 — when mainWeapon == OneHandSword OR mainWeapon != Halberd AND mainWeapon != OneHandSword
- set `abnormalRate` = `(((Lv + (Lv << 2)) << 1) / 100)` → Lv1..10: [0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1.0] — when mainWeapon == OneHandSword OR mainWeapon != Halberd AND mainWeapon != OneHandSword
- set `criticalPercent` = `((100 - (Lv + (Lv << 2))) * 0.5)` → Lv1..10: [47.5, 45.0, 42.5, 40.0, 37.5, 35.0, 32.5, 30.0, 27.5, 25.0] — when mainWeapon == OneHandSword

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`

**`calcPlayerToMobDamage`** (152 paths)

- set `skillRate` = `(skillRate + abnormalRate)` — when AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND damageCount lt 1 OR AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) eq 1 AND damageCount lt 1 OR 1 ge damageCount AND AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND damageCount ge 1
- template `AddRate[SkillRate]` = `(skillRate + abnormalRate)` — when AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND damageCount lt 1 OR AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) eq 1 AND damageCount lt 1 OR 1 ge damageCount AND AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) ge 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND damageCount ge 1
- template `AddRate[SkillRate]` = `bonusSkillRate`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- info `templates` = `1`
- template `AddRate[SkillRate]` = `skillRate` — when AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) lt 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND damageCount lt 1 OR AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) lt 1 AND IsInstanceOf(playerAction, PlayerActionManager) eq 1 AND damageCount lt 1 OR 1 ge damageCount AND AbnormalStateManager.get_AbnormalCount(MobActionManagerBase.get_AbnormalStateManager(mobAction)) lt 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND damageCount ge 1

</details>

---

### คริติคอลสเปียร์ (HandlingSatisfaction) · uid 971

<img src="../../icons/sk_971.png" width="40" alt="icon"> 
**Tree:** ハルバードスキル (`HalberdSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 70 · **Weapons:** Halberd · **Requires:** ฮัลเบิร์ทมาสเตอรี่ · **Client class:** `HandlingSatisfactionMastary` (passive mastery)

> เรียนเคล็ดวิชาหอกวายุ
> อัตราคริติคอลจะเพิ่มขึ้นเมื่อติดตั้งหอกวายุ

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| CrtRate | 0 | 1 | 1 | 2 | 2 | 3 | 3 | 4 | 4 | 5 |
| Crt | 1 | 1 | 2 | 2 | 3 | 3 | 4 | 4 | 5 | 5 |


---

### บัสเตอร์แลนซ์ / แพนิกบัสเตอร์แลนซ์ (BusterLunce) · uid 975

<img src="../../icons/sk_975.png" width="40" alt="icon"> 
**Tree:** ハルバードスキル (`HalberdSkill`, tier 3) · **Type:** Attack · **Max Lv:** 70 · **Weapons:** Halberd · **Flags:** NoMarketSearch, MercenaryCanUseSkill · **Client class:** `BusterLanceAction`

> โจมตีระยะไกลด้วยการขวางหอก
> ยิ่งห่างมากพลังโจมตีจะยิ่งต่ำลง
> ถ้าทำเงื่อนไขครบถ้วนสกิลจะเปลี่ยนไป
> การลดทอนระยะทางก็จะคลายลงเช่นกัน

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((((((500 + (((status.Agi + status.Str) lt 0 ? ((status.Agi + status.Str) + 1) : (status.Agi + status.Str)) >> 1))) - (((100 - (Lv + (Lv << 2)))) * max((((MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))) pl 100 ? min((((500 + (((status.Agi + status.Str) lt 0 ? ((status.Agi + status.Str) + 1) : (status.Agi + status.Str)) >> 1))) - (((100 - (Lv + (Lv << 2)))) * max((((MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter(ActionRange) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))), 855) : 100) + (gemCart(1044[4]))) / 100)`
- SkillRate × `((((((500 + (((status.Agi + status.Str) lt 0 ? ((status.Agi + status.Str) + 1) : (status.Agi + status.Str)) >> 1))) - (((100 - (Lv + (Lv << 2)))) * max((((MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))) pl 100 ? min((((500 + (((status.Agi + status.Str) lt 0 ? ((status.Agi + status.Str) + 1) : (status.Agi + status.Str)) >> 1))) - (((100 - (Lv + (Lv << 2)))) * max((((MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter(ActionRange) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))), 855) : 100) + (gemCart(1044[4]))) / 100)` — !AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR !AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND !PlayerAttackBase.IsBlank(this) AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR !AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND !PlayerAttackBase.IsBlank(this) AND MobaMode eq 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction)
- SkillRate × `((((((500 + (((status.Agi + status.Str) lt 0 ? ((status.Agi + status.Str) + 1) : (status.Agi + status.Str)) >> 1))) - (((100 - (Lv + (Lv << 2)))) * max((((MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))) pl 100 ? min((((500 + (((status.Agi + status.Str) lt 0 ? ((status.Agi + status.Str) + 1) : (status.Agi + status.Str)) >> 1))) - (((100 - (Lv + (Lv << 2)))) * max((((MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter(ActionRange) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))), 855) : 100) + (gemCart(1044[4]))) / 100)`
- SkillRate × `((((((500 + (((status.Agi + status.Str) lt 0 ? ((status.Agi + status.Str) + 1) : (status.Agi + status.Str)) >> 1))) - (((100 - (Lv + (Lv << 2)))) * max((((MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))) pl 100 ? min((((500 + (((status.Agi + status.Str) lt 0 ? ((status.Agi + status.Str) + 1) : (status.Agi + status.Str)) >> 1))) - (((100 - (Lv + (Lv << 2)))) * max((((MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter(ActionRange) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))), 855) : 100) + (gemCart(1044[4]))) / 100)` — !AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR !AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND !PlayerAttackBase.IsBlank(this) AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR !AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND !PlayerAttackBase.IsBlank(this) AND MobaMode eq 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction)
- Flat dmg + `(100)` — !AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR !AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND !PlayerAttackBase.IsBlank(this) AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR !AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND !PlayerAttackBase.IsBlank(this) AND MobaMode eq 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction)

**Role:** attack (deals damage)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **slot chosen at runtime (physical or magic by a per-cast flag)**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(100)`
- `SkillRate` multiplies by (adds into): `((((((500 + (((status.Agi + status.Str) lt 0 ? ((status.Agi + status.Str) + 1) : (status.Agi + status.Str)) >> 1))) - (((100 - (Lv + (Lv << 2)))) * max((((MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))) pl 100 ? min((((500 + (((status.Agi + status.Str) lt 0 ? ((status.Agi + status.Str) + 1) : (status.Agi + status.Str)) >> 1))) - (((100 - (Lv + (Lv << 2)))) * max((((MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(15))) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter(ActionRange) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))), 855) : 100) + (gemCart(1044[4]))) / 100)`
- `ExpRate` sets: `ExtensionMethod.ExSkillData.SkillDataExtentionMethod.GetTargetExpRate(BusterLanceAction.get_AttackType(), PlayerAttackBase.get_ActionID(), MobActionManagerBase.get_MobBattleStatus(mobAction))`

**Proration:** slot `dynamic`, mode `first_hit_per_target`, attack type `dynamic`, action id 975

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(15)`
- set `skillRate` = `(500 + (((status.Agi + status.Str) lt 0 ? ((status.Agi + status.Str) + 1) : (status.Agi + status.Str)) >> 1))`
- set `fixAddDamage` = `100` = 100
- set `distanceAttenuation` = `(100 - (Lv + (Lv << 2)))` → Lv1..10: [95, 90, 85, 80, 75, 70, 65, 60, 55, 50]
- set `isGemCart` = `1` = 1
- set `attenuationStartDist` = `(attenuationStartDist + 3)`
- set `gemCartRate` = `gemCart(1044[4])`

**`ActionPreparation`** (30 paths)

- set `SkillParam` = `(SkillParam | 16)` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND SkillActionBase.checkPercent(this, 100, 30) AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Equality(actarAction) AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND PlayerAttackBase.IsBlank(this) AND SkillActionBase.checkPercent(this, 100, 30) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND MobaMode ne 0 AND SkillActionBase.checkPercent(this, 100, 30) AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction)
- set `isPunishRay` = `1` = 1 — when !AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR !AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND !PlayerAttackBase.IsBlank(this) AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR !AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND !PlayerAttackBase.IsBlank(this) AND MobaMode eq 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction)
- set `punishRayLv` = `PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[967].Level` — when !AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR !AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND !PlayerAttackBase.IsBlank(this) AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR !AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND !PlayerAttackBase.IsBlank(this) AND MobaMode eq 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction)
- set `distanceAttenuation` = `(distanceAttenuation + -25)` — when !AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR !AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND !PlayerAttackBase.IsBlank(this) AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR !AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND !PlayerAttackBase.IsBlank(this) AND MobaMode eq 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction)
- set `fixAddDamage` = `(fixAddDamage + 100)` — when !AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR !AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND !PlayerAttackBase.IsBlank(this) AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR !AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND !PlayerAttackBase.IsBlank(this) AND MobaMode eq 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction)
- set `skillRate` = `(skillRate + ((PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[967].Level + (PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[967].Level << 2)) << 1))` — when !AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR !AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND !PlayerAttackBase.IsBlank(this) AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR !AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND !PlayerAttackBase.IsBlank(this) AND MobaMode eq 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction)

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`calcPlayerToMobDamage`** (2 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)`
- template `AddRate[SkillRate]` = `((((skillRate - (distanceAttenuation * max((((MathUtil.DistanceToDisplayMeter(ActionRange) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter(ActionRange) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))) pl 100 ? min((skillRate - (distanceAttenuation * max((((MathUtil.DistanceToDisplayMeter(ActionRange) mi MobActionManagerBase.get_PlayerMeterDistance(mobAction) ? MathUtil.DistanceToDisplayMeter(ActionRange) : MobActionManagerBase.get_PlayerMeterDistance(mobAction)) - attenuationStartDist) + 1), 0))), 855) : 100) + gemCartRate) / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- template `SetRate[ExpRate]` = `ExtensionMethod.ExSkillData.SkillDataExtentionMethod.GetTargetExpRate(BusterLanceAction.get_AttackType(), PlayerAttackBase.get_ActionID(), MobActionManagerBase.get_MobBattleStatus(mobAction))`
- info `templates` = `1`

**`GetLocalizeKey`** (2 paths)

- set `isPunishRay` = `isPunishRay`

</details>

---

### บลิทซ์ไปก์ (BlitzPike) · uid 980

<img src="../../icons/sk_980.png" width="40" alt="icon"> 
**Tree:** ハルバードスキル (`HalberdSkill`, tier 3) · **Type:** Object · **Max Lv:** 70 · **Weapons:** Halberd · **Requires:** วานิชเรย์ · **Client class:** `BlitzPikeAction`

> โจมตีด้วยสายฟ้าลมกรดอย่างรวดเร็ว
> เมื่อเปิดใช้งานในระยะใกล้มีโอกาสทำให้ติด "อัมพาต"
> เป้าหมายที่ติดอัมพาตจะถูกโจมตีด้วยเวทมนตร์
> เมื่อเปิดใช้งานในระยะไกลจะเรียกหอกสายฟ้าออกมา
> และโจมตีเป้าหมายที่เข้ามาใกล้โดยอัตโนมัติ

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(skillRate[0] / 100)` — CalcFirstDamageData fixAddDamage.Length ne 0 AND skillRate.Length ne 0 OR fixAddDamage.Length eq 0 AND skillRate.Length ne 0 OR PlayerAttackBase.checkAbnormalPercent(this, 6, abnormalPer, playerAction) AND fixAddDamage.Length ne 0 AND skillRate.Length ne 0
- SkillRate × `(skillRate[1] / 100)` — CalcSecondDamageData fixAddDamage.Length hi 1 AND skillRate.Length hi 1 OR fixAddDamage.Length ls 1 AND skillRate.Length hi 1
- Flat dmg + `fixAddDamage[0]` — CalcFirstDamageData fixAddDamage.Length ne 0 AND skillRate.Length ne 0 OR PlayerAttackBase.checkAbnormalPercent(this, 6, abnormalPer, playerAction) AND fixAddDamage.Length ne 0 AND skillRate.Length ne 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 6, abnormalPer, playerAction) AND fixAddDamage.Length ne 0 AND skillRate.Length ne 0
- Flat dmg + `fixAddDamage[1]` — CalcSecondDamageData fixAddDamage.Length hi 1 AND skillRate.Length hi 1

**Role:** attack (deals damage) · buff (self) · applies status ailment · placed object / trap / summon

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `fixAddDamage[0]` | `fixAddDamage[1]`
- `SkillRate` multiplies by (adds into): `(skillRate[0] / 100)` | `(skillRate[1] / 100)`
- `ExpRate` sets: `(exp / 100)`

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `dynamic`, action id 980

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (7 paths)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(24)`
- set `attackType` = `1` = 1
- set `skillRate[0]` = `((((Lv * 10) + 300) + ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 982, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 982, 1) << 2)) << 1)) + ((baseSTR lt 0 ? (baseSTR + 1) : baseSTR) >> 1))` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 982, 1) ge 1 AND fixAddDamage.Length hi 1 AND fixAddDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length ne 0 AND skillRate.Length ne 1 OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 982, 1) ge 1 AND fixAddDamage.Length hi 1 AND fixAddDamage.Length ne 0 AND skillRate.Length ls 1 AND skillRate.Length ne 0 AND skillRate.Length ne 1
- set `skillRate[1]` = `((((Lv * 30) + 100) + ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 982, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 982, 1) << 2)) << 1)) + ((baseINT lt 0 ? (baseINT + 1) : baseINT) >> 1))` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 982, 1) ge 1 AND fixAddDamage.Length hi 1 AND fixAddDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length ne 0 AND skillRate.Length ne 1
- set `fixAddDamage[0]` = `300` = 300 — when fixAddDamage.Length ls 1 AND fixAddDamage.Length ne 0 AND skillRate.Length ne 0 AND skillRate.Length ne 1 OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 982, 1) lt 1 AND fixAddDamage.Length hi 1 AND fixAddDamage.Length ne 0 AND skillRate.Length ne 0 AND skillRate.Length ne 1 OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 982, 1) ge 1 AND fixAddDamage.Length hi 1 AND fixAddDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length ne 0 AND skillRate.Length ne 1
- set `fixAddDamage[1]` = `((status.Int lt 0 ? (status.Int + 1) : status.Int) >> 1)` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 982, 1) lt 1 AND fixAddDamage.Length hi 1 AND fixAddDamage.Length ne 0 AND skillRate.Length ne 0 AND skillRate.Length ne 1 OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 982, 1) ge 1 AND fixAddDamage.Length hi 1 AND fixAddDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length ne 0 AND skillRate.Length ne 1 OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 982, 1) ge 1 AND fixAddDamage.Length hi 1 AND fixAddDamage.Length ne 0 AND skillRate.Length ls 1 AND skillRate.Length ne 0 AND skillRate.Length ne 1
- set `abnormalPer` = `((baseINT // 10) + (Lv + (Lv << 2)))` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 982, 1) lt 1 AND fixAddDamage.Length hi 1 AND fixAddDamage.Length ne 0 AND skillRate.Length ne 0 AND skillRate.Length ne 1 OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 982, 1) ge 1 AND fixAddDamage.Length hi 1 AND fixAddDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length ne 0 AND skillRate.Length ne 1
- set `skillRate[1]` = `((Lv * 30) + 100)` → Lv1..10: [130, 160, 190, 220, 250, 280, 310, 340, 370, 400] — when fixAddDamage.Length eq 0 AND skillRate.Length ne 0 AND skillRate.Length ne 1 OR fixAddDamage.Length ls 1 AND fixAddDamage.Length ne 0 AND skillRate.Length ne 0 AND skillRate.Length ne 1 OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 982, 1) lt 1 AND fixAddDamage.Length hi 1 AND fixAddDamage.Length ne 0 AND skillRate.Length ne 0 AND skillRate.Length ne 1
- set `skillRate[0]` = `((Lv * 10) + 300)` → Lv1..10: [310, 320, 330, 340, 350, 360, 370, 380, 390, 400] — when skillRate.Length eq 1 AND skillRate.Length ne 0 OR fixAddDamage.Length eq 0 AND skillRate.Length ne 0 AND skillRate.Length ne 1 OR fixAddDamage.Length ls 1 AND fixAddDamage.Length ne 0 AND skillRate.Length ne 0 AND skillRate.Length ne 1

**`ActionStart`** (3 paths)

- set `SkillIndividualFlag` = `(MobActionManagerBase.get_PlayerMeterDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)) lt 8 ? 1 : 0)` — when (MobActionManagerBase.get_PlayerMeterDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)) lt 8 ? 1 : 0) eq 1 AND UnityEngine.Object.op_Inequality(target) OR (MobActionManagerBase.get_PlayerMeterDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)) lt 8 ? 1 : 0) ne 1 AND UnityEngine.Object.op_Inequality(target)
- set `mainTarget` = `UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)` — when (MobActionManagerBase.get_PlayerMeterDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)) lt 8 ? 1 : 0) eq 1 AND UnityEngine.Object.op_Inequality(target) OR (MobActionManagerBase.get_PlayerMeterDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)) lt 8 ? 1 : 0) ne 1 AND UnityEngine.Object.op_Inequality(target)
- set `SkillIndividualFlag` = `0` = 0 — when !UnityEngine.Object.op_Inequality(target)

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`NextRangeHit`** (5 paths)

- set `isAbnormalSucces` = `1` = 1 — when attackCount eq 0

**`calcPlayerToMobDamage`** (6 paths)

- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(987, 0, 0)` — when attackCount eq 2 OR attackCount eq 0 AND attackCount ne 2 OR attackCount ne 0 AND attackCount ne 2
- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(987)` — when attackCount eq 2 OR attackCount eq 0 AND attackCount ne 2 OR attackCount ne 0 AND attackCount ne 2

**`CalcFirstDamageData`** (10 paths)

- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `attackType` = `1` = 1
- template `AddRate[SkillRate]` = `(skillRate[0] / 100)` — when fixAddDamage.Length ne 0 AND skillRate.Length ne 0 OR fixAddDamage.Length eq 0 AND skillRate.Length ne 0 OR PlayerAttackBase.checkAbnormalPercent(this, 6, abnormalPer, playerAction) AND fixAddDamage.Length ne 0 AND skillRate.Length ne 0
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage[0]` — when fixAddDamage.Length ne 0 AND skillRate.Length ne 0 OR PlayerAttackBase.checkAbnormalPercent(this, 6, abnormalPer, playerAction) AND fixAddDamage.Length ne 0 AND skillRate.Length ne 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 6, abnormalPer, playerAction) AND fixAddDamage.Length ne 0 AND skillRate.Length ne 0
- template `SetRate[ExpRate]` = `(exp / 100)` — when fixAddDamage.Length ne 0 AND skillRate.Length ne 0 OR PlayerAttackBase.checkAbnormalPercent(this, 6, abnormalPer, playerAction) AND fixAddDamage.Length ne 0 AND skillRate.Length ne 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 6, abnormalPer, playerAction) AND fixAddDamage.Length ne 0 AND skillRate.Length ne 0
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(6, abnormalPer, playerAction)` — when PlayerAttackBase.checkAbnormalPercent(this, 6, abnormalPer, playerAction) AND fixAddDamage.Length ne 0 AND skillRate.Length ne 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 6, abnormalPer, playerAction) AND fixAddDamage.Length ne 0 AND skillRate.Length ne 0
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(6, 0)` — when PlayerAttackBase.checkAbnormalPercent(this, 6, abnormalPer, playerAction) AND fixAddDamage.Length ne 0 AND skillRate.Length ne 0
- info `templates` = `1`

**`CalcSecondDamageData`** (4 paths)

- set `Element` = `3` = 3
- set `attackType` = `1` = 1
- template `AddRate[SkillRate]` = `(skillRate[1] / 100)` — when fixAddDamage.Length hi 1 AND skillRate.Length hi 1 OR fixAddDamage.Length ls 1 AND skillRate.Length hi 1
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage[1]` — when fixAddDamage.Length hi 1 AND skillRate.Length hi 1
- template `SetRate[ExpRate]` = `(exp / 100)` — when fixAddDamage.Length hi 1 AND skillRate.Length hi 1
- info `templates` = `1`

**`ActionSkillEvent`** (5 paths)

- calls `BlitzPikeBuf..ctor` = `.ctor(Lv, actarAction)` — when UnityEngine.Object.op_Inequality(actarAction) AND param eq 101 OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 980) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 101
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new BlitzPikeBuf, Id)` — when UnityEngine.Object.op_Inequality(actarAction) AND param eq 101 OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 980) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 101

</details>

**Buffs**

**Buff `BlitzPikeBuf`**
- Buff hook methods: `<Prev>b__21_0`, `<Updata>b__20_0`, `ClearEffect`, `EffectUpdate`, `OnLeave`, `Prev`, `TakeEvent`, `UpdateParam`
- `Value` = `int((intervalTimer * 100))`
- `Count` = `(0)`
- Buff fields set in the constructor (all recovered):
  - `effectPosList` = `0x165d9d4(meta(0x3973d10, UnityEngine.Vector3[]_TypeInfo), 4, playerAction)`
  - `effectDataList` = `new System.Collections.Generic.List<BlitzPikeBuf.EffectData>`
  - `Count` = `0`
  - `Max` = `4` = 4
  - `playerAction` = `playerAction`
- Hook `UpdateParam`: `takeController`=[Singleton<TakeManager>.get_Instance()+0x20]
- Hook `Updata`: `intervalTimer`=max((intervalTimer - UnityEngine.Time.get_deltaTime()), 0)
- Hook `Prev`: `intervalTimer`=1
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:BlitzPikeBuf$$.ctor<-BlitzPikeAction$$ActionSkillEvent` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

<details><summary>Effect applied in `SkillBufferManager$$UpdateIndividualBuf` (9 guarded paths)</summary>

- when `TryGetBuf.out2() ne 0`
  - returns `SkillBufferManager.RemoveBuffer(this, 301, ?x2, ?x3)`
  - calls `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `SkillBufferManager$$RemoveBuffer`, `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `SkillBufferManager$$RemoveBuffer`
- when `TryGetBuf.out2() ne 0`
  - returns `SkillBufferManager.TryGetBuf(this, 301, stkp(-24), ?x3)`
  - calls `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `SkillBufferManager$$RemoveBuffer`
- when `TryGetBuf.out2() ne 0`
  - returns `CharacterActionManagerBase.get_DefaultMoveSpeed()`
  - calls `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`
- when `TryGetBuf.out2() ne 0`
  - returns `SkillBufferManager.TryGetBuf(this, 301, stkp(-24), ?x3)`
  - calls `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`
- when `TryGetBuf.out2() eq 0`
  - calls `0x165db84`
- when `TryGetBuf.out2() ne 0`
  - returns `SkillBufferManager.RemoveBuffer(this, 301, ?x2, ?x3)`
  - calls `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `SkillBufferManager$$RemoveBuffer`
- when `TryGetBuf.out2() ne 0`
  - returns `CharacterActionManagerBase.get_DefaultMoveSpeed()`
  - calls `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`
- when `TryGetBuf.out2() eq 0`
  - calls `0x165db84`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `SkillBufferManager$$UpdateIndividualBuf (TryGetBuf)`

---

### ดราก้อนทูธ (DragonTooth) · uid 972

<img src="../../icons/sk_972.png" width="40" alt="icon"> 
**Tree:** ハルバードスキル (`HalberdSkill`, tier 4) · **Type:** Attack · **Max Lv:** 150 · **Weapons:** Halberd · **Requires:** ดราก้อนเทล · **Flags:** MercenaryCanUseSkill · **Client class:** `DragonToothAction`

> กระโจนพุ่งเข้าใส่แล้วโจมตีเป้าหมาย
> หลังจากใช้สกิลสำเร็จจะกลับไปอยู่ที่เดิม
> เพิ่มอัตราการโจมตีทะลุพลังป้องกัน​และอัตราคริติคอลในระดับสูง
> แต่ไม่มีบวกโบนัสพลังสกิล

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [calcFirstDamage] | 0.75 | 1.5 | 2.25 | 3 | 3.75 | 4.5 | 5.25 | 6 | 6.75 | 7.5 |
| SkillRate × [calcSecondDamage] | 7.5 | 7.5 | 7.5 | 7.5 | 7.5 | 7.5 | 7.5 | 7.5 | 7.5 | 7.5 |

**Role:** attack (deals damage) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillRate` multiplies by (adds into): `(((Lv * 75) / 100))` | `7.5`

**Mechanics recovered from code**

- **Attack range** (`attackRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- **Resistance value** (`resist`): `((Lv + (Lv << 2)) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 972

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`
- set `attackRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `critical` = `(Lv + 65)` → Lv1..10: [66, 67, 68, 69, 70, 71, 72, 73, 74, 75]
- set `skillRate` = `((Lv * 75) / 100)` → Lv1..10: [0.75, 1.5, 2.25, 3.0, 3.75, 4.5, 5.25, 6.0, 6.75, 7.5]
- set `resist` = `((Lv + (Lv << 2)) << 1)` → Lv1..10: [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`
- set `targetPos` = `castTime`

**`ActionStartOthers`** (1 path)

- set `startPos.y` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y`
- set `startPos.z` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z`

**`ActionStart`** (2 paths)

- set `targetAction` = `UnityEngine.GameObject.GetComponent<CharacterActionManagerBase>(target)` — when !PlayerAttackBase.IsBlank(this)
- set `startPos.y` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y` — when !PlayerAttackBase.IsBlank(this)
- set `startPos.z` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z` — when !PlayerAttackBase.IsBlank(this)
- set `targetPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x` — when !PlayerAttackBase.IsBlank(this)
- set `targetPos.y` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y` — when !PlayerAttackBase.IsBlank(this)
- set `targetPos.z` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z` — when !PlayerAttackBase.IsBlank(this)
- set `SkillIndividualFlag` = `int((max((fsqrt((((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x)))) - CharacterActionManagerBase.get_Size()), 0) * 100))` — when !PlayerAttackBase.IsBlank(this)

**`calcPlayerToMobDamage`** (2 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)`

**`calcFirstDamage`** (2 paths)

- template `AddRate[SkillRate]` = `skillRate`
- info `templates` = `1`

**`calcSecondDamage`** (2 paths)

- template `AddRate[SkillRate]` = `7.5`
- info `templates` = `1`

**`Damaged`** (3 paths)

- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(0, 0)` — when (damageData.AbnormalType - 1) ls 2 AND IsInstanceOf(SkillActionManagerBase.get_CurrentSkill(), DragonToothAction) eq 1

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `N_DragonToothAction$$OnInitialize (GetSkillLv)`

---

### โครนอสไดรฟ์ (CronosDrive) · uid 973

<img src="../../icons/sk_973.png" width="40" alt="icon"> 
**Tree:** ハルバードスキル (`HalberdSkill`, tier 4) · **Type:** Attack · **Max Lv:** 150 · **Weapons:** Halberd · **Requires:** สไตร์คสเต็ป · **Flags:** MercenaryCanUseSkill · **Client class:** `CronosDriveAction`

> ท่าลับที่ทำให้แทงทะลุซ้ำๆ กันได้หลายครั้ง
> จะสร้างความเสียหายกับมอนสเตอร์ที่เป็นเป้าหมายอย่างต่อเนื่อง
> พร้อมฟื้นฟู MP ให้ตัวเองเล็กน้อยเป็นเวลาหลายวินาที

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 1.5 | 2 | 2.5 | 3 | 3.5 | 4 | 4.5 | 5 | 5.5 | 6 |
| Flat dmg + | 40 | 80 | 120 | 160 | 200 | 240 | 280 | 320 | 360 | 400 |

**Role:** attack (deals damage) · buff (self)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv + (Lv << 2)) << 3))`
- `SkillRate` multiplies by (adds into): `((((Lv * 50) + 100) / 100))`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 973

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `skillRate` = `(((Lv * 50) + 100) / 100)` → Lv1..10: [1.5, 2.0, 2.5, 3.0, 3.5, 4.0, 4.5, 5.0, 5.5, 6.0]
- set `fixAddDamage` = `((Lv + (Lv << 2)) << 3)` → Lv1..10: [40, 80, 120, 160, 200, 240, 280, 320, 360, 400]
- set `SkillIndividualFlag` = `int(((IPlayerStatusCalculator.GetNextAtkTime(PlayerStatusBase.get_SecondaryStatus()) + ((SkillActionBase.get_MotionSpeed(this) / 100) * 1.5)) * 100))`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`

**`calcPlayerToMobDamage`** (2 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)`
- set `baseHitReaction` = `PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction)`
- template `AddRate[SkillRate]` = `skillRate`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- info `templates` = `1`

**`via PlayerAttackBase$$HitReactionAssign`** (3467 paths)

- calls `MathUtil.CheckPercent` = `CheckPercent()` — when !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) eq 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3
- template `SetCalcValue[GuardPower]` = `System.Math.Max(0, (25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4))))` — when !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType ne 2 AND comboType ne 3
- template `SetCalcValue[GuardPower]` = `25` — when !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType ne 2 AND comboType ne 3

</details>

**Buffs**

**Buff `CronosDriveBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `(int((Lv eq 0 ? 0 : ((?ands - 1) * 0.5))) + 5)` s [Lv ne 10]; `10` s [Lv eq 10]
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0

<details><summary>Effect applied in `DimensionTillAction$$ActionHit` (1 guarded path)</summary>

- always
  - returns `SkillBufferManager.ContainsBuffer(?blr, 973, 0, ?x3)`
  - set `isCronosDriveBuf` = `(SkillBufferManager.ContainsBuffer(?blr, 973, 0, ?x3) & 1)`
  - set `hitCount` = `(hitCount + 1)`
  - calls `SkillActionBase$$ActionHit`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `DimensionTillAction$$ActionHit (ContainsBuffer)`
- `MobaPlayerBattleManager$$ReceiveSkillMotionEnd (GetSkillLv)`

---

### เทพลมกรด (HandlingerOfGodspeed) · uid 974

<img src="../../icons/sk_974.png" width="40" alt="icon"> 
**Tree:** ハルバードスキル (`HalberdSkill`, tier 4) · **Type:** Buffer · **Max Lv:** 150 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** วอร์ครายสทรักเกิ้ล · **Client class:** `HandlingerOfGodspeedAction`

> ใช้ MP สูงสุดและปล่อยพลังซ้อนกันได้ไม่เกิน 3 ครั้ง
> อัพเกรด ASPD/ความเร็วการเคลื่อนที่/การฟื้นฟู Avoid ในระยะเวลาสั้นๆ
> ลดต้านทานอาวุธ/ต้านทานเวทย์ลงเป็นจำนวนมาก
> ผลจะสิ้นสุดลงเมื่อได้รับความเสียหาย

<details><summary>In-game level notes</summary>

- Lv9: *เพิ่มปริมาณการเพิ่ม ASPD *ลดการลดลงของต้านทานอาวุธ ลดการลดลงของต้านทานเวทย์ ระยะเวลาแสดงผล +30 วินาที

</details>

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 974

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (5 paths)

- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(974, Lv, Id)` — when IsInstanceOf(SkillBufferManager.AddSelfBuffer(PlayerStatusBase.get_SkillBufferManager(), 974, Lv, Id), HandlingerOfGodspeedBuf) eq 1 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(SkillBufferManager.AddSelfBuffer(PlayerStatusBase.get_SkillBufferManager(), 974, Lv, Id), HandlingerOfGodspeedBuf) ne 1 AND UnityEngine.Object.op_Inequality(actarAction)

**`OnInheritance`** (1 path)

- set `IsInheritance` = `1` = 1

</details>

**Buffs**

**Buff `HandlingerOfGodspeedBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `CalcParam`, `DamageFunction`, `GetGodSpearHandlingParam`, `NextParam`, `UpdateParam`, `get_BufEffectTakeId`
- Duration: `((Lv << 1) + 10)` s
- `Value` = `cverlayCount` _(when BuffEffectActive ne 0)_
- `MagicDmgCut` = `(cverlayCount * (HandlingerOfGodspeedBuf.GetGodSpearHandlingParam(this, id) - (((Lv - lv) + 100))))` _(when BuffEffectActive ne 0)_
- `PowerDmgCut` = `(cverlayCount * (HandlingerOfGodspeedBuf.GetGodSpearHandlingParam(this, id) - (((Lv - lv) + 100))))` _(when BuffEffectActive ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| AvoidUp | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| MaxMpUp | -100 | -100 | -100 | -100 | -100 | -100 | -100 | -100 | -100 | -100 |
| Aspd | 30 | 60 | 90 | 120 | 150 | 180 | 210 | 240 | 270 | 300 |
| MotionSpeedRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |

- Buff fields set in the constructor (all recovered):
  - `bufTakeId` = `0x11e1aad0` = 300002000
  - `avoid` = `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `maxMp` = `100` = 100
  - `aspd` = `(Lv * 30)` → Lv1..10 [30, 60, 90, 120, 150, 180, 210, 240, 270, 300]
  - `actionSpeed` = `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `IsDamageCancel` = `1` = 1
  - `physicsResist` = `((Lv - lv) + 100)` = 100
  - `magicResist` = `((Lv - lv) + 100)` = 100
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `DamageFunction`: `cverlayCount`=(cverlayCount - 1); `bufTakeId`=((cverlayCount - 1) + 0x11e1aad0); `avoid`=((cverlayCount - 1) * Lv); `maxMp`=((cverlayCount - 1) * 100)
- Hook `NextParam`: `playerStatus`=status; `bufTakeId`=(cverlayCount + 0x11e1aad0); `aspd`=((type eq 9 ? (((level & 255) * 30) + 100) : ((level & 255) * 30)) * cverlayCount); `actionSpeed`=(cverlayCount * (level & 255))
- Hook `UpdateParam`: `playerStatus`=PlayerActionManagerBase.get_PlayerStatus(); `cverlayCount`=((cverlayCount lt 3 ? cverlayCount : 3) gt 1 ? (cverlayCount lt 3 ? cverlayCount : 3) : 1); `bufTakeId`=(cverlayCount + 0x11e1aad0); `avoid`=(((cverlayCount lt 3 ? cverlayCount : 3) gt 1 ? (cverlayCount lt 3 ? cverlayCount : 3) : 1) * Lv)
- Hook `CalcParam`: `avoid`=(cverlayCount * Lv); `maxMp`=(cverlayCount * 100); `aspd`=((type eq 9 ? ((Lv * 30) + 100) : (Lv * 30)) * cverlayCount); `actionSpeed`=(cverlayCount * Lv)

<details><summary>Effect applied in `GodSpearHandling1Action$$ActionHit` (4 guarded paths)</summary>

- when `SkillLv(974) ge 1` AND `TryGetValue.out2() ne 0`
  - returns `HandlingerOfGodspeedBuf.UpdateParam(TryGetValue.out2(), WeaponType, 1, SkillLv(974))`
  - calls `HandlingerOfGodspeedBuf$$UpdateParam`
- when `SkillLv(974) ge 1` AND `TryGetValue.out2() eq 0`
  - calls `0x165db84`
- when `SkillLv(974) ge 1`
  - returns `HandlingerOfGodspeedBuf.UpdateParam(SkillBufferManager.AddSelfBuffer(?blr, 974, SkillLv(974), Id), WeaponType, 1, SkillLv(974))`
  - calls `SkillBufferManager$$AddSelfBuffer`, `HandlingerOfGodspeedBuf$$UpdateParam`
- when `SkillLv(974) lt 1`
  - returns `SkillLv(974)`

</details>

<details><summary>Effect applied in `GodSpearHandling1Action$$IsFailure` (9 guarded paths)</summary>

- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 9` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 9` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `0`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 9` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `(PlayerAttackBase.IsFailure(this, status, missType, 0) & 1)`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 9` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 9` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) eq 0` AND `IPlayerStatusCalculator.get_MaxMp(PlayerStatusBase.get_SecondaryStatus()) lt 100`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_GameStatus`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 9` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) eq 0` AND `IPlayerStatusCalculator.get_MaxMp(PlayerStatusBase.get_SecondaryStatus()) lt 100`
  - returns `0`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_GameStatus`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 9` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) eq 0` AND `IPlayerStatusCalculator.get_MaxMp(PlayerStatusBase.get_SecondaryStatus()) ge 100`
  - returns `(PlayerAttackBase.IsFailure(this, status, missType, 0) & 1)`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `PlayerAttackBase$$IsFailure`
- when `SkillLv(974) gt 0` AND `SkillLv(978) le 9`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`

</details>

<details><summary>Effect applied in `GodSpearHandling2Action$$ActionHit` (4 guarded paths)</summary>

- when `SkillLv(974) ge 1` AND `TryGetValue.out2() ne 0`
  - returns `HandlingerOfGodspeedBuf.UpdateParam(TryGetValue.out2(), WeaponType, 2, SkillLv(974))`
  - calls `HandlingerOfGodspeedBuf$$UpdateParam`
- when `SkillLv(974) ge 1` AND `TryGetValue.out2() eq 0`
  - calls `0x165db84`
- when `SkillLv(974) ge 1`
  - returns `HandlingerOfGodspeedBuf.UpdateParam(SkillBufferManager.AddSelfBuffer(?blr, 974, SkillLv(974), Id), WeaponType, 2, SkillLv(974))`
  - calls `SkillBufferManager$$AddSelfBuffer`, `HandlingerOfGodspeedBuf$$UpdateParam`
- when `SkillLv(974) lt 1`
  - returns `SkillLv(974)`

</details>

<details><summary>Effect applied in `GodSpearHandling2Action$$IsFailure` (9 guarded paths)</summary>

- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 4` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 4` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `0`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 4` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `(PlayerAttackBase.IsFailure(this, status, missType, 0) & 1)`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 4` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 4` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) eq 0` AND `IPlayerStatusCalculator.get_MaxMp(PlayerStatusBase.get_SecondaryStatus()) lt 200`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_GameStatus`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 4` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) eq 0` AND `IPlayerStatusCalculator.get_MaxMp(PlayerStatusBase.get_SecondaryStatus()) lt 200`
  - returns `0`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_GameStatus`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 4` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) eq 0` AND `IPlayerStatusCalculator.get_MaxMp(PlayerStatusBase.get_SecondaryStatus()) ge 200`
  - returns `(PlayerAttackBase.IsFailure(this, status, missType, 0) & 1)`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `PlayerAttackBase$$IsFailure`
- when `SkillLv(974) gt 0` AND `SkillLv(978) le 4`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`

</details>

<details><summary>Effect applied in `GodSpearHandling3Action$$ActionHit` (4 guarded paths)</summary>

- when `SkillLv(974) ge 1` AND `TryGetValue.out2() ne 0`
  - returns `HandlingerOfGodspeedBuf.UpdateParam(TryGetValue.out2(), WeaponType, 3, SkillLv(974))`
  - calls `HandlingerOfGodspeedBuf$$UpdateParam`
- when `SkillLv(974) ge 1` AND `TryGetValue.out2() eq 0`
  - calls `0x165db84`
- when `SkillLv(974) ge 1`
  - returns `HandlingerOfGodspeedBuf.UpdateParam(SkillBufferManager.AddSelfBuffer(?blr, 974, SkillLv(974), Id), WeaponType, 3, SkillLv(974))`
  - calls `SkillBufferManager$$AddSelfBuffer`, `HandlingerOfGodspeedBuf$$UpdateParam`
- when `SkillLv(974) lt 1`
  - returns `SkillLv(974)`

</details>

<details><summary>Effect applied in `GodSpearHandling3Action$$IsFailure` (9 guarded paths)</summary>

- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `0`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `(PlayerAttackBase.IsFailure(this, status, missType, 0) & 1)`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) eq 0` AND `IPlayerStatusCalculator.get_MaxMp(PlayerStatusBase.get_SecondaryStatus()) lt 300`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_GameStatus`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) eq 0` AND `IPlayerStatusCalculator.get_MaxMp(PlayerStatusBase.get_SecondaryStatus()) lt 300`
  - returns `0`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_GameStatus`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) eq 0` AND `IPlayerStatusCalculator.get_MaxMp(PlayerStatusBase.get_SecondaryStatus()) ge 300`
  - returns `(PlayerAttackBase.IsFailure(this, status, missType, 0) & 1)`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `PlayerAttackBase$$IsFailure`
- when `SkillLv(974) gt 0` AND `SkillLv(978) le 0`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `GodSpearHandling1Action$$ActionHit (GetSkillLv)`
- `GodSpearHandling1Action$$IsFailure (GetSkillLv)`
- `GodSpearHandling1Action$$IsFailure (TryGetBuf)`
- `GodSpearHandling2Action$$ActionHit (GetSkillLv)`
- `GodSpearHandling2Action$$IsFailure (GetSkillLv)`
- `GodSpearHandling2Action$$IsFailure (TryGetBuf)`
- `GodSpearHandling3Action$$ActionHit (GetSkillLv)`
- `GodSpearHandling3Action$$IsFailure (GetSkillLv)`
- `GodSpearHandling3Action$$IsFailure (TryGetBuf)`

---

### ไลท์นิ่งเฮล (LightningHail) · uid 981

<img src="../../icons/sk_981.png" width="40" alt="icon"> 
**Tree:** ハルバードスキル (`HalberdSkill`, tier 4) · **Type:** Object · **Max Lv:** 150 · **Weapons:** Halberd · **Requires:** บลิทซ์ไปก์ · **Client class:** `LightningHailAction`

> เรียกพายุสายฟ้าจำนวนมากฟาดใส่ศัตรู
> สร้างความเสียหายเวทมนตร์รอบตัวเป้าหมาย
> หากเป้าหมายติดอัมพาตจะโจมตีได้แม่นยำยิ่งขึ้น
> ตัวเองจะติดคงกระพันเมื่อเปิดใช้สกิล

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 110 | 120 | 130 | 140 | 150 | 160 | 170 | 180 | 190 | 200 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((((status.Int // 10) + ((int((Lv * 0.5)) * 20) + 75))) / 100)`

**Role:** attack (deals damage) · buff (self) · placed object / trap / summon

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv * 10) + 100))`
- `SkillRate` multiplies by (adds into): `((((status.Int // 10) + ((int((Lv * 0.5)) * 20) + 75))) / 100)`
- `ExpRate` sets: `(target.ExpDefMagic / 100)` | `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**Mechanics recovered from code**

- **Loop / hit-repeat count** (`LoopParam`): `(int((Lv * 0.5)) + 3)` → Lv1..10 [3, 4, 4, 5, 5, 6, 6, 7, 7, 8]; `motionSpeed`; `(LoopParam + 100)` _(when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND AbnormalStateManager.Contains(EnemyMobActionManagerBase.get_AbnormalStateManager(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target)), 6) AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND attackNum ge 1 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND AbnormalStateManager.Contains(EnemyMobActionManagerBase.get_AbnormalStateManager(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target)), 6) AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND attackNum lt 1 OR !PlayerAttackBase.IsBlank(this) AND (SkillBufferManager.TryGetBuf<LightningHailBuf>!PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) AND AbnormalStateManager.Contains(EnemyMobActionManagerBase.get_AbnormalStateManager(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target)), 6) AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND attackNum ge 1)_
- **Effect radius (Unity units)** (`Radius`): `MathUtil.DisplayMeterToDistance(0.6)`

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 981

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(18)`
- set `skillRate` = `((status.Int // 10) + ((int((Lv * 0.5)) * 20) + 75))`
- set `fixAddDamage` = `((Lv * 10) + 100)` → Lv1..10: [110, 120, 130, 140, 150, 160, 170, 180, 190, 200]
- set `attackNum` = `(int((Lv * 0.5)) + 3)` → Lv1..10: [3, 4, 4, 5, 5, 6, 6, 7, 7, 8]
- set `LoopParam` = `(int((Lv * 0.5)) + 3)` → Lv1..10: [3, 4, 4, 5, 5, 6, 6, 7, 7, 8]
- set `nowAttackCount` = `0` = 0
- set `Radius` = `MathUtil.DisplayMeterToDistance(0.6)`

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `LoopParam` = `motionSpeed`
- set `targetPos` = `castTime`
- set `ActionRange` = `-1` = -1

**`ActionStart`** (101 paths)

- set `LoopParam` = `(LoopParam + 100)` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND AbnormalStateManager.Contains(EnemyMobActionManagerBase.get_AbnormalStateManager(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target)), 6) AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND attackNum ge 1 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND AbnormalStateManager.Contains(EnemyMobActionManagerBase.get_AbnormalStateManager(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target)), 6) AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND attackNum lt 1 OR !PlayerAttackBase.IsBlank(this) AND (SkillBufferManager.TryGetBuf<LightningHailBuf>!PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) AND AbnormalStateManager.Contains(EnemyMobActionManagerBase.get_AbnormalStateManager(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target)), 6) AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND attackNum ge 1
- set `lightningHailBuf` = `new LightningHailBuf` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND (SkillBufferManager.TryGetBuf<LightningHailBuf>!PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) AND UnityEngine.Object.op_Inequality(actarAction) AND attackNum ge 1 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND (SkillBufferManager.TryGetBuf<LightningHailBuf>!PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) AND UnityEngine.Object.op_Inequality(actarAction) AND attackNum lt 1 OR !PlayerAttackBase.IsBlank(this) AND (SkillBufferManager.TryGetBuf<LightningHailBuf>!PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) AND AbnormalStateManager.Contains(EnemyMobActionManagerBase.get_AbnormalStateManager(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target)), 6) AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND attackNum ge 1
- calls `LightningHailBuf..ctor` = `.ctor(Lv, Element, actarAction)` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND (SkillBufferManager.TryGetBuf<LightningHailBuf>!PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) AND UnityEngine.Object.op_Inequality(actarAction) AND attackNum ge 1 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND (SkillBufferManager.TryGetBuf<LightningHailBuf>!PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) AND UnityEngine.Object.op_Inequality(actarAction) AND attackNum lt 1 OR !PlayerAttackBase.IsBlank(this) AND (SkillBufferManager.TryGetBuf<LightningHailBuf>!PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) AND AbnormalStateManager.Contains(EnemyMobActionManagerBase.get_AbnormalStateManager(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target)), 6) AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND attackNum ge 1
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new LightningHailBuf, Id)` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND (SkillBufferManager.TryGetBuf<LightningHailBuf>!PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) AND UnityEngine.Object.op_Inequality(actarAction) AND attackNum ge 1 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND (SkillBufferManager.TryGetBuf<LightningHailBuf>!PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) AND UnityEngine.Object.op_Inequality(actarAction) AND attackNum lt 1 OR !PlayerAttackBase.IsBlank(this) AND (SkillBufferManager.TryGetBuf<LightningHailBuf>!PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) AND AbnormalStateManager.Contains(EnemyMobActionManagerBase.get_AbnormalStateManager(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target)), 6) AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND attackNum ge 1

**`OtherPlayerAttackStartReceive`** (22 paths)

- set `attackNum` = `(LoopParam - ((LoopParam // 100) * 100))`

**`calcPlayerToMobDamage`** (4 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- template `SetRate[ExpRate]` = `(target.ExpDefMagic / 100)`
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(987, 0, 0)`
- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(987)`
- info `templates` = `1`
- template `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**`NextRangeHit`** (2 paths)

- set `nowAttackCount` = `(nowAttackCount + 1)`

**`ActionSkillEventPreparation`** (5 paths)

- set `startNum` = `(startNum + 1)` — when param eq 100 AND startNum lo attackPosList.Length

**`ActionSkillEvent`** (7 paths)

- set `endNum` = `(endNum + 1)` — when endNum ge attackPosList.Length AND isThorHammer ne 0 AND param eq 101 AND param ne 102 OR endNum lo attackPosList.Length AND endNum lt attackPosList.Length AND isThorHammer ne 0 AND param eq 101 AND param ne 102

</details>

**Buffs**

**Buff `LightningHailBuf`**
- Buff hook methods: `AddEffect`, `ClearEffect`, `GetEffect`, `RemoveEffect`, `get_BufEffectTakeId`, `get_takeCount`

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Count | 3 | 4 | 4 | 5 | 5 | 6 | 6 | 7 | 7 | 8 |

- Buff fields set in the constructor (all recovered):
  - `takeList` = `new System.Collections.Generic.Dictionary<int, Vector3>`
  - `bufEffectTakeId` = `-1` = -1
  - `effectPos` = `UnityEngine.Vector3.static+0x0`
  - `effectPos.z` = `UnityEngine.Vector3.static+0x8`
  - `playerAction` = `playerAction`
- Hook `AddEffect`: `bufEffectTakeId`=0x11e69c74
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:LightningHailBuf$$.ctor<-LightningHailAction$$ActionStart` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

---

### ดราโกนิกชาร์จ (DragonicCharge) · uid 976

<img src="../../icons/sk_976.png" width="40" alt="icon"> 
**Tree:** ハルバードスキル (`HalberdSkill`, tier 5) · **Type:** Attack · **Max Lv:** 240 · **Weapons:** Halberd · **Requires:** ดราก้อนทูธ · **Client class:** `DragonicChargeAction`

> ปลดปล่อยความพิโรธแห่งมังกร
> จะใช้งานต่อเมื่อชาร์จจนเต็มหรือมีการเคลื่อนไหว
> การสะสมจะมากขึ้นเมื่อสัมผัสได้ถึงอันตรายขณะชาร์จ
> 
> ระวังจะโจมตีพลาดเป้าเพราะระยะจู่โจมมีเพียง 8 เมตรเท่านั้น

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 5.5 | 6 | 6.5 | 7 | 7.5 | 8 | 8.5 | 9 | 9.5 | 10 |
| Flat dmg + | 30 | 60 | 90 | 120 | 150 | 180 | 210 | 240 | 270 | 300 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((((0) eq 0 ? (((Lv * 50) + 500)) : (((Lv * 50) + 500))) * ((((([_currentSkillCombo+0x18]) + (([_currentSkillCombo+0x18]) << 2))) / 100) + 1)) / 100)`
- SkillRate × `((((0) eq 0 ? (((Lv * 50) + 500)) : (((Lv * 50) + 500))) * ((((([_currentSkillCombo+0x18]) + (([_currentSkillCombo+0x18]) << 2))) / 100) + 1)) / 100)`
- SkillRate × `((((0) eq 0 ? (((Lv * 50) + 500)) : (((Lv * 50) + 500))) * ((((([_currentSkillCombo+0x18]) + (([_currentSkillCombo+0x18]) << 2))) / 100) + 1)) / 100)` — (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x))) ls (MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)) * MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param))) AND ActionRange ne -1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 976) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x))) hi (MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)) * MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param))) AND ActionRange ne -1 AND MathUtil.DisplayMeterToDistance((((SkillBufferDataBase.GetParam(20) * 8) * 0.01) + 8)) gt 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 976) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x))) hi (MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)) * MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param))) AND ActionRange ne -1 AND MathUtil.DisplayMeterToDistance((((SkillBufferDataBase.GetParam(20) * 8) * 0.01) + 8)) le 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 976) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05

**Role:** attack (deals damage) · buff (self) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` sets: `((0) eq 0 ? ((Lv * 30)) : (300))`
- `Def` sets: `-int(((1 - min((((((((((((int(MathUtil.DistanceToDisplayMeter(MobActionManagerBase.get_PlayerDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)))) + (int(MathUtil.DistanceToDisplayMeter(MobActionManagerBase.get_PlayerDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)))) << 2)) << 1) << 1) lt 100 ? (((int(MathUtil.DistanceToDisplayMeter(MobActionManagerBase.get_PlayerDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)))) + (int(MathUtil.DistanceToDisplayMeter(MobActionManagerBase.get_PlayerDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)))) << 2)) << 1) << 1) : 100)) + PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51)) + DragonToothResistBreaker) lt 0 ? ((((((((int(MathUtil.DistanceToDisplayMeter(MobActionManagerBase.get_PlayerDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)))) + (int(MathUtil.DistanceToDisplayMeter(MobActionManagerBase.get_PlayerDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)))) << 2)) << 1) << 1) lt 100 ? (((int(MathUtil.DistanceToDisplayMeter(MobActionManagerBase.get_PlayerDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)))) + (int(MathUtil.DistanceToDisplayMeter(MobActionManagerBase.get_PlayerDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)))) << 2)) << 1) << 1) : 100)) + PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51)) + DragonToothResistBreaker) + 1) : (((((((int(MathUtil.DistanceToDisplayMeter(MobActionManagerBase.get_PlayerDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)))) + (int(MathUtil.DistanceToDisplayMeter(MobActionManagerBase.get_PlayerDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)))) << 2)) << 1) << 1) lt 100 ? (((int(MathUtil.DistanceToDisplayMeter(MobActionManagerBase.get_PlayerDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)))) + (int(MathUtil.DistanceToDisplayMeter(MobActionManagerBase.get_PlayerDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)))) << 2)) << 1) << 1) : 100)) + PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51)) + DragonToothResistBreaker)) >> 1) gt (DragonToothResistBreaker + PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 52)) ? ((((powerRegist + PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51)) + DragonToothResistBreaker) lt 0 ? (((powerRegist + PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51)) + DragonToothResistBreaker) + 1) : ((powerRegist + PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51)) + DragonToothResistBreaker)) >> 1) : (DragonToothResistBreaker + PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 52))) / 100), 1)) * IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction))))` | `-int(IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)))`
- `SkillRate` sets: `((((0) eq 0 ? (((Lv * 50) + 500)) : (((Lv * 50) + 500))) * ((((([_currentSkillCombo+0x18]) + (([_currentSkillCombo+0x18]) << 2))) / 100) + 1)) / 100)`
- `ExpRate` sets: `(target.ExpDefSkill / 100)` | `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**Mechanics recovered from code**

- **Per-target multiplier (%)** (`targetSkillRate`): `((Lv * 50) + 500)` → Lv1..10 [550, 600, 650, 700, 750, 800, 850, 900, 950, 1000]
- **Range-dependent multiplier (%)** (`rangeSkillRate`): `((Lv * 50) + 500)` → Lv1..10 [550, 600, 650, 700, 750, 800, 850, 900, 950, 1000]
- **Chance to inflict the skill's status ailment (%)** (`abnormalPercent`): `(Lv * Lv)` → Lv1..10 [1, 4, 9, 16, 25, 36, 49, 64, 81, 100] _(when (System.Collections.Generic.Dictionary<Int32Enum, Int32Enum>.TryGetValue(selectAbnormalType, PlayerStatusBase.GetEquipElementPlayerActionManagerBase.get_PlayerStatus()), (this + 324), meta(0x39a8418, Method$System.Collections.Generic.Dictionary<ElementType, AbnormalType>.TryGetValue())) AND GemCartBufferManager.GetTalentElementType(PlayerStatusBase.get_GemCartBuffManager()) eq 0 OR (System.Collections.Generic.Dictionary<Int32Enum, Int32Enum>.TryGetValue(selectAbnormalType, GemCartBufferManager.GetTalentElementTypePlayerStatusBase.get_GemCartBuffManager()), (this + 324), meta(0x39a8418, Method$System.Collections.Generic.Dictionary<ElementType, AbnormalType>.TryGetValue())) AND GemCartBufferManager.GetTalentElementType(PlayerStatusBase.get_GemCartBuffManager()) ne 0)_
- **Loop / hit-repeat count** (`LoopParam`): `0` = 0; `1` = 1

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 976

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (4 paths)

- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `targetFixDamage` = `300` = 300
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(100)`
- set `rangeFixDamage` = `(Lv * 30)` → Lv1..10: [30, 60, 90, 120, 150, 180, 210, 240, 270, 300]
- set `targetSkillRate` = `((Lv * 50) + 500)` → Lv1..10: [550, 600, 650, 700, 750, 800, 850, 900, 950, 1000]
- set `rangeSkillRate` = `((Lv * 50) + 500)` → Lv1..10: [550, 600, 650, 700, 750, 800, 850, 900, 950, 1000]
- set `abnormalPercent` = `(Lv * Lv)` → Lv1..10: [1, 4, 9, 16, 25, 36, 49, 64, 81, 100] — when (System.Collections.Generic.Dictionary<Int32Enum, Int32Enum>.TryGetValue(selectAbnormalType, PlayerStatusBase.GetEquipElementPlayerActionManagerBase.get_PlayerStatus()), (this + 324), meta(0x39a8418, Method$System.Collections.Generic.Dictionary<ElementType, AbnormalType>.TryGetValue())) AND GemCartBufferManager.GetTalentElementType(PlayerStatusBase.get_GemCartBuffManager()) eq 0 OR (System.Collections.Generic.Dictionary<Int32Enum, Int32Enum>.TryGetValue(selectAbnormalType, GemCartBufferManager.GetTalentElementTypePlayerStatusBase.get_GemCartBuffManager()), (this + 324), meta(0x39a8418, Method$System.Collections.Generic.Dictionary<ElementType, AbnormalType>.TryGetValue())) AND GemCartBufferManager.GetTalentElementType(PlayerStatusBase.get_GemCartBuffManager()) ne 0

**`InitializeOthers`** (2 paths)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`

**`OtherPlayerAttackStartReceive`** (1 path)

- set `chargeValue` = `(SkillIndividualFlag + (SkillIndividualFlag << 2))`

**`ActionStart`** (3 paths)

- set `target` = `target`
- set `LoopParam` = `0` = 0
- set `chargeValue` = `([_currentSkillCombo+0x18] + ([_currentSkillCombo+0x18] << 2))`
- set `SkillIndividualFlag` = `[_currentSkillCombo+0x18]`
- set `LoopParam` = `1` = 1
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(976, Lv, 0)` — when !PlayerAttackBase.IsBlank(this)

**`SetTargetMobOthers`** (1 path)

- set `target` = `target`

**`OnSkillButton`** (1 path)

- set `chargeSkip` = `1` = 1

**`ActionSkillEventIfMoveIndex`** (18 paths)

- set `chargeSkip` = `0` = 0 — when !DragonicChargeBuf.get_IsAttackPermission(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 976)) AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 976) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `chargeSkip` = `1` = 1 — when ActionRange eq -1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) OR ActionRange ne -1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 976) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ActionRange ne -1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 976) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)

**`ActionSkillEvent`** (259 paths)

- set `powerRegist` = `((((int(MathUtil.DistanceToDisplayMeter(MobActionManagerBase.get_PlayerDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)))) + (int(MathUtil.DistanceToDisplayMeter(MobActionManagerBase.get_PlayerDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)))) << 2)) << 1) << 1) lt 100 ? (((int(MathUtil.DistanceToDisplayMeter(MobActionManagerBase.get_PlayerDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)))) + (int(MathUtil.DistanceToDisplayMeter(MobActionManagerBase.get_PlayerDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)))) << 2)) << 1) << 1) : 100)` — when (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x))) ls (MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)) * MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param))) AND ActionRange ne -1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 976) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x))) hi (MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)) * MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param))) AND ActionRange ne -1 AND MathUtil.DisplayMeterToDistance((((SkillBufferDataBase.GetParam(20) * 8) * 0.01) + 8)) gt 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 976) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x))) hi (MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)) * MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param))) AND ActionRange ne -1 AND MathUtil.DisplayMeterToDistance((((SkillBufferDataBase.GetParam(20) * 8) * 0.01) + 8)) le 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 976) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05
- set `chargeValue` = `SkillBufferDataBase.GetParam(20)` — when (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x))) ls (MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)) * MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param))) AND ActionRange ne -1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 976) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x))) hi (MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)) * MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param))) AND ActionRange ne -1 AND MathUtil.DisplayMeterToDistance((((SkillBufferDataBase.GetParam(20) * 8) * 0.01) + 8)) gt 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 976) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x))) hi (MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)) * MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param))) AND ActionRange ne -1 AND MathUtil.DisplayMeterToDistance((((SkillBufferDataBase.GetParam(20) * 8) * 0.01) + 8)) le 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 976) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05
- set `isFirstAtkHit` = `0` = 0 — when (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x))) hi (MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)) * MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param))) AND MathUtil.DisplayMeterToDistance((((chargeValue * 8) * 0.01) + 8)) gt 0 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x))) hi (MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)) * MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param))) AND MathUtil.DisplayMeterToDistance((((chargeValue * 8) * 0.01) + 8)) le 0 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x))) hi (MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)) * MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param))) AND MathUtil.DisplayMeterToDistance((((chargeValue * 8) * 0.01) + 8)) gt 0 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05
- set `isFirstAtkHit` = `1` = 1 — when (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x))) ls (MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)) * MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param))) OR !UnityEngine.Object.op_Inequality(actarAction) AND (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x))) ls (MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)) * MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param))) OR (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x))) ls (MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)) * MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param))) AND ActionRange ne -1 AND UnityEngine.Object.op_Inequality(actarAction)
- set `powerRegist` = `((int(MathUtil.DistanceToDisplayMeter(MobActionManagerBase.get_PlayerDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)))) + (int(MathUtil.DistanceToDisplayMeter(MobActionManagerBase.get_PlayerDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)))) << 2)) << 1)` — when (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x))) ls (MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)) * MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param))) OR !UnityEngine.Object.op_Inequality(actarAction) AND (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x))) ls (MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)) * MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param))) OR ActionRange ne -1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 976) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `chargeValue` = `0` = 0 — when (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x))) ls (MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)) * MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param))) AND ActionRange ne -1 AND UnityEngine.Object.op_Inequality(actarAction) OR (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x))) hi (MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)) * MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param))) AND ActionRange ne -1 AND MathUtil.DisplayMeterToDistance(8) gt 0 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x))) hi (MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param)) * MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target, param))) AND ActionRange ne -1 AND MathUtil.DisplayMeterToDistance(8) le 0 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05

**`OtherPlayerSkillEventReceive`** (3 paths)

- set `chargeSkip` = `1` = 1 — when (System.Collections.Generic.Dictionary<int, int>.ContainsKey(values, 48, meta(0x39823b0, Method$System.Collections.Generic.Dictionary<int, int>.ContainsKey()), values) & 1) ne 0 AND (skillEventId & 0xffff) eq 101 OR (System.Collections.Generic.Dictionary<int, int>.ContainsKey(values, 48, meta(0x39823b0, Method$System.Collections.Generic.Dictionary<int, int>.ContainsKey()), values) & 1) eq 0 AND (skillEventId & 0xffff) eq 101

**`calcPlayerToMobDamage`** (60 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)`
- template `SetRate[ExpRate]` = `(target.ExpDefSkill / 100)` — when isFirst ne 0 OR (IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)) & 0x80000000) eq 0 AND isFirst eq 0 OR (IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)) & 0x80000000) ne 0 AND isFirst eq 0
- template `SetRate[SkillRate]` = `(((isFirst eq 0 ? rangeSkillRate : targetSkillRate) * ((chargeValue / 100) + 1)) / 100)`
- template `SetConstant[SkillConstantDamage]` = `(isFirst eq 0 ? rangeFixDamage : targetFixDamage)`
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(987, 0, 0)` — when isFirst ne 0 OR (IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)) & 0x80000000) eq 0 AND isFirst eq 0 OR (IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)) & 0x80000000) ne 0 AND isFirst eq 0
- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(987)` — when isFirst ne 0 OR (IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)) & 0x80000000) eq 0 AND isFirst eq 0 OR (IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)) & 0x80000000) ne 0 AND isFirst eq 0
- info `templates` = `1`
- template `SetConstant[Def]` = `-int(((1 - min(((((((powerRegist + PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51)) + DragonToothResistBreaker) lt 0 ? (((powerRegist + PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51)) + DragonToothResistBreaker) + 1) : ((powerRegist + PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51)) + DragonToothResistBreaker)) >> 1) gt (DragonToothResistBreaker + PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 52)) ? ((((powerRegist + PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51)) + DragonToothResistBreaker) lt 0 ? (((powerRegist + PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51)) + DragonToothResistBreaker) + 1) : ((powerRegist + PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 51)) + DragonToothResistBreaker)) >> 1) : (DragonToothResistBreaker + PlayerStatusBase.GetBonusValueWithBuf(PlayerActionManagerBase.get_PlayerStatus(), 52))) / 100), 1)) * IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction))))` — when (IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)) & 0x80000000) eq 0 AND isFirst eq 0 OR (IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)) & 0x80000000) eq 0 AND abnormalType eq 0 AND isFirst eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, abnormalType, abnormalPercent, playerAction) AND (IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)) & 0x80000000) eq 0 AND abnormalType ne 0 AND isFirst eq 0
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(abnormalType, abnormalPercent, playerAction)` — when !PlayerAttackBase.checkAbnormalPercent(this, abnormalType, abnormalPercent, playerAction) AND (IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)) & 0x80000000) eq 0 AND abnormalType ne 0 AND isFirst eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, abnormalType, abnormalPercent, playerAction) AND (IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)) & 0x80000000) ne 0 AND abnormalType ne 0 AND isFirst eq 0 OR (IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)) & 0x80000000) eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, abnormalType, abnormalPercent, playerAction) AND abnormalType eq 5 AND abnormalType ne 0 AND isFirst eq 0
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(abnormalType, 0)` — when (IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)) & 0x80000000) eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, abnormalType, abnormalPercent, playerAction) AND abnormalType eq 5 AND abnormalType ne 0 AND isFirst eq 0 OR (IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)) & 0x80000000) eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, abnormalType, abnormalPercent, playerAction) AND abnormalType ne 0 AND abnormalType ne 5 AND isFirst eq 0 OR (IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)) & 0x80000000) ne 0 AND PlayerAttackBase.checkAbnormalPercent(this, abnormalType, abnormalPercent, playerAction) AND abnormalType eq 5 AND abnormalType ne 0 AND isFirst eq 0
- template `SetConstant[Def]` = `-int(IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)))` — when (IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)) & 0x80000000) ne 0 AND isFirst eq 0 OR (IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)) & 0x80000000) ne 0 AND abnormalType eq 0 AND isFirst eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, abnormalType, abnormalPercent, playerAction) AND (IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)) & 0x80000000) ne 0 AND abnormalType ne 0 AND isFirst eq 0
- template `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` — when isFirst ne 0 OR (IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)) & 0x80000000) eq 0 AND isFirst eq 0 OR (IMobStatusCalculator.CalcMdef(MobActionManagerBase.get_MobBattleStatus(mobAction)) & 0x80000000) ne 0 AND isFirst eq 0

**`NextRangeHit`** (2 paths)

- set `isFirst` = `0` = 0

**`.<>c__DisplayClass36_0::<ActionStart>b__0`** (1 path)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(976)`

</details>

**Buffs**

**Buff `DragonicChargeBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `StopCharge`, `WarnMobAttack`, `get_IsAttackPermission`, `get_IsCharge`, `get_IsWarnDetection`, `set_IsWarnDetection`
- `Count` = `int((0))`
- Buff fields set in the constructor (all recovered):
  - `chargeValue` = `0`
  - `isCharge` = `1` = 1
  - `time` = `0`
  - `Count` = `0`
  - `Max` = `100` = 100
  - `IsWarnDetection` = `0`
- Hook `set_IsWarnDetection`: `IsWarnDetection`=(value & 1)
- Hook `Updata`: `time`=(time + UnityEngine.Time.get_deltaTime()); `chargeValue`=min(((time + UnityEngine.Time.get_deltaTime()) / 0.05), 100); `Count`=int(min(((time + UnityEngine.Time.get_deltaTime()) / 0.05), 100))
- Hook `StopCharge`: `isCharge`=0
- Hook `WarnMobAttack`: `chargeValue`=100; `Count`=100; `IsWarnDetection`=1

<details><summary>Effect applied in `GuardActionManager$$CheckGuardStart` (98 guarded paths)</summary>

- when `CharacterActionManagerBase.get_IsLocalDead() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 976, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `0`
  - calls `GuardActionManager$$CheckGuardEquip`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `GuardActionManager$$CheckInBlackHole`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`
- when `CharacterActionManagerBase.get_IsLocalDead() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 976, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `0`
  - calls `GuardActionManager$$CheckGuardEquip`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `GuardActionManager$$CheckInBlackHole`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`
- when `CharacterActionManagerBase.get_IsLocalDead() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 976, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `0`
  - calls `GuardActionManager$$CheckGuardEquip`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `GuardActionManager$$CheckInBlackHole`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`
- when `CharacterActionManagerBase.get_IsLocalDead() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 976, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `0`
  - calls `GuardActionManager$$CheckGuardEquip`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `GuardActionManager$$CheckInBlackHole`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`
- when `CharacterActionManagerBase.get_IsLocalDead() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 976, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `0`
  - calls `GuardActionManager$$CheckGuardEquip`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `GuardActionManager$$CheckInBlackHole`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`
- when `CharacterActionManagerBase.get_IsLocalDead() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 976, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `0`
  - calls `GuardActionManager$$CheckGuardEquip`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `GuardActionManager$$CheckInBlackHole`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`
- when `CharacterActionManagerBase.get_IsLocalDead() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 976, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `0`
  - calls `GuardActionManager$$CheckGuardEquip`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `GuardActionManager$$CheckInBlackHole`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`
- when `CharacterActionManagerBase.get_IsLocalDead() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 976, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `0`
  - calls `GuardActionManager$$CheckGuardEquip`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `GuardActionManager$$CheckInBlackHole`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`

</details>

<details><summary>Effect applied in `DragonicChargeAction$$ActionSkillEvent` (4 guarded paths)</summary>

- when `ActionRange ne -1` AND `(SkillBufferManager.TryGetBuf(?blr, 976, stkp(-216), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `UnityEngine.Transform.set_rotation(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `powerRegist` = `((((int(MathUtil.DistanceToDisplayMeter(0, ?mi, ?x2, ?x3)) + (int(MathUtil.DistanceToDisplayMeter(0, ?mi, ?x2, ?x3)) << 2)) << 1) << 1) lt 100 ? (((int(MathUtil.DistanceToDisplayMeter(0, ?mi, ?x2, ?x3)) + (int(MathUtil.DistanceToDisplayMete`
  - set `chargeValue` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `isFirstAtkHit` = `1`
  - calls `UnityEngine.GameObject$$GetComponent<object>`, `interface MobActionManagerBase.get_PlayerDistance`, `MathUtil$$DistanceToDisplayMeter`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`
- when `ActionRange ne -1` AND `(SkillBufferManager.TryGetBuf(?blr, 976, stkp(-216), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `UnityEngine.Transform.set_rotation(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `powerRegist` = `((int(MathUtil.DistanceToDisplayMeter(0, ?mi, ?x2, ?x3)) + (int(MathUtil.DistanceToDisplayMeter(0, ?mi, ?x2, ?x3)) << 2)) << 1)`
  - set `chargeValue` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `isFirstAtkHit` = `1`
  - calls `UnityEngine.GameObject$$GetComponent<object>`, `interface MobActionManagerBase.get_PlayerDistance`, `MathUtil$$DistanceToDisplayMeter`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`
- when `ActionRange ne -1` AND `(SkillBufferManager.TryGetBuf(?blr, 976, stkp(-216), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - set `powerRegist` = `((int(MathUtil.DistanceToDisplayMeter(0, ?mi, ?x2, ?x3)) + (int(MathUtil.DistanceToDisplayMeter(0, ?mi, ?x2, ?x3)) << 2)) << 1)`
  - calls `UnityEngine.GameObject$$GetComponent<object>`, `interface MobActionManagerBase.get_PlayerDistance`, `MathUtil$$DistanceToDisplayMeter`, `0x165db84`
- when `ActionRange ne -1` AND `(SkillBufferManager.TryGetBuf(?blr, 976, stkp(-216), 0) & 1) eq 0`
  - returns `UnityEngine.Transform.set_rotation(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `powerRegist` = `((int(MathUtil.DistanceToDisplayMeter(0, ?mi, ?x2, ?x3)) + (int(MathUtil.DistanceToDisplayMeter(0, ?mi, ?x2, ?x3)) << 2)) << 1)`
  - set `chargeValue` = `0`
  - set `isFirstAtkHit` = `1`
  - calls `UnityEngine.GameObject$$GetComponent<object>`, `interface MobActionManagerBase.get_PlayerDistance`, `MathUtil$$DistanceToDisplayMeter`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_transform`

</details>

<details><summary>Effect applied in `PlayerActionManagerBase$$InMobAttackArea` (3 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 976, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `DragonicChargeBuf.WarnMobAttack(TryGetBuf.out2(), 0, ?x2, ?x3)`
  - set `attentionTime` = `3`
  - calls `DragonicChargeBuf$$WarnMobAttack`
- when `(SkillBufferManager.TryGetBuf(?blr, 976, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - set `attentionTime` = `3`
  - calls `0x165db84`
- when `(SkillBufferManager.TryGetBuf(?blr, 976, stkp(-24), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 976, stkp(-24), 0)`
  - set `attentionTime` = `3`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `DragonicChargeAction$$ActionSkillEvent (TryGetBuf)`
- `DragonicChargeAction$$ActionSkillEventIfMoveIndex (TryGetBuf)`
- `GuardActionManager$$CheckGuardStart (TryGetBuf)`
- `PlayerActionManagerBase$$InMobAttackArea (TryGetBuf)`

---

### อินฟิไนท์ไดเมนชัน (DimensionTill) · uid 977

<img src="../../icons/sk_977.png" width="40" alt="icon"> 
**Tree:** ハルバードスキル (`HalberdSkill`, tier 5) · **Type:** Object · **Max Lv:** 240 · **Weapons:** Halberd · **Requires:** โครนอสไดรฟ์ · **Client class:** `DimensionTillAction`

> โจมตีซ้ำๆ ด้วยหอกผ่านห้วงมิติแห่งเวลา
> ทำการโจมตีซ้ำๆ เป็นวงกว้างรอบเป้าหมาย
> มีโอกาสทำให้ติดสภาวะ[ตาพร่า]
> ถ้ามีผลของโครนอสไดรฟ์อยู่จะเพิ่มการฟื้นฟู MP

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 20 | 40 | 60 | 80 | 100 | 120 | 140 | 160 | 180 | 200 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((((baseAGI + baseSTR) // 5) + 400)) / 100)` — (hitCount - ((hitCount // splitHitCount) * splitHitCount)) eq 0 OR (hitCount - ((hitCount // splitHitCount) * splitHitCount)) eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, 33, flashPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 33, flashPercent, playerAction) AND (hitCount - ((hitCount // splitHitCount) * splitHitCount)) eq 0

**Role:** attack (deals damage) · applies status ailment · placed object / trap / summon

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; never (IsExpDefFluctuate=false)

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` sets: `(((Lv + (Lv << 2)) << 2))`
- `SkillRate` sets: `(((((baseAGI + baseSTR) // 5) + 400)) / 100)`

**Mechanics recovered from code**

- **Loop / hit-repeat count** (`LoopParam`): `motionSpeed`
- **Hit count** (`hitCount`): `(hitCount + 1)`

**Proration:** slot `Skill`, mode `never (IsExpDefFluctuate=false)`, attack type `Physics`, action id 977

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`
- set `skillRate` = `(((baseAGI + baseSTR) // 5) + 400)`
- set `fixAddDamage` = `((Lv + (Lv << 2)) << 2)` → Lv1..10: [20, 40, 60, 80, 100, 120, 140, 160, 180, 200]
- set `flashPercent` = `((((baseAGI * 0x66666667) >> 32) >> 2) + (Lv + (Lv << 2)))`

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `LoopParam` = `motionSpeed`
- set `placePosition` = `castTime`
- set `ActionRange` = `-1` = -1
- set `arrowAngle` = `90` = 90
- set `arrowEventTake` = `new SkillLinkedTake`

**`ActionStart`** (1 path)

- set `placePosition` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x`
- set `placePosition.y` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y`
- set `placePosition.z` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z`
- set `targetAction` = `UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)`
- set `arrowAngle` = `90` = 90
- set `arrowEventTake` = `new SkillLinkedTake`

**`ActionSkillEvent`** (3 paths)

- set `arrowAngle` = `(((arrowAngle + 250) gt 360 ? 0xfffffe98 : 0) + (arrowAngle + 250))` — when (System.Collections.Generic.Dictionary<Int16Enum, int>.ContainsKey(arrowEventTake._parameter, 24, meta(0x399f6c8, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.ContainsKey())) & 1) ne 0 AND param eq 1 OR (System.Collections.Generic.Dictionary<Int16Enum, int>.ContainsKey(arrowEventTake._parameter, 24, meta(0x399f6c8, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.ContainsKey())) & 1) eq 0 AND param eq 1

**`calcPlayerToMobDamage`** (10 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)` — when (hitCount - ((hitCount // splitHitCount) * splitHitCount)) eq 0 OR (hitCount - ((hitCount // splitHitCount) * splitHitCount)) eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, 33, flashPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 33, flashPercent, playerAction) AND (hitCount - ((hitCount // splitHitCount) * splitHitCount)) eq 0
- template `SetRate[SkillRate]` = `(skillRate / 100)` — when (hitCount - ((hitCount // splitHitCount) * splitHitCount)) eq 0 OR (hitCount - ((hitCount // splitHitCount) * splitHitCount)) eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, 33, flashPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 33, flashPercent, playerAction) AND (hitCount - ((hitCount // splitHitCount) * splitHitCount)) eq 0
- template `SetConstant[SkillConstantDamage]` = `fixAddDamage` — when (hitCount - ((hitCount // splitHitCount) * splitHitCount)) eq 0 OR (hitCount - ((hitCount // splitHitCount) * splitHitCount)) eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, 33, flashPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 33, flashPercent, playerAction) AND (hitCount - ((hitCount // splitHitCount) * splitHitCount)) eq 0
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(33, flashPercent, playerAction)` — when (hitCount - ((hitCount // splitHitCount) * splitHitCount)) eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, 33, flashPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 33, flashPercent, playerAction) AND (hitCount - ((hitCount // splitHitCount) * splitHitCount)) eq 0
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(33, 0)` — when (hitCount - ((hitCount // splitHitCount) * splitHitCount)) eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, 33, flashPercent, playerAction)
- info `templates` = `1` — when (hitCount - ((hitCount // splitHitCount) * splitHitCount)) eq 0 OR (hitCount - ((hitCount // splitHitCount) * splitHitCount)) eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, 33, flashPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 33, flashPercent, playerAction) AND (hitCount - ((hitCount // splitHitCount) * splitHitCount)) eq 0

**`ActionHit`** (1 path)

- set `isCronosDriveBuf` = `(hasBuff(973) & 1)`
- set `hitCount` = `(hitCount + 1)`

</details>

---

### ออลไมทีวีลด์ (GodSpearHandling) · uid 978

<img src="../../icons/sk_978.png" width="40" alt="icon"> 
**Tree:** ハルバードスキル (`HalberdSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 240 · **Weapons:** Halberd · **Requires:** เทพลมกรด · **Client class:** `GodSpearHandlingMastary` (passive mastery)

> ลดปริมาณการลดลงของค่าต้านทานต่างๆ ที่เกิดจากสกิล[เทพลมกรด]
> เมื่อได้รับความเสียหายมีโอกาสคงกระพัน(ขึ้นอยู่กับค่าAGI)
> (เกิดขึ้นได้ไม่เกิน 1 ครั้งต่อ 10 วินาที)
> เพิ่มพลังโจมตีกายภาพของสกิลหอกวายุ

<details><summary>In-game level notes</summary>

- Lv9: เมื่อเรียนรู้ Lv 1 จะสามารถใช้ "ออลไมทีวีลด์III" ได้ เมื่อเรียนรู้ Lv 5 จะสามารถใช้ "ออลไมทีวีลด์II" ได้ เมื่อเรียนรู้ Lv 10 จะสามารถใช้ "ออลไมทีวีลด์I" ได้  เมื่อใช้IIจะใช้เทพลมกรดได้ 2 ครั้ง ทันทีถึงจะใช้ซ้ำก็ไม่สะสมเพิ่ม สามารถใช้Iหลังใช้IIเพื่อลดเอฟเฟกต์ได้

</details>

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| LastDmgRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


<details><summary>Effect applied in `GodSpearHandling1Action$$IsFailure` (8 guarded paths)</summary>

- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 9` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 9` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `0`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 9` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `(PlayerAttackBase.IsFailure(this, status, missType, 0) & 1)`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 9` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 9` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) eq 0` AND `IPlayerStatusCalculator.get_MaxMp(PlayerStatusBase.get_SecondaryStatus()) lt 100`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_GameStatus`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 9` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) eq 0` AND `IPlayerStatusCalculator.get_MaxMp(PlayerStatusBase.get_SecondaryStatus()) lt 100`
  - returns `0`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_GameStatus`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 9` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) eq 0` AND `IPlayerStatusCalculator.get_MaxMp(PlayerStatusBase.get_SecondaryStatus()) ge 100`
  - returns `(PlayerAttackBase.IsFailure(this, status, missType, 0) & 1)`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `PlayerAttackBase$$IsFailure`
- when `SkillLv(974) gt 0` AND `SkillLv(978) le 9`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`

</details>

<details><summary>Effect applied in `GodSpearHandling2Action$$IsFailure` (8 guarded paths)</summary>

- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 4` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 4` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `0`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 4` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `(PlayerAttackBase.IsFailure(this, status, missType, 0) & 1)`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 4` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 4` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) eq 0` AND `IPlayerStatusCalculator.get_MaxMp(PlayerStatusBase.get_SecondaryStatus()) lt 200`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_GameStatus`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 4` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) eq 0` AND `IPlayerStatusCalculator.get_MaxMp(PlayerStatusBase.get_SecondaryStatus()) lt 200`
  - returns `0`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_GameStatus`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 4` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) eq 0` AND `IPlayerStatusCalculator.get_MaxMp(PlayerStatusBase.get_SecondaryStatus()) ge 200`
  - returns `(PlayerAttackBase.IsFailure(this, status, missType, 0) & 1)`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `PlayerAttackBase$$IsFailure`
- when `SkillLv(974) gt 0` AND `SkillLv(978) le 4`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`

</details>

<details><summary>Effect applied in `GodSpearHandling3Action$$IsFailure` (8 guarded paths)</summary>

- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `0`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `(PlayerAttackBase.IsFailure(this, status, missType, 0) & 1)`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) eq 0` AND `IPlayerStatusCalculator.get_MaxMp(PlayerStatusBase.get_SecondaryStatus()) lt 300`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_GameStatus`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) eq 0` AND `IPlayerStatusCalculator.get_MaxMp(PlayerStatusBase.get_SecondaryStatus()) lt 300`
  - returns `0`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_GameStatus`
- when `SkillLv(974) gt 0` AND `SkillLv(978) gt 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 974, stkp(-56), 0) & 1) eq 0` AND `IPlayerStatusCalculator.get_MaxMp(PlayerStatusBase.get_SecondaryStatus()) ge 300`
  - returns `(PlayerAttackBase.IsFailure(this, status, missType, 0) & 1)`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxMp`, `PlayerAttackBase$$IsFailure`
- when `SkillLv(974) gt 0` AND `SkillLv(978) le 0`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`

</details>

<details><summary>Effect applied in `SkillManager$$GetAvailableSkill` (15 guarded paths)</summary>

- when `skillId ge 33` AND `(skillId & 0xffff) ne 1247` AND `((skillId & 0xffff) - 989) lo 3` AND `(System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue(availableSkillList, 978, stkp(-112), meta(0x3982618, Method$System.Collections.Generic.Dictionary<SkillId, SkillData>.TryGetValue())) & 1) eq 0`
  - returns `0`
  - calls `SkillUtil$$CheckSkillEquipLimit`, `SkillFactory$$CreateSkill`, `0x165d8dc`
- when `skillId ge 33` AND `(skillId & 0xffff) ne 1247` AND `((skillId & 0xffff) - 989) lo 3` AND `(System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue(availableSkillList, 978, stkp(-112), meta(0x3982618, Method$System.Collections.Generic.Dictionary<SkillId, SkillData>.TryGetValue())) & 1) eq 0`
  - returns `0`
  - calls `SkillUtil$$CheckSkillEquipLimit`, `SkillFactory$$CreateSkill`
- when `skillId ge 33` AND `(skillId & 0xffff) ne 1247` AND `((skillId & 0xffff) - 989) lo 3` AND `(System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue(availableSkillList, 978, stkp(-112), meta(0x3982618, Method$System.Collections.Generic.Dictionary<SkillId, SkillData>.TryGetValue())) & 1) eq 0`
  - returns `0`
  - calls `SkillUtil$$CheckSkillEquipLimit`
- when `skillId ge 33` AND `(skillId & 0xffff) ne 1247` AND `((skillId & 0xffff) - 989) lo 3` AND `(System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue(availableSkillList, 978, stkp(-112), meta(0x3982618, Method$System.Collections.Generic.Dictionary<SkillId, SkillData>.TryGetValue())) & 1) eq 0`
  - calls `0x165db84`, `0x165db84`, `0x165df00`, `System.Collections.Generic.List.Enumerator<object>$$Dispose`, `0x165db7c`, `0x14cfadc`
- when `skillId ge 33` AND `(skillId & 0xffff) ne 1247` AND `((skillId & 0xffff) - 989) lo 3` AND `(System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue(availableSkillList, 978, stkp(-112), meta(0x3982618, Method$System.Collections.Generic.Dictionary<SkillId, SkillData>.TryGetValue())) & 1) eq 0`
  - returns `0`
- when `skillId ge 33` AND `(skillId & 0xffff) ne 1247` AND `((skillId & 0xffff) - 989) lo 3` AND `(System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue(availableSkillList, 978, stkp(-112), meta(0x3982618, Method$System.Collections.Generic.Dictionary<SkillId, SkillData>.TryGetValue())) & 1) eq 0`
  - returns `0`
  - calls `SkillUtil$$CheckSkillEquipLimit`, `SkillFactory$$CreateSkill`, `0x165d8dc`
- when `skillId ge 33` AND `(skillId & 0xffff) ne 1247` AND `((skillId & 0xffff) - 989) lo 3` AND `(System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue(availableSkillList, 978, stkp(-112), meta(0x3982618, Method$System.Collections.Generic.Dictionary<SkillId, SkillData>.TryGetValue())) & 1) eq 0`
  - returns `0`
  - calls `SkillUtil$$CheckSkillEquipLimit`, `SkillFactory$$CreateSkill`
- when `skillId ge 33` AND `(skillId & 0xffff) ne 1247` AND `((skillId & 0xffff) - 989) lo 3` AND `(System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue(availableSkillList, 978, stkp(-112), meta(0x3982618, Method$System.Collections.Generic.Dictionary<SkillId, SkillData>.TryGetValue())) & 1) eq 0`
  - returns `0`
  - calls `SkillUtil$$CheckSkillEquipLimit`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `GodSpearHandling1Action$$IsFailure (GetSkillLv)`
- `GodSpearHandling2Action$$IsFailure (GetSkillLv)`
- `GodSpearHandling3Action$$IsFailure (GetSkillLv)`
- `SkillManager$$GetAvailableSkill (GetSkillLv)`
- `UIComboWindow$$Initialize (GetSkillLv)`
- `UIComboWindow$$SetSkillTreeButton (GetSkillLv)`

---

### ทอร์นาโดแลนซ์ (TornadoLance) · uid 979

<img src="../../icons/sk_979.png" width="40" alt="icon"> 
**Tree:** ハルバードスキル (`HalberdSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 240 · **Weapons:** Halberd · **Requires:** คริติคอลสเปียร์ · **Client class:** `TornadoLanceMastary` (passive mastery)

> ได้รับพลังทอร์นาโด 1 หน่วย
> เมื่อโจมตีเข้าเป้าด้วยฮัลเบิร์ทสกิล
> 
> ยิ่งชาร์จพลังทอร์นาโดหอกวายุก็จะยิ่งแข็งแกร่ง
> พลังทอร์นาโดจะหายไปครึ่งหนึ่งหากถูกโจมตี

<details><summary>In-game level notes</summary>

- Lv9: [พลังทอร์นาโด] ยิ่งสะสมได้มาเท่าไหร่ก็จะยิ่งเพิ่มรับประกันการโจมตีของหอกวายุ อัตราการโจมตีเพิ่มและโจมตีคริติคอล  เมื่อสูญเสียพลังทอร์นาโดตอนโดนโจมตี อัตราหลบหลีกจะเพิ่มขึ้นตามค่าที่สูญเสียไป

</details>

**Role:** buff (self) · passive mastery

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Buffs**

**Buff `TornadoLanceBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `CheckHitMobAttack`, `Next`, `NextStack`, `get_CorrectHit`
- Duration: `100` s
- `Percent` = `int(((2.5) * (count)))` _(when BuffEffectActive ne 0)_
- `CrtDamageUp` = `int((crtDamageUp * (count)))` _(when BuffEffectActive ne 0)_
- `Count` = `(count)` _(when BuffEffectActive ne 0)_
- `FleeRate` = `(((count) + ((count) << 2)) << 1)` _(when BuffEffectActive ne 0)_
- Buff fields set in the constructor (all recovered):
  - `Count` = `count`
  - `pursuitPercent` = `2.5` = 2.5
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
- Hook `Next`: `LeftTime`=100
- Hook `CheckHitMobAttack`: `Count`=((Count lt 0 ? (Count + 1) : Count) >> 1)

<details><summary>Effect applied in `MobaPlayerSecondaryStatus$$get_CriticalDmg` (38 guarded paths)</summary>

- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) ne 0`
  - returns `(((int(((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3())))) - 300) gt 0 ? ((((int(((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3())))) - 300) >> 1) + 300) : (int(((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) + (`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) ne 0`
  - returns `(((int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3())))) - 300) gt 0 ? ((((int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3())))) - 300) >> 1) + 300) : (int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) ne 0`
  - returns `(((int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3())))) - 300) gt 0 ? ((((int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3())))) - 300) >> 1) + 300) : (int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3)`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) ne 0`
  - returns `(((int(((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3())))) - 300) gt 0 ? ((((int(((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3())))) - 300) >> 1) + 300) : (int(((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) eq 0`
  - returns `(((int(((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))) - 300) gt 0 ? ((((int(((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))) - 300) >> 1) + 300) : (int(((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, `
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) eq 0`
  - returns `(((int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))) - 300) gt 0 ? ((((int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))) - 300) >> 1) + 300) : (int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManager`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) eq 0`
  - returns `(((int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))) - 300) gt 0 ? ((((int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))) - 300) >> 1) + 300) : (int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBas`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) eq 0`
  - returns `(((int(((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))) - 300) gt 0 ? ((((int(((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))) - 300) >> 1) + 300) : (int(((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`

</details>

<details><summary>Effect applied in `PlayerSecondaryStatus$$CalcCriticalDmg` (38 guarded paths)</summary>

- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) ne 0`
  - returns `(int(((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((PlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) ne 0`
  - returns `(int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((PlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) ne 0`
  - returns `(int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((PlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) ne 0`
  - returns `(int(((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) * (((PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((PlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) eq 0`
  - returns `(int(((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((PlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3())))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) eq 0`
  - returns `(int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((PlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3())))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) eq 0`
  - returns `(int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((PlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3())))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) eq 0`
  - returns `(int(((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) * (((PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((PlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3())))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`

</details>

<details><summary>Effect applied in `PlayerAttackBase$$CalcStable` (10 guarded paths)</summary>

- when `type hs 2` AND `type eq 3` AND `(correctHit & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 712, stkp(-48), 0) & 1) ne 0`
  - returns `SkillActionBase.CalcStablePercent((CharacterActionManagerBase.set_DefaultMoveSpeed() + (int(((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) / 100) * int((((correctHit & 1) ne 0 ? 0.5 : 1) * stableSource)))) + int((((correctHit & 1) ne 0 ? 0.5 : 1) * stableSource)))), 0, ?mi, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillActionBase$$CalcStablePercent`
- when `type hs 2` AND `type eq 3` AND `(correctHit & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 712, stkp(-48), 0) & 1) ne 0`
  - returns `SkillActionBase.CalcStablePercent((int(((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) / 100) * int((((correctHit & 1) ne 0 ? 0.5 : 1) * stableSource)))) + int((((correctHit & 1) ne 0 ? 0.5 : 1) * stableSource))), 0, ?x2, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillActionBase$$CalcStablePercent`
- when `type hs 2` AND `type eq 3` AND `(correctHit & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 712, stkp(-48), 0) & 1) eq 0`
  - returns `SkillActionBase.CalcStablePercent((CharacterActionManagerBase.set_DefaultMoveSpeed() + int((((correctHit & 1) ne 0 ? 0.5 : 1) * stableSource))), 0, ?mi, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillActionBase$$CalcStablePercent`
- when `type hs 2` AND `type eq 3` AND `(correctHit & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 712, stkp(-48), 0) & 1) eq 0`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
- when `type hs 2` AND `type eq 3` AND `(correctHit & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 712, stkp(-48), 0) & 1) eq 0`
  - returns `SkillActionBase.CalcStablePercent(int((((correctHit & 1) ne 0 ? 0.5 : 1) * stableSource)), 0, ?x2, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillActionBase$$CalcStablePercent`
- when `type lo 2` AND `(correctHit & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 712, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `SkillActionBase.CalcStablePercent((CharacterActionManagerBase.set_DefaultMoveSpeed() + (int(((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) / 100) * int((((correctHit & 1) ne 0 ? 0.5 : 1) * stableSource)))) + int((((correctHit & 1) ne 0 ? 0.5 : 1) * stableSource)))), 0, ?mi, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillActionBase$$CalcStablePercent`
- when `type lo 2` AND `(correctHit & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 712, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `SkillActionBase.CalcStablePercent((int(((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) / 100) * int((((correctHit & 1) ne 0 ? 0.5 : 1) * stableSource)))) + int((((correctHit & 1) ne 0 ? 0.5 : 1) * stableSource))), 0, ?x2, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillActionBase$$CalcStablePercent`
- when `type lo 2` AND `(correctHit & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 712, stkp(-48), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 979, stkp(-48), 0) & 1) ne 0`
  - returns `SkillActionBase.CalcStablePercent((CharacterActionManagerBase.set_DefaultMoveSpeed() + int((((correctHit & 1) ne 0 ? 0.5 : 1) * stableSource))), 0, ?mi, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillActionBase$$CalcStablePercent`

</details>

<details><summary>Effect applied in `MagicPursuit$$Calc` (30 guarded paths)</summary>

- when `IsValid ne 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 979, stkp(-80), 0) & 1) ne 0` AND `IPlayerStatusCalculator.get_Atk(?blr) lt IPlayerStatusCalculator.get_Matk(?blr)`
  - returns `1`
  - calls `virtual CharacterActionManagerBase.get_Size`, `interface IPlayerStatusCalculator.get_Atk`, `interface IPlayerStatusCalculator.get_Matk`, `SkillBufferDataBase$$GetParam`, `MathUtil$$CheckPercent`, `interface MobActionManagerBase.get_gameObject`, `virtual MagicPursuit.get_BonusType`, `PlayerBattleManager$$EquipBuffAttack`
- when `IsValid ne 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 979, stkp(-80), 0) & 1) ne 0` AND `IPlayerStatusCalculator.get_Atk(?blr) lt IPlayerStatusCalculator.get_Matk(?blr)`
  - returns `1`
  - calls `virtual CharacterActionManagerBase.get_Size`, `interface IPlayerStatusCalculator.get_Atk`, `interface IPlayerStatusCalculator.get_Matk`, `SkillBufferDataBase$$GetParam`, `MathUtil$$CheckPercent`, `interface MobActionManagerBase.get_gameObject`
- when `IsValid ne 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 979, stkp(-80), 0) & 1) ne 0` AND `IPlayerStatusCalculator.get_Atk(?blr) lt IPlayerStatusCalculator.get_Matk(?blr)`
  - returns `0`
  - calls `virtual CharacterActionManagerBase.get_Size`, `interface IPlayerStatusCalculator.get_Atk`, `interface IPlayerStatusCalculator.get_Matk`, `SkillBufferDataBase$$GetParam`, `MathUtil$$CheckPercent`
- when `IsValid ne 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 979, stkp(-80), 0) & 1) ne 0` AND `IPlayerStatusCalculator.get_Atk(?blr) lt IPlayerStatusCalculator.get_Matk(?blr)`
  - calls `virtual CharacterActionManagerBase.get_Size`, `interface IPlayerStatusCalculator.get_Atk`, `interface IPlayerStatusCalculator.get_Matk`, `0x165db84`
- when `IsValid ne 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 979, stkp(-80), 0) & 1) ne 0` AND `IPlayerStatusCalculator.get_Atk(?blr) ge IPlayerStatusCalculator.get_Matk(?blr)`
  - returns `1`
  - calls `virtual CharacterActionManagerBase.get_Size`, `interface IPlayerStatusCalculator.get_Atk`, `interface IPlayerStatusCalculator.get_Matk`, `MathUtil$$CheckPercent`, `interface MobActionManagerBase.get_gameObject`, `virtual MagicPursuit.get_BonusType`, `PlayerBattleManager$$EquipBuffAttack`
- when `IsValid ne 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 979, stkp(-80), 0) & 1) ne 0` AND `IPlayerStatusCalculator.get_Atk(?blr) ge IPlayerStatusCalculator.get_Matk(?blr)`
  - returns `1`
  - calls `virtual CharacterActionManagerBase.get_Size`, `interface IPlayerStatusCalculator.get_Atk`, `interface IPlayerStatusCalculator.get_Matk`, `MathUtil$$CheckPercent`, `interface MobActionManagerBase.get_gameObject`
- when `IsValid ne 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 979, stkp(-80), 0) & 1) ne 0` AND `IPlayerStatusCalculator.get_Atk(?blr) ge IPlayerStatusCalculator.get_Matk(?blr)`
  - returns `0`
  - calls `virtual CharacterActionManagerBase.get_Size`, `interface IPlayerStatusCalculator.get_Atk`, `interface IPlayerStatusCalculator.get_Matk`, `MathUtil$$CheckPercent`
- when `IsValid ne 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 979, stkp(-80), 0) & 1) eq 0`
  - returns `1`
  - calls `virtual CharacterActionManagerBase.get_Size`, `MathUtil$$CheckPercent`, `interface MobActionManagerBase.get_gameObject`, `virtual MagicPursuit.get_BonusType`, `PlayerBattleManager$$EquipBuffAttack`

</details>

<details><summary>Effect applied in `PhysicalPursuit$$Calc` (60 guarded paths)</summary>

- when `IsValid ne 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 979, stkp(-80), 0) & 1) ne 0` AND `IPlayerStatusCalculator.get_Atk(?blr) ge IPlayerStatusCalculator.get_Matk(?blr)`
  - returns `1`
  - calls `virtual CharacterActionManagerBase.get_Size`, `SkillBufferDataBase$$GetParam`, `interface IPlayerStatusCalculator.get_Atk`, `interface IPlayerStatusCalculator.get_Matk`, `SkillBufferDataBase$$GetParam`, `MathUtil$$CheckPercent`, `interface MobActionManagerBase.get_gameObject`, `virtual PhysicalPursuit.get_BonusType`
- when `IsValid ne 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 979, stkp(-80), 0) & 1) ne 0` AND `IPlayerStatusCalculator.get_Atk(?blr) ge IPlayerStatusCalculator.get_Matk(?blr)`
  - returns `1`
  - calls `virtual CharacterActionManagerBase.get_Size`, `SkillBufferDataBase$$GetParam`, `interface IPlayerStatusCalculator.get_Atk`, `interface IPlayerStatusCalculator.get_Matk`, `SkillBufferDataBase$$GetParam`, `MathUtil$$CheckPercent`, `interface MobActionManagerBase.get_gameObject`
- when `IsValid ne 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 979, stkp(-80), 0) & 1) ne 0` AND `IPlayerStatusCalculator.get_Atk(?blr) ge IPlayerStatusCalculator.get_Matk(?blr)`
  - returns `0`
  - calls `virtual CharacterActionManagerBase.get_Size`, `SkillBufferDataBase$$GetParam`, `interface IPlayerStatusCalculator.get_Atk`, `interface IPlayerStatusCalculator.get_Matk`, `SkillBufferDataBase$$GetParam`, `MathUtil$$CheckPercent`
- when `IsValid ne 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 979, stkp(-80), 0) & 1) ne 0` AND `IPlayerStatusCalculator.get_Atk(?blr) ge IPlayerStatusCalculator.get_Matk(?blr)`
  - calls `virtual CharacterActionManagerBase.get_Size`, `SkillBufferDataBase$$GetParam`, `interface IPlayerStatusCalculator.get_Atk`, `interface IPlayerStatusCalculator.get_Matk`, `0x165db84`
- when `IsValid ne 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 979, stkp(-80), 0) & 1) ne 0` AND `IPlayerStatusCalculator.get_Atk(?blr) lt IPlayerStatusCalculator.get_Matk(?blr)`
  - returns `1`
  - calls `virtual CharacterActionManagerBase.get_Size`, `SkillBufferDataBase$$GetParam`, `interface IPlayerStatusCalculator.get_Atk`, `interface IPlayerStatusCalculator.get_Matk`, `MathUtil$$CheckPercent`, `interface MobActionManagerBase.get_gameObject`, `virtual PhysicalPursuit.get_BonusType`, `PlayerBattleManager$$EquipBuffAttack`
- when `IsValid ne 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 979, stkp(-80), 0) & 1) ne 0` AND `IPlayerStatusCalculator.get_Atk(?blr) lt IPlayerStatusCalculator.get_Matk(?blr)`
  - returns `1`
  - calls `virtual CharacterActionManagerBase.get_Size`, `SkillBufferDataBase$$GetParam`, `interface IPlayerStatusCalculator.get_Atk`, `interface IPlayerStatusCalculator.get_Matk`, `MathUtil$$CheckPercent`, `interface MobActionManagerBase.get_gameObject`
- when `IsValid ne 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 979, stkp(-80), 0) & 1) ne 0` AND `IPlayerStatusCalculator.get_Atk(?blr) lt IPlayerStatusCalculator.get_Matk(?blr)`
  - returns `0`
  - calls `virtual CharacterActionManagerBase.get_Size`, `SkillBufferDataBase$$GetParam`, `interface IPlayerStatusCalculator.get_Atk`, `interface IPlayerStatusCalculator.get_Matk`, `MathUtil$$CheckPercent`
- when `IsValid ne 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 979, stkp(-80), 0) & 1) eq 0`
  - returns `1`
  - calls `virtual CharacterActionManagerBase.get_Size`, `SkillBufferDataBase$$GetParam`, `MathUtil$$CheckPercent`, `interface MobActionManagerBase.get_gameObject`, `virtual PhysicalPursuit.get_BonusType`, `PlayerBattleManager$$EquipBuffAttack`

</details>

<details><summary>Effect applied in `PlayerSecondaryStatus$$get_CurrectHit` (7 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `100`
  - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `TornadoLanceBuf$$get_CorrectHit`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `TornadoLanceBuf.get_CorrectHit(TryGetBuf.out2(), 0, ?x2, ?x3)`
  - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `TornadoLanceBuf$$get_CorrectHit`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `0x165db84`, `0x165df00`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-40), 0) & 1) ne 0`
  - returns `100`
  - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-40), 0) & 1) ne 0`
  - returns `0`
  - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-40), 0) & 1) eq 0`
  - returns `100`
  - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-40), 0) & 1) eq 0`
  - returns `0`
  - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`

</details>

<details><summary>Effect applied in `PlayerAttackBase$$ChackCorrectHit` (134 guarded paths)</summary>

- when `(isFlash & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 979, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_EquipItemData`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `UnityEngine.Random$$Range`, `System.Math$$Max`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_Weapon`, `TornadoLanceBuf$$get_CorrectHit`
- when `(isFlash & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 979, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `UnityEngine.Random.Range(0, 100, 0, isFlash) ge 100`
  - returns `((UnityEngine.Random.Range(0, 100, 0, isFlash) lt 100 ? 1 : 0) | (+0x14c ne 0 ? 1 : 0))`
  - calls `virtual PlayerStatusBase.get_EquipItemData`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `UnityEngine.Random$$Range`, `System.Math$$Max`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_Weapon`, `TornadoLanceBuf$$get_CorrectHit`
- when `(isFlash & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 979, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `UnityEngine.Random.Range(0, 100, 0, isFlash) ge 100`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_EquipItemData`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `UnityEngine.Random$$Range`, `System.Math$$Max`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_Weapon`, `TornadoLanceBuf$$get_CorrectHit`
- when `(isFlash & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 979, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `UnityEngine.Random.Range(0, 100, 0, isFlash) ge 100`
  - returns `(UnityEngine.Random.Range(0, 100, 0, isFlash) lt 100 ? 1 : 0)`
  - calls `virtual PlayerStatusBase.get_EquipItemData`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `UnityEngine.Random$$Range`, `System.Math$$Max`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_Weapon`, `TornadoLanceBuf$$get_CorrectHit`
- when `(isFlash & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 979, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `UnityEngine.Random.Range(0, 100, 0, isFlash) ge 100`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_EquipItemData`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `UnityEngine.Random$$Range`, `System.Math$$Max`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_Weapon`, `TornadoLanceBuf$$get_CorrectHit`
- when `(isFlash & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 979, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `UnityEngine.Random.Range(0, 100, 0, isFlash) ge 100`
  - returns `((UnityEngine.Random.Range(0, 100, 0, isFlash) lt 100 ? 1 : 0) | (+0x14c ne 0 ? 1 : 0))`
  - calls `virtual PlayerStatusBase.get_EquipItemData`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `UnityEngine.Random$$Range`, `System.Math$$Max`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_Weapon`, `TornadoLanceBuf$$get_CorrectHit`
- when `(isFlash & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 979, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `UnityEngine.Random.Range(0, 100, 0, isFlash) ge 100`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_EquipItemData`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `UnityEngine.Random$$Range`, `System.Math$$Max`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_Weapon`, `TornadoLanceBuf$$get_CorrectHit`
- when `(isFlash & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 979, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `UnityEngine.Random.Range(0, 100, 0, isFlash) ge 100`
  - returns `(UnityEngine.Random.Range(0, 100, 0, isFlash) lt 100 ? 1 : 0)`
  - calls `virtual PlayerStatusBase.get_EquipItemData`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `UnityEngine.Random$$Range`, `System.Math$$Max`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_Weapon`, `TornadoLanceBuf$$get_CorrectHit`

</details>

<details><summary>Effect applied in `MobAttackBase$$CalcHit` (300 guarded paths, truncated)</summary>

- when `(MobAttackBase.CheckCriticalPercent(this, mobAction, mobAction, playerAction) & 1) ne 0` AND `TryGetValue.out2() ne 0` AND `(MobBuffManager.TryGetBuff(MobActionManagerBase.get_BuffManager(mobAction), 14, stkp(-112), 0) & 1) ne 0` AND `TryGetBuff.out2() ne 0`
  - returns `ShadowWalkBuf.InvalidDamage(TryGetValue.out2(), 1, 0, ?x3)`
  - set `tornadoLanceFree` = `1`
  - calls `MobAttackBase$$CheckCriticalPercent`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`, `interface MobActionManagerBase.get_MobBattleStatus`, `interface IMobStatusCalculator.get_NecessaryFleePercent`, `SkillBufferDataBase$$GetParam`, `interface MobActionManagerBase.get_BuffManager`, `DeadlyPoisonDebuff$$GetNecessaryFreeDownRate`
- when `(MobAttackBase.CheckCriticalPercent(this, mobAction, mobAction, playerAction) & 1) ne 0` AND `TryGetValue.out2() ne 0` AND `(MobBuffManager.TryGetBuff(MobActionManagerBase.get_BuffManager(mobAction), 14, stkp(-112), 0) & 1) ne 0` AND `TryGetBuff.out2() ne 0`
  - returns `ShadowWalkBuf.CheckInvalidDamage(TryGetValue.out2(), 0, ?x2, ?x3)`
  - set `tornadoLanceFree` = `1`
  - calls `MobAttackBase$$CheckCriticalPercent`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`, `interface MobActionManagerBase.get_MobBattleStatus`, `interface IMobStatusCalculator.get_NecessaryFleePercent`, `SkillBufferDataBase$$GetParam`, `interface MobActionManagerBase.get_BuffManager`, `DeadlyPoisonDebuff$$GetNecessaryFreeDownRate`
- when `(MobAttackBase.CheckCriticalPercent(this, mobAction, mobAction, playerAction) & 1) ne 0` AND `TryGetValue.out2() ne 0` AND `(MobBuffManager.TryGetBuff(MobActionManagerBase.get_BuffManager(mobAction), 14, stkp(-112), 0) & 1) ne 0` AND `TryGetBuff.out2() ne 0`
  - returns `IAvoidAction.get_AvoidManager(0x165da68([playerAction+0x30], meta(0x399ced8, IAvoidAction_TypeInfo), ?x2, ?x3))`
  - set `tornadoLanceFree` = `1`
  - calls `MobAttackBase$$CheckCriticalPercent`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`, `interface MobActionManagerBase.get_MobBattleStatus`, `interface IMobStatusCalculator.get_NecessaryFleePercent`, `SkillBufferDataBase$$GetParam`, `interface MobActionManagerBase.get_BuffManager`, `DeadlyPoisonDebuff$$GetNecessaryFreeDownRate`
- when `(MobAttackBase.CheckCriticalPercent(this, mobAction, mobAction, playerAction) & 1) ne 0` AND `TryGetValue.out2() ne 0` AND `(MobBuffManager.TryGetBuff(MobActionManagerBase.get_BuffManager(mobAction), 14, stkp(-112), 0) & 1) ne 0` AND `TryGetBuff.out2() ne 0`
  - returns `UnityEngine.Object.op_Inequality(mobAction, 0, 0, ?x3)`
  - set `tornadoLanceFree` = `1`
  - calls `MobAttackBase$$CheckCriticalPercent`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`, `interface MobActionManagerBase.get_MobBattleStatus`, `interface IMobStatusCalculator.get_NecessaryFleePercent`, `SkillBufferDataBase$$GetParam`, `interface MobActionManagerBase.get_BuffManager`, `DeadlyPoisonDebuff$$GetNecessaryFreeDownRate`
- when `(MobAttackBase.CheckCriticalPercent(this, mobAction, mobAction, playerAction) & 1) ne 0` AND `TryGetValue.out2() ne 0` AND `(MobBuffManager.TryGetBuff(MobActionManagerBase.get_BuffManager(mobAction), 14, stkp(-112), 0) & 1) ne 0` AND `TryGetBuff.out2() ne 0`
  - returns `ShadowWalkBuf.InvalidDamage(TryGetValue.out2(), 1, 0, ?x3)`
  - set `tornadoLanceFree` = `1`
  - calls `MobAttackBase$$CheckCriticalPercent`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`, `interface MobActionManagerBase.get_MobBattleStatus`, `interface IMobStatusCalculator.get_NecessaryFleePercent`, `SkillBufferDataBase$$GetParam`, `interface MobActionManagerBase.get_BuffManager`, `DeadlyPoisonDebuff$$GetNecessaryFreeDownRate`
- when `(MobAttackBase.CheckCriticalPercent(this, mobAction, mobAction, playerAction) & 1) ne 0` AND `TryGetValue.out2() ne 0` AND `(MobBuffManager.TryGetBuff(MobActionManagerBase.get_BuffManager(mobAction), 14, stkp(-112), 0) & 1) ne 0` AND `TryGetBuff.out2() ne 0`
  - returns `ShadowWalkBuf.CheckInvalidDamage(TryGetValue.out2(), 0, ?x2, ?x3)`
  - set `tornadoLanceFree` = `1`
  - calls `MobAttackBase$$CheckCriticalPercent`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`, `interface MobActionManagerBase.get_MobBattleStatus`, `interface IMobStatusCalculator.get_NecessaryFleePercent`, `SkillBufferDataBase$$GetParam`, `interface MobActionManagerBase.get_BuffManager`, `DeadlyPoisonDebuff$$GetNecessaryFreeDownRate`
- when `(MobAttackBase.CheckCriticalPercent(this, mobAction, mobAction, playerAction) & 1) ne 0` AND `TryGetValue.out2() ne 0` AND `(MobBuffManager.TryGetBuff(MobActionManagerBase.get_BuffManager(mobAction), 14, stkp(-112), 0) & 1) ne 0` AND `TryGetBuff.out2() ne 0`
  - returns `IAvoidAction.get_AvoidManager(0x165da68([playerAction+0x30], meta(0x399ced8, IAvoidAction_TypeInfo), ?x2, ?x3))`
  - set `tornadoLanceFree` = `1`
  - calls `MobAttackBase$$CheckCriticalPercent`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`, `interface MobActionManagerBase.get_MobBattleStatus`, `interface IMobStatusCalculator.get_NecessaryFleePercent`, `SkillBufferDataBase$$GetParam`, `interface MobActionManagerBase.get_BuffManager`, `DeadlyPoisonDebuff$$GetNecessaryFreeDownRate`
- when `(MobAttackBase.CheckCriticalPercent(this, mobAction, mobAction, playerAction) & 1) ne 0` AND `TryGetValue.out2() ne 0` AND `(MobBuffManager.TryGetBuff(MobActionManagerBase.get_BuffManager(mobAction), 14, stkp(-112), 0) & 1) ne 0` AND `TryGetBuff.out2() ne 0`
  - returns `UnityEngine.Object.op_Inequality(mobAction, 0, 0, ?x3)`
  - set `tornadoLanceFree` = `1`
  - calls `MobAttackBase$$CheckCriticalPercent`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`, `interface MobActionManagerBase.get_MobBattleStatus`, `interface IMobStatusCalculator.get_NecessaryFleePercent`, `SkillBufferDataBase$$GetParam`, `interface MobActionManagerBase.get_BuffManager`, `DeadlyPoisonDebuff$$GetNecessaryFreeDownRate`

</details>

<details><summary>Effect applied in `MobEventScriptAttack$$CalcHit` (297 guarded paths, truncated)</summary>

- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 979, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `AbsoluteFree.out3() ne 0`
  - returns `ShadowWalkBuf.InvalidDamage(TryGetValue.out2(), 1, 0, ?x3)`
  - calls `MobAttackBase$$CalcCriticalPercent`, `MobAttackBase$$CheckCritical`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`, `SkillBufferDataBase$$GetParam`, `MobAttackBase$$CalcFlee`, `interface IPlayerStatusCalculator.get_Flee`, `MobAttackBase$$checkHit`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 979, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `AbsoluteFree.out3() ne 0`
  - returns `ShadowWalkBuf.CheckInvalidDamage(TryGetValue.out2(), 0, ?x2, ?x3)`
  - calls `MobAttackBase$$CalcCriticalPercent`, `MobAttackBase$$CheckCritical`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`, `SkillBufferDataBase$$GetParam`, `MobAttackBase$$CalcFlee`, `interface IPlayerStatusCalculator.get_Flee`, `MobAttackBase$$checkHit`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 979, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `AbsoluteFree.out3() ne 0`
  - returns `UnityEngine.Object.op_Inequality([playerAction+0x30], 0, 0, ?x3)`
  - calls `MobAttackBase$$CalcCriticalPercent`, `MobAttackBase$$CheckCritical`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`, `SkillBufferDataBase$$GetParam`, `MobAttackBase$$CalcFlee`, `interface IPlayerStatusCalculator.get_Flee`, `MobAttackBase$$checkHit`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 979, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `AbsoluteFree.out3() ne 0`
  - returns `UnityEngine.Object.op_Inequality([playerAction+0x30], 0, 0, ?x3)`
  - calls `MobAttackBase$$CalcCriticalPercent`, `MobAttackBase$$CheckCritical`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`, `SkillBufferDataBase$$GetParam`, `MobAttackBase$$CalcFlee`, `interface IPlayerStatusCalculator.get_Flee`, `MobAttackBase$$checkHit`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 979, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `AbsoluteFree.out3() ne 0`
  - returns `System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue([?blr+0x50], 1000, stkp(-88), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue()))`
  - calls `MobAttackBase$$CalcCriticalPercent`, `MobAttackBase$$CheckCritical`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`, `SkillBufferDataBase$$GetParam`, `MobAttackBase$$CalcFlee`, `interface IPlayerStatusCalculator.get_Flee`, `MobAttackBase$$checkHit`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 979, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `AbsoluteFree.out3() ne 0`
  - returns `MobAttackBase.CheckUnavoidable(this, playerAction, 0, ?x3)`
  - calls `MobAttackBase$$CalcCriticalPercent`, `MobAttackBase$$CheckCritical`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`, `SkillBufferDataBase$$GetParam`, `MobAttackBase$$CalcFlee`, `interface IPlayerStatusCalculator.get_Flee`, `MobAttackBase$$checkHit`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 979, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `AbsoluteFree.out3() eq 0`
  - returns `ShadowWalkBuf.InvalidDamage(TryGetValue.out2(), 1, 0, ?x3)`
  - calls `MobAttackBase$$CalcCriticalPercent`, `MobAttackBase$$CheckCritical`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`, `SkillBufferDataBase$$GetParam`, `MobAttackBase$$CalcFlee`, `interface IPlayerStatusCalculator.get_Flee`, `MobAttackBase$$checkHit`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 979, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `AbsoluteFree.out3() eq 0`
  - returns `ShadowWalkBuf.CheckInvalidDamage(TryGetValue.out2(), 0, ?x2, ?x3)`
  - calls `MobAttackBase$$CalcCriticalPercent`, `MobAttackBase$$CheckCritical`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`, `SkillBufferDataBase$$GetParam`, `MobAttackBase$$CalcFlee`, `interface IPlayerStatusCalculator.get_Flee`, `MobAttackBase$$checkHit`

</details>

<details><summary>Effect applied in `ReceiveBattleResult$$AttackMobaMob` (177 guarded paths, truncated)</summary>

- always
  - returns `SkillBufferManager.AddSelfBuffer(PlayerDataManager.get_SkillBufferManager(PlayerDataManager.GetPlayerDataManager(0, ?x1, ?x2, ?x3), 0, ?x2, ?x3), 0x165db78(meta(0x399cfe0, TornadoLanceBuf_TypeInfo), ?x1, ?x2, ?x3), 0, 0)`
  - calls `MindimageSenjuSkillBase$$Decryption`, `SkillFactory$$CreateSkill`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$LateMobaMobCheck`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$LateMobaMobCheck`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$ReceiveMobaPlayerAttackToMobaMob`
- always
  - returns `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType([CharacterActionManagerBase.set_DefaultMoveSpeed()+0x18], 0, ?x2, ?x3)`
  - calls `MindimageSenjuSkillBase$$Decryption`, `SkillFactory$$CreateSkill`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$LateMobaMobCheck`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$LateMobaMobCheck`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$ReceiveMobaPlayerAttackToMobaMob`
- always
  - returns `SkillManager.GetSkillLv(CharacterActionManagerBase.get_IsDeadOrLocalDead(), 979, 0, 0)`
  - calls `MindimageSenjuSkillBase$$Decryption`, `SkillFactory$$CreateSkill`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$LateMobaMobCheck`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$LateMobaMobCheck`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$ReceiveMobaPlayerAttackToMobaMob`
- always
  - returns `SkillBufferManager.AddSelfBuffer(PlayerDataManager.get_SkillBufferManager(PlayerDataManager.GetPlayerDataManager(0, ?x1, ?x2, ?x3), 0, ?x2, ?x3), 0x165db78(meta(0x399cfe0, TornadoLanceBuf_TypeInfo), ?x1, ?x2, ?x3), 0, 0)`
  - calls `MindimageSenjuSkillBase$$Decryption`, `SkillFactory$$CreateSkill`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$LateMobaMobCheck`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$LateMobaMobCheck`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$ReceiveMobaPlayerAttackToMobaMob`
- always
  - returns `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType([CharacterActionManagerBase.set_DefaultMoveSpeed()+0x18], 0, ?x2, ?x3)`
  - calls `MindimageSenjuSkillBase$$Decryption`, `SkillFactory$$CreateSkill`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$LateMobaMobCheck`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$LateMobaMobCheck`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$ReceiveMobaPlayerAttackToMobaMob`
- always
  - returns `SkillManager.GetSkillLv(CharacterActionManagerBase.get_IsDeadOrLocalDead(), 979, 0, 0)`
  - calls `MindimageSenjuSkillBase$$Decryption`, `SkillFactory$$CreateSkill`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$LateMobaMobCheck`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$LateMobaMobCheck`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$ReceiveMobaPlayerAttackToMobaMob`
- always
  - returns `SkillBufferManager.AddSelfBuffer(PlayerDataManager.get_SkillBufferManager(PlayerDataManager.GetPlayerDataManager(0, ?x1, ?x2, ?x3), 0, ?x2, ?x3), 0x165db78(meta(0x399cfe0, TornadoLanceBuf_TypeInfo), ?x1, ?x2, ?x3), 0, 0)`
  - calls `MindimageSenjuSkillBase$$Decryption`, `SkillFactory$$CreateSkill`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$LateMobaMobCheck`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$ReceiveMobaPlayerAttackToMobaMob`, `Toram.Common.Actions.ActionAppendData$$Contains`, `Toram.Common.Actions.ActionAppendData$$Get`
- always
  - returns `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType([CharacterActionManagerBase.set_DefaultMoveSpeed()+0x18], 0, ?x2, ?x3)`
  - calls `MindimageSenjuSkillBase$$Decryption`, `SkillFactory$$CreateSkill`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$LateMobaMobCheck`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$ReceiveMobaPlayerAttackToMobaMob`, `Toram.Common.Actions.ActionAppendData$$Contains`, `Toram.Common.Actions.ActionAppendData$$Get`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `MagicPursuit$$Calc (TryGetBuf)`
- `MobAttackBase$$CalcHit (ContainsBuffer)`
- `MobEventScriptAttack$$CalcHit (TryGetBuf)`
- `MobaPlayerSecondaryStatus$$get_CriticalDmg (TryGetBuf)`
- `PhysicalPursuit$$Calc (TryGetBuf)`
- `PlayerAttackBase$$CalcStable (TryGetBuf)`
- `PlayerAttackBase$$ChackCorrectHit (TryGetBuf)`
- `PlayerSecondaryStatus$$CalcCriticalDmg (TryGetBuf)`
- `PlayerSecondaryStatus$$get_CurrectHit (TryGetBuf)`
- `ReceiveBattleResult$$AttackMobaMob (GetSkillLv)`

---

### ธอร์แฮมเมอร์ (ThorHammer) · uid 982

<img src="../../icons/sk_982.png" width="40" alt="icon"> 
**Tree:** ハルバードスキル (`HalberdSkill`, tier 5) · **Type:** Object · **Max Lv:** 240 · **Weapons:** Halberd · **Requires:** ไลท์นิ่งเฮล · **Client class:** `ThorHammerAction`

> โจมตีด้วยเวทมนตร์สายฟ้าขนาดใหญ่การันตีคริติคอล
> แต่พลังโจมตีกระจายตามจำนวนเป้าหมายที่โดน
> หลังจากเปิดใช้งานจะเพิ่มการโจมตีเวทมนตร์ เวทเจาะเข้า
> และอัตราความแม่นของตัวเองในช่วงระยะเวลาหนึ่ง

<details><summary>In-game level notes</summary>

- Lv9: การเพิ่มของอัตราความแม่นขึ้นอยู่กับค่า INT ของตัวเอง  เมื่อใช้สกิล "ไลท์นิ่งเฮล" จะทิ้งร่องรอยไหม้จากฟ้าผ่า เมื่อใช้ร่วมกับสกิลธอร์แฮมเมอร์จะเพิ่มความเสียหายเวทมนตร์

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 10.5 | 11 | 11.5 | 12 | 12.5 | 13 | 13.5 | 14 | 14.5 | 15 |
| Flat dmg + | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((pursuitHitCount + 1) * (((((TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)).Level >> 1) * 20) + (status.Int // 10)) + 75))) / 100)` — nowAttackCount ne 0
- Flat dmg + `((0) eq 0 ? (400) : (((TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)).Level * 10) + 100)))`

**Role:** attack (deals damage) · buff (self) · applies status ailment · placed object / trap / summon

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `((0) eq 0 ? (400) : (((TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)).Level * 10) + 100)))`
- `BufferConstantDamage` sets: `0`
- `SkillRate` multiplies by (adds into): `(((pursuitHitCount + 1) * (((((TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)).Level >> 1) * 20) + (status.Int // 10)) + 75))) / 100)` | `((((Lv * 50) + 1000)) / 100)`
- `ExpRate` sets: `(target.ExpDefMagic / 100)` | `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**Mechanics recovered from code**

- **Number of damage events** (`damageCount`): `1` = 1; `(SkillBufferDataBase.GetParam(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)), 20) + damageCount)` _(when (SkillBufferManager.TryGetBuf<LightningHailBuf>PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) ne 0 AND UnityEngine.Object.op_Inequality(actarAction))_; `motionSpeed`
- **Loop / hit-repeat count** (`LoopParam`): `1` = 1; `(SkillBufferDataBase.GetParam(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)), 20) + damageCount)` _(when (SkillBufferManager.TryGetBuf<LightningHailBuf>PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) ne 0 AND UnityEngine.Object.op_Inequality(actarAction))_

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 982

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `fixAddDamage` = `400` = 400
- set `damageCount` = `1` = 1
- set `LoopParam` = `1` = 1
- set `skillRate` = `((Lv * 50) + 1000)` → Lv1..10: [1050, 1100, 1150, 1200, 1250, 1300, 1350, 1400, 1450, 1500]

**`ActionStart`** (4 paths)

- set `nowAttackCount` = `0` = 0
- set `pursuitSkillRate` = `((((TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)).Level >> 1) * 20) + (status.Int // 10)) + 75)` — when (SkillBufferManager.TryGetBuf<LightningHailBuf>PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `pursuitFixDamage` = `((TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)).Level * 10) + 100)` — when (SkillBufferManager.TryGetBuf<LightningHailBuf>PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `damageCount` = `(SkillBufferDataBase.GetParam(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)), 20) + damageCount)` — when (SkillBufferManager.TryGetBuf<LightningHailBuf>PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `LoopParam` = `(SkillBufferDataBase.GetParam(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)), 20) + damageCount)` — when (SkillBufferManager.TryGetBuf<LightningHailBuf>PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 981, (this + 344)) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1
- set `damageCount` = `motionSpeed`

**`calcPlayerToMobDamage`** (8 paths)

- template `SetRate[ExpRate]` = `(target.ExpDefMagic / 100)`
- template `AddRate[SkillRate]` = `(((pursuitHitCount + 1) * pursuitSkillRate) / 100)` — when nowAttackCount ne 0
- template `AddConstant[SkillConstantDamage]` = `(nowAttackCount eq 0 ? fixAddDamage : pursuitFixDamage)`
- template `SetConstant[BufferConstantDamage]` = `0` — when nowAttackCount ne 0
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(987, 0, 0)`
- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(987)`
- info `templates` = `1`
- template `AddRate[SkillRate]` = `(skillRate / 100)` — when nowAttackCount eq 0
- template `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**`NextRangeHit`** (6 paths)

- set `pursuitHitCount` = `(pursuitHitCount hs 7 ? 8 : (pursuitHitCount + 1))` — when nowAttackCount ge 1
- set `nowAttackCount` = `(nowAttackCount + 1)`

**`ActionSkillEventPreparation`** (7 paths)

- calls `ThorHammerBuf..ctor` = `.ctor(Lv, PlayerActionManagerBase.get_PlayerStatus())` — when (damageCount - 1) ge 1 AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 102 OR (damageCount - 1) lt 1 AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 102
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new ThorHammerBuf, Id)` — when (damageCount - 1) ge 1 AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 102 OR (damageCount - 1) lt 1 AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 102

**`ActionSkillEvent`** (6 paths)

- set `split` = `(System.Linq.Enumerable.Count<MobActionManagerBase>(MobManager.get_TargetableMobList(TargetableListManagerBase<MobManager>.get_Instance(actarAction)), new System.Func<MobActionManagerBase, bool>) gt 1 ? System.Linq.Enumerable.Count<MobActionManagerBase>(MobManager.get_TargetableMobList(TargetableListManagerBase<MobManager>.get_Instance(actarAction)), new System.Func<MobActionManagerBase, bool>) : 1)` — when param eq 100 AND param ne 101 AND param ne 103
- set `pursuitEnd` = `1` = 1 — when param eq 101 AND param ne 103 AND pursuitEnd eq 0
- set `pursuitUid` = `-1` = -1 — when param eq 103

**`OtherPlayerSkillEventReceive`** (4 paths)

- set `pursuitEnd` = `1` = 1 — when (skillEventId & 0xffff) eq 104

**`ReceivedAbnormal`** (3 paths)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(982)` — when (abnormalType - 1) ls 2 AND hasBuff(982)

**`Damaged`** (4 paths)

- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(0, 0)` — when SkillActionBase.get_ActionID() eq 982 AND SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND SkillDamageData.IsInactivityAbnormal(damageData)

**`.<>c__DisplayClass35_0::<ActionStart>b__0`** (1 path)

- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(CharacterActionManagerBase.get_IsLocalDead(), [<>c__DisplayClass35_0.<>4__this+0x14], [<>c__DisplayClass35_0.<>4__this+0x10])`

</details>

**Buffs**

**Buff `ThorHammerBuf`**
- Buff hook methods: `get_BufEffectTakeId`
- `HitUp` = `((baseINT * Lv) // 10)`

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MagiclPursuitSkillRate | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |
| MagicResistBreaker | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |

- Buff fields set in the constructor (all recovered):
  - `status` = `playerStatus`
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

<details><summary>Effect applied in `PlayerBattleManager$$PursuitAttack` (69 guarded paths)</summary>

- always
  - returns `PlayerBattleManager.EquipBuffAttack(this, 154, 0x165da68(targetActManager, meta(0x3973fb8, MobActionManagerBase_TypeInfo), ?x2, ?x3), ?x3)`
  - calls `System.Linq.Enumerable$$Any<object>`, `0x165da68`, `interface MobActionManagerBase.get_SystemInvincible`, `virtual SkillActionBase.get_ActionID`, `NormalAttackAction$$IsNormalAttack`, `EquipBuffManager$$IsEquipBuff`, `EquipBuffManager$$CalcBuff`, `EquipBuffManager$$IsEquipBuff`
- always
  - returns `UnityEngine.Object.op_Equality([mainTargetData+0x18], MobActionManagerBase.get_gameObject(0x165da68(targetActManager, meta(0x3973fb8, MobActionManagerBase_TypeInfo), ?x2, ?x3)), 0, ?x3)`
  - calls `System.Linq.Enumerable$$Any<object>`, `0x165da68`, `interface MobActionManagerBase.get_SystemInvincible`, `virtual SkillActionBase.get_ActionID`, `NormalAttackAction$$IsNormalAttack`, `EquipBuffManager$$IsEquipBuff`, `EquipBuffManager$$CalcBuff`, `EquipBuffManager$$IsEquipBuff`
- always
  - returns `MathUtil.CheckPercent(((CharacterActionManagerBase.get_Size() + 25) + [[TryGetValue.out2()+0x10]+0x18]), 0, ?x2, ?x3)`
  - calls `System.Linq.Enumerable$$Any<object>`, `0x165da68`, `interface MobActionManagerBase.get_SystemInvincible`, `virtual SkillActionBase.get_ActionID`, `NormalAttackAction$$IsNormalAttack`, `EquipBuffManager$$IsEquipBuff`, `EquipBuffManager$$CalcBuff`, `EquipBuffManager$$IsEquipBuff`
- always
  - returns `PlayerBattleManager.EquipBuffAttack(this, 154, 0x165da68(targetActManager, meta(0x3973fb8, MobActionManagerBase_TypeInfo), ?x2, ?x3), ?x3)`
  - calls `System.Linq.Enumerable$$Any<object>`, `0x165da68`, `interface MobActionManagerBase.get_SystemInvincible`, `virtual SkillActionBase.get_ActionID`, `NormalAttackAction$$IsNormalAttack`, `EquipBuffManager$$IsEquipBuff`, `EquipBuffManager$$CalcBuff`, `EquipBuffManager$$IsEquipBuff`
- always
  - returns `UnityEngine.Object.op_Equality([mainTargetData+0x18], MobActionManagerBase.get_gameObject(0x165da68(targetActManager, meta(0x3973fb8, MobActionManagerBase_TypeInfo), ?x2, ?x3)), 0, ?x3)`
  - calls `System.Linq.Enumerable$$Any<object>`, `0x165da68`, `interface MobActionManagerBase.get_SystemInvincible`, `virtual SkillActionBase.get_ActionID`, `NormalAttackAction$$IsNormalAttack`, `EquipBuffManager$$IsEquipBuff`, `EquipBuffManager$$CalcBuff`, `EquipBuffManager$$IsEquipBuff`
- always
  - returns `MathUtil.CheckPercent((CharacterActionManagerBase.get_Size() + 25), 0, ?x2, ?x3)`
  - calls `System.Linq.Enumerable$$Any<object>`, `0x165da68`, `interface MobActionManagerBase.get_SystemInvincible`, `virtual SkillActionBase.get_ActionID`, `NormalAttackAction$$IsNormalAttack`, `EquipBuffManager$$IsEquipBuff`, `EquipBuffManager$$CalcBuff`, `EquipBuffManager$$IsEquipBuff`
- always
  - calls `System.Linq.Enumerable$$Any<object>`, `0x165da68`, `interface MobActionManagerBase.get_SystemInvincible`, `virtual SkillActionBase.get_ActionID`, `NormalAttackAction$$IsNormalAttack`, `EquipBuffManager$$IsEquipBuff`, `EquipBuffManager$$CalcBuff`, `EquipBuffManager$$IsEquipBuff`
- always
  - returns `PlayerBattleManager.EquipBuffAttack(this, 154, 0x165da68(targetActManager, meta(0x3973fb8, MobActionManagerBase_TypeInfo), ?x2, ?x3), ?x3)`
  - calls `System.Linq.Enumerable$$Any<object>`, `0x165da68`, `interface MobActionManagerBase.get_SystemInvincible`, `virtual SkillActionBase.get_ActionID`, `NormalAttackAction$$IsNormalAttack`, `EquipBuffManager$$IsEquipBuff`, `EquipBuffManager$$CalcBuff`, `EquipBuffManager$$IsEquipBuff`

</details>

<details><summary>Effect applied in `BlitzPikeAction$$OnInitialize` (3 guarded paths)</summary>

- when `SkillLv(982) ge 1`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, meta(0), ?x2, ?x3)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `attackType` = `1`
  - set `skillRate[0]` = `((((Lv * 10) + 300) + ((SkillLv(982) + (SkillLv(982) << 2)) << 1)) + (([?blr+0x14] lt 0 ? ([?blr+0x14] + 1) : [?blr+0x14]) >> 1))`
  - set `skillRate[1]` = `((((Lv * 30) + 100) + ((SkillLv(982) + (SkillLv(982) << 2)) << 1)) + (([?blr+0x18] lt 0 ? ([?blr+0x18] + 1) : [?blr+0x18]) >> 1))`
  - set `fixAddDamage[0]` = `300`
  - set `fixAddDamage[1]` = `((IPlayerStatusCalculator.get_Int(?blr) lt 0 ? (IPlayerStatusCalculator.get_Int(?blr) + 1) : IPlayerStatusCalculator.get_Int(?blr)) >> 1)`
  - set `abnormalPer` = `(([?blr+0x18] // 10) + (Lv + (Lv << 2)))`
  - calls `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `interface IPlayerStatusCalculator.get_Int`, `PlayerAttackBase$$CalcMp`
- when `SkillLv(982) ge 1`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, meta(0), ?x2, ?x3)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `attackType` = `1`
  - set `skillRate[0]` = `((((Lv * 10) + 300) + ((SkillLv(982) + (SkillLv(982) << 2)) << 1)) + (([?blr+0x14] lt 0 ? ([?blr+0x14] + 1) : [?blr+0x14]) >> 1))`
  - set `skillRate[1]` = `((Lv * 30) + 100)`
  - set `fixAddDamage[0]` = `300`
  - set `fixAddDamage[1]` = `((IPlayerStatusCalculator.get_Int(?blr) lt 0 ? (IPlayerStatusCalculator.get_Int(?blr) + 1) : IPlayerStatusCalculator.get_Int(?blr)) >> 1)`
  - calls `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `interface IPlayerStatusCalculator.get_Int`, `0x165db8c`
- when `SkillLv(982) lt 1`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, meta(0), ?x2, ?x3)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `attackType` = `1`
  - set `skillRate[0]` = `((Lv * 10) + 300)`
  - set `skillRate[1]` = `((Lv * 30) + 100)`
  - set `fixAddDamage[0]` = `300`
  - set `fixAddDamage[1]` = `((IPlayerStatusCalculator.get_Int(?blr) lt 0 ? (IPlayerStatusCalculator.get_Int(?blr) + 1) : IPlayerStatusCalculator.get_Int(?blr)) >> 1)`
  - set `abnormalPer` = `(([?blr+0x18] // 10) + (Lv + (Lv << 2)))`
  - calls `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `interface IPlayerStatusCalculator.get_Int`, `PlayerAttackBase$$CalcMp`

</details>

<details><summary>Effect applied in `ThorHammerAction$$ReceivedAbnormal` (3 guarded paths)</summary>

- when `(abnormalType - 1) ls 2`
  - calls `SkillBufferManager$$RemoveSelfBuffer`
- when `(abnormalType - 1) ls 2`
  - returns `SkillBufferManager.ContainsBuffer(?blr, 982, 0, ?x3)`
- when `(abnormalType - 1) hi 2`
  - returns `SkillBufferManager.ContainsBuffer(?blr, 982, 0, ?x3)`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `BlitzPikeAction$$OnInitialize (GetSkillLv)`
- `LightningHailAction$$ActionStart (GetSkillLv)`
- `PlayerBattleManager$$PursuitAttack (ContainsBuffer)`
- `ThorHammerAction$$ReceivedAbnormal (ContainsBuffer)`

---
