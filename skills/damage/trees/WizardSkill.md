# ウィザードスキル (`WizardSkill`)

15 entries. See ../README.md for how to read these blocks.

### แฟมิเรีย (Familia) · uid 1025

<img src="../../icons/sk_1025.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 1) · **Type:** Special · **Max Lv:** 15 · **Weapons:** Rod, Magictool, SubMagictool · **Flags:** StarGem · **Client class:** `FamiliaAction`

> เรียกปีศาจรับใช้ออกมา ระหว่างการเรียก
> MATK กับ MP สูงสุด และเวทไล่โจมตีจะเพิ่มขึ้นเล็กน้อย
> ถ้าข้ารับใช้โดนโจมตีอาจจะหนีไปได้

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0.1, PlayerActionManagerBase.get_PlayerStatus())`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1025

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 0.1, PlayerActionManagerBase.get_PlayerStatus())`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

</details>

**Buffs**

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

<details><summary>Effect applied in `PlayerBattleManager$$PursuitAttack` (191 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `BlizzardAction$$IsFailure` (3 guarded paths)</summary>

- always
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
- always
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- always
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`

</details>

<details><summary>Effect applied in `CrystalLaserAction$$IsFailure` (3 guarded paths)</summary>

- always
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
- always
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- always
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`

</details>

<details><summary>Effect applied in `HighFamiliaAction$$IsFailure` (2 guarded paths)</summary>

- when `SkillLv(1025) gt 0`
  - calls `virtual PlayerStatusBase.get_SkillManager`, `PlayerAttackBase$$IsFailure`
- when `SkillLv(1025) le 0`
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillManager`

</details>

<details><summary>Effect applied in `LightningAction$$IsFailure` (3 guarded paths)</summary>

- always
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
- always
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- always
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`

</details>

<details><summary>Effect applied in `ManaCrystalAction$$IsFailure` (3 guarded paths)</summary>

- always
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
- always
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- always
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`

</details>

<details><summary>Effect applied in `MeteorStrikeAction$$IsFailure` (3 guarded paths)</summary>

- always
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
- always
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
- always
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`

</details>

<details><summary>Effect applied in `StoneSkinAction$$IsFailure` (5 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `SkillBufferManager$$AlignLearningSkillBuffer` (117 guarded paths)</summary>

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

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `BlizzardAction$$IsFailure (ContainsBuffer)`
- `CrystalLaserAction$$IsFailure (ContainsBuffer)`
- `GameManager$$ReceiveSummons (GetSkillLv)`
- `HighFamiliaAction$$IsFailure (GetSkillLv)`
- `LightningAction$$IsFailure (ContainsBuffer)`
- `ManaCrystalAction$$IsFailure (ContainsBuffer)`
- `MeteorStrikeAction$$IsFailure (ContainsBuffer)`
- `PlayerBattleManager$$PursuitAttack (ContainsBuffer)`
- `SkillBufferManager$$AlignLearningSkillBuffer (GetSkillLv)`
- `StoneSkinAction$$IsFailure (ContainsBuffer)`
- `UIExSkillManager$$ExSkillList (GetSkillLv)`
- `UISkillTreeManager$$SkillTreeList (GetSkillLv)`

---

### มานาคริสตัล (ManaCrystal) · uid 1026

<img src="../../icons/sk_1026.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 1) · **Type:** Support · **Max Lv:** 15 · **Weapons:** Rod, Magictool, SubMagictool · **Requires:** แฟมิเรีย · **Client class:** `ManaCrystalAction`

> คาถาใช้สร้างผลึกที่สามารถฟื้นฟูพลังเวทได้
> ฟื้นฟู MP ได้เล็กน้อยจากการใช้ผลึกที่ปรากฏออกมา
> เวลาใช้สกิลยิ่งอยู่ห่างจากปีศาจรับใช้
> ก็จะใช้เวลาร่ายนานยิ่งขึ้น

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, ((gemCart(1003[2]) * 4) / 100), PlayerActionManagerBase.get_PlayerStatus())`; `(CastTime + CastTime)` _(when !PlayerAttackBase.IsBlank(this) AND AutoMemberManager.TryGetAutoMember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager()), (this + 304)) AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager())) ne 0)_
- **Range** (`range`): `MathUtil.DisplayMeterToDistance(1)`; `MathUtil.DisplayMeterToDistance(1)`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1026

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, ((gemCart(1003[2]) * 4) / 100), PlayerActionManagerBase.get_PlayerStatus())`
- set `range` = `MathUtil.DisplayMeterToDistance(1)`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `range` = `MathUtil.DisplayMeterToDistance(1)`

**`ActionStart`** (6 paths)

- set `player` = `PlayerDataManager.GetPlayerDataManager()` — when !AutoMemberManager.TryGetAutoMember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager()), (this + 304)) AND !PlayerAttackBase.IsBlank(this) AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 OR !PlayerAttackBase.IsBlank(this) AND AutoMemberManager.TryGetAutoMember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager()), (this + 304)) AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager())) eq 0 OR !PlayerAttackBase.IsBlank(this) AND AutoMemberManager.TryGetAutoMember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager()), (this + 304)) AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager())) ne 0
- set `castingExtension` = `1` = 1 — when !PlayerAttackBase.IsBlank(this) AND AutoMemberManager.TryGetAutoMember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager()), (this + 304)) AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager())) ne 0
- set `CastTime` = `(CastTime + CastTime)` — when !PlayerAttackBase.IsBlank(this) AND AutoMemberManager.TryGetAutoMember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager()), (this + 304)) AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager())) ne 0
- set `SkillIndividualFlag` = `0` = 0 — when !PlayerAttackBase.IsBlank(this) AND AutoMemberManager.TryGetAutoMember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager()), (this + 304)) AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager())) ne 0 OR !PlayerAttackBase.IsBlank(this) AND !SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND AutoMemberManager.TryGetAutoMember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager()), (this + 304)) AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager())) ne 0
- set `failure` = `1` = 1 — when !AutoMemberManager.TryGetAutoMember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager()), (this + 304)) AND !PlayerAttackBase.IsBlank(this) AND IsInstanceOf(actarAction, PlayerActionManager) eq 1
- set `SkillIndividualFlag` = `-1` = -1 — when !AutoMemberManager.TryGetAutoMember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager()), (this + 304)) AND !PlayerAttackBase.IsBlank(this) AND IsInstanceOf(actarAction, PlayerActionManager) eq 1

**`ActionSkillEvent`** (8 paths)

