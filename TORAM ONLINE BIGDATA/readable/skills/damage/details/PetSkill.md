# ペット専用スキル (`PetSkill`) — skill details

27 entries.

### บาสต์แอคแทค (BusterAttack) · uid 929

<img src="../../icons/sk_929.png" width="40" alt="icon"> 
**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Attack · **Max Lv:** 1 · **Client class:** `BusterAttack`

> N$ทำการโจมตีทางกายภาพตามค่า ATK
> สร้างความเสียหายทางกายภาพอย่างรุนแรงแก่เป้าหมาย$S$การโจมตีกายภาพ/สร้างค่าความเสียหายอย่างรุนแรง

**How it works**

- Attack skill of the ペット専用スキル tree (tier 1, max Lv 1).
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×4.3 at Lv1 to 7 at Lv10; flat damage +1100 at Lv1 to 2000 at Lv10
- Proration: physical-skill proration slot, mode `first_hit_per_target`.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 4.3 | 4.6 | 4.9 | 5.2 | 5.5 | 5.8 | 6.1 | 6.4 | 6.7 | 7 |
| Flat dmg + | 1100 | 1200 | 1300 | 1400 | 1500 | 1600 | 1700 | 1800 | 1900 | 2000 |

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv * 30) + 400) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv * 100) + 1000))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 929
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 929_

---

### HP อัพ (PetHpUp) · uid 930

<img src="../../icons/sk_930.png" width="40" alt="icon"> 
**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 1 · **Client class:** `PetHpUp` (passive mastery)

> N$เพิ่ม HP สูงสุดของสัตว์เลี้ยง$S$สกิลติดตัว/เพิ่ม HP สูงสุด

**How it works**

- Mastery skill of the ペット専用スキル tree (tier 1, max Lv 1).
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): MaxHp (max HP) 500 at Lv1 to 5000 at Lv10, MaxHpRate (max HP %) 2 at Lv1 to 20 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MaxHp | 500 | 1000 | 1500 | 2000 | 2500 | 3000 | 3500 | 4000 | 4500 | 5000 |
| MaxHpRate | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |


Bonus meanings (inferred from the names):

- `MaxHp`: max HP
- `MaxHpRate`: max HP %

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 930_

---

### ดูดซับ MP (MPDrain) · uid 931

<img src="../../icons/sk_931.png" width="40" alt="icon"> 
**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 1

> N$เพิ่ม MP สูงสุดของสัตว์เลี้ยง$S$สกิลติดตัว/เพิ่ม MP สูงสุด

**How it works**

- Mastery skill of the ペット専用スキル tree (tier 1, max Lv 1).
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **no-client-code** — pet passive slot, client-inert: SkillId const + UI IsPassive bit only; no CreateMasterySkill case, no SkillId 931 constant/switch consumer in the binary.

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 931_

---

### ซ่อนตัว (PetHide) · uid 932

<img src="../../icons/sk_932.png" width="40" alt="icon"> 
**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 1 · **Client class:** `PetHide` (passive mastery)

> N$ซ่อนอยู่หลังเจ้าของเพื่อลดความเสียหายที่ได้รับ
> เจ้าของจะเป็นผู้รับความเสียหายส่วนที่ลดลง$S$สกิลติดตัว/รับความเสียหายบางส่วนแทนสัตว์เลี้ยง

**How it works**

- Mastery skill of the ペット専用スキル tree (tier 1, max Lv 1).
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): DamageTransferRate (damage transfer rate) 54 at Lv1 to 45 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| DamageTransferRate | 54 | 53 | 52 | 51 | 50 | 49 | 48 | 47 | 46 | 45 |


Bonus meanings (inferred from the names):

- `DamageTransferRate`: damage transfer rate

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 932_

---

### เมจิกแลนซ์ (SorciereLance) · uid 933

<img src="../../icons/sk_933.png" width="40" alt="icon"> 
**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Attack · **Max Lv:** 1 · **Client class:** `SorcielLance`

