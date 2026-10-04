# パルチザンスキル (`PartisanSkill`)

9 entries. See ../README.md for how to read these blocks.

### Lบูมเมอแรง / เลเพจบูมเมอแรง (L_Boomerang) · uid 673

<img src="../../icons/sk_673.png" width="40" alt="icon"> 
**Tree:** パルチザンスキル (`PartisanSkill`, tier 1) · **Type:** Object · **Max Lv:** 1 · **Weapons:** TwoHandSword · **Flags:** NoMarketSearch · **Client class:** `L_BoomerangAction`

> ขว้างดาบบูมเมอแรงของเลเพจ
> โจมตีเฉพาะเป้าหมายเท่านั้น
> เมื่อไปถึงระยะหนึ่งจะย้อนกลับมา
> และมีโอกาสโจมตีเป้าหมายอีกครั้ง
> สกิลนี้จะไม่สร้างความเสียหายหากไม่มีบูมเมอแรง

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)) + 200)) / 100)` — SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) ge 1
- SkillRate × `(((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)) + 200)) / 100)` — SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) lt 1
- SkillRate × `(((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)) + 200)) / 100)` — SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) ge 1
- SkillRate × `(((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)) + 200)) / 100)` — SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) lt 1

**Role:** attack (deals damage) · buff (self) · placed object / trap / summon

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **normal-attack proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(200)`
- `SkillRate` multiplies by (adds into): `(((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)) + 200)) / 100)`
- `ExpRate` sets: `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefNormal / 100)` | `(targetExpList[mobAction] / 100)`

**Mechanics recovered from code**

- **Effect radius (Unity units)** (`Radius`): `MathUtil.DisplayMeterToDistance(1)`

**Proration:** slot `Normal`, mode `first_hit_per_target`, attack type `SkillNormal`, action id 673

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (4 paths)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(10)`
- set `Radius` = `MathUtil.DisplayMeterToDistance(1)`
- set `skillRate` = `(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)) + 200)` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) ge 1
- set `fixAddDamage` = `200` = 200
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `skillRate` = `(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) lt 1
- set `skillRate` = `(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) ge 1
- set `skillRate` = `(baseDEX + ((Lv * 25) + 200))` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) lt 1

**`ActionPreparation`** (4 paths)

- set `SkillIndividualFlag` = `1` = 1 — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(673)
- calls `SkillBufferManager.RemoveBuffer` = `RemoveBuffer(673)` — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(673)

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`CheckRangeHit`** (6 paths)

- set `isHit` = `1` = 1 — when !UnityEngine.Object.op_Equality(SkillActionBase.GetMainTarget(this), 0) AND !UnityEngine.Object.op_Equality(skillPosition) AND !UnityEngine.Object.op_Inequality(UnityEngine.Component.get_gameObject(SkillActionBase.GetMainTarget(this)), UnityEngine.Component.get_gameObject(targetTransform)) AND (((UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z) * (UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z)) + ((UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x) * (UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x))) ls ((Radius + size) * (Radius + size)) AND isHit eq 0

**`calcPlayerToMobDamage`** (4 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- template `SetRate[ExpRate]` = `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefNormal / 100)`
- info `templates` = `1`
- template `SetRate[ExpRate]` = `(targetExpList[mobAction] / 100)`

**`ActionSkillEvent`** (7 paths)

- set `isHit` = `0` = 0 — when param eq 102 AND param ne 103
- set `isMpHeal` = `0` = 0 — when param eq 103

**`.<>c__DisplayClass26_0::<ActionPreparation>b__0`** (1 path)

- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(673, 0, 0)`

</details>

**Buffs**

**Buff `BoomerangBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).

<details><summary>Effect applied in `L_Boomerang2Action$$ActionPreparation` (2 guarded paths)</summary>

- always
  - set `SkillIndividualFlag` = `1`
  - calls `0x165db78`, `System.Object$$.ctor`, `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `SkillBufferManager$$RemoveBuffer`, `0x165db78`, `System.Action<bool>$$.ctor`
- always
  - returns `SkillBufferManager.ContainsBuffer(?blr, 673, 0, ?x3)`
  - calls `0x165db78`, `System.Object$$.ctor`, `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`

</details>

<details><summary>Effect applied in `L_Boomerang2Action$$OnInitialize` (2 guarded paths)</summary>

