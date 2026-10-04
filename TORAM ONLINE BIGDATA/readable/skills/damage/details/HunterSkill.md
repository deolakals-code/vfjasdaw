# ハンタースキル (`HunterSkill`) — skill details

17 entries.

### แตะ (KickBack) · uid 545

<img src="../../icons/sk_545.png" width="40" alt="icon"> 
**Tree:** ハンタースキル (`HunterSkill`, tier 1) · **Type:** Attack · **Max Lv:** 15 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `KickBackAction`

> เตะศัตรูให้กระเด็นห่างออกไป
> สร้างความเสียหายให้เป้าหมายและผลักกระเด็นออกไป

**How it works**

- Attack skill of the ハンタースキル tree (tier 1, max Lv 15); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on live values (formula below); flat damage +10 at Lv1 to 100 at Lv10
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: KnockBack (4).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(3)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 6 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 1 call, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv * 10) + (Lv hi 5 ? ((Lv * 10) - 50) : 0)) + ((baseSTR lt 0 ? (baseSTR + 1) : baseSTR) >> 1)) / 100))`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv * 10) + (Lv hi 5 ? ((Lv * 10) - 50) : 0)) + ((baseSTR lt 0 ? (baseSTR + 1) : baseSTR) >> 1)) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv + (Lv << 2)) << 1))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 545
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Chance field `knockBackPercent` (ailment chance): `(Lv + 90)` → Lv1..10 [91, 92, 93, 94, 95, 96, 97, 98, 99, 100]
- Rolls `knockBackPercent`% to inflict **KnockBack (4)** (`calcPlayerToMobDamage`)

_Raw recovered data (every method item): [trees/HunterSkill.md](../trees/HunterSkill.md) — uid 545_

---

### กับดักนิทรา (SleepTrap) · uid 549

<img src="../../icons/sk_549.png" width="40" alt="icon"> 
**Tree:** ハンタースキル (`HunterSkill`, tier 1) · **Type:** Object · **Max Lv:** 15 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem · **Client class:** `SleepTrapAction`

> วางกับดักที่มีแก๊สยาสลบ
> มีโอกาสทำให้เป้าหมาย[หลับ]เมื่อเหยียบโดน
> ไม่สามารถติดตั้งที่เท้าได้โดยตรง
> มีโอกาสถูกทำลายด้วยการโจมตีในวงกว้าง

**How it works**

- Object skill of the ハンタースキル tree (tier 1, max Lv 15); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- It places an object in the world (trap, summon or field object).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [(0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0]: skill multiplier ×0.01 at Lv1 to 0.1 at Lv10
  - `calcPlayerToMobDamage` [(0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage`: flat damage +55 at Lv1 to 100 at Lv10
- Proration: magic proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Sleep (20).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(100)`
- **Effect radius (Unity units)** (`Radius`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance(((Lv hi 5 ? 1 : 0.5) + 1))`
  - when `(0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0`
- **Effect radius (Unity units)** (`Radius`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance((Lv hi 5 ? 1 : 0.5))`
  - when `(0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 13 set
- `InitializeOthers` — setup used when another player's client replays the action: 5 set
- `ActionStartOthers` — skill-specific method: 1 set
- `ActionStart` — when the cast starts: 3 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 2 call, 1 info
- `ActionHit` — when the attack connects: 1 set, 2 call
- `AddSelfAbnormal` — skill-specific method: 1 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.01 | 0.02 | 0.03 | 0.04 | 0.05 | 0.06 | 0.07 | 0.08 | 0.09 | 0.1 |
| Flat dmg + | 55 | 60 | 65 | 70 | 75 | 80 | 85 | 90 | 95 | 100 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((Lv + ((baseDEX lt 0 ? (baseDEX + 1) : baseDEX) >> 1)) / 100))` — (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((Lv + ((baseDEX lt 0 ? (baseDEX + 1) : baseDEX) >> 1)) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv + (Lv << 2)) + 50))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 549, spawns `MobAttackPlayerSelfDestruct`
- Uses the magic proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `1` = 1
  - when `SleepTrapAction.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), MobActionManagerBase.get_transform(?stack), MobActionManagerBase.get_Size(?stack)) AND UnityEngine.Object.op_Inequality(actarAction) AND failTrapper ne 0`

**Status ailments**

- Chance field `abnormalPercent` (Chance to inflict the skill's status ailment (%)): `(((int(((Lv * 0.25) + 5.5)) + (int(((Lv * 0.25) + 5.5)) << 2)) << 1) + 20)` → Lv1..10 [70, 80, 80, 80, 80, 90, 90, 90, 90, 100]
  - when `(0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0`
- Chance field `abnormalPercent` (Chance to inflict the skill's status ailment (%)): `((int(((Lv * 0.25) + 5.5)) + (int(((Lv * 0.25) + 5.5)) << 2)) << 1)` → Lv1..10 [50, 60, 60, 60, 60, 70, 70, 70, 70, 80]
  - when `(0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0`
- Rolls `abnormalPercent`% to inflict **Sleep (20)** (`calcPlayerToMobDamage`)
  - when `!PlayerAttackBase.checkAbnormalPercent(this, 20, abnormalPercent, playerAction) OR MobActionManagerBase.get_IsBoss(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 20, abnormalPercent, playerAction) OR !MobActionManagerBase.get_IsBoss(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 20, abnormalPercent, playerAction)`
- Marks the hit with ailment **Sleep (20)** (`calcPlayerToMobDamage`)
  - when `MobActionManagerBase.get_IsBoss(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 20, abnormalPercent, playerAction) OR !MobActionManagerBase.get_IsBoss(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 20, abnormalPercent, playerAction)`
- Uses the default ailment duration (`AddSelfAbnormal`)
  - when `!UnityEngine.Object.op_Equality(actarAction) AND SkillActionBase.checkPercent(this, 100, abnormalPercent) AND selfDamage ne 0`

**Other recovered parameters**

- **Effect radius (Unity units)** (`Radius`): `MathUtil.DisplayMeterToDistance(((Lv hi 5 ? 1 : 0.5) + 1))` _(when (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0)_; `MathUtil.DisplayMeterToDistance((Lv hi 5 ? 1 : 0.5))` _(when (0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0)_
- **Loop / hit-repeat count** (`LoopParam`): `1` = 1 _(when SleepTrapAction.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), MobActionManagerBase.get_transform(?stack), MobActionManagerBase.get_Size(?stack)) AND UnityEngine.Object.op_Inequality(actarAction) AND failTrapper ne 0)_

**In-game level notes**

- Lv19: *DEX มีผลต่อพลัง *ระยะโจมตี (รัศมี)+1m *อัตราติดหลับ+20% *ฟื้นฟู MP เมื่อวางกับดัก+100

_Raw recovered data (every method item): [trees/HunterSkill.md](../trees/HunterSkill.md) — uid 549_

---

### โฮมมิ่งช็อต (HomingShot) · uid 554

<img src="../../icons/sk_554.png" width="40" alt="icon"> 
**Tree:** ハンタースキル (`HunterSkill`, tier 1) · **Type:** Object · **Max Lv:** 15 · **Weapons:** Bow, Bowgun · **Flags:** StarGem · **Client class:** `HomingShotAction`

> ยิงลูกธนูเวทมนตร์ติดตามที่แฝงการคุกคาม
> สกิลนี้โจมตีด้วย 'ความเคยชินทั่วไป'
> ยิ่งเลเวลสูงขึ้นเท่าไหร่จำนวนที่ยิงก็จะยิ่งเพิ่มมากขึ้น
> ฟื้นฟู MP เล็กน้อยเมื่อโจมตีโดนเป้าหมาย 

**How it works**

- Object skill of the ハンタースキル tree (tier 1, max Lv 15); usable with Bow, Bowgun.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It places an object in the world (trap, summon or field object).
- Damage (`calcPlayerToMobDamage` x3; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [1 hs arrowNum AND PlayerAttackBase.ExistWeaponType(playerAction, 19) AND arrowNum ne 0 OR !PlayerAttackBase.ExistWeaponType(playerAction, 19) AND 1 hs arrowNum AND arrowNum ne 0 AND isBowgunHunter ne 0 OR !PlayerAttackBase.ExistWeaponType(playerAction, 19) AND 1 hs arrowNum AND arrowNum ne 0 AND isBowgunHunter eq 0]: skill multiplier ×0.1 at Lv1 to 1 at Lv10
  - `calcPlayerToMobDamage` [(System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Arrow & 1) ne 0 AND mainWeapon == Bowgun OR (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Arrow & 1) ne 0 AND (mainWeapon==Bowgun & 1) ne 0 AND mainWeapon == Bowgun OR (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Arrow & 1) ne 0 AND (mainWeapon==Bowgun & 1) eq 0 AND mainWeapon == Bowgun & 1 hs arrowNum AND PlayerAttackBase.ExistWeaponType(playerAction, 19) AND arrowNum ne 0 OR !PlayerAttackBase.ExistWeaponType(playerAction, 19) AND 1 hs arrowNum AND arrowNum ne 0 AND isBowgunHunter ne 0 OR !PlayerAttackBase.ExistWeaponType(playerAction, 19) AND 1 hs arrowNum AND arrowNum ne 0 AND isBowgunHunter eq 0]: flat damage +200
  - `calcPlayerToMobDamage` [(System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Arrow & 1) eq 0 AND isBowgunHunter eq 0 AND mainWeapon == Bowgun OR (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Arrow & 1) eq 0 AND (mainWeapon==Bowgun & 1) ne 0 AND (subWeapon != Null ? 1 : 0) eq 0 AND mainWeapon == Bowgun OR (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Arrow & 1) eq 0 AND (mainWeapon==Bowgun & 1) eq 0 AND isBowgunHunter eq 0 AND mainWeapon == Bowgun & 1 hs arrowNum AND PlayerAttackBase.ExistWeaponType(playerAction, 19) AND arrowNum ne 0 OR !PlayerAttackBase.ExistWeaponType(playerAction, 19) AND 1 hs arrowNum AND arrowNum ne 0 AND isBowgunHunter ne 0 OR !PlayerAttackBase.ExistWeaponType(playerAction, 19) AND 1 hs arrowNum AND arrowNum ne 0 AND isBowgunHunter eq 0]: flat damage +0
- Proration: normal-attack proration slot, mode `every_hit + class check`.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(16)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 8 set
- `InitializeOthers` — setup used when another player's client replays the action: 3 set
- `ActionStart` — when the cast starts: 1 set
- `ActionStartOthers` — skill-specific method: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 3 info
- `ActionSkillEventIfMoveIndex` — skill-specific method: 1 set
- `ExpDefFluctuated` — skill-specific method: 1 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.1 | 0.2 | 0.3 | 0.4 | 0.5 | 0.6 | 0.7 | 0.8 | 0.9 | 1 |
| Flat dmg + [(System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Arrow & 1) ne 0 AND mainWeapon == Bowgun OR (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Arrow & 1) ne 0 AND (mainWeapon==Bowgun & 1) ne 0 AND mainWeapon == Bowgun OR (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Arrow & 1) ne 0 AND (mainWeapon==Bowgun & 1) eq 0 AND mainWeapon == Bowgun & 1 hs arrowNum AND PlayerAttackBase.ExistWeaponType(playerAction, 19) AND arrowNum ne 0 OR !PlayerAttackBase.ExistWeaponType(playerAction, 19) AND 1 hs arrowNum AND arrowNum ne 0 AND isBowgunHunter ne 0 OR !PlayerAttackBase.ExistWeaponType(playerAction, 19) AND 1 hs arrowNum AND arrowNum ne 0 AND isBowgunHunter eq 0] | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 |
| Flat dmg + [(System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Arrow & 1) eq 0 AND isBowgunHunter eq 0 AND mainWeapon == Bowgun OR (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Arrow & 1) eq 0 AND (mainWeapon==Bowgun & 1) ne 0 AND (subWeapon != Null ? 1 : 0) eq 0 AND mainWeapon == Bowgun OR (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Arrow & 1) eq 0 AND (mainWeapon==Bowgun & 1) eq 0 AND isBowgunHunter eq 0 AND mainWeapon == Bowgun & 1 hs arrowNum AND PlayerAttackBase.ExistWeaponType(playerAction, 19) AND arrowNum ne 0 OR !PlayerAttackBase.ExistWeaponType(playerAction, 19) AND 1 hs arrowNum AND arrowNum ne 0 AND isBowgunHunter ne 0 OR !PlayerAttackBase.ExistWeaponType(playerAction, 19) AND 1 hs arrowNum AND arrowNum ne 0 AND isBowgunHunter eq 0] | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 |

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv + (Lv << 2)) << 1)) / 100)`
  - when `1 hs arrowNum AND PlayerAttackBase.ExistWeaponType(playerAction, 19) AND arrowNum ne 0 OR !PlayerAttackBase.ExistWeaponType(playerAction, 19) AND 1 hs arrowNum AND arrowNum ne 0 AND isBowgunHunter ne 0 OR !PlayerAttackBase.ExistWeaponType(playerAction, 19) AND 1 hs arrowNum AND arrowNum ne 0 AND isBowgunHunter eq 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(200)`
  - when `1 hs arrowNum AND PlayerAttackBase.ExistWeaponType(playerAction, 19) AND arrowNum ne 0 OR !PlayerAttackBase.ExistWeaponType(playerAction, 19) AND 1 hs arrowNum AND arrowNum ne 0 AND isBowgunHunter ne 0 OR !PlayerAttackBase.ExistWeaponType(playerAction, 19) AND 1 hs arrowNum AND arrowNum ne 0 AND isBowgunHunter eq 0`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Normal`, mode `every_hit + class check`, attack type `SkillNormal`, action id 554
- Uses the normal-attack proration slot; Proration changes on EVERY damaging hit (bypasses the first-hit gate).

**Status ailments**

- Chance field `hitPercent` (ailment chance): `(Lv * Lv)` → Lv1..10 [1, 4, 9, 16, 25, 36, 49, 64, 81, 100]

**In-game level notes**

- Lv19: *พลังสกิล+200 *ฟื้นฟู MP 2 เท่า *เจาะทะลุ Avoid (ยกเว้น Avoid พิเศษ เช่น ในอีเว้นท์หรือกลไกต่างๆ)

_Raw recovered data (every method item): [trees/HunterSkill.md](../trees/HunterSkill.md) — uid 554_

---

### ซันไรส์แอร์โรว์ (SunriseArrow) · uid 546

<img src="../../icons/sk_546.png" width="40" alt="icon"> 
**Tree:** ハンタースキル (`HunterSkill`, tier 2) · **Type:** Attack · **Max Lv:** 35 · **Weapons:** Bow, Bowgun · **Requires:** แตะ · **Flags:** MercenaryCanUseSkill · **Client class:** `SunriseArrowAction`

> ยิงด้วยพลังสุริยะ
> โจมตีสร้างความเสียหายให้เป้าหมายโดยตรง
> ถ้าเป้าหมายหลับอยู่พลังโจมตีจะเพิ่มเป็น 2 เท่า

**How it works**

- Attack skill of the ハンタースキル tree (tier 2, max Lv 35); usable with Bow, Bowgun.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [(0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0]: skill multiplier ×1.1 at Lv1 to 2 at Lv10
  - `calcPlayerToMobDamage` [(0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0]: skill multiplier depends on Dex (formula below)
  - `calcPlayerToMobDamage`: flat damage +182 at Lv1 to 200 at Lv10
- Proration: physical-skill proration slot, mode `first_hit_per_target`.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(14)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 5 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionStart` — when the cast starts: 8 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 1.1 | 1.2 | 1.3 | 1.4 | 1.5 | 1.6 | 1.7 | 1.8 | 1.9 | 2 |
| Flat dmg + | 182 | 184 | 186 | 188 | 190 | 192 | 194 | 196 | 198 | 200 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv * 10) + 100) + status.Dex) / 100))` — (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv * 10) + 100) + status.Dex) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv << 1) + 180))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 546
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**In-game level notes**

- Lv19: *พลังจะเพิ่มมากกว่าค่า DEX ของตัวเอง *ระยะโจมตี (แนวนอน)+1m

_Raw recovered data (every method item): [trees/HunterSkill.md](../trees/HunterSkill.md) — uid 546_

---

### กับดักล่าสัตว์ (SteelTrap) · uid 550

<img src="../../icons/sk_550.png" width="40" alt="icon"> 
**Tree:** ハンタースキル (`HunterSkill`, tier 2) · **Type:** Object · **Max Lv:** 35 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** กับดักนิทรา · **Client class:** `SteelTrapAction`

> ติดตั้งกับดักสัตว์ มีโอกาสทำให้เป้าหมาย[หยุดนิ่ง]เมื่อเหยียบโดน
> ไม่สามารถติดตั้งที่เท้าได้โดยตรง
> มีโอกาสถูกทำลายด้วยการโจมตีในวงกว้าง

**How it works**

- Object skill of the ハンタースキル tree (tier 2, max Lv 35); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- It places an object in the world (trap, summon or field object).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [(0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0]: skill multiplier ×0.01 at Lv1 to 0.1 at Lv10
  - `calcPlayerToMobDamage` [(0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage`: flat damage +55 at Lv1 to 100 at Lv10
