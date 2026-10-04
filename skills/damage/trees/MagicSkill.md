# マジックスキル (`MagicSkill`)

24 entries. See ../README.md for how to read these blocks.

### เวทมนตร์:แอร์โรว์ / ธนูไฟ / ธนูน้ำ / ธนูลม / ธนูดิน / ธนูแสง / ธนูมืด (MagicArrow) · uid 97

<img src="../../icons/sk_097.png" width="40" alt="icon"> 
**Tree:** マジックスキル (`MagicSkill`, tier 1) · **Type:** Object · **Max Lv:** 10 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `MagicArrowAction`

> ยิงด้วยธนูเวทขนาดเล็ก
> จำนวนที่ยิงออกไปจะเพิ่มขึ้นตามเลเวล

<details><summary>In-game level notes</summary>

- Lv14: *พลัง+25
- Lv15: *เพิ่มจำนวนครั้งการโจมตี

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [(isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0] | 0.71 | 0.77 | 0.83 | 0.89 | 0.95 | 1.01 | 1.07 | 1.13 | 1.19 | 1.25 |
| SkillRate × [(mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0] | 0.96 | 1.02 | 1.08 | 1.14 | 1.2 | 1.26 | 1.32 | 1.38 | 1.44 | 1.5 |
| Flat dmg + | 95 | 100 | 105 | 110 | 115 | 120 | 125 | 130 | 135 | 140 |

**Role:** attack (deals damage) · buff (self) · placed object / trap / summon

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv + (Lv << 2)) + 90))`
- `SkillRate` multiplies by (adds into): `((((Lv * 6) + 65)) / 100)`

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())` _(when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0)_; `0` = 0 _(when PlayerAttackBase.CheckSkillParamFlag(this, 0x2000))_; `-1` = -1 _(when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0)_
- **Number of damage events** (`damageCount`): `(gemCart(105[2]) + (((((Lv - 1) + (((Lv - 1) & 0x8000) >> 15)) >> 1) + 2) + 2))` _(when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0)_; `(gemCart(105[2]) + ((((Lv - 1) + (((Lv - 1) & 0x8000) >> 15)) >> 1) + 2))` _(when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0)_; `motionSpeed`
- **Loop / hit-repeat count** (`LoopParam`): `(gemCart(105[2]) + (((((Lv - 1) + (((Lv - 1) & 0x8000) >> 15)) >> 1) + 2) + 2))` _(when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0)_; `(gemCart(105[2]) + ((((Lv - 1) + (((Lv - 1) & 0x8000) >> 15)) >> 1) + 2))` _(when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0)_; `((gemCart(105[2]) + ((((Lv - 1) + (((Lv - 1) & 0x8000) >> 15)) >> 1) + 2)) + 2)` _(when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0)_

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 97

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (7 paths)

- set `spellTuningArrow` = `ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 97)` — when (mainWeapon==Rod & 1) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())` — when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)` — when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0
- set `skillRate` = `((Lv * 6) + 65)` → Lv1..10: [71, 77, 83, 89, 95, 101, 107, 113, 119, 125] — when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `fixAddDamage` = `((Lv + (Lv << 2)) + 90)` → Lv1..10: [95, 100, 105, 110, 115, 120, 125, 130, 135, 140] — when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())` — when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0
- set `damageCount` = `(gemCart(105[2]) + (((((Lv - 1) + (((Lv - 1) & 0x8000) >> 15)) >> 1) + 2) + 2))` — when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `LoopParam` = `(gemCart(105[2]) + (((((Lv - 1) + (((Lv - 1) & 0x8000) >> 15)) >> 1) + 2) + 2))` — when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `damageCount` = `(gemCart(105[2]) + ((((Lv - 1) + (((Lv - 1) & 0x8000) >> 15)) >> 1) + 2))` — when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0
- set `LoopParam` = `(gemCart(105[2]) + ((((Lv - 1) + (((Lv - 1) & 0x8000) >> 15)) >> 1) + 2))` — when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0
- set `skillRate` = `(((Lv * 6) + 65) + 25)` → Lv1..10: [96, 102, 108, 114, 120, 126, 132, 138, 144, 150] — when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0

**`InitializeOthers`** (3 paths)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1
- set `damageCount` = `motionSpeed`

**`OtherPlayerAttackStartReceive`** (2 paths)

- set `CastTime` = `0` = 0 — when PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)

**`ActionPreparation`** (10 paths)

- set `Element` = `TryGetElemntType.elementType(PlayerActionManagerBase.get_PlayerStatus())` — when !PlayerAttackBase.CheckSkillParamFlag(this, 1024) AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.CheckSkillParamFlag(this, 1024) AND UnityEngine.Object.op_Inequality(actarAction)

**`calcPlayerToMobDamage`** (196 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- info `templates` = `1`

**`ActionSkillEvent`** (8 paths)

- set `firstHit` = `0` = 0 — when IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND firstHit ne 0 AND param eq 0 AND param ne 100 OR IsInstanceOf(actarAction, MobaPlayerActionManager) eq 1 AND IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND firstHit ne 0 AND param eq 0 AND param ne 100 OR IsInstanceOf(actarAction, MobaPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND firstHit ne 0 AND param eq 0 AND param ne 100
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(104, PlayerStatusBase.get_SkillManager().SkillMasteryList[104].skillData.Level, Id)` — when IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND firstHit ne 0 AND param eq 0 AND param ne 100 OR IsInstanceOf(actarAction, MobaPlayerActionManager) eq 1 AND IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND firstHit ne 0 AND param eq 0 AND param ne 100

**`InitializeEnchantedSpell`** (5 paths)

- set `spellTuningArrow` = `0` = 0
- set `LoopParam` = `((gemCart(105[2]) + ((((Lv - 1) + (((Lv - 1) & 0x8000) >> 15)) >> 1) + 2)) + 2)` — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `Element` = `PlayerStatusBase.GetEquipSubWeaponElement(PlayerActionManagerBase.get_PlayerStatus())` — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `CastTime` = `-1` = -1 — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `SkillParam` = `(SkillParam | 1024)` — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `fixAddDamage` = `((Lv + (Lv << 2)) + 90)` → Lv1..10: [95, 100, 105, 110, 115, 120, 125, 130, 135, 140] — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `skillRate` = `((Lv * 6) + 65)` → Lv1..10: [71, 77, 83, 89, 95, 101, 107, 113, 119, 125] — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `damageCount` = `((gemCart(105[2]) + ((((Lv - 1) + (((Lv - 1) & 0x8000) >> 15)) >> 1) + 2)) + 2)` — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `LoopParam` = `(gemCart(105[2]) + ((((Lv - 1) + (((Lv - 1) & 0x8000) >> 15)) >> 1) + 2))` — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0
- set `damageCount` = `(gemCart(105[2]) + ((((Lv - 1) + (((Lv - 1) & 0x8000) >> 15)) >> 1) + 2))` — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0

**`UseChronosShift`** (1 path)

- set `SkillParam` = `(SkillParam | 0x2000)`
- set `lastUsedSkill` = `lastUsedSkill`

</details>

---

### เวทมนตร์:แจฟลิน / หอกเพลิง / หอกน้ำแข็ง / หอกวายุ / หอกศิลา / หอกศักดิ์สิทธิ์ / หอกอนธการ (MagicJabelin) · uid 98

<img src="../../icons/sk_098.png" width="40" alt="icon"> 
**Tree:** マジックスキル (`MagicSkill`, tier 1) · **Type:** Attack · **Max Lv:** 10 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** [N]เวทมนตร์:แอร์โรว์[F]ธนูไฟ[A]ธนูน้ำ[W]ธนูลม[E]ธนูดิน[L]ธนูแสง[D]ธนูมืด[N] · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `MagicJabelinAction`

> ปล่อยหอกเวทขนาดใหญ่
> มีโอกาสทำให้เป้าหมายติดสภาวะผิดปกติ
> สภาวะนั้นจะเปลี่ยนไปตามธาตุ

<details><summary>In-game level notes</summary>

- Lv14: *พลัง+50
- Lv15: *อัตราติดสภาวะผิดปกติ+25%

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [(isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0] | 1.6 | 1.7 | 1.8 | 1.9 | 2 | 2.1 | 2.2 | 2.3 | 2.4 | 2.5 |
| SkillRate × [(mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0] | 2.1 | 2.2 | 2.3 | 2.4 | 2.5 | 2.6 | 2.7 | 2.8 | 2.9 | 3 |
| Flat dmg + | 65 | 80 | 95 | 110 | 125 | 140 | 155 | 170 | 185 | 200 |

**Role:** attack (deals damage) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **slot chosen at runtime (physical or magic by a per-cast flag)**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `((((Lv << 4) - Lv) + 50))`
- `SkillRate` multiplies by (adds into): `((((Lv * 10) + 150)) / 100)`

**Mechanics recovered from code**

- **Ailment chance (%)** (`abnormalRate`): `(int((Lv * 7.5)) + 25)` → Lv1..10 [32, 40, 47, 55, 62, 70, 77, 85, 92, 100] _(when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0)_; `int((Lv * 7.5))` → Lv1..10 [7, 15, 22, 30, 37, 45, 52, 60, 67, 75] _(when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0)_; `(int((Lv * 7.5)) + 25)` → Lv1..10 [32, 40, 47, 55, 62, 70, 77, 85, 92, 100] _(when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0)_
- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())` _(when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0)_; `0` = 0 _(when PlayerAttackBase.CheckSkillParamFlag(this, 0x2000))_; `-1` = -1 _(when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0)_

**Proration:** slot `dynamic`, mode `first_hit_per_target`, attack type `Magic`, action id 98

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (7 paths)

- set `spellTuningJabelin` = `ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 98)` — when (mainWeapon==Rod & 1) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())` — when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(8)` — when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0
- set `skillRate` = `((Lv * 10) + 150)` → Lv1..10: [160, 170, 180, 190, 200, 210, 220, 230, 240, 250] — when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `fixAddDamage` = `(((Lv << 4) - Lv) + 50)` → Lv1..10: [65, 80, 95, 110, 125, 140, 155, 170, 185, 200] — when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0
- set `abnormalRate` = `(int((Lv * 7.5)) + 25)` → Lv1..10: [32, 40, 47, 55, 62, 70, 77, 85, 92, 100] — when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())` — when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0
- set `abnormalRate` = `int((Lv * 7.5))` → Lv1..10: [7, 15, 22, 30, 37, 45, 52, 60, 67, 75] — when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0
- set `skillRate` = `(((Lv * 10) + 150) + 50)` → Lv1..10: [210, 220, 230, 240, 250, 260, 270, 280, 290, 300] — when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0

**`InitializeOthers`** (3 paths)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`OtherPlayerAttackStartReceive`** (2 paths)

- set `CastTime` = `0` = 0 — when PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)

**`ActionPreparation`** (7 paths)

- set `Element` = `TryGetElemntType.elementType(PlayerActionManagerBase.get_PlayerStatus())` — when !PlayerAttackBase.CheckSkillParamFlag(this, 1024) AND UnityEngine.Object.op_Inequality(actarAction)

