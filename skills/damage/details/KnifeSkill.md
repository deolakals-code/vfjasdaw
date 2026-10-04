# ナイフスキル (`KnifeSkill`) — skill details

13 entries.

### โธร์วไนฟ์ (Throwing) · uid 295

<img src="../../icons/sk_295.png" width="40" alt="icon"> 
**Tree:** ナイフスキル (`KnifeSkill`, tier 1) · **Type:** Attack · **Max Lv:** 5 · **Weapons:** ShortSword · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `ThrowingAction`

> โจมตีด้วยการขว้างดาบสั้น
> 
> ถ้าถึง Lv10 แล้ว MP ที่ใช้จะเป็น 0
> กลายเป็นความเคยชินตามปกติ

**How it works**

- Attack skill of the ナイフスキル tree (tier 1, max Lv 5); usable with ShortSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- MP: `0`.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×0.14 at Lv1 to 0.5 at Lv10
- Proration: slot chosen at runtime (physical or magic by a per-cast flag), mode `first_hit_per_target`.

**Cost, timing and range**

- **MP cost** (`mp` in `OnInitialize`): `0` = 0
  - when `Lv eq 10`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 set, 4 tpl, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.14 | 0.18 | 0.22 | 0.26 | 0.3 | 0.34 | 0.38 | 0.42 | 0.46 | 0.5 |

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv << 2) + 10) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[LastConstantDamage]` = `status.SubEqAtk`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[LastDamageRate]` = `PlayerAttackBase.CalcLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus(), ThrowingAction.get_AttackType())`
  - when `(SkillParam & 32) ne 0 AND MobaMode eq 0 AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) OR (SkillParam & 32) ne 0 AND MobaMode eq 0 AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) AND TryGetProperties<object>.out2(mobAction, 90) ne 0 OR (SkillParam & 32) ne 0 AND MobaMode eq 0 AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) AND TryGetProperties<object>.out2(mobAction, 90) eq 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[LastDamageRate]` = `-MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90))`
  - when `(SkillParam & 32) ne 0 AND MobaMode eq 0 AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) AND TryGetProperties<object>.out2(mobAction, 90) ne 0`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `dynamic`, mode `first_hit_per_target`, attack type `dynamic`, action id 295
- Uses the slot chosen at runtime (physical or magic by a per-cast flag); Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Other recovered parameters**

- **MP cost** (`mp`): `0` = 0 _(when Lv eq 10)_

_Raw recovered data (every method item): [trees/KnifeSkill.md](../trees/KnifeSkill.md) — uid 295_

---

### แซคเคิลอาร์ม (SecondArm) · uid 296

