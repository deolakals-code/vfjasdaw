# スプライトスキル (`SpriteSkill`)

18 entries. See ../README.md for how to read these blocks.

### ออโต้ดีไวซ์ (AutoDevice) · uid 705

<img src="../../icons/sk_705.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 1) · **Type:** Buffer · **Max Lv:** 50 · **Weapons:** MainMagictool · **Flags:** StarGem · **Client class:** `AutoDeviceAction`

> ทักษะที่ยอมให้อุปกรณ์เวทมนตร์ช่วยโจมตี
> การโจมตีปกติใส่เป้าหมายหลังจาก
> ไม่ได้ทำอะไรเป็นเวลา 60 วินาที
> ประสิทธิภาพลดลงถ้าอยู่ห่างออกไป (8 เมตรหรือมากกว่า)

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 705

<details><summary>Recovered formulas (per method)</summary>

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (2 paths)

- calls `AutoDeviceBuf..ctor` = `.ctor(Lv, EnhanceSprite.GetEnhanceParam(PlayerStatusBase.get_SkillManager().SkillMasteryList[719], PlayerAttackBase.get_ActionID()))`
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new AutoDeviceBuf, Id)`
- calls `AutoDeviceBuf..ctor` = `.ctor(Lv, 0)`

</details>

**Buffs**

**Buff `AutoDeviceBuf`**
- Buff hook methods: `get_ActionRange`, `get_FarRangeDist`
- Duration: `(0 + 60)` s

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Percent | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |
| Value | 14 | 13 | 12 | 11 | 10 | 9 | 8 | 7 | 6 | 5 |

- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:AutoDeviceBuf$$.ctor<-AutoDeviceAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

<details><summary>Effect applied in `MobaPlayerActionManager$$Update` (24 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 705, stkp(-40), 0) & 1) ne 0`
  - returns `MobaPlayerActionManager.DashClear(this, ?x1, ?x2, ?x3)`
  - set `moveDashTimer` = `0`
  - calls `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `PlayerActionManagerBase$$Update`, `Singleton<object>$$get_Instance`, `MobaPlayerActionManager$$get_IsInputLock`, `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `MobaPlayerActionManager$$NextSkillReserve`, `BattleManagerBase$$get_IsRegisteredAction`, `MobaPlayerBattleManager$$StartAutoDeviceAttack`
- when `(SkillBufferManager.TryGetBuf(?blr, 705, stkp(-40), 0) & 1) ne 0`
  - returns `?blr`
  - set `moveDashTimer` = `0`
  - calls `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `PlayerActionManagerBase$$Update`, `Singleton<object>$$get_Instance`, `MobaPlayerActionManager$$get_IsInputLock`, `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `MobaPlayerActionManager$$NextSkillReserve`, `BattleManagerBase$$get_IsRegisteredAction`, `MobaPlayerBattleManager$$StartAutoDeviceAttack`
- when `(SkillBufferManager.TryGetBuf(?blr, 705, stkp(-40), 0) & 1) ne 0`
  - returns `MobaPlayerActionManager.DashClear(this, ?x1, ?x2, ?x3)`
  - set `moveDashTimer` = `0`
  - calls `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `PlayerActionManagerBase$$Update`, `Singleton<object>$$get_Instance`, `MobaPlayerActionManager$$get_IsInputLock`, `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `MobaPlayerActionManager$$NextSkillReserve`, `BattleManagerBase$$get_IsRegisteredAction`, `MobaPlayerActionManager$$moveCheck`
- when `(SkillBufferManager.TryGetBuf(?blr, 705, stkp(-40), 0) & 1) ne 0`
  - returns `?blr`
  - set `moveDashTimer` = `0`
  - calls `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `PlayerActionManagerBase$$Update`, `Singleton<object>$$get_Instance`, `MobaPlayerActionManager$$get_IsInputLock`, `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `MobaPlayerActionManager$$NextSkillReserve`, `BattleManagerBase$$get_IsRegisteredAction`, `MobaPlayerActionManager$$moveCheck`
- when `(SkillBufferManager.TryGetBuf(?blr, 705, stkp(-40), 0) & 1) eq 0`
  - returns `MobaPlayerActionManager.DashClear(this, ?x1, ?x2, ?x3)`
  - set `moveDashTimer` = `0`
  - calls `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `PlayerActionManagerBase$$Update`, `Singleton<object>$$get_Instance`, `MobaPlayerActionManager$$get_IsInputLock`, `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `MobaPlayerActionManager$$NextSkillReserve`, `MobaPlayerActionManager$$moveCheck`, `TakeController$$get_MainPlayer`
- when `(SkillBufferManager.TryGetBuf(?blr, 705, stkp(-40), 0) & 1) eq 0`
  - returns `?blr`
  - set `moveDashTimer` = `0`
  - calls `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `PlayerActionManagerBase$$Update`, `Singleton<object>$$get_Instance`, `MobaPlayerActionManager$$get_IsInputLock`, `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `MobaPlayerActionManager$$NextSkillReserve`, `MobaPlayerActionManager$$moveCheck`, `TakeController$$get_MainPlayer`
- when `(SkillBufferManager.TryGetBuf(?blr, 705, stkp(-40), 0) & 1) ne 0`
  - returns `MobaPlayerActionManager.DashClear(this, ?x1, ?x2, ?x3)`
  - set `moveDashTimer` = `0`
  - calls `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `PlayerActionManagerBase$$Update`, `Singleton<object>$$get_Instance`, `MobaPlayerActionManager$$get_IsInputLock`, `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `MobaPlayerActionManager$$NextSkillReserve`, `BattleManagerBase$$get_IsRegisteredAction`, `MobaPlayerBattleManager$$StartAutoDeviceAttack`
- when `(SkillBufferManager.TryGetBuf(?blr, 705, stkp(-40), 0) & 1) ne 0`
  - returns `?blr`
  - set `moveDashTimer` = `0`
  - calls `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `PlayerActionManagerBase$$Update`, `Singleton<object>$$get_Instance`, `MobaPlayerActionManager$$get_IsInputLock`, `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `MobaPlayerActionManager$$NextSkillReserve`, `BattleManagerBase$$get_IsRegisteredAction`, `MobaPlayerBattleManager$$StartAutoDeviceAttack`

</details>

<details><summary>Effect applied in `PlayerActionManager$$Update` (291 guarded paths, truncated)</summary>

- always
  - returns `PlayerActionManager.SnowballColCheck(this, ?x1, ?x2, ?x3)`
  - set `battleEndDashWait` = `0`
  - set `moveDashTimer` = `(moveDashTimer - (3 - UnityEngine.Time.get_deltaTime(0, ?x1, ?x2, ?x3)))`
  - set `nextTargetType` = `4`
  - set `nextSkill` = `0`
  - calls `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `PlayerActionManagerBase$$Update`, `Singleton<object>$$get_Instance`, `FunctionLimitManager$$IsLimited`, `PlayerActionManagerBase$$get_IsBattleActive`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`
- always
  - returns `PlayerActionManager.SnowballColCheck(this, meta(0), ?x2, ?x3)`
  - set `battleEndDashWait` = `0`
  - set `moveDashTimer` = `(moveDashTimer - (3 - UnityEngine.Time.get_deltaTime(0, ?x1, ?x2, ?x3)))`
  - set `nextTargetType` = `4`
  - set `nextSkill` = `0`
  - calls `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `PlayerActionManagerBase$$Update`, `Singleton<object>$$get_Instance`, `FunctionLimitManager$$IsLimited`, `PlayerActionManagerBase$$get_IsBattleActive`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`
- always
  - returns `PlayerActionManager.SnowballColCheck(this, ?x1, ?x2, ?x3)`
  - set `battleEndDashWait` = `0`
  - set `moveDashTimer` = `(moveDashTimer - (3 - UnityEngine.Time.get_deltaTime(0, ?x1, ?x2, ?x3)))`
  - set `nextTargetType` = `4`
  - set `nextSkill` = `0`
  - calls `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `PlayerActionManagerBase$$Update`, `Singleton<object>$$get_Instance`, `FunctionLimitManager$$IsLimited`, `PlayerActionManagerBase$$get_IsBattleActive`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`
- always
  - returns `PlayerActionManager.SnowballColCheck(this, meta(0), ?x2, ?x3)`
  - set `battleEndDashWait` = `0`
  - set `moveDashTimer` = `(moveDashTimer - (3 - UnityEngine.Time.get_deltaTime(0, ?x1, ?x2, ?x3)))`
  - set `nextTargetType` = `4`
  - set `nextSkill` = `0`
  - calls `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `PlayerActionManagerBase$$Update`, `Singleton<object>$$get_Instance`, `FunctionLimitManager$$IsLimited`, `PlayerActionManagerBase$$get_IsBattleActive`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`
- always
  - returns `PlayerActionManager.SnowballColCheck(this, ?x1, ?x2, ?x3)`
  - set `battleEndDashWait` = `0`
  - set `moveDashTimer` = `(moveDashTimer - (3 - UnityEngine.Time.get_deltaTime(0, ?x1, ?x2, ?x3)))`
  - set `nextTargetType` = `4`
  - set `nextSkill` = `0`
  - calls `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `PlayerActionManagerBase$$Update`, `Singleton<object>$$get_Instance`, `FunctionLimitManager$$IsLimited`, `PlayerActionManagerBase$$get_IsBattleActive`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`
- always
  - returns `PlayerActionManager.SnowballColCheck(this, meta(0), ?x2, ?x3)`
  - set `battleEndDashWait` = `0`
  - set `moveDashTimer` = `(moveDashTimer - (3 - UnityEngine.Time.get_deltaTime(0, ?x1, ?x2, ?x3)))`
  - set `nextTargetType` = `4`
  - set `nextSkill` = `0`
  - calls `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `PlayerActionManagerBase$$Update`, `Singleton<object>$$get_Instance`, `FunctionLimitManager$$IsLimited`, `PlayerActionManagerBase$$get_IsBattleActive`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`
- always
  - returns `PlayerActionManager.SnowballColCheck(this, ?x1, ?x2, ?x3)`
  - set `battleEndDashWait` = `0`
  - set `moveDashTimer` = `(moveDashTimer - (3 - UnityEngine.Time.get_deltaTime(0, ?x1, ?x2, ?x3)))`
  - set `nextTargetType` = `4`
  - set `nextSkill` = `0`
  - calls `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `PlayerActionManagerBase$$Update`, `Singleton<object>$$get_Instance`, `FunctionLimitManager$$IsLimited`, `PlayerActionManagerBase$$get_IsBattleActive`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`
- always
  - returns `PlayerActionManager.SnowballColCheck(this, meta(0), ?x2, ?x3)`
  - set `battleEndDashWait` = `0`
  - set `moveDashTimer` = `(moveDashTimer - (3 - UnityEngine.Time.get_deltaTime(0, ?x1, ?x2, ?x3)))`
  - set `nextTargetType` = `4`
  - set `nextSkill` = `0`
  - calls `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `PlayerActionManagerBase$$Update`, `Singleton<object>$$get_Instance`, `FunctionLimitManager$$IsLimited`, `PlayerActionManagerBase$$get_IsBattleActive`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `MobaPlayerActionManager$$Update (TryGetBuf)`
- `PlayerActionManager$$Update (TryGetBuf)`

---

### อิกนิชั่น (Ignition) · uid 715

<img src="../../icons/sk_715.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 1) · **Type:** Attack · **Max Lv:** 50 · **Weapons:** MainMagictool · **Client class:** `IgnitionAction`

> เผาผลาญพลังเวทของศัตรูเพื่อโจมตี
> สร้างความเสียหายเวทมนตร์ที่ไม่เสถียร
> มีโอกาสต่ำที่จะทำให้ศัตรูติด[อ่อนแอ]
> DEX และเลเวลของสไปรท์ทรีของคุณยิ่งสูงเท่าไหร่
> จะยิ่งมีโอกาสติดมากขึ้น

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((System.Math.Min(((Lv * 60) + status.EqAtk), 1200)) / 100)`