- Proration: magic proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Stop (12).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(100)`
- **Effect radius (Unity units)** (`Radius`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance(((Lv hi 5 ? 1 : 0.5) + 1))`
  - when `(0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0`
- **Effect radius (Unity units)** (`Radius`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance((Lv hi 5 ? 1 : 0.5))`
  - when `(0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 13 set
- `InitializeOthers` — setup used when another player's client replays the action: 5 set
- `ActionStartOthers` — skill-specific method: 1 set
- `ActionStart` — when the cast starts: 3 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 2 call, 1 info
- `ActionHit` — when the attack connects: 3 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.01 | 0.02 | 0.03 | 0.04 | 0.05 | 0.06 | 0.07 | 0.08 | 0.09 | 0.1 |
| Flat dmg + | 55 | 60 | 65 | 70 | 75 | 80 | 85 | 90 | 95 | 100 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((Lv + ((baseDEX lt 0 ? (baseDEX + 1) : baseDEX) >> 1)) / 100))` — (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((Lv + ((baseDEX lt 0 ? (baseDEX + 1) : baseDEX) >> 1)) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv + (Lv << 2)) + 50))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 550, spawns `MobAttackPlayerSelfDestruct`
- Uses the magic proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `1` = 1
  - when `SteelTrapAction.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), MobActionManagerBase.get_transform(?stack), MobActionManagerBase.get_Size(?stack)) AND UnityEngine.Object.op_Inequality(actarAction) AND failTrapper ne 0`

**Status ailments**

- Chance field `abnormalPercent` (Chance to inflict the skill's status ailment (%)): `(((int(((Lv * 0.25) + 5.5)) + (int(((Lv * 0.25) + 5.5)) << 2)) << 1) + 20)` → Lv1..10 [70, 80, 80, 80, 80, 90, 90, 90, 90, 100]
  - when `(0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0`
- Chance field `abnormalPercent` (Chance to inflict the skill's status ailment (%)): `((int(((Lv * 0.25) + 5.5)) + (int(((Lv * 0.25) + 5.5)) << 2)) << 1)` → Lv1..10 [50, 60, 60, 60, 60, 70, 70, 70, 70, 80]
  - when `(0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0`
- Rolls `abnormalPercent`% to inflict **Stop (12)** (`calcPlayerToMobDamage`)
- Marks the hit with ailment **Stop (12)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 12, abnormalPercent, playerAction)`
- Marks the hit with ailment **Stop (12)** (`ActionHit`)
  - when `!UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND !UnityEngine.Object.op_Equality(actarAction) AND PlayerStatusBase.get_IsLocalDead() AND SkillActionBase.checkPercent(this, 100, abnormalPercent) AND fastHit ne 0 OR !PlayerStatusBase.get_IsLocalDead() AND !UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND !UnityEngine.Object.op_Equality(actarAction) AND SkillActionBase.checkPercent(this, 100, abnormalPercent) AND fastHit ne 0 OR !UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND !UnityEngine.Object.op_Equality(actarAction) AND PlayerStatusBase.get_IsLocalDead() AND SkillActionBase.checkPercent(this, 100, abnormalPercent) AND TryGetProperties<object>.out2(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 10) ne 0 AND fastHit ne 0`

**Other recovered parameters**

- **Effect radius (Unity units)** (`Radius`): `MathUtil.DisplayMeterToDistance(((Lv hi 5 ? 1 : 0.5) + 1))` _(when (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0)_; `MathUtil.DisplayMeterToDistance((Lv hi 5 ? 1 : 0.5))` _(when (0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0)_
- **Loop / hit-repeat count** (`LoopParam`): `1` = 1 _(when SteelTrapAction.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), MobActionManagerBase.get_transform(?stack), MobActionManagerBase.get_Size(?stack)) AND UnityEngine.Object.op_Inequality(actarAction) AND failTrapper ne 0)_

**In-game level notes**

- Lv19: *DEX มีผลต่อพลัง *ระยะโจมตี (รัศมี)+1m *อัตราติดหยุดนิ่ง+20% *ฟื้นฟู MP เมื่อวางกับดัก+100

_Raw recovered data (every method item): [trees/HunterSkill.md](../trees/HunterSkill.md) — uid 550_

---

### ดีเทคชั่น (Detection) · uid 553

<img src="../../icons/sk_553.png" width="40" alt="icon"> 
**Tree:** ハンタースキル (`HunterSkill`, tier 2) · **Type:** Buffer · **Max Lv:** 35 · **Weapons:** Bow, Bowgun · **Requires:** โฮมมิ่งช็อต · **Client class:** `DetectionAction`

> ความสามารถในการรับรู้ถึงอันตรายในธรรมชาติ
> ลดเฮทของตัวเองและ
> เพิ่มอัตราคริติคอลเล็กน้อย 40 วินาที
> เอฟเฟกต์จะสิ้นสุดลงเมื่อตกเป็นเป้าหมาย

**How it works**

- Buffer skill of the ハンタースキル tree (tier 2, max Lv 35); usable with Bow, Bowgun.
- It installs a buff on the caster.
- Buffs:
  - `DetectionBuf`: lasts `40` s; Lv1 → Lv10: CrtUp (critical rate +) 1 → 10
- Other client code reads this skill (7 lookups; see the last section).

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 1 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 1 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 553
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): adds the caster's buff of skill 553 (Detection) — `AddSelfBuffer(553, Lv, 0)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Buff values** (every recovered field; durations in seconds)

**Buff `DetectionBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `GetHateBonus`
- Duration: `40` s

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| CrtUp | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |

- Buff fields set in the constructor (all recovered):
  - `critical` = `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `hateRate` = `(0xfffffff6 - lv)` → Lv1..10 [-11, -12, -13, -14, -15, -16, -17, -18, -19, -20]
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0

Parameter meanings (inferred from the `SkillBufferId` names):

- `CrtUp`: critical rate +

**In-game level notes**

- Lv12: [จะได้รับเอฟเฟกต์แบบเดียวกันถ้าใช้กับโบว์กัน] *เมื่อเอฟเฟกต์สิ้นสุดลงด้วยการตกเป็นเป้าหมาย จะใช้สกิลยิง "เดคอยชูตเตอร์" โดยอัตโนมัติ

**Where else this skill takes effect**

- Effect applied in `MobaPlayerSecondaryStatus$$GetCrtConstant` (298 guarded paths, truncated):
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3))))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3)))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3)))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3)))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3)))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
- Effect applied in `EnemyMobActionManagerBase$$InitManagedMob` (21 guarded paths):
  - always
    - returns `SongOfLifeAction.ChangeHate(UnityEngine.GameObject.GetComponent<object>(Target, meta(0x398c090, Method$UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>()), ?x2, ?x3), 0, ?x2, ?x3)`
    - set `mobStatus` = `0x165db78(meta(0x399ace0, MobStatus_TypeInfo), ?x1, ?x2, ?x3)`
    - set `battlePlayer` = `UnityEngine.GameObject.AddComponent<object>(UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), meta(0x399b140, Method$UnityEngine.GameObject.AddComponent<MobBattlePlayer>()), ?x2, ?x3)`
    - set `localIsFeigningDeathState` = `?ubfx`
    - set `battleSystemManager` = `UnityEngine.GameObject.AddComponent<object>(UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), meta(0x399b148, Method$UnityEngine.GameObject.AddComponent<MobBattleSystemManager>()), ?x2, ?x3)`
    - set `IsAttackable` = `1`
    - calls `0x165db78`, `MobStatus$$.ctor`, `0x165d8dc`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsMmo`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`
  - always
    - returns `SongOfLifeAction.ChangeHate(UnityEngine.GameObject.GetComponent<object>(Target, meta(0x398c090, Method$UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>()), ?x2, ?x3), 0, ?x2, ?x3)`
    - set `mobStatus` = `0x165db78(meta(0x399ace0, MobStatus_TypeInfo), ?x1, ?x2, ?x3)`
    - set `battlePlayer` = `UnityEngine.GameObject.AddComponent<object>(UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), meta(0x399b140, Method$UnityEngine.GameObject.AddComponent<MobBattlePlayer>()), ?x2, ?x3)`
    - set `localIsFeigningDeathState` = `?ubfx`
    - set `battleSystemManager` = `UnityEngine.GameObject.AddComponent<object>(UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), meta(0x399b148, Method$UnityEngine.GameObject.AddComponent<MobBattleSystemManager>()), ?x2, ?x3)`
    - set `IsAttackable` = `1`
    - calls `0x165db78`, `MobStatus$$.ctor`, `0x165d8dc`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsMmo`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`
  - always
    - returns `SongOfLifeAction.ChangeHate(UnityEngine.GameObject.GetComponent<object>(Target, meta(0x398c090, Method$UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>()), ?x2, ?x3), 0, ?x2, ?x3)`
    - set `mobStatus` = `0x165db78(meta(0x399ace0, MobStatus_TypeInfo), ?x1, ?x2, ?x3)`
    - set `battlePlayer` = `UnityEngine.GameObject.AddComponent<object>(UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), meta(0x399b140, Method$UnityEngine.GameObject.AddComponent<MobBattlePlayer>()), ?x2, ?x3)`
    - set `localIsFeigningDeathState` = `?ubfx`
    - set `battleSystemManager` = `UnityEngine.GameObject.AddComponent<object>(UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), meta(0x399b148, Method$UnityEngine.GameObject.AddComponent<MobBattleSystemManager>()), ?x2, ?x3)`
    - set `IsAttackable` = `1`
    - calls `0x165db78`, `MobStatus$$.ctor`, `0x165d8dc`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsMmo`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`
  - always
    - returns `SongOfLifeAction.ChangeHate(UnityEngine.GameObject.GetComponent<object>(Target, meta(0x398c090, Method$UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>()), ?x2, ?x3), 0, ?x2, ?x3)`
    - set `mobStatus` = `0x165db78(meta(0x399ace0, MobStatus_TypeInfo), ?x1, ?x2, ?x3)`
    - set `battlePlayer` = `UnityEngine.GameObject.AddComponent<object>(UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), meta(0x399b140, Method$UnityEngine.GameObject.AddComponent<MobBattlePlayer>()), ?x2, ?x3)`
    - set `localIsFeigningDeathState` = `?ubfx`
    - set `battleSystemManager` = `UnityEngine.GameObject.AddComponent<object>(UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), meta(0x399b148, Method$UnityEngine.GameObject.AddComponent<MobBattleSystemManager>()), ?x2, ?x3)`
    - set `IsAttackable` = `1`
    - calls `0x165db78`, `MobStatus$$.ctor`, `0x165d8dc`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsMmo`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`
  - always
    - returns `SongOfLifeAction.ChangeHate(UnityEngine.GameObject.GetComponent<object>(Target, meta(0x398c090, Method$UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>()), ?x2, ?x3), 0, ?x2, ?x3)`
    - set `mobStatus` = `0x165db78(meta(0x399ace0, MobStatus_TypeInfo), ?x1, ?x2, ?x3)`
    - set `battlePlayer` = `UnityEngine.GameObject.AddComponent<object>(UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), meta(0x399b140, Method$UnityEngine.GameObject.AddComponent<MobBattlePlayer>()), ?x2, ?x3)`
    - set `localIsFeigningDeathState` = `?ubfx`
    - set `battleSystemManager` = `UnityEngine.GameObject.AddComponent<object>(UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), meta(0x399b148, Method$UnityEngine.GameObject.AddComponent<MobBattleSystemManager>()), ?x2, ?x3)`
    - set `IsAttackable` = `1`
    - calls `0x165db78`, `MobStatus$$.ctor`, `0x165d8dc`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsMmo`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`
  - always
    - returns `SongOfLifeAction.ChangeHate(UnityEngine.GameObject.GetComponent<object>(Target, meta(0x398c090, Method$UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>()), ?x2, ?x3), 0, ?x2, ?x3)`
    - set `mobStatus` = `0x165db78(meta(0x399ace0, MobStatus_TypeInfo), ?x1, ?x2, ?x3)`
    - set `battlePlayer` = `UnityEngine.GameObject.AddComponent<object>(UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), meta(0x399b140, Method$UnityEngine.GameObject.AddComponent<MobBattlePlayer>()), ?x2, ?x3)`
    - set `localIsFeigningDeathState` = `?ubfx`
    - set `battleSystemManager` = `UnityEngine.GameObject.AddComponent<object>(UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), meta(0x399b148, Method$UnityEngine.GameObject.AddComponent<MobBattleSystemManager>()), ?x2, ?x3)`
    - set `IsAttackable` = `1`
    - calls `0x165db78`, `MobStatus$$.ctor`, `0x165d8dc`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsMmo`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`
  - always
    - returns `SongOfLifeAction.ChangeHate(UnityEngine.GameObject.GetComponent<object>(Target, meta(0x398c090, Method$UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>()), ?x2, ?x3), 0, ?x2, ?x3)`
    - set `mobStatus` = `0x165db78(meta(0x399ace0, MobStatus_TypeInfo), ?x1, ?x2, ?x3)`
    - set `battlePlayer` = `UnityEngine.GameObject.AddComponent<object>(UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), meta(0x399b140, Method$UnityEngine.GameObject.AddComponent<MobBattlePlayer>()), ?x2, ?x3)`
    - set `localIsFeigningDeathState` = `?ubfx`
    - set `battleSystemManager` = `UnityEngine.GameObject.AddComponent<object>(UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), meta(0x399b148, Method$UnityEngine.GameObject.AddComponent<MobBattleSystemManager>()), ?x2, ?x3)`
    - set `IsAttackable` = `1`
    - calls `0x165db78`, `MobStatus$$.ctor`, `0x165d8dc`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsMmo`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`
  - always
    - returns `SongOfLifeAction.ChangeHate(UnityEngine.GameObject.GetComponent<object>(Target, meta(0x398c090, Method$UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>()), ?x2, ?x3), 0, ?x2, ?x3)`
    - set `mobStatus` = `0x165db78(meta(0x399ace0, MobStatus_TypeInfo), ?x1, ?x2, ?x3)`
    - set `battlePlayer` = `UnityEngine.GameObject.AddComponent<object>(UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), meta(0x399b140, Method$UnityEngine.GameObject.AddComponent<MobBattlePlayer>()), ?x2, ?x3)`
    - set `localIsFeigningDeathState` = `?ubfx`
    - set `battleSystemManager` = `UnityEngine.GameObject.AddComponent<object>(UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), meta(0x399b148, Method$UnityEngine.GameObject.AddComponent<MobBattleSystemManager>()), ?x2, ?x3)`
    - set `IsAttackable` = `1`
    - calls `0x165db78`, `MobStatus$$.ctor`, `0x165d8dc`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsMmo`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`
