# Monster proration — evidence

Source IDs are defined in [`../_sources.md`](../_sources.md). Addresses are RVAs in S1; file offset = RVA − 0x4000.

## 1. Fields (D1 `dump.cs`)

```
public class MobStatusMaster                 // TypeDefIndex 1029
    private byte expDefNormal;  // 0x34
    private byte expDefSkill;   // 0x35
    private byte expDefMagic;   // 0x36

public class MobStatus                       // TypeDefIndex 1028, runtime per monster
    private int localExpDefNormal;  // 0x18
    private int localExpDefSkill;   // 0x1C
    private int localExpDefMagic;   // 0x20
    private int serverExpDefNormal; // 0x24
    private int serverExpDefSkill;  // 0x28
    private int serverExpDefMagic;  // 0x2C
    RVA 0x1F36F48 .ctor(int)
    RVA 0x1F3712C ResetServerExpDef()
    RVA 0x1F37140 SetExpDef(int normal, int skill, int magic)
    RVA 0x1F37150 CalcExpDef(MobStatus.AttackType type, int normal, int skill, int magic)
    RVA 0x1F371D0 GetExp(SkillAttackType type)

enum MobStatus.AttackType { Normal 0, Skill 1, Magic 2 }
enum SkillAttackType      { None 0, Physics 1, Magic 2, SkillNormal 3 }

public abstract class EnemyMobActionManagerBase
    protected MobStatusMaster mobStatusMaster; // 0x70
    protected MobStatus mobStatus;             // 0x78
```

The CSV columns are the three bytes of the `mob_<map>` record in this declared order (see NOTES.md, Monsters).

## 2. Initial value 100 (`MobStatus..ctor`)

```
0x1f36f98  movi v0.4s, #0x64
0x1f36f9c  movi v1.2s, #0x64
0x1f36fa0  stur q0, [x19, #0x18]     ; local N/S/M + serverN = 100
0x1f36fa4  str  d1, [x19, #0x28]     ; serverS/M = 100
```

## 3. `CalcExpDef` — step and clamp

```
0x1f37150  cmp w1, #2 ; b.eq -> neg w4     ; Magic: negate magic step
0x1f37158  cmp w1, #1 ; b.eq -> neg w3     ; Skill: negate skill step
0x1f37160  cbnz w1 ...; neg w2             ; Normal: negate normal step
0x1f37188  add  w8, w8, w2                 ; N += step
0x1f3718c  cmp w8,#0xfa ; csel lt          ; min(.., 250)
0x1f37198  cmp w8,#0x32 ; csel gt          ; max(.., 50)
           (same for S at +0x1c, M at +0x20)
```

## 4. Caller passes the master bytes (`EnemyMobActionManagerBase.Damaged`)

```
0x1eeef1c  bl MindimageSenjuAttackAction.CheckExpDefFluctuate
0x1eeef90  blr [vtable+0x308]              ; SkillActionBase slot 29 get_IsExpDefFluctuate -> skip if false
0x1eeefa4  blr [vtable+0x188]              ; slot 5 get_ActionID; == 0 -> Normal path (0x1eef044)
0x1eeefb8  blr [vtable+0x1a8]              ; slot 7 get_ExpType
0x1eeefbc  cmp w0, #1                      ; Physics
0x1eeefc4  ldr x8, [x19, #0x70]            ; mobStatusMaster
0x1eeefcc  ldr x0, [x19, #0x78]            ; mobStatus
0x1eeefd4  ldrb w4, [x8, #0x36]            ; expDefMagic
0x1eeefd8  ldrb w3, [x8, #0x35]            ; expDefSkill
0x1eeefdc  ldrb w2, [x8, #0x34]            ; expDefNormal
0x1eeefe0  mov  w1, #1                     ; AttackType.Skill
0x1eeefe8  bl   MobStatus.CalcExpDef
0x1eeeffc  cmp w0, #2 ... mov w1, #2       ; Magic -> AttackType.Magic   (0x1eef028)
0x1eef03c  cmp w0, #3 ... mov w1, wzr      ; SkillNormal -> AttackType.Normal (0x1eef068)
```

