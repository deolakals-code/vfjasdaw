import csv, math, os, re, struct, sys
import UnityPy
from PIL import Image, ImageDraw
HERE = os.path.dirname(os.path.abspath(__file__))
sys.path.insert(0, HERE)
sys.path.insert(1, os.path.dirname(HERE))  # repo root: toramre
from decode import decode
from cache import bundles

OUT = os.path.join(os.path.dirname(HERE), "items")
# ItemMaster TypeId -> model bundle prefix; model id is ItemMaster u16@29
PREFIX = {7: "arms", 8: "arms", 9: "arms", 10: "arms", 11: "arms", 12: "arms", 13: "arms", 14: "arms", 15: "arms",
          16: "arms", 17: "arms", 20: "body", 21: "options", 25: "cos", 26: "cos", 27: "acce"}


from toramre.assets.toram_model import (Reader, PROP_SIZE, KIND, parse_model, default_variant, dye_tint,  # noqa: E402,F401
                                       render, write_obj)


def cached_models(prefixes):
    found = {}
    for p in prefixes:
        for d, data in bundles(p + "*").items():
            if not re.fullmatch(rf"{p}\d+", d):
                continue
            h = int(os.path.basename(os.path.dirname(data))[-8:], 16)
            for o in UnityPy.load(data).objects:
                if o.type.name == "TextAsset":
                    ta = o.read()
                    found[ta.m_Name] = (ta.m_Script, h)
    return found


if __name__ == "__main__":
    items = list(csv.DictReader(open(os.path.join(OUT, "items.csv"), encoding="utf-8-sig")))
    wanted = {f"{PREFIX[int(x['type_id'])]}{x['icon_or_model_id']}" for x in items
              if int(x["type_id"]) in PREFIX and x["icon_or_model_id"] != "0"}
    models = cached_models(set(PREFIX.values()))
    os.makedirs(os.path.join(OUT, "models"), exist_ok=True)
    os.makedirs(os.path.join(OUT, "previews"), exist_ok=True)
    done, failed = set(), []
    for name in sorted(wanted & models.keys()):
        script, h = models[name]
        try:
            textures, meshes, materials = parse_model(decode(script.encode("utf-8", "surrogateescape"), h))
        except (ValueError, IndexError, KeyError, struct.error) as e:
            failed.append((name, str(e))); continue
        write_obj(os.path.join(OUT, "models"), name, textures, meshes, materials)
        img = render(textures, meshes, materials)
        if img:
            img.save(os.path.join(OUT, "previews", name + ".png"))
        done.add(name)

    for x in items:
        t = int(x["type_id"])
        name = f"{PREFIX[t]}{x['icon_or_model_id']}" if t in PREFIX else ""
        x["model"] = f"models/{name}.obj" if name in done else ""
        x["preview"] = f"previews/{name}.png" if name in done else ""
    with open(os.path.join(OUT, "items.csv"), "w", encoding="utf-8-sig", newline="") as f:
        w = csv.DictWriter(f, fieldnames=list(items[0].keys()))
        w.writeheader(); w.writerows(items)
    print(f"{len(done)} models exported, {len(failed)} failed, {len(wanted - models.keys())} not in cache; "
          f"{sum(bool(x['model']) for x in items)} items linked")
    for f in failed:
        print("  failed", *f)
