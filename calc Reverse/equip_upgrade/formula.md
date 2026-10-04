# Equipment Upgrade (smith skill 365 "อัพเกรดอุปกรณ์") — formulas

Client class `SmithGrant` (+ `SmithGrantInfoWindow`, `GrantData`). The client computes everything shown in the UI and
sends only `itemUuid`, the stat types and the new stat values (`EnhanceEquipmentExplain`: `itemUuid`, `short[] property`,
`short[] propertyValue`). The server answers with `EnhanceEquipmentResponse { ItemList, MaterialList, Result, PlayerStatus }`.
So the success roll, the material deduction and the effect of skill 369 (keep on failure) are **server-side**; the
client formulas below are what the UI shows. Runnable version: [`grant_calc.py`](grant_calc.py) (self-check: `python grant_calc.py`).

Skills used (ids from SkillMaster): 354 ทั่งตีเหล็กส่วนตัว, 355/356/357/368 ทั่ง (anvils), 365 อัพเกรดอุปกรณ์,
366 อัพเกรดอย่างเที่ยงตรง, 367 อัพเกรดแบบมืออาชีพ, 370–375 ความเข้าใจ (metal / cloth / beast / wood / drug / mana).
`Lv(x)` = skill level, 0 when not learned.

## 1. Per-stat table (`GrantData.EnhanceCost`, 67 stats + `EnhanceElementCost`, 6 elements)

Full table: [`cost_table.csv`](cost_table.csv). Fields of each row (`EnhanceProperties2`):

| Field | Used for |
|---|---|
| `UsePotential` | potential per step |
| `DoubleUse` | 1 → ×2 potential on non-weapons (armor); 2 → ×2 on weapons; 0 → never |
| `Coefficient` | material base per step (§5) |
| `MaterialCategory` | material type: 0 Metal, 1 Cloth, 2 Beast, 3 Wood, 4 Drug, 5 Mana |
| `AbilityCategory` | group for the same-category penalty (§3) |
| `BaseMax` | cap below Lv 210; above it steps cost ×2 potential |
| `Rate` | cap growth per 10 player levels above 200 |
| `UpperMax` / `LowerMax` | hard cap of the positive / negative side (Lv ≥ 210) |
| `OverRate` | real value per step beyond ±`BaseMax` (only stats 12, 22, 24, 26, 28, 30, 32 have OverRate > 1) |

"Weapon" = ItemType 7–19 except 17 (Shield), or 23 (NinjutsuBook) (`UIItemListManager.CheckWeaponItem`).

## 2. Steps vs real values

The UI moves a stat one **step** at a time; the server receives the **real value**.
For stats with `OverRate > 1` (MaxHP flat, Accuracy, Dodge, DEF, MDEF, ASPD, CSPD flat):

```
real = steps                                  if |steps| <= BaseMax
real = ±BaseMax + (steps ∓ BaseMax) * OverRate  beyond that
```

e.g. flat ASPD (BaseMax 20, OverRate 16): steps 21, 22 → +36, +52.
MaxHP/MaxMP flat (12, 110) are displayed ×10. Resistances 121–128 cannot go below 0.

## 3. Max steps selectable (`getEnhanceMax`)

```
skill% = 10 + 3*Lv(365) + 3*Lv(366) + 3*Lv(367)            (max 100)
L = player level
if L < 210:
    max = min( int(skill%/100 * BaseMax), L/10, BaseMax )
else:
    extra = L/10 - 20
    grown = BaseMax + OverRate * int(Rate * extra)
    cap   = BaseMax + OverRate * ((UpperMax if positive else LowerMax) - BaseMax)
    max   = min( int(skill%/100 * grown), cap )
    if OverRate stat and max > BaseMax:  max = BaseMax + (max - BaseMax)/OverRate   (back to steps)
max = max(1, max)
```

Usable slots: `3 + floor((Lv(366)+2)*0.3) + floor((Lv(367)+4)*0.2)` → 3 … 8.

## 4. Potential cost (`CalcUsePotentialPoint`)

For each changed stat (`old` = value on the item, `delta` = change, `new = old + delta`, real values):

```
base = UsePotential, ×2 if DoubleUse applies (§1)

delta >= 0:
    A = part of the change below -BaseMax   (recovering a deep negative)
    B = part of the change above +BaseMax
    cost = base * ( (delta - A - B) + A/OverRate + 2 * B/OverRate )

delta < 0 (potential is given back):
    A = part above +BaseMax,  B = part below -BaseMax      (both negative)
    back = base * ( (delta - A - B) + A/OverRate + 0.5 * B/OverRate ) * (TEC/1000 + 0.05)
    cost = int(back)         (negative → refund)

element: cost = 100, or 10 if the item's master data already has that element
```

Then the whole set is multiplied by the same-category penalty, counted over the **final** stat list:

```
rate = 1 + 0.05 * Σ n²   over AbilityCategory groups with n >= 2 stats
total = int(rate * Σ cost)
```

## 5. Material points (`GetCurrentRequireMaterialPoint`)

```
P      = min(smith proficiency, limit) where limit = LvCap * (5*Lv(354) + 50)/100 if Lv(354) > 0,
         else ProficiencyManager.DefaultBlackSmithLimit (value not read; skill 354's text says 50)
factor = (100 - P/10 - P/50) / 100
Num    = ceil( floor(Coefficient * (100 - ΣLv(355,356,357,368)) / 10) * 0.1 )
each step between x and x±1 (steps, not real values):
    m    = max(|x|, |x±1|)
    raw  = int(Num * m² * 0.5)
    raw -= raw * Lv(understanding skill of this MaterialCategory) / 100
    cost += int(factor * raw)
```

`LvCap` = `FunctionLimitManager.GetValue(15)`, a server value (the same one that caps High Raid level).

## 6. Success rate shown (`OnGrantBeforeStartButton`)

```
skill = Lv(365) + (Lv(366)+10 if learned) + (Lv(367)+20 if learned)          (max 60)
base  = max(item's current potential, master potential of the item)
rate  = max(0, int(100 + skill + 230 * (potential_now - total_cost) / base))
```

With all skills at 10 this is the community formula `160 + 230 × remaining / base`.
The warning (with this rate) is shown only when `total_cost > potential_now`; at 0 the start button is disabled.
Whether the server rolls against exactly this number is **inferred** (not visible in the client).
