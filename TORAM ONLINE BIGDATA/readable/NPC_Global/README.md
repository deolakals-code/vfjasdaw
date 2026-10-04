# NPC models - every NPC in the game (2026-09-28)

`Npc/NpcModel/Npc_<id>` bundles, fetched **in full from the public CDN revision table**
(`scripts/list_npc_ids.py`, queries `RevisionInfoBinary.bytes` directly) rather than only what the
local play session had cached - this is the complete list, not a partial sample: **520/520
ids downloaded** (`scripts/cdn_fetch.py "^Npc/NpcModel/Npc_"`), **520/520 exported** with 0 parse
failures (`scripts/export_npc.py`, reuses `export_models.parse_model` - same custom binary format
as item/monster models, see NOTES.md "3D models").

- `models/Npc_<id>.obj` + `.mtl` + referenced `.png` textures (one or more mesh parts per id - some
  ids are multi-piece, hence 1469 files for 520 ids).
- `previews/Npc_<id>.png` - a rendered thumbnail per id (from `export_models.render`).

## What's NOT here
No id -> **name**, **role** (shopkeeper/quest giver/decoration/companion), **map placement**, or
**shop** is recoverable from client data - see `npc_shop/README.md` for why (no `Npc_th` text table
exists at all, unlike monsters' `Enemy_th`; shop catalogs are 100% server-fetched). `Npc_<id>` here
is only a model/appearance id - the same numeric id space also covers pets, statues, mounts and
other non-talking decorative figures that use the same NpcModel format, so "520 models" is not the
same number as "520 talking NPCs".
