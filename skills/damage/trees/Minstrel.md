# ミンストレル (`Minstrel`)

10 entries. See ../README.md for how to read these blocks.

### บทเพลงแห่งการเยียวยา (HealingSong) · uid 769

<img src="../../icons/sk_769.png" width="40" alt="icon"> 
**Tree:** ミンストレル (`Minstrel`, tier 1) · **Type:** Circle · **Max Lv:** 1 · **Weapons:** TwoHandSword, Bow, Bowgun, Rod, Magictool, Katana · **Flags:** NoMarketSearch · **Client class:** `HealingSongAction`

> การพักผ่อนของนักเดินทาง
> เพิ่มค่าประสบการณ์ที่ได้รับและเพิ่มพลังการฟื้นฟู
> อย่างเป็นธรรมชาติตอนไม่ได้ต่อสู้
> ฟื้นฟู HP และ MP เพิ่มเติมเมื่อจบการต่อสู้
> โดยขึ้นอยู่กับเวลาที่ใช้ในการต่อสู้

<details><summary>In-game level notes</summary>

- Lv255: [บัฟเพลง] เมื่อใช้สกิลเพลงต่อเนื่องถึงระยะเวลาหนึ่ง สกิลเพลงนั้นจะเปลี่ยนเป็นบัฟเพลง(ผลถาวร)  ยิ่งจำนวนเพลงที่เปลี่ยนเป็นบัฟเพลงเพิ่มขึ้นเท่าใด MP ที่ใช้ในการร่ายสกิลเพลง และเวลาที่ต้องใช้ในการ เปลี่ยนเพลงถัดไปให้เป็นบัฟเพลงก็จะเพิ่มขึ้นเท่านั้น

</details>

**Role:** buff (self) · circle / song area

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 769

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `song_buff_lv` = `SongActionBase.CalcBaseCostMp(this, PlayerActionManagerBase.get_PlayerStatus())`

</details>

**Buffs**

