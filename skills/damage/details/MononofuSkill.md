# モノノフスキル (`MononofuSkill`) — skill details

23 entries.

### เฟลช (FlashDrawnSword) · uid 609

<img src="../../icons/sk_609.png" width="40" alt="icon"> 
**Tree:** モノノフスキル (`MononofuSkill`, tier 1) · **Type:** Attack · **Max Lv:** 10 · **Weapons:** Katana · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `FlashDrawnSwordAction`

> ฟันศัตรูด้วยความเร็วจนตามองตามไม่ทัน
> มีโอกาสติดอัตราคริติคอลสูงในฮิตที่ 2

**How it works**

- Attack skill of the モノノフスキル tree (tier 1, max Lv 10); usable with Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [0 hs fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 ge skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 hs skillRate.Length AND 1 lt skillRate.Length]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 hs fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 ge skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 hs skillRate.Length AND 2 lt skillRate.Length]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 lo fixAddDamage.Length AND 2 lo skillRate.Length AND 2 lt skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 hs fixAddDamage.Length AND 2 lo skillRate.Length AND 2 lt skillRate.Length]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 ge skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 hs skillRate.Length AND 1 lt skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 hs fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length]: flat damage depends on live values (formula below)
  - `calcPlayerToMobDamage` [0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 ge skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 hs skillRate.Length AND 2 lt skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 lo fixAddDamage.Length AND 2 lo skillRate.Length AND 2 lt skillRate.Length]: flat damage depends on live values (formula below)
  - `calcPlayerToMobDamage` [0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 lo fixAddDamage.Length AND 2 lo skillRate.Length AND 2 lt skillRate.Length]: flat damage depends on live values (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetSubWeaponType.item(actarAction))`
  - when `mainWeapon == Bow AND skillRate.Length eq 0 OR fixAddDamage.Length eq 0 AND mainWeapon == Bow AND skillRate.Length ne 0 OR fixAddDamage.Length ne 0 AND mainWeapon == Bow AND skillRate.Length ls 1 AND skillRate.Length ne 0`
- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
  - when `mainWeapon != Bow AND skillRate.Length eq 0 OR fixAddDamage.Length eq 0 AND mainWeapon != Bow AND skillRate.Length ne 0 OR fixAddDamage.Length ne 0 AND mainWeapon != Bow AND skillRate.Length ls 1 AND skillRate.Length ne 0`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 9 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 8 tpl, 3 info

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `skillRate[0]` — 0 hs fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 ge skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 hs skillRate.Length AND 1 lt skillRate.Length
- SkillRate × `skillRate[1]` — 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 hs fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 ge skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 hs skillRate.Length AND 2 lt skillRate.Length
- SkillRate × `skillRate[2]` — 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 lo fixAddDamage.Length AND 2 lo skillRate.Length AND 2 lt skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 hs fixAddDamage.Length AND 2 lo skillRate.Length AND 2 lt skillRate.Length
- Flat dmg + `fixAddDamage[0]` — 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 ge skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 hs skillRate.Length AND 1 lt skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 hs fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length
- Flat dmg + `fixAddDamage[1]` — 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 ge skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 hs skillRate.Length AND 2 lt skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 lo fixAddDamage.Length AND 2 lo skillRate.Length AND 2 lt skillRate.Length
- Flat dmg + `fixAddDamage[2]` — 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 lo fixAddDamage.Length AND 2 lo skillRate.Length AND 2 lt skillRate.Length

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `skillRate[0]`
  - when `0 hs fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 ge skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 hs skillRate.Length AND 1 lt skillRate.Length`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `fixAddDamage[0]`
  - when `0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 ge skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 hs skillRate.Length AND 1 lt skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 hs fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, playerAction)`
  - when `0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 ge skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 hs skillRate.Length AND 1 lt skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 hs fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[FirstAttackRate]` = `(PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100)`
  - when `0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 ge skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 hs skillRate.Length AND 1 lt skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 hs fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `skillRate[1]`
  - when `0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 hs fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 ge skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 hs skillRate.Length AND 2 lt skillRate.Length`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `fixAddDamage[1]`
  - when `0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 ge skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 hs skillRate.Length AND 2 lt skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 lo fixAddDamage.Length AND 2 lo skillRate.Length AND 2 lt skillRate.Length`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `skillRate[2]`
  - when `0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 lo fixAddDamage.Length AND 2 lo skillRate.Length AND 2 lt skillRate.Length OR 0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 hs fixAddDamage.Length AND 2 lo skillRate.Length AND 2 lt skillRate.Length`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `fixAddDamage[2]`
  - when `0 lo fixAddDamage.Length AND 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo fixAddDamage.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 lo fixAddDamage.Length AND 2 lo skillRate.Length AND 2 lt skillRate.Length`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 609
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

_Raw recovered data (every method item): [trees/MononofuSkill.md](../trees/MononofuSkill.md) — uid 609_

---

### ปอมเมลสไตร์ค (StrikeBackOfSword) · uid 610

<img src="../../icons/sk_610.png" width="40" alt="icon"> 
**Tree:** モノノフスキル (`MononofuSkill`, tier 1) · **Type:** Attack · **Max Lv:** 10 · **Weapons:** Katana · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `StrikeBackOfSwordAction`

> อัดด้วยด้ามเต็มแรง
> มีโอกาสทำให้เป้าหมายติด[อัมพาต]
> ถ้าติดอัมพาตอยู่แล้วจะมีโอกาส[หมดสติ]

**How it works**

- Attack skill of the モノノフスキル tree (tier 1, max Lv 10); usable with Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×1.05 at Lv1 to 1.5 at Lv10; flat damage +110 at Lv1 to 200 at Lv10
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Stun (3), Paralysis (6).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetSubWeaponType.item(actarAction))`
  - when `mainWeapon == Bow`
- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
  - when `mainWeapon != Bow`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 7 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 4 call, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 1.05 | 1.1 | 1.15 | 1.2 | 1.25 | 1.3 | 1.35 | 1.4 | 1.45 | 1.5 |
| Flat dmg + | 110 | 120 | 130 | 140 | 150 | 160 | 170 | 180 | 190 | 200 |

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv + (Lv << 2)) + 100) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv * 10) + 100))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 610
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Chance field `abnormalPercent` (Chance to inflict the skill's status ailment (%)): `((Lv + (Lv << 2)) + 50)` → Lv1..10 [55, 60, 65, 70, 75, 80, 85, 90, 95, 100]
- Chance field `stunPercent` (Stun chance (%)): `(Lv + (Lv << 2))` → Lv1..10 [5, 10, 15, 20, 25, 30, 35, 40, 45, 50]
- Rolls `stunPercent`% to inflict **Stun (3)** (`calcPlayerToMobDamage`)
  - when `AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 6) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction) AND AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 6)`
- Marks the hit with ailment **Stun (3)** (`calcPlayerToMobDamage`)
  - when `AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 6) AND PlayerAttackBase.checkAbnormalPercent(this, 3, stunPercent, playerAction)`
- Rolls `abnormalPercent`% to inflict **Paralysis (6)** (`calcPlayerToMobDamage`)
  - when `!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 6) AND PlayerAttackBase.checkAbnormalPercent(this, 6, abnormalPercent, playerAction) OR !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 6) AND !PlayerAttackBase.checkAbnormalPercent(this, 6, abnormalPercent, playerAction)`
- Marks the hit with ailment **Paralysis (6)** (`calcPlayerToMobDamage`)
  - when `!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 6) AND PlayerAttackBase.checkAbnormalPercent(this, 6, abnormalPercent, playerAction)`

_Raw recovered data (every method item): [trees/MononofuSkill.md](../trees/MononofuSkill.md) — uid 610_

---

### พัลส์เบลด / สวิฟต์พัลส์เบลด (WaveBlade) · uid 611

<img src="../../icons/sk_611.png" width="40" alt="icon"> 
**Tree:** モノノフスキル (`MononofuSkill`, tier 1) · **Type:** Attack · **Max Lv:** 10 · **Weapons:** Katana · **Requires:** เฟลช · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `WaveBladeAction`

> ฟันศัตรูที่อยู่ห่างออกไปด้วยใบมีดสูญญากาศ
> ยิ่งอยู่ห่างเป้าหมายเท่าไหร่พลังทำลายก็ยิ่งลดต่ำลง
> สามารถเคลื่อนไหวตอนเก็บดาบเข้าฝักได้

**How it works**

- Attack skill of the モノノフスキル tree (tier 1, max Lv 10); usable with Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- `NormalAttackAction` looks its buff up and changes how normal attacks run while it is active.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 ge skillRate.Length OR 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 hs skillRate.Length AND 1 lt skillRate.Length OR 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 ge skillRate.Length]: skill multiplier depends on live values (formula below); flat damage +31 at Lv1 to 40 at Lv10
  - `calcPlayerToMobDamage` [0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 ge skillRate.Length OR 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 lo skillRate.Length AND 2 lt skillRate.Length OR 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 hs skillRate.Length AND 2 lt skillRate.Length]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 lo skillRate.Length AND 2 lt skillRate.Length]: skill multiplier depends on live values (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target if class check passes`.
- Buffs:
  - `SwordMoveBuf`

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 6 set
- `ActionPreparation` — before the cast starts: 2 set, 1 call
- `ActionSkillEvent` — on an animation/skill event during the motion: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 7 tpl, 3 info
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `GetLocalizeKey` — skill-specific method: 1 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 31 | 32 | 33 | 34 | 35 | 36 | 37 | 38 | 39 | 40 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(skillRate[0] / 100)` — 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 ge skillRate.Length OR 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 hs skillRate.Length AND 1 lt skillRate.Length OR 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 ge skillRate.Length
- SkillRate × `(skillRate[1] / 100)` — 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 ge skillRate.Length OR 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 lo skillRate.Length AND 2 lt skillRate.Length OR 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 hs skillRate.Length AND 2 lt skillRate.Length
- SkillRate × `(skillRate[2] / 100)` — 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 lo skillRate.Length AND 2 lt skillRate.Length

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `SetConstant[Def]` = `-PlayerAttackBase.CalcPowerResistDamage(PlayerActionManagerBase.get_PlayerStatus(), int(((((max((int(MathUtil.DistanceToDisplayMeter(max((fsqrt((((UnityEngine.Transform.get_position(MobActionManagerBase.get_transform(mobAction)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(playerAction)).z) * (UnityEngine.Transform.get_position(MobActionManagerBase.get_transform(mobAction)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(playerAction)).z)) + ((UnityEngine.Transform.get_position(MobActionManagerBase.get_transform(mobAction)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(playerAction)).x) * (UnityEngine.Transform.get_position(MobActionManagerBase.get_transform(mobAction)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(playerAction)).x)))) - MobActionManagerBase.get_Size(mobAction)), 0))) - int(MathUtil.DistanceToDisplayMeter((PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction)))))), 0) * ((11 - Lv))) / 100) + 1) * IMobStatusCalculator.CalcDef(MobActionManagerBase.get_MobBattleStatus(mobAction)))), 0)`
  - when `0 hs skillRate.Length AND 0 lt skillRate.Length OR 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 ge skillRate.Length OR 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 hs skillRate.Length AND 1 lt skillRate.Length`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(skillRate[0] / 100)`
  - when `0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 ge skillRate.Length OR 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 hs skillRate.Length AND 1 lt skillRate.Length OR 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 ge skillRate.Length`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `((Lv + 30))`
  - when `0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 ge skillRate.Length OR 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 hs skillRate.Length AND 1 lt skillRate.Length OR 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 ge skillRate.Length`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, playerAction)`
  - when `0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 ge skillRate.Length OR 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 hs skillRate.Length AND 1 lt skillRate.Length OR 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 ge skillRate.Length`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[FirstAttackRate]` = `(PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100)`
  - when `0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 ge skillRate.Length OR 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 hs skillRate.Length AND 1 lt skillRate.Length OR 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 ge skillRate.Length`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(skillRate[1] / 100)`
  - when `0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 ge skillRate.Length OR 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 lo skillRate.Length AND 2 lt skillRate.Length OR 0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 hs skillRate.Length AND 2 lt skillRate.Length`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(skillRate[2] / 100)`
  - when `0 lo skillRate.Length AND 0 lt skillRate.Length AND 1 lo skillRate.Length AND 1 lt skillRate.Length AND 2 lo skillRate.Length AND 2 lt skillRate.Length`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target if class check passes`, attack type `Physics`, action id 611
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `ActionPreparation` (before the cast starts): removes the caster's buff of skill 626 (UnannouncedDestination) — `RemoveSelfBuffer(626)`
  - when `!PlayerAttackBase.IsBlank(this) AND 0 lo skillRate.Length AND 1 lo skillRate.Length AND 2 lo skillRate.Length AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 626) ne 0 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 626).BuffEffectActive ne 0 AND UnityEngine.Object.op_Inequality(actarAction)`

**Buff values** (every recovered field; durations in seconds)

**Buff `SwordMoveBuf`**
- **Modifies normal attacks**: `NormalAttackAction` looks this buff up while it builds the normal-attack damage / hit logic.
- Attached to this skill via `caller2:SwordMove$$AddBuf<-WaveBladeAction$$ActionSkillEvent` (no direct constructor call in the skill's own code).
- Buff hook methods: `CheckDamageInvalid`, `DamageInvalid`, `EndSwordMove`
- `Value` = `((damageInvalid & 1))` _(when BuffEffectActive ne 0)_
- `Value` = `0` _(when BuffEffectActive eq 0)_
- Buff fields set in the constructor (all recovered):
  - `Level` = `257` = 257
  - `BuffEffectActive` = `1` = 1
  - `BufEffectTakeUid` = `-1` = -1
  - `damageInvalid` = `(damageInvalid & 1)`
- Hook `DamageInvalid`: `damageInvalid`=0
- Hook `EndSwordMove`: `damageInvalid`=0

Parameter meanings (inferred from the `SkillBufferId` names):

- `Value`: generic value (meaning set by the code that reads the buff)

_Raw recovered data (every method item): [trees/MononofuSkill.md](../trees/MononofuSkill.md) — uid 611_

---

### บุชิโด (Bushido) · uid 612

<img src="../../icons/sk_612.png" width="40" alt="icon"> 
**Tree:** モノノフスキル (`MononofuSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 10 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem · **Client class:** `Bushido` (passive mastery)

> เรียนรู้หัวใจแห่งการเป็นนักรบ
> HP, MP และความแม่นเพิ่มขึ้นเล็กน้อย
> ATK จะเพิ่มขึ้นเมื่อติดตั้งคาตานะ

**How it works**

- Mastery skill of the モノノフスキル tree (tier 1, max Lv 10); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): MaxHp (max HP) 10 at Lv1 to 100 at Lv10, MaxMp (max MP) 10 at Lv1 to 100 at Lv10, Hit (accuracy) 1 at Lv1 to 10 at Lv10, EqAtkRate (weapon ATK %) 3 at Lv1 to 30 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MaxHp | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |
| MaxMp | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |
| Hit | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| EqAtkRate | 3 | 6 | 9 | 12 | 15 | 18 | 21 | 24 | 27 | 30 |

- `AtkRate` = `(int(((Lv + 2) * vec(0x9999999a, 0x3fc99999))) + 1)`

Bonus meanings (inferred from the names):

- `MaxHp`: max HP
- `MaxMp`: max MP
- `Hit`: accuracy
- `AtkRate`: ATK %
- `EqAtkRate`: weapon ATK %

_Raw recovered data (every method item): [trees/MononofuSkill.md](../trees/MononofuSkill.md) — uid 612_

---

### ทูแฮนด์ (WeaponInBothHands) · uid 613

<img src="../../icons/sk_613.png" width="40" alt="icon"> 
**Tree:** モノノフスキル (`MononofuSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 10 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** บุชิโด · **Flags:** StarGem · **Client class:** `WeaponInBothHands` (passive mastery)

> เพิ่มพลังโจมตีถ้าใช้อาวุธสองมือ
> ค่าสถานะต่างๆ จะเพิ่มขึ้นถ้าช่องอาวุธเสริมว่างเปล่า
> ค่าความเสียหายคริติคอลจะเพิ่มขึ้นเป็นอย่างมากด้วยคาตานะ

**How it works**

- Mastery skill of the モノノフスキル tree (tier 1, max Lv 10); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Stable (stability) 1 at Lv1 to 10 at Lv10, Crt (critical rate) 1 at Lv1 to 10 at Lv10, HitRate (accuracy %) 1 at Lv1 to 10 at Lv10, AtkRate (ATK %) 5 at Lv1 to 50 at Lv10, EqAtkRate (weapon ATK %) 1 at Lv1 to 10 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Stable | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| Crt | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| HitRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| AtkRate | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |
| EqAtkRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |


Bonus meanings (inferred from the names):

- `Stable`: stability
- `Crt`: critical rate
- `HitRate`: accuracy %
- `AtkRate`: ATK %
- `EqAtkRate`: weapon ATK %

**In-game level notes**

- Lv8: *อัตราคริติคอลเพิ่มขึ้น 2 เท่า ความเสถียรเพิ่มขึ้น 2 เท่า

_Raw recovered data (every method item): [trees/MononofuSkill.md](../trees/MononofuSkill.md) — uid 613_

---

### ทริปเปิ้ลทรัสต์ (ThreeStageThrust) · uid 614

<img src="../../icons/sk_614.png" width="40" alt="icon"> 
**Tree:** モノノフスキル (`MononofuSkill`, tier 2) · **Type:** Attack · **Max Lv:** 30 · **Weapons:** Katana · **Requires:** [N]พัลส์เบลด[N2]สวิฟต์พัลส์เบลด[N] · **Flags:** MercenaryCanUseSkill · **Client class:** `ThreeStageThrustAction`

> พุ่งเข้าแทงศัตรูด้วยการก้าวเท้าอย่างรวดเร็ว
> เคลื่อนไหวไปข้างหลังแล้วโจมตี
> พลังโจมตีของสกิลถัดไปจะเพิ่มขึ้นเล็กน้อย

**How it works**

- Attack skill of the モノノフスキル tree (tier 2, max Lv 30); usable with Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on Agi (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Buffs:
  - `ThreeStageThrustBuf`
  - `CountBufferBase`
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
  - when `hasGemCart(214)`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`
  - when `!hasGemCart(214)`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 5 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 3 tpl, 1 info
- `ActionHit` — when the attack connects: 2 call

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv * 20) + 150) + (status.Agi // 5))) / 100)`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv * 20) + 150) + (status.Agi // 5))) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, playerAction)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[FirstAttackRate]` = `(PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 614
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `ThreeStageThrustBuf` — `.ctor(Lv, status.Lv)`
  - when `IsInstanceOf(actarAction, MobaPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): adds the caster's buff of `new ThreeStageThrustBuf` — `AddSelfBuffer(new ThreeStageThrustBuf, Id)`
  - when `IsInstanceOf(actarAction, MobaPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction)`

**Buff values** (every recovered field; durations in seconds)

**Buff `ThreeStageThrustBuf`**
- `SkillConstantDamage` = `((playerLv // (11 - lv)))` _(when BuffEffectActive ne 0)_
- `SkillConstantDamage` = `0` _(when BuffEffectActive eq 0)_
- Buff fields set in the constructor (all recovered):
  - `temporaryCount` = `-1` = -1
  - `constantDamage` = `(playerLv // (11 - lv))`
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:ThreeStageThrustBuf$$.ctor<-ThreeStageThrustAction$$ActionHit` (no direct constructor call in the skill's own code).
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
- `SkillConstantDamage`: skill flat damage

**Where else this skill takes effect**

- Code that reads this skill's level / buff by constant id: `MobaPlayerActionManager$$ReceiveAttack (GetSkillLv)`

_Raw recovered data (every method item): [trees/MononofuSkill.md](../trees/MononofuSkill.md) — uid 614_

---

### มากาดาจิ (CutOffTheDisaster) · uid 615

<img src="../../icons/sk_615.png" width="40" alt="icon"> 
**Tree:** モノノフスキル (`MononofuSkill`, tier 2) · **Type:** Special · **Max Lv:** 30 · **Weapons:** Katana · **Requires:** ปอมเมลสไตร์ค · **Flags:** MercenaryCanUseSkill · **Client class:** `CutOffTheDisasterAction`

> ปัดการโจมตีของศัตรูและลดความเสียหายได้เพียง 1 ครั้ง
> สภาวะผิดปกติไม่มีผล, ฟื้นฟู MP ขึ้นเล็กน้อย
> จะเหลืออย่างน้อย 1 HP เสมอเมื่อโดนโจมตีถึงตาย
> บางกรณีอาจไม่ปัดการโจมตี และต้องรับความเสียหายเต็มจำนวน
> ถ้าใช้คอมโบปริมาณการฟื้นฟู MP จะลดน้อยลง

**How it works**

- Special skill of the モノノフスキル tree (tier 2, max Lv 30); usable with Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- It can inflict a status ailment (chance and type below).
- Its buff exposes motion / combo hooks, so it changes the attack pattern while active (heuristic; the client has no explicit flag).
- `NormalAttackAction` looks its buff up and changes how normal attacks run while it is active.
- Damage (`calcPlayerToMobDamage` x2; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×2.3 at Lv1 to 5 at Lv10; skill multiplier depends on live values (formula below); flat damage +110 at Lv1 to 200 at Lv10; flat damage +300
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: None (0).
- Buffs:
  - `HeavenlyStarBuf`: lasts `10` s
  - `CutOffTheDisasterBuf`: marker buff (no parameters; other code tests whether it is present)
  - `CountBufferBase`
- Other client code reads this skill (3 lookups; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetSubWeaponType.item(actarAction))`
  - when `mainWeapon == Bow`
- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
  - when `mainWeapon != Bow`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 8 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionStart` — when the cast starts: 1 set, 2 call
- `ActionSkillEvent` — on an animation/skill event during the motion: 1 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 4 set, 7 tpl, 1 info
- `InvokeDamageCut` — skill-specific method: 1 call
- `DamageCut` — skill-specific method: 1 call
- `.<>c__DisplayClass30_0::<ActionStart>b__0` — skill-specific method: 1 call
- `.<>c__DisplayClass31_1::<ActionSkillEvent>b__1` — skill-specific method: 2 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 2.3 | 2.6 | 2.9 | 3.2 | 3.5 | 3.8 | 4.1 | 4.4 | 4.7 | 5 |
| Flat dmg + | 110 | 120 | 130 | 140 | 150 | 160 | 170 | 180 | 190 | 200 |
| Flat dmg + | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((int(((CountBufferBase.GetParam(20) * ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 620, 1) * 25) + 150)) * 0.5)) + 1300)) / 100)`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv * 10) + 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv * 30) + 200)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetConstant[BufferConstantDamage]` = `0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(300)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((int(((CountBufferBase.GetParam(20) * ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 620, 1) * 25) + 150)) * 0.5)) + 1300)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, playerAction)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[FirstAttackRate]` = `(PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 615
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Marks the hit with ailment **None (0)** (`DamageCut`)
  - when `PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) lt 20 AND SkillActionBase.get_AttackType() eq 2 AND SkillActionBase.op_Inequality(skillAction) OR PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) lt 20 AND SkillActionBase.get_AttackType() ne 2 AND SkillActionBase.op_Inequality(skillAction) OR PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()) ge 20 AND PlayerStatusBase.get_GameStatus().localHp le damageData._damage AND SkillActionBase.get_AttackType() eq 2 AND SkillActionBase.op_Inequality(skillAction)`

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): adds the caster's buff of skill 615 (CutOffTheDisaster) — `AddSelfBuffer(615, Lv, Id)`
  - when `!PlayerAttackBase.CheckSkillParamFlag(this, 4) AND (SkillParam & 16) eq 0 OR (SkillParam & 16) eq 0 AND PlayerAttackBase.CheckSkillParamFlag(this, 4)`
- `InvokeDamageCut` (method): removes the caster's buff of skill 615 (CutOffTheDisaster) — `RemoveSelfBuffer(615)`
- `.<>c__DisplayClass30_0::<ActionStart>b__0` (method): removes the caster's buff of skill 615 (CutOffTheDisaster) — `RemoveSelfBuffer(615)`
- `.<>c__DisplayClass31_1::<ActionSkillEvent>b__1` (method): constructs `HeavenlyStarBuf` — `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 620, 1))`
  - when `(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 620, 1) & 255) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue!PlayerStatusBase.get_SkillBufferManager().selfSkillBufList, 620, (this + 16), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue()))`
- `.<>c__DisplayClass31_1::<ActionSkillEvent>b__1` (method): adds the caster's buff of `new HeavenlyStarBuf` — `AddSelfBuffer(new HeavenlyStarBuf, 0)`
  - when `(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 620, 1) & 255) ne 0 AND (System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue!PlayerStatusBase.get_SkillBufferManager().selfSkillBufList, 620, (this + 16), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue()))`

**Other recovered parameters**

- **MP recovered** (`mpRecovery`): `((Lv * 10) + 100)` → Lv1..10 [110, 120, 130, 140, 150, 160, 170, 180, 190, 200]; `max((mpRecovery - 100), 0)` _(when !PlayerAttackBase.CheckSkillParamFlag(this, 4) AND (SkillParam & 16) eq 0 OR !PlayerAttackBase.CheckSkillParamFlag(this, 4) AND (SkillParam & 16) ne 0)_

**Buff values** (every recovered field; durations in seconds)

