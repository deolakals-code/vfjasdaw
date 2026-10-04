# Equipment Upgrade — evidence

Binary: S1 (`libil2cpp.so`, Android). Layouts: D1 (`dump.cs`). Code RVA = file offset + 0x4000; `.rodata` constants
read at the VA directly. Label: **Code** unless marked otherwise.

## Tools / raw dumps (offline)

| File | Content |
|---|---|
| `D:\toram_re\grant\smithgrant_all.txt` | `dis2.py -c SmithGrant` of all 43 SmithGrant / GrantData / RequireData methods used below |
| `D:\toram_re\grant\infowindow_all.txt` | every `SmithGrantInfoWindow`, `SmithGrantElement`, `ShopUtil.IsWeaponItem/IsArmorItem`, `CheckWeaponItem` method |
| `D:\toram_re\grant\requiredata_all.txt` | `SmithGrant.RequireData(.requireData)` methods |
| `D:\toram_re\grant\cost_table.tsv` | raw output of `scripts\decode_cost_table.py` |
| `scripts\decode_cost_table.py` | walks `GrantData..cctor` with a register tracker, captures every `EnhanceProperties2..ctor` + `Dictionary.Add` |

Reproduce: `python D:\toram_re\grant\decode_cost_table.py > cost_table.tsv` (73 entries; element dict ctor at 0x1D83D20).

## 1. Classes

| Class (TypeDefIndex) | Role |
|---|---|
| `SmithGrant` (8486) | the skill-365 UI; fields `SlotRequire` 0x118, `InfoWindow` 0xB0, `playerDataManager` 0x138 |
| `SmithGrant.RequireData.requireData` (8476) | one slot: `bonusType` 0x20, `ElementType` 0x24, `BonusValue` 0x28 (delta, real units), `IsFixed` 0x2C, `FixedBonusValue` 0x30 (value already on the item) |
| `SmithGrantInfoWindow` (8492) | step editor: `DetailVal` 0xA0 (steps), `DetailType` 0xA4, `DetailRequireNum` 0xA8, `DetailRequireType` 0xAC, `WeaponPotential` 0xC8, `ItemId` 0xCC, `fixedVal` 0xD4, `realFixedVal` 0xD8 |
| `GrantData` (8487) | static `EnhanceCost` (BonusType → EnhanceProperties2), `EnhanceElementCost`, `const LimitLevel = 210` |
| `Toram.Common.Productions.EnhanceProperties2` (11353) | `UsePotential 0, Coefficient 4, MaterialCategory 8, AbilityCategory 0xC, float Rate 0x10, BaseMax 0x14, UpperMax 0x18, LowerMax 0x1C, OverRate 0x20, DoubleUse 0x24` |
| `EnhanceEquipmentExplain` (14949) | request: `itemUuid`, `short[] itemPropertyS`, `short[] itemPropertyValue` only |
| `EnhanceEquipmentResponse` (11707) | `ItemList`, `MaterialList`, `bool Result`, `PlayerStatus` → result decided by the server |

## 2. Cost table — `GrantData..cctor` 0x1D81F1C (8388 bytes)

Each entry: `EnhanceProperties2..ctor` 0x36F2178 with `w1 UsePotential, w2 Coefficient, w3 MaterialCategory,
w4 AbilityCategory, s0 Rate, w5 BaseMax, w6 UpperMax, w7 LowerMax, [sp] OverRate, [sp+8] DoubleUse`, then
`Dictionary<Int32Enum,EnhanceProperties2>.Add` 0x28A36CC with the key in `w1`. First entry at 0x1D81FC8..0x1D82060:
`mov w1,#5; mov w2,#0x32; mov w3,#2; mov w4,#1; fmov s0,#1.0; mov w5,#0x14; mov w6,#0x32; mov w7,#0x32; str w21(=1),[sp]; str wzr,[sp,#8]` → key 1 (bStr).
Non-immediate rates come from `.rodata`: 0x946A84 = 0.35, 0x946CB8 = 0.19, 0x946A14 = 0.69, 0x946F3C = 0.40 (float32).
Keys resolved with enum `BonusType` / `ElementType` (D1); Thai names from GameScene_th `ItemProperty_th` (same ids).
Sanity check: MaterialCategory STR→Beast, INT→Wood, VIT→Metal, AGI→Cloth, DEX→Drug, element→Mana — same as the in-game material types (in-game knowledge, not a new check).