- Effect applied in `PlayerSecondaryStatus$$GetCrtConstant` (298 guarded paths, truncated):
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3))))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3)))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3)))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3)))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3)))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
- Effect applied in `PlayerSecondaryStatus$$GetDisplayBonusCalcHate` (297 guarded paths, truncated):
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
- Effect applied in `PhotonListener$$OnActionRoomChangeHateMine` (298 guarded paths, truncated):
  - always
    - calls `Debug$$Log`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$GetEnemyHateState`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - returns `System.Collections.Generic.Dictionary<object, Int32Enum>.get_Item(0x165db78(meta(0x39b5838, System.Collections.Generic.Dictionary<IMobIdData, EnemyMobActionManagerBase.HateState>_TypeInfo), ?x1, ?x2, ?x3), ?idx, meta(0x39b5830, Method$System.Collections.Generic.Dictionary<IMobIdData, EnemyMobActionManagerBase.HateState>.get_Item()), ?x3)`
    - calls `Debug$$Log`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$GetEnemyHateState`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - calls `Debug$$Log`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$GetEnemyHateState`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - returns `System.Collections.Generic.Dictionary<object, Int32Enum>.get_Item(0x165db78(meta(0x39b5838, System.Collections.Generic.Dictionary<IMobIdData, EnemyMobActionManagerBase.HateState>_TypeInfo), ?x1, ?x2, ?x3), ?idx, meta(0x39b5830, Method$System.Collections.Generic.Dictionary<IMobIdData, EnemyMobActionManagerBase.HateState>.get_Item()), ?x3)`
    - calls `Debug$$Log`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$GetEnemyHateState`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - calls `Debug$$Log`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$GetEnemyHateState`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - returns `System.Collections.Generic.Dictionary<object, Int32Enum>.get_Item(0x165db78(meta(0x39b5838, System.Collections.Generic.Dictionary<IMobIdData, EnemyMobActionManagerBase.HateState>_TypeInfo), ?x1, ?x2, ?x3), ?idx, meta(0x39b5830, Method$System.Collections.Generic.Dictionary<IMobIdData, EnemyMobActionManagerBase.HateState>.get_Item()), ?x3)`
    - calls `Debug$$Log`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$GetEnemyHateState`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - calls `Debug$$Log`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$GetEnemyHateState`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - calls `Debug$$Log`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$GetEnemyHateState`, `TargetableListManagerBase<object>$$get_Instance`
