"""Scan every cached sc_<map> field-script for the Shop opcode (FieldScriptCommand.Shop=73).
FieldScriptManager.<OnShopCommand>d__252$$MoveNext (Android libil2cpp RVA 0x25a3d68) reads one
FieldScriptLoader.ReadInt right after the opcode -> operand is just <H opcode=73><I ShopId>.
ShopId is then compared against a few hardcoded sentinel values (9999/10002/99999/99998 seen in
disasm) that pick a UI panel kind (smith/market/etc, not fetched from data) and an NpcArchetype
lookup for the shopkeeper's look; the actual item catalog is always server-fetched via
Toram.Common.Operations.Shop.ShopGetCatalog{ShopId,Position} - never present client-side.
"""
import re, struct, sys, os
import UnityPy
HERE = os.path.dirname(os.path.abspath(__file__))
sys.path.insert(0, HERE)
from export_quests import latest, text_assets

OPCODE = struct.pack("<H", 73)

hits = []
script_bundles = {**latest("FieldScript_*"), **latest("DefenceScript"), **latest("DungeonScript"), **latest("Moba")}
print("script bundles found:", len(script_bundles), file=sys.stderr)
for bundle, data in script_bundles.items():
    for blob in text_assets(data).values():
        for ta in (o.read() for o in UnityPy.load(blob).objects if o.type.name == "TextAsset"):
            if not re.fullmatch(r"sc_\d+", ta.m_Name):
                continue
            b = ta.m_Script.encode("utf-8", "surrogateescape")
            for m in re.finditer(re.escape(OPCODE), b):
                p = m.start() + 2
                if p + 4 > len(b):
                    continue
                shop_id = struct.unpack_from("<I", b, p)[0]
                nxt = b[p + 4:p + 6].hex()
                hits.append((bundle, ta.m_Name, m.start(), shop_id, nxt))

print("total opcode-73 hits:", len(hits))
from collections import Counter
c = Counter(h[3] for h in hits)
print("distinct shop_id values:", len(c))
for shop_id, n in c.most_common(30):
    print(f"  shop_id={shop_id:10d} ({shop_id:#x})  count={n}")
print()
print("sample hits (bundle, sc_map, offset, shop_id, next2bytes):")
for h in hits[:40]:
    print(h)