## 3. Formulas

| Formula | Method (RVA) | What was read |
|---|---|---|
| Base potential | `GrantData.GetUsePotential(BonusType)` 0x1D83FE0 | item not found → 9999; `UsePotential << (DoubleUse==1 && IsArmorItem(Type))` or `<< (DoubleUse==2 && IsWeaponItem(Id))` (0x1D840E4..0x1D84118). `IsArmorItem` = type 20; `IsWeaponItem` = master TypeId 7..19, not 17 |
| Element potential | `GrantData.GetUsePotential(ElementType)` 0x1D8413C | collects master `CapId1..10/CapVal1..10`; cap 0x41 with value == element → `x * 0x66666667 >> 34` (= /10) at 0x1D849A4 |
| Potential in the real calc | `SmithGrant.CalcUsePotentialPoint` 0x1D7F55C | double rule via `CheckWeaponItem(Type)` 0x1D7FAB0..0x1D7FAD0 (`csel` DoubleUse==2 / ==1). Positive branch 0x1D7FC14..0x1D7FC60 (two `sdiv` by OverRate, `add w8, w9, w8, lsl #1` = ×2 above BaseMax). Negative branch 0x1D7FC68..0x1D7FDB8: `(B/OR*0.5 + normal + A/OR) * base * (TEC/1000 + 0.05)`; 0.05 = `.rodata` 0x946D88, TEC = `IPlayerStatusCalculator` slot 9 (`get_Tec`). Element: `/10` at 0x1D7FD10 when master cap 0x41 matches. End: `(int)(rate * (short)total)` 0x1D7FDE0 |
| Category penalty | same method 0x1D7F714..0x1D7F9A8, and `RequireData.GetPotentialRate` 0x1D803F0 | per AbilityCategory count; first repeat sets 1 then +1 → n; `rate = 1 + Σ n*n*0.05` (`mul w8,w8,w8; fmul s0,s0,s9; fadd`) |
| Slot potential (old path) | `requireData.GetPotential` 0x1D802A0 | BonusValue 0 → 0; > 0 → Potential; < 0 → `-(int)((TEC/1000 + 0.05) * |Potential|)` |
| Success rate | `SmithGrant.OnGrantBeforeStartButton` 0x1D7E11C | 0x1D7E21C `ldrsh [master,#0x4c]` (ItemDBData.Potential) `csel` max with WeaponPotential; 0x1D7E238 `use - pot`; 2.3 = `.rodata` 0x946E6C; `-100f / base`; `+ (skill + 100)`; `bic` → max 0; `cmp #0x63` → ≥ 100 no warning; 0x1D7E2B0 warning only when use > pot; rate ≤ 0 → `grantWarningStartButton.isEnabled = false` |
| Skill part | `SmithGrant.getSuccessSkillRate` 0x1D7E4DC | `GetSkillLv(0x16D/0x16E/0x16F)`; `max(0,a) + (b>0 ? b+10 : 0) + (c>0 ? c+20 : 0)` |
| Slots | `SmithGrant.getUsableSlotCount` 0x1D7BAEC | `floor((Lv366+2)*0.3) + 3 + floor((Lv367+4)*0.2)`; 0.3 = 0x9470F4, 0.2 = 0x946FC0 |
| Max steps | `SmithGrantInfoWindow.getEnhanceMax` 0x1D87528 | skill% `3a+10+3b+3c` (0x1D87700..0x1D8773C); `cmp w24,#0xd1` (Lv ≤ 209); Lv ≥ 210 branch 0x1D87744..0x1D879E0 (`L/10 - 20` via 0xCCCCCCCD, `Rate*extra`, `OverRate*… + BaseMax`, `BaseMax + OverRate*(Upper/Lower - BaseMax)`, back-to-steps for OverRate types); Lv < 210 branch 0x1D87860..0x1D8790C; `Math.Max(1, …)`. Player level = IPlayerStatusCalculator slot 0 |
| OverRate stat set | `SmithGrantInfoWindow.CheckOverRateType` 0x1D86694 | `ror(type-12,1)`, mask 0x7E1 → types 12, 22, 24, 26, 28, 30, 32 |
| Steps ↔ real values | `SmithGrant.SetRequireMaterial` 0x1D7DB8C..0x1D7DCB4 | FixedBonusValue (real) → steps (`sdiv` OverRate), + DetailVal, → real (`madd`), BonusValue = real new − FixedBonusValue. Sent value = `BonusValue + FixedBonusValue` (`<GetEnhanceValueProperties>b__15_0` 0x1D80ED0; element sends ElementType) |
| Display | `SmithGrantInfoWindow.UpdateDetailVal` 0x1D866BC | types 12 / 110 (0x6E) shown ×10 (0x1D86784..0x1D867A0); step → real display 0x1D86BDC..0x1D86C28; its own potential preview uses steps: `(delta-B)*pot + 2*B*pot`, TEC refund with 0.5 beyond base |
| +/- buttons | `OnPlus` 0x1D87414, `OnMinus` 0x1D87B3C, `OnMinusMax` 0x1D87C84 | ±1 step inside ±getEnhanceMax; element fixed at 1; types 121..128 (`sub w10,w11,#0x79; cmp #7`) clamped at total 0 |
| Material points | `SmithGrantInfoWindow.GetCurrentRequireMaterialPoint` 0x1D87E1C | `(100 - P/10 - P/50)/100` (magic 0x99999999>>34, 0xAE147AE1>>36); per step `(m*m*Num) * 0.5` in double; `CalcUnderstandSkill`; `* factor`, truncated; three loops (0x1D87F70 / 0x1D88078 / 0x1D881A8) all reduce to m = max(|x|,|x±1|) |
| Proficiency P | `ProficiencyManager.BlackSmithLimitLevel` 0x205A560, `getBlackSmithLimitIncreaseBySkill` 0x205A310 | `min(BlackSmith, limit) / 100`; limit = `FunctionLimitManager.GetValue(15) * (5*Lv(0x162)+50)` if Lv(354) > 0 else `DefaultBlackSmithLimit` |
| Understanding | `CalcUnderstandSkill` 0x1D88328 | jump table `.rodata` 0x94848E `[0,21,7,28,14,35]` → Metal 370, Cloth 371, Beast 372, Wood 373, Drug 374, Mana 375; lv clamped ≤ 100, < 1 → unchanged; `x - lv*x/100` |
| Num (anvils) | `CalcCoefficientMitigation` 0x1D86FD4 + `.ctor` 0x1D8844C | list = skills 0x164, 0x163, 0x165, 0x170 (356, 355, 357, 368), Sum of levels; `ceil(floor((100-S)/100*coef*10) * 0.1)` (0.1 = 0x946BF0) |
| Num source | `SmithGrant.SetSelected` 0x1D7A5F8 | `SetRequireMaterialTypeAndValue(MaterialCategory, Coefficient)` |

## 4. Checks

- `grant_calc.py` self-check (hand-computed from the formulas above) passes.
- With skills 365/366/367 at 10 the success formula is `160 + 230 × remaining / base` — matches the community formula (**In-game knowledge**, not re-measured here).
- Not checked against a live in-game number in this session.

## 5. Not in the client

- The roll, material deduction, "no change on first-slot failure" (skill 369: no client reference found by skill id 0x171 in these classes) → server.
- `FunctionLimitManager.GetValue(15)` (level cap) and `DefaultBlackSmithLimit` value → server / runtime.