- set `SkillIndividualFlag` = `SkillIndividualFlag` — when SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) AND TryGetAutoMember.automember(player.AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(player)) ne 0 AND UnityEngine.Object.op_Inequality(player) AND castingExtension ne 0 AND familiaCast eq 0 AND param eq 255 OR SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) AND TryGetAutoMember.automember(player.AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(player)) ne 0 AND UnityEngine.Object.op_Inequality(player) AND castingExtension eq 0 AND familiaCast eq 0 AND param eq 255
- set `familiaCast` = `1` = 1 — when SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) AND TryGetAutoMember.automember(player.AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(player)) ne 0 AND UnityEngine.Object.op_Inequality(player) AND castingExtension ne 0 AND familiaCast eq 0 AND param eq 255 OR SkillActionBase.op_Equality(SkillActionManagerBase.get_CurrentSkill(), 0) AND TryGetAutoMember.automember(player.AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(player)) ne 0 AND UnityEngine.Object.op_Inequality(player) AND castingExtension eq 0 AND familiaCast eq 0 AND param eq 255

</details>

**Buffs**

**Buff `ManaCrystalBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `Clear`, `GetBufferEffectTakeId`, `HitCrystalLaser`, `OnCall`, `ReRegistration`, `Registration`, `Remove`, `RemoveOverPlace`, `StartCrystalLaser`, `TakenManaCrystal`
- `Count` = `System.Collections.Generic.Dictionary<int, object>.get_Count((new System.Collections.Generic.Dictionary<int, ManaCrystalBuf.Invoker>), meta(0x39aa0b8, Method$System.Collections.Generic.Dictionary<int, ManaCrystalBuf.Invoker>.get_Count()))` _(when BuffEffectActive ne 0)_
- `Count` = `0` _(when BuffEffectActive eq 0)_
- Buff fields set in the constructor (all recovered):
  - `invokers` = `new System.Collections.Generic.Dictionary<int, ManaCrystalBuf.Invoker>`
  - `player` = `PlayerDataManager.GetPlayerDataManager()`
- Hook `Registration`: `currentInvoker`=0

<details><summary>Effect applied in `CrystalLaserAction$$ActionStart` (9 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `CrystalLaserAction$$OnEnd` (3 guarded paths)</summary>

- when `(SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() ne 0`
  - returns `ManaCrystalBuf.HitCrystalLaser(TryGetBuf.out2(), 0, ?x2, ?x3)`
  - calls `PlayerAttackBase$$OnEnd`, `ManaCrystalBuf$$HitCrystalLaser`
- when `(SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-40), 0) & 1) ne 0` AND `TryGetBuf.out2() eq 0`
  - calls `PlayerAttackBase$$OnEnd`, `0x165db84`, `0x165df00`
- when `(SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-40), 0) & 1) eq 0`
  - returns `SkillBufferManager.TryGetBuf(?blr, 1026, stkp(-40), 0)`
  - calls `PlayerAttackBase$$OnEnd`

</details>

<details><summary>Effect applied in `CrystalLaserAction$$ActionSkillEvent` (54 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `PlayerBattleManager$$StartCatsDropItem` (96 guarded paths)</summary>

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

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `CrystalLaserAction$$ActionSkillEvent (GetSkillLv)`
- `CrystalLaserAction$$ActionSkillEvent (TryGetBuf)`
- `CrystalLaserAction$$ActionStart (TryGetBuf)`
- `CrystalLaserAction$$OnEnd (TryGetBuf)`
- `PlayerBattleManager$$StartCatsDropItem (GetSkillLv)`

---

### คาสต์มาสเตอรี่ (CastMastery) · uid 1033

<img src="../../icons/sk_1033.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 1) · **Type:** Mastery · **Max Lv:** 15 · **Weapons:** Rod, MainMagictool · **Flags:** StarGem · **Client class:** `CastMastery` (passive mastery)

> รวบรวมภูมิปัญญาเพื่อเร่งการร่ายเวท
> สูญเสีย ATK เพื่อแลกกับการเพิ่มขึ้นของ CSPD
> ตามสถานะการเรียนรู้ของสกิลจอมเวทย์
> *พลังโจมตีของปีศาจรับใช้ไม่ลดลง

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| AtkRate | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 |

- `Cspd` = `(this.allWizardSkillLevel * Lv)`
- `CspdRate` = `((this.learnWizardSkillNum * (Lv >> 1)) + Lv)`

---

### ไลท์นิ่ง (Lightning) · uid 1027

<img src="../../icons/sk_1027.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 2) · **Type:** Object · **Max Lv:** 35 · **Weapons:** Rod, Magictool, SubMagictool · **Requires:** แฟมิเรีย · **Client class:** `LightningAction`

> คำสั่งให้ปีศาจรับใช้เวทสายฟ้า
> โจมตีเป้าหมายด้วยเวทธาตุลม
> มีโอกาสทำให้เป้าหมายติด[อัมพาต]

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 80 | 80 | 80 | 80 | 80 | 80 | 80 | 80 | 80 | 80 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `((((Lv * 30) + 400) + HighFamiliaAction.GetLightningPowerUpValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1032, 1))) / 100)`

**Role:** attack (deals damage) · applies status ailment · placed object / trap / summon

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `80`
- `SkillRate` multiplies by (adds into): `((((Lv * 30) + 400) + HighFamiliaAction.GetLightningPowerUpValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1032, 1))) / 100)`

**Mechanics recovered from code**

- **Loop / hit-repeat count** (`LoopParam`): `1` = 1

**Proration:** slot `Magic`, mode `first_hit_per_target if class check passes`, attack type `Magic`, action id 1027

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`
- set `Element` = `3` = 3

**`InitializeOthers`** (2 paths)

- set `ActionRange` = `-1` = -1

**`ActionPreparation`** (13 paths)

- set `SkillParam` = `(SkillParam | 16)` — when !PlayerAttackBase.CheckSkillParamFlag(this, 256) AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND PlayerAttackBase.IsBlank(this) AND SkillActionBase.checkPercent(this, 100, 30) OR !PlayerAttackBase.CheckSkillParamFlag(this, 256) AND !PlayerAttackBase.IsBlank(this) AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND PlayerAttackBase.get_ActionID() eq 0 AND SkillActionBase.checkPercent(this, 100, 30) OR !PlayerAttackBase.CheckSkillParamFlag(this, 256) AND !PlayerAttackBase.IsBlank(this) AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND PlayerAttackBase.ContainsNotApplicableSkill(PlayerAttackBase.get_ActionID()) AND PlayerAttackBase.get_ActionID() ne 0 AND SkillActionBase.checkPercent(this, 100, 30)

**`calcPlayerToMobDamage`** (8 paths)

- template `AddRate[SkillRate]` = `((((Lv * 30) + 400) + HighFamiliaAction.GetLightningPowerUpValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1032, 1))) / 100)`
- template `AddConstant[SkillConstantDamage]` = `80`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(6, (Lv + (Lv << 1)), playerAction)`
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(6, 0)` — when PlayerAttackBase.checkAbnormalPercent(this, 6, (Lv + (Lv << 1)), playerAction)
- info `templates` = `1`

