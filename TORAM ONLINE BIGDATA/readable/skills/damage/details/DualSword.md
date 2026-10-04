# デュアルスキル (`DualSword`) — skill details

21 entries.

### ดูเอลมาสเตอรี่ (DualMastery) · uid 641

<img src="../../icons/sk_641.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 1) · **Type:** Mastery · **Max Lv:** 30 · **Weapons:** TwinSword · **Flags:** StarGem · **Client class:** `DualMastery` (passive mastery)

> สามารถติดตั้งดาบมือเดียว 2 เล่มพร้อมกัน
> ลดการลดลงของอัตราความแม่นและ
> อัตราคริติคอลเมื่อเลเวลเพิ่มขึ้น

**How it works**

- Mastery skill of the デュアルスキル tree (tier 1, max Lv 30); usable with TwinSword.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): HitRate (accuracy %) -52 at Lv1 to -25 at Lv10, CrtRate (critical rate %) -52 at Lv1 to -25 at Lv10.
- Its effect is applied by client code: `EquipItemData.OneHundSwordCalculator$$calcAtkParam`, `SkillManager$$GetEquipEnableSkillList` (formulas in the last section).
- Other client code reads this skill (4 lookups; see the last section).

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| HitRate | -52 | -49 | -46 | -43 | -40 | -37 | -34 | -31 | -28 | -25 |
| CrtRate | -52 | -49 | -46 | -43 | -40 | -37 | -34 | -31 | -28 | -25 |


Bonus meanings (inferred from the names):

- `HitRate`: accuracy %
- `CrtRate`: critical rate %

**Where else this skill takes effect**