**Role:** attack (deals damage) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `100`
- `SkillRate` multiplies by (adds into): `((System.Math.Min(((Lv * 60) + status.EqAtk), 1200)) / 100)`
- `StableRate` sets: `PlayerAttackBase.CalcStable(IgnitionAction.get_AttackType(), int((status.Stable + (status.Stable * -0.6))), (SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) & 1), PlayerActionManagerBase.get_PlayerStatus())`

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 715

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`
- set `skillRate` = `System.Math.Min(((Lv * 60) + status.EqAtk), 1200)`
- set `abnomalParcent` = `((SkillManager.GetSkillTreeLv(PlayerStatusBase.get_SkillManager(), 22, 0) + (SkillManager.GetSkillTreeLv(PlayerStatusBase.get_SkillManager(), 22, 0) << 2)) + ((baseDEX // 10) + ((Lv << 1) + (Lv >> 1))))`

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`calcPlayerToMobDamage`** (8 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `SetRate[StableRate]` = `PlayerAttackBase.CalcStable(IgnitionAction.get_AttackType(), int((status.Stable + (status.Stable * -0.6))), (SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) & 1), PlayerActionManagerBase.get_PlayerStatus())`
- template `AddConstant[SkillConstantDamage]` = `100`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(16, abnomalParcent, playerAction)`
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(16, 0, 0)` — when PlayerAttackBase.checkAbnormalPercent(this, 16, abnomalParcent, playerAction)
- info `templates` = `1`

</details>

---

### เอ็กเพรสเอด (RushAid) · uid 706

<img src="../../icons/sk_706.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 90 · **Weapons:** MainMagictool · **Requires:** ออโต้ดีไวซ์ · **Client class:** `RushAidMastery` (passive mastery)

> เร่งแรงส่งอุปกรณ์เวทมนตร์ให้เร็วขึ้น
> 
> เพิ่มความเร็วในการเคลื่อนที่ไปยังผู้เล่น
> ที่เป็นเป้าหมายเมื่อใช้"ปฐมพยาบาล"
> และลดความเสียหายที่ได้รับตามจำนวนครั้งที่กำหนด

**Role:** buff (self) · passive mastery

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| CutDmgRate | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |
| Value | 0 | 0 | 0 | 1 | 1 | 1 | 1 | 2 | 2 | 2 |


**Buffs**

**Buff `RushAidBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `EndFunction`, `OnDamage`
- `MobLastDamageRateBuf` = `0` _(when resistCount lt 1)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MobLastDamageRateBuf | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |

- Buff fields set in the constructor (all recovered):
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
  - `BufEffectTakeUid` = `-1` = -1
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `resistCount` = `((((Lv - 1) + (((Lv - 1) & 0xc000) >> 14)) >> 2) + 1)` → Lv1..10 [1, 1, 1, 1, 2, 2, 2, 2, 3, 3]
  - `battleManager` = `battleManager`
  - `charaMove` = `move`
  - `endAction` = `callBack`
  - `target` = `target`
- Hook `Updata`: `timer`=(timer + UnityEngine.Time.get_deltaTime()); `timer`=0
- Hook `OnDamage`: `resistCount`=(resistCount - 1)

<details><summary>Effect applied in `PlayerActionManager$$get_MoveSpeed` (66 guarded paths)</summary>

- always
  - returns `SummerEventRoomData.GetMoveSpeed([Singleton<object>.get_Instance(meta(0x3974220, Method$Singleton<RoomManager>.get_Instance()), ?x1, ?x2, ?x3)+0x28], 0, ?x2, ?x3)`
  - calls `AbnormalStateManager$$Contains`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`
- always
  - returns `SkillBufferManager.ContainsBuffer(?blr, 706, 0, ?x3)`
  - calls `AbnormalStateManager$$Contains`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `AbnormalStateManager$$Contains`
- always
  - returns `AbnormalStateManager.Contains(?blr, 11, 0, ?x3)`
  - calls `AbnormalStateManager$$Contains`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `AbnormalStateManager$$Contains`
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

</details>

<details><summary>Effect applied in `PlayerActionManager$$Damaged` (11 guarded paths)</summary>

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
- when `(SkillBufferManager.TryGetBuf(?blr, 706, stkp(-152), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `0x165db84`, `0x165df00`, `0x165df00`
- when `(SkillBufferManager.TryGetBuf(?blr, 706, stkp(-152), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-152), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-152), 0) & 1) ne 0`
  - returns `ImprovisationSongAction.Damaged(this, 0, ?x2, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `GodHandBuf$$DamageFunction`, `ImprovisationSongAction$$Damaged`
- when `(SkillBufferManager.TryGetBuf(?blr, 706, stkp(-152), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-152), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-152), 0) & 1) eq 0`
  - returns `ImprovisationSongAction.Damaged(this, 0, ?x2, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `ImprovisationSongAction$$Damaged`
- when `(SkillBufferManager.TryGetBuf(?blr, 706, stkp(-152), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-152), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `0x165db84`, `0x165df00`, `0x165df00`

</details>

<details><summary>Effect applied in `PlayerBattleManager.<>c__DisplayClass53_0$$<checkAssistMove>b__0` (2 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 706, (this + 24), 0) & 1) ne 0`
  - returns `SkillBufferDataBase.End([(this + 24)+0x0], 0, ?x2, ?x3)`
  - calls `SkillBufferDataBase$$End`
- when `(SkillBufferManager.TryGetBuf(?blr, 706, (this + 24), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 706, (this + 24), 0)`

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

- `MobAttackBase$$CalcLastDamage (TryGetBuf)`
- `PlayerActionManager$$Damaged (TryGetBuf)`
- `PlayerActionManager$$get_MoveSpeed (ContainsBuffer)`
- `PlayerBattleManager.<>c__DisplayClass53_0$$<checkAssistMove>b__0 (TryGetBuf)`

---

### เคาน์เตอร์ฟอร์ส (CounterForce) · uid 707

<img src="../../icons/sk_707.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 2) · **Type:** Object · **Max Lv:** 90 · **Weapons:** MainMagictool · **Requires:** ออโต้ดีไวซ์ · **Client class:** `CounterForceAction`

> ทักษะเสริมของอุปกรณ์เวทมนตร์
> สร้างวงเวทเป็นเวลา 30 วินาที
> เพื่อโจมตีเป้าหมายหากสมาชิกในปาร์ตี้
> อยู่ในสายตาระยะ(ไม่เกิน 24m) (สูงสุด 3 ครั้ง)

**Role:** buff (self) · placed object / trap / summon

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 707

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (1 path)

- calls `CounterForceBuf..ctor` = `.ctor(Lv, actarAction)`
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new CounterForceBuf, Id)`

</details>

**Buffs**

**Buff `CounterForceBuf`**
- Buff hook methods: `CheckInSight`, `EndSkill`, `ReceveOtherPlayerDamaged`, `RecevePlayerDamaged`
- Duration: `(30 + EnhanceSprite.GetEnhanceParam(PlayerStatusBase.get_SkillManager().SkillMasteryList[719], CounterForceBuf.get_SkillId()))` s; `30` s
- Buff fields set in the constructor (all recovered):
  - `skillList` = `new System.Collections.Generic.List<SkillActionBase>`
  - `range` = `MathUtil.DisplayMeterToDistance(24)`
  - `playerAction` = `playerAction`
  - `battleManager` = `playerAction.battleManager`
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `mobaBattleManager` = `playerAction.battleManager` when UnityEngine.Object.op_Equality(playerAction.battleManager)
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:CounterForceBuf$$.ctor<-CounterForceAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

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

<details><summary>Effect applied in `CounterForceAttackAction$$OnEnd` (3 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 707, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `PlayerAttackBase.OnEnd(this, (cancel & 1), 0, ?x3)`
  - calls `CounterForceBuf$$EndSkill`, `PlayerAttackBase$$OnEnd`
- when `(SkillBufferManager.TryGetBuf(?blr, 707, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `0x165db84`, `0x165df00`
- when `(SkillBufferManager.TryGetBuf(?blr, 707, stkp(-40), 0) & 1) eq 0`
  - returns `PlayerAttackBase.OnEnd(this, (cancel & 1), 0, ?x3)`
  - calls `PlayerAttackBase$$OnEnd`

</details>

<details><summary>Effect applied in `MobaPlayerBattleManager$$StartCounterForceAttack` (3 guarded paths)</summary>

- when `SkillLv(707) ge 1`
  - calls `SkillFactory$$CreateSkill`, `0x165d8dc`, `SkillActionBase$$Initialize`, `UnityEngine.GameObject$$GetComponent<object>`, `PlayerSkillActionManager$$PlaceEffectPlay`
- when `SkillLv(707) ge 1`
  - returns `UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<object>(target, meta(0x39745c0, Method$UnityEngine.GameObject.GetComponent<CharacterActionManagerBase>()), ?x2, ?x3), 0, 0, ?x3)`
  - calls `SkillFactory$$CreateSkill`, `0x165d8dc`, `SkillActionBase$$Initialize`, `UnityEngine.GameObject$$GetComponent<object>`
- when `SkillLv(707) lt 1`
  - returns `SkillLv(707)`
  - calls `SkillFactory$$CreateSkill`, `0x165d8dc`

</details>

<details><summary>Effect applied in `PlayerBattleManager$$StartCounterForceAttack` (3 guarded paths)</summary>

- when `SkillLv(707) ge 1`
  - calls `SkillFactory$$CreateSkill`, `0x165d8dc`, `SkillActionBase$$Initialize`, `UnityEngine.GameObject$$GetComponent<object>`, `PlayerSkillActionManager$$PlaceEffectPlay`
- when `SkillLv(707) ge 1`
  - returns `UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<object>(target, meta(0x39745c0, Method$UnityEngine.GameObject.GetComponent<CharacterActionManagerBase>()), ?x2, ?x3), 0, 0, ?x3)`
  - calls `SkillFactory$$CreateSkill`, `0x165d8dc`, `SkillActionBase$$Initialize`, `UnityEngine.GameObject$$GetComponent<object>`
- when `SkillLv(707) lt 1`
  - returns `SkillLv(707)`
  - calls `SkillFactory$$CreateSkill`, `0x165d8dc`

</details>

<details><summary>Effect applied in `FamiliaActionManager$$Damaged` (231 guarded paths, truncated)</summary>

- when `IsHighFamilia eq 0` AND `(CharacterActionManagerBase.get_IsLocalDead() & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `FamiliaMovingAI.ChangeStateAction(familiaAI, 0, ?x2, ?x3)`
  - calls `SkillDamageData$$SetAbnormalType`, `BattleManagerBase$$get_IsRegisteredAction`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `interface IPlayerStatusCalculator.get_MaxHp`, `TransformShake$$Shake`
- when `IsHighFamilia eq 0` AND `(CharacterActionManagerBase.get_IsLocalDead() & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `SkillActionBase.op_Equality(0, CharacterActionManagerBase.get_IsLocalDead(), 0, ?x3)`
  - calls `SkillDamageData$$SetAbnormalType`, `BattleManagerBase$$get_IsRegisteredAction`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `interface IPlayerStatusCalculator.get_MaxHp`, `TransformShake$$Shake`
- when `IsHighFamilia eq 0` AND `(CharacterActionManagerBase.get_IsLocalDead() & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `SkillActionBase.op_Equality(0, CharacterActionManagerBase.get_IsLocalDead(), 0, ?x3)`
  - calls `SkillDamageData$$SetAbnormalType`, `BattleManagerBase$$get_IsRegisteredAction`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `interface IPlayerStatusCalculator.get_MaxHp`, `TransformShake$$Shake`
- when `IsHighFamilia eq 0` AND `(CharacterActionManagerBase.get_IsLocalDead() & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `SkillDamageData$$SetAbnormalType`, `BattleManagerBase$$get_IsRegisteredAction`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `interface IPlayerStatusCalculator.get_MaxHp`, `TransformShake$$Shake`
- when `IsHighFamilia eq 0` AND `(CharacterActionManagerBase.get_IsLocalDead() & 1) ne 0`
  - returns `FamiliaMovingAI.ChangeStateAction(familiaAI, 0, ?x2, ?x3)`
  - calls `SkillDamageData$$SetAbnormalType`, `BattleManagerBase$$get_IsRegisteredAction`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `interface IPlayerStatusCalculator.get_MaxHp`, `TransformShake$$Shake`
- when `IsHighFamilia eq 0` AND `(CharacterActionManagerBase.get_IsLocalDead() & 1) ne 0`
  - returns `SkillActionBase.op_Equality(0, CharacterActionManagerBase.get_IsLocalDead(), 0, ?x3)`
  - calls `SkillDamageData$$SetAbnormalType`, `BattleManagerBase$$get_IsRegisteredAction`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `interface IPlayerStatusCalculator.get_MaxHp`, `TransformShake$$Shake`
- when `IsHighFamilia eq 0` AND `(CharacterActionManagerBase.get_IsLocalDead() & 1) ne 0`
  - returns `SkillActionBase.op_Equality(0, CharacterActionManagerBase.get_IsLocalDead(), 0, ?x3)`
  - calls `SkillDamageData$$SetAbnormalType`, `BattleManagerBase$$get_IsRegisteredAction`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `interface IPlayerStatusCalculator.get_MaxHp`, `TransformShake$$Shake`
- when `IsHighFamilia eq 0` AND `(CharacterActionManagerBase.get_IsLocalDead() & 1) ne 0` AND `aiLock eq 0`
  - returns `FamiliaMovingAI.ChangeStateAction(familiaAI, 0, ?x2, ?x3)`
  - calls `SkillDamageData$$SetAbnormalType`, `BattleManagerBase$$get_IsRegisteredAction`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `interface IPlayerStatusCalculator.get_MaxHp`, `TransformShake$$Shake`

</details>

<details><summary>Effect applied in `OtherPlayer$$OnActionMobAttack` (216 guarded paths)</summary>

- when `(OtherPlayer.get_IsPartyMember() & 1) eq 0` AND `TryGetBuf.out2() ne 0`
  - returns `CounterForceBuf.ReceveOtherPlayerDamaged(TryGetBuf.out2(), UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), MobManager.GetPartyEnemy(TargetableListManagerBase<object>.get_Instance(meta(0x3974240, Method$TargetableListManagerBase<MobManager>.get_Instance()), ?x1, ?x2, ?x3), [eventData+0x20], 1, 0), 0)`
  - calls `virtual OtherPlayer.get_IsPartyMember`, `OtherPlayer$$get_IsServerMobCreate`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$ContainsPartyEnemy`, `TargetableListManagerBase<object>$$get_Instance`, `UnityEngine.Component$$get_gameObject`, `MobManager$$CreatePartyUnmanagedEnemy`, `OtherPlayer$$get_IsServerMobCreate`
- when `(OtherPlayer.get_IsPartyMember() & 1) eq 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual OtherPlayer.get_IsPartyMember`, `OtherPlayer$$get_IsServerMobCreate`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$ContainsPartyEnemy`, `TargetableListManagerBase<object>$$get_Instance`, `UnityEngine.Component$$get_gameObject`, `MobManager$$CreatePartyUnmanagedEnemy`, `OtherPlayer$$get_IsServerMobCreate`
- when `(OtherPlayer.get_IsPartyMember() & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(PlayerDataManager.get_SkillBufferManager(playerDataManager, 0, ?x2, ?x3), 707, stkp(-72), 0)`
  - calls `virtual OtherPlayer.get_IsPartyMember`, `OtherPlayer$$get_IsServerMobCreate`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$ContainsPartyEnemy`, `TargetableListManagerBase<object>$$get_Instance`, `UnityEngine.Component$$get_gameObject`, `MobManager$$CreatePartyUnmanagedEnemy`, `OtherPlayer$$get_IsServerMobCreate`
- when `(OtherPlayer.get_IsPartyMember() & 1) eq 0`
  - returns `PartyManager.ContainsPartyMember(Singleton<object>.get_Instance(meta(0x3974068, Method$Singleton<PartyManager>.get_Instance()), ?x1, ?x2, ?x3), [archetype+0x1c], [archetype+0x18], 0)`
  - calls `virtual OtherPlayer.get_IsPartyMember`, `OtherPlayer$$get_IsServerMobCreate`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$ContainsPartyEnemy`, `TargetableListManagerBase<object>$$get_Instance`, `UnityEngine.Component$$get_gameObject`, `MobManager$$CreatePartyUnmanagedEnemy`, `OtherPlayer$$get_IsServerMobCreate`
- when `(OtherPlayer.get_IsPartyMember() & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(PlayerDataManager.get_SkillBufferManager(playerDataManager, 0, ?x2, ?x3), 707, stkp(-72), 0)`
  - calls `virtual OtherPlayer.get_IsPartyMember`, `OtherPlayer$$get_IsServerMobCreate`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$ContainsPartyEnemy`, `TargetableListManagerBase<object>$$get_Instance`, `UnityEngine.Component$$get_gameObject`, `MobManager$$CreatePartyUnmanagedEnemy`, `OtherPlayer$$get_IsServerMobCreate`
- when `(OtherPlayer.get_IsPartyMember() & 1) eq 0` AND `TryGetBuf.out2() ne 0`
  - returns `CounterForceBuf.ReceveOtherPlayerDamaged(TryGetBuf.out2(), UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), MobManager.GetPartyEnemy(TargetableListManagerBase<object>.get_Instance(meta(0x3974240, Method$TargetableListManagerBase<MobManager>.get_Instance()), ?x1, ?x2, ?x3), [eventData+0x20], 1, 0), 0)`
  - calls `virtual OtherPlayer.get_IsPartyMember`, `OtherPlayer$$get_IsServerMobCreate`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$ContainsPartyEnemy`, `TargetableListManagerBase<object>$$get_Instance`, `UnityEngine.Component$$get_gameObject`, `MobManager$$CreatePartyUnmanagedEnemy`, `OtherPlayer$$get_IsServerMobCreate`
- when `(OtherPlayer.get_IsPartyMember() & 1) eq 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual OtherPlayer.get_IsPartyMember`, `OtherPlayer$$get_IsServerMobCreate`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$ContainsPartyEnemy`, `TargetableListManagerBase<object>$$get_Instance`, `UnityEngine.Component$$get_gameObject`, `MobManager$$CreatePartyUnmanagedEnemy`, `OtherPlayer$$get_IsServerMobCreate`
- when `(OtherPlayer.get_IsPartyMember() & 1) eq 0`
  - returns `PartyManager.ContainsPartyMember(Singleton<object>.get_Instance(meta(0x3974068, Method$Singleton<PartyManager>.get_Instance()), ?x1, ?x2, ?x3), [archetype+0x1c], [archetype+0x18], 0)`
  - calls `virtual OtherPlayer.get_IsPartyMember`, `OtherPlayer$$get_IsServerMobCreate`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$ContainsPartyEnemy`, `TargetableListManagerBase<object>$$get_Instance`, `UnityEngine.Component$$get_gameObject`, `MobManager$$CreatePartyUnmanagedEnemy`, `OtherPlayer$$get_IsServerMobCreate`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `AutoMemberActionManager$$Damaged (TryGetBuf)`
- `CounterForceAttackAction$$OnEnd (TryGetBuf)`
- `FamiliaActionManager$$Damaged (TryGetBuf)`
- `MercenaryActionManager$$Damaged (TryGetBuf)`
- `MobaPlayerActionManager$$Damaged (TryGetBuf)`
- `MobaPlayerActionManager$$ReceiveDamaged (TryGetBuf)`
- `MobaPlayerBattleManager$$StartCounterForceAttack (GetSkillLv)`
- `OtherPlayer$$OnActionMobAttack (TryGetBuf)`
- `PetMemberActionManager$$Damaged (TryGetBuf)`
- `PlayerActionManager$$Damaged (TryGetBuf)`
- `PlayerBattleManager$$StartCounterForceAttack (GetSkillLv)`

---

### อาร์เดดราค (Aldedrak) · uid 716

<img src="../../icons/sk_716.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 2) · **Type:** Object · **Max Lv:** 90 · **Weapons:** MainMagictool · **Requires:** อิกนิชั่น · **Client class:** `AldedrakAction`

> ปล่อยกระสุนเวทมนตร์โจมตีจากใต้ดิน
> ยิงกระสุนเวทมนตร์เลียดพื้นดินไปที่เป้าหมาย
> เมื่อเข้าเป้าจะเกิดการโจมตีในวงแคบ
> หากมีเป้าหมายอื่นอยู่บนทางผ่านจะติดหยุดนิ่งและพุ่งผ่านไป

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv * 35) + 350) + (((baseDEX + baseINT) lt 0 ? ((baseDEX + baseINT) + 1) : (baseDEX + baseINT)) >> 1))) / 100)` — state ne 0

**Role:** attack (deals damage) · applies status ailment · placed object / trap / summon

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `300`
- `SkillRate` multiplies by (adds into): `(((((Lv * 35) + 350) + (((baseDEX + baseINT) lt 0 ? ((baseDEX + baseINT) + 1) : (baseDEX + baseINT)) >> 1))) / 100)`

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 716

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(16)`
- set `skillRate` = `(((Lv * 35) + 350) + (((baseDEX + baseINT) lt 0 ? ((baseDEX + baseINT) + 1) : (baseDEX + baseINT)) >> 1))`

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`calcPlayerToMobDamage`** (10 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)` — when state ne 0
- template `AddConstant[SkillConstantDamage]` = `300` — when state ne 0
- info `templates` = `1` — when state ne 0
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(12, 100, playerAction)` — when PlayerAttackBase.checkAbnormalPercent(this, 12, 100, playerAction) AND state eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 12, 100, playerAction) AND state eq 0
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(12, 0, 0)` — when PlayerAttackBase.checkAbnormalPercent(this, 12, 100, playerAction) AND state eq 0

**`SetLaunch`** (2 paths)

- set `isMoveEnd` = `1` = 1
- set `state` = `1` = 1

**`ActionHit`** (12 paths)

- set `hitObjectList` = `new System.Collections.Generic.List<GameObject>` — when state eq 0

</details>

---

### ไมโครฮีล (ClineHeal) · uid 708

<img src="../../icons/sk_708.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 3) · **Type:** Support · **Max Lv:** 170 · **Weapons:** MainMagictool · **Requires:** เอ็กเพรสเอด · **Client class:** `ClineHealAction`

> แบ่งเบาทำให้สบายขึ้นเล็กน้อย
> 
> ฟื้นฟู HP ของตัวเองและ HP ของสมาชิกปาร์ตี้
> ที่สูญเสีย HP มากที่สุดเล็กน้อย

**Role:** heal / recovery

This action never changes monster proration: ExpType None: no proration slot.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `0` = 0
- **HP healed** (`hpHeal`): `int(((((Lv * 5) / 100) * status.Matk) + (Lv * 50)))`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 708

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`
- set `CastTime` = `0` = 0
- set `hpHeal` = `int(((((Lv * 5) / 100) * status.Matk) + (Lv * 50)))`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionPreparation`** (2 paths)

- set `SkillIndividualFlag` = `1` = 1 — when UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(actarAction), target)
- set `target` = `target`

</details>

---

### เอนฮานซ์ (Enhance) · uid 709

<img src="../../icons/sk_709.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 3) · **Type:** Support · **Max Lv:** 170 · **Weapons:** MainMagictool · **Requires:** เอ็กเพรสเอด · **Client class:** `EnhanceAction`

> ทักษะที่ช่วยเพิ่มความสามารถให้โดดเด่นยิ่งขึ้นไปอีก
> เพิ่มพลังโจมตีของสมาชิกในปาร์ตี้ที่มี ATK และ MATK สูงสุด(แต่ละคน)ความแรงที่เพิ่มจะเปลี่ยนไปตามมอนสเตอร์ที่เผชิญหน้า

**Role:** buff (self) · buff (party / others) · changes attack pattern (motion / combo chain; heuristic)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 709

<details><summary>Recovered formulas (per method)</summary>

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`AddEnhanceBuf`** (4 paths)

- calls `EnhanceBuf..ctor` = `.ctor(skillLv, type)` — when UnityEngine.Object.op_Inequality(BattleMemberData.get_ActionManager(member), 0) AND member._isMine ne 0 OR !UnityEngine.Object.op_Inequality(BattleMemberData.get_ActionManager(member), 0) AND member._isMine ne 0 OR UnityEngine.Object.op_Inequality(BattleMemberData.get_ActionManager(member), 0) AND member._isMine eq 0
- calls `SkillBufferManager.AddBuffer` = `AddBuffer(new EnhanceBuf, 0)` — when UnityEngine.Object.op_Inequality(BattleMemberData.get_ActionManager(member), 0) AND member._isMine ne 0
- calls `AbnormalStateManager.RemoveAbnormalState` = `RemoveAbnormalState(251)` — when UnityEngine.Object.op_Inequality(BattleMemberData.get_ActionManager(member), 0) AND member._isMine eq 0

</details>

**Buffs**

**Buff `EnhanceBuf`**
- **Changes the attack pattern**: the buff object drives a motion/combo chain (`get_BufEffectTakeId`).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsEnhanceAtk`, `get_IsEnhanceMatk`
- Duration: `((Lv * 10) + 20)` s
- `AtkUp` = `atkUp`
- `MatkUp` = `matkUp`

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| LastDmgUpRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |

- Buff fields set in the constructor (all recovered):
  - `type` = `type`
  - `playerAction` = `PlayerDataManager.get_PlayerActionManager(PlayerDataManager.GetPlayerDataManager())`
- Hook `Updata`: `LeftTime`=0; `mobDef`=0; `mobMdef`=0; `atkUp`=0
- Hook `SetViewSelfIcon`: `isViewSelfIcon`=(flag & 1)
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:EnhanceBuf$$.ctor<-EnhanceAction$$AddEnhanceBuf` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

---

### แอสเทิลแลนซ์ (AstralLance) · uid 710

<img src="../../icons/sk_710.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 3) · **Type:** Special · **Max Lv:** 170 · **Weapons:** MainMagictool · **Requires:** เคาน์เตอร์ฟอร์ส · **Client class:** `AstralLanceAction`

> ทักษะการนำพลังเวทย์กลับมาใช้ใหม่อย่างมีประสิทธิภาพ
> 
> โจมตีโดยปล่อยหอกเวทมนตร์อันทรงพลังต่อทุก 500 MP ที่ใช้ไป
> เป็นเวลา 90 วินาที(สูงสุด 1 หอก)

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 710

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (1 path)

- calls `AstralLanceBuf..ctor` = `.ctor(Lv, actarAction)`
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new AstralLanceBuf, 0)`

</details>

**Buffs**

**Buff `AstralLanceBuf`**
- Buff hook methods: `EndAstralLanceAttack`, `StartAstralLanceAttack`, `StartSkill`
- Duration: `(90 + EnhanceSprite.GetEnhanceParam(PlayerStatusBase.get_SkillManager().SkillMasteryList[719], AstralLanceBuf.get_SkillId()))` s; `90` s
- `Count` = `(0)`
- Buff fields set in the constructor (all recovered):
  - `Count` = `0`
  - `nextCount` = `0`
  - `battleManager` = `playerAction.battleManager`
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `mobaBattleManager` = `playerAction.battleManager` when UnityEngine.Object.op_Equality(playerAction.battleManager)
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `StartSkill`: `Count`=Max; `nextCount`=System.Math.Min(((Count + (SkillActionBase.get_Mp() // 100)) - Max), Max); `nextCount`=0; `Count`=(Count + (SkillActionBase.get_Mp() // 100))
- Hook `StartAstralLanceAttack`: `nextCount`=0; `Count`=nextCount
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:AstralLanceBuf$$.ctor<-AstralLanceAction$$ActionHit` (no direct constructor call in the skill's own code).
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

<details><summary>Effect applied in `MobaPlayerBattleManager$$OnSkillActionStartSummonSkeleton` (40 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 145, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 710, stkp(-56), 0) & 1) ne 0`
  - returns `0`
  - calls `MobPopAreaGaugeManager$$get_Instance`, `MobPopAreaGaugeManager$$get_Instance`, `PlayerStatusBase$$PaySkillMp`, `SkillComboManager$$get_IsComboRun`, `SkillComboState$$CheckTenacityCost`, `SkillComboState$$CheckBloody`, `SkillComboManager$$CheckStartingComboWorksProperly`, `PlayerAttackBase$$RestoreDefalutlMotionSpeed`
- when `(SkillBufferManager.TryGetBuf(?blr, 145, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 710, stkp(-56), 0) & 1) eq 0`
  - returns `0`
  - calls `MobPopAreaGaugeManager$$get_Instance`, `MobPopAreaGaugeManager$$get_Instance`, `PlayerStatusBase$$PaySkillMp`, `SkillComboManager$$get_IsComboRun`, `SkillComboState$$CheckTenacityCost`, `SkillComboState$$CheckBloody`, `SkillComboManager$$CheckStartingComboWorksProperly`, `PlayerAttackBase$$RestoreDefalutlMotionSpeed`
- when `(SkillBufferManager.TryGetBuf(?blr, 145, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 710, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `0`
  - calls `MobPopAreaGaugeManager$$get_Instance`, `MobPopAreaGaugeManager$$get_Instance`, `PlayerStatusBase$$PaySkillMp`, `SkillComboManager$$get_IsComboRun`, `SkillComboState$$CheckTenacityCost`, `SkillComboState$$CheckBloody`, `SkillComboManager$$CheckStartingComboWorksProperly`, `PlayerAttackBase$$RestoreDefalutlMotionSpeed`
- when `(SkillBufferManager.TryGetBuf(?blr, 145, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 710, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `MobPopAreaGaugeManager$$get_Instance`, `MobPopAreaGaugeManager$$get_Instance`, `PlayerStatusBase$$PaySkillMp`, `SkillComboManager$$get_IsComboRun`, `SkillComboState$$CheckTenacityCost`, `SkillComboState$$CheckBloody`, `SkillComboManager$$CheckStartingComboWorksProperly`, `PlayerAttackBase$$RestoreDefalutlMotionSpeed`
- when `(SkillBufferManager.TryGetBuf(?blr, 145, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 710, stkp(-56), 0) & 1) eq 0`
  - returns `0`
  - calls `MobPopAreaGaugeManager$$get_Instance`, `MobPopAreaGaugeManager$$get_Instance`, `PlayerStatusBase$$PaySkillMp`, `SkillComboManager$$get_IsComboRun`, `SkillComboState$$CheckTenacityCost`, `SkillComboState$$CheckBloody`, `SkillComboManager$$CheckStartingComboWorksProperly`, `PlayerAttackBase$$RestoreDefalutlMotionSpeed`
- when `(SkillBufferManager.TryGetBuf(?blr, 145, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 710, stkp(-56), 0) & 1) ne 0`
  - returns `0`
  - calls `MobPopAreaGaugeManager$$get_Instance`, `MobPopAreaGaugeManager$$get_Instance`, `PlayerStatusBase$$PaySkillMp`, `SkillComboManager$$get_IsComboRun`, `PlayerAttackBase$$RestoreDefalutlMotionSpeed`, `CountUpIdManager$$Next`, `SkillActionBase$$SetId`, `AshuraAuraBuf$$StartSkill`
- when `(SkillBufferManager.TryGetBuf(?blr, 145, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 710, stkp(-56), 0) & 1) eq 0`
  - returns `0`
  - calls `MobPopAreaGaugeManager$$get_Instance`, `MobPopAreaGaugeManager$$get_Instance`, `PlayerStatusBase$$PaySkillMp`, `SkillComboManager$$get_IsComboRun`, `PlayerAttackBase$$RestoreDefalutlMotionSpeed`, `CountUpIdManager$$Next`, `SkillActionBase$$SetId`, `AshuraAuraBuf$$StartSkill`
- when `(SkillBufferManager.TryGetBuf(?blr, 145, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 710, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `0`
  - calls `MobPopAreaGaugeManager$$get_Instance`, `MobPopAreaGaugeManager$$get_Instance`, `PlayerStatusBase$$PaySkillMp`, `SkillComboManager$$get_IsComboRun`, `PlayerAttackBase$$RestoreDefalutlMotionSpeed`, `CountUpIdManager$$Next`, `SkillActionBase$$SetId`, `AvoidActionManager$$StartSkill`

</details>

<details><summary>Effect applied in `PlayerBattleManager$$OnSkillActionStartSummonSkeleton` (40 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 145, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.CheckSong(?blr, 0, 0, meta(0)) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 710, stkp(-48), 0) & 1) ne 0`
  - returns `0`
  - calls `MobPopAreaGaugeManager$$get_Instance`, `MobPopAreaGaugeManager$$get_Instance`, `PlayerBattleManager$$ActionStartSkillMpLess`, `SkillComboManager$$get_IsComboRun`, `SkillComboState$$CheckTenacityCost`, `SkillComboState$$CheckBloody`, `SkillComboManager$$CheckStartingComboWorksProperly`, `CountUpIdManager$$Next`
- when `(SkillBufferManager.TryGetBuf(?blr, 145, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.CheckSong(?blr, 0, 0, meta(0)) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 710, stkp(-48), 0) & 1) eq 0`
  - returns `0`
  - calls `MobPopAreaGaugeManager$$get_Instance`, `MobPopAreaGaugeManager$$get_Instance`, `PlayerBattleManager$$ActionStartSkillMpLess`, `SkillComboManager$$get_IsComboRun`, `SkillComboState$$CheckTenacityCost`, `SkillComboState$$CheckBloody`, `SkillComboManager$$CheckStartingComboWorksProperly`, `CountUpIdManager$$Next`
- when `(SkillBufferManager.TryGetBuf(?blr, 145, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.CheckSong(?blr, 0, 0, meta(0)) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 710, stkp(-48), 0) & 1) ne 0`
  - returns `0`
  - calls `MobPopAreaGaugeManager$$get_Instance`, `MobPopAreaGaugeManager$$get_Instance`, `PlayerBattleManager$$ActionStartSkillMpLess`, `SkillComboManager$$get_IsComboRun`, `SkillComboState$$CheckTenacityCost`, `SkillComboState$$CheckBloody`, `SkillComboManager$$CheckStartingComboWorksProperly`, `CountUpIdManager$$Next`
- when `(SkillBufferManager.TryGetBuf(?blr, 145, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.CheckSong(?blr, 0, 0, meta(0)) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 710, stkp(-48), 0) & 1) eq 0`
  - returns `0`
  - calls `MobPopAreaGaugeManager$$get_Instance`, `MobPopAreaGaugeManager$$get_Instance`, `PlayerBattleManager$$ActionStartSkillMpLess`, `SkillComboManager$$get_IsComboRun`, `SkillComboState$$CheckTenacityCost`, `SkillComboState$$CheckBloody`, `SkillComboManager$$CheckStartingComboWorksProperly`, `CountUpIdManager$$Next`
- when `(SkillBufferManager.TryGetBuf(?blr, 145, stkp(-48), 0) & 1) eq 0` AND `(SkillBufferManager.CheckSong(?blr, 0, 0, meta(0)) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 710, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `0`
  - calls `MobPopAreaGaugeManager$$get_Instance`, `MobPopAreaGaugeManager$$get_Instance`, `PlayerBattleManager$$ActionStartSkillMpLess`, `SkillComboManager$$get_IsComboRun`, `SkillComboState$$CheckTenacityCost`, `SkillComboState$$CheckBloody`, `SkillComboManager$$CheckStartingComboWorksProperly`, `CountUpIdManager$$Next`
- when `(SkillBufferManager.TryGetBuf(?blr, 145, stkp(-48), 0) & 1) eq 0` AND `(SkillBufferManager.CheckSong(?blr, 0, 0, meta(0)) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 710, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `MobPopAreaGaugeManager$$get_Instance`, `MobPopAreaGaugeManager$$get_Instance`, `PlayerBattleManager$$ActionStartSkillMpLess`, `SkillComboManager$$get_IsComboRun`, `SkillComboState$$CheckTenacityCost`, `SkillComboState$$CheckBloody`, `SkillComboManager$$CheckStartingComboWorksProperly`, `CountUpIdManager$$Next`
- when `(SkillBufferManager.TryGetBuf(?blr, 145, stkp(-48), 0) & 1) eq 0` AND `(SkillBufferManager.CheckSong(?blr, 0, 0, meta(0)) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 710, stkp(-48), 0) & 1) eq 0`
  - returns `0`
  - calls `MobPopAreaGaugeManager$$get_Instance`, `MobPopAreaGaugeManager$$get_Instance`, `PlayerBattleManager$$ActionStartSkillMpLess`, `SkillComboManager$$get_IsComboRun`, `SkillComboState$$CheckTenacityCost`, `SkillComboState$$CheckBloody`, `SkillComboManager$$CheckStartingComboWorksProperly`, `CountUpIdManager$$Next`
- when `(SkillBufferManager.TryGetBuf(?blr, 145, stkp(-48), 0) & 1) eq 0` AND `(SkillBufferManager.CheckSong(?blr, 0, 0, meta(0)) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 710, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `0`
  - calls `MobPopAreaGaugeManager$$get_Instance`, `MobPopAreaGaugeManager$$get_Instance`, `PlayerBattleManager$$ActionStartSkillMpLess`, `SkillComboManager$$get_IsComboRun`, `SkillComboState$$CheckTenacityCost`, `SkillComboState$$CheckBloody`, `SkillComboManager$$CheckStartingComboWorksProperly`, `CountUpIdManager$$Next`

</details>

<details><summary>Effect applied in `MobaPlayerBattleManager$$OnSkillActionStart` (207 guarded paths, truncated)</summary>

- when `(UnityEngine.Object.op_Implicit(target, 0, targetActManager, action) & 1) ne 0` AND `SkillActionBase.get_ActionID() ne 1218` AND `SkillActionBase.get_ActionID() eq 1219` AND `SkillActionBase.get_AttackType() eq 1`
  - returns `0`
  - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `MobaPlayerBattleManager$$CheckConvertRapidAqueVortex`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `MobaPlayerBattleManager$$CheckSkillStartAbnormalState`, `virtual SkillActionBase.get_AttackType`, `AbnormalStateManager$$Contains`
- when `(UnityEngine.Object.op_Implicit(target, 0, targetActManager, action) & 1) ne 0` AND `SkillActionBase.get_ActionID() ne 1218` AND `SkillActionBase.get_ActionID() eq 1219` AND `SkillActionBase.get_AttackType() eq 1`
  - returns `0`
  - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `MobaPlayerBattleManager$$CheckConvertRapidAqueVortex`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `MobaPlayerBattleManager$$CheckSkillStartAbnormalState`, `virtual SkillActionBase.get_AttackType`, `AbnormalStateManager$$Contains`
- when `(UnityEngine.Object.op_Implicit(target, 0, targetActManager, action) & 1) ne 0` AND `SkillActionBase.get_ActionID() ne 1218` AND `SkillActionBase.get_ActionID() eq 1219` AND `SkillActionBase.get_AttackType() eq 1`
  - returns `0`
  - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `MobaPlayerBattleManager$$CheckConvertRapidAqueVortex`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `MobaPlayerBattleManager$$CheckSkillStartAbnormalState`, `virtual SkillActionBase.get_AttackType`, `AbnormalStateManager$$Contains`
- when `(UnityEngine.Object.op_Implicit(target, 0, targetActManager, action) & 1) ne 0` AND `SkillActionBase.get_ActionID() ne 1218` AND `SkillActionBase.get_ActionID() eq 1219` AND `SkillActionBase.get_AttackType() eq 1`
  - returns `0`
  - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `MobaPlayerBattleManager$$CheckConvertRapidAqueVortex`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `MobaPlayerBattleManager$$CheckSkillStartAbnormalState`, `virtual SkillActionBase.get_AttackType`, `AbnormalStateManager$$Contains`
- when `(UnityEngine.Object.op_Implicit(target, 0, targetActManager, action) & 1) ne 0` AND `SkillActionBase.get_ActionID() ne 1218` AND `SkillActionBase.get_ActionID() eq 1219` AND `SkillActionBase.get_AttackType() eq 1`
  - returns `0`
  - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `MobaPlayerBattleManager$$CheckConvertRapidAqueVortex`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `MobaPlayerBattleManager$$CheckSkillStartAbnormalState`, `virtual SkillActionBase.get_AttackType`, `AbnormalStateManager$$Contains`
- when `(UnityEngine.Object.op_Implicit(target, 0, targetActManager, action) & 1) ne 0` AND `SkillActionBase.get_ActionID() ne 1218` AND `SkillActionBase.get_ActionID() eq 1219` AND `SkillActionBase.get_AttackType() eq 1`
  - returns `0`
  - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `MobaPlayerBattleManager$$CheckConvertRapidAqueVortex`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `MobaPlayerBattleManager$$CheckSkillStartAbnormalState`, `virtual SkillActionBase.get_AttackType`, `AbnormalStateManager$$Contains`
- when `(UnityEngine.Object.op_Implicit(target, 0, targetActManager, action) & 1) ne 0` AND `SkillActionBase.get_ActionID() ne 1218` AND `SkillActionBase.get_ActionID() eq 1219` AND `SkillActionBase.get_AttackType() eq 1`
  - returns `0`
  - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `MobaPlayerBattleManager$$CheckConvertRapidAqueVortex`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `MobaPlayerBattleManager$$CheckSkillStartAbnormalState`, `virtual SkillActionBase.get_AttackType`, `AbnormalStateManager$$Contains`
- when `(UnityEngine.Object.op_Implicit(target, 0, targetActManager, action) & 1) ne 0` AND `SkillActionBase.get_ActionID() ne 1218` AND `SkillActionBase.get_ActionID() eq 1219` AND `SkillActionBase.get_AttackType() eq 1`
  - returns `0`
  - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `MobaPlayerBattleManager$$CheckConvertRapidAqueVortex`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `MobaPlayerBattleManager$$CheckSkillStartAbnormalState`, `virtual SkillActionBase.get_AttackType`, `AbnormalStateManager$$Contains`

</details>

<details><summary>Effect applied in `PlayerBattleManager$$OnSkillActionStart` (273 guarded paths, truncated)</summary>

- when `(UnityEngine.Object.op_Implicit(target, 0, targetActManager, action) & 1) ne 0` AND `SkillActionBase.get_ActionID() ne 1218` AND `SkillActionBase.get_ActionID() eq 1219` AND `SkillActionBase.get_AttackType() eq 1`
  - returns `0`
  - set `assistMoveTime` = `0`
  - set `isAssistMovingCheck` = `0`
  - set `assistTarget` = `0`
  - set `+0xbc` = `0`
  - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `PlayerBattleManager$$CheckConvertRapidAqueVortex`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `PlayerAttackBase$$CheckSkillParamFlag`, `PlayerStatusBase$$EnoughMp`
- when `(UnityEngine.Object.op_Implicit(target, 0, targetActManager, action) & 1) ne 0` AND `SkillActionBase.get_ActionID() ne 1218` AND `SkillActionBase.get_ActionID() eq 1219` AND `SkillActionBase.get_AttackType() eq 1`
  - returns `0`
  - set `assistMoveTime` = `0`
  - set `isAssistMovingCheck` = `0`
  - set `assistTarget` = `0`
  - set `+0xbc` = `0`
  - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `PlayerBattleManager$$CheckConvertRapidAqueVortex`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `PlayerAttackBase$$CheckSkillParamFlag`, `PlayerStatusBase$$EnoughMp`
- when `(UnityEngine.Object.op_Implicit(target, 0, targetActManager, action) & 1) ne 0` AND `SkillActionBase.get_ActionID() ne 1218` AND `SkillActionBase.get_ActionID() eq 1219` AND `SkillActionBase.get_AttackType() eq 1`
  - returns `0`
  - set `assistMoveTime` = `0`
  - set `isAssistMovingCheck` = `0`
  - set `assistTarget` = `0`
  - set `+0xbc` = `0`
  - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `PlayerBattleManager$$CheckConvertRapidAqueVortex`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `PlayerAttackBase$$CheckSkillParamFlag`, `PlayerStatusBase$$EnoughMp`
- when `(UnityEngine.Object.op_Implicit(target, 0, targetActManager, action) & 1) ne 0` AND `SkillActionBase.get_ActionID() ne 1218` AND `SkillActionBase.get_ActionID() eq 1219` AND `SkillActionBase.get_AttackType() eq 1`
  - returns `0`
  - set `assistMoveTime` = `0`
  - set `isAssistMovingCheck` = `0`
  - set `assistTarget` = `0`
  - set `+0xbc` = `0`
  - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `PlayerBattleManager$$CheckConvertRapidAqueVortex`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `PlayerAttackBase$$CheckSkillParamFlag`, `PlayerStatusBase$$EnoughMp`
- when `(UnityEngine.Object.op_Implicit(target, 0, targetActManager, action) & 1) ne 0` AND `SkillActionBase.get_ActionID() ne 1218` AND `SkillActionBase.get_ActionID() eq 1219` AND `SkillActionBase.get_AttackType() eq 1`
  - returns `0`
  - set `assistMoveTime` = `0`
  - set `isAssistMovingCheck` = `0`
  - set `assistTarget` = `0`
  - set `+0xbc` = `0`
  - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `PlayerBattleManager$$CheckConvertRapidAqueVortex`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `PlayerAttackBase$$CheckSkillParamFlag`, `PlayerStatusBase$$EnoughMp`
- when `(UnityEngine.Object.op_Implicit(target, 0, targetActManager, action) & 1) ne 0` AND `SkillActionBase.get_ActionID() ne 1218` AND `SkillActionBase.get_ActionID() eq 1219` AND `SkillActionBase.get_AttackType() eq 1`
  - returns `0`
  - set `assistMoveTime` = `0`
  - set `isAssistMovingCheck` = `0`
  - set `assistTarget` = `0`
  - set `+0xbc` = `0`
  - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `PlayerBattleManager$$CheckConvertRapidAqueVortex`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `PlayerAttackBase$$CheckSkillParamFlag`, `PlayerStatusBase$$EnoughMp`
- when `(UnityEngine.Object.op_Implicit(target, 0, targetActManager, action) & 1) ne 0` AND `SkillActionBase.get_ActionID() ne 1218` AND `SkillActionBase.get_ActionID() eq 1219` AND `SkillActionBase.get_AttackType() eq 1`
  - returns `0`
  - set `assistMoveTime` = `0`
  - set `isAssistMovingCheck` = `0`
  - set `assistTarget` = `0`
  - set `+0xbc` = `0`
  - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `PlayerBattleManager$$CheckConvertRapidAqueVortex`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `PlayerAttackBase$$CheckSkillParamFlag`, `PlayerStatusBase$$EnoughMp`
- when `(UnityEngine.Object.op_Implicit(target, 0, targetActManager, action) & 1) ne 0` AND `SkillActionBase.get_ActionID() ne 1218` AND `SkillActionBase.get_ActionID() eq 1219` AND `SkillActionBase.get_AttackType() eq 1`
  - returns `0`
  - set `assistMoveTime` = `0`
  - set `isAssistMovingCheck` = `0`
  - set `assistTarget` = `0`
  - set `+0xbc` = `0`
  - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `PlayerBattleManager$$CheckConvertRapidAqueVortex`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `PlayerAttackBase$$CheckSkillParamFlag`, `PlayerStatusBase$$EnoughMp`

</details>

<details><summary>Effect applied in `AstralLanceAttackAction$$OnEnd` (3 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 710, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `AstralLanceBuf.EndAstralLanceAttack(TryGetBuf.out2(), 0, ?x2, ?x3)`
  - calls `PlayerAttackBase$$OnEnd`, `AstralLanceBuf$$EndAstralLanceAttack`
- when `(SkillBufferManager.TryGetBuf(?blr, 710, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `PlayerAttackBase$$OnEnd`, `0x165db84`, `0x165df00`
- when `(SkillBufferManager.TryGetBuf(?blr, 710, stkp(-40), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 710, stkp(-40), 0)`
  - calls `PlayerAttackBase$$OnEnd`

</details>

<details><summary>Effect applied in `AstralLanceAttackAction$$ActionStart` (3 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 710, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `AstralLanceBuf.StartAstralLanceAttack(TryGetBuf.out2(), 0, ?x2, ?x3)`
  - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `+0x12c` = `?v1`
  - set `+0x130` = `?v2`
  - calls `PlayerAttackBase$$ActionStart`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `AstralLanceBuf$$StartAstralLanceAttack`
- when `(SkillBufferManager.TryGetBuf(?blr, 710, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `+0x12c` = `?v1`
  - set `+0x130` = `?v2`
  - calls `PlayerAttackBase$$ActionStart`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `0x165db84`, `0x165df00`
- when `(SkillBufferManager.TryGetBuf(?blr, 710, stkp(-40), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 710, stkp(-40), 0)`
  - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `+0x12c` = `?v1`
  - set `+0x130` = `?v2`
  - calls `PlayerAttackBase$$ActionStart`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`

</details>

<details><summary>Effect applied in `MobaPlayerBattleManager$$StartAstralLanceAttack` (4 guarded paths)</summary>

- when `SkillLv(710) ge 1`
  - returns `1`
  - calls `SkillActionManager$$IsPlaySkillData`, `SkillFactory$$CreateSkill`, `SkillActionBase$$Initialize`, `UnityEngine.GameObject$$GetComponent<object>`, `PlayerSkillActionManager$$PlaceEffectPlay`
- when `SkillLv(710) ge 1`
  - returns `0`
  - calls `SkillActionManager$$IsPlaySkillData`, `SkillFactory$$CreateSkill`, `SkillActionBase$$Initialize`, `UnityEngine.GameObject$$GetComponent<object>`
- when `SkillLv(710) ge 1`
  - returns `0`
  - calls `SkillActionManager$$IsPlaySkillData`, `SkillFactory$$CreateSkill`, `SkillActionBase$$Initialize`
- when `SkillLv(710) lt 1`
  - returns `0`
  - calls `SkillActionManager$$IsPlaySkillData`, `SkillFactory$$CreateSkill`

</details>

<details><summary>Effect applied in `PlayerBattleManager$$StartAstralLanceAttack` (4 guarded paths)</summary>

- when `SkillLv(710) ge 1`
  - returns `1`
  - calls `SkillActionManager$$IsPlaySkillData`, `SkillFactory$$CreateSkill`, `SkillActionBase$$Initialize`, `UnityEngine.GameObject$$GetComponent<object>`, `PlayerSkillActionManager$$PlaceEffectPlay`
- when `SkillLv(710) ge 1`
  - returns `0`
  - calls `SkillActionManager$$IsPlaySkillData`, `SkillFactory$$CreateSkill`, `SkillActionBase$$Initialize`, `UnityEngine.GameObject$$GetComponent<object>`
- when `SkillLv(710) ge 1`
  - returns `0`
  - calls `SkillActionManager$$IsPlaySkillData`, `SkillFactory$$CreateSkill`, `SkillActionBase$$Initialize`
- when `SkillLv(710) lt 1`
  - returns `0`
  - calls `SkillActionManager$$IsPlaySkillData`, `SkillFactory$$CreateSkill`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `AstralLanceAttackAction$$ActionStart (TryGetBuf)`
- `AstralLanceAttackAction$$OnEnd (TryGetBuf)`
- `MagicBalkanAction$$ActionSkillEvent (TryGetBuf)`
- `MobaPlayerBattleManager$$OnSkillActionStart (TryGetBuf)`
- `MobaPlayerBattleManager$$OnSkillActionStartSummonSkeleton (TryGetBuf)`
- `MobaPlayerBattleManager$$StartAstralLanceAttack (GetSkillLv)`
- `PlayerBattleManager$$OnSkillActionStart (TryGetBuf)`
- `PlayerBattleManager$$OnSkillActionStartSummonSkeleton (TryGetBuf)`
- `PlayerBattleManager$$StartAstralLanceAttack (GetSkillLv)`

---

### แฟกทิสอาร์ม (FacticeArme) · uid 717

<img src="../../icons/sk_717.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 3) · **Type:** Attack · **Max Lv:** 170 · **Weapons:** MainMagictool · **Requires:** อาร์เดดราค · **Client class:** `FacticeArmeAction`

> ใช้อาวุธที่สร้างจากพลังเวท
> 
> โจมตีเป้าหมายเดี่ยว
> พลังเพิ่มตาม AGI และ DEX ที่สูงขึ้น

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + [type eq 3 OR type eq 0 AND type ne 3 OR type eq 4 AND type ne 0 AND type ne 3] | 4.5 | 18 | 40.5 | 72 | 112.5 | 162 | 220.5 | 288 | 364.5 | 450 |
| Flat dmg + [type eq 0 AND type ne 3 OR type eq 4 AND type ne 0 AND type ne 3] | 1.5 | 6 | 13.5 | 24 | 37.5 | 54 | 73.5 | 96 | 121.5 | 150 |
| Flat dmg + [type ne 0 AND type ne 3 AND type ne 4] | 6 | 24 | 54 | 96 | 150 | 216 | 294 | 384 | 486 | 600 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((((status.Agi + status.Dex) + 750)) / 100) * 0.75)` — type eq 3 OR type eq 0 AND type ne 3 OR type eq 4 AND type ne 0 AND type ne 3
- SkillRate × `(((((status.Agi + status.Dex) + 750)) / 100) * 0.25)` — type eq 0 AND type ne 3 OR type eq 4 AND type ne 0 AND type ne 3
- SkillRate × `((((status.Agi + status.Dex) + 750)) / 100)` — type ne 0 AND type ne 3 AND type ne 4

**Role:** attack (deals damage) · buff (self)

The skill builds 2 separate damage templates (each is a full hit with its own crit roll). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((((Lv * Lv) + ((Lv * Lv) << 1)) << 1)) * 0.75)` | `(((((Lv * Lv) + ((Lv * Lv) << 1)) << 1)) * 0.25)` | `((((Lv * Lv) + ((Lv * Lv) << 1)) << 1))`
- `SkillRate` multiplies by (adds into): `(((((status.Agi + status.Dex) + 750)) / 100) * 0.75)` | `(((((status.Agi + status.Dex) + 750)) / 100) * 0.25)` | `((((status.Agi + status.Dex) + 750)) / 100)`

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 717

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`
- set `skillRate` = `((status.Agi + status.Dex) + 750)`
- set `constantDamage` = `(((Lv * Lv) + ((Lv * Lv) << 1)) << 1)` → Lv1..10: [6, 24, 54, 96, 150, 216, 294, 384, 486, 600]
- set `type` = `UnityEngine.Random.Range(0, 5)`
- set `SkillIndividualFlag` = `UnityEngine.Random.Range(0, 5)`

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`ActionStartOthers`** (1 path)

- set `type` = `SkillIndividualFlag`

**`OtherPlayerSkillEventReceive`** (2 paths)

- set `canBackStep` = `1` = 1 — when (skillEventId & 0xffff) eq 1

**`ActionStart`** (1 path)

- set `mainTarget` = `UnityEngine.GameObject.get_transform(target)`

**`calcPlayerToMobDamage`** (21 paths)

- template `AddRate[SkillRate]` = `((skillRate / 100) * 0.75)` — when type eq 3 OR type eq 0 AND type ne 3 OR type eq 4 AND type ne 0 AND type ne 3
- template `AddConstant[SkillConstantDamage]` = `(constantDamage * 0.75)` — when type eq 3 OR type eq 0 AND type ne 3 OR type eq 4 AND type ne 0 AND type ne 3
- template `AddRate[SkillRate]` = `((skillRate / 100) * 0.25)` — when type eq 0 AND type ne 3 OR type eq 4 AND type ne 0 AND type ne 3
- template `AddConstant[SkillConstantDamage]` = `(constantDamage * 0.25)` — when type eq 0 AND type ne 3 OR type eq 4 AND type ne 0 AND type ne 3
- info `templates` = `2` — when type eq 3 OR type eq 0 AND type ne 3 OR type eq 4 AND type ne 0 AND type ne 3
- template `AddRate[SkillRate]` = `(skillRate / 100)` — when type ne 0 AND type ne 3 AND type ne 4
- template `AddConstant[SkillConstantDamage]` = `constantDamage` — when type ne 0 AND type ne 3 AND type ne 4
- info `templates` = `1` — when type ne 0 AND type ne 3 AND type ne 4

**`ActionSkillEventIfMoveIndex`** (7 paths)

- set `canBackStep` = `1` = 1 — when !UnityEngine.Object.op_Equality(mainTarget) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(mainTarget)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(mainTarget)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(mainTarget)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(mainTarget)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND type eq 2 OR !UnityEngine.Object.op_Equality(mainTarget) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(mainTarget)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(mainTarget)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(mainTarget)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(mainTarget)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 AND type eq 2

**`<CreateTake>b__29_0`** (1 path)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(94)`

**`<CreateTake>b__29_1`** (1 path)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(94)`

**`<CreateTake>b__29_2`** (1 path)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(624)`

**`<CreateTake>b__29_3`** (2 paths)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(624)` — when (cancel & 1) ne 0

</details>

**Buffs**

**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:JumpbackShotProtectionBuf$$.ctor<-FacticeArmeAction$$CreateTake` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

---

### เรเซอร์เรคชั่น (Resurrection) · uid 711

<img src="../../icons/sk_711.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 4) · **Type:** Support · **Max Lv:** 250 · **Weapons:** MainMagictool · **Requires:** ไมโครฮีล · **Client class:** `ResurrectionAction`

> ทักษะการชุบชีวิตผู้ที่ไม่สามารถต่อสู้ได้อีกต่อไป
> เวลารอคืนชีพของคนรอบข้าง(ภายใน 16m)จะเป็น 0 วินาที
> 
> *ใช้ไม่ได้ถ้าไม่มีปฐมพยาบาล
> *ใช้กับคอมโบไม่ได้

**Role:** utility / system action

This action never changes monster proration: ExpType None: no proration slot.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `((((ResurrectionAction.get_BaseMp() - PlayerAttackBase.CalcCostMp(this, actarAction)) // 100) * 0.5) + PlayerAttackBase.CalcCastTime(this, (10 - (Lv * 0.5)), PlayerActionManagerBase.get_PlayerStatus()))`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 711

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(16)`
- set `CastTime` = `((((ResurrectionAction.get_BaseMp() - PlayerAttackBase.CalcCostMp(this, actarAction)) // 100) * 0.5) + PlayerAttackBase.CalcCastTime(this, (10 - (Lv * 0.5)), PlayerActionManagerBase.get_PlayerStatus()))`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

</details>

---

### สเตบิไลซ์ (Stabilis) · uid 712

<img src="../../icons/sk_712.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 4) · **Type:** Support · **Max Lv:** 250 · **Weapons:** MainMagictool · **Requires:** เอนฮานซ์ · **Client class:** `StabilisAction`

> ทักษะที่ช่วยเพิ่มความแม่นยำ
> เพิ่มอัตราคริติคอลและความเสถียรของความเสียหายจากเวท
> และลดความเสถียรตอน Graze เป็นเวลา 45 วินาที
> ลบ "เหนื่อยล้า" เมื่อใช้งาน

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 712

<details><summary>Recovered formulas (per method)</summary>

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (5 paths)

- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(712, Lv, 0)` — when AbnormalStateManager.Contains(PlayerActionManagerBase.get_AbnormalStatusManager(), 23) AND UnityEngine.Object.op_Inequality(actarAction) OR !AbnormalStateManager.Contains(PlayerActionManagerBase.get_AbnormalStatusManager(), 23) AND UnityEngine.Object.op_Inequality(actarAction)
- calls `AbnormalStateManager.RemoveAbnormalState` = `RemoveAbnormalState(23)` — when AbnormalStateManager.Contains(PlayerActionManagerBase.get_AbnormalStatusManager(), 23) AND UnityEngine.Object.op_Inequality(actarAction)

</details>

**Buffs**

**Buff `StabilisBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `(0 + 45)` s

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |
| CrtUpRate | 4 | 8 | 12 | 16 | 20 | 24 | 28 | 32 | 36 | 40 |
| Count | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| CrtUp | 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13 | 14 | 15 |

- Buff fields set in the constructor (all recovered):
  - `IsSelfAction` = `(self & 1)`
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `BuffEffectActive` = `1` = 1
  - `BufEffectTakeUid` = `-1` = -1
  - `stableRecovery` = `((Lv << 2) + lv)` → Lv1..10 [5, 10, 15, 20, 25, 30, 35, 40, 45, 50]
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

<details><summary>Effect applied in `PetStatus$$get_Critical` (66 guarded paths)</summary>

- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-64), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `(int(((GetBonusConstant_Rate.out4() + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 43, 0, ?x3) / 100)) * (int((PetStatus.get_Crt(this, ?x1, ?x2, ?x3) / 3.4)) + 25))) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 19, 0, ?x3) + ((CharacterActionManagerBase.get_Size() + GetBonusConstant_Rate.out3()) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 19, 0, ?x3) << 1))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-64), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-64), 0) & 1) eq 0`
  - returns `(int((GetBonusConstant_Rate.out4() * (int((PetStatus.get_Crt(this, ?x1, ?x2, ?x3) / 3.4)) + 25))) + ((CharacterActionManagerBase.get_Size() + GetBonusConstant_Rate.out3()) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 19, 0, ?x3) << 1)))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-64), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `(int(((((GetBonusConstant_Rate.out4() + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 43, 0, ?x3) / 100)) + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.get_Size() / 100)) * (int((PetStatus.get_Crt(this, 23, ?mi, ?x3) / 3.4)) + 25))) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 19, 0, ?x3) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 19, 0, ?x3) + (CharacterActionManagerBase.get_Size() + GetBonusConstant_Rate.out3()))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-64), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `(int((((GetBonusConstant_Rate.out4() + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 43, 0, ?x3) / 100)) + (CharacterActionManagerBase.get_Size() / 100)) * (int((PetStatus.get_Crt(this, ?x1, ?x2, ?x3) / 3.4)) + 25))) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 19, 0, ?x3) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 19, 0, ?x3) + (CharacterActionManagerBase.get_Size() + GetBonusConstant_Rate.out3()))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-64), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `(int((((GetBonusConstant_Rate.out4() + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 43, 0, ?x3) / 100)) + (CharacterActionManagerBase.get_Size() / 100)) * (int((PetStatus.get_Crt(this, 23, ?mi, ?x3) / 3.4)) + 25))) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 19, 0, ?x3) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 19, 0, ?x3) + (CharacterActionManagerBase.get_Size() + GetBonusConstant_Rate.out3()))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-64), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `(int(((GetBonusConstant_Rate.out4() + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 43, 0, ?x3) / 100)) * (int((PetStatus.get_Crt(this, ?x1, ?x2, ?x3) / 3.4)) + 25))) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 19, 0, ?x3) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 19, 0, ?x3) + (CharacterActionManagerBase.get_Size() + GetBonusConstant_Rate.out3()))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-64), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `(int(((GetBonusConstant_Rate.out4() + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 43, 0, ?x3) / 100)) * (int((PetStatus.get_Crt(this, ?x1, ?x2, ?x3) / 3.4)) + 25))) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 19, 0, ?x3) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 19, 0, ?x3) + (CharacterActionManagerBase.get_Size() + GetBonusConstant_Rate.out3()))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`

</details>

<details><summary>Effect applied in `PlayerAttackBase$$CalcStable` (18 guarded paths)</summary>

- when `type hs 2` AND `type ne 3` AND `type eq 2` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 712, stkp(-40), 0) & 1) ne 0`
  - returns `SkillActionBase.CalcMagicStablePercent((int((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) / 10)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3) + (int((stableSource * 0.5)) + 50))), ((EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3) & 0xfffffffe) eq 14 ? 120 : 110), 0, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_WeaponItemType`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `SkillActionBase$$CalcMagicStablePercent`
- when `type hs 2` AND `type ne 3` AND `type eq 2` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 712, stkp(-40), 0) & 1) ne 0`
  - returns `SkillActionBase.CalcMagicStablePercent((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3) + (int((stableSource * 0.5)) + 50)), ((EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3) & 0xfffffffe) eq 14 ? 120 : 110), 0, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_WeaponItemType`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillActionBase$$CalcMagicStablePercent`
