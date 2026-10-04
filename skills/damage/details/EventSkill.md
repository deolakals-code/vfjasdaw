# EventSkill (`EventSkill`) — skill details

3 entries.

### ท่อเหล็ก (IronPipe) · uid 1249

<img src="../../icons/sk_1249.png" width="40" alt="icon"> 
**Type:** Attack · **Max Lv:** 1 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Client class:** `IronPipeAction`

> เอาไว้ใช้ฆ่าซอมบี้ได้
> 
> อัตราคริติคอลสำหรับการโจมตีในบริเวณแคบจะลดลง
> แต่ถ้าติดคริติคอลจะทำให้หวาดกลัว

**How it works**

- Attack; usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on live values (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Flinch (1).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(4)`
- **Effect radius (Unity units)** (`Radius`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance(0.5)`
- **Effect radius (Unity units)** (`Radius`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance(2)`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(2)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 5 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionStart` — when the cast starts: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 tpl, 2 call, 1 info
- `ActionSkillEvent` — on an animation/skill event during the motion: 1 set
- `OnInitializeEventRoom` — skill-specific method: 2 set

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((int((baseSTR / 2.5)) + ((Lv + (Lv << 2)) + 50))) / 100)`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((int((baseSTR / 2.5)) + ((Lv + (Lv << 2)) + 50))) / 100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1249
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Rolls `100`% to inflict **Flinch (1)** (`calcPlayerToMobDamage`)
- Marks the hit with ailment **Flinch (1)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 1, 100, playerAction)`

**Other recovered parameters**

- **Effect radius (Unity units)** (`Radius`): `MathUtil.DisplayMeterToDistance(0.5)`; `MathUtil.DisplayMeterToDistance(2)`

_Raw recovered data (every method item): [trees/EventSkill.md](../trees/EventSkill.md) — uid 1249_

---

### เรโทรโบว์กัน (RetroBowgun) · uid 1250

<img src="../../icons/sk_1250.png" width="40" alt="icon"> 
**Type:** Attack · **Max Lv:** 1 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Client class:** `RetroBowgunAction`

> โบว์กันประดับที่ดูไม่น่ามีอานุภาพ
> 
> ยิ่งโจมตีเป้าหมายไกลออกไปจะทำให้เป็นปรปักษ์
> และผลที่ได้จะยิ่งสูงขึ้น (6mขึ้นไป/9mขึ้นไป)

**How it works**

- Attack; usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on live values (formula below); flat damage +100
- Proration: physical-skill proration slot, mode `first_hit_per_target`.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionStart` — when the cast starts: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 1 info
- `OnInitializeEventRoom` — skill-specific method: 1 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((int((baseDEX / 2.5)) + ((Lv + (Lv << 2)) + 50))) / 100)`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((int((baseDEX / 2.5)) + ((Lv + (Lv << 2)) + 50))) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1250
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

_Raw recovered data (every method item): [trees/EventSkill.md](../trees/EventSkill.md) — uid 1250_

---

### แม็กนั่ม (Magnum) · uid 1251

<img src="../../icons/sk_1251.png" width="40" alt="icon"> 
**Type:** Attack · **Max Lv:** 1 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Client class:** `MagnumAction`

> อาวุธจากต่างโลกที่ได้รับการดัดแปลง
> 
> โจมตีเป้าหมายด้วยการันตีคริติคอล
> แต่มีแรงสะท้อนสูงทำให้แม่นยำได้ยาก
> จำนวนครั้งที่ใช้จะเพิ่มขึ้นเมื่อเวลาต่อสู้ผ่านไป

**How it works**

- Attack; usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on Lv (formula below); flat damage +40 at Lv1 to 400 at Lv10
- Proration: magic proration slot, mode `first_hit_per_target`.
- Buffs:
  - `MagnumBuf`; Lv1 → Lv10: HitRate (accuracy %) -94 → -85
- Other client code reads this skill (3 lookups; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(18)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 3 tpl, 1 info
- `OnInitializeEventRoom` — skill-specific method: 1 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 40 | 80 | 120 | 160 | 200 | 240 | 280 | 320 | 360 | 400 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((status.Lv + (Lv * 100))) / 100)`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((status.Lv + (Lv * 100))) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv + (Lv << 2)) << 3))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(target.ExpDefMagic / 100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Physics`, action id 1251
- Uses the magic proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buff values** (every recovered field; durations in seconds)

**Buff `MagnumBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `ActiveMagnumCount`, `InactiveMagnumCount`, `SetSkillParam`
- `Count` = `(count)`
- `HitRate` = `0` _(when BuffEffectActive eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| HitRate | -94 | -93 | -92 | -91 | -90 | -89 | -88 | -87 | -86 | -85 |

- Buff fields set in the constructor (all recovered):
  - `Count` = `count`
  - `hitRate` = `(95 - lv)` = 94
  - `BuffEffectActive` = `0`
- Hook `Updata`: `intervalTimer`=(20 - Lv); `intervalTimer`=(intervalTimer - UnityEngine.Time.get_deltaTime())
- Hook `ActiveMagnumCount`: `isInterval`=1; `Level`=lv; `intervalTimer`=(20 - lv)
- Hook `InactiveMagnumCount`: `isInterval`=0
- Hook `SetSkillParam`: `Level`=lv; `hitRate`=((((((baseTEC // 3) - baseTEC) >> 1) + (((baseTEC // 3) - baseTEC) >> 31)) - lv) + 95)

Parameter meanings (inferred from the `SkillBufferId` names):

- `Count`: stack / hit counter
- `HitRate`: accuracy %

**Where else this skill takes effect**

- Effect applied in `MagnumAction$$IsFailure` (4 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1251, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1251, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferDataBase$$GetParam`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1251, stkp(-24), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(PlayerStatusBase.get_SkillBufferManager(), 1251, stkp(-24), 0) & 1) eq 0`
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`
- Effect applied in `MagnumAction$$calcPlayerToMobDamage` (7 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 1251, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `?blr`
    - template `AddRate[SkillRate]` = `(skillRate / 100)`
    - template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
    - template `SetRate[ExpRate]` = `(IMobStatusCalculator.get_ExpDefMagic(MobActionManagerBase.get_MobBattleStatus(mobAction)) / 100)`
    - calls `MagnumBuf$$SetSkillParam`, `0x165db78`, `SkillCalcTemplate$$.ctor`, `virtual MagnumAction.get_AttackType`, `PlayerAttackBase$$TemplateAssignment`, `interface MobActionManagerBase.get_MobBattleStatus`, `interface IMobStatusCalculator.get_ExpDefMagic`, `0x165db78`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1251, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `?blr`
    - template `AddRate[SkillRate]` = `(skillRate / 100)`
    - template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
    - template `SetRate[ExpRate]` = `(IMobStatusCalculator.get_ExpDefMagic(MobActionManagerBase.get_MobBattleStatus(mobAction)) / 100)`
    - calls `MagnumBuf$$SetSkillParam`, `0x165db78`, `SkillCalcTemplate$$.ctor`, `virtual MagnumAction.get_AttackType`, `PlayerAttackBase$$TemplateAssignment`, `interface MobActionManagerBase.get_MobBattleStatus`, `interface IMobStatusCalculator.get_ExpDefMagic`, `0x165db78`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1251, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `0x165db84`, `0x165df00`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1251, stkp(-56), 0) & 1) eq 0` AND `TryGetBuf.out2() ne 0`
    - returns `?blr`
    - template `AddRate[SkillRate]` = `(skillRate / 100)`
    - template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
    - template `SetRate[ExpRate]` = `(IMobStatusCalculator.get_ExpDefMagic(MobActionManagerBase.get_MobBattleStatus(mobAction)) / 100)`
    - calls `0x165db78`, `SkillCalcTemplate$$.ctor`, `virtual MagnumAction.get_AttackType`, `PlayerAttackBase$$TemplateAssignment`, `interface MobActionManagerBase.get_MobBattleStatus`, `interface IMobStatusCalculator.get_ExpDefMagic`, `0x165db78`, `SkillActionBase.DamageData$$.ctor`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1251, stkp(-56), 0) & 1) eq 0` AND `TryGetBuf.out2() eq 0`
    - returns `TryGetBuf.out2()`
    - template `AddRate[SkillRate]` = `(skillRate / 100)`
    - template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
    - template `SetRate[ExpRate]` = `(IMobStatusCalculator.get_ExpDefMagic(MobActionManagerBase.get_MobBattleStatus(mobAction)) / 100)`
    - calls `0x165db78`, `SkillCalcTemplate$$.ctor`, `virtual MagnumAction.get_AttackType`, `PlayerAttackBase$$TemplateAssignment`, `interface MobActionManagerBase.get_MobBattleStatus`, `interface IMobStatusCalculator.get_ExpDefMagic`, `0x165db78`, `SkillActionBase.DamageData$$.ctor`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1251, stkp(-56), 0) & 1) eq 0` AND `TryGetBuf.out2() ne 0`
    - returns `?blr`
    - template `AddRate[SkillRate]` = `(skillRate / 100)`
    - template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
    - template `SetRate[ExpRate]` = `(IMobStatusCalculator.get_ExpDefMagic(MobActionManagerBase.get_MobBattleStatus(mobAction)) / 100)`
    - calls `0x165db78`, `SkillCalcTemplate$$.ctor`, `virtual MagnumAction.get_AttackType`, `PlayerAttackBase$$TemplateAssignment`, `interface MobActionManagerBase.get_MobBattleStatus`, `interface IMobStatusCalculator.get_ExpDefMagic`, `0x165db78`, `SkillActionBase.DamageData$$.ctor`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1251, stkp(-56), 0) & 1) eq 0` AND `TryGetBuf.out2() eq 0`
    - returns `TryGetBuf.out2()`
    - template `AddRate[SkillRate]` = `(skillRate / 100)`
    - template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
    - template `SetRate[ExpRate]` = `(IMobStatusCalculator.get_ExpDefMagic(MobActionManagerBase.get_MobBattleStatus(mobAction)) / 100)`
    - calls `0x165db78`, `SkillCalcTemplate$$.ctor`, `virtual MagnumAction.get_AttackType`, `PlayerAttackBase$$TemplateAssignment`, `interface MobActionManagerBase.get_MobBattleStatus`, `interface IMobStatusCalculator.get_ExpDefMagic`, `0x165db78`, `SkillActionBase.DamageData$$.ctor`
- Code that reads this skill's level / buff by constant id: `MagnumAction$$IsFailure (TryGetBuf)`, `MagnumAction$$calcPlayerToMobDamage (TryGetBuf)`, `ReceiveSupportResult$$OnEventPlayerSupport (GetSkillLv)`

_Raw recovered data (every method item): [trees/EventSkill.md](../trees/EventSkill.md) — uid 1251_

---
