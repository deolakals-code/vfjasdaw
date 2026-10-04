# ネクロマンサースキル (`NecromancerSkill`) — skill details

12 entries.

### เกรฟดิกเกอร์ (GlaiveTigger) · uid 1121

<img src="../../icons/sk_1121.png" width="40" alt="icon"> 
**Tree:** ネクロマンサースキル (`NecromancerSkill`, tier 1) · **Type:** Object · **Max Lv:** 1 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** NoMarketSearch · **Client class:** `GlaiveTiggerAction`

> เปิดสุสานแห่งจินตนาการเพื่อเตรียมใช้วิชาเนโครแมนเซอร์
> 
> เมื่ออยู่ในสุสานจะเริ่มสะสมสแต็ควิญญาณ
> ถ้าออกจากสุสานวิญญาณจะค่อยๆ หายไป

**How it works**

- Object skill of the ネクロマンサースキル tree (tier 1, max Lv 1); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It places an object in the world (trap, summon or field object).
- Buffs:
  - `GlaiveTiggerBuf`
  - `CountBufferBase`
- Other client code reads this skill (12 lookups; see the last section).

**Cost, timing and range**

- **Effect radius (Unity units)** (`Radius`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance(3)`
- **Effect radius (Unity units)** (`Radius`) (Unity units, 2 = 1 m): `(Radius + MathUtil.DisplayMeterToDistance((SkillMasteryBase.GetMasteryParam(MasteryId.Value) / 10)))`
  - when `!PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isNewPlace ne 0 AND mainWeapon == Rod OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isNewPlace eq 0 AND mainWeapon == Rod`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionStart` — when the cast starts: 4 set
- `.<>c__DisplayClass24_0::<ActionStart>b__0` — skill-specific method: 2 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1121
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `.<>c__DisplayClass24_0::<ActionStart>b__0` (method): constructs `GlaiveTiggerBuf` — `.ctor([<>c__DisplayClass24_0.<>4__this+0x14], <>c__DisplayClass24_0.playerAction)`
  - when `<>c__DisplayClass24_0.weaponType eq 14`
- `.<>c__DisplayClass24_0::<ActionStart>b__0` (method): adds the caster's buff of `new GlaiveTiggerBuf` — `AddSelfBuffer(new GlaiveTiggerBuf, [<>c__DisplayClass24_0.<>4__this+0x10])`
  - when `<>c__DisplayClass24_0.weaponType eq 14`

**Other recovered parameters**

- **Effect radius (Unity units)** (`Radius`): `MathUtil.DisplayMeterToDistance(3)`; `(Radius + MathUtil.DisplayMeterToDistance((SkillMasteryBase.GetMasteryParam(MasteryId.Value) / 10)))` _(when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isNewPlace ne 0 AND mainWeapon == Rod OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isNewPlace eq 0 AND mainWeapon == Rod)_

**Buff values** (every recovered field; durations in seconds)

**Buff `GlaiveTiggerBuf`**
- Buff hook methods: `Prev`, `PrevSkip`, `SetCount`, `SetCountValue`
- `Percent` = `int(((Lv * 0.1) * (0)))` _(when BuffEffectActive ne 0; EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 14)_
- `Percent` = `CountBufferBase.GetParam(this, id)` _(when BuffEffectActive ne 0; EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 14)_
- `Value` = `System.Linq.Enumerable.(0)<SkillActionBase>(SkillActionManager.get_PlaceSkilList((playerAction.battleManager.skillActManager)), GlaiveTiggerBuf.<>c.<>9__11_0)` _(when BuffEffectActive ne 0; UnityEngine.Object.op_Inequality(skillActionManager))_
- `Value` = `0` _(when BuffEffectActive ne 0; !UnityEngine.Object.op_Inequality(skillActionManager))_
- `AbnormalRegist` = `int(((Lv * 0.05) * (0)))` _(when BuffEffectActive ne 0; EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 14)_
- `AbnormalRegist` = `CountBufferBase.GetParam(this, id)` _(when BuffEffectActive ne 0; EquipItemData.get_WeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 14)_
- Buff fields set in the constructor (all recovered):
  - `bufferType` = `(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1127, 1) gt 0 ? 12 : 3)`
  - `Count` = `0`
  - `skillActionManager` = `playerAction.battleManager.skillActManager`
  - `playerStatus` = `PlayerActionManagerBase.get_PlayerStatus()`
- Hook `SetCount`: `Count`=(count lt 0 ? 0 : (Max lt count ? Max : count))
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:GlaiveTiggerBuf$$.ctor<-GlaiveTiggerAction.<>c__DisplayClass24_0$$<ActionStart>b__0` (no direct constructor call in the skill's own code).
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

- `AbnormalRegist`: ailment resistance
- `Count`: stack / hit counter
- `Percent`: generic percent
- `Value`: generic value (meaning set by the code that reads the buff)

**In-game level notes**

- Lv14: ไม่ว่าจะเป็นสกิลเลเวลใดก็จะได้รับสแต็ควิญญาณทุกวินาที จำนวนสแต็ควิญญาณที่คุณได้รับจะเพิ่มการฟื้นฟู MP การโจมตี และความต้านทานต่อสภาวะผิดปกติ  การฟื้นฟู MP การโจมตีต่อจำนวนสแต็ควิญญาณและ ความต้านทานต่อสภาวะผิดปกติจะเพิ่มขึ้นตามเลเวลสกิล

**Where else this skill takes effect**

- Effect applied in `PlayerSecondaryStatus$$get_AtkMpRecovery` (280 guarded paths, truncated):
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
  - when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 577, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 41, stkp(-72), 0) & 1) ne 0`
    - returns `int(((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 34, 0, ?x3) / 100)) + (GemCartBufferManager.GetBufferValue(?blr, 7, 0, ?x3) / 100)) * (EquipItemData.WeaponTypeCalculatorBase.get_WeaponType([CharacterActionManagerBase.set_DefaultMoveSpeed()+0x18], 0, ?x2, ?x3) eq 16 ? 0 : ((System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue([CharacterActionManagerBase.get_IsDeadOrLocalDead()+0x68], 133, stkp(-88), meta(0x3974490, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.TryGetValue())) & 1) ne 0 ? ((max((PlayerSecondaryStatus.CalcBaseMaxMp(this, ?x1, ?x2, ?x3) lt 2000 ? PlayerSecondaryStatus.CalcBaseMaxMp(this, ?x1, ?x2, ?x3) : 2000), 0) // 100) + 10) : 0))) + TryGetBuf.out2()))`
    - calls `virtual CharacterActionManagerBase.get_IsValid`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`
- Effect applied in `MobaPlayerSecondaryStatus$$get_AntiVirus` (25 guarded paths):
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
- Effect applied in `PlayerSecondaryStatus$$CalcAntiVirus` (25 guarded paths):
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
- Effect applied in `GlaiveTiggerBuf$$SetCountValue` (3 guarded paths):
  - when `value ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1121, stkp(-40), 0) & 1) eq 0`
    - returns `GlaiveTiggerBuf.SetCount(0x165db78(meta(0x39a9410, GlaiveTiggerBuf_TypeInfo), ?x1, ?x2, ?x3), value, ?x2, ?x3)`
    - calls `0x165db78`, `GlaiveTiggerBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `GlaiveTiggerBuf$$SetCount`
  - when `value ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1121, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `GlaiveTiggerBuf.SetCount(TryGetBuf.out2(), value, ?x2, ?x3)`
    - calls `GlaiveTiggerBuf$$SetCount`
  - when `value ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1121, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `0x165db84`, `0x165df00`
