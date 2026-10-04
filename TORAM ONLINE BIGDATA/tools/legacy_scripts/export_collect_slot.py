"""RecipeMaster Type=3 (recipeType.CollectSlot) -> the free unlock chain for the
"Collect" (สะสม) item-bag tab. Writes bag/collect_slot_unlock.csv.

Framing (exact EOF match, 2072 rows; layout from the client class RecipeDBData, corrected 2026-09-30):
  header 20 bytes: RecipeId i32@0, Type u8@4, ReleaseLv i16@5, Price i32@7 (Spina),
  Difficulty i16@11, CreateId i32@13, CreateVal i16@17, Category u8@19; for CollectSlot rows
  CreateVal is the 1..50 step ordinal.
  + nmat u32 + nmat x 8-byte material (RecipeNo u8, Lv u8, Id i32, Val i16; Lv 0 = item id,
  Lv 1 = material point type). scripts/export_items.py decodes every recipe type.
Only Type==3 rows exist (50, RecipeId 130001-130050, contiguous) - no per-row
Category field distinguishes Equip/Consume: recipeType has no EquipSlot/ConsumeSlot
value, so this table only ever covers the Collect bag.
"""
import struct, csv

b = open('TORAM ONLINE BIGDATA/data/decoded/BynaryData/a7e43f32/RecipeMaster.dec', 'rb').read()
count = struct.unpack_from('<I', b, 0)[0]

items = {}
with open('items/items.csv', encoding='utf-8') as f:
    r = csv.reader(f)
    next(r)
    for row in r:
        items[int(row[0])] = row[4]

rows = []
i = 4
for _ in range(count):
    base = i
    release_lv = struct.unpack_from('<H', b, base + 5)[0]
    price = struct.unpack_from('<I', b, base + 7)[0]
    i2 = base + 20
    nmat = struct.unpack_from('<I', b, i2)[0]
    i3 = i2 + 4
    mats = []
    for k in range(nmat):
        blob = b[i3 + k * 8: i3 + k * 8 + 8]
        item_id = struct.unpack_from('<I', blob, 2)[0]
        val = struct.unpack_from('<H', blob, 6)[0]
        mats.append((item_id, items.get(item_id, '?'), val))
    i = i3 + nmat * 8
    if b[base + 4] == 3:
        rows.append(dict(recipe_id=struct.unpack_from('<I', b, base)[0],
                          seq=b[base + 17], release_lv=release_lv, price=price,
                          nmat=nmat, mats=mats))
assert i == len(b)

rows.sort(key=lambda r: r['seq'])
with open('bag/collect_slot_unlock.csv', 'w', encoding='utf-8-sig', newline='') as f:
    w = csv.writer(f)
    w.writerow(['seq', 'recipe_id', 'kind', 'release_lv', 'spina', 'materials'])
    for r in rows:
        kind = 'spina_only' if r['nmat'] == 0 else 'material'
        mats = '; '.join(f"{name} x{val}" for _, name, val in r['mats'])
        w.writerow([r['seq'], r['recipe_id'], kind, r['release_lv'], r['price'], mats])

total_spina = sum(r['price'] for r in rows)
print('wrote', len(rows), 'rows -> bag/collect_slot_unlock.csv, total spina', total_spina)
