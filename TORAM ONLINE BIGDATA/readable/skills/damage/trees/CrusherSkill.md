# クラッシャー (`CrusherSkill`)

10 entries. See ../README.md for how to read these blocks.

### กำปั้นผดุงคุณธรรม (ForefistPunch) · uid 1153

<img src="../../icons/sk_1153.png" width="40" alt="icon"> 
**Tree:** クラッシャー (`CrusherSkill`, tier 1) · **Type:** Attack · **Max Lv:** 50 · **Weapons:** MainKnuckle · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `ForefistPunchAction`

> หมัดตรงอันเฉียบคม
> เป้าหมายจะโดนโจมตีคริติคอล
> ระหว่างใช้ความเสียหายที่ได้รับจะลดลง 1 ครั้ง

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 2.2 | 2.4 | 2.6 | 2.8 | 3 | 3.2 | 3.4 | 3.6 | 3.8 | 4 |
| Flat dmg + | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv + (Lv << 2)) << 2) + 200)) * 0.01)` — UnityEngine.Object.op_Inequality(actarAction)

**Role:** attack (deals damage) · buff (self)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(200)`
- `SkillRate` multiplies by (adds into): `(((((Lv + (Lv << 2)) << 2) + 200)) * 0.01)`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1153

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `skillRate` = `(((Lv + (Lv << 2)) << 2) + 200)` → Lv1..10: [220, 240, 260, 280, 300, 320, 340, 360, 380, 400]
- set `fixAddDamage` = `200` = 200

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`ActionPreparation`** (3 paths)

- set `skillRate` = `(skillRate + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1158], 50))` — when UnityEngine.Object.op_Inequality(actarAction)

**`ActionStart`** (3 paths)

- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(1153, Lv, 0)` — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction)

**`calcPlayerToMobDamage`** (2 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)`
- template `AddRate[SkillRate]` = `(skillRate * 0.01)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- info `templates` = `1`

**`OnInheritance`** (1 path)

- set `IsInheritance` = `1` = 1

**`.<>c__DisplayClass25_0::<ActionStart>b__0`** (1 path)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(1153)`

</details>

**Buffs**

**Buff `ForefistPunchBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 25 | 25 | 25 | 25 | 25 | 25 | 25 | 25 | 25 | 25 |


---

### วิธีการหายใจ (BreathingMethod) · uid 1154

<img src="../../icons/sk_1154.png" width="40" alt="icon"> 
**Tree:** クラッシャー (`CrusherSkill`, tier 1) · **Type:** Buffer · **Max Lv:** 50 · **Weapons:** Knuckle · **Flags:** StarGem · **Client class:** `BreathingMethodAction`

> วิธีจัดเตรียมลมหายใจอย่างรวดเร็ว
> ระหว่างใช้งาน HP ของตัวเองจะฟื้นฟูทันที
> ตอนใช้สกิลถัดไป HP ก็ยังฟื้นฟูอยู่
> พลังการฟื้นฟูของวิธีการหายใจจะลดต่ำลง

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

**Mechanics recovered from code**

- **MP cost** (`mp`): `(mp - 100)` _(when hasGemCart(1037))_
- **Cast time modifier** (`CastTime`): `SkillUtil.CalcCastTime(0, PlayerStatusBase.get_BattleStatus())`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1154

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (2 paths)

- set `mp` = `(mp - 100)` — when hasGemCart(1037)
- set `ActionRange` = `-1` = -1
- set `CastTime` = `SkillUtil.CalcCastTime(0, PlayerStatusBase.get_BattleStatus())`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (2 paths)

- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(1154, Lv, 0)` — when UnityEngine.Object.op_Inequality(actarAction)

**`OnInheritance`** (1 path)

- set `IsInheritance` = `1` = 1

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

<details><summary>Effect applied in `GazerShootAction$$ActionHit` (2 guarded paths)</summary>

