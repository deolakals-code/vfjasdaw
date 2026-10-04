# Validation of the automatically recovered formulas

Compared against the hand-derived Dual Sword notes (`calc Reverse/dual_sword/formula.md`) and in-game notes. **17/17 checks agree.**

| Check | Result | Recovered | Expected | Source |
|---|---|---|---|---|
| 642 Twin Slash SkillRate | PASS | `[1.6, 1.7, 1.8, 1.9, 2.0, 2.1, 2.2, 2.3, 2.4, 2.5]` | `[1.6, 1.7, 1.8, 1.9, 2.0, 2.1, 2.2, 2.3, 2.4, 2.5]` | dual_sword/formula.md 2.1 |
| 642 Twin Slash flat | PASS | `[110, 120, 130, 140, 150, 160, 170, 180, 190, 200]` | `[110, 120, 130, 140, 150, 160, 170, 180, 190, 200]` | dual_sword/formula.md 2.1 |
| 643 Parrying Sword SkillRate (gem 0) | PASS | `[1.01, 1.02, 1.03, 1.04, 1.05, 1.06, 1.07, 1.08, 1.09, 1.1]` | `[1.01, 1.02, 1.03, 1.04, 1.05, 1.06, 1.07, 1.08, 1.09, 1.1]` | 2.2 |
| 643 Parrying Sword flat | PASS | `[55, 60, 65, 70, 75, 80, 85, 90, 95, 100]` | `[55, 60, 65, 70, 75, 80, 85, 90, 95, 100]` | 2.2 |
| 646 Air Slide first-hit rate | PASS | `[1.27, 1.3, 1.32, 1.35, 1.37, 1.4, 1.42, 1.45, 1.47, 1.5]` | `[1.27, 1.3, 1.32, 1.35, 1.37, 1.4, 1.42, 1.45, 1.47, 1.5]` | 2.5 first hit |
| 646 Air Slide later-hit rate | PASS | `[0.32, 0.34, 0.36, 0.38, 0.4, 0.42, 0.44, 0.46, 0.48, 0.5]` | `[0.32, 0.34, 0.36, 0.38, 0.4, 0.42, 0.44, 0.46, 0.48, 0.5]` | 2.5 later hits |
| 646 Air Slide flat | PASS | `[55, 60, 65, 70, 75, 80, 85, 90, 95, 100]` | `[55, 60, 65, 70, 75, 80, 85, 90, 95, 100]` | 2.5 |
| 646 Air Slide blind chance | PASS | `[17, 20, 22, 25, 27, 30, 32, 35, 37, 40]` | `[17, 20, 22, 25, 27, 30, 32, 35, 37, 40]` | 2.5 blind chance |
| 652 Shining Cross flat | PASS | `[120, 140, 160, 180, 200, 220, 240, 260, 280, 300]` | `[120, 140, 160, 180, 200, 220, 240, 260, 280, 300]` | 2.11 |
| 652 Shining Cross rate contains 10*Lv+300 | PASS | `(max((((((Lv * 10) + 300) + (((status.Agi // 4) + (status.Str // 4)) + (status.Dex // 4)))` | `10*Lv+300 + stats/5` | 2.11 |
| 653 Storm Reaper flat | PASS | `[110, 120, 130, 140, 150, 160, 170, 180, 190, 200]` | `[110, 120, 130, 140, 150, 160, 170, 180, 190, 200]` | 2.12 |
| 653 Storm Reaper rate base 10*Lv+400 | PASS | `((((((Lv + (Lv << 2)) << 1) + 400) + ((baseDEX // 25) * Lv))) / 100)` | `10*Lv+400+(baseDEX/100)*Lv` | 2.12 (DEX divisor differs, see below) |
| 655 Luna Dither Star flat | PASS | `[400, 400, 400, 400, 400, 400, 400, 400, 400, 400]` | `[400, 400, 400, 400, 400, 400, 400, 400, 400, 400]` | 2.15 |
| 656 Twin Buster Blade flat | PASS | `[30, 60, 90, 120, 150, 180, 210, 240, 270, 300]` | `[30, 60, 90, 120, 150, 180, 210, 240, 270, 300]` | 2.16 |
| 659 Aerial Slay flat | PASS | `[120, 140, 160, 180, 200, 220, 240, 260, 280, 300]` | `[120, 140, 160, 180, 200, 220, 240, 260, 280, 300]` | 2.18 |
| 33 Hard Hit flinch chance (1H sword, in-game note '+50%') | PASS | `[60, 64, 69, 73, 78, 82, 87, 91, 96, 100]` | `[60, 64, 69, 73, 78, 82, 87, 91, 96, 100]` | skills_full notes Lv10 |
| 36 Sword Mastery EqAtkRate | PASS | `[3, 6, 9, 12, 15, 18, 21, 24, 27, 30]` | `[3, 6, 9, 12, 15, 18, 21, 24, 27, 30]` | 3% per level (Toram community value) |

## Known difference

Storm Reaper (653): the recovered code divides the stat by **25** (`mul x8,x8,#0x51eb851f ; asr x8,x8,#0x23`, i.e. multiply-high by the
magic constant then shift 35 = ÷25) while `dual_sword/formula.md` 2.12 says ÷100. The instruction stream of the Storm Reaper damage method (skill 653 `details/` page) shows the
shift is 35, so the recovered ÷25 follows the code; the earlier note should be re-checked. Not verified in game.
