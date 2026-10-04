# ウィザードスキル (`WizardSkill`) — skill details

15 entries.

### แฟมิเรีย (Familia) · uid 1025

<img src="../../icons/sk_1025.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 1) · **Type:** Special · **Max Lv:** 15 · **Weapons:** Rod, Magictool, SubMagictool · **Flags:** StarGem · **Client class:** `FamiliaAction`

> เรียกปีศาจรับใช้ออกมา ระหว่างการเรียก
> MATK กับ MP สูงสุด และเวทไล่โจมตีจะเพิ่มขึ้นเล็กน้อย
> ถ้าข้ารับใช้โดนโจมตีอาจจะหนีไปได้

**How it works**

- Special skill of the ウィザードスキル tree (tier 1, max Lv 15); usable with Rod, Magictool, SubMagictool.
- It installs a buff on the caster.
- Buffs:
  - `FamiliaBuf`; Lv1 → Lv10: Value (generic value (meaning set by the code that reads the buff)) 5 → 50
- Other client code reads this skill (12 lookups; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0.1, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1025
- No proration slot: ExpType None: no proration slot.

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0.1, PlayerActionManagerBase.get_PlayerStatus())`

**Buff values** (every recovered field; durations in seconds)

**Buff `FamiliaBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `BufferEnd`
- `MatkUp` = `(((int((Lv * 2.5))) * (status).Lv) // 100)` _(when BuffEffectActive ne 0)_
- `MaxMpUp` = `maxMp` _(when BuffEffectActive ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |

- Buff fields set in the constructor (all recovered):
  - `status` = `status`
  - `matkUpRate` = `int((Lv * 2.5))` → Lv1..10 [2, 5, 7, 10, 12, 15, 17, 20, 22, 25]
  - `magicPursuitAttackRate` = `(Lv + (Lv << 2))` → Lv1..10 [5, 10, 15, 20, 25, 30, 35, 40, 45, 50]
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0

Parameter meanings (inferred from the `SkillBufferId` names):

- `MatkUp`: MATK +
- `MaxMpUp`: max MP +
- `Value`: generic value (meaning set by the code that reads the buff)

**Where else this skill takes effect**

- Effect applied in `PlayerBattleManager$$PursuitAttack` (191 guarded paths):
  - always
    - returns `PlayerBattleManager.EquipBuffAttack(this, 154, 0x165da68(targetActManager, meta(0x3973fb8, MobActionManagerBase_TypeInfo), ?x2, ?x3), ?x3)`
    - calls `System.Linq.Enumerable$$Any<object>`, `0x165da68`, `interface MobActionManagerBase.get_SystemInvincible`, `virtual SkillActionBase.get_ActionID`, `NormalAttackAction$$IsNormalAttack`, `EquipBuffManager$$IsEquipBuff`, `EquipBuffManager$$CalcBuff`, `EquipBuffManager$$IsEquipBuff`
  - always
    - returns `UnityEngine.Object.op_Equality([mainTargetData+0x18], MobActionManagerBase.get_gameObject(0x165da68(targetActManager, meta(0x3973fb8, MobActionManagerBase_TypeInfo), ?x2, ?x3)), 0, ?x3)`
    - calls `System.Linq.Enumerable$$Any<object>`, `0x165da68`, `interface MobActionManagerBase.get_SystemInvincible`, `virtual SkillActionBase.get_ActionID`, `NormalAttackAction$$IsNormalAttack`, `EquipBuffManager$$IsEquipBuff`, `EquipBuffManager$$CalcBuff`, `EquipBuffManager$$IsEquipBuff`
  - always
    - returns `MathUtil.CheckPercent(((CharacterActionManagerBase.get_Size() + 25) + [[TryGetValue.out2()+0x10]+0x18]), 0, ?x2, ?x3)`
    - calls `System.Linq.Enumerable$$Any<object>`, `0x165da68`, `interface MobActionManagerBase.get_SystemInvincible`, `virtual SkillActionBase.get_ActionID`, `NormalAttackAction$$IsNormalAttack`, `EquipBuffManager$$IsEquipBuff`, `EquipBuffManager$$CalcBuff`, `EquipBuffManager$$IsEquipBuff`
  - always
    - returns `PlayerBattleManager.EquipBuffAttack(this, 154, 0x165da68(targetActManager, meta(0x3973fb8, MobActionManagerBase_TypeInfo), ?x2, ?x3), ?x3)`
    - calls `System.Linq.Enumerable$$Any<object>`, `0x165da68`, `interface MobActionManagerBase.get_SystemInvincible`, `virtual SkillActionBase.get_ActionID`, `NormalAttackAction$$IsNormalAttack`, `EquipBuffManager$$IsEquipBuff`, `EquipBuffManager$$CalcBuff`, `EquipBuffManager$$IsEquipBuff`
  - always
    - returns `UnityEngine.Object.op_Equality([mainTargetData+0x18], MobActionManagerBase.get_gameObject(0x165da68(targetActManager, meta(0x3973fb8, MobActionManagerBase_TypeInfo), ?x2, ?x3)), 0, ?x3)`
    - calls `System.Linq.Enumerable$$Any<object>`, `0x165da68`, `interface MobActionManagerBase.get_SystemInvincible`, `virtual SkillActionBase.get_ActionID`, `NormalAttackAction$$IsNormalAttack`, `EquipBuffManager$$IsEquipBuff`, `EquipBuffManager$$CalcBuff`, `EquipBuffManager$$IsEquipBuff`
  - always
    - returns `MathUtil.CheckPercent((CharacterActionManagerBase.get_Size() + 25), 0, ?x2, ?x3)`
    - calls `System.Linq.Enumerable$$Any<object>`, `0x165da68`, `interface MobActionManagerBase.get_SystemInvincible`, `virtual SkillActionBase.get_ActionID`, `NormalAttackAction$$IsNormalAttack`, `EquipBuffManager$$IsEquipBuff`, `EquipBuffManager$$CalcBuff`, `EquipBuffManager$$IsEquipBuff`
  - always
    - calls `System.Linq.Enumerable$$Any<object>`, `0x165da68`, `interface MobActionManagerBase.get_SystemInvincible`, `virtual SkillActionBase.get_ActionID`, `NormalAttackAction$$IsNormalAttack`, `EquipBuffManager$$IsEquipBuff`, `EquipBuffManager$$CalcBuff`, `EquipBuffManager$$IsEquipBuff`
  - always
    - returns `PlayerBattleManager.EquipBuffAttack(this, 154, 0x165da68(targetActManager, meta(0x3973fb8, MobActionManagerBase_TypeInfo), ?x2, ?x3), ?x3)`
    - calls `System.Linq.Enumerable$$Any<object>`, `0x165da68`, `interface MobActionManagerBase.get_SystemInvincible`, `virtual SkillActionBase.get_ActionID`, `NormalAttackAction$$IsNormalAttack`, `EquipBuffManager$$IsEquipBuff`, `EquipBuffManager$$CalcBuff`, `EquipBuffManager$$IsEquipBuff`
- Effect applied in `BlizzardAction$$IsFailure` (3 guarded paths):
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
  - always
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
- Effect applied in `CrystalLaserAction$$IsFailure` (3 guarded paths):
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
  - always
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
- Effect applied in `HighFamiliaAction$$IsFailure` (2 guarded paths):
  - when `SkillLv(1025) gt 0`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `PlayerAttackBase$$IsFailure`
  - when `SkillLv(1025) le 0`
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillManager`
- Effect applied in `LightningAction$$IsFailure` (3 guarded paths):
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
  - always
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
- Effect applied in `ManaCrystalAction$$IsFailure` (3 guarded paths):
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
  - always
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
- Effect applied in `MeteorStrikeAction$$IsFailure` (3 guarded paths):
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
  - always
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
- Effect applied in `StoneSkinAction$$IsFailure` (5 guarded paths):
  - always
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerAttackBase.get_ActionID`
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$IsFailure`
  - always
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - always
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerAttackBase.get_ActionID`
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$IsFailure`
- Effect applied in `SkillBufferManager$$AlignLearningSkillBuffer` (117 guarded paths):
  - when `SkillManager.GetSkillLv(CharacterActionManagerBase.get_IsDeadOrLocalDead(), ?stack, 1, 0) ge 1` AND `SkillLv(1025) le 0` AND `SkillManager.GetSkillLv(CharacterActionManagerBase.get_IsDeadOrLocalDead(), ?stack, 1, 0) ge 1` AND `SkillLv(1025) le 0`
    - calls `0x165db78`, `System.Collections.Generic.List<Int32Enum>$$.ctor`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`
  - when `SkillManager.GetSkillLv(CharacterActionManagerBase.get_IsDeadOrLocalDead(), ?stack, 1, 0) ge 1` AND `SkillLv(1025) le 0` AND `SkillManager.GetSkillLv(CharacterActionManagerBase.get_IsDeadOrLocalDead(), ?stack, 1, 0) ge 1` AND `SkillLv(1025) le 0`
    - calls `0x165db78`, `System.Collections.Generic.List<Int32Enum>$$.ctor`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`
  - when `SkillManager.GetSkillLv(CharacterActionManagerBase.get_IsDeadOrLocalDead(), ?stack, 1, 0) ge 1` AND `SkillLv(1025) le 0` AND `SkillManager.GetSkillLv(CharacterActionManagerBase.get_IsDeadOrLocalDead(), ?stack, 1, 0) ge 1` AND `SkillLv(1025) le 0`
    - calls `0x165db78`, `System.Collections.Generic.List<Int32Enum>$$.ctor`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`
  - when `SkillManager.GetSkillLv(CharacterActionManagerBase.get_IsDeadOrLocalDead(), ?stack, 1, 0) ge 1` AND `SkillLv(1025) le 0` AND `SkillManager.GetSkillLv(CharacterActionManagerBase.get_IsDeadOrLocalDead(), ?stack, 1, 0) ge 1` AND `SkillLv(1025) le 0`
    - calls `0x165db78`, `System.Collections.Generic.List<Int32Enum>$$.ctor`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`
  - when `SkillManager.GetSkillLv(CharacterActionManagerBase.get_IsDeadOrLocalDead(), ?stack, 1, 0) ge 1` AND `SkillLv(1025) le 0` AND `SkillManager.GetSkillLv(CharacterActionManagerBase.get_IsDeadOrLocalDead(), ?stack, 1, 0) ge 1` AND `SkillLv(1025) le 0`
    - calls `0x165db78`, `System.Collections.Generic.List<Int32Enum>$$.ctor`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `System.Collections.Generic.List<Int32Enum>$$AddWithResize`
  - when `SkillManager.GetSkillLv(CharacterActionManagerBase.get_IsDeadOrLocalDead(), ?stack, 1, 0) ge 1` AND `SkillLv(1025) le 0` AND `SkillManager.GetSkillLv(CharacterActionManagerBase.get_IsDeadOrLocalDead(), ?stack, 1, 0) ge 1` AND `SkillLv(1025) le 0`
    - calls `0x165db78`, `System.Collections.Generic.List<Int32Enum>$$.ctor`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `System.Collections.Generic.List<Int32Enum>$$AddWithResize`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`
  - when `SkillManager.GetSkillLv(CharacterActionManagerBase.get_IsDeadOrLocalDead(), ?stack, 1, 0) ge 1` AND `SkillLv(1025) le 0` AND `SkillManager.GetSkillLv(CharacterActionManagerBase.get_IsDeadOrLocalDead(), ?stack, 1, 0) ge 1` AND `SkillLv(1025) le 0`
    - calls `0x165db78`, `System.Collections.Generic.List<Int32Enum>$$.ctor`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `System.Collections.Generic.List<Int32Enum>$$AddWithResize`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`
  - when `SkillManager.GetSkillLv(CharacterActionManagerBase.get_IsDeadOrLocalDead(), ?stack, 1, 0) ge 1` AND `SkillLv(1025) le 0` AND `SkillManager.GetSkillLv(CharacterActionManagerBase.get_IsDeadOrLocalDead(), ?stack, 1, 0) ge 1` AND `SkillLv(1025) le 0`
    - calls `0x165db78`, `System.Collections.Generic.List<Int32Enum>$$.ctor`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `System.Collections.Generic.List<Int32Enum>$$AddWithResize`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`
- Code that reads this skill's level / buff by constant id: `BlizzardAction$$IsFailure (ContainsBuffer)`, `CrystalLaserAction$$IsFailure (ContainsBuffer)`, `GameManager$$ReceiveSummons (GetSkillLv)`, `HighFamiliaAction$$IsFailure (GetSkillLv)`, `LightningAction$$IsFailure (ContainsBuffer)`, `ManaCrystalAction$$IsFailure (ContainsBuffer)`, `MeteorStrikeAction$$IsFailure (ContainsBuffer)`, `PlayerBattleManager$$PursuitAttack (ContainsBuffer)`, `SkillBufferManager$$AlignLearningSkillBuffer (GetSkillLv)`, `StoneSkinAction$$IsFailure (ContainsBuffer)`, `UIExSkillManager$$ExSkillList (GetSkillLv)`, `UISkillTreeManager$$SkillTreeList (GetSkillLv)`

_Raw recovered data (every method item): [trees/WizardSkill.md](../trees/WizardSkill.md) — uid 1025_

---

### มานาคริสตัล (ManaCrystal) · uid 1026

<img src="../../icons/sk_1026.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 1) · **Type:** Support · **Max Lv:** 15 · **Weapons:** Rod, Magictool, SubMagictool · **Requires:** แฟมิเรีย · **Client class:** `ManaCrystalAction`

> คาถาใช้สร้างผลึกที่สามารถฟื้นฟูพลังเวทได้
> ฟื้นฟู MP ได้เล็กน้อยจากการใช้ผลึกที่ปรากฏออกมา
> เวลาใช้สกิลยิ่งอยู่ห่างจากปีศาจรับใช้
> ก็จะใช้เวลาร่ายนานยิ่งขึ้น

**How it works**

- Support skill of the ウィザードスキル tree (tier 1, max Lv 15); usable with Rod, Magictool, SubMagictool.
- It installs a buff on the caster.
- Buffs:
  - `ManaCrystalBuf`
- Other client code reads this skill (5 lookups; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, ((gemCart(1003[2]) * 4) / 100), PlayerActionManagerBase.get_PlayerStatus())`
- **Cast time** (`CastTime`): `(CastTime + CastTime)`
  - when `!PlayerAttackBase.IsBlank(this) AND AutoMemberManager.TryGetAutoMember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager()), (this + 304)) AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager())) ne 0`
- **Range** (`range`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance(1)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionStart` — when the cast starts: 6 set
- `ActionSkillEvent` — on an animation/skill event during the motion: 2 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1026
- No proration slot: ExpType None: no proration slot.

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, ((gemCart(1003[2]) * 4) / 100), PlayerActionManagerBase.get_PlayerStatus())`; `(CastTime + CastTime)` _(when !PlayerAttackBase.IsBlank(this) AND AutoMemberManager.TryGetAutoMember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager()), (this + 304)) AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager())) ne 0)_
- **Range** (`range`): `MathUtil.DisplayMeterToDistance(1)`; `MathUtil.DisplayMeterToDistance(1)`

**Buff values** (every recovered field; durations in seconds)

**Buff `ManaCrystalBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `Clear`, `GetBufferEffectTakeId`, `HitCrystalLaser`, `OnCall`, `ReRegistration`, `Registration`, `Remove`, `RemoveOverPlace`, `StartCrystalLaser`, `TakenManaCrystal`
- `Count` = `System.Collections.Generic.Dictionary<int, object>.get_Count((new System.Collections.Generic.Dictionary<int, ManaCrystalBuf.Invoker>), meta(0x39aa0b8, Method$System.Collections.Generic.Dictionary<int, ManaCrystalBuf.Invoker>.get_Count()))` _(when BuffEffectActive ne 0)_
- `Count` = `0` _(when BuffEffectActive eq 0)_
- Buff fields set in the constructor (all recovered):
  - `invokers` = `new System.Collections.Generic.Dictionary<int, ManaCrystalBuf.Invoker>`
  - `player` = `PlayerDataManager.GetPlayerDataManager()`