- when `longBonus ne 0` AND `SkillLv(1154) ge 1`
  - calls `SkillActionBase$$ActionHit`, `0x165db78`, `BreathingMethodBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
- when `longBonus ne 0` AND `SkillLv(1154) lt 1`
  - returns `SkillLv(1154)`
  - calls `SkillActionBase$$ActionHit`

</details>

<details><summary>Effect applied in `GeoImpactAction$$ActionPreparation` (7 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 1154, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `TryGetValue.out2() ne 0`
  - returns `SkillBufferDataBase.GetParam(TryGetValue.out2(), 50, 0, ?x3)`
  - set `breathingMethodHeal` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)`
  - set `mpHeal` = `(CharacterActionManagerBase.set_DefaultMoveSpeed() * 100)`
  - set `skillRate` = `(SkillBufferDataBase.GetParam(TryGetValue.out2(), 50, 0, ?x3) + skillRate)`
  - calls `PlayerAttackBase$$ActionPreparation`, `SkillBufferDataBase$$GetParam`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferDataBase$$GetParam`
- when `(SkillBufferManager.TryGetBuf(?blr, 1154, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `TryGetValue.out2() eq 0`
  - set `breathingMethodHeal` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)`
  - calls `PlayerAttackBase$$ActionPreparation`, `SkillBufferDataBase$$GetParam`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(?blr, 1154, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue([?blr+0x40], 1158, stkp(-40), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue()))`
  - set `breathingMethodHeal` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)`
  - calls `PlayerAttackBase$$ActionPreparation`, `SkillBufferDataBase$$GetParam`
- when `(SkillBufferManager.TryGetBuf(?blr, 1154, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `PlayerAttackBase$$ActionPreparation`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(?blr, 1154, stkp(-40), 0) & 1) eq 0` AND `TryGetValue.out2() ne 0`
  - returns `SkillBufferDataBase.GetParam(TryGetValue.out2(), 50, 0, ?x3)`
  - set `mpHeal` = `(CharacterActionManagerBase.set_DefaultMoveSpeed() * 100)`
  - set `skillRate` = `(SkillBufferDataBase.GetParam(TryGetValue.out2(), 50, 0, ?x3) + skillRate)`
  - calls `PlayerAttackBase$$ActionPreparation`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferDataBase$$GetParam`
- when `(SkillBufferManager.TryGetBuf(?blr, 1154, stkp(-40), 0) & 1) eq 0` AND `TryGetValue.out2() eq 0`
  - calls `PlayerAttackBase$$ActionPreparation`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(?blr, 1154, stkp(-40), 0) & 1) eq 0`
  - returns `System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue([?blr+0x40], 1158, stkp(-40), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue()))`
  - calls `PlayerAttackBase$$ActionPreparation`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `GazerShootAction$$ActionHit (GetSkillLv)`
- `GeoImpactAction$$ActionPreparation (TryGetBuf)`
- `PlayerAttackBase$$CalcCostMp (ContainsBuffer)`
- `PlayerAttackBase$$RemoveAfterSkillBuf (ContainsBuffer)`

---

### กลอเรียเทคชอต (GoliathTakeShot) · uid 1155

<img src="../../icons/sk_1155.png" width="40" alt="icon"> 
**Tree:** クラッシャー (`CrusherSkill`, tier 2) · **Type:** Attack · **Max Lv:** 90 · **Weapons:** MainKnuckle · **Requires:** กำปั้นผดุงคุณธรรม · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `GoliathTakeShotAction`

> โจมตีศัตรูตัวฉกาจอย่างรุนแรง
> ชาร์จสกิล(เลเวล6)
> จะโจมตีในระยะที่แคบมาก
> ถ้าเลยเวลาที่ชาร์จนเต็มไปแล้ว
> พลังจะลดลง

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 500 | 500 | 500 | 500 | 500 | 500 | 500 | 500 | 500 | 500 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((800) + ((((Lv * 10) + 300)) * (GoliathTakeShotBuf.GetParam(50)))) * 0.01)`
- SkillRate × `(((800) + ((((Lv * 10) + 300)) * (GoliathTakeShotBuf.GetParam(50)))) * 0.01)` — IsInstanceOf(actarAction, MercenaryActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(actarAction, MercenaryActionManager) eq 1 AND UnityEngine.Object.op_Inequality(actarAction)
- SkillRate × `(((800) + ((((Lv * 10) + 300)) * (GoliathTakeShotBuf.GetParam(50)))) * 0.01)` — IsInstanceOf(actarAction, MercenaryActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(actarAction, MercenaryActionManager) eq 1 AND UnityEngine.Object.op_Inequality(actarAction)
- SkillRate × `(((800) + ((((Lv * 10) + 300)) * (GoliathTakeShotBuf.GetParam(50)))) * 0.01)` — IsInstanceOf(actarAction, MercenaryActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(actarAction, MercenaryActionManager) eq 1 AND UnityEngine.Object.op_Inequality(actarAction) & IsInstanceOf(actarAction, MercenaryActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(actarAction, MercenaryActionManager) eq 1 AND UnityEngine.Object.op_Inequality(actarAction)

**Role:** attack (deals damage) · buff (self)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(500)`
- `SkillRate` multiplies by (adds into): `(((800) + ((((Lv * 10) + 300)) * (GoliathTakeShotBuf.GetParam(50)))) * 0.01)`

**Mechanics recovered from code**

- **MP cost** (`mp`): `(hasBuff(1155) ? 0 : 500)`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1155

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (2 paths)

- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `baseSkillRate` = `800` = 800
- set `chargeSkillRate` = `((Lv * 10) + 300)` → Lv1..10: [310, 320, 330, 340, 350, 360, 370, 380, 390, 400]
- set `fixAddDamage` = `500` = 500
- set `mp` = `(hasBuff(1155) ? 0 : 500)`
- set `SkillIndividualFlag` = `GoliathTakeShotBuf.GetParam(50)`
- set `chargeLevel` = `GoliathTakeShotBuf.GetParam(50)`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`
- set `chargeLevel` = `SkillIndividualFlag`

**`ActionStart`** (5 paths)

- set `target` = `UnityEngine.GameObject.get_transform(target)`
- set `baseSkillRate` = `(baseSkillRate + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1158], 50))` — when IsInstanceOf(actarAction, MercenaryActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(actarAction, MercenaryActionManager) eq 1 AND UnityEngine.Object.op_Inequality(actarAction)
- set `chargeSkillRate` = `(chargeSkillRate + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1158], 50))` — when IsInstanceOf(actarAction, MercenaryActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(actarAction, MercenaryActionManager) eq 1 AND UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(1155)` — when IsInstanceOf(actarAction, MercenaryActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(actarAction, MercenaryActionManager) eq 1 AND UnityEngine.Object.op_Inequality(actarAction)

**`calcPlayerToMobDamage`** (2 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)`
- template `AddRate[SkillRate]` = `((baseSkillRate + (chargeSkillRate * chargeLevel)) * 0.01)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- info `templates` = `1`

</details>

**Buffs**

**Buff `GoliathTakeShotBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `Charge`, `ChargeAura`, `GetComboParam`, `NextChargeLevel`, `RecieveIncapacitatedAbnormal`, `RecieveWeakAbnormal`, `SetComboParam`
- `Value` = `chargeLevel` _(when BuffEffectActive ne 0)_
- `Value` = `0` _(when BuffEffectActive eq 0)_
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `maxChargeLevel` = `5` = 5 when (archetypeType & 255) ne 0 OR !UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND (archetypeType & 255) eq 0 OR (archetypeType & 255) eq 0 AND UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0)
  - `chargeTime` = `((((Lv - 1) // 3) * -0.5) + 2.5)` → Lv1..10 [2.5, 2.5, 2.5, 2.0, 2.0, 2.0, 1.5, 1.5, 1.5, 1.0] when (archetypeType & 255) ne 0 OR !UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND (archetypeType & 255) eq 0 OR (archetypeType & 255) eq 0 AND UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0)
  - `archetypeType` = `archetypeType` when (archetypeType & 255) ne 0 OR !UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND (archetypeType & 255) eq 0 OR (archetypeType & 255) eq 0 AND UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0)
  - `playerDataManager` = `PlayerDataManager.GetPlayerDataManager()` when !UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND (archetypeType & 255) eq 0 OR (archetypeType & 255) eq 0 AND UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0)
  - `isMaxChargeEnd` = `0` when (archetypeType & 255) ne 0 OR !UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND (archetypeType & 255) eq 0 OR (archetypeType & 255) eq 0 AND UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0)
- Hook `Updata`: `chargeTime`=(chargeTime - UnityEngine.Time.get_deltaTime())
- Hook `SetComboParam`: `comboType`=type; `comboRate`=rate
- Hook `RecieveIncapacitatedAbnormal`: `chargeTime`=(chargeTime + add)
- Hook `RecieveWeakAbnormal`: `isMaxChargeEnd`=1; `Count`=1; `chargeLevel`=1
- Hook `Charge`: `chargeLevel`=System.Math.Min((chargeLevel + 1), maxChargeLevel); `isMaxChargeEnd`=1; `chargeTime`=(Lv + 2); `Count`=System.Math.Min((chargeLevel + 1), maxChargeLevel)
- Hook `NextChargeLevel`: `chargeLevel`=System.Math.Max((chargeLevel - 1), 1); `chargeTime`=6; `Count`=System.Math.Max((chargeLevel - 1), 1); `chargeLevel`=System.Math.Min((chargeLevel + 1), maxChargeLevel)

<details><summary>Effect applied in `MobaPlayerActionManager$$GetSkillTargetType` (2 guarded paths)</summary>

- when `skillId gt 577` AND `skillId gt 995` AND `skillId le 1155` AND `skillId ne 1131`
  - returns `[MasterSkillDataManager.GetSkillMaster(Singleton<object>.get_Instance(meta(0x397a328, Method$Singleton<MasterSkillDataManager>.get_Instance()), ?x1, ?x2, ?x3), 1155, 0, ?x3)+0x2c]`
  - calls `Singleton<object>$$get_Instance`, `MasterSkillDataManager$$GetSkillMaster`
- when `skillId gt 577` AND `skillId gt 995` AND `skillId le 1155` AND `skillId ne 1131`
  - returns `1`

</details>

<details><summary>Effect applied in `PlayerActionManager$$GetSkillTargetType` (2 guarded paths)</summary>

- when `skillId gt 629` AND `skillId gt 991` AND `skillId le 1155` AND `skillId ne 995`
  - returns `[MasterSkillDataManager.GetSkillMaster(Singleton<object>.get_Instance(meta(0x397a328, Method$Singleton<MasterSkillDataManager>.get_Instance()), ?x1, ?x2, ?x3), 1155, 0, ?x3)+0x2c]`
  - calls `Singleton<object>$$get_Instance`, `MasterSkillDataManager$$GetSkillMaster`
- when `skillId gt 629` AND `skillId gt 991` AND `skillId le 1155` AND `skillId ne 995`
  - returns `1`

</details>

<details><summary>Effect applied in `GoliathTakeShotAction$$ReceivedAbnormal` (8 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 1155, stkp(-40), 0) & 1) ne 0` AND `(abnormalType - 1) hs 3` AND `abnormalType ne 15` AND `abnormalType eq 43`
  - returns `GoliathTakeShotBuf.RecieveIncapacitatedAbnormal(TryGetBuf.out2(), 0, ?x2, ?x3)`
  - calls `GoliathTakeShotBuf$$RecieveIncapacitatedAbnormal`
- when `(SkillBufferManager.TryGetBuf(?blr, 1155, stkp(-40), 0) & 1) ne 0` AND `(abnormalType - 1) hs 3` AND `abnormalType ne 15` AND `abnormalType eq 43`
  - calls `0x165db84`, `0x165df00`
- when `(SkillBufferManager.TryGetBuf(?blr, 1155, stkp(-40), 0) & 1) ne 0` AND `(abnormalType - 1) hs 3` AND `abnormalType ne 15` AND `abnormalType ne 43`
  - returns `SkillBufferManager.TryGetBuf(?blr, 1155, stkp(-40), 0)`
- when `(SkillBufferManager.TryGetBuf(?blr, 1155, stkp(-40), 0) & 1) ne 0` AND `(abnormalType - 1) hs 3` AND `abnormalType eq 15` AND `TryGetBuf.out2() ne 0`
  - returns `GoliathTakeShotBuf.RecieveWeakAbnormal(TryGetBuf.out2(), 0, ?x2, ?x3)`
  - calls `GoliathTakeShotBuf$$RecieveWeakAbnormal`
- when `(SkillBufferManager.TryGetBuf(?blr, 1155, stkp(-40), 0) & 1) ne 0` AND `(abnormalType - 1) hs 3` AND `abnormalType eq 15` AND `TryGetBuf.out2() eq 0`
  - calls `0x165db84`, `0x165df00`
- when `(SkillBufferManager.TryGetBuf(?blr, 1155, stkp(-40), 0) & 1) ne 0` AND `(abnormalType - 1) lo 3` AND `TryGetBuf.out2() ne 0`
  - returns `GoliathTakeShotBuf.RecieveIncapacitatedAbnormal(TryGetBuf.out2(), 0, ?x2, ?x3)`
  - calls `GoliathTakeShotBuf$$RecieveIncapacitatedAbnormal`
- when `(SkillBufferManager.TryGetBuf(?blr, 1155, stkp(-40), 0) & 1) ne 0` AND `(abnormalType - 1) lo 3` AND `TryGetBuf.out2() eq 0`
  - calls `0x165db84`, `0x165df00`
- when `(SkillBufferManager.TryGetBuf(?blr, 1155, stkp(-40), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 1155, stkp(-40), 0)`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `GoliathTakeShotAction$$OnInitialize (ContainsBuffer)`
- `GoliathTakeShotAction$$ReceivedAbnormal (TryGetBuf)`
- `MobaPlayerActionManager$$GetSkillTargetType (ContainsBuffer)`
- `PlayerActionManager$$GetSkillTargetType (ContainsBuffer)`

---

### ฟลายอิ้งคิก (FloatingKick) · uid 1156

<img src="../../icons/sk_1156.png" width="40" alt="icon"> 
**Tree:** クラッシャー (`CrusherSkill`, tier 2) · **Type:** Attack · **Max Lv:** 90 · **Weapons:** Knuckle · **Requires:** วิธีการหายใจ · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `FloatingKickAction`

> กระโดดลอยไปเตะจากระยะไกล
> ถ้าใช้แบบธรรมดาจะเพิ่มความรุนแรงให้โจมตีคริติคอล
> เมื่อใช้ระหว่างเคลื่อนที่จะเล็งตรงเป้า
> โจมตีคริติคอลจะเพิ่มขึ้นในระดับนึงเท่านั้น

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 5.2 | 5.4 | 5.6 | 5.8 | 6 | 6.2 | 6.4 | 6.6 | 6.8 | 7 |
| Flat dmg + | 110 | 120 | 130 | 140 | 150 | 160 | 170 | 180 | 190 | 200 |
| Crit mult + | 0.14 | 0.18 | 0.22 | 0.26 | 0.3 | 0.34 | 0.38 | 0.42 | 0.46 | 0.5 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv + (Lv << 2)) << 2) + 500)) * 0.01)` — !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(target) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05

**Role:** attack (deals damage)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv * 10) + 100))`
- `CriticalRate` multiplies by (adds into): `((((Lv << 2) + 10)) * 0.01)`
- `SkillRate` multiplies by (adds into): `(((((Lv + (Lv << 2)) << 2) + 500)) * 0.01)`

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `int(((UnityEngine.Transform.get_eulerAngles(UnityEngine.Component.get_transform(actarAction)).y gt 180 ? (UnityEngine.Transform.get_eulerAngles(UnityEngine.Component.get_transform(actarAction)).y + -360) : UnityEngine.Transform.get_eulerAngles(UnityEngine.Component.get_transform(actarAction)).y) * 10))` _(when !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(target) AND UnityEngine.Object.op_Inequality(actarAction))_

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1156

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (2 paths)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(7)`
- set `fixAddDamage` = `((Lv * 10) + 100)` → Lv1..10: [110, 120, 130, 140, 150, 160, 170, 180, 190, 200]
- set `skillRate` = `(((Lv + (Lv << 2)) << 2) + 500)` → Lv1..10: [520, 540, 560, 580, 600, 620, 640, 660, 680, 700]
- set `criticalDmgUp` = `((Lv << 2) + 10)` → Lv1..10: [14, 18, 22, 26, 30, 34, 38, 42, 46, 50]

**`ActionPreparation`** (223 paths)

