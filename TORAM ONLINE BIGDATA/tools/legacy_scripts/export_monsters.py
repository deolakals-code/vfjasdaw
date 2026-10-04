"""Monsters: per-map spawn records from FieldScript mob_<map>, drops, names, and cached Mob_<model> meshes.
Writes monsters/monsters.json|csv, monsters/models/<model>/*.obj|mtl|png. Layout notes in NOTES.md (Monsters)."""
import csv, json, os, re, statistics, struct, sys
import numpy as np
import UnityPy
HERE = os.path.dirname(os.path.abspath(__file__))
sys.path.insert(0, HERE)
from decode import decode
from export_items import latest_assets, enum
from export_quests import latest, text_assets, parse_plain, master

BASE = os.path.dirname(HERE)
OUT = os.path.join(BASE, "monsters")
# per file version: action pattern size, then fixed-size lists (ex patterns, modes?, properties)
LAYOUT = {0: (54, [5, 35]), -1: (54, [5, 35]), -2: (54, [5, 35, 23]), -3: (56, [5, 35, 23]), -4: (58, [5, 35, 23])}
FIXED = ["lv", "exp", "hp", "proration_normal", "proration_physical", "proration_magic", "necessary_hit", "def", "mdef",
         "resist_physical", "resist_magic", "guard", "avoid", "flag", "element", "model", "size"]


# MobModeData (dump.cs TypeDefIndex 964), 35 bytes. trigger decoded with HyperModeTrigger (name match; HpRate values
# are 50/80-style percentages). target = record id in the same mob_ file (7998/8013 resolve).
MODE_FIELDS = ["mode_id", "trigger", "value", "target", "aura_model", "aura_motion", "aura_color", "ignition_model",
               "ignition_motion", "ignition_color", "flag", "combo"]


def parse_mobs(b):
    ver, fid, cnt = struct.unpack_from("<iII", b)
    i = 12
    if ver >= 0:  # oldest files have no version field: <I map><I count>
        (ver, fid, cnt), i = (0,) + struct.unpack_from("<II", b), 8
    P, lists = LAYOUT[ver]
    recs = []
    for _ in range(cnt):
        rid, uuid, room, L = struct.unpack_from("<IIBB", b, i)
        j = i + 10 + L
        r = {"id": rid, "uuid": uuid, "room": room, "name_jp": b[i + 10:j].decode("utf-8").strip()}
        r.update(zip(FIXED, struct.unpack_from("<HIIBBBHHHhhHHIBiB", b, j)))
        r["scale"] = struct.unpack_from("<H", b, j + 37)[0]
        r["colors"] = [b[j + 39 + 4 * k:j + 43 + 4 * k].hex() for k in range(3)]
        r["move_speed"], r["raw_52_55"] = b[j + 51], b[j + 52:j + 56].hex()
        n = struct.unpack_from("<I", b, j + 56)[0]
        q = j + 60
        # action pattern entries (AI) are not decoded; raw bytes only
        r["actions_raw"] = [b[q + P * t:q + P * (t + 1)].hex() for t in range(n)]
        q += P * n
        parts = []
        for size in lists:
            k = struct.unpack_from("<I", b, q)[0]; q += 4
            parts.append([b[q + size * t:q + size * (t + 1)] for t in range(k)]); q += size * k
        r["ex_actions"] = [struct.unpack_from("<BI", e) for e in parts[0]]
        r["modes_raw"] = [e.hex() for e in parts[1]]
        r["modes"] = [dict(zip(MODE_FIELDS, struct.unpack("<BhiiiBiiBiih", e))) for e in parts[1]]
        r["properties"] = [{"type": struct.unpack_from("<H", e, 1)[0], "values": list(struct.unpack_from("<5i", e, 3))}
                           for e in (parts[2] if len(parts) > 2 else [])]
        recs.append(r)
        i = q
    drops = {}
    if i == len(b):  # some files (all version-less ones) carry no drop table
        return ver, fid, recs, drops
    n = struct.unpack_from("<I", b, i)[0]; i += 4
    for _ in range(n):
        mid, k = struct.unpack_from("<II", b, i); i += 8
        drops[mid] = [struct.unpack_from("<Ii", b, i + 8 * t) for t in range(k)]; i += 8 * k
    assert i == len(b), (i, len(b))
    return ver, fid, recs, drops


def export_model(model, data, out):
    h = int(os.path.basename(os.path.dirname(data))[-8:], 16)
    files = []
    for outer in (o.read() for o in UnityPy.load(data).objects if o.type.name == "TextAsset"):
        env = UnityPy.load(decode(outer.m_Script.encode("utf-8", "surrogateescape"), h))
        os.makedirs(out, exist_ok=True)
        mats, done = {}, set()
        for o in env.objects:
            if o.type.name == "Material":
                m = o.read()
                tex = next((v.m_Texture for k, v in m.m_SavedProperties.m_TexEnvs if k == "_MainTex" and v.m_Texture.path_id), None)
                if tex:
                    t = tex.read(); t.image.save(os.path.join(out, t.m_Name + ".png"))
                    mats[m.m_Name] = t.m_Name
        for o in env.objects:
            if o.type.name != "SkinnedMeshRenderer":
                continue
            r = o.read()
            mesh = r.m_Mesh.read()
            if mesh.m_Name in done:
                continue
            done.add(mesh.m_Name)
            names = [x.read().m_Name for x in r.m_Materials]
            lines = [f"mtllib {mesh.m_Name}.mtl"]
            for line in mesh.export().splitlines():
                lines.append(line)
                g = re.match(rf"g {re.escape(mesh.m_Name)}_(\d+)$", line)
                if g and int(g.group(1)) < len(names):
                    lines.append(f"usemtl {names[int(g.group(1))]}")
            open(os.path.join(out, mesh.m_Name + ".obj"), "w").write("\n".join(lines) + "\n")
            with open(os.path.join(out, mesh.m_Name + ".mtl"), "w") as f:
                for n in names:
                    # a_* materials are drawn additively in game (same convention as item A_Character)
                    f.write(f"newmtl {n}\n{'# additive' + chr(10) if n.startswith('a_') else ''}map_Kd {mats.get(n, '')}.png\n\n")
            files.append(f"models/{model}/{mesh.m_Name}.obj")
    return files