- Hook `Registration`: `currentInvoker`=0

Parameter meanings (inferred from the `SkillBufferId` names):

- `Count`: stack / hit counter

**Where else this skill takes effect**

- Effect applied in `CrystalLaserAction$$ActionStart` (9 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `costMp ne 0`
    - returns `0x165d8dc(this, 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
    - set `attackDir` = `((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3) - crystalPos) / fsqrt((((?v2 - +0x140) * (?v2 - +0x140)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transfo`
    - set `+0x154` = `((?v1 - +0x13c) / fsqrt((((?v2 - +0x140) * (?v2 - +0x140)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3) - crystalPos) * (UnityEngine.Transform.get_position(UnityEngine.GameO`
    - set `+0x158` = `((?v2 - +0x140) / fsqrt((((?v2 - +0x140) * (?v2 - +0x140)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3) - crystalPos) * (UnityEngine.Transform.get_position(UnityEngine.GameO`
    - set `target` = `target`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - set `SkillIndividualFlag` = `-1`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `ManaCrystalBuf$$StartCrystalLaser`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `costMp eq 0`
    - returns `SkillLinkedTake.CreateNextTake([0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)+0x20], 0x11e82ec8, 0, ?x3)`
    - set `attackDir` = `((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3) - crystalPos) / fsqrt((((?v2 - +0x140) * (?v2 - +0x140)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transfo`
    - set `+0x154` = `((?v1 - +0x13c) / fsqrt((((?v2 - +0x140) * (?v2 - +0x140)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3) - crystalPos) * (UnityEngine.Transform.get_position(UnityEngine.GameO`
    - set `+0x158` = `((?v2 - +0x140) / fsqrt((((?v2 - +0x140) * (?v2 - +0x140)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target, 0, ?x2, ?x3), 0, ?x2, ?x3) - crystalPos) * (UnityEngine.Transform.get_position(UnityEngine.GameO`
    - set `target` = `target`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `ManaCrystalBuf$$StartCrystalLaser`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `costMp ne 0`
    - returns `0x165d8dc(this, 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
    - set `attackDir` = `meta(0)`
    - set `+0x154` = `[meta(0)+0x8]`
    - set `+0x158` = `meta(0)`
    - set `target` = `target`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - set `SkillIndividualFlag` = `-1`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `ManaCrystalBuf$$StartCrystalLaser`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `costMp eq 0`
    - returns `SkillLinkedTake.CreateNextTake([0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)+0x20], 0x11e82ec8, 0, ?x3)`
    - set `attackDir` = `meta(0)`
    - set `+0x154` = `[meta(0)+0x8]`
    - set `+0x158` = `meta(0)`
    - set `target` = `target`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `ManaCrystalBuf$$StartCrystalLaser`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `costMp ne 0`
    - returns `0x165d8dc(this, 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
    - set `failure` = `1`
    - set `target` = `target`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - set `SkillIndividualFlag` = `-1`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `ManaCrystalBuf$$StartCrystalLaser`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `costMp eq 0`
    - returns `SkillLinkedTake.CreateNextTake([0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)+0x20], 0x11e82ec8, 0, ?x3)`
    - set `failure` = `1`
    - set `target` = `target`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `ManaCrystalBuf$$StartCrystalLaser`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165db84`, `0x165df00`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-40), 0) & 1) eq 0` AND `costMp ne 0`
    - returns `0x165d8dc(this, 0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3), ?x2, ?x3)`
    - set `failure` = `1`
    - set `target` = `target`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - set `SkillIndividualFlag` = `-1`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- Effect applied in `CrystalLaserAction$$OnEnd` (3 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `ManaCrystalBuf.HitCrystalLaser(TryGetBuf.out2(), 0, ?x2, ?x3)`
    - calls `PlayerAttackBase$$OnEnd`, `ManaCrystalBuf$$HitCrystalLaser`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `PlayerAttackBase$$OnEnd`, `0x165db84`, `0x165df00`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-40), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-40), 0)`
    - calls `PlayerAttackBase$$OnEnd`
- Effect applied in `CrystalLaserAction$$ActionSkillEvent` (54 guarded paths):
  - when `param eq 102` AND `MobaMode ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-168), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `ManaCrystalBuf.HitCrystalLaser(TryGetBuf.out2(), 0, ?x2, ?x3)`
    - calls `0x165db78`, `System.Collections.Generic.List<object>$$.ctor`, `Singleton<object>$$get_Instance`, `PartyManager$$get_IsParty`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `MathUtil$$IsCapsuleAndSphereHit`
  - when `param eq 102` AND `MobaMode ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-168), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `0x165db78`, `System.Collections.Generic.List<object>$$.ctor`, `Singleton<object>$$get_Instance`, `PartyManager$$get_IsParty`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `MathUtil$$IsCapsuleAndSphereHit`
  - when `param eq 102` AND `MobaMode ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-168), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-168), 0)`
    - calls `0x165db78`, `System.Collections.Generic.List<object>$$.ctor`, `Singleton<object>$$get_Instance`, `PartyManager$$get_IsParty`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `MathUtil$$IsCapsuleAndSphereHit`
  - when `param eq 102` AND `MobaMode ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-168), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `ManaCrystalBuf.HitCrystalLaser(TryGetBuf.out2(), 0, ?x2, ?x3)`
    - calls `0x165db78`, `System.Collections.Generic.List<object>$$.ctor`, `Singleton<object>$$get_Instance`, `PartyManager$$get_IsParty`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `MathUtil$$IsCapsuleAndSphereHit`
  - when `param eq 102` AND `MobaMode ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-168), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `0x165db78`, `System.Collections.Generic.List<object>$$.ctor`, `Singleton<object>$$get_Instance`, `PartyManager$$get_IsParty`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `MathUtil$$IsCapsuleAndSphereHit`
  - when `param eq 102` AND `MobaMode ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-168), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-168), 0)`
    - calls `0x165db78`, `System.Collections.Generic.List<object>$$.ctor`, `Singleton<object>$$get_Instance`, `PartyManager$$get_IsParty`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `MathUtil$$IsCapsuleAndSphereHit`
  - when `param eq 102` AND `MobaMode ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-168), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `ManaCrystalBuf.HitCrystalLaser(TryGetBuf.out2(), 0, ?x2, ?x3)`
    - calls `0x165db78`, `System.Collections.Generic.List<object>$$.ctor`, `Singleton<object>$$get_Instance`, `PartyManager$$get_IsParty`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `MathUtil$$IsCapsuleAndSphereHit`
  - when `param eq 102` AND `MobaMode ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-168), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `0x165db78`, `System.Collections.Generic.List<object>$$.ctor`, `Singleton<object>$$get_Instance`, `PartyManager$$get_IsParty`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `MathUtil$$IsCapsuleAndSphereHit`
- Effect applied in `PlayerBattleManager$$StartCatsDropItem` (96 guarded paths):
  - when `SkillLv(1026) ge 1` AND `TryGetValue.out2() ne 0`
    - returns `?blr`
    - calls `0x165db78`, `System.Collections.Generic.List<int>$$.ctor`, `virtual PlayerAttackBase.get_ActionID`, `System.Collections.Generic.List<int>$$Contains`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `virtual CharacterActionManagerBase.get_Size`, `MathUtil$$CheckPercent`, `0x165db78`
  - when `SkillLv(1026) ge 1` AND `TryGetValue.out2() ne 0`
    - returns `MathUtil.CheckPercent(CharacterActionManagerBase.get_Size(), 0, ?mi, ?x3)`
    - calls `0x165db78`, `System.Collections.Generic.List<int>$$.ctor`, `virtual PlayerAttackBase.get_ActionID`, `System.Collections.Generic.List<int>$$Contains`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `virtual CharacterActionManagerBase.get_Size`, `MathUtil$$CheckPercent`
  - when `SkillLv(1026) ge 1` AND `TryGetValue.out2() eq 0`
    - calls `0x165db78`, `System.Collections.Generic.List<int>$$.ctor`, `virtual PlayerAttackBase.get_ActionID`, `System.Collections.Generic.List<int>$$Contains`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `0x165db84`, `0x165df00`
  - when `SkillLv(1026) ge 1`
    - returns `EquipItemData.WeaponTypeCalculatorBase.get_WeaponType([?blr+0x18], 0, ?x2, ?x3)`
    - calls `0x165db78`, `System.Collections.Generic.List<int>$$.ctor`, `virtual PlayerAttackBase.get_ActionID`, `System.Collections.Generic.List<int>$$Contains`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`
  - when `SkillLv(1026) ge 1`
    - returns `System.Collections.Generic.Dictionary<Int32Enum, object>.TryGetValue([?blr+0x68], 1037, stkp(-56), meta(0x3974490, Method$System.Collections.Generic.Dictionary<SkillId, SkillMasteryBase>.TryGetValue()))`
    - calls `0x165db78`, `System.Collections.Generic.List<int>$$.ctor`, `virtual PlayerAttackBase.get_ActionID`, `System.Collections.Generic.List<int>$$Contains`
  - when `SkillLv(1026) lt 1`
    - returns `SkillLv(1026)`
    - calls `0x165db78`, `System.Collections.Generic.List<int>$$.ctor`, `virtual PlayerAttackBase.get_ActionID`, `System.Collections.Generic.List<int>$$Contains`
  - when `SkillLv(1026) ge 1` AND `TryGetValue.out2() ne 0`
    - returns `?blr`
    - calls `0x165db78`, `System.Collections.Generic.List<int>$$.ctor`, `System.Collections.Generic.List<int>$$AddWithResize`, `virtual PlayerAttackBase.get_ActionID`, `System.Collections.Generic.List<int>$$Contains`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `virtual CharacterActionManagerBase.get_Size`, `MathUtil$$CheckPercent`
  - when `SkillLv(1026) ge 1` AND `TryGetValue.out2() ne 0`
    - returns `MathUtil.CheckPercent(CharacterActionManagerBase.get_Size(), 0, ?mi, ?x3)`
    - calls `0x165db78`, `System.Collections.Generic.List<int>$$.ctor`, `System.Collections.Generic.List<int>$$AddWithResize`, `virtual PlayerAttackBase.get_ActionID`, `System.Collections.Generic.List<int>$$Contains`, `EquipItemData.WeaponTypeCalculatorBase$$get_WeaponType`, `virtual CharacterActionManagerBase.get_Size`, `MathUtil$$CheckPercent`
- Code that reads this skill's level / buff by constant id: `CrystalLaserAction$$ActionSkillEvent (GetSkillLv)`, `CrystalLaserAction$$ActionSkillEvent (TryGetBuf)`, `CrystalLaserAction$$ActionStart (TryGetBuf)`, `CrystalLaserAction$$OnEnd (TryGetBuf)`, `PlayerBattleManager$$StartCatsDropItem (GetSkillLv)`

_Raw recovered data (every method item): [trees/WizardSkill.md](../trees/WizardSkill.md) — uid 1026_

---

### คาสต์มาสเตอรี่ (CastMastery) · uid 1033

<img src="../../icons/sk_1033.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 15 · **Weapons:** Rod, MainMagictool · **Flags:** StarGem · **Client class:** `CastMastery` (passive mastery)

> รวบรวมภูมิปัญญาเพื่อเร่งการร่ายเวท
> สูญเสีย ATK เพื่อแลกกับการเพิ่มขึ้นของ CSPD
> ตามสถานะการเรียนรู้ของสกิลจอมเวทย์
> *พลังโจมตีของปีศาจรับใช้ไม่ลดลง

**How it works**

- Mastery skill of the ウィザードスキル tree (tier 1, max Lv 15); usable with Rod, MainMagictool.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): AtkRate (ATK %) 0.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| AtkRate | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 |

- `Cspd` = `(this.allWizardSkillLevel * Lv)`
- `CspdRate` = `((this.learnWizardSkillNum * (Lv >> 1)) + Lv)`

Bonus meanings (inferred from the names):

- `AtkRate`: ATK %
- `Cspd`: cast speed
- `CspdRate`: cast speed %

_Raw recovered data (every method item): [trees/WizardSkill.md](../trees/WizardSkill.md) — uid 1033_

---

### ไลท์นิ่ง (Lightning) · uid 1027

<img src="../../icons/sk_1027.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 2) · **Type:** Object · **Max Lv:** 35 · **Weapons:** Rod, Magictool, SubMagictool · **Requires:** แฟมิเรีย · **Client class:** `LightningAction`

> คำสั่งให้ปีศาจรับใช้เวทสายฟ้า
> โจมตีเป้าหมายด้วยเวทธาตุลม
> มีโอกาสทำให้เป้าหมายติด[อัมพาต]

**How it works**

- Object skill of the ウィザードスキル tree (tier 2, max Lv 35); usable with Rod, Magictool, SubMagictool.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- It places an object in the world (trap, summon or field object).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on live values (formula below); flat damage +80
- Proration: magic proration slot, mode `first_hit_per_target if class check passes`.
- Can inflict on the target: Paralysis (6).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionPreparation` — before the cast starts: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 2 call, 1 info
- `InitializeHighFamilia` — skill-specific method: 2 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 80 | 80 | 80 | 80 | 80 | 80 | 80 | 80 | 80 | 80 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((((Lv * 30) + 400) + HighFamiliaAction.GetLightningPowerUpValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1032, 1))) / 100)`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv * 30) + 400) + HighFamiliaAction.GetLightningPowerUpValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1032, 1))) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `80`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `first_hit_per_target if class check passes`, attack type `Magic`, action id 1027
- Uses the magic proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `1` = 1

**Status ailments**

- Rolls `(Lv + (Lv << 1))`% to inflict **Paralysis (6)** (`calcPlayerToMobDamage`)
- Marks the hit with ailment **Paralysis (6)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 6, (Lv + (Lv << 1)), playerAction)`

**Other recovered parameters**

- **Loop / hit-repeat count** (`LoopParam`): `1` = 1

_Raw recovered data (every method item): [trees/WizardSkill.md](../trees/WizardSkill.md) — uid 1027_

---

### บลิซซาร์ด (Blizzard) · uid 1028

<img src="../../icons/sk_1028.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 2) · **Type:** Object · **Max Lv:** 35 · **Weapons:** Rod, Magictool, SubMagictool · **Requires:** แฟมิเรีย · **Client class:** `BlizzardAction`

> คำสั่งให้ปีศาจรับใช้เวทพายุหิมะโจมตี
> สร้างความเสียหายต่อเนื่องด้วยเวทธาตุน้ำเป็นบริเวณกว้าง
> มีโอกาสทำให้เป้าหมายติด[แช่แข็ง]

**How it works**

- Object skill of the ウィザードスキル tree (tier 2, max Lv 35); usable with Rod, Magictool, SubMagictool.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- It places an object in the world (trap, summon or field object).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on live values (formula below); flat damage +100
- Proration: magic proration slot, mode `first_hit_per_target if class check passes`.
- Can inflict on the target: Freeze (9).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`
- **Attack range** (`attackRange`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance(8)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 8 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionPreparation` — before the cast starts: 1 set
- `ActionStart` — when the cast starts: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 4 tpl, 3 call, 1 info
- `InitializeHighFamilia` — skill-specific method: 2 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((HighFamiliaAction.GetBlizzardPowerUpValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1032, 1)) + ((Lv + (Lv << 2)) + 100))) / 100)`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(target.ExpDefMagic / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((HighFamiliaAction.GetBlizzardPowerUpValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1032, 1)) + ((Lv + (Lv << 2)) + 100))) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `first_hit_per_target if class check passes`, attack type `Magic`, action id 1028
- Uses the magic proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Hit counts**

- Max attacks (`maxAttackCount`): `(int((Lv * 0.3)) + 3)` → Lv1..10 [3, 3, 3, 4, 4, 4, 5, 5, 5, 6]
- Loop / hit-repeat count (`LoopParam`): `1` = 1

**Status ailments**

- Rolls `percent`% to inflict **Freeze (9)** (`calcPlayerToMobDamage`)
- Marks the hit with ailment **Freeze (9)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 9, percent, playerAction)`

**Buffs and effects it installs or removes**

- `calcPlayerToMobDamage` (damage calculation against a monster): adds the buff-provided flat damage to the template — `SetBufferConstantDamage(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), maxAttackCount)`

**Other recovered parameters**

- **Effect percent** (`percent`): `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
- **Attack range** (`attackRange`): `MathUtil.DisplayMeterToDistance(8)`
- **Max attacks** (`maxAttackCount`): `(int((Lv * 0.3)) + 3)` → Lv1..10 [3, 3, 3, 4, 4, 4, 5, 5, 5, 6]
- **Loop / hit-repeat count** (`LoopParam`): `1` = 1

_Raw recovered data (every method item): [trees/WizardSkill.md](../trees/WizardSkill.md) — uid 1028_

---

### คริสตัลเลเซอร์ (CrystalLaser) · uid 1034

<img src="../../icons/sk_1034.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 2) · **Type:** Object · **Max Lv:** 35 · **Weapons:** Rod, MainMagictool · **Requires:** มานาคริสตัล · **Client class:** `CrystalLaserAction`

> ยิงมานาจากมานาคริสตัลเป็นเส้นตรงเพื่อโจมตี
> ฟื้นฟู MP ของสมาชิกปาร์ตี้ในระยะโจมตีเล็กน้อย

**How it works**

- Object skill of the ウィザードスキル tree (tier 2, max Lv 35); usable with Rod, MainMagictool.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It places an object in the world (trap, summon or field object).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×7.3 at Lv1 to 10 at Lv10; flat damage +200
- Proration: magic proration slot, mode `first_hit_per_target`.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionStart` — when the cast starts: 9 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 1 info
- `ActionSkillEvent` — on an animation/skill event during the motion: 6 set, 1 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 7.3 | 7.6 | 7.9 | 8.2 | 8.5 | 8.8 | 9.1 | 9.4 | 9.7 | 10 |
| Flat dmg + | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 |

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[SkillRate]` = `((((Lv * 30) + 700)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetConstant[SkillConstantDamage]` = `(200)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 1034
- Uses the magic proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

_Raw recovered data (every method item): [trees/WizardSkill.md](../trees/WizardSkill.md) — uid 1034_

---

### เมเทโอสตอร์มสไตร์ค (MeteorStrike) · uid 1029

<img src="../../icons/sk_1029.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 3) · **Type:** Object · **Max Lv:** 125 · **Weapons:** Rod, Magictool, SubMagictool · **Requires:** บลิซซาร์ด · **Client class:** `MeteorStrikeAction`

>  คำสั่งให้ปีศาจรับใช้เวทอุกกาบาต
> อุกกาบาต 3 ก้อนจะตกสู่เป้าหมายที่อยู่ใกล้
> มีโอกาสทำให้เป้าหมายติด[ไหม้ไฟ]และ[ตาลาย]
> ขอเตือนว่าความแม่นนั้นขึ้นอยู่กับดวง

**How it works**

- Object skill of the ウィザードスキル tree (tier 3, max Lv 125); usable with Rod, Magictool, SubMagictool.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- It places an object in the world (trap, summon or field object).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on live values (formula below); flat damage +300
- Proration: magic proration slot, mode `first_hit_per_target if class check passes`.
- Can inflict on the target: Ignition (8), Dizzy (14).

**Cost, timing and range**

- **Cast time** (`CastTime`): `1` = 1
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`
- **Attack range** (`attackRange`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance(3)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 11 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionPreparation` — before the cast starts: 2 set
- `NextRangeHit` — next range-hit pass: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 4 tpl, 5 call, 1 info
- `InitializeHighFamilia` — skill-specific method: 4 set
- `SetHideAttack` — skill-specific method: 1 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((HighFamiliaAction.GetMeteorStrikePowerUpValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1032, 1)) + ((Lv * 100) + 500))) / 100)`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(target.ExpDefMagic / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((HighFamiliaAction.GetMeteorStrikePowerUpValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1032, 1)) + ((Lv * 100) + 500))) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(300)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `first_hit_per_target if class check passes`, attack type `Magic`, action id 1029
- Uses the magic proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `status.Luk`
- Loop / hit-repeat count (`LoopParam`): `luk`

**Status ailments**

- Chance field `ignitionPercent` (ailment chance): `((Lv + (Lv << 2)) + 50)` → Lv1..10 [55, 60, 65, 70, 75, 80, 85, 90, 95, 100]
- Chance field `dizzyPercent` (ailment chance): `(Lv + (Lv << 2))` → Lv1..10 [5, 10, 15, 20, 25, 30, 35, 40, 45, 50]
- Rolls `ignitionPercent`% to inflict **Ignition (8)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 8, ignitionPercent, playerAction) AND isSingleShot eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 8, ignitionPercent, playerAction) AND isSingleShot eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 8, ignitionPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND isSingleShot eq 0`
- Marks the hit with ailment **Ignition (8)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 8, ignitionPercent, playerAction) AND isSingleShot eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 8, ignitionPercent, playerAction) AND isSingleShot eq 0`
- Rolls `dizzyPercent`% to inflict **Dizzy (14)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 8, ignitionPercent, playerAction) AND isSingleShot eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 8, ignitionPercent, playerAction) AND isSingleShot eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 8, ignitionPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND isSingleShot eq 0`
- Marks the hit with ailment **Dizzy (14)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 8, ignitionPercent, playerAction) AND isSingleShot eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 8, ignitionPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND isSingleShot eq 0`

**Buffs and effects it installs or removes**

- `calcPlayerToMobDamage` (damage calculation against a monster): adds the buff-provided flat damage to the template — `SetBufferConstantDamage(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), LoopParam)`

**Other recovered parameters**

- **Attack range** (`attackRange`): `MathUtil.DisplayMeterToDistance(3)`
- **Loop / hit-repeat count** (`LoopParam`): `status.Luk`; `luk`
- **Cast time modifier** (`CastTime`): `1` = 1

_Raw recovered data (every method item): [trees/WizardSkill.md](../trees/WizardSkill.md) — uid 1029_

---

### สโตนสกิล (StoneSkin) · uid 1030

<img src="../../icons/sk_1030.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 3) · **Type:** Support · **Max Lv:** 125 · **Weapons:** Rod, Magictool, SubMagictool · **Requires:** มานาคริสตัล · **Client class:** `StoneSkinAction`

>  คำสั่งให้ปีศาจรับใช้เวทป้องกัน
> จะติดบาเรียลดความเสียหายได้ในระดับหนึ่งแต่
> ความเสียหายจากไหม้ไฟและพิษจะเพิ่มมากขึ้น(ข้อเสีย)
> ไม่สามารถใช้ซ้อนกันได้

**How it works**

- Support skill of the ウィザードスキル tree (tier 3, max Lv 125); usable with Rod, Magictool, SubMagictool.
- It installs a buff on the caster.
- Buffs:
  - `StoneSkinBuf`: lasts `time` s

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 1 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1030
- No proration slot: ExpType None: no proration slot.

**Buff values** (every recovered field; durations in seconds)

**Buff `StoneSkinBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `CalcCutDamageValue`, `DamageCut`, `get_BufEffectTakeId`
- Duration: `time` s
- `Value` = `((((Lv * 200) + (mVit << 1)) + 500))` _(when BuffEffectActive ne 0)_
- `Value` = `0` _(when BuffEffectActive eq 0)_
- Buff fields set in the constructor (all recovered):
  - `barrier` = `(((Lv * 200) + (mVit << 1)) + 500)`
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
- Hook `DamageCut`: `barrier`=0; `Count`=Max; `barrier`=(barrier - (damage - 1)); `Count`=System.Math.Min(Max, (Count + (damage - 1)))

Parameter meanings (inferred from the `SkillBufferId` names):

- `Value`: generic value (meaning set by the code that reads the buff)

_Raw recovered data (every method item): [trees/WizardSkill.md](../trees/WizardSkill.md) — uid 1030_

---

### โอเวอร์ลิมิต (OverLimit) · uid 1035

<img src="../../icons/sk_1035.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 3) · **Type:** Buffer · **Max Lv:** 125 · **Weapons:** Rod, MainMagictool · **Requires:** คริสตัลเลเซอร์ · **Client class:** `OverLimitAction`

> เทคนิคลับเพื่อเพิ่มพลังธาตุเป็นเวลา 90 วินาที
> สำหรับทุกพลังธาตุ(เฉพาะเวทมนตร์)ยกเว้นไร้ธาตุ
> แต่ CSPD จะลดลงและ 1% ของ Max HP จะหายไปทุกครั้งที่ร่ายเวท

**How it works**

- Buffer skill of the ウィザードスキル tree (tier 3, max Lv 125); usable with Rod, MainMagictool.
- It installs a buff on the caster.
- Buffs:
  - `OverLimitBuf`; Lv1 → Lv10: CspdUp (cast speed +) -1000 → -1000, Value (generic value (meaning set by the code that reads the buff)) 1 → 10

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 1 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 2 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1035
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): constructs `OverLimitBuf` — `.ctor(Lv, PlayerActionManagerBase.get_PlayerStatus())`
  - when `UnityEngine.Object.op_Inequality(actarAction)`
- `ActionHit` (when the attack connects): adds the caster's buff of `new OverLimitBuf` — `AddSelfBuffer(new OverLimitBuf, 0)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`

**Buff values** (every recovered field; durations in seconds)

**Buff `OverLimitBuf`**
- `CspdUp` = `(SkillMasteryBase.GetMasteryParam(MasteryId.Cspd) - 1000)` _(when BuffEffectActive ne 0)_
- `Value` = `(SkillMasteryBase.GetMasteryParam(MasteryId.Value) + Lv)` _(when BuffEffectActive ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| CspdUp | -1000 | -1000 | -1000 | -1000 | -1000 | -1000 | -1000 | -1000 | -1000 | -1000 |
| Value | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |

- Buff fields set in the constructor (all recovered):
  - `playerStatus` = `status`
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

Parameter meanings (inferred from the `SkillBufferId` names):

- `CspdUp`: cast speed +
- `Value`: generic value (meaning set by the code that reads the buff)

_Raw recovered data (every method item): [trees/WizardSkill.md](../trees/WizardSkill.md) — uid 1035_

---

### อิมพีเรียลเรย์[PN]อิมพีเรียลบลาสท์[PF]อิมพีเรียลไฟร์[PA]อิมพีเรียลฟรีซ[PW]อิมพีเรียลโกลม[PE]อิมพีเรียลเปตรา[PL]อิมพีเรียลโฮลี่[PD]อิมพีเรียลชาโดว์ (ImperialRay) · uid 1031

<img src="../../icons/sk_1031.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 4) · **Type:** Attack · **Max Lv:** 205 · **Weapons:** Rod, Magictool, SubMagictool · **Requires:** เมเทโอสตอร์มสไตร์ค · **Client class:** `ImperialRayAction`

> เทคนิคการโจมตีด้วยการระเบิดพลังเวทมนตร์ที่ถูกบีบอัด
> ถ้าโดนไล่โจมตีด้วยสกิลเฉพาะเช่นสกิลเวทมนตร์
> จะเกิดการระเบิดครั้งใหญ่จากพลังเวท
> การระเบิดครั้งใหญ่จะติดคริติคอลแน่นอน
> ธาตุที่เป็นจุดอ่อนจะติดอ่อนแอ

**How it works**

- Attack skill of the ウィザードスキル tree (tier 4, max Lv 205); usable with Rod, Magictool, SubMagictool.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [(mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0]: skill multiplier ×5.5 at Lv1 to 10 at Lv10; skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage`: flat damage +220 at Lv1 to 400 at Lv10
- Proration: magic proration slot, mode `never (IsExpDefFluctuate=false)`.
- Buffs:
  - `ImperialRayBuf`: marker buff (no parameters; other code tests whether it is present)
- Other client code reads this skill (2 lookups; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 6 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionStart` — when the cast starts: 4 set
- `ActionSkillEvent` — on an animation/skill event during the motion: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 5.5 | 6 | 6.5 | 7 | 7.5 | 8 | 8.5 | 9 | 9.5 | 10 |
| Flat dmg + | 220 | 240 | 260 | 280 | 300 | 320 | 340 | 360 | 380 | 400 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv * 50) + 500) + SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate))) / 100)` — (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv * 50) + 500) + SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate))) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv * 20) + 200))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `never (IsExpDefFluctuate=false)`, attack type `Magic`, action id 1031
- Uses the magic proration slot but never changes monster proration: IsExpDefFluctuate=false.

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`

