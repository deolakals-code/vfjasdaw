# NPC shop catalogs - not recoverable from client data

Checked 2026-09-28. There is **no client-side shop-catalog table** in this game (no `ShopMaster` in
`master_data/`, no `Npc_th` name table in `text_th/`), and this isn't a gap in what's been reversed
so far - it's structural:

- `Toram.Common.Operations.Shop.ShopGetCatalog{ShopId, Position}` /
  `ShopGetCatalogResponse{ShopId, ShopCatalog}` (metadata `all_types.txt`): the client sends the
  `ShopId` it's standing at and the **server** returns the item list live. Nothing is cached or
  baked into the client build - every NPC merchant's stock, prices and restock state are
  server-only, same pattern as house-cooking assignments, guild-raid costs and market fees
  documented elsewhere in NOTES.md.
- `FieldScriptCommand.Shop = 73` is the field-script opcode that opens the shop UI at an NPC
  (`FieldScriptManager.<OnShopCommand>d__252$$MoveNext`, Android libil2cpp RVA `0x25a3d68`).
  Disassembled 2026-09-28: it reads one `FieldScriptLoader.ReadInt` as `ShopId`, compares it against
  a handful of hardcoded sentinel values (9999/10002/99999/99998 seen in the binary) to pick which
  **UI panel kind** to open (smith/general store/etc - a fixed enum, not data) and looks the id up
  in a live `NpcArchetype` array purely to pick the shopkeeper's visual model. It never reads an
  item list - confirms the catalog truly never touches the client.
  - Tried recovering `ShopId` + location by regex-scanning every cached `sc_<map>` bytecode for the
    opcode `49 00` (u16 LE) and reading the following 4 bytes (`scripts/scan_shops.py`, 871 hits
    across 65 field-script bundles): the value distribution is noise (509 distinct values, most
    seen once, no clean small-integer IDs) because unlike `BossMenu`/`Quest` ops there's no anchor
    byte pattern to confirm real opcode boundaries, and ~300 of the game's 326 field-script opcodes
    have unknown operand sizes, so a correct sequential walk of the bytecode isn't possible without
    reversing every opcode handler first. Not worth doing: even a perfect `ShopId` extraction would
    only give a location + numeric id, never the wares (that's server-side per above) - abandoned.

## What IS recoverable: NPC models -> `NPC_Global/`
See `NPC_Global/README.md`. No name, role (merchant/quest-giver/decoration), or shop-id mapping is
recoverable for any of these models - only the 3D appearance.
