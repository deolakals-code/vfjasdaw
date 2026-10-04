# ナイトスキル (`KnightSkill`)

15 entries. See ../README.md for how to read these blocks.

### แอสเซาต์แอคแทค (AssaultAttack) · uid 513

<img src="../../icons/sk_513.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 1) · **Type:** Attack · **Max Lv:** 15 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `AssaultAttackAction`

> จู่โจมอย่างรวดเร็วและดันศัตรูออกไป
> มีโอกาสทำให้เป้าหมาย[เชื่องช้า]

<details><summary>In-game level notes</summary>

- Lv17: *พลัง+25 *พลังสกิล+50 *อัตราติดผลักกระเด็น+50%

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [subWeapon == Shield] | 0.6 | 0.7 | 0.8 | 0.9 | 1 | 1.1 | 1.2 | 1.3 | 1.4 | 1.5 |
| SkillRate × [subWeapon != Shield] | 0.35 | 0.45 | 0.55 | 0.65 | 0.75 | 0.85 | 0.95 | 1.05 | 1.15 | 1.25 |
| Flat dmg + [subWeapon == Shield] | 55 | 60 | 65 | 70 | 75 | 80 | 85 | 90 | 95 | 100 |
| Flat dmg + [subWeapon != Shield] | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((((((Lv + (Lv << 2)) << 1) + 25) + 25) + gemCart(1002[4]))) / 100)` — (+0x109 & 2) ne 0 AND Lv eq 10 AND UnityEngine.Object.op_Inequality(actarAction)

**Role:** attack (deals damage) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv + (Lv << 2)) + 50))`
- `SkillRate` multiplies by (adds into): `(((((((Lv + (Lv << 2)) << 1) + 25) + 25) + gemCart(1002[4]))) / 100)`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 513

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (2 paths)

- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(6)`
- set `fixAddDamage` = `((Lv + (Lv << 2)) + 50)` → Lv1..10: [55, 60, 65, 70, 75, 80, 85, 90, 95, 100] — when subWeapon == Shield
- set `slowRate` = `0` = 0
- set `skillRate` = `(((((Lv + (Lv << 2)) << 1) + 25) + 25) + gemCart(1002[4]))` — when subWeapon == Shield
- set `knockbackRate` = `0` = 0
- set `fixAddDamage` = `(Lv + (Lv << 2))` → Lv1..10: [5, 10, 15, 20, 25, 30, 35, 40, 45, 50] — when subWeapon != Shield
- set `skillRate` = `((((Lv + (Lv << 2)) << 1) + 25) + gemCart(1002[4]))` — when subWeapon != Shield

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`

**`ActionPreparation`** (5 paths)

- set `skillRate` = `(skillRate + KnightWill.GetParam(PlayerStatusBase.get_SkillManager().SkillMasteryList[520], 0, (WeaponType eq 17 ? 1 : 0)))` — when (+0x109 & 2) ne 0 AND Lv eq 10 AND UnityEngine.Object.op_Inequality(actarAction)

**`calcPlayerToMobDamage`** (16 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(11, slowRate, playerAction)` — when PlayerAttackBase.checkAbnormalPercent(this, 11, slowRate, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 4, knockbackRate, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 4, knockbackRate, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 11, slowRate, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 11, slowRate, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 4, knockbackRate, playerAction)
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(11, 0)` — when PlayerAttackBase.checkAbnormalPercent(this, 11, slowRate, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 4, knockbackRate, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 4, knockbackRate, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 11, slowRate, playerAction)
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(4, knockbackRate, playerAction)` — when PlayerAttackBase.checkAbnormalPercent(this, 11, slowRate, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 4, knockbackRate, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 4, knockbackRate, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 11, slowRate, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 11, slowRate, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 4, knockbackRate, playerAction)
- info `templates` = `1`

</details>

---

### โพรโวค (Provoke) · uid 514

<img src="../../icons/sk_514.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 1) · **Type:** Special · **Max Lv:** 15 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `ProvokeAction`

> ยั่วยุศัตรูให้เข้ามาโจมตีผู้ใช้

**Role:** utility / system action

This action never changes monster proration: ExpType None: no proration slot.

**Mechanics recovered from code**

- **MP cost** (`mp`): `200` = 200 _(when Lv hi 5 AND Lv hi 9)_; `300` = 300 _(when Lv hi 5 AND Lv ls 9)_; `400` = 400 _(when Lv ls 5)_

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 514

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (3 paths)

- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `mp` = `200` = 200 — when Lv hi 5 AND Lv hi 9
- set `ActionRange` = `MathUtil.DisplayMeterToDistance(8)`
- set `mp` = `300` = 300 — when Lv hi 5 AND Lv ls 9
- set `mp` = `400` = 400 — when Lv ls 5

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`

**`ActionPreparation`** (2 paths)

- set `SkillIndividualFlag` = `(SkillIndividualFlag | 256)` — when MobManager.IsAnyTarget(TargetableListManagerBase<MobManager>.get_Instance(), UnityEngine.Component.get_gameObject(actarAction))

**`OnInheritance`** (1 path)

- set `IsInheritance` = `1` = 1

</details>

---

### ไนท์สแตนซ์ (KnightStance) · uid 521

<img src="../../icons/sk_521.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 1) · **Type:** Buffer · **Max Lv:** 15 · **Weapons:** OneHandSword · **Flags:** StarGem · **Client class:** `KnightStanceAction`

> คำสาบานของอัศวิน
> เพิ่ม VIT และเฮทของตัวเองเป็นเวลา 6 นาที
> ระหว่างเอฟเฟกต์มีผลอยู่ถ้ามีเฮทที่ตรงกัน
> อัตราความเสียหายที่ได้รับจากมอนสเตอร์จะลดลงเล็กน้อย

<details><summary>In-game level notes</summary>

- Lv17: *เฮทเพิ่มขึ้นUP *เพิ่มพลังการลดอัตราความเสียหาย *ระหว่างใช้[วอร์คราย]จะเพิ่มความต้านทานหวาดกลัว

</details>

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 521

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (8 paths)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(521)` — when UnityEngine.Object.op_Inequality(actarAction) AND status.MaxHp le 0 OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 524, 1) lt 1 AND UnityEngine.Object.op_Inequality(actarAction) AND status.MaxHp le 0 OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 524, 1) lt 1 AND UnityEngine.Object.op_Inequality(actarAction) AND status.MaxHp gt 0
- calls `KnightStanceBuf..ctor` = `.ctor(Lv, PlayerActionManagerBase.get_PlayerStatus())` — when UnityEngine.Object.op_Inequality(actarAction) AND status.MaxHp le 0 OR UnityEngine.Object.op_Inequality(actarAction) AND status.MaxHp gt 0 OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 524, 1) lt 1 AND UnityEngine.Object.op_Inequality(actarAction) AND status.MaxHp le 0
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new KnightStanceBuf, Id)` — when UnityEngine.Object.op_Inequality(actarAction) AND status.MaxHp le 0 OR UnityEngine.Object.op_Inequality(actarAction) AND status.MaxHp gt 0 OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 524, 1) lt 1 AND UnityEngine.Object.op_Inequality(actarAction) AND status.MaxHp le 0

</details>

**Buffs**

**Buff `KnightStanceBuf`**
- Buff hook methods: `CalcCount`, `GetFearResistValue`, `SyncDamageStack`
- Duration: `360` s
- `RateDamageResist` = `((int((Lv * 0.5))) << (EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator) eq 17 ? 1 : 0))` _(when BuffEffectActive ne 0)_
- `Value` = `stack` _(when BuffEffectActive ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| HateRate | 3 | 6 | 9 | 12 | 15 | 18 | 21 | 24 | 27 | 30 |
| HateRate | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |

- Buff fields set in the constructor (all recovered):
  - `countViewType` = `7` = 7
  - `status` = `status`
  - `maxHp` = `status.MaxHp`
  - `damageResist` = `int((Lv * 0.5))` → Lv1..10 [0, 1, 1, 2, 2, 3, 3, 4, 4, 5]
  - `hateRate` = `(Lv << 1)` → Lv1..10 [2, 4, 6, 8, 10, 12, 14, 16, 18, 20]
- Hook `Updata`: `stack`=(stack lt status.MaxHp ? stack : status.MaxHp); `maxHp`=status.MaxHp; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
- Hook `SyncDamageStack`: `stack`=serverStack
- Hook `CalcCount`: `Count`=((int(((stack * 100) / maxHp)) lt 100 ? int(((stack * 100) / maxHp)) : 100) gt 1 ? (int(((stack * 100) / maxHp)) lt 100 ? int(((stack * 100) / maxHp)) : 100) : 1); `countViewType`=11; `Count`=0; `countViewType`=7
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:KnightStanceBuf$$.ctor<-KnightStanceAction$$ActionHit` (no direct constructor call in the skill's own code).
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

<details><summary>Effect applied in `KnightHeal$$Damaged` (11 guarded paths)</summary>

- when `TryGetValue.out2() ne 0`
  - returns `UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<object>(actor, meta(0x3973fb0, Method$UnityEngine.GameObject.GetComponent<MobActionManagerBase>()), ?x2, ?x3)), UnityEngine.Component.get_gameObject(playerAction, 0, ?x2, ?x3), 0, ?x3)`
  - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.GameObject$$GetComponent<object>`, `interface MobActionManagerBase.get_Target`, `UnityEngine.Component$$get_gameObject`
- when `TryGetValue.out2() ne 0`
  - returns `UnityEngine.Object.op_Equality([[[playerAction+0x30]+0x48]+0x18], actor, 0, ?x3)`
  - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
- when `TryGetValue.out2() ne 0`
  - returns `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType([?blr+0x20], 0, ?mi, ?x3)`
  - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
- when `TryGetValue.out2() eq 0`
  - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `0x165db84`
- always
  - returns `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType([?blr+0x20], 0, ?x2, ?x3)`
  - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
- when `TryGetValue.out2() ne 0`
  - returns `UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<object>(actor, meta(0x3973fb0, Method$UnityEngine.GameObject.GetComponent<MobActionManagerBase>()), ?x2, ?x3)), UnityEngine.Component.get_gameObject(playerAction, 0, ?x2, ?x3), 0, ?x3)`
  - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.GameObject$$GetComponent<object>`, `interface MobActionManagerBase.get_Target`, `UnityEngine.Component$$get_gameObject`
- when `TryGetValue.out2() ne 0`
  - returns `UnityEngine.Object.op_Equality([[[playerAction+0x30]+0x48]+0x18], actor, 0, ?x3)`
  - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
- when `TryGetValue.out2() ne 0`
  - returns `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType([?blr+0x20], 0, ?mi, ?x3)`
  - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`

</details>

<details><summary>Effect applied in `MobaPlayerSecondaryStatus$$get_Vit` (3 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `(MobaPlayerSecondaryStatus.CalcBaseSecondaryStatus(this, [CharacterActionManagerBase.get_IsLocalDead()+0x1c], 8, 3) + [TryGetBuf.out2()+0x10])`
  - calls `virtual CharacterActionManagerBase.get_IsLocalDead`, `MobaPlayerSecondaryStatus$$CalcBaseSecondaryStatus`, `virtual CharacterActionManagerBase.get_IsValid`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual CharacterActionManagerBase.get_IsLocalDead`, `MobaPlayerSecondaryStatus$$CalcBaseSecondaryStatus`, `virtual CharacterActionManagerBase.get_IsValid`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-24), 0) & 1) eq 0`
  - returns `MobaPlayerSecondaryStatus.CalcBaseSecondaryStatus(this, [CharacterActionManagerBase.get_IsLocalDead()+0x1c], 8, 3)`
  - calls `virtual CharacterActionManagerBase.get_IsLocalDead`, `MobaPlayerSecondaryStatus$$CalcBaseSecondaryStatus`, `virtual CharacterActionManagerBase.get_IsValid`

</details>

<details><summary>Effect applied in `KnightStanceAction$$ActionHit` (7 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 521, stkp(-72), 0) & 1) ne 0` AND `SkillLv(524) ge 1` AND `TryGetBuf.out2() ne 0` AND `IPlayerStatusCalculator.get_MaxHp(?blr) le 0`
  - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 521, 0, ?x3)`
  - calls `SkillActionBase$$ActionHit`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryHp`, `SkillBufferManager$$RemoveSelfBuffer`, `0x165db78`
- when `(SkillBufferManager.TryGetBuf(?blr, 521, stkp(-72), 0) & 1) ne 0` AND `SkillLv(524) ge 1` AND `TryGetBuf.out2() ne 0` AND `IPlayerStatusCalculator.get_MaxHp(?blr) gt 0`
  - returns `IPlayerStatusCalculator.get_MaxHp(?blr)`
  - calls `SkillActionBase$$ActionHit`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryHp`, `SkillBufferManager$$RemoveSelfBuffer`, `0x165db78`
- when `(SkillBufferManager.TryGetBuf(?blr, 521, stkp(-72), 0) & 1) ne 0` AND `SkillLv(524) ge 1` AND `TryGetBuf.out2() eq 0`
  - calls `SkillActionBase$$ActionHit`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(?blr, 521, stkp(-72), 0) & 1) ne 0` AND `SkillLv(524) lt 1` AND `IPlayerStatusCalculator.get_MaxHp(?blr) le 0`
  - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 521, 0, ?x3)`
  - calls `SkillActionBase$$ActionHit`, `SkillBufferManager$$RemoveSelfBuffer`, `0x165db78`, `KnightStanceBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `interface IPlayerStatusCalculator.get_MaxHp`, `SkillBufferManager$$RemoveSelfBuffer`
- when `(SkillBufferManager.TryGetBuf(?blr, 521, stkp(-72), 0) & 1) ne 0` AND `SkillLv(524) lt 1` AND `IPlayerStatusCalculator.get_MaxHp(?blr) gt 0`
  - returns `IPlayerStatusCalculator.get_MaxHp(?blr)`
  - calls `SkillActionBase$$ActionHit`, `SkillBufferManager$$RemoveSelfBuffer`, `0x165db78`, `KnightStanceBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `interface IPlayerStatusCalculator.get_MaxHp`
- when `(SkillBufferManager.TryGetBuf(?blr, 521, stkp(-72), 0) & 1) eq 0` AND `IPlayerStatusCalculator.get_MaxHp(?blr) le 0`
  - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 521, 0, ?x3)`
  - calls `SkillActionBase$$ActionHit`, `0x165db78`, `KnightStanceBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `interface IPlayerStatusCalculator.get_MaxHp`, `SkillBufferManager$$RemoveSelfBuffer`
