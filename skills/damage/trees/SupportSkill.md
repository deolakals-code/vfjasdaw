# サポートスキル (`SupportSkill`)

13 entries. See ../README.md for how to read these blocks.

### ปฐมพยาบาล (FirstAidMastary) · uid 225

<img src="../../icons/sk_225.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 10 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem · **Client class:** `FirstAidMastary` (passive mastery)

> ประสิทธิภาพของ[ปฐมพยาบาล]ในเมนูสนับสนุนเพิ่มขึ้น
> เวลาที่ใช้รอในการคืนชีพลดลงอย่างมาก

**Role:** passive mastery

---

### ไลฟ์รีคัฟเวอรี่ (LifeRecovery) · uid 226

<img src="../../icons/sk_226.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 1) · **Type:** Circle · **Max Lv:** 10 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem · **Client class:** `LifeRecoveryAction`

> สร้างพื้นที่สำหรับฟื้นฟู HP อย่างต่อเนื่อง
> 
> DEF ของผู้ใช้จะลดลง
> และผลลัพธ์จะหมดไปเมื่อได้รับความเสียหาย

**Role:** buff (self) · circle / song area

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `0` = 0
- **Range** (`range`): `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 226

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `CastTime` = `0` = 0
- set `range` = `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (1 path)

- set `checkPos` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x`
- set `checkPos.y` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y`
- set `checkPos.z` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z`
- calls `LifeRecoveryBuf..ctor` = `.ctor(Lv, 1, 0)`
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new LifeRecoveryBuf, Id)`

</details>

**Buffs**