<img src="../../icons/sk_296.png" width="40" alt="icon"> 
**Tree:** ナイフスキル (`KnifeSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 5 · **Weapons:** ShortSword · **Flags:** StarGem · **Client class:** `SecondArm` (passive mastery)

> มีโอกาสเพิ่มค่าความเสียหายเล็กน้อย
> ในการโจมตีปกติถ้าติดตั้งมีดอยู่

**How it works**

- Mastery skill of the ナイフスキル tree (tier 1, max Lv 5); usable with ShortSword.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Trigger (trigger chance (%)) 5 at Lv1 to 50 at Lv10, SkillRate (skill multiplier bonus) 25.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Trigger | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |
| SkillRate | 25 | 25 | 25 | 25 | 25 | 25 | 25 | 25 | 25 | 25 |


Bonus meanings (inferred from the names):

- `Trigger`: trigger chance (%)
- `SkillRate`: skill multiplier bonus

_Raw recovered data (every method item): [trees/KnifeSkill.md](../trees/KnifeSkill.md) — uid 296_

---

### สไปก์ดาร์ต (SpikeDart) · uid 290

<img src="../../icons/sk_290.png" width="40" alt="icon"> 
**Tree:** ナイフスキル (`KnifeSkill`, tier 2) · **Type:** Attack · **Max Lv:** 20 · **Weapons:** ShortSword · **Requires:** โธร์วไนฟ์ · **Flags:** MercenaryCanUseSkill · **Client class:** `SpikeDartAction`

> รบกวนการเคลื่อนไหวด้วยการขว้างมีดสั้นใส่เท้าของเป้าหมาย
> มีโอกาสทำให้เป้าหมาย[เชื่องช้า]

**How it works**

- Attack skill of the ナイフスキル tree (tier 2, max Lv 20); usable with ShortSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [1 hs Lv AND Lv ne 0]: skill multiplier ×0.75
  - `calcPlayerToMobDamage` [1 lo Lv AND 2 hs Lv AND Lv ne 0]: skill multiplier ×0.42
  - `calcPlayerToMobDamage` [1 lo Lv AND 2 lo Lv AND 3 hs Lv AND Lv ne 0]: skill multiplier ×0.47
  - `calcPlayerToMobDamage` [1 lo Lv AND 2 lo Lv AND 3 lo Lv AND Lv ne 0]: skill multiplier ×47
  - `calcPlayerToMobDamage`: skill multiplier depends on live values (formula below); flat damage +11 at Lv1 to 20 at Lv10; flat damage depends on SubEqAtk (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Slow (11).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(8)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 12 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 set, 6 tpl, 2 call, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [1 hs Lv AND Lv ne 0] | 0.75 | 0.75 | 0.75 | 0.75 | 0.75 | 0.75 | 0.75 | 0.75 | 0.75 | 0.75 |
| SkillRate × [1 lo Lv AND 2 hs Lv AND Lv ne 0] | 0.42 | 0.42 | 0.42 | 0.42 | 0.42 | 0.42 | 0.42 | 0.42 | 0.42 | 0.42 |
| SkillRate × [1 lo Lv AND 2 lo Lv AND 3 hs Lv AND Lv ne 0] | 0.47 | 0.47 | 0.47 | 0.47 | 0.47 | 0.47 | 0.47 | 0.47 | 0.47 | 0.47 |
| SkillRate × [1 lo Lv AND 2 lo Lv AND 3 lo Lv AND Lv ne 0] | 47 | 47 | 47 | 47 | 47 | 47 | 47 | 47 | 47 | 47 |
| Flat dmg + | 11 | 12 | 13 | 14 | 15 | 16 | 17 | 18 | 19 | 20 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((baseDEX // (20 - Lv)) / 100))`
- Flat dmg + `((status.SubEqAtk // 5))`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(0.75)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((baseDEX // (20 - Lv)) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `((Lv + 10))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `((status.SubEqAtk // 5))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[LastDamageRate]` = `PlayerAttackBase.CalcLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus(), SpikeDartAction.get_AttackType())`
  - when `(SkillParam & 32) ne 0 AND MobaMode eq 0 AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) AND damageCount lt 1 OR (SkillParam & 32) ne 0 AND 1 ge damageCount AND MobaMode eq 0 AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) AND damageCount ge 1 OR (SkillParam & 32) ne 0 AND MobaMode eq 0 AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) AND TryGetProperties<object>.out2(mobAction, 90) ne 0 AND damageCount lt 1`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[LastDamageRate]` = `-MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90))`
  - when `(SkillParam & 32) ne 0 AND MobaMode eq 0 AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) AND TryGetProperties<object>.out2(mobAction, 90) ne 0 AND damageCount lt 1 OR (SkillParam & 32) ne 0 AND 1 ge damageCount AND MobaMode eq 0 AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) AND TryGetProperties<object>.out2(mobAction, 90) ne 0 AND damageCount ge 1 OR (SkillParam & 32) ne 0 AND MobaMode eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, 11, slowPercent, playerAction) AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) AND TryGetProperties<object>.out2(mobAction, 90) ne 0 AND damageCount lt 1`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 290
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Hit counts**

- Number of damage events (`damageCount`): `1` = 1
  - when `1 hs Lv AND Lv ne 0`
- Number of damage events (`damageCount`): `2` = 2
  - when `1 lo Lv AND 2 hs Lv AND Lv ne 0 OR 1 lo Lv AND 2 lo Lv AND 3 hs Lv AND Lv ne 0 OR 1 lo Lv AND 2 lo Lv AND 3 lo Lv AND Lv ne 0`

**Status ailments**

- Chance field `slowPercent` (Slow chance (%)): `((Lv + (Lv << 2)) + 50)` → Lv1..10 [55, 60, 65, 70, 75, 80, 85, 90, 95, 100]
  - when `Lv eq 0 OR 1 hs Lv AND Lv ne 0 OR 1 lo Lv AND 2 hs Lv AND Lv ne 0`
- Rolls `slowPercent`% to inflict **Slow (11)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 11, slowPercent, playerAction) AND damageCount lt 1 OR !PlayerAttackBase.checkAbnormalPercent(this, 11, slowPercent, playerAction) AND damageCount lt 1 OR 1 ge damageCount AND PlayerAttackBase.checkAbnormalPercent(this, 11, slowPercent, playerAction) AND damageCount ge 1`
- Marks the hit with ailment **Slow (11)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 11, slowPercent, playerAction) AND damageCount lt 1 OR 1 ge damageCount AND PlayerAttackBase.checkAbnormalPercent(this, 11, slowPercent, playerAction) AND damageCount ge 1 OR MobaMode ne 0 AND PlayerAttackBase.checkAbnormalPercent(this, 11, slowPercent, playerAction) AND damageCount lt 1`

**Other recovered parameters**

- **Number of damage events** (`damageCount`): `1` = 1 _(when 1 hs Lv AND Lv ne 0)_; `2` = 2 _(when 1 lo Lv AND 2 hs Lv AND Lv ne 0 OR 1 lo Lv AND 2 lo Lv AND 3 hs Lv AND Lv ne 0 OR 1 lo Lv AND 2 lo Lv AND 3 lo Lv AND Lv ne 0)_
- **Alternate skill multiplier (%)** (`bonusSkillRate`): `((baseDEX // (20 - Lv)) / 100)` _(when Lv eq 0 OR 1 hs Lv AND Lv ne 0 OR 1 lo Lv AND 2 hs Lv AND Lv ne 0)_
- **Bonus flat damage** (`bonusFixAddDamage`): `(status.SubEqAtk // 5)` _(when Lv eq 0 OR 1 hs Lv AND Lv ne 0 OR 1 lo Lv AND 2 hs Lv AND Lv ne 0)_

_Raw recovered data (every method item): [trees/KnifeSkill.md](../trees/KnifeSkill.md) — uid 290_

---

### พอยซั่นแดกเกอร์ (PoisonDagger) · uid 291

<img src="../../icons/sk_291.png" width="40" alt="icon"> 
**Tree:** ナイフスキル (`KnifeSkill`, tier 2) · **Type:** Attack · **Max Lv:** 20 · **Weapons:** ShortSword · **Requires:** โธร์วไนฟ์ · **Flags:** MercenaryCanUseSkill · **Client class:** `PoisonDaggerAction`

> โจมตีด้วยมีดสั้นอาบยาพิษ
> มีโอกาสทำให้เป้าหมายติด[พิษ]

**How it works**

- Attack skill of the ナイフスキル tree (tier 2, max Lv 20); usable with ShortSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×0.52 at Lv1 to 0.75 at Lv10; skill multiplier depends on live values (formula below); flat damage +110 at Lv1 to 200 at Lv10; flat damage depends on SubAtk (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Poison (5).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(8)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 7 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 set, 6 tpl, 3 call, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.52 | 0.55 | 0.57 | 0.6 | 0.62 | 0.65 | 0.67 | 0.7 | 0.72 | 0.75 |
| Flat dmg + | 110 | 120 | 130 | 140 | 150 | 160 | 170 | 180 | 190 | 200 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((baseINT // (11 - Lv)) / 100))`
- Flat dmg + `(status.SubAtk)`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((int((Lv * 2.5)) + 50) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((baseINT // (11 - Lv)) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv * 10) + 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(status.SubAtk)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[LastDamageRate]` = `PlayerAttackBase.CalcLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus(), PoisonDaggerAction.get_AttackType())`
  - when `(SkillParam & 32) ne 0 AND MobaMode eq 0 AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) OR (SkillParam & 32) ne 0 AND MobaMode eq 0 AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) AND TryGetProperties<object>.out2(mobAction, 90) ne 0 OR (SkillParam & 32) ne 0 AND MobaMode eq 0 AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) AND TryGetProperties<object>.out2(mobAction, 90) eq 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[LastDamageRate]` = `-MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90))`
  - when `(SkillParam & 32) ne 0 AND MobaMode eq 0 AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) AND TryGetProperties<object>.out2(mobAction, 90) ne 0 OR (SkillParam & 32) ne 0 AND MobaMode eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, 5, poisonPercent, playerAction) AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) AND TryGetProperties<object>.out2(mobAction, 90) ne 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 5, poisonPercent, playerAction) AND (SkillParam & 32) ne 0 AND MobaMode eq 0 AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) AND TryGetProperties<object>.out2(mobAction, 90) ne 0`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 291
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Chance field `poisonPercent` (Poison chance (%)): `(int((Lv * 2.5)) + 75)` → Lv1..10 [77, 80, 82, 85, 87, 90, 92, 95, 97, 100]
- Rolls `poisonPercent`% to inflict **Poison (5)** (`calcPlayerToMobDamage`)
- Marks the hit with ailment **Poison (5)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 5, poisonPercent, playerAction) OR MobaMode ne 0 AND PlayerAttackBase.checkAbnormalPercent(this, 5, poisonPercent, playerAction) OR !SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) AND MobaMode eq 0 AND PlayerAttackBase.checkAbnormalPercent(this, 5, poisonPercent, playerAction)`

**Other recovered parameters**

- **Alternate skill multiplier (%)** (`bonusSkillRate`): `((baseINT // (11 - Lv)) / 100)`
- **Bonus flat damage** (`bonusFixAddDamage`): `status.SubAtk`

_Raw recovered data (every method item): [trees/KnifeSkill.md](../trees/KnifeSkill.md) — uid 291_

---

### อินเทนซีฟไนฟ์ (IntenseKnife) · uid 297

<img src="../../icons/sk_297.png" width="40" alt="icon"> 
**Tree:** ナイフスキル (`KnifeSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 20 · **Weapons:** ShortSword · **Requires:** แซคเคิลอาร์ม · **Client class:** `IntenseKnife` (passive mastery)

> เพิ่มพลังโจมตีและอัตราการเกิด
> ให้แซคเคิลอาร์มมีประสิทธิภาพมากขึ้น

**How it works**

- Mastery skill of the ナイフスキル tree (tier 2, max Lv 20); usable with ShortSword.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Trigger (trigger chance (%)) 5 at Lv1 to 50 at Lv10, SkillRate (skill multiplier bonus) 25.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Trigger | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |
| SkillRate | 25 | 25 | 25 | 25 | 25 | 25 | 25 | 25 | 25 | 25 |


Bonus meanings (inferred from the names):

- `Trigger`: trigger chance (%)
- `SkillRate`: skill multiplier bonus

_Raw recovered data (every method item): [trees/KnifeSkill.md](../trees/KnifeSkill.md) — uid 297_

---

### แกตติ้งไนฟ์ (GatlingKnife) · uid 292

<img src="../../icons/sk_292.png" width="40" alt="icon"> 
**Tree:** ナイフスキル (`KnifeSkill`, tier 3) · **Type:** Attack · **Max Lv:** 50 · **Weapons:** ShortSword · **Requires:** สไปก์ดาร์ต · **Flags:** MercenaryCanUseSkill · **Client class:** `GatlingKnifeAction`

> ขวางมีดสั้นออกไปเป็นจำนวนมากอย่างต่อเนื่อง

**How it works**

- Attack skill of the ナイフスキル tree (tier 3, max Lv 50); usable with ShortSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×0.4 at Lv1 to 1 at Lv10; skill multiplier depends on live values (formula below); flat damage +22 at Lv1 to 40 at Lv10; flat damage depends on SubEqAtk (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(8)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 7 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 set, 6 tpl, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.4 | 0.4 | 0.5 | 0.6 | 0.7 | 0.7 | 0.8 | 0.9 | 1 | 1 |
| Flat dmg + | 22 | 24 | 26 | 28 | 30 | 32 | 34 | 36 | 38 | 40 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((baseAGI + baseSTR) + baseDEX) // 30) / 100))`
- Flat dmg + `(status.SubEqAtk)`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((int(((Lv - 1) * 0.75)) * 10) + 40) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((baseAGI + baseSTR) + baseDEX) // 30) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv << 1) + 20))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(status.SubEqAtk)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[LastDamageRate]` = `PlayerAttackBase.CalcLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus(), GatlingKnifeAction.get_AttackType())`
  - when `(SkillParam & 32) ne 0 AND MobaMode eq 0 AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) AND damageCount lt 1 OR (SkillParam & 32) ne 0 AND 1 ge damageCount AND MobaMode eq 0 AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) AND damageCount ge 1 OR (SkillParam & 32) ne 0 AND MobaMode eq 0 AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) AND TryGetProperties<object>.out2(mobAction, 90) ne 0 AND damageCount lt 1`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[LastDamageRate]` = `-MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90))`
  - when `(SkillParam & 32) ne 0 AND MobaMode eq 0 AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) AND TryGetProperties<object>.out2(mobAction, 90) ne 0 AND damageCount lt 1 OR (SkillParam & 32) ne 0 AND 1 ge damageCount AND MobaMode eq 0 AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) AND TryGetProperties<object>.out2(mobAction, 90) ne 0 AND damageCount ge 1 OR (SkillParam & 32) ne 0 AND 1 ge damageCount AND MobaMode eq 0 AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) AND TryGetProperties<object>.out2(mobAction, 90) ne 0 AND damageCount ge 1 AND damageCount lt 1`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 292
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Hit counts**

- Number of damage events (`damageCount`): `(((Lv + 2) >> 2) + 5)` → Lv1..10 [5, 6, 6, 6, 6, 7, 7, 7, 7, 8]

**Other recovered parameters**

- **Alternate skill multiplier (%)** (`bonusSkillRate`): `((((baseAGI + baseSTR) + baseDEX) // 30) / 100)`
- **Bonus flat damage** (`bonusFixAddDamage`): `status.SubEqAtk`
- **Number of damage events** (`damageCount`): `(((Lv + 2) >> 2) + 5)` → Lv1..10 [5, 6, 6, 6, 6, 7, 7, 7, 7, 8]

_Raw recovered data (every method item): [trees/KnifeSkill.md](../trees/KnifeSkill.md) — uid 292_

---

### ดับเบิ้ลสแทบ (DoubleThrow) · uid 293

<img src="../../icons/sk_293.png" width="40" alt="icon"> 
**Tree:** ナイフスキル (`KnifeSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 50 · **Weapons:** ShortSword · **Requires:** พอยซั่นแดกเกอร์ · **Client class:** `DoubleThrow` (passive mastery)

> เมื่อใช้ Avoid พลังของสกิลมีดที่ใช้ถัดไปจะเพิ่มขึ้น
> ถ้าใช้ไปครั้งหนึ่งแล้วจะต้องรอเวลาเพื่อใช้ครั้งถัดไป
> จะสามารถใช้ครั้งต่อไปได้เร็วขึ้นเมื่อเลเวลเพิ่มขึ้น
> ไม่มีผลกับสกิลที่ไม่ได้ใช้ MP

**How it works**

- Mastery skill of the ナイフスキル tree (tier 3, max Lv 50); usable with ShortSword.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Its effect is applied by client code: `AvoidActionManager$$DoubleThrowAvoid` (formulas in the last section).
- Other client code reads this skill (3 lookups; see the last section).

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

- `Trigger` = `?addv`

Bonus meanings (inferred from the names):

- `Trigger`: trigger chance (%)

**Where else this skill takes effect**

- Effect applied in `AvoidActionManager$$DoubleThrowAvoid` (4 guarded paths):
  - always
    - returns `SkillBufferManager.ContainsBuffer(PlayerDataManager.get_SkillBufferManager(playerManager, 0, ?x2, ?x3), 293, 0, ?x3)`
    - calls `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `PlayerDataManager$$get_SkillBufferManager`
  - always
    - calls `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `PlayerDataManager$$get_SkillBufferManager`, `0x165db78`, `DoubleThrowBuf$$.ctor`, `PlayerDataManager$$get_SkillBufferManager`
  - always
    - returns `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType([CharacterActionManagerBase.set_DefaultMoveSpeed()+0x20], 0, ?x2, ?x3)`
    - calls `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
  - always
    - returns `SkillLv(293)`
    - calls `PlayerDataManager$$get_SkillManager`
- Code that reads this skill's level / buff by constant id: `AvoidActionManager$$DoubleThrowAvoid (ContainsBuffer)`, `AvoidActionManager$$DoubleThrowAvoid (GetSkillLv)`, `PlayerBattleManager$$OnSkillActionDamaged (TryGetBuf)`

_Raw recovered data (every method item): [trees/KnifeSkill.md](../trees/KnifeSkill.md) — uid 293_

---

### ไนฟ์คอมแบท (KnifeCombat) · uid 299

<img src="../../icons/sk_299.png" width="40" alt="icon"> 
**Tree:** ナイフスキル (`KnifeSkill`, tier 3) · **Type:** Special · **Max Lv:** 50 · **Weapons:** ShortSword · **Requires:** อินเทนซีฟไนฟ์ · **Client class:** `KnifeCombatAction`

> เปลี่ยนการโจมตีปกติเป็นการโจมตีด้วยดาบสั้น
> เพิ่มอัตราคริติคอลและฟื้นฟู MP การโจมตี
> ลดการใช้ Avoid ระหว่างการโจมตีปกติ
> ความเคยชินทั่วไปจะหายไป
> เอฟเฟกต์จะสิ้นสุดลงเมื่อใช้สกิลอื่น

**How it works**

- Special skill of the ナイフスキル tree (tier 3, max Lv 50); usable with ShortSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Its buff exposes motion / combo hooks, so it changes the attack pattern while active (heuristic; the client has no explicit flag).
- Its buff raises normal-attack damage (`NormalAttackRate` / `NormalAttackConstantDamage`).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 18]: skill multiplier ×1
  - `calcPlayerToMobDamage` [EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 18]: skill multiplier depends on live values (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Buffs:
  - `KnifeCombatBuf`
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (10 lookups; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(4)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionStart` — when the cast starts: 2 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 set, 3 tpl, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((100 + EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function)) / 100)` — EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 18

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((100 + EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[LastDamageRate]` = `PlayerAttackBase.CalcLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus(), KnifeCombatAction.get_AttackType())`
  - when `(SkillParam & 32) ne 0 AND MobaMode eq 0 AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) OR (SkillParam & 32) ne 0 AND MobaMode eq 0 AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) AND TryGetProperties<object>.out2(mobAction, 90) ne 0 OR (SkillParam & 32) ne 0 AND MobaMode eq 0 AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) AND TryGetProperties<object>.out2(mobAction, 90) eq 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[LastDamageRate]` = `-MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90))`
  - when `(SkillParam & 32) ne 0 AND MobaMode eq 0 AND SkillActionBase.checkPercent(this, 100, SkillMasteryBase.GetMasteryParam(MasteryId.Trigger)) AND TryGetProperties<object>.out2(mobAction, 90) ne 0`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 299
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): constructs `KnifeCombatBuf` — `.ctor(Lv, actarAction)`
  - when `!PlayerAttackBase.IsBlank(this) OR !PlayerAttackBase.IsBlank(this) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 82) ne 0 OR !PlayerAttackBase.IsBlank(this) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 82) eq 0`
- `ActionStart` (when the cast starts): adds the caster's buff of `new KnifeCombatBuf` — `AddSelfBuffer(new KnifeCombatBuf, 0)`
  - when `!PlayerAttackBase.IsBlank(this) OR !PlayerAttackBase.IsBlank(this) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 82) ne 0 OR !PlayerAttackBase.IsBlank(this) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 82) eq 0`

**Buff values** (every recovered field; durations in seconds)

**Buff `KnifeCombatBuf`**
- **Changes the attack pattern**: the buff object drives a motion/combo chain (`CheckTake`, `TakeEvent`, `get_KnifeTakeId`).
- **Boosts normal-attack damage** through the `NormalAttackRate` / `NormalAttackConstantDamage` parameters.
- Buff hook methods: `<TakeEvent>b__19_0`, `CheckTake`, `IsBattleActive`, `TakeEvent`, `TakeStop`, `get_KnifeTakeId`
- `NormalAttackRate` = `normalAtkRate` _(when BuffEffectActive ne 0)_
- `Value` = `(100 - avoidStackRegist)` _(when BuffEffectActive ne 0)_
- `AttackMprecoveryUp` = `atkMpRecovery` _(when BuffEffectActive ne 0)_
- `CrtUp` = `crtUp` _(when BuffEffectActive ne 0)_
- Buff fields set in the constructor (all recovered):
  - `actionManager` = `playerAction`
  - `takeController` = `UnityEngine.Component.GetComponent<TakeController>(playerAction)`
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:KnifeCombatBuf$$.ctor<-KnifeCombatAction$$ActionStart` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