- when `(SkillBufferManager.TryGetBuf(?blr, 521, stkp(-72), 0) & 1) eq 0` AND `IPlayerStatusCalculator.get_MaxHp(?blr) gt 0`
  - returns `IPlayerStatusCalculator.get_MaxHp(?blr)`
  - calls `SkillActionBase$$ActionHit`, `0x165db78`, `KnightStanceBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `interface IPlayerStatusCalculator.get_MaxHp`

</details>

<details><summary>Effect applied in `PlayerActionManager$$DamagedKnightHeal` (13 guarded paths)</summary>

- when `TryGetValue.out2() ne 0`
  - returns `System.Math.Max(1, int((([damageData+0x84] * ((UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<object>(actor, meta(0x3973fb0, Method$UnityEngine.GameObject.GetComponent<MobActionManagerBase>()), ?x2, ?x3)), UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), 0, ?x3) & 1) ne 0 ? (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() << 1)) : CharacterActionManagerBase.get_Size())) * 0.01)), 0, ?x3)`
  - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.GameObject$$GetComponent<object>`, `interface MobActionManagerBase.get_Target`, `UnityEngine.Component$$get_gameObject`, `System.Math$$Max`
- when `TryGetValue.out2() ne 0`
  - returns `System.Math.Max(1, int((([damageData+0x84] * CharacterActionManagerBase.get_Size()) * 0.01)), 0, ?x3)`
  - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `System.Math$$Max`
- when `TryGetValue.out2() ne 0`
  - returns `System.Math.Max(1, int((([damageData+0x84] * CharacterActionManagerBase.get_Size()) * 0.01)), 0, ?x3)`
  - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `System.Math$$Max`
- when `TryGetValue.out2() ne 0`
  - returns `System.Math.Max(1, int((([damageData+0x84] * CharacterActionManagerBase.get_Size()) * 0.01)), 0, ?x3)`
  - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `System.Math$$Max`
- when `TryGetValue.out2() eq 0`
  - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `0x165db84`
- always
  - returns `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType([?blr+0x20], 0, ?x2, ?x3)`
  - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
- when `TryGetValue.out2() ne 0`
  - returns `System.Math.Max(1, int((([damageData+0x84] * ((UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<object>(actor, meta(0x3973fb0, Method$UnityEngine.GameObject.GetComponent<MobActionManagerBase>()), ?x2, ?x3)), UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), 0, ?x3) & 1) ne 0 ? (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() << 1)) : CharacterActionManagerBase.get_Size())) * 0.01)), 0, ?x3)`
  - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.GameObject$$GetComponent<object>`, `interface MobActionManagerBase.get_Target`, `UnityEngine.Component$$get_gameObject`, `System.Math$$Max`
- when `TryGetValue.out2() ne 0`
  - returns `System.Math.Max(1, int((([damageData+0x84] * CharacterActionManagerBase.get_Size()) * 0.01)), 0, ?x3)`
  - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `System.Math$$Max`

</details>

<details><summary>Effect applied in `PlayerSecondaryStatus$$get_Vit` (3 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `(PlayerSecondaryStatus.CalcBaseSecondaryStatus(this, [CharacterActionManagerBase.get_IsLocalDead()+0x1c], 8, 3) + [TryGetBuf.out2()+0x10])`
  - calls `virtual CharacterActionManagerBase.get_IsLocalDead`, `PlayerSecondaryStatus$$CalcBaseSecondaryStatus`, `virtual CharacterActionManagerBase.get_IsValid`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `virtual CharacterActionManagerBase.get_IsLocalDead`, `PlayerSecondaryStatus$$CalcBaseSecondaryStatus`, `virtual CharacterActionManagerBase.get_IsValid`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-24), 0) & 1) eq 0`
  - returns `PlayerSecondaryStatus.CalcBaseSecondaryStatus(this, [CharacterActionManagerBase.get_IsLocalDead()+0x1c], 8, 3)`
  - calls `virtual CharacterActionManagerBase.get_IsLocalDead`, `PlayerSecondaryStatus$$CalcBaseSecondaryStatus`, `virtual CharacterActionManagerBase.get_IsValid`

</details>

<details><summary>Effect applied in `PhotonListener$$OnActionMobAttack` (52 guarded paths)</summary>

- when `returnCode eq 0` AND `(archetypeType & 255) ne 9` AND `(archetypeType & 255) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-72), 0) & 1) ne 0`
  - returns `MobManager.UpdatePlayerEnemyData(TargetableListManagerBase<object>.get_Instance(meta(0x3974240, Method$TargetableListManagerBase<MobManager>.get_Instance()), ?x1, ?x2, ?x3), [response+0x28], 0, ?x3)`
  - calls `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `GameManager$$UpdatePlayerStatusFromDamage`, `Toram.Common.Actions.ActionAppendData$$Contains`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerStatus`
- when `returnCode eq 0` AND `(archetypeType & 255) ne 9` AND `(archetypeType & 255) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-72), 0) & 1) ne 0`
  - returns `MobManager.UpdatePlayerEnemyData(TargetableListManagerBase<object>.get_Instance(meta(0x3974240, Method$TargetableListManagerBase<MobManager>.get_Instance()), ?x1, ?x2, ?x3), [response+0x28], 0, ?x3)`
  - calls `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `GameManager$$UpdatePlayerStatusFromDamage`, `Toram.Common.Actions.ActionAppendData$$Contains`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerStatus`
- when `returnCode eq 0` AND `(archetypeType & 255) ne 9` AND `(archetypeType & 255) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-72), 0) & 1) ne 0`
  - returns `MobManager.UpdatePlayerEnemyData(TargetableListManagerBase<object>.get_Instance(meta(0x3974240, Method$TargetableListManagerBase<MobManager>.get_Instance()), ?x1, ?x2, ?x3), [response+0x28], 0, ?x3)`
  - calls `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `GameManager$$UpdatePlayerStatusFromDamage`, `Toram.Common.Actions.ActionAppendData$$Contains`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerStatus`
- when `returnCode eq 0` AND `(archetypeType & 255) ne 9` AND `(archetypeType & 255) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-72), 0) & 1) ne 0`
  - returns `MobManager.UpdatePlayerEnemyData(TargetableListManagerBase<object>.get_Instance(meta(0x3974240, Method$TargetableListManagerBase<MobManager>.get_Instance()), ?x1, ?x2, ?x3), [response+0x28], 0, ?x3)`
  - calls `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `GameManager$$UpdatePlayerStatusFromDamage`, `Toram.Common.Actions.ActionAppendData$$Contains`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerStatus`
- when `returnCode eq 0` AND `(archetypeType & 255) ne 9` AND `(archetypeType & 255) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-72), 0) & 1) ne 0`
  - returns `MobManager.UpdatePlayerEnemyData(TargetableListManagerBase<object>.get_Instance(meta(0x3974240, Method$TargetableListManagerBase<MobManager>.get_Instance()), ?x1, ?x2, ?x3), [response+0x28], 0, ?x3)`
  - calls `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `GameManager$$UpdatePlayerStatusFromDamage`, `Toram.Common.Actions.ActionAppendData$$Contains`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerStatus`
- when `returnCode eq 0` AND `(archetypeType & 255) ne 9` AND `(archetypeType & 255) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-72), 0) & 1) ne 0`
  - returns `MobManager.UpdatePlayerEnemyData(TargetableListManagerBase<object>.get_Instance(meta(0x3974240, Method$TargetableListManagerBase<MobManager>.get_Instance()), ?x1, ?x2, ?x3), [response+0x28], 0, ?x3)`
  - calls `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `GameManager$$UpdatePlayerStatusFromDamage`, `Toram.Common.Actions.ActionAppendData$$Contains`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerStatus`
- when `returnCode eq 0` AND `(archetypeType & 255) ne 9` AND `(archetypeType & 255) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-72), 0) & 1) ne 0`
  - returns `MobManager.UpdatePlayerEnemyData(TargetableListManagerBase<object>.get_Instance(meta(0x3974240, Method$TargetableListManagerBase<MobManager>.get_Instance()), ?x1, ?x2, ?x3), [response+0x28], 0, ?x3)`
  - calls `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `GameManager$$UpdatePlayerStatusFromDamage`, `Toram.Common.Actions.ActionAppendData$$Contains`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerStatus`
- when `returnCode eq 0` AND `(archetypeType & 255) ne 9` AND `(archetypeType & 255) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-72), 0) & 1) ne 0`
  - returns `MobManager.UpdatePlayerEnemyData(TargetableListManagerBase<object>.get_Instance(meta(0x3974240, Method$TargetableListManagerBase<MobManager>.get_Instance()), ?x1, ?x2, ?x3), [response+0x28], 0, ?x3)`
  - calls `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `GameManager$$UpdatePlayerStatusFromDamage`, `Toram.Common.Actions.ActionAppendData$$Contains`, `PlayerDataManager$$GetPlayerDataManager`, `PlayerDataManager$$get_PlayerStatus`

</details>

<details><summary>Effect applied in `PlayerSecondaryStatus$$GetDisplayBonusCalcHate` (299 guarded paths, truncated)</summary>

- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 553, stkp(-56), 0) & 1) ne 0`
  - returns `int(frintp((fcvt((((((((((BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 62, 0, ?x3) + (KnightWill.GetParam(TryGetValue.out2(), 5, (EquipItemData.get_SubWeaponItemType(CharacterActionManagerBase.set_DefaultMoveSpeed(), 0, ?x2, ?x3) eq 17 ? 1 : 0), 0) / 100)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) + (CharacterActionManagerBase.get_Size() / 100)) + (DetectionBuf.GetHateBonus(TryGetBuf.out2(), playerStatus, 0, ?x3) * 0.01)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) * (1 - BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 156, 0, ?x3))) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) + 1) * 100)) + -0.5)))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeaponItemType`, `KnightWill$$GetParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 553, stkp(-56), 0) & 1) ne 0`
  - returns `int(frintm((fcvt((((((((((BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 62, 0, ?x3) + (KnightWill.GetParam(TryGetValue.out2(), 5, (EquipItemData.get_SubWeaponItemType(CharacterActionManagerBase.set_DefaultMoveSpeed(), 0, ?x2, ?x3) eq 17 ? 1 : 0), 0) / 100)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) + (CharacterActionManagerBase.get_Size() / 100)) + (DetectionBuf.GetHateBonus(TryGetBuf.out2(), playerStatus, 0, ?x3) * 0.01)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) * (1 - BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 156, 0, ?x3))) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) + 1) * 100)) + 0.5)))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeaponItemType`, `KnightWill$$GetParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 553, stkp(-56), 0) & 1) ne 0`
  - returns `int(frintp((fcvt(((((((((BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 62, 0, ?x3) + (KnightWill.GetParam(TryGetValue.out2(), 5, (EquipItemData.get_SubWeaponItemType(CharacterActionManagerBase.set_DefaultMoveSpeed(), 0, ?x2, ?x3) eq 17 ? 1 : 0), 0) / 100)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) + (CharacterActionManagerBase.get_Size() / 100)) + (DetectionBuf.GetHateBonus(TryGetBuf.out2(), playerStatus, 0, ?x3) * 0.01)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) * (1 - BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 156, 0, ?x3))) + 1) * 100)) + -0.5)))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeaponItemType`, `KnightWill$$GetParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 553, stkp(-56), 0) & 1) ne 0`
  - returns `int(frintm((fcvt(((((((((BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 62, 0, ?x3) + (KnightWill.GetParam(TryGetValue.out2(), 5, (EquipItemData.get_SubWeaponItemType(CharacterActionManagerBase.set_DefaultMoveSpeed(), 0, ?x2, ?x3) eq 17 ? 1 : 0), 0) / 100)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) + (CharacterActionManagerBase.get_Size() / 100)) + (DetectionBuf.GetHateBonus(TryGetBuf.out2(), playerStatus, 0, ?x3) * 0.01)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) * (1 - BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 156, 0, ?x3))) + 1) * 100)) + 0.5)))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeaponItemType`, `KnightWill$$GetParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 553, stkp(-56), 0) & 1) ne 0`
  - returns `int(frintp((fcvt((((((((((BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 62, 0, ?x3) + (KnightWill.GetParam(TryGetValue.out2(), 5, (EquipItemData.get_SubWeaponItemType(CharacterActionManagerBase.set_DefaultMoveSpeed(), 0, ?x2, ?x3) eq 17 ? 1 : 0), 0) / 100)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) + (CharacterActionManagerBase.get_Size() / 100)) + (DetectionBuf.GetHateBonus(TryGetBuf.out2(), playerStatus, 0, ?x3) * 0.01)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) * (1 - BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 157, 0, ?x3))) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) + 1) * 100)) + -0.5)))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeaponItemType`, `KnightWill$$GetParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 553, stkp(-56), 0) & 1) ne 0`
  - returns `int(frintm((fcvt((((((((((BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 62, 0, ?x3) + (KnightWill.GetParam(TryGetValue.out2(), 5, (EquipItemData.get_SubWeaponItemType(CharacterActionManagerBase.set_DefaultMoveSpeed(), 0, ?x2, ?x3) eq 17 ? 1 : 0), 0) / 100)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) + (CharacterActionManagerBase.get_Size() / 100)) + (DetectionBuf.GetHateBonus(TryGetBuf.out2(), playerStatus, 0, ?x3) * 0.01)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) * (1 - BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 157, 0, ?x3))) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) + 1) * 100)) + 0.5)))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeaponItemType`, `KnightWill$$GetParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 553, stkp(-56), 0) & 1) ne 0`
  - returns `int(frintp((fcvt(((((((((BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 62, 0, ?x3) + (KnightWill.GetParam(TryGetValue.out2(), 5, (EquipItemData.get_SubWeaponItemType(CharacterActionManagerBase.set_DefaultMoveSpeed(), 0, ?x2, ?x3) eq 17 ? 1 : 0), 0) / 100)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) + (CharacterActionManagerBase.get_Size() / 100)) + (DetectionBuf.GetHateBonus(TryGetBuf.out2(), playerStatus, 0, ?x3) * 0.01)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) * (1 - BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 157, 0, ?x3))) + 1) * 100)) + -0.5)))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeaponItemType`, `KnightWill$$GetParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`
