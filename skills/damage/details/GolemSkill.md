# ゴーレムスキル (`GolemSkill`) — skill details

12 entries.

### อัญเชิญโกเล็ม (CallGolem) · uid 577

<img src="../../icons/sk_577.png" width="40" alt="icon"> 
**Tree:** ゴーレムスキル (`GolemSkill`, tier 1) · **Type:** Object · **Max Lv:** 1 · **Weapons:** Bowgun, Rod, MainMagictool · **Flags:** NoMarketSearch · **Client class:** `CallGolemAction`

> อัญเชิญโกเล็มมาร่วมต่อสู้
> 
> สูญเสียฟื้นฟู MP การโจมตีของคุณ
> แต่ได้ฟื้นฟู MP จากการโจมตีปกติมาแทน
> เลือกประเภทของโกเล็มและปรับแต่งหลอดพลังด้วย EX สกิล

**How it works**

- Object skill of the ゴーレムスキル tree (tier 1, max Lv 1); usable with Bowgun, Rod, MainMagictool.
- It installs a buff on the caster.
- It places an object in the world (trap, summon or field object).
- Buffs:
  - `CallGolemBuf`: lasts `((10 + ((((ExSkillCallGolem.CalcSurplusPoint(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577), lv) & 255) << 2) + ExSkillCallGolem.CalcSurplusPoint(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577), lv)) << 1)) + ([TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577)+0x10] eq 1 ? SkillMasteryBase.GetMasteryParam(MasteryId.LimitTimeUp) : (SkillMasteryBase.GetMasteryParam(MasteryId.LimitTimeUp) * 0.5)))` s / `(10 + ((((ExSkillCallGolem.CalcSurplusPoint(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577), lv) & 255) << 2) + ExSkillCallGolem.CalcSurplusPoint(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 577), lv)) << 1))` s / `10` s