> N$ทำการโจมตีด้วยเวทมนตร์ตามค่า MATK
> สร้างค่าความเสียหายทางเวทมนตร์อย่างรุนแรงแก่เป้าหมาย$S$การโจมตีเวทมนตร์/สร้างความค่าเสียหายอย่างรุนแรงมาก

**How it works**

- Attack skill of the ペット専用スキル tree (tier 1, max Lv 1).
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×3.3 at Lv1 to 6 at Lv10; flat damage +2100 at Lv1 to 3000 at Lv10
- Proration: magic proration slot, mode `first_hit_per_target`.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `24` = 24

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 3.3 | 3.6 | 3.9 | 4.2 | 4.5 | 4.8 | 5.1 | 5.4 | 5.7 | 6 |
| Flat dmg + | 2100 | 2200 | 2300 | 2400 | 2500 | 2600 | 2700 | 2800 | 2900 | 3000 |

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv * 30) + 300) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv * 100) + 2000))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 933
- Uses the magic proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 933_

---

### คริติคอลอัพ (PetCriticalUp) · uid 934

<img src="../../icons/sk_934.png" width="40" alt="icon"> 
**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Buffer · **Max Lv:** 1 · **Client class:** `PetCriticalUp`

> N$เพิ่มความเสียหายคริติคอลให้สมาชิกปาร์ตี้ทุกคนชั่วขณะ
> เพิ่มความเสียหายคริติคอล$S$สนับสนุน/เพิ่มความเสียหายคริติคอลให้สมาชิกปาร์ตี้

**How it works**

- Buffer skill of the ペット専用スキル tree (tier 1, max Lv 1).
- It installs a buff on the caster.
- It installs a buff on other players / the party.
- Buffs:
  - `PetCriticalUpBuf`: lasts `10` s

**When each part runs**

- `OnPetSkillInitialize` — skill-specific method: 1 set
- `ActionHit` — when the attack connects: 1 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 934
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): adds a target's buff of `PlayerAttackBase.get_ActionID()` — `AddBuffer(PlayerAttackBase.get_ActionID(), Lv, 0)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Buff values** (every recovered field; durations in seconds)