- when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 553, stkp(-56), 0) & 1) ne 0`
  - returns `int(frintm((fcvt(((((((((BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 62, 0, ?x3) + (KnightWill.GetParam(TryGetValue.out2(), 5, (EquipItemData.get_SubWeaponItemType(CharacterActionManagerBase.set_DefaultMoveSpeed(), 0, ?x2, ?x3) eq 17 ? 1 : 0), 0) / 100)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) + (CharacterActionManagerBase.get_Size() / 100)) + (DetectionBuf.GetHateBonus(TryGetBuf.out2(), playerStatus, 0, ?x3) * 0.01)) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 89, 0, ?x3) / 100)) * (1 - BonusManager.GetBonusPercentValue(CharacterActionManagerBase.get_MoveSpeed(), 157, 0, ?x3))) + 1) * 100)) + 0.5)))`
  - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeaponItemType`, `KnightWill$$GetParam`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferDataBase$$GetParam`

</details>

<details><summary>Effect applied in `MobaPlayerActionManager$$ReceiveDamaged` (296 guarded paths, truncated)</summary>

- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `UnityEngine.Object.op_Inequality([[battleManager+0x48]+0x20], 0, 0, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `BattleManagerBase.TargetData.SetTarget([battleManager+0x58], UnityEngine.Component.get_gameObject(otherPlayer, 0, ?x2, ?x3), UnityEngine.Component.GetComponent<object>(otherPlayer, meta(0x3982c60, Method$UnityEngine.Component.GetComponent<CharacterActionManagerBase>()), ?x2, ?x3), 0)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `MobaDuelAbilityManager.ContaintsAbility([playerStatus+0x90], 27, 0, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `UnityEngine.Object.op_Inequality([[battleManager+0x48]+0x20], 0, 0, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `BattleManagerBase.TargetData.SetTarget([battleManager+0x58], UnityEngine.Component.get_gameObject(otherPlayer, 0, ?x2, ?x3), UnityEngine.Component.GetComponent<object>(otherPlayer, meta(0x3982c60, Method$UnityEngine.Component.GetComponent<CharacterActionManagerBase>()), ?x2, ?x3), 0)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `MobaDuelAbilityManager.ContaintsAbility([playerStatus+0x90], 27, 0, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `UnityEngine.Object.op_Inequality([[battleManager+0x48]+0x20], 0, 0, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `BattleManagerBase.TargetData.SetTarget([battleManager+0x58], UnityEngine.Component.get_gameObject(otherPlayer, 0, ?x2, ?x3), UnityEngine.Component.GetComponent<object>(otherPlayer, meta(0x3982c60, Method$UnityEngine.Component.GetComponent<CharacterActionManagerBase>()), ?x2, ?x3), 0)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`

</details>

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

- `KnightHeal$$Damaged (ContainsBuffer)`
- `KnightStanceAction$$ActionHit (TryGetBuf)`
- `MobAttackBase$$CalcLastDamage (TryGetBuf)`
- `MobAttackBase$$SetAbnormalEffect (TryGetBuf)`
- `MobaPlayerActionManager$$ReceiveDamaged (TryGetBuf)`
- `MobaPlayerSecondaryStatus$$get_Vit (TryGetBuf)`
- `PhotonListener$$OnActionMobAttack (TryGetBuf)`
- `PlayerActionManager$$DamagedKnightHeal (ContainsBuffer)`
- `PlayerSecondaryStatus$$GetDisplayBonusCalcHate (TryGetBuf)`
- `PlayerSecondaryStatus$$get_Vit (TryGetBuf)`

---

### แพรี่ (Parry) · uid 515

<img src="../../icons/sk_515.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 35 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** แอสเซาต์แอคแทค · **Client class:** `Parry` (passive mastery)

> ปัดป้องการโจมตีด้วยอาวุธ
> มีโอกาสลดความเสียหายทางกายภาพ
> สกิลนี้จะไม่เกิดพร้อมปฏิกิริยา  Guard

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Trigger | 5 | 10 | 15 | 20 | 25 | 10 | 15 | 20 | 25 | 30 |
| CutDmgRate | 10 | 10 | 10 | 10 | 10 | 20 | 20 | 20 | 20 | 20 |


---

### เรจซอร์ด (RageSword) · uid 516

<img src="../../icons/sk_516.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 2) · **Type:** Attack · **Max Lv:** 35 · **Weapons:** OneHandSword, TwoHandSword · **Requires:** โพรโวค · **Flags:** MercenaryCanUseSkill · **Client class:** `RageSwordAction`

> โจมตีโดยปลดปล่อยจิตสังหารที่มี
> เป็นการโจมตีพิเศษที่ทำให้เกิดเฮทจำนวนมาก
> ถ้าตกเป็นเป้าอัตราคริติคอลจะเพิ่มขึ้น
> MP ที่ใช้ในสกิลถัดไปจะลดลงกึ่งหนึ่ง

<details><summary>In-game level notes</summary>

- Lv17: *พลัง+30 *พลังจะเพิ่มมากกว่าค่า VIT ของตัวเอง *พลังสกิล+100

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 1.6 | 1.7 | 1.8 | 1.9 | 2 | 2.1 | 2.2 | 2.3 | 2.4 | 2.5 |
| Flat dmg + [subWeapon == Shield] | 155 | 160 | 165 | 170 | 175 | 180 | 185 | 190 | 195 | 200 |
| Flat dmg + [subWeapon != Shield] | 55 | 60 | 65 | 70 | 75 | 80 | 85 | 90 | 95 | 100 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((((((Lv * 10) + 150) + (((status.Vit lt 0 ? (status.Vit + 1) : status.Vit) >> 1) + 30))) + gemCart(1019[4])) / 100)` — subWeapon == Shield
- SkillRate × `((((((Lv * 10) + 150) + (((status.Vit lt 0 ? (status.Vit + 1) : status.Vit) >> 1) + 30))) + gemCart(1019[4])) / 100)` — (+0x109 & 2) ne 0 AND Lv eq 10 AND UnityEngine.Object.op_Inequality(actarAction)
- SkillRate × `((((((Lv * 10) + 150) + (((status.Vit lt 0 ? (status.Vit + 1) : status.Vit) >> 1) + 30))) + gemCart(1019[4])) / 100)`

**Role:** attack (deals damage) · buff (self)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `((((Lv + (Lv << 2)) + 50) + 100))`
- `SkillRate` multiplies by (adds into): `((((((Lv * 10) + 150) + (((status.Vit lt 0 ? (status.Vit + 1) : status.Vit) >> 1) + 30))) + gemCart(1019[4])) / 100)`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 516

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (2 paths)

- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `skillRate` = `(((Lv * 10) + 150) + (((status.Vit lt 0 ? (status.Vit + 1) : status.Vit) >> 1) + 30))` — when subWeapon == Shield
- set `fixAddDamage` = `(((Lv + (Lv << 2)) + 50) + 100)` → Lv1..10: [155, 160, 165, 170, 175, 180, 185, 190, 195, 200] — when subWeapon == Shield
- set `skillRate` = `((Lv * 10) + 150)` → Lv1..10: [160, 170, 180, 190, 200, 210, 220, 230, 240, 250] — when subWeapon != Shield
- set `fixAddDamage` = `((Lv + (Lv << 2)) + 50)` → Lv1..10: [55, 60, 65, 70, 75, 80, 85, 90, 95, 100] — when subWeapon != Shield

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`

**`ActionPreparation`** (5 paths)

- set `skillRate` = `(skillRate + KnightWill.GetParam(PlayerStatusBase.get_SkillManager().SkillMasteryList[520], 2, (WeaponType eq 17 ? 1 : 0)))` — when (+0x109 & 2) ne 0 AND Lv eq 10 AND UnityEngine.Object.op_Inequality(actarAction)

**`calcPlayerToMobDamage`** (6 paths)

- set `isHateTarget` = `1` = 1 — when UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(playerAction), MobActionManagerBase.get_Target(mobAction))
- set `SkillIndividualFlag` = `(SkillIndividualFlag | 1)` — when UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(playerAction), MobActionManagerBase.get_Target(mobAction))
- set `skillRate` = `(skillRate + gemCart(1019[4]))`
- template `AddRate[SkillRate]` = `((skillRate + gemCart(1019[4])) / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- info `templates` = `1`

**`ActionHit`** (4 paths)

- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(516, Lv, Id)` — when MobaMode eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND isHateTarget ne 0

</details>

**Buffs**

**Buff `RageSwordBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff fields set in the constructor (all recovered):
  - `Level` = `257` = 257
  - `BuffEffectActive` = `1` = 1
  - `BufEffectTakeUid` = `-1` = -1

<details><summary>Effect applied in `PlayerAttackBase$$CalcCostMp` (300 guarded paths, truncated)</summary>

- when `(SkillBufferManager.TryGetBuf<object>(?blr, 105, stkp(-56), meta(0x399f9d8, Method$SkillBufferManager.TryGetBuf<MagicImpactBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `300`
  - set `CostMpType` = `6`
  - calls `InflexibilityBuf$$CheckMpHalving`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `MultipleHuntBuf$$CheckMode`, `virtual PlayerAttackBase.get_ActionID`, `AbnormalStateManager$$Contains`, `AshuraAuraBuf$$CheckMpIncrease`
- when `(SkillBufferManager.TryGetBuf<object>(?blr, 105, stkp(-56), meta(0x399f9d8, Method$SkillBufferManager.TryGetBuf<MagicImpactBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `200`
  - set `CostMpType` = `2`
  - calls `InflexibilityBuf$$CheckMpHalving`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `MultipleHuntBuf$$CheckMode`, `virtual PlayerAttackBase.get_ActionID`, `AbnormalStateManager$$Contains`, `AshuraAuraBuf$$CheckMpIncrease`
- when `(SkillBufferManager.TryGetBuf<object>(?blr, 105, stkp(-56), meta(0x399f9d8, Method$SkillBufferManager.TryGetBuf<MagicImpactBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `200`
  - set `CostMpType` = `2`
  - calls `InflexibilityBuf$$CheckMpHalving`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `MultipleHuntBuf$$CheckMode`, `virtual PlayerAttackBase.get_ActionID`, `AbnormalStateManager$$Contains`, `AshuraAuraBuf$$CheckMpIncrease`
- when `(SkillBufferManager.TryGetBuf<object>(?blr, 105, stkp(-56), meta(0x399f9d8, Method$SkillBufferManager.TryGetBuf<MagicImpactBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `200`
  - set `CostMpType` = `2`
  - calls `InflexibilityBuf$$CheckMpHalving`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `MultipleHuntBuf$$CheckMode`, `virtual PlayerAttackBase.get_ActionID`, `AbnormalStateManager$$Contains`
- when `(SkillBufferManager.TryGetBuf<object>(?blr, 105, stkp(-56), meta(0x399f9d8, Method$SkillBufferManager.TryGetBuf<MagicImpactBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `200`
  - set `CostMpType` = `4`
  - calls `InflexibilityBuf$$CheckMpHalving`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `MultipleHuntBuf$$CheckMode`, `virtual PlayerAttackBase.get_ActionID`, `AbnormalStateManager$$Contains`, `AshuraAuraBuf$$CheckMpIncrease`
- when `(SkillBufferManager.TryGetBuf<object>(?blr, 105, stkp(-56), meta(0x399f9d8, Method$SkillBufferManager.TryGetBuf<MagicImpactBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `100`
  - set `CostMpType` = `0`
  - calls `InflexibilityBuf$$CheckMpHalving`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `MultipleHuntBuf$$CheckMode`, `virtual PlayerAttackBase.get_ActionID`, `AbnormalStateManager$$Contains`, `AshuraAuraBuf$$CheckMpIncrease`
- when `(SkillBufferManager.TryGetBuf<object>(?blr, 105, stkp(-56), meta(0x399f9d8, Method$SkillBufferManager.TryGetBuf<MagicImpactBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `100`
  - set `CostMpType` = `0`
  - calls `InflexibilityBuf$$CheckMpHalving`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `MultipleHuntBuf$$CheckMode`, `virtual PlayerAttackBase.get_ActionID`, `AbnormalStateManager$$Contains`, `AshuraAuraBuf$$CheckMpIncrease`
- when `(SkillBufferManager.TryGetBuf<object>(?blr, 105, stkp(-56), meta(0x399f9d8, Method$SkillBufferManager.TryGetBuf<MagicImpactBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `100`
  - set `CostMpType` = `0`
  - calls `InflexibilityBuf$$CheckMpHalving`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `MultipleHuntBuf$$CheckMode`, `virtual PlayerAttackBase.get_ActionID`, `AbnormalStateManager$$Contains`

</details>

<details><summary>Effect applied in `PlayerAttackBase$$RemoveAfterSkillBuf` (300 guarded paths, truncated)</summary>

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

- `PlayerAttackBase$$CalcCostMp (ContainsBuffer)`
- `PlayerAttackBase$$RemoveAfterSkillBuf (ContainsBuffer)`

---

### โซนิคทรัสต์ (SonicThrust) · uid 522

<img src="../../icons/sk_522.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 2) · **Type:** Attack · **Max Lv:** 35 · **Weapons:** OneHandSword · **Requires:** เรจซอร์ด · **Client class:** `SonicThrustAction`

> โจมตีด้วยรัศมีแห่งดาบทำให้ศัตรูสูญเสียความสมดุล
> เป้าหมายมีโอกาส[ล้มคว่ำ]

<details><summary>In-game level notes</summary>

- Lv17: *พลังเพิ่มขึ้นตามค่า DEX *ถ้าผลของล้มคว่ำถูกป้องกันเนื่องจากเวลาต้านทาน จะฟื้นพู MP ขึ้นมาเล็กน้อย

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 1.65 | 1.8 | 1.95 | 2.1 | 2.25 | 2.4 | 2.55 | 2.7 | 2.85 | 3 |
| Flat dmg + | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((((((Lv << 4) - Lv) + 150) + status.Dex)) / 100)` — subWeapon == Shield

**Role:** attack (deals damage) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(200)`
- `SkillRate` multiplies by (adds into): `((((((Lv << 4) - Lv) + 150) + status.Dex)) / 100)`

**Mechanics recovered from code**

- **Effect percent** (`percent`): `((Lv + (Lv << 2)) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 522

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (2 paths)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(8)`
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `fixAddDamage` = `200` = 200
- set `skillRate` = `((((Lv << 4) - Lv) + 150) + status.Dex)` — when subWeapon == Shield
- set `percent` = `((Lv + (Lv << 2)) << 1)` → Lv1..10: [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]
- set `skillRate` = `(((Lv << 4) - Lv) + 150)` → Lv1..10: [165, 180, 195, 210, 225, 240, 255, 270, 285, 300] — when subWeapon != Shield

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Element` = `loopCount`

**`calcPlayerToMobDamage`** (16 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(2, percent, playerAction)` — when PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND hasGemCart(217) OR !PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND hasGemCart(217) OR !hasGemCart(217) AND PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction)
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(2, 0)` — when PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND hasGemCart(217) OR !hasGemCart(217) AND PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction)
- info `templates` = `1`

</details>

---

### N$Pดีเฟนส์$F$เพอร์เฟกต์ดีเฟนส์ (P_Deffence) · uid 517

<img src="../../icons/sk_517.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 3) · **Type:** Buffer · **Max Lv:** 125 · **Weapons:** Shield · **Requires:** แพรี่ · **Client class:** `P_DeffenceAction`

> ปกป้องสมบูรณ์แบบ
> ลดค่าความเสียหายให้เหลือ 0 ด้วยโล่
> ฟื้นฟู HP เล็กน้อย

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 517

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionStart`** (1 path)

- set `isPop` = `1` = 1
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(517, Lv, Id)`

**`ActionSkillEvent`** (6 paths)

- set `isCancel` = `(?mvn & 1)` — when !UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR MobaMode eq 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction)

**`.<>c__DisplayClass26_0::<ActionPreparation>b__0`** (4 paths)

- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(AfterShieldBuf.CreateDefaultBuf(<>c__DisplayClass26_0.afterShieldLv), 0)`

</details>

**Buffs**

**Buff `P_DeffenceActionBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `1` s
- Buff fields set in the constructor (all recovered):
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:AfterShieldBuf$$CreateDefaultBuf<-P_DeffenceAction.<>c__DisplayClass26_0$$<ActionPreparation>b__0` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

<details><summary>Effect applied in `MobAttackBase$$InvalidDamage` (11 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 94, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 302, stkp(-24), 0) & 1) ne 0`
  - returns `1`
  - calls `WheelBiteBuf$$CheckDamageInvalid`
- when `(SkillBufferManager.TryGetBuf(?blr, 94, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 302, stkp(-24), 0) & 1) ne 0`
  - returns `0`
  - calls `WheelBiteBuf$$CheckDamageInvalid`
- when `(SkillBufferManager.TryGetBuf(?blr, 94, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 302, stkp(-24), 0) & 1) eq 0`
  - returns `0`
- when `(SkillBufferManager.TryGetBuf(?blr, 94, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `1`
- when `(SkillBufferManager.TryGetBuf(?blr, 94, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `0x165db84`, `0x165df00`
- when `(SkillBufferManager.TryGetBuf(?blr, 94, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 302, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `1`
  - calls `WheelBiteBuf$$CheckDamageInvalid`
- when `(SkillBufferManager.TryGetBuf(?blr, 94, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 302, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `0`
  - calls `WheelBiteBuf$$CheckDamageInvalid`
- when `(SkillBufferManager.TryGetBuf(?blr, 94, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 302, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `0x165db84`, `0x165df00`

</details>

<details><summary>Effect applied in `PlayerAttackBase$$RemoveAfterSkillBuf` (300 guarded paths, truncated)</summary>

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

<details><summary>Effect applied in `P_DeffenceAction$$ActionSkillEvent` (3 guarded paths)</summary>

- when `MobaMode ne 0`
  - returns `SkillBufferManager.ContainsBuffer(?blr, 517, 0, ?x3)`
  - set `isCancel` = `(?mvn & 1)`
- when `MobaMode eq 0`
  - returns `SkillBufferManager.ContainsBuffer(?blr, 517, 0, ?x3)`
  - set `isCancel` = `(?mvn & 1)`
- always
  - returns `SkillBufferManager.ContainsBuffer(?blr, 517, 0, ?x3)`
  - set `isCancel` = `(?mvn & 1)`

</details>

<details><summary>Effect applied in `MobaPlayerActionManager$$ReceiveDamaged` (296 guarded paths, truncated)</summary>

- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `UnityEngine.Object.op_Inequality([[battleManager+0x48]+0x20], 0, 0, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `BattleManagerBase.TargetData.SetTarget([battleManager+0x58], UnityEngine.Component.get_gameObject(otherPlayer, 0, ?x2, ?x3), UnityEngine.Component.GetComponent<object>(otherPlayer, meta(0x3982c60, Method$UnityEngine.Component.GetComponent<CharacterActionManagerBase>()), ?x2, ?x3), 0)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `MobaDuelAbilityManager.ContaintsAbility([playerStatus+0x90], 27, 0, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `UnityEngine.Object.op_Inequality([[battleManager+0x48]+0x20], 0, 0, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `BattleManagerBase.TargetData.SetTarget([battleManager+0x58], UnityEngine.Component.get_gameObject(otherPlayer, 0, ?x2, ?x3), UnityEngine.Component.GetComponent<object>(otherPlayer, meta(0x3982c60, Method$UnityEngine.Component.GetComponent<CharacterActionManagerBase>()), ?x2, ?x3), 0)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `MobaDuelAbilityManager.ContaintsAbility([playerStatus+0x90], 27, 0, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `UnityEngine.Object.op_Inequality([[battleManager+0x48]+0x20], 0, 0, ?x3)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`
- when `(skillId & 0xffff) ne 514` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1000, stkp(-160), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `GetServerHitTypeV2.out1() ne 0`
  - returns `BattleManagerBase.TargetData.SetTarget([battleManager+0x58], UnityEngine.Component.get_gameObject(otherPlayer, 0, ?x2, ?x3), UnityEngine.Component.GetComponent<object>(otherPlayer, meta(0x3982c60, Method$UnityEngine.Component.GetComponent<CharacterActionManagerBase>()), ?x2, ?x3), 0)`
  - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillUtil$$GetServerHitTypeV2`, `Toram.Common.Actions.ActionAppendData$$Get`, `0x165da68`, `0x165da68`, `interface #2`, `virtual CharacterActionManagerBase.get_IsValid`, `ShadowWalkBuf$$InvalidDamage`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `MobAttackBase$$InvalidDamage (ContainsBuffer)`
- `MobAttackPlayerSelfDestruct$$calcMobToPlayerDamage (ContainsBuffer)`
- `MobaPlayerActionManager$$Damaged (ContainsBuffer)`
- `MobaPlayerActionManager$$ReceiveDamaged (ContainsBuffer)`
- `P_DeffenceAction$$ActionSkillEvent (ContainsBuffer)`
- `PlayerActionManager$$Damaged (ContainsBuffer)`
- `PlayerAttackBase$$RemoveAfterSkillBuf (ContainsBuffer)`

---

### ไบด์สไตร์ค (BindStrike) · uid 518

<img src="../../icons/sk_518.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 3) · **Type:** Attack · **Max Lv:** 125 · **Weapons:** OneHandSword, TwoHandSword · **Requires:** เรจซอร์ด · **Flags:** MercenaryCanUseSkill · **Client class:** `BindStrikeAction`

> โจมตีศัตรูด้วยคลื่นพลังทำลายล้าง
> มีโอกาสทำให้เป้าหมาย[หยุดนิ่ง]
> การโจมตีพิเศษที่จะทำให้เกิดเฮทจำนวนมาก

<details><summary>In-game level notes</summary>

- Lv17: *พลัง+150 *พลังจะเพิ่มมากกว่าค่า VIT ของตัวเอง *พลังสกิล+150

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 4.55 | 4.6 | 4.65 | 4.7 | 4.75 | 4.8 | 4.85 | 4.9 | 4.95 | 5 |
| Flat dmg + [mainWeapon == TwoHandSword AND subWeapon == Shield OR mainWeapon != TwoHandSword AND subWeapon == Shield] | 210 | 220 | 230 | 240 | 250 | 260 | 270 | 280 | 290 | 300 |
| Flat dmg + [mainWeapon == TwoHandSword AND subWeapon != Shield OR mainWeapon != TwoHandSword AND subWeapon != Shield] | 60 | 70 | 80 | 90 | 100 | 110 | 120 | 130 | 140 | 150 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((((((Lv * 5) + 450) + (status.Vit + 150))) + status.Vit) / 100)` — mainWeapon == TwoHandSword AND subWeapon == Shield OR mainWeapon != TwoHandSword AND subWeapon == Shield & UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND hasGemCart(1021) AND isEquipShield ne 0 OR !hasGemCart(1021) AND PlayerAttackBase.checkAbnormalPercent(this, 12, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0
- SkillRate × `((((((Lv * 5) + 450) + (status.Vit + 150))) + status.Vit) / 100)` — mainWeapon == TwoHandSword AND subWeapon != Shield OR mainWeapon != TwoHandSword AND subWeapon != Shield & UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND hasGemCart(1021) AND isEquipShield ne 0 OR !hasGemCart(1021) AND PlayerAttackBase.checkAbnormalPercent(this, 12, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0
- SkillRate × `((((((Lv * 5) + 450) + (status.Vit + 150))) + status.Vit) / 100)` — (+0x109 & 2) ne 0 AND Lv eq 10 AND UnityEngine.Object.op_Inequality(actarAction) & UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND hasGemCart(1021) AND isEquipShield ne 0 OR !hasGemCart(1021) AND PlayerAttackBase.checkAbnormalPercent(this, 12, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0
- SkillRate × `(((((Lv * 5) + 450) + (status.Vit + 150))) / 100)` — mainWeapon == TwoHandSword AND subWeapon == Shield OR mainWeapon != TwoHandSword AND subWeapon == Shield & isEquipShield eq 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND hasGemCart(1021) AND isEquipShield eq 0
- SkillRate × `(((((Lv * 5) + 450) + (status.Vit + 150))) / 100)` — (+0x109 & 2) ne 0 AND Lv eq 10 AND UnityEngine.Object.op_Inequality(actarAction) & isEquipShield eq 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND hasGemCart(1021) AND isEquipShield eq 0

**Role:** attack (deals damage) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `((((Lv * 10) + 50) + 150))`
- `SkillRate` multiplies by (adds into): `((((((Lv * 5) + 450) + (status.Vit + 150))) + status.Vit) / 100)` | `(((((Lv * 5) + 450) + (status.Vit + 150))) / 100)`

**Mechanics recovered from code**

- **Range** (`range`): `MathUtil.DisplayMeterToDistance((floor((Lv * 0.1)) + (floor((Lv * 0.175)) + 3)))`
- **Effect percent** (`percent`): `((Lv + (Lv << 2)) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 518

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (4 paths)

- set `Element` = `7` = 7
- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `skillRate` = `(((Lv * 5) + 450) + (status.Vit + 150))` — when mainWeapon == TwoHandSword AND subWeapon == Shield OR mainWeapon != TwoHandSword AND subWeapon == Shield
- set `fixAddDamage` = `(((Lv * 10) + 50) + 150)` → Lv1..10: [210, 220, 230, 240, 250, 260, 270, 280, 290, 300] — when mainWeapon == TwoHandSword AND subWeapon == Shield OR mainWeapon != TwoHandSword AND subWeapon == Shield
- set `range` = `MathUtil.DisplayMeterToDistance((floor((Lv * 0.1)) + (floor((Lv * 0.175)) + 3)))`
- set `percent` = `((Lv + (Lv << 2)) << 1)` → Lv1..10: [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]
- set `isEquipShield` = `1` = 1 — when mainWeapon == TwoHandSword AND subWeapon == Shield OR mainWeapon != TwoHandSword AND subWeapon == Shield
- set `skillRate` = `((Lv * 5) + 450)` → Lv1..10: [455, 460, 465, 470, 475, 480, 485, 490, 495, 500] — when mainWeapon == TwoHandSword AND subWeapon != Shield OR mainWeapon != TwoHandSword AND subWeapon != Shield
- set `fixAddDamage` = `((Lv * 10) + 50)` → Lv1..10: [60, 70, 80, 90, 100, 110, 120, 130, 140, 150] — when mainWeapon == TwoHandSword AND subWeapon != Shield OR mainWeapon != TwoHandSword AND subWeapon != Shield

**`InitializeOthers`** (2 paths)

- set `ActionRange` = `-1` = -1
- set `Element` = `0` = 0

**`ActionPreparation`** (5 paths)

- set `target` = `UnityEngine.GameObject.get_transform(target)`
- set `skillRate` = `(skillRate + KnightWill.GetParam(PlayerStatusBase.get_SkillManager().SkillMasteryList[520], 3, (EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator) eq 17 ? 1 : 0)))` — when (+0x109 & 2) ne 0 AND Lv eq 10 AND UnityEngine.Object.op_Inequality(actarAction)

**`calcPlayerToMobDamage`** (42 paths)

- template `AddRate[SkillRate]` = `((skillRate + status.Vit) / 100)` — when UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND hasGemCart(1021) AND isEquipShield ne 0 OR !hasGemCart(1021) AND PlayerAttackBase.checkAbnormalPercent(this, 12, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(3, percent, playerAction)` — when PlayerAttackBase.checkAbnormalPercent(this, 3, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND hasGemCart(1021) AND isEquipShield eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 3, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND hasGemCart(1021) AND isEquipShield eq 0 OR PlayerAttackBase.checkAbnormalPercent(this, 3, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND hasGemCart(1021) AND isEquipShield ne 0
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(3, ?stack)` — when PlayerAttackBase.checkAbnormalPercent(this, 3, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND hasGemCart(1021) AND isEquipShield eq 0 OR PlayerAttackBase.checkAbnormalPercent(this, 3, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND hasGemCart(1021) AND isEquipShield ne 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND PlayerAttackBase.checkAbnormalPercent(this, 3, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND hasGemCart(1021) AND isEquipShield ne 0
- info `templates` = `1`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(12, percent, playerAction)` — when !hasGemCart(1021) AND PlayerAttackBase.checkAbnormalPercent(this, 12, percent, playerAction) AND isEquipShield eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 12, percent, playerAction) AND !hasGemCart(1021) AND isEquipShield eq 0 OR !hasGemCart(1021) AND PlayerAttackBase.checkAbnormalPercent(this, 12, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(12, 0)` — when !hasGemCart(1021) AND PlayerAttackBase.checkAbnormalPercent(this, 12, percent, playerAction) AND isEquipShield eq 0 OR !hasGemCart(1021) AND PlayerAttackBase.checkAbnormalPercent(this, 12, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND !hasGemCart(1021) AND PlayerAttackBase.checkAbnormalPercent(this, 12, percent, playerAction) AND isEquipShield ne 0
- template `AddRate[SkillRate]` = `(skillRate / 100)` — when isEquipShield eq 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND hasGemCart(1021) AND isEquipShield eq 0

</details>

---

### เรเวอเนีย (Levenir) · uid 523

<img src="../../icons/sk_523.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 3) · **Type:** Attack · **Max Lv:** 125 · **Weapons:** OneHandSword · **Requires:** โซนิคทรัสต์ · **Client class:** `LevenirAction`

> การโจมตีศัตรูทรงพลังที่ขวางทางอย่างรุนแรง
> หากตรงตามเงื่อนไขจำนวน HIT จะเพิ่มขึ้น(สูงสุด 3HIT)
> แต่ถ้าติดสภาวะผิดปกติใดๆ ผลของการ
> เพิ่มจำนวน HIT จะไม่ทำงาน
> การโจมตีนี้จะไม่ทำให้เกิดการแบ่งสัดส่วน

<details><summary>In-game level notes</summary>

- Lv17: *การันตีคริติตอล  *จำนวน HIT จะเพิ่มขึ้น 1 เมื่อ Pดีเฟนส์สำเร็จ *จำนวน HIT จะเพิ่มขึ้น 1 เมื่อทำให้ผงะ *จำนวน HIT จะเพิ่มขึ้น 3 เมื่อทำให้ล้มคว่ำ *จำนวน HIT จะเพิ่มขึ้น 5 เมื่อทำให้หมดสติ *สามารถสะสมผลที่เพิ่มได้จนถึงสกิลเลเวล

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 40 | 80 | 120 | 160 | 200 | 240 | 280 | 320 | 360 | 400 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv * 10) + 500) + (baseDEX << 1))) / 100)` — 1 ge maxAttackCount AND maxAttackCount ge 1 OR 1 lt maxAttackCount AND 2 ge maxAttackCount AND maxAttackCount ge 1 OR 1 lt maxAttackCount AND 2 lt maxAttackCount AND 3 ge maxAttackCount AND maxAttackCount ge 1

**Role:** attack (deals damage) · buff (self)

The skill builds 3 separate damage templates (each is a full hit with its own crit roll). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; never (IsExpDefFluctuate=false)

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv + (Lv << 2)) << 3))`
- `SkillRate` multiplies by (adds into): `(((((Lv * 10) + 500) + (baseDEX << 1))) / 100)`

**Mechanics recovered from code**

- **Max attacks** (`maxAttackCount`): `((SkillBufferDataBase.GetParam(20) lt 2 ? SkillBufferDataBase.GetParam(20) : 2) + maxAttackCount)` _(when IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) ne 1 AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) eq 1 AND SkillBufferDataBase.GetParam(20) le 0 AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) eq 1 AND SkillBufferDataBase.GetParam(20) gt 0 AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 AND UnityEngine.Object.op_Inequality(actarAction))_
- **Loop / hit-repeat count** (`LoopParam`): `((SkillBufferDataBase.GetParam(20) lt 2 ? SkillBufferDataBase.GetParam(20) : 2) + maxAttackCount)` _(when IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) eq 1 AND SkillBufferDataBase.GetParam(20) le 0 AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) eq 1 AND SkillBufferDataBase.GetParam(20) gt 0 AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 AND UnityEngine.Object.op_Inequality(actarAction))_; `maxAttackCount` _(when System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) ne 0 AND UnityEngine.Object.op_Inequality(actarAction))_

**Proration:** slot `Skill`, mode `never (IsExpDefFluctuate=false)`, attack type `Physics`, action id 523

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `Element` = `PlayerStatusBase.GetEquipElement(PlayerActionManagerBase.get_PlayerStatus())`
- set `fixAddDamage` = `((Lv + (Lv << 2)) << 3)` → Lv1..10: [40, 80, 120, 160, 200, 240, 280, 320, 360, 400]
- set `skillRate` = `(((Lv * 10) + 500) + (baseDEX << 1))`

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`ActionPreparation`** (7 paths)

- set `maxAttackCount` = `((SkillBufferDataBase.GetParam(20) lt 2 ? SkillBufferDataBase.GetParam(20) : 2) + maxAttackCount)` — when IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) ne 1 AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) eq 1 AND SkillBufferDataBase.GetParam(20) le 0 AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) eq 1 AND SkillBufferDataBase.GetParam(20) gt 0 AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `LoopParam` = `((SkillBufferDataBase.GetParam(20) lt 2 ? SkillBufferDataBase.GetParam(20) : 2) + maxAttackCount)` — when IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) eq 1 AND SkillBufferDataBase.GetParam(20) le 0 AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) eq 1 AND SkillBufferDataBase.GetParam(20) gt 0 AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(523)` — when IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) eq 1 AND SkillBufferDataBase.GetParam(20) le 0 AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)
- set `LoopParam` = `maxAttackCount` — when System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)

**`calcPlayerToMobDamage`** (38 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)` — when 1 ge maxAttackCount AND maxAttackCount ge 1 OR 1 lt maxAttackCount AND 2 ge maxAttackCount AND maxAttackCount ge 1 OR 1 lt maxAttackCount AND 2 lt maxAttackCount AND 3 ge maxAttackCount AND maxAttackCount ge 1
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage` — when 1 ge maxAttackCount AND maxAttackCount ge 1 OR 1 lt maxAttackCount AND 2 ge maxAttackCount AND maxAttackCount ge 1 OR 1 lt maxAttackCount AND 2 lt maxAttackCount AND 3 ge maxAttackCount AND maxAttackCount ge 1
- info `templates` = `1` — when 1 ge maxAttackCount AND maxAttackCount ge 1
- info `templates` = `2` — when 1 lt maxAttackCount AND 2 ge maxAttackCount AND maxAttackCount ge 1
- info `templates` = `3` — when 1 lt maxAttackCount AND 2 lt maxAttackCount AND 3 ge maxAttackCount AND maxAttackCount ge 1 OR 1 lt maxAttackCount AND 2 lt maxAttackCount AND 3 lt maxAttackCount AND maxAttackCount ge 1

**`AbnormalStack`** (13 paths)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(523)` — when !UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>(actor), 0) AND !UnityEngine.Object.op_Equality(actor) AND (SkillBufferDataBase.GetParam(20) + ((type - 1) lo 3 ? ?bfi : 0)) lt 1 AND (type - 1) ls 2 AND EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator) eq 17 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 OR !UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>(actor), 0) AND !UnityEngine.Object.op_Equality(actor) AND (SkillBufferDataBase.GetParam(20) + ((type - 1) lo 3 ? ?bfi : 0)) eq 1 AND (SkillBufferDataBase.GetParam(20) + ((type - 1) lo 3 ? ?bfi : 0)) ge 1 AND (type - 1) ls 2 AND EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator) eq 17 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 OR !UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>(actor), 0) AND !UnityEngine.Object.op_Equality(actor) AND ((SkillBufferDataBase.GetParam(20) + ((type - 1) lo 3 ? ?bfi : 0)) - 1) eq 1 AND (SkillBufferDataBase.GetParam(20) + ((type - 1) lo 3 ? ?bfi : 0)) ge 1 AND (SkillBufferDataBase.GetParam(20) + ((type - 1) lo 3 ? ?bfi : 0)) ne 1 AND (type - 1) ls 2 AND EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator) eq 17 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0
- calls `LevenirBuf..ctor` = `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1))` — when !UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>(actor), 0) AND !UnityEngine.Object.op_Equality(actor) AND (type - 1) ls 2 AND EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator) eq 17 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 OR !UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>(actor), 0) AND !UnityEngine.Object.op_Equality(actor) AND (SkillBufferDataBase.GetParam(20) + ((type - 1) lo 3 ? ?bfi : 0)) lt 1 AND (type - 1) ls 2 AND EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator) eq 17 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 OR !UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>(actor), 0) AND !UnityEngine.Object.op_Equality(actor) AND (SkillBufferDataBase.GetParam(20) + ((type - 1) lo 3 ? ?bfi : 0)) eq 1 AND (SkillBufferDataBase.GetParam(20) + ((type - 1) lo 3 ? ?bfi : 0)) ge 1 AND (type - 1) ls 2 AND EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator) eq 17 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new LevenirBuf, 0)` — when !UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>(actor), 0) AND !UnityEngine.Object.op_Equality(actor) AND (type - 1) ls 2 AND EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator) eq 17 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 OR !UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>(actor), 0) AND !UnityEngine.Object.op_Equality(actor) AND (SkillBufferDataBase.GetParam(20) + ((type - 1) lo 3 ? ?bfi : 0)) lt 1 AND (type - 1) ls 2 AND EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator) eq 17 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 OR !UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>(actor), 0) AND !UnityEngine.Object.op_Equality(actor) AND (SkillBufferDataBase.GetParam(20) + ((type - 1) lo 3 ? ?bfi : 0)) eq 1 AND (SkillBufferDataBase.GetParam(20) + ((type - 1) lo 3 ? ?bfi : 0)) ge 1 AND (type - 1) ls 2 AND EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator) eq 17 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0

**`Damaged`** (9 paths)

- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(523)` — when (SkillBufferDataBase.GetParam(20) + 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 OR (SkillBufferDataBase.GetParam(20) + 1) eq 1 AND (SkillBufferDataBase.GetParam(20) + 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 OR ((SkillBufferDataBase.GetParam(20) + 1) - 1) eq 1 AND (SkillBufferDataBase.GetParam(20) + 1) ge 1 AND (SkillBufferDataBase.GetParam(20) + 1) ne 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0
- calls `LevenirBuf..ctor` = `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1))` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 OR (SkillBufferDataBase.GetParam(20) + 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 OR (SkillBufferDataBase.GetParam(20) + 1) eq 1 AND (SkillBufferDataBase.GetParam(20) + 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new LevenirBuf, 0)` — when SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 OR (SkillBufferDataBase.GetParam(20) + 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 OR (SkillBufferDataBase.GetParam(20) + 1) eq 1 AND (SkillBufferDataBase.GetParam(20) + 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0

</details>

**Buffs**

**Buff `LevenirBuf`**
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:LevenirBuf$$.ctor<-LevenirAction$$AbnormalStack` (no direct constructor call in the skill's own code).
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

<details><summary>Effect applied in `LevenirAction$$AbnormalStack` (10 guarded paths)</summary>

- when `(type - 1) ls 2` AND `SkillLv(523) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 523, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `?blr`
  - calls `UnityEngine.GameObject$$GetComponent<object>`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `0x165db78`, `LevenirBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
- when `(type - 1) ls 2` AND `SkillLv(523) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 523, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `?blr`
  - calls `UnityEngine.GameObject$$GetComponent<object>`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `0x165db78`, `LevenirBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
- when `(type - 1) ls 2` AND `SkillLv(523) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 523, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `?blr`
  - calls `UnityEngine.GameObject$$GetComponent<object>`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `0x165db78`, `LevenirBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
- when `(type - 1) ls 2` AND `SkillLv(523) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 523, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - calls `UnityEngine.GameObject$$GetComponent<object>`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `0x165db78`, `LevenirBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
- when `(type - 1) ls 2` AND `SkillLv(523) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 523, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `SkillBufferManager.AddSelfBuffer(?blr, 0x165db78(meta(0x399f1e8, LevenirBuf_TypeInfo), ?x1, ?x2, ?x3), 0, 0)`
  - calls `UnityEngine.GameObject$$GetComponent<object>`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `0x165db78`, `LevenirBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
- when `(type - 1) ls 2` AND `SkillLv(523) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 523, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `TryGetBuf.out2()`
  - calls `UnityEngine.GameObject$$GetComponent<object>`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
- when `(type - 1) ls 2` AND `SkillLv(523) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 523, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `UnityEngine.GameObject$$GetComponent<object>`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `0x165db84`, `0x165df00`
- when `(type - 1) ls 2` AND `SkillLv(523) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 523, stkp(-56), 0) & 1) eq 0`
  - returns `SkillBufferManager.AddSelfBuffer(?blr, 0x165db78(meta(0x399f1e8, LevenirBuf_TypeInfo), ?x1, ?x2, ?x3), 0, 0)`
  - calls `UnityEngine.GameObject$$GetComponent<object>`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `0x165db78`, `LevenirBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`

</details>

<details><summary>Effect applied in `LevenirAction$$ActionPreparation` (4 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 523, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() le 0`
  - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 523, 0, ?x3)`
  - set `maxAttackCount` = `((CharacterActionManagerBase.set_DefaultMoveSpeed() lt 2 ? CharacterActionManagerBase.set_DefaultMoveSpeed() : 2) + maxAttackCount)`
  - set `LoopParam` = `((CharacterActionManagerBase.set_DefaultMoveSpeed() lt 2 ? CharacterActionManagerBase.set_DefaultMoveSpeed() : 2) + maxAttackCount)`
  - calls `PlayerAttackBase$$ActionPreparation`, `AbnormalStateManager$$get_AbnormalList`, `System.Linq.Enumerable$$Where<object>`, `System.Linq.Enumerable$$Count<object>`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`
- when `(SkillBufferManager.TryGetBuf(?blr, 523, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() gt 0`
  - returns `CharacterActionManagerBase.set_DefaultMoveSpeed()`
  - set `maxAttackCount` = `((CharacterActionManagerBase.set_DefaultMoveSpeed() lt 2 ? CharacterActionManagerBase.set_DefaultMoveSpeed() : 2) + maxAttackCount)`
  - set `LoopParam` = `((CharacterActionManagerBase.set_DefaultMoveSpeed() lt 2 ? CharacterActionManagerBase.set_DefaultMoveSpeed() : 2) + maxAttackCount)`
  - calls `PlayerAttackBase$$ActionPreparation`, `AbnormalStateManager$$get_AbnormalList`, `System.Linq.Enumerable$$Where<object>`, `System.Linq.Enumerable$$Count<object>`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- when `(SkillBufferManager.TryGetBuf(?blr, 523, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `PlayerAttackBase$$ActionPreparation`, `AbnormalStateManager$$get_AbnormalList`, `System.Linq.Enumerable$$Where<object>`, `System.Linq.Enumerable$$Count<object>`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(?blr, 523, stkp(-56), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 523, stkp(-56), 0)`
  - set `LoopParam` = `maxAttackCount`
  - calls `PlayerAttackBase$$ActionPreparation`, `AbnormalStateManager$$get_AbnormalList`, `System.Linq.Enumerable$$Where<object>`, `System.Linq.Enumerable$$Count<object>`

</details>

<details><summary>Effect applied in `LevenirAction$$Damaged` (9 guarded paths)</summary>

- when `SkillLv(523) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 523, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(CharacterActionManagerBase.set_DefaultMoveSpeed() + 1) lt 1`
  - returns `SkillBufferManager.AddSelfBuffer(?blr, 0x165db78(meta(0x399f1e8, LevenirBuf_TypeInfo), ?x1, ?x2, ?x3), 0, 0)`
  - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `0x165db78`, `LevenirBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
- when `SkillLv(523) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 523, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(CharacterActionManagerBase.set_DefaultMoveSpeed() + 1) ge 1`
  - returns `?blr`
  - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `0x165db78`, `LevenirBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
- when `SkillLv(523) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 523, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(CharacterActionManagerBase.set_DefaultMoveSpeed() + 1) ge 1`
  - returns `?blr`
  - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `0x165db78`, `LevenirBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
- when `SkillLv(523) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 523, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(CharacterActionManagerBase.set_DefaultMoveSpeed() + 1) ge 1`
  - returns `?blr`
  - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `0x165db78`, `LevenirBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
- when `SkillLv(523) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 523, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(CharacterActionManagerBase.set_DefaultMoveSpeed() + 1) ge 1`
  - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveSelfBuffer`, `0x165db78`, `LevenirBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
- when `SkillLv(523) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 523, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `?blr`
- when `SkillLv(523) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 523, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `0x165db84`
- when `SkillLv(523) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 523, stkp(-56), 0) & 1) eq 0`
  - returns `?blr`
  - calls `0x165db78`, `LevenirBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `LevenirAction$$AbnormalStack (GetSkillLv)`
- `LevenirAction$$AbnormalStack (TryGetBuf)`
- `LevenirAction$$ActionPreparation (TryGetBuf)`
- `LevenirAction$$Damaged (GetSkillLv)`
- `LevenirAction$$Damaged (TryGetBuf)`
- `PlayerActionManager$$Damaged (GetSkillLv)`
- `PlayerActionManager$$Damaged (TryGetBuf)`

---

### ฟาเรส (Fearless) · uid 519

<img src="../../icons/sk_519.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 4) · **Type:** Buffer · **Max Lv:** 205 · **Weapons:** Shield · **Requires:** N$Pดีเฟนส์$F$เพอร์เฟกต์ดีเฟนส์ · **Flags:** StarGem · **Client class:** `FearlessAction`

> ผลจะเพิ่มขึ้นเมื่ออยู่ในสภาพหยุดนิ่ง(5 ระดับ)
> เพิ่มความเร็วการโจมตี, อาวุธเจาะเข้า, การโจมตีปกติ,
> อัตราส่วนการลดความเสียหาย
> 
> ความเร็วการโจมตีและอาวุธเจาะเข้าจะได้รับอิทธิพลจากค่า VIT ของตัวเอง

**Role:** buff (self) · boosts normal-attack damage

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 519

<details><summary>Recovered formulas (per method)</summary>

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (6 paths)

- calls `FearlessBuf..ctor` = `.ctor(Lv, actarAction)` — when !UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR MobaMode eq 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new FearlessBuf, 0)` — when !UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR MobaMode eq 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction)

</details>

**Buffs**

**Buff `FearlessBuf`**
- **Boosts normal-attack damage** through the `NormalAttackRate` / `NormalAttackConstantDamage` parameters.
- Buff hook methods: `SetBufCount`
- Duration: `240` s
- `PowerResistBreaker` = `((0) * (int((((Lv * 0.1) * baseVIT) * 0.01))))` _(when BuffEffectActive ne 0; EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17)_
- `NormalAttackRate` = `((0) * ((int((Lv * 1.5)) + 5)))` _(when BuffEffectActive ne 0; EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17)_
- `Aspd` = `((0) * (int(((((Lv * baseVIT) + ((Lv * baseVIT) << 2)) << 1) * 0.01))))` _(when BuffEffectActive ne 0; EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17)_
- `MobLastDamageRateBuf` = `int((((Lv * 0.4)) * (0)))` _(when BuffEffectActive ne 0; EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17)_
- Buff fields set in the constructor (all recovered):
  - `Count` = `0`
  - `Max` = `5` = 5
  - `baseAspdUp` = `int(((((Lv * baseVIT) + ((Lv * baseVIT) << 2)) << 1) * 0.01))`
  - `baseRateDmgDownRate` = `(Lv * 0.4)` → Lv1..10 [0.4, 0.8, 1.2, 1.6, 2.0, 2.4, 2.8, 3.2, 3.6, 4.0]
  - `baseResist` = `int((((Lv * 0.1) * baseVIT) * 0.01))`
  - `baseNormalAtkUpRate` = `(int((Lv * 1.5)) + 5)` → Lv1..10 [6, 8, 9, 11, 12, 14, 15, 17, 18, 20]
  - `playerStatus` = `PlayerActionManagerBase.get_PlayerStatus()`
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `SetBufCount`: `Count`=count
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:FearlessBuf$$.ctor<-FearlessAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

<details><summary>Effect applied in `ArialSlayAction$$ActionStart` (20 guarded paths)</summary>

- when `SubWeaponType ne 10` AND `SubWeaponType eq 17`
  - returns `PlayerAttackBase.add_EndFunction(this, 0x165db78(meta(0x3975858, System.Action<bool>_TypeInfo), ?x1, ?x2, ?x3), 0, ?x3)`
  - set `isMoveAssist` = `0`
  - set `charaMove` = `UnityEngine.Component.GetComponent<object>(vtab(0x165db78(meta(0x39a8258, ArialSlayAction.<>c__DisplayClass30_0_TypeInfo), actarAction, target, ?x3)), meta(0x3982b38, Method$UnityEngine.Component.GetComponent<CharacterMove>()), ?x2, ?x3)`
  - set `enableMove` = `1`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `0x165db78`, `ArialSlayBuf$$.ctor`
- when `SubWeaponType ne 10` AND `SubWeaponType eq 17`
  - returns `UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<object>(vtab(0x165db78(meta(0x39a8258, ArialSlayAction.<>c__DisplayClass30_0_TypeInfo), actarAction, target, ?x3)), meta(0x3982b38, Method$UnityEngine.Component.GetComponent<CharacterMove>()), ?x2, ?x3), 0, 0, ?x3)`
  - set `isMoveAssist` = `0`
  - set `charaMove` = `UnityEngine.Component.GetComponent<object>(vtab(0x165db78(meta(0x39a8258, ArialSlayAction.<>c__DisplayClass30_0_TypeInfo), actarAction, target, ?x3)), meta(0x3982b38, Method$UnityEngine.Component.GetComponent<CharacterMove>()), ?x2, ?x3)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `0x165db78`, `ArialSlayBuf$$.ctor`
- when `SubWeaponType ne 10` AND `SubWeaponType eq 17`
  - returns `PlayerAttackBase.add_EndFunction(this, 0x165db78(meta(0x3975858, System.Action<bool>_TypeInfo), ?x1, ?x2, ?x3), 0, ?x3)`
  - set `isMoveAssist` = `[skillMaster+0x30]`
  - set `charaMove` = `UnityEngine.Component.GetComponent<object>(vtab(0x165db78(meta(0x39a8258, ArialSlayAction.<>c__DisplayClass30_0_TypeInfo), actarAction, target, ?x3)), meta(0x3982b38, Method$UnityEngine.Component.GetComponent<CharacterMove>()), ?x2, ?x3)`
  - set `enableMove` = `1`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `0x165db78`, `ArialSlayBuf$$.ctor`
- when `SubWeaponType ne 10` AND `SubWeaponType eq 17`
  - returns `UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<object>(vtab(0x165db78(meta(0x39a8258, ArialSlayAction.<>c__DisplayClass30_0_TypeInfo), actarAction, target, ?x3)), meta(0x3982b38, Method$UnityEngine.Component.GetComponent<CharacterMove>()), ?x2, ?x3), 0, 0, ?x3)`
  - set `isMoveAssist` = `[skillMaster+0x30]`
  - set `charaMove` = `UnityEngine.Component.GetComponent<object>(vtab(0x165db78(meta(0x39a8258, ArialSlayAction.<>c__DisplayClass30_0_TypeInfo), actarAction, target, ?x3)), meta(0x3982b38, Method$UnityEngine.Component.GetComponent<CharacterMove>()), ?x2, ?x3)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `0x165db78`, `ArialSlayBuf$$.ctor`
- when `SubWeaponType ne 10` AND `SubWeaponType ne 17`
  - returns `PlayerAttackBase.add_EndFunction(this, 0x165db78(meta(0x3975858, System.Action<bool>_TypeInfo), ?x1, ?x2, ?x3), 0, ?x3)`
  - set `isMoveAssist` = `0`
  - set `charaMove` = `UnityEngine.Component.GetComponent<object>(vtab(0x165db78(meta(0x39a8258, ArialSlayAction.<>c__DisplayClass30_0_TypeInfo), actarAction, target, ?x3)), meta(0x3982b38, Method$UnityEngine.Component.GetComponent<CharacterMove>()), ?x2, ?x3)`
  - set `enableMove` = `1`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `UnityEngine.Component$$GetComponent<object>`, `0x165d8dc`
- when `SubWeaponType ne 10` AND `SubWeaponType ne 17`
  - returns `UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<object>(vtab(0x165db78(meta(0x39a8258, ArialSlayAction.<>c__DisplayClass30_0_TypeInfo), actarAction, target, ?x3)), meta(0x3982b38, Method$UnityEngine.Component.GetComponent<CharacterMove>()), ?x2, ?x3), 0, 0, ?x3)`
  - set `isMoveAssist` = `0`
  - set `charaMove` = `UnityEngine.Component.GetComponent<object>(vtab(0x165db78(meta(0x39a8258, ArialSlayAction.<>c__DisplayClass30_0_TypeInfo), actarAction, target, ?x3)), meta(0x3982b38, Method$UnityEngine.Component.GetComponent<CharacterMove>()), ?x2, ?x3)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `UnityEngine.Component$$GetComponent<object>`, `0x165d8dc`
- when `SubWeaponType ne 10` AND `SubWeaponType ne 17`
  - returns `PlayerAttackBase.add_EndFunction(this, 0x165db78(meta(0x3975858, System.Action<bool>_TypeInfo), ?x1, ?x2, ?x3), 0, ?x3)`
  - set `isMoveAssist` = `[skillMaster+0x30]`
  - set `charaMove` = `UnityEngine.Component.GetComponent<object>(vtab(0x165db78(meta(0x39a8258, ArialSlayAction.<>c__DisplayClass30_0_TypeInfo), actarAction, target, ?x3)), meta(0x3982b38, Method$UnityEngine.Component.GetComponent<CharacterMove>()), ?x2, ?x3)`
  - set `enableMove` = `1`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `UnityEngine.Component$$GetComponent<object>`, `0x165d8dc`
- when `SubWeaponType ne 10` AND `SubWeaponType ne 17`
  - returns `UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<object>(vtab(0x165db78(meta(0x39a8258, ArialSlayAction.<>c__DisplayClass30_0_TypeInfo), actarAction, target, ?x3)), meta(0x3982b38, Method$UnityEngine.Component.GetComponent<CharacterMove>()), ?x2, ?x3), 0, 0, ?x3)`
  - set `isMoveAssist` = `[skillMaster+0x30]`
  - set `charaMove` = `UnityEngine.Component.GetComponent<object>(vtab(0x165db78(meta(0x39a8258, ArialSlayAction.<>c__DisplayClass30_0_TypeInfo), actarAction, target, ?x3)), meta(0x3982b38, Method$UnityEngine.Component.GetComponent<CharacterMove>()), ?x2, ?x3)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `UnityEngine.Component$$GetComponent<object>`, `0x165d8dc`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `ArialSlayAction$$ActionStart (ContainsBuffer)`

---

### ไนท์วีล (KnightWill) · uid 520

<img src="../../icons/sk_520.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 4) · **Type:** Mastery · **Max Lv:** 205 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ไบด์สไตร์ค · **Flags:** StarGem · **Client class:** `KnightWill` (passive mastery)

> จะมีผลเมื่อความรู้สึกเป็นศัตรูของเป้าหมายมุ่งมาที่ตัวเอง
> เฮทของตัวเองจะเพิ่มได้ง่ายยิ่งขึ้น
> เสริมประสิทธิภาพของสกิลอัศวิน Lv10 จนถึงทรีเลเวล 3
> (ไม่รวมสกิลในขั้นที่ 3 และขั้นที่ 4)

<details><summary>In-game level notes</summary>

- Lv17: *เพิ่มค่าเฮท *เพิ่มพลังของแอสเซาต์แอคแทคLv10 เพิ่มปริมาณเฮทของโพรโวคLv10 *เพิ่มอัตราการเกิดแพรี่Lv10 *เพิ่มปริมาณเฮทและพลังของเรจซอร์ดLv10 *เพิ่มพลังของไบด์สไตร์คLv10 *เพิ่มขีดจำกัดการฟื้นฟูของPดีเฟ้นส์Lv10

</details>

**Role:** passive mastery

<details><summary>Effect applied in `PlayerAttackBase$$ActionPreparation` (236 guarded paths, truncated)</summary>

- when `(SkillActionBase.checkPercent(this, 100, 30, 0) & 1) ne 0` AND `SkillLv(520) ge 1` AND `(((SkillParam | 16) | 512) & 16) eq 0` AND `PlayerAttackBase.get_ActionID() ne 0`
  - returns `HeavenlyStarBuf.SetAttackSkillId(TryGetBuf<object>.out2(), PlayerAttackBase.get_ActionID(), 0, ?x3)`
  - set `SkillParam` = `((SkillParam | 16) | 512)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `AbnormalStateManager$$Contains`, `SkillActionBase$$checkPercent`, `IchijhinnokazeAction$$UpdateFirstAttackParam`, `TargetableListManagerBase<object>$$get_Instance`
- when `(SkillActionBase.checkPercent(this, 100, 30, 0) & 1) ne 0` AND `SkillLv(520) ge 1` AND `(((SkillParam | 16) | 512) & 16) eq 0` AND `PlayerAttackBase.get_ActionID() ne 0`
  - set `SkillParam` = `((SkillParam | 16) | 512)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `AbnormalStateManager$$Contains`, `SkillActionBase$$checkPercent`, `IchijhinnokazeAction$$UpdateFirstAttackParam`, `TargetableListManagerBase<object>$$get_Instance`
- when `(SkillActionBase.checkPercent(this, 100, 30, 0) & 1) ne 0` AND `SkillLv(520) ge 1` AND `(((SkillParam | 16) | 512) & 16) eq 0` AND `PlayerAttackBase.get_ActionID() ne 0`
  - returns `SkillUtil.IsPursuitSkill(PlayerAttackBase.get_ActionID(), 0, ?x2, ?x3)`
  - set `SkillParam` = `((SkillParam | 16) | 512)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `AbnormalStateManager$$Contains`, `SkillActionBase$$checkPercent`, `IchijhinnokazeAction$$UpdateFirstAttackParam`, `TargetableListManagerBase<object>$$get_Instance`
- when `(SkillActionBase.checkPercent(this, 100, 30, 0) & 1) ne 0` AND `SkillLv(520) ge 1` AND `(((SkillParam | 16) | 512) & 16) eq 0` AND `PlayerAttackBase.get_ActionID() ne 0`
  - returns `SkillBufferManager.TryGetBuf<object>(?blr, 620, stkp(-56), meta(0x399f910, Method$SkillBufferManager.TryGetBuf<HeavenlyStarBuf>()))`
  - set `SkillParam` = `((SkillParam | 16) | 512)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `AbnormalStateManager$$Contains`, `SkillActionBase$$checkPercent`, `IchijhinnokazeAction$$UpdateFirstAttackParam`, `TargetableListManagerBase<object>$$get_Instance`
- when `(SkillActionBase.checkPercent(this, 100, 30, 0) & 1) ne 0` AND `SkillLv(520) ge 1` AND `(((SkillParam | 16) | 512) & 16) eq 0` AND `PlayerAttackBase.get_ActionID() ne 0`
  - returns `HeavenlyStarBuf.SetAttackSkillId(TryGetBuf<object>.out2(), PlayerAttackBase.get_ActionID(), 0, ?x3)`
  - set `SkillParam` = `((SkillParam | 16) | 512)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `AbnormalStateManager$$Contains`, `SkillActionBase$$checkPercent`, `IchijhinnokazeAction$$UpdateFirstAttackParam`, `TargetableListManagerBase<object>$$get_Instance`
- when `(SkillActionBase.checkPercent(this, 100, 30, 0) & 1) ne 0` AND `SkillLv(520) ge 1` AND `(((SkillParam | 16) | 512) & 16) eq 0` AND `PlayerAttackBase.get_ActionID() ne 0`
  - set `SkillParam` = `((SkillParam | 16) | 512)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `AbnormalStateManager$$Contains`, `SkillActionBase$$checkPercent`, `IchijhinnokazeAction$$UpdateFirstAttackParam`, `TargetableListManagerBase<object>$$get_Instance`
- when `(SkillActionBase.checkPercent(this, 100, 30, 0) & 1) ne 0` AND `SkillLv(520) ge 1` AND `(((SkillParam | 16) | 512) & 16) eq 0` AND `PlayerAttackBase.get_ActionID() ne 0`
  - returns `SkillUtil.IsPursuitSkill(PlayerAttackBase.get_ActionID(), 0, ?x2, ?x3)`
  - set `SkillParam` = `((SkillParam | 16) | 512)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `AbnormalStateManager$$Contains`, `SkillActionBase$$checkPercent`, `IchijhinnokazeAction$$UpdateFirstAttackParam`, `TargetableListManagerBase<object>$$get_Instance`
- when `(SkillActionBase.checkPercent(this, 100, 30, 0) & 1) ne 0` AND `SkillLv(520) ge 1` AND `(((SkillParam | 16) | 512) & 16) eq 0` AND `PlayerAttackBase.get_ActionID() ne 0`
  - returns `SkillBufferManager.TryGetBuf<object>(?blr, 620, stkp(-56), meta(0x399f910, Method$SkillBufferManager.TryGetBuf<HeavenlyStarBuf>()))`
  - set `SkillParam` = `((SkillParam | 16) | 512)`
  - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165d8dc`, `AbnormalStateManager$$Contains`, `SkillActionBase$$checkPercent`, `IchijhinnokazeAction$$UpdateFirstAttackParam`, `TargetableListManagerBase<object>$$get_Instance`

</details>

<details><summary>Effect applied in `CallGolemNormalAttackAction$$ActionPreparation` (3 guarded paths)</summary>

- when `SkillLv(520) ge 1`
  - returns `MobManager.HasPlayerHateManager(TargetableListManagerBase<object>.get_Instance(meta(0x3974240, Method$TargetableListManagerBase<MobManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `SkillParam` = `(SkillParam | 512)`
  - calls `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$HasPlayerHateManager`
- when `SkillLv(520) ge 1`
  - returns `MobManager.HasPlayerHateManager(TargetableListManagerBase<object>.get_Instance(meta(0x3974240, Method$TargetableListManagerBase<MobManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3)`
  - calls `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$HasPlayerHateManager`
- when `SkillLv(520) lt 1`
  - returns `SkillLv(520)`

</details>

<details><summary>Effect applied in `HuntingOneNormalAttackAction$$ActionPreparation` (3 guarded paths)</summary>

- when `SkillLv(520) ge 1`
  - returns `MobManager.HasPlayerHateManager(TargetableListManagerBase<object>.get_Instance(meta(0x3974240, Method$TargetableListManagerBase<MobManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3)`
  - set `SkillParam` = `(SkillParam | 512)`
  - calls `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$HasPlayerHateManager`
- when `SkillLv(520) ge 1`
  - returns `MobManager.HasPlayerHateManager(TargetableListManagerBase<object>.get_Instance(meta(0x3974240, Method$TargetableListManagerBase<MobManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3)`
  - calls `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$HasPlayerHateManager`
- when `SkillLv(520) lt 1`
  - returns `SkillLv(520)`

</details>

<details><summary>Effect applied in `WarCryAction$$ActionPreparation` (60 guarded paths)</summary>

- when `(SkillActionBase.checkPercent(this, 100, 30, 0) & 1) ne 0` AND `SkillLv(520) ge 1` AND `PlayerAttackBase.get_ActionID() ne 0`
  - returns `PlayerAttackBase.ContainsNotApplicableSkill(PlayerAttackBase.get_ActionID(), 0, ?x2, ?x3)`
  - set `SkillParam` = `((SkillParam | 16) | 512)`
  - calls `AbnormalStateManager$$Contains`, `SkillActionBase$$checkPercent`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$HasPlayerHateManager`, `PlayerAttackBase$$IsBlank`, `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$CheckSkillParamFlag`, `virtual PlayerAttackBase.get_ActionID`
- when `(SkillActionBase.checkPercent(this, 100, 30, 0) & 1) ne 0` AND `SkillLv(520) ge 1` AND `PlayerAttackBase.get_ActionID() ne 0`
  - set `SkillParam` = `((SkillParam | 16) | 512)`
  - calls `AbnormalStateManager$$Contains`, `SkillActionBase$$checkPercent`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$HasPlayerHateManager`, `PlayerAttackBase$$IsBlank`, `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$CheckSkillParamFlag`, `virtual PlayerAttackBase.get_ActionID`
- when `(SkillActionBase.checkPercent(this, 100, 30, 0) & 1) ne 0` AND `SkillLv(520) ge 1` AND `PlayerAttackBase.get_ActionID() ne 0`
  - returns `PlayerAttackBase.CheckSkillParamFlag(this, 1024, 0, ?x3)`
  - set `SkillParam` = `((SkillParam | 16) | 512)`
  - calls `AbnormalStateManager$$Contains`, `SkillActionBase$$checkPercent`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$HasPlayerHateManager`, `PlayerAttackBase$$IsBlank`, `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$CheckSkillParamFlag`
- when `(SkillActionBase.checkPercent(this, 100, 30, 0) & 1) ne 0` AND `SkillLv(520) ge 1` AND `PlayerAttackBase.get_ActionID() eq 0`
  - returns `PlayerAttackBase.get_ActionID()`
  - set `SkillParam` = `((SkillParam | 16) | 512)`
  - calls `AbnormalStateManager$$Contains`, `SkillActionBase$$checkPercent`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$HasPlayerHateManager`, `PlayerAttackBase$$IsBlank`, `virtual PlayerAttackBase.get_ActionID`
- when `(SkillActionBase.checkPercent(this, 100, 30, 0) & 1) ne 0` AND `SkillLv(520) ge 1`
  - returns `PlayerAttackBase.IsBlank(this, 0, ?x2, ?x3)`
  - set `SkillParam` = `((SkillParam | 16) | 512)`
  - calls `AbnormalStateManager$$Contains`, `SkillActionBase$$checkPercent`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$HasPlayerHateManager`, `PlayerAttackBase$$IsBlank`
- when `(SkillActionBase.checkPercent(this, 100, 30, 0) & 1) ne 0` AND `SkillLv(520) ge 1` AND `PlayerAttackBase.get_ActionID() ne 0`
  - returns `PlayerAttackBase.ContainsNotApplicableSkill(PlayerAttackBase.get_ActionID(), 0, ?x2, ?x3)`
  - set `SkillParam` = `(SkillParam | 16)`
  - calls `AbnormalStateManager$$Contains`, `SkillActionBase$$checkPercent`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$HasPlayerHateManager`, `PlayerAttackBase$$IsBlank`, `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$CheckSkillParamFlag`, `virtual PlayerAttackBase.get_ActionID`
- when `(SkillActionBase.checkPercent(this, 100, 30, 0) & 1) ne 0` AND `SkillLv(520) ge 1` AND `PlayerAttackBase.get_ActionID() ne 0`
  - set `SkillParam` = `(SkillParam | 16)`
  - calls `AbnormalStateManager$$Contains`, `SkillActionBase$$checkPercent`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$HasPlayerHateManager`, `PlayerAttackBase$$IsBlank`, `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$CheckSkillParamFlag`, `virtual PlayerAttackBase.get_ActionID`
- when `(SkillActionBase.checkPercent(this, 100, 30, 0) & 1) ne 0` AND `SkillLv(520) ge 1` AND `PlayerAttackBase.get_ActionID() ne 0`
  - returns `PlayerAttackBase.CheckSkillParamFlag(this, 1024, 0, ?x3)`
  - set `SkillParam` = `(SkillParam | 16)`
  - calls `AbnormalStateManager$$Contains`, `SkillActionBase$$checkPercent`, `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$HasPlayerHateManager`, `PlayerAttackBase$$IsBlank`, `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$CheckSkillParamFlag`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `CallGolemNormalAttackAction$$ActionPreparation (GetSkillLv)`
- `HuntingOneNormalAttackAction$$ActionPreparation (GetSkillLv)`
- `PlayerAttackBase$$ActionPreparation (GetSkillLv)`
- `WarCryAction$$ActionPreparation (GetSkillLv)`

---

### ไนท์ฮีล (KnightHeal) · uid 524

<img src="../../icons/sk_524.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 4) · **Type:** Mastery · **Max Lv:** 205 · **Weapons:** OneHandSword · **Requires:** ไนท์สแตนซ์ · **Client class:** `KnightHeal` (passive mastery)

> ความเสียหายที่ได้รับระหว่างใช้ไนท์สแตนซ์
> จะมีบางส่วนที่ถูกสะสมไว้เพื่อใช้ฟื้นฟู HP
> และเมื่อใช้ไนท์สแตนซ์อีกครั้ง
> ค่าที่สะสมไว้ทั้งหมดจะถูกใช้เพื่อฟื้นฟู HP

<details><summary>In-game level notes</summary>

- Lv17: *สะสมความเสียหายให้มากขึ้น จากเป้าหมายที่มีเฮทตรงกัน

</details>

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Percent | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


<details><summary>Effect applied in `KnightStanceAction$$ActionHit` (5 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 521, stkp(-72), 0) & 1) ne 0` AND `SkillLv(524) ge 1` AND `TryGetBuf.out2() ne 0` AND `IPlayerStatusCalculator.get_MaxHp(?blr) le 0`
  - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 521, 0, ?x3)`
  - calls `SkillActionBase$$ActionHit`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryHp`, `SkillBufferManager$$RemoveSelfBuffer`, `0x165db78`
- when `(SkillBufferManager.TryGetBuf(?blr, 521, stkp(-72), 0) & 1) ne 0` AND `SkillLv(524) ge 1` AND `TryGetBuf.out2() ne 0` AND `IPlayerStatusCalculator.get_MaxHp(?blr) gt 0`
  - returns `IPlayerStatusCalculator.get_MaxHp(?blr)`
  - calls `SkillActionBase$$ActionHit`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$RecoveryHp`, `SkillBufferManager$$RemoveSelfBuffer`, `0x165db78`
- when `(SkillBufferManager.TryGetBuf(?blr, 521, stkp(-72), 0) & 1) ne 0` AND `SkillLv(524) ge 1` AND `TryGetBuf.out2() eq 0`
  - calls `SkillActionBase$$ActionHit`, `0x165db84`
- when `(SkillBufferManager.TryGetBuf(?blr, 521, stkp(-72), 0) & 1) ne 0` AND `SkillLv(524) lt 1` AND `IPlayerStatusCalculator.get_MaxHp(?blr) le 0`
  - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 521, 0, ?x3)`
  - calls `SkillActionBase$$ActionHit`, `SkillBufferManager$$RemoveSelfBuffer`, `0x165db78`, `KnightStanceBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `interface IPlayerStatusCalculator.get_MaxHp`, `SkillBufferManager$$RemoveSelfBuffer`
- when `(SkillBufferManager.TryGetBuf(?blr, 521, stkp(-72), 0) & 1) ne 0` AND `SkillLv(524) lt 1` AND `IPlayerStatusCalculator.get_MaxHp(?blr) gt 0`
  - returns `IPlayerStatusCalculator.get_MaxHp(?blr)`
  - calls `SkillActionBase$$ActionHit`, `SkillBufferManager$$RemoveSelfBuffer`, `0x165db78`, `KnightStanceBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `interface IPlayerStatusCalculator.get_MaxHp`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `KnightStanceAction$$ActionHit (GetSkillLv)`

---

### อาฟเตอร์ชีลด์ (AfterShield) · uid 525

<img src="../../icons/sk_525.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 285 · **Weapons:** OneHandSword · **Requires:** ฟาเรส · **Client class:** `AfterShield` (passive mastery)

> หลังจากเปิดใช้งานPดีเฟ้นส์
> จะลดความเสียหายลงได้ช่วงเวลาหนึ่ง
> 
> และถ้าเรียนรู้จะเพิ่มต้านทานไร้ธาตุเล็กน้อยแบบถาวร

<details><summary>In-game level notes</summary>

- Lv10: ถ้าได้รับความเสียหายร้ายแรงเกินHPสูงสุด ระหว่างอาฟเตอร์ชีลด์มีผลอยู่ความเสียหายนั้นจะไม่มีผล แต่หลังจากใช้งานไป 1 ครั้งจะไม่สามารถ ใช้งานอาฟเตอร์ชีลด์ได้อีกในระยะเวลาหนึ่ง

</details>

**Role:** buff (self) · passive mastery

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| NormalResist | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


**Buffs**

**Buff `AfterShieldBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `CreateCooltimeBuf`, `CreateDefaultBuf`, `get_IsCooltime`, `set_IsCooltime`
- `MobLastDamageRateBuf` = `(int(LeftTime) + (int(LeftTime) << 2))` _(when BuffEffectActive ne 0; IsCooltime eq 0)_
- `MobLastDamageRateBuf` = `0` _(when BuffEffectActive ne 0; IsCooltime ne 0)_
- Hook `set_IsCooltime`: `IsCooltime`=(value & 1)
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:AfterShieldBuf$$CreateCooltimeBuf<-AfterShield$$InvalidDamage` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

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

### บลิงค์ซอร์ด (BlinkSword) · uid 526

<img src="../../icons/sk_526.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 5) · **Type:** Attack · **Max Lv:** 285 · **Weapons:** OneHandSword · **Requires:** ไนท์วีล · **Client class:** `BlinkSwordAction`

> ขว้างดาบและเข้าใกล้เป้าหมายทันที
> มีโอกาส[ผงะ]สามารถลดเปอร์เซ็นต์ความเสียหาย
> ได้เป็นเวลา 3 วินาทีหลังจากสำเร็จ
> แม้ว่าจะเคลื่อนไหวผลของฟาเรสจะไม่หายไป

<details><summary>In-game level notes</summary>

- Lv10: ถ้าทำให้ติดผงะได้สำเร็จ บลิงค์ซอร์ดจะเล็งตรงเป้าแน่นอน หากเกิดMISSการเปิดใช้งานจะล้มเหลว

</details>

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 5.75 | 6.5 | 7.25 | 8 | 8.75 | 9.5 | 10.25 | 11 | 11.75 | 12.5 |
| Flat dmg + | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv * 75) + 500)) + baseVIT) / 100)` — AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND MobActionManagerBase.get_SystemInvincible(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0
- SkillRate × `(((((Lv * 75) + 500)) + baseVIT) / 100)` — AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND MobActionManagerBase.get_SystemInvincible(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0 & AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND MobActionManagerBase.get_SystemInvincible(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0
- SkillRate × `((((Lv * 75) + 500)) / 100)` — AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND MobActionManagerBase.get_SystemInvincible(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0 & !AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3)

**Role:** attack (deals damage) · buff (self) · applies status ailment

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **physical-skill proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(200)`
- `SkillRate` multiplies by (adds into): `(((((Lv * 75) + 500)) + baseVIT) / 100)` | `((((Lv * 75) + 500)) / 100)`

**Mechanics recovered from code**

- **Effect percent** (`percent`): `((int((Lv * 4.5)) + 5) + 50)` → Lv1..10 [59, 64, 68, 73, 77, 82, 86, 91, 95, 100] _(when (mainWeapon==Shield & 1) ne 0)_; `(int((Lv * 4.5)) + 5)` → Lv1..10 [9, 14, 18, 23, 27, 32, 36, 41, 45, 50] _(when (mainWeapon==Shield & 1) eq 0)_
- **Cast time modifier** (`CastTime`): `(((PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction)) * 10) mi 0 ? int((PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction)) * 10)) : int((PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction)) * 10))) & 255)`

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 526

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (2 paths)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(14)`
- set `weaponRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- set `constantDamage` = `200` = 200
- set `skillRate` = `((Lv * 75) + 500)` → Lv1..10: [575, 650, 725, 800, 875, 950, 1025, 1100, 1175, 1250]
- set `percent` = `((int((Lv * 4.5)) + 5) + 50)` → Lv1..10: [59, 64, 68, 73, 77, 82, 86, 91, 95, 100] — when (mainWeapon==Shield & 1) ne 0
- set `isEquipShield` = `1` = 1 — when (mainWeapon==Shield & 1) ne 0
- set `CastTime` = `(((PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction)) * 10) mi 0 ? int((PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction)) * 10)) : int((PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction)) * 10))) & 255)`
- set `percent` = `(int((Lv * 4.5)) + 5)` → Lv1..10: [9, 14, 18, 23, 27, 32, 36, 41, 45, 50] — when (mainWeapon==Shield & 1) eq 0

**`calcPlayerToMobDamage`** (48 paths)

- set `skillRate` = `(skillRate + baseVIT)` — when AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND MobActionManagerBase.get_SystemInvincible(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0
- template `AddRate[SkillRate]` = `((skillRate + baseVIT) / 100)` — when AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND MobActionManagerBase.get_SystemInvincible(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0
- template `AddConstant[SkillConstantDamage]` = `constantDamage`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(1, percent, playerAction)` — when !PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) OR !PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1)
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(1, 0)` — when AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND MobActionManagerBase.get_SystemInvincible(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND isEquipShield ne 0 OR AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND MobActionManagerBase.get_SystemInvincible(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND isEquipShield eq 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0
- info `templates` = `1`
- set `isTeleport` = `1` = 1 — when !AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3)
- template `AddRate[SkillRate]` = `(skillRate / 100)` — when !AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3)

**`ActionStart`** (6 paths)

- set `mainTarget` = `target` — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND isTeleport ne 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND isTeleport eq 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 AND isTeleport ne 0
- set `movePos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x` — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND isTeleport ne 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND isTeleport eq 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 AND isTeleport ne 0
- set `movePos.y` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y` — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND isTeleport ne 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND isTeleport eq 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 AND isTeleport ne 0
- set `movePos.z` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z` — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND isTeleport ne 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND isTeleport eq 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 AND isTeleport ne 0
- set `SkillIndividualFlag` = `1` = 1 — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 AND isTeleport ne 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05 AND isTeleport ne 0

**`ActionSkillEvent`** (8 paths)

- calls `BlinkSwordBuf..ctor` = `.ctor(Lv)` — when (((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).x) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).x))) hi ((targetSize + weaponRange) * (targetSize + weaponRange)) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(mainTarget) AND isTeleport ne 0 AND param eq 100 OR (((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).x) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).x))) ls ((targetSize + weaponRange) * (targetSize + weaponRange)) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(mainTarget) AND isTeleport ne 0 AND param eq 100 OR !UnityEngine.Object.op_Inequality(mainTarget) AND (((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - movePos.z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - movePos.z)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - movePos) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - movePos))) hi ((targetSize + weaponRange) * (targetSize + weaponRange)) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND isTeleport ne 0 AND param eq 100
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new BlinkSwordBuf, Id)` — when (((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).x) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).x))) hi ((targetSize + weaponRange) * (targetSize + weaponRange)) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(mainTarget) AND isTeleport ne 0 AND param eq 100 OR (((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).x) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).x))) ls ((targetSize + weaponRange) * (targetSize + weaponRange)) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(mainTarget) AND isTeleport ne 0 AND param eq 100 OR !UnityEngine.Object.op_Inequality(mainTarget) AND (((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - movePos.z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - movePos.z)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - movePos) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - movePos))) hi ((targetSize + weaponRange) * (targetSize + weaponRange)) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND isTeleport ne 0 AND param eq 100

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `weaponRange` = `(?v3 / 10)`

**`OtherPlayerAttackStartReceive`** (2 paths)

- set `isTeleport` = `1` = 1 — when PlayerAttackBase.CheckSkillIndividualFlag(this, 1)

**`via PlayerAttackBase$$HitReactionAssign`** (3467 paths)

- calls `MathUtil.CheckPercent` = `CheckPercent()` — when !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) eq 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3
- template `SetCalcValue[GuardPower]` = `System.Math.Max(0, (25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4))))` — when !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType ne 2 AND comboType ne 3
- template `SetCalcValue[GuardPower]` = `25` — when !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType ne 2 AND comboType ne 3

</details>

**Buffs**

**Buff `BlinkSwordBuf`**
- Duration: `3` s
- `RateDamageResist` = `0` _(when BuffEffectActive eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| RateDamageResist | 3 | 6 | 9 | 12 | 15 | 18 | 21 | 24 | 27 | 30 |

- Buff fields set in the constructor (all recovered):
  - `rateDamageResist` = `((Lv << 1) + lv)` → Lv1..10 [3, 6, 9, 12, 15, 18, 21, 24, 27, 30]
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:BlinkSwordBuf$$.ctor<-BlinkSwordAction$$ActionSkillEvent` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

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

