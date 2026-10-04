# ダンサー (`DancerSkill`)

7 entries. See ../README.md for how to read these blocks.

### การร่ายรำแห่งภูตพราย (FairyDance) · uid 801

<img src="../../icons/sk_801.png" width="40" alt="icon"> 
**Tree:** ダンサー (`DancerSkill`, tier 1) · **Type:** Support · **Max Lv:** 1 · **Weapons:** OneHandSword, Magictool, Knuckle, ShortSword, Halberd · **Flags:** NoMarketSearch · **Client class:** `FairyDanceAction`

> การร่ายรำอันพริ้วไหวราวภูตพราย
> ลดอัตราความแม่นของมอนสเตอร์
> ผลลัพธ์จะเพิ่มขึ้นถ้าเริ่มร่ายรำใหม่อีกครั้งก่อนผลจะสิ้นสุดลงเพียงเล็กน้อย
> ถ้าเริ่มใช้ใหม่เร็วเกินไป จะเป็นการลดผลที่ได้รับจากผลของการร่ายรำอื่น

**Role:** buff (self) · buff (party / others)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 801

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`ActionHit`** (2 paths)

- calls `SkillBufferManager.AddSelfDanceBuf` = `AddSelfDanceBuf(PlayerAttackBase.get_ActionID(), Lv)` — when UnityEngine.Object.op_Inequality(actarAction)

</details>

**Buffs**

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

---

### การร่ายรำอันรุนแรง (PassionDance) · uid 802

<img src="../../icons/sk_802.png" width="40" alt="icon"> 
**Tree:** ダンサー (`DancerSkill`, tier 1) · **Type:** Support · **Max Lv:** 1 · **Weapons:** OneHandSword, Magictool, Knuckle, ShortSword, Halberd · **Requires:** การร่ายรำแห่งภูตพราย · **Flags:** NoMarketSearch · **Client class:** `PassionDanceAction`

> การร่ายรำที่แสดงออกถึงความรู้สึกอย่างรุนแรง
> จะทำให้ทำลายชิ้นส่วนของมอนสเตอร์ได้ง่ายขึ้น
> ผลลัพธ์จะเพิ่มขึ้นถ้าเริ่มร่ายรำใหม่อีกครั้งก่อนผลจะสิ้นสุดลงเพียงเล็กน้อย
> ถ้าเริ่มใช้ใหม่เร็วเกินไป จะเป็นการลดผลที่ได้รับจากผลของการร่ายรำอื่น

**Role:** buff (self) · buff (party / others)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 802

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`ActionHit`** (2 paths)

- calls `SkillBufferManager.AddSelfDanceBuf` = `AddSelfDanceBuf(PlayerAttackBase.get_ActionID(), Lv)` — when UnityEngine.Object.op_Inequality(actarAction)

</details>

**Buffs**

**Buff `PassionDanceBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `time` s
- `Value` = `((((danceLv) - 5) * ((((Lv hi 5 ? Lv : 5) + lv) - 4))) + ((Lv << 1)))` _(when BuffEffectActive ne 0)_
- Buff fields set in the constructor (all recovered):
  - `Count` = `danceLv`
  - `partsAttck` = `(Lv << 1)` = 2
  - `variableValue` = `(((Lv hi 5 ? Lv : 5) + lv) - 4)` = 2
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

---

### การร่ายรำให้กำลังใจ (SupportDance) · uid 803

<img src="../../icons/sk_803.png" width="40" alt="icon"> 
**Tree:** ダンサー (`DancerSkill`, tier 1) · **Type:** Support · **Max Lv:** 1 · **Weapons:** OneHandSword, Magictool, Knuckle, ShortSword, Halberd · **Requires:** การร่ายรำแห่งภูตพราย · **Flags:** NoMarketSearch · **Client class:** `SupportDanceAction`

> การร่ายรำเพื่อสร้างขวัญกำลังใจให้พวกพ้อง
> ฟื้นฟู MP ได้ทันที
> ผลลัพธ์จะเพิ่มขึ้นถ้าเริ่มร่ายรำใหม่อีกครั้งก่อนผลจะสิ้นสุดลงเพียงเล็กน้อย
> ถ้าเริ่มใช้ใหม่เร็วเกินไป จะเป็นการลดผลที่ได้รับจากผลของการร่ายรำอื่น

**Role:** buff (self) · buff (party / others)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 803

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`ActionHit`** (2 paths)

- calls `SkillBufferManager.AddSelfDanceBuf` = `AddSelfDanceBuf(PlayerAttackBase.get_ActionID(), Lv)` — when UnityEngine.Object.op_Inequality(actarAction)

</details>

**Buffs**

**Buff `SupportDanceBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `time` s
- Buff fields set in the constructor (all recovered):
  - `Count` = `danceLv`
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