- Effect applied in `EquipItemData.OneHundSwordCalculator$$calcAtkParam` (4 guarded paths):
  - when `SkillLv(641) ge 1`
    - returns `(int((((CharacterActionManagerBase.get_Size() / 100) + ?v0) * (((((IPlayerStatusCalculator.get_EqAtk(PlayerStatusBase.get_SecondaryStatus()) + baseAtkUp) + ?blr) + IPlayerStatusCalculator.get_Str(PlayerStatusBase.get_SecondaryStatus())) + IPlayerStatusCalculator.get_Agi(PlayerStatusBase.get_SecondaryStatus())) + (IPlayerStatusCalculator.get_Dex(PlayerStatusBase.get_SecondaryStatus()) << 1)))) + atkRate)`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual CharacterActionManagerBase.get_Size`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`
  - when `SkillLv(641) lt 1`
    - returns `(int((((CharacterActionManagerBase.get_Size() / 100) + ?v0) * (((IPlayerStatusCalculator.get_EqAtk(PlayerStatusBase.get_SecondaryStatus()) + baseAtkUp) + ?blr) + ((IPlayerStatusCalculator.get_Dex(PlayerStatusBase.get_SecondaryStatus()) + IPlayerStatusCalculator.get_Str(PlayerStatusBase.get_SecondaryStatus())) << 1)))) + atkRate)`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual CharacterActionManagerBase.get_Size`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`
  - when `SkillLv(641) ge 1`
    - returns `(int((?v0 * (((((IPlayerStatusCalculator.get_EqAtk(PlayerStatusBase.get_SecondaryStatus()) + baseAtkUp) + ?blr) + IPlayerStatusCalculator.get_Str(PlayerStatusBase.get_SecondaryStatus())) + IPlayerStatusCalculator.get_Agi(PlayerStatusBase.get_SecondaryStatus())) + (IPlayerStatusCalculator.get_Dex(PlayerStatusBase.get_SecondaryStatus()) << 1)))) + atkRate)`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_EqAtk`
  - when `SkillLv(641) lt 1`
    - returns `(int((?v0 * (((IPlayerStatusCalculator.get_EqAtk(PlayerStatusBase.get_SecondaryStatus()) + baseAtkUp) + ?blr) + ((IPlayerStatusCalculator.get_Dex(PlayerStatusBase.get_SecondaryStatus()) + IPlayerStatusCalculator.get_Str(PlayerStatusBase.get_SecondaryStatus())) << 1)))) + atkRate)`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData$$get_SubWeapon`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_EqAtk`
- Effect applied in `SkillManager$$GetEquipEnableSkillList` (3 guarded paths):
  - always
    - returns `0x165db78(meta(0x397a538, System.Collections.Generic.List<SkillId>_TypeInfo), checkEquipSkill, ?x2, ?x3)`
    - calls `0x165db78`, `System.Collections.Generic.List<Int32Enum>$$.ctor`
  - always
    - returns `0x165db78(meta(0x397a538, System.Collections.Generic.List<SkillId>_TypeInfo), checkEquipSkill, ?x2, ?x3)`
    - calls `0x165db78`, `System.Collections.Generic.List<Int32Enum>$$.ctor`, `System.Collections.Generic.List<Int32Enum>$$AddWithResize`
  - always
    - returns `0x165db78(meta(0x397a538, System.Collections.Generic.List<SkillId>_TypeInfo), checkEquipSkill, ?x2, ?x3)`
    - calls `0x165db78`, `System.Collections.Generic.List<Int32Enum>$$.ctor`
- Code that reads this skill's level / buff by constant id: `EquipItemData.OneHundSwordCalculator$$CalcSubAtk (GetSkillLv)`, `EquipItemData.OneHundSwordCalculator$$SubCalcStable (GetSkillLv)`, `EquipItemData.OneHundSwordCalculator$$calcAtkParam (GetSkillLv)`, `SkillManager$$GetEquipEnableSkillList (GetSkillLv)`

_Raw recovered data (every method item): [trees/DualSword.md](../trees/DualSword.md) — uid 641_

---

### ทวินสแลช (TwinSlash) · uid 642

<img src="../../icons/sk_642.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 1) · **Type:** Attack · **Max Lv:** 30 · **Weapons:** TwinSword · **Requires:** ดูเอลมาสเตอรี่ · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `TwinSlashAction`

> ฟันด้วยดาบมือเดียว 2 เล่ม
> ความเสียหายจากคริติคอลจะสูงกว่าปกติ

**How it works**

- Attack skill of the デュアルスキル tree (tier 1, max Lv 30); usable with TwinSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×1.6 at Lv1 to 2.5 at Lv10; flat damage +110 at Lv1 to 200 at Lv10; extra crit multiplier +0.55 at Lv1 to 1 at Lv10
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 3 tpl, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 1.6 | 1.7 | 1.8 | 1.9 | 2 | 2.1 | 2.2 | 2.3 | 2.4 | 2.5 |
| Flat dmg + | 110 | 120 | 130 | 140 | 150 | 160 | 170 | 180 | 190 | 200 |
| Crit mult + | 0.55 | 0.6 | 0.65 | 0.7 | 0.75 | 0.8 | 0.85 | 0.9 | 0.95 | 1 |

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv * 10) + 150) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv * 10) + 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[CriticalRate]` = `(((((Lv + (Lv << 2)) + 50) + gemCart(109[2])) / 100))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 642
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Where else this skill takes effect**

- Code that reads this skill's level / buff by constant id: `AirSlicerAction$$OnInitialize (GetSkillLv)`

_Raw recovered data (every method item): [trees/DualSword.md](../trees/DualSword.md) — uid 642_

---

### ครอสแพรี่ (ParryingSword) · uid 643

<img src="../../icons/sk_643.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 1) · **Type:** Attack · **Max Lv:** 30 · **Weapons:** TwinSword · **Requires:** ดูเอลมาสเตอรี่ · **Flags:** StarGem · **Client class:** `ParryingSwordAction`

> หลบการโจมตีของศัตรูพร้อมตอบโต้กลับ
> ลดความเสียหายจากการโจมตีทางกายภาพและเวทมนตร์ระหว่างใช้สกิล
> เร่ง ATK กับ ASPD เมื่อลดความเสียหายสำเร็จเป็นเวลา 30 วินาที

**How it works**

- Attack skill of the デュアルスキル tree (tier 1, max Lv 30); usable with TwinSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×1.01 at Lv1 to 1.1 at Lv10; flat damage +55 at Lv1 to 100 at Lv10
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: None (0).
- Buffs:
  - `ParryingSwordBuf`: lasts `0` s; Lv1 → Lv10: AtkUpRate (ATK %) 1 → 10, AspdRate (attack speed %) 10 → 100
- Other client code reads this skill (2 lookups; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 2 tpl, 1 info
- `ActionStart` — when the cast starts: 1 call
- `Damaged` — when the caster takes damage while the action / buff is active: 1 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 1.01 | 1.02 | 1.03 | 1.04 | 1.05 | 1.06 | 1.07 | 1.08 | 1.09 | 1.1 |
| Flat dmg + | 55 | 60 | 65 | 70 | 75 | 80 | 85 | 90 | 95 | 100 |

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv + 100) + gemCart(110[4])) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv + (Lv << 2)) + 50))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 643
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Marks the hit with ailment **None (0)** (`Damaged`)
  - when `SkillDamageData.IsInactivityAbnormal(damageData) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 643) ne 0`

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): adds the caster's buff of skill 643 (ParryingSword) — `AddSelfBuffer(643, Lv, Id)`
  - when `(SkillParam & 16) eq 0`

**Buff values** (every recovered field; durations in seconds)

**Buff `ParryingSwordBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `EndDamageAbnormalCut`, `Parry`, `SetParrySuccess`, `calcDmgCut`, `get_DamageAbnormalCut`, `get_ParrySuccess`, `get_RealLeftTime`, `set_DamageAbnormalCut`, `set_ParrySuccess`, `set_RealLeftTime`
- Duration: `0` s
- `PowerDmgCut` = `ParryingSwordBuf.calcDmgCut(this, Lv)` _(when BuffEffectActive ne 0; ParrySuccess ne 0; DamageAbnormalCut ne 0)_
- `MagicDmgCut` = `ParryingSwordBuf.calcDmgCut(this, Lv)` _(when BuffEffectActive ne 0; ParrySuccess ne 0; DamageAbnormalCut ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| AtkUpRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| AspdRate | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |

- Buff fields set in the constructor (all recovered):
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `RealLeftTime` = `0`
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
  - `ParrySuccess` = `256` = 256
- Hook `set_RealLeftTime`: `RealLeftTime`=value
- Hook `set_ParrySuccess`: `ParrySuccess`=(value & 1)
- Hook `set_DamageAbnormalCut`: `DamageAbnormalCut`=(value & 1)
- Hook `Updata`: `RealLeftTime`=0; `RealLeftTime`=(RealLeftTime - UnityEngine.Time.get_deltaTime())
- Hook `SetParrySuccess`: `RealLeftTime`=30; `ParrySuccess`=1
- Hook `EndDamageAbnormalCut`: `DamageAbnormalCut`=0

Parameter meanings (inferred from the `SkillBufferId` names):

- `AspdRate`: attack speed %
- `AtkUpRate`: ATK %
- `MagicDmgCut`: magic damage taken reduction
- `PowerDmgCut`: physical damage taken reduction

**Where else this skill takes effect**

- Effect applied in `ParryingSwordAction$$Damaged` (5 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 643, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillDamageData.SetAbnormalType(damageData, 0, 0, ?x3)`
    - calls `SkillDamageData$$IsInactivityAbnormal`, `SkillDamageData$$SetAbnormalType`
  - when `(SkillBufferManager.TryGetBuf(?blr, 643, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillDamageData.IsInactivityAbnormal(damageData, 0, ?x2, ?x3)`
    - calls `SkillDamageData$$IsInactivityAbnormal`
  - when `(SkillBufferManager.TryGetBuf(?blr, 643, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 643, stkp(-40), 0)`
  - when `(SkillBufferManager.TryGetBuf(?blr, 643, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(?blr, 643, stkp(-40), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 643, stkp(-40), 0)`
- Effect applied in `ParryingSwordBuf$$Parry` (5 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 643, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `TryGetBuf.out2()`
  - when `(SkillBufferManager.TryGetBuf(?blr, 643, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `TryGetBuf.out2()`
  - when `(SkillBufferManager.TryGetBuf(?blr, 643, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `TryGetBuf.out2()`
  - when `(SkillBufferManager.TryGetBuf(?blr, 643, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `0x165db84`, `0x165df00`
  - when `(SkillBufferManager.TryGetBuf(?blr, 643, stkp(-24), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 643, stkp(-24), 0)`
- Code that reads this skill's level / buff by constant id: `ParryingSwordAction$$Damaged (TryGetBuf)`, `ParryingSwordBuf$$Parry (TryGetBuf)`

_Raw recovered data (every method item): [trees/DualSword.md](../trees/DualSword.md) — uid 643_

---

### รีเฟล็กซ์ (StepReactor) · uid 644

<img src="../../icons/sk_644.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 1) · **Type:** Buffer · **Max Lv:** 30 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ดูเอลมาสเตอรี่ · **Flags:** StarGem · **Client class:** `StepReactorAction`

> เพิ่มการฟื้นฟู Avoid ในเวลาสั้นๆ
> DEF/MDEF จะลดลงจำนวนมาก

**How it works**

- Buffer skill of the デュアルスキル tree (tier 1, max Lv 30); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It installs a buff on other players / the party.
- Buffs:
  - `StepReactorbuf`: lasts `time` s; Lv1 → Lv10: AvoidUp (dodge +) 12 → 30, MdefRate (MDEF %) -99 → -90, DefRate (DEF %) -99 → -90

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 1 call
- `OnInheritance` — state carried over when this action follows another: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 644
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): adds a target's buff of skill 644 (StepReactor) — `AddBuffer(644, Lv, (equipDualSword eq 0 ? 10 : 100))`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`

**Buff values** (every recovered field; durations in seconds)

**Buff `StepReactorbuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `time` s

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| AvoidUp | 12 | 14 | 16 | 18 | 20 | 22 | 24 | 26 | 28 | 30 |
| MdefRate | -99 | -98 | -97 | -96 | -95 | -94 | -93 | -92 | -91 | -90 |
| DefRate | -99 | -98 | -97 | -96 | -95 | -94 | -93 | -92 | -91 | -90 |

- Buff fields set in the constructor (all recovered):
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
  - `BufEffectTakeUid` = `-1` = -1
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

Parameter meanings (inferred from the `SkillBufferId` names):

- `AvoidUp`: dodge +
- `DefRate`: DEF %
- `MdefRate`: MDEF %

**In-game level notes**

- Lv10: *ระยะเวลาแสดงผล+90 วิ

_Raw recovered data (every method item): [trees/DualSword.md](../trees/DualSword.md) — uid 644_

---

### ควบคุมดาบคู่ (DualSwordTechnique) · uid 645

<img src="../../icons/sk_645.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 1) · **Type:** Mastery · **Max Lv:** 30 · **Weapons:** TwinSword · **Requires:** ดูเอลมาสเตอรี่ · **Flags:** StarGem · **Client class:** `DualSwordTechnique` (passive mastery)

> เพิ่ม ASPD ของดาบคู่
> และลดข้อเสียของดาบคู่ลงด้วย

**How it works**

- Mastery skill of the デュアルスキル tree (tier 1, max Lv 30); usable with TwinSword.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): HitRate (accuracy %) 8 at Lv1 to 35 at Lv10, CrtRate (critical rate %) 8 at Lv1 to 35 at Lv10, Aspd (attack speed) 50 at Lv1 to 500 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| HitRate | 8 | 11 | 14 | 17 | 20 | 23 | 26 | 29 | 32 | 35 |
| CrtRate | 8 | 11 | 14 | 17 | 20 | 23 | 26 | 29 | 32 | 35 |
| Aspd | 50 | 100 | 150 | 200 | 250 | 300 | 350 | 400 | 450 | 500 |


Bonus meanings (inferred from the names):

- `HitRate`: accuracy %
- `CrtRate`: critical rate %
- `Aspd`: attack speed

_Raw recovered data (every method item): [trees/DualSword.md](../trees/DualSword.md) — uid 645_

---

### สปินนิ่งสแลช (AirSlide) · uid 646

<img src="../../icons/sk_646.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 2) · **Type:** Object · **Max Lv:** 50 · **Weapons:** TwinSword · **Requires:** ทวินสแลช · **Flags:** MercenaryCanUseSkill · **Client class:** `AirSlideAction`

> ฟันศัตรูที่อยู่รอบตัวให้กระเด็นออกไป\ธาตุคู่(ดาบมือเดียว)
> หลังการโจมตีคาไมทาจิจะสร้างความเสียหายต่อเนื่อง
> มีโอกาสทำให้เป้าหมาย[มืดบอด] 

**How it works**

- Object skill of the デュアルスキル tree (tier 2, max Lv 50); usable with TwinSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- It places an object in the world (trap, summon or field object).
- Damage (`calcFirstDamage` x1, `calcAnyDamage` x1; each template is a full damage roll with its own crit):
  - `calcFirstDamage`: skill multiplier ×1.27 at Lv1 to 1.5 at Lv10; flat damage +55 at Lv1 to 100 at Lv10
  - `calcAnyDamage`: skill multiplier ×0.32 at Lv1 to 0.5 at Lv10
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: KnockBack (4), Blindness (7).
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 11 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `OtherPlayerAttackStartReceive` — skill-specific method: 1 set
- `calcFirstDamage` — damage calculation of hit 1: 4 tpl, 2 call, 1 info
- `calcAnyDamage` — damage calculation shared by every hit: 3 tpl, 3 call, 1 info
- `ActionStart` — when the cast starts: 3 set
- `NextRangeHit` — next range-hit pass: 1 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [calcFirstDamage] | 1.27 | 1.3 | 1.32 | 1.35 | 1.37 | 1.4 | 1.42 | 1.45 | 1.47 | 1.5 |
| SkillRate × [calcAnyDamage] | 0.32 | 0.34 | 0.36 | 0.38 | 0.4 | 0.42 | 0.44 | 0.46 | 0.48 | 0.5 |
| Flat dmg + | 55 | 60 | 65 | 70 | 75 | 80 | 85 | 90 | 95 | 100 |

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcFirstDamage` (damage calculation of hit 1): `SetRate[ExpRate]` = `(target.ExpDefSkill / 100)`
- `calcFirstDamage` (damage calculation of hit 1): `AddRate[SkillRate]` = `((((int((Lv * 2.5)) + 125) + gemCart(210[4])) / 100))`
- `calcFirstDamage` (damage calculation of hit 1): `AddConstant[SkillConstantDamage]` = `(((Lv + (Lv << 2)) + 50))`
- `calcFirstDamage` (damage calculation of hit 1): `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`
- `calcAnyDamage` (damage calculation shared by every hit): `SetRate[ExpRate]` = `(target.ExpDefSkill / 100)`
- `calcAnyDamage` (damage calculation shared by every hit): `AddRate[SkillRate]` = `(((((Lv + Lv) + 30) + gemCart(210[4])) / 100))`
- `calcAnyDamage` (damage calculation shared by every hit): `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 646
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Hit counts**

- Number of damage events (`damageCount`): `4` = 4
- Loop / hit-repeat count (`LoopParam`): `4` = 4

**Status ailments**

- Chance field `blindPercent` (Blind chance (%)): `(int((Lv * 2.5)) + 15)` → Lv1..10 [17, 20, 22, 25, 27, 30, 32, 35, 37, 40]
- Rolls `100`% to inflict **KnockBack (4)** (`calcFirstDamage`)
  - when `MobActionManagerBase.get_IsPlayerManaged(mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 4, 100, playerAction) AND isEquipCompressionGemCart eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 4, 100, playerAction) AND MobActionManagerBase.get_IsPlayerManaged(mobAction) AND isEquipCompressionGemCart eq 0`
- Rolls `blindPercent`% to inflict **Blindness (7)** (`calcAnyDamage`)
- Marks the hit with ailment **Blindness (7)** (`calcAnyDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 7, blindPercent, playerAction)`

**Buffs and effects it installs or removes**

- `calcFirstDamage` (damage calculation of hit 1): adds the buff-provided flat damage to the template — `SetBufferConstantDamage(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), damageCount)`
- `calcAnyDamage` (damage calculation shared by every hit): adds the buff-provided flat damage to the template — `SetBufferConstantDamage(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), damageCount)`

**Other recovered parameters**

- **First-hit multiplier** (`skillRateFirst`): `(((int((Lv * 2.5)) + 125) + gemCart(210[4])) / 100)`
- **Number of damage events** (`damageCount`): `4` = 4; `4` = 4
- **Loop / hit-repeat count** (`LoopParam`): `4` = 4
- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`

**Where else this skill takes effect**

- Code that reads this skill's level / buff by constant id: `AirSlicerAction$$OnInitialize (GetSkillLv)`

_Raw recovered data (every method item): [trees/DualSword.md](../trees/DualSword.md) — uid 646_

---

### ชาร์จจิ้งสแลช (DragoonSword) · uid 647

<img src="../../icons/sk_647.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 2) · **Type:** Attack · **Max Lv:** 50 · **Weapons:** TwinSword · **Requires:** ครอสแพรี่ · **Flags:** MercenaryCanUseSkill · **Client class:** `DragoonSwordAction`

> โจมตีศัตรูด้วยดาบ 2 เล่ม
> โจมตีเป้าหมายที่ผ่านเป็นทางตรง
> จะได้รับผลโบนัสจากฟันครั้งแรก

**How it works**

- Attack skill of the デュアルスキル tree (tier 2, max Lv 50); usable with TwinSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×2.2 at Lv1 to 4 at Lv10; flat damage +120 at Lv1 to 300 at Lv10
- Proration: physical-skill proration slot, mode `first_hit_per_target`.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 8 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionStart` — when the cast starts: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 6 tpl, 1 call, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 2.2 | 2.4 | 2.6 | 2.8 | 3 | 3.2 | 3.4 | 3.6 | 3.8 | 4 |
| Flat dmg + | 120 | 140 | 160 | 180 | 200 | 220 | 240 | 260 | 280 | 300 |

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(target.ExpDefSkill / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((((Lv + (Lv << 2)) << 2) + 200) + gemCart(211[4])) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv * 20) + 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, playerAction)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[FirstAttackRate]` = `(PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 647
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `calcPlayerToMobDamage` (damage calculation against a monster): adds the buff-provided flat damage to the template — `SetBufferConstantDamage(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 2)`

_Raw recovered data (every method item): [trees/DualSword.md](../trees/DualSword.md) — uid 647_

---

### เร็วดุจเทพ (GodspeedLocus) · uid 648

<img src="../../icons/sk_648.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 2) · **Type:** Mastery · **Max Lv:** 50 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ควบคุมดาบคู่ · **Client class:** `GodspeedLocus` (passive mastery)

> เพิ่ม AGI และพลังโจมตีของฟันครั้งแรก
> (โจมตีครั้งแรก/Avoidแอคแทค/หลังใช้สกิลที่กำหนด)

**How it works**

- Mastery skill of the デュアルスキル tree (tier 2, max Lv 50); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): FirstAttackRate (first-attack multiplier) 6 at Lv1 to 15 at Lv10, Agi (AGI) 0.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| FirstAttackRate | 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13 | 14 | 15 |
| Agi | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 |


Bonus meanings (inferred from the names):

- `FirstAttackRate`: first-attack multiplier
- `Agi`: AGI

**In-game level notes**

- Lv10: *พลังโจมตีด้วยอาวุธ+10%

_Raw recovered data (every method item): [trees/DualSword.md](../trees/DualSword.md) — uid 648_

---

### แฟนทอมสแลช / แฟนทอมอิคลิพส์ (PhantomRave) · uid 649

<img src="../../icons/sk_649.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 3) · **Type:** Attack · **Max Lv:** 90 · **Weapons:** TwinSword · **Requires:** สปินนิ่งสแลช · **Flags:** MercenaryCanUseSkill · **Client class:** `PhantomRaveAction`

> ฟันอย่างรวดเร็วจนตาเปล่ามองไม่เห็นนับครั้งไม่ถ้วน
> ธาตุคู่(ดาบมือเดียว)
> ติดสถานะไร้พ่ายระหว่างใช้สกิลแต่มีโอกาสยกเลิกสถานะจากการเคลื่อนไหวคาแรคเตอร์
> มีโอกาสทำให้มอนสเตอร์ที่อ่อนแอนอกเหนือจากบอสตายทันที
> มีโอกาสทำให้เป้าหมายถูก[แช่แข็ง]

**How it works**

- Attack skill of the デュアルスキル tree (tier 3, max Lv 90); usable with TwinSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×10.4 at Lv1 to 14 at Lv10; skill multiplier depends on live values (formula below); flat damage +220 at Lv1 to 400 at Lv10
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Freeze (9).
- Buffs:
  - `DoubleThrowBuf`: lasts `(30 - lv)` s

**Cost, timing and range**

- **MP cost** (`cost` in `OnInitialize`): `400` = 400
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(8)`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(24)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 7 set, 1 call
- `ActionStart` — when the cast starts: 1 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `OtherPlayerAttackStartReceive` — skill-specific method: 1 set
- `AttackStartReceive` — skill-specific method: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 7 tpl, 1 call, 1 info
- `CreateMultiDamage` — skill-specific method: 1 call
- `CalcPhantomRaveLastDamageRate` — skill-specific method: 1 set
- `LunaDitherStartInterruptableInitialize` — skill-specific method: 4 set
- `GetLocalizeKey` — skill-specific method: 1 set
- `via PlayerAttackBase$$CalcDoubleThrowLastDamageRate` — skill-specific method: 1 set, 3 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 10.4 | 10.8 | 11.2 | 11.6 | 12 | 12.4 | 12.8 | 13.2 | 13.6 | 14 |
| Flat dmg + | 220 | 240 | 260 | 280 | 300 | 320 | 340 | 360 | 380 | 400 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((((((Lv * 20) + 500) + gemCart(305[4])) / 100)) * ((1) eq 0 ? 1 : 2))`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((((Lv * 20) + 500) + gemCart(305[4])) / 100)) * ((1) eq 0 ? 1 : 2))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv * 20) + 200))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[LastDamageRate]` = `(CalcPhantomRaveLastDamageRate.out2(this, PlayerActionManagerBase.get_PlayerStatus(), PlayerActionManagerBase.get_PlayerStatus()) - MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90)))`
  - when `TryGetProperties<object>.out2(mobAction, 90) ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[SkillRate]` = `(((((Lv * 20) + 500) + gemCart(305[4])) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[LastDamageRate]` = `(CalcPhantomRaveLastDamageRate.out3(this, PlayerActionManagerBase.get_PlayerStatus(), PlayerActionManagerBase.get_PlayerStatus()) - MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90)))`
  - when `TryGetProperties<object>.out2(mobAction, 90) ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[LastDamageRate]` = `CalcPhantomRaveLastDamageRate.out2(this, PlayerActionManagerBase.get_PlayerStatus(), PlayerActionManagerBase.get_PlayerStatus())`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[LastDamageRate]` = `CalcPhantomRaveLastDamageRate.out3(this, PlayerActionManagerBase.get_PlayerStatus(), PlayerActionManagerBase.get_PlayerStatus())`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 649
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Rolls `freezeRate`% to inflict **Freeze (9)** (`calcPlayerToMobDamage`)

**Buffs and effects it installs or removes**

- `CreateMultiDamage` (method): splits the damage into several hits — `createMultiHitDamage(damageData, damageData.TotalDamage)`
- `via PlayerAttackBase$$CalcDoubleThrowLastDamageRate` (method): removes the caster's buff of skill 293 (DoubleThrow) — `RemoveSelfBuffer(293)`
  - when `PlayerAttackBase.get_ActionID() ne 300 AND PlayerAttackBase.get_ActionID() ne 302 AND PlayerAttackBase.get_TreeType() eq 9 AND PlayerStatusBase.get_SkillBufferManager().skillBufList[293].CoolTime eq 0 AND costMp ne 0`
- `via PlayerAttackBase$$CalcDoubleThrowLastDamageRate` (method): constructs `DoubleThrowBuf` — `.ctor(PlayerStatusBase.get_SkillBufferManager().skillBufList[293].Level, 1)`
  - when `PlayerAttackBase.get_ActionID() ne 300 AND PlayerAttackBase.get_ActionID() ne 302 AND PlayerAttackBase.get_TreeType() eq 9 AND PlayerStatusBase.get_SkillBufferManager().skillBufList[293].CoolTime eq 0 AND costMp ne 0`
- `via PlayerAttackBase$$CalcDoubleThrowLastDamageRate` (method): adds the caster's buff of `new DoubleThrowBuf` — `AddSelfBuffer(new DoubleThrowBuf, Id)`
  - when `PlayerAttackBase.get_ActionID() ne 300 AND PlayerAttackBase.get_ActionID() ne 302 AND PlayerAttackBase.get_TreeType() eq 9 AND PlayerStatusBase.get_SkillBufferManager().skillBufList[293].CoolTime eq 0 AND costMp ne 0`

**Other recovered parameters**

- **Cost** (`cost`): `400` = 400

**Buff values** (every recovered field; durations in seconds)

**Buff `DoubleThrowBuf`**
- Buff hook methods: `ReductionCoolTime`, `get_CoolTime`, `set_CoolTime`
- Duration: `(30 - lv)` s [(coolTime & 1) ne 0]
- Buff fields set in the constructor (all recovered):
  - `CoolTime` = `(coolTime & 1)`
- Hook `set_CoolTime`: `CoolTime`=(value & 1)
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `ReductionCoolTime`: `LeftTime`=(LeftTime - time); `LeftTime`=0

_Raw recovered data (every method item): [trees/DualSword.md](../trees/DualSword.md) — uid 649_

---

### แฟลชบลาส (PhiloEclair) · uid 650

<img src="../../icons/sk_650.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 3) · **Type:** Buffer · **Max Lv:** 90 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** รีเฟล็กซ์ · **Client class:** `PhiloEclairAction`

> ธาตุคู่(ดาบมือเดียว)
> เพิ่มพลังโจมตีฟันครั้งแรกชั่วขณะ
> เพิ่มเคาน์เตอร์แอทแทคเมื่อ Avoid
> จะทำงานเมื่อใช้สกิล[ชาโดว์สเต็ป]ด้วย

**How it works**

- Buffer skill of the デュアルスキル tree (tier 3, max Lv 90); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It installs a buff on other players / the party.
- Buffs:
  - `PhiloEclairBuf`: lasts `120` s / `20` s; Lv1 → Lv10: EqAtkUpRate (weapon ATK %) 25 → 25, FirstAttackRate (first-attack multiplier) 1 → 10, AvoidStack (dodge stacks) 0 → 2000
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 1 call
- `OnInheritance` — state carried over when this action follows another: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 650
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): adds a target's buff of skill 650 (PhiloEclair) — `AddBuffer(650, Lv, 0)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`

**Buff values** (every recovered field; durations in seconds)

**Buff `PhiloEclairBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `120` s [isDualSword ne 0]; `20` s [isDualSword eq 0]

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| EqAtkUpRate | 25 | 25 | 25 | 25 | 25 | 25 | 25 | 25 | 25 | 25 |
| FirstAttackRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| AvoidStack | 0 | 0 | 0 | 0 | 1000 | 1000 | 1000 | 1000 | 1000 | 2000 |

- Buff fields set in the constructor (all recovered):
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `isDualSword` = `(isDualSword ne 0 ? 1 : 0)`
  - `firstAttackRate` = `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `eqAtkRate` = `25` = 25 when isDualSword ne 0
  - `avoidStack` = `(int((Lv * 0.2)) * 1000)` → Lv1..10 [0, 0, 0, 0, 1000, 1000, 1000, 1000, 1000, 2000] when isDualSword ne 0
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

Parameter meanings (inferred from the `SkillBufferId` names):

- `AvoidStack`: dodge stacks
- `EqAtkUpRate`: weapon ATK %
- `FirstAttackRate`: first-attack multiplier

**In-game level notes**

- Lv10: *เพิ่มปริมาณการเพิ่มบัฟ ATK อาวุธ *เวลาแสดงผล+100s
- Lv10: *พลัง+50 *ระยะโจมตี (รัศมี)+1m

**Where else this skill takes effect**

- Effect applied in `AvoidActionManager$$CheckActivatePhiloEclair` (2 guarded paths):
  - always
    - returns `(FieldRayPick.GetFallDelta([charaMove+0x30], stkp(-160), 0, ?x3) & 1)`
    - calls `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_rotation`, `UnityEngine.Quaternion$$Internal_ToEulerRad`, `UnityEngine.Quaternion$$Internal_MakePositive`, `CharacterMove$$set_IgnoreHeight`
  - always
    - returns `0`
- Code that reads this skill's level / buff by constant id: `AvoidActionManager$$CheckActivatePhiloEclair (ContainsBuffer)`

_Raw recovered data (every method item): [trees/DualSword.md](../trees/DualSword.md) — uid 650_

---

### ชาโดว์สเต็ป (WrapAround) · uid 651

<img src="../../icons/sk_651.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 3) · **Type:** Attack · **Max Lv:** 90 · **Weapons:** TwinSword · **Requires:** ชาร์จจิ้งสแลช · **Flags:** MercenaryCanUseSkill · **Client class:** `WrapAroundAction`

> เคลื่อนย้ายไปอยู่ข้างหลังศัตรูอย่างรวดเร็ว
> เพิ่มการฟื้นฟู MP จนกว่าจะใช้สกิลถัดไป
> เพิ่มอัตราคริติคอลของการโจมตีด้วยสกิล 1 ครั้ง

**How it works**

- Attack skill of the デュアルスキル tree (tier 3, max Lv 90); usable with TwinSword.
- It installs a buff on the caster.
- MP: 400 at Lv1 to 200 at Lv10.
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **MP cost** (`mp` in `OnInitialize`): `((4 - int(((Lv * 0.25) + 0.25))) * 100)` → Lv1..10 [400, 400, 300, 300, 300, 300, 200, 200, 200, 200]
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance((Lv eq 10 ? 12 : (int((Lv * 0.5)) + 4)))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `ActionStart` — when the cast starts: 1 set, 1 call
- `InitializeOthers` — setup used when another player's client replays the action: 2 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 651
- No proration slot: ExpType None: no proration slot.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `int((CharacterActionManagerBase.get_Size() * 1.5))`
  - when `UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<CharacterActionManagerBase>(target), 0)`

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): adds the caster's buff of skill 651 (WrapAround) — `AddSelfBuffer(651, Lv, Id)`

**Other recovered parameters**

- **MP cost** (`mp`): `((4 - int(((Lv * 0.25) + 0.25))) * 100)` → Lv1..10 [400, 400, 300, 300, 300, 300, 200, 200, 200, 200]
- **Loop / hit-repeat count** (`LoopParam`): `int((CharacterActionManagerBase.get_Size() * 1.5))` _(when UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<CharacterActionManagerBase>(target), 0))_

**Where else this skill takes effect**

- Effect applied in `LunaDitherStarAction$$ActionSkillEvent` (6 guarded paths):
  - when `param ne 101` AND `param eq 100` AND `MobaMode ne 0` AND `(SkillLv(651) & 255) ne 0`
    - set `bladeRain` = `1`
    - calls `SkillActionBase$$ActionSkillEvent`, `PlayerBattleManager$$StartLunaDitherStarBladeRain`, `0x165db78`, `WrapAroundBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
  - when `param ne 101` AND `param eq 100` AND `MobaMode ne 0` AND `(SkillLv(651) & 255) eq 0`
    - returns `SkillLv(651)`
    - set `bladeRain` = `1`
    - calls `SkillActionBase$$ActionSkillEvent`, `PlayerBattleManager$$StartLunaDitherStarBladeRain`
  - when `param ne 101` AND `param eq 100` AND `MobaMode eq 0` AND `(SkillLv(651) & 255) ne 0`
    - set `bladeRain` = `1`
    - calls `SkillActionBase$$ActionSkillEvent`, `PlayerBattleManager$$StartLunaDitherStarBladeRain`, `0x165db78`, `WrapAroundBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
  - when `param ne 101` AND `param eq 100` AND `MobaMode eq 0` AND `(SkillLv(651) & 255) eq 0`
    - returns `SkillLv(651)`
    - set `bladeRain` = `1`
    - calls `SkillActionBase$$ActionSkillEvent`, `PlayerBattleManager$$StartLunaDitherStarBladeRain`
  - when `param ne 101` AND `param eq 100` AND `(SkillLv(651) & 255) ne 0`
    - set `bladeRain` = `1`
    - calls `SkillActionBase$$ActionSkillEvent`, `PlayerBattleManager$$StartLunaDitherStarBladeRain`, `0x165db78`, `WrapAroundBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
  - when `param ne 101` AND `param eq 100` AND `(SkillLv(651) & 255) eq 0`
    - returns `SkillLv(651)`
    - set `bladeRain` = `1`
    - calls `SkillActionBase$$ActionSkillEvent`, `PlayerBattleManager$$StartLunaDitherStarBladeRain`
- Code that reads this skill's level / buff by constant id: `LunaDitherStarAction$$ActionSkillEvent (GetSkillLv)`

_Raw recovered data (every method item): [trees/DualSword.md](../trees/DualSword.md) — uid 651_

---

### ไชน์นิ่งครอส / เบลซซิ่งไชน์นิ่งครอส (ShiningCloth) · uid 652

<img src="../../icons/sk_652.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 4) · **Type:** Attack · **Max Lv:** 170 · **Weapons:** TwinSword · **Requires:** ชาโดว์สเต็ป · **Flags:** MercenaryCanUseSkill · **Client class:** `ShiningClothAction`

> ดาบคู่แห่งแสงตัดผ่านความมืดมิด
> ธาตุคู่(ดาบมือเดียว)
> ยิ่งเข้าไปใกล้ศัตรูจะยิ่งสร้างความเสียหายได้เพิ่มขึ้น
> ฟื้นฟู MP ถ้าติดคริติคอล เมื่อติดบัฟจะฟื้นฟู HP เล็กน้อย
> บัฟนี้จะไม่มีการทับซ้อนกัน

**How it works**

- Attack skill of the デュアルスキル tree (tier 4, max Lv 170); usable with TwinSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Damage (`calcPlayerToMobDamage` x2; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [hasBuff(655)]: skill multiplier depends on Agi, Str, Dex (formula below)
  - `calcPlayerToMobDamage` [!hasBuff(655)]: skill multiplier depends on Agi, Str, Dex (formula below)
  - `calcPlayerToMobDamage`: skill multiplier depends on Agi, Str, Dex (formula below); flat damage +120 at Lv1 to 300 at Lv10
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Buffs:
  - `ShiningClothBuf`: lasts `9` s

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 9 set
- `InitializeOthers` — setup used when another player's client replays the action: 3 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 3 set, 2 tpl, 1 info
- `GetLocalizeKey` — skill-specific method: 1 set
- `.<>c__DisplayClass27_0::<ActionStart>b__1` — skill-specific method: 1 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 120 | 140 | 160 | 180 | 200 | 220 | 240 | 260 | 280 | 300 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(max((((((Lv * 10) + 300) + (((status.Agi // 4) + (status.Str // 4)) + (status.Dex // 4)))) - System.Math.Max(0, System.Math.Min(400, ((MobActionManagerBase.get_PlayerMeterDistance(mobAction) * 50) - 200)))), 100) / 100)` — hasBuff(655)
- SkillRate × `(max((((((Lv * 10) + 300) + (((status.Agi // 4) + (status.Str // 4)) + (status.Dex // 4)))) - System.Math.Max(0, System.Math.Min(400, ((MobActionManagerBase.get_PlayerMeterDistance(mobAction) * 50) - 200)))), 100) / 100)` — !hasBuff(655)
- SkillRate × `(max((((((Lv * 10) + 300) + (((status.Agi // 4) + (status.Str // 4)) + (status.Dex // 4)))) - System.Math.Max(0, System.Math.Min(400, ((MobActionManagerBase.get_PlayerMeterDistance(mobAction) * 50) - 200)))), 100) / 100)`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(max((((((Lv * 10) + 300) + (((status.Agi // 4) + (status.Str // 4)) + (status.Dex // 4)))) - System.Math.Max(0, System.Math.Min(400, ((MobActionManagerBase.get_PlayerMeterDistance(mobAction) * 50) - 200)))), 100) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv * 20) + 100))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 652
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `SubElement`

**Buffs and effects it installs or removes**

- `.<>c__DisplayClass27_0::<ActionStart>b__1` (method): adds the caster's buff of `CharacterActionManagerBase.get_IsLocalDead()` — `AddSelfBuffer(CharacterActionManagerBase.get_IsLocalDead(), [<>c__DisplayClass27_0.<>4__this+0x14], 0)`
  - when `(cancel & 1) eq 0`

**Other recovered parameters**

- **Loop / hit-repeat count** (`LoopParam`): `SubElement`

**Buff values** (every recovered field; durations in seconds)

**Buff `ShiningClothBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `9` s
- Buff fields set in the constructor (all recovered):
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

_Raw recovered data (every method item): [trees/DualSword.md](../trees/DualSword.md) — uid 652_

---

### สตอร์มรีปเปอร์ / ออร์บิทรีปเปอร์ (SturmLeaper) · uid 653

<img src="../../icons/sk_653.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 4) · **Type:** Attack · **Max Lv:** 170 · **Weapons:** TwinSword · **Requires:** แฟลชบลาส · **Flags:** MercenaryCanUseSkill · **Client class:** `SturmLeaperAction`

> โจมตีศัตรูและกระโดดถอยกลับอย่างรวดเร็ว
> พลังโจมตีระยะใกล้ของสกิลที่ใช้ถัดไป
> จะเพิ่มขึ้นตามระยะถอยห่าง
> ติดคงกระพันขณะถอยห่าง

**How it works**

- Attack skill of the デュアルスキル tree (tier 4, max Lv 170); usable with TwinSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Damage (`calcPlayerToMobDamage` x2; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on live values (formula below); flat damage +110 at Lv1 to 200 at Lv10
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Buffs:
  - `SturmLeaperBuf`
  - `CountBufferBase`

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(24)`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `ActionStart` — when the cast starts: 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 3 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 set, 4 tpl, 1 info
- `LunaDitherStartInterruptableInitialize` — skill-specific method: 3 set
- `GetLocalizeKey` — skill-specific method: 1 set
- `.<>c__DisplayClass31_0::<ActionStart>b__1` — skill-specific method: 5 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 110 | 120 | 130 | 140 | 150 | 160 | 170 | 180 | 190 | 200 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((((((Lv + (Lv << 2)) << 1) + 400) + ((baseDEX // 25) * Lv))) / 100)`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((((Lv + (Lv << 2)) << 1) + 400) + ((baseDEX // 25) * Lv))) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `((((Lv + (Lv << 2)) << 1) + 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[FirstAttackRate]` = `(PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, playerAction)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 653
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `.<>c__DisplayClass31_0::<ActionStart>b__1` (method): constructs `SturmLeaperBuf` — `.ctor([<>c__DisplayClass31_0.<>4__this+0x14], ((int(frintp((((((int(frintp((((fsqrt(((([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z) * ([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z)) + (([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x) * ([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x)))) * 100)) + -0.5))) / 100) / MathUtil.DisplayMeterToDistance(9)) * 100)) + -0.5))) / 100) pl 0.1 ? min((int(frintp((((((int(frintp((((fsqrt(((([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z) * ([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z)) + (([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x) * ([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x)))) * 100)) + -0.5))) / 100) / MathUtil.DisplayMeterToDistance(9)) * 100)) + -0.5))) / 100), 1) : 0.1), [<>c__DisplayClass31_0.<>4__this+0x135])`
- `.<>c__DisplayClass31_0::<ActionStart>b__1` (method): adds the caster's buff of `new SturmLeaperBuf` — `AddSelfBuffer(new SturmLeaperBuf, [<>c__DisplayClass31_0.<>4__this+0x10])`
- `.<>c__DisplayClass31_0::<ActionStart>b__1` (method): constructs `SturmLeaperBuf` — `.ctor([<>c__DisplayClass31_0.<>4__this+0x14], ((int(floor((((((int(frintp((((fsqrt(((([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z) * ([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z)) + (([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x) * ([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x)))) * 100)) + -0.5))) / 100) / MathUtil.DisplayMeterToDistance(9)) * 100)) + 0.5))) / 100) pl 0.1 ? min((int(floor((((((int(frintp((((fsqrt(((([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z) * ([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z)) + (([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x) * ([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x)))) * 100)) + -0.5))) / 100) / MathUtil.DisplayMeterToDistance(9)) * 100)) + 0.5))) / 100), 1) : 0.1), [<>c__DisplayClass31_0.<>4__this+0x135])`
- `.<>c__DisplayClass31_0::<ActionStart>b__1` (method): constructs `SturmLeaperBuf` — `.ctor([<>c__DisplayClass31_0.<>4__this+0x14], ((int(frintp((((((int(floor((((fsqrt(((([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z) * ([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z)) + (([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x) * ([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x)))) * 100)) + 0.5))) / 100) / MathUtil.DisplayMeterToDistance(9)) * 100)) + -0.5))) / 100) pl 0.1 ? min((int(frintp((((((int(floor((((fsqrt(((([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z) * ([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z)) + (([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x) * ([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x)))) * 100)) + 0.5))) / 100) / MathUtil.DisplayMeterToDistance(9)) * 100)) + -0.5))) / 100), 1) : 0.1), [<>c__DisplayClass31_0.<>4__this+0x135])`
- `.<>c__DisplayClass31_0::<ActionStart>b__1` (method): constructs `SturmLeaperBuf` — `.ctor([<>c__DisplayClass31_0.<>4__this+0x14], ((int(floor((((((int(floor((((fsqrt(((([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z) * ([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z)) + (([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x) * ([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x)))) * 100)) + 0.5))) / 100) / MathUtil.DisplayMeterToDistance(9)) * 100)) + 0.5))) / 100) pl 0.1 ? min((int(floor((((((int(floor((((fsqrt(((([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z) * ([<>c__DisplayClass31_0.<>4__this+0x140] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).z)) + (([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x) * ([<>c__DisplayClass31_0.<>4__this+0x138] - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(<>c__DisplayClass31_0.actarAction)).x)))) * 100)) + 0.5))) / 100) / MathUtil.DisplayMeterToDistance(9)) * 100)) + 0.5))) / 100), 1) : 0.1), [<>c__DisplayClass31_0.<>4__this+0x135])`

**Buff values** (every recovered field; durations in seconds)

**Buff `SturmLeaperBuf`**
- `ShortRangeRate` = `(0)` _(when BuffEffectActive ne 0)_
- `LongRangeRate` = `(((int(((((Lv << 2) + lv) << 1) * rate)) lt 0 ? (int(((((Lv << 2) + lv) << 1) * rate)) + 1) : int(((((Lv << 2) + lv) << 1) * rate))) >> 1))` _(when BuffEffectActive ne 0)_
- Buff fields set in the constructor (all recovered):
  - `temporaryCount` = `-1` = -1
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `shortRange` = `0` when (OrbitReaper & 1) ne 0
  - `shortRange` = `int(((((Lv << 2) + lv) << 1) * rate))` when (OrbitReaper & 1) eq 0
  - `longRange` = `((int(((((Lv << 2) + lv) << 1) * rate)) lt 0 ? (int(((((Lv << 2) + lv) << 1) * rate)) + 1) : int(((((Lv << 2) + lv) << 1) * rate))) >> 1)` when (OrbitReaper & 1) ne 0
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:SturmLeaperBuf$$.ctor<-SturmLeaperAction.<>c__DisplayClass31_0$$<ActionStart>b__1` (no direct constructor call in the skill's own code).
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
- `LongRangeRate`: long-range damage %
- `ShortRangeRate`: short-range damage %

_Raw recovered data (every method item): [trees/DualSword.md](../trees/DualSword.md) — uid 653_

---

### เซเบอร์ออร่า (SaberAura) · uid 654

<img src="../../icons/sk_654.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 4) · **Type:** Buffer · **Max Lv:** 170 · **Weapons:** TwinSword · **Requires:** เร็วดุจเทพ · **Client class:** `SaberAuraAction`

> ดาบคู่เปล่งประกายแสงศักดิ์สิทธิ์
> เพิ่มความเร็วการเคลื่อนไหวและสเตตัสต่างๆ
> ใช้ HP อย่างต่อเนื่อง ถ้าใช้ไม่ได้เมื่อไหร่ผลจะสิ้นสุดลง
> ใช้ทับซ้อนกันไม่ได้

**How it works**

- Buffer skill of the デュアルスキル tree (tier 4, max Lv 170); usable with TwinSword.
- It installs a buff on the caster.
- Buffs:
  - `SaberAuraBuf`; Lv1 → Lv10: Count (stack / hit counter) 1 → 1, HitUp (accuracy +) 5 → 50, Value (generic value (meaning set by the code that reads the buff)) 100 → 100, AspdRate (attack speed %) 10 → 100, AttackMprecoveryUp (MP recovered per attack (flat)) 1 → 5, CrtUp (critical rate +) 2 → 25
- Other client code reads this skill (12 lookups; see the last section).

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 1 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 2 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 654
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): adds the caster's buff of `PlayerAttackBase.get_ActionID()` — `AddSelfBuffer(PlayerAttackBase.get_ActionID(), Lv, Id)`
  - when `UnityEngine.Object.op_Inequality(actarAction) OR TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 657) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 657) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): removes the caster's buff of skill 657 (ArkSaber) — `RemoveSelfBuffer(657)`
  - when `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 657) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)`

**Buff values** (every recovered field; durations in seconds)

**Buff `SaberAuraBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `BufferEnd`, `CheckTake`, `CheckUnableEquipChange`, `Inquire`, `get_BufEffectTakeId`, `get_IsBufferEnd`, `get_IsPutUpWeapon`

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Count | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 |
| HitUp | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |
| Value | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |
| AspdRate | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |
| AttackMprecoveryUp | 1 | 1 | 2 | 2 | 3 | 3 | 4 | 4 | 5 | 5 |
| CrtUp | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |

- Buff fields set in the constructor (all recovered):
  - `isBattleActive` = `1` = 1
  - `Count` = `1` = 1
  - `hitUp` = `(Lv + (Lv << 2))` → Lv1..10 [5, 10, 15, 20, 25, 30, 35, 40, 45, 50]
  - `strengthenInterval` = `(7 - int(((Lv + 1) * 0.5)))` → Lv1..10 [6, 6, 5, 5, 4, 4, 3, 3, 2, 2]
  - `payHp` = `(25 - (Lv << 1))` → Lv1..10 [23, 21, 19, 17, 15, 13, 11, 9, 7, 5]
  - `increase` = `5` = 5
  - `moveSpeed` = `100` = 100
  - `critical` = `int((Lv * 2.5))` → Lv1..10 [2, 5, 7, 10, 12, 15, 17, 20, 22, 25]
  - `aspdRate` = `((Lv + (Lv << 2)) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]
  - `atkMpHeal` = `(int(((Lv - 1) * 0.5)) + 1)` → Lv1..10 [1, 1, 2, 2, 3, 3, 4, 4, 5, 5]
  - `timer` = `(7 - int(((Lv + 1) * 0.5)))` → Lv1..10 [6, 6, 5, 5, 4, 4, 3, 3, 2, 2]
  - `player` = `PlayerDataManager.GetPlayerDataManager()`
- Hook `Updata`: `isBattleActive`=(PlayerActionManagerBase.get_IsBattleActive(PlayerDataManager.get_PlayerActionManager(player)) & 1); `timer`=strengthenInterval; `payHp`=System.Math.Min(99, (increase + payHp)); `inquireTime`=UnityEngine.Time.get_realtimeSinceStartup()
- Hook `Inquire`: `inquire`=1; `inquireTime`=UnityEngine.Time.get_realtimeSinceStartup()
- Hook `BufferEnd`: `bufferEnd`=1; `LeftTime`=(Count + 10)

Parameter meanings (inferred from the `SkillBufferId` names):

- `AspdRate`: attack speed %
- `AttackMprecoveryUp`: MP recovered per attack (flat)
- `Count`: stack / hit counter
- `CrtUp`: critical rate +
- `HitUp`: accuracy +
- `Value`: generic value (meaning set by the code that reads the buff)

**Where else this skill takes effect**

- Effect applied in `MobaPlayerActionManager$$get_MoveSpeed` (36 guarded paths):
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1223, 0, ?x3)`
    - calls `AbnormalStateManager$$Contains`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaRoomData$$get_NowGamePhase`, `PlayerActionManagerBase$$get_IsBattleActive`, `SkillBufferManager$$GetSkillBuffer`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `AbnormalStateManager$$Contains`
  - always
    - returns `AbnormalStateManager.Contains(?blr, 11, 0, ?x3)`
    - calls `AbnormalStateManager$$Contains`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaRoomData$$get_NowGamePhase`, `PlayerActionManagerBase$$get_IsBattleActive`, `SkillBufferManager$$GetSkillBuffer`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `AbnormalStateManager$$Contains`
  - when `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1223, 0, ?x3)`
    - calls `AbnormalStateManager$$Contains`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaRoomData$$get_NowGamePhase`, `PlayerActionManagerBase$$get_IsBattleActive`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `AbnormalStateManager$$Contains`, `GemCartBufferManager$$GetGemCartBuffer`
  - when `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `AbnormalStateManager.Contains(?blr, 11, 0, ?x3)`
    - calls `AbnormalStateManager$$Contains`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaPlayerActionManager$$get_mobaRoomData`, `MobaRoomData$$get_NowGamePhase`, `PlayerActionManagerBase$$get_IsBattleActive`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `AbnormalStateManager$$Contains`
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
- Effect applied in `PlayerActionManager$$get_MoveSpeed` (58 guarded paths):
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
- Effect applied in `ArkSaberAction$$ActionHit` (3 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.AddSelfBuffer(?blr, 0x165db78(meta(0x399cf20, ArkSaberBuf_TypeInfo), ?x1, ?x2, ?x3), Id, 0)`
    - calls `SaberAuraBuf$$BufferEnd`, `SkillBufferManager$$RemoveSelfBuffer`, `0x165db78`, `ArkSaberBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
  - when `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `0x165db84`, `0x165df00`
  - when `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-56), 0) & 1) eq 0`
    - returns `SkillBufferManager.AddSelfBuffer(?blr, 0x165db78(meta(0x399cf20, ArkSaberBuf_TypeInfo), ?x1, ?x2, ?x3), Id, 0)`
    - calls `0x165db78`, `ArkSaberBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
- Effect applied in `ArkSaberAction$$ActionStart` (3 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `TryGetBuf.out2()`
    - set `level` = `[TryGetBuf.out2()+0x20]`
    - calls `PlayerAttackBase$$ActionStart`
  - when `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `PlayerAttackBase$$ActionStart`, `0x165db84`, `0x165df00`
  - when `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-40), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 654, stkp(-40), 0)`
    - calls `PlayerAttackBase$$ActionStart`
- Effect applied in `ArkSaberAction$$ConverterArkSaberSkillId` (3 guarded paths):
  - when `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 654, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `([TryGetBuf.out2()+0x50] eq 0 ? 657 : skillId)`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 654, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`, `0x165df00`
  - when `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 654, stkp(-40), 0) & 1) eq 0`
    - returns `skillId`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- Effect applied in `ArkSaberAction$$IsFailure` (4 guarded paths):
  - when `change eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 654, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() gt 1`
    - returns `(PlayerAttackBase.IsFailure(this, status, missType, 0) & 1)`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `PlayerAttackBase$$IsFailure`
  - when `change eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 654, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() le 1`
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `change eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 654, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
  - when `change eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 654, stkp(-40), 0) & 1) eq 0`
    - returns `(PlayerAttackBase.IsFailure(this, status, missType, 0) & 1)`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
- Effect applied in `MobaPlayerActionManager$$SupportReserve` (48 guarded paths):
  - when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
    - returns `UI3DLabelManager.SetSkillMissPopUp(Singleton<object>.get_Instance(meta(0x3974690, Method$Singleton<UI3DLabelManager>.get_Instance()), ?x1, ?x2, ?x3), GetAvailableSkill.out4(), 0, ?x3)`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `Singleton<object>$$get_Instance`, `UI3DLabelManager$$SetSkillMissPopUp`
  - when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `0x165df00`
  - when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
    - returns `UI3DLabelManager.SetSkillMissPopUp(Singleton<object>.get_Instance(meta(0x3974690, Method$Singleton<UI3DLabelManager>.get_Instance()), ?x1, ?x2, ?x3), 3, 0, ?x3)`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `PlayerStatusBase$$GetEquipSkill`, `SkillComboManager$$CheckCombo`, `SkillComboState$$TemporaryUseSkill`, `AbnormalStateManager$$Contains`
  - when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
    - returns `GameManager.StartSupportSkill(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), target, (GetAvailableSkill.out4() eq 6 ? 0 : SkillManager.GetAvailableSkill(CharacterActionManagerBase.get_IsDeadOrLocalDead(), this, 0, ([TryGetBuf.out2()+0x50] eq 0 ? 657 : 654))), 0)`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `PlayerStatusBase$$GetEquipSkill`, `SkillComboManager$$CheckCombo`, `SkillComboState$$TemporaryUseSkill`, `AbnormalStateManager$$Contains`
  - when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
    - returns `MobaPlayerActionManager.SkillReserveMpLess(this, (GetAvailableSkill.out4() eq 6 ? 0 : SkillManager.GetAvailableSkill(CharacterActionManagerBase.get_IsDeadOrLocalDead(), this, 0, ([TryGetBuf.out2()+0x50] eq 0 ? 657 : 654))), stkp(-72), ?x3)`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `PlayerStatusBase$$GetEquipSkill`, `SkillComboManager$$CheckCombo`, `SkillComboState$$TemporaryUseSkill`, `AbnormalStateManager$$Contains`
  - when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
    - returns `BattleManagerBase.SupportReserve(battleManager, target, (GetAvailableSkill.out4() eq 6 ? 0 : SkillManager.GetAvailableSkill(CharacterActionManagerBase.get_IsDeadOrLocalDead(), this, 0, ([TryGetBuf.out2()+0x50] eq 0 ? 657 : 654))), (([TryGetBuf.out2()+0x50] eq 0 ? 657 : 654) ne 0 ? 1 : 0))`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `PlayerStatusBase$$GetEquipSkill`, `SkillComboManager$$CheckCombo`, `SkillComboState$$TemporaryUseSkill`, `AbnormalStateManager$$Contains`
  - when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
    - returns `BattleManagerBase.SupportReserve(battleManager, target, (GetAvailableSkill.out4() eq 6 ? 0 : SkillManager.GetAvailableSkill(CharacterActionManagerBase.get_IsDeadOrLocalDead(), this, 0, ([TryGetBuf.out2()+0x50] eq 0 ? 657 : 654))), (([TryGetBuf.out2()+0x50] eq 0 ? 657 : 654) ne 0 ? 1 : 0))`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `PlayerStatusBase$$GetEquipSkill`, `SkillComboManager$$CheckCombo`, `SkillComboState$$TemporaryUseSkill`, `AbnormalStateManager$$Contains`
  - when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
    - returns `UI3DLabelManager.SetSkillMissPopUp(Singleton<object>.get_Instance(meta(0x3974690, Method$Singleton<UI3DLabelManager>.get_Instance()), ?x1, ?x2, ?x3), 3, 0, ?x3)`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `PlayerStatusBase$$GetEquipSkill`, `SkillComboManager$$CheckCombo`, `AbnormalStateManager$$Contains`, `Singleton<object>$$get_Instance`
- Code that reads this skill's level / buff by constant id: `ArkSaberAction$$ActionHit (TryGetBuf)`, `ArkSaberAction$$ActionStart (TryGetBuf)`, `ArkSaberAction$$ConverterArkSaberSkillId (TryGetBuf)`, `ArkSaberAction$$IsFailure (TryGetBuf)`, `MobaPlayerActionManager$$SupportReserve (TryGetBuf)`, `MobaPlayerActionManager$$get_MoveSpeed (ContainsBuffer)`, `PlayerActionManager$$get_MoveSpeed (ContainsBuffer)`, `UIActiveBaseShortcutButton$$SkillButton (ContainsBuffer)`, `UIGLShortcutButton$$LabelUpdate (ContainsBuffer)`, `UIGLShortcutButton$$Update (ContainsBuffer)`, `UIShortcutListButton$$OnSkillCostCheck (ContainsBuffer)`, `UIShortcutListButton$$SetSkillButton (ContainsBuffer)`

_Raw recovered data (every method item): [trees/DualSword.md](../trees/DualSword.md) — uid 654_

---

### เอเลียสลีย์ (ArialSlay) · uid 659

<img src="../../icons/sk_659.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 4) · **Type:** Special · **Max Lv:** 170 · **Weapons:** OneHandSword, TwinSword · **Requires:** เร็วดุจเทพ · **Client class:** `ArialSlayAction`

> ฟันรัวขณะหลอกล่อศัตรู
> เมื่อใช้ในคอมโบ(ยกเว้นครั้งแรก)
> จะใช้ MP 100
> 
> สามารถเคลื่อนที่ได้ขณะใช้สกิล

**How it works**

- Special skill of the デュアルスキル tree (tier 4, max Lv 170); usable with OneHandSword, TwinSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- It can inflict a status ailment (chance and type below).
- MP: `100`.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on Dex (formula below); flat damage +120 at Lv1 to 300 at Lv10
- Proration: slot chosen at runtime (physical or magic by a per-cast flag), mode `first_hit_per_target`.
- Can inflict on the target: None (0).
- Buffs:
  - `ArialSlayBuf`: lasts `5` s
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (2 lookups; see the last section).

**Cost, timing and range**

- **MP cost** (`baseMp` in `ChangeMpDuringCombo`): `100` = 100
  - when `combo.index ge 1`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`
  - when `((1 << subWeaponType) & 0x888000) ne 0 AND subWeapon == OneHandSword AND subWeaponType ls 23 OR ((1 << subWeaponType) & 0x888000) ne 0 AND (subWeaponType | 2) eq 18 AND subWeapon == OneHandSword AND subWeaponType ls 23 OR ((1 << subWeaponType) & 0x888000) ne 0 AND (subWeaponType | 2) ne 18 AND subWeapon == OneHandSword AND subWeaponType ls 23`
- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
  - when `subWeapon == OneHandSword AND subWeaponType hi 23 OR ((1 << subWeaponType) & 0x888000) eq 0 AND subWeapon == OneHandSword AND subWeaponType ls 23 OR (subWeaponType | 2) eq 18 AND subWeapon == OneHandSword AND subWeaponType hi 23`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 6 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionStart` — when the cast starts: 5 set, 2 call
- `ChangeMpDuringCombo` — MP cost adjustment while inside a combo chain: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 1 info
- `Damaged` — when the caster takes damage while the action / buff is active: 1 call
- `ActionSkillEvent` — on an animation/skill event during the motion: 1 set
- `.<>c__DisplayClass30_0::<ActionStart>b__0` — skill-specific method: 1 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 120 | 140 | 160 | 180 | 200 | 220 | 240 | 260 | 280 | 300 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((((Lv * 50) + System.Math.Max(status.Dex, baseSTR))) / 100)`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv * 50) + System.Math.Max(status.Dex, baseSTR))) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv * 20) + 100))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `dynamic`, mode `first_hit_per_target`, attack type `dynamic`, action id 659
- Uses the slot chosen at runtime (physical or magic by a per-cast flag); Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Marks the hit with ailment **None (0)** (`Damaged`)
  - when `EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 17 AND SkillDamageData.IsInactivityAbnormal(damageData) AND hasBuff(659)`

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): constructs `ArialSlayBuf` — `.ctor(Lv, PlayerActionManagerBase.get_PlayerStatus())`
  - when `!PlayerAttackBase.IsBlank(this) AND SubWeaponType eq 17 AND SubWeaponType ne 10 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND hasBuff(519) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND SubWeaponType eq 17 AND SubWeaponType ne 10 AND hasBuff(519) OR !PlayerAttackBase.IsBlank(this) AND !hasBuff(519) AND SubWeaponType eq 17 AND SubWeaponType ne 10 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0)`
- `ActionStart` (when the cast starts): adds the caster's buff of `new ArialSlayBuf` — `AddSelfBuffer(new ArialSlayBuf, Id)`
  - when `!PlayerAttackBase.IsBlank(this) AND SubWeaponType eq 17 AND SubWeaponType ne 10 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND hasBuff(519) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0) AND SubWeaponType eq 17 AND SubWeaponType ne 10 AND hasBuff(519) OR !PlayerAttackBase.IsBlank(this) AND !hasBuff(519) AND SubWeaponType eq 17 AND SubWeaponType ne 10 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<CharacterMove>(actarAction), 0)`
- `.<>c__DisplayClass30_0::<ActionStart>b__0` (method): removes the caster's buff of skill 659 (ArialSlay) — `RemoveSelfBuffer(659)`

**Other recovered parameters**

- **Base MP cost** (`baseMp`): `100` = 100 _(when combo.index ge 1)_

**Buff values** (every recovered field; durations in seconds)

**Buff `ArialSlayBuf`**
- Duration: `5` s [EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 10 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 17]
- `MobLastDamageRateBuf` = `System.Math.Min(((ItemData.get_Refine((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()))) & 255) << 1), 30)` _(when subWeapon.Type eq 17)_
- `MobLastDamageRateBuf` = `0` _(when subWeapon.Type ne 17)_
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `flag` = `1024` = 1024 when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 10 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 17 OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 10 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 17
  - `flag` = `3072` = 3072 when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17
  - `subWeapon` = `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())` when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 10 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 17 OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 10 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 17
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:ArialSlayBuf$$.ctor<-ArialSlayAction$$ActionStart` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

Parameter meanings (inferred from the `SkillBufferId` names):

- `MobLastDamageRateBuf`: final damage multiplier vs monsters (buff category)

**In-game level notes**

- Lv16: [ได้รับผลแบบเดียวกันเมื่อใช้กับมีดสั้น] เปิดใช้งานในสภาวะรวดเร็ว
- Lv17: ระหว่างใช้งานจะได้รับการต้านทานความเสียหายและ ต้านทานผลกระทบที่ทำให้ไม่สามารถเคลื่อนไหวได้ตามค่าถลุง  เมื่อใช้สกิล "เอเลียสลีย์" ผลของสกิล "ฟาเรส" จะยังคงอยู่
- Lv15: *สามารถเปิดใช้งานได้แม้ว่าเป้าหมายจะอยู่ห่างออกไป และเปลี่ยนเป็นความเสียหายเวทมนตร์
- Lv19: [จะได้รับผลแบบเดียวกันเมื่อใช้คัมภีร์นินจูตสึ] *สามารถเปิดใช้งานได้แม้ว่าเป้าหมายจะอยู่ห่างออกไป
- Lv10: 5MP เฮทของตัวเองจะลดลงอย่างมากเป็นเวลา 5 วินาที

**Where else this skill takes effect**

- Effect applied in `ArialSlayAction$$Damaged` (4 guarded paths):
  - always
    - calls `EquipItemData$$get_SubWeaponItemType`, `SkillDamageData$$IsInactivityAbnormal`, `SkillDamageData$$SetAbnormalType`
  - always
    - returns `SkillDamageData.IsInactivityAbnormal(damageData, 0, ?x2, ?x3)`
    - calls `EquipItemData$$get_SubWeaponItemType`, `SkillDamageData$$IsInactivityAbnormal`
  - always
    - returns `EquipItemData.get_SubWeaponItemType(?blr, 0, ?x2, ?x3)`
    - calls `EquipItemData$$get_SubWeaponItemType`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 659, 0, ?x3)`
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
- Code that reads this skill's level / buff by constant id: `ArialSlayAction$$Damaged (ContainsBuffer)`, `MobAttackBase$$CalcLastDamage (TryGetBuf)`

_Raw recovered data (every method item): [trees/DualSword.md](../trees/DualSword.md) — uid 659_

---

### ลูนาดิธเธอร์สตาร์ (LunaDitherStar) · uid 655

<img src="../../icons/sk_655.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 5) · **Type:** Attack · **Max Lv:** 250 · **Weapons:** TwinSword · **Requires:** [N]ไชน์นิ่งครอส[N2]เบลซซิ่งไชน์นิ่งครอส[N] · **Client class:** `LunaDitherStarAction`

> เงาจันทร์เปล่งประกาย ธาตุคู่(ดาบมือเดียว)
> หลังใช้งานถ้ากดปุ่มเคลื่อนที่ถอยหลังจะถอยกลับทันที
> และแทงศัตรูด้วยดาบแสงจันทร์

**How it works**

- Attack skill of the デュアルスキル tree (tier 5, max Lv 250); usable with TwinSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- MP: `(hasGemCart(1040) ? 300 : 400)`.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [(System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, mobAction, meta(0x39a82c0, Method$System.Collections.Generic.Dictionary<MobActionManagerBase, int>.ContainsKey())) & 1) eq 0]: skill multiplier depends on Dex (formula below); flat damage +400
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Buffs:
  - `WrapAroundBuf`; Lv1 → Lv10: CrtUpRate (critical rate %) 20 → 200, AttackMprecoveryUp (MP recovered per attack (flat)) 1 → 10
  - `CountBufferBase`
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **MP cost** (`baseMp` in `OnInitialize`): `(hasGemCart(1040) ? 300 : 400)`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 7 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `OtherPlayerSkillEventReceive` — skill-specific method: 2 set
- `ActionStart` — when the cast starts: 3 set
- `ActionSkillEvent` — on an animation/skill event during the motion: 2 set, 2 call
- `CheckRangeHit` — range-hit test: 2 set
- `ActionSkillEventIfMoveIndex` — skill-specific method: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 4 tpl, 1 call, 1 info
- `RegistInterruptableSkill` — skill-specific method: 1 set
- `SetNextAction` — skill-specific method: 1 set
- `ReceivedAbnormal` — skill-specific method: 1 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((((status.Dex / 1.5) + ((Lv * 50) + 500))) / 100)` — (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, mobAction, meta(0x39a82c0, Method$System.Collections.Generic.Dictionary<MobActionManagerBase, int>.ContainsKey())) & 1) eq 0

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((status.Dex / 1.5) + ((Lv * 50) + 500))) / 100)`
  - when `(System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, mobAction, meta(0x39a82c0, Method$System.Collections.Generic.Dictionary<MobActionManagerBase, int>.ContainsKey())) & 1) eq 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(400)`
  - when `(System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, mobAction, meta(0x39a82c0, Method$System.Collections.Generic.Dictionary<MobActionManagerBase, int>.ContainsKey())) & 1) eq 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[FirstAttackRate]` = `(PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100)`
  - when `(System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, mobAction, meta(0x39a82c0, Method$System.Collections.Generic.Dictionary<MobActionManagerBase, int>.ContainsKey())) & 1) eq 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, playerAction)`
  - when `(System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, mobAction, meta(0x39a82c0, Method$System.Collections.Generic.Dictionary<MobActionManagerBase, int>.ContainsKey())) & 1) eq 0`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 655
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `ActionSkillEvent` (on an animation/skill event during the motion): constructs `WrapAroundBuf` — `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 651, 1))`
  - when `!UnityEngine.Object.op_Equality(actarAction) AND (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 651, 1) & 255) ne 0 AND IsInstanceOf(actarAction.battleManager, PlayerBattleManager) eq 1 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 651, 1) & 255) ne 0 AND IsInstanceOf(actarAction.battleManager, PlayerBattleManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 100 AND param ne 101 OR (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 651, 1) & 255) ne 0 AND IsInstanceOf(actarAction.battleManager, PlayerBattleManager) eq 1 AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 100 AND param ne 101`
- `ActionSkillEvent` (on an animation/skill event during the motion): adds the caster's buff of `new WrapAroundBuf` — `AddSelfBuffer(new WrapAroundBuf, Id)`
  - when `!UnityEngine.Object.op_Equality(actarAction) AND (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 651, 1) & 255) ne 0 AND IsInstanceOf(actarAction.battleManager, PlayerBattleManager) eq 1 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 100 AND param ne 101 OR !UnityEngine.Object.op_Equality(actarAction) AND (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 651, 1) & 255) ne 0 AND IsInstanceOf(actarAction.battleManager, PlayerBattleManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 100 AND param ne 101 OR (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 651, 1) & 255) ne 0 AND IsInstanceOf(actarAction.battleManager, PlayerBattleManager) eq 1 AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 100 AND param ne 101`
- `calcPlayerToMobDamage` (damage calculation against a monster): chains one more damage event — `CreateNextDamage()`
  - when `(System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, mobAction, meta(0x39a82c0, Method$System.Collections.Generic.Dictionary<MobActionManagerBase, int>.ContainsKey())) & 1) eq 0`
- `ReceivedAbnormal` (method): removes the caster's buff of skill 671 (LunaDitherStarBladeRainAction) — `RemoveSelfBuffer(671)`
  - when `AbnormalTypeEx.IsActionStop(type) AND hasBuff(671)`

**Other recovered parameters**

- **Base MP cost** (`baseMp`): `(hasGemCart(1040) ? 300 : 400)`

**Buff values** (every recovered field; durations in seconds)

**Buff `WrapAroundBuf`**

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| CrtUpRate | 20 | 40 | 60 | 80 | 100 | 120 | 140 | 160 | 180 | 200 |
| AttackMprecoveryUp | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |

- Buff fields set in the constructor (all recovered):
  - `temporaryCount` = `-1` = -1
  - `crtRate` = `(((Lv << 2) + lv) << 2)` → Lv1..10 [20, 40, 60, 80, 100, 120, 140, 160, 180, 200]
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:WrapAroundBuf$$.ctor<-LunaDitherStarAction$$ActionSkillEvent` (no direct constructor call in the skill's own code).
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

- `AttackMprecoveryUp`: MP recovered per attack (flat)
- `Count`: stack / hit counter
- `CrtUpRate`: critical rate %

**Where else this skill takes effect**

- Effect applied in `ShiningClothAction$$OnInitialize` (2 guarded paths):
  - always
    - set `Element` = `5`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `skillRate` = `(((Lv * 10) + 300) + (((IPlayerStatusCalculator.get_Agi(?blr) // 4) + (IPlayerStatusCalculator.get_Str(?blr) // 4)) + (IPlayerStatusCalculator.get_Dex(?blr) // 4)))`
    - set `fixAddDamage` = `((Lv * 20) + 100)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `change` = `1`
    - set `SkillIndividualFlag` = `0x10000`
    - set `LoopParam` = `SubElement`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMp`, `PlayerAttackBase$$CalcMotionSpeed`, `interface IPlayerStatusCalculator.get_Str`, `interface IPlayerStatusCalculator.get_Agi`, `interface IPlayerStatusCalculator.get_Dex`, `0x165db78`, `SkillLinkedTake$$.ctor`
  - always
    - set `Element` = `5`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `skillRate` = `(((Lv * 10) + 300) + (((IPlayerStatusCalculator.get_Agi(?blr) // 5) + (IPlayerStatusCalculator.get_Str(?blr) // 5)) + (IPlayerStatusCalculator.get_Dex(?blr) // 5)))`
    - set `fixAddDamage` = `((Lv * 20) + 100)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `SkillIndividualFlag` = `0`
    - set `LoopParam` = `SubElement`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMp`, `PlayerAttackBase$$CalcMotionSpeed`, `interface IPlayerStatusCalculator.get_Str`, `interface IPlayerStatusCalculator.get_Agi`, `interface IPlayerStatusCalculator.get_Dex`, `0x165db78`, `SkillLinkedTake$$.ctor`
- Code that reads this skill's level / buff by constant id: `ShiningClothAction$$OnInitialize (ContainsBuffer)`

_Raw recovered data (every method item): [trees/DualSword.md](../trees/DualSword.md) — uid 655_

---

### ทวินบัสตาร์ดเบลด (TwinBusterBlade) · uid 656

<img src="../../icons/sk_656.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 5) · **Type:** Attack · **Max Lv:** 250 · **Weapons:** TwinSword · **Requires:** [N]ไชน์นิ่งครอส[N2]เบลซซิ่งไชน์นิ่งครอส[N] · **Client class:** `TwinBusterBladeAction`

> ฟันต่อเนื่องสองครั้งพร้อมออร่า
> เป็นการโจมตีสองครั้งที่มีโอกาสติดคริติคอลสูง
> 
> ครั้งที่ 1 จะฟันเป้าหมายอย่างต่อเนื่อง
> ครั้งที่ 2 โจมตีแบบวงกว้างความแรง
> จะเพิ่มขึ้นตามจำนวนเป้าหมายที่ถูกโจมตี

**How it works**

- Attack skill of the デュアルスキル tree (tier 5, max Lv 250); usable with TwinSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [lineAttack ne 0]: skill multiplier ×5; flat damage +30 at Lv1 to 300 at Lv10
  - `calcPlayerToMobDamage` [IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(targetTransform) AND isExorcism ne 0 AND param eq 100 & lineAttack ne 0]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [!UnityEngine.Object.op_Inequality(actarAction) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform), 0) AND UnityEngine.Object.op_Inequality(targetTransform) AND isExorcism ne 0 AND param eq 100 & lineAttack ne 0]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [!UnityEngine.Object.op_Inequality(targetTransform) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND isExorcism ne 0 AND param eq 100 OR !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform), 0) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(targetTransform) AND isExorcism ne 0 AND param eq 100 & lineAttack ne 0]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [(System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND lineAttack eq 0 OR (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND MobActionManagerBase.get_SystemInvincible(mobAction) AND lineAttack eq 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND lineAttack eq 0]: skill multiplier depends on live values (formula below); flat damage +30 at Lv1 to 300 at Lv10
- Proration: physical-skill proration slot, mode `first_hit_per_target`.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(7)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 8 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionStart` — when the cast starts: 9 set, 1 call
- `ActionSkillEvent` — on an animation/skill event during the motion: 10 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 8 tpl, 1 info, 1 call
- `.<>c__DisplayClass39_0::<ActionStart>b__0` — skill-specific method: 1 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 5 | 5 | 5 | 5 | 5 | 5 | 5 | 5 | 5 | 5 |
| Flat dmg + [lineAttack ne 0] | 30 | 60 | 90 | 120 | 150 | 180 | 210 | 240 | 270 | 300 |
| Flat dmg + [(System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND lineAttack eq 0 OR (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND MobActionManagerBase.get_SystemInvincible(mobAction) AND lineAttack eq 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND lineAttack eq 0] | 30 | 60 | 90 | 120 | 150 | 180 | 210 | 240 | 270 | 300 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((500) / 100)` — IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(targetTransform) AND isExorcism ne 0 AND param eq 100 & lineAttack ne 0
- SkillRate × `((500) / 100)` — !UnityEngine.Object.op_Inequality(actarAction) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform), 0) AND UnityEngine.Object.op_Inequality(targetTransform) AND isExorcism ne 0 AND param eq 100 & lineAttack ne 0
- SkillRate × `((500) / 100)` — !UnityEngine.Object.op_Inequality(targetTransform) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND isExorcism ne 0 AND param eq 100 OR !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform), 0) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(targetTransform) AND isExorcism ne 0 AND param eq 100 & lineAttack ne 0
- SkillRate × `((((Lv * 75) + (((baseDEX + baseAGI) lt 0 ? ((baseDEX + baseAGI) + 1) : (baseDEX + baseAGI)) >> 1))) / 100)` — (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND lineAttack eq 0 OR (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND MobActionManagerBase.get_SystemInvincible(mobAction) AND lineAttack eq 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND lineAttack eq 0

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((500) / 100)`
  - when `lineAttack ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `((Lv * 30))`
  - when `lineAttack ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[FirstAttackRate]` = `(PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100)`
  - when `lineAttack ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, playerAction)`
  - when `lineAttack ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefSkill / 100)`
  - when `lineAttack ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(targetExpList[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`
  - when `lineAttack ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv * 75) + (((baseDEX + baseAGI) lt 0 ? ((baseDEX + baseAGI) + 1) : (baseDEX + baseAGI)) >> 1))) / 100)`
  - when `(System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND lineAttack eq 0 OR (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND MobActionManagerBase.get_SystemInvincible(mobAction) AND lineAttack eq 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND lineAttack eq 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `((Lv * 30))`
  - when `(System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND lineAttack eq 0 OR (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND MobActionManagerBase.get_SystemInvincible(mobAction) AND lineAttack eq 0 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND lineAttack eq 0`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 656
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `calcPlayerToMobDamage` (damage calculation against a monster): chains one more damage event — `CreateNextDamage()`
  - when `(System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND lineAttack eq 0 OR (System.Collections.Generic.Dictionary<object, int>.ContainsKey(targetExpList, MobActionManagerBase.get_CharacterActionManagerBase(mobAction), meta(0x39a83c0, Method$System.Collections.Generic.Dictionary<CharacterActionManagerBase, int>.ContainsKey())) & 1) eq 0 AND MobActionManagerBase.get_SystemInvincible(mobAction) AND lineAttack eq 0`
- `.<>c__DisplayClass39_0::<ActionStart>b__0` (method): adds the caster's buff of skill 45 (BusterBlade) — `AddSelfBuffer(45, <>c__DisplayClass39_0.sLv, 0)`
  - when `!hasBuff(FirstAttackRate) AND (cancel & 1) eq 0 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<TakeController>(<>c__DisplayClass39_0.playerAction), 0) OR !UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<TakeController>(<>c__DisplayClass39_0.playerAction), 0) AND !hasBuff(FirstAttackRate) AND (cancel & 1) eq 0`

**Other recovered parameters**

- **First-part skill multiplier (%)** (`firstSkillRate`): `((Lv * 75) + (((baseDEX + baseAGI) lt 0 ? ((baseDEX + baseAGI) + 1) : (baseDEX + baseAGI)) >> 1))`
- **Second-part multiplier** (`secondSkillRate`): `500` = 500; `min((secondSkillRate + ((baseSTR * 0.5) * ((maxDebufCount lt MobBuffManager.GetDebuffCount(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform))) ? maxDebufCount : MobBuffManager.GetDebuffCount(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform)))) + 1))), 2000)` _(when IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform), 0) AND UnityEngine.Object.op_Inequality(actarAction) AND UnityEngine.Object.op_Inequality(targetTransform) AND isExorcism ne 0 AND param eq 100)_; `min((secondSkillRate + (0.5 * ((maxDebufCount lt MobBuffManager.GetDebuffCount(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform))) ? maxDebufCount : MobBuffManager.GetDebuffCount(EnemyMobActionManagerBase.get_BuffManager(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform)))) + 1))), 2000)` _(when !UnityEngine.Object.op_Inequality(actarAction) AND IsOtherPlayer eq 0 AND UnityEngine.Object.op_Inequality(UnityEngine.Component.GetComponent<EnemyMobActionManagerBase>(targetTransform), 0) AND UnityEngine.Object.op_Inequality(targetTransform) AND isExorcism ne 0 AND param eq 100)_
- **First-part flat damage** (`firstFixAddDamage`): `(Lv * 30)` → Lv1..10 [30, 60, 90, 120, 150, 180, 210, 240, 270, 300]
- **Second-part flat damage** (`secondFixAddDamage`): `(Lv * 30)` → Lv1..10 [30, 60, 90, 120, 150, 180, 210, 240, 270, 300]

**In-game level notes**

- Lv10: ถ้าเรียนรู้บัสตาร์ดเบลดแล้วจะได้รับผลของบัฟที่เหมือนกัน

_Raw recovered data (every method item): [trees/DualSword.md](../trees/DualSword.md) — uid 656_

---

### อาร์คเซเบอร์ (ArkSaber) · uid 657

<img src="../../icons/sk_657.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 5) · **Type:** Buffer · **Max Lv:** 250 · **Weapons:** TwinSword · **Requires:** เซเบอร์ออร่า · **Client class:** `ArkSaberAction` · **Client class:** `ArkSaber` (passive mastery)

> สกิลพิเศษที่สามารถเปิดใช้งานระหว่างใช้เซเบอร์ออร่า
> ช่วยฟื้นฟู HP และจำนวน Avoid
> การใช้ MP นอกเหนือจากสกิลเวทมนตร์จะลดลงครึ่งหนึ่งเสมอ
> พร้อมกับอัตราคริติคอลที่เพิ่มขึ้นเป็นอย่างมาก
> แต่ถ้าโดนศัตรูโจมตีล่ะก็...

**How it works**

- Buffer skill of the デュアルスキル tree (tier 5, max Lv 250); usable with TwinSword.
- It installs a buff on the caster.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Buffs:
  - `ArkSaberBuf`: lasts `((count + (count << 1)) gt 10 ? (count + (count << 1)) : 10)` s; Lv1 → Lv10: Value (generic value (meaning set by the code that reads the buff)) 80 → 80, AttackMprecoveryUp (MP recovered per attack (flat)) 2 → 20, CrtUp (critical rate +) 10 → 100
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (15 lookups; see the last section).

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 1 set
- `ActionStart` — when the cast starts: 1 set
- `ActionHit` — when the attack connects: 3 call
- `LunaDitherStartInterruptableInitialize` — skill-specific method: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 657
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): removes the caster's buff of skill 654 (SaberAura) — `RemoveSelfBuffer(654)`
  - when `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 654) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): constructs `ArkSaberBuf` — `.ctor(Lv, level)`
  - when `UnityEngine.Object.op_Inequality(actarAction) OR TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 654) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): adds the caster's buff of `new ArkSaberBuf` — `AddSelfBuffer(new ArkSaberBuf, Id)`
  - when `UnityEngine.Object.op_Inequality(actarAction) OR TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 654) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)`

**Buff values** (every recovered field; durations in seconds)

**Buff `ArkSaberBuf`**
- Buff hook methods: `BufferEnd`, `get_BufEffectTakeId`
- Duration: `((count + (count << 1)) gt 10 ? (count + (count << 1)) : 10)` s
- `Count` = `(count)` _(when BuffEffectActive ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 80 | 80 | 80 | 80 | 80 | 80 | 80 | 80 | 80 | 80 |
| AttackMprecoveryUp | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |
| CrtUp | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |

- Buff fields set in the constructor (all recovered):
  - `count` = `count`
  - `critical` = `(((Lv << 2) + lv) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]
  - `barrierValue` = `80` = 80
  - `atkMpRecovery` = `(Lv << 1)` → Lv1..10 [2, 4, 6, 8, 10, 12, 14, 16, 18, 20]
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:ArkSaberBuf$$.ctor<-ArkSaberAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