### ไนท์เพลดจ์ (KnightPledge) · uid 527

<img src="../../icons/sk_527.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 5) · **Type:** Object · **Max Lv:** 285 · **Weapons:** OneHandSword · **Requires:** ไนท์ฮีล · **Client class:** `KnightPledgeAction`

> แทงดาบแห่งคำสาบานเพื่อสร้างพื้นที่ป้องกัน
> เพิ่มพลังโจมตีภายในพื้นที่และเพิ่มต้านทานความเสียหาย
> อย่างรุนแรง(ลดลงตามจำนวนครั้ง)ให้กับผู้อื่น
> จะหายไปเมื่อโดนโจมตีแบบผลักกระเด็น
> ผลลัพธ์จะกระจายมากขึ้นตามเป้าหมายที่ปกป้อง

<details><summary>In-game level notes</summary>

- Lv10: หากลดความเสียหายจากการโจมตีแบบผลักกระเด็นในพื้นที่ จะสามารถลดระยะนั้นลงได้เป็นอย่างมาก แต่ดาบที่แทงลงไปจะถูกดีดออกทำให้ผลของสกิลสิ้นสุดลง  นอกจากนี้หากมีหลายเป้าหมายในพื้นที่ พลังโจมตีจะเพิ่มขึ้น ความเสียหายจะลดลง ผลลดลงเนื่องจากการกระจายของผลการลดผลักกระเด็น
- Lv17: *ความต้านทานผลักกระเด็นเพิ่มขึ้นอีก พลังโจมตีเพิ่มขึ้นอีกขึ้นอยู่กับค่าถลุงโล่