- Effect applied in `PhotonListener$$OnActionPartyChangeHateMine` (298 guarded paths, truncated):
  - always
    - calls `Debug$$Log`, `Singleton<object>$$get_Instance`, `PartyManager$$get_IsParty`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - returns `System.Collections.Generic.Dictionary<object, Int32Enum>.get_Item(0x165db78(meta(0x39b5838, System.Collections.Generic.Dictionary<IMobIdData, EnemyMobActionManagerBase.HateState>_TypeInfo), ?x1, ?x2, ?x3), ?idx, meta(0x39b5830, Method$System.Collections.Generic.Dictionary<IMobIdData, EnemyMobActionManagerBase.HateState>.get_Item()), ?x3)`
    - calls `Debug$$Log`, `Singleton<object>$$get_Instance`, `PartyManager$$get_IsParty`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - calls `Debug$$Log`, `Singleton<object>$$get_Instance`, `PartyManager$$get_IsParty`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - returns `System.Collections.Generic.Dictionary<object, Int32Enum>.get_Item(0x165db78(meta(0x39b5838, System.Collections.Generic.Dictionary<IMobIdData, EnemyMobActionManagerBase.HateState>_TypeInfo), ?x1, ?x2, ?x3), ?idx, meta(0x39b5830, Method$System.Collections.Generic.Dictionary<IMobIdData, EnemyMobActionManagerBase.HateState>.get_Item()), ?x3)`
    - calls `Debug$$Log`, `Singleton<object>$$get_Instance`, `PartyManager$$get_IsParty`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - calls `Debug$$Log`, `Singleton<object>$$get_Instance`, `PartyManager$$get_IsParty`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - returns `System.Collections.Generic.Dictionary<object, Int32Enum>.get_Item(0x165db78(meta(0x39b5838, System.Collections.Generic.Dictionary<IMobIdData, EnemyMobActionManagerBase.HateState>_TypeInfo), ?x1, ?x2, ?x3), ?idx, meta(0x39b5830, Method$System.Collections.Generic.Dictionary<IMobIdData, EnemyMobActionManagerBase.HateState>.get_Item()), ?x3)`
    - calls `Debug$$Log`, `Singleton<object>$$get_Instance`, `PartyManager$$get_IsParty`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - calls `Debug$$Log`, `Singleton<object>$$get_Instance`, `PartyManager$$get_IsParty`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - calls `Debug$$Log`, `Singleton<object>$$get_Instance`, `PartyManager$$get_IsParty`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`
- Effect applied in `MobObjectManager$$ReceiveMobaMobChangeHateManager` (193 guarded paths, truncated):
  - always
    - returns `SummonDemonicAction.ChangeHateManaged(PlayerDataManager.get_PlayerActionManager(playerDataManager, 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - calls `MobObjectManager$$GetMobaMob`, `EnemyMobActionManagerBase$$get_MobStatus`, `EnemyMobActionManagerBase$$get_MobStatus`, `MobStatus$$UpdateHate`, `EnemyMobActionManagerBase$$get_MobStatus`, `System.Linq.Enumerable$$Count<object>`, `Toram.Common.ArchetypeUid$$.ctor`, `System.Collections.Generic.List<object>$$GetEnumerator`
  - always
    - returns `SummonDemonicAction.ChangeHateManaged(PlayerDataManager.get_PlayerActionManager(playerDataManager, 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - calls `MobObjectManager$$GetMobaMob`, `EnemyMobActionManagerBase$$get_MobStatus`, `EnemyMobActionManagerBase$$get_MobStatus`, `MobStatus$$UpdateHate`, `EnemyMobActionManagerBase$$get_MobStatus`, `System.Linq.Enumerable$$Count<object>`, `Toram.Common.ArchetypeUid$$.ctor`, `System.Collections.Generic.List<object>$$GetEnumerator`
  - always
    - returns `SummonDemonicAction.ChangeHateManaged(PlayerDataManager.get_PlayerActionManager(playerDataManager, 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - calls `MobObjectManager$$GetMobaMob`, `EnemyMobActionManagerBase$$get_MobStatus`, `EnemyMobActionManagerBase$$get_MobStatus`, `MobStatus$$UpdateHate`, `EnemyMobActionManagerBase$$get_MobStatus`, `System.Linq.Enumerable$$Count<object>`, `Toram.Common.ArchetypeUid$$.ctor`, `System.Collections.Generic.List<object>$$GetEnumerator`
  - always
    - calls `MobObjectManager$$GetMobaMob`, `EnemyMobActionManagerBase$$get_MobStatus`, `EnemyMobActionManagerBase$$get_MobStatus`, `MobStatus$$UpdateHate`, `EnemyMobActionManagerBase$$get_MobStatus`, `System.Linq.Enumerable$$Count<object>`, `Toram.Common.ArchetypeUid$$.ctor`, `System.Collections.Generic.List<object>$$GetEnumerator`
  - always
    - returns `CamouflageAction.ChangeHateMine(PlayerDataManager.get_PlayerActionManager(playerDataManager, 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - calls `MobObjectManager$$GetMobaMob`, `EnemyMobActionManagerBase$$get_MobStatus`, `EnemyMobActionManagerBase$$get_MobStatus`, `MobStatus$$UpdateHate`, `EnemyMobActionManagerBase$$get_MobStatus`, `System.Linq.Enumerable$$Count<object>`, `Toram.Common.ArchetypeUid$$.ctor`, `System.Collections.Generic.List<object>$$GetEnumerator`
  - always
    - calls `MobObjectManager$$GetMobaMob`, `EnemyMobActionManagerBase$$get_MobStatus`, `EnemyMobActionManagerBase$$get_MobStatus`, `MobStatus$$UpdateHate`, `EnemyMobActionManagerBase$$get_MobStatus`, `System.Linq.Enumerable$$Count<object>`, `Toram.Common.ArchetypeUid$$.ctor`, `System.Collections.Generic.List<object>$$GetEnumerator`
  - always
    - returns `MobObjectManager.ChangeMobaMobUnmanaged(System.Linq.Enumerable.Count<object>([EnemyMobActionManagerBase.get_MobStatus([MobObjectManager.GetMobaMob(this, [[(mobs + 16)+0x20]+0x24], ?x2, ?x3)+0x28], 0, ?x2, ?x3)+0x30], meta(0x399bf68, Method$System.Linq.Enumerable.Count<MobStatus.HateData>()), ?x2, ?x3), 0, MobObjectManager.GetMobaMob(this, [[(mobs + 16)+0x20]+0x24], ?x2, ?x3), ?x3)`
    - calls `MobObjectManager$$GetMobaMob`, `EnemyMobActionManagerBase$$get_MobStatus`, `EnemyMobActionManagerBase$$get_MobStatus`, `MobStatus$$UpdateHate`, `EnemyMobActionManagerBase$$get_MobStatus`, `System.Linq.Enumerable$$Count<object>`, `Toram.Common.ArchetypeUid$$.ctor`, `System.Collections.Generic.List<object>$$GetEnumerator`
  - always
    - calls `MobObjectManager$$GetMobaMob`, `EnemyMobActionManagerBase$$get_MobStatus`, `EnemyMobActionManagerBase$$get_MobStatus`, `MobStatus$$UpdateHate`, `EnemyMobActionManagerBase$$get_MobStatus`, `System.Linq.Enumerable$$Count<object>`, `Toram.Common.ArchetypeUid$$.ctor`, `System.Collections.Generic.List<object>$$GetEnumerator`
- Code that reads this skill's level / buff by constant id: `EnemyMobActionManagerBase$$InitManagedMob (ContainsBuffer)`, `MobObjectManager$$ReceiveMobaMobChangeHateManager (ContainsBuffer)`, `MobaPlayerSecondaryStatus$$GetCrtConstant (TryGetBuf)`, `PhotonListener$$OnActionPartyChangeHateMine (ContainsBuffer)`, `PhotonListener$$OnActionRoomChangeHateMine (ContainsBuffer)`, `PlayerSecondaryStatus$$GetCrtConstant (TryGetBuf)`, `PlayerSecondaryStatus$$GetDisplayBonusCalcHate (TryGetBuf)`

_Raw recovered data (every method item): [trees/HunterSkill.md](../trees/HunterSkill.md) — uid 553_

---

### เมจิคแอร์โรว์ (ForceArrow) · uid 547

<img src="../../icons/sk_547.png" width="40" alt="icon"> 
**Tree:** ハンタースキル (`HunterSkill`, tier 3) · **Type:** Buffer · **Max Lv:** 125 · **Weapons:** Bow, Bowgun · **Requires:** ซันไรส์แอร์โรว์ · **Client class:** `ForceArrow`

> เทคนิคอัพเกรดพลังโจมตีให้ลูกธนูด้วยเวทมนตร์
> การฟื้นฟู ATK อาวุธและ MP โจมตีจะเพิ่มขึ้นเล็กน้อย
> การโจมตีปกติจะถูกอัพเกรดตาม MATK
> ผลลัพธ์ที่ได้จะหมดลง เมื่อใช้การโจมตีปกติตามจำนวนครั้งที่กำหนด

**How it works**

- Buffer skill of the ハンタースキル tree (tier 3, max Lv 125); usable with Bow, Bowgun.
- It installs a buff on the caster.
- Its buff raises normal-attack damage (`NormalAttackRate` / `NormalAttackConstantDamage`).
- Buffs:
  - `ForceArrowBuf`; Lv1 → Lv10: EqAtkUpRate (weapon ATK %) 0 → 5
  - `CountBufferBase`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 1 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 3 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 547
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `ForceArrowBuf` — `.ctor(Lv, (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 0 ? (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 19 ? 1 : 0) : 1), PlayerActionManagerBase.get_PlayerStatus())`
  - when `(System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): adds the caster's buff of `new ForceArrowBuf` — `AddSelfBuffer(new ForceArrowBuf, Id)`
  - when `(System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND UnityEngine.Object.op_Inequality(actarAction) OR (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): constructs `ForceArrowBuf` — `.ctor(Lv, (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 19 ? 1 : 0), PlayerActionManagerBase.get_PlayerStatus())`
  - when `(System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND UnityEngine.Object.op_Inequality(actarAction) OR (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)`

**Buff values** (every recovered field; durations in seconds)

**Buff `ForceArrowBuf`**
- **Boosts normal-attack damage** through the `NormalAttackRate` / `NormalAttackConstantDamage` parameters.
- `AttackMprecoveryUp` = `(int((Lv * 0.5)) + ((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 19 ? 1 : 0) | (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 0 ? 1 : 0)))` _(when BuffEffectActive ne 0; (EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type & 0xfffffffe) eq 12; (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())); EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 13)_
- `NormalAttackConstantDamage` = `(status.Lv + int((status.Matk * 0.1)))` _(when BuffEffectActive ne 0; (EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type & 0xfffffffe) eq 12; (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())); EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 13; ((!EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 19 ? 1 : 0) | (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 0 ? 1 : 0)))_
- `NormalAttackConstantDamage` = `(status.Lv + status.Matk)` _(when BuffEffectActive ne 0; (EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type & 0xfffffffe) eq 12; (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())); EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 13; ((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 19 ? 1 : 0) | (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 0 ? 1 : 0)))_
- `AttackMprecoveryUp` = `(int((Lv * 0.5)) + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 19 ? 1 : 0))` _(when BuffEffectActive ne 0; (EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type & 0xfffffffe) eq 12; (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())); EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ne 13)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| EqAtkUpRate | 0 | 1 | 1 | 2 | 2 | 3 | 3 | 4 | 4 | 5 |

- Buff fields set in the constructor (all recovered):
  - `playerStatus` = `status`
  - `eqAtkRate` = `int((Lv * 0.5))` → Lv1..10 [0, 1, 1, 2, 2, 3, 3, 4, 4, 5]
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:ForceArrowBuf$$.ctor<-ForceArrow$$ActionHit` (no direct constructor call in the skill's own code).
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

- `AttackMprecoveryUp`: MP recovered per attack (flat)
- `Count`: stack / hit counter
- `EqAtkUpRate`: weapon ATK %
- `NormalAttackConstantDamage`: normal-attack flat damage

**In-game level notes**

- Lv19: *ปริมาณ MATK มีผลต่อพลังการโจมตีปกติ+90% *ฟื้นฟู MP โจมตี+1 *เพิ่มจำนวนครั้งผลที่ได้รับ

_Raw recovered data (every method item): [trees/HunterSkill.md](../trees/HunterSkill.md) — uid 547_

---

### ทุ่นระเบิด (Explossive) · uid 551

<img src="../../icons/sk_551.png" width="40" alt="icon"> 
**Tree:** ハンタースキル (`HunterSkill`, tier 3) · **Type:** Object · **Max Lv:** 125 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** กับดักล่าสัตว์ · **Client class:** `ExplossiveAction`

> ติดตั้งกับระเบิด
> มีโอกาสเล็กน้อยที่จะทำให้เป้าหมาย[ไหม้ไฟ]เมื่อเหยียบโดน
> ไม่สามารถติดตั้งที่เท้าโดยตรงได้
> อาจโดนทำลายด้วยการโจมตีในบริเวณกว้าง

**How it works**

- Object skill of the ハンタースキル tree (tier 3, max Lv 125); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- It places an object in the world (trap, summon or field object).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [(0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0]: skill multiplier ×2.6 at Lv1 to 8 at Lv10
  - `calcPlayerToMobDamage` [(System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0]: skill multiplier ×260 at Lv1 to 800 at Lv10
  - `calcPlayerToMobDamage` [(0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage`: flat damage +130 at Lv1 to 400 at Lv10
- Proration: magic proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Ignition (8).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(100)`
- **Effect radius (Unity units)** (`Radius`) (Unity units, 2 = 1 m): `1` = 1
  - when `(0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR (0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0`
- **Effect radius (Unity units)** (`Radius`) (Unity units, 2 = 1 m): `rad`
  - when `(((UnityEngine.Transform.get_position(targetTransform).x - placePosition) * (UnityEngine.Transform.get_position(targetTransform).x - placePosition)) + ((UnityEngine.Transform.get_position(targetTransform).z - placePosition.z) * (UnityEngine.Transform.get_position(targetTransform).z - placePosition.z))) ls ((Radius + size) * (Radius + size)) AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - placePosition.y), size)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 11 set
- `InitializeOthers` — setup used when another player's client replays the action: 5 set
- `ActionStartOthers` — skill-specific method: 1 set
- `ActionStart` — when the cast starts: 3 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 2 call, 1 info
- `CheckRangeHit` — range-hit test: 1 set
- `ActionHit` — when the attack connects: 3 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [(0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0] | 2.6 | 3.2 | 3.8 | 4.4 | 5 | 5.6 | 6.2 | 6.8 | 7.4 | 8 |
| SkillRate × [(System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0] | 260 | 320 | 380 | 440 | 500 | 560 | 620 | 680 | 740 | 800 |
| Flat dmg + | 130 | 160 | 190 | 220 | 250 | 280 | 310 | 340 | 370 | 400 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv * 60) + 200) + ((baseTEC + baseDEX) << 1)) / 100))` — (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv * 60) + 200) + ((baseTEC + baseDEX) << 1)) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv * 30) + 100))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 551, spawns `MobAttackPlayerSelfDestruct`
- Uses the magic proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `1` = 1
  - when `ExplossiveAction.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), MobActionManagerBase.get_transform(?stack), MobActionManagerBase.get_Size(?stack)) AND UnityEngine.Object.op_Inequality(actarAction) AND failTrapper ne 0`

**Status ailments**

- Rolls `abnormalPercent`% to inflict **Ignition (8)** (`calcPlayerToMobDamage`)
- Marks the hit with ailment **Ignition (8)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 8, abnormalPercent, playerAction)`
- Marks the hit with ailment **Ignition (8)** (`ActionHit`)
  - when `!UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND !UnityEngine.Object.op_Equality(actarAction) AND PlayerStatusBase.get_IsLocalDead() AND SkillActionBase.checkPercent(this, 100, abnormalPercent) AND fastHit ne 0 OR !PlayerStatusBase.get_IsLocalDead() AND !UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND !UnityEngine.Object.op_Equality(actarAction) AND SkillActionBase.checkPercent(this, 100, abnormalPercent) AND fastHit ne 0 OR !UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND !UnityEngine.Object.op_Equality(actarAction) AND PlayerStatusBase.get_IsLocalDead() AND SkillActionBase.checkPercent(this, 100, abnormalPercent) AND TryGetProperties<object>.out2(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 10) ne 0 AND fastHit ne 0`

**Other recovered parameters**

- **Effect radius (Unity units)** (`Radius`): `1` = 1 _(when (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR (0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0)_; `rad` _(when (((UnityEngine.Transform.get_position(targetTransform).x - placePosition) * (UnityEngine.Transform.get_position(targetTransform).x - placePosition)) + ((UnityEngine.Transform.get_position(targetTransform).z - placePosition.z) * (UnityEngine.Transform.get_position(targetTransform).z - placePosition.z))) ls ((Radius + size) * (Radius + size)) AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - placePosition.y), size))_
- **Loop / hit-repeat count** (`LoopParam`): `1` = 1 _(when ExplossiveAction.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), MobActionManagerBase.get_transform(?stack), MobActionManagerBase.get_Size(?stack)) AND UnityEngine.Object.op_Inequality(actarAction) AND failTrapper ne 0)_

**In-game level notes**

- Lv19: *DEX กับ TEC มีผลต่อพลัง *ระยะโจมตี (รัศมี)+1m *อัตราติดไหม้ไฟ+80% *ฟื้นฟู MP เมื่อวางกับดัก+100

_Raw recovered data (every method item): [trees/HunterSkill.md](../trees/HunterSkill.md) — uid 551_

---

### ไซโคลนแอร์โรว์ (CycloneArrow) · uid 556

<img src="../../icons/sk_556.png" width="40" alt="icon"> 
**Tree:** ハンタースキル (`HunterSkill`, tier 3) · **Type:** Attack · **Max Lv:** 125 · **Weapons:** Bow · **Requires:** ดีเทคชั่น · **Client class:** `CycloneArrowAction`

> สกิลการยิงธนูที่ห่อหุ้มด้วยวายุเพื่อสร้างทอร์นาโด
> แม้พลังจะต่ำแต่มีโอกาสทำให้เป้าหมาย "ผงะ"
> และดูดกลืนมอนสเตอร์ที่อยู่โดยรอบ

**How it works**

- Attack skill of the ハンタースキル tree (tier 3, max Lv 125); usable with Bow.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [(mainWeapon==Arrow & 1) eq 0]: skill multiplier ×0.1 at Lv1 to 1 at Lv10
  - `calcPlayerToMobDamage` [(mainWeapon==Arrow & 1) ne 0]: skill multiplier depends on Dex (formula below)
  - `calcPlayerToMobDamage`: flat damage +100
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Flinch (1), Suction (28).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(14)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 5 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionStartOthers` — skill-specific method: 1 set
- `ActionStart` — when the cast starts: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 3 call, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.1 | 0.2 | 0.3 | 0.4 | 0.5 | 0.6 | 0.7 | 0.8 | 0.9 | 1 |
| Flat dmg + | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv + (Lv << 2)) << 1) + ((status.Dex lt 0 ? (status.Dex + 1) : status.Dex) >> 1))) / 100)` — (mainWeapon==Arrow & 1) ne 0

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv + (Lv << 2)) << 1) + ((status.Dex lt 0 ? (status.Dex + 1) : status.Dex) >> 1))) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 556
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Rolls `(Lv * Lv)`% to inflict **Flinch (1)** (`calcPlayerToMobDamage`)
  - when `MobActionManagerBase.get_IsPlayerManaged(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 1, (Lv * Lv), playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_gameObject(mobAction), skillTarget) OR !PlayerAttackBase.checkAbnormalPercent(this, 1, (Lv * Lv), playerAction) AND MobActionManagerBase.get_IsPlayerManaged(mobAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_gameObject(mobAction), skillTarget)`
- Uses the default ailment duration (`calcPlayerToMobDamage`)
  - when `MobActionManagerBase.get_IsPlayerManaged(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 1, (Lv * Lv), playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_gameObject(mobAction), skillTarget)`
- Rolls `100`% to inflict **Suction (28)** (`calcPlayerToMobDamage`)
  - when `!MobActionManagerBase.get_IsBoss(mobAction) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_gameObject(mobAction), skillTarget) AND MobActionManagerBase.get_IsPlayerManaged(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 28, 100, playerAction) OR !MobActionManagerBase.get_IsBoss(mobAction) AND !PlayerAttackBase.checkAbnormalPercent(this, 28, 100, playerAction) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_gameObject(mobAction), skillTarget) AND MobActionManagerBase.get_IsPlayerManaged(mobAction)`

**In-game level notes**

- Lv19: *พลังจะเพิ่มมากกว่าค่า DEX ของตัวเอง *ระยะโจมตี (รัศมี) 2 เท่า

_Raw recovered data (every method item): [trees/HunterSkill.md](../trees/HunterSkill.md) — uid 556_

---

### ฮันเตอร์ครอสโบ (BowgunHunter) · uid 557

<img src="../../icons/sk_557.png" width="40" alt="icon"> 
**Tree:** ハンタースキル (`HunterSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 125 · **Weapons:** Bowgun · **Requires:** ดีเทคชั่น · **Client class:** `BowgunHunter` (passive mastery)

