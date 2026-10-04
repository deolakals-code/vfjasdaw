# スプライトスキル (`SpriteSkill`) — skill details

18 entries.

### ออโต้ดีไวซ์ (AutoDevice) · uid 705

<img src="../../icons/sk_705.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 1) · **Type:** Buffer · **Max Lv:** 50 · **Weapons:** MainMagictool · **Flags:** StarGem · **Client class:** `AutoDeviceAction`

> ทักษะที่ยอมให้อุปกรณ์เวทมนตร์ช่วยโจมตี
> การโจมตีปกติใส่เป้าหมายหลังจาก
> ไม่ได้ทำอะไรเป็นเวลา 60 วินาที
> ประสิทธิภาพลดลงถ้าอยู่ห่างออกไป (8 เมตรหรือมากกว่า)

**How it works**

- Buffer skill of the スプライトスキル tree (tier 1, max Lv 50); usable with MainMagictool.
- It installs a buff on the caster.
- Buffs:
  - `AutoDeviceBuf`: lasts `(0 + 60)` s; Lv1 → Lv10: Percent (generic percent) 5 → 50, Value (generic value (meaning set by the code that reads the buff)) 14 → 5
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (2 lookups; see the last section).

**When each part runs**

- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 3 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 705
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `AutoDeviceBuf` — `.ctor(Lv, EnhanceSprite.GetEnhanceParam(PlayerStatusBase.get_SkillManager().SkillMasteryList[719], PlayerAttackBase.get_ActionID()))`
- `ActionHit` (when the attack connects): adds the caster's buff of `new AutoDeviceBuf` — `AddSelfBuffer(new AutoDeviceBuf, Id)`
- `ActionHit` (when the attack connects): constructs `AutoDeviceBuf` — `.ctor(Lv, 0)`

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `Percent`: generic percent
- `Value`: generic value (meaning set by the code that reads the buff)

**Where else this skill takes effect**

- Effect applied in `MobaPlayerActionManager$$Update` (24 guarded paths):
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
- Effect applied in `PlayerActionManager$$Update` (291 guarded paths, truncated):
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
- Code that reads this skill's level / buff by constant id: `MobaPlayerActionManager$$Update (TryGetBuf)`, `PlayerActionManager$$Update (TryGetBuf)`

_Raw recovered data (every method item): [trees/SpriteSkill.md](../trees/SpriteSkill.md) — uid 705_

---

### อิกนิชั่น (Ignition) · uid 715

<img src="../../icons/sk_715.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 1) · **Type:** Attack · **Max Lv:** 50 · **Weapons:** MainMagictool · **Client class:** `IgnitionAction`

> เผาผลาญพลังเวทของศัตรูเพื่อโจมตี
> สร้างความเสียหายเวทมนตร์ที่ไม่เสถียร
> มีโอกาสต่ำที่จะทำให้ศัตรูติด[อ่อนแอ]
> DEX และเลเวลของสไปรท์ทรีของคุณยิ่งสูงเท่าไหร่
> จะยิ่งมีโอกาสติดมากขึ้น

**How it works**

- Attack skill of the スプライトスキル tree (tier 1, max Lv 50); usable with MainMagictool.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on EqAtk (formula below); flat damage +100
- Proration: magic proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Collapse (16).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 3 tpl, 2 call, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((System.Math.Min(((Lv * 60) + status.EqAtk), 1200)) / 100)`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((System.Math.Min(((Lv * 60) + status.EqAtk), 1200)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[StableRate]` = `PlayerAttackBase.CalcStable(IgnitionAction.get_AttackType(), int((status.Stable + (status.Stable * -0.6))), (SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) & 1), PlayerActionManagerBase.get_PlayerStatus())`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `100`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 715
- Uses the magic proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Rolls `abnomalParcent`% to inflict **Collapse (16)** (`calcPlayerToMobDamage`)
- Marks the hit with ailment **Collapse (16)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 16, abnomalParcent, playerAction)`

_Raw recovered data (every method item): [trees/SpriteSkill.md](../trees/SpriteSkill.md) — uid 715_

---

### เอ็กเพรสเอด (RushAid) · uid 706

<img src="../../icons/sk_706.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 90 · **Weapons:** MainMagictool · **Requires:** ออโต้ดีไวซ์ · **Client class:** `RushAidMastery` (passive mastery)

> เร่งแรงส่งอุปกรณ์เวทมนตร์ให้เร็วขึ้น
> 
> เพิ่มความเร็วในการเคลื่อนที่ไปยังผู้เล่น
> ที่เป็นเป้าหมายเมื่อใช้"ปฐมพยาบาล"
> และลดความเสียหายที่ได้รับตามจำนวนครั้งที่กำหนด

**How it works**

- Mastery skill of the スプライトスキル tree (tier 2, max Lv 90); usable with MainMagictool.
- It installs a buff on the caster.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Buffs:
  - `RushAidBuf`; Lv1 → Lv10: MobLastDamageRateBuf (final damage multiplier vs monsters (buff category)) 10 → 100
- Passive modifiers (negative = penalty): CutDmgRate (damage taken reduction %) 10 at Lv1 to 100 at Lv10, Value (generic value) 0 at Lv1 to 2 at Lv10.
- Its effect is applied by client code: `MobAttackBase$$CalcLastDamage`, `PlayerActionManager$$Damaged`, `PlayerActionManager$$get_MoveSpeed`, `PlayerBattleManager.<>c__DisplayClass53_0$$<checkAssistMove>b__0` (formulas in the last section).
- Other client code reads this skill (4 lookups; see the last section).

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `MobLastDamageRateBuf`: final damage multiplier vs monsters (buff category)

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| CutDmgRate | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |
| Value | 0 | 0 | 0 | 1 | 1 | 1 | 1 | 2 | 2 | 2 |


Bonus meanings (inferred from the names):

- `CutDmgRate`: damage taken reduction %
- `Value`: generic value

**Where else this skill takes effect**

- Effect applied in `PlayerActionManager$$get_MoveSpeed` (66 guarded paths):
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
- Effect applied in `PlayerActionManager$$Damaged` (11 guarded paths):
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
- Effect applied in `PlayerBattleManager.<>c__DisplayClass53_0$$<checkAssistMove>b__0` (2 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 706, (this + 24), 0) & 1) ne 0`
    - returns `SkillBufferDataBase.End([(this + 24)+0x0], 0, ?x2, ?x3)`
    - calls `SkillBufferDataBase$$End`
  - when `(SkillBufferManager.TryGetBuf(?blr, 706, (this + 24), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 706, (this + 24), 0)`
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
- Code that reads this skill's level / buff by constant id: `MobAttackBase$$CalcLastDamage (TryGetBuf)`, `PlayerActionManager$$Damaged (TryGetBuf)`, `PlayerActionManager$$get_MoveSpeed (ContainsBuffer)`, `PlayerBattleManager.<>c__DisplayClass53_0$$<checkAssistMove>b__0 (TryGetBuf)`

