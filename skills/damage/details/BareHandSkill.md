# ベアハンドスキル (`BareHandSkill`) — skill details

12 entries.

### ความชำนาญการสู้มือเปล่า (BarehandMastery) · uid 1089

<img src="../../icons/sk_1089.png" width="40" alt="icon"> 
**Tree:** ベアハンドスキル (`BareHandSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 1 · **Weapons:** Hand, SubWeaponExclusion · **Flags:** NoMarketSearch · **Client class:** `BarehandMastery` (passive mastery)

> สามารถใช้ได้เมื่อทั้งเมนและซับเป็นมือเปล่าเท่านั้น
> แก่นแท้ของมือเปล่า
> จะได้รับ ATK อาวุธตามเลเวลของตัวเอง
> และเพิ่มขีดจำกัดให้ชี่กง

**How it works**

- Mastery skill of the ベアハンドスキル tree (tier 1, max Lv 1); usable with Hand, SubWeaponExclusion.
- It installs a buff on the caster.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Buffs:
  - `TakeQigongBuf`: lasts `600` s
- Passive modifiers (negative = penalty): EqAtkRate (weapon ATK %) 10 at Lv1 to 100 at Lv10.
- Its effect is applied by client code: `Revival$$CheckRevival`, `Revival$$OnActionMobDamage` (formulas in the last section).
- Other client code reads this skill (2 lookups; see the last section).

**Buff values** (every recovered field; durations in seconds)

**Buff `TakeQigongBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `GetUseQigongNum`, `UpdateQigongNum`, `get_TakeQigongNum`, `set_TakeQigongNum`
- Duration: `600` s
- `Value` = `Max` _(when BuffEffectActive ne 0)_
- `Count` = `Count` _(when BuffEffectActive ne 0)_
- Hook `set_TakeQigongNum`: `takeQigongNum`=value; `Count`=value; `LeftTime`=600; `LeftTime`=0
- Hook `Updata`: `LeftTime`=0; `Count`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
- Hook `UpdateQigongNum`: `Count`=takeQigongNum; `LeftTime`=600; `LeftTime`=0

Parameter meanings (inferred from the `SkillBufferId` names):

- `Count`: stack / hit counter
- `Value`: generic value (meaning set by the code that reads the buff)

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| EqAtkRate | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |


Bonus meanings (inferred from the names):

- `EqAtkRate`: weapon ATK %

**Where else this skill takes effect**

- Effect applied in `Revival$$CheckRevival` (3 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 1089, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `(TakeQigongBuf.GetUseQigongNum(TryGetBuf.out2(), 0, ?x2, ?x3) gt 0 ? 1 : 0)`
    - calls `TakeQigongBuf$$GetUseQigongNum`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1089, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1089, stkp(-24), 0) & 1) eq 0`
    - returns `0`
- Effect applied in `Revival$$OnActionMobDamage` (236 guarded paths, truncated):
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `CollectQigongBuf.UpdateQigongNum(TryGetBuf.out2(), Toram.Common.Actions.ActionAppendData.Get(appendData, 1093, 0, ?x3), 0, ?x3)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1090, stkp(-56), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.AddSelfBuffer(CharacterActionManagerBase.get_IsValid(), 1089, [[TryGetValue.out2()+0x10]+0x18], ((([[TryGetValue.out2()+0x10]+0x18] + ([[TryGetValue.out2()+0x10]+0x18] << 2)) << 1) + 10))`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `CollectQigongBuf.UpdateQigongNum(TryGetBuf.out2(), Toram.Common.Actions.ActionAppendData.Get(appendData, 1093, 0, ?x3), 0, ?x3)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1090, stkp(-56), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.AddSelfBuffer(CharacterActionManagerBase.get_IsValid(), 1089, [[TryGetValue.out2()+0x10]+0x18], ((([[TryGetValue.out2()+0x10]+0x18] + ([[TryGetValue.out2()+0x10]+0x18] << 2)) << 1) + ?blr))`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `CollectQigongBuf.UpdateQigongNum(TryGetBuf.out2(), Toram.Common.Actions.ActionAppendData.Get(appendData, 1093, 0, ?x3), 0, ?x3)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1090, stkp(-56), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
- Code that reads this skill's level / buff by constant id: `Revival$$CheckRevival (TryGetBuf)`, `Revival$$OnActionMobDamage (TryGetBuf)`

_Raw recovered data (every method item): [trees/BareHandSkill.md](../trees/BareHandSkill.md) — uid 1089_

---

### ชาร์จพลังชี่กง (CollectQigong) · uid 1090

<img src="../../icons/sk_1090.png" width="40" alt="icon"> 
**Tree:** ベアハンドスキル (`BareHandSkill`, tier 1) · **Type:** Buffer · **Max Lv:** 1 · **Weapons:** Hand, SubWeaponExclusion · **Flags:** NoMarketSearch · **Client class:** `CollectQigongAction`

> สามารถใช้ได้เมื่อทั้งเมนและซับเป็นมือเปล่าเท่านั้น
> ใช้ MP ทั้งหมดเพื่อสะสมชี่กง
> เพิ่ม ATK ตามการสะสมชี่กงเป็นเวลา 180 วินาที
> ความเสถียรจะเพิ่มขึ้นโดยไม่เกี่ยวข้องกับจำนวนชี่กง

**How it works**

- Buffer skill of the ベアハンドスキル tree (tier 1, max Lv 1); usable with Hand, SubWeaponExclusion.
- It installs a buff on the caster.
- MP: `((PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) gt 100 ? (PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) : 100)` (conditional variants below).
- Buffs:
  - `CollectQigongBuf`: lasts `180` s; Lv1 → Lv10: Stable (stability) 5 → 50
- Other client code reads this skill (2 lookups; see the last section).

**Cost, timing and range**

- **MP cost** (`mp` in `calcCostMp`): `((PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) gt 100 ? (PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) : 100)`
- **MP cost** (`costMp` in `calcCostMp`): `((PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) gt 100 ? (PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) : 100)`
- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `calcCostMp` — skill-specific method: 2 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1090
- No proration slot: ExpType None: no proration slot.

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`
- **MP cost** (`mp`): `((PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) gt 100 ? (PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) : 100)`
- **MP cost** (`costMp`): `((PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) gt 100 ? (PlayerAttackBase.CalcCostMp(this, playerAction) lt 2000 ? PlayerAttackBase.CalcCostMp(this, playerAction) : 2000) : 100)`

**Buff values** (every recovered field; durations in seconds)

**Buff `CollectQigongBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `UpdateQigongNum`
- Duration: `180` s
- `AtkUp` = `(((((takeNum) * Lv) * Lv) * Lv) // 100)` _(when BuffEffectActive ne 0)_
- `Stable` = `0` _(when BuffEffectActive ne 0; Count lt 1)_
- `Count` = `(takeNum)` _(when BuffEffectActive ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Stable | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |

- Buff fields set in the constructor (all recovered):
  - `Count` = `takeNum`
  - `Max` = `10` = 10
  - `startTime` = `UnityEngine.Time.get_realtimeSinceStartup()`
- Hook `Updata`: `LeftTime`=((startTime - UnityEngine.Time.get_realtimeSinceStartup()) + 180); `LeftTime`=0
- Hook `UpdateQigongNum`: `Count`=nowNum

Parameter meanings (inferred from the `SkillBufferId` names):

- `AtkUp`: ATK +
- `Count`: stack / hit counter
- `Stable`: stability

**Where else this skill takes effect**

- Effect applied in `PlayerSecondaryStatus$$get_AtkMpRecovery` (293 guarded paths, truncated):
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
- Effect applied in `Revival$$OnActionMobDamage` (190 guarded paths, truncated):
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `CollectQigongBuf.UpdateQigongNum(TryGetBuf.out2(), Toram.Common.Actions.ActionAppendData.Get(appendData, 1093, 0, ?x3), 0, ?x3)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1090, stkp(-56), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `CollectQigongBuf.UpdateQigongNum(TryGetBuf.out2(), Toram.Common.Actions.ActionAppendData.Get(appendData, 1093, 0, ?x3), 0, ?x3)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1090, stkp(-56), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `CollectQigongBuf.UpdateQigongNum(TryGetBuf.out2(), Toram.Common.Actions.ActionAppendData.Get(appendData, 1093, 0, ?x3), 0, ?x3)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1090, stkp(-56), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `CollectQigongBuf.UpdateQigongNum(TryGetBuf.out2(), Toram.Common.Actions.ActionAppendData.Get(appendData, 1093, 0, ?x3), 0, ?x3)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1090, stkp(-56), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
- Code that reads this skill's level / buff by constant id: `PlayerSecondaryStatus$$get_AtkMpRecovery (TryGetBuf)`, `Revival$$OnActionMobDamage (TryGetBuf)`

_Raw recovered data (every method item): [trees/BareHandSkill.md](../trees/BareHandSkill.md) — uid 1090_

---

### ซีซ่าแสลชเชอร์ (FuriousEfforts) · uid 1091

<img src="../../icons/sk_1091.png" width="40" alt="icon"> 
**Tree:** ベアハンドスキル (`BareHandSkill`, tier 1) · **Type:** Buffer · **Max Lv:** 1 · **Weapons:** Hand, SubWeaponExclusion · **Requires:** ชาร์จพลังชี่กง · **Flags:** NoMarketSearch · **Client class:** `FuriousEffortsAction`

> สามารถใช้ได้เมื่อทั้งเมนและซับเป็นมือเปล่าเท่านั้น
> ใช้ชี่กง 30 วินาที
> เพื่อเพิ่มการโจมตีปกติ และอัตราคริติคอล
> แต่ต้องแลกกับการสูญเสียความเร็วการโจมตีจำนวนมาก
> ถ้าใช้สกิลชี่กงอื่นผลจะสิ้นสุดลงทันที 

**How it works**

- Buffer skill of the ベアハンドスキル tree (tier 1, max Lv 1); usable with Hand, SubWeaponExclusion.
- It installs a buff on the caster.
- Its buff raises normal-attack damage (`NormalAttackRate` / `NormalAttackConstantDamage`).
- Buffs:
  - `FuriousEffortsBuf`: lasts `30` s; Lv1 → Lv10: Aspd (attack speed +) -2850 → -2850
  - `CountBufferBase`
- Other client code reads this skill (11 lookups; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionStart` — when the cast starts: 2 set
- `ActionSkillEvent` — on an animation/skill event during the motion: 3 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1091
- No proration slot: ExpType None: no proration slot.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `TakeQigongBuf.GetUseQigongNum(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1089])`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Buffs and effects it installs or removes**

- `ActionSkillEvent` (on an animation/skill event during the motion): constructs `FuriousEffortsBuf` — `.ctor(Lv, useQigongNum, PlayerActionManagerBase.get_PlayerStatus())`
  - when `IsInstanceOf(actarAction, OtherPlayerActionManager) eq 1 AND useQigongNum ge 1 OR IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1091) AND useQigongNum ge 1 OR !hasBuff(1091) AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) AND useQigongNum ge 1`
- `ActionSkillEvent` (on an animation/skill event during the motion): adds the caster's buff of `new FuriousEffortsBuf` — `AddSelfBuffer(new FuriousEffortsBuf, Id)`
  - when `IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1091) AND useQigongNum ge 1 OR !hasBuff(1091) AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) AND useQigongNum ge 1`
- `ActionSkillEvent` (on an animation/skill event during the motion): constructs `FuriousEffortsBuf` — `.ctor(Lv, useQigongNum, 0)`
  - when `IsInstanceOf(actarAction, MobaOtherPlayerActionManager) eq 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND useQigongNum ge 1`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`
