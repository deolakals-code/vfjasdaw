# scripts/ - extraction tooling (single source tree)

All code lives here. Heavy work files (APK, `dump_android/`, per-skill recipes, caches, backups) live in the work directory
`D:\toram_re` (override: env `TORAM_WORK`; data root override: `TORAM_DATA`). Nothing in this folder may contain an address
copied from one build: functions are found by name (`script.json`), overloads by signature (`dump.cs`), layout facts by the ELF headers.

## Build-independent core

| file | role |
|---|---|
| `il2.py` | paths, ELF facts (exec segment, `OFF`), `method_rva(cls, name, sig)`, `fn(name)`, `enum_values`, `field_offset`, il2cpp stub discovery (`stub("object_new")`, ...), SHA-256 of the binary. `python il2.py` prints what it found; it raises when a structural assumption breaks. |
| `dis_android.py` | capstone disassembly + name / metadata-slot annotation (`python dis_android.py <rva or Class$$method>`) |
| `symexec.py`, `dis2.py`, `refutil.py`, `exprsimp.py`, `calc_engine.py` | symbolic executor and the expression layer |
| `emu_factory.py`, `build_factory_maps.py` | jump-table emulator; regenerates `state/_factory_map.json`, `_mastery_map.json`, `_buffer_map.json` (`--check` compares with the stored ones) |
| `fingerprint.py` | per-unit fingerprints (class + nested + base chain + constructed `*Buf` classes; GemCart buffs; stats layer) with branch targets / pages normalised away |
| `update_game.py` | the update driver (see PROJECT.md "Game update runbook"): `status`, `baseline`, `install --so --meta`, `plan`, `rebuild` |

## Pipelines

- Skills: `bash pipeline.sh` (everything) or `bash pipeline.sh --derived` (derived layers only). `PYTHONHASHSEED=0` is set so reruns are byte-identical.
- Registlet: `registlet_inputs.py` (state files) -> `build_registlet.py` (needs `emu_desc_value.py`, `gem_bonusdata.py`).
- Damage type: `build_damage_type.py` (assert-guarded hand table `DYN`).
- Data layer (bundles, masters, text): `cache.py`, `cdn_fetch.py`, `decode_all.py`, `extract_all.py`, `export_*.py`. Parsers stop on any layout change (exact-EOF rule).
- Constants: `meta_dump.py <global-metadata.dat> [outdir]` -> `constants.tsv` (adopted by `update_game.py install` unless an enum value moved).

## Character status (Details screen) - added 2026-10-03

Order: `decode_status_panel.py` (rows + Calc* helpers -> `player_status/detail_panel.json`; `--only A,B` merges single entries) -> `build_equip_buffers.py` (`equip_buffers.json`)
-> `export_status_spec.py [--golden FILE]` (`status_spec.json`; first runs `bonus_overrides.check()`) ; `measure_bonus_reach.py` (which stat line moves which row -> `bonus_reach.json`, used for `bonusRead`).
Skills / masteries / weapon element (2026-10-03): `run_masteries.py` (recipes -> `D:\toram_re\masteryrecipes`) -> `build_mastery_table.py` (`player_status/mastery_table.json`, per mastery and `MasteryId` the value at every level)
-> `redecode_stats_receivers.py` (upgrades the stat functions on disk so `GetMasteryParam` keeps its receiver; `harvest_stats.py` sets `symexec.MASTERY_RECV` for new harvests) -> `export_status_spec.py` -> `measure_mastery_reach.py` (`mastery_reach.json`: which skill moves which row).
`sweep_virtual_receivers.py` lists every virtual call of the stat functions that was decoded without its receiver (`player_status/virtual_receivers.json`); run it after any decoder change and compare the old golden (`status_golden.json`) with the new one before overwriting it.
Always run these from a Python whose first import path is this directory: `D:\toram_re` still holds older copies of `symexec.py`, `run_skills.py`, `build_variables.py`, `dis_android.py`, and `decode_status_panel.py` inserts it first (pre-import `symexec` from here, or use `runpy`, as done for `--only`).
`player_status.py` is the reference evaluator, `bonus_overrides.py` / `armour_overrides.py` / `rate_patches.py` are the hand-decoded bodies the executor cannot produce (each has an evidence assert),
`bonus_consumers.py` lists the functions that contain a BonusType id as an immediate (noisy for ids below 256: confirm by decoding).

## Calculator gaps (missing-data/08 + 09, added 2026-10-03)

- Machine form of the damage rows (08): `build_overview.py` writes `alts[].calc` (+ `calc_why`) into `skills/damage/overview/overview.json` using `damage_calc_rules.py` (rewrite of engine calls into canonical inputs) and
  `build_buff_values.canon()`; `validate_damage_calc.py` parses every string with the website's `skillExpr.js` through node, re-evaluates the level tables and writes `overview/damage_calc_residual.csv`.
  Always run build_overview with `PYTHONHASHSEED=0`; its output (display text) must stay byte-identical except for the new keys.
- Mastery verdicts (09 item 2): `mastery_readers.py` (who reads each mastery: skill consumers, decoded stat functions, direct class callers, `Dictionary<Int32Enum,object>.TryGetValue/get_Item/ContainsKey(uid)` incl. the compiler's outlined
  thunks) -> `player_status/mastery_readers.json`; `measure_mastery_reach.py` (alone, top level) -> `mastery_reach.json`; `mastery_verdict.py` (a / b / c per idle mastery, one subprocess per probe) -> `mastery_verdict.json`.
- Stat lines (09 items 3-4): `bonus_readers.py <BonusType names>` (constant-id reads through every BonusManager / EquipBuffManager accessor, tighter than `bonus_consumers.py`) -> `bonus_readers.json`; `build_unreachable_lines.py` -> `unreachable_lines.json`.
- Buffs (09 item 5): `build_buff_table.py` -> `player_status/buff_table.json` (parameters per Lv, aggregation, Details reach, stat reads, timers, songs, untabulated classes).
- Import order: the new scripts put this directory first and append `D:\toram_re`, which holds stale copies of `dis_android.py`, `symexec.py`, `build_variables.py`, `run_skills.py` (`calc_engine.py` there was re-synced on 2026-10-03: the shift operator built every result of `<< >> & | ^` for each operator).

## Legacy / one-off investigation scripts

`scan_*_callers.py`, `scan_shops.py`, `decode_cost_table.py` (now name-based), `marker_calls.py`, `skill_consumers.py` (now ELF-range based) were written for single questions.
The `scan_*_callers.py` family and a few `export_*` comments still quote RVAs of the analysed build: treat those numbers as documentation of one build, not as inputs.

## State files (`<work>/state/`)

`il2_stubs.json` (cached per binary hash), `_factory_map.json`, `_mastery_map.json`, `_buffer_map.json`, `_gemcart_*.json`, `fp_baseline.json` (fingerprints of the last fully verified build),
`fp_current.json`, `changed_units.json`, `archive/<sha8>/` (previous binary, dump, baseline), `v2_ids.txt` (skill ids `run_skills.py` decodes).