scene = latest_assets("GameScene_th")
enemies, fields = parse_plain(scene["Enemy_th"]), parse_plain(scene["FieldName_th"])
enemies = {k: v.strip() for k, v in enemies.items()}  # 5 Enemy_th names carry trailing spaces
elements, flags, props = enum("ElementType"), enum("MobMultiFlag"), enum("Toram.Common.Mob.MonsterPropertyType")
triggers = enum("HyperModeTrigger")
items = {}
with open(os.path.join(BASE, "items", "items.csv"), encoding="utf-8-sig") as f:
    for r in csv.DictReader(f):
        items[int(r["id"])] = r["name"]


def menu_rooms(b, op, o):
    """(map, room) targets of every `op` in sc_ bytecode; operand at +o is <I map><B room><H x,y,z><H dir><H -1>."""
    for m in re.finditer(re.escape(struct.pack("<H", op)), b):
        p = m.start() + o
        if b[p + 13:p + 15] == b"\xff\xff":
            yield struct.unpack_from("<IB", b, p)


AILMENT_TH = {-1: "สะดุ้ง(เวท)", 1: "สะดุ้ง", 2: "ล้ม", 3: "มึน", 4: "กระเด็น", 5: "พิษ", 6: "อัมพาต", 7: "ตาบอด", 8: "ติดไฟ",
              9: "แช่แข็ง", 10: "เกราะแตก", 11: "ช้า", 12: "หยุด", 13: "กลัว", 14: "เวียนหัว", 15: "อ่อนแอ", 16: "ทรุด",
              17: "สับสน", 18: "ใบ้", 19: "เลือดไหล", 20: "หลับ", 22: "คลั่ง", 23: "เหนื่อย", 28: "ถูกดูด", 30: "เสน่ห์",
              32: "คำสาป", 33: "แฟลช", 40: "แรงโน้มถ่วง", 41: "ดิสเพล", 42: "กลับด้าน", 43: "กลายเป็นหิน"}
WEAPON_TH = {7: "ค้อน", 8: "คาตานะ", 9: "ทวน", 10: "ดาบมือเดียว", 11: "ดาบสองมือ", 12: "ธนู", 13: "ธนูกล", 14: "ไม้เท้า",
             15: "อุปกรณ์เวท", 16: "สนับมือ", 18: "มีดสั้น"}


def property_th(t, v):
    """Thai one-liner for a MobPropertyMaster (A..E = v[0..4]). [code] = read from the MobProperty* class in libil2cpp;
    [data] = meaning inferred from value patterns only. NOTES.md (Monsters, properties) has the method addresses."""
    a, b, c, d, _ = v
    ail = AILMENT_TH.get(a, f"สถานะ#{a}")
    return {
        1: f"[code] ต้านสถานะ{ail}: โอกาสติด x{100 - c}% แล้ว -{b} แต้ม, ติดแล้วกันซ้ำเพิ่ม {d / 10:g} วิ",
        2: f"[code] ถ้ามอนติดสถานะ{ail} อยู่ ดาเมจที่ได้รับ +{b}%",
        3: f"[code] ถ้ามอนติดสถานะ{ail} อยู่ ดาเมจจากผลสถานะ +{b}% (ตีความชื่อ AppliedDamage)",
        4: f"[code] โดนอาวุธ{WEAPON_TH.get(a, f'#{a}')} ดาเมจพื้นฐาน {b:+d}%",
        5: (f"[code] จำกัดดาเมจต่อฮิต {a}%-{b}% ของ HP สูงสุด" if d & 32 else f"[code] จำกัดดาเมจต่อฮิต {a}-{b}")
           + (f", เอฟเฟกต์ตัวเลข x{c / 100:g}" if c else "") + (f", flag D={d}" if d & ~32 else ""),
        6: f"[code] ลดอัตราคริของผู้เล่น {a} แต้ม (ลดครึ่งเมื่อมอนติดบางสถานะ)",
        7: f"[data] ปรับค่าตัด(ต้านทาน)ของพาร์ท A={a} B={b}",
        8: f"[data] ปรับค่าตัด(ต้านทาน)ของตัวหลัก A={a} B={b}",
        10: f"[code] ท่าโจมตี #{a} เร็วขึ้น x{100 / (100 - b) if b < 100 else 10000:.2f}",
        13: f"[data] ท่าเหยียบ/โจมตีเท้า A={a} B={b} C={c} D={d}",
        14: f"[code] ล็อก HP ไว้ที่ {a}% (ลดต่ำกว่านี้ไม่ได้จนกว่า script ปลด)",
        15: f"[code] ถ้าผู้เล่นอยู่ห่าง {a}-{b} ม. ดาเมจเหลือ {c}%",
        16: f"[data] FunnelFlag A={a}",
        17: f"[code] วงเหตุการณ์ใต้ตัว: script flag {a}, รัศมี {b}, สี {c & 0xffffffff:08x}",
        18: f"[code] เอฟเฟกต์หน้าจอแบบ {a}, สี {b & 0xffffffff:08x}, รัศมีใน {c} นอก {d}",
        19: f"[code] script action แบบ {'Hate' if a == 0 else a}: ค่า1={b} ค่า2={c}",
        20: f"[code] โดนตีหลายฮิตพร้อมกันเกิน {max(b, 1)} ครั้ง ดาเมจเหลือ {min(a, 100)}% (เงื่อนไขอนุมานจากชื่อ)",
        21: f"[data] IdSetting หมายเลข {a}",
        22: f"[code] เปลี่ยนท่า animation: {[x for x in v if x != -1]}",
        23: f"[data] AreaHate A={a} B={b} C={c} D={d}",
        30: f"[code] High Raid: พลังโจมตี x{a / 100:g}, ค่าหลบที่ต้องใช้ x{b / 100:g}",
        31: f"[data] DPSLimit A={a}",
        32: f"[code] High Raid ล็อกค่าไม่คูณตามเลเวล: " + (", ".join(n for k, n in enumerate(
            ["HP", "Hit", "Def", "MDef", "ตัดกายภาพ", "ตัดเวท"]) if a >> k & 1) or "ไม่มี"),
        33: f"[code] ดาเมจต่อฮิตสูงสุด {a / 100:g}% ของ HP สูงสุด" + (f", เอฟเฟกต์ตัวเลข x{c / 100:g}" if c else "") + f" (B={b} D={d} ยังไม่แกะ)",
        34: f"[code] ดาเมจต่อฮิตต่ำสุด {a / 100:g}% ของ HP สูงสุด" + (f", เอฟเฟกต์ตัวเลข x{c / 100:g}" if c else "") + f" (B={b} D={d} ยังไม่แกะ)",
        50: f"[data] หลอด HP บนหัว: A={a} (จำนวนหลอด?) B={b} C={c}",
        51: f"[data] เกจการ์ด: เปิด={a} B={b} C={c}",
        52: f"[data] ประเภทมอนล่าสมบัติ {a} B={b} C={c}",
        90: f"[code] Guild raid คู่มอน: ลดดาเมจสุดท้าย (A={a} B={b})",
    }.get(t, f"type {t} {v}")