- when `type hs 2` AND `type ne 3` AND `type eq 2` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 712, stkp(-40), 0) & 1) ne 0`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
- when `type hs 2` AND `type ne 3` AND `type eq 2` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 712, stkp(-40), 0) & 1) eq 0`
  - returns `SkillActionBase.CalcMagicStablePercent((int((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) / 10)) + (int((stableSource * 0.5)) + 50)), 110, 0, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `SkillActionBase$$CalcMagicStablePercent`
- when `type hs 2` AND `type ne 3` AND `type eq 2` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 712, stkp(-40), 0) & 1) eq 0`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
- when `type hs 2` AND `type ne 3` AND `type eq 2` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 712, stkp(-40), 0) & 1) eq 0`
  - returns `SkillActionBase.CalcMagicStablePercent((int((stableSource * 0.5)) + 50), 110, 0, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillActionBase$$CalcMagicStablePercent`
- when `type hs 2` AND `type eq 3` AND `(correctHit & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 712, stkp(-48), 0) & 1) ne 0`
  - returns `SkillActionBase.CalcStablePercent((CharacterActionManagerBase.set_DefaultMoveSpeed() + (int(((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) / 100) * int((((correctHit & 1) ne 0 ? 0.5 : 1) * stableSource)))) + int((((correctHit & 1) ne 0 ? 0.5 : 1) * stableSource)))), 0, ?mi, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillActionBase$$CalcStablePercent`
- when `type hs 2` AND `type eq 3` AND `(correctHit & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 712, stkp(-48), 0) & 1) ne 0`
  - returns `SkillActionBase.CalcStablePercent((int(((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) / 100) * int((((correctHit & 1) ne 0 ? 0.5 : 1) * stableSource)))) + int((((correctHit & 1) ne 0 ? 0.5 : 1) * stableSource))), 0, ?x2, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillActionBase$$CalcStablePercent`

</details>

<details><summary>Effect applied in `MobaPlayerSecondaryStatus$$GetCrtConstant` (298 guarded paths, truncated)</summary>

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

<details><summary>Effect applied in `PlayerSecondaryStatus$$GetCrtConstant` (298 guarded paths, truncated)</summary>

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

<details><summary>Effect applied in `PlayerSecondaryStatus$$GetCrtRate` (96 guarded paths)</summary>

- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) ne 0`
  - returns `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0)`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
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

