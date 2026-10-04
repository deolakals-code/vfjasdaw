# TORAM ONLINE BIGDATA

Everything recovered offline from the Toram Online client (Unity 2022.3.62f2, IL2CPP, Android build + public asset CDN).
Snapshot built 2026-09-29. Latest master-data version: `a7e43f32` (CDN `releaseA`).

Scope: game-system data only. No anti-cheat analysis, no running/attaching to the game. See `PROJECT.md`.

## Layout

| Path | Content | Form |
|---|---|---|
| `data/decoded/<bundle>/<ver8>/**.dec` | Every TextAsset of every non-model bundle, XOR-decoded. 582 bundle-versions, 9,018 assets. `BynaryData` and `GameScene_*` keep **every** cached version (20 master versions, 2026-07-02 -> 2026-09-29). Inner bundle assets (FieldScript `Quest_/Mission_/sc_/mob_`) are stored plain, not XORed. | binary |
| `data/decoded_manifest.json` | Bundle-version -> source file, asset list, size, sha1. | json |
| `data/cdn/` | CDN version tables (`RevisionInfoBinary_A..D.bytes`) and `catalog_A..D.csv` (5,089 bundles: key, version, type, size). Channels E/F do not exist (404). | binary + csv |
| `code/` | IL2CPP dump of the Android build: `dump.cs.gz`, `il2cpp.h.gz`, `script.json.gz` (method RVAs), `stringliteral.json.gz`, constants and type lists. | gz / tsv |
| **`readable/`** | **Everything human/AI-readable. Start here.** | |
| `readable/code/cs/<assembly>/<namespace>/<Type>.cs` | `dump.cs` split into 17,958 C# declaration files (fields with offsets, method signatures with RVA). Declarations only. | .cs |
| `readable/code/{classes.json,enums.json,enums.txt,methods.tsv}` | Class/field layouts, all 1,921 enums with values, 134,714 method RVAs. | json / txt / tsv |
| `readable/csharp/ToramDecoder.cs` | C# port of the XOR decoder and localized-text reader. | .cs |
| `readable/text/<bundle>/<asset>.tsv` | Localized text tables in 6 languages (th, us, jp, kr, cnt, idn): items, skills, enemies, fields, quest/mission text, scenario text, system strings. 5,668 tables. | tsv |
| `readable/masters/` | Generic dump of the 38 master tables (`<name>.csv`, `_framing.json`, `_history.csv`). Heuristic framing only; see caveats. | csv |
| `readable/{items,monsters,quests,skills,cuisine,trophies,courses,bag,npc_shop}` | Fully parsed exports (real field names, Thai names, cross-referenced ids). | csv / json |
| `readable/calc_reverse/`, `readable/proration_calculator/` | Recovered formulas (`formula.md` + `evidence.md` per topic) and the proration simulator. | md / py |
| `readable/NOTES_original.md` | The running RE notes with every finding and its evidence. | md |
| `tools/` | Rebuild pipeline `s1..s6`, `run_all.py`, plus `legacy_scripts/` (the original exporters). | py |

## Not in this folder (too large, kept beside it)

3D models, textures, audio and raw caches live outside BIGDATA. See `MANIFEST_HEAVY.md`.

## Rebuild

```
python scripts/cdn_fetch.py "^(BynaryData|EventShopData|CommonAssetBundle)$|^FieldScript/|^Localize/" A   # refresh cache
python "TORAM ONLINE BIGDATA/tools/run_all.py"        # s1 decode -> s2 catalog -> s3 code -> s4 masters -> s5 text
python scripts/export_*.py                            # parsed exports, then re-copy into readable/
```

## Caveats

- `readable/code` is structure only. Method bodies are native ARM64 in `libil2cpp.so`; there is no C# source to recover. Disassembly is done per method with `D:\toram_re\dis_android.py`.
- `readable/masters/*.csv` frames a table as `count + fixed-width records` when the size divides exactly. That is a heuristic and can be a false positive; 12 tables are variable-width and are not framed. The authoritative parsers are the `export_*.py` scripts and the exports next to them.
- Server-side values (cooldowns, shop lists, drop rates, quest rewards) are not in the client. Skill multipliers, MP cost, range and buff values ARE in the client (`skills/damage/`). Read `PROJECT.md` "Completion rules" before any extraction task.