def boss_menus(b):
    """BossMenu (130) -> (map, room, closeDifficulty, level). FieldScriptManager.OnBossMenuCommand (libil2cpp RVA 0x25949F0):
    script ver >= 15: <B sub><B -><I map><B room><H x,y,z><H rot><H -><I map><B room><B -><H x,y,z><I level>
    [sub >= 15: <B closeDifficulty>][sub >= 16: <B itemButtonHide>]; ver 14: same without <B sub><B ->; older: skipped."""
    ver = b[0]
    if ver < 14:
        return
    for m in re.finditer(b"\x82\x00", b):
        sub, p = (b[m.start() + 2], m.start() + 4) if ver >= 15 else (0, m.start() + 2)
        if b[p + 13:p + 15] == b"\xff\xff" and p + 32 <= len(b):
            yield (*struct.unpack_from("<IB", b, p), b[p + 31] if sub >= 15 else 0, struct.unpack_from("<I", b, p + 27)[0])


DIFF = ["Easy", "Normal", "Hard", "Nightmare", "Ultimate"]
mob_files, script_of = {}, {}
# BossMenu (130) opens the Easy..Ultimate picker for a boss room; BossAreaLevelMenu (170) picks one of several
# fixed-level rooms (event bosses: Candela, Choco Orc, Mieli...). NOTES.md (Monsters, boss kinds).
DIFF_ROOMS, LEVEL_ROOMS = {}, set()
# event-mode script bundles (FieldScript/<name> on the CDN) carry mob_ files too
script_bundles = {**latest("FieldScript_*"), **latest("DefenceScript"), **latest("DungeonScript"), **latest("Moba")}
for bundle, data in script_bundles.items():
    for blob in text_assets(data).values():
        for ta in (o.read() for o in UnityPy.load(blob).objects if o.type.name == "TextAsset"):
            if ta.m_Name.startswith("mob_"):
                key = ta.m_Name if bundle.startswith("FieldScript_") else f"{bundle}/{ta.m_Name}"
                mob_files[key] = ta.m_Script.encode("utf-8", "surrogateescape")
                script_of[key] = f"{bundle}/{ta.m_Name}"
            elif re.fullmatch(r"sc_\d+", ta.m_Name):
                b = ta.m_Script.encode("utf-8", "surrogateescape")
                for mp, room, close, level in boss_menus(b):
                    # UIBossSymbolManager.SetSelectDifficulty: bit k set = difficulty k (Easy..Ultimate) not offered
                    DIFF_ROOMS.setdefault((mp, room), set()).update(d for k, d in enumerate(DIFF) if not close >> k & 1)
                LEVEL_ROOMS.update(menu_rooms(b, 170, 5))

rows = []
for name, b in sorted(mob_files.items()):
    if len(b) < 12:
        continue  # 8-byte stubs: map id + 0 records
    ver, fid, recs, drops = parse_mobs(b)
    for r in recs:
        r.update({"script_file": script_of[name], "map": fid, "map_name": fields.get(fid, ""), "name_th": enemies.get(r["uuid"], ""),
                  "element_name": elements.get(r["element"], ""),
                  "flag_names": [n for v, n in flags.items() if v and r["flag"] & v == v],
                  "drops": [{"item": it, "item_name": items.get(it, ""), "raw2": v} for it, v in drops.get(r["id"], [])]})
        for p in r["properties"]:
            p["type_name"] = props.get(p["type"], "")
            p["desc_th"] = property_th(p["type"], p["values"])
        for m in r["modes"]:
            m["trigger_name"] = triggers.get(m["trigger"], "")
        rows.append(r)

reward_types = enum("Toram.Common.Items.RewardType")
raids = {}
b = master("HighRaidBossMaster")
i = 5  # <B 0><I count>
for _ in range(struct.unpack_from("<I", b, 1)[0]):
    no, fid, room, rflag, mid, uuid, base, mn, n = struct.unpack_from("<BIBBIIHHH", b, i); i += 21
    rewards = []
    for _ in range(n):
        idx, points, rtype, value, num, order = struct.unpack_from("<BIBIIB", b, i); i += 15
        rewards.append({"idx": idx, "points": points, "type": reward_types.get(rtype, rtype), "value": value,
                        "value_name": items.get(value, "") if rtype in (1, 5) else "", "num": num, "order": order})
    raids[uuid] = {"no": no, "uuid": uuid, "name_th": enemies.get(uuid, ""), "field": fid, "room": room, "raid_flag": rflag,
                   "monster_id": mid, "base_level": base, "min_level": mn, "rewards": rewards}