**Buff `HeavenlyStarBuf`**
- **Changes the attack pattern**: the buff object drives a motion/combo chain (`SetAttackSkillId`).
- **Modifies normal attacks**: `NormalAttackAction` looks this buff up while it builds the normal-attack damage / hit logic.
- Buff hook methods: `CheckExpDefFluctuate`, `IllusionarySceneReset`, `Reset`, `SetAttackSkillId`
- Duration: `10` s
- Buff fields set in the constructor (all recovered):
  - `isExpDefFluctuate` = `1` = 1
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `Reset`: `Count`=0; `LeftTime`=30; `prevSkillId`=0
- Hook `IllusionarySceneReset`: `Count`=max((((illusionarySceneParry & 1) + count) + ([TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 627)+0x20] ge 50 ? 0xfffffffe : 0xfffffffd)), 0); `LeftTime`=(EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) eq 8 ? (((count + (count << 2)) << 1) + 10) : ((count + (count << 2)) << 1)); `prevSkillId`=0; `Count`=max((((illusionarySceneParry & 1) + count) + 0xfffffffd), 0)
- Hook `SetAttackSkillId`: `prevSkillId`=skillId
**Buff `CutOffTheDisasterBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff fields set in the constructor (all recovered):
  - `IsDamageCancel` = `1` = 1
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:HeavenlyStarBuf$$.ctor<-CutOffTheDisasterAction.<>c__DisplayClass31_1$$<ActionSkillEvent>b__1` (no direct constructor call in the skill's own code).
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

**Where else this skill takes effect**

- Code that reads this skill's level / buff by constant id: `CutOffTheDisasterAction$$ActionSkillEvent (ContainsBuffer)`, `MercenaryActionManager$$Damaged (ContainsBuffer)`, `PlayerActionManager$$Damaged (ContainsBuffer)`

_Raw recovered data (every method item): [trees/MononofuSkill.md](../trees/MononofuSkill.md) — uid 615_

---

### เมเคียวชิซุย (ClearAndSerene) · uid 616

<img src="../../icons/sk_616.png" width="40" alt="icon"> 
**Tree:** モノノフスキル (`MononofuSkill`, tier 2) · **Type:** Buffer · **Max Lv:** 30 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ทูแฮนด์ · **Client class:** `ClearAndSereneAction`

> เพิ่มสมาธิให้แน่วแน่
> เพิ่มอัตราคริติคอลปริมาณมากในระยะเวลาสั้นๆ
> ค่าความเสียหายคริติคอลล, DEF, MDEF จะลดลง
> ถ้าใช้สกิลอื่นผลจะหมดลงทันที

**How it works**

- Buffer skill of the モノノフスキル tree (tier 2, max Lv 30); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- Other client code reads this skill (2 lookups; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 1 call
- `OnInheritance` — state carried over when this action follows another: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 616
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): adds the caster's buff of skill 616 (ClearAndSerene) — `AddSelfBuffer(616, Lv, Id)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**In-game level notes**

- Lv8: *ระยะเวลาแสดงผล 2 เท่า *การเพิ่มของอัตราคริติคอล+25 *ค่าความเสียหายคริติคอลไม่ลดลง

**Where else this skill takes effect**

- Effect applied in `MobaPlayerSecondaryStatus$$get_CriticalDmg` (36 guarded paths):
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) ne 0`
    - returns `(((int(((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3())))) - 300) gt 0 ? ((((int(((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3())))) - 300) >> 1) + 300) : (int(((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) + (`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) ne 0`
    - returns `(((int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3())))) - 300) gt 0 ? ((((int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3())))) - 300) >> 1) + 300) : (int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) ne 0`
    - returns `(((int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3())))) - 300) gt 0 ? ((((int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3())))) - 300) >> 1) + 300) : (int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3)`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) ne 0`
    - returns `(((int(((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3())))) - 300) gt 0 ? ((((int(((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3())))) - 300) >> 1) + 300) : (int(((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) eq 0`
    - returns `(((int(((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))) - 300) gt 0 ? ((((int(((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))) - 300) >> 1) + 300) : (int(((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1,`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) eq 0`
    - returns `(((int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))) - 300) gt 0 ? ((((int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))) - 300) >> 1) + 300) : (int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManager`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) eq 0`
    - returns `(((int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))) - 300) gt 0 ? ((((int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))) - 300) >> 1) + 300) : (int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBas`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) eq 0`
    - returns `(((int(((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))) - 300) gt 0 ? ((((int(((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))) - 300) >> 1) + 300) : (int(((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) * (((MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((MobaPlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - MobaPlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- Effect applied in `PlayerSecondaryStatus$$CalcCriticalDmg` (36 guarded paths):
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) ne 0`
    - returns `(int(((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((PlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) ne 0`
    - returns `(int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((PlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) ne 0`
    - returns `(int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((PlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) ne 0`
    - returns `(int(((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) * (((PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((PlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) eq 0`
    - returns `(int(((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((PlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3())))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) eq 0`
    - returns `(int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((PlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3())))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) eq 0`
    - returns `(int((((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) + (CharacterActionManagerBase.set_DefaultMoveSpeed() / 100)) * (((PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((PlayerSecondaryStatus.get_Agi(this, 47, ?mi, ?x3) - PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3())))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 39, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 979, stkp(-56), 0) & 1) eq 0`
    - returns `(int(((GetBonusConstant_Rate.out4() + (CharacterActionManagerBase.get_Size() / 100)) * (((PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3) * 0.2) + max(((PlayerSecondaryStatus.get_Agi(this, ?x1, ?x2, ?x3) - PlayerSecondaryStatus.get_Str(this, ?x1, ?x2, ?x3)) * 0.1), 0)) + 150))) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 53, 0, ?x3) + GetBonusConstant_Rate.out3())))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusConstant_Rate`, `virtual CharacterActionManagerBase.get_IsValid`, `SkillBufferManager$$GetSkillBufferParam`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- Code that reads this skill's level / buff by constant id: `MobaPlayerSecondaryStatus$$get_CriticalDmg (TryGetBuf)`, `PlayerSecondaryStatus$$CalcCriticalDmg (TryGetBuf)`

_Raw recovered data (every method item): [trees/MononofuSkill.md](../trees/MononofuSkill.md) — uid 616_

---

### ลมมงคล (Mizukaze) · uid 628

<img src="../../icons/sk_628.png" width="40" alt="icon"> 
**Tree:** モノノフスキル (`MononofuSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 30 · **Weapons:** Katana · **Requires:** เมเคียวชิซุย · **Client class:** `Mizukaze` (passive mastery)

> มีโอกาสทำงานเมื่อการโจมตีของตัวเอง MISS
> หรือเมื่อหลบหลีก Avoid สำเร็จพลังโจมตีระยะใกล้/
> โจมตีคริติคอล/แม่นยำจะเพิ่มขึ้นเล็กน้อย
> เป็นเวลา 30 วินาทีและสามารถสะสมได้สูงสุด 3 สแต็ค
> ผลของสกิลเพิ่มขึ้นตามระดับ Lv การเรียนรู้ของสกิลโมโนโนฟุ

**How it works**

- Mastery skill of the モノノフスキル tree (tier 2, max Lv 30); usable with Katana.
- It installs a buff on the caster.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Buffs:
  - `CountBufferBase`
  - `MizukazeBuf`: lasts `30` s
- Passive modifiers (negative = penalty): Percent (generic percent) 10 at Lv1 to 100 at Lv10.
- Its effect is applied by client code: `Mizukaze$$UpdateBuf` (formulas in the last section).
- Other client code reads this skill (1 lookup; see the last section).

**Buff values** (every recovered field; durations in seconds)

**Buff `CountBufferBase`**
- Attached to this skill via `caller2:MizukazeBuf$$.ctor<-Mizukaze$$UpdateBuf` (no direct constructor call in the skill's own code).
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
**Buff `MizukazeBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `Next`, `UpdateSkillTreeLevel`
- Duration: `30` s
- `ShortRangeRate` = `(Count * shortRangeDamageRate)` _(when BuffEffectActive ne 0)_
- `CrtDmg` = `(Count * criticalDamage)` _(when BuffEffectActive ne 0)_
- `HitUp` = `(Count * hit)` _(when BuffEffectActive ne 0)_
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `Next`: `LeftTime`=30
- Hook `UpdateSkillTreeLevel`: `shortRangeDamageRate`=(treeLevel & 255); `criticalDamage`=(treeLevel & 255); `mononofuSkillTreeLv`=treeLevel; `hit`=((((treeLevel & 255) << 2) + treeLevel) << 1)

Parameter meanings (inferred from the `SkillBufferId` names):

- `Count`: stack / hit counter
- `CrtDmg`: critical damage
- `HitUp`: accuracy +
- `ShortRangeRate`: short-range damage %

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Percent | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |


Bonus meanings (inferred from the names):

- `Percent`: generic percent

**Where else this skill takes effect**

- Effect applied in `Mizukaze$$UpdateBuf` (4 guarded paths):
  - when `SkillLv(628) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 628, stkp(-40), meta(0x39aa408, Method$SkillBufferManager.TryGetBuf<MizukazeBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
    - returns `?blr`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `SkillLv(628) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 628, stkp(-40), meta(0x39aa408, Method$SkillBufferManager.TryGetBuf<MizukazeBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() eq 0`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
  - when `SkillLv(628) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 628, stkp(-40), meta(0x39aa408, Method$SkillBufferManager.TryGetBuf<MizukazeBuf>())) & 1) eq 0`
    - returns `SkillBufferManager.AddSelfBuffer(PlayerStatusBase.get_SkillBufferManager(), 0x165db78(meta(0x39aa400, MizukazeBuf_TypeInfo), ?x1, ?x2, ?x3), 0, 0)`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`, `SkillManager$$GetSkillTreeLv`, `0x165db78`, `MizukazeBuf$$.ctor`, `MizukazeBuf$$UpdateSkillTreeLevel`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `SkillLv(628) lt 1`
    - returns `SkillLv(628)`
    - calls `virtual PlayerStatusBase.get_SkillManager`
- Code that reads this skill's level / buff by constant id: `Mizukaze$$UpdateBuf (GetSkillLv)`

_Raw recovered data (every method item): [trees/MononofuSkill.md](../trees/MononofuSkill.md) — uid 628_

---

### ฮัซโซฮัปปะ (Okaranman) · uid 617

<img src="../../icons/sk_617.png" width="40" alt="icon"> 
**Tree:** モノノフスキル (`MononofuSkill`, tier 3) · **Type:** Object · **Max Lv:** 70 · **Weapons:** Katana · **Requires:** ทริปเปิ้ลทรัสต์ · **Flags:** MercenaryCanUseSkill · **Client class:** `HassohappaAction`

> ฟันศัตรูในพื้นที่ที่กำหนดพร้อมกัน
> สร้างความเสียหายแก่ศัตรูโดยรอบได้อย่างแม่นยำ
> สามารถเคลื่อนไหวตอนเก็บดาบเข้าฝักได้

**How it works**

- Object skill of the モノノフスキル tree (tier 3, max Lv 70); usable with Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- It places an object in the world (trap, summon or field object).
- `NormalAttackAction` looks its buff up and changes how normal attacks run while it is active.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [isFirstAttck ne 0]: skill multiplier ×3.2 at Lv1 to 7 at Lv10
  - `calcPlayerToMobDamage` [isFirstAttck eq 0]: skill multiplier ×3.2 at Lv1 to 4 at Lv10
  - `calcPlayerToMobDamage`: flat damage +132 at Lv1 to 150 at Lv10
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Buffs:
  - `SwordMoveBuf`

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetSubWeaponType.item(actarAction))`
  - when `mainWeapon == Bow`
- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
  - when `mainWeapon != Bow`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 9 set
- `ActionStart` — when the cast starts: 6 set, 1 call
- `NextRangeHit` — next range-hit pass: 1 set
- `ActionSkillEvent` — on an animation/skill event during the motion: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 7 tpl, 1 call, 1 info
- `InitializeOthers` — setup used when another player's client replays the action: 2 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [isFirstAttck ne 0] | 3.2 | 3.3 | 3.4 | 3.5 | 3.6 | 3.7 | 3.8 | 3.9 | 4 | 7 |
| SkillRate × [isFirstAttck eq 0] | 3.2 | 3.3 | 3.4 | 3.5 | 3.6 | 3.7 | 3.8 | 3.9 | 4 | 4 |
| Flat dmg + | 132 | 134 | 136 | 138 | 140 | 142 | 144 | 146 | 148 | 150 |

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(target.ExpDefSkill / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv << 1) + 130))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((1) eq 0 ? (Lv eq 10 ? ((((((Lv + (Lv << 2)) << 1) lo 90 ? ((Lv + (Lv << 2)) << 1) : 90) + 210)) + 300) : (((((Lv + (Lv << 2)) << 1) lo 90 ? ((Lv + (Lv << 2)) << 1) : 90) + 210))) : ((Lv eq 10 ? ((((((Lv + (Lv << 2)) << 1) lo 90 ? ((Lv + (Lv << 2)) << 1) : 90) + 210)) + 300) : skillRate) + 100)) / 100)`
  - when `isFirstAttck ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, playerAction)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[FirstAttackRate]` = `(PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((1) eq 0 ? (((((Lv + (Lv << 2)) << 1) lo 90 ? ((Lv + (Lv << 2)) << 1) : 90) + 210)) : ((((((Lv + (Lv << 2)) << 1) lo 90 ? ((Lv + (Lv << 2)) << 1) : 90) + 210)) + 100)) / 100)`
  - when `isFirstAttck eq 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 617
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Hit counts**

- Number of damage events (`damageCount`): `System.Math.Min((int(floor((Lv * 0.3))) + 1), 3)`

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): removes the caster's buff of skill 617 (Okaranman) — `RemoveSelfBuffer(617)`
  - when `CountBufferBase.get_Peak() AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 617) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)`
- `calcPlayerToMobDamage` (damage calculation against a monster): adds the buff-provided flat damage to the template — `SetBufferConstantDamage(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), damageCount)`

**Other recovered parameters**

- **Number of damage events** (`damageCount`): `System.Math.Min((int(floor((Lv * 0.3))) + 1), 3)`

**Buff values** (every recovered field; durations in seconds)

**Buff `SwordMoveBuf`**
- **Modifies normal attacks**: `NormalAttackAction` looks this buff up while it builds the normal-attack damage / hit logic.
- Attached to this skill via `caller2:SwordMove$$AddBuf<-HassohappaAction$$ActionSkillEvent` (no direct constructor call in the skill's own code).
- Buff hook methods: `CheckDamageInvalid`, `DamageInvalid`, `EndSwordMove`
- `Value` = `((damageInvalid & 1))` _(when BuffEffectActive ne 0)_
- `Value` = `0` _(when BuffEffectActive eq 0)_
- Buff fields set in the constructor (all recovered):
  - `Level` = `257` = 257
  - `BuffEffectActive` = `1` = 1
  - `BufEffectTakeUid` = `-1` = -1
  - `damageInvalid` = `(damageInvalid & 1)`
- Hook `DamageInvalid`: `damageInvalid`=0
- Hook `EndSwordMove`: `damageInvalid`=0

Parameter meanings (inferred from the `SkillBufferId` names):

- `Value`: generic value (meaning set by the code that reads the buff)

_Raw recovered data (every method item): [trees/MononofuSkill.md](../trees/MononofuSkill.md) — uid 617_

---

### ซังเทเซตเท็ตสึ (Zanteisettetsu) · uid 618

<img src="../../icons/sk_618.png" width="40" alt="icon"> 
**Tree:** モノノフスキル (`MononofuSkill`, tier 3) · **Type:** Attack · **Max Lv:** 70 · **Weapons:** Katana · **Requires:** มากาดาจิ · **Flags:** MercenaryCanUseSkill · **Client class:** `ZanteisettetsuAction`

> ฟาดฟันศัตรูด้วยความโกรธอย่างต่อเนื่อง
> ความเสียหายไม่มีผลหนึ่งครั้งและโจมตีกลับ
> การโจมตีกลับมีโอกาสติด[ลดการป้องกัน] 

**How it works**

- Attack skill of the モノノフスキル tree (tier 3, max Lv 70); usable with Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- It can inflict a status ailment (chance and type below).
- Its buff exposes motion / combo hooks, so it changes the attack pattern while active (heuristic; the client has no explicit flag).
- `NormalAttackAction` looks its buff up and changes how normal attacks run while it is active.
- Damage (`calcPlayerToMobDamage` x3; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×1.2 at Lv1 to 3 at Lv10; skill multiplier ×6 at Lv1 to 15 at Lv10; skill multiplier depends on live values (formula below); flat damage +10 at Lv1 to 100 at Lv10; flat damage +30 at Lv1 to 300 at Lv10; flat damage +300
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Breaking (10), None (0).
- Buffs:
  - `HeavenlyStarBuf`: lasts `10` s
  - `ZanteisettetsuBuf`: marker buff (no parameters; other code tests whether it is present)
  - `CountBufferBase`
- Other client code reads this skill (5 lookups; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetSubWeaponType.item(actarAction))`
  - when `mainWeapon == Bow`
- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
  - when `mainWeapon != Bow`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 10 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionSkillEvent` — on an animation/skill event during the motion: 1 call, 1 set
- `ActionStart` — when the cast starts: 1 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 4 set, 9 tpl, 2 call, 1 info
- `CheckDamageInvalid` — skill-specific method: 2 call
- `.<>c__DisplayClass32_0::<ActionSkillEvent>b__1` — skill-specific method: 2 call
- `.<>c__DisplayClass33_0::<ActionStart>b__0` — skill-specific method: 1 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 1.2 | 1.4 | 1.6 | 1.8 | 2 | 2.2 | 2.4 | 2.6 | 2.8 | 3 |
| SkillRate × | 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13 | 14 | 15 |
| Flat dmg + | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |
| Flat dmg + | 30 | 60 | 90 | 120 | 150 | 180 | 210 | 240 | 270 | 300 |
| Flat dmg + | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((int(((CountBufferBase.GetParam(20) * ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 620, 1) * 25) + 150)) * 0.5)) + 1300)) / 100)`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv + (Lv << 2)) << 1))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv * 20) + 100)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, playerAction)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[FirstAttackRate]` = `(PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetConstant[BufferConstantDamage]` = `0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `((Lv * 30))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv * 100) + 500)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(300)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((int(((CountBufferBase.GetParam(20) * ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 620, 1) * 25) + 150)) * 0.5)) + 1300)) / 100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 618
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Chance field `abnormalPercent` (Chance to inflict the skill's status ailment (%)): `((Lv + (Lv << 2)) + 50)` → Lv1..10 [55, 60, 65, 70, 75, 80, 85, 90, 95, 100]
- Rolls `abnormalPercent`% to inflict **Breaking (10)** (`calcPlayerToMobDamage`)
- Marks the hit with ailment **Breaking (10)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 10, abnormalPercent, playerAction)`
- Marks the hit with ailment **None (0)** (`CheckDamageInvalid`)
  - when `SkillDamageData.IsInactivityAbnormal(damageData) AND hasBuff(618)`

**Buffs and effects it installs or removes**

- `ActionSkillEvent` (on an animation/skill event during the motion): removes the caster's buff of skill 618 (Zanteisettetsu) — `RemoveSelfBuffer(618)`
  - when `!UnityEngine.Object.op_Equality(actarAction) AND ((param eq 100 ? 1 : 0) & (IsOtherPlayer eq 0 ? 1 : 0)) eq 0 AND ActionRange ne -1 AND hasBuff(618)`
- `ActionStart` (when the cast starts): adds the caster's buff of skill 618 (Zanteisettetsu) — `AddSelfBuffer(618, Lv, Id)`
  - when `!UnityEngine.Object.op_Equality(actarAction) AND (SkillParam & 16) eq 0 AND ActionRange ne -1`
- `CheckDamageInvalid` (method): removes the caster's buff of skill 618 (Zanteisettetsu) — `RemoveSelfBuffer(618)`
  - when `SkillDamageData.IsInactivityAbnormal(damageData) AND hasBuff(618) OR !SkillDamageData.IsInactivityAbnormal(damageData) AND hasBuff(618)`
- `.<>c__DisplayClass32_0::<ActionSkillEvent>b__1` (method): constructs `HeavenlyStarBuf` — `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 620, 1))`
  - when `(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 620, 1) & 255) ne 0`
- `.<>c__DisplayClass32_0::<ActionSkillEvent>b__1` (method): adds the caster's buff of `new HeavenlyStarBuf` — `AddSelfBuffer(new HeavenlyStarBuf, 0)`
  - when `(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 620, 1) & 255) ne 0`
- `.<>c__DisplayClass33_0::<ActionStart>b__0` (method): removes the caster's buff of skill 618 (Zanteisettetsu) — `RemoveSelfBuffer(618)`

**Buff values** (every recovered field; durations in seconds)

**Buff `HeavenlyStarBuf`**
- **Changes the attack pattern**: the buff object drives a motion/combo chain (`SetAttackSkillId`).
- **Modifies normal attacks**: `NormalAttackAction` looks this buff up while it builds the normal-attack damage / hit logic.
- Buff hook methods: `CheckExpDefFluctuate`, `IllusionarySceneReset`, `Reset`, `SetAttackSkillId`
- Duration: `10` s
- Buff fields set in the constructor (all recovered):
  - `isExpDefFluctuate` = `1` = 1
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `Reset`: `Count`=0; `LeftTime`=30; `prevSkillId`=0
- Hook `IllusionarySceneReset`: `Count`=max((((illusionarySceneParry & 1) + count) + ([TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 627)+0x20] ge 50 ? 0xfffffffe : 0xfffffffd)), 0); `LeftTime`=(EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) eq 8 ? (((count + (count << 2)) << 1) + 10) : ((count + (count << 2)) << 1)); `prevSkillId`=0; `Count`=max((((illusionarySceneParry & 1) + count) + 0xfffffffd), 0)
- Hook `SetAttackSkillId`: `prevSkillId`=skillId
**Buff `ZanteisettetsuBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff fields set in the constructor (all recovered):
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `IsSelfAction` = `257` = 257
  - `BuffEffectActive` = `1` = 1
  - `BufEffectTakeUid` = `-1` = -1
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:HeavenlyStarBuf$$.ctor<-ZanteisettetsuAction.<>c__DisplayClass32_0$$<ActionSkillEvent>b__1` (no direct constructor call in the skill's own code).
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

**Where else this skill takes effect**

- Effect applied in `ZanteisettetsuAction$$ActionSkillEvent` (17 guarded paths):
  - when `ActionRange ne -1` AND `((param eq 100 ? 1 : 0) & (IsOtherPlayer eq 0 ? 1 : 0)) eq 0`
    - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 618, 0, ?x3)`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `SkillBufferManager$$RemoveSelfBuffer`
  - when `ActionRange ne -1` AND `((param eq 100 ? 1 : 0) & (IsOtherPlayer eq 0 ? 1 : 0)) eq 0` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 620, stkp(-56), meta(0x399f910, Method$SkillBufferManager.TryGetBuf<HeavenlyStarBuf>())) & 1) ne 0` AND `IsOtherPlayer eq 0`
    - returns `GameManager.SkillEvent(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), UnityEngine.Component.get_gameObject(actarAction, 0, ?x2, ?x3), PlayerAttackBase.get_ActionID(), Id)`
    - set `isLocalizeHeavenlyStar` = `1`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `Singleton<object>$$get_Instance`, `virtual PlayerAttackBase.get_ActionID`, `UI3DLabelManager$$SetSkillPopUp`, `0x165db78`, `System.Action<bool>$$.ctor`
  - when `ActionRange ne -1` AND `((param eq 100 ? 1 : 0) & (IsOtherPlayer eq 0 ? 1 : 0)) eq 0` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 620, stkp(-56), meta(0x399f910, Method$SkillBufferManager.TryGetBuf<HeavenlyStarBuf>())) & 1) ne 0` AND `IsOtherPlayer ne 0`
    - returns `0x165d8dc(([targetDamageData+0x10] + ([targetDamageData+0x18] << 3)), heavenlyStarDamageData, ?x2, ?x3)`
    - set `isLocalizeHeavenlyStar` = `1`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `Singleton<object>$$get_Instance`, `virtual PlayerAttackBase.get_ActionID`, `UI3DLabelManager$$SetSkillPopUp`, `0x165db78`, `System.Action<bool>$$.ctor`
  - when `ActionRange ne -1` AND `((param eq 100 ? 1 : 0) & (IsOtherPlayer eq 0 ? 1 : 0)) eq 0` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 620, stkp(-56), meta(0x399f910, Method$SkillBufferManager.TryGetBuf<HeavenlyStarBuf>())) & 1) ne 0` AND `IsOtherPlayer eq 0`
    - returns `GameManager.SkillEvent(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), UnityEngine.Component.get_gameObject(actarAction, 0, ?x2, ?x3), PlayerAttackBase.get_ActionID(), Id)`
    - set `isLocalizeHeavenlyStar` = `1`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `Singleton<object>$$get_Instance`, `virtual PlayerAttackBase.get_ActionID`, `UI3DLabelManager$$SetSkillPopUp`, `0x165db78`, `System.Action<bool>$$.ctor`
  - when `ActionRange ne -1` AND `((param eq 100 ? 1 : 0) & (IsOtherPlayer eq 0 ? 1 : 0)) eq 0` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 620, stkp(-56), meta(0x399f910, Method$SkillBufferManager.TryGetBuf<HeavenlyStarBuf>())) & 1) ne 0` AND `IsOtherPlayer ne 0`
    - returns `System.Collections.Generic.List<object>.AddWithResize(targetDamageData, heavenlyStarDamageData, meta(0), ?x3)`
    - set `isLocalizeHeavenlyStar` = `1`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `Singleton<object>$$get_Instance`, `virtual PlayerAttackBase.get_ActionID`, `UI3DLabelManager$$SetSkillPopUp`, `0x165db78`, `System.Action<bool>$$.ctor`
  - when `ActionRange ne -1` AND `((param eq 100 ? 1 : 0) & (IsOtherPlayer eq 0 ? 1 : 0)) eq 0` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 620, stkp(-56), meta(0x399f910, Method$SkillBufferManager.TryGetBuf<HeavenlyStarBuf>())) & 1) ne 0` AND `IsOtherPlayer eq 0`
    - returns `GameManager.SkillEvent(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), UnityEngine.Component.get_gameObject(actarAction, 0, ?x2, ?x3), PlayerAttackBase.get_ActionID(), Id)`
    - set `isLocalizeHeavenlyStar` = `1`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `Singleton<object>$$get_Instance`, `virtual PlayerAttackBase.get_ActionID`, `UI3DLabelManager$$SetSkillPopUp`, `0x165db78`, `System.Action<bool>$$.ctor`
  - when `ActionRange ne -1` AND `((param eq 100 ? 1 : 0) & (IsOtherPlayer eq 0 ? 1 : 0)) eq 0` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 620, stkp(-56), meta(0x399f910, Method$SkillBufferManager.TryGetBuf<HeavenlyStarBuf>())) & 1) ne 0` AND `IsOtherPlayer ne 0`
    - returns `0x165d8dc(([targetDamageData+0x10] + ([targetDamageData+0x18] << 3)), heavenlyStarDamageData, [targetDamageData+0x18], ?x3)`
    - set `isLocalizeHeavenlyStar` = `1`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `Singleton<object>$$get_Instance`, `virtual PlayerAttackBase.get_ActionID`, `UI3DLabelManager$$SetSkillPopUp`, `0x165db78`, `System.Action<bool>$$.ctor`
  - when `ActionRange ne -1` AND `((param eq 100 ? 1 : 0) & (IsOtherPlayer eq 0 ? 1 : 0)) eq 0` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 620, stkp(-56), meta(0x399f910, Method$SkillBufferManager.TryGetBuf<HeavenlyStarBuf>())) & 1) ne 0` AND `IsOtherPlayer eq 0`
    - returns `GameManager.SkillEvent(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), UnityEngine.Component.get_gameObject(actarAction, 0, ?x2, ?x3), PlayerAttackBase.get_ActionID(), Id)`
    - set `isLocalizeHeavenlyStar` = `1`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `Singleton<object>$$get_Instance`, `virtual PlayerAttackBase.get_ActionID`, `UI3DLabelManager$$SetSkillPopUp`, `0x165db78`, `System.Action<bool>$$.ctor`
- Effect applied in `ZanteisettetsuAction$$CheckDamageInvalid` (3 guarded paths):
  - always
    - returns `1`
    - calls `SkillBufferManager$$RemoveSelfBuffer`, `SkillDamageData$$set_Damage`, `SkillDamageData$$IsInactivityAbnormal`, `SkillDamageData$$SetAbnormalType`
  - always
    - returns `1`
    - calls `SkillBufferManager$$RemoveSelfBuffer`, `SkillDamageData$$set_Damage`, `SkillDamageData$$IsInactivityAbnormal`
  - always
    - returns `0`
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
- Code that reads this skill's level / buff by constant id: `MercenaryActionManager$$Damaged (ContainsBuffer)`, `MobaPlayerActionManager$$ReceiveDamaged (ContainsBuffer)`, `PlayerActionManager$$Damaged (ContainsBuffer)`, `ZanteisettetsuAction$$ActionSkillEvent (ContainsBuffer)`, `ZanteisettetsuAction$$CheckDamageInvalid (ContainsBuffer)`

_Raw recovered data (every method item): [trees/MononofuSkill.md](../trees/MononofuSkill.md) — uid 618_

---

### ชูคุจิ (Shukuchi) · uid 619