- Other client code reads this skill (13 lookups; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 577
- No proration slot: ExpType None: no proration slot.

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `AspdRate`: attack speed %
- `MobLastDamageRateBuf`: final damage multiplier vs monsters (buff category)
- `Value`: generic value (meaning set by the code that reads the buff)

**Where else this skill takes effect**

- Effect applied in `GameManager$$PlayerSkillUpdate` (30 guarded paths):
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
- Effect applied in `PlayerSecondaryStatus$$get_AtkMpRecovery` (300 guarded paths, truncated):
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
- Effect applied in `MobaPlayerSecondaryStatus$$get_AtkMpRecovery` (4 guarded paths):
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
- Effect applied in `CallGolemNormalAttackAction$$OnInitialize` (173 guarded paths):
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
- Effect applied in `MainPlayer$$PlayerDead` (168 guarded paths, truncated):
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
- Code that reads this skill's level / buff by constant id: `CallGolemAction$$EnchantEnd (TryGetBuf)`, `CallGolemActionManager$$BattleReservation (GetSkillLv)`, `CallGolemActionManager$$CalcMoveSpeed (GetSkillLv)`, `CallGolemBuf$$GetDamageResistRate (TryGetBuf)`, `CallGolemNormalAttackAction$$OnInitialize (TryGetBuf)`, `GameManager$$PlayerSkillUpdate (GetSkillLv)`, `GameManager$$ReceiveSummons (GetSkillLv)`, `MainPlayer$$PlayerDead (ContainsBuffer)`, `MobaPlayerSecondaryStatus$$get_AtkMpRecovery (TryGetBuf)`, `PlayerSecondaryStatus$$get_AtkMpRecovery (TryGetBuf)`, `UIExSkillManager$$ExSkillList (GetSkillLv)`, `UIGolemExSkillManager.<Start>d__30$$MoveNext (GetSkillLv)`, `UISkillTreeManager$$SkillTreeList (GetSkillLv)`

_Raw recovered data (every method item): [trees/GolemSkill.md](../trees/GolemSkill.md) — uid 577_

---

### ระเบิดเวทมนตร์ (MagicGrenade) · uid 584

<img src="../../icons/sk_584.png" width="40" alt="icon"> 
**Tree:** ゴーレムスキル (`GolemSkill`, tier 1) · **Type:** Attack · **Max Lv:** 1 · **Weapons:** Bowgun, Shield, MainHand · **Flags:** NoMarketSearch · **Client class:** `MagicGrenadeAction`

> ทำให้พลังเวทของหลอดพลังเกินขีดจำกัดแล้วใช้เป็นระเบิด
> 
> โจมตีเป็นวงกว้างแต่จะไม่ถึง
> หากเป้าหมายอยู่ไกลเกินไป
> พลังโจมตีจะเพิ่มขึ้นอีกตามค่า INT หรือ TEC

**How it works**

- Attack skill of the ゴーレムスキル tree (tier 1, max Lv 1); usable with Bowgun, Shield, MainHand.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on live values (formula below); flat damage depends on live values (formula below)
- Proration: magic proration slot, mode `never (IsExpDefFluctuate=false)`.
- Other client code reads this skill (3 lookups; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(100)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 1 info
- `InitializeOthers` — setup used when another player's client replays the action: 3 set

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(skillRate / 100)`
- Flat dmg + `constantDamage`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(skillRate / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `constantDamage`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `never (IsExpDefFluctuate=false)`, attack type `Magic`, action id 584
- Uses the magic proration slot but never changes monster proration: IsExpDefFluctuate=false.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `Lv` = 1

**Other recovered parameters**

- **Loop / hit-repeat count** (`LoopParam`): `Lv` = 1

**Where else this skill takes effect**

- Effect applied in `FlashGrenadeAction$$OnInitialize` (1 guarded path):
  - always
    - returns `SkillLv(584)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `percent` = `((Lv + (Lv << 2)) << 1)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `LoopParam` = `SkillLv(584)`
    - calls `PlayerAttackBase$$GetWeaponType`, `MathUtil$$DisplayMeterToDistance`, `PlayerStatusBase$$GetEquipElement`, `GolemGrenadeSkillBase$$GetMagicGrenadeParameter`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`
- Effect applied in `FreezeGrenadeAction$$OnInitialize` (1 guarded path):
  - always
    - returns `SkillLv(584)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `percent` = `((Lv + (Lv << 2)) << 1)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `LoopParam` = `SkillLv(584)`
    - calls `PlayerAttackBase$$GetWeaponType`, `MathUtil$$DisplayMeterToDistance`, `PlayerStatusBase$$GetEquipElement`, `GolemGrenadeSkillBase$$GetMagicGrenadeParameter`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`
- Effect applied in `GolemGrenadeSkillBase$$GetMagicGrenadeParameter` (2 guarded paths):
  - when `SkillLv(584) gt 0`
    - returns `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `GolemGrenadeSkillBase$$CalcSkillRate`, `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`
  - when `SkillLv(584) le 0`
    - returns `SkillLv(584)`
    - calls `virtual PlayerStatusBase.get_SkillManager`
- Code that reads this skill's level / buff by constant id: `FlashGrenadeAction$$OnInitialize (GetSkillLv)`, `FreezeGrenadeAction$$OnInitialize (GetSkillLv)`, `GolemGrenadeSkillBase$$GetMagicGrenadeParameter (GetSkillLv)`

_Raw recovered data (every method item): [trees/GolemSkill.md](../trees/GolemSkill.md) — uid 584_

---

### แลนเซอร์พลัส (LancerTypeImproved) · uid 578

<img src="../../icons/sk_578.png" width="40" alt="icon"> 
**Tree:** ゴーレムスキル (`GolemSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 200 · **Weapons:** Bowgun, Rod, MainMagictool · **Requires:** อัญเชิญโกเล็ม · **Flags:** NoMarketSearch · **Client class:** `LancerTypeImproved` (passive mastery)

> เพิ่มประสิทธิภาพของโกเล็มประเภทแลนเซอร์
> 
> พลังเจาะเข้าและอัตราคริติคอลของโกเล็มจะเพิ่มขึ้น
> สำหรับประเภทชีลด์และบัสเตอร์ก็จะเพิ่มขึ้นเพียงเล็กน้อย

**How it works**

- Mastery skill of the ゴーレムスキル tree (tier 2, max Lv 200); usable with Bowgun, Rod, MainMagictool.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): PowerResistBreaker (physical pierce) 12 at Lv1 to 75 at Lv10, Crt (critical rate) 7 at Lv1 to 75 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| PowerResistBreaker | 12 | 19 | 26 | 33 | 40 | 47 | 54 | 61 | 68 | 75 |
| Crt | 7 | 15 | 22 | 30 | 37 | 45 | 52 | 60 | 67 | 75 |


Bonus meanings (inferred from the names):

- `PowerResistBreaker`: physical pierce
- `Crt`: critical rate

_Raw recovered data (every method item): [trees/GolemSkill.md](../trees/GolemSkill.md) — uid 578_

---

### ชีลด์พลัส (ShieldTypeImproved) · uid 579

<img src="../../icons/sk_579.png" width="40" alt="icon"> 
**Tree:** ゴーレムスキル (`GolemSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 200 · **Weapons:** Bowgun, Rod, MainMagictool · **Requires:** อัญเชิญโกเล็ม · **Flags:** NoMarketSearch · **Client class:** `ShieldTypeImproved` (passive mastery)

> เพิ่มประสิทธิภาพของโกเล็มประเภทชีลด์
> 
> ระยะเวลาคงอยู่และระยะการลดความเสียหายของโกเล็มจะเพิ่มขึ้น
> สำหรับประเภทแลนเซอร์และบัสเตอร์ก็จะเพิ่มขึ้นเพียงเล็กน้อย

**How it works**

- Mastery skill of the ゴーレムスキル tree (tier 2, max Lv 200); usable with Bowgun, Rod, MainMagictool.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): LimitTimeUp (time limit extension) 8 at Lv1 to 80 at Lv10, Value (generic value) 2 at Lv1 to 20 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| LimitTimeUp | 8 | 16 | 24 | 32 | 40 | 48 | 56 | 64 | 72 | 80 |
| Value | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |


Bonus meanings (inferred from the names):

- `LimitTimeUp`: time limit extension
- `Value`: generic value

_Raw recovered data (every method item): [trees/GolemSkill.md](../trees/GolemSkill.md) — uid 579_

---

### บัสเตอร์พลัส (BusterTypeImproved) · uid 580

<img src="../../icons/sk_580.png" width="40" alt="icon"> 
**Tree:** ゴーレムスキル (`GolemSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 200 · **Weapons:** Bowgun, Rod, MainMagictool · **Requires:** อัญเชิญโกเล็ม · **Flags:** NoMarketSearch · **Client class:** `BusterTypeImproved` (passive mastery)

> เพิ่มประสิทธิภาพของโกเล็มประเภทบัสเตอร์
> 
> พลังเจาะเข้าและอัตราคริติคอลของโกเล็มจะเพิ่มขึ้น
> สำหรับประเภทแลนเซอร์และชีลด์จะเพิ่มขึ้นเพียงเล็กน้อย

**How it works**

- Mastery skill of the ゴーレムスキル tree (tier 2, max Lv 200); usable with Bowgun, Rod, MainMagictool.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): PowerResistBreaker (physical pierce) 12 at Lv1 to 75 at Lv10, Crt (critical rate) 7 at Lv1 to 75 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| PowerResistBreaker | 12 | 19 | 26 | 33 | 40 | 47 | 54 | 61 | 68 | 75 |
| Crt | 7 | 15 | 22 | 30 | 37 | 45 | 52 | 60 | 67 | 75 |


Bonus meanings (inferred from the names):

- `PowerResistBreaker`: physical pierce
- `Crt`: critical rate

_Raw recovered data (every method item): [trees/GolemSkill.md](../trees/GolemSkill.md) — uid 580_

---

### ระเบิดเยือกแข็ง (FreezeGrenade) · uid 585

<img src="../../icons/sk_585.png" width="40" alt="icon"> 
**Tree:** ゴーレムスキル (`GolemSkill`, tier 2) · **Type:** Attack · **Max Lv:** 200 · **Weapons:** Bowgun, Shield, MainHand · **Requires:** ระเบิดเวทมนตร์ · **Flags:** NoMarketSearch · **Client class:** `FreezeGrenadeAction`

> เติมพลังเวทเยือกแข็งลงในหลอดพลัง
> 
> พลังโจมตีขึ้นอยู่กับระเบิดเวทมนตร์ที่เรียนรู้มา
> มีโอกาสติด "แช่แข็ง" แต่
> หากโดนระเบิดตัวเองก็มีโอกาสเล็กน้อยที่จะถูกแช่แข็งไปด้วย

**How it works**

- Attack skill of the ゴーレムスキル tree (tier 2, max Lv 200); usable with Bowgun, Shield, MainHand.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on live values (formula below); flat damage depends on live values (formula below)
- Proration: magic proration slot, mode `never (IsExpDefFluctuate=false)`.
- Can inflict on the target: Freeze (9).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(100)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `ActionSkillEvent` — on an animation/skill event during the motion: 1 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 2 call, 1 info
- `InitializeOthers` — setup used when another player's client replays the action: 3 set

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(skillRate / 100)`
- Flat dmg + `constantDamage`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(skillRate / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `constantDamage`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `never (IsExpDefFluctuate=false)`, attack type `Magic`, action id 585
- Uses the magic proration slot but never changes monster proration: IsExpDefFluctuate=false.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 584, 1)`

**Status ailments**

- Uses the default ailment duration (`ActionSkillEvent`)
  - when `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 17 AND FreezeGrenadeAction.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), UnityEngine.Component.get_transform(actarAction), 0) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 200 OR EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 17 AND FreezeGrenadeAction.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), UnityEngine.Component.get_transform(actarAction), 0) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1093) AND param eq 200 OR !hasBuff(1093) AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 17 AND FreezeGrenadeAction.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), UnityEngine.Component.get_transform(actarAction), 0) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 200`
- Rolls `percent`% to inflict **Freeze (9)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 9, percent, playerAction) AND SkillActionBase.DamageData.CheckEffectiveAbnormal(PlayerAttackBase.templateToDamageData(this, new SkillActionBase.DamageData, PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 1)) OR !PlayerAttackBase.checkAbnormalPercent(this, 9, percent, playerAction) AND SkillActionBase.DamageData.CheckEffectiveAbnormal(PlayerAttackBase.templateToDamageData(this, new SkillActionBase.DamageData, PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 1))`
- Marks the hit with ailment **Freeze (9)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 9, percent, playerAction) AND SkillActionBase.DamageData.CheckEffectiveAbnormal(PlayerAttackBase.templateToDamageData(this, new SkillActionBase.DamageData, PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 1))`

**Other recovered parameters**

- **Effect percent** (`percent`): `((Lv + (Lv << 2)) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]
- **Loop / hit-repeat count** (`LoopParam`): `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 584, 1)`

