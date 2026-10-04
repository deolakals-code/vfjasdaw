import csv, os, re, struct, sys
import UnityPy
HERE = os.path.dirname(os.path.abspath(__file__))
sys.path.insert(0, HERE)
from decode import decode
from parse_text import varint
from cache import newest

GAME = r"D:\SteamLibrary\steamapps\common\Toram Online\ToramOnline_Data"
OUT = os.path.join(os.path.dirname(HERE), "items")
REC = 37


def latest_assets(bundle):
    data = newest(bundle)
    h = int(os.path.basename(os.path.dirname(data))[-8:], 16)
    return {ta.m_Name: decode(ta.m_Script.encode("utf-8", "surrogateescape"), h)
            for ta in (o.read() for o in UnityPy.load(data).objects if o.type.name == "TextAsset")}


def parse_text(b):
    count = struct.unpack_from("<I", b)[0]
    i, out = 4, {}
    for _ in range(count):
        tid, kind = struct.unpack_from("<IB", b, i); i += 5
        n, i = varint(b, i)
        out.setdefault(tid, {}).setdefault(kind, []).append(b[i:i + n].decode("utf-8")); i += n
    assert i == len(b), (i, len(b))
    return out


def enum(name):
    out = {}
    for line in open(os.path.join(os.path.dirname(HERE), "metadata", "constants.tsv"), encoding="utf-8"):
        cls, key, _, val = line.rstrip("\n").split("\t")
        if cls == name:
            out.setdefault(int(val), key)
    return out


def icon_sprites():
    # NGUI UIAtlas raw layout: header(32) + name + material pptr(12), then <i count> x {string, 12 x i32}
    env = UnityPy.load(os.path.join(GAME, "sharedassets0.assets"))
    tex = next(o.read() for o in env.objects if o.type.name == "Texture2D" and o.read().m_Name == "UIIconAtlasTexture")
    for o in env.objects:
        if o.type.name != "MonoBehaviour":
            continue
        raw = o.get_raw_data()
        i = 32 + struct.unpack_from("<i", raw, 28)[0]
        i += (-i) % 4 + 12
        try:
            count = struct.unpack_from("<i", raw, i)[0]; i += 4
            sprites = {}
            for _ in range(count):
                n = struct.unpack_from("<i", raw, i)[0]; i += 4
                name = raw[i:i + n].decode("utf-8"); i += n + (-(i + n)) % 4
                sprites[name] = struct.unpack_from("<4i", raw, i); i += 48
        except (struct.error, UnicodeDecodeError):
            continue
        if "it_1" in sprites:
            return tex.image, sprites
    raise RuntimeError("icon atlas not found")


# Consumable effect ids (BonusType 200+) have no UI text; wording ours, each checked against item descriptions
EFFECT_TH = {201: "ฟื้นฟู HP {0}", 202: "ฟื้นฟู HP {0}%", 204: "ฟื้นฟู MP {0}", 209: "ฟื้นฟู HP ต่อเนื่อง {0} วินาที",
             230: "ทุก {0} วินาที", 244: "วาร์ป (map id {0})", 245: "สุ่มได้ไอเทม (กล่อง id {0})",
             246: "เรียนสกิล (id {0})"}


def parse_props(masters, prop_text):
    # ItemProperty_th: <I count> then <I id><varint len><utf8>, a format string like "STR+{0}"
    count = struct.unpack_from("<I", prop_text)[0]
    i, fmt = 4, {}
    for _ in range(count):
        pid = struct.unpack_from("<i", prop_text, i)[0]; i += 4
        n, i = varint(prop_text, i)
        fmt[pid] = prop_text[i:i + n].decode("utf-8"); i += n
    # ItemProperties: <I count> then count x (i32 item id + 10 x (u16 prop id, i16 value))
    b = masters["ItemProperties"]
    count = struct.unpack_from("<I", b)[0]
    assert 4 + count * 44 == len(b)
    bonus = enum("Toram.Common.Bonus.BonusType")
    elements = {1: "ไฟ", 2: "น้ำ", 3: "ลม", 4: "ดิน", 5: "แสง", 6: "มืด"}  # ElementType, checked against element-advantage stats

    def line(pid, v):
        if pid == 65:
            return "ธาตุ" + elements.get(v, str(v))
        if v < 0 and -pid in fmt:  # negative ids hold the "decrease" wording
            return fmt[-pid].replace("{0}", str(-v))
        if pid in fmt:
            return fmt[pid].replace("{0}", str(v)).replace("+-", "-")
        name = bonus.get(pid, f"#{pid}")
        if pid in EFFECT_TH:
            return f"{EFFECT_TH[pid].format(v)} [{name}]"
        if name.startswith("runn_"):  # timed buff: value is the duration
            return f"ระยะเวลา {v} วินาที [{name}]"
        return f"{name}={v}"

    out = {}
    for k in range(count):
        rec = b[4 + k * 44: 4 + (k + 1) * 44]
        out[struct.unpack_from("<i", rec)[0]] = [line(pid, v) for pid, v in struct.iter_unpack("<Hh", rec[4:]) if pid]
    return out


