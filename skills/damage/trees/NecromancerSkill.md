# ネクロマンサースキル (`NecromancerSkill`)

12 entries. See ../README.md for how to read these blocks.

### เกรฟดิกเกอร์ (GlaiveTigger) · uid 1121

<img src="../../icons/sk_1121.png" width="40" alt="icon"> 
**Tree:** ネクロマンサースキル (`NecromancerSkill`, tier 1) · **Type:** Object · **Max Lv:** 1 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** NoMarketSearch · **Client class:** `GlaiveTiggerAction`

> เปิดสุสานแห่งจินตนาการเพื่อเตรียมใช้วิชาเนโครแมนเซอร์
> 
> เมื่ออยู่ในสุสานจะเริ่มสะสมสแต็ควิญญาณ
> ถ้าออกจากสุสานวิญญาณจะค่อยๆ หายไป

<details><summary>In-game level notes</summary>

- Lv14: ไม่ว่าจะเป็นสกิลเลเวลใดก็จะได้รับสแต็ควิญญาณทุกวินาที จำนวนสแต็ควิญญาณที่คุณได้รับจะเพิ่มการฟื้นฟู MP การโจมตี และความต้านทานต่อสภาวะผิดปกติ  การฟื้นฟู MP การโจมตีต่อจำนวนสแต็ควิญญาณและ ความต้านทานต่อสภาวะผิดปกติจะเพิ่มขึ้นตามเลเวลสกิล

</details>

**Role:** buff (self) · placed object / trap / summon

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Effect radius (Unity units)** (`Radius`): `MathUtil.DisplayMeterToDistance(3)`; `(Radius + MathUtil.DisplayMeterToDistance((SkillMasteryBase.GetMasteryParam(MasteryId.Value) / 10)))` _(when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isNewPlace ne 0 AND mainWeapon == Rod OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isNewPlace eq 0 AND mainWeapon == Rod)_

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1121

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (2 paths)

- set `ActionRange` = `-1` = -1
- set `Radius` = `MathUtil.DisplayMeterToDistance(3)`
- set `isNewPlace` = `(?mvn & 1)` — when UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager)
- set `isNewPlace` = `1` = 1 — when !UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager)

**`InitializeOthers`** (4 paths)

- set `ActionRange` = `-1` = -1

**`ActionStart`** (9 paths)

- set `placePos` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x` — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isNewPlace ne 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isNewPlace eq 0 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND isNewPlace ne 0
- set `placePos.y` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y` — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isNewPlace ne 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isNewPlace eq 0 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND isNewPlace ne 0
- set `placePos.z` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z` — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isNewPlace ne 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isNewPlace eq 0 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction) AND isNewPlace ne 0
- set `Radius` = `(Radius + MathUtil.DisplayMeterToDistance((SkillMasteryBase.GetMasteryParam(MasteryId.Value) / 10)))` — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isNewPlace ne 0 AND mainWeapon == Rod OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isNewPlace eq 0 AND mainWeapon == Rod

**`.<>c__DisplayClass24_0::<ActionStart>b__0`** (5 paths)

- calls `GlaiveTiggerBuf..ctor` = `.ctor([<>c__DisplayClass24_0.<>4__this+0x14], <>c__DisplayClass24_0.playerAction)` — when <>c__DisplayClass24_0.weaponType eq 14
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new GlaiveTiggerBuf, [<>c__DisplayClass24_0.<>4__this+0x10])` — when <>c__DisplayClass24_0.weaponType eq 14

</details>

**Buffs**

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

<details><summary>Effect applied in `PlayerSecondaryStatus$$get_AtkMpRecovery` (280 guarded paths, truncated)</summary>

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

</details>

<details><summary>Effect applied in `MobaPlayerSecondaryStatus$$get_AntiVirus` (25 guarded paths)</summary>

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

<details><summary>Effect applied in `PlayerSecondaryStatus$$CalcAntiVirus` (25 guarded paths)</summary>

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

<details><summary>Effect applied in `GlaiveTiggerBuf$$SetCountValue` (3 guarded paths)</summary>

- when `value ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1121, stkp(-40), 0) & 1) eq 0`
  - returns `GlaiveTiggerBuf.SetCount(0x165db78(meta(0x39a9410, GlaiveTiggerBuf_TypeInfo), ?x1, ?x2, ?x3), value, ?x2, ?x3)`
  - calls `0x165db78`, `GlaiveTiggerBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `GlaiveTiggerBuf$$SetCount`
- when `value ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1121, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `GlaiveTiggerBuf.SetCount(TryGetBuf.out2(), value, ?x2, ?x3)`
  - calls `GlaiveTiggerBuf$$SetCount`