Parameter meanings (inferred from the `SkillBufferId` names):

- `AttackMprecoveryUp`: MP recovered per attack (flat)
- `Count`: stack / hit counter
- `CrtUp`: critical rate +
- `Value`: generic value (meaning set by the code that reads the buff)

**Where else this skill takes effect**

- Effect applied in `PlayerAttackBase$$RemoveAfterSkillBuf` (198 guarded paths, truncated):
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
- Effect applied in `MobaPlayerSecondaryStatus$$GetCrtConstant` (299 guarded paths, truncated):
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3))))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3)))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3)))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3)))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3)))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
- Effect applied in `PlayerSecondaryStatus$$GetCrtConstant` (299 guarded paths, truncated):
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3))))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3)))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3)))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3)))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3)))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(isNormalAttack & 1) ne 0`
    - returns `(CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + ((CharacterActionManagerBase.set_DefaultMoveSpeed() << ([EquipItemData.get_Weapon(?blr, 0, ?x2, ?x3)+0x38] eq 11 ? 1 : 0)) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 40, 0, ?x3))))))))))))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_Weapon`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.get_Size`, `EquipItemData$$get_SubWeapon`, `EquipItemData$$get_Weapon`
- Effect applied in `ArkSaberAction$$ConverterArkSaberSkillId` (4 guarded paths):
  - when `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 654, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `([TryGetBuf.out2()+0x50] eq 0 ? 657 : skillId)`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 654, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`, `0x165df00`
  - when `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 654, stkp(-40), 0) & 1) eq 0`
    - returns `skillId`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `SkillLv(657) lt 1`
    - returns `skillId`
    - calls `virtual PlayerStatusBase.get_SkillManager`