- when `SkillLv(673) ge 1`
  - set `ActionRange` = `-1`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `skillRate` = `((((((SkillLv(673) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200) + (SkillLv(675) gt 0 ? ((SkillLv(675) * 25) + 200) : 0)) lt 0 ? (((((SkillManager.GetSk`
  - set `fixAddDamage` = `100`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - calls `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
- when `SkillLv(673) lt 1`
  - set `ActionRange` = `-1`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `skillRate` = `(((([?blr+0x24] + ((Lv * 25) + 200)) + (SkillLv(675) gt 0 ? ((SkillLv(675) * 25) + 200) : 0)) lt 0 ? ((([?blr+0x24] + ((Lv * 25) + 200)) + (SkillLv(675) gt `
  - set `fixAddDamage` = `100`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - calls `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`

</details>

<details><summary>Effect applied in `L_Boomerang3Action$$ActionPreparation` (2 guarded paths)</summary>

- always
  - set `isMpHeal` = `1`
  - set `isPlace` = `1`
  - set `SkillIndividualFlag` = `1`
  - calls `0x165db78`, `System.Object$$.ctor`, `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `SkillBufferManager$$RemoveBuffer`, `0x165db78`, `System.Action<bool>$$.ctor`
- always
  - returns `SkillBufferManager.ContainsBuffer(?blr, 673, 0, ?x3)`
  - set `isMpHeal` = `0`
  - set `isPlace` = `0`
  - calls `0x165db78`, `System.Object$$.ctor`, `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`

</details>

<details><summary>Effect applied in `L_BoomerangAction$$ActionPreparation` (2 guarded paths)</summary>

- always
  - set `SkillIndividualFlag` = `1`
  - calls `0x165db78`, `System.Object$$.ctor`, `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `SkillBufferManager$$RemoveBuffer`, `0x165db78`, `System.Action<bool>$$.ctor`
- always
  - returns `SkillBufferManager.ContainsBuffer(?blr, 673, 0, ?x3)`
  - calls `0x165db78`, `System.Object$$.ctor`, `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`

</details>

<details><summary>Effect applied in `L_Boomerang3Action$$OnInitialize` (4 guarded paths)</summary>

- when `SkillLv(673) ge 1` AND `SkillLv(674) ge 1`
  - set `moveDist` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `skillRate` = `(((SkillLv(674) * 25) + (((SkillLv(673) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200)) + 200)`
  - set `fixAddDamage` = `400`
  - set `critical` = `(Lv * 10)`
  - set `physicalResist` = `(Lv * 5)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
- when `SkillLv(673) ge 1` AND `SkillLv(674) lt 1`
  - set `moveDist` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `skillRate` = `(((SkillLv(673) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200)`
  - set `fixAddDamage` = `400`
  - set `critical` = `(Lv * 10)`
  - set `physicalResist` = `(Lv * 5)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
- when `SkillLv(673) lt 1` AND `SkillLv(674) ge 1`
  - set `moveDist` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `skillRate` = `(((SkillLv(674) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200)`
  - set `fixAddDamage` = `400`
  - set `critical` = `(Lv * 10)`
  - set `physicalResist` = `(Lv * 5)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
- when `SkillLv(673) lt 1` AND `SkillLv(674) lt 1`
  - set `moveDist` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `skillRate` = `([?blr+0x24] + ((Lv * 25) + 200))`
  - set `fixAddDamage` = `400`
  - set `critical` = `(Lv * 10)`
  - set `physicalResist` = `(Lv * 5)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `L_Boomerang2Action$$ActionPreparation (ContainsBuffer)`
- `L_Boomerang2Action$$OnInitialize (GetSkillLv)`
- `L_Boomerang3Action$$ActionPreparation (ContainsBuffer)`
- `L_Boomerang3Action$$OnInitialize (GetSkillLv)`
- `L_BoomerangAction$$ActionPreparation (ContainsBuffer)`
- `SkillBufferManager$$UpdateBoomerangBuf (GetSkillLv)`

---

### ฮีลลิ่งช็อต (HealingShot) · uid 677

<img src="../../icons/sk_677.png" width="40" alt="icon"> 
**Tree:** パルチザンスキル (`PartisanSkill`, tier 1) · **Type:** Special · **Max Lv:** 1 · **Weapons:** Bow, Bowgun · **Flags:** NoMarketSearch · **Client class:** `HealingShotAction`

> ใช้ HP ของตัวเอง (ขั้นต่ำ 100)
> เพื่อยิงลูกธนูฟื้นฟูตรงไปยัง
> สมาชิกปาร์ตี้ที่อยู่ไกลที่สุดปริมาณการฟื้นฟูจะแตกต่างกันไปสำหรับ
> ทหารรับจ้าง, พาร์ทเนอร์และสัตว์เลี้ยง

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **HP consumed** (`consumptionHp`): `(int(((status.MaxHp * (25 - (Lv << 1))) / 100)) gt 100 ? int(((status.MaxHp * (25 - (Lv << 1))) / 100)) : 100)`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 677

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (3 paths)

- set `ActionRange` = `-1` = -1
- set `consumptionHp` = `(int(((status.MaxHp * (25 - (Lv << 1))) / 100)) gt 100 ? int(((status.MaxHp * (25 - (Lv << 1))) / 100)) : 100)`

**`InitializeOthers`** (3 paths)

- set `ActionRange` = `-1` = -1

**`ActionStart`** (3 paths)

- set `shotDir` = `((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) / fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))))` — when UnityEngine.Object.op_Inequality(target, UnityEngine.Component.get_gameObject(actarAction)) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05
- set `shotDir.z` = `((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) / fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))))` — when UnityEngine.Object.op_Inequality(target, UnityEngine.Component.get_gameObject(actarAction)) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05
- set `shotDir.y` = `0` = 0 — when UnityEngine.Object.op_Inequality(target, UnityEngine.Component.get_gameObject(actarAction)) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 OR UnityEngine.Object.op_Inequality(target, UnityEngine.Component.get_gameObject(actarAction)) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05
- set `shotDir` = `UnityEngine.Vector3.static+0x0` — when UnityEngine.Object.op_Inequality(target, UnityEngine.Component.get_gameObject(actarAction)) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05
- set `shotDir.z` = `UnityEngine.Vector3.static+0x8` — when UnityEngine.Object.op_Inequality(target, UnityEngine.Component.get_gameObject(actarAction)) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05
- set `shotDir` = `UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(actarAction)).x` — when !UnityEngine.Object.op_Inequality(target, UnityEngine.Component.get_gameObject(actarAction))
- set `shotDir.y` = `UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(actarAction)).y` — when !UnityEngine.Object.op_Inequality(target, UnityEngine.Component.get_gameObject(actarAction))
- set `shotDir.z` = `UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(actarAction)).z` — when !UnityEngine.Object.op_Inequality(target, UnityEngine.Component.get_gameObject(actarAction))

**`ActionStartOthers`** (2 paths)

- set `shotDir` = `((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) / fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))))` — when fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05
- set `shotDir.z` = `((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) / fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))))` — when fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05
- set `shotDir.y` = `0` = 0
- set `shotDir` = `UnityEngine.Vector3.static+0x0` — when fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05
- set `shotDir.z` = `UnityEngine.Vector3.static+0x8` — when fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) le 1e-05

**`ActionHit`** (2 paths)

- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(677, Lv, (EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) eq 12 ? 10 : 5))` — when UnityEngine.Object.op_Inequality(actarAction)

**`CheckPayHp`** (6 paths)

