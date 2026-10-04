# ナイトスキル (`KnightSkill`) — skill details

15 entries.

### แอสเซาต์แอคแทค (AssaultAttack) · uid 513

<img src="../../icons/sk_513.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 1) · **Type:** Attack · **Max Lv:** 15 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `AssaultAttackAction`

> จู่โจมอย่างรวดเร็วและดันศัตรูออกไป
> มีโอกาสทำให้เป้าหมาย[เชื่องช้า]

**How it works**

- Attack skill of the ナイトスキル tree (tier 1, max Lv 15); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [subWeapon == Shield]: skill multiplier ×0.6 at Lv1 to 1.5 at Lv10; flat damage +55 at Lv1 to 100 at Lv10
  - `calcPlayerToMobDamage` [subWeapon != Shield]: skill multiplier ×0.35 at Lv1 to 1.25 at Lv10; flat damage +5 at Lv1 to 50 at Lv10
  - `calcPlayerToMobDamage` [(+0x109 & 2) ne 0 AND Lv eq 10 AND UnityEngine.Object.op_Inequality(actarAction)]: skill multiplier depends on live values (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Slow (11), KnockBack (4).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(6)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 8 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionPreparation` — before the cast starts: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 3 call, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [subWeapon == Shield] | 0.6 | 0.7 | 0.8 | 0.9 | 1 | 1.1 | 1.2 | 1.3 | 1.4 | 1.5 |
| SkillRate × [subWeapon != Shield] | 0.35 | 0.45 | 0.55 | 0.65 | 0.75 | 0.85 | 0.95 | 1.05 | 1.15 | 1.25 |
| Flat dmg + [subWeapon == Shield] | 55 | 60 | 65 | 70 | 75 | 80 | 85 | 90 | 95 | 100 |
| Flat dmg + [subWeapon != Shield] | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((((Lv + (Lv << 2)) << 1) + 25) + 25) + gemCart(1002[4]))) / 100)` — (+0x109 & 2) ne 0 AND Lv eq 10 AND UnityEngine.Object.op_Inequality(actarAction)

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((((Lv + (Lv << 2)) << 1) + 25) + 25) + gemCart(1002[4]))) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv + (Lv << 2)) + 50))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 513
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Rolls `slowRate`% to inflict **Slow (11)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 11, slowRate, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 4, knockbackRate, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 4, knockbackRate, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 11, slowRate, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 11, slowRate, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 4, knockbackRate, playerAction)`
- Marks the hit with ailment **Slow (11)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 11, slowRate, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 4, knockbackRate, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 4, knockbackRate, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 11, slowRate, playerAction)`
- Rolls `knockbackRate`% to inflict **KnockBack (4)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 11, slowRate, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 4, knockbackRate, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 4, knockbackRate, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 11, slowRate, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 11, slowRate, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 4, knockbackRate, playerAction)`

**In-game level notes**

- Lv17: *พลัง+25 *พลังสกิล+50 *อัตราติดผลักกระเด็น+50%

_Raw recovered data (every method item): [trees/KnightSkill.md](../trees/KnightSkill.md) — uid 513_

---

### โพรโวค (Provoke) · uid 514

<img src="../../icons/sk_514.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 1) · **Type:** Special · **Max Lv:** 15 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `ProvokeAction`

> ยั่วยุศัตรูให้เข้ามาโจมตีผู้ใช้

**How it works**

- Special skill of the ナイトスキル tree (tier 1, max Lv 15); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a utility / system action (movement, state change) rather than a damage or buff skill.
- MP: `200` (conditional variants below).

**Cost, timing and range**

- **MP cost** (`mp` in `OnInitialize`): `200` = 200
  - when `Lv hi 5 AND Lv hi 9`
- **MP cost** (`mp` in `OnInitialize`): `300` = 300
  - when `Lv hi 5 AND Lv ls 9`
- **MP cost** (`mp` in `OnInitialize`): `400` = 400
  - when `Lv ls 5`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(8)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 5 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionPreparation` — before the cast starts: 1 set
- `OnInheritance` — state carried over when this action follows another: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 514
- No proration slot: ExpType None: no proration slot.

**Other recovered parameters**

- **MP cost** (`mp`): `200` = 200 _(when Lv hi 5 AND Lv hi 9)_; `300` = 300 _(when Lv hi 5 AND Lv ls 9)_; `400` = 400 _(when Lv ls 5)_

_Raw recovered data (every method item): [trees/KnightSkill.md](../trees/KnightSkill.md) — uid 514_

---

### ไนท์สแตนซ์ (KnightStance) · uid 521

<img src="../../icons/sk_521.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 1) · **Type:** Buffer · **Max Lv:** 15 · **Weapons:** OneHandSword · **Flags:** StarGem · **Client class:** `KnightStanceAction`

> คำสาบานของอัศวิน
> เพิ่ม VIT และเฮทของตัวเองเป็นเวลา 6 นาที
> ระหว่างเอฟเฟกต์มีผลอยู่ถ้ามีเฮทที่ตรงกัน
> อัตราความเสียหายที่ได้รับจากมอนสเตอร์จะลดลงเล็กน้อย

**How it works**

- Buffer skill of the ナイトスキル tree (tier 1, max Lv 15); usable with OneHandSword.
- It installs a buff on the caster.
- Buffs:
  - `KnightStanceBuf`: lasts `360` s; Lv1 → Lv10: HateRate (aggro (hate) generation %) 3 → 30, HateRate (aggro (hate) generation %) 2 → 20
  - `CountBufferBase`
- Other client code reads this skill (10 lookups; see the last section).

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 1 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 3 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 521
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): removes the caster's buff of skill 521 (KnightStance) — `RemoveSelfBuffer(521)`
  - when `UnityEngine.Object.op_Inequality(actarAction) AND status.MaxHp le 0 OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 524, 1) lt 1 AND UnityEngine.Object.op_Inequality(actarAction) AND status.MaxHp le 0 OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 524, 1) lt 1 AND UnityEngine.Object.op_Inequality(actarAction) AND status.MaxHp gt 0`
- `ActionHit` (when the attack connects): constructs `KnightStanceBuf` — `.ctor(Lv, PlayerActionManagerBase.get_PlayerStatus())`
  - when `UnityEngine.Object.op_Inequality(actarAction) AND status.MaxHp le 0 OR UnityEngine.Object.op_Inequality(actarAction) AND status.MaxHp gt 0 OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 524, 1) lt 1 AND UnityEngine.Object.op_Inequality(actarAction) AND status.MaxHp le 0`
- `ActionHit` (when the attack connects): adds the caster's buff of `new KnightStanceBuf` — `AddSelfBuffer(new KnightStanceBuf, Id)`
  - when `UnityEngine.Object.op_Inequality(actarAction) AND status.MaxHp le 0 OR UnityEngine.Object.op_Inequality(actarAction) AND status.MaxHp gt 0 OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 524, 1) lt 1 AND UnityEngine.Object.op_Inequality(actarAction) AND status.MaxHp le 0`

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `Count`: stack / hit counter
- `HateRate`: aggro (hate) generation %
- `RateDamageResist`: damage taken multiplier
- `Value`: generic value (meaning set by the code that reads the buff)

**In-game level notes**

- Lv17: *เฮทเพิ่มขึ้นUP *เพิ่มพลังการลดอัตราความเสียหาย *ระหว่างใช้[วอร์คราย]จะเพิ่มความต้านทานหวาดกลัว

**Where else this skill takes effect**