- when `value ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1121, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `0x165db84`, `0x165df00`

</details>

<details><summary>Effect applied in `GlaiveTiggerAction$$InitializeOthers` (4 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `PhantomMissileAction$$IsFailure` (4 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `GlaiveTiggerAction.<>c__DisplayClass24_0$$<ActionStart>b__0` (5 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `SummonSkeletonAction$$IsFailure` (4 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `SummonSkeletonAction$$ActionPreparation` (3 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `PhantomMissileAction$$ActionPreparation` (3 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `TombAction$$ActionPreparation` (5 guarded paths)</summary>

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

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `GlaiveTiggerAction$$InitializeOthers (GetSkillLv)`
- `GlaiveTiggerAction.<>c__DisplayClass24_0$$<ActionStart>b__0 (TryGetBuf)`
- `GlaiveTiggerBuf$$SetCountValue (GetSkillLv)`
- `GlaiveTiggerBuf$$SetCountValue (TryGetBuf)`
- `MobaPlayerSecondaryStatus$$get_AntiVirus (TryGetBuf)`
- `PhantomMissileAction$$ActionPreparation (TryGetBuf)`
- `PhantomMissileAction$$IsFailure (TryGetBuf)`
- `PlayerSecondaryStatus$$CalcAntiVirus (TryGetBuf)`
- `PlayerSecondaryStatus$$get_AtkMpRecovery (TryGetBuf)`
- `SummonSkeletonAction$$ActionPreparation (TryGetBuf)`
- `SummonSkeletonAction$$IsFailure (TryGetBuf)`
- `TombAction$$ActionPreparation (TryGetBuf)`

---

### ทูม (Tomb) · uid 1122

<img src="../../icons/sk_1122.png" width="40" alt="icon"> 
**Tree:** ネクロマンサースキル (`NecromancerSkill`, tier 1) · **Type:** Attack · **Max Lv:** 1 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** NoMarketSearch · **Client class:** `TombAction`

> เนโครแมนเซอร์ที่ใช้ศิลาหน้าหลุมศพโจมตี
> สร้างความเสียหายทางกายภาพแก่เป้าหมาย
> เมื่อ VIT มากกว่า 50 จะเพิ่มโอกาสทำให้เป้าหมาย[ล้มคว่ำ]
> หากใช้สแต็ควิญญาณx3 จะเพิ่มการโจมตีบริเวณโดยรอบ
> สามารถเปิดใช้งานพร้อมกันได้สูงสุด 3 ครั้ง

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [(SkillActionBase.get_AttackCount(this) & 255) ne 0] | 1.6 | 1.7 | 1.8 | 1.9 | 2 | 2.1 | 2.2 | 2.3 | 2.4 | 2.5 |
| SkillRate × [(SkillActionBase.get_AttackCount(this) & 255) eq 0 OR (SkillActionBase.get_AttackCount(this) & 255) eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalPercent, playerAction) AND (SkillActionBase.get_AttackCount(this) & 255) eq 0] | 2.5 | 2.5 | 2.5 | 2.5 | 2.5 | 2.5 | 2.5 | 2.5 | 2.5 | 2.5 |
| Flat dmg + [(SkillActionBase.get_AttackCount(this) & 255) ne 0] | 30 | 60 | 90 | 120 | 150 | 180 | 210 | 240 | 270 | 300 |
| Flat dmg + [(SkillActionBase.get_AttackCount(this) & 255) eq 0 OR (SkillActionBase.get_AttackCount(this) & 255) eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalPercent, playerAction) AND (SkillActionBase.get_AttackCount(this) & 255) eq 0] | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 |

**Role:** attack (deals damage) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `((Lv * 30))` | `(300)`
- `SkillRate` multiplies by (adds into): `((((Lv * 10) + 150)) / 100)` | `((250) / 100)`
- `ExpRate` sets: `(target.ExpDefSkill / 100)` | `(targetExpRegister[mobAction] / 100)`

**Mechanics recovered from code**

- **Chance to inflict the skill's status ailment (%)** (`abnormalPercent`): `System.Math.Min((((baseVIT // 50) + ((baseVIT // 50) << 2)) << 2), 100)`
- **Loop / hit-repeat count** (`LoopParam`): `motionSpeed`; `System.Math.Min((SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121), 20) // 3), 3)` _(when !PlayerAttackBase.IsBlank(this) AND System.Math.Min((SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121), 20) // 3), 3) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND System.Math.Min((SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121), 20) // 3), 3) lt 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction))_
- **Effect radius (Unity units)** (`Radius`): `MathUtil.DisplayMeterToDistance(3)` _(when (((UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z) * (UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z)) + ((UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x) * (UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x))) le ((MathUtil.DisplayMeterToDistance(3) + size) * (MathUtil.DisplayMeterToDistance(3) + size)) AND (SkillActionBase.get_AttackCount(this) & 255) ne 0 AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).y), size) OR (((UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z) * (UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z)) + ((UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x) * (UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x))) gt ((MathUtil.DisplayMeterToDistance(3) + size) * (MathUtil.DisplayMeterToDistance(3) + size)) AND (SkillActionBase.get_AttackCount(this) & 255) ne 0 AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).y), size))_

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1122

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(7)`
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `skillRate` = `250` = 250
- set `fixAddDamage` = `300` = 300
- set `pursuitFixDamage` = `(Lv * 30)` = 30
- set `pursuitRate` = `((Lv * 10) + 150)` = 160
- set `abnormalPercent` = `System.Math.Min((((baseVIT // 50) + ((baseVIT // 50) << 2)) << 2), 100)`

**`InitializeOthers`** (2 paths)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`
- set `LoopParam` = `motionSpeed`

**`ActionPreparation`** (9 paths)

- set `LoopParam` = `System.Math.Min((SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121), 20) // 3), 3)` — when !PlayerAttackBase.IsBlank(this) AND System.Math.Min((SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121), 20) // 3), 3) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND System.Math.Min((SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121), 20) // 3), 3) lt 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `SkillIndividualFlag` = `System.Math.Min((SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121), 20) // 3), 3)` — when !PlayerAttackBase.IsBlank(this) AND System.Math.Min((SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121), 20) // 3), 3) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND System.Math.Min((SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121), 20) // 3), 3) lt 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)

**`ActionStart`** (1 path)

- set `target` = `UnityEngine.GameObject.get_transform(target)`

**`CheckRangeHit`** (4 paths)

- set `Radius` = `MathUtil.DisplayMeterToDistance(3)` — when (((UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z) * (UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z)) + ((UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x) * (UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x))) le ((MathUtil.DisplayMeterToDistance(3) + size) * (MathUtil.DisplayMeterToDistance(3) + size)) AND (SkillActionBase.get_AttackCount(this) & 255) ne 0 AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).y), size) OR (((UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z) * (UnityEngine.Transform.get_position(targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z)) + ((UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x) * (UnityEngine.Transform.get_position(targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x))) gt ((MathUtil.DisplayMeterToDistance(3) + size) * (MathUtil.DisplayMeterToDistance(3) + size)) AND (SkillActionBase.get_AttackCount(this) & 255) ne 0 AND PlayerAttackBase.checkRangeHeight(this, (UnityEngine.Transform.get_position(targetTransform).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).y), size)

**`calcPlayerToMobDamage`** (20 paths)

- template `SetRate[ExpRate]` = `(target.ExpDefSkill / 100)`
- template `AddRate[SkillRate]` = `(pursuitRate / 100)` — when (SkillActionBase.get_AttackCount(this) & 255) ne 0
- template `AddConstant[SkillConstantDamage]` = `pursuitFixDamage` — when (SkillActionBase.get_AttackCount(this) & 255) ne 0
- calls `PlayerAttackBase.SetBufferConstantDamage` = `SetBufferConstantDamage(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), (LoopParam + 1))`
- info `templates` = `1`
- template `AddRate[SkillRate]` = `(skillRate / 100)` — when (SkillActionBase.get_AttackCount(this) & 255) eq 0 OR (SkillActionBase.get_AttackCount(this) & 255) eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalPercent, playerAction) AND (SkillActionBase.get_AttackCount(this) & 255) eq 0
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage` — when (SkillActionBase.get_AttackCount(this) & 255) eq 0 OR (SkillActionBase.get_AttackCount(this) & 255) eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalPercent, playerAction) AND (SkillActionBase.get_AttackCount(this) & 255) eq 0
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(2, abnormalPercent, playerAction)` — when (SkillActionBase.get_AttackCount(this) & 255) eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalPercent, playerAction) AND (SkillActionBase.get_AttackCount(this) & 255) eq 0
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(2, 0)` — when (SkillActionBase.get_AttackCount(this) & 255) eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalPercent, playerAction)
- template `SetRate[ExpRate]` = `(targetExpRegister[mobAction] / 100)`

</details>

---

### แฟนทอมมิสไซล์ (PhantomMissile) · uid 1123

<img src="../../icons/sk_1123.png" width="40" alt="icon"> 
**Tree:** ネクロマンサースキル (`NecromancerSkill`, tier 1) · **Type:** Object · **Max Lv:** 1 · **Weapons:** Rod · **Requires:** เกรฟดิกเกอร์ · **Flags:** NoMarketSearch · **Client class:** `PhantomMissileAction`

> เนโครแมนเซอร์ที่โจมตีด้วยการปล่อยวิญญาณชั่วร้าย
> ใช้สแต็ควิญญาณ (สูงสุด 10)
> เพื่อสร้างความเสียหายเวทมนตร์แก่เป้าหมาย
> ยิ่งใช้วิญญาณมากขึ้นจะยิ่งเพิ่มระยะเวลา (จำนวน HIT)
> ทุกครั้งที่ติดคริติคอล(เกณฑ์ทางกายภาพ)พลังจะเพิ่มขึ้น

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [(LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0] | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 |
| SkillRate × [(LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0] | 1.1 | 1.2 | 1.3 | 1.4 | 1.5 | 1.6 | 1.7 | 1.8 | 1.9 | 2 |
| SkillRate × [(LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 lt (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0] | 1.2 | 1.4 | 1.6 | 1.8 | 2 | 2.2 | 2.4 | 2.6 | 2.8 | 3 |
| Flat dmg + | 500 | 500 | 500 | 500 | 500 | 500 | 500 | 500 | 500 | 500 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((100) / 100)` — (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 & (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0
- SkillRate × `((100) / 100)` — (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 & (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0
- SkillRate × `((100) / 100)` — (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 lt (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 & (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0
- SkillRate × `(((Lv * 10) + (100)) / 100)` — (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 & (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0
- SkillRate × `(((Lv * 10) + (100)) / 100)` — (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 & (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0
- SkillRate × `(((Lv * 10) + (100)) / 100)` — (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 lt (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 & (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0
- SkillRate × `(((Lv * 10) + ((Lv * 10) + (100))) / 100)` — (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 & (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 lt (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0
- SkillRate × `(((Lv * 10) + ((Lv * 10) + (100))) / 100)` — (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 & (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 lt (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0

**Role:** attack (deals damage) · placed object / trap / summon

The skill builds 3 separate damage templates (each is a full hit with its own crit roll). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(500)`
- `SkillRate` multiplies by (adds into): `((100) / 100)` | `(((Lv * 10) + (100)) / 100)` | `(((Lv * 10) + ((Lv * 10) + (100))) / 100)`
- `ExpRate` sets: `(target.ExpDefMagic / 100)` | `(targetMagicExp / 100)`

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0.5, PlayerActionManagerBase.get_PlayerStatus())`
- **Loop / hit-repeat count** (`LoopParam`): `(System.Math.Min(SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121), 20), 10) - 1)` _(when TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction))_; `motionSpeed`

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 1123

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(24)`
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 0.5, PlayerActionManagerBase.get_PlayerStatus())`
- set `skillRate` = `100` = 100
- set `fixAddDamage` = `500` = 500

**`ActionPreparation`** (4 paths)

- set `SkillIndividualFlag` = `System.Math.Min(SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121), 20), 10)` — when TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `LoopParam` = `(System.Math.Min(SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121), 20), 10) - 1)` — when TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `target` = `target`

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1
- set `LoopParam` = `motionSpeed`

**`ActionStartOthers`** (1 path)

- set `target` = `target`

**`calcPlayerToMobDamage`** (148 paths)

- set `skillRate` = `((Lv * 10) + skillRate)` — when (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0
- template `SetRate[ExpRate]` = `(target.ExpDefMagic / 100)` — when (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0
- template `AddRate[SkillRate]` = `(skillRate / 100)` — when (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage` — when (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0
- info `templates` = `1` — when (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0
- set `skillRate` = `((Lv * 10) + ((Lv * 10) + skillRate))` — when (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0
- template `AddRate[SkillRate]` = `(((Lv * 10) + skillRate) / 100)` — when (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0
- info `templates` = `2` — when (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0
- set `skillRate` = `((Lv * 10) + ((Lv * 10) + ((Lv * 10) + skillRate)))` — when (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 lt (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0
- template `AddRate[SkillRate]` = `(((Lv * 10) + ((Lv * 10) + skillRate)) / 100)` — when (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 lt (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0
- info `templates` = `3` — when (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 lt (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp eq 0 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 lt (LoopParam + 1) AND 3 ge (LoopParam + 1) AND targetMagicExp eq 0
- template `SetRate[ExpRate]` = `(targetMagicExp / 100)` — when (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND (LoopParam + 1) ge 1 AND 1 ge (LoopParam + 1) AND targetMagicExp ne 0 OR (LoopParam + 1) ge 1 AND 1 lt (LoopParam + 1) AND 2 ge (LoopParam + 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 6) AND targetMagicExp ne 0

**`.MoveEffect::Update`** (24 paths)

- set `moveSpeed` = `(MoveEffect.moveSpeed * 0.9)` — when MoveEffect.isEnd ne 0 AND fsqrt(((moveSpeed.z * moveSpeed.z) + ((MoveEffect.moveSpeed * MoveEffect.moveSpeed) + (moveSpeed.y * moveSpeed.y)))) gt 1e-05 OR MoveEffect.isEnd ne 0 AND fsqrt(((moveSpeed.z * moveSpeed.z) + ((MoveEffect.moveSpeed * MoveEffect.moveSpeed) + (moveSpeed.y * moveSpeed.y)))) le 1e-05
- set `moveSpeed.y` = `(moveSpeed.y * 0.9)` — when MoveEffect.isEnd ne 0 AND fsqrt(((moveSpeed.z * moveSpeed.z) + ((MoveEffect.moveSpeed * MoveEffect.moveSpeed) + (moveSpeed.y * moveSpeed.y)))) gt 1e-05 OR MoveEffect.isEnd ne 0 AND fsqrt(((moveSpeed.z * moveSpeed.z) + ((MoveEffect.moveSpeed * MoveEffect.moveSpeed) + (moveSpeed.y * moveSpeed.y)))) le 1e-05
- set `moveSpeed.z` = `(moveSpeed.z * 0.9)` — when MoveEffect.isEnd ne 0 AND fsqrt(((moveSpeed.z * moveSpeed.z) + ((MoveEffect.moveSpeed * MoveEffect.moveSpeed) + (moveSpeed.y * moveSpeed.y)))) gt 1e-05 OR MoveEffect.isEnd ne 0 AND fsqrt(((moveSpeed.z * moveSpeed.z) + ((MoveEffect.moveSpeed * MoveEffect.moveSpeed) + (moveSpeed.y * moveSpeed.y)))) le 1e-05
- set `moveSpeed.z` = `(moveSpeed.z + ((PhantomMissileAction.MoveEffect.get_accelDir(this).z * 75) * UnityEngine.Time.get_deltaTime()))` — when MoveEffect.isEnd eq 0 AND MoveEffect.isHit eq 0 AND MoveEffect.isHitCheck ne 0 AND fsqrt(((moveSpeed.z * moveSpeed.z) + ((MoveEffect.moveSpeed * MoveEffect.moveSpeed) + (moveSpeed.y * moveSpeed.y)))) gt 1e-05 OR MoveEffect.isEnd eq 0 AND MoveEffect.isHit ne 0 AND MoveEffect.isHitCheck ne 0 AND fsqrt(((moveSpeed.z * moveSpeed.z) + ((MoveEffect.moveSpeed * MoveEffect.moveSpeed) + (moveSpeed.y * moveSpeed.y)))) gt 1e-05 OR !PhantomMissileAction.MoveEffect.HitCheck(this) AND MoveEffect.isEnd eq 0 AND MoveEffect.isHitCheck eq 0 AND fsqrt(((moveSpeed.z * moveSpeed.z) + ((MoveEffect.moveSpeed * MoveEffect.moveSpeed) + (moveSpeed.y * moveSpeed.y)))) gt 1e-05
- set `isHit` = `(PhantomMissileAction.MoveEffect.HitCheck(this) & 1)` — when MoveEffect.isEnd eq 0 AND MoveEffect.isHit eq 0 AND MoveEffect.isHitCheck ne 0 AND fsqrt(((moveSpeed.z * moveSpeed.z) + ((MoveEffect.moveSpeed * MoveEffect.moveSpeed) + (moveSpeed.y * moveSpeed.y)))) gt 1e-05 OR MoveEffect.isEnd eq 0 AND MoveEffect.isHit eq 0 AND MoveEffect.isHitCheck ne 0 AND fsqrt(((moveSpeed.z * moveSpeed.z) + ((MoveEffect.moveSpeed * MoveEffect.moveSpeed) + (moveSpeed.y * moveSpeed.y)))) le 1e-05
- set `hitCheckOffTimer` = `0` = 0 — when !PhantomMissileAction.MoveEffect.HitCheck(this) AND MoveEffect.isEnd eq 0 AND MoveEffect.isHitCheck eq 0 AND fsqrt(((moveSpeed.z * moveSpeed.z) + ((MoveEffect.moveSpeed * MoveEffect.moveSpeed) + (moveSpeed.y * moveSpeed.y)))) gt 1e-05 OR !PhantomMissileAction.MoveEffect.HitCheck(this) AND MoveEffect.isEnd eq 0 AND MoveEffect.isHitCheck eq 0 AND fsqrt(((moveSpeed.z * moveSpeed.z) + ((MoveEffect.moveSpeed * MoveEffect.moveSpeed) + (moveSpeed.y * moveSpeed.y)))) le 1e-05 OR (MoveEffect.hitCheckOffTimer + UnityEngine.Time.get_deltaTime()) gt 1 AND MoveEffect.isEnd eq 0 AND MoveEffect.isHitCheck eq 0 AND PhantomMissileAction.MoveEffect.HitCheck(this) AND fsqrt(((moveSpeed.z * moveSpeed.z) + ((MoveEffect.moveSpeed * MoveEffect.moveSpeed) + (moveSpeed.y * moveSpeed.y)))) gt 1e-05
- set `isHitCheck` = `1` = 1 — when !PhantomMissileAction.MoveEffect.HitCheck(this) AND MoveEffect.isEnd eq 0 AND MoveEffect.isHitCheck eq 0 AND fsqrt(((moveSpeed.z * moveSpeed.z) + ((MoveEffect.moveSpeed * MoveEffect.moveSpeed) + (moveSpeed.y * moveSpeed.y)))) gt 1e-05 OR !PhantomMissileAction.MoveEffect.HitCheck(this) AND MoveEffect.isEnd eq 0 AND MoveEffect.isHitCheck eq 0 AND fsqrt(((moveSpeed.z * moveSpeed.z) + ((MoveEffect.moveSpeed * MoveEffect.moveSpeed) + (moveSpeed.y * moveSpeed.y)))) le 1e-05 OR (MoveEffect.hitCheckOffTimer + UnityEngine.Time.get_deltaTime()) gt 1 AND MoveEffect.isEnd eq 0 AND MoveEffect.isHitCheck eq 0 AND PhantomMissileAction.MoveEffect.HitCheck(this) AND fsqrt(((moveSpeed.z * moveSpeed.z) + ((MoveEffect.moveSpeed * MoveEffect.moveSpeed) + (moveSpeed.y * moveSpeed.y)))) gt 1e-05
- set `hitCheckOffTimer` = `(MoveEffect.hitCheckOffTimer + UnityEngine.Time.get_deltaTime())` — when (MoveEffect.hitCheckOffTimer + UnityEngine.Time.get_deltaTime()) le 1 AND MoveEffect.isEnd eq 0 AND MoveEffect.isHitCheck eq 0 AND PhantomMissileAction.MoveEffect.HitCheck(this) AND fsqrt(((moveSpeed.z * moveSpeed.z) + ((MoveEffect.moveSpeed * MoveEffect.moveSpeed) + (moveSpeed.y * moveSpeed.y)))) gt 1e-05 OR (MoveEffect.hitCheckOffTimer + UnityEngine.Time.get_deltaTime()) le 1 AND MoveEffect.isEnd eq 0 AND MoveEffect.isHitCheck eq 0 AND PhantomMissileAction.MoveEffect.HitCheck(this) AND fsqrt(((moveSpeed.z * moveSpeed.z) + ((MoveEffect.moveSpeed * MoveEffect.moveSpeed) + (moveSpeed.y * moveSpeed.y)))) le 1e-05

**`.MoveEffect::ChangeState`** (7 paths)

- set `state` = `state`
- set `isHit` = `0` = 0 — when MoveEffect.bounceCount ne 0 AND state eq 0 AND state ne 1 OR MoveEffect.bounceCount eq 0 AND state eq 0 AND state ne 1
- set `isHitCheck` = `0` = 0 — when MoveEffect.bounceCount ne 0 AND state eq 0 AND state ne 1
- set `isEnd` = `1` = 1 — when MoveEffect.bounceCount ge MoveEffect.maxBounce AND fsqrt((((UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z)) + ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x)))) gt 1e-05 AND state eq 1 OR MoveEffect.bounceCount ge MoveEffect.maxBounce AND fsqrt((((UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z)) + ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x)))) le 1e-05 AND state eq 1
- set `moveSpeed` = `(0 - (10 * ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x) / fsqrt((((UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z)) + ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x)))))))` — when MoveEffect.bounceCount ge MoveEffect.maxBounce AND fsqrt((((UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z)) + ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x)))) gt 1e-05 AND state eq 1
- set `moveSpeed.y` = `(moveSpeed.y - (10 * (0 / fsqrt((((UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z)) + ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x)))))))` — when MoveEffect.bounceCount ge MoveEffect.maxBounce AND fsqrt((((UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z)) + ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x)))) gt 1e-05 AND state eq 1
- set `moveSpeed.z` = `(0 - (10 * ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z) / fsqrt((((UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z)) + ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x)))))))` — when MoveEffect.bounceCount ge MoveEffect.maxBounce AND fsqrt((((UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z)) + ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x)))) gt 1e-05 AND state eq 1
- set `bounceCount` = `(MoveEffect.bounceCount + 1)` — when MoveEffect.bounceCount ge MoveEffect.maxBounce AND fsqrt((((UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z)) + ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x)))) gt 1e-05 AND state eq 1 OR MoveEffect.bounceCount ge MoveEffect.maxBounce AND fsqrt((((UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z)) + ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x)))) le 1e-05 AND state eq 1 OR MoveEffect.bounceCount lt MoveEffect.maxBounce AND fsqrt((((UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z)) + ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x)))) gt 1e-05 AND state eq 1
- set `moveSpeed` = `(0 - (10 * UnityEngine.Vector3.static+0x0))` — when MoveEffect.bounceCount ge MoveEffect.maxBounce AND fsqrt((((UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z)) + ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x)))) le 1e-05 AND state eq 1
- set `moveSpeed.y` = `(moveSpeed.y - (10 * UnityEngine.Vector3.static+0x4))` — when MoveEffect.bounceCount ge MoveEffect.maxBounce AND fsqrt((((UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z)) + ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x)))) le 1e-05 AND state eq 1
- set `moveSpeed.z` = `(0 - (10 * UnityEngine.Vector3.static+0x8))` — when MoveEffect.bounceCount ge MoveEffect.maxBounce AND fsqrt((((UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z)) + ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x)))) le 1e-05 AND state eq 1
- set `moveSpeed` = `(0 - ((MoveEffect.isEnd eq 0 ? 25 : 10) * ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x) / fsqrt((((UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z)) + ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x)))))))` — when MoveEffect.bounceCount lt MoveEffect.maxBounce AND fsqrt((((UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z)) + ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x)))) gt 1e-05 AND state eq 1
- set `moveSpeed.y` = `(moveSpeed.y - ((MoveEffect.isEnd eq 0 ? 25 : 10) * (0 / fsqrt((((UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z)) + ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x)))))))` — when MoveEffect.bounceCount lt MoveEffect.maxBounce AND fsqrt((((UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z)) + ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x)))) gt 1e-05 AND state eq 1
- set `moveSpeed.z` = `(0 - ((MoveEffect.isEnd eq 0 ? 25 : 10) * ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z) / fsqrt((((UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z)) + ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x)))))))` — when MoveEffect.bounceCount lt MoveEffect.maxBounce AND fsqrt((((UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z)) + ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x)))) gt 1e-05 AND state eq 1
- set `moveSpeed` = `(0 - ((MoveEffect.isEnd eq 0 ? 25 : 10) * UnityEngine.Vector3.static+0x0))` — when MoveEffect.bounceCount lt MoveEffect.maxBounce AND fsqrt((((UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z)) + ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x)))) le 1e-05 AND state eq 1
- set `moveSpeed.y` = `(moveSpeed.y - ((MoveEffect.isEnd eq 0 ? 25 : 10) * UnityEngine.Vector3.static+0x4))` — when MoveEffect.bounceCount lt MoveEffect.maxBounce AND fsqrt((((UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z)) + ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x)))) le 1e-05 AND state eq 1
- set `moveSpeed.z` = `(0 - ((MoveEffect.isEnd eq 0 ? 25 : 10) * UnityEngine.Vector3.static+0x8))` — when MoveEffect.bounceCount lt MoveEffect.maxBounce AND fsqrt((((UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).z)) + ((UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x) * (UnityEngine.Transform.get_position(MoveEffect.targetTransform).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(MoveEffect.effect)).x)))) le 1e-05 AND state eq 1

</details>

---

### พลั่วชั้นดี (GoodQualityShovel) · uid 1124

<img src="../../icons/sk_1124.png" width="40" alt="icon"> 
**Tree:** ネクロマンサースキル (`NecromancerSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 1 · **Weapons:** Rod · **Requires:** เกรฟดิกเกอร์ · **Flags:** NoMarketSearch · **Client class:** `GoodQualityShovel` (passive mastery)

> เมื่อใช้สกิล[ขุดหลุมศพ]เป็นครั้งแรก
> จะได้รับสแต็ควิญญาณเพิ่ม
> 
> และถึงจะออกห่างจากสุสานไปเล็กน้อย
> สแต็ควิญญาณจะยังคงเพิ่มขึ้นต่อไป

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 6 | 12 | 18 | 24 | 30 | 36 | 42 | 48 | 53 | 60 |


---

### สกัลเชคเกอร์ (SkullShaker) · uid 1125

<img src="../../icons/sk_1125.png" width="40" alt="icon"> 
**Tree:** ネクロマンサースキル (`NecromancerSkill`, tier 2) · **Type:** Attack · **Max Lv:** 205 · **Weapons:** Rod, Halberd · **Requires:** ทูม · **Flags:** NoMarketSearch · **Client class:** `SkullShakerAction`

> ใช้ไม้เท้าฟาดเข้าที่กลางศีรษะ
> สร้างความเสียหายทางกายภาพแก่เป้าหมาย
> มีโอกาสที่เป้าหมายจะ[ตาลาย]ยิ่งโจมตีโดนมาก
> พลังโจมตีและโอกาสทำให้[หมดสติ]จะยิ่งเพิ่มขึ้น
> ถ้าทำให้เป้าหมายหมดสติได้สำเร็จจะถูกรีเซ็ต

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(skillRate / 100)`
- Flat dmg + `fixAddDamage`

**Role:** attack (deals damage) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `fixAddDamage`
- `SkillRate` multiplies by (adds into): `(skillRate / 100)`

**Mechanics recovered from code**

- **Stun chance (%)** (`stunPercent`): `((MobBuffBase.GetValue() + (MobBuffBase.GetValue() << 2)) << 1)` _(when TryGetBuff.buff(MobActionManagerBase.get_BuffManager(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)), 18) ne 0)_

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1125

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (2 paths)

- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `dizzyPercent` = `System.Math.Min(((baseSTR // 5) + (Lv + (Lv << 2))), 100)`
- set `IsAvoidCancel` = `0` = 0

**`ActionPreparation`** (3 paths)

- set `mobAction` = `UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)`
- set `skillRate` = `(((WeaponType eq 14 ? (int((Lv * 7.5)) + 25) : int((Lv * 7.5))) * MobBuffBase.GetValue()) + skillRate)` — when TryGetBuff.buff(MobActionManagerBase.get_BuffManager(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)), 18) ne 0
- set `stunPercent` = `((MobBuffBase.GetValue() + (MobBuffBase.GetValue() << 2)) << 1)` — when TryGetBuff.buff(MobActionManagerBase.get_BuffManager(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)), 18) ne 0

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`calcPlayerToMobDamage`** (20 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(14, dizzyPercent, playerAction)` — when PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(14, 0)` — when PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 18) ne 0
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(3, stunPercent, playerAction)` — when PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)
- calls `AbnormalStateManager.GetDefaultAnbormalStateTime` = `GetDefaultAnbormalStateTime()` — when PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)
- info `templates` = `1`
- calls `SkullShakerDebuff..ctor` = `.ctor((MobBuffBase.GetValue() + 1))` — when !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 18) ne 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 18) ne 0
- calls `SkullShakerDebuff..ctor` = `.ctor(1)` — when !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)

**`ActionHit`** (7 paths)

- set `IsAvoidCancel` = `1` = 1

</details>

---

### บลัดสตีล (BloodSteel) · uid 1126

<img src="../../icons/sk_1126.png" width="40" alt="icon"> 
**Tree:** ネクロマンサースキル (`NecromancerSkill`, tier 2) · **Type:** Special · **Max Lv:** 205 · **Weapons:** Rod · **Requires:** แฟนทอมมิสไซล์ · **Flags:** NoMarketSearch · **Client class:** `BloodSteelAction`

> เนโครแมนซีที่ทำให้เกิดคำสาปดูดเลือด
> ดูดซับความเสียหายที่สร้างให้เป้าหมายบางส่วนกลับมาเป็น HP
> ระวังว่ามีโอกาศที่จะดูดซับสภาวะผิดปกติมาด้วย
> เพิ่มโอกาสที่จะทำให้เป้าหมาย[ผงะ]เมื่อ VIT เกิน 50
> คำสาปจะถูกยกเลิกทันทีเมื่อโจมตีจากระยะไกล

**Role:** buff (self) · applies status ailment · changes attack pattern (motion / combo chain; heuristic) · modifies normal-attack behaviour

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Effect percent** (`percent`): `((((baseVIT // 50) + ((baseVIT // 50) << 2)) << 2) lt 100 ? (((baseVIT // 50) + ((baseVIT // 50) << 2)) << 2) : 100)`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1126

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `percent` = `((((baseVIT // 50) + ((baseVIT // 50) << 2)) << 2) lt 100 ? (((baseVIT // 50) + ((baseVIT // 50) << 2)) << 2) : 100)`

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`calcPlayerToMobDamage`** (4 paths)

- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(1, percent, playerAction)`
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(1, 0)` — when PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction)

**`ActionHit`** (2 paths)

- calls `BloodSteelBuf..ctor` = `.ctor(Lv, actarAction, target)` — when UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new BloodSteelBuf, Id)` — when UnityEngine.Object.op_Inequality(actarAction)

</details>

**Buffs**

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

- `EnemyMobActionManagerBase$$SetHyperModeStatus (TryGetBuf)`

---

### ซัมมอนสเกเลตัน (SummonSkeleton) · uid 1127

<img src="../../icons/sk_1127.png" width="40" alt="icon"> 
**Tree:** ネクロマンサースキル (`NecromancerSkill`, tier 2) · **Type:** Object · **Max Lv:** 205 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เกรฟดิกเกอร์ · **Flags:** NoMarketSearch · **Client class:** `SummonSkeletonAction`

> ใช้สแต็ควิญญาณx3เพื่อเรียกอัศวินโครงกระดูก
> (ไม่เกินครั้งละ 3 ตัว)
> อัศวินโครงกระดูกจะโจมตีระยะประชิด
> และจะระเบิดหายไปเมื่อมีการโจมตีโดยรอบ
> พลังโจมตีถูกกำหนดโดย ATK หรือ MATK ที่สูงกว่า

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.1 | 0.2 | 0.3 | 0.4 | 0.5 | 0.6 | 0.7 | 0.8 | 0.9 | 1 |

**Role:** attack (deals damage) · placed object / trap / summon

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **normal-attack proration slot**; never (IsExpDefFluctuate=false)

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillRate` multiplies by (adds into): `((((Lv + (Lv << 2)) << 1)) / 100)`

**Proration:** slot `Normal`, mode `never (IsExpDefFluctuate=false)`, attack type `Physics`, action id 1127

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (2 paths)

- set `actionManager` = `actarAction`
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(100)`
- set `skillRate` = `((Lv + (Lv << 2)) << 1)` → Lv1..10: [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]
- set `SkillIndividualFlag` = `1` = 1 — when isHarvest ne 0

**`SetHarvest`** (1 path)

- set `isHarvest` = `1` = 1

**`InitializeOthers`** (2 paths)

- set `actionManager` = `IOtherPlayerActionManager.get_ActionManager(actarAction)`
- set `ActionRange` = `-1` = -1
- set `movePos` = `PlacePos`
- set `movePos.y` = `PlacePos.y`
- set `movePos.z` = `PlacePos.z`
- set `isHarvest` = `SkillIndividualFlag` — when SkillIndividualFlag eq 1

**`ActionPreparation`** (6 paths)

- set `movePos` = `PlacePos` — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isHarvest eq 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isHarvest ne 0 OR !PlayerAttackBase.IsBlank(this) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND isHarvest eq 0
- set `movePos.y` = `PlacePos.y` — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isHarvest eq 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isHarvest ne 0 OR !PlayerAttackBase.IsBlank(this) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND isHarvest eq 0
- set `movePos.z` = `PlacePos.z` — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isHarvest eq 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isHarvest ne 0 OR !PlayerAttackBase.IsBlank(this) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND isHarvest eq 0

**`ActionSkillReceiveEffect`** (8 paths)

- set `PlacePos.y` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).y` — when UnityEngine.Object.op_Equality(effectMove) AND UnityEngine.Object.op_Equality(skillPosition) AND UnityEngine.Object.op_Inequality(skillPosition) OR !UnityEngine.Object.op_Equality(effectMove) AND UnityEngine.Object.op_Equality(skillPosition) AND UnityEngine.Object.op_Inequality(skillPosition) OR !UnityEngine.Object.op_Equality(skillPosition) AND UnityEngine.Object.op_Equality(effectMove) AND UnityEngine.Object.op_Inequality(skillPosition)
- set `PlacePos.z` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z` — when UnityEngine.Object.op_Equality(effectMove) AND UnityEngine.Object.op_Equality(skillPosition) AND UnityEngine.Object.op_Inequality(skillPosition) OR !UnityEngine.Object.op_Equality(effectMove) AND UnityEngine.Object.op_Equality(skillPosition) AND UnityEngine.Object.op_Inequality(skillPosition) OR !UnityEngine.Object.op_Equality(skillPosition) AND UnityEngine.Object.op_Equality(effectMove) AND UnityEngine.Object.op_Inequality(skillPosition)
- set `effectMove` = `UnityEngine.GameObject.AddComponent<EffectMove>(effect)` — when UnityEngine.Object.op_Equality(effectMove) AND UnityEngine.Object.op_Equality(skillPosition) AND UnityEngine.Object.op_Inequality(skillPosition) OR !UnityEngine.Object.op_Inequality(skillPosition) AND UnityEngine.Object.op_Equality(effectMove) AND UnityEngine.Object.op_Equality(skillPosition) OR !UnityEngine.Object.op_Equality(skillPosition) AND UnityEngine.Object.op_Equality(effectMove) AND UnityEngine.Object.op_Inequality(skillPosition)

**`ActionSkillEvent`** (4 paths)

- set `changeCheck` = `(((param & 255) lo 200 ? param : (param + 56)) & 255)` — when ((1 << (param - 200)) & 639) ne 0 AND (param - 100) hi 8 AND (param - 200) ls 9

**`calcPlayerToMobDamage`** (2 paths)

- set `Element` = `SkillUtil.GetWeakElement(target.Element)`
- template `AddRate[SkillRate]` = `(skillRate / 100)`
- info `templates` = `1`

**`CreateTake`** (2 paths)

- set `eventTake` = `new SkillLinkedTake`

**`SetPlacePos`** (7 paths)

- set `PlacePos.y` = `[System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actionManager.battleManager.skillActManager), SummonSkeletonAction.<>c.<>9__82_0)+0x124]` — when IsInstanceOf(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actionManager.battleManager.skillActManager), SummonSkeletonAction.<>c.<>9__82_0), GlaiveTiggerAction) eq 1 AND SkillActionBase.CheckRangeHit(0, UnityEngine.Component.get_transform(UnityEngine.Component.get_transform(actionManager)), CharacterActionManagerBase.get_Size()) AND SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actionManager.battleManager.skillActManager), SummonSkeletonAction.<>c.<>9__82_0), 0) AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actionManager.battleManager.skillActManager), SummonSkeletonAction.<>c.<>9__82_0) ne 0 AND UnityEngine.Object.op_Inequality(actionManager.battleManager.skillActManager) AND isHarvest eq 0
- set `PlacePos.z` = `[System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actionManager.battleManager.skillActManager), SummonSkeletonAction.<>c.<>9__82_0)+0x128]` — when IsInstanceOf(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actionManager.battleManager.skillActManager), SummonSkeletonAction.<>c.<>9__82_0), GlaiveTiggerAction) eq 1 AND SkillActionBase.CheckRangeHit(0, UnityEngine.Component.get_transform(UnityEngine.Component.get_transform(actionManager)), CharacterActionManagerBase.get_Size()) AND SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actionManager.battleManager.skillActManager), SummonSkeletonAction.<>c.<>9__82_0), 0) AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actionManager.battleManager.skillActManager), SummonSkeletonAction.<>c.<>9__82_0) ne 0 AND UnityEngine.Object.op_Inequality(actionManager.battleManager.skillActManager) AND isHarvest eq 0
- set `PlacePos.y` = `SummonSkeletonAction.GetNearPlayerPosition(this).y` — when isHarvest ne 0 OR !UnityEngine.Object.op_Inequality(actionManager.battleManager.skillActManager) AND isHarvest eq 0 OR !SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actionManager.battleManager.skillActManager), SummonSkeletonAction.<>c.<>9__82_0), 0) AND UnityEngine.Object.op_Inequality(actionManager.battleManager.skillActManager) AND isHarvest eq 0
- set `PlacePos.z` = `SummonSkeletonAction.GetNearPlayerPosition(this).z` — when isHarvest ne 0 OR !UnityEngine.Object.op_Inequality(actionManager.battleManager.skillActManager) AND isHarvest eq 0 OR !SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actionManager.battleManager.skillActManager), SummonSkeletonAction.<>c.<>9__82_0), 0) AND UnityEngine.Object.op_Inequality(actionManager.battleManager.skillActManager) AND isHarvest eq 0

**`OnEndMoveAction`** (3 paths)

- set `routeIndex` = `(routeIndex + 1)` — when routeIndex lt (routePositionList.Count - 1) AND routePositionList.Count ne 0
- set `routeIndex` = `0` = 0 — when routeIndex ge (routePositionList.Count - 1) AND routePositionList.Count ne 0
- set `isMoveEnd` = `1` = 1 — when routePositionList.Count eq 0 OR routeIndex ge (routePositionList.Count - 1) AND routePositionList.Count ne 0

**`OnEndMoveFollow`** (12 paths)

- set `routeIndex` = `(routeIndex + 1)` — when fsqrt((((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).y) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).y))))) gt 1e-05 AND routeIndex lt (routePositionList.Count - 1) AND routePositionList.Count ne 0 OR fsqrt((((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).y) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).y))))) le 1e-05 AND routeIndex lt (routePositionList.Count - 1) AND routePositionList.Count ne 0
- set `routeIndex` = `0` = 0 — when fsqrt((((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).y) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).y))))) gt 1e-05 AND routeIndex lt (routePositionList.Count - 1) AND routePositionList.Count ne 0 OR fsqrt((((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).y) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).y))))) le 1e-05 AND routeIndex lt (routePositionList.Count - 1) AND routePositionList.Count ne 0 OR (((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x))) gt (followRange * followRange) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x)))) gt 1e-05 AND routeIndex ge (routePositionList.Count - 1) AND routePositionList.Count gt 0 AND routePositionList.Count ne 0
- set `isFollowPlayer` = `0` = 0 — when routePositionList.Count eq 0 OR (((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actionManager)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(skillPosition)).x))) le (followRange * followRange) AND routeIndex ge (routePositionList.Count - 1) AND routePositionList.Count ne 0

**`<ActionSkillEvent>b__76_0`** (1 path)

- set `isFollowPlayer` = `0` = 0

**`<ActionSkillEvent>b__76_1`** (1 path)

- set `isFollowPlayer` = `0` = 0

**`<OnEndMoveFollow>b__88_0`** (1 path)

- set `isFollowPlayer` = `0` = 0

**`<OnEndMoveFollow>b__88_1`** (1 path)

- set `isFollowPlayer` = `0` = 0

**`<OnEndMoveFollow>b__88_2`** (1 path)

- set `isFollowPlayer` = `0` = 0

</details>

<details><summary>Effect applied in `GlaiveTiggerBuf$$.ctor` (1 guarded path)</summary>

- always
  - returns `SkillLv(1127)`
  - set `bufferType` = `(SkillLv(1127) gt 0 ? 12 : 3)`
  - set `Count` = `0`
  - set `skillActionManager` = `[[playerAction+0x30]+0x30]`
  - set `playerStatus` = `?blr`
  - calls `CountBufferBase$$.ctor`, `0x165d8dc`, `0x165d8dc`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `GlaiveTiggerBuf$$.ctor (GetSkillLv)`
- `PlayerBattleManager$$HarvestSummonSkeleton (GetSkillLv)`
- `PlayerBattleManager$$StartSummonSkeletonBomb (GetSkillLv)`

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

**Role:** passive mastery

---

### เดนเจอร์เชค (DengerShake) · uid 1129

<img src="../../icons/sk_1129.png" width="40" alt="icon"> 
**Tree:** ネクロマンサースキル (`NecromancerSkill`, tier 3) · **Type:** Attack · **Max Lv:** 260 · **Weapons:** Rod, Halberd · **Requires:** สกัลเชคเกอร์ · **Flags:** NoMarketSearch · **Client class:** `DengerShakeAction`

> เทคนิคการใช้พลองที่ปรับเปลี่ยนได้ตามสถานการณ์
> โจมตีทางกายภาพเพิ่มเติมได้โดยการกดคีย์ ใช้เพิ่มอีก 100 MP
> ข้างหน้า (พลังสูง), ซ้ายขวา (ลดความเสียหาย), ข้างหลัง (แบ็คสเต็ป)

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(skillRate[0] / 100)` — isFirst ne 0 AND skillRate.Length ne 0
- SkillRate × `(skillRate[(1)] / 100)` — !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) le 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND param eq 100 AND param ne 101 & attackDir eq 1 AND attackDir lo skillRate.Length AND isFirst eq 0 OR attackDir lo skillRate.Length AND attackDir ne 1 AND isFirst eq 0
- SkillRate × `(skillRate[(1)] / 100)` — !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) le 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND param eq 100 AND param ne 101 & attackDir eq 1 AND attackDir lo skillRate.Length AND isFirst eq 0 OR attackDir lo skillRate.Length AND attackDir ne 1 AND isFirst eq 0
- SkillRate × `(skillRate[(1)] / 100)` — !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) le 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND param eq 100 AND param ne 101 & attackDir eq 1 AND attackDir lo skillRate.Length AND isFirst eq 0 OR attackDir lo skillRate.Length AND attackDir ne 1 AND isFirst eq 0
- SkillRate × `(skillRate[(1)] / 100)` — !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !UnityEngine.Object.op_Equality(actarAction) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND param eq 100 AND param ne 101 & attackDir eq 1 AND attackDir lo skillRate.Length AND isFirst eq 0 OR attackDir lo skillRate.Length AND attackDir ne 1 AND isFirst eq 0