- Effect applied in `ArkSaber$$CalcConstantDamage` (3 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 657, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `max((int((((max((IPlayerStatusCalculator.get_Critical(?blr) - 100), 0) - max((MobPropertyCriticalResist.GetCriticalResist(0, mobAction, 0, 0x165da60([((vtab(mobAction) + (([(meta(0) + 8)+0x0] + meta(0)) << 4)) + 312)+0x8], meta(0x399fbb8, Method$MobActionManagerBase.TryGetProperties<MobPropertyCriticalResist>()), meta(0), ?x3)) - 100), 0)) / 10) * [TryGetBuf.out2()+0x10])) lt 200 ? int((((max((IPlayerStatusCalculator.get_Critical(?blr) - 100), 0) - max((MobPropertyCriticalResist.GetCriticalResist(0, mobAction, 0, 0x165da60([((vtab(mobAction) + (([(meta(0) + 8)+0x0] + meta(0)) << 4)) + 312)+0x8], meta(0x399fbb8, Method$MobActionManagerBase.TryGetProperties<MobPropertyCriticalResist>()), meta(0), ?x3)) - 100), 0)) / 10) * [TryGetBuf.out2()+0x10])) : 200), 0)`
    - calls `0x165da60`, `MobPropertyCriticalResist$$GetCriticalResist`, `interface IPlayerStatusCalculator.get_Critical`
  - when `(SkillBufferManager.TryGetBuf(?blr, 657, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `0x165da60`, `MobPropertyCriticalResist$$GetCriticalResist`, `interface IPlayerStatusCalculator.get_Critical`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(?blr, 657, stkp(-40), 0) & 1) eq 0`
    - returns `0`
- Effect applied in `SaberAuraAction$$ActionHit` (3 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 657, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 657, 0, ?x3)`
    - calls `virtual PlayerAttackBase.get_ActionID`, `SkillBufferManager$$AddSelfBuffer`, `ArkSaberBuf$$BufferEnd`, `SkillBufferManager$$RemoveSelfBuffer`
  - when `(SkillBufferManager.TryGetBuf(?blr, 657, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual PlayerAttackBase.get_ActionID`, `SkillBufferManager$$AddSelfBuffer`, `0x165db84`, `0x165df00`
  - when `(SkillBufferManager.TryGetBuf(?blr, 657, stkp(-40), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 657, stkp(-40), 0)`
    - calls `virtual PlayerAttackBase.get_ActionID`, `SkillBufferManager$$AddSelfBuffer`
- Effect applied in `PlayerDataManager$$OnSkillBuffEnd` (3 guarded paths):
  - when `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.RemoveSelfBuffer(PlayerDataManager.get_SkillBufferManager(this, ?x1, ?x2, ?x3), 657, 0, ?x3)`
    - calls `PlayerDataManager$$UpdateServerHP`, `PlayerDataManager$$UpdateServerMp`, `PlayerDataManager$$get_SkillBufferManager`, `ArkSaberBuf$$BufferEnd`, `PlayerDataManager$$get_SkillBufferManager`, `SkillBufferManager$$RemoveSelfBuffer`
  - when `TryGetBuf.out2() eq 0`
    - calls `PlayerDataManager$$UpdateServerHP`, `PlayerDataManager$$UpdateServerMp`, `PlayerDataManager$$get_SkillBufferManager`, `0x165db84`, `0x165df00`, `0x165df00`
  - always
    - returns `SkillBufferManager.RemoveSelfBuffer(PlayerDataManager.get_SkillBufferManager(this, ?x1, ?x2, ?x3), 657, 0, ?x3)`
    - calls `PlayerDataManager$$UpdateServerHP`, `PlayerDataManager$$UpdateServerMp`, `PlayerDataManager$$get_SkillBufferManager`, `PlayerDataManager$$get_SkillBufferManager`, `SkillBufferManager$$RemoveSelfBuffer`
- Effect applied in `MobaPlayerActionManager$$SupportReserve` (70 guarded paths):
  - when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
    - returns `UI3DLabelManager.SetSkillMissPopUp(Singleton<object>.get_Instance(meta(0x3974690, Method$Singleton<UI3DLabelManager>.get_Instance()), ?x1, ?x2, ?x3), GetAvailableSkill.out4(), 0, ?x3)`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `Singleton<object>$$get_Instance`, `UI3DLabelManager$$SetSkillMissPopUp`
  - when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `0x165df00`
  - when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
    - returns `UI3DLabelManager.SetSkillMissPopUp(Singleton<object>.get_Instance(meta(0x3974690, Method$Singleton<UI3DLabelManager>.get_Instance()), ?x1, ?x2, ?x3), 3, 0, ?x3)`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `PlayerStatusBase$$GetEquipSkill`, `SkillComboManager$$CheckCombo`, `SkillComboState$$TemporaryUseSkill`, `AbnormalStateManager$$Contains`
  - when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
    - returns `GameManager.StartSupportSkill(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), target, (GetAvailableSkill.out4() eq 6 ? 0 : SkillManager.GetAvailableSkill(CharacterActionManagerBase.get_IsDeadOrLocalDead(), this, 0, ([TryGetBuf.out2()+0x50] eq 0 ? 657 : 654))), 0)`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `PlayerStatusBase$$GetEquipSkill`, `SkillComboManager$$CheckCombo`, `SkillComboState$$TemporaryUseSkill`, `AbnormalStateManager$$Contains`
  - when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
    - returns `MobaPlayerActionManager.SkillReserveMpLess(this, (GetAvailableSkill.out4() eq 6 ? 0 : SkillManager.GetAvailableSkill(CharacterActionManagerBase.get_IsDeadOrLocalDead(), this, 0, ([TryGetBuf.out2()+0x50] eq 0 ? 657 : 654))), stkp(-72), ?x3)`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `PlayerStatusBase$$GetEquipSkill`, `SkillComboManager$$CheckCombo`, `SkillComboState$$TemporaryUseSkill`, `AbnormalStateManager$$Contains`
  - when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
    - returns `BattleManagerBase.SupportReserve(battleManager, target, (GetAvailableSkill.out4() eq 6 ? 0 : SkillManager.GetAvailableSkill(CharacterActionManagerBase.get_IsDeadOrLocalDead(), this, 0, ([TryGetBuf.out2()+0x50] eq 0 ? 657 : 654))), (([TryGetBuf.out2()+0x50] eq 0 ? 657 : 654) ne 0 ? 1 : 0))`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `PlayerStatusBase$$GetEquipSkill`, `SkillComboManager$$CheckCombo`, `SkillComboState$$TemporaryUseSkill`, `AbnormalStateManager$$Contains`
  - when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
    - returns `BattleManagerBase.SupportReserve(battleManager, target, (GetAvailableSkill.out4() eq 6 ? 0 : SkillManager.GetAvailableSkill(CharacterActionManagerBase.get_IsDeadOrLocalDead(), this, 0, ([TryGetBuf.out2()+0x50] eq 0 ? 657 : 654))), (([TryGetBuf.out2()+0x50] eq 0 ? 657 : 654) ne 0 ? 1 : 0))`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `PlayerStatusBase$$GetEquipSkill`, `SkillComboManager$$CheckCombo`, `SkillComboState$$TemporaryUseSkill`, `AbnormalStateManager$$Contains`
  - when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `SkillLv(657) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 654, stkp(-88), 0) & 1) ne 0`
    - returns `UI3DLabelManager.SetSkillMissPopUp(Singleton<object>.get_Instance(meta(0x3974690, Method$Singleton<UI3DLabelManager>.get_Instance()), ?x1, ?x2, ?x3), 3, 0, ?x3)`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `PlayerStatusBase$$GetEquipSkill`, `SkillComboManager$$CheckCombo`, `AbnormalStateManager$$Contains`, `Singleton<object>$$get_Instance`
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
- Code that reads this skill's level / buff by constant id: `ArkSaber$$CalcConstantDamage (TryGetBuf)`, `ArkSaberAction$$ConverterArkSaberSkillId (GetSkillLv)`, `MobAttackBase$$CalcLastDamage (TryGetBuf)`, `MobaPlayerActionManager$$SupportReserve (GetSkillLv)`, `MobaPlayerSecondaryStatus$$GetCrtConstant (TryGetBuf)`, `PlayerAttackBase$$CalcCostMp (ContainsBuffer)`, `PlayerAttackBase$$RemoveAfterSkillBuf (ContainsBuffer)`, `PlayerDataManager$$OnSkillBuffEnd (TryGetBuf)`, `PlayerSecondaryStatus$$GetCrtConstant (TryGetBuf)`, `SaberAuraAction$$ActionHit (TryGetBuf)`, `UIActiveBaseShortcutButton$$SkillButton (GetSkillLv)`, `UIGLShortcutButton$$LabelUpdate (GetSkillLv)`, `UIShortcutListButton$$OnSkillCostCheck (ContainsBuffer)`, `UIShortcutListButton$$OnSkillCostCheck (GetSkillLv)`, `UIShortcutListButton$$SetSkillButton (GetSkillLv)`

_Raw recovered data (every method item): [trees/DualSword.md](../trees/DualSword.md) — uid 657_

---

### แอร์สไลเซอร์ (AirSlicer) · uid 658

<img src="../../icons/sk_658.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 5) · **Type:** Attack · **Max Lv:** 250 · **Weapons:** TwinSword · **Requires:** สปินนิ่งสแลช · **Client class:** `AirSlicerAction`

> เทคนิคปลดปล่อยคมดาบแห่งสายลม
> ธาตุคู่(ดาบมือเดียว)ถ้ากำลังเปิดใช้สปินนิ่งสแลชที่เท้า
> เมื่อกดปุ่มเคลื่อนที่ไปข้างหน้าจะใช้อีก 200MP เพื่อเพิ่มการโจมอันทรงพลัง

**How it works**

- Attack skill of the デュアルスキル tree (tier 5, max Lv 250); usable with TwinSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- Damage (`CalcFirstDamage` x1, `CalcSecondDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [CalcFirstDamage]: skill multiplier depends on live values (formula below); flat damage depends on live values (formula below)
  - `calcPlayerToMobDamage` [CalcSecondDamage]: skill multiplier depends on live values (formula below); skill multiplier depends on live values (formula below); flat damage +20 at Lv1 to 200 at Lv10; extra crit multiplier depends on live values (formula below)
- Proration: slot chosen at runtime (physical or magic by a per-cast flag), mode `every_hit + class check`.
- Can inflict on the target: Blindness (7).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 9 set
- `ActionPreparation` — before the cast starts: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 3 call
- `CalcFirstDamage` — skill-specific method: 2 tpl, 1 info
- `CalcSecondDamage` — skill-specific method: 1 set, 3 tpl, 1 info
- `ActionSkillEvent` — on an animation/skill event during the motion: 1 set
- `ExpDefFluctuated` — skill-specific method: 1 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `OtherPlayerSkillEventReceive` — skill-specific method: 1 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 20 | 40 | 60 | 80 | 100 | 120 | 140 | 160 | 180 | 200 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((((((gemCart(210[4]) + ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) << 1) + 30)) + ((gemCart(210[4]) + ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) << 1) + 30)) << 1)) + (gemCart(210[4]) + (int((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) * 2.5)) + 125))) + ((baseDEX // 10) * Lv))) / 100)` — CalcFirstDamage
- SkillRate × `((max((((baseSTR) * (((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 2) lt 100 ? (100 - ((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 2)) : 0)) / 100), 0) + (((Lv * 100) + 500))) / 100)` — CalcSecondDamage
- SkillRate × `((max((((baseSTR) * (((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 2) lt 100 ? (100 - ((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 2)) : 0)) / 100), 0) + (((Lv * 100) + 500))) / 100)` — CalcSecondDamage
- Flat dmg + `(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) << 2)) + 50))` — CalcFirstDamage
- Crit mult + `(max((((((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) << 2)) + 50) lt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) << 2)) + 51) : ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) << 2)) + 50)) >> 1)) << (AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 7) & 1)) - (((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 1) lt 50 ? ((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 1) : 50)), 0) / 100)` — CalcSecondDamage

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `CalcFirstDamage` (method): `AddRate[SkillRate]` = `((((((gemCart(210[4]) + ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) << 1) + 30)) + ((gemCart(210[4]) + ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) << 1) + 30)) << 1)) + (gemCart(210[4]) + (int((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) * 2.5)) + 125))) + ((baseDEX // 10) * Lv))) / 100)`
- `CalcFirstDamage` (method): `AddConstant[SkillConstantDamage]` = `(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) << 2)) + 50))`
- `CalcSecondDamage` (method): `AddRate[SkillRate]` = `((max((((baseSTR) * (((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 2) lt 100 ? (100 - ((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 2)) : 0)) / 100), 0) + (((Lv * 100) + 500))) / 100)`
- `CalcSecondDamage` (method): `AddConstant[SkillConstantDamage]` = `(((Lv + (Lv << 2)) << 2))`
- `CalcSecondDamage` (method): `AddRate[CriticalRate]` = `(max((((((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) << 2)) + 50) lt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) << 2)) + 51) : ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 642, 1) << 2)) + 50)) >> 1)) << (AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 7) & 1)) - (((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 1) lt 50 ? ((max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) + (max((int(MathUtil.DistanceToDisplayMeter(startTargetDist)) - 7), 0) << 2)) << 1) : 50)), 0) / 100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `dynamic`, mode `every_hit + class check`, attack type `Physics`, action id 658
- Uses the slot chosen at runtime (physical or magic by a per-cast flag); Proration changes on EVERY damaging hit (bypasses the first-hit gate).

**Status ailments**

- Rolls `percent`% to inflict **Blindness (7)** (`calcPlayerToMobDamage`)
- Marks the hit with ailment **Blindness (7)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 7, percent, playerAction)`

**Buffs and effects it installs or removes**

- `calcPlayerToMobDamage` (damage calculation against a monster): chains one more damage event — `CreateNextDamage()`
  - when `MaxFirstAttackCount lt 2 OR 2 ge MaxFirstAttackCount AND MaxFirstAttackCount ge 2 OR 2 ge MaxFirstAttackCount AND 2 lt MaxFirstAttackCount AND MaxFirstAttackCount ge 2`

**Other recovered parameters**

- **First-part skill multiplier (%)** (`firstSkillRate`): `((((gemCart(210[4]) + ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) << 1) + 30)) + ((gemCart(210[4]) + ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) << 1) + 30)) << 1)) + (gemCart(210[4]) + (int((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) * 2.5)) + 125))) + ((baseDEX // 10) * Lv))`
- **Effect percent** (`percent`): `(int((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) * 2.5)) + 15)`
- **First-part flat damage** (`firstFixAddDamage`): `((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 646, 1) << 2)) + 50)`
- **Second-part multiplier** (`secondSkillRate`): `((Lv * 100) + 500)` → Lv1..10 [600, 700, 800, 900, 1000, 1100, 1200, 1300, 1400, 1500]
- **Second-part flat damage** (`secondFixAddDamage`): `((Lv + (Lv << 2)) << 2)` → Lv1..10 [20, 40, 60, 80, 100, 120, 140, 160, 180, 200]

**In-game level notes**

- Lv10: *พลังของแอร์สไลเซอร์ขึ้นอยู่กับเลเวลของสปินนิ่งสแลชที่มี  *การโจมตีเพิ่มเติมจะถูกเสริมด้วยความเสียหายคริติคอลของทวินสแลชที่เรียนรู้ และจะเพิ่มขึ้นอีกเมื่อเป้าหมายอยู่ในสภาวะมืดบอด แต่ยิ่งห่าง (ตั้งแต่ 8 เมตรขึ้นไป) ค่าที่ได้ก็จะยิ่งน้อยลง

_Raw recovered data (every method item): [trees/DualSword.md](../trees/DualSword.md) — uid 658_

---

### ฮอร์ริซอนคัท (HorizontalCut) · uid 660

<img src="../../icons/sk_660.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 5) · **Type:** Attack · **Max Lv:** 250 · **Weapons:** OneHandSword, TwinSword · **Requires:** เอเลียสลีย์ · **Client class:** `HorizontalCutAction`

> ฟันกลับอย่างรวดเร็วแบบไม่ให้ศัตรูได้ตั้งตัว
> ลด MP ที่ใช้ของสกิลถัดไปลงครึ่งหนึ่ง
> ถ้าใช้เป็นสกิลเริ่มต้นของคอมโบต้องใช้ 300 MP
> ถ้าใช้งานที่จุดสิ้นสุดของคอมโบ MP ที่จำเป็นจะกลายเป็น 0
> ระหว่างใช้สกิลหากถูกโจมตีจะล้มคว่ำ

**How it works**

- Attack skill of the デュアルスキル tree (tier 5, max Lv 250); usable with OneHandSword, TwinSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- MP: `(combo.index eq (SkillComboLine.get_Count(combo.comboLine) - 1) ? 0 : 300)`.
- Damage (`calcFirstDamage` x1, `calcSecondDamage` x1; each template is a full damage roll with its own crit):
  - `calcFirstDamage` [!UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR !SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0) eq 0 AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword]: skill multiplier depends on Dex (formula below); flat damage +30 at Lv1 to 300 at Lv10
  - `calcFirstDamage` [isDualSword ne 0 AND subWeapon != OneHandSword OR isDualSword eq 0 AND subWeapon != OneHandSword]: skill multiplier depends on Dex (formula below); flat damage +60 at Lv1 to 600 at Lv10
  - `calcSecondDamage`: skill multiplier depends on live values (formula below); flat damage +30 at Lv1 to 300 at Lv10
- Proration: physical-skill proration slot, mode `never (IsExpDefFluctuate=false)`.
- If the caster is hit while the action / buff is active, the `Damaged` hook changes the caster's ailment state (details below).
- Buffs:
  - `HorizontalCutBuf`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **MP cost** (`baseMp` in `ChangeMpDuringCombo`): `(combo.index eq (SkillComboLine.get_Count(combo.comboLine) - 1) ? 0 : 300)`
  - when `combo.index eq (SkillComboLine.get_Count(combo.comboLine) - 1) OR combo.index eq 0 AND combo.index ne (SkillComboLine.get_Count(combo.comboLine) - 1)`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(14)`
  - when `SkillActionBase.CheckRangeHit(UnityEngine.Component.get_transform(actarAction), UnityEngine.Component.get_transform(actarAction), 0.1) AND SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0) ne 0 AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword`
- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
  - when `!UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR isDualSword ne 0 AND subWeapon != OneHandSword OR isDualSword eq 0 AND subWeapon != OneHandSword`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 12 set
- `InitializeOthers` — setup used when another player's client replays the action: 3 set
- `ChangeMpDuringCombo` — MP cost adjustment while inside a combo chain: 1 set
- `ActionStart` — when the cast starts: 1 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set
- `calcFirstDamage` — damage calculation of hit 1: 2 tpl, 1 info
- `calcSecondDamage` — damage calculation of hit 2: 2 tpl, 1 info
- `Damaged` — when the caster takes damage while the action / buff is active: 3 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + [calcFirstDamage !UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR !SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0) eq 0 AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword] | 30 | 60 | 90 | 120 | 150 | 180 | 210 | 240 | 270 | 300 |
| Flat dmg + [calcFirstDamage isDualSword ne 0 AND subWeapon != OneHandSword OR isDualSword eq 0 AND subWeapon != OneHandSword] | 60 | 120 | 180 | 240 | 300 | 360 | 420 | 480 | 540 | 600 |
| Flat dmg + [calcSecondDamage] | 30 | 60 | 90 | 120 | 150 | 180 | 210 | 240 | 270 | 300 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((((Lv * 10) + status.Dex) + 900) lt 0 ? ((((Lv * 10) + status.Dex) + 900) + 1) : (((Lv * 10) + status.Dex) + 900)) >> 1)) / 100)` — calcFirstDamage !UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR !SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0) eq 0 AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword
- SkillRate × `(((((((Lv * 10) + status.Dex) + 900) lt 0 ? ((((Lv * 10) + status.Dex) + 900) + 1) : (((Lv * 10) + status.Dex) + 900)) >> 1)) / 100)` — calcFirstDamage isDualSword ne 0 AND subWeapon != OneHandSword OR isDualSword eq 0 AND subWeapon != OneHandSword
- SkillRate × `((((Lv * 50) + (((baseSTR gt baseAGI ? baseSTR : baseAGI) lt 0 ? ((baseSTR gt baseAGI ? baseSTR : baseAGI) + 1) : (baseSTR gt baseAGI ? baseSTR : baseAGI)) >> 1))) / 100)` — calcSecondDamage

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcFirstDamage` (damage calculation of hit 1): `AddRate[SkillRate]` = `(((((((Lv * 10) + status.Dex) + 900) lt 0 ? ((((Lv * 10) + status.Dex) + 900) + 1) : (((Lv * 10) + status.Dex) + 900)) >> 1)) / 100)`
- `calcFirstDamage` (damage calculation of hit 1): `AddConstant[SkillConstantDamage]` = `(((Lv * 60) >> 1))`
- `calcSecondDamage` (damage calculation of hit 2): `AddRate[SkillRate]` = `((((Lv * 50) + (((baseSTR gt baseAGI ? baseSTR : baseAGI) lt 0 ? ((baseSTR gt baseAGI ? baseSTR : baseAGI) + 1) : (baseSTR gt baseAGI ? baseSTR : baseAGI)) >> 1))) / 100)`
- `calcSecondDamage` (damage calculation of hit 2): `AddConstant[SkillConstantDamage]` = `((Lv * 30))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `never (IsExpDefFluctuate=false)`, attack type `Physics`, action id 660
- Uses the physical-skill proration slot but never changes monster proration: IsExpDefFluctuate=false.

