# クラッシャー (`CrusherSkill`) — skill details

10 entries.

### กำปั้นผดุงคุณธรรม (ForefistPunch) · uid 1153

<img src="../../icons/sk_1153.png" width="40" alt="icon"> 
**Tree:** クラッシャー (`CrusherSkill`, tier 1) · **Type:** Attack · **Max Lv:** 50 · **Weapons:** MainKnuckle · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `ForefistPunchAction`

> หมัดตรงอันเฉียบคม
> เป้าหมายจะโดนโจมตีคริติคอล
> ระหว่างใช้ความเสียหายที่ได้รับจะลดลง 1 ครั้ง

**How it works**

- Attack skill of the クラッシャー tree (tier 1, max Lv 50); usable with MainKnuckle.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×2.2 at Lv1 to 4 at Lv10; flat damage +200
  - `calcPlayerToMobDamage` [UnityEngine.Object.op_Inequality(actarAction)]: skill multiplier depends on live values (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Buffs:
  - `ForefistPunchBuf`; Lv1 → Lv10: Value (generic value (meaning set by the code that reads the buff)) 25 → 25

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionPreparation` — before the cast starts: 1 set
- `ActionStart` — when the cast starts: 1 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 2 tpl, 1 info
- `OnInheritance` — state carried over when this action follows another: 1 set
- `.<>c__DisplayClass25_0::<ActionStart>b__0` — skill-specific method: 1 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 2.2 | 2.4 | 2.6 | 2.8 | 3 | 3.2 | 3.4 | 3.6 | 3.8 | 4 |
| Flat dmg + | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv + (Lv << 2)) << 2) + 200)) * 0.01)` — UnityEngine.Object.op_Inequality(actarAction)

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv + (Lv << 2)) << 2) + 200)) * 0.01)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(200)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1153
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): adds the caster's buff of skill 1153 (ForefistPunch) — `AddSelfBuffer(1153, Lv, 0)`
  - when `!PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction)`
- `.<>c__DisplayClass25_0::<ActionStart>b__0` (method): removes the caster's buff of skill 1153 (ForefistPunch) — `RemoveSelfBuffer(1153)`

**Buff values** (every recovered field; durations in seconds)

**Buff `ForefistPunchBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 25 | 25 | 25 | 25 | 25 | 25 | 25 | 25 | 25 | 25 |


Parameter meanings (inferred from the `SkillBufferId` names):

- `Value`: generic value (meaning set by the code that reads the buff)

_Raw recovered data (every method item): [trees/CrusherSkill.md](../trees/CrusherSkill.md) — uid 1153_

---

### วิธีการหายใจ (BreathingMethod) · uid 1154

<img src="../../icons/sk_1154.png" width="40" alt="icon"> 
**Tree:** クラッシャー (`CrusherSkill`, tier 1) · **Type:** Buffer · **Max Lv:** 50 · **Weapons:** Knuckle · **Flags:** StarGem · **Client class:** `BreathingMethodAction`

> วิธีจัดเตรียมลมหายใจอย่างรวดเร็ว
> ระหว่างใช้งาน HP ของตัวเองจะฟื้นฟูทันที
> ตอนใช้สกิลถัดไป HP ก็ยังฟื้นฟูอยู่
> พลังการฟื้นฟูของวิธีการหายใจจะลดต่ำลง

**How it works**

- Buffer skill of the クラッシャー tree (tier 1, max Lv 50); usable with Knuckle.
- It installs a buff on the caster.
- MP: `(mp - 100)`.
- Other client code reads this skill (4 lookups; see the last section).

**Cost, timing and range**

- **MP cost** (`mp` in `OnInitialize`): `(mp - 100)`
  - when `hasGemCart(1037)`
- **Cast time** (`CastTime`): `SkillUtil.CalcCastTime(0, PlayerStatusBase.get_BattleStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 1 call
- `OnInheritance` — state carried over when this action follows another: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1154
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): adds the caster's buff of skill 1154 (BreathingMethod) — `AddSelfBuffer(1154, Lv, 0)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Other recovered parameters**

- **MP cost** (`mp`): `(mp - 100)` _(when hasGemCart(1037))_
- **Cast time modifier** (`CastTime`): `SkillUtil.CalcCastTime(0, PlayerStatusBase.get_BattleStatus())`

**Where else this skill takes effect**