**Role:** attack (deals damage) · buff (self)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(100)`
- `SkillRate` multiplies by (adds into): `(skillRate[0] / 100)` | `(skillRate[(1)] / 100)`
- `ExpRate` sets: `(target.ExpDefSkill / 100)` | `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1129

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (6 paths)

- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `skillRate[0]` = `(((baseSTR lt 0 ? (baseSTR + 1) : baseSTR) >> 1) + 750)` — when skillRate.Length ls 1 AND skillRate.Length ne 0 OR skillRate.Length hi 1 AND skillRate.Length ls 2 AND skillRate.Length ne 0 OR skillRate.Length eq 3 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0
- set `skillRate[1]` = `(((Lv * 25) + status.Str) + 750)` — when skillRate.Length hi 1 AND skillRate.Length ls 2 AND skillRate.Length ne 0 OR skillRate.Length eq 3 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0 OR mainWeapon == Rod AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0 AND skillRate.Length ne 3
- set `skillRate[2]` = `((Lv * 25) + 500)` → Lv1..10: [525, 550, 575, 600, 625, 650, 675, 700, 725, 750] — when skillRate.Length eq 3 AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0 OR mainWeapon == Rod AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0 AND skillRate.Length ne 3 OR mainWeapon != Rod AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0 AND skillRate.Length ne 3
- set `skillRate[3]` = `((Lv * 25) + 250)` → Lv1..10: [275, 300, 325, 350, 375, 400, 425, 450, 475, 500] — when mainWeapon == Rod AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0 AND skillRate.Length ne 3 OR mainWeapon != Rod AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0 AND skillRate.Length ne 3
- set `fixAddDamage` = `100` = 100 — when mainWeapon == Rod AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0 AND skillRate.Length ne 3 OR mainWeapon != Rod AND skillRate.Length hi 1 AND skillRate.Length hi 2 AND skillRate.Length ne 0 AND skillRate.Length ne 3

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`ActionStart`** (3 paths)