- calls `SoulHuntBuf..ctor` = `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1))` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND consumptionHp ge 1 AND consumptionHp lt (PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new SoulHuntBuf, 0)` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND consumptionHp ge 1 AND consumptionHp lt (PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp)

</details>

**Buffs**

**Buff `SoulHuntBuf`**
**Buff `HealingShotBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `time` s
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:SoulHuntBuf$$.ctor<-HealingShotAction$$CheckPayHp` (no direct constructor call in the skill's own code).
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

---

### ค้ำจุนแนวหน้า (MaintainingTheFront) · uid 680

<img src="../../icons/sk_680.png" width="40" alt="icon"> 
**Tree:** パルチザンスキル (`PartisanSkill`, tier 1) · **Type:** Buffer · **Max Lv:** 1 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** NoMarketSearch · **Client class:** `MaintainingTheFrontAction`

> ความมุ่งมั่นที่ตั้งใจจะไม่ถอยกลับ
> เพิ่มเฮทให้กับตัวเองและ
> ปริมาณเฮทจะเพิ่มขึ้นอีก 60 วินาที
> จะได้รับบาเรียอาวุธเพิ่มตาม
> จำนวนสมาชิกที่ไม่ใช่เป้าหมาย

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 680

<details><summary>Recovered formulas (per method)</summary>

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

</details>

**Buffs**

**Buff `MaintainingTheFrontBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- `Value` = `(((noTargetMemberNum * 100) * Lv))` _(when BuffEffectActive ne 0)_
- `Percent` = `(((noTargetMemberNum * 100) * SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 681, 1)))` _(when BuffEffectActive ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| HateRate | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |

- Buff fields set in the constructor (all recovered):
  - `playerStatus` = `status`
  - `physicalBarrier` = `((noTargetMemberNum * 100) * Lv)`
  - `magicBarrier` = `((noTargetMemberNum * 100) * SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 681, 1))`
  - `hateRate` = `(Lv << 1)` = 2
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

<details><summary>Effect applied in `PlayerSecondaryStatus$$GetDisplayBonusCalcHate` (295 guarded paths, truncated)</summary>

- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 553, stkp(-56), 0) & 1) ne 0`
  - returns `int(frintp((fcvt((((((((((BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 62, 0, ?x3) + (KnightWill.GetParam(TryGetValue.out2(), 5, (EquipItemData.get_SubWeaponItemType(CharacterActionManagerBase.set_DefaultMoveSpeed(), 0, ?x2, ?x3) eq 17 ? 1 : 0), 0) / 100)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) + (CharacterActionManagerBase.get_Size() / 100)) + (DetectionBuf.GetHateBonus(TryGetBuf.out2(), playerStatus, 0, ?x3) * 0.01)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) * (1 - BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 156, 0, ?x3))) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) + 1) * 100)) + -0.5)))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeaponItemType`, `KnightWill$$GetParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 553, stkp(-56), 0) & 1) ne 0`
  - returns `int(frintm((fcvt((((((((((BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 62, 0, ?x3) + (KnightWill.GetParam(TryGetValue.out2(), 5, (EquipItemData.get_SubWeaponItemType(CharacterActionManagerBase.set_DefaultMoveSpeed(), 0, ?x2, ?x3) eq 17 ? 1 : 0), 0) / 100)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) + (CharacterActionManagerBase.get_Size() / 100)) + (DetectionBuf.GetHateBonus(TryGetBuf.out2(), playerStatus, 0, ?x3) * 0.01)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) * (1 - BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 156, 0, ?x3))) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) + 1) * 100)) + 0.5)))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeaponItemType`, `KnightWill$$GetParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 553, stkp(-56), 0) & 1) ne 0`
  - returns `int(frintp((fcvt(((((((((BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 62, 0, ?x3) + (KnightWill.GetParam(TryGetValue.out2(), 5, (EquipItemData.get_SubWeaponItemType(CharacterActionManagerBase.set_DefaultMoveSpeed(), 0, ?x2, ?x3) eq 17 ? 1 : 0), 0) / 100)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) + (CharacterActionManagerBase.get_Size() / 100)) + (DetectionBuf.GetHateBonus(TryGetBuf.out2(), playerStatus, 0, ?x3) * 0.01)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) * (1 - BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 156, 0, ?x3))) + 1) * 100)) + -0.5)))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeaponItemType`, `KnightWill$$GetParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 553, stkp(-56), 0) & 1) ne 0`
  - returns `int(frintm((fcvt(((((((((BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 62, 0, ?x3) + (KnightWill.GetParam(TryGetValue.out2(), 5, (EquipItemData.get_SubWeaponItemType(CharacterActionManagerBase.set_DefaultMoveSpeed(), 0, ?x2, ?x3) eq 17 ? 1 : 0), 0) / 100)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) + (CharacterActionManagerBase.get_Size() / 100)) + (DetectionBuf.GetHateBonus(TryGetBuf.out2(), playerStatus, 0, ?x3) * 0.01)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) * (1 - BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 156, 0, ?x3))) + 1) * 100)) + 0.5)))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeaponItemType`, `KnightWill$$GetParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 553, stkp(-56), 0) & 1) ne 0`
  - returns `int(frintp((fcvt((((((((((BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 62, 0, ?x3) + (KnightWill.GetParam(TryGetValue.out2(), 5, (EquipItemData.get_SubWeaponItemType(CharacterActionManagerBase.set_DefaultMoveSpeed(), 0, ?x2, ?x3) eq 17 ? 1 : 0), 0) / 100)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) + (CharacterActionManagerBase.get_Size() / 100)) + (DetectionBuf.GetHateBonus(TryGetBuf.out2(), playerStatus, 0, ?x3) * 0.01)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) * (1 - BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 157, 0, ?x3))) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) + 1) * 100)) + -0.5)))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeaponItemType`, `KnightWill$$GetParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 553, stkp(-56), 0) & 1) ne 0`
  - returns `int(frintm((fcvt((((((((((BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 62, 0, ?x3) + (KnightWill.GetParam(TryGetValue.out2(), 5, (EquipItemData.get_SubWeaponItemType(CharacterActionManagerBase.set_DefaultMoveSpeed(), 0, ?x2, ?x3) eq 17 ? 1 : 0), 0) / 100)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) + (CharacterActionManagerBase.get_Size() / 100)) + (DetectionBuf.GetHateBonus(TryGetBuf.out2(), playerStatus, 0, ?x3) * 0.01)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) * (1 - BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 157, 0, ?x3))) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) + 1) * 100)) + 0.5)))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeaponItemType`, `KnightWill$$GetParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 553, stkp(-56), 0) & 1) ne 0`
  - returns `int(frintp((fcvt(((((((((BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 62, 0, ?x3) + (KnightWill.GetParam(TryGetValue.out2(), 5, (EquipItemData.get_SubWeaponItemType(CharacterActionManagerBase.set_DefaultMoveSpeed(), 0, ?x2, ?x3) eq 17 ? 1 : 0), 0) / 100)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) + (CharacterActionManagerBase.get_Size() / 100)) + (DetectionBuf.GetHateBonus(TryGetBuf.out2(), playerStatus, 0, ?x3) * 0.01)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) * (1 - BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 157, 0, ?x3))) + 1) * 100)) + -0.5)))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeaponItemType`, `KnightWill$$GetParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 553, stkp(-56), 0) & 1) ne 0`
  - returns `int(frintm((fcvt(((((((((BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 62, 0, ?x3) + (KnightWill.GetParam(TryGetValue.out2(), 5, (EquipItemData.get_SubWeaponItemType(CharacterActionManagerBase.set_DefaultMoveSpeed(), 0, ?x2, ?x3) eq 17 ? 1 : 0), 0) / 100)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) + (CharacterActionManagerBase.get_Size() / 100)) + (DetectionBuf.GetHateBonus(TryGetBuf.out2(), playerStatus, 0, ?x3) * 0.01)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) * (1 - BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 157, 0, ?x3))) + 1) * 100)) + 0.5)))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeaponItemType`, `KnightWill$$GetParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`

</details>

<details><summary>Effect applied in `EquipMagicBarrierBuf$$CheckTakeOver` (5 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0`
  - returns `((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 52, 0, ?x3) + SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)) gt 0 ? 1 : 0)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) eq 0`
  - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) gt 0 ? 1 : 0)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 52, 0, ?x3) gt 0 ? 1 : 0)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) eq 0`
  - returns `0`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`

</details>

<details><summary>Effect applied in `EquipMagicBarrierBuf$$GetBarrierValue` (5 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0`
  - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 52, 0, ?x3) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + Value))`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) eq 0`
  - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + Value)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 52, 0, ?x3) + Value)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) eq 0`
  - returns `Value`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`

</details>

<details><summary>Effect applied in `EquipPhysicalBarrierBuf$$CheckTakeOver` (5 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0`
  - returns `((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)) gt 0 ? 1 : 0)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) eq 0`
  - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) gt 0 ? 1 : 0)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) gt 0 ? 1 : 0)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) eq 0`
  - returns `0`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`

</details>

<details><summary>Effect applied in `EquipPhysicalBarrierBuf$$GetBarrierValue` (5 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0`
  - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + Value))`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) eq 0`
  - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + Value)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + Value)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) eq 0`
  - returns `Value`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`

</details>

<details><summary>Effect applied in `PlayerBattleManager$$StartRangeHateAttack` (2 guarded paths)</summary>

- when `SkillLv(680) ge 1`
  - returns `1`
  - calls `SkillFactory$$CreateSkill`, `SkillActionBase$$Initialize`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.Component$$get_gameObject`, `PlayerSkillActionManager$$PlaceEffectPlay`
- when `SkillLv(680) lt 1`
  - returns `0`
  - calls `SkillFactory$$CreateSkill`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `EquipMagicBarrierBuf$$CheckTakeOver (TryGetBuf)`
- `EquipMagicBarrierBuf$$GetBarrierValue (TryGetBuf)`
- `EquipPhysicalBarrierBuf$$CheckTakeOver (TryGetBuf)`
- `EquipPhysicalBarrierBuf$$GetBarrierValue (TryGetBuf)`
- `PlayerBattleManager$$StartRangeHateAttack (GetSkillLv)`
- `PlayerSecondaryStatus$$GetDisplayBonusCalcHate (TryGetBuf)`

---

### LบูมเมอแรงII / เลเพจบูมเมอแรงII (L_Boomerang2) · uid 674

<img src="../../icons/sk_674.png" width="40" alt="icon"> 
**Tree:** パルチザンスキル (`PartisanSkill`, tier 2) · **Type:** Object · **Max Lv:** 160 · **Weapons:** TwoHandSword · **Requires:** [N]Lบูมเมอแรง[N2]เลเพจบูมเมอแรง[N] · **Flags:** NoMarketSearch · **Client class:** `L_Boomerang2Action`