assert i == len(b), (i, len(b))
# High Raid: HighRaidBossBattleStatus / HighRaidMobBattleStatus (libil2cpp) scale every record in the raid room by the
# level picked in UIHighRaidEnterManager: start BaseLevel, buttons -5/+5/-10/+10 clamped to [MinLevel, cap]; cap =
# FunctionLimitManager.GetValue(15), a server value not in the client. If cap <= MinLevel only MinLevel is offered.
# ponytail: cap hard-coded from what the user sees in game (2026-09-25); update when the level cap rises.
HIGH_RAID_LEVEL_CAP = 325
HR_ROOMS = {(x["field"], x["room"]): x for x in raids.values()}


def hr_levels(x):
    lo, cap = x["min_level"], HIGH_RAID_LEVEL_CAP
    if cap <= lo:
        return [lo]
    seen, todo = set(), [x["base_level"] if lo <= x["base_level"] else lo]
    while todo:
        v = todo.pop()
        if v in seen:
            continue
        seen.add(v)
        todo += [max(v - d, lo) for d in (5, 10)] + [min(v + d, cap) for d in (5, 10)]
    return sorted(seen)


def hr_stats(r, lv):
    """Base stats at raid level lv, float32 like the client. Fixed* bits (HighRaidFlag property, ValueA) keep the record
    value. Live-only terms not included: + alive parts (hit/def/mdef/cut), buffs, Def/MDef x0.5 under abnormal 10."""
    f = next((p["values"][0] for p in r["properties"] if p["type"] == 32), 0)
    F, L = np.float32, np.float32(lv)
    trunc = lambda x: int(x)
    hp = F(1.5 if lv > 149 else 1.0) * (((L / F(10) + F(30)) * (F(lv * lv) / F(2.4) + F(lv + 81))) * (F(r["hp"]) / F(100)))
    return {"lv": lv,
            "hp": r["hp"] if f & 1 else trunc(hp),
            "necessary_hit": r["necessary_hit"] if f & 2 else trunc(L * F(1.5) * (F(r["necessary_hit"]) / F(100))),
            "def": r["def"] if f & 4 else trunc(F(r["def"]) / F(100) * L),
            "mdef": r["mdef"] if f & 8 else trunc(F(r["mdef"]) / F(100) * L),
            "resist_physical": r["resist_physical"] + (0 if f & 16 else trunc(L * F(0.04))),
            "resist_magic": r["resist_magic"] + (0 if f & 32 else trunc(L * F(0.04)))}


# Guild Raid (libil2cpp GuildRaidBossMobBattleStatus / GuildRaidEntourageMobBattleStatus, room type 29): maps 100100..100600
# hold one boss per element (Fire..Dark = System_th GuildRaidBossId1..6). Stats come from the server-sent raid level L
# (GuildRaidRoomData.GuildRaidLevel) and HP gauge count G (CurrentHpCount); the summon menu shows L = 4 * G.
# Rows are emitted for L = 4 * G. Boss class for record ids < 1000, entourage for the rest (inferred from the id layout).
# ponytail: level grid is a guess (server decides the range); change GUILD_RAID_LEVELS when real levels are known.
GUILD_RAID_MAPS = {100100, 100200, 100300, 100400, 100500, 100600}
GUILD_RAID_LEVELS = list(range(40, 321, 40))