- set `target` = `target`
- set `IsSkillGuard` = `1` = 1

**`calcPlayerToMobDamage`** (18 paths)

- template `AddRate[SkillRate]` = `(skillRate[0] / 100)` — when isFirst ne 0 AND skillRate.Length ne 0
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage` — when isFirst ne 0 AND skillRate.Length ne 0 OR attackDir eq 1 AND attackDir lo skillRate.Length AND isFirst eq 0 OR attackDir lo skillRate.Length AND attackDir ne 1 AND isFirst eq 0
- template `SetRate[ExpRate]` = `(target.ExpDefSkill / 100)` — when isFirst ne 0 AND skillRate.Length ne 0 OR attackDir eq 1 AND attackDir lo skillRate.Length AND isFirst eq 0 OR attackDir lo skillRate.Length AND attackDir ne 1 AND isFirst eq 0
- info `templates` = `1`
- template `AddRate[SkillRate]` = `(skillRate[attackDir] / 100)` — when attackDir eq 1 AND attackDir lo skillRate.Length AND isFirst eq 0 OR attackDir lo skillRate.Length AND attackDir ne 1 AND isFirst eq 0
- template `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)` — when isFirst ne 0 AND skillRate.Length ne 0 OR attackDir eq 1 AND attackDir lo skillRate.Length AND isFirst eq 0 OR attackDir lo skillRate.Length AND attackDir ne 1 AND isFirst eq 0

**`NextRangeHit`** (2 paths)

- set `isFirst` = `0` = 0

**`ActionSkillEvent`** (34 paths)

- set `IsSkillGuard` = `0` = 0 — when IsOtherPlayer ne 0 AND param eq 100 AND param ne 101 OR IsOtherPlayer eq 0 AND UnityEngine.Object.op_Equality(actarAction) AND param eq 100 AND param ne 101 OR !PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND !UnityEngine.Object.op_Equality(actarAction) AND IsOtherPlayer eq 0 AND param eq 100 AND param ne 101
- set `attackDir` = `1` = 1 — when !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) le 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND param eq 100 AND param ne 101
- set `attackDir` = `2` = 2 — when !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) le 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND param eq 100 AND param ne 101
- set `IsDamageInvalid` = `1` = 1 — when !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) le 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND param eq 100 AND param ne 101
- set `attackDir` = `3` = 3 — when !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) gt 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND fsqrt(((((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).z))) + (((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x)) * ((InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).x * UnityEngine.Transform.get_right(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x) + (InputManager.get_LeftInputValue(Singleton<InputManager>.get_Instance()).y * UnityEngine.Transform.get_forward(UnityEngine.Component.get_transform(UnityEngine.Camera.get_main())).x))))) le 1e-05 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND param eq 100 AND param ne 101
- set `attackDir` = `0` = 0 — when !InputManager.get_LeftInputKey(Singleton<InputManager>.get_Instance()) AND !UnityEngine.Object.op_Equality(actarAction) AND IsOtherPlayer eq 0 AND PlayerStatusBase.EnoughMp(PlayerActionManagerBase.get_PlayerStatus(), 100) AND param eq 100 AND param ne 101

**`ApplyDamageCut`** (1 path)

- set `IsDamageInvalid` = `0` = 0

**`.<>c__DisplayClass35_0::<ActionStart>b__0`** (2 paths)

- calls `DengerShakeBuf..ctor` = `.ctor()`
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new DengerShakeBuf, [<>c__DisplayClass35_0.<>4__this+0x10])`

