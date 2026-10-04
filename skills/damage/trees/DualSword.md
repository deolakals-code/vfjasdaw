# デュアルスキル (`DualSword`)

21 entries. See ../README.md for how to read these blocks.

### ดูเอลมาสเตอรี่ (DualMastery) · uid 641

<img src="../../icons/sk_641.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 1) · **Type:** Mastery · **Max Lv:** 30 · **Weapons:** TwinSword · **Flags:** StarGem · **Client class:** `DualMastery` (passive mastery)

> สามารถติดตั้งดาบมือเดียว 2 เล่มพร้อมกัน
> ลดการลดลงของอัตราความแม่นและ
> อัตราคริติคอลเมื่อเลเวลเพิ่มขึ้น

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| HitRate | -52 | -49 | -46 | -43 | -40 | -37 | -34 | -31 | -28 | -25 |
| CrtRate | -52 | -49 | -46 | -43 | -40 | -37 | -34 | -31 | -28 | -25 |


<details><summary>Effect applied in `EquipItemData.OneHundSwordCalculator$$calcAtkParam` (4 guarded paths)</summary>

- when `SkillLv(641) ge 1`
  - returns `(int((((CharacterActionManagerBase.get_Size() / 100) + ?v0) * (((((IPlayerStatusCalculator.get_EqAtk(PlayerStatusBase.get_SecondaryStatus()) + baseAtkUp) + ?blr) + IPlayerStatusCalculator.get_Str(PlayerStatusBase.get_SecondaryStatus())) + IPlayerStatusCalculator.get_Agi(PlayerStatusBase.get_SecondaryStatus())) + (IPlayerStatusCalculator.get_Dex(PlayerStatusBase.get_SecondaryStatus()) << 1)))) + atkRate)`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual CharacterActionManagerBase.get_Size`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`
- when `SkillLv(641) lt 1`
  - returns `(int((((CharacterActionManagerBase.get_Size() / 100) + ?v0) * (((IPlayerStatusCalculator.get_EqAtk(PlayerStatusBase.get_SecondaryStatus()) + baseAtkUp) + ?blr) + ((IPlayerStatusCalculator.get_Dex(PlayerStatusBase.get_SecondaryStatus()) + IPlayerStatusCalculator.get_Str(PlayerStatusBase.get_SecondaryStatus())) << 1)))) + atkRate)`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual CharacterActionManagerBase.get_Size`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`
- when `SkillLv(641) ge 1`
  - returns `(int((?v0 * (((((IPlayerStatusCalculator.get_EqAtk(PlayerStatusBase.get_SecondaryStatus()) + baseAtkUp) + ?blr) + IPlayerStatusCalculator.get_Str(PlayerStatusBase.get_SecondaryStatus())) + IPlayerStatusCalculator.get_Agi(PlayerStatusBase.get_SecondaryStatus())) + (IPlayerStatusCalculator.get_Dex(PlayerStatusBase.get_SecondaryStatus()) << 1)))) + atkRate)`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_EqAtk`
- when `SkillLv(641) lt 1`
  - returns `(int((?v0 * (((IPlayerStatusCalculator.get_EqAtk(PlayerStatusBase.get_SecondaryStatus()) + baseAtkUp) + ?blr) + ((IPlayerStatusCalculator.get_Dex(PlayerStatusBase.get_SecondaryStatus()) + IPlayerStatusCalculator.get_Str(PlayerStatusBase.get_SecondaryStatus())) << 1)))) + atkRate)`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_EqAtk`

</details>

<details><summary>Effect applied in `SkillManager$$GetEquipEnableSkillList` (3 guarded paths)</summary>

- always
  - returns `0x165db78(meta(0x397a538, System.Collections.Generic.List<SkillId>_TypeInfo), checkEquipSkill, ?x2, ?x3)`
  - calls `0x165db78`, `System.Collections.Generic.List<Int32Enum>$$.ctor`
- always
  - returns `0x165db78(meta(0x397a538, System.Collections.Generic.List<SkillId>_TypeInfo), checkEquipSkill, ?x2, ?x3)`
  - calls `0x165db78`, `System.Collections.Generic.List<Int32Enum>$$.ctor`, `System.Collections.Generic.List<Int32Enum>$$AddWithResize`
- always
  - returns `0x165db78(meta(0x397a538, System.Collections.Generic.List<SkillId>_TypeInfo), checkEquipSkill, ?x2, ?x3)`
  - calls `0x165db78`, `System.Collections.Generic.List<Int32Enum>$$.ctor`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `EquipItemData.OneHundSwordCalculator$$CalcSubAtk (GetSkillLv)`
- `EquipItemData.OneHundSwordCalculator$$SubCalcStable (GetSkillLv)`
- `EquipItemData.OneHundSwordCalculator$$calcAtkParam (GetSkillLv)`
- `SkillManager$$GetEquipEnableSkillList (GetSkillLv)`

---

### ทวินสแลช (TwinSlash) · uid 642

<img src="../../icons/sk_642.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 1) · **Type:** Attack · **Max Lv:** 30 · **Weapons:** TwinSword · **Requires:** ดูเอลมาสเตอรี่ · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `TwinSlashAction`

> ฟันด้วยดาบมือเดียว 2 เล่ม
> ความเสียหายจากคริติคอลจะสูงกว่าปกติ

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 1.6 | 1.7 | 1.8 | 1.9 | 2 | 2.1 | 2.2 | 2.3 | 2.4 | 2.5 |
| Flat dmg + | 110 | 120 | 130 | 140 | 150 | 160 | 170 | 180 | 190 | 200 |
| Crit mult + | 0.55 | 0.6 | 0.65 | 0.7 | 0.75 | 0.8 | 0.85 | 0.9 | 0.95 | 1 |

**Role:** attack (deals damage)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv * 10) + 100))`
- `CriticalRate` multiplies by (adds into): `(((((Lv + (Lv << 2)) + 50) + gemCart(109[2])) / 100))`
- `SkillRate` multiplies by (adds into): `((((Lv * 10) + 150) / 100))`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 642

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `fixAddDamage` = `((Lv * 10) + 100)` → Lv1..10: [110, 120, 130, 140, 150, 160, 170, 180, 190, 200]
- set `skillRate` = `(((Lv * 10) + 150) / 100)` → Lv1..10: [1.6, 1.7, 1.8, 1.9, 2.0, 2.1, 2.2, 2.3, 2.4, 2.5]
- set `crtDamageRate` = `((((Lv + (Lv << 2)) + 50) + gemCart(109[2])) / 100)`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`

**`calcPlayerToMobDamage`** (2 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)`
- template `AddRate[SkillRate]` = `skillRate`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- template `AddRate[CriticalRate]` = `crtDamageRate`
- info `templates` = `1`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `AirSlicerAction$$OnInitialize (GetSkillLv)`

---

### ครอสแพรี่ (ParryingSword) · uid 643

<img src="../../icons/sk_643.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 1) · **Type:** Attack · **Max Lv:** 30 · **Weapons:** TwinSword · **Requires:** ดูเอลมาสเตอรี่ · **Flags:** StarGem · **Client class:** `ParryingSwordAction`

> หลบการโจมตีของศัตรูพร้อมตอบโต้กลับ
> ลดความเสียหายจากการโจมตีทางกายภาพและเวทมนตร์ระหว่างใช้สกิล
> เร่ง ATK กับ ASPD เมื่อลดความเสียหายสำเร็จเป็นเวลา 30 วินาที

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 1.01 | 1.02 | 1.03 | 1.04 | 1.05 | 1.06 | 1.07 | 1.08 | 1.09 | 1.1 |
| Flat dmg + | 55 | 60 | 65 | 70 | 75 | 80 | 85 | 90 | 95 | 100 |

**Role:** attack (deals damage) · buff (self) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv + (Lv << 2)) + 50))`
- `SkillRate` multiplies by (adds into): `((((Lv + 100) + gemCart(110[4])) / 100))`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 643

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `skillRate` = `(((Lv + 100) + gemCart(110[4])) / 100)`
- set `fixAddDamage` = `((Lv + (Lv << 2)) + 50)` → Lv1..10: [55, 60, 65, 70, 75, 80, 85, 90, 95, 100]

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`

**`calcPlayerToMobDamage`** (2 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)`
- template `AddRate[SkillRate]` = `skillRate`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- info `templates` = `1`

**`ActionStart`** (2 paths)

- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(643, Lv, Id)` — when (SkillParam & 16) eq 0

**`Damaged`** (5 paths)

- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(0, 0)` — when SkillDamageData.IsInactivityAbnormal(damageData) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 643) ne 0

</details>

**Buffs**

**Buff `ParryingSwordBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `EndDamageAbnormalCut`, `Parry`, `SetParrySuccess`, `calcDmgCut`, `get_DamageAbnormalCut`, `get_ParrySuccess`, `get_RealLeftTime`, `set_DamageAbnormalCut`, `set_ParrySuccess`, `set_RealLeftTime`
- Duration: `0` s
- `PowerDmgCut` = `ParryingSwordBuf.calcDmgCut(this, Lv)` _(when BuffEffectActive ne 0; ParrySuccess ne 0; DamageAbnormalCut ne 0)_
- `MagicDmgCut` = `ParryingSwordBuf.calcDmgCut(this, Lv)` _(when BuffEffectActive ne 0; ParrySuccess ne 0; DamageAbnormalCut ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| AtkUpRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| AspdRate | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |

- Buff fields set in the constructor (all recovered):
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `RealLeftTime` = `0`
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
  - `ParrySuccess` = `256` = 256
- Hook `set_RealLeftTime`: `RealLeftTime`=value
- Hook `set_ParrySuccess`: `ParrySuccess`=(value & 1)
- Hook `set_DamageAbnormalCut`: `DamageAbnormalCut`=(value & 1)
- Hook `Updata`: `RealLeftTime`=0; `RealLeftTime`=(RealLeftTime - UnityEngine.Time.get_deltaTime())
- Hook `SetParrySuccess`: `RealLeftTime`=30; `ParrySuccess`=1
- Hook `EndDamageAbnormalCut`: `DamageAbnormalCut`=0

<details><summary>Effect applied in `ParryingSwordAction$$Damaged` (5 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 643, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `SkillDamageData.SetAbnormalType(damageData, 0, 0, ?x3)`
  - calls `SkillDamageData$$IsInactivityAbnormal`, `SkillDamageData$$SetAbnormalType`
- when `(SkillBufferManager.TryGetBuf(?blr, 643, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `SkillDamageData.IsInactivityAbnormal(damageData, 0, ?x2, ?x3)`
  - calls `SkillDamageData$$IsInactivityAbnormal`
- when `(SkillBufferManager.TryGetBuf(?blr, 643, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 643, stkp(-40), 0)`
- when `(SkillBufferManager.TryGetBuf(?blr, 643, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `0x165db84`
- when `(SkillBufferManager.TryGetBuf(?blr, 643, stkp(-40), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 643, stkp(-40), 0)`

</details>

<details><summary>Effect applied in `ParryingSwordBuf$$Parry` (5 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 643, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `TryGetBuf.out2()`
- when `(SkillBufferManager.TryGetBuf(?blr, 643, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `TryGetBuf.out2()`
- when `(SkillBufferManager.TryGetBuf(?blr, 643, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `TryGetBuf.out2()`
- when `(SkillBufferManager.TryGetBuf(?blr, 643, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `0x165db84`, `0x165df00`
- when `(SkillBufferManager.TryGetBuf(?blr, 643, stkp(-24), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 643, stkp(-24), 0)`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `ParryingSwordAction$$Damaged (TryGetBuf)`
- `ParryingSwordBuf$$Parry (TryGetBuf)`

---

### รีเฟล็กซ์ (StepReactor) · uid 644

<img src="../../icons/sk_644.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 1) · **Type:** Buffer · **Max Lv:** 30 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ดูเอลมาสเตอรี่ · **Flags:** StarGem · **Client class:** `StepReactorAction`

> เพิ่มการฟื้นฟู Avoid ในเวลาสั้นๆ
> DEF/MDEF จะลดลงจำนวนมาก

<details><summary>In-game level notes</summary>

- Lv10: *ระยะเวลาแสดงผล+90 วิ

</details>

**Role:** buff (self) · buff (party / others)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 644

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (3 paths)

- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`
- set `equipDualSword` = `1` = 1 — when mainWeapon == OneHandSword AND subWeapon == OneHandSword

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (1 path)

- calls `SkillBufferManager.AddBuffer` = `AddBuffer(644, Lv, (equipDualSword eq 0 ? 10 : 100))`

**`OnInheritance`** (1 path)

- set `IsInheritance` = `1` = 1

</details>

**Buffs**

**Buff `StepReactorbuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `time` s

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| AvoidUp | 12 | 14 | 16 | 18 | 20 | 22 | 24 | 26 | 28 | 30 |
| MdefRate | -99 | -98 | -97 | -96 | -95 | -94 | -93 | -92 | -91 | -90 |
| DefRate | -99 | -98 | -97 | -96 | -95 | -94 | -93 | -92 | -91 | -90 |

- Buff fields set in the constructor (all recovered):
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
  - `BufEffectTakeUid` = `-1` = -1
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

---

### ควบคุมดาบคู่ (DualSwordTechnique) · uid 645

<img src="../../icons/sk_645.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 1) · **Type:** Mastery · **Max Lv:** 30 · **Weapons:** TwinSword · **Requires:** ดูเอลมาสเตอรี่ · **Flags:** StarGem · **Client class:** `DualSwordTechnique` (passive mastery)

> เพิ่ม ASPD ของดาบคู่
> และลดข้อเสียของดาบคู่ลงด้วย

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| HitRate | 8 | 11 | 14 | 17 | 20 | 23 | 26 | 29 | 32 | 35 |
| CrtRate | 8 | 11 | 14 | 17 | 20 | 23 | 26 | 29 | 32 | 35 |
| Aspd | 50 | 100 | 150 | 200 | 250 | 300 | 350 | 400 | 450 | 500 |


---

### สปินนิ่งสแลช (AirSlide) · uid 646

<img src="../../icons/sk_646.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 2) · **Type:** Object · **Max Lv:** 50 · **Weapons:** TwinSword · **Requires:** ทวินสแลช · **Flags:** MercenaryCanUseSkill · **Client class:** `AirSlideAction`

> ฟันศัตรูที่อยู่รอบตัวให้กระเด็นออกไป\ธาตุคู่(ดาบมือเดียว)
> หลังการโจมตีคาไมทาจิจะสร้างความเสียหายต่อเนื่อง
> มีโอกาสทำให้เป้าหมาย[มืดบอด] 

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [calcFirstDamage] | 1.27 | 1.3 | 1.32 | 1.35 | 1.37 | 1.4 | 1.42 | 1.45 | 1.47 | 1.5 |
| SkillRate × [calcAnyDamage] | 0.32 | 0.34 | 0.36 | 0.38 | 0.4 | 0.42 | 0.44 | 0.46 | 0.48 | 0.5 |
| Flat dmg + | 55 | 60 | 65 | 70 | 75 | 80 | 85 | 90 | 95 | 100 |

**Role:** attack (deals damage) · applies status ailment · placed object / trap / summon

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv + (Lv << 2)) + 50))`
- `SkillRate` multiplies by (adds into): `((((int((Lv * 2.5)) + 125) + gemCart(210[4])) / 100))` | `(((((Lv + Lv) + 30) + gemCart(210[4])) / 100))`
- `ExpRate` sets: `(target.ExpDefSkill / 100)` | `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**Mechanics recovered from code**

- **First-hit multiplier** (`skillRateFirst`): `(((int((Lv * 2.5)) + 125) + gemCart(210[4])) / 100)`
- **Number of damage events** (`damageCount`): `4` = 4; `4` = 4
- **Loop / hit-repeat count** (`LoopParam`): `4` = 4
- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`
- **Blind chance (%)** (`blindPercent`): `(int((Lv * 2.5)) + 15)` → Lv1..10 [17, 20, 22, 25, 27, 30, 32, 35, 37, 40]

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 646

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `3` = 3
- set `skillRate` = `((((Lv + Lv) + 30) + gemCart(210[4])) / 100)`
- set `skillRateFirst` = `(((int((Lv * 2.5)) + 125) + gemCart(210[4])) / 100)`
- set `fixAddDamage` = `((Lv + (Lv << 2)) + 50)` → Lv1..10: [55, 60, 65, 70, 75, 80, 85, 90, 95, 100]
- set `isEquipCompressionGemCart` = `(GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 210) ne 0 ? 1 : 0)`
- set `damageCount` = `4` = 4
- set `LoopParam` = `4` = 4
- set `SkillIndividualFlag` = `int(((gemCart(210[2]) * 0.01) * 100))`
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`
- set `blindPercent` = `(int((Lv * 2.5)) + 15)` → Lv1..10: [17, 20, 22, 25, 27, 30, 32, 35, 37, 40]

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`OtherPlayerAttackStartReceive`** (1 path)

- set `damageCount` = `4` = 4

**`calcFirstDamage`** (24 paths)

- template `SetRate[ExpRate]` = `(target.ExpDefSkill / 100)`
- template `AddRate[SkillRate]` = `skillRateFirst`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- calls `PlayerAttackBase.SetBufferConstantDamage` = `SetBufferConstantDamage(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), damageCount)`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(4, 100, playerAction)` — when MobActionManagerBase.get_IsPlayerManaged(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 4, 100, playerAction) AND isEquipCompressionGemCart eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 4, 100, playerAction) AND MobActionManagerBase.get_IsPlayerManaged(mobAction) AND isEquipCompressionGemCart eq 0
- info `templates` = `1`
- template `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**`calcAnyDamage`** (16 paths)

- template `SetRate[ExpRate]` = `(target.ExpDefSkill / 100)`
- template `AddRate[SkillRate]` = `skillRate`
- calls `PlayerAttackBase.SetBufferConstantDamage` = `SetBufferConstantDamage(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), damageCount)`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(7, blindPercent, playerAction)`
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(7, 0)` — when PlayerAttackBase.checkAbnormalPercent(this, 7, blindPercent, playerAction)
- info `templates` = `1`
- template `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**`ActionStart`** (1 path)

- set `attackPosition` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x`
- set `attackPosition.y` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y`
- set `attackPosition.z` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z`

**`NextRangeHit`** (2 paths)

- set `actionCount` = `(actionCount + 1)`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `AirSlicerAction$$OnInitialize (GetSkillLv)`

---

### ชาร์จจิ้งสแลช (DragoonSword) · uid 647

<img src="../../icons/sk_647.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 2) · **Type:** Attack · **Max Lv:** 50 · **Weapons:** TwinSword · **Requires:** ครอสแพรี่ · **Flags:** MercenaryCanUseSkill · **Client class:** `DragoonSwordAction`

> โจมตีศัตรูด้วยดาบ 2 เล่ม
> โจมตีเป้าหมายที่ผ่านเป็นทางตรง
> จะได้รับผลโบนัสจากฟันครั้งแรก

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 2.2 | 2.4 | 2.6 | 2.8 | 3 | 3.2 | 3.4 | 3.6 | 3.8 | 4 |
| Flat dmg + | 120 | 140 | 160 | 180 | 200 | 220 | 240 | 260 | 280 | 300 |

**Role:** attack (deals damage)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv * 20) + 100))`
- `FirstAttack` adds: `PlayerAttackBase.calcFastAttackDamage(this, playerAction)`
- `SkillRate` multiplies by (adds into): `((((((Lv + (Lv << 2)) << 2) + 200) + gemCart(211[4])) / 100))`
- `FirstAttackRate` multiplies by (adds into): `(PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100)`
- `ExpRate` sets: `(target.ExpDefSkill / 100)` | `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 647

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `runRange` = `MathUtil.DisplayMeterToDistance(runRange)`
- set `skillRate` = `(((((Lv + (Lv << 2)) << 2) + 200) + gemCart(211[4])) / 100)`
- set `isEquipCriticalGemCart` = `1` = 1
- set `fixAddDamage` = `((Lv * 20) + 100)` → Lv1..10: [120, 140, 160, 180, 200, 220, 240, 260, 280, 300]
- set `rangeRad` = `MathUtil.DisplayMeterToDistance(rangeRad)`
- set `SkillParam` = `(SkillParam | 2)`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`

**`ActionStart`** (304 paths)

- set `startPos.y` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y`
- set `startPos.z` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z`

**`calcPlayerToMobDamage`** (8 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)`
- template `SetRate[ExpRate]` = `(target.ExpDefSkill / 100)`
- template `AddRate[SkillRate]` = `skillRate`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- template `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, playerAction)`
- template `AddRate[FirstAttackRate]` = `(PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100)`
- calls `PlayerAttackBase.SetBufferConstantDamage` = `SetBufferConstantDamage(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 2)`
- info `templates` = `1`
- template `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

</details>

---

### เร็วดุจเทพ (GodspeedLocus) · uid 648

<img src="../../icons/sk_648.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 2) · **Type:** Mastery · **Max Lv:** 50 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ควบคุมดาบคู่ · **Client class:** `GodspeedLocus` (passive mastery)

> เพิ่ม AGI และพลังโจมตีของฟันครั้งแรก
> (โจมตีครั้งแรก/Avoidแอคแทค/หลังใช้สกิลที่กำหนด)

<details><summary>In-game level notes</summary>

- Lv10: *พลังโจมตีด้วยอาวุธ+10%

</details>

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| FirstAttackRate | 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13 | 14 | 15 |
| Agi | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 |


---

### แฟนทอมสแลช / แฟนทอมอิคลิพส์ (PhantomRave) · uid 649

<img src="../../icons/sk_649.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 3) · **Type:** Attack · **Max Lv:** 90 · **Weapons:** TwinSword · **Requires:** สปินนิ่งสแลช · **Flags:** MercenaryCanUseSkill · **Client class:** `PhantomRaveAction`

> ฟันอย่างรวดเร็วจนตาเปล่ามองไม่เห็นนับครั้งไม่ถ้วน
> ธาตุคู่(ดาบมือเดียว)
> ติดสถานะไร้พ่ายระหว่างใช้สกิลแต่มีโอกาสยกเลิกสถานะจากการเคลื่อนไหวคาแรคเตอร์
> มีโอกาสทำให้มอนสเตอร์ที่อ่อนแอนอกเหนือจากบอสตายทันที
> มีโอกาสทำให้เป้าหมายถูก[แช่แข็ง]

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 10.4 | 10.8 | 11.2 | 11.6 | 12 | 12.4 | 12.8 | 13.2 | 13.6 | 14 |
| Flat dmg + | 220 | 240 | 260 | 280 | 300 | 320 | 340 | 360 | 380 | 400 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((((((Lv * 20) + 500) + gemCart(305[4])) / 100)) * ((1) eq 0 ? 1 : 2))`

