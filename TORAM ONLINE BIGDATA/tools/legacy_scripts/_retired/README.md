# Retired scripts

Moved out of `legacy_scripts/` on 2026-10-04 because nothing imports them and they are superseded:

| File | Superseded by |
|---|---|
| `export_skills.py`, `skill_table.py` | `export_skills_full.py` (these hardcode old versions `02dc3f32` / `96613d32`) |
| `extract_all.py`, `decode_all.py`, `extract_text.py` | `tools/s1_extract_all.py` (history + nested bundles) |
| `hexview.py`, `intview.py`, `meta_header.py`, `meta_search.py`, `meta_strings.py` | one-off probes; `meta_dump.py` stays |

Shared decode / varint / text-table code now lives in `tools/common.py`.
