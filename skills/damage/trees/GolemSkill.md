# ゴーレムスキル (`GolemSkill`)

12 entries. See ../README.md for how to read these blocks.

### อัญเชิญโกเล็ม (CallGolem) · uid 577

<img src="../../icons/sk_577.png" width="40" alt="icon"> 
**Tree:** ゴーレムスキル (`GolemSkill`, tier 1) · **Type:** Object · **Max Lv:** 1 · **Weapons:** Bowgun, Rod, MainMagictool · **Flags:** NoMarketSearch · **Client class:** `CallGolemAction`

> อัญเชิญโกเล็มมาร่วมต่อสู้
> 
> สูญเสียฟื้นฟู MP การโจมตีของคุณ
> แต่ได้ฟื้นฟู MP จากการโจมตีปกติมาแทน
> เลือกประเภทของโกเล็มและปรับแต่งหลอดพลังด้วย EX สกิล

**Role:** buff (self) · placed object / trap / summon

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 577

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

</details>

**Buffs**

**Buff `CallGolemBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `BufferEnd`, `GetDamageResistRate`, `get_GolemBonus`, `set_GolemBonus`
- Duration: `((10 + ((((ExSkillCallGolem.CalcSurplusPoint(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577), lv) & 255) << 2) + ExSkillCallGolem.CalcSurplusPoint(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577), lv)) << 1)) + ([TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577)+0x10] eq 1 ? SkillMasteryBase.GetMasteryParam(MasteryId.LimitTimeUp) : (SkillMasteryBase.GetMasteryParam(MasteryId.LimitTimeUp) * 0.5)))` s [TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577) ne 0]; `(10 + ((((ExSkillCallGolem.CalcSurplusPoint(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577), lv) & 255) << 2) + ExSkillCallGolem.CalcSurplusPoint(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577), lv)) << 1))` s [TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577) ne 0]; `10` s [TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577) eq 0]; `((10 + (((Lv << 2) + lv) << 1)) + (golemType eq 1 ? SkillMasteryBase.GetMasteryParam(MasteryId.LimitTimeUp) : (SkillMasteryBase.GetMasteryParam(MasteryId.LimitTimeUp) * 0.5)))` s; `(10 + (((Lv << 2) + lv) << 1))` s
- `MobLastDamageRateBuf` = `((10 + ExSkillCallGolem.GetPoint(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577), lv, 1)))`
- `AspdRate` = `(((((ExSkillCallGolem.GetPoint(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577), lv, 2) & 255) << 4) - ExSkillCallGolem.GetPoint(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577), lv, 2)) + 0xffffffe7))` _(when GolemBonus ne 0)_
- `AspdRate` = `0` _(when GolemBonus eq 0)_
- `Value` = `([TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577)+0x10])`
- Buff fields set in the constructor (all recovered):
  - `GolemBonus` = `0`
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `damageCut` = `(10 + ExSkillCallGolem.GetPoint(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577), lv, 1))` when TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577) ne 0
  - `damageCut` = `ExSkillCallGolem.GetPoint(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577), lv, 1)` when TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577) ne 0
  - `damageCut` = `0`
  - `aspdRate` = `((((ExSkillCallGolem.GetPoint(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577), lv, 2) & 255) << 4) - ExSkillCallGolem.GetPoint(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577), lv, 2)) + 0xffffffe7)` when TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577) ne 0
  - `aspdRate` = `(((ExSkillCallGolem.GetPoint(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577), lv, 2) & 255) << 4) - ExSkillCallGolem.GetPoint(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577), lv, 2))` when TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577) ne 0
  - `aspdRate` = `((((ExSkillCallGolem.GetPoint(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577), lv, 2) & 255) << 4) - ExSkillCallGolem.GetPoint(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577), lv, 2)) + 25)` when TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577) ne 0
  - `aspdRate` = `0`
  - `golemType` = `[TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577)+0x10]` when TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577) ne 0
- Hook `set_GolemBonus`: `GolemBonus`=(value & 1)
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

<details><summary>Effect applied in `GameManager$$PlayerSkillUpdate` (30 guarded paths)</summary>

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

<details><summary>Effect applied in `PlayerSecondaryStatus$$get_AtkMpRecovery` (300 guarded paths, truncated)</summary>

- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 577, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `0`
  - calls `virtual CharacterActionManagerBase.get_IsValid`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 577, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 41, stkp(-72), 0) & 1) ne 0`
  - returns `int((((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 52, 0, ?x3) / 100) + 1) * ((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 34, 0, ?x3) / 100)) + (GemCartBufferManager.GetBufferValue(?blr, 7, 0, ?x3) / 100)) * ((SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1090, stkp(-72), 0) & 1) ne 0 ? (EquipItemData.WeaponTypeCalculatorBase.get_WeaponType([CharacterActionManagerBase.set_DefaultMoveSpeed()+0x18], 0, ?x2, ?x3) eq 16 ? 0 : ((System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue([CharacterActionManagerBase.get_IsDeadOrLocalDead()+0x68], 133, stkp(-88), meta(0x3974490, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.TryGetValue())) & 1) ne 0 ? ((max((PlayerSecondaryStatus.CalcBaseMaxMp(this, ?x1, ?x2, ?x3) lt 2000 ? PlayerSecondaryStatus.CalcBaseMaxMp(this, ?x1, ?x2, ?x3) : 2000), 0) // 100) + 10) : 0)) : 0)) + TryGetBuf.out2())))`
  - calls `virtual CharacterActionManagerBase.get_IsValid`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 577, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 41, stkp(-72), 0) & 1) ne 0`
  - returns `int(((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 34, 0, ?x3) / 100)) + (GemCartBufferManager.GetBufferValue(?blr, 7, 0, ?x3) / 100)) * ((SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1090, stkp(-72), 0) & 1) ne 0 ? (EquipItemData.WeaponTypeCalculatorBase.get_WeaponType([CharacterActionManagerBase.set_DefaultMoveSpeed()+0x18], 0, ?x2, ?x3) eq 16 ? 0 : ((System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue([CharacterActionManagerBase.get_IsDeadOrLocalDead()+0x68], 133, stkp(-88), meta(0x3974490, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.TryGetValue())) & 1) ne 0 ? ((max((PlayerSecondaryStatus.CalcBaseMaxMp(this, ?x1, ?x2, ?x3) lt 2000 ? PlayerSecondaryStatus.CalcBaseMaxMp(this, ?x1, ?x2, ?x3) : 2000), 0) // 100) + 10) : 0)) : 0)) + TryGetBuf.out2()))`
  - calls `virtual CharacterActionManagerBase.get_IsValid`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 577, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 41, stkp(-72), 0) & 1) ne 0`
  - returns `int((((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 52, 0, ?x3) / 100) + 1) * ((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 34, 0, ?x3) / 100)) + (GemCartBufferManager.GetBufferValue(?blr, 7, 0, ?x3) / 100)) * ((SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1090, stkp(-72), 0) & 1) ne 0 ? (EquipItemData.WeaponTypeCalculatorBase.get_WeaponType([CharacterActionManagerBase.set_DefaultMoveSpeed()+0x18], 0, ?x2, ?x3) eq 16 ? 0 : ((System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue([CharacterActionManagerBase.get_IsDeadOrLocalDead()+0x68], 133, stkp(-88), meta(0x3974490, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.TryGetValue())) & 1) ne 0 ? ((max((PlayerSecondaryStatus.CalcBaseMaxMp(this, ?x1, ?x2, ?x3) lt 2000 ? PlayerSecondaryStatus.CalcBaseMaxMp(this, ?x1, ?x2, ?x3) : 2000), 0) // 100) + 10) : 0)) : 0)) + TryGetBuf.out2())))`
  - calls `virtual CharacterActionManagerBase.get_IsValid`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 577, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 41, stkp(-72), 0) & 1) ne 0`
  - returns `int(((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 34, 0, ?x3) / 100)) + (GemCartBufferManager.GetBufferValue(?blr, 7, 0, ?x3) / 100)) * ((SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1090, stkp(-72), 0) & 1) ne 0 ? (EquipItemData.WeaponTypeCalculatorBase.get_WeaponType([CharacterActionManagerBase.set_DefaultMoveSpeed()+0x18], 0, ?x2, ?x3) eq 16 ? 0 : ((System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue([CharacterActionManagerBase.get_IsDeadOrLocalDead()+0x68], 133, stkp(-88), meta(0x3974490, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.TryGetValue())) & 1) ne 0 ? ((max((PlayerSecondaryStatus.CalcBaseMaxMp(this, ?x1, ?x2, ?x3) lt 2000 ? PlayerSecondaryStatus.CalcBaseMaxMp(this, ?x1, ?x2, ?x3) : 2000), 0) // 100) + 10) : 0)) : 0)) + TryGetBuf.out2()))`
  - calls `virtual CharacterActionManagerBase.get_IsValid`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 577, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 41, stkp(-72), 0) & 1) ne 0`
  - returns `int((((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 52, 0, ?x3) / 100) + 1) * ((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 34, 0, ?x3) / 100)) + (GemCartBufferManager.GetBufferValue(?blr, 7, 0, ?x3) / 100)) * (EquipItemData.WeaponTypeCalculatorBase.get_WeaponType([CharacterActionManagerBase.set_DefaultMoveSpeed()+0x18], 0, ?x2, ?x3) eq 16 ? 0 : ((System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue([CharacterActionManagerBase.get_IsDeadOrLocalDead()+0x68], 133, stkp(-88), meta(0x3974490, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.TryGetValue())) & 1) ne 0 ? ((max((PlayerSecondaryStatus.CalcBaseMaxMp(this, ?x1, ?x2, ?x3) lt 2000 ? PlayerSecondaryStatus.CalcBaseMaxMp(this, ?x1, ?x2, ?x3) : 2000), 0) // 100) + 10) : 0))) + TryGetBuf.out2())))`
  - calls `virtual CharacterActionManagerBase.get_IsValid`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 577, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 41, stkp(-72), 0) & 1) ne 0`
  - returns `int(((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 34, 0, ?x3) / 100)) + (GemCartBufferManager.GetBufferValue(?blr, 7, 0, ?x3) / 100)) * (EquipItemData.WeaponTypeCalculatorBase.get_WeaponType([CharacterActionManagerBase.set_DefaultMoveSpeed()+0x18], 0, ?x2, ?x3) eq 16 ? 0 : ((System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue([CharacterActionManagerBase.get_IsDeadOrLocalDead()+0x68], 133, stkp(-88), meta(0x3974490, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.TryGetValue())) & 1) ne 0 ? ((max((PlayerSecondaryStatus.CalcBaseMaxMp(this, ?x1, ?x2, ?x3) lt 2000 ? PlayerSecondaryStatus.CalcBaseMaxMp(this, ?x1, ?x2, ?x3) : 2000), 0) // 100) + 10) : 0))) + TryGetBuf.out2()))`
  - calls `virtual CharacterActionManagerBase.get_IsValid`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 577, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 41, stkp(-72), 0) & 1) ne 0`
  - returns `int((((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 52, 0, ?x3) / 100) + 1) * ((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 34, 0, ?x3) / 100)) + (GemCartBufferManager.GetBufferValue(?blr, 7, 0, ?x3) / 100)) * (EquipItemData.WeaponTypeCalculatorBase.get_WeaponType([CharacterActionManagerBase.set_DefaultMoveSpeed()+0x18], 0, ?x2, ?x3) eq 16 ? 0 : ((System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue([CharacterActionManagerBase.get_IsDeadOrLocalDead()+0x68], 133, stkp(-88), meta(0x3974490, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.TryGetValue())) & 1) ne 0 ? ((max((PlayerSecondaryStatus.CalcBaseMaxMp(this, ?x1, ?x2, ?x3) lt 2000 ? PlayerSecondaryStatus.CalcBaseMaxMp(this, ?x1, ?x2, ?x3) : 2000), 0) // 100) + 10) : 0))) + TryGetBuf.out2())))`
  - calls `virtual CharacterActionManagerBase.get_IsValid`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`

</details>

<details><summary>Effect applied in `MobaPlayerSecondaryStatus$$get_AtkMpRecovery` (4 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 577, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `0`
  - calls `virtual CharacterActionManagerBase.get_IsValid`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 577, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `int(((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 34, 0, ?x3) / 100)) + (GemCartBufferManager.GetBufferValue(?blr, 7, 0, ?x3) / 100)) * ((MobaPlayerSecondaryStatus.get_MaxMp(this, ?x1, ?x2, ?x3) // 100) + 10)) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 33, 0, ?x3) + GetBonusConstant_Rate.out3())))`
  - calls `virtual CharacterActionManagerBase.get_IsValid`, `MobaPlayerSecondaryStatus$$get_MaxMp`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 577, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual CharacterActionManagerBase.get_IsValid`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 577, stkp(-40), 0) & 1) eq 0`
  - returns `int(((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 34, 0, ?x3) / 100)) + (GemCartBufferManager.GetBufferValue(?blr, 7, 0, ?x3) / 100)) * ((MobaPlayerSecondaryStatus.get_MaxMp(this, ?x1, ?x2, ?x3) // 100) + 10)) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 33, 0, ?x3) + GetBonusConstant_Rate.out3())))`
  - calls `virtual CharacterActionManagerBase.get_IsValid`, `MobaPlayerSecondaryStatus$$get_MaxMp`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`

</details>

<details><summary>Effect applied in `CallGolemNormalAttackAction$$OnInitialize` (173 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 577, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `TryGetExSkillData<object>.out2() ne 0` AND `TryGetValue.out2() ne 0`
  - returns `IPlayerStatusCalculator.get_Aspd(?blr)`
  - set `ActionRange` = `-1`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `golemType` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)`
  - set `isBoost` = `1`
  - set `addHit` = `((?ands * 20) + (CharacterActionManagerBase.get_Size() + addHit))`
  - set `skillRate` = `((max((SkillLv(581) * 0.2), 0) + 2) * (skillRate + ((CharacterActionManagerBase.get_Size() + 20) * ?ands)))`
  - set `addMotionSpeed` = `((CharacterActionManagerBase.get_Size() * ?ands) + addMotionSpeed)`
  - set `_motionSpeed` = `(100 - (int(((max((IPlayerStatusCalculator.get_Aspd(?blr) - 1000), 0) * 0.00555617) + ((CharacterActionManagerBase.get_Size() * ?ands) + addMotionSpeed))) lt 50 ? int(((max((IPlayerStatusCalculator.get_Aspd(?blr) - 1000), 0) * 0.00555617) +`
  - set `SkillIndividualFlag` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)`
  - calls `PlayerStatusBase$$GetEquipElement`, `SkillBufferDataBase$$GetParam`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `CallGolemNormalAttackAction$$InitLancerAttack`, `virtual CharacterActionManagerBase.get_Size`, `ExSkillCallGolem$$GetPoint`
- when `(SkillBufferManager.TryGetBuf(?blr, 577, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `TryGetExSkillData<object>.out2() ne 0` AND `TryGetValue.out2() ne 0`
  - returns `IPlayerStatusCalculator.get_Aspd(?blr)`
  - set `ActionRange` = `-1`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `golemType` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)`
  - set `isBoost` = `1`
  - set `addHit` = `((?ands * 20) + (CharacterActionManagerBase.get_Size() + addHit))`
  - set `skillRate` = `((max((SkillLv(581) * 0.2), 0) + 2) * (skillRate + ((CharacterActionManagerBase.get_Size() + 20) * ?ands)))`
  - set `_motionSpeed` = `(100 - (int(((max((IPlayerStatusCalculator.get_Aspd(?blr) - 1000), 0) * 0.00555617) + addMotionSpeed)) lt 50 ? int(((max((IPlayerStatusCalculator.get_Aspd(?blr) - 1000), 0) * 0.00555617) + addMotionSpeed)) : 50))`
  - set `SkillIndividualFlag` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)`
  - calls `PlayerStatusBase$$GetEquipElement`, `SkillBufferDataBase$$GetParam`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `CallGolemNormalAttackAction$$InitLancerAttack`, `virtual CharacterActionManagerBase.get_Size`, `ExSkillCallGolem$$GetPoint`
- when `(SkillBufferManager.TryGetBuf(?blr, 577, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `TryGetExSkillData<object>.out2() ne 0` AND `TryGetValue.out2() eq 0`
  - set `ActionRange` = `-1`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `golemType` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)`
  - set `isBoost` = `1`
  - calls `PlayerStatusBase$$GetEquipElement`, `SkillBufferDataBase$$GetParam`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `CallGolemNormalAttackAction$$InitLancerAttack`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(?blr, 577, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `TryGetExSkillData<object>.out2() ne 0`
  - returns `IPlayerStatusCalculator.get_Aspd(?blr)`
  - set `ActionRange` = `-1`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `golemType` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)`
  - set `isBoost` = `1`
  - set `skillRate` = `((max((SkillLv(581) * 0.2), 0) + 2) * (skillRate + (20 * ?ands)))`
  - set `addHit` = `((?ands * 20) + addHit)`
  - set `addMotionSpeed` = `((CharacterActionManagerBase.get_Size() * ?ands) + addMotionSpeed)`
  - set `_motionSpeed` = `(100 - (int(((max((IPlayerStatusCalculator.get_Aspd(?blr) - 1000), 0) * 0.00555617) + ((CharacterActionManagerBase.get_Size() * ?ands) + addMotionSpeed))) lt 50 ? int(((max((IPlayerStatusCalculator.get_Aspd(?blr) - 1000), 0) * 0.00555617) +`
  - set `SkillIndividualFlag` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)`
  - calls `PlayerStatusBase$$GetEquipElement`, `SkillBufferDataBase$$GetParam`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `CallGolemNormalAttackAction$$InitLancerAttack`, `ExSkillCallGolem$$GetPoint`, `ExSkillCallGolem$$GetPoint`
- when `(SkillBufferManager.TryGetBuf(?blr, 577, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `TryGetExSkillData<object>.out2() ne 0`
  - set `ActionRange` = `-1`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `golemType` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)`
  - set `isBoost` = `1`
  - set `skillRate` = `(skillRate + (20 * ?ands))`
  - set `addHit` = `((?ands * 20) + addHit)`
  - calls `PlayerStatusBase$$GetEquipElement`, `SkillBufferDataBase$$GetParam`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `CallGolemNormalAttackAction$$InitLancerAttack`, `ExSkillCallGolem$$GetPoint`, `ExSkillCallGolem$$GetPoint`
- when `(SkillBufferManager.TryGetBuf(?blr, 577, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `TryGetExSkillData<object>.out2() ne 0`
  - returns `IPlayerStatusCalculator.get_Aspd(?blr)`
  - set `ActionRange` = `-1`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `golemType` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)`
  - set `isBoost` = `1`
  - set `skillRate` = `((max((SkillLv(581) * 0.2), 0) + 2) * (skillRate + (20 * ?ands)))`
  - set `addHit` = `((?ands * 20) + addHit)`
  - set `_motionSpeed` = `(100 - (int(((max((IPlayerStatusCalculator.get_Aspd(?blr) - 1000), 0) * 0.00555617) + addMotionSpeed)) lt 50 ? int(((max((IPlayerStatusCalculator.get_Aspd(?blr) - 1000), 0) * 0.00555617) + addMotionSpeed)) : 50))`
  - set `SkillIndividualFlag` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)`
  - calls `PlayerStatusBase$$GetEquipElement`, `SkillBufferDataBase$$GetParam`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `CallGolemNormalAttackAction$$InitLancerAttack`, `ExSkillCallGolem$$GetPoint`, `ExSkillCallGolem$$GetPoint`
- when `(SkillBufferManager.TryGetBuf(?blr, 577, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `TryGetExSkillData<object>.out2() eq 0`
  - returns `IPlayerStatusCalculator.get_Aspd(?blr)`
  - set `ActionRange` = `-1`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `golemType` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)`
  - set `isBoost` = `1`
  - set `skillRate` = `((max((SkillLv(581) * 0.2), 0) + 2) * skillRate)`
  - set `_motionSpeed` = `(100 - (int(((max((IPlayerStatusCalculator.get_Aspd(?blr) - 1000), 0) * 0.00555617) + addMotionSpeed)) lt 50 ? int(((max((IPlayerStatusCalculator.get_Aspd(?blr) - 1000), 0) * 0.00555617) + addMotionSpeed)) : 50))`
  - set `SkillIndividualFlag` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)`
  - calls `PlayerStatusBase$$GetEquipElement`, `SkillBufferDataBase$$GetParam`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `CallGolemNormalAttackAction$$InitLancerAttack`, `interface IPlayerStatusCalculator.get_Aspd`
- when `(SkillBufferManager.TryGetBuf(?blr, 577, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `TryGetExSkillData<object>.out2() ne 0` AND `TryGetValue.out2() ne 0`
  - returns `IPlayerStatusCalculator.get_Aspd(?blr)`
  - set `ActionRange` = `-1`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `golemType` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)`
  - set `isBoost` = `1`
  - set `addHit` = `((?ands * 20) + (CharacterActionManagerBase.get_Size() + addHit))`
  - set `skillRate` = `(skillRate + ((CharacterActionManagerBase.get_Size() + 20) * ?ands))`
  - set `addMotionSpeed` = `((CharacterActionManagerBase.get_Size() * ?ands) + addMotionSpeed)`
  - set `_motionSpeed` = `(100 - (int(((max((IPlayerStatusCalculator.get_Aspd(?blr) - 1000), 0) * 0.00555617) + ((CharacterActionManagerBase.get_Size() * ?ands) + addMotionSpeed))) lt 50 ? int(((max((IPlayerStatusCalculator.get_Aspd(?blr) - 1000), 0) * 0.00555617) +`
  - set `SkillIndividualFlag` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)`
  - calls `PlayerStatusBase$$GetEquipElement`, `SkillBufferDataBase$$GetParam`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `virtual CharacterActionManagerBase.get_Size`, `ExSkillCallGolem$$GetPoint`, `virtual CharacterActionManagerBase.get_Size`

</details>

<details><summary>Effect applied in `MainPlayer$$PlayerDead` (168 guarded paths, truncated)</summary>

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

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `CallGolemAction$$EnchantEnd (TryGetBuf)`
- `CallGolemActionManager$$BattleReservation (GetSkillLv)`
- `CallGolemActionManager$$CalcMoveSpeed (GetSkillLv)`
- `CallGolemBuf$$GetDamageResistRate (TryGetBuf)`
- `CallGolemNormalAttackAction$$OnInitialize (TryGetBuf)`
- `GameManager$$PlayerSkillUpdate (GetSkillLv)`
- `GameManager$$ReceiveSummons (GetSkillLv)`
- `MainPlayer$$PlayerDead (ContainsBuffer)`
- `MobaPlayerSecondaryStatus$$get_AtkMpRecovery (TryGetBuf)`
- `PlayerSecondaryStatus$$get_AtkMpRecovery (TryGetBuf)`
- `UIExSkillManager$$ExSkillList (GetSkillLv)`
- `UIGolemExSkillManager.<Start>d__30$$MoveNext (GetSkillLv)`
- `UISkillTreeManager$$SkillTreeList (GetSkillLv)`

---

### ระเบิดเวทมนตร์ (MagicGrenade) · uid 584

<img src="../../icons/sk_584.png" width="40" alt="icon"> 
**Tree:** ゴーレムスキル (`GolemSkill`, tier 1) · **Type:** Attack · **Max Lv:** 1 · **Weapons:** Bowgun, Shield, MainHand · **Flags:** NoMarketSearch · **Client class:** `MagicGrenadeAction`

> ทำให้พลังเวทของหลอดพลังเกินขีดจำกัดแล้วใช้เป็นระเบิด
> 
> โจมตีเป็นวงกว้างแต่จะไม่ถึง
> หากเป้าหมายอยู่ไกลเกินไป
> พลังโจมตีจะเพิ่มขึ้นอีกตามค่า INT หรือ TEC

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(skillRate / 100)`
- Flat dmg + `constantDamage`

**Role:** attack (deals damage)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; never (IsExpDefFluctuate=false)

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `constantDamage`
- `SkillRate` multiplies by (adds into): `(skillRate / 100)`

**Mechanics recovered from code**

- **Loop / hit-repeat count** (`LoopParam`): `Lv` = 1

**Proration:** slot `Magic`, mode `never (IsExpDefFluctuate=false)`, attack type `Magic`, action id 584

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(100)`
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `LoopParam` = `Lv` = 1

**`calcPlayerToMobDamage`** (2 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `constantDamage`
- info `templates` = `1`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`
- set `maxThrowingDistance` = `MathUtil.DisplayMeterToDistance(((motionSpeed * 0.5) + 3))`

</details>

<details><summary>Effect applied in `FlashGrenadeAction$$OnInitialize` (1 guarded path)</summary>

- always
  - returns `SkillLv(584)`
  - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `percent` = `((Lv + (Lv << 2)) << 1)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `LoopParam` = `SkillLv(584)`
  - calls `PlayerAttackBase$$GetWeaponType`, `MathUtil$$DisplayMeterToDistance`, `PlayerStatusBase$$GetEquipElement`, `GolemGrenadeSkillBase$$GetMagicGrenadeParameter`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`

</details>

<details><summary>Effect applied in `FreezeGrenadeAction$$OnInitialize` (1 guarded path)</summary>

- always
  - returns `SkillLv(584)`
  - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
  - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
  - set `percent` = `((Lv + (Lv << 2)) << 1)`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `LoopParam` = `SkillLv(584)`
  - calls `PlayerAttackBase$$GetWeaponType`, `MathUtil$$DisplayMeterToDistance`, `PlayerStatusBase$$GetEquipElement`, `GolemGrenadeSkillBase$$GetMagicGrenadeParameter`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`

</details>

<details><summary>Effect applied in `GolemGrenadeSkillBase$$GetMagicGrenadeParameter` (2 guarded paths)</summary>

- when `SkillLv(584) gt 0`
  - returns `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `GolemGrenadeSkillBase$$CalcSkillRate`, `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`
- when `SkillLv(584) le 0`
  - returns `SkillLv(584)`
  - calls `virtual PlayerStatusBase.get_SkillManager`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `FlashGrenadeAction$$OnInitialize (GetSkillLv)`
- `FreezeGrenadeAction$$OnInitialize (GetSkillLv)`
- `GolemGrenadeSkillBase$$GetMagicGrenadeParameter (GetSkillLv)`

---

### แลนเซอร์พลัส (LancerTypeImproved) · uid 578

<img src="../../icons/sk_578.png" width="40" alt="icon"> 
**Tree:** ゴーレムスキル (`GolemSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 200 · **Weapons:** Bowgun, Rod, MainMagictool · **Requires:** อัญเชิญโกเล็ม · **Flags:** NoMarketSearch · **Client class:** `LancerTypeImproved` (passive mastery)

> เพิ่มประสิทธิภาพของโกเล็มประเภทแลนเซอร์
> 
> พลังเจาะเข้าและอัตราคริติคอลของโกเล็มจะเพิ่มขึ้น
> สำหรับประเภทชีลด์และบัสเตอร์ก็จะเพิ่มขึ้นเพียงเล็กน้อย

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| PowerResistBreaker | 12 | 19 | 26 | 33 | 40 | 47 | 54 | 61 | 68 | 75 |
| Crt | 7 | 15 | 22 | 30 | 37 | 45 | 52 | 60 | 67 | 75 |


---

### ชีลด์พลัส (ShieldTypeImproved) · uid 579

<img src="../../icons/sk_579.png" width="40" alt="icon"> 
**Tree:** ゴーレムスキル (`GolemSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 200 · **Weapons:** Bowgun, Rod, MainMagictool · **Requires:** อัญเชิญโกเล็ม · **Flags:** NoMarketSearch · **Client class:** `ShieldTypeImproved` (passive mastery)

> เพิ่มประสิทธิภาพของโกเล็มประเภทชีลด์
> 
> ระยะเวลาคงอยู่และระยะการลดความเสียหายของโกเล็มจะเพิ่มขึ้น
> สำหรับประเภทแลนเซอร์และบัสเตอร์ก็จะเพิ่มขึ้นเพียงเล็กน้อย

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| LimitTimeUp | 8 | 16 | 24 | 32 | 40 | 48 | 56 | 64 | 72 | 80 |
| Value | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |


---

### บัสเตอร์พลัส (BusterTypeImproved) · uid 580

<img src="../../icons/sk_580.png" width="40" alt="icon"> 
**Tree:** ゴーレムスキル (`GolemSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 200 · **Weapons:** Bowgun, Rod, MainMagictool · **Requires:** อัญเชิญโกเล็ม · **Flags:** NoMarketSearch · **Client class:** `BusterTypeImproved` (passive mastery)

> เพิ่มประสิทธิภาพของโกเล็มประเภทบัสเตอร์
> 
> พลังเจาะเข้าและอัตราคริติคอลของโกเล็มจะเพิ่มขึ้น
> สำหรับประเภทแลนเซอร์และชีลด์จะเพิ่มขึ้นเพียงเล็กน้อย

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| PowerResistBreaker | 12 | 19 | 26 | 33 | 40 | 47 | 54 | 61 | 68 | 75 |
| Crt | 7 | 15 | 22 | 30 | 37 | 45 | 52 | 60 | 67 | 75 |


---

### ระเบิดเยือกแข็ง (FreezeGrenade) · uid 585

<img src="../../icons/sk_585.png" width="40" alt="icon"> 
**Tree:** ゴーレムスキル (`GolemSkill`, tier 2) · **Type:** Attack · **Max Lv:** 200 · **Weapons:** Bowgun, Shield, MainHand · **Requires:** ระเบิดเวทมนตร์ · **Flags:** NoMarketSearch · **Client class:** `FreezeGrenadeAction`

> เติมพลังเวทเยือกแข็งลงในหลอดพลัง
> 
> พลังโจมตีขึ้นอยู่กับระเบิดเวทมนตร์ที่เรียนรู้มา
> มีโอกาสติด "แช่แข็ง" แต่
> หากโดนระเบิดตัวเองก็มีโอกาสเล็กน้อยที่จะถูกแช่แข็งไปด้วย

<details><summary>In-game level notes</summary>

- Lv17: เมื่อติดตั้งโล่จะต้านทานแช่แข็งได้ด้วยการต้านภาวะผิดปกติของคุณเอง
- Lv254: [ผลลัพธ์ต่อไปนี้ใช้ได้เมื่อติดตั้งเป็นอุปกรณ์หลักเท่านั้น] ขณะสกิลชี่กงฟื้นฟูทำงานจะต้านทานแช่แข็ง ได้ด้วยการต้านภาวะผิดปกติของคุณเอง

</details>

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(skillRate / 100)`
- Flat dmg + `constantDamage`

**Role:** attack (deals damage) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; never (IsExpDefFluctuate=false)

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `constantDamage`
- `SkillRate` multiplies by (adds into): `(skillRate / 100)`

**Mechanics recovered from code**

- **Effect percent** (`percent`): `((Lv + (Lv << 2)) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]
- **Loop / hit-repeat count** (`LoopParam`): `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 584, 1)`

**Proration:** slot `Magic`, mode `never (IsExpDefFluctuate=false)`, attack type `Magic`, action id 585

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(100)`
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `percent` = `((Lv + (Lv << 2)) << 1)` → Lv1..10: [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]
- set `LoopParam` = `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 584, 1)`

**`ActionSkillEvent`** (7 paths)

- calls `AbnormalStateManager.GetDefaultAnbormalStateTime` = `GetDefaultAnbormalStateTime()` — when EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 17 AND FreezeGrenadeAction.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), UnityEngine.Component.get_transform(actarAction), 0) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 200 OR EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 17 AND FreezeGrenadeAction.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), UnityEngine.Component.get_transform(actarAction), 0) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1093) AND param eq 200 OR !hasBuff(1093) AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 17 AND FreezeGrenadeAction.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), UnityEngine.Component.get_transform(actarAction), 0) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 200

**`calcPlayerToMobDamage`** (6 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `constantDamage`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(9, percent, playerAction)` — when PlayerAttackBase.checkAbnormalPercent(this, 9, percent, playerAction) AND SkillActionBase.DamageData.CheckEffectiveAbnormal(PlayerAttackBase.templateToDamageData(this, new SkillActionBase.DamageData, PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 1)) OR !PlayerAttackBase.checkAbnormalPercent(this, 9, percent, playerAction) AND SkillActionBase.DamageData.CheckEffectiveAbnormal(PlayerAttackBase.templateToDamageData(this, new SkillActionBase.DamageData, PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 1))
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(9, 0)` — when PlayerAttackBase.checkAbnormalPercent(this, 9, percent, playerAction) AND SkillActionBase.DamageData.CheckEffectiveAbnormal(PlayerAttackBase.templateToDamageData(this, new SkillActionBase.DamageData, PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 1))
- info `templates` = `1`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`
- set `maxThrowingDistance` = `MathUtil.DisplayMeterToDistance(((motionSpeed * 0.5) + 3))`

</details>

---

### บาเรียสกรีน (BarrierScreen) · uid 587

<img src="../../icons/sk_587.png" width="40" alt="icon"> 
**Tree:** ゴーレムスキル (`GolemSkill`, tier 2) · **Type:** Object · **Max Lv:** 200 · **Weapons:** Bowgun, Shield · **Requires:** ระเบิดเวทมนตร์ · **Flags:** NoMarketSearch · **Client class:** `BarrierScreenAction`

> ติดตั้งโดรนกางเมจิกบาเรีย
> ช่วยลดความรุนแรงของการโจมตีแนวตรง, กระสุน
> ของมีคมประเภทซัดที่ผ่านบาเรียได้หนึ่งครั้ง
> *มีการโจมตีบางประเภทที่ไม่สามารถลดความเสียหายได้
> ระหว่างติดตั้งการฟื้นฟู MP การโจมตีจะลดลง

**Role:** buff (self) · placed object / trap / summon

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 587

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(100)`
- set `time` = `(((Lv + (Lv << 1)) << 2) lo 60 ? ((Lv + (Lv << 1)) << 2) : 60)` → Lv1..10: [12, 24, 36, 48, 60, 60, 60, 60, 60, 60]
- set `reduceDamageValue` = `((Lv << 2) hi 20 ? (Lv << 2) : 20)` → Lv1..10: [20, 20, 20, 20, 20, 24, 28, 32, 36, 40]

**`ActionStart`** (8 paths)

- set `archetypeUid` = `IUserArchetype.get_ArchetypeUid(UnityEngine.Component.GetComponent<IUserArchetype>(actarAction))` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND UnityEngine.Object.op_Inequality(actarAction) AND max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 588, 1), 0) ge 1 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND UnityEngine.Object.op_Inequality(actarAction) AND max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 588, 1), 0) lt 1 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 588, 1), 0) ge 1
- set `placePos` = `(UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x + (UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(actarAction)).x + UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(actarAction)).x))` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND UnityEngine.Object.op_Inequality(actarAction) AND max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 588, 1), 0) ge 1 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND UnityEngine.Object.op_Inequality(actarAction) AND max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 588, 1), 0) lt 1 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 588, 1), 0) ge 1
- set `placePos.y` = `(UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y + (UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(actarAction)).y + UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(actarAction)).y))` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND UnityEngine.Object.op_Inequality(actarAction) AND max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 588, 1), 0) ge 1 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND UnityEngine.Object.op_Inequality(actarAction) AND max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 588, 1), 0) lt 1 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 588, 1), 0) ge 1
- set `placePos.z` = `(UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z + (UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(actarAction)).z + UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(actarAction)).z))` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND UnityEngine.Object.op_Inequality(actarAction) AND max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 588, 1), 0) ge 1 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND UnityEngine.Object.op_Inequality(actarAction) AND max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 588, 1), 0) lt 1 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 588, 1), 0) ge 1
- set `reduceDamageValue` = `(reduceDamageValue + max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 588, 1), 0))` — when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND UnityEngine.Object.op_Inequality(actarAction) AND max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 588, 1), 0) ge 1 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 588, 1), 0) ge 1 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 AND max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 588, 1), 0) ge 1