_Raw recovered data (every method item): [trees/SpriteSkill.md](../trees/SpriteSkill.md) — uid 706_

---

### เคาน์เตอร์ฟอร์ส (CounterForce) · uid 707

<img src="../../icons/sk_707.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 2) · **Type:** Object · **Max Lv:** 90 · **Weapons:** MainMagictool · **Requires:** ออโต้ดีไวซ์ · **Client class:** `CounterForceAction`

> ทักษะเสริมของอุปกรณ์เวทมนตร์
> สร้างวงเวทเป็นเวลา 30 วินาที
> เพื่อโจมตีเป้าหมายหากสมาชิกในปาร์ตี้
> อยู่ในสายตาระยะ(ไม่เกิน 24m) (สูงสุด 3 ครั้ง)

**How it works**

- Object skill of the スプライトスキル tree (tier 2, max Lv 90); usable with MainMagictool.
- It installs a buff on the caster.
- It places an object in the world (trap, summon or field object).
- Buffs:
  - `CounterForceBuf`: lasts `(30 + EnhanceSprite.GetEnhanceParam(PlayerStatusBase.get_SkillManager().SkillMasteryList[719], CounterForceBuf.get_SkillId()))` s / `30` s
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (11 lookups; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 1 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 2 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 707
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `CounterForceBuf` — `.ctor(Lv, actarAction)`
- `ActionHit` (when the attack connects): adds the caster's buff of `new CounterForceBuf` — `AddSelfBuffer(new CounterForceBuf, Id)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`

**Buff values** (every recovered field; durations in seconds)

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

**Where else this skill takes effect**

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
- Effect applied in `CounterForceAttackAction$$OnEnd` (3 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 707, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `PlayerAttackBase.OnEnd(this, (cancel & 1), 0, ?x3)`
    - calls `CounterForceBuf$$EndSkill`, `PlayerAttackBase$$OnEnd`
  - when `(SkillBufferManager.TryGetBuf(?blr, 707, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `0x165db84`, `0x165df00`
  - when `(SkillBufferManager.TryGetBuf(?blr, 707, stkp(-40), 0) & 1) eq 0`
    - returns `PlayerAttackBase.OnEnd(this, (cancel & 1), 0, ?x3)`
    - calls `PlayerAttackBase$$OnEnd`
- Effect applied in `MobaPlayerBattleManager$$StartCounterForceAttack` (3 guarded paths):
  - when `SkillLv(707) ge 1`
    - calls `SkillFactory$$CreateSkill`, `0x165d8dc`, `SkillActionBase$$Initialize`, `UnityEngine.GameObject$$GetComponent<object>`, `PlayerSkillActionManager$$PlaceEffectPlay`
  - when `SkillLv(707) ge 1`
    - returns `UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<object>(target, meta(0x39745c0, Method$UnityEngine.GameObject.GetComponent<CharacterActionManagerBase>()), ?x2, ?x3), 0, 0, ?x3)`
    - calls `SkillFactory$$CreateSkill`, `0x165d8dc`, `SkillActionBase$$Initialize`, `UnityEngine.GameObject$$GetComponent<object>`
  - when `SkillLv(707) lt 1`
    - returns `SkillLv(707)`
    - calls `SkillFactory$$CreateSkill`, `0x165d8dc`
- Effect applied in `PlayerBattleManager$$StartCounterForceAttack` (3 guarded paths):
  - when `SkillLv(707) ge 1`
    - calls `SkillFactory$$CreateSkill`, `0x165d8dc`, `SkillActionBase$$Initialize`, `UnityEngine.GameObject$$GetComponent<object>`, `PlayerSkillActionManager$$PlaceEffectPlay`
  - when `SkillLv(707) ge 1`
    - returns `UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<object>(target, meta(0x39745c0, Method$UnityEngine.GameObject.GetComponent<CharacterActionManagerBase>()), ?x2, ?x3), 0, 0, ?x3)`
    - calls `SkillFactory$$CreateSkill`, `0x165d8dc`, `SkillActionBase$$Initialize`, `UnityEngine.GameObject$$GetComponent<object>`
  - when `SkillLv(707) lt 1`
    - returns `SkillLv(707)`
    - calls `SkillFactory$$CreateSkill`, `0x165d8dc`
- Effect applied in `FamiliaActionManager$$Damaged` (231 guarded paths, truncated):
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
- Effect applied in `OtherPlayer$$OnActionMobAttack` (216 guarded paths):
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
- Code that reads this skill's level / buff by constant id: `AutoMemberActionManager$$Damaged (TryGetBuf)`, `CounterForceAttackAction$$OnEnd (TryGetBuf)`, `FamiliaActionManager$$Damaged (TryGetBuf)`, `MercenaryActionManager$$Damaged (TryGetBuf)`, `MobaPlayerActionManager$$Damaged (TryGetBuf)`, `MobaPlayerActionManager$$ReceiveDamaged (TryGetBuf)`, `MobaPlayerBattleManager$$StartCounterForceAttack (GetSkillLv)`, `OtherPlayer$$OnActionMobAttack (TryGetBuf)`, `PetMemberActionManager$$Damaged (TryGetBuf)`, `PlayerActionManager$$Damaged (TryGetBuf)`, `PlayerBattleManager$$StartCounterForceAttack (GetSkillLv)`

_Raw recovered data (every method item): [trees/SpriteSkill.md](../trees/SpriteSkill.md) — uid 707_

---

### อาร์เดดราค (Aldedrak) · uid 716

<img src="../../icons/sk_716.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 2) · **Type:** Object · **Max Lv:** 90 · **Weapons:** MainMagictool · **Requires:** อิกนิชั่น · **Client class:** `AldedrakAction`

> ปล่อยกระสุนเวทมนตร์โจมตีจากใต้ดิน
> ยิงกระสุนเวทมนตร์เลียดพื้นดินไปที่เป้าหมาย
> เมื่อเข้าเป้าจะเกิดการโจมตีในวงแคบ
> หากมีเป้าหมายอื่นอยู่บนทางผ่านจะติดหยุดนิ่งและพุ่งผ่านไป

**How it works**

- Object skill of the スプライトスキル tree (tier 2, max Lv 90); usable with MainMagictool.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- It places an object in the world (trap, summon or field object).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [state ne 0]: skill multiplier depends on live values (formula below); flat damage +300
- Proration: magic proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Stop (12).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(16)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 1 info, 2 call
- `SetLaunch` — skill-specific method: 2 set
- `ActionHit` — when the attack connects: 1 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv * 35) + 350) + (((baseDEX + baseINT) lt 0 ? ((baseDEX + baseINT) + 1) : (baseDEX + baseINT)) >> 1))) / 100)` — state ne 0

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv * 35) + 350) + (((baseDEX + baseINT) lt 0 ? ((baseDEX + baseINT) + 1) : (baseDEX + baseINT)) >> 1))) / 100)`
  - when `state ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `300`
  - when `state ne 0`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 716
