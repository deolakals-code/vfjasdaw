# シールドスキル (`ShieldSkill`)

14 entries. See ../README.md for how to read these blocks.

### ชีลด์มาสเตอรี่ (ShieldMastary) · uid 257

<img src="../../icons/sk_257.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 5 · **Weapons:** Shield · **Flags:** StarGem · **Client class:** `ShieldMastary` (passive mastery)

> อัพเกรดความเร็วการโจมตีเมื่อติดตั้งโล่

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| AspdRate | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |


---

### โพรเทคชั่น (Protection) · uid 263

<img src="../../icons/sk_263.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 1) · **Type:** Support · **Max Lv:** 5 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `ProtectionAction`

> เพิ่มความต้านทานทางกายภาพให้สมาชิกปาร์ตี้ชั่วขณะ
> แต่การต้านทานเวทจะลดลง

<details><summary>In-game level notes</summary>

- Lv17: *MP ที่ใช้-200

</details>

**Role:** buff (self) · buff (party / others)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **MP cost** (`mp`): `(mp - 200)` _(when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 AND UnityEngine.Object.op_Inequality(actarAction))_
- **Cast time modifier** (`CastTime`): `SkillUtil.CalcCastTime(0, PlayerStatusBase.get_BattleStatus())`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 263

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (3 paths)

- set `mp` = `(mp - 200)` — when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 AND UnityEngine.Object.op_Inequality(actarAction)
- set `ActionRange` = `-1` = -1
- set `CastTime` = `SkillUtil.CalcCastTime(0, PlayerStatusBase.get_BattleStatus())`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (3 paths)

- calls `ProtectionBuf..ctor` = `.ctor(Lv)` — when !hasGemCart(1036) OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 264, 1) ge 1 AND hasGemCart(1036) OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 264, 1) lt 1 AND hasGemCart(1036)
- calls `SkillBufferManager.AddBuffer` = `AddBuffer(new ProtectionBuf, 0)` — when !hasGemCart(1036) OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 264, 1) ge 1 AND hasGemCart(1036) OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 264, 1) lt 1 AND hasGemCart(1036)
- calls `AegisBuf..ctor` = `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 264, 1))` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 264, 1) ge 1 AND hasGemCart(1036)
- calls `SkillBufferManager.AddBuffer` = `AddBuffer(new AegisBuf, 0)` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 264, 1) ge 1 AND hasGemCart(1036)

</details>

**Buffs**

**Buff `AegisBuf`**
- Duration: `(Lv * 60)` s

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MagicDmgCut | 10 | 10 | 15 | 15 | 15 | 20 | 20 | 20 | 25 | 25 |
| PowerDmgCut | -35 | -35 | -30 | -30 | -30 | -25 | -25 | -25 | -20 | -20 |

- Buff fields set in the constructor (all recovered):
  - `isViewSelfIcon` = `IsSelfAction`
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `SetViewSelfIcon`: `isViewSelfIcon`=(flag & 1)
**Buff `ProtectionBuf`**
- Duration: `(Lv * 60)` s

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| PowerDmgCut | 10 | 10 | 15 | 15 | 15 | 20 | 20 | 20 | 25 | 25 |
| MagicDmgCut | -35 | -35 | -30 | -30 | -30 | -25 | -25 | -25 | -20 | -20 |

- Buff fields set in the constructor (all recovered):
  - `IsSelfAction` = `1` = 1
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5]
  - `BuffEffectActive` = `257` = 257
  - `BufEffectTakeUid` = `-1` = -1
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
- Hook `SetViewSelfIcon`: `isViewSelfIcon`=(flag & 1)
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:AegisBuf$$.ctor<-ProtectionAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

<details><summary>Effect applied in `AegisAction$$ActionHit` (2 guarded paths)</summary>

- when `SkillLv(263) ge 1`
  - calls `0x165db78`, `AegisBuf$$.ctor`, `SkillBufferManager$$AddBuffer`, `0x165db78`, `ProtectionBuf$$.ctor`, `SkillBufferManager$$AddBuffer`
- when `SkillLv(263) lt 1`
  - returns `SkillLv(263)`
  - calls `0x165db78`, `AegisBuf$$.ctor`, `SkillBufferManager$$AddBuffer`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `AegisAction$$ActionHit (GetSkillLv)`

---

### ชีลด์บาช (ShieldBash) · uid 258

<img src="../../icons/sk_258.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 2) · **Type:** Attack · **Max Lv:** 20 · **Weapons:** Shield · **Requires:** ชีลด์มาสเตอรี่ · **Flags:** MercenaryCanUseSkill · **Client class:** `ShieldBashAction`

> อัดด้วยโล่เต็มแรง
> มีโอกาสทำให้เป้าหมาย[หมดสติ]

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.01 | 0.03 | 0.04 | 0.06 | 0.07 | 0.09 | 0.1 | 0.12 | 0.13 | 0.15 |
| Flat dmg + | 55 | 60 | 65 | 70 | 75 | 80 | 85 | 90 | 95 | 100 |

**Role:** attack (deals damage) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv + (Lv << 2)) + 50))`
- `SkillRate` multiplies by (adds into): `((int((Lv * 1.5)) / 100))`

**Mechanics recovered from code**

- **Stun chance (%)** (`stunPercent`): `(int((Lv * 2.5)) + 75)` → Lv1..10 [77, 80, 82, 85, 87, 90, 92, 95, 97, 100]

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 258

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (2 paths)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(3)`
- set `skillRate` = `(int((Lv * 1.5)) / 100)` → Lv1..10: [0.01, 0.03, 0.04, 0.06, 0.07, 0.09, 0.1, 0.12, 0.13, 0.15]
- set `fixAddDamage` = `((Lv + (Lv << 2)) + 50)` → Lv1..10: [55, 60, 65, 70, 75, 80, 85, 90, 95, 100]
- set `stunPercent` = `(int((Lv * 2.5)) + 75)` → Lv1..10: [77, 80, 82, 85, 87, 90, 92, 95, 97, 100]

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`

**`calcPlayerToMobDamage`** (8 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)`
- template `AddRate[SkillRate]` = `skillRate`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(3, stunPercent, playerAction)`
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(3, 0)` — when PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)
- info `templates` = `1`

</details>

---

### ฟอร์ชชีลด์ (ForceShield) · uid 259

<img src="../../icons/sk_259.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 20 · **Weapons:** Shield · **Requires:** ชีลด์มาสเตอรี่ · **Client class:** `ForceShield` (passive mastery)

> เพิ่ม DEF และการต้านทานอาวุธ
> เมื่อติดตั้งโล่

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Def | 6 | 8 | 9 | 11 | 12 | 14 | 15 | 17 | 18 | 20 |
| MaxHp | 50 | 100 | 150 | 200 | 250 | 300 | 350 | 400 | 450 | 500 |
| CutDmgRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| DefRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


---

### อีจิส (Aegis) · uid 264

<img src="../../icons/sk_264.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 2) · **Type:** Support · **Max Lv:** 20 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** โพรเทคชั่น · **Flags:** MercenaryCanUseSkill · **Client class:** `AegisAction`

> เพิ่มการต้านทานเวทให้สมาชิกปาร์ตี้ชั่วขณะ
> แต่ความต้านทานทางกายภาพจะลดลง

<details><summary>In-game level notes</summary>

- Lv17: *MP ที่ใช้-200

</details>

**Role:** buff (self) · buff (party / others)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **MP cost** (`mp`): `(mp - 200)` _(when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 AND UnityEngine.Object.op_Inequality(actarAction))_
- **Cast time modifier** (`CastTime`): `SkillUtil.CalcCastTime(0, PlayerStatusBase.get_BattleStatus())`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 264

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (3 paths)