- Effect applied in `GlaiveTiggerAction$$InitializeOthers` (4 guarded paths):
  - always
    - set `ActionRange` = `-1`
    - set `_motionSpeed` = `targetPos`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_SkillManager`
  - always
    - returns `System.Linq.Enumerable.FirstOrDefault<object>(PartyManager.get_LoginMemberData(Singleton<object>.get_Instance(meta(0x3974068, Method$Singleton<PartyManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3), 0x165db78(meta(0x3974800, System.Func<PartyMemberData, bool>_TypeInfo), ?x1, ?x2, ?x3), meta(0x39747f8, Method$System.Linq.Enumerable.FirstOrDefault<PartyMemberData>()), ?x3)`
    - set `ActionRange` = `-1`
    - set `_motionSpeed` = `targetPos`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_SkillManager`
  - always
    - returns `System.Linq.Enumerable.FirstOrDefault<object>(PartyManager.get_LoginMemberData(Singleton<object>.get_Instance(meta(0x3974068, Method$Singleton<PartyManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3), 0x165db78(meta(0x3974800, System.Func<PartyMemberData, bool>_TypeInfo), ?x1, ?x2, ?x3), meta(0x39747f8, Method$System.Linq.Enumerable.FirstOrDefault<PartyMemberData>()), ?x3)`
    - set `ActionRange` = `-1`
    - set `_motionSpeed` = `targetPos`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_SkillManager`
  - always
    - returns `SkillLv(1121)`
    - set `ActionRange` = `-1`
    - set `_motionSpeed` = `targetPos`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_SkillManager`
- Effect applied in `PhantomMissileAction$$IsFailure` (4 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1121, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `(PlayerAttackBase.IsFailure(this, status, missType, 0) & 1)`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `PlayerAttackBase$$IsFailure`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1121, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1121, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1121, stkp(-40), 0) & 1) eq 0`
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`
- Effect applied in `GlaiveTiggerAction.<>c__DisplayClass24_0$$<ActionStart>b__0` (5 guarded paths):
  - when `<>c__DisplayClass24_0.weaponType eq 14` AND `(SkillBufferManager.TryGetBuf(?blr, 1121, stkp(-56), 0) & 1) eq 0` AND `TryGetValue.out2() ne 0`
    - returns `GameManager.ActionSuppportDelay(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), CharacterActionManagerBase.get_IsLocalDead(), 0x165db78(meta(0x399f280, System.Collections.Generic.List<TargetPlayerData>_TypeInfo), ((SkillManager.GetAllSkillLvInTree(?blr, 35, 1, 0) // 10) + [[TryGetValue.out2()+0x10]+0x18]), meta(0), ?x3), 0)`
    - calls `0x165db78`, `GlaiveTiggerBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `SkillManager$$GetAllSkillLvInTree`, `0x165db78`, `System.Collections.Generic.List<object>$$.ctor`, `Singleton<object>$$get_Instance`, `virtual CharacterActionManagerBase.get_IsLocalDead`
  - when `<>c__DisplayClass24_0.weaponType eq 14` AND `(SkillBufferManager.TryGetBuf(?blr, 1121, stkp(-56), 0) & 1) eq 0` AND `TryGetValue.out2() eq 0`
    - calls `0x165db78`, `GlaiveTiggerBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `0x165db84`, `0x165df00`
  - when `<>c__DisplayClass24_0.weaponType eq 14` AND `(SkillBufferManager.TryGetBuf(?blr, 1121, stkp(-56), 0) & 1) ne 0` AND `TryGetValue.out2() ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `GameManager.ActionSuppportDelay(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), CharacterActionManagerBase.get_IsLocalDead(), 0x165db78(meta(0x399f280, System.Collections.Generic.List<TargetPlayerData>_TypeInfo), ((SkillManager.GetAllSkillLvInTree(?blr, 35, 1, 0) // 10) + [[TryGetValue.out2()+0x10]+0x18]), meta(0), ?x3), 0)`
    - calls `SkillManager$$GetAllSkillLvInTree`, `0x165db78`, `System.Collections.Generic.List<object>$$.ctor`, `Singleton<object>$$get_Instance`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `GameManager$$ActionSuppportDelay`
  - when `<>c__DisplayClass24_0.weaponType eq 14` AND `(SkillBufferManager.TryGetBuf(?blr, 1121, stkp(-56), 0) & 1) ne 0` AND `TryGetValue.out2() ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `SkillManager$$GetAllSkillLvInTree`, `0x165db84`, `0x165df00`
  - when `<>c__DisplayClass24_0.weaponType eq 14` AND `(SkillBufferManager.TryGetBuf(?blr, 1121, stkp(-56), 0) & 1) ne 0` AND `TryGetValue.out2() eq 0`
    - calls `0x165db84`, `0x165df00`
- Effect applied in `SummonSkeletonAction$$IsFailure` (4 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1121, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1121, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `(PlayerAttackBase.IsFailure(this, status, missType, 0) & 1)`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `PlayerAttackBase$$IsFailure`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1121, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1121, stkp(-40), 0) & 1) eq 0`
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`
- Effect applied in `SummonSkeletonAction$$ActionPreparation` (3 guarded paths):
  - when `isHarvest eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1121, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SummonSkeletonAction.CreateTake(this, ?x1, ?x2, ?x3)`
    - set `movePos` = `PlacePos`
    - set `+0x174` = `+0x124`
    - set `+0x178` = `+0x128`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `SummonSkeletonAction$$SetPlacePos`, `SummonSkeletonAction$$CreateTake`
  - when `isHarvest eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1121, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `0x165db84`, `0x165df00`
  - when `isHarvest eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1121, stkp(-40), 0) & 1) eq 0`
    - returns `SummonSkeletonAction.CreateTake(this, ?x1, ?x2, ?x3)`
    - set `movePos` = `PlacePos`
    - set `+0x174` = `+0x124`
    - set `+0x178` = `+0x128`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `SummonSkeletonAction$$SetPlacePos`, `SummonSkeletonAction$$CreateTake`
- Effect applied in `PhantomMissileAction$$ActionPreparation` (3 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 1121, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add([SkillActionBase.get_CurrentEventTake(this, 0, ?x2, ?x3)+0x50], 7, Element, meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
    - set `playerAction` = `actarAction`
    - set `SkillIndividualFlag` = `System.Math.Min(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3), 10, 0, ?x3)`
    - set `LoopParam` = `(System.Math.Min(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3), 10, 0, ?x3) - 1)`
    - set `target` = `target`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerAttackBase$$ActionPreparation`, `0x165d8dc`, `SkillBufferDataBase$$GetParam`, `System.Math$$Min`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1121, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - set `playerAction` = `actarAction`
    - calls `PlayerAttackBase$$ActionPreparation`, `0x165d8dc`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1121, stkp(-56), 0) & 1) eq 0`
    - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add([SkillActionBase.get_CurrentEventTake(this, 0, ?x2, ?x3)+0x50], 7, Element, meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
    - set `playerAction` = `actarAction`
    - set `target` = `target`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerAttackBase$$ActionPreparation`, `0x165d8dc`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`
- Effect applied in `TombAction$$ActionPreparation` (5 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 1121, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `0x165d8dc(vtab(this), 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
    - set `playerAction` = `actarAction`
    - set `LoopParam` = `System.Math.Min((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3) // 3), 3, 0, ?x3)`
    - set `SkillIndividualFlag` = `System.Math.Min((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3) // 3), 3, 0, ?x3)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerAttackBase$$ActionPreparation`, `0x165d8dc`, `PlayerAttackBase$$IsBlank`, `SkillBufferDataBase$$GetParam`, `System.Math$$Min`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1121, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `0x165d8dc(vtab(this), 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
    - set `playerAction` = `actarAction`
    - set `LoopParam` = `System.Math.Min((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3) // 3), 3, 0, ?x3)`
    - set `SkillIndividualFlag` = `System.Math.Min((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3) // 3), 3, 0, ?x3)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerAttackBase$$ActionPreparation`, `0x165d8dc`, `PlayerAttackBase$$IsBlank`, `SkillBufferDataBase$$GetParam`, `System.Math$$Min`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1121, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - set `playerAction` = `actarAction`
    - calls `PlayerAttackBase$$ActionPreparation`, `0x165d8dc`, `PlayerAttackBase$$IsBlank`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1121, stkp(-72), 0) & 1) eq 0` AND `LoopParam ge 1`
    - returns `0x165d8dc(vtab(this), 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
    - set `playerAction` = `actarAction`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerAttackBase$$ActionPreparation`, `0x165d8dc`, `PlayerAttackBase$$IsBlank`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1121, stkp(-72), 0) & 1) eq 0` AND `LoopParam lt 1`
    - returns `0x165d8dc(vtab(this), 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
    - set `playerAction` = `actarAction`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerAttackBase$$ActionPreparation`, `0x165d8dc`, `PlayerAttackBase$$IsBlank`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`
- Code that reads this skill's level / buff by constant id: `GlaiveTiggerAction$$InitializeOthers (GetSkillLv)`, `GlaiveTiggerAction.<>c__DisplayClass24_0$$<ActionStart>b__0 (TryGetBuf)`, `GlaiveTiggerBuf$$SetCountValue (GetSkillLv)`, `GlaiveTiggerBuf$$SetCountValue (TryGetBuf)`, `MobaPlayerSecondaryStatus$$get_AntiVirus (TryGetBuf)`, `PhantomMissileAction$$ActionPreparation (TryGetBuf)`, `PhantomMissileAction$$IsFailure (TryGetBuf)`, `PlayerSecondaryStatus$$CalcAntiVirus (TryGetBuf)`, `PlayerSecondaryStatus$$get_AtkMpRecovery (TryGetBuf)`, `SummonSkeletonAction$$ActionPreparation (TryGetBuf)`, `SummonSkeletonAction$$IsFailure (TryGetBuf)`, `TombAction$$ActionPreparation (TryGetBuf)`

_Raw recovered data (every method item): [trees/NecromancerSkill.md](../trees/NecromancerSkill.md) — uid 1121_

---

### ทูม (Tomb) · uid 1122

<img src="../../icons/sk_1122.png" width="40" alt="icon"> 
**Tree:** ネクロマンサースキル (`NecromancerSkill`, tier 1) · **Type:** Attack · **Max Lv:** 1 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** NoMarketSearch · **Client class:** `TombAction`

> เนโครแมนเซอร์ที่ใช้ศิลาหน้าหลุมศพโจมตี
> สร้างความเสียหายทางกายภาพแก่เป้าหมาย
> เมื่อ VIT มากกว่า 50 จะเพิ่มโอกาสทำให้เป้าหมาย[ล้มคว่ำ]
> หากใช้สแต็ควิญญาณx3 จะเพิ่มการโจมตีบริเวณโดยรอบ
> สามารถเปิดใช้งานพร้อมกันได้สูงสุด 3 ครั้ง

**How it works**

- Attack skill of the ネクロマンサースキル tree (tier 1, max Lv 1); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [(SkillActionBase.get_AttackCount(this) & 255) ne 0]: skill multiplier ×1.6 at Lv1 to 2.5 at Lv10; flat damage +30 at Lv1 to 300 at Lv10
  - `calcPlayerToMobDamage` [(SkillActionBase.get_AttackCount(this) & 255) eq 0 OR (SkillActionBase.get_AttackCount(this) & 255) eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalPercent, playerAction) AND (SkillActionBase.get_AttackCount(this) & 255) eq 0]: skill multiplier ×2.5; flat damage +300
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Tumble (2).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(7)`
- **Effect radius (Unity units)** (`Radius`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance(3)`
  - when `(((UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z) * (UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z)) + ((UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x) * (UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x))) le ((MathUtil.DisplayMeterToDistance(3) + size) * (MathUtil.DisplayMeterToDistance(3) + size)) AND (SkillActionBase.get_AttackCount(this) & 255) ne 0 AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).y), size) OR (((UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z) * (UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z)) + ((UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x) * (UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x))) gt ((MathUtil.DisplayMeterToDistance(3) + size) * (MathUtil.DisplayMeterToDistance(3) + size)) AND (SkillActionBase.get_AttackCount(this) & 255) ne 0 AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).y), size)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 7 set
- `InitializeOthers` — setup used when another player's client replays the action: 3 set
- `ActionPreparation` — before the cast starts: 2 set
- `ActionStart` — when the cast starts: 1 set
- `CheckRangeHit` — range-hit test: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 6 tpl, 3 call, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [(SkillActionBase.get_AttackCount(this) & 255) ne 0] | 1.6 | 1.7 | 1.8 | 1.9 | 2 | 2.1 | 2.2 | 2.3 | 2.4 | 2.5 |
| SkillRate × [(SkillActionBase.get_AttackCount(this) & 255) eq 0 OR (SkillActionBase.get_AttackCount(this) & 255) eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalPercent, playerAction) AND (SkillActionBase.get_AttackCount(this) & 255) eq 0] | 2.5 | 2.5 | 2.5 | 2.5 | 2.5 | 2.5 | 2.5 | 2.5 | 2.5 | 2.5 |
| Flat dmg + [(SkillActionBase.get_AttackCount(this) & 255) ne 0] | 30 | 60 | 90 | 120 | 150 | 180 | 210 | 240 | 270 | 300 |
| Flat dmg + [(SkillActionBase.get_AttackCount(this) & 255) eq 0 OR (SkillActionBase.get_AttackCount(this) & 255) eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalPercent, playerAction) AND (SkillActionBase.get_AttackCount(this) & 255) eq 0] | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 |

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(target.ExpDefSkill / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv * 10) + 150)) / 100)`
  - when `(SkillActionBase.get_AttackCount(this) & 255) ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `((Lv * 30))`
  - when `(SkillActionBase.get_AttackCount(this) & 255) ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((250) / 100)`
  - when `(SkillActionBase.get_AttackCount(this) & 255) eq 0 OR (SkillActionBase.get_AttackCount(this) & 255) eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalPercent, playerAction) AND (SkillActionBase.get_AttackCount(this) & 255) eq 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(300)`
  - when `(SkillActionBase.get_AttackCount(this) & 255) eq 0 OR (SkillActionBase.get_AttackCount(this) & 255) eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalPercent, playerAction) AND (SkillActionBase.get_AttackCount(this) & 255) eq 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(targetExpRegister[mobAction] / 100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1122
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `motionSpeed`
- Loop / hit-repeat count (`LoopParam`): `System.Math.Min((SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121), 20) // 3), 3)`
  - when `!PlayerAttackBase.IsBlank(this) AND System.Math.Min((SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121), 20) // 3), 3) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND System.Math.Min((SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121), 20) // 3), 3) lt 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)`

**Status ailments**