> ขว้างบูมเมอแรงขณะถอยหลังได้
> แต่พลังจะลดน้อยลง
> ถ้าไม่มีบูมเมอแรงจะทำได้แค่ถอยหลังเท่านั้น

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((((((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) gt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + 200) : 0)) lt 0 ? (((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) gt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + 200) : 0)) + 1) : ((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) gt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + 200) : 0))) >> 1)) / 100)` — SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) ge 1
- SkillRate × `((((((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) gt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + 200) : 0)) lt 0 ? (((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) gt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + 200) : 0)) + 1) : ((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) gt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + 200) : 0))) >> 1)) / 100)` — SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) lt 1

**Role:** attack (deals damage) · buff (self) · placed object / trap / summon

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **normal-attack proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(100)`
- `SkillRate` multiplies by (adds into): `((((((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) gt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + 200) : 0)) lt 0 ? (((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) gt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + 200) : 0)) + 1) : ((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) gt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + 200) : 0))) >> 1)) / 100)`
- `ExpRate` sets: `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefNormal / 100)` | `(targetExpList[mobAction] / 100)`

**Mechanics recovered from code**

- **Effect radius (Unity units)** (`Radius`): `MathUtil.DisplayMeterToDistance(1)`
- **Loop / hit-repeat count** (`LoopParam`): `int((UnityEngine.Quaternion.Internal_MakePositive(0).y * 100))` _(when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND isPlace ne 0 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND isPlace eq 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 AND isPlace ne 0)_

**Proration:** slot `Normal`, mode `first_hit_per_target`, attack type `SkillNormal`, action id 674

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (2 paths)

- set `ActionRange` = `-1` = -1
- set `Radius` = `MathUtil.DisplayMeterToDistance(1)`
- set `skillRate` = `((((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) gt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + 200) : 0)) lt 0 ? (((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) gt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + 200) : 0)) + 1) : ((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) gt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + 200) : 0))) >> 1)` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) ge 1
- set `fixAddDamage` = `100` = 100
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `skillRate` = `((((baseDEX + ((Lv * 25) + 200)) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) gt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + 200) : 0)) lt 0 ? (((baseDEX + ((Lv * 25) + 200)) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) gt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + 200) : 0)) + 1) : ((baseDEX + ((Lv * 25) + 200)) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) gt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + 200) : 0))) >> 1)` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) lt 1

**`ActionPreparation`** (4 paths)

- set `SkillIndividualFlag` = `1` = 1 — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(673)
- calls `SkillBufferManager.RemoveBuffer` = `RemoveBuffer(673)` — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(673)

**`ActionStart`** (7 paths)

- set `LoopParam` = `int((UnityEngine.Quaternion.Internal_MakePositive(0).y * 100))` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND isPlace ne 0 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND isPlace eq 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 AND isPlace ne 0

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`CheckRangeHit`** (6 paths)

- set `isHit` = `1` = 1 — when !UnityEngine.Object.op_Equality(SkillActionBase.GetMainTarget(this), 0) AND !UnityEngine.Object.op_Equality(skillPosition) AND !UnityEngine.Object.op_Inequality(UnityEngine.Component.get_gameObject(SkillActionBase.GetMainTarget(this)), UnityEngine.Component.get_gameObject(targetTransform)) AND (((UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z) * (UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z)) + ((UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x) * (UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x))) ls ((Radius + size) * (Radius + size)) AND isHit eq 0

**`calcPlayerToMobDamage`** (4 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- template `SetRate[ExpRate]` = `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefNormal / 100)`
- info `templates` = `1`
- template `SetRate[ExpRate]` = `(targetExpList[mobAction] / 100)`

**`ActionSkillEvent`** (6 paths)

- set `isHit` = `0` = 0 — when param eq 102 AND param ne 103
- set `isMpHeal` = `0` = 0 — when param eq 103

**`.<>c__DisplayClass28_0::<ActionPreparation>b__0`** (1 path)

- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(673, 0, 0)`

</details>

<details><summary>Effect applied in `L_Boomerang3Action$$OnInitialize` (4 guarded paths)</summary>

- when `SkillLv(673) ge 1` AND `SkillLv(674) ge 1`
  - set `moveDist` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `skillRate` = `(((SkillLv(674) * 25) + (((SkillLv(673) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200)) + 200)`
  - set `fixAddDamage` = `400`
  - set `critical` = `(Lv * 10)`
  - set `physicalResist` = `(Lv * 5)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
- when `SkillLv(673) ge 1` AND `SkillLv(674) lt 1`
  - set `moveDist` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `skillRate` = `(((SkillLv(673) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200)`
  - set `fixAddDamage` = `400`
  - set `critical` = `(Lv * 10)`
  - set `physicalResist` = `(Lv * 5)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
- when `SkillLv(673) lt 1` AND `SkillLv(674) ge 1`
  - set `moveDist` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `skillRate` = `(((SkillLv(674) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200)`
  - set `fixAddDamage` = `400`
  - set `critical` = `(Lv * 10)`
  - set `physicalResist` = `(Lv * 5)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
- when `SkillLv(673) lt 1` AND `SkillLv(674) lt 1`
  - set `moveDist` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `skillRate` = `([?blr+0x24] + ((Lv * 25) + 200))`
  - set `fixAddDamage` = `400`
  - set `critical` = `(Lv * 10)`
  - set `physicalResist` = `(Lv * 5)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`

</details>

<details><summary>Effect applied in `L_BoomerangAction$$OnInitialize` (4 guarded paths)</summary>

- when `SkillLv(674) ge 1` AND `SkillLv(675) ge 1`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `skillRate` = `(((SkillLv(675) * 25) + (((SkillLv(674) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200)) + 200)`
  - set `fixAddDamage` = `200`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
- when `SkillLv(674) ge 1` AND `SkillLv(675) lt 1`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `skillRate` = `(((SkillLv(674) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200)`
  - set `fixAddDamage` = `200`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
- when `SkillLv(674) lt 1` AND `SkillLv(675) ge 1`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `skillRate` = `(((SkillLv(675) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200)`
  - set `fixAddDamage` = `200`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
- when `SkillLv(674) lt 1` AND `SkillLv(675) lt 1`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `skillRate` = `([?blr+0x24] + ((Lv * 25) + 200))`
  - set `fixAddDamage` = `200`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `L_Boomerang3Action$$OnInitialize (GetSkillLv)`
- `L_BoomerangAction$$OnInitialize (GetSkillLv)`

---

### ลับคมลูกศร (ArrowSharpening) · uid 678

<img src="../../icons/sk_678.png" width="40" alt="icon"> 
**Tree:** パルチザンスキル (`PartisanSkill`, tier 2) · **Type:** Buffer · **Max Lv:** 160 · **Weapons:** Bow, Bowgun · **Requires:** ฮีลลิ่งช็อต · **Flags:** NoMarketSearch · **Client class:** `ArrowSharpeningAction`

> อัพเกรดการโจมตีปกติครั้งถัดไป
> 
> STR เพิ่มอาวุธเจาะเข้า
> AGI เพิ่มความเร็วการเคลื่อนที่
> DEX เพิ่มคริติคอลฮิต

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 678

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (2 paths)

- calls `ArrowSharpeningBuf..ctor` = `.ctor(Lv, PlayerActionManagerBase.get_PlayerStatus())` — when UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new ArrowSharpeningBuf, Id)` — when UnityEngine.Object.op_Inequality(actarAction)

</details>

**Buffs**

**Buff `ArrowSharpeningBuf`**
- `PowerResistBreaker` = `(int(((baseSTR / 50) * Lv)) gt Lv ? int(((baseSTR / 50) * Lv)) : Lv)` _(when BuffEffectActive ne 0)_
- `CrtDamageUpRate` = `(int(((baseDEX / 25) * Lv)) gt Lv ? int(((baseDEX / 25) * Lv)) : Lv)` _(when BuffEffectActive ne 0)_
- `CrtUpRate` = `(int(((baseDEX / 10) * Lv)) gt Lv ? int(((baseDEX / 10) * Lv)) : Lv)` _(when BuffEffectActive ne 0)_
- `MotionSpeed` = `(int(((baseAGI / 100) * Lv)) gt Lv ? int(((baseAGI / 100) * Lv)) : Lv)` _(when BuffEffectActive ne 0)_
- Buff fields set in the constructor (all recovered):
  - `playerStatus` = `status`
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:ArrowSharpeningBuf$$.ctor<-ArrowSharpeningAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

<details><summary>Effect applied in `MobaPlayerSecondaryStatus$$get_CriticalDmg` (34 guarded paths)</summary>

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

<details><summary>Effect applied in `PlayerSecondaryStatus$$CalcCriticalDmg` (34 guarded paths)</summary>

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

<details><summary>Effect applied in `MobaPlayerSecondaryStatus$$GetMotionSpeed` (76 guarded paths)</summary>

- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) ne 0`
  - returns `(100 - (int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3))))))))) lt 50 ? int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3))))))))) : 50))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) ne 0`
  - returns `(100 - (int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3)))))))) lt 50 ? int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3)))))))) : 50))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) ne 0`
  - returns `(100 - (int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3)))))))) lt 50 ? int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3)))))))) : 50))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) ne 0`
  - returns `(100 - (int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3))))))) lt 50 ? int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3))))))) : 50))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) eq 0`
  - returns `(100 - (int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3)))))))) lt 50 ? int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3)))))))) : 50))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) eq 0`
  - returns `(100 - (int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3))))))) lt 50 ? int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3))))))) : 50))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) eq 0`
  - returns `(100 - (int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3))))))) lt 50 ? int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3))))))) : 50))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) eq 0`
  - returns `(100 - (int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3)))))) lt 50 ? int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3)))))) : 50))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`

</details>

<details><summary>Effect applied in `PlayerSecondaryStatus$$GetCalcMotionSpeed` (112 guarded paths)</summary>

- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) ne 0`
  - returns `int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3)))))))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) ne 0`
  - returns `int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3))))))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) ne 0`
  - returns `int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3))))))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) ne 0`
  - returns `int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3)))))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) ne 0`
  - returns `int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3))))))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) ne 0`
  - returns `int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3)))))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) eq 0`
  - returns `int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3))))))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) eq 0`
  - returns `int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3)))))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`

</details>

<details><summary>Effect applied in `PlayerSecondaryStatus$$GetCrtRate` (80 guarded paths)</summary>

- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) ne 0`
  - returns `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0)`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0)`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) ne 0`
  - returns `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0)`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`

</details>

<details><summary>Effect applied in `MobaPlayerSecondaryStatus$$GetCrtRate` (80 guarded paths)</summary>

- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) ne 0`
  - returns `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0)`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0)`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) ne 0`
  - returns `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0)`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `MobaPlayerSecondaryStatus$$GetCrtRate (TryGetBuf)`
