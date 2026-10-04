# ダークパワースキル (`DarkPowerSkill`) — skill details

12 entries.

### บลัดดี้ไบท์ (BloodBite) · uid 1057

<img src="../../icons/sk_1057.png" width="40" alt="icon"> 
**Tree:** ダークパワースキル (`DarkPowerSkill`, tier 1) · **Type:** Attack · **Max Lv:** 1 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** NoMarketSearch · **Client class:** `BloodBiteAction`

> ศาสตร์มืดที่ดูดเลือดของศัตรูมาหล่อเลี้ยง
> สร้างความเสียหายให้กับเป้าหมาย
> และดูดซับค่าความเสียหายบางส่วนมาเป็น HP ของตัวเอง
> ปริมาณการฟื้นฟูจะขึ้นอยู่กับเลเวลของตัวเอง

**How it works**

- Attack skill of the ダークパワースキル tree (tier 1, max Lv 1); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It restores HP or MP.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×1.1 at Lv1 to 2 at Lv10; flat damage +100
- Proration: physical-skill proration slot, mode `first_hit_per_target`.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(4)`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 6 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionHit` — when the attack connects: 1 set, 1 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 set, 2 tpl, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 1.1 | 1.2 | 1.3 | 1.4 | 1.5 | 1.6 | 1.7 | 1.8 | 1.9 | 2 |
| Flat dmg + | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv * 10) + 100) + gemCart(1015[4]))) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1057
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): removes the caster's buff of skill 1059 (DarkStinger) — `RemoveSelfBuffer(1059)`
  - when `IsInstanceOf(actarAction, MobaPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction)`

**Other recovered parameters**

- **HP recovery cap** (`maxHpRecovery`): `int(((EternalNightmareBuf.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1064], 0) * ((status.Lv + (status.Lv << 2)) << 1)) * 0.01))`; `((status.Lv + (status.Lv << 2)) << 1)`
- **HP recovered** (`hpRecovery`): `(int((((DarkStingerBuf.GetParam(50) * DarkStingerBuf.GetParam(50)) * status.MaxHp) * 0.01)) + hpRecovery)` _(when IsInstanceOf(actarAction, MobaPlayerActionManager) ne 1 AND UnityEngine.Object.op_Inequality(actarAction))_; `int((((recoveryRate * [PlayerAttackBase.templateToDamageData(this, new SkillActionBase.DamageData, PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 1)+0x18]) * 0.01) mi maxHpRecovery ? ((recoveryRate * [PlayerAttackBase.templateToDamageData(this, new SkillActionBase.DamageData, PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 1)+0x18]) * 0.01) : maxHpRecovery))`

_Raw recovered data (every method item): [trees/DarkPowerSkill.md](../trees/DarkPowerSkill.md) — uid 1057_

---

### แซครีไฟซ์ (Sacrifice) · uid 1058

<img src="../../icons/sk_1058.png" width="40" alt="icon"> 
**Tree:** ダークパワースキル (`DarkPowerSkill`, tier 1) · **Type:** Special · **Max Lv:** 1 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** NoMarketSearch · **Client class:** `SacrificeAction`

> สาปศัตรูด้วยการเสียสละพลังชีวิตตัวเอง
> ใช้ 10% ของค่า HP สูงสุดเพื่อสร้างความเสียหายพิเศษ
> จะหมดสติในกรณีที่ HP มีไม่เพียงพอ

**How it works**

- Special skill of the ダークパワースキル tree (tier 1, max Lv 1); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Damage:
  - `calcPlayerToMobDamage`: skill multiplier ×6 at Lv1 to 10 at Lv10
- Proration: physical-skill proration slot, mode `never (IsExpSkill excludes ActionID)`.
- Buffs:
  - `SoulHuntBuf`: marker buff (no parameters; other code tests whether it is present)
  - `CountBufferBase`

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(4)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 5 set
- `ActionStart` — when the cast starts: 1 set, 1 call
- `CheckPayHp` — skill-specific method: 2 call
- `StrengthPayHp` — skill-specific method: 1 call
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 1 set, 8 tpl
- `via PlayerAttackBase$$HitReactionAssign` — skill-specific method: 1 call, 2 tpl

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 6 | 7 | 8 | 9 | 10 | 10 | 10 | 10 | 10 | 10 |

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[BaseDamage]` = `int((((10) * status.MaxHp) * 89129))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv * 100) lo 500 ? (Lv * 100) : 500) + 500)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[StableRate]` = `PlayerAttackBase.CalcStable(SacrificeAction.get_AttackType(), ((EternalNightmareBuf.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1064], 1) + ((Lv eq 10 ? 45 : 35) + ((Lv hi 5 ? Lv : 5) + ((Lv hi 5 ? Lv : 5) << 2))))), (SkillCalcTemplate.CheckStepResult(PlayerAttackBase.HitReactionAssign(this, new SkillCalcTemplate, playerAction, mobAction), 4) & 1), PlayerActionManagerBase.get_PlayerStatus())`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[ExpRate]` = `((100 - max(target.CutAttack)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[LastDamageRate]` = `(1 - MobPropertyLifeReduceDamage.CalcReduceLastDamageRate(TryGetProperties<object>.out2(mobAction, 90, PlayerActionManagerBase.get_PlayerStatus())))`
  - when `IsInstanceOf(mobAction, GuildRaidBossMobActionManager) eq 1 AND TryGetProperties<object>.out2(mobAction, 90, PlayerActionManagerBase.get_PlayerStatus()) ne 0 OR CheckDamageLimit.max(this, mobAction) ne -1 AND CheckDamageLimit.min(this, mobAction) ne -1 AND IsInstanceOf(mobAction, GuildRaidBossMobActionManager) eq 1 AND TryGetProperties<object>.out2(mobAction, 90, PlayerActionManagerBase.get_PlayerStatus()) ne 0 OR CheckDamageLimit.max(this, mobAction) eq -1 AND CheckDamageLimit.min(this, mobAction) ne -1 AND IsInstanceOf(mobAction, GuildRaidBossMobActionManager) eq 1 AND TryGetProperties<object>.out2(mobAction, 90, PlayerActionManagerBase.get_PlayerStatus()) ne 0`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetConstant[DamageLimit]` = `CheckPlayerDamageUpLimit.limitDamage(this, playerAction, mobAction)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[MinDamage]` = `CheckDamageLimit.min(this, mobAction)`
  - when `CheckDamageLimit.max(this, mobAction) ne -1 AND CheckDamageLimit.min(this, mobAction) ne -1 AND IsInstanceOf(mobAction, GuildRaidBossMobActionManager) eq 1 OR CheckDamageLimit.max(this, mobAction) eq -1 AND CheckDamageLimit.min(this, mobAction) ne -1 AND IsInstanceOf(mobAction, GuildRaidBossMobActionManager) eq 1 OR CheckDamageLimit.max(this, mobAction) ne -1 AND CheckDamageLimit.min(this, mobAction) ne -1 AND IsInstanceOf(mobAction, GuildRaidBossMobActionManager) ne 1`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[MaxDamage]` = `CheckDamageLimit.max(this, mobAction)`
  - when `CheckDamageLimit.max(this, mobAction) ne -1 AND CheckDamageLimit.min(this, mobAction) ne -1 AND IsInstanceOf(mobAction, GuildRaidBossMobActionManager) eq 1 OR CheckDamageLimit.max(this, mobAction) ne -1 AND CheckDamageLimit.min(this, mobAction) eq -1 AND IsInstanceOf(mobAction, GuildRaidBossMobActionManager) eq 1 OR CheckDamageLimit.max(this, mobAction) ne -1 AND CheckDamageLimit.min(this, mobAction) ne -1 AND IsInstanceOf(mobAction, GuildRaidBossMobActionManager) ne 1`
- `via PlayerAttackBase$$HitReactionAssign` (method): `SetCalcValue[GuardPower]` = `System.Math.Max(0, (25 - MobBuffer.GuardUpBuff.get_GuardUpval(TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4))))`
  - when `!MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND TryGetBuff.buff(MobActionManagerBase.get_BuffManager(mobAction), 4) ne 0 AND attackType ne 2 AND comboType ne 3`
- `via PlayerAttackBase$$HitReactionAssign` (method): `SetCalcValue[GuardPower]` = `25`
  - when `!MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) ne 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND ((1 | isCritical) & 1) eq 0 AND (False & 1) eq 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType eq 2 AND comboType ne 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND (False & 1) eq 0 AND AbnormalStateManager.Contains(PlayerStatusBase.get_AbnormalStatusManager(), 33) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 2 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) ne 0 AND attackType ne 2 AND comboType ne 3`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `never (IsExpSkill excludes ActionID)`, attack type `Physics`, action id 1058
- Uses the physical-skill proration slot but never changes monster proration: IsExpSkill excludes ActionID.

**Status ailments**

- Extra percent roll `CheckPercent` (`ActionStart`)
  - when `!UnityEngine.Object.op_Equality(actarAction) AND MathUtil.CheckPercent(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) << 2)) << 1)) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) ge 1 AND hasGemCart(401) OR !MathUtil.CheckPercent(((SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) + (SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) << 2)) << 1)) AND !UnityEngine.Object.op_Equality(actarAction) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 46, 1) ge 1 AND hasGemCart(401)`
- Extra percent roll `CheckPercent` (`via PlayerAttackBase$$HitReactionAssign`)
  - when `!MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) ne 0 AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3 OR !MobActionManagerBase.get_SystemInvincible(mobAction) AND !SkillActionBase.op_Inequality(this) AND ((1 | isCritical) & 1) eq 0 AND MathUtil.CheckPercent(SkillComboState.GetThirdEyeValue(_currentSkillCombo)) AND MobaMode eq 0 AND PlayerAttackBase.CalcHitReaction(this, attackType, playerAction, mobAction) eq 0 AND attackType eq 2 AND comboType eq 3`

**Buffs and effects it installs or removes**

- `CheckPayHp` (method): constructs `SoulHuntBuf` — `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1))`
  - when `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND consumptionHp ge 1 AND consumptionHp lt (PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp) AND hasBuff(1061) OR !hasBuff(1061) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND consumptionHp ge 1 AND consumptionHp lt (PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp)`
- `CheckPayHp` (method): adds the caster's buff of `new SoulHuntBuf` — `AddSelfBuffer(new SoulHuntBuf, 0)`
  - when `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND consumptionHp ge 1 AND consumptionHp lt (PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp) AND hasBuff(1061) OR !hasBuff(1061) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND consumptionHp ge 1 AND consumptionHp lt (PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp)`
- `StrengthPayHp` (method): removes the caster's buff of skill 41 (Rampage) — `RemoveSelfBuffer(41)`
  - when `!hasBuff(CrtDamageUp) AND CharacterActionManagerBase.AddAbnormalState(UnityEngine.Component.get_gameObject(actarAction), 3, 3, 0, 0, 0, 1) AND SkillIndividualFlag ne 1 AND UnityEngine.Object.op_Inequality(actarAction)`

**Other recovered parameters**

- **HP consumed** (`consumptionHp`): `int(((consumptionHpRate * status.MaxHp) * 89129))`

**Buff values** (every recovered field; durations in seconds)