- Chance field `abnormalPercent` (Chance to inflict the skill's status ailment (%)): `System.Math.Min((((baseVIT // 50) + ((baseVIT // 50) << 2)) << 2), 100)`
- Rolls `abnormalPercent`% to inflict **Tumble (2)** (`calcPlayerToMobDamage`)
  - when `(SkillActionBase.get_AttackCount(this) & 255) eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalPercent, playerAction) AND (SkillActionBase.get_AttackCount(this) & 255) eq 0`
- Marks the hit with ailment **Tumble (2)** (`calcPlayerToMobDamage`)
  - when `(SkillActionBase.get_AttackCount(this) & 255) eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalPercent, playerAction)`

**Buffs and effects it installs or removes**

- `calcPlayerToMobDamage` (damage calculation against a monster): adds the buff-provided flat damage to the template — `SetBufferConstantDamage(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), (LoopParam + 1))`

**Other recovered parameters**

- **Loop / hit-repeat count** (`LoopParam`): `motionSpeed`; `System.Math.Min((SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121), 20) // 3), 3)` _(when !PlayerAttackBase.IsBlank(this) AND System.Math.Min((SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121), 20) // 3), 3) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND System.Math.Min((SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121), 20) // 3), 3) lt 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction))_
- **Effect radius (Unity units)** (`Radius`): `MathUtil.DisplayMeterToDistance(3)` _(when (((UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z) * (UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z)) + ((UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x) * (UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x))) le ((MathUtil.DisplayMeterToDistance(3) + size) * (MathUtil.DisplayMeterToDistance(3) + size)) AND (SkillActionBase.get_AttackCount(this) & 255) ne 0 AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).y), size) OR (((UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z) * (UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z)) + ((UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x) * (UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x))) gt ((MathUtil.DisplayMeterToDistance(3) + size) * (MathUtil.DisplayMeterToDistance(3) + size)) AND (SkillActionBase.get_AttackCount(this) & 255) ne 0 AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).y), size))_

_Raw recovered data (every method item): [trees/NecromancerSkill.md](../trees/NecromancerSkill.md) — uid 1122_

---

### แฟนทอมมิสไซล์ (PhantomMissile) · uid 1123

<img src="../../icons/sk_1123.png" width="40" alt="icon"> 
**Tree:** ネクロマンサースキル (`NecromancerSkill`, tier 1) · **Type:** Object · **Max Lv:** 1 · **Weapons:** Rod · **Requires:** เกรฟดิกเกอร์ · **Flags:** NoMarketSearch · **Client class:** `PhantomMissileAction`

> เนโครแมนเซอร์ที่โจมตีด้วยการปล่อยวิญญาณชั่วร้าย
> ใช้สแต็ควิญญาณ (สูงสุด 10)
> เพื่อสร้างความเสียหายเวทมนตร์แก่เป้าหมาย
> ยิ่งใช้วิญญาณมากขึ้นจะยิ่งเพิ่มระยะเวลา (จำนวน HIT)
> ทุกครั้งที่ติดคริติคอล(เกณฑ์ทางกายภาพ)พลังจะเพิ่มขึ้น

**How it works**