**`calcPlayerToMobDamage`** (54 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- info `templates` = `1`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(1, abnormalRate, playerAction)` — when +0x139 ne 0 AND GemCartBufferManager.GetTalentElementType(PlayerStatusBase.get_GemCartBuffManager()) hi 8 AND PlayerAttackBase.checkAbnormalPercent(this, 1, abnormalRate, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 1, abnormalRate, playerAction) AND +0x139 ne 0 AND GemCartBufferManager.GetTalentElementType(PlayerStatusBase.get_GemCartBuffManager()) hi 8 OR +0x139 eq 0 AND GemCartBufferManager.GetTalentElementType(PlayerStatusBase.get_GemCartBuffManager()) hi 8 AND PlayerAttackBase.checkAbnormalPercent(this, 1, abnormalRate, playerAction)
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(1, 0)` — when +0x139 ne 0 AND GemCartBufferManager.GetTalentElementType(PlayerStatusBase.get_GemCartBuffManager()) hi 8 AND PlayerAttackBase.checkAbnormalPercent(this, 1, abnormalRate, playerAction) OR +0x139 eq 0 AND GemCartBufferManager.GetTalentElementType(PlayerStatusBase.get_GemCartBuffManager()) hi 8 AND PlayerAttackBase.checkAbnormalPercent(this, 1, abnormalRate, playerAction)

**`OtherPlayerSkillEventReceive`** (2 paths)

- set `state` = `skillEventId` — when state lt skillEventId

**`OnFailedAddAbnormalState`** (3 paths)

- set `state` = `(state + 1)` — when +0x139 ne 0 AND state le 0

**`InitializeEnchantedSpell`** (5 paths)

- set `spellTuningJabelin` = `0` = 0
- set `Element` = `PlayerStatusBase.GetEquipSubWeaponElement(PlayerActionManagerBase.get_PlayerStatus())` — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `CastTime` = `-1` = -1 — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `SkillParam` = `(SkillParam | 1024)` — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `fixAddDamage` = `(((Lv << 4) - Lv) + 50)` → Lv1..10: [65, 80, 95, 110, 125, 140, 155, 170, 185, 200] — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `skillRate` = `((Lv * 10) + 150)` → Lv1..10: [160, 170, 180, 190, 200, 210, 220, 230, 240, 250] — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `abnormalRate` = `(int((Lv * 7.5)) + 25)` → Lv1..10: [32, 40, 47, 55, 62, 70, 77, 85, 92, 100] — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `abnormalRate` = `int((Lv * 7.5))` → Lv1..10: [7, 15, 22, 30, 37, 45, 52, 60, 67, 75] — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0

**`UseChronosShift`** (1 path)

- set `SkillParam` = `(SkillParam | 0x2000)`
- set `lastUsedSkill` = `lastUsedSkill`

</details>

---

### เวทมนตร์:กำแพง / กำแพงอัคคี / ม่านวารี / กำแพงวายุ / เขตแดนปฐพี / เขตแดนศักดิ์สิทธิ์ / ประตูอสูร (MagicWall) · uid 99

<img src="../../icons/sk_099.png" width="40" alt="icon"> 
**Tree:** マジックスキル (`MagicSkill`, tier 1) · **Type:** Object · **Max Lv:** 10 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** [N]เวทมนตร์:แอร์โรว์[F]ธนูไฟ[A]ธนูน้ำ[W]ธนูลม[E]ธนูดิน[L]ธนูแสง[D]ธนูมืด[N] · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `MagicWallAction`

> สร้างกำแพงเวทขึ้นตรงปลายเท้า
> จะสร้างความเสียหายให้เป้าหมาย
> และผลักกระเด็นกลับไป

<details><summary>In-game level notes</summary>

- Lv14: *พลัง+30
- Lv15: *ระยะโจมตี (รัศมี)+1m

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [(mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0] | 0.84 | 0.88 | 0.92 | 0.96 | 1 | 1.04 | 1.08 | 1.12 | 1.16 | 1.2 |
| SkillRate × [(isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0] | 0.84 | 0.88 | 0.92 | 0.96 | 1 | 1.04 | 1.08 | 1.12 | 1.16 | 1.2 |
| Flat dmg + | 130 | 140 | 150 | 160 | 170 | 180 | 190 | 200 | 210 | 220 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((((Lv * 4) + 80)) / 100)` — (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0

**Role:** attack (deals damage) · placed object / trap / summon

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv * 10) + 120))`
- `SkillRate` multiplies by (adds into): `((((Lv * 4) + 80)) / 100)`
- `ExpRate` sets: `(target.ExpDefMagic / 100)` | `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**Mechanics recovered from code**

- **Number of damage events** (`damageCount`): `((int((Lv * 0.5)) + 5) + ((int((Lv * 0.5)) + 5) << 1))` → Lv1..10 [15, 18, 18, 21, 21, 24, 24, 27, 27, 30] _(when (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0)_; `(int((Lv * 0.5)) + 5)` → Lv1..10 [5, 6, 6, 7, 7, 8, 8, 9, 9, 10] _(when (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 eq 0)_; `motionSpeed`
- **Loop / hit-repeat count** (`LoopParam`): `((int((Lv * 0.5)) + 5) + ((int((Lv * 0.5)) + 5) << 1))` → Lv1..10 [15, 18, 18, 21, 21, 24, 24, 27, 27, 30] _(when (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0)_; `(int((Lv * 0.5)) + 5)` → Lv1..10 [5, 6, 6, 7, 7, 8, 8, 9, 9, 10] _(when (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 eq 0)_; `(int((Lv * 0.5)) + 5)` → Lv1..10 [5, 6, 6, 7, 7, 8, 8, 9, 9, 10] _(when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0)_
- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())` _(when (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0)_; `0` = 0 _(when PlayerAttackBase.CheckSkillParamFlag(this, 0x2000))_; `-1` = -1 _(when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0)_

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 99

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (13 paths)

- set `spellTuningWall` = `ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 99)` — when (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(100)` — when (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())` — when (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `skillRate` = `((Lv * 4) + 80)` → Lv1..10: [84, 88, 92, 96, 100, 104, 108, 112, 116, 120] — when (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `fixAddDamage` = `((Lv * 10) + 120)` → Lv1..10: [130, 140, 150, 160, 170, 180, 190, 200, 210, 220] — when (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `damageCount` = `((int((Lv * 0.5)) + 5) + ((int((Lv * 0.5)) + 5) << 1))` → Lv1..10: [15, 18, 18, 21, 21, 24, 24, 27, 27, 30] — when (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0
- set `LoopParam` = `((int((Lv * 0.5)) + 5) + ((int((Lv * 0.5)) + 5) << 1))` → Lv1..10: [15, 18, 18, 21, 21, 24, 24, 27, 27, 30] — when (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())` — when (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `damageCount` = `(int((Lv * 0.5)) + 5)` → Lv1..10: [5, 6, 6, 7, 7, 8, 8, 9, 9, 10] — when (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 eq 0
- set `LoopParam` = `(int((Lv * 0.5)) + 5)` → Lv1..10: [5, 6, 6, 7, 7, 8, 8, 9, 9, 10] — when (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 eq 0

**`WriteSkillIndividualFlag`** (1 path)

- set `SkillIndividualFlag` = `((System.Convert.ToByte(+0x151) & 255) | (((int((rad * 10)) << 1) | (System.Convert.ToByte((spellTuningWall ne 0 ? 1 : 0)) & 255)) << 1))`

**`ReadSkillIndividualFlag`** (1 path)

- set `SkillIndividualFlag` = `((SkillIndividualFlag >> 1) >> 1)`
- set `spellTuningWall` = `(System.Convert.ToBoolean(((SkillIndividualFlag >> 1) & 1)) & 1)`

**`ActionPreparation`** (5 paths)

- set `Element` = `TryGetElemntType.elementType(PlayerActionManagerBase.get_PlayerStatus())` — when !PlayerAttackBase.CheckSkillParamFlag(this, 1024) AND UnityEngine.Object.op_Inequality(actarAction)

**`ActionStart`** (2 paths)

- set `placePosition` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x`
- set `placePosition.y` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y`
- set `placePosition.z` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z`

**`InitializeOthers`** (4 paths)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1
- set `damageCount` = `motionSpeed`

**`OtherPlayerAttackStartReceive`** (2 paths)

- set `CastTime` = `0` = 0 — when PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)

**`calcPlayerToMobDamage`** (16 paths)

- template `SetRate[ExpRate]` = `(target.ExpDefMagic / 100)` — when !MobActionManagerBase.get_IsPlayerManaged(mobAction) OR MobActionManagerBase.get_IsPlayerManaged(mobAction) AND spellTuningWall ne 0 OR MobActionManagerBase.get_IsPlayerManaged(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 4, 100, playerAction) AND spellTuningWall eq 0
- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- calls `PlayerAttackBase.SetBufferConstantDamage` = `SetBufferConstantDamage(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), damageCount)` — when !MobActionManagerBase.get_IsPlayerManaged(mobAction) OR MobActionManagerBase.get_IsPlayerManaged(mobAction) AND spellTuningWall ne 0 OR MobActionManagerBase.get_IsPlayerManaged(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 4, 100, playerAction) AND spellTuningWall eq 0
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(4, 100, playerAction)` — when MobActionManagerBase.get_IsPlayerManaged(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 4, 100, playerAction) AND spellTuningWall eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 4, 100, playerAction) AND MobActionManagerBase.get_IsPlayerManaged(mobAction) AND spellTuningWall eq 0
- info `templates` = `1`
- template `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` — when !MobActionManagerBase.get_IsPlayerManaged(mobAction) OR MobActionManagerBase.get_IsPlayerManaged(mobAction) AND spellTuningWall ne 0 OR MobActionManagerBase.get_IsPlayerManaged(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 4, 100, playerAction) AND spellTuningWall eq 0

**`CheckRangeHit`** (6 paths)

- set `placePosition` = `UnityEngine.Transform.get_position(actorTransform).x` — when !PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - UnityEngine.Transform.get_position(actorTransform).y), size) AND spellTuningWall ne 0 OR (((UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(actorTransform).x) * (UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(actorTransform).x)) + ((UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(actorTransform).z) * (UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(actorTransform).z))) hi ((rad + size) * (rad + size)) AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - UnityEngine.Transform.get_position(actorTransform).y), size) AND spellTuningWall ne 0 OR (((UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(actorTransform).x) * (UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(actorTransform).x)) + ((UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(actorTransform).z) * (UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(actorTransform).z))) ls ((rad + size) * (rad + size)) AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - UnityEngine.Transform.get_position(actorTransform).y), size) AND spellTuningWall ne 0
- set `placePosition.y` = `UnityEngine.Transform.get_position(actorTransform).y` — when !PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - UnityEngine.Transform.get_position(actorTransform).y), size) AND spellTuningWall ne 0 OR (((UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(actorTransform).x) * (UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(actorTransform).x)) + ((UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(actorTransform).z) * (UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(actorTransform).z))) hi ((rad + size) * (rad + size)) AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - UnityEngine.Transform.get_position(actorTransform).y), size) AND spellTuningWall ne 0 OR (((UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(actorTransform).x) * (UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(actorTransform).x)) + ((UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(actorTransform).z) * (UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(actorTransform).z))) ls ((rad + size) * (rad + size)) AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - UnityEngine.Transform.get_position(actorTransform).y), size) AND spellTuningWall ne 0
- set `placePosition.z` = `UnityEngine.Transform.get_position(actorTransform).z` — when !PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - UnityEngine.Transform.get_position(actorTransform).y), size) AND spellTuningWall ne 0 OR (((UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(actorTransform).x) * (UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(actorTransform).x)) + ((UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(actorTransform).z) * (UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(actorTransform).z))) hi ((rad + size) * (rad + size)) AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - UnityEngine.Transform.get_position(actorTransform).y), size) AND spellTuningWall ne 0 OR (((UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(actorTransform).x) * (UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(actorTransform).x)) + ((UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(actorTransform).z) * (UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(actorTransform).z))) ls ((rad + size) * (rad + size)) AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - UnityEngine.Transform.get_position(actorTransform).y), size) AND spellTuningWall ne 0

**`ActionSkillEvent`** (4 paths)

- set `placePosition` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x` — when IsOtherPlayer ne 0 AND param eq 0 OR IsOtherPlayer eq 0 AND param eq 0
- set `placePosition.y` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y` — when IsOtherPlayer ne 0 AND param eq 0 OR IsOtherPlayer eq 0 AND param eq 0
- set `placePosition.z` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z` — when IsOtherPlayer ne 0 AND param eq 0 OR IsOtherPlayer eq 0 AND param eq 0

**`InitializeEnchantedSpell`** (5 paths)

- set `spellTuningWall` = `0` = 0
- set `Element` = `PlayerStatusBase.GetEquipSubWeaponElement(PlayerActionManagerBase.get_PlayerStatus())` — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `CastTime` = `-1` = -1 — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `SkillParam` = `(SkillParam | 1024)` — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `skillRate` = `((((Lv * 4) + 80) + (baseINT // 10)) + gemCart(106[4]))` — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `fixAddDamage` = `((Lv * 10) + 120)` → Lv1..10: [130, 140, 150, 160, 170, 180, 190, 200, 210, 220] — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `damageCount` = `(int((Lv * 0.5)) + 5)` → Lv1..10: [5, 6, 6, 7, 7, 8, 8, 9, 9, 10] — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `LoopParam` = `(int((Lv * 0.5)) + 5)` → Lv1..10: [5, 6, 6, 7, 7, 8, 8, 9, 9, 10] — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `skillRate` = `(((Lv * 4) + 80) + gemCart(106[4]))` — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0

**`UseChronosShift`** (1 path)

- set `SkillParam` = `(SkillParam | 0x2000)`
- set `lastUsedSkill` = `lastUsedSkill`

</details>

---

### เมจิกมาสเตอรี่ (MagicMastary) · uid 100

<img src="../../icons/sk_100.png" width="40" alt="icon"> 
**Tree:** マジックスキル (`MagicSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 10 · **Weapons:** Rod, MainMagictool · **Flags:** StarGem · **Client class:** `MagicMastary` (passive mastery)

> ใช้อุปกรณ์เวทได้ชำนาญขึ้น
> เพิ่มพลังโจมตีเมื่อใช้ไม้เท้า
> หรืออุปกรณ์เวท

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| EqAtkRate | 3 | 6 | 9 | 12 | 15 | 18 | 21 | 24 | 27 | 30 |
| MatkRate | 1 | 1 | 1 | 1 | 1 | 1 | 2 | 2 | 2 | 2 |


---

### ชาร์จ MP (Charging) · uid 101

<img src="../../icons/sk_101.png" width="40" alt="icon"> 
**Tree:** マジックスキル (`MagicSkill`, tier 1) · **Type:** Buffer · **Max Lv:** 10 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem · **Client class:** `ChargingAction`

> ฟื้นฟู MP ด้วยการชาร์จพลังเวท
> ใช้เวลาชาร์จน้อยลงเมื่อเลเวลเพิ่มขึ้น

<details><summary>In-game level notes</summary>

- Lv14: *ใช้เวลาชาร์จน้อยลง
- Lv15: *ใช้เวลาชาร์จน้อยลงเล็กน้อย ฟื้นฟู MP+50

</details>

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `ChargingAction.CalcChargingCastTime(actarAction, Lv)`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 101

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (3 paths)

- set `ActionRange` = `-1` = -1
- set `CastTime` = `ChargingAction.CalcChargingCastTime(actarAction, Lv)`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionSkillEvent`** (8 paths)

- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(101, Lv, Id)` — when !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND (EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) & 0xfffffffe) eq 14 AND IsOtherPlayer eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 110, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND (EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) & 0xfffffffe) ne 14 AND EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator) eq 15 AND IsOtherPlayer eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 110, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction)

**`UseChronosShift`** (1 path)

- set `SkillParam` = `(SkillParam | 0x2000)`
- set `lastUsedSkill` = `lastUsedSkill`

**`OnInheritance`** (1 path)

- set `IsInheritance` = `1` = 1

</details>

**Buffs**

**Buff `ChargingBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).

<details><summary>Effect applied in `MaximuyzerAction$$ActionStart` (40 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 101, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 116, stkp(-56), 0) & 1) ne 0` AND `+-0x34 ls 0`
  - returns `0x165d8dc(this, 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
  - set `CastTime` = `0`
  - set `WeaponType` = `15`
  - set `SkillIndividualFlag` = `((SkillIndividualFlag | 4) | 1)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - set `isEnchantStartMotion` = `0`
  - calls `PlayerAttackBase$$CheckSkillParamFlag`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `MagicProtectionBuf$$InactiveNextMaximuyzershortening`, `PlayerAttackBase$$ActionStart`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `(SkillBufferManager.TryGetBuf(?blr, 101, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 116, stkp(-56), 0) & 1) ne 0` AND `+-0x34 hi 0`
  - returns `0x165d8dc(this, 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
  - set `CastTime` = `0`
  - set `WeaponType` = `15`
  - set `SkillIndividualFlag` = `(SkillIndividualFlag | 4)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$CheckSkillParamFlag`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `MagicProtectionBuf$$InactiveNextMaximuyzershortening`, `PlayerAttackBase$$ActionStart`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `(SkillBufferManager.TryGetBuf(?blr, 101, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 116, stkp(-56), 0) & 1) ne 0` AND `+-0x34 ls 0`
  - returns `0x165d8dc(this, 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
  - set `CastTime` = `(((20 - Lv) - max(((5 - Lv) * 0.5), 0)) - [TryGetBuf.out2()+0x10])`
  - set `WeaponType` = `15`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - set `isEnchantStartMotion` = `0`
  - set `SkillIndividualFlag` = `(SkillIndividualFlag | 1)`
  - calls `PlayerAttackBase$$CheckSkillParamFlag`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ActionStart`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`
- when `(SkillBufferManager.TryGetBuf(?blr, 101, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 116, stkp(-56), 0) & 1) ne 0` AND `+-0x34 hi 0`
  - returns `0x165d8dc(this, 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
  - set `CastTime` = `(((20 - Lv) - max(((5 - Lv) * 0.5), 0)) - [TryGetBuf.out2()+0x10])`
  - set `WeaponType` = `15`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$CheckSkillParamFlag`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ActionStart`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `(SkillBufferManager.TryGetBuf(?blr, 101, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 116, stkp(-56), 0) & 1) eq 0` AND `+-0x34 ls 0`
  - returns `0x165d8dc(this, 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
  - set `CastTime` = `(((20 - Lv) - max(((5 - Lv) * 0.5), 0)) - [TryGetBuf.out2()+0x10])`
  - set `WeaponType` = `15`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - set `isEnchantStartMotion` = `0`
  - set `SkillIndividualFlag` = `(SkillIndividualFlag | 1)`
  - calls `PlayerAttackBase$$CheckSkillParamFlag`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ActionStart`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`
- when `(SkillBufferManager.TryGetBuf(?blr, 101, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 116, stkp(-56), 0) & 1) eq 0` AND `+-0x34 hi 0`
  - returns `0x165d8dc(this, 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
  - set `CastTime` = `(((20 - Lv) - max(((5 - Lv) * 0.5), 0)) - [TryGetBuf.out2()+0x10])`
  - set `WeaponType` = `15`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$CheckSkillParamFlag`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ActionStart`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `(SkillBufferManager.TryGetBuf(?blr, 101, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 116, stkp(-56), 0) & 1) ne 0` AND `+-0x34 ls 0`
  - returns `0x165d8dc(this, 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
  - set `CastTime` = `0`
  - set `SkillIndividualFlag` = `((SkillIndividualFlag | 4) | 1)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - set `isEnchantStartMotion` = `0`
  - calls `PlayerAttackBase$$CheckSkillParamFlag`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `MagicProtectionBuf$$InactiveNextMaximuyzershortening`, `PlayerAttackBase$$ActionStart`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `(SkillBufferManager.TryGetBuf(?blr, 101, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 116, stkp(-56), 0) & 1) ne 0` AND `+-0x34 hi 0`
  - returns `0x165d8dc(this, 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
  - set `CastTime` = `0`
  - set `SkillIndividualFlag` = `(SkillIndividualFlag | 4)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$CheckSkillParamFlag`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `MagicProtectionBuf$$InactiveNextMaximuyzershortening`, `PlayerAttackBase$$ActionStart`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`

</details>

<details><summary>Effect applied in `MaximuyzerSwitchingBuff$$ConverterMaximuyzerSwitching` (34 guarded paths)</summary>

- when `(GemCartBufferManager.ContainsBuffer(?blr, 404, comboManager, skillActionManager) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 116, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(101) ge 1`
  - returns `110`
  - calls `SkillComboManager$$CheckEnableFirstSkillId`, `SkillComboManager$$get_ComboStarted`, `SkillComboState$$get_CurrentSkillId`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual SkillActionManagerBase.get_CurrentSkill`, `virtual CharacterActionManagerBase.get_IsLocalDead`
- when `(GemCartBufferManager.ContainsBuffer(?blr, 404, comboManager, skillActionManager) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 116, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(101) ge 1`
  - returns `101`
  - calls `SkillComboManager$$CheckEnableFirstSkillId`, `SkillComboManager$$get_ComboStarted`, `SkillComboState$$get_CurrentSkillId`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual SkillActionManagerBase.get_CurrentSkill`, `virtual CharacterActionManagerBase.get_IsLocalDead`
- when `(GemCartBufferManager.ContainsBuffer(?blr, 404, comboManager, skillActionManager) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 116, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(101) ge 1`
  - returns `101`
  - calls `SkillComboManager$$CheckEnableFirstSkillId`, `SkillComboManager$$get_ComboStarted`, `SkillComboState$$get_CurrentSkillId`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual SkillActionManagerBase.get_CurrentSkill`, `virtual CharacterActionManagerBase.get_IsLocalDead`
- when `(GemCartBufferManager.ContainsBuffer(?blr, 404, comboManager, skillActionManager) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 116, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(101) ge 1`
  - returns `skillId`
  - calls `SkillComboManager$$CheckEnableFirstSkillId`, `SkillComboManager$$get_ComboStarted`, `SkillComboState$$get_CurrentSkillId`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual SkillActionManagerBase.get_CurrentSkill`, `virtual CharacterActionManagerBase.get_IsLocalDead`
- when `(GemCartBufferManager.ContainsBuffer(?blr, 404, comboManager, skillActionManager) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 116, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(101) ge 1`
  - returns `101`
  - calls `SkillComboManager$$CheckEnableFirstSkillId`, `SkillComboManager$$get_ComboStarted`, `SkillComboState$$get_CurrentSkillId`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual SkillActionManagerBase.get_CurrentSkill`
- when `(GemCartBufferManager.ContainsBuffer(?blr, 404, comboManager, skillActionManager) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 116, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(101) ge 1`
  - returns `101`
  - calls `SkillComboManager$$CheckEnableFirstSkillId`, `SkillComboManager$$get_ComboStarted`, `SkillComboState$$get_CurrentSkillId`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`
- when `(GemCartBufferManager.ContainsBuffer(?blr, 404, comboManager, skillActionManager) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 116, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(101) lt 1`
  - returns `skillId`
  - calls `SkillComboManager$$CheckEnableFirstSkillId`, `SkillComboManager$$get_ComboStarted`, `SkillComboState$$get_CurrentSkillId`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`
- when `(GemCartBufferManager.ContainsBuffer(?blr, 404, comboManager, skillActionManager) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 116, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `skillId`
  - calls `SkillComboManager$$CheckEnableFirstSkillId`, `SkillComboManager$$get_ComboStarted`, `SkillComboState$$get_CurrentSkillId`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`

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

- `MaximuyzerAction$$ActionStart (TryGetBuf)`
- `MaximuyzerSwitchingBuff$$ConverterMaximuyzerSwitching (ContainsBuffer)`
- `MaximuyzerSwitchingBuff$$ConverterMaximuyzerSwitching (GetSkillLv)`
- `PlayerAttackBase$$RemoveAfterSkillBuf (ContainsBuffer)`

---

### เวทมนตร์:แลนซ์  / วัลแคน  / ไอซ์ซิเคิล / สลาตัน / ปืนใหญ่ศิลา / แสงสังหาร / สุริยคราส (MagicLancer) · uid 102

<img src="../../icons/sk_102.png" width="40" alt="icon"> 
**Tree:** マジックスキル (`MagicSkill`, tier 2) · **Type:** Object · **Max Lv:** 30 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** [N]เวทมนตร์:แจฟลิน[F]หอกเพลิง[A]หอกน้ำแข็ง[W]หอกวายุ[E]หอกศิลา[L]หอกศักดิ์สิทธิ์[D]หอกอนธการ[N] · **Flags:** MercenaryCanUseSkill · **Client class:** `MagicLancerAction`

> ยิงหอกเวทต่อเนื่อง
> จำนวนที่ยิงออกไปจะเพิ่มขึ้นตามเลเวล
> มีโอกาสทำให้เป้าหมาย[หยุดนิ่ง]

<details><summary>In-game level notes</summary>

- Lv14: *พลัง+150 *พลังจะเพิ่มมากกว่าค่า INT ของตัวเอง *อัตราติดหยุดนิ่งx3
- Lv15: *พลังจะเพิ่มมากกว่าค่า INT ของตัวเอง *เพิ่มจำนวนครั้งการโจมตี *อัตราติดหยุดนิ่งx3

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 2.65 | 2.8 | 2.95 | 3.1 | 3.25 | 3.4 | 3.55 | 3.7 | 3.85 | 4 |
| Flat dmg + | 304 | 308 | 312 | 316 | 320 | 324 | 328 | 332 | 336 | 340 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv * 15) + 250) + (status.Int / 5))) * 0.01)` — ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) eq 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- SkillRate × `(((((Lv * 15) + 250) + (status.Int / 5))) * 0.01)` — (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 eq 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0

**Role:** attack (deals damage) · applies status ailment · placed object / trap / summon

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv << 2) + 300))`
- `SkillRate` multiplies by (adds into): `(((((Lv * 15) + 250) + (status.Int / 5))) * 0.01)`

**Mechanics recovered from code**

- **Stop chance (%)** (`stopPercent`): `(((Lv << 1) + 10) + (((Lv << 1) + 10) << 1))` → Lv1..10 [36, 42, 48, 54, 60, 66, 72, 78, 84, 90] _(when (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 eq 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0)_; `((Lv << 1) + 10)` → Lv1..10 [12, 14, 16, 18, 20, 22, 24, 26, 28, 30] _(when (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 eq 0 AND spellTuningLancer ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0)_; `(stopPercent + (stopPercent << 1))` _(when ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) eq 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0)_
- **Magic pierce %** (`magicResistBreaker`): `(((Lv << 1) + 10) + (((Lv << 1) + 10) << 1))` → Lv1..10 [36, 42, 48, 54, 60, 66, 72, 78, 84, 90] _(when (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND spellTuningLancer ne 0)_; `((Lv << 1) + 10)` → Lv1..10 [12, 14, 16, 18, 20, 22, 24, 26, 28, 30] _(when (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR ((spellTuningLancer eq 0 ? (20 - gemCart(205[2])) : ((20 - gemCart(205[2])) - 10)) & 0x80000000) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND spellTuningLancer eq 0)_; `0` = 0 _(when ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) eq 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction))_
- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())` _(when (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 eq 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0)_; `0` = 0 _(when CastTime mi 0 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) OR CastTime pl 0 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000))_; `-1` = -1 _(when ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) eq 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction))_
- **Number of damage events** (`damageCount`): `((((Lv - 1) // 5) + 2) + 2)` → Lv1..10 [4, 4, 4, 4, 4, 5, 5, 5, 5, 5] _(when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 eq 0 AND spellTuningLancer ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0)_; `(((Lv - 1) // 5) + 2)` → Lv1..10 [2, 2, 2, 2, 2, 3, 3, 3, 3, 3] _(when (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 eq 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0)_; `((((Lv - 1) // 5) + 2) + 2)` → Lv1..10 [4, 4, 4, 4, 4, 5, 5, 5, 5, 5] _(when ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) eq 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0)_
- **Loop / hit-repeat count** (`LoopParam`): `((((Lv - 1) // 5) + 2) + 2)` → Lv1..10 [4, 4, 4, 4, 4, 5, 5, 5, 5, 5] _(when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 eq 0 AND spellTuningLancer ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0)_; `(((Lv - 1) // 5) + 2)` → Lv1..10 [2, 2, 2, 2, 2, 3, 3, 3, 3, 3] _(when (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 eq 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0)_; `motionSpeed`

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 102

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (37 paths)

- set `spellTuningLancer` = `ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102)` — when (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 eq 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())` — when (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 eq 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(14)` — when (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 eq 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `skillRate` = `(((Lv * 15) + 250) + (status.Int / 5))` — when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 eq 0 AND spellTuningLancer ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `fixAddDamage` = `((Lv << 2) + 300)` → Lv1..10: [304, 308, 312, 316, 320, 324, 328, 332, 336, 340] — when (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 eq 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `stopPercent` = `(((Lv << 1) + 10) + (((Lv << 1) + 10) << 1))` → Lv1..10: [36, 42, 48, 54, 60, 66, 72, 78, 84, 90] — when (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 eq 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `magicResistBreaker` = `(((Lv << 1) + 10) + (((Lv << 1) + 10) << 1))` → Lv1..10: [36, 42, 48, 54, 60, 66, 72, 78, 84, 90] — when (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND spellTuningLancer ne 0
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())` — when (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 eq 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `damageCount` = `((((Lv - 1) // 5) + 2) + 2)` → Lv1..10: [4, 4, 4, 4, 4, 5, 5, 5, 5, 5] — when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 eq 0 AND spellTuningLancer ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `LoopParam` = `((((Lv - 1) // 5) + 2) + 2)` → Lv1..10: [4, 4, 4, 4, 4, 5, 5, 5, 5, 5] — when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 eq 0 AND spellTuningLancer ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `interval` = `max((ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) eq 0 ? (20 - gemCart(205[2])) : ((20 - gemCart(205[2])) - 10)), 0)` — when (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 eq 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `SkillIndividualFlag` = `max((ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) eq 0 ? (20 - gemCart(205[2])) : ((20 - gemCart(205[2])) - 10)), 0)` — when (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 eq 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `interval` = `(20 - gemCart(205[2]))` — when ((spellTuningLancer eq 0 ? (20 - gemCart(205[2])) : ((20 - gemCart(205[2])) - 10)) & 0x80000000) eq 0 AND (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND spellTuningLancer eq 0 OR ((spellTuningLancer eq 0 ? (20 - gemCart(205[2])) : ((20 - gemCart(205[2])) - 10)) & 0x80000000) eq 0 AND (mainWeapon==Rod & 1) ne 0 AND +0x141 eq 0 AND spellTuningLancer eq 0 OR ((ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) eq 0 ? (20 - gemCart(205[2])) : ((20 - gemCart(205[2])) - 10)) & 0x80000000) eq 0 AND (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `SkillIndividualFlag` = `(20 - gemCart(205[2]))` — when ((spellTuningLancer eq 0 ? (20 - gemCart(205[2])) : ((20 - gemCart(205[2])) - 10)) & 0x80000000) eq 0 AND (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND spellTuningLancer eq 0 OR ((spellTuningLancer eq 0 ? (20 - gemCart(205[2])) : ((20 - gemCart(205[2])) - 10)) & 0x80000000) eq 0 AND (mainWeapon==Rod & 1) ne 0 AND +0x141 eq 0 AND spellTuningLancer eq 0 OR ((ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) eq 0 ? (20 - gemCart(205[2])) : ((20 - gemCart(205[2])) - 10)) & 0x80000000) eq 0 AND (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `skillRate` = `((Lv * 15) + 250)` → Lv1..10: [265, 280, 295, 310, 325, 340, 355, 370, 385, 400] — when (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 eq 0 AND spellTuningLancer ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `stopPercent` = `((Lv << 1) + 10)` → Lv1..10: [12, 14, 16, 18, 20, 22, 24, 26, 28, 30] — when (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 eq 0 AND spellTuningLancer ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `magicResistBreaker` = `((Lv << 1) + 10)` → Lv1..10: [12, 14, 16, 18, 20, 22, 24, 26, 28, 30] — when (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR ((spellTuningLancer eq 0 ? (20 - gemCart(205[2])) : ((20 - gemCart(205[2])) - 10)) & 0x80000000) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND spellTuningLancer eq 0
- set `damageCount` = `(((Lv - 1) // 5) + 2)` → Lv1..10: [2, 2, 2, 2, 2, 3, 3, 3, 3, 3] — when (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 eq 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `LoopParam` = `(((Lv - 1) // 5) + 2)` → Lv1..10: [2, 2, 2, 2, 2, 3, 3, 3, 3, 3] — when (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 eq 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `skillRate` = `(((Lv * 15) + 250) + ((status.Int / 5) + 150))` — when (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 eq 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 102) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `interval` = `max((spellTuningLancer eq 0 ? (20 - gemCart(205[2])) : ((20 - gemCart(205[2])) - 10)), 0)` — when (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 eq 0 AND spellTuningLancer ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND spellTuningLancer ne 0
- set `SkillIndividualFlag` = `max((spellTuningLancer eq 0 ? (20 - gemCart(205[2])) : ((20 - gemCart(205[2])) - 10)), 0)` — when (mainWeapon==Rod & 1) ne 0 AND +0x141 ne 0 AND spellTuningLancer ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x141 eq 0 AND spellTuningLancer ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x141 ne 0 AND spellTuningLancer ne 0

**`InitializeOthers`** (3 paths)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1
- set `LoopParam` = `motionSpeed`

**`OtherPlayerAttackStartReceive`** (1 path)

- set `interval` = `skillIndividualFlag`

**`ActionStartOthers`** (4 paths)

- set `CastTime` = `0` = 0 — when CastTime mi 0 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) OR CastTime pl 0 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)

**`ActionPreparation`** (5 paths)

- set `Element` = `TryGetElemntType.elementType(PlayerActionManagerBase.get_PlayerStatus())` — when !PlayerAttackBase.CheckSkillParamFlag(this, 1024) AND UnityEngine.Object.op_Inequality(actarAction)

**`calcPlayerToMobDamage`** (698 paths)

- template `AddRate[SkillRate]` = `(skillRate * 0.01)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(12, stopPercent, playerAction)` — when PlayerAttackBase.checkAbnormalPercent(this, 12, stopPercent, playerAction) AND damageCount lt 1 OR !PlayerAttackBase.checkAbnormalPercent(this, 12, stopPercent, playerAction) AND damageCount lt 1 OR 1 ge damageCount AND PlayerAttackBase.checkAbnormalPercent(this, 12, stopPercent, playerAction) AND damageCount ge 1
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(12, 0)` — when PlayerAttackBase.checkAbnormalPercent(this, 12, stopPercent, playerAction) AND damageCount lt 1 OR 1 ge damageCount AND PlayerAttackBase.checkAbnormalPercent(this, 12, stopPercent, playerAction) AND damageCount ge 1 OR 1 lt damageCount AND 2 ge damageCount AND PlayerAttackBase.checkAbnormalPercent(this, 12, stopPercent, playerAction) AND damageCount ge 1
- info `templates` = `1`

**`InitializeEnchantedSpell`** (9 paths)

- set `spellTuningLancer` = `0` = 0
- set `Element` = `PlayerStatusBase.GetEquipSubWeaponElement(PlayerActionManagerBase.get_PlayerStatus())` — when ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) eq 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `CastTime` = `-1` = -1 — when ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) eq 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `SkillParam` = `(SkillParam | 1024)` — when ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) eq 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `skillRate` = `(((Lv * 15) + 250) + (status.Int / 5))` — when ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) eq 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `damageCount` = `((((Lv - 1) // 5) + 2) + 2)` → Lv1..10: [4, 4, 4, 4, 4, 5, 5, 5, 5, 5] — when ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) eq 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `stopPercent` = `(stopPercent + (stopPercent << 1))` — when ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) eq 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `LoopParam` = `((((Lv - 1) // 5) + 2) + 2)` → Lv1..10: [4, 4, 4, 4, 4, 5, 5, 5, 5, 5] — when ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) eq 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `interval` = `0` = 0 — when ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `magicResistBreaker` = `0` = 0 — when ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) eq 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `SkillIndividualFlag` = `0` = 0 — when ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `interval` = `(20 - gemCart(205[2]))` — when ((20 - gemCart(205[2])) & 0x80000000) eq 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) eq 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND ((20 - gemCart(205[2])) & 0x80000000) eq 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `SkillIndividualFlag` = `(20 - gemCart(205[2]))` — when ((20 - gemCart(205[2])) & 0x80000000) eq 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) eq 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND ((20 - gemCart(205[2])) & 0x80000000) eq 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `skillRate` = `((Lv * 15) + 250)` → Lv1..10: [265, 280, 295, 310, 325, 340, 355, 370, 385, 400] — when ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) eq 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0
- set `damageCount` = `(((Lv - 1) // 5) + 2)` → Lv1..10: [2, 2, 2, 2, 2, 3, 3, 3, 3, 3] — when ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) eq 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0
- set `LoopParam` = `(((Lv - 1) // 5) + 2)` → Lv1..10: [2, 2, 2, 2, 2, 3, 3, 3, 3, 3] — when ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR ((20 - gemCart(205[2])) & 0x80000000) eq 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND ((20 - gemCart(205[2])) & 0x80000000) ne 0 AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0

**`UseChronosShift`** (1 path)

- set `SkillParam` = `(SkillParam | 0x2000)`
- set `lastUsedSkill` = `lastUsedSkill`

</details>

---

### เวทมนตร์:บลาส / เอ็กซ์โพลชั่น  / แอบโซลูทซีโร่ / แอร์โรว์บลาส / จีโออิมแพ็ค / ไชน์นิ่งบลาส / อีวิลบลาส (MagicBlast) · uid 103

<img src="../../icons/sk_103.png" width="40" alt="icon"> 
**Tree:** マジックスキル (`MagicSkill`, tier 2) · **Type:** Attack · **Max Lv:** 30 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** [N]เวทมนตร์:กำแพง[F]กำแพงอัคคี[A]ม่านวารี[W]กำแพงวายุ[E]เขตแดนปฐพี[L]เขตแดนศักดิ์สิทธิ์[D]ประตูอสูร[N] · **Flags:** MercenaryCanUseSkill · **Client class:** `MagicBlastAction`

> รวบรวมพลังเวทสร้างระเบิดขนาดใหญ่
> มีโอกาสทำให้เป้าหมายติดสภาวะผิดปกติ
> สภาวะนั้นจะเปลี่ยนไปตามธาตุ

<details><summary>In-game level notes</summary>

- Lv14: *พลัง+150 *พลังจะเพิ่มมากกว่าค่า INT ของตัวเอง
- Lv15: *พลังจะเพิ่มมากกว่าค่า INT ของตัวเอง *อัตราติดสภาวะผิดปกติ+50% *ระยะโจมตี (รัศมี)+2m

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 7.3 | 7.6 | 7.9 | 8.2 | 8.5 | 8.8 | 9.1 | 9.4 | 9.7 | 10 |
| Flat dmg + | 200 | 220 | 240 | 260 | 280 | 300 | 320 | 340 | 360 | 380 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv * 30) + 700) + (status.Int / 5))) * 0.01)` — (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 eq 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- SkillRate × `(((((Lv * 30) + 700) + (status.Int / 5))) * 0.01)` — (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- SkillRate × `(((((Lv * 30) + 700) + (status.Int / 5))) * 0.01)` — (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0

**Role:** attack (deals damage) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv * 20) + 180))`
- `SkillRate` multiplies by (adds into): `(((((Lv * 30) + 700) + (status.Int / 5))) * 0.01)`

**Mechanics recovered from code**

- **Ailment chance (%)** (`abnormalRate`): `(((Lv + (Lv << 2)) + 50) // 5)` → Lv1..10 [11, 12, 13, 14, 15, 16, 17, 18, 19, 20] _(when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0)_; `((Lv + (Lv << 2)) + 50)` → Lv1..10 [55, 60, 65, 70, 75, 80, 85, 90, 95, 100] _(when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 eq 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0)_; `((Lv + (Lv << 2)) // 5)` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] _(when (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0)_
- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, (((ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 103) eq 0 ? 4 : 3) + -2) + (gemCart(206[2]) * -0.1)), PlayerActionManagerBase.get_PlayerStatus())` _(when (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0)_; `PlayerAttackBase.CalcCastTime(this, ((ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 103) eq 0 ? 4 : 3) + (gemCart(206[2]) * -0.1)), PlayerActionManagerBase.get_PlayerStatus())` _(when (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0)_; `PlayerAttackBase.CalcCastTime(this, (((spellTuningBlast eq 0 ? 4 : 3) + -2) + (gemCart(206[2]) * -0.1)), PlayerActionManagerBase.get_PlayerStatus())` _(when (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0)_

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 103

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (13 paths)

- set `spellTuningBlast` = `ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 103)` — when (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())` — when (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `skillRate` = `(((Lv * 30) + 700) + (status.Int / 5))` — when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 eq 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `abnormalRate` = `(((Lv + (Lv << 2)) + 50) // 5)` → Lv1..10: [11, 12, 13, 14, 15, 16, 17, 18, 19, 20] — when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `fixAddDamage` = `((Lv * 20) + 180)` → Lv1..10: [200, 220, 240, 260, 280, 300, 320, 340, 360, 380] — when (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(8)` — when (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, (((ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 103) eq 0 ? 4 : 3) + -2) + (gemCart(206[2]) * -0.1)), PlayerActionManagerBase.get_PlayerStatus())` — when (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `abnormalRate` = `((Lv + (Lv << 2)) + 50)` → Lv1..10: [55, 60, 65, 70, 75, 80, 85, 90, 95, 100] — when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 eq 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, ((ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 103) eq 0 ? 4 : 3) + (gemCart(206[2]) * -0.1)), PlayerActionManagerBase.get_PlayerStatus())` — when (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `skillRate` = `((Lv * 30) + 700)` → Lv1..10: [730, 760, 790, 820, 850, 880, 910, 940, 970, 1000] — when (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 eq 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `abnormalRate` = `((Lv + (Lv << 2)) // 5)` → Lv1..10: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] — when (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0
- set `abnormalRate` = `(Lv + (Lv << 2))` → Lv1..10: [5, 10, 15, 20, 25, 30, 35, 40, 45, 50] — when (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 eq 0
- set `skillRate` = `(((Lv * 30) + 700) + ((status.Int / 5) + 150))` — when (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 OR (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, (((spellTuningBlast eq 0 ? 4 : 3) + -2) + (gemCart(206[2]) * -0.1)), PlayerActionManagerBase.get_PlayerStatus())` — when (mainWeapon==Rod & 1) ne 0 AND +0x151 ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 ne 0
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, ((spellTuningBlast eq 0 ? 4 : 3) + (gemCart(206[2]) * -0.1)), PlayerActionManagerBase.get_PlayerStatus())` — when (mainWeapon==Rod & 1) ne 0 AND +0x151 eq 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 eq 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND +0x151 eq 0

**`InitializeOthers`** (3 paths)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`OtherPlayerAttackStartReceive`** (2 paths)

- set `CastTime` = `0` = 0 — when PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)

**`calcPlayerToMobDamage`** (9 paths)

- template `AddRate[SkillRate]` = `(skillRate * 0.01)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- info `templates` = `1`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(1, abnormalRate, playerAction)` — when GemCartBufferManager.GetTalentElementType(PlayerStatusBase.get_GemCartBuffManager()) hi 8 AND PlayerAttackBase.checkAbnormalPercent(this, 1, abnormalRate, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 1, abnormalRate, playerAction) AND GemCartBufferManager.GetTalentElementType(PlayerStatusBase.get_GemCartBuffManager()) hi 8
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(1, 0)` — when GemCartBufferManager.GetTalentElementType(PlayerStatusBase.get_GemCartBuffManager()) hi 8 AND PlayerAttackBase.checkAbnormalPercent(this, 1, abnormalRate, playerAction)

**`ActionPreparation`** (7 paths)

- set `Element` = `TryGetElemntType.elementType(PlayerActionManagerBase.get_PlayerStatus())` — when !PlayerAttackBase.CheckSkillParamFlag(this, 1024) AND UnityEngine.Object.op_Inequality(actarAction)

**`ActionStart`** (2 paths)

- set `attackTransform` = `UnityEngine.GameObject.get_transform(target)`
- set `attackPosition` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x`
- set `attackPosition.y` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y`
- set `attackPosition.z` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z`

**`InitializeEnchantedSpell`** (5 paths)

- set `spellTuningBlast` = `0` = 0
- set `Element` = `PlayerStatusBase.GetEquipSubWeaponElement(PlayerActionManagerBase.get_PlayerStatus())` — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `CastTime` = `-1` = -1 — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `SkillParam` = `(SkillParam | 1024)` — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `fixAddDamage` = `((Lv * 20) + 180)` → Lv1..10: [200, 220, 240, 260, 280, 300, 320, 340, 360, 380] — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `skillRate` = `((status.Int / 5) + ((Lv * 30) + 700))` — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `abnormalRate` = `((Lv + (Lv << 2)) + 50)` → Lv1..10: [55, 60, 65, 70, 75, 80, 85, 90, 95, 100] — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `skillRate` = `((Lv * 30) + 700)` → Lv1..10: [730, 760, 790, 820, 850, 880, 910, 940, 970, 1000] — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0
- set `abnormalRate` = `(Lv + (Lv << 2))` → Lv1..10: [5, 10, 15, 20, 25, 30, 35, 40, 45, 50] — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0

**`UseChronosShift`** (1 path)

- set `SkillParam` = `(SkillParam | 0x2000)`
- set `lastUsedSkill` = `lastUsedSkill`

</details>

---

### เชนแคสต์ (ChainCast) · uid 104

<img src="../../icons/sk_104.png" width="40" alt="icon"> 
**Tree:** マジックスキル (`MagicSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 30 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ชาร์จ MP · **Client class:** `ChainCast` (passive mastery)

> ร่ายเวทได้อย่างมีประสิทธิภาพ
> ร่ายได้เร็วขึ้นหลังใช้ "เวทมนตร์:แอร์โรว์"
> 
> เอฟเฟกต์เพิ่มเติมจะได้รับจากไม้เท้าหรืออุปกรณ์เวทมนตร์ (หลัก)

<details><summary>In-game level notes</summary>

- Lv14: ทุกครั้งที่โจมตีด้วยสกิลโจมตีที่มีระยะเวลาร่ายเวทย์เวลา ในการร่ายจะสั้นลง MATK เพิ่มขึ้นเล็กน้อยและความเสถียร เวทมนต์จะเพิ่มขึ้น สามารถรับเอฟเฟกต์นี้ได้สูงสุด 10 ครั้ง
- Lv15: ทุกครั้งที่โจมตีด้วยสกิลโจมตีที่มีระยะเวลาร่ายเวทย์ เวลาในการร่ายจะสั้นลง MATK เพิ่มขึ้นและความเสถียร เวทมนต์จะเพิ่มขึ้นเล็กน้อยสามารถรับเอฟเฟกต์นี้ได้สูงสุด 10 ครั้ง

</details>

**Role:** buff (self) · passive mastery

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Buffs**

**Buff `ChainCastBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- `MotionSpeedRate` = `0` _(when BuffEffectActive eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MotionSpeedRate | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |

**Buff `ChainCastStackBuf`**
- Attached to this skill via `manual:name stem + constructed in monster Damaged hooks (stack of ChainCast); inferred` (no direct constructor call in the skill's own code).
- Buff hook methods: `Next`
- `Count` = `Count` _(when BuffEffectActive ne 0)_
- `MotionSpeed` = `Count` _(when BuffEffectActive ne 0)_
- `MatkUp` = `((Count * Lv) << (EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 15 ? 1 : 0))` _(when BuffEffectActive ne 0)_
- `Value` = `((Count * Lv) << (EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 14 ? 1 : 0))` _(when BuffEffectActive ne 0)_
- Buff fields set in the constructor (all recovered):
  - `playerStatus` = `status`
- Hook `Updata`: `LeftTime`=30; `Count`=(Count - 1); `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
- Hook `Next`: `LeftTime`=30

---

### เมจิคไนฟ์ (MagicKnife) · uid 117

<img src="../../icons/sk_117.png" width="40" alt="icon"> 
**Tree:** マジックスキル (`MagicSkill`, tier 2) · **Type:** Object · **Max Lv:** 30 · **Weapons:** Rod · **Requires:** เมจิกมาสเตอรี่ · **Client class:** `MagicKnifeAction`

> ใช้มีดสั้นเวทมนตร์ยับยั้งศัตรู
> สกิลนี้โจมตีด้วย[ความเคยชินตามปกติ]
> เล็งตรงเป้าและเมื่อโจมตีเข้าเป้าจะฟื้นฟู MP เล็กน้อย
> เมื่อถึง Lv10 โจมตีเพิ่มและโจมตีด้วยความเคยชินตามปกติจะเพิ่มขึ้น

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((System.Math.Min(((Lv * 10) + 60), 150)) / 100)`

**Role:** attack (deals damage) · placed object / trap / summon

The skill builds 2 separate damage templates (each is a full hit with its own crit roll). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **normal-attack proration slot**; Proration change is decided by the skill's own check (`CheckExpDefFluctuate`).

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillRate` multiplies by (adds into): `((System.Math.Min(((Lv * 10) + 60), 150)) / 100)`

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `0` = 0
- **Loop / hit-repeat count** (`LoopParam`): `int(MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)))`

**Proration:** slot `Normal`, mode `custom_check`, attack type `SkillNormal`, action id 117

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `Element` = `7` = 7
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(8)`
- set `skillRate` = `System.Math.Min(((Lv * 10) + 60), 150)`
- set `CastTime` = `0` = 0
- set `effectAngle` = `45` = 45
- set `attackTake` = `new SkillLinkedTake`

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1
- set `attackTake` = `new SkillLinkedTake`

**`ActionStart`** (1 path)

- set `LoopParam` = `int(MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)))`

**`ActionSkillEvent`** (4 paths)

- set `effectAngle` = `(effectAngle + 90)` — when param eq 101 AND param ne 102
- set `effectAngle` = `45` = 45 — when Lv eq 10 AND param eq 102

**`calcPlayerToMobDamage`** (5 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- info `templates` = `2` — when Lv eq 10
- info `templates` = `1` — when Lv ne 10

**`ActionSkillReceiveEffect`** (1 path)

- set `effectAngle` = `(effectAngle + 90)`

</details>

---

### เวทมนตร์:อิมแพ็ค (MagicImpact) · uid 105

<img src="../../icons/sk_105.png" width="40" alt="icon"> 
**Tree:** マジックスキル (`MagicSkill`, tier 3) · **Type:** Attack · **Max Lv:** 70 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** [N]เวทมนตร์:แลนซ์ [F]วัลแคน [A]ไอซ์ซิเคิล[W]สลาตัน[E]ปืนใหญ่ศิลา[L]แสงสังหาร[D]สุริยคราส[N] · **Flags:** MercenaryCanUseSkill · **Client class:** `MagicImpactAction`

> โจมตีศัตรูรอบบริเวณด้วยพลังคลื่นทำลายล้าง
> ลดการใช้ MP ลงครึ่งหนึ่งเมื่อใช้สกิลถัดไป
> ประสิทธิภาพของสกิลจะลดลงเมื่อใช้อย่างต่อเนื่อง

<details><summary>In-game level notes</summary>

- Lv14: *อัตราติดล้มคว่ำ+25%
- Lv15: *พลัง+250

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [(isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND isUseMagicImpact ne 0 OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND isUseMagicImpact ne 0] | 0.1 | 0.2 | 0.3 | 0.4 | 0.5 | 0.6 | 0.7 | 0.8 | 0.9 | 1 |
| SkillRate × [!hasBuff(105) AND (ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 105) & 256) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR !hasBuff(105) AND (ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 105) & 256) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) le 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0] | 5.25 | 5.5 | 5.75 | 6 | 6.25 | 6.5 | 6.75 | 7 | 7.25 | 7.5 |
| SkillRate × [(isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND isUseMagicImpact eq 0] | 2.75 | 3 | 3.25 | 3.5 | 3.75 | 4 | 4.25 | 4.5 | 4.75 | 5 |
| SkillRate × [(isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND isUseMagicImpact eq 0] | 0.25 | 0.5 | 0.75 | 1 | 1.25 | 1.5 | 1.75 | 2 | 2.25 | 2.5 |
| Flat dmg + [(isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND isUseMagicImpact ne 0 OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND isUseMagicImpact ne 0] | 110 | 120 | 130 | 140 | 150 | 160 | 170 | 180 | 190 | 200 |
| Flat dmg + [(isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND isUseMagicImpact eq 0 OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND isUseMagicImpact eq 0] | 110 | 120 | 130 | 140 | 150 | 160 | 170 | 180 | 190 | 200 |

**Role:** attack (deals damage) · buff (self) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **slot chosen at runtime (physical or magic by a per-cast flag)**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `((((Lv + (Lv << 2)) << 1) + 100))`
- `SkillRate` multiplies by (adds into): `((((Lv + (Lv << 2)) << 1)) / 100)`

**Mechanics recovered from code**

- **Ailment chance (%)** (`abnormalRate`): `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] _(when (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 AND hasBuff(105) OR (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) le 0 AND hasBuff(105) OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 AND hasBuff(105))_; `(((Lv + (Lv << 2)) + 15) + 35)` → Lv1..10 [55, 60, 65, 70, 75, 80, 85, 90, 95, 100] _(when !hasBuff(105) AND (ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 105) & 256) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR !hasBuff(105) AND (ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 105) & 256) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) le 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR !hasBuff(105) AND (ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 105) & 256) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0)_; `((Lv + (Lv << 2)) + 15)` → Lv1..10 [20, 25, 30, 35, 40, 45, 50, 55, 60, 65] _(when !hasBuff(105) AND (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) eq 0 OR !hasBuff(105) AND (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 OR !hasBuff(105) AND (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) le 0)_
- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus())` _(when (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 AND hasBuff(105) OR (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) le 0 AND hasBuff(105) OR !hasBuff(105) AND (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0)_; `0` = 0 _(when PlayerAttackBase.CheckSkillParamFlag(this, 0x2000))_; `-1` = -1 _(when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND isUseMagicImpact ne 0 OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND isUseMagicImpact eq 0 OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND isUseMagicImpact ne 0)_

**Proration:** slot `dynamic`, mode `first_hit_per_target`, attack type `Magic`, action id 105

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (27 paths)

- set `isGemCart` = `(hasGemCart(403) & 1)`
- set `Element` = `7` = 7
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(100)`
- set `isUseMagicImpact` = `1` = 1 — when (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 AND hasBuff(105) OR (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) le 0 AND hasBuff(105) OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 AND hasBuff(105)
- set `abnormalRate` = `Lv` → Lv1..10: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] — when (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 AND hasBuff(105) OR (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) le 0 AND hasBuff(105) OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 AND hasBuff(105)
- set `skillRate` = `((Lv + (Lv << 2)) << 1)` → Lv1..10: [10, 20, 30, 40, 50, 60, 70, 80, 90, 100] — when (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 AND hasBuff(105) OR (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) le 0 AND hasBuff(105) OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 AND hasBuff(105)
- set `fixAddDamage` = `(((Lv + (Lv << 2)) << 1) + 100)` → Lv1..10: [110, 120, 130, 140, 150, 160, 170, 180, 190, 200] — when (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 AND hasBuff(105) OR (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) le 0 AND hasBuff(105) OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 AND hasBuff(105)
- set `SkillIndividualFlag` = `int((MathUtil.DisplayMeterToDistance(rad) * 10))` — when (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 AND hasBuff(105) OR (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) le 0 AND hasBuff(105) OR !hasBuff(105) AND (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus())` — when (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 AND hasBuff(105) OR (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) le 0 AND hasBuff(105) OR !hasBuff(105) AND (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0
- set `isEnchantStartMotion` = `0` = 0 — when (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) le 0 AND hasBuff(105) OR !hasBuff(105) AND (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) le 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) le 0 AND hasBuff(105)
- set `skillRate` = `(((Lv * 25) + 250) + 250)` → Lv1..10: [525, 550, 575, 600, 625, 650, 675, 700, 725, 750] — when !hasBuff(105) AND (ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 105) & 256) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR !hasBuff(105) AND (ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 105) & 256) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) le 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `fixAddDamage` = `((Lv * 10) + 100)` → Lv1..10: [110, 120, 130, 140, 150, 160, 170, 180, 190, 200] — when !hasBuff(105) AND (mainWeapon==Rod & 1) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) eq 0 OR !hasBuff(105) AND (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 OR !hasBuff(105) AND (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) le 0
- set `abnormalRate` = `(((Lv + (Lv << 2)) + 15) + 35)` → Lv1..10: [55, 60, 65, 70, 75, 80, 85, 90, 95, 100] — when !hasBuff(105) AND (ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 105) & 256) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR !hasBuff(105) AND (ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 105) & 256) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) le 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR !hasBuff(105) AND (ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 105) & 256) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `SkillIndividualFlag` = `int((MathUtil.DisplayMeterToDistance((rad + 1)) * 10))` — when !hasBuff(105) AND (ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 105) & 256) ne 0 AND (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR !hasBuff(105) AND (ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 105) & 256) ne 0 AND (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) le 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR !hasBuff(105) AND (ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 105) & 256) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `skillRate` = `((Lv * 25) + 250)` → Lv1..10: [275, 300, 325, 350, 375, 400, 425, 450, 475, 500] — when !hasBuff(105) AND (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) eq 0 OR !hasBuff(105) AND (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 OR !hasBuff(105) AND (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) le 0
- set `abnormalRate` = `((Lv + (Lv << 2)) + 15)` → Lv1..10: [20, 25, 30, 35, 40, 45, 50, 55, 60, 65] — when !hasBuff(105) AND (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) eq 0 OR !hasBuff(105) AND (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 OR !hasBuff(105) AND (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) le 0
- set `skillRate` = `(Lv * 25)` → Lv1..10: [25, 50, 75, 100, 125, 150, 175, 200, 225, 250] — when !hasBuff(105) AND (mainWeapon==Rod & 1) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) eq 0 OR !hasBuff(105) AND (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 OR !hasBuff(105) AND (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) le 0
- set `abnormalRate` = `(((Lv + (Lv << 2)) + 40) + 35)` → Lv1..10: [80, 85, 90, 95, 100, 105, 110, 115, 120, 125] — when !hasBuff(105) AND (ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 105) & 256) ne 0 AND (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR !hasBuff(105) AND (ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 105) & 256) ne 0 AND (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) le 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `abnormalRate` = `((Lv + (Lv << 2)) + 40)` → Lv1..10: [45, 50, 55, 60, 65, 70, 75, 80, 85, 90] — when !hasBuff(105) AND (mainWeapon==Rod & 1) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) eq 0 OR !hasBuff(105) AND (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) gt 0 OR !hasBuff(105) AND (mainWeapon==Rod & 1) ne 0 AND PlayerAttackBase.CalcCastTime(this, (3 - int(((Lv * 0.25) + 0.5))), PlayerActionManagerBase.get_PlayerStatus()) le 0

**`WriteIndividualFlag`** (1 path)

- set `SkillIndividualFlag` = `int((rad * 10))`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`

**`OtherPlayerAttackStartReceive`** (2 paths)

- set `CastTime` = `0` = 0 — when PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)

**`calcPlayerToMobDamage`** (8 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(2, abnormalRate, playerAction)`
- calls `AbnormalStateManager.GetDefaultAnbormalStateTime` = `GetDefaultAnbormalStateTime()` — when PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalRate, playerAction)
- info `templates` = `1`

**`ActionStart`** (6 paths)

- set `attackPosition` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x`
- set `attackPosition.y` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y`
- set `attackPosition.z` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z`
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(105, Lv, 0)` — when (SkillParam & 16) eq 0 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND (SkillParam & 16) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)

**`ActionSkillEvent`** (3 paths)

- set `attackPosition` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x` — when param eq 0
- set `attackPosition.y` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y` — when param eq 0
- set `attackPosition.z` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z` — when param eq 0

**`UseChronosShift`** (1 path)

- set `SkillParam` = `(SkillParam | 0x2000)`
- set `lastUsedSkill` = `lastUsedSkill`

**`InitializeEnchantedSpell`** (5 paths)

- set `CastTime` = `-1` = -1 — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND isUseMagicImpact ne 0 OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND isUseMagicImpact eq 0 OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND isUseMagicImpact ne 0
- set `skillRate` = `((Lv + (Lv << 2)) << 1)` → Lv1..10: [10, 20, 30, 40, 50, 60, 70, 80, 90, 100] — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND isUseMagicImpact ne 0 OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND isUseMagicImpact ne 0
- set `fixAddDamage` = `(((Lv + (Lv << 2)) << 1) + 100)` → Lv1..10: [110, 120, 130, 140, 150, 160, 170, 180, 190, 200] — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND isUseMagicImpact ne 0 OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND isUseMagicImpact ne 0
- set `abnormalRate` = `Lv` → Lv1..10: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND isUseMagicImpact ne 0 OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND isUseMagicImpact ne 0
- set `SkillIndividualFlag` = `int((rad * 10))`
- set `skillRate` = `((Lv * 25) + 250)` → Lv1..10: [275, 300, 325, 350, 375, 400, 425, 450, 475, 500] — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND isUseMagicImpact eq 0
- set `fixAddDamage` = `((Lv * 10) + 100)` → Lv1..10: [110, 120, 130, 140, 150, 160, 170, 180, 190, 200] — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND isUseMagicImpact eq 0 OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND isUseMagicImpact eq 0
- set `abnormalRate` = `((Lv + (Lv << 2)) + 15)` → Lv1..10: [20, 25, 30, 35, 40, 45, 50, 55, 60, 65] — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND isUseMagicImpact eq 0 OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND isUseMagicImpact eq 0
- set `skillRate` = `(Lv * 25)` → Lv1..10: [25, 50, 75, 100, 125, 150, 175, 200, 225, 250] — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND isUseMagicImpact eq 0

</details>

**Buffs**

**Buff `MagicImpactBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_IsMotionSpeedUp`, `get_IsMpHalving`, `set_IsMotionSpeedUp`, `set_IsMpHalving`
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `IsMpHalving` = `256` = 256 when (isEnchantSpell & 1) eq 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 105) AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
  - `IsMpHalving` = `1` = 1
- Hook `set_IsMpHalving`: `IsMpHalving`=(value & 1)
- Hook `set_IsMotionSpeedUp`: `IsMotionSpeedUp`=(value & 1)

<details><summary>Effect applied in `MagicImpactAction$$OnInitialize` (27 guarded paths)</summary>

- always
  - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add([[0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)+0x20]+0x50], 6, int((MathUtil.DistanceToDisplayMeter(0, ?x1, ?x2, ?x3) * 33.3333)), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
  - set `isGemCart` = `(GemCartBufferManager.ContainsBuffer(?blr, 403, 0, ?x3) & 1)`
  - set `Element` = `7`
  - set `WeaponType` = `15`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `isUseMagicImpact` = `1`
  - set `abnormalRate` = `Lv`
  - set `skillRate` = `((Lv + (Lv << 2)) << 1)`
  - set `fixAddDamage` = `(((Lv + (Lv << 2)) << 1) + 100)`
  - set `SkillIndividualFlag` = `int((MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3) * 10))`
  - set `rad` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `CastTime` = `PlayerAttackBase.CalcCastTime(this, ?blr, 0, ?x3)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - calls `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcCastTime`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`, `0x165db78`
- always
  - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add([[0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)+0x20]+0x50], 6, int((MathUtil.DistanceToDisplayMeter(0, ?x1, ?x2, ?x3) * 33.3333)), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
  - set `isGemCart` = `(GemCartBufferManager.ContainsBuffer(?blr, 403, 0, ?x3) & 1)`
  - set `Element` = `7`
  - set `WeaponType` = `15`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `isUseMagicImpact` = `1`
  - set `abnormalRate` = `Lv`
  - set `skillRate` = `((Lv + (Lv << 2)) << 1)`
  - set `fixAddDamage` = `(((Lv + (Lv << 2)) << 1) + 100)`
  - set `SkillIndividualFlag` = `int((MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3) * 10))`
  - set `rad` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `CastTime` = `PlayerAttackBase.CalcCastTime(this, ?blr, 0, ?x3)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - calls `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcCastTime`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`, `0x165db78`
- when `TryGetExSkillData<object>.out2() ne 0`
  - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add([[0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)+0x20]+0x50], 6, int((MathUtil.DistanceToDisplayMeter(0, ?x1, ?x2, ?x3) * 33.3333)), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
  - set `isGemCart` = `(GemCartBufferManager.ContainsBuffer(?blr, 403, 0, ?x3) & 1)`
  - set `Element` = `7`
  - set `WeaponType` = `15`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `skillRate` = `(((Lv * 25) + 250) + 250)`
  - set `fixAddDamage` = `((Lv * 10) + 100)`
  - set `abnormalRate` = `(((Lv + (Lv << 2)) + 15) + 35)`
  - set `rad` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `CastTime` = `PlayerAttackBase.CalcCastTime(this, ?blr, 0, ?x3)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `SkillIndividualFlag` = `int((MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3) * 10))`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `MathUtil$$DisplayMeterToDistance`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillSpellTuning$$GetEnabledConfig`, `MathUtil$$DisplayMeterToDistance`
- when `TryGetExSkillData<object>.out2() ne 0`
  - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add([[0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)+0x20]+0x50], 6, int((MathUtil.DistanceToDisplayMeter(0, ?x1, ?x2, ?x3) * 33.3333)), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
  - set `isGemCart` = `(GemCartBufferManager.ContainsBuffer(?blr, 403, 0, ?x3) & 1)`
  - set `Element` = `7`
  - set `WeaponType` = `15`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `skillRate` = `(((Lv * 25) + 250) + 250)`
  - set `fixAddDamage` = `((Lv * 10) + 100)`
  - set `abnormalRate` = `(((Lv + (Lv << 2)) + 15) + 35)`
  - set `rad` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `CastTime` = `PlayerAttackBase.CalcCastTime(this, ?blr, 0, ?x3)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `SkillIndividualFlag` = `int((MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3) * 10))`
  - set `isEnchantStartMotion` = `0`
  - calls `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `MathUtil$$DisplayMeterToDistance`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillSpellTuning$$GetEnabledConfig`, `MathUtil$$DisplayMeterToDistance`
- when `TryGetExSkillData<object>.out2() ne 0`
  - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add([[0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)+0x20]+0x50], 6, int((MathUtil.DistanceToDisplayMeter(0, ?x1, ?x2, ?x3) * 33.3333)), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
  - set `isGemCart` = `(GemCartBufferManager.ContainsBuffer(?blr, 403, 0, ?x3) & 1)`
  - set `Element` = `7`
  - set `WeaponType` = `15`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `skillRate` = `((Lv * 25) + 250)`
  - set `fixAddDamage` = `((Lv * 10) + 100)`
  - set `abnormalRate` = `((Lv + (Lv << 2)) + 15)`
  - set `rad` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `CastTime` = `PlayerAttackBase.CalcCastTime(this, ?blr, 0, ?x3)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `SkillIndividualFlag` = `int((MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3) * 10))`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `MathUtil$$DisplayMeterToDistance`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillSpellTuning$$GetEnabledConfig`, `MathUtil$$DisplayMeterToDistance`
- when `TryGetExSkillData<object>.out2() ne 0`
  - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add([[0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)+0x20]+0x50], 6, int((MathUtil.DistanceToDisplayMeter(0, ?x1, ?x2, ?x3) * 33.3333)), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
  - set `isGemCart` = `(GemCartBufferManager.ContainsBuffer(?blr, 403, 0, ?x3) & 1)`
  - set `Element` = `7`
  - set `WeaponType` = `15`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `skillRate` = `((Lv * 25) + 250)`
  - set `fixAddDamage` = `((Lv * 10) + 100)`
  - set `abnormalRate` = `((Lv + (Lv << 2)) + 15)`
  - set `rad` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `CastTime` = `PlayerAttackBase.CalcCastTime(this, ?blr, 0, ?x3)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `SkillIndividualFlag` = `int((MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3) * 10))`
  - set `isEnchantStartMotion` = `0`
  - calls `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `MathUtil$$DisplayMeterToDistance`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillSpellTuning$$GetEnabledConfig`, `MathUtil$$DisplayMeterToDistance`
- when `TryGetExSkillData<object>.out2() eq 0`
  - set `isGemCart` = `(GemCartBufferManager.ContainsBuffer(?blr, 403, 0, ?x3) & 1)`
  - set `Element` = `7`
  - set `WeaponType` = `15`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `skillRate` = `((Lv * 25) + 250)`
  - set `fixAddDamage` = `((Lv * 10) + 100)`
  - set `abnormalRate` = `((Lv + (Lv << 2)) + 15)`
  - calls `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `MathUtil$$DisplayMeterToDistance`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `0x165db84`
- always
  - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add([[0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)+0x20]+0x50], 6, int((MathUtil.DistanceToDisplayMeter(0, ?x1, ?x2, ?x3) * 33.3333)), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
  - set `isGemCart` = `(GemCartBufferManager.ContainsBuffer(?blr, 403, 0, ?x3) & 1)`
  - set `Element` = `7`
  - set `WeaponType` = `15`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `skillRate` = `((Lv * 25) + 250)`
  - set `fixAddDamage` = `((Lv * 10) + 100)`
  - set `abnormalRate` = `((Lv + (Lv << 2)) + 15)`
  - set `rad` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `CastTime` = `PlayerAttackBase.CalcCastTime(this, ?blr, 0, ?x3)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `SkillIndividualFlag` = `int((MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3) * 10))`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `MathUtil$$DisplayMeterToDistance`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcCastTime`

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

- `MagicImpactAction$$OnInitialize (ContainsBuffer)`
- `PlayerAttackBase$$RemoveAfterSkillBuf (ContainsBuffer)`

---

### เวทมนตร์:สตรอม / ไฟเออร์สตรอม / โฟรเซนไซโคลน / ธันเดอร์สตรอม / แซนด์สตรอม / ลักซ์วอร์เทคซ์ / อีวิวเทมเพสต์ (MagicStorm) · uid 106

<img src="../../icons/sk_106.png" width="40" alt="icon"> 
**Tree:** マジックスキル (`MagicSkill`, tier 3) · **Type:** Object · **Max Lv:** 70 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** [N]เวทมนตร์:บลาส[F]เอ็กซ์โพลชั่น [A]แอบโซลูทซีโร่[W]แอร์โรว์บลาส[E]จีโออิมแพ็ค[L]ไชน์นิ่งบลาส[D]อีวิลบลาส[N] · **Flags:** MercenaryCanUseSkill · **Client class:** `MagicStormAction`

> เวทมนตร์สร้างพายุหมุน
> สร้างความเสียหายด้วยการดูดศัตรูเข้าไป
> ศัตรูที่มีความแข็งแกร่งอาจไม่ถูกดูด

<details><summary>In-game level notes</summary>

- Lv14: *พลัง+100
- Lv15: *ระยะโจมตี (รัศมี)+2m

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [(mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND spellTuningStorm ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND spellTuningStorm ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 106) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0] | 3.14 | 3.18 | 3.22 | 3.26 | 3.3 | 3.34 | 3.38 | 3.42 | 3.46 | 3.5 |
| SkillRate × [(isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0] | 1.32 | 1.34 | 1.36 | 1.38 | 1.4 | 1.42 | 1.44 | 1.46 | 1.48 | 1.5 |
| SkillRate × [(mainWeapon==Rod & 1) ne 0 AND spellTuningStorm ne 0 OR (mainWeapon==Rod & 1) ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 106) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0] | 4.14 | 4.18 | 4.22 | 4.26 | 4.3 | 4.34 | 4.38 | 4.42 | 4.46 | 4.5 |
| SkillRate × [(mainWeapon==Rod & 1) ne 0 AND spellTuningStorm eq 0 OR (mainWeapon==Rod & 1) ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 106) eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0] | 2.32 | 2.34 | 2.36 | 2.38 | 2.4 | 2.42 | 2.44 | 2.46 | 2.48 | 2.5 |
| Flat dmg + | 420 | 420 | 420 | 420 | 420 | 420 | 420 | 420 | 420 | 420 |

**Role:** attack (deals damage) · placed object / trap / summon

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(420)`
- `SkillRate` multiplies by (adds into): `((((((Lv + Lv) + 180) + ((Lv + Lv) + 180)) + -50)) / 100)`
- `ExpRate` sets: `(target.ExpDefMagic / 100)` | `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**Mechanics recovered from code**

- **Number of damage events** (`damageCount`): `(gemCart(308[2]) + int((floor((Lv * 0.5)) + 1)))` _(when (mainWeapon==Rod & 1) ne 0 AND spellTuningStorm ne 0 OR (mainWeapon==Rod & 1) ne 0 AND spellTuningStorm eq 0 OR (mainWeapon==Rod & 1) ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 106) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0)_; `motionSpeed`
- **Loop / hit-repeat count** (`LoopParam`): `(gemCart(308[2]) + int((floor((Lv * 0.5)) + 1)))` _(when (mainWeapon==Rod & 1) ne 0 AND spellTuningStorm ne 0 OR (mainWeapon==Rod & 1) ne 0 AND spellTuningStorm eq 0 OR (mainWeapon==Rod & 1) ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 106) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0)_; `motionSpeed`
- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())` _(when (mainWeapon==Rod & 1) ne 0 AND spellTuningStorm ne 0 OR (mainWeapon==Rod & 1) ne 0 AND spellTuningStorm eq 0 OR (mainWeapon==Rod & 1) ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 106) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0)_; `0` = 0 _(when PlayerAttackBase.CheckSkillParamFlag(this, 0x2000))_; `-1` = -1 _(when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0)_
- **Hit count** (`hitCount`): `LoopParam` _(when (skillEventId & 0xffff) eq 1)_; `(hitCount + 1)`

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 106

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (13 paths)

- set `spellTuningStorm` = `ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 106)` — when (mainWeapon==Rod & 1) ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 106) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Rod & 1) ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 106) eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 106) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(8)` — when (mainWeapon==Rod & 1) ne 0 AND spellTuningStorm ne 0 OR (mainWeapon==Rod & 1) ne 0 AND spellTuningStorm eq 0 OR (mainWeapon==Rod & 1) ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 106) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())` — when (mainWeapon==Rod & 1) ne 0 AND spellTuningStorm ne 0 OR (mainWeapon==Rod & 1) ne 0 AND spellTuningStorm eq 0 OR (mainWeapon==Rod & 1) ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 106) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `skillRate` = `((((Lv + Lv) + 180) + ((Lv + Lv) + 180)) + -50)` → Lv1..10: [314, 318, 322, 326, 330, 334, 338, 342, 346, 350] — when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND spellTuningStorm ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND spellTuningStorm ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 106) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `constantDamage` = `420` = 420 — when (mainWeapon==Rod & 1) ne 0 AND spellTuningStorm ne 0 OR (mainWeapon==Rod & 1) ne 0 AND spellTuningStorm eq 0 OR (mainWeapon==Rod & 1) ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 106) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `damageCount` = `(gemCart(308[2]) + int((floor((Lv * 0.5)) + 1)))` — when (mainWeapon==Rod & 1) ne 0 AND spellTuningStorm ne 0 OR (mainWeapon==Rod & 1) ne 0 AND spellTuningStorm eq 0 OR (mainWeapon==Rod & 1) ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 106) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `LoopParam` = `(gemCart(308[2]) + int((floor((Lv * 0.5)) + 1)))` — when (mainWeapon==Rod & 1) ne 0 AND spellTuningStorm ne 0 OR (mainWeapon==Rod & 1) ne 0 AND spellTuningStorm eq 0 OR (mainWeapon==Rod & 1) ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 106) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())` — when (mainWeapon==Rod & 1) ne 0 AND spellTuningStorm ne 0 OR (mainWeapon==Rod & 1) ne 0 AND spellTuningStorm eq 0 OR (mainWeapon==Rod & 1) ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 106) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `skillRate` = `(((Lv + Lv) + 180) + -50)` → Lv1..10: [132, 134, 136, 138, 140, 142, 144, 146, 148, 150] — when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND spellTuningStorm eq 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0 AND spellTuningStorm eq 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 106) eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `skillRate` = `(((((Lv + Lv) + 180) + ((Lv + Lv) + 180)) + 100) + -50)` → Lv1..10: [414, 418, 422, 426, 430, 434, 438, 442, 446, 450] — when (mainWeapon==Rod & 1) ne 0 AND spellTuningStorm ne 0 OR (mainWeapon==Rod & 1) ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 106) ne 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0
- set `skillRate` = `((((Lv + Lv) + 180) + 100) + -50)` → Lv1..10: [232, 234, 236, 238, 240, 242, 244, 246, 248, 250] — when (mainWeapon==Rod & 1) ne 0 AND spellTuningStorm eq 0 OR (mainWeapon==Rod & 1) ne 0 AND ExSkillSpellTuning.GetEnabledConfig(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119), 106) eq 0 AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 119) ne 0