**Role:** attack (deals damage) · buff (self) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv * 20) + 200))`
- `SkillRate` multiplies by (adds into): `((((((Lv * 20) + 500) + gemCart(305[4])) / 100)) * ((1) eq 0 ? 1 : 2))`
- `LastDamageRate` sets: `(CalcPhantomRaveLastDamageRate.out2(this, PlayerActionManagerBase.get_PlayerStatus(), PlayerActionManagerBase.get_PlayerStatus()) - MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90)))` | `(CalcPhantomRaveLastDamageRate.out3(this, PlayerActionManagerBase.get_PlayerStatus(), PlayerActionManagerBase.get_PlayerStatus()) - MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90)))` | `CalcPhantomRaveLastDamageRate.out2(this, PlayerActionManagerBase.get_PlayerStatus(), PlayerActionManagerBase.get_PlayerStatus())`

**Mechanics recovered from code**

- **Cost** (`cost`): `400` = 400

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 649

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `Element` = `6` = 6
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(8)`
- set `skillRate` = `((((Lv * 20) + 500) + gemCart(305[4])) / 100)`
- set `freezeRate` = `((Lv + (Lv << 2)) << 1)` → Lv1..10: [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]
- set `fixAddDamage` = `((Lv * 20) + 200)` → Lv1..10: [220, 240, 260, 280, 300, 320, 340, 360, 380, 400]
- set `cost` = `400` = 400
- set `phantomMove` = `new PhantomRaveMove`
- calls `PhantomRaveMove..ctor` = `.ctor(2, actarAction)`

**`ActionStart`** (4 paths)

- set `SkillIndividualFlag` = `(SkillIndividualFlag | 2)` — when SkillActionBase.get_MotionSpeed(this) ne 0 AND change ne 0 OR SkillActionBase.get_MotionSpeed(this) eq 0 AND change ne 0

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`OtherPlayerAttackStartReceive`** (4 paths)

- set `InstantKillTake` = `new SkillLinkedTake` — when PlayerAttackBase.CheckSkillIndividualFlag(this, 1) AND SkillActionBase.get_MotionSpeed(this) ne 0 OR PlayerAttackBase.CheckSkillIndividualFlag(this, 1) AND SkillActionBase.get_MotionSpeed(this) eq 0

**`AttackStartReceive`** (2 paths)

- set `InstantKillHitCount` = `(InstantKillHitCount + 1)` — when (skillIndividualFlag & 1) ne 0
- set `InstantKillTake` = `new SkillLinkedTake` — when (skillIndividualFlag & 1) ne 0

**`calcPlayerToMobDamage`** (13 paths)

- set `placeDamageData` = `PlayerAttackBase.templateToDamageData(this, new SkillActionBase.DamageData, PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), StandardHitCount)`
- template `AddRate[SkillRate]` = `(skillRate * (change eq 0 ? 1 : 2))`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- template `SetRate[LastDamageRate]` = `(CalcPhantomRaveLastDamageRate.out2(this, PlayerActionManagerBase.get_PlayerStatus(), PlayerActionManagerBase.get_PlayerStatus()) - MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90)))` — when TryGetProperties<object>.out2(mobAction, 90) ne 0
- template `SetRate[SkillRate]` = `skillRate`
- template `SetRate[LastDamageRate]` = `(CalcPhantomRaveLastDamageRate.out3(this, PlayerActionManagerBase.get_PlayerStatus(), PlayerActionManagerBase.get_PlayerStatus()) - MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90)))` — when TryGetProperties<object>.out2(mobAction, 90) ne 0
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(9, freezeRate, playerAction)`
- info `templates` = `1`
- template `SetRate[LastDamageRate]` = `CalcPhantomRaveLastDamageRate.out2(this, PlayerActionManagerBase.get_PlayerStatus(), PlayerActionManagerBase.get_PlayerStatus())`
- template `SetRate[LastDamageRate]` = `CalcPhantomRaveLastDamageRate.out3(this, PlayerActionManagerBase.get_PlayerStatus(), PlayerActionManagerBase.get_PlayerStatus())`

**`CreateMultiDamage`** (1 path)

- calls `PlayerAttackBase.createMultiHitDamage` = `createMultiHitDamage(damageData, damageData.TotalDamage)`

**`CalcPhantomRaveLastDamageRate`** (12 paths)

- set `isPlaceBonus` = `1` = 1

**`LunaDitherStartInterruptableInitialize`** (1 path)

- set `change` = `1` = 1
- set `freezeRate` = `0` = 0
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(24)`
- set `SkillParam` = `(SkillParam | 4)`

**`GetLocalizeKey`** (2 paths)

- set `change` = `change`

**`via PlayerAttackBase$$CalcDoubleThrowLastDamageRate`** (7 paths)

- set `SkillParam` = `(SkillParam | 32)` — when PlayerAttackBase.get_ActionID() ne 300 AND PlayerAttackBase.get_ActionID() ne 302 AND PlayerAttackBase.get_TreeType() eq 9 AND PlayerStatusBase.get_SkillBufferManager().skillBufList[293].CoolTime eq 0 AND costMp ne 0
- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(293)` — when PlayerAttackBase.get_ActionID() ne 300 AND PlayerAttackBase.get_ActionID() ne 302 AND PlayerAttackBase.get_TreeType() eq 9 AND PlayerStatusBase.get_SkillBufferManager().skillBufList[293].CoolTime eq 0 AND costMp ne 0
- calls `DoubleThrowBuf..ctor` = `.ctor(PlayerStatusBase.get_SkillBufferManager().skillBufList[293].Level, 1)` — when PlayerAttackBase.get_ActionID() ne 300 AND PlayerAttackBase.get_ActionID() ne 302 AND PlayerAttackBase.get_TreeType() eq 9 AND PlayerStatusBase.get_SkillBufferManager().skillBufList[293].CoolTime eq 0 AND costMp ne 0
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new DoubleThrowBuf, Id)` — when PlayerAttackBase.get_ActionID() ne 300 AND PlayerAttackBase.get_ActionID() ne 302 AND PlayerAttackBase.get_TreeType() eq 9 AND PlayerStatusBase.get_SkillBufferManager().skillBufList[293].CoolTime eq 0 AND costMp ne 0

</details>

**Buffs**

**Buff `DoubleThrowBuf`**
- Buff hook methods: `ReductionCoolTime`, `get_CoolTime`, `set_CoolTime`
- Duration: `(30 - lv)` s [(coolTime & 1) ne 0]
- Buff fields set in the constructor (all recovered):
  - `CoolTime` = `(coolTime & 1)`
- Hook `set_CoolTime`: `CoolTime`=(value & 1)
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `ReductionCoolTime`: `LeftTime`=(LeftTime - time); `LeftTime`=0

---

### แฟลชบลาส (PhiloEclair) · uid 650

<img src="../../icons/sk_650.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 3) · **Type:** Buffer · **Max Lv:** 90 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** รีเฟล็กซ์ · **Client class:** `PhiloEclairAction`

> ธาตุคู่(ดาบมือเดียว)
> เพิ่มพลังโจมตีฟันครั้งแรกชั่วขณะ
> เพิ่มเคาน์เตอร์แอทแทคเมื่อ Avoid
> จะทำงานเมื่อใช้สกิล[ชาโดว์สเต็ป]ด้วย

<details><summary>In-game level notes</summary>

- Lv10: *เพิ่มปริมาณการเพิ่มบัฟ ATK อาวุธ *เวลาแสดงผล+100s
- Lv10: *พลัง+50 *ระยะโจมตี (รัศมี)+1m

</details>

**Role:** buff (self) · buff (party / others)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 650

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (3 paths)

- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`
- set `isDualSword` = `1` = 1 — when PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 2).Type eq 10 AND mainWeapon == OneHandSword
- set `isDualSword` = `0` = 0 — when mainWeapon != OneHandSword OR PlayerStatusBase.GetEquip(PlayerActionManagerBase.get_PlayerStatus(), 2).Type ne 10 AND mainWeapon == OneHandSword

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (1 path)

- calls `SkillBufferManager.AddBuffer` = `AddBuffer(650, Lv, 0)`

**`OnInheritance`** (1 path)

- set `IsInheritance` = `1` = 1

</details>

**Buffs**

**Buff `PhiloEclairBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `120` s [isDualSword ne 0]; `20` s [isDualSword eq 0]

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| EqAtkUpRate | 25 | 25 | 25 | 25 | 25 | 25 | 25 | 25 | 25 | 25 |
| FirstAttackRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| AvoidStack | 0 | 0 | 0 | 0 | 1000 | 1000 | 1000 | 1000 | 1000 | 2000 |

- Buff fields set in the constructor (all recovered):
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `isDualSword` = `(isDualSword ne 0 ? 1 : 0)`
  - `firstAttackRate` = `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `eqAtkRate` = `25` = 25 when isDualSword ne 0
  - `avoidStack` = `(int((Lv * 0.2)) * 1000)` → Lv1..10 [0, 0, 0, 0, 1000, 1000, 1000, 1000, 1000, 2000] when isDualSword ne 0
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

<details><summary>Effect applied in `AvoidActionManager$$CheckActivatePhiloEclair` (2 guarded paths)</summary>

- always
  - returns `(FieldRayPick.GetFallDelta([charaMove+0x30], stkp(-160), 0, ?x3) & 1)`
  - calls `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_rotation`, `UnityEngine.Quaternion$$Internal_ToEulerRad`, `UnityEngine.Quaternion$$Internal_MakePositive`, `CharacterMove$$set_IgnoreHeight`
- always
  - returns `0`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `AvoidActionManager$$CheckActivatePhiloEclair (ContainsBuffer)`

---

### ชาโดว์สเต็ป (WrapAround) · uid 651

<img src="../../icons/sk_651.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 3) · **Type:** Attack · **Max Lv:** 90 · **Weapons:** TwinSword · **Requires:** ชาร์จจิ้งสแลช · **Flags:** MercenaryCanUseSkill · **Client class:** `WrapAroundAction`

> เคลื่อนย้ายไปอยู่ข้างหลังศัตรูอย่างรวดเร็ว
> เพิ่มการฟื้นฟู MP จนกว่าจะใช้สกิลถัดไป
> เพิ่มอัตราคริติคอลของการโจมตีด้วยสกิล 1 ครั้ง

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

**Mechanics recovered from code**

- **MP cost** (`mp`): `((4 - int(((Lv * 0.25) + 0.25))) * 100)` → Lv1..10 [400, 400, 300, 300, 300, 300, 200, 200, 200, 200]
- **Loop / hit-repeat count** (`LoopParam`): `int((CharacterActionManagerBase.get_Size() * 1.5))` _(when UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<CharacterActionManagerBase>(target), 0))_

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 651

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `Element` = `1` = 1
- set `ActionRange` = `MathUtil.DisplayMeterToDistance((Lv eq 10 ? 12 : (int((Lv * 0.5)) + 4)))`
- set `mp` = `((4 - int(((Lv * 0.25) + 0.25))) * 100)` → Lv1..10: [400, 400, 300, 300, 300, 300, 200, 200, 200, 200]

**`ActionStart`** (2 paths)

- set `LoopParam` = `int((CharacterActionManagerBase.get_Size() * 1.5))` — when UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<CharacterActionManagerBase>(target), 0)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(651, Lv, Id)`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`

</details>

<details><summary>Effect applied in `LunaDitherStarAction$$ActionSkillEvent` (6 guarded paths)</summary>

- when `param ne 101` AND `param eq 100` AND `MobaMode ne 0` AND `(SkillLv(651) & 255) ne 0`
  - set `bladeRain` = `1`
  - calls `SkillActionBase$$ActionSkillEvent`, `PlayerBattleManager$$StartLunaDitherStarBladeRain`, `0x165db78`, `WrapAroundBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