- set `target` = `target` — when !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(target) AND UnityEngine.Object.op_Inequality(actarAction)
- set `charaMove` = `UnityEngine.Component.GetComponent<CharacterMove>(actarAction)` — when !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(target) AND UnityEngine.Object.op_Inequality(actarAction)
- set `moveDir.y` = `(0 / fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))))` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05
- set `moveDir` = `(((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) / fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))))` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05
- set `moveDir.z` = `(((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) / fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))))` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05
- set `inputDirection` = `2` = 2 — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) le 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05
- set `CastTime` = `int(((UnityEngine.Transform.get_eulerAngles(UnityEngine.Component.get_transform(actarAction)).y gt 180 ? (UnityEngine.Transform.get_eulerAngles(UnityEngine.Component.get_transform(actarAction)).y + -360) : UnityEngine.Transform.get_eulerAngles(UnityEngine.Component.get_transform(actarAction)).y) * 10))` — when !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(target) AND UnityEngine.Object.op_Inequality(actarAction)
- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, actarAction, UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))` — when !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(target) AND UnityEngine.Object.op_Inequality(actarAction)
- set `skillRate` = `(skillRate + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1158], 50))` — when !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(target) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05
- set `inputDirection` = `1` = 1 — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) le 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05
- set `inputDirection` = `0` = 0 — when !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(target) AND UnityEngine.Object.op_Inequality(actarAction)
- set `moveDir.y` = `0` = 0 — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) le 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) le 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) le 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05
- set `moveDir` = `UnityEngine.Vector3.static+0x0` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) le 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) le 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) le 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05
- set `moveDir.z` = `UnityEngine.Vector3.static+0x8` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) le 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) le 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) le 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05
- set `SkillIndividualFlag` = `((SkillIndividualFlag | 0) | int(((MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)) + 1) * 10)))` — when !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(target) AND UnityEngine.Object.op_Inequality(actarAction)

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1
- set `otherAngle` = `((?v3 * 0.1) mi 0 ? ((?v3 * 0.1) + 360) : (?v3 * 0.1))`

**`ActionStartOthers`** (1 path)

- set `charaMove` = `UnityEngine.Component.GetComponent<CharacterMove>(actarAction)`

**`SetTargetMobOthers`** (1 path)

- set `target` = `target`

**`calcPlayerToMobDamage`** (8 paths)

- set `dummy` = `PlayerAttackBase.CreateDummyDamageData(this, mobAction)`
- template `AddRate[SkillRate]` = `(skillRate * 0.01)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- template `AddRate[CriticalRate]` = `(criticalDmgUp * 0.01)` — when (!PlayerAttackBase.checkCriticalPercent(this, status.Critical, mobAction) ^ 1) AND (SkillCalcTemplate.get_Item(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 13) + (criticalDmgUp * 0.01)) ls 2 AND inputDirection eq 0
- info `templates` = `1`

**`ActionSkillEvent`** (18 paths)

- set `elapsedTime` = `(elapsedTime + UnityEngine.Time.get_deltaTime())` — when (elapsedTime + UnityEngine.Time.get_deltaTime()) lt 3 AND elapsedTime mi 3 AND param eq 2 OR (elapsedTime + UnityEngine.Time.get_deltaTime()) ge 3 AND (inputDirection - 1) lo 2 AND elapsedTime mi 3 AND param eq 2 OR (elapsedTime + UnityEngine.Time.get_deltaTime()) ge 3 AND (inputDirection - 1) hs 2 AND elapsedTime mi 3 AND inputDirection eq 0 AND param eq 2

</details>

---

### คอมบิเนชั่น (Combination) · uid 1157

<img src="../../icons/sk_1157.png" width="40" alt="icon"> 
**Tree:** クラッシャー (`CrusherSkill`, tier 2) · **Type:** Attack · **Max Lv:** 90 · **Weapons:** MainKnuckle · **Requires:** วิธีการหายใจ · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `CombinationAction`

> ออกหมัดต่อเนื่องอย่างรวดเร็ว
> สกิลนี้โจมตีด้วย[ความเคยชินตามปกติ]
> อัตราคริติคอลเพิ่มขึ้นตามสกิลเลเวลที่เพิ่มขึ้น

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 1.1 | 1.2 | 1.3 | 1.4 | 1.5 | 1.6 | 1.7 | 1.8 | 1.9 | 2 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv + (Lv << 2)) << 1) + 100)) * 0.01)` — UnityEngine.Object.op_Inequality(actarAction)

**Role:** attack (deals damage)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **normal-attack proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillRate` multiplies by (adds into): `(((((Lv + (Lv << 2)) << 1) + 100)) * 0.01)`

**Proration:** slot `Normal`, mode `first_hit_per_target`, attack type `SkillNormal`, action id 1157

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `skillRate` = `(((Lv + (Lv << 2)) << 1) + 100)` → Lv1..10: [110, 120, 130, 140, 150, 160, 170, 180, 190, 200]
- set `critical` = `(Lv * Lv)` → Lv1..10: [1, 4, 9, 16, 25, 36, 49, 64, 81, 100]

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`ActionPreparation`** (3 paths)

- set `skillRate` = `(skillRate + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1158], 50))` — when UnityEngine.Object.op_Inequality(actarAction)

**`calcPlayerToMobDamage`** (8 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)`
- template `AddRate[SkillRate]` = `(skillRate * 0.01)`
- calls `SkillDamageData.CreateNextDamage` = `CreateNextDamage()`
- info `templates` = `1`

**`OnInheritance`** (1 path)

- set `IsInheritance` = `1` = 1

</details>

---

### ก็อดแฮนด์ (GodHand) · uid 1158

<img src="../../icons/sk_1158.png" width="40" alt="icon"> 
**Tree:** クラッシャー (`CrusherSkill`, tier 3) · **Type:** Attack · **Max Lv:** 170 · **Weapons:** MainKnuckle · **Requires:** กลอเรียเทคชอต · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `GodHandAction`

> หมัดปัดเป่าภัยพิบัติ
> ความเสียหายจะลดลงเสมอในขณะใช้งาน
> พลังของครัชเชอร์ที่ใช้ต่อจะเพิ่มขึ้น 60 วินาที
> หากโจมตีโดนหรือลดความเสียหายลงได้สำเร็จ
> 
> (สูงสุดไม่เกิน 3 สแทค)

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 10 | 10 | 10 | 10 | 10 | 10 | 10 | 10 | 10 | 10 |
| Flat dmg + | 40 | 80 | 120 | 160 | 200 | 240 | 280 | 320 | 360 | 400 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((1000) * 0.01)` — UnityEngine.Object.op_Inequality(actarAction)

**Role:** attack (deals damage) · buff (self)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv + (Lv << 2)) << 3))`
- `SkillRate` multiplies by (adds into): `((1000) * 0.01)`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1158

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (2 paths)

- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `skillRate` = `1000` = 1000
- set `fixAddDamage` = `((Lv + (Lv << 2)) << 3)` → Lv1..10: [40, 80, 120, 160, 200, 240, 280, 320, 360, 400]
- set `SkillIndividualFlag` = `1` = 1 — when (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 1161, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey()))

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`ActionPreparation`** (3 paths)

- set `skillRate` = `(skillRate + SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1158], 50))` — when UnityEngine.Object.op_Inequality(actarAction)

**`ActionStart`** (10 paths)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(1158)` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValuePlayerStatusBase.get_SkillBufferManager().skillBufList, 1158, (new GodHandAction.<>c__DisplayClass25_0 + 24), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue!PlayerStatusBase.get_SkillBufferManager().skillBufList, 1158, (new GodHandAction.<>c__DisplayClass25_0 + 24), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValuePlayerStatusBase.get_SkillBufferManager().skillBufList, 1158, (new GodHandAction.<>c__DisplayClass25_0 + 24), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(1158, Lv, new GodHandAction.<>c__DisplayClass25_0.buf.LeftTime)` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValuePlayerStatusBase.get_SkillBufferManager().skillBufList, 1158, (new GodHandAction.<>c__DisplayClass25_0 + 24), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValuePlayerStatusBase.get_SkillBufferManager().skillBufList, 1158, (new GodHandAction.<>c__DisplayClass25_0 + 24), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValuePlayerStatusBase.get_SkillBufferManager().skillBufList, 1158, (new GodHandAction.<>c__DisplayClass25_0 + 24), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) AND MobaMode eq 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(1158, Lv, 0)` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue!PlayerStatusBase.get_SkillBufferManager().skillBufList, 1158, (new GodHandAction.<>c__DisplayClass25_0 + 24), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue!PlayerStatusBase.get_SkillBufferManager().skillBufList, 1158, (new GodHandAction.<>c__DisplayClass25_0 + 24), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue!PlayerStatusBase.get_SkillBufferManager().skillBufList, 1158, (new GodHandAction.<>c__DisplayClass25_0 + 24), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) AND MobaMode eq 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction)

**`calcPlayerToMobDamage`** (2 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)`
- template `AddRate[SkillRate]` = `(skillRate * 0.01)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- info `templates` = `1`

**`OnInheritance`** (1 path)

- set `IsInheritance` = `1` = 1