**`WriteIndividualFlag`** (1 path)

- set `SkillIndividualFlag` = `((int((rad * 10)) << 1) | (System.Convert.ToByte((+0x155 ne 0 ? 1 : 0)) & 255))`

**`ReadIndividualParameter`** (1 path)

- set `SkillIndividualFlag` = `(SkillIndividualFlag >> 1)`

**`ActionPreparation`** (5 paths)

- set `Element` = `TryGetElemntType.elementType(PlayerActionManagerBase.get_PlayerStatus())` — when !PlayerAttackBase.CheckSkillParamFlag(this, 1024) AND UnityEngine.Object.op_Inequality(actarAction)

**`ActionStart`** (2 paths)

- set `targetTransform` = `UnityEngine.GameObject.get_transform(target)`

**`InitializeOthers`** (4 paths)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`
- set `damageCount` = `motionSpeed`
- set `LoopParam` = `motionSpeed`

**`ActionStartOthers`** (5 paths)

- set `CastTime` = `0` = 0 — when PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)

**`OtherPlayerSkillEventReceive`** (2 paths)

- set `hitCount` = `LoopParam` — when (skillEventId & 0xffff) eq 1

**`calcPlayerToMobDamage`** (20 paths)

- template `SetRate[ExpRate]` = `(target.ExpDefMagic / 100)`
- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `constantDamage`
- calls `PlayerAttackBase.SetBufferConstantDamage` = `SetBufferConstantDamage(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), damageCount)`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(28, (MobActionManagerBase.get_IsBoss(mobAction) ? 50 : 100), playerAction)` — when MobActionManagerBase.get_IsPlayerManaged(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 28, ((MobActionManagerBase.get_IsBoss(mobAction) ? 50 : 100), playerAction) & 1) ne 0 OR MobActionManagerBase.get_IsPlayerManaged(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 28, (!MobActionManagerBase.get_IsBoss(mobAction) ? 50 : 100), playerAction)
- info `templates` = `1`
- template `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**`AddHitCount`** (1 path)

- set `hitCount` = `(hitCount + 1)`

**`ActionSkillEvent`** (4 paths)

- set `targetTransform` = `0` = 0 — when UnityEngine.Object.op_Inequality(targetTransform) AND param eq 0 AND param ne 100
- set `+0x144` = `0` = 0 — when UnityEngine.Object.op_Inequality(targetTransform) AND param eq 0 AND param ne 100

**`ActionSkillReceiveEffect`** (1 path)

- set `StormObject` = `effect`

**`UseChronosShift`** (1 path)

- set `SkillParam` = `(SkillParam | 0x2000)`
- set `lastUsedSkill` = `lastUsedSkill`

**`InitializeEnchantedSpell`** (5 paths)

- set `spellTuningStorm` = `0` = 0
- set `Element` = `PlayerStatusBase.GetEquipSubWeaponElement(PlayerActionManagerBase.get_PlayerStatus())` — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `CastTime` = `-1` = -1 — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `constantDamage` = `420` = 420 — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `skillRate` = `(((Lv + Lv) + 180) + -50)` → Lv1..10: [132, 134, 136, 138, 140, 142, 144, 146, 148, 150] — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0

</details>

---

### พาวเวอร์เวฟ (PowerWave) · uid 107

<img src="../../icons/sk_107.png" width="40" alt="icon"> 
**Tree:** マジックスキル (`MagicSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 70 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เชนแคสต์ · **Client class:** `PowerWave` (passive mastery)

> ยิงคลื่นเวทมนตร์เมื่อการโจมตีปกติโจมตีไปไม่ถึง
> ใช้ได้ในระยะ 5m หรือน้อยกว่า
> จะเพิ่มขึ้นได้ถึง 10m ตามการเพิ่มของเลเวล
> การฟื้นฟู MP โจมตีจะใช้ได้กับสกิลนี้

<details><summary>In-game level notes</summary>

- Lv14: *พลัง+40 ระยะห่างที่สามารถใช้ได้+2m
- Lv15: *พลัง+70

</details>

**Role:** passive mastery

<details><summary>Effect applied in `GemCartBuffer.PowerWaveChangeBuff$$OnGetValue` (1 guarded path)</summary>

- when `id eq 3`
  - returns `(((SkillLv(107) + +0x14) lt 0 ? ((SkillLv(107) + +0x14) + 1) : (SkillLv(107) + +0x14)) >> 1)`
  - calls `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `GemCartBuffer.PowerWaveChangeBuff$$OnGetValue (GetSkillLv)`
- `UIRegistletMainManager$$GetDescriptionValueText (GetSkillLv)`

---

### เวทมนตร์:อีเกล (MagicEgel) · uid 111

<img src="../../icons/sk_111.png" width="40" alt="icon"> 
**Tree:** マジックスキル (`MagicSkill`, tier 3) · **Type:** Buffer · **Max Lv:** 70 · **Weapons:** Rod, MainMagictool · **Flags:** NoMarketSearch · **Client class:** `MagicEgelAction`

> แสงแห่งการปกปักษ์
> นอกจากตอนร่ายเวทมนตร์:อีเกล
> หรือหลังจากได้รับความเสียหายจะมีการโจมตี
> ด้วยเวทออกไปในช่วงเวลาที่เจาะจง

**Role:** buff (self) · modifies normal-attack behaviour

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 111

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (2 paths)

- calls `MagicEgelBuf..ctor` = `.ctor(Lv, actarAction)` — when UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new MagicEgelBuf, 0)` — when UnityEngine.Object.op_Inequality(actarAction)

**`UseChronosShift`** (1 path)

- set `SkillParam` = `(SkillParam | 0x2000)`
- set `lastUsedSkill` = `lastUsedSkill`

</details>

**Buffs**

**Buff `MagicEgelBuf`**
- **Modifies normal attacks**: `NormalAttackAction` looks this buff up while it builds the normal-attack damage / hit logic.
- Buff hook methods: `Active`, `Damaged`, `IsActive`, `Reset`, `get_EnableCounter`, `set_EnableCounter`
- Buff fields set in the constructor (all recovered):
  - `active` = `new System.Collections.Generic.Dictionary<int, MagicEgelBuf.TargetData>`
  - `playerAction` = `playerAction`
  - `battleManager` = `playerAction.battleManager`
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `Max` = `(((mul64(((Lv eq 1 ? 2 : (Lv + 1)) - 2), ((Lv eq 1 ? 2 : (Lv + 1)) - 3)) >> 1) + ((Lv eq 1 ? 2 : (Lv + 1)) << 1)) - 3)` when Lv ne 0
  - `Max` = `0` when Lv eq 0