**Buff `SoulHuntBuf`**
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:SoulHuntBuf$$.ctor<-SacrificeAction$$CheckPayHp` (no direct constructor call in the skill's own code).
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

_Raw recovered data (every method item): [trees/DarkPowerSkill.md](../trees/DarkPowerSkill.md) — uid 1058_

---

### เนตรมารข่มขวัญ (IntimidatingEvilEye) · uid 1065

<img src="../../icons/sk_1065.png" width="40" alt="icon"> 
**Tree:** ダークパワースキル (`DarkPowerSkill`, tier 1) · **Type:** Attack · **Max Lv:** 1 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Flags:** NoMarketSearch · **Client class:** `IntimidatingEvilEyeAction`

> จ้องมองด้วยสายตาอันเฉียบคมเพื่อข่มขวัญศัตรูให้หวาดกลัว
> ยิ่งเลเวลของเป้าหมายต่ำกว่ายิ่งมีโอกาสมากขึ้นที่จะทำให้ติดผงะ
> ถ้าข่มขวัญไม่สำเร็จจะติดเชื่องช้าแทน
> ไม่สามารถคาดหวังความเสียหายจากการโจมตีนี้ได้

**How it works**

- Attack skill of the ダークパワースキル tree (tier 1, max Lv 1); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×0.01 at Lv1 to 0.1 at Lv10; flat damage +20 at Lv1 to 200 at Lv10
- Proration: magic proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Flinch (1), Slow (11).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 5 set
- `ActionPreparation` — before the cast starts: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 4 call, 1 info
- `InitializeOthers` — setup used when another player's client replays the action: 2 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 0.01 | 0.02 | 0.03 | 0.04 | 0.05 | 0.06 | 0.07 | 0.08 | 0.09 | 0.1 |
| Flat dmg + | 20 | 40 | 60 | 80 | 100 | 120 | 140 | 160 | 180 | 200 |

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((Lv) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv + (Lv << 2)) << 2))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 1065
- Uses the magic proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Chance field `slowPercent` (Slow chance (%)): `100` = 100
- Chance field `flinchPercent` (Flinch chance (%)): `(max(((max(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1), 0) + status.Lv) - target.Level), 0) * Lv)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`
- Rolls `flinchPercent`% to inflict **Flinch (1)** (`calcPlayerToMobDamage`)
  - when `!AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, flinchPercent, playerAction) OR !AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND !PlayerAttackBase.checkAbnormalPercent(this, 1, flinchPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 11, slowPercent, playerAction) OR !AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND !PlayerAttackBase.checkAbnormalPercent(this, 1, flinchPercent, playerAction) AND !PlayerAttackBase.checkAbnormalPercent(this, 11, slowPercent, playerAction)`
- Marks the hit with ailment **Flinch (1)** (`calcPlayerToMobDamage`)
  - when `!AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 1, flinchPercent, playerAction)`
- Rolls `slowPercent`% to inflict **Slow (11)** (`calcPlayerToMobDamage`)
  - when `AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 11, slowPercent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 11, slowPercent, playerAction) AND AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) OR !AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND !PlayerAttackBase.checkAbnormalPercent(this, 1, flinchPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 11, slowPercent, playerAction)`
- Marks the hit with ailment **Slow (11)** (`calcPlayerToMobDamage`)
  - when `AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND PlayerAttackBase.checkAbnormalPercent(this, 11, slowPercent, playerAction) OR !AbnormalStateManager.ContainsAbnormal(MobActionManagerBase.get_AbnormalStateManager(mobAction), 1) AND !PlayerAttackBase.checkAbnormalPercent(this, 1, flinchPercent, playerAction) AND PlayerAttackBase.checkAbnormalPercent(this, 11, slowPercent, playerAction)`

**In-game level notes**

- Lv255: *นำเลเวลการเรียนรู้ของสกิลอีเทอนอลไนท์แมร์ มาบวกเพิ่มในอัตราติดผงะ

_Raw recovered data (every method item): [trees/DarkPowerSkill.md](../trees/DarkPowerSkill.md) — uid 1065_

---

### ดาร์คสตริงเกอร์ (DarkStinger) · uid 1059

<img src="../../icons/sk_1059.png" width="40" alt="icon"> 
**Tree:** ダークパワースキル (`DarkPowerSkill`, tier 2) · **Type:** Attack · **Max Lv:** 60 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** บลัดดี้ไบท์ · **Flags:** NoMarketSearch · **Client class:** `DarkStingerAction`

> ระเบิดพลังศาสตร์มืดที่อยู่ในแขนขวา
> ใช้ 10% ของ HP ปัจจุบันเพื่อสร้างความเสียหาย
> ค่า HP สูงสุดของตัวเองจะลดต่ำลง
> เป็นเวลา 10 วินาที (ไม่เกิน 5 ครั้ง)
> ถ้าใช้บลัดดี้ไบท์ระหว่างแสดงผล
> ผลเสียจะถูกลบออกไปและเพิ่มการฟื้นฟู HP

**How it works**

- Attack skill of the ダークパワースキル tree (tier 2, max Lv 60); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier depends on live values (formula below); flat damage depends on live values (formula below)
  - `calcPlayerToMobDamage` [!PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 AND int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) ge 1001 OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) lt 1 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 AND int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) ge 1001 OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) le 1e-05 AND int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) ge 1001]: skill multiplier depends on live values (formula below); skill multiplier depends on live values (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Buffs:
  - `SoulHuntBuf`: marker buff (no parameters; other code tests whether it is present)
  - `DarkStingerBuf`: lasts `30` s; Lv1 → Lv10: MaxHpUpRate (max HP %) -5 → -5, Value (generic value (meaning set by the code that reads the buff)) 1 → 1
  - `CountBufferBase`

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(8)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `ActionStart` — when the cast starts: 11 set, 3 call
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 1 info

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `(((((Lv * 30) + 100) + (baseVIT + baseSTR))) / 100)`
- SkillRate × `(((((Lv * 30) + 100) + (baseVIT + baseSTR))) / 100)` — !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 AND int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) ge 1001 OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) lt 1 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 AND int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) ge 1001 OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) le 1e-05 AND int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) ge 1001
- SkillRate × `(((((Lv * 30) + 100) + (baseVIT + baseSTR))) / 100)` — !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 AND int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) ge 1001 OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) lt 1 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 AND int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) ge 1001 OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) le 1e-05 AND int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) ge 1001
- Flat dmg + `((int((((10) * PlayerStatusBase.get_GameStatus().serverHp) / 100)) lt 1000 ? int((((10) * PlayerStatusBase.get_GameStatus().serverHp) / 100)) : 1000))`

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv * 30) + 100) + (baseVIT + baseSTR))) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `((int((((10) * PlayerStatusBase.get_GameStatus().serverHp) / 100)) lt 1000 ? int((((10) * PlayerStatusBase.get_GameStatus().serverHp) / 100)) : 1000))`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1059
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): adds the caster's buff of skill 1059 (DarkStinger) — `AddSelfBuffer(1059, Lv, Id)`
  - when `!PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 AND int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) lt 1 AND int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) lt 1001 OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 AND int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) ge 1001 OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) lt 1 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 AND int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) ge 1001`
- `ActionStart` (when the cast starts): constructs `SoulHuntBuf` — `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1))`
  - when `!PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 AND int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) ge 1001 OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) le 1e-05 AND int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) ge 1001 OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 AND int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) ge 1 AND int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) lt 1001`
- `ActionStart` (when the cast starts): adds the caster's buff of `new SoulHuntBuf` — `AddSelfBuffer(new SoulHuntBuf, 0)`
  - when `!PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 AND int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) ge 1001 OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) le 1e-05 AND int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) ge 1001 OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) AND fsqrt((((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).z - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).z)) + (((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).x - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).x)) + ((UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y) * (UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(target)).y - UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction))).y))))) gt 1e-05 AND int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) ge 1 AND int(((consumptionHpRate * PlayerStatusBase.get_GameStatus().serverHp) / 100)) lt 1001`

**Buff values** (every recovered field; durations in seconds)

**Buff `SoulHuntBuf`**
**Buff `DarkStingerBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `Stack`
- Duration: `30` s

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MaxHpUpRate | -5 | -5 | -5 | -5 | -5 | -5 | -5 | -5 | -5 | -5 |
| Value | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 |

- Buff fields set in the constructor (all recovered):
  - `maxHp` = `5` = 5
  - `stack` = `1` = 1
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `Stack`: `LeftTime`=30; `stack`=((stack + 1) ge 5 ? 5 : (stack + 1))
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:SoulHuntBuf$$.ctor<-DarkStingerAction$$ActionStart` (no direct constructor call in the skill's own code).
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
- `MaxHpUpRate`: max HP %
- `Value`: generic value (meaning set by the code that reads the buff)

_Raw recovered data (every method item): [trees/DarkPowerSkill.md](../trees/DarkPowerSkill.md) — uid 1059_

---

### เดมอนคลอว์ (DemonCrowe) · uid 1060

<img src="../../icons/sk_1060.png" width="40" alt="icon"> 
**Tree:** ダークパワースキル (`DarkPowerSkill`, tier 2) · **Type:** Attack · **Max Lv:** 60 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** แซครีไฟซ์ · **Flags:** NoMarketSearch · **Client class:** `DemonCroweAction`

> ปีศาจร้ายที่อยู่ภายในอาละวาดดเพราะกระหายลือด
> เข้าโจมตีศัตรูที่เป็นเป้าหมาย
> โจมตีได้สูงสุดถึง 10 ตัวแต่ความเสียหายจะลดลงไป
> พลังจะเพิ่มมากขึ้นตาม HP ที่ลดลงเมื่อใช้งาน
> และจะไม่เกิดเฮท

**How it works**

- Attack skill of the ダークパワースキル tree (tier 2, max Lv 60); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×1.1 at Lv1 to 2 at Lv10; flat damage +40 at Lv1 to 400 at Lv10
  - `calcPlayerToMobDamage` [!PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND hasGemCart(1016)]: skill multiplier depends on live values (formula below); skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [!PlayerAttackBase.IsBlank(this) AND !hasGemCart(1016) AND UnityEngine.Object.op_Inequality(actarAction)]: skill multiplier depends on live values (formula below)
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Tiredness (23).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(8)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `ActionPreparation` — before the cast starts: 12 set, 1 call
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionSkillEvent` — on an animation/skill event during the motion: 1 set, 1 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 2 call, 1 info

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 1.1 | 1.2 | 1.3 | 1.4 | 1.5 | 1.6 | 1.7 | 1.8 | 1.9 | 2 |
| Flat dmg + | 40 | 80 | 120 | 160 | 200 | 240 | 280 | 320 | 360 | 400 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((((Lv * 10) + 100)) / 100)` — !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND hasGemCart(1016)
- SkillRate × `((((Lv * 10) + 100)) / 100)` — !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND hasGemCart(1016)
- SkillRate × `((((Lv * 10) + 100)) / 100)` — !PlayerAttackBase.IsBlank(this) AND !hasGemCart(1016) AND UnityEngine.Object.op_Inequality(actarAction)

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv + (Lv << 2)) << 3))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv * 10) + 100)) / 100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1060
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Rolls `percent`% to inflict **Tiredness (23)** (`calcPlayerToMobDamage`)
- Marks the hit with ailment **Tiredness (23)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 23, percent, playerAction)`

**Other recovered parameters**

- **Effect percent** (`percent`): `((((((100 - (int(PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus())) - EternalNightmareBuf.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1064], 3))) lt 90 ? (100 - (int(PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus())) - EternalNightmareBuf.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1064], 3))) : 90) // 10) + ((((100 - (int(PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus())) - EternalNightmareBuf.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1064], 3))) lt 90 ? (100 - (int(PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus())) - EternalNightmareBuf.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1064], 3))) : 90) // 10) << 2)) << 1) // (11 - Lv))` _(when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND hasGemCart(1016) OR !PlayerAttackBase.IsBlank(this) AND !hasGemCart(1016) AND UnityEngine.Object.op_Inequality(actarAction))_; `((((((100 - int(PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()))) lt 90 ? (100 - int(PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()))) : 90) // 10) + ((((100 - int(PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()))) lt 90 ? (100 - int(PlayerStatusBase.GetHpPercent(PlayerActionManagerBase.get_PlayerStatus()))) : 90) // 10) << 2)) << 1) // (11 - Lv))` _(when !PlayerAttackBase.IsBlank(this) AND UnityEngine.Object.op_Inequality(actarAction) AND hasGemCart(1016) OR !PlayerAttackBase.IsBlank(this) AND !hasGemCart(1016) AND UnityEngine.Object.op_Inequality(actarAction))_

_Raw recovered data (every method item): [trees/DarkPowerSkill.md](../trees/DarkPowerSkill.md) — uid 1060_

---

### เนตรมารเสน่หา (EnchantingEvilEye) · uid 1066

<img src="../../icons/sk_1066.png" width="40" alt="icon"> 
**Tree:** ダークパワースキル (`DarkPowerSkill`, tier 2) · **Type:** Attack · **Max Lv:** 60 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เนตรมารข่มขวัญ · **Flags:** NoMarketSearch · **Client class:** `EnchantingEvilEyeAction`

> ตรึงเป้าหมายไว้ด้วยอำนาจแห่งความชั่วร้าย
> มีโอกาสทำให้เป้าหมายติดหลงใหล
> หากเป้าหมายติดหลงใหลอยู่แล้วจะเพิ่มความเสียหาย

**How it works**

- Attack skill of the ダークパワースキル tree (tier 2, max Lv 60); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) OR AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction))]: skill multiplier ×1 at Lv1 to 10 at Lv10
  - `calcPlayerToMobDamage` [!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) OR !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction) OR !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND !PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction)]: skill multiplier ×0.01 at Lv1 to 0.1 at Lv10; flat damage +0
  - `calcPlayerToMobDamage` [!UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30)]: flat damage +0
  - `calcPlayerToMobDamage` [AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) OR AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) OR !PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction) AND AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction))]: flat damage depends on live values (formula below)