**`.<>c__DisplayClass25_0::<ActionStart>b__0`** (3 paths)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(1158)` — when (System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValuePlayerStatusBase.get_SkillBufferManager().selfSkillBufList, 1158, (this + 24), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) AND SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1158], 20) eq 0

</details>

**Buffs**

**Buff `GodHandBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `ApplyDamageCut`, `DamageFunction`, `Initalize`, `Next`, `SkillEnd`, `get_BufEffectTakeId`, `get_IsGodRigidBodyMastery`, `get_IsSkillEnd`
- Duration: `time` s [Lv hi 9 OR 1 ge (10 - lv) AND Lv ls 9 OR 1 lt (10 - lv) AND 2 ge (10 - lv) AND Lv ls 9]
- `Value` = `((((stack) * Lv) + (((stack) * Lv) << 2)) << 1)` _(when BuffEffectActive ne 0)_
- `AbnormalRegist` = `SkillMasteryBase.GetMasteryParam(MasteryId.Value)` _(when BuffEffectActive ne 0; isSkillEnd eq 0)_
- `AbnormalRegist` = `0` _(when BuffEffectActive ne 0; isSkillEnd eq 0)_
- `MobLastDamageRateBuf` = `SkillMasteryBase.GetMasteryParam(MasteryId.CutDmgRate)` _(when BuffEffectActive ne 0; isSkillEnd eq 0)_
- `MobLastDamageRateBuf` = `0` _(when BuffEffectActive ne 0; isSkillEnd eq 0)_
- `MobLastDamageRateUnique` = `0` _(when BuffEffectActive ne 0; isSkillEnd ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MobLastDamageRateUnique | 72 | 72 | 72 | 72 | 72 | 72 | 72 | 72 | 72 | 72 |

- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `damageDownRate` = `72` = 72 when 1 ge (10 - lv) AND Lv ls 9
  - `damageDownRate` = `57` = 57 when 1 lt (10 - lv) AND 2 ge (10 - lv) AND Lv ls 9
  - `damageDownRate` = `45` = 45 when 1 lt (10 - lv) AND 2 lt (10 - lv) AND 3 ge (10 - lv) AND Lv ls 9
  - `damageDownRate` = `90` = 90 when Lv hi 9 OR 1 lt (10 - lv) AND 2 lt (10 - lv) AND 3 lt (10 - lv) AND Lv ls 9
  - `Count` = `stack` when Lv hi 9 OR 1 ge (10 - lv) AND Lv ls 9 OR 1 lt (10 - lv) AND 2 ge (10 - lv) AND Lv ls 9
  - `isSkillEnd` = `0` when Lv hi 9 OR 1 ge (10 - lv) AND Lv ls 9 OR 1 lt (10 - lv) AND 2 ge (10 - lv) AND Lv ls 9
- Hook `Next`: `LeftTime`=60
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `SkillEnd`: `isSkillEnd`=1; `isDeathExemption`=0
- Hook `Initalize`: `playerStatus`=status; `isDeathExemption`=1
- Hook `ApplyDamageCut`: `isCutDamage`=1
- Hook `DamageFunction`: `isCutDamage`=0

<details><summary>Effect applied in `PlayerActionManager$$Damaged` (9 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 706, stkp(-152), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-152), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-152), 0) & 1) ne 0`
  - returns `ImprovisationSongAction.Damaged(this, 0, ?x2, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `GodHandBuf$$DamageFunction`, `ImprovisationSongAction$$Damaged`
- when `(SkillBufferManager.TryGetBuf(?blr, 706, stkp(-152), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-152), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-152), 0) & 1) eq 0`
  - returns `ImprovisationSongAction.Damaged(this, 0, ?x2, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `ImprovisationSongAction$$Damaged`
- when `(SkillBufferManager.TryGetBuf(?blr, 706, stkp(-152), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-152), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-152), 0) & 1) ne 0`
  - returns `ImprovisationSongAction.Damaged(this, 0, ?x2, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `GodHandBuf$$DamageFunction`, `ImprovisationSongAction$$Damaged`
- when `(SkillBufferManager.TryGetBuf(?blr, 706, stkp(-152), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-152), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-152), 0) & 1) eq 0`
  - returns `ImprovisationSongAction.Damaged(this, 0, ?x2, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `ImprovisationSongAction$$Damaged`
- when `(SkillBufferManager.TryGetBuf(?blr, 706, stkp(-152), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-152), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-152), 0) & 1) ne 0`
  - returns `ImprovisationSongAction.Damaged(this, 0, ?x2, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `GodHandBuf$$DamageFunction`, `ImprovisationSongAction$$Damaged`
- when `(SkillBufferManager.TryGetBuf(?blr, 706, stkp(-152), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-152), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-152), 0) & 1) eq 0`
  - returns `ImprovisationSongAction.Damaged(this, 0, ?x2, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `ImprovisationSongAction$$Damaged`
- when `(SkillBufferManager.TryGetBuf(?blr, 706, stkp(-152), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-152), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-152), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `ImprovisationSongAction.Damaged(this, 0, ?x2, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `GodHandBuf$$DamageFunction`, `ImprovisationSongAction$$Damaged`
- when `(SkillBufferManager.TryGetBuf(?blr, 706, stkp(-152), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-152), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-152), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `0x165db84`, `0x165df00`, `0x165df00`

</details>

<details><summary>Effect applied in `MobaPlayerSecondaryStatus$$get_AntiVirus` (27 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 145, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1158, stkp(-40), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 713, stkp(-40), 0) & 1) ne 0`
  - returns `((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 37, 0, ?x3) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 37, 0, ?x3) + ((((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) lt 100 ? ((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) : 100) + (BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 44, 0, ?x3) + (((MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) + (MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) << 2)) << 1) // 34)))))) lt 100 ? (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 37, 0, ?x3) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 37, 0, ?x3) + ((((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) lt 100 ? ((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) : 100) + (BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 44, 0, ?x3) + (((MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) + (MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) << 2)) << 1) // 34)))))) : 100)`
  - calls `MobaPlayerSecondaryStatus$$get_Men`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`, `virtual CharacterActionManagerBase.get_IsValid`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 145, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1158, stkp(-40), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 713, stkp(-40), 0) & 1) ne 0`
  - returns `((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 37, 0, ?x3) + ((((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) lt 100 ? ((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) : 100) + (BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 44, 0, ?x3) + (((MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) + (MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) << 2)) << 1) // 34))))) lt 100 ? (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 37, 0, ?x3) + ((((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) lt 100 ? ((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) : 100) + (BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 44, 0, ?x3) + (((MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) + (MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) << 2)) << 1) // 34))))) : 100)`
  - calls `MobaPlayerSecondaryStatus$$get_Men`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`, `virtual CharacterActionManagerBase.get_IsValid`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 145, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1158, stkp(-40), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 713, stkp(-40), 0) & 1) eq 0`
  - returns `((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 37, 0, ?x3) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 37, 0, ?x3) + ((((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) lt 100 ? ((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) : 100) + (BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 44, 0, ?x3) + (((MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) + (MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) << 2)) << 1) // 34))))) lt 100 ? (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 37, 0, ?x3) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 37, 0, ?x3) + ((((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) lt 100 ? ((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) : 100) + (BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 44, 0, ?x3) + (((MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) + (MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) << 2)) << 1) // 34))))) : 100)`
  - calls `MobaPlayerSecondaryStatus$$get_Men`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`, `virtual CharacterActionManagerBase.get_IsValid`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 145, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1158, stkp(-40), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 713, stkp(-40), 0) & 1) eq 0`
  - returns `((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 37, 0, ?x3) + ((((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) lt 100 ? ((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) : 100) + (BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 44, 0, ?x3) + (((MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) + (MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) << 2)) << 1) // 34)))) lt 100 ? (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 37, 0, ?x3) + ((((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) lt 100 ? ((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) : 100) + (BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 44, 0, ?x3) + (((MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) + (MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) << 2)) << 1) // 34)))) : 100)`
  - calls `MobaPlayerSecondaryStatus$$get_Men`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`, `virtual CharacterActionManagerBase.get_IsValid`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 145, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1158, stkp(-40), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 713, stkp(-40), 0) & 1) ne 0`
  - returns `((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 37, 0, ?x3) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + ((((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) lt 100 ? ((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) : 100) + (BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 44, 0, ?x3) + (((MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) + (MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) << 2)) << 1) // 34))))) lt 100 ? (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 37, 0, ?x3) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + ((((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) lt 100 ? ((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) : 100) + (BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 44, 0, ?x3) + (((MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) + (MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) << 2)) << 1) // 34))))) : 100)`
  - calls `MobaPlayerSecondaryStatus$$get_Men`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 145, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1158, stkp(-40), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 713, stkp(-40), 0) & 1) ne 0`
  - returns `((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + ((((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) lt 100 ? ((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) : 100) + (BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 44, 0, ?x3) + (((MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) + (MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) << 2)) << 1) // 34)))) lt 100 ? (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + ((((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) lt 100 ? ((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) : 100) + (BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 44, 0, ?x3) + (((MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) + (MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) << 2)) << 1) // 34)))) : 100)`
  - calls `MobaPlayerSecondaryStatus$$get_Men`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 145, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1158, stkp(-40), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 713, stkp(-40), 0) & 1) eq 0`
  - returns `((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 37, 0, ?x3) + ((((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) lt 100 ? ((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) : 100) + (BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 44, 0, ?x3) + (((MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) + (MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) << 2)) << 1) // 34)))) lt 100 ? (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 37, 0, ?x3) + ((((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) lt 100 ? ((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) : 100) + (BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 44, 0, ?x3) + (((MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) + (MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) << 2)) << 1) // 34)))) : 100)`
  - calls `MobaPlayerSecondaryStatus$$get_Men`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsValid`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 145, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1158, stkp(-40), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 713, stkp(-40), 0) & 1) eq 0`
  - returns `(((((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) lt 100 ? ((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) : 100) + (BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 44, 0, ?x3) + (((MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) + (MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) << 2)) << 1) // 34))) lt 100 ? ((((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) lt 100 ? ((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) : 100) + (BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 44, 0, ?x3) + (((MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) + (MobaPlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) << 2)) << 1) // 34))) : 100)`
  - calls `MobaPlayerSecondaryStatus$$get_Men`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsValid`

</details>

<details><summary>Effect applied in `PlayerSecondaryStatus$$CalcAntiVirus` (27 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 145, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1158, stkp(-40), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 713, stkp(-40), 0) & 1) ne 0`
  - returns `System.Math.Max((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 37, 0, ?x3) + ((((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) lt 100 ? ((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) : 100) + (BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 44, 0, ?x3) + (((PlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) + (PlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) << 2)) << 1) // 34))))), SkillBufferDataBase.GetParam(TryGetBuf.out2(), 37, 0, ?x3), 0, ?x3)`
  - calls `PlayerSecondaryStatus$$get_Men`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`, `virtual CharacterActionManagerBase.get_IsValid`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 145, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1158, stkp(-40), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 713, stkp(-40), 0) & 1) ne 0`
  - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 37, 0, ?x3) + ((((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) lt 100 ? ((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) : 100) + (BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 44, 0, ?x3) + (((PlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) + (PlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) << 2)) << 1) // 34)))))`
  - calls `PlayerSecondaryStatus$$get_Men`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`, `virtual CharacterActionManagerBase.get_IsValid`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 145, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1158, stkp(-40), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 713, stkp(-40), 0) & 1) eq 0`
  - returns `System.Math.Max((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 37, 0, ?x3) + ((((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) lt 100 ? ((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) : 100) + (BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 44, 0, ?x3) + (((PlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) + (PlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) << 2)) << 1) // 34)))), SkillBufferDataBase.GetParam(TryGetBuf.out2(), 37, 0, ?x3), 0, ?x3)`
  - calls `PlayerSecondaryStatus$$get_Men`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`, `virtual CharacterActionManagerBase.get_IsValid`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 145, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1158, stkp(-40), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 713, stkp(-40), 0) & 1) eq 0`
  - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 37, 0, ?x3) + ((((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) lt 100 ? ((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) : 100) + (BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 44, 0, ?x3) + (((PlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) + (PlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) << 2)) << 1) // 34))))`
  - calls `PlayerSecondaryStatus$$get_Men`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`, `virtual CharacterActionManagerBase.get_IsValid`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 145, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1158, stkp(-40), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 713, stkp(-40), 0) & 1) ne 0`
  - returns `System.Math.Max((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + ((((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) lt 100 ? ((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) : 100) + (BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 44, 0, ?x3) + (((PlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) + (PlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) << 2)) << 1) // 34)))), SkillBufferDataBase.GetParam(TryGetBuf.out2(), 37, 0, ?x3), 0, ?x3)`
  - calls `PlayerSecondaryStatus$$get_Men`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 145, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1158, stkp(-40), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 713, stkp(-40), 0) & 1) ne 0`
  - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + ((((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) lt 100 ? ((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) : 100) + (BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 44, 0, ?x3) + (((PlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) + (PlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) << 2)) << 1) // 34))))`
  - calls `PlayerSecondaryStatus$$get_Men`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 145, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1158, stkp(-40), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 713, stkp(-40), 0) & 1) eq 0`
  - returns `System.Math.Max(((((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) lt 100 ? ((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) : 100) + (BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 44, 0, ?x3) + (((PlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) + (PlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) << 2)) << 1) // 34))), SkillBufferDataBase.GetParam(TryGetBuf.out2(), 37, 0, ?x3), 0, ?x3)`
  - calls `PlayerSecondaryStatus$$get_Men`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsValid`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 145, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1158, stkp(-40), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 713, stkp(-40), 0) & 1) eq 0`
  - returns `((((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) lt 100 ? ((([CharacterActionManagerBase.get_Size()+0x18] // 100) + (([CharacterActionManagerBase.get_Size()+0x18] // 100) << 2)) << 1) : 100) + (BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 44, 0, ?x3) + (((PlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) + (PlayerSecondaryStatus.get_Men(this, ?x1, ?x2, ?x3) << 2)) << 1) // 34)))`
  - calls `PlayerSecondaryStatus$$get_Men`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsValid`

</details>

<details><summary>Effect applied in `MobaPlayerActionManager$$ReceiveDamaged` (296 guarded paths, truncated)</summary>

- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `UnityEngine.Object.op_Inequality([[battleManager+0x48]+0x20], 0, 0, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `BattleManagerBase.TargetData.SetTarget([battleManager+0x58], UnityEngine.Component.get_gameObject(otherPlayer, 0, ?x2, ?x3), UnityEngine.Component.GetComponent<object>(otherPlayer, meta(0x3982c60, Method$UnityEngine.Component.GetComponent<CharacterActionManagerBase>()), ?x2, ?x3), 0)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `MobaDuelAbilityManager.ContaintsAbility([playerStatus+0x90], 27, 0, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `UnityEngine.Object.op_Inequality([[battleManager+0x48]+0x20], 0, 0, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `BattleManagerBase.TargetData.SetTarget([battleManager+0x58], UnityEngine.Component.get_gameObject(otherPlayer, 0, ?x2, ?x3), UnityEngine.Component.GetComponent<object>(otherPlayer, meta(0x3982c60, Method$UnityEngine.Component.GetComponent<CharacterActionManagerBase>()), ?x2, ?x3), 0)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `MobaDuelAbilityManager.ContaintsAbility([playerStatus+0x90], 27, 0, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `UnityEngine.Object.op_Inequality([[battleManager+0x48]+0x20], 0, 0, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `BattleManagerBase.TargetData.SetTarget([battleManager+0x58], UnityEngine.Component.get_gameObject(otherPlayer, 0, ?x2, ?x3), UnityEngine.Component.GetComponent<object>(otherPlayer, meta(0x3982c60, Method$UnityEngine.Component.GetComponent<CharacterActionManagerBase>()), ?x2, ?x3), 0)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`

</details>

<details><summary>Effect applied in `GazerShootAction$$ActionPreparation` (3 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `skillRate` = `(skillRate + CharacterActionManagerBase.set_DefaultMoveSpeed())`
  - set `physicsBreaker` = `((physicsBreaker * CharacterActionManagerBase.set_DefaultMoveSpeed()) + physicsBreaker)`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-40), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-40), 0)`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`

</details>

<details><summary>Effect applied in `GodHandAction$$ActionHit` (3 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `?blr`
  - calls `SkillActionBase$$ActionHit`, `System.Collections.Generic.List<object>$$get_Item`
- when `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `SkillActionBase$$ActionHit`, `System.Collections.Generic.List<object>$$get_Item`, `0x165db84`, `0x165df00`
- when `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-40), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-40), 0)`
  - calls `SkillActionBase$$ActionHit`, `System.Collections.Generic.List<object>$$get_Item`

</details>

<details><summary>Effect applied in `MindimageSenjuAttackAction$$ActionHit` (3 guarded paths)</summary>

- when `IsInheritance ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() ne 844` AND `CharacterActionManagerBase.get_IsLocalDead() eq 1158` AND `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-56), 0) & 1) ne 0`
  - returns `?blr`
  - calls `SkillActionBase$$ActionHit`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`
- when `IsInheritance ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() ne 844` AND `CharacterActionManagerBase.get_IsLocalDead() eq 1158` AND `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-56), 0) & 1) ne 0`
  - calls `SkillActionBase$$ActionHit`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `0x165db84`, `0x165df00`
- when `IsInheritance ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() ne 844` AND `CharacterActionManagerBase.get_IsLocalDead() eq 1158` AND `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-56), 0) & 1) eq 0`
  - returns `?blr`
  - calls `SkillActionBase$$ActionHit`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `SkillBufferManager$$AddSelfBuffer`, `GodHandBuf$$Initalize`, `GodHandBuf$$SkillEnd`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `GazerShootAction$$ActionPreparation (TryGetBuf)`
- `GodHandAction$$ActionHit (TryGetBuf)`
- `MindimageSenjuAttackAction$$ActionHit (TryGetBuf)`
- `MobaPlayerActionManager$$ReceiveDamaged (GetSkillLv)`
- `MobaPlayerActionManager$$ReceiveDamaged (TryGetBuf)`
- `MobaPlayerSecondaryStatus$$get_AntiVirus (TryGetBuf)`
- `PlayerActionManager$$Damaged (TryGetBuf)`
- `PlayerSecondaryStatus$$CalcAntiVirus (TryGetBuf)`

---

### ผู้ทำลายล้าง (Destroyer) · uid 1159

<img src="../../icons/sk_1159.png" width="40" alt="icon"> 
**Tree:** クラッシャー (`CrusherSkill`, tier 3) · **Type:** Buffer · **Max Lv:** 170 · **Weapons:** Knuckle · **Requires:** คอมบิเนชั่น · **Flags:** StarGem · **Client class:** `DestroyerAction`

> แก่นแท้แห่งการทำลายล้าง
> เมื่อเรียนรู้สกิลนี้แล้วจะมีผลเป็นพาสซีฟ
> เพิ่มปริมาณการฟื้นฟู HP ของวิธีการหายใจ เมื่อถึง Lv10 จะเพิ่มผลลด MP ที่ใช้กับสกิล
> ถ้าใช้กับสนับมือจะได้ผลลัพธ์ที่ดียิ่งขึ้น

<details><summary>In-game level notes</summary>

- Lv16: [ผลลัพธ์ด้านล่างจะใช้ได้กับอาวุธหลักเท่านั้น] *ระหว่างได้รับผลของบัฟ ATK อาวุธจะเพิ่มขึ้น อัตราการลดการป้องกันที่เกิดจาก[เชลเบรค]จะเพิ่มขึ้นแต่ความเสถียรจะลดลง และจะไม่สามารถใช้งานผงะ/ล้มคว่ำ/หมดสติ/ผลักกระเด็นได้

</details>

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `SkillUtil.CalcCastTime(0, PlayerStatusBase.get_BattleStatus())`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1159

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `CastTime` = `SkillUtil.CalcCastTime(0, PlayerStatusBase.get_BattleStatus())`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (2 paths)

- calls `DestroyerBuf..ctor` = `.ctor(Lv, PlayerActionManagerBase.get_PlayerStatus())` — when UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new DestroyerBuf, Id)` — when UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(872)` — when UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(894)` — when UnityEngine.Object.op_Inequality(actarAction)

**`OnInheritance`** (1 path)

- set `IsInheritance` = `1` = 1

</details>

**Buffs**

**Buff `DestroyerBuf`**
- Buff hook methods: `get_IsMainKnuckleEquip`
- `BaseEqAtkUpRate` = `0` _(when BuffEffectActive ne 0; isMainKnuckleEquip eq 0)_
- `Value` = `0` _(when BuffEffectActive ne 0; isMainKnuckleEquip eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| BaseEqAtkUpRate | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |
| Value | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |
| Stable | -10 | -10 | -10 | -10 | -10 | -10 | -10 | -10 | -10 | -10 |

- Buff fields set in the constructor (all recovered):
  - `isMainKnuckleEquip` = `1` = 1
  - `status` = `status`
- Hook `Updata`: `LeftTime`=0; `isMainKnuckleEquip`=(PlayerStatusBase.GetEquip(status, 1).Type eq 16 ? 1 : 0); `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:DestroyerBuf$$.ctor<-DestroyerAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

<details><summary>Effect applied in `EnchantedBurstAction$$ActionHit` (4 guarded paths)</summary>

- when `(flag & 1) ne 0` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 872, stkp(-40), meta(0x399ee38, Method$SkillBufferManager.TryGetBuf<EnchantedBurstBuf>())) & 1) eq 0`
  - returns `EnchantedBurstBuf.LocalNext(0x165db78(meta(0x39a8788, EnchantedBurstBuf_TypeInfo), ?x1, ?x2, ?x3), PlayerAttackBase.GetSkillIdData(this, 0, ?x2, ?x3), 0, ?x3)`
  - calls `SkillActionBase$$ActionHit`, `0x165db78`, `EnchantedBurstBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `PlayerAttackBase$$GetSkillIdData`, `EnchantedBurstBuf$$LocalNext`