---

### การร่ายรำอันเฉียบคม (SharpDance) · uid 804

<img src="../../icons/sk_804.png" width="40" alt="icon"> 
**Tree:** ダンサー (`DancerSkill`, tier 2) · **Type:** Support · **Max Lv:** 60 · **Weapons:** OneHandSword, Magictool, Knuckle, ShortSword, Halberd · **Requires:** การร่ายรำอันรุนแรง · **Flags:** NoMarketSearch · **Client class:** `SharpDanceAction`

> การร่ายรำอย่างอ่อนช้อยเฉียบคม
> ลดอัตราการหลบหลีกของมอนสเตอร์
> ผลลัพธ์จะเพิ่มขึ้นถ้าเริ่มร่ายรำใหม่อีกครั้งก่อนผลจะสิ้นสุดลงเพียงเล็กน้อย
> ถ้าเริ่มใช้ใหม่เร็วเกินไป จะเป็นการลดผลที่ได้รับจากผลของการร่ายรำอื่น

**Role:** buff (self) · buff (party / others)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 804

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`ActionHit`** (2 paths)

- calls `SkillBufferManager.AddSelfDanceBuf` = `AddSelfDanceBuf(PlayerAttackBase.get_ActionID(), Lv)` — when UnityEngine.Object.op_Inequality(actarAction)

</details>

**Buffs**

