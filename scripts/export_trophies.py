"""Trophies (เหรียญตรา) -> trophies/trophies.csv|json.

TrophyMaster (BynaryData), read by TrophyManager.ReadMasterData (libil2cpp 0x175EFB8):
  <i ver><I count> if ver == 2 else count = ver, then count x (<i Id><i BinaryId>[<B Type> if ver == 2]).
  BinaryId = index into the per-player state byte array the server sends (Initialize(byte[]) 0x175F2DC:
  state = bytes[BinaryId]); Type = list tab (System_th TrophyListLabel<Type>; 254 = Other).
Trophy_th (GameScene_th): <I count> + (<I trophy id><B kind><varint len><utf8>); kind 0 name, 1 reward, 2 condition.
Daily/weekly trophies (ids 10000+ / 20000+) exist only in Trophy_th: the server hands them out
(TrophyManager.InitializeDaily/InitializeWeekly), so their tab (255 daily / 253 weekly) is inferred from the id range.
Condition values and rewards exist only as text; the server holds the real counters (TrophyProgressData).
"""
import csv, json, os, struct
from export_items import latest_assets, HERE
from parse_text import varint

OUT = os.path.join(os.path.dirname(HERE), "trophies")


def parse_master(b):
    ver = struct.unpack_from("<i", b)[0]
    i, count = (8, struct.unpack_from("<I", b, 4)[0]) if ver == 2 else (4, ver)
    size = 9 if ver == 2 else 8
    assert i + size * count == len(b), (count, len(b))
    rows = []
    for k in range(count):
        tid, bid = struct.unpack_from("<ii", b, i + size * k)
        rows.append({"id": tid, "binary_id": bid, "type": b[i + size * k + 8] if ver == 2 else 0})
    return rows


def parse_text(b):
    count = struct.unpack_from("<I", b)[0]
    i, out = 4, {}
    for _ in range(count):
        tid, kind = struct.unpack_from("<IB", b, i); i += 5
        n, i = varint(b, i)
        out.setdefault(tid, {})[kind] = b[i:i + n].decode("utf-8"); i += n
    assert i == len(b)
    return out


def parse_system(b):
    count = struct.unpack_from("<I", b)[0]
    i, out = 4, {}
    for _ in range(count):
        n, i = varint(b, i); k = b[i:i + n].decode("utf-8"); i += n
        n, i = varint(b, i); out[k] = b[i:i + n].decode("utf-8"); i += n
    return out


if __name__ == "__main__":
    scene, masters = latest_assets("GameScene_th"), latest_assets("BynaryData")
    rows = parse_master(masters["TrophyMaster"])
    text = parse_text(scene["Trophy_th"])
    system = parse_system(scene["System_th"])
    known = {r["id"] for r in rows}
    for r in rows:
        r["source"] = "master"
    for tid in sorted(set(text) - known):
        rows.append({"id": tid, "binary_id": None, "type": 255 if tid < 20000 else 253, "source": "server (text only)"})
    for r in rows:
        t = text.get(r["id"], {})
        r["category"] = system.get(f"TrophyListLabel{r['type']}", "")
        r["name"], r["condition"], r["reward"] = t.get(0, ""), t.get(2, ""), t.get(1, "")
    os.makedirs(OUT, exist_ok=True)
    json.dump(rows, open(os.path.join(OUT, "trophies.json"), "w", encoding="utf-8"), ensure_ascii=False, indent=1)
    cols = ["id", "binary_id", "type", "category", "source", "name", "condition", "reward"]
    with open(os.path.join(OUT, "trophies.csv"), "w", newline="", encoding="utf-8-sig") as f:
        w = csv.DictWriter(f, cols)
        w.writeheader()
        w.writerows(rows)
    print(len(rows), "trophies,", len(known), "from master")
