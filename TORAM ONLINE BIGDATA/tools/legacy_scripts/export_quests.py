import bisect, csv, json, os, re, struct, sys
import UnityPy
HERE = os.path.dirname(os.path.abspath(__file__))
sys.path.insert(0, HERE)
from decode import decode
from parse_text import varint
from cache import bundles, newest

BASE = os.path.dirname(HERE)
OUT = os.path.join(BASE, "quests")
MASTER = newest("BynaryData")
# FieldScriptCommand ids whose first operand is `00 01 <u32 quest id>`
QUEST_OPS = {30: "CheckQuest", 32: "RewardQuest", 36: "SetKeyItem", 38: "ProgressQuest", 79: "EndQuest",
             80: "RewardCheck", 81: "ViewQuest", 82: "GetKeyItem", 115: "ViewEffect", 247: "RepeatRewardQuest"}
GUILD_TYPES = {1: ("mob", 16), 2: ("item", 12), 3: ("smith", 16), 4: ("type4", 12)}


def text_assets(data):
    h = int(os.path.basename(os.path.dirname(data))[-8:], 16)
    return {ta.m_Name: decode(ta.m_Script.encode("utf-8", "surrogateescape"), h)
            for ta in (o.read() for o in UnityPy.load(data).objects if o.type.name == "TextAsset")}


def latest(bundle_glob):
    return bundles(bundle_glob)


def parse_keyed(b):
    # Quest/Mission/sc text: <I count> then <I id><B kind>[<B no> if kind] <varint len><utf8>
    count = struct.unpack_from("<I", b)[0]
    i, rows = 4, []
    for _ in range(count):
        tid, kind = struct.unpack_from("<IB", b, i); i += 5
        no = None
        if kind:
            no = b[i]; i += 1
        n, i = varint(b, i)
        rows.append((tid, kind, no, b[i:i + n].decode("utf-8"))); i += n
    if i != len(b):
        raise ValueError(f"consumed {i} of {len(b)}")
    return rows


def parse_plain(b):
    # Enemy_th / FieldName_th: <I count> then <I id><varint len><utf8>
    count = struct.unpack_from("<I", b)[0]
    i, out = 4, {}
    for _ in range(count):
        tid = struct.unpack_from("<I", b, i)[0]; i += 4
        n, i = varint(b, i)
        out[tid] = b[i:i + n].decode("utf-8"); i += n
    assert i == len(b), (i, len(b))
    return out


def master(name):
    for ta in (o.read() for o in UnityPy.load(MASTER).objects if o.type.name == "TextAsset"):
        if ta.m_Name == name:
            return decode(ta.m_Script.encode("utf-8", "surrogateescape"), int(os.path.basename(os.path.dirname(MASTER))[-8:], 16))
    raise KeyError(name)


