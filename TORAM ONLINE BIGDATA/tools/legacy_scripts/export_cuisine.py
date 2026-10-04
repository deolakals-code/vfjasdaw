"""House cooking (Cuisine master) -> cuisine/cuisine.csv|json.

Cuisine: <B 0><I count> + count x 50 bytes:
  <I CuisineID><H UseFoodPoint><B ?=1><H PropertyID><B 20 = byte size of values><10 x h value per level 1..10>
  + 20 bytes, all zero in every record (Property2 slot of HouseCuisineManager.CuisineRecipeData, unused; layout not confirmed).
PropertyID uses the ItemProperty_th wording (same ids as equipment stats).
"""
import csv, json, os, struct
from export_items import latest_assets, HERE

OUT = os.path.join(os.path.dirname(HERE), "cuisine")


def prop_text(b):
    from parse_text import varint
    count = struct.unpack_from("<I", b)[0]
    i, fmt = 4, {}
    for _ in range(count):
        pid = struct.unpack_from("<i", b, i)[0]; i += 4
        n, i = varint(b, i)
        fmt[pid] = b[i:i + n].decode("utf-8"); i += n
    return fmt


def parse(b):
    assert b[0] == 0
    count = struct.unpack_from("<I", b, 1)[0]
    assert 5 + 50 * count == len(b), (count, len(b))
    rows = []
    for k in range(count):
        r = b[5 + 50 * k: 5 + 50 * (k + 1)]
        cid, food = struct.unpack_from("<IH", r)
        flag, pid, nbytes = struct.unpack_from("<BHB", r, 6)
        assert nbytes == 20 and not any(r[30:]), (cid, r[30:].hex())
        props = [{"flag": flag, "id": pid, "values": list(struct.unpack_from("<10h", r, 10))}]
        rows.append({"id": cid, "food_point": food, "props": props})
    return rows


if __name__ == "__main__":
    scene = latest_assets("GameScene_th")
    masters = latest_assets("BynaryData")
    fmt = prop_text(scene["ItemProperty_th"])
    rows = parse(masters["Cuisine"])
    for r in rows:
        for p in r["props"]:
            f = fmt.get(-p["id"] if p["values"][0] < 0 and -p["id"] in fmt else p["id"], f"#{p['id']}+{{0}}")
            p["text"] = [f.replace("{0}", str(abs(v) if p["values"][0] < 0 and -p["id"] in fmt else v)).replace("+-", "-") for v in p["values"]]
    os.makedirs(OUT, exist_ok=True)
    json.dump(rows, open(os.path.join(OUT, "cuisine.json"), "w", encoding="utf-8"), ensure_ascii=False, indent=1)
    with open(os.path.join(OUT, "cuisine.csv"), "w", newline="", encoding="utf-8-sig") as f:
        w = csv.writer(f)
        w.writerow(["cuisine_id", "food_point", "property_id"] + [f"lv{i}" for i in range(1, 11)])
        for r in rows:
            for p in r["props"]:
                w.writerow([r["id"], r["food_point"], p["id"]] + p["text"])
    print(len(rows), "cuisines")
