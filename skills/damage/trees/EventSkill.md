# EventSkill (`EventSkill`)

3 entries. See ../README.md for how to read these blocks.

### ท่อเหล็ก (IronPipe) · uid 1249

<img src="../../icons/sk_1249.png" width="40" alt="icon"> 
**Type:** Attack · **Max Lv:** 1 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Client class:** `IronPipeAction`

> เอาไว้ใช้ฆ่าซอมบี้ได้
> 
> อัตราคริติคอลสำหรับการโจมตีในบริเวณแคบจะลดลง
> แต่ถ้าติดคริติคอลจะทำให้หวาดกลัว

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((int((baseSTR / 2.5)) + ((Lv + (Lv << 2)) + 50))) / 100)`

**Role:** attack (deals damage) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillRate` multiplies by (adds into): `(((int((baseSTR / 2.5)) + ((Lv + (Lv << 2)) + 50))) / 100)`

**Mechanics recovered from code**

- **Effect radius (Unity units)** (`Radius`): `MathUtil.DisplayMeterToDistance(0.5)`; `MathUtil.DisplayMeterToDistance(2)`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1249

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(4)`
- set `Radius` = `MathUtil.DisplayMeterToDistance(0.5)`
- set `Element` = `7` = 7
- set `skillRate` = `(int((baseSTR / 2.5)) + ((Lv + (Lv << 2)) + 50))`
- set `criticalRate` = `(Lv + (Lv << 2))` = 5

**`InitializeOthers`** (1 path)

- set `Element` = `7` = 7
- set `ActionRange` = `-1` = -1

**`ActionStart`** (3 paths)

- set `attackTarget` = `target` — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(target)

**`calcPlayerToMobDamage`** (8 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(1, 100, playerAction)`
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(1, 0)` — when PlayerAttackBase.checkAbnormalPercent(this, 1, 100, playerAction)
- info `templates` = `1`

**`ActionSkillEvent`** (4 paths)

- set `invincibilityId` = `AbnormalStateManager.AddInvincibilityTemporarilyInAction(PlayerActionManagerBase.get_AbnormalStatusManager(), 1)` — when UnityEngine.Object.op_Inequality(actarAction) AND param eq 101 AND param ne 102

**`OnInitializeEventRoom`** (1 path)

- set `Radius` = `MathUtil.DisplayMeterToDistance(2)`
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(2)`

</details>

---

### เรโทรโบว์กัน (RetroBowgun) · uid 1250

<img src="../../icons/sk_1250.png" width="40" alt="icon"> 
**Type:** Attack · **Max Lv:** 1 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Client class:** `RetroBowgunAction`

> โบว์กันประดับที่ดูไม่น่ามีอานุภาพ
> 
> ยิ่งโจมตีเป้าหมายไกลออกไปจะทำให้เป็นปรปักษ์
> และผลที่ได้จะยิ่งสูงขึ้น (6mขึ้นไป/9mขึ้นไป)

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((int((baseDEX / 2.5)) + ((Lv + (Lv << 2)) + 50))) / 100)`

**Role:** attack (deals damage)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(100)`
- `SkillRate` multiplies by (adds into): `(((int((baseDEX / 2.5)) + ((Lv + (Lv << 2)) + 50))) / 100)`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1250

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`
- set `Element` = `7` = 7
- set `skillRate` = `(int((baseDEX / 2.5)) + ((Lv + (Lv << 2)) + 50))`
- set `fixAddDamage` = `100` = 100

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`ActionStart`** (3 paths)

- set `SkillIndividualFlag` = `MobActionManagerBase.get_PlayerMeterDistance(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))` — when MobActionManagerBase.get_IsPlayerManaged(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)) AND UnityEngine.Object.op_Inequality(target)

**`calcPlayerToMobDamage`** (2 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- info `templates` = `1`

**`OnInitializeEventRoom`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`

</details>

---

### แม็กนั่ม (Magnum) · uid 1251