- `MobaPlayerSecondaryStatus$$GetMotionSpeed (TryGetBuf)`
- `MobaPlayerSecondaryStatus$$get_CriticalDmg (TryGetBuf)`
- `PlayerSecondaryStatus$$CalcCriticalDmg (TryGetBuf)`
- `PlayerSecondaryStatus$$GetCalcMotionSpeed (TryGetBuf)`
- `PlayerSecondaryStatus$$GetCrtRate (TryGetBuf)`

---

### ค้ำจุนแนวหน้าII (MaintainingTheFront2) · uid 681

<img src="../../icons/sk_681.png" width="40" alt="icon"> 
**Tree:** パルチザンスキル (`PartisanSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 160 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ค้ำจุนแนวหน้า · **Flags:** NoMarketSearch · **Client class:** `MaintainingTheFrontMastery` (passive mastery)

> เมื่อได้รับบาเรียอาวุธด้วยสกิล "ค้ำจุนแนวหน้า"
> จะได้รับบาเรียเวทด้วยและ HP สูงสุด
> จะเพิ่มขึ้นอย่างถาวรเมื่อเรียนรู้สกิล
> มีผลเป็นพาสซีฟ

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MaxHp | 100 | 200 | 300 | 400 | 500 | 600 | 700 | 800 | 900 | 1000 |


<details><summary>Effect applied in `MaintainingTheFrontBuf$$.ctor` (1 guarded path)</summary>

- always
  - returns `SkillLv(681)`
  - set `playerStatus` = `status`
  - set `physicalBarrier` = `((noTargetMemberNum * 100) * Lv)`
  - set `magicBarrier` = `((noTargetMemberNum * 100) * SkillLv(681))`
  - set `hateRate` = `(Lv << 1)`
  - calls `SkillBufferDataBase$$.ctor`, `0x165d8dc`, `virtual PlayerStatusBase.get_SkillManager`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `MaintainingTheFrontBuf$$.ctor (GetSkillLv)`

---

### LบูมเมอแรงIII / เลเพจบูมเมอแรงIII (L_Boomerang3) · uid 675

<img src="../../icons/sk_675.png" width="40" alt="icon"> 
**Tree:** パルチザンスキル (`PartisanSkill`, tier 3) · **Type:** Object · **Max Lv:** 250 · **Weapons:** TwoHandSword · **Requires:** [N]LบูมเมอแรงII[N2]เลเพจบูมเมอแรงII[N] · **Flags:** NoMarketSearch · **Client class:** `L_Boomerang3Action`

> อัตราคริติคอลและอาวุธเจาะเข้าจะเพิ่มขึ้น
> บูมเมอแรงจะไล่ตามเป้าหมายมันจะกลับมา
> หลังจากไปได้ระยะหนึ่งหรือชนกับสิ่งกีดขวาง
> และมีโอกาสที่จะโจมตีเป้าหมายอีกครั้ง
> สกิลนี้จะไม่สร้างความเสียหายหากไม่มีบูมเมอแรง

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) * 25) + (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)) + 200)) / 100)` — SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) ge 1
- SkillRate × `(((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) * 25) + (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)) + 200)) / 100)` — SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) lt 1
- SkillRate × `(((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) * 25) + (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)) + 200)) / 100)` — SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) ge 1
- SkillRate × `(((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) * 25) + (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)) + 200)) / 100)` — SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) lt 1

**Role:** attack (deals damage) · buff (self) · placed object / trap / summon

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **normal-attack proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(400)`
- `SkillRate` multiplies by (adds into): `(((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) * 25) + (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)) + 200)) / 100)`
- `ExpRate` sets: `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefNormal / 100)` | `(targetExpList[mobAction] / 100)`

**Mechanics recovered from code**

- **Effect radius (Unity units)** (`Radius`): `MathUtil.DisplayMeterToDistance(1)`

**Proration:** slot `Normal`, mode `first_hit_per_target`, attack type `SkillNormal`, action id 675

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (4 paths)

- set `moveDist` = `MathUtil.DisplayMeterToDistance(10)`
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(10)`
- set `Radius` = `MathUtil.DisplayMeterToDistance(1)`
- set `skillRate` = `(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) * 25) + (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)) + 200)` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) ge 1
- set `fixAddDamage` = `400` = 400
- set `critical` = `(Lv * 10)` → Lv1..10: [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]
- set `physicalResist` = `(Lv * 5)` → Lv1..10: [5, 10, 15, 20, 25, 30, 35, 40, 45, 50]
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `skillRate` = `(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) lt 1
- set `skillRate` = `(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) ge 1
- set `skillRate` = `(baseDEX + ((Lv * 25) + 200))` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) lt 1

