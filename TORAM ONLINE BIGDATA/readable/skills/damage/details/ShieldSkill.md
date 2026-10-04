# シールドスキル (`ShieldSkill`) — skill details

14 entries.

### ชีลด์มาสเตอรี่ (ShieldMastary) · uid 257

<img src="../../icons/sk_257.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 5 · **Weapons:** Shield · **Flags:** StarGem · **Client class:** `ShieldMastary` (passive mastery)

> อัพเกรดความเร็วการโจมตีเมื่อติดตั้งโล่

**How it works**

- Mastery skill of the シールドスキル tree (tier 1, max Lv 5); usable with Shield.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): AspdRate (attack speed %) 5 at Lv1 to 50 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| AspdRate | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |


Bonus meanings (inferred from the names):

- `AspdRate`: attack speed %

_Raw recovered data (every method item): [trees/ShieldSkill.md](../trees/ShieldSkill.md) — uid 257_

---

### โพรเทคชั่น (Protection) · uid 263

<img src="../../icons/sk_263.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 1) · **Type:** Support · **Max Lv:** 5 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `ProtectionAction`

> เพิ่มความต้านทานทางกายภาพให้สมาชิกปาร์ตี้ชั่วขณะ
> แต่การต้านทานเวทจะลดลง

**How it works**

- Support skill of the シールドスキル tree (tier 1, max Lv 5); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It installs a buff on other players / the party.
- MP: `(mp - 200)`.
- Buffs:
  - `AegisBuf`: lasts `(Lv * 60)` s; Lv1 → Lv10: MagicDmgCut (magic damage taken reduction) 10 → 25, PowerDmgCut (physical damage taken reduction) -35 → -20
  - `ProtectionBuf`: lasts `(Lv * 60)` s; Lv1 → Lv10: PowerDmgCut (physical damage taken reduction) 10 → 25, MagicDmgCut (magic damage taken reduction) -35 → -20
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **MP cost** (`mp` in `OnInitialize`): `(mp - 200)`
  - when `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 AND UnityEngine.Object.op_Inequality(actarAction)`
