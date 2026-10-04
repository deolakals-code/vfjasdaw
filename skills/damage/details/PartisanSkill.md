# パルチザンスキル (`PartisanSkill`) — skill details

9 entries.

### Lบูมเมอแรง / เลเพจบูมเมอแรง (L_Boomerang) · uid 673

<img src="../../icons/sk_673.png" width="40" alt="icon"> 
**Tree:** パルチザンスキル (`PartisanSkill`, tier 1) · **Type:** Object · **Max Lv:** 1 · **Weapons:** TwoHandSword · **Flags:** NoMarketSearch · **Client class:** `L_BoomerangAction`

> ขว้างดาบบูมเมอแรงของเลเพจ
> โจมตีเฉพาะเป้าหมายเท่านั้น
> เมื่อไปถึงระยะหนึ่งจะย้อนกลับมา
> และมีโอกาสโจมตีเป้าหมายอีกครั้ง
> สกิลนี้จะไม่สร้างความเสียหายหากไม่มีบูมเมอแรง

**How it works**

- Object skill of the パルチザンスキル tree (tier 1, max Lv 1); usable with TwoHandSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- It places an object in the world (trap, summon or field object).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) ge 1]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) lt 1]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) ge 1]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) lt 1]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage`: flat damage +200
- Proration: normal-attack proration slot, mode `first_hit_per_target`.
- Buffs:
  - `BoomerangBuf`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (6 lookups; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(10)`
- **Effect radius (Unity units)** (`Radius`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance(1)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 8 set
- `ActionPreparation` — before the cast starts: 1 set, 1 call
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `CheckRangeHit` — range-hit test: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 4 tpl, 1 info
- `ActionSkillEvent` — on an animation/skill event during the motion: 2 set
- `.<>c__DisplayClass26_0::<ActionPreparation>b__0` — skill-specific method: 1 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)) + 200)) / 100)` — SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) ge 1
- SkillRate × `(((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)) + 200)) / 100)` — SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) lt 1
- SkillRate × `(((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)) + 200)) / 100)` — SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) ge 1
- SkillRate × `(((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)) + 200)) / 100)` — SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) lt 1

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)) + 200)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(200)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefNormal / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(targetExpList[mobAction] / 100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Normal`, mode `first_hit_per_target`, attack type `SkillNormal`, action id 673
- Uses the normal-attack proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `ActionPreparation` (before the cast starts): removes a target's buff of skill 673 (L_Boomerang) — `RemoveBuffer(673)`
  - when `!PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(673)`
- `.<>c__DisplayClass26_0::<ActionPreparation>b__0` (method): adds the caster's buff of skill 673 (L_Boomerang) — `AddSelfBuffer(673, 0, 0)`

**Other recovered parameters**

- **Effect radius (Unity units)** (`Radius`): `MathUtil.DisplayMeterToDistance(1)`

**Buff values** (every recovered field; durations in seconds)

