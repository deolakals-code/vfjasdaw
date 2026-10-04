"""Every cached Npc/NpcModel/Npc_<id> bundle (fetched in full from the CDN revision table 2026-09-28,
520/520 real ids - see NOTES.md) -> NPC_Global/models/<id>.obj|mtl|png (+ previews/<id>.png).
Same custom binary model format as items/monsters (export_models.parse_model). No name/role/shop
data exists for these ids anywhere in client data - see npc_shop/README.md."""
import os, struct, sys
HERE = os.path.dirname(os.path.abspath(__file__))
sys.path.insert(0, HERE)
from decode import decode
from export_models import parse_model, write_obj, render, cached_models

BASE = os.path.dirname(HERE)
OUT = os.path.join(BASE, "NPC_Global", "models")
PREV = os.path.join(BASE, "NPC_Global", "previews")
os.makedirs(OUT, exist_ok=True)
os.makedirs(PREV, exist_ok=True)

models = cached_models({"Npc_"})
print("cached Npc_ model bundles:", len(models))
ok, fail = 0, []
for name, (script, h) in sorted(models.items()):
    try:
        textures, meshes, materials = parse_model(decode(script.encode("utf-8", "surrogateescape"), h))
    except (ValueError, IndexError, KeyError, struct.error) as e:
        fail.append((name, str(e)))
        continue
    write_obj(OUT, name, textures, meshes, materials)
    img = render(textures, meshes, materials)
    if img:
        img.save(os.path.join(PREV, name + ".png"))
    ok += 1

print(f"{ok} npc models exported, {len(fail)} failed -> {OUT}")
for f in fail:
    print("  failed", *f)