- Effect applied in `PlayerAttackBase$$RemoveAfterSkillBuf` (300 guarded paths, truncated):
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
- Effect applied in `GazerShootAction$$ActionHit` (2 guarded paths):
  - when `longBonus ne 0` AND `SkillLv(1154) ge 1`
    - calls `SkillActionBase$$ActionHit`, `0x165db78`, `BreathingMethodBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
  - when `longBonus ne 0` AND `SkillLv(1154) lt 1`
    - returns `SkillLv(1154)`
    - calls `SkillActionBase$$ActionHit`
- Effect applied in `GeoImpactAction$$ActionPreparation` (7 guarded paths):
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
- Code that reads this skill's level / buff by constant id: `GazerShootAction$$ActionHit (GetSkillLv)`, `GeoImpactAction$$ActionPreparation (TryGetBuf)`, `PlayerAttackBase$$CalcCostMp (ContainsBuffer)`, `PlayerAttackBase$$RemoveAfterSkillBuf (ContainsBuffer)`

_Raw recovered data (every method item): [trees/CrusherSkill.md](../trees/CrusherSkill.md) — uid 1154_

---

### กลอเรียเทคชอต (GoliathTakeShot) · uid 1155

<img src="../../icons/sk_1155.png" width="40" alt="icon"> 
**Tree:** クラッシャー (`CrusherSkill`, tier 2) · **Type:** Attack · **Max Lv:** 90 · **Weapons:** MainKnuckle · **Requires:** กำปั้นผดุงคุณธรรม · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `GoliathTakeShotAction`

> โจมตีศัตรูตัวฉกาจอย่างรุนแรง
> ชาร์จสกิล(เลเวล6)
> จะโจมตีในระยะที่แคบมาก
> ถ้าเลยเวลาที่ชาร์จนเต็มไปแล้ว
> พลังจะลดลง

**How it works**

- Attack skill of the クラッシャー tree (tier 2, max Lv 90); usable with MainKnuckle.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- MP: `(hasBuff(1155) ? 0 : 500)`.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on live values (formula below); flat damage +500
  - `calcPlayerToMobDamage` [IsInstanceOf(actarAction, MercenaryActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(actarAction, MercenaryActionManager) eq 1 AND UnityEngine.Object.op_Inequality(actarAction)]: skill multiplier depends on live values (formula below); skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [IsInstanceOf(actarAction, MercenaryActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(actarAction, MercenaryActionManager) eq 1 AND UnityEngine.Object.op_Inequality(actarAction) & IsInstanceOf(actarAction, MercenaryActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(actarAction, MercenaryActionManager) eq 1 AND UnityEngine.Object.op_Inequality(actarAction)]: skill multiplier depends on live values (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Buffs:
  - `GoliathTakeShotBuf`
- Other client code reads this skill (4 lookups; see the last section).

**Cost, timing and range**

- **MP cost** (`mp` in `OnInitialize`): `(hasBuff(1155) ? 0 : 500)`
- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 7 set
- `InitializeOthers` — setup used when another player's client replays the action: 3 set
- `ActionStart` — when the cast starts: 3 set, 1 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 2 tpl, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 500 | 500 | 500 | 500 | 500 | 500 | 500 | 500 | 500 | 500 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((800) + ((((Lv * 10) + 300)) * (GoliathTakeShotBuf.GetParam(50)))) * 0.01)`
- SkillRate × `(((800) + ((((Lv * 10) + 300)) * (GoliathTakeShotBuf.GetParam(50)))) * 0.01)` — IsInstanceOf(actarAction, MercenaryActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(actarAction, MercenaryActionManager) eq 1 AND UnityEngine.Object.op_Inequality(actarAction)
- SkillRate × `(((800) + ((((Lv * 10) + 300)) * (GoliathTakeShotBuf.GetParam(50)))) * 0.01)` — IsInstanceOf(actarAction, MercenaryActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(actarAction, MercenaryActionManager) eq 1 AND UnityEngine.Object.op_Inequality(actarAction)
- SkillRate × `(((800) + ((((Lv * 10) + 300)) * (GoliathTakeShotBuf.GetParam(50)))) * 0.01)` — IsInstanceOf(actarAction, MercenaryActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(actarAction, MercenaryActionManager) eq 1 AND UnityEngine.Object.op_Inequality(actarAction) & IsInstanceOf(actarAction, MercenaryActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(actarAction, MercenaryActionManager) eq 1 AND UnityEngine.Object.op_Inequality(actarAction)

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((800) + ((((Lv * 10) + 300)) * (GoliathTakeShotBuf.GetParam(50)))) * 0.01)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(500)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1155
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): removes the caster's buff of skill 1155 (GoliathTakeShot) — `RemoveSelfBuffer(1155)`
  - when `IsInstanceOf(actarAction, MercenaryActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(actarAction, MercenaryActionManager) eq 1 AND UnityEngine.Object.op_Inequality(actarAction)`

**Other recovered parameters**

- **MP cost** (`mp`): `(hasBuff(1155) ? 0 : 500)`

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `Value`: generic value (meaning set by the code that reads the buff)

**Where else this skill takes effect**

- Effect applied in `MobaPlayerActionManager$$GetSkillTargetType` (2 guarded paths):
  - when `skillId gt 577` AND `skillId gt 995` AND `skillId le 1155` AND `skillId ne 1131`
    - returns `[MasterSkillDataManager.GetSkillMaster(Singleton<object>.get_Instance(meta(0x397a328, Method$Singleton<MasterSkillDataManager>.get_Instance()), ?x1, ?x2, ?x3), 1155, 0, ?x3)+0x2c]`
    - calls `Singleton<object>$$get_Instance`, `MasterSkillDataManager$$GetSkillMaster`
  - when `skillId gt 577` AND `skillId gt 995` AND `skillId le 1155` AND `skillId ne 1131`
    - returns `1`
- Effect applied in `PlayerActionManager$$GetSkillTargetType` (2 guarded paths):
  - when `skillId gt 629` AND `skillId gt 991` AND `skillId le 1155` AND `skillId ne 995`
    - returns `[MasterSkillDataManager.GetSkillMaster(Singleton<object>.get_Instance(meta(0x397a328, Method$Singleton<MasterSkillDataManager>.get_Instance()), ?x1, ?x2, ?x3), 1155, 0, ?x3)+0x2c]`
    - calls `Singleton<object>$$get_Instance`, `MasterSkillDataManager$$GetSkillMaster`
  - when `skillId gt 629` AND `skillId gt 991` AND `skillId le 1155` AND `skillId ne 995`
    - returns `1`
- Effect applied in `GoliathTakeShotAction$$ReceivedAbnormal` (8 guarded paths):
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
- Code that reads this skill's level / buff by constant id: `GoliathTakeShotAction$$OnInitialize (ContainsBuffer)`, `GoliathTakeShotAction$$ReceivedAbnormal (TryGetBuf)`, `MobaPlayerActionManager$$GetSkillTargetType (ContainsBuffer)`, `PlayerActionManager$$GetSkillTargetType (ContainsBuffer)`

_Raw recovered data (every method item): [trees/CrusherSkill.md](../trees/CrusherSkill.md) — uid 1155_

---

### ฟลายอิ้งคิก (FloatingKick) · uid 1156

<img src="../../icons/sk_1156.png" width="40" alt="icon"> 
**Tree:** クラッシャー (`CrusherSkill`, tier 2) · **Type:** Attack · **Max Lv:** 90 · **Weapons:** Knuckle · **Requires:** วิธีการหายใจ · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `FloatingKickAction`

> กระโดดลอยไปเตะจากระยะไกล
> ถ้าใช้แบบธรรมดาจะเพิ่มความรุนแรงให้โจมตีคริติคอล
> เมื่อใช้ระหว่างเคลื่อนที่จะเล็งตรงเป้า
> โจมตีคริติคอลจะเพิ่มขึ้นในระดับนึงเท่านั้น

**How it works**

- Attack skill of the クラッシャー tree (tier 2, max Lv 90); usable with Knuckle.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×5.2 at Lv1 to 7 at Lv10; flat damage +110 at Lv1 to 200 at Lv10
  - `calcPlayerToMobDamage` [!InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(target) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [(!PlayerAttackBase.checkCriticalPercent(this, status.Critical, mobAction) ^ 1) AND (SkillCalcTemplate.get_Item(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 13) + (criticalDmgUp * 0.01)) ls 2 AND inputDirection eq 0]: extra crit multiplier +0.14 at Lv1 to 0.5 at Lv10
- Proration: physical-skill proration slot, mode `first_hit_per_target`.

**Cost, timing and range**

- **Cast time** (`CastTime`): `int(((UnityEngine.Transform.get_eulerAngles(UnityEngine.Component.get_transform(actarAction)).y gt 180 ? (UnityEngine.Transform.get_eulerAngles(UnityEngine.Component.get_transform(actarAction)).y + -360) : UnityEngine.Transform.get_eulerAngles(UnityEngine.Component.get_transform(actarAction)).y) * 10))`
  - when `!InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(target) AND UnityEngine.Object.op_Inequality(actarAction)`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(7)`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `ActionPreparation` — before the cast starts: 15 set
- `InitializeOthers` — setup used when another player's client replays the action: 3 set
- `ActionStartOthers` — skill-specific method: 1 set
- `SetTargetMobOthers` — skill-specific method: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 3 tpl, 1 info
- `ActionSkillEvent` — on an animation/skill event during the motion: 1 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 5.2 | 5.4 | 5.6 | 5.8 | 6 | 6.2 | 6.4 | 6.6 | 6.8 | 7 |
| Flat dmg + | 110 | 120 | 130 | 140 | 150 | 160 | 170 | 180 | 190 | 200 |
| Crit mult + | 0.14 | 0.18 | 0.22 | 0.26 | 0.3 | 0.34 | 0.38 | 0.42 | 0.46 | 0.5 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv + (Lv << 2)) << 2) + 500)) * 0.01)` — !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(target) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv + (Lv << 2)) << 2) + 500)) * 0.01)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv * 10) + 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[CriticalRate]` = `((((Lv << 2) + 10)) * 0.01)`
  - when `(!PlayerAttackBase.checkCriticalPercent(this, status.Critical, mobAction) ^ 1) AND (SkillCalcTemplate.get_Item(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 13) + (criticalDmgUp * 0.01)) ls 2 AND inputDirection eq 0`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1156
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `int(((UnityEngine.Transform.get_eulerAngles(UnityEngine.Component.get_transform(actarAction)).y gt 180 ? (UnityEngine.Transform.get_eulerAngles(UnityEngine.Component.get_transform(actarAction)).y + -360) : UnityEngine.Transform.get_eulerAngles(UnityEngine.Component.get_transform(actarAction)).y) * 10))` _(when !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(target) AND UnityEngine.Object.op_Inequality(actarAction))_

_Raw recovered data (every method item): [trees/CrusherSkill.md](../trees/CrusherSkill.md) — uid 1156_

---

### คอมบิเนชั่น (Combination) · uid 1157

<img src="../../icons/sk_1157.png" width="40" alt="icon"> 
**Tree:** クラッシャー (`CrusherSkill`, tier 2) · **Type:** Attack · **Max Lv:** 90 · **Weapons:** MainKnuckle · **Requires:** วิธีการหายใจ · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `CombinationAction`

> ออกหมัดต่อเนื่องอย่างรวดเร็ว
> สกิลนี้โจมตีด้วย[ความเคยชินตามปกติ]
> อัตราคริติคอลเพิ่มขึ้นตามสกิลเลเวลที่เพิ่มขึ้น

**How it works**

- Attack skill of the クラッシャー tree (tier 2, max Lv 90); usable with MainKnuckle.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×1.1 at Lv1 to 2 at Lv10
  - `calcPlayerToMobDamage` [UnityEngine.Object.op_Inequality(actarAction)]: skill multiplier depends on live values (formula below)
- Proration: normal-attack proration slot, mode `first_hit_per_target`.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionPreparation` — before the cast starts: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 1 tpl, 1 call, 1 info
- `OnInheritance` — state carried over when this action follows another: 1 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 1.1 | 1.2 | 1.3 | 1.4 | 1.5 | 1.6 | 1.7 | 1.8 | 1.9 | 2 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv + (Lv << 2)) << 1) + 100)) * 0.01)` — UnityEngine.Object.op_Inequality(actarAction)

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv + (Lv << 2)) << 1) + 100)) * 0.01)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Normal`, mode `first_hit_per_target`, attack type `SkillNormal`, action id 1157
- Uses the normal-attack proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `calcPlayerToMobDamage` (damage calculation against a monster): chains one more damage event — `CreateNextDamage()`