- set `mp` = `(mp - 200)` — when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 AND UnityEngine.Object.op_Inequality(actarAction)
- set `ActionRange` = `-1` = -1
- set `CastTime` = `SkillUtil.CalcCastTime(0, PlayerStatusBase.get_BattleStatus())`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (3 paths)

- calls `AegisBuf..ctor` = `.ctor(Lv)` — when !hasGemCart(1036) OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 263, 1) ge 1 AND hasGemCart(1036) OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 263, 1) lt 1 AND hasGemCart(1036)
- calls `SkillBufferManager.AddBuffer` = `AddBuffer(new AegisBuf, 0)` — when !hasGemCart(1036) OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 263, 1) ge 1 AND hasGemCart(1036) OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 263, 1) lt 1 AND hasGemCart(1036)
- calls `ProtectionBuf..ctor` = `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 263, 1))` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 263, 1) ge 1 AND hasGemCart(1036)
- calls `SkillBufferManager.AddBuffer` = `AddBuffer(new ProtectionBuf, 0)` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 263, 1) ge 1 AND hasGemCart(1036)

</details>

**Buffs**

**Buff `AegisBuf`**
- Duration: `(Lv * 60)` s

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MagicDmgCut | 10 | 10 | 15 | 15 | 15 | 20 | 20 | 20 | 25 | 25 |
| PowerDmgCut | -35 | -35 | -30 | -30 | -30 | -25 | -25 | -25 | -20 | -20 |

- Buff fields set in the constructor (all recovered):
  - `isViewSelfIcon` = `IsSelfAction`
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `SetViewSelfIcon`: `isViewSelfIcon`=(flag & 1)
**Buff `ProtectionBuf`**
- Duration: `(Lv * 60)` s

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| PowerDmgCut | 10 | 10 | 15 | 15 | 15 | 20 | 20 | 20 | 25 | 25 |
| MagicDmgCut | -35 | -35 | -30 | -30 | -30 | -25 | -25 | -25 | -20 | -20 |

- Buff fields set in the constructor (all recovered):
  - `IsSelfAction` = `1` = 1
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `BuffEffectActive` = `257` = 257
  - `BufEffectTakeUid` = `-1` = -1
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
- Hook `SetViewSelfIcon`: `isViewSelfIcon`=(flag & 1)
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:AegisBuf$$.ctor<-AegisAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

<details><summary>Effect applied in `ProtectionAction$$ActionHit` (2 guarded paths)</summary>

- when `SkillLv(264) ge 1`
  - calls `0x165db78`, `ProtectionBuf$$.ctor`, `SkillBufferManager$$AddBuffer`, `0x165db78`, `AegisBuf$$.ctor`, `SkillBufferManager$$AddBuffer`
- when `SkillLv(264) lt 1`
  - returns `SkillLv(264)`
  - calls `0x165db78`, `ProtectionBuf$$.ctor`, `SkillBufferManager$$AddBuffer`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `ProtectionAction$$ActionHit (GetSkillLv)`

---

### ชีลด์อัปเปอร์คัต (ShieldUpper) · uid 266

<img src="../../icons/sk_266.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 2) · **Type:** Attack · **Max Lv:** 20 · **Weapons:** Shield · **Requires:** ชีลด์มาสเตอรี่ · **Client class:** `ShieldUpperAction`

> เสยหมัดอย่างรุนแรงพร้อมโล่
> มีโอกาสที่เป้าหมายจะติด [ล้มคว่ำ]
> ความเสียหายที่ได้รับจะลดลง
> และเปิดใช้ Guard โดยอัตโนมัติระหว่างใช้สกิลนี้

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.15 | 0.3 | 0.45 | 0.6 | 0.75 | 0.9 | 1.05 | 1.2 | 1.35 | 1.5 |
| Flat dmg + | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255)) * Lv) + (((Lv << 4) - Lv))) / 100)` — !AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(mobAction), 2) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)

**Role:** attack (deals damage) · buff (self) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(100)`
- `SkillRate` multiplies by (adds into): `((((Lv << 4) - Lv)) / 100)` | `(((((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255)) * Lv) + (((Lv << 4) - Lv))) / 100)`

**Mechanics recovered from code**

- **Effect percent** (`percent`): `((Lv + (Lv << 2)) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 266

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `Element` = `7` = 7
- set `constantDamage` = `100` = 100
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(4)`
- set `skillRate` = `((Lv << 4) - Lv)` → Lv1..10: [15, 30, 45, 60, 75, 90, 105, 120, 135, 150]
- set `percent` = `((Lv + (Lv << 2)) << 1)` → Lv1..10: [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`

**`ActionPreparation`** (5 paths)

- set `shieldRefine` = `(ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255)` — when !PlayerAttackBase.IsBlank(this) AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 AND UnityEngine.Object.op_Inequality(actarAction) OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 AND PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction)
- calls `ShieldUpperBuf..ctor` = `.ctor(Lv, (ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255))` — when !PlayerAttackBase.IsBlank(this) AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 AND UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new ShieldUpperBuf, Id)` — when !PlayerAttackBase.IsBlank(this) AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 17 AND UnityEngine.Object.op_Inequality(actarAction)
- calls `ShieldUpperBuf..ctor` = `.ctor(Lv, shieldRefine)` — when !PlayerAttackBase.IsBlank(this) AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 17 AND UnityEngine.Object.op_Inequality(actarAction)

**`calcPlayerToMobDamage`** (10 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)` — when !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)
- template `AddConstant[SkillConstantDamage]` = `constantDamage`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(2, percent, playerAction)` — when !PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(mobAction), 2) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)
- info `templates` = `1`
- template `AddRate[SkillRate]` = `(((shieldRefine * Lv) + skillRate) / 100)` — when !AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(mobAction), 2) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(2, 0)` — when !AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(mobAction), 2) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(mobAction), 2) AND PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)

**`.<>c__DisplayClass22_0::<ActionPreparation>b__0`** (1 path)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(266)`

