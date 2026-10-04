# PriestSkill (`PriestSkill`)

15 entries. See ../README.md for how to read these blocks.

### เบลส (Bless) · uid 833

<img src="../../icons/sk_833.png" width="40" alt="icon"> 
**Type:** Support · **Max Lv:** 15 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `BlessAction`

> ฟื้นฟู HP เล็กน้อยชั่วขณะ
> ปริมาณฟื้นฟูและระยะเวลาจะเพิ่มขึ้นตามเลเวล

<details><summary>In-game level notes</summary>

- Lv14: *INT มีผลต่อปริมาณการฟื้นฟู *ปริมาณ MATK มีผลต่อปริมาณการฟื้นฟู+1%

</details>

**Role:** buff (self) · buff (party / others)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `0` = 0

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 833

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (48 paths)

- set `ActionRange` = `-1` = -1
- set `CastTime` = `0` = 0
- set `count` = `((Lv eq 10 ? (((int((Lv / 3)) + 1) + int(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 837, 1) - 1) * 0.5))) + 1) : ((int((Lv / 3)) + 1) + int(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 837, 1) - 1) * 0.5)))) - 1)` — when Lv lo 2 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 837, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 837, 1) ge 2 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 837, 1) gt 0 AND mainWeapon == Rod OR Lv lo 2 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 837, 1) ge 2 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 837, 1) gt 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 837, 1) lt 1 AND mainWeapon == Rod OR Lv lo 2 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 837, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 837, 1) ge 2 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 837, 1) gt 0 AND mainWeapon != Rod
- set `count` = `((int((Lv / 3)) + 1) - 1)` → Lv1..10: [0, 0, 1, 1, 1, 2, 2, 2, 3, 3] — when Lv lo 2 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 837, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 837, 1) ge 2 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 837, 1) le 0 AND mainWeapon == Rod OR Lv lo 2 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 837, 1) ge 2 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 837, 1) le 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 837, 1) lt 1 AND mainWeapon == Rod OR Lv lo 2 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 837, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 837, 1) ge 2 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 837, 1) le 0 AND mainWeapon != Rod

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (1 path)

- calls `BlessBuf..ctor` = `.ctor(Lv, (count * 5))`
- calls `SkillBufferManager.AddBuffer` = `AddBuffer(new BlessBuf, 0)`

</details>

**Buffs**

**Buff `BlessBuf`**
- Duration: `time` s
- Buff fields set in the constructor (all recovered):
  - `isViewSelfIcon` = `0`
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `SetViewSelfIcon`: `isViewSelfIcon`=(flag & 1)
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:BlessBuf$$.ctor<-BlessAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

---

### โฮลี่ฟิสท์ (HollyFist) · uid 834

<img src="../../icons/sk_834.png" width="40" alt="icon"> 
**Type:** Attack · **Max Lv:** 15 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `HolyFistAction`

> อัดศัตรูด้วยหมัดพลังแสง
> สร้างความเสียหายทางกายภาพและเวทพร้อมกัน
> สกิลนี้เป็น[สกิลกายภาพ]

<details><summary>In-game level notes</summary>

- Lv14: *พลังเวท×2 *พลังเวทจะเพิ่มมากกว่าค่า INT ของตัวเอง
- Lv16: *พลังกายภาพ×2 *พลังกายภาพจะเพิ่มมากกว่าค่า STR ของตัวเอง

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.55 | 0.6 | 0.65 | 0.7 | 0.75 | 0.8 | 0.85 | 0.9 | 0.95 | 1 |
| SkillRate × | 0.55 | 0.6 | 0.65 | 0.7 | 0.75 | 0.8 | 0.85 | 0.9 | 0.95 | 1 |
| Flat dmg + | 55 | 60 | 65 | 70 | 75 | 80 | 85 | 90 | 95 | 100 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((((Lv + (Lv << 2)) + 50) / 100))`
- SkillRate × `((((((Lv + (Lv << 2)) + 50) + ((Lv + (Lv << 2)) + 50)) + status.Str) / 100))`

**Role:** attack (deals damage)

The skill builds 2 separate damage templates (each is a full hit with its own crit roll). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv + (Lv << 2)) + 50))`
- `SkillRate` multiplies by (adds into): `((((Lv + (Lv << 2)) + 50) / 100))` | `((((((Lv + (Lv << 2)) + 50) + ((Lv + (Lv << 2)) + 50)) + status.Str) / 100))`
- `ExpRate` sets: `ExtensionMethod.ExSkillData.SkillDataExtentionMethod.GetTargetExpRate(1, PlayerAttackBase.get_ActionID(), MobActionManagerBase.get_MobBattleStatus(mobAction))`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 834

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (3 paths)

- set `Element` = `5` = 5
- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(ExistWeaponType.item(actarAction, 16))`
- set `magicSkillRate` = `(((Lv + (Lv << 2)) + 50) / 100)` → Lv1..10: [0.55, 0.6, 0.65, 0.7, 0.75, 0.8, 0.85, 0.9, 0.95, 1.0]
- set `physicsSkillRate` = `(((((Lv + (Lv << 2)) + 50) + ((Lv + (Lv << 2)) + 50)) + status.Str) / 100)`
- set `fixAddDamage` = `((Lv + (Lv << 2)) + 50)` → Lv1..10: [55, 60, 65, 70, 75, 80, 85, 90, 95, 100]
- set `ActionRange` = `weaponRange`
- set `physicsSkillRate` = `(((Lv + (Lv << 2)) + 50) / 100)` → Lv1..10: [0.55, 0.6, 0.65, 0.7, 0.75, 0.8, 0.85, 0.9, 0.95, 1.0]
- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(ExistWeaponType.item(actarAction, 14))`
- set `magicSkillRate` = `(((((Lv + (Lv << 2)) + 50) + ((Lv + (Lv << 2)) + 50)) + status.Int) / 100)`

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`calcPlayerToMobDamage`** (96 paths)

- template `AddRate[SkillRate]` = `magicSkillRate`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- template `SetRate[ExpRate]` = `ExtensionMethod.ExSkillData.SkillDataExtentionMethod.GetTargetExpRate(1, PlayerAttackBase.get_ActionID(), MobActionManagerBase.get_MobBattleStatus(mobAction))`
- template `AddRate[SkillRate]` = `physicsSkillRate`
- calls `PlayerAttackBase.SetBufferConstantDamage` = `SetBufferConstantDamage(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 2)`
- info `templates` = `2`

**`OnInheritance`** (1 path)

- set `IsInheritance` = `1` = 1

</details>

---

### ร็อดสทับ (RodStub) · uid 841

<img src="../../icons/sk_841.png" width="40" alt="icon"> 
**Type:** Attack · **Max Lv:** 15 · **Weapons:** Rod · **Client class:** `RodStubAction`

> ตีอย่างแรงด้วยไม้เท้า
> ยิ่ง STR สูงเท่าไหร่ก็จะยิ่งมองข้ามพลังป้องกันของเป้าหมาย
> มีโอกาสทำให้เป้าหมาย[ผงะ]

<details><summary>In-game level notes</summary>

- Lv17: *อัตราติดผงะ+25%

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((((Lv + 190) + status.Str)) / 100)`

**Role:** attack (deals damage)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(100)`
- `SkillRate` multiplies by (adds into): `((((Lv + 190) + status.Str)) / 100)`

**Mechanics recovered from code**

- **Effect percent** (`percent`): `(((Lv + (Lv << 2)) + 25) + 25)` → Lv1..10 [55, 60, 65, 70, 75, 80, 85, 90, 95, 100] _(when subWeapon == Shield)_; `((Lv + (Lv << 2)) + 25)` → Lv1..10 [30, 35, 40, 45, 50, 55, 60, 65, 70, 75] _(when subWeapon != Shield)_
- **Resistance value** (`resist`): `((baseSTR // 10) + 25)`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 841

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (2 paths)

- set `Element` = `7` = 7
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(7)`
- set `fixAddDamage` = `100` = 100
- set `skillRate` = `((Lv + 190) + status.Str)`
- set `percent` = `(((Lv + (Lv << 2)) + 25) + 25)` → Lv1..10: [55, 60, 65, 70, 75, 80, 85, 90, 95, 100] — when subWeapon == Shield
- set `resist` = `((baseSTR // 10) + 25)`
- set `percent` = `((Lv + (Lv << 2)) + 25)` → Lv1..10: [30, 35, 40, 45, 50, 55, 60, 65, 70, 75] — when subWeapon != Shield

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`calcPlayerToMobDamage`** (8 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(1, percent, playerAction)`
- calls `AbnormalStateManager.GetDefaultAnbormalStateTime` = `GetDefaultAnbormalStateTime()` — when PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction)
- info `templates` = `1`

</details>

---

### กลอเรีย (Gloria) · uid 835

<img src="../../icons/sk_835.png" width="40" alt="icon"> 
**Type:** Support · **Max Lv:** 35 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เบลส · **Flags:** MercenaryCanUseSkill · **Client class:** `GloriaAction`

> เพิ่ม DEF/MDEF ในระยะเวลาสั้นๆ
> และเพิ่มการฟื้นฟู  Guard ขณะติดตั้งโล่

<details><summary>In-game level notes</summary>

- Lv14: *การฟื้นฟู Guard ของผู้ที่ใช้โล่จะได้รับผลจากการเพิ่มขึ้นของสกิลนี้

</details>

**Role:** buff (self) · buff (party / others)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 835

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (2 paths)

- set `ActionRange` = `-1` = -1
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`
- set `guard` = `(((Lv >> 1) + 5) + 5)` → Lv1..10: [10, 11, 11, 12, 12, 13, 13, 14, 14, 15] — when mainWeapon == Rod
- set `guard` = `((Lv >> 1) + 5)` → Lv1..10: [5, 6, 6, 7, 7, 8, 8, 9, 9, 10] — when mainWeapon != Rod

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (1 path)

- calls `GloriaBuf..ctor` = `.ctor(Lv, guard)`
- calls `SkillBufferManager.AddBuffer` = `AddBuffer(new GloriaBuf, 0)`

</details>

**Buffs**

**Buff `GloriaBuf`**
- Duration: `30` s
- `GuardRate` = `(guard)` _(when BuffEffectActive ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| DefRate | 51 | 56 | 63 | 74 | 87 | 104 | 123 | 146 | 171 | 200 |
| MdefRate | 51 | 56 | 63 | 74 | 87 | 104 | 123 | 146 | 171 | 200 |

- Buff fields set in the constructor (all recovered):
  - `defUpRate` = `(int(((Lv * Lv) * 1.5)) + 50)` → Lv1..10 [51, 56, 63, 74, 87, 104, 123, 146, 171, 200]
  - `guardUp` = `guard`
  - `isViewSelfIcon` = `0`
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `SetViewSelfIcon`: `isViewSelfIcon`=(flag & 1)
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:GloriaBuf$$.ctor<-GloriaAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

<details><summary>Effect applied in `PetStatus$$get_GuardDelay` (12 guarded paths)</summary>

- when `TryGetValue.out2() ne 0`
  - returns `max((((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 27, 0, ?x3) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + 10)))) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) lt 90 ? ((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 27, 0, ?x3) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + 10)))) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) : 90), 0)`
  - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `ItemData$$get_BattleCustomize`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`
- when `TryGetValue.out2() ne 0`
  - returns `max((((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + 10))) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) lt 90 ? ((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + 10))) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) : 90), 0)`
  - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `ItemData$$get_BattleCustomize`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`
- when `TryGetValue.out2() ne 0`
  - returns `max((((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 27, 0, ?x3) + (CharacterActionManagerBase.get_Size() + 10))) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) lt 90 ? ((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 27, 0, ?x3) + (CharacterActionManagerBase.get_Size() + 10))) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) : 90), 0)`
  - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `ItemData$$get_BattleCustomize`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`
- when `TryGetValue.out2() ne 0`
  - returns `max((((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (CharacterActionManagerBase.get_Size() + 10)) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) lt 90 ? ((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (CharacterActionManagerBase.get_Size() + 10)) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) : 90), 0)`
  - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `ItemData$$get_BattleCustomize`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`