- Object skill of the ネクロマンサースキル tree (tier 1, max Lv 1); usable with Rod.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It places an object in the world (trap, summon or field object).
- Damage (`calcPlayerToMobDamage` x3; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [(LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0]: skill multiplier ×1; flat damage +500
  - `calcPlayerToMobDamage` [(LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0]: skill multiplier ×1.1 at Lv1 to 2 at Lv10
  - `calcPlayerToMobDamage` [(LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 lt (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0]: skill multiplier ×1.2 at Lv1 to 3 at Lv10
  - `calcPlayerToMobDamage` [(LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 & (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [(LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 & (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [(LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 lt (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 & (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [(LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 & (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [(LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 & (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0]: skill multiplier depends on live values (formula below)
  - ... and 3 more variants (see the tables below)
- Proration: magic proration slot, mode `first_hit_per_target`.

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0.5, PlayerActionManagerBase.get_PlayerStatus())`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(24)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 5 set
- `ActionPreparation` — before the cast starts: 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 3 set
- `ActionStartOthers` — skill-specific method: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 3 set, 6 tpl, 3 info
- `.MoveEffect::Update` — skill-specific method: 8 set
- `.MoveEffect::ChangeState` — skill-specific method: 17 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [(LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0] | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 |
| SkillRate × [(LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0] | 1.1 | 1.2 | 1.3 | 1.4 | 1.5 | 1.6 | 1.7 | 1.8 | 1.9 | 2 |
| SkillRate × [(LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 lt (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0] | 1.2 | 1.4 | 1.6 | 1.8 | 2 | 2.2 | 2.4 | 2.6 | 2.8 | 3 |
| Flat dmg + | 500 | 500 | 500 | 500 | 500 | 500 | 500 | 500 | 500 | 500 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((100) / 100)` — (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 & (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0
- SkillRate × `((100) / 100)` — (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 & (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0
- SkillRate × `((100) / 100)` — (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 lt (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 & (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0
- SkillRate × `(((Lv * 10) + (100)) / 100)` — (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 & (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0
- SkillRate × `(((Lv * 10) + (100)) / 100)` — (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 & (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0
- SkillRate × `(((Lv * 10) + (100)) / 100)` — (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 lt (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 & (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0
- SkillRate × `(((Lv * 10) + ((Lv * 10) + (100))) / 100)` — (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 & (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 lt (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0
- SkillRate × `(((Lv * 10) + ((Lv * 10) + (100))) / 100)` — (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 & (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 lt (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(target.ExpDefMagic / 100)`
  - when `(LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((100) / 100)`
  - when `(LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(500)`
  - when `(LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((Lv * 10) + (100)) / 100)`
  - when `(LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((Lv * 10) + ((Lv * 10) + (100))) / 100)`
  - when `(LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 lt (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(targetMagicExp / 100)`
  - when `(LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND targetMagicExp ne 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 1123
- Uses the magic proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `(System.Math.Min(SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121), 20), 10) - 1)`
  - when `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)`
- Loop / hit-repeat count (`LoopParam`): `motionSpeed`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0.5, PlayerActionManagerBase.get_PlayerStatus())`
- **Loop / hit-repeat count** (`LoopParam`): `(System.Math.Min(SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121), 20), 10) - 1)` _(when TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction))_; `motionSpeed`

_Raw recovered data (every method item): [trees/NecromancerSkill.md](../trees/NecromancerSkill.md) — uid 1123_

---

### พลั่วชั้นดี (GoodQualityShovel) · uid 1124

<img src="../../icons/sk_1124.png" width="40" alt="icon"> 
**Tree:** ネクロマンサースキル (`NecromancerSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 1 · **Weapons:** Rod · **Requires:** เกรฟดิกเกอร์ · **Flags:** NoMarketSearch · **Client class:** `GoodQualityShovel` (passive mastery)

> เมื่อใช้สกิล[ขุดหลุมศพ]เป็นครั้งแรก
> จะได้รับสแต็ควิญญาณเพิ่ม
> 
> และถึงจะออกห่างจากสุสานไปเล็กน้อย
> สแต็ควิญญาณจะยังคงเพิ่มขึ้นต่อไป

**How it works**

- Mastery skill of the ネクロマンサースキル tree (tier 1, max Lv 1); usable with Rod.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Value (generic value) 6 at Lv1 to 60 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 6 | 12 | 18 | 24 | 30 | 36 | 42 | 48 | 53 | 60 |


Bonus meanings (inferred from the names):

- `Value`: generic value

_Raw recovered data (every method item): [trees/NecromancerSkill.md](../trees/NecromancerSkill.md) — uid 1124_

---

### สกัลเชคเกอร์ (SkullShaker) · uid 1125

<img src="../../icons/sk_1125.png" width="40" alt="icon"> 
**Tree:** ネクロマンサースキル (`NecromancerSkill`, tier 2) · **Type:** Attack · **Max Lv:** 205 · **Weapons:** Rod, Halberd · **Requires:** ทูม · **Flags:** NoMarketSearch · **Client class:** `SkullShakerAction`

> ใช้ไม้เท้าฟาดเข้าที่กลางศีรษะ
> สร้างความเสียหายทางกายภาพแก่เป้าหมาย
> มีโอกาสที่เป้าหมายจะ[ตาลาย]ยิ่งโจมตีโดนมาก
> พลังโจมตีและโอกาสทำให้[หมดสติ]จะยิ่งเพิ่มขึ้น
> ถ้าทำให้เป้าหมายหมดสติได้สำเร็จจะถูกรีเซ็ต

**How it works**

- Attack skill of the ネクロマンサースキル tree (tier 2, max Lv 205); usable with Rod, Halberd.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on live values (formula below); flat damage depends on live values (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Dizzy (14), Stun (3).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `ActionPreparation` — before the cast starts: 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 6 call, 1 info
- `ActionHit` — when the attack connects: 1 set

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(skillRate / 100)`
- Flat dmg + `fixAddDamage`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(skillRate / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `fixAddDamage`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1125
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Chance field `dizzyPercent` (ailment chance): `System.Math.Min(((baseSTR // 5) + (Lv + (Lv << 2))), 100)`
- Chance field `stunPercent` (Stun chance (%)): `((MobBuffBase.GetValue() + (MobBuffBase.GetValue() << 2)) << 1)`
  - when `TryGetBuff.buff(MobActionManagerBase.get_BuffManager(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)), 18) ne 0`
- Rolls `dizzyPercent`% to inflict **Dizzy (14)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)`
- Marks the hit with ailment **Dizzy (14)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 18) ne 0`
- Rolls `stunPercent`% to inflict **Stun (3)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)`
- Uses the default ailment duration (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)`

**Buffs and effects it installs or removes**

- `calcPlayerToMobDamage` (damage calculation against a monster): constructs `SkullShakerDebuff` — `.ctor((MobBuffBase.GetValue() + 1))`
  - when `!PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 18) ne 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 18) ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): constructs `SkullShakerDebuff` — `.ctor(1)`
  - when `!PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)`

_Raw recovered data (every method item): [trees/NecromancerSkill.md](../trees/NecromancerSkill.md) — uid 1125_

---

### บลัดสตีล (BloodSteel) · uid 1126

<img src="../../icons/sk_1126.png" width="40" alt="icon"> 
**Tree:** ネクロマンサースキル (`NecromancerSkill`, tier 2) · **Type:** Special · **Max Lv:** 205 · **Weapons:** Rod · **Requires:** แฟนทอมมิสไซล์ · **Flags:** NoMarketSearch · **Client class:** `BloodSteelAction`

> เนโครแมนซีที่ทำให้เกิดคำสาปดูดเลือด
> ดูดซับความเสียหายที่สร้างให้เป้าหมายบางส่วนกลับมาเป็น HP
> ระวังว่ามีโอกาศที่จะดูดซับสภาวะผิดปกติมาด้วย
> เพิ่มโอกาสที่จะทำให้เป้าหมาย[ผงะ]เมื่อ VIT เกิน 50
> คำสาปจะถูกยกเลิกทันทีเมื่อโจมตีจากระยะไกล

**How it works**

- Special skill of the ネクロマンサースキル tree (tier 2, max Lv 205); usable with Rod.
- It installs a buff on the caster.
- It can inflict a status ailment (chance and type below).
- Its buff exposes motion / combo hooks, so it changes the attack pattern while active (heuristic; the client has no explicit flag).
- `NormalAttackAction` looks its buff up and changes how normal attacks run while it is active.
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Flinch (1).
- Buffs:
  - `BloodSteelBuf`: lasts `(((Lv << 1) + lv) << 2)` s
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 call
- `ActionHit` — when the attack connects: 2 call

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1126
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Rolls `percent`% to inflict **Flinch (1)** (`calcPlayerToMobDamage`)
- Marks the hit with ailment **Flinch (1)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction)`

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `BloodSteelBuf` — `.ctor(Lv, actarAction, target)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): adds the caster's buff of `new BloodSteelBuf` — `AddSelfBuffer(new BloodSteelBuf, Id)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Other recovered parameters**

- **Effect percent** (`percent`): `((((baseVIT // 50) + ((baseVIT // 50) << 2)) << 2) lt 100 ? (((baseVIT // 50) + ((baseVIT // 50) << 2)) << 2) : 100)`

**Buff values** (every recovered field; durations in seconds)

**Buff `BloodSteelBuf`**
- **Changes the attack pattern**: the buff object drives a motion/combo chain (`ChangeHyperMode`, `get_BufEffectTakeId`).
- **Modifies normal attacks**: `NormalAttackAction` looks this buff up while it builds the normal-attack damage / hit logic.
- Buff hook methods: `ChangeHyperMode`, `CheckLineConnect`, `OnCall`, `OnEnd`, `get_BufEffectTakeId`
- Duration: `(((Lv << 1) + lv) << 2)` s
- Buff fields set in the constructor (all recovered):
  - `bufRange` = `MathUtil.DisplayMeterToDistance(8)`
  - `playerAction` = `playerAction`
  - `target` = `target`
  - `mobAction` = `UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target)`
  - `isEffectiveRange` = `1` = 1
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
- Hook `OnCall`: `effect`=UnityEngine.GameObject.AddComponent<BloodSteelBuf.LineEffect>(UnityEngine.Component.get_gameObject([[Singleton<TakeManager>.get_Instance()+0x20]+0x30][takeUid]))
- Hook `CheckLineConnect`: `isEffectiveRange`=0; `LeftTime`=(LeftTime / 10); `isEffectiveRange`=1; `LeftTime`=(LeftTime * 10)
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:BloodSteelBuf$$.ctor<-BloodSteelAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

**Where else this skill takes effect**

- Effect applied in `EnemyMobActionManagerBase$$SetHyperModeStatus` (300 guarded paths, truncated):
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
- Code that reads this skill's level / buff by constant id: `EnemyMobActionManagerBase$$SetHyperModeStatus (TryGetBuf)`

_Raw recovered data (every method item): [trees/NecromancerSkill.md](../trees/NecromancerSkill.md) — uid 1126_

---

### ซัมมอนสเกเลตัน (SummonSkeleton) · uid 1127

<img src="../../icons/sk_1127.png" width="40" alt="icon"> 
**Tree:** ネクロマンサースキル (`NecromancerSkill`, tier 2) · **Type:** Object · **Max Lv:** 205 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เกรฟดิกเกอร์ · **Flags:** NoMarketSearch · **Client class:** `SummonSkeletonAction`

> ใช้สแต็ควิญญาณx3เพื่อเรียกอัศวินโครงกระดูก
> (ไม่เกินครั้งละ 3 ตัว)
> อัศวินโครงกระดูกจะโจมตีระยะประชิด
> และจะระเบิดหายไปเมื่อมีการโจมตีโดยรอบ
> พลังโจมตีถูกกำหนดโดย ATK หรือ MATK ที่สูงกว่า

**How it works**

- Object skill of the ネクロマンサースキル tree (tier 2, max Lv 205); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It places an object in the world (trap, summon or field object).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×0.1 at Lv1 to 1 at Lv10
- Proration: normal-attack proration slot, mode `never (IsExpDefFluctuate=false)`.
- Other client code reads this skill (3 lookups; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(100)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `SetHarvest` — skill-specific method: 1 set
- `InitializeOthers` — setup used when another player's client replays the action: 6 set
- `ActionPreparation` — before the cast starts: 3 set
- `ActionSkillReceiveEffect` — skill-specific method: 3 set
- `ActionSkillEvent` — on an animation/skill event during the motion: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 1 tpl, 1 info
- `CreateTake` — skill-specific method: 1 set
- `SetPlacePos` — skill-specific method: 4 set
- `OnEndMoveAction` — skill-specific method: 3 set
- `OnEndMoveFollow` — skill-specific method: 3 set
- `<ActionSkillEvent>b__76_0` — skill-specific method: 1 set
- `<ActionSkillEvent>b__76_1` — skill-specific method: 1 set
- `<OnEndMoveFollow>b__88_0` — skill-specific method: 1 set
- `<OnEndMoveFollow>b__88_1` — skill-specific method: 1 set
- `<OnEndMoveFollow>b__88_2` — skill-specific method: 1 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.1 | 0.2 | 0.3 | 0.4 | 0.5 | 0.6 | 0.7 | 0.8 | 0.9 | 1 |

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv + (Lv << 2)) << 1)) / 100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Normal`, mode `never (IsExpDefFluctuate=false)`, attack type `Physics`, action id 1127
- Uses the normal-attack proration slot but never changes monster proration: IsExpDefFluctuate=false.

**Where else this skill takes effect**

- Effect applied in `GlaiveTiggerBuf$$.ctor` (1 guarded path):
  - always
    - returns `SkillLv(1127)`
    - set `bufferType` = `(SkillLv(1127) gt 0 ? 12 : 3)`
    - set `Count` = `0`
    - set `skillActionManager` = `[[playerAction+0x30]+0x30]`
    - set `playerStatus` = `?blr`
    - calls `CountBufferBase$$.ctor`, `0x165d8dc`, `0x165d8dc`
- Code that reads this skill's level / buff by constant id: `GlaiveTiggerBuf$$.ctor (GetSkillLv)`, `PlayerBattleManager$$HarvestSummonSkeleton (GetSkillLv)`, `PlayerBattleManager$$StartSummonSkeletonBomb (GetSkillLv)`

_Raw recovered data (every method item): [trees/NecromancerSkill.md](../trees/NecromancerSkill.md) — uid 1127_

---

### ฮาร์เวสต์ (Harvest) · uid 1128

<img src="../../icons/sk_1128.png" width="40" alt="icon"> 
**Tree:** ネクロマンサースキル (`NecromancerSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 205 · **Weapons:** Rod · **Requires:** พลั่วชั้นดี · **Flags:** NoMarketSearch · **Client class:** `Harvest` (passive mastery)

> ฟื้นฟู HP และ MP เล็กน้อยทันทีเมื่อกำจัดมอนสเตอร์
> (เปิดใช้งานหนึ่งครั้งต่อวินาที)
> 
> ถ้าเรียนรู้สกิล[ซัมมอนสเกลตัน]แล้ว
> จะเรียกอัศวินโครงกระดูกออกมาเมื่อฟื้นฟู
> (จำนวนไม่เกินขีดจำกัดสูงสุด)

**How it works**

- Mastery skill of the ネクロマンサースキル tree (tier 2, max Lv 205); usable with Rod.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.

_Raw recovered data (every method item): [trees/NecromancerSkill.md](../trees/NecromancerSkill.md) — uid 1128_

---

### เดนเจอร์เชค (DengerShake) · uid 1129

<img src="../../icons/sk_1129.png" width="40" alt="icon"> 
**Tree:** ネクロマンサースキル (`NecromancerSkill`, tier 3) · **Type:** Attack · **Max Lv:** 260 · **Weapons:** Rod, Halberd · **Requires:** สกัลเชคเกอร์ · **Flags:** NoMarketSearch · **Client class:** `DengerShakeAction`

> เทคนิคการใช้พลองที่ปรับเปลี่ยนได้ตามสถานการณ์
> โจมตีทางกายภาพเพิ่มเติมได้โดยการกดคีย์ ใช้เพิ่มอีก 100 MP
> ข้างหน้า (พลังสูง), ซ้ายขวา (ลดความเสียหาย), ข้างหลัง (แบ็คสเต็ป)

**How it works**

- Attack skill of the ネクロマンサースキル tree (tier 3, max Lv 260); usable with Rod, Halberd.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [isFirst ne 0 AND skillRate.Length ne 0]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [!UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) le 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND param eq 100 AND param ne 101 & attackDir eq 1 AND attackDir lo skillRate.Length AND isFirst eq 0 OR attackDir lo skillRate.Length AND attackDir ne 1 AND isFirst eq 0]: skill multiplier depends on live values (formula below); skill multiplier depends on live values (formula below); skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [!InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !UnityEngine.Object.op_Equality(actarAction) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND param eq 100 AND param ne 101 & attackDir eq 1 AND attackDir lo skillRate.Length AND isFirst eq 0 OR attackDir lo skillRate.Length AND attackDir ne 1 AND isFirst eq 0]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [isFirst ne 0 AND skillRate.Length ne 0 OR attackDir eq 1 AND attackDir lo skillRate.Length AND isFirst eq 0 OR attackDir lo skillRate.Length AND attackDir ne 1 AND isFirst eq 0]: flat damage +100
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Buffs:
  - `DengerShakeBuf`; Lv1 → Lv10: MotionSpeed (motion speed +) 50 → 50
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 6 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionStart` — when the cast starts: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 5 tpl, 1 info
- `NextRangeHit` — next range-hit pass: 1 set
- `ActionSkillEvent` — on an animation/skill event during the motion: 6 set
- `ApplyDamageCut` — skill-specific method: 1 set
- `.<>c__DisplayClass35_0::<ActionStart>b__0` — skill-specific method: 2 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(skillRate[0] / 100)` — isFirst ne 0 AND skillRate.Length ne 0
- SkillRate × `(skillRate[(1)] / 100)` — !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) le 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND param eq 100 AND param ne 101 & attackDir eq 1 AND attackDir lo skillRate.Length AND isFirst eq 0 OR attackDir lo skillRate.Length AND attackDir ne 1 AND isFirst eq 0
- SkillRate × `(skillRate[(1)] / 100)` — !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) le 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND param eq 100 AND param ne 101 & attackDir eq 1 AND attackDir lo skillRate.Length AND isFirst eq 0 OR attackDir lo skillRate.Length AND attackDir ne 1 AND isFirst eq 0
- SkillRate × `(skillRate[(1)] / 100)` — !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) le 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND param eq 100 AND param ne 101 & attackDir eq 1 AND attackDir lo skillRate.Length AND isFirst eq 0 OR attackDir lo skillRate.Length AND attackDir ne 1 AND isFirst eq 0
- SkillRate × `(skillRate[(1)] / 100)` — !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !UnityEngine.Object.op_Equality(actarAction) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND param eq 100 AND param ne 101 & attackDir eq 1 AND attackDir lo skillRate.Length AND isFirst eq 0 OR attackDir lo skillRate.Length AND attackDir ne 1 AND isFirst eq 0

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(skillRate[0] / 100)`
  - when `isFirst ne 0 AND skillRate.Length ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(100)`
  - when `isFirst ne 0 AND skillRate.Length ne 0 OR attackDir eq 1 AND attackDir lo skillRate.Length AND isFirst eq 0 OR attackDir lo skillRate.Length AND attackDir ne 1 AND isFirst eq 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(target.ExpDefSkill / 100)`
  - when `isFirst ne 0 AND skillRate.Length ne 0 OR attackDir eq 1 AND attackDir lo skillRate.Length AND isFirst eq 0 OR attackDir lo skillRate.Length AND attackDir ne 1 AND isFirst eq 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(skillRate[(1)] / 100)`
  - when `attackDir eq 1 AND attackDir lo skillRate.Length AND isFirst eq 0 OR attackDir lo skillRate.Length AND attackDir ne 1 AND isFirst eq 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`
  - when `isFirst ne 0 AND skillRate.Length ne 0 OR attackDir eq 1 AND attackDir lo skillRate.Length AND isFirst eq 0 OR attackDir lo skillRate.Length AND attackDir ne 1 AND isFirst eq 0`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1129
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `.<>c__DisplayClass35_0::<ActionStart>b__0` (method): constructs `DengerShakeBuf` — `.ctor()`
- `.<>c__DisplayClass35_0::<ActionStart>b__0` (method): adds the caster's buff of `new DengerShakeBuf` — `AddSelfBuffer(new DengerShakeBuf, [<>c__DisplayClass35_0.<>4__this+0x10])`

**Buff values** (every recovered field; durations in seconds)

**Buff `DengerShakeBuf`**

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MotionSpeed | 50 | 50 | 50 | 50 | 50 | 50 | 50 | 50 | 50 | 50 |

**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:DengerShakeBuf$$.ctor<-DengerShakeAction.<>c__DisplayClass35_0$$<ActionStart>b__0` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

Parameter meanings (inferred from the `SkillBufferId` names):

- `MotionSpeed`: motion speed +

**Where else this skill takes effect**

- Effect applied in `PlayerAttackBase$$RemoveAfterSkillBuf` (295 guarded paths, truncated):
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
- Code that reads this skill's level / buff by constant id: `PlayerAttackBase$$RemoveAfterSkillBuf (TryGetBuf)`

_Raw recovered data (every method item): [trees/NecromancerSkill.md](../trees/NecromancerSkill.md) — uid 1129_

---

### โซลสตรีม (SoulStream) · uid 1130

<img src="../../icons/sk_1130.png" width="40" alt="icon"> 
**Tree:** ネクロマンサースキル (`NecromancerSkill`, tier 3) · **Type:** Object · **Max Lv:** 260 · **Weapons:** Rod · **Requires:** บลัดสตีล · **Flags:** NoMarketSearch · **Client class:** `SoulStreamAction`

> เนโครแมนซีที่ยิงปืนใหญ่อนุภาควิญญาณ
> โจมตีเป้าหมายด้วยเวทมนตร์  อัตราทำให้[เฉื่อยชา]
> เพิ่มขึ้นตามสแต็ควิญญาณที่ใช้ไปพร้อมกับฟื้นฟู MP
> สแต็ควิญญาณที่ใช้จะขึ้นอยู่กับจำนวน
> MP ที่ใช้ไปในขณะที่ร่าย(สูงสุด 20 )

**How it works**

- Object skill of the ネクロマンサースキル tree (tier 3, max Lv 260); usable with Rod.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- It places an object in the world (trap, summon or field object).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on live values (formula below); flat damage +495 at Lv1 to 900 at Lv10
  - `calcPlayerToMobDamage` [(max((status.MaxMp - (PlayerStatusBase.get_GameStatus().localExMp + PlayerStatusBase.get_GameStatus().localMp)), 0) // 100) gt TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121).Count AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [(max((status.MaxMp - (PlayerStatusBase.get_GameStatus().localExMp + PlayerStatusBase.get_GameStatus().localMp)), 0) // 100) le TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121).Count AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)]: skill multiplier depends on live values (formula below)
- Proration: magic proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Weak (15).

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1.5, PlayerActionManagerBase.get_PlayerStatus())`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 5 set
- `ActionPreparation` — before the cast starts: 6 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 2 call, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 495 | 540 | 585 | 630 | 675 | 720 | 765 | 810 | 855 | 900 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((((Lv * 100) + baseINT)) / 100)`
- SkillRate × `((((Lv * 100) + baseINT)) / 100)` — (max((status.MaxMp - (PlayerStatusBase.get_GameStatus().localExMp + PlayerStatusBase.get_GameStatus().localMp)), 0) // 100) gt TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121).Count AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- SkillRate × `((((Lv * 100) + baseINT)) / 100)` — (max((status.MaxMp - (PlayerStatusBase.get_GameStatus().localExMp + PlayerStatusBase.get_GameStatus().localMp)), 0) // 100) le TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121).Count AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv * 100) + baseINT)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv * 45) + 450))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 1130
- Uses the magic proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Rolls `abnormalPer`% to inflict **Weak (15)** (`calcPlayerToMobDamage`)
- Marks the hit with ailment **Weak (15)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 15, abnormalPer, playerAction)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1.5, PlayerActionManagerBase.get_PlayerStatus())`

_Raw recovered data (every method item): [trees/NecromancerSkill.md](../trees/NecromancerSkill.md) — uid 1130_

---

### ซัมมอนเดโมนิก (SummonDemonic) · uid 1131

<img src="../../icons/sk_1131.png" width="40" alt="icon"> 
**Tree:** ネクロマンサースキル (`NecromancerSkill`, tier 3) · **Type:** Extra · **Max Lv:** 260 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ซัมมอนสเกเลตัน · **Flags:** NoMarketSearch · **Client class:** `SummonDemonicAction`

> ทำพันธสัญญากับปีศาจ
> ประสิทธิภาพจะเปลี่ยนไปตามปริมาณ MP ที่ใช้ทำสัญญา
> ปีศาจจะดูด HP ของผู้ร่ายเพื่อแลกกับการโจมตีในแต่ละครั้ง
> สามารถยุติสัญญากับปีศาจได้โดยการใช้สกิลนี้อีกครั้ง
> หากสถานการณ์เลวร้ายอาจเกิดการทรยศหักหลัง

**How it works**

- Extra skill of the ネクロマンサースキル tree (tier 3, max Lv 260); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- MP: `0` (conditional variants below).
- Buffs:
  - `SummonDemonicBuf`
- Other client code reads this skill (23 lookups; see the last section).

**Cost, timing and range**

- **MP cost** (`mp` in `calcCostMp`): `0` = 0
  - when `hasBuff(1131)`
- **MP cost** (`costMp` in `calcCostMp`): `0` = 0
  - when `hasBuff(1131)`
- **MP cost** (`mp` in `calcCostMp`): `((PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) gt 100 ? (PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) : 100)`
  - when `!hasBuff(1131)`
- **MP cost** (`costMp` in `calcCostMp`): `((PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) gt 100 ? (PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) : 100)`
  - when `!hasBuff(1131)`
- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `calcCostMp` — skill-specific method: 4 set
- `GetDamageResistRate` — skill-specific method: 1 call
- `ChangeHateManaged` — skill-specific method: 1 call
- `PartyAcceptance` — skill-specific method: 1 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1131
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ChangeHateManaged` (method): removes the caster's buff of skill 1131 (SummonDemonic) — `RemoveSelfBuffer(1131)`
  - when `CharacterActionManagerBase.AddAbnormalState(UnityEngine.Component.get_gameObject(playerAction), 3, 5, 0, 0, 0, 1) AND UnityEngine.Random.Range(0, 100) lt int((((100 - PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus())) * (100 - PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()))) / 200)) AND hasBuff(1131) OR !CharacterActionManagerBase.AddAbnormalState(UnityEngine.Component.get_gameObject(playerAction), 3, 5, 0, 0, 0, 1) AND UnityEngine.Random.Range(0, 100) lt int((((100 - PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus())) * (100 - PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()))) / 200)) AND hasBuff(1131) OR CharacterActionManagerBase.AddAbnormalState(UnityEngine.Component.get_gameObject(playerAction), 3, 5, 0, 0, 0, 1) AND TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 15, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager())) ne 0 AND UnityEngine.Random.Range(0, 100) lt int((((100 - PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus())) * (100 - PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()))) / 200)) AND hasBuff(1131)`
- `PartyAcceptance` (method): removes the caster's buff of skill 1131 (SummonDemonic) — `RemoveSelfBuffer(1131)`
  - when `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1131) ne 0`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`
- **MP cost** (`mp`): `0` = 0 _(when hasBuff(1131))_; `((PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) gt 100 ? (PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) : 100)` _(when !hasBuff(1131))_
- **MP cost** (`costMp`): `0` = 0 _(when hasBuff(1131))_; `((PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) gt 100 ? (PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) : 100)` _(when !hasBuff(1131))_

**Buff values** (every recovered field; durations in seconds)

**Buff `SummonDemonicBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `BufferEnd`, `SetBloodContract`, `SetSummonMp`
- `MaxHpUpRate` = `maxHpRate`
- `Value` = `(mp)`
- Buff fields set in the constructor (all recovered):
  - `summonMp` = `mp`
- Hook `SetBloodContract`: `maxHpRate`=-50
- Hook `SetSummonMp`: `summonMp`=mp

Parameter meanings (inferred from the `SkillBufferId` names):

- `MaxHpUpRate`: max HP %
- `Value`: generic value (meaning set by the code that reads the buff)

**Where else this skill takes effect**

- Effect applied in `ReceiveSupportResult$$OnActionPlayerSupport` (3 guarded paths):
  - when `skillId gt 709` AND `skillId gt 1025` AND `skillId gt 1039` AND `skillId gt 1090`
    - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillId, skillLv, supportData), 0, ?x2, ?x3), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_AbnormalStateManager`, `AbnormalStateManager$$Recovery`, `PlayerDataManager$$get_PlayerArchetypeId`, `AutoMemberManager$$TryGetAutoMember`, `PlayerDataManager$$get_PlayerStatus`
  - when `skillId gt 709` AND `skillId gt 1025` AND `skillId gt 1039` AND `skillId gt 1090`
    - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillId, skillLv, supportData), 0, ?x2, ?x3), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_AbnormalStateManager`, `AbnormalStateManager$$Recovery`, `PlayerDataManager$$get_PlayerArchetypeId`, `AutoMemberManager$$TryGetAutoMember`, `PlayerDataManager$$get_PlayerStatus`
  - when `skillId gt 709` AND `skillId gt 1025` AND `skillId gt 1039` AND `skillId gt 1090`
    - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillId, skillLv, supportData), 0, ?x2, ?x3), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_AbnormalStateManager`, `AbnormalStateManager$$Recovery`, `PlayerDataManager$$get_PlayerArchetypeId`, `AutoMemberManager$$TryGetAutoMember`, `PlayerDataManager$$get_PlayerStatus`
- Effect applied in `PhotonListener$$OnActionRoomChangeHateMine` (300 guarded paths, truncated):
  - always
    - calls `Debug$$Log`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$GetEnemyHateState`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - returns `System.Collections.Generic.Dictionary<object, Int32Enum>.get_Item(0x165db78(meta(0x39b5838, System.Collections.Generic.Dictionary<IMobIdData, EnemyMobActionManagerBase.HateState>_TypeInfo), ?x1, ?x2, ?x3), ?idx, meta(0x39b5830, Method$System.Collections.Generic.Dictionary<IMobIdData, EnemyMobActionManagerBase.HateState>.get_Item()), ?x3)`
    - calls `Debug$$Log`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$GetEnemyHateState`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - calls `Debug$$Log`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$GetEnemyHateState`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - returns `System.Collections.Generic.Dictionary<object, Int32Enum>.get_Item(0x165db78(meta(0x39b5838, System.Collections.Generic.Dictionary<IMobIdData, EnemyMobActionManagerBase.HateState>_TypeInfo), ?x1, ?x2, ?x3), ?idx, meta(0x39b5830, Method$System.Collections.Generic.Dictionary<IMobIdData, EnemyMobActionManagerBase.HateState>.get_Item()), ?x3)`
    - calls `Debug$$Log`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$GetEnemyHateState`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - calls `Debug$$Log`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$GetEnemyHateState`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - returns `System.Collections.Generic.Dictionary<object, Int32Enum>.get_Item(0x165db78(meta(0x39b5838, System.Collections.Generic.Dictionary<IMobIdData, EnemyMobActionManagerBase.HateState>_TypeInfo), ?x1, ?x2, ?x3), ?idx, meta(0x39b5830, Method$System.Collections.Generic.Dictionary<IMobIdData, EnemyMobActionManagerBase.HateState>.get_Item()), ?x3)`
    - calls `Debug$$Log`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$GetEnemyHateState`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - calls `Debug$$Log`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$GetEnemyHateState`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - calls `Debug$$Log`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$GetEnemyHateState`, `TargetableListManagerBase<object>$$get_Instance`
- Effect applied in `PhotonListener$$OnActionPartyChangeHateMine` (300 guarded paths, truncated):
  - always
    - calls `Debug$$Log`, `Singleton<object>$$get_Instance`, `PartyManager$$get_IsParty`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - returns `System.Collections.Generic.Dictionary<object, Int32Enum>.get_Item(0x165db78(meta(0x39b5838, System.Collections.Generic.Dictionary<IMobIdData, EnemyMobActionManagerBase.HateState>_TypeInfo), ?x1, ?x2, ?x3), ?idx, meta(0x39b5830, Method$System.Collections.Generic.Dictionary<IMobIdData, EnemyMobActionManagerBase.HateState>.get_Item()), ?x3)`
    - calls `Debug$$Log`, `Singleton<object>$$get_Instance`, `PartyManager$$get_IsParty`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - calls `Debug$$Log`, `Singleton<object>$$get_Instance`, `PartyManager$$get_IsParty`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - returns `System.Collections.Generic.Dictionary<object, Int32Enum>.get_Item(0x165db78(meta(0x39b5838, System.Collections.Generic.Dictionary<IMobIdData, EnemyMobActionManagerBase.HateState>_TypeInfo), ?x1, ?x2, ?x3), ?idx, meta(0x39b5830, Method$System.Collections.Generic.Dictionary<IMobIdData, EnemyMobActionManagerBase.HateState>.get_Item()), ?x3)`
    - calls `Debug$$Log`, `Singleton<object>$$get_Instance`, `PartyManager$$get_IsParty`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - calls `Debug$$Log`, `Singleton<object>$$get_Instance`, `PartyManager$$get_IsParty`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - returns `System.Collections.Generic.Dictionary<object, Int32Enum>.get_Item(0x165db78(meta(0x39b5838, System.Collections.Generic.Dictionary<IMobIdData, EnemyMobActionManagerBase.HateState>_TypeInfo), ?x1, ?x2, ?x3), ?idx, meta(0x39b5830, Method$System.Collections.Generic.Dictionary<IMobIdData, EnemyMobActionManagerBase.HateState>.get_Item()), ?x3)`
    - calls `Debug$$Log`, `Singleton<object>$$get_Instance`, `PartyManager$$get_IsParty`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - calls `Debug$$Log`, `Singleton<object>$$get_Instance`, `PartyManager$$get_IsParty`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - calls `Debug$$Log`, `Singleton<object>$$get_Instance`, `PartyManager$$get_IsParty`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `PlayerDataManager$$get_GemCartBufManager`, `0x165db78`, `TargetableListManagerBase<object>$$get_Instance`
- Effect applied in `MainPlayer$$PlayerDead` (178 guarded paths, truncated):
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
- Effect applied in `PhotonListener$$OnActionPartyChangeHateActor` (22 guarded paths):
  - always
    - calls `0x165db78`, `PhotonListener.<>c__DisplayClass151_0$$.ctor`, `0x165d8dc`, `Debug$$Log`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$IsPlayerHateManager`
  - always
    - returns `UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(0, ?x1, ?x2, ?x3), 0, 0, ?x3)`
    - calls `0x165db78`, `PhotonListener.<>c__DisplayClass151_0$$.ctor`, `0x165d8dc`, `Debug$$Log`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$IsPlayerHateManager`
  - always
    - returns `System.Linq.Enumerable.FirstOrDefault<object>(PartyManager.get_MemberData(Singleton<object>.get_Instance(meta(0x3974068, Method$Singleton<PartyManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3), 0x165db78(meta(0x3974800, System.Func<PartyMemberData, bool>_TypeInfo), ?x1, ?x2, ?x3), meta(0x39747f8, Method$System.Linq.Enumerable.FirstOrDefault<PartyMemberData>()), ?x3)`
    - calls `0x165db78`, `PhotonListener.<>c__DisplayClass151_0$$.ctor`, `0x165d8dc`, `Debug$$Log`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$IsPlayerHateManager`
  - always
    - calls `0x165db78`, `PhotonListener.<>c__DisplayClass151_0$$.ctor`, `0x165d8dc`, `Debug$$Log`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$IsPlayerHateManager`
  - always
    - returns `UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(0, ?x1, ?x2, ?x3), 0, 0, ?x3)`
    - calls `0x165db78`, `PhotonListener.<>c__DisplayClass151_0$$.ctor`, `0x165d8dc`, `Debug$$Log`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$IsPlayerHateManager`
  - always
    - returns `System.Linq.Enumerable.FirstOrDefault<object>(PartyManager.get_MemberData(Singleton<object>.get_Instance(meta(0x3974068, Method$Singleton<PartyManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3), 0x165db78(meta(0x3974800, System.Func<PartyMemberData, bool>_TypeInfo), ?x1, ?x2, ?x3), meta(0x39747f8, Method$System.Linq.Enumerable.FirstOrDefault<PartyMemberData>()), ?x3)`
    - calls `0x165db78`, `PhotonListener.<>c__DisplayClass151_0$$.ctor`, `0x165d8dc`, `Debug$$Log`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$IsPlayerHateManager`
  - always
    - calls `0x165db78`, `PhotonListener.<>c__DisplayClass151_0$$.ctor`, `0x165d8dc`, `Debug$$Log`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$IsPlayerHateManager`
  - always
    - returns `UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(0, ?x1, ?x2, ?x3), 0, 0, ?x3)`
    - calls `0x165db78`, `PhotonListener.<>c__DisplayClass151_0$$.ctor`, `0x165d8dc`, `Debug$$Log`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$IsPlayerHateManager`
- Effect applied in `PhotonListener$$OnActionRoomChangeHateActor` (40 guarded paths):
  - always
    - returns `SongOfLifeAction.ChangeHate(PlayerDataManager.get_PlayerActionManager(PlayerDataManager.GetPlayerDataManager(0, ?x1, ?x2, ?x3), 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$IsPlayerHateManager`, `TargetableListManagerBase<object>$$get_Instance`, `OtherPlayerManager$$GetOtherPlayer`, `0x165d9d4`, `0x165da6c`
  - always
    - returns `UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(0, ?x1, ?x2, ?x3), 0, 0, ?x3)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$IsPlayerHateManager`, `TargetableListManagerBase<object>$$get_Instance`, `OtherPlayerManager$$GetOtherPlayer`, `0x165d9d4`, `0x165da6c`
  - always
    - returns `SongOfLifeAction.ChangeHate(PlayerDataManager.get_PlayerActionManager(PlayerDataManager.GetPlayerDataManager(0, ?x1, ?x2, ?x3), 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$IsPlayerHateManager`, `TargetableListManagerBase<object>$$get_Instance`, `OtherPlayerManager$$GetOtherPlayer`, `0x165d9d4`, `0x165da6c`
  - always
    - returns `UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(0, ?x1, ?x2, ?x3), 0, 0, ?x3)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$IsPlayerHateManager`, `TargetableListManagerBase<object>$$get_Instance`, `OtherPlayerManager$$GetOtherPlayer`, `0x165d9d4`, `0x165da6c`
  - always
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$IsPlayerHateManager`, `TargetableListManagerBase<object>$$get_Instance`, `OtherPlayerManager$$GetOtherPlayer`, `0x165d9d4`, `0x165da6c`
  - always
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$IsPlayerHateManager`, `TargetableListManagerBase<object>$$get_Instance`, `OtherPlayerManager$$GetOtherPlayer`, `0x165d9d4`, `0x165da6c`
  - always
    - returns `SongOfLifeAction.ChangeHate(PlayerDataManager.get_PlayerActionManager(PlayerDataManager.GetPlayerDataManager(0, ?x1, ?x2, ?x3), 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$IsPlayerHateManager`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$IsPlayerHateManager`, `TargetableListManagerBase<object>$$get_Instance`, `OtherPlayerManager$$GetOtherPlayer`
  - always
    - returns `UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(0, ?x1, ?x2, ?x3), 0, 0, ?x3)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$IsPlayerHateManager`, `TargetableListManagerBase<object>$$get_Instance`, `MobObjectManager$$IsPlayerHateManager`, `TargetableListManagerBase<object>$$get_Instance`, `OtherPlayerManager$$GetOtherPlayer`
- Effect applied in `SummonDemonicAction$$ChangeHateManaged` (5 guarded paths):
  - when `TryGetAutoMember.out3() ne 0`
    - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 1131, 0, ?x3)`
    - calls `PlayerStatusBase$$GetHpPercent`, `UnityEngine.Random$$Range`, `UnityEngine.Component$$get_gameObject`, `BufferEffectManager$$AbnormalEffectPlay`, `Singleton<object>$$get_Instance`, `0x165db78`, `System.Collections.Generic.List<object>$$.ctor`, `GameManager$$ActionSuppportDelay`
  - when `TryGetAutoMember.out3() eq 0`
    - calls `PlayerStatusBase$$GetHpPercent`, `UnityEngine.Random$$Range`, `UnityEngine.Component$$get_gameObject`, `BufferEffectManager$$AbnormalEffectPlay`, `Singleton<object>$$get_Instance`, `0x165db78`, `System.Collections.Generic.List<object>$$.ctor`, `GameManager$$ActionSuppportDelay`
  - always
    - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 1131, 0, ?x3)`
    - calls `PlayerStatusBase$$GetHpPercent`, `UnityEngine.Random$$Range`, `UnityEngine.Component$$get_gameObject`, `BufferEffectManager$$AbnormalEffectPlay`, `Singleton<object>$$get_Instance`, `0x165db78`, `System.Collections.Generic.List<object>$$.ctor`, `GameManager$$ActionSuppportDelay`
  - always
    - returns `UnityEngine.Random.Range(0, 100, 0, ?x3)`
    - calls `PlayerStatusBase$$GetHpPercent`, `UnityEngine.Random$$Range`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1131, 0, ?x3)`
- Effect applied in `SummonDemonicAction$$calcCostMp` (2 guarded paths):
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1131, 0, ?x3)`
    - set `mp` = `0`
    - set `costMp` = `0`
  - always
    - returns `PlayerAttackBase.CalcCostMp(this, playerAction, 0, ?x3)`
    - set `mp` = `((PlayerAttackBase.CalcCostMp(this, playerAction, 0, ?x3) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction, 0, ?x3) : 2000) gt 100 ? (PlayerAttackBase.CalcCostMp(this, playerAction, 0, ?x3) lt 2000 ? PlayerAttackBase.CalcCostMp(this`
    - set `costMp` = `((PlayerAttackBase.CalcCostMp(this, playerAction, 0, ?x3) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction, 0, ?x3) : 2000) gt 100 ? (PlayerAttackBase.CalcCostMp(this, playerAction, 0, ?x3) lt 2000 ? PlayerAttackBase.CalcCostMp(this`
    - calls `PlayerAttackBase$$CalcCostMp`
- Effect applied in `SummonDemonicAction$$IsFailure` (3 guarded paths):
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `Singleton<object>$$get_Instance`, `PartyManager$$get_MemberData`, `TargetableListManagerBase<object>$$get_Instance`, `OtherPlayerManager$$ContainsOtherPlayer`, `0x165db7c`, `0x165db7c`, `0x14cfadc`
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `Singleton<object>$$get_Instance`, `PartyManager$$get_MemberData`, `TargetableListManagerBase<object>$$get_Instance`, `OtherPlayerManager$$ContainsOtherPlayer`, `TargetableListManagerBase<object>$$get_Instance`, `OtherPlayerManager$$ContainsOtherPlayer`, `TargetableListManagerBase<object>$$get_Instance`
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
- Effect applied in `SummonDemonicAttackAction$$ActionHit` (3 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `?blr`
    - calls `SkillActionBase$$ActionHit`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `SkillActionBase$$ActionHit`, `0x165db84`, `0x165df00`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0)`
    - calls `SkillActionBase$$ActionHit`
- Effect applied in `SummonDemonicSpecialAttack$$ActionHit` (3 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `?blr`
    - calls `SkillActionBase$$ActionHit`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `SkillActionBase$$ActionHit`, `0x165db84`, `0x165df00`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0)`
    - calls `SkillActionBase$$ActionHit`
- Effect applied in `SummonDemonicAttackAction$$OnInitialize` (11 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add(meta(0), 7, PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
    - set `ActionRange` = `-1`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `constantDamage` = `((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) lt 0 ? (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + 1) : SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)) >> 1)`
    - set `skillRate` = `((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) // 20) + 100)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `attackType` = `2`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerStatusBase$$GetEquipElement`, `SkillBufferDataBase$$GetParam`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillSummonDemonic$$CheckAbility`, `ExSkillSummonDemonic$$CheckAbility`, `PlayerAttackBase$$CalcMotionSpeed`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add(meta(0), 7, PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
    - set `ActionRange` = `-1`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `constantDamage` = `((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) lt 0 ? (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + 1) : SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)) >> 1)`
    - set `skillRate` = `((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) // 20) + 100)`
    - set `_motionSpeed` = `100`
    - set `attackType` = `2`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerStatusBase$$GetEquipElement`, `SkillBufferDataBase$$GetParam`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillSummonDemonic$$CheckAbility`, `ExSkillSummonDemonic$$CheckAbility`, `0x165db78`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add(meta(0), 7, PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
    - set `ActionRange` = `-1`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `constantDamage` = `((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) lt 0 ? (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + 1) : SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)) >> 1)`
    - set `skillRate` = `((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) // 20) + 100)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerStatusBase$$GetEquipElement`, `SkillBufferDataBase$$GetParam`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillSummonDemonic$$CheckAbility`, `ExSkillSummonDemonic$$CheckAbility`, `PlayerAttackBase$$CalcMotionSpeed`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add(meta(0), 7, PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
    - set `ActionRange` = `-1`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `constantDamage` = `((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) lt 0 ? (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + 1) : SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)) >> 1)`
    - set `skillRate` = `((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) // 20) + 100)`
    - set `_motionSpeed` = `100`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerStatusBase$$GetEquipElement`, `SkillBufferDataBase$$GetParam`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillSummonDemonic$$CheckAbility`, `ExSkillSummonDemonic$$CheckAbility`, `0x165db78`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add(meta(0), 7, PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
    - set `ActionRange` = `-1`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `constantDamage` = `((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) lt 0 ? (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + 1) : SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)) >> 1)`
    - set `skillRate` = `((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) // 20) + 100)`
    - set `_motionSpeed` = `100`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerStatusBase$$GetEquipElement`, `SkillBufferDataBase$$GetParam`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - set `ActionRange` = `-1`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - calls `PlayerStatusBase$$GetEquipElement`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) eq 0`
    - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add(meta(0), 7, PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
    - set `ActionRange` = `-1`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `constantDamage` = `0`
    - set `skillRate` = `((mul64(0, 0x66666667) >> 35) + 100)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `attackType` = `2`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerStatusBase$$GetEquipElement`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillSummonDemonic$$CheckAbility`, `ExSkillSummonDemonic$$CheckAbility`, `PlayerAttackBase$$CalcMotionSpeed`, `0x165db78`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) eq 0`
    - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add(meta(0), 7, PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
    - set `ActionRange` = `-1`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `constantDamage` = `0`
    - set `skillRate` = `((mul64(0, 0x66666667) >> 35) + 100)`
    - set `_motionSpeed` = `100`
    - set `attackType` = `2`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerStatusBase$$GetEquipElement`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillSummonDemonic$$CheckAbility`, `ExSkillSummonDemonic$$CheckAbility`, `0x165db78`, `SkillLinkedTake$$.ctor`
- Effect applied in `SummonDemonicSpecialAttack$$OnInitialize` (11 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add(meta(0), 7, PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
    - set `ActionRange` = `-1`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `constantDamage` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)`
    - set `skillRate` = `(int((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) * 0.9)) + 200)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `attackType` = `2`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerStatusBase$$GetEquipElement`, `SkillBufferDataBase$$GetParam`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillSummonDemonic$$CheckAbility`, `ExSkillSummonDemonic$$CheckAbility`, `PlayerAttackBase$$CalcMotionSpeed`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add(meta(0), 7, PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
    - set `ActionRange` = `-1`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `constantDamage` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)`
    - set `skillRate` = `(int((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) * 0.9)) + 200)`
    - set `_motionSpeed` = `100`
    - set `attackType` = `2`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerStatusBase$$GetEquipElement`, `SkillBufferDataBase$$GetParam`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillSummonDemonic$$CheckAbility`, `ExSkillSummonDemonic$$CheckAbility`, `0x165db78`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add(meta(0), 7, PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
    - set `ActionRange` = `-1`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `constantDamage` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)`
    - set `skillRate` = `(int((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) * 0.9)) + 200)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerStatusBase$$GetEquipElement`, `SkillBufferDataBase$$GetParam`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillSummonDemonic$$CheckAbility`, `ExSkillSummonDemonic$$CheckAbility`, `PlayerAttackBase$$CalcMotionSpeed`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add(meta(0), 7, PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
    - set `ActionRange` = `-1`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `constantDamage` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)`
    - set `skillRate` = `(int((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) * 0.9)) + 200)`
    - set `_motionSpeed` = `100`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerStatusBase$$GetEquipElement`, `SkillBufferDataBase$$GetParam`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillSummonDemonic$$CheckAbility`, `ExSkillSummonDemonic$$CheckAbility`, `0x165db78`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add(meta(0), 7, PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
    - set `ActionRange` = `-1`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `constantDamage` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)`
    - set `skillRate` = `(int((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) * 0.9)) + 200)`
    - set `_motionSpeed` = `100`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerStatusBase$$GetEquipElement`, `SkillBufferDataBase$$GetParam`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - set `ActionRange` = `-1`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - calls `PlayerStatusBase$$GetEquipElement`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) eq 0`
    - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add(meta(0), 7, PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
    - set `ActionRange` = `-1`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `constantDamage` = `0`
    - set `skillRate` = `200`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `attackType` = `2`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerStatusBase$$GetEquipElement`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillSummonDemonic$$CheckAbility`, `ExSkillSummonDemonic$$CheckAbility`, `PlayerAttackBase$$CalcMotionSpeed`, `0x165db78`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) eq 0`
    - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add(meta(0), 7, PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
    - set `ActionRange` = `-1`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `constantDamage` = `0`
    - set `skillRate` = `200`
    - set `_motionSpeed` = `100`
    - set `attackType` = `2`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerStatusBase$$GetEquipElement`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_ExSkillManager`, `ExSkillManager$$TryGetExSkillData<object>`, `ExSkillSummonDemonic$$CheckAbility`, `ExSkillSummonDemonic$$CheckAbility`, `0x165db78`, `SkillLinkedTake$$.ctor`
- Effect applied in `SummonDemonicAI$$.ctor` (19 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `0x165d8dc(0x165d9d4(meta(0x39a04d8, SummonDemonic.DemonThinkingRoutineBase[]_TypeInfo), System.Array.get_Length(System.Enum.GetValues(System.Type.GetTypeFromHandle(meta(0x39a0510, SummonDemonic.DemonThinkingRoutineBase.ThinkingRoutine_var), 0, ?x2, ?x3), 0, ?x2, ?x3), 0, ?x2, ?x3), ?x2, ?x3), 0x165db78(meta(0x39a04e8, SummonDemonic.DemonThinkingRoutineEventAreaMove_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
    - set `ownerLastMovePos` = `meta(0)`
    - set `+0x58` = `meta(0)`
    - set `ownerMovePoint` = `0x165db78(meta(0x39a0508, System.Collections.Generic.List<SummonDemonicAI.MapPointData>_TypeInfo), actor, actorActionManager, owner)`
    - set `actor` = `actor`
    - set `actorActionManager` = `actorActionManager`
    - set `owner` = `owner`
    - set `ownerActionManager` = `ownerActionManager`
    - set `charaMove` = `charaMove`
    - set `animation` = `animation`
    - set `ArchetypeUid` = `IUserArchetype.get_ArchetypeUid(UnityEngine.GameObject.GetComponent<object>(actor, meta(0x397a658, Method$UnityEngine.GameObject.GetComponent<IUserArchetype>()), ?x2, ?x3))`
    - set `player` = `PlayerDataManager.GetPlayerDataManager(0, ?mi, ?x2, ?x3)`
    - set `specialAttackPercent` = `(int((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) / 100)) + specialAttackPercent)`
    - calls `0x165db78`, `System.Collections.Generic.List<object>$$.ctor`, `0x165d8dc`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - set `ownerLastMovePos` = `meta(0)`
    - set `+0x58` = `meta(0)`
    - set `ownerMovePoint` = `0x165db78(meta(0x39a0508, System.Collections.Generic.List<SummonDemonicAI.MapPointData>_TypeInfo), actor, actorActionManager, owner)`
    - set `actor` = `actor`
    - set `actorActionManager` = `actorActionManager`
    - set `owner` = `owner`
    - set `ownerActionManager` = `ownerActionManager`
    - set `charaMove` = `charaMove`
    - set `animation` = `animation`
    - set `ArchetypeUid` = `IUserArchetype.get_ArchetypeUid(UnityEngine.GameObject.GetComponent<object>(actor, meta(0x397a658, Method$UnityEngine.GameObject.GetComponent<IUserArchetype>()), ?x2, ?x3))`
    - set `player` = `PlayerDataManager.GetPlayerDataManager(0, ?mi, ?x2, ?x3)`
    - set `specialAttackPercent` = `(int((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) / 100)) + specialAttackPercent)`
    - calls `0x165db78`, `System.Collections.Generic.List<object>$$.ctor`, `0x165d8dc`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - set `ownerLastMovePos` = `meta(0)`
    - set `+0x58` = `meta(0)`
    - set `ownerMovePoint` = `0x165db78(meta(0x39a0508, System.Collections.Generic.List<SummonDemonicAI.MapPointData>_TypeInfo), actor, actorActionManager, owner)`
    - set `actor` = `actor`
    - set `actorActionManager` = `actorActionManager`
    - set `owner` = `owner`
    - set `ownerActionManager` = `ownerActionManager`
    - set `charaMove` = `charaMove`
    - set `animation` = `animation`
    - set `ArchetypeUid` = `IUserArchetype.get_ArchetypeUid(UnityEngine.GameObject.GetComponent<object>(actor, meta(0x397a658, Method$UnityEngine.GameObject.GetComponent<IUserArchetype>()), ?x2, ?x3))`
    - set `player` = `PlayerDataManager.GetPlayerDataManager(0, ?mi, ?x2, ?x3)`
    - set `specialAttackPercent` = `(int((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) / 100)) + specialAttackPercent)`
    - calls `0x165db78`, `System.Collections.Generic.List<object>$$.ctor`, `0x165d8dc`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - set `ownerLastMovePos` = `meta(0)`
    - set `+0x58` = `meta(0)`
    - set `ownerMovePoint` = `0x165db78(meta(0x39a0508, System.Collections.Generic.List<SummonDemonicAI.MapPointData>_TypeInfo), actor, actorActionManager, owner)`
    - set `actor` = `actor`
    - set `actorActionManager` = `actorActionManager`
    - set `owner` = `owner`
    - set `ownerActionManager` = `ownerActionManager`
    - set `charaMove` = `charaMove`
    - set `animation` = `animation`
    - set `ArchetypeUid` = `IUserArchetype.get_ArchetypeUid(UnityEngine.GameObject.GetComponent<object>(actor, meta(0x397a658, Method$UnityEngine.GameObject.GetComponent<IUserArchetype>()), ?x2, ?x3))`
    - set `player` = `PlayerDataManager.GetPlayerDataManager(0, ?mi, ?x2, ?x3)`
    - set `specialAttackPercent` = `(int((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) / 100)) + specialAttackPercent)`
    - calls `0x165db78`, `System.Collections.Generic.List<object>$$.ctor`, `0x165d8dc`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - set `ownerLastMovePos` = `meta(0)`
    - set `+0x58` = `meta(0)`
    - set `ownerMovePoint` = `0x165db78(meta(0x39a0508, System.Collections.Generic.List<SummonDemonicAI.MapPointData>_TypeInfo), actor, actorActionManager, owner)`
    - set `actor` = `actor`
    - set `actorActionManager` = `actorActionManager`
    - set `owner` = `owner`
    - set `ownerActionManager` = `ownerActionManager`
    - set `charaMove` = `charaMove`
    - set `animation` = `animation`
    - set `ArchetypeUid` = `IUserArchetype.get_ArchetypeUid(UnityEngine.GameObject.GetComponent<object>(actor, meta(0x397a658, Method$UnityEngine.GameObject.GetComponent<IUserArchetype>()), ?x2, ?x3))`
    - set `player` = `PlayerDataManager.GetPlayerDataManager(0, ?mi, ?x2, ?x3)`
    - set `specialAttackPercent` = `(int((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) / 100)) + specialAttackPercent)`
    - calls `0x165db78`, `System.Collections.Generic.List<object>$$.ctor`, `0x165d8dc`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - set `ownerLastMovePos` = `meta(0)`
    - set `+0x58` = `meta(0)`
    - set `ownerMovePoint` = `0x165db78(meta(0x39a0508, System.Collections.Generic.List<SummonDemonicAI.MapPointData>_TypeInfo), actor, actorActionManager, owner)`
    - set `actor` = `actor`
    - set `actorActionManager` = `actorActionManager`
    - set `owner` = `owner`
    - set `ownerActionManager` = `ownerActionManager`
    - set `charaMove` = `charaMove`
    - set `animation` = `animation`
    - set `ArchetypeUid` = `IUserArchetype.get_ArchetypeUid(UnityEngine.GameObject.GetComponent<object>(actor, meta(0x397a658, Method$UnityEngine.GameObject.GetComponent<IUserArchetype>()), ?x2, ?x3))`
    - set `player` = `PlayerDataManager.GetPlayerDataManager(0, ?mi, ?x2, ?x3)`
    - set `specialAttackPercent` = `(int((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) / 100)) + specialAttackPercent)`
    - calls `0x165db78`, `System.Collections.Generic.List<object>$$.ctor`, `0x165d8dc`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - set `ownerLastMovePos` = `meta(0)`
    - set `+0x58` = `meta(0)`
    - set `ownerMovePoint` = `0x165db78(meta(0x39a0508, System.Collections.Generic.List<SummonDemonicAI.MapPointData>_TypeInfo), actor, actorActionManager, owner)`
    - set `actor` = `actor`
    - set `actorActionManager` = `actorActionManager`
    - set `owner` = `owner`
    - set `ownerActionManager` = `ownerActionManager`
    - set `charaMove` = `charaMove`
    - set `animation` = `animation`
    - set `ArchetypeUid` = `IUserArchetype.get_ArchetypeUid(UnityEngine.GameObject.GetComponent<object>(actor, meta(0x397a658, Method$UnityEngine.GameObject.GetComponent<IUserArchetype>()), ?x2, ?x3))`
    - set `player` = `PlayerDataManager.GetPlayerDataManager(0, ?mi, ?x2, ?x3)`
    - set `specialAttackPercent` = `(int((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) / 100)) + specialAttackPercent)`
    - calls `0x165db78`, `System.Collections.Generic.List<object>$$.ctor`, `0x165d8dc`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - set `ownerLastMovePos` = `meta(0)`
    - set `+0x58` = `meta(0)`
    - set `ownerMovePoint` = `0x165db78(meta(0x39a0508, System.Collections.Generic.List<SummonDemonicAI.MapPointData>_TypeInfo), actor, actorActionManager, owner)`
    - set `actor` = `actor`
    - set `actorActionManager` = `actorActionManager`
    - set `owner` = `owner`
    - set `ownerActionManager` = `ownerActionManager`
    - set `charaMove` = `charaMove`
    - set `animation` = `animation`
    - set `ArchetypeUid` = `IUserArchetype.get_ArchetypeUid(UnityEngine.GameObject.GetComponent<object>(actor, meta(0x397a658, Method$UnityEngine.GameObject.GetComponent<IUserArchetype>()), ?x2, ?x3))`
    - set `player` = `PlayerDataManager.GetPlayerDataManager(0, ?mi, ?x2, ?x3)`
    - set `specialAttackPercent` = `(int((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) / 100)) + specialAttackPercent)`
    - calls `0x165db78`, `System.Collections.Generic.List<object>$$.ctor`, `0x165d8dc`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`
- Code that reads this skill's level / buff by constant id: `GameManager$$ReceiveSummons (GetSkillLv)`, `MainPlayer$$PlayerDead (ContainsBuffer)`, `PhotonListener$$OnActionPartyChangeHateActor (ContainsBuffer)`, `PhotonListener$$OnActionPartyChangeHateMine (ContainsBuffer)`, `PhotonListener$$OnActionRoomChangeHateActor (ContainsBuffer)`, `PhotonListener$$OnActionRoomChangeHateMine (ContainsBuffer)`, `PlayerActionManager$$Damaged (ContainsBuffer)`, `ReceiveSupportResult$$OnActionPlayerSupport (TryGetBuf)`, `ReceiveSupportResult$$OnEventNpcSupport (TryGetBuf)`, `ReceiveSupportResult$$OnEventPlayerSupport (TryGetBuf)`, `SummonDemonicAI$$.ctor (TryGetBuf)`, `SummonDemonicAction$$ChangeHateManaged (ContainsBuffer)`, `SummonDemonicAction$$IsFailure (ContainsBuffer)`, `SummonDemonicAction$$calcCostMp (ContainsBuffer)`, `SummonDemonicActionManager$$BattleReservSpecialAttack (GetSkillLv)`, `SummonDemonicActionManager$$BattleReserveNormalAttack (GetSkillLv)`, `SummonDemonicAttackAction$$ActionHit (TryGetBuf)`, `SummonDemonicAttackAction$$OnInitialize (TryGetBuf)`, `SummonDemonicSpecialAttack$$ActionHit (TryGetBuf)`, `SummonDemonicSpecialAttack$$OnInitialize (TryGetBuf)`, `UIExSkillManager$$ExSkillList (GetSkillLv)`, `UINecromancerExSkillManager$$Initialize (GetSkillLv)`, `UISkillTreeManager$$SkillTreeList (GetSkillLv)`

_Raw recovered data (every method item): [trees/NecromancerSkill.md](../trees/NecromancerSkill.md) — uid 1131_

---

### แผนตลบหลัง (MatchPump) · uid 1132

<img src="../../icons/sk_1132.png" width="40" alt="icon"> 
**Tree:** ネクロマンサースキル (`NecromancerSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 260 · **Weapons:** Rod · **Requires:** ฮาร์เวสต์ · **Flags:** NoMarketSearch · **Client class:** `MatchPump` (passive mastery)

> อัศวินโครงกระดูกที่ระเบิดหายไปแล้ว
> ก็มีโอกาสได้รับผลของสกิล[ฮาร์เวสต์ ]

**How it works**

- Mastery skill of the ネクロマンサースキル tree (tier 3, max Lv 260); usable with Rod.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.

_Raw recovered data (every method item): [trees/NecromancerSkill.md](../trees/NecromancerSkill.md) — uid 1132_

---
