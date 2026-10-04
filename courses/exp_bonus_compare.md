# EXP bonus: monthly course vs trophies (and everything else)

Source: `UIPlayerStatusDetailPanel.CalcExpValue` 0x1CB0C90 and `CalcDropValue` 0x1CB0EA0 (S1), the numbers the
status-detail screen shows. Raw dump: `D:\toram_re\course\expcalc.txt`.

## How the screen adds them up (Code)

```
EXP% = 100 + Character + TrophyExpBonus + OrbExpBonus + Event
       = 0 if the Registlet "ผู้ฝึกสอน" (GemCartId 68 Instructor) is equipped
Drop% = 100 + GetDropBonus + TrophyDropBonus + OrbDropBonus + GameEventManager.GetDropRate
```

All plain integer additions (`add w8, w20, w24; add w8, w8, w23; add w8, w8, w19; add w19, w8, #0x64`).
`TrophyExpBonus`/`OrbExpBonus` come from the server as `serverBonusList[0..3]` (enum `ServerBonusType`:
0 TrophyExp, 1 OrbExp, 2 TrophyDrop, 3 OrbDrop). "Orb" = the monthly course.

So a course and a trophy bonus **do not multiply each other**: they are separate lines that are summed.
That the server grants EXP with this same sum is **inferred** (the client only displays it).

## Sources

| Line | Source | Value | Duration / condition | Where the value comes from |
|---|---|---|---|---|
| OrbExpBonus | คอร์สมาตรฐาน | +50% | while the course is active | course text; value sent by server |
| OrbExpBonus | คอร์สเร่งเลเวล | +100% | while the course is active | course text; value sent by server |
| OrbExpBonus | คอร์สขยายกระเป๋า | +0% | – | course text |
| TrophyExpBonus | บันทึกการผจญภัย เล่ม 1–16 (Id 501–516) | +10% … +25% (+1% per book) | permanent, **only while your level is below** 30, 60, … 480 (book n: Lv < 30n) | Trophy_th reward text |
| TrophyExpBonus | Daily trophies 10000–10002, 10010–10011, 10250 | +10% | 1 day | Trophy_th |
| TrophyExpBonus | Daily trophies 10238, 10247 (event) | +50% | 1 day | Trophy_th |
| Character | `BonusType.bExpRate` (63) on gear / items / food / timed buffs | item value | item | `BonusManager.GetBonusValue(63)` |
| Character | Skill 194 เพิ่ม Exp | +1% per skill level | learned | `GetExpBonus` 0x2051A88 (skill 0xC2, param 0x1C) |
| Character | Skill 769 บทเพลงแห่งการเยียวยา (buff) | buff param 0x32 | while buffed | `GetExpBonus` 0x2051AD0 |
| Character | Registlet ผู้ฝึกตน (GemCartId 26) | +10% | equipped (also −15% damage per its text) | `GetExpBonus` 0x2051B14..0x2051B2C |
| Character | Guild booster | `GuildManager.GetBoosterRate` | booster type 1, or type 4 when account level ≤ levelLimit/3 | `GetExpBonus` 0x2051B20..0x2051B9C |
| Character | Guild facility EXP bonus | facility value | guild | `BonusManager.GetGuildFacilityExpBonus` |
| Event | EXP term events | LevelBonus (+ PartyBonus in a party) | event period | `GameEventManager.GetExpBonusRate(lv, inParty)` |
| – | Registlet ผู้ฝึกสอน (GemCartId 68) | EXP% = 0 | equipped | `CalcExpValue` 0x1CB0DB4..0x1CB0DC8 |

## Course vs trophy

| | Monthly course (เร่งเลเวล) | Trophy EXP |
|---|---|---|
| Size | +100% (มาตรฐาน +50%) | +10…25% (adventure logs), +10% or +50% (daily) |
| Line on the screen | OrbExpBonus | TrophyExpBonus |
| Duration | 30 days (or 3/7/15-day items) | adventure log: permanent until you out-level it; daily: 1 day |
| Level limit | none in the text | adventure log n: only below Lv 30n |
| Stacking | added to the trophy line | added to the course line |

Example (Lv 200, course เร่งเลเวล, adventure log 7 = +16%, daily +10%, no gear):
`100 + 100 + (16 + 10) = 226%` on the screen, not `100 × 2.0 × 1.26 = 252%`.
Whether several trophy bonuses add inside `TrophyExpBonus` (16 + 10) is decided by the server; the client only
receives the total.

The level-gap multiplier (×11 within ±5 levels, `../calc Reverse/level_exp/formula.md`) is applied to the mob's base EXP
and is not part of this screen; how the server combines it with the % above is not visible in the client.