- Proration: magic proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Charm (30).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(14)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 5 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 5 tpl, 1 call, 1 info
- `InitializeOthers` — setup used when another player's client replays the action: 2 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) OR AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction))] | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| SkillRate × [!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) OR !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction) OR !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND !PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction)] | 0.01 | 0.02 | 0.03 | 0.04 | 0.05 | 0.06 | 0.07 | 0.08 | 0.09 | 0.1 |
| Flat dmg + [!UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30)] | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 |
| Flat dmg + [!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) OR !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction) OR !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND !PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction)] | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 |

**Damage terms that depend on live stats (not tabulated)**

- Flat dmg + `((target.Level * Lv) lt 0x2710 ? (target.Level * Lv) : 0x2710)` — AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) OR AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) OR !PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction) AND AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction))

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((Lv * 100) / 100)`
  - when `AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) OR AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `((target.Level * Lv) lt 0x2710 ? (target.Level * Lv) : 0x2710)`
  - when `AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) OR AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) OR !PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction) AND AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `0`
  - when `!UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) OR !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction) OR !PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((Lv) / 100)`
  - when `!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) OR !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction) OR !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND !PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(0)`
  - when `!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) OR !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction) OR !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND !PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 1066
- Uses the magic proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Rolls `percent`% to inflict **Charm (30)** (`calcPlayerToMobDamage`)
  - when `!AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction) OR !AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND !PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction) OR AbnormalStateManager.Contains(MobActionManagerBase.get_AbnormalStateManager(mobAction), 30) AND PlayerAttackBase.checkAbnormalPercent(this, 30, percent, playerAction) AND UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction))`

**Other recovered parameters**

- **Effect percent** (`percent`): `(Lv * Lv)` → Lv1..10 [1, 4, 9, 16, 25, 36, 49, 64, 81, 100]

**In-game level notes**

- Lv255: *ขยายระยะเวลาผลของหลงใหลตามเลเวลการเรียนรู้ของสกิลอีเทอนอลไนท์แมร์ *ระยะเวลาความต้านทานไม่เปลี่ยนแปลง

_Raw recovered data (every method item): [trees/DarkPowerSkill.md](../trees/DarkPowerSkill.md) — uid 1066_

---

### เรดเทีย (RedTear) · uid 1061

<img src="../../icons/sk_1061.png" width="40" alt="icon"> 
**Tree:** ダークパワースキル (`DarkPowerSkill`, tier 3) · **Type:** Object · **Max Lv:** 120 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** ดาร์คสตริงเกอร์ · **Flags:** NoMarketSearch · **Client class:** `RedTearAction`

> ความเกลียดชังจะถูกแปรเปลี่ยนเป็นน้ำตาแห่งสายเลือดและโจมตีศัตรู
> ถ้าถูกเล็งเป้าโดยศัตรูจะตกอยู่ในสภาวะเลือดออก
> ถ้าไม่ค่าเฮทจะลดง และจะยกเว้นการใช้ HP
> ของพลังแห่งความมืดระหว่างใช้สกิล

**How it works**

- Object skill of the ダークパワースキル tree (tier 3, max Lv 120); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- It places an object in the world (trap, summon or field object).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×1.82 at Lv1 to 2 at Lv10
- Proration: physical-skill proration slot, mode `first_hit_per_target`.
- Buffs:
  - `RedTearBuf`: lasts `((int((Lv * 0.5)) gt 1 ? int((Lv * 0.5)) : 1) + 1)` s
- Other client code reads this skill (1 lookup; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0.5, PlayerActionManagerBase.get_PlayerStatus())`
- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(4)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 10 set
- `InitializeOthers` — setup used when another player's client replays the action: 3 set
- `ActionStart` — when the cast starts: 2 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 3 tpl, 1 info
- `.<>c__DisplayClass35_0::<ActionStart>b__0` — skill-specific method: 2 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 1.82 | 1.84 | 1.86 | 1.88 | 1.9 | 1.92 | 1.94 | 1.96 | 1.98 | 2 |

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(target.ExpDefMagic / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv << 1) + 180)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(targetExpRegister[MobActionManagerBase.get_CharacterActionManagerBase(mobAction)] / 100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Skill`, mode `first_hit_per_target`, attack type `Physics`, action id 1061
- Uses the physical-skill proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Hit counts**

- Number of damage events (`damageCount`): `int(((EternalNightmareBuf.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1064], 4) * (int((Lv * 0.5)) gt 1 ? int((Lv * 0.5)) : 1)) * 0.01))`
- Loop / hit-repeat count (`LoopParam`): `int(((EternalNightmareBuf.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1064], 4) * (int((Lv * 0.5)) gt 1 ? int((Lv * 0.5)) : 1)) * 0.01))`
- Number of damage events (`damageCount`): `(int((Lv * 0.5)) gt 1 ? int((Lv * 0.5)) : 1)` → Lv1..10 [1, 1, 1, 2, 2, 3, 3, 4, 4, 5]
- Loop / hit-repeat count (`LoopParam`): `(int((Lv * 0.5)) gt 1 ? int((Lv * 0.5)) : 1)` → Lv1..10 [1, 1, 1, 2, 2, 3, 3, 4, 4, 5]
- Number of damage events (`damageCount`): `motionSpeed`

**Buffs and effects it installs or removes**

- `.<>c__DisplayClass35_0::<ActionStart>b__0` (method): constructs `RedTearBuf` — `.ctor([<>c__DisplayClass35_0.<>4__this+0x14])`
- `.<>c__DisplayClass35_0::<ActionStart>b__0` (method): adds the caster's buff of `new RedTearBuf` — `AddSelfBuffer(new RedTearBuf, [<>c__DisplayClass35_0.<>4__this+0x10])`

**Other recovered parameters**

- **Resistance value** (`resist`): `((Lv + (Lv << 2)) << 1)` → Lv1..10 [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]
- **Number of damage events** (`damageCount`): `int(((EternalNightmareBuf.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1064], 4) * (int((Lv * 0.5)) gt 1 ? int((Lv * 0.5)) : 1)) * 0.01))`; `(int((Lv * 0.5)) gt 1 ? int((Lv * 0.5)) : 1)` → Lv1..10 [1, 1, 1, 2, 2, 3, 3, 4, 4, 5]; `motionSpeed`
- **Loop / hit-repeat count** (`LoopParam`): `int(((EternalNightmareBuf.GetParam(PlayerStatusBase.get_SkillBufferManager().selfSkillBufList[1064], 4) * (int((Lv * 0.5)) gt 1 ? int((Lv * 0.5)) : 1)) * 0.01))`; `(int((Lv * 0.5)) gt 1 ? int((Lv * 0.5)) : 1)` → Lv1..10 [1, 1, 1, 2, 2, 3, 3, 4, 4, 5]
- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0.5, PlayerActionManagerBase.get_PlayerStatus())`

**Buff values** (every recovered field; durations in seconds)

**Buff `RedTearBuf`**
- Duration: `((int((Lv * 0.5)) gt 1 ? int((Lv * 0.5)) : 1) + 1)` s
- Buff fields set in the constructor (all recovered):
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
  - `BufEffectTakeUid` = `-1` = -1
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())

**Where else this skill takes effect**

- Effect applied in `SacrificeAction$$CheckPayHp` (2 guarded paths):
  - always
    - returns `1`
  - always
    - returns `((consumptionHp lt ([?blr+0x20] + [?blr+0x10]) ? 1 : 0) & 1)`
- Code that reads this skill's level / buff by constant id: `SacrificeAction$$CheckPayHp (ContainsBuffer)`

_Raw recovered data (every method item): [trees/DarkPowerSkill.md](../trees/DarkPowerSkill.md) — uid 1061_

---

### รีเกรทเลส (Regret) · uid 1062

<img src="../../icons/sk_1062.png" width="40" alt="icon"> 
**Tree:** ダークパワースキル (`DarkPowerSkill`, tier 3) · **Type:** Buffer · **Max Lv:** 120 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เดมอนคลอว์ · **Flags:** NoMarketSearch · **Client class:** `RegretAction`

> ถึงตายก็ไม่เสียดายชีวิต
> ฟื้นฟู HP ทั้งหมด เพิ่มสเตตัส และลด HP สูงสุดชั่วขณะ (ใช้ซ้อนกันได้)
> จะตายเมื่อผลสิ้นสุดลง
> *ไม่สามารถใช้ปฐมพยาบาล, พยายามเข้านะ!! และหยาดแห่งชีวิตได้

**How it works**

- Buffer skill of the ダークパワースキル tree (tier 3, max Lv 120); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- Buffs:
  - `RegretBuf`: lasts `30` s; Lv1 → Lv10: Value (generic value (meaning set by the code that reads the buff)) 1 → 1
- Other client code reads this skill (8 lookups; see the last section).

**Cost, timing and range**

- **Cast time** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 1 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set
- `ActionHit` — when the attack connects: 2 call

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1062
- No proration slot: ExpType None: no proration slot.

**Buffs and effects it installs or removes**

- `ActionHit` (when the attack connects): removes the caster's buff of skill 1062 (Regret) — `RemoveSelfBuffer(1062)`
  - when `UnityEngine.Object.op_Inequality(actarAction) AND status.MaxHp le 0`
- `ActionHit` (when the attack connects): adds the caster's buff of skill 1062 (Regret) — `AddSelfBuffer(1062, Lv, Id)`
  - when `UnityEngine.Object.op_Inequality(actarAction) AND status.MaxHp le 0 OR UnityEngine.Object.op_Inequality(actarAction) AND status.MaxHp gt 0`

**Other recovered parameters**

- **Cast time modifier** (`CastTime`): `PlayerAttackBase.CalcCastTime(this, 0, PlayerActionManagerBase.get_PlayerStatus())`

**Buff values** (every recovered field; durations in seconds)

**Buff `RegretBuf`**
- Attached to this skill via `factory:CreateSkillBuffer` (no direct constructor call in the skill's own code).
- Buff hook methods: `Stack`, `calc`
- Duration: `30` s
- `MaxMpUp` = `(((1) lt 10 ? (1) : 10) * maxMp)` _(when BuffEffectActive ne 0)_
- `MaxHpUpRate` = `-(maxHp * (1))` _(when BuffEffectActive ne 0)_
- `MatkUp` = `(((1) lt 10 ? (1) : 10) * matk)` _(when BuffEffectActive ne 0)_
- `AtkUp` = `(((1) lt 10 ? (1) : 10) * atk)` _(when BuffEffectActive ne 0)_
- `AttackMprecoveryUp` = `(((1) lt 10 ? (1) : 10) * atkMpHeal)` _(when BuffEffectActive ne 0)_
- `MagicDmgCut` = `(((1) lt 10 ? (1) : 10) * magic)` _(when BuffEffectActive ne 0)_
- `PowerDmgCut` = `(((1) lt 10 ? (1) : 10) * physics)` _(when BuffEffectActive ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| Value | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 | 1 |

- Buff fields set in the constructor (all recovered):
  - `Level` = `lv` → Lv1..10 [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
  - `IsSelfAction` = `1` = 1
  - `BuffEffectActive` = `1` = 1
  - `stack` = `1` = 1
- Hook `Updata`: `LeftTime`=0; `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime())
- Hook `Stack`: `Level`=lv; `LeftTime`=max((30 - (stack << 1)), 0); `stack`=(stack + 1)
- Hook `calc`: `atk`=(int(((Lv - 1) * 0.5)) + 1); `matk`=(int(((Lv - 1) * 0.5)) + 1); `physics`=Lv; `magic`=Lv

Parameter meanings (inferred from the `SkillBufferId` names):

- `AtkUp`: ATK +
- `AttackMprecoveryUp`: MP recovered per attack (flat)
- `MagicDmgCut`: magic damage taken reduction
- `MatkUp`: MATK +
- `MaxHpUpRate`: max HP %
- `MaxMpUp`: max MP +
- `PowerDmgCut`: physical damage taken reduction
- `Value`: generic value (meaning set by the code that reads the buff)

**Where else this skill takes effect**