**Buff `PetCriticalUpBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `10` s
- `CrtDmg` = `(Lv + (((value eq 1 ? 1 : 0)) << 1))` _(when BuffEffectActive ne 0)_
- `CrtDmg` = `0` _(when BuffEffectActive eq 0)_
- Buff fields set in the constructor (all recovered):
  - `isSupportSpecialty` = `(value eq 1 ? 1 : 0)`
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0

Parameter meanings (inferred from the `SkillBufferId` names):

- `CrtDmg`: critical damage

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 934_

---

### เฮวี่แอคแทค (HeavyAttack) · uid 935

<img src="../../icons/sk_935.png" width="40" alt="icon"> 
**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Attack · **Max Lv:** 1 · **Client class:** `HeavyAttack`

> N$ทำการโจมตีทางกายภาพตามค่า ATK
> สร้างค่าความเสียหายทางกายภาพอย่างรุนแรงแก่เป้าหมาย$S$การโจมตีกายภาพ/สร้างค่าความเสียหายอย่างรุนแรง

**How it works**

- Attack skill of the ペット専用スキル tree (tier 1, max Lv 1).
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×3.2 at Lv1 to 5 at Lv10; flat damage +40 at Lv1 to 400 at Lv10
- Proration: physical-skill proration slot, mode `first_hit_per_target`.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 3.2 | 3.4 | 3.6 | 3.8 | 4 | 4.2 | 4.4 | 4.6 | 4.8 | 5 |
| Flat dmg + | 40 | 80 | 120 | 160 | 200 | 240 | 280 | 320 | 360 | 400 |

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv * 20) + 300) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv + (Lv << 2)) << 3))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 935
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 935_

---

### ลอบโจมตี (SneakAttack) · uid 936

<img src="../../icons/sk_936.png" width="40" alt="icon"> 
**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Attack · **Max Lv:** 1 · **Client class:** `SneakAttack`

> N$การโจมตีที่ไม่เพิ่มค่าเฮท
> ถ้าสัตว์เลี้ยงมีค่า ATK สูงจะโจมตีทางกายภาพ
> ถ้า ค่า MATK สูงจะโจมตีด้วยเวทมนตร์$S$การโจมตีพิเศษ/ไม่ทำให้เกิดเฮท

**How it works**

- Attack skill of the ペット専用スキル tree (tier 1, max Lv 1).
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on live values (formula below); flat damage depends on live values (formula below)
- Proration: slot chosen at runtime (physical or magic by a per-cast flag), mode `first_hit_per_target`.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 2 tpl, 1 info

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `skillRate`
- Flat dmg + `fixAddDamage`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `skillRate`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `fixAddDamage`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `dynamic`, mode `first_hit_per_target`, attack type `dynamic`, action id 936
- Uses the slot chosen at runtime (physical or magic by a per-cast flag); Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 936_

---

### เมจิกชอต (MagicShot) · uid 937

<img src="../../icons/sk_937.png" width="40" alt="icon"> 
**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Attack · **Max Lv:** 1 · **Client class:** `MagicShot`

> N$ทำการโจมตีด้วยเวทมนตร์ตามค่า MATK
> สร้างค่าความเสียหายทางเวทมนตร์อย่างรุนแรงแก่เป้าหมาย$S$การโจมตีเวทมนตร์/สร้างความค่าเสียหายอย่างรุนแรง

**How it works**

- Attack skill of the ペット専用スキル tree (tier 1, max Lv 1).
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×2.2 at Lv1 to 4 at Lv10; flat damage +275 at Lv1 to 500 at Lv10
- Proration: magic proration slot, mode `first_hit_per_target`.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `24` = 24

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 2.2 | 2.4 | 2.6 | 2.8 | 3 | 3.2 | 3.4 | 3.6 | 3.8 | 4 |
| Flat dmg + | 275 | 300 | 325 | 350 | 375 | 400 | 425 | 450 | 475 | 500 |

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv * 20) + 200) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv * 25) + 250))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 937
- Uses the magic proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 937_

---

### บลาสต์แฟลร์ (BlastFlare) · uid 938

<img src="../../icons/sk_938.png" width="40" alt="icon"> 
**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Attack · **Max Lv:** 1 · **Client class:** `BlastFlare`

> N$ทำการโจมตีด้วยเวทมนตร์ตามค่า MATK
> โจมตีเป้าหมายและศัตรูที่อยู่รอบๆ
> ขอบเขตการโจมตีจะกว้างขึ้นเมื่อเลเวลสูงขึ้น$S$การโจมตีเวทมนตร์/สร้างความเสียหายแก่เป้าหมายและศัตรูที่อยู่รอบๆ

**How it works**

- Attack skill of the ペット専用スキル tree (tier 1, max Lv 1).
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on live values (formula below); flat damage depends on live values (formula below)
- Proration: magic proration slot, mode `first_hit_per_target`.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `24` = 24

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 1 info
- `ActionStart` — when the cast starts: 4 set

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `skillRate`
- Flat dmg + `fixAddDamage`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `skillRate`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `fixAddDamage`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 938
- Uses the magic proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 938_

---

### เซอร์เคิลฮีล (KreisHeel) · uid 939

<img src="../../icons/sk_939.png" width="40" alt="icon"> 
**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Heal · **Max Lv:** 1 · **Client class:** `KreisHeel`

> N$ฟื้นฟู HP ให้สมาชิกปาร์ตี้ทุกคน
> ปริมาณการฟื้นฟูจะขึ้นอยู่กับ MATK ของสัตว์เลี้ยง$S$ฮีล/ฟื้นฟู HP ของสมาชิกปาร์ตี้ทุกคนที่อยู่ใกล้

**How it works**

- Heal skill of the ペット専用スキル tree (tier 1, max Lv 1).
- It restores HP or MP.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `200` = 200

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 1 set
- `ActionHit` — when the attack connects: 3 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 939
- No proration slot: ExpType None: no proration slot.

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 939_

---

### กระตุ้นพลัง (BraveUp) · uid 940

<img src="../../icons/sk_940.png" width="40" alt="icon"> 
**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Buffer · **Max Lv:** 1 · **Client class:** `BraveUp`

> N$เพิ่ม ATK และ ASPD ให้สมาชิกปาร์ตี้ที่อยู่ใกล้ชั่วขณะ
> $S$สนับสนุน/เพิ่ม ATK และ ASPD ให้สมาชิกปาร์ตี้

**How it works**

- Buffer skill of the ペット専用スキル tree (tier 1, max Lv 1).
- It installs a buff on the caster.
- It installs a buff on other players / the party.
- Buffs:
  - `BraveUpBuf`: lasts `10` s; Lv1 → Lv10: Aspd (attack speed +) 120 → 300, AtkUpRate (ATK %) 1 → 10

**When each part runs**

- `OnPetSkillInitialize` — skill-specific method: 1 set
- `ActionHit` — when the attack connects: 1 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 940
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): adds a target's buff of `PlayerAttackBase.get_ActionID()` — `AddBuffer(PlayerAttackBase.get_ActionID(), Lv, 0)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Buff values** (every recovered field; durations in seconds)