**Buff `SharpDanceBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `time` s
- `Value` = `(((5 - (danceLv)) * (((Lv + 2) // 3))) + -(Lv))` _(when BuffEffectActive ne 0)_
- Buff fields set in the constructor (all recovered):
  - `Count` = `danceLv`
  - `necessaryHitRate` = `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `variableValue` = `((Lv + 2) // 3)` → Lv1..10 [1, 1, 1, 2, 2, 2, 3, 3, 3, 4]
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

<details><summary>Effect applied in `HuntingOneNormalAttackAction$$calcPlayerToMobDamage` (300 guarded paths, truncated)</summary>

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

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `CallGolemNormalAttackAction$$calcPlayerToMobDamage (TryGetBuf)`
- `HuntingOneNormalAttackAction$$calcPlayerToMobDamage (TryGetBuf)`
- `SummonDemonicAttackAction$$calcPlayerToMobDamage (TryGetBuf)`
- `SummonDemonicSpecialAttack$$calcPlayerToMobDamage (TryGetBuf)`

---

### ตั้งรับอย่างสง่างาม (ElegantStance) · uid 805

<img src="../../icons/sk_805.png" width="40" alt="icon"> 
**Tree:** ダンサー (`DancerSkill`, tier 2) · **Type:** Buffer · **Max Lv:** 60 · **Weapons:** OneHandSword, Magictool, Knuckle, ShortSword, Halberd · **Flags:** NoMarketSearch · **Client class:** `ElegantStanceAction`

> ใช้พัดตั้งรับและหลบหลีกการโจมตี
> ระหว่างตั้งรับความเสียหายที่ได้รับจะลดน้อยลง
> ติดสถานะไร้พ่ายให้ตัวเอง
> ถ้าตัวเองติดสถานะผิดปกติอยู่จะไม่สามารถตั้งรับได้อย่างงดงาม

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 805

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `timer` = `2` = 2
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `timer` = `2` = 2

**`ActionSkillEvent`** (15 paths)

- set `timer` = `0` = 0 — when !UnityEngine.Object.op_Equality(actarAction) AND (timer - UnityEngine.Time.get_deltaTime()) ls 0 AND UnityEngine.Object.op_Inequality(actarAction) AND holdOff eq 0 AND param eq 2 AND param ne 3 AND param ne 4 AND timer gt 0 OR !UnityEngine.Object.op_Equality(actarAction) AND !UnityEngine.Object.op_Inequality(actarAction) AND (timer - UnityEngine.Time.get_deltaTime()) ls 0 AND holdOff eq 0 AND param eq 2 AND param ne 3 AND param ne 4 AND timer gt 0 OR (timer - UnityEngine.Time.get_deltaTime()) ls 0 AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) AND holdOff eq 0 AND param eq 2 AND param ne 3 AND param ne 4 AND timer gt 0
- set `holdOff` = `1` = 1 — when UnityEngine.Object.op_Inequality(actarAction) AND holdOff eq 0 AND param eq 4 OR !UnityEngine.Object.op_Equality(actarAction) AND (timer - UnityEngine.Time.get_deltaTime()) ls 0 AND UnityEngine.Object.op_Inequality(actarAction) AND holdOff eq 0 AND param eq 2 AND param ne 3 AND param ne 4 AND timer gt 0 OR (timer - UnityEngine.Time.get_deltaTime()) ls 0 AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) AND holdOff eq 0 AND param eq 2 AND param ne 3 AND param ne 4 AND timer gt 0
- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(805)` — when UnityEngine.Object.op_Inequality(actarAction) AND holdOff eq 0 AND param eq 4 OR !UnityEngine.Object.op_Equality(actarAction) AND (timer - UnityEngine.Time.get_deltaTime()) ls 0 AND UnityEngine.Object.op_Inequality(actarAction) AND holdOff eq 0 AND param eq 2 AND param ne 3 AND param ne 4 AND timer gt 0 OR (timer - UnityEngine.Time.get_deltaTime()) ls 0 AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) AND holdOff eq 0 AND param eq 2 AND param ne 3 AND param ne 4 AND timer gt 0
- set `timer` = `(timer - UnityEngine.Time.get_deltaTime())` — when (timer - UnityEngine.Time.get_deltaTime()) hi 0 AND holdOff eq 0 AND param eq 2 AND param ne 3 AND param ne 4 AND timer gt 0

**`OtherPlayerSkillEventReceive`** (1 path)

- set `timer` = `0` = 0
- set `holdOff` = `1` = 1

**`ActionHit`** (2 paths)

- calls `ElegantStanceBuf..ctor` = `.ctor(Lv)` — when UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new ElegantStanceBuf, Id)` — when UnityEngine.Object.op_Inequality(actarAction)

</details>

**Buffs**

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

<details><summary>Effect applied in `ElegantStanceAction$$Damaged` (3 guarded paths)</summary>

- always
  - returns `?blr`
  - calls `virtual CharacterActionManagerBase.get_IsLocalDead`
- always
  - returns `SkillActionBase.op_Inequality(CharacterActionManagerBase.get_IsLocalDead(), 0, 0, ?x3)`
  - calls `virtual CharacterActionManagerBase.get_IsLocalDead`
- always
  - returns `SkillBufferManager.ContainsBuffer(?blr, 805, 0, ?x3)`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `ElegantStanceAction$$Damaged (ContainsBuffer)`
- `MercenaryActionManager$$Damaged (ContainsBuffer)`
- `PlayerActionManager$$Damaged (ContainsBuffer)`

---

### การร่ายรำอันทรงเสน่ห์ (EnchantedDance) · uid 806

<img src="../../icons/sk_806.png" width="40" alt="icon"> 
**Tree:** ダンサー (`DancerSkill`, tier 3) · **Type:** Support · **Max Lv:** 120 · **Weapons:** OneHandSword, Magictool, Knuckle, ShortSword, Halberd · **Requires:** การร่ายรำอันเฉียบคม · **Flags:** NoMarketSearch · **Client class:** `EnchantedDanceAction`

> การร่ายรำอันทรงเสน่ห์ที่ทำให้ลุ่มหลง
> ลดอัตราความเสถียรของมอนสเตอร์
> ผลลัพธ์จะเพิ่มขึ้นถ้าเริ่มร่ายรำใหม่อีกครั้งก่อนผลจะสิ้นสุดลงเพียงเล็กน้อย
> ถ้าเริ่มใช้ใหม่เร็วเกินไป จะเป็นการลดผลที่ได้รับจากผลของการร่ายรำอื่น

**Role:** buff (self) · buff (party / others)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 806

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`ActionHit`** (2 paths)

- calls `SkillBufferManager.AddSelfDanceBuf` = `AddSelfDanceBuf(PlayerAttackBase.get_ActionID(), Lv)` — when UnityEngine.Object.op_Inequality(actarAction)

</details>

**Buffs**

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

---

### วิจิตรธรรมชาติ (BeautiesOfNature) · uid 807

<img src="../../icons/sk_807.png" width="40" alt="icon"> 
**Tree:** ダンサー (`DancerSkill`, tier 3) · **Type:** Attack · **Max Lv:** 120 · **Weapons:** OneHandSword, Magictool, Knuckle, ShortSword, Halberd · **Requires:** ตั้งรับอย่างสง่างาม · **Flags:** NoMarketSearch · **Client class:** `BeautiesOfNatureAction`

> การย่อโจมตีราวการร่ายรำอันงดงาม
> สร้างความเสียหายโดยรอบ ตอนสกิลสิ้นสุด
> จะฟื้นฟู HP ให้พวกพ้องที่อยู่ใกล้เคียง
> ได้รับพลังต้านทานผงะและล้มคว่ำตามสกิลเลเวล

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 1.57 | 1.65 | 1.72 | 1.8 | 1.87 | 1.95 | 2.02 | 2.1 | 2.17 | 2.25 |
| Flat dmg + | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Role:** attack (deals damage) · buff (self)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(100)`
- `SkillRate` multiplies by (adds into): `(((((Lv * 30) + 600) >> 2)) / 100)`
- `ExpRate` sets: `(target.ExpDefSkill / 100)` | `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**Mechanics recovered from code**

- **Attack range** (`attackRange`): `MathUtil.DisplayMeterToDistance((int((Lv * 0.3)) + 3))`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 807

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(3)`
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `fixAddDamage` = `100` = 100
- set `skillRate` = `(((Lv * 30) + 600) >> 2)` → Lv1..10: [157, 165, 172, 180, 187, 195, 202, 210, 217, 225]
- set `attackRange` = `MathUtil.DisplayMeterToDistance((int((Lv * 0.3)) + 3))`

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`ActionStart`** (3 paths)

- calls `BeautiesOfNatureBuf..ctor` = `.ctor(Lv)` — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new BeautiesOfNatureBuf, Id)` — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction)

**`calcPlayerToMobDamage`** (4 paths)

- set `Element` = `PlayerAttackBase.GetWeaponElementType(this, playerAction, mobAction)`
- template `SetRate[ExpRate]` = `(target.ExpDefSkill / 100)`
- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- calls `PlayerAttackBase.SetBufferConstantDamage` = `SetBufferConstantDamage(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4)`
- info `templates` = `1`
- template `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**`.<>c__DisplayClass23_0::<ActionStart>b__0`** (1 path)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(807)`

</details>

**Buffs**

**Buff `BeautiesOfNatureBuf`**
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:BeautiesOfNatureBuf$$.ctor<-BeautiesOfNatureAction$$ActionStart` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

---
