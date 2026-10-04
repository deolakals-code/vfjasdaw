# Dual Sword skill tree — damage formulas

Source: Android `libil2cpp.so` (see `../_sources.md`). Every number below is read from code unless marked **(Inferred)**.
Addresses and raw instructions are in [`evidence.md`](evidence.md).

Notation
- `Lv` = level of the skill being used (1..10).
- `rate%` = the skill multiplier in percent. It is added to the template as `rate%/100`.
- `const` = skill constant damage (`SkillConstantDamage` step).
- `base STR/AGI/DEX` = stat points from `PlayerPrimaryStatus` (what you allocated, no equipment).
  `DEX (total)`, `AGI (total)` = the final stat from `IPlayerStatusCalculator` (after equipment/buffs).
- `/` on integers truncates toward zero.
- "split into n" = one damage number computed once, then shown as n hits: each hit `= dmg / n`, the first `dmg % n` hits get +1.
- "n templates" = n separate calculations, each with its own crit roll.

---

## 1. How one hit is computed (shared engine)

Every skill builds a `SkillCalcTemplate` (41 slots, one per `CalcStep`), fills it, and calls `GetDamage()`.

### 1.1 What the engine fills (`PlayerAttackBase.TemplateAssignment`)

| Step | Value put in |
|---|---|
| BaseDamage | `calcBaseDamage(...)`, see 1.3 |
| Def | `-CalcRegistDamage(...)` = −(target DEF or MDEF after pierce), see 1.4 |
| BufferConstantDamage | buff `SkillConstantDamage` param + ArkSaber constant (2.14) |
| CriticalRate | `CriticalDmg / 100` (magic: `CriticalMagicDmg / 100`) |
| ElementBonusRate | `CalcElementBonus` (element advantage) |
| NormalElementDamageResistRate | `CalcNormalElementWeaponDamageResistRate` |
| StableRate | `CalcStable(type, Stability, graze, status)` |
| ExpRate | target proration (`GetTargetExpRate`), see `../proration/` |
| TypeDamageRate | `CalcSkillTypeBonusRate` (skill-type / skill-tree bonuses) |
| LastDamageRate | buffer last-damage + `CalcLastDamageRate` + boss LifeReduce + pet penalty (all summed) |
| DistanceResistRate | 1.0, or `MobPropertyDistanceResist` for mobs that have that property |
| GemDamageRate | `CalcGemLastDamageRate` |
| AbnormalDamageIncreaseRate, SpecificWeaponLastDamage | when applicable |
| DamageLimit / MinDamage / MaxDamage | mob damage caps, when the mob has them |

**Not filled by the engine** (the skill supplies them): `SkillRate`, `SkillConstantDamage`, `FirstAttack`, `FirstAttackRate`.

`AddRate` / `AddConstant` add into a slot (several sources in one slot are **summed**). `SetRate` / `SetConstant` replace the slot.

### 1.2 `GetDamage()` — the order of operations

Slots are processed in `CalcStep` order. After each Rate step the value is truncated to int.

```
d = BaseDamage + SkillConstantDamage + BufferConstantDamage + Def(negative) + FirstAttack
d = max(d, 0)
d = (int)(d * CriticalRate)          # only when the hit is a crit, otherwise x1
d = (int)(d * ElementBonusRate)
d = (int)(d * NormalElementDamageResistRate)
d = (int)(d * NormalAttackPowerWave)  # not used by these skills
d = (int)(d * SkillRate)
d = (int)(d * FirstAttackRate)
d = (int)(d * AutoSkillRate)
d = (int)(d * StableRate)
d = d + AutoSkillConstant
d = (int)(d * ExpRate)                # proration
d = (int)(d * TypeDamageRate)
d = (int)(d * LastDamageRate)
d = (int)(d * DistanceResistRate)
d = (int)(d * SpecialLastDamageRate)
d = (int)(d * GemDamageRate)
d = (int)(d * AbnormalDamageIncreaseRate)
d = max(d, 0) + LastConstantDamage
if guarded: d = (int)(d * GuardPower / 100)      # GuardPower default 25
d = (int)(d * NormalAttackTreasureHuntLastDamageRate)
d = min(d, DamageLimit); d = max(d, MinDamage); d = min(d, MaxDamage)
d = (int)(d * SpecificWeaponLastDamage)
if d <= 0: d = 1
```