<img src="../../icons/sk_1251.png" width="40" alt="icon"> 
**Type:** Attack · **Max Lv:** 1 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Client class:** `MagnumAction`

> อาวุธจากต่างโลกที่ได้รับการดัดแปลง
> 
> โจมตีเป้าหมายด้วยการันตีคริติคอล
> แต่มีแรงสะท้อนสูงทำให้แม่นยำได้ยาก
> จำนวนครั้งที่ใช้จะเพิ่มขึ้นเมื่อเวลาต่อสู้ผ่านไป

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 40 | 80 | 120 | 160 | 200 | 240 | 280 | 320 | 360 | 400 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((status.Lv + (Lv * 100))) / 100)`

**Role:** attack (deals damage) · buff (self)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv + (Lv << 2)) << 3))`
- `SkillRate` multiplies by (adds into): `(((status.Lv + (Lv * 100))) / 100)`
- `ExpRate` sets: `(target.ExpDefMagic / 100)`

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Physics`, action id 1251

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `Element` = `1` = 1
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(18)`
- set `skillRate` = `(status.Lv + (Lv * 100))`
- set `fixAddDamage` = `((Lv + (Lv << 2)) << 3)` = 40

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`calcPlayerToMobDamage`** (7 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- template `SetRate[ExpRate]` = `(target.ExpDefMagic / 100)`
- info `templates` = `1`

**`OnInitializeEventRoom`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(18)`

</details>

**Buffs**

**Buff `MagnumBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `ActiveMagnumCount`, `InactiveMagnumCount`, `SetSkillParam`
- `Count` = `(count)`
- `HitRate` = `0` _(when BuffEffectActive eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| HitRate | -94 | -93 | -92 | -91 | -90 | -89 | -88 | -87 | -86 | -85 |

- Buff fields set in the constructor (all recovered):
  - `Count` = `count`
  - `hitRate` = `(95 - lv)` = 94
  - `BuffEffectActive` = `0`
- Hook `Updata`: `intervalTimer`=(20 - Lv); `intervalTimer`=(intervalTimer - UnityEngine.Time.get_deltaTime())
- Hook `ActiveMagnumCount`: `isInterval`=1; `Level`=lv; `intervalTimer`=(20 - lv)
- Hook `InactiveMagnumCount`: `isInterval`=0
- Hook `SetSkillParam`: `Level`=lv; `hitRate`=((((((baseTEC // 3) - baseTEC) >> 1) + (((baseTEC // 3) - baseTEC) >> 31)) - lv) + 95)

<details><summary>Effect applied in `MagnumAction$$IsFailure` (4 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1251, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `0`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1251, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1251, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1251, stkp(-24), 0) & 1) eq 0`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`

</details>

<details><summary>Effect applied in `MagnumAction$$calcPlayerToMobDamage` (7 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 1251, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `?blr`
  - template `AddRate[SkillRate]` = `(skillRate / 100)`
  - template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
  - template `SetRate[ExpRate]` = `(IMobStatusCalculator.get_ExpDefMagic(MobActionManagerBase.get_MobBattleStatus(mobAction)) / 100)`
  - calls `MagnumBuf$$SetSkillParam`, `0x165db78`, `SkillCalcTemplate$$.ctor`, `virtual MagnumAction.get_AttackType`, `PlayerAttackBase$$TemplateAssignment`, `interface MobActionManagerBase.get_MobBattleStatus`, `interface IMobStatusCalculator.get_ExpDefMagic`, `0x165db78`
- when `(SkillBufferManager.TryGetBuf(?blr, 1251, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `?blr`
  - template `AddRate[SkillRate]` = `(skillRate / 100)`
  - template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
  - template `SetRate[ExpRate]` = `(IMobStatusCalculator.get_ExpDefMagic(MobActionManagerBase.get_MobBattleStatus(mobAction)) / 100)`
  - calls `MagnumBuf$$SetSkillParam`, `0x165db78`, `SkillCalcTemplate$$.ctor`, `virtual MagnumAction.get_AttackType`, `PlayerAttackBase$$TemplateAssignment`, `interface MobActionManagerBase.get_MobBattleStatus`, `interface IMobStatusCalculator.get_ExpDefMagic`, `0x165db78`
- when `(SkillBufferManager.TryGetBuf(?blr, 1251, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `0x165db84`, `0x165df00`
- when `(SkillBufferManager.TryGetBuf(?blr, 1251, stkp(-56), 0) & 1) eq 0` AND `TryGetBuf.out2() ne 0`
  - returns `?blr`
  - template `AddRate[SkillRate]` = `(skillRate / 100)`
  - template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
  - template `SetRate[ExpRate]` = `(IMobStatusCalculator.get_ExpDefMagic(MobActionManagerBase.get_MobBattleStatus(mobAction)) / 100)`
  - calls `0x165db78`, `SkillCalcTemplate$$.ctor`, `virtual MagnumAction.get_AttackType`, `PlayerAttackBase$$TemplateAssignment`, `interface MobActionManagerBase.get_MobBattleStatus`, `interface IMobStatusCalculator.get_ExpDefMagic`, `0x165db78`, `SkillActionBase.DamageData$$.ctor`
- when `(SkillBufferManager.TryGetBuf(?blr, 1251, stkp(-56), 0) & 1) eq 0` AND `TryGetBuf.out2() eq 0`
  - returns `TryGetBuf.out2()`
  - template `AddRate[SkillRate]` = `(skillRate / 100)`
  - template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
  - template `SetRate[ExpRate]` = `(IMobStatusCalculator.get_ExpDefMagic(MobActionManagerBase.get_MobBattleStatus(mobAction)) / 100)`
  - calls `0x165db78`, `SkillCalcTemplate$$.ctor`, `virtual MagnumAction.get_AttackType`, `PlayerAttackBase$$TemplateAssignment`, `interface MobActionManagerBase.get_MobBattleStatus`, `interface IMobStatusCalculator.get_ExpDefMagic`, `0x165db78`, `SkillActionBase.DamageData$$.ctor`
- when `(SkillBufferManager.TryGetBuf(?blr, 1251, stkp(-56), 0) & 1) eq 0` AND `TryGetBuf.out2() ne 0`
  - returns `?blr`
  - template `AddRate[SkillRate]` = `(skillRate / 100)`
  - template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
  - template `SetRate[ExpRate]` = `(IMobStatusCalculator.get_ExpDefMagic(MobActionManagerBase.get_MobBattleStatus(mobAction)) / 100)`
  - calls `0x165db78`, `SkillCalcTemplate$$.ctor`, `virtual MagnumAction.get_AttackType`, `PlayerAttackBase$$TemplateAssignment`, `interface MobActionManagerBase.get_MobBattleStatus`, `interface IMobStatusCalculator.get_ExpDefMagic`, `0x165db78`, `SkillActionBase.DamageData$$.ctor`
- when `(SkillBufferManager.TryGetBuf(?blr, 1251, stkp(-56), 0) & 1) eq 0` AND `TryGetBuf.out2() eq 0`
  - returns `TryGetBuf.out2()`
  - template `AddRate[SkillRate]` = `(skillRate / 100)`
  - template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
  - template `SetRate[ExpRate]` = `(IMobStatusCalculator.get_ExpDefMagic(MobActionManagerBase.get_MobBattleStatus(mobAction)) / 100)`
  - calls `0x165db78`, `SkillCalcTemplate$$.ctor`, `virtual MagnumAction.get_AttackType`, `PlayerAttackBase$$TemplateAssignment`, `interface MobActionManagerBase.get_MobBattleStatus`, `interface IMobStatusCalculator.get_ExpDefMagic`, `0x165db78`, `SkillActionBase.DamageData$$.ctor`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `MagnumAction$$IsFailure (TryGetBuf)`
- `MagnumAction$$calcPlayerToMobDamage (TryGetBuf)`
- `ReceiveSupportResult$$OnEventPlayerSupport (GetSkillLv)`

---
