# What a damage simulator needs, and where each piece comes from

Evidence label for every formula below: **Code** (decoded from `libil2cpp.so`, offline). Nothing here has been compared with an in-game number except the items listed under "Cross-checks".

## 1. Hit pipeline

`engine.json` -> `get_damage` fixes the order (BaseDamage + constants, Def, rates truncated to int one by one, SkillRate, Stable, LastDamage ..., limits).
The inputs to those steps are decoded in [`STATS.md`](STATS.md) (all 1,164 functions) and [`CORE_FORMULAS.md`](CORE_FORMULAS.md) (the subset a simulator evaluates).

| Step input | Decoded in | Notes |
|---|---|---|
| player ATK / MATK / EqAtk / SubAtk | `PlayerSecondaryStatus.get_Atk` -> `EquipItemData.WeaponTypeCalculatorBase.CalcAtk` -> per weapon `calcAtkParam`, `calcMatkParam` | weapon family overrides in `EquipItemData.<Weapon>Calculator` |
| stability | `<Weapon>Calculator.CalcStable` / `SubCalcStable`, `PlayerSecondaryStatus.get_Stable`, `PlayerAttackBase.CalcStable` | weapon base stable = `item.dbData.Stable` (items.csv `stability`) |
| crit rate / crit damage | `PlayerSecondaryStatus.get_Critical`, `GetCrtRate`, `GetCrtConstant`, `get_CriticalDmg`, `CalcCriticalDmg` | |
| hit / flee / aspd / cspd | `get_Hit`, `get_Flee`, `get_Aspd`, `get_Cspd` | |
| element | `PlayerAttackBase.CalcElementBonus`, `CalcElementKillerBonus`, `CalcNormalElementWeaponDamageResistRate` | |
| rate multipliers | `PlayerAttackBase.CalcLastDamageRate`, `CalcBufferLastDamageRate`, `CalcSkillTypeBonusRate`, `CalcSkillMasteryLastDamageRate`, `CalcWeaponCharacteristicsLastDamageRate`, `CalcBonusLastDamageRate`, `CalcGemLastDamageRate`, `CalcCobmoRate`, `CalcDoubleThrowLastDamageRate` | |
| target resist | `PlayerAttackBase.CalcPowerResistDamage`, `CalcMagicResistDamage`, `CalcDistanceResistRate`, `CalcRegistDamage` | |
| monster side | `MobBattleStatus.get_Def / get_MagicDef / get_ExpDefNormal / ExpDefSkill / ExpDefMagic / get_StablePercent / get_NecessaryHit / get_DamagePercent ...` plus the boss / raid / dungeon variants | monster rows come from `monsters/monster_full.csv` (`lv`, `def`, `mdef`, `necessary_hit`, `element_name`, `proration_*`) |
| normal (non-skill) attack | `NormalAttackAction.*` (57 functions) | |
| damage taken by the player | `MobAttackBase.CalcBaseAttack`, `CalcHit`, `CalcLastDamage` | |

## 2. Inputs the simulator must ask for

- Player: level, the 9 primary stats (`PlayerPrimaryStatus`), skill levels (`SkillMasteryList` ids appear as plain numbers in the formulas; `skill_reference.json` maps them), which buffs are active, abnormal states.
- Equipment: main / sub weapon type and base ATK / stable / range (`items/items.csv`), refine, plus every `BonusType` line from gear (`BonusManager.GetBonusValue(BonusType.x)`; bonus names in `variables.json`, 83 entries).
- Target: one row of `monsters/monster_full.csv` (+ boss difficulty from `calc Reverse/boss_difficulty`), its buffs and abnormal states (`MobBuffManager`, `AbnormalStateManager`).
- Context: attack type, hit index, combo state (`PlayerAttackBase.CalcCobmoRate`), room / map type where a formula branches on it.

## 3. Values that are not in the client

Each has a network op or a server-fed manager as evidence (see `PROJECT.md` "Hard limits"): skill cooldown values, ailment / drop rolls, drop rates, quest rewards and EXP, raid level cap. A simulator must take these as user input.

## 4. Known residual gaps (full list in [`COVERAGE_STATS.md`](COVERAGE_STATS.md))

Closed in the last pass: `MobAttackBase.CalcBaseAttack` (the tail with `BossDifficultyLevelMethods.GetAttackRate`, the x1.5 abnormal step and `TryGetProperties<MobPropertyAbnormalAppliedDamageIncrease>` was lost because every class test was assumed true), all 14 generic-virtual-method call sites, `PlayerAttackBase.CalcElementBonus` (`Singleton<FieldManager>.get_Instance()`), the unnamed field reads in `NormalAttackAction.CalcMercenaryDamage` and `PlayerSecondaryStatus.get_AvoidStack`.