**`ActionPreparation`** (4 paths)

- set `isMpHeal` = `1` = 1 — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(673)
- set `SkillIndividualFlag` = `1` = 1 — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(673)
- calls `SkillBufferManager.RemoveBuffer` = `RemoveBuffer(673)` — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(673)
- set `isMpHeal` = `0` = 0 — when !PlayerAttackBase.IsBlank(this) AND !hasBuff(673) AND UnityEngine.Object.op_Inequality(actarAction)

**`ActionStart`** (3 paths)

- set `moveVec.y` = `(0 / fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))))` — when fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND isPlace ne 0
- set `moveVec` = `((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) / fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))))` — when fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND isPlace ne 0
- set `moveVec.z` = `((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) / fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))))` — when fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND isPlace ne 0
- set `moveVec.y` = `0` = 0 — when fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 AND isPlace ne 0
- set `moveVec` = `UnityEngine.Vector3.static+0x0` — when fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 AND isPlace ne 0
- set `moveVec.z` = `UnityEngine.Vector3.static+0x8` — when fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 AND isPlace ne 0

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`
- set `moveDist` = `MathUtil.DisplayMeterToDistance(10)`

**`ActionStartOthers`** (3 paths)

- set `moveVec.y` = `(0 / fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))))` — when SkillIndividualFlag eq 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05
- set `moveVec` = `((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) / fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))))` — when SkillIndividualFlag eq 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05
- set `moveVec.z` = `((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) / fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))))` — when SkillIndividualFlag eq 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05
- set `moveVec.y` = `0` = 0 — when SkillIndividualFlag eq 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05
- set `moveVec` = `UnityEngine.Vector3.static+0x0` — when SkillIndividualFlag eq 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05
- set `moveVec.z` = `UnityEngine.Vector3.static+0x8` — when SkillIndividualFlag eq 1 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05

**`ActionSkillReceiveEffect`** (1 path)

- set `beforePos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(effect)).x`
- set `beforePos.y` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(effect)).y`
- set `beforePos.z` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(effect)).z`

**`CheckRangeHit`** (6 paths)

- set `isHit` = `1` = 1 — when !UnityEngine.Object.op_Equality(SkillActionBase.GetMainTarget(this), 0) AND !UnityEngine.Object.op_Equality(skillPosition) AND !UnityEngine.Object.op_Inequality(UnityEngine.Component.get_gameObject(SkillActionBase.GetMainTarget(this)), UnityEngine.Component.get_gameObject(targetTransform)) AND (((UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z) * (UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z)) + ((UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x) * (UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x))) ls ((Radius + size) * (Radius + size)) AND isHit eq 0

**`calcPlayerToMobDamage`** (4 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- template `SetRate[ExpRate]` = `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefNormal / 100)`
- info `templates` = `1`
- template `SetRate[ExpRate]` = `(targetExpList[mobAction] / 100)`

**`ActionSkillEvent`** (7 paths)

- set `isHit` = `0` = 0 — when isTurn eq 0 AND param eq 102 AND param ne 104
- set `isTurn` = `1` = 1 — when isTurn eq 0 AND param eq 102 AND param ne 104

**`ActionSkillEventIfMoveIndex`** (3 paths)

- set `moveDist` = `(moveDist - fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z)))))` — when !UnityEngine.Object.op_Equality(skillPosition) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z)))) gt 1e-05 OR !UnityEngine.Object.op_Equality(skillPosition) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z)))) le 1e-05
- set `moveVec` = `((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos) / fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z)))))` — when !UnityEngine.Object.op_Equality(skillPosition) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z)))) gt 1e-05
- set `moveVec.y` = `(0 / fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z)))))` — when !UnityEngine.Object.op_Equality(skillPosition) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z)))) gt 1e-05
- set `moveVec.z` = `((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z) / fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z)))))` — when !UnityEngine.Object.op_Equality(skillPosition) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z)))) gt 1e-05
- set `beforePos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x` — when !UnityEngine.Object.op_Equality(skillPosition) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z)))) gt 1e-05 OR !UnityEngine.Object.op_Equality(skillPosition) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z)))) le 1e-05
- set `beforePos.y` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).y` — when !UnityEngine.Object.op_Equality(skillPosition) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z)))) gt 1e-05 OR !UnityEngine.Object.op_Equality(skillPosition) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z)))) le 1e-05
- set `beforePos.z` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z` — when !UnityEngine.Object.op_Equality(skillPosition) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z)))) gt 1e-05 OR !UnityEngine.Object.op_Equality(skillPosition) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z)))) le 1e-05
- set `moveVec` = `UnityEngine.Vector3.static+0x0` — when !UnityEngine.Object.op_Equality(skillPosition) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z)))) le 1e-05
- set `moveVec.y` = `UnityEngine.Vector3.static+0x4` — when !UnityEngine.Object.op_Equality(skillPosition) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z)))) le 1e-05
- set `moveVec.z` = `UnityEngine.Vector3.static+0x8` — when !UnityEngine.Object.op_Equality(skillPosition) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x - beforePos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z - beforePos.z)))) le 1e-05

**`.<>c__DisplayClass32_0::<ActionPreparation>b__0`** (1 path)

- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(673, 0, 0)`

</details>

<details><summary>Effect applied in `L_BoomerangAction$$OnInitialize` (4 guarded paths)</summary>

- when `SkillLv(674) ge 1` AND `SkillLv(675) ge 1`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `skillRate` = `(((SkillLv(675) * 25) + (((SkillLv(674) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200)) + 200)`
  - set `fixAddDamage` = `200`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
- when `SkillLv(674) ge 1` AND `SkillLv(675) lt 1`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `skillRate` = `(((SkillLv(674) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200)`
  - set `fixAddDamage` = `200`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
- when `SkillLv(674) lt 1` AND `SkillLv(675) ge 1`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `skillRate` = `(((SkillLv(675) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200)`
  - set `fixAddDamage` = `200`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
- when `SkillLv(674) lt 1` AND `SkillLv(675) lt 1`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `skillRate` = `([?blr+0x24] + ((Lv * 25) + 200))`
  - set `fixAddDamage` = `200`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `L_Boomerang2Action$$OnInitialize (GetSkillLv)`
- `L_BoomerangAction$$OnInitialize (GetSkillLv)`

---

### Nดราก้อนทูธ / นีโน่ดราก้อนทูธ (N_DragonTooth) · uid 676

<img src="../../icons/sk_676.png" width="40" alt="icon"> 
**Tree:** パルチザンスキル (`PartisanSkill`, tier 3) · **Type:** Attack · **Max Lv:** 250 · **Weapons:** Halberd · **Flags:** NoMarketSearch · **Client class:** `N_DragonToothAction`

> ดราก้อนทูธที่คิดค้นโดยนีโน่
> โจมตีเป้าหมายและเคลื่อนที่ไปข้างหลัง
> เพิ่มพลังเจาะเข้าของสกิลที่ใช้ถัดไปเล็กน้อย
> เพิ่มพลังขึ้นอีกเมื่อเรียนสกิล"ดราก้อนทูธ"