def parse_system(b):
    # System_th: <I count> then <varint len><key><varint len><text>
    count = struct.unpack_from("<I", b)[0]
    i, out = 4, {}
    for _ in range(count):
        n, i = varint(b, i); key = b[i:i + n].decode("utf-8"); i += n
        n, i = varint(b, i); out[key] = b[i:i + n].decode("utf-8"); i += n
    return out


def ui_text(s):
    return re.sub(r"\[[0-9a-fA-F]{6}\]", "", s.replace("\\n", "\n").replace("　", " ")).strip()


WEAPONS = set(range(7, 20)) | {23}
DEF_GEAR = {20, 21, 22}


def tooltip(system, type_id, desc, stats, base, stability, stack, flag):
    # rebuilds the in-game item panel from System_th ItemPanel* templates; verified against a crysta tooltip only
    tname = system.get(f"ItemlType{type_id}", "")
    lines = []
    if type_id in WEAPONS:
        lines.append(ui_text(system["ItemPanelPropertyATKEquip"].format(tname, base, stability)))
    elif type_id in DEF_GEAR:
        lines.append(ui_text(system["ItemPanelPropertyDEFEquip"].format(tname, base)))
    lines += [desc] + [s for s in stats.split("\n") if not s.startswith("#")]  # "#id=v" effects have no UI text
    if f"ItemPanelPropertyMaxCrista{type_id}" in system:
        lines.append(ui_text(system[f"ItemPanelPropertyMaxCrista{type_id}"].format(stack)))
    else:
        if type_id == 3:
            lines.append(ui_text(system["ItemPanelPropertyMaterialItem"]))
        elif type_id in (1, 2):
            lines.append(ui_text(system["ItemPanelPropertyUseItem"]))
        if stack > 1:
            lines.append(ui_text(system["ItemPanelPropertyMax"].format(stack)))
    lines.append(" ".join(ui_text(system[k]) for bit, k in ((4, "ItemPanelPropertyTrade"), (1, "ItemPanelPropertyBuy")) if flag & bit))
    return "\n".join(l for l in lines if l) or (tname and f"[{tname}]")


# ItemMaster record = ItemDBData.CreateItemData read order (libil2cpp 0x21309D4): every one of the 37 bytes is named.
ITEM = struct.Struct("<4iBBhhhBBBhii")
ITEM_FIELDS = ("id", "sort_id", "type_id", "price", "material_lv", "material_id", "process", "stack", "function", "stable",
               "range", "slot_max", "potential", "model", "flag")
LANGS = ("us", "jp", "kr", "cnt", "idn")
# ShopUtil.GetLocalizedMaterialName (0x1D73474) indexes this array by MaterialId; System_th keys in the same order
MATERIAL_KEYS = ("MetelItem", "ClothItem", "BeastItem", "WoodItem", "MedicineItem", "MagicItem")
MATERIAL_EN = ("Metal", "Cloth", "Beast", "Wood", "Medicine", "Mana")
# ItemDBData.CheckUseItem / UIItemListManager.CheckUseItem (0x2130EB4 / 0x1E5E7B4): the bag "Use" button exists only for
# type < 3 (Null/Heales/Consumption), 5 TreasureBox, 30 Unlock (emotes), 50 UniqueItem. ItemDBData.CheckEquipItem (0x2130E44): 7..27.
can_use = lambda t: t < 3 or t in (5, 30, 50)
can_equip = lambda t: 7 <= t <= 27
# Orb-shop goods (2000xxx ids, types 52-54/100-103/200) are server-fed OrbItemData consumed through the orb panel (OrbItemUse op);
# the client has no per-type list of it, so this channel is Inferred from the type names
ORB_TYPES = {52, 53, 54, 100, 101, 102, 103, 200}