**Buff `BraveUpBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `10` s
- `AtkUp` = `(((((value eq 1 ? 1 : 0)) eq 0 ? 0 : 25) + (Lv << 1)) + 30)` _(when BuffEffectActive ne 0)_
- `AspdRate` = `((((value eq 1 ? 1 : 0)) eq 0 ? 0 : 10) + Lv)` _(when BuffEffectActive ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Aspd | 120 | 140 | 160 | 180 | 200 | 220 | 240 | 260 | 280 | 300 |
| AtkUpRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |

- Buff fields set in the constructor (all recovered):
  - `isSupportSpecialty` = `(value eq 1 ? 1 : 0)`
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0

Parameter meanings (inferred from the `SkillBufferId` names):

- `Aspd`: attack speed +
- `AspdRate`: attack speed %
- `AtkUp`: ATK +
- `AtkUpRate`: ATK %

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 940_

---

### ปฐมพยาบาล (PetFirstAid) · uid 941

<img src="../../icons/sk_941.png" width="40" alt="icon"> 
**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Special · **Max Lv:** 1 · **Client class:** `PetFirstAid`

> N$ปฐมพยาบาลให้เจ้าของตอนที่หมดพลัง
> ลดเวลาที่รอเพื่อคืนชีพ$S$ฮีล/ปฐมพยาบาลให้เจ้าของตอนหมดพลัง

**How it works**

- Special skill of the ペット専用スキル tree (tier 1, max Lv 1).
- It installs a buff on the caster.
- Buffs:
  - `FirstAidBuf`; Lv1 → Lv10: FirstAidCost (First Aid MP cost) 200 → 1100

**Cost, timing and range**

- **MP cost** (`cost` in `OnInitialize`): `FirstAidBuf.GetParam(14)`
- **MP cost** (`cost` in `OnInitialize`): `100` = 100
- **ActionRange** (`ActionRange`): `6` = 6

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 941
- No proration slot: ExpType None: no proration slot.

**Other recovered parameters**

- **Cost** (`cost`): `FirstAidBuf.GetParam(14)`; `100` = 100

**Buff values** (every recovered field; durations in seconds)

**Buff `FirstAidBuf`**
- Attached to this skill via `caller2:SkillBufferManager$$UpdateFirstAidBuffer<-PetFirstAid$$ActionStart` (no direct constructor call in the skill's own code).
- Buff hook methods: `InvalidInvincible`, `LevelUp`, `ValidInvincible`
- `FirstAidCost` = `0` _(when BuffEffectActive eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| FirstAidCost | 200 | 300 | 400 | 500 | 600 | 700 | 800 | 900 | 1000 | 1100 |

- Buff fields set in the constructor (all recovered):
  - `_flag` = `2560` = 2560
  - `levelDownTimer` = `time`
- Hook `Updata`: `levelDownTimer`=((levelDownTimer - UnityEngine.Time.get_deltaTime()) + 60); `Level`=(Lv - 1); `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `LevelUp`: `Level`=(Lv + 1); `levelDownTimer`=60
- Hook `ValidInvincible`: `LeftTime`=time; `_flag`=((_flag & 0xffffe7ff) | 0x1000)
- Hook `InvalidInvincible`: `LeftTime`=0; `_flag`=((_flag & 0xffffe7ff) | 2048)