_Raw recovered data (every method item): [trees/CrusherSkill.md](../trees/CrusherSkill.md) — uid 1157_

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

**How it works**

- Attack skill of the クラッシャー tree (tier 3, max Lv 170); usable with MainKnuckle.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×10; flat damage +40 at Lv1 to 400 at Lv10
  - `calcPlayerToMobDamage` [UnityEngine.Object.op_Inequality(actarAction)]: skill multiplier depends on live values (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Buffs:
  - `GodHandBuf`: lasts `time` s; Lv1 → Lv10: MobLastDamageRateUnique (final damage multiplier vs monsters (unique category)) 72 → 72
- Other client code reads this skill (8 lookups; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionPreparation` — before the cast starts: 1 set
- `ActionStart` — when the cast starts: 3 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 2 tpl, 1 info
- `OnInheritance` — state carried over when this action follows another: 1 set
- `.<>c__DisplayClass25_0::<ActionStart>b__0` — skill-specific method: 1 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 10 | 10 | 10 | 10 | 10 | 10 | 10 | 10 | 10 | 10 |
| Flat dmg + | 40 | 80 | 120 | 160 | 200 | 240 | 280 | 320 | 360 | 400 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((1000) * 0.01)` — UnityEngine.Object.op_Inequality(actarAction)

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((1000) * 0.01)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv + (Lv << 2)) << 3))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1158
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): removes the caster's buff of skill 1158 (GodHand) — `RemoveSelfBuffer(1158)`
  - when `!PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValuePlayerStatusBase.get_SkillBufferManager().skillBufList, 1158, (new GodHandAction.<>c__DisplayClass25_0 + 24), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue!PlayerStatusBase.get_SkillBufferManager().skillBufList, 1158, (new GodHandAction.<>c__DisplayClass25_0 + 24), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValuePlayerStatusBase.get_SkillBufferManager().skillBufList, 1158, (new GodHandAction.<>c__DisplayClass25_0 + 24), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction)`