- **Loop / hit-repeat count** (`LoopParam`): `TakeQigongBuf.GetUseQigongNum(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1089])` _(when UnityEngine.Object.op_Inequality(actarAction))_

**Buff values** (every recovered field; durations in seconds)

**Buff `FuriousEffortsBuf`**
- **Boosts normal-attack damage** through the `NormalAttackRate` / `NormalAttackConstantDamage` parameters.
- Buff hook methods: `get_BufEffectTakeId`
- Duration: `30` s
- `NormalAttackRate` = `(((SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) + (Lv << 1))) * (useNum))`
- `NormalAttackConstantDamage` = `(((useNum) * Lv) + (((useNum) * Lv) << 2))`
- `Count` = `(useNum)`
- `CrtUp` = `((useNum) * Lv)`

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Aspd | -2850 | -2850 | -2850 | -2850 | -2850 | -2850 | -2850 | -2850 | -2850 | -2850 |

- Buff fields set in the constructor (all recovered):
  - `Count` = `useNum`
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `normalAttackDamageUpRate` = `(SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate) + (Lv << 1))`
  - `normalAttackDamageUpRate` = `(Lv << 1)` = 2
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:FuriousEffortsBuf$$.ctor<-FuriousEffortsAction$$ActionSkillEvent` (no direct constructor call in the skill's own code).
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

- `Aspd`: attack speed +
- `Count`: stack / hit counter
- `CrtUp`: critical rate +
- `NormalAttackConstantDamage`: normal-attack flat damage
- `NormalAttackRate`: normal-attack damage multiplier (%)

**Where else this skill takes effect**

- Effect applied in `EnemyMobActionManagerBase$$Damaged` (300 guarded paths, truncated):
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
- Effect applied in `ScoreAttackBossActionManager$$Damaged` (300 guarded paths, truncated):
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
- Effect applied in `BCollaboBossActionManager$$Damaged` (300 guarded paths, truncated):
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
- Effect applied in `GuildRaidBossMobActionManager$$Damaged` (300 guarded paths, truncated):
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
- Effect applied in `EarthShatteringAction$$ActionStart` (8 guarded paths):
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `(((LoopParam | 2) | 4) | 1)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `((LoopParam | 2) | 4)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `((LoopParam | 2) | 1)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `(LoopParam | 2)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `((LoopParam | 4) | 1)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `(LoopParam | 4)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `(LoopParam | 1)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - calls `PlayerAttackBase$$ActionStart`
- Effect applied in `EarthShatteringBuf$$GetBufferEffectAppendParameter` (2 guarded paths):
  - when `otherPlayer eq 0`
    - returns `0x165db78(meta(0x397a3b8, System.Collections.Generic.Dictionary<TakeParameterType, int>_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `virtual CharacterActionManagerBase.get_IsValid`, `0x165db78`
  - when `otherPlayer eq 0`
    - returns `0x165db78(meta(0x397a3b8, System.Collections.Generic.Dictionary<TakeParameterType, int>_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.get_IsValid`, `0x165db78`
- Effect applied in `FuriousEffortsExtreme$$Damaged` (4 guarded paths):
  - when `TryGetValue.out2() ne 0` AND `(hitType & 2) ne 0`
    - returns `?blr`
    - calls `0x165db78`, `FuriousEffortsExtremeBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
  - when `TryGetValue.out2() ne 0` AND `(hitType & 2) ne 0`
    - returns `?blr`
  - when `TryGetValue.out2() ne 0` AND `(hitType & 2) ne 0`
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1091, 0, ?x3)`
  - when `TryGetValue.out2() ne 0` AND `(hitType & 2) eq 0`
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1091, 0, ?x3)`
- Effect applied in `SelfDisclosure$$UpdateCristaBonus` (3 guarded paths):
  - always
    - calls `PlayerDataManager$$get_SkillBufferManager`, `PlayerDataManager$$get_SkillBufferManager`, `PlayerDataManager$$get_SkillBufferManager`, `SelfDisclosure$$SetCristBonus`
  - always
    - calls `PlayerDataManager$$get_SkillBufferManager`, `PlayerDataManager$$get_SkillBufferManager`, `SelfDisclosure$$SetCristBonus`
  - always
    - calls `PlayerDataManager$$get_SkillBufferManager`, `SelfDisclosure$$SetCristBonus`
- Effect applied in `Revival$$OnActionMobDamage` (300 guarded paths, truncated):
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `CollectQigongBuf.UpdateQigongNum(TryGetBuf.out2(), Toram.Common.Actions.ActionAppendData.Get(appendData, 1093, 0, ?x3), 0, ?x3)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1090, stkp(-56), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.AddSelfBuffer(CharacterActionManagerBase.get_IsValid(), 1089, [[TryGetValue.out2()+0x10]+0x18], ((([[TryGetValue.out2()+0x10]+0x18] + ([[TryGetValue.out2()+0x10]+0x18] << 2)) << 1) + 10))`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `CollectQigongBuf.UpdateQigongNum(TryGetBuf.out2(), Toram.Common.Actions.ActionAppendData.Get(appendData, 1093, 0, ?x3), 0, ?x3)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1090, stkp(-56), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.AddSelfBuffer(CharacterActionManagerBase.get_IsValid(), 1089, [[TryGetValue.out2()+0x10]+0x18], ((([[TryGetValue.out2()+0x10]+0x18] + ([[TryGetValue.out2()+0x10]+0x18] << 2)) << 1) + ?blr))`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `CollectQigongBuf.UpdateQigongNum(TryGetBuf.out2(), Toram.Common.Actions.ActionAppendData.Get(appendData, 1093, 0, ?x3), 0, ?x3)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1090, stkp(-56), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
- Code that reads this skill's level / buff by constant id: `BCollaboBossActionManager$$Damaged (ContainsBuffer)`, `EarthShatteringAction$$ActionSkillEvent (TryGetBuf)`, `EarthShatteringAction$$ActionStart (ContainsBuffer)`, `EarthShatteringBuf$$GetBufferEffectAppendParameter (ContainsBuffer)`, `EnemyMobActionManagerBase$$Damaged (ContainsBuffer)`, `FuriousEffortsAction$$ActionSkillEvent (ContainsBuffer)`, `FuriousEffortsExtreme$$Damaged (ContainsBuffer)`, `GuildRaidBossMobActionManager$$Damaged (ContainsBuffer)`, `Revival$$OnActionMobDamage (TryGetBuf)`, `ScoreAttackBossActionManager$$Damaged (ContainsBuffer)`, `SelfDisclosure$$UpdateCristaBonus (ContainsBuffer)`

_Raw recovered data (every method item): [trees/BareHandSkill.md](../trees/BareHandSkill.md) — uid 1091_

---

### วายุโหมคลื่นกระหน่ำ (StormAndUrge) · uid 1092

<img src="../../icons/sk_1092.png" width="40" alt="icon"> 
**Tree:** ベアハンドスキル (`BareHandSkill`, tier 1) · **Type:** Buffer · **Max Lv:** 1 · **Weapons:** Hand, SubWeaponExclusion · **Requires:** ชาร์จพลังชี่กง · **Flags:** NoMarketSearch · **Client class:** `StormAndUrgeAction`

> สามารถใช้ได้เมื่อทั้งเมนและซับเป็นมือเปล่าเท่านั้น
> ใช้ชี่กง 30 วินาทีเพื่อเพิ่มความแม่น, ความเร็วการโจมตี
> ความเร็วในการเคลื่อนย้าย 
> ถ้าใช้สกิลชี่กงอื่นผลจะสิ้นสุดลงทันที

**How it works**

- Buffer skill of the ベアハンドスキル tree (tier 1, max Lv 1); usable with Hand, SubWeaponExclusion.
- It installs a buff on the caster.
- Buffs:
  - `StormAndUrgeBuf`: lasts `30` s; Lv1 → Lv10: Value (generic value (meaning set by the code that reads the buff)) 50 → 50
- Other client code reads this skill (8 lookups; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionStart` — when the cast starts: 2 set
- `ActionSkillEvent` — on an animation/skill event during the motion: 2 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1092
- No proration slot: ExpType None: no proration slot.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `TakeQigongBuf.GetUseQigongNum(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1089])`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Buffs and effects it installs or removes**

- `ActionSkillEvent` (on an animation/skill event during the motion): adds the caster's buff of skill 1092 (StormAndUrge) — `AddSelfBuffer(1092, Lv, 0)`
  - when `IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1096, 1) lt 1 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1092) AND useQigongNum ge 1 OR !hasBuff(1092) AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1096, 1) lt 1 AND UnityEngine.Object.op_Inequality(actarAction) AND useQigongNum ge 1 OR IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction.battleManager, PlayerBattleManager) eq 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1096, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1092) AND useQigongNum ge 1`
- `ActionSkillEvent` (on an animation/skill event during the motion): adds the caster's buff of skill 1096 (StormAndUrgeExtreme) — `AddSelfBuffer(1096, SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1096, 1), Id)`
  - when `IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction.battleManager, PlayerBattleManager) eq 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1096, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1092) AND useQigongNum ge 1 OR !hasBuff(1092) AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction.battleManager, PlayerBattleManager) eq 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1096, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND useQigongNum ge 1 OR IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction.battleManager, MobaPlayerBattleManager) eq 1 AND IsInstanceOf(actarAction.battleManager, PlayerBattleManager) ne 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1096, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1092) AND useQigongNum ge 1`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`
- **Loop / hit-repeat count** (`LoopParam`): `TakeQigongBuf.GetUseQigongNum(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1089])` _(when UnityEngine.Object.op_Inequality(actarAction))_

**Buff values** (every recovered field; durations in seconds)

**Buff `StormAndUrgeBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`
- Duration: `30` s
- `HitUp` = `(((useNum) * Lv) * Lv)`
- `Aspd` = `(((useNum) * Lv) * 100)`
- `AttackMprecoveryUp` = `int((((useNum) * Lv) * 0.2))`
- `Count` = `(useNum)`

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 50 | 50 | 50 | 50 | 50 | 50 | 50 | 50 | 50 | 50 |

- Buff fields set in the constructor (all recovered):
  - `moveSpeed` = `50` = 50
  - `Count` = `useNum`
  - `playerDataManager` = `PlayerDataManager.GetPlayerDataManager()`
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

Parameter meanings (inferred from the `SkillBufferId` names):

- `Aspd`: attack speed +
- `AttackMprecoveryUp`: MP recovered per attack (flat)
- `Count`: stack / hit counter
- `HitUp`: accuracy +
- `Value`: generic value (meaning set by the code that reads the buff)

**Where else this skill takes effect**

- Effect applied in `MobaPlayerActionManager$$get_MoveSpeed` (16 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1223, 0, ?x3)`
    - calls `AbnormalStateManager$$Contains`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaRoomData$$get_NowGamePhase`, `PlayerActionManagerBase$$get_IsBattleActive`, `SkillBufferManager$$GetSkillBuffer`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `AbnormalStateManager$$Contains`
  - when `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `AbnormalStateManager.Contains(?blr, 11, 0, ?x3)`
    - calls `AbnormalStateManager$$Contains`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaRoomData$$get_NowGamePhase`, `PlayerActionManagerBase$$get_IsBattleActive`, `SkillBufferManager$$GetSkillBuffer`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `AbnormalStateManager$$Contains`
  - when `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1223, 0, ?x3)`
    - calls `AbnormalStateManager$$Contains`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaRoomData$$get_NowGamePhase`, `PlayerActionManagerBase$$get_IsBattleActive`, `AbnormalStateManager$$Contains`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`
  - when `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `AbnormalStateManager.Contains(?blr, 11, 0, ?x3)`
    - calls `AbnormalStateManager$$Contains`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaRoomData$$get_NowGamePhase`, `PlayerActionManagerBase$$get_IsBattleActive`, `AbnormalStateManager$$Contains`
  - when `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 878, stkp(-24), 0) & 1) eq 0`
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1223, 0, ?x3)`
    - calls `AbnormalStateManager$$Contains`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaRoomData$$get_NowGamePhase`, `PlayerActionManagerBase$$get_IsBattleActive`, `SkillBufferManager$$GetSkillBuffer`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `AbnormalStateManager$$Contains`
  - when `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 878, stkp(-24), 0) & 1) eq 0`
    - returns `AbnormalStateManager.Contains(?blr, 11, 0, ?x3)`
    - calls `AbnormalStateManager$$Contains`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaRoomData$$get_NowGamePhase`, `PlayerActionManagerBase$$get_IsBattleActive`, `SkillBufferManager$$GetSkillBuffer`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `AbnormalStateManager$$Contains`
  - when `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 878, stkp(-24), 0) & 1) eq 0`
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1223, 0, ?x3)`
    - calls `AbnormalStateManager$$Contains`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaRoomData$$get_NowGamePhase`, `PlayerActionManagerBase$$get_IsBattleActive`, `AbnormalStateManager$$Contains`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`
  - when `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 878, stkp(-24), 0) & 1) eq 0`
    - returns `AbnormalStateManager.Contains(?blr, 11, 0, ?x3)`
    - calls `AbnormalStateManager$$Contains`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaRoomData$$get_NowGamePhase`, `PlayerActionManagerBase$$get_IsBattleActive`, `AbnormalStateManager$$Contains`