- when `TryGetValue.out2() ne 0`
  - returns `max((((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 27, 0, ?x3) + (CharacterActionManagerBase.get_Size() + 10))) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) lt 90 ? ((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 27, 0, ?x3) + (CharacterActionManagerBase.get_Size() + 10))) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) : 90), 0)`
  - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `ItemData$$get_BattleCustomize`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`
- when `TryGetValue.out2() ne 0`
  - returns `max((((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (CharacterActionManagerBase.get_Size() + 10)) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) lt 90 ? ((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (CharacterActionManagerBase.get_Size() + 10)) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) : 90), 0)`
  - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `ItemData$$get_BattleCustomize`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`
- always
  - returns `max((((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 27, 0, ?x3) + 10)) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) lt 90 ? ((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 27, 0, ?x3) + 10)) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) : 90), 0)`
  - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `ItemData$$get_BattleCustomize`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- always
  - returns `max((((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + 10) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) lt 90 ? ((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + 10) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) : 90), 0)`
  - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `ItemData$$get_BattleCustomize`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `PetStatus$$get_GuardDelay (ContainsBuffer)`

---

### โฮลี่ไลท์ (HollyLight) · uid 836

<img src="../../icons/sk_836.png" width="40" alt="icon"> 
**Type:** Attack · **Max Lv:** 35 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** โฮลี่ฟิสท์ · **Flags:** MercenaryCanUseSkill · **Client class:** `HolyLightActin`

> ลงทัณฑ์เหล่าร้ายด้วยพลังศักดิ์สิทธิ์
> ใช้เวทธาตุแสงสร้างความเสียหายกับเป้าหมาย
> และฟื้นฟู HP ของตัวเองเล็กน้อย

<details><summary>In-game level notes</summary>

- Lv14: *พลัง+100 *พลังจะเพิ่มมากกว่าค่า INT ของตัวเอง
- Lv15: *ขีดจำกัดปริมาณการฟื้นฟู HP จะเพิ่มมากกว่าค่า INT ของตัวเอง

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 1.15 | 1.3 | 1.45 | 1.6 | 1.75 | 1.9 | 2.05 | 2.2 | 2.35 | 2.5 |
| Flat dmg + | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv << 4) - Lv) + 100)) / 100)`

**Role:** attack (deals damage) · heal / recovery

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(200)`
- `SkillRate` multiplies by (adds into): `(((((Lv << 4) - Lv) + 100)) / 100)`

**Mechanics recovered from code**

- **HP recovery cap** (`maxHpRecovery`): `((baseINT * 10) + (Lv * 100))` _(when (mainWeapon==Magictool & 1) ne 0)_; `(Lv * 100)` → Lv1..10 [100, 200, 300, 400, 500, 600, 700, 800, 900, 1000]; `((baseINT * 10) + (Lv * 100))` _(when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0)_
- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`; `-1` = -1 _(when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0)_
- **HP recovered** (`hpRecovery`): `int(((status.MaxHp * 0.25) gt maxHpRecovery ? maxHpRecovery : (status.MaxHp * 0.25)))`

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 836

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (5 paths)

- set `Element` = `5` = 5
- set `fixAddDamage` = `200` = 200
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`
- set `skillRate` = `(((Lv << 4) - Lv) + 100)` → Lv1..10: [115, 130, 145, 160, 175, 190, 205, 220, 235, 250]
- set `maxHpRecovery` = `((baseINT * 10) + (Lv * 100))` — when (mainWeapon==Magictool & 1) ne 0
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`
- set `maxHpRecovery` = `(Lv * 100)` → Lv1..10: [100, 200, 300, 400, 500, 600, 700, 800, 900, 1000]
- set `skillRate` = `((((Lv << 4) - Lv) + 100) + ((status.Int << 1) + 100))`

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`ActionStart`** (3 paths)

- set `hpRecovery` = `int(((status.MaxHp * 0.25) gt maxHpRecovery ? maxHpRecovery : (status.MaxHp * 0.25)))`

**`calcPlayerToMobDamage`** (2 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- info `templates` = `1`

**`InitializeEnchantedSpell`** (3 paths)

- set `CastTime` = `-1` = -1 — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0
- set `fixAddDamage` = `200` = 200 — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0
- set `skillRate` = `(((Lv << 4) - Lv) + 100)` → Lv1..10: [115, 130, 145, 160, 175, 190, 205, 220, 235, 250] — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0
- set `maxHpRecovery` = `((baseINT * 10) + (Lv * 100))` — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0
- set `maxHpRecovery` = `(Lv * 100)` → Lv1..10: [100, 200, 300, 400, 500, 600, 700, 800, 900, 1000] — when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0

</details>

<details><summary>Effect applied in `MobaPlayerBattleManager$$StartHolyBiblePursuitAttack` (2 guarded paths)</summary>

- when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(836) ge 1`
  - returns `HolyBibleBuf.OnAction(TryGetBuf.out2(), 0, ?x2, ?x3)`
  - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`, `SkillBufferDataBase$$GetParam`, `EquipItemData$$get_SubWeapon`, `MathUtil$$CheckPercent`, `SkillFactory$$CreateSkill`, `SkillActionBase$$Initialize`
- when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(836) lt 1`
  - returns `SkillLv(836)`
  - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`, `SkillBufferDataBase$$GetParam`, `EquipItemData$$get_SubWeapon`, `MathUtil$$CheckPercent`, `SkillFactory$$CreateSkill`

</details>

<details><summary>Effect applied in `PlayerBattleManager$$StartHolyBiblePursuitAttack` (2 guarded paths)</summary>

- when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(836) ge 1`
  - returns `HolyBibleBuf.OnAction(TryGetBuf.out2(), 0, ?x2, ?x3)`
  - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`, `SkillBufferDataBase$$GetParam`, `EquipItemData$$get_SubWeapon`, `MathUtil$$CheckPercent`, `SkillFactory$$CreateSkill`, `SkillActionBase$$Initialize`
- when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(836) lt 1`
  - returns `SkillLv(836)`
  - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`, `SkillBufferDataBase$$GetParam`, `EquipItemData$$get_SubWeapon`, `MathUtil$$CheckPercent`, `SkillFactory$$CreateSkill`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `MobaPlayerBattleManager$$StartHolyBiblePursuitAttack (GetSkillLv)`
- `PlayerBattleManager$$StartHolyBiblePursuitAttack (GetSkillLv)`

---

### เอ็กซอร์ซิสต์ (Exorcism) · uid 842

<img src="../../icons/sk_842.png" width="40" alt="icon"> 
**Type:** Attack · **Max Lv:** 35 · **Weapons:** Rod, Shield · **Requires:** โฮลี่ไลท์ · **Client class:** `ExorcismAction`

> โจมตีด้วยเวทมนตร์ธาตุแสงไปบริเวณรอบๆ
> ลด MP ที่ใช้ในสกิลถัดไปลงครึ่งหนึ่ง
> 
> ถ้าใช้กับธาตุมืดจะทรงพลังมากยิ่งขึ้น
> มีโอกาสทำให้ "ตาลาย/ตาพร่า/หวาดกลัว" อย่างใดอย่างหนึ่ง

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((target.(5) eq 6 ? ((((Lv * 20) + (status.Str * 0.5))) + 400) : (((Lv * 20) + (status.Str * 0.5)))) / 100)`
- SkillRate × `((target.(5) eq 6 ? ((((Lv * 20) + (status.Str * 0.5))) + 400) : (((Lv * 20) + (status.Str * 0.5)))) / 100)`
- Flat dmg + `(target.(5) eq 6 ? (((Lv * 10)) + 100) : ((Lv * 10)))`
- Flat dmg + `(target.(5) eq 6 ? (((Lv * 10)) + 100) : ((Lv * 10)))`

**Role:** attack (deals damage) · buff (self)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(target.(5) eq 6 ? (((Lv * 10)) + 100) : ((Lv * 10)))`
- `SkillRate` multiplies by (adds into): `((target.(5) eq 6 ? ((((Lv * 20) + (status.Str * 0.5))) + 400) : (((Lv * 20) + (status.Str * 0.5)))) / 100)`

**Mechanics recovered from code**

- **Effect percent** (`percent`): `(Lv * 3)` → Lv1..10 [3, 6, 9, 12, 15, 18, 21, 24, 27, 30]
- **Cast time modifier** (`CastTime`): `0` = 0; `-1` = -1 _(when (isPlayer & 1) ne 0)_

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 842

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `Element` = `5` = 5
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(100)`
- set `skillRate` = `((Lv * 20) + (status.Str * 0.5))`
- set `fixAddDamage` = `(Lv * 10)` → Lv1..10: [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]
- set `percent` = `(Lv * 3)` → Lv1..10: [3, 6, 9, 12, 15, 18, 21, 24, 27, 30]
- set `CastTime` = `0` = 0

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`ActionStart`** (3 paths)

- set `isNemesisBuf` = `(hasBuff(844) & 1)` — when (SkillParam & 16) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !UnityEngine.Object.op_Inequality(actarAction) AND (SkillParam & 16) eq 0
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(842, Lv, Id)` — when (SkillParam & 16) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)

**`calcPlayerToMobDamage`** (18 paths)

- template `AddRate[SkillRate]` = `((target.Element eq 6 ? (skillRate + 400) : skillRate) / 100)`
- template `AddConstant[SkillConstantDamage]` = `(target.Element eq 6 ? (fixAddDamage + 100) : fixAddDamage)`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(abnormalType, (MobActionManagerBase.get_IsBoss(mobAction) ? (percent // 10) : percent), playerAction)` — when PlayerAttackBase.checkAbnormalPercent(this, abnormalType, ((MobActionManagerBase.get_IsBoss(mobAction) ? (percent // 10) : percent), playerAction) & 1) ne 0 AND target.Element eq 6 OR PlayerAttackBase.checkAbnormalPercent(this, abnormalType, (!MobActionManagerBase.get_IsBoss(mobAction) ? (percent // 10) : percent), playerAction) AND target.Element eq 6 OR PlayerAttackBase.checkAbnormalPercent(this, abnormalType, ((MobActionManagerBase.get_IsBoss(mobAction) ? (percent // 10) : percent), playerAction) & 1) ne 0 AND isNemesisBuf ne 0 AND target.Element ne 6
- calls `AbnormalStateManager.GetDefaultAnbormalStateTime` = `GetDefaultAnbormalStateTime()` — when PlayerAttackBase.checkAbnormalPercent(this, abnormalType, ((MobActionManagerBase.get_IsBoss(mobAction) ? (percent // 10) : percent), playerAction) & 1) ne 0 AND target.Element eq 6 OR PlayerAttackBase.checkAbnormalPercent(this, abnormalType, ((MobActionManagerBase.get_IsBoss(mobAction) ? (percent // 10) : percent), playerAction) & 1) ne 0 AND isNemesisBuf ne 0 AND target.Element ne 6
- info `templates` = `1`

**`OnInheritance`** (1 path)

- set `IsInheritance` = `1` = 1

**`InitializeEnchantedSpell`** (2 paths)

- set `CastTime` = `-1` = -1 — when (isPlayer & 1) ne 0

</details>

**Buffs**

**Buff `ExorcismBuf`**
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

- `PlayerAttackBase$$CalcCostMp (ContainsBuffer)`
- `PlayerAttackBase$$RemoveAfterSkillBuf (ContainsBuffer)`

---

### เอนเชนส์เบลส (BlessStrengthen) · uid 837

<img src="../../icons/sk_837.png" width="40" alt="icon"> 
**Type:** Mastery · **Max Lv:** 125 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** กลอเรีย · **Client class:** `BlessStrengthen` (passive mastery)

> เพิ่มพลังฟื้นฟูของ[เบลส]
> ในกรณีที่มีเบลสเลเวล 10
> จะเพิ่มระยะเวลา, ปริมาณที่ฟื้นฟู และโบนัสไม้เท้าให้มากยิ่งขึ้น

<details><summary>In-game level notes</summary>

- Lv14: *ปริมาณ MATK มีผลต่อปริมาณการฟื้นฟู+1% ในกรณีที่สกิลเลเวลของเบลสเป็น 10 INT มีผลต่อปริมาณการฟื้นฟู

</details>

**Role:** passive mastery

<details><summary>Effect applied in `BlessAction$$OnInitialize` (48 guarded paths)</summary>

- when `SkillLv(837) gt 0` AND `Lv lo 2` AND `SkillLv(837) ge 2` AND `SkillLv(837) ge 1`
  - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
  - set `ActionRange` = `-1`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CastTime` = `0`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - set `count` = `((Lv eq 10 ? (((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5))) + 1) : ((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5)))) - 1)`
  - calls `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$CalcMotionSpeed`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `SkillLv(837) gt 0` AND `Lv lo 2` AND `SkillLv(837) ge 2` AND `SkillLv(837) ge 1`
  - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
  - set `ActionRange` = `-1`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CastTime` = `0`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - set `count` = `((Lv eq 10 ? (((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5))) + 1) : ((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5)))) - 1)`
  - calls `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$CalcMotionSpeed`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `SkillLv(837) gt 0` AND `Lv lo 2` AND `SkillLv(837) ge 2` AND `SkillLv(837) lt 1`
  - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
  - set `ActionRange` = `-1`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CastTime` = `0`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - set `count` = `((Lv eq 10 ? (((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5))) + 1) : ((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5)))) - 1)`
  - calls `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$CalcMotionSpeed`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `SkillLv(837) gt 0` AND `Lv lo 2` AND `SkillLv(837) ge 2` AND `SkillLv(837) lt 1`
  - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
  - set `ActionRange` = `-1`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CastTime` = `0`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - set `count` = `((Lv eq 10 ? (((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5))) + 1) : ((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5)))) - 1)`
  - calls `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$CalcMotionSpeed`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `SkillLv(837) gt 0` AND `Lv lo 2` AND `SkillLv(837) ge 2` AND `SkillLv(837) ge 1`
  - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
  - set `ActionRange` = `-1`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CastTime` = `0`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - set `count` = `((Lv eq 10 ? (((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5))) + 1) : ((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5)))) - 1)`
  - calls `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$CalcMotionSpeed`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `SkillLv(837) gt 0` AND `Lv lo 2` AND `SkillLv(837) ge 2` AND `SkillLv(837) lt 1`
  - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
  - set `ActionRange` = `-1`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CastTime` = `0`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - set `count` = `((Lv eq 10 ? (((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5))) + 1) : ((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5)))) - 1)`
  - calls `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$CalcMotionSpeed`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `SkillLv(837) gt 0` AND `Lv lo 2` AND `SkillLv(837) lt 2` AND `SkillLv(837) ge 1`
  - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
  - set `ActionRange` = `-1`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CastTime` = `0`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - set `count` = `((Lv eq 10 ? (((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5))) + 1) : ((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5)))) - 1)`
  - calls `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$CalcMotionSpeed`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- when `SkillLv(837) gt 0` AND `Lv lo 2` AND `SkillLv(837) lt 2` AND `SkillLv(837) ge 1`
  - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
  - set `ActionRange` = `-1`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CastTime` = `0`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - set `count` = `((Lv eq 10 ? (((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5))) + 1) : ((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5)))) - 1)`
  - calls `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$CalcMotionSpeed`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `BlessAction$$OnInitialize (GetSkillLv)`