</details>

<details><summary>Effect applied in `MobaPlayerSecondaryStatus$$GetCrtRate` (96 guarded paths)</summary>

- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) ne 0`
  - returns `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0)`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
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

</details>

<details><summary>Effect applied in `PetSkillActionBase$$CalcStable` (6 guarded paths)</summary>

- when `type hs 2` AND `type eq 2` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 712, stkp(-40), correctHit) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `SkillActionBase.CalcMagicStablePercent((([Motiondata+0x1c] & 1024) eq 0 ? (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3) + (int(([Motiondata+0x14] * 0.5)) + 50)) : (((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3) + (int(([Motiondata+0x14] * 0.5)) + 50)) lt 0 ? ((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3) + (int(([Motiondata+0x14] * 0.5)) + 50)) + 1) : (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3) + (int(([Motiondata+0x14] * 0.5)) + 50))) >> 1)), ((EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData(), 0, ?x2, ?x3) & 0xfffffffe) eq 14 ? 120 : 110), 0, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_WeaponItemType`, `SkillActionBase$$CalcMagicStablePercent`
- when `type hs 2` AND `type eq 2` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 712, stkp(-40), correctHit) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
- when `type hs 2` AND `type eq 2` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 712, stkp(-40), correctHit) & 1) eq 0`
  - returns `SkillActionBase.CalcMagicStablePercent((([Motiondata+0x1c] & 1024) eq 0 ? (int(([Motiondata+0x14] * 0.5)) + 50) : (((int(([Motiondata+0x14] * 0.5)) + 50) lt 0 ? ((int(([Motiondata+0x14] * 0.5)) + 50) + 1) : (int(([Motiondata+0x14] * 0.5)) + 50)) >> 1)), 110, 0, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillActionBase$$CalcMagicStablePercent`
