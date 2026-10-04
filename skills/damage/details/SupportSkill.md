# サポートスキル (`SupportSkill`) — skill details

13 entries.

### ปฐมพยาบาล (FirstAidMastary) · uid 225

<img src="../../icons/sk_225.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 10 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem · **Client class:** `FirstAidMastary` (passive mastery)

> ประสิทธิภาพของ[ปฐมพยาบาล]ในเมนูสนับสนุนเพิ่มขึ้น
> เวลาที่ใช้รอในการคืนชีพลดลงอย่างมาก

**How it works**

- Mastery skill of the サポートスキル tree (tier 1, max Lv 10); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.

_Raw recovered data (every method item): [trees/SupportSkill.md](../trees/SupportSkill.md) — uid 225_

---

### ไลฟ์รีคัฟเวอรี่ (LifeRecovery) · uid 226

<img src="../../icons/sk_226.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 1) · **Type:** Circle · **Max Lv:** 10 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem · **Client class:** `LifeRecoveryAction`

> สร้างพื้นที่สำหรับฟื้นฟู HP อย่างต่อเนื่อง
> 
> DEF ของผู้ใช้จะลดลง
> และผลลัพธ์จะหมดไปเมื่อได้รับความเสียหาย

**How it works**

- Circle skill of the サポートスキル tree (tier 1, max Lv 10); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It creates an area (circle / song field) that affects targets standing inside.
- Buffs:
  - `LifeRecoveryBuf`; Lv1 → Lv10: MobLastDamageRateBuf (final damage multiplier vs monsters (buff category)) 190 → 100
  - `CircleBufferBase`: lasts `900` s / `time` s