- `ActionStart` (when the cast starts): adds the caster's buff of skill 1158 (GodHand) — `AddSelfBuffer(1158, Lv, new GodHandAction.<>c__DisplayClass25_0.buf.LeftTime)`
  - when `!PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValuePlayerStatusBase.get_SkillBufferManager().skillBufList, 1158, (new GodHandAction.<>c__DisplayClass25_0 + 24), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValuePlayerStatusBase.get_SkillBufferManager().skillBufList, 1158, (new GodHandAction.<>c__DisplayClass25_0 + 24), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValuePlayerStatusBase.get_SkillBufferManager().skillBufList, 1158, (new GodHandAction.<>c__DisplayClass25_0 + 24), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) AND MobaMode eq 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction)`
- `ActionStart` (when the cast starts): adds the caster's buff of skill 1158 (GodHand) — `AddSelfBuffer(1158, Lv, 0)`
  - when `!PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue!PlayerStatusBase.get_SkillBufferManager().skillBufList, 1158, (new GodHandAction.<>c__DisplayClass25_0 + 24), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue!PlayerStatusBase.get_SkillBufferManager().skillBufList, 1158, (new GodHandAction.<>c__DisplayClass25_0 + 24), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue!PlayerStatusBase.get_SkillBufferManager().skillBufList, 1158, (new GodHandAction.<>c__DisplayClass25_0 + 24), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) AND MobaMode eq 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction)`