Parameter meanings (inferred from the `SkillBufferId` names):

- `AttackMprecoveryUp`: MP recovered per attack (flat)
- `CrtUp`: critical rate +
- `NormalAttackRate`: normal-attack damage multiplier (%)
- `Value`: generic value (meaning set by the code that reads the buff)

**In-game level notes**

- Lv18: การโจมตีปกติระหว่างไนฟ์คอมแบทจะแข็งแกร่งขึ้นตาม แซคเคิลอาร์ม, อินเทนซีฟไนฟ์ และเมลเบรคเกอร์ที่ได้เรียนรู้

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
- Effect applied in `MobaPlayerSecondaryStatus$$GetCrtConstant` (298 guarded paths, truncated):
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
- Effect applied in `PlayerBattleManager$$CheckZeroActionDelay` (12 guarded paths):
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
  - always
    - returns `0`
    - calls `PlayerStatusBase$$CheckBodyAbility`, `GemCartBufferManager$$GetGemCartBuffer`, `GemCartBufferBase$$GetValue`
- Effect applied in `FlinchKnifeAction$$ActionStart` (4 guarded paths):
  - when `(SkillLv(299) & 255) ne 0` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 82, stkp(-56), meta(0x399f228, Method$SkillBufferManager.TryGetBuf<TwinStormBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
    - returns `TwinStormBuf.ChangeTwinStorm(TryGetBuf<object>.out2(), 0, 0, ?x3)`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `SkillBufferManager$$GetSkillBufferFlagMachBuffer`, `0x165db78`, `KnifeCombatBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `TwinStormBuf$$ChangeTwinStorm`
  - when `(SkillLv(299) & 255) ne 0` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 82, stkp(-56), meta(0x399f228, Method$SkillBufferManager.TryGetBuf<TwinStormBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() eq 0`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `SkillBufferManager$$GetSkillBufferFlagMachBuffer`, `0x165db78`, `KnifeCombatBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `0x165db84`
  - when `(SkillLv(299) & 255) ne 0` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 82, stkp(-56), meta(0x399f228, Method$SkillBufferManager.TryGetBuf<TwinStormBuf>())) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf<object>(?blr, 82, stkp(-56), meta(0x399f228, Method$SkillBufferManager.TryGetBuf<TwinStormBuf>()))`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `SkillBufferManager$$GetSkillBufferFlagMachBuffer`, `0x165db78`, `KnifeCombatBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
  - when `(SkillLv(299) & 255) eq 0`
    - returns `SkillLv(299)`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `SkillBufferManager$$GetSkillBufferFlagMachBuffer`
- Effect applied in `WheelBiteAction.<>c__DisplayClass31_0$$<ActionStart>b__0` (4 guarded paths):
  - when `SkillLv(299) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 82, stkp(-56), meta(0x399f228, Method$SkillBufferManager.TryGetBuf<TwinStormBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
    - returns `SkillBufferManager.RemoveBuffer(?blr, 302, 0, ?x3)`
    - calls `SkillBufferManager$$GetSkillBufferFlagMachBuffer`, `0x165db78`, `KnifeCombatBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `TwinStormBuf$$ChangeTwinStorm`, `SkillBufferManager$$RemoveBuffer`
  - when `SkillLv(299) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 82, stkp(-56), meta(0x399f228, Method$SkillBufferManager.TryGetBuf<TwinStormBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() eq 0`
    - calls `SkillBufferManager$$GetSkillBufferFlagMachBuffer`, `0x165db78`, `KnifeCombatBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `0x165db84`
  - when `SkillLv(299) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 82, stkp(-56), meta(0x399f228, Method$SkillBufferManager.TryGetBuf<TwinStormBuf>())) & 1) eq 0`
    - returns `SkillBufferManager.RemoveBuffer(?blr, 302, 0, ?x3)`
    - calls `SkillBufferManager$$GetSkillBufferFlagMachBuffer`, `0x165db78`, `KnifeCombatBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `SkillBufferManager$$RemoveBuffer`
  - when `SkillLv(299) lt 1`
    - returns `SkillBufferManager.RemoveBuffer(?blr, 302, 0, ?x3)`
    - calls `SkillBufferManager$$GetSkillBufferFlagMachBuffer`, `SkillBufferManager$$RemoveBuffer`
- Effect applied in `AvoidActionManager$$AvoidMove` (115 guarded paths):
  - when `CharacterActionManagerBase.get_IsLocalDead() eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 299, stkp(-96), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.RemoveBuffer(?blr, 1006, 0, ?x3)`
    - set `AvoidStack` = `max((AvoidStack - AssaultChaseAction.CalcAvoidConsumptionReduction(actionManager, int(((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) * 1000) / 100)), 0, ?x3)), 0)`
    - set `emergencyTimer` = `5`
    - calls `AvoidActionManager$$get_SkillActionManager`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `AvoidActionManager$$get_SkillActionManager`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `NormalAttackAction$$get_IsKnifeCombat`, `SkillBufferDataBase$$GetParam`, `SkillBufferManager$$SuspendedSong`
  - when `CharacterActionManagerBase.get_IsLocalDead() eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 299, stkp(-96), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `AvoidActionManager.get_AvoidCount(this, ?x1, ?x2, ?x3)`
    - set `AvoidStack` = `max((AvoidStack - AssaultChaseAction.CalcAvoidConsumptionReduction(actionManager, int(((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) * 1000) / 100)), 0, ?x3)), 0)`
    - set `emergencyTimer` = `5`
    - calls `AvoidActionManager$$get_SkillActionManager`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `AvoidActionManager$$get_SkillActionManager`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `NormalAttackAction$$get_IsKnifeCombat`, `SkillBufferDataBase$$GetParam`, `SkillBufferManager$$SuspendedSong`
  - when `CharacterActionManagerBase.get_IsLocalDead() eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 299, stkp(-96), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - set `AvoidStack` = `max((AvoidStack - AssaultChaseAction.CalcAvoidConsumptionReduction(actionManager, int(((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) * 1000) / 100)), 0, ?x3)), 0)`
    - calls `AvoidActionManager$$get_SkillActionManager`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `AvoidActionManager$$get_SkillActionManager`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `NormalAttackAction$$get_IsKnifeCombat`, `SkillBufferDataBase$$GetParam`, `SkillBufferManager$$SuspendedSong`
  - when `CharacterActionManagerBase.get_IsLocalDead() eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 299, stkp(-96), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - set `AvoidStack` = `max((AvoidStack - AssaultChaseAction.CalcAvoidConsumptionReduction(actionManager, int(((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) * 1000) / 100)), 0, ?x3)), 0)`
    - calls `AvoidActionManager$$get_SkillActionManager`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `AvoidActionManager$$get_SkillActionManager`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `NormalAttackAction$$get_IsKnifeCombat`, `SkillBufferDataBase$$GetParam`, `SkillBufferManager$$SuspendedSong`
  - when `CharacterActionManagerBase.get_IsLocalDead() eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 299, stkp(-96), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - set `AvoidStack` = `max((AvoidStack - AssaultChaseAction.CalcAvoidConsumptionReduction(actionManager, int(((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) * 1000) / 100)), 0, ?x3)), 0)`
    - calls `AvoidActionManager$$get_SkillActionManager`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `AvoidActionManager$$get_SkillActionManager`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `NormalAttackAction$$get_IsKnifeCombat`, `SkillBufferDataBase$$GetParam`, `SkillBufferManager$$SuspendedSong`
  - when `CharacterActionManagerBase.get_IsLocalDead() eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 299, stkp(-96), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - set `AvoidStack` = `max((AvoidStack - AssaultChaseAction.CalcAvoidConsumptionReduction(actionManager, int(((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) * 1000) / 100)), 0, ?x3)), 0)`
    - calls `AvoidActionManager$$get_SkillActionManager`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `AvoidActionManager$$get_SkillActionManager`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `NormalAttackAction$$get_IsKnifeCombat`, `SkillBufferDataBase$$GetParam`, `SkillBufferManager$$SuspendedSong`
  - when `CharacterActionManagerBase.get_IsLocalDead() eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 299, stkp(-96), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - set `AvoidStack` = `max((AvoidStack - AssaultChaseAction.CalcAvoidConsumptionReduction(actionManager, int(((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) * 1000) / 100)), 0, ?x3)), 0)`
    - calls `AvoidActionManager$$get_SkillActionManager`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `AvoidActionManager$$get_SkillActionManager`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `NormalAttackAction$$get_IsKnifeCombat`, `SkillBufferDataBase$$GetParam`, `SkillBufferManager$$SuspendedSong`
  - when `CharacterActionManagerBase.get_IsLocalDead() eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 299, stkp(-96), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.RemoveBuffer(?blr, 1006, 0, ?x3)`
    - set `AvoidStack` = `max((AvoidStack - int(((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) * 1000) / 100))), 0)`
    - set `emergencyTimer` = `5`
    - calls `AvoidActionManager$$get_SkillActionManager`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `AvoidActionManager$$get_SkillActionManager`, `virtual CharacterActionManagerBase.get_IsLocalDead`, `NormalAttackAction$$get_IsKnifeCombat`, `SkillBufferDataBase$$GetParam`, `SkillBufferManager$$SuspendedSong`
- Effect applied in `PlayerSecondaryStatus$$GetCrtConstant` (298 guarded paths, truncated):
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
- Code that reads this skill's level / buff by constant id: `AvoidActionManager$$AvoidMove (TryGetBuf)`, `FlinchKnifeAction$$ActionStart (GetSkillLv)`, `MobaPlayerBattleManager$$OnSkillActionEnd (ContainsBuffer)`, `MobaPlayerSecondaryStatus$$GetCrtConstant (TryGetBuf)`, `NormalAttackAction$$OnInitialize (ContainsBuffer)`, `PlayerAttackBase$$RemoveAfterSkillBuf (ContainsBuffer)`, `PlayerBattleManager$$CheckZeroActionDelay (ContainsBuffer)`, `PlayerSecondaryStatus$$GetCrtConstant (TryGetBuf)`, `UIFishingPanelManager$$StartFishingResponse (TryGetBuf)`, `WheelBiteAction.<>c__DisplayClass31_0$$<ActionStart>b__0 (GetSkillLv)`

_Raw recovered data (every method item): [trees/KnifeSkill.md](../trees/KnifeSkill.md) — uid 299_

---

### อเมซซิ่งโธร์ว (ThreateningThorwArts) · uid 294

<img src="../../icons/sk_294.png" width="40" alt="icon"> 
**Tree:** ナイフスキル (`KnifeSkill`, tier 4) · **Type:** Mastery · **Max Lv:** 110 · **Weapons:** ShortSword · **Requires:** แกตติ้งไนฟ์ · **Client class:** `ThreateningThorwArts` (passive mastery)

> ใช้เทคนิคการขว้างอันยอดเยี่ยม
> มีโอกาสเพิ่มจำนวนฮิตให้กับสกิลมีดทั้งหมด

**How it works**

- Mastery skill of the ナイフスキル tree (tier 4, max Lv 110); usable with ShortSword.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

- `Trigger` = `(id ne 26 ? (Lv + (Lv << 1)) : 1)`

Bonus meanings (inferred from the names):

- `Trigger`: trigger chance (%)

_Raw recovered data (every method item): [trees/KnifeSkill.md](../trees/KnifeSkill.md) — uid 294_

---

### เมลเบรคเกอร์ (MailBreaker) · uid 298

<img src="../../icons/sk_298.png" width="40" alt="icon"> 
**Tree:** ナイフスキル (`KnifeSkill`, tier 4) · **Type:** Mastery · **Max Lv:** 110 · **Weapons:** ShortSword · **Requires:** อินเทนซีฟไนฟ์ · **Client class:** `MailBreaker` (passive mastery)

> เพิกเฉยต่อค่า DEP บางส่วนเมื่อใช้แซคเคิลอาร์ม
> การโจมตีปกติในครั้งต่อไปมีโอกาสเล็กน้อยที่จะติดอัตราคริติคอล +75
> ฟื้นฟู MP การโจมตี +100% 

**How it works**

- Mastery skill of the ナイフスキル tree (tier 4, max Lv 110); usable with ShortSword.
- It installs a buff on the caster.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Buffs:
  - `MailBreakerBuf`; Lv1 → Lv10: CrtUp (critical rate +) 75 → 75, AttackMprecoveryUpRate (MP recovered per attack (%)) 100 → 100
- Passive modifiers (negative = penalty): Trigger (trigger chance (%)) 14 at Lv1 to 50 at Lv10, Percent (generic percent) 1 at Lv1 to 10 at Lv10.

**Buff values** (every recovered field; durations in seconds)

**Buff `MailBreakerBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| CrtUp | 75 | 75 | 75 | 75 | 75 | 75 | 75 | 75 | 75 | 75 |
| AttackMprecoveryUpRate | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