**Buff values** (every recovered field; durations in seconds)

**Buff `ImperialRayBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `CheckMob`, `RegisterMobUid`, `RemoveMobUid`, `UpdateMobUidList`
- Buff fields set in the constructor (all recovered):
  - `targetMobList` = `new System.Collections.Generic.Dictionary<int, bool>`
  - `timer` = `5` = 5
- Hook `Updata`: `timer`=5; `timer`=(timer - UnityEngine.Time.get_deltaTime())

**Where else this skill takes effect**

- Code that reads this skill's level / buff by constant id: `MobaPlayerBattleManager$$PursuitImperialRayAttack (GetSkillLv)`, `PlayerBattleManager$$PursuitImperialRayAttack (GetSkillLv)`

_Raw recovered data (every method item): [trees/WizardSkill.md](../trees/WizardSkill.md) — uid 1031_

---

### ไฮแฟมิเรีย (HighFamilia) · uid 1032

<img src="../../icons/sk_1032.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 4) · **Type:** Special · **Max Lv:** 205 · **Weapons:** Rod, Magictool, SubMagictool · **Requires:** สโตนสกิล · **Client class:** `HighFamiliaAction`

> อัญเชิญปีศาจรับใช้ ทำให้มันเกิดอารมณ์แปรปรวน
> ร่ายเวทไลท์นิ่ง,บลิซซาร์ด,เมเทโอสตอร์มสไตร์ค
> ออกมาแบบสุ่มชั่วระยะเวลาหนึ่ง
> ประสิทธิภาพของปีศาจรับใช้ สกิลที่ปล่อย
> ะขึ้นอยู่กับระดับการเรียนรู้ของตัวเอง

**How it works**

- Special skill of the ウィザードスキル tree (tier 4, max Lv 205); usable with Rod, Magictool, SubMagictool.
- It installs a buff on the caster.
- Buffs:
  - `HighFamiliaBuf`; Lv1 → Lv10: Value (generic value (meaning set by the code that reads the buff)) 5 → 50
- Other client code reads this skill (12 lookups; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0.1, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 2 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1032
- No proration slot: ExpType None: no proration slot.

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0.1, PlayerActionManagerBase.get_PlayerStatus())`