- when `param ne 101` AND `param eq 100` AND `MobaMode ne 0` AND `(SkillLv(651) & 255) eq 0`
  - returns `SkillLv(651)`
  - set `bladeRain` = `1`
  - calls `SkillActionBase$$ActionSkillEvent`, `PlayerBattleManager$$StartLunaDitherStarBladeRain`
- when `param ne 101` AND `param eq 100` AND `MobaMode eq 0` AND `(SkillLv(651) & 255) ne 0`
  - set `bladeRain` = `1`
  - calls `SkillActionBase$$ActionSkillEvent`, `PlayerBattleManager$$StartLunaDitherStarBladeRain`, `0x165db78`, `WrapAroundBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
- when `param ne 101` AND `param eq 100` AND `MobaMode eq 0` AND `(SkillLv(651) & 255) eq 0`
  - returns `SkillLv(651)`
  - set `bladeRain` = `1`
  - calls `SkillActionBase$$ActionSkillEvent`, `PlayerBattleManager$$StartLunaDitherStarBladeRain`
- when `param ne 101` AND `param eq 100` AND `(SkillLv(651) & 255) ne 0`
  - set `bladeRain` = `1`
  - calls `SkillActionBase$$ActionSkillEvent`, `PlayerBattleManager$$StartLunaDitherStarBladeRain`, `0x165db78`, `WrapAroundBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
- when `param ne 101` AND `param eq 100` AND `(SkillLv(651) & 255) eq 0`
  - returns `SkillLv(651)`
  - set `bladeRain` = `1`
  - calls `SkillActionBase$$ActionSkillEvent`, `PlayerBattleManager$$StartLunaDitherStarBladeRain`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `LunaDitherStarAction$$ActionSkillEvent (GetSkillLv)`

---

### ไชน์นิ่งครอส / เบลซซิ่งไชน์นิ่งครอส (ShiningCloth) · uid 652

<img src="../../icons/sk_652.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 4) · **Type:** Attack · **Max Lv:** 170 · **Weapons:** TwinSword · **Requires:** ชาโดว์สเต็ป · **Flags:** MercenaryCanUseSkill · **Client class:** `ShiningClothAction`