- Buff fields set in the constructor (all recovered):
  - `critical` = `75` = 75

Parameter meanings (inferred from the `SkillBufferId` names):

- `AttackMprecoveryUpRate`: MP recovered per attack (%)
- `CrtUp`: critical rate +

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Trigger | 14 | 18 | 22 | 26 | 30 | 34 | 38 | 42 | 46 | 50 |
| Percent | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


Bonus meanings (inferred from the names):

- `Trigger`: trigger chance (%)
- `Percent`: generic percent

_Raw recovered data (every method item): [trees/KnifeSkill.md](../trees/KnifeSkill.md) — uid 298_

---

### ฟินเชอร์ไนฟ์ / ไนฟ์สไตล์ (FlinchKnife) · uid 300

<img src="../../icons/sk_300.png" width="40" alt="icon"> 
**Tree:** ナイフスキル (`KnifeSkill`, tier 4) · **Type:** Attack · **Max Lv:** 110 · **Weapons:** ShortSword · **Requires:** ไนฟ์คอมแบท · **Client class:** `FlinchKnifeAction`

> เมื่อตกเป็นเป้าหมายมีโอกาสติด "ผงะ"
> และเข้าสู่สถานะไนฟ์คอมแบท
> ถ้าไม่ตกเป็นเป้าหมายจะไม่ติดผงะ
> แต่พลังกับอาวุธเจาะเข้าจะเพิ่มขึ้นแทน

**How it works**

- Attack skill of the ナイフスキル tree (tier 4, max Lv 110); usable with ShortSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- It can inflict a status ailment (chance and type below).
- Its buff exposes motion / combo hooks, so it changes the attack pattern while active (heuristic; the client has no explicit flag).
- Its buff raises normal-attack damage (`NormalAttackRate` / `NormalAttackConstantDamage`).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 18]: skill multiplier ×2.2 at Lv1 to 4 at Lv10
  - `calcPlayerToMobDamage` [EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 18]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [UnityEngine.Object.op_Inequality(MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)), UnityEngine.Component.get_gameObject(actarAction)) OR !UnityEngine.Object.op_Inequality(MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)), UnityEngine.Component.get_gameObject(actarAction)) AND isFightingKnife ne 0]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage`: flat damage +30 at Lv1 to 300 at Lv10
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Flinch (1).
- Buffs:
  - `KnifeCombatBuf`
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(4)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 5 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionPreparation` — before the cast starts: 5 set
- `ActionStart` — when the cast starts: 2 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 2 call, 1 info
- `GetLocalizeKey` — skill-specific method: 1 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 2.2 | 2.4 | 2.6 | 2.8 | 3 | 3.2 | 3.4 | 3.6 | 3.8 | 4 |
| Flat dmg + | 30 | 60 | 90 | 120 | 150 | 180 | 210 | 240 | 270 | 300 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv * 20) + 200) + ((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function >> 15)) >> 1))) / 100)` — EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 18
- SkillRate × `(((((Lv * 20) + 200) + ((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function >> 15)) >> 1))) / 100)` — UnityEngine.Object.op_Inequality(MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)), UnityEngine.Component.get_gameObject(actarAction)) OR !UnityEngine.Object.op_Inequality(MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)), UnityEngine.Component.get_gameObject(actarAction)) AND isFightingKnife ne 0

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv * 20) + 200) + ((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function + (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function >> 15)) >> 1))) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `((Lv * 30))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 300
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Chance field `flinchPercent` (Flinch chance (%)): `(((Lv + (Lv << 2)) << 2) lo 100 ? ((Lv + (Lv << 2)) << 2) : 100)` → Lv1..10 [20, 40, 60, 80, 100, 100, 100, 100, 100, 100]
  - when `!UnityEngine.Object.op_Inequality(MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target)), UnityEngine.Component.get_gameObject(actarAction)) AND isFightingKnife eq 0`