- `.<>c__DisplayClass25_0::<ActionStart>b__0` (method): removes the caster's buff of skill 1158 (GodHand) — `RemoveSelfBuffer(1158)`
  - when `(System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValuePlayerStatusBase.get_SkillBufferManager().selfSkillBufList, 1158, (this + 24), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) AND SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1158], 20) eq 0`

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `AbnormalRegist`: ailment resistance
- `MobLastDamageRateBuf`: final damage multiplier vs monsters (buff category)
- `MobLastDamageRateUnique`: final damage multiplier vs monsters (unique category)
- `Value`: generic value (meaning set by the code that reads the buff)

**Where else this skill takes effect**

- Effect applied in `PlayerActionManager$$Damaged` (9 guarded paths):
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
- Effect applied in `MobaPlayerSecondaryStatus$$get_AntiVirus` (27 guarded paths):
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
- Effect applied in `PlayerSecondaryStatus$$CalcAntiVirus` (27 guarded paths):
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
- Effect applied in `MobaPlayerActionManager$$ReceiveDamaged` (296 guarded paths, truncated):
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
- Effect applied in `GazerShootAction$$ActionPreparation` (3 guarded paths):
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
- Effect applied in `GodHandAction$$ActionHit` (3 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `?blr`
    - calls `SkillActionBase$$ActionHit`, `System.Collections.Generic.List<object>$$get_Item`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `SkillActionBase$$ActionHit`, `System.Collections.Generic.List<object>$$get_Item`, `0x165db84`, `0x165df00`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-40), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-40), 0)`
    - calls `SkillActionBase$$ActionHit`, `System.Collections.Generic.List<object>$$get_Item`
- Effect applied in `MindimageSenjuAttackAction$$ActionHit` (3 guarded paths):
  - when `IsInheritance ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() ne 844` AND `CharacterActionManagerBase.get_IsLocalDead() eq 1158` AND `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-56), 0) & 1) ne 0`
    - returns `?blr`
    - calls `SkillActionBase$$ActionHit`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`
  - when `IsInheritance ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() ne 844` AND `CharacterActionManagerBase.get_IsLocalDead() eq 1158` AND `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-56), 0) & 1) ne 0`
    - calls `SkillActionBase$$ActionHit`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `0x165db84`, `0x165df00`
  - when `IsInheritance ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() ne 844` AND `CharacterActionManagerBase.get_IsLocalDead() eq 1158` AND `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-56), 0) & 1) eq 0`
    - returns `?blr`
    - calls `SkillActionBase$$ActionHit`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `SkillBufferManager$$AddSelfBuffer`, `GodHandBuf$$Initalize`, `GodHandBuf$$SkillEnd`
- Code that reads this skill's level / buff by constant id: `GazerShootAction$$ActionPreparation (TryGetBuf)`, `GodHandAction$$ActionHit (TryGetBuf)`, `MindimageSenjuAttackAction$$ActionHit (TryGetBuf)`, `MobaPlayerActionManager$$ReceiveDamaged (GetSkillLv)`, `MobaPlayerActionManager$$ReceiveDamaged (TryGetBuf)`, `MobaPlayerSecondaryStatus$$get_AntiVirus (TryGetBuf)`, `PlayerActionManager$$Damaged (TryGetBuf)`, `PlayerSecondaryStatus$$CalcAntiVirus (TryGetBuf)`

_Raw recovered data (every method item): [trees/CrusherSkill.md](../trees/CrusherSkill.md) — uid 1158_

---

### ผู้ทำลายล้าง (Destroyer) · uid 1159

