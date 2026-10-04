"""NPC models (custom model format, same as items), field scene meshes and BGM from the cache.
Writes D:\\toram_re\\world: npc/*.obj|mtl|png (+ previews), fields/<bundle>/*.obj|png, bgm/*.wav|ogg;
and items/event_shops.json|csv."""
import csv, json, os, struct, sys
import UnityPy
HERE = os.path.dirname(os.path.abspath(__file__))
sys.path.insert(0, HERE)
from decode import decode
from cache import bundles
from export_items import enum
from export_models import parse_model, write_obj, render, cached_models
from export_quests import latest

OUT = r"D:\toram_re\world"  # bulky wav/meshes kept off the OneDrive-synced C: drive


def inner_env(data):
    h = int(os.path.basename(os.path.dirname(data))[-8:], 16)
    for o in UnityPy.load(data).objects:
        if o.type.name == "TextAsset":
            raw = decode(o.read().m_Script.encode("utf-8", "surrogateescape"), h)
            if raw[:7] == b"UnityFS":
                yield UnityPy.load(raw)


os.makedirs(os.path.join(OUT, "npc", "previews"), exist_ok=True)
npc_ok, npc_fail = 0, []
for name, (script, h) in sorted(cached_models({"Npc_"}).items()):
    try:
        textures, meshes, materials = parse_model(decode(script.encode("utf-8", "surrogateescape"), h))
    except (ValueError, IndexError, KeyError, struct.error) as e:
        npc_fail.append((name, str(e))); continue
    write_obj(os.path.join(OUT, "npc"), name, textures, meshes, materials)
    img = render(textures, meshes, materials)
    if img:
        img.save(os.path.join(OUT, "npc", "previews", name + ".png"))
    npc_ok += 1

# ponytail: meshes written at their local origin; scene Transforms not applied, so a field is parts, not a laid-out map
field_meshes = 0
for bundle, data in sorted(latest("Field_*").items()):
    out = os.path.join(OUT, "fields", bundle)
    os.makedirs(out, exist_ok=True)
    for env in inner_env(data):
        for o in env.objects:
            if o.type.name == "Mesh":
                m = o.read()
                open(os.path.join(out, f"{m.m_Name}_{o.path_id}.obj"), "w").write(m.export())
                field_meshes += 1
            elif o.type.name == "Texture2D":
                t = o.read()
                t.image.save(os.path.join(out, f"{t.m_Name}.png"))

tracks = 0
os.makedirs(os.path.join(OUT, "bgm"), exist_ok=True)
for bundle, data in sorted(latest("BGM_*").items()):
    for env in inner_env(data):
        for o in env.objects:
            if o.type.name == "AudioClip":
                for fname, raw in o.read().samples.items():
                    open(os.path.join(OUT, "bgm", f"{bundle}_{fname}"), "wb").write(raw)
                    tracks += 1

# EventShop<n>: <B ?><H shop><B ?><I currency item> 8 bytes <H count> + count x 31:
# <H no><H ?><B RewardType><I value><I num><B ?><I price> + 13 unknown bytes. No metadata class names it.
items = {int(r["id"]): r["name"] for r in csv.DictReader(open(os.path.join(os.path.dirname(HERE), "items", "items.csv"), encoding="utf-8-sig"))}
reward_types = enum("Toram.Common.Items.RewardType")
shops = []
for bundle, data in bundles("EventShopData").items():
    h = int(os.path.basename(os.path.dirname(data))[-8:], 16)
    for o in UnityPy.load(data).objects:
        if o.type.name != "TextAsset":
            continue
        ta = o.read()
        b = decode(ta.m_Script.encode("utf-8", "surrogateescape"), h)
        cnt, cur = struct.unpack_from("<H", b, 16)[0], struct.unpack_from("<I", b, 4)[0]
        assert 18 + 31 * cnt == len(b), ta.m_Name
        entries = []
        for k in range(cnt):
            e = b[18 + 31 * k:18 + 31 * (k + 1)]
            no, _, rtype, value, num = struct.unpack_from("<HHBII", e)
            entries.append({"no": no, "type": reward_types.get(rtype, rtype), "value": value, "value_name": items.get(value, ""),
                            "num": num, "price": struct.unpack_from("<I", e, 14)[0], "raw_rest": e[18:].hex()})
        shops.append({"shop": struct.unpack_from("<H", b, 1)[0], "name": ta.m_Name, "currency": cur,
                      "currency_name": items.get(cur, ""), "entries": entries})
shops.sort(key=lambda s: s["shop"])
json.dump(shops, open(os.path.join(os.path.dirname(HERE), "items", "event_shops.json"), "w", encoding="utf-8"), ensure_ascii=False, indent=1)
with open(os.path.join(os.path.dirname(HERE), "items", "event_shops.csv"), "w", encoding="utf-8-sig", newline="") as f:
    w = csv.writer(f)
    w.writerow(["shop", "currency", "currency_name", "no", "type", "value", "value_name", "num", "price"])
    for s in shops:
        for e in s["entries"]:
            w.writerow([s["shop"], s["currency"], s["currency_name"], e["no"], e["type"], e["value"], e["value_name"], e["num"], e["price"]])

print(f"{len(shops)} event shops ({sum(len(s['entries']) for s in shops)} entries)")
print(f"{npc_ok} npc models ({len(npc_fail)} failed), {field_meshes} field meshes, {tracks} bgm tracks -> {OUT}")
for f in npc_fail:
    print("  failed", *f)