<details><summary>In-game level notes</summary>

- Lv9: หากใช้สกิลสำเร็จโดยไม่ได้รับความเสียหายจะฟื้นฟู MP เล็กน้อย ปริมาณการฟื้นฟู MP จะเพิ่มขึ้นตามระยะถอยห่างด้วยการกดปุ่ม และขึ้นอยู่กับเลเวลที่เรียนรู้ของสกิลดราก้อนทูธ

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.75 | 1.5 | 2.25 | 3 | 3.75 | 4.5 | 5.25 | 6 | 6.75 | 7.5 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((max((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 972, 1) * 75), 0) / 100))` — calcSecondDamage

**Role:** attack (deals damage) · buff (self)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillRate` multiplies by (adds into): `(((Lv * 75) / 100))` | `((max((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 972, 1) * 75), 0) / 100))`

**Mechanics recovered from code**

- **First-part skill multiplier (%)** (`firstSkillRate`): `((Lv * 75) / 100)` → Lv1..10 [0.75, 1.5, 2.25, 3.0, 3.75, 4.5, 5.25, 6.0, 6.75, 7.5]
- **Second-part multiplier** (`secondSkillRate`): `(max((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 972, 1) * 75), 0) / 100)`
- **MP recovered** (`mpRecovery`): `((max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 972, 1), 0) + (max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 972, 1), 0) << 2)) << 1)`
- **Resistance value** (`resist`): `(Lv * 10)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 676

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `firstSkillRate` = `((Lv * 75) / 100)` → Lv1..10: [0.75, 1.5, 2.25, 3.0, 3.75, 4.5, 5.25, 6.0, 6.75, 7.5]
- set `secondSkillRate` = `(max((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 972, 1) * 75), 0) / 100)`
- set `mpRecovery` = `((max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 972, 1), 0) + (max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 972, 1), 0) << 2)) << 1)`
- set `critical` = `(Lv * 5)` → Lv1..10: [5, 10, 15, 20, 25, 30, 35, 40, 45, 50]
- set `resist` = `(Lv * 10)` → Lv1..10: [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`
- set `targetPos` = `castTime`

**`OtherPlayerAttackStartReceive`** (1 path)

- set `distance` = `(SkillIndividualFlag / 100)`

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
- set `distance` = `max((fsqrt((((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x)))) - CharacterActionManagerBase.get_Size()), 0)` — when !PlayerAttackBase.IsBlank(this)
- set `SkillIndividualFlag` = `int((max((fsqrt((((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x)))) - CharacterActionManagerBase.get_Size()), 0) * 100))` — when !PlayerAttackBase.IsBlank(this)