<img src="../../icons/sk_1159.png" width="40" alt="icon"> 
**Tree:** クラッシャー (`CrusherSkill`, tier 3) · **Type:** Buffer · **Max Lv:** 170 · **Weapons:** Knuckle · **Requires:** คอมบิเนชั่น · **Flags:** StarGem · **Client class:** `DestroyerAction`

> แก่นแท้แห่งการทำลายล้าง
> เมื่อเรียนรู้สกิลนี้แล้วจะมีผลเป็นพาสซีฟ
> เพิ่มปริมาณการฟื้นฟู HP ของวิธีการหายใจ เมื่อถึง Lv10 จะเพิ่มผลลด MP ที่ใช้กับสกิล
> ถ้าใช้กับสนับมือจะได้ผลลัพธ์ที่ดียิ่งขึ้น

**How it works**

- Buffer skill of the クラッシャー tree (tier 3, max Lv 170); usable with Knuckle.
- It installs a buff on the caster.
- Buffs:
  - `DestroyerBuf`; Lv1 → Lv10: BaseEqAtkUpRate (base weapon ATK %) 5 → 50, Value (generic value (meaning set by the code that reads the buff)) 2 → 25, Stable (stability) -10 → -10
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (9 lookups; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `SkillUtil.CalcCastTime(0, PlayerStatusBase.get_BattleStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 4 call
- `OnInheritance` — state carried over when this action follows another: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1159
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `DestroyerBuf` — `.ctor(Lv, PlayerActionManagerBase.get_PlayerStatus())`
  - when `UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): adds the caster's buff of `new DestroyerBuf` — `AddSelfBuffer(new DestroyerBuf, Id)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): removes the caster's buff of skill 872 (EnchantedBurst) — `RemoveSelfBuffer(872)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): removes the caster's buff of skill 894 — `RemoveSelfBuffer(894)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `SkillUtil.CalcCastTime(0, PlayerStatusBase.get_BattleStatus())`

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `BaseEqAtkUpRate`: base weapon ATK %
- `Stable`: stability
- `Value`: generic value (meaning set by the code that reads the buff)

**In-game level notes**

- Lv16: [ผลลัพธ์ด้านล่างจะใช้ได้กับอาวุธหลักเท่านั้น] *ระหว่างได้รับผลของบัฟ ATK อาวุธจะเพิ่มขึ้น อัตราการลดการป้องกันที่เกิดจาก[เชลเบรค]จะเพิ่มขึ้นแต่ความเสถียรจะลดลง และจะไม่สามารถใช้งานผงะ/ล้มคว่ำ/หมดสติ/ผลักกระเด็นได้

**Where else this skill takes effect**

- Effect applied in `EnchantedBurstAction$$ActionHit` (4 guarded paths):
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
- Effect applied in `EnchantedBurstAction$$AddLocalStack` (6 guarded paths):
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
- Effect applied in `EnchantedSwordAction$$ActionPreparation` (16 guarded paths):
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
- Effect applied in `EquipItemData.WeaponTypeCalculatorBase$$CalcEqAtk` (295 guarded paths):
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
- Effect applied in `GeoImpactAction$$calcPlayerToMobDamage` (4 guarded paths):
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
- Effect applied in `MindimageSenjuAttackAction$$CalcDamageGeoImpact` (8 guarded paths):
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
- Effect applied in `ShellBreakAction$$OnInitialize` (12 guarded paths):
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
- Code that reads this skill's level / buff by constant id: `EnchantedBurstAction$$ActionHit (ContainsBuffer)`, `EnchantedBurstAction$$AddLocalStack (ContainsBuffer)`, `EnchantedSwordAction$$ActionPreparation (ContainsBuffer)`, `EquipItemData.WeaponTypeCalculatorBase$$CalcEqAtk (TryGetBuf)`, `GeoImpactAction$$calcPlayerToMobDamage (ContainsBuffer)`, `GoliathTakeShotAction$$EnemyDamage (ContainsBuffer)`, `MindimageSenjuAttackAction$$CalcDamageGeoImpact (ContainsBuffer)`, `PlayerAttackBase$$CalcCostMp (GetSkillLv)`, `ShellBreakAction$$OnInitialize (TryGetBuf)`

_Raw recovered data (every method item): [trees/CrusherSkill.md](../trees/CrusherSkill.md) — uid 1159_

---

### เทอราบลาสต์ (GeoImpact) · uid 1160

<img src="../../icons/sk_1160.png" width="40" alt="icon"> 
**Tree:** クラッシャー (`CrusherSkill`, tier 4) · **Type:** Attack · **Max Lv:** 250 · **Weapons:** MainKnuckle · **Requires:** ผู้ทำลายล้าง · **Flags:** StarGem · **Client class:** `GeoImpactAction`