def use_kind(type_id, cap1):
    # ItemData.IsWarpItem (0x21307F0) = type 2 and CapId1 == 244; OnUseItem routes CapId1 == 246 to the skill-book popup
    if not can_use(type_id):
        return ""
    return {5: "box", 30: "unlock", 50: "unique"}.get(type_id) or (
        "warp" if type_id == 2 and cap1 == 244 else "skill_book" if cap1 == 246 else "heal" if type_id == 1 else "consume")


# UIItemBagManager.OnUseItem: FieldRoomType GuildRaid (29) and ScoreAttack (40) refuse warp items
USE_NOTE = {"warp": "refused in Guild Raid and Score Attack rooms", "skill_book": "refused when the skill tree is already learned",
            "box": "bulk open (all / 10 / 99) when stacked"}


def cap1_table(masters):
    b = masters["ItemProperties"]
    return {struct.unpack_from("<i", b, 4 + k * 44)[0]: struct.unpack_from("<H", b, 8 + k * 44)[0]
            for k in range(struct.unpack_from("<I", b)[0])}


def parse_recipes(masters):
    # RecipeDBData (dump.cs 8521): <i RecipeId><B Type><h ReleaseLv><i Price><h Difficulty><i CreateId><h CreateVal><B Category>
    # + <I n> + n x RecipeMaterialData <B RecipeNo><B Lv><i Id><h Val>. Lv 0 = item id, Lv 1 = material point type (MaterialId index).
    b, i, out = masters["RecipeMaster"], 4, []
    for _ in range(struct.unpack_from("<I", b)[0]):
        rid, typ, rel, price, diff, cid, cval, cat = struct.unpack_from("<iBhihihB", b, i)
        n = struct.unpack_from("<I", b, i + 20)[0]
        mats = [struct.unpack_from("<BBih", b, i + 24 + 8 * k) for k in range(n)]
        out.append(dict(recipe_id=rid, type=("Smith", "Synthetic", "Recreate", "CollectSlot")[typ], release_lv=rel, price=price,
                        difficulty=diff, create_id=cid, create_num=cval, category=cat, materials=mats))
        i += 24 + 8 * n
    assert i == len(b), (i, len(b))
    return out