- Effect applied in `PlayerActionManager$$get_MoveSpeed` (16 guarded paths):
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
  - always
    - returns `AbnormalStateManager.Contains(?blr, 11, 0, ?x3)`
    - calls `AbnormalStateManager$$Contains`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `PlayerActionManagerBase$$get_IsBattleActive`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 706, 0, ?x3)`
    - calls `AbnormalStateManager$$Contains`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `PlayerActionManagerBase$$get_IsBattleActive`
  - always
    - returns `AbnormalStateManager.Contains(?blr, 11, 0, ?x3)`
    - calls `AbnormalStateManager$$Contains`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `PlayerActionManagerBase$$get_IsBattleActive`
- Effect applied in `EarthShatteringAction$$ActionStart` (8 guarded paths):
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `(((LoopParam | 2) | 4) | 1)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `((LoopParam | 2) | 4)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `((LoopParam | 2) | 1)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `(LoopParam | 2)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `((LoopParam | 4) | 1)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `(LoopParam | 4)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `(LoopParam | 1)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - calls `PlayerAttackBase$$ActionStart`
- Effect applied in `SelfDisclosure$$UpdateCristaBonus` (2 guarded paths):
  - always
    - calls `PlayerDataManager$$get_SkillBufferManager`, `PlayerDataManager$$get_SkillBufferManager`, `PlayerDataManager$$get_SkillBufferManager`, `SelfDisclosure$$SetCristBonus`
  - always
    - calls `PlayerDataManager$$get_SkillBufferManager`, `PlayerDataManager$$get_SkillBufferManager`, `SelfDisclosure$$SetCristBonus`
- Effect applied in `Revival$$OnActionMobDamage` (219 guarded paths, truncated):
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `CollectQigongBuf.UpdateQigongNum(TryGetBuf.out2(), Toram.Common.Actions.ActionAppendData.Get(appendData, 1093, 0, ?x3), 0, ?x3)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1090, stkp(-56), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.AddSelfBuffer(CharacterActionManagerBase.get_IsValid(), 1089, [[TryGetValue.out2()+0x10]+0x18], ((([[TryGetValue.out2()+0x10]+0x18] + ([[TryGetValue.out2()+0x10]+0x18] << 2)) << 1) + 10))`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `CollectQigongBuf.UpdateQigongNum(TryGetBuf.out2(), Toram.Common.Actions.ActionAppendData.Get(appendData, 1093, 0, ?x3), 0, ?x3)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1090, stkp(-56), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.AddSelfBuffer(CharacterActionManagerBase.get_IsValid(), 1089, [[TryGetValue.out2()+0x10]+0x18], ((([[TryGetValue.out2()+0x10]+0x18] + ([[TryGetValue.out2()+0x10]+0x18] << 2)) << 1) + ?blr))`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `CollectQigongBuf.UpdateQigongNum(TryGetBuf.out2(), Toram.Common.Actions.ActionAppendData.Get(appendData, 1093, 0, ?x3), 0, ?x3)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
  - when `(CharacterActionManagerBase.get_IsDead() & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1091, stkp(-56), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1092, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1090, stkp(-56), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerActionManager`, `virtual CharacterActionManagerBase.get_IsDead`, `PlayerDataManager$$get_PlayerStatus`, `Toram.Common.Actions.ActionAppendData$$Get`, `Toram.Common.Actions.ActionAppendData$$Get`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `0x165db78`
- Code that reads this skill's level / buff by constant id: `EarthShatteringAction$$ActionSkillEvent (TryGetBuf)`, `EarthShatteringAction$$ActionStart (ContainsBuffer)`, `EarthShatteringBuf$$GetBufferEffectAppendParameter (ContainsBuffer)`, `MobaPlayerActionManager$$get_MoveSpeed (ContainsBuffer)`, `PlayerActionManager$$get_MoveSpeed (ContainsBuffer)`, `Revival$$OnActionMobDamage (TryGetBuf)`, `SelfDisclosure$$UpdateCristaBonus (ContainsBuffer)`, `StormAndUrgeAction$$ActionSkillEvent (ContainsBuffer)`

_Raw recovered data (every method item): [trees/BareHandSkill.md](../trees/BareHandSkill.md) — uid 1092_

---

### ชี่กงฟื้นฟู (HealQigong) · uid 1093

<img src="../../icons/sk_1093.png" width="40" alt="icon"> 
**Tree:** ベアハンドスキル (`BareHandSkill`, tier 1) · **Type:** Buffer · **Max Lv:** 1 · **Weapons:** Hand, SubWeaponExclusion · **Requires:** ชาร์จพลังชี่กง · **Flags:** NoMarketSearch · **Client class:** `HealQigongAction`

> สามารถใช้ได้เมื่อทั้งเมนและซับเป็นมือเปล่าเท่านั้น
> ใช้ชี่กงเพื่อเพิ่มการฟื้นฟู HP อย่างต่อเนื่องชั่วขณะ
> เมื่อถูกโจมตีจะใช้ชี่กงเพื่อลดความเสียหายให้เบาลง
> ระหว่างติดผลพลังการโจมตีจะลดลง ความเสียหายจากพิษจะแรงขึ้น
> ถ้าใช้สกิลชี่กงอื่นผลจะสิ้นสุดลงทันที

**How it works**

- Buffer skill of the ベアハンドスキル tree (tier 1, max Lv 1); usable with Hand, SubWeaponExclusion.
- It installs a buff on the caster.
- Buffs:
  - `HealQigongBuf`; Lv1 → Lv10: AtkUpRate (ATK %) -98 → -75
  - `CountBufferBase`
- Other client code reads this skill (8 lookups; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionStart` — when the cast starts: 2 set
- `ActionSkillEvent` — on an animation/skill event during the motion: 3 call
- `EndByOtherBarehandBuf` — skill-specific method: 3 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1093
- No proration slot: ExpType None: no proration slot.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `TakeQigongBuf.GetUseQigongNum(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1089])`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Buffs and effects it installs or removes**

- `ActionSkillEvent` (on an animation/skill event during the motion): constructs `HealQigongBuf` — `.ctor(Lv, useQigongNum, PlayerActionManagerBase.get_PlayerStatus())`
  - when `UnityEngine.Object.op_Implicit(actarAction) AND useQigongNum ge 1 OR !UnityEngine.Object.op_Implicit(actarAction) AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1093) AND useQigongNum ge 1 OR !UnityEngine.Object.op_Implicit(actarAction) AND !hasBuff(1093) AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) AND useQigongNum ge 1`
- `ActionSkillEvent` (on an animation/skill event during the motion): adds the caster's buff of `new HealQigongBuf` — `AddSelfBuffer(new HealQigongBuf, Id)`
  - when `!UnityEngine.Object.op_Implicit(actarAction) AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1093) AND useQigongNum ge 1 OR !UnityEngine.Object.op_Implicit(actarAction) AND !hasBuff(1093) AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) AND useQigongNum ge 1`
- `ActionSkillEvent` (on an animation/skill event during the motion): constructs `HealQigongBuf` — `.ctor(Lv, useQigongNum, 0)`
  - when `!UnityEngine.Object.op_Implicit(actarAction) AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) eq 1 AND useQigongNum ge 1`
- `EndByOtherBarehandBuf` (method): removes the caster's buff of skill 1098 (EarthShattering) — `RemoveSelfBuffer(1098)`
- `EndByOtherBarehandBuf` (method): removes the caster's buff of skill 1095 (FuriousEffortsExtreme) — `RemoveSelfBuffer(1095)`
- `EndByOtherBarehandBuf` (method): removes the caster's buff of skill 1096 (StormAndUrgeExtreme) — `RemoveSelfBuffer(1096)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`
- **Loop / hit-repeat count** (`LoopParam`): `TakeQigongBuf.GetUseQigongNum(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1089])` _(when UnityEngine.Object.op_Inequality(actarAction))_

**Buff values** (every recovered field; durations in seconds)

**Buff `HealQigongBuf`**
- Buff hook methods: `ApplyDamageCut`, `CheckCollisionOfFightingSpirit`, `CheckCutDamageByQigong`, `DamageFunction`, `get_BufEffectTakeId`, `get_IsCutDamage`, `set_IsCutDamage`
- `Percent` = `(SkillMasteryBase.GetMasteryParam(MasteryId.Percent))`
- `Count` = `Count`
- `MobLastDamageRateUnique` = `int((((Lv * 0.5) + 4.5) * Count))`

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| AtkUpRate | -98 | -95 | -93 | -90 | -88 | -85 | -83 | -80 | -78 | -75 |

- Buff fields set in the constructor (all recovered):
  - `status` = `status`
  - `percent` = `SkillMasteryBase.GetMasteryParam(MasteryId.Percent)`
- Hook `set_IsCutDamage`: `IsCutDamage`=(value & 1)
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `CheckCutDamageByQigong`: `IsCutDamage`=0
- Hook `ApplyDamageCut`: `IsCutDamage`=1
- Hook `DamageFunction`: `IsCutDamage`=0
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:HealQigongBuf$$.ctor<-HealQigongAction$$ActionSkillEvent` (no direct constructor call in the skill's own code).
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

- `AtkUpRate`: ATK %
- `Count`: stack / hit counter
- `MobLastDamageRateUnique`: final damage multiplier vs monsters (unique category)
- `Percent`: generic percent

**Where else this skill takes effect**

- Effect applied in `Revival$$CheckRevival` (4 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 1089, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `(TakeQigongBuf.GetUseQigongNum(TryGetBuf.out2(), 0, ?x2, ?x3) gt 0 ? 1 : 0)`
    - calls `TakeQigongBuf$$GetUseQigongNum`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1089, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1089, stkp(-24), 0) & 1) eq 0`
    - returns `0`
  - always
    - returns `0`
- Effect applied in `EarthShatteringAction$$ActionStart` (9 guarded paths):
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1093, 0, ?x3)`
    - set `LoopParam` = `(LoopParam | 8)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `(((LoopParam | 2) | 4) | 1)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `((LoopParam | 2) | 4)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `((LoopParam | 2) | 1)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `(LoopParam | 2)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `((LoopParam | 4) | 1)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `(LoopParam | 4)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `(LoopParam | 1)`
    - calls `PlayerAttackBase$$ActionStart`