> เพิ่มความเก่งกาจในการล่า
> ฮันเตอร์สกิลยังคงแสดงผล
> แม้ว่าจะติดตั้งตัวช่วยอื่นนอกจากลูกธนู
> เพิ่ม ATK ของโบว์กันตามสกิลเลเวล

**How it works**

- Mastery skill of the ハンタースキル tree (tier 3, max Lv 125); usable with Bowgun.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): EqAtkRate (weapon ATK %) 2 at Lv1 to 25 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| EqAtkRate | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |


Bonus meanings (inferred from the names):

- `EqAtkRate`: weapon ATK %

_Raw recovered data (every method item): [trees/HunterSkill.md](../trees/HunterSkill.md) — uid 557_

---

### แซทเทิลไลท์แอร์โรว์ (SatelliteArrow) · uid 548

<img src="../../icons/sk_548.png" width="40" alt="icon"> 
**Tree:** ハンタースキル (`HunterSkill`, tier 4) · **Type:** Object · **Max Lv:** 205 · **Weapons:** Bow, Bowgun · **Requires:** เมจิคแอร์โรว์ · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `SatelliteArrowAction`

> เป็นเทคนิคที่ต้องใช้ความสามารถมากเพื่อโจมตีเป้าหมายจากมุมสูง
> เนื่องจากต้องใช้เวลาในการเล็งโจมตีเป้าหมาย
> จึงต้องการเทคนิคระดับสูงในการโจมตีให้เข้าเป้า

**How it works**

- Object skill of the ハンタースキル tree (tier 4, max Lv 205); usable with Bow, Bowgun.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It places an object in the world (trap, summon or field object).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [(0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0]: skill multiplier ×5.5 at Lv1 to 10 at Lv10
  - `calcPlayerToMobDamage` [(0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0]: skill multiplier depends on Dex (formula below)
  - `calcPlayerToMobDamage`: flat damage +300
- Proration: physical-skill proration slot, mode `first_hit_per_target`.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(16)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 8 set
- `InitializeOthers` — setup used when another player's client replays the action: 4 set
- `ActionStart` — when the cast starts: 6 set
- `SetTargetMobOthers` — skill-specific method: 1 set
- `ActionSkillEvent` — on an animation/skill event during the motion: 6 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 4 tpl, 1 call, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 5.5 | 6 | 6.5 | 7 | 7.5 | 8 | 8.5 | 9 | 9.5 | 10 |
| Flat dmg + | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv * 50) + 500) + status.Dex) / 100))` — (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(target.ExpDefSkill / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv * 50) + 500) + status.Dex) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(300)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 548
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Hit counts**

- Number of damage events (`damageCount`): `((Lv + 3) >> 2)` → Lv1..10 [1, 1, 1, 1, 2, 2, 2, 2, 3, 3]
- Loop / hit-repeat count (`LoopParam`): `((Lv + 3) >> 2)` → Lv1..10 [1, 1, 1, 1, 2, 2, 2, 2, 3, 3]
- Number of damage events (`damageCount`): `motionSpeed`

**Buffs and effects it installs or removes**

- `calcPlayerToMobDamage` (damage calculation against a monster): adds the buff-provided flat damage to the template — `SetBufferConstantDamage(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), damageCount)`

**Other recovered parameters**

- **Resistance value** (`resist`): `((Lv + (Lv << 2)) + 50)` → Lv1..10 [55, 60, 65, 70, 75, 80, 85, 90, 95, 100]
- **Number of damage events** (`damageCount`): `((Lv + 3) >> 2)` → Lv1..10 [1, 1, 1, 1, 2, 2, 2, 2, 3, 3]; `motionSpeed`
- **Loop / hit-repeat count** (`LoopParam`): `((Lv + 3) >> 2)` → Lv1..10 [1, 1, 1, 1, 2, 2, 2, 2, 3, 3]

**In-game level notes**

- Lv19: *DEX มีผลต่อพลัง *ระยะโจมตี (รัศมี)+0.5m

_Raw recovered data (every method item): [trees/HunterSkill.md](../trees/HunterSkill.md) — uid 548_

---

### กับดักความมืด (BlankTrap) · uid 552

<img src="../../icons/sk_552.png" width="40" alt="icon"> 
**Tree:** ハンタースキル (`HunterSkill`, tier 4) · **Type:** Object · **Max Lv:** 205 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ทุ่นระเบิด · **Flags:** StarGem · **Client class:** `BlankTrapAction`

> ติดตั้งกับดักดูดพลัง
> มีโอกาสเล็กน้อยที่จะทำให้เป้าหมาย[เฉื่อยชา]เมื่อเหยียบโดน
> ไม่สามารถติดตั้งที่เท้าโดยตรงได้
> อาจโดนทำลายได้ด้วยการโจมตีในบริเวณกว้าง

**How it works**

- Object skill of the ハンタースキル tree (tier 4, max Lv 205); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- It places an object in the world (trap, summon or field object).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [(0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0]: skill multiplier ×0.01 at Lv1 to 0.1 at Lv10
  - `calcPlayerToMobDamage` [(0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage`: flat damage +55 at Lv1 to 100 at Lv10
- Proration: magic proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Weak (15).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(100)`
- **Effect radius (Unity units)** (`Radius`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance(((Lv hi 5 ? 1.5 : 1) + 1))`
  - when `(0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0`
- **Effect radius (Unity units)** (`Radius`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance((Lv hi 5 ? 1.5 : 1))`
  - when `(0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 13 set
- `InitializeOthers` — setup used when another player's client replays the action: 5 set
- `ActionStartOthers` — skill-specific method: 1 set
- `ActionStart` — when the cast starts: 3 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 2 call, 1 info
- `ActionHit` — when the attack connects: 3 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.01 | 0.02 | 0.03 | 0.04 | 0.05 | 0.06 | 0.07 | 0.08 | 0.09 | 0.1 |
| Flat dmg + | 55 | 60 | 65 | 70 | 75 | 80 | 85 | 90 | 95 | 100 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((Lv + baseDEX) / 100))` — (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((Lv + baseDEX) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv + (Lv << 2)) + 50))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 552, spawns `MobAttackPlayerSelfDestruct`
- Uses the magic proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `1` = 1
  - when `BlankTrapAction.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), MobActionManagerBase.get_transform(?stack), MobActionManagerBase.get_Size(?stack)) AND UnityEngine.Object.op_Inequality(actarAction) AND failTrapper ne 0`

**Status ailments**

- Chance field `abnormalPercent` (Chance to inflict the skill's status ailment (%)): `(((((Lv + 2) >> 2) * 10) + 50) + 20)` → Lv1..10 [70, 80, 80, 80, 80, 90, 90, 90, 90, 100]
  - when `(0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0`
- Chance field `abnormalPercent` (Chance to inflict the skill's status ailment (%)): `((((Lv + 2) >> 2) * 10) + 50)` → Lv1..10 [50, 60, 60, 60, 60, 70, 70, 70, 70, 80]
  - when `(0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0`
- Rolls `abnormalPercent`% to inflict **Weak (15)** (`calcPlayerToMobDamage`)
- Marks the hit with ailment **Weak (15)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 15, abnormalPercent, playerAction)`
- Marks the hit with ailment **Weak (15)** (`ActionHit`)
  - when `!UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND !UnityEngine.Object.op_Equality(actarAction) AND PlayerStatusBase.get_IsLocalDead() AND SkillActionBase.checkPercent(this, 100, abnormalPercent) AND fastHit ne 0 OR !PlayerStatusBase.get_IsLocalDead() AND !UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND !UnityEngine.Object.op_Equality(actarAction) AND SkillActionBase.checkPercent(this, 100, abnormalPercent) AND fastHit ne 0 OR !UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND !UnityEngine.Object.op_Equality(actarAction) AND PlayerStatusBase.get_IsLocalDead() AND SkillActionBase.checkPercent(this, 100, abnormalPercent) AND TryGetProperties<object>.out2(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 10) ne 0 AND fastHit ne 0`

**Other recovered parameters**

- **Effect radius (Unity units)** (`Radius`): `MathUtil.DisplayMeterToDistance(((Lv hi 5 ? 1.5 : 1) + 1))` _(when (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0)_; `MathUtil.DisplayMeterToDistance((Lv hi 5 ? 1.5 : 1))` _(when (0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!PlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) OR ((subWeapon != Null ? 1 : 0) | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) ne 0 OR (0 | (subWeapon == Arrow ? 1 : 0)) eq 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyPlayerStatusBase.get_SkillManager().SkillMasteryList, 557, meta(0x397e5b8, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.ContainsKey())) AND (mainWeapon==Bowgun & 1) eq 0)_
- **Loop / hit-repeat count** (`LoopParam`): `1` = 1 _(when BlankTrapAction.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), MobActionManagerBase.get_transform(?stack), MobActionManagerBase.get_Size(?stack)) AND UnityEngine.Object.op_Inequality(actarAction) AND failTrapper ne 0)_

**In-game level notes**

- Lv19: *DEX มีผลต่อพลัง *ระยะโจมตี (รัศมี)+1m *อัตราติดเฉื่อยชา+20% *ฟื้นฟู MP เมื่อวางกับดัก+100

_Raw recovered data (every method item): [trees/HunterSkill.md](../trees/HunterSkill.md) — uid 552_

---

### เวอร์ติคัลแอร์ (VerticalAir) · uid 555

<img src="../../icons/sk_555.png" width="40" alt="icon"> 
**Tree:** ハンタースキル (`HunterSkill`, tier 4) · **Type:** Attack · **Max Lv:** 205 · **Weapons:** Bow · **Requires:** ไซโคลนแอร์โรว์ · **Client class:** `VerticalAirAction`

> สกิลลูกธนูมรณะผสมผสานระหว่างหลบหลีกและตอบโต้
> จำนวนการโจมตีจะเพิ่มขึ้นตามระยะห่าง
> (สูงสุด 3 ครั้ง)
> ติด "คงกระพัน" ให้ตัวเองเมื่อเปิดใช้สกิล

**How it works**