**Status ailments**

- Uses the default ailment duration (`Damaged`, the caster is the one hit)
  - when `!CharacterActionManagerBase.AddAbnormalState(actor, 2, AbnormalStateManager.GetDefaultAnbormalStateTime(2), 0, 0, 0, 1) AND !SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) AND !SkillActionBase.op_Inequality(action) AND (damageData.AbnormalType - 1) hs 4 AND SkillActionBase.get_ActionID() eq 660 AND damageData.AbnormalType ne 43 OR !CharacterActionManagerBase.AddAbnormalState(actor, 2, AbnormalStateManager.GetDefaultAnbormalStateTime(2), 0, 0, 0, 1) AND !SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) AND (damageData.AbnormalType - 1) hs 4 AND IsInstanceOf(action, MobEventScriptAttack) ne 1 AND SkillActionBase.get_ActionID() eq 660 AND SkillActionBase.op_Inequality(action) AND damageData.AbnormalType ne 43 OR !CharacterActionManagerBase.AddAbnormalState(actor, 2, AbnormalStateManager.GetDefaultAnbormalStateTime(2), 0, 0, 0, 1) AND !SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) AND (damageData.AbnormalType - 1) hs 4 AND IsInstanceOf(action, MobEventScriptAttack) eq 1 AND SkillActionBase.get_ActionID() eq 660 AND SkillActionBase.op_Inequality(action) AND damageData.AbnormalType ne 43`