> ดาบคู่แห่งแสงตัดผ่านความมืดมิด
> ธาตุคู่(ดาบมือเดียว)
> ยิ่งเข้าไปใกล้ศัตรูจะยิ่งสร้างความเสียหายได้เพิ่มขึ้น
> ฟื้นฟู MP ถ้าติดคริติคอล เมื่อติดบัฟจะฟื้นฟู HP เล็กน้อย
> บัฟนี้จะไม่มีการทับซ้อนกัน

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 120 | 140 | 160 | 180 | 200 | 220 | 240 | 260 | 280 | 300 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(max((((((Lv * 10) + 300) + (((status.Agi // 4) + (status.Str // 4)) + (status.Dex // 4)))) - System.Math.Max(0, System.Math.Min(400, ((MobActionManagerBase.get_PlayerMeterDistance(mobAction) * 50) - 200)))), 100) / 100)` — hasBuff(655)
- SkillRate × `(max((((((Lv * 10) + 300) + (((status.Agi // 4) + (status.Str // 4)) + (status.Dex // 4)))) - System.Math.Max(0, System.Math.Min(400, ((MobActionManagerBase.get_PlayerMeterDistance(mobAction) * 50) - 200)))), 100) / 100)` — !hasBuff(655)
- SkillRate × `(max((((((Lv * 10) + 300) + (((status.Agi // 4) + (status.Str // 4)) + (status.Dex // 4)))) - System.Math.Max(0, System.Math.Min(400, ((MobActionManagerBase.get_PlayerMeterDistance(mobAction) * 50) - 200)))), 100) / 100)`

**Role:** attack (deals damage) · buff (self)

The skill builds 2 separate damage templates (each is a full hit with its own crit roll). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv * 20) + 100))`
- `SkillRate` multiplies by (adds into): `(max((((((Lv * 10) + 300) + (((status.Agi // 4) + (status.Str // 4)) + (status.Dex // 4)))) - System.Math.Max(0, System.Math.Min(400, ((MobActionManagerBase.get_PlayerMeterDistance(mobAction) * 50) - 200)))), 100) / 100)`

**Mechanics recovered from code**

- **Loop / hit-repeat count** (`LoopParam`): `SubElement`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 652

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (2 paths)

- set `Element` = `5` = 5
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`
- set `skillRate` = `(((Lv * 10) + 300) + (((status.Agi // 4) + (status.Str // 4)) + (status.Dex // 4)))` — when hasBuff(655)
- set `fixAddDamage` = `((Lv * 20) + 100)` → Lv1..10: [120, 140, 160, 180, 200, 220, 240, 260, 280, 300]
- set `change` = `1` = 1 — when hasBuff(655)
- set `SkillIndividualFlag` = `0x10000` = 65536 — when hasBuff(655)
- set `LoopParam` = `SubElement`
- set `skillRate` = `(((Lv * 10) + 300) + (((status.Agi // 5) + (status.Str // 5)) + (status.Dex // 5)))` — when !hasBuff(655)
- set `SkillIndividualFlag` = `0` = 0 — when !hasBuff(655)

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `SubElement` = `motionSpeed`
- set `ActionRange` = `-1` = -1

**`calcPlayerToMobDamage`** (16 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)` — when change ne 0
- set `skillRate` = `max((skillRate - System.Math.Max(0, System.Math.Min(400, ((MobActionManagerBase.get_PlayerMeterDistance(mobAction) * 50) - 200)))), 100)`
- set `SkillIndividualFlag` = `(MobActionManagerBase.get_PlayerMeterDistance(mobAction) | SkillIndividualFlag)`
- template `AddRate[SkillRate]` = `(max((skillRate - System.Math.Max(0, System.Math.Min(400, ((MobActionManagerBase.get_PlayerMeterDistance(mobAction) * 50) - 200)))), 100) / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- info `templates` = `2`

**`GetLocalizeKey`** (2 paths)

- set `change` = `change`

**`.<>c__DisplayClass27_0::<ActionStart>b__1`** (2 paths)

- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(CharacterActionManagerBase.get_IsLocalDead(), [<>c__DisplayClass27_0.<>4__this+0x14], 0)` — when (cancel & 1) eq 0

</details>

**Buffs**

**Buff `ShiningClothBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `9` s
- Buff fields set in the constructor (all recovered):
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

---

### สตอร์มรีปเปอร์ / ออร์บิทรีปเปอร์ (SturmLeaper) · uid 653

<img src="../../icons/sk_653.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 4) · **Type:** Attack · **Max Lv:** 170 · **Weapons:** TwinSword · **Requires:** แฟลชบลาส · **Flags:** MercenaryCanUseSkill · **Client class:** `SturmLeaperAction`

> โจมตีศัตรูและกระโดดถอยกลับอย่างรวดเร็ว
> พลังโจมตีระยะใกล้ของสกิลที่ใช้ถัดไป
> จะเพิ่มขึ้นตามระยะถอยห่าง
> ติดคงกระพันขณะถอยห่าง

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 110 | 120 | 130 | 140 | 150 | 160 | 170 | 180 | 190 | 200 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((((((Lv + (Lv << 2)) << 1) + 400) + ((baseDEX // 25) * Lv))) / 100)`

**Role:** attack (deals damage) · buff (self)

The skill builds 2 separate damage templates (each is a full hit with its own crit roll). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `((((Lv + (Lv << 2)) << 1) + 100))`
- `FirstAttack` adds: `PlayerAttackBase.calcFastAttackDamage(this, playerAction)`
- `SkillRate` multiplies by (adds into): `((((((Lv + (Lv << 2)) << 1) + 400) + ((baseDEX // 25) * Lv))) / 100)`
- `FirstAttackRate` multiplies by (adds into): `(PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100)`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 653

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `skillRate` = `((((Lv + (Lv << 2)) << 1) + 400) + ((baseDEX // 25) * Lv))`
- set `fixAddDamage` = `(((Lv + (Lv << 2)) << 1) + 100)` → Lv1..10: [110, 120, 130, 140, 150, 160, 170, 180, 190, 200]
- set `SkillParam` = `(SkillParam | 2)`

**`ActionStart`** (3 paths)

- set `SkillIndividualFlag` = `(SkillIndividualFlag | 1)` — when !PlayerAttackBase.IsBlank(this) AND change ne 0
- set `startPos.y` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y` — when !PlayerAttackBase.IsBlank(this) AND change ne 0 OR !PlayerAttackBase.IsBlank(this) AND change eq 0
- set `startPos.z` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z` — when !PlayerAttackBase.IsBlank(this) AND change ne 0 OR !PlayerAttackBase.IsBlank(this) AND change eq 0

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `otherTargetPos` = `castTime`
- set `ActionRange` = `-1` = -1

**`calcPlayerToMobDamage`** (8 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)`
- set `ActionRange` = `ActionRange`
- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- template `AddRate[FirstAttackRate]` = `(PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100)`
- template `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, playerAction)`
- info `templates` = `2`

**`LunaDitherStartInterruptableInitialize`** (1 path)

- set `change` = `1` = 1
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(24)`
- set `SkillParam` = `(SkillParam | 4)`

**`GetLocalizeKey`** (2 paths)

- set `change` = `change`

**`.<>c__DisplayClass31_0::<ActionStart>b__1`** (8 paths)

- calls `SturmLeaperBuf..ctor` = `.ctor([<>c__DisplayClass31_0.<>4__this+0x14], ((int(frintp((((((int(frintp((((fsqrt(((([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z) * ([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z)) + (([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x) * ([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x)))) * 100)) + -0.5))) / 100) / MathUtil.DisplayMeterToDistance(9)) * 100)) + -0.5))) / 100) pl 0.1 ? min((int(frintp((((((int(frintp((((fsqrt(((([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z) * ([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z)) + (([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x) * ([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x)))) * 100)) + -0.5))) / 100) / MathUtil.DisplayMeterToDistance(9)) * 100)) + -0.5))) / 100), 1) : 0.1), [<>c__DisplayClass31_0.<>4__this+0x135])`
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new SturmLeaperBuf, [<>c__DisplayClass31_0.<>4__this+0x10])`
- calls `SturmLeaperBuf..ctor` = `.ctor([<>c__DisplayClass31_0.<>4__this+0x14], ((int(floor((((((int(frintp((((fsqrt(((([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z) * ([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z)) + (([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x) * ([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x)))) * 100)) + -0.5))) / 100) / MathUtil.DisplayMeterToDistance(9)) * 100)) + 0.5))) / 100) pl 0.1 ? min((int(floor((((((int(frintp((((fsqrt(((([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z) * ([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z)) + (([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x) * ([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x)))) * 100)) + -0.5))) / 100) / MathUtil.DisplayMeterToDistance(9)) * 100)) + 0.5))) / 100), 1) : 0.1), [<>c__DisplayClass31_0.<>4__this+0x135])`
- calls `SturmLeaperBuf..ctor` = `.ctor([<>c__DisplayClass31_0.<>4__this+0x14], ((int(frintp((((((int(floor((((fsqrt(((([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z) * ([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z)) + (([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x) * ([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x)))) * 100)) + 0.5))) / 100) / MathUtil.DisplayMeterToDistance(9)) * 100)) + -0.5))) / 100) pl 0.1 ? min((int(frintp((((((int(floor((((fsqrt(((([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z) * ([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z)) + (([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x) * ([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x)))) * 100)) + 0.5))) / 100) / MathUtil.DisplayMeterToDistance(9)) * 100)) + -0.5))) / 100), 1) : 0.1), [<>c__DisplayClass31_0.<>4__this+0x135])`
- calls `SturmLeaperBuf..ctor` = `.ctor([<>c__DisplayClass31_0.<>4__this+0x14], ((int(floor((((((int(floor((((fsqrt(((([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z) * ([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z)) + (([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x) * ([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x)))) * 100)) + 0.5))) / 100) / MathUtil.DisplayMeterToDistance(9)) * 100)) + 0.5))) / 100) pl 0.1 ? min((int(floor((((((int(floor((((fsqrt(((([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z) * ([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z)) + (([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x) * ([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x)))) * 100)) + 0.5))) / 100) / MathUtil.DisplayMeterToDistance(9)) * 100)) + 0.5))) / 100), 1) : 0.1), [<>c__DisplayClass31_0.<>4__this+0x135])`

</details>

**Buffs**

**Buff `SturmLeaperBuf`**
- `ShortRangeRate` = `(0)` _(when BuffEffectActive ne 0)_
- `LongRangeRate` = `(((int(((((Lv << 2) + lv) << 1) * rate)) lt 0 ? (int(((((Lv << 2) + lv) << 1) * rate)) + 1) : int(((((Lv << 2) + lv) << 1) * rate))) >> 1))` _(when BuffEffectActive ne 0)_
- Buff fields set in the constructor (all recovered):
  - `temporaryCount` = `-1` = -1
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `shortRange` = `0` when (OrbitReaper & 1) ne 0
  - `shortRange` = `int(((((Lv << 2) + lv) << 1) * rate))` when (OrbitReaper & 1) eq 0
  - `longRange` = `((int(((((Lv << 2) + lv) << 1) * rate)) lt 0 ? (int(((((Lv << 2) + lv) << 1) * rate)) + 1) : int(((((Lv << 2) + lv) << 1) * rate))) >> 1)` when (OrbitReaper & 1) ne 0
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:SturmLeaperBuf$$.ctor<-SturmLeaperAction.<>c__DisplayClass31_0$$<ActionStart>b__1` (no direct constructor call in the skill's own code).
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

### เซเบอร์ออร่า (SaberAura) · uid 654

<img src="../../icons/sk_654.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 4) · **Type:** Buffer · **Max Lv:** 170 · **Weapons:** TwinSword · **Requires:** เร็วดุจเทพ · **Client class:** `SaberAuraAction`

> ดาบคู่เปล่งประกายแสงศักดิ์สิทธิ์
> เพิ่มความเร็วการเคลื่อนไหวและสเตตัสต่างๆ
> ใช้ HP อย่างต่อเนื่อง ถ้าใช้ไม่ได้เมื่อไหร่ผลจะสิ้นสุดลง
> ใช้ทับซ้อนกันไม่ได้

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 654

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (4 paths)

- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(PlayerAttackBase.get_ActionID(), Lv, Id)` — when UnityEngine.Object.op_Inequality(actarAction) OR TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 657) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 657) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(657)` — when TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 657) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)

</details>

**Buffs**

**Buff `SaberAuraBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `BufferEnd`, `CheckTake`, `CheckUnableEquipChange`, `Inquire`, `get_BufEffectTakeId`, `get_IsBufferEnd`, `get_IsPutUpWeapon`

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Count | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 |
| HitUp | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |
| Value | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |
| AspdRate | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |
| AttackMprecoveryUp | 1 | 1 | 2 | 2 | 3 | 3 | 4 | 4 | 5 | 5 |
| CrtUp | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |

- Buff fields set in the constructor (all recovered):
  - `isBattleActive` = `1` = 1
  - `Count` = `1` = 1
  - `hitUp` = `(Lv + (Lv << 2))` → Lv1..10 [5, 10, 15, 20, 25, 30, 35, 40, 45, 50]
  - `strengthenInterval` = `(7 - int(((Lv + 1) * 0.5)))` → Lv1..10 [6, 6, 5, 5, 4, 4, 3, 3, 2, 2]
  - `payHp` = `(25 - (Lv << 1))` → Lv1..10 [23, 21, 19, 17, 15, 13, 11, 9, 7, 5]
  - `increase` = `5` = 5
  - `moveSpeed` = `100` = 100
  - `critical` = `int((Lv * 2.5))` → Lv1..10 [2, 5, 7, 10, 12, 15, 17, 20, 22, 25]
  - `aspdRate` = `((Lv + (Lv << 2)) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]
  - `atkMpHeal` = `(int(((Lv - 1) * 0.5)) + 1)` → Lv1..10 [1, 1, 2, 2, 3, 3, 4, 4, 5, 5]
  - `timer` = `(7 - int(((Lv + 1) * 0.5)))` → Lv1..10 [6, 6, 5, 5, 4, 4, 3, 3, 2, 2]
  - `player` = `PlayerDataManager.GetPlayerDataManager()`
- Hook `Updata`: `isBattleActive`=(PlayerActionManagerBase.get_IsBattleActive(PlayerDataManager.get_PlayerActionManager(player)) & 1); `timer`=strengthenInterval; `payHp`=System.Math.Min(99, (increase + payHp)); `inquireTime`=UnityEngine.Time.get_realtimeSinceStartup()
- Hook `Inquire`: `inquire`=1; `inquireTime`=UnityEngine.Time.get_realtimeSinceStartup()
- Hook `BufferEnd`: `bufferEnd`=1; `LeftTime`=(Count + 10)

<details><summary>Effect applied in `MobaPlayerActionManager$$get_MoveSpeed` (36 guarded paths)</summary>

- always
  - returns `SkillBufferManager.ContainsBuffer(?blr, 1223, 0, ?x3)`
  - calls `AbnormalStateManager$$Contains`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaRoomData$$get_NowGamePhase`, `PlayerActionManagerBase$$get_IsBattleActive`, `SkillBufferManager$$GetSkillBuffer`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `AbnormalStateManager$$Contains`
- always
  - returns `AbnormalStateManager.Contains(?blr, 11, 0, ?x3)`
  - calls `AbnormalStateManager$$Contains`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaRoomData$$get_NowGamePhase`, `PlayerActionManagerBase$$get_IsBattleActive`, `SkillBufferManager$$GetSkillBuffer`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `AbnormalStateManager$$Contains`
- when `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `SkillBufferManager.ContainsBuffer(?blr, 1223, 0, ?x3)`
  - calls `AbnormalStateManager$$Contains`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaRoomData$$get_NowGamePhase`, `PlayerActionManagerBase$$get_IsBattleActive`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `AbnormalStateManager$$Contains`, `GemCartBufferManager$$GetGemCartBuffer`
- when `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `AbnormalStateManager.Contains(?blr, 11, 0, ?x3)`
  - calls `AbnormalStateManager$$Contains`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaRoomData$$get_NowGamePhase`, `PlayerActionManagerBase$$get_IsBattleActive`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `AbnormalStateManager$$Contains`
- when `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `SkillBufferManager.ContainsBuffer(?blr, 1223, 0, ?x3)`
  - calls `AbnormalStateManager$$Contains`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaRoomData$$get_NowGamePhase`, `PlayerActionManagerBase$$get_IsBattleActive`, `SkillBufferManager$$GetSkillBuffer`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `AbnormalStateManager$$Contains`
- when `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `AbnormalStateManager.Contains(?blr, 11, 0, ?x3)`
  - calls `AbnormalStateManager$$Contains`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaRoomData$$get_NowGamePhase`, `PlayerActionManagerBase$$get_IsBattleActive`, `SkillBufferManager$$GetSkillBuffer`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `AbnormalStateManager$$Contains`
- when `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `SkillBufferManager.ContainsBuffer(?blr, 1223, 0, ?x3)`
  - calls `AbnormalStateManager$$Contains`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaRoomData$$get_NowGamePhase`, `PlayerActionManagerBase$$get_IsBattleActive`, `AbnormalStateManager$$Contains`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`
- when `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `AbnormalStateManager.Contains(?blr, 11, 0, ?x3)`
  - calls `AbnormalStateManager$$Contains`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaRoomData$$get_NowGamePhase`, `PlayerActionManagerBase$$get_IsBattleActive`, `AbnormalStateManager$$Contains`

</details>

<details><summary>Effect applied in `PlayerActionManager$$get_MoveSpeed` (58 guarded paths)</summary>

- always
  - returns `SkillBufferManager.ContainsBuffer(?blr, 706, 0, ?x3)`
  - calls `AbnormalStateManager$$Contains`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `PlayerActionManagerBase$$get_IsBattleActive`
- always
  - returns `AbnormalStateManager.Contains(?blr, 11, 0, ?x3)`
  - calls `AbnormalStateManager$$Contains`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `PlayerActionManagerBase$$get_IsBattleActive`
- always
  - returns `SkillBufferManager.ContainsBuffer(?blr, 706, 0, ?x3)`
  - calls `AbnormalStateManager$$Contains`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `PlayerActionManagerBase$$get_IsBattleActive`
- always
  - returns `AbnormalStateManager.Contains(?blr, 11, 0, ?x3)`
  - calls `AbnormalStateManager$$Contains`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `PlayerActionManagerBase$$get_IsBattleActive`
- always
  - returns `SkillBufferManager.ContainsBuffer(?blr, 706, 0, ?x3)`
  - calls `AbnormalStateManager$$Contains`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `PlayerActionManagerBase$$get_IsBattleActive`
- always
  - returns `AbnormalStateManager.Contains(?blr, 11, 0, ?x3)`
  - calls `AbnormalStateManager$$Contains`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `PlayerActionManagerBase$$get_IsBattleActive`
- always
  - returns `SkillBufferManager.ContainsBuffer(?blr, 706, 0, ?x3)`
  - calls `AbnormalStateManager$$Contains`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `PlayerActionManagerBase$$get_IsBattleActive`
- always
  - returns `AbnormalStateManager.Contains(?blr, 11, 0, ?x3)`
  - calls `AbnormalStateManager$$Contains`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `PlayerActionManagerBase$$get_IsBattleActive`

</details>

<details><summary>Effect applied in `ArkSaberAction$$ActionHit` (3 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `SkillBufferManager.AddSelfBuffer(?blr, 0x165db78(meta(0x399cf20, ArkSaberBuf_TypeInfo), ?x1, ?x2, ?x3), Id, 0)`
  - calls `SaberAuraBuf$$BufferEnd`, `SkillBufferManager$$RemoveSelfBuffer`, `0x165db78`, `ArkSaberBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
- when `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `0x165db84`, `0x165df00`
- when `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-56), 0) & 1) eq 0`
  - returns `SkillBufferManager.AddSelfBuffer(?blr, 0x165db78(meta(0x399cf20, ArkSaberBuf_TypeInfo), ?x1, ?x2, ?x3), Id, 0)`
  - calls `0x165db78`, `ArkSaberBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`

</details>

<details><summary>Effect applied in `ArkSaberAction$$ActionStart` (3 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `TryGetBuf.out2()`
  - set `level` = `[TryGetBuf.out2()+0x20]`
  - calls `PlayerAttackBase$$ActionStart`
- when `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `PlayerAttackBase$$ActionStart`, `0x165db84`, `0x165df00`
- when `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-40), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 654, stkp(-40), 0)`
  - calls `PlayerAttackBase$$ActionStart`

</details>

<details><summary>Effect applied in `ArkSaberAction$$ConverterArkSaberSkillId` (3 guarded paths)</summary>

- when `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 654, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `([TryGetBuf.out2()+0x50] eq 0 ? 657 : skillId)`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- when `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 654, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`, `0x165df00`
- when `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 654, stkp(-40), 0) & 1) eq 0`
  - returns `skillId`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`

</details>

<details><summary>Effect applied in `ArkSaberAction$$IsFailure` (4 guarded paths)</summary>

- when `change eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 654, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() gt 1`
  - returns `(PlayerAttackBase.IsFailure(this, status, missType, 0) & 1)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `PlayerAttackBase$$IsFailure`
- when `change eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 654, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() le 1`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `change eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 654, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
- when `change eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 654, stkp(-40), 0) & 1) eq 0`
  - returns `(PlayerAttackBase.IsFailure(this, status, missType, 0) & 1)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`

</details>

<details><summary>Effect applied in `MobaPlayerActionManager$$SupportReserve` (48 guarded paths)</summary>

- when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
  - returns `UI3DLabelManager.SetSkillMissPopUp(Singleton<object>.get_Instance(meta(0x3974690, Method$Singleton<UI3DLabelManager>.get_Instance()), ?x1, ?x2, ?x3), GetAvailableSkill.out4(), 0, ?x3)`
  - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `Singleton<object>$$get_Instance`, `UI3DLabelManager$$SetSkillMissPopUp`
- when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
  - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `0x165df00`
- when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
  - returns `UI3DLabelManager.SetSkillMissPopUp(Singleton<object>.get_Instance(meta(0x3974690, Method$Singleton<UI3DLabelManager>.get_Instance()), ?x1, ?x2, ?x3), 3, 0, ?x3)`
  - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `PlayerStatusBase$$GetEquipSkill`, `SkillComboManager$$CheckCombo`, `SkillComboState$$TemporaryUseSkill`, `AbnormalStateManager$$Contains`
- when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
  - returns `GameManager.StartSupportSkill(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), target, (GetAvailableSkill.out4() eq 6 ? 0 : SkillManager.GetAvailableSkill(CharacterActionManagerBase.get_IsDeadOrLocalDead(), this, 0, ([TryGetBuf.out2()+0x50] eq 0 ? 657 : 654))), 0)`
  - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `PlayerStatusBase$$GetEquipSkill`, `SkillComboManager$$CheckCombo`, `SkillComboState$$TemporaryUseSkill`, `AbnormalStateManager$$Contains`
- when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
  - returns `MobaPlayerActionManager.SkillReserveMpLess(this, (GetAvailableSkill.out4() eq 6 ? 0 : SkillManager.GetAvailableSkill(CharacterActionManagerBase.get_IsDeadOrLocalDead(), this, 0, ([TryGetBuf.out2()+0x50] eq 0 ? 657 : 654))), stkp(-72), ?x3)`
  - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `PlayerStatusBase$$GetEquipSkill`, `SkillComboManager$$CheckCombo`, `SkillComboState$$TemporaryUseSkill`, `AbnormalStateManager$$Contains`
- when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
  - returns `BattleManagerBase.SupportReserve(battleManager, target, (GetAvailableSkill.out4() eq 6 ? 0 : SkillManager.GetAvailableSkill(CharacterActionManagerBase.get_IsDeadOrLocalDead(), this, 0, ([TryGetBuf.out2()+0x50] eq 0 ? 657 : 654))), (([TryGetBuf.out2()+0x50] eq 0 ? 657 : 654) ne 0 ? 1 : 0))`
  - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `PlayerStatusBase$$GetEquipSkill`, `SkillComboManager$$CheckCombo`, `SkillComboState$$TemporaryUseSkill`, `AbnormalStateManager$$Contains`
- when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
  - returns `BattleManagerBase.SupportReserve(battleManager, target, (GetAvailableSkill.out4() eq 6 ? 0 : SkillManager.GetAvailableSkill(CharacterActionManagerBase.get_IsDeadOrLocalDead(), this, 0, ([TryGetBuf.out2()+0x50] eq 0 ? 657 : 654))), (([TryGetBuf.out2()+0x50] eq 0 ? 657 : 654) ne 0 ? 1 : 0))`
  - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `PlayerStatusBase$$GetEquipSkill`, `SkillComboManager$$CheckCombo`, `SkillComboState$$TemporaryUseSkill`, `AbnormalStateManager$$Contains`
- when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
  - returns `UI3DLabelManager.SetSkillMissPopUp(Singleton<object>.get_Instance(meta(0x3974690, Method$Singleton<UI3DLabelManager>.get_Instance()), ?x1, ?x2, ?x3), 3, 0, ?x3)`
  - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `PlayerStatusBase$$GetEquipSkill`, `SkillComboManager$$CheckCombo`, `AbnormalStateManager$$Contains`, `Singleton<object>$$get_Instance`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `ArkSaberAction$$ActionHit (TryGetBuf)`
- `ArkSaberAction$$ActionStart (TryGetBuf)`
- `ArkSaberAction$$ConverterArkSaberSkillId (TryGetBuf)`
- `ArkSaberAction$$IsFailure (TryGetBuf)`
- `MobaPlayerActionManager$$SupportReserve (TryGetBuf)`
- `MobaPlayerActionManager$$get_MoveSpeed (ContainsBuffer)`
- `PlayerActionManager$$get_MoveSpeed (ContainsBuffer)`
- `UIActiveBaseShortcutButton$$SkillButton (ContainsBuffer)`
- `UIGLShortcutButton$$LabelUpdate (ContainsBuffer)`
- `UIGLShortcutButton$$Update (ContainsBuffer)`
- `UIShortcutListButton$$OnSkillCostCheck (ContainsBuffer)`
- `UIShortcutListButton$$SetSkillButton (ContainsBuffer)`

---

### เอเลียสลีย์ (ArialSlay) · uid 659

<img src="../../icons/sk_659.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 4) · **Type:** Special · **Max Lv:** 170 · **Weapons:** OneHandSword, TwinSword · **Requires:** เร็วดุจเทพ · **Client class:** `ArialSlayAction`

> ฟันรัวขณะหลอกล่อศัตรู
> เมื่อใช้ในคอมโบ(ยกเว้นครั้งแรก)
> จะใช้ MP 100
> 
> สามารถเคลื่อนที่ได้ขณะใช้สกิล

<details><summary>In-game level notes</summary>

- Lv16: [ได้รับผลแบบเดียวกันเมื่อใช้กับมีดสั้น] เปิดใช้งานในสภาวะรวดเร็ว
- Lv17: ระหว่างใช้งานจะได้รับการต้านทานความเสียหายและ ต้านทานผลกระทบที่ทำให้ไม่สามารถเคลื่อนไหวได้ตามค่าถลุง  เมื่อใช้สกิล "เอเลียสลีย์" ผลของสกิล "ฟาเรส" จะยังคงอยู่
- Lv15: *สามารถเปิดใช้งานได้แม้ว่าเป้าหมายจะอยู่ห่างออกไป และเปลี่ยนเป็นความเสียหายเวทมนตร์
- Lv19: [จะได้รับผลแบบเดียวกันเมื่อใช้คัมภีร์นินจูตสึ] *สามารถเปิดใช้งานได้แม้ว่าเป้าหมายจะอยู่ห่างออกไป
- Lv10: 5MP เฮทของตัวเองจะลดลงอย่างมากเป็นเวลา 5 วินาที

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 120 | 140 | 160 | 180 | 200 | 220 | 240 | 260 | 280 | 300 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((((Lv * 50) + System.Math.Max(status.Dex, baseSTR))) / 100)`

**Role:** attack (deals damage) · buff (self) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **slot chosen at runtime (physical or magic by a per-cast flag)**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv * 20) + 100))`
- `SkillRate` multiplies by (adds into): `((((Lv * 50) + System.Math.Max(status.Dex, baseSTR))) / 100)`

**Mechanics recovered from code**

- **Base MP cost** (`baseMp`): `100` = 100 _(when combo.index ge 1)_

**Proration:** slot `dynamic`, mode `first_hit_per_target`, attack type `dynamic`, action id 659

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (24 paths)

- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)` — when ((1 << subWeaponType) & 0x888000) ne 0 AND subWeapon == OneHandSword AND subWeaponType ls 23 OR ((1 << subWeaponType) & 0x888000) ne 0 AND (subWeaponType | 2) eq 18 AND subWeapon == OneHandSword AND subWeaponType ls 23 OR ((1 << subWeaponType) & 0x888000) ne 0 AND (subWeaponType | 2) ne 18 AND subWeapon == OneHandSword AND subWeaponType ls 23
- set `fixAddDamage` = `((Lv * 20) + 100)` → Lv1..10: [120, 140, 160, 180, 200, 220, 240, 260, 280, 300] — when (subWeaponType | 2) eq 18 AND subWeapon == OneHandSword AND subWeaponType hi 23 OR (subWeaponType | 2) ne 18 AND subWeapon == OneHandSword AND subWeaponType hi 23 OR (subWeaponType | 2) eq 18 AND subWeapon != OneHandSword AND subWeaponType hi 23
- set `skillRate` = `((Lv * 50) + System.Math.Max(status.Dex, baseSTR))` — when (subWeaponType | 2) eq 18 AND subWeapon != OneHandSword AND subWeaponType hi 23 OR ((1 << subWeaponType) & 0x888000) ne 0 AND (subWeaponType | 2) eq 18 AND subWeapon != OneHandSword AND subWeaponType ls 23 OR ((1 << subWeaponType) & 0x888000) eq 0 AND (subWeaponType | 2) eq 18 AND subWeapon != OneHandSword AND subWeaponType ls 23
- set `attackType` = `2` = 2 — when (subWeaponType | 2) ne 18 AND subWeapon != OneHandSword AND subWeapon == Magictool AND subWeaponType hi 23 OR ((1 << subWeaponType) & 0x888000) ne 0 AND (subWeaponType | 2) ne 18 AND subWeapon != OneHandSword AND subWeapon == Magictool AND subWeaponType ls 23 OR ((1 << subWeaponType) & 0x888000) eq 0 AND (subWeaponType | 2) ne 18 AND subWeapon != OneHandSword AND subWeapon == Magictool AND subWeaponType ls 23
- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))` — when subWeapon == OneHandSword AND subWeaponType hi 23 OR ((1 << subWeaponType) & 0x888000) eq 0 AND subWeapon == OneHandSword AND subWeaponType ls 23 OR (subWeaponType | 2) eq 18 AND subWeapon == OneHandSword AND subWeaponType hi 23

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`

**`ActionStart`** (21 paths)

- set `isMoveAssist` = `0` = 0 — when !PlayerAttackBase.IsBlank(this) AND SubWeaponType eq 17 AND SubWeaponType ne 10 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND hasBuff(519) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND SubWeaponType eq 17 AND SubWeaponType ne 10 AND hasBuff(519) OR !PlayerAttackBase.IsBlank(this) AND SubWeaponType ne 10 AND SubWeaponType ne 17 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND hasBuff(519)
- set `charaMove` = `UnityEngine.Component.GetComponent<CharacterMove>(actarAction)` — when !PlayerAttackBase.IsBlank(this) AND SubWeaponType eq 17 AND SubWeaponType ne 10 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND hasBuff(519) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND SubWeaponType eq 17 AND SubWeaponType ne 10 AND hasBuff(519) OR !PlayerAttackBase.IsBlank(this) AND !hasBuff(519) AND SubWeaponType eq 17 AND SubWeaponType ne 10 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0)
- set `enableMove` = `1` = 1 — when !PlayerAttackBase.IsBlank(this) AND SubWeaponType eq 17 AND SubWeaponType ne 10 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND hasBuff(519) OR !PlayerAttackBase.IsBlank(this) AND !hasBuff(519) AND SubWeaponType eq 17 AND SubWeaponType ne 10 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) OR !PlayerAttackBase.IsBlank(this) AND SubWeaponType ne 10 AND SubWeaponType ne 17 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND hasBuff(519)
- calls `ArialSlayBuf..ctor` = `.ctor(Lv, PlayerActionManagerBase.get_PlayerStatus())` — when !PlayerAttackBase.IsBlank(this) AND SubWeaponType eq 17 AND SubWeaponType ne 10 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND hasBuff(519) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND SubWeaponType eq 17 AND SubWeaponType ne 10 AND hasBuff(519) OR !PlayerAttackBase.IsBlank(this) AND !hasBuff(519) AND SubWeaponType eq 17 AND SubWeaponType ne 10 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new ArialSlayBuf, Id)` — when !PlayerAttackBase.IsBlank(this) AND SubWeaponType eq 17 AND SubWeaponType ne 10 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND hasBuff(519) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND SubWeaponType eq 17 AND SubWeaponType ne 10 AND hasBuff(519) OR !PlayerAttackBase.IsBlank(this) AND !hasBuff(519) AND SubWeaponType eq 17 AND SubWeaponType ne 10 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0)
- set `isMoveAssist` = `[skillMaster+0x30]` — when !PlayerAttackBase.IsBlank(this) AND !hasBuff(519) AND SubWeaponType eq 17 AND SubWeaponType ne 10 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND !hasBuff(519) AND SubWeaponType eq 17 AND SubWeaponType ne 10 OR !PlayerAttackBase.IsBlank(this) AND !hasBuff(519) AND SubWeaponType ne 10 AND SubWeaponType ne 17 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0)
- set `SkillIndividualFlag` = `1` = 1 — when !PlayerAttackBase.IsBlank(this) AND SubWeaponType eq 10 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND hasBuff(519) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND SubWeaponType eq 10 AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND hasBuff(519) OR !PlayerAttackBase.IsBlank(this) AND !hasBuff(519) AND SubWeaponType eq 10 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0)

**`ChangeMpDuringCombo`** (2 paths)

- set `baseMp` = `100` = 100 — when combo.index ge 1

**`calcPlayerToMobDamage`** (4 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- info `templates` = `1`

**`Damaged`** (4 paths)

- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(0, 0)` — when EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 17 AND SkillDamageData.IsInactivityAbnormal(damageData) AND hasBuff(659)

**`ActionSkillEvent`** (6 paths)

- set `enableMove` = `0` = 0 — when UnityEngine.Object.op_Inequality(charaMove) AND param eq 101 OR !UnityEngine.Object.op_Inequality(charaMove) AND param eq 101

**`.<>c__DisplayClass30_0::<ActionStart>b__0`** (1 path)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(659)`

</details>

**Buffs**

**Buff `ArialSlayBuf`**
- Duration: `5` s [EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 10 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 17]
- `MobLastDamageRateBuf` = `System.Math.Min(((ItemData.get_Refine((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()))) & 255) << 1), 30)` _(when subWeapon.Type eq 17)_
- `MobLastDamageRateBuf` = `0` _(when subWeapon.Type ne 17)_
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `flag` = `1024` = 1024 when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 10 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 17 OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 10 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 17
  - `flag` = `3072` = 3072 when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17
  - `subWeapon` = `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())` when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 10 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 17 OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 10 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 17
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:ArialSlayBuf$$.ctor<-ArialSlayAction$$ActionStart` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

<details><summary>Effect applied in `ArialSlayAction$$Damaged` (4 guarded paths)</summary>

- always
  - calls `EquipItemData$$get_SubWeaponItemType`, `SkillDamageData$$IsInactivityAbnormal`, `SkillDamageData$$SetAbnormalType`
- always
  - returns `SkillDamageData.IsInactivityAbnormal(damageData, 0, ?x2, ?x3)`
  - calls `EquipItemData$$get_SubWeaponItemType`, `SkillDamageData$$IsInactivityAbnormal`
- always
  - returns `EquipItemData.get_SubWeaponItemType(?blr, 0, ?x2, ?x3)`
  - calls `EquipItemData$$get_SubWeaponItemType`
- always
  - returns `SkillBufferManager.ContainsBuffer(?blr, 659, 0, ?x3)`

</details>

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

- `ArialSlayAction$$Damaged (ContainsBuffer)`
- `MobAttackBase$$CalcLastDamage (TryGetBuf)`

---

### ลูนาดิธเธอร์สตาร์ (LunaDitherStar) · uid 655

<img src="../../icons/sk_655.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 5) · **Type:** Attack · **Max Lv:** 250 · **Weapons:** TwinSword · **Requires:** [N]ไชน์นิ่งครอส[N2]เบลซซิ่งไชน์นิ่งครอส[N] · **Client class:** `LunaDitherStarAction`

> เงาจันทร์เปล่งประกาย ธาตุคู่(ดาบมือเดียว)
> หลังใช้งานถ้ากดปุ่มเคลื่อนที่ถอยหลังจะถอยกลับทันที
> และแทงศัตรูด้วยดาบแสงจันทร์

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((((status.Dex / 1.5) + ((Lv * 50) + 500))) / 100)` — (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, mobAction, meta(0x39a82c0, Method$System.Collections.Generic.Dictionary<MobActionManagerBase, int>.ContainsKey())) & 1) eq 0

**Role:** attack (deals damage) · buff (self)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(400)`
- `FirstAttack` adds: `PlayerAttackBase.calcFastAttackDamage(this, playerAction)`
- `SkillRate` multiplies by (adds into): `((((status.Dex / 1.5) + ((Lv * 50) + 500))) / 100)`
- `FirstAttackRate` multiplies by (adds into): `(PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100)`

**Mechanics recovered from code**

- **Base MP cost** (`baseMp`): `(hasGemCart(1040) ? 300 : 400)`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 655

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`
- set `Element` = `6` = 6
- set `SubElement` = `BonusManager.GetEquipElement(PlayerStatusBase.get_BonusManager(), 2)`
- set `baseMp` = `(hasGemCart(1040) ? 300 : 400)`
- set `crossSkillRate` = `((status.Dex / 1.5) + ((Lv * 50) + 500))`
- set `crossFixAddDamage` = `400` = 400
- set `SkillParam` = `(SkillParam | 2)`

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`OtherPlayerSkillEventReceive`** (3 paths)

- set `bladeRain` = `1` = 1 — when (skillEventId & 0xffff) eq 100 AND (skillEventId & 0xffff) ne 102
- set `otherInterruptable` = `1` = 1 — when (skillEventId & 0xffff) eq 102

**`ActionStart`** (14 paths)

- set `isAssault` = `1` = 1 — when !GemCartBufferBase.get_IsCoolDown(GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1047)) AND !PlayerAttackBase.IsBlank(this) AND (System.Linq.Enumerable.Any<SkillActionBase.ApplyBufferData>(temporaryApplySkillBuffer, LunaDitherStarAction.<>c.<>9__46_0) & 1) ne 0 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !GemCartBufferBase.get_IsCoolDown(GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1047)) AND !PlayerAttackBase.IsBlank(this) AND (System.Linq.Enumerable.Any<SkillActionBase.ApplyBufferData>(temporaryApplySkillBuffer, LunaDitherStarAction.<>c.<>9__46_0) & 1) ne 0 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 OR !GemCartBufferBase.get_IsCoolDown(GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1047)) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND (System.Linq.Enumerable.Any<SkillActionBase.ApplyBufferData>(temporaryApplySkillBuffer, LunaDitherStarAction.<>c.<>9__46_0) & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05
- set `mainTarget` = `UnityEngine.GameObject.get_transform(target)` — when !PlayerAttackBase.IsBlank(this) AND (System.Linq.Enumerable.Any<SkillActionBase.ApplyBufferData>(temporaryApplySkillBuffer, LunaDitherStarAction.<>c.<>9__46_0) & 1) eq 0 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND (System.Linq.Enumerable.Any<SkillActionBase.ApplyBufferData>(temporaryApplySkillBuffer, LunaDitherStarAction.<>c.<>9__46_0) & 1) eq 0 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND (System.Linq.Enumerable.Any<SkillActionBase.ApplyBufferData>(temporaryApplySkillBuffer, LunaDitherStarAction.<>c.<>9__46_0) & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05
- set `attackStartTargetDist` = `max((fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) - MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))), 0)` — when !PlayerAttackBase.IsBlank(this) AND (System.Linq.Enumerable.Any<SkillActionBase.ApplyBufferData>(temporaryApplySkillBuffer, LunaDitherStarAction.<>c.<>9__46_0) & 1) eq 0 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND (System.Linq.Enumerable.Any<SkillActionBase.ApplyBufferData>(temporaryApplySkillBuffer, LunaDitherStarAction.<>c.<>9__46_0) & 1) eq 0 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND (System.Linq.Enumerable.Any<SkillActionBase.ApplyBufferData>(temporaryApplySkillBuffer, LunaDitherStarAction.<>c.<>9__46_0) & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05

**`ActionSkillEvent`** (20 paths)

- set `bladeRain` = `1` = 1 — when !UnityEngine.Object.op_Equality(actarAction) AND !UnityEngine.Object.op_Inequality(actarAction) AND IsOtherPlayer ne 0 AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Inequality(actarAction) AND IsOtherPlayer ne 0 AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Inequality(actarAction) AND IsOtherPlayer ne 0 AND MobaMode eq 0 AND UnityEngine.Object.op_Equality(actarAction) AND param eq 100 AND param ne 101
- calls `WrapAroundBuf..ctor` = `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 651, 1))` — when !UnityEngine.Object.op_Equality(actarAction) AND (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 651, 1) & 255) ne 0 AND IsInstanceOf(actarAction.battleManager, PlayerBattleManager) eq 1 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 651, 1) & 255) ne 0 AND IsInstanceOf(actarAction.battleManager, PlayerBattleManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 100 AND param ne 101 OR (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 651, 1) & 255) ne 0 AND IsInstanceOf(actarAction.battleManager, PlayerBattleManager) eq 1 AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 100 AND param ne 101
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new WrapAroundBuf, Id)` — when !UnityEngine.Object.op_Equality(actarAction) AND (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 651, 1) & 255) ne 0 AND IsInstanceOf(actarAction.battleManager, PlayerBattleManager) eq 1 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 651, 1) & 255) ne 0 AND IsInstanceOf(actarAction.battleManager, PlayerBattleManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 100 AND param ne 101 OR (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 651, 1) & 255) ne 0 AND IsInstanceOf(actarAction.battleManager, PlayerBattleManager) eq 1 AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 100 AND param ne 101
- set `interruptable` = `1` = 1 — when param eq 101

**`CheckRangeHit`** (2 paths)

- set `attackPos.y` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(mainTarget)).y` — when UnityEngine.Object.op_Equality(mainTarget, targetTransform)
- set `attackPos.z` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(mainTarget)).z` — when UnityEngine.Object.op_Equality(mainTarget, targetTransform)

**`ActionSkillEventIfMoveIndex`** (6 paths)

- set `bladeRain` = `1` = 1 — when !UnityEngine.Object.op_Equality(mainTarget) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(mainTarget)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(mainTarget)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(mainTarget)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(mainTarget)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !UnityEngine.Object.op_Equality(mainTarget) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(mainTarget)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(mainTarget)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(mainTarget)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(mainTarget)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05

**`calcPlayerToMobDamage`** (6 paths)

- template `AddRate[SkillRate]` = `(crossSkillRate / 100)` — when (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, mobAction, meta(0x39a82c0, Method$System.Collections.Generic.Dictionary<MobActionManagerBase, int>.ContainsKey())) & 1) eq 0
- template `AddConstant[SkillConstantDamage]` = `crossFixAddDamage` — when (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, mobAction, meta(0x39a82c0, Method$System.Collections.Generic.Dictionary<MobActionManagerBase, int>.ContainsKey())) & 1) eq 0
- template `AddRate[FirstAttackRate]` = `(PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100)` — when (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, mobAction, meta(0x39a82c0, Method$System.Collections.Generic.Dictionary<MobActionManagerBase, int>.ContainsKey())) & 1) eq 0
- template `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` — when (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, mobAction, meta(0x39a82c0, Method$System.Collections.Generic.Dictionary<MobActionManagerBase, int>.ContainsKey())) & 1) eq 0
- calls `SkillDamageData.CreateNextDamage` = `CreateNextDamage()` — when (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, mobAction, meta(0x39a82c0, Method$System.Collections.Generic.Dictionary<MobActionManagerBase, int>.ContainsKey())) & 1) eq 0
- info `templates` = `1` — when (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, mobAction, meta(0x39a82c0, Method$System.Collections.Generic.Dictionary<MobActionManagerBase, int>.ContainsKey())) & 1) eq 0

**`RegistInterruptableSkill`** (1 path)

- set `registSkillId` = `skillId`

**`SetNextAction`** (2 paths)

- set `nextAction` = `nextAction` — when SkillActionBase.get_ActionID() eq registSkillId

**`ReceivedAbnormal`** (3 paths)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(671)` — when AbnormalTypeEx.IsActionStop(type) AND hasBuff(671)

</details>

**Buffs**

**Buff `WrapAroundBuf`**

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| CrtUpRate | 20 | 40 | 60 | 80 | 100 | 120 | 140 | 160 | 180 | 200 |
| AttackMprecoveryUp | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |

- Buff fields set in the constructor (all recovered):
  - `temporaryCount` = `-1` = -1
  - `crtRate` = `(((Lv << 2) + lv) << 2)` → Lv1..10 [20, 40, 60, 80, 100, 120, 140, 160, 180, 200]
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:WrapAroundBuf$$.ctor<-LunaDitherStarAction$$ActionSkillEvent` (no direct constructor call in the skill's own code).
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

<details><summary>Effect applied in `ShiningClothAction$$OnInitialize` (2 guarded paths)</summary>

- always
  - set `Element` = `5`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `skillRate` = `(((Lv * 10) + 300) + (((IPlayerStatusCalculator.get_Agi(?blr) // 4) + (IPlayerStatusCalculator.get_Str(?blr) // 4)) + (IPlayerStatusCalculator.get_Dex(?blr) // 4)))`
  - set `fixAddDamage` = `((Lv * 20) + 100)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `change` = `1`
  - set `SkillIndividualFlag` = `0x10000`
  - set `LoopParam` = `SubElement`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMp`, `PlayerAttackBase$$CalcMotionSpeed`, `interface IPlayerStatusCalculator.get_Str`, `interface IPlayerStatusCalculator.get_Agi`, `interface IPlayerStatusCalculator.get_Dex`, `0x165db78`, `SkillLinkedTake$$.ctor`
- always
  - set `Element` = `5`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `skillRate` = `(((Lv * 10) + 300) + (((IPlayerStatusCalculator.get_Agi(?blr) // 5) + (IPlayerStatusCalculator.get_Str(?blr) // 5)) + (IPlayerStatusCalculator.get_Dex(?blr) // 5)))`
  - set `fixAddDamage` = `((Lv * 20) + 100)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `SkillIndividualFlag` = `0`
  - set `LoopParam` = `SubElement`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMp`, `PlayerAttackBase$$CalcMotionSpeed`, `interface IPlayerStatusCalculator.get_Str`, `interface IPlayerStatusCalculator.get_Agi`, `interface IPlayerStatusCalculator.get_Dex`, `0x165db78`, `SkillLinkedTake$$.ctor`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `ShiningClothAction$$OnInitialize (ContainsBuffer)`

---

### ทวินบัสตาร์ดเบลด (TwinBusterBlade) · uid 656

<img src="../../icons/sk_656.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 5) · **Type:** Attack · **Max Lv:** 250 · **Weapons:** TwinSword · **Requires:** [N]ไชน์นิ่งครอส[N2]เบลซซิ่งไชน์นิ่งครอส[N] · **Client class:** `TwinBusterBladeAction`

> ฟันต่อเนื่องสองครั้งพร้อมออร่า
> เป็นการโจมตีสองครั้งที่มีโอกาสติดคริติคอลสูง
> 
> ครั้งที่ 1 จะฟันเป้าหมายอย่างต่อเนื่อง
> ครั้งที่ 2 โจมตีแบบวงกว้างความแรง
> จะเพิ่มขึ้นตามจำนวนเป้าหมายที่ถูกโจมตี

<details><summary>In-game level notes</summary>

- Lv10: ถ้าเรียนรู้บัสตาร์ดเบลดแล้วจะได้รับผลของบัฟที่เหมือนกัน

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 5 | 5 | 5 | 5 | 5 | 5 | 5 | 5 | 5 | 5 |
| Flat dmg + [lineAttack ne 0] | 30 | 60 | 90 | 120 | 150 | 180 | 210 | 240 | 270 | 300 |
| Flat dmg + [(System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND lineAttack eq 0 OR (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND MobActionManagerBase.get_SystemInvincible(mobAction) AND lineAttack eq 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND lineAttack eq 0] | 30 | 60 | 90 | 120 | 150 | 180 | 210 | 240 | 270 | 300 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((500) / 100)` — IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(targetTransform) AND isExorcism ne 0 AND param eq 100 & lineAttack ne 0
- SkillRate × `((500) / 100)` — !UnityEngine.Object.op_Inequality(actarAction) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform), 0) AND UnityEngine.Object.op_Inequality(targetTransform) AND isExorcism ne 0 AND param eq 100 & lineAttack ne 0
- SkillRate × `((500) / 100)` — !UnityEngine.Object.op_Inequality(targetTransform) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND isExorcism ne 0 AND param eq 100 OR !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform), 0) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(targetTransform) AND isExorcism ne 0 AND param eq 100 & lineAttack ne 0
- SkillRate × `((((Lv * 75) + (((baseDEX + baseAGI) lt 0 ? ((baseDEX + baseAGI) + 1) : (baseDEX + baseAGI)) >> 1))) / 100)` — (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND lineAttack eq 0 OR (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND MobActionManagerBase.get_SystemInvincible(mobAction) AND lineAttack eq 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND lineAttack eq 0

**Role:** attack (deals damage) · buff (self)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `((Lv * 30))`
- `FirstAttack` adds: `PlayerAttackBase.calcFastAttackDamage(this, playerAction)`
- `SkillRate` multiplies by (adds into): `((500) / 100)` | `((((Lv * 75) + (((baseDEX + baseAGI) lt 0 ? ((baseDEX + baseAGI) + 1) : (baseDEX + baseAGI)) >> 1))) / 100)`
- `FirstAttackRate` multiplies by (adds into): `(PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100)`
- `ExpRate` sets: `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefSkill / 100)` | `(targetExpList[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**Mechanics recovered from code**

- **First-part skill multiplier (%)** (`firstSkillRate`): `((Lv * 75) + (((baseDEX + baseAGI) lt 0 ? ((baseDEX + baseAGI) + 1) : (baseDEX + baseAGI)) >> 1))`
- **Second-part multiplier** (`secondSkillRate`): `500` = 500; `min((secondSkillRate + ((baseSTR * 0.5) * ((maxDebufCount lt MobBuffManager.GetDebuffCount(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform))) ? maxDebufCount : MobBuffManager.GetDebuffCount(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform)))) + 1))), 2000)` _(when IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(targetTransform) AND isExorcism ne 0 AND param eq 100)_; `min((secondSkillRate + (0.5 * ((maxDebufCount lt MobBuffManager.GetDebuffCount(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform))) ? maxDebufCount : MobBuffManager.GetDebuffCount(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform)))) + 1))), 2000)` _(when !UnityEngine.Object.op_Inequality(actarAction) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform), 0) AND UnityEngine.Object.op_Inequality(targetTransform) AND isExorcism ne 0 AND param eq 100)_
- **First-part flat damage** (`firstFixAddDamage`): `(Lv * 30)` → Lv1..10 [30, 60, 90, 120, 150, 180, 210, 240, 270, 300]
- **Second-part flat damage** (`secondFixAddDamage`): `(Lv * 30)` → Lv1..10 [30, 60, 90, 120, 150, 180, 210, 240, 270, 300]

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 656

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(7)`
- set `firstSkillRate` = `((Lv * 75) + (((baseDEX + baseAGI) lt 0 ? ((baseDEX + baseAGI) + 1) : (baseDEX + baseAGI)) >> 1))`
- set `secondSkillRate` = `500` = 500
- set `firstFixAddDamage` = `(Lv * 30)` → Lv1..10: [30, 60, 90, 120, 150, 180, 210, 240, 270, 300]
- set `secondFixAddDamage` = `(Lv * 30)` → Lv1..10: [30, 60, 90, 120, 150, 180, 210, 240, 270, 300]
- set `lineAttackRange` = `MathUtil.DisplayMeterToDistance(6)`
- set `lineAttackWidth` = `MathUtil.DisplayMeterToDistance(1.5)`
- set `SkillParam` = `(SkillParam | 2)`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`

**`ActionStart`** (43 paths)

- set `targetTransform` = `UnityEngine.GameObject.get_transform(target)` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND !UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND !UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05
- set `attackStartPos.y` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND !UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND !UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05
- set `attackStartPos.z` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND !UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND !UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05
- set `attackStartDir` = `UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(actarAction)).x` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND !UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND !UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05
- set `attackStartDir.y` = `UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(actarAction)).y` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND !UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND !UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05
- set `attackStartDir.z` = `UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(actarAction)).z` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND !UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND !UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05
- set `isExorcism` = `1` = 1 — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 45, 1) lt 1 AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND !UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 45, 1) lt 1 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 45, 1) lt 1 AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05
- set `maxDebufCount` = `gemCart(1048[2])` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 45, 1) lt 1 AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND !UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 45, 1) lt 1 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 45, 1) lt 1 AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05
- set `debufCount` = `(gemCart(1048[2]) lt MobBuffManager.GetDebuffCount(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target))) ? gemCart(1048[2]) : MobBuffManager.GetDebuffCount(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target))))` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 45, 1) lt 1 AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 45, 1) lt 1 AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 OR !PlayerAttackBase.IsBlank(this) AND MobaMode ne 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 45, 1) lt 1 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05
- calls `TwinBusterBladeAction.<>c__DisplayClass39_0..ctor` = `.ctor()` — when PlayerAttackBase.IsBlank(this) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND !UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND !UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05

**`ActionSkillEvent`** (26 paths)

- set `lineAttack` = `1` = 1 — when !MobActionManagerBase.get_IsDeadOrLocalDead(?stack) AND IsOtherPlayer eq 0 AND isExorcism eq 0 AND param eq 100 OR IsOtherPlayer eq 0 AND MobActionManagerBase.get_IsDeadOrLocalDead(?stack) AND isExorcism eq 0 AND param eq 100 OR IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND isExorcism eq 0 AND param eq 100
- set `debufCount` = `(maxDebufCount lt MobBuffManager.GetDebuffCount(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform))) ? maxDebufCount : MobBuffManager.GetDebuffCount(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform))))` — when IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(targetTransform) AND isExorcism ne 0 AND param eq 100 OR !UnityEngine.Object.op_Inequality(actarAction) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform), 0) AND UnityEngine.Object.op_Inequality(targetTransform) AND isExorcism ne 0 AND param eq 100
- set `secondSkillRate` = `min((secondSkillRate + ((baseSTR * 0.5) * ((maxDebufCount lt MobBuffManager.GetDebuffCount(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform))) ? maxDebufCount : MobBuffManager.GetDebuffCount(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform)))) + 1))), 2000)` — when IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(targetTransform) AND isExorcism ne 0 AND param eq 100
- set `secondSkillRate` = `min((secondSkillRate + (0.5 * ((maxDebufCount lt MobBuffManager.GetDebuffCount(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform))) ? maxDebufCount : MobBuffManager.GetDebuffCount(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform)))) + 1))), 2000)` — when !UnityEngine.Object.op_Inequality(actarAction) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform), 0) AND UnityEngine.Object.op_Inequality(targetTransform) AND isExorcism ne 0 AND param eq 100
- set `secondSkillRate` = `min((secondSkillRate + ((baseSTR * 0.5) * (debufCount + 1))), 2000)` — when !UnityEngine.Object.op_Inequality(targetTransform) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND isExorcism ne 0 AND param eq 100 OR !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform), 0) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(targetTransform) AND isExorcism ne 0 AND param eq 100
- set `secondSkillRate` = `min((secondSkillRate + (0.5 * (debufCount + 1))), 2000)` — when !UnityEngine.Object.op_Inequality(actarAction) AND !UnityEngine.Object.op_Inequality(targetTransform) AND IsOtherPlayer eq 0 AND isExorcism ne 0 AND param eq 100 OR !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform), 0) AND !UnityEngine.Object.op_Inequality(actarAction) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(targetTransform) AND isExorcism ne 0 AND param eq 100
- set `secondSkillRate` = `min((secondSkillRate + ((baseSTR * 0.5) * (TwinBusterBladeAction.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), MobActionManagerBase.get_transform(?stack), MobActionManagerBase.get_Size(?stack)) & 1))), 2000)` — when !MobActionManagerBase.get_IsDeadOrLocalDead(?stack) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND isExorcism eq 0 AND param eq 100
- set `secondSkillRate` = `min((secondSkillRate + (0.5 * (TwinBusterBladeAction.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), MobActionManagerBase.get_transform(?stack), MobActionManagerBase.get_Size(?stack)) & 1))), 2000)` — when !MobActionManagerBase.get_IsDeadOrLocalDead(?stack) AND !UnityEngine.Object.op_Inequality(actarAction) AND IsOtherPlayer eq 0 AND isExorcism eq 0 AND param eq 100
- set `secondSkillRate` = `min((secondSkillRate + ((baseSTR * 0.5) * 0)), 2000)` — when IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND isExorcism eq 0 AND param eq 100
- set `secondSkillRate` = `min(secondSkillRate, 2000)` — when !UnityEngine.Object.op_Inequality(actarAction) AND IsOtherPlayer eq 0 AND isExorcism eq 0 AND param eq 100

**`calcPlayerToMobDamage`** (10 paths)

- template `AddRate[SkillRate]` = `(secondSkillRate / 100)` — when lineAttack ne 0
- template `AddConstant[SkillConstantDamage]` = `secondFixAddDamage` — when lineAttack ne 0
- template `AddRate[FirstAttackRate]` = `(PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100)` — when lineAttack ne 0
- template `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, playerAction)` — when lineAttack ne 0
- template `SetRate[ExpRate]` = `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefSkill / 100)` — when lineAttack ne 0
- info `templates` = `1` — when lineAttack ne 0 OR (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND lineAttack eq 0 OR (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND MobActionManagerBase.get_SystemInvincible(mobAction) AND lineAttack eq 0
- template `SetRate[ExpRate]` = `(targetExpList[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` — when lineAttack ne 0
- template `AddRate[SkillRate]` = `(firstSkillRate / 100)` — when (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND lineAttack eq 0 OR (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND MobActionManagerBase.get_SystemInvincible(mobAction) AND lineAttack eq 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND lineAttack eq 0
- template `AddConstant[SkillConstantDamage]` = `firstFixAddDamage` — when (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND lineAttack eq 0 OR (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND MobActionManagerBase.get_SystemInvincible(mobAction) AND lineAttack eq 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND lineAttack eq 0
- calls `SkillDamageData.CreateNextDamage` = `CreateNextDamage()` — when (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND lineAttack eq 0 OR (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND MobActionManagerBase.get_SystemInvincible(mobAction) AND lineAttack eq 0

**`.<>c__DisplayClass39_0::<ActionStart>b__0`** (4 paths)

- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(45, <>c__DisplayClass39_0.sLv, 0)` — when !hasBuff(FirstAttackRate) AND (cancel & 1) eq 0 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<TakeController>(<>c__DisplayClass39_0.playerAction), 0) OR !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<TakeController>(<>c__DisplayClass39_0.playerAction), 0) AND !hasBuff(FirstAttackRate) AND (cancel & 1) eq 0

</details>

---

### อาร์คเซเบอร์ (ArkSaber) · uid 657

<img src="../../icons/sk_657.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 5) · **Type:** Buffer · **Max Lv:** 250 · **Weapons:** TwinSword · **Requires:** เซเบอร์ออร่า · **Client class:** `ArkSaberAction` · **Client class:** `ArkSaber` (passive mastery)

> สกิลพิเศษที่สามารถเปิดใช้งานระหว่างใช้เซเบอร์ออร่า
> ช่วยฟื้นฟู HP และจำนวน Avoid
> การใช้ MP นอกเหนือจากสกิลเวทมนตร์จะลดลงครึ่งหนึ่งเสมอ
> พร้อมกับอัตราคริติคอลที่เพิ่มขึ้นเป็นอย่างมาก
> แต่ถ้าโดนศัตรูโจมตีล่ะก็...

**Role:** buff (self) · passive mastery

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 657

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionStart`** (4 paths)

- set `level` = `[TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 654)+0x20]` — when TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 654) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)

**`ActionHit`** (4 paths)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(654)` — when TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 654) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- calls `ArkSaberBuf..ctor` = `.ctor(Lv, level)` — when UnityEngine.Object.op_Inequality(actarAction) OR TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 654) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new ArkSaberBuf, Id)` — when UnityEngine.Object.op_Inequality(actarAction) OR TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 654) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)

**`LunaDitherStartInterruptableInitialize`** (1 path)

- set `change` = `1` = 1

</details>

**Buffs**

**Buff `ArkSaberBuf`**
- Buff hook methods: `BufferEnd`, `get_BufEffectTakeId`
- Duration: `((count + (count << 1)) gt 10 ? (count + (count << 1)) : 10)` s
- `Count` = `(count)` _(when BuffEffectActive ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 80 | 80 | 80 | 80 | 80 | 80 | 80 | 80 | 80 | 80 |
| AttackMprecoveryUp | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |
| CrtUp | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |

- Buff fields set in the constructor (all recovered):
  - `count` = `count`
  - `critical` = `(((Lv << 2) + lv) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]
  - `barrierValue` = `80` = 80
  - `atkMpRecovery` = `(Lv << 1)` → Lv1..10 [2, 4, 6, 8, 10, 12, 14, 16, 18, 20]
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:ArkSaberBuf$$.ctor<-ArkSaberAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

<details><summary>Effect applied in `PlayerAttackBase$$RemoveAfterSkillBuf` (198 guarded paths, truncated)</summary>

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

<details><summary>Effect applied in `MobaPlayerSecondaryStatus$$GetCrtConstant` (299 guarded paths, truncated)</summary>

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

</details>

<details><summary>Effect applied in `PlayerSecondaryStatus$$GetCrtConstant` (299 guarded paths, truncated)</summary>

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

</details>

<details><summary>Effect applied in `ArkSaberAction$$ConverterArkSaberSkillId` (4 guarded paths)</summary>

- when `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 654, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `([TryGetBuf.out2()+0x50] eq 0 ? 657 : skillId)`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- when `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 654, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`, `0x165df00`
- when `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 654, stkp(-40), 0) & 1) eq 0`
  - returns `skillId`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- when `SkillLv(657) lt 1`
  - returns `skillId`
  - calls `virtual PlayerStatusBase.get_SkillManager`

</details>

<details><summary>Effect applied in `ArkSaber$$CalcConstantDamage` (3 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 657, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `max((int((((max((IPlayerStatusCalculator.get_Critical(?blr) - 100), 0) - max((MobPropertyCriticalResist.GetCriticalResist(0, mobAction, 0, 0x165da60([((vtab(mobAction) + (([(meta(0) + 8)+0x0] + meta(0)) << 4)) + 312)+0x8], meta(0x399fbb8, Method$MobActionManagerBase.TryGetProperties<MobPropertyCriticalResist>()), meta(0), ?x3)) - 100), 0)) / 10) * [TryGetBuf.out2()+0x10])) lt 200 ? int((((max((IPlayerStatusCalculator.get_Critical(?blr) - 100), 0) - max((MobPropertyCriticalResist.GetCriticalResist(0, mobAction, 0, 0x165da60([((vtab(mobAction) + (([(meta(0) + 8)+0x0] + meta(0)) << 4)) + 312)+0x8], meta(0x399fbb8, Method$MobActionManagerBase.TryGetProperties<MobPropertyCriticalResist>()), meta(0), ?x3)) - 100), 0)) / 10) * [TryGetBuf.out2()+0x10])) : 200), 0)`
  - calls `0x165da60`, `MobPropertyCriticalResist$$GetCriticalResist`, `interface IPlayerStatusCalculator.get_Critical`
- when `(SkillBufferManager.TryGetBuf(?blr, 657, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `0x165da60`, `MobPropertyCriticalResist$$GetCriticalResist`, `interface IPlayerStatusCalculator.get_Critical`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(?blr, 657, stkp(-40), 0) & 1) eq 0`
  - returns `0`

</details>

<details><summary>Effect applied in `SaberAuraAction$$ActionHit` (3 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 657, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 657, 0, ?x3)`
  - calls `virtual PlayerAttackBase.get_ActionID`, `SkillBufferManager$$AddSelfBuffer`, `ArkSaberBuf$$BufferEnd`, `SkillBufferManager$$RemoveSelfBuffer`
- when `(SkillBufferManager.TryGetBuf(?blr, 657, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual PlayerAttackBase.get_ActionID`, `SkillBufferManager$$AddSelfBuffer`, `0x165db84`, `0x165df00`
- when `(SkillBufferManager.TryGetBuf(?blr, 657, stkp(-40), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 657, stkp(-40), 0)`
  - calls `virtual PlayerAttackBase.get_ActionID`, `SkillBufferManager$$AddSelfBuffer`

</details>

<details><summary>Effect applied in `PlayerDataManager$$OnSkillBuffEnd` (3 guarded paths)</summary>

- when `TryGetBuf.out2() ne 0`
  - returns `SkillBufferManager.RemoveSelfBuffer(PlayerDataManager.get_SkillBufferManager(this, ?x1, ?x2, ?x3), 657, 0, ?x3)`
  - calls `PlayerDataManager$$UpdateServerHP`, `PlayerDataManager$$UpdateServerMp`, `PlayerDataManager$$get_SkillBufferManager`, `ArkSaberBuf$$BufferEnd`, `PlayerDataManager$$get_SkillBufferManager`, `SkillBufferManager$$RemoveSelfBuffer`
- when `TryGetBuf.out2() eq 0`
  - calls `PlayerDataManager$$UpdateServerHP`, `PlayerDataManager$$UpdateServerMp`, `PlayerDataManager$$get_SkillBufferManager`, `0x165db84`, `0x165df00`, `0x165df00`
- always
  - returns `SkillBufferManager.RemoveSelfBuffer(PlayerDataManager.get_SkillBufferManager(this, ?x1, ?x2, ?x3), 657, 0, ?x3)`
  - calls `PlayerDataManager$$UpdateServerHP`, `PlayerDataManager$$UpdateServerMp`, `PlayerDataManager$$get_SkillBufferManager`, `PlayerDataManager$$get_SkillBufferManager`, `SkillBufferManager$$RemoveSelfBuffer`

</details>

<details><summary>Effect applied in `MobaPlayerActionManager$$SupportReserve` (70 guarded paths)</summary>

- when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
  - returns `UI3DLabelManager.SetSkillMissPopUp(Singleton<object>.get_Instance(meta(0x3974690, Method$Singleton<UI3DLabelManager>.get_Instance()), ?x1, ?x2, ?x3), GetAvailableSkill.out4(), 0, ?x3)`
  - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `Singleton<object>$$get_Instance`, `UI3DLabelManager$$SetSkillMissPopUp`
- when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
  - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `0x165df00`
- when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
  - returns `UI3DLabelManager.SetSkillMissPopUp(Singleton<object>.get_Instance(meta(0x3974690, Method$Singleton<UI3DLabelManager>.get_Instance()), ?x1, ?x2, ?x3), 3, 0, ?x3)`
  - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `PlayerStatusBase$$GetEquipSkill`, `SkillComboManager$$CheckCombo`, `SkillComboState$$TemporaryUseSkill`, `AbnormalStateManager$$Contains`
- when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
  - returns `GameManager.StartSupportSkill(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), target, (GetAvailableSkill.out4() eq 6 ? 0 : SkillManager.GetAvailableSkill(CharacterActionManagerBase.get_IsDeadOrLocalDead(), this, 0, ([TryGetBuf.out2()+0x50] eq 0 ? 657 : 654))), 0)`
  - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `PlayerStatusBase$$GetEquipSkill`, `SkillComboManager$$CheckCombo`, `SkillComboState$$TemporaryUseSkill`, `AbnormalStateManager$$Contains`
- when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
  - returns `MobaPlayerActionManager.SkillReserveMpLess(this, (GetAvailableSkill.out4() eq 6 ? 0 : SkillManager.GetAvailableSkill(CharacterActionManagerBase.get_IsDeadOrLocalDead(), this, 0, ([TryGetBuf.out2()+0x50] eq 0 ? 657 : 654))), stkp(-72), ?x3)`
  - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `PlayerStatusBase$$GetEquipSkill`, `SkillComboManager$$CheckCombo`, `SkillComboState$$TemporaryUseSkill`, `AbnormalStateManager$$Contains`
- when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
  - returns `BattleManagerBase.SupportReserve(battleManager, target, (GetAvailableSkill.out4() eq 6 ? 0 : SkillManager.GetAvailableSkill(CharacterActionManagerBase.get_IsDeadOrLocalDead(), this, 0, ([TryGetBuf.out2()+0x50] eq 0 ? 657 : 654))), (([TryGetBuf.out2()+0x50] eq 0 ? 657 : 654) ne 0 ? 1 : 0))`
  - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `PlayerStatusBase$$GetEquipSkill`, `SkillComboManager$$CheckCombo`, `SkillComboState$$TemporaryUseSkill`, `AbnormalStateManager$$Contains`
- when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
  - returns `BattleManagerBase.SupportReserve(battleManager, target, (GetAvailableSkill.out4() eq 6 ? 0 : SkillManager.GetAvailableSkill(CharacterActionManagerBase.get_IsDeadOrLocalDead(), this, 0, ([TryGetBuf.out2()+0x50] eq 0 ? 657 : 654))), (([TryGetBuf.out2()+0x50] eq 0 ? 657 : 654) ne 0 ? 1 : 0))`
  - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `PlayerStatusBase$$GetEquipSkill`, `SkillComboManager$$CheckCombo`, `SkillComboState$$TemporaryUseSkill`, `AbnormalStateManager$$Contains`
- when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
  - returns `UI3DLabelManager.SetSkillMissPopUp(Singleton<object>.get_Instance(meta(0x3974690, Method$Singleton<UI3DLabelManager>.get_Instance()), ?x1, ?x2, ?x3), 3, 0, ?x3)`
  - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `PlayerStatusBase$$GetEquipSkill`, `SkillComboManager$$CheckCombo`, `AbnormalStateManager$$Contains`, `Singleton<object>$$get_Instance`

</details>

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

- `ArkSaber$$CalcConstantDamage (TryGetBuf)`
- `ArkSaberAction$$ConverterArkSaberSkillId (GetSkillLv)`
- `MobAttackBase$$CalcLastDamage (TryGetBuf)`
- `MobaPlayerActionManager$$SupportReserve (GetSkillLv)`
- `MobaPlayerSecondaryStatus$$GetCrtConstant (TryGetBuf)`
- `PlayerAttackBase$$CalcCostMp (ContainsBuffer)`
- `PlayerAttackBase$$RemoveAfterSkillBuf (ContainsBuffer)`
- `PlayerDataManager$$OnSkillBuffEnd (TryGetBuf)`
- `PlayerSecondaryStatus$$GetCrtConstant (TryGetBuf)`
- `SaberAuraAction$$ActionHit (TryGetBuf)`
- `UIActiveBaseShortcutButton$$SkillButton (GetSkillLv)`
- `UIGLShortcutButton$$LabelUpdate (GetSkillLv)`
- `UIShortcutListButton$$OnSkillCostCheck (ContainsBuffer)`
- `UIShortcutListButton$$OnSkillCostCheck (GetSkillLv)`
- `UIShortcutListButton$$SetSkillButton (GetSkillLv)`

---

### แอร์สไลเซอร์ (AirSlicer) · uid 658

<img src="../../icons/sk_658.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 5) · **Type:** Attack · **Max Lv:** 250 · **Weapons:** TwinSword · **Requires:** สปินนิ่งสแลช · **Client class:** `AirSlicerAction`

> เทคนิคปลดปล่อยคมดาบแห่งสายลม
> ธาตุคู่(ดาบมือเดียว)ถ้ากำลังเปิดใช้สปินนิ่งสแลชที่เท้า
> เมื่อกดปุ่มเคลื่อนที่ไปข้างหน้าจะใช้อีก 200MP เพื่อเพิ่มการโจมอันทรงพลัง

<details><summary>In-game level notes</summary>

- Lv10: *พลังของแอร์สไลเซอร์ขึ้นอยู่กับเลเวลของสปินนิ่งสแลชที่มี  *การโจมตีเพิ่มเติมจะถูกเสริมด้วยความเสียหายคริติคอลของทวินสแลชที่เรียนรู้ และจะเพิ่มขึ้นอีกเมื่อเป้าหมายอยู่ในสภาวะมืดบอด แต่ยิ่งห่าง (ตั้งแต่ 8 เมตรขึ้นไป) ค่าที่ได้ก็จะยิ่งน้อยลง

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 20 | 40 | 60 | 80 | 100 | 120 | 140 | 160 | 180 | 200 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((((((gemCart(210[4]) + ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) << 1) + 30)) + ((gemCart(210[4]) + ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) << 1) + 30)) << 1)) + (gemCart(210[4]) + (int((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) * 2.5)) + 125))) + ((baseDEX // 10) * Lv))) / 100)` — CalcFirstDamage
- SkillRate × `((max((((baseSTR) * (((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 2) lt 100 ? (100 - ((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 2)) : 0)) / 100), 0) + (((Lv * 100) + 500))) / 100)` — CalcSecondDamage
- SkillRate × `((max((((baseSTR) * (((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 2) lt 100 ? (100 - ((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 2)) : 0)) / 100), 0) + (((Lv * 100) + 500))) / 100)` — CalcSecondDamage
- Flat dmg + `(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) << 2)) + 50))` — CalcFirstDamage
- Crit mult + `(max((((((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) << 2)) + 50) lt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) << 2)) + 51) : ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) << 2)) + 50)) >> 1)) << (AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 7) & 1)) - (((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 1) lt 50 ? ((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 1) : 50)), 0) / 100)` — CalcSecondDamage

**Role:** attack (deals damage) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **slot chosen at runtime (physical or magic by a per-cast flag)**; Proration changes on EVERY damaging hit (bypasses the first-hit gate).

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) << 2)) + 50))` | `(((Lv + (Lv << 2)) << 2))`
- `CriticalRate` multiplies by (adds into): `(max((((((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) << 2)) + 50) lt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) << 2)) + 51) : ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) << 2)) + 50)) >> 1)) << (AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 7) & 1)) - (((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 1) lt 50 ? ((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 1) : 50)), 0) / 100)`
- `SkillRate` multiplies by (adds into): `((((((gemCart(210[4]) + ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) << 1) + 30)) + ((gemCart(210[4]) + ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) << 1) + 30)) << 1)) + (gemCart(210[4]) + (int((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) * 2.5)) + 125))) + ((baseDEX // 10) * Lv))) / 100)` | `((max((((baseSTR) * (((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 2) lt 100 ? (100 - ((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 2)) : 0)) / 100), 0) + (((Lv * 100) + 500))) / 100)`

**Mechanics recovered from code**

- **First-part skill multiplier (%)** (`firstSkillRate`): `((((gemCart(210[4]) + ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) << 1) + 30)) + ((gemCart(210[4]) + ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) << 1) + 30)) << 1)) + (gemCart(210[4]) + (int((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) * 2.5)) + 125))) + ((baseDEX // 10) * Lv))`
- **Effect percent** (`percent`): `(int((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) * 2.5)) + 15)`
- **First-part flat damage** (`firstFixAddDamage`): `((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) << 2)) + 50)`
- **Second-part multiplier** (`secondSkillRate`): `((Lv * 100) + 500)` → Lv1..10 [600, 700, 800, 900, 1000, 1100, 1200, 1300, 1400, 1500]
- **Second-part flat damage** (`secondFixAddDamage`): `((Lv + (Lv << 2)) << 2)` → Lv1..10 [20, 40, 60, 80, 100, 120, 140, 160, 180, 200]

**Proration:** slot `dynamic`, mode `every_hit + class check`, attack type `Physics`, action id 658

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`
- set `Element` = `3` = 3
- set `firstSkillRate` = `((((gemCart(210[4]) + ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) << 1) + 30)) + ((gemCart(210[4]) + ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) << 1) + 30)) << 1)) + (gemCart(210[4]) + (int((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) * 2.5)) + 125))) + ((baseDEX // 10) * Lv))`
- set `percent` = `(int((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) * 2.5)) + 15)`
- set `firstFixAddDamage` = `((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) << 2)) + 50)`
- set `secondSkillRate` = `((Lv * 100) + 500)` → Lv1..10: [600, 700, 800, 900, 1000, 1100, 1200, 1300, 1400, 1500]
- set `secondSkillRateBonus` = `baseSTR`
- set `secondFixAddDamage` = `((Lv + (Lv << 2)) << 2)` → Lv1..10: [20, 40, 60, 80, 100, 120, 140, 160, 180, 200]
- set `criticalDamageUp` = `((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) << 2)) + 50) lt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) << 2)) + 51) : ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) << 2)) + 50)) >> 1)`

**`ActionPreparation`** (1 path)

- set `target` = `target`

**`calcPlayerToMobDamage`** (26 paths)

- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(7, percent, playerAction)`
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(7, 0)` — when PlayerAttackBase.checkAbnormalPercent(this, 7, percent, playerAction)
- calls `SkillDamageData.CreateNextDamage` = `CreateNextDamage()` — when MaxFirstAttackCount lt 2 OR 2 ge MaxFirstAttackCount AND MaxFirstAttackCount ge 2 OR 2 ge MaxFirstAttackCount AND 2 lt MaxFirstAttackCount AND MaxFirstAttackCount ge 2

**`CalcFirstDamage`** (1 path)

- template `AddRate[SkillRate]` = `(firstSkillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `firstFixAddDamage`
- info `templates` = `1`

**`CalcSecondDamage`** (1 path)

- set `secondSkillRateBonus` = `max(((secondSkillRateBonus * (((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 2) lt 100 ? (100 - ((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 2)) : 0)) / 100), 0)`
- template `AddRate[SkillRate]` = `((max(((secondSkillRateBonus * (((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 2) lt 100 ? (100 - ((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 2)) : 0)) / 100), 0) + secondSkillRate) / 100)`
- template `AddConstant[SkillConstantDamage]` = `secondFixAddDamage`
- template `AddRate[CriticalRate]` = `(max(((criticalDamageUp << (AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 7) & 1)) - (((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 1) lt 50 ? ((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 1) : 50)), 0) / 100)`
- info `templates` = `1`

**`ActionSkillEvent`** (2 paths)

- set `exp` = `1` = 1 — when param eq 101

**`ExpDefFluctuated`** (1 path)

- set `exp` = `0` = 0

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`

**`OtherPlayerSkillEventReceive`** (2 paths)

- set `otherChange` = `1` = 1 — when (skillEventId & 0xffff) eq 101

</details>

---

### ฮอร์ริซอนคัท (HorizontalCut) · uid 660

<img src="../../icons/sk_660.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 5) · **Type:** Attack · **Max Lv:** 250 · **Weapons:** OneHandSword, TwinSword · **Requires:** เอเลียสลีย์ · **Client class:** `HorizontalCutAction`

> ฟันกลับอย่างรวดเร็วแบบไม่ให้ศัตรูได้ตั้งตัว
> ลด MP ที่ใช้ของสกิลถัดไปลงครึ่งหนึ่ง
> ถ้าใช้เป็นสกิลเริ่มต้นของคอมโบต้องใช้ 300 MP
> ถ้าใช้งานที่จุดสิ้นสุดของคอมโบ MP ที่จำเป็นจะกลายเป็น 0
> ระหว่างใช้สกิลหากถูกโจมตีจะล้มคว่ำ

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + [calcFirstDamage !UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR !SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0) eq 0 AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword] | 30 | 60 | 90 | 120 | 150 | 180 | 210 | 240 | 270 | 300 |
| Flat dmg + [calcFirstDamage isDualSword ne 0 AND subWeapon != OneHandSword OR isDualSword eq 0 AND subWeapon != OneHandSword] | 60 | 120 | 180 | 240 | 300 | 360 | 420 | 480 | 540 | 600 |
| Flat dmg + [calcSecondDamage] | 30 | 60 | 90 | 120 | 150 | 180 | 210 | 240 | 270 | 300 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((((((Lv * 10) + status.Dex) + 900) lt 0 ? ((((Lv * 10) + status.Dex) + 900) + 1) : (((Lv * 10) + status.Dex) + 900)) >> 1)) / 100)` — calcFirstDamage !UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR !SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0) eq 0 AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword
- SkillRate × `(((((((Lv * 10) + status.Dex) + 900) lt 0 ? ((((Lv * 10) + status.Dex) + 900) + 1) : (((Lv * 10) + status.Dex) + 900)) >> 1)) / 100)` — calcFirstDamage isDualSword ne 0 AND subWeapon != OneHandSword OR isDualSword eq 0 AND subWeapon != OneHandSword
- SkillRate × `((((Lv * 50) + (((baseSTR gt baseAGI ? baseSTR : baseAGI) lt 0 ? ((baseSTR gt baseAGI ? baseSTR : baseAGI) + 1) : (baseSTR gt baseAGI ? baseSTR : baseAGI)) >> 1))) / 100)` — calcSecondDamage

**Role:** attack (deals damage) · buff (self)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; never (IsExpDefFluctuate=false)

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv * 60) >> 1))` | `((Lv * 30))`
- `SkillRate` multiplies by (adds into): `(((((((Lv * 10) + status.Dex) + 900) lt 0 ? ((((Lv * 10) + status.Dex) + 900) + 1) : (((Lv * 10) + status.Dex) + 900)) >> 1)) / 100)` | `((((Lv * 50) + (((baseSTR gt baseAGI ? baseSTR : baseAGI) lt 0 ? ((baseSTR gt baseAGI ? baseSTR : baseAGI) + 1) : (baseSTR gt baseAGI ? baseSTR : baseAGI)) >> 1))) / 100)`

**Mechanics recovered from code**

- **Second-part multiplier** (`secondSkillRate`): `((Lv * 50) + (((baseSTR gt baseAGI ? baseSTR : baseAGI) lt 0 ? ((baseSTR gt baseAGI ? baseSTR : baseAGI) + 1) : (baseSTR gt baseAGI ? baseSTR : baseAGI)) >> 1))` _(when !UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR !SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0) eq 0 AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword)_
- **Base MP cost** (`baseMp`): `(combo.index eq (SkillComboLine.get_Count(combo.comboLine) - 1) ? 0 : 300)` _(when combo.index eq (SkillComboLine.get_Count(combo.comboLine) - 1) OR combo.index eq 0 AND combo.index ne (SkillComboLine.get_Count(combo.comboLine) - 1))_

**Proration:** slot `Skill`, mode `never (IsExpDefFluctuate=false)`, attack type `Physics`, action id 660

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (7 paths)

- set `baseActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(14)` — when SkillActionBase.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), UnityEngine.Component.get_transform(actarAction), 0.1) AND SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0) ne 0 AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword
- set `skillRate` = `(((((Lv * 10) + status.Dex) + 900) lt 0 ? ((((Lv * 10) + status.Dex) + 900) + 1) : (((Lv * 10) + status.Dex) + 900)) >> 1)` — when !UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR !SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0) eq 0 AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword
- set `fixAddDamage` = `((Lv * 60) >> 1)` → Lv1..10: [30, 60, 90, 120, 150, 180, 210, 240, 270, 300] — when !UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR !SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0) eq 0 AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword
- set `isDualSword` = `1` = 1 — when !UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR !SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0) eq 0 AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword
- set `secondSkillRate` = `((Lv * 50) + (((baseSTR gt baseAGI ? baseSTR : baseAGI) lt 0 ? ((baseSTR gt baseAGI ? baseSTR : baseAGI) + 1) : (baseSTR gt baseAGI ? baseSTR : baseAGI)) >> 1))` — when !UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR !SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0) eq 0 AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword
- set `secondFixDamage` = `(Lv * 30)` → Lv1..10: [30, 60, 90, 120, 150, 180, 210, 240, 270, 300] — when !UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR !SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0) eq 0 AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword
- set `SkillIndividualFlag` = `(SkillIndividualFlag | 1)` — when SkillActionBase.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), UnityEngine.Component.get_transform(actarAction), 0.1) AND SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0) ne 0 AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword
- set `isLongRangeAttack` = `1` = 1 — when SkillActionBase.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), UnityEngine.Component.get_transform(actarAction), 0.1) AND SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0) ne 0 AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword
- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))` — when !UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR isDualSword ne 0 AND subWeapon != OneHandSword OR isDualSword eq 0 AND subWeapon != OneHandSword
- set `skillRate` = `(((Lv * 10) + status.Dex) + 900)` — when isDualSword ne 0 AND subWeapon != OneHandSword OR isDualSword eq 0 AND subWeapon != OneHandSword
- set `fixAddDamage` = `(Lv * 60)` → Lv1..10: [60, 120, 180, 240, 300, 360, 420, 480, 540, 600] — when isDualSword ne 0 AND subWeapon != OneHandSword OR isDualSword eq 0 AND subWeapon != OneHandSword

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`
- set `isDualSword` = `(IOtherPlayerActionManager.get_SubWeapon(actarAction) eq 10 ? 1 : 0)`