<img src="../../icons/sk_619.png" width="40" alt="icon"> 
**Tree:** モノノフスキル (`MononofuSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 70 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** บุชิโด · **Client class:** `ShukuchiAction` · **Client class:** `Shukuchi` (passive mastery)

> เทคนิคที่ทำให้เคลื่อนไหวได้อย่างรวดเร็ว
> สามารถเคลื่อนไหวได้อย่างรวดเร็วในระยะการโจมตีปกติ
> เพิ่มความสามารถการโจมตีปกติในครั้งถัดไปเล็กน้อย
> จะไม่เพิ่มขึ้นถ้าติด[เชื่องช้า/หยุดนิ่ง]อยู่

**How it works**

- Mastery skill of the モノノフスキル tree (tier 3, max Lv 70); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- `NormalAttackAction` looks its buff up and changes how normal attacks run while it is active.
- Its buff raises normal-attack damage (`NormalAttackRate` / `NormalAttackConstantDamage`).
- Buffs:
  - `ShukuchiBuf`; Lv1 → Lv10: NormalAttackRate (normal-attack damage multiplier (%)) 400 → 400, NormalAttackRate (normal-attack damage multiplier (%)) 5 → 50, Value (generic value (meaning set by the code that reads the buff)) 0 → 50
- Other client code reads this skill (15 lookups; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(-1)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 1 set
- `ActionStart` — when the cast starts: 1 set, 1 call
- `InitializeOthers` — setup used when another player's client replays the action: 2 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 619
- No proration slot: ExpType None: no proration slot.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `int((NextActionRrange + CharacterActionManagerBase.get_Size()))`
  - when `UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<CharacterActionManagerBase>(target), 0)`

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): adds the caster's buff of skill 619 (Shukuchi) — `AddSelfBuffer(619, Lv, Id)`

**Other recovered parameters**

- **Loop / hit-repeat count** (`LoopParam`): `int((NextActionRrange + CharacterActionManagerBase.get_Size()))` _(when UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<CharacterActionManagerBase>(target), 0))_

**Buff values** (every recovered field; durations in seconds)

**Buff `ShukuchiBuf`**
- **Modifies normal attacks**: `NormalAttackAction` looks this buff up while it builds the normal-attack damage / hit logic.
- **Boosts normal-attack damage** through the `NormalAttackRate` / `NormalAttackConstantDamage` parameters.
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `InvalidUnannouncedDestination`, `ValidUnannouncedDestination`

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| NormalAttackRate | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 |
| NormalAttackRate | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |
| Value | 0 | 2 | 4 | 8 | 12 | 18 | 24 | 32 | 40 | 50 |

- Buff fields set in the constructor (all recovered):
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
  - `BufEffectTakeUid` = `-1` = -1
- Hook `ValidUnannouncedDestination`: `unannouncedDestination`=1
- Hook `InvalidUnannouncedDestination`: `unannouncedDestination`=0

Parameter meanings (inferred from the `SkillBufferId` names):

- `NormalAttackRate`: normal-attack damage multiplier (%)
- `Value`: generic value (meaning set by the code that reads the buff)

**In-game level notes**

- Lv8: *สามารถใช้ได้กับสกิลคาตานะ

**Where else this skill takes effect**

- Effect applied in `PlayerSecondaryStatus$$get_AtkMpRecovery` (294 guarded paths, truncated):
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
- Effect applied in `MobaPlayerBattleManager$$OnBattleEnd` (8 guarded paths):
  - when `attackDelay gt 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `IsUnsheathe eq 0`
    - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
    - set `IsDelay` = `1`
    - set `IsAssistMove` = `0`
    - calls `KadarElexioBuf$$BattleEnd`, `SkillFactory$$CreateSkill`, `Singleton<object>$$get_Instance`, `GameManager$$ActionCancel`, `SkillBufferManager$$RemoveSelfBuffer`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`
  - when `attackDelay gt 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `IsUnsheathe eq 0`
    - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
    - set `IsDelay` = `1`
    - set `IsAssistMove` = `0`
    - calls `KadarElexioBuf$$BattleEnd`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`, `UIFadeManager$$FadeOutBattleEnd`
  - when `attackDelay gt 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) eq 0` AND `IsUnsheathe eq 0`
    - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
    - set `IsDelay` = `1`
    - set `IsAssistMove` = `0`
    - calls `SkillFactory$$CreateSkill`, `Singleton<object>$$get_Instance`, `GameManager$$ActionCancel`, `SkillBufferManager$$RemoveSelfBuffer`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`, `UIFadeManager$$FadeOutBattleEnd`
  - when `attackDelay gt 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) eq 0` AND `IsUnsheathe eq 0`
    - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
    - set `IsDelay` = `1`
    - set `IsAssistMove` = `0`
    - calls `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`, `UIFadeManager$$FadeOutBattleEnd`
  - when `attackDelay le 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `IsUnsheathe eq 0`
    - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
    - set `IsAssistMove` = `0`
    - calls `KadarElexioBuf$$BattleEnd`, `SkillFactory$$CreateSkill`, `Singleton<object>$$get_Instance`, `GameManager$$ActionCancel`, `SkillBufferManager$$RemoveSelfBuffer`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`
  - when `attackDelay le 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `IsUnsheathe eq 0`
    - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
    - set `IsAssistMove` = `0`
    - calls `KadarElexioBuf$$BattleEnd`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`, `UIFadeManager$$FadeOutBattleEnd`
  - when `attackDelay le 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) eq 0` AND `IsUnsheathe eq 0`
    - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
    - set `IsAssistMove` = `0`
    - calls `SkillFactory$$CreateSkill`, `Singleton<object>$$get_Instance`, `GameManager$$ActionCancel`, `SkillBufferManager$$RemoveSelfBuffer`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`, `UIFadeManager$$FadeOutBattleEnd`
  - when `attackDelay le 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) eq 0` AND `IsUnsheathe eq 0`
    - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
    - set `IsAssistMove` = `0`
    - calls `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`, `UIFadeManager$$FadeOutBattleEnd`
- Effect applied in `PlayerBattleManager$$OnBattleEnd` (8 guarded paths):
  - when `attackDelay gt 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `IsUnsheathe eq 0`
    - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
    - set `IsDelay` = `1`
    - set `IsAssistMove` = `0`
    - calls `KadarElexioBuf$$BattleEnd`, `SkillFactory$$CreateSkill`, `Singleton<object>$$get_Instance`, `GameManager$$ActionCancel`, `SkillBufferManager$$RemoveSelfBuffer`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`
  - when `attackDelay gt 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `IsUnsheathe eq 0`
    - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
    - set `IsDelay` = `1`
    - set `IsAssistMove` = `0`
    - calls `KadarElexioBuf$$BattleEnd`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`, `UIFadeManager$$FadeOutBattleEnd`
  - when `attackDelay gt 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) eq 0` AND `IsUnsheathe eq 0`
    - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
    - set `IsDelay` = `1`
    - set `IsAssistMove` = `0`
    - calls `SkillFactory$$CreateSkill`, `Singleton<object>$$get_Instance`, `GameManager$$ActionCancel`, `SkillBufferManager$$RemoveSelfBuffer`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`, `UIFadeManager$$FadeOutBattleEnd`
  - when `attackDelay gt 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) eq 0` AND `IsUnsheathe eq 0`
    - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
    - set `IsDelay` = `1`
    - set `IsAssistMove` = `0`
    - calls `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`, `UIFadeManager$$FadeOutBattleEnd`
  - when `attackDelay le 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `IsUnsheathe eq 0`
    - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
    - set `IsAssistMove` = `0`
    - calls `KadarElexioBuf$$BattleEnd`, `SkillFactory$$CreateSkill`, `Singleton<object>$$get_Instance`, `GameManager$$ActionCancel`, `SkillBufferManager$$RemoveSelfBuffer`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`
  - when `attackDelay le 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `IsUnsheathe eq 0`
    - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
    - set `IsAssistMove` = `0`
    - calls `KadarElexioBuf$$BattleEnd`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`, `UIFadeManager$$FadeOutBattleEnd`
  - when `attackDelay le 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) eq 0` AND `IsUnsheathe eq 0`
    - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
    - set `IsAssistMove` = `0`
    - calls `SkillFactory$$CreateSkill`, `Singleton<object>$$get_Instance`, `GameManager$$ActionCancel`, `SkillBufferManager$$RemoveSelfBuffer`, `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`, `UIFadeManager$$FadeOutBattleEnd`
  - when `attackDelay le 0` AND `(SkillBufferManager.TryGetBuf(?blr, 118, stkp(-40), 0) & 1) eq 0` AND `IsUnsheathe eq 0`
    - returns `UIFadeManager.FadeOutBattleEnd([Singleton<object>.get_Instance(meta(0x3974a18, Method$Singleton<UIMainManager>.get_Instance()), ?x1, ?x2, ?x3)+0x1e0], 0, ?x2, ?x3)`
    - set `IsAssistMove` = `0`
    - calls `Singleton<object>$$get_Instance`, `GameManager$$BattleEndCheck`, `Singleton<object>$$get_Instance`, `UIFadeManager$$FadeOutBattleEnd`