- when `(flag & 1) ne 0` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 872, stkp(-40), meta(0x399ee38, Method$SkillBufferManager.TryGetBuf<EnchantedBurstBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
  - returns `EnchantedBurstBuf.LocalNext(TryGetBuf<object>.out2(), PlayerAttackBase.GetSkillIdData(this, 0, ?x2, ?x3), 0, ?x3)`
  - calls `SkillActionBase$$ActionHit`, `PlayerAttackBase$$GetSkillIdData`, `EnchantedBurstBuf$$LocalNext`
- when `(flag & 1) ne 0` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 872, stkp(-40), meta(0x399ee38, Method$SkillBufferManager.TryGetBuf<EnchantedBurstBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() eq 0`
  - calls `SkillActionBase$$ActionHit`, `PlayerAttackBase$$GetSkillIdData`, `0x165db84`
- when `(flag & 1) ne 0`
  - returns `SkillBufferManager.ContainsBuffer(?blr, 1159, 0, ?x3)`
  - calls `SkillActionBase$$ActionHit`

</details>

<details><summary>Effect applied in `EnchantedBurstAction$$AddLocalStack` (6 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 872, stkp(-56), meta(0x399ee38, Method$SkillBufferManager.TryGetBuf<EnchantedBurstBuf>())) & 1) eq 0` AND `SkillLv(872) ge 1`
  - returns `EnchantedBurstBuf.LocalNext(0x165db78(meta(0x39a8788, EnchantedBurstBuf_TypeInfo), ?x1, ?x2, ?x3), skillId, skillLocalId, 0)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`, `0x165db78`, `EnchantedBurstBuf$$.ctor`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferManager$$AddSelfBuffer`
- when `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 872, stkp(-56), meta(0x399ee38, Method$SkillBufferManager.TryGetBuf<EnchantedBurstBuf>())) & 1) eq 0` AND `SkillLv(872) lt 1` AND `TryGetBuf<object>.out2() ne 0`
  - returns `EnchantedBurstBuf.LocalNext(TryGetBuf<object>.out2(), skillId, skillLocalId, 0)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`, `EnchantedBurstBuf$$LocalNext`
- when `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 872, stkp(-56), meta(0x399ee38, Method$SkillBufferManager.TryGetBuf<EnchantedBurstBuf>())) & 1) eq 0` AND `SkillLv(872) lt 1` AND `TryGetBuf<object>.out2() eq 0`
  - returns `TryGetBuf<object>.out2()`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`