Empty slots are skipped, so an unset Rate means x1 and an unset Constant means +0.
A miss (`HitCheck` false) returns 0. A MetalSlime-flag target returns 1.

### 1.3 Base damage — the dual-wield formula

`calcBaseDamage` checks whether the skill's `EqLimit` has bit 15 (all Dual Sword skills have `EqLimit = 32768`) and whether the sub weapon is a One-Hand Sword (`ItemType 10`):

```
dual:    base = (ATK + SubATK * SubStability / 100 + Lv_player - Lv_mob) * (100 - mob physical resist%) / 100 * weaponRate
normal:  base = (ATK + Lv_player - Lv_mob) * (100 - mob physical resist%) / 100 * weaponRate
```

- ATK = final ATK. SubATK and SubStability come from `IPlayerStatusCalculator.SubAtk / SubStable`.
- For magic skills the same shape uses MATK, SubMATK and magic resist.
- `weaponRate` = `CheckSpecificWeaponBaseDamageRate`, 1.0 unless a special weapon rule applies.

### 1.4 DEF and pierce

```
Def step = -(int)(DEF_mob * (1 - min(1, addRegist + bPowerResistBreaker% + buffPowerResistBreaker*0.01)))
```

`addRegist` is 0 unless the skill passes one (Blade Stinger, Luna Dither Star blade rain).

### 1.5 First-attack bonus (used by Charging Slash, Sturm/Orbit Reaper, Luna Dither Star, Twin Buster Blade 2nd hit)

```
FirstAttack     += bFirstAttack                              (0 while the Ichijhinnokaze buff is active)
FirstAttackRate += ( 100
                     + (Godspeed Locus learned ? Lv_GL + 5 : 0)
                     + (Godspeed Locus learned and main & sub are 1H swords ? 10 : 0)
                     + buff FirstAttackRate (Flash Blast gives +Lv)
                     + bFirstAttackRate ) / 100
                  (exactly 100 while the Ichijhinnokaze buff is active)
```

### 1.6 Critical chance

`checkCriticalPercent(Critical, mob)`: the player's Critical, minus the mob's `CriticalResist` property if it has one, rolled out of 100.

---

## 2. Skills

### 2.1 Twin Slash (642) — physical, MP 200
- `rate% = 10*Lv + 150`. At Lv10 this is 250.
- `const = 10*Lv + 100`. At Lv10 this is 200.
- `CriticalRate += (5*Lv + 50 + gem 0x6D value[2]) / 100`. At Lv10 a crit multiplies by `CriticalDmg/100 + 1.00`.
- 1 hit.

### 2.2 Parrying Sword / Cross Parry (643)
- `rate% = Lv + 100 + gem 0x6E value[4]`. At Lv10 this is 110.
- `const = 5*Lv + 50`.
- Split into 2 hits.
- **Buff after a successful parry (30 s):** `AtkUpRate = Lv`, `AspdRate = 10*Lv`. Damage cut while the skill is active comes from `calcDmgCut(Lv)`.

### 2.3 Step Reactor / Reflex (644) — no damage
Buff: `DefRate = MdefRate = Lv − 100` (%), `AvoidUp = 2*Lv + 10`.

### 2.4 Dual Sword Mastery (641) / Dual Sword Control (645) — passives
| MasteryId | Mastery (641) | Control (645) |
|---|---|---|
| HitRate (21) | `3*Lv − 55` | `3*Lv + 5` |
| CrtRate (23) | `3*Lv − 55` | `3*Lv + 5` |
| Aspd (6) | — | `50*Lv` |

