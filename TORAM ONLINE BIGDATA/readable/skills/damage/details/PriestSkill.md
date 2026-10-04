# PriestSkill (`PriestSkill`) — skill details

15 entries.

### เบลส (Bless) · uid 833

<img src="../../icons/sk_833.png" width="40" alt="icon"> 
**Type:** Support · **Max Lv:** 15 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `BlessAction`

> ฟื้นฟู HP เล็กน้อยชั่วขณะ
> ปริมาณฟื้นฟูและระยะเวลาจะเพิ่มขึ้นตามเลเวล

**How it works**

- Support; usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It installs a buff on other players / the party.
- Buffs:
  - `BlessBuf`: lasts `time` s
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)

**Cost, timing and range**

- **Cast time** (`CastTime`): `0` = 0

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 2 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 833
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `BlessBuf` — `.ctor(Lv, (count * 5))`
- `ActionHit` (when the attack connects): adds a target's buff of `new BlessBuf` — `AddBuffer(new BlessBuf, 0)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `0` = 0

**Buff values** (every recovered field; durations in seconds)

**Buff `BlessBuf`**
- Duration: `time` s
- Buff fields set in the constructor (all recovered):
  - `isViewSelfIcon` = `0`
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `SetViewSelfIcon`: `isViewSelfIcon`=(flag & 1)
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:BlessBuf$$.ctor<-BlessAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

**In-game level notes**

- Lv14: *INT มีผลต่อปริมาณการฟื้นฟู *ปริมาณ MATK มีผลต่อปริมาณการฟื้นฟู+1%

_Raw recovered data (every method item): [trees/PriestSkill.md](../trees/PriestSkill.md) — uid 833_

---

### โฮลี่ฟิสท์ (HollyFist) · uid 834

<img src="../../icons/sk_834.png" width="40" alt="icon"> 
**Type:** Attack · **Max Lv:** 15 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `HolyFistAction`

> อัดศัตรูด้วยหมัดพลังแสง
> สร้างความเสียหายทางกายภาพและเวทพร้อมกัน
> สกิลนี้เป็น[สกิลกายภาพ]

**How it works**