- Effect applied in `CloningTechniqueAction$$ActionStart` (9 guarded paths):
  - when `SkillLv(619) ge 1` AND `(SkillActionBase.checkPercent(this, 100, ((SkillLv(619) + (SkillLv(619) << 2)) << 1), 0) & 1) ne 0`
    - returns `SkillActionBase.checkPercent(this, 100, ((SkillLv(619) + (SkillLv(619) << 2)) << 1), 0)`
    - set `_motionSpeed` = `100`
    - set `PlacePos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform([System.Linq.Enumerable.FirstOrDefault<object>(SkillActionManager.get_PlaceSkilList([[actionManager+0x30]+0x30], 0, ?x2, ?x3), meta(0), meta(0x397e778, Method$System.Li`
    - set `+0x128` = `?v1`
    - set `+0x12c` = `?v2`
    - set `shukuchi` = `1`
    - set `SkillIndividualFlag` = `1`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `SkillActionManager$$get_PlaceSkilList`
  - when `SkillLv(619) ge 1` AND `(SkillActionBase.checkPercent(this, 100, ((SkillLv(619) + (SkillLv(619) << 2)) << 1), 0) & 1) eq 0`
    - returns `SkillActionBase.checkPercent(this, 100, ((SkillLv(619) + (SkillLv(619) << 2)) << 1), 0)`
    - set `_motionSpeed` = `100`
    - set `PlacePos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform([System.Linq.Enumerable.FirstOrDefault<object>(SkillActionManager.get_PlaceSkilList([[actionManager+0x30]+0x30], 0, ?x2, ?x3), meta(0), meta(0x397e778, Method$System.Li`
    - set `+0x128` = `?v1`
    - set `+0x12c` = `?v2`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `SkillActionManager$$get_PlaceSkilList`
  - when `SkillLv(619) lt 1`
    - returns `SkillLv(619)`
    - set `_motionSpeed` = `100`
    - set `PlacePos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform([System.Linq.Enumerable.FirstOrDefault<object>(SkillActionManager.get_PlaceSkilList([[actionManager+0x30]+0x30], 0, ?x2, ?x3), meta(0), meta(0x397e778, Method$System.Li`
    - set `+0x128` = `?v1`
    - set `+0x12c` = `?v2`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `SkillActionManager$$get_PlaceSkilList`
  - when `SkillLv(619) ge 1` AND `(SkillActionBase.checkPercent(this, 100, ((SkillLv(619) + (SkillLv(619) << 2)) << 1), 0) & 1) ne 0`
    - returns `SkillActionBase.checkPercent(this, 100, ((SkillLv(619) + (SkillLv(619) << 2)) << 1), 0)`
    - set `_motionSpeed` = `100`
    - set `PlacePos` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(vtab(0x165db78(meta(0x39a9630, CloningTechniqueAction.<>c__DisplayClass51_0_TypeInfo), ?x1, ?x2, ?x3)), 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - set `+0x128` = `?v1`
    - set `+0x12c` = `?v2`
    - set `shukuchi` = `1`
    - set `SkillIndividualFlag` = `1`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `SkillActionManager$$get_PlaceSkilList`
  - when `SkillLv(619) ge 1` AND `(SkillActionBase.checkPercent(this, 100, ((SkillLv(619) + (SkillLv(619) << 2)) << 1), 0) & 1) eq 0`
    - returns `SkillActionBase.checkPercent(this, 100, ((SkillLv(619) + (SkillLv(619) << 2)) << 1), 0)`
    - set `_motionSpeed` = `100`
    - set `PlacePos` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(vtab(0x165db78(meta(0x39a9630, CloningTechniqueAction.<>c__DisplayClass51_0_TypeInfo), ?x1, ?x2, ?x3)), 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - set `+0x128` = `?v1`
    - set `+0x12c` = `?v2`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `SkillActionManager$$get_PlaceSkilList`
  - when `SkillLv(619) lt 1`
    - returns `SkillLv(619)`
    - set `_motionSpeed` = `100`
    - set `PlacePos` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(vtab(0x165db78(meta(0x39a9630, CloningTechniqueAction.<>c__DisplayClass51_0_TypeInfo), ?x1, ?x2, ?x3)), 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - set `+0x128` = `?v1`
    - set `+0x12c` = `?v2`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `SkillActionManager$$get_PlaceSkilList`
  - when `SkillLv(619) ge 1` AND `(SkillActionBase.checkPercent(this, 100, ((SkillLv(619) + (SkillLv(619) << 2)) << 1), 0) & 1) ne 0`
    - returns `SkillActionBase.checkPercent(this, 100, ((SkillLv(619) + (SkillLv(619) << 2)) << 1), 0)`
    - set `_motionSpeed` = `100`
    - set `PlacePos` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(vtab(0x165db78(meta(0x39a9630, CloningTechniqueAction.<>c__DisplayClass51_0_TypeInfo), ?x1, ?x2, ?x3)), 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - set `+0x128` = `?v1`
    - set `+0x12c` = `?v2`
    - set `shukuchi` = `1`
    - set `SkillIndividualFlag` = `1`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `0x165db78`
  - when `SkillLv(619) ge 1` AND `(SkillActionBase.checkPercent(this, 100, ((SkillLv(619) + (SkillLv(619) << 2)) << 1), 0) & 1) eq 0`
    - returns `SkillActionBase.checkPercent(this, 100, ((SkillLv(619) + (SkillLv(619) << 2)) << 1), 0)`
    - set `_motionSpeed` = `100`
    - set `PlacePos` = `UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(vtab(0x165db78(meta(0x39a9630, CloningTechniqueAction.<>c__DisplayClass51_0_TypeInfo), ?x1, ?x2, ?x3)), 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - set `+0x128` = `?v1`
    - set `+0x12c` = `?v2`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `0x165db78`
- Effect applied in `IchijhinnokazeAratame$$InvokeShukuchi` (9 guarded paths):
  - when `SkillLv(631) ge 5` AND `nowAttackMode ne 2` AND `((nowAttackMode eq 1 ? 1 : 0) & (SkillLv(631) gt 9 ? 1 : 0)) ne 0` AND `SkillLv(619) ge 1`
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `0x165db78`
  - when `SkillLv(631) ge 5` AND `nowAttackMode ne 2` AND `((nowAttackMode eq 1 ? 1 : 0) & (SkillLv(631) gt 9 ? 1 : 0)) ne 0` AND `SkillLv(619) lt 1`
    - returns `0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`
  - when `SkillLv(631) ge 5` AND `nowAttackMode ne 2` AND `((nowAttackMode eq 1 ? 1 : 0) & (SkillLv(631) gt 9 ? 1 : 0)) eq 0`
    - returns `0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_SkillManager`
  - when `SkillLv(631) ge 5` AND `nowAttackMode eq 2` AND `SkillLv(619) ge 1`
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `0x165db78`
  - when `SkillLv(631) ge 5` AND `nowAttackMode eq 2` AND `SkillLv(619) lt 1`
    - returns `0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`
  - when `SkillLv(631) lt 5`
    - returns `0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_SkillManager`
  - always
    - returns `0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`
  - always
    - returns `0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`
- Effect applied in `IchijhinnokazeBuf$$Updata` (8 guarded paths):
  - when `isFieldLeave eq 0` AND `isBattleActive eq 0` AND `isUpdateWeapon ne 0`
    - returns `BufferEffectManager.SkillBufferEffectPlay(effectManager, this, 0, 0)`
    - set `isPutUpWeapon` = `1`
    - set `isUpdateWeapon` = `0`
    - calls `IchijhinnokazeBuf$$CheckBattleActive`, `IchijhinnokazeBuf$$CheckPlayLoopMotion`, `Singleton<object>$$get_Instance`, `InputManager$$get_LeftInputKey`, `IchijhinnokazeBuf$$TakeStop`, `IchijhinnokazeBuf$$CheckPlayMotion`, `BufferEffectManager$$SkillBufferEffectPlay`
  - when `isFieldLeave eq 0` AND `isBattleActive eq 0` AND `isUpdateWeapon ne 0`
    - returns `IchijhinnokazeBuf.CheckPlayMotion(this, ?x1, ?x2, ?x3)`
    - set `isPutUpWeapon` = `1`
    - calls `IchijhinnokazeBuf$$CheckBattleActive`, `IchijhinnokazeBuf$$CheckPlayLoopMotion`, `Singleton<object>$$get_Instance`, `InputManager$$get_LeftInputKey`, `IchijhinnokazeBuf$$TakeStop`, `IchijhinnokazeBuf$$CheckPlayMotion`
  - when `isFieldLeave eq 0` AND `isBattleActive eq 0` AND `isUpdateWeapon eq 0`
    - returns `BufferEffectManager.SkillBufferEffectStop(effectManager, IchijhinnokazeBuf.get_SkillId(), 0, ?x3)`
    - set `isPutUpWeapon` = `1`
    - set `isUpdateWeapon` = `1`
    - calls `IchijhinnokazeBuf$$CheckBattleActive`, `IchijhinnokazeBuf$$CheckPlayLoopMotion`, `Singleton<object>$$get_Instance`, `InputManager$$get_LeftInputKey`, `IchijhinnokazeBuf$$TakeStop`, `IchijhinnokazeBuf$$CheckPlayMotion`, `virtual IchijhinnokazeBuf.get_SkillId`, `BufferEffectManager$$SkillBufferEffectStop`
  - when `isFieldLeave eq 0` AND `isBattleActive eq 0` AND `isUpdateWeapon eq 0`
    - returns `IchijhinnokazeBuf.CheckPlayMotion(this, ?x1, ?x2, ?x3)`
    - set `isPutUpWeapon` = `1`
    - calls `IchijhinnokazeBuf$$CheckBattleActive`, `IchijhinnokazeBuf$$CheckPlayLoopMotion`, `Singleton<object>$$get_Instance`, `InputManager$$get_LeftInputKey`, `IchijhinnokazeBuf$$TakeStop`, `IchijhinnokazeBuf$$CheckPlayMotion`
  - when `isFieldLeave eq 0` AND `isBattleActive eq 0` AND `isUpdateWeapon ne 0`
    - returns `BufferEffectManager.SkillBufferEffectPlay(effectManager, this, 0, 0)`
    - set `isPutUpWeapon` = `1`
    - set `isUpdateWeapon` = `0`
    - calls `IchijhinnokazeBuf$$CheckBattleActive`, `IchijhinnokazeBuf$$CheckPlayLoopMotion`, `Singleton<object>$$get_Instance`, `InputManager$$get_LeftInputKey`, `IchijhinnokazeBuf$$CheckPlayMotion`, `BufferEffectManager$$SkillBufferEffectPlay`
  - when `isFieldLeave eq 0` AND `isBattleActive eq 0` AND `isUpdateWeapon ne 0`
    - returns `IchijhinnokazeBuf.CheckPlayMotion(this, ?x1, ?x2, ?x3)`
    - set `isPutUpWeapon` = `1`
    - calls `IchijhinnokazeBuf$$CheckBattleActive`, `IchijhinnokazeBuf$$CheckPlayLoopMotion`, `Singleton<object>$$get_Instance`, `InputManager$$get_LeftInputKey`, `IchijhinnokazeBuf$$CheckPlayMotion`
  - when `isFieldLeave eq 0` AND `isBattleActive eq 0` AND `isUpdateWeapon eq 0`
    - returns `BufferEffectManager.SkillBufferEffectStop(effectManager, IchijhinnokazeBuf.get_SkillId(), 0, ?x3)`
    - set `isPutUpWeapon` = `1`
    - set `isUpdateWeapon` = `1`
    - calls `IchijhinnokazeBuf$$CheckBattleActive`, `IchijhinnokazeBuf$$CheckPlayLoopMotion`, `Singleton<object>$$get_Instance`, `InputManager$$get_LeftInputKey`, `IchijhinnokazeBuf$$CheckPlayMotion`, `virtual IchijhinnokazeBuf.get_SkillId`, `BufferEffectManager$$SkillBufferEffectStop`
  - when `isFieldLeave eq 0` AND `isBattleActive eq 0` AND `isUpdateWeapon eq 0`
    - returns `IchijhinnokazeBuf.CheckPlayMotion(this, ?x1, ?x2, ?x3)`
    - set `isPutUpWeapon` = `1`
    - calls `IchijhinnokazeBuf$$CheckBattleActive`, `IchijhinnokazeBuf$$CheckPlayLoopMotion`, `Singleton<object>$$get_Instance`, `InputManager$$get_LeftInputKey`, `IchijhinnokazeBuf$$CheckPlayMotion`
- Effect applied in `MobaPlayerBattleManager$$AbnormalFear` (16 guarded paths):
  - when `SkillActionBase.get_ActionID() ge 1` AND `SkillActionBase.get_ActionID() ge 32` AND `SkillActionBase.get_ActionID() eq 0`
    - returns `1`
    - set `attackDelay` = `System.Math.Max(0, IPlayerStatusCalculator.get_Aspd(?blr), ?mi, ?x3)`
    - set `IsDelay` = `1`
    - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `interface IPlayerStatusCalculator.get_Aspd`, `interface IPlayerStatusCalculator.GetNextAtkTime`, `System.Math$$Max`, `Singleton<object>$$get_Instance`, `UIMainManager$$get_UIWaitTimer`
  - when `SkillActionBase.get_ActionID() ge 1` AND `SkillActionBase.get_ActionID() ge 32` AND `SkillActionBase.get_ActionID() eq 0`
    - returns `1`
    - set `attackDelay` = `System.Math.Max(0, IPlayerStatusCalculator.get_Aspd(?blr), ?mi, ?x3)`
    - set `IsDelay` = `1`
    - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `interface IPlayerStatusCalculator.get_Aspd`, `interface IPlayerStatusCalculator.GetNextAtkTime`, `System.Math$$Max`, `Singleton<object>$$get_Instance`, `UIMainManager$$get_UIWaitTimer`
  - when `SkillActionBase.get_ActionID() ge 1` AND `SkillActionBase.get_ActionID() ge 32` AND `SkillActionBase.get_ActionID() eq 0`
    - returns `1`
    - set `attackDelay` = `System.Math.Max(0, IPlayerStatusCalculator.get_Aspd(?blr), ?mi, ?x3)`
    - set `IsDelay` = `1`
    - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `interface IPlayerStatusCalculator.get_Aspd`, `interface IPlayerStatusCalculator.GetNextAtkTime`, `System.Math$$Max`, `Singleton<object>$$get_Instance`, `UIMainManager$$get_UIWaitTimer`
  - when `SkillActionBase.get_ActionID() ge 1` AND `SkillActionBase.get_ActionID() ge 32` AND `SkillActionBase.get_ActionID() eq 0`
    - returns `1`
    - set `attackDelay` = `System.Math.Max(0, IPlayerStatusCalculator.get_Aspd(?blr), ?mi, ?x3)`
    - set `IsDelay` = `1`
    - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `interface IPlayerStatusCalculator.get_Aspd`, `interface IPlayerStatusCalculator.GetNextAtkTime`, `System.Math$$Max`, `Singleton<object>$$get_Instance`, `UIMainManager$$get_UIWaitTimer`
  - when `SkillActionBase.get_ActionID() ge 1` AND `SkillActionBase.get_ActionID() ge 32` AND `SkillActionBase.get_ActionID() ne 0`
    - returns `1`
    - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `SkillComboManager$$get_ComboStarted`, `Singleton<object>$$get_Instance`, `GameManager$$ComboEnd`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`
  - when `SkillActionBase.get_ActionID() ge 1` AND `SkillActionBase.get_ActionID() ge 32` AND `SkillActionBase.get_ActionID() ne 0`
    - returns `1`
    - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `SkillComboManager$$get_ComboStarted`, `Singleton<object>$$get_Instance`, `GameManager$$ComboEnd`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`
  - when `SkillActionBase.get_ActionID() ge 1` AND `SkillActionBase.get_ActionID() ge 32` AND `SkillActionBase.get_ActionID() ne 0`
    - returns `1`
    - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `SkillComboManager$$get_ComboStarted`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$AbnormalPopLabelEnemyToPlayer`
  - when `SkillActionBase.get_ActionID() ge 1` AND `SkillActionBase.get_ActionID() ge 32` AND `SkillActionBase.get_ActionID() ne 0`
    - returns `1`
    - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `SkillComboManager$$get_ComboStarted`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$AbnormalPopLabelEnemyToPlayer`
- Effect applied in `PlayerBattleManager$$AbnormalFear` (16 guarded paths):
  - when `SkillActionBase.get_ActionID() ge 1` AND `SkillActionBase.get_ActionID() ge 32` AND `SkillActionBase.get_ActionID() eq 0`
    - returns `1`
    - set `attackDelay` = `System.Math.Max(0, IPlayerStatusCalculator.get_Aspd(?blr), ?mi, ?x3)`
    - set `IsDelay` = `1`
    - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `interface IPlayerStatusCalculator.get_Aspd`, `interface IPlayerStatusCalculator.GetNextAtkTime`, `System.Math$$Max`, `Singleton<object>$$get_Instance`, `UIMainManager$$get_UIWaitTimer`
  - when `SkillActionBase.get_ActionID() ge 1` AND `SkillActionBase.get_ActionID() ge 32` AND `SkillActionBase.get_ActionID() eq 0`
    - returns `1`
    - set `attackDelay` = `System.Math.Max(0, IPlayerStatusCalculator.get_Aspd(?blr), ?mi, ?x3)`
    - set `IsDelay` = `1`
    - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `interface IPlayerStatusCalculator.get_Aspd`, `interface IPlayerStatusCalculator.GetNextAtkTime`, `System.Math$$Max`, `Singleton<object>$$get_Instance`, `UIMainManager$$get_UIWaitTimer`
  - when `SkillActionBase.get_ActionID() ge 1` AND `SkillActionBase.get_ActionID() ge 32` AND `SkillActionBase.get_ActionID() eq 0`
    - returns `1`
    - set `attackDelay` = `System.Math.Max(0, IPlayerStatusCalculator.get_Aspd(?blr), ?mi, ?x3)`
    - set `IsDelay` = `1`
    - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `interface IPlayerStatusCalculator.get_Aspd`, `interface IPlayerStatusCalculator.GetNextAtkTime`, `System.Math$$Max`, `Singleton<object>$$get_Instance`, `UIMainManager$$get_UIWaitTimer`
  - when `SkillActionBase.get_ActionID() ge 1` AND `SkillActionBase.get_ActionID() ge 32` AND `SkillActionBase.get_ActionID() eq 0`
    - returns `1`
    - set `attackDelay` = `System.Math.Max(0, IPlayerStatusCalculator.get_Aspd(?blr), ?mi, ?x3)`
    - set `IsDelay` = `1`
    - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `interface IPlayerStatusCalculator.get_Aspd`, `interface IPlayerStatusCalculator.GetNextAtkTime`, `System.Math$$Max`, `Singleton<object>$$get_Instance`, `UIMainManager$$get_UIWaitTimer`
  - when `SkillActionBase.get_ActionID() ge 1` AND `SkillActionBase.get_ActionID() ge 32` AND `SkillActionBase.get_ActionID() ne 0`
    - returns `1`
    - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `SkillComboManager$$get_ComboStarted`, `Singleton<object>$$get_Instance`, `GameManager$$ComboEnd`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`
  - when `SkillActionBase.get_ActionID() ge 1` AND `SkillActionBase.get_ActionID() ge 32` AND `SkillActionBase.get_ActionID() ne 0`
    - returns `1`
    - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `SkillComboManager$$get_ComboStarted`, `Singleton<object>$$get_Instance`, `GameManager$$ComboEnd`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`
  - when `SkillActionBase.get_ActionID() ge 1` AND `SkillActionBase.get_ActionID() ge 32` AND `SkillActionBase.get_ActionID() ne 0`
    - returns `1`
    - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `SkillComboManager$$get_ComboStarted`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$AbnormalPopLabelEnemyToPlayer`
  - when `SkillActionBase.get_ActionID() ge 1` AND `SkillActionBase.get_ActionID() ge 32` AND `SkillActionBase.get_ActionID() ne 0`
    - returns `1`
    - calls `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `virtual SkillActionBase.get_ActionID`, `SkillComboManager$$get_ComboStarted`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_transform`, `UnityEngine.Transform$$get_position`, `UI3DLabelManager$$AbnormalPopLabelEnemyToPlayer`
- Effect applied in `ShukuchiAction$$CanActivated` (10 guarded paths):
  - when `TryGetValue.out2() ne 0` AND `SkillLv(619) ge 1`
    - returns `((0 | (SkillActionBase.get_ActionID() eq 0 ? 1 : 0)) ne 0 ? 1 : 0)`
    - calls `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`, `UnityEngine.Component$$get_gameObject`
  - when `TryGetValue.out2() ne 0` AND `SkillLv(619) ge 1`
    - returns `(((SkillActionBase.get_ActionID() lt 639 ? 1 : 0) | (SkillActionBase.get_ActionID() eq 0 ? 1 : 0)) ne 0 ? 1 : 0)`
    - calls `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`, `UnityEngine.Component$$get_gameObject`
  - when `TryGetValue.out2() ne 0` AND `SkillLv(619) ge 1`
    - returns `0`
    - calls `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`, `UnityEngine.Component$$get_gameObject`
  - when `TryGetValue.out2() ne 0` AND `SkillLv(619) ge 1`
    - returns `0`
    - calls `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`, `UnityEngine.Component$$get_gameObject`
  - when `TryGetValue.out2() ne 0` AND `SkillLv(619) lt 1`
    - returns `0`
    - calls `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`
  - when `SkillLv(619) ge 1` AND `SkillActionBase.get_ActionID() lt 609`
    - returns `((0 | (SkillActionBase.get_ActionID() eq 0 ? 1 : 0)) ne 0 ? 1 : 0)`
    - calls `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`, `UnityEngine.Component$$get_gameObject`
  - when `SkillLv(619) ge 1` AND `SkillActionBase.get_ActionID() ge 609`
    - returns `(((SkillActionBase.get_ActionID() lt 639 ? 1 : 0) | (SkillActionBase.get_ActionID() eq 0 ? 1 : 0)) ne 0 ? 1 : 0)`
    - calls `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`, `UnityEngine.Component$$get_gameObject`
  - when `SkillLv(619) ge 1`
    - returns `0`
    - calls `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillManager`, `UnityEngine.Component$$get_gameObject`
- Effect applied in `NormalAttackAction$$ActionPreparation` (300 guarded paths, truncated):
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
- Effect applied in `NormalAttackAction$$calcPlayerToMobDamage` (292 guarded paths, truncated):
  - when `(SkillIndividualFlag & 2) eq 0` AND `(System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue(meta(0), 804, stkp(-152), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) & 1) ne 0` AND `TryGetValue.out2() ne 0` AND `(MobBuffManager.TryGetBuff(MobActionManagerBase.get_BuffManager(mobAction), 10, stkp(-160), 0) & 1) ne 0`
    - returns `SkillBufferManager.SetBufferEffectActive(?blr, 678, 0, 0)`
    - set `calcTemplate` = `0x165db78(meta(0x399f088, SkillCalcTemplate_TypeInfo), ?x1, ?x2, ?x3)`
    - set `Delay` = `IPlayerStatusCalculator.GetNextAtkTime(?blr)`
    - set `SkillIndividualFlag` = `((SkillIndividualFlag | 2048) | 0x1000)`
    - template `SetCheck[HitCheck]` = `NormalAttackAction.get_ActionID()`
    - template `AddConstant[BaseDamage]` = `NormalAttackAction.CalcBaseDamage(this, vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), mobAction, ?stack)`
    - template `AddConstant[SkillConstantDamage]` = `SkillBufferManager.GetSkillBufferParam(vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), 56, 0, ?x3)`
    - template `AddConstant[SkillConstantDamage]` = `NormalAttackAction.calcRampageConstantDamage(this_tpl(), vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), 0, ?x3)`
    - template `AddConstant[SkillConstantDamage]` = `((ArkSaber.CalcConstantDamage(vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), mobAction, 0, ?x3) lt 0 ? (ArkSaber.CalcConstantDamage(vtab(0x165db78(meta(0x399f890, NormalAtt`
    - template `AddConstant[SkillConstantDamage]` = `UnannouncedDestination.CalcNormalAttackConstantDamage(?blr, 0, 0, ?x3)`
    - template `AddConstant[SkillConstantDamage]` = `IchijhinnokazeBuf.GetNormalAttackConstantDamage(?blr, 0, 0, ?x3)`
    - template `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), 0, ?x3)`
    - calls `0x165db78`, `NormalAttackAction.<>c__DisplayClass81_0$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillActionBase.DamageData$$.ctor`, `0x165d8dc`, `interface MobActionManagerBase.get_MobBattleStatus`, `SkillBufferManager$$SetBufferEffectActive`
  - when `(SkillIndividualFlag & 2) eq 0` AND `(System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue(meta(0), 804, stkp(-152), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) & 1) ne 0` AND `TryGetValue.out2() ne 0` AND `(MobBuffManager.TryGetBuff(MobActionManagerBase.get_BuffManager(mobAction), 10, stkp(-160), 0) & 1) ne 0`
    - returns `SkillBufferManager.SetBufferEffectActive(?blr, 678, 0, 0)`
    - set `calcTemplate` = `0x165db78(meta(0x399f088, SkillCalcTemplate_TypeInfo), ?x1, ?x2, ?x3)`
    - set `Delay` = `IPlayerStatusCalculator.GetNextAtkTime(?blr)`
    - set `SkillIndividualFlag` = `((SkillIndividualFlag | 2048) | 0x1000)`
    - template `SetCheck[HitCheck]` = `NormalAttackAction.get_ActionID()`
    - template `AddConstant[BaseDamage]` = `NormalAttackAction.CalcBaseDamage(this, vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), mobAction, ?stack)`
    - template `AddConstant[SkillConstantDamage]` = `SkillBufferManager.GetSkillBufferParam(vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), 56, 0, ?x3)`
    - template `AddConstant[SkillConstantDamage]` = `NormalAttackAction.calcRampageConstantDamage(this_tpl(), vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), 0, ?x3)`
    - template `AddConstant[SkillConstantDamage]` = `((ArkSaber.CalcConstantDamage(vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), mobAction, 0, ?x3) lt 0 ? (ArkSaber.CalcConstantDamage(vtab(0x165db78(meta(0x399f890, NormalAtt`
    - template `AddConstant[SkillConstantDamage]` = `UnannouncedDestination.CalcNormalAttackConstantDamage(?blr, 0, 0, ?x3)`
    - template `AddConstant[SkillConstantDamage]` = `IchijhinnokazeBuf.GetNormalAttackConstantDamage(?blr, 0, 0, ?x3)`
    - template `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), 0, ?x3)`
    - calls `0x165db78`, `NormalAttackAction.<>c__DisplayClass81_0$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillActionBase.DamageData$$.ctor`, `0x165d8dc`, `interface MobActionManagerBase.get_MobBattleStatus`, `SkillBufferManager$$SetBufferEffectActive`
  - when `(SkillIndividualFlag & 2) eq 0` AND `(System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue(meta(0), 804, stkp(-152), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) & 1) ne 0` AND `TryGetValue.out2() ne 0` AND `(MobBuffManager.TryGetBuff(MobActionManagerBase.get_BuffManager(mobAction), 10, stkp(-160), 0) & 1) ne 0`
    - returns `SkillBufferManager.SetBufferEffectActive(?blr, 678, 0, 0)`
    - set `calcTemplate` = `0x165db78(meta(0x399f088, SkillCalcTemplate_TypeInfo), ?x1, ?x2, ?x3)`
    - set `Delay` = `IPlayerStatusCalculator.GetNextAtkTime(?blr)`
    - set `SkillIndividualFlag` = `((SkillIndividualFlag | 2048) | 0x1000)`
    - template `SetCheck[HitCheck]` = `NormalAttackAction.get_ActionID()`
    - template `AddConstant[BaseDamage]` = `NormalAttackAction.CalcBaseDamage(this, vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), mobAction, ?stack)`
    - template `AddConstant[SkillConstantDamage]` = `SkillBufferManager.GetSkillBufferParam(vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), 56, 0, ?x3)`
    - template `AddConstant[SkillConstantDamage]` = `NormalAttackAction.calcRampageConstantDamage(this_tpl(), vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), 0, ?x3)`
    - template `AddConstant[SkillConstantDamage]` = `((ArkSaber.CalcConstantDamage(vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), mobAction, 0, ?x3) lt 0 ? (ArkSaber.CalcConstantDamage(vtab(0x165db78(meta(0x399f890, NormalAtt`
    - template `AddConstant[SkillConstantDamage]` = `UnannouncedDestination.CalcNormalAttackConstantDamage(?blr, 0, 0, ?x3)`
    - template `AddConstant[SkillConstantDamage]` = `IchijhinnokazeBuf.GetNormalAttackConstantDamage(?blr, 0, 0, ?x3)`
    - template `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), 0, ?x3)`
    - calls `0x165db78`, `NormalAttackAction.<>c__DisplayClass81_0$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillActionBase.DamageData$$.ctor`, `0x165d8dc`, `interface MobActionManagerBase.get_MobBattleStatus`, `SkillBufferManager$$SetBufferEffectActive`
  - when `(SkillIndividualFlag & 2) eq 0` AND `(System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue(meta(0), 804, stkp(-152), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) & 1) ne 0` AND `TryGetValue.out2() ne 0` AND `(MobBuffManager.TryGetBuff(MobActionManagerBase.get_BuffManager(mobAction), 10, stkp(-160), 0) & 1) ne 0`
    - returns `SkillBufferManager.SetBufferEffectActive(?blr, 678, 0, 0)`
    - set `calcTemplate` = `0x165db78(meta(0x399f088, SkillCalcTemplate_TypeInfo), ?x1, ?x2, ?x3)`
    - set `Delay` = `IPlayerStatusCalculator.GetNextAtkTime(?blr)`
    - set `SkillIndividualFlag` = `((SkillIndividualFlag | 2048) | 0x1000)`
    - template `SetCheck[HitCheck]` = `NormalAttackAction.get_ActionID()`
    - template `AddConstant[BaseDamage]` = `NormalAttackAction.CalcBaseDamage(this, vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), mobAction, ?stack)`
    - template `AddConstant[SkillConstantDamage]` = `SkillBufferManager.GetSkillBufferParam(vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), 56, 0, ?x3)`
    - template `AddConstant[SkillConstantDamage]` = `NormalAttackAction.calcRampageConstantDamage(this_tpl(), vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), 0, ?x3)`
    - template `AddConstant[SkillConstantDamage]` = `((ArkSaber.CalcConstantDamage(vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), mobAction, 0, ?x3) lt 0 ? (ArkSaber.CalcConstantDamage(vtab(0x165db78(meta(0x399f890, NormalAtt`
    - template `AddConstant[SkillConstantDamage]` = `UnannouncedDestination.CalcNormalAttackConstantDamage(?blr, 0, 0, ?x3)`
    - template `AddConstant[SkillConstantDamage]` = `IchijhinnokazeBuf.GetNormalAttackConstantDamage(?blr, 0, 0, ?x3)`
    - template `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), 0, ?x3)`
    - calls `0x165db78`, `NormalAttackAction.<>c__DisplayClass81_0$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillActionBase.DamageData$$.ctor`, `0x165d8dc`, `interface MobActionManagerBase.get_MobBattleStatus`, `SkillBufferManager$$SetBufferEffectActive`
  - when `(SkillIndividualFlag & 2) eq 0` AND `(System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue(meta(0), 804, stkp(-152), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) & 1) ne 0` AND `TryGetValue.out2() ne 0` AND `(MobBuffManager.TryGetBuff(MobActionManagerBase.get_BuffManager(mobAction), 10, stkp(-160), 0) & 1) ne 0`
    - returns `SkillBufferManager.SetBufferEffectActive(?blr, 678, 0, 0)`
    - set `calcTemplate` = `0x165db78(meta(0x399f088, SkillCalcTemplate_TypeInfo), ?x1, ?x2, ?x3)`
    - set `Delay` = `IPlayerStatusCalculator.GetNextAtkTime(?blr)`
    - set `SkillIndividualFlag` = `((SkillIndividualFlag | 2048) | 0x1000)`
    - template `SetCheck[HitCheck]` = `NormalAttackAction.get_ActionID()`
    - template `AddConstant[BaseDamage]` = `NormalAttackAction.CalcBaseDamage(this, vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), mobAction, ?stack)`
    - template `AddConstant[SkillConstantDamage]` = `SkillBufferManager.GetSkillBufferParam(vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), 56, 0, ?x3)`
    - template `AddConstant[SkillConstantDamage]` = `NormalAttackAction.calcRampageConstantDamage(this_tpl(), vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), 0, ?x3)`
    - template `AddConstant[SkillConstantDamage]` = `((ArkSaber.CalcConstantDamage(vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), mobAction, 0, ?x3) lt 0 ? (ArkSaber.CalcConstantDamage(vtab(0x165db78(meta(0x399f890, NormalAtt`
    - template `AddConstant[SkillConstantDamage]` = `UnannouncedDestination.CalcNormalAttackConstantDamage(?blr, 0, 0, ?x3)`
    - template `AddConstant[SkillConstantDamage]` = `IchijhinnokazeBuf.GetNormalAttackConstantDamage(?blr, 0, 0, ?x3)`
    - template `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), 0, ?x3)`
    - calls `0x165db78`, `NormalAttackAction.<>c__DisplayClass81_0$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillActionBase.DamageData$$.ctor`, `0x165d8dc`, `interface MobActionManagerBase.get_MobBattleStatus`, `SkillBufferManager$$SetBufferEffectActive`
  - when `(SkillIndividualFlag & 2) eq 0` AND `(System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue(meta(0), 804, stkp(-152), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) & 1) ne 0` AND `TryGetValue.out2() ne 0` AND `(MobBuffManager.TryGetBuff(MobActionManagerBase.get_BuffManager(mobAction), 10, stkp(-160), 0) & 1) ne 0`
    - returns `SkillBufferManager.SetBufferEffectActive(?blr, 678, 0, 0)`
    - set `calcTemplate` = `0x165db78(meta(0x399f088, SkillCalcTemplate_TypeInfo), ?x1, ?x2, ?x3)`
    - set `Delay` = `IPlayerStatusCalculator.GetNextAtkTime(?blr)`
    - set `SkillIndividualFlag` = `((SkillIndividualFlag | 2048) | 0x1000)`
    - template `SetCheck[HitCheck]` = `NormalAttackAction.get_ActionID()`
    - template `AddConstant[BaseDamage]` = `NormalAttackAction.CalcBaseDamage(this, vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), mobAction, ?stack)`
    - template `AddConstant[SkillConstantDamage]` = `SkillBufferManager.GetSkillBufferParam(vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), 56, 0, ?x3)`
    - template `AddConstant[SkillConstantDamage]` = `NormalAttackAction.calcRampageConstantDamage(this_tpl(), vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), 0, ?x3)`
    - template `AddConstant[SkillConstantDamage]` = `((ArkSaber.CalcConstantDamage(vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), mobAction, 0, ?x3) lt 0 ? (ArkSaber.CalcConstantDamage(vtab(0x165db78(meta(0x399f890, NormalAtt`
    - template `AddConstant[SkillConstantDamage]` = `UnannouncedDestination.CalcNormalAttackConstantDamage(?blr, 0, 0, ?x3)`
    - template `AddConstant[SkillConstantDamage]` = `IchijhinnokazeBuf.GetNormalAttackConstantDamage(?blr, 0, 0, ?x3)`
    - template `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), 0, ?x3)`
    - calls `0x165db78`, `NormalAttackAction.<>c__DisplayClass81_0$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillActionBase.DamageData$$.ctor`, `0x165d8dc`, `interface MobActionManagerBase.get_MobBattleStatus`, `SkillBufferManager$$SetBufferEffectActive`
  - when `(SkillIndividualFlag & 2) eq 0` AND `(System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue(meta(0), 804, stkp(-152), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) & 1) ne 0` AND `TryGetValue.out2() ne 0` AND `(MobBuffManager.TryGetBuff(MobActionManagerBase.get_BuffManager(mobAction), 10, stkp(-160), 0) & 1) ne 0`
    - returns `SkillBufferManager.SetBufferEffectActive(?blr, 678, 0, 0)`
    - set `calcTemplate` = `0x165db78(meta(0x399f088, SkillCalcTemplate_TypeInfo), ?x1, ?x2, ?x3)`
    - set `Delay` = `IPlayerStatusCalculator.GetNextAtkTime(?blr)`
    - set `SkillIndividualFlag` = `((SkillIndividualFlag | 2048) | 0x1000)`
    - template `SetCheck[HitCheck]` = `NormalAttackAction.get_ActionID()`
    - template `AddConstant[BaseDamage]` = `NormalAttackAction.CalcBaseDamage(this, vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), mobAction, ?stack)`
    - template `AddConstant[SkillConstantDamage]` = `SkillBufferManager.GetSkillBufferParam(vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), 56, 0, ?x3)`
    - template `AddConstant[SkillConstantDamage]` = `NormalAttackAction.calcRampageConstantDamage(this_tpl(), vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), 0, ?x3)`
    - template `AddConstant[SkillConstantDamage]` = `((ArkSaber.CalcConstantDamage(vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), mobAction, 0, ?x3) lt 0 ? (ArkSaber.CalcConstantDamage(vtab(0x165db78(meta(0x399f890, NormalAtt`
    - template `AddConstant[SkillConstantDamage]` = `UnannouncedDestination.CalcNormalAttackConstantDamage(?blr, 0, 0, ?x3)`
    - template `AddConstant[SkillConstantDamage]` = `IchijhinnokazeBuf.GetNormalAttackConstantDamage(?blr, 0, 0, ?x3)`
    - template `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), 0, ?x3)`
    - calls `0x165db78`, `NormalAttackAction.<>c__DisplayClass81_0$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillActionBase.DamageData$$.ctor`, `0x165d8dc`, `interface MobActionManagerBase.get_MobBattleStatus`, `SkillBufferManager$$SetBufferEffectActive`
  - when `(SkillIndividualFlag & 2) eq 0` AND `(System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue(meta(0), 804, stkp(-152), meta(0x3974650, Method$System.Collections.Generic.Dictionary<SkillId, SkillBufferDataBase>.TryGetValue())) & 1) ne 0` AND `TryGetValue.out2() ne 0` AND `(MobBuffManager.TryGetBuff(MobActionManagerBase.get_BuffManager(mobAction), 10, stkp(-160), 0) & 1) ne 0`
    - returns `SkillBufferManager.SetBufferEffectActive(?blr, 678, 0, 0)`
    - set `calcTemplate` = `0x165db78(meta(0x399f088, SkillCalcTemplate_TypeInfo), ?x1, ?x2, ?x3)`
    - set `Delay` = `IPlayerStatusCalculator.GetNextAtkTime(?blr)`
    - set `SkillIndividualFlag` = `((SkillIndividualFlag | 2048) | 0x1000)`
    - template `SetCheck[HitCheck]` = `NormalAttackAction.get_ActionID()`
    - template `AddConstant[BaseDamage]` = `NormalAttackAction.CalcBaseDamage(this, vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), mobAction, ?stack)`
    - template `AddConstant[SkillConstantDamage]` = `SkillBufferManager.GetSkillBufferParam(vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), 56, 0, ?x3)`
    - template `AddConstant[SkillConstantDamage]` = `NormalAttackAction.calcRampageConstantDamage(this_tpl(), vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), 0, ?x3)`
    - template `AddConstant[SkillConstantDamage]` = `((ArkSaber.CalcConstantDamage(vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), mobAction, 0, ?x3) lt 0 ? (ArkSaber.CalcConstantDamage(vtab(0x165db78(meta(0x399f890, NormalAtt`
    - template `AddConstant[SkillConstantDamage]` = `UnannouncedDestination.CalcNormalAttackConstantDamage(?blr, 0, 0, ?x3)`
    - template `AddConstant[SkillConstantDamage]` = `IchijhinnokazeBuf.GetNormalAttackConstantDamage(?blr, 0, 0, ?x3)`
    - template `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, vtab(0x165db78(meta(0x399f890, NormalAttackAction.<>c__DisplayClass81_0_TypeInfo), playerAction, mobAction, ?x3)), 0, ?x3)`
    - calls `0x165db78`, `NormalAttackAction.<>c__DisplayClass81_0$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillActionBase.DamageData$$.ctor`, `0x165d8dc`, `interface MobActionManagerBase.get_MobBattleStatus`, `SkillBufferManager$$SetBufferEffectActive`
- Code that reads this skill's level / buff by constant id: `CloningTechniqueAction$$ActionStart (GetSkillLv)`, `IchijhinnokazeAratame$$InvokeShukuchi (ContainsBuffer)`, `IchijhinnokazeAratame$$InvokeShukuchi (GetSkillLv)`, `IchijhinnokazeAttackAction$$ActionPreparation (GetSkillLv)`, `IchijhinnokazeBuf$$Updata (ContainsBuffer)`, `MobaPlayerBattleManager$$AbnormalFear (ContainsBuffer)`, `MobaPlayerBattleManager$$OnBattleEnd (ContainsBuffer)`, `MobaPlayerBattleManager.<ShukuchiMoveWait>d__93$$MoveNext (GetSkillLv)`, `NormalAttackAction$$ActionPreparation (ContainsBuffer)`, `NormalAttackAction$$calcPlayerToMobDamage (TryGetBuf)`, `PlayerBattleManager$$AbnormalFear (ContainsBuffer)`, `PlayerBattleManager$$OnBattleEnd (ContainsBuffer)`, `PlayerBattleManager.<ShukuchiMoveWait>d__54$$MoveNext (GetSkillLv)`, `PlayerSecondaryStatus$$get_AtkMpRecovery (TryGetBuf)`, `ShukuchiAction$$CanActivated (GetSkillLv)`

_Raw recovered data (every method item): [trees/MononofuSkill.md](../trees/MononofuSkill.md) — uid 619_

---

### คมดาบมายา (RepelBlade) · uid 623

<img src="../../icons/sk_623.png" width="40" alt="icon"> 
**Tree:** モノノフスキル (`MononofuSkill`, tier 3) · **Type:** Special · **Max Lv:** 70 · **Weapons:** MainKatana · **Flags:** NoMarketSearch, MercenaryCanUseSkill · **Client class:** `RepelBladeAction`

> เทคนิคการใช้ฝักดาบป้องกัน
> ถ้าได้รับความเสียหายตอนใช้ฝักดาบตั้งท่าอยู่
> จะโจมตีกลับ 1 ครั้งจะลดMP ที่ใช้
> และเพิ่มอัตราความแม่นให้สกิลถัดไป

**How it works**

- Special skill of the モノノフスキル tree (tier 3, max Lv 70); usable with MainKatana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- It can inflict a status ailment (chance and type below).
- `NormalAttackAction` looks its buff up and changes how normal attacks run while it is active.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×2.2 at Lv1 to 4 at Lv10; flat damage +110 at Lv1 to 200 at Lv10
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: None (0).
- Buffs:
  - `RepelBladeBuf`; Lv1 → Lv10: Value (generic value (meaning set by the code that reads the buff)) 10 → 100
  - `SwordMoveBuf`
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionStart` — when the cast starts: 2 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 4 tpl, 1 info
- `Damaged` — when the caster takes damage while the action / buff is active: 1 call
- `.<>c__DisplayClass30_0::<ActionStart>b__0` — skill-specific method: 1 call
- `.<>c__DisplayClass30_0::<ActionStart>b__1` — skill-specific method: 1 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 2.2 | 2.4 | 2.6 | 2.8 | 3 | 3.2 | 3.4 | 3.6 | 3.8 | 4 |
| Flat dmg + | 110 | 120 | 130 | 140 | 150 | 160 | 170 | 180 | 190 | 200 |

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv * 20) + 200)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv * 10) + 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[FirstAttackRate]` = `(PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, playerAction)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 623
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Marks the hit with ailment **None (0)** (`Damaged`)
  - when `!SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) AND (1 & ((PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp) gt damageData._damage ? 1 : 0)) ne 0 AND (damageData.AbnormalType - 1) ls 2 AND (damageData.AbnormalType | 16) ne 20 AND IsInstanceOf(playerAction, MobaPlayerActionManager) ne 1 AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND PlayerStatusBase.get_SkillBufferManager().skillBufList[623].IsHolding ne 0 OR !SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) AND (1 & ((PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp) gt damageData._damage ? 1 : 0)) ne 0 AND (SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().skillBufList[623], 50) * damageData._damage) ge 100 AND (damageData.AbnormalType - 1) ls 2 AND (damageData.AbnormalType | 16) ne 20 AND IsInstanceOf(playerAction, PlayerActionManager) eq 1 AND PlayerStatusBase.get_SkillBufferManager().skillBufList[623].IsHolding ne 0 OR !SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) AND (1 & ((PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp) gt damageData._damage ? 1 : 0)) ne 0 AND (SkillBufferDataBase.GetParam(PlayerStatusBase.get_SkillBufferManager().skillBufList[623], 50) * damageData._damage) lt 100 AND (damageData.AbnormalType - 1) ls 2 AND (damageData.AbnormalType | 16) ne 20 AND IsInstanceOf(playerAction, PlayerActionManager) eq 1 AND PlayerStatusBase.get_SkillBufferManager().skillBufList[623].IsHolding ne 0`

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): constructs `RepelBladeBuf` — `.ctor(Lv, status.EqAtk)`
  - when `!PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction)`
- `ActionStart` (when the cast starts): adds the caster's buff of `new RepelBladeBuf` — `AddSelfBuffer(new RepelBladeBuf, Id)`
  - when `!PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(actarAction)`
- `.<>c__DisplayClass30_0::<ActionStart>b__0` (method): removes the caster's buff of skill 623 (RepelBlade) — `RemoveSelfBuffer(623)`
  - when `PlayerStatusBase.get_SkillBufferManager().skillBufList[623].IsReelSuccess eq 0`
- `.<>c__DisplayClass30_0::<ActionStart>b__1` (method): adds the caster's buff of skill 621 (FinishingTouch) — `AddSelfBuffer(621, SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 621, 1), 0)`
  - when `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 621, 1) ge 1`

**Buff values** (every recovered field; durations in seconds)

**Buff `RepelBladeBuf`**
- Buff hook methods: `Parry`, `get_IsHolding`, `get_IsReelSuccess`, `set_IsHolding`, `set_IsReelSuccess`
- `HitRate` = `(((((Lv << 1) + 5) * eqAtk) // 100))` _(when BuffEffectActive ne 0; IsReelSuccess ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |

- Buff fields set in the constructor (all recovered):
  - `BufEffectTakeUid` = `-1` = -1
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
  - `IsHolding` = `1` = 1
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `hitRate` = `((((Lv << 1) + 5) * eqAtk) // 100)`
  - `hpHealRate` = `(((Lv << 2) + lv) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]
- Hook `set_IsHolding`: `IsHolding`=(value & 1)
- Hook `set_IsReelSuccess`: `IsReelSuccess`=(value & 1)
- Hook `Parry`: `IsHolding`=0; `IsReelSuccess`=(succsess & 1)
**Buff `SwordMoveBuf`**
- **Modifies normal attacks**: `NormalAttackAction` looks this buff up while it builds the normal-attack damage / hit logic.
- Attached to this skill via `caller2:SwordMove$$AddBuf<-RepelBladeAction$$ActionSkillEvent` (no direct constructor call in the skill's own code).
- Buff hook methods: `CheckDamageInvalid`, `DamageInvalid`, `EndSwordMove`
- `Value` = `((damageInvalid & 1))` _(when BuffEffectActive ne 0)_
- `Value` = `0` _(when BuffEffectActive eq 0)_
- Buff fields set in the constructor (all recovered):
  - `Level` = `257` = 257
  - `BuffEffectActive` = `1` = 1
  - `BufEffectTakeUid` = `-1` = -1
  - `damageInvalid` = `(damageInvalid & 1)`
- Hook `DamageInvalid`: `damageInvalid`=0
- Hook `EndSwordMove`: `damageInvalid`=0

Parameter meanings (inferred from the `SkillBufferId` names):

- `HitRate`: accuracy %
- `Value`: generic value (meaning set by the code that reads the buff)

**Where else this skill takes effect**

- Code that reads this skill's level / buff by constant id: `PlayerAttackBase$$CalcCostMp (ContainsBuffer)`

_Raw recovered data (every method item): [trees/MononofuSkill.md](../trees/MononofuSkill.md) — uid 623_

---

### ลมกระโชก / ลมสงบนิ่ง[N3]ลมเหนือ[N4]ลมตะวันออก[N5]ลมตะวันตก[N6]ลมใต้[N7]สี่ฤดูกาล (Ichijhinnokaze) · uid 629

<img src="../../icons/sk_629.png" width="40" alt="icon"> 
**Tree:** モノノフスキル (`MononofuSkill`, tier 3) · **Type:** Special · **Max Lv:** 70 · **Weapons:** Katana · **Requires:** ลมมงคล · **Client class:** `IchijhinnokazeAction`

> เข้าสู่ท่าตั้งรับการชักดาบสองมือ ลบผลของพลังโจมตี
> จากฟันครั้งแรกและแปลงเป็น ATK กับ ATK อาวุธแทน
> เมื่อสกิลนี้ทำงานอยู่หากใช้ลมกระโชกซ้ำ
> จะเกิดผลที่แตกต่างกันไปตามคีย์ที่กด
> ผลจะสิ้นสุดลงเมื่อเก็บดาบเข้าฝักแล้วเคลื่อนไหว

**How it works**

- Special skill of the モノノフスキル tree (tier 3, max Lv 70); usable with Katana.
- It installs a buff on the caster.
- `NormalAttackAction` looks its buff up and changes how normal attacks run while it is active.
- Buffs:
  - `IchijhinnokazeBuf`; Lv1 → Lv10: Percent (generic percent) 10 → 100
  - `CountBufferBase`
- Other client code reads this skill (8 lookups; see the last section).

**When each part runs**

- `ActionHit` — when the attack connects: 2 call
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ResetSpecialAcion` — skill-specific method: 2 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 629
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `IchijhinnokazeBuf` — `.ctor(Lv, actarAction)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): adds the caster's buff of `new IchijhinnokazeBuf` — `AddSelfBuffer(new IchijhinnokazeBuf, Id)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`
- `ResetSpecialAcion` (method): removes the caster's buff of skill 629 (Ichijhinnokaze) — `RemoveSelfBuffer(629)`
  - when `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 629) ne 0 OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 621) eq 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 629) ne 0 OR TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 621) ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 621).IsEnd ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 629) ne 0`
- `ResetSpecialAcion` (method): removes the caster's buff of skill 621 (FinishingTouch) — `RemoveSelfBuffer(621)`
  - when `TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 621) ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 621).IsEnd ne 0 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 629) ne 0`

**Buff values** (every recovered field; durations in seconds)

**Buff `IchijhinnokazeBuf`**
- **Modifies normal attacks**: `NormalAttackAction` looks this buff up while it builds the normal-attack damage / hit logic.
- Buff hook methods: `Active`, `BufferEnd`, `Inactive`, `OnLeave`, `UpdateParameter`, `get_BufEffectTakeId`, `get_IsPutUpWeapon`, `get_NowAttackMode`, `set_NowAttackMode`
- `BaseEqAtk` = `baseEqAtk` _(when BuffEffectActive ne 0)_
- `AtkUp` = `atk` _(when BuffEffectActive ne 0)_
- `Value2` = `activeSkill` _(when BuffEffectActive ne 0)_
- `Value` = `NowAttackMode` _(when BuffEffectActive ne 0)_
- `AtkUpRate` = `atkRate` _(when BuffEffectActive ne 0)_
- `Count` = `((NowAttackMode + 1))` _(when BuffEffectActive ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Percent | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |

- Buff fields set in the constructor (all recovered):
  - `isBattleActive` = `1` = 1
  - `actionManager` = `actionManager`
  - `takeController` = `actionManager.TakeController`
  - `effectManager` = `PlayerActionManagerBase.get_BufferEffectManager()`
  - `equipMainKatana` = `(EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) eq 8 ? 1 : 0)`
  - `Count` = `(NowAttackMode + 1)`
- Hook `set_NowAttackMode`: `NowAttackMode`=value
- Hook `Updata`: `isPutUpWeapon`=0; `isBattleActive`=(IchijhinnokazeBuf.CheckBattleActive(this) & 1); `isUpdateWeapon`=0; `isUpdateWeapon`=1
- Hook `OnLeave`: `isFieldLeave`=1
- Hook `UpdateParameter`: `atk`=int(((SkillBufferDataBase.GetParam(this, 52) * firstAttack) / 100)); `atkRate`=int(((SkillBufferDataBase.GetParam(this, 52) * firstAttackRate) / 100)); `baseEqAtk`=int(((SkillBufferDataBase.GetParam(this, 52) * firstAttackRate) / 100))
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:IchijhinnokazeBuf$$.ctor<-IchijhinnokazeAction$$ActionHit` (no direct constructor call in the skill's own code).
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

- `AtkUp`: ATK +
- `AtkUpRate`: ATK %
- `BaseEqAtk`: base weapon ATK +
- `Count`: stack / hit counter
- `Percent`: generic percent
- `Value`: generic value (meaning set by the code that reads the buff)
- `Value2`: second generic value

**In-game level notes**

- Lv8: สกิลที่มีการเปลี่ยนแปลงซึ่งสามารถใช้ได้ด้วยการกดปุ่ม [ลมสงบนิ่ง(ตั้งรับ)][ลมเหนือ][ลมตะวันออก][ลมตะวันตก] [ลมใต้] สามารถใช้โดยยังรักษาสถานะของ[เมเคียวชิซุย]เอาไว้ได้  ถึงจะกดคีย์หลังจากที่ตั้งรับ[ลมสงบนิ่ง]แล้ว ยังสามารถใช้สกิลการเปลี่ยนแปลงที่เกี่ยวข้องได้ (จะใช้ MP เมื่อเปิดใช้[ลมสงบนิ่ง]เท่านั้น)

**Where else this skill takes effect**

- Effect applied in `PlayerActionManager$$GetSkillTargetType` (1 guarded path):
  - when `skillId le 629` AND `skillId gt 112` AND `skillId gt 299` AND `skillId ne 514`
    - returns `((SkillBufferManager.ContainsBuffer(?blr, 629, 0, ?x3) & 1) ne 0 ? 4 : 1)`
- Effect applied in `EquipItemData.WeaponTypeCalculatorBase$$CalcEqAtk` (292 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1159, stkp(-80), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 147, stkp(-80), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-80), 0) & 1) ne 0`
    - returns `(((((((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3)) * ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) // 100) + ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) + int((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 8, 0, ?x3) / 100)) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 9, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
    - calls `virtual PlayerStatusBase.get_BonusManager`, `BonusManager$$GetBonusConstant_Rate`, `virtual EquipItemData.WeaponTypeCalculatorBase.calcEqAtkBonus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1159, stkp(-80), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 147, stkp(-80), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-80), 0) & 1) ne 0`
    - returns `(((((((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?mi, ?x3)) * ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?mi, ?x3))) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) // 100) + ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?mi, ?x3))) + int(((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 8, 0, ?x3) / 100)) + (CharacterActionManagerBase.get_Size() / 100)) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 9, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
    - calls `virtual PlayerStatusBase.get_BonusManager`, `BonusManager$$GetBonusConstant_Rate`, `virtual EquipItemData.WeaponTypeCalculatorBase.calcEqAtkBonus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1159, stkp(-80), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 147, stkp(-80), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-80), 0) & 1) ne 0`
    - returns `(((((((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3)) * ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) // 100) + ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) + int((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 8, 0, ?x3) / 100)) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 9, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
    - calls `virtual PlayerStatusBase.get_BonusManager`, `BonusManager$$GetBonusConstant_Rate`, `virtual EquipItemData.WeaponTypeCalculatorBase.calcEqAtkBonus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1159, stkp(-80), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 147, stkp(-80), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-80), 0) & 1) ne 0`
    - calls `virtual PlayerStatusBase.get_BonusManager`, `BonusManager$$GetBonusConstant_Rate`, `virtual EquipItemData.WeaponTypeCalculatorBase.calcEqAtkBonus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1159, stkp(-80), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 147, stkp(-80), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-80), 0) & 1) ne 0`
    - returns `(((((((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3)) * ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) // 100) + ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) + int((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 8, 0, ?x3) / 100)) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 9, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
    - calls `virtual PlayerStatusBase.get_BonusManager`, `BonusManager$$GetBonusConstant_Rate`, `virtual EquipItemData.WeaponTypeCalculatorBase.calcEqAtkBonus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1159, stkp(-80), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 147, stkp(-80), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-80), 0) & 1) ne 0`
    - returns `(((((((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3)) * ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) // 100) + ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) + int((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 8, 0, ?x3) / 100)) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 9, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
    - calls `virtual PlayerStatusBase.get_BonusManager`, `BonusManager$$GetBonusConstant_Rate`, `virtual EquipItemData.WeaponTypeCalculatorBase.calcEqAtkBonus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1159, stkp(-80), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 147, stkp(-80), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-80), 0) & 1) ne 0`
    - returns `(((((((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3)) * ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) * ((CharacterActionManagerBase.set_DefaultMoveSpeed() + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) // 100) + ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) + int((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 8, 0, ?x3) / 100)) * ((CharacterActionManagerBase.set_DefaultMoveSpeed() + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 9, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
    - calls `virtual PlayerStatusBase.get_BonusManager`, `BonusManager$$GetBonusConstant_Rate`, `virtual EquipItemData.WeaponTypeCalculatorBase.calcEqAtkBonus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1159, stkp(-80), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 147, stkp(-80), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-80), 0) & 1) ne 0`
    - returns `(((((((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?mi, ?x3)) * ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?mi, ?x3))) * ((CharacterActionManagerBase.set_DefaultMoveSpeed() + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) // 100) + ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?mi, ?x3))) + int(((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 8, 0, ?x3) / 100)) + (CharacterActionManagerBase.get_Size() / 100)) * ((CharacterActionManagerBase.set_DefaultMoveSpeed() + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 9, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
    - calls `virtual PlayerStatusBase.get_BonusManager`, `BonusManager$$GetBonusConstant_Rate`, `virtual EquipItemData.WeaponTypeCalculatorBase.calcEqAtkBonus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`
- Effect applied in `TenjhoTengeMusouSwordAction$$CheckActive` (7 guarded paths):
  - when `SkillLv(625) ge 1` AND `SkillLv(621) ge 10` AND `(SkillBufferManager.TryGetBuf(?blr, 621, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `1`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.Component$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillActionManager$$get_PlaceSkilList`, `System.Linq.Enumerable$$Any<object>`
  - when `SkillLv(625) ge 1` AND `SkillLv(621) ge 10` AND `(SkillBufferManager.TryGetBuf(?blr, 621, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.Component$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillActionManager$$get_PlaceSkilList`, `System.Linq.Enumerable$$Any<object>`
  - when `SkillLv(625) ge 1` AND `SkillLv(621) ge 10` AND `(SkillBufferManager.TryGetBuf(?blr, 621, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.Component$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `SkillLv(625) ge 1` AND `SkillLv(621) ge 10` AND `(SkillBufferManager.TryGetBuf(?blr, 621, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.Component$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `SkillLv(625) ge 1` AND `SkillLv(621) ge 10` AND `(SkillBufferManager.TryGetBuf(?blr, 621, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.Component$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`, `0x165db84`
  - when `SkillLv(625) ge 1` AND `SkillLv(621) ge 10` AND `(SkillBufferManager.TryGetBuf(?blr, 621, stkp(-40), 0) & 1) eq 0`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.Component$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`
  - when `SkillLv(625) ge 1` AND `SkillLv(621) ge 10`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.Component$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`
- Effect applied in `IchijhinnokazeAttackAction$$CheckSetunakenran` (5 guarded paths):
  - when `SkillLv(626) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 629, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 626, stkp(-24), 0) & 1) ne 0`
    - returns `(UnannouncedDestinationBuf.CheckActive(TryGetBuf.out2(), 0, ?x2, ?x3) & 1)`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.GameObject$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`, `System.Nullable<bool>$$.ctor`, `IchijhinnokazeBuf$$CheckActiveSetsunakenran`, `UnannouncedDestinationBuf$$CheckActive`
  - when `SkillLv(626) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 629, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 626, stkp(-24), 0) & 1) eq 0`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.GameObject$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`, `System.Nullable<bool>$$.ctor`, `IchijhinnokazeBuf$$CheckActiveSetsunakenran`
  - when `SkillLv(626) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 629, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.GameObject$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`, `System.Nullable<bool>$$.ctor`, `IchijhinnokazeBuf$$CheckActiveSetsunakenran`
  - when `SkillLv(626) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 629, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.GameObject$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`, `System.Nullable<bool>$$.ctor`, `0x165db84`, `0x165df00`
  - when `SkillLv(626) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 629, stkp(-24), 0) & 1) eq 0`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.GameObject$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`, `System.Nullable<bool>$$.ctor`
- Effect applied in `HayateAction$$IsFailure` (2 guarded paths):
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
  - always
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`
- Effect applied in `IchijhinnokazeAction$$IsFailure` (2 guarded paths):
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferManager$$GetSkillBufferFlagMachBuffer`, `PlayerAttackBase$$IsFailure`
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferManager$$GetSkillBufferFlagMachBuffer`, `PlayerAttackBase$$IsFailure`
- Effect applied in `IchijhinnokazeBuf$$CheckNormalAttackIchijhinnokaze` (5 guarded paths):
  - when `SkillLv(629) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 629, stkp(-56), meta(0x399fa98, Method$SkillBufferManager.TryGetBuf<IchijhinnokazeBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `Singleton<object>$$get_Instance`, `MasterSkillDataManager$$GetSkillMaster`, `virtual PlayerStatusBase.get_EquipItemData`, `SkillUtil$$CheckSkillEquipLimit`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `SkillLv(629) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 629, stkp(-56), meta(0x399fa98, Method$SkillBufferManager.TryGetBuf<IchijhinnokazeBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() eq 0`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `Singleton<object>$$get_Instance`, `MasterSkillDataManager$$GetSkillMaster`, `virtual PlayerStatusBase.get_EquipItemData`, `SkillUtil$$CheckSkillEquipLimit`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
  - when `SkillLv(629) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 629, stkp(-56), meta(0x399fa98, Method$SkillBufferManager.TryGetBuf<IchijhinnokazeBuf>())) & 1) eq 0`
    - returns `0`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `Singleton<object>$$get_Instance`, `MasterSkillDataManager$$GetSkillMaster`, `virtual PlayerStatusBase.get_EquipItemData`, `SkillUtil$$CheckSkillEquipLimit`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `SkillLv(629) ge 1`
    - returns `0`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `Singleton<object>$$get_Instance`, `MasterSkillDataManager$$GetSkillMaster`, `virtual PlayerStatusBase.get_EquipItemData`, `SkillUtil$$CheckSkillEquipLimit`
  - when `SkillLv(629) lt 1`
    - returns `0`
    - calls `virtual PlayerStatusBase.get_SkillManager`
- Code that reads this skill's level / buff by constant id: `EquipItemData.WeaponTypeCalculatorBase$$CalcEqAtk (TryGetBuf)`, `HayateAction$$IsFailure (ContainsBuffer)`, `IchijhinnokazeAction$$IsFailure (ContainsBuffer)`, `IchijhinnokazeAttackAction$$CheckSetunakenran (TryGetBuf)`, `IchijhinnokazeBuf$$CheckNormalAttackIchijhinnokaze (GetSkillLv)`, `PlayerActionManager$$GetSkillTargetType (ContainsBuffer)`, `TenjhoTengeMusouSwordAction$$CheckActive (ContainsBuffer)`, `UIFishingPanelManager$$StartFishingResponse (TryGetBuf)`

_Raw recovered data (every method item): [trees/MononofuSkill.md](../trees/MononofuSkill.md) — uid 629_

---

### เท็นริวรันเซ (HeavenlyStar) · uid 620

<img src="../../icons/sk_620.png" width="40" alt="icon"> 
**Tree:** モノノフスキル (`MononofuSkill`, tier 4) · **Type:** Attack · **Max Lv:** 150 · **Weapons:** Katana · **Requires:** ฮัซโซฮัปปะ · **Flags:** MercenaryCanUseSkill · **Client class:** `HeavenlyStarAction`

> ฟันอย่างต่อเนื่องราวคลื่นที่โหมกระหน่ำ
> เพิ่มพลังชั่วขณะทุกครั้งที่ใช้งาน(ใช้ได้สูงสุด 4 ครั้ง)
> เมื่อสำเร็จตามเงื่อนไขของมากาดาจิ/ซังเทเซ็ตเท็ตสึจะใช้การโจมตีพิเศษได้
> และระยะเวลาการเพิ่มพลังจะเพิ่มขึ้น

**How it works**

- Attack skill of the モノノフスキル tree (tier 4, max Lv 150); usable with Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Its buff exposes motion / combo hooks, so it changes the attack pattern while active (heuristic; the client has no explicit flag).
- `NormalAttackAction` looks its buff up and changes how normal attacks run while it is active.
- MP: `100`.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×1.75 at Lv1 to 4 at Lv10; skill multiplier depends on live values (formula below); skill multiplier depends on live values (formula below); flat damage +10 at Lv1 to 100 at Lv10
  - `calcPlayerToMobDamage` [InflexibilityBuf.CheckHeavenlyStarPowerUp(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627)) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627) ne 0]: skill multiplier depends on live values (formula below); skill multiplier depends on live values (formula below); skill multiplier depends on live values (formula below); skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [InflexibilityBuf.CheckHeavenlyStarPowerUp(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627)) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627) ne 0 & InflexibilityBuf.CheckHeavenlyStarPowerUp(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627)) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627) ne 0]: skill multiplier depends on live values (formula below); skill multiplier depends on live values (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target if class check passes`.
- Buffs:
  - `HeavenlyStarBuf`: lasts `10` s
  - `CountBufferBase`
- Other client code reads this skill (11 lookups; see the last section).

**Cost, timing and range**

- **MP cost** (`mp` in `OnInitialize`): `100` = 100
  - when `hasBuff(620) AND mainWeapon == Bow OR hasBuff(620) AND mainWeapon != Bow`
- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetSubWeaponType.item(actarAction))`
  - when `hasBuff(620) AND mainWeapon == Bow OR !hasBuff(620) AND mainWeapon == Bow`
- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
  - when `hasBuff(620) AND mainWeapon != Bow OR !hasBuff(620) AND mainWeapon != Bow`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 7 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionStart` — when the cast starts: 2 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 5 set, 7 tpl, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 1.75 | 2 | 2.25 | 2.5 | 2.75 | 3 | 3.25 | 3.5 | 3.75 | 4 |
| Flat dmg + | 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 | 100 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((((((Lv * 25) + 150)) + ((((Lv * 25) + 150)) * System.Math.Min(CountBufferBase.GetParam(20), 3))) + ((System.Math.Min(CountBufferBase.GetParam(20), 3) * 100) + 100)) / 100)` — InflexibilityBuf.CheckHeavenlyStarPowerUp(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627)) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627) ne 0
- SkillRate × `((((((Lv * 25) + 150)) + ((((Lv * 25) + 150)) * System.Math.Min(CountBufferBase.GetParam(20), 3))) + ((System.Math.Min(CountBufferBase.GetParam(20), 3) * 100) + 100)) / 100)` — InflexibilityBuf.CheckHeavenlyStarPowerUp(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627)) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627) ne 0 & InflexibilityBuf.CheckHeavenlyStarPowerUp(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627)) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627) ne 0
- SkillRate × `((((((Lv * 25) + 150)) + ((((Lv * 25) + 150)) * System.Math.Min(CountBufferBase.GetParam(20), 3))) + ((System.Math.Min(CountBufferBase.GetParam(20), 3) * 100) + 100)) / 100)` — InflexibilityBuf.CheckHeavenlyStarPowerUp(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627)) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627) ne 0
- SkillRate × `((((((Lv * 25) + 150)) + ((((Lv * 25) + 150)) * System.Math.Min(CountBufferBase.GetParam(20), 3))) + ((System.Math.Min(CountBufferBase.GetParam(20), 3) * 100) + 100)) / 100)` — InflexibilityBuf.CheckHeavenlyStarPowerUp(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627)) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627) ne 0 & InflexibilityBuf.CheckHeavenlyStarPowerUp(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627)) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627) ne 0
- SkillRate × `(((((Lv * 25) + 150)) + ((((Lv * 25) + 150)) * System.Math.Min(CountBufferBase.GetParam(20), 3))) / 100)`
- SkillRate × `(((((Lv * 25) + 150)) + ((((Lv * 25) + 150)) * System.Math.Min(CountBufferBase.GetParam(20), 3))) / 100)` — InflexibilityBuf.CheckHeavenlyStarPowerUp(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627)) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627) ne 0
- SkillRate × `(((((Lv * 25) + 150)) + ((((Lv * 25) + 150)) * System.Math.Min(CountBufferBase.GetParam(20), 3))) / 100)`
- SkillRate × `(((((Lv * 25) + 150)) + ((((Lv * 25) + 150)) * System.Math.Min(CountBufferBase.GetParam(20), 3))) / 100)` — InflexibilityBuf.CheckHeavenlyStarPowerUp(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627)) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627) ne 0

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv + (Lv << 2)) << 1))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((((Lv * 25) + 150)) + ((((Lv * 25) + 150)) * System.Math.Min(CountBufferBase.GetParam(20), 3))) + ((System.Math.Min(CountBufferBase.GetParam(20), 3) * 100) + 100)) / 100)`
  - when `InflexibilityBuf.CheckHeavenlyStarPowerUp(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627)) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627) ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, playerAction)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[FirstAttackRate]` = `(PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv * 25) + 150)) + ((((Lv * 25) + 150)) * System.Math.Min(CountBufferBase.GetParam(20), 3))) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv * 25) + 150)) + (((System.Math.Min(CountBufferBase.GetParam(20), 3)) * 100) + 100)) / 100)`
  - when `InflexibilityBuf.CheckHeavenlyStarPowerUp(TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627)) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 627) ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv * 25) + 150)) / 100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target if class check passes`, attack type `Physics`, action id 620
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): constructs `HeavenlyStarBuf` — `.ctor(Lv)`
  - when `!PlayerAttackBase.IsBlank(this) AND MobaMode ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND MobaMode eq 0 AND UnityEngine.Object.op_Inequality(actarAction)`
- `ActionStart` (when the cast starts): adds the caster's buff of `new HeavenlyStarBuf` — `AddSelfBuffer(new HeavenlyStarBuf, Id)`
  - when `!PlayerAttackBase.IsBlank(this) AND MobaMode ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND MobaMode eq 0 AND UnityEngine.Object.op_Inequality(actarAction)`

**Other recovered parameters**

- **MP cost** (`mp`): `100` = 100 _(when hasBuff(620) AND mainWeapon == Bow OR hasBuff(620) AND mainWeapon != Bow)_

**Buff values** (every recovered field; durations in seconds)

**Buff `HeavenlyStarBuf`**
- **Changes the attack pattern**: the buff object drives a motion/combo chain (`SetAttackSkillId`).
- **Modifies normal attacks**: `NormalAttackAction` looks this buff up while it builds the normal-attack damage / hit logic.
- Buff hook methods: `CheckExpDefFluctuate`, `IllusionarySceneReset`, `Reset`, `SetAttackSkillId`
- Duration: `10` s
- Buff fields set in the constructor (all recovered):
  - `isExpDefFluctuate` = `1` = 1
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `Reset`: `Count`=0; `LeftTime`=30; `prevSkillId`=0
- Hook `IllusionarySceneReset`: `Count`=max((((illusionarySceneParry & 1) + count) + ([TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 627)+0x20] ge 50 ? 0xfffffffe : 0xfffffffd)), 0); `LeftTime`=(EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) eq 8 ? (((count + (count << 2)) << 1) + 10) : ((count + (count << 2)) << 1)); `prevSkillId`=0; `Count`=max((((illusionarySceneParry & 1) + count) + 0xfffffffd), 0)
- Hook `SetAttackSkillId`: `prevSkillId`=skillId
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:HeavenlyStarBuf$$.ctor<-HeavenlyStarAction$$ActionStart` (no direct constructor call in the skill's own code).
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

**Where else this skill takes effect**

- Effect applied in `PlayerAttackBase$$CalcCostMp` (203 guarded paths, truncated):
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
- Effect applied in `PlayerBattleManager$$CheckZeroActionDelay` (15 guarded paths):
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
    - calls `AbnormalStateManager$$Contains`
- Effect applied in `CutOffTheDisasterAction.<>c__DisplayClass31_1$$<ActionSkillEvent>b__1` (2 guarded paths):
  - when `(SkillLv(620) & 255) ne 0`
    - calls `0x165db78`, `HeavenlyStarBuf$$.ctor`, `HeavenlyStarBuf$$Reset`, `SkillBufferManager$$AddSelfBuffer`
  - when `(SkillLv(620) & 255) eq 0`
    - returns `SkillLv(620)`
- Effect applied in `HeavenlyStarAction$$OnInitialize` (4 guarded paths):
  - always
    - returns `PlayerAttackBase.CalcMp(this, actarAction, 0, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-40), 0, ?x3)`
    - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetSubWeaponType.out1(), 0, ?x2, ?x3)`
    - set `skillRate` = `((Lv * 25) + 150)`
    - set `fixAddDamage` = `((Lv + (Lv << 2)) << 1)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `mp` = `100`
    - set `SkillParam` = `(SkillParam | 2)`
    - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`
  - always
    - returns `PlayerAttackBase.CalcMp(this, actarAction, 0, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-40), 0, ?x3)`
    - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetSubWeaponType.out1(), 0, ?x2, ?x3)`
    - set `skillRate` = `((Lv * 25) + 150)`
    - set `fixAddDamage` = `((Lv + (Lv << 2)) << 1)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `SkillParam` = `(SkillParam | 2)`
    - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`
  - always
    - returns `PlayerAttackBase.CalcMp(this, actarAction, 0, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-40), 0, ?x3)`
    - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.out1(), 0, ?x2, ?x3)`
    - set `skillRate` = `((Lv * 25) + 150)`
    - set `fixAddDamage` = `((Lv + (Lv << 2)) << 1)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `mp` = `100`
    - set `SkillParam` = `(SkillParam | 2)`
    - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`
  - always
    - returns `PlayerAttackBase.CalcMp(this, actarAction, 0, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-40), 0, ?x3)`
    - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.out1(), 0, ?x2, ?x3)`
    - set `skillRate` = `((Lv * 25) + 150)`
    - set `fixAddDamage` = `((Lv + (Lv << 2)) << 1)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `SkillParam` = `(SkillParam | 2)`
    - calls `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`