**`InitializeHighFamilia`** (1 path)

- set `SkillParam` = `(SkillParam | 256)`
- set `LoopParam` = `1` = 1

</details>

---

### บลิซซาร์ด (Blizzard) · uid 1028

<img src="../../icons/sk_1028.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 2) · **Type:** Object · **Max Lv:** 35 · **Weapons:** Rod, Magictool, SubMagictool · **Requires:** แฟมิเรีย · **Client class:** `BlizzardAction`

> คำสั่งให้ปีศาจรับใช้เวทพายุหิมะโจมตี
> สร้างความเสียหายต่อเนื่องด้วยเวทธาตุน้ำเป็นบริเวณกว้าง
> มีโอกาสทำให้เป้าหมายติด[แช่แข็ง]

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((HighFamiliaAction.GetBlizzardPowerUpValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1032, 1)) + ((Lv + (Lv << 2)) + 100))) / 100)`

**Role:** attack (deals damage) · applies status ailment · placed object / trap / summon

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(100)`
- `SkillRate` multiplies by (adds into): `(((HighFamiliaAction.GetBlizzardPowerUpValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1032, 1)) + ((Lv + (Lv << 2)) + 100))) / 100)`
- `ExpRate` sets: `(target.ExpDefMagic / 100)` | `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**Mechanics recovered from code**

- **Effect percent** (`percent`): `Lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
- **Attack range** (`attackRange`): `MathUtil.DisplayMeterToDistance(8)`
- **Max attacks** (`maxAttackCount`): `(int((Lv * 0.3)) + 3)` → Lv1..10 [3, 3, 3, 4, 4, 4, 5, 5, 5, 6]
- **Loop / hit-repeat count** (`LoopParam`): `1` = 1

**Proration:** slot `Magic`, mode `first_hit_per_target if class check passes`, attack type `Magic`, action id 1028

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`
- set `Element` = `2` = 2
- set `skillRate` = `(HighFamiliaAction.GetBlizzardPowerUpValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1032, 1)) + ((Lv + (Lv << 2)) + 100))`
- set `fixAddDamage` = `100` = 100
- set `percent` = `Lv` → Lv1..10: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
- set `attackRange` = `MathUtil.DisplayMeterToDistance(8)`
- set `SkillIndividualFlag` = `int((MathUtil.DisplayMeterToDistance(8) * 10))`
- set `maxAttackCount` = `(int((Lv * 0.3)) + 3)` → Lv1..10: [3, 3, 3, 4, 4, 4, 5, 5, 5, 6]

**`InitializeOthers`** (2 paths)

- set `ActionRange` = `-1` = -1

**`ActionPreparation`** (13 paths)

- set `SkillParam` = `(SkillParam | 16)` — when !PlayerAttackBase.CheckSkillParamFlag(this, 256) AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND PlayerAttackBase.IsBlank(this) AND SkillActionBase.checkPercent(this, 100, 30) OR !PlayerAttackBase.CheckSkillParamFlag(this, 256) AND !PlayerAttackBase.IsBlank(this) AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND PlayerAttackBase.get_ActionID() eq 0 AND SkillActionBase.checkPercent(this, 100, 30) OR !PlayerAttackBase.CheckSkillParamFlag(this, 256) AND !PlayerAttackBase.IsBlank(this) AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND PlayerAttackBase.ContainsNotApplicableSkill(PlayerAttackBase.get_ActionID()) AND PlayerAttackBase.get_ActionID() ne 0 AND SkillActionBase.checkPercent(this, 100, 30)

**`ActionStart`** (1 path)

- set `mainTarget` = `UnityEngine.GameObject.get_transform(target)`

**`calcPlayerToMobDamage`** (16 paths)

- template `SetRate[ExpRate]` = `(target.ExpDefMagic / 100)`
- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- calls `PlayerAttackBase.SetBufferConstantDamage` = `SetBufferConstantDamage(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), maxAttackCount)`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(9, percent, playerAction)`
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(9, 0)` — when PlayerAttackBase.checkAbnormalPercent(this, 9, percent, playerAction)
- info `templates` = `1`
- template `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**`InitializeHighFamilia`** (1 path)

- set `SkillParam` = `(SkillParam | 256)`
- set `LoopParam` = `1` = 1

</details>

---

### คริสตัลเลเซอร์ (CrystalLaser) · uid 1034

<img src="../../icons/sk_1034.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 2) · **Type:** Object · **Max Lv:** 35 · **Weapons:** Rod, MainMagictool · **Requires:** มานาคริสตัล · **Client class:** `CrystalLaserAction`

> ยิงมานาจากมานาคริสตัลเป็นเส้นตรงเพื่อโจมตี
> ฟื้นฟู MP ของสมาชิกปาร์ตี้ในระยะโจมตีเล็กน้อย

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 7.3 | 7.6 | 7.9 | 8.2 | 8.5 | 8.8 | 9.1 | 9.4 | 9.7 | 10 |
| Flat dmg + | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 | 200 |

**Role:** attack (deals damage) · placed object / trap / summon

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` sets: `(200)`
- `SkillRate` sets: `((((Lv * 30) + 700)) / 100)`

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 1034

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`
- set `Element` = `7` = 7
- set `skillRate` = `((Lv * 30) + 700)` → Lv1..10: [730, 760, 790, 820, 850, 880, 910, 940, 970, 1000]
- set `fixAddDamage` = `200` = 200

**`InitializeOthers`** (2 paths)

- set `ActionRange` = `-1` = -1
- set `failure` = `1` = 1 — when SkillIndividualFlag eq -1

**`ActionStart`** (9 paths)