**Buff `HealingSongBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `CreateOtherBuf`, `CreateSelfBuf`, `get_EmotionType`
- `HpRecoveryRate` = `guitaristSavingTime` _(when BuffEffectActive ne 0)_
- `MpRecoveryRate` = `ValidSongBuffLvUp` _(when BuffEffectActive ne 0)_
- `Value` = `UseArcheTypeId` _(when BuffEffectActive ne 0)_
- Buff fields set in the constructor (all recovered):
  - `naturalHpRecoveryRate` = `(Lv * 10)` = 10
  - `naturalMpRecoveryRate` = `(Lv * 5)` = 5
  - `expBonus` = `((mLv // 10) + lv)`
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
**Buff `SongBufferBase`**
- Attached to this skill via `caller2:HealingSongBuf$$CreateSelfBuf<-HealingSongAction$$EffectiveSongBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `UpdateMotionSwitch`, `get_ArchetypeId`, `get_IsSendSupport`, `get_IsSensory`, `get_IsSuspendSong`, `get_SkillLocalId`, `set_ArchetypeId`, `set_IsSendSupport`, `set_IsSensory`, `set_IsSuspendSong`, `set_SkillLocalId`
- Buff fields set in the constructor (all recovered):
  - `suspendedTimer` = `-1` = -1
  - `playTakeUid` = `-1` = -1
  - `isChangeSongMotion` = `1` = 1
  - `sendSupportTimer` = `1` = 1
  - `partyMemberNum` = `1` = 1
  - `actorAction` = `actorAction`
  - `ArchetypeId` = `archetypeId`
  - `SkillLocalId` = `skillLocalId`
  - `BuffEffectActive` = `0`
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `takeController` = `actorAction.TakeController` when UnityEngine.Object.op_Inequality(actorAction)
- Hook `set_IsSensory`: `IsSensory`=(value & 1)
- Hook `set_IsSuspendSong`: `IsSuspendSong`=(value & 1)
- Hook `set_ArchetypeId`: `ArchetypeId`=value
- Hook `set_SkillLocalId`: `SkillLocalId`=value
- Hook `set_IsSendSupport`: `IsSendSupport`=(value & 1)
- Hook `UpdateMotionSwitch`: `isChangeSongMotion`=(PlayerActionManagerBase.get_IsBattleActive(actorAction) & 1); `isChangeSongMotion`=1; `suspendedTimer`=10; `IsSuspendSong`=1

<details><summary>Effect applied in `GameManager$$PlayerSkillUpdate` (29 guarded paths)</summary>

- when `TryGetExSkillData<object>.out2() ne 0`
  - returns `ElementReach.ResetShootSkill(PlayerDataManager.get_PlayerStatus(playerManager, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - calls `PlayerDataManager$$UpdateSkillList`, `GameManager$$PlayerPrimaryStatusUpdate`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillCallGolem$$PointReset`, `PlayerDataManager$$get_SkillManager`
- when `TryGetExSkillData<object>.out2() ne 0`
  - returns `SkillLv(83)`
  - calls `PlayerDataManager$$UpdateSkillList`, `GameManager$$PlayerPrimaryStatusUpdate`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillCallGolem$$PointReset`, `PlayerDataManager$$get_SkillManager`
- when `TryGetExSkillData<object>.out2() ne 0`
  - returns `ElementReach.ResetShootSkill(PlayerDataManager.get_PlayerStatus(playerManager, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - calls `PlayerDataManager$$UpdateSkillList`, `GameManager$$PlayerPrimaryStatusUpdate`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillCallGolem$$PointReset`, `PlayerDataManager$$get_SkillManager`
- when `TryGetExSkillData<object>.out2() ne 0`
  - returns `ElementReach.ResetShootSkill(PlayerDataManager.get_PlayerStatus(playerManager, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - calls `PlayerDataManager$$UpdateSkillList`, `GameManager$$PlayerPrimaryStatusUpdate`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillCallGolem$$PointReset`, `PlayerDataManager$$get_SkillManager`
- when `TryGetExSkillData<object>.out2() ne 0`
  - returns `SkillLv(83)`
  - calls `PlayerDataManager$$UpdateSkillList`, `GameManager$$PlayerPrimaryStatusUpdate`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillCallGolem$$PointReset`, `PlayerDataManager$$get_SkillManager`
- when `TryGetExSkillData<object>.out2() ne 0`
  - returns `ElementReach.ResetShootSkill(PlayerDataManager.get_PlayerStatus(playerManager, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - calls `PlayerDataManager$$UpdateSkillList`, `GameManager$$PlayerPrimaryStatusUpdate`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillCallGolem$$PointReset`, `PlayerDataManager$$get_SkillManager`
- when `TryGetExSkillData<object>.out2() ne 0`
  - returns `ElementReach.ResetShootSkill(PlayerDataManager.get_PlayerStatus(playerManager, 0, ?x2, ?x3), 0, ?x2, ?x3)`
  - calls `PlayerDataManager$$UpdateSkillList`, `GameManager$$PlayerPrimaryStatusUpdate`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillCallGolem$$PointReset`, `PlayerDataManager$$get_SkillManager`
- when `TryGetExSkillData<object>.out2() ne 0`
  - returns `SkillLv(83)`
  - calls `PlayerDataManager$$UpdateSkillList`, `GameManager$$PlayerPrimaryStatusUpdate`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillCallGolem$$PointReset`, `PlayerDataManager$$get_SkillManager`

</details>

<details><summary>Effect applied in `PlayerSecondaryStatus$$CalcHpRecovery` (10 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 226, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(isBattle & 1) eq 0` AND `TryGetValue.out2() ne 0`
  - returns `((System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey([CharacterActionManagerBase.get_IsValid()+0x40], 1064, meta(0x3974488, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.ContainsKey()), ?x3) & 1) ne 0 ? 0 : (int((CharacterActionManagerBase.get_Size() + ((((CharacterActionManagerBase.get_Size() / 100) + 1) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), (((PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) lt 0x1869f ? PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) : 0x1869f) // 25) + 10), 35, 34)))) + CharacterActionManagerBase.set_DefaultMoveSpeed()))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 226, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(isBattle & 1) eq 0` AND `TryGetValue.out2() ne 0`
  - returns `((System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey([CharacterActionManagerBase.get_IsValid()+0x40], 1064, meta(0x3974488, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.ContainsKey()), ?x3) & 1) ne 0 ? 0 : (int((CharacterActionManagerBase.get_Size() + (((CharacterActionManagerBase.get_Size() / 100) + 1) * BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), (((PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) lt 0x1869f ? PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) : 0x1869f) // 25) + 10), 35, 34)))) + CharacterActionManagerBase.set_DefaultMoveSpeed()))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 226, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(isBattle & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 769, stkp(-40), 0) & 1) ne 0`
  - returns `((System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey([CharacterActionManagerBase.get_IsValid()+0x40], 1064, meta(0x3974488, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.ContainsKey()), ?x3) & 1) ne 0 ? 0 : (int(((1 + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), (((PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) lt 0x1869f ? PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) : 0x1869f) // 25) + 10), 35, 34))) + CharacterActionManagerBase.set_DefaultMoveSpeed()))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 226, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(isBattle & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 769, stkp(-40), 0) & 1) eq 0`
  - returns `((System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey([CharacterActionManagerBase.get_IsValid()+0x40], 1064, meta(0x3974488, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.ContainsKey()), ?x3) & 1) ne 0 ? 0 : (int(BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), (((PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) lt 0x1869f ? PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) : 0x1869f) // 25) + 10), 35, 34)) + CharacterActionManagerBase.set_DefaultMoveSpeed()))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsValid`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 226, stkp(-40), 0) & 1) eq 0` AND `(isBattle & 1) eq 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 769, stkp(-40), 0) & 1) ne 0`
  - returns `((System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey([CharacterActionManagerBase.get_IsValid()+0x40], 1064, meta(0x3974488, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.ContainsKey()), ?x3) & 1) ne 0 ? 0 : int((CharacterActionManagerBase.get_Size() + ((((CharacterActionManagerBase.get_Size() / 100) + 1) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), (((PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) lt 0x1869f ? PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) : 0x1869f) // 25) + 10), 35, 34)))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 226, stkp(-40), 0) & 1) eq 0` AND `(isBattle & 1) eq 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 769, stkp(-40), 0) & 1) ne 0`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 226, stkp(-40), 0) & 1) eq 0` AND `(isBattle & 1) eq 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 769, stkp(-40), 0) & 1) eq 0`
  - returns `((System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey([CharacterActionManagerBase.get_IsValid()+0x40], 1064, meta(0x3974488, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.ContainsKey()), ?x3) & 1) ne 0 ? 0 : int((CharacterActionManagerBase.get_Size() + (((CharacterActionManagerBase.get_Size() / 100) + 1) * BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), (((PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) lt 0x1869f ? PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) : 0x1869f) // 25) + 10), 35, 34)))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 226, stkp(-40), 0) & 1) eq 0` AND `(isBattle & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 769, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `((System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey([CharacterActionManagerBase.get_IsValid()+0x40], 1064, meta(0x3974488, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.ContainsKey()), ?x3) & 1) ne 0 ? 0 : int(((1 + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), (((PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) lt 0x1869f ? PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) : 0x1869f) // 25) + 10), 35, 34))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`

</details>

<details><summary>Effect applied in `PlayerSecondaryStatus$$CalcMpRecovery` (18 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 227, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(isBattle & 1) eq 0` AND `TryGetValue.out2() ne 0`
  - returns `(int((CharacterActionManagerBase.get_Size() + (((((CharacterActionManagerBase.get_Size() / 100) + 1) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), ((max((PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) lt 2000 ? PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) : 2000), 0) // 100) + 1), 37, 36)))) + CharacterActionManagerBase.set_DefaultMoveSpeed())`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 227, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(isBattle & 1) eq 0` AND `TryGetValue.out2() ne 0`
  - returns `(int((CharacterActionManagerBase.get_Size() + ((((CharacterActionManagerBase.get_Size() / 100) + 1) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), ((max((PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) lt 2000 ? PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) : 2000), 0) // 100) + 1), 37, 36)))) + CharacterActionManagerBase.set_DefaultMoveSpeed())`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 227, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(isBattle & 1) eq 0` AND `TryGetValue.out2() ne 0`
  - returns `(int((CharacterActionManagerBase.get_Size() + ((((CharacterActionManagerBase.get_Size() / 100) + 1) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), ((max((PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) lt 2000 ? PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) : 2000), 0) // 100) + 1), 37, 36)))) + CharacterActionManagerBase.set_DefaultMoveSpeed())`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 227, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(isBattle & 1) eq 0` AND `TryGetValue.out2() ne 0`
  - returns `(int((CharacterActionManagerBase.get_Size() + (((CharacterActionManagerBase.get_Size() / 100) + 1) * BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), ((max((PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) lt 2000 ? PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) : 2000), 0) // 100) + 1), 37, 36)))) + CharacterActionManagerBase.set_DefaultMoveSpeed())`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 227, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(isBattle & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 232, stkp(-40), 0) & 1) ne 0`
  - returns `(int((((1 + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), ((max((PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) lt 2000 ? PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) : 2000), 0) // 100) + 1), 37, 36))) + CharacterActionManagerBase.set_DefaultMoveSpeed())`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 227, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(isBattle & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 232, stkp(-40), 0) & 1) ne 0`
  - returns `(int(((1 + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), ((max((PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) lt 2000 ? PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) : 2000), 0) // 100) + 1), 37, 36))) + CharacterActionManagerBase.set_DefaultMoveSpeed())`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 227, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(isBattle & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 232, stkp(-40), 0) & 1) eq 0`
  - returns `(int(((1 + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), ((max((PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) lt 2000 ? PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) : 2000), 0) // 100) + 1), 37, 36))) + CharacterActionManagerBase.set_DefaultMoveSpeed())`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsValid`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 227, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(isBattle & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 232, stkp(-40), 0) & 1) eq 0`
  - returns `(int(BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), ((max((PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) lt 2000 ? PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) : 2000), 0) // 100) + 1), 37, 36)) + CharacterActionManagerBase.set_DefaultMoveSpeed())`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsValid`

</details>

<details><summary>Effect applied in `MobaPlayerSecondaryStatus$$get_HpRecovery` (3 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 769, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `int((((CharacterActionManagerBase.set_DefaultMoveSpeed() / 100) + 1) * BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), ((MobaPlayerSecondaryStatus.get_MaxHp(this, ?mi, ?x2, ?x3) // 25) + 10), 35, 34)))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `MobaPlayerSecondaryStatus$$get_MaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 769, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `MobaPlayerSecondaryStatus$$get_MaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 769, stkp(-24), 0) & 1) eq 0`
  - returns `BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), ((MobaPlayerSecondaryStatus.get_MaxHp(this, ?mi, ?x2, ?x3) // 25) + 10), 35, 34)`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `MobaPlayerSecondaryStatus$$get_MaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`

</details>

<details><summary>Effect applied in `MobaPlayerSecondaryStatus$$get_MpRecovery` (3 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 769, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `int((((CharacterActionManagerBase.set_DefaultMoveSpeed() / 100) + 1) * BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), ((MobaPlayerSecondaryStatus.get_MaxMp(this, ?mi, ?x2, ?x3) // 100) + 1), 37, 36)))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `MobaPlayerSecondaryStatus$$get_MaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 769, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `MobaPlayerSecondaryStatus$$get_MaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 769, stkp(-24), 0) & 1) eq 0`
  - returns `BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), ((MobaPlayerSecondaryStatus.get_MaxMp(this, ?mi, ?x2, ?x3) // 100) + 1), 37, 36)`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `MobaPlayerSecondaryStatus$$get_MaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`

</details>

<details><summary>Effect applied in `PetStatus$$get_HpRecovery` (2 guarded paths)</summary>

- always
  - returns `int((((CharacterActionManagerBase.set_DefaultMoveSpeed() / 100) + 1) * BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), ((PetStatus.get_MaxHp(this, ?mi, ?x2, ?x3) // 25) + 10), 35, 34)))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PetStatus$$get_MaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBuffer`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- always
  - returns `BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), ((PetStatus.get_MaxHp(this, ?mi, ?x2, ?x3) // 25) + 10), 35, 34)`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PetStatus$$get_MaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`

</details>

<details><summary>Effect applied in `PetStatus$$get_MpRecovery` (5 guarded paths)</summary>

- always
  - returns `int((((CharacterActionManagerBase.set_DefaultMoveSpeed() / 100) + 1) * BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), ((PetStatus.get_MaxMp(this, ?mi, ?x2, ?x3) // 100) + 1), 37, 36)))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PetStatus$$get_MaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBuffer`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `0x165d9d4`
- always
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PetStatus$$get_MaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBuffer`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `0x165d9d4`
- always
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PetStatus$$get_MaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBuffer`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `0x165d9d4`
- always
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PetStatus$$get_MaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBuffer`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `0x165d9d4`
- always
  - returns `BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), ((PetStatus.get_MaxMp(this, ?mi, ?x2, ?x3) // 100) + 1), 37, 36)`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PetStatus$$get_MaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`

</details>

<details><summary>Effect applied in `PlayerSecondaryStatus$$GetExpBonus` (18 guarded paths)</summary>

- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 769, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `guildStatusBoostType ne 1`
  - returns `(BonusManager.GetGuildFacilityExpBonus(CharacterActionManagerBase.get_MoveSpeed(), 63, 0, ?x3) + (GuildManager.GetBoosterRate(PlayerDataManager.get_GuildManager(PlayerDataManager.GetPlayerDataManager(GameManager.get_AccountLevel(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3), ?x1, ?x2, ?x3), ?x1, ?x2, ?x3), guildStatusBoostType, 0, ?x3) + ((GemCartBufferManager.ContainsBuffer(?blr, 26, 0, ?x3) & 1) ne 0 ? ((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 63, 0, ?x3))) + 10) : (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 63, 0, ?x3))))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`, `Singleton<object>$$get_Instance`, `GameManager$$get_AccountLevel`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 769, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `guildStatusBoostType ne 1`
  - returns `(BonusManager.GetGuildFacilityExpBonus(CharacterActionManagerBase.get_MoveSpeed(), 63, 0, ?x3) + ((GemCartBufferManager.ContainsBuffer(?blr, 26, 0, ?x3) & 1) ne 0 ? ((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 63, 0, ?x3))) + 10) : (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 63, 0, ?x3)))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`, `Singleton<object>$$get_Instance`, `GameManager$$get_AccountLevel`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 769, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `guildStatusBoostType ne 1`
  - returns `(BonusManager.GetGuildFacilityExpBonus(CharacterActionManagerBase.get_MoveSpeed(), 63, 0, ?x3) + ((GemCartBufferManager.ContainsBuffer(?blr, 26, 0, ?x3) & 1) ne 0 ? ((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 63, 0, ?x3))) + 10) : (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 63, 0, ?x3)))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetGuildFacilityExpBonus`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 769, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `guildStatusBoostType eq 1`
  - returns `(BonusManager.GetGuildFacilityExpBonus(CharacterActionManagerBase.get_MoveSpeed(), 63, 0, ?x3) + (GuildManager.GetBoosterRate(PlayerDataManager.get_GuildManager(PlayerDataManager.GetPlayerDataManager(GemCartBufferManager.ContainsBuffer(?blr, 26, 0, ?x3), ?x1, ?x2, ?x3), ?x1, ?x2, ?x3), guildStatusBoostType, 0, ?x3) + ((GemCartBufferManager.ContainsBuffer(?blr, 26, 0, ?x3) & 1) ne 0 ? ((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 63, 0, ?x3))) + 10) : (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 63, 0, ?x3))))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_GuildManager`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 769, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `0x165db84`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 769, stkp(-40), 0) & 1) eq 0` AND `guildStatusBoostType ne 1` AND `guildStatusBoostType eq 4`
  - returns `(BonusManager.GetGuildFacilityExpBonus(CharacterActionManagerBase.get_MoveSpeed(), 63, 0, ?x3) + (GuildManager.GetBoosterRate(PlayerDataManager.get_GuildManager(PlayerDataManager.GetPlayerDataManager(GameManager.get_AccountLevel(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3), ?x1, ?x2, ?x3), ?x1, ?x2, ?x3), guildStatusBoostType, 0, ?x3) + ((GemCartBufferManager.ContainsBuffer(?blr, 26, 0, ?x3) & 1) ne 0 ? ((CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 63, 0, ?x3)) + 10) : (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 63, 0, ?x3)))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `Singleton<object>$$get_Instance`, `GameManager$$get_AccountLevel`, `PlayerDataManager$$GetPlayerDataManager`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 769, stkp(-40), 0) & 1) eq 0` AND `guildStatusBoostType ne 1` AND `guildStatusBoostType eq 4`
  - returns `(BonusManager.GetGuildFacilityExpBonus(CharacterActionManagerBase.get_MoveSpeed(), 63, 0, ?x3) + ((GemCartBufferManager.ContainsBuffer(?blr, 26, 0, ?x3) & 1) ne 0 ? ((CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 63, 0, ?x3)) + 10) : (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 63, 0, ?x3))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `Singleton<object>$$get_Instance`, `GameManager$$get_AccountLevel`, `virtual CharacterActionManagerBase.get_MoveSpeed`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 769, stkp(-40), 0) & 1) eq 0` AND `guildStatusBoostType ne 1` AND `guildStatusBoostType ne 4`
  - returns `(BonusManager.GetGuildFacilityExpBonus(CharacterActionManagerBase.get_MoveSpeed(), 63, 0, ?x3) + ((GemCartBufferManager.ContainsBuffer(?blr, 26, 0, ?x3) & 1) ne 0 ? ((CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 63, 0, ?x3)) + 10) : (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 63, 0, ?x3))))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetGuildFacilityExpBonus`

</details>

<details><summary>Effect applied in `SetlistAction$$GetSkillId` (22 guarded paths)</summary>

- when `TryGetExSkillData<object>.out2() ne 0` AND `(SkillBufferManager.TryGetBuf<object>(CharacterActionManagerBase.get_IsValid(), ?idx, stkp(-72), meta(0x39a89f8, Method$SkillBufferManager.TryGetBuf<SongBufferBase>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
  - returns `0xffffffff`
  - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillSetlist$$GetValidSongSkillIds`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_IsValid`
- when `TryGetExSkillData<object>.out2() ne 0` AND `(SkillBufferManager.TryGetBuf<object>(CharacterActionManagerBase.get_IsValid(), ?idx, stkp(-72), meta(0x39a89f8, Method$SkillBufferManager.TryGetBuf<SongBufferBase>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
  - returns `0xffffffff`
  - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillSetlist$$GetValidSongSkillIds`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_IsValid`, `PlayerDataManager$$get_PlayerStatus`
- when `TryGetExSkillData<object>.out2() ne 0` AND `(SkillBufferManager.TryGetBuf<object>(CharacterActionManagerBase.get_IsValid(), ?idx, stkp(-72), meta(0x39a89f8, Method$SkillBufferManager.TryGetBuf<SongBufferBase>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
  - returns `0xffffffff`
  - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillSetlist$$GetValidSongSkillIds`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_IsValid`, `PlayerDataManager$$get_PlayerStatus`
- when `TryGetExSkillData<object>.out2() ne 0` AND `(SkillBufferManager.TryGetBuf<object>(CharacterActionManagerBase.get_IsValid(), ?idx, stkp(-72), meta(0x39a89f8, Method$SkillBufferManager.TryGetBuf<SongBufferBase>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
  - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillSetlist$$GetValidSongSkillIds`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_IsValid`, `PlayerDataManager$$get_PlayerStatus`
- when `TryGetExSkillData<object>.out2() ne 0` AND `(SkillBufferManager.TryGetBuf<object>(CharacterActionManagerBase.get_IsValid(), ?idx, stkp(-72), meta(0x39a89f8, Method$SkillBufferManager.TryGetBuf<SongBufferBase>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
  - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillSetlist$$GetValidSongSkillIds`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_IsValid`, `PlayerDataManager$$get_PlayerStatus`
- when `TryGetExSkillData<object>.out2() ne 0` AND `(SkillBufferManager.TryGetBuf<object>(CharacterActionManagerBase.get_IsValid(), ?idx, stkp(-72), meta(0x39a89f8, Method$SkillBufferManager.TryGetBuf<SongBufferBase>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
  - returns `[(ExSkillSetlist.GetValidSongSkillIds(TryGetExSkillData<object>.out2(), 0, ?x2, ?x3) + 8)+0x20]`
  - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillSetlist$$GetValidSongSkillIds`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_IsValid`, `PlayerDataManager$$get_PlayerStatus`
- when `TryGetExSkillData<object>.out2() ne 0` AND `(SkillBufferManager.TryGetBuf<object>(CharacterActionManagerBase.get_IsValid(), ?idx, stkp(-72), meta(0x39a89f8, Method$SkillBufferManager.TryGetBuf<SongBufferBase>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
  - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillSetlist$$GetValidSongSkillIds`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_IsValid`, `PlayerDataManager$$get_PlayerStatus`
- when `TryGetExSkillData<object>.out2() ne 0` AND `(SkillBufferManager.TryGetBuf<object>(CharacterActionManagerBase.get_IsValid(), ?idx, stkp(-72), meta(0x39a89f8, Method$SkillBufferManager.TryGetBuf<SongBufferBase>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
  - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillSetlist$$GetValidSongSkillIds`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_IsValid`, `PlayerDataManager$$get_PlayerStatus`

</details>

<details><summary>Effect applied in `ShortcutManager$$ShortcutChatPanelOpen` (142 guarded paths, truncated)</summary>

- always
  - calls `UnityEngine.Resources$$Load`, `UnityEngine.Object$$Instantiate`, `UnityEngine.GameObject$$get_transform`, `Singleton<object>$$get_Instance`, `UnityEngine.Transform$$set_parent`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$set_localScale`, `UnityEngine.GameObject$$GetComponent<object>`
- always
  - calls `UnityEngine.Resources$$Load`, `UnityEngine.Object$$Instantiate`, `UnityEngine.GameObject$$get_transform`, `Singleton<object>$$get_Instance`, `UnityEngine.Transform$$set_parent`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$set_localScale`, `UnityEngine.GameObject$$GetComponent<object>`
- always
  - calls `UnityEngine.Resources$$Load`, `UnityEngine.Object$$Instantiate`, `UnityEngine.GameObject$$get_transform`, `Singleton<object>$$get_Instance`, `UnityEngine.Transform$$set_parent`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$set_localScale`, `UnityEngine.GameObject$$GetComponent<object>`
- always
  - calls `UnityEngine.Resources$$Load`, `UnityEngine.Object$$Instantiate`, `UnityEngine.GameObject$$get_transform`, `Singleton<object>$$get_Instance`, `UnityEngine.Transform$$set_parent`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$set_localScale`, `UnityEngine.GameObject$$GetComponent<object>`
- always
  - calls `UnityEngine.Resources$$Load`, `UnityEngine.Object$$Instantiate`, `UnityEngine.GameObject$$get_transform`, `Singleton<object>$$get_Instance`, `UnityEngine.Transform$$set_parent`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$set_localScale`, `UnityEngine.GameObject$$GetComponent<object>`
- always
  - calls `UnityEngine.Resources$$Load`, `UnityEngine.Object$$Instantiate`, `UnityEngine.GameObject$$get_transform`, `Singleton<object>$$get_Instance`, `UnityEngine.Transform$$set_parent`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$set_localScale`, `UnityEngine.GameObject$$GetComponent<object>`
- always
  - calls `UnityEngine.Resources$$Load`, `UnityEngine.Object$$Instantiate`, `UnityEngine.GameObject$$get_transform`, `Singleton<object>$$get_Instance`, `UnityEngine.Transform$$set_parent`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$set_localScale`, `UnityEngine.GameObject$$GetComponent<object>`
- always
  - calls `UnityEngine.Resources$$Load`, `UnityEngine.Object$$Instantiate`, `UnityEngine.GameObject$$get_transform`, `Singleton<object>$$get_Instance`, `UnityEngine.Transform$$set_parent`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$set_localScale`, `UnityEngine.GameObject$$GetComponent<object>`

</details>

<details><summary>Effect applied in `ShortcutManager$$ShortcutChatTargetOpen` (92 guarded paths, truncated)</summary>

- always
  - calls `PlayerDataManager$$get_IsGMEventPlayer`, `UnityEngine.Resources$$Load`, `UnityEngine.Object$$Instantiate`, `UnityEngine.GameObject$$get_transform`, `Singleton<object>$$get_Instance`, `UnityEngine.Transform$$set_parent`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$set_localScale`
- always
  - calls `PlayerDataManager$$get_IsGMEventPlayer`, `UnityEngine.Resources$$Load`, `UnityEngine.Object$$Instantiate`, `UnityEngine.GameObject$$get_transform`, `Singleton<object>$$get_Instance`, `UnityEngine.Transform$$set_parent`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$set_localScale`
- always
  - calls `PlayerDataManager$$get_IsGMEventPlayer`, `UnityEngine.Resources$$Load`, `UnityEngine.Object$$Instantiate`, `UnityEngine.GameObject$$get_transform`, `Singleton<object>$$get_Instance`, `UnityEngine.Transform$$set_parent`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$set_localScale`
- always
  - calls `PlayerDataManager$$get_IsGMEventPlayer`, `UnityEngine.Resources$$Load`, `UnityEngine.Object$$Instantiate`, `UnityEngine.GameObject$$get_transform`, `Singleton<object>$$get_Instance`, `UnityEngine.Transform$$set_parent`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$set_localScale`
- always
  - calls `PlayerDataManager$$get_IsGMEventPlayer`, `UnityEngine.Resources$$Load`, `UnityEngine.Object$$Instantiate`, `UnityEngine.GameObject$$get_transform`, `Singleton<object>$$get_Instance`, `UnityEngine.Transform$$set_parent`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$set_localScale`
- always
  - calls `PlayerDataManager$$get_IsGMEventPlayer`, `UnityEngine.Resources$$Load`, `UnityEngine.Object$$Instantiate`, `UnityEngine.GameObject$$get_transform`, `Singleton<object>$$get_Instance`, `UnityEngine.Transform$$set_parent`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$set_localScale`
- always
  - calls `PlayerDataManager$$get_IsGMEventPlayer`, `UnityEngine.Resources$$Load`, `UnityEngine.Object$$Instantiate`, `UnityEngine.GameObject$$get_transform`, `Singleton<object>$$get_Instance`, `UnityEngine.Transform$$set_parent`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$set_localScale`
- always
  - calls `PlayerDataManager$$get_IsGMEventPlayer`, `UnityEngine.Resources$$Load`, `UnityEngine.Object$$Instantiate`, `UnityEngine.GameObject$$get_transform`, `Singleton<object>$$get_Instance`, `UnityEngine.Transform$$set_parent`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$set_localScale`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `GameManager$$PlayerSkillUpdate (GetSkillLv)`
- `MainPlayer$$ConnectUpdate (GetSkillLv)`
- `MobaPlayerSecondaryStatus$$get_HpRecovery (TryGetBuf)`
- `MobaPlayerSecondaryStatus$$get_MpRecovery (TryGetBuf)`
- `PetStatus$$get_HpRecovery (ContainsBuffer)`
- `PetStatus$$get_MpRecovery (ContainsBuffer)`
- `PlayerSecondaryStatus$$CalcHpRecovery (TryGetBuf)`
- `PlayerSecondaryStatus$$CalcMpRecovery (TryGetBuf)`
- `PlayerSecondaryStatus$$GetExpBonus (TryGetBuf)`
- `SetlistAction$$GetSkillId (GetSkillLv)`
- `ShortcutManager$$ShortcutChatPanelOpen (GetSkillLv)`
- `ShortcutManager$$ShortcutChatTargetOpen (GetSkillLv)`
- `ShortcutManager$$ShortcutPanelOpen (GetSkillLv)`
- `UIComboWindow$$Initialize (GetSkillLv)`
- `UIExSkillManager$$ExSkillList (GetSkillLv)`
- `UISkillTreeManager$$SkillTreeList (GetSkillLv)`

---

### บทเพลงแห่งภูตพราย (FairySong) · uid 770

<img src="../../icons/sk_770.png" width="40" alt="icon"> 
**Tree:** ミンストレル (`Minstrel`, tier 1) · **Type:** Circle · **Max Lv:** 1 · **Weapons:** TwoHandSword, Bow, Bowgun, Rod, Magictool, Katana · **Requires:** บทเพลงแห่งการเยียวยา · **Flags:** NoMarketSearch · **Client class:** `FairySongAction`

> การชี้นำแห่งภูตพราย
> เพิ่มอัตราความแม่นและอัตราหลบหลีก
> เมื่อโจมตีเป้าหมายแล้วเกิด Avoid หรือ Guard
> จะฟื้นฟู MP เล็กน้อย(ขึ้นอยู่กับค่าฟื้นฟู MP การโจมตี)
> ไม่สามารถใช้ร่วมกับสกิลเพลงอื่นได้

<details><summary>In-game level notes</summary>

- Lv255: [บัฟเพลง] เมื่อใช้สกิลเพลงต่อเนื่องถึงระยะเวลาหนึ่ง สกิลเพลงนั้นจะเปลี่ยนเป็นบัฟเพลง(ผลถาวร)  ยิ่งจำนวนเพลงที่เปลี่ยนเป็นบัฟเพลงเพิ่มขึ้นเท่าใด MP ที่ใช้ในการร่ายสกิลเพลงและเวลาที่ต้องใช้ในการ เปลี่ยนเพลงถัดไปให้เป็นบัฟเพลงก็จะเพิ่มขึ้นเท่านั้น
- Lv255: ผลบางส่วนของบทเพลงแห่งภูตพรายที่ผู้ใช้ได้รับจะลดลง ผลกระทบนี้จะลดลงเมื่อสมาชิกในปาร์ตี้ (ไม่รวม NPC) เพิ่มขึ้น

</details>

**Role:** buff (self) · circle / song area

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 770

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `song_buff_lv` = `SongActionBase.CalcBaseCostMp(this, PlayerActionManagerBase.get_PlayerStatus())`

</details>

**Buffs**

**Buff `FairySongBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `CreateOtherBuf`, `CreateSelfBuf`, `get_EmotionType`
- `FleeRate` = `IsValidBuff` _(when BuffEffectActive ne 0; IsSelfAction eq 0)_
- `FleeRate` = `int(((isBattleActive * 0.25) * IsValidBuff))` _(when BuffEffectActive ne 0; IsSelfAction ne 0)_
- `HitRate` = `ValidSongBuffLvUp` _(when BuffEffectActive ne 0; IsSelfAction eq 0)_
- `HitRate` = `int(((isBattleActive * 0.25) * ValidSongBuffLvUp))` _(when BuffEffectActive ne 0; IsSelfAction ne 0)_
- `HitUp` = `guitaristSavingTime` _(when BuffEffectActive ne 0; IsSelfAction eq 0)_
- `HitUp` = `int(((isBattleActive * 0.25) * guitaristSavingTime))` _(when BuffEffectActive ne 0; IsSelfAction ne 0)_
- `Flee` = `int(((isBattleActive * 0.25) * UseArcheTypeId))` _(when BuffEffectActive ne 0; IsSelfAction ne 0)_
- `Flee` = `UseArcheTypeId` _(when BuffEffectActive ne 0; IsSelfAction eq 0)_
- Buff fields set in the constructor (all recovered):
  - `hit` = `(Lv * 10)` = 10
  - `hitRate` = `(Lv * 5)` = 5
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
**Buff `SongBufferBase`**
- Attached to this skill via `caller2:FairySongBuf$$CreateSelfBuf<-FairySongAction$$EffectiveSongBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `UpdateMotionSwitch`, `get_ArchetypeId`, `get_IsSendSupport`, `get_IsSensory`, `get_IsSuspendSong`, `get_SkillLocalId`, `set_ArchetypeId`, `set_IsSendSupport`, `set_IsSensory`, `set_IsSuspendSong`, `set_SkillLocalId`
- Buff fields set in the constructor (all recovered):
  - `suspendedTimer` = `-1` = -1
  - `playTakeUid` = `-1` = -1
  - `isChangeSongMotion` = `1` = 1
  - `sendSupportTimer` = `1` = 1
  - `partyMemberNum` = `1` = 1
  - `actorAction` = `actorAction`
  - `ArchetypeId` = `archetypeId`
  - `SkillLocalId` = `skillLocalId`
  - `BuffEffectActive` = `0`
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `takeController` = `actorAction.TakeController` when UnityEngine.Object.op_Inequality(actorAction)
- Hook `set_IsSensory`: `IsSensory`=(value & 1)
- Hook `set_IsSuspendSong`: `IsSuspendSong`=(value & 1)
- Hook `set_ArchetypeId`: `ArchetypeId`=value
- Hook `set_SkillLocalId`: `SkillLocalId`=value
- Hook `set_IsSendSupport`: `IsSendSupport`=(value & 1)
- Hook `UpdateMotionSwitch`: `isChangeSongMotion`=(PlayerActionManagerBase.get_IsBattleActive(actorAction) & 1); `isChangeSongMotion`=1; `suspendedTimer`=10; `IsSuspendSong`=1

<details><summary>Effect applied in `PetStatus$$get_Hit` (2 guarded paths)</summary>

- always
  - returns `(int(((?stack + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (IPlayerStatusCalculator.get_Dex(CharacterActionManagerBase.get_UnTargetDist()) + PetStatus.get_Lv(this, 11, ?mi, ?x3)))) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 42, 0, ?x3) + GetBonusConstant_AvatarConstan_Rate.out4()))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_AvatarConstan_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBuffer`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- always
  - returns `(int((?stack * (IPlayerStatusCalculator.get_Dex(CharacterActionManagerBase.get_UnTargetDist()) + PetStatus.get_Lv(this, ?x1, ?x2, ?x3)))) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 42, 0, ?x3) + GetBonusConstant_AvatarConstan_Rate.out4()))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_AvatarConstan_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsValid`, `PetStatus$$get_Lv`, `virtual CharacterActionManagerBase.get_UnTargetDist`, `interface IPlayerStatusCalculator.get_Dex`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `PetStatus$$get_Hit (ContainsBuffer)`

---

### บทเพลงแห่งชีวิต (SongOfLife) · uid 771

<img src="../../icons/sk_771.png" width="40" alt="icon"> 
**Tree:** ミンストレル (`Minstrel`, tier 1) · **Type:** Circle · **Max Lv:** 1 · **Weapons:** TwoHandSword, Bow, Bowgun, Rod, Magictool, Katana · **Requires:** บทเพลงแห่งการเยียวยา · **Flags:** NoMarketSearch · **Client class:** `SongOfLifeAction`

> จังหวะชีวิต
> ลดเวลาการคืนชีพทุกช่วงเวลาที่กำหนด
> สะสมผลการลดความเสียหายแบบเป็นเปอร์เซ็นต์
> เมื่อ HP เหลือ 0 ค่าสะสมจะเปลี่ยนเป็นบาเรียฟื้นฟู
> ไม่สามารถใช้ร่วมกับสกิลเพลงอื่นได้

<details><summary>In-game level notes</summary>

- Lv255: [บัฟเพลง] เมื่อใช้สกิลเพลงต่อเนื่องถึงระยะเวลาหนึ่ง สกิลเพลงนั้นจะเปลี่ยนเป็นบัฟเพลง(ผลถาวร)  ยิ่งจำนวนเพลงที่เปลี่ยนเป็นบัฟเพลงเพิ่มขึ้นเท่าใด MP ที่ใช้ในการร่ายสกิลเพลง และเวลาที่ต้องใช้ในการ เปลี่ยนเพลงถัดไปให้เป็นบัฟเพลงก็จะเพิ่มขึ้นเท่านั้น

</details>

**Role:** buff (self) · circle / song area

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 771

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `song_buff_lv` = `SongActionBase.CalcBaseCostMp(this, PlayerActionManagerBase.get_PlayerStatus())`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

</details>

**Buffs**

**Buff `SongOfLifeBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `CreateOtherBuf`, `CreateSelfBuf`, `GetHealHp`, `NotTargeted`, `OnInvalid`, `OnValid`, `Stack`, `Targeted`, `get_EmotionType`
- `Count` = `guitaristSavingTime` _(when BuffEffectActive ne 0)_
- `Count` = `0` _(when BuffEffectActive eq 0)_
- Buff fields set in the constructor (all recovered):
  - `intervalTimer` = `4` = 4
- Hook `Updata`: `intervalTimer`=(UseArcheTypeId eq 0 ? 4 : 2); `stack`=((guitaristSavingTime + 1) ge 50 ? 50 : (guitaristSavingTime + 1)); `intervalTimer`=(ValidSongBuffLvUp - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `Targeted`: `targeted`=1
- Hook `NotTargeted`: `targeted`=0
- Hook `Stack`: `stack`=((guitaristSavingTime + 1) ge 50 ? 50 : (guitaristSavingTime + 1))
- Hook `OnInvalid`: `intervalTimer`=4
**Buff `SongBufferBase`**
- Attached to this skill via `caller2:SongOfLifeBuf$$CreateSelfBuf<-SongOfLifeAction$$EffectiveSongBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `UpdateMotionSwitch`, `get_ArchetypeId`, `get_IsSendSupport`, `get_IsSensory`, `get_IsSuspendSong`, `get_SkillLocalId`, `set_ArchetypeId`, `set_IsSendSupport`, `set_IsSensory`, `set_IsSuspendSong`, `set_SkillLocalId`
- Buff fields set in the constructor (all recovered):
  - `suspendedTimer` = `-1` = -1
  - `playTakeUid` = `-1` = -1
  - `isChangeSongMotion` = `1` = 1
  - `sendSupportTimer` = `1` = 1
  - `partyMemberNum` = `1` = 1
  - `actorAction` = `actorAction`
  - `ArchetypeId` = `archetypeId`
  - `SkillLocalId` = `skillLocalId`
  - `BuffEffectActive` = `0`
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `takeController` = `actorAction.TakeController` when UnityEngine.Object.op_Inequality(actorAction)
- Hook `set_IsSensory`: `IsSensory`=(value & 1)
- Hook `set_IsSuspendSong`: `IsSuspendSong`=(value & 1)
- Hook `set_ArchetypeId`: `ArchetypeId`=value
- Hook `set_SkillLocalId`: `SkillLocalId`=value
- Hook `set_IsSendSupport`: `IsSendSupport`=(value & 1)
- Hook `UpdateMotionSwitch`: `isChangeSongMotion`=(PlayerActionManagerBase.get_IsBattleActive(actorAction) & 1); `isChangeSongMotion`=1; `suspendedTimer`=10; `IsSuspendSong`=1

---

### บทเพลงแห่งมายา (PhantomSong) · uid 772

<img src="../../icons/sk_772.png" width="40" alt="icon"> 
**Tree:** ミンストレル (`Minstrel`, tier 2) · **Type:** Circle · **Max Lv:** 60 · **Weapons:** TwoHandSword, Bow, Bowgun, Rod, Magictool, Katana · **Requires:** บทเพลงแห่งชีวิต · **Flags:** NoMarketSearch · **Client class:** `PhantomSongAction`

> มายาแห่งห้วงฝัน
> จะสะสมผลของเพลงไว้ชั่วขณะ
> ตอนที่สกิลคลายลงจะใช้ผลของเพลงเพื่อฟื้นฟู MP
> จะไม่ทำงานระหว่างทำคอมโบ
> ไม่สามารถใช้ร่วมกับสกิลเพลงอื่นได้

<details><summary>In-game level notes</summary>

- Lv255: [บัฟเพลง] เมื่อใช้สกิลเพลงต่อเนื่องถึงระยะเวลาหนึ่ง สกิลเพลงนั้นจะเปลี่ยนเป็นบัฟเพลง(ผลถาวร)  ยิ่งจำนวนเพลงที่เปลี่ยนเป็นบัฟเพลงเพิ่มขึ้นเท่าใด MP ที่ใช้ในการร่ายสกิลเพลง และเวลาที่ต้องใช้ในการ เปลี่ยนเพลงถัดไปให้เป็นบัฟเพลงก็จะเพิ่มขึ้นเท่านั้น

</details>

**Role:** buff (self) · circle / song area

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 772

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `song_buff_lv` = `SongActionBase.CalcBaseCostMp(this, PlayerActionManagerBase.get_PlayerStatus())`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

</details>

**Buffs**

**Buff `PhantomSongBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `CreateOtherBuf`, `CreateSelfBuf`, `OnInvalid`, `OnValid`, `Stack`, `UseStack`, `get_EmotionType`
- `Value` = `ValidSongBuffLvUp` _(when BuffEffectActive ne 0)_
- `Value` = `0` _(when BuffEffectActive eq 0)_
- Buff fields set in the constructor (all recovered):
  - `intervalTime` = `((Lv * -0.5) + 11)` → Lv1..10 [10.5, 10.0, 9.5, 9.0, 8.5, 8.0, 7.5, 7.0, 6.5, 6.0]
  - `intervalTimer` = `((Lv * -0.5) + 11)` → Lv1..10 [10.5, 10.0, 9.5, 9.0, 8.5, 8.0, 7.5, 7.0, 6.5, 6.0]
- Hook `Updata`: `intervalTimer`=guitaristSavingTime; `stack`=((ValidSongBuffLvUp + 1) ge 9 ? 9 : (ValidSongBuffLvUp + 1)); `intervalTimer`=(UseArcheTypeId - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `UseStack`: `intervalTimer`=guitaristSavingTime; `stack`=max((ValidSongBuffLvUp - useStack), 0)
- Hook `Stack`: `stack`=((ValidSongBuffLvUp + 1) ge 9 ? 9 : (ValidSongBuffLvUp + 1))
- Hook `OnInvalid`: `intervalTimer`=guitaristSavingTime
**Buff `SongBufferBase`**
- Attached to this skill via `caller2:PhantomSongBuf$$CreateSelfBuf<-PhantomSongAction$$EffectiveSongBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `UpdateMotionSwitch`, `get_ArchetypeId`, `get_IsSendSupport`, `get_IsSensory`, `get_IsSuspendSong`, `get_SkillLocalId`, `set_ArchetypeId`, `set_IsSendSupport`, `set_IsSensory`, `set_IsSuspendSong`, `set_SkillLocalId`
- Buff fields set in the constructor (all recovered):
  - `suspendedTimer` = `-1` = -1
  - `playTakeUid` = `-1` = -1
  - `isChangeSongMotion` = `1` = 1
  - `sendSupportTimer` = `1` = 1
  - `partyMemberNum` = `1` = 1
  - `actorAction` = `actorAction`
  - `ArchetypeId` = `archetypeId`
  - `SkillLocalId` = `skillLocalId`
  - `BuffEffectActive` = `0`
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `takeController` = `actorAction.TakeController` when UnityEngine.Object.op_Inequality(actorAction)
- Hook `set_IsSensory`: `IsSensory`=(value & 1)
- Hook `set_IsSuspendSong`: `IsSuspendSong`=(value & 1)
- Hook `set_ArchetypeId`: `ArchetypeId`=value
- Hook `set_SkillLocalId`: `SkillLocalId`=value
- Hook `set_IsSendSupport`: `IsSendSupport`=(value & 1)
- Hook `UpdateMotionSwitch`: `isChangeSongMotion`=(PlayerActionManagerBase.get_IsBattleActive(actorAction) & 1); `isChangeSongMotion`=1; `suspendedTimer`=10; `IsSuspendSong`=1

---

### แอดลิบ (ImprovisationSong) · uid 773

<img src="../../icons/sk_773.png" width="40" alt="icon"> 
**Tree:** ミンストレル (`Minstrel`, tier 2) · **Type:** Buffer · **Max Lv:** 60 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** NoMarketSearch · **Client class:** `ImprovisationSongAction`

> ใช้สกิลเพลงที่ใช้ไปล่าสุดอีกครั้ง
> ในระหว่างที่สกิลเพลงกำลังทำงานอยู่
> จะลดความเสียหายขณะใช้แอดลิบ
> (Lv10 จะเปลี่ยนจากการลดความเสียหายเป็นคงกระพัน)

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 773

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`

**`ActionPreparation`** (15 paths)

- set `gemcartGuitaristLv` = `GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 46)` — when !PlayerAttackBase.IsBlank(this) AND (System.Collections.IEnumerator#0(System.Collections.Generic.IEnumerable<SkillBufferDataBase>#0!SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000))) AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !SkillBufferManager.TryGetImprovisationSongBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)) AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) lt 1 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND (System.Collections.IEnumerator#0(System.Collections.Generic.IEnumerable<SkillBufferDataBase>#0SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000))) AND SongActionBase.IsSongSkillId(CharacterActionManagerBase.get_Size()) AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) ge 1 AND UnityEngine.Object.op_Inequality(actarAction)
- set `SkillIndividualFlag` = `(Toram.Common.ProgramUtil.ShiftLeftBitByShort((SkillBufferDataBase.get_SkillId() & 0xffff)) | 0)` — when !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 46) ne 0 AND SkillBufferManager.TryGetImprovisationSongBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)) AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) lt 1 AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)) ne 0 AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)).IsEnd ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillBufferManager.TryGetImprovisationSongBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)) AND SongBufferBase.CheckTake(TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288))) AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) lt 1 AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)) ne 0 AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)).IsEnd eq 0 AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)).IsSuspendSong eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !SongBufferBase.CheckTake(TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288))) AND GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 46) ne 0 AND SkillBufferManager.TryGetImprovisationSongBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)) AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) lt 1 AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)) ne 0 AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)).IsEnd eq 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `SkillIndividualFlag` = `(Toram.Common.ProgramUtil.ShiftLeftBitByShort((SkillBufferDataBase.get_SkillId() & 0xffff)) | 1)` — when !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 46) eq 0 AND SkillBufferManager.TryGetImprovisationSongBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)) AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) lt 1 AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)) ne 0 AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)).IsEnd ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !SongBufferBase.CheckTake(TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288))) AND GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 46) eq 0 AND SkillBufferManager.TryGetImprovisationSongBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)) AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) lt 1 AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)) ne 0 AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)).IsEnd eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 46) eq 0 AND SkillBufferManager.TryGetImprovisationSongBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)) AND SongBufferBase.CheckTake(TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288))) AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) lt 1 AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)) ne 0 AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)).IsEnd eq 0 AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)).IsSuspendSong ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- calls `ImprovisationSongBuf..ctor` = `.ctor(Lv, Id)` — when !PlayerAttackBase.IsBlank(this) AND SkillBufferManager.TryGetImprovisationSongBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)) AND SongBufferBase.CheckTake(TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288))) AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) lt 1 AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)) ne 0 AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)).IsEnd eq 0 AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)).IsSuspendSong eq 0 AND UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new ImprovisationSongBuf, Id)` — when !PlayerAttackBase.IsBlank(this) AND SkillBufferManager.TryGetImprovisationSongBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)) AND SongBufferBase.CheckTake(TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288))) AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) lt 1 AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)) ne 0 AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)).IsEnd eq 0 AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)).IsSuspendSong eq 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `SkillIndividualFlag` = `(Toram.Common.ProgramUtil.ShiftLeftBitByShort(0) | 0)` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !SkillBufferManager.TryGetImprovisationSongBuf(PlayerStatusBase.get_SkillBufferManager(), (this + 288)) AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) lt 1 AND UnityEngine.Object.op_Inequality(actarAction)

**`ActionSkillEvent`** (9 paths)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(773)` — when Id eq TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 773).skillLocalId AND IsOtherPlayer eq 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 773) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 100 AND param ne 200
- set `isDamaged` = `1` = 1 — when IsOtherPlayer ne 0 AND param eq 200