- Effect applied in `SuppressionBonusGameManager.<>c__DisplayClass18_0$$<Start>b__0` (2 guarded paths):
  - always
    - returns `BonusProgressLabel.Play([<>c__DisplayClass18_0.<>4__this+0x38], System.String.Format(SystemTextManager.Get(<>c__DisplayClass18_0.systemTextManager, meta(0x399cba8, 'AreaPopBonusProgressLabel'), 0, ?x3), 0x165da6c(meta(0x39720c8, byte_TypeInfo), stkp(-36), ?x2, ?x3), 0, ?x3), 0, ?x3)`
    - calls `SystemTextManager$$Get`, `0x165da6c`, `System.String$$Format`, `BonusProgressLabel$$Play`
  - always
    - returns `SkillBufferManager.ContainsBuffer(?blr, 1062, 0, ?x3)`
- Code that reads this skill's level / buff by constant id: `MobaPlayerActionManager$$Damaged (ContainsBuffer)`, `MobaPlayerActionManager$$ReceiveDamaged (ContainsBuffer)`, `PlayerActionManager$$Damaged (ContainsBuffer)`, `PlayerActionManager$$EventDamaged (ContainsBuffer)`, `PlayerActionManager$$abnormalActionLockCheck (ContainsBuffer)`, `SuppressionBonusGameManager.<>c__DisplayClass18_0$$<Start>b__0 (ContainsBuffer)`, `SuppressionBonusGameManager.<MenuLoadWait>d__21$$MoveNext (ContainsBuffer)`, `UIRezeroFieldPopWindowManager$$Start (ContainsBuffer)`

_Raw recovered data (every method item): [trees/DarkPowerSkill.md](../trees/DarkPowerSkill.md) — uid 1062_

---

### เนตรมารเพลิงทมิฬ (BlackFlameEvilEye) · uid 1067

<img src="../../icons/sk_1067.png" width="40" alt="icon"> 
**Tree:** ダークパワースキル (`DarkPowerSkill`, tier 3) · **Type:** Attack · **Max Lv:** 120 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เนตรมารเสน่หา · **Flags:** NoMarketSearch · **Client class:** `BlackFlameEvilEyeAction`

> แผดเผาเป้าหมายที่จ้องมองด้วยเพลิงทมิฬ
> สร้างความเสียหายด้วยเวทมนตร์
> โดยอิงจากค่า ATK MATK ที่สูงกว่า
> หากเป้าหมายกำลังตั้งเป้าโจมตีมาที่ตัวคุณจะการันตีคริติคอล
> หากใช้เพลิงทมิฬมากเกินไปอาจส่งผลกระทบต่อร่างกายของผู้ใช้

**How it works**

- Attack skill of the ダークパワースキル tree (tier 3, max Lv 120); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×11 at Lv1 to 20 at Lv10; flat damage +100
  - `calcPlayerToMobDamage` [!PlayerAttackBase.IsBlank(this) AND (PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp) le (int((status.MaxHp * 0.3)) gt 1000 ? int((status.MaxHp * 0.3)) : 1000) AND CharacterActionManagerBase.get_UnTargetDist() lt new BlackFlameEvilEyeBuf.Count AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1) ge 1 AND UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(actarAction), MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND (PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp) gt (int((status.MaxHp * 0.3)) gt 1000 ? int((status.MaxHp * 0.3)) : 1000) AND CharacterActionManagerBase.get_UnTargetDist() lt new BlackFlameEvilEyeBuf.Count AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1) ge 1 AND UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(actarAction), MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(actarAction), MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) AND (PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp) le (int((status.MaxHp * 0.3)) gt 1000 ? int((status.MaxHp * 0.3)) : 1000) AND CharacterActionManagerBase.get_UnTargetDist() lt new BlackFlameEvilEyeBuf.Count AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction)]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [!PlayerAttackBase.IsBlank(this) AND CharacterActionManagerBase.get_UnTargetDist() ge new BlackFlameEvilEyeBuf.Count AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1) ge 1 AND UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(actarAction), MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1) ge 1 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1067) eq 0 AND UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(actarAction), MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(actarAction), MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) AND CharacterActionManagerBase.get_UnTargetDist() ge new BlackFlameEvilEyeBuf.Count AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction)]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [!PlayerAttackBase.IsBlank(this) AND (PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp) le (int((status.MaxHp * 0.3)) gt 1000 ? int((status.MaxHp * 0.3)) : 1000) AND CharacterActionManagerBase.get_UnTargetDist() lt new BlackFlameEvilEyeBuf.Count AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1) lt 1 AND UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(actarAction), MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND (PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp) gt (int((status.MaxHp * 0.3)) gt 1000 ? int((status.MaxHp * 0.3)) : 1000) AND CharacterActionManagerBase.get_UnTargetDist() lt new BlackFlameEvilEyeBuf.Count AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1) lt 1 AND UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(actarAction), MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(actarAction), MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) AND (PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp) le (int((status.MaxHp * 0.3)) gt 1000 ? int((status.MaxHp * 0.3)) : 1000) AND CharacterActionManagerBase.get_UnTargetDist() lt new BlackFlameEvilEyeBuf.Count AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1) lt 1 AND UnityEngine.Object.op_Inequality(actarAction)]: skill multiplier depends on live values (formula below)
- Proration: magic proration slot, mode `first_hit_per_target`.
- Buffs:
  - `BlackFlameEvilEyeBuf`: marker buff (no parameters; other code tests whether it is present)
  - `SkillBufferDataBase`: marker buff (no parameters; other code tests whether it is present)

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(16)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 4 set
- `ActionPreparation` — before the cast starts: 6 set, 2 call
- `ActionStart` — when the cast starts: 2 set
- `ActionSkillEvent` — on an animation/skill event during the motion: 1 call
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 tpl, 1 info
- `InitializeOthers` — setup used when another player's client replays the action: 2 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 11 | 12 | 13 | 14 | 15 | 16 | 17 | 18 | 19 | 20 |
| Flat dmg + | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 | 100 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((((Lv * 100) + 1000)) / 100)` — !PlayerAttackBase.IsBlank(this) AND (PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp) le (int((status.MaxHp * 0.3)) gt 1000 ? int((status.MaxHp * 0.3)) : 1000) AND CharacterActionManagerBase.get_UnTargetDist() lt new BlackFlameEvilEyeBuf.Count AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1) ge 1 AND UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(actarAction), MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND (PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp) gt (int((status.MaxHp * 0.3)) gt 1000 ? int((status.MaxHp * 0.3)) : 1000) AND CharacterActionManagerBase.get_UnTargetDist() lt new BlackFlameEvilEyeBuf.Count AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1) ge 1 AND UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(actarAction), MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(actarAction), MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) AND (PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp) le (int((status.MaxHp * 0.3)) gt 1000 ? int((status.MaxHp * 0.3)) : 1000) AND CharacterActionManagerBase.get_UnTargetDist() lt new BlackFlameEvilEyeBuf.Count AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction)
- SkillRate × `((((Lv * 100) + 1000)) / 100)` — !PlayerAttackBase.IsBlank(this) AND CharacterActionManagerBase.get_UnTargetDist() ge new BlackFlameEvilEyeBuf.Count AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1) ge 1 AND UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(actarAction), MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1) ge 1 AND TryGetBuf<object>.out2(PlayerStatusBase.get_SkillBufferManager(), 1067) eq 0 AND UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(actarAction), MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(actarAction), MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) AND CharacterActionManagerBase.get_UnTargetDist() ge new BlackFlameEvilEyeBuf.Count AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction)
- SkillRate × `((((Lv * 100) + 1000)) / 100)` — !PlayerAttackBase.IsBlank(this) AND (PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp) le (int((status.MaxHp * 0.3)) gt 1000 ? int((status.MaxHp * 0.3)) : 1000) AND CharacterActionManagerBase.get_UnTargetDist() lt new BlackFlameEvilEyeBuf.Count AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1) lt 1 AND UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(actarAction), MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND (PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp) gt (int((status.MaxHp * 0.3)) gt 1000 ? int((status.MaxHp * 0.3)) : 1000) AND CharacterActionManagerBase.get_UnTargetDist() lt new BlackFlameEvilEyeBuf.Count AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1) lt 1 AND UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(actarAction), MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(actarAction), MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) AND (PlayerStatusBase.get_GameStatus().serverExHp + PlayerStatusBase.get_GameStatus().serverHp) le (int((status.MaxHp * 0.3)) gt 1000 ? int((status.MaxHp * 0.3)) : 1000) AND CharacterActionManagerBase.get_UnTargetDist() lt new BlackFlameEvilEyeBuf.Count AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1) lt 1 AND UnityEngine.Object.op_Inequality(actarAction)

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv * 100) + 1000)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(100)`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Magic`, action id 1067
- Uses the magic proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Buffs and effects it installs or removes**

- `ActionPreparation` (before the cast starts): constructs `BlackFlameEvilEyeBuf` — `.ctor(Lv)`
  - when `!PlayerAttackBase.IsBlank(this) AND CharacterActionManagerBase.get_UnTargetDist() ge new BlackFlameEvilEyeBuf.Count AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1) ge 1 AND UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(actarAction), MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(actarAction), MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) AND CharacterActionManagerBase.get_UnTargetDist() ge new BlackFlameEvilEyeBuf.Count AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND CharacterActionManagerBase.get_UnTargetDist() ge new BlackFlameEvilEyeBuf.Count AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1) lt 1 AND UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(actarAction), MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) AND UnityEngine.Object.op_Inequality(actarAction)`
- `ActionPreparation` (before the cast starts): adds the caster's buff of `new BlackFlameEvilEyeBuf` — `AddSelfBuffer(new BlackFlameEvilEyeBuf, 0)`
  - when `!PlayerAttackBase.IsBlank(this) AND CharacterActionManagerBase.get_UnTargetDist() ge new BlackFlameEvilEyeBuf.Count AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1) ge 1 AND UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(actarAction), MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND !UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(actarAction), MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) AND CharacterActionManagerBase.get_UnTargetDist() ge new BlackFlameEvilEyeBuf.Count AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1) ge 1 AND UnityEngine.Object.op_Inequality(actarAction) OR !PlayerAttackBase.IsBlank(this) AND CharacterActionManagerBase.get_UnTargetDist() ge new BlackFlameEvilEyeBuf.Count AND SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1064, 1) lt 1 AND UnityEngine.Object.op_Equality(UnityEngine.Component.get_gameObject(actarAction), MobActionManagerBase.get_Target(UnityEngine.GameObject.GetComponent<MobActionManagerBase>(target))) AND UnityEngine.Object.op_Inequality(actarAction)`

**Buff values** (every recovered field; durations in seconds)

**Buff `BlackFlameEvilEyeBuf`**
- Buff hook methods: `Explosion`
- Buff fields set in the constructor (all recovered):
  - `Count` = `0`
  - `Max` = `100` = 100
- Hook `Explosion`: `Count`=((Count lt 0 ? (Count + 1) : Count) >> 1)
**Buff `SkillBufferDataBase`**
- Attached to this skill via `caller2:BlackFlameEvilEyeBuf$$.ctor<-BlackFlameEvilEyeAction$$ActionPreparation` (no direct constructor call in the skill's own code).
- Buff hook methods: `get_BufEffectTakeId`, `get_IsAbnormalDamageCancel`, `get_IsDamageCancel`, `get_IsEnd`, `get_IsRange`, `get_IsSelfAction`, `get_LeftTime`, `get_Level`, `set_IsDamageCancel`, `set_IsEnd`, `set_IsSelfAction`, `set_LeftTime`, `set_Level`
- Hook `set_Level`: `Level`=value
- Hook `set_IsSelfAction`: `IsSelfAction`=(value & 1)
- Hook `set_IsDamageCancel`: `IsDamageCancel`=(value & 1)
- Hook `set_LeftTime`: `LeftTime`=value

**In-game level notes**

- Lv255: *เพิ่มความรุนแรงของสกิลตามระดับเลเวลของอีเทอนอลไนท์แมร์

_Raw recovered data (every method item): [trees/DarkPowerSkill.md](../trees/DarkPowerSkill.md) — uid 1067_

---

### โซลฮันเตอร์ / เดธรีปเปอร์ (SoulHunt_Deathscythe) · uid 1063

<img src="../../icons/sk_1063.png" width="40" alt="icon"> 
**Tree:** ダークパワースキル (`DarkPowerSkill`, tier 4) · **Type:** Attack · **Max Lv:** 180 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เรดเทีย · **Flags:** NoMarketSearch · **Client class:** `SoulHuntAction`

> การเผชิญหน้าอย่างมุ่งมั่นจะทำให้เราได้พบสิ่งที่ดีที่สุด
> ผลลัพธ์จะมากขึ้นด้วยการใช้ HP(สูงสุด 10 เลเวล)
> จะทำให้เป้าหมายมีโอกาสติด[หวาดกลัว]
> และถ้าได้ผลลัพธ์มากขึ้นจะเพิ่มการฟื้นฟู MP
> และจะกวัดแกว่งวิญญาณที่ถูกล่ามาแทนเคียวเพื่อโจมตีสิ่งโดยรอบ

**How it works**

- Attack skill of the ダークパワースキル tree (tier 4, max Lv 180); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It installs a buff on the caster.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage` [attackCount ne 1 AND attackCount ne 2]: skill multiplier ×5
  - `calcPlayerToMobDamage` [attackCount eq 2]: skill multiplier ×5.5 at Lv1 to 10 at Lv10
  - `calcPlayerToMobDamage` [UnityEngine.Object.op_Inequality(actarAction) & attackCount ne 1 AND attackCount ne 2]: skill multiplier depends on live values (formula below)
  - `calcPlayerToMobDamage` [attackCount eq 2 OR attackCount ne 1 AND attackCount ne 2]: flat damage +130 at Lv1 to 400 at Lv10