- Effect applied in `FlashGrenadeAction$$ActionSkillEvent` (2 guarded paths):
  - when `param eq 200` AND `IsOtherPlayer eq 0`
    - calls `SkillActionBase$$ActionSkillEvent`, `UnityEngine.Component$$get_transform`, `UnityEngine.Component$$get_transform`, `EquipItemData$$get_SubWeaponItemType`, `interface IPlayerStatusCalculator.get_AntiVirus`, `AbnormalStateManager$$GetDefaultAnbormalStateTime`
  - when `param eq 200` AND `IsOtherPlayer eq 0`
    - calls `SkillActionBase$$ActionSkillEvent`, `UnityEngine.Component$$get_transform`, `UnityEngine.Component$$get_transform`, `EquipItemData$$get_SubWeaponItemType`, `AbnormalStateManager$$GetDefaultAnbormalStateTime`
- Effect applied in `FreezeGrenadeAction$$ActionSkillEvent` (2 guarded paths):
  - when `param eq 200` AND `IsOtherPlayer eq 0`
    - calls `SkillActionBase$$ActionSkillEvent`, `UnityEngine.Component$$get_transform`, `UnityEngine.Component$$get_transform`, `EquipItemData$$get_SubWeaponItemType`, `interface IPlayerStatusCalculator.get_AntiVirus`, `AbnormalStateManager$$GetDefaultAnbormalStateTime`
  - when `param eq 200` AND `IsOtherPlayer eq 0`
    - calls `SkillActionBase$$ActionSkillEvent`, `UnityEngine.Component$$get_transform`, `UnityEngine.Component$$get_transform`, `EquipItemData$$get_SubWeaponItemType`, `AbnormalStateManager$$GetDefaultAnbormalStateTime`
- Code that reads this skill's level / buff by constant id: `EarthShatteringAction$$ActionSkillEvent (ContainsBuffer)`, `EarthShatteringAction$$ActionStart (ContainsBuffer)`, `FlashGrenadeAction$$ActionSkillEvent (ContainsBuffer)`, `FreezeGrenadeAction$$ActionSkillEvent (ContainsBuffer)`, `HealQigongAction$$ActionSkillEvent (ContainsBuffer)`, `Revival$$CheckRevival (ContainsBuffer)`, `Revival$$OnActionMobDamage (GetSkillLv)`, `SelfDisclosure$$UpdateCristaBonus (ContainsBuffer)`

_Raw recovered data (every method item): [trees/BareHandSkill.md](../trees/BareHandSkill.md) — uid 1093_

---

### ชาร์จพลังชี่กงอัลติมา (CollectQigongExtreme) · uid 1094