- **Cast time** (`CastTime`): `SkillUtil.CalcCastTime(0, PlayerStatusBase.get_BattleStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 4 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 263
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `ProtectionBuf` — `.ctor(Lv)`
  - when `!hasGemCart(1036) OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 264, 1) ge 1 AND hasGemCart(1036) OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 264, 1) lt 1 AND hasGemCart(1036)`
- `ActionHit` (when the attack connects): adds a target's buff of `new ProtectionBuf` — `AddBuffer(new ProtectionBuf, 0)`
  - when `!hasGemCart(1036) OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 264, 1) ge 1 AND hasGemCart(1036) OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 264, 1) lt 1 AND hasGemCart(1036)`
- `ActionHit` (when the attack connects): constructs `AegisBuf` — `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 264, 1))`
  - when `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 264, 1) ge 1 AND hasGemCart(1036)`
- `ActionHit` (when the attack connects): adds a target's buff of `new AegisBuf` — `AddBuffer(new AegisBuf, 0)`
  - when `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 264, 1) ge 1 AND hasGemCart(1036)`

**Other recovered parameters**

- **MP cost** (`mp`): `(mp - 200)` _(when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 AND UnityEngine.Object.op_Inequality(actarAction))_
- **Cast time modifier** (`CastTime`): `SkillUtil.CalcCastTime(0, PlayerStatusBase.get_BattleStatus())`

**Buff values** (every recovered field; durations in seconds)

**Buff `AegisBuf`**
- Duration: `(Lv * 60)` s

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MagicDmgCut | 10 | 10 | 15 | 15 | 15 | 20 | 20 | 20 | 25 | 25 |
| PowerDmgCut | -35 | -35 | -30 | -30 | -30 | -25 | -25 | -25 | -20 | -20 |

- Buff fields set in the constructor (all recovered):
  - `isViewSelfIcon` = `IsSelfAction`
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `SetViewSelfIcon`: `isViewSelfIcon`=(flag & 1)
**Buff `ProtectionBuf`**
- Duration: `(Lv * 60)` s

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| PowerDmgCut | 10 | 10 | 15 | 15 | 15 | 20 | 20 | 20 | 25 | 25 |
| MagicDmgCut | -35 | -35 | -30 | -30 | -30 | -25 | -25 | -25 | -20 | -20 |

- Buff fields set in the constructor (all recovered):
  - `IsSelfAction` = `1` = 1
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5]
  - `BuffEffectActive` = `257` = 257
  - `BufEffectTakeUid` = `-1` = -1
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
- Hook `SetViewSelfIcon`: `isViewSelfIcon`=(flag & 1)
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:AegisBuf$$.ctor<-ProtectionAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

Parameter meanings (inferred from the `SkillBufferId` names):

- `MagicDmgCut`: magic damage taken reduction
- `PowerDmgCut`: physical damage taken reduction

**In-game level notes**

- Lv17: *MP ที่ใช้-200

**Where else this skill takes effect**

- Effect applied in `AegisAction$$ActionHit` (2 guarded paths):
  - when `SkillLv(263) ge 1`
    - calls `0x165db78`, `AegisBuf$$.ctor`, `SkillBufferManager$$AddBuffer`, `0x165db78`, `ProtectionBuf$$.ctor`, `SkillBufferManager$$AddBuffer`
  - when `SkillLv(263) lt 1`
    - returns `SkillLv(263)`
    - calls `0x165db78`, `AegisBuf$$.ctor`, `SkillBufferManager$$AddBuffer`
- Code that reads this skill's level / buff by constant id: `AegisAction$$ActionHit (GetSkillLv)`

_Raw recovered data (every method item): [trees/ShieldSkill.md](../trees/ShieldSkill.md) — uid 263_

---

### ชีลด์บาช (ShieldBash) · uid 258

<img src="../../icons/sk_258.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 2) · **Type:** Attack · **Max Lv:** 20 · **Weapons:** Shield · **Requires:** ชีลด์มาสเตอรี่ · **Flags:** MercenaryCanUseSkill · **Client class:** `ShieldBashAction`

> อัดด้วยโล่เต็มแรง
> มีโอกาสทำให้เป้าหมาย[หมดสติ]

**How it works**

- Attack skill of the シールドスキル tree (tier 2, max Lv 20); usable with Shield.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×0.01 at Lv1 to 0.15 at Lv10; flat damage +55 at Lv1 to 100 at Lv10
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Stun (3).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(3)`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 2 tpl, 2 call, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.01 | 0.03 | 0.04 | 0.06 | 0.07 | 0.09 | 0.1 | 0.12 | 0.13 | 0.15 |
| Flat dmg + | 55 | 60 | 65 | 70 | 75 | 80 | 85 | 90 | 95 | 100 |

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((int((Lv * 1.5)) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv + (Lv << 2)) + 50))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 258
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Chance field `stunPercent` (Stun chance (%)): `(int((Lv * 2.5)) + 75)` → Lv1..10 [77, 80, 82, 85, 87, 90, 92, 95, 97, 100]
- Rolls `stunPercent`% to inflict **Stun (3)** (`calcPlayerToMobDamage`)
- Marks the hit with ailment **Stun (3)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)`

_Raw recovered data (every method item): [trees/ShieldSkill.md](../trees/ShieldSkill.md) — uid 258_

---

### ฟอร์ชชีลด์ (ForceShield) · uid 259

<img src="../../icons/sk_259.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 20 · **Weapons:** Shield · **Requires:** ชีลด์มาสเตอรี่ · **Client class:** `ForceShield` (passive mastery)

> เพิ่ม DEF และการต้านทานอาวุธ
> เมื่อติดตั้งโล่

**How it works**

- Mastery skill of the シールドスキル tree (tier 2, max Lv 20); usable with Shield.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Def (DEF) 6 at Lv1 to 20 at Lv10, MaxHp (max HP) 50 at Lv1 to 500 at Lv10, CutDmgRate (damage taken reduction %) 1 at Lv1 to 10 at Lv10, DefRate (DEF %) 1 at Lv1 to 10 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Def | 6 | 8 | 9 | 11 | 12 | 14 | 15 | 17 | 18 | 20 |
| MaxHp | 50 | 100 | 150 | 200 | 250 | 300 | 350 | 400 | 450 | 500 |
| CutDmgRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| DefRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


Bonus meanings (inferred from the names):

- `Def`: DEF
- `MaxHp`: max HP
- `CutDmgRate`: damage taken reduction %
- `DefRate`: DEF %

_Raw recovered data (every method item): [trees/ShieldSkill.md](../trees/ShieldSkill.md) — uid 259_

---

### อีจิส (Aegis) · uid 264

<img src="../../icons/sk_264.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 2) · **Type:** Support · **Max Lv:** 20 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** โพรเทคชั่น · **Flags:** MercenaryCanUseSkill · **Client class:** `AegisAction`

> เพิ่มการต้านทานเวทให้สมาชิกปาร์ตี้ชั่วขณะ
> แต่ความต้านทานทางกายภาพจะลดลง

**How it works**

- Support skill of the シールドスキル tree (tier 2, max Lv 20); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It installs a buff on other players / the party.
- MP: `(mp - 200)`.
- Buffs:
  - `AegisBuf`: lasts `(Lv * 60)` s; Lv1 → Lv10: MagicDmgCut (magic damage taken reduction) 10 → 25, PowerDmgCut (physical damage taken reduction) -35 → -20
  - `ProtectionBuf`: lasts `(Lv * 60)` s; Lv1 → Lv10: PowerDmgCut (physical damage taken reduction) 10 → 25, MagicDmgCut (magic damage taken reduction) -35 → -20
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **MP cost** (`mp` in `OnInitialize`): `(mp - 200)`
  - when `EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 AND UnityEngine.Object.op_Inequality(actarAction)`
- **Cast time** (`CastTime`): `SkillUtil.CalcCastTime(0, PlayerStatusBase.get_BattleStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 4 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 264
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `AegisBuf` — `.ctor(Lv)`
  - when `!hasGemCart(1036) OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 263, 1) ge 1 AND hasGemCart(1036) OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 263, 1) lt 1 AND hasGemCart(1036)`
- `ActionHit` (when the attack connects): adds a target's buff of `new AegisBuf` — `AddBuffer(new AegisBuf, 0)`
  - when `!hasGemCart(1036) OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 263, 1) ge 1 AND hasGemCart(1036) OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 263, 1) lt 1 AND hasGemCart(1036)`
- `ActionHit` (when the attack connects): constructs `ProtectionBuf` — `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 263, 1))`
  - when `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 263, 1) ge 1 AND hasGemCart(1036)`
- `ActionHit` (when the attack connects): adds a target's buff of `new ProtectionBuf` — `AddBuffer(new ProtectionBuf, 0)`
  - when `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 263, 1) ge 1 AND hasGemCart(1036)`

**Other recovered parameters**

- **MP cost** (`mp`): `(mp - 200)` _(when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 AND UnityEngine.Object.op_Inequality(actarAction))_
- **Cast time modifier** (`CastTime`): `SkillUtil.CalcCastTime(0, PlayerStatusBase.get_BattleStatus())`

**Buff values** (every recovered field; durations in seconds)

**Buff `AegisBuf`**
- Duration: `(Lv * 60)` s

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MagicDmgCut | 10 | 10 | 15 | 15 | 15 | 20 | 20 | 20 | 25 | 25 |
| PowerDmgCut | -35 | -35 | -30 | -30 | -30 | -25 | -25 | -25 | -20 | -20 |

- Buff fields set in the constructor (all recovered):
  - `isViewSelfIcon` = `IsSelfAction`
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `SetViewSelfIcon`: `isViewSelfIcon`=(flag & 1)
**Buff `ProtectionBuf`**
- Duration: `(Lv * 60)` s

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| PowerDmgCut | 10 | 10 | 15 | 15 | 15 | 20 | 20 | 20 | 25 | 25 |
| MagicDmgCut | -35 | -35 | -30 | -30 | -30 | -25 | -25 | -25 | -20 | -20 |

- Buff fields set in the constructor (all recovered):
  - `IsSelfAction` = `1` = 1
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `BuffEffectActive` = `257` = 257
  - `BufEffectTakeUid` = `-1` = -1
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
- Hook `SetViewSelfIcon`: `isViewSelfIcon`=(flag & 1)
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:AegisBuf$$.ctor<-AegisAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

Parameter meanings (inferred from the `SkillBufferId` names):

- `MagicDmgCut`: magic damage taken reduction
- `PowerDmgCut`: physical damage taken reduction

**In-game level notes**

- Lv17: *MP ที่ใช้-200

**Where else this skill takes effect**

- Effect applied in `ProtectionAction$$ActionHit` (2 guarded paths):
  - when `SkillLv(264) ge 1`
    - calls `0x165db78`, `ProtectionBuf$$.ctor`, `SkillBufferManager$$AddBuffer`, `0x165db78`, `AegisBuf$$.ctor`, `SkillBufferManager$$AddBuffer`
  - when `SkillLv(264) lt 1`
    - returns `SkillLv(264)`
    - calls `0x165db78`, `ProtectionBuf$$.ctor`, `SkillBufferManager$$AddBuffer`
- Code that reads this skill's level / buff by constant id: `ProtectionAction$$ActionHit (GetSkillLv)`

_Raw recovered data (every method item): [trees/ShieldSkill.md](../trees/ShieldSkill.md) — uid 264_

---

### ชีลด์อัปเปอร์คัต (ShieldUpper) · uid 266

<img src="../../icons/sk_266.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 2) · **Type:** Attack · **Max Lv:** 20 · **Weapons:** Shield · **Requires:** ชีลด์มาสเตอรี่ · **Client class:** `ShieldUpperAction`

> เสยหมัดอย่างรุนแรงพร้อมโล่
> มีโอกาสที่เป้าหมายจะติด [ล้มคว่ำ]
> ความเสียหายที่ได้รับจะลดลง
> และเปิดใช้ Guard โดยอัตโนมัติระหว่างใช้สกิลนี้

**How it works**

- Attack skill of the シールドスキル tree (tier 2, max Lv 20); usable with Shield.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)]: skill multiplier ×0.15 at Lv1 to 1.5 at Lv10
  - `calcPlayerToMobDamage` [!AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(mobAction), 2) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage`: flat damage +100
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Tumble (2).
- Buffs:
  - `ShieldUpperBuf`
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(4)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 5 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionPreparation` — before the cast starts: 1 set, 3 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 3 tpl, 2 call, 1 info
- `.<>c__DisplayClass22_0::<ActionPreparation>b__0` — skill-specific method: 1 call
- `.<>c__DisplayClass22_0::<ActionPreparation>b__1` — skill-specific method: 1 call
- `via PlayerAttackBase$$HitReactionAssign` — skill-specific method: 1 call, 2 tpl

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.15 | 0.3 | 0.45 | 0.6 | 0.75 | 0.9 | 1.05 | 1.2 | 1.35 | 1.5 |
| Flat dmg + | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255)) * Lv) + (((Lv << 4) - Lv))) / 100)` — !AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(mobAction), 2) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv << 4) - Lv)) / 100)`
  - when `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255)) * Lv) + (((Lv << 4) - Lv))) / 100)`
  - when `!AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(mobAction), 2) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)`
- `via PlayerAttackBase$$HitReactionAssign` (method): `SetCalcValue[GuardPower]` = `System.Math.Max(0, (25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4))))`
  - when `!MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType ne 2 AND comboType ne 3`
- `via PlayerAttackBase$$HitReactionAssign` (method): `SetCalcValue[GuardPower]` = `25`
  - when `!MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType ne 2 AND comboType ne 3`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 266
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Rolls `percent`% to inflict **Tumble (2)** (`calcPlayerToMobDamage`)
  - when `!PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(mobAction), 2) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)`
- Marks the hit with ailment **Tumble (2)** (`calcPlayerToMobDamage`)
  - when `!AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(mobAction), 2) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(mobAction), 2) AND PlayerAttackBase.checkAbnormalPercent(this, 2, percent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)`
- Extra percent roll `CheckPercent` (`via PlayerAttackBase$$HitReactionAssign`)
  - when `!MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) eq 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3`

**Buffs and effects it installs or removes**