- Attack; usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- Damage (`calcPlayerToMobDamage` x2; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×0.55 at Lv1 to 1 at Lv10; skill multiplier ×0.55 at Lv1 to 1 at Lv10; skill multiplier depends on live values (formula below); skill multiplier depends on Str (formula below); flat damage +55 at Lv1 to 100 at Lv10
- Proration: physical-skill proration slot, mode `first_hit_per_target`.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(ExistWeaponType.item(actarAction, 16))`
- **ActionRange** (`ActionRange`): `weaponRange`
- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(ExistWeaponType.item(actarAction, 14))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 9 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 4 tpl, 1 call, 1 info
- `OnInheritance` — state carried over when this action follows another: 1 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.55 | 0.6 | 0.65 | 0.7 | 0.75 | 0.8 | 0.85 | 0.9 | 0.95 | 1 |
| SkillRate × | 0.55 | 0.6 | 0.65 | 0.7 | 0.75 | 0.8 | 0.85 | 0.9 | 0.95 | 1 |
| Flat dmg + | 55 | 60 | 65 | 70 | 75 | 80 | 85 | 90 | 95 | 100 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((((Lv + (Lv << 2)) + 50) / 100))`
- SkillRate × `((((((Lv + (Lv << 2)) + 50) + ((Lv + (Lv << 2)) + 50)) + status.Str) / 100))`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv + (Lv << 2)) + 50) / 100))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv + (Lv << 2)) + 50))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `ExtensionMethod.ExSkillData.SkillDataExtentionMethod.GetTargetExpRate(1, PlayerAttackBase.get_ActionID(), MobActionManagerBase.get_MobBattleStatus(mobAction))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((((Lv + (Lv << 2)) + 50) + ((Lv + (Lv << 2)) + 50)) + status.Str) / 100))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 834
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `calcPlayerToMobDamage` (damage calculation against a monster): adds the buff-provided flat damage to the template — `SetBufferConstantDamage(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 2)`

**In-game level notes**

- Lv14: *พลังเวท×2 *พลังเวทจะเพิ่มมากกว่าค่า INT ของตัวเอง
- Lv16: *พลังกายภาพ×2 *พลังกายภาพจะเพิ่มมากกว่าค่า STR ของตัวเอง

_Raw recovered data (every method item): [trees/PriestSkill.md](../trees/PriestSkill.md) — uid 834_

---

### ร็อดสทับ (RodStub) · uid 841

<img src="../../icons/sk_841.png" width="40" alt="icon"> 
**Type:** Attack · **Max Lv:** 15 · **Weapons:** Rod · **Client class:** `RodStubAction`

> ตีอย่างแรงด้วยไม้เท้า
> ยิ่ง STR สูงเท่าไหร่ก็จะยิ่งมองข้ามพลังป้องกันของเป้าหมาย
> มีโอกาสทำให้เป้าหมาย[ผงะ]

**How it works**

- Attack; usable with Rod.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on Str (formula below); flat damage +100
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Flinch (1).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(7)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 7 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 2 call, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((((Lv + 190) + status.Str)) / 100)`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv + 190) + status.Str)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 841
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Rolls `percent`% to inflict **Flinch (1)** (`calcPlayerToMobDamage`)
- Uses the default ailment duration (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 1, percent, playerAction)`

**Other recovered parameters**

- **Effect percent** (`percent`): `(((Lv + (Lv << 2)) + 25) + 25)` → Lv1..10 [55, 60, 65, 70, 75, 80, 85, 90, 95, 100] _(when subWeapon == Shield)_; `((Lv + (Lv << 2)) + 25)` → Lv1..10 [30, 35, 40, 45, 50, 55, 60, 65, 70, 75] _(when subWeapon != Shield)_
- **Resistance value** (`resist`): `((baseSTR // 10) + 25)`

**In-game level notes**

- Lv17: *อัตราติดผงะ+25%

_Raw recovered data (every method item): [trees/PriestSkill.md](../trees/PriestSkill.md) — uid 841_

---

### กลอเรีย (Gloria) · uid 835

<img src="../../icons/sk_835.png" width="40" alt="icon"> 
**Type:** Support · **Max Lv:** 35 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เบลส · **Flags:** MercenaryCanUseSkill · **Client class:** `GloriaAction`

> เพิ่ม DEF/MDEF ในระยะเวลาสั้นๆ
> และเพิ่มการฟื้นฟู  Guard ขณะติดตั้งโล่

**How it works**

- Support; usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It installs a buff on other players / the party.
- Buffs:
  - `GloriaBuf`: lasts `30` s; Lv1 → Lv10: DefRate (DEF %) 51 → 200, MdefRate (MDEF %) 51 → 200
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 2 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 835
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `GloriaBuf` — `.ctor(Lv, guard)`
- `ActionHit` (when the attack connects): adds a target's buff of `new GloriaBuf` — `AddBuffer(new GloriaBuf, 0)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`

**Buff values** (every recovered field; durations in seconds)

**Buff `GloriaBuf`**
- Duration: `30` s
- `GuardRate` = `(guard)` _(when BuffEffectActive ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| DefRate | 51 | 56 | 63 | 74 | 87 | 104 | 123 | 146 | 171 | 200 |
| MdefRate | 51 | 56 | 63 | 74 | 87 | 104 | 123 | 146 | 171 | 200 |

- Buff fields set in the constructor (all recovered):
  - `defUpRate` = `(int(((Lv * Lv) * 1.5)) + 50)` → Lv1..10 [51, 56, 63, 74, 87, 104, 123, 146, 171, 200]
  - `guardUp` = `guard`
  - `isViewSelfIcon` = `0`
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `SetViewSelfIcon`: `isViewSelfIcon`=(flag & 1)
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:GloriaBuf$$.ctor<-GloriaAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

Parameter meanings (inferred from the `SkillBufferId` names):

- `DefRate`: DEF %
- `GuardRate`: guard rate %
- `MdefRate`: MDEF %

**In-game level notes**

- Lv14: *การฟื้นฟู Guard ของผู้ที่ใช้โล่จะได้รับผลจากการเพิ่มขึ้นของสกิลนี้

**Where else this skill takes effect**

- Effect applied in `PetStatus$$get_GuardDelay` (12 guarded paths):
  - when `TryGetValue.out2() ne 0`
    - returns `max((((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 27, 0, ?x3) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + 10)))) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) lt 90 ? ((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 27, 0, ?x3) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + 10)))) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) : 90), 0)`
    - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `ItemData$$get_BattleCustomize`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`
  - when `TryGetValue.out2() ne 0`
    - returns `max((((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + 10))) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) lt 90 ? ((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (CharacterActionManagerBase.get_Size() + (CharacterActionManagerBase.get_Size() + 10))) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) : 90), 0)`
    - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `ItemData$$get_BattleCustomize`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`
  - when `TryGetValue.out2() ne 0`
    - returns `max((((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 27, 0, ?x3) + (CharacterActionManagerBase.get_Size() + 10))) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) lt 90 ? ((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 27, 0, ?x3) + (CharacterActionManagerBase.get_Size() + 10))) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) : 90), 0)`
    - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `ItemData$$get_BattleCustomize`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`
  - when `TryGetValue.out2() ne 0`
    - returns `max((((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (CharacterActionManagerBase.get_Size() + 10)) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) lt 90 ? ((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (CharacterActionManagerBase.get_Size() + 10)) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) : 90), 0)`
    - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `ItemData$$get_BattleCustomize`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`
  - when `TryGetValue.out2() ne 0`
    - returns `max((((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 27, 0, ?x3) + (CharacterActionManagerBase.get_Size() + 10))) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) lt 90 ? ((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 27, 0, ?x3) + (CharacterActionManagerBase.get_Size() + 10))) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) : 90), 0)`
    - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `ItemData$$get_BattleCustomize`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`
  - when `TryGetValue.out2() ne 0`
    - returns `max((((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (CharacterActionManagerBase.get_Size() + 10)) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) lt 90 ? ((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (CharacterActionManagerBase.get_Size() + 10)) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) : 90), 0)`
    - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `ItemData$$get_BattleCustomize`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_Size`
  - always
    - returns `max((((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 27, 0, ?x3) + 10)) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) lt 90 ? ((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + (SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 27, 0, ?x3) + 10)) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) : 90), 0)`
    - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `ItemData$$get_BattleCustomize`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
  - always
    - returns `max((((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + 10) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) lt 90 ? ((SkillBufferManager.GetSkillBufferParam(CharacterActionManagerBase.get_IsValid(), 57, 0, ?x3) + 10) + BonusManager.GetBonusValue(CharacterActionManagerBase.get_MoveSpeed(), 45, 0, ?x3)) : 90), 0)`
    - calls `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `EquipItemData$$get_Body`, `ItemData$$get_BattleCustomize`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`
- Code that reads this skill's level / buff by constant id: `PetStatus$$get_GuardDelay (ContainsBuffer)`

_Raw recovered data (every method item): [trees/PriestSkill.md](../trees/PriestSkill.md) — uid 835_

---

### โฮลี่ไลท์ (HollyLight) · uid 836

<img src="../../icons/sk_836.png" width="40" alt="icon"> 
**Type:** Attack · **Max Lv:** 35 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** โฮลี่ฟิสท์ · **Flags:** MercenaryCanUseSkill · **Client class:** `HolyLightActin`

> ลงทัณฑ์เหล่าร้ายด้วยพลังศักดิ์สิทธิ์
> ใช้เวทธาตุแสงสร้างความเสียหายกับเป้าหมาย
> และฟื้นฟู HP ของตัวเองเล็กน้อย

**How it works**

- Attack; usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It restores HP or MP.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [(isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0]: skill multiplier ×1.15 at Lv1 to 2.5 at Lv10
  - `calcPlayerToMobDamage`: skill multiplier depends on live values (formula below); flat damage +200
- Proration: magic proration slot, mode `first_hit_per_target`.
- Other client code reads this skill (2 lookups; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`
- **Cast time** (`CastTime`): `-1` = -1
  - when `(isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 8 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionStart` — when the cast starts: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 1 info
- `InitializeEnchantedSpell` — skill-specific method: 5 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 1.15 | 1.3 | 1.45 | 1.6 | 1.75 | 1.9 | 2.05 | 2.2 | 2.35 | 2.5 |
| Flat dmg + | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv << 4) - Lv) + 100)) / 100)`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv << 4) - Lv) + 100)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(200)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 836
- Uses the magic proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Other recovered parameters**

- **HP recovery cap** (`maxHpRecovery`): `((baseINT * 10) + (Lv * 100))` _(when (mainWeapon==Magictool & 1) ne 0)_; `(Lv * 100)` → Lv1..10 [100, 200, 300, 400, 500, 600, 700, 800, 900, 1000]; `((baseINT * 10) + (Lv * 100))` _(when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0)_
- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`; `-1` = -1 _(when (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) ne 0 OR (isPlayer & 1) ne 0 AND (mainWeapon==Magictool & 1) eq 0)_
- **HP recovered** (`hpRecovery`): `int(((status.MaxHp * 0.25) gt maxHpRecovery ? maxHpRecovery : (status.MaxHp * 0.25)))`

**In-game level notes**

- Lv14: *พลัง+100 *พลังจะเพิ่มมากกว่าค่า INT ของตัวเอง
- Lv15: *ขีดจำกัดปริมาณการฟื้นฟู HP จะเพิ่มมากกว่าค่า INT ของตัวเอง

**Where else this skill takes effect**

- Effect applied in `MobaPlayerBattleManager$$StartHolyBiblePursuitAttack` (2 guarded paths):
  - when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(836) ge 1`
    - returns `HolyBibleBuf.OnAction(TryGetBuf.out2(), 0, ?x2, ?x3)`
    - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`, `SkillBufferDataBase$$GetParam`, `EquipItemData$$get_SubWeapon`, `MathUtil$$CheckPercent`, `SkillFactory$$CreateSkill`, `SkillActionBase$$Initialize`
  - when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(836) lt 1`
    - returns `SkillLv(836)`
    - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`, `SkillBufferDataBase$$GetParam`, `EquipItemData$$get_SubWeapon`, `MathUtil$$CheckPercent`, `SkillFactory$$CreateSkill`
- Effect applied in `PlayerBattleManager$$StartHolyBiblePursuitAttack` (2 guarded paths):
  - when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(836) ge 1`
    - returns `HolyBibleBuf.OnAction(TryGetBuf.out2(), 0, ?x2, ?x3)`
    - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`, `SkillBufferDataBase$$GetParam`, `EquipItemData$$get_SubWeapon`, `MathUtil$$CheckPercent`, `SkillFactory$$CreateSkill`, `SkillActionBase$$Initialize`
  - when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(836) lt 1`
    - returns `SkillLv(836)`
    - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`, `SkillBufferDataBase$$GetParam`, `EquipItemData$$get_SubWeapon`, `MathUtil$$CheckPercent`, `SkillFactory$$CreateSkill`
- Code that reads this skill's level / buff by constant id: `MobaPlayerBattleManager$$StartHolyBiblePursuitAttack (GetSkillLv)`, `PlayerBattleManager$$StartHolyBiblePursuitAttack (GetSkillLv)`

_Raw recovered data (every method item): [trees/PriestSkill.md](../trees/PriestSkill.md) — uid 836_

---

### เอ็กซอร์ซิสต์ (Exorcism) · uid 842

<img src="../../icons/sk_842.png" width="40" alt="icon"> 
**Type:** Attack · **Max Lv:** 35 · **Weapons:** Rod, Shield · **Requires:** โฮลี่ไลท์ · **Client class:** `ExorcismAction`

> โจมตีด้วยเวทมนตร์ธาตุแสงไปบริเวณรอบๆ
> ลด MP ที่ใช้ในสกิลถัดไปลงครึ่งหนึ่ง
> 
> ถ้าใช้กับธาตุมืดจะทรงพลังมากยิ่งขึ้น
> มีโอกาสทำให้ "ตาลาย/ตาพร่า/หวาดกลัว" อย่างใดอย่างหนึ่ง

**How it works**

- Attack; usable with Rod, Shield.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on Str (formula below); skill multiplier depends on Str (formula below); flat damage depends on live values (formula below); flat damage depends on live values (formula below)
- Proration: magic proration slot, mode `first_hit_per_target`.
- Can inflict on the target: `abnormalType`.
- Buffs:
  - `ExorcismBuf`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (2 lookups; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `0` = 0
- **Cast time** (`CastTime`): `-1` = -1
  - when `(isPlayer & 1) ne 0`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(100)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 6 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionStart` — when the cast starts: 1 set, 1 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 2 call, 1 info
- `OnInheritance` — state carried over when this action follows another: 1 set
- `InitializeEnchantedSpell` — skill-specific method: 1 set

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((target.(5) eq 6 ? ((((Lv * 20) + (status.Str * 0.5))) + 400) : (((Lv * 20) + (status.Str * 0.5)))) / 100)`
- SkillRate × `((target.(5) eq 6 ? ((((Lv * 20) + (status.Str * 0.5))) + 400) : (((Lv * 20) + (status.Str * 0.5)))) / 100)`
- Flat dmg + `(target.(5) eq 6 ? (((Lv * 10)) + 100) : ((Lv * 10)))`
- Flat dmg + `(target.(5) eq 6 ? (((Lv * 10)) + 100) : ((Lv * 10)))`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((target.(5) eq 6 ? ((((Lv * 20) + (status.Str * 0.5))) + 400) : (((Lv * 20) + (status.Str * 0.5)))) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(target.(5) eq 6 ? (((Lv * 10)) + 100) : ((Lv * 10)))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 842
- Uses the magic proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Rolls `(MobActionManagerBase.get_IsBoss(mobAction) ? (percent // 10) : percent)`% to inflict **`abnormalType`** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, abnormalType, ((MobActionManagerBase.get_IsBoss(mobAction) ? (percent // 10) : percent), playerAction) & 1) ne 0 AND target.Element eq 6 OR PlayerAttackBase.checkAbnormalPercent(this, abnormalType, (!MobActionManagerBase.get_IsBoss(mobAction) ? (percent // 10) : percent), playerAction) AND target.Element eq 6 OR PlayerAttackBase.checkAbnormalPercent(this, abnormalType, ((MobActionManagerBase.get_IsBoss(mobAction) ? (percent // 10) : percent), playerAction) & 1) ne 0 AND isNemesisBuf ne 0 AND target.Element ne 6`
- Uses the default ailment duration (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, abnormalType, ((MobActionManagerBase.get_IsBoss(mobAction) ? (percent // 10) : percent), playerAction) & 1) ne 0 AND target.Element eq 6 OR PlayerAttackBase.checkAbnormalPercent(this, abnormalType, ((MobActionManagerBase.get_IsBoss(mobAction) ? (percent // 10) : percent), playerAction) & 1) ne 0 AND isNemesisBuf ne 0 AND target.Element ne 6`

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): adds the caster's buff of skill 842 (Exorcism) — `AddSelfBuffer(842, Lv, Id)`
  - when `(SkillParam & 16) eq 0 AND UnityEngine.Object.op_Inequality(actarAction)`

**Other recovered parameters**

- **Effect percent** (`percent`): `(Lv * 3)` → Lv1..10 [3, 6, 9, 12, 15, 18, 21, 24, 27, 30]
- **Cast time modifier** (`CastTime`): `0` = 0; `-1` = -1 _(when (isPlayer & 1) ne 0)_

**Buff values** (every recovered field; durations in seconds)

**Buff `ExorcismBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).

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

_Raw recovered data (every method item): [trees/PriestSkill.md](../trees/PriestSkill.md) — uid 842_

---

### เอนเชนส์เบลส (BlessStrengthen) · uid 837

<img src="../../icons/sk_837.png" width="40" alt="icon"> 
**Type:** Mastery · **Max Lv:** 125 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** กลอเรีย · **Client class:** `BlessStrengthen` (passive mastery)

> เพิ่มพลังฟื้นฟูของ[เบลส]
> ในกรณีที่มีเบลสเลเวล 10
> จะเพิ่มระยะเวลา, ปริมาณที่ฟื้นฟู และโบนัสไม้เท้าให้มากยิ่งขึ้น

**How it works**

- Mastery; usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Its effect is applied by client code: `BlessAction$$OnInitialize` (formulas in the last section).
- Other client code reads this skill (1 lookup; see the last section).

**In-game level notes**

- Lv14: *ปริมาณ MATK มีผลต่อปริมาณการฟื้นฟู+1% ในกรณีที่สกิลเลเวลของเบลสเป็น 10 INT มีผลต่อปริมาณการฟื้นฟู

**Where else this skill takes effect**

- Effect applied in `BlessAction$$OnInitialize` (48 guarded paths):
  - when `SkillLv(837) gt 0` AND `Lv lo 2` AND `SkillLv(837) ge 2` AND `SkillLv(837) ge 1`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `-1`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `CastTime` = `0`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - set `count` = `((Lv eq 10 ? (((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5))) + 1) : ((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5)))) - 1)`
    - calls `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$CalcMotionSpeed`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
  - when `SkillLv(837) gt 0` AND `Lv lo 2` AND `SkillLv(837) ge 2` AND `SkillLv(837) ge 1`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `-1`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `CastTime` = `0`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - set `count` = `((Lv eq 10 ? (((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5))) + 1) : ((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5)))) - 1)`
    - calls `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$CalcMotionSpeed`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
  - when `SkillLv(837) gt 0` AND `Lv lo 2` AND `SkillLv(837) ge 2` AND `SkillLv(837) lt 1`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `-1`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `CastTime` = `0`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - set `count` = `((Lv eq 10 ? (((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5))) + 1) : ((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5)))) - 1)`
    - calls `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$CalcMotionSpeed`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
  - when `SkillLv(837) gt 0` AND `Lv lo 2` AND `SkillLv(837) ge 2` AND `SkillLv(837) lt 1`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `-1`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `CastTime` = `0`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - set `count` = `((Lv eq 10 ? (((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5))) + 1) : ((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5)))) - 1)`
    - calls `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$CalcMotionSpeed`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
  - when `SkillLv(837) gt 0` AND `Lv lo 2` AND `SkillLv(837) ge 2` AND `SkillLv(837) ge 1`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `-1`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `CastTime` = `0`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - set `count` = `((Lv eq 10 ? (((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5))) + 1) : ((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5)))) - 1)`
    - calls `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$CalcMotionSpeed`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
  - when `SkillLv(837) gt 0` AND `Lv lo 2` AND `SkillLv(837) ge 2` AND `SkillLv(837) lt 1`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `-1`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `CastTime` = `0`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - set `count` = `((Lv eq 10 ? (((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5))) + 1) : ((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5)))) - 1)`
    - calls `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$CalcMotionSpeed`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
  - when `SkillLv(837) gt 0` AND `Lv lo 2` AND `SkillLv(837) lt 2` AND `SkillLv(837) ge 1`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `-1`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `CastTime` = `0`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - set `count` = `((Lv eq 10 ? (((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5))) + 1) : ((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5)))) - 1)`
    - calls `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$CalcMotionSpeed`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
  - when `SkillLv(837) gt 0` AND `Lv lo 2` AND `SkillLv(837) lt 2` AND `SkillLv(837) ge 1`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `-1`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `CastTime` = `0`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - set `count` = `((Lv eq 10 ? (((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5))) + 1) : ((int((Lv / 3)) + 1) + int(((SkillLv(837) - 1) * 0.5)))) - 1)`
    - calls `PlayerAttackBase$$GetWeaponType`, `PlayerAttackBase$$CalcMotionSpeed`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- Code that reads this skill's level / buff by constant id: `BlessAction$$OnInitialize (GetSkillLv)`

_Raw recovered data (every method item): [trees/PriestSkill.md](../trees/PriestSkill.md) — uid 837_

---

### อีเธอร์บาเรีย (EtherCoat) · uid 838

<img src="../../icons/sk_838.png" width="40" alt="icon"> 
**Type:** Support · **Max Lv:** 125 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** โฮลี่ไลท์ · **Flags:** MercenaryCanUseSkill · **Client class:** `EtherCoatAction`

> กางบาเรียเพื่อดูดซับแรงจากการโจมตี
> เพิ่มความต้านทานสภาวะผิดปกติ[ผงะ]
> ในเวลาระยะเวลาสั้้นๆ

**How it works**

- Support; usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It installs a buff on other players / the party.
- Buffs:
  - `EtherCoatBuf`: lasts `5` s; Lv1 → Lv10: AbnormalRegist (ailment resistance) 55 → 100, MAtkUpRate (MATK %) -8 → -5
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 4, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 2 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 838
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `EtherCoatBuf` — `.ctor(Lv)`
- `ActionHit` (when the attack connects): adds a target's buff of `new EtherCoatBuf` — `AddBuffer(new EtherCoatBuf, 0)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 4, PlayerActionManagerBase.get_PlayerStatus())`

**Buff values** (every recovered field; durations in seconds)

**Buff `EtherCoatBuf`**
- Duration: `5` s

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| AbnormalRegist | 55 | 60 | 65 | 70 | 75 | 80 | 85 | 90 | 95 | 100 |
| MAtkUpRate | -8 | -8 | -8 | -7 | -7 | -7 | -6 | -6 | -6 | -5 |

- Buff fields set in the constructor (all recovered):
  - `isViewSelfIcon` = `0`
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `SetViewSelfIcon`: `isViewSelfIcon`=(flag & 1)
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:EtherCoatBuf$$.ctor<-EtherCoatAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

Parameter meanings (inferred from the `SkillBufferId` names):

- `AbnormalRegist`: ailment resistance
- `MAtkUpRate`: MATK %

_Raw recovered data (every method item): [trees/PriestSkill.md](../trees/PriestSkill.md) — uid 838_

---

### โฮลี่ไบเบิ้ล (HolyBible) · uid 843

<img src="../../icons/sk_843.png" width="40" alt="icon"> 
**Type:** Buffer · **Max Lv:** 125 · **Weapons:** OneHandSword, Rod, Knuckle · **Requires:** เอ็กซอร์ซิสต์ · **Client class:** `HolyBibleAction`

> เพิ่มต้านทานธาตุมืดเล็กน้อยเป็นเวลา 10 นาที
> ถ้าสร้างความเสียหายด้วยเวทมนตร์ให้กับเป้าหมายที่ไม่ใช่ธาตุแสง
> มีโอกาสที่จะใช้โฮลี่ไลท์ที่เรียนรู้มาแล้วเพิ่ม
> *มีโอกาสที่จะสร้างความเสียหายให้ธาตุแสงด้วย

**How it works**

- Buffer; usable with OneHandSword, Rod, Knuckle.
- It installs a buff on the caster.
- Buffs:
  - `HolyBibleBuf`: lasts `600` s; Lv1 → Lv10: Percent (generic percent) 27 → 50, ReceiveDarkElementDmgRate (dark-element damage taken %) 1 → 10
- Other client code reads this skill (4 lookups; see the last section).

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 1 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 1 call
- `OnInheritance` — state carried over when this action follows another: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 843
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): adds the caster's buff of skill 843 (HolyBible) — `AddSelfBuffer(843, Lv, 0)`
  - when `UnityEngine.Object.op_Inequality(actarAction) OR TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 843) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)`

**Buff values** (every recovered field; durations in seconds)

**Buff `HolyBibleBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `Initialize`, `OnAction`, `get_ActivePersuit`, `get_CoolTime`
- Duration: `600` s

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Percent | 27 | 30 | 32 | 35 | 37 | 40 | 42 | 45 | 47 | 50 |
| ReceiveDarkElementDmgRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |

- Buff fields set in the constructor (all recovered):
  - `darkElementDmgRate` = `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `activePercent` = `(int((Lv * 2.5)) + 25)` → Lv1..10 [27, 30, 32, 35, 37, 40, 42, 45, 47, 50]
  - `coolTime` = `0`
- Hook `Initialize`: `playerStatus`=playerStatus
- Hook `Updata`: `LeftTime`=0; `coolTime`=0; `coolTime`=(coolTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
- Hook `OnAction`: `coolTime`=(EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? ((20 - Lv) * 0.5) : (20 - Lv))

Parameter meanings (inferred from the `SkillBufferId` names):

- `Percent`: generic percent
- `ReceiveDarkElementDmgRate`: dark-element damage taken %

**In-game level notes**

- Lv10: *โฮลี่ไลท์ที่ใช้จะมีผลกับโบนัสไม้เท้า
- Lv15: *ลดเวลาที่จะใช้โฮลี่ไลท์อีกครั้งลงครึ่งหนึ่ง
- Lv17: *อัตราการใช้โฮลี่ไลท์จะเป็น 2 เท่า

**Where else this skill takes effect**

- Effect applied in `MobaPlayerBattleManager$$StartHolyBiblePursuitAttack` (7 guarded paths):
  - when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(836) ge 1`
    - returns `HolyBibleBuf.OnAction(TryGetBuf.out2(), 0, ?x2, ?x3)`
    - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`, `SkillBufferDataBase$$GetParam`, `EquipItemData$$get_SubWeapon`, `MathUtil$$CheckPercent`, `SkillFactory$$CreateSkill`, `SkillActionBase$$Initialize`
  - when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(836) lt 1`
    - returns `SkillLv(836)`
    - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`, `SkillBufferDataBase$$GetParam`, `EquipItemData$$get_SubWeapon`, `MathUtil$$CheckPercent`, `SkillFactory$$CreateSkill`
  - when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillActionBase.op_Equality(SkillFactory.CreateSkill(22, 0, ?x2, ?x3), 0, 0, ?x3)`
    - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`, `SkillBufferDataBase$$GetParam`, `EquipItemData$$get_SubWeapon`, `MathUtil$$CheckPercent`, `SkillFactory$$CreateSkill`
  - when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `MathUtil.CheckPercent((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 52, 0, ?x3) << ([EquipItemData.get_SubWeapon(?blr, 0, ?x2, ?x3)+0x38] eq 17 ? 1 : 0)), 0, ?x2, ?x3)`
    - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`, `SkillBufferDataBase$$GetParam`, `EquipItemData$$get_SubWeapon`, `MathUtil$$CheckPercent`
  - when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `HolyBibleBuf.get_ActivePersuit(TryGetBuf.out2(), 0, ?x2, ?x3)`
    - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`
  - when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `0x165db84`, `0x165df00`, `0x165df00`
  - when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0)`
    - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`
- Effect applied in `PlayerBattleManager$$StartHolyBiblePursuitAttack` (7 guarded paths):
  - when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(836) ge 1`
    - returns `HolyBibleBuf.OnAction(TryGetBuf.out2(), 0, ?x2, ?x3)`
    - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`, `SkillBufferDataBase$$GetParam`, `EquipItemData$$get_SubWeapon`, `MathUtil$$CheckPercent`, `SkillFactory$$CreateSkill`, `SkillActionBase$$Initialize`
  - when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `SkillLv(836) lt 1`
    - returns `SkillLv(836)`
    - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`, `SkillBufferDataBase$$GetParam`, `EquipItemData$$get_SubWeapon`, `MathUtil$$CheckPercent`, `SkillFactory$$CreateSkill`
  - when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `SkillActionBase.op_Equality(SkillFactory.CreateSkill(22, 0, ?x2, ?x3), 0, 0, ?x3)`
    - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`, `SkillBufferDataBase$$GetParam`, `EquipItemData$$get_SubWeapon`, `MathUtil$$CheckPercent`, `SkillFactory$$CreateSkill`
  - when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `MathUtil.CheckPercent((SkillBufferDataBase.GetParam(TryGetBuf.out2(), 52, 0, ?x3) << ([EquipItemData.get_SubWeapon(?blr, 0, ?x2, ?x3)+0x38] eq 17 ? 1 : 0)), 0, ?x2, ?x3)`
    - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`, `SkillBufferDataBase$$GetParam`, `EquipItemData$$get_SubWeapon`, `MathUtil$$CheckPercent`
  - when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `HolyBibleBuf.get_ActivePersuit(TryGetBuf.out2(), 0, ?x2, ?x3)`
    - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `HolyBibleBuf$$get_ActivePersuit`
  - when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`, `0x165db84`, `0x165df00`, `0x165df00`
  - when `SkillActionBase.get_AttackType() eq 2` AND `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 843, stkp(-56), 0)`
    - calls `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `virtual SkillActionBase.get_AttackType`