- Attack skill of the ハンタースキル tree (tier 4, max Lv 205); usable with Bow.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- Damage (`calcPlayerToMobDamage` x3; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [0 hs fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 ge damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 hs physicsResist.Length AND 1 lt damageCount AND damageCount ge 1]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 hs fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 ge damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 hs physicsResist.Length AND 2 lt damageCount AND damageCount ge 1]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 hs fixAddDamage.Length AND 2 lo physicsResist.Length AND 2 lo skillRate.Length AND 2 lt damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 lo fixAddDamage.Length AND 2 lo physicsResist.Length AND 2 lo skillRate.Length AND 2 lt damageCount AND 3 ge damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 lo fixAddDamage.Length AND 2 lo physicsResist.Length AND 2 lo skillRate.Length AND 2 lt damageCount AND 3 lt damageCount AND damageCount ge 1]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 ge damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 hs physicsResist.Length AND 1 lt damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 hs skillRate.Length AND 1 lo physicsResist.Length AND 1 lt damageCount AND damageCount ge 1]: flat damage depends on live values (formula below)
  - `calcPlayerToMobDamage` [0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 ge damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 hs physicsResist.Length AND 2 lt damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 hs skillRate.Length AND 2 lo physicsResist.Length AND 2 lt damageCount AND damageCount ge 1]: flat damage depends on live values (formula below)
  - `calcPlayerToMobDamage` [0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 lo fixAddDamage.Length AND 2 lo physicsResist.Length AND 2 lo skillRate.Length AND 2 lt damageCount AND 3 ge damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 lo fixAddDamage.Length AND 2 lo physicsResist.Length AND 2 lo skillRate.Length AND 2 lt damageCount AND 3 lt damageCount AND damageCount ge 1]: flat damage depends on live values (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 11 set
- `InitializeOthers` — setup used when another player's client replays the action: 3 set
- `ActionPreparation` — before the cast starts: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 6 tpl, 3 info
- `via PlayerAttackBase$$HitReactionAssign` — skill-specific method: 1 call, 2 tpl

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(skillRate[0] / 100)` — 0 hs fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 ge damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 hs physicsResist.Length AND 1 lt damageCount AND damageCount ge 1
- SkillRate × `(skillRate[1] / 100)` — 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 hs fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 ge damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 hs physicsResist.Length AND 2 lt damageCount AND damageCount ge 1
- SkillRate × `(skillRate[2] / 100)` — 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 hs fixAddDamage.Length AND 2 lo physicsResist.Length AND 2 lo skillRate.Length AND 2 lt damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 lo fixAddDamage.Length AND 2 lo physicsResist.Length AND 2 lo skillRate.Length AND 2 lt damageCount AND 3 ge damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 lo fixAddDamage.Length AND 2 lo physicsResist.Length AND 2 lo skillRate.Length AND 2 lt damageCount AND 3 lt damageCount AND damageCount ge 1
- Flat dmg + `fixAddDamage[0]` — 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 ge damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 hs physicsResist.Length AND 1 lt damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 hs skillRate.Length AND 1 lo physicsResist.Length AND 1 lt damageCount AND damageCount ge 1
- Flat dmg + `fixAddDamage[1]` — 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 ge damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 hs physicsResist.Length AND 2 lt damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 hs skillRate.Length AND 2 lo physicsResist.Length AND 2 lt damageCount AND damageCount ge 1
- Flat dmg + `fixAddDamage[2]` — 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 lo fixAddDamage.Length AND 2 lo physicsResist.Length AND 2 lo skillRate.Length AND 2 lt damageCount AND 3 ge damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 lo fixAddDamage.Length AND 2 lo physicsResist.Length AND 2 lo skillRate.Length AND 2 lt damageCount AND 3 lt damageCount AND damageCount ge 1

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(skillRate[0] / 100)`
  - when `0 hs fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 ge damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 hs physicsResist.Length AND 1 lt damageCount AND damageCount ge 1`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `fixAddDamage[0]`
  - when `0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 ge damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 hs physicsResist.Length AND 1 lt damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 hs skillRate.Length AND 1 lo physicsResist.Length AND 1 lt damageCount AND damageCount ge 1`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(skillRate[1] / 100)`
  - when `0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 hs fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 ge damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 hs physicsResist.Length AND 2 lt damageCount AND damageCount ge 1`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `fixAddDamage[1]`
  - when `0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 ge damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 hs physicsResist.Length AND 2 lt damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 hs skillRate.Length AND 2 lo physicsResist.Length AND 2 lt damageCount AND damageCount ge 1`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(skillRate[2] / 100)`
  - when `0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 hs fixAddDamage.Length AND 2 lo physicsResist.Length AND 2 lo skillRate.Length AND 2 lt damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 lo fixAddDamage.Length AND 2 lo physicsResist.Length AND 2 lo skillRate.Length AND 2 lt damageCount AND 3 ge damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 lo fixAddDamage.Length AND 2 lo physicsResist.Length AND 2 lo skillRate.Length AND 2 lt damageCount AND 3 lt damageCount AND damageCount ge 1`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `fixAddDamage[2]`
  - when `0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 lo fixAddDamage.Length AND 2 lo physicsResist.Length AND 2 lo skillRate.Length AND 2 lt damageCount AND 3 ge damageCount AND damageCount ge 1 OR 0 lo fixAddDamage.Length AND 0 lo physicsResist.Length AND 0 lo skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo physicsResist.Length AND 1 lo skillRate.Length AND 1 lt damageCount AND 2 lo fixAddDamage.Length AND 2 lo physicsResist.Length AND 2 lo skillRate.Length AND 2 lt damageCount AND 3 lt damageCount AND damageCount ge 1`
- `via PlayerAttackBase$$HitReactionAssign` (method): `SetCalcValue[GuardPower]` = `System.Math.Max(0, (25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4))))`
  - when `!MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType ne 2 AND comboType ne 3`
- `via PlayerAttackBase$$HitReactionAssign` (method): `SetCalcValue[GuardPower]` = `25`
  - when `!MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType ne 2 AND comboType ne 3`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 555
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Hit counts**

- Number of damage events (`damageCount`): `SkillIndividualFlag`
- Number of damage events (`damageCount`): `System.Math.Min((((MobActionManagerBase.get_PlayerMeterDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)) lt 0 ? (MobActionManagerBase.get_PlayerMeterDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)) + 3) : MobActionManagerBase.get_PlayerMeterDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) >> 2) + 1), 3)`

**Status ailments**

- Extra percent roll `CheckPercent` (`via PlayerAttackBase$$HitReactionAssign`)
  - when `!MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) eq 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3`

**Other recovered parameters**

- **Number of damage events** (`damageCount`): `SkillIndividualFlag`; `System.Math.Min((((MobActionManagerBase.get_PlayerMeterDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)) lt 0 ? (MobActionManagerBase.get_PlayerMeterDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)) + 3) : MobActionManagerBase.get_PlayerMeterDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) >> 2) + 1), 3)`

**In-game level notes**

- Lv19: *เพิ่มอาวุธเจาะเข้าเมื่อโจมตีครั้งที่ 2 *เพิ่มอาวุธเจาะเข้าเมื่อโจมตีครั้งที่ 3

_Raw recovered data (every method item): [trees/HunterSkill.md](../trees/HunterSkill.md) — uid 555_

---

### มัลติเพิลฮันท์ / วูปสไนเปอร์ / สไนเปอร์วอลเลย์ / วันแฮนด์ช็อต / ชาร์ปชูตเตอร์ (MultipleHunt) · uid 558

<img src="../../icons/sk_558.png" width="40" alt="icon"> 
**Tree:** ハンタースキル (`HunterSkill`, tier 4) · **Type:** Attack · **Max Lv:** 205 · **Weapons:** Bowgun · **Requires:** ฮันเตอร์ครอสโบ · **Client class:** `MultipleHuntAction`

> สกิลการล่าโดยใช้อาวุธเสริม
> เมื่อเปิดใช้สกิลนี้โดยไม่ได้ใช้ดาบสั้น, อุปกรณ์เวทมนตร์ หรือโล่
> จะสร้างความเสียหายให้กับเป้าหมายและ
> ยิ่งอาวุธเจาะเข้าของตัวเองสูงเท่าไหร่
> ก็จะยิ่งมีโอกาสทำให้เกิด "ลดการป้องกัน" มากเท่านั้น

**How it works**

- Attack skill of the ハンタースキル tree (tier 4, max Lv 205); usable with Bowgun.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- It can inflict a status ailment (chance and type below).
- Damage (`calcDamageWolfAssault` x1, `calcDamageHighRainSnipe` x1, `calcDamageChasseGarde` x1, `calcDamageSharpSnipe` x1; each template is a full damage roll with its own crit):
  - `calcDamageWolfAssault`: skill multiplier ×0.75 at Lv1 to 7.5 at Lv10; skill multiplier depends on Agi (formula below); skill multiplier depends on Agi (formula below); skill multiplier depends on Agi (formula below); flat damage +200
  - `calcDamageHighRainSnipe` [hitCount ne 0]: skill multiplier ×5.25 at Lv1 to 7.5 at Lv10
- Proration: slot chosen at runtime (physical or magic by a per-cast flag), mode `first_hit_per_target`.
- Can inflict on the target: Stop (12), Breaking (10).
- Buffs:
  - `MultipleHuntBuf`; Lv1 → Lv10: ShortRangeRate (short-range damage %) 10 → 10, CrtUp (critical rate +) -34 → -25, MobLastDamageRateUnique (final damage multiplier vs monsters (unique category)) 72 → 72
- Other client code reads this skill (8 lookups; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `1.5` = 1.5
- **Cast time** (`CastTime`): `0` = 0
  - when `UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND mode eq 3`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`
- **Effect radius (Unity units)** (`Radius`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance(12)`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(16)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `OtherPlayerAttackStartReceive` — skill-specific method: 1 set
- `InitializeWolfAssault` — skill-specific method: 6 set
- `InitializeHighRainSnipe` — skill-specific method: 8 set
- `InitializeChasseGarde` — skill-specific method: 6 set
- `InitializeSharpSnipe` — skill-specific method: 9 set
- `ActionPreparation` — before the cast starts: 2 set
- `ActionStart` — when the cast starts: 1 call
- `calcDamageWolfAssault` — skill-specific method: 2 tpl, 1 info
- `calcDamageHighRainSnipe` — skill-specific method: 5 tpl, 1 info, 2 call
- `calcDamageChasseGarde` — skill-specific method: 2 tpl, 1 info
- `calcDamageSharpSnipe` — skill-specific method: 2 tpl, 4 call, 1 info
- `NextRangeHit` — next range-hit pass: 1 set
- `GetLocalizeKey` — skill-specific method: 1 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [calcDamageWolfAssault] | 0.75 | 1.5 | 2.25 | 3 | 3.75 | 4.5 | 5.25 | 6 | 6.75 | 7.5 |
| SkillRate × [calcDamageHighRainSnipe hitCount ne 0] | 5.25 | 5.5 | 5.75 | 6 | 6.25 | 6.5 | 6.75 | 7 | 7.25 | 7.5 |
| Flat dmg + | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) + (status.Agi + ((Lv * 50) + 500)))) / 100)` — calcDamageWolfAssault
- SkillRate × `(((SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) + (status.Agi + ((Lv * 50) + 500)))) / 100)` — calcDamageWolfAssault
- SkillRate × `(((SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) + (status.Agi + ((Lv * 50) + 500)))) / 100)` — calcDamageWolfAssault

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcDamageWolfAssault` (method): `AddRate[SkillRate]` = `(((SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) + (status.Agi + ((Lv * 50) + 500)))) / 100)`
- `calcDamageWolfAssault` (method): `AddConstant[SkillConstantDamage]` = `(200)`
- `calcDamageHighRainSnipe` (method): `SetRate[ExpRate]` = `(target.ExpDefSkill / 100)`
  - when `hitCount ne 0`
- `calcDamageHighRainSnipe` (method): `AddRate[SkillRate]` = `((((Lv * 25) + 500)) / 100)`
  - when `hitCount ne 0`
- `calcDamageHighRainSnipe` (method): `AddConstant[SkillConstantDamage]` = `(200)`
- `calcDamageHighRainSnipe` (method): `AddRate[SkillRate]` = `(((SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) + (status.Agi + ((Lv * 50) + 500)))) / 100)`
  - when `hitCount eq 0 OR PlayerAttackBase.checkAbnormalPercent(this, 12, abnormalPercent, playerAction) AND hitCount eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 12, abnormalPercent, playerAction) AND hitCount eq 0`
- `calcDamageHighRainSnipe` (method): `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`
  - when `hitCount ne 0`