**`ActionSkillEventIfMoveIndex`** (13 paths)

- set `isDamaged` = `1` = 1 — when +0x129 eq 0 AND +0x12a eq 0 AND IsOtherPlayer eq 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 773) ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 773).damaged ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR +0x129 eq 0 AND +0x12a ne 0 AND IsOtherPlayer eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 776, 1) lt 1 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 773) ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 773).damaged ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR +0x129 eq 0 AND +0x12a ne 0 AND IsOtherPlayer eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 776, 1) ge 1 AND SkillUtil.CheckSkillEquipLimit(PlayerStatusBase.get_EquipItemData(), MasterSkillDataManager.GetSkillMaster(Singleton<MasterSkillDataManager>.get_Instance(), 776)) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 773) ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 773).damaged ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- calls `BeatBlastBuf..ctor` = `.ctor()` — when +0x129 eq 0 AND +0x12a ne 0 AND IsOtherPlayer eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 776, 1) ge 1 AND SkillUtil.CheckSkillEquipLimit(PlayerStatusBase.get_EquipItemData(), MasterSkillDataManager.GetSkillMaster(Singleton<MasterSkillDataManager>.get_Instance(), 776)) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 773) ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 773).damaged ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new BeatBlastBuf, 0)` — when +0x129 eq 0 AND +0x12a ne 0 AND IsOtherPlayer eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 776, 1) ge 1 AND SkillUtil.CheckSkillEquipLimit(PlayerStatusBase.get_EquipItemData(), MasterSkillDataManager.GetSkillMaster(Singleton<MasterSkillDataManager>.get_Instance(), 776)) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 773) ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 773).damaged ne 0 AND UnityEngine.Object.op_Inequality(actarAction)

**`ActiveResumeSong`** (4 paths)

- set `isResumed` = `1` = 1 — when +0x128 eq 0 OR (CharacterActionManagerBase.get_Size() - 769) ls 6 AND +0x128 eq 0 OR (CharacterActionManagerBase.get_Size() - 769) hi 6 AND +0x128 eq 0

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`