What is left, none of it on the player's own damage path:

- **Raid / score-attack boss part sums** (`BossMobBattleStatus`, `HighRaidBossBattleStatus`, `ScoreAttackBossBattleStatus` `get_Def` / `get_MagicDef` / `get_NecessaryHit`; 45 call sites in 16 functions): a `foreach` over the `PartsStatus` dictionary calls a virtual method on each part; the element type is lost through the enumerator, so the term shows as `?blr`. `HighRaidBossBattleStatus.get_NecessaryHit` is the only one that surfaces in a returned value (`(?blr + ...)`); read `ghidra_out/all/*.c` for the exact loop.
- `DefenceMobBattleStatus.get_GuardProbability`: the guard rate is read through a delegate (`invoke(Guard, statusMaster.guard, [Guard+0x28])`); the delegate target is set outside the function.
- `BonusManager.Update` (5 sites): the `OnInvokeBonus` event; side effect only.
- Eight raw field reads remain, none in a damage formula: `BonusManager` list / array plumbing (`[x+0x18]`), `MobaOtherPlayerBattleStatus.get_ExpDef*` (compiler closure field), `NormalAttackPattern.OnPostUpdate`, `PlayerStatusBase.GetEquipSubWeaponElement`.
- Skill pages: 2 recipe files still carry the old bogus name `set_DefaultMoveSpeed` and 4 carry `get_IsDead` as a virtual-call guess (was 44); the receiver there is an out value of `TryGetBuf` whose class is not known statically.

## 5. Independent cross-check with Ghidra 12.1.4

`libil2cpp.so` was imported into Ghidra (names from `script.json`, ARM64) and all 1,164 decoded functions were decompiled to C (`D:	oram_re\ghidra_out\`). `D:	oram_re\crosscheck_stats.py` compares the arithmetic constants and the named callees of that C against the decoded formulas: [`stats/CROSSCHECK.md`](stats/CROSSCHECK.md) (core 18 functions), [`stats/CROSSCHECK_all.md`](stats/CROSSCHECK_all.md) (all).

- Arithmetic constants: **0 differences in all 1,164 functions**.
- Callee names: 925 of 1,164 identical. The others are collection plumbing in functions that return no number (`Dispose`, `GetEnumerator`, `Add`, ...) and side-effect calls the value does not use.
- Core 18 functions: 15 identical; the 3 others differ only by a side-effect call (`get_Cspd`), the sub-weapon accessor (`get_Stable`), and the `TryGetValue` that we show as an index into the out value (`CalcBaseAttack`).
- Read side by side by hand and equal: `get_Critical`, `OneHundSwordCalculator.CalcStable`, `MobBattleStatus.get_Def` / `get_StablePercent`, `DungeonMobBattleStatus.get_DamagePercent`.
- The comparison found real decoder bugs, all fixed in `symexec.py` with every output regenerated: virtual calls dropped their arguments (`CalcAspd` was `calcAspdParam()`), class tests were assumed true, generic virtual calls were opaque.

## 6. Cross-checks that already agree with community knowledge

- `get_Critical`: crit rate = `25 + CRT * 10 / 34` (= 25 + CRT / 3.4).
- `get_Hit` core term: `DEX + Lv`.
- One-hand sword ATK: `Lv + 2*STR + 2*DEX + weapon ATK` (the dual-wield-with-skill branch adds AGI instead).

These are consistent with commonly quoted formulas but are not in-game measurements. To close the gap, read about 10-20 values from the game's status screen (ATK, stability, crit rate, hit, flee, aspd, cspd, DEF, MDEF) plus one skill hit against a known monster, and compare.

## 7. Regenerating

```
cd D:\toram_re
python harvest_stats.py            # decode (MergeEx), ~5 min, resumable; delete stats/decoded to force
python postfix_stats.py            # name raw [obj+0xNN] reads, il2cpp stubs
python render_stats.py             # STATS.md, COVERAGE_STATS.md
python render_core.py              # CORE_FORMULAS.md
python crosscheck_stats.py core    # needs ghidra_out/ (see section 5); also `all`
```
Viewer: `viewer\run_viewer.bat` -> tabs Skills / Skill variables / Stats / Files.