- Proration: magic proration slot, mode `first_hit_per_target`.
- Can inflict on the target: Fear (13).
- Buffs:
  - `SoulHuntBuf`: marker buff (no parameters; other code tests whether it is present)
  - `CountBufferBase`
- Other client code reads this skill (10 lookups; see the last section).

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `PlayerAttackBase.GetWeaponRange(GetWeaponType.item(actarAction))`
- **Attack range** (`attackRange`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance(4)`
- **Attack range** (`attackRange`) (Unity units, 2 = 1 m): `(motionSpeed * 0.1)`
- **Element**: follows the element of the equipped weapon.

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 10 set
- `InitializeOthers` — setup used when another player's client replays the action: 2 set
- `ActionStart` — when the cast starts: 4 set, 1 call
- `ActionSkillEvent` — on an animation/skill event during the motion: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 2 call, 2 set, 5 tpl, 1 info
- `PayHp` — skill-specific method: 2 call

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × [attackCount ne 1 AND attackCount ne 2] | 5 | 5 | 5 | 5 | 5 | 5 | 5 | 5 | 5 | 5 |
| SkillRate × [attackCount eq 2] | 5.5 | 6 | 6.5 | 7 | 7.5 | 8 | 8.5 | 9 | 9.5 | 10 |
| Flat dmg + | 130 | 160 | 190 | 220 | 250 | 280 | 310 | 340 | 370 | 400 |

**Damage terms that depend on live stats (not tabulated)**

- SkillRate × `((500) / 100)` — UnityEngine.Object.op_Inequality(actarAction) & attackCount ne 1 AND attackCount ne 2

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((500) / 100)`
  - when `attackCount ne 1 AND attackCount ne 2`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `(((Lv * 30) + 100))`
  - when `attackCount eq 2 OR attackCount ne 1 AND attackCount ne 2`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(MobActionManagerBase.get_MobStatus(mobAction).localExpDefMagic / 100)`
  - when `attackCount eq 2 OR attackCount ne 1 AND attackCount ne 2`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv * 50) + 500)) / 100)`
  - when `attackCount eq 2`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(targetExpList[MobActionManagerBase.get_MobStatus(mobAction).UniqueId] / 100)`
  - when `attackCount eq 2 OR attackCount ne 1 AND attackCount ne 2`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `Magic`, mode `first_hit_per_target`, attack type `Physics`, action id 1063
- Uses the magic proration slot; Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `int((MathUtil.DisplayMeterToDistance(4) * 10))`
  - when `(mainWeaponType - 8) hi 8`

**Status ailments**

- Rolls `percent`% to inflict **Fear (13)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 13, percent, playerAction) AND attackCount eq 1 AND attackCount ne 2 OR !PlayerAttackBase.checkAbnormalPercent(this, 13, percent, playerAction) AND attackCount eq 1 AND attackCount ne 2`
- Marks the hit with ailment **Fear (13)** (`calcPlayerToMobDamage`)
  - when `PlayerAttackBase.checkAbnormalPercent(this, 13, percent, playerAction) AND attackCount eq 1 AND attackCount ne 2`

**Buffs and effects it installs or removes**

- `ActionStart` (when the cast starts): removes the caster's buff of skill 1063 (SoulHunt_Deathscythe) — `RemoveSelfBuffer(1063)`
  - when `UnityEngine.Object.op_Inequality(actarAction)`
- `PayHp` (method): constructs `SoulHuntBuf` — `.ctor(SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1))`
  - when `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1`
- `PayHp` (method): adds the caster's buff of `new SoulHuntBuf` — `AddSelfBuffer(new SoulHuntBuf, 0)`
  - when `SkillManager.GetSkillLv(PlayerStatusBase.get_SkillManager(), 1063, 1) ge 1`

**Other recovered parameters**

- **First-part skill multiplier (%)** (`firstSkillRate`): `((Lv * 50) + 500)` → Lv1..10 [550, 600, 650, 700, 750, 800, 850, 900, 950, 1000]
- **Second-part multiplier** (`secondSkillRate`): `500` = 500; `(secondSkillRate + (((baseVIT // 10) + 100) * PlayerStatusBase.get_SkillBufferManager().skillBufList[1063].Count))` _(when UnityEngine.Object.op_Inequality(actarAction))_
- **Attack range** (`attackRange`): `MathUtil.DisplayMeterToDistance(4)`; `(motionSpeed * 0.1)`
- **Effect percent** (`percent`): `(Lv * Lv)` → Lv1..10 [1, 4, 9, 16, 25, 36, 49, 64, 81, 100]
- **Loop / hit-repeat count** (`LoopParam`): `int((MathUtil.DisplayMeterToDistance(4) * 10))` _(when (mainWeaponType - 8) hi 8)_

**Buff values** (every recovered field; durations in seconds)

**Buff `SoulHuntBuf`**
**Buff `CountBufferBase`**
- Attached to this skill via `caller2:SoulHuntBuf$$.ctor<-SoulHuntAction$$PayHp` (no direct constructor call in the skill's own code).
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

- Lv8: *พลังเพิ่มตามค่า DEX ของตัวเอง *โอกาสที่จะติดหวาดกลัวลดลงมาก
- Lv10: *พลังเพิ่มขึ้นตามค่า STR ของตัวเอง
- Lv11: [จะได้รับผลแบบเดียวกันเมื่อใช้หอกวายุ] *ระยะโจมตี(รัศมี)+2 *โอกาสที่จะติดหวาดกลัวลดลงมาก
- Lv12: [จะได้รับผลแบบเดียวกันเมื่อใช้โบว์กัน] *พลังจะลดลงอย่างมาก แต่จะใช้ตรงใจกลางของเป้าหมาย *โอกาสที่จะติดหวาดกลัวลดลงเล็กน้อย
- Lv14: [จะได้รับผลแบบเดียวกันเมื่อใช้อุปกรณ์เวท] *โอกาสที่จะติดหวาดกลัวลดลง *เพิ่มปริมาณการฟื้นฟู MP
- Lv16: *พลังเพิ่มตามค่า AGI ของตัวเอง

**Where else this skill takes effect**

- Effect applied in `ReceiveSupportResult$$OnActionPlayerSupport` (12 guarded paths):
  - when `skillId gt 709` AND `skillId le 1025` AND `skillId gt 869` AND `skillId le 968`
    - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillId, skillLv, supportData), 0, ?x2, ?x3), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_AbnormalStateManager`, `AbnormalStateManager$$Recovery`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_SkillBufferManager`, `0x165db78`
  - when `skillId gt 709` AND `skillId le 1025` AND `skillId gt 869` AND `skillId le 968`
    - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillId, skillLv, supportData), 0, ?x2, ?x3), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_AbnormalStateManager`, `AbnormalStateManager$$Recovery`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_SkillBufferManager`, `PlayerDataManager$$get_PlayerStatus`
  - when `skillId gt 709` AND `skillId le 1025` AND `skillId gt 869` AND `skillId le 968`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_AbnormalStateManager`, `AbnormalStateManager$$Recovery`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_SkillBufferManager`, `0x165db84`
  - when `skillId gt 709` AND `skillId le 1025` AND `skillId gt 869` AND `skillId le 968`
    - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillId, skillLv, supportData), 0, ?x2, ?x3), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_AbnormalStateManager`, `AbnormalStateManager$$Recovery`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_PlayerStatus`, `SacredTeachings$$ReceiveHpHeal`
  - when `skillId gt 709` AND `skillId le 1025` AND `skillId le 869` AND `skillId gt 773`
    - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillId, skillLv, supportData), 0, ?x2, ?x3), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_AbnormalStateManager`, `AbnormalStateManager$$Recovery`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_SkillBufferManager`, `0x165db78`
  - when `skillId gt 709` AND `skillId le 1025` AND `skillId le 869` AND `skillId gt 773`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_AbnormalStateManager`, `AbnormalStateManager$$Recovery`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_SkillBufferManager`, `0x165db84`
  - when `skillId gt 709` AND `skillId le 1025` AND `skillId le 869` AND `skillId gt 773`
    - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillId, skillLv, supportData), 0, ?x2, ?x3), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_AbnormalStateManager`, `AbnormalStateManager$$Recovery`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_SkillBufferManager`, `PlayerDataManager$$get_PlayerStatus`
  - when `skillId gt 709` AND `skillId le 1025` AND `skillId le 869` AND `skillId gt 773`
    - returns `SacredTeachings.ReceiveHpHeal(skillId, supportData, PlayerDataManager.get_PlayerStatus(PlayerDataManager.GetPlayerDataManager(0, skillId, skillLv, supportData), 0, ?x2, ?x3), 0)`
    - calls `PlayerDataManager$$GetPlayerDataManager`, `Singleton<object>$$get_Instance`, `GameManager$$UpdatePlayerStatus`, `PlayerDataManager$$get_AbnormalStateManager`, `AbnormalStateManager$$Recovery`, `PlayerDataManager$$get_SkillManager`, `PlayerDataManager$$get_PlayerStatus`, `SacredTeachings$$ReceiveHpHeal`
- Effect applied in `SkillComboState$$CheckTenacityCost` (20 guarded paths):
  - when `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-56), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() ge 1`
    - returns `(SkillComboState.EnoughTenacityCost(this, playerStatus, ?x2, ?x3) & 1)`
    - set `+0x2c` = `0`
    - calls `SkillComboState$$EnoughTenacityCost`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_GameStatus`, `PlayerGameStatus$$SetLocalHp`, `PlayerStatusBase$$DamageHp`, `SacredTeachingsBuf$$Damage`
  - when `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-56), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() ge 1` AND `TryGetValue.out2() ne 0`
    - returns `(SkillComboState.EnoughTenacityCost(this, playerStatus, ?x2, ?x3) & 1)`
    - set `+0x2c` = `0`
    - calls `SkillComboState$$EnoughTenacityCost`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_GameStatus`, `PlayerGameStatus$$SetLocalHp`, `PlayerStatusBase$$DamageHp`, `SacredTeachingsBuf$$Damage`
  - when `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-56), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() ge 1` AND `TryGetValue.out2() eq 0`
    - calls `SkillComboState$$EnoughTenacityCost`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_GameStatus`, `PlayerGameStatus$$SetLocalHp`, `PlayerStatusBase$$DamageHp`, `SacredTeachingsBuf$$Damage`
  - when `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-56), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() ge 1`
    - returns `(SkillComboState.EnoughTenacityCost(this, playerStatus, ?x2, ?x3) & 1)`
    - set `+0x2c` = `0`
    - calls `SkillComboState$$EnoughTenacityCost`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_GameStatus`, `PlayerGameStatus$$SetLocalHp`, `PlayerStatusBase$$DamageHp`, `SacredTeachingsBuf$$Damage`
  - when `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-56), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() lt 1`
    - returns `(SkillComboState.EnoughTenacityCost(this, playerStatus, ?x2, ?x3) & 1)`
    - set `+0x2c` = `0`
    - calls `SkillComboState$$EnoughTenacityCost`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_GameStatus`, `PlayerGameStatus$$SetLocalHp`, `PlayerStatusBase$$DamageHp`, `SacredTeachingsBuf$$Damage`
  - when `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-56), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() lt 1` AND `TryGetValue.out2() ne 0`
    - returns `(SkillComboState.EnoughTenacityCost(this, playerStatus, ?x2, ?x3) & 1)`
    - set `+0x2c` = `0`
    - calls `SkillComboState$$EnoughTenacityCost`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_GameStatus`, `PlayerGameStatus$$SetLocalHp`, `PlayerStatusBase$$DamageHp`, `SacredTeachingsBuf$$Damage`
  - when `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-56), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() lt 1` AND `TryGetValue.out2() eq 0`
    - calls `SkillComboState$$EnoughTenacityCost`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_GameStatus`, `PlayerGameStatus$$SetLocalHp`, `PlayerStatusBase$$DamageHp`, `SacredTeachingsBuf$$Damage`
  - when `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-56), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() lt 1`
    - returns `(SkillComboState.EnoughTenacityCost(this, playerStatus, ?x2, ?x3) & 1)`
    - set `+0x2c` = `0`
    - calls `SkillComboState$$EnoughTenacityCost`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_GameStatus`, `PlayerGameStatus$$SetLocalHp`, `PlayerStatusBase$$DamageHp`, `SacredTeachingsBuf$$Damage`