**Buff values** (every recovered field; durations in seconds)

**Buff `HighFamiliaBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `BufferEnd`
- `MatkUp` = `(((int((Lv * 2.5))) * (status).Lv) // 100)` _(when BuffEffectActive ne 0)_
- `MaxMpUp` = `maxMp` _(when BuffEffectActive ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 5 | 10 | 15 | 20 | 25 | 30 | 35 | 40 | 45 | 50 |

- Buff fields set in the constructor (all recovered):
  - `status` = `status`
  - `matkUpRate` = `int((Lv * 2.5))` → Lv1..10 [2, 5, 7, 10, 12, 15, 17, 20, 22, 25]
  - `magicPursuitAttackRate` = `(Lv + (Lv << 2))` → Lv1..10 [5, 10, 15, 20, 25, 30, 35, 40, 45, 50]
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0

Parameter meanings (inferred from the `SkillBufferId` names):

- `MatkUp`: MATK +
- `MaxMpUp`: max MP +
- `Value`: generic value (meaning set by the code that reads the buff)

**In-game level notes**

- Lv14: [รับเอฟเฟกต์เดียวกันเมื่อใช้กับอุปกรณ์เวทมนตร์] เมื่อระดับสกิลเพิ่มขึ้นพลังของ ไลท์นิ่ง,บลิซซาร์ด,เมเทโอสตอร์มสไตร์คจะเพิ่มขึ้น

**Where else this skill takes effect**

- Effect applied in `PlayerBattleManager$$PursuitAttack` (130 guarded paths):
  - always
    - returns `PlayerBattleManager.EquipBuffAttack(this, 154, 0x165da68(targetActManager, meta(0x3973fb8, MobActionManagerBase_TypeInfo), ?x2, ?x3), ?x3)`
    - calls `System.Linq.Enumerable$$Any<object>`, `0x165da68`, `interface MobActionManagerBase.get_SystemInvincible`, `virtual SkillActionBase.get_ActionID`, `NormalAttackAction$$IsNormalAttack`, `EquipBuffManager$$IsEquipBuff`, `EquipBuffManager$$CalcBuff`, `EquipBuffManager$$IsEquipBuff`
  - always
    - returns `UnityEngine.Object.op_Equality([mainTargetData+0x18], MobActionManagerBase.get_gameObject(0x165da68(targetActManager, meta(0x3973fb8, MobActionManagerBase_TypeInfo), ?x2, ?x3)), 0, ?x3)`
    - calls `System.Linq.Enumerable$$Any<object>`, `0x165da68`, `interface MobActionManagerBase.get_SystemInvincible`, `virtual SkillActionBase.get_ActionID`, `NormalAttackAction$$IsNormalAttack`, `EquipBuffManager$$IsEquipBuff`, `EquipBuffManager$$CalcBuff`, `EquipBuffManager$$IsEquipBuff`
  - always
    - returns `MathUtil.CheckPercent(((CharacterActionManagerBase.get_Size() + 25) + [[TryGetValue.out2()+0x10]+0x18]), 0, ?x2, ?x3)`
    - calls `System.Linq.Enumerable$$Any<object>`, `0x165da68`, `interface MobActionManagerBase.get_SystemInvincible`, `virtual SkillActionBase.get_ActionID`, `NormalAttackAction$$IsNormalAttack`, `EquipBuffManager$$IsEquipBuff`, `EquipBuffManager$$CalcBuff`, `EquipBuffManager$$IsEquipBuff`
  - always
    - returns `PlayerBattleManager.EquipBuffAttack(this, 154, 0x165da68(targetActManager, meta(0x3973fb8, MobActionManagerBase_TypeInfo), ?x2, ?x3), ?x3)`
    - calls `System.Linq.Enumerable$$Any<object>`, `0x165da68`, `interface MobActionManagerBase.get_SystemInvincible`, `virtual SkillActionBase.get_ActionID`, `NormalAttackAction$$IsNormalAttack`, `EquipBuffManager$$IsEquipBuff`, `EquipBuffManager$$CalcBuff`, `EquipBuffManager$$IsEquipBuff`
  - always
    - returns `UnityEngine.Object.op_Equality([mainTargetData+0x18], MobActionManagerBase.get_gameObject(0x165da68(targetActManager, meta(0x3973fb8, MobActionManagerBase_TypeInfo), ?x2, ?x3)), 0, ?x3)`
    - calls `System.Linq.Enumerable$$Any<object>`, `0x165da68`, `interface MobActionManagerBase.get_SystemInvincible`, `virtual SkillActionBase.get_ActionID`, `NormalAttackAction$$IsNormalAttack`, `EquipBuffManager$$IsEquipBuff`, `EquipBuffManager$$CalcBuff`, `EquipBuffManager$$IsEquipBuff`
  - always
    - returns `MathUtil.CheckPercent((CharacterActionManagerBase.get_Size() + 25), 0, ?x2, ?x3)`
    - calls `System.Linq.Enumerable$$Any<object>`, `0x165da68`, `interface MobActionManagerBase.get_SystemInvincible`, `virtual SkillActionBase.get_ActionID`, `NormalAttackAction$$IsNormalAttack`, `EquipBuffManager$$IsEquipBuff`, `EquipBuffManager$$CalcBuff`, `EquipBuffManager$$IsEquipBuff`
  - always
    - calls `System.Linq.Enumerable$$Any<object>`, `0x165da68`, `interface MobActionManagerBase.get_SystemInvincible`, `virtual SkillActionBase.get_ActionID`, `NormalAttackAction$$IsNormalAttack`, `EquipBuffManager$$IsEquipBuff`, `EquipBuffManager$$CalcBuff`, `EquipBuffManager$$IsEquipBuff`
  - always
    - returns `PlayerBattleManager.EquipBuffAttack(this, 154, 0x165da68(targetActManager, meta(0x3973fb8, MobActionManagerBase_TypeInfo), ?x2, ?x3), ?x3)`
    - calls `System.Linq.Enumerable$$Any<object>`, `0x165da68`, `interface MobActionManagerBase.get_SystemInvincible`, `virtual SkillActionBase.get_ActionID`, `NormalAttackAction$$IsNormalAttack`, `EquipBuffManager$$IsEquipBuff`, `EquipBuffManager$$CalcBuff`, `EquipBuffManager$$IsEquipBuff`
- Effect applied in `BlizzardAction$$IsFailure` (2 guarded paths):
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
  - always
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- Effect applied in `CrystalLaserAction$$IsFailure` (2 guarded paths):
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
  - always
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- Effect applied in `LightningAction$$IsFailure` (2 guarded paths):
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
  - always
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- Effect applied in `ManaCrystalAction$$IsFailure` (2 guarded paths):
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
  - always
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- Effect applied in `MeteorStrikeAction$$IsFailure` (2 guarded paths):
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
  - always
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- Effect applied in `StoneSkinAction$$IsFailure` (3 guarded paths):
  - always
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerAttackBase.get_ActionID`
  - always
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$IsFailure`
  - always
    - returns `1`
    - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- Code that reads this skill's level / buff by constant id: `BlizzardAction$$IsFailure (ContainsBuffer)`, `BlizzardAction$$OnInitialize (GetSkillLv)`, `CrystalLaserAction$$IsFailure (ContainsBuffer)`, `FamiliaActionManager$$UpdateHighFamilia (GetSkillLv)`, `LightningAction$$IsFailure (ContainsBuffer)`, `LightningAction$$calcPlayerToMobDamage (GetSkillLv)`, `ManaCrystalAction$$IsFailure (ContainsBuffer)`, `MeteorStrikeAction$$IsFailure (ContainsBuffer)`, `MeteorStrikeAction$$OnInitialize (GetSkillLv)`, `PlayerBattleManager$$PursuitAttack (ContainsBuffer)`, `StoneSkinAction$$IsFailure (ContainsBuffer)`, `UIFamiliarSelectManager$$UpdateRushSwitchButton (GetSkillLv)`

_Raw recovered data (every method item): [trees/WizardSkill.md](../trees/WizardSkill.md) — uid 1032_

---

### ซอร์ดเซอรีไกด์ (MagicalGuidance) · uid 1036

<img src="../../icons/sk_1036.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 4) · **Type:** Mastery · **Max Lv:** 205 · **Weapons:** Rod, MainMagictool · **Requires:** โอเวอร์ลิมิต · **Client class:** `MagicalGuidance` (passive mastery)

> ลดการสูญเสีย CSPD เนื่องจากโอเวอร์ลิมิต
> และเพิ่มพลังธาตุให้มากขึ้น

**How it works**

- Mastery skill of the ウィザードスキル tree (tier 4, max Lv 205); usable with Rod, MainMagictool.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Value (generic value) 1 at Lv1 to 10 at Lv10, Cspd (cast speed) 50 at Lv1 to 500 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| Cspd | 50 | 100 | 150 | 200 | 250 | 300 | 350 | 400 | 450 | 500 |


Bonus meanings (inferred from the names):

- `Value`: generic value
- `Cspd`: cast speed

_Raw recovered data (every method item): [trees/WizardSkill.md](../trees/WizardSkill.md) — uid 1036_

---

### ของที่แมวทำหล่น (CatsDropItem) · uid 1037

<img src="../../icons/sk_1037.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 285 · **Weapons:** Rod, MainMagictool · **Requires:** ไฮแฟมิเรีย · **Client class:** `CatsDropItem` (passive mastery)

> ถ้าเหลือก็ทิ้งไว้เมี๊ยว
> เมื่อปีศาจรับใช้ร่ายเวทสำเร็จ
> มีโอกาสที่สกิล[มานาคริสตัล]จะถูกติดตั้ง

**How it works**

- Mastery skill of the ウィザードスキル tree (tier 5, max Lv 285); usable with Rod, MainMagictool.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Percent (generic percent) 1 at Lv1 to 100 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Percent | 1 | 4 | 9 | 16 | 25 | 36 | 49 | 64 | 81 | 100 |


Bonus meanings (inferred from the names):

- `Percent`: generic percent

_Raw recovered data (every method item): [trees/WizardSkill.md](../trees/WizardSkill.md) — uid 1037_

---

### การวิจัยเวทมนตร์ (MagicResearch) · uid 1038

<img src="../../icons/sk_1038.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 285 · **Weapons:** Rod, Magictool, SubMagictool · **Requires:** [N]อิมพีเรียลเรย์[PN]อิมพีเรียลบลาสท์[PF]อิมพีเรียลไฟร์[PA]อิมพีเรียลฟรีซ[PW]อิมพีเรียลโกลม[PE]อิมพีเรียลเปตรา[PL]อิมพีเรียลโฮลี่[PD]อิมพีเรียลชาโดว์[N] · **Client class:** `MagicResearch` (passive mastery)

> เพิ่มความเข้าใจเวทมนตร์ให้ลึกซึ้งผ่านการวิจัย
> เพิ่มพลังของสกิล[อิมพีเรียลเรย์]
> และลดเวลาที่ปีศาจรับใช้ร่ายเวท

**How it works**

- Mastery skill of the ウィザードスキル tree (tier 5, max Lv 285); usable with Rod, Magictool, SubMagictool.
- It is a passive: while learned it returns stat bonuses from `GetMasteryParam`, no cast is needed.
- Passive modifiers (negative = penalty): Cspd (cast speed) 1 at Lv1 to 10 at Lv10, Value (generic value) 40 at Lv1 to 400 at Lv10, SkillRate (skill multiplier bonus) 20 at Lv1 to 200 at Lv10.

**Passive modifiers by level** (`GetMasteryParam(MasteryId)`; negative = penalty)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Cspd | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| Value | 40 | 80 | 120 | 160 | 200 | 240 | 280 | 320 | 360 | 400 |
| SkillRate | 20 | 40 | 60 | 80 | 100 | 120 | 140 | 160 | 180 | 200 |


Bonus meanings (inferred from the names):

- `Cspd`: cast speed
- `Value`: generic value
- `SkillRate`: skill multiplier bonus

_Raw recovered data (every method item): [trees/WizardSkill.md](../trees/WizardSkill.md) — uid 1038_

---

### ชิฟท์ (Shift) · uid 1039

<img src="../../icons/sk_1039.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 5) · **Type:** Buffer · **Max Lv:** 285 · **Weapons:** Rod, MainMagictool · **Requires:** ซอร์ดเซอรีไกด์ · **Client class:** `ShiftAction`

> ซ่อนตัวในชั้นมิติเพื่อหลบหนีวิกฤต
> ระหว่างชิฟท์จะไม่สามารถโจมตี และสูญเสียMPอย่างต่อเนื่อง
> แต่จะอยู่ในสถานะคงกระพันตลอด
> และลบค่าเฮทของตนเองออกไป
> ไม่สามารถแสดงผลเมื่อตัวเองถูกเล็งเป้า

**How it works**

- Buffer skill of the ウィザードスキル tree (tier 5, max Lv 285); usable with Rod, MainMagictool.
- It installs a buff on the caster.
- MP: `0` (conditional variants below).
- Buffs:
  - `ShiftBuf`: marker buff (no parameters; other code tests whether it is present)
  - `ShiftMotionSpeedBuf`: lasts `min((buf.LeftTime + ((int((((Lv * Lv) / 5) + 0.5)) + 10) * count)), 60)` s
  - `CountBufferBase`
- Other client code reads this skill (17 lookups; see the last section).

**Cost, timing and range**

- **MP cost** (`mp` in `OnInitialize`): `0` = 0
  - when `hasBuff(1039)`
- **MP cost** (`mp` in `OnInitialize`): `200` = 200
  - when `!hasBuff(1039)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ReceiveSupport` — skill-specific method: 5 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1039
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ReceiveSupport` (method): constructs `ShiftBuf` — `.ctor(skillLv, playerAction)`
  - when `UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<FadeAnimationManager>(UnityEngine.Component.get_gameObject(playerAction)), 0) AND resultData.Flag eq 1 AND resultData.Flag ne 2 OR !UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<FadeAnimationManager>(UnityEngine.Component.get_gameObject(playerAction)), 0) AND resultData.Flag eq 1 AND resultData.Flag ne 2`
- `ReceiveSupport` (method): adds the caster's buff of `new ShiftBuf` — `AddSelfBuffer(new ShiftBuf, 0)`
  - when `UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<FadeAnimationManager>(UnityEngine.Component.get_gameObject(playerAction)), 0) AND resultData.Flag eq 1 AND resultData.Flag ne 2 OR !UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<FadeAnimationManager>(UnityEngine.Component.get_gameObject(playerAction)), 0) AND resultData.Flag eq 1 AND resultData.Flag ne 2`
- `ReceiveSupport` (method): constructs `ShiftMotionSpeedBuf` — `.ctor(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1039).Level, SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1039), 20), PlayerActionManagerBase.get_PlayerStatus())`
  - when `SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1039), 20) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1039) ne 0 AND resultData.Flag eq 2`
- `ReceiveSupport` (method): adds the caster's buff of `new ShiftMotionSpeedBuf` — `AddSelfBuffer(new ShiftMotionSpeedBuf, 0)`
  - when `SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1039), 20) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1039) ne 0 AND resultData.Flag eq 2`
- `ReceiveSupport` (method): removes the caster's buff of skill 1039 (Shift) — `RemoveSelfBuffer(1039)`
  - when `SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1039), 20) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1039) ne 0 AND resultData.Flag eq 2 OR SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1039), 20) lt 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1039) ne 0 AND resultData.Flag eq 2`

**Other recovered parameters**

- **MP cost** (`mp`): `0` = 0 _(when hasBuff(1039))_; `200` = 200 _(when !hasBuff(1039))_

**Buff values** (every recovered field; durations in seconds)

**Buff `ShiftBuf`**
- Buff hook methods: `BufferEnd`, `get_EnableDistFade`, `set_EnableDistFade`
- Buff fields set in the constructor (all recovered):
  - `actionManager` = `playerAction`
- Hook `set_EnableDistFade`: `EnableDistFade`=(value & 1)
**Buff `ShiftMotionSpeedBuf`**
- Duration: `min((buf.LeftTime + ((int((((Lv * Lv) / 5) + 0.5)) + 10) * count)), 60)` s
- `MotionSpeed` = `((((((baseINT * 0x51eb851f) >> 32) >> 5) lt 5 ? (((baseINT * 0x51eb851f) >> 32) >> 5) : 5) + 10))`
- Buff fields set in the constructor (all recovered):
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
  - `BufEffectTakeUid` = `-1` = -1
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `motionSpeed` = `(((((baseINT * 0x51eb851f) >> 32) >> 5) lt 5 ? (((baseINT * 0x51eb851f) >> 32) >> 5) : 5) + 10)`
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:ShiftBuf$$.ctor<-ShiftAction$$ReceiveSupport` (no direct constructor call in the skill's own code).
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
- `MotionSpeed`: motion speed +

**In-game level notes**

- Lv14: [จะได้รับผลแบบเดียวกันเมื่อใช้อุปกรณ์เวทมนตร์] ระหว่างชิฟท์ถ้าหลบหลีกความเสียหายจะได้รับ บัฟเพิ่มความเร็วการเคลื่อนที่ตามจำนวนครั้งนั้น(สูงสุด 60 วินาที)

**Where else this skill takes effect**

- Effect applied in `MobaPlayerActionManager$$Damaged` (8 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `?blr`
    - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillDamageData$$Invincibility`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillDamageData$$Invincibility`, `0x165db84`, `0x165df00`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-88), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-88), 0)`
    - calls `EmotionPlayer$$MoveEmotionCancel`, `SkillDamageData$$Invincibility`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `?blr`
    - calls `EmotionPlayer$$MoveEmotionCancel`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `?blr`
    - calls `EmotionPlayer$$MoveEmotionCancel`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-88), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `EmotionPlayer$$MoveEmotionCancel`, `0x165db84`, `0x165df00`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-88), 0) & 1) eq 0`
    - returns `?blr`
    - calls `EmotionPlayer$$MoveEmotionCancel`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-88), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-88), 0)`
    - calls `EmotionPlayer$$MoveEmotionCancel`
- Effect applied in `PlayerActionManager$$Damaged` (17 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 706, stkp(-152), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-152), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-152), 0) & 1) ne 0`
    - returns `ImprovisationSongAction.Damaged(this, 0, ?x2, ?x3)`
    - calls `EmotionPlayer$$MoveEmotionCancel`, `GodHandBuf$$DamageFunction`, `ImprovisationSongAction$$Damaged`
  - when `(SkillBufferManager.TryGetBuf(?blr, 706, stkp(-152), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-152), 0) & 1) ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-152), 0) & 1) eq 0`
    - returns `ImprovisationSongAction.Damaged(this, 0, ?x2, ?x3)`
    - calls `EmotionPlayer$$MoveEmotionCancel`, `ImprovisationSongAction$$Damaged`
  - when `(SkillBufferManager.TryGetBuf(?blr, 706, stkp(-152), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-152), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-152), 0) & 1) ne 0`
    - returns `ImprovisationSongAction.Damaged(this, 0, ?x2, ?x3)`
    - calls `EmotionPlayer$$MoveEmotionCancel`, `GodHandBuf$$DamageFunction`, `ImprovisationSongAction$$Damaged`
  - when `(SkillBufferManager.TryGetBuf(?blr, 706, stkp(-152), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-152), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-152), 0) & 1) eq 0`
    - returns `ImprovisationSongAction.Damaged(this, 0, ?x2, ?x3)`
    - calls `EmotionPlayer$$MoveEmotionCancel`, `ImprovisationSongAction$$Damaged`
  - when `(SkillBufferManager.TryGetBuf(?blr, 706, stkp(-152), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-152), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-152), 0) & 1) ne 0`
    - returns `ImprovisationSongAction.Damaged(this, 0, ?x2, ?x3)`
    - calls `EmotionPlayer$$MoveEmotionCancel`, `GodHandBuf$$DamageFunction`, `ImprovisationSongAction$$Damaged`
  - when `(SkillBufferManager.TryGetBuf(?blr, 706, stkp(-152), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-152), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-152), 0) & 1) eq 0`
    - returns `ImprovisationSongAction.Damaged(this, 0, ?x2, ?x3)`
    - calls `EmotionPlayer$$MoveEmotionCancel`, `ImprovisationSongAction$$Damaged`
  - when `(SkillBufferManager.TryGetBuf(?blr, 706, stkp(-152), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-152), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `EmotionPlayer$$MoveEmotionCancel`, `0x165db84`, `0x165df00`, `0x165df00`
  - when `(SkillBufferManager.TryGetBuf(?blr, 706, stkp(-152), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-152), 0) & 1) eq 0` AND `(SkillBufferManager.TryGetBuf(?blr, 1158, stkp(-152), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `ImprovisationSongAction.Damaged(this, 0, ?x2, ?x3)`
    - calls `EmotionPlayer$$MoveEmotionCancel`, `GodHandBuf$$DamageFunction`, `ImprovisationSongAction$$Damaged`
- Effect applied in `ReceiveSupportResult$$OnEventPlayerSupport` (86 guarded paths, truncated):
  - when `(skillId & 0xffff) le 993` AND `(skillId & 0xffff) ne 231` AND `(skillId & 0xffff) ne 265` AND `skillId gt 833`
    - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillLv, targetArchetypeType, targetArchetypeId), 0, ?x2, ?x3), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `AbnormalStateManager$$RemoveAbnormalState`, `SkillUtil$$CheckDanceSkill`, `PlayerDataManager$$get_SkillBufferManager`
  - when `(skillId & 0xffff) le 993` AND `(skillId & 0xffff) ne 231` AND `(skillId & 0xffff) ne 265` AND `skillId gt 833`
    - returns `SacredTeachings.ReceiveOtherHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillLv, targetArchetypeType, targetArchetypeId), 0, ?x2, ?x3), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `AbnormalStateManager$$RemoveAbnormalState`, `SkillUtil$$CheckDanceSkill`, `PlayerDataManager$$get_SkillBufferManager`
  - when `(skillId & 0xffff) le 993` AND `(skillId & 0xffff) ne 231` AND `(skillId & 0xffff) ne 265` AND `skillId gt 833`
    - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillLv, targetArchetypeType, targetArchetypeId), 0, ?x2, ?x3), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `AbnormalStateManager$$RemoveAbnormalState`, `SkillUtil$$CheckDanceSkill`, `PlayerDataManager$$get_SkillBufferManager`
  - when `(skillId & 0xffff) le 993` AND `(skillId & 0xffff) ne 231` AND `(skillId & 0xffff) ne 265` AND `skillId gt 833`
    - returns `SacredTeachings.ReceiveOtherHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillLv, targetArchetypeType, targetArchetypeId), 0, ?x2, ?x3), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `AbnormalStateManager$$RemoveAbnormalState`, `SkillUtil$$CheckDanceSkill`, `PlayerDataManager$$get_SkillBufferManager`
  - when `(skillId & 0xffff) le 993` AND `(skillId & 0xffff) ne 231` AND `(skillId & 0xffff) ne 265` AND `skillId gt 833`
    - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillLv, targetArchetypeType, targetArchetypeId), 0, ?x2, ?x3), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `AbnormalStateManager$$RemoveAbnormalState`, `SkillUtil$$CheckDanceSkill`, `PlayerDataManager$$get_SkillBufferManager`
  - when `(skillId & 0xffff) le 993` AND `(skillId & 0xffff) ne 231` AND `(skillId & 0xffff) ne 265` AND `skillId gt 833`
    - returns `SacredTeachings.ReceiveOtherHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillLv, targetArchetypeType, targetArchetypeId), 0, ?x2, ?x3), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `AbnormalStateManager$$RemoveAbnormalState`, `SkillUtil$$CheckDanceSkill`, `PlayerDataManager$$get_SkillBufferManager`
  - when `(skillId & 0xffff) le 993` AND `(skillId & 0xffff) ne 231` AND `(skillId & 0xffff) ne 265` AND `skillId gt 833`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `AbnormalStateManager$$RemoveAbnormalState`, `SkillUtil$$CheckDanceSkill`, `PlayerDataManager$$get_SkillBufferManager`
  - when `(skillId & 0xffff) le 993` AND `(skillId & 0xffff) ne 231` AND `(skillId & 0xffff) ne 265` AND `skillId gt 833`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_PlayerStatus`, `virtual CharacterActionManagerBase.get_DefaultMoveSpeed`, `AbnormalStateManager$$RemoveAbnormalState`, `SkillUtil$$CheckDanceSkill`, `PlayerDataManager$$get_SkillBufferManager`