- Hook `set_EnableCounter`: `EnableCounter`=(value & 1)
- Hook `Updata`: `counterInterval`=0; `counterInterval`=(counterInterval - UnityEngine.Time.get_deltaTime())
- Hook `Damaged`: `counterInterval`=1
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:MagicEgelBuf$$.ctor<-MagicEgelAction$$ActionHit` (no direct constructor call in the skill's own code).
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

### คาดาร์เอเล็คซิโอ (KadarElexio) · uid 118

<img src="../../icons/sk_118.png" width="40" alt="icon"> 
**Tree:** マジックスキル (`MagicSkill`, tier 3) · **Type:** Buffer · **Max Lv:** 70 · **Weapons:** Rod · **Requires:** เมจิคไนฟ์ · **Client class:** `KadarElexioAction`

> เทคนิคต้องห้ามที่สร้างภาระหนักหน่วงแก่จิตใจและร่างกาย
> ใช้ HP ปัจจุบันและ HP สูงสุด (ค่าสุ่ม) เพื่อลด MP ที่ใช้
> ในสกิลถัดไปลงครึ่งหนึ่งและรับประกันคริติคอล
> ถ้าใช้งานซ้ำๆ จนรับภาระหนักเกินไปก็คงจะ...

<details><summary>In-game level notes</summary>

- Lv14: ตอนได้รับภาระจากพลังเวท (HP สูงสุดลดลงจากสกิลนี้) เมื่อเวลาผ่านไปพลังของสกิลเวทจะเพิ่มขึ้นทีละเล็กน้อย เมื่อผลของคาดาร์เอเล็คซิโอ เช่น ตอนพลังชีวิตหมด หรือย้ายแผนที่ หมดลงการเพิ่มพลังจะถูกรีเซ็ต

</details>

**Role:** buff (self) · modifies normal-attack behaviour

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 118

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

</details>

**Buffs**

**Buff `CountBufferBase`**
- Attached to this skill via `caller2:KadarElexioBuf$$.ctor<-KadarElexioAction$$PlayRandomEffect` (no direct constructor call in the skill's own code).
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
**Buff `KadarElexioBuf`**
- **Modifies normal attacks**: `NormalAttackAction` looks this buff up while it builds the normal-attack damage / hit logic.
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `ActiveKadarElexio`, `CheckCritical`, `CheckEnd`, `CheckMpHalving`, `CreateFailure`, `CreateOverloadStart`, `FailureKadarElexio`, `InactiveKadarElexio`, `get_BufEffectTakeId`
- `MaxHpUpRate` = `-Count` _(when BuffEffectActive ne 0)_
- `Value2` = `overloadValue` _(when BuffEffectActive ne 0)_
- `Value` = `isStack` _(when BuffEffectActive ne 0)_
- `LastDmgUpRate` = `(Count lt overloadValue ? Count : overloadValue)` _(when BuffEffectActive ne 0; validOverloadBonus ne 0)_
- `LastDmgUpRate` = `0` _(when BuffEffectActive ne 0; validOverloadBonus eq 0)_
- Buff fields set in the constructor (all recovered):
  - `bufFlag` = `514` = 514
  - `effectiveSkillList` = `new System.Collections.Generic.List<KadarElexioBuf.SkillIdData>`
  - `effectPlayer` = `effectPlayer`
- Hook `Updata`: `LeftTime`=0; `effectiveKadarElexio`=0; `Count`=0; `isStack`=0
- Hook `ActiveKadarElexio`: `effectiveKadarElexio`=1; `isStack`=1; `LeftTime`=180; `Count`=maxHpRate
- Hook `InactiveKadarElexio`: `LeftTime`=0; `effectiveKadarElexio`=0; `Count`=0; `isStack`=0
- Hook `FailureKadarElexio`: `Count`=maxHpRate; `effectiveKadarElexio`=0; `isStack`=0

<details><summary>Effect applied in `PlayerAttackBase$$CalcCostMp` (299 guarded paths, truncated)</summary>

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

<details><summary>Effect applied in `MobaPlayerBattleManager$$OnBattleActive` (8 guarded paths)</summary>

- when `IsUnsheathe eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `GameManager.StopBattleEndCheck(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `activeWaitPutUpWeapon` = `0`
  - set `+0xe4` = `0`
  - calls `UnityEngine.MonoBehaviour$$StopCoroutine`, `0x165d8dc`, `MobaPlayerBattleManager$$waitUnsheatheWeapon`, `UnityEngine.MonoBehaviour$$StartCoroutine`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `KadarElexioBuf$$BattleActive`, `Singleton<object>$$get_Instance`, `GameManager$$StopBattleEndCheck`
- when `IsUnsheathe eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - set `activeWaitPutUpWeapon` = `0`
  - set `+0xe4` = `0`
  - calls `UnityEngine.MonoBehaviour$$StopCoroutine`, `0x165d8dc`, `MobaPlayerBattleManager$$waitUnsheatheWeapon`, `UnityEngine.MonoBehaviour$$StartCoroutine`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `0x165db84`, `0x165df00`
- when `IsUnsheathe eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-24), 0) & 1) ne 0`
  - returns `GameManager.StopBattleEndCheck(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `activeWaitPutUpWeapon` = `0`
  - set `+0xe4` = `0`
  - calls `UnityEngine.MonoBehaviour$$StopCoroutine`, `0x165d8dc`, `MobaPlayerBattleManager$$waitUnsheatheWeapon`, `UnityEngine.MonoBehaviour$$StartCoroutine`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `Singleton<object>$$get_Instance`, `GameManager$$StopBattleEndCheck`
- when `IsUnsheathe eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-24), 0) & 1) eq 0`
  - returns `GameManager.StopBattleEndCheck(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `activeWaitPutUpWeapon` = `0`
  - set `+0xe4` = `0`
  - calls `UnityEngine.MonoBehaviour$$StopCoroutine`, `0x165d8dc`, `MobaPlayerBattleManager$$waitUnsheatheWeapon`, `UnityEngine.MonoBehaviour$$StartCoroutine`, `Singleton<object>$$get_Instance`, `GameManager$$StopBattleEndCheck`
- when `IsUnsheathe ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `GameManager.StopBattleEndCheck(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `activeWaitPutUpWeapon` = `0`
  - set `+0xe4` = `0`
  - calls `UnityEngine.MonoBehaviour$$StopCoroutine`, `0x165d8dc`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `KadarElexioBuf$$BattleActive`, `Singleton<object>$$get_Instance`, `GameManager$$StopBattleEndCheck`
- when `IsUnsheathe ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - set `activeWaitPutUpWeapon` = `0`
  - set `+0xe4` = `0`
  - calls `UnityEngine.MonoBehaviour$$StopCoroutine`, `0x165d8dc`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `0x165db84`, `0x165df00`
- when `IsUnsheathe ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-24), 0) & 1) ne 0`
  - returns `GameManager.StopBattleEndCheck(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `activeWaitPutUpWeapon` = `0`
  - set `+0xe4` = `0`
  - calls `UnityEngine.MonoBehaviour$$StopCoroutine`, `0x165d8dc`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `Singleton<object>$$get_Instance`, `GameManager$$StopBattleEndCheck`
- when `IsUnsheathe ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-24), 0) & 1) eq 0`
  - returns `GameManager.StopBattleEndCheck(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `activeWaitPutUpWeapon` = `0`
  - set `+0xe4` = `0`
  - calls `UnityEngine.MonoBehaviour$$StopCoroutine`, `0x165d8dc`, `Singleton<object>$$get_Instance`, `GameManager$$StopBattleEndCheck`

</details>

<details><summary>Effect applied in `MobaPlayerBattleManager$$OnBattleEnd` (22 guarded paths)</summary>

- when `attackDelay gt 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `IsUnsheathe ne 0`
  - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
  - set `IsDelay` = `1`
  - set `IsAssistMove` = `0`
  - set `IsUnsheathe` = `0`
  - calls `KadarElexioBuf$$BattleEnd`, `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`, `UIFadeManager$$FadeOutBattleEnd`
- when `attackDelay gt 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `IsUnsheathe ne 0`
  - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
  - set `IsDelay` = `1`
  - set `IsAssistMove` = `0`
  - calls `KadarElexioBuf$$BattleEnd`, `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`, `UIFadeManager$$FadeOutBattleEnd`
- when `attackDelay gt 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `IsUnsheathe eq 0`
  - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
  - set `IsDelay` = `1`
  - set `IsAssistMove` = `0`
  - calls `KadarElexioBuf$$BattleEnd`, `SkillFactory$$CreateSkill`, `Singleton<object>$$get_Instance`, `GameManager$$ActionCancel`, `SkillBufferManager$$RemoveSelfBuffer`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`
- when `attackDelay gt 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `IsUnsheathe eq 0`
  - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
  - set `IsDelay` = `1`
  - set `IsAssistMove` = `0`
  - calls `KadarElexioBuf$$BattleEnd`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`, `UIFadeManager$$FadeOutBattleEnd`
- when `attackDelay gt 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `IsUnsheathe eq 0`
  - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
  - set `IsDelay` = `1`
  - set `IsAssistMove` = `0`
  - calls `KadarElexioBuf$$BattleEnd`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`, `UIFadeManager$$FadeOutBattleEnd`
- when `attackDelay gt 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - set `IsDelay` = `1`
  - set `IsAssistMove` = `0`
  - calls `0x165db84`, `0x165df00`
- when `attackDelay gt 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) eq 0` AND `IsUnsheathe ne 0`
  - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
  - set `IsDelay` = `1`
  - set `IsAssistMove` = `0`
  - set `IsUnsheathe` = `0`
  - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`, `UIFadeManager$$FadeOutBattleEnd`
- when `attackDelay gt 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) eq 0` AND `IsUnsheathe ne 0`
  - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
  - set `IsDelay` = `1`
  - set `IsAssistMove` = `0`
  - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`, `UIFadeManager$$FadeOutBattleEnd`

</details>

<details><summary>Effect applied in `PlayerAttackBase.<>c__DisplayClass111_0$$<ActionPreparation>b__0` (2 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 118, (this + 32), 0) & 1) ne 0`
  - calls `virtual CharacterActionManagerBase.get_IsLocalDead`, `KadarElexioBuf$$EndNextSkill`
- when `(SkillBufferManager.TryGetBuf(?blr, 118, (this + 32), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 118, (this + 32), 0)`

</details>

<details><summary>Effect applied in `PlayerBattleManager$$OnBattleActive` (8 guarded paths)</summary>

- when `IsUnsheathe eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `GameManager.StopBattleEndCheck(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `activeWaitPutUpWeapon` = `0`
  - set `+0x104` = `0`
  - calls `UnityEngine.MonoBehaviour$$StopCoroutine`, `0x165d8dc`, `PlayerBattleManager$$waitUnsheatheWeapon`, `UnityEngine.MonoBehaviour$$StartCoroutine`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `KadarElexioBuf$$BattleActive`, `Singleton<object>$$get_Instance`, `GameManager$$StopBattleEndCheck`
- when `IsUnsheathe eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - set `activeWaitPutUpWeapon` = `0`
  - set `+0x104` = `0`
  - calls `UnityEngine.MonoBehaviour$$StopCoroutine`, `0x165d8dc`, `PlayerBattleManager$$waitUnsheatheWeapon`, `UnityEngine.MonoBehaviour$$StartCoroutine`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `0x165db84`, `0x165df00`
- when `IsUnsheathe eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-24), 0) & 1) ne 0`
  - returns `GameManager.StopBattleEndCheck(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `activeWaitPutUpWeapon` = `0`
  - set `+0x104` = `0`
  - calls `UnityEngine.MonoBehaviour$$StopCoroutine`, `0x165d8dc`, `PlayerBattleManager$$waitUnsheatheWeapon`, `UnityEngine.MonoBehaviour$$StartCoroutine`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `Singleton<object>$$get_Instance`, `GameManager$$StopBattleEndCheck`
- when `IsUnsheathe eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-24), 0) & 1) eq 0`
  - returns `GameManager.StopBattleEndCheck(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `activeWaitPutUpWeapon` = `0`
  - set `+0x104` = `0`
  - calls `UnityEngine.MonoBehaviour$$StopCoroutine`, `0x165d8dc`, `PlayerBattleManager$$waitUnsheatheWeapon`, `UnityEngine.MonoBehaviour$$StartCoroutine`, `Singleton<object>$$get_Instance`, `GameManager$$StopBattleEndCheck`
- when `IsUnsheathe ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `GameManager.StopBattleEndCheck(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `activeWaitPutUpWeapon` = `0`
  - set `+0x104` = `0`
  - calls `UnityEngine.MonoBehaviour$$StopCoroutine`, `0x165d8dc`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `KadarElexioBuf$$BattleActive`, `Singleton<object>$$get_Instance`, `GameManager$$StopBattleEndCheck`
- when `IsUnsheathe ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - set `activeWaitPutUpWeapon` = `0`
  - set `+0x104` = `0`
  - calls `UnityEngine.MonoBehaviour$$StopCoroutine`, `0x165d8dc`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `0x165db84`, `0x165df00`
- when `IsUnsheathe ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-24), 0) & 1) ne 0`
  - returns `GameManager.StopBattleEndCheck(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `activeWaitPutUpWeapon` = `0`
  - set `+0x104` = `0`
  - calls `UnityEngine.MonoBehaviour$$StopCoroutine`, `0x165d8dc`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `Singleton<object>$$get_Instance`, `GameManager$$StopBattleEndCheck`
- when `IsUnsheathe ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-24), 0) & 1) eq 0`
  - returns `GameManager.StopBattleEndCheck(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `activeWaitPutUpWeapon` = `0`
  - set `+0x104` = `0`
  - calls `UnityEngine.MonoBehaviour$$StopCoroutine`, `0x165d8dc`, `Singleton<object>$$get_Instance`, `GameManager$$StopBattleEndCheck`

</details>

<details><summary>Effect applied in `PlayerBattleManager$$OnBattleEnd` (22 guarded paths)</summary>

- when `attackDelay gt 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `IsUnsheathe ne 0`
  - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
  - set `IsDelay` = `1`
  - set `IsAssistMove` = `0`
  - set `IsUnsheathe` = `0`
  - calls `KadarElexioBuf$$BattleEnd`, `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`, `UIFadeManager$$FadeOutBattleEnd`
- when `attackDelay gt 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `IsUnsheathe ne 0`
  - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
  - set `IsDelay` = `1`
  - set `IsAssistMove` = `0`
  - calls `KadarElexioBuf$$BattleEnd`, `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`, `UIFadeManager$$FadeOutBattleEnd`
- when `attackDelay gt 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `IsUnsheathe eq 0`
  - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
  - set `IsDelay` = `1`
  - set `IsAssistMove` = `0`
  - calls `KadarElexioBuf$$BattleEnd`, `SkillFactory$$CreateSkill`, `Singleton<object>$$get_Instance`, `GameManager$$ActionCancel`, `SkillBufferManager$$RemoveSelfBuffer`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`
- when `attackDelay gt 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `IsUnsheathe eq 0`
  - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
  - set `IsDelay` = `1`
  - set `IsAssistMove` = `0`
  - calls `KadarElexioBuf$$BattleEnd`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`, `UIFadeManager$$FadeOutBattleEnd`
- when `attackDelay gt 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `IsUnsheathe eq 0`
  - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
  - set `IsDelay` = `1`
  - set `IsAssistMove` = `0`
  - calls `KadarElexioBuf$$BattleEnd`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`, `UIFadeManager$$FadeOutBattleEnd`
- when `attackDelay gt 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - set `IsDelay` = `1`
  - set `IsAssistMove` = `0`
  - calls `0x165db84`, `0x165df00`
- when `attackDelay gt 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) eq 0` AND `IsUnsheathe ne 0`
  - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
  - set `IsDelay` = `1`
  - set `IsAssistMove` = `0`
  - set `IsUnsheathe` = `0`
  - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`, `UIFadeManager$$FadeOutBattleEnd`
- when `attackDelay gt 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) eq 0` AND `IsUnsheathe ne 0`
  - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
  - set `IsDelay` = `1`
  - set `IsAssistMove` = `0`
  - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`, `UIFadeManager$$FadeOutBattleEnd`

</details>

<details><summary>Effect applied in `PlayerAttackBase$$ActionPreparation` (192 guarded paths, truncated)</summary>

- when `(SkillActionBase.checkPercent(this, 100, 30, 0) & 1) ne 0` AND `SkillLv(520) ge 1` AND `(((SkillParam | 16) | 512) & 16) eq 0` AND `PlayerAttackBase.get_ActionID() ne 0`
  - returns `HeavenlyStarBuf.SetAttackSkillId(TryGetBuf<object>.out2(), PlayerAttackBase.get_ActionID(), 0, ?x3)`
  - set `SkillParam` = `((SkillParam | 16) | 512)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `AbnormalStateManager$$Contains`, `SkillActionBase$$checkPercent`, `IchijhinnokazeAction$$UpdateFirstAttackParam`, `TargetableListManagerBase<object>$$get_Instance`
- when `(SkillActionBase.checkPercent(this, 100, 30, 0) & 1) ne 0` AND `SkillLv(520) ge 1` AND `(((SkillParam | 16) | 512) & 16) eq 0` AND `PlayerAttackBase.get_ActionID() ne 0`
  - set `SkillParam` = `((SkillParam | 16) | 512)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `AbnormalStateManager$$Contains`, `SkillActionBase$$checkPercent`, `IchijhinnokazeAction$$UpdateFirstAttackParam`, `TargetableListManagerBase<object>$$get_Instance`
- when `(SkillActionBase.checkPercent(this, 100, 30, 0) & 1) ne 0` AND `SkillLv(520) ge 1` AND `(((SkillParam | 16) | 512) & 16) eq 0` AND `PlayerAttackBase.get_ActionID() ne 0`
  - returns `SkillUtil.IsPursuitSkill(PlayerAttackBase.get_ActionID(), 0, ?x2, ?x3)`
  - set `SkillParam` = `((SkillParam | 16) | 512)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `AbnormalStateManager$$Contains`, `SkillActionBase$$checkPercent`, `IchijhinnokazeAction$$UpdateFirstAttackParam`, `TargetableListManagerBase<object>$$get_Instance`
- when `(SkillActionBase.checkPercent(this, 100, 30, 0) & 1) ne 0` AND `SkillLv(520) ge 1` AND `(((SkillParam | 16) | 512) & 16) eq 0` AND `PlayerAttackBase.get_ActionID() ne 0`
  - returns `SkillBufferManager.TryGetBuf<object>(?blr, 620, stkp(-56), meta(0x399f910, Method$SkillBufferManager.TryGetBuf<HeavenlyStarBuf>()))`
  - set `SkillParam` = `((SkillParam | 16) | 512)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `AbnormalStateManager$$Contains`, `SkillActionBase$$checkPercent`, `IchijhinnokazeAction$$UpdateFirstAttackParam`, `TargetableListManagerBase<object>$$get_Instance`
- when `(SkillActionBase.checkPercent(this, 100, 30, 0) & 1) ne 0` AND `SkillLv(520) ge 1` AND `(((SkillParam | 16) | 512) & 16) eq 0` AND `PlayerAttackBase.get_ActionID() ne 0`
  - returns `HeavenlyStarBuf.SetAttackSkillId(TryGetBuf<object>.out2(), PlayerAttackBase.get_ActionID(), 0, ?x3)`
  - set `SkillParam` = `((SkillParam | 16) | 512)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `AbnormalStateManager$$Contains`, `SkillActionBase$$checkPercent`, `IchijhinnokazeAction$$UpdateFirstAttackParam`, `TargetableListManagerBase<object>$$get_Instance`
- when `(SkillActionBase.checkPercent(this, 100, 30, 0) & 1) ne 0` AND `SkillLv(520) ge 1` AND `(((SkillParam | 16) | 512) & 16) eq 0` AND `PlayerAttackBase.get_ActionID() ne 0`
  - set `SkillParam` = `((SkillParam | 16) | 512)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `AbnormalStateManager$$Contains`, `SkillActionBase$$checkPercent`, `IchijhinnokazeAction$$UpdateFirstAttackParam`, `TargetableListManagerBase<object>$$get_Instance`
- when `(SkillActionBase.checkPercent(this, 100, 30, 0) & 1) ne 0` AND `SkillLv(520) ge 1` AND `(((SkillParam | 16) | 512) & 16) eq 0` AND `PlayerAttackBase.get_ActionID() ne 0`
  - returns `SkillUtil.IsPursuitSkill(PlayerAttackBase.get_ActionID(), 0, ?x2, ?x3)`
  - set `SkillParam` = `((SkillParam | 16) | 512)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `AbnormalStateManager$$Contains`, `SkillActionBase$$checkPercent`, `IchijhinnokazeAction$$UpdateFirstAttackParam`, `TargetableListManagerBase<object>$$get_Instance`
- when `(SkillActionBase.checkPercent(this, 100, 30, 0) & 1) ne 0` AND `SkillLv(520) ge 1` AND `(((SkillParam | 16) | 512) & 16) eq 0` AND `PlayerAttackBase.get_ActionID() ne 0`
  - returns `SkillBufferManager.TryGetBuf<object>(?blr, 620, stkp(-56), meta(0x399f910, Method$SkillBufferManager.TryGetBuf<HeavenlyStarBuf>()))`
  - set `SkillParam` = `((SkillParam | 16) | 512)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `AbnormalStateManager$$Contains`, `SkillActionBase$$checkPercent`, `IchijhinnokazeAction$$UpdateFirstAttackParam`, `TargetableListManagerBase<object>$$get_Instance`

</details>

<details><summary>Effect applied in `ReceiveSupportResult$$OnEventPlayerSupport` (40 guarded paths, truncated)</summary>

- when `(skillId & 0xffff) le 993` AND `(skillId & 0xffff) ne 231` AND `(skillId & 0xffff) ne 265` AND `(skillId & 0xffff) le 708`
  - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillLv, targetArchetypeType, targetArchetypeId), 0, ?x2, ?x3), 0)`
  - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `AbnormalStateManager$$RemoveAbnormalState`, `SkillUtil$$CheckDanceSkill`, `PlayerDataManager$$get_PlayerStatus`
- when `(skillId & 0xffff) le 993` AND `(skillId & 0xffff) ne 231` AND `(skillId & 0xffff) ne 265` AND `(skillId & 0xffff) le 708`
  - returns `SacredTeachings.ReceiveOtherHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillLv, targetArchetypeType, targetArchetypeId), 0, ?x2, ?x3), 0)`
  - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `AbnormalStateManager$$RemoveAbnormalState`, `SkillUtil$$CheckDanceSkill`, `PlayerDataManager$$get_PlayerStatus`
- when `(skillId & 0xffff) le 993` AND `(skillId & 0xffff) ne 231` AND `(skillId & 0xffff) ne 265` AND `(skillId & 0xffff) le 708`
  - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillLv, targetArchetypeType, targetArchetypeId), 0, ?x2, ?x3), 0)`
  - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `AbnormalStateManager$$RemoveAbnormalState`, `SkillUtil$$CheckDanceSkill`, `PlayerDataManager$$get_PlayerStatus`
- when `(skillId & 0xffff) le 993` AND `(skillId & 0xffff) ne 231` AND `(skillId & 0xffff) ne 265` AND `(skillId & 0xffff) le 708`
  - returns `SacredTeachings.ReceiveOtherHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillLv, targetArchetypeType, targetArchetypeId), 0, ?x2, ?x3), 0)`
  - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `AbnormalStateManager$$RemoveAbnormalState`, `SkillUtil$$CheckDanceSkill`, `PlayerDataManager$$get_PlayerStatus`
- when `(skillId & 0xffff) le 993` AND `(skillId & 0xffff) ne 231` AND `(skillId & 0xffff) ne 265` AND `(skillId & 0xffff) le 708`
  - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillLv, targetArchetypeType, targetArchetypeId), 0, ?x2, ?x3), 0)`
  - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `AbnormalStateManager$$RemoveAbnormalState`, `SkillUtil$$CheckDanceSkill`, `PlayerDataManager$$get_PlayerStatus`
- when `(skillId & 0xffff) le 993` AND `(skillId & 0xffff) ne 231` AND `(skillId & 0xffff) ne 265` AND `(skillId & 0xffff) le 708`
  - returns `SacredTeachings.ReceiveOtherHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillLv, targetArchetypeType, targetArchetypeId), 0, ?x2, ?x3), 0)`
  - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `AbnormalStateManager$$RemoveAbnormalState`, `SkillUtil$$CheckDanceSkill`, `PlayerDataManager$$get_PlayerStatus`
- when `(skillId & 0xffff) le 993` AND `(skillId & 0xffff) ne 231` AND `(skillId & 0xffff) ne 265` AND `(skillId & 0xffff) le 708`
  - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillLv, targetArchetypeType, targetArchetypeId), 0, ?x2, ?x3), 0)`
  - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `AbnormalStateManager$$RemoveAbnormalState`, `SkillUtil$$CheckDanceSkill`, `PlayerDataManager$$get_PlayerStatus`
- when `(skillId & 0xffff) le 993` AND `(skillId & 0xffff) ne 231` AND `(skillId & 0xffff) ne 265` AND `(skillId & 0xffff) le 708`
  - returns `SacredTeachings.ReceiveOtherHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillLv, targetArchetypeType, targetArchetypeId), 0, ?x2, ?x3), 0)`
  - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `AbnormalStateManager$$RemoveAbnormalState`, `SkillUtil$$CheckDanceSkill`, `PlayerDataManager$$get_PlayerStatus`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `MobaPlayerBattleManager$$OnBattleActive (TryGetBuf)`
- `MobaPlayerBattleManager$$OnBattleEnd (TryGetBuf)`
- `PlayerAttackBase$$ActionPreparation (TryGetBuf)`
- `PlayerAttackBase$$CalcCostMp (TryGetBuf)`
- `PlayerAttackBase$$TemplateAssignment (TryGetBuf)`
- `PlayerAttackBase.<>c__DisplayClass111_0$$<ActionPreparation>b__0 (TryGetBuf)`
- `PlayerBattleManager$$OnBattleActive (TryGetBuf)`
- `PlayerBattleManager$$OnBattleEnd (TryGetBuf)`
- `ReceiveSupportResult$$OnEventPlayerSupport (GetSkillLv)`

---

### เวทมนตร์: ไฟนอล (MagicFinaw) · uid 108

<img src="../../icons/sk_108.png" width="40" alt="icon"> 
**Tree:** マジックスキル (`MagicSkill`, tier 4) · **Type:** Attack · **Max Lv:** 150 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เวทมนตร์:อิมแพ็ค · **Flags:** MercenaryCanUseSkill · **Client class:** `MagicFinawAction`

> เวทมนตร์โจมตีที่มีผลในพื้นที่กว้าง
> ศัตรูที่อยู่ใกล้จุดศูนย์กลางของระยะโจมตีจะโดนพลังโจมตีอย่างรุนแรง
> ใช้เวลาร่ายนาน ไม่สามารถลดเวลาร่ายด้วย CSPD ได้
> เฮทจะเกิดขึ้นตามปกติระหว่างร่าย

<details><summary>In-game level notes</summary>

- Lv14: *พลัง +750 *พลังเพิ่มขึ้นตามค่า INT
- Lv15: *พลังเพิ่มขึ้นตามค่า INT *4x ระยะโจมตี (รัศมี) สำหรับ HIT ที่ 1 *2x ระยะโจมตี (รัศมี) สำหรับ HIT ที่ 2 และ 3

</details>

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `skillRate[damageCount]` — calcFinawData damageCount lo fixAddDamage.Length AND damageCount lo skillRate.Length OR damageCount hs fixAddDamage.Length AND damageCount lo skillRate.Length
- Flat dmg + `fixAddDamage[damageCount]` — calcFinawData damageCount lo fixAddDamage.Length AND damageCount lo skillRate.Length

**Role:** attack (deals damage) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `fixAddDamage[damageCount]`
- `SkillRate` multiplies by (adds into): `skillRate[damageCount]`
- `ExpRate` sets: `(target.ExpDefMagic / 100)` | `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `max(((13 - Lv) + ((max(status.Cspd, 0) lt 0x2710 ? max(status.Cspd) : 0x2710) / -10000)), 0)` _(when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0)_; `(13 - Lv)` → Lv1..10 [12, 11, 10, 9, 8, 7, 6, 5, 4, 3] _(when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0)_; `max((CastTime + -1), 0)` _(when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 17 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116) ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116).effective ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116).isBreak eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 17 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116) ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116).effective ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116).isBreak eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 17 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116) ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116).effective ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116).isBreak eq 0 AND UnityEngine.Object.op_Inequality(actarAction))_
- **Number of damage events** (`damageCount`): `(damageCount + 1)` _(when addHate eq 0)_

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 108

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (58 paths)

- set `Element` = `7` = 7
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`
- set `CastTime` = `max(((13 - Lv) + ((max(status.Cspd, 0) lt 0x2710 ? max(status.Cspd) : 0x2710) / -10000)), 0)` — when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0
- set `CastTime` = `(13 - Lv)` → Lv1..10: [12, 11, 10, 9, 8, 7, 6, 5, 4, 3] — when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0

**`InitializeOthers`** (4 paths)

- set `ActionRange` = `-1` = -1
- set `Element` = `7` = 7

**`SetTargetMobOthers`** (1 path)

- set `targetObj` = `target`

**`ActionStart`** (62 paths)

- set `CastTime` = `max((CastTime + -1), 0)` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 17 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116) ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116).effective ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116).isBreak eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 17 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116) ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116).effective ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116).isBreak eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 17 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116) ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116).effective ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116).isBreak eq 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `attackPos.y` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y`
- set `attackPos.z` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z`
- set `targetObj` = `target`
- set `CastTime` = `CastTime` — when PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND PlayerAttackBase.IsBlank(this) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND PlayerAttackBase.IsBlank(this) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction) AND !UnityEngine.Object.op_Inequality(actarAction) AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)

**`ActionSkillEvent`** (9 paths)