- when `type lo 2` AND `(correctHit & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 712, stkp(-56), correctHit) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `SkillActionBase.CalcStablePercent((int(((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) / 100) * int((((correctHit & 1) ne 0 ? 0.5 : 1) * [Motiondata+0x14])))) + int((((correctHit & 1) ne 0 ? 0.5 : 1) * [Motiondata+0x14]))), 0, ?x2, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `SkillActionBase$$CalcStablePercent`
- when `type lo 2` AND `(correctHit & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 712, stkp(-56), correctHit) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
- when `type lo 2` AND `(correctHit & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 712, stkp(-56), correctHit) & 1) eq 0`
  - returns `SkillActionBase.CalcStablePercent(int((((correctHit & 1) ne 0 ? 0.5 : 1) * [Motiondata+0x14])), 0, ?x2, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillActionBase$$CalcStablePercent`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `MobaPlayerSecondaryStatus$$GetCrtConstant (TryGetBuf)`
- `MobaPlayerSecondaryStatus$$GetCrtRate (TryGetBuf)`
- `PetSkillActionBase$$CalcStable (TryGetBuf)`
- `PetStatus$$get_Critical (TryGetBuf)`
- `PlayerAttackBase$$CalcStable (TryGetBuf)`
- `PlayerSecondaryStatus$$GetCrtConstant (TryGetBuf)`
- `PlayerSecondaryStatus$$GetCrtRate (TryGetBuf)`

---

### สไปรท์ชีลด์ (SpriteShield) · uid 713

<img src="../../icons/sk_713.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 4) · **Type:** Buffer · **Max Lv:** 250 · **Weapons:** MainMagictool · **Requires:** เอนฮานซ์ · **Client class:** `SpriteShieldAction`

> ทักษะการเปลี่ยนพลังงานเป็นพลังเวท
> ใช้ HP เพื่อฟื้นฟู 100 MP ทันที
> ลดความเสียหายและโอกาสในการติด
> ภาวะผิดปกติที่โดนในครั้งต่อไป

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`
- **HP consumed** (`consumptionHp`): `System.Math.Max(int(((status.MaxHp * (30 - (Lv << 1))) * 89129)), 100)`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 713

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`
- set `consumptionHp` = `System.Math.Max(int(((status.MaxHp * (30 - (Lv << 1))) * 89129)), 100)`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`CheckPayHp`** (6 paths)

- calls `SoulHuntBuf..ctor` = `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1))` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND consumptionHp ge 1 AND consumptionHp lt (PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new SoulHuntBuf, 0)` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND consumptionHp ge 1 AND consumptionHp lt (PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp)