Parameter meanings (inferred from the `SkillBufferId` names):

- `FirstAidCost`: First Aid MP cost

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 941_

---

### เพิ่มกำลังใจ (MindUp) · uid 942

<img src="../../icons/sk_942.png" width="40" alt="icon"> 
**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Buffer · **Max Lv:** 1 · **Client class:** `MindUp`

> N$N$เพิ่ม MATK และ CSPD ให้สมาชิกปาร์ตี้ที่อยู่ใกล้ชั่วขณะ
> $S$สนับสนุน/เพิ่ม MATK และ CSPD ให้สมาชิกปาร์ตี้

**How it works**

- Buffer skill of the ペット専用スキル tree (tier 1, max Lv 1).
- It installs a buff on the caster.
- It installs a buff on other players / the party.
- Buffs:
  - `MindUpBuf`: lasts `10` s; Lv1 → Lv10: MAtkUpRate (MATK %) 1 → 10, CspdUp (cast speed +) 120 → 300

**When each part runs**

- `OnPetSkillInitialize` — skill-specific method: 1 set
- `ActionHit` — when the attack connects: 1 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 942
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): adds a target's buff of `PlayerAttackBase.get_ActionID()` — `AddBuffer(PlayerAttackBase.get_ActionID(), Lv, 0)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Buff values** (every recovered field; durations in seconds)

**Buff `MindUpBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `10` s
- `CspdUpRate` = `((((value eq 1 ? 1 : 0)) eq 0 ? 0 : 10) + Lv)` _(when BuffEffectActive ne 0)_
- `MatkUp` = `(((((value eq 1 ? 1 : 0)) eq 0 ? 0 : 25) + (Lv << 1)) + 30)` _(when BuffEffectActive ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MAtkUpRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| CspdUp | 120 | 140 | 160 | 180 | 200 | 220 | 240 | 260 | 280 | 300 |

- Buff fields set in the constructor (all recovered):
  - `isSupportSpecialty` = `(value eq 1 ? 1 : 0)`
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0

Parameter meanings (inferred from the `SkillBufferId` names):

- `CspdUp`: cast speed +
- `CspdUpRate`: cast speed %
- `MAtkUpRate`: MATK %
- `MatkUp`: MATK +

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 942_

---

### ฟื้นฟู (PetHealing) · uid 943

<img src="../../icons/sk_943.png" width="40" alt="icon"> 
**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Heal · **Max Lv:** 1 · **Client class:** `PetHealing`

> N$ฟื้นฟูให้ผู้เล่นที่มี HP เหลือน้อยที่สุด
> ปริมาณการฟื้นฟูจะขึ้นอยู่กับ MATK ของสัตว์เลี้ยง$S$ฮีล/ฟื้นฟูให้เป้าหมายที่มี HP เหลือน้อยที่สุด

**How it works**

- Heal skill of the ペット専用スキル tree (tier 1, max Lv 1).
- It restores HP or MP.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `200` = 200

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 943
- No proration slot: ExpType None: no proration slot.

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 943_

---

### สวีปแอคแทค (SweepAttack) · uid 944

<img src="../../icons/sk_944.png" width="40" alt="icon"> 
**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Attack · **Max Lv:** 1 · **Client class:** `SweepAttack`

> N$ทำการโจมตีทางกายภาพตามค่า ATK
> มีโอกาสทำให้เป้าหมาย[ล้มคว่ำ]$S$การโจมตีกายภาพ/มีโอกาสทำให้[ล้มคว่ำ]

**How it works**

- Attack skill of the ペット専用スキル tree (tier 1, max Lv 1).
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on live values (formula below); flat damage depends on live values (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Tumble (2).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 2 call, 1 info

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `skillRate`
- Flat dmg + `fixAddDamage`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `skillRate`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `fixAddDamage`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 944
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Rolls `abnormalPercent`% to inflict **Tumble (2)** (`calcPlayerToMobDamage`)
- Marks the hit with ailment **Tumble (2)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 2, abnormalPercent, playerAction)`

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 944_