- Effect applied in `IllusionarySceneAction$$OnInitialize` (7 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 620, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `PlayerAttackBase.ValidSkillParamFlag(this, 2, 0, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-40), 0, ?x3)`
    - set `SubWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.out1(), 0, ?x2, ?x3)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `rangekiSkillRate` = `((Lv * 75) + 750)`
    - set `finishSkillRate` = `((CharacterActionManagerBase.set_DefaultMoveSpeed() lt 1 ? 100 : (((SkillLv(620) * 25) + 150) * CharacterActionManagerBase.set_DefaultMoveSpeed())) + ((IPlayerStatusCalculator.get_Dex(?blr) << 1) // (5 - Characte`
    - set `finishConstantDamage` = `200`
    - calls `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `interface IPlayerStatusCalculator.get_Dex`, `PlayerAttackBase$$ValidSkillParamFlag`
  - when `(SkillBufferManager.TryGetBuf(?blr, 620, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `PlayerAttackBase.ValidSkillParamFlag(this, 2, 0, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-40), 0, ?x3)`
    - set `SubWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.out1(), 0, ?x2, ?x3)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `rangekiSkillRate` = `((Lv * 75) + 750)`
    - set `finishSkillRate` = `(CharacterActionManagerBase.set_DefaultMoveSpeed() lt 1 ? 100 : (((SkillLv(620) * 25) + 150) * CharacterActionManagerBase.set_DefaultMoveSpeed()))`
    - set `finishConstantDamage` = `200`
    - calls `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `PlayerAttackBase$$ValidSkillParamFlag`
  - when `(SkillBufferManager.TryGetBuf(?blr, 620, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `PlayerAttackBase.ValidSkillParamFlag(this, 2, 0, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-40), 0, ?x3)`
    - set `SubWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.out1(), 0, ?x2, ?x3)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `rangekiSkillRate` = `((Lv * 75) + 750)`
    - set `finishSkillRate` = `((CharacterActionManagerBase.set_DefaultMoveSpeed() lt 1 ? 100 : (((SkillLv(620) * 25) + 150) * CharacterActionManagerBase.set_DefaultMoveSpeed())) + ((IPlayerStatusCalculator.get_Dex(?blr) << 1) // (5 - Characte`
    - set `finishConstantDamage` = `200`
    - calls `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `interface IPlayerStatusCalculator.get_Dex`, `PlayerAttackBase$$ValidSkillParamFlag`
  - when `(SkillBufferManager.TryGetBuf(?blr, 620, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-40), 0, ?x3)`
    - set `SubWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.out1(), 0, ?x2, ?x3)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `rangekiSkillRate` = `((Lv * 75) + 750)`
    - calls `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(?blr, 620, stkp(-56), 0) & 1) eq 0`
    - returns `PlayerAttackBase.ValidSkillParamFlag(this, 2, 0, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-40), 0, ?x3)`
    - set `SubWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.out1(), 0, ?x2, ?x3)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `rangekiSkillRate` = `((Lv * 75) + 750)`
    - set `finishConstantDamage` = `200`
    - set `finishSkillRate` = `(finishSkillRate + ((IPlayerStatusCalculator.get_Dex(?blr) << 1) // 5))`
    - calls `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`, `interface IPlayerStatusCalculator.get_Dex`, `PlayerAttackBase$$ValidSkillParamFlag`
  - when `(SkillBufferManager.TryGetBuf(?blr, 620, stkp(-56), 0) & 1) eq 0`
    - returns `PlayerAttackBase.ValidSkillParamFlag(this, 2, 0, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-40), 0, ?x3)`
    - set `SubWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.out1(), 0, ?x2, ?x3)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `rangekiSkillRate` = `((Lv * 75) + 750)`
    - set `finishConstantDamage` = `200`
    - calls `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`, `PlayerAttackBase$$ValidSkillParamFlag`
  - when `(SkillBufferManager.TryGetBuf(?blr, 620, stkp(-56), 0) & 1) eq 0`
    - returns `PlayerAttackBase.ValidSkillParamFlag(this, 2, 0, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-40), 0, ?x3)`
    - set `SubWeaponType` = `PlayerAttackBase.GetSubWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `PlayerAttackBase.GetWeaponRange(GetWeaponType.out1(), 0, ?x2, ?x3)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `rangekiSkillRate` = `((Lv * 75) + 750)`
    - set `finishConstantDamage` = `200`
    - set `finishSkillRate` = `(finishSkillRate + ((IPlayerStatusCalculator.get_Dex(?blr) << 1) // 5))`
    - calls `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponRange`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`, `interface IPlayerStatusCalculator.get_Dex`, `PlayerAttackBase$$ValidSkillParamFlag`
- Effect applied in `IllusionarySceneAction.<>c__DisplayClass30_0$$<ActionPreparation>b__0` (2 guarded paths):
  - when `(SkillBufferManager.TryGetBuf<object>(?blr, 620, stkp(-40), meta(0x399f910, Method$SkillBufferManager.TryGetBuf<HeavenlyStarBuf>())) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 624, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `HeavenlyStarBuf.IllusionarySceneReset(SkillBufferManager.AddSelfBuffer(?blr, 620, SkillLv(620), 0), ?blr, [<>c__DisplayClass30_0.<>4__this+0x130], ([TryGetBuf.out2()+0x24] ne 0 ? 1 : 0))`
    - calls `SkillBufferManager$$AddSelfBuffer`, `SkillBufferManager$$RemoveSelfBuffer`, `HeavenlyStarBuf$$IllusionarySceneReset`
  - when `(SkillBufferManager.TryGetBuf<object>(?blr, 620, stkp(-40), meta(0x399f910, Method$SkillBufferManager.TryGetBuf<HeavenlyStarBuf>())) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 624, stkp(-48), 0) & 1) eq 0`
    - returns `HeavenlyStarBuf.IllusionarySceneReset(SkillBufferManager.AddSelfBuffer(?blr, 620, SkillLv(620), 0), ?blr, [<>c__DisplayClass30_0.<>4__this+0x130], 0)`
    - calls `SkillBufferManager$$AddSelfBuffer`, `SkillBufferManager$$RemoveSelfBuffer`, `HeavenlyStarBuf$$IllusionarySceneReset`
- Effect applied in `ZanteisettetsuAction.<>c__DisplayClass32_0$$<ActionSkillEvent>b__1` (2 guarded paths):
  - when `(SkillBufferManager.TryGetBuf<object>(?blr, 620, stkp(-40), meta(0x399f910, Method$SkillBufferManager.TryGetBuf<HeavenlyStarBuf>())) & 1) eq 0` AND `(SkillLv(620) & 255) ne 0`
    - returns `SkillBufferManager.AddSelfBuffer(?blr, 0x165db78(meta(0x39a8a30, HeavenlyStarBuf_TypeInfo), ?x1, ?x2, ?x3), 0, 0)`
    - calls `0x165db78`, `HeavenlyStarBuf$$.ctor`, `HeavenlyStarBuf$$Reset`, `SkillBufferManager$$AddSelfBuffer`
  - when `(SkillBufferManager.TryGetBuf<object>(?blr, 620, stkp(-40), meta(0x399f910, Method$SkillBufferManager.TryGetBuf<HeavenlyStarBuf>())) & 1) eq 0` AND `(SkillLv(620) & 255) eq 0`
    - returns `SkillLv(620)`
- Code that reads this skill's level / buff by constant id: `CutOffTheDisasterAction$$OnInitialize (GetSkillLv)`, `CutOffTheDisasterAction.<>c__DisplayClass31_1$$<ActionSkillEvent>b__1 (GetSkillLv)`, `HeavenlyStarAction$$OnInitialize (ContainsBuffer)`, `IllusionarySceneAction$$OnInitialize (GetSkillLv)`, `IllusionarySceneAction$$OnInitialize (TryGetBuf)`, `IllusionarySceneAction.<>c__DisplayClass30_0$$<ActionPreparation>b__0 (GetSkillLv)`, `MobaPlayerBattleManager$$OnSkillActionEnd (ContainsBuffer)`, `PlayerAttackBase$$CalcCostMp (ContainsBuffer)`, `PlayerBattleManager$$CheckZeroActionDelay (ContainsBuffer)`, `ZanteisettetsuAction$$OnInitialize (GetSkillLv)`, `ZanteisettetsuAction.<>c__DisplayClass32_0$$<ActionSkillEvent>b__1 (GetSkillLv)`

_Raw recovered data (every method item): [trees/MononofuSkill.md](../trees/MononofuSkill.md) — uid 620_

---

### การิวเท็นเซ (FinishingTouch) · uid 621

<img src="../../icons/sk_621.png" width="40" alt="icon"> 
**Tree:** モノノフスキル (`MononofuSkill`, tier 4) · **Type:** Attack · **Max Lv:** 150 · **Weapons:** Katana · **Requires:** ฮัซโซฮัปปะ · **Flags:** MercenaryCanUseSkill · **Client class:** `FinishingTouchAction`

> พิฆาตในดาบเดียว
> พลังจะเพิ่มขึ้นทุกครั้งที่ใช้โมโนโนฟุสกิล (ใช้ได้สูงสุด 10 ครั้ง)
> พลังจะเพิ่มขึ้นเมื่อเป้าหมายถูกทำลายชิ้นส่วน
> เป็นสกิลที่มีอัตราคริติคอลต่ำเป็นอย่างมาก

**How it works**

- Attack skill of the モノノフスキル tree (tier 4, max Lv 150); usable with Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×0.2 at Lv1 to 2 at Lv10
  - `calcPlayerToMobDamage` [PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[621].Count ge 1 AND UnityEngine.Object.op_Inequality(actarAction)]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10)]: flat damage +1000
  - `calcPlayerToMobDamage` [!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10)]: flat damage +100
  - `calcPlayerToMobDamage` [AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10) & AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10)]: flat damage depends on live values (formula below)
  - `calcPlayerToMobDamage` [AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10) & !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10)]: flat damage depends on live values (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Buffs:
  - `FinishingTouchBuf`
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (10 lookups; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetSubWeaponType.item(actarAction))`
  - when `IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND mainWeapon == Bow OR IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND mainWeapon == Bow`
- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
  - when `IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND mainWeapon != Bow OR IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND mainWeapon != Bow`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 6 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionPreparation` — before the cast starts: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 4 set, 3 tpl, 1 info
- `AddSwordSoul` — skill-specific method: 2 call
- `.<>c__DisplayClass23_0::<ActionPreparation>b__1` — skill-specific method: 1 call
- `.<>c__DisplayClass23_0::<ActionPreparation>b__0` — skill-specific method: 1 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.2 | 0.4 | 0.6 | 0.8 | 1 | 1.2 | 1.4 | 1.6 | 1.8 | 2 |
| Flat dmg + [AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10)] | 1000 | 1000 | 1000 | 1000 | 1000 | 1000 | 1000 | 1000 | 1000 | 1000 |
| Flat dmg + [!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10)] | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((((Lv + (Lv << 2)) << 2)) / 100)` — PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[621].Count ge 1 AND UnityEngine.Object.op_Inequality(actarAction)
- Flat dmg + `((100) * 10)` — AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10) & AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10)
- Flat dmg + `(100)` — AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10) & !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10)

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `((100) * 10)`
  - when `AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv + (Lv << 2)) << 2)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(100)`
  - when `!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 10)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 621
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `AddSwordSoul` (method): constructs `FinishingTouchBuf` — `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 621, 1))`
  - when `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 621, 1) ge 1`