**`ActionHit`** (2 paths)

- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(713, Lv, Id)` — when UnityEngine.Object.op_Inequality(actarAction)

</details>

**Buffs**

**Buff `SoulHuntBuf`**
**Buff `SpriteShieldBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 1 | 4 | 9 | 16 | 25 | 36 | 49 | 64 | 81 | 100 |
| MobLastDamageRateSupport | 50 | 50 | 50 | 50 | 50 | 50 | 50 | 50 | 50 | 50 |

- Buff fields set in the constructor (all recovered):
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `IsSelfAction` = `(self & 1)`
  - `BuffEffectActive` = `1` = 1
  - `BufEffectTakeUid` = `-1` = -1
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:SoulHuntBuf$$.ctor<-SpriteShieldAction$$CheckPayHp` (no direct constructor call in the skill's own code).
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

<details><summary>Effect applied in `MobaPlayerSecondaryStatus$$get_AntiVirus` (26 guarded paths)</summary>

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

<details><summary>Effect applied in `PlayerSecondaryStatus$$CalcAntiVirus` (26 guarded paths)</summary>

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

<details><summary>Effect applied in `PlayerActionManager$$AddEventAbnormal` (8 guarded paths)</summary>

- when `(PlayerActionManager.get_IsDead() & 1) eq 0` AND `((abnormalState & 255) - 24) hs 4` AND `(abnormalState & 255) ne 252` AND `(SkillBufferManager.ContainsBuffer(?blr, 713, 0, stateTime) & 1) ne 0`
  - calls `virtual PlayerActionManager.get_IsDead`, `interface IPlayerStatusCalculator.get_AntiVirus`, `SkillBufferManager$$RemoveSelfBuffer`, `0x165db78`, `System.Collections.Generic.List<object>$$.ctor`, `Singleton<object>$$get_Instance`, `GameManager$$ActionSuppportDelay`, `UnityEngine.Random$$Range`
- when `(PlayerActionManager.get_IsDead() & 1) eq 0` AND `((abnormalState & 255) - 24) hs 4` AND `(abnormalState & 255) ne 252` AND `(SkillBufferManager.ContainsBuffer(?blr, 713, 0, stateTime) & 1) ne 0`
  - returns `CountUpIdManager.Next(abnormalLocalIdManager, 0, ?x2, ?x3)`
  - calls `virtual PlayerActionManager.get_IsDead`, `interface IPlayerStatusCalculator.get_AntiVirus`, `SkillBufferManager$$RemoveSelfBuffer`, `0x165db78`, `System.Collections.Generic.List<object>$$.ctor`, `Singleton<object>$$get_Instance`, `GameManager$$ActionSuppportDelay`, `UnityEngine.Random$$Range`
- when `(PlayerActionManager.get_IsDead() & 1) eq 0` AND `((abnormalState & 255) - 24) hs 4` AND `(abnormalState & 255) ne 252` AND `(SkillBufferManager.ContainsBuffer(?blr, 713, 0, stateTime) & 1) ne 0`
  - returns `UnityEngine.Random.Range(0, 100, 0, ?x3)`
  - calls `virtual PlayerActionManager.get_IsDead`, `interface IPlayerStatusCalculator.get_AntiVirus`, `SkillBufferManager$$RemoveSelfBuffer`, `0x165db78`, `System.Collections.Generic.List<object>$$.ctor`, `Singleton<object>$$get_Instance`, `GameManager$$ActionSuppportDelay`, `UnityEngine.Random$$Range`
- when `(PlayerActionManager.get_IsDead() & 1) eq 0` AND `((abnormalState & 255) - 24) hs 4` AND `(abnormalState & 255) ne 252` AND `(SkillBufferManager.ContainsBuffer(?blr, 713, 0, stateTime) & 1) ne 0`
  - returns `UnityEngine.Random.Range(0, 100, 0, ?x3)`
  - calls `virtual PlayerActionManager.get_IsDead`, `interface IPlayerStatusCalculator.get_AntiVirus`, `SkillBufferManager$$RemoveSelfBuffer`, `0x165db78`, `System.Collections.Generic.List<object>$$.ctor`, `Singleton<object>$$get_Instance`, `GameManager$$ActionSuppportDelay`, `UnityEngine.Random$$Range`
- when `(PlayerActionManager.get_IsDead() & 1) eq 0` AND `((abnormalState & 255) - 24) hs 4` AND `(abnormalState & 255) ne 252` AND `(SkillBufferManager.ContainsBuffer(?blr, 713, 0, stateTime) & 1) eq 0`
  - calls `virtual PlayerActionManager.get_IsDead`, `interface IPlayerStatusCalculator.get_AntiVirus`, `UnityEngine.Random$$Range`, `SkillBufferManager$$GetSkillBufferParam`, `UnityEngine.Random$$Range`, `CountUpIdManager$$Next`, `Singleton<object>$$get_Instance`, `GameManager$$EventAbnormal`
- when `(PlayerActionManager.get_IsDead() & 1) eq 0` AND `((abnormalState & 255) - 24) hs 4` AND `(abnormalState & 255) ne 252` AND `(SkillBufferManager.ContainsBuffer(?blr, 713, 0, stateTime) & 1) eq 0`
  - returns `CountUpIdManager.Next(abnormalLocalIdManager, 0, ?x2, ?x3)`
  - calls `virtual PlayerActionManager.get_IsDead`, `interface IPlayerStatusCalculator.get_AntiVirus`, `UnityEngine.Random$$Range`, `SkillBufferManager$$GetSkillBufferParam`, `UnityEngine.Random$$Range`, `CountUpIdManager$$Next`
- when `(PlayerActionManager.get_IsDead() & 1) eq 0` AND `((abnormalState & 255) - 24) hs 4` AND `(abnormalState & 255) ne 252` AND `(SkillBufferManager.ContainsBuffer(?blr, 713, 0, stateTime) & 1) eq 0`
  - returns `UnityEngine.Random.Range(0, 100, 0, ?x3)`
  - calls `virtual PlayerActionManager.get_IsDead`, `interface IPlayerStatusCalculator.get_AntiVirus`, `UnityEngine.Random$$Range`, `SkillBufferManager$$GetSkillBufferParam`, `UnityEngine.Random$$Range`
- when `(PlayerActionManager.get_IsDead() & 1) eq 0` AND `((abnormalState & 255) - 24) hs 4` AND `(abnormalState & 255) ne 252` AND `(SkillBufferManager.ContainsBuffer(?blr, 713, 0, stateTime) & 1) eq 0`
  - returns `UnityEngine.Random.Range(0, 100, 0, ?x3)`
  - calls `virtual PlayerActionManager.get_IsDead`, `interface IPlayerStatusCalculator.get_AntiVirus`, `UnityEngine.Random$$Range`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `MobaPlayerActionManager$$Damaged (TryGetBuf)`
- `MobaPlayerActionManager$$ReceiveDamaged (TryGetBuf)`
- `MobaPlayerSecondaryStatus$$get_AntiVirus (TryGetBuf)`
- `PlayerActionManager$$AddEventAbnormal (ContainsBuffer)`
- `PlayerActionManager$$Damaged (TryGetBuf)`
- `PlayerSecondaryStatus$$CalcAntiVirus (TryGetBuf)`

---

### เมจิกวัลแคน (MagicBalkan) · uid 714

<img src="../../icons/sk_714.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 4) · **Type:** Object · **Max Lv:** 250 · **Weapons:** MainMagictool · **Requires:** แอสเทิลแลนซ์ · **Client class:** `MagicBalkanAction`

> ทักษะปืนเวทมนตร์แบบหมุน
> สร้างความเสียหายเวทย์อย่างต่อเนื่องกับเป้าหมาย
> สามารถเพิ่มการใช้ MP เพื่อโจมตีต่อเนื่องแต่พลังจะค่อยๆ ลดลง
> การโจมตีนี้ไม่ทำให้เกิดความเคยชิน

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.55 | 0.6 | 0.65 | 0.7 | 0.75 | 0.8 | 0.85 | 0.9 | 0.95 | 1 |
| Flat dmg + | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 |
| Flat dmg + [(damageCount + 1) gt 4] | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((((Lv + (Lv << 2)) + 50)) / 100)` — (damageCount + 1) gt 4
- SkillRate × `((((Lv + (Lv << 2)) + 50)) / 100)` — (damageCount + 1) le 4