---

### อีเธอร์บาเรีย (EtherCoat) · uid 838

<img src="../../icons/sk_838.png" width="40" alt="icon"> 
**Type:** Support · **Max Lv:** 125 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** โฮลี่ไลท์ · **Flags:** MercenaryCanUseSkill · **Client class:** `EtherCoatAction`

> กางบาเรียเพื่อดูดซับแรงจากการโจมตี
> เพิ่มความต้านทานสภาวะผิดปกติ[ผงะ]
> ในเวลาระยะเวลาสั้้นๆ

**Role:** buff (self) · buff (party / others)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 4, PlayerActionManagerBase.get_PlayerStatus())`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 838

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 4, PlayerActionManagerBase.get_PlayerStatus())`
- set `ActionRange` = `-1` = -1

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (1 path)

- calls `EtherCoatBuf..ctor` = `.ctor(Lv)`
- calls `SkillBufferManager.AddBuffer` = `AddBuffer(new EtherCoatBuf, 0)`

</details>

**Buffs**

**Buff `EtherCoatBuf`**
- Duration: `5` s

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| AbnormalRegist | 55 | 60 | 65 | 70 | 75 | 80 | 85 | 90 | 95 | 100 |
| MAtkUpRate | -8 | -8 | -8 | -7 | -7 | -7 | -6 | -6 | -6 | -5 |

- Buff fields set in the constructor (all recovered):
  - `isViewSelfIcon` = `0`
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `SetViewSelfIcon`: `isViewSelfIcon`=(flag & 1)
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:EtherCoatBuf$$.ctor<-EtherCoatAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

---

### โฮลี่ไบเบิ้ล (HolyBible) · uid 843

<img src="../../icons/sk_843.png" width="40" alt="icon"> 
**Type:** Buffer · **Max Lv:** 125 · **Weapons:** OneHandSword, Rod, Knuckle · **Requires:** เอ็กซอร์ซิสต์ · **Client class:** `HolyBibleAction`

> เพิ่มต้านทานธาตุมืดเล็กน้อยเป็นเวลา 10 นาที
> ถ้าสร้างความเสียหายด้วยเวทมนตร์ให้กับเป้าหมายที่ไม่ใช่ธาตุแสง
> มีโอกาสที่จะใช้โฮลี่ไลท์ที่เรียนรู้มาแล้วเพิ่ม
> *มีโอกาสที่จะสร้างความเสียหายให้ธาตุแสงด้วย

<details><summary>In-game level notes</summary>

- Lv10: *โฮลี่ไลท์ที่ใช้จะมีผลกับโบนัสไม้เท้า
- Lv15: *ลดเวลาที่จะใช้โฮลี่ไลท์อีกครั้งลงครึ่งหนึ่ง
- Lv17: *อัตราการใช้โฮลี่ไลท์จะเป็น 2 เท่า

</details>

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 843

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (4 paths)

- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(843, Lv, 0)` — when UnityEngine.Object.op_Inequality(actarAction) OR TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 843) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)

**`OnInheritance`** (1 path)

- set `IsInheritance` = `1` = 1

</details>

**Buffs**

**Buff `HolyBibleBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `Initialize`, `OnAction`, `get_ActivePersuit`, `get_CoolTime`
- Duration: `600` s

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Percent | 27 | 30 | 32 | 35 | 37 | 40 | 42 | 45 | 47 | 50 |
| ReceiveDarkElementDmgRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |

- Buff fields set in the constructor (all recovered):
  - `darkElementDmgRate` = `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `activePercent` = `(int((Lv * 2.5)) + 25)` → Lv1..10 [27, 30, 32, 35, 37, 40, 42, 45, 47, 50]
  - `coolTime` = `0`
- Hook `Initialize`: `playerStatus`=playerStatus
- Hook `Updata`: `LeftTime`=0; `coolTime`=0; `coolTime`=(coolTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
- Hook `OnAction`: `coolTime`=(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? ((20 - Lv) * 0.5) : (20 - Lv))

<details><summary>Effect applied in `MobaPlayerBattleManager$$StartHolyBiblePursuitAttack` (7 guarded paths)</summary>

- when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(836) ge 1`
  - returns `HolyBibleBuf.OnAction(TryGetBuf.out2(), 0, ?x2, ?x3)`
  - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`, `SkillBufferDataBase$$GetParam`, `EquipItemData$$get_SubWeapon`, `MathUtil$$CheckPercent`, `SkillFactory$$CreateSkill`, `SkillActionBase$$Initialize`
- when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(836) lt 1`
  - returns `SkillLv(836)`
  - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`, `SkillBufferDataBase$$GetParam`, `EquipItemData$$get_SubWeapon`, `MathUtil$$CheckPercent`, `SkillFactory$$CreateSkill`
- when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `SkillActionBase.op_Equality(SkillFactory.CreateSkill(22, 0, ?x2, ?x3), 0, 0, ?x3)`
  - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`, `SkillBufferDataBase$$GetParam`, `EquipItemData$$get_SubWeapon`, `MathUtil$$CheckPercent`, `SkillFactory$$CreateSkill`
- when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `MathUtil.CheckPercent((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 52, 0, ?x3) << ([EquipItemData.get_SubWeapon(?blr, 0, ?x2, ?x3)+0x38] eq 17 ? 1 : 0)), 0, ?x2, ?x3)`
  - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`, `SkillBufferDataBase$$GetParam`, `EquipItemData$$get_SubWeapon`, `MathUtil$$CheckPercent`
- when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `HolyBibleBuf.get_ActivePersuit(TryGetBuf.out2(), 0, ?x2, ?x3)`
  - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`
- when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `0x165db84`, `0x165df00`, `0x165df00`
- when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0)`
  - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`

</details>

<details><summary>Effect applied in `PlayerBattleManager$$StartHolyBiblePursuitAttack` (7 guarded paths)</summary>

- when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(836) ge 1`
  - returns `HolyBibleBuf.OnAction(TryGetBuf.out2(), 0, ?x2, ?x3)`
  - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`, `SkillBufferDataBase$$GetParam`, `EquipItemData$$get_SubWeapon`, `MathUtil$$CheckPercent`, `SkillFactory$$CreateSkill`, `SkillActionBase$$Initialize`
- when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(836) lt 1`
  - returns `SkillLv(836)`
  - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`, `SkillBufferDataBase$$GetParam`, `EquipItemData$$get_SubWeapon`, `MathUtil$$CheckPercent`, `SkillFactory$$CreateSkill`
- when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `SkillActionBase.op_Equality(SkillFactory.CreateSkill(22, 0, ?x2, ?x3), 0, 0, ?x3)`
  - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`, `SkillBufferDataBase$$GetParam`, `EquipItemData$$get_SubWeapon`, `MathUtil$$CheckPercent`, `SkillFactory$$CreateSkill`
- when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `MathUtil.CheckPercent((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 52, 0, ?x3) << ([EquipItemData.get_SubWeapon(?blr, 0, ?x2, ?x3)+0x38] eq 17 ? 1 : 0)), 0, ?x2, ?x3)`
  - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`, `SkillBufferDataBase$$GetParam`, `EquipItemData$$get_SubWeapon`, `MathUtil$$CheckPercent`
- when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `HolyBibleBuf.get_ActivePersuit(TryGetBuf.out2(), 0, ?x2, ?x3)`
  - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`
- when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `0x165db84`, `0x165df00`, `0x165df00`
- when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0)`
  - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`

</details>

<details><summary>Effect applied in `HolyBibleAction$$ActionHit` (3 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `HolyBibleBuf.Initialize(SkillBufferManager.AddSelfBuffer(?blr, 843, Lv, 0), ?blr, 0, ?x3)`
  - calls `EquipItemData$$get_SubWeapon`, `SkillBufferManager$$AddSelfBuffer`, `HolyBibleBuf$$Initialize`
- when `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `EquipItemData$$get_SubWeapon`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-40), 0) & 1) eq 0`
  - returns `HolyBibleBuf.Initialize(SkillBufferManager.AddSelfBuffer(?blr, 843, Lv, 0), ?blr, 0, ?x3)`
  - calls `EquipItemData$$get_SubWeapon`, `SkillBufferManager$$AddSelfBuffer`, `HolyBibleBuf$$Initialize`

</details>

<details><summary>Effect applied in `MindimageSenjuSupportAction$$ActionHit` (3 guarded paths)</summary>

- when `SendSupport ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() gt 644` AND `CharacterActionManagerBase.get_IsLocalDead() le 965` AND `CharacterActionManagerBase.get_IsLocalDead() ne 650`
  - returns `HolyBibleBuf.Initialize(SkillBufferManager.AddSelfBuffer(?blr, 843, [baseSkill+0x14], 0), ?blr, 0, ?x3)`
  - calls `virtual CharacterActionManagerBase.get_IsLocalDead`, `EquipItemData$$get_SubWeapon`, `SkillBufferManager$$AddSelfBuffer`, `HolyBibleBuf$$Initialize`
- when `SendSupport ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() gt 644` AND `CharacterActionManagerBase.get_IsLocalDead() le 965` AND `CharacterActionManagerBase.get_IsLocalDead() ne 650`
  - calls `virtual CharacterActionManagerBase.get_IsLocalDead`, `EquipItemData$$get_SubWeapon`, `0x165db84`, `0x165df00`
- when `SendSupport ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() gt 644` AND `CharacterActionManagerBase.get_IsLocalDead() le 965` AND `CharacterActionManagerBase.get_IsLocalDead() ne 650`
  - returns `HolyBibleBuf.Initialize(SkillBufferManager.AddSelfBuffer(?blr, 843, [baseSkill+0x14], 0), ?blr, 0, ?x3)`
  - calls `virtual CharacterActionManagerBase.get_IsLocalDead`, `EquipItemData$$get_SubWeapon`, `SkillBufferManager$$AddSelfBuffer`, `HolyBibleBuf$$Initialize`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `HolyBibleAction$$ActionHit (TryGetBuf)`
- `MindimageSenjuSupportAction$$ActionHit (TryGetBuf)`
- `MobaPlayerBattleManager$$StartHolyBiblePursuitAttack (TryGetBuf)`
- `PlayerBattleManager$$StartHolyBiblePursuitAttack (TryGetBuf)`

---

### ไฮเนสฮีล (HighnessHeal) · uid 839

<img src="../../icons/sk_839.png" width="40" alt="icon"> 
**Type:** Support · **Max Lv:** 205 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เอนเชนส์เบลส · **Flags:** StarGem · **Client class:** `HighnessHealAction`

> ฟื้นฟู HP ของตัวเองและเพื่อนที่อยู่รอบๆ
> ไม่เหมือนฮีลของสกิลสนับสนุนตรงที่
> ไม่มีผลทำให้คืนชีพได้เร็วขึ้น

**Role:** utility / system action

This action never changes monster proration: ExpType None: no proration slot.

**Mechanics recovered from code**

- **Heal range** (`healRange`): `MathUtil.DisplayMeterToDistance((gemCart(1025[2]) + 8))`
- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 3, PlayerActionManagerBase.get_PlayerStatus())`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 839

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (2 paths)