**`ChangeMpDuringCombo`** (3 paths)

- set `baseMp` = `(combo.index eq (SkillComboLine.get_Count(combo.comboLine) - 1) ? 0 : 300)` — when combo.index eq (SkillComboLine.get_Count(combo.comboLine) - 1) OR combo.index eq 0 AND combo.index ne (SkillComboLine.get_Count(combo.comboLine) - 1)

**`ActionStart`** (3 paths)

- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(660, Lv, Id)` — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction)

**`calcPlayerToMobDamage`** (12 paths)

- set `ActionRange` = `ActionRange`

**`calcFirstDamage`** (1 path)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- info `templates` = `1`

**`calcSecondDamage`** (1 path)

- template `AddRate[SkillRate]` = `(secondSkillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `secondFixDamage`
- info `templates` = `1`

**`Damaged`** (66 paths)

- calls `AbnormalStateManager.GetDefaultAnbormalStateTime` = `GetDefaultAnbormalStateTime()` — when !CharacterActionManagerBase.AddAbnormalState(actor, 2, AbnormalStateManager.GetDefaultAnbormalStateTime(2), 0, 0, 0, 1) AND !SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) AND !SkillActionBase.op_Inequality(action) AND (damageData.AbnormalType - 1) hs 4 AND SkillActionBase.get_ActionID() eq 660 AND damageData.AbnormalType ne 43 OR !CharacterActionManagerBase.AddAbnormalState(actor, 2, AbnormalStateManager.GetDefaultAnbormalStateTime(2), 0, 0, 0, 1) AND !SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) AND (damageData.AbnormalType - 1) hs 4 AND IsInstanceOf(action, MobEventScriptAttack) ne 1 AND SkillActionBase.get_ActionID() eq 660 AND SkillActionBase.op_Inequality(action) AND damageData.AbnormalType ne 43 OR !CharacterActionManagerBase.AddAbnormalState(actor, 2, AbnormalStateManager.GetDefaultAnbormalStateTime(2), 0, 0, 0, 1) AND !SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) AND (damageData.AbnormalType - 1) hs 4 AND IsInstanceOf(action, MobEventScriptAttack) eq 1 AND SkillActionBase.get_ActionID() eq 660 AND SkillActionBase.op_Inequality(action) AND damageData.AbnormalType ne 43
- calls `MathUtil.CheckPercent` = `CheckPercent()` — when !SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) AND !SkillActionBase.op_Inequality(action) AND (!MathUtil.CheckPercent(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) << 2)) << 1)) | hasBuff(CrtDamageUp)) AND (damageData.AbnormalType - 1) hs 4 AND CharacterActionManagerBase.AddAbnormalState(actor, 2, AbnormalStateManager.GetDefaultAnbormalStateTime(2), 0, 0, 0, 1) AND SkillActionBase.get_ActionID() eq 660 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) ge 1 AND damageData.AbnormalType ne 43 AND hasGemCart(401) OR !SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) AND !SkillActionBase.op_Inequality(action) AND (MathUtil.CheckPercent(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) << 2)) << 1)) | hasBuff(CrtDamageUp)) AND (damageData.AbnormalType - 1) hs 4 AND CharacterActionManagerBase.AddAbnormalState(actor, 2, AbnormalStateManager.GetDefaultAnbormalStateTime(2), 0, 0, 0, 1) AND SkillActionBase.get_ActionID() eq 660 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) ge 1 AND damageData.AbnormalType ne 43 AND hasGemCart(401) OR !SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) AND (!MathUtil.CheckPercent(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) << 2)) << 1)) | hasBuff(CrtDamageUp)) AND (damageData.AbnormalType - 1) hs 4 AND CharacterActionManagerBase.AddAbnormalState(actor, 2, AbnormalStateManager.GetDefaultAnbormalStateTime(2), 0, 0, 0, 1) AND IsInstanceOf(action, MobEventScriptAttack) ne 1 AND SkillActionBase.get_ActionID() eq 660 AND SkillActionBase.op_Inequality(action) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) ge 1 AND damageData.AbnormalType ne 43 AND hasGemCart(401)
- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(41)` — when !SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) AND !SkillActionBase.op_Inequality(action) AND !hasGemCart(401) AND ((0 | hasBuff(CrtDamageUp)) & 1) eq 0 AND (damageData.AbnormalType - 1) hs 4 AND CharacterActionManagerBase.AddAbnormalState(actor, 2, AbnormalStateManager.GetDefaultAnbormalStateTime(2), 0, 0, 0, 1) AND SkillActionBase.get_ActionID() eq 660 AND damageData.AbnormalType ne 43 OR !SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) AND !hasGemCart(401) AND ((0 | hasBuff(CrtDamageUp)) & 1) eq 0 AND (damageData.AbnormalType - 1) hs 4 AND CharacterActionManagerBase.AddAbnormalState(actor, 2, AbnormalStateManager.GetDefaultAnbormalStateTime(2), 0, 0, 0, 1) AND IsInstanceOf(action, MobEventScriptAttack) ne 1 AND SkillActionBase.get_ActionID() eq 660 AND SkillActionBase.op_Inequality(action) AND damageData.AbnormalType ne 43 OR !SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) AND !hasGemCart(401) AND ((0 | hasBuff(CrtDamageUp)) & 1) eq 0 AND (damageData.AbnormalType - 1) hs 4 AND CharacterActionManagerBase.AddAbnormalState(actor, 2, AbnormalStateManager.GetDefaultAnbormalStateTime(2), 0, 0, 0, 1) AND IsInstanceOf(action, MobEventScriptAttack) eq 1 AND SkillActionBase.get_ActionID() eq 660 AND SkillActionBase.op_Inequality(action) AND damageData.AbnormalType ne 43

</details>

**Buffs**

**Buff `HorizontalCutBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).