- Uses the magic proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Rolls `100`% to inflict **Stop (12)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 12, 100, playerAction) AND state eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 12, 100, playerAction) AND state eq 0`
- Marks the hit with ailment **Stop (12)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 12, 100, playerAction) AND state eq 0`

_Raw recovered data (every method item): [trees/SpriteSkill.md](../trees/SpriteSkill.md) — uid 716_

---

### ไมโครฮีล (ClineHeal) · uid 708

<img src="../../icons/sk_708.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 3) · **Type:** Support · **Max Lv:** 170 · **Weapons:** MainMagictool · **Requires:** เอ็กเพรสเอด · **Client class:** `ClineHealAction`

> แบ่งเบาทำให้สบายขึ้นเล็กน้อย
> 
> ฟื้นฟู HP ของตัวเองและ HP ของสมาชิกปาร์ตี้
> ที่สูญเสีย HP มากที่สุดเล็กน้อย

**How it works**

- Support skill of the スプライトスキル tree (tier 3, max Lv 170); usable with MainMagictool.
- It restores HP or MP.

**Cost, timing and range**

- **Cast time** (`CastTime`): `0` = 0
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionPreparation` — before the cast starts: 2 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 708
- No proration slot: ExpType None: no proration slot.

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `0` = 0
- **HP healed** (`hpHeal`): `int(((((Lv * 5) / 100) * status.Matk) + (Lv * 50)))`

_Raw recovered data (every method item): [trees/SpriteSkill.md](../trees/SpriteSkill.md) — uid 708_

---

### เอนฮานซ์ (Enhance) · uid 709

<img src="../../icons/sk_709.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 3) · **Type:** Support · **Max Lv:** 170 · **Weapons:** MainMagictool · **Requires:** เอ็กเพรสเอด · **Client class:** `EnhanceAction`

> ทักษะที่ช่วยเพิ่มความสามารถให้โดดเด่นยิ่งขึ้นไปอีก
> เพิ่มพลังโจมตีของสมาชิกในปาร์ตี้ที่มี ATK และ MATK สูงสุด(แต่ละคน)ความแรงที่เพิ่มจะเปลี่ยนไปตามมอนสเตอร์ที่เผชิญหน้า

**How it works**

- Support skill of the スプライトスキル tree (tier 3, max Lv 170); usable with MainMagictool.
- It installs a buff on the caster.
- It installs a buff on other players / the party.
- Its buff exposes motion / combo hooks, so it changes the attack pattern while active (heuristic; the client has no explicit flag).
- Buffs:
  - `EnhanceBuf`: lasts `((Lv * 10) + 20)` s; Lv1 → Lv10: LastDmgUpRate (final damage dealt %) 1 → 10
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)

**When each part runs**

- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `AddEnhanceBuf` — skill-specific method: 3 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 709
- No proration slot: ExpType None: no proration slot.

**Status ailments**

- Removes ailment **Enhance (251)** (`AddEnhanceBuf`)
  - when `UnityEngine.Object.op_Inequality(BattleMemberData.get_ActionManager(member), 0) AND member._isMine eq 0`

**Buffs and effects it installs or removes**

- `AddEnhanceBuf` (method): constructs `EnhanceBuf` — `.ctor(skillLv, type)`
  - when `UnityEngine.Object.op_Inequality(BattleMemberData.get_ActionManager(member), 0) AND member._isMine ne 0 OR !UnityEngine.Object.op_Inequality(BattleMemberData.get_ActionManager(member), 0) AND member._isMine ne 0 OR UnityEngine.Object.op_Inequality(BattleMemberData.get_ActionManager(member), 0) AND member._isMine eq 0`
- `AddEnhanceBuf` (method): adds a target's buff of `new EnhanceBuf` — `AddBuffer(new EnhanceBuf, 0)`
  - when `UnityEngine.Object.op_Inequality(BattleMemberData.get_ActionManager(member), 0) AND member._isMine ne 0`

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `AtkUp`: ATK +
- `LastDmgUpRate`: final damage dealt %
- `MatkUp`: MATK +

_Raw recovered data (every method item): [trees/SpriteSkill.md](../trees/SpriteSkill.md) — uid 709_

---

### แอสเทิลแลนซ์ (AstralLance) · uid 710

<img src="../../icons/sk_710.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 3) · **Type:** Special · **Max Lv:** 170 · **Weapons:** MainMagictool · **Requires:** เคาน์เตอร์ฟอร์ส · **Client class:** `AstralLanceAction`

> ทักษะการนำพลังเวทย์กลับมาใช้ใหม่อย่างมีประสิทธิภาพ
> 
> โจมตีโดยปล่อยหอกเวทมนตร์อันทรงพลังต่อทุก 500 MP ที่ใช้ไป
> เป็นเวลา 90 วินาที(สูงสุด 1 หอก)

**How it works**

- Special skill of the スプライトスキル tree (tier 3, max Lv 170); usable with MainMagictool.
- It installs a buff on the caster.
- Buffs:
  - `AstralLanceBuf`: lasts `(90 + EnhanceSprite.GetEnhanceParam(PlayerStatusBase.get_SkillManager().SkillMasteryList[719], AstralLanceBuf.get_SkillId()))` s / `90` s
  - `CountBufferBase`
- Other client code reads this skill (9 lookups; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 1 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 2 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 710
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `AstralLanceBuf` — `.ctor(Lv, actarAction)`
- `ActionHit` (when the attack connects): adds the caster's buff of `new AstralLanceBuf` — `AddSelfBuffer(new AstralLanceBuf, 0)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `Count`: stack / hit counter

**Where else this skill takes effect**