**`calcPlayerToMobDamage`** (2 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)`

**`calcFirstDamage`** (2 paths)

- template `AddRate[SkillRate]` = `firstSkillRate`
- info `templates` = `1`

**`calcSecondDamage`** (2 paths)

- template `AddRate[SkillRate]` = `secondSkillRate`
- info `templates` = `1`

</details>

**Buffs**

**Buff `N_DragonToothBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- `Value` = `0` _(when BuffEffectActive eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |

- Buff fields set in the constructor (all recovered):
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
  - `BufEffectTakeUid` = `-1` = -1

---

### สัญชาตญาณการอยู่รอด (SurvivalInstinct) · uid 679

<img src="../../icons/sk_679.png" width="40" alt="icon"> 
**Tree:** パルチザンスキル (`PartisanSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Bow, Bowgun · **Requires:** ลับคมลูกศร · **Flags:** NoMarketSearch

> เมื่อสมาชิกปาร์ตี้ตาย HP สูงสุดและ
> อัตราส่วนการลดความเสียหายจะเพิ่มขึ้น
> *ไม่เปิดใช้งานในบางสถานการณ์

**Role:** buff (self) · passive mastery · no client action class (system / production / unreleased)

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Buffs**

**Buff `SurvivalInstinctBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `20` s

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MaxHpUp | 500 | 1000 | 1500 | 2000 | 2500 | 3000 | 3500 | 4000 | 4500 | 5000 |
| MaxHpUpRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| RateDamageResist | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |

- Buff fields set in the constructor (all recovered):
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

<details><summary>Effect applied in `MobAttackBase$$CalcLastDamage` (300 guarded paths, truncated)</summary>

- when `TryGetValue.out2() ne 0` AND `0 mi CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - returns `0`
  - set `earthStyleDamageCut` = `1`
  - set `geoImpactUseBarrier` = `(CharacterActionManagerBase.set_DefaultMoveSpeed() - CharacterActionManagerBase.set_DefaultMoveSpeed())`
  - set `stoneSkinCutValue` = `(CharacterActionManagerBase.set_DefaultMoveSpeed() - CharacterActionManagerBase.set_DefaultMoveSpeed())`
  - set `arkSaberMpDamage` = `((mul64((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) * StoneSkinBuf.DamageCut(TryGetValue.out2(), GeoImpactBuf.DamageCut(TryGetValue.out2(), max((int((int((((BonusManager.GetBonusValue(?blr, 192, 0, ?x3) + 100) * MobAttackBas`
  - calls `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$Contains`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$Contains`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$GetAbnormalData`, `UnityEngine.Component$$GetComponent<object>`, `interface IUserArchetype.get_ArchetypeUid`
- when `TryGetValue.out2() ne 0` AND `0 mi CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - returns `StoneSkinBuf.DamageCut(TryGetValue.out2(), GeoImpactBuf.DamageCut(TryGetValue.out2(), max((int((int((((BonusManager.GetBonusValue(?blr, 192, 0, ?x3) + 100) * MobAttackBase.calcResistDamage(meta(0x39734d8, System.Math_TypeInfo), MobAttackBase.calcResistDamage(meta(0x39734d8, System.Math_TypeInfo), int((((100 - CharacterActionManagerBase.set_DefaultMoveSpeed()) * 0.01) * int((((Toram.Common.ArchetypeUid.IsArchetype(stkp(-160), [AbnormalStateManager.GetAbnormalData(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30, 0, ?x3)+0x28], [AbnormalStateManager.GetAbnormalData(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30, 0, ?x3)+0x2c], 0) & 1) ne 0 ? ((AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 15, 0, damage) & 1) ne 0 ? 0.7 : 1) : (((AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 15, 0, damage) & 1) ne 0 ? 0.7 : 1) + -0.1)) * damage)))), ?x2, ?x3), ?x2, ?x3)) / 100)) * (GemCartBufferManager.GetRecieveDamageRate(?blr, ?blr, MobActionManagerBase.get_transform(mobAction), this) + 1))) - int(((SkillBufferDataBase.GetParam(TryGetValue.out2(), 50, 0, ?x3) * IPlayerStatusCalculator.get_MaxHp(?blr)) * 0.01))), 0), 0, ?x3), 0, ?x3)`
  - set `earthStyleDamageCut` = `1`
  - set `geoImpactUseBarrier` = `(CharacterActionManagerBase.set_DefaultMoveSpeed() - CharacterActionManagerBase.set_DefaultMoveSpeed())`
  - set `stoneSkinCutValue` = `(CharacterActionManagerBase.set_DefaultMoveSpeed() - CharacterActionManagerBase.set_DefaultMoveSpeed())`
  - calls `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$Contains`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$Contains`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$GetAbnormalData`, `UnityEngine.Component$$GetComponent<object>`, `interface IUserArchetype.get_ArchetypeUid`
- when `TryGetValue.out2() ne 0` AND `0 mi CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - returns `0`
  - set `earthStyleDamageCut` = `1`
  - set `geoImpactUseBarrier` = `(CharacterActionManagerBase.set_DefaultMoveSpeed() - CharacterActionManagerBase.set_DefaultMoveSpeed())`
  - set `arkSaberMpDamage` = `((mul64((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) * GeoImpactBuf.DamageCut(TryGetValue.out2(), max((int((int((((BonusManager.GetBonusValue(?blr, 192, 0, ?x3) + 100) * MobAttackBase.calcResistDamage(meta(0x39734d8, System.M`
  - calls `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$Contains`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$Contains`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$GetAbnormalData`, `UnityEngine.Component$$GetComponent<object>`, `interface IUserArchetype.get_ArchetypeUid`
- when `TryGetValue.out2() ne 0` AND `0 mi CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - returns `GeoImpactBuf.DamageCut(TryGetValue.out2(), max((int((int((((BonusManager.GetBonusValue(?blr, 192, 0, ?x3) + 100) * MobAttackBase.calcResistDamage(meta(0x39734d8, System.Math_TypeInfo), MobAttackBase.calcResistDamage(meta(0x39734d8, System.Math_TypeInfo), int((((100 - CharacterActionManagerBase.set_DefaultMoveSpeed()) * 0.01) * int((((Toram.Common.ArchetypeUid.IsArchetype(stkp(-160), [AbnormalStateManager.GetAbnormalData(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30, 0, ?x3)+0x28], [AbnormalStateManager.GetAbnormalData(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30, 0, ?x3)+0x2c], 0) & 1) ne 0 ? ((AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 15, 0, damage) & 1) ne 0 ? 0.7 : 1) : (((AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 15, 0, damage) & 1) ne 0 ? 0.7 : 1) + -0.1)) * damage)))), ?x2, ?x3), ?x2, ?x3)) / 100)) * (GemCartBufferManager.GetRecieveDamageRate(?blr, ?blr, MobActionManagerBase.get_transform(mobAction), this) + 1))) - int(((SkillBufferDataBase.GetParam(TryGetValue.out2(), 50, 0, ?x3) * IPlayerStatusCalculator.get_MaxHp(?blr)) * 0.01))), 0), 0, ?x3)`
  - set `earthStyleDamageCut` = `1`
  - set `geoImpactUseBarrier` = `(CharacterActionManagerBase.set_DefaultMoveSpeed() - CharacterActionManagerBase.set_DefaultMoveSpeed())`
  - calls `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$Contains`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$Contains`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$GetAbnormalData`, `UnityEngine.Component$$GetComponent<object>`, `interface IUserArchetype.get_ArchetypeUid`
- when `TryGetValue.out2() ne 0` AND `0 mi CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - returns `0`
  - set `earthStyleDamageCut` = `1`
  - set `stoneSkinCutValue` = `(CharacterActionManagerBase.set_DefaultMoveSpeed() - CharacterActionManagerBase.set_DefaultMoveSpeed())`
  - set `arkSaberMpDamage` = `((mul64((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) * StoneSkinBuf.DamageCut(TryGetValue.out2(), max((int((int((((BonusManager.GetBonusValue(?blr, 192, 0, ?x3) + 100) * MobAttackBase.calcResistDamage(meta(0x39734d8, System.M`
  - calls `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$Contains`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$Contains`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$GetAbnormalData`, `UnityEngine.Component$$GetComponent<object>`, `interface IUserArchetype.get_ArchetypeUid`
- when `TryGetValue.out2() ne 0` AND `0 mi CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - returns `StoneSkinBuf.DamageCut(TryGetValue.out2(), max((int((int((((BonusManager.GetBonusValue(?blr, 192, 0, ?x3) + 100) * MobAttackBase.calcResistDamage(meta(0x39734d8, System.Math_TypeInfo), MobAttackBase.calcResistDamage(meta(0x39734d8, System.Math_TypeInfo), int((((100 - CharacterActionManagerBase.set_DefaultMoveSpeed()) * 0.01) * int((((Toram.Common.ArchetypeUid.IsArchetype(stkp(-160), [AbnormalStateManager.GetAbnormalData(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30, 0, ?x3)+0x28], [AbnormalStateManager.GetAbnormalData(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30, 0, ?x3)+0x2c], 0) & 1) ne 0 ? ((AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 15, 0, damage) & 1) ne 0 ? 0.7 : 1) : (((AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 15, 0, damage) & 1) ne 0 ? 0.7 : 1) + -0.1)) * damage)))), ?x2, ?x3), ?x2, ?x3)) / 100)) * (GemCartBufferManager.GetRecieveDamageRate(?blr, ?blr, MobActionManagerBase.get_transform(mobAction), this) + 1))) - int(((SkillBufferDataBase.GetParam(TryGetValue.out2(), 50, 0, ?x3) * IPlayerStatusCalculator.get_MaxHp(?blr)) * 0.01))), 0), 0, ?x3)`
  - set `earthStyleDamageCut` = `1`
  - set `stoneSkinCutValue` = `(CharacterActionManagerBase.set_DefaultMoveSpeed() - CharacterActionManagerBase.set_DefaultMoveSpeed())`
  - calls `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$Contains`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$Contains`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$GetAbnormalData`, `UnityEngine.Component$$GetComponent<object>`, `interface IUserArchetype.get_ArchetypeUid`
- when `TryGetValue.out2() ne 0` AND `0 mi CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - returns `0`
  - set `earthStyleDamageCut` = `1`
  - set `arkSaberMpDamage` = `((mul64((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) * max((int((int((((BonusManager.GetBonusValue(?blr, 192, 0, ?x3) + 100) * MobAttackBase.calcResistDamage(meta(0x39734d8, System.Math_TypeInfo), MobAttackBase.calcResistDama`
  - calls `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$Contains`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$Contains`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$GetAbnormalData`, `UnityEngine.Component$$GetComponent<object>`, `interface IUserArchetype.get_ArchetypeUid`
- when `TryGetValue.out2() ne 0` AND `0 mi CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - returns `max((int((int((((BonusManager.GetBonusValue(?blr, 192, 0, ?x3) + 100) * MobAttackBase.calcResistDamage(meta(0x39734d8, System.Math_TypeInfo), MobAttackBase.calcResistDamage(meta(0x39734d8, System.Math_TypeInfo), int((((100 - CharacterActionManagerBase.set_DefaultMoveSpeed()) * 0.01) * int((((Toram.Common.ArchetypeUid.IsArchetype(stkp(-160), [AbnormalStateManager.GetAbnormalData(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30, 0, ?x3)+0x28], [AbnormalStateManager.GetAbnormalData(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30, 0, ?x3)+0x2c], 0) & 1) ne 0 ? ((AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 15, 0, damage) & 1) ne 0 ? 0.7 : 1) : (((AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 15, 0, damage) & 1) ne 0 ? 0.7 : 1) + -0.1)) * damage)))), ?x2, ?x3), ?x2, ?x3)) / 100)) * (GemCartBufferManager.GetRecieveDamageRate(?blr, ?blr, MobActionManagerBase.get_transform(mobAction), this) + 1))) - int(((SkillBufferDataBase.GetParam(TryGetValue.out2(), 50, 0, ?x3) * IPlayerStatusCalculator.get_MaxHp(?blr)) * 0.01))), 0)`
  - set `earthStyleDamageCut` = `1`
  - calls `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$Contains`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$Contains`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$GetAbnormalData`, `UnityEngine.Component$$GetComponent<object>`, `interface IUserArchetype.get_ArchetypeUid`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `MobAttackBase$$CalcLastDamage (TryGetBuf)`

---