**Buff `BoomerangBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).

**Where else this skill takes effect**

- Effect applied in `L_Boomerang2Action$$ActionPreparation` (2 guarded paths):
  - always
    - set `SkillIndividualFlag` = `1`
    - calls `0x165db78`, `System.Object$$.ctor`, `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `SkillBufferManager$$RemoveBuffer`, `0x165db78`, `System.Action<bool>$$.ctor`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 673, 0, ?x3)`
    - calls `0x165db78`, `System.Object$$.ctor`, `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`
- Effect applied in `L_Boomerang2Action$$OnInitialize` (2 guarded paths):
  - when `SkillLv(673) ge 1`
    - set `ActionRange` = `-1`
    - set `Radius` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `skillRate` = `((((((SkillLv(673) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200) + (SkillLv(675) gt 0 ? ((SkillLv(675) * 25) + 200) : 0)) lt 0 ? (((((SkillManager.GetSk`
    - set `fixAddDamage` = `100`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - calls `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
  - when `SkillLv(673) lt 1`
    - set `ActionRange` = `-1`
    - set `Radius` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `skillRate` = `(((([?blr+0x24] + ((Lv * 25) + 200)) + (SkillLv(675) gt 0 ? ((SkillLv(675) * 25) + 200) : 0)) lt 0 ? ((([?blr+0x24] + ((Lv * 25) + 200)) + (SkillLv(675) gt`
    - set `fixAddDamage` = `100`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - calls `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
- Effect applied in `L_Boomerang3Action$$ActionPreparation` (2 guarded paths):
  - always
    - set `isMpHeal` = `1`
    - set `isPlace` = `1`
    - set `SkillIndividualFlag` = `1`
    - calls `0x165db78`, `System.Object$$.ctor`, `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `SkillBufferManager$$RemoveBuffer`, `0x165db78`, `System.Action<bool>$$.ctor`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 673, 0, ?x3)`
    - set `isMpHeal` = `0`
    - set `isPlace` = `0`
    - calls `0x165db78`, `System.Object$$.ctor`, `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`
- Effect applied in `L_BoomerangAction$$ActionPreparation` (2 guarded paths):
  - always
    - set `SkillIndividualFlag` = `1`
    - calls `0x165db78`, `System.Object$$.ctor`, `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `SkillBufferManager$$RemoveBuffer`, `0x165db78`, `System.Action<bool>$$.ctor`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 673, 0, ?x3)`
    - calls `0x165db78`, `System.Object$$.ctor`, `PlayerAttackBase$$ActionPreparation`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`
- Effect applied in `L_Boomerang3Action$$OnInitialize` (4 guarded paths):
  - when `SkillLv(673) ge 1` AND `SkillLv(674) ge 1`
    - set `moveDist` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `skillRate` = `(((SkillLv(674) * 25) + (((SkillLv(673) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200)) + 200)`
    - set `fixAddDamage` = `400`
    - set `critical` = `(Lv * 10)`
    - set `physicalResist` = `(Lv * 5)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
  - when `SkillLv(673) ge 1` AND `SkillLv(674) lt 1`
    - set `moveDist` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `skillRate` = `(((SkillLv(673) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200)`
    - set `fixAddDamage` = `400`
    - set `critical` = `(Lv * 10)`
    - set `physicalResist` = `(Lv * 5)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
  - when `SkillLv(673) lt 1` AND `SkillLv(674) ge 1`
    - set `moveDist` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `skillRate` = `(((SkillLv(674) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200)`
    - set `fixAddDamage` = `400`
    - set `critical` = `(Lv * 10)`
    - set `physicalResist` = `(Lv * 5)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
  - when `SkillLv(673) lt 1` AND `SkillLv(674) lt 1`
    - set `moveDist` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `skillRate` = `([?blr+0x24] + ((Lv * 25) + 200))`
    - set `fixAddDamage` = `400`
    - set `critical` = `(Lv * 10)`
    - set `physicalResist` = `(Lv * 5)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
- Code that reads this skill's level / buff by constant id: `L_Boomerang2Action$$ActionPreparation (ContainsBuffer)`, `L_Boomerang2Action$$OnInitialize (GetSkillLv)`, `L_Boomerang3Action$$ActionPreparation (ContainsBuffer)`, `L_Boomerang3Action$$OnInitialize (GetSkillLv)`, `L_BoomerangAction$$ActionPreparation (ContainsBuffer)`, `SkillBufferManager$$UpdateBoomerangBuf (GetSkillLv)`

_Raw recovered data (every method item): [trees/PartisanSkill.md](../trees/PartisanSkill.md) — uid 673_

---

### ฮีลลิ่งช็อต (HealingShot) · uid 677

<img src="../../icons/sk_677.png" width="40" alt="icon"> 
**Tree:** パルチザンスキル (`PartisanSkill`, tier 1) · **Type:** Special · **Max Lv:** 1 · **Weapons:** Bow, Bowgun · **Flags:** NoMarketSearch · **Client class:** `HealingShotAction`

> ใช้ HP ของตัวเอง (ขั้นต่ำ 100)
> เพื่อยิงลูกธนูฟื้นฟูตรงไปยัง
> สมาชิกปาร์ตี้ที่อยู่ไกลที่สุดปริมาณการฟื้นฟูจะแตกต่างกันไปสำหรับ
> ทหารรับจ้าง, พาร์ทเนอร์และสัตว์เลี้ยง

**How it works**

- Special skill of the パルチザンスキル tree (tier 1, max Lv 1); usable with Bow, Bowgun.
- It installs a buff on the caster.
- Buffs:
  - `SoulHuntBuf`: marker buff (no parameters; other code tests whether it is present)
  - `HealingShotBuf`: lasts `time` s
  - `CountBufferBase`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionStart` — when the cast starts: 8 set
- `ActionStartOthers` — skill-specific method: 5 set
- `ActionHit` — when the attack connects: 1 call
- `CheckPayHp` — skill-specific method: 2 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 677
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): adds the caster's buff of skill 677 (HealingShot) — `AddSelfBuffer(677, Lv, (EquipItemData.WeaponTypeCalculatorBase.get_WeaponType(PlayerStatusBase.get_EquipItemData().mainWeaponCalculator) eq 12 ? 10 : 5))`
  - when `UnityEngine.Object.op_Inequality(actarAction)`
- `CheckPayHp` (method): constructs `SoulHuntBuf` — `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1))`
  - when `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND consumptionHp ge 1 AND consumptionHp lt (PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp)`
- `CheckPayHp` (method): adds the caster's buff of `new SoulHuntBuf` — `AddSelfBuffer(new SoulHuntBuf, 0)`
  - when `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND consumptionHp ge 1 AND consumptionHp lt (PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp)`

**Other recovered parameters**

- **HP consumed** (`consumptionHp`): `(int(((status.MaxHp * (25 - (Lv << 1))) / 100)) gt 100 ? int(((status.MaxHp * (25 - (Lv << 1))) / 100)) : 100)`

**Buff values** (every recovered field; durations in seconds)

**Buff `SoulHuntBuf`**
**Buff `HealingShotBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `time` s
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:SoulHuntBuf$$.ctor<-HealingShotAction$$CheckPayHp` (no direct constructor call in the skill's own code).
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

_Raw recovered data (every method item): [trees/PartisanSkill.md](../trees/PartisanSkill.md) — uid 677_

---

### ค้ำจุนแนวหน้า (MaintainingTheFront) · uid 680

<img src="../../icons/sk_680.png" width="40" alt="icon"> 
**Tree:** パルチザンスキル (`PartisanSkill`, tier 1) · **Type:** Buffer · **Max Lv:** 1 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** NoMarketSearch · **Client class:** `MaintainingTheFrontAction`

> ความมุ่งมั่นที่ตั้งใจจะไม่ถอยกลับ
> เพิ่มเฮทให้กับตัวเองและ
> ปริมาณเฮทจะเพิ่มขึ้นอีก 60 วินาที
> จะได้รับบาเรียอาวุธเพิ่มตาม
> จำนวนสมาชิกที่ไม่ใช่เป้าหมาย

**How it works**

- Buffer skill of the パルチザンスキル tree (tier 1, max Lv 1); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- Buffs:
  - `MaintainingTheFrontBuf`; Lv1 → Lv10: HateRate (aggro (hate) generation %) 2 → 20
- Other client code reads this skill (6 lookups; see the last section).

**When each part runs**

- `InitializeOthers` — setup used when another player's client replays the action: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 680
- No proration slot: ExpType None: no proration slot.

**Buff values** (every recovered field; durations in seconds)

**Buff `MaintainingTheFrontBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- `Value` = `(((noTargetMemberNum * 100) * Lv))` _(when BuffEffectActive ne 0)_
- `Percent` = `(((noTargetMemberNum * 100) * SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 681, 1)))` _(when BuffEffectActive ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| HateRate | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |

- Buff fields set in the constructor (all recovered):
  - `playerStatus` = `status`
  - `physicalBarrier` = `((noTargetMemberNum * 100) * Lv)`
  - `magicBarrier` = `((noTargetMemberNum * 100) * SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 681, 1))`
  - `hateRate` = `(Lv << 1)` = 2
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

Parameter meanings (inferred from the `SkillBufferId` names):

- `HateRate`: aggro (hate) generation %
- `Percent`: generic percent
- `Value`: generic value (meaning set by the code that reads the buff)

**Where else this skill takes effect**

- Effect applied in `PlayerSecondaryStatus$$GetDisplayBonusCalcHate` (295 guarded paths, truncated):
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
- Effect applied in `EquipMagicBarrierBuf$$CheckTakeOver` (5 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0`
    - returns `((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 52, 0, ?x3) + SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)) gt 0 ? 1 : 0)`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) eq 0`
    - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) gt 0 ? 1 : 0)`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 52, 0, ?x3) gt 0 ? 1 : 0)`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) eq 0`
    - returns `0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- Effect applied in `EquipMagicBarrierBuf$$GetBarrierValue` (5 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0`
    - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 52, 0, ?x3) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + Value))`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) eq 0`
    - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + Value)`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 52, 0, ?x3) + Value)`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) eq 0`
    - returns `Value`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- Effect applied in `EquipPhysicalBarrierBuf$$CheckTakeOver` (5 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0`
    - returns `((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3)) gt 0 ? 1 : 0)`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) eq 0`
    - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) gt 0 ? 1 : 0)`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) gt 0 ? 1 : 0)`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) eq 0`
    - returns `0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- Effect applied in `EquipPhysicalBarrierBuf$$GetBarrierValue` (5 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0`
    - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + (SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + Value))`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) eq 0`
    - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + Value)`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `(SkillBufferDataBase.GetParam(TryGetBuf.out2(), 50, 0, ?x3) + Value)`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1098, stkp(-24), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 680, stkp(-24), 0) & 1) eq 0`
    - returns `Value`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- Effect applied in `PlayerBattleManager$$StartRangeHateAttack` (2 guarded paths):
  - when `SkillLv(680) ge 1`
    - returns `1`
    - calls `SkillFactory$$CreateSkill`, `SkillActionBase$$Initialize`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.Component$$get_gameObject`, `PlayerSkillActionManager$$PlaceEffectPlay`
  - when `SkillLv(680) lt 1`
    - returns `0`
    - calls `SkillFactory$$CreateSkill`