**In-game level notes**

- Lv17: เมื่อติดตั้งโล่จะต้านทานแช่แข็งได้ด้วยการต้านภาวะผิดปกติของคุณเอง
- Lv254: [ผลลัพธ์ต่อไปนี้ใช้ได้เมื่อติดตั้งเป็นอุปกรณ์หลักเท่านั้น] ขณะสกิลชี่กงฟื้นฟูทำงานจะต้านทานแช่แข็ง ได้ด้วยการต้านภาวะผิดปกติของคุณเอง

_Raw recovered data (every method item): [trees/GolemSkill.md](../trees/GolemSkill.md) — uid 585_

---

### บาเรียสกรีน (BarrierScreen) · uid 587

<img src="../../icons/sk_587.png" width="40" alt="icon"> 
**Tree:** ゴーレムスキル (`GolemSkill`, tier 2) · **Type:** Object · **Max Lv:** 200 · **Weapons:** Bowgun, Shield · **Requires:** ระเบิดเวทมนตร์ · **Flags:** NoMarketSearch · **Client class:** `BarrierScreenAction`

> ติดตั้งโดรนกางเมจิกบาเรีย
> ช่วยลดความรุนแรงของการโจมตีแนวตรง, กระสุน
> ของมีคมประเภทซัดที่ผ่านบาเรียได้หนึ่งครั้ง
> *มีการโจมตีบางประเภทที่ไม่สามารถลดความเสียหายได้
> ระหว่างติดตั้งการฟื้นฟู MP การโจมตีจะลดลง