**`.<>c__DisplayClass31_0::<ActionPreparation>b__0`** (4 paths)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(773)` — when TryGetBuf<object>.out2(<>c__DisplayClass31_0.bufManager, 773) ne 0

**`.<>c__DisplayClass31_0::<ActionPreparation>b__1`** (5 paths)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(773)` — when (cancel & 1) ne 0 AND TryGetBuf<object>.out2(<>c__DisplayClass31_0.bufManager, 773) ne 0

</details>

**Buffs**

**Buff `BeatBlastBuf`**
- Buff hook methods: `PayStack`, `SetStack`
- Hook `PayStack`: `Count`=(Count lt 7 ? 0 : (Count - 6))
- Hook `SetStack`: `Count`=(Max lt stack ? Max : stack)
**Buff `ImprovisationSongBuf`**
- Buff hook methods: `CheckDamaged`, `Damaged`, `get_SkillLocalId`
- Duration: `1` s
- `MobLastDamageRateUnique` = `0` _(when BuffEffectActive eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MobLastDamageRateUnique | 30 | 30 | 30 | 30 | 30 | 30 | 30 | 30 | 30 | 30 |

- Buff fields set in the constructor (all recovered):
  - `skillLocalId` = `skillLocalId`
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `damageCut` = `256` = 256 when Lv eq 10
  - `damageCut` = `(((Lv + (Lv << 2)) << 1) lo 100 ? ((Lv + (Lv << 2)) << 1) : 100)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100] when Lv ne 10
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `Damaged`: `damaged`=1
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:BeatBlastBuf$$.ctor<-ImprovisationSongAction$$ActionSkillEventIfMoveIndex` (no direct constructor call in the skill's own code).
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
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:ImprovisationSongBuf$$.ctor<-ImprovisationSongAction$$ActionPreparation` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value
**Buff `SongBufferBase`**
- Attached to this skill via `caller2:FairySongBuf$$CreateSelfBuf<-ImprovisationSongAction$$ActiveResumeSong` (no direct constructor call in the skill's own code).
- Buff hook methods: `UpdateMotionSwitch`, `get_ArchetypeId`, `get_IsSendSupport`, `get_IsSensory`, `get_IsSuspendSong`, `get_SkillLocalId`, `set_ArchetypeId`, `set_IsSendSupport`, `set_IsSensory`, `set_IsSuspendSong`, `set_SkillLocalId`
- Buff fields set in the constructor (all recovered):
  - `suspendedTimer` = `-1` = -1
  - `playTakeUid` = `-1` = -1
  - `isChangeSongMotion` = `1` = 1
  - `sendSupportTimer` = `1` = 1
  - `partyMemberNum` = `1` = 1
  - `actorAction` = `actorAction`
  - `ArchetypeId` = `archetypeId`
  - `SkillLocalId` = `skillLocalId`
  - `BuffEffectActive` = `0`
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `takeController` = `actorAction.TakeController` when UnityEngine.Object.op_Inequality(actorAction)
- Hook `set_IsSensory`: `IsSensory`=(value & 1)
- Hook `set_IsSuspendSong`: `IsSuspendSong`=(value & 1)
- Hook `set_ArchetypeId`: `ArchetypeId`=value
- Hook `set_SkillLocalId`: `SkillLocalId`=value
- Hook `set_IsSendSupport`: `IsSendSupport`=(value & 1)
- Hook `UpdateMotionSwitch`: `isChangeSongMotion`=(PlayerActionManagerBase.get_IsBattleActive(actorAction) & 1); `isChangeSongMotion`=1; `suspendedTimer`=10; `IsSuspendSong`=1

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

### บีทบลาสต์ (BeatBlast) · uid 776

<img src="../../icons/sk_776.png" width="40" alt="icon"> 
**Tree:** ミンストレル (`Minstrel`, tier 2) · **Type:** Special · **Max Lv:** 60 · **Weapons:** TwoHandSword, Bow, Bowgun, Rod, Magictool, Katana · **Requires:** บทเพลงแห่งชีวิต · **Flags:** NoMarketSearch · **Client class:** `BeatBlastAction`

> โจมตีด้วยแรงดันเสียงที่ใช้ได้ขณะใช้สกิลเพลงเท่านั้น
> จะสะสมสแต็คตามค่า MP ที่สมาชิกปาร์ตี้
> ได้รับผลจากเพลงใช้ไป (สูงสุด 20)
> ใช้(สูงสุด 6) สแต็คเพื่อสร้าง
> ความเสียหายเวทมนตร์ต่อศัตรูรอบข้าง (ที่กำลังต่อสู้อยู่)

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 1.15 | 1.3 | 1.45 | 1.6 | 1.75 | 1.9 | 2.05 | 2.2 | 2.35 | 2.5 |
| Flat dmg + | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 |

**Role:** attack (deals damage)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(0)`
- `SkillRate` multiplies by (adds into): `(((((Lv << 4) - Lv) + 100)) / 100)`

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 776

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `constantDamage` = `0` = 0
- set `skillRate` = `(((Lv << 4) - Lv) + 100)` → Lv1..10: [115, 130, 145, 160, 175, 190, 205, 220, 235, 250]
- set `magicBreak` = `((Lv + (Lv << 2)) << 1)` → Lv1..10: [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]

**`ActionPreparation`** (11 paths)

- set `SkillIndividualFlag` = `BeatBlastBuf.PayStack(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 776))` — when !PlayerAttackBase.IsBlank(this) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 776) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 776) ne 0 AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager()) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 776) ne 0 AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager()) ne 0 AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager()).IsEnd eq 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `SkillIndividualFlag` = `0` = 0 — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager()) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager()) ne 0 AND TryGetImprovisationSongBuf.songBuf(PlayerStatusBase.get_SkillBufferManager()).IsEnd eq 0 AND UnityEngine.Object.op_Inequality(actarAction)