</details>

**Role:** buff (self) · placed object / trap / summon

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Effect radius (Unity units)** (`Radius`): `MathUtil.DisplayMeterToDistance(1.5)`; `(MathUtil.DisplayMeterToDistance(1.5) + 0.5)`; `(MathUtil.DisplayMeterToDistance(1.5) + 0.5)`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 527

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Radius` = `MathUtil.DisplayMeterToDistance(1.5)`

**`ActionStart`** (7 paths)

- set `actarArchetypeUid` = `IUserArchetype.get_ArchetypeUid(UnityEngine.Component.GetComponent<IUserArchetype>(actarAction))` — when !PlayerAttackBase.IsBlank(this) AND IsInstanceOf(actarAction, PlayerActionManagerBase) ne 1 OR !PlayerAttackBase.IsBlank(this) AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 AND IsInstanceOf(actarAction, PlayerActionManagerBase) eq 1 OR !PlayerAttackBase.IsBlank(this) AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 17 AND IsInstanceOf(actarAction, PlayerActionManagerBase) eq 1
- set `lastDamageRate` = `int((Lv * 0.25))` → Lv1..10: [0, 0, 0, 1, 1, 1, 1, 2, 2, 2] — when !PlayerAttackBase.IsBlank(this) AND IsInstanceOf(actarAction, PlayerActionManagerBase) ne 1 OR !PlayerAttackBase.IsBlank(this) AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 17 AND IsInstanceOf(actarAction, PlayerActionManagerBase) eq 1
- set `knockbackDistReduceRate` = `((Lv << 2) + 10)` → Lv1..10: [14, 18, 22, 26, 30, 34, 38, 42, 46, 50] — when !PlayerAttackBase.IsBlank(this) AND IsInstanceOf(actarAction, PlayerActionManagerBase) ne 1 OR !PlayerAttackBase.IsBlank(this) AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 17 AND IsInstanceOf(actarAction, PlayerActionManagerBase) eq 1
- set `SkillIndividualFlag` = `1` = 1 — when !PlayerAttackBase.IsBlank(this) AND IsInstanceOf(actarAction, PlayerActionManagerBase) ne 1 OR !PlayerAttackBase.IsBlank(this) AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 AND IsInstanceOf(actarAction, PlayerActionManagerBase) eq 1 OR !PlayerAttackBase.IsBlank(this) AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 17 AND IsInstanceOf(actarAction, PlayerActionManagerBase) eq 1
- set `actorForwardAngle` = `UnityEngine.Quaternion.Internal_MakePositive(0).y` — when !PlayerAttackBase.IsBlank(this) AND IsInstanceOf(actarAction, PlayerActionManagerBase) ne 1 OR !PlayerAttackBase.IsBlank(this) AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 AND IsInstanceOf(actarAction, PlayerActionManagerBase) eq 1 OR !PlayerAttackBase.IsBlank(this) AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 17 AND IsInstanceOf(actarAction, PlayerActionManagerBase) eq 1
- set `SkillIndividualFlag` = `0` = 0 — when !PlayerAttackBase.IsBlank(this) AND IsInstanceOf(actarAction, PlayerActionManagerBase) ne 1 OR !PlayerAttackBase.IsBlank(this) AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 AND IsInstanceOf(actarAction, PlayerActionManagerBase) eq 1 OR !PlayerAttackBase.IsBlank(this) AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 17 AND IsInstanceOf(actarAction, PlayerActionManagerBase) eq 1
- set `lastDamageRate` = `(int((Lv * 0.25)) gt ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) ? int((Lv * 0.25)) : (ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255))` — when !PlayerAttackBase.IsBlank(this) AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 AND IsInstanceOf(actarAction, PlayerActionManagerBase) eq 1
- set `knockbackDistReduceRate` = `(((Lv << 2) + 10) + 25)` → Lv1..10: [39, 43, 47, 51, 55, 59, 63, 67, 71, 75] — when !PlayerAttackBase.IsBlank(this) AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 AND IsInstanceOf(actarAction, PlayerActionManagerBase) eq 1

**`ActionSkillEvent`** (9 paths)

- set `effectiveEnd` = `1` = 1 — when !UnityEngine.Object.op_Inequality(actarAction) AND IsOtherPlayer eq 0 AND param eq 101 AND param ne 200 OR IsOtherPlayer eq 0 AND SkillBufferManager.RemoveSelfKnightPledgeBuf(PlayerStatusBase.get_SkillBufferManager(), Id) AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 101 AND param ne 200 OR !SkillBufferManager.RemoveSelfKnightPledgeBuf(PlayerStatusBase.get_SkillBufferManager(), Id) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 101 AND param ne 200
- set `isOtherEnd` = `1` = 1 — when IsOtherPlayer ne 0 AND param eq 200

**`SustainedSupport`** (7 paths)

- set `effectiveNum` = `([new System.Collections.Generic.List<GameObject>+0x18] + (KnightPledgeAction.CheckRangeHit(0, UnityEngine.Component.get_transform(actarActionManager), 0) & 1))` — when UnityEngine.Object.op_Inequality(actarActionManager) AND effectiveEnd eq 0

**`PrevInitializeOthers`** (1 path)

- set `receiveOtherPos` = `Vector3Ex.SetServerPosition(eventData.Position).x`
- set `receiveOtherPos.y` = `Vector3Ex.SetServerPosition(eventData.Position).y`
- set `receiveOtherPos.z` = `Vector3Ex.SetServerPosition(eventData.Position).z`
- set `receiveOtherForwardAngle` = `eventData.Rotation`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `Radius` = `(MathUtil.DisplayMeterToDistance(1.5) + 0.5)`

**`InitializeOtherPlaceSkill`** (1 path)

- set `Radius` = `(MathUtil.DisplayMeterToDistance(1.5) + 0.5)`

</details>

**Buffs**

**Buff `KnightPledgeBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `CheckEnd`, `CheckInvokeSelfKnightPledge`, `CheckIsSelf`, `GetEffectiveArchetypeId`, `ReceiveDamage`, `RemoveSelfBuf`, `UpdateEffectiveParameter`, `UpdateOtherBuf`, `UpdateSelfBuf`
- `KnockbackDistReduceRate` = `knockbackDistReduceRate` _(when BuffEffectActive ne 0; isEffective ne 0)_
- `Count` = `Count` _(when BuffEffectActive ne 0; isEffective ne 0)_
- `Value2` = `effectiveNum` _(when BuffEffectActive ne 0; isEffective ne 0)_
- `Value` = `selfBufData.((int((Lv * 4.5)) + 45))` _(when BuffEffectActive ne 0; isEffective ne 0)_
- `MobLastDamageRateUnique` = `(((int((Lv * 4.5)) + 45)) // effectiveNum)` _(when BuffEffectActive ne 0; isEffective ne 0)_
- `LastDamageRateDecimal` = `(((Lv) * 100) // effectiveNum)` _(when BuffEffectActive ne 0; isEffective ne 0)_
- Buff fields set in the constructor (all recovered):
  - `bufferType` = `512` = 512
  - `countViewType` = `(IsSelfAction eq 0 ? 13 : 9)`
  - `lastDamageRate` = `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `totalReduceValue` = `(int((Lv * 4.5)) + 45)` → Lv1..10 [49, 54, 58, 63, 67, 72, 76, 81, 85, 90]
- Hook `Updata`: `selfBufData`=0; `otherBufData`=0
- Hook `UpdateOtherBuf`: `otherBufData`=new KnightPledgeBuf.EffectiveBufData
- Hook `RemoveSelfBuf`: `selfBufData`=0
- Hook `UpdateEffectiveParameter`: `isEffective`=1; `totalReduceValue`=((selfBufData.totalReduceValue * 100) // 10); `effectiveNum`=selfBufData.effectiveNum; `knockbackDistReduceRate`=selfBufData.knockbackDistReduceRate

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