**How it works**

- Object skill of the ゴーレムスキル tree (tier 2, max Lv 200); usable with Bowgun, Shield.
- It installs a buff on the caster.
- It places an object in the world (trap, summon or field object).
- Buffs:
  - `BarrierScreenBuf`
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(100)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `ActionStart` — when the cast starts: 5 set
- `ActionSkillEvent` — on an animation/skill event during the motion: 1 set, 2 call
- `OnDamage` — skill-specific method: 1 set
- `Break` — skill-specific method: 1 set
- `InitializeOthers` — setup used when another player's client replays the action: 3 set
- `ActionStartOthers` — skill-specific method: 2 set
- `ReceiveOtherSkillEvent` — skill-specific method: 1 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 587
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionSkillEvent` (on an animation/skill event during the motion): constructs `BarrierScreenBuf` — `.ctor(Lv, max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 588, 1), 0))`
  - when `IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 10`
- `ActionSkillEvent` (on an animation/skill event during the motion): adds the caster's buff of `new BarrierScreenBuf` — `AddSelfBuffer(new BarrierScreenBuf, Id)`
  - when `IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 10`

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `AttackMprecoveryUpRate`: MP recovered per attack (%)
- `Value`: generic value (meaning set by the code that reads the buff)

_Raw recovered data (every method item): [trees/GolemSkill.md](../trees/GolemSkill.md) — uid 587_

---

### เสริมพลังโจมตี (AttackPerformanceImprovement) · uid 581

<img src="../../icons/sk_581.png" width="40" alt="icon"> 
**Tree:** ゴーレムスキル (`GolemSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Bowgun, Rod, MainMagictool · **Requires:** แลนเซอร์พลัส · **Flags:** NoMarketSearch · **Client class:** `AttackPerformanceImprovement` (passive mastery)

