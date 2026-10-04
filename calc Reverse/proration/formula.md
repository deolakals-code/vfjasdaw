# Monster proration — formula

The three bytes `proration_normal / proration_physical / proration_magic` in `monsters/monster_full.csv`
are the master fields `MobStatusMaster.expDefNormal / expDefSkill / expDefMagic`.
They are **per-hit step sizes**, not a base value and not a resistance. Every monster starts at 100 / 100 / 100.

## State (per monster instance)

```
p[Normal] = p[Skill] = p[Magic] = 100        (MobStatus..ctor)
```

## On each hit that counts for proration (see "Which hits count" below)

Attack type from `SkillActionBase.ExpType` (`SkillAttackType`):

| ExpType | Proration slot |
|---|---|
| SkillNormal (3), or ActionID == 0 (plain normal attack) | Normal |
| Physics (1) | Skill (physical skills) |
| Magic (2) | Magic |

```
for each slot s in {Normal, Skill, Magic}:
    step = master.expDef[s]                 # the CSV byte
    p[s] += (s == hit slot) ? -step : +step
    p[s]  = clamp(p[s], 50, 250)
```

The hit slot goes down by its own step; the other two go up by **their own** steps.
Only actions whose `IsExpDefFluctuate` is true change the state.

## Which hits count

Not every hit changes the state. Per action instance (one `SkillActionBase`) and per target:

- Miss (`HitType == 0`): never.
- Default: only the **first** damaging hit of that action on that target. Hits 2..n of the same action on the same
  target leave `p` unchanged (they still use the current `p` in the damage formula).
- `ActionID` 10-12, 25-28, 1058 and classes whose `IsExpDefFluctuate` is false: never (`is_exp_def_fluctuate.csv`).
- Bypass the first-hit gate (change `p` on every hit): Kunai Throwing (1219), Air Slicer (658), Homing Shot (554);
  Magic Knife (117), MindimageSenju (159), Slash Reaper use their own check; Crazy Dagger (301) needs first hit AND
  `DamageIndividualFlag` bit 1.

Multi-hit skills: all hits of one cast share one action instance (evidence section 12), so the same rule holds for
the whole cast. Per-skill result for all 398 skill ids: `proration_calculator/skill_proration_modes.csv`.

Data: `proration_calculator/proration_hit_rules.json`; evidence.md §11.

## Damage use

```
damage = (int)(damage * p[slot] / 100)
```

(Read in the HuntingOne / SummonDemonic minigame damage paths. `GetTargetExpRate` is the `p[slot]/100`
conversion point; its callers are `PlayerAttackBase.TemplateAssignment` (the field damage pipeline) and
`BusterLanceAction` / `HolyFistAction` / `PetNormalMagicAction` `.calcPlayerToMobDamage` — see evidence §8-9.
`CalcPowerResistDamage`/`CalcMagicResistDamage` are NOT part of proration: they are the pierce/resist
reduction, `(int)(dmg * (1 - min(1, sum)))`.)

## Reading the CSV

| CSV | Meaning |
|---|---|
| 0 / 0 / 0 | proration never moves: always 100% |
| 10 / 10 / 10 | each hit: used type −10, others +10 |
| 100 / 100 / 100 | one hit drops the used type to the 50% floor and raises the others to 200% |
| 20 / 1 / 1 | normal attacks fall fast (−20); skills/magic fall slowly (−1) and recover slowly |

Worked example, step 10 / 5 / 10, from fresh:

| After | Normal | Skill | Magic |
|---|---|---|---|
| start | 100 | 100 | 100 |
| 1 normal attack | 90 | 105 | 110 |
| + 1 physical skill | 100 | 100 | 120 |
| + 1 magic skill | 110 | 105 | 110 |

## Open points (Inferred)

- The server also sends values (`MobStatus.SetExpDef` via `EnemyMobActionManagerBase.UpdateExpDef`) and overwrites the local state; the client copy is a prediction. Server-side formula assumed identical, not confirmed.
- Not checked in game.