---

### คลีนฮิต (DownBlow) · uid 945

<img src="../../icons/sk_945.png" width="40" alt="icon"> 
**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Attack · **Max Lv:** 1 · **Client class:** `DownBlow`

> N$ทำการโจมตีทางกายภาพตามค่า ATK
> มีโอกาสทำให้เป้าหมาย[ผงะ]$S$การโจมตีกายภาพ/มีโอกาสทำให้[ผงะ]

**How it works**

- Attack skill of the ペット専用スキル tree (tier 1, max Lv 1).
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on live values (formula below); flat damage depends on live values (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Flinch (1).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 2 call, 1 info

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `skillRate`
- Flat dmg + `fixAddDamage`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `skillRate`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `fixAddDamage`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 945
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Rolls `abnormalPercent`% to inflict **Flinch (1)** (`calcPlayerToMobDamage`)
- Marks the hit with ailment **Flinch (1)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 1, abnormalPercent, playerAction)`

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 945_

---

### เรจแอคแทค (RageAttack) · uid 946

<img src="../../icons/sk_946.png" width="40" alt="icon"> 
**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Attack · **Max Lv:** 1 · **Client class:** `RageAttack`

> N$การโจมตีที่ทำให้เกิดค่าเฮทสูง
> าสัตว์เลี้ยงมีค่า ATK สูงจะโจมตีทางกายภาพ
> ถ้า ค่า MATK สูงจะโจมตีด้วยเวทย์$S$การโจมตีพิเศษ/ทำให้เกิดเฮทจำนวนมาก

**How it works**

- Attack skill of the ペット専用スキル tree (tier 1, max Lv 1).
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on live values (formula below); flat damage depends on live values (formula below)
- Proration: slot chosen at runtime (physical or magic by a per-cast flag), mode `first_hit_per_target`.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 2 tpl, 1 info

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `skillRate`
- Flat dmg + `fixAddDamage`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `skillRate`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `fixAddDamage`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `dynamic`, mode `first_hit_per_target`, attack type `dynamic`, action id 946
- Uses the slot chosen at runtime (physical or magic by a per-cast flag); Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 946_

---

### บลายอิ้งแชโดว์ (BlindEye) · uid 947

<img src="../../icons/sk_947.png" width="40" alt="icon"> 
**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Attack · **Max Lv:** 1 · **Client class:** `BlindEye`

> N$ทำการโจมตีด้วยเวทมนตร์ตามค่า MATK
> มีโอกาสทำให้เป้าหมายติด[มืดบอด]$S$การโจมตีกายภาพ/มีโอกาสทำให้[มืดบอด]

**How it works**

- Attack skill of the ペット専用スキル tree (tier 1, max Lv 1).
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×0.6 at Lv1 to 1.5 at Lv10; flat damage +110 at Lv1 to 200 at Lv10
- Proration: magic proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Blindness (7).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `16` = 16

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 5 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 2 call, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.6 | 0.7 | 0.8 | 0.9 | 1 | 1.1 | 1.2 | 1.3 | 1.4 | 1.5 |
| Flat dmg + | 110 | 120 | 130 | 140 | 150 | 160 | 170 | 180 | 190 | 200 |

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv + (Lv << 2)) << 1) + 50) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `((((Lv + (Lv << 2)) << 1) + 100))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 947
- Uses the magic proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Chance field `abnormalPercent` (Chance to inflict the skill's status ailment (%)): `((Lv + (Lv << 1)) + 70)` = 73
- Rolls `abnormalPercent`% to inflict **Blindness (7)** (`calcPlayerToMobDamage`)
- Marks the hit with ailment **Blindness (7)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 7, abnormalPercent, playerAction)`

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 947_

---

### เพิ่มแรงต้านทาน (CutUp) · uid 948

<img src="../../icons/sk_948.png" width="40" alt="icon"> 
**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Buffer · **Max Lv:** 1 · **Client class:** `CutUp`

> N$N$เพิ่มความต้านทานทางกายภาพและต้านทานเวท
> ให้สมาชิกปาร์ตี้ที่อยู่ใกล้ชั่วขณะ
> $S$สนับสนุน/เพิ่มความต้านทานทางกายภาพและต้านทานเวทให้สมาชิกปาร์ตี้

**How it works**

- Buffer skill of the ペット専用スキル tree (tier 1, max Lv 1).
- It installs a buff on the caster.
- It installs a buff on other players / the party.
- Buffs:
  - `CutUpBuf`: lasts `10` s

**When each part runs**

- `OnPetSkillInitialize` — skill-specific method: 1 set
- `ActionHit` — when the attack connects: 1 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 948
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): adds a target's buff of `PlayerAttackBase.get_ActionID()` — `AddBuffer(PlayerAttackBase.get_ActionID(), Lv, 0)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Buff values** (every recovered field; durations in seconds)

