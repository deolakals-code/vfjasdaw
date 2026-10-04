"""Gear catalogue for the character stats calculator: every equippable item and crysta with its stat lines as (BonusType, value) pairs.

Source: ItemMaster / ItemProperties (BynaryData), names and icons from items/items.csv (written by export_items.py), Thai labels of bonus names from
skills/damage/variables.json (`gloss_th`), Limit marker wording from ItemProperty_th / ItemProperty_us.

Run (cwd D:\\toram_re, Bash):  python "D:\\toram reverse data\\scripts\\export_gear.py" [--selftest]
Writes D:\\toram reverse data\\gear\\gear.json

gear.json = { "items": [Item], "bonuses": [{k, th, id}], "limitRules": {marker: rule}, "bonusById": {id: name} }
Item = { id, type, typeName, slot: weapon|sub|body|option|special|crysta, slots: [..], crystaKind?, tier?, name:{th,en}, icon,
         atk, stable, slotMax, lines: [ {b, v} | {limit} ] }
Label: Code (ItemProperties / BonusType), the Limit rules are Inferred from the in-game wording (see NOTES.md "Item stat lines: Limit markers").
"""
import os, sys, re, csv, json, struct

HERE = os.path.dirname(os.path.abspath(__file__))
sys.path.insert(0, HERE)
sys.path.insert(0, r"D:\toram_re")
import export_items as X

ROOT = r"D:\toram reverse data"
OUT = os.path.join(ROOT, "gear")
csv.field_size_limit(10 ** 9)

# BonusType ids that are conditions of the lines that follow them (ItemProperty text "With X:")
LIMIT_IDS = {96, 97, 98, 99, 100, 101, 102, 103, 108, 109, 114, 115, 116, 117, 118, 119, 120, 193}
LIMIT_RULES = {
    "bNinjutsuScrollLimit": {"any": [23]}, "b1handLimit": {"any": [10]}, "b2handLimit": {"any": [11]}, "bBowLimit": {"any": [12]},
    "bGunLimit": {"any": [13]}, "bRodLimit": {"any": [14]}, "bMagictoolLimit": {"any": [15]}, "bKnuckleLimit": {"any": [16]},
    "bDualswordLimit": {"both": [10]}, "bShieldLimit": {"any": [17]}, "bPoleweaponLimit": {"any": [9]}, "bKatanaLimit": {"any": [8]},
    "bArrowLimit": {"any": [19]}, "bKnifeLimit": {"any": [18]}, "bLightArmorLimit": {"armour": 1}, "bHeavyArmorLimit": {"armour": 2},
    "bEventCheck": {"off": True}, "bDamageLimit": {"unknown": True},
}
# main / sub weapon slots by ItemType (ItemDBData.ItemType); the client's SetEquip jump table is not decoded, so this is the game's own rule of thumb:
# one-handed swords can be dual-wielded, magic tools and knuckles go either way, shield / dagger / arrow / ninjutsu scroll are sub-only
MAIN_TYPES = {7, 8, 9, 10, 11, 12, 13, 14, 15, 16}
SUB_TYPES = {10, 15, 16, 17, 18, 19, 23}
CRYSTA_KIND = [("NormalBlue", "normal"), ("WeaponRed", "weapon"), ("ArmorGreen", "armor"), ("AddEquipYellow", "option"), ("SpecialPurple", "special")]


def props_by_item(masters):
    b = masters["ItemProperties"]
    n = struct.unpack_from("<I", b)[0]
    out = {}
    for k in range(n):
        rec = b[4 + k * 44: 4 + (k + 1) * 44]
        out[struct.unpack_from("<i", rec)[0]] = [(p, v) for p, v in struct.iter_unpack("<Hh", rec[4:]) if p]
    return out


def classify(typ):
    if "Crista" in typ:
        tier = "powerup" if typ.startswith("PowerUp") else "normal"
        kind = next((k for key, k in CRYSTA_KIND if key in typ), None)
        if kind is None:
            m = re.match(r"PowerUp(\w+)Crista", typ)
            kind = {"Normal": "normal", "Weapon": "weapon", "Armor": "armor", "AddEquip": "option", "Special": "special"}.get(m.group(1) if m else "", None)
        return "crysta", tier, kind
    return None, None, None