- set `attackDir` = `((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312))) / fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312))) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)))) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))))` — when !PlayerAttackBase.IsBlank(this) AND ManaCrystalBuf.StartCrystalLaser(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND failure ne 0 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312))) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)))) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND ManaCrystalBuf.StartCrystalLaser(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND failure eq 0 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312))) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)))) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))) gt 1e-05
- set `attackDir.y` = `((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) / fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312))) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)))) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))))` — when !PlayerAttackBase.IsBlank(this) AND ManaCrystalBuf.StartCrystalLaser(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND failure ne 0 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312))) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)))) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND ManaCrystalBuf.StartCrystalLaser(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND failure eq 0 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312))) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)))) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))) gt 1e-05
- set `attackDir.z` = `((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) / fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312))) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)))) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))))` — when !PlayerAttackBase.IsBlank(this) AND ManaCrystalBuf.StartCrystalLaser(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND failure ne 0 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312))) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)))) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))) gt 1e-05 OR !PlayerAttackBase.IsBlank(this) AND ManaCrystalBuf.StartCrystalLaser(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND failure eq 0 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312))) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)))) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))) gt 1e-05
- set `target` = `target` — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) OR !ManaCrystalBuf.StartCrystalLaser(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)) AND !PlayerAttackBase.IsBlank(this) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND ManaCrystalBuf.StartCrystalLaser(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND failure ne 0 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312))) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)))) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))) gt 1e-05
- set `SkillIndividualFlag` = `-1` = -1 — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) OR !ManaCrystalBuf.StartCrystalLaser(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)) AND !PlayerAttackBase.IsBlank(this) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND ManaCrystalBuf.StartCrystalLaser(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND failure ne 0 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312))) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)))) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))) gt 1e-05
- set `attackDir` = `UnityEngine.Vector3.static+0x0` — when !PlayerAttackBase.IsBlank(this) AND ManaCrystalBuf.StartCrystalLaser(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND failure ne 0 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312))) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)))) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))) le 1e-05 OR !PlayerAttackBase.IsBlank(this) AND ManaCrystalBuf.StartCrystalLaser(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND failure eq 0 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312))) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)))) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))) le 1e-05
- set `attackDir.y` = `UnityEngine.Vector3.static+0x4` — when !PlayerAttackBase.IsBlank(this) AND ManaCrystalBuf.StartCrystalLaser(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND failure ne 0 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312))) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)))) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))) le 1e-05 OR !PlayerAttackBase.IsBlank(this) AND ManaCrystalBuf.StartCrystalLaser(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND failure eq 0 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312))) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)))) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))) le 1e-05
- set `attackDir.z` = `UnityEngine.Vector3.static+0x8` — when !PlayerAttackBase.IsBlank(this) AND ManaCrystalBuf.StartCrystalLaser(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND failure ne 0 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312))) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)))) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))) le 1e-05 OR !PlayerAttackBase.IsBlank(this) AND ManaCrystalBuf.StartCrystalLaser(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026) ne 0 AND UnityEngine.Object.op_Inequality(actarAction) AND failure eq 0 AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312))) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - StartCrystalLaser.pos(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)))) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))) le 1e-05
- set `failure` = `1` = 1 — when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) OR !ManaCrystalBuf.StartCrystalLaser(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026), (this + 312)) AND !PlayerAttackBase.IsBlank(this) AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1026) ne 0 AND UnityEngine.Object.op_Inequality(actarAction)

**`calcPlayerToMobDamage`** (2 paths)

- template `SetRate[SkillRate]` = `(skillRate / 100)`
- template `SetConstant[SkillConstantDamage]` = `fixAddDamage`
- info `templates` = `1`

**`ActionSkillEvent`** (123 paths)

- set `attackDir` = `((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - crystalPos) / fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - crystalPos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - crystalPos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))))` — when fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - crystalPos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - crystalPos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))) gt 1e-05 AND param eq 101 AND param ne 102
- set `attackDir.y` = `((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) / fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - crystalPos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - crystalPos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))))` — when fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - crystalPos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - crystalPos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))) gt 1e-05 AND param eq 101 AND param ne 102
- set `attackDir.z` = `((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) / fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - crystalPos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - crystalPos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))))` — when fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - crystalPos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - crystalPos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))) gt 1e-05 AND param eq 101 AND param ne 102
- set `attackDir` = `UnityEngine.Vector3.static+0x0` — when fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - crystalPos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - crystalPos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))) le 1e-05 AND param eq 101 AND param ne 102
- set `attackDir.y` = `UnityEngine.Vector3.static+0x4` — when fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - crystalPos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - crystalPos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))) le 1e-05 AND param eq 101 AND param ne 102
- set `attackDir.z` = `UnityEngine.Vector3.static+0x8` — when fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - crystalPos.z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - crystalPos) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - crystalPos)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - crystalPos.y))))) le 1e-05 AND param eq 101 AND param ne 102
- calls `Toram.Common.Actions.TargetPlayerData..ctor` = `.ctor()` — when !PartyManager.get_IsParty(Singleton<PartyManager>.get_Instance()) AND !UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 102 OR !PartyManager.get_IsParty(Singleton<PartyManager>.get_Instance()) AND MobaMode ne 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 102 OR !PartyManager.get_IsParty(Singleton<PartyManager>.get_Instance()) AND MobaMode eq 0 AND UnityEngine.Object.op_Equality(actarAction) AND UnityEngine.Object.op_Inequality(actarAction) AND param eq 102

</details>

---

### เมเทโอสตอร์มสไตร์ค (MeteorStrike) · uid 1029

<img src="../../icons/sk_1029.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 3) · **Type:** Object · **Max Lv:** 125 · **Weapons:** Rod, Magictool, SubMagictool · **Requires:** บลิซซาร์ด · **Client class:** `MeteorStrikeAction`

>  คำสั่งให้ปีศาจรับใช้เวทอุกกาบาต
> อุกกาบาต 3 ก้อนจะตกสู่เป้าหมายที่อยู่ใกล้
> มีโอกาสทำให้เป้าหมายติด[ไหม้ไฟ]และ[ตาลาย]
> ขอเตือนว่าความแม่นนั้นขึ้นอยู่กับดวง

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Flat dmg + | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 | 300 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((HighFamiliaAction.GetMeteorStrikePowerUpValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1032, 1)) + ((Lv * 100) + 500))) / 100)`

**Role:** attack (deals damage) · applies status ailment · placed object / trap / summon

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(300)`
- `SkillRate` multiplies by (adds into): `(((HighFamiliaAction.GetMeteorStrikePowerUpValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1032, 1)) + ((Lv * 100) + 500))) / 100)`
- `ExpRate` sets: `(target.ExpDefMagic / 100)` | `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**Mechanics recovered from code**

- **Attack range** (`attackRange`): `MathUtil.DisplayMeterToDistance(3)`
- **Loop / hit-repeat count** (`LoopParam`): `status.Luk`; `luk`
- **Cast time modifier** (`CastTime`): `1` = 1

**Proration:** slot `Magic`, mode `first_hit_per_target if class check passes`, attack type `Magic`, action id 1029

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`
- set `Element` = `1` = 1
- set `SubElement` = `4` = 4
- set `skillRate` = `(HighFamiliaAction.GetMeteorStrikePowerUpValue(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1032, 1)) + ((Lv * 100) + 500))`
- set `fixAddDamage` = `300` = 300
- set `ignitionPercent` = `((Lv + (Lv << 2)) + 50)` → Lv1..10: [55, 60, 65, 70, 75, 80, 85, 90, 95, 100]
- set `dizzyPercent` = `(Lv + (Lv << 2))` → Lv1..10: [5, 10, 15, 20, 25, 30, 35, 40, 45, 50]
- set `attackRange` = `MathUtil.DisplayMeterToDistance(3)`
- set `rand` = `new System.Random`
- set `luk` = `status.Luk`
- set `LoopParam` = `status.Luk`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1
- set `luk` = `motionSpeed`