**Role:** attack (deals damage) · buff (self) · placed object / trap / summon

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; never (IsExpDefFluctuate=false)

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` sets: `(0)`
- `SkillRate` multiplies by (adds into): `((((Lv + (Lv << 2)) + 50)) / 100)`

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `2` = 2
- **Loop / hit-repeat count** (`LoopParam`): `int(MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)))` _(when !PlayerAttackBase.IsBlank(this) AND PlayerStatusBase.CheckBodyAbility(PlayerActionManagerBase.get_PlayerStatus(), 2) OR !PlayerAttackBase.IsBlank(this) AND !PlayerStatusBase.CheckBodyAbility(PlayerActionManagerBase.get_PlayerStatus(), 2))_
- **Number of damage events** (`damageCount`): `(damageCount + 1)`

**Proration:** slot `Magic`, mode `never (IsExpDefFluctuate=false)`, attack type `Magic`, action id 714

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `skillRate` = `((Lv + (Lv << 2)) + 50)` → Lv1..10: [55, 60, 65, 70, 75, 80, 85, 90, 95, 100]
- set `fixAddDamage` = `0` = 0
- set `CastTime` = `2` = 2

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`ActionStart`** (3 paths)

- set `LoopParam` = `int(MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)))` — when !PlayerAttackBase.IsBlank(this) AND PlayerStatusBase.CheckBodyAbility(PlayerActionManagerBase.get_PlayerStatus(), 2) OR !PlayerAttackBase.IsBlank(this) AND !PlayerStatusBase.CheckBodyAbility(PlayerActionManagerBase.get_PlayerStatus(), 2)
- calls `MagicBalkanBuf..ctor` = `.ctor(Lv)` — when !PlayerAttackBase.IsBlank(this) AND PlayerStatusBase.CheckBodyAbility(PlayerActionManagerBase.get_PlayerStatus(), 2) OR !PlayerAttackBase.IsBlank(this) AND !PlayerStatusBase.CheckBodyAbility(PlayerActionManagerBase.get_PlayerStatus(), 2)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new MagicBalkanBuf, Id)` — when !PlayerAttackBase.IsBlank(this) AND PlayerStatusBase.CheckBodyAbility(PlayerActionManagerBase.get_PlayerStatus(), 2) OR !PlayerAttackBase.IsBlank(this) AND !PlayerStatusBase.CheckBodyAbility(PlayerActionManagerBase.get_PlayerStatus(), 2)

**`CheckRangeHit`** (6 paths)

- set `isHit` = `0` = 0 — when UnityEngine.Object.op_Equality(playerAction) OR !BattleManagerBase.get_IsTargeting(playerAction.battleManager) AND !UnityEngine.Object.op_Equality(playerAction) OR !UnityEngine.Object.op_Equality(playerAction) AND BattleManagerBase.get_IsTargeting(playerAction.battleManager) AND UnityEngine.Object.op_Equality(playerAction.battleManager.mainTargetData.Target)
- set `isHit` = `1` = 1 — when !UnityEngine.Object.op_Equality(playerAction) AND !UnityEngine.Object.op_Equality(playerAction.battleManager.mainTargetData.Target) AND !UnityEngine.Object.op_Inequality(UnityEngine.GameObject.get_transform(playerAction.battleManager.mainTargetData.Target), targetTransform) AND (((UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(playerAction)).z) * (UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(playerAction)).z)) + ((UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(playerAction)).x) * (UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(playerAction)).x))) ls ((ActionRange + size) * (ActionRange + size)) AND BattleManagerBase.get_IsTargeting(playerAction.battleManager)

**`NextRangeHit`** (4 paths)

- set `damageCount` = `(damageCount + 1)`
- set `skillRate` = `System.Math.Max(((((damageCount + 1) // 5) * 0xffffffec) + ((Lv * 10) + 200)), 10)` — when (damageCount + 1) gt 4
- set `fixAddDamage` = `100` = 100 — when (damageCount + 1) gt 4
- set `skillRate` = `(((((damageCount + 1) + ((damageCount + 1) << 2)) + 5) * Lv) + 50)` — when (damageCount + 1) le 4

**`calcPlayerToMobDamage`** (4 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `SetConstant[SkillConstantDamage]` = `fixAddDamage`
- template `SetConstant[MinDamage]` = `1`
- info `templates` = `1`

**`CreateTake`** (1 path)

- set `current` = `SkillLinkedTake.CreateNextTake(new SkillLinkedTake, 0xbf7acc8)`

**`OnEnd`** (3 paths)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(714)` — when IsInstanceOf(playerAction, PlayerActionManager) eq 1 OR IsInstanceOf(playerAction, MobaPlayerActionManager) eq 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1

**`via PlayerAttackBase$$HitReactionAssign`** (3467 paths)

- calls `MathUtil.CheckPercent` = `CheckPercent()` — when !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) eq 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3
- template `SetCalcValue[GuardPower]` = `System.Math.Max(0, (25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4))))` — when !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType ne 2 AND comboType ne 3
- template `SetCalcValue[GuardPower]` = `25` — when !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType ne 2 AND comboType ne 3

</details>

**Buffs**

**Buff `MagicBalkanBuf`**
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:MagicBalkanBuf$$.ctor<-MagicBalkanAction$$ActionStart` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

---

### สแลชรีปเปอร์ (SlashReaper) · uid 718

<img src="../../icons/sk_718.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 4) · **Type:** Object · **Max Lv:** 250 · **Weapons:** MainMagictool · **Requires:** แฟกทิสอาร์ม · **Client class:** `SlashReaperAction`

> ใช้ดาบเวทป้องกันตัวเองจากภัยคุกคามที่เข้ามาใกล้
> 
> หากตรงตามเงื่อนไขดาบเวทจะเพิ่มขึ้น(สูงสุด 99 ขีดจำกัดการใช้ 5)
> เมื่อใช้สกิลซ้ำอีกครั้งจะปล่อยดาบเวทที่ปรากฏ
> พุ่งเข้าโจมตีเป้าหมาย

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(skillRate[(2)] / 100)` — IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND IsOtherPlayer ne 0 AND param eq 2 OR IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND param eq 2 AND param ne 10 & state eq 2 AND state lo constDamage.Length AND state lo skillRate.Length OR state eq 2 AND state hs constDamage.Length AND state lo skillRate.Length OR state lo constDamage.Length AND state lo skillRate.Length AND state ne 2
- SkillRate × `(skillRate[(2)] / 100)` — (state - 1) hs 2 AND System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())) ge 1 OR !UnityEngine.Object.op_Equality(?stack) AND (state - 1) hs 2 AND System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())) ge 1 OR (state - 1) hs 2 AND System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())) ge 1 AND UnityEngine.Object.op_Equality(?stack) & state eq 2 AND state lo constDamage.Length AND state lo skillRate.Length OR state eq 2 AND state hs constDamage.Length AND state lo skillRate.Length OR state lo constDamage.Length AND state lo skillRate.Length AND state ne 2
- Flat dmg + `constDamage[(2)]` — IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND IsOtherPlayer ne 0 AND param eq 2 OR IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND param eq 2 AND param ne 10 & state eq 2 AND state lo constDamage.Length AND state lo skillRate.Length OR state lo constDamage.Length AND state lo skillRate.Length AND state ne 2
- Flat dmg + `constDamage[(2)]` — (state - 1) hs 2 AND System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())) ge 1 OR !UnityEngine.Object.op_Equality(?stack) AND (state - 1) hs 2 AND System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())) ge 1 OR (state - 1) hs 2 AND System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())) ge 1 AND UnityEngine.Object.op_Equality(?stack) & state eq 2 AND state lo constDamage.Length AND state lo skillRate.Length OR state lo constDamage.Length AND state lo skillRate.Length AND state ne 2

**Role:** attack (deals damage) · placed object / trap / summon

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration change is decided by the skill's own check (`CheckExpDefFluctuate`).

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `constDamage[(2)]`
- `SkillRate` multiplies by (adds into): `(skillRate[(2)] / 100)`

**Mechanics recovered from code**

- **Magic resistance** (`magicResist`): `((Lv + (Lv << 2)) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100] _(when constDamage.Length hi 1 AND constDamage.Length hi 2 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0 OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 718) eq 0 AND constDamage.Length hi 1 AND constDamage.Length hi 2 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0 OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 718) ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 718).BuffEffectActive ne 0 AND constDamage.Length hi 1 AND constDamage.Length hi 2 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0)_
- **MP cost** (`mp`): `100` = 100 _(when TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 718) ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 718).BuffEffectActive ne 0 AND constDamage.Length hi 1 AND constDamage.Length hi 2 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0)_

**Proration:** slot `Magic`, mode `custom_check + class check`, attack type `Magic`, action id 718

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (10 paths)

- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(16)`
- set `skillRate[0]` = `((status.Agi // (20 - Lv)) + 10)` — when constDamage.Length eq 0 AND skillRate.Length ne 0 OR constDamage.Length ne 0 AND skillRate.Length ls 1 AND skillRate.Length ne 0 OR constDamage.Length ls 1 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length ne 0
- set `constDamage[0]` = `int((baseAGI / ((Lv * -0.5) + 10)))` — when constDamage.Length ne 0 AND skillRate.Length ls 1 AND skillRate.Length ne 0 OR constDamage.Length ls 1 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length ne 0 OR constDamage.Length hi 1 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length ls 2 AND skillRate.Length ne 0
- set `skillRate[1]` = `((status.Agi // (20 - Lv)) + 10)` — when constDamage.Length ls 1 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length ne 0 OR constDamage.Length hi 1 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length ls 2 AND skillRate.Length ne 0 OR constDamage.Length hi 1 AND constDamage.Length hi 2 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0
- set `constDamage[1]` = `int((baseAGI / ((Lv * -0.5) + 10)))` — when constDamage.Length hi 1 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length ls 2 AND skillRate.Length ne 0 OR constDamage.Length hi 1 AND constDamage.Length hi 2 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0 OR constDamage.Length hi 1 AND constDamage.Length ls 2 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0
- set `skillRate[2]` = `((baseINT // 5) + 200)` — when constDamage.Length hi 1 AND constDamage.Length hi 2 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0 OR constDamage.Length hi 1 AND constDamage.Length ls 2 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0 OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 718) eq 0 AND constDamage.Length hi 1 AND constDamage.Length hi 2 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0
- set `constDamage[2]` = `100` = 100 — when constDamage.Length hi 1 AND constDamage.Length hi 2 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0 OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 718) eq 0 AND constDamage.Length hi 1 AND constDamage.Length hi 2 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0 OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 718) ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 718).BuffEffectActive ne 0 AND constDamage.Length hi 1 AND constDamage.Length hi 2 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0
- set `magicResist` = `((Lv + (Lv << 2)) << 1)` → Lv1..10: [10, 20, 30, 40, 50, 60, 70, 80, 90, 100] — when constDamage.Length hi 1 AND constDamage.Length hi 2 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0 OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 718) eq 0 AND constDamage.Length hi 1 AND constDamage.Length hi 2 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0 OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 718) ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 718).BuffEffectActive ne 0 AND constDamage.Length hi 1 AND constDamage.Length hi 2 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0
- set `inRad` = `MathUtil.DisplayMeterToDistance(2.6)` — when constDamage.Length hi 1 AND constDamage.Length hi 2 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0 OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 718) eq 0 AND constDamage.Length hi 1 AND constDamage.Length hi 2 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0 OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 718) ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 718).BuffEffectActive ne 0 AND constDamage.Length hi 1 AND constDamage.Length hi 2 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0
- set `mp` = `100` = 100 — when TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 718) ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 718).BuffEffectActive ne 0 AND constDamage.Length hi 1 AND constDamage.Length hi 2 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0

**`RemoveBrade`** (15 paths)

- set `bladeTakeList` = `new System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>` — when System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())) ge 1 AND System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())) gt count AND count gt 0

**`AddBlade`** (11 paths)

- set `countCreatingBlade` = `(countCreatingBlade + 1)` — when !UnityEngine.Object.op_Equality(parentTake) AND ((count lt 5 ? count : 5) - SlashReaperAction.get_BladeCount(this)) eq 1 AND (count lt 5 ? count : 5) gt (countCreatingBlade + SlashReaperAction.get_BladeCount(this)) AND (state - 1) hs 2 AND SlashReaperAction.get_BladeCount(this) lt (count lt 5 ? count : 5) OR ((count lt 5 ? count : 5) - SlashReaperAction.get_BladeCount(this)) eq 1 AND (count lt 5 ? count : 5) gt (countCreatingBlade + SlashReaperAction.get_BladeCount(this)) AND (state - 1) hs 2 AND SlashReaperAction.get_BladeCount(this) lt (count lt 5 ? count : 5) AND UnityEngine.Object.op_Equality(parentTake)
- set `countCreatingBlade` = `((countCreatingBlade + 1) + 1)` — when !UnityEngine.Object.op_Equality(parentTake) AND (((count lt 5 ? count : 5) - SlashReaperAction.get_BladeCount(this)) - 1) eq 1 AND ((count lt 5 ? count : 5) - SlashReaperAction.get_BladeCount(this)) ne 1 AND (count lt 5 ? count : 5) gt (countCreatingBlade + SlashReaperAction.get_BladeCount(this)) AND (state - 1) hs 2 AND SlashReaperAction.get_BladeCount(this) lt (count lt 5 ? count : 5) OR (((count lt 5 ? count : 5) - SlashReaperAction.get_BladeCount(this)) - 1) eq 1 AND ((count lt 5 ? count : 5) - SlashReaperAction.get_BladeCount(this)) ne 1 AND (count lt 5 ? count : 5) gt (countCreatingBlade + SlashReaperAction.get_BladeCount(this)) AND (state - 1) hs 2 AND SlashReaperAction.get_BladeCount(this) lt (count lt 5 ? count : 5) AND UnityEngine.Object.op_Equality(parentTake)
- set `countCreatingBlade` = `(((countCreatingBlade + 1) + 1) + 1)` — when !UnityEngine.Object.op_Equality(parentTake) AND ((((count lt 5 ? count : 5) - SlashReaperAction.get_BladeCount(this)) - 1) - 1) eq 1 AND (((count lt 5 ? count : 5) - SlashReaperAction.get_BladeCount(this)) - 1) ne 1 AND ((count lt 5 ? count : 5) - SlashReaperAction.get_BladeCount(this)) ne 1 AND (count lt 5 ? count : 5) gt (countCreatingBlade + SlashReaperAction.get_BladeCount(this)) AND (state - 1) hs 2 AND SlashReaperAction.get_BladeCount(this) lt (count lt 5 ? count : 5) OR !UnityEngine.Object.op_Equality(parentTake) AND ((((count lt 5 ? count : 5) - SlashReaperAction.get_BladeCount(this)) - 1) - 1) ne 1 AND (((count lt 5 ? count : 5) - SlashReaperAction.get_BladeCount(this)) - 1) ne 1 AND ((count lt 5 ? count : 5) - SlashReaperAction.get_BladeCount(this)) ne 1 AND (count lt 5 ? count : 5) gt (countCreatingBlade + SlashReaperAction.get_BladeCount(this)) AND (state - 1) hs 2 AND SlashReaperAction.get_BladeCount(this) lt (count lt 5 ? count : 5) OR ((((count lt 5 ? count : 5) - SlashReaperAction.get_BladeCount(this)) - 1) - 1) eq 1 AND (((count lt 5 ? count : 5) - SlashReaperAction.get_BladeCount(this)) - 1) ne 1 AND ((count lt 5 ? count : 5) - SlashReaperAction.get_BladeCount(this)) ne 1 AND (count lt 5 ? count : 5) gt (countCreatingBlade + SlashReaperAction.get_BladeCount(this)) AND (state - 1) hs 2 AND SlashReaperAction.get_BladeCount(this) lt (count lt 5 ? count : 5) AND UnityEngine.Object.op_Equality(parentTake)

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`SetTargetMobOthers`** (1 path)