def main():
    import json
    from collections import defaultdict
    from export_models import PREFIX
    from export_quests import parse_plain
    scene = latest_assets("GameScene_th")
    system = parse_system(scene["System_th"])
    masters = latest_assets("BynaryData")
    texts = parse_text(scene["Item_th"])
    props = parse_props(masters, scene["ItemProperty_th"])
    cap1 = cap1_table(masters)
    lang = {l: latest_assets(f"GameScene_{l}") for l in LANGS}
    ltext = {l: parse_text(lang[l][f"Item_{l}"]) for l in LANGS}
    avatar_cat = parse_system(scene["AvatarEquip_th"])
    master = masters["ItemMaster"]
    types = {**enum("ItemDBData/ItemType"), **enum("Toram.Common.Items.ItemType")}  # the second enum names 4 HolyGem, 5 TreasureBox, 51..54
    flags = enum("ItemDBData/ItemFlag")
    atlas, sprites = icon_sprites()

    os.makedirs(os.path.join(OUT, "icons"), exist_ok=True)
    for name, (x, y, w, h) in sprites.items():
        if name.startswith("it_"):
            atlas.crop((x, y, x + w, y + h)).save(os.path.join(OUT, "icons", name + ".png"))

    count = struct.unpack_from("<I", master)[0]
    assert 4 + count * ITEM.size == len(master)
    rows = [dict(zip(ITEM_FIELDS, ITEM.unpack_from(master, 4 + k * ITEM.size))) for k in range(count)]
    ids = {r["id"] for r in rows}

    # cross references
    recipes = parse_recipes(masters)
    made, used = defaultdict(list), defaultdict(list)
    for rc in recipes:
        if rc["type"] in ("Smith", "Synthetic"):  # Recreate CreateId is another id space (317 of 330 are not item ids)
            made[rc["create_id"]].append(rc["recipe_id"])
        for _, lv, mid, _ in rc["materials"]:
            if lv == 0:
                used[mid].append(rc["recipe_id"])
    dropped = defaultdict(set)
    for r in json.load(open(os.path.join(OUT, "..", "monsters", "monsters.json"), encoding="utf-8")):
        for d in r["drops"]:
            dropped[d["item"]].add(r["uuid"])
    db = masters["ItemDorpData"]
    hints = defaultdict(int)
    for k in range(struct.unpack_from("<I", db)[0]):
        hints[struct.unpack_from("<I", db, 4 + 13 * k)[0]] += 1
    shops, shop_items = defaultdict(set), ("Item", "OrbItem")
    for sh in json.load(open(os.path.join(OUT, "event_shops.json"), encoding="utf-8")):
        for e in sh["entries"]:
            if e["type"] in shop_items:
                shops[e["value"]].add(sh["shop"])
    nb = masters["NGItem"]
    ng = {struct.unpack_from("<i", nb, 4 + 4 * k)[0] for k in range(struct.unpack_from("<I", nb)[0])}

    # items.csv
    cols = ["id", "sort_id", "type_id", "type", "type_th", "name", "name_en", "name_jp", "name_kr", "name_cnt", "name_idn",
            "description", "description_en", "can_use", "use_kind", "use_note", "use_channel", "can_equip", "auto_potion", "price", "stack",
            "base_atk_def", "stability", "range", "slot_max", "potential", "material_type", "material_points", "processable",
            "avatar_category", "avatar_category_name", "stats", "tooltip", "flag", "flags", "icon_or_model_id", "icon", "model", "preview",
            "recipes_making", "recipes_using", "dropped_by_mobs", "drop_hints", "event_shops", "ng_item", "in_item_master"]
    text_only = sorted(set(texts) - ids)  # names exist in Item_th but ItemMaster has no record (type/price unknown)
    rows += [dict.fromkeys(ITEM_FIELDS, 0) | {"id": i, "type_id": -1} for i in text_only]
    with open(os.path.join(OUT, "items.csv"), "w", encoding="utf-8-sig", newline="") as f:
        w = csv.DictWriter(f, fieldnames=cols)
        w.writeheader()
        for r in rows:
            iid, t, flag = r["id"], r["type_id"], r["flag"]
            in_master = iid in ids
            tx = texts.get(iid, {})
            desc, stats = "\n".join(tx.get(1, [])), "\n".join(props.get(iid, []))
            # equipment/crysta types use the per-type `_0` icon (Model is a model id there); others store an icon id in Model
            icon_ok = t not in (27, 30)  # AvatarOption/Unlock: Model is a model/emote id, not an icon
            icon = next((n for n in (f"it_{t}_0", f"it_{t:02d}_0", icon_ok and r["model"] and f"it_{r['model']}", f"it_{t}") if n in sprites), "")
            mat = r["material_id"] if r["material_lv"] else None
            cat = (r["range"] << 8 | r["slot_max"]) if t in (25, 26, 27) else None  # ItemDBData.AvatarCategory
            kind = use_kind(t, cap1.get(iid, 0)) if in_master else ""
            mname = f"{PREFIX[t]}{r['model']}" if t in PREFIX and r["model"] else ""  # same link rule as export_models.py
            has_model = mname and os.path.exists(os.path.join(OUT, "models", mname + ".obj"))
            w.writerow({
                "id": iid, "sort_id": r["sort_id"], "type_id": t, "type": types.get(t, f"Type{t}" if in_master else ""),
                "type_th": system.get(f"ItemlType{t}", ""), "name": "\n".join(tx.get(0, [])),
                **{f"name_{'en' if l == 'us' else l}": "\n".join(ltext[l].get(iid, {}).get(0, [])) for l in LANGS},
                "description": desc, "description_en": "\n".join(ltext["us"].get(iid, {}).get(1, [])),
                "can_use": ("yes" if can_use(t) else "no") if in_master else "unknown", "use_kind": kind, "use_note": USE_NOTE.get(kind, ""),
                "use_channel": ("bag" if can_use(t) else "equip" if can_equip(t) else "orb_panel (inferred)" if t in ORB_TYPES else "none") if in_master else "unknown",
                "can_equip": ("yes" if can_equip(t) else "no") if in_master else "unknown", "auto_potion": int(bool(flag & 256)),
                "price": r["price"], "stack": r["stack"], "base_atk_def": r["function"], "stability": r["stable"], "range": r["range"],
                "slot_max": r["slot_max"], "potential": r["potential"],
                "material_type": f"{MATERIAL_EN[mat]}/{system.get(MATERIAL_KEYS[mat], '')}" if mat is not None and mat < 6 else "",
                "material_points": r["process"] if r["material_lv"] else "", "processable": r["material_lv"],
                "avatar_category": "" if cat is None else cat, "avatar_category_name": avatar_cat.get(f"AvatarCategory{cat}", "") if cat is not None else "",
                "stats": stats, "tooltip": tooltip(system, t, ui_text(desc), stats, r["function"], r["stable"], r["stack"], flag) if in_master else "",
                "flag": flag, "flags": "|".join(v for b, v in flags.items() if b and flag & b == b), "icon_or_model_id": r["model"],
                "icon": icon and f"icons/{icon}.png",
                "model": f"models/{mname}.obj" if has_model else "", "preview": f"previews/{mname}.png" if has_model and os.path.exists(os.path.join(OUT, "previews", mname + ".png")) else "",
                "recipes_making": " ".join(map(str, made.get(iid, []))), "recipes_using": len(used.get(iid, [])),
                "dropped_by_mobs": len(dropped.get(iid, ())), "drop_hints": hints.get(iid, 0),
                "event_shops": " ".join(map(str, sorted(shops.get(iid, [])))), "ng_item": int(iid in ng), "in_item_master": int(in_master)})
    print(count, "items +", len(text_only), "text-only ids,", sum(n.startswith("it_") for n in sprites), "icons ->", OUT)

    # item_recipes.csv: every RecipeMaster row with the item names resolved
    name = {r["id"]: "\n".join(texts.get(r["id"], {}).get(0, [])) for r in rows}
    with open(os.path.join(OUT, "item_recipes.csv"), "w", encoding="utf-8-sig", newline="") as f:
        w = csv.writer(f)
        w.writerow(["recipe_id", "type", "release_lv", "price", "difficulty", "category", "create_id", "create_name", "create_num", "materials"])
        for rc in recipes:
            cn = name.get(rc["create_id"], "") if rc["type"] != "Recreate" else ""
            mats = "; ".join(f"{name.get(m, '?')}#{m} x{v}" if lv == 0 else f"{MATERIAL_EN[m]} {v}pt" for _, lv, m, v in rc["materials"])
            w.writerow([rc["recipe_id"], rc["type"], rc["release_lv"], rc["price"], rc["difficulty"], rc["category"], rc["create_id"],
                        cn, rc["create_num"], mats])
    print(len(recipes), "recipes -> item_recipes.csv")

    # house_items.csv: furniture catalog (HouseItem_<lang>), a separate id space from ItemMaster
    hl = {l: parse_plain(latest_assets(f"GameScene_{l}")[f"HouseItem_{l}"]) for l in ("th",) + LANGS}
    with open(os.path.join(OUT, "house_items.csv"), "w", encoding="utf-8-sig", newline="") as f:
        w = csv.writer(f)
        w.writerow(["id", "in_item_master", *[f"name_{'en' if l == 'us' else l}" for l in hl]])
        for hid in sorted(hl["th"]):
            w.writerow([hid, int(hid in ids), *[hl[l].get(hid, "") for l in hl]])
    print(len(hl["th"]), "house items -> house_items.csv")

    # items_missing.csv: every item id the client references that items.csv could not describe fully
    refs = defaultdict(set)
    for i in text_only:
        refs[i].add("Item_th text without ItemMaster record")
    for i in ids - set(texts):
        refs[i].add("ItemMaster record without Item_th text")
    for src, found in (("mob drop table", dropped), ("ItemDorpData", hints), ("event shop", shops), ("recipe material", used),
                       ("recipe product", made)):
        for i in found:
            if i not in ids:
                refs[i].add(src)
    for b in json.load(open(os.path.join(OUT, "..", "monsters", "high_raid.json"), encoding="utf-8"))["bosses"]:
        for rw in b["rewards"]:
            if rw["type"] in shop_items + ("Material",) and rw["value"] not in ids:
                refs[rw["value"]].add("high raid reward")
    with open(os.path.join(OUT, "items_missing.csv"), "w", encoding="utf-8-sig", newline="") as f:
        w = csv.writer(f)
        w.writerow(["id", "problem", "name_th", "name_en", "can_use"])
        for i in sorted(refs):
            w.writerow([i, " | ".join(sorted(refs[i])), "\n".join(texts.get(i, {}).get(0, [])), "\n".join(ltext["us"].get(i, {}).get(0, [])),
                        "unknown" if i not in ids else "see items.csv"])
    print(len(refs), "ids with a completeness problem -> items_missing.csv")


if __name__ == "__main__":
    main()