- Code that reads this skill's level / buff by constant id: `EquipMagicBarrierBuf$$CheckTakeOver (TryGetBuf)`, `EquipMagicBarrierBuf$$GetBarrierValue (TryGetBuf)`, `EquipPhysicalBarrierBuf$$CheckTakeOver (TryGetBuf)`, `EquipPhysicalBarrierBuf$$GetBarrierValue (TryGetBuf)`, `PlayerBattleManager$$StartRangeHateAttack (GetSkillLv)`, `PlayerSecondaryStatus$$GetDisplayBonusCalcHate (TryGetBuf)`

_Raw recovered data (every method item): [trees/PartisanSkill.md](../trees/PartisanSkill.md) — uid 680_

---

### LบูมเมอแรงII / เลเพจบูมเมอแรงII (L_Boomerang2) · uid 674

<img src="../../icons/sk_674.png" width="40" alt="icon"> 
**Tree:** パルチザンスキル (`PartisanSkill`, tier 2) · **Type:** Object · **Max Lv:** 160 · **Weapons:** TwoHandSword · **Requires:** [N]Lบูมเมอแรง[N2]เลเพจบูมเมอแรง[N] · **Flags:** NoMarketSearch · **Client class:** `L_Boomerang2Action`

> ขว้างบูมเมอแรงขณะถอยหลังได้
> แต่พลังจะลดน้อยลง
> ถ้าไม่มีบูมเมอแรงจะทำได้แค่ถอยหลังเท่านั้น