**`.<>c__DisplayClass22_0::<ActionPreparation>b__1`** (2 paths)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(266)` — when (cancel & 1) ne 0

**`via PlayerAttackBase$$HitReactionAssign`** (3467 paths)

- calls `MathUtil.CheckPercent` = `CheckPercent()` — when !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) eq 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3
- template `SetCalcValue[GuardPower]` = `System.Math.Max(0, (25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4))))` — when !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType ne 2 AND comboType ne 3
- template `SetCalcValue[GuardPower]` = `25` — when !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType ne 2 AND comboType ne 3

</details>

**Buffs**

**Buff `ShieldUpperBuf`**
- `MobLastDamageRateUnique` = `((((((Lv << 1) + lv) + ((Lv * shieldRefine) // 5)) + 39) lt 99 ? ((((Lv << 1) + lv) + ((Lv * shieldRefine) // 5)) + 39) : 99))` _(when BuffEffectActive ne 0)_
- `MobLastDamageRateUnique` = `0` _(when BuffEffectActive eq 0)_
- Buff fields set in the constructor (all recovered):
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
  - `BufEffectTakeUid` = `-1` = -1
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `damageCut` = `(((((Lv << 1) + lv) + ((Lv * shieldRefine) // 5)) + 39) lt 99 ? ((((Lv << 1) + lv) + ((Lv * shieldRefine) // 5)) + 39) : 99)`

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

### ชีลด์แคนนอน (ShieldCannon) · uid 260

<img src="../../icons/sk_260.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 3) · **Type:** Attack · **Max Lv:** 50 · **Weapons:** Shield · **Requires:** ชีลด์บาช · **Flags:** MercenaryCanUseSkill · **Client class:** `ShieldCannonAction`

> ขว้างโล่ออกไปเต็มแรงเหมือนกระสุนปืนใหญ่
> มีโอกาสทำให้เป้าหมายหมดสติ
> ถ้าทำให้หมดสติสำเร็จพลังโจมตีจะเพิ่มขึ้น

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.6 | 0.7 | 0.8 | 0.9 | 1 | 1.1 | 1.2 | 1.3 | 1.4 | 1.5 |
| Flat dmg + | 110 | 120 | 130 | 140 | 150 | 160 | 170 | 180 | 190 | 200 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((((Lv * 10) + 50) / 100))` — !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) & !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)
- SkillRate × `(((((Lv * 10) + 50) / 100)) * (((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255) ne 0 ? ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) : 1) & 255))` — !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)
- SkillRate × `(((((Lv * 10) + 50) / 100)) * (((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255) ne 0 ? ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) : 1) & 255))` — !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) & !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)
- Flat dmg + `((((Lv + (Lv << 2)) << 1) + 100))` — !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) & !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)
- Flat dmg + `(int(((((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255) / 5) + 1) * baseVIT)) + ((((Lv + (Lv << 2)) << 1) + 100)))` — !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)
- Flat dmg + `(int(((((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255) / 5) + 1) * baseVIT)) + ((((Lv + (Lv << 2)) << 1) + 100)))` — !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) & !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)

**Role:** attack (deals damage) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `((((Lv + (Lv << 2)) << 1) + 100))` | `(int(((((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255) / 5) + 1) * baseVIT)) + ((((Lv + (Lv << 2)) << 1) + 100)))`
- `SkillRate` multiplies by (adds into): `((((Lv * 10) + 50) / 100))` | `(((((Lv * 10) + 50) / 100)) * (((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255) ne 0 ? ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) : 1) & 255))`

**Mechanics recovered from code**

- **Stun chance (%)** (`stunPercent`): `((Lv + (Lv << 2)) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 260

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `Element` = `5` = 5
- set `ActionRange` = `MathUtil.DisplayMeterToDistance((int((Lv * 1.5)) + 5))`
- set `fixAddDamage` = `(((Lv + (Lv << 2)) << 1) + 100)` → Lv1..10: [110, 120, 130, 140, 150, 160, 170, 180, 190, 200]
- set `skillRate` = `(((Lv * 10) + 50) / 100)` → Lv1..10: [0.6, 0.7, 0.8, 0.9, 1.0, 1.1, 1.2, 1.3, 1.4, 1.5]
- set `stunPercent` = `((Lv + (Lv << 2)) << 1)` → Lv1..10: [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`

**`calcPlayerToMobDamage`** (12 paths)

- template `AddRate[SkillRate]` = `skillRate` — when !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage` — when !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(3, stunPercent, playerAction)` — when !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)
- info `templates` = `1`
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(3, 0)` — when !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyMobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)
- set `skillRate` = `(skillRate * (((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255) ne 0 ? ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) : 1) & 255))` — when !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)
- set `fixAddDamage` = `(int(((((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255) / 5) + 1) * baseVIT)) + fixAddDamage)` — when !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)
- set `SkillIndividualFlag` = `1` = 1 — when !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)
- template `AddRate[SkillRate]` = `(skillRate * (((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255) ne 0 ? ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) : 1) & 255))` — when !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)
- template `AddConstant[SkillConstantDamage]` = `(int(((((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255) / 5) + 1) * baseVIT)) + fixAddDamage)` — when !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)

**`via PlayerAttackBase$$HitReactionAssign`** (3467 paths)

- calls `MathUtil.CheckPercent` = `CheckPercent()` — when !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) eq 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3
- template `SetCalcValue[GuardPower]` = `System.Math.Max(0, (25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4))))` — when !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType ne 2 AND comboType ne 3
- template `SetCalcValue[GuardPower]` = `25` — when !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType ne 2 AND comboType ne 3

</details>

---

### เมจิกคัลชีลด์ (MagicalShield) · uid 261

<img src="../../icons/sk_261.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 50 · **Weapons:** Shield · **Requires:** ฟอร์ชชีลด์ · **Client class:** `MagicalShield` (passive mastery)

> เพิ่ม MDEF และการต้านทานเวทย์
> เมื่อติดตั้งโล่

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| CutDmgRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| MdefRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| Mdef | 6 | 8 | 9 | 11 | 12 | 14 | 15 | 17 | 18 | 20 |
| MaxHp | 50 | 100 | 150 | 200 | 250 | 300 | 350 | 400 | 450 | 500 |


---

### ดูอัลชีลด์ (PairOfShields) · uid 267

<img src="../../icons/sk_267.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 3) · **Type:** Buffer · **Max Lv:** 50 · **Weapons:** Shield · **Requires:** ชีลด์อัปเปอร์คัต · **Client class:** `PairOfShieldsAction`

> เจตจำนงอันแรงกล้าจะกลายเป็นป้อมปราการที่แข็งแกร่ง
> ติดตั้งโล่คู่
> และรักษาสถานะ Guard ระหว่างการต่อสู้
> หากติดตั้งเกราะหนักจะเพิ่มระยะ Guard
> และลดช่วงเวลาการโจมตีปกติ

**Role:** buff (self) · changes attack pattern (motion / combo chain; heuristic) · boosts normal-attack damage

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 267

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (4 paths)

