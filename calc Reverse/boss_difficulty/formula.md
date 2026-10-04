# Boss difficulty scaling — formula

Applies to bosses fought through the boss difficulty menu (`BossMobBattleStatus`, and boss parts via `MobPartsStatus`).
Input values are the Normal-difficulty stats stored in the map's `mob_<map>` file (see `monsters/monsters.csv`).

## Index

```
difficulty: Easy = -1, Normal = 0, Hard = 1, Nightmare (code name Lunatic) = 2, Ultimate = 3
i = clamp(difficulty, -1, 3) + 1          -> 0..4
```

## Tables

| Table | Easy | Normal | Hard | Nightmare | Ultimate | Type |
|---|---|---|---|---|---|---|
| LvRate | -10 | 0 | 10 | 20 | 40 | int |
| HpRate | 0.1 | 1 | 2 | 5 | 10 | float32 |
| StatusRate | 0.1 | 1 | 2 | 4 | 6 | float32 |
| AttackRate | 0.5 | 1 | 2 | 4 | 6 | float32 |
| FlinchResistRate | 0 | 0 | 3 | 6 | 9 | float32 |
| TumbleResistRate | 0 | 0 | 6 | 12 | 18 | float32 |
| StunResistRate | 0 | 0 | 10 | 20 | 30 | float32 |
| ExpRate | 0.1 | 1 | 2 | 5 | 10 | float32 |
| PartsExpRate | 0.1 | 1 | 1 | 1 | 1 | float32 |
| DropRate | -90 | 0 | 100 | 200 | 400 | int |

## Formulas

All multiplications are done in float32 and truncated toward zero (`fcvtzs`).

```
Level       = max(1, lv + LvRate[i])                                  (result stored as int16)
MaxHp       = (int)(HpRate[i]     * hp)
Def         = (int)(StatusRate[i] * def)
MagicDef    = (int)(StatusRate[i] * mdef)
NecessaryHit= (int)(StatusRate[i] * necessaryHit)
Attack      = (int)(AttackRate[i] * attack)        # boss attack power; also used in mob flee calc
Exp         = (int)(ExpRate[i] * exp + PartsExpRate[i] * partsExp)
FlinchResistTime = max(param, FlinchResistRate[i])
TumbleResistTime = max(param, TumbleResistRate[i])
StunResistTime   = max(param, StunResistRate[i])
```

A float result of +infinity returns `int.MinValue` (overflow guard in every `(int)(rate * x)` path).

## Not scaled by difficulty

`BossMobBattleStatus` getters that do not call any difficulty method: CutAttack, CutMagicAttack (physical/magic resistance),
GuardProbability, AvoidProbability, Element, MoveSpeed, Persona, DamagePercent, NecessaryFleePercent, StablePercent,
ExpDefNormal/Skill/Magic (prorations).

## Open points (Inferred)

- DropRate has no getter in the client; no client method reads it. Most likely applied on the server. Unit (percent bonus) not confirmed.
- Resist-time unit is probably seconds; not confirmed.
- `partsExp` (EXP for breaking boss parts) is not in `mob_` records we decode, so `boss_difficulty.csv` only scales `exp`.

## Worked example (In-game check)

Krust (クースト, uuid 587), map 24100 "เขตลาบรินธ์: ลานกว้าง", record id 1: Normal Lv 178, HP 3,500,000, DEF/MDEF 534, EXP 18,200.

| | Lv | HP | DEF/MDEF | EXP |
|---|---|---|---|---|
| Easy | 168 | 350,000 | 53 | 1,820 |
| Normal | 178 | 3,500,000 | 534 | 18,200 |
| Hard | 188 | 7,000,000 | 1,068 | 36,400 |
| Nightmare | 198 | 17,500,000 | 2,136 | 91,000 |
| Ultimate | **218** | **35,000,000** | 3,204 | 182,000 |

The user saw Ultimate Krust in game at Lv 218 with 35,000,000 HP.