- set `ActionRange` = `-1` = -1
- set `healRange` = `MathUtil.DisplayMeterToDistance((gemCart(1025[2]) + 8))`
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 3, PlayerActionManagerBase.get_PlayerStatus())`

**`InitializeOthers`** (2 paths)

- set `ActionRange` = `-1` = -1

</details>

---

### พรีเอล (Priere) · uid 840

<img src="../../icons/sk_840.png" width="40" alt="icon"> 
**Type:** Support · **Max Lv:** 205 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** อีเธอร์บาเรีย · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `PriereAction`

> ตั้งจิตอธิษฐานเพื่อเพิ่มพลังเวท
> จะเพิ่ม MATK ได้ชั่วขณะ
> เมื่อใช้งานมีโอกาสที่จะหายจากสภาวะ [อ่อนแอ]

<details><summary>In-game level notes</summary>

- Lv14: *ระยะเวลาแสดงผล+50s
- Lv15: *UP ปริมาณการเพิ่ม MATK
- Lv17: *มีโอกาสหายจากภาวะอ่อนแอ+25%

</details>

**Role:** buff (self) · buff (party / others)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 840

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (3 paths)

- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`
- set `ActionRange` = `-1` = -1

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (1 path)

- calls `PriereBuf..ctor` = `.ctor(Lv, PlayerActionManagerBase.get_PlayerStatus())`
- calls `SkillBufferManager.AddBuffer` = `AddBuffer(new PriereBuf, 0)`

</details>

**Buffs**

