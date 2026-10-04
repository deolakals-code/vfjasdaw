# ダンサー (`DancerSkill`) — skill details

7 entries.

### การร่ายรำแห่งภูตพราย (FairyDance) · uid 801

<img src="../../icons/sk_801.png" width="40" alt="icon"> 
**Tree:** ダンサー (`DancerSkill`, tier 1) · **Type:** Support · **Max Lv:** 1 · **Weapons:** OneHandSword, Magictool, Knuckle, ShortSword, Halberd · **Flags:** NoMarketSearch · **Client class:** `FairyDanceAction`

> การร่ายรำอันพริ้วไหวราวภูตพราย
> ลดอัตราความแม่นของมอนสเตอร์
> ผลลัพธ์จะเพิ่มขึ้นถ้าเริ่มร่ายรำใหม่อีกครั้งก่อนผลจะสิ้นสุดลงเพียงเล็กน้อย
> ถ้าเริ่มใช้ใหม่เร็วเกินไป จะเป็นการลดผลที่ได้รับจากผลของการร่ายรำอื่น

**How it works**

- Support skill of the ダンサー tree (tier 1, max Lv 1); usable with OneHandSword, Magictool, Knuckle, ShortSword, Halberd.
- It installs a buff on the caster.
- It installs a buff on other players / the party.
- Buffs:
  - `FairyDanceBuf`: lasts `time` s

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionHit` — when the attack connects: 1 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 801
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): installs the dance buff on the caster — `AddSelfDanceBuf(PlayerAttackBase.get_ActionID(), Lv)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**Buff values** (every recovered field; durations in seconds)