- Effect applied in `SkillComboState$$CheckBloody` (20 guarded paths):
  - when `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-40), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() ge 1`
    - returns `1`
    - calls `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_GameStatus`, `PlayerGameStatus$$SetLocalHp`, `PlayerStatusBase$$DamageHp`
  - when `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-40), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() ge 1` AND `TryGetValue.out2() ne 0`
    - returns `1`
    - calls `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_GameStatus`, `PlayerGameStatus$$SetLocalHp`, `PlayerStatusBase$$DamageHp`
  - when `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-40), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() ge 1` AND `TryGetValue.out2() eq 0`
    - calls `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_GameStatus`, `PlayerGameStatus$$SetLocalHp`, `PlayerStatusBase$$DamageHp`
  - when `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-40), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() ge 1`
    - returns `1`
    - calls `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_GameStatus`, `PlayerGameStatus$$SetLocalHp`, `PlayerStatusBase$$DamageHp`
  - when `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-40), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() lt 1`
    - returns `1`
    - calls `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_GameStatus`, `PlayerGameStatus$$SetLocalHp`, `PlayerStatusBase$$DamageHp`
  - when `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-40), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() lt 1` AND `TryGetValue.out2() ne 0`
    - returns `1`
    - calls `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_GameStatus`, `PlayerGameStatus$$SetLocalHp`, `PlayerStatusBase$$DamageHp`
  - when `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-40), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() lt 1` AND `TryGetValue.out2() eq 0`
    - calls `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_GameStatus`, `PlayerGameStatus$$SetLocalHp`, `PlayerStatusBase$$DamageHp`
  - when `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 846, stkp(-40), meta(0x399cfd0, Method$SkillBufferManager.TryGetBuf<SacredTeachingsBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0` AND `CharacterActionManagerBase.set_DefaultMoveSpeed() lt 1`
    - returns `1`
    - calls `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_SkillBufferManager`, `virtual CharacterActionManagerBase.set_DefaultMoveSpeed`, `virtual PlayerStatusBase.get_GameStatus`, `virtual PlayerStatusBase.get_GameStatus`, `PlayerGameStatus$$SetLocalHp`, `PlayerStatusBase$$DamageHp`