- when `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 872, stkp(-56), meta(0x399ee38, Method$SkillBufferManager.TryGetBuf<EnchantedBurstBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
  - returns `EnchantedBurstBuf.LocalNext(TryGetBuf<object>.out2(), skillId, skillLocalId, 0)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `EnchantedBurstBuf$$LocalNext`
- when `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 872, stkp(-56), meta(0x399ee38, Method$SkillBufferManager.TryGetBuf<EnchantedBurstBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() eq 0`
  - returns `TryGetBuf<object>.out2()`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- always
  - returns `SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), 1159, 0, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`

</details>

<details><summary>Effect applied in `EnchantedSwordAction$$ActionPreparation` (16 guarded paths)</summary>

- when `WeaponType eq 11`
  - set `enchantedBurstStack` = `1`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `PlayerAttackBase$$CheckSkillIndividualFlag`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `WeaponType eq 11`
  - returns `0x165d8dc(this, 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
  - set `enchantedBurstStack` = `1`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `PlayerAttackBase$$CheckSkillIndividualFlag`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `WeaponType ne 11` AND `(WeaponType - 10) ls 6`
  - set `enchantedBurstStack` = `1`
  - set `SkillIndividualFlag` = `1`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `PlayerAttackBase$$CheckSkillIndividualFlag`
- when `WeaponType ne 11` AND `(WeaponType - 10) hi 6`
  - set `enchantedBurstStack` = `1`
  - set `SkillIndividualFlag` = `1`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `PlayerAttackBase$$CheckSkillIndividualFlag`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `WeaponType ne 11` AND `(WeaponType - 10) hi 6`
  - returns `0x165d8dc(this, 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
  - set `enchantedBurstStack` = `1`
  - set `SkillIndividualFlag` = `1`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `PlayerAttackBase$$CheckSkillIndividualFlag`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `(WeaponType - 10) ls 6`
  - set `enchantedBurstStack` = `1`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `PlayerAttackBase$$CheckSkillIndividualFlag`
- when `(WeaponType - 10) hi 6`
  - set `enchantedBurstStack` = `1`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `PlayerAttackBase$$CheckSkillIndividualFlag`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `(WeaponType - 10) hi 6`
  - returns `0x165d8dc(this, 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
  - set `enchantedBurstStack` = `1`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `PlayerAttackBase$$CheckSkillIndividualFlag`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`

</details>

<details><summary>Effect applied in `EquipItemData.WeaponTypeCalculatorBase$$CalcEqAtk` (295 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1159, stkp(-80), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 147, stkp(-80), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-80), 0) & 1) ne 0`
  - returns `(((((((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3)) * ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) // 100) + ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) + int((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 8, 0, ?x3) / 100)) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 9, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
  - calls `virtual PlayerStatusBase.get_BonusManager`, `BonusManager$$GetBonusConstant_Rate`, `virtual EquipItemData.WeaponTypeCalculatorBase.calcEqAtkBonus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1159, stkp(-80), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 147, stkp(-80), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-80), 0) & 1) ne 0`
  - returns `(((((((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?mi, ?x3)) * ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?mi, ?x3))) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) // 100) + ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?mi, ?x3))) + int(((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 8, 0, ?x3) / 100)) + (CharacterActionManagerBase.get_Size() / 100)) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 9, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
  - calls `virtual PlayerStatusBase.get_BonusManager`, `BonusManager$$GetBonusConstant_Rate`, `virtual EquipItemData.WeaponTypeCalculatorBase.calcEqAtkBonus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1159, stkp(-80), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 147, stkp(-80), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-80), 0) & 1) ne 0`
  - returns `(((((((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3)) * ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) // 100) + ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) + int((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 8, 0, ?x3) / 100)) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 9, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
  - calls `virtual PlayerStatusBase.get_BonusManager`, `BonusManager$$GetBonusConstant_Rate`, `virtual EquipItemData.WeaponTypeCalculatorBase.calcEqAtkBonus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1159, stkp(-80), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 147, stkp(-80), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-80), 0) & 1) ne 0`
  - calls `virtual PlayerStatusBase.get_BonusManager`, `BonusManager$$GetBonusConstant_Rate`, `virtual EquipItemData.WeaponTypeCalculatorBase.calcEqAtkBonus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1159, stkp(-80), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 147, stkp(-80), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-80), 0) & 1) ne 0`
  - returns `(((((((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3)) * ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) // 100) + ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) + int((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 8, 0, ?x3) / 100)) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 9, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
  - calls `virtual PlayerStatusBase.get_BonusManager`, `BonusManager$$GetBonusConstant_Rate`, `virtual EquipItemData.WeaponTypeCalculatorBase.calcEqAtkBonus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1159, stkp(-80), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 147, stkp(-80), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-80), 0) & 1) ne 0`
  - returns `(((((((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3)) * ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) // 100) + ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) + int((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 8, 0, ?x3) / 100)) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 9, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
  - calls `virtual PlayerStatusBase.get_BonusManager`, `BonusManager$$GetBonusConstant_Rate`, `virtual EquipItemData.WeaponTypeCalculatorBase.calcEqAtkBonus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1159, stkp(-80), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 147, stkp(-80), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-80), 0) & 1) ne 0`
  - returns `(((((((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3)) * ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) * ((CharacterActionManagerBase.set_DefaultMoveSpeed() + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) // 100) + ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) + int((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 8, 0, ?x3) / 100)) * ((CharacterActionManagerBase.set_DefaultMoveSpeed() + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 9, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
  - calls `virtual PlayerStatusBase.get_BonusManager`, `BonusManager$$GetBonusConstant_Rate`, `virtual EquipItemData.WeaponTypeCalculatorBase.calcEqAtkBonus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1159, stkp(-80), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 147, stkp(-80), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-80), 0) & 1) ne 0`
  - returns `(((((((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?mi, ?x3)) * ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?mi, ?x3))) * ((CharacterActionManagerBase.set_DefaultMoveSpeed() + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) // 100) + ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?mi, ?x3))) + int(((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 8, 0, ?x3) / 100)) + (CharacterActionManagerBase.get_Size() / 100)) * ((CharacterActionManagerBase.set_DefaultMoveSpeed() + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 9, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
  - calls `virtual PlayerStatusBase.get_BonusManager`, `BonusManager$$GetBonusConstant_Rate`, `virtual EquipItemData.WeaponTypeCalculatorBase.calcEqAtkBonus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`

</details>

<details><summary>Effect applied in `GeoImpactAction$$calcPlayerToMobDamage` (4 guarded paths)</summary>

- always
  - set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction, 0)`
  - template `AddRate[SkillRate]` = `(skillRate * 0.01)`
  - template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
  - calls `PlayerAttackBase$$GetWeaponElementType`, `interface IPlayerStatusCalculator.get_Critical`, `PlayerAttackBase$$checkCriticalPercent`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$Contains`, `0x165db78`, `SkillCalcTemplate$$.ctor`, `virtual GeoImpactAction.get_AttackType`
- always
  - set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction, 0)`
  - template `AddRate[SkillRate]` = `(skillRate * 0.01)`
  - template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
  - calls `PlayerAttackBase$$GetWeaponElementType`, `interface IPlayerStatusCalculator.get_Critical`, `PlayerAttackBase$$checkCriticalPercent`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$Contains`, `0x165db78`, `SkillCalcTemplate$$.ctor`, `virtual GeoImpactAction.get_AttackType`
- always
  - set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction, 0)`
  - template `AddRate[SkillRate]` = `(skillRate * 0.01)`
  - template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
  - calls `PlayerAttackBase$$GetWeaponElementType`, `interface IPlayerStatusCalculator.get_Critical`, `PlayerAttackBase$$checkCriticalPercent`, `0x165db78`, `SkillCalcTemplate$$.ctor`, `virtual GeoImpactAction.get_AttackType`, `PlayerAttackBase$$TemplateAssignment`, `0x165db78`
- always
  - set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction, 0)`
  - template `AddRate[SkillRate]` = `(skillRate * 0.01)`
  - template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
  - calls `PlayerAttackBase$$GetWeaponElementType`, `interface IPlayerStatusCalculator.get_Critical`, `PlayerAttackBase$$checkCriticalPercent`, `0x165db78`, `SkillCalcTemplate$$.ctor`, `virtual GeoImpactAction.get_AttackType`, `PlayerAttackBase$$TemplateAssignment`, `0x165db78`

</details>

<details><summary>Effect applied in `MindimageSenjuAttackAction$$CalcDamageGeoImpact` (8 guarded paths)</summary>

- always
  - template `AddRate[SkillRate]` = `(skillRate[0] * 0.01)`
  - template `AddConstant[SkillConstantDamage]` = `fixAddDamage[0]`
  - calls `interface IPlayerStatusCalculator.get_Critical`, `PlayerAttackBase$$checkCriticalPercent`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$Contains`, `0x165db78`, `SkillCalcTemplate$$.ctor`, `virtual MindimageSenjuAttackAction.get_AttackType`, `PlayerAttackBase$$TemplateAssignment`
- always
  - template `AddRate[SkillRate]` = `(skillRate[0] * 0.01)`
  - template `AddConstant[SkillConstantDamage]` = `fixAddDamage[0]`
  - calls `interface IPlayerStatusCalculator.get_Critical`, `PlayerAttackBase$$checkCriticalPercent`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$Contains`, `0x165db78`, `SkillCalcTemplate$$.ctor`, `virtual MindimageSenjuAttackAction.get_AttackType`, `PlayerAttackBase$$TemplateAssignment`
- always
  - template `AddRate[SkillRate]` = `(skillRate[0] * 0.01)`
  - calls `interface IPlayerStatusCalculator.get_Critical`, `PlayerAttackBase$$checkCriticalPercent`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$Contains`, `0x165db78`, `SkillCalcTemplate$$.ctor`, `virtual MindimageSenjuAttackAction.get_AttackType`, `PlayerAttackBase$$TemplateAssignment`
- always
  - calls `interface IPlayerStatusCalculator.get_Critical`, `PlayerAttackBase$$checkCriticalPercent`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$Contains`, `0x165db78`, `SkillCalcTemplate$$.ctor`, `virtual MindimageSenjuAttackAction.get_AttackType`, `PlayerAttackBase$$TemplateAssignment`
- always
  - template `AddRate[SkillRate]` = `(skillRate[0] * 0.01)`
  - template `AddConstant[SkillConstantDamage]` = `fixAddDamage[0]`
  - calls `interface IPlayerStatusCalculator.get_Critical`, `PlayerAttackBase$$checkCriticalPercent`, `0x165db78`, `SkillCalcTemplate$$.ctor`, `virtual MindimageSenjuAttackAction.get_AttackType`, `PlayerAttackBase$$TemplateAssignment`, `0x165db78`, `SkillActionBase.DamageData$$.ctor`
- always
  - template `AddRate[SkillRate]` = `(skillRate[0] * 0.01)`
  - template `AddConstant[SkillConstantDamage]` = `fixAddDamage[0]`
  - calls `interface IPlayerStatusCalculator.get_Critical`, `PlayerAttackBase$$checkCriticalPercent`, `0x165db78`, `SkillCalcTemplate$$.ctor`, `virtual MindimageSenjuAttackAction.get_AttackType`, `PlayerAttackBase$$TemplateAssignment`, `0x165db78`, `SkillActionBase.DamageData$$.ctor`
- always
  - template `AddRate[SkillRate]` = `(skillRate[0] * 0.01)`
  - calls `interface IPlayerStatusCalculator.get_Critical`, `PlayerAttackBase$$checkCriticalPercent`, `0x165db78`, `SkillCalcTemplate$$.ctor`, `virtual MindimageSenjuAttackAction.get_AttackType`, `PlayerAttackBase$$TemplateAssignment`, `0x165db8c`
- always
  - calls `interface IPlayerStatusCalculator.get_Critical`, `PlayerAttackBase$$checkCriticalPercent`, `0x165db78`, `SkillCalcTemplate$$.ctor`, `virtual MindimageSenjuAttackAction.get_AttackType`, `PlayerAttackBase$$TemplateAssignment`, `0x165db8c`

</details>

<details><summary>Effect applied in `ShellBreakAction$$OnInitialize` (12 guarded paths)</summary>

- when `(PlayerAttackBase.ExistWeaponType(actarAction, 16, stkp(-56), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1159, stkp(-64), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add(meta(0), 7, PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `WeaponType` = `16`
  - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(ExistWeaponType.out2(), 0, ?x2, ?x3)`
  - set `skillRate` = `(((Lv + (Lv << 2)) + 100) + 50)`
  - set `fixAddDamage` = `(((Lv + (Lv << 2)) << 1) + 200)`
  - set `breakPercent` = `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + (GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 208, 0, ?x3), 2, 0, ?x3) + ((int(((Lv * 0.5) + Lv)) + 10) + 25)))`
  - set `disDefParcent` = `(Lv + (Lv << 2))`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`, `SkillBufferDataBase$$GetParam`, `PlayerAttackBase$$CalcMotionSpeed`
- when `(PlayerAttackBase.ExistWeaponType(actarAction, 16, stkp(-56), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1159, stkp(-64), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `WeaponType` = `16`
  - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(ExistWeaponType.out2(), 0, ?x2, ?x3)`
  - set `skillRate` = `(((Lv + (Lv << 2)) + 100) + 50)`
  - set `fixAddDamage` = `(((Lv + (Lv << 2)) << 1) + 200)`
  - set `breakPercent` = `(GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 208, 0, ?x3), 2, 0, ?x3) + ((int(((Lv * 0.5) + Lv)) + 10) + 25))`
  - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`, `0x165db84`
- when `(PlayerAttackBase.ExistWeaponType(actarAction, 16, stkp(-56), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1159, stkp(-64), 0) & 1) eq 0`
  - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add(meta(0), 7, PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `WeaponType` = `16`
  - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(ExistWeaponType.out2(), 0, ?x2, ?x3)`
  - set `skillRate` = `(((Lv + (Lv << 2)) + 100) + 50)`
  - set `fixAddDamage` = `(((Lv + (Lv << 2)) << 1) + 200)`
  - set `breakPercent` = `(GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 208, 0, ?x3), 2, 0, ?x3) + ((int(((Lv * 0.5) + Lv)) + 10) + 25))`
  - set `disDefParcent` = `(Lv + (Lv << 2))`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`
- when `(PlayerAttackBase.ExistWeaponType(actarAction, 16, stkp(-56), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1159, stkp(-64), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add(meta(0), 7, PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `WeaponType` = `16`
  - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(ExistWeaponType.out2(), 0, ?x2, ?x3)`
  - set `skillRate` = `(((Lv + (Lv << 2)) + 100) + 50)`
  - set `fixAddDamage` = `(((Lv + (Lv << 2)) << 1) + 200)`
  - set `breakPercent` = `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + (GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 208, 0, ?x3), 2, 0, ?x3) + (int(((Lv * 0.5) + Lv)) + 10)))`
  - set `disDefParcent` = `(Lv + (Lv << 2))`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`, `SkillBufferDataBase$$GetParam`, `PlayerAttackBase$$CalcMotionSpeed`
- when `(PlayerAttackBase.ExistWeaponType(actarAction, 16, stkp(-56), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1159, stkp(-64), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `WeaponType` = `16`
  - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(ExistWeaponType.out2(), 0, ?x2, ?x3)`
  - set `skillRate` = `(((Lv + (Lv << 2)) + 100) + 50)`
  - set `fixAddDamage` = `(((Lv + (Lv << 2)) << 1) + 200)`
  - set `breakPercent` = `(GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 208, 0, ?x3), 2, 0, ?x3) + (int(((Lv * 0.5) + Lv)) + 10))`
  - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`, `0x165db84`
- when `(PlayerAttackBase.ExistWeaponType(actarAction, 16, stkp(-56), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1159, stkp(-64), 0) & 1) eq 0`
  - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add(meta(0), 7, PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `WeaponType` = `16`
  - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(ExistWeaponType.out2(), 0, ?x2, ?x3)`
  - set `skillRate` = `(((Lv + (Lv << 2)) + 100) + 50)`
  - set `fixAddDamage` = `(((Lv + (Lv << 2)) << 1) + 200)`
  - set `breakPercent` = `(GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 208, 0, ?x3), 2, 0, ?x3) + (int(((Lv * 0.5) + Lv)) + 10))`
  - set `disDefParcent` = `(Lv + (Lv << 2))`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`
- when `(PlayerAttackBase.ExistWeaponType(actarAction, 16, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1159, stkp(-64), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add(meta(0), 7, PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `WeaponType` = `0`
  - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(ExistWeaponType.out2(), 0, ?x2, ?x3)`
  - set `skillRate` = `((Lv + (Lv << 2)) + 100)`
  - set `fixAddDamage` = `(((Lv + (Lv << 2)) << 1) + 50)`
  - set `breakPercent` = `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + (GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 208, 0, ?x3), 2, 0, ?x3) + ((int(((Lv * 0.5) + Lv)) + 10) + 25)))`
  - set `disDefParcent` = `(Lv + (Lv << 2))`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`, `SkillBufferDataBase$$GetParam`, `PlayerAttackBase$$CalcMotionSpeed`
- when `(PlayerAttackBase.ExistWeaponType(actarAction, 16, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1159, stkp(-64), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `WeaponType` = `0`
  - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(ExistWeaponType.out2(), 0, ?x2, ?x3)`
  - set `skillRate` = `((Lv + (Lv << 2)) + 100)`
  - set `fixAddDamage` = `(((Lv + (Lv << 2)) << 1) + 50)`
  - set `breakPercent` = `(GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 208, 0, ?x3), 2, 0, ?x3) + ((int(((Lv * 0.5) + Lv)) + 10) + 25))`
  - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`, `0x165db84`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `EnchantedBurstAction$$ActionHit (ContainsBuffer)`
- `EnchantedBurstAction$$AddLocalStack (ContainsBuffer)`
- `EnchantedSwordAction$$ActionPreparation (ContainsBuffer)`
- `EquipItemData.WeaponTypeCalculatorBase$$CalcEqAtk (TryGetBuf)`
- `GeoImpactAction$$calcPlayerToMobDamage (ContainsBuffer)`
- `GoliathTakeShotAction$$EnemyDamage (ContainsBuffer)`
- `MindimageSenjuAttackAction$$CalcDamageGeoImpact (ContainsBuffer)`
- `PlayerAttackBase$$CalcCostMp (GetSkillLv)`
- `ShellBreakAction$$OnInitialize (TryGetBuf)`

---

### เทอราบลาสต์ (GeoImpact) · uid 1160

<img src="../../icons/sk_1160.png" width="40" alt="icon"> 
**Tree:** クラッシャー (`CrusherSkill`, tier 4) · **Type:** Attack · **Max Lv:** 250 · **Weapons:** MainKnuckle · **Requires:** ผู้ทำลายล้าง · **Flags:** StarGem · **Client class:** `GeoImpactAction`

> ทักษะการบดขยี้แผ่นดินแล้วใช้หินที่ยกสูงขึ้นเป็นเกราะกำบัง
> สร้างความเสียหายให้กับพื้นที่โดยรอบ
> และสร้างบาเรีย 10 วินาทีตาม HP ที่ใช้ไป(ไม่สามารถบันทึกทับ)
> ถ้าผู้ทำลายล้างใช้งานอยู่และเป้าหมายติด"ลดการป้องกัน"
> จะการันตีคริติคอล

<details><summary>In-game level notes</summary>

- Lv16: หากได้รับบัฟเพิ่มพลังโจมตีของก็อดแฮนด์ จะเพิ่มผลการฟื้นฟู MP เล็กน้อยให้กับ สกิลเทอราบลาสต์เมื่อโจมตีโดนเป้าหมาย

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 710 | 720 | 730 | 740 | 750 | 760 | 770 | 780 | 790 | 800 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((System.Math.Max(baseSTR, baseAGI) + ((Lv * 60) + 900))) * 0.01)`
- SkillRate × `(((System.Math.Max(baseSTR, baseAGI) + ((Lv * 60) + 900))) * 0.01)`

**Role:** attack (deals damage) · buff (self)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv * 10) + 700))`
- `SkillRate` multiplies by (adds into): `(((System.Math.Max(baseSTR, baseAGI) + ((Lv * 60) + 900))) * 0.01)`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1160

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `skillRate` = `(System.Math.Max(baseSTR, baseAGI) + ((Lv * 60) + 900))`
- set `fixAddDamage` = `((Lv * 10) + 700)` → Lv1..10: [710, 720, 730, 740, 750, 760, 770, 780, 790, 800]

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`ActionPreparation`** (5 paths)