- Effect applied in `GuardActionManager$$CheckGuardStart` (140 guarded paths):
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
- Effect applied in `BattleManagerBase$$SupportEntry` (5 guarded paths):
  - when `SkillActionBase.get_ActionID() eq 1039` AND `(MindimageSenjuSkillBase.CheckInheritance(actionManager, action, 0, ?mi) & 1) ne 0`
    - returns `1`
    - set `nextAction` = `0`
    - set `+0x64` = `0`
    - set `isFirstHit` = `0`
    - set `IsDistanceCancel` = `0`
    - calls `virtual SkillActionBase.get_ActionID`, `UnityEngine.GameObject$$GetComponent<object>`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`, `CharacterMove$$MoveStop`
  - when `SkillActionBase.get_ActionID() eq 1039` AND `(MindimageSenjuSkillBase.CheckInheritance(actionManager, action, 0, ?mi) & 1) eq 0`
    - returns `1`
    - set `nextAction` = `0`
    - set `+0x64` = `0`
    - set `isFirstHit` = `0`
    - set `IsDistanceCancel` = `0`
    - calls `virtual SkillActionBase.get_ActionID`, `UnityEngine.GameObject$$GetComponent<object>`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`, `CharacterMove$$MoveStop`
  - when `SkillActionBase.get_ActionID() ne 1039`
    - returns `0`
    - calls `virtual SkillActionBase.get_ActionID`
  - when `(MindimageSenjuSkillBase.CheckInheritance(actionManager, action, 0, ?mi) & 1) ne 0`
    - returns `1`
    - set `nextAction` = `0`
    - set `+0x64` = `0`
    - set `isFirstHit` = `0`
    - set `IsDistanceCancel` = `0`
    - calls `UnityEngine.GameObject$$GetComponent<object>`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`, `CharacterMove$$MoveStop`, `virtual CharacterActionManagerBase.get_IsValid`
  - when `(MindimageSenjuSkillBase.CheckInheritance(actionManager, action, 0, ?mi) & 1) eq 0`
    - returns `1`
    - set `nextAction` = `0`
    - set `+0x64` = `0`
    - set `isFirstHit` = `0`
    - set `IsDistanceCancel` = `0`
    - calls `UnityEngine.GameObject$$GetComponent<object>`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`, `0x165d8dc`, `CharacterMove$$MoveStop`, `virtual CharacterActionManagerBase.get_IsValid`