**`ActionPreparation`** (13 paths)

- set `isSingleShot` = `(hasGemCart(1022) & 1)`
- set `SkillParam` = `(SkillParam | 16)` — when !PlayerAttackBase.CheckSkillParamFlag(this, 256) AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND PlayerAttackBase.IsBlank(this) AND SkillActionBase.checkPercent(this, 100, 30) OR !PlayerAttackBase.CheckSkillParamFlag(this, 256) AND !PlayerAttackBase.IsBlank(this) AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND PlayerAttackBase.get_ActionID() eq 0 AND SkillActionBase.checkPercent(this, 100, 30) OR !PlayerAttackBase.CheckSkillParamFlag(this, 256) AND !PlayerAttackBase.ContainsNotApplicableSkill(PlayerAttackBase.get_ActionID()) AND !PlayerAttackBase.IsBlank(this) AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 13) AND PlayerAttackBase.get_ActionID() ne 0 AND SkillActionBase.checkPercent(this, 100, 30)

**`NextRangeHit`** (2 paths)

- set `nowAttackCount` = `(nowAttackCount + 1)`

**`calcPlayerToMobDamage`** (32 paths)

- template `SetRate[ExpRate]` = `(target.ExpDefMagic / 100)`
- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- calls `PlayerAttackBase.SetBufferConstantDamage` = `SetBufferConstantDamage(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), LoopParam)`
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(8, ignitionPercent, playerAction)` — when PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 8, ignitionPercent, playerAction) AND isSingleShot eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 8, ignitionPercent, playerAction) AND isSingleShot eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 8, ignitionPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND isSingleShot eq 0
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(8, 0)` — when PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 8, ignitionPercent, playerAction) AND isSingleShot eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 8, ignitionPercent, playerAction) AND isSingleShot eq 0
- calls `PlayerAttackBase.checkAbnormalPercent` = `checkAbnormalPercent(14, dizzyPercent, playerAction)` — when PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 8, ignitionPercent, playerAction) AND isSingleShot eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 8, ignitionPercent, playerAction) AND isSingleShot eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 8, ignitionPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND isSingleShot eq 0
- calls `SkillDamageData.SetAbnormalType` = `SetAbnormalType(14, 0)` — when PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 8, ignitionPercent, playerAction) AND isSingleShot eq 0 OR !PlayerAttackBase.checkAbnormalPercent(this, 8, ignitionPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 14, dizzyPercent, playerAction) AND isSingleShot eq 0
- info `templates` = `1`
- template `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

**`InitializeHighFamilia`** (2 paths)

- set `SkillParam` = `(SkillParam | 256)`
- set `isSingleShot` = `(hasGemCart(1022) & 1)` — when UnityEngine.Object.op_Inequality(actarAction)
- set `CastTime` = `1` = 1
- set `LoopParam` = `luk`

**`SetHideAttack`** (1 path)

- set `hideAttackApplied` = `(active & 1)`

</details>

---

### สโตนสกิล (StoneSkin) · uid 1030

<img src="../../icons/sk_1030.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 3) · **Type:** Support · **Max Lv:** 125 · **Weapons:** Rod, Magictool, SubMagictool · **Requires:** มานาคริสตัล · **Client class:** `StoneSkinAction`

>  คำสั่งให้ปีศาจรับใช้เวทป้องกัน
> จะติดบาเรียลดความเสียหายได้ในระดับหนึ่งแต่
> ความเสียหายจากไหม้ไฟและพิษจะเพิ่มมากขึ้น(ข้อเสีย)
> ไม่สามารถใช้ซ้อนกันได้

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1030

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

</details>

**Buffs**

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

---

### โอเวอร์ลิมิต (OverLimit) · uid 1035

<img src="../../icons/sk_1035.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 3) · **Type:** Buffer · **Max Lv:** 125 · **Weapons:** Rod, MainMagictool · **Requires:** คริสตัลเลเซอร์ · **Client class:** `OverLimitAction`

> เทคนิคลับเพื่อเพิ่มพลังธาตุเป็นเวลา 90 วินาที
> สำหรับทุกพลังธาตุ(เฉพาะเวทมนตร์)ยกเว้นไร้ธาตุ
> แต่ CSPD จะลดลงและ 1% ของ Max HP จะหายไปทุกครั้งที่ร่ายเวท

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1035

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ActionHit`** (2 paths)