- calls `PairOfShieldsBuf..ctor` = `.ctor(Lv, actarAction)` — when UnityEngine.Object.op_Inequality(actarAction) OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 82) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 82) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new PairOfShieldsBuf, Id)` — when UnityEngine.Object.op_Inequality(actarAction) OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 82) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 82) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)

</details>

**Buffs**

**Buff `PairOfShieldsBuf`**
- **Changes the attack pattern**: the buff object drives a motion/combo chain (`get_BufEffectTakeId`).
- **Boosts normal-attack damage** through the `NormalAttackRate` / `NormalAttackConstantDamage` parameters.
- Buff hook methods: `BufferEnd`, `CheckPairOfShieldsTake`, `TakeStop`, `get_BufEffectTakeId`
- Duration: `(LeftTime + (ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255))` s [EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17]
- `NormalAttackRate` = `(((baseVIT // 5) + ((Lv + (Lv << 2)) << 1)))` _(when BuffEffectActive ne 0)_
- `HitUp` = `((hit + EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function))` _(when BuffEffectActive ne 0)_
- `AspdRate` = `((aspdRate + ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()))))` _(when BuffEffectActive ne 0)_
- Buff fields set in the constructor (all recovered):
  - `isBattleActive` = `1` = 1
  - `playerAction` = `playerAction`
  - `status` = `PlayerActionManagerBase.get_PlayerStatus()`
  - `takeController` = `playerAction.TakeController`
  - `effectManager` = `PlayerActionManagerBase.get_BufferEffectManager()`
  - `normalAttackRate` = `((baseVIT // 5) + ((Lv + (Lv << 2)) << 1))`
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `aspdRate` = `(aspdRate + ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())))` when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17
  - `hit` = `(hit + EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function)` when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `updateShield`=0; `isBattleActive`=1; `isBattleActive`=(PlayerActionManagerBase.get_IsBattleActive(playerAction) & 1)
- Hook `BufferEnd`: `LeftTime`=0

<details><summary>Effect applied in `NormalAttackAction$$OnInitialize` (300 guarded paths, truncated)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 41, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() eq 1` AND `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-72), 0) & 1) ne 0`
  - returns `SkillBufferManager.SetBufferEffectActive(?blr, 678, 0, 0)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, meta(0), ?x2, ?x3)`
  - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-56), 0, ?x3)`
  - set `subWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, 0, ?x2, ?x3)`
  - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.out1(), 0, ?x2, ?x3)`
  - set `SkillIndividualFlag` = `(((((SkillIndividualFlag | 2) | 16) | 1024) | 0x2000) & 0xfffffe7f)`
  - set `defaultRange` = `0`
  - set `powerWaveRate` = `0`
  - set `damageCount` = `3`
  - set `sheatheMove` = `0x165db78(meta(0x399f8f8, SheatheMove_TypeInfo), ?x1, ?x2, ?x3)`
  - set `ChangeCriticalHitTake` = `0`
  - set `powerWaveMastery` = `0`
  - set `+0x13c` = `0`
  - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `MathUtil$$DisplayMeterToDistance`, `EquipItemData$$get_SubWeaponItemType`, `MathUtil$$DisplayMeterToDistance`
- when `(SkillBufferManager.TryGetBuf(?blr, 41, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() eq 1` AND `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-72), 0) & 1) ne 0`
  - returns `SkillBufferManager.SetBufferEffectActive(?blr, 678, 0, 0)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, meta(0), ?x2, ?x3)`
  - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-56), 0, ?x3)`
  - set `subWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, 0, ?x2, ?x3)`
  - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.out1(), 0, ?x2, ?x3)`
  - set `SkillIndividualFlag` = `(((((SkillIndividualFlag | 2) | 16) | 1024) | 0x2000) & 0xfffffe7f)`
  - set `defaultRange` = `0`
  - set `powerWaveRate` = `0`
  - set `damageCount` = `3`
  - set `sheatheMove` = `0x165db78(meta(0x399f8f8, SheatheMove_TypeInfo), ?x1, ?x2, ?x3)`
  - set `ChangeCriticalHitTake` = `0`
  - set `powerWaveMastery` = `0`
  - set `+0x13c` = `0`
  - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `MathUtil$$DisplayMeterToDistance`, `EquipItemData$$get_SubWeaponItemType`, `MathUtil$$DisplayMeterToDistance`
- when `(SkillBufferManager.TryGetBuf(?blr, 41, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() eq 1` AND `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-72), 0) & 1) ne 0`
  - returns `SkillBufferManager.SetBufferEffectActive(?blr, 678, 0, 0)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, meta(0), ?x2, ?x3)`
  - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-56), 0, ?x3)`
  - set `subWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, 0, ?x2, ?x3)`
  - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.out1(), 0, ?x2, ?x3)`
  - set `SkillIndividualFlag` = `(((((SkillIndividualFlag | 2) | 16) | 1024) | 0x2000) & 0xfffffe7f)`
  - set `defaultRange` = `0`
  - set `powerWaveRate` = `0`
  - set `damageCount` = `3`
  - set `sheatheMove` = `0x165db78(meta(0x399f8f8, SheatheMove_TypeInfo), ?x1, ?x2, ?x3)`
  - set `ChangeCriticalHitTake` = `0`
  - set `powerWaveMastery` = `0`
  - set `+0x13c` = `0`
  - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `MathUtil$$DisplayMeterToDistance`, `EquipItemData$$get_SubWeaponItemType`, `MathUtil$$DisplayMeterToDistance`
- when `(SkillBufferManager.TryGetBuf(?blr, 41, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() eq 1` AND `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-72), 0) & 1) ne 0`
  - returns `SkillBufferManager.SetBufferEffectActive(?blr, 678, 0, 0)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, meta(0), ?x2, ?x3)`
  - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-56), 0, ?x3)`
  - set `subWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, 0, ?x2, ?x3)`
  - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.out1(), 0, ?x2, ?x3)`
  - set `SkillIndividualFlag` = `(((((SkillIndividualFlag | 2) | 16) | 1024) | 0x2000) & 0xfffffe7f)`
  - set `defaultRange` = `0`
  - set `powerWaveRate` = `0`
  - set `damageCount` = `3`
  - set `sheatheMove` = `0x165db78(meta(0x399f8f8, SheatheMove_TypeInfo), ?x1, ?x2, ?x3)`
  - set `ChangeCriticalHitTake` = `0`
  - set `powerWaveMastery` = `0`
  - set `+0x13c` = `0`
  - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `MathUtil$$DisplayMeterToDistance`, `EquipItemData$$get_SubWeaponItemType`, `MathUtil$$DisplayMeterToDistance`
- when `(SkillBufferManager.TryGetBuf(?blr, 41, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() eq 1` AND `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-72), 0) & 1) ne 0`
  - returns `SkillBufferManager.SetBufferEffectActive(?blr, 678, 0, 0)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, meta(0), ?x2, ?x3)`
  - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-56), 0, ?x3)`
  - set `subWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, 0, ?x2, ?x3)`
  - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.out1(), 0, ?x2, ?x3)`
  - set `SkillIndividualFlag` = `(((((SkillIndividualFlag | 2) | 16) | 1024) | 0x2000) & 0xfffffe7f)`
  - set `defaultRange` = `0`
  - set `powerWaveRate` = `0`
  - set `damageCount` = `3`
  - set `sheatheMove` = `0x165db78(meta(0x399f8f8, SheatheMove_TypeInfo), ?x1, ?x2, ?x3)`
  - set `ChangeCriticalHitTake` = `0`
  - set `powerWaveMastery` = `0`
  - set `+0x13c` = `0`
  - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `MathUtil$$DisplayMeterToDistance`, `EquipItemData$$get_SubWeaponItemType`, `MathUtil$$DisplayMeterToDistance`
- when `(SkillBufferManager.TryGetBuf(?blr, 41, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() eq 1` AND `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-72), 0) & 1) ne 0`
  - returns `SkillBufferManager.SetBufferEffectActive(?blr, 678, 0, 0)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, meta(0), ?x2, ?x3)`
  - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-56), 0, ?x3)`
  - set `subWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, 0, ?x2, ?x3)`
  - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.out1(), 0, ?x2, ?x3)`
  - set `SkillIndividualFlag` = `(((((SkillIndividualFlag | 2) | 16) | 1024) | 0x2000) & 0xfffffe7f)`
  - set `defaultRange` = `0`
  - set `powerWaveRate` = `0`
  - set `damageCount` = `3`
  - set `sheatheMove` = `0x165db78(meta(0x399f8f8, SheatheMove_TypeInfo), ?x1, ?x2, ?x3)`
  - set `ChangeCriticalHitTake` = `0`
  - set `powerWaveMastery` = `0`
  - set `+0x13c` = `0`
  - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `MathUtil$$DisplayMeterToDistance`, `EquipItemData$$get_SubWeaponItemType`, `MathUtil$$DisplayMeterToDistance`
- when `(SkillBufferManager.TryGetBuf(?blr, 41, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() eq 1` AND `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-72), 0) & 1) ne 0`
  - returns `SkillBufferManager.SetBufferEffectActive(?blr, 678, 0, 0)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, meta(0), ?x2, ?x3)`
  - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-56), 0, ?x3)`
  - set `subWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, 0, ?x2, ?x3)`
  - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.out1(), 0, ?x2, ?x3)`
  - set `SkillIndividualFlag` = `(((((SkillIndividualFlag | 2) | 16) | 1024) | 0x2000) & 0xfffffe7f)`
  - set `defaultRange` = `0`
  - set `powerWaveRate` = `0`
  - set `damageCount` = `3`
  - set `sheatheMove` = `0x165db78(meta(0x399f8f8, SheatheMove_TypeInfo), ?x1, ?x2, ?x3)`
  - set `ChangeCriticalHitTake` = `0`
  - set `powerWaveMastery` = `0`
  - set `+0x13c` = `0`
  - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `MathUtil$$DisplayMeterToDistance`, `EquipItemData$$get_SubWeaponItemType`, `MathUtil$$DisplayMeterToDistance`
- when `(SkillBufferManager.TryGetBuf(?blr, 41, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() eq 1` AND `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-72), 0) & 1) ne 0`
  - returns `SkillBufferManager.SetBufferEffectActive(?blr, 678, 0, 0)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, meta(0), ?x2, ?x3)`
  - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-56), 0, ?x3)`
  - set `subWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, 0, ?x2, ?x3)`
  - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.out1(), 0, ?x2, ?x3)`
  - set `SkillIndividualFlag` = `(((((SkillIndividualFlag | 2) | 16) | 1024) | 0x2000) & 0xfffffe7f)`
  - set `defaultRange` = `0`
  - set `powerWaveRate` = `0`
  - set `damageCount` = `3`
  - set `sheatheMove` = `0x165db78(meta(0x399f8f8, SheatheMove_TypeInfo), ?x1, ?x2, ?x3)`
  - set `ChangeCriticalHitTake` = `0`
  - set `powerWaveMastery` = `0`
  - set `+0x13c` = `0`
  - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `MathUtil$$DisplayMeterToDistance`, `EquipItemData$$get_SubWeaponItemType`, `MathUtil$$DisplayMeterToDistance`

</details>

<details><summary>Effect applied in `BeragelungAction$$IsFailure` (2 guarded paths)</summary>

- always
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
- always
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`