- set `addHate` = `1` = 1 — when param eq 1 AND param ne 100 AND param ne 2
- set `addHate` = `0` = 0 — when IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND UnityEngine.Object.op_Inequality(targetObj) AND param eq 2 AND param ne 100 OR !UnityEngine.Object.op_Inequality(targetObj) AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND param eq 2 AND param ne 100 OR IsInstanceOf(actarAction, MobaPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(targetObj) AND param eq 2 AND param ne 100
- set `attackPos.y` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(targetObj)).y` — when IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND UnityEngine.Object.op_Inequality(targetObj) AND param eq 2 AND param ne 100 OR IsInstanceOf(actarAction, MobaPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(targetObj) AND param eq 2 AND param ne 100 OR IsInstanceOf(actarAction, MobaPlayerActionManager) eq 1 AND IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(targetObj) AND param eq 2 AND param ne 100
- set `attackPos.z` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(targetObj)).z` — when IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND UnityEngine.Object.op_Inequality(targetObj) AND param eq 2 AND param ne 100 OR IsInstanceOf(actarAction, MobaPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(targetObj) AND param eq 2 AND param ne 100 OR IsInstanceOf(actarAction, MobaPlayerActionManager) eq 1 AND IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(targetObj) AND param eq 2 AND param ne 100
- set `attackPos.y` = `attackPos.y` — when !UnityEngine.Object.op_Inequality(targetObj) AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND param eq 2 AND param ne 100 OR !UnityEngine.Object.op_Inequality(targetObj) AND IsInstanceOf(actarAction, MobaPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND param eq 2 AND param ne 100 OR !UnityEngine.Object.op_Inequality(targetObj) AND IsInstanceOf(actarAction, MobaPlayerActionManager) eq 1 AND IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND param eq 2 AND param ne 100
- set `attackPos.z` = `attackPos.z` — when !UnityEngine.Object.op_Inequality(targetObj) AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND param eq 2 AND param ne 100 OR !UnityEngine.Object.op_Inequality(targetObj) AND IsInstanceOf(actarAction, MobaPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND param eq 2 AND param ne 100 OR !UnityEngine.Object.op_Inequality(targetObj) AND IsInstanceOf(actarAction, MobaPlayerActionManager) eq 1 AND IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND param eq 2 AND param ne 100

**`ActionHit`** (6 paths)

- set `enchantedBurstStack` = `1` = 1 — when !UnityEngine.Object.op_Inequality(actarAction) AND addHate eq 0 AND enchantedBurstStack eq 0 OR !hasBuff(873) AND UnityEngine.Object.op_Inequality(actarAction) AND addHate eq 0 AND enchantedBurstStack eq 0 OR EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) eq 10 AND UnityEngine.Object.op_Inequality(actarAction) AND addHate eq 0 AND enchantedBurstStack eq 0 AND hasBuff(873)
- calls `EnchantedBurstAction.AddLocalStack` = `AddLocalStack(PlayerAttackBase.get_ActionID(), Id)` — when EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) eq 10 AND UnityEngine.Object.op_Inequality(actarAction) AND addHate eq 0 AND enchantedBurstStack eq 0 AND hasBuff(873)

**`NextRangeHit`** (4 paths)

- set `damageCount` = `(damageCount + 1)` — when addHate eq 0

**`calcFinawData`** (6 paths)

- template `SetRate[ExpRate]` = `(target.ExpDefMagic / 100)` — when damageCount hs skillRate.Length OR damageCount lo fixAddDamage.Length AND damageCount lo skillRate.Length OR damageCount hs fixAddDamage.Length AND damageCount lo skillRate.Length
- template `AddRate[SkillRate]` = `skillRate[damageCount]` — when damageCount lo fixAddDamage.Length AND damageCount lo skillRate.Length OR damageCount hs fixAddDamage.Length AND damageCount lo skillRate.Length
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage[damageCount]` — when damageCount lo fixAddDamage.Length AND damageCount lo skillRate.Length
- info `templates` = `1`
- template `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` — when damageCount hs skillRate.Length OR damageCount lo fixAddDamage.Length AND damageCount lo skillRate.Length OR damageCount hs fixAddDamage.Length AND damageCount lo skillRate.Length

**`calcDummyData`** (2 paths)

- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(254, 0)`

**`UseChronosShift`** (1 path)

- set `SkillParam` = `(SkillParam | 0x2000)`
- set `lastUsedSkill` = `lastUsedSkill`

**`InitializeChronosShift`** (2 paths)

- set `CastTime` = `0` = 0
- set `attackPos.y` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(targetObj)).y` — when UnityEngine.Object.op_Inequality(targetObj)
- set `attackPos.z` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(targetObj)).z` — when UnityEngine.Object.op_Inequality(targetObj)
- set `attackPos.y` = `attackPos.y` — when !UnityEngine.Object.op_Inequality(targetObj)
- set `attackPos.z` = `attackPos.z` — when !UnityEngine.Object.op_Inequality(targetObj)

</details>

---

### เวทมนตร์: บลาส / เฮลอินเฟรูโน่ / อีเทอนอลบลิซซาร์ด / ฟอร์สเทมเพสต์ / เทิร์นกราวิตี้ / พันนิชเมนท์ / อีคลิปส์ (MagicBurst) · uid 109

<img src="../../icons/sk_109.png" width="40" alt="icon"> 
**Tree:** マジックスキル (`MagicSkill`, tier 4) · **Type:** Attack · **Max Lv:** 150 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** [N]เวทมนตร์:สตรอม[F]ไฟเออร์สตรอม[A]โฟรเซนไซโคลน[W]ธันเดอร์สตรอม[E]แซนด์สตรอม[L]ลักซ์วอร์เทคซ์[D]อีวิวเทมเพสต์[N] · **Flags:** MercenaryCanUseSkill · **Client class:** `MagicBurstAction`

> เพิ่มพลังเวทมนตร์และยิงออกไป
> ทำให้คงกระพันเมื่อเปิดใช้สกิล
> มีโอกาสผลักกระเด็นมอนสเตอร์ยกเว้นบอส
> ยิ่งใช้สกิลเวทเวลาร่ายก็จะยิ่งสั้นลง

<details><summary>In-game level notes</summary>

- Lv14: *พลังจะเพิ่มมากกว่าค่า INT ของตัวเอง *เพิ่มเวลาคงกระพัน
- Lv15: *พลังจะเพิ่มมากกว่าค่า INT ของตัวเอง *ระยะโจมตีสูงสุดเพิ่มตามสกิลเลเวล  *ถ้ามีอุปกรณ์เวทมนตร์ (หลัก)จะเพิ่มเวลาคงกระพัน

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 15.6 | 16.2 | 16.8 | 17.4 | 18 | 18.6 | 19.2 | 19.8 | 20.4 | 21 |
| Flat dmg + | 230 | 260 | 290 | 320 | 350 | 380 | 410 | 440 | 470 | 500 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv * 60) + 1500) + baseINT)) / 100)` — (mainWeapon==Rod & 1) ne 0
- SkillRate × `(((((Lv * 60) + 1500) + baseINT)) / 100)` — (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0

**Role:** attack (deals damage) · buff (self) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv * 30) + 200))`
- `SkillRate` multiplies by (adds into): `(((((Lv * 60) + 1500) + baseINT)) / 100)`

**Mechanics recovered from code**

- **Attack range** (`attackRange`): `(MathUtil.DisplayMeterToDistance(8) + MathUtil.DisplayMeterToDistance(((Lv hi 5 ? Lv : 5) - 5)))` _(when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0)_; `((MathUtil.DisplayMeterToDistance(8) + MathUtil.DisplayMeterToDistance(((Lv hi 5 ? Lv : 5) - 5))) + MathUtil.DisplayMeterToDistance((Lv // 3)))` _(when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0)_
- **Chance to inflict the skill's status ailment (%)** (`abnormalPercent`): `((Lv + (Lv << 2)) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]
- **Cast time modifier** (`CastTime`): `max((PlayerAttackBase.CalcCastTime(this, 8, PlayerActionManagerBase.get_PlayerStatus()) - (PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[109].Count lt PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[109].Max ? PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[109].Count : PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[109].Max)), 0)` _(when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0)_; `max(PlayerAttackBase.CalcCastTime(this, 8, PlayerActionManagerBase.get_PlayerStatus()), 0)` _(when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0)_; `0` = 0 _(when PlayerAttackBase.CheckSkillParamFlag(this, 0x2000))_

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 109

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (6 paths)

- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `attackRange` = `(MathUtil.DisplayMeterToDistance(8) + MathUtil.DisplayMeterToDistance(((Lv hi 5 ? Lv : 5) - 5)))` — when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(8)`
- set `fixAddDamage` = `((Lv * 30) + 200)` → Lv1..10: [230, 260, 290, 320, 350, 380, 410, 440, 470, 500]
- set `abnormalPercent` = `((Lv + (Lv << 2)) << 1)` → Lv1..10: [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]
- set `skillRate` = `(((Lv * 60) + 1500) + baseINT)` — when (mainWeapon==Rod & 1) ne 0
- set `attackAngle` = `((Lv << 1) + 40)` → Lv1..10: [42, 44, 46, 48, 50, 52, 54, 56, 58, 60] — when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0
- set `CastTime` = `max((PlayerAttackBase.CalcCastTime(this, 8, PlayerActionManagerBase.get_PlayerStatus()) - (PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[109].Count lt PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[109].Max ? PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[109].Count : PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[109].Max)), 0)` — when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0
- set `SkillIndividualFlag` = `int(((MathUtil.DistanceToDisplayMeter((MathUtil.DisplayMeterToDistance(8) + MathUtil.DisplayMeterToDistance(((Lv hi 5 ? Lv : 5) - 5)))) * 0.125) * 100))` — when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0
- set `CastTime` = `max(PlayerAttackBase.CalcCastTime(this, 8, PlayerActionManagerBase.get_PlayerStatus()), 0)` — when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0
- set `attackRange` = `((MathUtil.DisplayMeterToDistance(8) + MathUtil.DisplayMeterToDistance(((Lv hi 5 ? Lv : 5) - 5))) + MathUtil.DisplayMeterToDistance((Lv // 3)))` — when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0
- set `skillRate` = `(((Lv * 60) + 1500) + ((baseINT lt 0 ? (baseINT + 1) : baseINT) >> 1))` — when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0
- set `attackAngle` = `(((Lv << 1) + 40) + ((Lv // 3) + ((Lv // 3) << 2)))` → Lv1..10: [42, 44, 51, 53, 55, 62, 64, 66, 73, 75] — when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0
- set `SkillIndividualFlag` = `int(((MathUtil.DistanceToDisplayMeter(((MathUtil.DisplayMeterToDistance(8) + MathUtil.DisplayMeterToDistance(((Lv hi 5 ? Lv : 5) - 5))) + MathUtil.DisplayMeterToDistance((Lv // 3)))) * 0.125) * 100))` — when (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0
- set `skillRate` = `((Lv * 60) + 1500)` → Lv1..10: [1560, 1620, 1680, 1740, 1800, 1860, 1920, 1980, 2040, 2100] — when (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0

**`InitializeOthers`** (4 paths)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`OtherPlayerAttackStartReceive`** (2 paths)

- set `CastTime` = `0` = 0 — when PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)

**`ActionStart`** (39 paths)

- set `Element` = `TryGetElemntType.elementType(PlayerActionManagerBase.get_PlayerStatus())` — when !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND PlayerAttackBase.IsBlank(this) AND SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND !SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND UnityEngine.Object.op_Inequality(actarAction)
- set `forward.y` = `0` = 0 — when !UnityEngine.Object.op_Inequality(actarAction) AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !UnityEngine.Object.op_Inequality(actarAction) AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 OR !PlayerAttackBase.IsBlank(this) AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05
- set `forward` = `(UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)` — when !UnityEngine.Object.op_Inequality(actarAction) AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !UnityEngine.Object.op_Inequality(actarAction) AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 OR !PlayerAttackBase.IsBlank(this) AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05
- set `forward.z` = `((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) / fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))))` — when !UnityEngine.Object.op_Inequality(actarAction) AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND PlayerAttackBase.IsBlank(this) AND SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05
- calls `MagicBurstAction.<>c__DisplayClass38_0..ctor` = `.ctor()` — when !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !UnityEngine.Object.op_Inequality(actarAction) AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05
- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(109)` — when !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND PlayerAttackBase.IsBlank(this) AND SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND !SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND UnityEngine.Object.op_Inequality(actarAction)
- set `forward.z` = `UnityEngine.Vector3.static+0x8` — when !UnityEngine.Object.op_Inequality(actarAction) AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 OR !PlayerAttackBase.IsBlank(this) AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 OR PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND PlayerAttackBase.IsBlank(this) AND SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05

**`ActionSkillEvent`** (5 paths)

- set `forward` = `UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(actarAction)).x` — when ActionRange pl 0 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 0 AND param ne 100 OR !UnityEngine.Object.op_Inequality(actarAction) AND ActionRange pl 0 AND param eq 0 AND param ne 100
- set `forward.y` = `UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(actarAction)).y` — when ActionRange pl 0 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 0 AND param ne 100 OR !UnityEngine.Object.op_Inequality(actarAction) AND ActionRange pl 0 AND param eq 0 AND param ne 100
- set `forward.z` = `UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(actarAction)).z` — when ActionRange pl 0 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 0 AND param ne 100 OR !UnityEngine.Object.op_Inequality(actarAction) AND ActionRange pl 0 AND param eq 0 AND param ne 100
- set `invincibilityId` = `(AbnormalStateManager.AddInvincibilityTemporarilyInAction(PlayerActionManagerBase.get_AbnormalStatusManager(), 2) & 255)` — when ActionRange pl 0 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 0 AND param ne 100
- set `addInvincibility` = `1` = 1 — when ActionRange pl 0 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 0 AND param ne 100

**`ActionHit`** (5 paths)

- set `enchantedBurstStack` = `1` = 1 — when !UnityEngine.Object.op_Inequality(actarAction) AND enchantedBurstStack eq 0 OR !hasBuff(873) AND UnityEngine.Object.op_Inequality(actarAction) AND enchantedBurstStack eq 0 OR EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) eq 10 AND UnityEngine.Object.op_Inequality(actarAction) AND enchantedBurstStack eq 0 AND hasBuff(873)
- calls `EnchantedBurstAction.AddLocalStack` = `AddLocalStack(PlayerAttackBase.get_ActionID(), Id)` — when EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) eq 10 AND UnityEngine.Object.op_Inequality(actarAction) AND enchantedBurstStack eq 0 AND hasBuff(873)

**`calcPlayerToMobDamage`** (10 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(4, abnormalPercent, playerAction)` — when !PlayerAttackBase.checkAbnormalPercent(this, 4, abnormalPercent, playerAction) OR !MobActionManagerBase.CheckMultiFlag(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 4, abnormalPercent, playerAction) OR MobActionManagerBase.CheckMultiFlag(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 4, abnormalPercent, playerAction)
- info `templates` = `1`

**`UseChronosShift`** (1 path)

- set `SkillParam` = `(SkillParam | 0x2000)`
- set `lastUsedSkill` = `lastUsedSkill`

**`InitializeChronosShift`** (1 path)

- set `invincibilityBufFunc` = `0` = 0
- set `+0x14c` = `0` = 0
- set `invincibilityId` = `(AbnormalStateManager.AddInvincibilityTemporarilyInAction(PlayerActionManagerBase.get_AbnormalStatusManager(), 2) & 255)`
- set `addInvincibility` = `1` = 1

**`AddStack`** (10 paths)

- calls `MagicBurstBuf..ctor` = `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 109, 1))` — when !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 109, 1) ge 1 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 109, 1) ge 1 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116) ne 0 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 109, 1) ge 1 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116) eq 0
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new MagicBurstBuf, 0)` — when !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 109, 1) ge 1 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 109, 1) ge 1 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116) ne 0 OR !UnityEngine.Object.op_Equality(playerAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 109, 1) ge 1 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116) eq 0

</details>

**Buffs**

**Buff `MagicBurstBuf`**
- Buff hook methods: `Next`, `NextSkip`, `UpdateMaxValue`
- `Value` = `innerCount` _(when BuffEffectActive ne 0)_
- Hook `Next`: `innerCount`=(innerCount hs 7 ? 8 : (innerCount + 1))
- Hook `NextSkip`: `innerCount`=((innerCount + count) lt 8 ? (innerCount + count) : 8)
- Hook `UpdateMaxValue`: `Max`=1; `Count`=(1 gt innerCount ? innerCount : 1); `Max`=2; `Count`=(2 gt innerCount ? innerCount : 2)
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:MagicBurstBuf$$.ctor<-MagicBurstAction$$AddStack` (no direct constructor call in the skill's own code).
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

<details><summary>Effect applied in `MagicBurstAction$$AddStack` (8 guarded paths)</summary>

- when `SkillLv(109) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 109, stkp(-40), meta(0x399f630, Method$SkillBufferManager.TryGetBuf<MagicBurstBuf>())) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 116, stkp(-56), meta(0x39a87c0, Method$SkillBufferManager.TryGetBuf<MagicProtectionBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
  - returns `MagicBurstBuf.UpdateMaxValue(0x165db78(meta(0x39a87f0, MagicBurstBuf_TypeInfo), ?x1, ?x2, ?x3), ?blr, 0, ?x3)`
  - calls `0x165db78`, `MagicBurstBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `MagicBurstBuf$$UpdateMaxValue`
- when `SkillLv(109) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 109, stkp(-40), meta(0x399f630, Method$SkillBufferManager.TryGetBuf<MagicBurstBuf>())) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 116, stkp(-56), meta(0x39a87c0, Method$SkillBufferManager.TryGetBuf<MagicProtectionBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() eq 0`
  - calls `0x165db78`, `MagicBurstBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `0x165db84`
- when `SkillLv(109) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 109, stkp(-40), meta(0x399f630, Method$SkillBufferManager.TryGetBuf<MagicBurstBuf>())) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 116, stkp(-56), meta(0x39a87c0, Method$SkillBufferManager.TryGetBuf<MagicProtectionBuf>())) & 1) eq 0`
  - returns `MagicBurstBuf.UpdateMaxValue(0x165db78(meta(0x39a87f0, MagicBurstBuf_TypeInfo), ?x1, ?x2, ?x3), ?blr, 0, ?x3)`
  - calls `0x165db78`, `MagicBurstBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `MagicBurstBuf$$UpdateMaxValue`
- when `SkillLv(109) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 109, stkp(-40), meta(0x399f630, Method$SkillBufferManager.TryGetBuf<MagicBurstBuf>())) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 116, stkp(-56), meta(0x39a87c0, Method$SkillBufferManager.TryGetBuf<MagicProtectionBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
  - returns `MagicBurstBuf.UpdateMaxValue(TryGetBuf<object>.out2(), ?blr, 0, ?x3)`
  - calls `MagicBurstBuf$$UpdateMaxValue`
- when `SkillLv(109) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 109, stkp(-40), meta(0x399f630, Method$SkillBufferManager.TryGetBuf<MagicBurstBuf>())) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 116, stkp(-56), meta(0x39a87c0, Method$SkillBufferManager.TryGetBuf<MagicProtectionBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() eq 0`
  - calls `0x165db84`
- when `SkillLv(109) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 109, stkp(-40), meta(0x399f630, Method$SkillBufferManager.TryGetBuf<MagicBurstBuf>())) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 116, stkp(-56), meta(0x39a87c0, Method$SkillBufferManager.TryGetBuf<MagicProtectionBuf>())) & 1) eq 0` AND `TryGetBuf<object>.out2() ne 0`
  - returns `MagicBurstBuf.UpdateMaxValue(TryGetBuf<object>.out2(), ?blr, 0, ?x3)`
  - calls `MagicBurstBuf$$UpdateMaxValue`
- when `SkillLv(109) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 109, stkp(-40), meta(0x399f630, Method$SkillBufferManager.TryGetBuf<MagicBurstBuf>())) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 116, stkp(-56), meta(0x39a87c0, Method$SkillBufferManager.TryGetBuf<MagicProtectionBuf>())) & 1) eq 0` AND `TryGetBuf<object>.out2() eq 0`
  - calls `0x165db84`
- when `SkillLv(109) lt 1`
  - returns `SkillLv(109)`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `MagicBurstAction$$AddStack (GetSkillLv)`

---

### แม็กซ์ไมเซอร์ (Maximuyzer) · uid 110

<img src="../../icons/sk_110.png" width="40" alt="icon"> 
**Tree:** マジックスキル (`MagicSkill`, tier 4) · **Type:** Buffer · **Max Lv:** 150 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** พาวเวอร์เวฟ · **Client class:** `MaximuyzerAction`

> ฟื้นฟู MP จำนวนมากด้วยการเพิ่มพลังเวทมนตร์ชั่วขณะ
> เวลาร่ายจะเร็วขึ้นเมื่อเลเวลเพิ่มขึ้น
> ถ้าใช้ชาร์จ MP ก่อนสกิลนี้เวลาร่ายสูงสุดจะลดลง
> ตามสกิลเลเวลของชาร์จ MP เมื่อใช้ไม้เท้าหรืออุปกรณ์เวทมนตร์

<details><summary>In-game level notes</summary>

- Lv14: *ปริมาณฟื้นฟู MP +500
- Lv15: *ปริมาณฟื้นฟู MP +700

</details>

**Role:** utility / system action

This action never changes monster proration: ExpType None: no proration slot.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `0` = 0 _(when !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND (mainWeapon==Rod & 1) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 116) ne 0 OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND (mainWeapon==Rod & 1) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 101) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 116) ne 0 OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 116) ne 0)_; `(((20 - Lv) - max(((5 - Lv) * 0.5), 0)) - TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 101).Level)` _(when !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND (mainWeapon==Rod & 1) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 101) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 116) eq 0 OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND (((20 - Lv) - max(((5 - Lv) * 0.5), 0)) - TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 101).Level) ls 0 AND (mainWeapon==Rod & 1) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 101) ne 0 OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND (((20 - Lv) - max(((5 - Lv) * 0.5), 0)) - TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 101).Level) hi 0 AND (mainWeapon==Rod & 1) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 101) ne 0)_; `((20 - Lv) - max(((5 - Lv) * 0.5), 0))` → Lv1..10 [17.0, 16.5, 16.0, 15.5, 15.0, 14, 13, 12, 11, 10] _(when !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 101) eq 0 OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND (mainWeapon==Rod & 1) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 116) eq 0 OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND ((20 - Lv) - max(((5 - Lv) * 0.5), 0)) ls 0 AND (mainWeapon==Rod & 1) ne 0)_

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 110

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionStart`** (38 paths)

- set `CastTime` = `0` = 0 — when !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND (mainWeapon==Rod & 1) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 116) ne 0 OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND (mainWeapon==Rod & 1) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 101) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 116) ne 0 OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 116) ne 0
- set `SkillIndividualFlag` = `((SkillIndividualFlag | 4) | 1)` — when !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND (mainWeapon==Rod & 1) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 116) ne 0 OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND (mainWeapon==Rod & 1) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 101) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 116) ne 0 OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 116) ne 0
- set `isEnchantStartMotion` = `0` = 0 — when !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND (mainWeapon==Rod & 1) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 116) ne 0 OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND ((20 - Lv) - max(((5 - Lv) * 0.5), 0)) ls 0 AND (mainWeapon==Rod & 1) ne 0 OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND (mainWeapon==Rod & 1) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 101) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 116) ne 0
- set `CastTime` = `(((20 - Lv) - max(((5 - Lv) * 0.5), 0)) - TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 101).Level)` — when !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND (mainWeapon==Rod & 1) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 101) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 116) eq 0 OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND (((20 - Lv) - max(((5 - Lv) * 0.5), 0)) - TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 101).Level) ls 0 AND (mainWeapon==Rod & 1) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 101) ne 0 OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND (((20 - Lv) - max(((5 - Lv) * 0.5), 0)) - TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 101).Level) hi 0 AND (mainWeapon==Rod & 1) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 101) ne 0
- set `SkillIndividualFlag` = `(SkillIndividualFlag | 1)` — when !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND ((20 - Lv) - max(((5 - Lv) * 0.5), 0)) ls 0 AND (mainWeapon==Rod & 1) ne 0 OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND (((20 - Lv) - max(((5 - Lv) * 0.5), 0)) - TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 101).Level) ls 0 AND (mainWeapon==Rod & 1) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 101) ne 0 OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND ((20 - Lv) - max(((5 - Lv) * 0.5), 0)) ls 0 AND (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0
- set `CastTime` = `((20 - Lv) - max(((5 - Lv) * 0.5), 0))` → Lv1..10: [17.0, 16.5, 16.0, 15.5, 15.0, 14, 13, 12, 11, 10] — when !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 101) eq 0 OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND (mainWeapon==Rod & 1) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 116) eq 0 OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND ((20 - Lv) - max(((5 - Lv) * 0.5), 0)) ls 0 AND (mainWeapon==Rod & 1) ne 0

**`UseChronosShift`** (1 path)

- set `SkillParam` = `(SkillParam | 0x2000)`

**`InitializeChronosShift`** (1 path)

- set `CastTime` = `0` = 0

</details>

<details><summary>Effect applied in `ChargingAction$$ActionSkillEvent` (4 guarded paths)</summary>

- when `IsOtherPlayer eq 0` AND `SkillLv(110) ge 1`
  - calls `PlayerAttackBase$$CheckSkillParamFlag`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `SkillBufferManager$$AddSelfBuffer`
- when `IsOtherPlayer eq 0` AND `SkillLv(110) lt 1`
  - returns `SkillLv(110)`
  - calls `PlayerAttackBase$$CheckSkillParamFlag`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
- when `IsOtherPlayer eq 0` AND `SkillLv(110) ge 1`
  - calls `PlayerAttackBase$$CheckSkillParamFlag`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `SkillBufferManager$$AddSelfBuffer`
- when `IsOtherPlayer eq 0` AND `SkillLv(110) lt 1`
  - returns `SkillLv(110)`
  - calls `PlayerAttackBase$$CheckSkillParamFlag`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`

</details>

<details><summary>Effect applied in `MindimageSenjuSupportAction$$ActionSkillEvent` (6 guarded paths)</summary>

- when `CharacterActionManagerBase.get_IsLocalDead() eq 101` AND `SkillLv(110) ge 1`
  - calls `SkillActionBase$$ActionSkillEvent`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `SkillBufferManager$$AddSelfBuffer`
- when `CharacterActionManagerBase.get_IsLocalDead() eq 101` AND `SkillLv(110) lt 1`
  - returns `SkillLv(110)`
  - calls `SkillActionBase$$ActionSkillEvent`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
- when `CharacterActionManagerBase.get_IsLocalDead() eq 101` AND `SkillLv(110) ge 1`
  - calls `SkillActionBase$$ActionSkillEvent`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `SkillBufferManager$$AddSelfBuffer`
- when `CharacterActionManagerBase.get_IsLocalDead() eq 101` AND `SkillLv(110) lt 1`
  - returns `SkillLv(110)`
  - calls `SkillActionBase$$ActionSkillEvent`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
- when `CharacterActionManagerBase.get_IsLocalDead() eq 101` AND `SkillLv(110) ge 1`
  - calls `SkillActionBase$$ActionSkillEvent`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `SkillBufferManager$$AddSelfBuffer`
- when `CharacterActionManagerBase.get_IsLocalDead() eq 101` AND `SkillLv(110) lt 1`
  - returns `SkillLv(110)`
  - calls `SkillActionBase$$ActionSkillEvent`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `ChargingAction$$ActionSkillEvent (GetSkillLv)`
- `MindimageSenjuSupportAction$$ActionSkillEvent (GetSkillLv)`

---

### สเปลทูนนิ่ง (SpellTurning) · uid 119

<img src="../../icons/sk_119.png" width="40" alt="icon"> 
**Tree:** マジックスキル (`MagicSkill`, tier 4) · **Type:** Extra · **Max Lv:** 150 · **Weapons:** Rod, MainMagictool · **Requires:** คาดาร์เอเล็คซิโอ

> ความรู้ในการปรับแต่งเวทมนตร์ตามความถนัด
> สามารถปรับแต่งสกิลเวทมนตร์บางอย่างได้ถึงเลเวล 3 ของสกิลทรี
> 
> *ไม่ส่งผลต่อเอนชานท์สเปล  

**Role:** no client action class (system / production / unreleased)

<details><summary>Effect applied in `ExSkillSpellTuning$$get_IsEnable` (6 guarded paths)</summary>

- when `SkillLv(119) ge 1`
  - calls `PlayerDataManager$$GetPlayerDataManager`, `0x165d8dc`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `ExSkillSpellTuning$$get_MaxPoint`, `Singleton<object>$$get_Instance`, `MasterSkillDataManager$$GetSkillMaster`, `PlayerDataManager$$get_PlayerStatus`
- when `SkillLv(119) ge 1`
  - returns `0`
  - calls `PlayerDataManager$$GetPlayerDataManager`, `0x165d8dc`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `ExSkillSpellTuning$$get_MaxPoint`
- when `SkillLv(119) lt 1`
  - returns `0`
  - calls `PlayerDataManager$$GetPlayerDataManager`, `0x165d8dc`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`
- when `SkillLv(119) ge 1`
  - calls `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `ExSkillSpellTuning$$get_MaxPoint`, `Singleton<object>$$get_Instance`, `MasterSkillDataManager$$GetSkillMaster`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillUtil$$CheckSkillEquipLimit`
- when `SkillLv(119) ge 1`
  - returns `0`
  - calls `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `ExSkillSpellTuning$$get_MaxPoint`
- when `SkillLv(119) lt 1`
  - returns `0`
  - calls `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`

</details>

<details><summary>Effect applied in `ExSkillSpellTuning$$get_MaxPoint` (2 guarded paths)</summary>

- always
  - returns `(SkillManager.GetSkillTreeLv(CharacterActionManagerBase.get_IsDeadOrLocalDead(), 3, 0, 0) gt 4 ? (SkillLv(119) + 2) : SkillLv(119))`
  - calls `PlayerDataManager$$GetPlayerDataManager`, `0x165d8dc`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetSkillTreeLv`
- always
  - returns `(SkillManager.GetSkillTreeLv(CharacterActionManagerBase.get_IsDeadOrLocalDead(), 3, 0, 0) gt 4 ? (SkillLv(119) + 2) : SkillLv(119))`
  - calls `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetSkillTreeLv`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `ExSkillSpellTuning$$get_IsEnable (GetSkillLv)`
- `ExSkillSpellTuning$$get_MaxPoint (GetSkillLv)`
- `UIExSkillManager$$ExSkillList (GetSkillLv)`
- `UIMagicExSkillManager$$Initialize (GetSkillLv)`
- `UISkillTreeManager$$SkillTreeList (GetSkillLv)`

---

### เวทมนตร์:เมจิกแคนนอน (MagicCannon) · uid 112

<img src="../../icons/sk_112.png" width="40" alt="icon"> 
**Tree:** マジックスキル (`MagicSkill`, tier 5) · **Type:** Attack · **Max Lv:** 240 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** [N]เวทมนตร์: บลาส[F]เฮลอินเฟรูโน่[A]อีเทอนอลบลิซซาร์ด[W]ฟอร์สเทมเพสต์[E]เทิร์นกราวิตี้[L]พันนิชเมนท์[D]อีคลิปส์[N] · **Client class:** `MagicCannonAction`

> ปืนใหญ่เวทมตร์กวาดล้างศัตรูเป็นเส้นตรง(ชาร์จสกิล)
> ยิ่งชาร์จพลังและจำนวน HIT ก็จะยิ่งเพิ่มขึ้น
> การชาร์จจะเร็วขึ้นเมื่อใช้สกิลที่ต้องร่ายเวทมนตร์
> เมื่อชาร์จเกิน 100% โอกาสในการเจาะเกราะจะเพิ่มโอกาสในการเจาะ Guard

<details><summary>In-game level notes</summary>