**Buff `FairyDanceBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `time` s
- `Value` = `(((5 - (danceLv)) * ((((Lv + 2) // 3) + 2))) + -((Lv << 1)))` _(when BuffEffectActive ne 0)_
- `Count` = `(danceLv)` _(when BuffEffectActive ne 0)_
- Buff fields set in the constructor (all recovered):
  - `Count` = `danceLv`
  - `Max` = `10` = 10
  - `necessaryFleeRate` = `(Lv << 1)` = 2
  - `variableValue` = `(((Lv + 2) // 3) + 2)` = 3
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0

Parameter meanings (inferred from the `SkillBufferId` names):

- `Count`: stack / hit counter
- `Value`: generic value (meaning set by the code that reads the buff)

_Raw recovered data (every method item): [trees/DancerSkill.md](../trees/DancerSkill.md) — uid 801_

---

### การร่ายรำอันรุนแรง (PassionDance) · uid 802

<img src="../../icons/sk_802.png" width="40" alt="icon"> 
**Tree:** ダンサー (`DancerSkill`, tier 1) · **Type:** Support · **Max Lv:** 1 · **Weapons:** OneHandSword, Magictool, Knuckle, ShortSword, Halberd · **Requires:** การร่ายรำแห่งภูตพราย · **Flags:** NoMarketSearch · **Client class:** `PassionDanceAction`

> การร่ายรำที่แสดงออกถึงความรู้สึกอย่างรุนแรง
> จะทำให้ทำลายชิ้นส่วนของมอนสเตอร์ได้ง่ายขึ้น
> ผลลัพธ์จะเพิ่มขึ้นถ้าเริ่มร่ายรำใหม่อีกครั้งก่อนผลจะสิ้นสุดลงเพียงเล็กน้อย
> ถ้าเริ่มใช้ใหม่เร็วเกินไป จะเป็นการลดผลที่ได้รับจากผลของการร่ายรำอื่น

**How it works**

- Support skill of the ダンサー tree (tier 1, max Lv 1); usable with OneHandSword, Magictool, Knuckle, ShortSword, Halberd.
- It installs a buff on the caster.
- It installs a buff on other players / the party.
- Buffs:
  - `PassionDanceBuf`: lasts `time` s

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionHit` — when the attack connects: 1 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 802
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): installs the dance buff on the caster — `AddSelfDanceBuf(PlayerAttackBase.get_ActionID(), Lv)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**Buff values** (every recovered field; durations in seconds)

**Buff `PassionDanceBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `time` s
- `Value` = `((((danceLv) - 5) * ((((Lv hi 5 ? Lv : 5) + lv) - 4))) + ((Lv << 1)))` _(when BuffEffectActive ne 0)_
- Buff fields set in the constructor (all recovered):
  - `Count` = `danceLv`
  - `partsAttck` = `(Lv << 1)` = 2
  - `variableValue` = `(((Lv hi 5 ? Lv : 5) + lv) - 4)` = 2
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

Parameter meanings (inferred from the `SkillBufferId` names):

- `Value`: generic value (meaning set by the code that reads the buff)

_Raw recovered data (every method item): [trees/DancerSkill.md](../trees/DancerSkill.md) — uid 802_

---

### การร่ายรำให้กำลังใจ (SupportDance) · uid 803

<img src="../../icons/sk_803.png" width="40" alt="icon"> 
**Tree:** ダンサー (`DancerSkill`, tier 1) · **Type:** Support · **Max Lv:** 1 · **Weapons:** OneHandSword, Magictool, Knuckle, ShortSword, Halberd · **Requires:** การร่ายรำแห่งภูตพราย · **Flags:** NoMarketSearch · **Client class:** `SupportDanceAction`

> การร่ายรำเพื่อสร้างขวัญกำลังใจให้พวกพ้อง
> ฟื้นฟู MP ได้ทันที
> ผลลัพธ์จะเพิ่มขึ้นถ้าเริ่มร่ายรำใหม่อีกครั้งก่อนผลจะสิ้นสุดลงเพียงเล็กน้อย
> ถ้าเริ่มใช้ใหม่เร็วเกินไป จะเป็นการลดผลที่ได้รับจากผลของการร่ายรำอื่น

**How it works**

- Support skill of the ダンサー tree (tier 1, max Lv 1); usable with OneHandSword, Magictool, Knuckle, ShortSword, Halberd.
- It installs a buff on the caster.
- It installs a buff on other players / the party.
- Buffs:
  - `SupportDanceBuf`: lasts `time` s

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionHit` — when the attack connects: 1 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 803
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): installs the dance buff on the caster — `AddSelfDanceBuf(PlayerAttackBase.get_ActionID(), Lv)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**Buff values** (every recovered field; durations in seconds)

**Buff `SupportDanceBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `time` s
- Buff fields set in the constructor (all recovered):
  - `Count` = `danceLv`
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

_Raw recovered data (every method item): [trees/DancerSkill.md](../trees/DancerSkill.md) — uid 803_

---

### การร่ายรำอันเฉียบคม (SharpDance) · uid 804

<img src="../../icons/sk_804.png" width="40" alt="icon"> 
**Tree:** ダンサー (`DancerSkill`, tier 2) · **Type:** Support · **Max Lv:** 60 · **Weapons:** OneHandSword, Magictool, Knuckle, ShortSword, Halberd · **Requires:** การร่ายรำอันรุนแรง · **Flags:** NoMarketSearch · **Client class:** `SharpDanceAction`

> การร่ายรำอย่างอ่อนช้อยเฉียบคม
> ลดอัตราการหลบหลีกของมอนสเตอร์
> ผลลัพธ์จะเพิ่มขึ้นถ้าเริ่มร่ายรำใหม่อีกครั้งก่อนผลจะสิ้นสุดลงเพียงเล็กน้อย
> ถ้าเริ่มใช้ใหม่เร็วเกินไป จะเป็นการลดผลที่ได้รับจากผลของการร่ายรำอื่น

**How it works**

- Support skill of the ダンサー tree (tier 2, max Lv 60); usable with OneHandSword, Magictool, Knuckle, ShortSword, Halberd.
- It installs a buff on the caster.
- It installs a buff on other players / the party.
- Buffs:
  - `SharpDanceBuf`: lasts `time` s
- Other client code reads this skill (4 lookups; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionHit` — when the attack connects: 1 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 804
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): installs the dance buff on the caster — `AddSelfDanceBuf(PlayerAttackBase.get_ActionID(), Lv)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**Buff values** (every recovered field; durations in seconds)

**Buff `SharpDanceBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `time` s
- `Value` = `(((5 - (danceLv)) * (((Lv + 2) // 3))) + -(Lv))` _(when BuffEffectActive ne 0)_
- Buff fields set in the constructor (all recovered):
  - `Count` = `danceLv`
  - `necessaryHitRate` = `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `variableValue` = `((Lv + 2) // 3)` → Lv1..10 [1, 1, 1, 2, 2, 2, 3, 3, 3, 4]
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

Parameter meanings (inferred from the `SkillBufferId` names):

- `Value`: generic value (meaning set by the code that reads the buff)

**Where else this skill takes effect**

- Effect applied in `HuntingOneNormalAttackAction$$calcPlayerToMobDamage` (300 guarded paths, truncated):
  - when `(SkillBufferManager.TryGetBuf(?blr, 804, stkp(-136), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(MobBuffManager.TryGetBuff(MobActionManagerBase.get_BuffManager(mobAction), 10, stkp(-144), 0) & 1) ne 0` AND `TryGetBuff.out2() ne 0`
    - returns `0x165d8dc(([targetDamageData+0x10] + ([targetDamageData+0x18] << 3)), 0x165db78(meta(0x398c078, SkillActionBase.DamageData_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
    - calls `SkillBufferManager$$SetBufferEffectActive`, `PlayerSecondaryStatus$$GetCrtRate`, `PlayerSecondaryStatus$$GetCrtConstant`, `PlayerSecondaryStatus$$CalcCritical`, `PlayerAttackBase$$checkCriticalPercent`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$CheckEffectAbnormal`, `interface MobActionManagerBase.get_MobBattleStatus`
  - when `(SkillBufferManager.TryGetBuf(?blr, 804, stkp(-136), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(MobBuffManager.TryGetBuff(MobActionManagerBase.get_BuffManager(mobAction), 10, stkp(-144), 0) & 1) ne 0` AND `TryGetBuff.out2() ne 0`
    - returns `System.Collections.Generic.List<object>.AddWithResize(targetDamageData, 0x165db78(meta(0x398c078, SkillActionBase.DamageData_TypeInfo), ?x1, ?x2, ?x3), meta(0), ?x3)`
    - calls `SkillBufferManager$$SetBufferEffectActive`, `PlayerSecondaryStatus$$GetCrtRate`, `PlayerSecondaryStatus$$GetCrtConstant`, `PlayerSecondaryStatus$$CalcCritical`, `PlayerAttackBase$$checkCriticalPercent`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$CheckEffectAbnormal`, `interface MobActionManagerBase.get_MobBattleStatus`
  - when `(SkillBufferManager.TryGetBuf(?blr, 804, stkp(-136), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(MobBuffManager.TryGetBuff(MobActionManagerBase.get_BuffManager(mobAction), 10, stkp(-144), 0) & 1) ne 0` AND `TryGetBuff.out2() ne 0`
    - returns `0x165d8dc(([targetDamageData+0x10] + ([targetDamageData+0x18] << 3)), 0x165db78(meta(0x398c078, SkillActionBase.DamageData_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
    - calls `SkillBufferManager$$SetBufferEffectActive`, `PlayerSecondaryStatus$$GetCrtRate`, `PlayerSecondaryStatus$$GetCrtConstant`, `PlayerSecondaryStatus$$CalcCritical`, `PlayerAttackBase$$checkCriticalPercent`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$CheckEffectAbnormal`, `interface MobActionManagerBase.get_MobBattleStatus`
  - when `(SkillBufferManager.TryGetBuf(?blr, 804, stkp(-136), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(MobBuffManager.TryGetBuff(MobActionManagerBase.get_BuffManager(mobAction), 10, stkp(-144), 0) & 1) ne 0` AND `TryGetBuff.out2() ne 0`
    - returns `System.Collections.Generic.List<object>.AddWithResize(targetDamageData, 0x165db78(meta(0x398c078, SkillActionBase.DamageData_TypeInfo), ?x1, ?x2, ?x3), meta(0), ?x3)`
    - calls `SkillBufferManager$$SetBufferEffectActive`, `PlayerSecondaryStatus$$GetCrtRate`, `PlayerSecondaryStatus$$GetCrtConstant`, `PlayerSecondaryStatus$$CalcCritical`, `PlayerAttackBase$$checkCriticalPercent`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$CheckEffectAbnormal`, `interface MobActionManagerBase.get_MobBattleStatus`
  - when `(SkillBufferManager.TryGetBuf(?blr, 804, stkp(-136), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(MobBuffManager.TryGetBuff(MobActionManagerBase.get_BuffManager(mobAction), 10, stkp(-144), 0) & 1) ne 0` AND `TryGetBuff.out2() ne 0`
    - returns `0x165d8dc(([targetDamageData+0x10] + ([targetDamageData+0x18] << 3)), 0x165db78(meta(0x398c078, SkillActionBase.DamageData_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
    - calls `SkillBufferManager$$SetBufferEffectActive`, `PlayerSecondaryStatus$$GetCrtRate`, `PlayerSecondaryStatus$$GetCrtConstant`, `PlayerSecondaryStatus$$CalcCritical`, `PlayerAttackBase$$checkCriticalPercent`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$CheckEffectAbnormal`, `interface MobActionManagerBase.get_MobBattleStatus`
  - when `(SkillBufferManager.TryGetBuf(?blr, 804, stkp(-136), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(MobBuffManager.TryGetBuff(MobActionManagerBase.get_BuffManager(mobAction), 10, stkp(-144), 0) & 1) ne 0` AND `TryGetBuff.out2() ne 0`
    - returns `System.Collections.Generic.List<object>.AddWithResize(targetDamageData, 0x165db78(meta(0x398c078, SkillActionBase.DamageData_TypeInfo), ?x1, ?x2, ?x3), meta(0), ?x3)`
    - calls `SkillBufferManager$$SetBufferEffectActive`, `PlayerSecondaryStatus$$GetCrtRate`, `PlayerSecondaryStatus$$GetCrtConstant`, `PlayerSecondaryStatus$$CalcCritical`, `PlayerAttackBase$$checkCriticalPercent`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$CheckEffectAbnormal`, `interface MobActionManagerBase.get_MobBattleStatus`
  - when `(SkillBufferManager.TryGetBuf(?blr, 804, stkp(-136), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(MobBuffManager.TryGetBuff(MobActionManagerBase.get_BuffManager(mobAction), 10, stkp(-144), 0) & 1) ne 0` AND `TryGetBuff.out2() ne 0`
    - calls `SkillBufferManager$$SetBufferEffectActive`, `PlayerSecondaryStatus$$GetCrtRate`, `PlayerSecondaryStatus$$GetCrtConstant`, `PlayerSecondaryStatus$$CalcCritical`, `PlayerAttackBase$$checkCriticalPercent`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$CheckEffectAbnormal`, `interface MobActionManagerBase.get_MobBattleStatus`
  - when `(SkillBufferManager.TryGetBuf(?blr, 804, stkp(-136), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(MobBuffManager.TryGetBuff(MobActionManagerBase.get_BuffManager(mobAction), 10, stkp(-144), 0) & 1) ne 0` AND `TryGetBuff.out2() ne 0`
    - calls `SkillBufferManager$$SetBufferEffectActive`, `PlayerSecondaryStatus$$GetCrtRate`, `PlayerSecondaryStatus$$GetCrtConstant`, `PlayerSecondaryStatus$$CalcCritical`, `PlayerAttackBase$$checkCriticalPercent`, `interface MobActionManagerBase.get_AbnormalStateManager`, `AbnormalStateManager$$CheckEffectAbnormal`, `interface MobActionManagerBase.get_MobBattleStatus`
- Code that reads this skill's level / buff by constant id: `CallGolemNormalAttackAction$$calcPlayerToMobDamage (TryGetBuf)`, `HuntingOneNormalAttackAction$$calcPlayerToMobDamage (TryGetBuf)`, `SummonDemonicAttackAction$$calcPlayerToMobDamage (TryGetBuf)`, `SummonDemonicSpecialAttack$$calcPlayerToMobDamage (TryGetBuf)`

_Raw recovered data (every method item): [trees/DancerSkill.md](../trees/DancerSkill.md) — uid 804_

---

### ตั้งรับอย่างสง่างาม (ElegantStance) · uid 805

<img src="../../icons/sk_805.png" width="40" alt="icon"> 
**Tree:** ダンサー (`DancerSkill`, tier 2) · **Type:** Buffer · **Max Lv:** 60 · **Weapons:** OneHandSword, Magictool, Knuckle, ShortSword, Halberd · **Flags:** NoMarketSearch · **Client class:** `ElegantStanceAction`

> ใช้พัดตั้งรับและหลบหลีกการโจมตี
> ระหว่างตั้งรับความเสียหายที่ได้รับจะลดน้อยลง
> ติดสถานะไร้พ่ายให้ตัวเอง
> ถ้าตัวเองติดสถานะผิดปกติอยู่จะไม่สามารถตั้งรับได้อย่างงดงาม

**How it works**

- Buffer skill of the ダンサー tree (tier 2, max Lv 60); usable with OneHandSword, Magictool, Knuckle, ShortSword, Halberd.
- It installs a buff on the caster.
- Buffs:
  - `ElegantStanceBuf`
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (3 lookups; see the last section).

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionSkillEvent` — on an animation/skill event during the motion: 3 set, 1 call
- `OtherPlayerSkillEventReceive` — skill-specific method: 2 set
- `ActionHit` — when the attack connects: 2 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 805
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionSkillEvent` (on an animation/skill event during the motion): removes the caster's buff of skill 805 (ElegantStance) — `RemoveSelfBuffer(805)`
  - when `UnityEngine.Object.op_Inequality(actarAction) AND holdOff eq 0 AND param eq 4 OR !UnityEngine.Object.op_Equality(actarAction) AND (timer - UnityEngine.Time.get_deltaTime()) ls 0 AND UnityEngine.Object.op_Inequality(actarAction) AND holdOff eq 0 AND param eq 2 AND param ne 3 AND param ne 4 AND timer gt 0 OR (timer - UnityEngine.Time.get_deltaTime()) ls 0 AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) AND holdOff eq 0 AND param eq 2 AND param ne 3 AND param ne 4 AND timer gt 0`
- `ActionHit` (when the attack connects): constructs `ElegantStanceBuf` — `.ctor(Lv)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): adds the caster's buff of `new ElegantStanceBuf` — `AddSelfBuffer(new ElegantStanceBuf, Id)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Buff values** (every recovered field; durations in seconds)

**Buff `ElegantStanceBuf`**
- `MobLastDamageRateBuf` = `receiveDmgDownRate` _(when BuffEffectActive ne 0)_
- `AbnormalAvoid` = `abnormalAvoid` _(when BuffEffectActive ne 0)_
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:ElegantStanceBuf$$.ctor<-ElegantStanceAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

Parameter meanings (inferred from the `SkillBufferId` names):

- `AbnormalAvoid`: ailment avoidance
- `MobLastDamageRateBuf`: final damage multiplier vs monsters (buff category)

**Where else this skill takes effect**

- Effect applied in `ElegantStanceAction$$Damaged` (3 guarded paths):
  - always
    - returns `?blr`
    - calls `virtual CharacterActionManagerBase.get_IsLocalDead`
  - always
    - returns `SkillActionBase.op_Inequality(CharacterActionManagerBase.get_IsLocalDead(), 0, 0, ?x3)`
    - calls `virtual CharacterActionManagerBase.get_IsLocalDead`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 805, 0, ?x3)`
- Code that reads this skill's level / buff by constant id: `ElegantStanceAction$$Damaged (ContainsBuffer)`, `MercenaryActionManager$$Damaged (ContainsBuffer)`, `PlayerActionManager$$Damaged (ContainsBuffer)`

_Raw recovered data (every method item): [trees/DancerSkill.md](../trees/DancerSkill.md) — uid 805_

---

### การร่ายรำอันทรงเสน่ห์ (EnchantedDance) · uid 806

<img src="../../icons/sk_806.png" width="40" alt="icon"> 
**Tree:** ダンサー (`DancerSkill`, tier 3) · **Type:** Support · **Max Lv:** 120 · **Weapons:** OneHandSword, Magictool, Knuckle, ShortSword, Halberd · **Requires:** การร่ายรำอันเฉียบคม · **Flags:** NoMarketSearch · **Client class:** `EnchantedDanceAction`

> การร่ายรำอันทรงเสน่ห์ที่ทำให้ลุ่มหลง
> ลดอัตราความเสถียรของมอนสเตอร์
> ผลลัพธ์จะเพิ่มขึ้นถ้าเริ่มร่ายรำใหม่อีกครั้งก่อนผลจะสิ้นสุดลงเพียงเล็กน้อย
> ถ้าเริ่มใช้ใหม่เร็วเกินไป จะเป็นการลดผลที่ได้รับจากผลของการร่ายรำอื่น

**How it works**

- Support skill of the ダンサー tree (tier 3, max Lv 120); usable with OneHandSword, Magictool, Knuckle, ShortSword, Halberd.
- It installs a buff on the caster.
- It installs a buff on other players / the party.
- Buffs:
  - `EnchantedDanceBuf`: lasts `time` s

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionHit` — when the attack connects: 1 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 806
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): installs the dance buff on the caster — `AddSelfDanceBuf(PlayerAttackBase.get_ActionID(), Lv)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**Buff values** (every recovered field; durations in seconds)

**Buff `EnchantedDanceBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `time` s
- `Value` = `(((5 - (danceLv)) * ((((Lv + 2) // 3) + 2))) + -(((Lv << 1) + lv)))` _(when BuffEffectActive ne 0)_
- `Count` = `(danceLv)` _(when BuffEffectActive ne 0)_
- Buff fields set in the constructor (all recovered):
  - `Count` = `danceLv`
  - `Max` = `10` = 10
  - `stableRate` = `((Lv << 1) + lv)` → Lv1..10 [3, 6, 9, 12, 15, 18, 21, 24, 27, 30]
  - `variableValue` = `(((Lv + 2) // 3) + 2)` → Lv1..10 [3, 3, 3, 4, 4, 4, 5, 5, 5, 6]
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0

Parameter meanings (inferred from the `SkillBufferId` names):

- `Count`: stack / hit counter
- `Value`: generic value (meaning set by the code that reads the buff)

_Raw recovered data (every method item): [trees/DancerSkill.md](../trees/DancerSkill.md) — uid 806_

---

### วิจิตรธรรมชาติ (BeautiesOfNature) · uid 807

<img src="../../icons/sk_807.png" width="40" alt="icon"> 
**Tree:** ダンサー (`DancerSkill`, tier 3) · **Type:** Attack · **Max Lv:** 120 · **Weapons:** OneHandSword, Magictool, Knuckle, ShortSword, Halberd · **Requires:** ตั้งรับอย่างสง่างาม · **Flags:** NoMarketSearch · **Client class:** `BeautiesOfNatureAction`

> การย่อโจมตีราวการร่ายรำอันงดงาม
> สร้างความเสียหายโดยรอบ ตอนสกิลสิ้นสุด
> จะฟื้นฟู HP ให้พวกพ้องที่อยู่ใกล้เคียง
> ได้รับพลังต้านทานผงะและล้มคว่ำตามสกิลเลเวล

**How it works**

- Attack skill of the ダンサー tree (tier 3, max Lv 120); usable with OneHandSword, Magictool, Knuckle, ShortSword, Halberd.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×1.57 at Lv1 to 2.25 at Lv10; flat damage +100
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Buffs:
  - `BeautiesOfNatureBuf`: marker buff (no parameters; other code tests whether it is present)
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(3)`
- **Attack range** (`attackRange`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance((int((Lv * 0.3)) + 3))`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 5 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionStart` — when the cast starts: 2 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 4 tpl, 1 call, 1 info
- `.<>c__DisplayClass23_0::<ActionStart>b__0` — skill-specific method: 1 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 1.57 | 1.65 | 1.72 | 1.8 | 1.87 | 1.95 | 2.02 | 2.1 | 2.17 | 2.25 |
| Flat dmg + | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(target.ExpDefSkill / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv * 30) + 600) >> 2)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 807
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): constructs `BeautiesOfNatureBuf` — `.ctor(Lv)`
  - when `!PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction)`
- `ActionStart` (when the cast starts): adds the caster's buff of `new BeautiesOfNatureBuf` — `AddSelfBuffer(new BeautiesOfNatureBuf, Id)`
  - when `!PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction)`
- `calcPlayerToMobDamage` (damage calculation against a monster): adds the buff-provided flat damage to the template — `SetBufferConstantDamage(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)`
- `.<>c__DisplayClass23_0::<ActionStart>b__0` (method): removes the caster's buff of skill 807 (BeautiesOfNature) — `RemoveSelfBuffer(807)`

**Other recovered parameters**

- **Attack range** (`attackRange`): `MathUtil.DisplayMeterToDistance((int((Lv * 0.3)) + 3))`

**Buff values** (every recovered field; durations in seconds)

**Buff `BeautiesOfNatureBuf`**
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:BeautiesOfNatureBuf$$.ctor<-BeautiesOfNatureAction$$ActionStart` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

_Raw recovered data (every method item): [trees/DancerSkill.md](../trees/DancerSkill.md) — uid 807_

---