- Effect applied in `MobaPlayerBattleManager$$OnSkillActionStartSummonSkeleton` (40 guarded paths):
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
- Effect applied in `PlayerBattleManager$$OnSkillActionStartSummonSkeleton` (40 guarded paths):
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
- Effect applied in `MobaPlayerBattleManager$$OnSkillActionStart` (207 guarded paths, truncated):
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
- Effect applied in `PlayerBattleManager$$OnSkillActionStart` (273 guarded paths, truncated):
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
- Effect applied in `AstralLanceAttackAction$$OnEnd` (3 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 710, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `AstralLanceBuf.EndAstralLanceAttack(TryGetBuf.out2(), 0, ?x2, ?x3)`
    - calls `PlayerAttackBase$$OnEnd`, `AstralLanceBuf$$EndAstralLanceAttack`
  - when `(SkillBufferManager.TryGetBuf(?blr, 710, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `PlayerAttackBase$$OnEnd`, `0x165db84`, `0x165df00`
  - when `(SkillBufferManager.TryGetBuf(?blr, 710, stkp(-40), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 710, stkp(-40), 0)`
    - calls `PlayerAttackBase$$OnEnd`
- Effect applied in `AstralLanceAttackAction$$ActionStart` (3 guarded paths):
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
- Effect applied in `MobaPlayerBattleManager$$StartAstralLanceAttack` (4 guarded paths):
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
- Effect applied in `PlayerBattleManager$$StartAstralLanceAttack` (4 guarded paths):
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
- Code that reads this skill's level / buff by constant id: `AstralLanceAttackAction$$ActionStart (TryGetBuf)`, `AstralLanceAttackAction$$OnEnd (TryGetBuf)`, `MagicBalkanAction$$ActionSkillEvent (TryGetBuf)`, `MobaPlayerBattleManager$$OnSkillActionStart (TryGetBuf)`, `MobaPlayerBattleManager$$OnSkillActionStartSummonSkeleton (TryGetBuf)`, `MobaPlayerBattleManager$$StartAstralLanceAttack (GetSkillLv)`, `PlayerBattleManager$$OnSkillActionStart (TryGetBuf)`, `PlayerBattleManager$$OnSkillActionStartSummonSkeleton (TryGetBuf)`, `PlayerBattleManager$$StartAstralLanceAttack (GetSkillLv)`

_Raw recovered data (every method item): [trees/SpriteSkill.md](../trees/SpriteSkill.md) — uid 710_

---

### แฟกทิสอาร์ม (FacticeArme) · uid 717

<img src="../../icons/sk_717.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 3) · **Type:** Attack · **Max Lv:** 170 · **Weapons:** MainMagictool · **Requires:** อาร์เดดราค · **Client class:** `FacticeArmeAction`

> ใช้อาวุธที่สร้างจากพลังเวท
> 
> โจมตีเป้าหมายเดี่ยว
> พลังเพิ่มตาม AGI และ DEX ที่สูงขึ้น

**How it works**

- Attack skill of the スプライトスキル tree (tier 3, max Lv 170); usable with MainMagictool.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [type eq 3 OR type eq 0 AND type ne 3 OR type eq 4 AND type ne 0 AND type ne 3]: skill multiplier depends on Agi, Dex (formula below); flat damage +4.5 at Lv1 to 450 at Lv10
  - `calcPlayerToMobDamage` [type eq 0 AND type ne 3 OR type eq 4 AND type ne 0 AND type ne 3]: skill multiplier depends on Agi, Dex (formula below); flat damage +1.5 at Lv1 to 150 at Lv10
  - `calcPlayerToMobDamage` [type ne 0 AND type ne 3 AND type ne 4]: skill multiplier depends on Agi, Dex (formula below); flat damage +6 at Lv1 to 600 at Lv10
- Proration: magic proration slot, mode `first_hit_per_target`.
- Buffs:
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 6 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionStartOthers` — skill-specific method: 1 set
- `OtherPlayerSkillEventReceive` — skill-specific method: 1 set
- `ActionStart` — when the cast starts: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 6 tpl, 2 info
- `ActionSkillEventIfMoveIndex` — skill-specific method: 1 set
- `<CreateTake>b__29_0` — skill-specific method: 1 call
- `<CreateTake>b__29_1` — skill-specific method: 1 call
- `<CreateTake>b__29_2` — skill-specific method: 1 call
- `<CreateTake>b__29_3` — skill-specific method: 1 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + [type eq 3 OR type eq 0 AND type ne 3 OR type eq 4 AND type ne 0 AND type ne 3] | 4.5 | 18 | 40.5 | 72 | 112.5 | 162 | 220.5 | 288 | 364.5 | 450 |
| Flat dmg + [type eq 0 AND type ne 3 OR type eq 4 AND type ne 0 AND type ne 3] | 1.5 | 6 | 13.5 | 24 | 37.5 | 54 | 73.5 | 96 | 121.5 | 150 |
| Flat dmg + [type ne 0 AND type ne 3 AND type ne 4] | 6 | 24 | 54 | 96 | 150 | 216 | 294 | 384 | 486 | 600 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((status.Agi + status.Dex) + 750)) / 100) * 0.75)` — type eq 3 OR type eq 0 AND type ne 3 OR type eq 4 AND type ne 0 AND type ne 3
- SkillRate × `(((((status.Agi + status.Dex) + 750)) / 100) * 0.25)` — type eq 0 AND type ne 3 OR type eq 4 AND type ne 0 AND type ne 3
- SkillRate × `((((status.Agi + status.Dex) + 750)) / 100)` — type ne 0 AND type ne 3 AND type ne 4

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((status.Agi + status.Dex) + 750)) / 100) * 0.75)`
  - when `type eq 3 OR type eq 0 AND type ne 3 OR type eq 4 AND type ne 0 AND type ne 3`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((((Lv * Lv) + ((Lv * Lv) << 1)) << 1)) * 0.75)`
  - when `type eq 3 OR type eq 0 AND type ne 3 OR type eq 4 AND type ne 0 AND type ne 3`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((status.Agi + status.Dex) + 750)) / 100) * 0.25)`
  - when `type eq 0 AND type ne 3 OR type eq 4 AND type ne 0 AND type ne 3`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((((Lv * Lv) + ((Lv * Lv) << 1)) << 1)) * 0.25)`
  - when `type eq 0 AND type ne 3 OR type eq 4 AND type ne 0 AND type ne 3`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((status.Agi + status.Dex) + 750)) / 100)`
  - when `type ne 0 AND type ne 3 AND type ne 4`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `((((Lv * Lv) + ((Lv * Lv) << 1)) << 1))`
  - when `type ne 0 AND type ne 3 AND type ne 4`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 717
- Uses the magic proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `<CreateTake>b__29_0` (method): removes the caster's buff of skill 94 — `RemoveSelfBuffer(94)`
- `<CreateTake>b__29_1` (method): removes the caster's buff of skill 94 — `RemoveSelfBuffer(94)`
- `<CreateTake>b__29_2` (method): removes the caster's buff of skill 624 (IllusionaryScene) — `RemoveSelfBuffer(624)`
- `<CreateTake>b__29_3` (method): removes the caster's buff of skill 624 (IllusionaryScene) — `RemoveSelfBuffer(624)`
  - when `(cancel & 1) ne 0`

**Buff values** (every recovered field; durations in seconds)