vtable base 0x138 (slot n at 0x138 + 16n) fixed by slot 29 = 0x308 matching `get_IsExpDefFluctuate`.
Same pattern in `BCollaboBossActionManager.Damaged` (0x1ec7374..), `GuildRaidBossMobActionManager.Damaged` (0x1ef4aa0..),
`ScoreAttackBossActionManager.Damaged` (0x1f4c418..).

## 5. Damage multiplier (`HuntingOneNormalAttackAction.calcPlayerToMobDamage`)

```
0x2353b30  bl  MobStatus.GetExp (type 1)   ; -> w23
0x2353c5c  mov w8, #0x42c80000             ; 100.0f
0x2353c60  scvtf s0, w23
0x2353c68  fdiv s0, s0, s1                 ; p / 100
0x2353c70  fmul s0, s9, s0
0x2353c94  fmul s8, s0, s8
```
`GetExp` (0x1f371d0) returns 100 for type > 3. Its only direct callers are three minigame actions
(`HuntingOneNormalAttackAction`, `SummonDemonicAttackAction`, `SummonDemonicSpecialAttack`); the normal field damage
path reads `MobStatus` fields directly and was not traced.

## 6. Server sync

`EnemyMobActionManagerBase.UpdateExpDef` → `MobStatus.SetExpDef` (0x1eed52c) writes both local and server copies;
`ResetServerExpDef` copies server → local.

## 7. Data check (`monster_full.csv`, Normal/"-" rows)

Most common triples: 0/0/0 (1468), 1/1/1 (392), 10/10/10 (321), 5/5/5 (214), 10/5/10 (141), 20/1/1 (138).
Max 100, consistent with a step clamped into [50, 250].

## 8. Main field damage path (traced 2026-09-28)

Fills the "not traced" gap in §5: how a normal field hit (not the HuntingOne/SummonDemonic minigames) turns
p[slot] into a damage multiplier.

```
0x1f05ea0  MobBattleStatus.get_ExpDefNormal
  ldr x8, [x0, #0x28]      ; x0+0x28 = mobStatus ptr (matches EnemyMobActionManagerBase.mobStatus @ 0x78 offset chain)
  cbz x8, +0x10            ; null -> default 100
  ldr w0, [x8, #0x18]      ; else return mobStatus.localExpDefNormal (offset 0x18, matches §1)
  ret
```
Confirms `MobBattleStatus` (the live battle-status wrapper) is a thin proxy over `MobStatus`'s already-documented
fields — no separate storage, no extra computation.

```
0x1ea9294  SkillDataExtentionMethod.GetTargetExpRate(int type, int expType, MobStatus target)
```
Dispatcher: picks a field-getter slot on `IMobStatusCalculator` by `expType` (param1) — slot 0x10/0x11/0x12
(Normal/Skill/Magic in some order per branch) unless `expType` is a distinguished sentinel range or 0, in which
case it short-circuits to a fixed `100`. Whichever getter fires, the return int is `scvtf`'d and divided by
`100.0f` (`0x42c80000`) before returning — i.e. this is the `p[slot] / 100` step of the formula, generalized to
also hand back a flat `1.0` when proration doesn't apply to that action.

```
0x2066c6c  NormalAttackAction.CalcDef(...)
```
After computing the equip-type cut multiplier (`GetWeaponTypeToEquipLimit` -> 1.0 / 0.5 / 0.0 by weapon
category) and folding in `EquipBuffManager` state, it branches on physical vs magic and tail-calls
`PlayerAttackBase$$CalcPowerResistDamage` (0x2070e2c) or `PlayerAttackBase$$CalcMagicResistDamage` (0x2070ef8).