> ทักษะการบดขยี้แผ่นดินแล้วใช้หินที่ยกสูงขึ้นเป็นเกราะกำบัง
> สร้างความเสียหายให้กับพื้นที่โดยรอบ
> และสร้างบาเรีย 10 วินาทีตาม HP ที่ใช้ไป(ไม่สามารถบันทึกทับ)
> ถ้าผู้ทำลายล้างใช้งานอยู่และเป้าหมายติด"ลดการป้องกัน"
> จะการันตีคริติคอล

**How it works**

- Attack skill of the クラッシャー tree (tier 4, max Lv 250); usable with MainKnuckle.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on live values (formula below); skill multiplier depends on live values (formula below); flat damage +710 at Lv1 to 800 at Lv10
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Buffs:
  - `GeoImpactBuf`: lasts `10` s
  - `CountBufferBase`
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionPreparation` — before the cast starts: 3 set
- `ActionStart` — when the cast starts: 3 set, 2 call
- `ActionHit` — when the attack connects: 1 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 2 tpl, 1 info
- `MpHeal` — skill-specific method: 1 set
- `OnInheritance` — state carried over when this action follows another: 1 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 710 | 720 | 730 | 740 | 750 | 760 | 770 | 780 | 790 | 800 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((System.Math.Max(baseSTR, baseAGI) + ((Lv * 60) + 900))) * 0.01)`
- SkillRate × `(((System.Math.Max(baseSTR, baseAGI) + ((Lv * 60) + 900))) * 0.01)`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((System.Math.Max(baseSTR, baseAGI) + ((Lv * 60) + 900))) * 0.01)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv * 10) + 700))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1160
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): constructs `GeoImpactBuf` — `.ctor(Lv, ((status.MaxHp - PlayerStatusBase.get_GameStatus().localHp) + breathingMethodHeal), status.MaxHp)`
  - when `!hasBuff(1160) AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 90`
- `ActionStart` (when the cast starts): adds the caster's buff of `new GeoImpactBuf` — `AddSelfBuffer(new GeoImpactBuf, Id)`
  - when `!hasBuff(1160) AND PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ls 90`
- `ActionHit` (when the attack connects): restores MP to the caster — `MpHeal()`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `Count`: stack / hit counter
- `Value`: generic value (meaning set by the code that reads the buff)

**In-game level notes**

- Lv16: หากได้รับบัฟเพิ่มพลังโจมตีของก็อดแฮนด์ จะเพิ่มผลการฟื้นฟู MP เล็กน้อยให้กับ สกิลเทอราบลาสต์เมื่อโจมตีโดนเป้าหมาย

**Where else this skill takes effect**

- Effect applied in `GeoImpactAction$$ActionStart` (3 guarded paths):
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
- Code that reads this skill's level / buff by constant id: `GeoImpactAction$$ActionStart (ContainsBuffer)`

_Raw recovered data (every method item): [trees/CrusherSkill.md](../trees/CrusherSkill.md) — uid 1160_

---

### ร่างแกร่งดุจเทพ (GodRigidBody) · uid 1161

<img src="../../icons/sk_1161.png" width="40" alt="icon"> 
**Tree:** クラッシャー (`CrusherSkill`, tier 4) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** MainKnuckle · **Requires:** ก็อดแฮนด์ · **Flags:** StarGem · **Client class:** `GodRigidBodyMastery` (passive mastery)

> ทำให้หัตถ์แห่งเทพสมบูรณ์พร้อม
> ระหว่างใช้ก็อดแฮนด์อัตราความเสียหายจะลดลง
> และต้านภาวะผิดปกติเพิ่มขึ้น
> นอกจากนี้ทุกครั้งที่ลดสำเร็จ MP จะฟื้นฟูเล็กน้อย(สูงสุด 2 ครั้ง)

**How it works**

- Mastery skill of the クラッシャー tree (tier 4, max Lv 250); usable with MainKnuckle.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): CutDmgRate (damage taken reduction %) 90, Value (generic value) 5 at Lv1 to 50 at Lv10.
- Its effect is applied by client code: `GodHandBuf$$DeathExemption`, `GodHandBuf$$Initalize` (formulas in the last section).
- Other client code reads this skill (3 lookups; see the last section).

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| CutDmgRate | 90 | 90 | 90 | 90 | 90 | 90 | 90 | 90 | 90 | 90 |
| Value | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |


Bonus meanings (inferred from the names):

- `CutDmgRate`: damage taken reduction %
- `Value`: generic value

**In-game level notes**

- Lv16: ถ้าเรียนรู้และมีสถานะร่างแกร่งดุจเทพแล้วใช้[ผู้ทำลายล้าง] การชาร์จ[กลอเรียเทคชอต]จะเพิ่มขึ้นเร็วขึ้น ทุกครั้งที่สร้างความเสียหายด้วยครัชเชอร์

**Where else this skill takes effect**