**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:JumpbackShotProtectionBuf$$.ctor<-FacticeArmeAction$$CreateTake` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

_Raw recovered data (every method item): [trees/SpriteSkill.md](../trees/SpriteSkill.md) — uid 717_

---

### เรเซอร์เรคชั่น (Resurrection) · uid 711

<img src="../../icons/sk_711.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 4) · **Type:** Support · **Max Lv:** 250 · **Weapons:** MainMagictool · **Requires:** ไมโครฮีล · **Client class:** `ResurrectionAction`

> ทักษะการชุบชีวิตผู้ที่ไม่สามารถต่อสู้ได้อีกต่อไป
> เวลารอคืนชีพของคนรอบข้าง(ภายใน 16m)จะเป็น 0 วินาที
> 
> *ใช้ไม่ได้ถ้าไม่มีปฐมพยาบาล
> *ใช้กับคอมโบไม่ได้

**How it works**

- Support skill of the スプライトスキル tree (tier 4, max Lv 250); usable with MainMagictool.
- It is a utility / system action (movement, state change) rather than a damage or buff skill.

**Cost, timing and range**

- **Cast time** (`CastTime`): `((((ResurrectionAction.get_BaseMp() - PlayerAttackBase.CalcCostMp(this, actarAction)) // 100) * 0.5) + PlayerAttackBase.CalcCastTime(this, (10 - (Lv * 0.5)), PlayerActionManagerBase.get_PlayerStatus()))`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(16)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 711
- No proration slot: ExpType None: no proration slot.

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `((((ResurrectionAction.get_BaseMp() - PlayerAttackBase.CalcCostMp(this, actarAction)) // 100) * 0.5) + PlayerAttackBase.CalcCastTime(this, (10 - (Lv * 0.5)), PlayerActionManagerBase.get_PlayerStatus()))`

_Raw recovered data (every method item): [trees/SpriteSkill.md](../trees/SpriteSkill.md) — uid 711_

---

### สเตบิไลซ์ (Stabilis) · uid 712

<img src="../../icons/sk_712.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 4) · **Type:** Support · **Max Lv:** 250 · **Weapons:** MainMagictool · **Requires:** เอนฮานซ์ · **Client class:** `StabilisAction`

> ทักษะที่ช่วยเพิ่มความแม่นยำ
> เพิ่มอัตราคริติคอลและความเสถียรของความเสียหายจากเวท
> และลดความเสถียรตอน Graze เป็นเวลา 45 วินาที
> ลบ "เหนื่อยล้า" เมื่อใช้งาน

**How it works**

- Support skill of the スプライトスキル tree (tier 4, max Lv 250); usable with MainMagictool.
- It installs a buff on the caster.
- Buffs:
  - `StabilisBuf`: lasts `(0 + 45)` s; Lv1 → Lv10: Value (generic value (meaning set by the code that reads the buff)) 5 → 50, CrtUpRate (critical rate %) 4 → 40, Count (stack / hit counter) 1 → 10, CrtUp (critical rate +) 6 → 15
- Other client code reads this skill (7 lookups; see the last section).

**When each part runs**

- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 2 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 712
- No proration slot: ExpType None: no proration slot.

**Status ailments**

- Removes ailment **Tiredness (23)** (`ActionHit`)
  - when `AbnormalStateManager.Contains(PlayerActionManagerBase.get_AbnormalStatusManager(), 23) AND UnityEngine.Object.op_Inequality(actarAction)`

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): adds the caster's buff of skill 712 (Stabilis) — `AddSelfBuffer(712, Lv, 0)`
  - when `AbnormalStateManager.Contains(PlayerActionManagerBase.get_AbnormalStatusManager(), 23) AND UnityEngine.Object.op_Inequality(actarAction) OR !AbnormalStateManager.Contains(PlayerActionManagerBase.get_AbnormalStatusManager(), 23) AND UnityEngine.Object.op_Inequality(actarAction)`

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `Count`: stack / hit counter
- `CrtUp`: critical rate +
- `CrtUpRate`: critical rate %
- `Value`: generic value (meaning set by the code that reads the buff)

**Where else this skill takes effect**

- Effect applied in `PetStatus$$get_Critical` (66 guarded paths):
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
- Effect applied in `PlayerAttackBase$$CalcStable` (18 guarded paths):
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
- Effect applied in `PlayerSecondaryStatus$$GetCrtRate` (96 guarded paths):
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
- Effect applied in `MobaPlayerSecondaryStatus$$GetCrtRate` (96 guarded paths):
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
- Effect applied in `PetSkillActionBase$$CalcStable` (6 guarded paths):
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
- Code that reads this skill's level / buff by constant id: `MobaPlayerSecondaryStatus$$GetCrtConstant (TryGetBuf)`, `MobaPlayerSecondaryStatus$$GetCrtRate (TryGetBuf)`, `PetSkillActionBase$$CalcStable (TryGetBuf)`, `PetStatus$$get_Critical (TryGetBuf)`, `PlayerAttackBase$$CalcStable (TryGetBuf)`, `PlayerSecondaryStatus$$GetCrtConstant (TryGetBuf)`, `PlayerSecondaryStatus$$GetCrtRate (TryGetBuf)`

_Raw recovered data (every method item): [trees/SpriteSkill.md](../trees/SpriteSkill.md) — uid 712_

---

### สไปรท์ชีลด์ (SpriteShield) · uid 713

<img src="../../icons/sk_713.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 4) · **Type:** Buffer · **Max Lv:** 250 · **Weapons:** MainMagictool · **Requires:** เอนฮานซ์ · **Client class:** `SpriteShieldAction`

> ทักษะการเปลี่ยนพลังงานเป็นพลังเวท
> ใช้ HP เพื่อฟื้นฟู 100 MP ทันที
> ลดความเสียหายและโอกาสในการติด
> ภาวะผิดปกติที่โดนในครั้งต่อไป

**How it works**

- Buffer skill of the スプライトスキル tree (tier 4, max Lv 250); usable with MainMagictool.
- It installs a buff on the caster.
- Buffs:
  - `SoulHuntBuf`: marker buff (no parameters; other code tests whether it is present)
  - `SpriteShieldBuf`; Lv1 → Lv10: Value (generic value (meaning set by the code that reads the buff)) 1 → 100, MobLastDamageRateSupport (final damage multiplier vs monsters (support category)) 50 → 50
  - `CountBufferBase`
- Other client code reads this skill (6 lookups; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `CheckPayHp` — skill-specific method: 2 call
- `ActionHit` — when the attack connects: 1 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 713
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `CheckPayHp` (method): constructs `SoulHuntBuf` — `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1))`
  - when `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND consumptionHp ge 1 AND consumptionHp lt (PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp)`
- `CheckPayHp` (method): adds the caster's buff of `new SoulHuntBuf` — `AddSelfBuffer(new SoulHuntBuf, 0)`
  - when `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND consumptionHp ge 1 AND consumptionHp lt (PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp)`
- `ActionHit` (when the attack connects): adds the caster's buff of skill 713 (SpriteShield) — `AddSelfBuffer(713, Lv, Id)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`
- **HP consumed** (`consumptionHp`): `System.Math.Max(int(((status.MaxHp * (30 - (Lv << 1))) * 89129)), 100)`

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `Count`: stack / hit counter
- `MobLastDamageRateSupport`: final damage multiplier vs monsters (support category)
- `Value`: generic value (meaning set by the code that reads the buff)

**Where else this skill takes effect**

- Effect applied in `MobaPlayerSecondaryStatus$$get_AntiVirus` (26 guarded paths):
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
- Effect applied in `PlayerSecondaryStatus$$CalcAntiVirus` (26 guarded paths):
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
- Effect applied in `PlayerActionManager$$AddEventAbnormal` (8 guarded paths):
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
- Code that reads this skill's level / buff by constant id: `MobaPlayerActionManager$$Damaged (TryGetBuf)`, `MobaPlayerActionManager$$ReceiveDamaged (TryGetBuf)`, `MobaPlayerSecondaryStatus$$get_AntiVirus (TryGetBuf)`, `PlayerActionManager$$AddEventAbnormal (ContainsBuffer)`, `PlayerActionManager$$Damaged (TryGetBuf)`, `PlayerSecondaryStatus$$CalcAntiVirus (TryGetBuf)`

_Raw recovered data (every method item): [trees/SpriteSkill.md](../trees/SpriteSkill.md) — uid 713_

---

### เมจิกวัลแคน (MagicBalkan) · uid 714

<img src="../../icons/sk_714.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 4) · **Type:** Object · **Max Lv:** 250 · **Weapons:** MainMagictool · **Requires:** แอสเทิลแลนซ์ · **Client class:** `MagicBalkanAction`

> ทักษะปืนเวทมนตร์แบบหมุน
> สร้างความเสียหายเวทย์อย่างต่อเนื่องกับเป้าหมาย
> สามารถเพิ่มการใช้ MP เพื่อโจมตีต่อเนื่องแต่พลังจะค่อยๆ ลดลง
> การโจมตีนี้ไม่ทำให้เกิดความเคยชิน

**How it works**

- Object skill of the スプライトスキル tree (tier 4, max Lv 250); usable with MainMagictool.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- It places an object in the world (trap, summon or field object).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×0.55 at Lv1 to 1 at Lv10; flat damage +0
  - `calcPlayerToMobDamage` [(damageCount + 1) gt 4]: skill multiplier depends on live values (formula below); flat damage +100
  - `calcPlayerToMobDamage` [(damageCount + 1) le 4]: skill multiplier depends on live values (formula below)
- Proration: magic proration slot, mode `never (IsExpDefFluctuate=false)`.
- Buffs:
  - `MagicBalkanBuf`: marker buff (no parameters; other code tests whether it is present)
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)

**Cost, timing and range**

- **Cast time** (`CastTime`): `2` = 2
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 5 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionStart` — when the cast starts: 1 set, 2 call
- `CheckRangeHit` — range-hit test: 2 set
- `NextRangeHit` — next range-hit pass: 4 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 3 tpl, 1 info
- `CreateTake` — skill-specific method: 1 set
- `OnEnd` — when the action ends: 1 call
- `via PlayerAttackBase$$HitReactionAssign` — skill-specific method: 1 call, 2 tpl

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.55 | 0.6 | 0.65 | 0.7 | 0.75 | 0.8 | 0.85 | 0.9 | 0.95 | 1 |
| Flat dmg + | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 |
| Flat dmg + [(damageCount + 1) gt 4] | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((((Lv + (Lv << 2)) + 50)) / 100)` — (damageCount + 1) gt 4
- SkillRate × `((((Lv + (Lv << 2)) + 50)) / 100)` — (damageCount + 1) le 4

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv + (Lv << 2)) + 50)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetConstant[SkillConstantDamage]` = `(0)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetConstant[MinDamage]` = `1`
- `via PlayerAttackBase$$HitReactionAssign` (method): `SetCalcValue[GuardPower]` = `System.Math.Max(0, (25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4))))`
  - when `!MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType ne 2 AND comboType ne 3`
- `via PlayerAttackBase$$HitReactionAssign` (method): `SetCalcValue[GuardPower]` = `25`
  - when `!MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType ne 2 AND comboType ne 3`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `never (IsExpDefFluctuate=false)`, attack type `Magic`, action id 714
- Uses the magic proration slot but never changes monster proration: IsExpDefFluctuate=false.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `int(MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)))`
  - when `!PlayerAttackBase.IsBlank(this) AND PlayerStatusBase.CheckBodyAbility(PlayerActionManagerBase.get_PlayerStatus(), 2) OR !PlayerAttackBase.IsBlank(this) AND !PlayerStatusBase.CheckBodyAbility(PlayerActionManagerBase.get_PlayerStatus(), 2)`
- Number of damage events (`damageCount`): `(damageCount + 1)`

**Status ailments**

- Extra percent roll `CheckPercent` (`via PlayerAttackBase$$HitReactionAssign`)
  - when `!MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) eq 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3`

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): constructs `MagicBalkanBuf` — `.ctor(Lv)`
  - when `!PlayerAttackBase.IsBlank(this) AND PlayerStatusBase.CheckBodyAbility(PlayerActionManagerBase.get_PlayerStatus(), 2) OR !PlayerAttackBase.IsBlank(this) AND !PlayerStatusBase.CheckBodyAbility(PlayerActionManagerBase.get_PlayerStatus(), 2)`
- `ActionStart` (when the cast starts): adds the caster's buff of `new MagicBalkanBuf` — `AddSelfBuffer(new MagicBalkanBuf, Id)`
  - when `!PlayerAttackBase.IsBlank(this) AND PlayerStatusBase.CheckBodyAbility(PlayerActionManagerBase.get_PlayerStatus(), 2) OR !PlayerAttackBase.IsBlank(this) AND !PlayerStatusBase.CheckBodyAbility(PlayerActionManagerBase.get_PlayerStatus(), 2)`
- `OnEnd` (when the action ends): removes the caster's buff of skill 714 (MagicBalkan) — `RemoveSelfBuffer(714)`
  - when `IsInstanceOf(playerAction, PlayerActionManager) eq 1 OR IsInstanceOf(playerAction, MobaPlayerActionManager) eq 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `2` = 2