- Effect applied in `BattleManagerBase$$BattleEntry` (16 guarded paths):
  - when `IsBattleActive eq 0` AND `(MindimageSenjuSkillBase.CheckInheritance(actionManager, action, 0, ?mi) & 1) ne 0` AND `SkillActionBase.get_ActionID() eq 1127`
    - returns `1`
    - set `nextAction` = `0`
    - set `+0x64` = `0`
    - set `isFirstHit` = `0`
    - set `IsNotReadyBattle` = `0`
    - set `IsBattleActive` = `1`
    - set `IsDistanceCancel` = `0`
    - calls `UnityEngine.GameObject$$GetComponent<object>`, `0x165da68`, `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `0x165d8dc`, `CharacterMove$$MoveStop`, `0x165d8dc`, `0x165d8dc`, `virtual CharacterActionManagerBase.get_IsValid`
  - when `IsBattleActive eq 0` AND `(MindimageSenjuSkillBase.CheckInheritance(actionManager, action, 0, ?mi) & 1) ne 0` AND `SkillActionBase.get_ActionID() eq 1127`
    - returns `1`
    - set `nextAction` = `0`
    - set `+0x64` = `0`
    - set `isFirstHit` = `0`
    - set `IsNotReadyBattle` = `0`
    - set `IsBattleActive` = `1`
    - set `IsDistanceCancel` = `0`
    - calls `UnityEngine.GameObject$$GetComponent<object>`, `0x165da68`, `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `0x165d8dc`, `CharacterMove$$MoveStop`, `0x165d8dc`, `0x165d8dc`, `virtual CharacterActionManagerBase.get_IsValid`
  - when `IsBattleActive eq 0` AND `(MindimageSenjuSkillBase.CheckInheritance(actionManager, action, 0, ?mi) & 1) ne 0` AND `SkillActionBase.get_ActionID() ne 1127`
    - returns `1`
    - set `nextAction` = `0`
    - set `+0x64` = `0`
    - set `isFirstHit` = `0`
    - set `IsNotReadyBattle` = `0`
    - set `IsBattleActive` = `1`
    - set `IsDistanceCancel` = `0`
    - calls `UnityEngine.GameObject$$GetComponent<object>`, `0x165da68`, `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `0x165d8dc`, `CharacterMove$$MoveStop`, `0x165d8dc`, `0x165d8dc`, `virtual CharacterActionManagerBase.get_IsValid`
  - when `IsBattleActive eq 0` AND `(MindimageSenjuSkillBase.CheckInheritance(actionManager, action, 0, ?mi) & 1) eq 0` AND `SkillActionBase.get_ActionID() eq 1127`
    - returns `1`
    - set `nextAction` = `0`
    - set `+0x64` = `0`
    - set `isFirstHit` = `0`
    - set `IsNotReadyBattle` = `0`
    - set `IsBattleActive` = `1`
    - set `IsDistanceCancel` = `0`
    - calls `UnityEngine.GameObject$$GetComponent<object>`, `0x165da68`, `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `0x165d8dc`, `CharacterMove$$MoveStop`, `0x165d8dc`, `0x165d8dc`, `virtual CharacterActionManagerBase.get_IsValid`
  - when `IsBattleActive eq 0` AND `(MindimageSenjuSkillBase.CheckInheritance(actionManager, action, 0, ?mi) & 1) eq 0` AND `SkillActionBase.get_ActionID() eq 1127`
    - returns `1`
    - set `nextAction` = `0`
    - set `+0x64` = `0`
    - set `isFirstHit` = `0`
    - set `IsNotReadyBattle` = `0`
    - set `IsBattleActive` = `1`
    - set `IsDistanceCancel` = `0`
    - calls `UnityEngine.GameObject$$GetComponent<object>`, `0x165da68`, `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `0x165d8dc`, `CharacterMove$$MoveStop`, `0x165d8dc`, `0x165d8dc`, `virtual CharacterActionManagerBase.get_IsValid`
  - when `IsBattleActive eq 0` AND `(MindimageSenjuSkillBase.CheckInheritance(actionManager, action, 0, ?mi) & 1) eq 0` AND `SkillActionBase.get_ActionID() ne 1127`
    - returns `1`
    - set `nextAction` = `0`
    - set `+0x64` = `0`
    - set `isFirstHit` = `0`
    - set `IsNotReadyBattle` = `0`
    - set `IsBattleActive` = `1`
    - set `IsDistanceCancel` = `0`
    - calls `UnityEngine.GameObject$$GetComponent<object>`, `0x165da68`, `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `0x165d8dc`, `CharacterMove$$MoveStop`, `0x165d8dc`, `0x165d8dc`, `virtual CharacterActionManagerBase.get_IsValid`
  - when `IsBattleActive ne 0` AND `(MindimageSenjuSkillBase.CheckInheritance(actionManager, action, 0, ?mi) & 1) ne 0` AND `SkillActionBase.get_ActionID() eq 1127`
    - returns `1`
    - set `nextAction` = `0`
    - set `+0x64` = `0`
    - set `isFirstHit` = `0`
    - set `IsNotReadyBattle` = `0`
    - set `IsDistanceCancel` = `0`
    - calls `UnityEngine.GameObject$$GetComponent<object>`, `0x165da68`, `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `0x165d8dc`, `CharacterMove$$MoveStop`, `0x165d8dc`, `0x165d8dc`, `virtual CharacterActionManagerBase.get_IsValid`
  - when `IsBattleActive ne 0` AND `(MindimageSenjuSkillBase.CheckInheritance(actionManager, action, 0, ?mi) & 1) ne 0` AND `SkillActionBase.get_ActionID() eq 1127`
    - returns `1`
    - set `nextAction` = `0`
    - set `+0x64` = `0`
    - set `isFirstHit` = `0`
    - set `IsNotReadyBattle` = `0`
    - set `IsDistanceCancel` = `0`
    - calls `UnityEngine.GameObject$$GetComponent<object>`, `0x165da68`, `CharacterActionManagerBase$$get_IsDeadOrLocalDead`, `0x165d8dc`, `CharacterMove$$MoveStop`, `0x165d8dc`, `0x165d8dc`, `virtual CharacterActionManagerBase.get_IsValid`
- Effect applied in `MobaPlayerBattleManager$$StartAutoDeviceAttack` (15 guarded paths):
  - when `IsDelay eq 0`
    - calls `0x165db78`, `MobaPlayerBattleManager.<>c__DisplayClass119_0$$.ctor`, `0x165d8dc`, `BattleManagerBase$$get_IsReservedAction`, `CharacterMove$$get_IsMove`, `CharacterMove$$get_IsTargetMove`, `SkillActionManager$$IsPlaySkillData`, `BattleManagerBase.TargetData$$get_HasTarget`
  - when `IsDelay eq 0`
    - calls `0x165db78`, `MobaPlayerBattleManager.<>c__DisplayClass119_0$$.ctor`, `0x165d8dc`, `BattleManagerBase$$get_IsReservedAction`, `CharacterMove$$get_IsMove`, `CharacterMove$$get_IsTargetMove`, `SkillActionManager$$IsPlaySkillData`, `BattleManagerBase.TargetData$$get_HasTarget`
  - when `IsDelay eq 0`
    - returns `SkillActionBase.op_Equality(SkillFactory.CreateSkill(733, [buf+0x10], actionManager, 0), 0, 0, ?x3)`
    - calls `0x165db78`, `MobaPlayerBattleManager.<>c__DisplayClass119_0$$.ctor`, `0x165d8dc`, `BattleManagerBase$$get_IsReservedAction`, `CharacterMove$$get_IsMove`, `CharacterMove$$get_IsTargetMove`, `SkillActionManager$$IsPlaySkillData`, `BattleManagerBase.TargetData$$get_HasTarget`
  - when `IsDelay eq 0`
    - returns `AutoDeviceBuf.get_ActionRange(buf, 0, ?x2, ?x3)`
    - calls `0x165db78`, `MobaPlayerBattleManager.<>c__DisplayClass119_0$$.ctor`, `0x165d8dc`, `BattleManagerBase$$get_IsReservedAction`, `CharacterMove$$get_IsMove`, `CharacterMove$$get_IsTargetMove`, `SkillActionManager$$IsPlaySkillData`, `BattleManagerBase.TargetData$$get_HasTarget`
  - when `IsDelay eq 0`
    - returns `BattleManagerBase.TargetData.get_HasTarget(mainTargetData, 0, ?x2, ?x3)`
    - calls `0x165db78`, `MobaPlayerBattleManager.<>c__DisplayClass119_0$$.ctor`, `0x165d8dc`, `BattleManagerBase$$get_IsReservedAction`, `CharacterMove$$get_IsMove`, `CharacterMove$$get_IsTargetMove`, `SkillActionManager$$IsPlaySkillData`, `BattleManagerBase.TargetData$$get_HasTarget`
  - when `IsDelay eq 0`
    - returns `SkillActionManager.IsPlaySkillData(skillActManager, 733, 0, ?x3)`
    - calls `0x165db78`, `MobaPlayerBattleManager.<>c__DisplayClass119_0$$.ctor`, `0x165d8dc`, `BattleManagerBase$$get_IsReservedAction`, `CharacterMove$$get_IsMove`, `CharacterMove$$get_IsTargetMove`, `SkillActionManager$$IsPlaySkillData`
  - when `IsDelay eq 0`
    - returns `CharacterMove.get_IsTargetMove(charaMove, 0, ?x2, ?x3)`
    - calls `0x165db78`, `MobaPlayerBattleManager.<>c__DisplayClass119_0$$.ctor`, `0x165d8dc`, `BattleManagerBase$$get_IsReservedAction`, `CharacterMove$$get_IsMove`, `CharacterMove$$get_IsTargetMove`
  - when `IsDelay eq 0`
    - returns `CharacterMove.get_IsMove(charaMove, 0, ?x2, ?x3)`
    - calls `0x165db78`, `MobaPlayerBattleManager.<>c__DisplayClass119_0$$.ctor`, `0x165d8dc`, `BattleManagerBase$$get_IsReservedAction`, `CharacterMove$$get_IsMove`
- Effect applied in `PlayerBattleManager$$StartAutoDeviceAttack` (15 guarded paths):
  - when `IsDelay eq 0`
    - calls `0x165db78`, `PlayerBattleManager.<>c__DisplayClass138_0$$.ctor`, `0x165d8dc`, `SkillBufferManager$$CheckSong`, `BattleManagerBase$$get_IsReservedAction`, `CharacterMove$$get_IsMove`, `CharacterMove$$get_IsTargetMove`, `SkillActionManager$$IsPlaySkillData`
  - when `IsDelay eq 0`
    - calls `0x165db78`, `PlayerBattleManager.<>c__DisplayClass138_0$$.ctor`, `0x165d8dc`, `SkillBufferManager$$CheckSong`, `BattleManagerBase$$get_IsReservedAction`, `CharacterMove$$get_IsMove`, `CharacterMove$$get_IsTargetMove`, `SkillActionManager$$IsPlaySkillData`
  - when `IsDelay eq 0`
    - returns `SkillActionBase.op_Equality(SkillFactory.CreateSkill(733, [buf+0x10], actionManager, 0), 0, 0, ?x3)`
    - calls `0x165db78`, `PlayerBattleManager.<>c__DisplayClass138_0$$.ctor`, `0x165d8dc`, `SkillBufferManager$$CheckSong`, `BattleManagerBase$$get_IsReservedAction`, `CharacterMove$$get_IsMove`, `CharacterMove$$get_IsTargetMove`, `SkillActionManager$$IsPlaySkillData`
  - when `IsDelay eq 0`
    - returns `AutoDeviceBuf.get_ActionRange(buf, 0, ?x2, ?x3)`
    - calls `0x165db78`, `PlayerBattleManager.<>c__DisplayClass138_0$$.ctor`, `0x165d8dc`, `SkillBufferManager$$CheckSong`, `BattleManagerBase$$get_IsReservedAction`, `CharacterMove$$get_IsMove`, `CharacterMove$$get_IsTargetMove`, `SkillActionManager$$IsPlaySkillData`
  - when `IsDelay eq 0`
    - returns `BattleManagerBase.TargetData.get_HasTarget(mainTargetData, 0, ?x2, ?x3)`
    - calls `0x165db78`, `PlayerBattleManager.<>c__DisplayClass138_0$$.ctor`, `0x165d8dc`, `SkillBufferManager$$CheckSong`, `BattleManagerBase$$get_IsReservedAction`, `CharacterMove$$get_IsMove`, `CharacterMove$$get_IsTargetMove`, `SkillActionManager$$IsPlaySkillData`
  - when `IsDelay eq 0`
    - returns `SkillActionManager.IsPlaySkillData(skillActManager, 733, 0, ?x3)`
    - calls `0x165db78`, `PlayerBattleManager.<>c__DisplayClass138_0$$.ctor`, `0x165d8dc`, `SkillBufferManager$$CheckSong`, `BattleManagerBase$$get_IsReservedAction`, `CharacterMove$$get_IsMove`, `CharacterMove$$get_IsTargetMove`, `SkillActionManager$$IsPlaySkillData`
  - when `IsDelay eq 0`
    - returns `CharacterMove.get_IsTargetMove(charaMove, 0, ?x2, ?x3)`
    - calls `0x165db78`, `PlayerBattleManager.<>c__DisplayClass138_0$$.ctor`, `0x165d8dc`, `SkillBufferManager$$CheckSong`, `BattleManagerBase$$get_IsReservedAction`, `CharacterMove$$get_IsMove`, `CharacterMove$$get_IsTargetMove`
  - when `IsDelay eq 0`
    - returns `CharacterMove.get_IsMove(charaMove, 0, ?x2, ?x3)`
    - calls `0x165db78`, `PlayerBattleManager.<>c__DisplayClass138_0$$.ctor`, `0x165d8dc`, `SkillBufferManager$$CheckSong`, `BattleManagerBase$$get_IsReservedAction`, `CharacterMove$$get_IsMove`
- Effect applied in `ShiftAction$$OnInitialize` (2 guarded paths):
  - always
    - set `mp` = `0`
    - set `ActionRange` = `-1`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
  - always
    - set `mp` = `200`
    - set `ActionRange` = `-1`
    - set `_motionSpeed` = `PlayerAttackBase.CalcMotionSpeed(?blr, 0, ?x2, ?x3)`
    - set `CurrentTake` = `0x165db78(meta(0x399a650, SkillLinkedTake_TypeInfo), ?x1, ?x2, ?x3)`
    - calls `PlayerAttackBase$$CalcMotionSpeed`, `PlayerAttackBase$$CalcMp`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`, `0x165db78`, `SkillLinkedTake$$.ctor`, `0x165d8dc`