- Effect applied in `HolyBibleAction$$ActionHit` (3 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `HolyBibleBuf.Initialize(SkillBufferManager.AddSelfBuffer(?blr, 843, Lv, 0), ?blr, 0, ?x3)`
    - calls `EquipItemData$$get_SubWeapon`, `SkillBufferManager$$AddSelfBuffer`, `HolyBibleBuf$$Initialize`
  - when `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `EquipItemData$$get_SubWeapon`, `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(?blr, 843, stkp(-40), 0) & 1) eq 0`
    - returns `HolyBibleBuf.Initialize(SkillBufferManager.AddSelfBuffer(?blr, 843, Lv, 0), ?blr, 0, ?x3)`
    - calls `EquipItemData$$get_SubWeapon`, `SkillBufferManager$$AddSelfBuffer`, `HolyBibleBuf$$Initialize`
- Effect applied in `MindimageSenjuSupportAction$$ActionHit` (3 guarded paths):
  - when `SendSupport ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() gt 644` AND `CharacterActionManagerBase.get_IsLocalDead() le 965` AND `CharacterActionManagerBase.get_IsLocalDead() ne 650`
    - returns `HolyBibleBuf.Initialize(SkillBufferManager.AddSelfBuffer(?blr, 843, [baseSkill+0x14], 0), ?blr, 0, ?x3)`
    - calls `virtual CharacterActionManagerBase.get_IsLocalDead`, `EquipItemData$$get_SubWeapon`, `SkillBufferManager$$AddSelfBuffer`, `HolyBibleBuf$$Initialize`
  - when `SendSupport ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() gt 644` AND `CharacterActionManagerBase.get_IsLocalDead() le 965` AND `CharacterActionManagerBase.get_IsLocalDead() ne 650`
    - calls `virtual CharacterActionManagerBase.get_IsLocalDead`, `EquipItemData$$get_SubWeapon`, `0x165db84`, `0x165df00`
  - when `SendSupport ne 0` AND `CharacterActionManagerBase.get_IsLocalDead() gt 644` AND `CharacterActionManagerBase.get_IsLocalDead() le 965` AND `CharacterActionManagerBase.get_IsLocalDead() ne 650`
    - returns `HolyBibleBuf.Initialize(SkillBufferManager.AddSelfBuffer(?blr, 843, [baseSkill+0x14], 0), ?blr, 0, ?x3)`
    - calls `virtual CharacterActionManagerBase.get_IsLocalDead`, `EquipItemData$$get_SubWeapon`, `SkillBufferManager$$AddSelfBuffer`, `HolyBibleBuf$$Initialize`
- Code that reads this skill's level / buff by constant id: `HolyBibleAction$$ActionHit (TryGetBuf)`, `MindimageSenjuSupportAction$$ActionHit (TryGetBuf)`, `MobaPlayerBattleManager$$StartHolyBiblePursuitAttack (TryGetBuf)`, `PlayerBattleManager$$StartHolyBiblePursuitAttack (TryGetBuf)`

_Raw recovered data (every method item): [trees/PriestSkill.md](../trees/PriestSkill.md) — uid 843_

---

### ไฮเนสฮีล (HighnessHeal) · uid 839

<img src="../../icons/sk_839.png" width="40" alt="icon"> 
**Type:** Support · **Max Lv:** 205 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เอนเชนส์เบลส · **Flags:** StarGem · **Client class:** `HighnessHealAction`

> ฟื้นฟู HP ของตัวเองและเพื่อนที่อยู่รอบๆ
> ไม่เหมือนฮีลของสกิลสนับสนุนตรงที่
> ไม่มีผลทำให้คืนชีพได้เร็วขึ้น

**How it works**

- Support; usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It is a utility / system action (movement, state change) rather than a damage or buff skill.

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 3, PlayerActionManagerBase.get_PlayerStatus())`
- **Heal range** (`healRange`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance((gemCart(1025[2]) + 8))`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 839
- No proration slot: ExpType None: no proration slot.

**Other recovered parameters**

- **Heal range** (`healRange`): `MathUtil.DisplayMeterToDistance((gemCart(1025[2]) + 8))`
- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 3, PlayerActionManagerBase.get_PlayerStatus())`

_Raw recovered data (every method item): [trees/PriestSkill.md](../trees/PriestSkill.md) — uid 839_

---

### พรีเอล (Priere) · uid 840

<img src="../../icons/sk_840.png" width="40" alt="icon"> 
**Type:** Support · **Max Lv:** 205 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** อีเธอร์บาเรีย · **Flags:** StarGem, MercenaryCanUseSkill · **Client class:** `PriereAction`

> ตั้งจิตอธิษฐานเพื่อเพิ่มพลังเวท
> จะเพิ่ม MATK ได้ชั่วขณะ
> เมื่อใช้งานมีโอกาสที่จะหายจากสภาวะ [อ่อนแอ]

**How it works**

- Support; usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It installs a buff on other players / the party.
- Buffs:
  - `PriereBuf`: lasts `((Lv + 15) + 50)` s / `(Lv + 15)` s; Lv1 → Lv10: MAtkUpRate (MATK %) 1 → 10

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 2 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 840
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `PriereBuf` — `.ctor(Lv, PlayerActionManagerBase.get_PlayerStatus())`
- `ActionHit` (when the attack connects): adds a target's buff of `new PriereBuf` — `AddBuffer(new PriereBuf, 0)`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 1, PlayerActionManagerBase.get_PlayerStatus())`

**Buff values** (every recovered field; durations in seconds)

**Buff `PriereBuf`**
- Duration: `((Lv + 15) + 50)` s [EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14]; `(Lv + 15)` s [((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? 1 : 0) | 0) eq 1 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ne 14 OR ((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? 1 : 0) | 0) ne 1 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ne 14 OR ((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? 1 : 0) | 1) eq 1 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ne 14]; `time` s
- `MAtkUpRate` = `0` _(when BuffEffectActive eq 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MAtkUpRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |

- Buff parameters that depend on the weapon/gem (constructor overloads):
  - `BuffEffectActive` = `1` = 1 when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR ((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? 1 : 0) | 0) eq 1 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ne 14
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR ((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? 1 : 0) | 0) eq 1 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ne 14
  - `IsSelfAction` = `0` when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR ((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? 1 : 0) | 0) eq 1 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ne 14
  - `BufEffectTakeUid` = `-1` = -1 when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR ((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? 1 : 0) | 0) eq 1 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ne 14
  - `mAtkUpRate` = `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR ((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? 1 : 0) | 0) ne 1 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ne 14
  - `mAtkUpRate` = `(Lv + 5)` → Lv1..10 [6, 7, 8, 9, 10, 11, 12, 13, 14, 15] when ((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? 1 : 0) | 0) eq 1 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ne 14 OR ((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? 1 : 0) | 1) eq 1 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ne 14
  - `isViewSelfIcon` = `1` = 1 when EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 14 OR ((EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type eq 15 ? 1 : 0) | 0) eq 1 AND EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 15 AND EquipItemData.get_Weapon(PlayerStatusBase.get_EquipItemData()).Type ne 14
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

Parameter meanings (inferred from the `SkillBufferId` names):

- `MAtkUpRate`: MATK %

**In-game level notes**

- Lv14: *ระยะเวลาแสดงผล+50s
- Lv15: *UP ปริมาณการเพิ่ม MATK
- Lv17: *มีโอกาสหายจากภาวะอ่อนแอ+25%

_Raw recovered data (every method item): [trees/PriestSkill.md](../trees/PriestSkill.md) — uid 840_

---

### เนเมซิส (Nemesis) · uid 844

<img src="../../icons/sk_844.png" width="40" alt="icon"> 
**Type:** Attack · **Max Lv:** 205 · **Weapons:** OneHandSword, Rod, Knuckle · **Requires:** โฮลี่ไบเบิ้ล · **Client class:** `NemesisAction`

> สร้างความเสียหายทางกายภาพและ
> กำหนดเป้าหมายที่จะโดนทัณฑ์สวรรค์
> 
> ถ้าอยู่ในสถานะที่โดนทัณฑ์สวรรค์สแต็คจะถูกสะสม
> เมื่อใช้งานสกิลนี้อีกครั้ง ขอบเขตการโจมตีด้วยเวทมนตร์
> จะเพิ่มตามจำนวนสแต็คที่สะสม

**How it works**

- Attack; usable with OneHandSword, Rod, Knuckle.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Its buff exposes motion / combo hooks, so it changes the attack pattern while active (heuristic; the client has no explicit flag).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [isFirst ne 0]: skill multiplier ×10; skill multiplier depends on Str (formula below); flat damage +60 at Lv1 to 600 at Lv10
  - `calcPlayerToMobDamage` [!PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount lt 1 AND isFirst eq 0 OR !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount ge 1 AND criticalAttackCount ge SkillActionBase.get_AttackCount(this) AND isFirst eq 0 OR criticalAttackCount eq -1 AND criticalAttackCount ge 1 AND criticalAttackCount lt SkillActionBase.get_AttackCount(this) AND isFirst eq 0]: skill multiplier ×10; skill multiplier depends on Int, Str (formula below); skill multiplier depends on Int, Str (formula below); skill multiplier depends on Int, Str (formula below); flat damage +60 at Lv1 to 600 at Lv10; flat damage +30 at Lv1 to 300 at Lv10
- Proration: slot chosen at runtime (physical or magic by a per-cast flag), mode `first_hit_per_target`.
- Buffs:
  - `NemesisBuf`: lasts `((((Lv << 2) + lv) << 1) + (((Lv << 2) + lv) << 1))` s / `(((Lv << 2) + lv) << 1)` s
  - `CountBufferBase`
- Other client code reads this skill (15 lookups; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(8)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `InitializeOthers` — setup used when another player's client replays the action: 3 set
- `OtherPlayerAttackStartReceive` — skill-specific method: 1 set
- `ActionPreparation` — before the cast starts: 9 set
- `ActionStart` — when the cast starts: 1 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 6 tpl, 1 call, 1 info, 1 set
- `NextRangeHit` — next range-hit pass: 1 set
- `ActionHit` — when the attack connects: 2 call
- `OnInheritance` — state carried over when this action follows another: 1 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [isFirst ne 0] | 10 | 10 | 10 | 10 | 10 | 10 | 10 | 10 | 10 | 10 |
| SkillRate × [!PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount lt 1 AND isFirst eq 0 OR !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount ge 1 AND criticalAttackCount ge SkillActionBase.get_AttackCount(this) AND isFirst eq 0 OR criticalAttackCount eq -1 AND criticalAttackCount ge 1 AND criticalAttackCount lt SkillActionBase.get_AttackCount(this) AND isFirst eq 0] | 10 | 10 | 10 | 10 | 10 | 10 | 10 | 10 | 10 | 10 |
| Flat dmg + [isFirst ne 0] | 60 | 120 | 180 | 240 | 300 | 360 | 420 | 480 | 540 | 600 |
| Flat dmg + [!PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount lt 1 AND isFirst eq 0 OR !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount ge 1 AND criticalAttackCount ge SkillActionBase.get_AttackCount(this) AND isFirst eq 0 OR criticalAttackCount eq -1 AND criticalAttackCount ge 1 AND criticalAttackCount lt SkillActionBase.get_AttackCount(this) AND isFirst eq 0] | 60 | 120 | 180 | 240 | 300 | 360 | 420 | 480 | 540 | 600 |
| Flat dmg + [!PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount lt 1 AND isFirst eq 0 OR !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount ge 1 AND criticalAttackCount ge SkillActionBase.get_AttackCount(this) AND isFirst eq 0 OR criticalAttackCount eq -1 AND criticalAttackCount ge 1 AND criticalAttackCount lt SkillActionBase.get_AttackCount(this) AND isFirst eq 0] | 30 | 60 | 90 | 120 | 150 | 180 | 210 | 240 | 270 | 300 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((min((1000 + status.Str), 1500)) / 100)` — isFirst ne 0
- SkillRate × `((((1) eq 0 ? 1 : 0) ne 0 ? (min(((status.Int * 0.5) + 500), 750)) : (min((1000 + status.Str), 1500))) / 100)` — !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount lt 1 AND isFirst eq 0 OR !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount ge 1 AND criticalAttackCount ge SkillActionBase.get_AttackCount(this) AND isFirst eq 0 OR criticalAttackCount eq -1 AND criticalAttackCount ge 1 AND criticalAttackCount lt SkillActionBase.get_AttackCount(this) AND isFirst eq 0
- SkillRate × `((((1) eq 0 ? 1 : 0) ne 0 ? (min(((status.Int * 0.5) + 500), 750)) : (min((1000 + status.Str), 1500))) / 100)` — !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount lt 1 AND isFirst eq 0 OR !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount ge 1 AND criticalAttackCount ge SkillActionBase.get_AttackCount(this) AND isFirst eq 0 OR criticalAttackCount eq -1 AND criticalAttackCount ge 1 AND criticalAttackCount lt SkillActionBase.get_AttackCount(this) AND isFirst eq 0
- SkillRate × `((((1) eq 0 ? 1 : 0) ne 0 ? (min(((status.Int * 0.5) + 500), 750)) : (min((1000 + status.Str), 1500))) / 100)` — !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount lt 1 AND isFirst eq 0 OR !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount ge 1 AND criticalAttackCount ge SkillActionBase.get_AttackCount(this) AND isFirst eq 0 OR criticalAttackCount eq -1 AND criticalAttackCount ge 1 AND criticalAttackCount lt SkillActionBase.get_AttackCount(this) AND isFirst eq 0

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((min((1000 + status.Str), 1500)) / 100)`
  - when `isFirst ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `((Lv * 60))`
  - when `isFirst ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(target.ExpDefMagic / 100)`
  - when `!PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount lt 1 AND isFirst eq 0 OR !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount ge 1 AND criticalAttackCount ge SkillActionBase.get_AttackCount(this) AND isFirst eq 0 OR criticalAttackCount eq -1 AND criticalAttackCount ge 1 AND criticalAttackCount lt SkillActionBase.get_AttackCount(this) AND isFirst eq 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((1) eq 0 ? 1 : 0) ne 0 ? (min(((status.Int * 0.5) + 500), 750)) : (min((1000 + status.Str), 1500))) / 100)`
  - when `!PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount lt 1 AND isFirst eq 0 OR !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount ge 1 AND criticalAttackCount ge SkillActionBase.get_AttackCount(this) AND isFirst eq 0 OR criticalAttackCount eq -1 AND criticalAttackCount ge 1 AND criticalAttackCount lt SkillActionBase.get_AttackCount(this) AND isFirst eq 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((1) eq 0 ? 1 : 0) ne 0 ? ((Lv * 30)) : ((Lv * 60)))`
  - when `!PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount lt 1 AND isFirst eq 0 OR !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount ge 1 AND criticalAttackCount ge SkillActionBase.get_AttackCount(this) AND isFirst eq 0 OR criticalAttackCount eq -1 AND criticalAttackCount ge 1 AND criticalAttackCount lt SkillActionBase.get_AttackCount(this) AND isFirst eq 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`
  - when `!PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount lt 1 AND isFirst eq 0 OR !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount ge 1 AND criticalAttackCount ge SkillActionBase.get_AttackCount(this) AND isFirst eq 0 OR criticalAttackCount eq -1 AND criticalAttackCount ge 1 AND criticalAttackCount lt SkillActionBase.get_AttackCount(this) AND isFirst eq 0`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `dynamic`, mode `first_hit_per_target`, attack type `dynamic`, action id 844
- Uses the slot chosen at runtime (physical or magic by a per-cast flag); Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `motionSpeed`
- Loop / hit-repeat count (`LoopParam`): `SkillBufferDataBase.GetParam(CheckNemesisBuf.buf((this + 312), actarAction), 20)`
- Loop / hit-repeat count (`LoopParam`): `0` = 0

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): removes the caster's buff of skill 844 (Nemesis) — `RemoveSelfBuffer(844)`
  - when `!PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND isInstallation ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): adds the buff-provided flat damage to the template — `SetBufferConstantDamage(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), (LoopParam + 1))`
  - when `isFirst ne 0 OR !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount lt 1 AND isFirst eq 0 OR !PlayerAttackBase.CheckMagicCritical(this, PlayerActionManagerBase.get_PlayerStatus(), mobAction) AND criticalAttackCount ge 1 AND criticalAttackCount ge SkillActionBase.get_AttackCount(this) AND isFirst eq 0`
- `ActionHit` (when the attack connects): constructs `NemesisBuf` — `.ctor(Lv, target, actarAction)`
  - when `UnityEngine.Object.op_Inequality(actarAction) AND isInstallation eq 0`
- `ActionHit` (when the attack connects): adds the caster's buff of `new NemesisBuf` — `AddSelfBuffer(new NemesisBuf, Id)`
  - when `UnityEngine.Object.op_Inequality(actarAction) AND isInstallation eq 0`

**Other recovered parameters**

- **Loop / hit-repeat count** (`LoopParam`): `motionSpeed`; `SkillBufferDataBase.GetParam(CheckNemesisBuf.buf((this + 312), actarAction), 20)`; `0` = 0
- **Per-target multiplier (%)** (`targetSkillRate`): `min((1000 + status.Str), 1500)`; `1000` = 1000

**Buff values** (every recovered field; durations in seconds)

**Buff `NemesisBuf`**
- **Changes the attack pattern**: the buff object drives a motion/combo chain (`ChangeHyperMode`, `get_BufEffectTakeId`).
- Buff hook methods: `ChangeHyperMode`, `CheckBufferLineConnect`, `CheckPlayerAttackDamaged`, `CountReset`, `MobAttackDamaged`, `OnCall`, `PlayerAttackDamaged`, `get_BufEffectTakeId`
- Duration: `((((Lv << 2) + lv) << 1) + (((Lv << 2) + lv) << 1))` s [EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type eq 17]; `(((Lv << 2) + lv) << 1)` s [EquipItemData.get_SubWeapon(PlayerStatusBase.get_EquipItemData()).Type ne 17]
- `Count` = `(0)` _(when BuffEffectActive ne 0)_
- Buff fields set in the constructor (all recovered):
  - `range` = `MathUtil.DisplayMeterToDistance(16)`
  - `playerAttackIdList` = `new System.Collections.Generic.List<int>`
  - `Count` = `0`
  - `target` = `target`
  - `playerAction` = `player`
  - `mobAction` = `UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>(target)`
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
- Hook `CountReset`: `Count`=0
- Hook `OnCall`: `lineEffect`=UnityEngine.GameObject.AddComponent<NemesisBuf.NemesisLineEffect>(UnityEngine.Component.get_gameObject([[Singleton<TakeManager>.get_Instance()+0x20]+0x30][takeUid]))
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:NemesisBuf$$.ctor<-NemesisAction$$ActionHit` (no direct constructor call in the skill's own code).
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

- Lv10: [ไม่ว่าจะใช้ไม้เท้าหรือสนับมือก็มีรายละเอียดเหมือนกัน] จะมีเส้นที่เชื่อมโยงกับเป้าหมายที่โดนทัณฑ์สวรรค์แสดงขึ้นมา ถ้าอยู่ห่างกันเกินไปทัณฑ์สวรรค์จะถูกยกเลิก  สแต็คจะเพิ่มขึ้นเมื่อโจมตีโดนเป้าหมายที่มีเส้นเชื่อมโยงอยู่ หรือตอนที่ถูกโจมตี ถ้าอยู่ในสภาวะนิ่งเงียบสแต๊คที่สะสมมาจะหายไป
- Lv10: [ไม่ว่าจะใช้ไม้เท้าหรือสนับมือก็มีรายละเอียดเหมือนกัน] เมื่อใช้บัฟของสกิลนี้ผลข้อจำกัดเรื่อง ธาตุของเอ็กซอร์ซิสต์กับโฮลี่ไบเบิ้ลจะหายไป และเพิ่มธาตุคู่(อุปกรณ์เวทมนตร์)
- Lv15: *ระยะ (รัศมี) ของการโจมตีด้วยเวทย์มนตร์+2.5m
- Lv17: *พลังจะเพิ่มขึ้นตามค่า STR ของตัวเอง เวลาที่มีผลเพิ่มเป็น 2 เท่า

**Where else this skill takes effect**

- Effect applied in `MobaPlayerActionManager$$ReceiveAttack` (300 guarded paths, truncated):
  - when `(SkillActionBase.op_Inequality(skill, 0, 0, attackResponseData) & 1) ne 0` AND `GetServerHitTypeV2.out2() ne 1` AND `GetServerHitTypeV2.out1() ne 0` AND `SkillActionBase.get_ActionID() le 515`
    - returns `ChatManager.AddMobaDuelAbilityMessage(Singleton<object>.get_Instance(meta(0x3974ce8, Method$Singleton<ChatManager>.get_Instance()), ?x1, ?x2, ?x3), 37, 0x165d9d4(meta(0x3972128, object[]_TypeInfo), 2, ?x2, ?x3), 0)`
    - calls `SkillUtil$$GetServerHitTypeV2`, `virtual SkillActionBase.get_ActionID`, `UnityEngine.Component$$get_gameObject`, `PlayerSkillActionManager$$ReceiveMobaHitDamage`, `MoonSlashAction$$ReceiveMobaAttack`, `FuriousEffortsExtreme$$Damaged`, `UnityEngine.Component$$get_gameObject`, `NemesisBuf$$CheckPlayerAttackDamaged`
  - when `(SkillActionBase.op_Inequality(skill, 0, 0, attackResponseData) & 1) ne 0` AND `GetServerHitTypeV2.out2() ne 1` AND `GetServerHitTypeV2.out1() ne 0` AND `SkillActionBase.get_ActionID() le 515`
    - calls `SkillUtil$$GetServerHitTypeV2`, `virtual SkillActionBase.get_ActionID`, `UnityEngine.Component$$get_gameObject`, `PlayerSkillActionManager$$ReceiveMobaHitDamage`, `MoonSlashAction$$ReceiveMobaAttack`, `FuriousEffortsExtreme$$Damaged`, `UnityEngine.Component$$get_gameObject`, `NemesisBuf$$CheckPlayerAttackDamaged`
  - when `(SkillActionBase.op_Inequality(skill, 0, 0, attackResponseData) & 1) ne 0` AND `GetServerHitTypeV2.out2() ne 1` AND `GetServerHitTypeV2.out1() ne 0` AND `SkillActionBase.get_ActionID() le 515`
    - calls `SkillUtil$$GetServerHitTypeV2`, `virtual SkillActionBase.get_ActionID`, `UnityEngine.Component$$get_gameObject`, `PlayerSkillActionManager$$ReceiveMobaHitDamage`, `MoonSlashAction$$ReceiveMobaAttack`, `FuriousEffortsExtreme$$Damaged`, `UnityEngine.Component$$get_gameObject`, `NemesisBuf$$CheckPlayerAttackDamaged`
  - when `(SkillActionBase.op_Inequality(skill, 0, 0, attackResponseData) & 1) ne 0` AND `GetServerHitTypeV2.out2() ne 1` AND `GetServerHitTypeV2.out1() ne 0` AND `SkillActionBase.get_ActionID() le 515`
    - returns `UnityEngine.Object.op_Inequality([battleManager+0x30], 0, 0, ?x3)`
    - calls `SkillUtil$$GetServerHitTypeV2`, `virtual SkillActionBase.get_ActionID`, `UnityEngine.Component$$get_gameObject`, `PlayerSkillActionManager$$ReceiveMobaHitDamage`, `MoonSlashAction$$ReceiveMobaAttack`, `FuriousEffortsExtreme$$Damaged`, `UnityEngine.Component$$get_gameObject`, `NemesisBuf$$CheckPlayerAttackDamaged`
  - when `(SkillActionBase.op_Inequality(skill, 0, 0, attackResponseData) & 1) ne 0` AND `GetServerHitTypeV2.out2() ne 1` AND `GetServerHitTypeV2.out1() ne 0` AND `SkillActionBase.get_ActionID() le 515`
    - returns `ChatManager.AddMobaDuelAbilityMessage(Singleton<object>.get_Instance(meta(0x3974ce8, Method$Singleton<ChatManager>.get_Instance()), ?x1, ?x2, ?x3), 37, 0x165d9d4(meta(0x3972128, object[]_TypeInfo), 2, ?x2, ?x3), 0)`
    - calls `SkillUtil$$GetServerHitTypeV2`, `virtual SkillActionBase.get_ActionID`, `UnityEngine.Component$$get_gameObject`, `PlayerSkillActionManager$$ReceiveMobaHitDamage`, `MoonSlashAction$$ReceiveMobaAttack`, `FuriousEffortsExtreme$$Damaged`, `UnityEngine.Component$$get_gameObject`, `NemesisBuf$$CheckPlayerAttackDamaged`
  - when `(SkillActionBase.op_Inequality(skill, 0, 0, attackResponseData) & 1) ne 0` AND `GetServerHitTypeV2.out2() ne 1` AND `GetServerHitTypeV2.out1() ne 0` AND `SkillActionBase.get_ActionID() le 515`
    - calls `SkillUtil$$GetServerHitTypeV2`, `virtual SkillActionBase.get_ActionID`, `UnityEngine.Component$$get_gameObject`, `PlayerSkillActionManager$$ReceiveMobaHitDamage`, `MoonSlashAction$$ReceiveMobaAttack`, `FuriousEffortsExtreme$$Damaged`, `UnityEngine.Component$$get_gameObject`, `NemesisBuf$$CheckPlayerAttackDamaged`
  - when `(SkillActionBase.op_Inequality(skill, 0, 0, attackResponseData) & 1) ne 0` AND `GetServerHitTypeV2.out2() ne 1` AND `GetServerHitTypeV2.out1() ne 0` AND `SkillActionBase.get_ActionID() le 515`
    - calls `SkillUtil$$GetServerHitTypeV2`, `virtual SkillActionBase.get_ActionID`, `UnityEngine.Component$$get_gameObject`, `PlayerSkillActionManager$$ReceiveMobaHitDamage`, `MoonSlashAction$$ReceiveMobaAttack`, `FuriousEffortsExtreme$$Damaged`, `UnityEngine.Component$$get_gameObject`, `NemesisBuf$$CheckPlayerAttackDamaged`
  - when `(SkillActionBase.op_Inequality(skill, 0, 0, attackResponseData) & 1) ne 0` AND `GetServerHitTypeV2.out2() ne 1` AND `GetServerHitTypeV2.out1() ne 0` AND `SkillActionBase.get_ActionID() le 515`
    - returns `UnityEngine.Object.op_Inequality([battleManager+0x30], 0, 0, ?x3)`
    - calls `SkillUtil$$GetServerHitTypeV2`, `virtual SkillActionBase.get_ActionID`, `UnityEngine.Component$$get_gameObject`, `PlayerSkillActionManager$$ReceiveMobaHitDamage`, `MoonSlashAction$$ReceiveMobaAttack`, `FuriousEffortsExtreme$$Damaged`, `UnityEngine.Component$$get_gameObject`, `NemesisBuf$$CheckPlayerAttackDamaged`
- Effect applied in `EnemyMobActionManagerBase$$Damaged` (300 guarded paths, truncated):
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
- Effect applied in `ScoreAttackBossActionManager$$Damaged` (300 guarded paths, truncated):
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
- Effect applied in `BCollaboBossActionManager$$Damaged` (300 guarded paths, truncated):
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`
- Effect applied in `GuildRaidBossMobActionManager$$Damaged` (300 guarded paths, truncated):
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `EnemyMobActionManagerBase.get_IsLocalDead()`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
  - when `(EnemyMobActionManagerBase.get_IsDead() & 1) eq 0` AND `IsValid ne 0` AND `IsPlayerCreated ne 0` AND `(UnityEngine.Object.op_Equality(battleManager, 0, 0, damageData) & 1) ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, TransformShake.Shake(transformShake, 0, ?x2, ?x3), 0, ?x3)`
    - calls `virtual EnemyMobActionManagerBase.get_IsDead`, `virtual EnemyMobActionManagerBase.get_IsLocalDead`, `MobBattleSystemManager$$Avoid`, `BattleLogManager$$AvoidChatLog`, `EnemyMobActionManagerBase$$CheckCurrentPatternDamageInvalid`, `UnityEngine.GameObject$$GetComponent<object>`, `EnemyMobActionManagerBase$$TryGetProperties<object>`, `MobPropertyDamageLimit$$GetEffectScale`
- Effect applied in `ExorcismAction$$ActionStart` (2 guarded paths):
  - when `(SkillParam & 16) eq 0`
    - returns `SkillBufferManager.ContainsBuffer(?blr, 844, 0, ?x3)`
    - set `isNemesisBuf` = `(SkillBufferManager.ContainsBuffer(?blr, 844, 0, ?x3) & 1)`
    - calls `PlayerAttackBase$$ActionStart`, `SkillBufferManager$$AddSelfBuffer`
  - when `(SkillParam & 16) eq 0`
    - returns `SkillBufferManager.ContainsBuffer(?blr, 844, 0, ?x3)`
    - set `isNemesisBuf` = `(SkillBufferManager.ContainsBuffer(?blr, 844, 0, ?x3) & 1)`
    - calls `PlayerAttackBase$$ActionStart`
- Effect applied in `MobaOtherPlayerActionManager$$Damaged` (4 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 844, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `NemesisBuf.CheckPlayerAttackDamaged(TryGetBuf.out2(), UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), [action+0x10], 0)`
    - calls `UnityEngine.GameObject$$GetComponent<object>`, `UnityEngine.Component$$get_gameObject`, `NemesisBuf$$CheckPlayerAttackDamaged`
  - when `(SkillBufferManager.TryGetBuf(?blr, 844, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `NemesisBuf.CheckPlayerAttackDamaged(TryGetBuf.out2(), UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), [action+0x10], 0)`
    - calls `UnityEngine.GameObject$$GetComponent<object>`, `UnityEngine.Component$$get_gameObject`, `NemesisBuf$$CheckPlayerAttackDamaged`
  - when `(SkillBufferManager.TryGetBuf(?blr, 844, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `UnityEngine.GameObject$$GetComponent<object>`, `UnityEngine.Component$$get_gameObject`, `0x165db84`, `0x165df00`
  - when `(SkillBufferManager.TryGetBuf(?blr, 844, stkp(-56), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 844, stkp(-56), 0)`
    - calls `UnityEngine.GameObject$$GetComponent<object>`
- Effect applied in `NemesisAction$$Damaged` (5 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 844, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(NemesisBuf.MobAttackDamaged(TryGetBuf.out2(), target, damageData, 0) & 1) ne 0`
    - returns `NemesisBuf.MobAttackDamaged(TryGetBuf.out2(), target, damageData, 0)`
    - calls `NemesisBuf$$MobAttackDamaged`
  - when `(SkillBufferManager.TryGetBuf(?blr, 844, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(NemesisBuf.MobAttackDamaged(TryGetBuf.out2(), target, damageData, 0) & 1) eq 0`
    - returns `NemesisBuf.MobAttackDamaged(TryGetBuf.out2(), target, damageData, 0)`
    - calls `NemesisBuf$$MobAttackDamaged`
  - when `(SkillBufferManager.TryGetBuf(?blr, 844, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `0x165db84`, `0x165df00`
  - when `(SkillBufferManager.TryGetBuf(?blr, 844, stkp(-40), 0) & 1) ne 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 844, stkp(-40), 0)`
  - when `(SkillBufferManager.TryGetBuf(?blr, 844, stkp(-40), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 844, stkp(-40), 0)`
- Effect applied in `NemesisAction$$OnInitialize` (3 guarded paths):
  - always
    - set `Element` = `5`
    - set `SubElement` = `PlayerStatusBase.GetEquipSubWeaponElement(?blr, 0, ?x2, ?x3)`
    - set `IsValidDualElement` = `1`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - calls `PlayerAttackBase$$GetSubWeaponType`, `PlayerStatusBase$$GetEquipSubWeaponElement`, `PlayerAttackBase$$GetWeaponType`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`
  - always
    - set `Element` = `5`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - calls `PlayerAttackBase$$GetSubWeaponType`, `PlayerAttackBase$$GetWeaponType`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`
  - always
    - set `Element` = `5`
    - set `WeaponType` = `PlayerAttackBase.GetWeaponType(actarAction, 0, ?x2, ?x3)`
    - set `ActionRange` = `MathUtil.DisplayMeterToDistance(0, ?x1, ?x2, ?x3)`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - calls `PlayerAttackBase$$GetWeaponType`, `MathUtil$$DisplayMeterToDistance`, `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`
- Effect applied in `MobaPlayerActionManager$$AddAbnormalState` (6 guarded paths):
  - when `(resist & 1) ne 0` AND `type ne 4` AND `type le 18` AND `(type - 1) hi 10`
    - returns `(AbnormalStateManager.AddAbnormalState(?blr, 18, [0x165db78(meta(0x399ed28, MobaPlayerActionManager.<>c__DisplayClass64_0_TypeInfo), actor, type, time)+0x18], (resist & 1)) & 1)`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `AbnormalStateManager$$RemoveAbnormalState`, `0x165db78`, `System.Action<object>$$.ctor`, `SkillBufferManager$$RemoveSelfBuffer`
  - when `(resist & 1) ne 0` AND `type ne 4` AND `type le 18` AND `(type - 1) hi 10`
    - returns `(AbnormalStateManager.AddAbnormalState(?blr, 18, [0x165db78(meta(0x399ed28, MobaPlayerActionManager.<>c__DisplayClass64_0_TypeInfo), actor, type, time)+0x18], (resist & 1)) & 1)`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `AbnormalStateManager$$RemoveAbnormalState`, `0x165db78`, `System.Action<object>$$.ctor`, `AbnormalStateManager$$AddAbnormalState`
  - when `(resist & 1) eq 0` AND `(type - 1) lo 4` AND `type le 18` AND `(type - 1) hi 10`
    - returns `(AbnormalStateManager.AddAbnormalState(?blr, 18, [0x165db78(meta(0x399ed28, MobaPlayerActionManager.<>c__DisplayClass64_0_TypeInfo), actor, type, time)+0x18], (resist & 1)) & 1)`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165db78`, `System.Action<object>$$.ctor`, `SkillBufferManager$$RemoveSelfBuffer`, `AbnormalStateManager$$AddAbnormalState`
  - when `(resist & 1) eq 0` AND `(type - 1) lo 4` AND `type le 18` AND `(type - 1) hi 10`
    - returns `(AbnormalStateManager.AddAbnormalState(?blr, 18, [0x165db78(meta(0x399ed28, MobaPlayerActionManager.<>c__DisplayClass64_0_TypeInfo), actor, type, time)+0x18], (resist & 1)) & 1)`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165db78`, `System.Action<object>$$.ctor`, `AbnormalStateManager$$AddAbnormalState`
  - when `(resist & 1) eq 0` AND `type le 18` AND `(type - 1) hi 10` AND `type eq 18`
    - returns `(AbnormalStateManager.AddAbnormalState(?blr, 18, [0x165db78(meta(0x399ed28, MobaPlayerActionManager.<>c__DisplayClass64_0_TypeInfo), actor, type, time)+0x18], (resist & 1)) & 1)`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165db78`, `System.Action<object>$$.ctor`, `SkillBufferManager$$RemoveSelfBuffer`, `AbnormalStateManager$$AddAbnormalState`
  - when `(resist & 1) eq 0` AND `type le 18` AND `(type - 1) hi 10` AND `type eq 18`
    - returns `(AbnormalStateManager.AddAbnormalState(?blr, 18, [0x165db78(meta(0x399ed28, MobaPlayerActionManager.<>c__DisplayClass64_0_TypeInfo), actor, type, time)+0x18], (resist & 1)) & 1)`
    - calls `0x165db78`, `System.Object$$.ctor`, `0x165d8dc`, `0x165db78`, `System.Action<object>$$.ctor`, `AbnormalStateManager$$AddAbnormalState`
- Effect applied in `EnemyMobActionManagerBase$$SetHyperModeStatus` (300 guarded paths, truncated):
  - when `ChangeHyperMode.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 844, stkp(-120), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1126, stkp(-120), 0) & 1) ne 0`
    - returns `MobScriptActionManager.UpdateStatus(scriptActionManager, 0, ?x2, ?x3)`
    - set `mobStatusMaster` = `status`
    - set `invincibleTime` = `([mobModeData+0x2c] / 10)`
    - calls `0x165d8dc`, `MobHyperModeManager$$ChangeHyperMode`, `0x165da68`, `interface IBossParts.ClearParts`, `Singleton<object>$$get_Instance`, `MobMaster$$GetMobMaster`, `MobStatusMasterEx$$CheckMultiFlag`, `interface IBossParts.SetPartsMaster`
  - when `ChangeHyperMode.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 844, stkp(-120), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1126, stkp(-120), 0) & 1) ne 0`
    - returns `MobScriptActionManager.UpdateStatus(scriptActionManager, 0, ?x2, ?x3)`
    - set `mobStatusMaster` = `status`
    - set `invincibleTime` = `([mobModeData+0x2c] / 10)`
    - calls `0x165d8dc`, `MobHyperModeManager$$ChangeHyperMode`, `0x165da68`, `interface IBossParts.ClearParts`, `Singleton<object>$$get_Instance`, `MobMaster$$GetMobMaster`, `MobStatusMasterEx$$CheckMultiFlag`, `interface IBossParts.SetPartsMaster`
  - when `ChangeHyperMode.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 844, stkp(-120), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1126, stkp(-120), 0) & 1) ne 0`
    - set `mobStatusMaster` = `status`
    - set `invincibleTime` = `([mobModeData+0x2c] / 10)`
    - calls `0x165d8dc`, `MobHyperModeManager$$ChangeHyperMode`, `0x165da68`, `interface IBossParts.ClearParts`, `Singleton<object>$$get_Instance`, `MobMaster$$GetMobMaster`, `MobStatusMasterEx$$CheckMultiFlag`, `interface IBossParts.SetPartsMaster`
  - when `ChangeHyperMode.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 844, stkp(-120), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1126, stkp(-120), 0) & 1) ne 0`
    - returns `MobScriptActionManager.UpdateStatus(scriptActionManager, 0, ?x2, ?x3)`
    - set `mobStatusMaster` = `status`
    - set `invincibleTime` = `([mobModeData+0x2c] / 10)`
    - calls `0x165d8dc`, `MobHyperModeManager$$ChangeHyperMode`, `0x165da68`, `interface IBossParts.ClearParts`, `Singleton<object>$$get_Instance`, `MobMaster$$GetMobMaster`, `MobStatusMasterEx$$CheckMultiFlag`, `interface IBossParts.SetPartsMaster`
  - when `ChangeHyperMode.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 844, stkp(-120), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1126, stkp(-120), 0) & 1) ne 0`
    - set `mobStatusMaster` = `status`
    - set `invincibleTime` = `([mobModeData+0x2c] / 10)`
    - calls `0x165d8dc`, `MobHyperModeManager$$ChangeHyperMode`, `0x165da68`, `interface IBossParts.ClearParts`, `Singleton<object>$$get_Instance`, `MobMaster$$GetMobMaster`, `MobStatusMasterEx$$CheckMultiFlag`, `interface IBossParts.SetPartsMaster`
  - when `ChangeHyperMode.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 844, stkp(-120), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1126, stkp(-120), 0) & 1) ne 0`
    - returns `MobScriptActionManager.UpdateStatus(scriptActionManager, 0, ?x2, ?x3)`
    - set `mobStatusMaster` = `status`
    - set `invincibleTime` = `([mobModeData+0x2c] / 10)`
    - calls `0x165d8dc`, `MobHyperModeManager$$ChangeHyperMode`, `0x165da68`, `interface IBossParts.ClearParts`, `Singleton<object>$$get_Instance`, `MobMaster$$GetMobMaster`, `MobStatusMasterEx$$CheckMultiFlag`, `interface IBossParts.SetPartsMaster`
  - when `ChangeHyperMode.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 844, stkp(-120), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1126, stkp(-120), 0) & 1) ne 0`
    - returns `MobScriptActionManager.UpdateStatus(scriptActionManager, 0, ?x2, ?x3)`
    - set `mobStatusMaster` = `status`
    - calls `0x165d8dc`, `MobHyperModeManager$$ChangeHyperMode`, `0x165da68`, `interface IBossParts.ClearParts`, `Singleton<object>$$get_Instance`, `MobMaster$$GetMobMaster`, `MobStatusMasterEx$$CheckMultiFlag`, `interface IBossParts.SetPartsMaster`
  - when `ChangeHyperMode.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 844, stkp(-120), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(CharacterActionManagerBase.get_IsValid(), 1126, stkp(-120), 0) & 1) ne 0`
    - returns `MobScriptActionManager.UpdateStatus(scriptActionManager, 0, ?x2, ?x3)`
    - set `mobStatusMaster` = `status`
    - calls `0x165d8dc`, `MobHyperModeManager$$ChangeHyperMode`, `0x165da68`, `interface IBossParts.ClearParts`, `Singleton<object>$$get_Instance`, `MobMaster$$GetMobMaster`, `MobStatusMasterEx$$CheckMultiFlag`, `interface IBossParts.SetPartsMaster`
- Code that reads this skill's level / buff by constant id: `BCollaboBossActionManager$$Damaged (TryGetBuf)`, `EnemyMobActionManagerBase$$Damaged (TryGetBuf)`, `EnemyMobActionManagerBase$$SetHyperModeStatus (TryGetBuf)`, `ExorcismAction$$ActionStart (ContainsBuffer)`, `GuildRaidBossMobActionManager$$Damaged (TryGetBuf)`, `MindimageSenjuAttackAction$$ActionStart (ContainsBuffer)`, `MobaOtherPlayerActionManager$$Damaged (TryGetBuf)`, `MobaPlayerActionManager$$AddAbnormalState (ContainsBuffer)`, `MobaPlayerActionManager$$ReceiveAttack (TryGetBuf)`, `MobaPlayerBattleManager$$StartHolyBiblePursuitAttack (ContainsBuffer)`, `NemesisAction$$Damaged (TryGetBuf)`, `NemesisAction$$OnInitialize (ContainsBuffer)`, `PlayerActionManager$$AddAbnormalState (ContainsBuffer)`, `PlayerBattleManager$$StartHolyBiblePursuitAttack (ContainsBuffer)`, `ScoreAttackBossActionManager$$Damaged (TryGetBuf)`

_Raw recovered data (every method item): [trees/PriestSkill.md](../trees/PriestSkill.md) — uid 844_

---

### แอสพิสโซล (AspisSeoul) · uid 845

<img src="../../icons/sk_845.png" width="40" alt="icon"> 
**Type:** Mastery · **Max Lv:** 285 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** พรีเอล · **Client class:** `AspisSeoul` (passive mastery)

> โล่แห่งศรัทธา
> ได้รับผลการลดเปอร์เซ็นต์ความเสียหาย
> ที่มุ่งเป้าไปหาตัวเองแบบถาวร
> และได้รับผลการป้องกันสถานะผิดปกติในบางช่วงเวลา

**How it works**

- Mastery; usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- `NormalAttackAction` looks its buff up and changes how normal attacks run while it is active.
- Buffs:
  - `AspisSeoulBuf`: lasts `((Lv << 1) + lv)` s
- Its effect is applied by client code: `AspisSeoul$$GetRateDamageResist`, `AspisSeoul$$ReceiveSupportEvent` (formulas in the last section).
- Other client code reads this skill (2 lookups; see the last section).

**Buff values** (every recovered field; durations in seconds)

**Buff `AspisSeoulBuf`**
- **Modifies normal attacks**: `NormalAttackAction` looks this buff up while it builds the normal-attack damage / hit logic.
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Duration: `((Lv << 1) + lv)` s
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0

**In-game level notes**

- Lv255: ถ้าอยู่ในปาร์ตี้จะเพิ่มเปอร์เซ็นต์ต้านทานความเสียหาย ขึ้นอยู่กับจำนวนสมาชิกPTที่รอดชีวิต(สูงสุด 3 คน)  ได้ผลการป้องกันเมื่อฟื้นฟูจากภาวะผิดปกติตามธรรมชาติ และเมื่อเริ่มต่อสู้กับบอส

**Where else this skill takes effect**

- Effect applied in `AspisSeoul$$ReceiveSupportEvent` (3 guarded paths):
  - when `SkillLv(845) ge 1`
    - returns `SkillBufferManager.ContainsBuffer(PlayerStatusBase.get_SkillBufferManager(), 231, 0, ?x3)`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `SkillLv(845) ge 1`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `RecoveryBuf$$CreateAspisSeoulBuf`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferManager$$AddSelfBuffer`
  - when `SkillLv(845) lt 1`
    - returns `SkillLv(845)`
    - calls `virtual PlayerStatusBase.get_SkillManager`
- Effect applied in `AspisSeoul$$GetRateDamageResist` (2 guarded paths):
  - when `SkillLv(845) ge 1`
    - returns `(((System.Linq.Enumerable.Count<object>(System.Linq.Enumerable.Where<object>(BattleMemberManager.GetBattleMemberList([Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3)+0x28], 0, ?x2, ?x3), meta(0), meta(0x39a0cc8, Method$System.Linq.Enumerable.Where<BattleMemberData>()), ?x3), meta(0x3994ca8, Method$System.Linq.Enumerable.Count<BattleMemberData>()), ?x2, ?x3) lt 3 ? System.Linq.Enumerable.Count<object>(System.Linq.Enumerable.Where<object>(BattleMemberManager.GetBattleMemberList([Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3)+0x28], 0, ?x2, ?x3), meta(0), meta(0x39a0cc8, Method$System.Linq.Enumerable.Where<BattleMemberData>()), ?x3), meta(0x3994ca8, Method$System.Linq.Enumerable.Count<BattleMemberData>()), ?x2, ?x3) : 3) * int((SkillLv(845) * 0.5))) + SkillLv(845))`
    - calls `AspisSeoul$$CheckResistTarget`, `Singleton<object>$$get_Instance`, `BattleMemberManager$$GetBattleMemberList`, `System.Linq.Enumerable$$Where<object>`, `System.Linq.Enumerable$$Count<object>`
  - when `SkillLv(845) lt 1`
    - returns `0`
    - calls `AspisSeoul$$CheckResistTarget`
- Code that reads this skill's level / buff by constant id: `AspisSeoul$$GetRateDamageResist (GetSkillLv)`, `AspisSeoul$$ReceiveSupportEvent (GetSkillLv)`

_Raw recovered data (every method item): [trees/PriestSkill.md](../trees/PriestSkill.md) — uid 845_

---

### คำสอนศักดิ์สิทธิ์ (SacredTeachings) · uid 846

<img src="../../icons/sk_846.png" width="40" alt="icon"> 
**Type:** Mastery · **Max Lv:** 285 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ไฮเนสฮีล · **Client class:** `SacredTeachings` (passive mastery)

> เมื่อใช้สกิลฟื้นฟูจะได้รับHPชั่วคราว
> ที่เกินกว่าค่าHPสูงสุดในปัจจุบัน(*)
> เมื่อได้รับHPชั่วคราวATKและMATK
> จะเพิ่มขึ้นเล็กน้อยตามค่านั้น

**How it works**

- Mastery; usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Buffs:
  - `CountBufferBase`
  - `SacredTeachingsBuf`
- Its effect is applied by client code: `SacredTeachings$$ReceiveHpHeal` (formulas in the last section).
- Other client code reads this skill (1 lookup; see the last section).

**Buff values** (every recovered field; durations in seconds)

**Buff `CountBufferBase`**
- Attached to this skill via `caller2:SacredTeachingsBuf$$.ctor<-SacredTeachings$$ReceiveEventSupport` (no direct constructor call in the skill's own code).
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
**Buff `SacredTeachingsBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `AddOverHeal`, `Damage`, `SetOverHeal`, `UpdateCount`
- `Value2` = `localOverHealValue` _(when BuffEffectActive ne 0; (id - 54) hs 2)_
- `Value` = `overHealValue` _(when BuffEffectActive ne 0; (id - 54) hs 2)_
- Buff fields set in the constructor (all recovered):
  - `MaxOverHealValue` = `(Lv * 1000)` → Lv1..10 [1000, 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000, 10000]
- Hook `AddOverHeal`: `overHealValue`=(max((0x1869f - maxHp), 0) lt (MaxOverHealValue lt (overHealValue + healValue) ? MaxOverHealValue : (overHealValue + healValue)) ? max((0x1869f - maxHp), 0) : (MaxOverHealValue lt (overHealValue + healValue) ? MaxOverHealValue : (overHealValue + healValue))); `Count`=(?ccmp lt 0 ? int((((max((0x1869f - maxHp), 0) lt (MaxOverHealValue lt (overHealValue + healValue) ? MaxOverHealValue : (overHealValue + healValue)) ? max((0x1869f - maxHp), 0) : (MaxOverHealValue lt (overHealValue + healValue) ? MaxOverHealValue : (overHealValue + healValue))) / MaxOverHealValue) * 100)) : 1)
- Hook `SetOverHeal`: `overHealValue`=(max((0x1869f - maxHp), 0) lt (MaxOverHealValue lt overHealValue ? MaxOverHealValue : overHealValue) ? max((0x1869f - maxHp), 0) : (MaxOverHealValue lt overHealValue ? MaxOverHealValue : overHealValue)); `localOverHealValue`=(max((0x1869f - maxHp), 0) lt (MaxOverHealValue lt overHealValue ? MaxOverHealValue : overHealValue) ? max((0x1869f - maxHp), 0) : (MaxOverHealValue lt overHealValue ? MaxOverHealValue : overHealValue)); `Count`=(?ccmp lt 0 ? int((((max((0x1869f - maxHp), 0) lt (MaxOverHealValue lt overHealValue ? MaxOverHealValue : overHealValue) ? max((0x1869f - maxHp), 0) : (MaxOverHealValue lt overHealValue ? MaxOverHealValue : overHealValue)) / MaxOverHealValue) * 100)) : 1)
- Hook `Damage`: `localOverHealValue`=(localOverHealValue gt damage ? (localOverHealValue - damage) : 0)
- Hook `UpdateCount`: `Count`=(?ccmp lt 0 ? int(((overHealValue / MaxOverHealValue) * 100)) : 1)

Parameter meanings (inferred from the `SkillBufferId` names):

- `Count`: stack / hit counter
- `Value`: generic value (meaning set by the code that reads the buff)
- `Value2`: second generic value

**In-game level notes**

- Lv255: (*)เมื่อค่าHPสูงสุดรวมกับHPชั่วคราวเกิน 99,999 HPชั่วคราวจะถูกตัดทิ้ง

**Where else this skill takes effect**

- Effect applied in `SacredTeachings$$ReceiveHpHeal` (6 guarded paths):
  - when `SkillLv(846) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-56), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>())) & 1) eq 0`
    - returns `SacredTeachingsBuf.SetOverHeal(0x165db78(meta(0x39aa418, SacredTeachingsBuf_TypeInfo), ?x1, ?x2, ?x3), [supportData+0x34], IPlayerStatusCalculator.get_MaxHp(PlayerStatusBase.get_SecondaryStatus()), 0)`
    - calls `System.Linq.Enumerable$$Contains<Int32Enum>`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db78`, `SacredTeachingsBuf$$.ctor`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferManager$$AddSelfBuffer`, `virtual PlayerStatusBase.get_SecondaryStatus`
  - when `SkillLv(846) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-56), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
    - returns `SacredTeachingsBuf.SetOverHeal(TryGetBuf<object>.out2(), [supportData+0x34], IPlayerStatusCalculator.get_MaxHp(PlayerStatusBase.get_SecondaryStatus()), 0)`
    - calls `System.Linq.Enumerable$$Contains<Int32Enum>`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxHp`, `SacredTeachingsBuf$$SetOverHeal`
  - when `SkillLv(846) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-56), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() eq 0`
    - returns `SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-56), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>()))`
    - calls `System.Linq.Enumerable$$Contains<Int32Enum>`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `SkillLv(846) ge 1` AND `TryGetBuf<object>.out2() ne 0`
    - returns `SacredTeachingsBuf.SetOverHeal(TryGetBuf<object>.out2(), [supportData+0x34], IPlayerStatusCalculator.get_MaxHp(PlayerStatusBase.get_SecondaryStatus()), 0)`
    - calls `System.Linq.Enumerable$$Contains<Int32Enum>`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SecondaryStatus`, `interface IPlayerStatusCalculator.get_MaxHp`, `SacredTeachingsBuf$$SetOverHeal`
  - when `SkillLv(846) ge 1` AND `TryGetBuf<object>.out2() eq 0`
    - returns `SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-56), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>()))`
    - calls `System.Linq.Enumerable$$Contains<Int32Enum>`, `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `SkillLv(846) lt 1`
    - returns `SkillLv(846)`
    - calls `System.Linq.Enumerable$$Contains<Int32Enum>`, `virtual PlayerStatusBase.get_SkillManager`