- Other client code reads this skill (2 lookups; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `0` = 0
- **Range** (`range`) (Unity units, 2 = 1 m): `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 3 set, 2 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 226
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `LifeRecoveryBuf` — `.ctor(Lv, 1, 0)`
- `ActionHit` (when the attack connects): adds the caster's buff of `new LifeRecoveryBuf` — `AddSelfBuffer(new LifeRecoveryBuf, Id)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `0` = 0
- **Range** (`range`): `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `HpRecoveryUp`: HP natural recovery +
- `MobLastDamageRateBuf`: final damage multiplier vs monsters (buff category)

**Where else this skill takes effect**

- Effect applied in `PlayerSecondaryStatus$$CalcHpRecovery` (19 guarded paths):
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
- Effect applied in `PlayerSecondaryStatus$$get_HpRecovery` (3 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 226, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + int(BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), (((PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) lt 0x1869f ? PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) : 0x1869f) // 25) + 10), 35, 34)))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 226, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 226, stkp(-24), 0) & 1) eq 0`
    - returns `int(BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), (((PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) lt 0x1869f ? PlayerSecondaryStatus.CalcBaseMaxHp(this, ?mi, ?x2, ?x3) : 0x1869f) // 25) + 10), 35, 34))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxHp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`
- Code that reads this skill's level / buff by constant id: `PlayerSecondaryStatus$$CalcHpRecovery (TryGetBuf)`, `PlayerSecondaryStatus$$get_HpRecovery (TryGetBuf)`

_Raw recovered data (every method item): [trees/SupportSkill.md](../trees/SupportSkill.md) — uid 226_

---

### มานารีชาร์จ (ManaRecharge) · uid 227

<img src="../../icons/sk_227.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 1) · **Type:** Circle · **Max Lv:** 10 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem · **Client class:** `ManaRechargeAction`

> สร้างพื้นที่สำหรับฟื้นฟู MP อย่างต่อเนื่อง
> 
> ATK ของผู้ใช้จะลดลง
> และผลลัพธ์ที่เกิดจะหมดไปเมื่อได้รับความเสียหาย

**How it works**

- Circle skill of the サポートスキル tree (tier 1, max Lv 10); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It creates an area (circle / song field) that affects targets standing inside.
- Buffs:
  - `ManaRechargeBuf`; Lv1 → Lv10: LastDmgDownRate (final damage dealt reduced %) 47 → 25
  - `CircleBufferBase`: lasts `900` s / `time` s
- Other client code reads this skill (2 lookups; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `0` = 0
- **Range** (`range`) (Unity units, 2 = 1 m): `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 3 set, 2 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 227
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `ManaRechargeBuf` — `.ctor(Lv, 1, 0)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): adds the caster's buff of `new ManaRechargeBuf` — `AddSelfBuffer(new ManaRechargeBuf, Id)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `0` = 0
- **Range** (`range`): `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `LastDmgDownRate`: final damage dealt reduced %
- `MpRecoveryUp`: MP natural recovery +

**Where else this skill takes effect**

- Effect applied in `PlayerSecondaryStatus$$get_MpRecovery` (3 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 227, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + int(BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), ((max((PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) lt 2000 ? PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) : 2000), 0) // 100) + 1), 37, 36)))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 227, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 227, stkp(-24), 0) & 1) eq 0`
    - returns `int(BonusManager.GetCalcBonusValue(CharacterActionManagerBase.get_MoveSpeed(), ((max((PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) lt 2000 ? PlayerSecondaryStatus.CalcBaseMaxMp(this, ?mi, ?x2, ?x3) : 2000), 0) // 100) + 1), 37, 36))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `PlayerSecondaryStatus$$CalcBaseMaxMp`, `BonusManager$$GetCalcBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`
- Effect applied in `PlayerSecondaryStatus$$CalcMpRecovery` (29 guarded paths):
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
- Code that reads this skill's level / buff by constant id: `PlayerSecondaryStatus$$CalcMpRecovery (TryGetBuf)`, `PlayerSecondaryStatus$$get_MpRecovery (TryGetBuf)`

_Raw recovered data (every method item): [trees/SupportSkill.md](../trees/SupportSkill.md) — uid 227_

---

### มินิฮีล (PetitHeal) · uid 228

<img src="../../icons/sk_228.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 1) · **Type:** Heal · **Max Lv:** 10 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem · **Client class:** `PutitHealAction`

> ฟื้นฟู HP ให้เป้าหมายเล็กน้อย
> และจะช่วยลดเวลาคืนชีพให้สั้นลง
> เมื่อเป้าหมายอยู่ในระหว่างรอคืนชีพ

**How it works**

- Heal skill of the サポートスキル tree (tier 1, max Lv 10); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It restores HP or MP.
- MP: `0`.
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **MP cost** (`costMp` in `CheckHealStock`): `0` = 0
  - when `SkillIndividualFlag eq 1`
- **Cast time** (`CastTime`): `0` = 0
  - when `SkillBufferDataBase.GetParam(20) ge (baseMp // 100) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0`
- **Cast time** (`CastTime`): `SkillUtil.CalcCastTime(1, PlayerStatusBase.get_BattleStatus())`
- **Cast time** (`CastTime`): `-1` = -1
  - when `(isPlayer & 1) ne 0`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(24)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 5 set
- `ActionPreparation` — before the cast starts: 2 set
- `CheckHealStock` — skill-specific method: 1 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `InitializeEnchantedSpell` — skill-specific method: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 228
- No proration slot: ExpType None: no proration slot.

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `0` = 0 _(when SkillBufferDataBase.GetParam(20) ge (baseMp // 100) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0)_; `SkillUtil.CalcCastTime(1, PlayerStatusBase.get_BattleStatus())`; `-1` = -1 _(when (isPlayer & 1) ne 0)_
- **HP healed** (`hpHeal`): `(((status.MaxHp * Lv) // 100) + (Lv * 30))`; `(hpHeal - int((((((GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) + (GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) << 2)) << 1) * -0.01) + 1) * ((hpHeal lt 0 ? (hpHeal + 1) : hpHeal) >> 1))))` _(when GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND SkillIndividualFlag eq 1 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND SkillIndividualFlag ne 1 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND SkillIndividualFlag eq 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 AND hasGemCart(1026))_; `(hpHeal - ((hpHeal lt 0 ? (hpHeal + 1) : hpHeal) >> 1))` _(when GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND SkillIndividualFlag eq 1 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND SkillIndividualFlag ne 1 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND SkillIndividualFlag eq 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 AND hasGemCart(1026))_
- **MP cost** (`costMp`): `0` = 0 _(when SkillIndividualFlag eq 1)_

**Where else this skill takes effect**

- Effect applied in `RecoveryAction$$OnInitialize` (2 guarded paths):
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
- Code that reads this skill's level / buff by constant id: `RecoveryAction$$OnInitialize (GetSkillLv)`

_Raw recovered data (every method item): [trees/SupportSkill.md](../trees/SupportSkill.md) — uid 228_

---

### เบรฟออร่า (BraveAura) · uid 229

<img src="../../icons/sk_229.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 2) · **Type:** Circle · **Max Lv:** 30 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ไลฟ์รีคัฟเวอรี่ · **Client class:** `BraveAuraAction`

> สร้างพื้นที่เพิ่ม ATK กับประสิทธิภาพอาวุธ
> 
> อัตราความแม่นของผู้ใช้จะลดลง
> และผลลัพธ์จะหมดไปเมื่อได้รับความเสียหาย

**How it works**

- Circle skill of the サポートスキル tree (tier 2, max Lv 30); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It creates an area (circle / song field) that affects targets standing inside.
- Buffs:
  - `BraveAuraBuf`; Lv1 → Lv10: LastDmgUpRate (final damage dealt %) 2 → 20, EqAtkUpRate (weapon ATK %) 12 → 30, HitRate (accuracy %) -73 → -50

**Cost, timing and range**

- **Cast time** (`CastTime`): `SkillUtil.CalcCastTime(1, PlayerStatusBase.get_BattleStatus())`
- **Range** (`range`) (Unity units, 2 = 1 m): `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 3 set, 1 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 229
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): adds the caster's buff of skill 229 (BraveAura) — `AddSelfBuffer(229, Lv, Id)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `SkillUtil.CalcCastTime(1, PlayerStatusBase.get_BattleStatus())`
- **Range** (`range`): `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `EqAtkUpRate`: weapon ATK %
- `HitRate`: accuracy %
- `LastDmgUpRate`: final damage dealt %

_Raw recovered data (every method item): [trees/SupportSkill.md](../trees/SupportSkill.md) — uid 229_

---

### เมจิกบาเรีย (MagicBarrier) · uid 230

<img src="../../icons/sk_230.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 2) · **Type:** Circle · **Max Lv:** 30 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** มานารีชาร์จ · **Client class:** `MagicBarrierAction`

> สร้างพื้นที่ DEF กับประสิทธิภาพของอุปกรณ์ป้องกัน
> 
> อัตราหลบหลีกของผู้ใช้จะลดลง
> และผลลัพธ์จะหมดไปเมื่อได้รับความเสียหาย

**How it works**

- Circle skill of the サポートスキル tree (tier 2, max Lv 30); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It creates an area (circle / song field) that affects targets standing inside.
- Buffs:
  - `MagicBarrierBuf`; Lv1 → Lv10: MdefRate (MDEF %) 12 → 30, DefRate (DEF %) 12 → 30, FleeRate (dodge %) -73 → -50, MobLastDamageRateSupport (final damage multiplier vs monsters (support category)) 2 → 20

**Cost, timing and range**

- **Cast time** (`CastTime`): `SkillUtil.CalcCastTime(1, PlayerStatusBase.get_BattleStatus())`
- **Range** (`range`) (Unity units, 2 = 1 m): `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 3 set, 1 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 230
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): adds the caster's buff of skill 230 (MagicBarrier) — `AddSelfBuffer(230, Lv, Id)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `SkillUtil.CalcCastTime(1, PlayerStatusBase.get_BattleStatus())`
- **Range** (`range`): `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `DefRate`: DEF %
- `FleeRate`: dodge %
- `MdefRate`: MDEF %
- `MobLastDamageRateSupport`: final damage multiplier vs monsters (support category)

_Raw recovered data (every method item): [trees/SupportSkill.md](../trees/SupportSkill.md) — uid 230_

---

### รีคัฟเวอรี่ (Recovery) · uid 231

<img src="../../icons/sk_231.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 2) · **Type:** Heal · **Max Lv:** 30 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** มินิฮีล · **Client class:** `RecoveryAction`

> รักษาสภาวะผิดปกติให้เป้าหมาย 1 ชนิด
> ถ้าไม่มีสภาวะผิดปกติที่สามารถรักษาได้
> จะมีผลบัฟช่วยรักษาสภาวะผิดปกติได้ 1 ชนิดชั่วขณะ
> เมื่อรักษาสภาวะผิดปกติสำเร็จจะฟื้นฟู MP ของผู้ใช้ขึ้นเล็กน้อย

**How it works**

- Heal skill of the サポートスキル tree (tier 2, max Lv 30); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It restores HP or MP.
- Buffs:
  - `RecoveryBuf`; Lv1 → Lv10: Value (generic value (meaning set by the code that reads the buff)) 1 → 100
- Other client code reads this skill (5 lookups; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`
- **Cast time** (`CastTime`): `-1` = -1
  - when `(isPlayer & 1) ne 0`
- **ActionRange** (`ActionRange`): `48` = 48

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 2 call
- `AddRecovery` — skill-specific method: 1 call
- `InitializeEnchantedSpell` — skill-specific method: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 231
- No proration slot: ExpType None: no proration slot.

**Status ailments**

- Removes ailment **Recovery (255)** (`AddRecovery`)

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): queues a recovery for a target — `AddRecovery(PartyManager.GetPartyMemberDataUseArcheType(Singleton<PartyManager>.get_Instance(), Toram.Common.ArchetypeUid.get_Type(stkp(-56)), Toram.Common.ArchetypeUid.get_Id(stkp(-56))).MemberActionManager)`
  - when `PartyManager.get_IsParty(Singleton<PartyManager>.get_Instance(actarAction, target)) AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(System.Linq.Enumerable.ToList<AbnormalData>(AbnormalStateManager.get_AbnormalList(OtherPlayerActionManager.get_AbnormalStatusManager())), RecoveryAction.<>c.<>9__24_0)) eq 0 AND UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<OtherPlayer>(target), 0)`
- `ActionHit` (when the attack connects): queues a recovery for a target — `AddRecovery(PlayerObjectBase.get_ActionManager(TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, target)))`
  - when `!UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<OtherPlayer>(target), 0) AND PartyManager.get_IsParty(Singleton<PartyManager>.get_Instance(actarAction, target)) AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(System.Linq.Enumerable.ToList<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerActionManagerBase.get_AbnormalStatusManager())), RecoveryAction.<>c.<>9__24_1)) eq 0 AND TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, target) ne 0`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`; `-1` = -1 _(when (isPlayer & 1) ne 0)_
- **HP healed** (`hpHeal`): `((gemCart(1006[2]) * [SkillFactory.CreateSkill(228)+0x120]) // 100)` _(when SkillActionBase.op_Inequality(SkillFactory.CreateSkill(228), 0) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 228, 1) ge 1)_

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `Value`: generic value (meaning set by the code that reads the buff)

**Where else this skill takes effect**

- Effect applied in `AspisSeoul$$ReceiveSupportEvent` (2 guarded paths):
  - when `SkillLv(845) ge 1`
    - returns `SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), 231, 0, ?x3)`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `SkillLv(845) ge 1`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `RecoveryBuf$$CreateAspisSeoulBuf`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferManager$$AddSelfBuffer`
- Effect applied in `AutoMemberActionManager$$AddAbnormalState` (13 guarded paths):
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
- Effect applied in `MercenaryActionManager$$AddAbnormalState` (13 guarded paths):
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
- Effect applied in `PetMemberActionManager$$AddAbnormalState` (10 guarded paths):
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
- Effect applied in `OtherPlayerActionManager$$AddAbnormalState` (16 guarded paths):
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
- Code that reads this skill's level / buff by constant id: `AspisSeoul$$ReceiveSupportEvent (ContainsBuffer)`, `AutoMemberActionManager$$AddAbnormalState (ContainsBuffer)`, `MercenaryActionManager$$AddAbnormalState (ContainsBuffer)`, `OtherPlayerActionManager$$AddAbnormalState (ContainsBuffer)`, `PetMemberActionManager$$AddAbnormalState (ContainsBuffer)`

_Raw recovered data (every method item): [trees/SupportSkill.md](../trees/SupportSkill.md) — uid 231_

---

### ไฮไซเคิล (HighCycle) · uid 232

<img src="../../icons/sk_232.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 3) · **Type:** Circle · **Max Lv:** 70 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เบรฟออร่า · **Client class:** `HighCycleAction`

> สร้างพื้นที่ที่ทำให้ร่ายเวทและชาร์จได้เร็วขึ้น
> 
> การฟื้นฟู MP ของผู้ใช้จะลดลง
> และผลลัพธ์จะหมดไปเมื่อได้รับความเสียหาย

**How it works**

- Circle skill of the サポートスキル tree (tier 3, max Lv 70); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It creates an area (circle / song field) that affects targets standing inside.
- Buffs:
  - `HighCycleBuf`; Lv1 → Lv10: CspdUpRate (cast speed %) 25 → 250, CspdUp (cast speed +) 100 → 550
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `SkillUtil.CalcCastTime(2, PlayerStatusBase.get_BattleStatus())`
- **Range** (`range`) (Unity units, 2 = 1 m): `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 3 set, 1 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 232
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): adds the caster's buff of skill 232 (HighCycle) — `AddSelfBuffer(232, Lv, Id)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `SkillUtil.CalcCastTime(2, PlayerStatusBase.get_BattleStatus())`
- **Range** (`range`): `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `AttackMprecoveryUpRate`: MP recovered per attack (%)
- `CspdUp`: cast speed +
- `CspdUpRate`: cast speed %
- `MpRecoveryUp`: MP natural recovery +

**Where else this skill takes effect**

- Effect applied in `PlayerSecondaryStatus$$CalcMpRecovery` (20 guarded paths):
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
- Code that reads this skill's level / buff by constant id: `PlayerSecondaryStatus$$CalcMpRecovery (TryGetBuf)`

_Raw recovered data (every method item): [trees/SupportSkill.md](../trees/SupportSkill.md) — uid 232_

---

### อิมมูนิตี้ (DiseasetSeal) · uid 233

<img src="../../icons/sk_233.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 3) · **Type:** Circle · **Max Lv:** 70 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เมจิกบาเรีย · **Client class:** `DiseasetSealAction`

> สร้างพื้นที่ป้องกันสภาวะผิดปกติ
> 
> ความเร็วในการโจมตีของผู้ใช้จะลดลง
> และผลลัพธ์จะหมดไปเมื่อได้รับความเสียหาย

**How it works**

- Circle skill of the サポートスキル tree (tier 3, max Lv 70); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It creates an area (circle / song field) that affects targets standing inside.
- Buffs:
  - `DiseasetSealBuf`; Lv1 → Lv10: AbnormalRegist (ailment resistance) 23 → 50, AspdRate (attack speed %) -925 → -250

**Cost, timing and range**

- **Cast time** (`CastTime`): `SkillUtil.CalcCastTime(2, PlayerStatusBase.get_BattleStatus())`
- **Range** (`range`) (Unity units, 2 = 1 m): `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 3 set, 1 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 233
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): adds the caster's buff of skill 233 (DiseasetSeal) — `AddSelfBuffer(233, Lv, Id)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `SkillUtil.CalcCastTime(2, PlayerStatusBase.get_BattleStatus())`
- **Range** (`range`): `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `AbnormalRegist`: ailment resistance
- `AspdRate`: attack speed %

_Raw recovered data (every method item): [trees/SupportSkill.md](../trees/SupportSkill.md) — uid 233_

---

### แซงจูรี่ (Sanctuary) · uid 234

<img src="../../icons/sk_234.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 3) · **Type:** Object · **Max Lv:** 70 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** รีคัฟเวอรี่ · **Client class:** `SanctuaryAction`

> สร้างอาณาเขตศักดิ์สิทธิ์เพื่อปกป้องพวกพ้อง
> ผู้เล่นที่อยู่ในอาณาเขตศักดิ์สิทธิ์จะได้รับความเสียหายลดลง
> ปริมาณที่ลดลงจะขึ้นอยู่กับ HP สูงสุดของแต่ละคน
> และไม่สามารถลดได้หากความเสียหายนั้นรุนแรงเกินไป

**How it works**

- Object skill of the サポートスキル tree (tier 3, max Lv 70); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It places an object in the world (trap, summon or field object).
- Buffs:
  - `SanctuaryBuf`: lasts `2` s; Lv1 → Lv10: LimitRegistDamage (damage-limit resistance) 5 → 10, MobLastDamageRateUnique (final damage multiplier vs monsters (unique category)) 30 → 90

**Cost, timing and range**

- **Cast time** (`CastTime`): `0` = 0
- **Range** (`range`) (Unity units, 2 = 1 m): `int(MathUtil.DisplayMeterToDistance(int(((Lv / 3) + 0.99))))`
- **Range** (`range`) (Unity units, 2 = 1 m): `int(MathUtil.DisplayMeterToDistance(int(((motionSpeed / 3) + 0.99))))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionHit` — when the attack connects: 3 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 234
- No proration slot: ExpType None: no proration slot.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `0` = 0
- **Range** (`range`): `int(MathUtil.DisplayMeterToDistance(int(((Lv / 3) + 0.99))))`; `int(MathUtil.DisplayMeterToDistance(int(((motionSpeed / 3) + 0.99))))`
- **Loop / hit-repeat count** (`LoopParam`): `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `LimitRegistDamage`: damage-limit resistance
- `MobLastDamageRateUnique`: final damage multiplier vs monsters (unique category)

_Raw recovered data (every method item): [trees/SupportSkill.md](../trees/SupportSkill.md) — uid 234_

---

### ควิกโมชั่น (QuickMotion) · uid 235

<img src="../../icons/sk_235.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 4) · **Type:** Circle · **Max Lv:** 150 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ไฮไซเคิล · **Client class:** `QuickMotionAction`

> สร้างพื้นที่เพิ่มความเร็วการโจมตี
> 
> MP ที่ใช้สำหรับสกิลของผู้ใช้จะลดลง
> และผลลัพธ์จะหมดไปเมื่อได้รับความเสียหาย

**How it works**

- Circle skill of the サポートスキル tree (tier 4, max Lv 150); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It creates an area (circle / song field) that affects targets standing inside.
- Buffs:
  - `QuickMotionBuf`; Lv1 → Lv10: AspdRate (attack speed %) 25 → 250, Aspd (attack speed +) 200 → 1100, AttackMprecoveryUpRate (MP recovered per attack (%)) -97 → -70

**Cost, timing and range**

- **Cast time** (`CastTime`): `SkillUtil.CalcCastTime(3, PlayerStatusBase.get_BattleStatus())`
- **Range** (`range`) (Unity units, 2 = 1 m): `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 3 set, 1 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 235
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): adds the caster's buff of skill 235 (QuickMotion) — `AddSelfBuffer(235, Lv, Id)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `SkillUtil.CalcCastTime(3, PlayerStatusBase.get_BattleStatus())`
- **Range** (`range`): `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `Aspd`: attack speed +
- `AspdRate`: attack speed %
- `AttackMprecoveryUpRate`: MP recovered per attack (%)

_Raw recovered data (every method item): [trees/SupportSkill.md](../trees/SupportSkill.md) — uid 235_

---

### ฟาสต์รีเอคชั่น (HighReaction) · uid 236

<img src="../../icons/sk_236.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 4) · **Type:** Circle · **Max Lv:** 150 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** อิมมูนิตี้ · **Client class:** `HighReactionAction`

> สร้างพื้นที่เพิ่มการฟื้นฟู Guard และ Avoid
> 
> ผู้ใช้จะร่ายเวทย์ได้ช้าลง
> และผลจะสิ้นสุดลงเมื่อได้รับความเสียหาย

**How it works**

- Circle skill of the サポートスキル tree (tier 4, max Lv 150); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It creates an area (circle / song field) that affects targets standing inside.
- Buffs:
  - `HighReactionBuf`; Lv1 → Lv10: Guard (guard (block) rate) 11 → 20, AvoidUp (dodge +) 1 → 10, CspdUpRate (cast speed %) -925 → -250

**Cost, timing and range**

- **Cast time** (`CastTime`): `SkillUtil.CalcCastTime(3, PlayerStatusBase.get_BattleStatus())`
- **Range** (`range`) (Unity units, 2 = 1 m): `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 3 set, 1 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 236
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): adds the caster's buff of skill 236 (HighReaction) — `AddSelfBuffer(236, Lv, Id)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `SkillUtil.CalcCastTime(3, PlayerStatusBase.get_BattleStatus())`
- **Range** (`range`): `int(MathUtil.DisplayMeterToDistance(((Lv >> 1) + 5)))`

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `AvoidUp`: dodge +
- `CspdUpRate`: cast speed %
- `Guard`: guard (block) rate