**`ActionSkillEvent`** (9 paths)

- set `state` = `1` = 1 — when param eq 100 AND param ne 10 AND param ne 101 AND state eq 0
- calls `BarrierScreenBuf..ctor` = `.ctor(Lv, max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 588, 1), 0))` — when IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 10
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new BarrierScreenBuf, Id)` — when IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 10

**`OnDamage`** (2 paths)

- set `state` = `2` = 2 — when state ne 2

**`Break`** (1 path)

- set `state` = `2` = 2

**`InitializeOthers`** (1 path)

- set `archetypeUid` = `IOtherPlayerActionManager.get_ArchetypeUid(actarAction)`
- set `isMine` = `0` = 0
- set `placePos` = `castTime`

**`ActionStartOthers`** (1 path)

- set `time` = `((((SkillIndividualFlag >> 24) + ((SkillIndividualFlag >> 24) << 1)) << 2) lo 60 ? (((SkillIndividualFlag >> 24) + ((SkillIndividualFlag >> 24) << 1)) << 2) : 60)`
- set `reduceDamageValue` = `((((SkillIndividualFlag >> 24) << 2) hi 20 ? ((SkillIndividualFlag >> 24) << 2) : 20) + ((255 & SkillIndividualFlag) eq 0 ? 0 : ?ubfx))`

**`ReceiveOtherSkillEvent`** (12 paths)

- calls `Toram.Common.ArchetypeUid..ctor` = `.ctor(0, System.Collections.Generic.Dictionary<int, int>.get_Item(skillEventData.Value, 21, meta(0x3974b60, Method$System.Collections.Generic.Dictionary<int, int>.get_Item())))` — when (System.Collections.Generic.Dictionary<int, int>.ContainsKey(skillEventData.Value, 21, meta(0x39823b0, Method$System.Collections.Generic.Dictionary<int, int>.ContainsKey())) & 1) ne 0 AND skillEventData.SkillEventId eq 200 AND skillEventData.SkillID eq 587 OR (System.Collections.Generic.Dictionary<int, int>.ContainsKey(skillEventData.Value, 21, meta(0x39823b0, Method$System.Collections.Generic.Dictionary<int, int>.ContainsKey())) & 1) ne 0 AND SkillActionBase.op_Inequality(0) AND skillEventData.SkillEventId eq 200 AND skillEventData.SkillID eq 587 OR !SkillActionBase.op_Inequality(0) AND (System.Collections.Generic.Dictionary<int, int>.ContainsKey(skillEventData.Value, 21, meta(0x39823b0, Method$System.Collections.Generic.Dictionary<int, int>.ContainsKey())) & 1) ne 0 AND skillEventData.SkillEventId eq 200 AND skillEventData.SkillID eq 587

</details>

**Buffs**

**Buff `BarrierScreenBuf`**
- `AttackMprecoveryUpRate` = `((int(((modifyLevel & 255) * 2.5)) - 50))`
- `Value` = `int(time)`
- Buff fields set in the constructor (all recovered):
  - `atkMpHeal` = `(int(((modifyLevel & 255) * 2.5)) - 50)`
- Hook `Updata`: `time`=(time + UnityEngine.Time.get_deltaTime())
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:BarrierScreenBuf$$.ctor<-BarrierScreenAction$$ActionSkillEvent` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

