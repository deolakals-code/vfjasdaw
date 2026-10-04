# Level and EXP — formula

Source: Android `libil2cpp.so` (S1) + metadata blobs (D4). Evidence: [`evidence.md`](evidence.md).

## 1. EXP needed for the next level

```
NextExp(Lv) = (long)( 2*Lv + (0.5*Lv) * (Lv^3 * 0.05) )      # float32 math, truncated
            ≈ 0.025 * Lv^4 + 2 * Lv
```

The code (`PlayerStatusBase.GetNextExp`) runs in float32. Above about Lv 250 the result can differ from the exact real-number formula by a few points.

| Lv | NextExp (game, float32) | 0.025·Lv⁴+2·Lv |
|---|---|---|
| 1 | 2 | 2.025 |
| 10 | 270 | 270 |
| 50 | 156,350 | 156,350 |
| 100 | 2,500,200 | 2,500,200 |
| 150 | 12,656,550 | 12,656,550 |
| 200 | 40,000,400 | 40,000,400 |
| 250 | 97,656,752 | 97,656,750 |
| 300 | 202,500,608 | 202,500,600 |
| 350 | 375,156,960 | 375,156,950 |

Lv 1 → 2 needs 2 EXP. The amount grows with the 4th power of the level, so each +10 levels costs a lot more.

Moba mode (`MobaPlayerStatus`) uses a separate fixed table:

| Lv | NextExp |
|---|---|
| ≤ 25 | 100 |
| 26–50 | 200 |
| 51–75 | 400 |
| 76–100 | 800 |
| > 100 | 0 |

## 2. EXP from a monster — level-difference multiplier

```
d = | mobLv − playerLv |
baseExp = mob "exp" from mob_<map> record   (bosses: × difficulty ExpRate, see ../boss_difficulty)

if d <= 9:        exp = (int)(baseExp * (100 + Bonus[d]) / 100)
elif d < 20:      exp = baseExp
else:             exp = (int)(baseExp * (100 − Penalty[d − 20]) / 100)   # index past the end uses the last value (90)
exp = max(exp, 1)   # in the bonus and penalty branches
```

| d (level gap) | Bonus | Multiplier |
|---|---|---|
| 0–5 | +1000 % | **×11** |
| 6 | +900 % | ×10 |
| 7 | +800 % | ×9 |
| 8 | +600 % | ×7 |
| 9 | +200 % | ×3 |
| 10–19 | — | ×1 |
| 20–29 | −1 … −10 % (step 1) | ×0.99 … ×0.90 |
| 30–39 | −12 … −30 % (step 2) | ×0.88 … ×0.70 |
| 40–49 | −33 … −60 % (step 3) | ×0.67 … ×0.40 |
| 50–56 | −64 … −88 % (step 4) | ×0.36 … ×0.12 |
| 57+ | −90 % | ×0.10 |

Full penalty list (d:%): 20:1 21:2 22:3 23:4 24:5 25:6 26:7 27:8 28:9 29:10 30:12 31:14 32:16 33:18 34:20 35:22 36:24 37:26 38:28 39:30
40:33 41:36 42:39 43:42 44:45 45:48 46:51 47:54 48:57 49:60 50:64 51:68 52:72 53:76 54:80 55:84 56:88 57+:90.

- **The gap is an absolute value.** A mob 5 levels above you and a mob 5 levels below you both give ×11.
- **The client warns at |d| ≥ 20** (`MobMaster.CheckMobLevelExpWarning`: `d² ≥ 400`), which is exactly where the penalty starts.

Farming meaning:
- Keep mobs within ±5 levels for ×11.
- Each level past 5 loses a big chunk: 6 → ×10, 7 → ×9, 8 → ×7, 9 → ×3.
- From 10 levels apart it drops to ×1, an 11× loss.
- From 20 levels apart the penalty grows until it reaches ×0.1.

## 3. Other EXP multipliers found (how they stack is not in the client)

| Source | Where | Rule read |
|---|---|---|
| Term events | `GameEventManager.GetExpBonusRate(lv, isParty)` | sum over active `ExpBonusTermEvent`s of `LevelBonus` (if `BonusLevelLimit ≥ 1` and `lv ≤ BonusLevelLimit`) + `PartyBonus` (if in a party and `PartyBonus ≥ 1`) |
| Equipment/buff | `BonusType.bExpRate` (63) | exists; value comes from gear/buffs |
| Guild | `GuildExpRate`, guild facility EXP bonus | exists, not traced |
| Server bonuses | `UIPlayerStatusDetailPanel.ServerBonusType` TrophyExpBonus / OrbExpBonus | values sent by the server |
| EXP potions | `BankPotionData` (active EXP pot) | exists, not traced |
| Boss difficulty | `BossDifficultyLevelMethods.GetExp` | see `../boss_difficulty/formula.md` |

## 4. Confidence

- **NextExp:** Code.
- **Level-difference table:** Code and metadata.
  - It is read from `UIMobDropPanel`, which shows a mob's EXP on the map panel. EXP is actually granted by the server; that it uses the same table is **Inferred**, supported by the warning threshold matching.
- **Party split, the order the multipliers stack in, and caps:** not in the client, so unknown.
- **In-game check:** none yet. The easiest check is the map mob panel: it shows EXP after the level-gap rule for your current level.