- set `breathingMethodHeal` = `SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1154), 50)` — when TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1154) ne 0
- set `mpHeal` = `(GodHandBuf.GetParam(20) * 100)`
- set `skillRate` = `(SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1158], 50) + skillRate)`

**`ActionStart`** (3 paths)

- set `targetPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x`
- set `targetPos.y` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y`
- set `targetPos.z` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z`
- calls `GeoImpactBuf..ctor` = `.ctor(Lv, ((status.MaxHp - PlayerStatusBase.get_GameStatus().localHp) + breathingMethodHeal), status.MaxHp)` — when !hasBuff(1160) AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 90
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new GeoImpactBuf, Id)` — when !hasBuff(1160) AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 90

**`ActionHit`** (2 paths)

- calls `GeoImpactAction.MpHeal` = `MpHeal()` — when UnityEngine.Object.op_Inequality(actarAction)

**`calcPlayerToMobDamage`** (4 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)`
- template `AddRate[SkillRate]` = `(skillRate * 0.01)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- info `templates` = `1`

**`MpHeal`** (2 paths)

- set `mpHeal` = `0` = 0 — when mpHeal ge 1

**`OnInheritance`** (1 path)

- set `IsInheritance` = `1` = 1

</details>

**Buffs**

**Buff `GeoImpactBuf`**
- Buff hook methods: `CalcDamage`, `DamageCut`
- Duration: `10` s
- `Value` = `(barrier)`
- Buff fields set in the constructor (all recovered):
  - `barrier` = `barrier`
  - `maxHp` = `hp`
  - `Count` = `int(((barrier / hp) * 100))`
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `DamageCut`: `barrier`=0; `Count`=int(((0 / maxHp) * 100)); `barrier`=(barrier - damage); `Count`=int((((barrier - damage) / maxHp) * 100))
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:GeoImpactBuf$$.ctor<-GeoImpactAction$$ActionStart` (no direct constructor call in the skill's own code).
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

<details><summary>Effect applied in `GeoImpactAction$$ActionStart` (3 guarded paths)</summary>

- always
  - returns `PlayerStatusBase.GetHpPercent(?blr, 0, ?x2, ?x3)`
  - set `targetPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `+0x13c` = `?v1`
  - set `+0x140` = `?v2`
  - calls `PlayerAttackBase$$ActionStart`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `PlayerStatusBase$$GetHpPercent`
- always
  - set `targetPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `+0x13c` = `?v1`
  - set `+0x140` = `?v2`
  - calls `PlayerAttackBase$$ActionStart`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `PlayerStatusBase$$GetHpPercent`, `interface IPlayerStatusCalculator.get_MaxHp`, `interface IPlayerStatusCalculator.get_MaxHp`, `0x165db78`, `GeoImpactBuf$$.ctor`
- always
  - returns `SkillBufferManager.ContainsBuffer(?blr, 1160, 0, ?x3)`
  - set `targetPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `+0x13c` = `?v1`
  - set `+0x140` = `?v2`
  - calls `PlayerAttackBase$$ActionStart`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `GeoImpactAction$$ActionStart (ContainsBuffer)`

---

### ร่างแกร่งดุจเทพ (GodRigidBody) · uid 1161

<img src="../../icons/sk_1161.png" width="40" alt="icon"> 
**Tree:** クラッシャー (`CrusherSkill`, tier 4) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** MainKnuckle · **Requires:** ก็อดแฮนด์ · **Flags:** StarGem · **Client class:** `GodRigidBodyMastery` (passive mastery)

> ทำให้หัตถ์แห่งเทพสมบูรณ์พร้อม
> ระหว่างใช้ก็อดแฮนด์อัตราความเสียหายจะลดลง
> และต้านภาวะผิดปกติเพิ่มขึ้น
> นอกจากนี้ทุกครั้งที่ลดสำเร็จ MP จะฟื้นฟูเล็กน้อย(สูงสุด 2 ครั้ง)

<details><summary>In-game level notes</summary>

- Lv16: ถ้าเรียนรู้และมีสถานะร่างแกร่งดุจเทพแล้วใช้[ผู้ทำลายล้าง] การชาร์จ[กลอเรียเทคชอต]จะเพิ่มขึ้นเร็วขึ้น ทุกครั้งที่สร้างความเสียหายด้วยครัชเชอร์

</details>

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| CutDmgRate | 90 | 90 | 90 | 90 | 90 | 90 | 90 | 90 | 90 | 90 |
| Value | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |


<details><summary>Effect applied in `GodHandBuf$$DeathExemption` (3 guarded paths)</summary>

- when `isSkillEnd eq 0` AND `SkillLv(1161) ge 1` AND `isDeathExemption ne 0`
  - returns `1`
  - set `isDeathExemption` = `0`
  - calls `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`
- when `isSkillEnd eq 0` AND `SkillLv(1161) ge 1` AND `isDeathExemption eq 0`
  - returns `0`
  - calls `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`
- when `isSkillEnd eq 0` AND `SkillLv(1161) lt 1`
  - returns `0`
  - calls `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`

</details>

<details><summary>Effect applied in `GodHandBuf$$Initalize` (2 guarded paths)</summary>

- when `SkillLv(1161) ge 1`
  - returns `SkillLv(1161)`
  - set `playerStatus` = `status`
  - set `isDeathExemption` = `1`
  - calls `0x165d8dc`
- when `SkillLv(1161) lt 1`
  - returns `SkillLv(1161)`
  - set `playerStatus` = `status`
  - calls `0x165d8dc`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `GodHandBuf$$DeathExemption (GetSkillLv)`
- `GodHandBuf$$Initalize (GetSkillLv)`
- `GoliathTakeShotAction$$EnemyDamage (GetSkillLv)`

---

### กีย์เซอร์ชู้ต (GazerShoot) · uid 1162

<img src="../../icons/sk_1162.png" width="40" alt="icon"> 
**Tree:** クラッシャー (`CrusherSkill`, tier 4) · **Type:** Attack · **Max Lv:** 250 · **Weapons:** MainKnuckle · **Requires:** ฟลายอิ้งคิก · **Flags:** StarGem · **Client class:** `GazerShootAction`

> การกระโดดเตะที่รวดเร็วและทรงพลังอย่างน่าสะพรึงกลัว
> การแสดงผลของสกิลจะเปลี่ยนตามระยะใกล้/ไกล ถ้าใช้ในระยะไกล
> พลังจะเพิ่มขึ้นและเพิ่มการใช้วิธีการหายใจที่ได้เรียนรู้มา

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [startTargetDist ge MathUtil.DisplayMeterToDistance(8)] | 0.5 | 1 | 1.5 | 2 | 2.5 | 3 | 3.5 | 4 | 4.5 | 5 |
| SkillRate × [startTargetDist lt MathUtil.DisplayMeterToDistance(8) & startTargetDist ge MathUtil.DisplayMeterToDistance(8)] | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 |
| SkillRate × [startTargetDist lt MathUtil.DisplayMeterToDistance(8)] | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 |
| Flat dmg + | 210 | 220 | 230 | 240 | 250 | 260 | 270 | 280 | 290 | 300 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv * 10) + 900) + ((status.Agi lt 0 ? (status.Agi + 1) : status.Agi) >> 1))) / 100)`
- SkillRate × `(((((Lv * 10) + 900) + ((status.Agi lt 0 ? (status.Agi + 1) : status.Agi) >> 1))) / 100)` — !PlayerAttackBase.IsBlank(this) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1158) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)