- Effect applied in `SoulHuntAction$$PayHp` (4 guarded paths):
  - when `SkillLv(1063) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 1063, stkp(-40), meta(0x39a8218, Method$SkillBufferManager.TryGetBuf<SoulHuntBuf>())) & 1) eq 0`
    - returns `?blr`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db78`, `SoulHuntBuf$$.ctor`, `virtual PlayerStatusBase.get_SkillBufferManager`, `SkillBufferManager$$AddSelfBuffer`
  - when `SkillLv(1063) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 1063, stkp(-40), meta(0x39a8218, Method$SkillBufferManager.TryGetBuf<SoulHuntBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
    - returns `?blr`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`
  - when `SkillLv(1063) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(PlayerStatusBase.get_SkillBufferManager(), 1063, stkp(-40), meta(0x39a8218, Method$SkillBufferManager.TryGetBuf<SoulHuntBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() eq 0`
    - calls `virtual PlayerStatusBase.get_SkillManager`, `virtual PlayerStatusBase.get_SkillBufferManager`, `0x165db84`
  - when `SkillLv(1063) lt 1`
    - returns `SkillLv(1063)`
    - calls `virtual PlayerStatusBase.get_SkillManager`
- Effect applied in `DarkStingerAction$$ActionStart` (24 guarded paths):
  - when `SkillLv(1063) ge 1` AND `TryGetValue.out2() ne 0`
    - returns `DarkStingerBuf.Stack(TryGetValue.out2(), 0, ?x2, ?x3)`
    - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - set `+0x134` = `?v1`
    - set `+0x138` = `?v2`
    - set `attackDir` = `meta(0)`
    - set `+0x140` = `[meta(0)+0x8]`
    - set `+0x144` = `meta(0)`
    - set `fixAddDamage` = `(int(((consumptionHpRate * [?blr+0x10]) / 100)) lt 1000 ? int(((consumptionHpRate * [?blr+0x10]) / 100)) : 1000)`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `0x165db78`
  - when `SkillLv(1063) ge 1` AND `TryGetValue.out2() eq 0`
    - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - set `+0x134` = `?v1`
    - set `+0x138` = `?v2`
    - set `attackDir` = `meta(0)`
    - set `+0x140` = `[meta(0)+0x8]`
    - set `+0x144` = `meta(0)`
    - set `fixAddDamage` = `(int(((consumptionHpRate * [?blr+0x10]) / 100)) lt 1000 ? int(((consumptionHpRate * [?blr+0x10]) / 100)) : 1000)`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `0x165db78`
  - when `SkillLv(1063) ge 1`
    - returns `SkillBufferManager.AddSelfBuffer(?blr, 1059, Lv, Id)`
    - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - set `+0x134` = `?v1`
    - set `+0x138` = `?v2`
    - set `attackDir` = `meta(0)`
    - set `+0x140` = `[meta(0)+0x8]`
    - set `+0x144` = `meta(0)`
    - set `fixAddDamage` = `(int(((consumptionHpRate * [?blr+0x10]) / 100)) lt 1000 ? int(((consumptionHpRate * [?blr+0x10]) / 100)) : 1000)`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `0x165db78`
  - when `SkillLv(1063) ge 1` AND `TryGetValue.out2() ne 0`
    - returns `DarkStingerBuf.Stack(TryGetValue.out2(), 0, ?x2, ?x3)`
    - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - set `+0x134` = `?v1`
    - set `+0x138` = `?v2`
    - set `attackDir` = `meta(0)`
    - set `+0x140` = `[meta(0)+0x8]`
    - set `+0x144` = `meta(0)`
    - set `fixAddDamage` = `(int(((consumptionHpRate * [?blr+0x10]) / 100)) lt 1000 ? int(((consumptionHpRate * [?blr+0x10]) / 100)) : 1000)`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `DarkStingerBuf$$Stack`
  - when `SkillLv(1063) ge 1` AND `TryGetValue.out2() ne 0`
    - returns `SkillBufferManager.AddSelfBuffer(?blr, 1059, Lv, Id)`
    - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - set `+0x134` = `?v1`
    - set `+0x138` = `?v2`
    - set `attackDir` = `meta(0)`
    - set `+0x140` = `[meta(0)+0x8]`
    - set `+0x144` = `meta(0)`
    - set `fixAddDamage` = `(int(((consumptionHpRate * [?blr+0x10]) / 100)) lt 1000 ? int(((consumptionHpRate * [?blr+0x10]) / 100)) : 1000)`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `SkillBufferManager$$AddSelfBuffer`
  - when `SkillLv(1063) ge 1` AND `TryGetValue.out2() eq 0`
    - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - set `+0x134` = `?v1`
    - set `+0x138` = `?v2`
    - set `attackDir` = `meta(0)`
    - set `+0x140` = `[meta(0)+0x8]`
    - set `+0x144` = `meta(0)`
    - set `fixAddDamage` = `(int(((consumptionHpRate * [?blr+0x10]) / 100)) lt 1000 ? int(((consumptionHpRate * [?blr+0x10]) / 100)) : 1000)`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `0x165db84`
  - when `SkillLv(1063) lt 1` AND `TryGetValue.out2() ne 0`
    - returns `DarkStingerBuf.Stack(TryGetValue.out2(), 0, ?x2, ?x3)`
    - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - set `+0x134` = `?v1`
    - set `+0x138` = `?v2`
    - set `attackDir` = `meta(0)`
    - set `+0x140` = `[meta(0)+0x8]`
    - set `+0x144` = `meta(0)`
    - set `fixAddDamage` = `(int(((consumptionHpRate * [?blr+0x10]) / 100)) lt 1000 ? int(((consumptionHpRate * [?blr+0x10]) / 100)) : 1000)`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `DarkStingerBuf$$Stack`
  - when `SkillLv(1063) lt 1` AND `TryGetValue.out2() eq 0`
    - set `attackPos` = `UnityEngine.Transform.get_position(UnityEngine.GameObject.get_transform(UnityEngine.Component.get_gameObject(actarAction, 0, ?x2, ?x3), 0, ?x2, ?x3), 0, ?x2, ?x3)`
    - set `+0x134` = `?v1`
    - set `+0x138` = `?v2`
    - set `attackDir` = `meta(0)`
    - set `+0x140` = `[meta(0)+0x8]`
    - set `+0x144` = `meta(0)`
    - set `fixAddDamage` = `(int(((consumptionHpRate * [?blr+0x10]) / 100)) lt 1000 ? int(((consumptionHpRate * [?blr+0x10]) / 100)) : 1000)`
    - calls `PlayerAttackBase$$ActionStart`, `PlayerAttackBase$$IsBlank`, `UnityEngine.Component$$get_gameObject`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `UnityEngine.GameObject$$get_transform`, `UnityEngine.Transform$$get_position`, `0x165db84`
- Code that reads this skill's level / buff by constant id: `DarkStingerAction$$ActionStart (GetSkillLv)`, `GameManager$$ReceiveActionSupportDelay (GetSkillLv)`, `HealingShotAction$$CheckPayHp (GetSkillLv)`, `ReceiveSupportResult$$OnActionPlayerSupport (GetSkillLv)`, `ReceiveSupportResult$$OnEventPlayerSupport (GetSkillLv)`, `SacrificeAction$$CheckPayHp (GetSkillLv)`, `SkillComboState$$CheckBloody (GetSkillLv)`, `SkillComboState$$CheckTenacityCost (GetSkillLv)`, `SoulHuntAction$$PayHp (GetSkillLv)`, `SpriteShieldAction$$CheckPayHp (GetSkillLv)`

_Raw recovered data (every method item): [trees/DarkPowerSkill.md](../trees/DarkPowerSkill.md) — uid 1063_

---

### อีเทอนอลไนท์แมร์ (EternalNightmare) · uid 1064

<img src="../../icons/sk_1064.png" width="40" alt="icon"> 
**Tree:** ダークパワースキル (`DarkPowerSkill`, tier 4) · **Type:** Object · **Max Lv:** 180 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** รีเกรทเลส · **Flags:** NoMarketSearch · **Client class:** `EternalNightmareAction`

> เราอยู่ในห้วงฝันหรือว่าฝันร้าย?
> ใช้ HP อย่างต่อเนื่องเพื่อลดพลังป้องกันของมอนสเตอร์
> และอัพเกรดดาร์คพาวเวอร์สกิลได้ถึงเลเวล 3
> เพิ่มความต้านทานธาตุมืดในระหว่างการใช้งาน แต่ความต้านทานธาตุแสงลงจะลดลง

**How it works**

- Object skill of the ダークパワースキル tree (tier 4, max Lv 180); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It installs a buff on the caster.
- It places an object in the world (trap, summon or field object).
- Buffs:
  - `EternalNightmareBuf`: lasts `(IsSelfAction eq 0 ? 3 : 300)` s; Lv1 → Lv10: MaxHpUpRate (max HP %) 2 → 20, ReceiveLightElementDmgRate (light-element damage taken %) -5 → -5, ReceiveDarkElementDmgRate (dark-element damage taken %) 1 → 10
- Other client code reads this skill (4 lookups; see the last section).

**Cost, timing and range**

- **Range** (`range`) (Unity units, 2 = 1 m): `MathUtil.DisplayMeterToDistance(100)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `InitializeOthers` — setup used when another player's client replays the action: 1 set

**Proration:** slot `none`, mode `never (ExpType None: no proration slot)`, attack type `None`, action id 1064
- No proration slot: ExpType None: no proration slot.

**Hit counts**

- Loop / hit-repeat count (`LoopParam`): `300` = 300

**Other recovered parameters**

- **Range** (`range`): `MathUtil.DisplayMeterToDistance(100)`
- **Loop / hit-repeat count** (`LoopParam`): `300` = 300

**Buff values** (every recovered field; durations in seconds)

**Buff `EternalNightmareBuf`**
- Attached to this skill via `name` (no direct constructor call in the skill's own code).
- Buff hook methods: `ActiveDefDown`, `PlayEffect`, `get_SkillLocalId`, `set_SkillLocalId`
- Duration: `(IsSelfAction eq 0 ? 3 : 300)` s
- `TargetDefDown` = `(((((val) * Lv) lt 0 ? (((val) * Lv) + 1) : ((val) * Lv)) >> 1) lt 400 ? ((((val) * Lv) lt 0 ? (((val) * Lv) + 1) : ((val) * Lv)) >> 1) : 400)` _(when BuffEffectActive ne 0; IsSelfAction ne 0; activeDefDown ne 0)_
- `TargetMdefDown` = `(((((val) * Lv) lt 0 ? (((val) * Lv) + 1) : ((val) * Lv)) >> 1) lt 400 ? ((((val) * Lv) lt 0 ? (((val) * Lv) + 1) : ((val) * Lv)) >> 1) : 400)` _(when BuffEffectActive ne 0; IsSelfAction ne 0; activeDefDown ne 0)_

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| MaxHpUpRate | 2 | 4 | 6 | 8 | 10 | 12 | 14 | 16 | 18 | 20 |
| ReceiveLightElementDmgRate | -5 | -5 | -5 | -5 | -5 | -5 | -5 | -5 | -5 | -5 |
| ReceiveDarkElementDmgRate | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |

- Buff fields set in the constructor (all recovered):
  - `SkillLocalId` = `localId`
  - `activeDefDown` = `1` = 1
  - `mobList` = `new System.Collections.Generic.List<CharacterActionManagerBase>`
  - `allDarkPowerSkillLevel` = `val`
- Hook `set_SkillLocalId`: `SkillLocalId`=value
- Hook `Updata`: `LeftTime`=(LeftTime - UnityEngine.Time.get_deltaTime()); `LeftTime`=0
- Hook `ActiveDefDown`: `activeDefDown`=(active & 1)

Parameter meanings (inferred from the `SkillBufferId` names):

- `MaxHpUpRate`: max HP %
- `ReceiveDarkElementDmgRate`: dark-element damage taken %
- `ReceiveLightElementDmgRate`: light-element damage taken %
- `TargetDefDown`: target DEF reduction
- `TargetMdefDown`: target MDEF reduction

**In-game level notes**

- Lv255: *ปริมาณการป้องกันที่ลดลงขึ้นอยู่กับเลเวลรวมของดาร์คพาวเวอร์ *เพิ่มลิมิตการฟื้นฟูของบลัดดี้ไบท์ *เพิ่มอัตราความเสถียรของแซคคริไฟส์ *เพิ่มพลังของดาร์คสตริงเกอร์ตามสัดส่วนการใช้ HP *ลดเกณฑ์ HP ในการเพิ่มพลังของเดมอนคลอว์ *เพิ่มจำนวนการโจมตีของเรดเทีย *เพิ่มโอกาสในการหลีกเลี่ยงความเสียใจด้วยรีเกรทเลส

**Where else this skill takes effect**

- Effect applied in `BlackFlameEvilEyeAction$$ActionPreparation` (20 guarded paths):
  - when `SkillLv(1064) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 1067, stkp(-72), meta(0x39a81a0, Method$SkillBufferManager.TryGetBuf<BlackFlameEvilEyeBuf>())) & 1) eq 0`
    - returns `Toram.Common.ProgramUtil.ShiftLeftBitByShort((System.DateTime.get_Ticks(stkp(-56), 0, ?x2, ?x3) & 0xffff), 0, ?x2, ?x3)`
    - set `skillRate` = `((skillRate + (SkillLv(1064) * 50)) + (skillRate + (SkillLv(1064) * 50)))`
    - set `confirmedCritical` = `1`
    - set `explosion` = `1`
    - set `SkillIndividualFlag` = `(Toram.Common.ProgramUtil.ShiftLeftBitByShort((System.DateTime.get_Ticks(stkp(-56), 0, ?x2, ?x3) & 0xffff), 0, ?x2, ?x3) | 3)`
    - calls `PlayerAttackBase$$ActionPreparation`, `System.DateTime$$get_Now`, `System.DateTime$$get_Ticks`, `PlayerAttackBase$$IsBlank`, `UnityEngine.GameObject$$GetComponent<object>`, `UnityEngine.Component$$get_gameObject`, `interface MobActionManagerBase.get_Target`, `0x165db78`
  - when `SkillLv(1064) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 1067, stkp(-72), meta(0x39a81a0, Method$SkillBufferManager.TryGetBuf<BlackFlameEvilEyeBuf>())) & 1) eq 0`
    - returns `Toram.Common.ProgramUtil.ShiftLeftBitByShort((System.DateTime.get_Ticks(stkp(-56), 0, ?x2, ?x3) & 0xffff), 0, 100, ?mi)`
    - set `skillRate` = `(skillRate + (SkillLv(1064) * 50))`
    - set `confirmedCritical` = `1`
    - set `SkillIndividualFlag` = `(Toram.Common.ProgramUtil.ShiftLeftBitByShort((System.DateTime.get_Ticks(stkp(-56), 0, ?x2, ?x3) & 0xffff), 0, 100, ?mi) | 1)`
    - calls `PlayerAttackBase$$ActionPreparation`, `System.DateTime$$get_Now`, `System.DateTime$$get_Ticks`, `PlayerAttackBase$$IsBlank`, `UnityEngine.GameObject$$GetComponent<object>`, `UnityEngine.Component$$get_gameObject`, `interface MobActionManagerBase.get_Target`, `0x165db78`
  - when `SkillLv(1064) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 1067, stkp(-72), meta(0x39a81a0, Method$SkillBufferManager.TryGetBuf<BlackFlameEvilEyeBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
    - returns `Toram.Common.ProgramUtil.ShiftLeftBitByShort((System.DateTime.get_Ticks(stkp(-56), 0, ?x2, ?x3) & 0xffff), 0, ?x2, ?x3)`
    - set `skillRate` = `((skillRate + (SkillLv(1064) * 50)) + (skillRate + (SkillLv(1064) * 50)))`
    - set `confirmedCritical` = `1`
    - set `explosion` = `1`
    - set `SkillIndividualFlag` = `(Toram.Common.ProgramUtil.ShiftLeftBitByShort((System.DateTime.get_Ticks(stkp(-56), 0, ?x2, ?x3) & 0xffff), 0, ?x2, ?x3) | 3)`
    - calls `PlayerAttackBase$$ActionPreparation`, `System.DateTime$$get_Now`, `System.DateTime$$get_Ticks`, `PlayerAttackBase$$IsBlank`, `UnityEngine.GameObject$$GetComponent<object>`, `UnityEngine.Component$$get_gameObject`, `interface MobActionManagerBase.get_Target`, `0x165db78`
  - when `SkillLv(1064) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 1067, stkp(-72), meta(0x39a81a0, Method$SkillBufferManager.TryGetBuf<BlackFlameEvilEyeBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
    - returns `Toram.Common.ProgramUtil.ShiftLeftBitByShort((System.DateTime.get_Ticks(stkp(-56), 0, ?x2, ?x3) & 0xffff), 0, 100, ?mi)`
    - set `skillRate` = `(skillRate + (SkillLv(1064) * 50))`
    - set `confirmedCritical` = `1`
    - set `SkillIndividualFlag` = `(Toram.Common.ProgramUtil.ShiftLeftBitByShort((System.DateTime.get_Ticks(stkp(-56), 0, ?x2, ?x3) & 0xffff), 0, 100, ?mi) | 1)`
    - calls `PlayerAttackBase$$ActionPreparation`, `System.DateTime$$get_Now`, `System.DateTime$$get_Ticks`, `PlayerAttackBase$$IsBlank`, `UnityEngine.GameObject$$GetComponent<object>`, `UnityEngine.Component$$get_gameObject`, `interface MobActionManagerBase.get_Target`, `0x165db78`
  - when `SkillLv(1064) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 1067, stkp(-72), meta(0x39a81a0, Method$SkillBufferManager.TryGetBuf<BlackFlameEvilEyeBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() eq 0`
    - set `skillRate` = `(skillRate + (SkillLv(1064) * 50))`
    - set `confirmedCritical` = `1`
    - calls `PlayerAttackBase$$ActionPreparation`, `System.DateTime$$get_Now`, `System.DateTime$$get_Ticks`, `PlayerAttackBase$$IsBlank`, `UnityEngine.GameObject$$GetComponent<object>`, `UnityEngine.Component$$get_gameObject`, `interface MobActionManagerBase.get_Target`, `0x165db78`
  - when `SkillLv(1064) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 1067, stkp(-72), meta(0x39a81a0, Method$SkillBufferManager.TryGetBuf<BlackFlameEvilEyeBuf>())) & 1) eq 0`
    - returns `Toram.Common.ProgramUtil.ShiftLeftBitByShort((System.DateTime.get_Ticks(stkp(-56), 0, ?x2, ?x3) & 0xffff), 0, ?x2, ?x3)`
    - set `skillRate` = `((skillRate + (SkillLv(1064) * 50)) + (skillRate + (SkillLv(1064) * 50)))`
    - set `explosion` = `1`
    - set `SkillIndividualFlag` = `(Toram.Common.ProgramUtil.ShiftLeftBitByShort((System.DateTime.get_Ticks(stkp(-56), 0, ?x2, ?x3) & 0xffff), 0, ?x2, ?x3) | 2)`
    - calls `PlayerAttackBase$$ActionPreparation`, `System.DateTime$$get_Now`, `System.DateTime$$get_Ticks`, `PlayerAttackBase$$IsBlank`, `UnityEngine.GameObject$$GetComponent<object>`, `UnityEngine.Component$$get_gameObject`, `interface MobActionManagerBase.get_Target`, `0x165db78`
  - when `SkillLv(1064) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 1067, stkp(-72), meta(0x39a81a0, Method$SkillBufferManager.TryGetBuf<BlackFlameEvilEyeBuf>())) & 1) eq 0`
    - returns `Toram.Common.ProgramUtil.ShiftLeftBitByShort((System.DateTime.get_Ticks(stkp(-56), 0, ?x2, ?x3) & 0xffff), 0, 100, ?mi)`
    - set `skillRate` = `(skillRate + (SkillLv(1064) * 50))`
    - set `SkillIndividualFlag` = `(Toram.Common.ProgramUtil.ShiftLeftBitByShort((System.DateTime.get_Ticks(stkp(-56), 0, ?x2, ?x3) & 0xffff), 0, 100, ?mi) | 0)`
    - calls `PlayerAttackBase$$ActionPreparation`, `System.DateTime$$get_Now`, `System.DateTime$$get_Ticks`, `PlayerAttackBase$$IsBlank`, `UnityEngine.GameObject$$GetComponent<object>`, `UnityEngine.Component$$get_gameObject`, `interface MobActionManagerBase.get_Target`, `0x165db78`
  - when `SkillLv(1064) ge 1` AND `(SkillBufferManager.TryGetBuf<object>(?blr, 1067, stkp(-72), meta(0x39a81a0, Method$SkillBufferManager.TryGetBuf<BlackFlameEvilEyeBuf>())) & 1) ne 0` AND `TryGetBuf<object>.out2() ne 0`
    - returns `Toram.Common.ProgramUtil.ShiftLeftBitByShort((System.DateTime.get_Ticks(stkp(-56), 0, ?x2, ?x3) & 0xffff), 0, ?x2, ?x3)`
    - set `skillRate` = `((skillRate + (SkillLv(1064) * 50)) + (skillRate + (SkillLv(1064) * 50)))`
    - set `explosion` = `1`
    - set `SkillIndividualFlag` = `(Toram.Common.ProgramUtil.ShiftLeftBitByShort((System.DateTime.get_Ticks(stkp(-56), 0, ?x2, ?x3) & 0xffff), 0, ?x2, ?x3) | 2)`
    - calls `PlayerAttackBase$$ActionPreparation`, `System.DateTime$$get_Now`, `System.DateTime$$get_Ticks`, `PlayerAttackBase$$IsBlank`, `UnityEngine.GameObject$$GetComponent<object>`, `UnityEngine.Component$$get_gameObject`, `interface MobActionManagerBase.get_Target`, `0x165db78`
- Code that reads this skill's level / buff by constant id: `BlackFlameEvilEyeAction$$ActionPreparation (GetSkillLv)`, `EnchantingEvilEyeAction$$calcPlayerToMobDamage (GetSkillLv)`, `IntimidatingEvilEyeAction$$ActionPreparation (GetSkillLv)`, `ReceiveSupportResult$$OnActionPlayerSupport (GetSkillLv)`

_Raw recovered data (every method item): [trees/DarkPowerSkill.md](../trees/DarkPowerSkill.md) — uid 1064_

---

### เนตรมารโกลาหล (ChaosEvilEye) · uid 1068

<img src="../../icons/sk_1068.png" width="40" alt="icon"> 
**Tree:** ダークパワースキル (`DarkPowerSkill`, tier 4) · **Type:** Attack · **Max Lv:** 180 · **Weapons:** Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana · **Requires:** เนตรมารเพลิงทมิฬ · **Flags:** NoMarketSearch · **Client class:** `ChaosEvilEyeAction`

> ใช้กระแสแห่งความโกลาหลมอบความทรมานให้แก่ศัตรู
> สร้างความเสียหายด้วยเวทมนตร์ตามจุดอ่อนของเป้าหมาย
> มอบภาวะผิดปกติ(โดยการสุ่มมาหนึ่งจากสิบประเภท)
> หากมอบสำเร็จความเสียหายจะเพิ่มขึ้นเป็นอย่างมาก
> ถ้าเป้าหมายกำลังเล็งโจมตีคุณอยู่จะเจาะ Guard ได้

**How it works**

- Attack skill of the ダークパワースキル tree (tier 4, max Lv 180); usable with Hand, OneHandSword, TwoHandSword, Bow, Bowgun, Rod, Magictool, Knuckle, Halberd, Katana.
- It deals damage: the action builds a damage template and the shared damage engine finishes the calculation.
- It can inflict a status ailment (chance and type below).
- Damage (`calcPlayerToMobDamage` x1; each template is a full damage roll with its own crit):
  - `calcPlayerToMobDamage`: skill multiplier ×6 at Lv1 to 15 at Lv10; flat damage +50 at Lv1 to 500 at Lv10
  - `calcPlayerToMobDamage` [!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND PlayerAttackBase.checkAbnormalPercent(this, abnormalType, 100, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND target.ExpDefMagic gt target.ExpDefNormal AND target.ExpDefMagic lt target.ExpDefNormal AND target.ExpDefNormal gt target.ExpDefSkill AND target.ExpDefNormal lt target.ExpDefSkill OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND PlayerAttackBase.checkAbnormalPercent(this, abnormalType, 100, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND target.ExpDefMagic gt target.ExpDefNormal AND target.ExpDefMagic lt target.ExpDefNormal AND target.ExpDefNormal le target.ExpDefSkill AND target.ExpDefNormal lt target.ExpDefSkill OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND PlayerAttackBase.checkAbnormalPercent(this, abnormalType, 100, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND target.ExpDefMagic gt target.ExpDefSkill AND target.ExpDefMagic le target.ExpDefNormal AND target.ExpDefMagic lt target.ExpDefNormal AND target.ExpDefNormal lt target.ExpDefSkill]: skill multiplier ×9 at Lv1 to 22.5 at Lv10
- Proration: slot chosen at runtime (physical or magic by a per-cast flag), mode `first_hit_per_target`.
- Can inflict on the target: `abnormalType`.

**Cost, timing and range**

- **ActionRange** (`ActionRange`): `MathUtil.DisplayMeterToDistance(12)`

**When each part runs**

- `OnInitialize` — skill setup (fields the action starts with): 3 set
- `ActionStart` — when the cast starts: 1 set
- `calcPlayerToMobDamage` — damage calculation against a monster: 3 set, 6 tpl, 2 call, 1 info
- `InitializeOthers` — setup used when another player's client replays the action: 2 set

**Damage numbers by level** (gem bonuses assumed 0)

| | Lv1 | Lv2 | Lv3 | Lv4 | Lv5 | Lv6 | Lv7 | Lv8 | Lv9 | Lv10 |
|---|---|---|---|---|---|---|---|---|---|---|
| SkillRate × | 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13 | 14 | 15 |
| SkillRate × [!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND PlayerAttackBase.checkAbnormalPercent(this, abnormalType, 100, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND target.ExpDefMagic gt target.ExpDefNormal AND target.ExpDefMagic lt target.ExpDefNormal AND target.ExpDefNormal gt target.ExpDefSkill AND target.ExpDefNormal lt target.ExpDefSkill OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND PlayerAttackBase.checkAbnormalPercent(this, abnormalType, 100, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND target.ExpDefMagic gt target.ExpDefNormal AND target.ExpDefMagic lt target.ExpDefNormal AND target.ExpDefNormal le target.ExpDefSkill AND target.ExpDefNormal lt target.ExpDefSkill OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND PlayerAttackBase.checkAbnormalPercent(this, abnormalType, 100, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND target.ExpDefMagic gt target.ExpDefSkill AND target.ExpDefMagic le target.ExpDefNormal AND target.ExpDefMagic lt target.ExpDefNormal AND target.ExpDefNormal lt target.ExpDefSkill] | 9 | 10.5 | 12 | 13.5 | 15 | 16.5 | 18 | 19.5 | 21 | 22.5 |
| Flat dmg + | 50 | 100 | 150 | 200 | 250 | 300 | 350 | 400 | 450 | 500 |

**Every damage-template term, per method** (`int()` after each multiplier; engine terms are added by `TemplateAssignment`)

- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `((((Lv * 100) + 500)) / 100)`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddConstant[SkillConstantDamage]` = `((Lv * 50))`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(target.ExpDefSkill / 100)`
  - when `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEffectiveAbnormal ne 0 AND target.ExpDefMagic gt target.ExpDefNormal AND target.ExpDefMagic lt target.ExpDefNormal AND target.ExpDefNormal gt target.ExpDefSkill AND target.ExpDefNormal lt target.ExpDefSkill OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEffectiveAbnormal eq 0 AND target.ExpDefMagic gt target.ExpDefNormal AND target.ExpDefMagic lt target.ExpDefNormal AND target.ExpDefNormal gt target.ExpDefSkill AND target.ExpDefNormal lt target.ExpDefSkill OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEffectiveAbnormal ne 0 AND target.ExpDefMagic gt target.ExpDefNormal AND target.ExpDefMagic lt target.ExpDefNormal AND target.ExpDefNormal le target.ExpDefSkill AND target.ExpDefNormal lt target.ExpDefSkill`
- `calcPlayerToMobDamage` (damage calculation against a monster): `AddRate[SkillRate]` = `(((((Lv * 100) + 500)) * 1.5) / 100)`
  - when `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND PlayerAttackBase.checkAbnormalPercent(this, abnormalType, 100, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND target.ExpDefMagic gt target.ExpDefNormal AND target.ExpDefMagic lt target.ExpDefNormal AND target.ExpDefNormal gt target.ExpDefSkill AND target.ExpDefNormal lt target.ExpDefSkill OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND PlayerAttackBase.checkAbnormalPercent(this, abnormalType, 100, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND target.ExpDefMagic gt target.ExpDefNormal AND target.ExpDefMagic lt target.ExpDefNormal AND target.ExpDefNormal le target.ExpDefSkill AND target.ExpDefNormal lt target.ExpDefSkill OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND PlayerAttackBase.checkAbnormalPercent(this, abnormalType, 100, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND target.ExpDefMagic gt target.ExpDefSkill AND target.ExpDefMagic le target.ExpDefNormal AND target.ExpDefMagic lt target.ExpDefNormal AND target.ExpDefNormal lt target.ExpDefSkill`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(target.ExpDefNormal / 100)`
  - when `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEffectiveAbnormal ne 0 AND target.ExpDefMagic gt target.ExpDefNormal AND target.ExpDefMagic lt target.ExpDefNormal AND target.ExpDefNormal ge target.ExpDefSkill AND target.ExpDefNormal gt target.ExpDefSkill OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEffectiveAbnormal eq 0 AND target.ExpDefMagic gt target.ExpDefNormal AND target.ExpDefMagic lt target.ExpDefNormal AND target.ExpDefNormal ge target.ExpDefSkill AND target.ExpDefNormal gt target.ExpDefSkill OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEffectiveAbnormal ne 0 AND target.ExpDefMagic gt target.ExpDefNormal AND target.ExpDefMagic lt target.ExpDefNormal AND target.ExpDefNormal ge target.ExpDefSkill AND target.ExpDefNormal le target.ExpDefSkill`
- `calcPlayerToMobDamage` (damage calculation against a monster): `SetRate[ExpRate]` = `(target.ExpDefMagic / 100)`
  - when `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEffectiveAbnormal ne 0 AND target.ExpDefMagic ge target.ExpDefNormal AND target.ExpDefMagic ge target.ExpDefSkill AND target.ExpDefMagic gt target.ExpDefNormal AND target.ExpDefNormal gt target.ExpDefSkill OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEffectiveAbnormal eq 0 AND target.ExpDefMagic ge target.ExpDefNormal AND target.ExpDefMagic ge target.ExpDefSkill AND target.ExpDefMagic gt target.ExpDefNormal AND target.ExpDefNormal gt target.ExpDefSkill OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEffectiveAbnormal ne 0 AND target.ExpDefMagic ge target.ExpDefNormal AND target.ExpDefMagic ge target.ExpDefSkill AND target.ExpDefMagic gt target.ExpDefNormal AND target.ExpDefNormal le target.ExpDefSkill`

Engine terms (always present): `BaseDamage`, target `Def` (after pierce), element bonus, stability, `ExpRate = p[slot]/100` (proration), type / last-damage / gem multipliers.

**Proration:** slot `dynamic`, mode `first_hit_per_target`, attack type `Magic`, action id 1068
- Uses the slot chosen at runtime (physical or magic by a per-cast flag); Proration changes on the FIRST damaging hit of one cast on each target only; later hits of the same cast read the updated value but do not change it.

**Status ailments**

- Rolls `100`% to inflict **`abnormalType`** (`calcPlayerToMobDamage`)
  - when `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND PlayerAttackBase.checkAbnormalPercent(this, abnormalType, 100, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND target.ExpDefMagic gt target.ExpDefNormal AND target.ExpDefMagic lt target.ExpDefNormal AND target.ExpDefNormal gt target.ExpDefSkill AND target.ExpDefNormal lt target.ExpDefSkill OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND PlayerAttackBase.checkAbnormalPercent(this, abnormalType, 100, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND target.ExpDefMagic gt target.ExpDefNormal AND target.ExpDefMagic lt target.ExpDefNormal AND target.ExpDefNormal le target.ExpDefSkill AND target.ExpDefNormal lt target.ExpDefSkill OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 3) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND PlayerAttackBase.checkAbnormalPercent(this, abnormalType, 100, playerAction) AND SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND target.ExpDefMagic gt target.ExpDefSkill AND target.ExpDefMagic le target.ExpDefNormal AND target.ExpDefMagic lt target.ExpDefNormal AND target.ExpDefNormal lt target.ExpDefSkill`
- Marks the hit with ailment **`abnormalType`** (`calcPlayerToMobDamage`)
  - when `!SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEffectiveAbnormal ne 0 AND target.ExpDefMagic gt target.ExpDefNormal AND target.ExpDefMagic lt target.ExpDefNormal AND target.ExpDefNormal gt target.ExpDefSkill AND target.ExpDefNormal lt target.ExpDefSkill OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEffectiveAbnormal ne 0 AND target.ExpDefMagic gt target.ExpDefNormal AND target.ExpDefMagic lt target.ExpDefNormal AND target.ExpDefNormal le target.ExpDefSkill AND target.ExpDefNormal lt target.ExpDefSkill OR !SkillCalcTemplate.CheckStepResult(PlayerAttackBase.TemplateAssignment(this, new SkillCalcTemplate, playerAction, mobAction), 0) AND !UnityEngine.Object.op_Equality(MobActionManagerBase.get_Target(mobAction), UnityEngine.Component.get_gameObject(playerAction)) AND isEffectiveAbnormal ne 0 AND target.ExpDefMagic gt target.ExpDefSkill AND target.ExpDefMagic le target.ExpDefNormal AND target.ExpDefMagic lt target.ExpDefNormal AND target.ExpDefNormal lt target.ExpDefSkill`

_Raw recovered data (every method item): [trees/DarkPowerSkill.md](../trees/DarkPowerSkill.md) — uid 1068_

---