Both at Lv10 give `−25 + 35 = +10` for HitRate and CrtRate. The base dual-wield penalty these offset was not traced.

### 2.5 Spinning Slash / Air Slide (646)
- **First hit:** `rate% = (int)(2.5*Lv) + 125 + g`, where g = gem 0xD2 value[4]. `const = 5*Lv + 50`.
- **Later hits** (while the attack keeps hitting, LoopParam 4): `rate% = 2*Lv + 30 + g`, const 0.
- **Proration is locked:** the target's physical-skill proration at the first contact is stored and used for every later hit (`SetRate ExpRate`).
- Buffer constant ÷ 4.
- Blind chance `(int)(2.5*Lv) + 15` %.
- Gem 0xD2 ("Compression") also scales the radius by `value[2]*0.01` and adds a 100% knock-back roll.
- At Lv10 with no gem: first hit 150% +100, later hits 50%.

### 2.6 Charging Slash / Dragoon Sword (647)
- `rate% = 20*Lv + 200 + gem 0xD3 value[4]`. At Lv10 this is 400.
- `const = 20*Lv + 100`. At Lv10 this is 300.
- Gets the first-attack bonus (1.5).
- Proration locked per target at first contact.
- Buffer constant ÷ 2. Split into 2 hits.
- With gem 0xD3 ("Critical") the hit is always a crit.

### 2.7 Godspeed Locus (648) — passive
- `AGI + Σ_{i=0}^{Lv−1} (i < 5 ? 1 : 2)`. At Lv10 this is +15.
- FirstAttackRate `+Lv+5`, plus 10 more when both hands are 1H swords (see 1.5).

### 2.8 Phantom Slash / Phantom Eclipse (649) — Dark, MP 400
- `rate% = 20*Lv + 500 + gem 0x131 value[4]`. At Lv10 this is 700.
- `const = 20*Lv`.
- Freeze chance `10*Lv` %.
- **Two damage packets**, each split into 6 (`StandardHitCount`). Each of the 6 is shown again as 2 halves.
  - main packet: `SkillRate = rate × (Eclipse ? 2 : 1)`, `LastDamageRate := B × (1 + LRM + HB) × Combo × DT − lifeReduce`
  - "place" packet: `SkillRate = rate`, `LastDamageRate := B × (1 + HB) × Combo × DT − lifeReduce`
  - B is `CalcBufferLastDamageRate`. LRM is Long Range Mastery's LastDmgRate / 100 (0 if not learned). HB is Heavy Blow's LastDmgRate / 100 (only when its gem roll passes). Combo is `CalcCobmoRate` plus the NothingStyle gem. DT is `CalcDoubleThrowLastDamageRate`.
  - Because these are `SetRate`, they **replace** the engine's normal LastDamageRate sum. The equipment last-damage term (`CalcLastDamageRate`) is not in this skill's formula.
- **Eclipse:** the ×2 applies when Phantom Slash is used as the follow-up interrupt of Luna Dither Star (`LunaDitherStartInterruptableInitialize` sets `change`).
- **Instant kill:** when a packet connects, the client appends one extra hit of **999,999,999** (`DeathDamage`). The description says this is a chance against weak non-boss mobs. That gating is not in this function; it arrives through `AttackStartReceive` flags, so the decision is presumably server-side **(Inferred)**.

### 2.9 Flash Blast (650)
- **Buff:**
  - `FirstAttackRate +Lv` (%).
  - With dual swords: `EqAtkUpRate 25` (%), `AvoidStack floor(0.2*Lv)*1000`, duration 120 s.
  - Otherwise: 20 s and no EqAtk.