_Raw recovered data (every method item): [trees/SupportSkill.md](../trees/SupportSkill.md) — uid 236_

---

### ฮีล (Heal) · uid 237

<img src="../../icons/sk_237.png" width="40" alt="icon"> 
**Tree:** サポートスキル (`SupportSkill`, tier 4) · **Type:** Heal · **Max Lv:** 150 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** แซงจูรี่ · **Client class:** `HealAction`

> ฟื้นฟู HP เป้าหมาย
> ถ้าใช้กับผู้เล่นที่ไม่สามารถต่อสู้ได้
> จะทำให้ฟื้นคืนชีพเร็วขึ้นเล็กน้อย

**How it works**

- Heal skill of the サポートスキル tree (tier 4, max Lv 150); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It restores HP or MP.
- MP: `(hasGemCart(1007) ? 200 : 300)` (conditional variants below).

**Cost, timing and range**

- **MP cost** (`baseMp` in `OnInitialize`): `(hasGemCart(1007) ? 200 : 300)`
- **MP cost** (`costMp` in `CheckHealStock`): `0` = 0
  - when `SkillIndividualFlag eq 1`
- **Cast time** (`CastTime`): `0` = 0
  - when `!hasGemCart(1026) AND SkillBufferDataBase.GetParam(20) ge ((hasGemCart(1007) ? 200 : 300) // 100) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND SkillBufferDataBase.GetParam(20) ge ((hasGemCart(1007) ? 200 : 300) // 100) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND SkillBufferDataBase.GetParam(20) ge ((hasGemCart(1007) ? 200 : 300) // 100) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 AND hasGemCart(1026)`