- `calcDamageChasseGarde` (method): `AddRate[SkillRate]` = `(((SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) + (status.Agi + ((Lv * 50) + 500)))) / 100)`
- `calcDamageChasseGarde` (method): `AddConstant[SkillConstantDamage]` = `(200)`
- `calcDamageSharpSnipe` (method): `AddRate[SkillRate]` = `(((SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) + (status.Agi + ((Lv * 50) + 500)))) / 100)`
- `calcDamageSharpSnipe` (method): `AddConstant[SkillConstantDamage]` = `(200)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `dynamic`, mode `first_hit_per_target`, attack type `dynamic`, action id 558
- Uses the slot chosen at runtime (physical or magic by a per-cast flag); Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Hit counts**

- Hit count (`hitCount`): `(hitCount + 1)`

**Status ailments**

- Chance field `abnormalPercent` (Chance to inflict the skill's status ailment (%)): `(((baseDEX // 10) + (Lv + (Lv << 2))) + (status.Int // 5))`
- Chance field `abnormalPercent` (Chance to inflict the skill's status ailment (%)): `(10 + (BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51) << 1))`
- Rolls `abnormalPercent`% to inflict **Stop (12)** (`calcDamageHighRainSnipe`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 12, abnormalPercent, playerAction) AND hitCount eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 12, abnormalPercent, playerAction) AND hitCount eq 0`
- Marks the hit with ailment **Stop (12)** (`calcDamageHighRainSnipe`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 12, abnormalPercent, playerAction) AND hitCount eq 0`
- Rolls `abnormalPercent`% to inflict **Breaking (10)** (`calcDamageSharpSnipe`)
- Marks the hit with ailment **Breaking (10)** (`calcDamageSharpSnipe`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 10, abnormalPercent, playerAction)`

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): adds the caster's buff of skill 558 (MultipleHunt) — `AddSelfBuffer(558, Lv, 0)`
  - when `!PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND mode eq 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND mode eq 2 AND mode ne 0`
- `calcDamageSharpSnipe` (method): adds the caster's buff of skill 558 (MultipleHunt) — `AddSelfBuffer(558, Lv, 0)`
- `calcDamageSharpSnipe` (method): removes the caster's buff of skill 558 (MultipleHunt) — `RemoveSelfBuffer(558)`

**Other recovered parameters**

- **Second-part multiplier** (`secondSkillRate`): `((Lv * 25) + 500)` → Lv1..10 [525, 550, 575, 600, 625, 650, 675, 700, 725, 750]
- **Effect radius (Unity units)** (`Radius`): `MathUtil.DisplayMeterToDistance(12)`
- **Cast time modifier** (`CastTime`): `1.5` = 1.5; `0` = 0 _(when UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND mode eq 3)_
- **Hit count** (`hitCount`): `(hitCount + 1)`

**Buff values** (every recovered field; durations in seconds)

**Buff `MultipleHuntBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `ApplyDamageCut`, `AttackSkillEnd`, `CheckMode`, `DamageFunction`, `GetHealValue`, `SkillEnd`, `StartSkill`
- `MagicDmgCut` = `damageResist` _(when BuffEffectActive ne 0)_
- `PowerDmgCut` = `damageResist` _(when BuffEffectActive ne 0)_
- `MobLastDamageRateUnique` = `0` _(when BuffEffectActive ne 0; isSkillEnd ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| ShortRangeRate | 10 | 10 | 10 | 10 | 10 | 10 | 10 | 10 | 10 | 10 |
| CrtUp | -34 | -33 | -32 | -31 | -30 | -29 | -28 | -27 | -26 | -25 |
| MobLastDamageRateUnique | 72 | 72 | 72 | 72 | 72 | 72 | 72 | 72 | 72 | 72 |

- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `flag` = `1024` = 1024 when mode eq 3 OR mode eq 0 AND mode ne 2 AND mode ne 3 OR mode ne 0 AND mode ne 2 AND mode ne 3
  - `flag` = `1536` = 1536 when !UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND Lv hi 9 AND mode eq 2 AND mode ne 3 OR Lv hi 9 AND UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND mode eq 2 AND mode ne 3 OR !UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND ((11 - Lv) - 1) le 1 AND Lv ls 9 AND mode eq 2 AND mode ne 3
  - `guardEffectId` = `0x9ec0a3` = 10404003 when mode eq 3 OR mode eq 0 AND mode ne 2 AND mode ne 3 OR mode ne 0 AND mode ne 2 AND mode ne 3
  - `healCheckList` = `new System.Collections.Generic.Dictionary<PlayerAttackBase, int>` when mode eq 3 OR mode eq 0 AND mode ne 2 AND mode ne 3 OR mode ne 0 AND mode ne 2 AND mode ne 3
  - `skillMode` = `mode` when mode eq 3 OR mode eq 0 AND mode ne 2 AND mode ne 3 OR mode ne 0 AND mode ne 2 AND mode ne 3
  - `shortRangeRate` = `10` = 10 when mode eq 0 AND mode ne 2 AND mode ne 3
  - `bufferType` = `13` = 13 when mode eq 3 OR mode eq 0 AND mode ne 2 AND mode ne 3 OR !UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND Lv hi 9 AND mode eq 2 AND mode ne 3
  - `actionManager` = `PlayerDataManager.get_PlayerActionManager(PlayerDataManager.GetPlayerDataManager())` when Lv hi 9 AND UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND mode eq 2 AND mode ne 3 OR ((11 - Lv) - 1) le 1 AND Lv ls 9 AND UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND mode eq 2 AND mode ne 3 OR (((11 - Lv) - 1) - 1) le 1 AND ((11 - Lv) - 1) gt 1 AND Lv ls 9 AND UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND mode eq 2 AND mode ne 3
  - `takeController` = `UnityEngine.Component.GetComponent<TakeController>(PlayerDataManager.get_PlayerActionManager(PlayerDataManager.GetPlayerDataManager()))` when Lv hi 9 AND UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND mode eq 2 AND mode ne 3 OR ((11 - Lv) - 1) le 1 AND Lv ls 9 AND UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND mode eq 2 AND mode ne 3 OR (((11 - Lv) - 1) - 1) le 1 AND ((11 - Lv) - 1) gt 1 AND Lv ls 9 AND UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND mode eq 2 AND mode ne 3
  - `isSkillEnd` = `0` when !UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND Lv hi 9 AND mode eq 2 AND mode ne 3 OR Lv hi 9 AND UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND mode eq 2 AND mode ne 3 OR !UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND ((11 - Lv) - 1) le 1 AND Lv ls 9 AND mode eq 2 AND mode ne 3
  - `damageCut` = `72` = 72 when !UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND ((11 - Lv) - 1) le 1 AND Lv ls 9 AND mode eq 2 AND mode ne 3 OR ((11 - Lv) - 1) le 1 AND Lv ls 9 AND UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND mode eq 2 AND mode ne 3
  - `damageCut` = `57` = 57 when !UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND (((11 - Lv) - 1) - 1) le 1 AND ((11 - Lv) - 1) gt 1 AND Lv ls 9 AND mode eq 2 AND mode ne 3 OR (((11 - Lv) - 1) - 1) le 1 AND ((11 - Lv) - 1) gt 1 AND Lv ls 9 AND UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND mode eq 2 AND mode ne 3
  - `damageCut` = `45` = 45 when !UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND ((((11 - Lv) - 1) - 1) - 1) le 1 AND (((11 - Lv) - 1) - 1) gt 1 AND ((11 - Lv) - 1) gt 1 AND Lv ls 9 AND mode eq 2 AND mode ne 3 OR ((((11 - Lv) - 1) - 1) - 1) le 1 AND (((11 - Lv) - 1) - 1) gt 1 AND ((11 - Lv) - 1) gt 1 AND Lv ls 9 AND UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND mode eq 2 AND mode ne 3
  - `damageCut` = `90` = 90 when !UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND Lv hi 9 AND mode eq 2 AND mode ne 3 OR Lv hi 9 AND UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND mode eq 2 AND mode ne 3 OR !UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) AND ((((11 - Lv) - 1) - 1) - 1) gt 1 AND (((11 - Lv) - 1) - 1) gt 1 AND ((11 - Lv) - 1) gt 1 AND Lv ls 9 AND mode eq 2 AND mode ne 3
- Hook `StartSkill`: `isSkillEnd`=0
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0; `damageResist`=0; `bufferType`=13
- Hook `SkillEnd`: `isSkillEnd`=1; `LeftTime`=10; `bufferType`=7; `damageResist`=((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255) lo 15 ? (ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255) : 15)
- Hook `ApplyDamageCut`: `isDamaged`=1
- Hook `DamageFunction`: `isDamaged`=0

Parameter meanings (inferred from the `SkillBufferId` names):

- `CrtUp`: critical rate +
- `MagicDmgCut`: magic damage taken reduction
- `MobLastDamageRateUnique`: final damage multiplier vs monsters (unique category)
- `PowerDmgCut`: physical damage taken reduction
- `ShortRangeRate`: short-range damage %

**In-game level notes**

- Lv15: ควบคุมและยิงเป้าหมายด้วยเวทมนตร์  สร้างความเสียหายทางเวทแก่เป้าหมาย มีโอกาสติด[หยุดนิ่ง] โจมตีโดยรอบอย่างต่อเนื่อง (ความเสียหายกายภาพ) เมื่อนั้นเป้าหมายที่หยุดนิ่งจะการันตีคริติคอล
- Lv17: ยิงโดยถือโล่ไว้ด้านหน้า  พลังเพิ่มตามค่า VIT ของตัวเอง ลดความเสียหายที่ได้รับระหว่างสกิลแสดงผล หากใช้สกิลสำเร็จ ผลการฟื้นฟู HP จะเพิ่มความเสียหายของสกิลเป็นเวลา 10 วินาที
- Lv18: หลังซุ่มโจมตีด้วยดาบสั้นจะโจมตีด้วยธนูโดยอัตโนมัติ  พลังเพิ่มตามค่า AGI ของตัวเอง ลดการใช้ MP ลงครึ่งหนึ่งของสกิลที่ใช้ถัดไป และพลังโจมตีระยะใกล้จะเพิ่มขึ้นเล็กน้อย

**Where else this skill takes effect**

- Effect applied in `PlayerAttackBase$$CalcCostMp` (299 guarded paths, truncated):
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
- Effect applied in `EnemyMobActionManagerBase$$Damaged` (300 guarded paths, truncated):
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
- Effect applied in `BCollaboBossActionManager$$Damaged` (300 guarded paths, truncated):
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
- Effect applied in `PlayerAttackBase$$ActionStart` (30 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 558, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `?blr`
    - set `actionStartTime` = `UnityEngine.Time.get_realtimeSinceStartup(0, ?x1, ?x2, ?x3)`
    - set `startTargetDist` = `fsqrt((((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3) - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)) * (UnityEn`
    - set `_motionSpeed` = `int((SkillActionBase.get_MotionSpeed(this, 0, ?x2, ?x3) * 1.5))`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `UnityEngine.Time$$get_realtimeSinceStartup`, `0x165d8dc`, `PlayerAttackBase$$SetSendAtkParam`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`
  - when `(SkillBufferManager.TryGetBuf(?blr, 558, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `?blr`
    - set `actionStartTime` = `UnityEngine.Time.get_realtimeSinceStartup(0, ?x1, ?x2, ?x3)`
    - set `startTargetDist` = `fsqrt((((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3) - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)) * (UnityEn`
    - set `_motionSpeed` = `int((SkillActionBase.get_MotionSpeed(this, 0, ?x2, ?x3) * 1.5))`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `UnityEngine.Time$$get_realtimeSinceStartup`, `0x165d8dc`, `PlayerAttackBase$$SetSendAtkParam`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`
  - when `(SkillBufferManager.TryGetBuf(?blr, 558, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - returns `?blr`
    - set `actionStartTime` = `UnityEngine.Time.get_realtimeSinceStartup(0, ?x1, ?x2, ?x3)`
    - set `startTargetDist` = `fsqrt((((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3) - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)) * (UnityEn`
    - set `_motionSpeed` = `int((SkillActionBase.get_MotionSpeed(this, 0, ?x2, ?x3) * 1.5))`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `UnityEngine.Time$$get_realtimeSinceStartup`, `0x165d8dc`, `PlayerAttackBase$$SetSendAtkParam`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`
  - when `(SkillBufferManager.TryGetBuf(?blr, 558, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - returns `?blr`
    - set `actionStartTime` = `UnityEngine.Time.get_realtimeSinceStartup(0, ?x1, ?x2, ?x3)`
    - set `startTargetDist` = `fsqrt((((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3) - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)) * (UnityEn`
    - set `_motionSpeed` = `int((SkillActionBase.get_MotionSpeed(this, 0, ?x2, ?x3) * 1.5))`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `UnityEngine.Time$$get_realtimeSinceStartup`, `0x165d8dc`, `PlayerAttackBase$$SetSendAtkParam`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`
  - when `(SkillBufferManager.TryGetBuf(?blr, 558, stkp(-88), 0) & 1) eq 0`
    - returns `?blr`
    - set `actionStartTime` = `UnityEngine.Time.get_realtimeSinceStartup(0, ?x1, ?x2, ?x3)`
    - set `startTargetDist` = `fsqrt((((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3) - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)) * (UnityEn`
    - set `_motionSpeed` = `int((SkillActionBase.get_MotionSpeed(this, 0, ?x2, ?x3) * 1.5))`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `UnityEngine.Time$$get_realtimeSinceStartup`, `0x165d8dc`, `PlayerAttackBase$$SetSendAtkParam`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`
  - when `(SkillBufferManager.TryGetBuf(?blr, 558, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `?blr`
    - set `actionStartTime` = `UnityEngine.Time.get_realtimeSinceStartup(0, ?x1, ?x2, ?x3)`
    - set `startTargetDist` = `fsqrt((((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3) - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)) * (UnityEn`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `UnityEngine.Time$$get_realtimeSinceStartup`, `0x165d8dc`, `PlayerAttackBase$$SetSendAtkParam`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`
  - when `(SkillBufferManager.TryGetBuf(?blr, 558, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `?blr`
    - set `actionStartTime` = `UnityEngine.Time.get_realtimeSinceStartup(0, ?x1, ?x2, ?x3)`
    - set `startTargetDist` = `fsqrt((((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3) - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)) * (UnityEn`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `UnityEngine.Time$$get_realtimeSinceStartup`, `0x165d8dc`, `PlayerAttackBase$$SetSendAtkParam`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`
  - when `(SkillBufferManager.TryGetBuf(?blr, 558, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - returns `?blr`
    - set `actionStartTime` = `UnityEngine.Time.get_realtimeSinceStartup(0, ?x1, ?x2, ?x3)`
    - set `startTargetDist` = `fsqrt((((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3) - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)) * (UnityEn`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `UnityEngine.Time$$get_realtimeSinceStartup`, `0x165d8dc`, `PlayerAttackBase$$SetSendAtkParam`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`
- Effect applied in `MultipleHuntAction$$ActionStart` (3 guarded paths):
  - when `mode ne 0` AND `mode eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 558, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `PlayerAttackBase.add_EndFunction(this, 0x165db78(meta(0x3975858, System.Action<bool>_TypeInfo), ?x1, ?x2, ?x3), 0, ?x3)`
    - calls `0x165db78`, `System.Object$$.ctor`, `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `MultipleHuntBuf$$StartSkill`, `0x165db78`, `System.Action<bool>$$.ctor`
  - when `mode ne 0` AND `mode eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 558, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `0x165db78`, `System.Object$$.ctor`, `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `0x165db84`, `0x165df00`
  - when `mode ne 0` AND `mode eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 558, stkp(-56), 0) & 1) eq 0`
    - returns `PlayerAttackBase.add_EndFunction(this, 0x165db78(meta(0x3975858, System.Action<bool>_TypeInfo), ?x1, ?x2, ?x3), 0, ?x3)`
    - calls `0x165db78`, `System.Object$$.ctor`, `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `SkillBufferManager$$AddSelfBuffer`, `0x165db78`, `System.Action<bool>$$.ctor`
- Effect applied in `MultipleHuntAction.<>c__DisplayClass37_0$$<ActionStart>b__0` (3 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 558, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `MultipleHuntBuf.SkillEnd(TryGetBuf.out2(), (cancel & 1), 0, ?x3)`
    - calls `MultipleHuntBuf$$SkillEnd`
  - when `(SkillBufferManager.TryGetBuf(?blr, 558, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(?blr, 558, stkp(-40), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 558, stkp(-40), 0)`
- Effect applied in `MobAttackBase$$CalcLastDamage` (300 guarded paths, truncated):
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
- Code that reads this skill's level / buff by constant id: `BCollaboBossActionManager$$Damaged (TryGetBuf)`, `EnemyMobActionManagerBase$$Damaged (TryGetBuf)`, `MobAttackBase$$CalcLastDamage (TryGetBuf)`, `MultipleHuntAction$$ActionStart (TryGetBuf)`, `MultipleHuntAction.<>c__DisplayClass37_0$$<ActionStart>b__0 (TryGetBuf)`, `PlayerActionManager$$Damaged (TryGetBuf)`, `PlayerAttackBase$$ActionStart (TryGetBuf)`, `PlayerAttackBase$$CalcCostMp (TryGetBuf)`

_Raw recovered data (every method item): [trees/HunterSkill.md](../trees/HunterSkill.md) — uid 558_

---

### แคมฟลาจ (Camouflage) · uid 559

<img src="../../icons/sk_559.png" width="40" alt="icon"> 
**Tree:** ハンタースキル (`HunterSkill`, tier 5) · **Type:** Buffer · **Max Lv:** 285 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** กับดักความมืด · **Client class:** `CamouflageAction` · **Client class:** `CamouflageMastery` (passive mastery)

> ลดค่าเฮทลงอย่างมากขึ้นอยู่กับ MP ที่ใช้
> และเพิ่ม ATK กับอัตราคริติคอลเป็นเวลา 180 วินาที
> 
> ถ้าตกเป็นเป้าหมายระหว่างได้รับผลลัพธ์
> ผลของพรางตัวจะหายไปและหมดสติ(*)

**How it works**

- Buffer skill of the ハンタースキル tree (tier 5, max Lv 285); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Buffs:
  - `CamouflageBuf`
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Passive modifiers (negative = penalty): Crt (critical rate) 2 at Lv1 to 20 at Lv10.
- Other client code reads this skill (2 lookups; see the last section).

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 1 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionPreparation` — before the cast starts: 1 set
- `ActionHit` — when the attack connects: 2 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 559
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `CamouflageBuf` — `.ctor(Lv, PlayerActionManagerBase.get_PlayerStatus())`
  - when `SkillIndividualFlag eq 1 AND UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): adds the caster's buff of `new CamouflageBuf` — `AddSelfBuffer(new CamouflageBuf, Id)`
  - when `SkillIndividualFlag eq 1 AND UnityEngine.Object.op_Inequality(actarAction)`

**Buff values** (every recovered field; durations in seconds)

**Buff `CamouflageBuf`**
- Buff hook methods: `ChangeHateManaged`, `get_IsEndChangeHate`, `set_IsEndChangeHate`
- `AtkUp` = `(int(((status.Lv / 20) * Lv)) << 1)` _(when EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 12; EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 13)_
- `AtkUp` = `int(((status.Lv / 20) * Lv))` _(when EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 12; EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 13)_
- `CrtUp` = `(criticalUp // (EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 13 ? 2 : 1))`
- Buff fields set in the constructor (all recovered):
  - `playerStatus` = `status`
- Hook `set_IsEndChangeHate`: `IsEndChangeHate`=(value & 1)
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
- Hook `ChangeHateManaged`: `IsEndChangeHate`=1
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:CamouflageBuf$$.ctor<-CamouflageAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

Parameter meanings (inferred from the `SkillBufferId` names):

- `AtkUp`: ATK +
- `CrtUp`: critical rate +

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Crt | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |


Bonus meanings (inferred from the names):

- `Crt`: critical rate

**In-game level notes**

- Lv255: (*)ถ้าไม่ได้อยู่ในปาร์ตี้จะไม่หมดสติ
- Lv12: *ครึ่งหนึ่งของ [ลดค่าเฮทตาม MP ที่ใช้] ของแคมฟลาจที่เรียนรู้ เป็นผลพาสซีฟที่ติดตัวเสมอแม้จะไม่ได้เปิดใช้งานสกิล  *เวลาหมดสติที่เกิดจากแคมฟลาจจะลดลงครึ่งหนึ่ง
- Lv13: *ครึ่งหนึ่งของ[เพิ่มอัตราคริติคอล] ของแคมฟลาจที่เรียนรู้ เป็นผลพาสซีฟที่ติดตัวเสมอแม้จะไม่ได้เปิดใช้งานสกิล  *เวลาหมดสติที่เกิดจากแคมฟลาจจะลดลงครึ่งหนึ่ง

**Where else this skill takes effect**

- Effect applied in `MobaPlayerSecondaryStatus$$GetCrtConstant` (298 guarded paths, truncated):
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3))))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3)))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3)))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3)))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3)))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
- Effect applied in `PlayerSecondaryStatus$$GetCrtConstant` (298 guarded paths, truncated):
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3))))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3)))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3)))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3)))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3)))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
- Code that reads this skill's level / buff by constant id: `MobaPlayerSecondaryStatus$$GetCrtConstant (TryGetBuf)`, `PlayerSecondaryStatus$$GetCrtConstant (TryGetBuf)`

