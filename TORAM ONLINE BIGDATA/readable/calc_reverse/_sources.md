# Sources

Hashes are SHA-256 of the files as copied on 2026-09-24.

| ID | File | Size (bytes) | SHA-256 | Origin |
|---|---|---|---|---|
| S1 | `D:\toram_re\apk\lib\libil2cpp.so` | 63,412,608 | `20e5b318b1c228375ee4a4d825383fbba66538558aa15b918b8896286195c5df` | Phone `/data/app/.../com.asobimo.toramonline-.../lib/arm64/libil2cpp.so`, pulled with `adb pull -a`; APK installed 2026-09-17 15:17 |
| S2 | `D:\toram_re\phone_app\com.asobimo.toramonline\files\il2cpp\Metadata\global-metadata.dat` | 15,873,628 | `67c3392f862dfc141d4688c64d1f24a8ba980dac43ab8b2130f11f18252b2539` | Phone `Android/data/com.asobimo.toramonline/files/il2cpp/Metadata/`, copied over MTP |
| S3 | `D:\SteamLibrary\steamapps\common\Toram Online\ToramOnline_Data\il2cpp_data\Metadata\global-metadata.dat` | 28,276,368 | `e0d6c1269b603f217be7cc186cd3deee244adffda1304fbc08ccb40a614627ff` | PC (Steam) install |
| S4 | `D:\toram_re\apk\base.apk` | 41,258,065 | `f15c5f4004425681862af3b79da3781fc385fb34b0c6165bc9d9899965b3f174` | Phone, `adb pull` |
| S5 | `D:\toram_re\apk\split_config.arm64_v8a.apk` | 32,797,788 | `f50e1be142092174cab45bf7c61c62e730537804e40d450322fb4ed22b99e9b1` | Phone, `adb pull` |

Engine: Unity 2022.3.62f2 (7670c08855a9), IL2CPP, arm64-v8a, metadata version 31.

## Derived files

| ID | File | Made from | Tool |
|---|---|---|---|
| D1 | `D:\toram_re\dump_android\dump.cs`, `script.json` | S1 + S2 | Il2CppDumper v6.7.46 (`D:\toram_re\tool`) |
| D2 | `metadata\constants.tsv` (this folder's parent) | S3 | `scripts\meta_dump.py` |
| D3 | `D:\toram_re\dis_android.py` output | S1 + D1 | capstone 5.0.9, ARM64 |
| D4 | `D:\toram_re\meta_android\constants.tsv` | S2 | `scripts\meta_dump.py` with the metadata path pointed at S2 |

## Protection check on S1

| Segment | Flags | Entropy | Notes |
|---|---|---|---|
| LOAD 0x14cb94c, size 0x235d294 | R-X | 6.62 | normal ARM64 code; 142,875 `RET`; not packed |
| `.rodata` | R | 4.48 | plain |

Exports `il2cpp_init`, `il2cpp_domain_get` are present. Il2CppDumper printed "This file may be protected" (it saw `JNI_OnLoad`) but found CodeRegistration `0x3831118` and MetadataRegistration `0x38ddf78` and dumped normally.

## Note on S2 vs S3

The Android and PC metadata files differ (15.9 MB vs 28.3 MB). The nine `<PrivateImplementationDetails>` blobs used for boss difficulty were dumped from both (D4 from S2, D2 from S3) and compared: all nine are byte-identical. The code that consumes them was read from S1 (Android).
