"""Which learned skills / masteries move a Details row?  For every mastery of player_status/mastery_table.json (plus the plain skill-level reads: Conversion 867, Magic Skin 879,
Dual Mastery 641) learn it at its top level and compare all rows with the same character without it, over main weapon types x sub weapon types.
Also measures the weapon element (0 -> 8 Mana, 3 Wind) and the Cast Mastery active flag.
Output: player_status/mastery_reach.json = {"skills": {uid: {class, name, level, rows, mainTypes}}, "idle": [uids that move nothing], "element": {...}}
Run (cwd D:\\toram_re):  python "D:\\toram reverse data\\scripts\\measure_mastery_reach.py"
Label: Code (the same evaluator as the Details export); not checked in game.
"""
import sys, json

sys.path.insert(0, r"D:\toram reverse data\scripts")
sys.path.insert(0, r"D:\toram_re")
import player_status as P

OUT = r"D:\toram reverse data\player_status\mastery_reach.json"
MAIN = [0, 8, 9, 10, 11, 12, 13, 14, 15, 16, 18, 23]
SUB = [0, 8, 10, 15, 16, 17, 19, 23]          # 16 Knuckle and 23 NinjutsuScroll added 2026-10-03 (OneChance reads a knuckle sub weapon, WeaponInBothHands a scroll)
BODY = [0, 1, 2]          # ArmorAbility: 0 normal, 1 light, 2 heavy (the armour masteries gate on it)
EXTRA_SKILLS = {867: "Conversion", 879: "MagicSkin", 641: "DualMastery"}


_BASE = {}


def rows(main, sub, body, **kw):
    ch = P.Character(lv=200, str_=120, int_=120, vit=100, agi=120, dex=120, weapon=P.item(main, 200, 20, 9), sub=P.item(sub, 60, 5, 5), body=P.item(20, 200, 0, 9, body), **kw)
    res, _ = P.compute(ch)
    return [(r["type"], r["value"]) for r in res]


def moved(extra):
    out_rows, mains = set(), set()
    for m in MAIN:
        for s in SUB:
            for b in BODY:
                base = _BASE.get((m, s, b)) or _BASE.setdefault((m, s, b), rows(m, s, b))
                for (t, a), (_, c) in zip(base, rows(m, s, b, **extra)):
                    if a != c:
                        out_rows.add(t); mains.add(m)
    return sorted(out_rows), sorted(mains)


def main():
    res, idle = {}, []
    for uid, m in sorted(P.MASTERY_TABLE.items(), key=lambda kv: int(kv[0])):
        lv = m["maxLv"]          # the top level (2026-10-03: the old cap of 10 hid every table that is 0 below its first step, e.g. DefUp max 20)
        r, mains = moved({"skills": {int(uid): lv}})
        res[uid] = {"class": m["class"], "name": m["name"], "level": lv, "rows": r, "mainTypes": mains}
        if not r:
            idle.append(int(uid))
    for uid, nm in EXTRA_SKILLS.items():
        r, mains = moved({"skills": {uid: 10}})
        res.setdefault(str(uid), {"class": nm, "name": "", "level": 10})["skillLevelRows"] = r
    elem = {str(e): moved({"weapon_element": e})[0] for e in (3, 8)}
    sub_elem = {str(e): moved({"sub_element": e})[0] for e in (8,)}
    cast = moved({"skills": {1033: 15, 1025: 10, 1026: 10}, "cast_active": 1})[0]
    json.dump({"skills": res, "idle": idle, "weaponElement": elem, "subElement": sub_elem, "castMasteryActive": cast}, open(OUT, "w", encoding="utf-8"), ensure_ascii=False, indent=1)
    moving = [u for u, v in res.items() if v.get("rows")]
    print(f"{len(res)} masteries measured, {len(moving)} move a row, {len(idle)} move nothing")
    print("weapon element:", elem, " sub:", sub_elem, " cast:", cast)
    print("extra skill-level reads:", {u: res[str(u)].get("skillLevelRows") for u in EXTRA_SKILLS})


if __name__ == "__main__":
    main()