<img src="../../icons/sk_1094.png" width="40" alt="icon"> 
**Tree:** ベアハンドスキル (`BareHandSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 100 · **Weapons:** Hand, SubWeaponExclusion · **Requires:** ชาร์จพลังชี่กง · **Flags:** NoMarketSearch · **Client class:** `CollectQigongExtreme` (passive mastery)

> ลดจำนวนการใช้ชี่กงเมื่อใช้สกิลอื่นนอกเหนือจากมือเปล่า
> และเพิ่มการฟื้นฟู MP การโจมตีขึ้นเล็กน้อย

**How it works**

- Mastery skill of the ベアハンドスキル tree (tier 2, max Lv 100); usable with Hand, SubWeaponExclusion.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Percent (generic percent) 1 at Lv1 to 10 at Lv10, Value (generic value) 0 at Lv1 to 5 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Percent | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| Value | 0 | 1 | 1 | 2 | 2 | 3 | 3 | 4 | 4 | 5 |


Bonus meanings (inferred from the names):

- `Percent`: generic percent
- `Value`: generic value

_Raw recovered data (every method item): [trees/BareHandSkill.md](../trees/BareHandSkill.md) — uid 1094_

---

### ซีซ่าแสลชเชอร์อัลติมา (FuriousEffortsExtreme) · uid 1095

<img src="../../icons/sk_1095.png" width="40" alt="icon"> 
**Tree:** ベアハンドスキル (`BareHandSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 100 · **Weapons:** Hand, SubWeaponExclusion · **Requires:** ซีซ่าแสลชเชอร์ · **Flags:** NoMarketSearch · **Client class:** `FuriousEffortsExtreme` (passive mastery)

> เพิ่มผลของซีซ่าแสลชเชอร์เพื่ออัพเกรดการโจมตีปกติ
> ถ้าติดคริติคอลระหว่างใช้ซีซ่าแสลชเชอร์
> ผลที่ช่วยอัพเกรดสกิลการโจมตีจะถูกสะสมไว้
> แต่ถ้าใช้างานชี่กงฟื้นฟูพลังจะหายไป

**How it works**

- Mastery skill of the ベアハンドスキル tree (tier 2, max Lv 100); usable with Hand, SubWeaponExclusion.
- It installs a buff on the caster.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Buffs:
  - `CountBufferBase`
  - `FuriousEffortsExtremeBuf`; Lv1 → Lv10: Value (generic value (meaning set by the code that reads the buff)) 5 → 10
- Passive modifiers (negative = penalty): SkillRate (skill multiplier bonus) 2 at Lv1 to 20 at Lv10.

**Buff values** (every recovered field; durations in seconds)

**Buff `CountBufferBase`**
- Attached to this skill via `caller2:FuriousEffortsExtremeBuf$$.ctor<-FuriousEffortsExtreme$$Damaged` (no direct constructor call in the skill's own code).
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
**Buff `FuriousEffortsExtremeBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `CalcLastDamageRate`

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 5 | 5 | 5 | 5 | 5 | 6 | 7 | 8 | 9 | 10 |

- Buff fields set in the constructor (all recovered):
  - `lastDamageRate` = `(Lv hi 5 ? Lv : 5)` → Lv1..10 [5, 5, 5, 5, 5, 6, 7, 8, 9, 10]
- Hook `CalcLastDamageRate`: `Count`=(Count - (Count lt 5 ? Count : 5))

Parameter meanings (inferred from the `SkillBufferId` names):

- `Count`: stack / hit counter
- `Value`: generic value (meaning set by the code that reads the buff)

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |


Bonus meanings (inferred from the names):

- `SkillRate`: skill multiplier bonus

_Raw recovered data (every method item): [trees/BareHandSkill.md](../trees/BareHandSkill.md) — uid 1095_

---

### วายุโหมคลื่นกระหน่ำอัลติมา (StormAndUrgeExtreme) · uid 1096

<img src="../../icons/sk_1096.png" width="40" alt="icon"> 
**Tree:** ベアハンドスキル (`BareHandSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 100 · **Weapons:** Hand, SubWeaponExclusion · **Requires:** วายุโหมคลื่นกระหน่ำ · **Flags:** NoMarketSearch · **Client class:** `StormAndUrgeExtreme` (passive mastery)

> เมื่อใช้วายุโหมคลื่นกระหน่ำจะมีโอกาสช่วยเพิ่ม
> อาวุธเจาะเข้าและโจมตีระยะประชิดเพิ่มมากขึ้น
> ผลจะสิ้นสุดลงถ้าใช้สกิลอื่นที่ไม่ใช่มือเปล่า
> แต่จะลด MP ที่ใช้ลงครึ่งหนึ่ง
> และถ้าใช้ชี่กงฟื้นฟูผลก็จะหายไปเช่นกัน

**How it works**

- Mastery skill of the ベアハンドスキル tree (tier 2, max Lv 100); usable with Hand, SubWeaponExclusion.
- It installs a buff on the caster.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Buffs:
  - `StormAndUrgeExtremeBuf`; Lv1 → Lv10: Percent (generic percent) 2 → 20, PowerResistBreaker (physical pierce) 200 → 2000, Value (generic value (meaning set by the code that reads the buff)) 200 → 2000
- Other client code reads this skill (2 lookups; see the last section).

**Buff values** (every recovered field; durations in seconds)

**Buff `StormAndUrgeExtremeBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Percent | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |
| PowerResistBreaker | 200 | 400 | 600 | 800 | 1000 | 1200 | 1400 | 1600 | 1800 | 2000 |
| Value | 200 | 400 | 600 | 800 | 1000 | 1200 | 1400 | 1600 | 1800 | 2000 |

- Buff fields set in the constructor (all recovered):
  - `temporaryCount` = `-1` = -1
  - `percent` = `(Lv << 1)` → Lv1..10 [2, 4, 6, 8, 10, 12, 14, 16, 18, 20]
  - `powerResistBreaker` = `(Lv * 200)` → Lv1..10 [200, 400, 600, 800, 1000, 1200, 1400, 1600, 1800, 2000]
  - `avoidStackHeal` = `(Lv * 200)` → Lv1..10 [200, 400, 600, 800, 1000, 1200, 1400, 1600, 1800, 2000]

Parameter meanings (inferred from the `SkillBufferId` names):

- `Percent`: generic percent
- `PowerResistBreaker`: physical pierce
- `Value`: generic value (meaning set by the code that reads the buff)

**Where else this skill takes effect**

- Code that reads this skill's level / buff by constant id: `PlayerAttackBase$$CalcCostMp (ContainsBuffer)`, `StormAndUrgeAction$$ActionSkillEvent (GetSkillLv)`

_Raw recovered data (every method item): [trees/BareHandSkill.md](../trees/BareHandSkill.md) — uid 1096_

---

### การปะทะของจิตวิญญาณ (CollisionOfFightingSpirit) · uid 1097

<img src="../../icons/sk_1097.png" width="40" alt="icon"> 
**Tree:** ベアハンドスキル (`BareHandSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 100 · **Weapons:** Hand, SubWeaponExclusion · **Requires:** ชี่กงฟื้นฟู · **Flags:** NoMarketSearch · **Client class:** `CollisionOfFightingSpirit` (passive mastery)

> ใช้ได้เฉพาะตอนไม่ได้ติดตั้งอาวุธหลักหรืออาวุธเสริม
> เมื่อทิศทางของเฮทระหว่างคุณและเป้าหมายตรงกัน
> ความเสียหายที่ได้รับจากเป้าหมายจะลดลง
> มีโอกาสในการป้องกันการใช้ชี่กง
> ถ้าได้รับความเสียหายระหว่างใช้ชี่กงฟื้นฟู

**How it works**

- Mastery skill of the ベアハンドスキル tree (tier 2, max Lv 100); usable with Hand, SubWeaponExclusion.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): LastDmgRate (final damage dealt %) 1 at Lv1 to 10 at Lv10, Percent (generic percent) 2 at Lv1 to 25 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| LastDmgRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| Percent | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |


Bonus meanings (inferred from the names):

- `LastDmgRate`: final damage dealt %
- `Percent`: generic percent

_Raw recovered data (every method item): [trees/BareHandSkill.md](../trees/BareHandSkill.md) — uid 1097_

---

### สะเทือนโลกา (EarthShattering) · uid 1098

<img src="../../icons/sk_1098.png" width="40" alt="icon"> 
**Tree:** ベアハンドスキル (`BareHandSkill`, tier 3) · **Type:** Buffer · **Max Lv:** 250 · **Weapons:** Hand, SubWeaponExclusion · **Flags:** NoMarketSearch · **Client class:** `EarthShatteringAction`

> สามารถใช้ได้ต่อเมื่อทั้งอาวุธหลักและเสริมเป็นมือเปล่าเท่านั้น
> สกิลนี้จะได้รับบาเรียตามจำนวนชี่กงที่สะสม
> ธาตุที่ได้เปรียบ อาวุธเจาะเข้า ความเสถียรทั้งหมดจะเพิ่มขึ้น
> ผลจะสิ้นสุดลงเมื่อใช้ชี่กงฟื้นฟู

**How it works**

- Buffer skill of the ベアハンドスキル tree (tier 3, max Lv 250); usable with Hand, SubWeaponExclusion.
- It installs a buff on the caster.
- Buffs:
  - `EarthShatteringBuf`; Lv1 → Lv10: PowerResistBreaker (physical pierce) 1 → 15, Stable (stability) 1 → 10
  - `EquipMagicBarrierBuf`
  - `EquipPhysicalBarrierBuf`
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (13 lookups; see the last section).

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 1 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionPreparation` — before the cast starts: 1 set
- `ActionStart` — when the cast starts: 8 set
- `ActionSkillEvent` — on an animation/skill event during the motion: 13 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1098
- No proration slot: ExpType None: no proration slot.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `(LoopParam | 8)`
  - when `UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1093)`
- Loop / hit-repeat count (`LoopParam`): `(((LoopParam | 2) | 4) | 1)`
  - when `!hasBuff(1093) AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1091) AND hasBuff(1092) AND hasBuff(1098)`
- Loop / hit-repeat count (`LoopParam`): `((LoopParam | 2) | 4)`
  - when `!hasBuff(1093) AND !hasBuff(1098) AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1091) AND hasBuff(1092)`
- Loop / hit-repeat count (`LoopParam`): `((LoopParam | 2) | 1)`
  - when `!hasBuff(1092) AND !hasBuff(1093) AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1091) AND hasBuff(1098)`
- Loop / hit-repeat count (`LoopParam`): `(LoopParam | 2)`
  - when `!hasBuff(1092) AND !hasBuff(1093) AND !hasBuff(1098) AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1091)`
- Loop / hit-repeat count (`LoopParam`): `((LoopParam | 4) | 1)`
  - when `!hasBuff(1091) AND !hasBuff(1093) AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1092) AND hasBuff(1098)`
- Loop / hit-repeat count (`LoopParam`): `(LoopParam | 4)`
  - when `!hasBuff(1091) AND !hasBuff(1093) AND !hasBuff(1098) AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1092)`
- Loop / hit-repeat count (`LoopParam`): `(LoopParam | 1)`
  - when `!hasBuff(1091) AND !hasBuff(1092) AND !hasBuff(1093) AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1098)`

**Buffs and effects it installs or removes**

- `ActionSkillEvent` (on an animation/skill event during the motion): removes a target's buff of skill 1098 (EarthShattering) — `RemoveBuffer(1098)`
  - when `IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1098) OR IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 2) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1098) OR IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 3) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1098)`
- `ActionSkillEvent` (on an animation/skill event during the motion): removes the caster's buff of skill 2 — `RemoveSelfBuffer(2)`
  - when `EquipPhysicalBarrierBuf.GetBarrierValue(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 2), PlayerActionManagerBase.get_PlayerStatus()) le 0 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 2) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1098) OR EquipPhysicalBarrierBuf.GetBarrierValue(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 2), PlayerActionManagerBase.get_PlayerStatus()) le 0 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 2) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 3) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1098) OR EquipPhysicalBarrierBuf.GetBarrierValue(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 2), PlayerActionManagerBase.get_PlayerStatus()) le 0 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1091) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 2) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1098)`
- `ActionSkillEvent` (on an animation/skill event during the motion): removes the caster's buff of skill 3 — `RemoveSelfBuffer(3)`
  - when `EquipMagicBarrierBuf.GetBarrierValue(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 3), PlayerActionManagerBase.get_PlayerStatus()) le 0 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 3) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1098) OR EquipMagicBarrierBuf.GetBarrierValue(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 3), PlayerActionManagerBase.get_PlayerStatus()) le 0 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1091) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 3) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1098) OR EquipMagicBarrierBuf.GetBarrierValue(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 3), PlayerActionManagerBase.get_PlayerStatus()) le 0 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1091) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 3) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1098)`
- `ActionSkillEvent` (on an animation/skill event during the motion): adds the caster's buff of skill 1089 (BarehandMastery) — `AddSelfBuffer(1089, PlayerStatusBase.get_SkillManager().SkillMasteryList[1089].skillData.Level, 0)`
  - when `!hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgDownRate) AND !hasBuff(LastDmgUpRate) AND IsInstanceOf(SkillBufferManager.AddSelfBuffer(PlayerStatusBase.get_SkillBufferManager(), 1089, PlayerStatusBase.get_SkillManager().SkillMasteryList[1089].skillData.Level, 0), TakeQigongBuf) eq 1 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND PlayerStatusBase.get_SkillManager().SkillMasteryList[1089].skillData.Level lo 10 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1119) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgDownRate) AND IsInstanceOf(SkillBufferManager.AddSelfBuffer(PlayerStatusBase.get_SkillBufferManager(), 1089, PlayerStatusBase.get_SkillManager().SkillMasteryList[1089].skillData.Level, 0), TakeQigongBuf) eq 1 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND PlayerStatusBase.get_SkillManager().SkillMasteryList[1089].skillData.Level lo 10 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1119) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(LastDmgUpRate) OR !hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgUpRate) AND IsInstanceOf(SkillBufferManager.AddSelfBuffer(PlayerStatusBase.get_SkillBufferManager(), 1089, PlayerStatusBase.get_SkillManager().SkillMasteryList[1089].skillData.Level, 0), TakeQigongBuf) eq 1 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND PlayerStatusBase.get_SkillManager().SkillMasteryList[1089].skillData.Level lo 10 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1119) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(LastDmgDownRate)`
- `ActionSkillEvent` (on an animation/skill event during the motion): removes a target's buff of skill 1119 — `RemoveBuffer(1119)`
  - when `!hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgDownRate) AND !hasBuff(LastDmgUpRate) AND IsInstanceOf(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1089], TakeQigongBuf) eq 1 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1119) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgDownRate) AND IsInstanceOf(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1089], TakeQigongBuf) eq 1 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1119) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(LastDmgUpRate) OR !hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgUpRate) AND IsInstanceOf(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1089], TakeQigongBuf) eq 1 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1119) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(LastDmgDownRate)`
- `ActionSkillEvent` (on an animation/skill event during the motion): constructs `EarthShatteringBuf` — `.ctor(Lv, SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1119), 20), PlayerActionManagerBase.get_PlayerStatus())`
  - when `!hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgDownRate) AND !hasBuff(LastDmgUpRate) AND IsInstanceOf(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1089], TakeQigongBuf) eq 1 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1119) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgDownRate) AND IsInstanceOf(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1089], TakeQigongBuf) eq 1 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1119) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(LastDmgUpRate) OR !hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgUpRate) AND IsInstanceOf(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1089], TakeQigongBuf) eq 1 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1119) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(LastDmgDownRate)`
- `ActionSkillEvent` (on an animation/skill event during the motion): adds the caster's buff of `new EarthShatteringBuf` — `AddSelfBuffer(new EarthShatteringBuf, Id)`
  - when `!hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgDownRate) AND !hasBuff(LastDmgUpRate) AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) OR !hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgDownRate) AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(LastDmgUpRate) OR !hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgUpRate) AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(LastDmgDownRate)`
- `ActionSkillEvent` (on an animation/skill event during the motion): constructs `EquipPhysicalBarrierBuf` — `.ctor(0)`
  - when `!hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgDownRate) AND !hasBuff(LastDmgUpRate) AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) OR !hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgDownRate) AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(LastDmgUpRate) OR !hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgDownRate) AND !hasBuff(LastDmgUpRate) AND IsInstanceOf(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1089], TakeQigongBuf) eq 1 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1119) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)`
- `ActionSkillEvent` (on an animation/skill event during the motion): adds the caster's buff of `new EquipPhysicalBarrierBuf` — `AddSelfBuffer(new EquipPhysicalBarrierBuf, Id)`
  - when `!hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgDownRate) AND !hasBuff(LastDmgUpRate) AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) OR !hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgDownRate) AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(LastDmgUpRate) OR !hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgDownRate) AND !hasBuff(LastDmgUpRate) AND IsInstanceOf(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1089], TakeQigongBuf) eq 1 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1119) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)`
- `ActionSkillEvent` (on an animation/skill event during the motion): adds the caster's buff of `new EquipMagicBarrierBuf` — `AddSelfBuffer(new EquipMagicBarrierBuf, Id)`
  - when `!hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgDownRate) AND !hasBuff(LastDmgUpRate) AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) OR !hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgUpRate) AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(LastDmgDownRate) OR !hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgDownRate) AND !hasBuff(LastDmgUpRate) AND IsInstanceOf(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1089], TakeQigongBuf) eq 1 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1119) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)`
- `ActionSkillEvent` (on an animation/skill event during the motion): constructs `EquipMagicBarrierBuf` — `.ctor(0)`
  - when `!hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgUpRate) AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(LastDmgDownRate) OR !hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgUpRate) AND IsInstanceOf(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1089], TakeQigongBuf) eq 1 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1119) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(LastDmgDownRate) OR !hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgUpRate) AND IsInstanceOf(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1089], TakeQigongBuf) ne 1 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1119) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(LastDmgDownRate)`
- `ActionSkillEvent` (on an animation/skill event during the motion): constructs `EarthShatteringBuf` — `.ctor(Lv, 0, PlayerActionManagerBase.get_PlayerStatus())`
  - when `!hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgDownRate) AND !hasBuff(LastDmgUpRate) AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) OR !hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgDownRate) AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(LastDmgUpRate) OR !hasBuff(1093) AND !hasBuff(1098) AND !hasBuff(LastDmgUpRate) AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) ne 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(LastDmgDownRate)`
- `ActionSkillEvent` (on an animation/skill event during the motion): constructs `EarthShatteringBuf` — `.ctor(bufCondition)`
  - when `(bufCondition & 1) eq 0 AND (bufCondition & 8) eq 0 AND IsInstanceOf(actarAction, OtherPlayerActionManager) eq 1 OR (bufCondition & 1) eq 0 AND (bufCondition & 8) eq 0 AND IsInstanceOf(actarAction, MobaOtherPlayerActionManager) eq 1 AND IsInstanceOf(actarAction, OtherPlayerActionManager) ne 1`

**Other recovered parameters**

- **Loop / hit-repeat count** (`LoopParam`): `(LoopParam | 8)` _(when UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1093))_; `(((LoopParam | 2) | 4) | 1)` _(when !hasBuff(1093) AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1091) AND hasBuff(1092) AND hasBuff(1098))_; `((LoopParam | 2) | 4)` _(when !hasBuff(1093) AND !hasBuff(1098) AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(1091) AND hasBuff(1092))_

**Buff values** (every recovered field; durations in seconds)

**Buff `EarthShatteringBuf`**
- Buff hook methods: `get_BufEffectTakeId`
- `Percent` = `(((status.Lv // 10) + (Lv << 1)))`
- `Value` = `barrier`
- `Count` = `(0)`

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| PowerResistBreaker | 1 | 2 | 3 | 4 | 5 | 7 | 9 | 11 | 13 | 15 |
| Stable | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |

- Buff fields set in the constructor (all recovered):
  - `Count` = `0`
  - `Max` = `0x7fffffff` = 2147483647
  - `stable` = `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `powerResist` = `(((Lv hi 5 ? Lv : 5) + lv) - 5)` → Lv1..10 [1, 2, 3, 4, 5, 7, 9, 11, 13, 15]
  - `element` = `((status.Lv // 10) + (Lv << 1))`
  - `playerStatus` = `status`
  - `otherPlayer` = `1` = 1
  - `bufCondition` = `condition`
**Buff `EquipMagicBarrierBuf`**
- Buff hook methods: `Calc`, `CheckTakeOver`, `GetBarrierValue`, `UpdateBufData`, `get_IsDataStack`, `get_Timer`, `set_Timer`
- `Value` = `(value)`
- Buff fields set in the constructor (all recovered):
  - `coolTime` = `30` = 30
  - `Value` = `value`
  - `Timer` = `0`
- Hook `set_Timer`: `Timer`=value
- Hook `Updata`: `Timer`=(Timer - UnityEngine.Time.get_deltaTime()); `BuffEffectActive`=1
- Hook `Calc`: `BuffEffectActive`=0; `Timer`=EquipBuffManager.CalcBuff(PlayerStatusBase.get_EquipBuffManager(), 162, int(coolTime))
- Hook `UpdateBufData`: `Timer`=[buf+0x24]; `BuffEffectActive`=buf.BuffEffectActive
**Buff `EquipPhysicalBarrierBuf`**
- Buff hook methods: `Calc`, `CheckTakeOver`, `GetBarrierValue`, `UpdateBufData`, `get_IsDataStack`, `get_Timer`, `set_Timer`
- `Value` = `(value)`
- Buff fields set in the constructor (all recovered):
  - `coolTime` = `30` = 30
  - `Value` = `value`
  - `Timer` = `0`
- Hook `set_Timer`: `Timer`=value
- Hook `Updata`: `Timer`=(Timer - UnityEngine.Time.get_deltaTime()); `BuffEffectActive`=1
- Hook `Calc`: `BuffEffectActive`=0; `Timer`=EquipBuffManager.CalcBuff(PlayerStatusBase.get_EquipBuffManager(), 162, int(coolTime))
- Hook `UpdateBufData`: `Timer`=[buf+0x24]; `BuffEffectActive`=buf.BuffEffectActive
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:EarthShatteringBuf$$.ctor<-EarthShatteringAction$$ActionSkillEvent` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

Parameter meanings (inferred from the `SkillBufferId` names):

- `Count`: stack / hit counter
- `Percent`: generic percent
- `PowerResistBreaker`: physical pierce
- `Stable`: stability
- `Value`: generic value (meaning set by the code that reads the buff)

**Where else this skill takes effect**

- Effect applied in `ReceiveSupportResult$$OnActionPlayerSupport` (79 guarded paths):
  - when `skillId gt 709` AND `skillId gt 1025` AND `skillId gt 1039` AND `skillId gt 1090`
    - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillId, skillLv, supportData), 0, meta(0), ?x3), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_AbnormalStateManager`, `AbnormalStateManager$$Recovery`, `PlayerDataManager$$get_PlayerStatus`, `PlayerDataManager$$get_SkillBufferManager`, `TakeQigongBuf$$set_TakeQigongNum`
  - when `skillId gt 709` AND `skillId gt 1025` AND `skillId gt 1039` AND `skillId gt 1090`
    - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillId, skillLv, supportData), 0, ?x2, ?x3), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_AbnormalStateManager`, `AbnormalStateManager$$Recovery`, `PlayerDataManager$$get_PlayerStatus`, `PlayerDataManager$$get_SkillBufferManager`, `TakeQigongBuf$$set_TakeQigongNum`
  - when `skillId gt 709` AND `skillId gt 1025` AND `skillId gt 1039` AND `skillId gt 1090`
    - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillId, skillLv, supportData), 0, ?x2, ?x3), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_AbnormalStateManager`, `AbnormalStateManager$$Recovery`, `PlayerDataManager$$get_PlayerStatus`, `PlayerDataManager$$get_SkillBufferManager`, `TakeQigongBuf$$set_TakeQigongNum`
  - when `skillId gt 709` AND `skillId gt 1025` AND `skillId gt 1039` AND `skillId gt 1090`
    - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillId, skillLv, supportData), 0, ?x2, ?x3), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_AbnormalStateManager`, `AbnormalStateManager$$Recovery`, `PlayerDataManager$$get_PlayerStatus`, `PlayerDataManager$$get_SkillBufferManager`, `TakeQigongBuf$$set_TakeQigongNum`
  - when `skillId gt 709` AND `skillId gt 1025` AND `skillId gt 1039` AND `skillId gt 1090`
    - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillId, skillLv, supportData), 0, ?x2, ?x3), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_AbnormalStateManager`, `AbnormalStateManager$$Recovery`, `PlayerDataManager$$get_PlayerStatus`, `PlayerDataManager$$get_SkillBufferManager`, `TakeQigongBuf$$set_TakeQigongNum`
  - when `skillId gt 709` AND `skillId gt 1025` AND `skillId gt 1039` AND `skillId gt 1090`
    - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillId, skillLv, supportData), 0, meta(0), ?x3), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_AbnormalStateManager`, `AbnormalStateManager$$Recovery`, `PlayerDataManager$$get_PlayerStatus`, `PlayerDataManager$$get_SkillBufferManager`, `TakeQigongBuf$$set_TakeQigongNum`
  - when `skillId gt 709` AND `skillId gt 1025` AND `skillId gt 1039` AND `skillId gt 1090`
    - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillId, skillLv, supportData), 0, ?x2, ?x3), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_AbnormalStateManager`, `AbnormalStateManager$$Recovery`, `PlayerDataManager$$get_PlayerStatus`, `PlayerDataManager$$get_SkillBufferManager`, `TakeQigongBuf$$set_TakeQigongNum`
  - when `skillId gt 709` AND `skillId gt 1025` AND `skillId gt 1039` AND `skillId gt 1090`
    - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillId, skillLv, supportData), 0, ?x2, ?x3), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_AbnormalStateManager`, `AbnormalStateManager$$Recovery`, `PlayerDataManager$$get_PlayerStatus`, `PlayerDataManager$$get_SkillBufferManager`, `TakeQigongBuf$$set_TakeQigongNum`
- Effect applied in `EquipMagicBarrierBuf$$CheckTakeOver` (6 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0`
    - returns `((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 52, 0, ?x3) + SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)) gt 0 ? 1 : 0)`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) eq 0`
    - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) gt 0 ? 1 : 0)`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 52, 0, ?x3) gt 0 ? 1 : 0)`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) eq 0`
    - returns `0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- Effect applied in `EquipMagicBarrierBuf$$GetBarrierValue` (6 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0`
    - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 52, 0, ?x3) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + Value))`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) eq 0`
    - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + Value)`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 52, 0, ?x3) + Value)`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) eq 0`
    - returns `Value`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- Effect applied in `EquipPhysicalBarrierBuf$$CheckTakeOver` (6 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0`
    - returns `((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)) gt 0 ? 1 : 0)`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) eq 0`
    - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) gt 0 ? 1 : 0)`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) gt 0 ? 1 : 0)`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) eq 0`
    - returns `0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- Effect applied in `EquipPhysicalBarrierBuf$$GetBarrierValue` (6 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0`
    - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + Value))`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) eq 0`
    - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + Value)`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + Value)`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) eq 0`
    - returns `Value`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- Effect applied in `NormalAttackAction$$ActionPreparation` (296 guarded paths, truncated):
  - when `TryGetValue.out2() ne 0`
    - returns `NormalAttackAction.SetEarthShatteringTake(this, ?x1, ?x2, ?x3)`
    - set `checkUnannouncedDestination` = `1`
    - set `SkillIndividualFlag` = `((SkillIndividualFlag | 64) | 0x4000)`
    - set `orgaslashBonusSkillRate` = `2`
    - set `orgaslashBonusResistBreaker` = `((CheckValidEffect.out1() + (CheckValidEffect.out1() << 2)) << 1)`
    - set `damageCount` = `3`
    - set `twinStormEffectColorR` = `MathUtil.Color32ToInt32RGB(0xff694eca, 0, ?mi, ?x3)`
    - set `twinStormEffectColorG` = `MathUtil.Color32ToInt32RGB(0xff45c3dd, 0, ?x2, ?x3)`
    - set `CastTime` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - set `UnmanagedHitTake` = `1`
    - calls `0x165db78`, `NormalAttackAction.<>c__DisplayClass72_0$$.ctor`, `0x165d8dc`, `0x165d8dc`, `PlayerAttackBase$$ActionPreparation`, `0x165d8dc`, `UnityEngine.GameObject$$GetComponent<object>`, `PlayerAttackBase$$IsBlank`
  - when `TryGetValue.out2() ne 0`
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `checkUnannouncedDestination` = `1`
    - set `SkillIndividualFlag` = `(SkillIndividualFlag | 64)`
    - set `orgaslashBonusSkillRate` = `2`
    - set `orgaslashBonusResistBreaker` = `((CheckValidEffect.out1() + (CheckValidEffect.out1() << 2)) << 1)`
    - set `damageCount` = `6`
    - set `twinStormEffectColorR` = `MathUtil.Color32ToInt32RGB(0xff694eca, 0, ?mi, ?x3)`
    - set `twinStormEffectColorG` = `MathUtil.Color32ToInt32RGB(0xff45c3dd, 0, ?x2, ?x3)`
    - set `CastTime` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `0x165db78`, `NormalAttackAction.<>c__DisplayClass72_0$$.ctor`, `0x165d8dc`, `0x165d8dc`, `PlayerAttackBase$$ActionPreparation`, `0x165d8dc`, `UnityEngine.GameObject$$GetComponent<object>`, `PlayerAttackBase$$IsBlank`
  - when `TryGetValue.out2() ne 0`
    - returns `NormalAttackAction.SetEarthShatteringTake(this, ?x1, ?x2, ?x3)`
    - set `checkUnannouncedDestination` = `1`
    - set `SkillIndividualFlag` = `((SkillIndividualFlag | 64) | 0x4000)`
    - set `orgaslashBonusSkillRate` = `2`
    - set `orgaslashBonusResistBreaker` = `((CheckValidEffect.out1() + (CheckValidEffect.out1() << 2)) << 1)`
    - set `damageCount` = `3`
    - set `twinStormEffectColorR` = `MathUtil.Color32ToInt32RGB(0xff694eca, 0, ?mi, ?x3)`
    - set `twinStormEffectColorG` = `MathUtil.Color32ToInt32RGB(0xff45c3dd, 0, ?x2, ?x3)`
    - set `CastTime` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - set `UnmanagedHitTake` = `1`
    - calls `0x165db78`, `NormalAttackAction.<>c__DisplayClass72_0$$.ctor`, `0x165d8dc`, `0x165d8dc`, `PlayerAttackBase$$ActionPreparation`, `0x165d8dc`, `UnityEngine.GameObject$$GetComponent<object>`, `PlayerAttackBase$$IsBlank`
  - when `TryGetValue.out2() ne 0`
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `checkUnannouncedDestination` = `1`
    - set `SkillIndividualFlag` = `(SkillIndividualFlag | 64)`
    - set `orgaslashBonusSkillRate` = `2`
    - set `orgaslashBonusResistBreaker` = `((CheckValidEffect.out1() + (CheckValidEffect.out1() << 2)) << 1)`
    - set `damageCount` = `6`
    - set `twinStormEffectColorR` = `MathUtil.Color32ToInt32RGB(0xff694eca, 0, ?mi, ?x3)`
    - set `twinStormEffectColorG` = `MathUtil.Color32ToInt32RGB(0xff45c3dd, 0, ?x2, ?x3)`
    - set `CastTime` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `0x165db78`, `NormalAttackAction.<>c__DisplayClass72_0$$.ctor`, `0x165d8dc`, `0x165d8dc`, `PlayerAttackBase$$ActionPreparation`, `0x165d8dc`, `UnityEngine.GameObject$$GetComponent<object>`, `PlayerAttackBase$$IsBlank`
  - when `TryGetValue.out2() ne 0`
    - returns `NormalAttackAction.SetEarthShatteringTake(this, ?x1, ?x2, ?x3)`
    - set `checkUnannouncedDestination` = `1`
    - set `SkillIndividualFlag` = `((SkillIndividualFlag | 64) | 0x4000)`
    - set `orgaslashBonusSkillRate` = `2`
    - set `orgaslashBonusResistBreaker` = `((CheckValidEffect.out1() + (CheckValidEffect.out1() << 2)) << 1)`
    - set `damageCount` = `3`
    - set `twinStormEffectColorR` = `MathUtil.Color32ToInt32RGB(0xff694eca, 0, ?mi, ?x3)`
    - set `twinStormEffectColorG` = `MathUtil.Color32ToInt32RGB(0xff45c3dd, 0, ?x2, ?x3)`
    - set `CastTime` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - set `UnmanagedHitTake` = `1`
    - calls `0x165db78`, `NormalAttackAction.<>c__DisplayClass72_0$$.ctor`, `0x165d8dc`, `0x165d8dc`, `PlayerAttackBase$$ActionPreparation`, `0x165d8dc`, `UnityEngine.GameObject$$GetComponent<object>`, `PlayerAttackBase$$IsBlank`
  - when `TryGetValue.out2() ne 0`
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `checkUnannouncedDestination` = `1`
    - set `SkillIndividualFlag` = `(SkillIndividualFlag | 64)`
    - set `orgaslashBonusSkillRate` = `2`
    - set `orgaslashBonusResistBreaker` = `((CheckValidEffect.out1() + (CheckValidEffect.out1() << 2)) << 1)`
    - set `damageCount` = `2`
    - set `twinStormEffectColorR` = `MathUtil.Color32ToInt32RGB(0xff694eca, 0, ?mi, ?x3)`
    - set `twinStormEffectColorG` = `MathUtil.Color32ToInt32RGB(0xff45c3dd, 0, ?x2, ?x3)`
    - set `CastTime` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `0x165db78`, `NormalAttackAction.<>c__DisplayClass72_0$$.ctor`, `0x165d8dc`, `0x165d8dc`, `PlayerAttackBase$$ActionPreparation`, `0x165d8dc`, `UnityEngine.GameObject$$GetComponent<object>`, `PlayerAttackBase$$IsBlank`
  - when `TryGetValue.out2() ne 0`
    - returns `NormalAttackAction.SetEarthShatteringTake(this, ?x1, ?x2, ?x3)`
    - set `checkUnannouncedDestination` = `1`
    - set `SkillIndividualFlag` = `((SkillIndividualFlag | 64) | 0x4000)`
    - set `orgaslashBonusSkillRate` = `2`
    - set `orgaslashBonusResistBreaker` = `((CheckValidEffect.out1() + (CheckValidEffect.out1() << 2)) << 1)`
    - set `damageCount` = `3`
    - set `twinStormEffectColorR` = `MathUtil.Color32ToInt32RGB(0xff9b6798, 0, ?mi, ?x3)`
    - set `twinStormEffectColorG` = `MathUtil.Color32ToInt32RGB(0xff45d7c9, 0, ?x2, ?x3)`
    - set `CastTime` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - set `UnmanagedHitTake` = `1`
    - calls `0x165db78`, `NormalAttackAction.<>c__DisplayClass72_0$$.ctor`, `0x165d8dc`, `0x165d8dc`, `PlayerAttackBase$$ActionPreparation`, `0x165d8dc`, `UnityEngine.GameObject$$GetComponent<object>`, `PlayerAttackBase$$IsBlank`
  - when `TryGetValue.out2() ne 0`
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `checkUnannouncedDestination` = `1`
    - set `SkillIndividualFlag` = `(SkillIndividualFlag | 64)`
    - set `orgaslashBonusSkillRate` = `2`
    - set `orgaslashBonusResistBreaker` = `((CheckValidEffect.out1() + (CheckValidEffect.out1() << 2)) << 1)`
    - set `damageCount` = `6`
    - set `twinStormEffectColorR` = `MathUtil.Color32ToInt32RGB(0xff9b6798, 0, ?mi, ?x3)`
    - set `twinStormEffectColorG` = `MathUtil.Color32ToInt32RGB(0xff45d7c9, 0, ?x2, ?x3)`
    - set `CastTime` = `CharacterActionManagerBase.set_DefaultMoveSpeed()`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `0x165db78`, `NormalAttackAction.<>c__DisplayClass72_0$$.ctor`, `0x165d8dc`, `0x165d8dc`, `PlayerAttackBase$$ActionPreparation`, `0x165d8dc`, `UnityEngine.GameObject$$GetComponent<object>`, `PlayerAttackBase$$IsBlank`
- Effect applied in `EarthShatteringAction$$ActionStart` (8 guarded paths):
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `(((LoopParam | 2) | 4) | 1)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `((LoopParam | 2) | 4)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `((LoopParam | 2) | 1)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `(LoopParam | 2)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `((LoopParam | 4) | 1)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `(LoopParam | 4)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `LoopParam` = `(LoopParam | 1)`
    - calls `PlayerAttackBase$$ActionStart`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - calls `PlayerAttackBase$$ActionStart`
- Effect applied in `EarthShatteringAction$$ActionPreparation` (1 guarded path):
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3)`
    - set `SkillIndividualFlag` = `((SkillBufferManager.ContainsBuffer(?blr, 1098, 0, ?x3) & 1) ne 0 ? 2 : 1)`
    - calls `PlayerAttackBase$$ActionPreparation`