- **Counter blast (`PhiloEclailAttackAction`), Wind element, plus the sub element when dual:**
  - `rate% = 15*Lv + 50` (+50 if the main weapon is a 1H sword). At Lv10 with a 1H sword this is 250.
  - Radius 5 m with a 1H sword, 4 m otherwise.
  - `const = 10*Lv + 100`.
  - Uses the dual base formula only when both weapons are 1H swords.
  - Crit chance is recomputed without the Shadow Step (WrapAround) crit buff and without the Clear & Serene buff.
  - Consumes a pending Sturm Reaper buff without using it.
  - Buffer constant ÷ 2. 1 hit.

### 2.10 Shadow Step / Wrap Around (651)
- The hit itself deals **0 damage**.
- MP `floor(0.25*Lv + 0.25) * 100`.
- **Next-attack buff (1 use):** `CrtUpRate = 20*Lv`, `AttackMpRecoveryUp = Lv`.

### 2.11 Shining Cross / Blazing Shining Cross (652) — Light (Blazing: weapon element)
- `rate% = 10*Lv + 300 + STR/d + AGI/d + DEX/d`. These are **final** stats; each division is an integer division.
  - d = 4 while the Luna Dither Star buff is active (Blazing), else 5.
- **Distance penalty:** `rate% −= clamp(50*distance_m − 200, 0, 400)`, then `rate% = max(rate%, 100)`. There is no loss up to 4 m, and each metre beyond that costs 50.
- `const = 20*Lv + 100`.
- **2 templates:** 2 separate full hits, each with its own crit roll.

### 2.12 Storm Reaper / Orbit Reaper (653)
- `rate% = 10*Lv + 400 + (base DEX / 100) * Lv`. At Lv10 this is `500 + floor(DEX/100)*10`.
- `const = 10*Lv + 100`.
- Weapon element. First-attack bonus. 2 templates.
- **Next-attack buff on landing:**
  - `r = clamp(backstep_distance_m / 9, 0.1, 1.0)`
  - Storm: `ShortRangeRate = (int)(10*Lv * r)`
  - Orbit (used after Luna Dither Star): `ShortRangeRate = 0`, `LongRangeRate = (int)(10*Lv*r) / 2`
  - The distance is rounded to 0.01 m. One displayed metre is 2 Unity units.

### 2.13 Saber Aura (654) — no damage
Stacking buff (`Count`, max 20). Per stack:
- `CrtUp floor(2.5*Lv)`
- `AspdRate 10*Lv`
- `HitUp 5*Lv`
- `AtkMpRecoveryUp floor((Lv−1)/2)+1`

Other values:
- A stack is added every `7 − floor((Lv+1)/2)` s.
- HP cost field: `25 − 2*Lv`.
- Move-speed value: 100.

Using Saber Aura ends Ark Saber.

### 2.14 Ark Saber (657) — no direct damage
- **Buff:**
  - `CrtUp 10*Lv`, `AtkMpRecoveryUp 2*Lv`, barrier value 80.
  - `Count = n`, duration `max(3n, 10)` s.
- **While the buff is active, every attack gets a flat bonus in BufferConstantDamage:**
  ```
  min(200, max(0, (max(0, CRT − 100) − max(0, mobCritResist − 100)) / 10 * buffLv))
  ```
  CRT = final Critical.

### 2.15 Luna Dither Star (655) — Dark + sub element, MP 400 (300 with gem 0x410)
- **Cross:**
  - `rate% = 50*Lv + 500 + DEX(total)/1.5`. At Lv10 this is `1000 + DEX/1.5`.
  - `const = 400`.
  - First-attack bonus. Split into 2.
  - Hit state can be forced sure-hit / ignore-avoid by the skill flags.
  - A target already hit by this cast reuses the earlier result, with no second calculation.
- **Blade rain** (up to 5 blades, 1 hit each), Normal element:
  - `rate% = 5*Lv + 250`, const 0.
  - Extra pierce `addRegist = 5*Lv` % (1.4).
  - Proration fixed to the target's magic proration at its first contact.
- Buff `LunaDitherStarBuf`: duration `6 * hitCount` s. This buff turns Shining Cross into Blazing, and Phantom Slash / Storm Reaper follow-ups into Eclipse / Orbit.