- **Loop / hit-repeat count** (`LoopParam`): `int(MobActionManagerBase.get_Size(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)))` _(when !PlayerAttackBase.IsBlank(this) AND PlayerStatusBase.CheckBodyAbility(PlayerActionManagerBase.get_PlayerStatus(), 2) OR !PlayerAttackBase.IsBlank(this) AND !PlayerStatusBase.CheckBodyAbility(PlayerActionManagerBase.get_PlayerStatus(), 2))_
- **Number of damage events** (`damageCount`): `(damageCount + 1)`

**Buff values** (every recovered field; durations in seconds)

**Buff `MagicBalkanBuf`**
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:MagicBalkanBuf$$.ctor<-MagicBalkanAction$$ActionStart` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

_Raw recovered data (every method item): [trees/SpriteSkill.md](../trees/SpriteSkill.md) — uid 714_

---

### สแลชรีปเปอร์ (SlashReaper) · uid 718

<img src="../../icons/sk_718.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 4) · **Type:** Object · **Max Lv:** 250 · **Weapons:** MainMagictool · **Requires:** แฟกทิสอาร์ม · **Client class:** `SlashReaperAction`

> ใช้ดาบเวทป้องกันตัวเองจากภัยคุกคามที่เข้ามาใกล้
> 
> หากตรงตามเงื่อนไขดาบเวทจะเพิ่มขึ้น(สูงสุด 99 ขีดจำกัดการใช้ 5)
> เมื่อใช้สกิลซ้ำอีกครั้งจะปล่อยดาบเวทที่ปรากฏ
> พุ่งเข้าโจมตีเป้าหมาย

**How it works**

- Object skill of the スプライトスキル tree (tier 4, max Lv 250); usable with MainMagictool.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It places an object in the world (trap, summon or field object).
- MP: `100`.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND IsOtherPlayer ne 0 AND param eq 2 OR IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND param eq 2 AND param ne 10 & state eq 2 AND state lo constDamage.Length AND state lo skillRate.Length OR state eq 2 AND state hs constDamage.Length AND state lo skillRate.Length OR state lo constDamage.Length AND state lo skillRate.Length AND state ne 2]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [(state - 1) hs 2 AND System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())) ge 1 OR !UnityEngine.Object.op_Equality(?stack) AND (state - 1) hs 2 AND System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())) ge 1 OR (state - 1) hs 2 AND System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())) ge 1 AND UnityEngine.Object.op_Equality(?stack) & state eq 2 AND state lo constDamage.Length AND state lo skillRate.Length OR state eq 2 AND state hs constDamage.Length AND state lo skillRate.Length OR state lo constDamage.Length AND state lo skillRate.Length AND state ne 2]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND IsOtherPlayer ne 0 AND param eq 2 OR IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND param eq 2 AND param ne 10 & state eq 2 AND state lo constDamage.Length AND state lo skillRate.Length OR state lo constDamage.Length AND state lo skillRate.Length AND state ne 2]: flat damage depends on live values (formula below)
  - `calcPlayerToMobDamage` [(state - 1) hs 2 AND System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())) ge 1 OR !UnityEngine.Object.op_Equality(?stack) AND (state - 1) hs 2 AND System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())) ge 1 OR (state - 1) hs 2 AND System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())) ge 1 AND UnityEngine.Object.op_Equality(?stack) & state eq 2 AND state lo constDamage.Length AND state lo skillRate.Length OR state lo constDamage.Length AND state lo skillRate.Length AND state ne 2]: flat damage depends on live values (formula below)
- Proration: magic proration slot, mode `custom_check + class check`.
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **MP cost** (`mp` in `OnInitialize`): `100` = 100
  - when `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 718) ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 718).BuffEffectActive ne 0 AND constDamage.Length hi 1 AND constDamage.Length hi 2 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(16)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 11 set