- Code that reads this skill's level / buff by constant id: `SacredTeachings$$ReceiveHpHeal (GetSkillLv)`

_Raw recovered data (every method item): [trees/PriestSkill.md](../trees/PriestSkill.md) — uid 846_

---

### โฮลี่เกรซ (HolyGrace) · uid 847

<img src="../../icons/sk_847.png" width="40" alt="icon"> 
**Type:** Support · **Max Lv:** 285 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เนเมซิส · **Client class:** `HolyGraceAction`

> สวรรค์ประทานพรให้ผู้บริสุทธิ์และพิพากษาเหล่าอธรรม
> เมื่อพลังชีวิตหมดจะทำให้ปาร์ตี้สามารถรักษาผล
> ของไอเท็มได้หนึ่งครั้งในระยะเวลาที่กำหนด
> นอกจากนี้การใช้ MP ของสกิลที่ถัดจาก
> ผู้ร่ายโฮลี่เกรซจะลดลงครึ่งหนึ่ง

**How it works**

- Support; usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- Buffs:
  - `HolyGraceBuf`: lasts `((Lv + (Lv << 2)) << 1)` s
  - `HolyGraceNextSkillMpHalvingBuf`: lasts `(((Lv << 2) + lv) << 1)` s
  - `NextAttackBufferBase`: marker buff (no parameters; other code tests whether it is present)
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (2 lookups; see the last section).

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `ActionHit` — when the attack connects: 5 call
- `InitializeOthers` — setup used when another player's client replays the action: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 847
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `HolyGraceBuf` — `.ctor(Lv, 1)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): adds the caster's buff of `new HolyGraceBuf` — `AddSelfBuffer(new HolyGraceBuf, Id)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): removes the caster's buff of skill 24 — `RemoveSelfBuffer(24)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): constructs `HolyGraceNextSkillMpHalvingBuf` — `.ctor(Lv)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): adds the caster's buff of `new HolyGraceNextSkillMpHalvingBuf` — `AddSelfBuffer(new HolyGraceNextSkillMpHalvingBuf, 0)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Buff values** (every recovered field; durations in seconds)

**Buff `HolyGraceBuf`**
- Duration: `((Lv + (Lv << 2)) << 1)` s
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
**Buff `HolyGraceNextSkillMpHalvingBuf`**
- Duration: `(((Lv << 2) + lv) << 1)` s
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
**Buff `NextAttackBufferBase`**
- Attached to this skill via `caller2:HolyGraceNextSkillMpHalvingBuf$$.ctor<-HolyGraceAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `Lock`, `Unlock`
- Buff fields set in the constructor (all recovered):
  - `temporaryCount` = `-1` = -1