### 2.16 Twin Buster Blade (656) — both parts are **always critical**
- **1st part:**
  - `rate% = 75*Lv + (base AGI + base DEX) / 2`.
  - `const = 30*Lv`.
  - Split into 4.
- **2nd part:**
  - `rate% = min(2000, 500 + 0.5 * base STR * N)`.
  - N = number of live targetable mobs in range. With the Exorcism gem, N is `min(target debuff count, max) + 1` instead.
  - `const = 30*Lv`. First-attack bonus.
  - Proration fixed to the value stored at the 1st part. 1 hit.
- Range 7 m; line 6 m × 1.5 m.

### 2.17 Air Slicer (658)
S = learned Spinning Slash level. T = learned Twin Slash level. g = gem 0xD2 value[4].
- **1st part:**
  - `rate% = ((int)(2.5*S) + 125 + g) + 3*(2*S + 30 + g) + floor(base DEX / 10) * Lv`.
  - `const = 5*S + 50`.
  - Split into 3.
  - Blind chance `(int)(2.5*S) + 15` %.
- **2nd part** (forward input, +200 MP):
  - `d = max(0, ceil(distance_m) − 7)`.
  - `rate% = 100*Lv + 500 + max(0, base STR * max(0, 100 − 20d) / 100)`.
  - `const = 20*Lv`.
  - `CriticalRate += max(0, ((5T + 50) / 2) * (target Blind ? 2 : 1) − min(10d, 50)) / 100`.
  - 1 hit.

### 2.18 Aerial Slay / Arial Slay (659)
- `rate%`:
  - sub = 1H sword: `100*Lv + max(base STR, base AGI, base DEX) / 2`
  - otherwise: `50*Lv + max(DEX(total), base STR)`
- `const = 20*Lv + 100`. 1 hit.
- With a Magic Device as sub it becomes a magic attack.
- Buff: with a Shield as sub, `MobLastDamageRateBuf = min(2 × shield refine, 30)`. With a 1H sword as sub the buff lasts 5 s.

### 2.19 Horizon Cut / Horizontal Cut (660)
- **Hit 1:**
  - `rate% = 10*Lv + 900 + DEX(total)`.
  - `const = 60*Lv`.
- **If the sub weapon is a 1H sword:**
  - Hit 1 changes to `rate/2`, `const/2`.
  - Hit 2 is added: `rate% = 50*Lv + max(base STR, base AGI) / 2`, `const = 30*Lv`.
- Each hit is its own template. Range becomes 14 m when a placed skill object is present.

### 2.20 Blade Stinger (661)
- `P = (4*Lv + 10) + bPowerResistBreaker + buff PowerResistBreaker`.
- `bonus% = P ≥ 101 ? min(10*P − 1000, 500) : 0`.
- **Hit 1:**
  - `rate% = 40*Lv + 300`, plus `DEX(total)` when the sub is **not** a 1H sword.
  - If the hit does not graze: `rate% += bonus%`, and pierce `addRegist = (4*Lv + 10)` % is used for the Def step.
  - `const = 100`.
- **Hit 2 (sub is a 1H sword only):**
  - `rate% = AGI(total) + 300`, with the same graze rule.
  - Sure-hit when hit 1 connected without grazing.
  - `const = 100`.
- Range 24 m.

---

## 3. Open points
- Gem-cart values (`GemCartBufferBase.GetValue(id, idx)`) come from the gem data, not from these classes. The ids are listed above; their numbers were not extracted.
- `CalcStable`, `CalcElementBonus`, `CalcLastDamageRate`, `CalcBufferLastDamageRate`, `CalcSkillTypeBonusRate`: the engine calls are identified, but their insides are not traced here.
- The dual-wield Hit/Crit penalty that Dual Sword Mastery/Control offsets was not located.
- Phantom Slash instant-kill gating (see 2.8).
- None of the formulas were checked against in-game damage numbers.