- Effect applied in `MagicBarrier$$Calc` (3 guarded paths):
  - when `IsValid ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1098, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `(((value gt 1 ? value : 1) - (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + Value)) gt 0 ? ((value gt 1 ? value : 1) - (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + Value)) : 1)`
    - set `IsValid` = `0`
    - set `Timer` = `EquipBuffManager.CalcBuff(?blr, 162, int(coolTime), mobAct)`
    - calls `EquipBuffManager$$CalcBuff`, `SkillBufferDataBase$$GetParam`, `BattleLogManager$$BarrierLog`
  - when `IsValid ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1098, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - set `IsValid` = `0`
    - set `Timer` = `EquipBuffManager.CalcBuff(?blr, 162, int(coolTime), mobAct)`
    - calls `EquipBuffManager$$CalcBuff`, `0x165db84`
  - when `IsValid ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1098, stkp(-40), 0) & 1) eq 0`
    - returns `(((value gt 1 ? value : 1) - Value) gt 0 ? ((value gt 1 ? value : 1) - Value) : 1)`
    - set `IsValid` = `0`
    - set `Timer` = `EquipBuffManager.CalcBuff(?blr, 162, int(coolTime), mobAct)`
    - calls `EquipBuffManager$$CalcBuff`, `BattleLogManager$$BarrierLog`