> ปรับปรุงหลอดพลังเพื่อเพิ่มประสิทธิภาพการโจมตี
> 
> ค่าพลังที่แบ่งไปที่การโจมตีจะเพิ่มขึ้น
> และค่าความแม่นจะเพิ่มขึ้นตลอดเวลา
> โดยไม่ขึ้นอยู่กับการแบ่งพลัง

**How it works**

- Mastery skill of the ゴーレムスキル tree (tier 3, max Lv 250); usable with Bowgun, Rod, MainMagictool.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Value (generic value) 2 at Lv1 to 20 at Lv10, Hit (accuracy) 2 at Lv1 to 200 at Lv10.
- Other client code reads this skill (1 lookup; see the last section).

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |
| Hit | 2 | 8 | 18 | 32 | 50 | 72 | 98 | 128 | 162 | 200 |


Bonus meanings (inferred from the names):

- `Value`: generic value
- `Hit`: accuracy

**In-game level notes**

- Lv13: [สามารถใช้ผลแบบเดียวกันทั้งกับไม้เท้าและอุปกรณ์เวทมนตร์] หากใช้งานสกิล[อัญเชิญโกเล็ม]ซ้ำในขณะที่เรียกโกเล็มออกมาอยู่ จะติดบัฟเพิ่มพลังโจมตีให้โกเล็มได้ 1 ครั้ง

**Where else this skill takes effect**