**Buff `PriereBuf`**
- Duration: `((Lv + 15) + 50)` s [EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14]; `(Lv + 15)` s [((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? 1 : 0) | 0) eq 1 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ne 14 OR ((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? 1 : 0) | 0) ne 1 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ne 14 OR ((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? 1 : 0) | 1) eq 1 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ne 14]; `time` s
- `MAtkUpRate` = `0` _(when BuffEffectActive eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MAtkUpRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |

- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `BuffEffectActive` = `1` = 1 when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR ((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? 1 : 0) | 0) eq 1 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ne 14
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR ((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? 1 : 0) | 0) eq 1 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ne 14
  - `IsSelfAction` = `0` when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR ((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? 1 : 0) | 0) eq 1 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ne 14
  - `BufEffectTakeUid` = `-1` = -1 when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR ((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? 1 : 0) | 0) eq 1 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ne 14
  - `mAtkUpRate` = `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR ((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? 1 : 0) | 0) ne 1 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ne 14
  - `mAtkUpRate` = `(Lv + 5)` → Lv1..10 [6, 7, 8, 9, 10, 11, 12, 13, 14, 15] when ((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? 1 : 0) | 0) eq 1 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ne 14 OR ((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? 1 : 0) | 1) eq 1 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ne 14
  - `isViewSelfIcon` = `1` = 1 when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR ((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? 1 : 0) | 0) eq 1 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ne 14
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

---

### เนเมซิส (Nemesis) · uid 844

<img src="../../icons/sk_844.png" width="40" alt="icon"> 
**Type:** Attack · **Max Lv:** 205 · **Weapons:** OneHandSword, Rod, Knuckle · **Requires:** โฮลี่ไบเบิ้ล · **Client class:** `NemesisAction`

> สร้างความเสียหายทางกายภาพและ
> กำหนดเป้าหมายที่จะโดนทัณฑ์สวรรค์
> 
> ถ้าอยู่ในสถานะที่โดนทัณฑ์สวรรค์สแต็คจะถูกสะสม
> เมื่อใช้งานสกิลนี้อีกครั้ง ขอบเขตการโจมตีด้วยเวทมนตร์
> จะเพิ่มตามจำนวนสแต็คที่สะสม

<details><summary>In-game level notes</summary>

- Lv10: [ไม่ว่าจะใช้ไม้เท้าหรือสนับมือก็มีรายละเอียดเหมือนกัน] จะมีเส้นที่เชื่อมโยงกับเป้าหมายที่โดนทัณฑ์สวรรค์แสดงขึ้นมา ถ้าอยู่ห่างกันเกินไปทัณฑ์สวรรค์จะถูกยกเลิก  สแต็คจะเพิ่มขึ้นเมื่อโจมตีโดนเป้าหมายที่มีเส้นเชื่อมโยงอยู่ หรือตอนที่ถูกโจมตี ถ้าอยู่ในสภาวะนิ่งเงียบสแต๊คที่สะสมมาจะหายไป
- Lv10: [ไม่ว่าจะใช้ไม้เท้าหรือสนับมือก็มีรายละเอียดเหมือนกัน] เมื่อใช้บัฟของสกิลนี้ผลข้อจำกัดเรื่อง ธาตุของเอ็กซอร์ซิสต์กับโฮลี่ไบเบิ้ลจะหายไป และเพิ่มธาตุคู่(อุปกรณ์เวทมนตร์)
- Lv15: *ระยะ (รัศมี) ของการโจมตีด้วยเวทย์มนตร์+2.5m
- Lv17: *พลังจะเพิ่มขึ้นตามค่า STR ของตัวเอง เวลาที่มีผลเพิ่มเป็น 2 เท่า

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [isFirst ne 0] | 10 | 10 | 10 | 10 | 10 | 10 | 10 | 10 | 10 | 10 |
| SkillRate × [!PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount lt 1 AND isFirst eq 0 OR !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount ge 1 AND criticalAttackCount ge SkillActionBase.get_AttackCount(this) AND isFirst eq 0 OR criticalAttackCount eq -1 AND criticalAttackCount ge 1 AND criticalAttackCount lt SkillActionBase.get_AttackCount(this) AND isFirst eq 0] | 10 | 10 | 10 | 10 | 10 | 10 | 10 | 10 | 10 | 10 |
| Flat dmg + [isFirst ne 0] | 60 | 120 | 180 | 240 | 300 | 360 | 420 | 480 | 540 | 600 |
| Flat dmg + [!PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount lt 1 AND isFirst eq 0 OR !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount ge 1 AND criticalAttackCount ge SkillActionBase.get_AttackCount(this) AND isFirst eq 0 OR criticalAttackCount eq -1 AND criticalAttackCount ge 1 AND criticalAttackCount lt SkillActionBase.get_AttackCount(this) AND isFirst eq 0] | 60 | 120 | 180 | 240 | 300 | 360 | 420 | 480 | 540 | 600 |
| Flat dmg + [!PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount lt 1 AND isFirst eq 0 OR !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount ge 1 AND criticalAttackCount ge SkillActionBase.get_AttackCount(this) AND isFirst eq 0 OR criticalAttackCount eq -1 AND criticalAttackCount ge 1 AND criticalAttackCount lt SkillActionBase.get_AttackCount(this) AND isFirst eq 0] | 30 | 60 | 90 | 120 | 150 | 180 | 210 | 240 | 270 | 300 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((min((1000 + status.Str), 1500)) / 100)` — isFirst ne 0
- SkillRate × `((((1) eq 0 ? 1 : 0) ne 0 ? (min(((status.Int * 0.5) + 500), 750)) : (min((1000 + status.Str), 1500))) / 100)` — !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount lt 1 AND isFirst eq 0 OR !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount ge 1 AND criticalAttackCount ge SkillActionBase.get_AttackCount(this) AND isFirst eq 0 OR criticalAttackCount eq -1 AND criticalAttackCount ge 1 AND criticalAttackCount lt SkillActionBase.get_AttackCount(this) AND isFirst eq 0
- SkillRate × `((((1) eq 0 ? 1 : 0) ne 0 ? (min(((status.Int * 0.5) + 500), 750)) : (min((1000 + status.Str), 1500))) / 100)` — !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount lt 1 AND isFirst eq 0 OR !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount ge 1 AND criticalAttackCount ge SkillActionBase.get_AttackCount(this) AND isFirst eq 0 OR criticalAttackCount eq -1 AND criticalAttackCount ge 1 AND criticalAttackCount lt SkillActionBase.get_AttackCount(this) AND isFirst eq 0
- SkillRate × `((((1) eq 0 ? 1 : 0) ne 0 ? (min(((status.Int * 0.5) + 500), 750)) : (min((1000 + status.Str), 1500))) / 100)` — !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount lt 1 AND isFirst eq 0 OR !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount ge 1 AND criticalAttackCount ge SkillActionBase.get_AttackCount(this) AND isFirst eq 0 OR criticalAttackCount eq -1 AND criticalAttackCount ge 1 AND criticalAttackCount lt SkillActionBase.get_AttackCount(this) AND isFirst eq 0

**Role:** attack (deals damage) · buff (self) · changes attack pattern (motion / combo chain; heuristic)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **slot chosen at runtime (physical or magic by a per-cast flag)**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `((Lv * 60))` | `(((1) eq 0 ? 1 : 0) ne 0 ? ((Lv * 30)) : ((Lv * 60)))`
- `SkillRate` multiplies by (adds into): `((min((1000 + status.Str), 1500)) / 100)` | `((((1) eq 0 ? 1 : 0) ne 0 ? (min(((status.Int * 0.5) + 500), 750)) : (min((1000 + status.Str), 1500))) / 100)`
- `ExpRate` sets: `(target.ExpDefMagic / 100)` | `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**Mechanics recovered from code**

- **Loop / hit-repeat count** (`LoopParam`): `motionSpeed`; `SkillBufferDataBase.GetParam(CheckNemesisBuf.buf((this + 312), actarAction), 20)`; `0` = 0
- **Per-target multiplier (%)** (`targetSkillRate`): `min((1000 + status.Str), 1500)`; `1000` = 1000

**Proration:** slot `dynamic`, mode `first_hit_per_target`, attack type `dynamic`, action id 844

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (3 paths)

- set `Element` = `5` = 5
- set `SubElement` = `PlayerStatusBase.GetEquipSubWeaponElement(PlayerActionManagerBase.get_PlayerStatus())` — when hasBuff(844) AND subWeapon == Magictool
- set `IsValidDualElement` = `1` = 1 — when hasBuff(844) AND subWeapon == Magictool
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(8)`

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1
- set `LoopParam` = `motionSpeed`

**`OtherPlayerAttackStartReceive`** (1 path)

- set `isInstallation` = `((skillIndividualFlag & 15) ne 0 ? 1 : 0)`

**`ActionPreparation`** (8 paths)

- set `mainTarget` = `UnityEngine.GameObject.get_transform(target)`
- set `targetSkillRate` = `min((1000 + status.Str), 1500)`
- set `fixAddDamage` = `(Lv * 60)` → Lv1..10: [60, 120, 180, 240, 300, 360, 420, 480, 540, 600]
- set `placeSkillRate` = `min(((status.Int * 0.5) + 500), 750)`
- set `placeFixDamage` = `(Lv * 30)` → Lv1..10: [30, 60, 90, 120, 150, 180, 210, 240, 270, 300]
- set `isFirst` = `1` = 1
- set `LoopParam` = `SkillBufferDataBase.GetParam(CheckNemesisBuf.buf((this + 312), actarAction), 20)`
- set `LoopParam` = `0` = 0
- set `targetSkillRate` = `1000` = 1000

**`ActionStart`** (4 paths)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(844)` — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isInstallation ne 0

**`calcPlayerToMobDamage`** (36 paths)

- template `AddRate[SkillRate]` = `(targetSkillRate / 100)` — when isFirst ne 0
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage` — when isFirst ne 0
- calls `PlayerAttackBase.SetBufferConstantDamage` = `SetBufferConstantDamage(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), (LoopParam + 1))` — when isFirst ne 0 OR !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount lt 1 AND isFirst eq 0 OR !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount ge 1 AND criticalAttackCount ge SkillActionBase.get_AttackCount(this) AND isFirst eq 0
- info `templates` = `1`
- set `criticalAttackCount` = `(SkillActionBase.get_AttackCount(this) & 255)` — when criticalAttackCount eq -1 AND criticalAttackCount ge 1 AND criticalAttackCount lt SkillActionBase.get_AttackCount(this) AND isFirst eq 0 OR PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount eq -1 AND criticalAttackCount lt 1 AND isFirst eq 0 OR PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount eq -1 AND criticalAttackCount ge 1 AND criticalAttackCount ge SkillActionBase.get_AttackCount(this) AND isFirst eq 0
- template `SetRate[ExpRate]` = `(target.ExpDefMagic / 100)` — when !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount lt 1 AND isFirst eq 0 OR !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount ge 1 AND criticalAttackCount ge SkillActionBase.get_AttackCount(this) AND isFirst eq 0 OR criticalAttackCount eq -1 AND criticalAttackCount ge 1 AND criticalAttackCount lt SkillActionBase.get_AttackCount(this) AND isFirst eq 0
- template `AddRate[SkillRate]` = `(((isFirst eq 0 ? 1 : 0) ne 0 ? placeSkillRate : targetSkillRate) / 100)` — when !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount lt 1 AND isFirst eq 0 OR !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount ge 1 AND criticalAttackCount ge SkillActionBase.get_AttackCount(this) AND isFirst eq 0 OR criticalAttackCount eq -1 AND criticalAttackCount ge 1 AND criticalAttackCount lt SkillActionBase.get_AttackCount(this) AND isFirst eq 0
- template `AddConstant[SkillConstantDamage]` = `((isFirst eq 0 ? 1 : 0) ne 0 ? placeFixDamage : fixAddDamage)` — when !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount lt 1 AND isFirst eq 0 OR !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount ge 1 AND criticalAttackCount ge SkillActionBase.get_AttackCount(this) AND isFirst eq 0 OR criticalAttackCount eq -1 AND criticalAttackCount ge 1 AND criticalAttackCount lt SkillActionBase.get_AttackCount(this) AND isFirst eq 0
- template `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` — when !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount lt 1 AND isFirst eq 0 OR !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount ge 1 AND criticalAttackCount ge SkillActionBase.get_AttackCount(this) AND isFirst eq 0 OR criticalAttackCount eq -1 AND criticalAttackCount ge 1 AND criticalAttackCount lt SkillActionBase.get_AttackCount(this) AND isFirst eq 0

**`NextRangeHit`** (2 paths)

- set `isFirst` = `0` = 0

**`ActionHit`** (6 paths)

- calls `NemesisBuf..ctor` = `.ctor(Lv, target, actarAction)` — when UnityEngine.Object.op_Inequality(actarAction) AND isInstallation eq 0
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new NemesisBuf, Id)` — when UnityEngine.Object.op_Inequality(actarAction) AND isInstallation eq 0

**`OnInheritance`** (1 path)

- set `IsInheritance` = `1` = 1

</details>

**Buffs**

**Buff `NemesisBuf`**
- **Changes the attack pattern**: the buff object drives a motion/combo chain (`ChangeHyperMode`, `get_BufEffectTakeId`).
- Buff hook methods: `ChangeHyperMode`, `CheckBufferLineConnect`, `CheckPlayerAttackDamaged`, `CountReset`, `MobAttackDamaged`, `OnCall`, `PlayerAttackDamaged`, `get_BufEffectTakeId`
- Duration: `((((Lv << 2) + lv) << 1) + (((Lv << 2) + lv) << 1))` s [EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17]; `(((Lv << 2) + lv) << 1)` s [EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 17]
- `Count` = `(0)` _(when BuffEffectActive ne 0)_
- Buff fields set in the constructor (all recovered):
  - `range` = `MathUtil.DisplayMeterToDistance(16)`
  - `playerAttackIdList` = `new System.Collections.Generic.List<int>`
  - `Count` = `0`
  - `target` = `target`
  - `playerAction` = `player`
  - `mobAction` = `UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target)`
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
- Hook `CountReset`: `Count`=0
- Hook `OnCall`: `lineEffect`=UnityEngine.GameObject.AddComponent<NemesisBuf.NemesisLineEffect>(UnityEngine.Component.get_gameObject([[Singleton<TakeManager>.get_Instance()+0x20]+0x30][takeUid]))
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:NemesisBuf$$.ctor<-NemesisAction$$ActionHit` (no direct constructor call in the skill's own code).
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

<details><summary>Effect applied in `MobaPlayerActionManager$$ReceiveAttack` (300 guarded paths, truncated)</summary>

- when `(SkillActionBase.op_Inequality(skill, 0, 0, attackResponseData) & 1) ne 0` AND `GetServerHitTypeV2.out2() ne 1` AND `GetServerHitTypeV2.out1() ne 0` AND `SkillActionBase.get_ActionID() le 515`
  - returns `ChatManager.AddMobaDuelAbilityMessage(Singleton<object>.get_Instance(meta(0x3974ce8, Method$Singleton<ChatManager>.get_Instance()), ?x1, ?x2, ?x3), 37, 0x165d9d4(meta(0x3972128, object[]_TypeInfo), 2, ?x2, ?x3), 0)`
  - calls `SkillUtil$$GetServerHitTypeV2`, `virtual SkillActionBase.get_ActionID`, `UnityEngine.Component$$get_gameObject`, `PlayerSkillActionManager$$ReceiveMobaHitDamage`, `MoonSlashAction$$ReceiveMobaAttack`, `FuriousEffortsExtreme$$Damaged`, `UnityEngine.Component$$get_gameObject`, `NemesisBuf$$CheckPlayerAttackDamaged`
- when `(SkillActionBase.op_Inequality(skill, 0, 0, attackResponseData) & 1) ne 0` AND `GetServerHitTypeV2.out2() ne 1` AND `GetServerHitTypeV2.out1() ne 0` AND `SkillActionBase.get_ActionID() le 515`
  - calls `SkillUtil$$GetServerHitTypeV2`, `virtual SkillActionBase.get_ActionID`, `UnityEngine.Component$$get_gameObject`, `PlayerSkillActionManager$$ReceiveMobaHitDamage`, `MoonSlashAction$$ReceiveMobaAttack`, `FuriousEffortsExtreme$$Damaged`, `UnityEngine.Component$$get_gameObject`, `NemesisBuf$$CheckPlayerAttackDamaged`
- when `(SkillActionBase.op_Inequality(skill, 0, 0, attackResponseData) & 1) ne 0` AND `GetServerHitTypeV2.out2() ne 1` AND `GetServerHitTypeV2.out1() ne 0` AND `SkillActionBase.get_ActionID() le 515`
  - calls `SkillUtil$$GetServerHitTypeV2`, `virtual SkillActionBase.get_ActionID`, `UnityEngine.Component$$get_gameObject`, `PlayerSkillActionManager$$ReceiveMobaHitDamage`, `MoonSlashAction$$ReceiveMobaAttack`, `FuriousEffortsExtreme$$Damaged`, `UnityEngine.Component$$get_gameObject`, `NemesisBuf$$CheckPlayerAttackDamaged`
- when `(SkillActionBase.op_Inequality(skill, 0, 0, attackResponseData) & 1) ne 0` AND `GetServerHitTypeV2.out2() ne 1` AND `GetServerHitTypeV2.out1() ne 0` AND `SkillActionBase.get_ActionID() le 515`
  - returns `UnityEngine.Object.op_Inequality([battleManager+0x30], 0, 0, ?x3)`
  - calls `SkillUtil$$GetServerHitTypeV2`, `virtual SkillActionBase.get_ActionID`, `UnityEngine.Component$$get_gameObject`, `PlayerSkillActionManager$$ReceiveMobaHitDamage`, `MoonSlashAction$$ReceiveMobaAttack`, `FuriousEffortsExtreme$$Damaged`, `UnityEngine.Component$$get_gameObject`, `NemesisBuf$$CheckPlayerAttackDamaged`
- when `(SkillActionBase.op_Inequality(skill, 0, 0, attackResponseData) & 1) ne 0` AND `GetServerHitTypeV2.out2() ne 1` AND `GetServerHitTypeV2.out1() ne 0` AND `SkillActionBase.get_ActionID() le 515`
  - returns `ChatManager.AddMobaDuelAbilityMessage(Singleton<object>.get_Instance(meta(0x3974ce8, Method$Singleton<ChatManager>.get_Instance()), ?x1, ?x2, ?x3), 37, 0x165d9d4(meta(0x3972128, object[]_TypeInfo), 2, ?x2, ?x3), 0)`
  - calls `SkillUtil$$GetServerHitTypeV2`, `virtual SkillActionBase.get_ActionID`, `UnityEngine.Component$$get_gameObject`, `PlayerSkillActionManager$$ReceiveMobaHitDamage`, `MoonSlashAction$$ReceiveMobaAttack`, `FuriousEffortsExtreme$$Damaged`, `UnityEngine.Component$$get_gameObject`, `NemesisBuf$$CheckPlayerAttackDamaged`
- when `(SkillActionBase.op_Inequality(skill, 0, 0, attackResponseData) & 1) ne 0` AND `GetServerHitTypeV2.out2() ne 1` AND `GetServerHitTypeV2.out1() ne 0` AND `SkillActionBase.get_ActionID() le 515`
  - calls `SkillUtil$$GetServerHitTypeV2`, `virtual SkillActionBase.get_ActionID`, `UnityEngine.Component$$get_gameObject`, `PlayerSkillActionManager$$ReceiveMobaHitDamage`, `MoonSlashAction$$ReceiveMobaAttack`, `FuriousEffortsExtreme$$Damaged`, `UnityEngine.Component$$get_gameObject`, `NemesisBuf$$CheckPlayerAttackDamaged`
- when `(SkillActionBase.op_Inequality(skill, 0, 0, attackResponseData) & 1) ne 0` AND `GetServerHitTypeV2.out2() ne 1` AND `GetServerHitTypeV2.out1() ne 0` AND `SkillActionBase.get_ActionID() le 515`
  - calls `SkillUtil$$GetServerHitTypeV2`, `virtual SkillActionBase.get_ActionID`, `UnityEngine.Component$$get_gameObject`, `PlayerSkillActionManager$$ReceiveMobaHitDamage`, `MoonSlashAction$$ReceiveMobaAttack`, `FuriousEffortsExtreme$$Damaged`, `UnityEngine.Component$$get_gameObject`, `NemesisBuf$$CheckPlayerAttackDamaged`
- when `(SkillActionBase.op_Inequality(skill, 0, 0, attackResponseData) & 1) ne 0` AND `GetServerHitTypeV2.out2() ne 1` AND `GetServerHitTypeV2.out1() ne 0` AND `SkillActionBase.get_ActionID() le 515`
  - returns `UnityEngine.Object.op_Inequality([battleManager+0x30], 0, 0, ?x3)`
  - calls `SkillUtil$$GetServerHitTypeV2`, `virtual SkillActionBase.get_ActionID`, `UnityEngine.Component$$get_gameObject`, `PlayerSkillActionManager$$ReceiveMobaHitDamage`, `MoonSlashAction$$ReceiveMobaAttack`, `FuriousEffortsExtreme$$Damaged`, `UnityEngine.Component$$get_gameObject`, `NemesisBuf$$CheckPlayerAttackDamaged`

</details>

<details><summary>Effect applied in `EnemyMobActionManagerBase$$Damaged` (300 guarded paths, truncated)</summary>

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

</details>

<details><summary>Effect applied in `ScoreAttackBossActionManager$$Damaged` (300 guarded paths, truncated)</summary>

- when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
  - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
  - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
- when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
  - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
  - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
- when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
  - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
  - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
- when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
  - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
  - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
- when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
  - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
  - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
- when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
  - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
  - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
- when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
  - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
  - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
- when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
  - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
  - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`

</details>

<details><summary>Effect applied in `BCollaboBossActionManager$$Damaged` (300 guarded paths, truncated)</summary>

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

</details>

<details><summary>Effect applied in `GuildRaidBossMobActionManager$$Damaged` (300 guarded paths, truncated)</summary>

- when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
  - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
- when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
  - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
  - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
- when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
  - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
  - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
- when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
  - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
  - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
- when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
  - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
  - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
- when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
  - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
  - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
- when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
  - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
  - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
- when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
  - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
  - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`

</details>

<details><summary>Effect applied in `ExorcismAction$$ActionStart` (2 guarded paths)</summary>

- when `(SkillParam & 16) eq 0`
  - returns `SkillBufferManager.ContainsBuffer(?blr, 844, 0, ?x3)`
  - set `isNemesisBuf` = `(SkillBufferManager.ContainsBuffer(?blr, 844, 0, ?x3) & 1)`
  - calls `PlayerAttackBase$$ActionStart`, `SkillBufferManager$$AddSelfBuffer`
- when `(SkillParam & 16) eq 0`
  - returns `SkillBufferManager.ContainsBuffer(?blr, 844, 0, ?x3)`
  - set `isNemesisBuf` = `(SkillBufferManager.ContainsBuffer(?blr, 844, 0, ?x3) & 1)`
  - calls `PlayerAttackBase$$ActionStart`

</details>

<details><summary>Effect applied in `MobaOtherPlayerActionManager$$Damaged` (4 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 844, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `NemesisBuf.CheckPlayerAttackDamaged(TryGetBuf.out2(), UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), [action+0x10], 0)`
  - calls `UnityEngine.GameObject$$GetComponent<object>`, `UnityEngine.Component$$get_gameObject`, `NemesisBuf$$CheckPlayerAttackDamaged`
- when `(SkillBufferManager.TryGetBuf(?blr, 844, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `NemesisBuf.CheckPlayerAttackDamaged(TryGetBuf.out2(), UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), [action+0x10], 0)`
  - calls `UnityEngine.GameObject$$GetComponent<object>`, `UnityEngine.Component$$get_gameObject`, `NemesisBuf$$CheckPlayerAttackDamaged`
- when `(SkillBufferManager.TryGetBuf(?blr, 844, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `UnityEngine.GameObject$$GetComponent<object>`, `UnityEngine.Component$$get_gameObject`, `0x165db84`, `0x165df00`
- when `(SkillBufferManager.TryGetBuf(?blr, 844, stkp(-56), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 844, stkp(-56), 0)`
  - calls `UnityEngine.GameObject$$GetComponent<object>`

</details>

<details><summary>Effect applied in `NemesisAction$$Damaged` (5 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 844, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(NemesisBuf.MobAttackDamaged(TryGetBuf.out2(), target, damageData, 0) & 1) ne 0`
  - returns `NemesisBuf.MobAttackDamaged(TryGetBuf.out2(), target, damageData, 0)`
  - calls `NemesisBuf$$MobAttackDamaged`
- when `(SkillBufferManager.TryGetBuf(?blr, 844, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(NemesisBuf.MobAttackDamaged(TryGetBuf.out2(), target, damageData, 0) & 1) eq 0`
  - returns `NemesisBuf.MobAttackDamaged(TryGetBuf.out2(), target, damageData, 0)`
  - calls `NemesisBuf$$MobAttackDamaged`
- when `(SkillBufferManager.TryGetBuf(?blr, 844, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `0x165db84`, `0x165df00`
- when `(SkillBufferManager.TryGetBuf(?blr, 844, stkp(-40), 0) & 1) ne 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 844, stkp(-40), 0)`
- when `(SkillBufferManager.TryGetBuf(?blr, 844, stkp(-40), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 844, stkp(-40), 0)`

</details>

<details><summary>Effect applied in `NemesisAction$$OnInitialize` (3 guarded paths)</summary>

- always
  - set `Element` = `5`
  - set `SubElement` = `PlayerStatusBase.GetEquipSubWeaponElement(?blr, 0, ?x2, ?x3)`
  - set `IsValidDualElement` = `1`
  - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - calls `PlayerAttackBase$$GetSubWeaponType`, `PlayerStatusBase$$GetEquipSubWeaponElement`, `PlayerAttackBase$$GetWeaponType`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`
- always
  - set `Element` = `5`
  - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - calls `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponType`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`
- always
  - set `Element` = `5`
  - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - calls `PlayerAttackBase$$GetWeaponType`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`

</details>

<details><summary>Effect applied in `MobaPlayerActionManager$$AddAbnormalState` (6 guarded paths)</summary>

- when `(resist & 1) ne 0` AND `type ne 4` AND `type le 18` AND `(type - 1) hi 10`
  - returns `(AbnormalStateManager.AddAbnormalState(?blr, 18, [0x165db78(meta(0x399ed28, MobaPlayerActionManager.<>c__DisplayClass64_0_TypeInfo), actor, type, time)+0x18], (resist & 1)) & 1)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `AbnormalStateManager$$RemoveAbnormalState`, `0x165db78`, `System.Action<object>$$.ctor`, `SkillBufferManager$$RemoveSelfBuffer`
- when `(resist & 1) ne 0` AND `type ne 4` AND `type le 18` AND `(type - 1) hi 10`
  - returns `(AbnormalStateManager.AddAbnormalState(?blr, 18, [0x165db78(meta(0x399ed28, MobaPlayerActionManager.<>c__DisplayClass64_0_TypeInfo), actor, type, time)+0x18], (resist & 1)) & 1)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `AbnormalStateManager$$RemoveAbnormalState`, `0x165db78`, `System.Action<object>$$.ctor`, `AbnormalStateManager$$AddAbnormalState`
- when `(resist & 1) eq 0` AND `(type - 1) lo 4` AND `type le 18` AND `(type - 1) hi 10`
  - returns `(AbnormalStateManager.AddAbnormalState(?blr, 18, [0x165db78(meta(0x399ed28, MobaPlayerActionManager.<>c__DisplayClass64_0_TypeInfo), actor, type, time)+0x18], (resist & 1)) & 1)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165db78`, `System.Action<object>$$.ctor`, `SkillBufferManager$$RemoveSelfBuffer`, `AbnormalStateManager$$AddAbnormalState`
- when `(resist & 1) eq 0` AND `(type - 1) lo 4` AND `type le 18` AND `(type - 1) hi 10`
  - returns `(AbnormalStateManager.AddAbnormalState(?blr, 18, [0x165db78(meta(0x399ed28, MobaPlayerActionManager.<>c__DisplayClass64_0_TypeInfo), actor, type, time)+0x18], (resist & 1)) & 1)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165db78`, `System.Action<object>$$.ctor`, `AbnormalStateManager$$AddAbnormalState`
- when `(resist & 1) eq 0` AND `type le 18` AND `(type - 1) hi 10` AND `type eq 18`
  - returns `(AbnormalStateManager.AddAbnormalState(?blr, 18, [0x165db78(meta(0x399ed28, MobaPlayerActionManager.<>c__DisplayClass64_0_TypeInfo), actor, type, time)+0x18], (resist & 1)) & 1)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165db78`, `System.Action<object>$$.ctor`, `SkillBufferManager$$RemoveSelfBuffer`, `AbnormalStateManager$$AddAbnormalState`
- when `(resist & 1) eq 0` AND `type le 18` AND `(type - 1) hi 10` AND `type eq 18`
  - returns `(AbnormalStateManager.AddAbnormalState(?blr, 18, [0x165db78(meta(0x399ed28, MobaPlayerActionManager.<>c__DisplayClass64_0_TypeInfo), actor, type, time)+0x18], (resist & 1)) & 1)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165db78`, `System.Action<object>$$.ctor`, `AbnormalStateManager$$AddAbnormalState`

</details>

<details><summary>Effect applied in `EnemyMobActionManagerBase$$SetHyperModeStatus` (300 guarded paths, truncated)</summary>

- when `ChangeHyperMode.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 844, stkp(-120), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1126, stkp(-120), 0) & 1) ne 0`
  - returns `MobScriptActionManager.UpdateStatus(scriptActionManager, 0, ?x2, ?x3)`
  - set `mobStatusMaster` = `status`
  - set `invincibleTime` = `([mobModeData+0x2c] / 10)`
  - calls `0x165d8dc`, `MobHyperModeManager$$ChangeHyperMode`, `0x165da68`, `interface IBossParts.ClearParts`, `Singleton<object>$$get_Instance`, `MobMaster$$GetMobMaster`, `MobStatusMasterEx$$CheckMultiFlag`, `interface IBossParts.SetPartsMaster`
- when `ChangeHyperMode.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 844, stkp(-120), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1126, stkp(-120), 0) & 1) ne 0`
  - returns `MobScriptActionManager.UpdateStatus(scriptActionManager, 0, ?x2, ?x3)`
  - set `mobStatusMaster` = `status`
  - set `invincibleTime` = `([mobModeData+0x2c] / 10)`
  - calls `0x165d8dc`, `MobHyperModeManager$$ChangeHyperMode`, `0x165da68`, `interface IBossParts.ClearParts`, `Singleton<object>$$get_Instance`, `MobMaster$$GetMobMaster`, `MobStatusMasterEx$$CheckMultiFlag`, `interface IBossParts.SetPartsMaster`
- when `ChangeHyperMode.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 844, stkp(-120), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1126, stkp(-120), 0) & 1) ne 0`
  - set `mobStatusMaster` = `status`
  - set `invincibleTime` = `([mobModeData+0x2c] / 10)`
  - calls `0x165d8dc`, `MobHyperModeManager$$ChangeHyperMode`, `0x165da68`, `interface IBossParts.ClearParts`, `Singleton<object>$$get_Instance`, `MobMaster$$GetMobMaster`, `MobStatusMasterEx$$CheckMultiFlag`, `interface IBossParts.SetPartsMaster`
- when `ChangeHyperMode.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 844, stkp(-120), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1126, stkp(-120), 0) & 1) ne 0`
  - returns `MobScriptActionManager.UpdateStatus(scriptActionManager, 0, ?x2, ?x3)`
  - set `mobStatusMaster` = `status`
  - set `invincibleTime` = `([mobModeData+0x2c] / 10)`
  - calls `0x165d8dc`, `MobHyperModeManager$$ChangeHyperMode`, `0x165da68`, `interface IBossParts.ClearParts`, `Singleton<object>$$get_Instance`, `MobMaster$$GetMobMaster`, `MobStatusMasterEx$$CheckMultiFlag`, `interface IBossParts.SetPartsMaster`
- when `ChangeHyperMode.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 844, stkp(-120), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1126, stkp(-120), 0) & 1) ne 0`
  - set `mobStatusMaster` = `status`
  - set `invincibleTime` = `([mobModeData+0x2c] / 10)`
  - calls `0x165d8dc`, `MobHyperModeManager$$ChangeHyperMode`, `0x165da68`, `interface IBossParts.ClearParts`, `Singleton<object>$$get_Instance`, `MobMaster$$GetMobMaster`, `MobStatusMasterEx$$CheckMultiFlag`, `interface IBossParts.SetPartsMaster`
- when `ChangeHyperMode.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 844, stkp(-120), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1126, stkp(-120), 0) & 1) ne 0`
  - returns `MobScriptActionManager.UpdateStatus(scriptActionManager, 0, ?x2, ?x3)`
  - set `mobStatusMaster` = `status`
  - set `invincibleTime` = `([mobModeData+0x2c] / 10)`
  - calls `0x165d8dc`, `MobHyperModeManager$$ChangeHyperMode`, `0x165da68`, `interface IBossParts.ClearParts`, `Singleton<object>$$get_Instance`, `MobMaster$$GetMobMaster`, `MobStatusMasterEx$$CheckMultiFlag`, `interface IBossParts.SetPartsMaster`
- when `ChangeHyperMode.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 844, stkp(-120), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1126, stkp(-120), 0) & 1) ne 0`
  - returns `MobScriptActionManager.UpdateStatus(scriptActionManager, 0, ?x2, ?x3)`
  - set `mobStatusMaster` = `status`
  - calls `0x165d8dc`, `MobHyperModeManager$$ChangeHyperMode`, `0x165da68`, `interface IBossParts.ClearParts`, `Singleton<object>$$get_Instance`, `MobMaster$$GetMobMaster`, `MobStatusMasterEx$$CheckMultiFlag`, `interface IBossParts.SetPartsMaster`
- when `ChangeHyperMode.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 844, stkp(-120), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1126, stkp(-120), 0) & 1) ne 0`
  - returns `MobScriptActionManager.UpdateStatus(scriptActionManager, 0, ?x2, ?x3)`
  - set `mobStatusMaster` = `status`
  - calls `0x165d8dc`, `MobHyperModeManager$$ChangeHyperMode`, `0x165da68`, `interface IBossParts.ClearParts`, `Singleton<object>$$get_Instance`, `MobMaster$$GetMobMaster`, `MobStatusMasterEx$$CheckMultiFlag`, `interface IBossParts.SetPartsMaster`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `BCollaboBossActionManager$$Damaged (TryGetBuf)`
- `EnemyMobActionManagerBase$$Damaged (TryGetBuf)`
- `EnemyMobActionManagerBase$$SetHyperModeStatus (TryGetBuf)`
- `ExorcismAction$$ActionStart (ContainsBuffer)`
- `GuildRaidBossMobActionManager$$Damaged (TryGetBuf)`
- `MindimageSenjuAttackAction$$ActionStart (ContainsBuffer)`
- `MobaOtherPlayerActionManager$$Damaged (TryGetBuf)`
- `MobaPlayerActionManager$$AddAbnormalState (ContainsBuffer)`
- `MobaPlayerActionManager$$ReceiveAttack (TryGetBuf)`
- `MobaPlayerBattleManager$$StartHolyBiblePursuitAttack (ContainsBuffer)`
- `NemesisAction$$Damaged (TryGetBuf)`
- `NemesisAction$$OnInitialize (ContainsBuffer)`
- `PlayerActionManager$$AddAbnormalState (ContainsBuffer)`
- `PlayerBattleManager$$StartHolyBiblePursuitAttack (ContainsBuffer)`
- `ScoreAttackBossActionManager$$Damaged (TryGetBuf)`

---

### แอสพิสโซล (AspisSeoul) · uid 845

<img src="../../icons/sk_845.png" width="40" alt="icon"> 
**Type:** Mastery · **Max Lv:** 285 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** พรีเอล · **Client class:** `AspisSeoul` (passive mastery)

> โล่แห่งศรัทธา
> ได้รับผลการลดเปอร์เซ็นต์ความเสียหาย
> ที่มุ่งเป้าไปหาตัวเองแบบถาวร
> และได้รับผลการป้องกันสถานะผิดปกติในบางช่วงเวลา

<details><summary>In-game level notes</summary>

- Lv255: ถ้าอยู่ในปาร์ตี้จะเพิ่มเปอร์เซ็นต์ต้านทานความเสียหาย ขึ้นอยู่กับจำนวนสมาชิกPTที่รอดชีวิต(สูงสุด 3 คน)  ได้ผลการป้องกันเมื่อฟื้นฟูจากภาวะผิดปกติตามธรรมชาติ และเมื่อเริ่มต่อสู้กับบอส

</details>

**Role:** buff (self) · passive mastery · modifies normal-attack behaviour

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Buffs**

**Buff `AspisSeoulBuf`**
- **Modifies normal attacks**: `NormalAttackAction` looks this buff up while it builds the normal-attack damage / hit logic.
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Duration: `((Lv << 1) + lv)` s
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0

<details><summary>Effect applied in `AspisSeoul$$ReceiveSupportEvent` (3 guarded paths)</summary>

- when `SkillLv(845) ge 1`
  - returns `SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), 231, 0, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- when `SkillLv(845) ge 1`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `RecoveryBuf$$CreateAspisSeoulBuf`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferManager$$AddSelfBuffer`
- when `SkillLv(845) lt 1`
  - returns `SkillLv(845)`
  - calls `virtual PlayerStatusBase.get_SkillManager`

</details>

<details><summary>Effect applied in `AspisSeoul$$GetRateDamageResist` (2 guarded paths)</summary>

- when `SkillLv(845) ge 1`
  - returns `(((System.Linq.Enumerable.Count<object>(System.Linq.Enumerable.Where<object>(BattleMemberManager.GetBattleMemberList([Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3)+0x28], 0, ?x2, ?x3), meta(0), meta(0x39a0cc8, Method$System.Linq.Enumerable.Where<BattleMemberData>()), ?x3), meta(0x3994ca8, Method$System.Linq.Enumerable.Count<BattleMemberData>()), ?x2, ?x3) lt 3 ? System.Linq.Enumerable.Count<object>(System.Linq.Enumerable.Where<object>(BattleMemberManager.GetBattleMemberList([Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3)+0x28], 0, ?x2, ?x3), meta(0), meta(0x39a0cc8, Method$System.Linq.Enumerable.Where<BattleMemberData>()), ?x3), meta(0x3994ca8, Method$System.Linq.Enumerable.Count<BattleMemberData>()), ?x2, ?x3) : 3) * int((SkillLv(845) * 0.5))) + SkillLv(845))`
  - calls `AspisSeoul$$CheckResistTarget`, `Singleton<object>$$get_Instance`, `BattleMemberManager$$GetBattleMemberList`, `System.Linq.Enumerable$$Where<object>`, `System.Linq.Enumerable$$Count<object>`
- when `SkillLv(845) lt 1`
  - returns `0`
  - calls `AspisSeoul$$CheckResistTarget`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `AspisSeoul$$GetRateDamageResist (GetSkillLv)`
- `AspisSeoul$$ReceiveSupportEvent (GetSkillLv)`

---

### คำสอนศักดิ์สิทธิ์ (SacredTeachings) · uid 846

<img src="../../icons/sk_846.png" width="40" alt="icon"> 
**Type:** Mastery · **Max Lv:** 285 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ไฮเนสฮีล · **Client class:** `SacredTeachings` (passive mastery)

> เมื่อใช้สกิลฟื้นฟูจะได้รับHPชั่วคราว
> ที่เกินกว่าค่าHPสูงสุดในปัจจุบัน(*)
> เมื่อได้รับHPชั่วคราวATKและMATK
> จะเพิ่มขึ้นเล็กน้อยตามค่านั้น

<details><summary>In-game level notes</summary>

- Lv255: (*)เมื่อค่าHPสูงสุดรวมกับHPชั่วคราวเกิน 99,999 HPชั่วคราวจะถูกตัดทิ้ง

</details>

**Role:** buff (self) · passive mastery

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Buffs**

**Buff `CountBufferBase`**
- Attached to this skill via `caller2:SacredTeachingsBuf$$.ctor<-SacredTeachings$$ReceiveEventSupport` (no direct constructor call in the skill's own code).
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
**Buff `SacredTeachingsBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `AddOverHeal`, `Damage`, `SetOverHeal`, `UpdateCount`
- `Value2` = `localOverHealValue` _(when BuffEffectActive ne 0; (id - 54) hs 2)_
- `Value` = `overHealValue` _(when BuffEffectActive ne 0; (id - 54) hs 2)_
- Buff fields set in the constructor (all recovered):
  - `MaxOverHealValue` = `(Lv * 1000)` → Lv1..10 [1000, 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000, 10000]