- Effect applied in `PhysicalBarrier$$Calc` (3 guarded paths):
  - when `IsValid ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1098, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `(((value gt 1 ? value : 1) - (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + Value)) gt 0 ? ((value gt 1 ? value : 1) - (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + Value)) : 1)`
    - set `IsValid` = `0`
    - set `Timer` = `EquipBuffManager.CalcBuff(?blr, 162, int(coolTime), mobAct)`
    - calls `EquipBuffManager$$CalcBuff`, `SkillBufferDataBase$$GetParam`, `BattleLogManager$$BarrierLog`
  - when `IsValid ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1098, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - set `IsValid` = `0`
    - set `Timer` = `EquipBuffManager.CalcBuff(?blr, 162, int(coolTime), mobAct)`
    - calls `EquipBuffManager$$CalcBuff`, `0x165db84`
  - when `IsValid ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1098, stkp(-40), 0) & 1) eq 0`
    - returns `(((value gt 1 ? value : 1) - Value) gt 0 ? ((value gt 1 ? value : 1) - Value) : 1)`
    - set `IsValid` = `0`
    - set `Timer` = `EquipBuffManager.CalcBuff(?blr, 162, int(coolTime), mobAct)`
    - calls `EquipBuffManager$$CalcBuff`, `BattleLogManager$$BarrierLog`