- calls `OverLimitBuf..ctor` = `.ctor(Lv, PlayerActionManagerBase.get_PlayerStatus())` — when UnityEngine.Object.op_Inequality(actarAction)
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new OverLimitBuf, 0)` — when UnityEngine.Object.op_Inequality(actarAction)

</details>

**Buffs**

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

---

### อิมพีเรียลเรย์[PN]อิมพีเรียลบลาสท์[PF]อิมพีเรียลไฟร์[PA]อิมพีเรียลฟรีซ[PW]อิมพีเรียลโกลม[PE]อิมพีเรียลเปตรา[PL]อิมพีเรียลโฮลี่[PD]อิมพีเรียลชาโดว์ (ImperialRay) · uid 1031

<img src="../../icons/sk_1031.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 4) · **Type:** Attack · **Max Lv:** 205 · **Weapons:** Rod, Magictool, SubMagictool · **Requires:** เมเทโอสตอร์มสไตร์ค · **Client class:** `ImperialRayAction`

> เทคนิคการโจมตีด้วยการระเบิดพลังเวทมนตร์ที่ถูกบีบอัด
> ถ้าโดนไล่โจมตีด้วยสกิลเฉพาะเช่นสกิลเวทมนตร์
> จะเกิดการระเบิดครั้งใหญ่จากพลังเวท
> การระเบิดครั้งใหญ่จะติดคริติคอลแน่นอน
> ธาตุที่เป็นจุดอ่อนจะติดอ่อนแอ

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 5.5 | 6 | 6.5 | 7 | 7.5 | 8 | 8.5 | 9 | 9.5 | 10 |
| Flat dmg + | 220 | 240 | 260 | 280 | 300 | 320 | 340 | 360 | 380 | 400 |

**Formulas that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv * 50) + 500) + SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate))) / 100)` — (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0

**Role:** attack (deals damage) · buff (self)

The skill builds one damage template (one hit). For each template the shared engine (`TemplateAssignment`) fills base damage, defence, element, stability and proration; this skill then adds its own terms listed below and `GetDamage()` multiplies them in `CalcStep` order.

Proration uses the **magic proration slot**; never (IsExpDefFluctuate=false)

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Damage formula for this skill** (per template; `int()` after every multiplier)

- Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.
- `SkillConstantDamage` adds: `(((Lv * 20) + 200))`
- `SkillRate` multiplies by (adds into): `(((((Lv * 50) + 500) + SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate))) / 100)`

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`

**Proration:** slot `Magic`, mode `never (IsExpDefFluctuate=false)`, attack type `Magic`, action id 1031

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (6 paths)

- set `ActionRange` = `MathUtil.DisplayMeterToDistance(12)`
- set `Element` = `7` = 7
- set `skillRate` = `(((Lv * 50) + 500) + SkillMasteryBase.GetMasteryParam(MasteryId.SkillRate))` — when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0
- set `fixAddDamage` = `((Lv * 20) + 200)` → Lv1..10: [220, 240, 260, 280, 300, 320, 340, 360, 380, 400]
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 2, PlayerActionManagerBase.get_PlayerStatus())`
- set `skillRate` = `((Lv * 50) + 500)` → Lv1..10: [550, 600, 650, 700, 750, 800, 850, 900, 950, 1000] — when (mainWeapon==Rod & 1) ne 0 OR (mainWeapon==Magictool & 1) ne 0 AND (mainWeapon==Rod & 1) eq 0 OR (mainWeapon==Magictool & 1) eq 0 AND (mainWeapon==Rod & 1) eq 0

**`InitializeOthers`** (1 path)

- set `Element` = `loopCount`
- set `ActionRange` = `-1` = -1

**`ActionStart`** (8 paths)

- set `mainTarget` = `target`
- set `player` = `PlayerDataManager.GetPlayerDataManager()` — when !AutoMemberManager.TryGetAutoMember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager()), (this + 296)) AND !PlayerAttackBase.IsBlank(this) AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 OR !PlayerAttackBase.IsBlank(this) AND AutoMemberManager.TryGetAutoMember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager()), (this + 296)) AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager())) eq 0 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(PlayerObjectBase.get_ActionManager(TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager()))), 0) AND AutoMemberManager.TryGetAutoMember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager()), (this + 296)) AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager())) ne 0
- set `SkillIndividualFlag` = `1` = 1 — when !PlayerAttackBase.IsBlank(this) AND !SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND AutoMemberManager.TryGetAutoMember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager()), (this + 296)) AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager())) ne 0 AND UnityEngine.Object.op_Inequality(PlayerObjectBase.get_ActionManager(TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager()))), 0) OR !PlayerAttackBase.IsBlank(this) AND AutoMemberManager.TryGetAutoMember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager()), (this + 296)) AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND PlayerAttackBase.CheckSkillParamFlag(SkillActionManagerBase.get_CurrentSkill(), 256) AND SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager())) ne 0 AND UnityEngine.Object.op_Inequality(PlayerObjectBase.get_ActionManager(TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager()))), 0)
- set `SkillIndividualFlag` = `0` = 0 — when !AutoMemberManager.TryGetAutoMember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager()), (this + 296)) AND !PlayerAttackBase.IsBlank(this) AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Inequality(PlayerObjectBase.get_ActionManager(TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager()))), 0) AND AutoMemberManager.TryGetAutoMember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager()), (this + 296)) AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager())) ne 0 OR !PlayerAttackBase.CheckSkillParamFlag(SkillActionManagerBase.get_CurrentSkill(), 256) AND !PlayerAttackBase.IsBlank(this) AND AutoMemberManager.TryGetAutoMember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager()), (this + 296)) AND IsInstanceOf(actarAction, PlayerActionManager) eq 1 AND SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager())) ne 0 AND UnityEngine.Object.op_Inequality(PlayerObjectBase.get_ActionManager(TryGetAutoMember.automember(PlayerDataManager.GetPlayerDataManager().AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(PlayerDataManager.GetPlayerDataManager()))), 0)

**`ActionSkillEvent`** (14 paths)

- set `familiaCast` = `1` = 1 — when SkillIndividualFlag eq 1 AND SkillIndividualFlag ne 0 AND TryGetAutoMember.automember(player.AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(player)) ne 0 AND UnityEngine.Object.op_Inequality(PlayerObjectBase.get_ActionManager(TryGetAutoMember.automember(player.AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(player))), 0) AND UnityEngine.Object.op_Inequality(player) AND familiaCast eq 0 AND param eq 255 OR !SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND SkillIndividualFlag eq 0 AND TryGetAutoMember.automember(player.AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(player)) ne 0 AND UnityEngine.Object.op_Inequality(PlayerObjectBase.get_ActionManager(TryGetAutoMember.automember(player.AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(player))), 0) AND UnityEngine.Object.op_Inequality(player) AND familiaCast eq 0 AND param eq 255 OR PlayerAttackBase.CheckSkillParamFlag(SkillActionManagerBase.get_CurrentSkill(), 256) AND SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND SkillIndividualFlag eq 0 AND TryGetAutoMember.automember(player.AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(player)) ne 0 AND UnityEngine.Object.op_Inequality(PlayerObjectBase.get_ActionManager(TryGetAutoMember.automember(player.AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(player))), 0) AND UnityEngine.Object.op_Inequality(player) AND familiaCast eq 0 AND param eq 255
- set `SkillIndividualFlag` = `1` = 1 — when !SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND SkillIndividualFlag eq 0 AND TryGetAutoMember.automember(player.AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(player)) ne 0 AND UnityEngine.Object.op_Inequality(PlayerObjectBase.get_ActionManager(TryGetAutoMember.automember(player.AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(player))), 0) AND UnityEngine.Object.op_Inequality(player) AND familiaCast eq 0 AND param eq 255 OR PlayerAttackBase.CheckSkillParamFlag(SkillActionManagerBase.get_CurrentSkill(), 256) AND SkillActionBase.op_Inequality(SkillActionManagerBase.get_CurrentSkill(), 0) AND SkillIndividualFlag eq 0 AND TryGetAutoMember.automember(player.AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(player)) ne 0 AND UnityEngine.Object.op_Inequality(PlayerObjectBase.get_ActionManager(TryGetAutoMember.automember(player.AutoMemberManager, 8, PlayerDataManager.get_PlayerArchetypeId(player))), 0) AND UnityEngine.Object.op_Inequality(player) AND familiaCast eq 0 AND param eq 255

**`calcPlayerToMobDamage`** (2 paths)

- template `AddRate[SkillRate]` = `(skillRate / 100)`
- template `AddConstant[SkillConstantDamage]` = `fixAddDamage`
- info `templates` = `1`

</details>

**Buffs**