- Effect applied in `PlayerActionManager$$OnActionButton` (28 guarded paths):
  - when `id ne 1039` AND `type eq 1`
    - returns `0`
    - set `externalTarget` = `0`
    - calls `PlayerActionManager$$get_IsInputLock`, `PlayerDataManager$$EquipPurgeDisableSkill`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsSafetyArea`, `Singleton<object>$$get_Instance`, `UI3DLabelManager$$SetSkillMissPopUp`
  - when `id ne 1039` AND `type eq 1` AND `id le 1031` AND `id ne 87`
    - returns `((PlayerActionManager.supportTargetToReserve(this, PlayerActionManager.GetSkillTargetType(this, id, ?x2, ?x3), id, ?x3) & 1) ne 0 ? 2 : 0)`
    - set `externalTarget` = `0`
    - calls `PlayerActionManager$$get_IsInputLock`, `PlayerDataManager$$EquipPurgeDisableSkill`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsSafetyArea`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `EmotionPlayer$$MoveEmotionCancel`, `PlayerActionManager$$GetSkillTargetType`
  - when `id ne 1039` AND `type eq 1` AND `id le 1031` AND `id ne 87`
    - returns `2`
    - set `externalTarget` = `0`
    - calls `PlayerActionManager$$get_IsInputLock`, `PlayerDataManager$$EquipPurgeDisableSkill`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsSafetyArea`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `EmotionPlayer$$MoveEmotionCancel`, `PlayerActionManager$$GetSkillTargetType`
  - when `id ne 1039` AND `type eq 1` AND `id le 1031` AND `id ne 87`
    - returns `2`
    - set `externalTarget` = `0`
    - calls `PlayerActionManager$$get_IsInputLock`, `PlayerDataManager$$EquipPurgeDisableSkill`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsSafetyArea`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `EmotionPlayer$$MoveEmotionCancel`, `PlayerActionManager$$GetSkillTargetType`
  - when `id ne 1039` AND `type eq 1` AND `id le 1031` AND `id ne 87`
    - returns `1`
    - set `externalTarget` = `0`
    - calls `PlayerActionManager$$get_IsInputLock`, `PlayerDataManager$$EquipPurgeDisableSkill`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsSafetyArea`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `EmotionPlayer$$MoveEmotionCancel`, `PlayerActionManager$$GetSkillTargetType`
  - when `id ne 1039` AND `type eq 1` AND `id le 1031` AND `id ne 87`
    - returns `1`
    - set `externalTarget` = `0`
    - calls `PlayerActionManager$$get_IsInputLock`, `PlayerDataManager$$EquipPurgeDisableSkill`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsSafetyArea`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `EmotionPlayer$$MoveEmotionCancel`, `PlayerActionManager$$GetSkillTargetType`
  - when `id ne 1039` AND `type eq 1` AND `id le 1031` AND `id ne 87`
    - returns `0`
    - set `externalTarget` = `0`
    - calls `PlayerActionManager$$get_IsInputLock`, `PlayerDataManager$$EquipPurgeDisableSkill`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsSafetyArea`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `EmotionPlayer$$MoveEmotionCancel`, `PlayerActionManager$$GetSkillTargetType`
  - when `id ne 1039` AND `type eq 1` AND `id le 1031` AND `id ne 87`
    - returns `2`
    - set `externalTarget` = `0`
    - calls `PlayerActionManager$$get_IsInputLock`, `PlayerDataManager$$EquipPurgeDisableSkill`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsSafetyArea`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `EmotionPlayer$$MoveEmotionCancel`, `PlayerActionManager$$GetSkillTargetType`
- Effect applied in `ShiftAction$$ReceiveSupport` (4 guarded paths):
  - when `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `ShiftBuf.BufferEnd(TryGetBuf.out2(), 0, ?x2, ?x3)`
    - calls `SkillBufferDataBase$$GetParam`, `0x165db78`, `ShiftMotionSpeedBuf$$.ctor`, `SkillBufferManager$$AddSelfBuffer`, `SkillBufferManager$$RemoveSelfBuffer`, `ShiftBuf$$BufferEnd`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
    - returns `ShiftBuf.BufferEnd(TryGetBuf.out2(), 0, ?x2, ?x3)`
    - calls `SkillBufferDataBase$$GetParam`, `SkillBufferManager$$RemoveSelfBuffer`, `ShiftBuf$$BufferEnd`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-56), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
    - calls `0x165db84`
  - when `(SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-56), 0) & 1) eq 0`
    - returns `SkillBufferManager.TryGetBuf(?blr, 1039, stkp(-56), 0)`
- Effect applied in `MobaPlayerActionManager$$OnActionButton` (76 guarded paths):
  - when `type eq 1` AND `id eq 1039`
    - returns `0`
    - set `externalTarget` = `0`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsSafetyArea`, `Singleton<object>$$get_Instance`, `UI3DLabelManager$$SetSkillMissPopUp`
  - when `type eq 1` AND `id eq 1039` AND `id le 1031`
    - returns `((MobaPlayerActionManager.supportTargetToReserve(this, MobaPlayerActionManager.GetSkillTargetType(this, id, ?x2, ?x3), id, ?x3) & 1) ne 0 ? 2 : 0)`
    - set `externalTarget` = `0`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsSafetyArea`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `EmotionPlayer$$MoveEmotionCancel`, `MobaPlayerActionManager$$GetSkillTargetType`, `Singleton<object>$$get_Instance`
  - when `type eq 1` AND `id eq 1039` AND `id le 1031`
    - returns `2`
    - set `externalTarget` = `0`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsSafetyArea`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `EmotionPlayer$$MoveEmotionCancel`, `MobaPlayerActionManager$$GetSkillTargetType`, `Singleton<object>$$get_Instance`
  - when `type eq 1` AND `id eq 1039` AND `id le 1031`
    - returns `1`
    - set `externalTarget` = `0`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsSafetyArea`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `EmotionPlayer$$MoveEmotionCancel`, `MobaPlayerActionManager$$GetSkillTargetType`, `Singleton<object>$$get_Instance`
  - when `type eq 1` AND `id eq 1039` AND `id le 1031`
    - returns `0`
    - set `externalTarget` = `0`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsSafetyArea`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `EmotionPlayer$$MoveEmotionCancel`, `MobaPlayerActionManager$$GetSkillTargetType`, `Singleton<object>$$get_Instance`
  - when `type eq 1` AND `id eq 1039` AND `id le 1031`
    - returns `2`
    - set `externalTarget` = `0`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsSafetyArea`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `EmotionPlayer$$MoveEmotionCancel`, `MobaPlayerActionManager$$GetSkillTargetType`, `Singleton<object>$$get_Instance`
  - when `type eq 1` AND `id eq 1039` AND `id gt 1031`
    - returns `((MobaPlayerActionManager.supportTargetToReserve(this, MobaPlayerActionManager.GetSkillTargetType(this, id, ?x2, ?x3), id, ?x3) & 1) ne 0 ? 2 : 0)`
    - set `externalTarget` = `0`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsSafetyArea`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `EmotionPlayer$$MoveEmotionCancel`, `MobaPlayerActionManager$$GetSkillTargetType`, `Singleton<object>$$get_Instance`
  - when `type eq 1` AND `id eq 1039` AND `id gt 1031`
    - returns `2`
    - set `externalTarget` = `0`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `Singleton<object>$$get_Instance`, `FieldManager$$get_IsSafetyArea`, `Singleton<object>$$get_Instance`, `FieldManager$$get_RoomType`, `EmotionPlayer$$MoveEmotionCancel`, `MobaPlayerActionManager$$GetSkillTargetType`, `Singleton<object>$$get_Instance`