- Extra percent roll `CheckPercent` (`Damaged`, the caster is the one hit)
  - when `!SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) AND !SkillActionBase.op_Inequality(action) AND (!MathUtil.CheckPercent(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) << 2)) << 1)) | hasBuff(CrtDamageUp)) AND (damageData.AbnormalType - 1) hs 4 AND CharacterActionManagerBase.AddAbnormalState(actor, 2, AbnormalStateManager.GetDefaultAnbormalStateTime(2), 0, 0, 0, 1) AND SkillActionBase.get_ActionID() eq 660 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) ge 1 AND damageData.AbnormalType ne 43 AND hasGemCart(401) OR !SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) AND !SkillActionBase.op_Inequality(action) AND (MathUtil.CheckPercent(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) << 2)) << 1)) | hasBuff(CrtDamageUp)) AND (damageData.AbnormalType - 1) hs 4 AND CharacterActionManagerBase.AddAbnormalState(actor, 2, AbnormalStateManager.GetDefaultAnbormalStateTime(2), 0, 0, 0, 1) AND SkillActionBase.get_ActionID() eq 660 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) ge 1 AND damageData.AbnormalType ne 43 AND hasGemCart(401) OR !SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) AND (!MathUtil.CheckPercent(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) << 2)) << 1)) | hasBuff(CrtDamageUp)) AND (damageData.AbnormalType - 1) hs 4 AND CharacterActionManagerBase.AddAbnormalState(actor, 2, AbnormalStateManager.GetDefaultAnbormalStateTime(2), 0, 0, 0, 1) AND IsInstanceOf(action, MobEventScriptAttack) ne 1 AND SkillActionBase.get_ActionID() eq 660 AND SkillActionBase.op_Inequality(action) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) ge 1 AND damageData.AbnormalType ne 43 AND hasGemCart(401)`

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): adds the caster's buff of skill 660 (HorizontalCut) — `AddSelfBuffer(660, Lv, Id)`
  - when `!PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction)`