**CORRECTION (2026-09-29, disassembled both bodies):** these two are NOT proration. Each is
`(int)(dmg * (1 - min(1, arg + BonusManager.GetBonusPercentValue(0x33|0x34) + SkillBufferParam(0x48|0x49) * k)))`
(k = float @ 0x946f84, presumably 0.01): the pierce/resist reduction, same function already used by Pierce in
`dual_sword/evidence.md`. They contain no call to `GetTargetExpRate` and read no `MobStatus` proration field.
The earlier "name-based guess confirmed" wording was wrong; `CalcDef` is a Def-reduction step, unrelated to `p[slot]`.

Real `GetTargetExpRate` (0x1ea9294) callers, found by `scripts/scan_gettargetexprate_callers.py` (full `.text` `bl`
scan, 4 sites): `PlayerAttackBase.TemplateAssignment` (0x206c2a4, the pipeline's ExpRate step),
`BusterLanceAction.calcPlayerToMobDamage`, `HolyFistAction.calcPlayerToMobDamage`,
`PetNormalMagicAction.calcPlayerToMobDamage`. Indirect (vtable) callers are not visible to a `bl` scan.

## 9. Exhaustive caller scan (2026-09-28)

`scripts/scan_calcexpdef_callers.py` disassembles every `SHF_EXECINSTR` section of `libil2cpp.so`
(3 ranges, ~46 MB of code), finds every `bl` targeting `0x1f37150` (`CalcExpDef`) or `0x1f371d0`
(`GetExp`), and maps each call site to its enclosing function via `bisect` over `sorted(names)`
(same technique `dis_android.func()` uses for range-capping, applied globally instead of locally).

Result: **exactly 15 call sites, 0 new callers** — matches §4/§5's manually-found list precisely:

| Target | Callers (3 sites each, one per branch) |
|---|---|
| `CalcExpDef` | `EnemyMobActionManagerBase.Damaged`, `BCollaboBossActionManager.Damaged`, `GuildRaidBossMobActionManager.Damaged`, `ScoreAttackBossActionManager.Damaged` |
| `GetExp` | `HuntingOneNormalAttackAction.calcPlayerToMobDamage`, `SummonDemonicAttackAction.calcPlayerToMobDamage`, `SummonDemonicSpecialAttack.calcPlayerToMobDamage` |

Confirms the original evidence was already complete: no other action/manager class in the game calls
either function directly. (Doesn't rule out an indirect path via `GetTargetExpRate` dispatching to a
vtable slot that itself reads `MobStatus` fields without calling `CalcExpDef`/`GetExp` by name — see §8.)

## 10. How the field pipeline applies the rate (2026-09-29)

`PlayerAttackBase.TemplateAssignment` (0x206bbb0) at 0x206c2a4 calls `GetTargetExpRate(attackType, actionId, mob)`
and feeds the float straight into `SkillCalcTemplate.AddRate(step 0x17 = ExpRate)` (0x206c2b4). So the field path
uses the same `p[slot]/100` value as the minigames, as a pipeline step, not a separate formula.

`SkillCalcTemplate.GetDamage` (0x21ff504) walks steps 0..40 in numeric order. `checkType` (table @ rodata 0x949384,
index step-7; RVA read directly) gives each step a kind: 0 constant (`damage += v`), 1 rate
(`damage = (int)(damage * v)`, truncated to an integer after every rate step, 0x21ff81c-0x21ff83c), 2 check-only,
3 guard (GuardPower). ExpRate (23) is kind 1 (multiplicative). Kinds: 0 = steps 7-11, 22, 30, 35-37;
1 = 13, 15-21, 23-29, 34, 40; 2 = 12, 14, 31, 32, 38, 39; 3 = 33. Each step's `v` is the sum of all `AddRate` calls
made on that step. Step 13 (CriticalRate) is skipped (v = 1) unless the critical check passed.

Order around it: ... StableRate(21) -> AutoSkillConstant(22, +const) -> **ExpRate(23)** -> TypeDamageRate(24) ->
LastDamageRate(25) -> ... Each multiplication truncates toward zero, so proration rounds down before the next step.
Caveat: enum order is the execution order here (GetDamage loops `x20 = 0..40`), unlike the earlier "not proven" note.
Not checked in game.

## 11. Per-hit or first-hit only? (traced 2026-09-29)

Answer: **first damaging hit of one action instance on each target**, except a few skills that bypass the gate.
Machine-readable copy: `proration_calculator/proration_hit_rules.json`.

`EnemyMobActionManagerBase.Damaged(actor, action, damageData, id)` (0x1eede78) runs once per damage event.
Order of the proration-relevant part:

1. `damageData.HitType` (+0x14) == 0 (Miss) -> return before any of the below (0x1eeee34).
2. `w25 = SkillActionBase.CheckHitTarget(action, thisMob)` (0x1eeee6c). Its body is a `FirstOrDefault` over
   `action.targetList` (+0x88) returning `TargetData.hit` (byte +0x11), or false if the mob is not in the list.
   If false: `ContainsHitTarget`/`AddHitTarget` (adds the entry) then `HitTarget` sets `hit = 1` (0x1eeee78-0x1eeeea8).
   So w25 = 0 on the first damaging hit of this action instance on this mob and 1 on every later one. No method
   clears or resets the list (only Add/Contains/Check/HitTarget/HitTargetNum/CopyHitTargetData exist).
3. Dispatch on `ActionID` (vtable +0x188, 0x1eeeeac): 1219 (Kunai) -> update path directly; 159 (MindimageSenju) ->
   its own `CheckExpDefFluctuate`; 658 (Air Slicer) -> update path directly; then at 0x1eef3a0: 117 (Magic Knife) ->
   `MagicKnifeAction.CheckExpDefFluctuate`; 554 (Homing Shot) -> update path directly; class SlashReaperAction ->
   its own check; 301 (Crazy Dagger) -> update only if `!w25 && (damageData.DamageIndividualFlag & 2)`;
   **everything else: `tbz w25, #0` -> update path only if w25 == 0** (0x1eef478).
4. Update path (0x1eeef40): `SkillUtil.IsExpSkill(ActionID)` (false for 10-12, 25-28, 1058) and
   `get_IsExpDefFluctuate` must both be true, then `CalcExpDef` for the slot chosen from ActionID / ExpType (§4).

Enum `SkillHitType`: Miss 0, Hit 1, Critical 2, Correct 3. `SkillHitReactionType` (+0x18): None 0, Avoid 1, Guard 2,
Invincible 3... (avoid/guard are handled before step 1 and reach the same `HitType == 0` test).

`CopyHitTargetData` (0x248a35c) has one caller (`LunaDitherStarBladeRainAction.Inheritance`, `scripts/
scan_copyhittarget_callers.py`): only that spawned sub-action inherits the parent's already-hit list.
`CheckHitTarget` (0x2489e28) callers (`scripts/scan_checkhittarget_callers.py`): the four `Damaged` overrides
(EnemyMobActionManagerBase, BCollaboBoss, GuildRaidBossMob, ScoreAttackBoss), `PursuitImperialRay`,
MindimageSenju's check, player-side `OnSkillActionHit`/`TrapActionHit` (+ Moba twins), `ReceiveMobaHitDamage`.
The three non-Enemy managers were not disassembled individually; same gate assumed.

Damage side is separate: every hit (first or not) reads the current `p[slot]` through `TemplateAssignment` ->
`GetTargetExpRate` -> ExpRate step (§10). So in a multi-hit action hit 1 is calculated with the old p and hits 2..n
with the p left by hit 1 (ordering of mob-side update vs next hit's calculation not traced).

Not proven: that one cast of a multi-hit skill is one `SkillActionBase` instance (inferred from `Damaged` taking
`action` per damage event and from TornadoLance using `HitTargetNum()==0` for "first hit of the action"). Not checked
in game.

## 12. Multi-hit skills: one cast = one action instance (traced 2026-09-29)

Question: does a skill that hits several times count proration per hit? Answer: hits of one cast share ONE
`SkillActionBase`, so the section 11 gate applies to the whole cast: only the first damaging hit on each target changes
`p` (except the bypass skills listed there). Evidence:

- `GameManager.AttackDamage(mob, action, damageData, id)` (0x2445c04) is the per-hit entry point. It calls
  `SkillActionBase.AddAttackCount` (0x2488160, `_attackCount` at +0x7C) on the SAME `action` on every hit and sends
  `ActionCommand.Attack` with `get_AttackCount`. Only caller of `AddAttackCount`: `GameManager.AttackDamage` (2 sites,
  `scripts/scan_addattackcount_callers.py`). A per-action counter that grows per hit only makes sense if all hits share
  the instance.
- `SkillActionBase` also keeps per-instance `targetDamageData` (+0x80), `hitTargetData` (+0x88, the list behind
  `CheckHitTarget`) and `damageCountList` (+0x98, Dictionary<IMobIdData, byte> = hits per mob).
- `damageData.DamageLocalId` / `id` (byte) numbers the damage entries inside one action; TornadoLance (action 988) uses
  `HitTargetNum()==0` for "first hit of this action" (0x1eee7bc), the same instance-scoped idea.
- New action instances get a fresh hit list, so each may fluctuate: child/follow-up actions such as pursuit actions.
  `LunaDitherStarBladeRainAction` inherits the parent's list via `CopyHitTargetData`, so it does NOT re-fluctuate.
  `MobAttackPlayerSelfDestruct` is the child created by traps 549-552.

Skill id -> class table: `SkillFactory.CreateSkill(int)` (0x2396894) is a range-split + jump-table switch, decoded by
`scripts/emu_factory.py` (small AArch64 emulator over the switch, checked against known ids: 1219 Kunai, 658 Air Slicer,
554 Homing Shot, 117 Magic Knife, 301 Crazy Dagger, 33 Hard Hit) -> 398 ids, one class each.
`scripts/build_proration_skill_table.py` resolves for every class (walking base classes) the `ActionID`, `AttackType`,
`ExpType` (default = AttackType), `IsExpDefFluctuate`, then applies the section 11 gate ->
`proration_calculator/skill_proration_modes.csv|json`.

Result over the 398 ids: 202 first_hit_per_target, 8 first_hit_per_target if the class check passes, 148 never (ExpType
None: support/buff, no proration slot), 25 never (`IsExpDefFluctuate` false), 8 never (`IsExpSkill` excludes ActionID),
3 every_hit (Kunai, Air Slicer, Homing Shot; their class byte check also applies), 1 first_hit_and_flag (Crazy
Dagger), 3 custom_check (Magic Knife, MindimageSenju, Slash Reaper). 20 rows have a per-instance Physics/Magic choice
(`slot` = dynamic; e.g. Buster Lance, Nemesis, Hammer Down read a byte field).
Limits: child-action detection only scans a class's own methods, so actions spawned from compiler-generated
closure/coroutine classes are missed (only 4 found); `name_th` is blank for 48 ids missing from skills.csv; not checked
in game.

## Reproduce

```
python D:\toram_re\dis_android.py 0x1f36f48 0x1f37150 0x1f371d0 0x1f3712c 0x1f37140
python D:\toram_re\dis_android.py 0x1f05ea0 0x1ea9294 0x2066c6c
python D:\toram_re\scripts\scan_calcexpdef_callers.py
```
Ranges inside long functions (`Damaged`, `calcPlayerToMobDamage`) exceed the script's 0x1000-byte cap; disassemble
0x1eeef00-0x1eef0a0 and 0x2353b30-0x2353ca0 with the cap removed.