- Code that reads this skill's level / buff by constant id: `CallGolemNormalAttackAction$$OnInitialize (GetSkillLv)`

_Raw recovered data (every method item): [trees/GolemSkill.md](../trees/GolemSkill.md) — uid 581_

---

### เสริมพลังป้องกัน (ShieldPerformanceImprovement) · uid 582

<img src="../../icons/sk_582.png" width="40" alt="icon"> 
**Tree:** ゴーレムスキル (`GolemSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Bowgun, Rod, MainMagictool · **Requires:** ชีลด์พลัส · **Flags:** NoMarketSearch · **Client class:** `ShieldPerformanceImprovement` (passive mastery)

> ปรับปรุงหลอดพลังเพื่อเพิ่มประสิทธิภาพโล่
> 
> ค่าพลังที่แบ่งไปที่โล่จะเพิ่มขึ้น
> และระยะลดความเสียหายจะเพิ่มขึ้นตลอดเวลา
> โดยไม่ขึ้นอยู่กับการแบ่งพลัง

**How it works**

- Mastery skill of the ゴーレムスキル tree (tier 3, max Lv 250); usable with Bowgun, Rod, MainMagictool.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): MobAttackLastDamageRate (final damage taken from monster attacks) 2 at Lv1 to 20 at Lv10, Value (generic value) 2 at Lv1 to 20 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MobAttackLastDamageRate | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |
| Value | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |


Bonus meanings (inferred from the names):

- `MobAttackLastDamageRate`: final damage taken from monster attacks
- `Value`: generic value

_Raw recovered data (every method item): [trees/GolemSkill.md](../trees/GolemSkill.md) — uid 582_

---

### เสริมความเร็ว (SpeedPerformanceImprovement) · uid 583

<img src="../../icons/sk_583.png" width="40" alt="icon"> 
**Tree:** ゴーレムスキル (`GolemSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Bowgun, Rod, MainMagictool · **Requires:** บัสเตอร์พลัส · **Flags:** NoMarketSearch · **Client class:** `SpeedPerformanceImprovement` (passive mastery)

> ปรับปรุงหลอดพลังเพื่อเพิ่มประสิทธิภาพความเร็ว
> 
> ค่าพลังที่แบ่งไปที่ความเร็ว
> จะทำให้ความเร็วการเคลื่อนที่เพิ่มขึ้น

**How it works**

- Mastery skill of the ゴーレムスキル tree (tier 3, max Lv 250); usable with Bowgun, Rod, MainMagictool.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Aspd (attack speed) 1 at Lv1 to 10 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Aspd | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


Bonus meanings (inferred from the names):

- `Aspd`: attack speed

_Raw recovered data (every method item): [trees/GolemSkill.md](../trees/GolemSkill.md) — uid 583_

---

### ระเบิดแสง (FlashGrenade) · uid 586

<img src="../../icons/sk_586.png" width="40" alt="icon"> 
**Tree:** ゴーレムスキル (`GolemSkill`, tier 3) · **Type:** Attack · **Max Lv:** 250 · **Weapons:** Bowgun, Shield, MainHand · **Requires:** ระเบิดเยือกแข็ง · **Flags:** NoMarketSearch · **Client class:** `FlashGrenadeAction`

> เติมพลังเวทแสงลงในหลอดพลัง
> 
> ความเสียหายขึ้นอยู่กับระเบิดเวทมนตร์ที่เรียนรู้มา
> มีโอกาสติด "ตาพร่า แต่
> หากโดนระเบิดตัวเองก็มีโอกาสเล็กน้อยที่จะตาพร่าไปด้วย

**How it works**

- Attack skill of the ゴーレムスキル tree (tier 3, max Lv 250); usable with Bowgun, Shield, MainHand.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on live values (formula below); flat damage depends on live values (formula below)
- Proration: magic proration slot, mode `never (IsExpDefFluctuate=false)`.
- Can inflict on the target: Flash (33).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(100)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `ActionSkillEvent` — on an animation/skill event during the motion: 1 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 2 call, 1 info
- `InitializeOthers` — setup used when another player's client replays the action: 3 set

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(skillRate / 100)`
- Flat dmg + `constantDamage`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(skillRate / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `constantDamage`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `never (IsExpDefFluctuate=false)`, attack type `Magic`, action id 586
- Uses the magic proration slot but never changes monster proration: IsExpDefFluctuate=false.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 584, 1)`

**Status ailments**

- Uses the default ailment duration (`ActionSkillEvent`)
  - when `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 17 AND FlashGrenadeAction.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), UnityEngine.Component.get_transform(actarAction), 0) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 200 OR EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 17 AND FlashGrenadeAction.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), UnityEngine.Component.get_transform(actarAction), 0) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1093) AND param eq 200 OR !hasBuff(1093) AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 17 AND FlashGrenadeAction.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), UnityEngine.Component.get_transform(actarAction), 0) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 200`
- Rolls `percent`% to inflict **Flash (33)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 33, percent, playerAction) AND SkillActionBase.DamageData.CheckEffectiveAbnormal(PlayerAttackBase.templateToDamageData(this, new SkillActionBase.DamageData, PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 1)) OR !PlayerAttackBase.checkAbnormalPercent(this, 33, percent, playerAction) AND SkillActionBase.DamageData.CheckEffectiveAbnormal(PlayerAttackBase.templateToDamageData(this, new SkillActionBase.DamageData, PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 1))`
- Marks the hit with ailment **Flash (33)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 33, percent, playerAction) AND SkillActionBase.DamageData.CheckEffectiveAbnormal(PlayerAttackBase.templateToDamageData(this, new SkillActionBase.DamageData, PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 1))`