- Effect applied in `SkillBufferManager$$Update` (4 guarded paths):
  - always
    - returns `SkillBufferManager.UpdateSkillCombo(this, ?x1, ?x2, ?x3)`
    - set `IsInvincible` = `0`
    - calls `Singleton<object>$$get_Instance`, `PartyManager$$get_LoginMemberData`, `0x165db78`, `System.Collections.Generic.List<Int32Enum>$$.ctor`, `0x165db78`, `System.Collections.Generic.List<Int32Enum>$$.ctor`, `System.Collections.Generic.List<Int32Enum>$$GetEnumerator`, `System.Collections.Generic.List.Enumerator<Int32Enum>$$MoveNext`
  - always
    - returns `SkillBufferManager.UpdateSkillCombo(this, ?x1, ?x2, ?x3)`
    - set `IsInvincible` = `0`
    - calls `Singleton<object>$$get_Instance`, `PartyManager$$get_LoginMemberData`, `0x165db78`, `System.Collections.Generic.List<Int32Enum>$$.ctor`, `0x165db78`, `System.Collections.Generic.List<Int32Enum>$$.ctor`, `System.Collections.Generic.List<Int32Enum>$$GetEnumerator`, `System.Collections.Generic.List.Enumerator<Int32Enum>$$MoveNext`
  - always
    - returns `SkillBufferManager.UpdateSkillCombo(this, ?x1, ?x2, ?x3)`
    - set `IsInvincible` = `0`
    - calls `Singleton<object>$$get_Instance`, `PartyManager$$get_LoginMemberData`, `0x165db78`, `System.Collections.Generic.List<Int32Enum>$$.ctor`, `0x165db78`, `System.Collections.Generic.List<Int32Enum>$$.ctor`, `SkillBufferManager$$UpdateKnightPledgeBuf`, `SkillBufferManager$$UpdateIndividualBuf`
  - always
    - returns `SkillBufferManager.UpdateSkillCombo(this, ?x1, ?x2, ?x3)`
    - set `IsInvincible` = `0`
    - calls `Singleton<object>$$get_Instance`, `PartyManager$$get_LoginMemberData`, `0x165db78`, `System.Collections.Generic.List<Int32Enum>$$.ctor`, `0x165db78`, `System.Collections.Generic.List<Int32Enum>$$.ctor`, `SkillBufferManager$$UpdateKnightPledgeBuf`, `SkillBufferManager$$UpdateIndividualBuf`
- Code that reads this skill's level / buff by constant id: `EarthShatteringAction$$ActionPreparation (ContainsBuffer)`, `EarthShatteringAction$$ActionSkillEvent (ContainsBuffer)`, `EarthShatteringAction$$ActionStart (ContainsBuffer)`, `EquipMagicBarrierBuf$$CheckTakeOver (TryGetBuf)`, `EquipMagicBarrierBuf$$GetBarrierValue (TryGetBuf)`, `EquipPhysicalBarrierBuf$$CheckTakeOver (TryGetBuf)`, `EquipPhysicalBarrierBuf$$GetBarrierValue (TryGetBuf)`, `MagicBarrier$$Calc (TryGetBuf)`, `NormalAttackAction$$ActionPreparation (ContainsBuffer)`, `PhysicalBarrier$$Calc (TryGetBuf)`, `ReceiveSupportResult$$OnActionPlayerSupport (ContainsBuffer)`, `ReceiveSupportResult$$OnActionPlayerSupport (GetSkillLv)`, `SkillBufferManager$$Update (TryGetBuf)`

_Raw recovered data (every method item): [trees/BareHandSkill.md](../trees/BareHandSkill.md) — uid 1098_

---

### ฟื้นคืนชีพ (Revival) · uid 1099

<img src="../../icons/sk_1099.png" width="40" alt="icon"> 
**Tree:** ベアハンドスキル (`BareHandSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Hand, SubWeaponExclusion · **Requires:** การปะทะของจิตวิญญาณ · **Flags:** NoMarketSearch · **Client class:** `Revival` (passive mastery)

> ถ้าตายไปตอนที่ไม่ได้เปิดใช้ชี่กงฟื้นฟูมีโอกาสที่
> ชี่กงฟื้นฟูจะถูกเปิดใช้งานโดยอัตโนมัติเพื่อฟื้นฟู HP
> เมื่อเปิดใช้ไปแล้วจะไม่สามารถใช้งานได้อีกระยะหนึ่ง

**How it works**

- Mastery skill of the ベアハンドスキル tree (tier 3, max Lv 250); usable with Hand, SubWeaponExclusion.
- It installs a buff on the caster.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Buffs:
  - `RevivalBuf`: lasts `900` s
  - `CountBufferBase`
- Passive modifiers (negative = penalty): Value (generic value) 0 at Lv1 to 1 at Lv10, Percent (generic percent) 1 at Lv1 to 100 at Lv10.
- Its effect is applied by client code: `Revival$$CheckRevival` (formulas in the last section).
- Other client code reads this skill (1 lookup; see the last section).

**Buff values** (every recovered field; durations in seconds)

**Buff `RevivalBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `900` s
- Buff fields set in the constructor (all recovered):
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:HealQigongBuf$$.ctor<-Revival$$OnActionMobDamage` (no direct constructor call in the skill's own code).
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

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 0 | 0 | 0 | 0 | 0 | 1 | 1 | 1 | 1 | 1 |
| Percent | 1 | 4 | 9 | 16 | 25 | 36 | 49 | 64 | 81 | 100 |


Bonus meanings (inferred from the names):

- `Value`: generic value
- `Percent`: generic percent

**Where else this skill takes effect**

- Effect applied in `Revival$$CheckRevival` (5 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 1089, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `(TakeQigongBuf.GetUseQigongNum(TryGetBuf.out2(), 0, ?x2, ?x3) gt 0 ? 1 : 0)`
    - calls `TakeQigongBuf$$GetUseQigongNum`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1089, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1089, stkp(-24), 0) & 1) eq 0`
    - returns `0`
  - always
    - returns `0`
  - always
    - returns `0`
- Code that reads this skill's level / buff by constant id: `Revival$$CheckRevival (ContainsBuffer)`

_Raw recovered data (every method item): [trees/BareHandSkill.md](../trees/BareHandSkill.md) — uid 1099_

---

### ซ่อนเร้นตัวตน (SelfDisclosure) · uid 1100

<img src="../../icons/sk_1100.png" width="40" alt="icon"> 
**Tree:** ベアハンドスキル (`BareHandSkill`, tier 3) · **Type:** Extra · **Max Lv:** 250 · **Weapons:** Hand, SubWeaponExclusion · **Requires:** ชาร์จพลังชี่กงอัลติมา · **Flags:** NoMarketSearch · **Client class:** `SelfDisclosure` (passive mastery)

> หากไม่มีสล็อตให้ถือไว้
> เมื่อติดตั้งคริสตา 3 อันและเปิดใช้
> ซีซ่าแสลชเชอร์/วายุโหมคลื่นกระหน่ำ/ชี่กงฟื้นฟู
> จะได้รับความสามารถของคริสตา 2 อันที่สอดคล้องกัน

**How it works**

- Extra skill of the ベアハンドスキル tree (tier 3, max Lv 250); usable with Hand, SubWeaponExclusion.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Value (generic value) 1200 at Lv1 to 3000 at Lv10, Percent (generic percent) 0 at Lv1 to 5 at Lv10, Avoid (dodge) 10 at Lv1 to 100 at Lv10, GuardPower (guard power) 500 at Lv1 to 5000 at Lv10, Guard (guard rate) 7 at Lv1 to 25 at Lv10.
- Other client code reads this skill (1 lookup; see the last section).

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 1200 | 1400 | 1600 | 1800 | 2000 | 2200 | 2400 | 2600 | 2800 | 3000 |
| Percent | 0 | 1 | 1 | 2 | 2 | 3 | 3 | 4 | 4 | 5 |
| Avoid | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |
| GuardPower | 500 | 1000 | 1500 | 2000 | 2500 | 3000 | 3500 | 4000 | 4500 | 5000 |
| Guard | 7 | 9 | 11 | 13 | 15 | 17 | 19 | 21 | 23 | 25 |


Bonus meanings (inferred from the names):

- `Value`: generic value
- `Percent`: generic percent
- `Avoid`: dodge
- `GuardPower`: guard power
- `Guard`: guard rate

**Where else this skill takes effect**

- Code that reads this skill's level / buff by constant id: `UIExSkillManager$$ExSkillList (GetSkillLv)`

_Raw recovered data (every method item): [trees/BareHandSkill.md](../trees/BareHandSkill.md) — uid 1100_

---
