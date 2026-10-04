# Proration — full code linkage map (every attack type)

Extends [`../calc Reverse/proration/`](../calc%20Reverse/proration/) (state machine + clamp, already
Code-confirmed from disassembly there). This file answers the open question that evidence.md left:
**where does every player attack type — not just the two HuntingOne/SummonDemonic minigame actions —
read the prorate percentage?**

Sources: `D:\toram_re\dump_android\dump.cs` (Il2CppDumper signature dump of [S1], see `_sources.md`).
Everything below is a class/field/method **signature**, confirmed by reading dump.cs directly (exact,
same tier as "Code" elsewhere in this project). The handful of items marked **pending** need
ARM64 disassembly (`dis_android.py`) to confirm the exact arithmetic; that tool is blocked this
session by a transient server-side outage (`auto mode classifier gave no verdict` on every Bash/
PowerShell/Skill call) — not a data gap, a tool-access gap. Resume with the `Reproduce` commands below.

## 1. The universal read point: `IMobStatusCalculator`

`dump.cs:42122` — interface, 20 members. Three are ours:

```
public abstract int ExpDefNormal { get; }   // Slot 16
public abstract int ExpDefSkill  { get; }   // Slot 17
public abstract int ExpDefMagic  { get; }   // Slot 18
```

`MobStatus.get_ExpDefNormal()` (`dump.cs:47875`, RVA `0x1F36F28`) is a trivial getter — RVA gap to
the next getter is 8 bytes, i.e. load field + ret, no computation. It proxies `localExpDefNormal`
(`dump.cs:47806`), the same **live, clamped 50–250 percentage** field already documented in
`../calc Reverse/proration/evidence.md` §1. So `IMobStatusCalculator.ExpDefNormal` is not the CSV
master step — it is the current per-hit state, exposed generically to every attack-side consumer.

## 2. Every mob type implements it — the mechanic is universal across game modes

23 concrete classes implement `IMobStatusCalculator` (`dump.cs`, grep `IMobStatusCalculator`):

`MobBattleStatus` (field, `dump.cs:43532`), `BossMobBattleStatus`, `BCollaboMobBattleStatus`,
`BCollaboBossMobBattleStatus`, `DefenceMobBattleStatus`, `DefenceBossBattleStatus`,
`DungeonMobBattleStatus`, `DungeonBossMobBattleStatus`, `GuildRaidMobBattleStatus`,
`GuildRaidBossMobBattleStatus`, `GuildRaidEntourageMobBattleStatus`, `HighRaidMobBattleStatus`,
`HighRaidBossBattleStatus`, `MobaMobBattleStatus`, `MobaOtherPlayerBattleStatus`,
`NewWaveMobBattleStatus`, `NewWaveBossBattleStatus`, `NonTargetDummyMobBattleStatus`,
`RezeroMobBattleStatus`, `ScoreAttackMobBattleStatus`, `ScoreAttackBossBattleStatus`,
`TreasureHuntMobBattleStatus`, `TreasureHuntBossBattleStatus`, `WaveMobBattleStatus`,
`WaveBossMobBattleStatus`.

`MobBattleStatus` (the field-mob one) wraps a `statusMaster: MobStatusMaster` (the CSV step bytes)
**and** a `mobStatus: MobStatus` (the live state) — confirming the pattern already found in
`../calc Reverse/proration/evidence.md`: the master supplies step size, `MobStatus` holds the
fluctuating percentage, and every mode's `*BattleStatus` wrapper hands that percentage out through
the one shared interface. Field, every boss family, guild raid, high raid, wave, dungeon, moba,
score attack, treasure hunt, defence, b-collab — one mechanic, one interface, no per-mode variant.

**Pending:** disassemble one non-field wrapper's `get_ExpDefNormal` (e.g. `BossMobBattleStatus`,
`GuildRaidBossMobBattleStatus`) to confirm it proxies its own `mobStatus` field the same trivial way
`MobBattleStatus` does. High confidence from the identical property shape; not yet byte-confirmed.