**Buff `CutUpBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `10` s
- `PowerDmgCut` = `((((value eq 1 ? 1 : 0)) eq 0 ? 0 : 5) + (Lv + (Lv << 1)))` _(when BuffEffectActive ne 0)_
- `MagicDmgCut` = `((((value eq 1 ? 1 : 0)) eq 0 ? 0 : 5) + (Lv + (Lv << 1)))` _(when BuffEffectActive ne 0)_
- Buff fields set in the constructor (all recovered):
  - `isSupportSpecialty` = `(value eq 1 ? 1 : 0)`
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0

Parameter meanings (inferred from the `SkillBufferId` names):

- `MagicDmgCut`: magic damage taken reduction
- `PowerDmgCut`: physical damage taken reduction

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 948_

---

### สตันแอคแทค (StanAttack) · uid 949

<img src="../../icons/sk_949.png" width="40" alt="icon"> 
**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Attack · **Max Lv:** 1 · **Client class:** `StanAttack`

> N$ทำการโจมตีทางกายภาพตามค่า ATK
> มีโอกาสทำให้เป้าหมาย[หมดสติ]$S$การโจมตีกายภาพ/มีโอกาสทำให้[หมดสติ]

**How it works**

- Attack skill of the ペット専用スキル tree (tier 1, max Lv 1).
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on live values (formula below); flat damage depends on live values (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Stun (3).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 2 call, 1 info

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `skillRate`
- Flat dmg + `fixAddDamage`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `skillRate`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `fixAddDamage`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 949
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Rolls `abnormalPercent`% to inflict **Stun (3)** (`calcPlayerToMobDamage`)
- Marks the hit with ailment **Stun (3)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 3, abnormalPercent, playerAction)`

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 949_

---

### ปกป้อง (PetProtect) · uid 950

<img src="../../icons/sk_950.png" width="40" alt="icon"> 
**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 1 · **Client class:** `PetProtect` (passive mastery)

> N$ลดค่าความเสียหายที่เจ้าของได้รับ
> สัตว์เลี้ยงจะรับค่าความเสียหายส่วนที่ลดลง$S$สกิลติดตัว/สัตว์เลี้ยงจะรับความเสียหายบางส่วนแทนเจ้าของ

**How it works**

- Mastery skill of the ペット専用スキル tree (tier 1, max Lv 1).
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): DamageTransferRate (damage transfer rate) 54 at Lv1 to 45 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| DamageTransferRate | 54 | 53 | 52 | 51 | 50 | 49 | 48 | 47 | 46 | 45 |