- `AddSwordSoul` (method): adds the caster's buff of `new FinishingTouchBuf` — `AddSelfBuffer(new FinishingTouchBuf, 0)`
  - when `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 621, 1) ge 1`
- `.<>c__DisplayClass23_0::<ActionPreparation>b__1` (method): removes the caster's buff of skill 621 (FinishingTouch) — `RemoveSelfBuffer(621)`
- `.<>c__DisplayClass23_0::<ActionPreparation>b__0` (method): removes the caster's buff of skill 622 (WeirdnessOfGod) — `RemoveSelfBuffer(622)`

**Other recovered parameters**

- **Resistance value** (`resist`): `WeirdnessOfGodBuf.GetParam(50)`

**Buff values** (every recovered field; durations in seconds)

**Buff `FinishingTouchBuf`**
- Buff hook methods: `ActiveFinishingTouch`, `ActiveResetIchijhinnokaze`, `ActiveTenjhoTengeMusouSword`, `Next`, `NextSkip`, `OnEnd`
- `Value` = `lastDamageRate` _(when BuffEffectActive ne 0)_
- `FirstAttackRate` = `firstAttackRate` _(when BuffEffectActive ne 0)_
- `AttackMprecoveryUp` = `atkMpRecovery` _(when BuffEffectActive ne 0)_
- `Count` = `(0)` _(when BuffEffectActive ne 0)_
- `MobLastDamageRateBuf` = `damageCut` _(when BuffEffectActive ne 0)_
- Buff fields set in the constructor (all recovered):
  - `countType` = `2` = 2
  - `Count` = `0`
  - `Max` = `10` = 10
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
- Hook `Next`: `lastDamageRate`=(Count << 1)
- Hook `NextSkip`: `lastDamageRate`=(Count << 1)
- Hook `ActiveFinishingTouch`: `isActiveBuffer`=1; `firstAttackRate`=0; `atkMpRecovery`=0; `Count`=0
- Hook `ActiveTenjhoTengeMusouSword`: `isActiveBuffer`=1; `LeftTime`=Count; `damageCut`=(Count + (Count << 2)); `Count`=0
- Hook `ActiveResetIchijhinnokaze`: `Count`=0
- Hook `OnEnd`: `isActiveBuffer`=0; `LeftTime`=0; `lastDamageRate`=(Count << 1); `countType`=2
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:FinishingTouchBuf$$.ctor<-FinishingTouchAction$$AddSwordSoul` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

Parameter meanings (inferred from the `SkillBufferId` names):

- `AttackMprecoveryUp`: MP recovered per attack (flat)
- `Count`: stack / hit counter
- `FirstAttackRate`: first-attack multiplier
- `MobLastDamageRateBuf`: final damage multiplier vs monsters (buff category)
- `Value`: generic value (meaning set by the code that reads the buff)

**In-game level notes**

- Lv8: พลังของโมโนโนฟุสกิลจะเพิ่มขึ้น เมื่อบัฟของการิวเท็นเซเพิ่มขึ้น  เมื่อเปิดใช้งานสกิล บัฟที่สะสมไว้ของการิวเท็นเซทั้งหมดจะถูกใช้ และคุณจะเข้าสู่สถานะลดค่าความเสียหาย ในระหว่างสถานะนี้การเพิ่มพลังของโมโนโนฟุจะยังคงอยู่ที่ระดับสูงสุด  รีเซ็ตเมื่อสกิล[ลมกระโชก]ถูกยกเลิก

**Where else this skill takes effect**

- Effect applied in `FinishingTouchAction$$AddSwordSoul` (4 guarded paths):
  - when `SkillLv(621) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 621, stkp(-40), meta(0x39a8a58, Method$SkillBufferManager.TryGetBuf<FinishingTouchBuf>())) & 1) eq 0`
    - returns `(SkillLv(621) gt 0 ? 1 : 0)`
    - calls `0x165db78`, `FinishingTouchBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
  - when `SkillLv(621) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 621, stkp(-40), meta(0x39a8a58, Method$SkillBufferManager.TryGetBuf<FinishingTouchBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
    - returns `(SkillLv(621) gt 0 ? 1 : 0)`
  - when `SkillLv(621) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 621, stkp(-40), meta(0x39a8a58, Method$SkillBufferManager.TryGetBuf<FinishingTouchBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() eq 0`
    - calls `0x165db84`
  - when `SkillLv(621) lt 1`
    - returns `(SkillLv(621) gt 0 ? 1 : 0)`
- Effect applied in `IchijhinnokazeAttackAction.<>c__DisplayClass117_0$$<AddMotionEndFinishingTouchBuf>b__0` (4 guarded paths):
  - when `SkillLv(621) ge 1` AND `TryGetValue.out2() ne 0`
    - returns `?blr`
  - when `SkillLv(621) ge 1` AND `TryGetValue.out2() eq 0`
    - calls `0x165db84`, `0x165df00`
  - when `SkillLv(621) ge 1`
    - returns `?blr`
    - calls `SkillBufferManager$$AddSelfBuffer`
  - when `SkillLv(621) lt 1`
    - returns `SkillLv(621)`
- Effect applied in `NormalAttackAction.<>c__DisplayClass81_0$$<calcPlayerToMobDamage>b__0` (4 guarded paths):
  - when `SkillLv(621) ge 1` AND `TryGetValue.out2() ne 0`
    - returns `?blr`
  - when `SkillLv(621) ge 1` AND `TryGetValue.out2() eq 0`
    - calls `0x165db84`, `0x165df00`
  - when `SkillLv(621) ge 1`
    - returns `?blr`
    - calls `SkillBufferManager$$AddSelfBuffer`
  - when `SkillLv(621) lt 1`
    - returns `SkillLv(621)`
- Effect applied in `RepelBladeAction.<>c__DisplayClass30_0$$<ActionStart>b__1` (6 guarded paths):
  - when `SkillLv(621) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 621, stkp(-24), meta(0x39a8a58, Method$SkillBufferManager.TryGetBuf<FinishingTouchBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
    - returns `?blr`
  - when `SkillLv(621) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 621, stkp(-24), meta(0x39a8a58, Method$SkillBufferManager.TryGetBuf<FinishingTouchBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
    - returns `?blr`
  - when `SkillLv(621) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 621, stkp(-24), meta(0x39a8a58, Method$SkillBufferManager.TryGetBuf<FinishingTouchBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() eq 0`
    - calls `0x165db84`
  - when `SkillLv(621) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 621, stkp(-24), meta(0x39a8a58, Method$SkillBufferManager.TryGetBuf<FinishingTouchBuf>())) & 1) eq 0`
    - returns `?blr`
    - calls `SkillBufferManager$$AddSelfBuffer`
  - when `SkillLv(621) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 621, stkp(-24), meta(0x39a8a58, Method$SkillBufferManager.TryGetBuf<FinishingTouchBuf>())) & 1) eq 0`
    - returns `?blr`
    - calls `SkillBufferManager$$AddSelfBuffer`
  - when `SkillLv(621) lt 1`
    - returns `SkillLv(621)`
- Effect applied in `TenjhoTengeMusouSwordAction$$ActionStart` (3 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 621, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `FinishingTouchBuf.ActiveTenjhoTengeMusouSword(TryGetBuf.out2(), ?blr, 0, ?x3)`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `FinishingTouchBuf$$ActiveTenjhoTengeMusouSword`
  - when `(SkillBufferManager.TryGetBuf(?blr, 621, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165db84`, `0x165df00`
  - when `(SkillBufferManager.TryGetBuf(?blr, 621, stkp(-40), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 621, stkp(-40), 0)`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`
- Effect applied in `TenjhoTengeMusouSwordAction$$CheckActive` (10 guarded paths):
  - when `SkillLv(625) ge 1` AND `SkillLv(621) ge 10` AND `(SkillBufferManager.TryGetBuf(?blr, 621, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `1`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.Component$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillActionManager$$get_PlaceSkilList`, `System.Linq.Enumerable$$Any<object>`
  - when `SkillLv(625) ge 1` AND `SkillLv(621) ge 10` AND `(SkillBufferManager.TryGetBuf(?blr, 621, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.Component$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillActionManager$$get_PlaceSkilList`, `System.Linq.Enumerable$$Any<object>`
  - when `SkillLv(625) ge 1` AND `SkillLv(621) ge 10` AND `(SkillBufferManager.TryGetBuf(?blr, 621, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.Component$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `SkillLv(625) ge 1` AND `SkillLv(621) ge 10` AND `(SkillBufferManager.TryGetBuf(?blr, 621, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.Component$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `SkillLv(625) ge 1` AND `SkillLv(621) ge 10` AND `(SkillBufferManager.TryGetBuf(?blr, 621, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.Component$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`, `0x165db84`
  - when `SkillLv(625) ge 1` AND `SkillLv(621) ge 10` AND `(SkillBufferManager.TryGetBuf(?blr, 621, stkp(-40), 0) & 1) eq 0`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.Component$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`
  - when `SkillLv(625) ge 1` AND `SkillLv(621) ge 10`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.Component$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`
  - when `SkillLv(625) ge 1` AND `SkillLv(621) ge 10`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.Component$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`
- Effect applied in `ShadowlessSlashAction$$ActionSkillEvent` (12 guarded paths):
  - when `param ne 102` AND `param ne 101` AND `param eq 100` AND `MobaMode ne 0`
    - returns `GameManager.SkillEvent(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), meta(0), ?x2, ?x3), UnityEngine.Component.get_gameObject(actarAction, 0, ?x2, ?x3), 625, Id)`
    - set `shadowless` = `1`
    - calls `SkillActionBase$$ActionSkillEvent`, `0x165db78`, `ShadowlessSlashBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_gameObject`, `GameManager$$SkillEvent`
  - when `param ne 102` AND `param ne 101` AND `param eq 100` AND `MobaMode ne 0`
    - set `shadowless` = `1`
    - calls `SkillActionBase$$ActionSkillEvent`, `0x165db78`, `ShadowlessSlashBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `0x165db84`, `0x165df00`
  - when `param ne 102` AND `param ne 101` AND `param eq 100` AND `MobaMode ne 0`
    - returns `GameManager.SkillEvent(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), meta(0), ?x2, ?x3), UnityEngine.Component.get_gameObject(actarAction, 0, ?x2, ?x3), 625, Id)`
    - set `shadowless` = `1`
    - calls `SkillActionBase$$ActionSkillEvent`, `0x165db78`, `ShadowlessSlashBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `SkillBufferManager$$AddSelfBuffer`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_gameObject`, `GameManager$$SkillEvent`
  - when `param ne 102` AND `param ne 101` AND `param eq 100` AND `MobaMode ne 0`
    - returns `SkillLv(621)`
    - set `shadowless` = `1`
    - calls `SkillActionBase$$ActionSkillEvent`, `0x165db78`, `ShadowlessSlashBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
  - when `param ne 102` AND `param ne 101` AND `param eq 100` AND `MobaMode eq 0`
    - returns `GameManager.SkillEvent(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), meta(0), ?x2, ?x3), UnityEngine.Component.get_gameObject(actarAction, 0, ?x2, ?x3), 625, Id)`
    - set `shadowless` = `1`
    - calls `SkillActionBase$$ActionSkillEvent`, `0x165db78`, `ShadowlessSlashBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_gameObject`, `GameManager$$SkillEvent`
  - when `param ne 102` AND `param ne 101` AND `param eq 100` AND `MobaMode eq 0`
    - set `shadowless` = `1`
    - calls `SkillActionBase$$ActionSkillEvent`, `0x165db78`, `ShadowlessSlashBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `0x165db84`, `0x165df00`
  - when `param ne 102` AND `param ne 101` AND `param eq 100` AND `MobaMode eq 0`
    - returns `GameManager.SkillEvent(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), meta(0), ?x2, ?x3), UnityEngine.Component.get_gameObject(actarAction, 0, ?x2, ?x3), 625, Id)`
    - set `shadowless` = `1`
    - calls `SkillActionBase$$ActionSkillEvent`, `0x165db78`, `ShadowlessSlashBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `SkillBufferManager$$AddSelfBuffer`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_gameObject`, `GameManager$$SkillEvent`
  - when `param ne 102` AND `param ne 101` AND `param eq 100` AND `MobaMode eq 0`
    - returns `SkillLv(621)`
    - set `shadowless` = `1`
    - calls `SkillActionBase$$ActionSkillEvent`, `0x165db78`, `ShadowlessSlashBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
- Code that reads this skill's level / buff by constant id: `FinishingTouchAction$$AddSwordSoul (GetSkillLv)`, `IchijhinnokazeAttackAction.<>c__DisplayClass117_0$$<AddMotionEndFinishingTouchBuf>b__0 (GetSkillLv)`, `NormalAttackAction.<>c__DisplayClass81_0$$<calcPlayerToMobDamage>b__0 (GetSkillLv)`, `PlayerAttackBase$$CalcBufferLastDamageRate (TryGetBuf)`, `PlayerAttackBase.<>c__DisplayClass113_0$$<ActionStart>b__1 (GetSkillLv)`, `RepelBladeAction.<>c__DisplayClass30_0$$<ActionStart>b__1 (GetSkillLv)`, `ShadowlessSlashAction$$ActionSkillEvent (GetSkillLv)`, `TenjhoTengeMusouSwordAction$$ActionStart (TryGetBuf)`, `TenjhoTengeMusouSwordAction$$CheckActive (GetSkillLv)`, `TenjhoTengeMusouSwordAction$$CheckActive (TryGetBuf)`

_Raw recovered data (every method item): [trees/MononofuSkill.md](../trees/MononofuSkill.md) — uid 621_

---

### ไคริกิรันชิน (WeirdnessOfGod) · uid 622

<img src="../../icons/sk_622.png" width="40" alt="icon"> 
**Tree:** モノノフスキル (`MononofuSkill`, tier 4) · **Type:** Buffer · **Max Lv:** 150 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เมเคียวชิซุย · **Client class:** `WeirdnessOfGodAction`

> ปลดปล่อยพลังปิศาจที่แฝงอยู่ภายใน
> เพิ่ม ATK/ฟื้นฟู MP โจมตี/การโจมตีปกติ
> อัพเกรดการทะลวงการป้องกัน/อัตราคริติคอลของการิวเท็นเซ
> ตัวเองจะติด[ไหม้ไฟ]เมื่อใช้งาน

**How it works**

- Buffer skill of the モノノフスキル tree (tier 4, max Lv 150); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- Its buff raises normal-attack damage (`NormalAttackRate` / `NormalAttackConstantDamage`).
- Buffs:
  - `WeirdnessOfGodBuf`: lasts `(int((Lv * 0.5)) + 5)` s; Lv1 → Lv10: AttackMprecoveryUp (MP recovered per attack (flat)) 6 → 25
- Other client code reads this skill (3 lookups; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionStart` — when the cast starts: 3 set, 1 call
- `EffectiveAbnormalIgnition` — skill-specific method: 3 call
- `OnInheritance` — state carried over when this action follows another: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 622
- No proration slot: ExpType None: no proration slot.

**Status ailments**

- Extra percent roll `CheckPercent` (`ActionStart`)
  - when `!UnityEngine.Object.op_Equality(actarAction) AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND MathUtil.CheckPercent(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) << 2)) << 1)) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) ge 1 AND hasGemCart(401) OR !UnityEngine.Object.op_Equality(actarAction) AND IsInstanceOf(actarAction, PlayerActionManager) ne 1 AND MathUtil.CheckPercent(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) << 2)) << 1)) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) ge 1 AND hasGemCart(401) OR !MathUtil.CheckPercent(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) << 2)) << 1)) AND !UnityEngine.Object.op_Equality(actarAction) AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) ge 1 AND hasGemCart(401)`

**Buffs and effects it installs or removes**

- `EffectiveAbnormalIgnition` (method): constructs `WeirdnessOfGodBuf` — `.ctor(skill.Level, (PlayerAttackBase.ExistWeaponType(playerAction, 8) ? 8 : 0))`
  - when `!SkillActionBase.op_Equality(skill) AND !hasBuff(CrtDamageUp) AND PlayerAttackBase.get_ActionID() eq 622 OR !SkillActionBase.op_Equality(skill) AND PlayerAttackBase.get_ActionID() eq 622 AND hasBuff(CrtDamageUp) OR !SkillActionBase.op_Equality(skill) AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND PlayerAttackBase.get_ActionID() eq 622`
- `EffectiveAbnormalIgnition` (method): adds the caster's buff of `new WeirdnessOfGodBuf` — `AddSelfBuffer(new WeirdnessOfGodBuf, skill.Id)`
  - when `!SkillActionBase.op_Equality(skill) AND !hasBuff(CrtDamageUp) AND PlayerAttackBase.get_ActionID() eq 622 OR !SkillActionBase.op_Equality(skill) AND PlayerAttackBase.get_ActionID() eq 622 AND hasBuff(CrtDamageUp) OR !SkillActionBase.op_Equality(skill) AND IsInstanceOf(playerAction, PlayerActionManager) ne 1 AND PlayerAttackBase.get_ActionID() eq 622`
- `EffectiveAbnormalIgnition` (method): removes the caster's buff of skill 41 (Rampage) — `RemoveSelfBuffer(41)`
  - when `!SkillActionBase.op_Equality(skill) AND !hasBuff(CrtDamageUp) AND PlayerAttackBase.get_ActionID() eq 622`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**Buff values** (every recovered field; durations in seconds)

**Buff `WeirdnessOfGodBuf`**
- **Boosts normal-attack damage** through the `NormalAttackRate` / `NormalAttackConstantDamage` parameters.
- Duration: `(int((Lv * 0.5)) + 5)` s; `(((int((Lv * 0.5)) + 5)) * 3)` s [weaponType eq 8]
- `AtkUp` = `atk` _(when BuffEffectActive ne 0)_
- `NormalAttackRate` = `((normalAttackRate + 50))` _(when BuffEffectActive ne 0)_
- `Value` = `registBreak` _(when BuffEffectActive ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| AttackMprecoveryUp | 6 | 7 | 8 | 9 | 10 | 16 | 17 | 18 | 19 | 25 |

- Buff fields set in the constructor (all recovered):
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
  - `BufEffectTakeUid` = `-1` = -1
  - `atkMpHeal` = `((Lv hi 5 ? (Lv eq 10 ? 15 : 10) : 5) + Lv)` → Lv1..10 [6, 7, 8, 9, 10, 16, 17, 18, 19, 25]
- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `normalAttackRate` = `(normalAttackRate + 50)` when weaponType eq 8
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

Parameter meanings (inferred from the `SkillBufferId` names):

- `AtkUp`: ATK +
- `AttackMprecoveryUp`: MP recovered per attack (flat)
- `NormalAttackRate`: normal-attack damage multiplier (%)
- `Value`: generic value (meaning set by the code that reads the buff)

**In-game level notes**

- Lv8: *พลังการโจมตีปกติ +50 *3x ระยะเวลาแสดงผล

**Where else this skill takes effect**

- Effect applied in `TenjhoTengeMusouSwordAction$$ActionPreparation` (6 guarded paths):
  - when `SkillLv(622) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 622, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 622, stkp(-56), 0)`
    - set `resistBreaker` = `(([TryGetBuf.out2()+0x10] + ([TryGetBuf.out2()+0x10] << 2)) << 1)`
    - set `critical` = `(critical + (([TryGetBuf.out2()+0x10] + ([TryGetBuf.out2()+0x10] << 2)) << 1))`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `PlayerAttackBase$$ExistWeaponType`, `0x165db78`, `WeirdnessOfGodBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
  - when `SkillLv(622) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 622, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `PlayerAttackBase$$ExistWeaponType`, `0x165db78`, `WeirdnessOfGodBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `0x165db84`
  - when `SkillLv(622) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 622, stkp(-56), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 622, stkp(-56), 0)`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `PlayerAttackBase$$ExistWeaponType`, `0x165db78`, `WeirdnessOfGodBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
  - when `SkillLv(622) lt 1` AND `(SkillBufferManager.TryGetBuf(?blr, 622, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 622, stkp(-56), 0)`
    - set `resistBreaker` = `(([TryGetBuf.out2()+0x10] + ([TryGetBuf.out2()+0x10] << 2)) << 1)`
    - set `critical` = `(critical + (([TryGetBuf.out2()+0x10] + ([TryGetBuf.out2()+0x10] << 2)) << 1))`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`
  - when `SkillLv(622) lt 1` AND `(SkillBufferManager.TryGetBuf(?blr, 622, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `0x165db84`
  - when `SkillLv(622) lt 1` AND `(SkillBufferManager.TryGetBuf(?blr, 622, stkp(-56), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 622, stkp(-56), 0)`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`
- Code that reads this skill's level / buff by constant id: `IchijhinnokazeAttackAction$$ActionPreparation (GetSkillLv)`, `TenjhoTengeMusouSwordAction$$ActionPreparation (GetSkillLv)`, `TenjhoTengeMusouSwordAction$$ActionPreparation (TryGetBuf)`

_Raw recovered data (every method item): [trees/MononofuSkill.md](../trees/MononofuSkill.md) — uid 622_

---

### ลมกรด (Hayate) · uid 630

<img src="../../icons/sk_630.png" width="40" alt="icon"> 
**Tree:** モノノフスキル (`MononofuSkill`, tier 4) · **Type:** Attack · **Max Lv:** 150 · **Weapons:** Katana · **Requires:** [N]ลมกระโชก[N2]ลมสงบนิ่ง[N3]ลมเหนือ[N4]ลมตะวันออก[N5]ลมตะวันตก[N6]ลมใต้[N7]สี่ฤดูกาล[N] · **Client class:** `HayateAction`

> หลบหนีจากวิกฤตได้ราวสายลมพัด(เฉพาะในสถานะลมกระโชกเท่านั้น)
> ระหว่างการกระโดดจะอยู่ในสถานะคงกระพัน
> เมื่อเวลาผ่านไปหรือกดคีย์จะโจมตีแบบพุ่งลง
> พลังโจมตีเพิ่มขึ้นตามระยะเวลาที่คงกระพันแต่หากไม่มีเป้าหมายอยู่ที่จุดตกถึงพื้นจะ MISS

**How it works**

- Attack skill of the モノノフスキル tree (tier 4, max Lv 150); usable with Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×0.6 at Lv1 to 6 at Lv10; flat damage +400
  - `calcPlayerToMobDamage` [jumpElapsedTime ge 1]: skill multiplier depends on live values (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(100)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `ActionPreparation` — before the cast starts: 1 set
- `ActionSkillEvent` — on an animation/skill event during the motion: 3 set
- `ActionSkillEventIfMoveIndex` — skill-specific method: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 3 tpl, 1 info
- `InitializeOthers` — setup used when another player's client replays the action: 2 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.6 | 1.2 | 1.8 | 2.4 | 3 | 3.6 | 4.2 | 4.8 | 5.4 | 6 |
| Flat dmg + | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((int(((UnityEngine.Time.get_realtimeSinceStartup() - (UnityEngine.Time.get_realtimeSinceStartup())))) lt 4 ? int(((UnityEngine.Time.get_realtimeSinceStartup() - (UnityEngine.Time.get_realtimeSinceStartup())))) : 4) * 300) / 100)` — jumpElapsedTime ge 1

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((Lv * 60)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(400)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((int(((UnityEngine.Time.get_realtimeSinceStartup() - (UnityEngine.Time.get_realtimeSinceStartup())))) lt 4 ? int(((UnityEngine.Time.get_realtimeSinceStartup() - (UnityEngine.Time.get_realtimeSinceStartup())))) : 4) * 300) / 100)`
  - when `jumpElapsedTime ge 1`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 630
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

_Raw recovered data (every method item): [trees/MononofuSkill.md](../trees/MononofuSkill.md) — uid 630_

---

### คาสุมิเซ็ตสึเก็คคะ / เท็นริวรันเซ:ซันยุ (IllusionaryScene) · uid 624

<img src="../../icons/sk_624.png" width="40" alt="icon"> 
**Tree:** モノノフスキル (`MononofuSkill`, tier 5) · **Type:** Attack · **Max Lv:** 240 · **Weapons:** Katana · **Requires:** เท็นริวรันเซ · **Client class:** `IllusionarySceneAction`

> ฟาดฟันโจมตีเป้าหมายอย่างต่อเนื่อง
> ลดความเสียหายที่ได้รับลงอย่างมากขณะใช้งาน
> จะเกิดการโจมตีพิเศษถ้ามีผลของเท็นริวรันเซอยู่
> ระยะเวลาต่อเนื่องของพลังที่เพิ่มจะขึ้นอยู่กับจำนวนครั้งที่ใช้งาน

**How it works**

- Attack skill of the モノノフスキル tree (tier 5, max Lv 240); usable with Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x2; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×8.25 at Lv1 to 15 at Lv10; flat damage +200; flat damage depends on live values (formula below)
  - `calcPlayerToMobDamage` [TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 620) ne 0 AND mainWeapon == Katana OR TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 620) ne 0 AND mainWeapon != Katana AND subWeapon == Katana]: skill multiplier depends on Dex (formula below)
  - `calcPlayerToMobDamage` [TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 620) ne 0 AND mainWeapon != Katana AND subWeapon != Katana]: skill multiplier depends on Dex (formula below)
  - `calcPlayerToMobDamage` [mainWeapon == Katana OR mainWeapon != Katana AND subWeapon == Katana]: skill multiplier depends on Dex (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: None (0).
- Buffs:
  - `IllusionarySceneBuf`; Lv1 → Lv10: MobLastDamageRateBuf (final damage multiplier vs monsters (buff category)) 9 → 90
  - `OkaranmanBuf`: marker buff (no parameters; other code tests whether it is present)
  - `CountBufferBase`
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (5 lookups; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 6 set
- `ActionPreparation` — before the cast starts: 2 set, 2 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 6 tpl, 1 info
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `Damaged` — when the caster takes damage while the action / buff is active: 1 call
- `.<>c__DisplayClass30_0::<ActionPreparation>b__0` — skill-specific method: 4 call
- `.<>c__DisplayClass30_0::<ActionPreparation>b__1` — skill-specific method: 3 call
- `.<>c__DisplayClass30_0::<ActionPreparation>b__2` — skill-specific method: 1 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 8.25 | 9 | 9.75 | 10.5 | 11.25 | 12 | 12.75 | 13.5 | 14.25 | 15 |
| Flat dmg + | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((((SkillBufferDataBase.GetParam(20) lt 1 ? 100 : (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 620, 1) * 25) + 150) * SkillBufferDataBase.GetParam(20))) + ((status.Dex << 1) // (5 - SkillBufferDataBase.GetParam(20))))) / 100)` — TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 620) ne 0 AND mainWeapon == Katana OR TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 620) ne 0 AND mainWeapon != Katana AND subWeapon == Katana
- SkillRate × `((((SkillBufferDataBase.GetParam(20) lt 1 ? 100 : (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 620, 1) * 25) + 150) * SkillBufferDataBase.GetParam(20))) + ((status.Dex << 1) // (5 - SkillBufferDataBase.GetParam(20))))) / 100)` — TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 620) ne 0 AND mainWeapon != Katana AND subWeapon != Katana
- SkillRate × `((((SkillBufferDataBase.GetParam(20) lt 1 ? 100 : (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 620, 1) * 25) + 150) * SkillBufferDataBase.GetParam(20))) + ((status.Dex << 1) // (5 - SkillBufferDataBase.GetParam(20))))) / 100)` — mainWeapon == Katana OR mainWeapon != Katana AND subWeapon == Katana
- Flat dmg + `rangekiConstantDamage`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv * 75) + 750)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `rangekiConstantDamage`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[FirstAttackRate]` = `(PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, playerAction)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((SkillBufferDataBase.GetParam(20) lt 1 ? 100 : (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 620, 1) * 25) + 150) * SkillBufferDataBase.GetParam(20))) + ((status.Dex << 1) // (5 - SkillBufferDataBase.GetParam(20))))) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(200)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 624
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Marks the hit with ailment **None (0)** (`Damaged`)
  - when `!UnityEngine.Object.op_Equality(playerAction) AND IsInstanceOf(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 624), IllusionarySceneBuf) eq 1 AND SkillDamageData.IsInactivityAbnormal(damageData) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 624) ne 0`

**Buffs and effects it installs or removes**

- `ActionPreparation` (before the cast starts): constructs `IllusionarySceneBuf` — `.ctor(Lv)`
  - when `!PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 620) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 620) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)`
- `ActionPreparation` (before the cast starts): adds the caster's buff of `new IllusionarySceneBuf` — `AddSelfBuffer(new IllusionarySceneBuf, Id)`
  - when `!PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 620) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 620) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)`
- `.<>c__DisplayClass30_0::<ActionPreparation>b__0` (method): adds the caster's buff of skill 620 (HeavenlyStar) — `AddSelfBuffer(620, SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 620, 1), 0)`
- `.<>c__DisplayClass30_0::<ActionPreparation>b__0` (method): removes the caster's buff of skill 624 (IllusionaryScene) — `RemoveSelfBuffer(624)`
- `.<>c__DisplayClass30_0::<ActionPreparation>b__0` (method): constructs `OkaranmanBuf` — `.ctor([<>c__DisplayClass30_0.<>4__this+0x14])`
- `.<>c__DisplayClass30_0::<ActionPreparation>b__0` (method): adds the caster's buff of `new OkaranmanBuf` — `AddSelfBuffer(new OkaranmanBuf, 0)`
- `.<>c__DisplayClass30_0::<ActionPreparation>b__1` (method): removes the caster's buff of skill 624 (IllusionaryScene) — `RemoveSelfBuffer(624)`
- `.<>c__DisplayClass30_0::<ActionPreparation>b__1` (method): constructs `OkaranmanBuf` — `.ctor([<>c__DisplayClass30_0.<>4__this+0x14])`
- `.<>c__DisplayClass30_0::<ActionPreparation>b__1` (method): adds the caster's buff of `new OkaranmanBuf` — `AddSelfBuffer(new OkaranmanBuf, 0)`
- `.<>c__DisplayClass30_0::<ActionPreparation>b__2` (method): removes the caster's buff of skill 624 (IllusionaryScene) — `RemoveSelfBuffer(624)`
  - when `(cancel & 1) ne 0`

**Buff values** (every recovered field; durations in seconds)

**Buff `IllusionarySceneBuf`**
- Buff hook methods: `CheckParry`, `CheckSuperArmor`, `EndSuperArmor`, `ParrySuccess`
- `MobLastDamageRateBuf` = `0` _(when BuffEffectActive eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MobLastDamageRateBuf | 9 | 18 | 27 | 36 | 45 | 54 | 63 | 72 | 81 | 90 |

- Buff fields set in the constructor (all recovered):
  - `isSuperArmor` = `1` = 1
  - `damageCutValue` = `((Lv << 3) + lv)` → Lv1..10 [9, 18, 27, 36, 45, 54, 63, 72, 81, 90]
- Hook `ParrySuccess`: `parrySuccess`=1
- Hook `EndSuperArmor`: `isSuperArmor`=0
**Buff `OkaranmanBuf`**
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:OkaranmanBuf$$.ctor<-IllusionarySceneAction.<>c__DisplayClass30_0$$<ActionPreparation>b__0` (no direct constructor call in the skill's own code).
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
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:IllusionarySceneBuf$$.ctor<-IllusionarySceneAction$$ActionPreparation` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

Parameter meanings (inferred from the `SkillBufferId` names):

- `Count`: stack / hit counter
- `MobLastDamageRateBuf`: final damage multiplier vs monsters (buff category)

**Where else this skill takes effect**

- Effect applied in `IllusionarySceneAction.<>c__DisplayClass30_0$$<ActionPreparation>b__0` (12 guarded paths):
  - when `(SkillBufferManager.TryGetBuf<object>(?blr, 620, stkp(-40), meta(0x399f910, Method$SkillBufferManager.TryGetBuf<HeavenlyStarBuf>())) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 624, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.AddSelfBuffer(?blr, 0x165db78(meta(0x39a8b78, OkaranmanBuf_TypeInfo), ?x1, ?x2, ?x3), 0, 0)`
    - calls `SkillBufferManager$$AddSelfBuffer`, `SkillBufferManager$$RemoveSelfBuffer`, `HeavenlyStarBuf$$IllusionarySceneReset`, `0x165db78`, `OkaranmanBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
  - when `(SkillBufferManager.TryGetBuf<object>(?blr, 620, stkp(-40), meta(0x399f910, Method$SkillBufferManager.TryGetBuf<HeavenlyStarBuf>())) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 624, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `HeavenlyStarBuf.IllusionarySceneReset(SkillBufferManager.AddSelfBuffer(?blr, 620, SkillLv(620), 0), ?blr, [<>c__DisplayClass30_0.<>4__this+0x130], ([TryGetBuf.out2()+0x24] ne 0 ? 1 : 0))`
    - calls `SkillBufferManager$$AddSelfBuffer`, `SkillBufferManager$$RemoveSelfBuffer`, `HeavenlyStarBuf$$IllusionarySceneReset`
  - when `(SkillBufferManager.TryGetBuf<object>(?blr, 620, stkp(-40), meta(0x399f910, Method$SkillBufferManager.TryGetBuf<HeavenlyStarBuf>())) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 624, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `SkillBufferManager$$AddSelfBuffer`, `0x165db84`, `0x165df00`
  - when `(SkillBufferManager.TryGetBuf<object>(?blr, 620, stkp(-40), meta(0x399f910, Method$SkillBufferManager.TryGetBuf<HeavenlyStarBuf>())) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 624, stkp(-48), 0) & 1) eq 0`
    - returns `SkillBufferManager.AddSelfBuffer(?blr, 0x165db78(meta(0x39a8b78, OkaranmanBuf_TypeInfo), ?x1, ?x2, ?x3), 0, 0)`
    - calls `SkillBufferManager$$AddSelfBuffer`, `SkillBufferManager$$RemoveSelfBuffer`, `HeavenlyStarBuf$$IllusionarySceneReset`, `0x165db78`, `OkaranmanBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
  - when `(SkillBufferManager.TryGetBuf<object>(?blr, 620, stkp(-40), meta(0x399f910, Method$SkillBufferManager.TryGetBuf<HeavenlyStarBuf>())) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 624, stkp(-48), 0) & 1) eq 0`
    - returns `HeavenlyStarBuf.IllusionarySceneReset(SkillBufferManager.AddSelfBuffer(?blr, 620, SkillLv(620), 0), ?blr, [<>c__DisplayClass30_0.<>4__this+0x130], 0)`
    - calls `SkillBufferManager$$AddSelfBuffer`, `SkillBufferManager$$RemoveSelfBuffer`, `HeavenlyStarBuf$$IllusionarySceneReset`
  - when `(SkillBufferManager.TryGetBuf<object>(?blr, 620, stkp(-40), meta(0x399f910, Method$SkillBufferManager.TryGetBuf<HeavenlyStarBuf>())) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 624, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `TryGetBuf<object>.out2() ne 0`
    - returns `SkillBufferManager.AddSelfBuffer(?blr, 0x165db78(meta(0x39a8b78, OkaranmanBuf_TypeInfo), ?x1, ?x2, ?x3), 0, 0)`
    - calls `SkillBufferManager$$RemoveSelfBuffer`, `HeavenlyStarBuf$$IllusionarySceneReset`, `0x165db78`, `OkaranmanBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
  - when `(SkillBufferManager.TryGetBuf<object>(?blr, 620, stkp(-40), meta(0x399f910, Method$SkillBufferManager.TryGetBuf<HeavenlyStarBuf>())) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 624, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `TryGetBuf<object>.out2() ne 0`
    - returns `HeavenlyStarBuf.IllusionarySceneReset(TryGetBuf<object>.out2(), ?blr, [<>c__DisplayClass30_0.<>4__this+0x130], ([TryGetBuf.out2()+0x24] ne 0 ? 1 : 0))`
    - calls `SkillBufferManager$$RemoveSelfBuffer`, `HeavenlyStarBuf$$IllusionarySceneReset`
  - when `(SkillBufferManager.TryGetBuf<object>(?blr, 620, stkp(-40), meta(0x399f910, Method$SkillBufferManager.TryGetBuf<HeavenlyStarBuf>())) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 624, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `TryGetBuf<object>.out2() eq 0`
    - calls `SkillBufferManager$$RemoveSelfBuffer`, `0x165db84`, `0x165df00`
- Effect applied in `FacticeArmeAction$$ActionSkillEvent` (3 guarded paths):
  - when `param eq 100` AND `type eq 4` AND `IsOtherPlayer eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 624, stkp(-40), 0) & 1) ne 0`
    - returns `GameManager.SkillEvent(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), UnityEngine.Component.get_gameObject(actarAction, 0, ?x2, ?x3), PlayerAttackBase.get_ActionID(), Id)`
    - calls `SkillActionBase$$ActionSkillEvent`, `IllusionarySceneBuf$$EndSuperArmor`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_gameObject`, `virtual PlayerAttackBase.get_ActionID`, `GameManager$$SkillEvent`
  - when `param eq 100` AND `type eq 4` AND `IsOtherPlayer eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 624, stkp(-40), 0) & 1) ne 0`
    - returns `GameManager.SkillEvent(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), UnityEngine.Component.get_gameObject(actarAction, 0, ?x2, ?x3), PlayerAttackBase.get_ActionID(), Id)`
    - calls `SkillActionBase$$ActionSkillEvent`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_gameObject`, `virtual PlayerAttackBase.get_ActionID`, `GameManager$$SkillEvent`
  - when `param eq 100` AND `type eq 4` AND `IsOtherPlayer eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 624, stkp(-40), 0) & 1) eq 0`
    - returns `GameManager.SkillEvent(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), UnityEngine.Component.get_gameObject(actarAction, 0, ?x2, ?x3), PlayerAttackBase.get_ActionID(), Id)`
    - calls `SkillActionBase$$ActionSkillEvent`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_gameObject`, `virtual PlayerAttackBase.get_ActionID`, `GameManager$$SkillEvent`
- Effect applied in `IllusionarySceneAction$$ActionSkillEvent` (6 guarded paths):
  - when `param eq 100` AND `IsOtherPlayer eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 624, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `GameManager.SkillEvent(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), UnityEngine.Component.get_gameObject(actarAction, 0, ?x2, ?x3), PlayerAttackBase.get_ActionID(), Id)`
    - calls `SkillActionBase$$ActionSkillEvent`, `IllusionarySceneBuf$$EndSuperArmor`, `Singleton<object>$$get_Instance`, `virtual PlayerAttackBase.get_ActionID`, `UI3DLabelManager$$SetSkillPopUp`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_gameObject`, `virtual PlayerAttackBase.get_ActionID`
  - when `param eq 100` AND `IsOtherPlayer eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 624, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `GameManager.SkillEvent(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), UnityEngine.Component.get_gameObject(actarAction, 0, ?x2, ?x3), PlayerAttackBase.get_ActionID(), Id)`
    - calls `SkillActionBase$$ActionSkillEvent`, `IllusionarySceneBuf$$EndSuperArmor`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_gameObject`, `virtual PlayerAttackBase.get_ActionID`, `GameManager$$SkillEvent`
  - when `param eq 100` AND `IsOtherPlayer eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 624, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - returns `GameManager.SkillEvent(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), UnityEngine.Component.get_gameObject(actarAction, 0, ?x2, ?x3), PlayerAttackBase.get_ActionID(), Id)`
    - calls `SkillActionBase$$ActionSkillEvent`, `Singleton<object>$$get_Instance`, `virtual PlayerAttackBase.get_ActionID`, `UI3DLabelManager$$SetSkillPopUp`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_gameObject`, `virtual PlayerAttackBase.get_ActionID`, `GameManager$$SkillEvent`
  - when `param eq 100` AND `IsOtherPlayer eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 624, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - returns `GameManager.SkillEvent(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), UnityEngine.Component.get_gameObject(actarAction, 0, ?x2, ?x3), PlayerAttackBase.get_ActionID(), Id)`
    - calls `SkillActionBase$$ActionSkillEvent`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_gameObject`, `virtual PlayerAttackBase.get_ActionID`, `GameManager$$SkillEvent`
  - when `param eq 100` AND `IsOtherPlayer eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 624, stkp(-40), 0) & 1) eq 0` AND `(SkillIndividualFlag & 1) ne 0`
    - returns `GameManager.SkillEvent(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), UnityEngine.Component.get_gameObject(actarAction, 0, ?x2, ?x3), PlayerAttackBase.get_ActionID(), Id)`
    - calls `SkillActionBase$$ActionSkillEvent`, `Singleton<object>$$get_Instance`, `virtual PlayerAttackBase.get_ActionID`, `UI3DLabelManager$$SetSkillPopUp`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_gameObject`, `virtual PlayerAttackBase.get_ActionID`, `GameManager$$SkillEvent`
  - when `param eq 100` AND `IsOtherPlayer eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 624, stkp(-40), 0) & 1) eq 0` AND `(SkillIndividualFlag & 1) eq 0`
    - returns `GameManager.SkillEvent(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), UnityEngine.Component.get_gameObject(actarAction, 0, ?x2, ?x3), PlayerAttackBase.get_ActionID(), Id)`
    - calls `SkillActionBase$$ActionSkillEvent`, `Singleton<object>$$get_Instance`, `UnityEngine.Component$$get_gameObject`, `virtual PlayerAttackBase.get_ActionID`, `GameManager$$SkillEvent`