- Hook `Lock`: `Count`=count; `temporaryCount`=Count
- Hook `Unlock`: `temporaryCount`=-1; `Count`=temporaryCount
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:HolyGraceBuf$$.ctor<-HolyGraceAction$$ActionHit` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

**In-game level notes**

- Lv14: [จะได้รับผลแบบเดียวกันเมื่อใช้อุปกรณ์เวทมนตร์ (หลัก)]  ถ้าผลของ[สกิลที่ใช้ถัดไปจะลดMPที่ใช้ลงครึ่งหนึ่ง] ถูกใช้โดยบัฟสกิลที่กำหนด จะสร้างความเสียหาย ทางเวทให้กับมอนสเตอร์ทุกตัวในการต่อสู้ที่คุณเข้าร่วม

**Where else this skill takes effect**

- Effect applied in `MainPlayer$$PlayerDead` (300 guarded paths, truncated):
  - when `(SkillBufferManager.ContainsBuffer(SkillBufferManager, 847, 0, serverMp) & 1) ne 0` AND `TryGetAutoMember.out3() ne 0` AND `(SkillBufferManager.TryGetBuf<object>(SkillBufferManager, 87, stkp(-88), meta(0x3982890, Method$SkillBufferManager.TryGetBuf<HuntingOneBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
    - returns `?blr`
    - calls `PlayerStatusBase$$UpdateEffectiveDeadItemDuration`, `PlayerDataManager$$GetPlayerDataManager`, `Toram.Common.ArchetypeUid$$get_Id`, `AutoMemberManager$$TryGetAutoMember`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveBuffer`, `HuntingOneActionManager$$OwnerDead`, `Toram.Common.ArchetypeUid$$get_Id`
  - when `(SkillBufferManager.ContainsBuffer(SkillBufferManager, 847, 0, serverMp) & 1) ne 0` AND `TryGetAutoMember.out3() ne 0` AND `(SkillBufferManager.TryGetBuf<object>(SkillBufferManager, 87, stkp(-88), meta(0x3982890, Method$SkillBufferManager.TryGetBuf<HuntingOneBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, MainPlayer.WaitEnable(this, (actDead & 1), ?x2, ?x3), 0, ?x3)`
    - calls `PlayerStatusBase$$UpdateEffectiveDeadItemDuration`, `PlayerDataManager$$GetPlayerDataManager`, `Toram.Common.ArchetypeUid$$get_Id`, `AutoMemberManager$$TryGetAutoMember`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveBuffer`, `HuntingOneActionManager$$OwnerDead`, `Toram.Common.ArchetypeUid$$get_Id`
  - when `(SkillBufferManager.ContainsBuffer(SkillBufferManager, 847, 0, serverMp) & 1) ne 0` AND `TryGetAutoMember.out3() ne 0` AND `(SkillBufferManager.TryGetBuf<object>(SkillBufferManager, 87, stkp(-88), meta(0x3982890, Method$SkillBufferManager.TryGetBuf<HuntingOneBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
    - calls `PlayerStatusBase$$UpdateEffectiveDeadItemDuration`, `PlayerDataManager$$GetPlayerDataManager`, `Toram.Common.ArchetypeUid$$get_Id`, `AutoMemberManager$$TryGetAutoMember`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveBuffer`, `HuntingOneActionManager$$OwnerDead`, `Toram.Common.ArchetypeUid$$get_Id`
  - when `(SkillBufferManager.ContainsBuffer(SkillBufferManager, 847, 0, serverMp) & 1) ne 0` AND `TryGetAutoMember.out3() ne 0` AND `(SkillBufferManager.TryGetBuf<object>(SkillBufferManager, 87, stkp(-88), meta(0x3982890, Method$SkillBufferManager.TryGetBuf<HuntingOneBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
    - returns `?blr`
    - calls `PlayerStatusBase$$UpdateEffectiveDeadItemDuration`, `PlayerDataManager$$GetPlayerDataManager`, `Toram.Common.ArchetypeUid$$get_Id`, `AutoMemberManager$$TryGetAutoMember`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveBuffer`, `HuntingOneActionManager$$OwnerDead`, `Toram.Common.ArchetypeUid$$get_Id`
  - when `(SkillBufferManager.ContainsBuffer(SkillBufferManager, 847, 0, serverMp) & 1) ne 0` AND `TryGetAutoMember.out3() ne 0` AND `(SkillBufferManager.TryGetBuf<object>(SkillBufferManager, 87, stkp(-88), meta(0x3982890, Method$SkillBufferManager.TryGetBuf<HuntingOneBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, MainPlayer.WaitEnable(this, (actDead & 1), ?x2, ?x3), 0, ?x3)`
    - calls `PlayerStatusBase$$UpdateEffectiveDeadItemDuration`, `PlayerDataManager$$GetPlayerDataManager`, `Toram.Common.ArchetypeUid$$get_Id`, `AutoMemberManager$$TryGetAutoMember`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveBuffer`, `HuntingOneActionManager$$OwnerDead`, `Toram.Common.ArchetypeUid$$get_Id`
  - when `(SkillBufferManager.ContainsBuffer(SkillBufferManager, 847, 0, serverMp) & 1) ne 0` AND `TryGetAutoMember.out3() ne 0` AND `(SkillBufferManager.TryGetBuf<object>(SkillBufferManager, 87, stkp(-88), meta(0x3982890, Method$SkillBufferManager.TryGetBuf<HuntingOneBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
    - calls `PlayerStatusBase$$UpdateEffectiveDeadItemDuration`, `PlayerDataManager$$GetPlayerDataManager`, `Toram.Common.ArchetypeUid$$get_Id`, `AutoMemberManager$$TryGetAutoMember`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveBuffer`, `HuntingOneActionManager$$OwnerDead`, `Toram.Common.ArchetypeUid$$get_Id`
  - when `(SkillBufferManager.ContainsBuffer(SkillBufferManager, 847, 0, serverMp) & 1) ne 0` AND `TryGetAutoMember.out3() ne 0` AND `(SkillBufferManager.TryGetBuf<object>(SkillBufferManager, 87, stkp(-88), meta(0x3982890, Method$SkillBufferManager.TryGetBuf<HuntingOneBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
    - returns `?blr`
    - calls `PlayerStatusBase$$UpdateEffectiveDeadItemDuration`, `PlayerDataManager$$GetPlayerDataManager`, `Toram.Common.ArchetypeUid$$get_Id`, `AutoMemberManager$$TryGetAutoMember`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveBuffer`, `HuntingOneActionManager$$OwnerDead`, `Toram.Common.ArchetypeUid$$get_Id`
  - when `(SkillBufferManager.ContainsBuffer(SkillBufferManager, 847, 0, serverMp) & 1) ne 0` AND `TryGetAutoMember.out3() ne 0` AND `(SkillBufferManager.TryGetBuf<object>(SkillBufferManager, 87, stkp(-88), meta(0x3982890, Method$SkillBufferManager.TryGetBuf<HuntingOneBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
    - returns `UnityEngine.MonoBehaviour.StartCoroutine(this, MainPlayer.WaitEnable(this, (actDead & 1), ?x2, ?x3), 0, ?x3)`
    - calls `PlayerStatusBase$$UpdateEffectiveDeadItemDuration`, `PlayerDataManager$$GetPlayerDataManager`, `Toram.Common.ArchetypeUid$$get_Id`, `AutoMemberManager$$TryGetAutoMember`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `SkillBufferManager$$RemoveBuffer`, `HuntingOneActionManager$$OwnerDead`, `Toram.Common.ArchetypeUid$$get_Id`
- Effect applied in `PlayerBattleManager.<HolyGracePursuitAttack>d__148$$MoveNext` (5 guarded paths):
  - when `<HolyGracePursuitAttack>d__148.<>1__state eq 1` AND `SkillLv(847) ge 1`
    - returns `0`
    - set `<>1__state` = `-1`
    - calls `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$get_TargetableMobList`, `System.Collections.Generic.List<object>$$GetEnumerator`, `System.Collections.Generic.List.Enumerator<object>$$MoveNext`, `HolyGracePursuitAttackAction$$CheckHate`, `SkillFactory$$CreateSkill`, `SkillActionBase$$Initialize`, `interface MobActionManagerBase.get_gameObject`
  - when `<HolyGracePursuitAttack>d__148.<>1__state eq 1` AND `SkillLv(847) ge 1`
    - returns `0`
    - set `<>1__state` = `-1`
    - calls `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$get_TargetableMobList`, `System.Collections.Generic.List<object>$$GetEnumerator`, `System.Collections.Generic.List.Enumerator<object>$$MoveNext`, `HolyGracePursuitAttackAction$$CheckHate`, `SkillFactory$$CreateSkill`, `System.Collections.Generic.List.Enumerator<object>$$Dispose`
  - when `<HolyGracePursuitAttack>d__148.<>1__state eq 1` AND `SkillLv(847) ge 1`
    - set `<>1__state` = `-1`
    - calls `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$get_TargetableMobList`, `System.Collections.Generic.List<object>$$GetEnumerator`, `System.Collections.Generic.List.Enumerator<object>$$MoveNext`, `HolyGracePursuitAttackAction$$CheckHate`, `System.Collections.Generic.List.Enumerator<object>$$MoveNext`, `HolyGracePursuitAttackAction$$CheckHate`, `System.Collections.Generic.List.Enumerator<object>$$MoveNext`
  - when `<HolyGracePursuitAttack>d__148.<>1__state eq 1` AND `SkillLv(847) ge 1`
    - returns `0`
    - set `<>1__state` = `-1`
    - calls `TargetableListManagerBase<object>$$get_Instance`, `MobManager$$get_TargetableMobList`, `System.Collections.Generic.List<object>$$GetEnumerator`, `System.Collections.Generic.List.Enumerator<object>$$MoveNext`, `System.Collections.Generic.List.Enumerator<object>$$Dispose`
  - when `<HolyGracePursuitAttack>d__148.<>1__state eq 1` AND `SkillLv(847) lt 1`
    - returns `0`
    - set `<>1__state` = `-1`
- Code that reads this skill's level / buff by constant id: `MainPlayer$$PlayerDead (ContainsBuffer)`, `PlayerBattleManager.<HolyGracePursuitAttack>d__148$$MoveNext (GetSkillLv)`

_Raw recovered data (every method item): [trees/PriestSkill.md](../trees/PriestSkill.md) — uid 847_

---