Bonus meanings (inferred from the names):

- `DamageTransferRate`: damage transfer rate

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 950_

---

### ดูดซับ HP (HPDrain) · uid 951

<img src="../../icons/sk_951.png" width="40" alt="icon"> 
**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 1

> N$เปลี่ยนค่าความเสียหายบางส่วนที่ได้รับเป็น HP
> $S$สกิลติดตัว/ฟื้นฟู HP จากความเสียหายที่ได้รับบางส่วน

**How it works**

- Mastery skill of the ペット専用スキル tree (tier 1, max Lv 1).
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **no-client-code** — pet passive slot, client-inert: SkillId const + UI IsPassive bit only; no CreateMasterySkill case, no SkillId 951 constant/switch consumer in the binary.

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 951_

---

### MP อัพ (PetMpUp) · uid 952

<img src="../../icons/sk_952.png" width="40" alt="icon"> 
**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 1 · **Client class:** `PetMpUp` (passive mastery)

> N$เพิ่ม MP สูงสุดของสัตว์เลี้ยง$S$สกิลติดตัว/เพิ่ม MP สูงสุด

**How it works**

- Mastery skill of the ペット専用スキル tree (tier 1, max Lv 1).
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): MaxMp (max MP) 100 at Lv1 to 1000 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MaxMp | 100 | 200 | 300 | 400 | 500 | 600 | 700 | 800 | 900 | 1000 |


Bonus meanings (inferred from the names):

- `MaxMp`: max MP

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 952_

---

### ชีลเบรคเกอร์ (SealBreaker) · uid 953

<img src="../../icons/sk_953.png" width="40" alt="icon"> 
**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Attack · **Max Lv:** 1 · **Client class:** `SealBreaker`

> N$ทำการโจมตีด้วยเวทมนตร์ตามค่า MATK
> มีโอกาสทำให้เป้าหมาย[ลดการป้องกัน]$S$การโจมตีกายภาพ/มีโอกาสทำให้[ลดการป้องกัน]

**How it works**

- Attack skill of the ペット専用スキル tree (tier 1, max Lv 1).
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on live values (formula below); flat damage depends on live values (formula below)
- Proration: magic proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Breaking (10).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `16` = 16

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 2 call, 1 info

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `skillRate`
- Flat dmg + `fixAddDamage`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `skillRate`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `fixAddDamage`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 953
- Uses the magic proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Rolls `abnormalPercent`% to inflict **Breaking (10)** (`calcPlayerToMobDamage`)
- Marks the hit with ailment **Breaking (10)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 10, abnormalPercent, playerAction)`

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 953_

---

### การการโจมตีปกติ (กายภาพ) (PetPhysicalAttack) · uid 958

**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Attack · **Client class:** `PetNormalAttackAction`

> No Info Data...

**How it works**

- Attack skill of the ペット専用スキル tree (tier 1).
- It is a utility / system action (movement, state change) rather than a damage or buff skill.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 1 info

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 958
- No proration slot: ExpType None: no proration slot.

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 958_

---

### การโจมตีปกติ (เวทมนตร์) (PetMagicAttack) · uid 959

**Tree:** ペット専用スキル (`PetSkill`, tier 1) · **Type:** Attack · **Client class:** `PetNormalMagicAction`

> No Info Data...

**How it works**

- Attack skill of the ペット専用スキル tree (tier 1).
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(9)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 1 tpl, 1 info

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `ExtensionMethod.ExSkillData.SkillDataExtentionMethod.GetTargetExpRate(PetNormalMagicAction.get_AttackType(), PetNormalMagicAction.get_ActionID(), MobActionManagerBase.get_MobBattleStatus(mobAction))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 959
- No proration slot: ExpType None: no proration slot.

_Raw recovered data (every method item): [trees/PetSkill.md](../trees/PetSkill.md) — uid 959_

---
