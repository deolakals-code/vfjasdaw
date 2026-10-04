"""Toram "Equipment Upgrade" (smith skill 365, client class SmithGrant) - re-implementation of the client math.

Every function mirrors one method in libil2cpp.so (see evidence.md for addresses). float32 is emulated where the
client uses `s` registers, int truncation where it uses fcvtzs / sdiv. The success roll itself is server-side.

usage: python grant_calc.py            (runs the self-check)
"""
import csv
import math
import os
import struct

HERE = os.path.dirname(os.path.abspath(__file__))
ELEMENT = 65  # BonusType.bElement
OVER_RATE_TYPES = {12, 22, 24, 26, 28, 30, 32}  # SmithGrantInfoWindow.CheckOverRateType (mask 0x7e1)
X10_DISPLAY = {12, 110}  # UpdateDetailVal shows value * 10 (bMaxHpTo10 / bMaxMpTo10)
NO_NEGATIVE = set(range(121, 129))  # OnMinus/OnMinusMax clamp: total never below 0
ANVILS = (355, 356, 357, 368)  # CoefficientMitigationSkillList (.ctor 0x1d8844c)
UNDERSTAND = {0: 370, 1: 371, 2: 372, 3: 373, 4: 374, 5: 375}  # MaterialType -> skill (CalcUnderstandSkill)


def f32(x):
    return struct.unpack("<f", struct.pack("<f", x))[0]


def trunc_div(a, b):
    """C# / on ints (ARM sdiv): truncates toward zero."""
    q = abs(a) // abs(b)
    return q if (a >= 0) == (b >= 0) else -q


def load_table():
    bonus, element = {}, {}
    with open(os.path.join(HERE, "cost_table.csv"), encoding="utf-8-sig") as f:
        for r in csv.DictReader(f):
            p = {k: (f32(float(r[k])) if k == "Rate" else int(r[k])) for k in
                 ("UsePotential", "Coefficient", "MaterialCategory", "AbilityCategory", "Rate", "BaseMax",
                  "UpperMax", "LowerMax", "OverRate", "DoubleUse")}
            (bonus if r["dict"] == "Bonus" else element)[int(r["key"])] = p
    return bonus, element


BONUS, ELEM = load_table()


def props(bonus_type, value=0):
    """Table row for a stat; element rows are keyed by the ElementType carried in the value."""
    return ELEM[value] if bonus_type == ELEMENT else BONUS[bonus_type]


def is_weapon_type(item_type):
    """UIItemListManager.CheckWeaponItem: 7..19 except 17 (Shield), or 23 (NinjutsuBook)."""
    return (item_type != 17 and 7 <= item_type <= 19) or item_type == 23


def base_potential(bonus_type, value, item_type, master_caps=()):
    """Potential per step before the category rate (GrantData.GetUsePotential / CalcUsePotentialPoint head).
    DoubleUse 1 doubles on non-weapons (armor), 2 on weapons. Element: 100, /10 if the item's master data
    already carries that element (cap 65 == value)."""
    p = props(bonus_type, value)
    double = p["DoubleUse"] == (2 if is_weapon_type(item_type) else 1)
    pot = p["UsePotential"] << int(double)
    if bonus_type == ELEMENT and (ELEMENT, value) in master_caps:
        pot = trunc_div(pot, 10)
    return pot


def to_steps(bonus_type, value):
    """Real stat value -> UI step count (SmithGrant.SetRequireMaterial 0x1d7dc00)."""
    if bonus_type not in OVER_RATE_TYPES:
        return value
    p = BONUS[bonus_type]
    bm, orr = p["BaseMax"], p["OverRate"]
    if value > bm:
        return bm + trunc_div(value - bm, orr)
    if value < -bm:
        return -bm - trunc_div(-(value + bm), orr)
    return value


def from_steps(bonus_type, steps):
    """UI step count -> real stat value sent to the server (SetRequireMaterial 0x1d7dc38..0x1d7dcb4)."""
    if bonus_type not in OVER_RATE_TYPES:
        return steps
    p = BONUS[bonus_type]
    bm, orr = p["BaseMax"], p["OverRate"]
    if steps > bm:
        return bm + (steps - bm) * orr
    if steps < -bm:
        return -bm + (steps + bm) * orr
    return steps