- set `otherPlayerTarget` = `target`

**`ActionPreparation`** (10 paths)

- set `SkillParam` = `(SkillParam & 239)`
- set `checkBlank` = `(isFireTake & 1)`

**`calcPlayerToMobDamage`** (8 paths)

- template `AddRate[SkillRate]` = `(skillRate[state] / 100)` — when state eq 2 AND state lo constDamage.Length AND state lo skillRate.Length OR state eq 2 AND state hs constDamage.Length AND state lo skillRate.Length OR state lo constDamage.Length AND state lo skillRate.Length AND state ne 2
- template `AddConstant[SkillConstantDamage]` = `constDamage[state]` — when state eq 2 AND state lo constDamage.Length AND state lo skillRate.Length OR state lo constDamage.Length AND state lo skillRate.Length AND state ne 2
- info `templates` = `1`

**`CheckRangeHit`** (25 paths)

- set `countStateAtackHit` = `(countStateAtackHit + 1)` — when !UnityEngine.Object.op_Equality(targetTransform) AND SkillActionBase.CheckMainTarget(this, UnityEngine.GameObject.GetComponent<CharacterActionManagerBase>(UnityEngine.Component.get_gameObject(targetTransform))) AND System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())) gt countStateAtackHit AND state eq 2
- set `lastHitTime` = `UnityEngine.Time.get_time()` — when !UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(UnityEngine.Component.get_gameObject(targetTransform)), 0) AND !UnityEngine.Object.op_Equality(targetTransform) AND EnemyMobActionManagerBase.HasPlayerHate(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(UnityEngine.Component.get_gameObject(targetTransform)), 0) AND SlashReaperAction.CheckRange(this, actorTransform, targetTransform, size) AND UnityEngine.Time.get_time() pl (lastHitTime + (1 / System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())))) AND state ls 1 AND state ne 2 OR !UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(UnityEngine.Component.get_gameObject(targetTransform)), 0) AND !UnityEngine.Object.op_Equality(targetTransform) AND EnemyMobActionManagerBase.HasPlayerHate(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(UnityEngine.Component.get_gameObject(targetTransform)), 0) AND SlashReaperAction.CheckRange(this, actorTransform, targetTransform, size) AND UnityEngine.Time.get_time() pl (lastHitTime + (1 / System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())))) AND state hi 1 AND state ne 2 OR !UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(UnityEngine.Component.get_gameObject(targetTransform)), 0) AND !UnityEngine.Object.op_Equality(targetTransform) AND EnemyMobActionManagerBase.HasPlayerHate(UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(UnityEngine.Component.get_gameObject(targetTransform)), 0) AND SlashReaperAction.CheckRange(this, actorTransform, targetTransform, size) AND UnityEngine.Time.get_time() pl (?stack[targetTransform] + 0.95) AND UnityEngine.Time.get_time() pl (lastHitTime + (1 / System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())))) AND state ls 1 AND state ne 2

**`ActionSkillReceiveEffect`** (7 paths)

- set `parentTake` = `UnityEngine.GameObject.GetComponent<TakePlayer>(effect)` — when UnityEngine.Object.op_Equality(parentTake) AND countCreatingBlade lt 1 OR 1 ge countCreatingBlade AND UnityEngine.Object.op_Equality(parentTake) AND countCreatingBlade ge 1 OR 1 lt countCreatingBlade AND 2 ge countCreatingBlade AND UnityEngine.Object.op_Equality(parentTake) AND countCreatingBlade ge 1
- set `countCreatingBlade` = `(countCreatingBlade - 1)` — when !UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<TakePlayer>(effect), 0) AND !UnityEngine.Object.op_Equality(parentTake)

**`ActionSkillEvent`** (13 paths)

- set `state` = `2` = 2 — when IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND IsOtherPlayer ne 0 AND param eq 2 OR IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND param eq 2 AND param ne 10

**`OnSkillButton`** (7 paths)

- set `state` = `1` = 1 — when (state - 1) hs 2 AND System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())) ge 1 OR !UnityEngine.Object.op_Equality(?stack) AND (state - 1) hs 2 AND System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())) ge 1 OR (state - 1) hs 2 AND System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())) ge 1 AND UnityEngine.Object.op_Equality(?stack)

**`.DamageLogData::AddDamage`** (1 path)

- set `Damage` = `(DamageLogData.Damage + damage)`
- set `Count` = `(DamageLogData.Count + 1)`

</details>

<details><summary>Effect applied in `PlayerActionManager$$GetSkillTargetType` (4 guarded paths)</summary>

- when `skillId gt 629` AND `skillId le 991` AND `skillId gt 707` AND `skillId eq 718`
  - returns `[MasterSkillDataManager.GetSkillMaster(Singleton<object>.get_Instance(meta(0x397a328, Method$Singleton<MasterSkillDataManager>.get_Instance()), ?x1, ?x2, ?x3), 718, 0, ?x3)+0x2c]`
  - calls `Singleton<object>$$get_Instance`, `MasterSkillDataManager$$GetSkillMaster`
- when `skillId gt 629` AND `skillId le 991` AND `skillId gt 707` AND `skillId eq 718`
  - returns `1`
- when `skillId gt 629` AND `skillId le 991` AND `skillId gt 707` AND `skillId eq 718`
  - calls `0x165db84`, `0x165df00`
- when `skillId gt 629` AND `skillId le 991` AND `skillId gt 707` AND `skillId eq 718`
  - returns `1`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `PlayerActionManager$$GetSkillTargetType (TryGetBuf)`

---

### สไปรท์อัพเกรด (EnhanceSprite) · uid 719

<img src="../../icons/sk_719.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 300 · **Weapons:** MainMagictool · **Requires:** สเตบิไลซ์ · **Client class:** `EnhanceSprite` (passive mastery)

> เพิ่มระยะเวลาต่อเนื่องของเคาน์เตอร์ฟอร์ส
> แอสเทิลแลนซ์ และสเตบิไลซ์

**Role:** passive mastery

---

### รีเทค (Retake) · uid 720

<img src="../../icons/sk_720.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 300 · **Weapons:** MainMagictool · **Requires:** สไปรท์ชีลด์ · **Flags:** NoMarketSearch, CanNotUse · **Client class:** `Retake` (passive mastery)

> ได้รับสถานะรีเทคเมื่อเปลี่ยนแผนที่
> และจะแสดงผลเมื่อเริ่มต่อสู้กับศัตรูที่แข็งแกร่ง
> 
> ในระหว่างที่ผลของสกิลยังอยู่สามารถฟื้นคืนชีพ
> ได้ทันที 1 ครั้งและฟื้นฟู HP และ MP จนเต็ม

**Role:** buff (self) · passive mastery

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Buffs**

**Buff `RetakeBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `((Lv + 2) * Lv)` s
- Buff fields set in the constructor (all recovered):
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `BufEffectTakeUid` = `-1` = -1
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `PlayerActionManager$$Damaged (TryGetBuf)`

---

### คาตาลาโบมัส (Catarabomos) · uid 721

<img src="../../icons/sk_721.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 5) · **Type:** Attack · **Max Lv:** 300 · **Weapons:** MainMagictool · **Requires:** เมจิกวัลแคน · **Client class:** `CatarabomosAction`

> เวทมนตร์ที่กัดกินวิญญาณด้วยคำสาป
> 
> ทำให้เป้าหมายติด [คำสาป] ถ้าสำเร็จ
> จะเพิ่มผลพิเศษที่สร้างความเสียหายอย่างต่อเนื่อง
> ((พลังโจมตีจะลดลงเมื่อใช้กับบอส)

**Role:** utility / system action

This action never changes monster proration: IsExpDefFluctuate=false.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**Proration:** slot `none`, mode `never (IsExpDefFluctuate=false)`, attack type `None`, action id 721

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `abnormalTime` = `(Lv + 2)` → Lv1..10: [3, 4, 5, 6, 7, 8, 9, 10, 11, 12]
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`calcPlayerToMobDamage`** (4 paths)

- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(32, 100, playerAction)`

**`AddAbnormalEffect`** (2 paths)

- calls `CatarabomosDebuff..ctor` = `.ctor(Toram.Common.ArchetypeUid.get_Id(stkp(-56)), skill.Level, status.Stable)` — when abnormalType eq 32

</details>

---

### เลเบนส์กลานซ์ (LebenGlanz) · uid 722

<img src="../../icons/sk_722.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 5) · **Type:** Attack · **Max Lv:** 300 · **Weapons:** MainMagictool · **Requires:** สแลชรีปเปอร์ · **Client class:** `LebenGlanzAction`

> วิชาต้องห้ามที่จะย้อนกลับเวลาแห่งชีวิต
> ที่สูญหายไปให้กลายเป็นพลังระเบิด
> 
> ติด[ระเบิดพลีชีพ]ให้แก่เป้าหมาย
> เมื่อระยะเวลาแสดงผลสิ้นสุดลงจะระเบิดสร้างความเสียหาย

<details><summary>In-game level notes</summary>

- Lv15: ดีบัฟ[ระเบิดพลีชีพ]  เมื่อโจมตีเป้าหมายที่ติดดีบัฟนี้สมาชิกในปาร์ตี้จะฟื้นฟู MP การโจมตี และจะสะสม MP ส่วนหนึ่งที่ใช้ระหว่างการโจมตี  เมื่อระเบิดจะสร้างความเสียหายตาม MP ที่สะสม และฟื้นฟู HP ให้กับสมาชิกปาร์ตี้ที่อยู่ใกล้เคียง

</details>

**Role:** buff (self)

This action never changes monster proration: IsExpDefFluctuate=false.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (IsExpDefFluctuate=false)`, attack type `None`, action id 722

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`calcPlayerToMobDamage`** (2 paths)

- calls `LifeExplosionDebuff..ctor` = `.ctor(Lv)`

**`EndDebuffHpHeal`** (387 paths)

- calls `Toram.Common.Actions.TargetPlayerData..ctor` = `.ctor()` — when (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(PlayerDataManager.get_gameObject(PlayerDataManager.GetPlayerDataManager()))).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(enemy)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(PlayerDataManager.get_gameObject(PlayerDataManager.GetPlayerDataManager()))).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(enemy)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(PlayerDataManager.get_gameObject(PlayerDataManager.GetPlayerDataManager()))).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(enemy)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(PlayerDataManager.get_gameObject(PlayerDataManager.GetPlayerDataManager()))).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(enemy)).x))) mi ((MathUtil.DisplayMeterToDistance(7) + EnemyMobActionManagerBase.get_Size()) * (MathUtil.DisplayMeterToDistance(7) + EnemyMobActionManagerBase.get_Size())) AND 0 hs OtherPlayerManager.GetOtherPlayers(TargetableListManagerBase<OtherPlayerManager>.get_Instance()).m_CancellationTokenSource AND OtherPlayerManager.GetOtherPlayers(TargetableListManagerBase<OtherPlayerManager>.get_Instance()).m_CancellationTokenSource ge 1 OR (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(PlayerDataManager.get_gameObject(PlayerDataManager.GetPlayerDataManager()))).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(enemy)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(PlayerDataManager.get_gameObject(PlayerDataManager.GetPlayerDataManager()))).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(enemy)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(PlayerDataManager.get_gameObject(PlayerDataManager.GetPlayerDataManager()))).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(enemy)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(PlayerDataManager.get_gameObject(PlayerDataManager.GetPlayerDataManager()))).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(enemy)).x))) mi ((MathUtil.DisplayMeterToDistance(7) + EnemyMobActionManagerBase.get_Size()) * (MathUtil.DisplayMeterToDistance(7) + EnemyMobActionManagerBase.get_Size())) AND OtherPlayerManager.GetOtherPlayers(TargetableListManagerBase<OtherPlayerManager>.get_Instance()).m_CancellationTokenSource lt 1 AND System.Linq.Enumerable.Count<TargetPlayerData>(new System.Collections.Generic.List<TargetPlayerData>) ge 1 OR (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(PlayerDataManager.get_gameObject(PlayerDataManager.GetPlayerDataManager()))).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(enemy)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(PlayerDataManager.get_gameObject(PlayerDataManager.GetPlayerDataManager()))).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(enemy)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(PlayerDataManager.get_gameObject(PlayerDataManager.GetPlayerDataManager()))).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(enemy)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(PlayerDataManager.get_gameObject(PlayerDataManager.GetPlayerDataManager()))).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(enemy)).x))) mi ((MathUtil.DisplayMeterToDistance(7) + EnemyMobActionManagerBase.get_Size()) * (MathUtil.DisplayMeterToDistance(7) + EnemyMobActionManagerBase.get_Size())) AND OtherPlayerManager.GetOtherPlayers(TargetableListManagerBase<OtherPlayerManager>.get_Instance()).m_CancellationTokenSource lt 1 AND System.Linq.Enumerable.Count<TargetPlayerData>(new System.Collections.Generic.List<TargetPlayerData>) lt 1

**`ValidDebuff`** (3 paths)

- calls `LebenGlanzBuf..ctor` = `.ctor(LifeExplosionDebuff.GetAttackMpRecovery(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 17)))` — when TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 17) ne 0
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new LebenGlanzBuf, 0)`
- calls `LebenGlanzBuf..ctor` = `.ctor(0)`

**`InvalidDebuff`** (1 path)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(722)`

</details>

**Buffs**

**Buff `LebenGlanzBuf`**
- `AttackMprecoveryUp` = `(atkMpRecovery)` _(when BuffEffectActive ne 0)_
- `AttackMprecoveryUp` = `0` _(when BuffEffectActive eq 0)_
- Buff fields set in the constructor (all recovered):
  - `attackMpRecovery` = `atkMpRecovery`
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:LebenGlanzBuf$$.ctor<-LebenGlanzAction$$ValidDebuff` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

---