<details><summary>Effect applied in `PlayerAttackBase$$RemoveAfterSkillBuf` (295 guarded paths, truncated)</summary>

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

- `PlayerAttackBase$$RemoveAfterSkillBuf (ContainsBuffer)`

---

### เบลดสตริงเกอร์ (BladeStinger) · uid 661

<img src="../../icons/sk_661.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 5) · **Type:** Attack · **Max Lv:** 250 · **Weapons:** OneHandSword, TwinSword · **Requires:** เอเลียสลีย์ · **Client class:** `BladeStingerAction`

> พุ่งตรงเข้าไปแทงอย่างรวดเร็ว
> ถ้าไม่ Graze จะทำให้พลังเจาะเข้าพิ่มขึ้น
> พลังโจมตีเพิ่มขึ้นอีกตามพลังเจาะเข้าที่เกินค่าสูงสุด

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [subWeapon == OneHandSword & !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10] | 3.4 | 3.8 | 4.2 | 4.6 | 5 | 5.4 | 5.8 | 6.2 | 6.6 | 7 |
| SkillRate × [subWeapon == OneHandSword & SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10] | 3.4 | 3.8 | 4.2 | 4.6 | 5 | 5.4 | 5.8 | 6.2 | 6.6 | 7 |
| Flat dmg + | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((0) + (((Lv * 40) + 300))) / 100)` — subWeapon == OneHandSword & ((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + physicsResistBreaker) ge 101 AND UnityEngine.Object.op_Inequality(actarAction) & !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10
- SkillRate × `(((0) + (((Lv * 40) + 300))) / 100)` — subWeapon != OneHandSword & !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10
- SkillRate × `(((0) + (((Lv * 40) + 300))) / 100)` — subWeapon != OneHandSword & ((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + physicsResistBreaker) ge 101 AND UnityEngine.Object.op_Inequality(actarAction) & !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10
- SkillRate × `(((0) + ((status.Agi + 300))) / 100)` — !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10
- SkillRate × `(((0) + ((status.Agi + 300))) / 100)` — ((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + physicsResistBreaker) ge 101 AND UnityEngine.Object.op_Inequality(actarAction) & !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10
- SkillRate × `((((Lv * 40) + 300)) / 100)` — subWeapon != OneHandSword & SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10
- SkillRate × `(((status.Agi + 300)) / 100)` — SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10

**Role:** attack (deals damage)

The skill builds 2 separate damage templates (each is a full hit with its own crit roll). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(100)`
- `Def` sets: `-PlayerAttackBase.CalcRegistDamage(this, 1, PlayerActionManagerBase.get_PlayerStatus(), MobActionManagerBase.get_MobBattleStatus(mobAction))`
- `SkillRate` multiplies by (adds into): `(((0) + (((Lv * 40) + 300))) / 100)` | `(((0) + ((status.Agi + 300))) / 100)` | `((((Lv * 40) + 300)) / 100)`