- **Cast time** (`CastTime`): `SkillUtil.CalcCastTime(1, PlayerStatusBase.get_BattleStatus())`
  - when `!hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND hasGemCart(1026)`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(24)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 8 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `CheckHealStock` — skill-specific method: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 237
- No proration slot: ExpType None: no proration slot.

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `0` = 0 _(when !hasGemCart(1026) AND SkillBufferDataBase.GetParam(20) ge ((hasGemCart(1007) ? 200 : 300) // 100) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND SkillBufferDataBase.GetParam(20) ge ((hasGemCart(1007) ? 200 : 300) // 100) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND SkillBufferDataBase.GetParam(20) ge ((hasGemCart(1007) ? 200 : 300) // 100) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 AND hasGemCart(1026))_; `SkillUtil.CalcCastTime(1, PlayerStatusBase.get_BattleStatus())` _(when !hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND hasGemCart(1026))_
- **HP healed** (`hpHeal`): `(((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300)) - int((((((GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) + (GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) << 2)) << 1) * -0.01) + 1) * ((((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300)) lt 0 ? (((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300)) + 1) : ((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300))) >> 1))))` _(when GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) eq 0 AND hasGemCart(1026))_; `(((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300)) - ((((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300)) lt 0 ? (((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300)) + 1) : ((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300))) >> 1))` _(when GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 AND hasGemCart(1026) OR GemCartBufferManager.GetBufferLevel(PlayerStatusBase.get_GemCartBuffManager(), 71) lt 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) eq 0 AND hasGemCart(1026))_; `((((Lv + 10) * status.MaxHp) // 100) + (Lv * 300))` _(when !hasGemCart(1026) OR !hasGemCart(1026) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) ne 0 OR !hasGemCart(1026) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 23) eq 0)_
- **Base MP cost** (`baseMp`): `(hasGemCart(1007) ? 200 : 300)`
- **MP cost** (`costMp`): `0` = 0 _(when SkillIndividualFlag eq 1)_

_Raw recovered data (every method item): [trees/SupportSkill.md](../trees/SupportSkill.md) — uid 237_

---