if __name__ == "__main__":
    scene = text_assets(newest("GameScene_th"))
    fields, enemies = parse_plain(scene["FieldName_th"]), parse_plain(scene["Enemy_th"])
    items = {}
    with open(os.path.join(BASE, "items", "items.csv"), encoding="utf-8-sig") as f:
        for r in csv.DictReader(f):
            items[int(r["id"])] = r["name"]

    # field scripts: outer TextAsset decodes to an inner UnityFS bundle holding Quest_/Mission_/sc_/mob_ assets per map
    tables, scripts = {}, {}
    for bundle, data in latest("FieldScript_*").items():
        for blob in text_assets(data).values():
            for ta in (o.read() for o in UnityPy.load(blob).objects if o.type.name == "TextAsset"):
                raw = ta.m_Script.encode("utf-8", "surrogateescape")
                kind = ta.m_Name.split("_")[0]
                if kind in ("Quest", "Mission"):
                    count = struct.unpack_from("<I", raw)[0]
                    rs = (len(raw) - 4) // count if count else 16  # 16, or 17 in Quest_93500/93503 (extra trailing byte, meaning unknown)
                    assert rs in (16, 17) and len(raw) == 4 + rs * count, ta.m_Name
                    for k in range(count):
                        rid, lv, prog, start, end = struct.unpack_from("<IHHII", raw, 4 + rs * k)
                        tables[(kind.lower(), rid)] = {"order_level": lv, "startable_progress": prog,
                                                       "start_map": start, "start_map_name": fields.get(start, ""),
                                                       "end_map": end, "end_map_name": fields.get(end, ""),
                                                       "table": ta.m_Name}
                elif kind == "sc":
                    scripts[ta.m_Name] = raw

    # quest id -> [(script, event, opcode)] ; sc header: <B version><H count><count x I absolute offset>
    refs = {}
    for name, b in scripts.items():
        n = struct.unpack_from("<H", b, 1)[0]
        offs = list(struct.unpack_from(f"<{n}I", b, 3))
        for m in re.finditer(rb"\x00\x01(....)", b, re.S):
            op = struct.unpack_from("<H", b, m.start() - 2)[0] if m.start() >= 2 else -1
            if op not in QUEST_OPS:
                continue
            qid = struct.unpack("<I", m.group(1))[0]
            ev = bisect.bisect_right(offs, m.start()) - 1
            refs.setdefault(qid, {}).setdefault((name, ev), set()).add(QUEST_OPS[op])

    # scenario dialogue: sc_<map>_th, `no` = event index in sc_<map>
    dialogue = {}
    for bundle, data in latest("sc_*_th").items():
        for name, b in text_assets(data).items():
            for tid, kind, no, text in parse_keyed(b):
                key = f"{name[:-3]}/{no}" if kind else f"{name[:-3]}/names"
                dialogue.setdefault(key, []).append({"id": tid, "text": text})
    for lines in dialogue.values():
        lines.sort(key=lambda r: r["id"])

    skip = {}
    b = master("MissionSkipMaster")
    for k in range(struct.unpack_from("<I", b)[0]):
        mid, chapter, cost = struct.unpack_from("<IBI", b, 4 + 9 * k)
        skip[mid] = {"chapter": chapter, "skip_cost": cost}

    records = []
    for bundle, data in latest("*_th").items():
        m = re.match(r"(Quest|Mission)_", bundle)
        if not m:
            continue
        for b in text_assets(data).values():
            rows = parse_keyed(b)
            rec = {"type": m.group(1).lower(), "id": rows[0][0], "bundle": bundle, "name": "", "description": [], "steps": [], "texts": []}
            for _, kind, no, text in rows:
                if kind == 0:
                    rec["name"] = text
                elif kind == 1:
                    rec["description"].append(text)
                    rec["steps"].append({"no": no, "text": text})
                else:
                    rec["texts"].append({"kind": kind, "no": no, "text": text})
            records.append(rec)

    seen = {(r["type"], r["id"]) for r in records}
    for (kind, rid) in tables:
        if (kind, rid) not in seen:
            records.append({"type": kind, "id": rid, "bundle": "", "name": "", "description": [], "steps": [], "texts": []})
    for r in records:
        r.update(tables.get((r["type"], r["id"]), {}))
        if r["type"] == "mission":
            r.update(skip.get(r["id"], {}))
        else:
            r["script_events"] = [{"script": s, "event": e, "ops": sorted(ops), "dialogue_key": f"{s}/{e}"}
                                  for (s, e), ops in sorted(refs.get(r["id"], {}).items())]

    guild = []
    b = master("GuildQuestMaster")
    i = 5  # <B 0><I count>
    for _ in range(struct.unpack_from("<I", b, 1)[0]):
        uid, level, t = struct.unpack_from("<IIB", b, i); i += 9
        label, size = GUILD_TYPES[t]
        v = struct.unpack_from(f"<{size // 4}I", b, i); i += size
        row = {"uid": uid, "level": level, "type": t, "type_label": label, "target": v[0]}
        if size == 16:
            row["limit_id"], row["value"], row["flag"] = v[1], v[2], v[3]
        else:
            row["limit_id"], row["value"], row["flag"] = None, v[1], v[2]
        row["target_name"] = enemies.get(v[0], "") if t == 1 else items.get(v[0], "")
        row["limit_name"] = fields.get(v[1], "") if t == 1 else ""
        guild.append(row)
    assert i == len(b), (i, len(b))

    records.sort(key=lambda r: (r["type"], r["id"]))
    os.makedirs(OUT, exist_ok=True)
    json.dump(records, open(os.path.join(OUT, "quests.json"), "w", encoding="utf-8"), ensure_ascii=False, indent=1)
    json.dump(dialogue, open(os.path.join(OUT, "scenario_text.json"), "w", encoding="utf-8"), ensure_ascii=False, indent=1)
    json.dump(guild, open(os.path.join(OUT, "guild_quests.json"), "w", encoding="utf-8"), ensure_ascii=False, indent=1)
    cols = ["type", "id", "bundle", "name", "order_level", "startable_progress", "start_map", "start_map_name",
            "end_map", "end_map_name", "chapter", "skip_cost", "description", "keys", "script_events"]
    with open(os.path.join(OUT, "quests.csv"), "w", encoding="utf-8-sig", newline="") as f:
        w = csv.writer(f)
        w.writerow(cols)
        for r in records:
            w.writerow([r.get(c, "") for c in cols[:12]] + [
                "\n".join(f"[{s['no']}] {s['text']}" for s in r["steps"]),
                " | ".join(t["text"] for t in r["texts"] if t["kind"] == 2),
                " ".join(e["dialogue_key"] for e in r.get("script_events", []))])
    with open(os.path.join(OUT, "guild_quests.csv"), "w", encoding="utf-8-sig", newline="") as f:
        w = csv.DictWriter(f, fieldnames=list(guild[0]))
        w.writeheader(); w.writerows(guild)

    q = [r for r in records if r["type"] == "quest"]
    print(len(records), "records:", len(q), "quests,", len(records) - len(q), "missions;",
          sum("order_level" in r for r in q), "quests with level/map table;",
          sum(bool(r["script_events"]) for r in q), "with script events;",
          sum(not r["name"] for r in records), "without text;",
          len(guild), "guild quests;", sum(len(v) for v in dialogue.values()), "dialogue lines ->", OUT)