- Lv14: *พลังเพิ่มขึ้นตาม INT
- Lv15: *เพิ่มโบนัสการชาร์จสำหรับพลังสกิล *เพิ่มระยะโจมตี

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 700 | 700 | 700 | 700 | 700 | 700 | 700 | 700 | 700 | 700 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((baseINT + (((Lv + (Lv << 1))) * skillRate[0])) / 100)` — 0 lo skillRate.Length AND 1 ge LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability le 99 OR 0 lo skillRate.Length AND 1 ge LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability gt 99 OR 0 lo skillRate.Length AND 1 hs skillRate.Length AND 1 lt LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability le 99
- SkillRate × `((baseINT + (((Lv + (Lv << 1))) * skillRate[0])) / 100)` — 0 lo skillRate.Length AND 1 ge LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability le 99 OR 0 lo skillRate.Length AND 1 ge LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability gt 99 OR 0 lo skillRate.Length AND 1 hs skillRate.Length AND 1 lt LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability le 99
- SkillRate × `((baseINT + (((Lv + (Lv << 1))) * skillRate[1])) / 100)` — 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 ge LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability le 99 OR 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 ge LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability gt 99 OR 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 hs skillRate.Length AND 2 lt LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability le 99
- SkillRate × `((baseINT + (((Lv + (Lv << 1))) * skillRate[1])) / 100)` — 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 ge LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability le 99 OR 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 ge LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability gt 99 OR 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 hs skillRate.Length AND 2 lt LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability le 99
- SkillRate × `((baseINT + (((Lv + (Lv << 1))) * skillRate[2])) / 100)` — 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 lo skillRate.Length AND 2 lt LoopParam AND 3 ge LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability le 99 OR 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 lo skillRate.Length AND 2 lt LoopParam AND 3 lt LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability le 99 OR 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 lo skillRate.Length AND 2 lt LoopParam AND 3 ge LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability gt 99
- SkillRate × `((baseINT + (((Lv + (Lv << 1))) * skillRate[2])) / 100)` — 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 lo skillRate.Length AND 2 lt LoopParam AND 3 ge LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability le 99 OR 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 lo skillRate.Length AND 2 lt LoopParam AND 3 lt LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability le 99 OR 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 lo skillRate.Length AND 2 lt LoopParam AND 3 ge LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability gt 99
- SkillRate × `((((Lv + (Lv << 1))) * skillRate[0]) / 100)` — 0 lo skillRate.Length AND 1 ge LoopParam AND LoopParam ge 1 AND WeaponType ne 14 AND attackCount lt LoopParam AND target.GuardProbability le 99 OR 0 lo skillRate.Length AND 1 ge LoopParam AND LoopParam ge 1 AND WeaponType ne 14 AND attackCount lt LoopParam AND target.GuardProbability gt 99 OR 0 lo skillRate.Length AND 1 hs skillRate.Length AND 1 lt LoopParam AND LoopParam ge 1 AND WeaponType ne 14 AND attackCount lt LoopParam AND target.GuardProbability le 99
- SkillRate × `((((Lv + (Lv << 1))) * skillRate[0]) / 100)` — 0 lo skillRate.Length AND 1 ge LoopParam AND LoopParam ge 1 AND WeaponType ne 14 AND attackCount lt LoopParam AND target.GuardProbability le 99 OR 0 lo skillRate.Length AND 1 ge LoopParam AND LoopParam ge 1 AND WeaponType ne 14 AND attackCount lt LoopParam AND target.GuardProbability gt 99 OR 0 lo skillRate.Length AND 1 hs skillRate.Length AND 1 lt LoopParam AND LoopParam ge 1 AND WeaponType ne 14 AND attackCount lt LoopParam AND target.GuardProbability le 99
- Flat dmg + `(700)` — !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND SkillBufferDataBase.GetParam(20) lt 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND ((LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) : 5) ge 1 AND SkillBufferDataBase.GetParam(20) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND ((LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) : 5) lt 1 AND SkillBufferDataBase.GetParam(20) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ne 0 AND UnityEngine.Object.op_Inequality(actarAction) & 0 lo skillRate.Length AND 1 ge LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability le 99 OR 0 lo skillRate.Length AND 1 ge LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability gt 99 OR 0 lo skillRate.Length AND 1 ge LoopParam AND LoopParam ge 1 AND WeaponType ne 14 AND attackCount lt LoopParam AND target.GuardProbability le 99

**Role:** attack (deals damage)

The skill builds 3 separate damage templates (each is a full hit with its own crit roll). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(700)`
- `SkillRate` multiplies by (adds into): `((baseINT + (((Lv + (Lv << 1))) * skillRate[0])) / 100)` | `((baseINT + (((Lv + (Lv << 1))) * skillRate[1])) / 100)` | `((baseINT + (((Lv + (Lv << 1))) * skillRate[2])) / 100)`

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`; `0` = 0 _(when PlayerAttackBase.CheckSkillParamFlag(this, 0x2000))_
- **Effect radius (Unity units)** (`Radius`): `MathUtil.DisplayMeterToDistance((FieldManager.get_IsMoRoom(Singleton<FieldManager>.get_Instance()) ? 100 : 24))`; `lastUsedSkill.Radius`
- **Loop / hit-repeat count** (`LoopParam`): `1` = 1; `motionSpeed`; `((LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) : 5)` _(when !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND SkillBufferDataBase.GetParam(20) lt 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND ((LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) : 5) ge 1 AND SkillBufferDataBase.GetParam(20) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND ((LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) : 5) lt 1 AND SkillBufferDataBase.GetParam(20) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ne 0 AND UnityEngine.Object.op_Inequality(actarAction))_
- **MP cost** (`mp`): `700` = 700 _(when TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ne 0 AND mainWeapon == Rod OR (mainWeapon==Magictool & 1) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ne 0 AND mainWeapon != Rod OR (mainWeapon==Magictool & 1) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ne 0 AND mainWeapon != Rod)_

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 112

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (12 paths)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(24)`
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`
- set `fixAddDamage` = `700` = 700
- set `baseSkillRate` = `(Lv + (Lv << 1))` → Lv1..10: [3, 6, 9, 12, 15, 18, 21, 24, 27, 30]
- set `Radius` = `MathUtil.DisplayMeterToDistance((FieldManager.get_IsMoRoom(Singleton<FieldManager>.get_Instance()) ? 100 : 24))`
- set `width` = `MathUtil.DisplayMeterToDistance(3)` — when (mainWeapon==Magictool & 1) ne 0 AND mainWeapon != Rod OR (mainWeapon==Magictool & 1) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) eq 0 AND mainWeapon != Rod OR (mainWeapon==Magictool & 1) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ne 0 AND mainWeapon != Rod
- set `LoopParam` = `1` = 1
- set `mp` = `700` = 700 — when TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ne 0 AND mainWeapon == Rod OR (mainWeapon==Magictool & 1) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ne 0 AND mainWeapon != Rod OR (mainWeapon==Magictool & 1) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ne 0 AND mainWeapon != Rod
- set `width` = `MathUtil.DisplayMeterToDistance((mainWeapon == Magictool ? 3 : 1.5))` — when mainWeapon == Rod OR (mainWeapon==Magictool & 1) eq 0 AND mainWeapon != Rod OR TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) eq 0 AND mainWeapon == Rod

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1
- set `LoopParam` = `motionSpeed`

**`OtherPlayerAttackStartReceive`** (2 paths)

- set `CastTime` = `0` = 0 — when PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)

**`ActionStart`** (427 paths)

- set `attackPos.y` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y` — when !PlayerAttackBase.IsBlank(this) AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)
- set `attackPos.z` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z` — when !PlayerAttackBase.IsBlank(this) AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)
- calls `AbnormalStateManager.RemoveAbnormalState` = `RemoveAbnormalState(37)` — when !PlayerAttackBase.IsBlank(this) AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND (System.Collections.Generic.Dictionary<Int16Enum, int>.ContainsKey(new SkillLinkedTake._parameter, 7, meta(0x399f6c8, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.ContainsKey())) & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `SkillIndividualFlag` = `SkillBufferDataBase.GetParam(20)` — when !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND SkillBufferDataBase.GetParam(20) lt 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND ((LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) : 5) ge 1 AND SkillBufferDataBase.GetParam(20) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND ((LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) : 5) lt 1 AND SkillBufferDataBase.GetParam(20) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `fixAddDamage` = `((WeaponType eq 15 ? (SkillBufferDataBase.GetParam(20) + (SkillBufferDataBase.GetParam(20) << 1)) : SkillBufferDataBase.GetParam(20)) + fixAddDamage)` — when !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND SkillBufferDataBase.GetParam(20) lt 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND ((LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) : 5) ge 1 AND SkillBufferDataBase.GetParam(20) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND ((LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) : 5) lt 1 AND SkillBufferDataBase.GetParam(20) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `LoopParam` = `((LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) : 5)` — when !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND SkillBufferDataBase.GetParam(20) lt 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND ((LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) : 5) ge 1 AND SkillBufferDataBase.GetParam(20) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND ((LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) : 5) lt 1 AND SkillBufferDataBase.GetParam(20) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `guardIgnorePercent` = `max(((SkillBufferDataBase.GetParam(20) - 100) lt 100 ? (SkillBufferDataBase.GetParam(20) - 100) : 100), 0)` — when !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND SkillBufferDataBase.GetParam(20) lt 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND ((LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) : 5) ge 1 AND SkillBufferDataBase.GetParam(20) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND ((LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((SkillBufferDataBase.GetParam(20) // 20) - ((SkillBufferDataBase.GetParam(20) - ((SkillBufferDataBase.GetParam(20) // 20) * 20)) eq 0 ? 1 : 0))) : 5) lt 1 AND SkillBufferDataBase.GetParam(20) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `Element` = `TryGetElemntType.elementType(PlayerActionManagerBase.get_PlayerStatus())` — when !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND (System.Collections.Generic.Dictionary<Int16Enum, int>.ContainsKey(new SkillLinkedTake._parameter, 7, meta(0x399f6c8, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.ContainsKey())) & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND (System.Collections.Generic.Dictionary<Int16Enum, int>.ContainsKey(new SkillLinkedTake._parameter, 7, meta(0x399f6c8, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.ContainsKey())) & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND (System.Collections.Generic.Dictionary<Int16Enum, int>.ContainsKey(new SkillLinkedTake._parameter, 7, meta(0x399f6c8, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.ContainsKey())) & 1) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 112).BuffEffectActive eq 0 AND UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(112)` — when !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND (System.Collections.Generic.Dictionary<Int16Enum, int>.ContainsKey(new SkillLinkedTake._parameter, 7, meta(0x399f6c8, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.ContainsKey())) & 1) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND (System.Collections.Generic.Dictionary<Int16Enum, int>.ContainsKey(new SkillLinkedTake._parameter, 7, meta(0x399f6c8, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.ContainsKey())) & 1) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)

**`ActionSkillEvent`** (2 paths)

- set `isRotationTarget` = `0` = 0 — when param eq 101

**`ActionSkillReceiveEffect`** (1 path)

- set `effect` = `effect`

**`ActionHit`** (5 paths)

- set `enchantedBurstStack` = `1` = 1 — when !UnityEngine.Object.op_Inequality(actarAction) AND enchantedBurstStack eq 0 OR !hasBuff(873) AND UnityEngine.Object.op_Inequality(actarAction) AND enchantedBurstStack eq 0 OR EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) eq 10 AND UnityEngine.Object.op_Inequality(actarAction) AND enchantedBurstStack eq 0 AND hasBuff(873)
- calls `EnchantedBurstAction.AddLocalStack` = `AddLocalStack(PlayerAttackBase.get_ActionID(), Id)` — when EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) eq 10 AND UnityEngine.Object.op_Inequality(actarAction) AND enchantedBurstStack eq 0 AND hasBuff(873)

**`calcPlayerToMobDamage`** (1109 paths)

- template `AddRate[SkillRate]` = `((baseINT + (baseSkillRate * skillRate[0])) / 100)` — when 0 lo skillRate.Length AND 1 ge LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability le 99 OR 0 lo skillRate.Length AND 1 ge LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability gt 99 OR 0 lo skillRate.Length AND 1 hs skillRate.Length AND 1 lt LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability le 99
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage` — when 0 lo skillRate.Length AND 1 ge LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability le 99 OR 0 lo skillRate.Length AND 1 ge LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability gt 99 OR 0 lo skillRate.Length AND 1 ge LoopParam AND LoopParam ge 1 AND WeaponType ne 14 AND attackCount lt LoopParam AND target.GuardProbability le 99
- info `templates` = `1` — when 0 hs skillRate.Length AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability le 99 OR 0 hs skillRate.Length AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability gt 99 OR 0 hs skillRate.Length AND LoopParam ge 1 AND WeaponType ne 14 AND attackCount lt LoopParam AND target.GuardProbability le 99
- template `AddRate[SkillRate]` = `((baseINT + (baseSkillRate * skillRate[1])) / 100)` — when 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 ge LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability le 99 OR 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 ge LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability gt 99 OR 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 hs skillRate.Length AND 2 lt LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability le 99
- info `templates` = `2` — when 0 lo skillRate.Length AND 1 hs skillRate.Length AND 1 lt LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability le 99 OR 0 lo skillRate.Length AND 1 hs skillRate.Length AND 1 lt LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability gt 99 OR 0 lo skillRate.Length AND 1 hs skillRate.Length AND 1 lt LoopParam AND LoopParam ge 1 AND WeaponType ne 14 AND attackCount lt LoopParam AND target.GuardProbability le 99
- template `AddRate[SkillRate]` = `((baseINT + (baseSkillRate * skillRate[2])) / 100)` — when 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 lo skillRate.Length AND 2 lt LoopParam AND 3 ge LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability le 99 OR 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 lo skillRate.Length AND 2 lt LoopParam AND 3 lt LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability le 99 OR 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 lo skillRate.Length AND 2 lt LoopParam AND 3 ge LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability gt 99
- info `templates` = `3` — when 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 hs skillRate.Length AND 2 lt LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability le 99 OR 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 hs skillRate.Length AND 2 lt LoopParam AND LoopParam ge 1 AND WeaponType eq 14 AND attackCount lt LoopParam AND target.GuardProbability gt 99 OR 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 hs skillRate.Length AND 2 lt LoopParam AND LoopParam ge 1 AND WeaponType ne 14 AND attackCount lt LoopParam AND target.GuardProbability le 99
- template `AddRate[SkillRate]` = `((baseSkillRate * skillRate[0]) / 100)` — when 0 lo skillRate.Length AND 1 ge LoopParam AND LoopParam ge 1 AND WeaponType ne 14 AND attackCount lt LoopParam AND target.GuardProbability le 99 OR 0 lo skillRate.Length AND 1 ge LoopParam AND LoopParam ge 1 AND WeaponType ne 14 AND attackCount lt LoopParam AND target.GuardProbability gt 99 OR 0 lo skillRate.Length AND 1 hs skillRate.Length AND 1 lt LoopParam AND LoopParam ge 1 AND WeaponType ne 14 AND attackCount lt LoopParam AND target.GuardProbability le 99
- template `AddRate[SkillRate]` = `((baseSkillRate * skillRate[1]) / 100)` — when 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 ge LoopParam AND LoopParam ge 1 AND WeaponType ne 14 AND attackCount lt LoopParam AND target.GuardProbability le 99 OR 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 ge LoopParam AND LoopParam ge 1 AND WeaponType ne 14 AND attackCount lt LoopParam AND target.GuardProbability gt 99 OR 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 hs skillRate.Length AND 2 lt LoopParam AND LoopParam ge 1 AND WeaponType ne 14 AND attackCount lt LoopParam AND target.GuardProbability le 99
- template `AddRate[SkillRate]` = `((baseSkillRate * skillRate[2]) / 100)` — when 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 lo skillRate.Length AND 2 lt LoopParam AND 3 ge LoopParam AND LoopParam ge 1 AND WeaponType ne 14 AND attackCount lt LoopParam AND target.GuardProbability le 99 OR 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 lo skillRate.Length AND 2 lt LoopParam AND 3 lt LoopParam AND LoopParam ge 1 AND WeaponType ne 14 AND attackCount lt LoopParam AND target.GuardProbability le 99 OR 0 lo skillRate.Length AND 1 lo skillRate.Length AND 1 lt LoopParam AND 2 lo skillRate.Length AND 2 lt LoopParam AND 3 ge LoopParam AND LoopParam ge 1 AND WeaponType ne 14 AND attackCount lt LoopParam AND target.GuardProbability gt 99

**`UseChronosShift`** (1 path)

- set `SkillParam` = `(SkillParam | 0x2000)`
- set `lastUsedSkill` = `lastUsedSkill`

**`InitializeChronosShift`** (1 path)

- set `Radius` = `lastUsedSkill.Radius`
- set `width` = `lastUsedSkill.width`
- set `LoopParam` = `lastUsedSkill.LoopParam`
- set `baseSkillRate` = `lastUsedSkill.baseSkillRate`
- set `skillRate` = `lastUsedSkill.skillRate`
- set `chargeComboType` = `0` = 0
- set `chargeComboRate` = `100` = 100

</details>

<details><summary>Effect applied in `MobaPlayerActionManager$$GetSkillTargetType` (4 guarded paths)</summary>

- when `skillId le 577` AND `skillId gt 76` AND `skillId le 114` AND `skillId eq 112`
  - returns `[MasterSkillDataManager.GetSkillMaster(Singleton<object>.get_Instance(meta(0x397a328, Method$Singleton<MasterSkillDataManager>.get_Instance()), ?x1, ?x2, ?x3), 112, 0, ?x3)+0x2c]`
  - calls `Singleton<object>$$get_Instance`, `MasterSkillDataManager$$GetSkillMaster`
- when `skillId le 577` AND `skillId gt 76` AND `skillId le 114` AND `skillId eq 112`
  - returns `1`
- when `skillId le 577` AND `skillId gt 76` AND `skillId le 114` AND `skillId eq 112`
  - calls `0x165db84`, `0x165df00`
- when `skillId le 577` AND `skillId gt 76` AND `skillId le 114` AND `skillId eq 112`
  - returns `1`

</details>

<details><summary>Effect applied in `PlayerActionManager$$GetSkillTargetType` (4 guarded paths)</summary>

- when `skillId le 629` AND `skillId le 112` AND `skillId gt 9` AND `skillId ne 50`
  - returns `[MasterSkillDataManager.GetSkillMaster(Singleton<object>.get_Instance(meta(0x397a328, Method$Singleton<MasterSkillDataManager>.get_Instance()), ?x1, ?x2, ?x3), 112, 0, ?x3)+0x2c]`
  - calls `Singleton<object>$$get_Instance`, `MasterSkillDataManager$$GetSkillMaster`
- when `skillId le 629` AND `skillId le 112` AND `skillId gt 9` AND `skillId ne 50`
  - returns `1`
- when `skillId le 629` AND `skillId le 112` AND `skillId gt 9` AND `skillId ne 50`
  - calls `0x165db84`, `0x165df00`
- when `skillId le 629` AND `skillId le 112` AND `skillId gt 9` AND `skillId ne 50`
  - returns `1`

</details>

<details><summary>Effect applied in `MagicCannonAction$$OnInitialize` (12 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `PlayerAttackBase.CalcMp(this, actarAction, 0, ?x3)`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `WeaponType` = `15`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CastTime` = `PlayerAttackBase.CalcCastTime(this, ?blr, 0, ?x3)`
  - set `fixAddDamage` = `700`
  - set `baseSkillRate` = `(Lv + (Lv << 1))`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `width` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `LoopParam` = `1`
  - set `mp` = `700`
  - calls `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcCastTime`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsMoRoom`
- when `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `PlayerAttackBase.CalcMp(this, actarAction, 0, ?x3)`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `WeaponType` = `15`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CastTime` = `PlayerAttackBase.CalcCastTime(this, ?blr, 0, ?x3)`
  - set `fixAddDamage` = `700`
  - set `baseSkillRate` = `(Lv + (Lv << 1))`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `width` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `LoopParam` = `1`
  - calls `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcCastTime`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsMoRoom`
- when `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `WeaponType` = `15`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CastTime` = `PlayerAttackBase.CalcCastTime(this, ?blr, 0, ?x3)`
  - set `fixAddDamage` = `700`
  - set `baseSkillRate` = `(Lv + (Lv << 1))`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `width` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `LoopParam` = `1`
  - calls `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcCastTime`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsMoRoom`
- when `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-40), 0) & 1) eq 0`
  - returns `PlayerAttackBase.CalcMp(this, actarAction, 0, ?x3)`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `WeaponType` = `15`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CastTime` = `PlayerAttackBase.CalcCastTime(this, ?blr, 0, ?x3)`
  - set `fixAddDamage` = `700`
  - set `baseSkillRate` = `(Lv + (Lv << 1))`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `width` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `LoopParam` = `1`
  - calls `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcCastTime`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsMoRoom`
- when `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `PlayerAttackBase.CalcMp(this, actarAction, 0, ?x3)`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CastTime` = `PlayerAttackBase.CalcCastTime(this, ?blr, 0, ?x3)`
  - set `fixAddDamage` = `700`
  - set `baseSkillRate` = `(Lv + (Lv << 1))`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `width` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `LoopParam` = `1`
  - set `mp` = `700`
  - calls `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcCastTime`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsMoRoom`
- when `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `PlayerAttackBase.CalcMp(this, actarAction, 0, ?x3)`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CastTime` = `PlayerAttackBase.CalcCastTime(this, ?blr, 0, ?x3)`
  - set `fixAddDamage` = `700`
  - set `baseSkillRate` = `(Lv + (Lv << 1))`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `width` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `LoopParam` = `1`
  - calls `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcCastTime`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsMoRoom`
- when `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CastTime` = `PlayerAttackBase.CalcCastTime(this, ?blr, 0, ?x3)`
  - set `fixAddDamage` = `700`
  - set `baseSkillRate` = `(Lv + (Lv << 1))`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `width` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `LoopParam` = `1`
  - calls `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcCastTime`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsMoRoom`
- when `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-40), 0) & 1) eq 0`
  - returns `PlayerAttackBase.CalcMp(this, actarAction, 0, ?x3)`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CastTime` = `PlayerAttackBase.CalcCastTime(this, ?blr, 0, ?x3)`
  - set `fixAddDamage` = `700`
  - set `baseSkillRate` = `(Lv + (Lv << 1))`
  - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `width` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `LoopParam` = `1`
  - calls `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcCastTime`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsMoRoom`

</details>

<details><summary>Effect applied in `PlayerAttackBase$$MagicCannonCharge` (9 guarded paths)</summary>

- when `SkillLv(112) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `MagicCannonBuf.Charge(TryGetBuf.out2(), ?blr, 0, ?x3)`
  - calls `0x165da68`, `interface IEnchantSkill.get_IsEnchantMotion`, `MagicCannonBuf$$Charge`
- when `SkillLv(112) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `0x165da68`, `interface IEnchantSkill.get_IsEnchantMotion`, `0x165db84`
- when `SkillLv(112) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `((?blr & 1) ne 0 ? 2 : 1) eq 1`
  - returns `MagicCannonBuf.Charge(TryGetBuf.out2(), ?blr, 0, ?x3)`
  - calls `0x165da68`, `interface IEnchantSkill.get_IsEnchantMotion`, `MagicCannonBuf$$Charge`
- when `SkillLv(112) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `((?blr & 1) ne 0 ? 2 : 1) ne 1`
  - returns `MagicCannonBuf.Charge(TryGetBuf.out2(), ?blr, 0, ?x3)`
  - calls `0x165da68`, `interface IEnchantSkill.get_IsEnchantMotion`, `MagicCannonBuf$$Charge`, `MagicCannonBuf$$Charge`
- when `SkillLv(112) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `((?blr & 1) ne 0 ? 2 : 1) ne 1`
  - returns `MagicCannonBuf.Charge(TryGetBuf.out2(), ?blr, 0, ?x3)`
  - calls `0x165da68`, `interface IEnchantSkill.get_IsEnchantMotion`, `MagicCannonBuf$$Charge`, `MagicCannonBuf$$Charge`, `MagicCannonBuf$$Charge`
- when `SkillLv(112) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `((?blr & 1) ne 0 ? 2 : 1) ne 1`
  - calls `0x165da68`, `interface IEnchantSkill.get_IsEnchantMotion`, `MagicCannonBuf$$Charge`, `MagicCannonBuf$$Charge`, `MagicCannonBuf$$Charge`
- when `SkillLv(112) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `0x165da68`, `interface IEnchantSkill.get_IsEnchantMotion`, `0x165db84`
- when `SkillLv(112) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-56), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 112, stkp(-56), 0)`
  - calls `0x165da68`

</details>

<details><summary>Effect applied in `SkillChargeAction$$ReceiveSupport` (3 guarded paths)</summary>

- when `returnCode eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `MagicCannonBuf.Start(TryGetBuf.out2(), 0, ?x2, ?x3)`
  - calls `MagicCannonBuf$$Start`
- when `returnCode eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `0x165db84`, `0x165df00`
- when `returnCode eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-40), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 112, stkp(-40), 0)`

</details>

<details><summary>Effect applied in `PlayerDataManager$$OnAbnormalDamage` (6 guarded paths)</summary>

- when `TryGetBuf<object>.out2() ne 0`
  - returns `SlashReaperBuf.DamagedMagicalExplosion(TryGetBuf<object>.out2(), 0, ?x2, ?x3)`
  - calls `PlayerDataManager$$UpdateServerHP`, `PlayerDataManager$$UpdateServerMp`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_PlayerActionManager`, `0x165db78`, `System.Action<int, Int32Enum, int>$$.ctor`, `PlayerDataManager$$get_gameObject`, `PlayerDataManager$$get_gameObject`
- when `TryGetBuf<object>.out2() eq 0`
  - calls `PlayerDataManager$$UpdateServerHP`, `PlayerDataManager$$UpdateServerMp`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_PlayerActionManager`, `0x165db78`, `System.Action<int, Int32Enum, int>$$.ctor`, `PlayerDataManager$$get_gameObject`, `PlayerDataManager$$get_gameObject`
- always
  - returns `SkillBufferManager.TryGetBuf<object>(PlayerDataManager.get_SkillBufferManager(this, ?x1, ?x2, ?x3), 718, stkp(-64), meta(0x399f5f8, Method$SkillBufferManager.TryGetBuf<SlashReaperBuf>()))`
  - calls `PlayerDataManager$$UpdateServerHP`, `PlayerDataManager$$UpdateServerMp`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_PlayerActionManager`, `0x165db78`, `System.Action<int, Int32Enum, int>$$.ctor`, `PlayerDataManager$$get_gameObject`, `PlayerDataManager$$get_gameObject`
- when `TryGetBuf<object>.out2() ne 0`
  - returns `SlashReaperBuf.DamagedMagicalExplosion(TryGetBuf<object>.out2(), 0, ?x2, ?x3)`
  - calls `PlayerDataManager$$UpdateServerHP`, `PlayerDataManager$$UpdateServerMp`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_PlayerActionManager`, `0x165db78`, `System.Action<int, Int32Enum, int>$$.ctor`, `PlayerDataManager$$get_gameObject`, `PlayerDataManager$$get_gameObject`
- when `TryGetBuf<object>.out2() eq 0`
  - calls `PlayerDataManager$$UpdateServerHP`, `PlayerDataManager$$UpdateServerMp`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_PlayerActionManager`, `0x165db78`, `System.Action<int, Int32Enum, int>$$.ctor`, `PlayerDataManager$$get_gameObject`, `PlayerDataManager$$get_gameObject`