- `RemoveBrade` — skill-specific method: 1 set
- `AddBlade` — skill-specific method: 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `SetTargetMobOthers` — skill-specific method: 1 set
- `ActionPreparation` — before the cast starts: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 1 info
- `CheckRangeHit` — range-hit test: 2 set
- `ActionSkillReceiveEffect` — skill-specific method: 2 set
- `ActionSkillEvent` — on an animation/skill event during the motion: 1 set
- `OnSkillButton` — skill-specific method: 1 set
- `.DamageLogData::AddDamage` — skill-specific method: 2 set

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(skillRate[(2)] / 100)` — IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND IsOtherPlayer ne 0 AND param eq 2 OR IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND param eq 2 AND param ne 10 & state eq 2 AND state lo constDamage.Length AND state lo skillRate.Length OR state eq 2 AND state hs constDamage.Length AND state lo skillRate.Length OR state lo constDamage.Length AND state lo skillRate.Length AND state ne 2
- SkillRate × `(skillRate[(2)] / 100)` — (state - 1) hs 2 AND System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())) ge 1 OR !UnityEngine.Object.op_Equality(?stack) AND (state - 1) hs 2 AND System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())) ge 1 OR (state - 1) hs 2 AND System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())) ge 1 AND UnityEngine.Object.op_Equality(?stack) & state eq 2 AND state lo constDamage.Length AND state lo skillRate.Length OR state eq 2 AND state hs constDamage.Length AND state lo skillRate.Length OR state lo constDamage.Length AND state lo skillRate.Length AND state ne 2
- Flat dmg + `constDamage[(2)]` — IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND IsOtherPlayer ne 0 AND param eq 2 OR IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND param eq 2 AND param ne 10 & state eq 2 AND state lo constDamage.Length AND state lo skillRate.Length OR state lo constDamage.Length AND state lo skillRate.Length AND state ne 2
- Flat dmg + `constDamage[(2)]` — (state - 1) hs 2 AND System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())) ge 1 OR !UnityEngine.Object.op_Equality(?stack) AND (state - 1) hs 2 AND System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())) ge 1 OR (state - 1) hs 2 AND System.Collections.Generic.Dictionary<object, object>.get_Count(bladeTakeList, meta(0x39a9af8, Method$System.Collections.Generic.Dictionary<TakePlayer, Dictionary<Transform, float>>.get_Count())) ge 1 AND UnityEngine.Object.op_Equality(?stack) & state eq 2 AND state lo constDamage.Length AND state lo skillRate.Length OR state lo constDamage.Length AND state lo skillRate.Length AND state ne 2

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(skillRate[(2)] / 100)`
  - when `state eq 2 AND state lo constDamage.Length AND state lo skillRate.Length OR state eq 2 AND state hs constDamage.Length AND state lo skillRate.Length OR state lo constDamage.Length AND state lo skillRate.Length AND state ne 2`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `constDamage[(2)]`
  - when `state eq 2 AND state lo constDamage.Length AND state lo skillRate.Length OR state lo constDamage.Length AND state lo skillRate.Length AND state ne 2`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `custom_check + class check`, attack type `Magic`, action id 718
- Uses the magic proration slot; Proration change is decided by the skill's own check (`CheckExpDefFluctuate`).

**Other recovered parameters**