**Buff `LifeRecoveryBuf`**
- `MobLastDamageRateBuf` = `0` _(when BuffEffectActive ne 0; IsSelfAction eq 0)_
- `HpRecoveryUp` = `(((System.Math.Max(0, val)) + (Lv << 2)) + 10)` _(when BuffEffectActive ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MobLastDamageRateBuf | 190 | 180 | 170 | 160 | 150 | 140 | 130 | 120 | 110 | 100 |

- Buff fields set in the constructor (all recovered):
  - `mVit` = `System.Math.Max(0, val)`
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `range` = `int(MathUtil.DisplayMeterToDistance((?ubfx + 5)))` when (self & 1) ne 0
  - `IsDamageCancel` = `1` = 1 when (self & 1) ne 0
**Buff `CircleBufferBase`**
- Attached to this skill via `caller2:LifeRecoveryBuf$$.ctor<-LifeRecoveryAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `CheckRange`, `CheckTarget`, `CheckTestRange`, `SetLocalId`, `UpdateClear`, `get_IsPlace`, `get_IsRange`, `get_IsUpdate`, `get_LocalId`, `get_Range`, `set_IsUpdate`, `set_LocalId`
- Duration: `900` s [(self & 1) ne 0]; `time` s [(self & 1) eq 0]
- Buff fields set in the constructor (all recovered):
  - `targetList` = `new System.Collections.Generic.List<Transform>`
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `intervalTime` = `3` = 3 when (self & 1) ne 0
- Hook `set_LocalId`: `LocalId`=value
- Hook `set_IsUpdate`: `IsUpdate`=(value & 1)
- Hook `SetLocalId`: `LocalId`=id
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `intervalTime`=3; `IsUpdate`=1; `intervalTime`=(intervalTime - UnityEngine.Time.get_deltaTime())
- Hook `UpdateClear`: `IsUpdate`=0

<details><summary>Effect applied in `PlayerSecondaryStatus$$CalcHpRecovery` (19 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 226, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(isBattle & 1) ne 0` AND `TryGetValue.out2() ne 0`
  - returns `((System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey([CharacterActionManagerBase.get_IsValid()+0x40], 1064, meta(0x3974488, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.ContainsKey()), ?x3) & 1) ne 0 ? 0 : (int(((CharacterActionManagerBase.get_Size() / 100) * BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), (((PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) lt 0x1869f ? PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) : 0x1869f) // 25) + 10), 35, 34))) + CharacterActionManagerBase.set_DefaultMoveSpeed()))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 226, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(isBattle & 1) ne 0` AND `TryGetValue.out2() eq 0`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 226, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(isBattle & 1) ne 0`
  - returns `((System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey([CharacterActionManagerBase.get_IsValid()+0x40], 1064, meta(0x3974488, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.ContainsKey()), ?x3) & 1) ne 0 ? 0 : (int((0 * BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), (((PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) lt 0x1869f ? PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) : 0x1869f) // 25) + 10), 35, 34))) + CharacterActionManagerBase.set_DefaultMoveSpeed()))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsValid`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 226, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(isBattle & 1) eq 0` AND `TryGetValue.out2() ne 0`
  - returns `((System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey([CharacterActionManagerBase.get_IsValid()+0x40], 1064, meta(0x3974488, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.ContainsKey()), ?x3) & 1) ne 0 ? 0 : (int((CharacterActionManagerBase.get_Size() + ((((CharacterActionManagerBase.get_Size() / 100) + 1) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), (((PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) lt 0x1869f ? PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) : 0x1869f) // 25) + 10), 35, 34)))) + CharacterActionManagerBase.set_DefaultMoveSpeed()))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 226, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(isBattle & 1) eq 0` AND `TryGetValue.out2() ne 0`
  - returns `((System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey([CharacterActionManagerBase.get_IsValid()+0x40], 1064, meta(0x3974488, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.ContainsKey()), ?x3) & 1) ne 0 ? 0 : (int((CharacterActionManagerBase.get_Size() + (((CharacterActionManagerBase.get_Size() / 100) + 1) * BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), (((PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) lt 0x1869f ? PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) : 0x1869f) // 25) + 10), 35, 34)))) + CharacterActionManagerBase.set_DefaultMoveSpeed()))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_Size`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 226, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(isBattle & 1) eq 0` AND `TryGetValue.out2() eq 0`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 226, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(isBattle & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 769, stkp(-40), 0) & 1) ne 0`
  - returns `((System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey([CharacterActionManagerBase.get_IsValid()+0x40], 1064, meta(0x3974488, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.ContainsKey()), ?x3) & 1) ne 0 ? 0 : (int(((1 + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), (((PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) lt 0x1869f ? PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) : 0x1869f) // 25) + 10), 35, 34))) + CharacterActionManagerBase.set_DefaultMoveSpeed()))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 226, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(isBattle & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 769, stkp(-40), 0) & 1) eq 0`
  - returns `((System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey([CharacterActionManagerBase.get_IsValid()+0x40], 1064, meta(0x3974488, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.ContainsKey()), ?x3) & 1) ne 0 ? 0 : (int(BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), (((PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) lt 0x1869f ? PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) : 0x1869f) // 25) + 10), 35, 34)) + CharacterActionManagerBase.set_DefaultMoveSpeed()))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsValid`

</details>

<details><summary>Effect applied in `PlayerSecondaryStatus$$get_HpRecovery` (3 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 226, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + int(BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), (((PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) lt 0x1869f ? PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) : 0x1869f) // 25) + 10), 35, 34)))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 226, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 226, stkp(-24), 0) & 1) eq 0`
  - returns `int(BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), (((PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) lt 0x1869f ? PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) : 0x1869f) // 25) + 10), 35, 34))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `PlayerSecondaryStatus$$CalcHpRecovery (TryGetBuf)`
- `PlayerSecondaryStatus$$get_HpRecovery (TryGetBuf)`

---

### มานารีชาร์จ (ManaRecharge) · uid 227

<img src="../../icons/sk_227.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 1) · **Type:** Circle · **Max Lv:** 10 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem · **Client class:** `ManaRechargeAction`

> สร้างพื้นที่สำหรับฟื้นฟู MP อย่างต่อเนื่อง
> 
> ATK ของผู้ใช้จะลดลง
> และผลลัพธ์ที่เกิดจะหมดไปเมื่อได้รับความเสียหาย

**Role:** buff (self) · circle / song area

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `0` = 0
- **Range** (`range`): `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 227

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `CastTime` = `0` = 0
- set `range` = `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (2 paths)

- set `checkPos` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x`
- set `checkPos.y` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y`
- set `checkPos.z` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z`
- calls `ManaRechargeBuf..ctor` = `.ctor(Lv, 1, 0)` — when UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new ManaRechargeBuf, Id)` — when UnityEngine.Object.op_Inequality(actarAction)

</details>

**Buffs**

**Buff `ManaRechargeBuf`**
- `LastDmgDownRate` = `0` _(when BuffEffectActive ne 0; IsSelfAction eq 0)_
- `MpRecoveryUp` = `((int((Lv * 1.5)) + 10) + (int((System.Math.Max(0, val) * 0.1))))` _(when BuffEffectActive ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| LastDmgDownRate | 47 | 45 | 42 | 40 | 37 | 35 | 32 | 30 | 27 | 25 |

- Buff fields set in the constructor (all recovered):
  - `mInt` = `int((System.Math.Max(0, val) * 0.1))`
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `range` = `int(MathUtil.DisplayMeterToDistance((?ubfx + 5)))` when (self & 1) ne 0
  - `IsDamageCancel` = `1` = 1 when (self & 1) ne 0
**Buff `CircleBufferBase`**
- Attached to this skill via `caller2:ManaRechargeBuf$$.ctor<-ManaRechargeAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `CheckRange`, `CheckTarget`, `CheckTestRange`, `SetLocalId`, `UpdateClear`, `get_IsPlace`, `get_IsRange`, `get_IsUpdate`, `get_LocalId`, `get_Range`, `set_IsUpdate`, `set_LocalId`
- Duration: `900` s [(self & 1) ne 0]; `time` s [(self & 1) eq 0]
- Buff fields set in the constructor (all recovered):
  - `targetList` = `new System.Collections.Generic.List<Transform>`
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `intervalTime` = `3` = 3 when (self & 1) ne 0
- Hook `set_LocalId`: `LocalId`=value
- Hook `set_IsUpdate`: `IsUpdate`=(value & 1)
- Hook `SetLocalId`: `LocalId`=id
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `intervalTime`=3; `IsUpdate`=1; `intervalTime`=(intervalTime - UnityEngine.Time.get_deltaTime())
- Hook `UpdateClear`: `IsUpdate`=0

<details><summary>Effect applied in `PlayerSecondaryStatus$$get_MpRecovery` (3 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 227, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + int(BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), ((max((PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) lt 2000 ? PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) : 2000), 0) // 100) + 1), 37, 36)))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 227, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 227, stkp(-24), 0) & 1) eq 0`
  - returns `int(BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), ((max((PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) lt 2000 ? PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) : 2000), 0) // 100) + 1), 37, 36))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`

</details>

<details><summary>Effect applied in `PlayerSecondaryStatus$$CalcMpRecovery` (29 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 227, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(isBattle & 1) ne 0` AND `TryGetValue.out2() ne 0`
  - returns `(int(((CharacterActionManagerBase.get_Size() / 100) * BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), ((max((PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) lt 2000 ? PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) : 2000), 0) // 100) + 1), 37, 36))) + CharacterActionManagerBase.set_DefaultMoveSpeed())`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 227, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(isBattle & 1) ne 0` AND `TryGetValue.out2() eq 0`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 227, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(isBattle & 1) ne 0`
  - returns `(int((0 * BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), ((max((PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) lt 2000 ? PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) : 2000), 0) // 100) + 1), 37, 36))) + CharacterActionManagerBase.set_DefaultMoveSpeed())`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`
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
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 227, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(isBattle & 1) eq 0` AND `TryGetValue.out2() eq 0`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db84`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `PlayerSecondaryStatus$$CalcMpRecovery (TryGetBuf)`
- `PlayerSecondaryStatus$$get_MpRecovery (TryGetBuf)`

---

### มินิฮีล (PetitHeal) · uid 228

<img src="../../icons/sk_228.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 1) · **Type:** Heal · **Max Lv:** 10 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem · **Client class:** `PutitHealAction`

> ฟื้นฟู HP ให้เป้าหมายเล็กน้อย
> และจะช่วยลดเวลาคืนชีพให้สั้นลง
> เมื่อเป้าหมายอยู่ในระหว่างรอคืนชีพ

**Role:** heal / recovery

This action never changes monster proration: ExpType None: no proration slot.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `0` = 0 _(when SkillBufferDataBase.GetParam(20) ge (baseMp // 100) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0)_; `SkillUtil.CalcCastTime(1, PlayerStatusBase.get_BattleStatus())`; `-1` = -1 _(when (isPlayer & 1) ne 0)_
- **HP healed** (`hpHeal`): `(((status.MaxHp * Lv) // 100) + (Lv * 30))`; `(hpHeal - int((((((GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) + (GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) << 2)) << 1) * -0.01) + 1) * ((hpHeal lt 0 ? (hpHeal + 1) : hpHeal) >> 1))))` _(when GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND SkillIndividualFlag eq 1 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND SkillIndividualFlag ne 1 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND SkillIndividualFlag eq 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 AND hasGemCart(1026))_; `(hpHeal - ((hpHeal lt 0 ? (hpHeal + 1) : hpHeal) >> 1))` _(when GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND SkillIndividualFlag eq 1 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND SkillIndividualFlag ne 1 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND SkillIndividualFlag eq 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 AND hasGemCart(1026))_
- **MP cost** (`costMp`): `0` = 0 _(when SkillIndividualFlag eq 1)_

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 228

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (8 paths)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(24)`
- set `CastTime` = `0` = 0 — when SkillBufferDataBase.GetParam(20) ge (baseMp // 100) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0
- set `hpHeal` = `(((status.MaxHp * Lv) // 100) + (Lv * 30))`
- set `SkillIndividualFlag` = `1` = 1 — when SkillBufferDataBase.GetParam(20) ge (baseMp // 100) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0
- set `CastTime` = `SkillUtil.CalcCastTime(1, PlayerStatusBase.get_BattleStatus())`

**`ActionPreparation`** (12 paths)

- set `hpHeal` = `(hpHeal - int((((((GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) + (GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) << 2)) << 1) * -0.01) + 1) * ((hpHeal lt 0 ? (hpHeal + 1) : hpHeal) >> 1))))` — when GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND SkillIndividualFlag eq 1 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND SkillIndividualFlag ne 1 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND SkillIndividualFlag eq 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 AND hasGemCart(1026)
- set `hpHeal` = `(hpHeal - ((hpHeal lt 0 ? (hpHeal + 1) : hpHeal) >> 1))` — when GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND SkillIndividualFlag eq 1 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND SkillIndividualFlag ne 1 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND SkillIndividualFlag eq 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 AND hasGemCart(1026)

**`CheckHealStock`** (2 paths)

- set `costMp` = `0` = 0 — when SkillIndividualFlag eq 1

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`InitializeEnchantedSpell`** (2 paths)

- set `CastTime` = `-1` = -1 — when (isPlayer & 1) ne 0

</details>

<details><summary>Effect applied in `RecoveryAction$$OnInitialize` (2 guarded paths)</summary>

- when `SkillLv(228) ge 1`
  - set `ActionRange` = `48`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CastTime` = `PlayerAttackBase.CalcCastTime(this, ?blr, 0, ?x3)`
  - set `hpHeal` = `((GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 1006, 0, ?x3), 2, 0, ?x3) * [SkillFactory.CreateSkill(228, 0, ?x2, ?x3)+0x120]) // 100)`
  - set `SkillIndividualFlag` = `((GemCartBufferBase.GetValue(GemCartBufferManager.GetGemCartBuffer(?blr, 1006, 0, ?x3), 2, 0, ?x3) * [SkillFactory.CreateSkill(228, 0, ?x2, ?x3)+0x120]) // 100)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcCastTime`, `GemCartBufferManager$$GetGemCartBuffer`, `SkillFactory$$CreateSkill`, `SkillActionBase$$Initialize`, `GemCartBufferBase$$GetValue`, `PlayerAttackBase$$CalcMp`, `0x165db78`
- when `SkillLv(228) lt 1`
  - set `ActionRange` = `48`
  - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
  - set `CastTime` = `PlayerAttackBase.CalcCastTime(this, ?blr, 0, ?x3)`
  - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
  - calls `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcCastTime`, `GemCartBufferManager$$GetGemCartBuffer`, `SkillFactory$$CreateSkill`, `PlayerAttackBase$$CalcMp`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `RecoveryAction$$OnInitialize (GetSkillLv)`

---

### เบรฟออร่า (BraveAura) · uid 229

<img src="../../icons/sk_229.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 2) · **Type:** Circle · **Max Lv:** 30 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ไลฟ์รีคัฟเวอรี่ · **Client class:** `BraveAuraAction`

> สร้างพื้นที่เพิ่ม ATK กับประสิทธิภาพอาวุธ
> 
> อัตราความแม่นของผู้ใช้จะลดลง
> และผลลัพธ์จะหมดไปเมื่อได้รับความเสียหาย

**Role:** buff (self) · circle / song area

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `SkillUtil.CalcCastTime(1, PlayerStatusBase.get_BattleStatus())`
- **Range** (`range`): `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 229

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `CastTime` = `SkillUtil.CalcCastTime(1, PlayerStatusBase.get_BattleStatus())`
- set `range` = `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (1 path)

- set `checkPos` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x`
- set `checkPos.y` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y`
- set `checkPos.z` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z`
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(229, Lv, Id)`

</details>

**Buffs**

**Buff `BraveAuraBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- `HitRate` = `0` _(when BuffEffectActive ne 0; IsSelfAction eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| LastDmgUpRate | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |
| EqAtkUpRate | 12 | 14 | 16 | 18 | 20 | 22 | 24 | 26 | 28 | 30 |
| HitRate | -73 | -70 | -68 | -65 | -63 | -60 | -58 | -55 | -53 | -50 |

- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `range` = `int(MathUtil.DisplayMeterToDistance((?ubfx + 5)))` when (self & 1) ne 0
  - `IsDamageCancel` = `1` = 1 when (self & 1) ne 0

---

### เมจิกบาเรีย (MagicBarrier) · uid 230

<img src="../../icons/sk_230.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 2) · **Type:** Circle · **Max Lv:** 30 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** มานารีชาร์จ · **Client class:** `MagicBarrierAction`

> สร้างพื้นที่ DEF กับประสิทธิภาพของอุปกรณ์ป้องกัน
> 
> อัตราหลบหลีกของผู้ใช้จะลดลง
> และผลลัพธ์จะหมดไปเมื่อได้รับความเสียหาย

**Role:** buff (self) · circle / song area

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `SkillUtil.CalcCastTime(1, PlayerStatusBase.get_BattleStatus())`
- **Range** (`range`): `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 230

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `CastTime` = `SkillUtil.CalcCastTime(1, PlayerStatusBase.get_BattleStatus())`
- set `range` = `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (1 path)

- set `checkPos` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x`
- set `checkPos.y` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y`
- set `checkPos.z` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z`
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(230, Lv, Id)`

</details>

**Buffs**

**Buff `MagicBarrierBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- `FleeRate` = `0` _(when BuffEffectActive ne 0; IsSelfAction eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MdefRate | 12 | 14 | 16 | 18 | 20 | 22 | 24 | 26 | 28 | 30 |
| DefRate | 12 | 14 | 16 | 18 | 20 | 22 | 24 | 26 | 28 | 30 |
| FleeRate | -73 | -70 | -68 | -65 | -63 | -60 | -58 | -55 | -53 | -50 |
| MobLastDamageRateSupport | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |

- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `range` = `int(MathUtil.DisplayMeterToDistance((?ubfx + 5)))` when (self & 1) ne 0
  - `IsDamageCancel` = `1` = 1 when (self & 1) ne 0

---

### รีคัฟเวอรี่ (Recovery) · uid 231

<img src="../../icons/sk_231.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 2) · **Type:** Heal · **Max Lv:** 30 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** มินิฮีล · **Client class:** `RecoveryAction`

> รักษาสภาวะผิดปกติให้เป้าหมาย 1 ชนิด
> ถ้าไม่มีสภาวะผิดปกติที่สามารถรักษาได้
> จะมีผลบัฟช่วยรักษาสภาวะผิดปกติได้ 1 ชนิดชั่วขณะ
> เมื่อรักษาสภาวะผิดปกติสำเร็จจะฟื้นฟู MP ของผู้ใช้ขึ้นเล็กน้อย

**Role:** buff (self) · heal / recovery

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`; `-1` = -1 _(when (isPlayer & 1) ne 0)_
- **HP healed** (`hpHeal`): `((gemCart(1006[2]) * [SkillFactory.CreateSkill(228)+0x120]) // 100)` _(when SkillActionBase.op_Inequality(SkillFactory.CreateSkill(228), 0) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 228, 1) ge 1)_

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 231

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (3 paths)

- set `ActionRange` = `48` = 48
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`
- set `hpHeal` = `((gemCart(1006[2]) * [SkillFactory.CreateSkill(228)+0x120]) // 100)` — when SkillActionBase.op_Inequality(SkillFactory.CreateSkill(228), 0) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 228, 1) ge 1
- set `SkillIndividualFlag` = `((gemCart(1006[2]) * [SkillFactory.CreateSkill(228)+0x120]) // 100)` — when SkillActionBase.op_Inequality(SkillFactory.CreateSkill(228), 0) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 228, 1) ge 1

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (7 paths)

- calls `RecoveryAction.AddRecovery` = `AddRecovery(PartyManager.GetPartyMemberDataUseArcheType(Singleton<PartyManager>.get_Instance(), Toram.Common.ArchetypeUid.get_Type(stkp(-56)), Toram.Common.ArchetypeUid.get_Id(stkp(-56))).MemberActionManager)` — when PartyManager.get_IsParty(Singleton<PartyManager>.get_Instance(actarAction, target)) AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(System.Linq.Enumerable.ToList<AbnormalData>(AbnormalStateManager.get_AbnormalList(OtherPlayerActionManager.get_AbnormalStatusManager())), RecoveryAction.<>c.<>9__24_0)) eq 0 AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<OtherPlayer>(target), 0)
- calls `RecoveryAction.AddRecovery` = `AddRecovery(PlayerObjectBase.get_ActionManager(TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, target)))` — when !UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<OtherPlayer>(target), 0) AND PartyManager.get_IsParty(Singleton<PartyManager>.get_Instance(actarAction, target)) AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(System.Linq.Enumerable.ToList<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerActionManagerBase.get_AbnormalStatusManager())), RecoveryAction.<>c.<>9__24_1)) eq 0 AND TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, target) ne 0

**`AddRecovery`** (1 path)

- calls `AbnormalStateManager.RemoveAbnormalState` = `RemoveAbnormalState(255)`

**`InitializeEnchantedSpell`** (2 paths)

- set `CastTime` = `-1` = -1 — when (isPlayer & 1) ne 0

</details>

**Buffs**

**Buff `RecoveryBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `CreateAspisSeoulBuf`, `CreateDefaultBuf`, `CreateVenomSnatchBuf`, `get_Effect`, `get_IsMpHeal`
- `Value` = `0` _(when BuffEffectActive eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 1 | 4 | 9 | 16 | 25 | 36 | 49 | 64 | 81 | 100 |

- Buff fields set in the constructor (all recovered):
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `IsSelfAction` = `(isSelf & 1)`
  - `BuffEffectActive` = `1` = 1
  - `BufEffectTakeUid` = `-1` = -1
  - `effectType` = `effectType`
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

<details><summary>Effect applied in `AspisSeoul$$ReceiveSupportEvent` (2 guarded paths)</summary>

- when `SkillLv(845) ge 1`
  - returns `SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), 231, 0, ?x3)`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- when `SkillLv(845) ge 1`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `RecoveryBuf$$CreateAspisSeoulBuf`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferManager$$AddSelfBuffer`

</details>

<details><summary>Effect applied in `AutoMemberActionManager$$AddAbnormalState` (13 guarded paths)</summary>

- when `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) ne 0` AND `(type - 1) ls 3`
- when `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) ne 0` AND `(type - 1) hi 3` AND `type eq 43`
  - returns `1`
  - calls `0x165db78`, `System.Action<object>$$.ctor`, `AbnormalStateManager$$AddAbnormalState`, `AutoMemberActionManager$$interruptAction`
- when `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) ne 0` AND `(type - 1) hi 3` AND `type eq 43`
  - returns `1`
  - calls `0x165db78`, `System.Action<object>$$.ctor`, `AbnormalStateManager$$AddAbnormalState`, `AutoMemberActionManager$$interruptAction`
- when `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) ne 0` AND `(type - 1) hi 3` AND `type eq 43`
  - returns `0`
  - calls `0x165db78`, `System.Action<object>$$.ctor`, `AbnormalStateManager$$AddAbnormalState`
- when `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) ne 0` AND `(type - 1) hi 3` AND `type ne 43`
  - returns `0`
  - calls `SkillBufferManager$$RemoveSelfBuffer`
- when `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) eq 0` AND `(type - 1) ls 3`
- when `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) eq 0` AND `(type - 1) hi 3` AND `type ne 20`
  - calls `AbnormalStateManager$$AddAbnormalState`
- when `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) eq 0` AND `(type - 1) hi 3` AND `type ne 20`
  - returns `1`
  - calls `0x165db78`, `System.Action<object>$$.ctor`, `AbnormalStateManager$$AddAbnormalState`, `AutoMemberActionManager$$interruptAction`

</details>

<details><summary>Effect applied in `MercenaryActionManager$$AddAbnormalState` (13 guarded paths)</summary>

- when `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) ne 0` AND `(type - 1) ls 3`
- when `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) ne 0` AND `(type - 1) hi 3` AND `type eq 43`
  - returns `1`
  - calls `0x165db78`, `System.Action<object>$$.ctor`, `AbnormalStateManager$$AddAbnormalState`, `MercenaryActionManager$$interruptAction`
- when `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) ne 0` AND `(type - 1) hi 3` AND `type eq 43`
  - returns `1`
  - calls `0x165db78`, `System.Action<object>$$.ctor`, `AbnormalStateManager$$AddAbnormalState`, `MercenaryActionManager$$interruptAction`
- when `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) ne 0` AND `(type - 1) hi 3` AND `type eq 43`
  - returns `0`
  - calls `0x165db78`, `System.Action<object>$$.ctor`, `AbnormalStateManager$$AddAbnormalState`
- when `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) ne 0` AND `(type - 1) hi 3` AND `type ne 43`
  - returns `0`
  - calls `SkillBufferManager$$RemoveSelfBuffer`
- when `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) eq 0` AND `(type - 1) ls 3`
- when `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) eq 0` AND `(type - 1) hi 3` AND `type ne 20`
  - calls `AbnormalStateManager$$AddAbnormalState`
- when `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) eq 0` AND `(type - 1) hi 3` AND `type ne 20`
  - returns `1`
  - calls `0x165db78`, `System.Action<object>$$.ctor`, `AbnormalStateManager$$AddAbnormalState`, `MercenaryActionManager$$interruptAction`

</details>

<details><summary>Effect applied in `PetMemberActionManager$$AddAbnormalState` (10 guarded paths)</summary>

- when `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) ne 0` AND `(type - 1) ls 3`
- when `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) ne 0` AND `(type - 1) hi 3` AND `type eq 43`
  - returns `1`
  - calls `0x165db78`, `System.Action<object>$$.ctor`, `AbnormalStateManager$$AddAbnormalState`, `PetMemberActionManager$$interruptAction`, `ClonePlayerAnimation$$PlayStun`
- when `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) ne 0` AND `(type - 1) hi 3` AND `type eq 43`
  - returns `1`
  - calls `0x165db78`, `System.Action<object>$$.ctor`, `AbnormalStateManager$$AddAbnormalState`, `PetMemberActionManager$$interruptAction`
- when `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) ne 0` AND `(type - 1) hi 3` AND `type eq 43`
  - returns `0`
  - calls `0x165db78`, `System.Action<object>$$.ctor`, `AbnormalStateManager$$AddAbnormalState`
- when `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) ne 0` AND `(type - 1) hi 3` AND `type ne 43`
  - returns `0`
  - calls `SkillBufferManager$$RemoveSelfBuffer`
- when `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) eq 0` AND `(type - 1) ls 3`
- when `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) eq 0` AND `(type - 1) hi 3` AND `type ne 43`
  - calls `AbnormalStateManager$$AddAbnormalState`
- when `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) eq 0` AND `(type - 1) hi 3` AND `type eq 43`
  - returns `1`
  - calls `0x165db78`, `System.Action<object>$$.ctor`, `AbnormalStateManager$$AddAbnormalState`, `PetMemberActionManager$$interruptAction`, `ClonePlayerAnimation$$PlayStun`

</details>

<details><summary>Effect applied in `OtherPlayerActionManager$$AddAbnormalState` (16 guarded paths)</summary>

- when `IsPartyMember ne 0` AND `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) ne 0` AND `(type - 1) ls 3`
- when `IsPartyMember ne 0` AND `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) ne 0` AND `(type - 1) hi 3`
  - returns `0`
  - calls `SkillBufferManager$$RemoveSelfBuffer`
- when `IsPartyMember ne 0` AND `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) ne 0` AND `(type - 1) hi 3`
  - returns `1`
  - calls `0x165db78`, `System.Action<object>$$.ctor`, `AbnormalStateManager$$AddAbnormalState`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerAnimation$$CompleteStop`
- when `IsPartyMember ne 0` AND `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) ne 0` AND `(type - 1) hi 3`
  - returns `1`
  - calls `0x165db78`, `System.Action<object>$$.ctor`, `AbnormalStateManager$$AddAbnormalState`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `Toram.Common.ArchetypeUid$$get_Type`, `virtual CharacterActionManagerBase.get_Size`
- when `IsPartyMember ne 0` AND `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) ne 0` AND `(type - 1) hi 3`
  - returns `1`
  - calls `0x165db78`, `System.Action<object>$$.ctor`, `AbnormalStateManager$$AddAbnormalState`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `Toram.Common.ArchetypeUid$$get_Type`, `Toram.Common.ArchetypeUid$$get_Type`
- when `IsPartyMember ne 0` AND `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) ne 0` AND `(type - 1) hi 3`
  - returns `0`
  - calls `0x165db78`, `System.Action<object>$$.ctor`, `AbnormalStateManager$$AddAbnormalState`
- when `IsPartyMember ne 0` AND `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) eq 0` AND `(type - 1) ls 3`
- when `IsPartyMember ne 0` AND `(resist & 1) eq 0` AND `(SkillBufferManager.ContainsBuffer(?blr, 231, 0, time) & 1) eq 0` AND `(type - 1) hi 3`
  - returns `1`
  - calls `0x165db78`, `System.Action<object>$$.ctor`, `AbnormalStateManager$$AddAbnormalState`, `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerAnimation$$CompleteStop`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `AspisSeoul$$ReceiveSupportEvent (ContainsBuffer)`
- `AutoMemberActionManager$$AddAbnormalState (ContainsBuffer)`
- `MercenaryActionManager$$AddAbnormalState (ContainsBuffer)`
- `OtherPlayerActionManager$$AddAbnormalState (ContainsBuffer)`
- `PetMemberActionManager$$AddAbnormalState (ContainsBuffer)`

---

### ไฮไซเคิล (HighCycle) · uid 232

<img src="../../icons/sk_232.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 3) · **Type:** Circle · **Max Lv:** 70 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เบรฟออร่า · **Client class:** `HighCycleAction`

> สร้างพื้นที่ที่ทำให้ร่ายเวทและชาร์จได้เร็วขึ้น
> 
> การฟื้นฟู MP ของผู้ใช้จะลดลง
> และผลลัพธ์จะหมดไปเมื่อได้รับความเสียหาย

**Role:** buff (self) · circle / song area

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `SkillUtil.CalcCastTime(2, PlayerStatusBase.get_BattleStatus())`
- **Range** (`range`): `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 232

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `CastTime` = `SkillUtil.CalcCastTime(2, PlayerStatusBase.get_BattleStatus())`
- set `range` = `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (1 path)

- set `checkPos` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x`
- set `checkPos.y` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y`
- set `checkPos.z` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z`
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(232, Lv, Id)`

</details>

**Buffs**

**Buff `HighCycleBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- `MpRecoveryUp` = `(((Lv * -2.5) + 50.5) eq -inf ? 0x80000000 : int(-((Lv * -2.5) + 50.5)))` _(when BuffEffectActive ne 0; IsSelfAction ne 0)_
- `MpRecoveryUp` = `0` _(when BuffEffectActive ne 0; IsSelfAction eq 0)_
- `AttackMprecoveryUpRate` = `(((Lv * -1.5) + 90.5) eq -inf ? 0x80000000 : int(-((Lv * -1.5) + 90.5)))` _(when BuffEffectActive ne 0; IsSelfAction ne 0)_
- `AttackMprecoveryUpRate` = `0` _(when BuffEffectActive ne 0; IsSelfAction eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| CspdUpRate | 25 | 50 | 75 | 100 | 125 | 150 | 175 | 200 | 225 | 250 |
| CspdUp | 100 | 150 | 200 | 250 | 300 | 350 | 400 | 450 | 500 | 550 |

- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `range` = `int(MathUtil.DisplayMeterToDistance((?ubfx + 5)))` when (self & 1) ne 0
  - `IsDamageCancel` = `1` = 1 when (self & 1) ne 0

<details><summary>Effect applied in `PlayerSecondaryStatus$$CalcMpRecovery` (20 guarded paths)</summary>

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

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `PlayerSecondaryStatus$$CalcMpRecovery (TryGetBuf)`

---

### อิมมูนิตี้ (DiseasetSeal) · uid 233

<img src="../../icons/sk_233.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 3) · **Type:** Circle · **Max Lv:** 70 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เมจิกบาเรีย · **Client class:** `DiseasetSealAction`

> สร้างพื้นที่ป้องกันสภาวะผิดปกติ
> 
> ความเร็วในการโจมตีของผู้ใช้จะลดลง
> และผลลัพธ์จะหมดไปเมื่อได้รับความเสียหาย

**Role:** buff (self) · circle / song area

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `SkillUtil.CalcCastTime(2, PlayerStatusBase.get_BattleStatus())`
- **Range** (`range`): `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 233

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `CastTime` = `SkillUtil.CalcCastTime(2, PlayerStatusBase.get_BattleStatus())`
- set `range` = `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (1 path)

- set `checkPos` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x`
- set `checkPos.y` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y`
- set `checkPos.z` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z`
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(233, Lv, Id)`

</details>

**Buffs**

**Buff `DiseasetSealBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- `AspdRate` = `0` _(when BuffEffectActive ne 0; IsSelfAction eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| AbnormalRegist | 23 | 26 | 29 | 32 | 35 | 38 | 41 | 44 | 47 | 50 |
| AspdRate | -925 | -850 | -775 | -700 | -625 | -550 | -475 | -400 | -325 | -250 |

- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `range` = `int(MathUtil.DisplayMeterToDistance((?ubfx + 5)))` when (self & 1) ne 0
  - `IsDamageCancel` = `1` = 1 when (self & 1) ne 0

---

### แซงจูรี่ (Sanctuary) · uid 234

<img src="../../icons/sk_234.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 3) · **Type:** Object · **Max Lv:** 70 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** รีคัฟเวอรี่ · **Client class:** `SanctuaryAction`

> สร้างอาณาเขตศักดิ์สิทธิ์เพื่อปกป้องพวกพ้อง
> ผู้เล่นที่อยู่ในอาณาเขตศักดิ์สิทธิ์จะได้รับความเสียหายลดลง
> ปริมาณที่ลดลงจะขึ้นอยู่กับ HP สูงสุดของแต่ละคน
> และไม่สามารถลดได้หากความเสียหายนั้นรุนแรงเกินไป

**Role:** buff (self) · placed object / trap / summon

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `0` = 0
- **Range** (`range`): `int(MathUtil.DisplayMeterToDistance(int(((Lv / 3) + 0.99))))`; `int(MathUtil.DisplayMeterToDistance(int(((motionSpeed / 3) + 0.99))))`
- **Loop / hit-repeat count** (`LoopParam`): `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 234

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `CastTime` = `0` = 0
- set `range` = `int(MathUtil.DisplayMeterToDistance(int(((Lv / 3) + 0.99))))`
- set `LoopParam` = `Lv` → Lv1..10: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `range` = `int(MathUtil.DisplayMeterToDistance(int(((motionSpeed / 3) + 0.99))))`

**`ActionHit`** (1 path)

- set `checkPos` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x`
- set `checkPos.y` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y`
- set `checkPos.z` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z`

</details>

**Buffs**

**Buff `SanctuaryBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_PlacePosition`, `set_PlacePosition`
- Duration: `2` s

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| LimitRegistDamage | 5 | 6 | 6 | 7 | 7 | 8 | 8 | 9 | 9 | 10 |
| MobLastDamageRateUnique | 30 | 30 | 30 | 50 | 50 | 50 | 70 | 70 | 70 | 90 |

- Buff fields set in the constructor (all recovered):
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `IsSelfAction` = `(self & 1)`
  - `BuffEffectActive` = `1` = 1
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

---

### ควิกโมชั่น (QuickMotion) · uid 235

<img src="../../icons/sk_235.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 4) · **Type:** Circle · **Max Lv:** 150 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ไฮไซเคิล · **Client class:** `QuickMotionAction`

> สร้างพื้นที่เพิ่มความเร็วการโจมตี
> 
> MP ที่ใช้สำหรับสกิลของผู้ใช้จะลดลง
> และผลลัพธ์จะหมดไปเมื่อได้รับความเสียหาย

**Role:** buff (self) · circle / song area

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `SkillUtil.CalcCastTime(3, PlayerStatusBase.get_BattleStatus())`
- **Range** (`range`): `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 235

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `CastTime` = `SkillUtil.CalcCastTime(3, PlayerStatusBase.get_BattleStatus())`
- set `range` = `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (1 path)

- set `checkPos` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x`
- set `checkPos.y` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y`
- set `checkPos.z` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z`
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(235, Lv, Id)`

</details>

**Buffs**

**Buff `QuickMotionBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| AspdRate | 25 | 50 | 75 | 100 | 125 | 150 | 175 | 200 | 225 | 250 |
| Aspd | 200 | 300 | 400 | 500 | 600 | 700 | 800 | 900 | 1000 | 1100 |
| AttackMprecoveryUpRate | -97 | -94 | -91 | -88 | -85 | -82 | -79 | -76 | -73 | -70 |

- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `range` = `int(MathUtil.DisplayMeterToDistance((?ubfx + 5)))` when (self & 1) ne 0
  - `IsDamageCancel` = `1` = 1 when (self & 1) ne 0

---

### ฟาสต์รีเอคชั่น (HighReaction) · uid 236

<img src="../../icons/sk_236.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 4) · **Type:** Circle · **Max Lv:** 150 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** อิมมูนิตี้ · **Client class:** `HighReactionAction`

> สร้างพื้นที่เพิ่มการฟื้นฟู Guard และ Avoid
> 
> ผู้ใช้จะร่ายเวทย์ได้ช้าลง
> และผลจะสิ้นสุดลงเมื่อได้รับความเสียหาย

**Role:** buff (self) · circle / song area

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `SkillUtil.CalcCastTime(3, PlayerStatusBase.get_BattleStatus())`
- **Range** (`range`): `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 236

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `CastTime` = `SkillUtil.CalcCastTime(3, PlayerStatusBase.get_BattleStatus())`
- set `range` = `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (1 path)

- set `checkPos` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x`
- set `checkPos.y` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y`
- set `checkPos.z` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z`
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(236, Lv, Id)`

</details>

**Buffs**

**Buff `HighReactionBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- `CspdUpRate` = `0` _(when BuffEffectActive ne 0; IsSelfAction eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Guard | 11 | 12 | 13 | 14 | 15 | 16 | 17 | 18 | 19 | 20 |
| AvoidUp | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| CspdUpRate | -925 | -850 | -775 | -700 | -625 | -550 | -475 | -400 | -325 | -250 |

- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `range` = `int(MathUtil.DisplayMeterToDistance((?ubfx + 5)))` when (self & 1) ne 0
  - `IsDamageCancel` = `1` = 1 when (self & 1) ne 0

---

### ฮีล (Heal) · uid 237

<img src="../../icons/sk_237.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 4) · **Type:** Heal · **Max Lv:** 150 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** แซงจูรี่ · **Client class:** `HealAction`

> ฟื้นฟู HP เป้าหมาย
> ถ้าใช้กับผู้เล่นที่ไม่สามารถต่อสู้ได้
> จะทำให้ฟื้นคืนชีพเร็วขึ้นเล็กน้อย

**Role:** heal / recovery

This action never changes monster proration: ExpType None: no proration slot.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `0` = 0 _(when !hasGemCart(1026) AND SkillBufferDataBase.GetParam(20) ge ((hasGemCart(1007) ? 200 : 300) // 100) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND SkillBufferDataBase.GetParam(20) ge ((hasGemCart(1007) ? 200 : 300) // 100) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND SkillBufferDataBase.GetParam(20) ge ((hasGemCart(1007) ? 200 : 300) // 100) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 AND hasGemCart(1026))_; `SkillUtil.CalcCastTime(1, PlayerStatusBase.get_BattleStatus())` _(when !hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND hasGemCart(1026))_
- **HP healed** (`hpHeal`): `(((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300)) - int((((((GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) + (GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) << 2)) << 1) * -0.01) + 1) * ((((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300)) lt 0 ? (((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300)) + 1) : ((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300))) >> 1))))` _(when GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) eq 0 AND hasGemCart(1026))_; `(((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300)) - ((((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300)) lt 0 ? (((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300)) + 1) : ((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300))) >> 1))` _(when GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) eq 0 AND hasGemCart(1026))_; `((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300))` _(when !hasGemCart(1026) OR !hasGemCart(1026) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 OR !hasGemCart(1026) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) eq 0)_
- **Base MP cost** (`baseMp`): `(hasGemCart(1007) ? 200 : 300)`
- **MP cost** (`costMp`): `0` = 0 _(when SkillIndividualFlag eq 1)_

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 237

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (24 paths)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(24)`
- set `CastTime` = `0` = 0 — when !hasGemCart(1026) AND SkillBufferDataBase.GetParam(20) ge ((hasGemCart(1007) ? 200 : 300) // 100) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND SkillBufferDataBase.GetParam(20) ge ((hasGemCart(1007) ? 200 : 300) // 100) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND SkillBufferDataBase.GetParam(20) ge ((hasGemCart(1007) ? 200 : 300) // 100) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 AND hasGemCart(1026)
- set `hpHeal` = `(((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300)) - int((((((GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) + (GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) << 2)) << 1) * -0.01) + 1) * ((((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300)) lt 0 ? (((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300)) + 1) : ((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300))) >> 1))))` — when GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) eq 0 AND hasGemCart(1026)
- set `baseMp` = `(hasGemCart(1007) ? 200 : 300)`
- set `SkillIndividualFlag` = `1` = 1 — when !hasGemCart(1026) AND SkillBufferDataBase.GetParam(20) ge ((hasGemCart(1007) ? 200 : 300) // 100) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND SkillBufferDataBase.GetParam(20) ge ((hasGemCart(1007) ? 200 : 300) // 100) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND SkillBufferDataBase.GetParam(20) ge ((hasGemCart(1007) ? 200 : 300) // 100) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 AND hasGemCart(1026)
- set `CastTime` = `SkillUtil.CalcCastTime(1, PlayerStatusBase.get_BattleStatus())` — when !hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND hasGemCart(1026)
- set `hpHeal` = `(((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300)) - ((((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300)) lt 0 ? (((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300)) + 1) : ((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300))) >> 1))` — when GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) eq 0 AND hasGemCart(1026)
- set `hpHeal` = `((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300))` — when !hasGemCart(1026) OR !hasGemCart(1026) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 OR !hasGemCart(1026) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) eq 0

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`CheckHealStock`** (2 paths)

- set `costMp` = `0` = 0 — when SkillIndividualFlag eq 1

</details>

---
