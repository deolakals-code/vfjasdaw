# Heavy assets kept outside BIGDATA

Sizes as of 2026-09-29. Paths are on D:.

| Path | Size | Content |
|---|---|---|
| `D:\toram reverse data\items\models` (+ `previews`) | 1.1 GB | Item/equipment/avatar 3D models (obj/mtl/png) |
| `D:\toram reverse data\monsters\models` | 76 MB | Monster models |
| `D:\toram reverse data\NPC_Global` | 54 MB | 520 NPC models + previews |
| `D:\toram_re\world` | 2.8 GB | Field meshes, NPC models, BGM wav |
| `D:\toram_re\phone_cache` | 1.4 GB | Read-only copy of the phone's UnityCache (2,015 bundles) |
| `D:\toram_re\cdn_cache` | 77 MB | Bundles fetched from the CDN (cache layout, read by `scripts/cache.py`) |
| `D:\toram_re\apk` | 162 MB | `base.apk`, `split_config.arm64_v8a.apk`, `lib/arm64/libil2cpp.so` |
| `D:\toram_re\phone_app` | 22 MB | Phone app folder copy (`files/il2cpp/Metadata/global-metadata.dat`, ...) |
| `D:\toram_re\dump_android` | 176 MB | Il2CppDumper output (`dump.cs`, `il2cpp.h`, `script.json`, `DummyDll/`); compressed copies are in `code/` |
| `D:\toram_re\tool` | 1 MB | Il2CppDumper v6.7.46 |
| `D:\toram_re\dis_android.py` | - | capstone ARM64 disassembler (RVA = file offset + 0x4000) |

Not downloaded: the ~4,000 model/motion/BGM/field bundles in `data/cdn/catalog_A.csv` (estimate ~2.6 GB for all 5,089 bundles of channel A).
Fetch with `python -m toramre fetch plan --only model` (dry run, sizes) then `python -m toramre fetch get --only model --dest D:\toram_re\cdn_cache`
(parallel, resumable, MD5-verified; `--only all` for everything). The old `python scripts/cdn_fetch.py "<regex>" A` still works and uses the same code.
Readable files from the fetched bundles: `python -m toramre fetch export --only model --dest <cache> --out D:\toram_re\exported` (needs `pip install UnityPy`).

Anti-cheat files (`libxigncode.so`, `files/xigncode/`) exist inside the phone copies and were never analysed.