- always
  - returns `SkillBufferManager.TryGetBuf<object>(PlayerDataManager.get_SkillBufferManager(this, ?x1, ?x2, ?x3), 718, stkp(-64), meta(0x399f5f8, Method$SkillBufferManager.TryGetBuf<SlashReaperBuf>()))`
  - calls `PlayerDataManager$$UpdateServerHP`, `PlayerDataManager$$UpdateServerMp`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_PlayerActionManager`, `0x165db78`, `System.Action<int, Int32Enum, int>$$.ctor`, `PlayerDataManager$$get_gameObject`, `PlayerDataManager$$get_gameObject`

</details>

<details><summary>Effect applied in `MagicCannonAction$$ActionStart` (299 guarded paths, truncated)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-104), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() ge 1` AND `((LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() //`
  - returns `PlayerAttackBase.CheckSkillParamFlag(this, 0x2000, 0, ?x3)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `+0x15c` = `0`
  - set `+0x160` = `(?v2 - ?v2)`
  - set `SkillIndividualFlag` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `fixAddDamage` = `((WeaponType eq 15 ? (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() << 1)) : CharacterActionManagerBase.set_DefaultMoveSpeed()) + fixAddDamage)`
  - set `LoopParam` = `((LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((Charact`
  - set `skillRate` = `0x165d9d4(meta(0x3978430, float[]_TypeInfo), ((LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) * 20)) `
  - set `guardIgnorePercent` = `max(((CharacterActionManagerBase.set_DefaultMoveSpeed() - 100) lt 100 ? (CharacterActionManagerBase.set_DefaultMoveSpeed() - 100) : 100), 0)`
  - set `Element` = `TryGetElemntType.out1()`
  - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-104), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() ge 1` AND `((LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() //`
  - returns `PlayerAttackBase.CheckSkillParamFlag(this, 0x2000, 0, ?x3)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `+0x15c` = `0`
  - set `+0x160` = `(?v2 - ?v2)`
  - set `SkillIndividualFlag` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `fixAddDamage` = `((WeaponType eq 15 ? (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() << 1)) : CharacterActionManagerBase.set_DefaultMoveSpeed()) + fixAddDamage)`
  - set `LoopParam` = `((LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((Charact`
  - set `skillRate` = `0x165d9d4(meta(0x3978430, float[]_TypeInfo), ((LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) * 20)) `
  - set `guardIgnorePercent` = `max(((CharacterActionManagerBase.set_DefaultMoveSpeed() - 100) lt 100 ? (CharacterActionManagerBase.set_DefaultMoveSpeed() - 100) : 100), 0)`
  - set `Element` = `TryGetElemntType.out1()`
  - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-104), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() ge 1` AND `((LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() //`
  - returns `PlayerAttackBase.CheckSkillParamFlag(this, 0x2000, 0, ?x3)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `+0x15c` = `0`
  - set `+0x160` = `(?v2 - ?v2)`
  - set `SkillIndividualFlag` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `fixAddDamage` = `((WeaponType eq 15 ? (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() << 1)) : CharacterActionManagerBase.set_DefaultMoveSpeed()) + fixAddDamage)`
  - set `LoopParam` = `((LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((Charact`
  - set `skillRate` = `0x165d9d4(meta(0x3978430, float[]_TypeInfo), ((LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) * 20)) `
  - set `guardIgnorePercent` = `max(((CharacterActionManagerBase.set_DefaultMoveSpeed() - 100) lt 100 ? (CharacterActionManagerBase.set_DefaultMoveSpeed() - 100) : 100), 0)`
  - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-104), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() ge 1` AND `((LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() //`
  - returns `PlayerAttackBase.CheckSkillParamFlag(this, 0x2000, 0, ?x3)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `+0x15c` = `0`
  - set `+0x160` = `(?v2 - ?v2)`
  - set `SkillIndividualFlag` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `fixAddDamage` = `((WeaponType eq 15 ? (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() << 1)) : CharacterActionManagerBase.set_DefaultMoveSpeed()) + fixAddDamage)`
  - set `LoopParam` = `((LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((Charact`
  - set `skillRate` = `0x165d9d4(meta(0x3978430, float[]_TypeInfo), ((LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) * 20)) `
  - set `guardIgnorePercent` = `max(((CharacterActionManagerBase.set_DefaultMoveSpeed() - 100) lt 100 ? (CharacterActionManagerBase.set_DefaultMoveSpeed() - 100) : 100), 0)`
  - set `Element` = `TryGetElemntType.out1()`
  - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-104), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() ge 1` AND `((LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() //`
  - returns `PlayerAttackBase.CheckSkillParamFlag(this, 0x2000, 0, ?x3)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `+0x15c` = `0`
  - set `+0x160` = `(?v2 - ?v2)`
  - set `SkillIndividualFlag` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `fixAddDamage` = `((WeaponType eq 15 ? (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() << 1)) : CharacterActionManagerBase.set_DefaultMoveSpeed()) + fixAddDamage)`
  - set `LoopParam` = `((LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((Charact`
  - set `skillRate` = `0x165d9d4(meta(0x3978430, float[]_TypeInfo), ((LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) * 20)) `
  - set `guardIgnorePercent` = `max(((CharacterActionManagerBase.set_DefaultMoveSpeed() - 100) lt 100 ? (CharacterActionManagerBase.set_DefaultMoveSpeed() - 100) : 100), 0)`
  - set `Element` = `TryGetElemntType.out1()`
  - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-104), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() ge 1` AND `((LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() //`
  - returns `PlayerAttackBase.CheckSkillParamFlag(this, 0x2000, 0, ?x3)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `+0x15c` = `0`
  - set `+0x160` = `(?v2 - ?v2)`
  - set `SkillIndividualFlag` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `fixAddDamage` = `((WeaponType eq 15 ? (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() << 1)) : CharacterActionManagerBase.set_DefaultMoveSpeed()) + fixAddDamage)`
  - set `LoopParam` = `((LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((Charact`
  - set `skillRate` = `0x165d9d4(meta(0x3978430, float[]_TypeInfo), ((LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) * 20)) `
  - set `guardIgnorePercent` = `max(((CharacterActionManagerBase.set_DefaultMoveSpeed() - 100) lt 100 ? (CharacterActionManagerBase.set_DefaultMoveSpeed() - 100) : 100), 0)`
  - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-104), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() ge 1` AND `((LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() //`
  - returns `PlayerAttackBase.CheckSkillParamFlag(this, 0x2000, 0, ?x3)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `+0x15c` = `0`
  - set `+0x160` = `(?v2 - ?v2)`
  - set `SkillIndividualFlag` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `fixAddDamage` = `((WeaponType eq 15 ? (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() << 1)) : CharacterActionManagerBase.set_DefaultMoveSpeed()) + fixAddDamage)`
  - set `LoopParam` = `((LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((Charact`
  - set `skillRate` = `0x165d9d4(meta(0x3978430, float[]_TypeInfo), ((LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) * 20)) `
  - set `guardIgnorePercent` = `max(((CharacterActionManagerBase.set_DefaultMoveSpeed() - 100) lt 100 ? (CharacterActionManagerBase.set_DefaultMoveSpeed() - 100) : 100), 0)`
  - set `Element` = `TryGetElemntType.out1()`
  - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `(SkillBufferManager.TryGetBuf(?blr, 112, stkp(-104), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() ge 1` AND `((LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() //`
  - returns `PlayerAttackBase.CheckSkillParamFlag(this, 0x2000, 0, ?x3)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `+0x15c` = `0`
  - set `+0x160` = `(?v2 - ?v2)`
  - set `SkillIndividualFlag` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `fixAddDamage` = `((WeaponType eq 15 ? (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() << 1)) : CharacterActionManagerBase.set_DefaultMoveSpeed()) + fixAddDamage)`
  - set `LoopParam` = `((LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) * 20)) eq 0 ? 1 : 0))) lt 5 ? (LoopParam + ((Charact`
  - set `skillRate` = `0x165d9d4(meta(0x3978430, float[]_TypeInfo), ((LoopParam + ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) - ((CharacterActionManagerBase.set_DefaultMoveSpeed() - ((CharacterActionManagerBase.set_DefaultMoveSpeed() // 20) * 20)) `
  - set `guardIgnorePercent` = `max(((CharacterActionManagerBase.set_DefaultMoveSpeed() - 100) lt 100 ? (CharacterActionManagerBase.set_DefaultMoveSpeed() - 100) : 100), 0)`
  - set `Element` = `TryGetElemntType.out1()`
  - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `MagicCannonAction$$ActionStart (TryGetBuf)`
- `MagicCannonAction$$OnInitialize (TryGetBuf)`
- `MobaPlayerActionManager$$GetSkillTargetType (TryGetBuf)`
- `PlayerActionManager$$GetSkillTargetType (TryGetBuf)`
- `PlayerAttackBase$$MagicCannonCharge (GetSkillLv)`
- `PlayerAttackBase$$MagicCannonCharge (TryGetBuf)`
- `PlayerDataManager$$OnAbnormalDamage (TryGetBuf)`
- `SkillChargeAction$$ReceiveSupport (TryGetBuf)`

---

### เวทมนตร์:แครช / เมเทโอเรน / เฮล / ฟลูกูไรต์ / ร็อคฟอล / เมเทโอไลท์ / คอสมอส (MagicFall) · uid 113

<img src="../../icons/sk_113.png" width="40" alt="icon"> 
**Tree:** マジックスキル (`MagicSkill`, tier 5) · **Type:** Attack · **Max Lv:** 240 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** [N]เวทมนตร์:สตรอม[F]ไฟเออร์สตรอม[A]โฟรเซนไซโคลน[W]ธันเดอร์สตรอม[E]แซนด์สตรอม[L]ลักซ์วอร์เทคซ์[D]อีวิวเทมเพสต์[N] · **Client class:** `MagicFallAction`

> เวทที่ใช้เรียกอุกกาบาต 3 ก้อนเล็ก
> เมื่อโจมตีอุกกาบาตแต่ละก้อน
> อาจจะตกลงมาอีกไม่เกิน 2 ครั้งด้วยพลังที่ลดลง
> แต่จะแลกมาด้วยโอกาสคริติคอลตายตัวที่เพิ่มขึ้น
> และมีโอกาสสูงที่จะทำให้เกิด[ลดการป้องกัน]หรือ[ตาลาย]

<details><summary>In-game level notes</summary>

- Lv14: *พลังเพิ่มขึ้นตาม INT *เพิ่มอัตราการติดสภาวะผิดปกติ *ระยะโจมตี(รัศมี)+0.5m
- Lv15: *เพิ่มอัตราการติดสภาวะผิดปกติอย่างมาก *ระยะโจมตี(รัศมี)+1.5m

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(skillRate[(((((param & 0xffff) - (((param & 0xffff) // 200) * 200))) - 1) // 3)] / 100)` — (param - 101) hi 98 AND (param - 200) ls 99 AND param eq 200 AND param ne 100 & ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND gemCartLv ge 1 OR ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND gemCartLv lt 1 OR ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND (currentMeteorNumber - 1) lo attackHits.Length AND gemCartLv ge 1
- SkillRate × `(skillRate[(((((param & 0xffff) - (((param & 0xffff) // 200) * 200))) - 1) // 3)] / 100)` — (param - 101) hi 98 AND (param - 200) ls 99 AND param ne 100 AND param ne 200 & ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND gemCartLv ge 1 OR ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND gemCartLv lt 1 OR ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND (currentMeteorNumber - 1) lo attackHits.Length AND gemCartLv ge 1

**Role:** attack (deals damage) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(400)`
- `SkillRate` multiplies by (adds into): `(skillRate[(((((param & 0xffff) - (((param & 0xffff) // 200) * 200))) - 1) // 3)] / 100)`
- `ExpRate` sets: `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefMagic / 100)` | `(targetExpList[mobAction] / 100)`

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`; `0` = 0
- **Effect radius (Unity units)** (`Radius`): `(MathUtil.DisplayMeterToDistance(1.5) + MathUtil.DisplayMeterToDistance(0.5))` _(when mainWeapon != Magictool AND mainWeapon == Rod)_; `(MathUtil.DisplayMeterToDistance(1.5) + MathUtil.DisplayMeterToDistance(1.5))` _(when mainWeapon == Magictool OR (mainWeapon==Magictool & 1) ne 0 AND mainWeapon != Magictool AND mainWeapon != Rod)_; `MathUtil.DisplayMeterToDistance(1.5)` _(when (mainWeapon==Magictool & 1) eq 0 AND mainWeapon != Magictool AND mainWeapon != Rod)_
- **Loop / hit-repeat count** (`LoopParam`): `int(((max(MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)), 3) * 0.5) * 10))` _(when !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv ge 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv ge 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv ge 1 AND UnityEngine.Object.op_Inequality(actarAction))_; `int((max(MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)), 3) * 10))` _(when !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv lt 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv lt 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv lt 1 AND UnityEngine.Object.op_Inequality(actarAction))_

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 113

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (9 paths)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`
- set `fixAddDamage` = `400` = 400
- set `Radius` = `(MathUtil.DisplayMeterToDistance(1.5) + MathUtil.DisplayMeterToDistance(0.5))` — when mainWeapon != Magictool AND mainWeapon == Rod
- set `Radius` = `(MathUtil.DisplayMeterToDistance(1.5) + MathUtil.DisplayMeterToDistance(1.5))` — when mainWeapon == Magictool OR (mainWeapon==Magictool & 1) ne 0 AND mainWeapon != Magictool AND mainWeapon != Rod
- set `Radius` = `MathUtil.DisplayMeterToDistance(1.5)` — when (mainWeapon==Magictool & 1) eq 0 AND mainWeapon != Magictool AND mainWeapon != Rod

**`ActionStart`** (1026 paths)

- set `targetObject` = `target` — when !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv ge 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv lt 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv ge 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)
- set `attackCenterPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x` — when !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv ge 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv lt 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv ge 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)
- set `attackCenterPos.y` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y` — when !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv ge 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv lt 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv ge 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)
- set `attackCenterPos.z` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z` — when !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv ge 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv lt 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv ge 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)
- set `effectSize` = `((WeaponType eq 15 ? 2 : 1) * 0.5)` — when !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv ge 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv lt 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv ge 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)
- set `Element` = `TryGetElemntType.elementType(PlayerActionManagerBase.get_PlayerStatus())` — when !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv ge 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv lt 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv ge 1 AND UnityEngine.Object.op_Inequality(actarAction)
- set `Radius` = `(Radius / 10)` — when !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv ge 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv lt 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv ge 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)
- set `gemCartLv` = `GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv` — when !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv ge 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv lt 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv ge 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000)
- set `LoopParam` = `int(((max(MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)), 3) * 0.5) * 10))` — when !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv ge 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv ge 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv ge 1 AND UnityEngine.Object.op_Inequality(actarAction)
- set `LoopParam` = `int((max(MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)), 3) * 10))` — when !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv lt 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv lt 1 AND PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) OR !PlayerAttackBase.CheckSkillParamFlag(this, 0x2000) AND !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetGemCartBuffer(PlayerStatusBase.get_GemCartBuffManager(), 1042).Lv lt 1 AND UnityEngine.Object.op_Inequality(actarAction)

**`ActionSkillEventPreparation`** (19 paths)

- set `attackCenterPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(targetObject)).x` — when (param - 1) ls 8 AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND UnityEngine.Object.op_Inequality(targetObject) AND gemCartLv ge 1 OR (param - 1) ls 8 AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND UnityEngine.Object.op_Inequality(targetObject) AND gemCartLv lt 1 OR (param - 1) ls 8 AND IsInstanceOf(actarAction, MobaPlayerActionManager) eq 1 AND IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(targetObject) AND gemCartLv ge 1
- set `attackCenterPos.y` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(targetObject)).y` — when (param - 1) ls 8 AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND UnityEngine.Object.op_Inequality(targetObject) AND gemCartLv ge 1 OR (param - 1) ls 8 AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND UnityEngine.Object.op_Inequality(targetObject) AND gemCartLv lt 1 OR (param - 1) ls 8 AND IsInstanceOf(actarAction, MobaPlayerActionManager) eq 1 AND IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(targetObject) AND gemCartLv ge 1
- set `attackCenterPos.z` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(targetObject)).z` — when (param - 1) ls 8 AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND UnityEngine.Object.op_Inequality(targetObject) AND gemCartLv ge 1 OR (param - 1) ls 8 AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND UnityEngine.Object.op_Inequality(targetObject) AND gemCartLv lt 1 OR (param - 1) ls 8 AND IsInstanceOf(actarAction, MobaPlayerActionManager) eq 1 AND IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(targetObject) AND gemCartLv ge 1

**`ActionSkillEvent`** (12 paths)

- set `currentMeteorNumber` = `(currentMeteorNumber + 1)` — when (param - 101) hi 98 AND (param - 200) ls 99 AND param eq 200 AND param ne 100
- set `currentMeteorNumber` = `((param & 0xffff) - (((param & 0xffff) // 200) * 200))` — when (param - 101) hi 98 AND (param - 200) ls 99 AND param ne 100 AND param ne 200
- set `attackCenterPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(targetObject)).x` — when (param - 101) ls 98 AND UnityEngine.Object.op_Inequality(targetObject) AND gemCartLv gt 0 AND param ne 100 OR (param - 101) ls 98 AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND UnityEngine.Object.op_Inequality(targetObject) AND gemCartLv le 0 AND param ne 100 OR (param - 101) ls 98 AND IsInstanceOf(actarAction, MobaPlayerActionManager) eq 1 AND IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(targetObject) AND gemCartLv le 0 AND param ne 100
- set `attackCenterPos.y` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(targetObject)).y` — when (param - 101) ls 98 AND UnityEngine.Object.op_Inequality(targetObject) AND gemCartLv gt 0 AND param ne 100 OR (param - 101) ls 98 AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND UnityEngine.Object.op_Inequality(targetObject) AND gemCartLv le 0 AND param ne 100 OR (param - 101) ls 98 AND IsInstanceOf(actarAction, MobaPlayerActionManager) eq 1 AND IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(targetObject) AND gemCartLv le 0 AND param ne 100
- set `attackCenterPos.z` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(targetObject)).z` — when (param - 101) ls 98 AND UnityEngine.Object.op_Inequality(targetObject) AND gemCartLv gt 0 AND param ne 100 OR (param - 101) ls 98 AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND UnityEngine.Object.op_Inequality(targetObject) AND gemCartLv le 0 AND param ne 100 OR (param - 101) ls 98 AND IsInstanceOf(actarAction, MobaPlayerActionManager) eq 1 AND IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(targetObject) AND gemCartLv le 0 AND param ne 100

**`ActionHit`** (5 paths)

- set `enchantedBurstStack` = `1` = 1 — when !UnityEngine.Object.op_Inequality(actarAction) AND enchantedBurstStack eq 0 OR !hasBuff(873) AND UnityEngine.Object.op_Inequality(actarAction) AND enchantedBurstStack eq 0 OR EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) eq 10 AND UnityEngine.Object.op_Inequality(actarAction) AND enchantedBurstStack eq 0 AND hasBuff(873)
- calls `EnchantedBurstAction.AddLocalStack` = `AddLocalStack(PlayerAttackBase.get_ActionID(), Id)` — when EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) eq 10 AND UnityEngine.Object.op_Inequality(actarAction) AND enchantedBurstStack eq 0 AND hasBuff(873)

**`calcPlayerToMobDamage`** (66 paths)

- template `AddRate[SkillRate]` = `(skillRate[((currentMeteorNumber - 1) // 3)] / 100)` — when ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND gemCartLv ge 1 OR ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND gemCartLv lt 1 OR ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND (currentMeteorNumber - 1) lo attackHits.Length AND gemCartLv ge 1
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage` — when ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND gemCartLv ge 1 OR ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND gemCartLv lt 1 OR ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND (currentMeteorNumber - 1) lo attackHits.Length AND gemCartLv ge 1
- template `SetRate[ExpRate]` = `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefMagic / 100)` — when ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND gemCartLv ge 1 OR ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND gemCartLv lt 1 OR ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND (currentMeteorNumber - 1) lo attackHits.Length AND gemCartLv ge 1
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(14, dizzyPercent[((currentMeteorNumber - 1) // 3)], playerAction)` — when ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo dizzyPercent.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND (currentMeteorNumber - 1) lo attackHits.Length AND AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10) AND PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent[((currentMeteorNumber - 1) // 3)], playerAction) AND gemCartLv ge 1 OR !PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent[((currentMeteorNumber - 1) // 3)], playerAction) AND ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo dizzyPercent.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND (currentMeteorNumber - 1) lo attackHits.Length AND AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10) AND gemCartLv ge 1 OR ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo dizzyPercent.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND (currentMeteorNumber - 1) lo attackHits.Length AND AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10) AND PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent[((currentMeteorNumber - 1) // 3)], playerAction) AND gemCartLv lt 1
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(14, 0)` — when ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo dizzyPercent.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND (currentMeteorNumber - 1) lo attackHits.Length AND AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10) AND PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent[((currentMeteorNumber - 1) // 3)], playerAction) AND gemCartLv ge 1 OR ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo dizzyPercent.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND (currentMeteorNumber - 1) lo attackHits.Length AND AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10) AND PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent[((currentMeteorNumber - 1) // 3)], playerAction) AND gemCartLv lt 1
- info `templates` = `1` — when ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND gemCartLv ge 1 OR ((currentMeteorNumber - 1) // 3) hs skillRate.Length AND ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND gemCartLv ge 1 OR ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND gemCartLv lt 1
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(10, breakingPercent[((currentMeteorNumber - 1) // 3)], playerAction)` — when !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10) AND ((currentMeteorNumber - 1) // 3) lo breakingPercent.Length AND ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND (currentMeteorNumber - 1) lo attackHits.Length AND PlayerAttackBase.checkAbnormalPercent(this, 10, breakingPercent[((currentMeteorNumber - 1) // 3)], playerAction) AND gemCartLv ge 1 OR !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10) AND !PlayerAttackBase.checkAbnormalPercent(this, 10, breakingPercent[((currentMeteorNumber - 1) // 3)], playerAction) AND ((currentMeteorNumber - 1) // 3) lo breakingPercent.Length AND ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND (currentMeteorNumber - 1) lo attackHits.Length AND gemCartLv ge 1 OR !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10) AND ((currentMeteorNumber - 1) // 3) lo breakingPercent.Length AND ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND (currentMeteorNumber - 1) lo attackHits.Length AND PlayerAttackBase.checkAbnormalPercent(this, 10, breakingPercent[((currentMeteorNumber - 1) // 3)], playerAction) AND gemCartLv lt 1
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(10, 0)` — when !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10) AND ((currentMeteorNumber - 1) // 3) lo breakingPercent.Length AND ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND (currentMeteorNumber - 1) lo attackHits.Length AND PlayerAttackBase.checkAbnormalPercent(this, 10, breakingPercent[((currentMeteorNumber - 1) // 3)], playerAction) AND gemCartLv ge 1 OR !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10) AND ((currentMeteorNumber - 1) // 3) lo breakingPercent.Length AND ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND (currentMeteorNumber - 1) lo attackHits.Length AND PlayerAttackBase.checkAbnormalPercent(this, 10, breakingPercent[((currentMeteorNumber - 1) // 3)], playerAction) AND gemCartLv lt 1
- template `SetRate[ExpRate]` = `(targetExpList[mobAction] / 100)` — when ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND gemCartLv ge 1 OR ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND gemCartLv lt 1 OR ((currentMeteorNumber - 1) // 3) lo criticalBonus.Length AND ((currentMeteorNumber - 1) // 3) lo skillRate.Length AND (currentMeteorNumber - 1) lo attackHits.Length AND gemCartLv ge 1

**`InitializeChronosShift`** (1 path)

- set `CastTime` = `0` = 0

**`UseChronosShift`** (1 path)

- set `SkillParam` = `(SkillParam | 0x2000)`
- set `lastUsedSkill` = `lastUsedSkill`

**`InitializeOthers`** (4 paths)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`ActionStartOthers`** (2 paths)

- set `targetObject` = `target`
- set `attackCenterPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x`
- set `attackCenterPos.y` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y`
- set `attackCenterPos.z` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z`
- set `effectSize` = `((WeaponType eq 15 ? 2 : 1) * 0.5)`
- set `Radius` = `(Radius / 10)`

</details>

---

### โครนอสชิฟท์ (ChronosShift) · uid 114

<img src="../../icons/sk_114.png" width="40" alt="icon"> 
**Tree:** マジックスキル (`MagicSkill`, tier 5) · **Type:** Special · **Max Lv:** 240 · **Weapons:** MainMagictool · **Requires:** เวทมนตร์: ไฟนอล · **Client class:** `ChronosShiftAction`

> วิชาต้องห้ามใช้ย้อนเวลาเพื่อกลับไปใช้เวทมนตร์
> จะทำให้ใช้สกิลเวทที่ใช้เป็นครั้งสุดท้ายได้ทันทีอีกครั้ง
> เมื่อใช้สกิลนี้แล้ว
> จะไม่สามารถใช้ได้อีกในช่วงระยะเวลาหนึ่ง

**Role:** buff (self)

Proration uses the **slot chosen at runtime (physical or magic by a per-cast flag)**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`
- **MP cost** (`mp`): `0` = 0 _(when SkillActionBase.op_Equality(saveSkill) OR !SkillActionBase.op_Equality(saveSkill) AND isCoolDown ne 0)_; `SkillActionBase.get_Mp()` _(when !SkillActionBase.op_Equality(saveSkill) AND isCoolDown eq 0)_

**Proration:** slot `dynamic`, mode `first_hit_per_target`, attack type `dynamic`, action id 114

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (6 paths)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(100)`
- set `isCoolDown` = `[TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 114)+0x28]` — when !SkillActionBase.op_Inequality(TryGetSaveMagicSkill.saveSkill(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 114), (this + 312)), 0) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 114) ne 0 OR SkillActionBase.op_Inequality(TryGetSaveMagicSkill.saveSkill(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 114), (this + 312)), 0) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 114) ne 0 AND TryGetSaveMagicSkill.saveSkill(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 114), (this + 312)) ne 0 OR SkillActionBase.op_Inequality(TryGetSaveMagicSkill.saveSkill(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 114), (this + 312)), 0) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 114) ne 0 AND TryGetSaveMagicSkill.saveSkill(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 114), (this + 312)) eq 0
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`
- set `SkillIndividualFlag` = `SkillActionBase.get_ActionID()` — when SkillActionBase.op_Inequality(saveSkill) OR SkillActionBase.op_Inequality(TryGetSaveMagicSkill.saveSkill(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 114), (this + 312)), 0) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 114) ne 0 AND TryGetSaveMagicSkill.saveSkill(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 114), (this + 312)) ne 0
- set `SkillIndividualFlag` = `0` = 0 — when !SkillActionBase.op_Inequality(saveSkill) OR !SkillActionBase.op_Inequality(TryGetSaveMagicSkill.saveSkill(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 114), (this + 312)), 0) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 114) ne 0

**`InitializeChronosShift`** (3 paths)

- set `mp` = `0` = 0 — when SkillActionBase.op_Equality(saveSkill) OR !SkillActionBase.op_Equality(saveSkill) AND isCoolDown ne 0
- set `attackType` = `SkillActionBase.get_AttackType()` — when !SkillActionBase.op_Equality(saveSkill) AND isCoolDown eq 0
- set `isInterruptable` = `(SkillActionBase.get_IsInterruptable() & 1)` — when !SkillActionBase.op_Equality(saveSkill) AND isCoolDown eq 0
- set `isHitRigidity` = `(SkillActionBase.get_IsHitRigidity() & 1)` — when !SkillActionBase.op_Equality(saveSkill) AND isCoolDown eq 0
- set `isUnsheatheWeapon` = `(SkillActionBase.get_IsUnsheatheWeapon() & 1)` — when !SkillActionBase.op_Equality(saveSkill) AND isCoolDown eq 0
- set `isPutUpWeapon` = `(SkillActionBase.get_IsPutUpWeapon() & 1)` — when !SkillActionBase.op_Equality(saveSkill) AND isCoolDown eq 0
- set `isRange` = `(SkillActionBase.get_IsRange() & 1)` — when !SkillActionBase.op_Equality(saveSkill) AND isCoolDown eq 0
- set `mp` = `SkillActionBase.get_Mp()` — when !SkillActionBase.op_Equality(saveSkill) AND isCoolDown eq 0
- set `isSupport` = `(SkillActionBase.get_IsSupport() & 1)` — when !SkillActionBase.op_Equality(saveSkill) AND isCoolDown eq 0

</details>

**Buffs**

**Buff `ChronosShiftBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `GetLastUsedSkillTargetType`, `SaveMagicSkill`, `StartCoolDown`, `TryGetSaveMagicSkill`, `get_IsCoolDown`, `set_IsCoolDown`
- Duration: `0` s
- Buff fields set in the constructor (all recovered):
  - `viewType` = `3` = 3
  - `Count` = `0`
  - `Max` = `20` = 20
- Hook `set_IsCoolDown`: `IsCoolDown`=(value & 1)
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
- Hook `SaveMagicSkill`: `saveSkill`=skill; `Count`=(SkillActionBase.get_Mp() // 100)
- Hook `StartCoolDown`: `IsCoolDown`=1; `LeftTime`=(16 - Lv); `viewType`=7

<details><summary>Effect applied in `MobaPlayerActionManager$$GetSkillTargetType` (3 guarded paths)</summary>

- when `skillId le 577` AND `skillId gt 76` AND `skillId le 114` AND `skillId ne 112`
  - returns `ChronosShiftBuf.GetLastUsedSkillTargetType(TryGetBuf.out2(), 0, ?x2, ?x3)`
  - calls `ChronosShiftBuf$$GetLastUsedSkillTargetType`
- when `skillId le 577` AND `skillId gt 76` AND `skillId le 114` AND `skillId ne 112`
  - calls `0x165db84`, `0x165df00`
- when `skillId le 577` AND `skillId gt 76` AND `skillId le 114` AND `skillId ne 112`
  - returns `4`

</details>

<details><summary>Effect applied in `PlayerActionManager$$GetSkillTargetType` (3 guarded paths)</summary>

- when `skillId le 629` AND `skillId gt 112` AND `skillId le 299` AND `skillId eq 114`
  - returns `ChronosShiftBuf.GetLastUsedSkillTargetType(TryGetBuf.out2(), 0, ?x2, ?x3)`
  - calls `ChronosShiftBuf$$GetLastUsedSkillTargetType`
- when `skillId le 629` AND `skillId gt 112` AND `skillId le 299` AND `skillId eq 114`
  - calls `0x165db84`, `0x165df00`
- when `skillId le 629` AND `skillId gt 112` AND `skillId le 299` AND `skillId eq 114`
  - returns `4`

</details>

<details><summary>Effect applied in `ChronosShiftAction$$OnInitialize` (5 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 114, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `CharacterActionManagerBase.get_IsLocalDead()`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `isCoolDown` = `[TryGetBuf.out2()+0x28]`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CastTime` = `PlayerAttackBase.CalcCastTime(this, ?blr, 0, ?x3)`
  - set `SkillIndividualFlag` = `CharacterActionManagerBase.get_IsLocalDead()`
  - calls `MathUtil$$DisplayMeterToDistance`, `ChronosShiftBuf$$TryGetSaveMagicSkill`, `ChronosShiftAction$$InitializeChronosShift`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcCastTime`, `PlayerAttackBase$$CalcMp`, `virtual CharacterActionManagerBase.get_IsLocalDead`
- when `(SkillBufferManager.TryGetBuf(?blr, 114, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `0`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `isCoolDown` = `[TryGetBuf.out2()+0x28]`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CastTime` = `PlayerAttackBase.CalcCastTime(this, ?blr, 0, ?x3)`
  - set `SkillIndividualFlag` = `0`
  - calls `MathUtil$$DisplayMeterToDistance`, `ChronosShiftBuf$$TryGetSaveMagicSkill`, `ChronosShiftAction$$InitializeChronosShift`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcCastTime`, `PlayerAttackBase$$CalcMp`
- when `(SkillBufferManager.TryGetBuf(?blr, 114, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - calls `MathUtil$$DisplayMeterToDistance`, `0x165db84`, `0x165df00`
- when `(SkillBufferManager.TryGetBuf(?blr, 114, stkp(-40), 0) & 1) eq 0`
  - returns `CharacterActionManagerBase.get_IsLocalDead()`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CastTime` = `PlayerAttackBase.CalcCastTime(this, ?blr, 0, ?x3)`
  - set `SkillIndividualFlag` = `CharacterActionManagerBase.get_IsLocalDead()`
  - calls `MathUtil$$DisplayMeterToDistance`, `ChronosShiftAction$$InitializeChronosShift`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcCastTime`, `PlayerAttackBase$$CalcMp`, `virtual CharacterActionManagerBase.get_IsLocalDead`
- when `(SkillBufferManager.TryGetBuf(?blr, 114, stkp(-40), 0) & 1) eq 0`
  - returns `0`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CastTime` = `PlayerAttackBase.CalcCastTime(this, ?blr, 0, ?x3)`
  - set `SkillIndividualFlag` = `0`
  - calls `MathUtil$$DisplayMeterToDistance`, `ChronosShiftAction$$InitializeChronosShift`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcCastTime`, `PlayerAttackBase$$CalcMp`

</details>

<details><summary>Effect applied in `PlayerAttackBase$$RegistChronosShift` (5 guarded paths)</summary>

- when `PlayerAttackBase.get_ActionID() ne 114` AND `SkillLv(114) ge 1`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `virtual PlayerAttackBase.get_ActionID`, `Singleton<object>$$get_Instance`, `MasterSkillDataManager$$GetSkillMaster`, `SkillUtil$$CheckSkillEquipLimit`
- when `PlayerAttackBase.get_ActionID() ne 114` AND `SkillLv(114) ge 1`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `virtual PlayerAttackBase.get_ActionID`, `Singleton<object>$$get_Instance`, `MasterSkillDataManager$$GetSkillMaster`, `SkillUtil$$CheckSkillEquipLimit`
- when `PlayerAttackBase.get_ActionID() ne 114` AND `SkillLv(114) ge 1`
  - returns `SkillBufferManager.TryGetBuf(?blr, 114, (0x165db78(meta(0x399fa40, PlayerAttackBase.<>c__DisplayClass118_0_TypeInfo), playerAction, ?x2, ?x3) + 24), 0)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `virtual PlayerAttackBase.get_ActionID`, `Singleton<object>$$get_Instance`, `MasterSkillDataManager$$GetSkillMaster`, `SkillUtil$$CheckSkillEquipLimit`
- when `PlayerAttackBase.get_ActionID() ne 114` AND `SkillLv(114) ge 1`
  - returns `SkillUtil.CheckSkillEquipLimit(?blr, MasterSkillDataManager.GetSkillMaster(Singleton<object>.get_Instance(meta(0x397a328, Method$Singleton<MasterSkillDataManager>.get_Instance()), ?x1, ?x2, ?x3), 114, 0, ?x3), 0, ?x3)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `virtual PlayerAttackBase.get_ActionID`, `Singleton<object>$$get_Instance`, `MasterSkillDataManager$$GetSkillMaster`, `SkillUtil$$CheckSkillEquipLimit`
- when `PlayerAttackBase.get_ActionID() ne 114` AND `SkillLv(114) lt 1`
  - returns `SkillLv(114)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `virtual PlayerAttackBase.get_ActionID`

</details>

<details><summary>Effect applied in `PlayerAttackBase.<>c__DisplayClass118_0$$<RegistChronosShift>b__0` (3 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 114, (this + 24), 0) & 1) ne 0`
  - returns `[(this + 24)+0x0]`
- when `(SkillBufferManager.TryGetBuf(?blr, 114, (this + 24), 0) & 1) ne 0`
  - calls `ChronosShiftBuf$$SaveMagicSkill`, `SkillBufferManager$$AddSelfBuffer`, `0x165db78`, `Singleton<object>$$get_Instance`, `Singleton<object>$$get_Instance`, `0x165db78`, `System.Action<int, Int32Enum, int>$$.ctor`, `UnityEngine.Component$$get_gameObject`
- when `(SkillBufferManager.TryGetBuf(?blr, 114, (this + 24), 0) & 1) eq 0`
  - set `buf` = `0x165db78(meta(0x399eda8, ChronosShiftBuf_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `0x165db78`, `ChronosShiftBuf$$.ctor`, `0x165d8dc`, `ChronosShiftBuf$$SaveMagicSkill`, `SkillBufferManager$$AddSelfBuffer`, `0x165db78`, `Singleton<object>$$get_Instance`, `Singleton<object>$$get_Instance`

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

- `ChronosShiftAction$$OnInitialize (TryGetBuf)`
- `MobAttackBase$$CalcLastDamage (GetSkillLv)`
- `MobaPlayerActionManager$$GetSkillTargetType (TryGetBuf)`
- `PlayerActionManager$$GetSkillTargetType (TryGetBuf)`
- `PlayerAttackBase$$RegistChronosShift (GetSkillLv)`
- `PlayerAttackBase$$RegistChronosShift (TryGetBuf)`
- `PlayerAttackBase.<>c__DisplayClass118_0$$<RegistChronosShift>b__0 (TryGetBuf)`

---

### แรพพิดชาร์จ (RapidCharge) · uid 115

<img src="../../icons/sk_115.png" width="40" alt="icon"> 
**Tree:** マジックスキル (`MagicSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 240 · **Weapons:** Rod, Magictool · **Requires:** แม็กซ์ไมเซอร์ · **Client class:** `RapidCharge` (passive mastery)

> เร่งความเร็วในการชาร์จ MP ได้เล็กน้อย (สูงสุด Lv5)
> เมื่อใช่แม็กซ์ไมเซอร์ต่อจะเพิ่มประสิทธิภาพให้
> MATK และเวทเจาะเข้า(สูงสุด50%)
> *ตั้งแต่ Lv6 ขึ้นไปจะเป็นการขยายเวลาการบัฟเท่านั้น

**Role:** buff (self) · passive mastery

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 2 | 4 | 6 | 8 | 10 | 10 | 10 | 10 | 10 | 10 |


**Buffs**

**Buff `RapidChargeBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Duration: `(((((Lv << 2) + lv) << 1) hi 50 ? (((Lv << 2) + lv) << 1) : 50) - 10)` s [(buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52)) ge 51 OR ((heal // 50) + (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52))) ge 51 AND (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52)) lt 51 OR ((heal // 50) + (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52))) lt 51 AND (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52)) lt 51]
- `MatkUp` = `((((((heal // 50) + (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52))) + (((heal // 50) + (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52))) << 2)) + (heal // 10)) - 250))`
- `MagicResistBreaker` = `(max((50 - (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52))), 0))`
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `IsSelfAction` = `1` = 1 when (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52)) ge 51 OR ((heal // 50) + (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52))) ge 51 AND (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52)) lt 51 OR ((heal // 50) + (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52))) lt 51 AND (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52)) lt 51
  - `BuffEffectActive` = `1` = 1 when (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52)) ge 51 OR ((heal // 50) + (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52))) ge 51 AND (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52)) lt 51 OR ((heal // 50) + (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52))) lt 51 AND (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52)) lt 51
  - `BufEffectTakeUid` = `-1` = -1 when (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52)) ge 51 OR ((heal // 50) + (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52))) ge 51 AND (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52)) lt 51 OR ((heal // 50) + (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52))) lt 51 AND (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52)) lt 51
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] when (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52)) ge 51 OR ((heal // 50) + (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52))) ge 51 AND (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52)) lt 51 OR ((heal // 50) + (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52))) lt 51 AND (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52)) lt 51
  - `matk` = `(((((heal // 50) + (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52))) + (((heal // 50) + (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52))) << 2)) + (heal // 10)) - 250)` when ((heal // 50) + (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52))) ge 51 AND (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52)) lt 51
  - `matk` = `(heal // 10)` when ((heal // 50) + (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52))) lt 51 AND (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52)) lt 51
  - `matk` = `((heal // 10) + ((heal // 50) + ((heal // 50) << 2)))` when (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52)) ge 51
  - `magicResistBreaker` = `max((50 - (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52))), 0)` when ((heal // 50) + (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52))) ge 51 AND (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52)) lt 51
  - `magicResistBreaker` = `(heal // 50)` when ((heal // 50) + (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52))) lt 51 AND (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52)) lt 51
  - `magicResistBreaker` = `0` when (buffParam(MagicResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 52)) ge 51
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

<details><summary>Effect applied in `ReceiveSupportResult$$OnActionPlayerSupport` (2 guarded paths)</summary>

- when `skillId le 709` AND `skillId le 142` AND `skillId gt 55` AND `skillId le 110`
  - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillId, skillLv, supportData), 0, ?x2, ?x3), 0)`
  - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_AbnormalStateManager`, `AbnormalStateManager$$Recovery`, `Singleton<object>$$get_Instance`, `PlayerDataManager$$get_transform`, `UnityEngine.Transform$$get_position`
- when `skillId le 709` AND `skillId le 142` AND `skillId gt 55` AND `skillId le 110`
  - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillId, skillLv, supportData), 0, ?x2, ?x3), 0)`
  - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_AbnormalStateManager`, `AbnormalStateManager$$Recovery`, `Singleton<object>$$get_Instance`, `PlayerDataManager$$get_transform`, `UnityEngine.Transform$$get_position`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `ReceiveSupportResult$$OnActionPlayerSupport (GetSkillLv)`

---

### เอนชานท์บาเรีย (MagicProtection) · uid 116

<img src="../../icons/sk_116.png" width="40" alt="icon"> 
**Tree:** マジックスキル (`MagicSkill`, tier 5) · **Type:** Buffer · **Max Lv:** 240 · **Weapons:** Rod, MainMagictool · **Requires:** แม็กซ์ไมเซอร์ · **Client class:** `MagicProtectionAction`

> วิชาป้องกันตัวเองด้วยการสร้างเขตอาคมส่วนตัว
> ภายในเขตอาคมจะรับความเสียหายที่เกิดขึ้นแทน
> นอกจากนี้ยังลบล้างผงะและลด MP เฮท
> หากฟื้นฟู MP ในเขตอาคม HP ของเขตอาคมจะถูกฟื้นฟูด้วย

<details><summary>In-game level notes</summary>

- Lv14: [ได้รับผลแบบเดียวกันเมื่อใช้กับอุปกรณ์เวทมนตร์] *HP ของเขตอาคมจะเพิ่มขึ้นตามค่า INT และประสิทธิภาพอาวุธ *จะแปรผันตั้งแต่ 50-100% ขึ้นอยู่กับประเภทความเสียหาย *ความเสียหายที่ได้รับจะลดลงอย่างมากเมื่ออยู่ในเขตอาคม *ความเร็วการเคลื่อนที่จะเพิ่มขึ้นเมื่ออยู่ในเขตอาคม *เคาท์ของเวทมนตร์: บลาสจะเพิ่มขึ้นอย่างมากภายในเขตอาคม *เวลาร่ายเวทมนตร์: ไฟนอลจะสั้นลงเมื่ออยู่ในเขตอาคม

</details>

**Role:** buff (self) · applies status ailment

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Effect radius (Unity units)** (`Radius`): `MathUtil.DisplayMeterToDistance(3)`; `MathUtil.DisplayMeterToDistance(3)`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 116

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (3 paths)

- set `ActionRange` = `-1` = -1
- set `Radius` = `MathUtil.DisplayMeterToDistance(3)`

**`ActionStart`** (5 paths)

- set `SkillIndividualFlag` = `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116).isBreak` — when !PlayerAttackBase.IsBlank(this) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)

**`ActionHit`** (4 paths)

- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116), 0)` — when TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- calls `MagicProtectionBuf..ctor` = `.ctor(Lv, PlayerActionManagerBase.get_PlayerStatus(), UnityEngine.Component.get_transform(actarAction))` — when UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new MagicProtectionBuf, 0)` — when UnityEngine.Object.op_Inequality(actarAction)

**`Damaged`** (37 paths)

- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(0, 0)` — when !SkillActionBase.op_Equality(action) AND (EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) & 0xfffffffe) eq 14 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116) ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116).effective ne 0 AND UnityEngine.Object.op_Inequality(actor) AND damageData.AbnormalType eq -1 OR !SkillActionBase.op_Equality(action) AND !UnityEngine.Object.op_Inequality(actor) AND (EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) & 0xfffffffe) eq 14 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116) ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 116).effective ne 0 AND damageData.AbnormalType eq -1

**`InitializeOthers`** (3 paths)

- set `ActionRange` = `-1` = -1
- set `Radius` = `MathUtil.DisplayMeterToDistance(3)`

</details>

**Buffs**

**Buff `MagicProtectionBuf`**
- Buff hook methods: `CheckTakeSkip`, `DamageTransfer`, `KadarElexioDamage`, `Next`, `NextSkip`, `OnCall`, `Reinstallation`, `get_BufEffectTakeId`
- `Value` = `((((((BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 12) * 10) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 11)) + int(((BonusManager.GetBonusPercentValue(PlayerStatusBase.get_BonusManager(), 13) + 1) * int((((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).dbData.Stable * EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Function) / 100) * (status.Int / 7.5)))))) lt 0x1869f ? (((BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 12) * 10) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 11)) + int(((BonusManager.GetBonusPercentValue(PlayerStatusBase.get_BonusManager(), 13) + 1) * int((((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).dbData.Stable * EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Function) / 100) * (status.Int / 7.5)))))) : 0x1869f) gt 100 ? ((((BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 12) * 10) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 11)) + int(((BonusManager.GetBonusPercentValue(PlayerStatusBase.get_BonusManager(), 13) + 1) * int((((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).dbData.Stable * EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Function) / 100) * (status.Int / 7.5)))))) lt 0x1869f ? (((BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 12) * 10) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 11)) + int(((BonusManager.GetBonusPercentValue(PlayerStatusBase.get_BonusManager(), 13) + 1) * int((((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).dbData.Stable * EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Function) / 100) * (status.Int / 7.5)))))) : 0x1869f) : 100))` _(when BuffEffectActive ne 0; effective ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MotionSpeed | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |
| MobLastDamageRateUnique | 30 | 35 | 40 | 45 | 50 | 55 | 60 | 65 | 70 | 75 |

- Buff fields set in the constructor (all recovered):
  - `isFirstSend` = `1` = 1
  - `flag` = `514` = 514
  - `countViewType` = `9` = 9
  - `outsideEffectTakeUid` = `0xfffffffeffffffff` = -1
  - `actor` = `actor`
  - `bufferEffect` = `bufferEffectManager`
  - `placePos` = `UnityEngine.Transform.get_position(actor).x`
  - `placePos.y` = `UnityEngine.Transform.get_position(actor).y`
  - `placePos.z` = `UnityEngine.Transform.get_position(actor).z`
  - `size` = `MathUtil.DisplayMeterToDistance(3)`
  - `motionSpeed` = `int((Lv * 2.5))` → Lv1..10 [2, 5, 7, 10, 12, 15, 17, 20, 22, 25]
  - `damageCut` = `(((Lv << 2) + lv) + 25)` → Lv1..10 [30, 35, 40, 45, 50, 55, 60, 65, 70, 75]
  - `barrierHp` = `(((((BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 12) * 10) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 11)) + int(((BonusManager.GetBonusPercentValue(PlayerStatusBase.get_BonusManager(), 13) + 1) * int((((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).dbData.Stable * EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Function) / 100) * (status.Int / 7.5)))))) lt 0x1869f ? (((BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 12) * 10) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 11)) + int(((BonusManager.GetBonusPercentValue(PlayerStatusBase.get_BonusManager(), 13) + 1) * int((((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).dbData.Stable * EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Function) / 100) * (status.Int / 7.5)))))) : 0x1869f) gt 100 ? ((((BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 12) * 10) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 11)) + int(((BonusManager.GetBonusPercentValue(PlayerStatusBase.get_BonusManager(), 13) + 1) * int((((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).dbData.Stable * EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Function) / 100) * (status.Int / 7.5)))))) lt 0x1869f ? (((BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 12) * 10) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 11)) + int(((BonusManager.GetBonusPercentValue(PlayerStatusBase.get_BonusManager(), 13) + 1) * int((((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).dbData.Stable * EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Function) / 100) * (status.Int / 7.5)))))) : 0x1869f) : 100)`
  - `maxBarrierHp` = `(((((BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 12) * 10) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 11)) + int(((BonusManager.GetBonusPercentValue(PlayerStatusBase.get_BonusManager(), 13) + 1) * int((((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).dbData.Stable * EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Function) / 100) * (status.Int / 7.5)))))) lt 0x1869f ? (((BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 12) * 10) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 11)) + int(((BonusManager.GetBonusPercentValue(PlayerStatusBase.get_BonusManager(), 13) + 1) * int((((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).dbData.Stable * EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Function) / 100) * (status.Int / 7.5)))))) : 0x1869f) gt 100 ? ((((BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 12) * 10) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 11)) + int(((BonusManager.GetBonusPercentValue(PlayerStatusBase.get_BonusManager(), 13) + 1) * int((((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).dbData.Stable * EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Function) / 100) * (status.Int / 7.5)))))) lt 0x1869f ? (((BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 12) * 10) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 11)) + int(((BonusManager.GetBonusPercentValue(PlayerStatusBase.get_BonusManager(), 13) + 1) * int((((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).dbData.Stable * EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Function) / 100) * (status.Int / 7.5)))))) : 0x1869f) : 100)`
- Hook `Updata`: `isFirstSend`=0; `effective`=1; `countViewType`=9; `countViewType`=13
- Hook `Reinstallation`: `isFirstSend`=1; `flag`=(flag & 0xfffff7ff); `isBreak`=0; `barrierHp`=int((maxBarrierHp * 0.01))
- Hook `KadarElexioDamage`: `barrierHp`=barrierHp
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:MagicProtectionBuf$$.ctor<-MagicProtectionAction$$ActionHit` (no direct constructor call in the skill's own code).
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

<details><summary>Effect applied in `MaximuyzerAction$$ActionStart` (39 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 101, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 116, stkp(-56), 0) & 1) ne 0` AND `+-0x34 ls 0`
  - returns `0x165d8dc(this, 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
  - set `CastTime` = `0`
  - set `WeaponType` = `15`
  - set `SkillIndividualFlag` = `((SkillIndividualFlag | 4) | 1)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - set `isEnchantStartMotion` = `0`
  - calls `PlayerAttackBase$$CheckSkillParamFlag`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `MagicProtectionBuf$$InactiveNextMaximuyzershortening`, `PlayerAttackBase$$ActionStart`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `(SkillBufferManager.TryGetBuf(?blr, 101, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 116, stkp(-56), 0) & 1) ne 0` AND `+-0x34 hi 0`
  - returns `0x165d8dc(this, 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
  - set `CastTime` = `0`
  - set `WeaponType` = `15`
  - set `SkillIndividualFlag` = `(SkillIndividualFlag | 4)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$CheckSkillParamFlag`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `MagicProtectionBuf$$InactiveNextMaximuyzershortening`, `PlayerAttackBase$$ActionStart`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `(SkillBufferManager.TryGetBuf(?blr, 101, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 116, stkp(-56), 0) & 1) ne 0` AND `+-0x34 ls 0`
  - returns `0x165d8dc(this, 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
  - set `CastTime` = `(((20 - Lv) - max(((5 - Lv) * 0.5), 0)) - [TryGetBuf.out2()+0x10])`
  - set `WeaponType` = `15`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - set `isEnchantStartMotion` = `0`
  - set `SkillIndividualFlag` = `(SkillIndividualFlag | 1)`
  - calls `PlayerAttackBase$$CheckSkillParamFlag`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ActionStart`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`
- when `(SkillBufferManager.TryGetBuf(?blr, 101, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 116, stkp(-56), 0) & 1) ne 0` AND `+-0x34 hi 0`
  - returns `0x165d8dc(this, 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
  - set `CastTime` = `(((20 - Lv) - max(((5 - Lv) * 0.5), 0)) - [TryGetBuf.out2()+0x10])`
  - set `WeaponType` = `15`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$CheckSkillParamFlag`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ActionStart`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `(SkillBufferManager.TryGetBuf(?blr, 101, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 116, stkp(-56), 0) & 1) eq 0` AND `+-0x34 ls 0`
  - returns `0x165d8dc(this, 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
  - set `CastTime` = `(((20 - Lv) - max(((5 - Lv) * 0.5), 0)) - [TryGetBuf.out2()+0x10])`
  - set `WeaponType` = `15`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - set `isEnchantStartMotion` = `0`
  - set `SkillIndividualFlag` = `(SkillIndividualFlag | 1)`
  - calls `PlayerAttackBase$$CheckSkillParamFlag`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ActionStart`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`
- when `(SkillBufferManager.TryGetBuf(?blr, 101, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 116, stkp(-56), 0) & 1) eq 0` AND `+-0x34 hi 0`
  - returns `0x165d8dc(this, 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
  - set `CastTime` = `(((20 - Lv) - max(((5 - Lv) * 0.5), 0)) - [TryGetBuf.out2()+0x10])`
  - set `WeaponType` = `15`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$CheckSkillParamFlag`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ActionStart`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `(SkillBufferManager.TryGetBuf(?blr, 101, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 116, stkp(-56), 0) & 1) ne 0` AND `+-0x34 ls 0`
  - returns `0x165d8dc(this, 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
  - set `CastTime` = `0`
  - set `SkillIndividualFlag` = `((SkillIndividualFlag | 4) | 1)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - set `isEnchantStartMotion` = `0`
  - calls `PlayerAttackBase$$CheckSkillParamFlag`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `MagicProtectionBuf$$InactiveNextMaximuyzershortening`, `PlayerAttackBase$$ActionStart`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `(SkillBufferManager.TryGetBuf(?blr, 101, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 116, stkp(-56), 0) & 1) ne 0` AND `+-0x34 hi 0`
  - returns `0x165d8dc(this, 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
  - set `CastTime` = `0`
  - set `SkillIndividualFlag` = `(SkillIndividualFlag | 4)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$CheckSkillParamFlag`, `PlayerAttackBase$$ExistWeaponType`, `PlayerAttackBase$$ExistWeaponType`, `MagicProtectionBuf$$InactiveNextMaximuyzershortening`, `PlayerAttackBase$$ActionStart`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`

</details>

<details><summary>Effect applied in `MaximuyzerSwitchingBuff$$ConverterMaximuyzerSwitching` (32 guarded paths)</summary>

- when `(GemCartBufferManager.ContainsBuffer(?blr, 404, comboManager, skillActionManager) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 116, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(101) ge 1`
  - returns `110`
  - calls `SkillComboManager$$CheckEnableFirstSkillId`, `SkillComboManager$$get_ComboStarted`, `SkillComboState$$get_CurrentSkillId`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual SkillActionManagerBase.get_CurrentSkill`, `virtual CharacterActionManagerBase.get_IsLocalDead`
- when `(GemCartBufferManager.ContainsBuffer(?blr, 404, comboManager, skillActionManager) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 116, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(101) ge 1`
  - returns `101`
  - calls `SkillComboManager$$CheckEnableFirstSkillId`, `SkillComboManager$$get_ComboStarted`, `SkillComboState$$get_CurrentSkillId`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual SkillActionManagerBase.get_CurrentSkill`, `virtual CharacterActionManagerBase.get_IsLocalDead`
- when `(GemCartBufferManager.ContainsBuffer(?blr, 404, comboManager, skillActionManager) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 116, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(101) ge 1`
  - returns `101`
  - calls `SkillComboManager$$CheckEnableFirstSkillId`, `SkillComboManager$$get_ComboStarted`, `SkillComboState$$get_CurrentSkillId`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual SkillActionManagerBase.get_CurrentSkill`, `virtual CharacterActionManagerBase.get_IsLocalDead`
- when `(GemCartBufferManager.ContainsBuffer(?blr, 404, comboManager, skillActionManager) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 116, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(101) ge 1`
  - returns `skillId`
  - calls `SkillComboManager$$CheckEnableFirstSkillId`, `SkillComboManager$$get_ComboStarted`, `SkillComboState$$get_CurrentSkillId`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual SkillActionManagerBase.get_CurrentSkill`, `virtual CharacterActionManagerBase.get_IsLocalDead`
- when `(GemCartBufferManager.ContainsBuffer(?blr, 404, comboManager, skillActionManager) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 116, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(101) ge 1`
  - returns `101`
  - calls `SkillComboManager$$CheckEnableFirstSkillId`, `SkillComboManager$$get_ComboStarted`, `SkillComboState$$get_CurrentSkillId`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`, `virtual SkillActionManagerBase.get_CurrentSkill`
- when `(GemCartBufferManager.ContainsBuffer(?blr, 404, comboManager, skillActionManager) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 116, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(101) ge 1`
  - returns `101`
  - calls `SkillComboManager$$CheckEnableFirstSkillId`, `SkillComboManager$$get_ComboStarted`, `SkillComboState$$get_CurrentSkillId`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`
- when `(GemCartBufferManager.ContainsBuffer(?blr, 404, comboManager, skillActionManager) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 116, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(101) lt 1`
  - returns `skillId`
  - calls `SkillComboManager$$CheckEnableFirstSkillId`, `SkillComboManager$$get_ComboStarted`, `SkillComboState$$get_CurrentSkillId`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`
- when `(GemCartBufferManager.ContainsBuffer(?blr, 404, comboManager, skillActionManager) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 116, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `skillId`
  - calls `SkillComboManager$$CheckEnableFirstSkillId`, `SkillComboManager$$get_ComboStarted`, `SkillComboState$$get_CurrentSkillId`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`

</details>

<details><summary>Effect applied in `MobaPlayerSecondaryStatus$$GetMotionSpeed` (72 guarded paths)</summary>

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

<details><summary>Effect applied in `PlayerSecondaryStatus$$GetCalcMotionSpeed` (108 guarded paths)</summary>

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

- `MaximuyzerAction$$ActionStart (TryGetBuf)`
- `MaximuyzerSwitchingBuff$$ConverterMaximuyzerSwitching (TryGetBuf)`
- `MobAttackBase$$CalcLastDamage (TryGetBuf)`
- `MobaPlayerSecondaryStatus$$GetMotionSpeed (TryGetBuf)`
- `PlayerSecondaryStatus$$GetCalcMotionSpeed (TryGetBuf)`

---

### เวทมนตร์:เรเซอร์ (MagicLazer) · uid 120

<img src="../../icons/sk_120.png" width="40" alt="icon"> 
**Tree:** マジックスキル (`MagicSkill`, tier 5) · **Type:** Attack · **Max Lv:** 240 · **Weapons:** OneHandSword, Rod, MainMagictool · **Requires:** เวทมนตร์: ไฟนอล · **Client class:** `MagicLazerAction`

> สกิลที่ช่วยลดความซับซ้อนของเวทมนตร์
> ทำให้ผู้ใช้ปลดปล่อยพลังเวทย์ได้ตามทักษะที่มี
> เมื่อเปิดใช้พลังจะเพิ่มขึ้นตาม MP ที่เหลืออยู่
> มีโอกาสเล็กน้อยที่จะทำให้ติดภาวะผิดปกติตาม(ธาตุอาวุธ)
> และหลังเปิดใช้งานจะเพิ่มเวทเจาะเข้าของตัวเองเล็กน้อย

<details><summary>In-game level notes</summary>

- Lv14: *เวทเจาะเข้าเพิ่มขึ้นเล็กน้อย
- Lv15: *อัตราติดภาวะผิดปกติ 1.5 เท่า
- Lv10: *อัตราติดภาวะผิดปกติลดลงครึ่งหนึ่ง

</details>

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv * 75) + ((baseDEX lt 0 ? (baseDEX + 1) : baseDEX) >> 1))) + MagicLazerAction.GetAddSkillRate(this)) / 100)` — mainWeapon == Rod
- SkillRate × `(((((Lv * 75) + ((baseDEX lt 0 ? (baseDEX + 1) : baseDEX) >> 1))) + MagicLazerAction.GetAddSkillRate(this)) / 100)` — mainWeapon != Rod AND mainWeapon == OneHandSword OR mainWeapon != OneHandSword AND mainWeapon != Rod AND mainWeapon == Magictool OR mainWeapon != Magictool AND mainWeapon != OneHandSword AND mainWeapon != Rod

**Role:** attack (deals damage) · buff (self) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillRate` multiplies by (adds into): `(((((Lv * 75) + ((baseDEX lt 0 ? (baseDEX + 1) : baseDEX) >> 1))) + MagicLazerAction.GetAddSkillRate(this)) / 100)`

**Mechanics recovered from code**

- **Ailment chance (%)** (`abnormalRate`): `(Lv << 1)` → Lv1..10 [2, 4, 6, 8, 10, 12, 14, 16, 18, 20] _(when mainWeapon == Rod OR mainWeapon != Magictool AND mainWeapon != OneHandSword AND mainWeapon != Rod)_; `int(((Lv << 1) * 1.5))` → Lv1..10 [3, 6, 9, 12, 15, 18, 21, 24, 27, 30] _(when mainWeapon != OneHandSword AND mainWeapon != Rod AND mainWeapon == Magictool)_; `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] _(when mainWeapon != Rod AND mainWeapon == OneHandSword)_
- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 120

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (4 paths)

- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(21)`
- set `skillRate` = `((Lv * 75) + ((baseDEX lt 0 ? (baseDEX + 1) : baseDEX) >> 1))` — when mainWeapon == Rod
- set `abnormalRate` = `(Lv << 1)` → Lv1..10: [2, 4, 6, 8, 10, 12, 14, 16, 18, 20] — when mainWeapon == Rod OR mainWeapon != Magictool AND mainWeapon != OneHandSword AND mainWeapon != Rod
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`
- set `SkillIndividualFlag` = `((MagicLazerAction.GetAddSkillRate(this) // 5) + 100)`
- set `skillRate` = `(Lv * 75)` → Lv1..10: [75, 150, 225, 300, 375, 450, 525, 600, 675, 750] — when mainWeapon != Rod AND mainWeapon == OneHandSword OR mainWeapon != OneHandSword AND mainWeapon != Rod AND mainWeapon == Magictool OR mainWeapon != Magictool AND mainWeapon != OneHandSword AND mainWeapon != Rod
- set `abnormalRate` = `int(((Lv << 1) * 1.5))` → Lv1..10: [3, 6, 9, 12, 15, 18, 21, 24, 27, 30] — when mainWeapon != OneHandSword AND mainWeapon != Rod AND mainWeapon == Magictool
- set `abnormalRate` = `Lv` → Lv1..10: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] — when mainWeapon != Rod AND mainWeapon == OneHandSword

**`InitializeOthers`** (3 paths)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`

**`ActionPreparation`** (13 paths)

- set `isPaidMp` = `1` = 1 — when PlayerAttackBase.CheckSkillParamFlag(this, 1024) AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(120) OR !hasBuff(120) AND PlayerAttackBase.CheckSkillParamFlag(this, 1024) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.CheckSkillParamFlag(this, 1024) AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(120)
- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(120)` — when PlayerAttackBase.CheckSkillParamFlag(this, 1024) AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(120) OR !PlayerAttackBase.CheckSkillParamFlag(this, 1024) AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(120)
- set `Element` = `TryGetElemntType.elementType(PlayerActionManagerBase.get_PlayerStatus())` — when !PlayerAttackBase.CheckSkillParamFlag(this, 1024) AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(120) OR !PlayerAttackBase.CheckSkillParamFlag(this, 1024) AND !hasBuff(120) AND UnityEngine.Object.op_Inequality(actarAction)

**`calcPlayerToMobDamage`** (9 paths)

- template `AddRate[SkillRate]` = `((skillRate + MagicLazerAction.GetAddSkillRate(this)) / 100)`
- info `templates` = `1`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(12, abnormalRate, playerAction)` — when GemCartBufferManager.GetTalentElementType(PlayerStatusBase.get_GemCartBuffManager()) hi 8 AND PlayerAttackBase.checkAbnormalPercent(this, 12, abnormalRate, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 12, abnormalRate, playerAction) AND GemCartBufferManager.GetTalentElementType(PlayerStatusBase.get_GemCartBuffManager()) hi 8
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(12, 0)` — when GemCartBufferManager.GetTalentElementType(PlayerStatusBase.get_GemCartBuffManager()) hi 8 AND PlayerAttackBase.checkAbnormalPercent(this, 12, abnormalRate, playerAction)

**`OnMotionEnd`** (1 path)

- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(120, Lv, 10)`

**`UseChronosShift`** (1 path)

- set `SkillParam` = `(SkillParam | 0x2000)`

</details>

**Buffs**

**Buff `MagicLazerBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Duration: `10` s
- `MagicResistBreaker` = `(((isEquipRod & 1) ne 0 ? 15 : 10))` _(when BuffEffectActive ne 0)_
- `MagicResistBreaker` = `0` _(when BuffEffectActive eq 0)_
- Buff fields set in the constructor (all recovered):
  - `magicResistBreakerRate` = `((isEquipRod & 1) ne 0 ? 15 : 10)`
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0

<details><summary>Effect applied in `MagicLazerAction$$ActionPreparation` (12 guarded paths)</summary>

- always
  - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 120, 0, ?x3)`
  - set `isPaidMp` = `1`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$CheckSkillParamFlag`, `SkillBufferManager$$RemoveSelfBuffer`
- always
  - returns `SkillBufferManager.ContainsBuffer(?blr, 120, 0, ?x3)`
  - set `isPaidMp` = `1`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$CheckSkillParamFlag`
- always
  - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 120, 0, ?x3)`
  - set `Element` = `TryGetElemntType.out1()`
  - set `isPaidMp` = `1`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$CheckSkillParamFlag`, `DualBringerAction$$TryGetElemntType`, `SkillBufferManager$$RemoveSelfBuffer`
- always
  - returns `SkillBufferManager.ContainsBuffer(?blr, 120, 0, ?x3)`
  - set `Element` = `TryGetElemntType.out1()`
  - set `isPaidMp` = `1`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$CheckSkillParamFlag`, `DualBringerAction$$TryGetElemntType`
- always
  - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 120, 0, ?x3)`
  - set `Element` = `TryGetElemntType.out1()`
  - set `isPaidMp` = `1`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$CheckSkillParamFlag`, `DualBringerAction$$TryGetElemntType`, `SkillBufferManager$$RemoveSelfBuffer`
- always
  - returns `SkillBufferManager.ContainsBuffer(?blr, 120, 0, ?x3)`
  - set `Element` = `TryGetElemntType.out1()`
  - set `isPaidMp` = `1`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$CheckSkillParamFlag`, `DualBringerAction$$TryGetElemntType`
- always
  - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 120, 0, ?x3)`
  - set `Element` = `TryGetElemntType.out1()`
  - set `isPaidMp` = `1`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$CheckSkillParamFlag`, `DualBringerAction$$TryGetElemntType`, `SkillBufferManager$$RemoveSelfBuffer`
- always
  - returns `SkillBufferManager.ContainsBuffer(?blr, 120, 0, ?x3)`
  - set `Element` = `TryGetElemntType.out1()`
  - set `isPaidMp` = `1`
  - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$CheckSkillParamFlag`, `DualBringerAction$$TryGetElemntType`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `MagicLazerAction$$ActionPreparation (ContainsBuffer)`

---