def enhance_max(is_upper, bonus_type, player_lv, lv365=0, lv366=0, lv367=0):
    """SmithGrantInfoWindow.getEnhanceMax -> largest |step| selectable (upper: +, lower: -)."""
    p = BONUS[bonus_type]
    skill = f32(f32(f32(3 * max(0, lv365) + 10.0) + 3 * max(0, lv366)) + 3 * max(0, lv367))
    pct = f32(skill / 100.0)
    bm = p["BaseMax"]
    if player_lv <= 209:
        m = min(min(int(f32(pct * bm)), trunc_div(player_lv, 10)), bm)
    else:
        extra = max(0, player_lv // 10 - 20)
        grown = p["OverRate"] * int(f32(p["Rate"] * extra)) + bm
        cap = p["UpperMax"] if is_upper else p["LowerMax"]
        m = min(int(f32(pct * grown)), bm + p["OverRate"] * (cap - bm))
        if bonus_type in OVER_RATE_TYPES and m > bm:
            m = trunc_div(m - bm, p["OverRate"]) + bm
    return max(1, m)


def category_rate(new_props, exclusion=0):
    """GetPotentialRate / CalcUsePotentialPoint first loop: 1 + 0.05 * sum(n^2) over AbilityCategory groups n >= 2."""
    counts = {}
    for t, v in new_props:
        if t == 0 or t == exclusion:
            continue
        c = props(t, v)["AbilityCategory"]
        counts[c] = counts.get(c, 0) + 1
    r = 1.0
    for n in counts.values():
        if n >= 2:
            r = f32(r + f32(f32(n * n) * f32(0.05)))
    return r


def potential_cost(item_type, item_caps, changes, new_props, tec, master_caps=(), exclusion=0):
    """SmithGrant.CalcUsePotentialPoint. Values are real stat values (not steps).
    item_caps: {type: current value}; changes: [(type, delta)]; new_props: [(type, value)] after the change.
    Positive = potential consumed, negative = potential returned."""
    total = 0
    for t, delta in changes:
        if t == 0 or t == exclusion or delta == 0:
            continue
        base = base_potential(t, delta, item_type, master_caps)
        if t == ELEMENT:
            total += base
            continue
        p = BONUS[t]
        bm, orr = p["BaseMax"], p["OverRate"]
        old = item_caps.get(t, 0)
        new = old + delta
        if delta >= 0:
            a = min(-bm - old, delta) if -bm > old else 0
            b = min(new - bm, delta - a) if new > bm else 0
            total += base * ((delta - a - b) + trunc_div(a, orr) + 2 * trunc_div(b, orr))
        else:
            a = max(bm - old, delta) if bm < old else 0
            b = max(new + bm, delta - a) if new < -bm else 0
            steps = f32(f32(trunc_div(b, orr) * 0.5) + (delta - a - b) + trunc_div(a, orr))
            back = f32(f32(steps * base) * f32(f32(tec / 1000.0) + f32(0.05)))
            total += int(back)
    total = struct.unpack("<h", struct.pack("<H", total & 0xFFFF))[0]
    return int(f32(category_rate(new_props, exclusion) * total))


def success_skill(lv365=0, lv366=0, lv367=0):
    """SmithGrant.getSuccessSkillRate (0x1d7e4dc)."""
    return max(0, lv365) + (lv366 + 10 if lv366 > 0 else 0) + (lv367 + 20 if lv367 > 0 else 0)


def success_rate(item_pot, master_pot, use, lv365=0, lv366=0, lv367=0):
    """SmithGrant.OnGrantBeforeStartButton (0x1d7e1e0..0x1d7e28c): percentage shown in the warning window.
    Only shown when use > item_pot; the real roll is done by the server."""
    denom = max(item_pot, master_pot)
    s = f32(f32(-100.0 / denom) * f32((use - item_pot) * f32(2.3)))
    return max(0, int(f32(success_skill(lv365, lv366, lv367) + 100 + s)))


def slot_count(lv366=0, lv367=0):
    """SmithGrant.getUsableSlotCount (0x1d7baec)."""
    return math.floor(f32((lv366 + 2) * f32(0.3))) + 3 + math.floor(f32((lv367 + 4) * f32(0.2)))


def smith_level(blacksmith_raw, lv354, lv_cap, default_limit_raw):
    """ProficiencyManager.BlackSmithLimitLevel: raw values are level * 100."""
    limit = lv_cap * (5 * lv354 + 50) if lv354 > 0 else default_limit_raw
    return trunc_div(min(blacksmith_raw, limit), 100)


def require_num(coefficient, anvil_levels=0):
    """SmithGrantInfoWindow.CalcCoefficientMitigation: anvil_levels = sum of skills 355/356/357/368."""
    x = math.floor(f32(f32(f32(f32(100 - anvil_levels) / 100.0) * coefficient) * 10.0))
    return math.ceil(f32(x * f32(0.1)))


def understand(points, lv):
    """SmithGrantInfoWindow.CalcUnderstandSkill: -lv% (lv clamped to 100), skill picked by material type."""
    if lv < 1:
        return points
    return points - trunc_div(min(lv, 100) * points, 100)


def material_cost(bonus_type, fixed_value, delta_steps, smith_lv, anvil_levels=0, understand_lv=0, element=0):
    """SmithGrantInfoWindow.GetCurrentRequireMaterialPoint: material points for moving one stat by delta_steps
    from its current real value fixed_value. Each unit step between x and x+-1 costs Num * m^2 / 2 with
    m = max(|x|, |x+-1|), then the understanding skill, then the proficiency factor."""
    p = props(bonus_type, element)
    num = require_num(p["Coefficient"], anvil_levels)
    factor = f32(f32(100 - trunc_div(smith_lv, 10) - trunc_div(smith_lv, 50)) / 100.0)
    x = 0 if bonus_type == ELEMENT else to_steps(bonus_type, fixed_value)
    step = 1 if delta_steps > 0 else -1
    cost = 0
    for _ in range(abs(delta_steps)):
        m = max(abs(x), abs(x + step))
        raw = int(m * m * num * 0.5)
        cost += int(f32(factor * understand(raw, understand_lv)))
        x += step
    return cost


def demo():
    assert BONUS[1]["UsePotential"] == 5 and BONUS[1]["MaterialCategory"] == 2 and len(BONUS) == 67 and len(ELEM) == 6
    # step <-> value for flat ASPD (BaseMax 20, OverRate 16)
    assert from_steps(30, 22) == 52 and to_steps(30, 52) == 22 and to_steps(30, -52) == -22
    # caps: STR Lv200 full skills = 20; Lv300 -> 20 + 10 = 30; ATK% Lv300 (Rate 0.5) -> 10 + 5 = 15
    assert enhance_max(True, 1, 200, 10, 10, 10) == 20
    assert enhance_max(True, 1, 300, 10, 10, 10) == 30
    assert enhance_max(True, 18, 300, 10, 10, 10) == 15
    assert enhance_max(True, 1, 150) == 2 and enhance_max(True, 1, 150, 10) == 8
    assert enhance_max(True, 1, 150, 10, 10, 10) == 15
    # potential: STR +5 on a bow (5 pot/step) = 25; +25 on a 20-cap stat: 20*5 + 5*2*5 = 150
    assert potential_cost(12, {}, [(1, 5)], [(1, 5)], tec=0) == 25
    assert potential_cost(12, {}, [(1, 25)], [(1, 25)], tec=0) == 150
    # ATK% weapon DoubleUse=1 -> not doubled on a weapon, doubled on armor (type 20)
    assert potential_cost(10, {}, [(18, 1)], [(18, 1)], tec=0) == 10
    assert potential_cost(20, {}, [(18, 1)], [(18, 1)], tec=0) == 20
    # two stats in one category (STR, INT: cat 1) -> x(1 + 0.05*4) = 1.2
    assert potential_cost(10, {}, [(1, 1), (2, 1)], [(1, 1), (2, 1)], tec=0) == 12
    # negative stat returns (0.05 + TEC/1000) of its cost: DEX -10 (50 pot) with TEC 255 -> -15
    assert potential_cost(10, {}, [(5, -10)], [(5, -10)], tec=255) == -15
    # element: 100, 10 when it matches the master element
    assert potential_cost(10, {}, [(ELEMENT, 1)], [(ELEMENT, 1)], tec=0) == 100
    assert potential_cost(10, {}, [(ELEMENT, 1)], [(ELEMENT, 1)], tec=0, master_caps={(ELEMENT, 1)}) == 10
    # success: full skills (60) + 100 + 230 * remaining / base  -> 160 at 0 remaining, 0 at -69.6..
    assert success_skill(10, 10, 10) == 60
    assert success_rate(100, 100, 100, 10, 10, 10) == 160
    assert success_rate(100, 100, 130, 10, 10, 10) == 91
    assert success_rate(100, 100, 100) == 100
    assert slot_count() == 3 and slot_count(10, 10) == 8
    # materials: STR coef 50, no skills, prof 0 -> 1^2*25 + 2^2*25 = 125
    assert require_num(50) == 50 and require_num(50, 40) == 30
    assert material_cost(1, 0, 2, smith_lv=0) == 125
    assert material_cost(1, 0, 2, smith_lv=250) == 17 + 70
    assert material_cost(1, 2, -2, smith_lv=0) == 125
    assert smith_level(25000, 10, 320, 5000) == 250 and smith_level(9000, 0, 320, 5000) == 50
    print("ok")


if __name__ == "__main__":
    demo()