**Mechanics recovered from code**

- **Physical pierce %** (`physicsResistBreaker`): `((Lv << 2) + 10)` → Lv1..10 [14, 18, 22, 26, 30, 34, 38, 42, 46, 50]

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 661

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (2 paths)

- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(24)`
- set `fixAddDamage` = `100` = 100
- set `skillRateBase` = `((Lv * 40) + 300)` → Lv1..10: [340, 380, 420, 460, 500, 540, 580, 620, 660, 700] — when subWeapon == OneHandSword
- set `physicsResistBreaker` = `((Lv << 2) + 10)` → Lv1..10: [14, 18, 22, 26, 30, 34, 38, 42, 46, 50]
- set `secondSkillRateBase` = `(status.Agi + 300)` — when subWeapon == OneHandSword
- set `addSkillRate` = `0` = 0
- set `skillRateBase` = `(status.Dex + ((Lv * 40) + 300))` — when subWeapon != OneHandSword

**`InitializeOthers`** (2 paths)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`ActionPreparation`** (3 paths)

- set `addSkillRate` = `(((((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + physicsResistBreaker) * 10) - 1000) lt 500 ? ((((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + physicsResistBreaker) * 10) - 1000) : 500)` — when ((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + physicsResistBreaker) ge 101 AND UnityEngine.Object.op_Inequality(actarAction)

**`ActionSkillEvent`** (3 paths)

- set `isAvoidPossible` = `1` = 1 — when IsOtherPlayer eq 0 AND param eq 100

**`calcPlayerToMobDamage`** (24 paths)

- template `SetConstant[Def]` = `-PlayerAttackBase.CalcRegistDamage(this, 1, PlayerActionManagerBase.get_PlayerStatus(), MobActionManagerBase.get_MobBattleStatus(mobAction))` — when !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10
- template `AddRate[SkillRate]` = `((addSkillRate + skillRateBase) / 100)` — when !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage` — when !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10 OR SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10
- template `AddRate[SkillRate]` = `((addSkillRate + secondSkillRateBase) / 100)` — when !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10
- info `templates` = `2` — when !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10
- info `templates` = `1` — when !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10 OR SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10
- template `AddRate[SkillRate]` = `(skillRateBase / 100)` — when SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10
- template `AddRate[SkillRate]` = `(secondSkillRateBase / 100)` — when SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10

</details>

---