- Rolls `flinchPercent`% to inflict **Flinch (1)** (`calcPlayerToMobDamage`)
- Uses the default ailment duration (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 1, flinchPercent, playerAction)`

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): constructs `KnifeCombatBuf` — `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 299, 1), actarAction)`
  - when `!PlayerAttackBase.IsBlank(this) AND (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 299, 1) & 255) ne 0 AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) lt 1 OR !PlayerAttackBase.IsBlank(this) AND (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 299, 1) & 255) ne 0 AND (System.Linq.Enumerable.Any<SkillBufferDataBase>!SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000), FlinchKnifeAction.<>c.<>9__29_0) AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) ge 1 OR !PlayerAttackBase.IsBlank(this) AND (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 299, 1) & 255) ne 0 AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) lt 1 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 82) ne 0`
- `ActionStart` (when the cast starts): adds the caster's buff of `new KnifeCombatBuf` — `AddSelfBuffer(new KnifeCombatBuf, 0)`
  - when `!PlayerAttackBase.IsBlank(this) AND (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 299, 1) & 255) ne 0 AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) lt 1 OR !PlayerAttackBase.IsBlank(this) AND (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 299, 1) & 255) ne 0 AND (System.Linq.Enumerable.Any<SkillBufferDataBase>!SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000), FlinchKnifeAction.<>c.<>9__29_0) AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) ge 1 OR !PlayerAttackBase.IsBlank(this) AND (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 299, 1) & 255) ne 0 AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) lt 1 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 82) ne 0`

**Buff values** (every recovered field; durations in seconds)

**Buff `KnifeCombatBuf`**
- **Changes the attack pattern**: the buff object drives a motion/combo chain (`CheckTake`, `TakeEvent`, `get_KnifeTakeId`).
- **Boosts normal-attack damage** through the `NormalAttackRate` / `NormalAttackConstantDamage` parameters.
- Buff hook methods: `<TakeEvent>b__19_0`, `CheckTake`, `IsBattleActive`, `TakeEvent`, `TakeStop`, `get_KnifeTakeId`
- `NormalAttackRate` = `normalAtkRate` _(when BuffEffectActive ne 0)_
- `Value` = `(100 - avoidStackRegist)` _(when BuffEffectActive ne 0)_
- `AttackMprecoveryUp` = `atkMpRecovery` _(when BuffEffectActive ne 0)_
- `CrtUp` = `crtUp` _(when BuffEffectActive ne 0)_
- Buff fields set in the constructor (all recovered):
  - `actionManager` = `playerAction`
  - `takeController` = `UnityEngine.Component.GetComponent<TakeController>(playerAction)`
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:KnifeCombatBuf$$.ctor<-FlinchKnifeAction$$ActionStart` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

Parameter meanings (inferred from the `SkillBufferId` names):

- `AttackMprecoveryUp`: MP recovered per attack (flat)
- `CrtUp`: critical rate +
- `NormalAttackRate`: normal-attack damage multiplier (%)
- `Value`: generic value (meaning set by the code that reads the buff)

**In-game level notes**

- Lv18: เมื่อใช้สกิลนี้ได้อย่างแม่นยำ การเปิดใช้ "ดับเบิ้ลสแทบ" ในครั้งถัดไปจะเร็วขึ้นเป็นอย่างมาก  และเนื่องจากสกิลนี้ไม่ได้ใช้ทักษะในการขว้าง ดังนั้นจึงไม่เข้าข่ายของ "ดับเบิ้ลสแทบ" และ "อเมซซิ่งโธร์ว"

_Raw recovered data (every method item): [trees/KnifeSkill.md](../trees/KnifeSkill.md) — uid 300_

---

### เครซี่แดกเกอร์ (CrazyDagger) · uid 301

<img src="../../icons/sk_301.png" width="40" alt="icon"> 
**Tree:** ナイフスキル (`KnifeSkill`, tier 5) · **Type:** Object · **Max Lv:** 225 · **Weapons:** ShortSword · **Requires:** อเมซซิ่งโธร์ว · **Client class:** `CrazyDaggerAction`

> เรียกใช้มีดสั้นบินวนรอบตัวเพื่อจู่โจมศัตรู
> ปามีดสั้นเข้าใส่เป้าหมายเดิมหรือเป้าหมายอื่น
> ที่กำลังต่อสู้เพื่อสร้างความเสียหาย
> หลังการใช้สกิลโจมตีมีดสั้นจะลอยติดตามตัว
> และช่วยโจมตีสนับสนุนตามจังหวะการโจมตีปกติ

**How it works**

- Object skill of the ナイフスキル tree (tier 5, max Lv 225); usable with ShortSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- It places an object in the world (trap, summon or field object).
- `NormalAttackAction` looks its buff up and changes how normal attacks run while it is active.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [((1 << mainWeaponType) & 0x10401) ne 0 AND mainWeaponType ls 16 AND subWeapon == ShortSword OR ((1 << mainWeaponType) & 0x10401) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301) ne 0 AND mainWeaponType ls 16 AND subWeapon == ShortSword & System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) eq 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) ne 0 AND MobaMode ne 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [mainWeaponType hi 16 AND subWeapon == ShortSword OR TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301) ne 0 AND mainWeaponType hi 16 AND subWeapon == ShortSword OR ((1 << mainWeaponType) & 0x10401) eq 0 AND mainWeaponType ls 16 AND subWeapon == ShortSword & System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) eq 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) ne 0 AND MobaMode ne 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [((1 << mainWeaponType) & 0x10401) ne 0 AND mainWeaponType ls 16 AND subWeapon != ShortSword OR ((1 << mainWeaponType) & 0x10401) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301) ne 0 AND mainWeaponType ls 16 AND subWeapon != ShortSword & System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) eq 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) ne 0 AND MobaMode ne 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [mainWeaponType hi 16 AND subWeapon != ShortSword OR TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301) ne 0 AND mainWeaponType hi 16 AND subWeapon != ShortSword OR ((1 << mainWeaponType) & 0x10401) eq 0 AND mainWeaponType ls 16 AND subWeapon != ShortSword & System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) eq 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) ne 0 AND MobaMode ne 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) eq 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) ne 0 AND MobaMode ne 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0]: flat damage +200
- Proration: physical-skill proration slot, mode `first_hit_and_flag`.
- Buffs:
  - `CrazyDaggerBuf`; Lv1 → Lv10: Count (stack / hit counter) 1 → 1
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (6 lookups; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(16)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 11 set
- `ActionPreparation` — before the cast starts: 1 set
- `ActionStart` — when the cast starts: 1 set, 2 call
- `InitializeOthers` — setup used when another player's client replays the action: 3 set
- `ActionStartOthers` — skill-specific method: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 6 tpl, 1 info, 1 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((((GetSubWeaponType.item(actarAction).Function // 10) lt 50 ? (GetSubWeaponType.item(actarAction).Function // 10) : 50) + (((Lv << 4) - Lv) + 50)) + 50)) * System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>()))) / 100)` — ((1 << mainWeaponType) & 0x10401) ne 0 AND mainWeaponType ls 16 AND subWeapon == ShortSword OR ((1 << mainWeaponType) & 0x10401) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301) ne 0 AND mainWeaponType ls 16 AND subWeapon == ShortSword & System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) eq 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) ne 0 AND MobaMode ne 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0
- SkillRate × `(((((((GetSubWeaponType.item(actarAction).Function // 10) lt 50 ? (GetSubWeaponType.item(actarAction).Function // 10) : 50) + (((Lv << 4) - Lv) + 50)) + 50)) * System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>()))) / 100)` — mainWeaponType hi 16 AND subWeapon == ShortSword OR TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301) ne 0 AND mainWeaponType hi 16 AND subWeapon == ShortSword OR ((1 << mainWeaponType) & 0x10401) eq 0 AND mainWeaponType ls 16 AND subWeapon == ShortSword & System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) eq 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) ne 0 AND MobaMode ne 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0
- SkillRate × `(((((((GetSubWeaponType.item(actarAction).Function // 10) lt 50 ? (GetSubWeaponType.item(actarAction).Function // 10) : 50) + (((Lv << 4) - Lv) + 50)) + 50)) * System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>()))) / 100)` — ((1 << mainWeaponType) & 0x10401) ne 0 AND mainWeaponType ls 16 AND subWeapon != ShortSword OR ((1 << mainWeaponType) & 0x10401) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301) ne 0 AND mainWeaponType ls 16 AND subWeapon != ShortSword & System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) eq 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) ne 0 AND MobaMode ne 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0
- SkillRate × `(((((((GetSubWeaponType.item(actarAction).Function // 10) lt 50 ? (GetSubWeaponType.item(actarAction).Function // 10) : 50) + (((Lv << 4) - Lv) + 50)) + 50)) * System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>()))) / 100)` — mainWeaponType hi 16 AND subWeapon != ShortSword OR TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301) ne 0 AND mainWeaponType hi 16 AND subWeapon != ShortSword OR ((1 << mainWeaponType) & 0x10401) eq 0 AND mainWeaponType ls 16 AND subWeapon != ShortSword & System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) eq 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) ne 0 AND MobaMode ne 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(target.ExpDefSkill / 100)`
  - when `System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) eq 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) ne 0 AND MobaMode ne 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((((GetSubWeaponType.item(actarAction).Function // 10) lt 50 ? (GetSubWeaponType.item(actarAction).Function // 10) : 50) + (((Lv << 4) - Lv) + 50)) + 50)) * System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>()))) / 100)`
  - when `System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) eq 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) ne 0 AND MobaMode ne 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(200)`
  - when `System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) eq 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) ne 0 AND MobaMode ne 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[LastDamageRate]` = `PlayerAttackBase.CalcLastDamageRate(this, PlayerActionManagerBase.get_PlayerStatus(), CrazyDaggerAction.get_AttackType())`
  - when `(SkillParam & 32) ne 0 AND (SkillParam & 8) ne 0 AND MobaMode eq 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 32) ne 0 AND (SkillParam & 8) ne 0 AND MobaMode eq 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 AND TryGetProperties<object>.out2(mobAction, 90) ne 0 OR (SkillParam & 32) ne 0 AND (SkillParam & 8) ne 0 AND MobaMode eq 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 AND TryGetProperties<object>.out2(mobAction, 90) eq 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[LastDamageRate]` = `-MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90))`
  - when `(SkillParam & 32) ne 0 AND (SkillParam & 8) ne 0 AND MobaMode eq 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 AND TryGetProperties<object>.out2(mobAction, 90) ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`
  - when `System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) eq 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0 OR (SkillParam & 8) ne 0 AND MobaMode ne 0 AND System.Linq.Enumerable.Count<KeyValuePair<int, object>>(System.Linq.Enumerable.Where<KeyValuePair<int, object>>(targetList, new System.Func<KeyValuePair<int, MobActionManagerBase>, bool>, meta(0x39a8600, Method$System.Linq.Enumerable.Where<KeyValuePair<int, MobActionManagerBase>>())), meta(0x39a85f8, Method$System.Linq.Enumerable.Count<KeyValuePair<int, MobActionManagerBase>>())) ge 1 AND System.Linq.Enumerable.FirstOrDefault<SkillActionBase.DamageData>(damageDataList, new System.Func<SkillActionBase.DamageData, bool>) eq 0`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_and_flag`, attack type `Physics`, action id 301
- Uses the physical-skill proration slot; Proration changes on the first hit only, and only when the damage flag bit 1 is set.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301), 20)`
  - when `TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301) ne 0 AND mainWeaponType hi 16 AND subWeapon == ShortSword OR TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301) ne 0 AND mainWeaponType hi 16 AND subWeapon != ShortSword OR ((1 << mainWeaponType) & 0x10401) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301) ne 0 AND mainWeaponType ls 16 AND subWeapon == ShortSword`
- Loop / hit-repeat count (`LoopParam`): `1` = 1
  - when `mainWeaponType hi 16 AND subWeapon == ShortSword OR mainWeaponType hi 16 AND subWeapon != ShortSword OR ((1 << mainWeaponType) & 0x10401) ne 0 AND mainWeaponType ls 16 AND subWeapon == ShortSword`

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): constructs `CrazyDaggerBuf` — `.ctor(Lv, actarAction, 0)`
  - when `!PlayerAttackBase.IsBlank(this) AND (SkillBufferManager.TryGetBuf<CrazyDaggerBuf>!PlayerStatusBase.get_SkillBufferManager(), 301, (this + 336)) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND (SkillBufferManager.TryGetBuf<CrazyDaggerBuf>!PlayerStatusBase.get_SkillBufferManager(), 301, (this + 336)) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05`
- `ActionStart` (when the cast starts): adds the caster's buff of `new CrazyDaggerBuf` — `AddSelfBuffer(new CrazyDaggerBuf, Id)`
  - when `!PlayerAttackBase.IsBlank(this) AND (SkillBufferManager.TryGetBuf<CrazyDaggerBuf>!PlayerStatusBase.get_SkillBufferManager(), 301, (this + 336)) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND (SkillBufferManager.TryGetBuf<CrazyDaggerBuf>!PlayerStatusBase.get_SkillBufferManager(), 301, (this + 336)) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)))) le 1e-05`

**Other recovered parameters**

- **Loop / hit-repeat count** (`LoopParam`): `SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301), 20)` _(when TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301) ne 0 AND mainWeaponType hi 16 AND subWeapon == ShortSword OR TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301) ne 0 AND mainWeaponType hi 16 AND subWeapon != ShortSword OR ((1 << mainWeaponType) & 0x10401) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 301) ne 0 AND mainWeaponType ls 16 AND subWeapon == ShortSword)_; `1` = 1 _(when mainWeaponType hi 16 AND subWeapon == ShortSword OR mainWeaponType hi 16 AND subWeapon != ShortSword OR ((1 << mainWeaponType) & 0x10401) ne 0 AND mainWeaponType ls 16 AND subWeapon == ShortSword)_