</details>

**Buffs**

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

- `PlayerAttackBase$$RemoveAfterSkillBuf (TryGetBuf)`

---

### โซลสตรีม (SoulStream) · uid 1130

<img src="../../icons/sk_1130.png" width="40" alt="icon"> 
**Tree:** ネクロマンサースキル (`NecromancerSkill`, tier 3) · **Type:** Object · **Max Lv:** 260 · **Weapons:** Rod · **Requires:** บลัดสตีล · **Flags:** NoMarketSearch · **Client class:** `SoulStreamAction`

> เนโครแมนซีที่ยิงปืนใหญ่อนุภาควิญญาณ
> โจมตีเป้าหมายด้วยเวทมนตร์  อัตราทำให้[เฉื่อยชา]
> เพิ่มขึ้นตามสแต็ควิญญาณที่ใช้ไปพร้อมกับฟื้นฟู MP
> สแต็ควิญญาณที่ใช้จะขึ้นอยู่กับจำนวน
> MP ที่ใช้ไปในขณะที่ร่าย(สูงสุด 20 )

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 495 | 540 | 585 | 630 | 675 | 720 | 765 | 810 | 855 | 900 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((((Lv * 100) + baseINT)) / 100)`
- SkillRate × `((((Lv * 100) + baseINT)) / 100)` — (max((status.MaxMp - (PlayerStatusBase.get_GameStatus().localExMp + PlayerStatusBase.get_GameStatus().localMp)), 0) // 100) gt TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121).Count AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- SkillRate × `((((Lv * 100) + baseINT)) / 100)` — (max((status.MaxMp - (PlayerStatusBase.get_GameStatus().localExMp + PlayerStatusBase.get_GameStatus().localMp)), 0) // 100) le TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121).Count AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)

**Role:** attack (deals damage) · applies status ailment · placed object / trap / summon

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv * 45) + 450))`
- `SkillRate` multiplies by (adds into): `((((Lv * 100) + baseINT)) / 100)`

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1.5, PlayerActionManagerBase.get_PlayerStatus())`

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 1130

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`
- set `skillRate` = `((Lv * 100) + baseINT)`
- set `constantDamage` = `((Lv * 45) + 450)` → Lv1..10: [495, 540, 585, 630, 675, 720, 765, 810, 855, 900]
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 1.5, PlayerActionManagerBase.get_PlayerStatus())`

**`ActionPreparation`** (5 paths)

- set `abnormalPer` = `(((TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121).Count + (TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121).Count << 2)) << 1) lt 100 ? ((TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121).Count + (TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121).Count << 2)) << 1) : 100)` — when (max((status.MaxMp - (PlayerStatusBase.get_GameStatus().localExMp + PlayerStatusBase.get_GameStatus().localMp)), 0) // 100) gt TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121).Count AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `skillRate` = `((TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121).Count * 75) + skillRate)` — when (max((status.MaxMp - (PlayerStatusBase.get_GameStatus().localExMp + PlayerStatusBase.get_GameStatus().localMp)), 0) // 100) gt TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121).Count AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `SkillIndividualFlag` = `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121).Count` — when (max((status.MaxMp - (PlayerStatusBase.get_GameStatus().localExMp + PlayerStatusBase.get_GameStatus().localMp)), 0) // 100) gt TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121).Count AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `abnormalPer` = `((((max((status.MaxMp - (PlayerStatusBase.get_GameStatus().localExMp + PlayerStatusBase.get_GameStatus().localMp)), 0) // 100) + ((max((status.MaxMp - (PlayerStatusBase.get_GameStatus().localExMp + PlayerStatusBase.get_GameStatus().localMp)), 0) // 100) << 2)) << 1) lt 100 ? (((max((status.MaxMp - (PlayerStatusBase.get_GameStatus().localExMp + PlayerStatusBase.get_GameStatus().localMp)), 0) // 100) + ((max((status.MaxMp - (PlayerStatusBase.get_GameStatus().localExMp + PlayerStatusBase.get_GameStatus().localMp)), 0) // 100) << 2)) << 1) : 100)` — when (max((status.MaxMp - (PlayerStatusBase.get_GameStatus().localExMp + PlayerStatusBase.get_GameStatus().localMp)), 0) // 100) le TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121).Count AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `skillRate` = `(((max((status.MaxMp - (PlayerStatusBase.get_GameStatus().localExMp + PlayerStatusBase.get_GameStatus().localMp)), 0) // 100) * 75) + skillRate)` — when (max((status.MaxMp - (PlayerStatusBase.get_GameStatus().localExMp + PlayerStatusBase.get_GameStatus().localMp)), 0) // 100) le TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121).Count AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `SkillIndividualFlag` = `(max((status.MaxMp - (PlayerStatusBase.get_GameStatus().localExMp + PlayerStatusBase.get_GameStatus().localMp)), 0) // 100)` — when (max((status.MaxMp - (PlayerStatusBase.get_GameStatus().localExMp + PlayerStatusBase.get_GameStatus().localMp)), 0) // 100) le TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121).Count AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1121) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`calcPlayerToMobDamage`** (8 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `constantDamage`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(15, abnormalPer, playerAction)`
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(15, 0)` — when PlayerAttackBase.checkAbnormalPercent(this, 15, abnormalPer, playerAction)
- info `templates` = `1`

</details>

---

### ซัมมอนเดโมนิก (SummonDemonic) · uid 1131

<img src="../../icons/sk_1131.png" width="40" alt="icon"> 
**Tree:** ネクロマンサースキル (`NecromancerSkill`, tier 3) · **Type:** Extra · **Max Lv:** 260 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ซัมมอนสเกเลตัน · **Flags:** NoMarketSearch · **Client class:** `SummonDemonicAction`

> ทำพันธสัญญากับปีศาจ
> ประสิทธิภาพจะเปลี่ยนไปตามปริมาณ MP ที่ใช้ทำสัญญา
> ปีศาจจะดูด HP ของผู้ร่ายเพื่อแลกกับการโจมตีในแต่ละครั้ง
> สามารถยุติสัญญากับปีศาจได้โดยการใช้สกิลนี้อีกครั้ง
> หากสถานการณ์เลวร้ายอาจเกิดการทรยศหักหลัง

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`
- **MP cost** (`mp`): `0` = 0 _(when hasBuff(1131))_; `((PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) gt 100 ? (PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) : 100)` _(when !hasBuff(1131))_
- **MP cost** (`costMp`): `0` = 0 _(when hasBuff(1131))_; `((PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) gt 100 ? (PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) : 100)` _(when !hasBuff(1131))_

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1131

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`calcCostMp`** (2 paths)

- set `mp` = `0` = 0 — when hasBuff(1131)
- set `costMp` = `0` = 0 — when hasBuff(1131)
- set `mp` = `((PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) gt 100 ? (PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) : 100)` — when !hasBuff(1131)
- set `costMp` = `((PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) gt 100 ? (PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) : 100)` — when !hasBuff(1131)

**`GetDamageResistRate`** (14 paths)

- calls `virtual MobAttackBase.CheckPercentageDamage` = `virtual MobAttackBase.CheckPercentageDamage()` — when (ExSkillSummonDemonic.CheckAbility(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 1131), 4) | ExSkillSummonDemonic.CheckAbility(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 1131), 5)) AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 1131) ne 0 AND UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) OR !ExSkillSummonDemonic.CheckAbility(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 1131), 4) AND (ExSkillSummonDemonic.CheckAbility(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 1131), 4) | ExSkillSummonDemonic.CheckAbility(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 1131), 5)) AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 1131) ne 0 AND UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0) OR (ExSkillSummonDemonic.CheckAbility(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 1131), 4) | ExSkillSummonDemonic.CheckAbility(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 1131), 5)) AND ExSkillSummonDemonic.CheckAbility(TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 1131), 4) AND TryGetExSkillData<object>.out2(PlayerDataManager.get_ExSkillManager(PlayerDataManager.GetPlayerDataManager()), 1131) ne 0 AND UnityEngine.Object.op_Inequality(PlayerDataManager.GetPlayerDataManager(), 0)