def main():
    masters = X.latest_assets("BynaryData")
    bonus = X.enum("Toram.Common.Bonus.BonusType")
    props = props_by_item(masters)
    gloss = json.load(open(os.path.join(ROOT, "skills", "damage", "variables.json"), encoding="utf-8"))["vars"]
    rows = list(csv.DictReader(open(os.path.join(ROOT, "items", "items.csv"), encoding="utf-8-sig")))
    types_of = {"Warhammer": 7, "Katana": 8, "Halberd": 9, "OneHandSword": 10, "TwoHandSword": 11, "Bow": 12, "Bowgun": 13, "Rod": 14, "Magictool": 15,
                "Knuckle": 16, "Shield": 17, "ShortSword": 18, "Arrow": 19, "NinjutsuBook": 23}
    items = []
    for r in rows:
        typ, tid = r["type"], int(r["type_id"] or 0)
        if r["in_item_master"] != "1":
            continue
        slot = tier = kind = None
        slots = []
        if typ in types_of:
            slots = (["weapon"] if tid in MAIN_TYPES else []) + (["sub"] if tid in SUB_TYPES else [])
            slot = slots[0]
        elif typ == "Armors":
            slot, slots = "body", ["body"]
        elif typ == "AddEquip":
            slot, slots = "option", ["option"]
        elif typ == "SpecialEquip":
            slot, slots = "special", ["special"]
        else:
            slot, tier, kind = classify(typ)
            if slot:
                slots = ["crysta"]
        if not slot:
            continue
        lines = []
        for pid, v in props.get(int(r["id"]), []):
            name = bonus.get(pid, f"#{pid}")
            lines.append({"limit": name} if pid in LIMIT_IDS else {"b": name, "v": v})
        it = {"id": int(r["id"]), "type": tid, "typeName": typ, "slot": slot, "slots": slots,
              "name": {"th": r["name"], "en": r["name_en"]}, "icon": r["icon"],
              "atk": int(r["base_atk_def"] or 0), "stable": int(r["stability"] or 0), "slotMax": int(r["slot_max"] or 0), "lines": lines}
        if tier:
            it["tier"], it["crystaKind"] = tier, kind
        items.append(it)
    used = {l["b"] for it in items for l in it["lines"] if "b" in l}
    bonuses = []
    for name in sorted(used):
        g = (gloss.get(f"BonusType.{name}") or {}).get("gloss_th") or ""
        bonuses.append({"k": name, "th": re.sub(r"\s*\(id \d+[^)]*\)", "", g) or None})
    os.makedirs(OUT, exist_ok=True)
    out = {"items": items, "bonuses": bonuses, "limitRules": LIMIT_RULES, "bonusById": {str(k): v for k, v in bonus.items()}}
    json.dump(out, open(os.path.join(OUT, "gear.json"), "w", encoding="utf-8"), ensure_ascii=False, separators=(",", ":"))
    print(f"items {len(items)}  bonuses {len(bonuses)}  size {os.path.getsize(os.path.join(OUT, 'gear.json')) // 1024} KB")
    selftest(out, rows, masters)


def selftest(gear, rows=None, masters=None):
    by = {i["id"]: i for i in gear["items"]}
    # expectations from the data read at the time of writing (item 9617 tooltip, item 11001, item 21001)
    assert by[9617]["lines"] == [{"b": "bLongRange", "v": 4}, {"b": "bFirstAttackRate", "v": 4}, {"b": "bHateRate", "v": -20},
                                 {"limit": "bRodLimit"}, {"b": "bMatkRate", "v": 6}], by[9617]["lines"]
    assert by[11001]["lines"] == [{"b": "bCritical", "v": 5}] and by[11001]["slot"] == "weapon"
    assert by[21001]["slot"] == "option" and by[21001]["lines"][0]["b"] == "bAtkMpRecovery"
    assert by[9617]["slot"] == "crysta" and by[9617]["crystaKind"] == "weapon" and by[9617]["tier"] == "normal"
    assert by[9604]["tier"] == "powerup" and by[9604]["crystaKind"] == "weapon"
    n = {s: sum(1 for i in gear["items"] if i["slot"] == s) for s in ("weapon", "body", "option", "special", "crysta")}
    assert n["weapon"] > 1000 and n["body"] > 100 and n["option"] > 500 and n["special"] > 100 and n["crysta"] > 400, n
    # every limit marker the lines use has a rule
    marks = {l["limit"] for i in gear["items"] for l in i["lines"] if "limit" in l}
    assert marks <= set(gear["limitRules"]), marks - set(gear["limitRules"])
    # one text line per (BonusType, value) pair: the line count of items.csv `stats` equals the number of entries kept
    if rows is not None:
        bad = []
        for r in rows:
            it = by.get(int(r["id"]))
            if not it or not r["stats"]:
                continue
            want = [x for x in r["stats"].splitlines() if x and not x.startswith("#")]
            if len(want) != len(it["lines"]):
                bad.append((it["id"], len(want), len(it["lines"])))
        assert len(bad) < 10, (len(bad), bad[:5])
        print(f"line-count check: {len(bad)} differing items of {len(gear['items'])}")
    print("selftest ok -", len(gear["items"]), "items")


if __name__ == "__main__":
    if "--selftest" in sys.argv:
        selftest(json.load(open(os.path.join(OUT, "gear.json"), encoding="utf-8")))
    else:
        main()