**Buff values** (every recovered field; durations in seconds)

**Buff `CrazyDaggerBuf`**
- **Modifies normal attacks**: `NormalAttackAction` looks this buff up while it builds the normal-attack damage / hit logic.
- Buff hook methods: `AttackStart`, `Next`, `OtherAttackStart`, `SetCount`, `SkillAttack`, `SkillAttackOther`, `SkillEnd`, `SkillGuard`, `SkillStart`
- `Count` = `0` _(when BuffEffectActive eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Count | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 |

- Buff fields set in the constructor (all recovered):
  - `isOther` = `(False & 1)`
  - `Count` = `1` = 1
  - `Max` = `5` = 5
  - `playerAction` = `playerAction`
  - `effectManager` = `new CrazyDaggerBuf.EffectManager`
- Hook `SetCount`: `Count`=(count lt 0 ? 0 : (Max lt count ? Max : count))
- Hook `SkillGuard`: `Count`=CrazyDaggerBuf.EffectManager.get_KnifeNum(effectManager)
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:CrazyDaggerBuf$$.ctor<-CrazyDaggerAction$$ActionStart` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

Parameter meanings (inferred from the `SkillBufferId` names):

- `Count`: stack / hit counter

**In-game level notes**

- Lv18: หลังจากเปิดใช้งานเครซี่แดกเกอร์ การใช้สกิลมีดจะช่วยเพิ่มจำนวนมีดสั้นที่ลอยอยู่รอบตัว ยกเว้นสกิลพาสซีฟบางสกิล (สูงสุด 5 เล่ม) จำนวนมีดจะลดลงหากติดภาวะผิดปกติที่ทำให้ขยับไม่ได้ เช่น ผงะและล้มคว่ำ หรือมีดที่ปล่อยออกมาถูก Guard

**Where else this skill takes effect**

- Effect applied in `NormalAttackAction$$Damaged` (237 guarded paths, truncated):
  - when `(SkillIndividualFlag & 2) ne 0` AND `(MobActionManagerBase.get_IsDead(mobActionManager) & 1) eq 0` AND `(SkillIndividualFlag & 8) ne 0` AND `checkSamuraiArchery eq 0`
    - returns `CrazyDaggerBuf.AttackStart(TryGetBuf.out2(), playerActionManager, mobActionManager, 0)`
    - set `checkSamuraiArchery` = `1`
    - set `checkTwinStorm` = `1`
    - calls `interface MobActionManagerBase.get_IsDead`, `0x165db78`, `SamuraiArcheryBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `SamuraiArcheryBuf$$CountUp`, `PlayerAttackBase$$CheckSkillIndividualFlag`, `StormBlazerAction$$StackStormBlazer`, `IchijhinnokazeAction$$NormalAttackDamaged`
  - when `(SkillIndividualFlag & 2) ne 0` AND `(MobActionManagerBase.get_IsDead(mobActionManager) & 1) eq 0` AND `(SkillIndividualFlag & 8) ne 0` AND `checkSamuraiArchery eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 301, stkp(-72), 0)`
    - set `checkSamuraiArchery` = `1`
    - set `checkTwinStorm` = `1`
    - calls `interface MobActionManagerBase.get_IsDead`, `0x165db78`, `SamuraiArcheryBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `SamuraiArcheryBuf$$CountUp`, `PlayerAttackBase$$CheckSkillIndividualFlag`, `StormBlazerAction$$StackStormBlazer`, `IchijhinnokazeAction$$NormalAttackDamaged`
  - when `(SkillIndividualFlag & 2) ne 0` AND `(MobActionManagerBase.get_IsDead(mobActionManager) & 1) eq 0` AND `(SkillIndividualFlag & 8) ne 0` AND `checkSamuraiArchery eq 0`
    - returns `CrazyDaggerBuf.AttackStart(TryGetBuf.out2(), playerActionManager, mobActionManager, 0)`
    - set `checkSamuraiArchery` = `1`
    - set `checkTwinStorm` = `1`
    - calls `interface MobActionManagerBase.get_IsDead`, `0x165db78`, `SamuraiArcheryBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `SamuraiArcheryBuf$$CountUp`, `PlayerAttackBase$$CheckSkillIndividualFlag`, `StormBlazerAction$$StackStormBlazer`, `IchijhinnokazeAction$$NormalAttackDamaged`
  - when `(SkillIndividualFlag & 2) ne 0` AND `(MobActionManagerBase.get_IsDead(mobActionManager) & 1) eq 0` AND `(SkillIndividualFlag & 8) ne 0` AND `checkSamuraiArchery eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 301, stkp(-72), 0)`
    - set `checkSamuraiArchery` = `1`
    - set `checkTwinStorm` = `1`
    - calls `interface MobActionManagerBase.get_IsDead`, `0x165db78`, `SamuraiArcheryBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `SamuraiArcheryBuf$$CountUp`, `PlayerAttackBase$$CheckSkillIndividualFlag`, `StormBlazerAction$$StackStormBlazer`, `IchijhinnokazeAction$$NormalAttackDamaged`
  - when `(SkillIndividualFlag & 2) ne 0` AND `(MobActionManagerBase.get_IsDead(mobActionManager) & 1) eq 0` AND `(SkillIndividualFlag & 8) ne 0` AND `checkSamuraiArchery eq 0`
    - returns `CrazyDaggerBuf.AttackStart(TryGetBuf.out2(), playerActionManager, mobActionManager, 0)`
    - set `checkSamuraiArchery` = `1`
    - set `checkTwinStorm` = `1`
    - calls `interface MobActionManagerBase.get_IsDead`, `0x165db78`, `SamuraiArcheryBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `SamuraiArcheryBuf$$CountUp`, `PlayerAttackBase$$CheckSkillIndividualFlag`, `StormBlazerAction$$StackStormBlazer`, `CrazyDaggerBuf$$AttackStart`
  - when `(SkillIndividualFlag & 2) ne 0` AND `(MobActionManagerBase.get_IsDead(mobActionManager) & 1) eq 0` AND `(SkillIndividualFlag & 8) ne 0` AND `checkSamuraiArchery eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 301, stkp(-72), 0)`
    - set `checkSamuraiArchery` = `1`
    - set `checkTwinStorm` = `1`
    - calls `interface MobActionManagerBase.get_IsDead`, `0x165db78`, `SamuraiArcheryBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `SamuraiArcheryBuf$$CountUp`, `PlayerAttackBase$$CheckSkillIndividualFlag`, `StormBlazerAction$$StackStormBlazer`
  - when `(SkillIndividualFlag & 2) ne 0` AND `(MobActionManagerBase.get_IsDead(mobActionManager) & 1) eq 0` AND `(SkillIndividualFlag & 8) ne 0` AND `checkSamuraiArchery eq 0`
    - returns `CrazyDaggerBuf.AttackStart(TryGetBuf.out2(), playerActionManager, mobActionManager, 0)`
    - set `checkSamuraiArchery` = `1`
    - set `checkTwinStorm` = `1`
    - calls `interface MobActionManagerBase.get_IsDead`, `0x165db78`, `SamuraiArcheryBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `SamuraiArcheryBuf$$CountUp`, `PlayerAttackBase$$CheckSkillIndividualFlag`, `StormBlazerAction$$StackStormBlazer`, `CrazyDaggerBuf$$AttackStart`
  - when `(SkillIndividualFlag & 2) ne 0` AND `(MobActionManagerBase.get_IsDead(mobActionManager) & 1) eq 0` AND `(SkillIndividualFlag & 8) ne 0` AND `checkSamuraiArchery eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 301, stkp(-72), 0)`
    - set `checkSamuraiArchery` = `1`
    - set `checkTwinStorm` = `1`
    - calls `interface MobActionManagerBase.get_IsDead`, `0x165db78`, `SamuraiArcheryBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `SamuraiArcheryBuf$$CountUp`, `PlayerAttackBase$$CheckSkillIndividualFlag`, `StormBlazerAction$$StackStormBlazer`
- Effect applied in `CrazyDaggerPursuitAction$$OnInitialize` (18 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 301, stkp(-64), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add(meta(0), 7, PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `skillRate` = `((System.Math.Min((([GetSubWeaponType.out1()+0x42] // ((mul64([?blr+0x24], 0xae147ae1) >> 37) + 15)) + 50), 100, 0, ?x3) + 50) * SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3))`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `damageCount` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3)`
    - set `SkillIndividualFlag` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerStatusBase$$GetEquipElement`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$GetSubWeaponType`, `System.Math$$Min`, `PlayerAttackBase$$GetWeaponType`, `SkillBufferDataBase$$GetParam`, `0x165db78`, `SkillLinkedTake$$.ctor`
  - when `(SkillBufferManager.TryGetBuf(?blr, 301, stkp(-64), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `skillRate` = `(System.Math.Min((([GetSubWeaponType.out1()+0x42] // ((mul64([?blr+0x24], 0xae147ae1) >> 37) + 15)) + 50), 100, 0, ?x3) + 50)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - calls `PlayerStatusBase$$GetEquipElement`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$GetSubWeaponType`, `System.Math$$Min`, `PlayerAttackBase$$GetWeaponType`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(?blr, 301, stkp(-64), 0) & 1) eq 0`
    - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add(meta(0), 7, PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `skillRate` = `(System.Math.Min((([GetSubWeaponType.out1()+0x42] // ((mul64([?blr+0x24], 0xae147ae1) >> 37) + 15)) + 50), 100, 0, ?x3) + 50)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerStatusBase$$GetEquipElement`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$GetSubWeaponType`, `System.Math$$Min`, `PlayerAttackBase$$GetWeaponType`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
  - when `(SkillBufferManager.TryGetBuf(?blr, 301, stkp(-64), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add(meta(0), 7, PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `skillRate` = `(System.Math.Min((([GetSubWeaponType.out1()+0x42] // ((mul64([?blr+0x24], 0xae147ae1) >> 37) + 15)) + 50), 100, 0, ?x3) * SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3))`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `damageCount` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3)`
    - set `SkillIndividualFlag` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerStatusBase$$GetEquipElement`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$GetSubWeaponType`, `System.Math$$Min`, `PlayerAttackBase$$GetWeaponType`, `SkillBufferDataBase$$GetParam`, `0x165db78`, `SkillLinkedTake$$.ctor`
  - when `(SkillBufferManager.TryGetBuf(?blr, 301, stkp(-64), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `skillRate` = `System.Math.Min((([GetSubWeaponType.out1()+0x42] // ((mul64([?blr+0x24], 0xae147ae1) >> 37) + 15)) + 50), 100, 0, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - calls `PlayerStatusBase$$GetEquipElement`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$GetSubWeaponType`, `System.Math$$Min`, `PlayerAttackBase$$GetWeaponType`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(?blr, 301, stkp(-64), 0) & 1) eq 0`
    - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add(meta(0), 7, PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `skillRate` = `System.Math.Min((([GetSubWeaponType.out1()+0x42] // ((mul64([?blr+0x24], 0xae147ae1) >> 37) + 15)) + 50), 100, 0, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerStatusBase$$GetEquipElement`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$GetSubWeaponType`, `System.Math$$Min`, `PlayerAttackBase$$GetWeaponType`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
  - when `(SkillBufferManager.TryGetBuf(?blr, 301, stkp(-64), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `System.Collections.Generic.Dictionary<Int16Enum, int>.Add(meta(0), 7, PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3), meta(0x397a3a0, Method$System.Collections.Generic.Dictionary<TakeParameterType, int>.Add()))`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `skillRate` = `(System.Math.Min((([GetSubWeaponType.out1()+0x42] // ((mul64([?blr+0x24], 0xae147ae1) >> 37) + 15)) + 50), 100, 0, ?x3) * SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3))`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `damageCount` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3)`
    - set `SkillIndividualFlag` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerStatusBase$$GetEquipElement`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$GetSubWeaponType`, `System.Math$$Min`, `PlayerAttackBase$$GetWeaponType`, `SkillBufferDataBase$$GetParam`, `0x165db78`, `SkillLinkedTake$$.ctor`
  - when `(SkillBufferManager.TryGetBuf(?blr, 301, stkp(-64), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `skillRate` = `System.Math.Min((([GetSubWeaponType.out1()+0x42] // ((mul64([?blr+0x24], 0xae147ae1) >> 37) + 15)) + 50), 100, 0, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - calls `PlayerStatusBase$$GetEquipElement`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$GetSubWeaponType`, `System.Math$$Min`, `PlayerAttackBase$$GetWeaponType`, `0x165db84`
- Effect applied in `CrazyDaggerAction$$OnInitialize` (13 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 301, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `PlayerAttackBase.CalcMp(this, actarAction, 0, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `knifeNum` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3)`
    - set `skillRate` = `(((([GetSubWeaponType.out1()+0x42] // 10) lt 50 ? ([GetSubWeaponType.out1()+0x42] // 10) : 50) + (((Lv << 4) - Lv) + 50)) + 50)`
    - set `constantDamage` = `200`
    - set `SubWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, stkp(-64), 0, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `LoopParam` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3)`
    - calls `SkillActionBase$$OnInitialize`, `PlayerStatusBase$$GetEquipElement`, `MathUtil$$DisplayMeterToDistance`, `SkillBufferDataBase$$GetParam`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponType`, `0x165db78`, `SkillLinkedTake$$.ctor`
  - when `(SkillBufferManager.TryGetBuf(?blr, 301, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `PlayerAttackBase.CalcMp(this, actarAction, 0, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `knifeNum` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3)`
    - set `skillRate` = `((([GetSubWeaponType.out1()+0x42] // 10) lt 50 ? ([GetSubWeaponType.out1()+0x42] // 10) : 50) + (((Lv << 4) - Lv) + 50))`
    - set `constantDamage` = `200`
    - set `SubWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, stkp(-64), 0, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `LoopParam` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3)`
    - calls `SkillActionBase$$OnInitialize`, `PlayerStatusBase$$GetEquipElement`, `MathUtil$$DisplayMeterToDistance`, `SkillBufferDataBase$$GetParam`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponType`, `0x165db78`, `SkillLinkedTake$$.ctor`
  - when `(SkillBufferManager.TryGetBuf(?blr, 301, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `PlayerAttackBase.CalcMp(this, actarAction, 0, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `knifeNum` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3)`
    - set `skillRate` = `((([GetSubWeaponType.out1()+0x42] // 10) lt 50 ? ([GetSubWeaponType.out1()+0x42] // 10) : 50) + (((Lv << 4) - Lv) + 50))`
    - set `constantDamage` = `200`
    - set `SubWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, stkp(-64), 0, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `LoopParam` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3)`
    - calls `SkillActionBase$$OnInitialize`, `PlayerStatusBase$$GetEquipElement`, `MathUtil$$DisplayMeterToDistance`, `SkillBufferDataBase$$GetParam`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponType`, `0x165db78`, `SkillLinkedTake$$.ctor`
  - when `(SkillBufferManager.TryGetBuf(?blr, 301, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `PlayerAttackBase.CalcMp(this, actarAction, 0, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `knifeNum` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3)`
    - set `skillRate` = `((((Lv << 4) - Lv) + 50) + 50)`
    - set `constantDamage` = `200`
    - set `SubWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, stkp(-64), 0, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `LoopParam` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3)`
    - calls `SkillActionBase$$OnInitialize`, `PlayerStatusBase$$GetEquipElement`, `MathUtil$$DisplayMeterToDistance`, `SkillBufferDataBase$$GetParam`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponType`, `0x165db78`, `SkillLinkedTake$$.ctor`
  - when `(SkillBufferManager.TryGetBuf(?blr, 301, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `PlayerAttackBase.CalcMp(this, actarAction, 0, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `knifeNum` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3)`
    - set `skillRate` = `(((Lv << 4) - Lv) + 50)`
    - set `constantDamage` = `200`
    - set `SubWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, stkp(-64), 0, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `LoopParam` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3)`
    - calls `SkillActionBase$$OnInitialize`, `PlayerStatusBase$$GetEquipElement`, `MathUtil$$DisplayMeterToDistance`, `SkillBufferDataBase$$GetParam`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponType`, `0x165db78`, `SkillLinkedTake$$.ctor`
  - when `(SkillBufferManager.TryGetBuf(?blr, 301, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `PlayerAttackBase.CalcMp(this, actarAction, 0, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `knifeNum` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3)`
    - set `skillRate` = `(((Lv << 4) - Lv) + 50)`
    - set `constantDamage` = `200`
    - set `SubWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, stkp(-64), 0, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `LoopParam` = `SkillBufferDataBase.GetParam(TryGetBuf.out2(), 20, 0, ?x3)`
    - calls `SkillActionBase$$OnInitialize`, `PlayerStatusBase$$GetEquipElement`, `MathUtil$$DisplayMeterToDistance`, `SkillBufferDataBase$$GetParam`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponType`, `0x165db78`, `SkillLinkedTake$$.ctor`
  - when `(SkillBufferManager.TryGetBuf(?blr, 301, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - calls `SkillActionBase$$OnInitialize`, `PlayerStatusBase$$GetEquipElement`, `MathUtil$$DisplayMeterToDistance`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(?blr, 301, stkp(-56), 0) & 1) eq 0`
    - returns `PlayerAttackBase.CalcMp(this, actarAction, 0, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `knifeNum` = `1`
    - set `skillRate` = `(((([GetSubWeaponType.out1()+0x42] // 10) lt 50 ? ([GetSubWeaponType.out1()+0x42] // 10) : 50) + (((Lv << 4) - Lv) + 50)) + 50)`
    - set `constantDamage` = `200`
    - set `SubWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, stkp(-64), 0, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `LoopParam` = `1`
    - calls `SkillActionBase$$OnInitialize`, `PlayerStatusBase$$GetEquipElement`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponType`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- Effect applied in `SkillBufferManager$$UpdateIndividualBuf` (8 guarded paths):
  - when `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.RemoveBuffer(this, 301, ?x2, ?x3)`
    - calls `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `SkillBufferManager$$RemoveBuffer`, `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `SkillBufferManager$$RemoveBuffer`
  - when `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.TryGetBuf(this, 301, stkp(-24), ?x3)`
    - calls `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `SkillBufferManager$$RemoveBuffer`
  - when `TryGetBuf.out2() ne 0`
    - returns `CharacterActionManagerBase.get_DefaultMoveSpeed()`
    - calls `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`
  - when `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.TryGetBuf(this, 301, stkp(-24), ?x3)`
    - calls `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`
  - when `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.RemoveBuffer(this, 301, ?x2, ?x3)`
    - calls `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `SkillBufferManager$$RemoveBuffer`
  - when `TryGetBuf.out2() ne 0`
    - returns `CharacterActionManagerBase.get_DefaultMoveSpeed()`
    - calls `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`
  - when `TryGetBuf.out2() eq 0`
    - calls `0x165db84`
  - always
    - returns `SkillBufferManager.TryGetBuf(this, 301, stkp(-24), ?x3)`
- Effect applied in `NormalAttackAction$$ActionPreparation` (198 guarded paths, truncated):
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
- Code that reads this skill's level / buff by constant id: `CrazyDaggerAction$$OnInitialize (TryGetBuf)`, `CrazyDaggerPursuitAction$$OnInitialize (TryGetBuf)`, `NormalAttackAction$$ActionPreparation (TryGetBuf)`, `NormalAttackAction$$Damaged (TryGetBuf)`, `PlayerAttackBase$$ActionStart (TryGetBuf)`, `SkillBufferManager$$UpdateIndividualBuf (TryGetBuf)`

_Raw recovered data (every method item): [trees/KnifeSkill.md](../trees/KnifeSkill.md) — uid 301_

---

### วีลไบต์ (WheelBite) · uid 302

<img src="../../icons/sk_302.png" width="40" alt="icon"> 
**Tree:** ナイフスキル (`KnifeSkill`, tier 5) · **Type:** Attack · **Max Lv:** 225 · **Weapons:** ShortSword · **Requires:** [N]ฟินเชอร์ไนฟ์[F]ไนฟ์สไตล์[N] · **Client class:** `WheelBiteAction`

> เทคนิคการใช้ดาบสั้นที่ผสานการหลบหลีกและการลอบจู่โจม
> ลดความเสียหายที่ได้รับขณะเคลื่อนที่พร้อมพุ่งเข้าประชิด
> เพื่อสร้างความเสียหายและเข้าสู่สถานะไนฟ์คอมแบท
> หากกดปุ่มทิศทางตรงข้ามกับด้านที่หันหน้าอยู่
> จะเป็นการยกเลิกการโจมตี

**How it works**

- Attack skill of the ナイフスキル tree (tier 5, max Lv 225); usable with ShortSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Its buff exposes motion / combo hooks, so it changes the attack pattern while active (heuristic; the client has no explicit flag).
- Its buff raises normal-attack damage (`NormalAttackRate` / `NormalAttackConstantDamage`).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×7.75 at Lv1 to 10 at Lv10; flat damage +400
  - `calcPlayerToMobDamage` [RecalcAvoidDamage !SkillCalcTemplate.CheckStepResult(damageTemplate, 1) AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 18]: skill multiplier depends on live values (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Buffs:
  - `KnifeCombatBuf`
  - `WheelBiteBuf`; Lv1 → Lv10: MobLastDamageRateUnique (final damage multiplier vs monsters (unique category)) 10 → 100
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (2 lookups; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(14)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `ActionStart` — when the cast starts: 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 2 tpl, 1 info
- `ActionSkillEvent` — on an animation/skill event during the motion: 2 set, 2 call
- `DamageAvoid` — skill-specific method: 1 set, 1 call
- `RecalcAvoidDamage` — skill-specific method: 2 tpl
- `.<>c__DisplayClass31_0::<ActionStart>b__0` — skill-specific method: 3 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 7.75 | 8 | 8.25 | 8.5 | 8.75 | 9 | 9.25 | 9.5 | 9.75 | 10 |
| Flat dmg + | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function << 1) lt 1000 ? (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function << 1) : 1000) / 100)` — RecalcAvoidDamage !SkillCalcTemplate.CheckStepResult(damageTemplate, 1) AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 18

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv * 25) + 750)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(400)`
- `RecalcAvoidDamage` (method): `SetConstant[Def]` = `0`
  - when `!SkillCalcTemplate.CheckStepResult(damageTemplate, 1) AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 18 OR !SkillCalcTemplate.CheckStepResult(damageTemplate, 1) AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) ne 18`
- `RecalcAvoidDamage` (method): `AddRate[SkillRate]` = `(((EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function << 1) lt 1000 ? (EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Function << 1) : 1000) / 100)`
  - when `!SkillCalcTemplate.CheckStepResult(damageTemplate, 1) AND EquipItemData.get_SubWeaponItemType(PlayerStatusBase.get_EquipItemData()) eq 18`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 302
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `ActionSkillEvent` (on an animation/skill event during the motion): adds the caster's buff of skill 302 (WheelBite) — `AddSelfBuffer(302, Lv, Id)`
  - when `UnityEngine.Object.op_Inequality(actarAction) AND param eq 100 AND param ne 101`
- `ActionSkillEvent` (on an animation/skill event during the motion): removes a target's buff of skill 302 (WheelBite) — `RemoveBuffer(302)`
  - when `UnityEngine.Object.op_Inequality(actarAction) AND param eq 101`
- `DamageAvoid` (method): removes a target's buff of skill 302 (WheelBite) — `RemoveBuffer(302)`
  - when `EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ne 9 AND checkAvoid ne 0 AND isAvoidSuccess eq 0 OR EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 9 AND checkAvoid ne 0 AND isAvoidSuccess eq 0`
- `.<>c__DisplayClass31_0::<ActionStart>b__0` (method): constructs `KnifeCombatBuf` — `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 299, 1), <>c__DisplayClass31_0.playerAction)`
  - when `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 299, 1) ge 1 AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) lt 1 OR (System.Linq.Enumerable.Any<SkillBufferDataBase>!SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000), WheelBiteAction.<>c.<>9__31_1) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 299, 1) ge 1 AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) ge 1 OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 299, 1) ge 1 AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) lt 1 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 82) ne 0`
- `.<>c__DisplayClass31_0::<ActionStart>b__0` (method): adds the caster's buff of `new KnifeCombatBuf` — `AddSelfBuffer(new KnifeCombatBuf, 0)`
  - when `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 299, 1) ge 1 AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) lt 1 OR (System.Linq.Enumerable.Any<SkillBufferDataBase>!SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000), WheelBiteAction.<>c.<>9__31_1) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 299, 1) ge 1 AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) ge 1 OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 299, 1) ge 1 AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) lt 1 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 82) ne 0`
- `.<>c__DisplayClass31_0::<ActionStart>b__0` (method): removes a target's buff of skill 302 (WheelBite) — `RemoveBuffer(302)`
  - when `(System.Linq.Enumerable.Any<SkillBufferDataBase>SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000), WheelBiteAction.<>c.<>9__31_1) AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) ge 1 OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 299, 1) ge 1 AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) lt 1 OR SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 299, 1) lt 1 AND System.Collections.Generic.ICollection<SkillBufferDataBase>#0(SkillBufferManager.GetSkillBufferFlagMachBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x18000)) lt 1`

**Buff values** (every recovered field; durations in seconds)

**Buff `KnifeCombatBuf`**
- **Changes the attack pattern**: the buff object drives a motion/combo chain (`CheckTake`, `TakeEvent`, `get_KnifeTakeId`).
- **Boosts normal-attack damage** through the `NormalAttackRate` / `NormalAttackConstantDamage` parameters.
- Buff hook methods: `<TakeEvent>b__19_0`, `CheckTake`, `IsBattleActive`, `TakeEvent`, `TakeStop`, `get_KnifeTakeId`
- `NormalAttackRate` = `normalAtkRate` _(when BuffEffectActive ne 0)_
- `Value` = `(100 - avoidStackRegist)` _(when BuffEffectActive ne 0)_
- `AttackMprecoveryUp` = `atkMpRecovery` _(when BuffEffectActive ne 0)_
- `CrtUp` = `crtUp` _(when BuffEffectActive ne 0)_
- Buff fields set in the constructor (all recovered):
  - `actionManager` = `playerAction`
  - `takeController` = `UnityEngine.Component.GetComponent<TakeController>(playerAction)`
**Buff `WheelBiteBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `CheckDamageInvalid`
- `MobLastDamageRateUnique` = `0` _(when BuffEffectActive eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MobLastDamageRateUnique | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |

- Buff fields set in the constructor (all recovered):
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
  - `BufEffectTakeUid` = `-1` = -1
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:KnifeCombatBuf$$.ctor<-WheelBiteAction.<>c__DisplayClass31_0$$<ActionStart>b__0` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

Parameter meanings (inferred from the `SkillBufferId` names):

- `AttackMprecoveryUp`: MP recovered per attack (flat)
- `CrtUp`: critical rate +
- `MobLastDamageRateUnique`: final damage multiplier vs monsters (unique category)
- `NormalAttackRate`: normal-attack damage multiplier (%)
- `Value`: generic value (meaning set by the code that reads the buff)

**In-game level notes**

- Lv9: *เมื่อลดความเสียหายสำเร็จจะไม่ติดคงกระพัน (แต่ผลของการเพิ่มความเสียหายจะยังคงทำงานอยู่)

**Where else this skill takes effect**

- Effect applied in `MobAttackBase$$InvalidDamage` (7 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 94, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 302, stkp(-24), 0) & 1) ne 0`
    - returns `1`
    - calls `WheelBiteBuf$$CheckDamageInvalid`
  - when `(SkillBufferManager.TryGetBuf(?blr, 94, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 302, stkp(-24), 0) & 1) ne 0`
    - returns `0`
    - calls `WheelBiteBuf$$CheckDamageInvalid`
  - when `(SkillBufferManager.TryGetBuf(?blr, 94, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 302, stkp(-24), 0) & 1) eq 0`
    - returns `0`
  - when `(SkillBufferManager.TryGetBuf(?blr, 94, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 302, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `1`
    - calls `WheelBiteBuf$$CheckDamageInvalid`
  - when `(SkillBufferManager.TryGetBuf(?blr, 94, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 302, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `0`
    - calls `WheelBiteBuf$$CheckDamageInvalid`
  - when `(SkillBufferManager.TryGetBuf(?blr, 94, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 302, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `0x165db84`, `0x165df00`
  - when `(SkillBufferManager.TryGetBuf(?blr, 94, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 302, stkp(-24), 0) & 1) eq 0`
    - returns `0`
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
- Code that reads this skill's level / buff by constant id: `MobAttackBase$$CalcLastDamage (TryGetBuf)`, `MobAttackBase$$InvalidDamage (TryGetBuf)`

_Raw recovered data (every method item): [trees/KnifeSkill.md](../trees/KnifeSkill.md) — uid 302_

---