- Effect applied in `KnightHeal$$Damaged` (11 guarded paths):
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
- Effect applied in `MobaPlayerSecondaryStatus$$get_Vit` (3 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `(MobaPlayerSecondaryStatus.CalcBaseSecondaryStatus(this, [CharacterActionManagerBase.get_IsLocalDead()+0x1c], 8, 3) + [TryGetBuf.out2()+0x10])`
    - calls `virtual CharacterActionManagerBase.get_IsLocalDead`, `MobaPlayerSecondaryStatus$$CalcBaseSecondaryStatus`, `virtual CharacterActionManagerBase.get_IsValid`
  - when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual CharacterActionManagerBase.get_IsLocalDead`, `MobaPlayerSecondaryStatus$$CalcBaseSecondaryStatus`, `virtual CharacterActionManagerBase.get_IsValid`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-24), 0) & 1) eq 0`
    - returns `MobaPlayerSecondaryStatus.CalcBaseSecondaryStatus(this, [CharacterActionManagerBase.get_IsLocalDead()+0x1c], 8, 3)`
    - calls `virtual CharacterActionManagerBase.get_IsLocalDead`, `MobaPlayerSecondaryStatus$$CalcBaseSecondaryStatus`, `virtual CharacterActionManagerBase.get_IsValid`
- Effect applied in `KnightStanceAction$$ActionHit` (7 guarded paths):
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
- Effect applied in `PlayerActionManager$$DamagedKnightHeal` (13 guarded paths):
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
- Effect applied in `PlayerSecondaryStatus$$get_Vit` (3 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `(PlayerSecondaryStatus.CalcBaseSecondaryStatus(this, [CharacterActionManagerBase.get_IsLocalDead()+0x1c], 8, 3) + [TryGetBuf.out2()+0x10])`
    - calls `virtual CharacterActionManagerBase.get_IsLocalDead`, `PlayerSecondaryStatus$$CalcBaseSecondaryStatus`, `virtual CharacterActionManagerBase.get_IsValid`
  - when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual CharacterActionManagerBase.get_IsLocalDead`, `PlayerSecondaryStatus$$CalcBaseSecondaryStatus`, `virtual CharacterActionManagerBase.get_IsValid`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 521, stkp(-24), 0) & 1) eq 0`
    - returns `PlayerSecondaryStatus.CalcBaseSecondaryStatus(this, [CharacterActionManagerBase.get_IsLocalDead()+0x1c], 8, 3)`
    - calls `virtual CharacterActionManagerBase.get_IsLocalDead`, `PlayerSecondaryStatus$$CalcBaseSecondaryStatus`, `virtual CharacterActionManagerBase.get_IsValid`
- Effect applied in `PhotonListener$$OnActionMobAttack` (52 guarded paths):
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
- Effect applied in `PlayerSecondaryStatus$$GetDisplayBonusCalcHate` (299 guarded paths, truncated):
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
- Effect applied in `MobaPlayerActionManager$$ReceiveDamaged` (296 guarded paths, truncated):
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
- Effect applied in `MobAttackBase$$CalcLastDamage` (300 guarded paths, truncated):
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
- Code that reads this skill's level / buff by constant id: `KnightHeal$$Damaged (ContainsBuffer)`, `KnightStanceAction$$ActionHit (TryGetBuf)`, `MobAttackBase$$CalcLastDamage (TryGetBuf)`, `MobAttackBase$$SetAbnormalEffect (TryGetBuf)`, `MobaPlayerActionManager$$ReceiveDamaged (TryGetBuf)`, `MobaPlayerSecondaryStatus$$get_Vit (TryGetBuf)`, `PhotonListener$$OnActionMobAttack (TryGetBuf)`, `PlayerActionManager$$DamagedKnightHeal (ContainsBuffer)`, `PlayerSecondaryStatus$$GetDisplayBonusCalcHate (TryGetBuf)`, `PlayerSecondaryStatus$$get_Vit (TryGetBuf)`

_Raw recovered data (every method item): [trees/KnightSkill.md](../trees/KnightSkill.md) — uid 521_

---

### แพรี่ (Parry) · uid 515

<img src="../../icons/sk_515.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 35 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** แอสเซาต์แอคแทค · **Client class:** `Parry` (passive mastery)

> ปัดป้องการโจมตีด้วยอาวุธ
> มีโอกาสลดความเสียหายทางกายภาพ
> สกิลนี้จะไม่เกิดพร้อมปฏิกิริยา  Guard

**How it works**

- Mastery skill of the ナイトスキル tree (tier 2, max Lv 35); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Trigger (trigger chance (%)) 5 at Lv1 to 30 at Lv10, CutDmgRate (damage taken reduction %) 10 at Lv1 to 20 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Trigger | 5 | 10 | 15 | 20 | 25 | 10 | 15 | 20 | 25 | 30 |
| CutDmgRate | 10 | 10 | 10 | 10 | 10 | 20 | 20 | 20 | 20 | 20 |


Bonus meanings (inferred from the names):

- `Trigger`: trigger chance (%)
- `CutDmgRate`: damage taken reduction %

_Raw recovered data (every method item): [trees/KnightSkill.md](../trees/KnightSkill.md) — uid 515_

---

### เรจซอร์ด (RageSword) · uid 516

<img src="../../icons/sk_516.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 2) · **Type:** Attack · **Max Lv:** 35 · **Weapons:** OneHandSword, TwoHandSword · **Requires:** โพรโวค · **Flags:** MercenaryCanUseSkill · **Client class:** `RageSwordAction`

> โจมตีโดยปลดปล่อยจิตสังหารที่มี
> เป็นการโจมตีพิเศษที่ทำให้เกิดเฮทจำนวนมาก
> ถ้าตกเป็นเป้าอัตราคริติคอลจะเพิ่มขึ้น
> MP ที่ใช้ในสกิลถัดไปจะลดลงกึ่งหนึ่ง

**How it works**

- Attack skill of the ナイトスキル tree (tier 2, max Lv 35); usable with OneHandSword, TwoHandSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [subWeapon != Shield]: skill multiplier ×1.6 at Lv1 to 2.5 at Lv10; flat damage +55 at Lv1 to 100 at Lv10
  - `calcPlayerToMobDamage` [subWeapon == Shield]: skill multiplier depends on Vit (formula below); flat damage +155 at Lv1 to 200 at Lv10
  - `calcPlayerToMobDamage` [(+0x109 & 2) ne 0 AND Lv eq 10 AND UnityEngine.Object.op_Inequality(actarAction)]: skill multiplier depends on Vit (formula below)
  - `calcPlayerToMobDamage`: skill multiplier depends on Vit (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Buffs:
  - `RageSwordBuf`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (2 lookups; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 6 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionPreparation` — before the cast starts: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 3 set, 2 tpl, 1 info
- `ActionHit` — when the attack connects: 1 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 1.6 | 1.7 | 1.8 | 1.9 | 2 | 2.1 | 2.2 | 2.3 | 2.4 | 2.5 |
| Flat dmg + [subWeapon == Shield] | 155 | 160 | 165 | 170 | 175 | 180 | 185 | 190 | 195 | 200 |
| Flat dmg + [subWeapon != Shield] | 55 | 60 | 65 | 70 | 75 | 80 | 85 | 90 | 95 | 100 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((((((Lv * 10) + 150) + (((status.Vit lt 0 ? (status.Vit + 1) : status.Vit) >> 1) + 30))) + gemCart(1019[4])) / 100)` — subWeapon == Shield
- SkillRate × `((((((Lv * 10) + 150) + (((status.Vit lt 0 ? (status.Vit + 1) : status.Vit) >> 1) + 30))) + gemCart(1019[4])) / 100)` — (+0x109 & 2) ne 0 AND Lv eq 10 AND UnityEngine.Object.op_Inequality(actarAction)
- SkillRate × `((((((Lv * 10) + 150) + (((status.Vit lt 0 ? (status.Vit + 1) : status.Vit) >> 1) + 30))) + gemCart(1019[4])) / 100)`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((((Lv * 10) + 150) + (((status.Vit lt 0 ? (status.Vit + 1) : status.Vit) >> 1) + 30))) + gemCart(1019[4])) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `((((Lv + (Lv << 2)) + 50) + 100))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 516
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): adds the caster's buff of skill 516 (RageSword) — `AddSelfBuffer(516, Lv, Id)`
  - when `MobaMode eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND isHateTarget ne 0`

**Buff values** (every recovered field; durations in seconds)

**Buff `RageSwordBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff fields set in the constructor (all recovered):
  - `Level` = `257` = 257
  - `BuffEffectActive` = `1` = 1
  - `BufEffectTakeUid` = `-1` = -1

**In-game level notes**

- Lv17: *พลัง+30 *พลังจะเพิ่มมากกว่าค่า VIT ของตัวเอง *พลังสกิล+100

**Where else this skill takes effect**

- Effect applied in `PlayerAttackBase$$CalcCostMp` (300 guarded paths, truncated):
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
- Effect applied in `PlayerAttackBase$$RemoveAfterSkillBuf` (300 guarded paths, truncated):
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
- Code that reads this skill's level / buff by constant id: `PlayerAttackBase$$CalcCostMp (ContainsBuffer)`, `PlayerAttackBase$$RemoveAfterSkillBuf (ContainsBuffer)`

_Raw recovered data (every method item): [trees/KnightSkill.md](../trees/KnightSkill.md) — uid 516_

---

### โซนิคทรัสต์ (SonicThrust) · uid 522

<img src="../../icons/sk_522.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 2) · **Type:** Attack · **Max Lv:** 35 · **Weapons:** OneHandSword · **Requires:** เรจซอร์ด · **Client class:** `SonicThrustAction`

> โจมตีด้วยรัศมีแห่งดาบทำให้ศัตรูสูญเสียความสมดุล
> เป้าหมายมีโอกาส[ล้มคว่ำ]

**How it works**

- Attack skill of the ナイトスキル tree (tier 2, max Lv 35); usable with OneHandSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [subWeapon != Shield]: skill multiplier ×1.65 at Lv1 to 3 at Lv10
  - `calcPlayerToMobDamage` [subWeapon == Shield]: skill multiplier depends on Dex (formula below)
  - `calcPlayerToMobDamage`: flat damage +200
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Tumble (2).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(8)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 6 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 2 call, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 1.65 | 1.8 | 1.95 | 2.1 | 2.25 | 2.4 | 2.55 | 2.7 | 2.85 | 3 |
| Flat dmg + | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((((((Lv << 4) - Lv) + 150) + status.Dex)) / 100)` — subWeapon == Shield

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((((Lv << 4) - Lv) + 150) + status.Dex)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(200)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 522
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Rolls `percent`% to inflict **Tumble (2)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND hasGemCart(217) OR !PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND hasGemCart(217) OR !hasGemCart(217) AND PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction)`
- Marks the hit with ailment **Tumble (2)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND hasGemCart(217) OR !hasGemCart(217) AND PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction)`

**Other recovered parameters**

- **Effect percent** (`percent`): `((Lv + (Lv << 2)) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]

**In-game level notes**

- Lv17: *พลังเพิ่มขึ้นตามค่า DEX *ถ้าผลของล้มคว่ำถูกป้องกันเนื่องจากเวลาต้านทาน จะฟื้นพู MP ขึ้นมาเล็กน้อย

_Raw recovered data (every method item): [trees/KnightSkill.md](../trees/KnightSkill.md) — uid 522_

---

### N$Pดีเฟนส์$F$เพอร์เฟกต์ดีเฟนส์ (P_Deffence) · uid 517

<img src="../../icons/sk_517.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 3) · **Type:** Buffer · **Max Lv:** 125 · **Weapons:** Shield · **Requires:** แพรี่ · **Client class:** `P_DeffenceAction`

> ปกป้องสมบูรณ์แบบ
> ลดค่าความเสียหายให้เหลือ 0 ด้วยโล่
> ฟื้นฟู HP เล็กน้อย

**How it works**

- Buffer skill of the ナイトスキル tree (tier 3, max Lv 125); usable with Shield.
- It installs a buff on the caster.
- Buffs:
  - `P_DeffenceActionBuf`: lasts `1` s
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (7 lookups; see the last section).

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 1 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionStart` — when the cast starts: 1 set, 1 call
- `ActionSkillEvent` — on an animation/skill event during the motion: 1 set
- `.<>c__DisplayClass26_0::<ActionPreparation>b__0` — skill-specific method: 1 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 517
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): adds the caster's buff of skill 517 (P_Deffence) — `AddSelfBuffer(517, Lv, Id)`
- `.<>c__DisplayClass26_0::<ActionPreparation>b__0` (method): adds the caster's buff of `AfterShieldBuf.CreateDefaultBuf(<>c__DisplayClass26_0.afterShieldLv)` — `AddSelfBuffer(AfterShieldBuf.CreateDefaultBuf(<>c__DisplayClass26_0.afterShieldLv), 0)`

**Buff values** (every recovered field; durations in seconds)

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

**Where else this skill takes effect**

- Effect applied in `MobAttackBase$$InvalidDamage` (11 guarded paths):
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
- Effect applied in `PlayerAttackBase$$RemoveAfterSkillBuf` (300 guarded paths, truncated):
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
- Effect applied in `P_DeffenceAction$$ActionSkillEvent` (3 guarded paths):
  - when `MobaMode ne 0`
    - returns `SkillBufferManager.ContainsBuffer(?blr, 517, 0, ?x3)`
    - set `isCancel` = `(?mvn & 1)`
  - when `MobaMode eq 0`
    - returns `SkillBufferManager.ContainsBuffer(?blr, 517, 0, ?x3)`
    - set `isCancel` = `(?mvn & 1)`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 517, 0, ?x3)`
    - set `isCancel` = `(?mvn & 1)`
- Effect applied in `MobaPlayerActionManager$$ReceiveDamaged` (296 guarded paths, truncated):
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
- Code that reads this skill's level / buff by constant id: `MobAttackBase$$InvalidDamage (ContainsBuffer)`, `MobAttackPlayerSelfDestruct$$calcMobToPlayerDamage (ContainsBuffer)`, `MobaPlayerActionManager$$Damaged (ContainsBuffer)`, `MobaPlayerActionManager$$ReceiveDamaged (ContainsBuffer)`, `P_DeffenceAction$$ActionSkillEvent (ContainsBuffer)`, `PlayerActionManager$$Damaged (ContainsBuffer)`, `PlayerAttackBase$$RemoveAfterSkillBuf (ContainsBuffer)`

_Raw recovered data (every method item): [trees/KnightSkill.md](../trees/KnightSkill.md) — uid 517_

---

### ไบด์สไตร์ค (BindStrike) · uid 518

<img src="../../icons/sk_518.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 3) · **Type:** Attack · **Max Lv:** 125 · **Weapons:** OneHandSword, TwoHandSword · **Requires:** เรจซอร์ด · **Flags:** MercenaryCanUseSkill · **Client class:** `BindStrikeAction`

> โจมตีศัตรูด้วยคลื่นพลังทำลายล้าง
> มีโอกาสทำให้เป้าหมาย[หยุดนิ่ง]
> การโจมตีพิเศษที่จะทำให้เกิดเฮทจำนวนมาก

**How it works**

- Attack skill of the ナイトスキル tree (tier 3, max Lv 125); usable with OneHandSword, TwoHandSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [mainWeapon == TwoHandSword AND subWeapon != Shield OR mainWeapon != TwoHandSword AND subWeapon != Shield & isEquipShield eq 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND hasGemCart(1021) AND isEquipShield eq 0]: skill multiplier ×4.55 at Lv1 to 5 at Lv10
  - `calcPlayerToMobDamage` [mainWeapon == TwoHandSword AND subWeapon == Shield OR mainWeapon != TwoHandSword AND subWeapon == Shield & UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND hasGemCart(1021) AND isEquipShield ne 0 OR !hasGemCart(1021) AND PlayerAttackBase.checkAbnormalPercent(this, 12, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0]: skill multiplier depends on Vit (formula below)
  - `calcPlayerToMobDamage` [mainWeapon == TwoHandSword AND subWeapon != Shield OR mainWeapon != TwoHandSword AND subWeapon != Shield & UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND hasGemCart(1021) AND isEquipShield ne 0 OR !hasGemCart(1021) AND PlayerAttackBase.checkAbnormalPercent(this, 12, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0]: skill multiplier depends on Vit (formula below)
  - `calcPlayerToMobDamage` [(+0x109 & 2) ne 0 AND Lv eq 10 AND UnityEngine.Object.op_Inequality(actarAction) & UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND hasGemCart(1021) AND isEquipShield ne 0 OR !hasGemCart(1021) AND PlayerAttackBase.checkAbnormalPercent(this, 12, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0]: skill multiplier depends on Vit (formula below)
  - `calcPlayerToMobDamage` [mainWeapon == TwoHandSword AND subWeapon == Shield OR mainWeapon != TwoHandSword AND subWeapon == Shield & isEquipShield eq 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND hasGemCart(1021) AND isEquipShield eq 0]: skill multiplier depends on Vit (formula below)
  - `calcPlayerToMobDamage` [(+0x109 & 2) ne 0 AND Lv eq 10 AND UnityEngine.Object.op_Inequality(actarAction) & isEquipShield eq 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND hasGemCart(1021) AND isEquipShield eq 0]: skill multiplier depends on Vit (formula below)
  - `calcPlayerToMobDamage` [mainWeapon == TwoHandSword AND subWeapon == Shield OR mainWeapon != TwoHandSword AND subWeapon == Shield]: flat damage +210 at Lv1 to 300 at Lv10
  - `calcPlayerToMobDamage` [mainWeapon == TwoHandSword AND subWeapon != Shield OR mainWeapon != TwoHandSword AND subWeapon != Shield]: flat damage +60 at Lv1 to 150 at Lv10
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Stun (3), Stop (12).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- **Range** (`range`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance((floor((Lv * 0.1)) + (floor((Lv * 0.175)) + 3)))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 9 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionPreparation` — before the cast starts: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 3 tpl, 4 call, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 4.55 | 4.6 | 4.65 | 4.7 | 4.75 | 4.8 | 4.85 | 4.9 | 4.95 | 5 |
| Flat dmg + [mainWeapon == TwoHandSword AND subWeapon == Shield OR mainWeapon != TwoHandSword AND subWeapon == Shield] | 210 | 220 | 230 | 240 | 250 | 260 | 270 | 280 | 290 | 300 |
| Flat dmg + [mainWeapon == TwoHandSword AND subWeapon != Shield OR mainWeapon != TwoHandSword AND subWeapon != Shield] | 60 | 70 | 80 | 90 | 100 | 110 | 120 | 130 | 140 | 150 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((((((Lv * 5) + 450) + (status.Vit + 150))) + status.Vit) / 100)` — mainWeapon == TwoHandSword AND subWeapon == Shield OR mainWeapon != TwoHandSword AND subWeapon == Shield & UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND hasGemCart(1021) AND isEquipShield ne 0 OR !hasGemCart(1021) AND PlayerAttackBase.checkAbnormalPercent(this, 12, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0
- SkillRate × `((((((Lv * 5) + 450) + (status.Vit + 150))) + status.Vit) / 100)` — mainWeapon == TwoHandSword AND subWeapon != Shield OR mainWeapon != TwoHandSword AND subWeapon != Shield & UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND hasGemCart(1021) AND isEquipShield ne 0 OR !hasGemCart(1021) AND PlayerAttackBase.checkAbnormalPercent(this, 12, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0
- SkillRate × `((((((Lv * 5) + 450) + (status.Vit + 150))) + status.Vit) / 100)` — (+0x109 & 2) ne 0 AND Lv eq 10 AND UnityEngine.Object.op_Inequality(actarAction) & UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND hasGemCart(1021) AND isEquipShield ne 0 OR !hasGemCart(1021) AND PlayerAttackBase.checkAbnormalPercent(this, 12, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0
- SkillRate × `(((((Lv * 5) + 450) + (status.Vit + 150))) / 100)` — mainWeapon == TwoHandSword AND subWeapon == Shield OR mainWeapon != TwoHandSword AND subWeapon == Shield & isEquipShield eq 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND hasGemCart(1021) AND isEquipShield eq 0
- SkillRate × `(((((Lv * 5) + 450) + (status.Vit + 150))) / 100)` — (+0x109 & 2) ne 0 AND Lv eq 10 AND UnityEngine.Object.op_Inequality(actarAction) & isEquipShield eq 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND hasGemCart(1021) AND isEquipShield eq 0

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((((Lv * 5) + 450) + (status.Vit + 150))) + status.Vit) / 100)`
  - when `UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND hasGemCart(1021) AND isEquipShield ne 0 OR !hasGemCart(1021) AND PlayerAttackBase.checkAbnormalPercent(this, 12, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `((((Lv * 10) + 50) + 150))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv * 5) + 450) + (status.Vit + 150))) / 100)`
  - when `isEquipShield eq 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND hasGemCart(1021) AND isEquipShield eq 0`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 518
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Rolls `percent`% to inflict **Stun (3)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 3, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND hasGemCart(1021) AND isEquipShield eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 3, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND hasGemCart(1021) AND isEquipShield eq 0 OR PlayerAttackBase.checkAbnormalPercent(this, 3, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND hasGemCart(1021) AND isEquipShield ne 0`
- Marks the hit with ailment **Stun (3)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 3, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND hasGemCart(1021) AND isEquipShield eq 0 OR PlayerAttackBase.checkAbnormalPercent(this, 3, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND hasGemCart(1021) AND isEquipShield ne 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND PlayerAttackBase.checkAbnormalPercent(this, 3, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_transform(mobAction), target) AND hasGemCart(1021) AND isEquipShield ne 0`
- Rolls `percent`% to inflict **Stop (12)** (`calcPlayerToMobDamage`)
  - when `!hasGemCart(1021) AND PlayerAttackBase.checkAbnormalPercent(this, 12, percent, playerAction) AND isEquipShield eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 12, percent, playerAction) AND !hasGemCart(1021) AND isEquipShield eq 0 OR !hasGemCart(1021) AND PlayerAttackBase.checkAbnormalPercent(this, 12, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0`
- Marks the hit with ailment **Stop (12)** (`calcPlayerToMobDamage`)
  - when `!hasGemCart(1021) AND PlayerAttackBase.checkAbnormalPercent(this, 12, percent, playerAction) AND isEquipShield eq 0 OR !hasGemCart(1021) AND PlayerAttackBase.checkAbnormalPercent(this, 12, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEquipShield ne 0 OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND !hasGemCart(1021) AND PlayerAttackBase.checkAbnormalPercent(this, 12, percent, playerAction) AND isEquipShield ne 0`

**Other recovered parameters**

- **Range** (`range`): `MathUtil.DisplayMeterToDistance((floor((Lv * 0.1)) + (floor((Lv * 0.175)) + 3)))`
- **Effect percent** (`percent`): `((Lv + (Lv << 2)) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]

**In-game level notes**

- Lv17: *พลัง+150 *พลังจะเพิ่มมากกว่าค่า VIT ของตัวเอง *พลังสกิล+150

_Raw recovered data (every method item): [trees/KnightSkill.md](../trees/KnightSkill.md) — uid 518_

---

### เรเวอเนีย (Levenir) · uid 523

<img src="../../icons/sk_523.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 3) · **Type:** Attack · **Max Lv:** 125 · **Weapons:** OneHandSword · **Requires:** โซนิคทรัสต์ · **Client class:** `LevenirAction`

> การโจมตีศัตรูทรงพลังที่ขวางทางอย่างรุนแรง
> หากตรงตามเงื่อนไขจำนวน HIT จะเพิ่มขึ้น(สูงสุด 3HIT)
> แต่ถ้าติดสภาวะผิดปกติใดๆ ผลของการ
> เพิ่มจำนวน HIT จะไม่ทำงาน
> การโจมตีนี้จะไม่ทำให้เกิดการแบ่งสัดส่วน

**How it works**

- Attack skill of the ナイトスキル tree (tier 3, max Lv 125); usable with OneHandSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Damage (`calcPlayerToMobDamage` x3; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [1 ge maxAttackCount AND maxAttackCount ge 1 OR 1 lt maxAttackCount AND 2 ge maxAttackCount AND maxAttackCount ge 1 OR 1 lt maxAttackCount AND 2 lt maxAttackCount AND 3 ge maxAttackCount AND maxAttackCount ge 1]: skill multiplier depends on live values (formula below); flat damage +40 at Lv1 to 400 at Lv10
- Proration: physical-skill proration slot, mode `never (IsExpDefFluctuate=false)`.
- Buffs:
  - `LevenirBuf`: marker buff (no parameters; other code tests whether it is present)
  - `CountBufferBase`
- Other client code reads this skill (7 lookups; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionPreparation` — before the cast starts: 3 set, 1 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 3 info
- `AbnormalStack` — skill-specific method: 3 call
- `Damaged` — when the caster takes damage while the action / buff is active: 3 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 40 | 80 | 120 | 160 | 200 | 240 | 280 | 320 | 360 | 400 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv * 10) + 500) + (baseDEX << 1))) / 100)` — 1 ge maxAttackCount AND maxAttackCount ge 1 OR 1 lt maxAttackCount AND 2 ge maxAttackCount AND maxAttackCount ge 1 OR 1 lt maxAttackCount AND 2 lt maxAttackCount AND 3 ge maxAttackCount AND maxAttackCount ge 1

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv * 10) + 500) + (baseDEX << 1))) / 100)`
  - when `1 ge maxAttackCount AND maxAttackCount ge 1 OR 1 lt maxAttackCount AND 2 ge maxAttackCount AND maxAttackCount ge 1 OR 1 lt maxAttackCount AND 2 lt maxAttackCount AND 3 ge maxAttackCount AND maxAttackCount ge 1`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv + (Lv << 2)) << 3))`
  - when `1 ge maxAttackCount AND maxAttackCount ge 1 OR 1 lt maxAttackCount AND 2 ge maxAttackCount AND maxAttackCount ge 1 OR 1 lt maxAttackCount AND 2 lt maxAttackCount AND 3 ge maxAttackCount AND maxAttackCount ge 1`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `never (IsExpDefFluctuate=false)`, attack type `Physics`, action id 523
- Uses the physical-skill proration slot but never changes monster proration: IsExpDefFluctuate=false.

**Hit counts**

- Max attacks (`maxAttackCount`): `((SkillBufferDataBase.GetParam(20) lt 2 ? SkillBufferDataBase.GetParam(20) : 2) + maxAttackCount)`
  - when `IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) ne 1 AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) eq 1 AND SkillBufferDataBase.GetParam(20) le 0 AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) eq 1 AND SkillBufferDataBase.GetParam(20) gt 0 AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)`
- Loop / hit-repeat count (`LoopParam`): `((SkillBufferDataBase.GetParam(20) lt 2 ? SkillBufferDataBase.GetParam(20) : 2) + maxAttackCount)`
  - when `IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) eq 1 AND SkillBufferDataBase.GetParam(20) le 0 AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) eq 1 AND SkillBufferDataBase.GetParam(20) gt 0 AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)`
- Loop / hit-repeat count (`LoopParam`): `maxAttackCount`
  - when `System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)`

**Buffs and effects it installs or removes**

- `ActionPreparation` (before the cast starts): removes the caster's buff of skill 523 (Levenir) — `RemoveSelfBuffer(523)`
  - when `IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) eq 1 AND SkillBufferDataBase.GetParam(20) le 0 AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)`
- `AbnormalStack` (method): removes the caster's buff of skill 523 (Levenir) — `RemoveSelfBuffer(523)`
  - when `!UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>(actor), 0) AND !UnityEngine.Object.op_Equality(actor) AND (SkillBufferDataBase.GetParam(20) + ((type - 1) lo 3 ? ?bfi : 0)) lt 1 AND (type - 1) ls 2 AND EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator) eq 17 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 OR !UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>(actor), 0) AND !UnityEngine.Object.op_Equality(actor) AND (SkillBufferDataBase.GetParam(20) + ((type - 1) lo 3 ? ?bfi : 0)) eq 1 AND (SkillBufferDataBase.GetParam(20) + ((type - 1) lo 3 ? ?bfi : 0)) ge 1 AND (type - 1) ls 2 AND EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator) eq 17 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 OR !UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>(actor), 0) AND !UnityEngine.Object.op_Equality(actor) AND ((SkillBufferDataBase.GetParam(20) + ((type - 1) lo 3 ? ?bfi : 0)) - 1) eq 1 AND (SkillBufferDataBase.GetParam(20) + ((type - 1) lo 3 ? ?bfi : 0)) ge 1 AND (SkillBufferDataBase.GetParam(20) + ((type - 1) lo 3 ? ?bfi : 0)) ne 1 AND (type - 1) ls 2 AND EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator) eq 17 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0`
- `AbnormalStack` (method): constructs `LevenirBuf` — `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1))`
  - when `!UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>(actor), 0) AND !UnityEngine.Object.op_Equality(actor) AND (type - 1) ls 2 AND EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator) eq 17 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 OR !UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>(actor), 0) AND !UnityEngine.Object.op_Equality(actor) AND (SkillBufferDataBase.GetParam(20) + ((type - 1) lo 3 ? ?bfi : 0)) lt 1 AND (type - 1) ls 2 AND EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator) eq 17 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 OR !UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>(actor), 0) AND !UnityEngine.Object.op_Equality(actor) AND (SkillBufferDataBase.GetParam(20) + ((type - 1) lo 3 ? ?bfi : 0)) eq 1 AND (SkillBufferDataBase.GetParam(20) + ((type - 1) lo 3 ? ?bfi : 0)) ge 1 AND (type - 1) ls 2 AND EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator) eq 17 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0`
- `AbnormalStack` (method): adds the caster's buff of `new LevenirBuf` — `AddSelfBuffer(new LevenirBuf, 0)`
  - when `!UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>(actor), 0) AND !UnityEngine.Object.op_Equality(actor) AND (type - 1) ls 2 AND EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator) eq 17 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 OR !UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>(actor), 0) AND !UnityEngine.Object.op_Equality(actor) AND (SkillBufferDataBase.GetParam(20) + ((type - 1) lo 3 ? ?bfi : 0)) lt 1 AND (type - 1) ls 2 AND EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator) eq 17 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 OR !UnityEngine.Object.op_Equality(UnityEngine.GameObject.GetComponent<PlayerActionManagerBase>(actor), 0) AND !UnityEngine.Object.op_Equality(actor) AND (SkillBufferDataBase.GetParam(20) + ((type - 1) lo 3 ? ?bfi : 0)) eq 1 AND (SkillBufferDataBase.GetParam(20) + ((type - 1) lo 3 ? ?bfi : 0)) ge 1 AND (type - 1) ls 2 AND EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().subWeaponCalculator) eq 17 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0`
- `Damaged` (when the caster takes damage while the action / buff is active): removes the caster's buff of skill 523 (Levenir) — `RemoveSelfBuffer(523)`
  - when `(SkillBufferDataBase.GetParam(20) + 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 OR (SkillBufferDataBase.GetParam(20) + 1) eq 1 AND (SkillBufferDataBase.GetParam(20) + 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 OR ((SkillBufferDataBase.GetParam(20) + 1) - 1) eq 1 AND (SkillBufferDataBase.GetParam(20) + 1) ge 1 AND (SkillBufferDataBase.GetParam(20) + 1) ne 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0`
- `Damaged` (when the caster takes damage while the action / buff is active): constructs `LevenirBuf` — `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1))`
  - when `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 OR (SkillBufferDataBase.GetParam(20) + 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 OR (SkillBufferDataBase.GetParam(20) + 1) eq 1 AND (SkillBufferDataBase.GetParam(20) + 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0`
- `Damaged` (when the caster takes damage while the action / buff is active): adds the caster's buff of `new LevenirBuf` — `AddSelfBuffer(new LevenirBuf, 0)`
  - when `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 OR (SkillBufferDataBase.GetParam(20) + 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 OR (SkillBufferDataBase.GetParam(20) + 1) eq 1 AND (SkillBufferDataBase.GetParam(20) + 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 523, 1) ne TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523).Level AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0`

**Other recovered parameters**

- **Max attacks** (`maxAttackCount`): `((SkillBufferDataBase.GetParam(20) lt 2 ? SkillBufferDataBase.GetParam(20) : 2) + maxAttackCount)` _(when IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) ne 1 AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) eq 1 AND SkillBufferDataBase.GetParam(20) le 0 AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) eq 1 AND SkillBufferDataBase.GetParam(20) gt 0 AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 AND UnityEngine.Object.op_Inequality(actarAction))_
- **Loop / hit-repeat count** (`LoopParam`): `((SkillBufferDataBase.GetParam(20) lt 2 ? SkillBufferDataBase.GetParam(20) : 2) + maxAttackCount)` _(when IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) eq 1 AND SkillBufferDataBase.GetParam(20) le 0 AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523), LevenirBuf) eq 1 AND SkillBufferDataBase.GetParam(20) gt 0 AND System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 523) ne 0 AND UnityEngine.Object.op_Inequality(actarAction))_; `maxAttackCount` _(when System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) eq 0 AND UnityEngine.Object.op_Inequality(actarAction) OR System.Linq.Enumerable.Count<AbnormalData>(System.Linq.Enumerable.Where<AbnormalData>(AbnormalStateManager.get_AbnormalList(PlayerStatusBase.get_AbnormalStatusManager()), LevenirAction.<>c.<>9__25_0)) ne 0 AND UnityEngine.Object.op_Inequality(actarAction))_

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `Count`: stack / hit counter

**In-game level notes**

- Lv17: *การันตีคริติตอล  *จำนวน HIT จะเพิ่มขึ้น 1 เมื่อ Pดีเฟนส์สำเร็จ *จำนวน HIT จะเพิ่มขึ้น 1 เมื่อทำให้ผงะ *จำนวน HIT จะเพิ่มขึ้น 3 เมื่อทำให้ล้มคว่ำ *จำนวน HIT จะเพิ่มขึ้น 5 เมื่อทำให้หมดสติ *สามารถสะสมผลที่เพิ่มได้จนถึงสกิลเลเวล

**Where else this skill takes effect**

- Effect applied in `LevenirAction$$AbnormalStack` (10 guarded paths):
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
- Effect applied in `LevenirAction$$ActionPreparation` (4 guarded paths):
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
- Effect applied in `LevenirAction$$Damaged` (9 guarded paths):
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
- Code that reads this skill's level / buff by constant id: `LevenirAction$$AbnormalStack (GetSkillLv)`, `LevenirAction$$AbnormalStack (TryGetBuf)`, `LevenirAction$$ActionPreparation (TryGetBuf)`, `LevenirAction$$Damaged (GetSkillLv)`, `LevenirAction$$Damaged (TryGetBuf)`, `PlayerActionManager$$Damaged (GetSkillLv)`, `PlayerActionManager$$Damaged (TryGetBuf)`

_Raw recovered data (every method item): [trees/KnightSkill.md](../trees/KnightSkill.md) — uid 523_

---

### ฟาเรส (Fearless) · uid 519

<img src="../../icons/sk_519.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 4) · **Type:** Buffer · **Max Lv:** 205 · **Weapons:** Shield · **Requires:** N$Pดีเฟนส์$F$เพอร์เฟกต์ดีเฟนส์ · **Flags:** StarGem · **Client class:** `FearlessAction`

> ผลจะเพิ่มขึ้นเมื่ออยู่ในสภาพหยุดนิ่ง(5 ระดับ)
> เพิ่มความเร็วการโจมตี, อาวุธเจาะเข้า, การโจมตีปกติ,
> อัตราส่วนการลดความเสียหาย
> 
> ความเร็วการโจมตีและอาวุธเจาะเข้าจะได้รับอิทธิพลจากค่า VIT ของตัวเอง

**How it works**

- Buffer skill of the ナイトスキル tree (tier 4, max Lv 205); usable with Shield.
- It installs a buff on the caster.
- Its buff raises normal-attack damage (`NormalAttackRate` / `NormalAttackConstantDamage`).
- Buffs:
  - `FearlessBuf`: lasts `240` s
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (1 lookup; see the last section).

**When each part runs**

- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 2 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 519
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `FearlessBuf` — `.ctor(Lv, actarAction)`
  - when `!UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR MobaMode eq 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): adds the caster's buff of `new FearlessBuf` — `AddSelfBuffer(new FearlessBuf, 0)`
  - when `!UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) OR MobaMode eq 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction)`

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `Aspd`: attack speed +
- `MobLastDamageRateBuf`: final damage multiplier vs monsters (buff category)
- `NormalAttackRate`: normal-attack damage multiplier (%)
- `PowerResistBreaker`: physical pierce

**Where else this skill takes effect**

- Effect applied in `ArialSlayAction$$ActionStart` (20 guarded paths):
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
- Code that reads this skill's level / buff by constant id: `ArialSlayAction$$ActionStart (ContainsBuffer)`

_Raw recovered data (every method item): [trees/KnightSkill.md](../trees/KnightSkill.md) — uid 519_

---

### ไนท์วีล (KnightWill) · uid 520

<img src="../../icons/sk_520.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 4) · **Type:** Mastery · **Max Lv:** 205 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ไบด์สไตร์ค · **Flags:** StarGem · **Client class:** `KnightWill` (passive mastery)

> จะมีผลเมื่อความรู้สึกเป็นศัตรูของเป้าหมายมุ่งมาที่ตัวเอง
> เฮทของตัวเองจะเพิ่มได้ง่ายยิ่งขึ้น
> เสริมประสิทธิภาพของสกิลอัศวิน Lv10 จนถึงทรีเลเวล 3
> (ไม่รวมสกิลในขั้นที่ 3 และขั้นที่ 4)

**How it works**

- Mastery skill of the ナイトスキル tree (tier 4, max Lv 205); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Its effect is applied by client code: `CallGolemNormalAttackAction$$ActionPreparation`, `HuntingOneNormalAttackAction$$ActionPreparation`, `PlayerAttackBase$$ActionPreparation`, `WarCryAction$$ActionPreparation` (formulas in the last section).
- Other client code reads this skill (4 lookups; see the last section).

**In-game level notes**

- Lv17: *เพิ่มค่าเฮท *เพิ่มพลังของแอสเซาต์แอคแทคLv10 เพิ่มปริมาณเฮทของโพรโวคLv10 *เพิ่มอัตราการเกิดแพรี่Lv10 *เพิ่มปริมาณเฮทและพลังของเรจซอร์ดLv10 *เพิ่มพลังของไบด์สไตร์คLv10 *เพิ่มขีดจำกัดการฟื้นฟูของPดีเฟ้นส์Lv10

**Where else this skill takes effect**

- Effect applied in `PlayerAttackBase$$ActionPreparation` (236 guarded paths, truncated):
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
- Effect applied in `CallGolemNormalAttackAction$$ActionPreparation` (3 guarded paths):
  - when `SkillLv(520) ge 1`
    - returns `MobManager.HasPlayerHateManager(TargetableListManagerBase<object>.get_Instance(meta(0x3974240, Method$TargetableListManagerBase<MobManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3)`
    - set `SkillParam` = `(SkillParam | 512)`
    - calls `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$HasPlayerHateManager`
  - when `SkillLv(520) ge 1`
    - returns `MobManager.HasPlayerHateManager(TargetableListManagerBase<object>.get_Instance(meta(0x3974240, Method$TargetableListManagerBase<MobManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3)`
    - calls `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$HasPlayerHateManager`
  - when `SkillLv(520) lt 1`
    - returns `SkillLv(520)`
- Effect applied in `HuntingOneNormalAttackAction$$ActionPreparation` (3 guarded paths):
  - when `SkillLv(520) ge 1`
    - returns `MobManager.HasPlayerHateManager(TargetableListManagerBase<object>.get_Instance(meta(0x3974240, Method$TargetableListManagerBase<MobManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3)`
    - set `SkillParam` = `(SkillParam | 512)`
    - calls `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$HasPlayerHateManager`
  - when `SkillLv(520) ge 1`
    - returns `MobManager.HasPlayerHateManager(TargetableListManagerBase<object>.get_Instance(meta(0x3974240, Method$TargetableListManagerBase<MobManager>.get_Instance()), ?x1, ?x2, ?x3), 0, ?x2, ?x3)`
    - calls `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$HasPlayerHateManager`
  - when `SkillLv(520) lt 1`
    - returns `SkillLv(520)`
- Effect applied in `WarCryAction$$ActionPreparation` (60 guarded paths):
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
- Code that reads this skill's level / buff by constant id: `CallGolemNormalAttackAction$$ActionPreparation (GetSkillLv)`, `HuntingOneNormalAttackAction$$ActionPreparation (GetSkillLv)`, `PlayerAttackBase$$ActionPreparation (GetSkillLv)`, `WarCryAction$$ActionPreparation (GetSkillLv)`

_Raw recovered data (every method item): [trees/KnightSkill.md](../trees/KnightSkill.md) — uid 520_

---

### ไนท์ฮีล (KnightHeal) · uid 524

<img src="../../icons/sk_524.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 4) · **Type:** Mastery · **Max Lv:** 205 · **Weapons:** OneHandSword · **Requires:** ไนท์สแตนซ์ · **Client class:** `KnightHeal` (passive mastery)

> ความเสียหายที่ได้รับระหว่างใช้ไนท์สแตนซ์
> จะมีบางส่วนที่ถูกสะสมไว้เพื่อใช้ฟื้นฟู HP
> และเมื่อใช้ไนท์สแตนซ์อีกครั้ง
> ค่าที่สะสมไว้ทั้งหมดจะถูกใช้เพื่อฟื้นฟู HP

**How it works**

- Mastery skill of the ナイトスキル tree (tier 4, max Lv 205); usable with OneHandSword.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Percent (generic percent) 1 at Lv1 to 10 at Lv10.
- Its effect is applied by client code: `KnightStanceAction$$ActionHit` (formulas in the last section).
- Other client code reads this skill (1 lookup; see the last section).

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Percent | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


Bonus meanings (inferred from the names):

- `Percent`: generic percent

**In-game level notes**

- Lv17: *สะสมความเสียหายให้มากขึ้น จากเป้าหมายที่มีเฮทตรงกัน

**Where else this skill takes effect**

- Effect applied in `KnightStanceAction$$ActionHit` (5 guarded paths):
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
- Code that reads this skill's level / buff by constant id: `KnightStanceAction$$ActionHit (GetSkillLv)`

_Raw recovered data (every method item): [trees/KnightSkill.md](../trees/KnightSkill.md) — uid 524_

---

### อาฟเตอร์ชีลด์ (AfterShield) · uid 525

<img src="../../icons/sk_525.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 285 · **Weapons:** OneHandSword · **Requires:** ฟาเรส · **Client class:** `AfterShield` (passive mastery)

> หลังจากเปิดใช้งานPดีเฟ้นส์
> จะลดความเสียหายลงได้ช่วงเวลาหนึ่ง
> 
> และถ้าเรียนรู้จะเพิ่มต้านทานไร้ธาตุเล็กน้อยแบบถาวร

**How it works**

- Mastery skill of the ナイトスキル tree (tier 5, max Lv 285); usable with OneHandSword.
- It installs a buff on the caster.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Buffs:
  - `AfterShieldBuf`
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Passive modifiers (negative = penalty): NormalResist (normal-element resistance) 1 at Lv1 to 10 at Lv10.
- Its effect is applied by client code: `MobAttackBase$$CalcLastDamage` (formulas in the last section).
- Other client code reads this skill (1 lookup; see the last section).

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `MobLastDamageRateBuf`: final damage multiplier vs monsters (buff category)

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| NormalResist | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


Bonus meanings (inferred from the names):

- `NormalResist`: normal-element resistance

**In-game level notes**

- Lv10: ถ้าได้รับความเสียหายร้ายแรงเกินHPสูงสุด ระหว่างอาฟเตอร์ชีลด์มีผลอยู่ความเสียหายนั้นจะไม่มีผล แต่หลังจากใช้งานไป 1 ครั้งจะไม่สามารถ ใช้งานอาฟเตอร์ชีลด์ได้อีกในระยะเวลาหนึ่ง

**Where else this skill takes effect**

- Effect applied in `MobAttackBase$$CalcLastDamage` (300 guarded paths, truncated):
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
- Code that reads this skill's level / buff by constant id: `MobAttackBase$$CalcLastDamage (TryGetBuf)`

_Raw recovered data (every method item): [trees/KnightSkill.md](../trees/KnightSkill.md) — uid 525_

---

### บลิงค์ซอร์ด (BlinkSword) · uid 526

<img src="../../icons/sk_526.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 5) · **Type:** Attack · **Max Lv:** 285 · **Weapons:** OneHandSword · **Requires:** ไนท์วีล · **Client class:** `BlinkSwordAction`

> ขว้างดาบและเข้าใกล้เป้าหมายทันที
> มีโอกาส[ผงะ]สามารถลดเปอร์เซ็นต์ความเสียหาย
> ได้เป็นเวลา 3 วินาทีหลังจากสำเร็จ
> แม้ว่าจะเคลื่อนไหวผลของฟาเรสจะไม่หายไป

**How it works**

- Attack skill of the ナイトスキル tree (tier 5, max Lv 285); usable with OneHandSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [!AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3)]: skill multiplier ×5.75 at Lv1 to 12.5 at Lv10
  - `calcPlayerToMobDamage` [AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND MobActionManagerBase.get_SystemInvincible(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND MobActionManagerBase.get_SystemInvincible(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0 & AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND MobActionManagerBase.get_SystemInvincible(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND MobActionManagerBase.get_SystemInvincible(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0 & !AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3)]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage`: flat damage +200
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Flinch (1).
- Buffs:
  - `BlinkSwordBuf`: lasts `3` s; Lv1 → Lv10: RateDamageResist (damage taken multiplier) 3 → 30
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `(((PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction)) * 10) mi 0 ? int((PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction)) * 10)) : int((PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction)) * 10))) & 255)`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(14)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 8 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 set, 3 tpl, 2 call, 1 info
- `ActionStart` — when the cast starts: 5 set
- `ActionSkillEvent` — on an animation/skill event during the motion: 2 call
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `OtherPlayerAttackStartReceive` — skill-specific method: 1 set
- `via PlayerAttackBase$$HitReactionAssign` — skill-specific method: 1 call, 2 tpl

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 5.75 | 6.5 | 7.25 | 8 | 8.75 | 9.5 | 10.25 | 11 | 11.75 | 12.5 |
| Flat dmg + | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv * 75) + 500)) + baseVIT) / 100)` — AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND MobActionManagerBase.get_SystemInvincible(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0
- SkillRate × `(((((Lv * 75) + 500)) + baseVIT) / 100)` — AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND MobActionManagerBase.get_SystemInvincible(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0 & AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND MobActionManagerBase.get_SystemInvincible(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0
- SkillRate × `((((Lv * 75) + 500)) / 100)` — AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND MobActionManagerBase.get_SystemInvincible(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0 & !AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3)

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv * 75) + 500)) + baseVIT) / 100)`
  - when `AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND MobActionManagerBase.get_SystemInvincible(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(200)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv * 75) + 500)) / 100)`
  - when `!AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3)`
- `via PlayerAttackBase$$HitReactionAssign` (method): `SetCalcValue[GuardPower]` = `System.Math.Max(0, (25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4))))`
  - when `!MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType ne 2 AND comboType ne 3`
- `via PlayerAttackBase$$HitReactionAssign` (method): `SetCalcValue[GuardPower]` = `25`
  - when `!MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType ne 2 AND comboType ne 3`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 526
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Rolls `percent`% to inflict **Flinch (1)** (`calcPlayerToMobDamage`)
  - when `!PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) OR !PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1)`
- Marks the hit with ailment **Flinch (1)** (`calcPlayerToMobDamage`)
  - when `AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND MobActionManagerBase.get_SystemInvincible(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND isEquipShield ne 0 OR AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND MobActionManagerBase.get_SystemInvincible(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND isEquipShield eq 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND AbnormalStateManager.CheckAbnormalType(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND isEquipShield ne 0`
- Extra percent roll `CheckPercent` (`via PlayerAttackBase$$HitReactionAssign`)
  - when `!MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) eq 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3`

**Buffs and effects it installs or removes**

- `ActionSkillEvent` (on an animation/skill event during the motion): constructs `BlinkSwordBuf` — `.ctor(Lv)`
  - when `(((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).x) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).x))) hi ((targetSize + weaponRange) * (targetSize + weaponRange)) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(mainTarget) AND isTeleport ne 0 AND param eq 100 OR (((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).x) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).x))) ls ((targetSize + weaponRange) * (targetSize + weaponRange)) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(mainTarget) AND isTeleport ne 0 AND param eq 100 OR !UnityEngine.Object.op_Inequality(mainTarget) AND (((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - movePos.z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - movePos.z)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - movePos) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - movePos))) hi ((targetSize + weaponRange) * (targetSize + weaponRange)) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND isTeleport ne 0 AND param eq 100`
- `ActionSkillEvent` (on an animation/skill event during the motion): adds the caster's buff of `new BlinkSwordBuf` — `AddSelfBuffer(new BlinkSwordBuf, Id)`
  - when `(((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).x) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).x))) hi ((targetSize + weaponRange) * (targetSize + weaponRange)) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(mainTarget) AND isTeleport ne 0 AND param eq 100 OR (((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).x) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(mainTarget)).x))) ls ((targetSize + weaponRange) * (targetSize + weaponRange)) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(mainTarget) AND isTeleport ne 0 AND param eq 100 OR !UnityEngine.Object.op_Inequality(mainTarget) AND (((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - movePos.z) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z - movePos.z)) + ((UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - movePos) * (UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x - movePos))) hi ((targetSize + weaponRange) * (targetSize + weaponRange)) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND isTeleport ne 0 AND param eq 100`

**Other recovered parameters**

- **Effect percent** (`percent`): `((int((Lv * 4.5)) + 5) + 50)` → Lv1..10 [59, 64, 68, 73, 77, 82, 86, 91, 95, 100] _(when (mainWeapon==Shield & 1) ne 0)_; `(int((Lv * 4.5)) + 5)` → Lv1..10 [9, 14, 18, 23, 27, 32, 36, 41, 45, 50] _(when (mainWeapon==Shield & 1) eq 0)_
- **Cast time modifier** (`CastTime`): `(((PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction)) * 10) mi 0 ? int((PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction)) * 10)) : int((PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction)) * 10))) & 255)`

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `RateDamageResist`: damage taken multiplier

**In-game level notes**

- Lv10: ถ้าทำให้ติดผงะได้สำเร็จ บลิงค์ซอร์ดจะเล็งตรงเป้าแน่นอน หากเกิดMISSการเปิดใช้งานจะล้มเหลว

**Where else this skill takes effect**

- Effect applied in `MobAttackBase$$CalcLastDamage` (300 guarded paths, truncated):
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
- Code that reads this skill's level / buff by constant id: `MobAttackBase$$CalcLastDamage (TryGetBuf)`

_Raw recovered data (every method item): [trees/KnightSkill.md](../trees/KnightSkill.md) — uid 526_

---

### ไนท์เพลดจ์ (KnightPledge) · uid 527

<img src="../../icons/sk_527.png" width="40" alt="icon"> 
**Tree:** ナイトスキル (`KnightSkill`, tier 5) · **Type:** Object · **Max Lv:** 285 · **Weapons:** OneHandSword · **Requires:** ไนท์ฮีล · **Client class:** `KnightPledgeAction`

> แทงดาบแห่งคำสาบานเพื่อสร้างพื้นที่ป้องกัน
> เพิ่มพลังโจมตีภายในพื้นที่และเพิ่มต้านทานความเสียหาย
> อย่างรุนแรง(ลดลงตามจำนวนครั้ง)ให้กับผู้อื่น
> จะหายไปเมื่อโดนโจมตีแบบผลักกระเด็น
> ผลลัพธ์จะกระจายมากขึ้นตามเป้าหมายที่ปกป้อง

**How it works**

- Object skill of the ナイトスキル tree (tier 5, max Lv 285); usable with OneHandSword.
- It installs a buff on the caster.
- It places an object in the world (trap, summon or field object).
- Buffs:
  - `KnightPledgeBuf`
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **Effect radius (Unity units)** (`Radius`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance(1.5)`
- **Effect radius (Unity units)** (`Radius`) (Unity units, 2 = 1 m): `(MathUtil.DisplayMeterToDistance(1.5) + 0.5)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `ActionStart` — when the cast starts: 8 set
- `ActionSkillEvent` — on an animation/skill event during the motion: 2 set
- `SustainedSupport` — skill-specific method: 1 set
- `PrevInitializeOthers` — skill-specific method: 4 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `InitializeOtherPlaceSkill` — skill-specific method: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 527
- No proration slot: ExpType None: no proration slot.

**Other recovered parameters**

- **Effect radius (Unity units)** (`Radius`): `MathUtil.DisplayMeterToDistance(1.5)`; `(MathUtil.DisplayMeterToDistance(1.5) + 0.5)`; `(MathUtil.DisplayMeterToDistance(1.5) + 0.5)`

**Buff values** (every recovered field; durations in seconds)

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

Parameter meanings (inferred from the `SkillBufferId` names):

- `Count`: stack / hit counter
- `KnockbackDistReduceRate`: knock-back distance reduction
- `LastDamageRateDecimal`: final damage multiplier (decimal)
- `MobLastDamageRateUnique`: final damage multiplier vs monsters (unique category)
- `Value`: generic value (meaning set by the code that reads the buff)
- `Value2`: second generic value

**In-game level notes**

- Lv10: หากลดความเสียหายจากการโจมตีแบบผลักกระเด็นในพื้นที่ จะสามารถลดระยะนั้นลงได้เป็นอย่างมาก แต่ดาบที่แทงลงไปจะถูกดีดออกทำให้ผลของสกิลสิ้นสุดลง  นอกจากนี้หากมีหลายเป้าหมายในพื้นที่ พลังโจมตีจะเพิ่มขึ้น ความเสียหายจะลดลง ผลลดลงเนื่องจากการกระจายของผลการลดผลักกระเด็น
- Lv17: *ความต้านทานผลักกระเด็นเพิ่มขึ้นอีก พลังโจมตีเพิ่มขึ้นอีกขึ้นอยู่กับค่าถลุงโล่

**Where else this skill takes effect**

- Effect applied in `MobAttackBase$$CalcLastDamage` (300 guarded paths, truncated):
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
- Code that reads this skill's level / buff by constant id: `MobAttackBase$$CalcLastDamage (TryGetBuf)`

_Raw recovered data (every method item): [trees/KnightSkill.md](../trees/KnightSkill.md) — uid 527_

---