- `Damaged` (when the caster takes damage while the action / buff is active): removes the caster's buff of skill 41 (Rampage) — `RemoveSelfBuffer(41)`
  - when `!SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) AND !SkillActionBase.op_Inequality(action) AND !hasGemCart(401) AND ((0 | hasBuff(CrtDamageUp)) & 1) eq 0 AND (damageData.AbnormalType - 1) hs 4 AND CharacterActionManagerBase.AddAbnormalState(actor, 2, AbnormalStateManager.GetDefaultAnbormalStateTime(2), 0, 0, 0, 1) AND SkillActionBase.get_ActionID() eq 660 AND damageData.AbnormalType ne 43 OR !SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) AND !hasGemCart(401) AND ((0 | hasBuff(CrtDamageUp)) & 1) eq 0 AND (damageData.AbnormalType - 1) hs 4 AND CharacterActionManagerBase.AddAbnormalState(actor, 2, AbnormalStateManager.GetDefaultAnbormalStateTime(2), 0, 0, 0, 1) AND IsInstanceOf(action, MobEventScriptAttack) ne 1 AND SkillActionBase.get_ActionID() eq 660 AND SkillActionBase.op_Inequality(action) AND damageData.AbnormalType ne 43 OR !SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) AND !hasGemCart(401) AND ((0 | hasBuff(CrtDamageUp)) & 1) eq 0 AND (damageData.AbnormalType - 1) hs 4 AND CharacterActionManagerBase.AddAbnormalState(actor, 2, AbnormalStateManager.GetDefaultAnbormalStateTime(2), 0, 0, 0, 1) AND IsInstanceOf(action, MobEventScriptAttack) eq 1 AND SkillActionBase.get_ActionID() eq 660 AND SkillActionBase.op_Inequality(action) AND damageData.AbnormalType ne 43`