**Role:** attack (deals damage) · buff (self)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv * 10) + 200))`
- `SkillRate` multiplies by (adds into): `(((((Lv * 10) + 900) + ((status.Agi lt 0 ? (status.Agi + 1) : status.Agi) >> 1))) / 100)` | `(((Lv * 50)) / 100)` | `0`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1162

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`
- set `skillRate` = `(((Lv * 10) + 900) + ((status.Agi lt 0 ? (status.Agi + 1) : status.Agi) >> 1))`
- set `physicsBreaker` = `(Lv << 1)` → Lv1..10: [2, 4, 6, 8, 10, 12, 14, 16, 18, 20]
- set `constantDamage` = `((Lv * 10) + 200)` → Lv1..10: [210, 220, 230, 240, 250, 260, 270, 280, 290, 300]
- set `longBonusSkillRate` = `(Lv * 50)` → Lv1..10: [50, 100, 150, 200, 250, 300, 350, 400, 450, 500]

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`OtherPlayerAttackStartReceive`** (1 path)

- set `longBonus` = `(SkillIndividualFlag ne 0 ? 1 : 0)`

**`ActionStartOthers`** (8 paths)

- set `startTime` = `UnityEngine.Time.get_realtimeSinceStartup()`

**`ActionPreparation`** (5 paths)

- set `skillRate` = `(skillRate + SkillBufferDataBase.GetParam(50))` — when !PlayerAttackBase.IsBlank(this) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1158) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `physicsBreaker` = `((physicsBreaker * SkillBufferDataBase.GetParam(20)) + physicsBreaker)` — when !PlayerAttackBase.IsBlank(this) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1158) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)

**`ActionStart`** (8 paths)

- set `startTime` = `UnityEngine.Time.get_realtimeSinceStartup()`

**`ActionHit`** (4 paths)

- calls `BreathingMethodBuf..ctor` = `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1154, 1))` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1154, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND longBonus ne 0
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new BreathingMethodBuf, Id)` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1154, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND longBonus ne 0

**`calcPlayerToMobDamage`** (4 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)`
- set `longBonus` = `(startTargetDist ge MathUtil.DisplayMeterToDistance(8) ? 1 : 0)`
- set `SkillIndividualFlag` = `1` = 1 — when startTargetDist ge MathUtil.DisplayMeterToDistance(8)
- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddRate[SkillRate]` = `(longBonusSkillRate / 100)` — when startTargetDist ge MathUtil.DisplayMeterToDistance(8)
- template `AddConstant[SkillConstantDamage]` = `constantDamage`
- info `templates` = `1`
- set `longBonusSkillRate` = `0` = 0 — when startTargetDist lt MathUtil.DisplayMeterToDistance(8)
- template `AddRate[SkillRate]` = `0` — when startTargetDist lt MathUtil.DisplayMeterToDistance(8)

</details>

**Buffs**

**Buff `BreathingMethodBuf`**
- Buff hook methods: `SetNextHeal`
- `Value` = `nextHeal` _(when BuffEffectActive ne 0)_
- `Value` = `0` _(when BuffEffectActive eq 0)_
- Hook `SetNextHeal`: `nextHeal`=((heal lt 0 ? (heal + 1) : heal) >> 1)
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:BreathingMethodBuf$$.ctor<-GazerShootAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

---