**`ActionStart`** (3 paths)

- set `AtkParam` = `status.Atk` — when UnityEngine.Object.op_Inequality(actarAction) AND status.Matk lt status.Atk
- set `AtkParam` = `status.Matk` — when UnityEngine.Object.op_Inequality(actarAction) AND status.Matk ge status.Atk

**`calcPlayerToMobDamage`** (3 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)` — when attackCount ge 1
- template `AddConstant[SkillConstantDamage]` = `constantDamage` — when attackCount ge 1
- info `templates` = `1` — when attackCount ge 1

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

</details>

<details><summary>Effect applied in `ImprovisationSongAction$$ActionSkillEventIfMoveIndex` (4 guarded paths)</summary>

- when `IsOtherPlayer eq 0` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 773, stkp(-56), meta(0x39ac500, Method$SkillBufferManager.TryGetBuf<ImprovisationSongBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `SkillLv(776) ge 1`
  - returns `1`
  - set `isDamaged` = `1`
  - calls `Singleton<object>$$get_Instance`, `MasterSkillDataManager$$GetSkillMaster`, `SkillUtil$$CheckSkillEquipLimit`, `0x165db78`, `BeatBlastBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_gameObject`
- when `IsOtherPlayer eq 0` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 773, stkp(-56), meta(0x39ac500, Method$SkillBufferManager.TryGetBuf<ImprovisationSongBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `SkillLv(776) ge 1`
  - returns `1`
  - set `isDamaged` = `1`
  - calls `Singleton<object>$$get_Instance`, `MasterSkillDataManager$$GetSkillMaster`, `SkillUtil$$CheckSkillEquipLimit`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_gameObject`, `virtual PlayerAttackBase.get_ActionID`, `GameManager$$SkillEvent`