_Raw recovered data (every method item): [trees/HunterSkill.md](../trees/HunterSkill.md) — uid 559_

---

### ความรู้ของนักล่า (HuntersKnowledge) · uid 560

<img src="../../icons/sk_560.png" width="40" alt="icon"> 
**Tree:** ハンタースキル (`HunterSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 285 · **Weapons:** Bowgun · **Requires:** [N]มัลติเพิลฮันท์[W]วูปสไนเปอร์[H]สไนเปอร์วอลเลย์[G]วันแฮนด์ช็อต[S]ชาร์ปชูตเตอร์[N] · **Client class:** `HuntersKnowledge` (passive mastery)

> เพิ่มพลังของสกิล[มัลติเพิลฮันท์]
> ที่เกี่ยวกับความรู้เรื่องอุปกรณ์ล่าสัตว์

**How it works**

- Mastery skill of the ハンタースキル tree (tier 5, max Lv 285); usable with Bowgun.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): SkillRate (skill multiplier bonus) 25 at Lv1 to 250 at Lv10, Crt (critical rate) 25.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate | 25 | 50 | 75 | 100 | 125 | 150 | 175 | 200 | 225 | 250 |
| Crt | 25 | 25 | 25 | 25 | 25 | 25 | 25 | 25 | 25 | 25 |


Bonus meanings (inferred from the names):

- `SkillRate`: skill multiplier bonus
- `Crt`: critical rate

_Raw recovered data (every method item): [trees/HunterSkill.md](../trees/HunterSkill.md) — uid 560_

---

### โฟกัส (Focus) · uid 561

<img src="../../icons/sk_561.png" width="40" alt="icon"> 
**Tree:** ハンタースキル (`HunterSkill`, tier 5) · **Type:** Attack · **Max Lv:** 285 · **Weapons:** Bow, Bowgun · **Requires:** แซทเทิลไลท์แอร์โรว์ · **Client class:** `FocusAction`

> ออกคำสั่งล่า
> หมายหัวศัตรูเป็นเป้าหมาย
> 
> เพิ่มพลังโจมตีระยะไกล
> ต่อเป้าหมายที่กำหนด(รวมสมาชิก PT)

**How it works**

- Attack skill of the ハンタースキル tree (tier 5, max Lv 285); usable with Bow, Bowgun.
- It installs a buff on the caster.
- It installs a buff on other players / the party.
- Buffs:
  - `FocusBuf`
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(16)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 1 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 call
- `ValidDebuff` — skill-specific method: 3 call
- `InvalidDebuff` — skill-specific method: 1 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 561
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `calcPlayerToMobDamage` (damage calculation against a monster): constructs `FocusDebuff` — `.ctor(Toram.Common.ArchetypeUid.get_Id(stkp(-56)), Lv)`
- `ValidDebuff` (method): constructs `FocusBuf` — `.ctor(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 15), PlayerActionManagerBase.get_PlayerStatus())`
  - when `TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 15) ne 0`
- `ValidDebuff` (method): adds a target's buff of `new FocusBuf` — `AddBuffer(new FocusBuf, 0)`
- `ValidDebuff` (method): constructs `FocusBuf` — `.ctor(0, PlayerActionManagerBase.get_PlayerStatus())`
  - when `TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 15) eq 0`
- `InvalidDebuff` (method): removes a target's buff of skill 561 (Focus) — `RemoveBuffer(561)`

**Buff values** (every recovered field; durations in seconds)

**Buff `FocusBuf`**
- `LongRangeRate` = `(int(((debuf.Level * 0.5) + 0.5)))`
- `ShortRangeRate` = `((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 561, 1) >> 1))`
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `longRangeRate` = `int(((debuf.Level * 0.5) + 0.5))` when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 561, 1) lt 1 OR (EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData()) & 0xfffffffe) ne 12 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 561, 1) ge 1 OR (EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) - 17) hi 1 AND (EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData()) & 0xfffffffe) eq 12 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 561, 1) ge 1
  - `shortRangeRate` = `(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 561, 1) >> 1)` when (EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) - 17) ls 1 AND (EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData()) & 0xfffffffe) eq 12 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 561, 1) ge 1
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:FocusBuf$$.ctor<-FocusAction$$ValidDebuff` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

Parameter meanings (inferred from the `SkillBufferId` names):

- `LongRangeRate`: long-range damage %
- `ShortRangeRate`: short-range damage %

**In-game level notes**

- Lv12: เป้าหมายจะถูกยิงเร็วขึ้นด้วยสกิล[แซทเทิลไลท์แอร์โรว์] และจะเล็งเป้าหมายใหม่ทุกครั้งที่โจมตี
- Lv13: หลังจากยิงเป้าหมายด้วย[แซทเทิลไลท์แอร์โรว์] ครั้งแรกไปแล้วจะยิงครั้งถัดไปได้เร็วขึ้น
- Lv18: [ได้รับผลแบบเดียวกันเมื่อใช้กับโล่]  *เพิ่ม “พลังโจมตีระยะใกล้กับเป้าหมาย” ด้วยผลของบัฟ (ตั้งแต่สกิลเลเวล 2)

**Where else this skill takes effect**

- Effect applied in `FocusBuf$$.ctor` (4 guarded paths):
  - when `SkillLv(561) ge 1`
    - returns `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)`
    - set `longRangeRate` = `int((([debuf+0x30] * 0.5) + 0.5))`
    - set `shortRangeRate` = `(SkillLv(561) >> 1)`
    - calls `SkillBufferDataBase$$.ctor`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_WeaponItemType`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeaponItemType`
  - when `SkillLv(561) ge 1`
    - returns `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)`
    - set `longRangeRate` = `int((([debuf+0x30] * 0.5) + 0.5))`
    - calls `SkillBufferDataBase$$.ctor`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_WeaponItemType`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeaponItemType`
  - when `SkillLv(561) ge 1`
    - returns `EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3)`
    - set `longRangeRate` = `int((([debuf+0x30] * 0.5) + 0.5))`
    - calls `SkillBufferDataBase$$.ctor`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_WeaponItemType`
  - when `SkillLv(561) lt 1`
    - returns `SkillLv(561)`
    - set `longRangeRate` = `int((([debuf+0x30] * 0.5) + 0.5))`
    - calls `SkillBufferDataBase$$.ctor`, `virtual PlayerStatusBase.get_SkillManager`
- Code that reads this skill's level / buff by constant id: `FocusBuf$$.ctor (GetSkillLv)`

_Raw recovered data (every method item): [trees/HunterSkill.md](../trees/HunterSkill.md) — uid 561_

---