**Buff `ImperialRayBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `CheckMob`, `RegisterMobUid`, `RemoveMobUid`, `UpdateMobUidList`
- Buff fields set in the constructor (all recovered):
  - `targetMobList` = `new System.Collections.Generic.Dictionary<int, bool>`
  - `timer` = `5` = 5
- Hook `Updata`: `timer`=5; `timer`=(timer - UnityEngine.Time.get_deltaTime())

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `MobaPlayerBattleManager$$PursuitImperialRayAttack (GetSkillLv)`
- `PlayerBattleManager$$PursuitImperialRayAttack (GetSkillLv)`

---

### ไฮแฟมิเรีย (HighFamilia) · uid 1032

<img src="../../icons/sk_1032.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 4) · **Type:** Special · **Max Lv:** 205 · **Weapons:** Rod, Magictool, SubMagictool · **Requires:** สโตนสกิล · **Client class:** `HighFamiliaAction`

> อัญเชิญปีศาจรับใช้ ทำให้มันเกิดอารมณ์แปรปรวน
> ร่ายเวทไลท์นิ่ง,บลิซซาร์ด,เมเทโอสตอร์มสไตร์ค
> ออกมาแบบสุ่มชั่วระยะเวลาหนึ่ง
> ประสิทธิภาพของปีศาจรับใช้ สกิลที่ปล่อย
> ะขึ้นอยู่กับระดับการเรียนรู้ของตัวเอง

<details><summary>In-game level notes</summary>

- Lv14: [รับเอฟเฟกต์เดียวกันเมื่อใช้กับอุปกรณ์เวทมนตร์] เมื่อระดับสกิลเพิ่มขึ้นพลังของ ไลท์นิ่ง,บลิซซาร์ด,เมเทโอสตอร์มสไตร์คจะเพิ่มขึ้น

</details>

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0.1, PlayerActionManagerBase.get_PlayerStatus())`

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1032

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (1 path)

- set `ActionRange` = `-1` = -1
- set `CastTime` = `PlayerAttackBase.CalcCastTime(this, 0.1, PlayerActionManagerBase.get_PlayerStatus())`

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

</details>

**Buffs**

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

<details><summary>Effect applied in `PlayerBattleManager$$PursuitAttack` (130 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `BlizzardAction$$IsFailure` (2 guarded paths)</summary>

- always
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
- always
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`

</details>

<details><summary>Effect applied in `CrystalLaserAction$$IsFailure` (2 guarded paths)</summary>

- always
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
- always
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`

</details>

<details><summary>Effect applied in `LightningAction$$IsFailure` (2 guarded paths)</summary>

- always
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
- always
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`

</details>

<details><summary>Effect applied in `ManaCrystalAction$$IsFailure` (2 guarded paths)</summary>

- always
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
- always
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`

</details>

<details><summary>Effect applied in `MeteorStrikeAction$$IsFailure` (2 guarded paths)</summary>

- always
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `PlayerAttackBase$$IsFailure`
- always
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`

</details>

<details><summary>Effect applied in `StoneSkinAction$$IsFailure` (3 guarded paths)</summary>

- always
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerAttackBase.get_ActionID`
- always
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerAttackBase.get_ActionID`, `PlayerAttackBase$$IsFailure`
- always
  - returns `1`
  - calls `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual PlayerStatusBase.get_SkillBufferManager`

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `BlizzardAction$$IsFailure (ContainsBuffer)`
- `BlizzardAction$$OnInitialize (GetSkillLv)`
- `CrystalLaserAction$$IsFailure (ContainsBuffer)`
- `FamiliaActionManager$$UpdateHighFamilia (GetSkillLv)`
- `LightningAction$$IsFailure (ContainsBuffer)`
- `LightningAction$$calcPlayerToMobDamage (GetSkillLv)`
- `ManaCrystalAction$$IsFailure (ContainsBuffer)`
- `MeteorStrikeAction$$IsFailure (ContainsBuffer)`
- `MeteorStrikeAction$$OnInitialize (GetSkillLv)`
- `PlayerBattleManager$$PursuitAttack (ContainsBuffer)`
- `StoneSkinAction$$IsFailure (ContainsBuffer)`
- `UIFamiliarSelectManager$$UpdateRushSwitchButton (GetSkillLv)`

---

### ซอร์ดเซอรีไกด์ (MagicalGuidance) · uid 1036

<img src="../../icons/sk_1036.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 4) · **Type:** Mastery · **Max Lv:** 205 · **Weapons:** Rod, MainMagictool · **Requires:** โอเวอร์ลิมิต · **Client class:** `MagicalGuidance` (passive mastery)

> ลดการสูญเสีย CSPD เนื่องจากโอเวอร์ลิมิต
> และเพิ่มพลังธาตุให้มากขึ้น

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| Cspd | 50 | 100 | 150 | 200 | 250 | 300 | 350 | 400 | 450 | 500 |


---

### ของที่แมวทำหล่น (CatsDropItem) · uid 1037

<img src="../../icons/sk_1037.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 285 · **Weapons:** Rod, MainMagictool · **Requires:** ไฮแฟมิเรีย · **Client class:** `CatsDropItem` (passive mastery)

> ถ้าเหลือก็ทิ้งไว้เมี๊ยว
> เมื่อปีศาจรับใช้ร่ายเวทสำเร็จ
> มีโอกาสที่สกิล[มานาคริสตัล]จะถูกติดตั้ง

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Percent | 1 | 4 | 9 | 16 | 25 | 36 | 49 | 64 | 81 | 100 |


---

### การวิจัยเวทมนตร์ (MagicResearch) · uid 1038

<img src="../../icons/sk_1038.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 5) · **Type:** Mastery · **Max Lv:** 285 · **Weapons:** Rod, Magictool, SubMagictool · **Requires:** [N]อิมพีเรียลเรย์[PN]อิมพีเรียลบลาสท์[PF]อิมพีเรียลไฟร์[PA]อิมพีเรียลฟรีซ[PW]อิมพีเรียลโกลม[PE]อิมพีเรียลเปตรา[PL]อิมพีเรียลโฮลี่[PD]อิมพีเรียลชาโดว์[N] · **Client class:** `MagicResearch` (passive mastery)

> เพิ่มความเข้าใจเวทมนตร์ให้ลึกซึ้งผ่านการวิจัย
> เพิ่มพลังของสกิล[อิมพีเรียลเรย์]
> และลดเวลาที่ปีศาจรับใช้ร่ายเวท

**Role:** passive mastery

**Passive bonuses by level** (`GetMasteryParam(MasteryId)`)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Cspd | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| Value | 40 | 80 | 120 | 160 | 200 | 240 | 280 | 320 | 360 | 400 |
| SkillRate | 20 | 40 | 60 | 80 | 100 | 120 | 140 | 160 | 180 | 200 |


---

### ชิฟท์ (Shift) · uid 1039

<img src="../../icons/sk_1039.png" width="40" alt="icon"> 
**Tree:** ウィザードスキル (`WizardSkill`, tier 5) · **Type:** Buffer · **Max Lv:** 285 · **Weapons:** Rod, MainMagictool · **Requires:** ซอร์ดเซอรีไกด์ · **Client class:** `ShiftAction`

> ซ่อนตัวในชั้นมิติเพื่อหลบหนีวิกฤต
> ระหว่างชิฟท์จะไม่สามารถโจมตี และสูญเสียMPอย่างต่อเนื่อง
> แต่จะอยู่ในสถานะคงกระพันตลอด
> และลบค่าเฮทของตนเองออกไป
> ไม่สามารถแสดงผลเมื่อตัวเองถูกเล็งเป้า

<details><summary>In-game level notes</summary>

- Lv14: [จะได้รับผลแบบเดียวกันเมื่อใช้อุปกรณ์เวทมนตร์] ระหว่างชิฟท์ถ้าหลบหลีกความเสียหายจะได้รับ บัฟเพิ่มความเร็วการเคลื่อนที่ตามจำนวนครั้งนั้น(สูงสุด 60 วินาที)

</details>

**Role:** buff (self)

This action never changes monster proration: ExpType None: no proration slot.

It applies the buff(s) listed under **Buffs**; the buff object keeps its own timer and returns bonus values through `GetParam(SkillBufferId)`.

**Mechanics recovered from code**

- **MP cost** (`mp`): `0` = 0 _(when hasBuff(1039))_; `200` = 200 _(when !hasBuff(1039))_

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1039

<details><summary>Recovered formulas (per method)</summary>

**`OnInitialize`** (2 paths)

- set `mp` = `0` = 0 — when hasBuff(1039)
- set `ActionRange` = `-1` = -1
- set `mp` = `200` = 200 — when !hasBuff(1039)

**`InitializeOthers`** (1 path)

- set `ActionRange` = `-1` = -1

**`ReceiveSupport`** (7 paths)

- calls `ShiftBuf..ctor` = `.ctor(skillLv, playerAction)` — when UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<FadeAnimationManager>(UnityEngine.Component.get_gameObject(playerAction)), 0) AND resultData.Flag eq 1 AND resultData.Flag ne 2 OR !UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<FadeAnimationManager>(UnityEngine.Component.get_gameObject(playerAction)), 0) AND resultData.Flag eq 1 AND resultData.Flag ne 2
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new ShiftBuf, 0)` — when UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<FadeAnimationManager>(UnityEngine.Component.get_gameObject(playerAction)), 0) AND resultData.Flag eq 1 AND resultData.Flag ne 2 OR !UnityEngine.Object.op_Inequality(UnityEngine.GameObject.GetComponent<FadeAnimationManager>(UnityEngine.Component.get_gameObject(playerAction)), 0) AND resultData.Flag eq 1 AND resultData.Flag ne 2
- calls `ShiftMotionSpeedBuf..ctor` = `.ctor(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1039).Level, SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1039), 20), PlayerActionManagerBase.get_PlayerStatus())` — when SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1039), 20) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1039) ne 0 AND resultData.Flag eq 2
- calls `SkillBufferManager.AddSelfBuffer` = `AddSelfBuffer(new ShiftMotionSpeedBuf, 0)` — when SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1039), 20) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1039) ne 0 AND resultData.Flag eq 2
- calls `SkillBufferManager.RemoveSelfBuffer` = `RemoveSelfBuffer(1039)` — when SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1039), 20) ge 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1039) ne 0 AND resultData.Flag eq 2 OR SkillBufferDataBase.GetParam(TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1039), 20) lt 1 AND TryGetBuf.buf(PlayerStatusBase.get_SkillBufferManager(), 1039) ne 0 AND resultData.Flag eq 2