- **Magic resistance** (`magicResist`): `((Lv + (Lv << 2)) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100] _(when constDamage.Length hi 1 AND constDamage.Length hi 2 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0 OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 718) eq 0 AND constDamage.Length hi 1 AND constDamage.Length hi 2 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0 OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 718) ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 718).BuffEffectActive ne 0 AND constDamage.Length hi 1 AND constDamage.Length hi 2 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0)_
- **MP cost** (`mp`): `100` = 100 _(when TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 718) ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 718).BuffEffectActive ne 0 AND constDamage.Length hi 1 AND constDamage.Length hi 2 AND constDamage.Length ne 0 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0)_

**Where else this skill takes effect**

- Effect applied in `PlayerActionManager$$GetSkillTargetType` (4 guarded paths):
  - when `skillId gt 629` AND `skillId le 991` AND `skillId gt 707` AND `skillId eq 718`
    - returns `[MasterSkillDataManager.GetSkillMaster(Singleton<object>.get_Instance(meta(0x397a328, Method$Singleton<MasterSkillDataManager>.get_Instance()), ?x1, ?x2, ?x3), 718, 0, ?x3)+0x2c]`
    - calls `Singleton<object>$$get_Instance`, `MasterSkillDataManager$$GetSkillMaster`
  - when `skillId gt 629` AND `skillId le 991` AND `skillId gt 707` AND `skillId eq 718`
    - returns `1`
  - when `skillId gt 629` AND `skillId le 991` AND `skillId gt 707` AND `skillId eq 718`
    - calls `0x165db84`, `0x165df00`
  - when `skillId gt 629` AND `skillId le 991` AND `skillId gt 707` AND `skillId eq 718`
    - returns `1`
- Code that reads this skill's level / buff by constant id: `PlayerActionManager$$GetSkillTargetType (TryGetBuf)`

_Raw recovered data (every method item): [trees/SpriteSkill.md](../trees/SpriteSkill.md) — uid 718_

---

### สไปรท์อัพเกรด (EnhanceSprite) · uid 719

<img src="../../icons/sk_719.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 300 · **Weapons:** MainMagictool · **Requires:** สเตบิไลซ์ · **Client class:** `EnhanceSprite` (passive mastery)

> เพิ่มระยะเวลาต่อเนื่องของเคาน์เตอร์ฟอร์ส
> แอสเทิลแลนซ์ และสเตบิไลซ์

**How it works**

- Mastery skill of the スプライトスキル tree (tier 5, max Lv 300); usable with MainMagictool.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.

_Raw recovered data (every method item): [trees/SpriteSkill.md](../trees/SpriteSkill.md) — uid 719_

---

### รีเทค (Retake) · uid 720

<img src="../../icons/sk_720.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 300 · **Weapons:** MainMagictool · **Requires:** สไปรท์ชีลด์ · **Flags:** NoMarketSearch, CanNotUse · **Client class:** `Retake` (passive mastery)

> ได้รับสถานะรีเทคเมื่อเปลี่ยนแผนที่
> และจะแสดงผลเมื่อเริ่มต่อสู้กับศัตรูที่แข็งแกร่ง
> 
> ในระหว่างที่ผลของสกิลยังอยู่สามารถฟื้นคืนชีพ
> ได้ทันที 1 ครั้งและฟื้นฟู HP และ MP จนเต็ม

**How it works**

- Mastery skill of the スプライトスキル tree (tier 5, max Lv 300); usable with MainMagictool.
- It installs a buff on the caster.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Buffs:
  - `RetakeBuf`: lasts `((Lv + 2) * Lv)` s
- Other client code reads this skill (1 lookup; see the last section).

**Buff values** (every recovered field; durations in seconds)

**Buff `RetakeBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `((Lv + 2) * Lv)` s
- Buff fields set in the constructor (all recovered):
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `BufEffectTakeUid` = `-1` = -1
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

**Where else this skill takes effect**

- Code that reads this skill's level / buff by constant id: `PlayerActionManager$$Damaged (TryGetBuf)`

_Raw recovered data (every method item): [trees/SpriteSkill.md](../trees/SpriteSkill.md) — uid 720_

---

### คาตาลาโบมัส (Catarabomos) · uid 721

<img src="../../icons/sk_721.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 5) · **Type:** Attack · **Max Lv:** 300 · **Weapons:** MainMagictool · **Requires:** เมจิกวัลแคน · **Client class:** `CatarabomosAction`

> เวทมนตร์ที่กัดกินวิญญาณด้วยคำสาป
> 
> ทำให้เป้าหมายติด [คำสาป] ถ้าสำเร็จ
> จะเพิ่มผลพิเศษที่สร้างความเสียหายอย่างต่อเนื่อง
> ((พลังโจมตีจะลดลงเมื่อใช้กับบอส)

**How it works**

- Attack skill of the スプライトスキル tree (tier 5, max Lv 300); usable with MainMagictool.
- It is a utility / system action (movement, state change) rather than a damage or buff skill.
- Can inflict on the target: Curse (32).

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 call
- `AddAbnormalEffect` — skill-specific method: 1 call

**Proration:** slot `none`, mode `never (IsExpDefFluctuate=false)`, attack type `None`, action id 721
- No proration slot: IsExpDefFluctuate=false.

**Status ailments**

- Rolls `100`% to inflict **Curse (32)** (`calcPlayerToMobDamage`)

**Buffs and effects it installs or removes**

- `AddAbnormalEffect` (method): constructs `CatarabomosDebuff` — `.ctor(Toram.Common.ArchetypeUid.get_Id(stkp(-56)), skill.Level, status.Stable)`
  - when `abnormalType eq 32`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

_Raw recovered data (every method item): [trees/SpriteSkill.md](../trees/SpriteSkill.md) — uid 721_

---

### เลเบนส์กลานซ์ (LebenGlanz) · uid 722

<img src="../../icons/sk_722.png" width="40" alt="icon"> 
**Tree:** スプライトスキル (`SpriteSkill`, tier 5) · **Type:** Attack · **Max Lv:** 300 · **Weapons:** MainMagictool · **Requires:** สแลชรีปเปอร์ · **Client class:** `LebenGlanzAction`

> วิชาต้องห้ามที่จะย้อนกลับเวลาแห่งชีวิต
> ที่สูญหายไปให้กลายเป็นพลังระเบิด
> 
> ติด[ระเบิดพลีชีพ]ให้แก่เป้าหมาย
> เมื่อระยะเวลาแสดงผลสิ้นสุดลงจะระเบิดสร้างความเสียหาย

**How it works**

- Attack skill of the スプライトスキル tree (tier 5, max Lv 300); usable with MainMagictool.
- It installs a buff on the caster.
- Buffs:
  - `LebenGlanzBuf`
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 1 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 call
- `EndDebuffHpHeal` — skill-specific method: 1 call
- `ValidDebuff` — skill-specific method: 3 call
- `InvalidDebuff` — skill-specific method: 1 call

**Proration:** slot `none`, mode `never (IsExpDefFluctuate=false)`, attack type `None`, action id 722
- No proration slot: IsExpDefFluctuate=false.

**Buffs and effects it installs or removes**

- `calcPlayerToMobDamage` (damage calculation against a monster): constructs `LifeExplosionDebuff` — `.ctor(Lv)`
- `ValidDebuff` (method): constructs `LebenGlanzBuf` — `.ctor(LifeExplosionDebuff.GetAttackMpRecovery(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 17)))`
  - when `TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 17) ne 0`
- `ValidDebuff` (method): adds the caster's buff of `new LebenGlanzBuf` — `AddSelfBuffer(new LebenGlanzBuf, 0)`
- `ValidDebuff` (method): constructs `LebenGlanzBuf` — `.ctor(0)`
- `InvalidDebuff` (method): removes the caster's buff of skill 722 (LebenGlanz) — `RemoveSelfBuffer(722)`

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `AttackMprecoveryUp`: MP recovered per attack (flat)

**In-game level notes**

- Lv15: ดีบัฟ[ระเบิดพลีชีพ]  เมื่อโจมตีเป้าหมายที่ติดดีบัฟนี้สมาชิกในปาร์ตี้จะฟื้นฟู MP การโจมตี และจะสะสม MP ส่วนหนึ่งที่ใช้ระหว่างการโจมตี  เมื่อระเบิดจะสร้างความเสียหายตาม MP ที่สะสม และฟื้นฟู HP ให้กับสมาชิกปาร์ตี้ที่อยู่ใกล้เคียง

_Raw recovered data (every method item): [trees/SpriteSkill.md](../trees/SpriteSkill.md) — uid 722_

---