- Effect applied in `GodHandBuf$$DeathExemption` (3 guarded paths):
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
- Effect applied in `GodHandBuf$$Initalize` (2 guarded paths):
  - when `SkillLv(1161) ge 1`
    - returns `SkillLv(1161)`
    - set `playerStatus` = `status`
    - set `isDeathExemption` = `1`
    - calls `0x165d8dc`
  - when `SkillLv(1161) lt 1`
    - returns `SkillLv(1161)`
    - set `playerStatus` = `status`
    - calls `0x165d8dc`
- Code that reads this skill's level / buff by constant id: `GodHandBuf$$DeathExemption (GetSkillLv)`, `GodHandBuf$$Initalize (GetSkillLv)`, `GoliathTakeShotAction$$EnemyDamage (GetSkillLv)`

_Raw recovered data (every method item): [trees/CrusherSkill.md](../trees/CrusherSkill.md) — uid 1161_

---

### กีย์เซอร์ชู้ต (GazerShoot) · uid 1162

<img src="../../icons/sk_1162.png" width="40" alt="icon"> 
**Tree:** クラッシャー (`CrusherSkill`, tier 4) · **Type:** Attack · **Max Lv:** 250 · **Weapons:** MainKnuckle · **Requires:** ฟลายอิ้งคิก · **Flags:** StarGem · **Client class:** `GazerShootAction`

> การกระโดดเตะที่รวดเร็วและทรงพลังอย่างน่าสะพรึงกลัว
> การแสดงผลของสกิลจะเปลี่ยนตามระยะใกล้/ไกล ถ้าใช้ในระยะไกล
> พลังจะเพิ่มขึ้นและเพิ่มการใช้วิธีการหายใจที่ได้เรียนรู้มา

**How it works**

- Attack skill of the クラッシャー tree (tier 4, max Lv 250); usable with MainKnuckle.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [startTargetDist ge MathUtil.DisplayMeterToDistance(8)]: skill multiplier ×0.5 at Lv1 to 5 at Lv10
  - `calcPlayerToMobDamage` [startTargetDist lt MathUtil.DisplayMeterToDistance(8) & startTargetDist ge MathUtil.DisplayMeterToDistance(8)]: skill multiplier ×0
  - `calcPlayerToMobDamage` [startTargetDist lt MathUtil.DisplayMeterToDistance(8)]: skill multiplier ×0
  - `calcPlayerToMobDamage`: skill multiplier depends on Agi (formula below); flat damage +210 at Lv1 to 300 at Lv10
  - `calcPlayerToMobDamage` [!PlayerAttackBase.IsBlank(this) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1158) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)]: skill multiplier depends on Agi (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Buffs:
  - `BreathingMethodBuf`
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 5 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `OtherPlayerAttackStartReceive` — skill-specific method: 1 set
- `ActionStartOthers` — skill-specific method: 1 set
- `ActionPreparation` — before the cast starts: 2 set
- `ActionStart` — when the cast starts: 1 set
- `ActionHit` — when the attack connects: 2 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 4 set, 4 tpl, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [startTargetDist ge MathUtil.DisplayMeterToDistance(8)] | 0.5 | 1 | 1.5 | 2 | 2.5 | 3 | 3.5 | 4 | 4.5 | 5 |
| SkillRate × [startTargetDist lt MathUtil.DisplayMeterToDistance(8) & startTargetDist ge MathUtil.DisplayMeterToDistance(8)] | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 |
| SkillRate × [startTargetDist lt MathUtil.DisplayMeterToDistance(8)] | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 |
| Flat dmg + | 210 | 220 | 230 | 240 | 250 | 260 | 270 | 280 | 290 | 300 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv * 10) + 900) + ((status.Agi lt 0 ? (status.Agi + 1) : status.Agi) >> 1))) / 100)`
- SkillRate × `(((((Lv * 10) + 900) + ((status.Agi lt 0 ? (status.Agi + 1) : status.Agi) >> 1))) / 100)` — !PlayerAttackBase.IsBlank(this) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1158) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv * 10) + 900) + ((status.Agi lt 0 ? (status.Agi + 1) : status.Agi) >> 1))) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((Lv * 50)) / 100)`
  - when `startTargetDist ge MathUtil.DisplayMeterToDistance(8)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv * 10) + 200))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `0`
  - when `startTargetDist lt MathUtil.DisplayMeterToDistance(8)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1162
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `BreathingMethodBuf` — `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1154, 1))`
  - when `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1154, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND longBonus ne 0`
- `ActionHit` (when the attack connects): adds the caster's buff of `new BreathingMethodBuf` — `AddSelfBuffer(new BreathingMethodBuf, Id)`
  - when `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1154, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND longBonus ne 0`

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `Value`: generic value (meaning set by the code that reads the buff)

_Raw recovered data (every method item): [trees/CrusherSkill.md](../trees/CrusherSkill.md) — uid 1162_

---