- Effect applied in `MobaPlayerActionManager$$BattleReserve` (300 guarded paths, truncated):
  - when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 0`
    - returns `UI3DLabelManager.SetSkillMissPopUp(Singleton<object>.get_Instance(meta(0x3974690, Method$Singleton<UI3DLabelManager>.get_Instance()), ?x1, ?x2, ?x3), CheckCaptureEnable.out4(), 0, ?x3)`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `System.Linq.Enumerable$$Contains<Int32Enum>`, `Singleton<object>$$get_Instance`, `UnityEngine.GameObject$$GetComponent<object>`, `MobaPlayer$$get_ItemManager`, `ItemManager$$get_BagItemList`
  - when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 0`
    - returns `UI3DLabelManager.SetSkillMissPopUp(Singleton<object>.get_Instance(meta(0x3974690, Method$Singleton<UI3DLabelManager>.get_Instance()), ?x1, ?x2, ?x3), 3, 0, ?x3)`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `System.Linq.Enumerable$$Contains<Int32Enum>`, `Singleton<object>$$get_Instance`, `UnityEngine.GameObject$$GetComponent<object>`, `MobaPlayer$$get_ItemManager`, `ItemManager$$get_BagItemList`
  - when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 0` AND `SkillReserveMpLess.out2() ne 0`
    - returns `GameManager.AttackStartToMob(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), 0, SkillManager.GetAvailableSkill(CharacterActionManagerBase.get_IsDeadOrLocalDead(), this, 0, skillId), 0)`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `System.Linq.Enumerable$$Contains<Int32Enum>`, `Singleton<object>$$get_Instance`, `UnityEngine.GameObject$$GetComponent<object>`, `MobaPlayer$$get_ItemManager`, `ItemManager$$get_BagItemList`
  - when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 0` AND `SkillReserveMpLess.out2() eq 0`
    - returns `MobaPlayerActionManager.SkillReserveMpLess(this, ((CaptureManager.CheckCaptureEnable(Singleton<object>.get_Instance(meta(0x3992c68, Method$Singleton<CaptureManager>.get_Instance()), ?x1, ?x2, ?x3), UnityEngine.GameObject.GetComponent<object>(target, meta(0x397f3d0, Method$UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>()), ?x2, ?x3), this, ItemManager.get_BagItemList(MobaPlayer.get_ItemManager(mobaPlayer, 0, ?x2, ?x3), 0, ?x2, ?x3)) & 1) ne 0 ? SkillManager.GetAvailableSkill(CharacterActionManagerBase.get_IsDeadOrLocalDead(), this, 0, skillId) : 0), stkp(-88), ?x3)`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `System.Linq.Enumerable$$Contains<Int32Enum>`, `Singleton<object>$$get_Instance`, `UnityEngine.GameObject$$GetComponent<object>`, `MobaPlayer$$get_ItemManager`, `ItemManager$$get_BagItemList`
  - when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 0`
    - returns `TargetManager.ClearTarget(targetManager, 0, ?x2, ?x3)`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `System.Linq.Enumerable$$Contains<Int32Enum>`, `Singleton<object>$$get_Instance`, `UnityEngine.GameObject$$GetComponent<object>`, `MobaPlayer$$get_ItemManager`, `ItemManager$$get_BagItemList`
  - when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 0`
    - returns `BattleManagerBase.BattleReserve(battleManager, target, ((CaptureManager.CheckCaptureEnable(Singleton<object>.get_Instance(meta(0x3992c68, Method$Singleton<CaptureManager>.get_Instance()), ?x1, ?x2, ?x3), UnityEngine.GameObject.GetComponent<object>(target, meta(0x397f3d0, Method$UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>()), ?x2, ?x3), this, ItemManager.get_BagItemList(MobaPlayer.get_ItemManager(mobaPlayer, 0, ?x2, ?x3), 0, ?x2, ?x3)) & 1) ne 0 ? SkillManager.GetAvailableSkill(CharacterActionManagerBase.get_IsDeadOrLocalDead(), this, 0, skillId) : 0), (skillId ne 0 ? 1 : 0))`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `System.Linq.Enumerable$$Contains<Int32Enum>`, `Singleton<object>$$get_Instance`, `UnityEngine.GameObject$$GetComponent<object>`, `MobaPlayer$$get_ItemManager`, `ItemManager$$get_BagItemList`
  - when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 0`
    - returns `TargetManager.ClearTarget(targetManager, 0, ?x2, ?x3)`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `System.Linq.Enumerable$$Contains<Int32Enum>`, `Singleton<object>$$get_Instance`, `UnityEngine.GameObject$$GetComponent<object>`, `MobaPlayer$$get_ItemManager`, `ItemManager$$get_BagItemList`
  - when `(MobaPlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 0`
    - returns `BattleManagerBase.BattleReserve(battleManager, target, ((CaptureManager.CheckCaptureEnable(Singleton<object>.get_Instance(meta(0x3992c68, Method$Singleton<CaptureManager>.get_Instance()), ?x1, ?x2, ?x3), UnityEngine.GameObject.GetComponent<object>(target, meta(0x397f3d0, Method$UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>()), ?x2, ?x3), this, ItemManager.get_BagItemList(MobaPlayer.get_ItemManager(mobaPlayer, 0, ?x2, ?x3), 0, ?x2, ?x3)) & 1) ne 0 ? SkillManager.GetAvailableSkill(CharacterActionManagerBase.get_IsDeadOrLocalDead(), this, 0, skillId) : 0), (skillId ne 0 ? 1 : 0))`
    - calls `MobaPlayerActionManager$$get_IsInputLock`, `virtual CharacterActionManagerBase.get_IsDeadOrLocalDead`, `SkillManager$$GetAvailableSkill`, `System.Linq.Enumerable$$Contains<Int32Enum>`, `Singleton<object>$$get_Instance`, `UnityEngine.GameObject$$GetComponent<object>`, `MobaPlayer$$get_ItemManager`, `ItemManager$$get_BagItemList`
- Effect applied in `PlayerActionManager$$BattleReserve` (300 guarded paths, truncated):
  - when `(PlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 629` AND `skillId eq 0`
    - returns `UI3DLabelManager.SetSkillMissPopUp(Singleton<object>.get_Instance(meta(0x3974690, Method$Singleton<UI3DLabelManager>.get_Instance()), ?x1, ?x2, ?x3), CheckCaptureEnable.out4(), 0, ?x3)`
    - calls `PlayerActionManager$$get_IsInputLock`, `PlayerActionManager$$get_PlayerBattleManager`, `PlayerActionManager$$get_PlayerBattleManager`, `PlayerBattleManager$$get_IsGuard`, `StarGemManager$$get_IsActionLock`, `SkillManager$$GetAvailableSkill`, `System.Linq.Enumerable$$Contains<Int32Enum>`, `Singleton<object>$$get_Instance`
  - when `(PlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 629` AND `skillId eq 0`
    - returns `UI3DLabelManager.SetSkillMissPopUp(Singleton<object>.get_Instance(meta(0x3974690, Method$Singleton<UI3DLabelManager>.get_Instance()), ?x1, ?x2, ?x3), 3, 0, ?x3)`
    - calls `PlayerActionManager$$get_IsInputLock`, `PlayerActionManager$$get_PlayerBattleManager`, `PlayerActionManager$$get_PlayerBattleManager`, `PlayerBattleManager$$get_IsGuard`, `StarGemManager$$get_IsActionLock`, `SkillManager$$GetAvailableSkill`, `System.Linq.Enumerable$$Contains<Int32Enum>`, `Singleton<object>$$get_Instance`
  - when `(PlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 629` AND `skillId eq 0`
    - returns `GameManager.AttackStartToMob(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), 0, SkillManager.GetAvailableSkill(?blr, this, (StarGemManager.get_IsActionLock(StarGemManager, 0, ?x2, ?x3) & 1), 0), 0)`
    - calls `PlayerActionManager$$get_IsInputLock`, `PlayerActionManager$$get_PlayerBattleManager`, `PlayerActionManager$$get_PlayerBattleManager`, `PlayerBattleManager$$get_IsGuard`, `StarGemManager$$get_IsActionLock`, `SkillManager$$GetAvailableSkill`, `System.Linq.Enumerable$$Contains<Int32Enum>`, `Singleton<object>$$get_Instance`
  - when `(PlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 629` AND `skillId eq 0`
    - returns `PlayerActionManager.SkillReserveMpLess(this, ((CaptureManager.CheckCaptureEnable(Singleton<object>.get_Instance(meta(0x3992c68, Method$Singleton<CaptureManager>.get_Instance()), ?x1, ?x2, ?x3), UnityEngine.GameObject.GetComponent<object>(target, meta(0x397f3d0, Method$UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>()), ?x2, ?x3), this, ItemManager.get_BagItemList(PlayerDataManager.get_ItemManager(playerDataManager, 0, ?x2, ?x3), 0, ?x2, ?x3)) & 1) ne 0 ? SkillManager.GetAvailableSkill(?blr, this, (StarGemManager.get_IsActionLock(StarGemManager, 0, ?x2, ?x3) & 1), 0) : 0), stkp(-88), ?x3)`
    - calls `PlayerActionManager$$get_IsInputLock`, `PlayerActionManager$$get_PlayerBattleManager`, `PlayerActionManager$$get_PlayerBattleManager`, `PlayerBattleManager$$get_IsGuard`, `StarGemManager$$get_IsActionLock`, `SkillManager$$GetAvailableSkill`, `System.Linq.Enumerable$$Contains<Int32Enum>`, `Singleton<object>$$get_Instance`
  - when `(PlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 629` AND `skillId eq 0`
    - returns `TargetManager.ClearTarget(targetManager, 0, ?x2, ?x3)`
    - calls `PlayerActionManager$$get_IsInputLock`, `PlayerActionManager$$get_PlayerBattleManager`, `PlayerActionManager$$get_PlayerBattleManager`, `PlayerBattleManager$$get_IsGuard`, `StarGemManager$$get_IsActionLock`, `SkillManager$$GetAvailableSkill`, `System.Linq.Enumerable$$Contains<Int32Enum>`, `Singleton<object>$$get_Instance`
  - when `(PlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 629` AND `skillId eq 0`
    - returns `BattleManagerBase.BattleReserve(battleManager, target, ((CaptureManager.CheckCaptureEnable(Singleton<object>.get_Instance(meta(0x3992c68, Method$Singleton<CaptureManager>.get_Instance()), ?x1, ?x2, ?x3), UnityEngine.GameObject.GetComponent<object>(target, meta(0x397f3d0, Method$UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>()), ?x2, ?x3), this, ItemManager.get_BagItemList(PlayerDataManager.get_ItemManager(playerDataManager, 0, ?x2, ?x3), 0, ?x2, ?x3)) & 1) ne 0 ? SkillManager.GetAvailableSkill(?blr, this, (StarGemManager.get_IsActionLock(StarGemManager, 0, ?x2, ?x3) & 1), 0) : 0), 0)`
    - calls `PlayerActionManager$$get_IsInputLock`, `PlayerActionManager$$get_PlayerBattleManager`, `PlayerActionManager$$get_PlayerBattleManager`, `PlayerBattleManager$$get_IsGuard`, `StarGemManager$$get_IsActionLock`, `SkillManager$$GetAvailableSkill`, `System.Linq.Enumerable$$Contains<Int32Enum>`, `Singleton<object>$$get_Instance`
  - when `(PlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 629` AND `skillId eq 0`
    - returns `TargetManager.ClearTarget(targetManager, 0, ?x2, ?x3)`
    - calls `PlayerActionManager$$get_IsInputLock`, `PlayerActionManager$$get_PlayerBattleManager`, `PlayerActionManager$$get_PlayerBattleManager`, `PlayerBattleManager$$get_IsGuard`, `StarGemManager$$get_IsActionLock`, `SkillManager$$GetAvailableSkill`, `System.Linq.Enumerable$$Contains<Int32Enum>`, `Singleton<object>$$get_Instance`
  - when `(PlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 629` AND `skillId eq 0`
    - returns `BattleManagerBase.BattleReserve(battleManager, target, ((CaptureManager.CheckCaptureEnable(Singleton<object>.get_Instance(meta(0x3992c68, Method$Singleton<CaptureManager>.get_Instance()), ?x1, ?x2, ?x3), UnityEngine.GameObject.GetComponent<object>(target, meta(0x397f3d0, Method$UnityEngine.GameObject.GetComponent<EnemyMobActionManagerBase>()), ?x2, ?x3), this, ItemManager.get_BagItemList(PlayerDataManager.get_ItemManager(playerDataManager, 0, ?x2, ?x3), 0, ?x2, ?x3)) & 1) ne 0 ? SkillManager.GetAvailableSkill(?blr, this, (StarGemManager.get_IsActionLock(StarGemManager, 0, ?x2, ?x3) & 1), 0) : 0), 0)`
    - calls `PlayerActionManager$$get_IsInputLock`, `PlayerActionManager$$get_PlayerBattleManager`, `PlayerActionManager$$get_PlayerBattleManager`, `PlayerBattleManager$$get_IsGuard`, `StarGemManager$$get_IsActionLock`, `SkillManager$$GetAvailableSkill`, `System.Linq.Enumerable$$Contains<Int32Enum>`, `Singleton<object>$$get_Instance`
- Effect applied in `PlayerActionManager$$SupportReserve` (300 guarded paths, truncated):
  - when `(PlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `CharacterActionManagerBase.get_IsLocalDead() ne 455` AND `CharacterActionManagerBase.get_IsLocalDead() eq 452`
    - returns `UI3DLabelManager.SetSkillMissPopUp(Singleton<object>.get_Instance(meta(0x3974690, Method$Singleton<UI3DLabelManager>.get_Instance()), ?x1, ?x2, ?x3), 6, 0, ?x3)`
    - calls `PlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `ArkSaberAction$$ConverterArkSaberSkillId`, `UnityEngine.Component$$get_gameObject`, `ClineHealAction$$CheckHealTarget`, `StarGemManager$$get_IsActionLock`, `SkillManager$$GetAvailableSkill`, `virtual CharacterActionManagerBase.get_IsLocalDead`
  - when `(PlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `CharacterActionManagerBase.get_IsLocalDead() ne 455` AND `CharacterActionManagerBase.get_IsLocalDead() eq 452`
    - returns `UI3DLabelManager.SetSkillMissPopUp(Singleton<object>.get_Instance(meta(0x3974690, Method$Singleton<UI3DLabelManager>.get_Instance()), ?x1, ?x2, ?x3), 3, 0, ?x3)`
    - calls `PlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `ArkSaberAction$$ConverterArkSaberSkillId`, `UnityEngine.Component$$get_gameObject`, `ClineHealAction$$CheckHealTarget`, `StarGemManager$$get_IsActionLock`, `SkillManager$$GetAvailableSkill`, `virtual CharacterActionManagerBase.get_IsLocalDead`
  - when `(PlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `CharacterActionManagerBase.get_IsLocalDead() ne 455` AND `CharacterActionManagerBase.get_IsLocalDead() eq 452`
    - returns `GameManager.StartSupportSkill(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), ClineHealAction.CheckHealTarget(UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), 0, ?x2, ?x3), 0, 0)`
    - calls `PlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `ArkSaberAction$$ConverterArkSaberSkillId`, `UnityEngine.Component$$get_gameObject`, `ClineHealAction$$CheckHealTarget`, `StarGemManager$$get_IsActionLock`, `SkillManager$$GetAvailableSkill`, `virtual CharacterActionManagerBase.get_IsLocalDead`
  - when `(PlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `CharacterActionManagerBase.get_IsLocalDead() ne 455` AND `CharacterActionManagerBase.get_IsLocalDead() eq 452`
    - returns `PlayerActionManager.SkillReserveMpLess(this, 0, stkp(-104), ?x3)`
    - calls `PlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `ArkSaberAction$$ConverterArkSaberSkillId`, `UnityEngine.Component$$get_gameObject`, `ClineHealAction$$CheckHealTarget`, `StarGemManager$$get_IsActionLock`, `SkillManager$$GetAvailableSkill`, `virtual CharacterActionManagerBase.get_IsLocalDead`
  - when `(PlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `CharacterActionManagerBase.get_IsLocalDead() ne 455` AND `CharacterActionManagerBase.get_IsLocalDead() eq 452`
    - returns `BattleManagerBase.SupportReserve(battleManager, ClineHealAction.CheckHealTarget(UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), 0, ?x2, ?x3), 0, (ArkSaberAction.ConverterArkSaberSkillId(654, ?blr, 0, ?x3) ne 0 ? 1 : 0))`
    - calls `PlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `ArkSaberAction$$ConverterArkSaberSkillId`, `UnityEngine.Component$$get_gameObject`, `ClineHealAction$$CheckHealTarget`, `StarGemManager$$get_IsActionLock`, `SkillManager$$GetAvailableSkill`, `virtual CharacterActionManagerBase.get_IsLocalDead`
  - when `(PlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `CharacterActionManagerBase.get_IsLocalDead() ne 455` AND `CharacterActionManagerBase.get_IsLocalDead() eq 452`
    - returns `BattleManagerBase.SupportReserve(battleManager, ClineHealAction.CheckHealTarget(UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), 0, ?x2, ?x3), 0, (ArkSaberAction.ConverterArkSaberSkillId(654, ?blr, 0, ?x3) ne 0 ? 1 : 0))`
    - calls `PlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `ArkSaberAction$$ConverterArkSaberSkillId`, `UnityEngine.Component$$get_gameObject`, `ClineHealAction$$CheckHealTarget`, `StarGemManager$$get_IsActionLock`, `SkillManager$$GetAvailableSkill`, `virtual CharacterActionManagerBase.get_IsLocalDead`
  - when `(PlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `CharacterActionManagerBase.get_IsLocalDead() ne 455` AND `CharacterActionManagerBase.get_IsLocalDead() eq 452`
    - returns `UI3DLabelManager.SetSkillMissPopUp(Singleton<object>.get_Instance(meta(0x3974690, Method$Singleton<UI3DLabelManager>.get_Instance()), ?x1, ?x2, ?x3), 3, 0, ?x3)`
    - calls `PlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `ArkSaberAction$$ConverterArkSaberSkillId`, `UnityEngine.Component$$get_gameObject`, `ClineHealAction$$CheckHealTarget`, `StarGemManager$$get_IsActionLock`, `SkillManager$$GetAvailableSkill`, `virtual CharacterActionManagerBase.get_IsLocalDead`
  - when `(PlayerActionManager.get_IsInputLock(this, target, skillId, assistCheck) & 1) eq 0` AND `skillId ne 1039` AND `CharacterActionManagerBase.get_IsLocalDead() ne 455` AND `CharacterActionManagerBase.get_IsLocalDead() eq 452`
    - returns `GameManager.StartSupportSkill(Singleton<object>.get_Instance(meta(0x3974218, Method$Singleton<GameManager>.get_Instance()), ?x1, ?x2, ?x3), ClineHealAction.CheckHealTarget(UnityEngine.Component.get_gameObject(this, 0, ?x2, ?x3), 0, ?x2, ?x3), 0, 0)`
    - calls `PlayerActionManager$$get_IsInputLock`, `SkillUtil$$IsChargeSkill`, `ArkSaberAction$$ConverterArkSaberSkillId`, `UnityEngine.Component$$get_gameObject`, `ClineHealAction$$CheckHealTarget`, `StarGemManager$$get_IsActionLock`, `SkillManager$$GetAvailableSkill`, `virtual CharacterActionManagerBase.get_IsLocalDead`
- Code that reads this skill's level / buff by constant id: `AvoidActionManager$$CheckAvoidStart (ContainsBuffer)`, `BattleManagerBase$$BattleEntry (ContainsBuffer)`, `BattleManagerBase$$SupportEntry (ContainsBuffer)`, `GuardActionManager$$CheckGuardStart (ContainsBuffer)`, `MobaPlayerActionManager$$BattleReserve (ContainsBuffer)`, `MobaPlayerActionManager$$Damaged (TryGetBuf)`, `MobaPlayerActionManager$$OnActionButton (ContainsBuffer)`, `MobaPlayerActionManager$$SupportReserve (ContainsBuffer)`, `MobaPlayerBattleManager$$StartAutoDeviceAttack (ContainsBuffer)`, `PlayerActionManager$$BattleReserve (ContainsBuffer)`, `PlayerActionManager$$Damaged (TryGetBuf)`, `PlayerActionManager$$OnActionButton (ContainsBuffer)`, `PlayerActionManager$$SupportReserve (ContainsBuffer)`, `PlayerBattleManager$$StartAutoDeviceAttack (ContainsBuffer)`, `ReceiveSupportResult$$OnEventPlayerSupport (TryGetBuf)`, `ShiftAction$$OnInitialize (ContainsBuffer)`, `ShiftAction$$ReceiveSupport (TryGetBuf)`

_Raw recovered data (every method item): [trees/WizardSkill.md](../trees/WizardSkill.md) — uid 1039_

---