- `ActionPreparation` (before the cast starts): constructs `ShieldUpperBuf` — `.ctor(Lv, (ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255))`
  - when `!PlayerAttackBase.IsBlank(this) AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 AND UnityEngine.Object.op_Inequality(actarAction)`
- `ActionPreparation` (before the cast starts): adds the caster's buff of `new ShieldUpperBuf` — `AddSelfBuffer(new ShieldUpperBuf, Id)`
  - when `!PlayerAttackBase.IsBlank(this) AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 17 AND UnityEngine.Object.op_Inequality(actarAction)`
- `ActionPreparation` (before the cast starts): constructs `ShieldUpperBuf` — `.ctor(Lv, shieldRefine)`
  - when `!PlayerAttackBase.IsBlank(this) AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 17 AND UnityEngine.Object.op_Inequality(actarAction)`
- `.<>c__DisplayClass22_0::<ActionPreparation>b__0` (method): removes the caster's buff of skill 266 (ShieldUpper) — `RemoveSelfBuffer(266)`
- `.<>c__DisplayClass22_0::<ActionPreparation>b__1` (method): removes the caster's buff of skill 266 (ShieldUpper) — `RemoveSelfBuffer(266)`
  - when `(cancel & 1) ne 0`

**Other recovered parameters**

- **Effect percent** (`percent`): `((Lv + (Lv << 2)) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]

**Buff values** (every recovered field; durations in seconds)

**Buff `ShieldUpperBuf`**
- `MobLastDamageRateUnique` = `((((((Lv << 1) + lv) + ((Lv * shieldRefine) // 5)) + 39) lt 99 ? ((((Lv << 1) + lv) + ((Lv * shieldRefine) // 5)) + 39) : 99))` _(when BuffEffectActive ne 0)_
- `MobLastDamageRateUnique` = `0` _(when BuffEffectActive eq 0)_
- Buff fields set in the constructor (all recovered):
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
  - `BufEffectTakeUid` = `-1` = -1
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `damageCut` = `(((((Lv << 1) + lv) + ((Lv * shieldRefine) // 5)) + 39) lt 99 ? ((((Lv << 1) + lv) + ((Lv * shieldRefine) // 5)) + 39) : 99)`

Parameter meanings (inferred from the `SkillBufferId` names):

- `MobLastDamageRateUnique`: final damage multiplier vs monsters (unique category)

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

_Raw recovered data (every method item): [trees/ShieldSkill.md](../trees/ShieldSkill.md) — uid 266_

---

### ชีลด์แคนนอน (ShieldCannon) · uid 260

<img src="../../icons/sk_260.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 3) · **Type:** Attack · **Max Lv:** 50 · **Weapons:** Shield · **Requires:** ชีลด์บาช · **Flags:** MercenaryCanUseSkill · **Client class:** `ShieldCannonAction`

> ขว้างโล่ออกไปเต็มแรงเหมือนกระสุนปืนใหญ่
> มีโอกาสทำให้เป้าหมายหมดสติ
> ถ้าทำให้หมดสติสำเร็จพลังโจมตีจะเพิ่มขึ้น

**How it works**

- Attack skill of the シールドスキル tree (tier 3, max Lv 50); usable with Shield.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)]: skill multiplier ×0.6 at Lv1 to 1.5 at Lv10; flat damage +110 at Lv1 to 200 at Lv10
  - `calcPlayerToMobDamage` [!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) & !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)]: skill multiplier depends on live values (formula below); flat damage depends on live values (formula below)
  - `calcPlayerToMobDamage` [!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)]: skill multiplier depends on live values (formula below); flat damage depends on live values (formula below)
  - `calcPlayerToMobDamage` [!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) & !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)]: skill multiplier depends on live values (formula below); flat damage depends on live values (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Stun (3).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance((int((Lv * 1.5)) + 5))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 5 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 4 tpl, 2 call, 1 info, 3 set
- `via PlayerAttackBase$$HitReactionAssign` — skill-specific method: 1 call, 2 tpl

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.6 | 0.7 | 0.8 | 0.9 | 1 | 1.1 | 1.2 | 1.3 | 1.4 | 1.5 |
| Flat dmg + | 110 | 120 | 130 | 140 | 150 | 160 | 170 | 180 | 190 | 200 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((((Lv * 10) + 50) / 100))` — !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) & !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)
- SkillRate × `(((((Lv * 10) + 50) / 100)) * (((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255) ne 0 ? ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) : 1) & 255))` — !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)
- SkillRate × `(((((Lv * 10) + 50) / 100)) * (((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255) ne 0 ? ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) : 1) & 255))` — !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) & !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)
- Flat dmg + `((((Lv + (Lv << 2)) << 1) + 100))` — !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) & !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)
- Flat dmg + `(int(((((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255) / 5) + 1) * baseVIT)) + ((((Lv + (Lv << 2)) << 1) + 100)))` — !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)
- Flat dmg + `(int(((((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255) / 5) + 1) * baseVIT)) + ((((Lv + (Lv << 2)) << 1) + 100)))` — !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) & !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv * 10) + 50) / 100))`
  - when `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `((((Lv + (Lv << 2)) << 1) + 100))`
  - when `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv * 10) + 50) / 100)) * (((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255) ne 0 ? ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) : 1) & 255))`
  - when `!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(int(((((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255) / 5) + 1) * baseVIT)) + ((((Lv + (Lv << 2)) << 1) + 100)))`
  - when `!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)`
- `via PlayerAttackBase$$HitReactionAssign` (method): `SetCalcValue[GuardPower]` = `System.Math.Max(0, (25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4))))`
  - when `!MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType ne 2 AND comboType ne 3`
- `via PlayerAttackBase$$HitReactionAssign` (method): `SetCalcValue[GuardPower]` = `25`
  - when `!MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType ne 2 AND comboType ne 3`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 260
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Chance field `stunPercent` (Stun chance (%)): `((Lv + (Lv << 2)) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]
- Rolls `stunPercent`% to inflict **Stun (3)** (`calcPlayerToMobDamage`)
  - when `!PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)`
- Marks the hit with ailment **Stun (3)** (`calcPlayerToMobDamage`)
  - when `!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKeyMobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0) OR !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 3) AND !PlayerAttackBase.CheckMobActionUnobstructable(this, mobAction) AND (System.Collections.Generic.Dictionary<Int32Enum, object>.ContainsKey!MobActionManagerBase.get_AbnormalStateManager(mobAction).resistTimeList, 3, meta(0x39a06e0, Method$System.Collections.Generic.Dictionary<AbnormalType, AbnormalData>.ContainsKey())) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 0)`
- Extra percent roll `CheckPercent` (`via PlayerAttackBase$$HitReactionAssign`)
  - when `!MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) eq 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3`

_Raw recovered data (every method item): [trees/ShieldSkill.md](../trees/ShieldSkill.md) — uid 260_

---

### เมจิกคัลชีลด์ (MagicalShield) · uid 261

<img src="../../icons/sk_261.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 50 · **Weapons:** Shield · **Requires:** ฟอร์ชชีลด์ · **Client class:** `MagicalShield` (passive mastery)

> เพิ่ม MDEF และการต้านทานเวทย์
> เมื่อติดตั้งโล่

**How it works**

- Mastery skill of the シールドスキル tree (tier 3, max Lv 50); usable with Shield.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): CutDmgRate (damage taken reduction %) 1 at Lv1 to 10 at Lv10, MdefRate (MDEF %) 1 at Lv1 to 10 at Lv10, Mdef (MDEF) 6 at Lv1 to 20 at Lv10, MaxHp (max HP) 50 at Lv1 to 500 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| CutDmgRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| MdefRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| Mdef | 6 | 8 | 9 | 11 | 12 | 14 | 15 | 17 | 18 | 20 |
| MaxHp | 50 | 100 | 150 | 200 | 250 | 300 | 350 | 400 | 450 | 500 |


Bonus meanings (inferred from the names):

- `CutDmgRate`: damage taken reduction %
- `MdefRate`: MDEF %
- `Mdef`: MDEF
- `MaxHp`: max HP

_Raw recovered data (every method item): [trees/ShieldSkill.md](../trees/ShieldSkill.md) — uid 261_

---

### ดูอัลชีลด์ (PairOfShields) · uid 267