- Effect applied in `IllusionarySceneAction$$Damaged` (5 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 624, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `IllusionarySceneBuf.ParrySuccess(TryGetBuf.out2(), 0, ?x2, ?x3)`
    - calls `SkillDamageData$$IsInactivityAbnormal`, `SkillDamageData$$SetAbnormalType`, `IllusionarySceneBuf$$ParrySuccess`
  - when `(SkillBufferManager.TryGetBuf(?blr, 624, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `IllusionarySceneBuf.ParrySuccess(TryGetBuf.out2(), 0, ?x2, ?x3)`
    - calls `SkillDamageData$$IsInactivityAbnormal`, `IllusionarySceneBuf$$ParrySuccess`
  - when `(SkillBufferManager.TryGetBuf(?blr, 624, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `IllusionarySceneBuf.ParrySuccess(TryGetBuf.out2(), 0, ?x2, ?x3)`
    - calls `SkillDamageData$$IsInactivityAbnormal`, `IllusionarySceneBuf$$ParrySuccess`
  - when `(SkillBufferManager.TryGetBuf(?blr, 624, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 624, stkp(-40), 0)`
  - when `(SkillBufferManager.TryGetBuf(?blr, 624, stkp(-40), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 624, stkp(-40), 0)`
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
- Code that reads this skill's level / buff by constant id: `FacticeArmeAction$$ActionSkillEvent (TryGetBuf)`, `IllusionarySceneAction$$ActionSkillEvent (TryGetBuf)`, `IllusionarySceneAction$$Damaged (TryGetBuf)`, `IllusionarySceneAction.<>c__DisplayClass30_0$$<ActionPreparation>b__0 (TryGetBuf)`, `MobAttackBase$$CalcLastDamage (TryGetBuf)`

_Raw recovered data (every method item): [trees/MononofuSkill.md](../trees/MononofuSkill.md) — uid 624_

---

### ชาโดว์เลสสแลช (ShadowlessSlash) · uid 625

<img src="../../icons/sk_625.png" width="40" alt="icon"> 
**Tree:** モノノフスキル (`MononofuSkill`, tier 5) · **Type:** Object · **Max Lv:** 240 · **Weapons:** Katana · **Requires:** การิวเท็นเซ · **Client class:** `ShadowlessSlashAction`

> ฟันด้วยความเร็วสูงจนแม้แต่ศัตรูก็มองไม่ออกว่า
> คาตานะออกจากฝักตั้งแต่เมื่อไหร่
> โจมตีเป้าหมายด้วยความแม่นยำสูง
> และเพิ่มประสิทธิภาพด้วยบัฟทั้ง 2 ของมังกรผงาดฟ้า
> สามารถเคลื่อนไหวตอนเก็บดาบเข้าฝักได้

**How it works**

- Object skill of the モノノフスキル tree (tier 5, max Lv 240); usable with Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- It places an object in the world (trap, summon or field object).
- `NormalAttackAction` looks its buff up and changes how normal attacks run while it is active.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on live values (formula below); flat damage +300
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Buffs:
  - `ShadowlessSlashBuf`: lasts `1` s; Lv1 → Lv10: HitRate (accuracy %) 3 → 300
  - `SwordMoveBuf`
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- **Effect radius (Unity units)** (`Radius`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance(2.5)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `ActionSkillEvent` — on an animation/skill event during the motion: 3 set, 3 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 4 tpl, 3 call, 1 info
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `OtherPlayerSkillEventReceive` — skill-specific method: 1 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv * 50) + 400) + (((baseAGI + baseDEX) lt 0 ? ((baseAGI + baseDEX) + 1) : (baseAGI + baseDEX)) >> 1))) / 100)`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv * 50) + 400) + (((baseAGI + baseDEX) lt 0 ? ((baseAGI + baseDEX) + 1) : (baseAGI + baseDEX)) >> 1))) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(300)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[FirstAttackRate]` = `(PlayerAttackBase.calcFastAttackDamageRate(playerAction) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[FirstAttack]` = `PlayerAttackBase.calcFastAttackDamage(this, playerAction)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 625
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `ActionSkillEvent` (on an animation/skill event during the motion): constructs `ShadowlessSlashBuf` — `.ctor(Lv)`
  - when `!UnityEngine.Object.op_Equality(actarAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 621, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 100 AND param ne 101 AND param ne 102 OR !UnityEngine.Object.op_Equality(actarAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 621, 1) lt 1 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 100 AND param ne 101 AND param ne 102 OR MobaMode ne 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 621, 1) ge 1 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 100 AND param ne 101 AND param ne 102`
- `ActionSkillEvent` (on an animation/skill event during the motion): adds the caster's buff of `new ShadowlessSlashBuf` — `AddSelfBuffer(new ShadowlessSlashBuf, Id)`
  - when `!UnityEngine.Object.op_Equality(actarAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 621, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 100 AND param ne 101 AND param ne 102 OR !UnityEngine.Object.op_Equality(actarAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 621, 1) lt 1 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 100 AND param ne 101 AND param ne 102 OR MobaMode ne 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 621, 1) ge 1 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 100 AND param ne 101 AND param ne 102`
- `ActionSkillEvent` (on an animation/skill event during the motion): adds the caster's buff of skill 621 (FinishingTouch) — `AddSelfBuffer(621, SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 621, 1), 0)`
  - when `!UnityEngine.Object.op_Equality(actarAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 621, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 100 AND param ne 101 AND param ne 102 OR MobaMode ne 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 621, 1) ge 1 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 100 AND param ne 101 AND param ne 102 OR MobaMode eq 0 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 621, 1) ge 1 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 100 AND param ne 101 AND param ne 102`
- `calcPlayerToMobDamage` (damage calculation against a monster): constructs `ShadowlessSlashBuf` — `.ctor(Lv)`
- `calcPlayerToMobDamage` (damage calculation against a monster): adds the caster's buff of `new ShadowlessSlashBuf` — `AddSelfBuffer(new ShadowlessSlashBuf, Id)`
- `calcPlayerToMobDamage` (damage calculation against a monster): removes the caster's buff of skill 625 (ShadowlessSlash) — `RemoveSelfBuffer(625)`

**Other recovered parameters**

- **Effect radius (Unity units)** (`Radius`): `MathUtil.DisplayMeterToDistance(2.5)`

**Buff values** (every recovered field; durations in seconds)

**Buff `ShadowlessSlashBuf`**
- Duration: `1` s
- `HitRate` = `0` _(when BuffEffectActive eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| HitRate | 3 | 12 | 27 | 48 | 75 | 108 | 147 | 192 | 243 | 300 |

- Buff fields set in the constructor (all recovered):
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `hitRate` = `((Lv * Lv) + ((Lv * Lv) << 1))` → Lv1..10 [3, 12, 27, 48, 75, 108, 147, 192, 243, 300]
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
**Buff `SwordMoveBuf`**
- **Modifies normal attacks**: `NormalAttackAction` looks this buff up while it builds the normal-attack damage / hit logic.
- Attached to this skill via `caller2:SwordMove$$AddBuf<-ShadowlessSlashAction$$ActionSkillEvent` (no direct constructor call in the skill's own code).
- Buff hook methods: `CheckDamageInvalid`, `DamageInvalid`, `EndSwordMove`
- `Value` = `((damageInvalid & 1))` _(when BuffEffectActive ne 0)_
- `Value` = `0` _(when BuffEffectActive eq 0)_
- Buff fields set in the constructor (all recovered):
  - `Level` = `257` = 257
  - `BuffEffectActive` = `1` = 1
  - `BufEffectTakeUid` = `-1` = -1
  - `damageInvalid` = `(damageInvalid & 1)`
- Hook `DamageInvalid`: `damageInvalid`=0
- Hook `EndSwordMove`: `damageInvalid`=0

Parameter meanings (inferred from the `SkillBufferId` names):

- `HitRate`: accuracy %
- `Value`: generic value (meaning set by the code that reads the buff)

**Where else this skill takes effect**

- Effect applied in `TenjhoTengeMusouSwordAction$$CheckActive` (11 guarded paths):
  - when `SkillLv(625) ge 1` AND `SkillLv(621) ge 10` AND `(SkillBufferManager.TryGetBuf(?blr, 621, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `1`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.Component$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillActionManager$$get_PlaceSkilList`, `System.Linq.Enumerable$$Any<object>`
  - when `SkillLv(625) ge 1` AND `SkillLv(621) ge 10` AND `(SkillBufferManager.TryGetBuf(?blr, 621, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.Component$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillActionManager$$get_PlaceSkilList`, `System.Linq.Enumerable$$Any<object>`
  - when `SkillLv(625) ge 1` AND `SkillLv(621) ge 10` AND `(SkillBufferManager.TryGetBuf(?blr, 621, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.Component$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `SkillLv(625) ge 1` AND `SkillLv(621) ge 10` AND `(SkillBufferManager.TryGetBuf(?blr, 621, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.Component$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `SkillLv(625) ge 1` AND `SkillLv(621) ge 10` AND `(SkillBufferManager.TryGetBuf(?blr, 621, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.Component$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`, `0x165db84`
  - when `SkillLv(625) ge 1` AND `SkillLv(621) ge 10` AND `(SkillBufferManager.TryGetBuf(?blr, 621, stkp(-40), 0) & 1) eq 0`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.Component$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`
  - when `SkillLv(625) ge 1` AND `SkillLv(621) ge 10`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.Component$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`
  - when `SkillLv(625) ge 1` AND `SkillLv(621) ge 10`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.Component$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`
- Code that reads this skill's level / buff by constant id: `TenjhoTengeMusouSwordAction$$CheckActive (GetSkillLv)`

_Raw recovered data (every method item): [trees/MononofuSkill.md](../trees/MononofuSkill.md) — uid 625_

---

### นุคิอุจิเซ็นโนเซ็น (UnannouncedDestination) · uid 626

<img src="../../icons/sk_626.png" width="40" alt="icon"> 
**Tree:** モノノフスキル (`MononofuSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 240 · **Weapons:** MainKatana · **Requires:** ชูคุจิ · **Client class:** `UnannouncedDestination` (passive mastery)

> เทคนิคการกวัดแกว่งดาบด้วยฝีมือระดับเทพ
> เมื่อไม่ได้โจมตีในระยะเวลาหนึ่ง
> การโจมตีปกติของชูคุจิจะรุนแรงขึ้นเป็นอย่างมาก
> ยิ่งผู้ใช้มี HP เหลือน้อยเท่าไหร่พลังก็จะยิ่งเพิ่มมากขึ้น

**How it works**

- Mastery skill of the モノノフスキル tree (tier 5, max Lv 240); usable with MainKatana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Its effect is applied by client code: `IchijhinnokazeAttackAction$$CheckSetunakenran`, `NormalAttackAction$$ActionPreparation`, `ShukuchiAction$$OnInitialize`, `WaveBladeAction$$ActionPreparation` (formulas in the last section).
- Other client code reads this skill (6 lookups; see the last section).

**Where else this skill takes effect**

- Effect applied in `IchijhinnokazeAttackAction$$CheckSetunakenran` (8 guarded paths):
  - when `SkillLv(626) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 629, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 626, stkp(-24), 0) & 1) ne 0`
    - returns `(UnannouncedDestinationBuf.CheckActive(TryGetBuf.out2(), 0, ?x2, ?x3) & 1)`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.GameObject$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`, `System.Nullable<bool>$$.ctor`, `IchijhinnokazeBuf$$CheckActiveSetsunakenran`, `UnannouncedDestinationBuf$$CheckActive`
  - when `SkillLv(626) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 629, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 626, stkp(-24), 0) & 1) eq 0`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.GameObject$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`, `System.Nullable<bool>$$.ctor`, `IchijhinnokazeBuf$$CheckActiveSetsunakenran`
  - when `SkillLv(626) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 629, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.GameObject$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`, `System.Nullable<bool>$$.ctor`, `IchijhinnokazeBuf$$CheckActiveSetsunakenran`
  - when `SkillLv(626) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 629, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.GameObject$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`, `System.Nullable<bool>$$.ctor`, `0x165db84`, `0x165df00`
  - when `SkillLv(626) ge 1` AND `(SkillBufferManager.TryGetBuf(?blr, 629, stkp(-24), 0) & 1) eq 0`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `UnityEngine.GameObject$$GetComponent<object>`, `interface MobActionManagerBase.get_IsBoss`, `System.Nullable<bool>$$.ctor`
  - when `SkillLv(626) ge 1`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
  - when `SkillLv(626) ge 1`
    - returns `0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
  - when `SkillLv(626) lt 1`
    - returns `0`
- Effect applied in `ShukuchiAction$$OnInitialize` (3 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 626, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `0x165d8dc(this, 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-40), 0, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerAttackBase$$GetWeaponType`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`, `UnannouncedDestination$$CheckMinimumBehavior`, `UnannouncedDestinationBuf$$CheckActive`, `0x165db78`, `SkillLinkedTake$$.ctor`
  - when `(SkillBufferManager.TryGetBuf(?blr, 626, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-40), 0, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - calls `PlayerAttackBase$$GetWeaponType`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`, `UnannouncedDestination$$CheckMinimumBehavior`, `0x165db84`, `0x165df00`
  - when `(SkillBufferManager.TryGetBuf(?blr, 626, stkp(-56), 0) & 1) eq 0`
    - returns `0x165d8dc(this, 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, stkp(-40), 0, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerAttackBase$$GetWeaponType`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`, `UnannouncedDestination$$CheckMinimumBehavior`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- Effect applied in `WaveBladeAction$$ActionPreparation` (7 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 626, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.RemoveSelfBuffer(?blr, 626, 0, ?x3)`
    - set `unannouncedWaveblade` = `1`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - set `SkillIndividualFlag` = `1`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `SkillBufferManager$$RemoveSelfBuffer`
  - when `(SkillBufferManager.TryGetBuf(?blr, 626, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - set `unannouncedWaveblade` = `1`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `0x165db8c`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(?blr, 626, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - set `unannouncedWaveblade` = `1`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `0x165db8c`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(?blr, 626, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - set `unannouncedWaveblade` = `1`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `0x165db8c`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(?blr, 626, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 626, stkp(-40), 0)`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`
  - when `(SkillBufferManager.TryGetBuf(?blr, 626, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(?blr, 626, stkp(-40), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 626, stkp(-40), 0)`
    - calls `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`
- Effect applied in `NormalAttackAction$$ActionPreparation` (300 guarded paths, truncated):
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
- Code that reads this skill's level / buff by constant id: `IchijhinnokazeAttackAction$$CheckSetunakenran (GetSkillLv)`, `IchijhinnokazeAttackAction$$CheckSetunakenran (TryGetBuf)`, `NormalAttackAction$$ActionPreparation (TryGetBuf)`, `ShukuchiAction$$OnInitialize (TryGetBuf)`, `UnannouncedDestination$$CheckMinimumBehavior (GetSkillLv)`, `WaveBladeAction$$ActionPreparation (TryGetBuf)`

_Raw recovered data (every method item): [trees/MononofuSkill.md](../trees/MononofuSkill.md) — uid 626_

---

### ดอนท์เลส (Inflexibility) · uid 627

<img src="../../icons/sk_627.png" width="40" alt="icon"> 
**Tree:** モノノフスキル (`MononofuSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 240 · **Weapons:** MainKatana · **Requires:** ไคริกิรันชิน · **Client class:** `Inflexibility` (passive mastery)

> มีปณิธานอันแน่วแน่ที่จะเผชิญหน้ากับศัตรู
> ดอนท์เลสจะสะสมโดยอัตโนมัติเมื่อต่อสู้กับศัตรูที่แข็งแกร่ง
> จะได้รับผลของบัฟต่างๆ ทุกการนับ 10
> เมื่อศัตรูที่แข็งแกร่งถูกกำจัดการนับจะถูกใช้และจะหมดลงเมื่อเวลาผ่านไป

**How it works**

- Mastery skill of the モノノフスキル tree (tier 5, max Lv 240); usable with MainKatana.
- It installs a buff on the caster.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Buffs:
  - `InflexibilityBuf`: lasts `((?sbfx - lv) + 12)` s
- Its effect is applied by client code: `EquipItemData.WeaponTypeCalculatorBase$$CalcEqAtk`, `HeavenlyStarBuf$$IllusionarySceneReset`, `MobaPlayerSecondaryStatus$$GetMotionSpeed`, `PlayerAttackBase$$CalcCostMp`, `PlayerSecondaryStatus$$GetCalcMotionSpeed`, `SwordMove$$AddBuf` (formulas in the last section).
- Other client code reads this skill (7 lookups; see the last section).

**Buff values** (every recovered field; durations in seconds)

**Buff `InflexibilityBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `CheckHeavenlyStarPowerUp`, `CheckMpHalving`, `CheckSwordMoveBuffer`, `EndCooldown`, `Next`, `NextSkip`, `Prev`, `PrevSkip`, `StartCooldown`
- Duration: `((?sbfx - lv) + 12)` s
- `HitUp` = `hit` _(when BuffEffectActive ne 0)_
- `FirstAttackRate` = `firstAttackRate` _(when BuffEffectActive ne 0)_
- `BaseEqAtk` = `baseEqAtk` _(when BuffEffectActive ne 0)_
- `EqAtk` = `eqAtk` _(when BuffEffectActive ne 0)_
- `MotionSpeed` = `motionSpeed` _(when BuffEffectActive ne 0)_
- Buff fields set in the constructor (all recovered):
  - `interval` = `((?sbfx - lv) + 12)`
  - `cooldownInterval` = `2` = 2
- Hook `Updata`: `LeftTime`=cooldownInterval; `LeftTime`=interval; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
- Hook `PrevSkip`: `Count`=System.Math.Max((Count - System.Math.Min((Count - ((Count // 10) * 10)), count)), 0)
- Hook `StartCooldown`: `Count`=newCount; `isCooldown`=1; `LeftTime`=2
- Hook `EndCooldown`: `isCooldown`=0; `interval`=((?sbfx - Lv) + 12); `LeftTime`=((?sbfx - Lv) + 12)

Parameter meanings (inferred from the `SkillBufferId` names):

- `BaseEqAtk`: base weapon ATK +
- `EqAtk`: weapon ATK +
- `FirstAttackRate`: first-attack multiplier
- `HitUp`: accuracy +
- `MotionSpeed`: motion speed +

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
- Effect applied in `MobaPlayerSecondaryStatus$$GetMotionSpeed` (80 guarded paths):
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) ne 0`
    - returns `(100 - (int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3))))))))) lt 50 ? int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3))))))))) : 50))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) ne 0`
    - returns `(100 - (int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3)))))))) lt 50 ? int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3)))))))) : 50))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) ne 0`
    - returns `(100 - (int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3)))))))) lt 50 ? int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3)))))))) : 50))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) ne 0`
    - returns `(100 - (int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3))))))) lt 50 ? int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3))))))) : 50))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) eq 0`
    - returns `(100 - (int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3)))))))) lt 50 ? int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3)))))))) : 50))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) eq 0`
    - returns `(100 - (int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3))))))) lt 50 ? int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3))))))) : 50))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) eq 0`
    - returns `(100 - (int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3))))))) lt 50 ? int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3))))))) : 50))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) eq 0`
    - returns `(100 - (int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3)))))) lt 50 ? int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3)))))) : 50))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- Effect applied in `PlayerSecondaryStatus$$GetCalcMotionSpeed` (116 guarded paths):
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) ne 0`
    - returns `int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3)))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) ne 0`
    - returns `int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) ne 0`
    - returns `int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) ne 0`
    - returns `int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3)))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) ne 0`
    - returns `int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) ne 0`
    - returns `int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3)))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) eq 0`
    - returns `int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3))))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 627, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-40), 0) & 1) eq 0`
    - returns `int(((max((aspd - 1000), 0) * 0.00555617) + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + (CharacterActionManagerBase.set_DefaultMoveSpeed() + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 104, 0, ?x3)))))))`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusValue`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual CharacterActionManagerBase.get_IsValid`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- Effect applied in `EquipItemData.WeaponTypeCalculatorBase$$CalcEqAtk` (293 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1159, stkp(-80), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 147, stkp(-80), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-80), 0) & 1) ne 0`
    - returns `(((((((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3)) * ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) // 100) + ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) + int((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 8, 0, ?x3) / 100)) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 9, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
    - calls `virtual PlayerStatusBase.get_BonusManager`, `BonusManager$$GetBonusConstant_Rate`, `virtual EquipItemData.WeaponTypeCalculatorBase.calcEqAtkBonus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1159, stkp(-80), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 147, stkp(-80), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-80), 0) & 1) ne 0`
    - returns `(((((((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?mi, ?x3)) * ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?mi, ?x3))) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) // 100) + ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?mi, ?x3))) + int(((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 8, 0, ?x3) / 100)) + (CharacterActionManagerBase.get_Size() / 100)) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 9, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
    - calls `virtual PlayerStatusBase.get_BonusManager`, `BonusManager$$GetBonusConstant_Rate`, `virtual EquipItemData.WeaponTypeCalculatorBase.calcEqAtkBonus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1159, stkp(-80), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 147, stkp(-80), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-80), 0) & 1) ne 0`
    - returns `(((((((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3)) * ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) // 100) + ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) + int((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 8, 0, ?x3) / 100)) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 9, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
    - calls `virtual PlayerStatusBase.get_BonusManager`, `BonusManager$$GetBonusConstant_Rate`, `virtual EquipItemData.WeaponTypeCalculatorBase.calcEqAtkBonus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1159, stkp(-80), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 147, stkp(-80), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-80), 0) & 1) ne 0`
    - calls `virtual PlayerStatusBase.get_BonusManager`, `BonusManager$$GetBonusConstant_Rate`, `virtual EquipItemData.WeaponTypeCalculatorBase.calcEqAtkBonus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1159, stkp(-80), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 147, stkp(-80), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-80), 0) & 1) ne 0`
    - returns `(((((((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3)) * ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) // 100) + ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) + int((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 8, 0, ?x3) / 100)) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 9, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
    - calls `virtual PlayerStatusBase.get_BonusManager`, `BonusManager$$GetBonusConstant_Rate`, `virtual EquipItemData.WeaponTypeCalculatorBase.calcEqAtkBonus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1159, stkp(-80), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 147, stkp(-80), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-80), 0) & 1) ne 0`
    - returns `(((((((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3)) * ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) // 100) + ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) + int((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 8, 0, ?x3) / 100)) * (((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()) + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 9, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
    - calls `virtual PlayerStatusBase.get_BonusManager`, `BonusManager$$GetBonusConstant_Rate`, `virtual EquipItemData.WeaponTypeCalculatorBase.calcEqAtkBonus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1159, stkp(-80), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 147, stkp(-80), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-80), 0) & 1) ne 0`
    - returns `(((((((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3)) * ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) * ((CharacterActionManagerBase.set_DefaultMoveSpeed() + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) // 100) + ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?x2, ?x3))) + int((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 8, 0, ?x3) / 100)) * ((CharacterActionManagerBase.set_DefaultMoveSpeed() + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 9, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
    - calls `virtual PlayerStatusBase.get_BonusManager`, `BonusManager$$GetBonusConstant_Rate`, `virtual EquipItemData.WeaponTypeCalculatorBase.calcEqAtkBonus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1159, stkp(-80), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 147, stkp(-80), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-80), 0) & 1) ne 0`
    - returns `(((((((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?mi, ?x3)) * ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?mi, ?x3))) * ((CharacterActionManagerBase.set_DefaultMoveSpeed() + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) // 100) + ((InflexibilityBuf.CheckRefineBonus(TryGetBuf.out2(), 0, ?mi, ?x3) & 1) + ItemData.get_Refine(WeaponTypeCalculatorBase.item, 0, ?mi, ?x3))) + int(((((GetBonusConstant_Rate.out4() + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 8, 0, ?x3) / 100)) + (CharacterActionManagerBase.get_Size() / 100)) * ((CharacterActionManagerBase.set_DefaultMoveSpeed() + [WeaponTypeCalculatorBase.item+0x42]) + int(((min((CharacterActionManagerBase.set_DefaultMoveSpeed() + CharacterActionManagerBase.set_DefaultMoveSpeed()), 50) * [WeaponTypeCalculatorBase.item+0x42]) / 100)))) + (SkillBufferManager.GetSkillBufferParam(PlayerStatusBase.get_SkillBufferManager(), 9, 0, ?x3) + GetBonusConstant_Rate.out3()))))`
    - calls `virtual PlayerStatusBase.get_BonusManager`, `BonusManager$$GetBonusConstant_Rate`, `virtual EquipItemData.WeaponTypeCalculatorBase.calcEqAtkBonus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_SkillBufferManager`
- Effect applied in `HeavenlyStarBuf$$IllusionarySceneReset` (5 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType([PlayerStatusBase.get_EquipItemData()+0x18], 0, ?x2, ?x3)`
    - set `Count` = `max((((illusionarySceneParry & 1) + count) + ([TryGetBuf.out2()+0x20] ge 50 ? 0xfffffffe : 0xfffffffd)), 0)`
    - set `LeftTime` = `(EquipItemData.WeaponTypeCalculatorBase.get_WeaponType([PlayerStatusBase.get_EquipItemData()+0x18], 0, ?x2, ?x3) eq 8 ? (((count + (count << 2)) << 1) + 10) : ((count + (count << 2)) << 1))`
    - set `prevSkillId` = `0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType([PlayerStatusBase.get_EquipItemData()+0x18], 0, ?x2, ?x3)`
    - set `Count` = `max((((illusionarySceneParry & 1) + count) + ([TryGetBuf.out2()+0x20] ge 50 ? 0xfffffffe : 0xfffffffd)), 0)`
    - set `prevSkillId` = `0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`, `0x165df00`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-56), 0) & 1) eq 0`
    - returns `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType([PlayerStatusBase.get_EquipItemData()+0x18], 0, ?x2, ?x3)`
    - set `Count` = `max((((illusionarySceneParry & 1) + count) + 0xfffffffd), 0)`
    - set `LeftTime` = `(EquipItemData.WeaponTypeCalculatorBase.get_WeaponType([PlayerStatusBase.get_EquipItemData()+0x18], 0, ?x2, ?x3) eq 8 ? (((count + (count << 2)) << 1) + 10) : ((count + (count << 2)) << 1))`
    - set `prevSkillId` = `0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 627, stkp(-56), 0) & 1) eq 0`
    - returns `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType([PlayerStatusBase.get_EquipItemData()+0x18], 0, ?x2, ?x3)`
    - set `Count` = `max((((illusionarySceneParry & 1) + count) + 0xfffffffd), 0)`
    - set `prevSkillId` = `0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_EquipItemData`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
- Effect applied in `SwordMove$$AddBuf` (3 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 627, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `(EquipItemData.WeaponTypeCalculatorBase.get_WeaponType([?blr+0x18], 0, ?x2, ?x3) eq 8 ? 1 : 0)`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `InflexibilityBuf$$CheckSwordMoveBuffer`, `0x165db78`, `SwordMoveBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
  - when `(SkillBufferManager.TryGetBuf(?blr, 627, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `0x165db84`, `0x165df00`
  - when `(SkillBufferManager.TryGetBuf(?blr, 627, stkp(-56), 0) & 1) eq 0`
    - returns `(EquipItemData.WeaponTypeCalculatorBase.get_WeaponType([?blr+0x18], 0, ?x2, ?x3) eq 8 ? 1 : 0)`
    - calls `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `0x165db78`, `SwordMoveBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`
- Code that reads this skill's level / buff by constant id: `EquipItemData.WeaponTypeCalculatorBase$$CalcEqAtk (TryGetBuf)`, `HeavenlyStarBuf$$IllusionarySceneReset (TryGetBuf)`, `Inflexibility$$CheckAdd (ContainsBuffer)`, `MobaPlayerSecondaryStatus$$GetMotionSpeed (TryGetBuf)`, `PlayerAttackBase$$CalcCostMp (TryGetBuf)`, `PlayerSecondaryStatus$$GetCalcMotionSpeed (TryGetBuf)`, `SwordMove$$AddBuf (TryGetBuf)`

_Raw recovered data (every method item): [trees/MononofuSkill.md](../trees/MononofuSkill.md) — uid 627_

---

### ลมกระโชกแรง (IchijhinnokazeAratame) · uid 631

<img src="../../icons/sk_631.png" width="40" alt="icon"> 
**Tree:** モノノフスキル (`MononofuSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 240 · **Weapons:** Katana · **Requires:** ลมกรด · **Client class:** `IchijhinnokazeAratame` (passive mastery)

> พัฒนาฝีมือวิชาดาบสองมือผ่านการฝึกฝนเป็นประจำ
> 
> พลังโจมตีของสกิลลมกระโชกในการโจมตีปกติ (ทั้ง 3 ระดับ)
> และพลังโจมตีของสกิลที่เปลี่ยนแปลงทั้งหมดจะเพิ่มขึ้น

**How it works**

- Mastery skill of the モノノフスキル tree (tier 5, max Lv 240); usable with Katana.
- It installs a buff on the caster.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- `NormalAttackAction` looks its buff up and changes how normal attacks run while it is active.
- Its buff raises normal-attack damage (`NormalAttackRate` / `NormalAttackConstantDamage`).
- Buffs:
  - `ShukuchiBuf`; Lv1 → Lv10: NormalAttackRate (normal-attack damage multiplier (%)) 400 → 400, NormalAttackRate (normal-attack damage multiplier (%)) 5 → 50, Value (generic value (meaning set by the code that reads the buff)) 0 → 50
- Its effect is applied by client code: `IchijhinnokazeAratame$$InvokeShukuchi` (formulas in the last section).
- Other client code reads this skill (1 lookup; see the last section).

**Buff values** (every recovered field; durations in seconds)

**Buff `ShukuchiBuf`**
- **Modifies normal attacks**: `NormalAttackAction` looks this buff up while it builds the normal-attack damage / hit logic.
- **Boosts normal-attack damage** through the `NormalAttackRate` / `NormalAttackConstantDamage` parameters.
- Attached to this skill via `caller:IchijhinnokazeAratame$$InvokeShukuchi` (no direct constructor call in the skill's own code).
- Buff hook methods: `InvalidUnannouncedDestination`, `ValidUnannouncedDestination`

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| NormalAttackRate | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 |
| NormalAttackRate | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |
| Value | 0 | 2 | 4 | 8 | 12 | 18 | 24 | 32 | 40 | 50 |

- Buff fields set in the constructor (all recovered):
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
  - `BufEffectTakeUid` = `-1` = -1
- Hook `ValidUnannouncedDestination`: `unannouncedDestination`=1
- Hook `InvalidUnannouncedDestination`: `unannouncedDestination`=0

Parameter meanings (inferred from the `SkillBufferId` names):

- `NormalAttackRate`: normal-attack damage multiplier (%)
- `Value`: generic value (meaning set by the code that reads the buff)

**Where else this skill takes effect**

- Effect applied in `IchijhinnokazeAratame$$InvokeShukuchi` (6 guarded paths):
  - when `SkillLv(631) ge 5` AND `nowAttackMode ne 2` AND `((nowAttackMode eq 1 ? 1 : 0) & (SkillLv(631) gt 9 ? 1 : 0)) ne 0` AND `SkillLv(619) ge 1`
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `0x165db78`
  - when `SkillLv(631) ge 5` AND `nowAttackMode ne 2` AND `((nowAttackMode eq 1 ? 1 : 0) & (SkillLv(631) gt 9 ? 1 : 0)) ne 0` AND `SkillLv(619) lt 1`
    - returns `0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`
  - when `SkillLv(631) ge 5` AND `nowAttackMode ne 2` AND `((nowAttackMode eq 1 ? 1 : 0) & (SkillLv(631) gt 9 ? 1 : 0)) eq 0`
    - returns `0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_SkillManager`
  - when `SkillLv(631) ge 5` AND `nowAttackMode eq 2` AND `SkillLv(619) ge 1`
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`, `0x165db78`
  - when `SkillLv(631) ge 5` AND `nowAttackMode eq 2` AND `SkillLv(619) lt 1`
    - returns `0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillManager`
  - when `SkillLv(631) lt 5`
    - returns `0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_AbnormalStatusManager`, `AbnormalStateManager$$Contains`, `virtual PlayerStatusBase.get_SkillManager`
- Code that reads this skill's level / buff by constant id: `IchijhinnokazeAratame$$InvokeShukuchi (GetSkillLv)`

_Raw recovered data (every method item): [trees/MononofuSkill.md](../trees/MononofuSkill.md) — uid 631_

---