- Hook `AddOverHeal`: `overHealValue`=(max((0x1869f - maxHp), 0) lt (MaxOverHealValue lt (overHealValue + healValue) ? MaxOverHealValue : (overHealValue + healValue)) ? max((0x1869f - maxHp), 0) : (MaxOverHealValue lt (overHealValue + healValue) ? MaxOverHealValue : (overHealValue + healValue))); `Count`=(?ccmp lt 0 ? int((((max((0x1869f - maxHp), 0) lt (MaxOverHealValue lt (overHealValue + healValue) ? MaxOverHealValue : (overHealValue + healValue)) ? max((0x1869f - maxHp), 0) : (MaxOverHealValue lt (overHealValue + healValue) ? MaxOverHealValue : (overHealValue + healValue))) / MaxOverHealValue) * 100)) : 1)
- Hook `SetOverHeal`: `overHealValue`=(max((0x1869f - maxHp), 0) lt (MaxOverHealValue lt overHealValue ? MaxOverHealValue : overHealValue) ? max((0x1869f - maxHp), 0) : (MaxOverHealValue lt overHealValue ? MaxOverHealValue : overHealValue)); `localOverHealValue`=(max((0x1869f - maxHp), 0) lt (MaxOverHealValue lt overHealValue ? MaxOverHealValue : overHealValue) ? max((0x1869f - maxHp), 0) : (MaxOverHealValue lt overHealValue ? MaxOverHealValue : overHealValue)); `Count`=(?ccmp lt 0 ? int((((max((0x1869f - maxHp), 0) lt (MaxOverHealValue lt overHealValue ? MaxOverHealValue : overHealValue) ? max((0x1869f - maxHp), 0) : (MaxOverHealValue lt overHealValue ? MaxOverHealValue : overHealValue)) / MaxOverHealValue) * 100)) : 1)
- Hook `Damage`: `localOverHealValue`=(localOverHealValue gt damage ? (localOverHealValue - damage) : 0)
- Hook `UpdateCount`: `Count`=(?ccmp lt 0 ? int(((overHealValue / MaxOverHealValue) * 100)) : 1)