## 3. The universal write point: every attack type overrides `calcPlayerToMobDamage`

`dump.cs:16182` — declared on the root class:

```
protected virtual void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }
```

in `SkillActionBase` (`dump.cs:15681`), the base of every player attack action in the game
(`MobAttackBase` and `PlayerAttackBase` both derive from it). Grep count: **278 override sites**
(`grep -c "protected override void calcPlayerToMobDamage" dump.cs`), one per skill/action class
(`NormalAttackAction`, every `*PursuitAction`, every numbered skill class like `SpiralAirAction`,
dual sword, mercenary, rampage, guard, bonus-damage variants, ...). This is the literal "every attack
form in the game" the request asked for — each one independently computes its own damage, and (per
the sampled classes below) several take `IMobStatusCalculator` directly into a private helper to read
the prorate percentage.

### 3a. Which of the 278 actually touch proration state: `IsExpDefFluctuate` overrides (46, mapped 2026-09-28)

278 is *every* action that computes damage; only actions whose `get_IsExpDefFluctuate` override
returns something other than the base default flip the `p[slot]` state (evidence.md §4's gate check).
`scripts/map_isexpdeffluctuate_classes.py` walked every `public override bool get_IsExpDefFluctuate()`
line back to its nearest enclosing top-level `class` declaration in `dump.cs`. All 46 resolved cleanly:

`BonusMagicDamageAction`, `BonusNaturalDamageAction`, `BonusNormalDamageAction`,
`BonusPhysicalDamageAction`, `GuardStrikeAction`, `ImperialRayPursuitAction`,
`JumpbackShotPursuitAction`, `MagicPursuitAction`, `NormalAttackAction`, `PhysicalPursuitAction`,
`BackstepAction`, `ShadowWalkAttackAction`, `VenomSnatchAction`, `MoonSlashPursuitAction`,
`AirSlicerAction`, `HorizontalCutAction`, `LunaDitherStarAction`, `DimensionTillAction`,
`HomingShotAction`, `CrazyDaggerPursuitAction`, `LevenirAction`, `MagicEgelAttackAction`,
`AshuraAuraAttackAction`, `MindimageSenjuAttackAction`, `SlidingAction`, `HeavenlyStarAction`,
`WaveBladeAction`, `SummonSkeletonAction`, `CloningTechniqueAction`, `KunaiThrowingAction`,
`RangeHateAttackAction`, `AstralLanceAttackAction`, `CatarabomosAction`, `CounterForceAttackAction`,
`LebenGlanzAction`, `MagicBalkanAction`, `SlashReaperAction`, `BlizzardAction`, `ImperialRayAction`,
`LightningAction`, `MeteorStrikeAction`, `CallGolemNormalAttackAction`, `FlashGrenadeAction`,
`FreezeGrenadeAction`, `MagicGrenadeAction`, `DropManaCrystalAction`.

**Return values (disassembled 2026-09-29, all 46 + base; per-class table in `is_exp_def_fluctuate.csv`):**
base `SkillActionBase.get_IsExpDefFluctuate` (0x2487dfc) = `true`. Overrides:

- **33 return constant `false`** (`mov w0, wzr`): the Bonus*Damage actions, pursuit/follow-up actions
  (`Magic/Physical/MoonSlash/CrazyDagger/ImperialRay/JumpbackShot Pursuit`), Backstep, VenomSnatch, HorizontalCut,
  Levenir, MagicEgel, AshuraAura, Sliding, SummonSkeleton, CloningTechnique, RangeHate, AstralLance, Catarabomos,
  CounterForce, LebenGlanz, MagicBalkan, ImperialRay, CallGolem, the 3 grenades, DropManaCrystal, GuardStrike,
  DimensionTill, BonusNatural/Normal/Magic/Physical. These hits neither read nor flip `p[slot]`.
- **12 conditional**: return a per-instance byte field (ShadowWalkAttack, AirSlicer, HomingShot, MindimageSenju,
  HeavenlyStar, KunaiThrowing), `WaveBlade` (field == 0), `SlashReaper` (field == 2),
  `NormalAttackAction` (true unless `NormalAttackAction.Flag` 0x400 KnifeCombat set), `Blizzard`/`Lightning`/
  `MeteorStrike` (true unless `SkillParamFlag` 0x100 HighFamilia set). Field values are runtime state, not decoded.
- **1 explicit `true`**: `LunaDitherStarAction` (tail-calls the base).

Practical rule: everything not listed uses the base `true` (proration applies); the 33 constant-false classes are
exempt. Consumer of the flag in `Damaged`/`calcPlayerToMobDamage` was already traced in evidence.md §4.

Sampled consumers (grep `IMobStatusCalculator` argument in `PlayerAttackBase`/subclasses):

| Class | Method | dump.cs line | RVA |
|---|---|---|---|
| `NormalAttackAction` (plain field/normal attack — the path evidence.md flagged as *not traced*) | `private int CalcDef(PlayerActionManagerBase, IMobStatusCalculator)` | 72024 | `0x2066C6C` |
| `PlayerAttackBase` (shared, used by most skill classes) | `protected int CalcRegistDamage(SkillAttackType, PlayerStatusBase, IMobStatusCalculator, float)` | 72874 | `0x2074DBC` |
| unnamed skill class before `SpiralAirAction` | `private int CalcBonusResistDamage(PlayerStatusBase, IMobStatusCalculator)` | 116136 | `0x21FA7D8` |
| `NormalAttackAction` | `IsExpDefFluctuate` override (gate already documented in evidence.md §1) | 71953 | `0x20639A0` |

**Pending:** disassemble `NormalAttackAction.CalcDef` (`0x2066C6C`) to see the exact arithmetic —
whether it multiplies mob Def by the percentage, multiplies final damage directly (matching the
`(int)(damage * p/100)` pattern already proven in the minigame path), or both.

## 4. A shared static helper that smells like the generic rate lookup

`dump.cs:397856`, static class `SkillDataExtentionMethod` (`ExtensionMethod.ExSkillData` namespace):

```
public static float GetTargetExpRate(SkillAttackType attackType, int actionID, IMobStatusCalculator mob) { }
```
RVA `0x1EA9294`, size 492 bytes (next method `GetActorAtk` starts at `0x1EA9480`) — small enough for
`dis_android.py`'s single-shot disassembly, no manual range needed once the tool is back.

Signature shape (`SkillAttackType` + `actionID`, the same two inputs `MobStatus.GetExp` already
consumes to pick Normal/Skill/Magic, per evidence.md §1's `SkillAttackType`/`ExpType` table) is the
strongest single candidate for *the* generic "get this attack's proration rate" call — likely what
most of the 300+ `calcPlayerToMobDamage` overrides call instead of duplicating the switch each has.
**Pending: not yet disassembled — this is the single highest-value next target.**

## Reproduce (once the RE tool works again)

```
cd D:\toram_re
python dis_android.py 0x1F05EA0        # MobBattleStatus.get_ExpDefNormal — confirm it proxies mobStatus, not statusMaster
python dis_android.py 0x1EA9294        # SkillDataExtentionMethod.GetTargetExpRate — the likely universal rate lookup
python dis_android.py 0x2066C6C        # NormalAttackAction.CalcDef — field-path application (evidence.md's "not traced" item)
```
Then: exhaustively scan the `.text` segment for every `bl` targeting `0x1f37150` (`CalcExpDef`) and
`0x1f371d0` (`GetExp`) using `dis_android.py`'s `names`/`RELA` tables + `capstone`, map each call site
back to its enclosing function via `bisect` over `sorted(names)` — gives the complete caller list in
one pass instead of the four callers found manually in the original evidence.md.