**`ChangeHateManaged`** (8 paths)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(1131)` — when CharacterActionManagerBase.AddAbnormalState(UnityEngine.Component.get_gameObject(playerAction), 3, 5, 0, 0, 0, 1) AND UnityEngine.Random.Range(0, 100) lt int((((100 - PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus())) * (100 - PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()))) / 200)) AND hasBuff(1131) OR !CharacterActionManagerBase.AddAbnormalState(UnityEngine.Component.get_gameObject(playerAction), 3, 5, 0, 0, 0, 1) AND UnityEngine.Random.Range(0, 100) lt int((((100 - PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus())) * (100 - PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()))) / 200)) AND hasBuff(1131) OR CharacterActionManagerBase.AddAbnormalState(UnityEngine.Component.get_gameObject(playerAction), 3, 5, 0, 0, 0, 1) AND TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 15, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager())) ne 0 AND UnityEngine.Random.Range(0, 100) lt int((((100 - PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus())) * (100 - PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()))) / 200)) AND hasBuff(1131)

**`PartyAcceptance`** (3 paths)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(1131)` — when TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1131) ne 0

</details>

**Buffs**

**Buff `SummonDemonicBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `BufferEnd`, `SetBloodContract`, `SetSummonMp`
- `MaxHpUpRate` = `maxHpRate`
- `Value` = `(mp)`
- Buff fields set in the constructor (all recovered):
  - `summonMp` = `mp`
- Hook `SetBloodContract`: `maxHpRate`=-50
- Hook `SetSummonMp`: `summonMp`=mp

<details><summary>Effect applied in `ReceiveSupportResult$$OnActionPlayerSupport` (3 guarded paths)</summary>

- when `skillId gt 709` AND `skillId gt 1025` AND `skillId gt 1039` AND `skillId gt 1090`
  - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillId, skillLv, supportData), 0, ?x2, ?x3), 0)`
  - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_AbnormalStateManager`, `AbnormalStateManager$$Recovery`, `PlayerDataManager$$get_PlayerArchetypeId`, `AutoMemberManager$$TryGetAutoMember`, `PlayerDataManager$$get_PlayerStatus`
- when `skillId gt 709` AND `skillId gt 1025` AND `skillId gt 1039` AND `skillId gt 1090`
  - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillId, skillLv, supportData), 0, ?x2, ?x3), 0)`
  - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_AbnormalStateManager`, `AbnormalStateManager$$Recovery`, `PlayerDataManager$$get_PlayerArchetypeId`, `AutoMemberManager$$TryGetAutoMember`, `PlayerDataManager$$get_PlayerStatus`
- when `skillId gt 709` AND `skillId gt 1025` AND `skillId gt 1039` AND `skillId gt 1090`
  - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillId, skillLv, supportData), 0, ?x2, ?x3), 0)`
  - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_AbnormalStateManager`, `AbnormalStateManager$$Recovery`, `PlayerDataManager$$get_PlayerArchetypeId`, `AutoMemberManager$$TryGetAutoMember`, `PlayerDataManager$$get_PlayerStatus`

</details>

<details><summary>Effect applied in `PhotonListener$$OnActionRoomChangeHateMine` (300 guarded paths, truncated)</summary>

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

</details>

<details><summary>Effect applied in `PhotonListener$$OnActionPartyChangeHateMine` (300 guarded paths, truncated)</summary>

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

</details>

<details><summary>Effect applied in `MainPlayer$$PlayerDead` (178 guarded paths, truncated)</summary>

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

<details><summary>Effect applied in `PhotonListener$$OnActionPartyChangeHateActor` (22 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `PhotonListener$$OnActionRoomChangeHateActor` (40 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `SummonDemonicAction$$ChangeHateManaged` (5 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `SummonDemonicAction$$calcCostMp` (2 guarded paths)</summary>

- always
  - returns `SkillBufferManager.ContainsBuffer(?blr, 1131, 0, ?x3)`
  - set `mp` = `0`
  - set `costMp` = `0`
- always
  - returns `PlayerAttackBase.CalcCostMp(this, playerAction, 0, ?x3)`
  - set `mp` = `((PlayerAttackBase.CalcCostMp(this, playerAction, 0, ?x3) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction, 0, ?x3) : 2000) gt 100 ? (PlayerAttackBase.CalcCostMp(this, playerAction, 0, ?x3) lt 2000 ? PlayerAttackBase.CalcCostMp(this`
  - set `costMp` = `((PlayerAttackBase.CalcCostMp(this, playerAction, 0, ?x3) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction, 0, ?x3) : 2000) gt 100 ? (PlayerAttackBase.CalcCostMp(this, playerAction, 0, ?x3) lt 2000 ? PlayerAttackBase.CalcCostMp(this`
  - calls `PlayerAttackBase$$CalcCostMp`

</details>

<details><summary>Effect applied in `SummonDemonicAction$$IsFailure` (3 guarded paths)</summary>

- always
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `Singleton<object>$$get_Instance`, `PartyManager$$get_MemberData`, `TargetableListManagerBase<object>$$get_Instance`, `OtherPlayerManager$$ContainsOtherPlayer`, `0x165db7c`, `0x165db7c`, `0x14cfadc`
- always
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `Singleton<object>$$get_Instance`, `PartyManager$$get_MemberData`, `TargetableListManagerBase<object>$$get_Instance`, `OtherPlayerManager$$ContainsOtherPlayer`, `TargetableListManagerBase<object>$$get_Instance`, `OtherPlayerManager$$ContainsOtherPlayer`, `TargetableListManagerBase<object>$$get_Instance`
- always
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`

</details>

<details><summary>Effect applied in `SummonDemonicAttackAction$$ActionHit` (3 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `?blr`
  - calls `SkillActionBase$$ActionHit`
- when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `SkillActionBase$$ActionHit`, `0x165db84`, `0x165df00`
- when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0)`
  - calls `SkillActionBase$$ActionHit`

</details>

<details><summary>Effect applied in `SummonDemonicSpecialAttack$$ActionHit` (3 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `?blr`
  - calls `SkillActionBase$$ActionHit`
- when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `SkillActionBase$$ActionHit`, `0x165db84`, `0x165df00`
- when `(SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 1131, stkp(-40), 0)`
  - calls `SkillActionBase$$ActionHit`

</details>

<details><summary>Effect applied in `SummonDemonicAttackAction$$OnInitialize` (11 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `SummonDemonicSpecialAttack$$OnInitialize` (11 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `SummonDemonicAI$$.ctor` (19 guarded paths)</summary>

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

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `GameManager$$ReceiveSummons (GetSkillLv)`
- `MainPlayer$$PlayerDead (ContainsBuffer)`
- `PhotonListener$$OnActionPartyChangeHateActor (ContainsBuffer)`
- `PhotonListener$$OnActionPartyChangeHateMine (ContainsBuffer)`
- `PhotonListener$$OnActionRoomChangeHateActor (ContainsBuffer)`
- `PhotonListener$$OnActionRoomChangeHateMine (ContainsBuffer)`
- `PlayerActionManager$$Damaged (ContainsBuffer)`
- `ReceiveSupportResult$$OnActionPlayerSupport (TryGetBuf)`
- `ReceiveSupportResult$$OnEventNpcSupport (TryGetBuf)`
- `ReceiveSupportResult$$OnEventPlayerSupport (TryGetBuf)`
- `SummonDemonicAI$$.ctor (TryGetBuf)`
- `SummonDemonicAction$$ChangeHateManaged (ContainsBuffer)`
- `SummonDemonicAction$$IsFailure (ContainsBuffer)`
- `SummonDemonicAction$$calcCostMp (ContainsBuffer)`
- `SummonDemonicActionManager$$BattleReservSpecialAttack (GetSkillLv)`
- `SummonDemonicActionManager$$BattleReserveNormalAttack (GetSkillLv)`
- `SummonDemonicAttackAction$$ActionHit (TryGetBuf)`
- `SummonDemonicAttackAction$$OnInitialize (TryGetBuf)`
- `SummonDemonicSpecialAttack$$ActionHit (TryGetBuf)`
- `SummonDemonicSpecialAttack$$OnInitialize (TryGetBuf)`
- `UIExSkillManager$$ExSkillList (GetSkillLv)`
- `UINecromancerExSkillManager$$Initialize (GetSkillLv)`
- `UISkillTreeManager$$SkillTreeList (GetSkillLv)`

---

### แผนตลบหลัง (MatchPump) · uid 1132

<img src="../../icons/sk_1132.png" width="40" alt="icon"> 
**Tree:** ネクロマンサースキル (`NecromancerSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 260 · **Weapons:** Rod · **Requires:** ฮาร์เวสต์ · **Flags:** NoMarketSearch · **Client class:** `MatchPump` (passive mastery)

> อัศวินโครงกระดูกที่ระเบิดหายไปแล้ว
> ก็มีโอกาสได้รับผลของสกิล[ฮาร์เวสต์ ]

**Role:** passive mastery

---