---

### เสริมพลังโจมตี (AttackPerformanceImprovement) · uid 581

<img src="../../icons/sk_581.png" width="40" alt="icon"> 
**Tree:** ゴーレムスキル (`GolemSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Bowgun, Rod, MainMagictool · **Requires:** แลนเซอร์พลัส · **Flags:** NoMarketSearch · **Client class:** `AttackPerformanceImprovement` (passive mastery)

> ปรับปรุงหลอดพลังเพื่อเพิ่มประสิทธิภาพการโจมตี
> 
> ค่าพลังที่แบ่งไปที่การโจมตีจะเพิ่มขึ้น
> และค่าความแม่นจะเพิ่มขึ้นตลอดเวลา
> โดยไม่ขึ้นอยู่กับการแบ่งพลัง

<details><summary>In-game level notes</summary>

- Lv13: [สามารถใช้ผลแบบเดียวกันทั้งกับไม้เท้าและอุปกรณ์เวทมนตร์] หากใช้งานสกิล[อัญเชิญโกเล็ม]ซ้ำในขณะที่เรียกโกเล็มออกมาอยู่ จะติดบัฟเพิ่มพลังโจมตีให้โกเล็มได้ 1 ครั้ง

</details>

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |
| Hit | 2 | 8 | 18 | 32 | 50 | 72 | 98 | 128 | 162 | 200 |


**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `CallGolemNormalAttackAction$$OnInitialize (GetSkillLv)`

---

### เสริมพลังป้องกัน (ShieldPerformanceImprovement) · uid 582

<img src="../../icons/sk_582.png" width="40" alt="icon"> 
**Tree:** ゴーレムスキル (`GolemSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Bowgun, Rod, MainMagictool · **Requires:** ชีลด์พลัส · **Flags:** NoMarketSearch · **Client class:** `ShieldPerformanceImprovement` (passive mastery)

> ปรับปรุงหลอดพลังเพื่อเพิ่มประสิทธิภาพโล่
> 
> ค่าพลังที่แบ่งไปที่โล่จะเพิ่มขึ้น
> และระยะลดความเสียหายจะเพิ่มขึ้นตลอดเวลา
> โดยไม่ขึ้นอยู่กับการแบ่งพลัง

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MobAttackLastDamageRate | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |
| Value | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |


---

### เสริมความเร็ว (SpeedPerformanceImprovement) · uid 583

<img src="../../icons/sk_583.png" width="40" alt="icon"> 
**Tree:** ゴーレムスキル (`GolemSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Bowgun, Rod, MainMagictool · **Requires:** บัสเตอร์พลัส · **Flags:** NoMarketSearch · **Client class:** `SpeedPerformanceImprovement` (passive mastery)

> ปรับปรุงหลอดพลังเพื่อเพิ่มประสิทธิภาพความเร็ว
> 
> ค่าพลังที่แบ่งไปที่ความเร็ว
> จะทำให้ความเร็วการเคลื่อนที่เพิ่มขึ้น

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Aspd | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


---

### ระเบิดแสง (FlashGrenade) · uid 586

<img src="../../icons/sk_586.png" width="40" alt="icon"> 
**Tree:** ゴーレムスキル (`GolemSkill`, tier 3) · **Type:** Attack · **Max Lv:** 250 · **Weapons:** Bowgun, Shield, MainHand · **Requires:** ระเบิดเยือกแข็ง · **Flags:** NoMarketSearch · **Client class:** `FlashGrenadeAction`

> เติมพลังเวทแสงลงในหลอดพลัง
> 
> ความเสียหายขึ้นอยู่กับระเบิดเวทมนตร์ที่เรียนรู้มา
> มีโอกาสติด "ตาพร่า แต่
> หากโดนระเบิดตัวเองก็มีโอกาสเล็กน้อยที่จะตาพร่าไปด้วย

<details><summary>In-game level notes</summary>

- Lv17: เมื่อติดตั้งโล่จะต้านทานตาพร่าได้ด้วยการต้านภาวะผิดปกติของคุณเอง
- Lv254: [ผลลัพธ์ต่อไปนี้ใช้ได้เมื่อติดตั้งเป็นอุปกรณ์หลักเท่านั้น] ขณะสกิลชี่กงฟื้นฟูทำงานจะต้านทานตาพร่า ได้ด้วยการต้านภาวะผิดปกติของคุณเอง

</details>

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(skillRate / 100)`
- Flat dmg + `constantDamage`

**Role:** attack (deals damage) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; never (IsExpDefFluctuate=false)

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `constantDamage`
- `SkillRate` multiplies by (adds into): `(skillRate / 100)`

**Mechanics recovered from code**

- **Effect percent** (`percent`): `((Lv + (Lv << 2)) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]
- **Loop / hit-repeat count** (`LoopParam`): `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 584, 1)`

**Proration:** slot `Magic`, mode `never (IsExpDefFluctuate=false)`, attack type `Magic`, action id 586

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(100)`
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `percent` = `((Lv + (Lv << 2)) << 1)` → Lv1..10: [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]
- set `LoopParam` = `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 584, 1)`

**`ActionSkillEvent`** (7 paths)

- calls `AbnormalStateManager.GetDefaultAnbormalStateTime` = `GetDefaultAnbormalStateTime()` — when EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 17 AND FlashGrenadeAction.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), UnityEngine.Component.get_transform(actarAction), 0) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 200 OR EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 17 AND FlashGrenadeAction.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), UnityEngine.Component.get_transform(actarAction), 0) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1093) AND param eq 200 OR !hasBuff(1093) AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 17 AND FlashGrenadeAction.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), UnityEngine.Component.get_transform(actarAction), 0) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 200

