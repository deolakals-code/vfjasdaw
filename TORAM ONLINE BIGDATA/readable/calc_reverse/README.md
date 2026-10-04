# calc Reverse — game formulas recovered from client code

Each topic has its own folder:

- `formula.md`: the formula only, written so it can be re-implemented.
- `evidence.md`: where every number comes from (file, class, method, address, raw bytes) and how it was checked.

All binaries are listed once in [`_sources.md`](_sources.md) with their hashes. Evidence files refer to them by ID (`[S1]`, `[S2]`, ...).

## Topics

| Topic | Folder | Status |
|---|---|---|
| Boss difficulty scaling (Easy / Normal / Hard / Nightmare / Ultimate) | [`boss_difficulty/`](boss_difficulty/) | Confirmed from code + one in-game check |
| Monster proration (`proration_*` columns) | [`proration/`](proration/) | Code; not checked in game |
| Dual Sword skill tree damage (all 21 skills + shared damage engine) | [`dual_sword/`](dual_sword/) | Code; not checked in game |
| Level curve (EXP to next level) + level-gap EXP multiplier | [`level_exp/`](level_exp/) | Code; gap rule read from the UI panel, server use inferred |
| Guild Raid bosses (HP by gauge count, Def/Hit by raid level) | [`guild_raid/`](guild_raid/) | Code; level inputs from the server |
| Equipment Upgrade / stat customization (smith skill 365): potential, caps, materials, success rate | [`equip_upgrade/`](equip_upgrade/) | Code (client UI math + 73-row cost table, `grant_calc.py`); roll is server-side |

## Confidence labels

- **Code**: read directly from disassembly or metadata constants. Exact.
- **In-game**: matched against a value seen in the game UI.
- **Inferred**: follows from the code but not observed (for example a unit, or behaviour on the server).

## Method (offline only)

1. Copy the Android build off the phone with adb (read-only): APK + `lib/arm64/*.so`, and `files/il2cpp/Metadata/global-metadata.dat`.
2. Check the code segment is not protection-packed (entropy, instruction counts). If it were, stop.
3. Il2CppDumper (`libil2cpp.so` + metadata) gives class layouts and method addresses.
4. Disassemble with capstone (`D:\toram_re\dis_android.py`, RVA = file offset + 0x4000).
5. Static array values come from `<PrivateImplementationDetails>` blobs stored in the metadata (dumped by `scripts/meta_dump.py` into `metadata/constants.tsv`).

The running game was never started, attached to, or modified. Anti-cheat files (`libxigncode.so`, `files/xigncode/`) were copied but not analysed.