- when `IsOtherPlayer eq 0` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 773, stkp(-56), meta(0x39ac500, Method$SkillBufferManager.TryGetBuf<ImprovisationSongBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `SkillLv(776) ge 1`
  - returns `1`
  - set `isDamaged` = `1`
  - calls `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_gameObject`, `virtual PlayerAttackBase.get_ActionID`, `GameManager$$SkillEvent`
- when `IsOtherPlayer eq 0` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 773, stkp(-56), meta(0x39ac500, Method$SkillBufferManager.TryGetBuf<ImprovisationSongBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `SkillLv(776) lt 1`
  - returns `1`
  - set `isDamaged` = `1`
  - calls `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_gameObject`, `virtual PlayerAttackBase.get_ActionID`, `GameManager$$SkillEvent`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `ImprovisationSongAction$$ActionSkillEventIfMoveIndex (GetSkillLv)`

---

### บทเพลงแห่งความเร่าร้อน (EnthusiasticSong) · uid 774

<img src="../../icons/sk_774.png" width="40" alt="icon"> 
**Tree:** ミンストレル (`Minstrel`, tier 3) · **Type:** Circle · **Max Lv:** 120 · **Weapons:** TwoHandSword, Bow, Bowgun, Rod, Magictool, Katana · **Requires:** บทเพลงแห่งภูตพราย · **Flags:** NoMarketSearch · **Client class:** `EnthusiasticSongAction`

> จิตที่ตั้งมั่นอย่างแน่วแน่
> เพิ่มความเสียหายต่อจุดอ่อนและความเสียหายต่อไร้ธาตุ
> และเพิ่มเฮทเมื่อตกเป็นเป้าหมาย
> ไม่สามารถใช้ร่วมกับสกิลเพลงอื่นได้

<details><summary>In-game level notes</summary>

- Lv255: [บัฟเพลง] เมื่อใช้สกิลเพลงต่อเนื่องถึงระยะเวลาหนึ่ง สกิลเพลงนั้นจะเปลี่ยนเป็นบัฟเพลง(ผลถาวร)  ยิ่งจำนวนเพลงที่เปลี่ยนเป็นบัฟเพลงเพิ่มขึ้นเท่าใด MP ที่ใช้ในการร่ายสกิลเพลงและเวลาที่ต้องใช้ในการ เปลี่ยนเพลงถัดไปให้เป็นบัฟเพลงก็จะเพิ่มขึ้นเท่านั้น
- Lv255: ผลของบทเพลงแห่งความเร่าร้อนที่ผู้ใช้ได้รับจะลดลง ผลกระทบนี้จะลดลงเมื่อสมาชิกในปาร์ตี้ (ไม่รวม NPC) เพิ่มขึ้น

</details>

**Role:** buff (self) · circle / song area

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 774

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `song_buff_lv` = `SongActionBase.CalcBaseCostMp(this, PlayerActionManagerBase.get_PlayerStatus())`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

</details>

**Buffs**

**Buff `EnthusiasticSongBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `CreateOtherBuf`, `CreateSelfBuf`, `get_EmotionType`
- `Value` = `int(((isBattleActive * 0.25) * guitaristSavingTime))` _(when BuffEffectActive ne 0; IsSelfAction ne 0)_
- `Value` = `guitaristSavingTime` _(when BuffEffectActive ne 0; IsSelfAction eq 0)_
- `Value` = `0` _(when BuffEffectActive eq 0)_
- Buff fields set in the constructor (all recovered):
  - `elementDamage` = `int((Lv * 1.5))` → Lv1..10 [1, 3, 4, 6, 7, 9, 10, 12, 13, 15]
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
**Buff `SongBufferBase`**
- Attached to this skill via `caller2:EnthusiasticSongBuf$$CreateSelfBuf<-EnthusiasticSongAction$$EffectiveSongBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `UpdateMotionSwitch`, `get_ArchetypeId`, `get_IsSendSupport`, `get_IsSensory`, `get_IsSuspendSong`, `get_SkillLocalId`, `set_ArchetypeId`, `set_IsSendSupport`, `set_IsSensory`, `set_IsSuspendSong`, `set_SkillLocalId`
- Buff fields set in the constructor (all recovered):
  - `suspendedTimer` = `-1` = -1
  - `playTakeUid` = `-1` = -1
  - `isChangeSongMotion` = `1` = 1
  - `sendSupportTimer` = `1` = 1
  - `partyMemberNum` = `1` = 1
  - `actorAction` = `actorAction`
  - `ArchetypeId` = `archetypeId`
  - `SkillLocalId` = `skillLocalId`
  - `BuffEffectActive` = `0`
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `takeController` = `actorAction.TakeController` when UnityEngine.Object.op_Inequality(actorAction)
- Hook `set_IsSensory`: `IsSensory`=(value & 1)
- Hook `set_IsSuspendSong`: `IsSuspendSong`=(value & 1)
- Hook `set_ArchetypeId`: `ArchetypeId`=value
- Hook `set_SkillLocalId`: `SkillLocalId`=value
- Hook `set_IsSendSupport`: `IsSendSupport`=(value & 1)
- Hook `UpdateMotionSwitch`: `isChangeSongMotion`=(PlayerActionManagerBase.get_IsBattleActive(actorAction) & 1); `isChangeSongMotion`=1; `suspendedTimer`=10; `IsSuspendSong`=1

<details><summary>Effect applied in `PlayerAttackBase$$CalcElementBonus` (35 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 774, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `attackType eq 2` AND `Element ne 0`
  - returns `PlayerAttackBase.CalcElementKillerBonus(status, targetType, ?x2, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `virtual PlayerStatusBase.get_BattleStatus`, `interface IPlayerStatusCalculator.get_ElementPower`, `SkillUtil$$CheckWeakElemet`, `Singleton<object>$$get_Instance`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 774, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `attackType eq 2` AND `Element ne 0`
  - returns `PlayerAttackBase.CalcElementKillerBonus(status, targetType, ?x2, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `virtual PlayerStatusBase.get_BattleStatus`, `interface IPlayerStatusCalculator.get_ElementPower`, `SkillUtil$$CheckWeakElemet`, `Singleton<object>$$get_Instance`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 774, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `attackType eq 2` AND `Element ne 0`
  - returns `PlayerAttackBase.CalcElementKillerBonus(status, targetType, ?x2, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `virtual PlayerStatusBase.get_BattleStatus`, `interface IPlayerStatusCalculator.get_ElementPower`, `SkillUtil$$CheckWeakElemet`, `PlayerAttackBase$$CalcElementKillerBonus`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 774, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `attackType eq 2` AND `Element ne 0`
  - returns `PlayerAttackBase.CalcElementKillerBonus(status, targetType, ?x2, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `SkillUtil$$CheckWeakElemet`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `virtual PlayerStatusBase.get_BonusManager`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 774, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `attackType eq 2` AND `Element ne 0`
  - returns `PlayerAttackBase.CalcElementKillerBonus(status, targetType, ?x2, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `SkillUtil$$CheckWeakElemet`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `PlayerAttackBase$$CalcElementKillerBonus`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 774, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `attackType eq 2` AND `Element ne 0`
  - returns `PlayerAttackBase.CalcElementKillerBonus(status, targetType, ?x2, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `SkillUtil$$CheckWeakElemet`, `PlayerAttackBase$$CalcElementKillerBonus`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 774, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `attackType eq 2` AND `Element eq 0`
  - returns `PlayerAttackBase.CalcElementKillerBonus(status, targetType, ?x2, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `SkillUtil$$CheckWeakElemet`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `virtual PlayerStatusBase.get_BonusManager`
- when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 774, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `attackType eq 2` AND `Element eq 0`
  - returns `PlayerAttackBase.CalcElementKillerBonus(status, targetType, ?x2, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `SkillUtil$$CheckWeakElemet`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `PlayerAttackBase$$CalcElementKillerBonus`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `PlayerAttackBase$$CalcElementBonus (TryGetBuf)`

---

### บทเพลงแห่งภูมิปัญญา (KnowledgeSong) · uid 775

<img src="../../icons/sk_775.png" width="40" alt="icon"> 
**Tree:** ミンストレル (`Minstrel`, tier 3) · **Type:** Circle · **Max Lv:** 120 · **Weapons:** TwoHandSword, Bow, Bowgun, Rod, Magictool, Katana · **Requires:** บทเพลงแห่งภูตพราย · **Flags:** NoMarketSearch · **Client class:** `KnowledgeSongAction`

> การรู้แจ้งแห่งภูมิปัญญาอันมหาศาล
> ลดความเสียหายทุกประเภทและระยะผลักกระเด็น
> ไม่สามารถใช้ร่วมกับสกิลเพลงอื่นได้

<details><summary>In-game level notes</summary>

- Lv255: [บัฟเพลง] เมื่อใช้สกิลเพลงต่อเนื่องถึงระยะเวลาหนึ่ง สกิลเพลงนั้นจะเปลี่ยนเป็นบัฟเพลง(ผลถาวร)  ยิ่งจำนวนเพลงที่เปลี่ยนเป็นบัฟเพลงเพิ่มขึ้นเท่าใด MP ที่ใช้ในการร่ายสกิลเพลงและเวลาที่ต้องใช้ในการ เปลี่ยนเพลงถัดไปให้เป็นบัฟเพลงก็จะเพิ่มขึ้นเท่านั้น
- Lv255: ผลของบทเพลงแห่งภูมิปัญญาที่ผู้ใช้ได้รับจะลดลง ผลกระทบนี้จะลดลงเมื่อสมาชิกในปาร์ตี้ (ไม่รวม NPC) เพิ่มขึ้น

</details>

**Role:** buff (self) · circle / song area

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 775

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `song_buff_lv` = `SongActionBase.CalcBaseCostMp(this, PlayerActionManagerBase.get_PlayerStatus())`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

</details>

**Buffs**

**Buff `KnowledgeSongBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `CreateOtherBuf`, `CreateSelfBuf`, `get_EmotionType`
- `MobLastDamageRateSupport` = `guitaristSavingTime` _(when BuffEffectActive ne 0)_
- `Value` = `int(((isBattleActive * 0.25) * ValidSongBuffLvUp))` _(when BuffEffectActive ne 0; IsSelfAction ne 0)_
- `Value` = `ValidSongBuffLvUp` _(when BuffEffectActive ne 0; IsSelfAction eq 0)_
- Buff fields set in the constructor (all recovered):
  - `reduceDamageRate` = `int((Lv * 2.5))` → Lv1..10 [2, 5, 7, 10, 12, 15, 17, 20, 22, 25]
  - `knockbackReduceValue` = `((Lv << 2) + lv)` → Lv1..10 [5, 10, 15, 20, 25, 30, 35, 40, 45, 50]
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
**Buff `SongBufferBase`**
- Attached to this skill via `caller2:KnowledgeSongBuf$$CreateSelfBuf<-KnowledgeSongAction$$EffectiveSongBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `UpdateMotionSwitch`, `get_ArchetypeId`, `get_IsSendSupport`, `get_IsSensory`, `get_IsSuspendSong`, `get_SkillLocalId`, `set_ArchetypeId`, `set_IsSendSupport`, `set_IsSensory`, `set_IsSuspendSong`, `set_SkillLocalId`
- Buff fields set in the constructor (all recovered):
  - `suspendedTimer` = `-1` = -1
  - `playTakeUid` = `-1` = -1
  - `isChangeSongMotion` = `1` = 1
  - `sendSupportTimer` = `1` = 1
  - `partyMemberNum` = `1` = 1
  - `actorAction` = `actorAction`
  - `ArchetypeId` = `archetypeId`
  - `SkillLocalId` = `skillLocalId`
  - `BuffEffectActive` = `0`
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `takeController` = `actorAction.TakeController` when UnityEngine.Object.op_Inequality(actorAction)
- Hook `set_IsSensory`: `IsSensory`=(value & 1)
- Hook `set_IsSuspendSong`: `IsSuspendSong`=(value & 1)
- Hook `set_ArchetypeId`: `ArchetypeId`=value
- Hook `set_SkillLocalId`: `SkillLocalId`=value
- Hook `set_IsSendSupport`: `IsSendSupport`=(value & 1)
- Hook `UpdateMotionSwitch`: `isChangeSongMotion`=(PlayerActionManagerBase.get_IsBattleActive(actorAction) & 1); `isChangeSongMotion`=1; `suspendedTimer`=10; `IsSuspendSong`=1

<details><summary>Effect applied in `AutoMemberActionManager$$CalcAbnormalKnockBackDistance` (5 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 775, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `AbnormalStateManager.GetAnbormalStateResistTime(4, 0, ?mi, ?x3)`
  - calls `KnightPledgeAction$$GetReduceKnockbackDistance`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `AbnormalStateManager$$GetAnbormalStateResistTime`
- when `(SkillBufferManager.TryGetBuf(?blr, 775, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - calls `KnightPledgeAction$$GetReduceKnockbackDistance`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `(SkillBufferManager.TryGetBuf(?blr, 775, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `KnightPledgeAction$$GetReduceKnockbackDistance`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(?blr, 775, stkp(-40), 0) & 1) eq 0`
  - returns `AbnormalStateManager.GetAnbormalStateResistTime(4, 0, ?x2, ?x3)`
  - calls `KnightPledgeAction$$GetReduceKnockbackDistance`, `AbnormalStateManager$$GetAnbormalStateResistTime`
- when `(SkillBufferManager.TryGetBuf(?blr, 775, stkp(-40), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 775, stkp(-40), 0)`
  - calls `KnightPledgeAction$$GetReduceKnockbackDistance`

</details>

<details><summary>Effect applied in `PlayerActionManager$$CalcAbnormalKnockBackDistance` (5 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 775, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `AbnormalStateManager.GetAnbormalStateResistTime(4, 0, ?mi, ?x3)`
  - calls `KnightPledgeAction$$GetReduceKnockbackDistance`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `AbnormalStateManager$$GetAnbormalStateResistTime`
- when `(SkillBufferManager.TryGetBuf(?blr, 775, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - calls `KnightPledgeAction$$GetReduceKnockbackDistance`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `(SkillBufferManager.TryGetBuf(?blr, 775, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `KnightPledgeAction$$GetReduceKnockbackDistance`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(?blr, 775, stkp(-40), 0) & 1) eq 0`
  - returns `AbnormalStateManager.GetAnbormalStateResistTime(4, 0, ?x2, ?x3)`
  - calls `KnightPledgeAction$$GetReduceKnockbackDistance`, `AbnormalStateManager$$GetAnbormalStateResistTime`
- when `(SkillBufferManager.TryGetBuf(?blr, 775, stkp(-40), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 775, stkp(-40), 0)`
  - calls `KnightPledgeAction$$GetReduceKnockbackDistance`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `AutoMemberActionManager$$CalcAbnormalKnockBackDistance (TryGetBuf)`
- `PlayerActionManager$$CalcAbnormalKnockBackDistance (TryGetBuf)`

---

### ซาวนด์เวล (SoundVeil) · uid 777

<img src="../../icons/sk_777.png" width="40" alt="icon"> 
**Tree:** ミンストレル (`Minstrel`, tier 3) · **Type:** Mastery · **Max Lv:** 120 · **Weapons:** TwoHandSword, Bow, Bowgun, Rod, Magictool, Katana · **Requires:** บีทบลาสต์ · **Flags:** NoMarketSearch · **Client class:** `SoundVeil` (passive mastery)

> ขณะใช้สกิลเพลงค่าเฮทที่เกิดจากตัวผู้ใช้จะกลายเป็น 1
> และลดความเสียหายทั้งหมดตามจำนวนบัฟเพลง
> แต่ไม่สามารถลดความเสียหายจากเป้าหมาย
> ที่พุ่งเป้ามาที่ผู้ใช้โดยตรงได้

**Role:** passive mastery

---

### แบทเทิลโน้ต (BattleNotes) · uid 778

<img src="../../icons/sk_778.png" width="40" alt="icon"> 
**Tree:** ミンストレル (`Minstrel`, tier 3) · **Type:** Mastery · **Max Lv:** 120 · **Weapons:** TwoHandSword, Bow, Bowgun, Rod, Magictool, Katana · **Requires:** บีทบลาสต์ · **Flags:** NoMarketSearch · **Client class:** `BattleNotes` (passive mastery)

> ขณะใช้สกิลเพลงหากมีเป้าหมาย
> อยู่ในระยะโจมตีของอาวุธที่ติดตั้งและผู้ใช้หยุดนิ่ง
> จะปล่อยคลื่นเสียงโจมตีเพื่อทำการโจมตีปกติ
> (ระยะเวลาการใช้ขึ้นอยู่กับค่า ASPD และสกิลเลเวล)

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Percent | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |


<details><summary>Effect applied in `PlayerBattleManager$$StartBattleNotesAttack` (2 guarded paths)</summary>

- when `SkillLv(778) ge 1`
  - returns `0`
  - calls `SkillActionManager$$IsPlaySkillData`, `UnityEngine.GameObject$$GetComponent<object>`, `SkillFactory$$CreateSkill`, `SkillActionBase$$Initialize`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`
- when `SkillLv(778) lt 1`
  - returns `0`
  - calls `SkillActionManager$$IsPlaySkillData`, `UnityEngine.GameObject$$GetComponent<object>`, `SkillFactory$$CreateSkill`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `PlayerBattleManager$$StartBattleNotesAttack (GetSkillLv)`

---