**`calcPlayerToMobDamage`** (6 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `constantDamage`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(33, percent, playerAction)` — when PlayerAttackBase.checkAbnormalPercent(this, 33, percent, playerAction) AND SkillActionBase.DamageData.CheckEffectiveAbnormal(PlayerAttackBase.templateToDamageData(this, new SkillActionBase.DamageData, PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 1)) OR !PlayerAttackBase.checkAbnormalPercent(this, 33, percent, playerAction) AND SkillActionBase.DamageData.CheckEffectiveAbnormal(PlayerAttackBase.templateToDamageData(this, new SkillActionBase.DamageData, PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 1))
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(33, 0)` — when PlayerAttackBase.checkAbnormalPercent(this, 33, percent, playerAction) AND SkillActionBase.DamageData.CheckEffectiveAbnormal(PlayerAttackBase.templateToDamageData(this, new SkillActionBase.DamageData, PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 1))
- info `templates` = `1`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`
- set `maxThrowingDistance` = `MathUtil.DisplayMeterToDistance(((motionSpeed * 0.5) + 3))`

</details>

---

### เสริมบาเรีย (BarrierScreenPerformanceImprovement) · uid 588

<img src="../../icons/sk_588.png" width="40" alt="icon"> 
**Tree:** ゴーレムスキル (`GolemSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Bowgun, Shield · **Requires:** บาเรียสกรีน · **Flags:** NoMarketSearch

> ปรับปรุงบาเรียโดรน
> 
> เพิ่มอัตราการลดทอนความรุนแรงของบาเรียให้สูงขึ้น
> และลดปริมาณการสูญเสียพลังฟื้นฟู
> MP การโจมตีที่ใช้ในการคงสภาพโดรน

**Role:** passive mastery · no client action class (system / production / unreleased)

<details><summary>Effect applied in `BarrierScreenAction$$ActionStart` (4 guarded paths)</summary>

- when `max(SkillLv(588), 0) ge 1`
  - set `archetypeUid` = `IUserArchetype.get_ArchetypeUid(UnityEngine.Component.GetComponent<object>(actarAction, meta(0x3990850, Method$UnityEngine.Component.GetComponent<IUserArchetype>()), ?x2, ?x3))`
  - set `placePos` = `(UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3) + (UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3) + UnityEngine.T`
  - set `+0x12c` = `([meta(0)+0x8] + ([meta(0)+0x8] + [meta(0)+0x8]))`
  - set `+0x130` = `(meta(0) + (meta(0) + meta(0)))`
  - set `reduceDamageValue` = `(reduceDamageValue + max(SkillLv(588), 0))`
  - set `SkillIndividualFlag` = `?bfxil`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `UnityEngine.Component$$GetComponent<object>`, `interface IUserArchetype.get_ArchetypeUid`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`
- when `max(SkillLv(588), 0) lt 1`
  - set `archetypeUid` = `IUserArchetype.get_ArchetypeUid(UnityEngine.Component.GetComponent<object>(actarAction, meta(0x3990850, Method$UnityEngine.Component.GetComponent<IUserArchetype>()), ?x2, ?x3))`
  - set `placePos` = `(UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3) + (UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3) + UnityEngine.T`
  - set `+0x12c` = `([meta(0)+0x8] + ([meta(0)+0x8] + [meta(0)+0x8]))`
  - set `+0x130` = `(meta(0) + (meta(0) + meta(0)))`
  - set `SkillIndividualFlag` = `?bfxil`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `UnityEngine.Component$$GetComponent<object>`, `interface IUserArchetype.get_ArchetypeUid`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`
- when `max(SkillLv(588), 0) ge 1`
  - set `archetypeUid` = `IUserArchetype.get_ArchetypeUid(UnityEngine.Component.GetComponent<object>(actarAction, meta(0x3990850, Method$UnityEngine.Component.GetComponent<IUserArchetype>()), ?x2, ?x3))`
  - set `placePos` = `(UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3) + (UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3) + UnityEngine.T`
  - set `+0x12c` = `(?v1 + (?v1 + ?v1))`
  - set `+0x130` = `(?v2 + (?v2 + ?v2))`
  - set `reduceDamageValue` = `(reduceDamageValue + max(SkillLv(588), 0))`
  - set `SkillIndividualFlag` = `?bfxil`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `UnityEngine.Component$$GetComponent<object>`, `interface IUserArchetype.get_ArchetypeUid`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_forward`
- when `max(SkillLv(588), 0) lt 1`
  - set `archetypeUid` = `IUserArchetype.get_ArchetypeUid(UnityEngine.Component.GetComponent<object>(actarAction, meta(0x3990850, Method$UnityEngine.Component.GetComponent<IUserArchetype>()), ?x2, ?x3))`
  - set `placePos` = `(UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3) + (UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3) + UnityEngine.T`
  - set `+0x12c` = `(?v1 + (?v1 + ?v1))`
  - set `+0x130` = `(?v2 + (?v2 + ?v2))`
  - set `SkillIndividualFlag` = `?bfxil`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `UnityEngine.Component$$GetComponent<object>`, `interface IUserArchetype.get_ArchetypeUid`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_forward`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `BarrierScreenAction$$ActionSkillEvent (GetSkillLv)`
- `BarrierScreenAction$$ActionStart (GetSkillLv)`

---