def gr_stats(r, lv):
    """Base stats at guild raid level lv (float32 like the client). Live-only terms not included: alive parts,
    StatusCollection (property 40) / orb random properties, buffs, abnormal x0.5."""
    F, g, t = np.float32, lv // 4, lv
    base = F(F(t) / F(10) + F(30)) * F(int(F(F(t * t) / F(2.4)) + F(t + 81)))
    hp = int((round(float(F(g * g) / F(100)), 2) + 50.0) * float(base))
    boss = r["id"] < 1000
    return {"lv": lv,
            "hp": hp if boss else int(F(hp) * F(F(r["hp"]) / F(100))),
            "necessary_hit": int(F(F(F(t) * F(1.5)) * F(r["necessary_hit"])) * F(0.01)),
            "def": int(F(F(r["def"] * t) * F(0.01))) if boss else int(F(F(r["def"]) * F(0.01)) * F(t)),
            "mdef": int(F(F(r["mdef"] * t) * F(0.01))) if boss else int(F(F(r["mdef"]) * F(0.01)) * F(t)),
            "resist_physical": r["resist_physical"] + t // 10,
            "resist_magic": r["resist_magic"] + t // 10}


area_hp = {}
for r in rows:
    if not r["flag"] & 4 and r["uuid"] and r["hp"] > 100:
        area_hp.setdefault(r["map"] // 100, []).append(r["hp"])
area_hp = {k: statistics.median(v) for k, v in area_hp.items()}


def boss_kind(r):
    if not r["flag"] & 4:
        return ""
    if (r["map"], r["room"]) in HR_ROOMS:
        return "high_raid"
    if r["map"] in GUILD_RAID_MAPS:
        return "guild_raid"
    if (r["map"], r["room"]) in DIFF_ROOMS:
        return "difficulty"
    if (r["map"], r["room"]) in LEVEL_ROOMS:
        return "level_select"
    g = r["script_file"].split("/")[0]
    # ponytail: field mini boss = Boss flag, no menu, open field (room 0, world group < 90), HP >= 10x the area's
    # normal-mob median; the client has no mini flag. Misses a mini that sits in an instanced room or a weak one.
    if (g.startswith("FieldScript_") and int(g[12:]) < 90 and r["map"] and r["uuid"] and r["room"] == 0
            and r["hp"] >= 10 * area_hp.get(r["map"] // 100, float("inf"))):
        return "field_mini"
    return "other"


for r in rows:
    r["boss_kind"] = boss_kind(r)
    r["difficulties"] = [d for d in DIFF if d in DIFF_ROOMS.get((r["map"], r["room"]), ())] if r["boss_kind"] == "difficulty" else []
    raid = HR_ROOMS.get((r["map"], r["room"]))
    r["high_raid_levels"] = hr_levels(raid) if raid else []
    r["guild_raid_levels"] = GUILD_RAID_LEVELS if r["boss_kind"] == "guild_raid" else []

# Phases: a mode whose target is another record swaps the mob to that record's full stat line (MobHyperModeGroup).
# Target == self only changes AI mode. `changed` lists every stat that differs between the two records.
PHASE_STATS = ["lv", "hp", "def", "mdef", "necessary_hit", "resist_physical", "resist_magic", "guard", "avoid",
               "proration_normal", "proration_physical", "proration_magic", "element_name", "flag_names", "model", "move_speed"]
by_rec = {(r["script_file"], r["id"]): r for r in rows}
for r in rows:
    r["phase_to"], r["phase_from"] = [], []
for r in rows:
    for m in r["modes"]:
        t = by_rec.get((r["script_file"], m["target"]))
        if not t or t is r:
            continue
        link = {"from": r["id"], "to": t["id"], "mode_id": m["mode_id"], "trigger": m["trigger_name"] or m["trigger"],
                "value": m["value"], "changed": {k: [r[k], t[k]] for k in PHASE_STATS if r[k] != t[k]}}
        r["phase_to"].append(link)
        t["phase_from"].append(link)
phase_str = lambda l: (f"#{l['from']}->#{l['to']} {l['trigger']}={l['value']}"
                       + (": " + ", ".join(f"{k} {a}->{b}" for k, (a, b) in l["changed"].items()) if l["changed"] else ""))

models = {}
for bundle, data in latest("Mob_*").items():
    model = int(bundle[4:])
    models[model] = export_model(model, data, os.path.join(OUT, "models", str(model)))
for r in rows:
    r["model_files"] = models.get(r["model"], [])

os.makedirs(OUT, exist_ok=True)
json.dump(rows, open(os.path.join(OUT, "monsters.json"), "w", encoding="utf-8"), ensure_ascii=False, indent=1)
cols = ["map", "map_name", "id", "uuid", "room", "name_th", "name_jp", *FIXED, "element_name", "flag_names", "boss_kind", "difficulties", "high_raid_levels",
        "scale", "move_speed", "properties", "phase_to", "phase_from", "drops", "model_files"]
with open(os.path.join(OUT, "monsters.csv"), "w", encoding="utf-8-sig", newline="") as f:
    w = csv.writer(f)
    w.writerow(cols)
    for r in rows:
        w.writerow([" | ".join(r[c]) if c in ("flag_names", "model_files", "difficulties") else
                    " | ".join(map(str, r[c])) if c == "high_raid_levels" else
                    " | ".join(map(phase_str, r[c])) if c in ("phase_to", "phase_from") else
                    " | ".join(f"{d['item_name']}#{d['item']}" for d in r[c]) if c == "drops" else
                    " | ".join(f"{p['type_name'] or p['type']}{p['values']} = {p['desc_th']}" for p in r[c]) if c == "properties" else
                    r[c] for c in cols])
print(len(rows), "spawn records,", len({r["uuid"] for r in rows}), "monsters,", len(mob_files), "maps,",
      sum(bool(r["drops"]) for r in rows), "with drops,", len(models), "model bundles,",
      sum(bool(r["model_files"]) for r in rows), "records with a model ->", OUT)

# index of every Enemy_th name, joined with what the client knows about it
reward_types, suitable = enum("Toram.Common.Items.RewardType"), enum("PetAttackPatternData/SuitableFlag")
pets = {}
b = master("PetCaptureDataMaster")
i = 4
for _ in range(struct.unpack_from("<I", b)[0]):
    uid, model, smin, smax, flag, k = struct.unpack_from("<IIHHII", b, i); i += 20
    pats = []
    for _ in range(k):
        # PatternData order; byte 6 (0/255) assumed continuousAttackNum
        motion, rate, stable, hit, cont, snd_start, snd_attack, pflag = struct.unpack_from("<HHBBbBBI", b, i); i += 13
        pats.append({"motion": motion, "attack_rate": rate, "stable": stable, "hit_rate": hit, "continuous_attack": cont,
                     "sound_start": snd_start, "sound_attack": snd_attack,
                     "flags": [n for v, n in suitable.items() if v and pflag & v == v and n != "All"]})
    pets[uid] = {"uuid": uid, "name_th": enemies.get(uid, ""), "model": model, "scale_min": smin, "scale_max": smax,
                 "flag": flag, "attack_patterns": pats}
assert i == len(b), (i, len(b))

b = master("HighRaidMaterialMaster")
materials = []
for k in range(struct.unpack_from("<I", b, 1)[0]):
    idx, item, count = struct.unpack_from("<BIB", b, 5 + 6 * k)
    materials.append({"index": idx, "item": item, "count": count, "item_name": items.get(item, "")})
assert 5 + 6 * len(materials) == len(b)
b = master("HighRaidTrophyMaster")
trophies = []
for k in range(struct.unpack_from("<H", b, 1)[0]):
    no, tid, utype, uval, rtype, rval, rnum = struct.unpack_from("<BBBHBII", b, 3 + 14 * k)
    trophies.append({"high_raid_no": no, "trophy": tid, "unlock_type": utype, "unlock_value": uval,
                     "reward_type": reward_types.get(rtype, rtype), "reward_value": rval, "reward_num": rnum})
assert 3 + 14 * len(trophies) == len(b)
json.dump(list(pets.values()), open(os.path.join(OUT, "pets.json"), "w", encoding="utf-8"), ensure_ascii=False, indent=1)
json.dump({"bosses": list(raids.values()), "materials": materials, "trophies": trophies},
          open(os.path.join(OUT, "high_raid.json"), "w", encoding="utf-8"), ensure_ascii=False, indent=1)
by_uuid = {}
for r in rows:
    by_uuid.setdefault(r["uuid"], []).append(r)
index = []
for uid, name in sorted(enemies.items()):
    rs = by_uuid.get(uid, [])
    model = next((r["model"] for r in rs if r["model"] > 0), pets[uid]["model"] if uid in pets else -1)
    index.append({"uuid": uid, "name_th": name, "name_jp": rs[0]["name_jp"] if rs else "", "spawn_records": len(rs),
                  "maps": " | ".join(sorted({r["map_name"] or str(r["map"]) for r in rs})),
                  "lv": " | ".join(sorted({str(r["lv"]) for r in rs}, key=int)), "boss": any(r["flag"] & 4 for r in rs),
                  "pet_capture": uid in pets, "high_raid_lv": f"{raids[uid]['min_level']}-{raids[uid]['base_level']}" if uid in raids else "",
                  "model": model, "model_cached": model in models})
with open(os.path.join(OUT, "monster_index.csv"), "w", encoding="utf-8-sig", newline="") as f:
    w = csv.DictWriter(f, fieldnames=list(index[0]))
    w.writeheader(); w.writerows(index)
print(len(index), "Enemy_th names;", sum(bool(x["spawn_records"]) for x in index), "with stats;",
      sum(x["pet_capture"] for x in index), "pet-capturable;", len(raids), "high raid bosses;",
      sum(x["model_cached"] for x in index), "with cached model")

# ItemDorpData: <I count> + count x <I item><I map><I mob uuid><B kind>; the item's "obtained from" hint.
# No rate in it. 1913 of 2166 checkable rows match a cached mob_<map> drop table.
b = master("ItemDorpData")
sources = []
for k in range(struct.unpack_from("<I", b)[0]):
    item, fmap, uuid, kind = struct.unpack_from("<IIIB", b, 4 + 13 * k)
    sources.append({"item": item, "item_name": items.get(item, ""), "map": fmap, "map_name": fields.get(fmap, "") if fmap else "",
                    "mob_uuid": uuid, "mob_name": enemies.get(uuid, "") if uuid else "", "kind": kind})
assert 4 + 13 * len(sources) == len(b)
with open(os.path.join(BASE, "items", "item_drop_sources.csv"), "w", encoding="utf-8-sig", newline="") as f:
    w = csv.DictWriter(f, fieldnames=list(sources[0]))
    w.writeheader(); w.writerows(sources)
print(len(sources), "item drop sources,", sum(bool(s["mob_uuid"]) for s in sources), "with a mob")

# Boss difficulty scaling, read from libil2cpp.so (Android arm64, offline): Toram.Common.Rooms.BossDifficultyLevelMethods
# static tables indexed by clamp(difficulty, -1, 3) + 1. BossMobBattleStatus: MaxHp -> HpRate, Level -> LvRate (min 1),
# NecessaryHit/Def/MagicDef -> StatusRate; value = (int)(float32 rate * param). Cut/guard/avoid/element are not scaled.
# The client stores only the Normal line (mob_ record) and scales it at runtime with these tables; there is no stored
# per-difficulty stat line anywhere in the client. Only difficulties the room's BossMenu offers are emitted.
difficulty_scaled = lambda r: r["boss_kind"] == "difficulty"
HP_RATE, STATUS_RATE, LV_RATE = [0.1, 1.0, 2.0, 5.0, 10.0], [0.1, 1.0, 2.0, 4.0, 6.0], [-10, 0, 10, 20, 40]
EXP_RATE, PARTS_EXP_RATE = [0.1, 1.0, 2.0, 5.0, 10.0], [0.1, 1.0, 1.0, 1.0, 1.0]
f32 = lambda x: struct.unpack("<f", struct.pack("<f", x))[0]
scale = lambda v, r: int(f32(f32(r) * f32(v)))
# Map files repeat one boss under several record ids/rooms and event maps copy it verbatim: one row per distinct
# stat line, with every map/record/room it came from listed.
boss_rows = {}
for r in rows:
    if not difficulty_scaled(r):
        continue
    for k, d in enumerate(DIFF):
        if d not in r["difficulties"]:
            continue
        key = (r["uuid"], r["name_th"], d, max(1, r["lv"] + LV_RATE[k]), scale(r["hp"], HP_RATE[k]),
               scale(r["necessary_hit"], STATUS_RATE[k]), scale(r["def"], STATUS_RATE[k]), scale(r["mdef"], STATUS_RATE[k]),
               scale(r["exp"], EXP_RATE[k]))
        acc = boss_rows.setdefault(key, [{}, {}, {}, {}])
        acc[0][r["map"]] = acc[1][r["map_name"]] = acc[2][(r["id"], r["room"])] = None
        acc[3].update(dict.fromkeys(map(phase_str, r["phase_from"] + r["phase_to"])))
for r in rows:
    if r["flag"] & 4 and r["high_raid_levels"]:
        for lv in r["high_raid_levels"]:
            st = hr_stats(r, lv)
            key = (r["uuid"], r["name_th"], f"Lv{lv}", lv, st["hp"], st["necessary_hit"], st["def"], st["mdef"], r["exp"])
            acc = boss_rows.setdefault(key, [{}, {}, {}, {}])
            acc[0][r["map"]] = acc[1][r["map_name"]] = acc[2][(r["id"], r["room"])] = None
            acc[3].update(dict.fromkeys(map(phase_str, r["phase_from"] + r["phase_to"])))
    for lv in r["guild_raid_levels"]:
        st = gr_stats(r, lv)
        key = (r["uuid"], r["name_th"], f"GR{lv}", lv, st["hp"], st["necessary_hit"], st["def"], st["mdef"], r["exp"])
        acc = boss_rows.setdefault(key, [{}, {}, {}, {}])
        acc[0][r["map"]] = acc[1][r["map_name"]] = acc[2][(r["id"], r["room"])] = None
        acc[3].update(dict.fromkeys(map(phase_str, r["phase_from"] + r["phase_to"])))
with open(os.path.join(OUT, "boss_difficulty.csv"), "w", encoding="utf-8-sig", newline="") as f:
    w = csv.writer(f)
    w.writerow(["uuid", "name_th", "difficulty", "lv", "hp", "necessary_hit", "def", "mdef", "exp", "maps", "map_names", "id:room", "phases"])
    for key, (maps, names, ids, ph) in boss_rows.items():
        w.writerow([*key, " | ".join(map(str, maps)), " | ".join(filter(None, names)), " | ".join(f"{a}:{b}" for a, b in ids),
                    " | ".join(ph)])
print(len(boss_rows), "boss difficulty rows")

# One entry per monster (uuid) -> monsters/monster_full.json; one row per spawn record x difficulty -> monster_full.csv.
# Bosses get a full stat block per difficulty (Easy..Ultimate, BossDifficultyLevelMethods); stats the game does not
# scale are copied unchanged so every block stands alone. Normal-only monsters have one block, difficulty "-".
enemies_us = {k: v.strip() for k, v in parse_plain(latest_assets("GameScene_us")["Enemy_us"]).items()}
src_by_uuid = {}
for s in sources:
    if s["mob_uuid"]:
        src_by_uuid.setdefault(s["mob_uuid"], []).append({k: s[k] for k in ("item", "item_name", "map", "map_name", "kind")})
STATS = ["lv", "hp", "exp", "def", "mdef", "necessary_hit", "resist_physical", "resist_magic", "guard", "avoid",
         "proration_normal", "proration_physical", "proration_magic", "element_name", "move_speed"]


def stat_blocks(r):
    base = {k: r[k] for k in STATS}
    if r["guild_raid_levels"]:
        return [{**base, **gr_stats(r, lv), "difficulty": f"GR{lv}"} for lv in r["guild_raid_levels"]]
    if not difficulty_scaled(r) and not r["high_raid_levels"]:
        return [{"difficulty": "-", **base}]
    if r["high_raid_levels"]:
        return [{**base, **hr_stats(r, lv), "difficulty": f"Lv{lv}"} for lv in r["high_raid_levels"]]
    return [{**base, "difficulty": d, "lv": max(1, r["lv"] + LV_RATE[k]), "hp": scale(r["hp"], HP_RATE[k]),
             "exp": scale(r["exp"], EXP_RATE[k]), "def": scale(r["def"], STATUS_RATE[k]), "mdef": scale(r["mdef"], STATUS_RATE[k]),
             "necessary_hit": scale(r["necessary_hit"], STATUS_RATE[k])} for k, d in enumerate(DIFF) if d in r["difficulties"]]


full = []
for uid in sorted(set(enemies) | set(by_uuid)):
    rs = by_uuid.get(uid, [])
    spawns = {}
    for r in rs:
        s = {"script_file": r["script_file"], "map": r["map"], "map_name": r["map_name"],
             "model": r["model"], "boss": bool(r["flag"] & 4), "boss_kind": r["boss_kind"], "difficulties": r["difficulties"], "flags": r["flag_names"], "size": r["size"], "scale": r["scale"],
             "colors": r["colors"], "stats": stat_blocks(r),
             "properties": r["properties"], "drops": r["drops"], "modes": r["modes"],
             "phase_to": [{k: v for k, v in l.items() if k != "from"} for l in r["phase_to"]], "phase_from": r["phase_from"],
             "ai_raw": {"actions": r["actions_raw"], "ex_actions": r["ex_actions"], "modes": r["modes_raw"], "raw_52_55": r["raw_52_55"]}}
        # a map file often repeats one monster under several record ids / rooms with byte-identical data: keep one, list the ids
        s = spawns.setdefault(json.dumps(s, sort_keys=True), {**s, "record_ids": [], "rooms": []})
        s["record_ids"].append(r["id"])
        if r["room"] not in s["rooms"]:
            s["rooms"].append(r["room"])
    spawns = list(spawns.values())
    model_ids = sorted({r["model"] for r in rs if r["model"] > 0} | ({pets[uid]["model"]} if uid in pets else set()))
    full.append({"uuid": uid, "name_th": enemies.get(uid, ""), "name_en": enemies_us.get(uid, ""),
                 "name_jp": rs[0]["name_jp"] if rs else "", "has_stats": bool(rs), "boss": any(r["flag"] & 4 for r in rs), "mini_boss": any(r["boss_kind"] == "field_mini" for r in rs),
                 "model_ids": model_ids, "model_cached": [m for m in model_ids if m in models],
                 "spawns": spawns, "pet_capture": pets.get(uid), "high_raid": raids.get(uid),
                 "obtained_from_hints": src_by_uuid.get(uid, [])})
json.dump(full, open(os.path.join(OUT, "monster_full.json"), "w", encoding="utf-8"), ensure_ascii=False, indent=1)

# Map files copy-paste the same monster into many records/rooms/maps, so a CSV row = one distinct (stats, drops) line
# per monster; everything else (model, flags, properties, maps, records) is merged into lists on that row.
# Bosses keep one row per difficulty; `variants` = JSON spawn entries merged.
LISTS = ["phases", "models", "flags", "properties", "maps", "map_names", "map:record_ids", "rooms", "script_files"]
cols = ["uuid", "name_th", "name_en", "name_jp", "boss", "boss_kind", "difficulty", *STATS, "drops", "variants", *LISTS]
out_rows = {}
for m in full:
    if m["uuid"] == 0:
        continue  # "unknown": unnamed script objects/gimmicks (mostly hp 10), kept in the JSON only
    if not m["spawns"]:
        out_rows[(m["uuid"],)] = [m["uuid"], m["name_th"], m["name_en"], m["name_jp"], False, False, "no data"] + [""] * (len(STATS) + 1) + [0] + [[] for _ in LISTS]
    for s in m["spawns"]:
        vals = ([phase_str({"from": x, **l}) for x in s["record_ids"] for l in s["phase_to"]] + list(map(phase_str, s["phase_from"])),
                [s["model"]], s["flags"], [f"{p['type_name'] or p['type']}{p['values']} = {p['desc_th']}" for p in s["properties"]], [s["map"]],
                [s["map_name"]], [f"{s['map']}:{x}" for x in s["record_ids"]], s["rooms"], [s["script_file"]])
        for b in s["stats"]:
            key = [m["uuid"], m["name_th"], m["name_en"], m["name_jp"], s["boss"], s["boss_kind"], b["difficulty"], *[b[k] for k in STATS],
                   " | ".join(f"{d['item_name']}#{d['item']}" for d in s["drops"])]
            row = out_rows.setdefault(tuple(key), key + [0] + [[] for _ in LISTS])
            row[-len(LISTS) - 1] += 1
            for acc, v in zip(row[-len(LISTS):], vals):
                acc += [x for x in v if x != "" and x not in acc]
rows_out = len(out_rows)
with open(os.path.join(OUT, "monster_full.csv"), "w", encoding="utf-8-sig", newline="") as f:
    w = csv.writer(f)
    w.writerow(cols)
    for row in out_rows.values():
        w.writerow(row[:-len(LISTS)] + [" | ".join(map(str, x)) for x in row[-len(LISTS):]])
print(len(full), "monsters,", rows_out, "csv rows ->", os.path.join(OUT, "monster_full.json|csv"), ";",
      sum(m["has_stats"] for m in full), "with stats,", sum(m["boss"] for m in full), "boss-flagged")

# monsters/GUILDRAID_BOSS.json|csv: every record in the guild raid maps with its base line, properties, drops, phases
# and the scaled stats per level (gr_stats + the attack/flee rates from the same classes, see calc Reverse/guild_raid).
from export_trophies import parse_system
gr_text = parse_system(scene["System_th"])
GR_NAMES = {m: gr_text.get(f"GuildRaidBossId{k}", "") for k, m in enumerate(sorted(GUILD_RAID_MAPS), 1)}


def gr_rates(r, lv):
    F, t = np.float32, lv
    if r["id"] < 1000:
        x = int(F(F(F(t * 321) / F(100)) + F(F(F(t) / F(2.5)) * F(t)) / F(3)) + F(F(t * t) / F(7)))
        dmg = F(F(F(t) / F(1000)) + F(0.25)) * F(x + t) * F(0.01)
    else:
        x = int(F(F(F(t * 321) / F(100)) + F(F(F(t) / F(2.5)) * F(t)) / F(3)) + F(t * t // 7))
        dmg = F(int(F(x) * F(0.1))) * F(0.01)
    d = round(float(dmg), 4)
    return {"gauge": lv // 4, "damage_percent": d,
            "damage_percent_desc": f"ค่าพลังโจมตีของมอน (ATK): ดาเมจ = เลเวลมอน + int({d} × พลังท่า) − เลเวลผู้เล่น "
                                   f"แล้วหักตาม DEF ผู้เล่น (MobNormalAttack/MobMagicAttack.calcMobToPlayerDamage); "
                                   f"ท่าพลัง 100 ≈ {int(d * 100):,}",
            "necessary_flee_percent": round(float(F(F(t) * F(1.5)) * F(0.01)), 4),
            "guard": r["guard"], "avoid": r["avoid"], "move_speed": r["move_speed"]}


gr_recs = sorted((r for r in rows if r["map"] in GUILD_RAID_MAPS), key=lambda r: (r["map"], r["id"]))
gr_json = []
for r in gr_recs:
    gr_json.append({"boss_no": sorted(GUILD_RAID_MAPS).index(r["map"]) + 1, "boss_name_system": GR_NAMES[r["map"]],
                    "map": r["map"], "map_name": r["map_name"], "record_id": r["id"], "uuid": r["uuid"], "name_th": r["name_th"],
                    "name_jp": r["name_jp"], "role": "boss" if r["id"] < 1000 else "add (inferred)", "element": r["element_name"],
                    "flags": r["flag_names"], "base": {k: r[k] for k in STATS},
                    "properties": [{**p} for p in r["properties"]], "drops": r["drops"],
                    "phases": [phase_str(l) for l in r["phase_to"] + r["phase_from"]],
                    "levels": [{**gr_stats(r, lv), **gr_rates(r, lv)} for lv in GUILD_RAID_LEVELS]})
json.dump({"note": "Scaled by raid level L (server) and HP gauge count G; rows assume L = 4G. Formulas: calc Reverse/guild_raid/formula.md",
           "records": gr_json}, open(os.path.join(OUT, "GUILDRAID_BOSS.json"), "w", encoding="utf-8"), ensure_ascii=False, indent=1)
GR_COLS = ["lv", "gauge", "hp", "def", "mdef", "necessary_hit", "resist_physical", "resist_magic", "guard", "avoid",
           "damage_percent", "damage_percent_desc", "necessary_flee_percent", "move_speed"]
with open(os.path.join(OUT, "GUILDRAID_BOSS.csv"), "w", encoding="utf-8-sig", newline="") as f:
    w = csv.writer(f)
    w.writerow(["boss_no", "boss_name_system", "map", "record_id", "uuid", "name_th", "role", "element", *GR_COLS,
                "proration_normal", "proration_physical", "proration_magic", "properties", "drops", "phases"])
    for g in gr_json:
        for s in g["levels"]:
            w.writerow([g["boss_no"], g["boss_name_system"], g["map"], g["record_id"], g["uuid"], g["name_th"], g["role"], g["element"],
                        *[s[c] for c in GR_COLS], g["base"]["proration_normal"], g["base"]["proration_physical"], g["base"]["proration_magic"],
                        " | ".join(f"{p['type_name'] or p['type']}{p['values']} = {p['desc_th']}" for p in g["properties"]),
                        " | ".join(f"{d['item_name']}#{d['item']}" for d in g["drops"]), " | ".join(g["phases"])])
print(len(gr_json), "guild raid records ->", os.path.join(OUT, "GUILDRAID_BOSS.json|csv"))