<img src="../../icons/sk_267.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 3) · **Type:** Buffer · **Max Lv:** 50 · **Weapons:** Shield · **Requires:** ชีลด์อัปเปอร์คัต · **Client class:** `PairOfShieldsAction`

> เจตจำนงอันแรงกล้าจะกลายเป็นป้อมปราการที่แข็งแกร่ง
> ติดตั้งโล่คู่
> และรักษาสถานะ Guard ระหว่างการต่อสู้
> หากติดตั้งเกราะหนักจะเพิ่มระยะ Guard
> และลดช่วงเวลาการโจมตีปกติ

**How it works**

- Buffer skill of the シールドスキル tree (tier 3, max Lv 50); usable with Shield.
- It installs a buff on the caster.
- Its buff exposes motion / combo hooks, so it changes the attack pattern while active (heuristic; the client has no explicit flag).
- Its buff raises normal-attack damage (`NormalAttackRate` / `NormalAttackConstantDamage`).
- Buffs:
  - `PairOfShieldsBuf`: lasts `(LeftTime + (ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255))` s
- Other client code reads this skill (9 lookups; see the last section).

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 1 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 2 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 267
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `PairOfShieldsBuf` — `.ctor(Lv, actarAction)`
  - when `UnityEngine.Object.op_Inequality(actarAction) OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 82) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 82) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): adds the caster's buff of `new PairOfShieldsBuf` — `AddSelfBuffer(new PairOfShieldsBuf, Id)`
  - when `UnityEngine.Object.op_Inequality(actarAction) OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 82) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 82) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)`

**Buff values** (every recovered field; durations in seconds)

**Buff `PairOfShieldsBuf`**
- **Changes the attack pattern**: the buff object drives a motion/combo chain (`get_BufEffectTakeId`).
- **Boosts normal-attack damage** through the `NormalAttackRate` / `NormalAttackConstantDamage` parameters.
- Buff hook methods: `BufferEnd`, `CheckPairOfShieldsTake`, `TakeStop`, `get_BufEffectTakeId`
- Duration: `(LeftTime + (ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255))` s [EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17]
- `NormalAttackRate` = `(((baseVIT // 5) + ((Lv + (Lv << 2)) << 1)))` _(when BuffEffectActive ne 0)_
- `HitUp` = `((hit + EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function))` _(when BuffEffectActive ne 0)_
- `AspdRate` = `((aspdRate + ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()))))` _(when BuffEffectActive ne 0)_
- Buff fields set in the constructor (all recovered):
  - `isBattleActive` = `1` = 1
  - `playerAction` = `playerAction`
  - `status` = `PlayerActionManagerBase.get_PlayerStatus()`
  - `takeController` = `playerAction.TakeController`
  - `effectManager` = `PlayerActionManagerBase.get_BufferEffectManager()`
  - `normalAttackRate` = `((baseVIT // 5) + ((Lv + (Lv << 2)) << 1))`
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `aspdRate` = `(aspdRate + ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())))` when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17
  - `hit` = `(hit + EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function)` when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `updateShield`=0; `isBattleActive`=1; `isBattleActive`=(PlayerActionManagerBase.get_IsBattleActive(playerAction) & 1)
- Hook `BufferEnd`: `LeftTime`=0

Parameter meanings (inferred from the `SkillBufferId` names):

- `AspdRate`: attack speed %
- `HitUp`: accuracy +
- `NormalAttackRate`: normal-attack damage multiplier (%)

**Where else this skill takes effect**

- Effect applied in `NormalAttackAction$$OnInitialize` (300 guarded paths, truncated):
  - when `(SkillBufferManager.TryGetBuf(?blr, 41, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() eq 1` AND `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-72), 0) & 1) ne 0`
    - returns `SkillBufferManager.SetBufferEffectActive(?blr, 678, 0, 0)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, meta(0), ?x2, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-56), 0, ?x3)`
    - set `subWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.out1(), 0, ?x2, ?x3)`
    - set `SkillIndividualFlag` = `(((((SkillIndividualFlag | 2) | 16) | 1024) | 0x2000) & 0xfffffe7f)`
    - set `defaultRange` = `0`
    - set `powerWaveRate` = `0`
    - set `damageCount` = `3`
    - set `sheatheMove` = `0x165db78(meta(0x399f8f8, SheatheMove_TypeInfo), ?x1, ?x2, ?x3)`
    - set `ChangeCriticalHitTake` = `0`
    - set `powerWaveMastery` = `0`
    - set `+0x13c` = `0`
    - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `MathUtil$$DisplayMeterToDistance`, `EquipItemData$$get_SubWeaponItemType`, `MathUtil$$DisplayMeterToDistance`
  - when `(SkillBufferManager.TryGetBuf(?blr, 41, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() eq 1` AND `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-72), 0) & 1) ne 0`
    - returns `SkillBufferManager.SetBufferEffectActive(?blr, 678, 0, 0)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, meta(0), ?x2, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-56), 0, ?x3)`
    - set `subWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.out1(), 0, ?x2, ?x3)`
    - set `SkillIndividualFlag` = `(((((SkillIndividualFlag | 2) | 16) | 1024) | 0x2000) & 0xfffffe7f)`
    - set `defaultRange` = `0`
    - set `powerWaveRate` = `0`
    - set `damageCount` = `3`
    - set `sheatheMove` = `0x165db78(meta(0x399f8f8, SheatheMove_TypeInfo), ?x1, ?x2, ?x3)`
    - set `ChangeCriticalHitTake` = `0`
    - set `powerWaveMastery` = `0`
    - set `+0x13c` = `0`
    - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `MathUtil$$DisplayMeterToDistance`, `EquipItemData$$get_SubWeaponItemType`, `MathUtil$$DisplayMeterToDistance`
  - when `(SkillBufferManager.TryGetBuf(?blr, 41, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() eq 1` AND `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-72), 0) & 1) ne 0`
    - returns `SkillBufferManager.SetBufferEffectActive(?blr, 678, 0, 0)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, meta(0), ?x2, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-56), 0, ?x3)`
    - set `subWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.out1(), 0, ?x2, ?x3)`
    - set `SkillIndividualFlag` = `(((((SkillIndividualFlag | 2) | 16) | 1024) | 0x2000) & 0xfffffe7f)`
    - set `defaultRange` = `0`
    - set `powerWaveRate` = `0`
    - set `damageCount` = `3`
    - set `sheatheMove` = `0x165db78(meta(0x399f8f8, SheatheMove_TypeInfo), ?x1, ?x2, ?x3)`
    - set `ChangeCriticalHitTake` = `0`
    - set `powerWaveMastery` = `0`
    - set `+0x13c` = `0`
    - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `MathUtil$$DisplayMeterToDistance`, `EquipItemData$$get_SubWeaponItemType`, `MathUtil$$DisplayMeterToDistance`
  - when `(SkillBufferManager.TryGetBuf(?blr, 41, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() eq 1` AND `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-72), 0) & 1) ne 0`
    - returns `SkillBufferManager.SetBufferEffectActive(?blr, 678, 0, 0)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, meta(0), ?x2, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-56), 0, ?x3)`
    - set `subWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.out1(), 0, ?x2, ?x3)`
    - set `SkillIndividualFlag` = `(((((SkillIndividualFlag | 2) | 16) | 1024) | 0x2000) & 0xfffffe7f)`
    - set `defaultRange` = `0`
    - set `powerWaveRate` = `0`
    - set `damageCount` = `3`
    - set `sheatheMove` = `0x165db78(meta(0x399f8f8, SheatheMove_TypeInfo), ?x1, ?x2, ?x3)`
    - set `ChangeCriticalHitTake` = `0`
    - set `powerWaveMastery` = `0`
    - set `+0x13c` = `0`
    - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `MathUtil$$DisplayMeterToDistance`, `EquipItemData$$get_SubWeaponItemType`, `MathUtil$$DisplayMeterToDistance`
  - when `(SkillBufferManager.TryGetBuf(?blr, 41, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() eq 1` AND `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-72), 0) & 1) ne 0`
    - returns `SkillBufferManager.SetBufferEffectActive(?blr, 678, 0, 0)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, meta(0), ?x2, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-56), 0, ?x3)`
    - set `subWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.out1(), 0, ?x2, ?x3)`
    - set `SkillIndividualFlag` = `(((((SkillIndividualFlag | 2) | 16) | 1024) | 0x2000) & 0xfffffe7f)`
    - set `defaultRange` = `0`
    - set `powerWaveRate` = `0`
    - set `damageCount` = `3`
    - set `sheatheMove` = `0x165db78(meta(0x399f8f8, SheatheMove_TypeInfo), ?x1, ?x2, ?x3)`
    - set `ChangeCriticalHitTake` = `0`
    - set `powerWaveMastery` = `0`
    - set `+0x13c` = `0`
    - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `MathUtil$$DisplayMeterToDistance`, `EquipItemData$$get_SubWeaponItemType`, `MathUtil$$DisplayMeterToDistance`
  - when `(SkillBufferManager.TryGetBuf(?blr, 41, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() eq 1` AND `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-72), 0) & 1) ne 0`
    - returns `SkillBufferManager.SetBufferEffectActive(?blr, 678, 0, 0)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, meta(0), ?x2, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-56), 0, ?x3)`
    - set `subWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.out1(), 0, ?x2, ?x3)`
    - set `SkillIndividualFlag` = `(((((SkillIndividualFlag | 2) | 16) | 1024) | 0x2000) & 0xfffffe7f)`
    - set `defaultRange` = `0`
    - set `powerWaveRate` = `0`
    - set `damageCount` = `3`
    - set `sheatheMove` = `0x165db78(meta(0x399f8f8, SheatheMove_TypeInfo), ?x1, ?x2, ?x3)`
    - set `ChangeCriticalHitTake` = `0`
    - set `powerWaveMastery` = `0`
    - set `+0x13c` = `0`
    - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `MathUtil$$DisplayMeterToDistance`, `EquipItemData$$get_SubWeaponItemType`, `MathUtil$$DisplayMeterToDistance`
  - when `(SkillBufferManager.TryGetBuf(?blr, 41, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() eq 1` AND `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-72), 0) & 1) ne 0`
    - returns `SkillBufferManager.SetBufferEffectActive(?blr, 678, 0, 0)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, meta(0), ?x2, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-56), 0, ?x3)`
    - set `subWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.out1(), 0, ?x2, ?x3)`
    - set `SkillIndividualFlag` = `(((((SkillIndividualFlag | 2) | 16) | 1024) | 0x2000) & 0xfffffe7f)`
    - set `defaultRange` = `0`
    - set `powerWaveRate` = `0`
    - set `damageCount` = `3`
    - set `sheatheMove` = `0x165db78(meta(0x399f8f8, SheatheMove_TypeInfo), ?x1, ?x2, ?x3)`
    - set `ChangeCriticalHitTake` = `0`
    - set `powerWaveMastery` = `0`
    - set `+0x13c` = `0`
    - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `MathUtil$$DisplayMeterToDistance`, `EquipItemData$$get_SubWeaponItemType`, `MathUtil$$DisplayMeterToDistance`
  - when `(SkillBufferManager.TryGetBuf(?blr, 41, stkp(-72), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() eq 1` AND `(SkillBufferManager.TryGetBuf(?blr, 82, stkp(-72), 0) & 1) ne 0`
    - returns `SkillBufferManager.SetBufferEffectActive(?blr, 678, 0, 0)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, meta(0), ?x2, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-56), 0, ?x3)`
    - set `subWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.out1(), 0, ?x2, ?x3)`
    - set `SkillIndividualFlag` = `(((((SkillIndividualFlag | 2) | 16) | 1024) | 0x2000) & 0xfffffe7f)`
    - set `defaultRange` = `0`
    - set `powerWaveRate` = `0`
    - set `damageCount` = `3`
    - set `sheatheMove` = `0x165db78(meta(0x399f8f8, SheatheMove_TypeInfo), ?x1, ?x2, ?x3)`
    - set `ChangeCriticalHitTake` = `0`
    - set `powerWaveMastery` = `0`
    - set `+0x13c` = `0`
    - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `MathUtil$$DisplayMeterToDistance`, `EquipItemData$$get_SubWeaponItemType`, `MathUtil$$DisplayMeterToDistance`
- Effect applied in `BeragelungAction$$IsFailure` (2 guarded paths):
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
  - always
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`
- Effect applied in `GuardActionManager$$CheckPairOfShieldsGuard` (4 guarded paths):
  - when `CharacterActionManagerBase.get_IsLocalDead() ne 0`
    - returns `(CharacterActionManagerBase.get_IsLocalDead() eq 267 ? 1 : 0)`
    - calls `EquipItemData$$get_SubWeaponItemType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`
  - when `CharacterActionManagerBase.get_IsLocalDead() eq 0`
    - returns `1`
    - calls `EquipItemData$$get_SubWeaponItemType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`
  - always
    - returns `0`
    - calls `EquipItemData$$get_SubWeaponItemType`
  - always
    - returns `0`
    - calls `EquipItemData$$get_SubWeaponItemType`
- Effect applied in `PlayerActionManager$$SuccessAddAbnormal` (9 guarded paths):
  - when `(type | 2) eq 18` AND `type eq 10` AND `(SkillBufferManager.TryGetBuf(?blr, 267, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `CrazyDaggerBuf.Damaged(this, type, 0, ?x3)`
    - calls `GoliathTakeShotAction$$ReceivedAbnormal`, `RampageAction$$ReceivedAbnormal`, `SkillBufferManager$$RemoveSelfBuffer`, `LunaDitherStarAction$$ReceivedAbnormal`, `PairOfShieldsBuf$$BufferEnd`, `ThorHammerAction$$ReceivedAbnormal`, `SlashReaperBuf$$ReceivedAbnormal`, `CrazyDaggerBuf$$Damaged`
  - when `(type | 2) eq 18` AND `type eq 10` AND `(SkillBufferManager.TryGetBuf(?blr, 267, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `GoliathTakeShotAction$$ReceivedAbnormal`, `RampageAction$$ReceivedAbnormal`, `SkillBufferManager$$RemoveSelfBuffer`, `LunaDitherStarAction$$ReceivedAbnormal`, `0x165db84`, `0x165df00`
  - when `(type | 2) eq 18` AND `type eq 10` AND `(SkillBufferManager.TryGetBuf(?blr, 267, stkp(-56), 0) & 1) eq 0`
    - returns `CrazyDaggerBuf.Damaged(this, type, 0, ?x3)`
    - calls `GoliathTakeShotAction$$ReceivedAbnormal`, `RampageAction$$ReceivedAbnormal`, `SkillBufferManager$$RemoveSelfBuffer`, `LunaDitherStarAction$$ReceivedAbnormal`, `ThorHammerAction$$ReceivedAbnormal`, `SlashReaperBuf$$ReceivedAbnormal`, `CrazyDaggerBuf$$Damaged`
  - when `(type | 2) ne 18` AND `type eq 10` AND `(SkillBufferManager.TryGetBuf(?blr, 267, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `CrazyDaggerBuf.Damaged(this, type, 0, ?x3)`
    - calls `GoliathTakeShotAction$$ReceivedAbnormal`, `RampageAction$$ReceivedAbnormal`, `LunaDitherStarAction$$ReceivedAbnormal`, `PairOfShieldsBuf$$BufferEnd`, `ThorHammerAction$$ReceivedAbnormal`, `SlashReaperBuf$$ReceivedAbnormal`, `CrazyDaggerBuf$$Damaged`
  - when `(type | 2) ne 18` AND `type eq 10` AND `(SkillBufferManager.TryGetBuf(?blr, 267, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `GoliathTakeShotAction$$ReceivedAbnormal`, `RampageAction$$ReceivedAbnormal`, `LunaDitherStarAction$$ReceivedAbnormal`, `0x165db84`, `0x165df00`
  - when `(type | 2) ne 18` AND `type eq 10` AND `(SkillBufferManager.TryGetBuf(?blr, 267, stkp(-56), 0) & 1) eq 0`
    - returns `CrazyDaggerBuf.Damaged(this, type, 0, ?x3)`
    - calls `GoliathTakeShotAction$$ReceivedAbnormal`, `RampageAction$$ReceivedAbnormal`, `LunaDitherStarAction$$ReceivedAbnormal`, `ThorHammerAction$$ReceivedAbnormal`, `SlashReaperBuf$$ReceivedAbnormal`, `CrazyDaggerBuf$$Damaged`
  - when `type eq 10` AND `(SkillBufferManager.TryGetBuf(?blr, 267, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `CrazyDaggerBuf.Damaged(this, type, 0, ?x3)`
    - calls `GoliathTakeShotAction$$ReceivedAbnormal`, `RampageAction$$ReceivedAbnormal`, `LunaDitherStarAction$$ReceivedAbnormal`, `PairOfShieldsBuf$$BufferEnd`, `ThorHammerAction$$ReceivedAbnormal`, `SlashReaperBuf$$ReceivedAbnormal`, `CrazyDaggerBuf$$Damaged`
  - when `type eq 10` AND `(SkillBufferManager.TryGetBuf(?blr, 267, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `GoliathTakeShotAction$$ReceivedAbnormal`, `RampageAction$$ReceivedAbnormal`, `LunaDitherStarAction$$ReceivedAbnormal`, `0x165db84`, `0x165df00`
- Effect applied in `PlayerBattleManager$$CheckZeroActionDelay` (14 guarded paths):
  - always
    - returns `1`
    - calls `AbnormalStateManager$$Contains`, `PlayerStatusBase$$CheckBodyAbility`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`
  - always
    - returns `0`
    - calls `AbnormalStateManager$$Contains`, `PlayerStatusBase$$CheckBodyAbility`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`
  - always
    - returns `1`
    - calls `AbnormalStateManager$$Contains`, `PlayerStatusBase$$CheckBodyAbility`
  - always
    - returns `1`
    - calls `AbnormalStateManager$$Contains`, `PlayerStatusBase$$CheckBodyAbility`
  - always
    - returns `1`
    - calls `AbnormalStateManager$$Contains`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`
  - always
    - returns `0`
    - calls `AbnormalStateManager$$Contains`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`
  - always
    - returns `1`
    - calls `AbnormalStateManager$$Contains`
  - always
    - returns `1`
    - calls `PlayerStatusBase$$CheckBodyAbility`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`
- Effect applied in `GuardActionManager$$CheckPairOfShields` (38 guarded paths):
  - when `IsGuard eq 0` AND `IPlayerStatusCalculator.get_GuardSpeed(?blr) ge 1` AND `CharacterActionManagerBase.get_IsLocalDead() ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() eq 267`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `interface IPlayerStatusCalculator.get_GuardSpeed`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `PlayerStatusBase$$CheckBodyAbility`, `interface MobActionManagerBase.get_transform`, `UnityEngine.Transform$$get_position`
  - when `IsGuard eq 0` AND `IPlayerStatusCalculator.get_GuardSpeed(?blr) ge 1` AND `CharacterActionManagerBase.get_IsLocalDead() ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() eq 267`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `interface IPlayerStatusCalculator.get_GuardSpeed`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `PlayerStatusBase$$CheckBodyAbility`, `interface MobActionManagerBase.get_transform`, `UnityEngine.Transform$$get_position`
  - when `IsGuard eq 0` AND `IPlayerStatusCalculator.get_GuardSpeed(?blr) ge 1` AND `CharacterActionManagerBase.get_IsLocalDead() ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() eq 267`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `interface IPlayerStatusCalculator.get_GuardSpeed`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `PlayerStatusBase$$CheckBodyAbility`, `interface MobActionManagerBase.get_transform`, `UnityEngine.Transform$$get_position`
  - when `IsGuard eq 0` AND `IPlayerStatusCalculator.get_GuardSpeed(?blr) ge 1` AND `CharacterActionManagerBase.get_IsLocalDead() ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() eq 267`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `interface IPlayerStatusCalculator.get_GuardSpeed`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `PlayerStatusBase$$CheckBodyAbility`, `interface MobActionManagerBase.get_transform`, `UnityEngine.Transform$$get_position`
  - when `IsGuard eq 0` AND `IPlayerStatusCalculator.get_GuardSpeed(?blr) ge 1` AND `CharacterActionManagerBase.get_IsLocalDead() ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() eq 267`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `interface IPlayerStatusCalculator.get_GuardSpeed`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `PlayerStatusBase$$CheckBodyAbility`, `interface MobActionManagerBase.get_transform`, `UnityEngine.Transform$$get_position`
  - when `IsGuard eq 0` AND `IPlayerStatusCalculator.get_GuardSpeed(?blr) ge 1` AND `CharacterActionManagerBase.get_IsLocalDead() ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() eq 267`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `interface IPlayerStatusCalculator.get_GuardSpeed`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `PlayerStatusBase$$CheckBodyAbility`, `interface MobActionManagerBase.get_transform`, `UnityEngine.Transform$$get_position`
  - when `IsGuard eq 0` AND `IPlayerStatusCalculator.get_GuardSpeed(?blr) ge 1` AND `CharacterActionManagerBase.get_IsLocalDead() ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() eq 267`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `interface IPlayerStatusCalculator.get_GuardSpeed`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `PlayerStatusBase$$CheckBodyAbility`, `interface MobActionManagerBase.get_transform`, `UnityEngine.Transform$$get_position`
  - when `IsGuard eq 0` AND `IPlayerStatusCalculator.get_GuardSpeed(?blr) ge 1` AND `CharacterActionManagerBase.get_IsLocalDead() ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() eq 267`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `interface IPlayerStatusCalculator.get_GuardSpeed`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `PlayerStatusBase$$CheckBodyAbility`, `interface MobActionManagerBase.get_transform`, `UnityEngine.Transform$$get_position`
- Effect applied in `GuardActionManager$$CheckGuardStart` (141 guarded paths):
  - always
    - returns `0`
    - calls `GuardActionManager$$CheckGuardEquip`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `GuardActionManager$$CheckInBlackHole`, `GuardActionManager$$get_GuardType`
  - when `CharacterActionManagerBase.get_IsLocalDead() eq 0`
    - returns `0`
    - calls `GuardActionManager$$CheckGuardEquip`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `GuardActionManager$$CheckInBlackHole`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `GuardActionManager$$get_GuardType`, `GuardActionManager$$get_GuardType`
  - when `CharacterActionManagerBase.get_IsLocalDead() ne 0`
    - returns `0`
    - calls `GuardActionManager$$CheckGuardEquip`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `GuardActionManager$$CheckInBlackHole`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `GuardActionManager$$get_GuardType`, `GuardActionManager$$get_GuardType`
  - when `CharacterActionManagerBase.get_IsLocalDead() eq 266`
    - returns `1`
    - calls `GuardActionManager$$CheckGuardEquip`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `GuardActionManager$$CheckInBlackHole`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `GuardActionManager$$get_GuardType`, `GuardActionManager$$get_GuardType`
  - when `CharacterActionManagerBase.get_IsLocalDead() eq 266`
    - returns `0`
    - calls `GuardActionManager$$CheckGuardEquip`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `GuardActionManager$$CheckInBlackHole`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `GuardActionManager$$get_GuardType`, `GuardActionManager$$get_GuardType`
  - when `CharacterActionManagerBase.get_IsLocalDead() eq 266`
    - returns `0`
    - calls `GuardActionManager$$CheckGuardEquip`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `GuardActionManager$$CheckInBlackHole`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `GuardActionManager$$get_GuardType`, `GuardActionManager$$get_GuardType`
  - when `CharacterActionManagerBase.get_IsLocalDead() eq 266`
    - returns `0`
    - calls `GuardActionManager$$CheckGuardEquip`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `GuardActionManager$$CheckInBlackHole`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `GuardActionManager$$get_GuardType`, `GuardActionManager$$get_GuardType`
  - when `CharacterActionManagerBase.get_IsLocalDead() eq 266`
    - returns `0`
    - calls `GuardActionManager$$CheckGuardEquip`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `GuardActionManager$$CheckInBlackHole`, `GuardActionManager$$get_GuardType`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `GuardActionManager$$get_GuardType`, `GuardActionManager$$get_GuardType`
- Code that reads this skill's level / buff by constant id: `BeragelungAction$$IsFailure (ContainsBuffer)`, `GuardActionManager$$CheckGuardStart (ContainsBuffer)`, `GuardActionManager$$CheckPairOfShields (ContainsBuffer)`, `GuardActionManager$$CheckPairOfShieldsGuard (ContainsBuffer)`, `NormalAttackAction$$OnInitialize (TryGetBuf)`, `PlayerActionManager$$Damaged (TryGetBuf)`, `PlayerActionManager$$SuccessAddAbnormal (TryGetBuf)`, `PlayerBattleManager$$CheckZeroActionDelay (ContainsBuffer)`, `UIFishingPanelManager$$StartFishingResponse (TryGetBuf)`

_Raw recovered data (every method item): [trees/ShieldSkill.md](../trees/ShieldSkill.md) — uid 267_

---

### การ์ดสไตร์ค (GuardStrike) · uid 262

<img src="../../icons/sk_262.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 4) · **Type:** Mastery · **Max Lv:** 110 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ชีลด์แคนนอน · **Client class:** `GuardStrikeAction` · **Client class:** `GuardStrike` (passive mastery)

> ต้านทานการโจมตีของศัตรูพร้อมโจมตีกลับ
> สร้างความเสียหายให้ศัตรูเมื่อ Guard ทำงาน
> พลังโจมตีจะเพิ่มตามพลัง Guard และค่าการถลุงของโล่

**How it works**

- Mastery skill of the シールドスキル tree (tier 4, max Lv 110); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [subWeapon != Shield]: skill multiplier ×0.1 at Lv1 to 1 at Lv10; flat damage +10 at Lv1 to 100 at Lv10
  - `calcPlayerToMobDamage` [subWeapon == Shield]: skill multiplier depends on live values (formula below); flat damage depends on live values (formula below)
- Passive modifiers (negative = penalty): SkillAttackRate (skill attack multiplier) 10 at Lv1 to 100 at Lv10.

**Cost, timing and range**

- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 5 set
- `ActionStart` — when the cast starts: 1 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 2 tpl, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.1 | 0.2 | 0.3 | 0.4 | 0.5 | 0.6 | 0.7 | 0.8 | 0.9 | 1 |
| Flat dmg + | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv + (Lv << 2)) << 1) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 46)) / 100))` — subWeapon == Shield
- Flat dmg + `((((Lv + (Lv << 2)) << 1) + ((ItemData.get_Refine(GetSubWeaponType.item(actarAction)) & 255) * 60)))` — subWeapon == Shield

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[SkillRate]` = `(((((Lv + (Lv << 2)) << 1) + BonusManager.GetBonusValue(PlayerStatusBase.get_BonusManager(), 46)) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetConstant[SkillConstantDamage]` = `((((Lv + (Lv << 2)) << 1) + ((ItemData.get_Refine(GetSubWeaponType.item(actarAction)) & 255) * 60)))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `none`, mode `never (IsExpDefFluctuate=false)`, attack type `None`, action id 262
- No proration slot: IsExpDefFluctuate=false.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillAttackRate | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |


Bonus meanings (inferred from the names):

- `SkillAttackRate`: skill attack multiplier

**In-game level notes**

- Lv17: *เพิ่มพลัง Guard ไปที่พลัง *ค่าการตีบวกของโล่มีผลต่อพลังสกิล

_Raw recovered data (every method item): [trees/ShieldSkill.md](../trees/ShieldSkill.md) — uid 262_

---

### การ์เดียน (Guardian) · uid 265

<img src="../../icons/sk_265.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 4) · **Type:** Support · **Max Lv:** 100 · **Weapons:** Shield · **Requires:** อีจิส · **Client class:** `GuardianAction`

> สร้างพื้นที่ลดความเสียหาย
> เพิ่มการฟื้นฟู Guard ของตัวเอง พลังโจมตีจะลดลง
> ตามจำนวนคนที่ปกป้อง แต่ค่าเฮทจะเพิ่มขึ้นจำนวนมาก
> ยิ่งค่าการถลุงสูงค่าความเสียหายก็จะยิ่งลดมาก

**How it works**

- Support skill of the シールドスキル tree (tier 4, max Lv 100); usable with Shield.
- It installs a buff on the caster.
- Buffs:
  - `GuardianBuf`: lasts `(((System.Math.Max(0, (Lv - 5)) + lv) * 10) + 30)` s; Lv1 → Lv10: AttackMprecoveryUp (MP recovered per attack (flat)) 6 → 15
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `0` = 0
- **Range** (`range`) (Unity units, 2 = 1 m): `int(MathUtil.DisplayMeterToDistance(int(((Lv * 0.5) + 1))))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 3 set, 1 call
- `OnInheritance` — state carried over when this action follows another: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 265
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): adds the caster's buff of skill 265 (Guardian) — `AddSelfBuffer(265, Lv, Id)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `0` = 0
- **Range** (`range`): `int(MathUtil.DisplayMeterToDistance(int(((Lv * 0.5) + 1))))`

**Buff values** (every recovered field; durations in seconds)

**Buff `GuardianBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `SetStatus`, `get_Num`, `get_Refine`, `set_Num`, `set_Refine`
- Duration: `(((System.Math.Max(0, (Lv - 5)) + lv) * 10) + 30)` s [(self & 1) ne 0]
- `HateRate` = `(Num * (int((Lv * 1.5)) + 15))` _(when BuffEffectActive ne 0; IsSelfAction ne 0; EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17)_
- `Guard` = `((val) + 15)` _(when BuffEffectActive ne 0; IsSelfAction ne 0; EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17)_
- `AttackMprecoveryUp` = `(Num * (int((Lv * 0.33)) + 2))` _(when BuffEffectActive ne 0; IsSelfAction ne 0; EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17)_
- `MAtkUpRate` = `(((Lv << 1) - 30) * Num)` _(when BuffEffectActive ne 0; IsSelfAction ne 0; EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17)_
- `AtkUpRate` = `(Num * (int((Lv * 1.5)) - 20))` _(when BuffEffectActive ne 0; IsSelfAction ne 0; EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17)_
- `MobLastDamageRateSupport` = `((val) + (int((Lv * 1.5)) + 20))` _(when BuffEffectActive ne 0; IsSelfAction eq 0; (Refine & 0x80000000) eq 0)_
- `HateRate` = `(((Lv - (Lv << 2)) - ((val) << 1)) - 30)` _(when BuffEffectActive ne 0; IsSelfAction eq 0; (Refine & 0x80000000) eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| AttackMprecoveryUp | 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13 | 14 | 15 |

- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `range` = `int(MathUtil.DisplayMeterToDistance(int(((Lv * 0.5) + 1))))` when (self & 1) ne 0
  - `Refine` = `val` when (self & 1) eq 0
- Hook `set_Num`: `Num`=value
- Hook `set_Refine`: `Refine`=value
- Hook `SetStatus`: `status`=status

Parameter meanings (inferred from the `SkillBufferId` names):

- `AtkUpRate`: ATK %
- `AttackMprecoveryUp`: MP recovered per attack (flat)
- `Guard`: guard (block) rate
- `HateRate`: aggro (hate) generation %
- `MAtkUpRate`: MATK %
- `MobLastDamageRateSupport`: final damage multiplier vs monsters (support category)

**In-game level notes**

- Lv17: [ค่าการตีของโล่จะมีผลทำให้ผลลัพธ์ด้านล่างแข็งแกร่งยิ่งขึ้น] *เพิ่มการฟื้นฟู Guard ที่ได้จากบัฟของพวกพ้องที่ได้รับการปกป้องจากสกิลนี้ *เพิ่มความสามารถในการลดเฮทของพวกพ้องที่ได้รับการปกป้องจากสกิลนี้

**Where else this skill takes effect**

- Effect applied in `PlayerSecondaryStatus$$GetDisplayBonusCalcHate` (293 guarded paths, truncated):
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
- Code that reads this skill's level / buff by constant id: `PlayerSecondaryStatus$$GetDisplayBonusCalcHate (TryGetBuf)`

_Raw recovered data (every method item): [trees/ShieldSkill.md](../trees/ShieldSkill.md) — uid 265_

---

### รีแพร์ชีลด์ (ShieldRepair) · uid 268

<img src="../../icons/sk_268.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 4) · **Type:** Buffer · **Max Lv:** 110 · **Weapons:** Shield · **Requires:** ดูอัลชีลด์ · **Client class:** `ShieldRepairAction`

> ซ่อมแซมโล่และฟื้นฟูความทนทาน
> 
> ฟื้นฟูพลัง Guard ที่ใช้ไป
> ฟื้นฟู MP ตามการฟื้นฟู Guard

**How it works**

- Buffer skill of the シールドスキル tree (tier 4, max Lv 110); usable with Shield.
- It is a utility / system action (movement, state change) rather than a damage or buff skill.

**Cost, timing and range**

- **Cast time** (`CastTime`): `1` = 1

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 268
- No proration slot: ExpType None: no proration slot.

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `1` = 1

_Raw recovered data (every method item): [trees/ShieldSkill.md](../trees/ShieldSkill.md) — uid 268_

---

### บาลาเกรุง (Beragelung) · uid 269

<img src="../../icons/sk_269.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 5) · **Type:** Object · **Max Lv:** 225 · **Weapons:** Shield · **Requires:** รีแพร์ชีลด์ · **Client class:** `BeragelungAction`

> การโจมตีด้วยโล่คู่ที่ใช้ได้ระหว่างใช้สกิล "ดูอัลชีลด์" เท่านั้น
> 
> โจมตีวงกว้าง 2 ครั้งและจบสกิลดูอัลชีลด์
> เพิ่มความเสียหายให้กับเป้าหมายที่เคลื่อนที่ไม่ได้

**How it works**

- Object skill of the シールドスキル tree (tier 5, max Lv 225); usable with Shield.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- It places an object in the world (trap, summon or field object).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×6.525 at Lv1 to 11.25 at Lv10; skill multiplier ×4.35 at Lv1 to 7.5 at Lv10; flat damage +110 at Lv1 to 200 at Lv10; flat damage depends on live values (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Buffs:
  - `BeragelungBuf`
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`
- **Attack range** (`attackRange`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance(3)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 5 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionStartOthers` — skill-specific method: 4 set
- `ActionPreparation` — before the cast starts: 5 set
- `ActionSkillEvent` — on an animation/skill event during the motion: 3 set
- `ActionSkillReceiveEffect` — skill-specific method: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 6 tpl, 1 info
- `AddDebuff` — skill-specific method: 2 call
- `ValidDebuff` — skill-specific method: 5 call
- `InvalidDebuff` — skill-specific method: 1 call
- `.<>c__DisplayClass36_0::<ActionPreparation>b__0` — skill-specific method: 1 call
- `.<>c__DisplayClass36_0::<ActionPreparation>b__1` — skill-specific method: 1 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 6.525 | 7.05 | 7.575 | 8.1 | 8.625 | 9.15 | 9.675 | 10.2 | 10.725 | 11.25 |
| SkillRate × | 4.35 | 4.7 | 5.05 | 5.4 | 5.75 | 6.1 | 6.45 | 6.8 | 7.15 | 7.5 |
| Flat dmg + | 110 | 120 | 130 | 140 | 150 | 160 | 170 | 180 | 190 | 200 |

**Damage terms that depend on live stats (not tabulated)**

- Flat dmg + `((((Lv * 10) + 100)) + (((((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255)) // 5) + 1) * baseVIT))`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((1.5 * (((Lv * 35) + 400))) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `((((Lv * 10) + 100)) + (((((ItemData.get_Refine(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData())) & 255)) // 5) + 1) * baseVIT))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefSkill / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(targetExpList[mobAction] / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv * 35) + 400)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv * 10) + 100))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 269
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `AddDebuff` (method): constructs `BeragelungStraightDebuff` — `.ctor(Toram.Common.ArchetypeUid.get_Id(stkp(-56)), action.Level)`
  - when `!UnityEngine.Object.op_Equality(actionManager) AND IsInstanceOf(action, PlayerAttackBase) eq 1 AND PlayerStatusBase.CheckBodyAbility(PlayerActionManagerBase.get_PlayerStatus(), 2) AND SkillActionBase.get_ActionID() eq 269`
- `AddDebuff` (method): constructs `BeragelungHomingDebuff` — `.ctor(Toram.Common.ArchetypeUid.get_Id(stkp(-56)), action.Level)`
  - when `!UnityEngine.Object.op_Equality(actionManager) AND IsInstanceOf(action, PlayerAttackBase) eq 1 AND PlayerStatusBase.CheckBodyAbility(PlayerActionManagerBase.get_PlayerStatus(), 2) AND SkillActionBase.get_ActionID() eq 269`
- `ValidDebuff` (method): constructs `BeragelungBuf` — `.ctor(int((BeragelungDebuffBase.GetLastDamageUpRate(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 11)) + BeragelungDebuffBase.GetLastDamageUpRate(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 12)))), (BeragelungDebuffBase.GetAttackMpRecovery(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 12)) + BeragelungDebuffBase.GetAttackMpRecovery(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 11))))`
  - when `TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 11) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 12) ne 0`
- `ValidDebuff` (method): adds the caster's buff of `new BeragelungBuf` — `AddSelfBuffer(new BeragelungBuf, 0)`
- `ValidDebuff` (method): constructs `BeragelungBuf` — `.ctor(int(BeragelungDebuffBase.GetLastDamageUpRate(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 11))), BeragelungDebuffBase.GetAttackMpRecovery(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 11)))`
  - when `TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 11) ne 0`
- `ValidDebuff` (method): constructs `BeragelungBuf` — `.ctor(int(BeragelungDebuffBase.GetLastDamageUpRate(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 12))), BeragelungDebuffBase.GetAttackMpRecovery(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 12)))`
  - when `TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 12) ne 0`
- `ValidDebuff` (method): constructs `BeragelungBuf` — `.ctor(0, 0)`
- `InvalidDebuff` (method): removes the caster's buff of skill 269 (Beragelung) — `RemoveSelfBuffer(269)`
- `.<>c__DisplayClass36_0::<ActionPreparation>b__0` (method): removes the caster's buff of skill 267 (PairOfShields) — `RemoveSelfBuffer(267)`
- `.<>c__DisplayClass36_0::<ActionPreparation>b__1` (method): removes the caster's buff of skill 267 (PairOfShields) — `RemoveSelfBuffer(267)`
  - when `(cancel & 1) ne 0`

**Other recovered parameters**

- **Attack range** (`attackRange`): `MathUtil.DisplayMeterToDistance(3)`

**Buff values** (every recovered field; durations in seconds)

**Buff `BeragelungBuf`**
- `LastDmgUpRate` = `(lastDamageRate)` _(when BuffEffectActive ne 0)_
- `AttackMprecoveryUp` = `(attackMpRecovery)` _(when BuffEffectActive ne 0)_
- Buff fields set in the constructor (all recovered):
  - `lastDamageRate` = `lastDamageRate`
  - `attackMpRecovery` = `attackMpRecovery`
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:BeragelungBuf$$.ctor<-BeragelungAction$$ValidDebuff` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

Parameter meanings (inferred from the `SkillBufferId` names):

- `AttackMprecoveryUp`: MP recovered per attack (flat)
- `LastDmgUpRate`: final damage dealt %

**In-game level notes**

- Lv17: ทำให้เคลื่อนที่ไม่ได้หมายถึง [ผงะ], [ล้มคว่ำ] และ [หมดสติ]  ติดดีบัฟให้กับเป้าหมายเมื่อติดตั้งเกราะหนัก ดีบัฟจะอยู่ต่อเนื่อง 15 วินาที ลดต้านทานคริติคอลตามเลเวลบาลาเกรุง เพิ่มความเสียหายที่ทำได้และการฟื้นฟู MP การโจมตี หากเป้าหมายถูกทำให้เคลื่อนที่ไม่ได้

_Raw recovered data (every method item): [trees/ShieldSkill.md](../trees/ShieldSkill.md) — uid 269_

---

### ラスティール / ラースバーン · uid 270

<img src="../../icons/sk_270.png" width="40" alt="icon"> 
**Tree:** シールドスキル (`ShieldSkill`, tier 5) · **Type:** Attack · **Max Lv:** 225 · **Weapons:** Shield · **Requires:** การ์เดียน · **Flags:** CanNotUse

> No Info Data...

**How it works**

- Attack skill of the シールドスキル tree (tier 5, max Lv 225); usable with Shield.
- Client status: **no-client-code** — flag CanNotUse (system/unreleased).

_Raw recovered data (every method item): [trees/ShieldSkill.md](../trees/ShieldSkill.md) — uid 270_

---