</details>

<details><summary>Effect applied in `GuardActionManager$$CheckPairOfShieldsGuard` (4 guarded paths)</summary>

- when `CharacterActionManagerBase.get_IsLocalDead() ne 0`
  - returns `(CharacterActionManagerBase.get_IsLocalDead() eq 267 ? 1 : 0)`
  - calls `EquipItemData$$get_SubWeaponItemType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`
- when `CharacterActionManagerBase.get_IsLocalDead() eq 0`
  - returns `1`
  - calls `EquipItemData$$get_SubWeaponItemType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`
- always
  - returns `0`
  - calls `EquipItemData$$get_SubWeaponItemType`
- always
  - returns `0`
  - calls `EquipItemData$$get_SubWeaponItemType`

</details>

<details><summary>Effect applied in `PlayerActionManager$$SuccessAddAbnormal` (9 guarded paths)</summary>

- when `(type | 2) eq 18` AND `type eq 10` AND `(SkillBufferManager.TryGetBuf(?blr, 267, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `CrazyDaggerBuf.Damaged(this, type, 0, ?x3)`
  - calls `GoliathTakeShotAction$$ReceivedAbnormal`, `RampageAction$$ReceivedAbnormal`, `SkillBufferManager$$RemoveSelfBuffer`, `LunaDitherStarAction$$ReceivedAbnormal`, `PairOfShieldsBuf$$BufferEnd`, `ThorHammerAction$$ReceivedAbnormal`, `SlashReaperBuf$$ReceivedAbnormal`, `CrazyDaggerBuf$$Damaged`
- when `(type | 2) eq 18` AND `type eq 10` AND `(SkillBufferManager.TryGetBuf(?blr, 267, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `GoliathTakeShotAction$$ReceivedAbnormal`, `RampageAction$$ReceivedAbnormal`, `SkillBufferManager$$RemoveSelfBuffer`, `LunaDitherStarAction$$ReceivedAbnormal`, `0x165db84`, `0x165df00`
- when `(type | 2) eq 18` AND `type eq 10` AND `(SkillBufferManager.TryGetBuf(?blr, 267, stkp(-56), 0) & 1) eq 0`
  - returns `CrazyDaggerBuf.Damaged(this, type, 0, ?x3)`
  - calls `GoliathTakeShotAction$$ReceivedAbnormal`, `RampageAction$$ReceivedAbnormal`, `SkillBufferManager$$RemoveSelfBuffer`, `LunaDitherStarAction$$ReceivedAbnormal`, `ThorHammerAction$$ReceivedAbnormal`, `SlashReaperBuf$$ReceivedAbnormal`, `CrazyDaggerBuf$$Damaged`
- when `(type | 2) ne 18` AND `type eq 10` AND `(SkillBufferManager.TryGetBuf(?blr, 267, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `CrazyDaggerBuf.Damaged(this, type, 0, ?x3)`
  - calls `GoliathTakeShotAction$$ReceivedAbnormal`, `RampageAction$$ReceivedAbnormal`, `LunaDitherStarAction$$ReceivedAbnormal`, `PairOfShieldsBuf$$BufferEnd`, `ThorHammerAction$$ReceivedAbnormal`, `SlashReaperBuf$$ReceivedAbnormal`, `CrazyDaggerBuf$$Damaged`
- when `(type | 2) ne 18` AND `type eq 10` AND `(SkillBufferManager.TryGetBuf(?blr, 267, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `GoliathTakeShotAction$$ReceivedAbnormal`, `RampageAction$$ReceivedAbnormal`, `LunaDitherStarAction$$ReceivedAbnormal`, `0x165db84`, `0x165df00`
- when `(type | 2) ne 18` AND `type eq 10` AND `(SkillBufferManager.TryGetBuf(?blr, 267, stkp(-56), 0) & 1) eq 0`
  - returns `CrazyDaggerBuf.Damaged(this, type, 0, ?x3)`
  - calls `GoliathTakeShotAction$$ReceivedAbnormal`, `RampageAction$$ReceivedAbnormal`, `LunaDitherStarAction$$ReceivedAbnormal`, `ThorHammerAction$$ReceivedAbnormal`, `SlashReaperBuf$$ReceivedAbnormal`, `CrazyDaggerBuf$$Damaged`
- when `type eq 10` AND `(SkillBufferManager.TryGetBuf(?blr, 267, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `CrazyDaggerBuf.Damaged(this, type, 0, ?x3)`
  - calls `GoliathTakeShotAction$$ReceivedAbnormal`, `RampageAction$$ReceivedAbnormal`, `LunaDitherStarAction$$ReceivedAbnormal`, `PairOfShieldsBuf$$BufferEnd`, `ThorHammerAction$$ReceivedAbnormal`, `SlashReaperBuf$$ReceivedAbnormal`, `CrazyDaggerBuf$$Damaged`
- when `type eq 10` AND `(SkillBufferManager.TryGetBuf(?blr, 267, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `GoliathTakeShotAction$$ReceivedAbnormal`, `RampageAction$$ReceivedAbnormal`, `LunaDitherStarAction$$ReceivedAbnormal`, `0x165db84`, `0x165df00`

</details>

<details><summary>Effect applied in `PlayerBattleManager$$CheckZeroActionDelay` (14 guarded paths)</summary>

- always
  - returns `1`
  - calls `AbnormalStateManager$$Contains`, `PlayerStatusBase$$CheckBodyAbility`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`
- always
  - returns `0`
  - calls `AbnormalStateManager$$Contains`, `PlayerStatusBase$$CheckBodyAbility`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`
- always
  - returns `1`
  - calls `AbnormalStateManager$$Contains`, `PlayerStatusBase$$CheckBodyAbility`
- always
  - returns `1`
  - calls `AbnormalStateManager$$Contains`, `PlayerStatusBase$$CheckBodyAbility`
- always
  - returns `1`
  - calls `AbnormalStateManager$$Contains`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`
- always
  - returns `0`
  - calls `AbnormalStateManager$$Contains`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`
- always
  - returns `1`
  - calls `AbnormalStateManager$$Contains`
- always
  - returns `1`
  - calls `PlayerStatusBase$$CheckBodyAbility`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`

</details>

<details><summary>Effect applied in `GuardActionManager$$CheckPairOfShields` (38 guarded paths)</summary>

- when `IsGuard eq 0` AND `IPlayerStatusCalculator.get_GuardSpeed(?blr) ge 1` AND `CharacterActionManagerBase.get_IsLocalDead() ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() eq 267`
  - returns `0`
  - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `interface IPlayerStatusCalculator.get_GuardSpeed`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `PlayerStatusBase$$CheckBodyAbility`, `interface MobActionManagerBase.get_transform`, `UnityEngine.Transform$$get_position`
- when `IsGuard eq 0` AND `IPlayerStatusCalculator.get_GuardSpeed(?blr) ge 1` AND `CharacterActionManagerBase.get_IsLocalDead() ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() eq 267`
  - returns `0`
  - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `interface IPlayerStatusCalculator.get_GuardSpeed`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `PlayerStatusBase$$CheckBodyAbility`, `interface MobActionManagerBase.get_transform`, `UnityEngine.Transform$$get_position`
- when `IsGuard eq 0` AND `IPlayerStatusCalculator.get_GuardSpeed(?blr) ge 1` AND `CharacterActionManagerBase.get_IsLocalDead() ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() eq 267`
  - returns `0`
  - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `interface IPlayerStatusCalculator.get_GuardSpeed`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `PlayerStatusBase$$CheckBodyAbility`, `interface MobActionManagerBase.get_transform`, `UnityEngine.Transform$$get_position`
- when `IsGuard eq 0` AND `IPlayerStatusCalculator.get_GuardSpeed(?blr) ge 1` AND `CharacterActionManagerBase.get_IsLocalDead() ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() eq 267`
  - returns `0`
  - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `interface IPlayerStatusCalculator.get_GuardSpeed`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `PlayerStatusBase$$CheckBodyAbility`, `interface MobActionManagerBase.get_transform`, `UnityEngine.Transform$$get_position`
- when `IsGuard eq 0` AND `IPlayerStatusCalculator.get_GuardSpeed(?blr) ge 1` AND `CharacterActionManagerBase.get_IsLocalDead() ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() eq 267`
  - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `interface IPlayerStatusCalculator.get_GuardSpeed`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `PlayerStatusBase$$CheckBodyAbility`, `interface MobActionManagerBase.get_transform`, `UnityEngine.Transform$$get_position`
- when `IsGuard eq 0` AND `IPlayerStatusCalculator.get_GuardSpeed(?blr) ge 1` AND `CharacterActionManagerBase.get_IsLocalDead() ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() eq 267`
  - returns `0`
  - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `interface IPlayerStatusCalculator.get_GuardSpeed`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `PlayerStatusBase$$CheckBodyAbility`, `interface MobActionManagerBase.get_transform`, `UnityEngine.Transform$$get_position`
- when `IsGuard eq 0` AND `IPlayerStatusCalculator.get_GuardSpeed(?blr) ge 1` AND `CharacterActionManagerBase.get_IsLocalDead() ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() eq 267`
  - returns `0`
  - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `interface IPlayerStatusCalculator.get_GuardSpeed`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `PlayerStatusBase$$CheckBodyAbility`, `interface MobActionManagerBase.get_transform`, `UnityEngine.Transform$$get_position`
- when `IsGuard eq 0` AND `IPlayerStatusCalculator.get_GuardSpeed(?blr) ge 1` AND `CharacterActionManagerBase.get_IsLocalDead() ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() eq 267`
  - returns `0`
  - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `interface IPlayerStatusCalculator.get_GuardSpeed`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `PlayerStatusBase$$CheckBodyAbility`, `interface MobActionManagerBase.get_transform`, `UnityEngine.Transform$$get_position`

</details>

<details><summary>Effect applied in `GuardActionManager$$CheckGuardStart` (141 guarded paths)</summary>

- always
  - returns `0`
  - calls `GuardActionManager$$CheckGuardEquip`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `GuardActionManager$$CheckInBlackHole`, `GuardActionManager$$get_GuardType`
- when `CharacterActionManagerBase.get_IsLocalDead() eq 0`
  - returns `0`
  - calls `GuardActionManager$$CheckGuardEquip`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `GuardActionManager$$CheckInBlackHole`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `GuardActionManager$$get_GuardType`, `GuardActionManager$$get_GuardType`
- when `CharacterActionManagerBase.get_IsLocalDead() ne 0`
  - returns `0`
  - calls `GuardActionManager$$CheckGuardEquip`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `GuardActionManager$$CheckInBlackHole`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `GuardActionManager$$get_GuardType`, `GuardActionManager$$get_GuardType`
- when `CharacterActionManagerBase.get_IsLocalDead() eq 266`
  - returns `1`
  - calls `GuardActionManager$$CheckGuardEquip`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `GuardActionManager$$CheckInBlackHole`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `GuardActionManager$$get_GuardType`, `GuardActionManager$$get_GuardType`
- when `CharacterActionManagerBase.get_IsLocalDead() eq 266`
  - returns `0`
  - calls `GuardActionManager$$CheckGuardEquip`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `GuardActionManager$$CheckInBlackHole`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `GuardActionManager$$get_GuardType`, `GuardActionManager$$get_GuardType`
- when `CharacterActionManagerBase.get_IsLocalDead() eq 266`
  - returns `0`
  - calls `GuardActionManager$$CheckGuardEquip`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `GuardActionManager$$CheckInBlackHole`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `GuardActionManager$$get_GuardType`, `GuardActionManager$$get_GuardType`
- when `CharacterActionManagerBase.get_IsLocalDead() eq 266`
  - returns `0`
  - calls `GuardActionManager$$CheckGuardEquip`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `GuardActionManager$$CheckInBlackHole`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `GuardActionManager$$get_GuardType`, `GuardActionManager$$get_GuardType`
- when `CharacterActionManagerBase.get_IsLocalDead() eq 266`
  - returns `0`
  - calls `GuardActionManager$$CheckGuardEquip`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `GuardActionManager$$CheckInBlackHole`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `GuardActionManager$$get_GuardType`, `GuardActionManager$$get_GuardType`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `BeragelungAction$$IsFailure (ContainsBuffer)`
- `GuardActionManager$$CheckGuardStart (ContainsBuffer)`
- `GuardActionManager$$CheckPairOfShields (ContainsBuffer)`
- `GuardActionManager$$CheckPairOfShieldsGuard (ContainsBuffer)`
- `NormalAttackAction$$OnInitialize (TryGetBuf)`
- `PlayerActionManager$$Damaged (TryGetBuf)`
- `PlayerActionManager$$SuccessAddAbnormal (TryGetBuf)`
- `PlayerBattleManager$$CheckZeroActionDelay (ContainsBuffer)`
- `UIFishingPanelManager$$StartFishingResponse (TryGetBuf)`

---

### การ์ดสไตร์ค (GuardStrike) · uid 262

<img src="../../icons/sk_262.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 4) · **Type:** Mastery · **Max Lv:** 110 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ชีลด์แคนนอน · **Client class:** `GuardStrikeAction` · **Client class:** `GuardStrike` (passive mastery)

> ต้านทานการโจมตีของศัตรูพร้อมโจมตีกลับ
> สร้างความเสียหายให้ศัตรูเมื่อ Guard ทำงาน
> พลังโจมตีจะเพิ่มตามพลัง Guard และค่าการถลุงของโล่

<details><summary>In-game level notes</summary>

- Lv17: *เพิ่มพลัง Guard ไปที่พลัง *ค่าการตีบวกของโล่มีผลต่อพลังสกิล

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.1 | 0.2 | 0.3 | 0.4 | 0.5 | 0.6 | 0.7 | 0.8 | 0.9 | 1 |
| Flat dmg + | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv + (Lv << 2)) << 1) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 46)) / 100))` — subWeapon == Shield
- Flat dmg + `((((Lv + (Lv << 2)) << 1) + ((ItemData.get_Refine(GetSubWeaponType.item(actarAction)) & 255) * 60)))` — subWeapon == Shield

**Role:** attack (deals damage) · passive mastery

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

This action never changes monster proration: IsExpDefFluctuate=false.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` sets: `((((Lv + (Lv << 2)) << 1) + ((ItemData.get_Refine(GetSubWeaponType.item(actarAction)) & 255) * 60)))`
- `SkillRate` sets: `(((((Lv + (Lv << 2)) << 1) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 46)) / 100))`

**Proration:** slot `none`, mode `never (IsExpDefFluctuate=false)`, attack type `None`, action id 262

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillAttackRate | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |


<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (2 paths)

- set `ActionRange` = `-1` = -1
- set `skillRate` = `((((Lv + (Lv << 2)) << 1) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 46)) / 100)` — when subWeapon == Shield
- set `fixAddDamage` = `(((Lv + (Lv << 2)) << 1) + ((ItemData.get_Refine(GetSubWeaponType.item(actarAction)) & 255) * 60))` — when subWeapon == Shield
- set `skillRate` = `(((Lv + (Lv << 2)) << 1) / 100)` → Lv1..10: [0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1.0] — when subWeapon != Shield
- set `fixAddDamage` = `((Lv + (Lv << 2)) << 1)` → Lv1..10: [10, 20, 30, 40, 50, 60, 70, 80, 90, 100] — when subWeapon != Shield

**`ActionStart`** (1 path)

- set `SkillParam` = `(SkillParam & 239)`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`calcPlayerToMobDamage`** (4 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)`
- template `SetRate[SkillRate]` = `skillRate`
- template `SetConstant[SkillConstantDamage]` = `fixAddDamage`
- info `templates` = `1`

</details>

---

### การ์เดียน (Guardian) · uid 265

<img src="../../icons/sk_265.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 4) · **Type:** Support · **Max Lv:** 100 · **Weapons:** Shield · **Requires:** อีจิส · **Client class:** `GuardianAction`

> สร้างพื้นที่ลดความเสียหาย
> เพิ่มการฟื้นฟู Guard ของตัวเอง พลังโจมตีจะลดลง
> ตามจำนวนคนที่ปกป้อง แต่ค่าเฮทจะเพิ่มขึ้นจำนวนมาก
> ยิ่งค่าการถลุงสูงค่าความเสียหายก็จะยิ่งลดมาก

<details><summary>In-game level notes</summary>

- Lv17: [ค่าการตีของโล่จะมีผลทำให้ผลลัพธ์ด้านล่างแข็งแกร่งยิ่งขึ้น] *เพิ่มการฟื้นฟู Guard ที่ได้จากบัฟของพวกพ้องที่ได้รับการปกป้องจากสกิลนี้ *เพิ่มความสามารถในการลดเฮทของพวกพ้องที่ได้รับการปกป้องจากสกิลนี้

</details>

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `0` = 0
- **Range** (`range`): `int(MathUtil.DisplayMeterToDistance(int(((Lv * 0.5) + 1))))`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 265

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `CastTime` = `0` = 0
- set `range` = `int(MathUtil.DisplayMeterToDistance(int(((Lv * 0.5) + 1))))`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (2 paths)

- set `checkPos` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x`
- set `checkPos.y` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y`
- set `checkPos.z` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z`
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(265, Lv, Id)`

**`OnInheritance`** (1 path)

- set `IsInheritance` = `1` = 1

</details>

**Buffs**

**Buff `GuardianBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `SetStatus`, `get_Num`, `get_Refine`, `set_Num`, `set_Refine`
- Duration: `(((System.Math.Max(0, (Lv - 5)) + lv) * 10) + 30)` s [(self & 1) ne 0]
- `HateRate` = `(Num * (int((Lv * 1.5)) + 15))` _(when BuffEffectActive ne 0; IsSelfAction ne 0; EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17)_
- `Guard` = `((val) + 15)` _(when BuffEffectActive ne 0; IsSelfAction ne 0; EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17)_
- `AttackMprecoveryUp` = `(Num * (int((Lv * 0.33)) + 2))` _(when BuffEffectActive ne 0; IsSelfAction ne 0; EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17)_
- `MAtkUpRate` = `(((Lv << 1) - 30) * Num)` _(when BuffEffectActive ne 0; IsSelfAction ne 0; EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17)_
- `AtkUpRate` = `(Num * (int((Lv * 1.5)) - 20))` _(when BuffEffectActive ne 0; IsSelfAction ne 0; EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17)_
- `MobLastDamageRateSupport` = `((val) + (int((Lv * 1.5)) + 20))` _(when BuffEffectActive ne 0; IsSelfAction eq 0; (Refine & 0x80000000) eq 0)_
- `HateRate` = `(((Lv - (Lv << 2)) - ((val) << 1)) - 30)` _(when BuffEffectActive ne 0; IsSelfAction eq 0; (Refine & 0x80000000) eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| AttackMprecoveryUp | 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13 | 14 | 15 |

- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `range` = `int(MathUtil.DisplayMeterToDistance(int(((Lv * 0.5) + 1))))` when (self & 1) ne 0
  - `Refine` = `val` when (self & 1) eq 0
- Hook `set_Num`: `Num`=value
- Hook `set_Refine`: `Refine`=value
- Hook `SetStatus`: `status`=status

<details><summary>Effect applied in `PlayerSecondaryStatus$$GetDisplayBonusCalcHate` (293 guarded paths, truncated)</summary>

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

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `PlayerSecondaryStatus$$GetDisplayBonusCalcHate (TryGetBuf)`

---

### รีแพร์ชีลด์ (ShieldRepair) · uid 268

<img src="../../icons/sk_268.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 4) · **Type:** Buffer · **Max Lv:** 110 · **Weapons:** Shield · **Requires:** ดูอัลชีลด์ · **Client class:** `ShieldRepairAction`

> ซ่อมแซมโล่และฟื้นฟูความทนทาน
> 
> ฟื้นฟูพลัง Guard ที่ใช้ไป
> ฟื้นฟู MP ตามการฟื้นฟู Guard

**Role:** utility / system action

This action never changes monster proration: ExpType None: no proration slot.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `1` = 1

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 268

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `CastTime` = `1` = 1

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

</details>

---

### บาลาเกรุง (Beragelung) · uid 269

<img src="../../icons/sk_269.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 5) · **Type:** Object · **Max Lv:** 225 · **Weapons:** Shield · **Requires:** รีแพร์ชีลด์ · **Client class:** `BeragelungAction`

> การโจมตีด้วยโล่คู่ที่ใช้ได้ระหว่างใช้สกิล "ดูอัลชีลด์" เท่านั้น
> 
> โจมตีวงกว้าง 2 ครั้งและจบสกิลดูอัลชีลด์
> เพิ่มความเสียหายให้กับเป้าหมายที่เคลื่อนที่ไม่ได้

<details><summary>In-game level notes</summary>

- Lv17: ทำให้เคลื่อนที่ไม่ได้หมายถึง [ผงะ], [ล้มคว่ำ] และ [หมดสติ]  ติดดีบัฟให้กับเป้าหมายเมื่อติดตั้งเกราะหนัก ดีบัฟจะอยู่ต่อเนื่อง 15 วินาที ลดต้านทานคริติคอลตามเลเวลบาลาเกรุง เพิ่มความเสียหายที่ทำได้และการฟื้นฟู MP การโจมตี หากเป้าหมายถูกทำให้เคลื่อนที่ไม่ได้

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 6.525 | 7.05 | 7.575 | 8.1 | 8.625 | 9.15 | 9.675 | 10.2 | 10.725 | 11.25 |
| SkillRate × | 4.35 | 4.7 | 5.05 | 5.4 | 5.75 | 6.1 | 6.45 | 6.8 | 7.15 | 7.5 |
| Flat dmg + | 110 | 120 | 130 | 140 | 150 | 160 | 170 | 180 | 190 | 200 |

**Formulas that depend on live stats (not tabulated)**

- Flat dmg + `((((Lv * 10) + 100)) + (((((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255)) // 5) + 1) * baseVIT))`

**Role:** attack (deals damage) · buff (self) · placed object / trap / summon

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `((((Lv * 10) + 100)) + (((((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255)) // 5) + 1) * baseVIT))` | `(((Lv * 10) + 100))`
- `SkillRate` multiplies by (adds into): `((1.5 * (((Lv * 35) + 400))) / 100)` | `((((Lv * 35) + 400)) / 100)`
- `ExpRate` sets: `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefSkill / 100)` | `(targetExpList[mobAction] / 100)`

**Mechanics recovered from code**

- **Attack range** (`attackRange`): `MathUtil.DisplayMeterToDistance(3)`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 269

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `skillRate` = `((Lv * 35) + 400)` → Lv1..10: [435, 470, 505, 540, 575, 610, 645, 680, 715, 750]
- set `constantDamage` = `((Lv * 10) + 100)` → Lv1..10: [110, 120, 130, 140, 150, 160, 170, 180, 190, 200]
- set `attackRange` = `MathUtil.DisplayMeterToDistance(3)`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`

**`ActionStartOthers`** (2 paths)

- set `mainTarget` = `target`
- set `mainTargetPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x` — when UnityEngine.Object.op_Inequality(target)
- set `mainTargetPos.y` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y` — when UnityEngine.Object.op_Inequality(target)
- set `mainTargetPos.z` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z` — when UnityEngine.Object.op_Inequality(target)

**`ActionPreparation`** (6 paths)

- set `mainTarget` = `target`
- set `mainTargetPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x` — when !UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 17 AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target)
- set `mainTargetPos.y` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y` — when !UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 17 AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target)
- set `mainTargetPos.z` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z` — when !UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 17 AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target)
- set `shieldRefine` = `(ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255)` — when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(target) OR !UnityEngine.Object.op_Inequality(target) AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 AND UnityEngine.Object.op_Inequality(actarAction)

**`ActionSkillEvent`** (7 paths)

- set `state` = `param` — when param eq 100 AND param ge 1 AND param le 199 OR param eq 200 AND param ge 1 AND param gt 199 OR param eq 102 AND param ge 1 AND param le 199 AND param ne 100
- set `straightEventTake` = `new SkillLinkedTake` — when param eq 100 AND param ge 1 AND param le 199
- set `homingEventTake` = `new SkillLinkedTake` — when param eq 200 AND param ge 1 AND param gt 199

**`ActionSkillReceiveEffect`** (3 paths)

- set `straightObject` = `effect` — when state eq 101 AND state ne 201
- set `homingObject` = `effect` — when state eq 201

**`calcPlayerToMobDamage`** (8 paths)

- template `AddRate[SkillRate]` = `((1.5 * skillRate) / 100)`
- template `AddConstant[SkillConstantDamage]` = `(constantDamage + (((shieldRefine // 5) + 1) * baseVIT))`
- template `SetRate[ExpRate]` = `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefSkill / 100)`
- info `templates` = `1`
- template `SetRate[ExpRate]` = `(targetExpList[mobAction] / 100)`
- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `constantDamage`

**`AddDebuff`** (8 paths)

- calls `BeragelungStraightDebuff..ctor` = `.ctor(Toram.Common.ArchetypeUid.get_Id(stkp(-56)), action.Level)` — when !UnityEngine.Object.op_Equality(actionManager) AND IsInstanceOf(action, PlayerAttackBase) eq 1 AND PlayerStatusBase.CheckBodyAbility(PlayerActionManagerBase.get_PlayerStatus(), 2) AND SkillActionBase.get_ActionID() eq 269
- calls `BeragelungHomingDebuff..ctor` = `.ctor(Toram.Common.ArchetypeUid.get_Id(stkp(-56)), action.Level)` — when !UnityEngine.Object.op_Equality(actionManager) AND IsInstanceOf(action, PlayerAttackBase) eq 1 AND PlayerStatusBase.CheckBodyAbility(PlayerActionManagerBase.get_PlayerStatus(), 2) AND SkillActionBase.get_ActionID() eq 269

**`ValidDebuff`** (11 paths)

- calls `BeragelungBuf..ctor` = `.ctor(int((BeragelungDebuffBase.GetLastDamageUpRate(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 11)) + BeragelungDebuffBase.GetLastDamageUpRate(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 12)))), (BeragelungDebuffBase.GetAttackMpRecovery(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 12)) + BeragelungDebuffBase.GetAttackMpRecovery(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 11))))` — when TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 11) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 12) ne 0
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new BeragelungBuf, 0)`
- calls `BeragelungBuf..ctor` = `.ctor(int(BeragelungDebuffBase.GetLastDamageUpRate(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 11))), BeragelungDebuffBase.GetAttackMpRecovery(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 11)))` — when TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 11) ne 0
- calls `BeragelungBuf..ctor` = `.ctor(int(BeragelungDebuffBase.GetLastDamageUpRate(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 12))), BeragelungDebuffBase.GetAttackMpRecovery(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 12)))` — when TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 12) ne 0
- calls `BeragelungBuf..ctor` = `.ctor(0, 0)`

**`InvalidDebuff`** (1 path)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(269)`

**`.<>c__DisplayClass36_0::<ActionPreparation>b__0`** (1 path)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(267)`

**`.<>c__DisplayClass36_0::<ActionPreparation>b__1`** (2 paths)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(267)` — when (cancel & 1) ne 0

</details>

**Buffs**

**Buff `BeragelungBuf`**
- `LastDmgUpRate` = `(lastDamageRate)` _(when BuffEffectActive ne 0)_
- `AttackMprecoveryUp` = `(attackMpRecovery)` _(when BuffEffectActive ne 0)_
- Buff fields set in the constructor (all recovered):
  - `lastDamageRate` = `lastDamageRate`
  - `attackMpRecovery` = `attackMpRecovery`
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:BeragelungBuf$$.ctor<-BeragelungAction$$ValidDebuff` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

---

### ラスティール / ラースバーン · uid 270

<img src="../../icons/sk_270.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 5) · **Type:** Attack · **Max Lv:** 225 · **Weapons:** Shield · **Requires:** การ์เดียน · **Flags:** CanNotUse

> No Info Data...

**Role:** no client action class (system / production / unreleased)

---