</details>

**Buffs**

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

<details><summary>Effect applied in `MobaPlayerActionManager$$Damaged` (8 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `PlayerActionManager$$Damaged` (17 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `ReceiveSupportResult$$OnEventPlayerSupport` (86 guarded paths, truncated)</summary>

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

</details>

<details><summary>Effect applied in `GuardActionManager$$CheckGuardStart` (140 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `MobaPlayerActionManager$$SupportReserve` (48 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `BattleManagerBase$$SupportEntry` (5 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `BattleManagerBase$$BattleEntry` (16 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `MobaPlayerBattleManager$$StartAutoDeviceAttack` (15 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `PlayerBattleManager$$StartAutoDeviceAttack` (15 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `ShiftAction$$OnInitialize` (2 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `PlayerActionManager$$OnActionButton` (28 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `ShiftAction$$ReceiveSupport` (4 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `MobaPlayerActionManager$$OnActionButton` (76 guarded paths)</summary>

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

</details>

<details><summary>Effect applied in `MobaPlayerActionManager$$BattleReserve` (300 guarded paths, truncated)</summary>

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

</details>

<details><summary>Effect applied in `PlayerActionManager$$BattleReserve` (300 guarded paths, truncated)</summary>

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

</details>

<details><summary>Effect applied in `PlayerActionManager$$SupportReserve` (300 guarded paths, truncated)</summary>

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

</details>

**Code that reads this skill** (level / buff lookups with a constant skill id; where its effect is applied)

- `AvoidActionManager$$CheckAvoidStart (ContainsBuffer)`
- `BattleManagerBase$$BattleEntry (ContainsBuffer)`
- `BattleManagerBase$$SupportEntry (ContainsBuffer)`
- `GuardActionManager$$CheckGuardStart (ContainsBuffer)`
- `MobaPlayerActionManager$$BattleReserve (ContainsBuffer)`
- `MobaPlayerActionManager$$Damaged (TryGetBuf)`
- `MobaPlayerActionManager$$OnActionButton (ContainsBuffer)`
- `MobaPlayerActionManager$$SupportReserve (ContainsBuffer)`
- `MobaPlayerBattleManager$$StartAutoDeviceAttack (ContainsBuffer)`
- `PlayerActionManager$$BattleReserve (ContainsBuffer)`
- `PlayerActionManager$$Damaged (TryGetBuf)`
- `PlayerActionManager$$OnActionButton (ContainsBuffer)`
- `PlayerActionManager$$SupportReserve (ContainsBuffer)`
- `PlayerBattleManager$$StartAutoDeviceAttack (ContainsBuffer)`
- `ReceiveSupportResult$$OnEventPlayerSupport (TryGetBuf)`
- `ShiftAction$$OnInitialize (ContainsBuffer)`
- `ShiftAction$$ReceiveSupport (TryGetBuf)`

---