**Other recovered parameters**

- **Effect percent** (`percent`): `((Lv + (Lv << 2)) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]
- **Loop / hit-repeat count** (`LoopParam`): `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 584, 1)`

**In-game level notes**

- Lv17: เมื่อติดตั้งโล่จะต้านทานตาพร่าได้ด้วยการต้านภาวะผิดปกติของคุณเอง
- Lv254: [ผลลัพธ์ต่อไปนี้ใช้ได้เมื่อติดตั้งเป็นอุปกรณ์หลักเท่านั้น] ขณะสกิลชี่กงฟื้นฟูทำงานจะต้านทานตาพร่า ได้ด้วยการต้านภาวะผิดปกติของคุณเอง

_Raw recovered data (every method item): [trees/GolemSkill.md](../trees/GolemSkill.md) — uid 586_

---

### เสริมบาเรีย (BarrierScreenPerformanceImprovement) · uid 588

<img src="../../icons/sk_588.png" width="40" alt="icon"> 
**Tree:** ゴーレムスキル (`GolemSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Bowgun, Shield · **Requires:** บาเรียสกรีน · **Flags:** NoMarketSearch

> ปรับปรุงบาเรียโดรน
> 
> เพิ่มอัตราการลดทอนความรุนแรงของบาเรียให้สูงขึ้น
> และลดปริมาณการสูญเสียพลังฟื้นฟู
> MP การโจมตีที่ใช้ในการคงสภาพโดรน

**How it works**

- Mastery skill of the ゴーレムスキル tree (tier 3, max Lv 250); usable with Bowgun, Shield.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **consumer-only** — no action class; effect applied in consumer code (see page).
- Its effect is applied by client code: `BarrierScreenAction$$ActionStart` (formulas in the last section).
- Other client code reads this skill (2 lookups; see the last section).

**Where else this skill takes effect**

- Effect applied in `BarrierScreenAction$$ActionStart` (4 guarded paths):
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
- Code that reads this skill's level / buff by constant id: `BarrierScreenAction$$ActionSkillEvent (GetSkillLv)`, `BarrierScreenAction$$ActionStart (GetSkillLv)`

_Raw recovered data (every method item): [trees/GolemSkill.md](../trees/GolemSkill.md) — uid 588_

---