**Other recovered parameters**

- **Second-part multiplier** (`secondSkillRate`): `((Lv * 50) + (((baseSTR gt baseAGI ? baseSTR : baseAGI) lt 0 ? ((baseSTR gt baseAGI ? baseSTR : baseAGI) + 1) : (baseSTR gt baseAGI ? baseSTR : baseAGI)) >> 1))` _(when !UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR !SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword OR SkillActionBase.op_Inequality(System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0), 0) AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase>(SkillActionManager.get_PlaceSkilList(actarAction.battleManager.skillActManager), HorizontalCutAction.<>c.<>9__28_0) eq 0 AND UnityEngine.Object.op_Inequality(actarAction.battleManager.skillActManager) AND subWeapon == OneHandSword)_
- **Base MP cost** (`baseMp`): `(combo.index eq (SkillComboLine.get_Count(combo.comboLine) - 1) ? 0 : 300)` _(when combo.index eq (SkillComboLine.get_Count(combo.comboLine) - 1) OR combo.index eq 0 AND combo.index ne (SkillComboLine.get_Count(combo.comboLine) - 1))_

**Buff values** (every recovered field; durations in seconds)

**Buff `HorizontalCutBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).

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
- Code that reads this skill's level / buff by constant id: `PlayerAttackBase$$RemoveAfterSkillBuf (ContainsBuffer)`

_Raw recovered data (every method item): [trees/DualSword.md](../trees/DualSword.md) — uid 660_

---

### เบลดสตริงเกอร์ (BladeStinger) · uid 661

<img src="../../icons/sk_661.png" width="40" alt="icon"> 
**Tree:** デュアルスキル (`DualSword`, tier 5) · **Type:** Attack · **Max Lv:** 250 · **Weapons:** OneHandSword, TwinSword · **Requires:** เอเลียสลีย์ · **Client class:** `BladeStingerAction`

> พุ่งตรงเข้าไปแทงอย่างรวดเร็ว
> ถ้าไม่ Graze จะทำให้พลังเจาะเข้าพิ่มขึ้น
> พลังโจมตีเพิ่มขึ้นอีกตามพลังเจาะเข้าที่เกินค่าสูงสุด

**How it works**

- Attack skill of the デュアルスキル tree (tier 5, max Lv 250); usable with OneHandSword, TwinSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [subWeapon == OneHandSword & !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10]: skill multiplier ×3.4 at Lv1 to 7 at Lv10
  - `calcPlayerToMobDamage` [subWeapon == OneHandSword & SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10]: skill multiplier ×3.4 at Lv1 to 7 at Lv10
  - `calcPlayerToMobDamage` [subWeapon == OneHandSword & ((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + physicsResistBreaker) ge 101 AND UnityEngine.Object.op_Inequality(actarAction) & !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [subWeapon != OneHandSword & !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [subWeapon != OneHandSword & ((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + physicsResistBreaker) ge 101 AND UnityEngine.Object.op_Inequality(actarAction) & !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10]: skill multiplier depends on Agi (formula below)
  - `calcPlayerToMobDamage` [((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + physicsResistBreaker) ge 101 AND UnityEngine.Object.op_Inequality(actarAction) & !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10]: skill multiplier depends on Agi (formula below)
  - `calcPlayerToMobDamage` [subWeapon != OneHandSword & SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10]: skill multiplier depends on live values (formula below)
  - ... and 2 more variants (see the tables below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(24)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 8 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionPreparation` — before the cast starts: 1 set
- `ActionSkillEvent` — on an animation/skill event during the motion: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 6 tpl, 2 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [subWeapon == OneHandSword & !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10] | 3.4 | 3.8 | 4.2 | 4.6 | 5 | 5.4 | 5.8 | 6.2 | 6.6 | 7 |
| SkillRate × [subWeapon == OneHandSword & SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10] | 3.4 | 3.8 | 4.2 | 4.6 | 5 | 5.4 | 5.8 | 6.2 | 6.6 | 7 |
| Flat dmg + | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((0) + (((Lv * 40) + 300))) / 100)` — subWeapon == OneHandSword & ((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + physicsResistBreaker) ge 101 AND UnityEngine.Object.op_Inequality(actarAction) & !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10
- SkillRate × `(((0) + (((Lv * 40) + 300))) / 100)` — subWeapon != OneHandSword & !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10
- SkillRate × `(((0) + (((Lv * 40) + 300))) / 100)` — subWeapon != OneHandSword & ((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + physicsResistBreaker) ge 101 AND UnityEngine.Object.op_Inequality(actarAction) & !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10
- SkillRate × `(((0) + ((status.Agi + 300))) / 100)` — !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10
- SkillRate × `(((0) + ((status.Agi + 300))) / 100)` — ((buffParam(PowerResistBreaker) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 51)) + physicsResistBreaker) ge 101 AND UnityEngine.Object.op_Inequality(actarAction) & !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10
- SkillRate × `((((Lv * 40) + 300)) / 100)` — subWeapon != OneHandSword & SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10
- SkillRate × `(((status.Agi + 300)) / 100)` — SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `SetConstant[Def]` = `-PlayerAttackBase.CalcRegistDamage(this, 1, PlayerActionManagerBase.get_PlayerStatus(), MobActionManagerBase.get_MobBattleStatus(mobAction))`
  - when `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((0) + (((Lv * 40) + 300))) / 100)`
  - when `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(100)`
  - when `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10 OR SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((0) + ((status.Agi + 300))) / 100)`
  - when `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv * 40) + 300)) / 100)`
  - when `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10 OR SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType ne 10`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((status.Agi + 300)) / 100)`
  - when `SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 4) AND SubWeaponType eq 10`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 661
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Other recovered parameters**

- **Physical pierce %** (`physicsResistBreaker`): `((Lv << 2) + 10)` → Lv1..10 [14, 18, 22, 26, 30, 34, 38, 42, 46, 50]

_Raw recovered data (every method item): [trees/DualSword.md](../trees/DualSword.md) — uid 661_

---