<details><summary>Effect applied in `SacredTeachings$$ReceiveHpHeal` (6 guarded paths)</summary>

- when `SkillLv(846) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-56), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>())) & 1) eq 0`
  - returns `SacredTeachingsBuf.SetOverHeal(0x165db78(meta(0x39aa418, SacredTeachingsBuf_TypeInfo), ?x1, ?x2, ?x3), [supportData+0x34], IPlayerStatusCalculator.get_MaxHp(PlayerStatusBase.get_SecondaryStatus()), 0)`
  - calls `System.Linq.Enumerable$$Contains<Int32Enum>`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db78`, `SacredTeachingsBuf$$.ctor`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferManager$$AddSelfBuffer`, `virtual PlayerStatusBase.get_SecondaryStatus`
- when `SkillLv(846) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-56), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
  - returns `SacredTeachingsBuf.SetOverHeal(TryGetBuf<object>.out2(), [supportData+0x34], IPlayerStatusCalculator.get_MaxHp(PlayerStatusBase.get_SecondaryStatus()), 0)`
  - calls `System.Linq.Enumerable$$Contains<Int32Enum>`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxHp`, `SacredTeachingsBuf$$SetOverHeal`
- when `SkillLv(846) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-56), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() eq 0`
  - returns `SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-56), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>()))`
  - calls `System.Linq.Enumerable$$Contains<Int32Enum>`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- when `SkillLv(846) ge 1` AND `TryGetBuf<object>.out2() ne 0`
  - returns `SacredTeachingsBuf.SetOverHeal(TryGetBuf<object>.out2(), [supportData+0x34], IPlayerStatusCalculator.get_MaxHp(PlayerStatusBase.get_SecondaryStatus()), 0)`
  - calls `System.Linq.Enumerable$$Contains<Int32Enum>`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxHp`, `SacredTeachingsBuf$$SetOverHeal`
- when `SkillLv(846) ge 1` AND `TryGetBuf<object>.out2() eq 0`
  - returns `SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-56), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>()))`
  - calls `System.Linq.Enumerable$$Contains<Int32Enum>`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- when `SkillLv(846) lt 1`
  - returns `SkillLv(846)`
  - calls `System.Linq.Enumerable$$Contains<Int32Enum>`, `virtual PlayerStatusBase.get_SkillManager`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `SacredTeachings$$ReceiveHpHeal (GetSkillLv)`

---

### โฮลี่เกรซ (HolyGrace) · uid 847

<img src="../../icons/sk_847.png" width="40" alt="icon"> 
**Type:** Support · **Max Lv:** 285 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เนเมซิส · **Client class:** `HolyGraceAction`

> สวรรค์ประทานพรให้ผู้บริสุทธิ์และพิพากษาเหล่าอธรรม
> เมื่อพลังชีวิตหมดจะทำให้ปาร์ตี้สามารถรักษาผล
> ของไอเท็มได้หนึ่งครั้งในระยะเวลาที่กำหนด
> นอกจากนี้การใช้ MP ของสกิลที่ถัดจาก
> ผู้ร่ายโฮลี่เกรซจะลดลงครึ่งหนึ่ง

<details><summary>In-game level notes</summary>

- Lv14: [จะได้รับผลแบบเดียวกันเมื่อใช้อุปกรณ์เวทมนตร์ (หลัก)]  ถ้าผลของ[สกิลที่ใช้ถัดไปจะลดMPที่ใช้ลงครึ่งหนึ่ง] ถูกใช้โดยบัฟสกิลที่กำหนด จะสร้างความเสียหาย ทางเวทให้กับมอนสเตอร์ทุกตัวในการต่อสู้ที่คุณเข้าร่วม

</details>

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 847

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `actionRange` = `MathUtil.DisplayMeterToDistance(24)`

**`ActionHit`** (2 paths)

- calls `HolyGraceBuf..ctor` = `.ctor(Lv, 1)` — when UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new HolyGraceBuf, Id)` — when UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(24)` — when UnityEngine.Object.op_Inequality(actarAction)
- calls `HolyGraceNextSkillMpHalvingBuf..ctor` = `.ctor(Lv)` — when UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new HolyGraceNextSkillMpHalvingBuf, 0)` — when UnityEngine.Object.op_Inequality(actarAction)

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