**How it works**

- Object skill of the パルチザンスキル tree (tier 2, max Lv 160); usable with TwoHandSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- It places an object in the world (trap, summon or field object).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) ge 1]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) lt 1]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage`: flat damage +100
- Proration: normal-attack proration slot, mode `first_hit_per_target`.
- Other client code reads this skill (2 lookups; see the last section).

**Cost, timing and range**

- **Effect radius (Unity units)** (`Radius`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance(1)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 6 set
- `ActionPreparation` — before the cast starts: 1 set, 1 call
- `ActionStart` — when the cast starts: 1 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `CheckRangeHit` — range-hit test: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 4 tpl, 1 info
- `ActionSkillEvent` — on an animation/skill event during the motion: 2 set
- `.<>c__DisplayClass28_0::<ActionPreparation>b__0` — skill-specific method: 1 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((((((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) gt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + 200) : 0)) lt 0 ? (((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) gt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + 200) : 0)) + 1) : ((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) gt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + 200) : 0))) >> 1)) / 100)` — SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) ge 1
- SkillRate × `((((((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) gt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + 200) : 0)) lt 0 ? (((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) gt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + 200) : 0)) + 1) : ((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) gt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + 200) : 0))) >> 1)) / 100)` — SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) lt 1

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) gt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + 200) : 0)) lt 0 ? (((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) gt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + 200) : 0)) + 1) : ((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) gt 0 ? ((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 675, 1) * 25) + 200) : 0))) >> 1)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefNormal / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(targetExpList[mobAction] / 100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Normal`, mode `first_hit_per_target`, attack type `SkillNormal`, action id 674
- Uses the normal-attack proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `int((UnityEngine.Quaternion.Internal_MakePositive(0).y * 100))`
  - when `!PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND isPlace ne 0 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND isPlace eq 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 AND isPlace ne 0`

**Buffs and effects it installs or removes**

- `ActionPreparation` (before the cast starts): removes a target's buff of skill 673 (L_Boomerang) — `RemoveBuffer(673)`
  - when `!PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(673)`
- `.<>c__DisplayClass28_0::<ActionPreparation>b__0` (method): adds the caster's buff of skill 673 (L_Boomerang) — `AddSelfBuffer(673, 0, 0)`

**Other recovered parameters**

- **Effect radius (Unity units)** (`Radius`): `MathUtil.DisplayMeterToDistance(1)`
- **Loop / hit-repeat count** (`LoopParam`): `int((UnityEngine.Quaternion.Internal_MakePositive(0).y * 100))` _(when !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND isPlace ne 0 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND isPlace eq 0 OR !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction.battleManager.mainTargetData.Target) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).z - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).x - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(actarAction.battleManager.mainTargetData.Target)).y - UnityEngine.Transform.get_position(UnityEngine.Component.get_transform(actarAction)).y))))) gt 1e-05 AND isPlace ne 0)_

**Where else this skill takes effect**

- Effect applied in `L_Boomerang3Action$$OnInitialize` (4 guarded paths):
  - when `SkillLv(673) ge 1` AND `SkillLv(674) ge 1`
    - set `moveDist` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `skillRate` = `(((SkillLv(674) * 25) + (((SkillLv(673) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200)) + 200)`
    - set `fixAddDamage` = `400`
    - set `critical` = `(Lv * 10)`
    - set `physicalResist` = `(Lv * 5)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
  - when `SkillLv(673) ge 1` AND `SkillLv(674) lt 1`
    - set `moveDist` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `skillRate` = `(((SkillLv(673) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200)`
    - set `fixAddDamage` = `400`
    - set `critical` = `(Lv * 10)`
    - set `physicalResist` = `(Lv * 5)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
  - when `SkillLv(673) lt 1` AND `SkillLv(674) ge 1`
    - set `moveDist` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `skillRate` = `(((SkillLv(674) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200)`
    - set `fixAddDamage` = `400`
    - set `critical` = `(Lv * 10)`
    - set `physicalResist` = `(Lv * 5)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
  - when `SkillLv(673) lt 1` AND `SkillLv(674) lt 1`
    - set `moveDist` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `skillRate` = `([?blr+0x24] + ((Lv * 25) + 200))`
    - set `fixAddDamage` = `400`
    - set `critical` = `(Lv * 10)`
    - set `physicalResist` = `(Lv * 5)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
- Effect applied in `L_BoomerangAction$$OnInitialize` (4 guarded paths):
  - when `SkillLv(674) ge 1` AND `SkillLv(675) ge 1`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `skillRate` = `(((SkillLv(675) * 25) + (((SkillLv(674) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200)) + 200)`
    - set `fixAddDamage` = `200`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
  - when `SkillLv(674) ge 1` AND `SkillLv(675) lt 1`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `skillRate` = `(((SkillLv(674) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200)`
    - set `fixAddDamage` = `200`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
  - when `SkillLv(674) lt 1` AND `SkillLv(675) ge 1`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `skillRate` = `(((SkillLv(675) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200)`
    - set `fixAddDamage` = `200`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
  - when `SkillLv(674) lt 1` AND `SkillLv(675) lt 1`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `skillRate` = `([?blr+0x24] + ((Lv * 25) + 200))`
    - set `fixAddDamage` = `200`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
- Code that reads this skill's level / buff by constant id: `L_Boomerang3Action$$OnInitialize (GetSkillLv)`, `L_BoomerangAction$$OnInitialize (GetSkillLv)`

_Raw recovered data (every method item): [trees/PartisanSkill.md](../trees/PartisanSkill.md) — uid 674_

---

### ลับคมลูกศร (ArrowSharpening) · uid 678

<img src="../../icons/sk_678.png" width="40" alt="icon"> 
**Tree:** パルチザンスキル (`PartisanSkill`, tier 2) · **Type:** Buffer · **Max Lv:** 160 · **Weapons:** Bow, Bowgun · **Requires:** ฮีลลิ่งช็อต · **Flags:** NoMarketSearch · **Client class:** `ArrowSharpeningAction`

> อัพเกรดการโจมตีปกติครั้งถัดไป
> 
> STR เพิ่มอาวุธเจาะเข้า
> AGI เพิ่มความเร็วการเคลื่อนที่
> DEX เพิ่มคริติคอลฮิต

**How it works**

- Buffer skill of the パルチザンスキル tree (tier 2, max Lv 160); usable with Bow, Bowgun.
- It installs a buff on the caster.
- Buffs:
  - `ArrowSharpeningBuf`
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (6 lookups; see the last section).

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 1 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 2 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 678
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `ArrowSharpeningBuf` — `.ctor(Lv, PlayerActionManagerBase.get_PlayerStatus())`
  - when `UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): adds the caster's buff of `new ArrowSharpeningBuf` — `AddSelfBuffer(new ArrowSharpeningBuf, Id)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Buff values** (every recovered field; durations in seconds)

**Buff `ArrowSharpeningBuf`**
- `PowerResistBreaker` = `(int(((baseSTR / 50) * Lv)) gt Lv ? int(((baseSTR / 50) * Lv)) : Lv)` _(when BuffEffectActive ne 0)_
- `CrtDamageUpRate` = `(int(((baseDEX / 25) * Lv)) gt Lv ? int(((baseDEX / 25) * Lv)) : Lv)` _(when BuffEffectActive ne 0)_
- `CrtUpRate` = `(int(((baseDEX / 10) * Lv)) gt Lv ? int(((baseDEX / 10) * Lv)) : Lv)` _(when BuffEffectActive ne 0)_
- `MotionSpeed` = `(int(((baseAGI / 100) * Lv)) gt Lv ? int(((baseAGI / 100) * Lv)) : Lv)` _(when BuffEffectActive ne 0)_
- Buff fields set in the constructor (all recovered):
  - `playerStatus` = `status`
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:ArrowSharpeningBuf$$.ctor<-ArrowSharpeningAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

Parameter meanings (inferred from the `SkillBufferId` names):

- `CrtDamageUpRate`: critical damage %
- `CrtUpRate`: critical rate %
- `MotionSpeed`: motion speed +
- `PowerResistBreaker`: physical pierce

**Where else this skill takes effect**

- Effect applied in `MobaPlayerSecondaryStatus$$get_CriticalDmg` (34 guarded paths):
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
- Effect applied in `PlayerSecondaryStatus$$CalcCriticalDmg` (34 guarded paths):
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
- Effect applied in `MobaPlayerSecondaryStatus$$GetMotionSpeed` (76 guarded paths):
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
- Effect applied in `PlayerSecondaryStatus$$GetCalcMotionSpeed` (112 guarded paths):
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
- Effect applied in `PlayerSecondaryStatus$$GetCrtRate` (80 guarded paths):
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) ne 0`
    - returns `CharacterActionManagerBase.set_DefaultMoveSpeed()`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0)`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `CharacterActionManagerBase.set_DefaultMoveSpeed()`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0)`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) ne 0`
    - returns `CharacterActionManagerBase.set_DefaultMoveSpeed()`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0)`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `CharacterActionManagerBase.set_DefaultMoveSpeed()`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
- Effect applied in `MobaPlayerSecondaryStatus$$GetCrtRate` (80 guarded paths):
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) ne 0`
    - returns `CharacterActionManagerBase.set_DefaultMoveSpeed()`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0)`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `CharacterActionManagerBase.set_DefaultMoveSpeed()`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0)`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) ne 0`
    - returns `CharacterActionManagerBase.set_DefaultMoveSpeed()`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0)`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
  - when `TryGetValue.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 712, stkp(-48), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 678, stkp(-48), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `CharacterActionManagerBase.set_DefaultMoveSpeed()`
    - calls `virtual CharacterActionManagerBase.get_MoveSpeed`, `BonusManager$$GetBonusPercentValue`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_SubWeapon`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Weapon`
- Code that reads this skill's level / buff by constant id: `MobaPlayerSecondaryStatus$$GetCrtRate (TryGetBuf)`, `MobaPlayerSecondaryStatus$$GetMotionSpeed (TryGetBuf)`, `MobaPlayerSecondaryStatus$$get_CriticalDmg (TryGetBuf)`, `PlayerSecondaryStatus$$CalcCriticalDmg (TryGetBuf)`, `PlayerSecondaryStatus$$GetCalcMotionSpeed (TryGetBuf)`, `PlayerSecondaryStatus$$GetCrtRate (TryGetBuf)`

_Raw recovered data (every method item): [trees/PartisanSkill.md](../trees/PartisanSkill.md) — uid 678_

---

### ค้ำจุนแนวหน้าII (MaintainingTheFront2) · uid 681

<img src="../../icons/sk_681.png" width="40" alt="icon"> 
**Tree:** パルチザンスキル (`PartisanSkill`, tier 2) · **Type:** Mastery · **Max Lv:** 160 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ค้ำจุนแนวหน้า · **Flags:** NoMarketSearch · **Client class:** `MaintainingTheFrontMastery` (passive mastery)

> เมื่อได้รับบาเรียอาวุธด้วยสกิล "ค้ำจุนแนวหน้า"
> จะได้รับบาเรียเวทด้วยและ HP สูงสุด
> จะเพิ่มขึ้นอย่างถาวรเมื่อเรียนรู้สกิล
> มีผลเป็นพาสซีฟ

**How it works**

- Mastery skill of the パルチザンスキル tree (tier 2, max Lv 160); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): MaxHp (max HP) 100 at Lv1 to 1000 at Lv10.
- Its effect is applied by client code: `MaintainingTheFrontBuf$$.ctor` (formulas in the last section).
- Other client code reads this skill (1 lookup; see the last section).

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MaxHp | 100 | 200 | 300 | 400 | 500 | 600 | 700 | 800 | 900 | 1000 |


Bonus meanings (inferred from the names):

- `MaxHp`: max HP

**Where else this skill takes effect**

- Effect applied in `MaintainingTheFrontBuf$$.ctor` (1 guarded path):
  - always
    - returns `SkillLv(681)`
    - set `playerStatus` = `status`
    - set `physicalBarrier` = `((noTargetMemberNum * 100) * Lv)`
    - set `magicBarrier` = `((noTargetMemberNum * 100) * SkillLv(681))`
    - set `hateRate` = `(Lv << 1)`
    - calls `SkillBufferDataBase$$.ctor`, `0x165d8dc`, `virtual PlayerStatusBase.get_SkillManager`
- Code that reads this skill's level / buff by constant id: `MaintainingTheFrontBuf$$.ctor (GetSkillLv)`

_Raw recovered data (every method item): [trees/PartisanSkill.md](../trees/PartisanSkill.md) — uid 681_

---

### LบูมเมอแรงIII / เลเพจบูมเมอแรงIII (L_Boomerang3) · uid 675

<img src="../../icons/sk_675.png" width="40" alt="icon"> 
**Tree:** パルチザンスキル (`PartisanSkill`, tier 3) · **Type:** Object · **Max Lv:** 250 · **Weapons:** TwoHandSword · **Requires:** [N]LบูมเมอแรงII[N2]เลเพจบูมเมอแรงII[N] · **Flags:** NoMarketSearch · **Client class:** `L_Boomerang3Action`

> อัตราคริติคอลและอาวุธเจาะเข้าจะเพิ่มขึ้น
> บูมเมอแรงจะไล่ตามเป้าหมายมันจะกลับมา
> หลังจากไปได้ระยะหนึ่งหรือชนกับสิ่งกีดขวาง
> และมีโอกาสที่จะโจมตีเป้าหมายอีกครั้ง
> สกิลนี้จะไม่สร้างความเสียหายหากไม่มีบูมเมอแรง

**How it works**

- Object skill of the パルチザンスキル tree (tier 3, max Lv 250); usable with TwoHandSword.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- It places an object in the world (trap, summon or field object).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) ge 1]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) lt 1]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) ge 1]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) lt 1]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage`: flat damage +400
- Proration: normal-attack proration slot, mode `first_hit_per_target`.
- Other client code reads this skill (2 lookups; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(10)`
- **Effect radius (Unity units)** (`Radius`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance(1)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 11 set
- `ActionPreparation` — before the cast starts: 3 set, 1 call
- `ActionStart` — when the cast starts: 6 set
- `InitializeOthers` — setup used when another player's client replays the action: 3 set
- `ActionStartOthers` — skill-specific method: 6 set
- `ActionSkillReceiveEffect` — skill-specific method: 3 set
- `CheckRangeHit` — range-hit test: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 4 tpl, 1 info
- `ActionSkillEvent` — on an animation/skill event during the motion: 2 set
- `ActionSkillEventIfMoveIndex` — skill-specific method: 10 set
- `.<>c__DisplayClass32_0::<ActionPreparation>b__0` — skill-specific method: 1 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 | 400 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) * 25) + (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)) + 200)) / 100)` — SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) ge 1
- SkillRate × `(((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) * 25) + (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)) + 200)) / 100)` — SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) ge 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) lt 1
- SkillRate × `(((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) * 25) + (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)) + 200)) / 100)` — SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) ge 1
- SkillRate × `(((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) * 25) + (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)) + 200)) / 100)` — SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) lt 1 AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) lt 1

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 674, 1) * 25) + (((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 673, 1) * 25) + (baseDEX + ((Lv * 25) + 200))) + 200)) + 200)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(400)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefNormal / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(targetExpList[mobAction] / 100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Normal`, mode `first_hit_per_target`, attack type `SkillNormal`, action id 675
- Uses the normal-attack proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `ActionPreparation` (before the cast starts): removes a target's buff of skill 673 (L_Boomerang) — `RemoveBuffer(673)`
  - when `!PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND hasBuff(673)`
- `.<>c__DisplayClass32_0::<ActionPreparation>b__0` (method): adds the caster's buff of skill 673 (L_Boomerang) — `AddSelfBuffer(673, 0, 0)`

**Other recovered parameters**

- **Effect radius (Unity units)** (`Radius`): `MathUtil.DisplayMeterToDistance(1)`

**Where else this skill takes effect**

- Effect applied in `L_BoomerangAction$$OnInitialize` (4 guarded paths):
  - when `SkillLv(674) ge 1` AND `SkillLv(675) ge 1`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `skillRate` = `(((SkillLv(675) * 25) + (((SkillLv(674) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200)) + 200)`
    - set `fixAddDamage` = `200`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
  - when `SkillLv(674) ge 1` AND `SkillLv(675) lt 1`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `skillRate` = `(((SkillLv(674) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200)`
    - set `fixAddDamage` = `200`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
  - when `SkillLv(674) lt 1` AND `SkillLv(675) ge 1`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `skillRate` = `(((SkillLv(675) * 25) + ([?blr+0x24] + ((Lv * 25) + 200))) + 200)`
    - set `fixAddDamage` = `200`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
  - when `SkillLv(674) lt 1` AND `SkillLv(675) lt 1`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, actarAction, ?x2, ?x3)`
    - set `Radius` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `skillRate` = `([?blr+0x24] + ((Lv * 25) + 200))`
    - set `fixAddDamage` = `200`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `Element` = `PlayerStatusBase.GetEquipElement(?blr, 0, ?x2, ?x3)`
    - calls `MathUtil$$DisplayMeterToDistance`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerStatusBase$$GetEquipElement`, `PlayerAttackBase$$CalcMp`
- Code that reads this skill's level / buff by constant id: `L_Boomerang2Action$$OnInitialize (GetSkillLv)`, `L_BoomerangAction$$OnInitialize (GetSkillLv)`

_Raw recovered data (every method item): [trees/PartisanSkill.md](../trees/PartisanSkill.md) — uid 675_

---

### Nดราก้อนทูธ / นีโน่ดราก้อนทูธ (N_DragonTooth) · uid 676

<img src="../../icons/sk_676.png" width="40" alt="icon"> 
**Tree:** パルチザンスキル (`PartisanSkill`, tier 3) · **Type:** Attack · **Max Lv:** 250 · **Weapons:** Halberd · **Flags:** NoMarketSearch · **Client class:** `N_DragonToothAction`

> ดราก้อนทูธที่คิดค้นโดยนีโน่
> โจมตีเป้าหมายและเคลื่อนที่ไปข้างหลัง
> เพิ่มพลังเจาะเข้าของสกิลที่ใช้ถัดไปเล็กน้อย
> เพิ่มพลังขึ้นอีกเมื่อเรียนสกิล"ดราก้อนทูธ"

**How it works**

- Attack skill of the パルチザンスキル tree (tier 3, max Lv 250); usable with Halberd.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Damage (`calcFirstDamage` x1, `calcSecondDamage` x1; each template is a full damage roll with its own crit):
  - `calcFirstDamage`: skill multiplier ×0.75 at Lv1 to 7.5 at Lv10
  - `calcSecondDamage`: skill multiplier depends on live values (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Buffs:
  - `N_DragonToothBuf`; Lv1 → Lv10: Value (generic value (meaning set by the code that reads the buff)) 2 → 20

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 6 set
- `InitializeOthers` — setup used when another player's client replays the action: 3 set
- `OtherPlayerAttackStartReceive` — skill-specific method: 1 set
- `ActionStartOthers` — skill-specific method: 2 set
- `ActionStart` — when the cast starts: 8 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set
- `calcFirstDamage` — damage calculation of hit 1: 1 tpl, 1 info
- `calcSecondDamage` — damage calculation of hit 2: 1 tpl, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.75 | 1.5 | 2.25 | 3 | 3.75 | 4.5 | 5.25 | 6 | 6.75 | 7.5 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((max((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 972, 1) * 75), 0) / 100))` — calcSecondDamage

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcFirstDamage` (damage calculation of hit 1): `AddRate[SkillRate]` = `(((Lv * 75) / 100))`
- `calcSecondDamage` (damage calculation of hit 2): `AddRate[SkillRate]` = `((max((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 972, 1) * 75), 0) / 100))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 676
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Other recovered parameters**

- **First-part skill multiplier (%)** (`firstSkillRate`): `((Lv * 75) / 100)` → Lv1..10 [0.75, 1.5, 2.25, 3.0, 3.75, 4.5, 5.25, 6.0, 6.75, 7.5]
- **Second-part multiplier** (`secondSkillRate`): `(max((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 972, 1) * 75), 0) / 100)`
- **MP recovered** (`mpRecovery`): `((max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 972, 1), 0) + (max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 972, 1), 0) << 2)) << 1)`
- **Resistance value** (`resist`): `(Lv * 10)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]

**Buff values** (every recovered field; durations in seconds)

**Buff `N_DragonToothBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- `Value` = `0` _(when BuffEffectActive eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |

- Buff fields set in the constructor (all recovered):
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
  - `BufEffectTakeUid` = `-1` = -1

Parameter meanings (inferred from the `SkillBufferId` names):

- `Value`: generic value (meaning set by the code that reads the buff)

**In-game level notes**

- Lv9: หากใช้สกิลสำเร็จโดยไม่ได้รับความเสียหายจะฟื้นฟู MP เล็กน้อย ปริมาณการฟื้นฟู MP จะเพิ่มขึ้นตามระยะถอยห่างด้วยการกดปุ่ม และขึ้นอยู่กับเลเวลที่เรียนรู้ของสกิลดราก้อนทูธ

_Raw recovered data (every method item): [trees/PartisanSkill.md](../trees/PartisanSkill.md) — uid 676_

---

### สัญชาตญาณการอยู่รอด (SurvivalInstinct) · uid 679

<img src="../../icons/sk_679.png" width="40" alt="icon"> 
**Tree:** パルチザンスキル (`PartisanSkill`, tier 3) · **Type:** Mastery · **Max Lv:** 250 · **Weapons:** Bow, Bowgun · **Requires:** ลับคมลูกศร · **Flags:** NoMarketSearch

> เมื่อสมาชิกปาร์ตี้ตาย HP สูงสุดและ
> อัตราส่วนการลดความเสียหายจะเพิ่มขึ้น
> *ไม่เปิดใช้งานในบางสถานการณ์

**How it works**

- Mastery skill of the パルチザンスキル tree (tier 3, max Lv 250); usable with Bow, Bowgun.
- It installs a buff on the caster.
- Marked as a passive in the skill table (no decoded `GetMasteryParam` class).
- Client status: **consumer-only** — no action class; effect applied in consumer code (see page).
- Buffs:
  - `SurvivalInstinctBuf`: lasts `20` s; Lv1 → Lv10: MaxHpUp (max HP +) 500 → 5000, MaxHpUpRate (max HP %) 1 → 10, RateDamageResist (damage taken multiplier) 2 → 25
- Its effect is applied by client code: `MobAttackBase$$CalcLastDamage` (formulas in the last section).
- Other client code reads this skill (1 lookup; see the last section).

**Buff values** (every recovered field; durations in seconds)

**Buff `SurvivalInstinctBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Duration: `20` s

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MaxHpUp | 500 | 1000 | 1500 | 2000 | 2500 | 3000 | 3500 | 4000 | 4500 | 5000 |
| MaxHpUpRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| RateDamageResist | 2 | 5 | 7 | 10 | 12 | 15 | 17 | 20 | 22 | 25 |

- Buff fields set in the constructor (all recovered):
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

Parameter meanings (inferred from the `SkillBufferId` names):

- `MaxHpUp`: max HP +
- `MaxHpUpRate`: max HP %
- `RateDamageResist`: damage taken multiplier

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

_Raw recovered data (every method item): [trees/PartisanSkill.md](../trees/PartisanSkill.md) — uid 679_

---