</details>

**Buffs**

**Buff `HolyGraceBuf`**
- Duration: `((Lv + (Lv << 2)) << 1)` s
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
**Buff `HolyGraceNextSkillMpHalvingBuf`**
- Duration: `(((Lv << 2) + lv) << 1)` s
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
**Buff `NextAttackBufferBase`**
- Attached to this skill via `caller2:HolyGraceNextSkillMpHalvingBuf$$.ctor<-HolyGraceAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `Lock`, `Unlock`
- Buff fields set in the constructor (all recovered):
  - `temporaryCount` = `-1` = -1
- Hook `Lock`: `Count`=count; `temporaryCount`=Count
- Hook `Unlock`: `temporaryCount`=-1; `Count`=temporaryCount
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:HolyGraceBuf$$.ctor<-HolyGraceAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

<details><summary>Effect applied in `MainPlayer$$PlayerDead` (300 guarded paths, truncated)</summary>

- when `(SkillBufferManager.ContainsBuffer(SkillBufferManager, 847, 0, serverMp) & 1) ne 0` AND `TryGetAutoMember.out3() ne 0` AND `(SkillBufferManager.TryGetBuf<object>(SkillBufferManager, 87, stkp(-88), meta(0x3982890, Method$SkillBufferManager.TryGetBuf<HuntingOneBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
  - returns `?blr`
  - calls `PlayerStatusBase$$UpdateEffectiveDeadItemDuration`, `PlayerDataManager$$GetPlayerDataManager`, `Toram.Common.ArchetypeUid$$get_Id`, `AutoMemberManager$$TryGetAutoMember`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveBuffer`, `HuntingOneActionManager$$OwnerDead`, `Toram.Common.ArchetypeUid$$get_Id`
- when `(SkillBufferManager.ContainsBuffer(SkillBufferManager, 847, 0, serverMp) & 1) ne 0` AND `TryGetAutoMember.out3() ne 0` AND `(SkillBufferManager.TryGetBuf<object>(SkillBufferManager, 87, stkp(-88), meta(0x3982890, Method$SkillBufferManager.TryGetBuf<HuntingOneBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
  - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, MainPlayer.WaitEnable(this, (actDead & 1), ?x2, ?x3), 0, ?x3)`
  - calls `PlayerStatusBase$$UpdateEffectiveDeadItemDuration`, `PlayerDataManager$$GetPlayerDataManager`, `Toram.Common.ArchetypeUid$$get_Id`, `AutoMemberManager$$TryGetAutoMember`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveBuffer`, `HuntingOneActionManager$$OwnerDead`, `Toram.Common.ArchetypeUid$$get_Id`
- when `(SkillBufferManager.ContainsBuffer(SkillBufferManager, 847, 0, serverMp) & 1) ne 0` AND `TryGetAutoMember.out3() ne 0` AND `(SkillBufferManager.TryGetBuf<object>(SkillBufferManager, 87, stkp(-88), meta(0x3982890, Method$SkillBufferManager.TryGetBuf<HuntingOneBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
  - calls `PlayerStatusBase$$UpdateEffectiveDeadItemDuration`, `PlayerDataManager$$GetPlayerDataManager`, `Toram.Common.ArchetypeUid$$get_Id`, `AutoMemberManager$$TryGetAutoMember`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveBuffer`, `HuntingOneActionManager$$OwnerDead`, `Toram.Common.ArchetypeUid$$get_Id`
- when `(SkillBufferManager.ContainsBuffer(SkillBufferManager, 847, 0, serverMp) & 1) ne 0` AND `TryGetAutoMember.out3() ne 0` AND `(SkillBufferManager.TryGetBuf<object>(SkillBufferManager, 87, stkp(-88), meta(0x3982890, Method$SkillBufferManager.TryGetBuf<HuntingOneBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
  - returns `?blr`
  - calls `PlayerStatusBase$$UpdateEffectiveDeadItemDuration`, `PlayerDataManager$$GetPlayerDataManager`, `Toram.Common.ArchetypeUid$$get_Id`, `AutoMemberManager$$TryGetAutoMember`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveBuffer`, `HuntingOneActionManager$$OwnerDead`, `Toram.Common.ArchetypeUid$$get_Id`
- when `(SkillBufferManager.ContainsBuffer(SkillBufferManager, 847, 0, serverMp) & 1) ne 0` AND `TryGetAutoMember.out3() ne 0` AND `(SkillBufferManager.TryGetBuf<object>(SkillBufferManager, 87, stkp(-88), meta(0x3982890, Method$SkillBufferManager.TryGetBuf<HuntingOneBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
  - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, MainPlayer.WaitEnable(this, (actDead & 1), ?x2, ?x3), 0, ?x3)`
  - calls `PlayerStatusBase$$UpdateEffectiveDeadItemDuration`, `PlayerDataManager$$GetPlayerDataManager`, `Toram.Common.ArchetypeUid$$get_Id`, `AutoMemberManager$$TryGetAutoMember`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveBuffer`, `HuntingOneActionManager$$OwnerDead`, `Toram.Common.ArchetypeUid$$get_Id`
- when `(SkillBufferManager.ContainsBuffer(SkillBufferManager, 847, 0, serverMp) & 1) ne 0` AND `TryGetAutoMember.out3() ne 0` AND `(SkillBufferManager.TryGetBuf<object>(SkillBufferManager, 87, stkp(-88), meta(0x3982890, Method$SkillBufferManager.TryGetBuf<HuntingOneBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
  - calls `PlayerStatusBase$$UpdateEffectiveDeadItemDuration`, `PlayerDataManager$$GetPlayerDataManager`, `Toram.Common.ArchetypeUid$$get_Id`, `AutoMemberManager$$TryGetAutoMember`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveBuffer`, `HuntingOneActionManager$$OwnerDead`, `Toram.Common.ArchetypeUid$$get_Id`
- when `(SkillBufferManager.ContainsBuffer(SkillBufferManager, 847, 0, serverMp) & 1) ne 0` AND `TryGetAutoMember.out3() ne 0` AND `(SkillBufferManager.TryGetBuf<object>(SkillBufferManager, 87, stkp(-88), meta(0x3982890, Method$SkillBufferManager.TryGetBuf<HuntingOneBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
  - returns `?blr`
  - calls `PlayerStatusBase$$UpdateEffectiveDeadItemDuration`, `PlayerDataManager$$GetPlayerDataManager`, `Toram.Common.ArchetypeUid$$get_Id`, `AutoMemberManager$$TryGetAutoMember`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveBuffer`, `HuntingOneActionManager$$OwnerDead`, `Toram.Common.ArchetypeUid$$get_Id`
- when `(SkillBufferManager.ContainsBuffer(SkillBufferManager, 847, 0, serverMp) & 1) ne 0` AND `TryGetAutoMember.out3() ne 0` AND `(SkillBufferManager.TryGetBuf<object>(SkillBufferManager, 87, stkp(-88), meta(0x3982890, Method$SkillBufferManager.TryGetBuf<HuntingOneBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
  - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, MainPlayer.WaitEnable(this, (actDead & 1), ?x2, ?x3), 0, ?x3)`
  - calls `PlayerStatusBase$$UpdateEffectiveDeadItemDuration`, `PlayerDataManager$$GetPlayerDataManager`, `Toram.Common.ArchetypeUid$$get_Id`, `AutoMemberManager$$TryGetAutoMember`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveBuffer`, `HuntingOneActionManager$$OwnerDead`, `Toram.Common.ArchetypeUid$$get_Id`

</details>

<details><summary>Effect applied in `PlayerBattleManager.<HolyGracePursuitAttack>d__148$$MoveNext` (5 guarded paths)</summary>

- when `<HolyGracePursuitAttack>d__148.<>1__state eq 1` AND `SkillLv(847) ge 1`
  - returns `0`
  - set `<>1__state` = `-1`
  - calls `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$get_TargetableMobList`, `System.Collections.Generic.List<object>$$GetEnumerator`, `System.Collections.Generic.List.Enumerator<object>$$MoveNext`, `HolyGracePursuitAttackAction$$CheckHate`, `SkillFactory$$CreateSkill`, `SkillActionBase$$Initialize`, `interface MobActionManagerBase.get_gameObject`
- when `<HolyGracePursuitAttack>d__148.<>1__state eq 1` AND `SkillLv(847) ge 1`
  - returns `0`
  - set `<>1__state` = `-1`
  - calls `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$get_TargetableMobList`, `System.Collections.Generic.List<object>$$GetEnumerator`, `System.Collections.Generic.List.Enumerator<object>$$MoveNext`, `HolyGracePursuitAttackAction$$CheckHate`, `SkillFactory$$CreateSkill`, `System.Collections.Generic.List.Enumerator<object>$$Dispose`
- when `<HolyGracePursuitAttack>d__148.<>1__state eq 1` AND `SkillLv(847) ge 1`
  - set `<>1__state` = `-1`
  - calls `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$get_TargetableMobList`, `System.Collections.Generic.List<object>$$GetEnumerator`, `System.Collections.Generic.List.Enumerator<object>$$MoveNext`, `HolyGracePursuitAttackAction$$CheckHate`, `System.Collections.Generic.List.Enumerator<object>$$MoveNext`, `HolyGracePursuitAttackAction$$CheckHate`, `System.Collections.Generic.List.Enumerator<object>$$MoveNext`
- when `<HolyGracePursuitAttack>d__148.<>1__state eq 1` AND `SkillLv(847) ge 1`
  - returns `0`
  - set `<>1__state` = `-1`
  - calls `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$get_TargetableMobList`, `System.Collections.Generic.List<object>$$GetEnumerator`, `System.Collections.Generic.List.Enumerator<object>$$MoveNext`, `System.Collections.Generic.List.Enumerator<object>$$Dispose`
- when `<HolyGracePursuitAttack>d__148.<>1__state eq 1` AND `SkillLv(847) lt 1`
  - returns `0`
  - set `<>1__state` = `-1`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `MainPlayer$$PlayerDead (ContainsBuffer)`
- `PlayerBattleManager.<HolyGracePursuitAttack>d__148$$MoveNext (GetSkillLv)`

---
