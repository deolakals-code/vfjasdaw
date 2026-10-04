# Toram Online master data RE notes

Constraint: offline only. Never attach to / run the game process. Never touch GameAssembly.dll
unpacking (XIGNCODE appsign packed: real code only exists at runtime).
Widened 2026-09-24 (user): offline static analysis of the Android APK / libil2cpp.so copied to the PC is allowed,
as long as that binary is not itself protection-packed (no unpacking/bypassing of any protection layer).

## Facts
- Unity 2022.3.62f2, IL2CPP, metadata v31 (unencrypted).
- GameAssembly.dll packed by XIGNCODE-neo appsign (`.text` entropy 8.00, `.data` rsize 0, `GameAssembly.origin.dll`).
- Master data cache: `%USERPROFILE%\AppData\LocalLow\Unity\Asobimo,Inc_ToramOnline\BynaryData\<hash>\__data`
  - 5 cached versions: 02dc3f32, 20893d32, 54dc2132, 818f0832, 974e3432 (newest = 02dc3f32)
  - Standard UnityFS bundle, 38 TextAssets (SkillMaster, ItemMaster, ItemProperties, ...)
- TextAsset payloads obfuscated; first bytes of many files equal the bundle hash LE (e.g. `32 3f dc 02`).
- SkillMasterData fields (metadata order): SkillUid, SkillTreeLv, PremiseId, SkillTreeType, EqLimit,
  SkillType, AssistFlag, PremisePosId, ConnectPosId, TreePosX, TreePosY, SkillFlag, EventId.
- Metadata names of interest: Xor, XorVal, DecryptionReceiveValue, AssetDecrypt, GetAssetDecryptData.

## Obfuscation (solved)
- Per bundle version: `p[j] = c[j] ^ c[j-4] ^ hash_le[j % 4]` (c[-4..-1] = 0). `decode.py`.
- Applies to BynaryData masters and GameScene_th text assets alike.

## Formats
- SkillMaster: `<i fmt=-3><I count>` then count x 24-byte records, layout `<HHBHBHHHBBBBBBHH` (`skill_table.py`).
  Verified: uid, tier, premise_uid, tree_type, eq_limit_mask (bit1 1H sword, bit2 2H sword, bit3 bow, bit4 bowgun),
  tree_pos_x/y. Record with tier 0 = tree header (name like `#สกิลดาบ`).
- Text (`*_th`): `<I count>` then `<I id><B kind><7-bit varint len><utf8>`; Skill_th kind 0 name, 1 desc, 2 bonus notes.
- Base skill multipliers: NOT in the PC (packed) build, but RECOVERED 2026-09-29 from the unpacked Android libil2cpp - see `skills/damage/` (README.md).

## Metadata (meta_dump.py: custom v31 parser, metadata only)
- 20631 types, 99438 fields, 160321 methods, 25401 constants (enum values + consts), all decoded.
- SkillMasterData declared field order = record layout `<HHBHBHHHBBBBBBBBH` (17 fields, skill_table.py).
- Every skill has a `*Action` class with instance field `skillRate` (HardHitAction.skillRate, ...):
  no metadata default value: the values are assigned in each action's OnInitialize; recovered by symbolic execution of the Android build (skills/damage/).
- Damage pipeline enum `SkillCalcTemplate/CalcStep` (41 steps: HitCheck ... BaseDamage, SkillConstantDamage,
  Def, SkillRate, ... DamageLimit). Execution order = enum order (proven 2026-09-29: `SkillCalcTemplate.GetDamage` loops steps 0..40; kinds via
  `checkType` table: 0 constant +=, 1 rate `(int)(dmg*v)` truncated per step, 2 check, 3 guard; ExpRate(23) is a rate step,
  fed by `TemplateAssignment` -> `GetTargetExpRate`; see proration/evidence.md §10).
- Proration: `GetTargetExpRate` is the `p[slot]/100` conversion point; exhaustive `.text` scan found only the 4+3
  `CalcExpDef`/`GetExp` callers in evidence.md. CORRECTED 2026-09-29: `CalcPowerResistDamage`/`CalcMagicResistDamage`
  are pierce/resist reduction, NOT proration (the 2026-09-28 "confirmed" claim was wrong). Real `GetTargetExpRate`
  callers: `PlayerAttackBase.TemplateAssignment` + BusterLance/HolyFist/PetNormalMagic `calcPlayerToMobDamage`.
  Per-hit rule (2026-09-29, evidence.md §11, `proration_calculator/proration_hit_rules.json`): `p[slot]` changes only on
  the FIRST damaging hit of one action instance per target (`SkillActionBase.CheckHitTarget` gate in `Damaged`);
  later hits of the same action only read p. Bypass (every hit): Kunai 1219, Air Slicer 658, Homing Shot 554; custom
  checks: Magic Knife 117, MindimageSenju 159, Slash Reaper, Crazy Dagger 301. Miss = never.
  Multi-hit (evidence section 12): hits of one cast share one action instance (`GameManager.AttackDamage` ->
  `AddAttackCount` on the same action), so first-hit-only covers the whole cast. `SkillFactory.CreateSkill` decoded
  (`scripts/emu_factory.py`, 398 ids) -> `proration_calculator/skill_proration_modes.csv|json` (mode, slot, ActionID).
  See `calc Reverse/proration/evidence.md` §8-9, `proration_calculator/code_map.md` §3a (46
  `IsExpDefFluctuate`-override classes mapped by name).

## Desktop copy layout (`OneDrive\Desktop\TORAM REVERSE DATA`)
- skills/ (skills.csv, skills.json), master_data/<ver>/*.bytes|.dec, text_th/*.bytes|.dec,
  metadata/ (all_types.txt, constants.tsv, damage_calc_steps.txt, damage_related_members.txt,
  skill_action_classes.txt), bag/ (item-bag/inventory-slot data, separate from items/),
  npc_shop/ (shop-catalog findings, no data - see README), NPC_Global/ (NPC 3D models, all 520),
  scripts/ (paths hardcoded to D:\toram_re).

## Skills, round 2 (2026-09-24)
- SkillMaster parses to its exact end (631 rows incl. uid 0 dummy); cached version 818f0832 has 618 (older patch).
- `SkillFlag` column = enum `SkillFlag` bitmask (1 StarGem, 2 NoMarketSearch, 4 CanNotUse, 8 MercenaryCanUseSkill);
  checked by names (CanNotUse = merchant/system skills). `raw_flags` (exported SkillType) matches no metadata enum
  (not SkillParamFlag/SkillEqLimitFlag); groups by weapon family, meaning unknown. AssistFlag meaning unknown.
- Icons: UIIconAtlas in sharedassets0 has 459 `sk_<NNN>` + 17 `runn_*` buff icons (identical in the Steam and the Android build; no icon bundle on the CDN).
  The sprite is chosen per SkillId, not per SkillUid (2026-10-03, Code): `UIIconBase.SkillIcon` -> alias switch -> `PetSkillIcon` remap (ids 929..953) -> `sk_<id:D3>`;
  7 special cases show named sprites (370-375 -> it_100..it_600 via `ShopUtil.GetMaterialIconName`, 557 -> it_13_0, 561 -> autoaim_on, 900 -> it_501, 1284 -> it_51);
  a missing sprite shows `mapMarker_2`. `scripts/build_skill_icon_map.py` walks the method -> `skills/icon_map.json|csv`; `export_skills_full.py` saves every uid's sprite as `skills/icons/sk_<uid>.png`.
  Result: 520 of 577 tree entries have an icon (was 441). Residual 16 named skills fall back to `mapMarker_2` in the game too: 417-425 (Phalanx, JP text only), 638, 958, 959, 1247, 1281, 1282, 1285; the rest are tree headers / unreleased.
- SUPERSEDED 2026-09-29: MP cost (baseMp/costMp), range, cast-time modifiers and multipliers (*Action.skillRate/fixAddDamage) ARE in the Android code
  (per-level formulas in skills/damage/). Still server-only: cooldown values (not found), drop/ailment rolls.

- 2026-09-29 (superseded, see the end of this file): `skills/damage/explained_th/` was first hand-written; it is now fully generated.

## Output
- `out\skills.csv` / `out\skills.json` (630 records, 577 skills, 40 trees; 54 without Thai text: trees 28, 37, 39-42).

## Tools
- UnityPy 1.25.3 (pip), Il2CppDumper v6.7.46 in `tool\` (fails: packed binary; do NOT let it use the PE loader).

## Quests (export_quests.py -> quests/quests.csv|json)
- Text only, from on-demand bundles `Quest_<n>_th`, `Mission_0_th` in the Unity cache; decode key = bundle dir hash.
- decode fix: trailing `len % 4` bytes are stored plain (old decode garbled the last 1-3 bytes of every asset).
- Record: `<I id><B kind>[<B no> if kind != 0]<varint len><utf8>`. Quest kind 0 name, 1 desc, 2 key.
  Mission kind 0 `chapter@episode`, 1 desc, 2 key, 3/4 keyword item, 5 pickup field.
- Cache only holds bundles the client has downloaded: currently Quest_3/70/80/90 (261 quests) + 130 missions.
  Bundle path pattern `Localize/{lang}/Quest/Quest_{group}_{lang}` (group = id // 1000); no local manifest lists all groups.
- No EXP/reward in any client asset. MasterScenarioData = Id, OrderLevel, StartableProgress, StartMapId, EndMapId.
  Rewards arrive as `ScenarioRewardData` (RewardType, Value, Num) via server responses (QuestManager.ReceiveQuestReward).
  Script confirms it: `RewardQuest` operand is only the quest id + 1 byte; no item ids/counts near any quest reference
  (delivery/kill targets come from the server as QuestManager.ItemClearData/MobClearData).
- Kind 1 `no` = step index (quests.json `steps`).

### FieldScript (added 2026-09-24)
- `FieldScript_<n>` outer TextAsset decodes (same XOR) to an inner UnityFS bundle: per map `Quest_<map>`, `Mission_<map>`,
  `sc_<map>` (event bytecode), `mob_<map>`. Only the fields the client downloaded are cached (11 now).
- `Quest_<map>`/`Mission_<map>`: `<I count>` + 16-byte `<I id><H OrderLevel><H StartableProgress><I StartMap><I EndMap>`
  (= MasterScenarioData order). OrderLevel = min level, StartableProgress = main-story progress needed
  (mission n has n-1). Map ids resolve through GameScene_th `FieldName_th`.
- `sc_<map>`: `<B version (FieldScriptVersion.currentVersion = 17)><H n><n x I absolute event offset>`, then
  `<u16 FieldScriptCommand>` + operands; jump targets are absolute. Quest ops take `00 01 <u32 quest id>` as first operand
  (CheckQuest, RewardQuest, SetKeyItem, ProgressQuest, EndQuest, RewardCheck, ViewQuest, GetKeyItem, ViewEffect).
  Known operand sizes (bytes after opcode): End 0, Mes 4 (text id), MesUser 4 (speaker id), Next/Close 0, Goto/Break 4,
  Check 14 (`<B var><B cmp><I val><I jT><I jF>`), Set 6, ProgressQuest 6, GetKeyItem 8, SetKeyItem 10, RewardCheck 12,
  ViewQuest 14, RewardQuest 7, Warp 3, DevelopWarp 16, Switch `<B var><B n>` + n x (I value, I target),
  Menu `<B n>` + n x 8, Select `<B n>` + n x 4. Full disassembly not done (~300 opcodes, some embed strings).
- `sc_<map>_th` text: same keyed format; `no` = event index in `sc_<map>` (587/588 Mes ids in sc_3100 match).
  kind 0 = place names. Speaker ids (MesUser) not resolved to names.

### Monsters (added 2026-09-24, export_monsters.py -> monsters/)
- `mob_<map>` (inside FieldScript): `<i ver -1..-4><I map><I count>`, then count records, then drop table.
  Record: `<I id><I uuid (Enemy_th id)><B room><B len><name_jp>` + fixed 36 bytes
  `<H lv><I exp><I hp><B prorate normal/physical/magic x3><H necessaryHit><H def><H mdef><h cutAtk><h cutMatk>
  <H guard><H avoid><I flag = MobMultiFlag (4 Boss ...)><B element = ElementType><i model (-1 none)>`, then `+36 B` (size?),
  `+37 H scale %`, `+39` 3 x RGBA colours, `+51 B` move speed (inferred), `+52..55` unknown, `+56 <I n>` action patterns
  (n x P bytes, not decoded), then lists `<I k>` + k x size: ex patterns 5 (`<B idx><I id>`), modes? 35 (raw),
  properties 23 (`<B ?><H MonsterPropertyType><5 x i32>`; every type resolves in the enum).
  P / lists per version: -1 54 [5,35]; -2 54 [5,35,23]; -3 56 [5,35,23]; -4 58 [5,35,23]. Verified by walking all
  136 non-empty files to the exact byte where the drop table starts and the table to EOF.
- Drop table: `<I n>` + n x (`<I record id><I k>` + k x `<I item><i 0>`); second field always 0 in cache. No drop rates.
- ItemDorpData (master): `<I count>` + count x `<I item><I map><I mob uuid><B kind>` = per-item "obtained from" hint
  (map/mob 0 = none). Verified: 1913 of 2166 checkable rows match a cached mob drop table. No rates anywhere in the
  client -> items/item_drop_sources.csv. kind meaning unknown (0 materials, 6 Revita, 7 hairstyle unlocks...).
- Field names follow metadata class `MobStatusMaster` order; proration/resist naming is ours.
  Proration bytes = `expDefNormal/Skill/Magic`: per-hit step (start 100, clamp 50..250), decoded in `calc Reverse/proration/`. Element/flag decoding
  checked only statistically (Boss flag median HP 870k vs 13k), not in-game.
- Models: `Mob_<model>` outer TextAsset -> inner UnityFS with standard Mesh/Texture2D/Material/SkinnedMeshRenderer
  (UnityPy exports OBJ). `a_*` material = additive, `n_*` = normal. `MobMotion_<n>` = standard AnimationClips (not exported).
  Only 41 of 198 referenced model ids are cached.
- Download unit CONFIRMED 2026-09-24: entering one map (96400) pulled `FieldScript_96` holding all 24 maps of group 96
  (= every FieldName_th id with id // 1000 == 96), plus `Field_964` (scene, id // 100), `sc_96_th`, and Mob_/MobMotion_/
  Npc_/BGM_ bundles for that map only. So one visit per group gets all stats/scripts of the group; models are per map.
  No player-facing "download all": StageLoginDownloader only fetches the base set (masters, localize); System_th has
  no such option; AssetBundleManager.CreateAllDownloadList caller is in packed code.
- High Raid bosses (FieldScript_102 etc., cached 2026-09-24 by entering a raid room): records hold small base values
  (Kastheria hp 380-600, Jaruga 100-700, def/mdef 600/900) plus properties LifeGauge (5) and HighRaidStatus
  ([300, 300, x, 0, 0]); HighRaidMobBattleStatus has mobLevel, so real HP/stats are scaled at runtime by the chosen
  raid level. Formula SOLVED 2026-09-25, see High Raid levels below.
- Phone cache (2026-09-24): vivo Y27 5G over MTP, copied read-only `Android/data/com.asobimo.toramonline/files/
  UnityCache/Shared` -> `D:\toram_re\phone_cache` (2015 bundles, original mtimes kept; `files/xigncode` not touched).
  Same layout/XOR as PC. scripts/cache.py merges roots: newest mtime per bundle across roots wins (copies keep the
  phone's mtimes; TORAM_CACHE overrides). Incremental refresh without USB: Wireless debugging + `adb connect`, list
  `stat -c '%s %Y %n'` of every __data, pull only new/size-changed files with `adb pull -a` (set MSYS_NO_PATHCONV=1 in
  Git Bash or the remote path gets rewritten). 2026-09-24 13:5x: phone had newer BynaryData/GameScene_th (a7e43f32).
- Embedded endpoints (global-metadata string literals, 2026-09-24; nothing was requested from any of them):
  asset CDN base `https://toram-jp.akamaized.net/resources/` (plain literal - earlier notes wrongly said the URL only
  exists in packed code; the full bundle path/version-file naming is still built in packed code), account/auth
  `auth*.asobimo.com`, `register*`, `integration*`, `common*.asobimo.com/alive.json` (server alive check), maintenance
  `app.toram.jp/mainteinfo_staging`, push `asbpush.com`, Photon (exitgames), Unity Analytics collect, Firebase project
  `toramonline-3d774` (StreamingAssets/google-services-desktop.json). Plus test/staging twins (`*-test`, `api-test`).
- Auto-updated data already in the cache: `Steam_News_th`/`Android_News_th` (in-game news: title, text, banner png
  names, link to `th.toram.jp/information/detail_app/?information_id=N`), `Banner_th` (packed banner texture),
  `Data_th` (orb-shop/gacha catalog layout: pack names, ItemTex/Avatar bundle refs), EventShopData.
- Formulas are written up with full evidence in `calc Reverse/` (one folder per topic: formula.md + evidence.md,
  binaries and hashes in `calc Reverse/_sources.md`).
- Boss difficulty SOLVED (2026-09-24) from the Android build: APK + lib/arm64 pulled via adb to D:\toram_re\apk
  (libil2cpp.so NOT packed: exec segment entropy 6.6, 142k RET). Il2CppDumper (Android metadata) -> D:\toram_re\dump_android,
  disassembler D:\toram_re\dis_android.py (capstone; RVA = file offset + 0x4000). Class
  `Toram.Common.Rooms.BossDifficultyLevelMethods`: 10 static 5-slot arrays filled in .cctor via InitializeArray from
  <PrivateImplementationDetails> blobs (values in metadata constants.tsv), index = clamp(difficulty,-1,3)+1:
      Easy / Normal / Hard / Nightmare(Lunatic) / Ultimate
      LvRate            -10 / 0 / +10 / +20 / +40      GetLevel = max(1, lv + rate)
      HpRate            0.1 / 1 / 2 / 5 / 10           (int)(rate * hp)          <- BossMobBattleStatus.get_MaxHp
      StatusRate        0.1 / 1 / 2 / 4 / 6            (int)(rate * v)           <- get_NecessaryHit, get_Def, get_MagicDef (+ MobPartsStatus)
      AttackRate        0.5 / 1 / 2 / 4 / 6            <- MobAttackBase.CalcBaseAttack / CalcFlee
      Flinch/Tumble/StunResistRate 0,0,3,6,9 / 0,0,6,12,18 / 0,0,10,20,30   GetXResistTime = max(param, rate) <- BossMobActionManager.ResistCollection
      ExpRate           0.1 / 1 / 2 / 5 / 10;  PartsExpRate 0.1 / 1 / 1 / 1 / 1   GetExp = (int)(ExpRate*exp + PartsExpRate*partsExp)
      DropRate (int)    -90 / 0 / +100 / +200 / +400   no client getter (server-side use presumed; unit not confirmed)
  Cut/guard/avoid/element/move speed are not scaled. Verified: Krust Normal Lv178 HP 3.5M -> Ultimate Lv218 HP 35M
  (in-game). Community wiki's "Hard EXP 1.5x" disagrees with the client table (2x). -> monsters/boss_difficulty.csv.
  (Old claim "BossMenu first u16 = BossCloseDifficultyFlag" was wrong: that byte is the operand sub-version; see Boss kinds.)
- Phone app folder copied whole (2026-09-24, MTP) to `D:\toram_re\phone_app\com.asobimo.toramonline` (UnityCache is the
  `phone_cache` mirror, 1837/1837). Encryption check: Android `files/il2cpp/Metadata/global-metadata.dat` is standard
  (magic AF1BB1FA, v31, 15.9 MB, differs from PC's 28 MB file, contains BossMobBattleStatus); shader cache, Unity
  analytics config, tombstones plain; banners are PNG. `files/xigncode/*` kept but not analysed (anti-cheat).
  tombstone_00 (2026-08-19 GPU-driver crash, arm64) gives native paths: /data/app/.../lib/arm64/libil2cpp.so,
  libunity.so, libmain.so, libFirebaseCppApp, libpairipcore.so (Google Play PairIP protection - check whether it
  encrypts libil2cpp before any analysis). libil2cpp.so / APK need adb (USB debugging); MTP cannot reach /data/app.
- Brute-force scan (scripts/scan_mobs.py, 2026-09-24): every cached bundle (TextAssets raw + XOR-decoded, nested UnityFS),
  the Steam install and the APK searched for the mob record signature. Real records exist ONLY in `mob_<map>` inside
  FieldScript bundles (all other hits were 1-char false positives in text). 934/1352 Enemy_th uuids have stats; the 418
  missing ones map (via ItemDorpData) to the 22 uncached real groups 1,5,6,9,16,25,27,30,31,39,43,91,93-95,97-99,103-105,200.
  libil2cpp literals list the other script bundles that can hold mobs: `FieldScript/{DefenceScript,DungeonScript,
  BlackKnight,Moba,GuildHome,Myroom,CardGame,CraneGame,Mahjong,PetRaceGame,RhythmGame}` - none cached.
  Negative FieldName_th ids (-1..-201 groups) mirror positive maps (e.g. -24100 = 24100 Krust room); meaning unconfirmed.
- CDN (2026-09-24, user-approved; first network use of this project, public asset files only, no login/game server):
  from libil2cpp: SystemManager.GetDownloadURL = `https://toram-jp.akamaized.net/resources/` + `android/` + getResourcesDir
  (`releaseA/`..`releaseF/`, by a SystemManager field); ResourceManager.Initialize fetches `<url>RevisionInfoBinary.bytes?<ticks>`;
  AssetBundleManager.LoadCacheAssetBundle loads `<url><key>.unity3d` with the table version. Live: releaseA-D (E/F 404);
  A newest (differs from D only in FieldScript_42 + CommonAssetBundle). Table format in scripts/revision.py
  (5089 bundles). Cache dir name = 24 zeros + version as LE hex (= XOR key), so scripts/cdn_fetch.py writes
  `D:\toram_re\cdn_cache` in cache layout and cache.py reads it as a third root.
- All 62 real FieldScript groups + event bundles fetched (74 files, 3.3 MB). FieldScript/{DefenceScript, DungeonScript, Moba}
  hold mob_ files (read by export_monsters.py); BlackKnight = 2D minigame (mobAction_/MobPopPointList_), GuildHome = gsc_,
  others minigame scripts. No FieldScript_43 on the CDN (group 43 names are JP-only: unreleased).
  Result: 1290/1352 Enemy_th uuids have stats. Remaining 62: 45 `#` placeholders (10001-10044, 10100), 6 JP-only names
  (1304-1309, unreleased), 2 Potum pets (522/523), 9 old/event mobs (6, 29, 31, 56, 318, 382, 383, 1188, 1189) not in
  any script mob_ file (1188 is listed by ItemDorpData for map 40100 but mob_40100 lacks it).
- monsters/monster_full.json|csv (export_monsters.py): one entry per uuid (1353 = Enemy_th + 1272 which has no th/us name):
  names th/en/jp, model ids, every spawn record (flags, properties, drops, raw AI bytes, script_file) with `stats` = one full
  block per difficulty for Boss-flagged records (Easy..Ultimate, unscaled stats copied), else one block "-"; pet capture,
  high raid, ItemDorpData hints. Duplicates are real game data, not a parser bug: a mob_ file repeats one monster under
  several record ids/rooms (Kuzto 24100 = records 1,2,3), often byte-identical (merged in JSON: record_ids/rooms lists),
  or differing only in AI bytes / colours / scale / size (kept apart in JSON, merged in CSV with `variants` = count).
  CSV = one row per distinct (stats, drops) line per monster x difficulty (17103 rows, was 21406, 0 rows sharing
  uuid+difficulty+stats+drops): model/flags/properties/maps/records merged into lists (`maps`, `map:record_ids`).
  boss_difficulty.csv deduped the same way (26330 -> 9642).
  uuid 0 "unknown" (459 unnamed
  script objects, mostly hp 10) is JSON-only. mob_0 in FieldScript_0 / DefenceScript / DungeonScript are different
  tables (map 0 = mode-wide pool, not a field). Boss part / helper records stay their own rows (e.g. Kuzto 1001/1002 hp 18000).
  Model ids 1/2 on part records: meaning unknown.
- Mini boss: no such flag in the client. MobMultiFlag (Boss 4, Parts 8, ...) and MobFactory/MobTypeFlag (Mob, Boss,
  Dungeon, Defence, Wave, HighRaid, ...) have no mini/elite/named value; every non-Boss record uses the same bits as
  normal mobs (Earl/Riddle/Marquis Colon: flag 0, HP near their map's median). Unnamed bit 1<<29 appears on 48 records, all Boss-flagged (Yeen Dow, Grenache).
  Known field mini bosses (user-confirmed: Grylle 232, Don Yeti 237, Altoblepas 475, Trus 914) are Boss-flagged too,
  room 0, same properties/raw bytes pattern as boss-room bosses; no record field separates them. Boss rooms are
  FieldRoomType Mo (BossRoomData has DifficultyState) vs field Mmo, but the room type per map is not in any cached
  client file (FieldScript holds only mob_/sc_/Mission_/Quest_). Tried 'boss shares map+room with normal mobs':
  fails (Trus is alone; Kuzto 24101, Finstern 22103, Cerberus 13403 share rooms with normals). So export_monsters.py
  kept (superseded, see boss kinds below) a hand list MINI_BOSSES: no difficulty rows, `mini_boss` column/key. Altoblepas in arena 93503 also treated as mini.
- Boss kinds + offered difficulties SOLVED from sc_ bytecode + libil2cpp (2026-09-25; replaces the MINI_BOSSES hand list).
  BossMenu (op 130), FieldScriptManager.<OnBossMenuCommand>d__263.MoveNext (RVA 0x25949F0) reads, for script ver >= 15:
  `<B sub (14/15/16)><B -><I map><B room><H x,y,z><H rot><H -><I escMap><B room><B -><H x,y,z><I level>`
  `[sub >= 15: <B closeDifficulty>][sub >= 16: <B itemButtonHide>]`; ver 14 omits `<B sub><B ->` (close = 0); ver < 14 skipped
  (map is a short there). Anchor `ff ff` at map+13; 251/252 hits end exactly on a valid next opcode (End 155, Goto 84...).
  UIBossSymbolManager.Initialize stores closeDifficulty at +0x1CE; SetSelectDifficulty (RVA 0x191BC68) adds difficulty
  -1..3 to the selectable list only if bit k is CLEAR (tbnz) -> bit set = not offered. Values: 0 x4 + sub14 (all 5), 1 x69
  (no Easy), 3 x1 (no Easy/Normal). Offered per record: all 5 on 1116 records, no Easy on 477, Hard+ on 5.
  BossAreaLevelMenu (op 170) `<3 B (11 00 00 / 12 00 00)><I map><B room>...ff ff` = one fixed-level room per level.
  export_monsters.py `boss_kind` per record: `difficulty` (BossMenu target), `level_select` (op 170 target),
  `field_mini` (heuristic: no menu, room 0, FieldScript group < 90, HP >= 10x median of the area's (map//100) normals),
  `other` (quest/instanced/event). All 4 user-confirmed minis -> field_mini. Kind is per record (Krust: difficulty in
  24100, field_mini in 24101, level_select in 90641). monster_full.csv `mini_boss` column replaced by `boss_kind`.
- Per-difficulty stats: the client stores ONLY the Normal line; checked every difficulty room: records sharing uuid+map
  with different stats all have the same level (phases/parts, not difficulty copies). BossMobBattleStatus scales at
  runtime with BossDifficultyLevelMethods, so boss_difficulty.csv / stats blocks are that client computation, emitted
  only for the difficulties the room's BossMenu offers.
- High Raid levels SOLVED (2026-09-25, libil2cpp): these bosses have no Easy..Ultimate; the player picks a level.
  UIHighRaidEnterManager.UIInit: HighRaidEventData.GetBossMasterData(no) -> start = BaseLevel, min = MinLevel,
  max = FunctionLimitManager.GetValue(15) (server value, NOT in the client); if max <= min or min > base -> MinLevel.
  OnDifficultyUp/Down = +-5, OnDifficultySUp/SDown = +-10, clamped to [min, max]. User-observed cap 325 (Kastheria 310-325,
  Etoise 275-325, Jaruga 345 only because MinLevel 345 > cap) -> HIGH_RAID_LEVEL_CAP in export_monsters.py.
  Every record in the raid room (HighRaidBossMaster field/room) uses HighRaidBossBattleStatus (Boss) / HighRaidMobBattleStatus
  (others), same base math, float32, L = level:
      MaxHp        = (int)(k * ((L/10 + 30) * (L*L/2.4 + (L+81))) * (hp/100)),  k = 1.5 if L > 149 else 1
      NecessaryHit = (int)(L*1.5 * (nh/100))        [+ alive parts]
      Def / MDef   = (int)((def/100) * L)           [+ alive parts, x(1+buff/100), x0.5 under abnormal 10: live only]
      Cut phys/mag = (int)(L*0.04) + record cut     [+ alive parts]
      Guard/Avoid, element, level-independent stats = record values.
  Constants: 2.4 @ 0x946ffc, 0.04 @ 0x946e68 (rodata: read at RVA directly, not RVA-0x4000). HighRaidFlag property (type 32)
  ValueA bits 0..5 = FixedHp/NecessaryHit/Def/MagicDef/CutAttack/CutMagicAttack -> keep record value.
  NecessaryFleePercent 0.7 / StablePercent 0.75 under some flag (not exported). Exported as difficulty "Lv<L>" rows
  (boss_kind `high_raid`, `high_raid_levels`). Not yet checked against an in-game number.
- Monster properties (2026-09-25): 23-byte entry = MobPropertyMaster `<B UID><H MonsterPropertyType><5 x i32 ValueA..E>`.
  Meanings read from each MobProperty* class in libil2cpp (disassembly of TryGetValue/getters); MobPropertyBase.GetValue(int)
  picks the entry whose ValueA == key (ailment type, weapon ItemType, attack pattern id). export_monsters.py property_th()
  writes a Thai one-liner per property (`desc_th`, also in the CSV properties columns), tagged [code] or [data]:
    AbnormalResist(1): A ailment, chance = max(0, (int)((100-C)/100*chance) - B), extra resist time D/10 s.
    AbnormalDamageIncrease(2)/AppliedDamageIncrease(3): A ailment on the mob -> rate += B/100.
    SpecificWeaponBaseDamage(4): A weapon ItemType -> base damage rate += B/100.
    DamageLimit(5): per-hit min A / max B; D bit5 -> A,B are % of max HP; C/100 = damage-number effect scale.
    CriticalResist(6): player crit - A (x0.5 under an ailment check). MotionSpeed(10): pattern A speed 100/(100-B) (B>=100 -> 10000).
    HpLock(14): A*0.01 HP rate. DistanceResist(15): if A <= distance <= B, damage x C/100. EventCircle(17): A script flag, B range,
    C colour. ScreenEffect(18): A type, B colour, C inner, D outer range. ScriptAction(19): A MobScriptActionType (0 Hate), B, C.
    ResistMultiDamage(20): rate min(A,100)/100, count max(B,1). MotionChange(22): A..E animation ids (-1 none).
    HighRaidStatus(30): atk x A*0.01, necessary flee x B*0.01. HighRaidFlag(32): Fixed* bits. Max/MinDamageRateLimit(33/34):
    A/10000 * maxHp per hit, C/100 effect scale, B/D not decoded. LifeReduceDamage(90): guild-raid pair, min(x,A)/100 path.
  Not decoded (no class method, consumer not traced): PartCut/BodyCutCorrection(7/8), FootAttack(13), FunnelFlag(16),
  IdSetting(21), AreaHate(23), DPSLimit(31), LifeGauge(50), GuardGauge(51), TreasureHuntMobTypeData(52) -> [data] raw.
- Boss phases: MobStatusMaster.modeList = the 35-byte list (MobModeData, dump.cs TypeDefIndex 964):
  `<B modeId><h trigger><i value><i targetMonsterId><i auraModel><B auraMotion><i auraColor><i ignitionModel>
  <B ignitionMotion><i ignitionColor><i flag><h combo>`. trigger named with HyperModeTrigger (HpRate 0, DamageTime 1,
  ModeTime 2, Abnormal 5, PartBreake 6, ChildDeadCount 9, ApparentDeath 10, RecoveryWait 11...; enum match by name, not
  traced in code). targetMonsterId = record id in the same mob_ file (7998/8013 resolve): the mob switches to that
  record's whole stat line (MobHyperModeGroup holds the forms). Of the links to another record 4128 change stats
  (resists, def/mdef, guard/avoid, element, flags, hp), the rest only AI. Krust 24100: #1 -> #2 at HpRate 80, -> #3 at
  50, same stats. Mortares 40800: #1 Earth 11.11M resist 33 -> ApparentDeath -> #100 Dark 22.22M resist 66.
  HpRate value assumed "HP% at or below"; whether HP carries over or resets on a form swap is not traced.
  Exported: monsters.json `modes`, `phase_to`, `phase_from` (with `changed` stat diffs), monsters.csv / monster_full.csv
  / boss_difficulty.csv `phases` = "#from->#to Trigger=value: stat a->b".
- Missions 132-135 exist in FieldScript tables but have no Mission_0_th text yet (possibly unreleased; unconfirmed).
  Phone added 28 FieldScript groups (40 total with PC), Quest_4_th, *_us English text, EventShopData, RandamMap_.
- mob_ version 0: files with no version field (`<I map><I count>`), layout same as -1, and no drop table
  (24 files, all in group 90); one -1 file also ends without a drop table.
- EventShopData: 17 `EventShop<n>` TextAssets, `<B ?><H shop><B ?><I currency item>` + 8 bytes + `<H count>` +
  count x 31 (`<H no><H ?><B RewardType><I value><I num><B ?><I price>` + 13 unknown). All sizes fit exactly;
  no metadata class names it. -> items/event_shops.json|csv.
- export_world.py -> D:\toram_re\world (moved off OneDrive/C: 2026-09-24, 2.7 GB, wav is 1.9 GB): `Npc_<id>` = same custom model format as items (96/96 parse, reuses export_models);
  `Field_<map//100>` = inner UnityFS with standard Mesh/Texture2D (meshes exported at local origin, transforms not
  applied); `BGM_<n>` = inner AudioClip (wav). `NpcMotion_`/`MobMotion_` = AnimationClips, not exported.
- monster_index.csv: all 1352 Enemy_th names; stats exist only for uuids whose field's `mob_<map>` is cached (242).
  Boss/event stats live in the same per-field files (boss rooms, e.g. mob_3011 Lv210 5.71M HP) or in event script
  bundles (`FieldScript/DefenceScript`, `DungeonScript`, `BlackKnight`, `Moba`... per metadata paths), none cached.
- PetCaptureDataMaster: `<I count>` + (`<I MonsterUid><I ModelId><H ScaleMin><H ScaleMax><I Flag><I n>` + n x 13).
  Pattern = PetAttackPatternData/PatternData `<H motionId><H attackRate><B stable><B hitRate><b continuousAttackNum?>
  <B startSoundTiming><B attackSoundTiming><I flag = SuitableFlag>`. Parses to EOF; 452 tameable mobs -> monsters/pets.json.
- HighRaidBossMaster: `<B 0><I count>` + (`<B No><I FieldId><B RoomId><B RaidFlag><I MonsterId><I MonsterUuid>
  <H BaseLevel><H MinLevel><H n>` + n x `<B idx><I points><B RewardType><I value><I num><B order>`). 10 bosses, EOF.
  Old master_data/*.dec copies have garbled last 2 bytes (pre-fix decoder); exporters decode fresh from the cache.
- HighRaidMaterialMaster: `<B 0><I n>` + n x `<B index><I item><B count>`.
  HighRaidTrophyMaster: `<B 0><H n>` + n x `<B HighRaidNo><B TrophyId><B UnlockType><H UnlockValue><B RewardType>
  <I RewardValue><I RewardNum>` (164). -> monsters/high_raid.json.
- SummonDemonicData / HuntingOneData are EX-skill cosmetic pickers (SelectNo, Color, Model, Flag), not monsters.

### Masters
- MissionSkipMaster: `<I count>` + `<I missionId><B chapter><I skipCost>`.
- GuildQuestMaster: `<B 0><I count>` + `<I QuestUid><I Level><B type>` + type 1 mob `<I enemy><I map><I count><I flag>`,
  2 item `<I item><I count><I flag>`, 3 smith `<I item><I ?><I count><I flag>`, 4 `<I item><I count><I flag>`
  (1181 rows, parses to exact end). Type 3 second field and type 4 meaning unconfirmed; metadata class
  `UIGuildQuestBoardManager/GuildQuestMaseter` = QuestUid, ScecondaryType, Level, TargetUid, LimitId, Value, flag.
- `export_quests.py` -> quests.json/csv (+ level/map/chapter/skip cost/script events), scenario_text.json
  (dialogue keyed `sc_<map>/<event>`), guild_quests.json/csv.

## Items (export_items.py -> items/items.csv, items/icons/*.png)
- Names/descriptions: GameScene_th `Item_th`, kind 0 name, kind 1 description (empty for most equipment).
- ItemMaster: `<I count>` + count x 37-byte records. Verified: Id i32@0, SortId i32@4, TypeId i32@8 (ItemDBData/ItemType),
  Stack u16@20 (99/999), Flag i32@33 (ItemDBData/ItemFlag: Revita=AutoPortion, 2118 x CreateTrade).
  u16@29 = icon id for general items (Revita 500 -> red potion; materials 100..600), model/emote id for equipment/avatar/unlock.
  **PowerUp*Crista (249 items): u16@29 is the id of the crysta it is upgraded FROM** (checked 2026-09-24: 245/249 point at a crysta of the
  matching colour - Weapon<-WeaponRed/PowerUpWeapon, Armor<-ArmorGreen, AddEquip<-AddEquipYellow, Special<-SpecialPurple, Normal<-NormalBlue;
  chains like Sega V<-IV, VI<-V; 4 point at ids absent from the table: 14860, 14870, 14903, 14904). Not in RecipeMaster/ItemProperties.
  Inferred from data patterns, not confirmed in-game.
  **Avatars (TypeId 25/26/27): bytes 25..26 = avatar set** (checked 2026-09-24): 277 groups, 235 of them exactly 3 tops +
  3 bottoms + 6 options (one gacha lineup, colour variants A/B/C), and it links pieces whose names differ (e.g. coat /
  hat / bag of one lineup). Byte 25 = 255 -> 70 stand-alone avatars (EX, event outfits). Byte 25 runs 1..12 with ~24
  sets each - looks like a release period, not confirmed. Top id 30000+n pairs with bottom 32000+n and both carry
  model id 10n (one cos file holds the whole outfit: meshes _0/_1 top, _4/_5 bottom).
  Other bytes (12..36) unlabelled; exported raw as `raw_12_36`.
- Icons: NGUI atlas `UIIconAtlasTexture` + UIAtlas MonoBehaviour in `ToramOnline_Data/sharedassets0.assets` (no typetree;
  sprite record = string + 12 x i32: x, y (top-origin), w, h, border x4, padding x4). 126 `it_*` item icons.
- Toram has no per-item art: equipment/crysta use per-type `it_<TypeId>_0` (Katana/Halberd spelled `it_08_0`/`it_09_0`).
  Icon rule is inferred from data (GetItemIconName lives in packed code), not proven.
- Cache `Item<id>` bundles = house furniture 3D models; outer TextAsset decodes (same XOR) to an inner UnityFS bundle.
- ItemMaster u16@22 = base ATK/DEF (monotonic with tier: wood sword 10, long sword 17), u8@24 = stability % (0 for armor).
  Inferred from value patterns, not confirmed in-game.
- ItemProperties: `<I count>` + count x 44 bytes = i32 item id + 10 x (u16 prop id, i16 value). 4460 items.
- ItemProperty_th: `<I count>` + `<i id><varint len><utf8>` format strings ("STR+{0}"). Negative ids = "decrease" wording
  used when value < 0. Prop 65 = element, value = ElementType (1 fire..6 dark; matches element-advantage bonuses).
- Prop ids 200+ (consumable effects: 201 = HP heal, 245 = box contents ...) have no ItemProperty_th text; since 2026-09-24 export_items.py
  decodes them to Thai text with the game's internal name appended (`ฟื้นฟู HP 250 [hp_heal]`, `[runn_maxhp]`, `[repeatwait]`, `[item_warp]`,
  `[bRandomItemGet]`); 632 items changed, no `#id=` left. Unnamed ones stay as `name=value` (e.g. `foodPoisoning=30`).

## 3D models (export_models.py -> items/models/*.obj|mtl|png, items/previews/*.png; run after export_items.py)
- Cache bundles arms/body/cos/acce/options<group>: outer TextAsset per model, same XOR decode, custom binary (not Unity mesh).
- Model = ItemMaster u16@29 with prefix by TypeId: weapons/shield -> arms<id>, Armors -> body, AddEquip -> options,
  AvatarTop/Bottom -> cos (full-body costume), AvatarOption -> acce. ShortSword/Arrow/SpecialEquip have model id 0.
- Format: `<u8 ver 1|2><u8 nsec>` + nsec x `<u8 id><u32 off><u32 0>`. Section ids = `ModelDataType` enum (type dump):
  0 BoneId, 1 Model (meshes), 2 Material, 3 Texture, 4 BoneData, 5 Motion, 6 BillBoard, 7 RenderState, 8 Offset,
  9 DynamicBoneData, 12 RotationBoneData. Parsed: 1, 2, 3.
  Textures: `<u8 count>` x (ver1 `<u8 index>` / ver2 `<u8 index><u8 format>`, `<u16 w><u16 h>` + rows bottom-up);
  format 0 = RGB24, 1 = RGBA32 (2 models). Layout checked: all 5757 cached files end exactly on the last texel.
  Materials (2026-09-24): `<u8 count>` x (`<u8 material index><u8 MaterialDataType><u8 nprops>` + props `<u8 tag>` payload).
  MaterialDataType: 0 Skin, 1 Face, 2 Hair (no texture - character colours), 3 N_Character, 4 A_Character, 5..8 effects.
  Tags = `MaterialProperty` enum: 100 MainTexture u8 (texture index), 101 SubTexture u8, 102 RenderQueue u16 (3000/4000),
  103 Layer u16, 104/105/106 ChangeColorR/G/B RGB24 (dye palette 1..3, cf. ModelFlag NotUsePallet1..3), 107 UVSpeed u16.
  All 5757 material sections parse to their exact end. Submesh `material` byte indexes this list, NOT the texture list
  (the pre-2026-09-24 exporter assumed it did: 1434 models had parts on the wrong texture or textured skin).
  A_Character: 41% of UV-sampled texels are near-black vs 1.6% for N_Character -> RGB with black as empty, drawn
  additively (inferred from data, not from shader code).
- Variants: body/cos files hold whole characters overlapping in one space. Mesh `<name>_<n>`: pairs 0/1 torso, 4/5 legs
  (older armours also 2/3, 6/7); odd n = female build (inferred from silhouettes - narrower waist, flared skirts; no field
  says so). Armours (134 of 148 body files) prefix `h_`/`m_`/`l_` = heavy/normal/light armour mode. Exporter writes
  `o <mesh>` per mesh and `# kind <skin|face|hair|opaque|add>` per material; previews show m_ + even meshes only.
  Meshes: `<u8 count>` x (`<pstr name><u32 off><u32>`); at off: `<u16 n>`, pos 3f*n, color 4B*n, uv 2f*n,
  unknown 2f*n, `<u8 nbones>` pstr names, skin per vertex `<u8 k>` + (1 bone | k x (bone, weight%)),
  `<u8 nsub>` x (`<u8 material><u16 count>` u16 indices, triangle list). Z-up.
- 5949/5960 cached models parse; failures are old ver1 default costumes (cos0, cos10..cos90).
- UV orientation checked statistically (fewer UV hits on empty texels with bottom-up rows).
- Tooltip text is not in Item_th: the client builds it from System_th `ItemPanel*` templates (System_th format:
  `<I count>` + `<varint len><key><varint len><text>`). `tooltip` column rebuilds it: ATK/DEF line, description,
  stats, crysta slot text (`ItemPanelPropertyMaxCrista<TypeId>`), stack line, trade/sell flags.
  Verified only against an in-game crysta tooltip (Drill Golem); ordering for other types is inferred.
- ItemProperties ids 200+ are `Toram.Common.Bonus.BonusType` consumable effects (hp_heal, runn_* timed buffs with value =
  duration s, repeatwait, bRandomItemGet = box id, foodPoisoning ...). No UI text in client; Thai wording in EFFECT_TH is ours.

## House cooking (added 2026-09-25, export_cuisine.py -> cuisine/cuisine.csv|json)
- Cuisine master: `<B 0><I count>` + 50-byte records `<I id><H UseFoodPoint><B 1><H PropertyID><B 20><10 x h per level>` + 20 zero bytes. 39 dishes, parses to exact end.
  PropertyID = ItemProperty_th ids (STR..DEX, MaxHP/MP, ATK/MATK, resist, element damage, EXP/drop rate, barriers).
- Who cooked what is server-only: `HouseOtherList` (op 193/111) returns HouseEntryData {HouseId, UserName, State, UpdateDate, CuisineId};
  `CuisineSendData` {Type Main/Sub, Id, Lv, EndTime}; `AddressSearch` (193/177) maps Address -> HouseId. Not queried (live server, out of scope).

## Equipment Upgrade (added 2026-09-25, calc Reverse/equip_upgrade/)
- Smith skill 365 = client class `SmithGrant`; table `GrantData.EnhanceCost`/`EnhanceElementCost` (73 `EnhanceProperties2`
  rows) decoded from `GrantData..cctor` by `scripts/decode_cost_table.py` -> cost_table.csv. Request sends only
  itemUuid + stat types + new real values; success roll / material deduction / skill 369 are server-side.
- UI works in steps; stats 12, 22, 24, 26, 28, 30, 32 jump by OverRate per step beyond BaseMax. Formulas + simulator:
  formula.md, grant_calc.py (self-check passes). Not checked against an in-game number yet.

## Trophies / เหรียญตรา (added 2026-09-26, scripts/export_trophies.py -> trophies/)
- TrophyMaster `<i ver=2><I 653>` + `<i Id><i BinaryId><B Type>`; Trophy_th kind 0 name / 1 reward / 2 condition; tab names
  System_th `TrophyListLabel<Type>`. 653 master + 101 daily/weekly (text only, server-assigned; range split inferred).
- State byte per trophy from the server, indexed by BinaryId: 0 None, 1 Check, 2 Complete, 3 Acquired. Conditions and
  rewards exist only as text; counters are server-side. Details: trophies/README.md.

## Monthly courses (added 2026-09-26, courses/README.md)
- course1 Bag / course2 Standard / course3 Leveling. Benefit list from System_th CourseInfo; client code applies only:
  material cap x2 (course1, ShopUtil.MaterialPointMax), special storage withdraw fee max(0, 5 - active courses)%,
  bazaar logout keeps the stall, My Room switch. EXP/drop/bag/market fee are server-side (text only).
- CourseData {CourseType, ItemId, LimitDate}; items 1000219-1000232 (3/7/15/30 days); daily trophies 10224-10226.
- EXP/drop % on the status screen (UIPlayerStatusDetailPanel.CalcExpValue 0x1CB0C90) = 100 + character + TrophyExpBonus
  + OrbExpBonus (course) + event, all added; Registlet 68 Instructor -> 0. Table: courses/exp_bonus_compare.md.

## Item bag / Collect slot (added 2026-09-28)
- Player inventory has 3 tabs: `UIItemBagManager/BagType` (BagA..E, Warranty) grouped under
  `BuyNewSlotType`: Collect=0, Consume=1, Equip=2, Course=3 (`ItemDataTypev2`: Collect=0, Consume=1, Equip=2).
- Two separate unlock paths, both send `Toram.Common.Operations.Main.Item.ItemBagSlotRelease{ItemDataType, RecipeId}`
  (free, server returns `InventoryCapacity`) or `...Orb.Service.ServiceItemBagSlot{ItemDataType, UseOrb}` (paid, orb).
  Paid-orb consumables in ItemMaster (TypeId 200/OrbConsumption): 2000103 เพิ่มช่องโกดัง+5, 2000113 ขยายสล็อตกระเป๋า+1,
  2000122 ขยายโกดังสัตว์เลี้ยง, 2000132 เพิ่มช่องคอมโบ. No drop source / event-shop entry cached for these ids.
- Free path only exists for the **Collect (สะสม)** bag: `RecipeMaster` recipeType enum has Smith=0/Synthetic=1/
  Recreate=2/**CollectSlot=3**, no Equip/Consume value -> Equip and Consume bags have no monster-material/Spina
  free-unlock table in client data (orb-only, per `UIItemBagManager/BuyNewSlotType`).
- RecipeMaster.bytes framing (SOLVED 2026-09-28, `scripts/export_collect_slot.py`): `<I count>` + count x record
  (20-byte header: `<I RecipeId><B Type>` then 15 unresolved bytes incl. ReleaseLv/Price/CreateVal/Category/CanCreate,
  not fully decoded) + `<I nmat>` + nmat x 8-byte material (`<H Lv><I ItemId><H Val>`, ItemId cross-checked against
  items.csv ids, ~70% direct hit rate - rest are legit id=0 "no material" rows). Framing (H=20,W=4,M=8) is the unique
  solution that lands exactly on EOF for all 2072 rows.
- Only 50 rows have Type=3, RecipeId 130001-130050 contiguous, one single chain (offset+17 byte in each record =
  clean 1..50 step index, no gaps) - confirms this whole table is the Collect-bag-only unlock ladder, not per-category.
  10 of 50 steps (seq 3,6,10,14,18,23,28,33,39,45) have nmat=0 (Spina-only, matches System_th
  `ItemBagPanelAddCollectNoItem` = "ไม่มี"); the other 40 need 1-3 real monster-drop materials (หนัง/ขน/เกล็ด/ปีก...,
  qty escalates 1->5 as steps progress). -> bag/collect_slot_unlock.csv.
- Header fields further cracked 2026-09-28 via cross-ref against Type=0 (Smith) rows, whose CreateId/CreateVal must
  be a real item+qty: **CreateId = u16 @offset13** (100% of 1500 Smith rows resolve to a valid items.csv id) - the
  equipment the recipe smiths. **CreateVal = u8 @offset17** (=1 for 1488/1500 Smith rows -> "produce qty 1", sane).
  For CollectSlot rows CreateVal is instead exactly the step's 1-based rank (1..50, no gaps/repeats) - CreateId
  there is presumably unused/0 (no item is "created"); reused as an ordinal, not a slot-count value.
  **Price = u32 @offset7, SOLVED**: 0 for all 40 material steps (materials only, no Spina), and exactly
  1000/2000/4000/8000/16000/32000/64000/100000/200000/300000 (clean round numbers, roughly doubling) for the 10
  spina-only checkpoint steps in order -> total 727,000 Spina across the whole 50-step free Collect-bag chain.
  **ReleaseLv = u16 @offset5**: 0 for material steps, 10/18/26/34/42/51/59/69/79/87 at the checkpoints (rising
  mission/level-progress gate, matches `ItemBagPanelAddCollectNotEnoughMission`). -> bag/collect_slot_unlock.csv
  (`scripts/export_collect_slot.py`) now has spina + release_lv columns per step.
  Still not decoded: Difficulty/Category/CanCreate (offsets 11-12/14-16/18-19, all constant 0 for CollectSlot rows
  -> unused for this recipe type, so not recoverable from this table regardless).
  Base/default Collect-bag slot count before any unlock, and the total after all 50: **still not present anywhere
  in client data** (CreateVal is confirmed an ordinal, not a running slot total, and no other field carries it).
  Best available inference, not verified in-game: the paid equivalent item is literally named "ขยายสล็อตกระเป๋า+1"
  (id 2000113, +1 slot per use) and the UI text is `สล็อตสะสม {0} → {1}` (a +1 preview), so each of the 50 free
  recipes most likely also grants exactly +1 slot (max = default + 50) - but "default" itself has no client-side
  source; would need an in-game check. Equip/Consume bag default/max: no data-driven path at all (orb-shop, server-side).

## NPC models + shop catalogs (added 2026-09-28, NPC_Global/, npc_shop/)
- Shop item catalogs (what an NPC sells, price, stock): **confirmed not present anywhere in client
  data**, not a gap - `Toram.Common.Operations.Shop.ShopGetCatalog{ShopId,Position}` fetches the
  list live from the server every time, nothing is baked into the client. `FieldScriptCommand.Shop`
  (opcode 73, `FieldScriptManager.<OnShopCommand>d__252$$MoveNext`, Android libil2cpp RVA
  0x25a3d68) only reads a `ShopId` to pick a hardcoded UI panel kind + shopkeeper look, never an
  item list. Tried regex-scanning cached `sc_<map>` bytecode for the opcode anyway
  (`scripts/scan_shops.py`): noise (509 distinct "ShopId" values out of 871 hits, no anchor byte
  pattern like BossMenu's `ff ff` to confirm real opcode boundaries, ~300/326 field-script opcodes
  have unknown operand sizes so a real sequential walk isn't possible) - abandoned, see
  npc_shop/README.md for the full writeup. No `Npc_th` name/role text table exists either (unlike
  monsters' `Enemy_th`), so NPC identity (name, merchant vs quest-giver vs decoration) is not
  recoverable from static data at all.
- NPC **models** ARE recoverable and now fully exported: `Npc/NpcModel/Npc_<id>` bundles fetched in
  full from the public CDN revision table (`scripts/list_npc_ids.py`, not just locally-cached ones)
  -> **520/520 real ids**, downloaded via `scripts/cdn_fetch.py "^Npc/NpcModel/Npc_"` and exported
  with `scripts/export_npc.py` (0 parse failures) -> `NPC_Global/models/*.obj|mtl|png` +
  `NPC_Global/previews/*.png`. Same custom model format as items/monsters (export_models.parse_model).
  The id space also covers non-talking decorative figures (pets/statues/mounts), so 520 models !=
  520 talking NPCs.

## Guild Raid (added 2026-09-26, calc Reverse/guild_raid/formula.md)
- Maps 100100..100600 = one boss per element (GuildRaidBossId1..6). Boss HP depends only on the HP gauge count G:
  (Round(G^2/100,2)+50)*(T/10+30)*int(T^2/2.4+T+81), T=4G; Def/MDef/Hit scale with raid level L (server). Adds scale
  by record HP. export_monsters.py: boss_kind guild_raid, rows GR40..GR320 (L=4G and the grid are assumptions).
- New MonsterPropertyType 40 StatusCollection (A stat, B constant, C rate%), from orb random properties only.

## Skill damage / buff / mastery reference (added 2026-09-29, `skills/damage/`)
- Data root moved by the user to `D:\toram reverse data` (was OneDrive\Desktop\TORAM REVERSE DATA). Working tree stays `D:\toram_re`.
- `SkillFactory.CreateSkill(int)` (0x2396894) and `CreateMasterySkill` (0x239B19C) are jump-table switches; `scripts/emu_factory.py` decodes them:
  398 action classes (skill id -> class, 1:1) and 128 mastery classes.
- `scripts/symexec.py` = small AArch64 symbolic executor (expression trees, path forking on game-state conditions, NEON pair-of-float ops,
  interface-call naming, out-param modelling, enum naming). `run_skills.py` runs every method of every skill class (+ nested classes, helper
  methods, `*Buf` classes); `run_masteries.py` runs `GetMasteryParam`. Results reproduce the hand-derived Dual Sword formulas (17/17 checks,
  `skills/damage/VALIDATION.md`); one difference: Storm Reaper's DEX divisor is 25 in code (shift 35), notes said 100.
- Buff objects: `GetParam(int id)` ids are the `SkillBufferId` enum (NOT BonusType); duration is `LeftTime` set in the ctor; ctor overloads chain.
- Mastery: `GetMasteryParam(MasteryId)` returns the passive bonus as a function of skill level (`skillData+0x18`).
- Attack-pattern changers: no literal flag in the client; heuristic = buff class exposes `get_KnifeTakeId` / `ChangeTwinStorm` / `ChangeHyperMode` /
  `CheckPairOfShieldsTake` / `SetAttackSkillId` ... ; normal-attack modifiers = buffs looked up by `NormalAttackAction` (12 classes).
- Kunai Throwing (1219) keeps its own per-target proration table (`targetExpLit`) and reads `IMobStatusCalculator.get_ExpDefSkill`.
- Outputs: `skills/damage/README.md, INDEX.md, ROLES.md, VALIDATION.md, trees/*.md, skill_reference.json, skill_levels.csv`.

## Skill coverage pass 2 (2026-09-29, `skills/damage/COVERAGE.md`)
- Audit now covers all 577 tree entries (before: 532, the 45 unnamed entries were silently skipped). Result: 468 complete, 24 consumer-only, 85 no-client-code, 0 unresolved. Code.
- 192 `#ガードスキル`: tree-header placeholder. `SkillId` enum jumps 168 -> 193, record has max_level 0 and no text/icon. Code.
- 931 MPDrain / 951 HPDrain (pet passives): `SkillId` consts and `UIPetStatusSetAction.IsPassive` bitmask (930-932, 950-952) exist; `CreateMasterySkill` has cases 930/932/950/952 only; a scan of the whole binary for constant 931/951 (movz/cmp/sub and switch prologues, `scripts/scan_const.py`, `scan_switch.py`) finds only UI code and `SkillFactory.CreateSkill` default. Pet skill lists are server-fed (`PetSkillData`, `PetOperationManager.PetSkillLearning`). Client-inert; server behaviour Inferred/unverified.
- Consumer scan was missing `SkillBufferManager.ContainsBuffer` (96 more uids now have readers) and the symbolic filter used `[^)]*`, which stops at the nested `get_SkillManager(...)` call, so most lookups were dropped: consumer effects 166 -> 213 uids. Formulas are no longer cut at 220 chars in the pages (`render_docs.py`, `SkillLv(N)` shorthand only). Code.
- Crafting skills are not server-only: e.g. `SmithGrant.getSuccessSkillRate = (lv366>0 ? lv366+10 : 0) + max(lv365,0) + (lv367>0 ? lv367+20 : 0)`, `ProficiencyManager.getBlackSmithLimitIncreaseBySkill`, `SyntheticEquip.getRate` (shop path returns 100). Earlier "server-side (text only)" label was wrong for 18 skills. Code.
- Marker buffs: `get_Flag` constants decoded (`SkillBufferFlag` 0x400 ChangeEquipRemove, 0x800 HideBufferIcon, 0x4000 Special). Readers listed in COVERAGE.md; 714/807/1059 have none by constant id.
- Scripts copied to `scripts/`: `skill_consumers.py, run_consumers.py, build_reference.py, render_docs.py, finalize_docs.py, build_coverage.py, scan_const.py, scan_switch.py, marker_calls.py` (they still import the working tree `D:\toram_re`).

## Skill detail pages (2026-09-29, `skills/damage/DETAILS.md`, `details/`)
- `scripts/render_details.py` writes one page per tree (same split as `trees/`): a "How it works" summary (kind, MP, hit templates with Lv1 -> Lv10 endpoints, proration, ailments, buffs, passives, who else reads the skill) followed by every damage term per method, ailment/buff calls with skill ids resolved to names, buff value tables, mastery tables, level notes and consumer formulas. Nothing is truncated; raw per-method dump stays in `trees/`.
- Wording of method phases (`ActionStart`, `Damaged` ...) and parameter meanings (`AspdRate`, `CrtUp` ...) is Inferred from client names; numbers and conditions are Code.
- `render_docs.py` no longer truncates formulas/conditions on the raw pages (was 70-320 chars in several places); `SkillLv(N)` is a display shorthand only.
- `refutil.evaluate` now understands `lt gt le ge eq ne lo hs` and `c ? a : b` (lo/hs treated as signed): rate tables 122 -> 126, symbolic-only 81 -> 77, mastery level tables filled in `build_reference.process_mastery`. `validate_reference.py` still 17/17.
- Thin entries (about 30 with a decoded class but only 1-3 recovered fields: NpcHeal, HighnessHeal, Resurrection, PetHeal, several pet/tame passives) reflect thin code in the client class; heal amounts that live in shared helpers (`RecoveryAction`, pet managers) are not attached to the skill yet.
- Viewer (`viewer/toram_viewer.py`): Skills tab now has a **Details** sub-tab (the `details/` entry of the selected skill, read lazily from `skills/damage/details/*.md`), a **state** column and **Coverage** filter (from `coverage.csv`), a "search in details text" switch, and the coverage reason in Overview. `--selftest` asserts every checked skill has a detail entry (630/630 loaded). The viewer only reads generated files; rerun `scripts/render_details.py` after regenerating skills.

## Thai numeric calculation blocks (2026-09-29, `scripts/render_calc_th.py`)
- `explained_th/` pages were hand-written summaries (no generator) and dropped most per-level / per-condition numbers; one claim was wrong (AccelBlade 35 `critical` = 10xLv, Lv for 2H sword; the page said "not decoded"; fixed).
- New generator appends, under each Thai entry, a block per damage template ("hit") split by calc method and hit variable (`type`, `isFirst`, `attackCount` ...), every CalcStep with Lv1..10 values, and tables per charge / stack / hit index when a step reads `chargeLevel`, `stackLevel`, `count`, `chargeValue`, `attackCount` or the misnamed `CharacterActionManagerBase.set_DefaultMoveSpeed()` (= charge/stack level in these texts, Inferred from CrossFire/GoliathTakeShot/HeavenlyStar where the same field is set from it).
- Helpers resolved from code: `NinjaSkillBase.GetNinjutsuTraining` = SkillLv(1227) + SkillLv(1228) (0x2356734); `GetNinko` = sub weapon is NinjutsuBook ? `ItemData.Function` (short @0x42) : 0 (0x23566c4). Code.
- Residual: `CharacterActionManagerBase.get_Size()` in 24 template lines is an untraced virtual call (likely another misnamed getter). Backlog item 10 in PROJECT.md.

## Decoder fixes + formula folding (2026-09-29, round 2)
Found while checking DragonicCharge (976) against its assembly by hand. All Code; pipeline rerun end to end (run_skills with raised caps for truncated ones, orphan bufs, masteries, consumers, build_reference --all, docs, coverage 468/0 partial, validate 17/17).
- `dis2.py` / `symexec.py` field tables skipped every field whose NAME contains "const" (the filter meant `const` declarations): `constantDamage` etc. were emitted as raw offsets (`+0x124`) in 42 templates and evaluated as numbers (CrazyDagger flat damage showed 292 = 0x124; real field `constantDamage` = 200). Filter is now `\bconst\b`.
- `add/sub` with a shifted-register operand (`add w8, w9, w8, asr #1`) ignored `asr/lsr` (only `lsl` handled); `and/orr/eor` ignored all shifts. Dropped a /2 (or other shift) in 23 action classes: BusterBlade 45, SpiralAir 39, MagicArrow 97, MagicWall 99, GatlingKnife 292, FlinchKnife 300, MultipleHunt 558, ArialSlay 659, HorizontalCut 660, Ignition 715, AstralLance 734, Bless 833, CannonSpear 962, DragonicCharge 976, DimensionTill 977, BlitzPike 980, FloatingKick 1156, and internal 0/10/14/17/517/649.
- `ldr [this, xN]` with xN = csel of two field offsets (e.g. `isFirst ? targetSkillRate : rangeSkillRate`) was `?idx`; now a ternary of fields (only for offsets that name a field of the analysed class: inherited helpers stay opaque, otherwise HitReactionAssign path count explodes).
- T[] fields: element stores `str v, [arr, #0x20+k*es]`, loads `[arr, xN, lsl #k]`, `[arr+0x20+k*es]`, `[(arr + c)+off]` become `name[k]`, and values written earlier in the same method are carried. Per-hit arrays are now visible: VerticalAir 555 (3 hits: 300+45Lv/250, 200+30Lv/100, 100+15Lv/50; pierce 0, int(2.5Lv), 5Lv, x2 with an arrow), BlitzPike 980, CannonSpear 962. `physicsResist[i]` is the pierce argument of `TemplateAssignment` (6th arg; DragonicCharge passes `powerRegist` there).
- DragonicCharge 976 (hand-read, matches decoder now): first-target hit rate (500+50Lv)x(1+chargeValue/100)%, flat 300; sweep hits same rate, flat 30xLv, and the sweep replaces the Def step with -int((1 - min(max((powerRegist + bPowerResistBreaker + DragonToothResistBreaker)/2, DragonToothResistBreaker + bMagicResistBreaker)/100, 1)) x MDEF); powerRegist = 10 x int(distance m), or min(20 x distance, 100) when DragonicChargeBuf.IsWarnDetection. chargeValue = buff param 20 (Count).
- `scripts/exprsimp.py` (new): parser + folder for decoder formulas: shift/add multiplies, signed /2^k idioms, compiler magic divisions (smull/umull, negative magic, 16-bit sign fix; checked numerically), min/max ternaries, common sub-terms. Used by `render_calc_th.py`; self-test `python exprsimp.py`.
- Thai pages corrected where the old decoder or hand reading was wrong: DimensionTill flash AGI/10 (was /5), HorizontalCut part 2 AGI/2, BusterBlade DEX/2 per term + 2H STR, GatlingKnife (AGI+STR+DEX)/30 (was /15), FlinchKnife sub ATK/2 (was 2x), CrazyDagger flat 200 (was 292), MultipleHunt HighRainSnipe DEX/10, AstralLance AGI/10, Ignition ailment formula, and the `?idx` lines of 555/844/966/969/976/980.
- Residual: `CharacterActionManagerBase.get_Size()` (24 lines, untraced virtual), Ignition `skillRate = min(0, ?mi)`, AutoDeviceAttackAction 733 truncated at 6000 paths.
- Cleanup (2026-09-29): removed pre-fix snapshots from the working tree (`skill_reference.before_eval.json`, `consumer_effects.before.json`, `skill_consumers.before.json`, `refutil.before_ternary.py`, 14 applied `_patch_*.py`, ~39 MB; nothing imported them) and stale LibreOffice lock files. `TORAM ONLINE BIGDATA/readable/skills/` held a 11:47 pre-fix `skill_reference.json` (3 MB): replaced by a copy of the current `skills/`.
- Thai pages regenerated from data only (2026-09-29): `scripts/render_explained_th.py` rewrites every `explained_th/<tree>.md` from `skill_reference.json` + `coverage.csv` (header facts, in-game description, roles, MP, proration, ailment chances and types, buff durations and `GetParam` values, passive bonuses, formulas returned by consumer code such as `SmithGrant.getSuccessSkillRate`, in-game level notes); `render_calc_th.py` then adds the numeric blocks. All hand-written Thai text (with its pre-fix numbers) is gone. Tree names: the client's tree text is Japanese for most trees, so Thai names come from a fixed map in the script. Old keyword list `skills/buff_skills.md` removed (superseded by details/explained_th). README template (`finalize_docs.py`) updated: crafting skills are client-computed, raised-cap reruns, decoder fixes.


## Monster export: ambiguous record keys (2026-09-30)
- `map` = header of the `mob_` file, not a unique table: map 0 (FieldScript_0/mob_0, mob_1, DefenceScript/mob_0, DungeonScript/mob_0) and 200201 (FieldScript_200, Moba x3) each hold several tables with overlapping record ids. `(map, id)` repeated in 166 groups of monsters.csv (80 byte-identical, 86 different monsters sharing an id); `(script_file, id)` has 0 repeats. Code.
- Only the labels were ambiguous: boss_kind/phases already keyed by `script_file`, no boss in map 0/200201 gets a difficulty/level/raid kind, row counts and every stat value unchanged (JSON identical). Code.
- Fix in `export_monsters.py`: monsters.csv gains `script_file`; monster_full.csv `map:record_ids` -> `script_file:record_ids`; boss_difficulty.csv `id:room` -> `script_file:id:room`. Regenerated all of `monsters/`.

## Items export rewrite (2026-09-30, `scripts/export_items.py`, `items/README.md`)
- ItemMaster's 37 bytes are now fully named from `ItemDBData.CreateItemData` (0x21309D4): Price i32@12, MaterialLv u8@16, MaterialId u8@17, Process i16@18, Stack, Function i16@22, Stable, Range u8@25, SlotMax u8@26, Potential i16@27, Model **i32**@29, Flag. The old export read Model as u16 (79 TreasureBox/PowerUp crysta ids above 65535 were truncated; no cached model bundle is affected). `raw_12_36` dropped. Code.
- MaterialId indexes `ShopUtil.GetLocalizedMaterialName` (0x1D73474): 0 Metal, 1 Cloth, 2 Beast, 3 Wood, 4 Medicine, 5 Mana; Process = material points (data pattern, Inferred). `AvatarCategory` = Range<<8|SlotMax (types 25-27), named by `AvatarEquip_th`. Code.
- Use status (Code): bag Use button = `ItemDBData.CheckUseItem` (0x2130EB4): type 0, 1, 2, 5, 30, 50 only; equip = `CheckEquipItem` types 7..27; warp item = type 2 + first property 244, skill book = first property 246 (`OnUseItem`); warp items are refused in FieldRoomType GuildRaid(29)/ScoreAttack(40). The `[นำไปใช้ได้]` tooltip line covers types 1, 2 only (0x1B233AC). Orb-shop goods (types 52-54, 100-103, 200) go through the orb panel: Inferred.
- Enum fix: type names now come from `Toram.Common.Items.ItemType` too (4 HolyGem, 5 TreasureBox, 51 StarGem, 52-54 AMarket_*); type 200 (46 orb-shop items: Revive, World Warp, slot +1) has no enum name.
- RecipeMaster fully decoded from `RecipeDBData` (dump.cs 8521): header `<i id><B type><h releaseLv><i price><h difficulty><i createId><h createVal><B category>`, material `<B recipeNo><B lv><i id><h val>`, Lv 0 = item, Lv 1 = material point type. CORRECTS the 2026-09-28 note (CreateId u16@13, CreateVal u8@17, materials `<H Lv><I id>`, "id=0 rows are no material"): CreateId is i32 and those rows are Metal(0)/Cloth/... point costs. Recreate rows (330) use another id space for CreateId. -> `items/item_recipes.csv`.
- New files: `item_recipes.csv` (2,079), `house_items.csv` (1,292 furniture names x 6 languages, no ItemMaster record; HouseObjMaster fields still unparsed, backlog 1), `items_missing.csv` (15 ids), name columns in us/jp/kr/cnt/idn, cross-reference columns (recipes, mob drops, ItemDorpData hints, event shops, NGItem), `model`/`preview` links.
- Completeness audit: ItemMaster 11,718 vs Item_th 11,716: 6 text-only ids (9496, 9498, 9501, 9505-9507: crysta-effect placeholders, no type/price) and 8 ids with no text (3999, 90014-94014, 108553, 2000145). Mob drop table item 2628 (Sibirares, map 99100) has neither record nor text (removed item). Recipe products/materials, ItemDorpData, event shops, guild quests, high raid rewards: 0 ids outside ItemMaster.

## Raised-cap rerun of all skill recipes (2026-10-01)
- `run_skills.py` already retried truncated methods at 20000 paths / 100000 ins (PROJECT.md rule 4); full rerun of all 398 action classes finished (135 recipes changed, 33 formerly truncated uids now complete). The session died after it, before any downstream step. Code.
- Path explosion: NormalAttackAction 0 (19 MB -> 2.68 GB), ComboRelfectionAction 17 (8.7 MB -> 2.2 GB) stay truncated even at 20000 paths (3 and 1 methods); AutoDeviceAttackAction 733 (4 MB -> 576 MB) completes (12,496 distinct paths, 2 distinct field sets). 0 and 17 restored to the 2026-09-29 80-path recipes (old truncation residual kept); 733 uses the full result. `build_reference.py` / `run_orphan_bufs.py` `json.load` every recipe, so 2 GB files cannot be in `skillrecipes/`. `summarize(dedupe=True)` added in `run_skills.py` (collapses identical paths; removed nothing for 733, paths differ by condition).
- Pipeline rerun end to end (orphan bufs 133, build_reference 630 records, docs, finalize, coverage, details, explained_th, calc_th idempotent, validate 17/17, exprsimp and viewer selftest ok). `skill_consumers` / `run_consumers` not rerun (their inputs are the binary and `symexec.py`, unchanged). Coverage unchanged 468 / 24 / 85 / 0 unresolved; rate tables 126 -> 130, symbolic-only 77 -> 73; 64 of 630 reference records changed (uids 0, 9-12, 15, 17, 39, 56, 88, 292, 301, 555, 715, 733, 874, 973 ...). Ignition 715 `?mi` resolved. Code.
- Residual text markers in Thai pages: `get_Size()` 37 lines, `?mi` 20 lines (other skills). `skills/` copied over `TORAM ONLINE BIGDATA/readable/skills/`; pre-rerun reference in `D:\toram_re\backup_20261001b`.

## Variables, engine and per-skill calculation specs (2026-10-01, `skills/damage/VARIABLES.md`)
Request: the Thai pages still showed raw placeholders (Soul Hunter 1063: "marker buff", "value returned by X", `TryGetValue.out2()`, `?mi`, `get_Size()`); resolve every variable for every skill, add a viewer tab for the variables, and extract the calculation of every skill for a real damage calculator. All Code unless stated.
- Executor (`symexec.py`, `dis2.py`) upgrades: return types of calls and typed field loads (`PlayerStatusBase.get_PrimaryStatus().vit`, struct members `fixidValues.TenacityCost`, `skillBufList[1063].Count`); interface slot 0 (`mov w2, wzr`) = `IPlayerStatusCalculator.get_Lv` (was `?blr`); plain-`ldr` virtual-call idiom; `br`/`b` tail calls return the callee result; 32-bit `stp/ldp` stack pairs; static fields via `klass+0xb8` (`SacredTeachings.TargetHealSkills`); `TryGetValue` outputs as `dict[key]`, `TryGetBuf` outputs typed by the generic argument or the buffer class registered for the constant skill id; out-pointers into `this`; GC write-barrier thunk `0x165d8dc` as a field store; il2cpp `new` thunk `0x165db78` + heap model (closures, pre-index writeback); array element through a computed address; Vector3 results in s0..s2; call arguments trimmed to the declared signature; `MergeEx` (forward state merging, `sel` DAG with named `_tN` sub-expressions): TemplateAssignment 20000+ paths -> 4, calcBaseDamage 535 -> 4, whole glossary decode 2m46s / 26 MB -> seconds / 3 MB.
- Findings that corrected earlier output: `CountBufferBase`/`SoulHuntBuf` are NOT markers: stack counter `Count` (SkillBufferId 20), `Next()` = min(Count+1, Max), derived buff passes `CountBufferBase(lv, 1, 10)` -> Max = 10 (renderer filtered the parameter because the ctor value is 0). Soul Hunter 2nd-hit rate = secondSkillRate + (baseVIT//10 + 100) x Count (checked with `calc_engine`: VIT 100, 10 stacks -> 1600%). First-hit ExpRate = `targetExpList[mob.UniqueId]/100` (proration snapshot at cast), later hits `MobStatus.localExpDefMagic/100`. `SoulHuntAction.PayHp` registers `SoulHuntBuf` (not an HP cost); `SkillComboState.CheckTenacityCost/CheckBloody` also add it when `fixidValues.TenacityCost/BloodyCost >= 1`. Sacred Teachings heals only for `TargetHealSkills` = PetitHeal, Heal, NpcHeal, HighnessHeal, ClineHeal, KnightStance.
- Engine layer decoded (was only hand-summarised): ATK/MATK per weapon type (`WeaponTypeCalculatorBase.calcAtkParam` overrides, e.g. 2H sword = Lv + EqAtk + 3 STR + DEX, katana = 2.5 DEX + 1.5 STR + ...), `calcBaseDamage` (normal / dual / magic, mastery and Dual Bringer cases), TemplateAssignment terms with conditions (`engine.json`), last-damage / stability / element / pierce helpers, 51 player and 26 mob stat getters with every implementation. `SkillCalcTemplate.GetDamage` is a loop the executor cannot summarise: `engine.json` keeps the hand-verified arithmetic (label Code, RVA 0x21FF504).
- New files: `variables.json` (1,705 entries: 413 helper, 533 skill hook, 108 engine, 60 player stat, 26 mob stat, 259 skill, 83 BonusType (Thai text = ItemProperty_th, ids equal), 55 buff param, 34 mastery, 35 abnormal, 2 static arrays ...), `skill_variables.json`, `calc_spec/<uid>.json` (630 specs, 886 damage terms, 4,804 input fields), `calc_spec_index.json`, `engine.json`, `static_arrays.json` (298 arrays, 155 with values), `unresolved.csv`, `VARIABLES.md`; scripts `build_variables.py build_glossary.py build_statics.py build_engine.py build_calc_spec.py calc_engine.py decode_fn.py spec_tidy.py gloss_manual.py audit_unresolved.py pipeline.sh`.
- Viewer: new top-level **Variables** tab, **Variables** and **Calc spec** sub-tabs under Skills; `--selftest` asserts 0 dangling ids (1,705 entries, 5,383 skill-variable links).
- Thai pages: stack buffs described by their counter + Max, "value returned by X" lines replaced by hook summaries taken from the decoded definition, formula-only lines list their runtime variables with Thai meaning.
- Audit of the Thai pages before -> after (`audit_unresolved.py`): `?x` opaque 396 -> 41 (22 skills), "returned by" lines 460 -> 0, `stkp(` 79 -> 0, `TryGetValue.out2()` lookup 72 -> 0, `get_Size()` 67 -> 4, raw `[x+0xNN]` 286 -> 168, marker-buff lines 176 -> 100 (flag buffs with no parameter and no state). Damage terms with a residual marker: 0 of 886; skills with any residual marker in the spec: 59 (visual / motion fields and non-damage state). Evaluator: 5,690 formulas, 3,797 evaluate with sample leaves, 228 (4%) do not parse (residual `?undef`/raw offsets in non-damage fields).
- Regression: recipes rebuilt with the new executor (`skillrecipes/`; old output `skillrecipes_old_oct1/`), `validate_reference.py` 17/17, coverage unchanged 468 / 24 / 85 / 0, rate tables 130, symbolic-only 73. Recipes 0 / 17 / 733 keep the 80-path recipes (cap 20000 = 2.7 GB); their spec comes from the merged decode in `variables.json`. Lesson: Bash heredoc collapses a double backslash to a single one (a `\b` became a backspace byte in 4 scripts); patch scripts are written with the Write tool and scanned for control characters.


- 2026-10-01 stat layer for a damage simulator: decoded 1,164 client functions (PlayerSecondaryStatus, weapon calculators, BonusManager, MobBattleStatus variants, PlayerAttackBase / MobAttackBase helpers, NormalAttackAction) with the forward-merging executor into skills/damage/stats/decoded (STATS.md, CORE_FORMULAS.md, COVERAGE_STATS.md, SIMULATOR_INPUTS.md); 0 truncated. Executor fixes in D:\toram_re\symexec.py: float operands that were raw bit patterns (0x3f800000 -> 1.0, packed vec lane 0), magic-number division folded to //, linker veneers (ldr xN; b back) executed instead of treated as tail calls, pre-index writeback on loads, ldp second register offset (was +8 for w regs), typed out-params so virtual calls on them resolve, const-returning stubs and il2cpp isinst. Regression: skill recipes 642/643/646/33 identical; 237 differs only where the bogus name CharacterActionManagerBase.set_DefaultMoveSpeed() is now SkillBufferDataBase.GetParam(). 44 files in skillrecipes/ and 21 published skill files still carry that old artifact until the skills pipeline is rerun.

- 2026-10-01 Ghidra 12.1.4 cross-check (D:\tools\ghidra_12.1.4_PUBLIC, project D:\toram_re\ghidra_proj, names from script.json via ghidra_in\ApplyNames.java, export via ExportDecompiled.java, compare via crosscheck_stats.py): arithmetic constants identical in all 1,164 decoded functions; 927 identical callee sets, rest are collection plumbing / side-effect calls / one real hole (MobAttackBase.CalcBaseAttack tail). Bug found and fixed by the comparison: virtual calls lost their arguments (dis2.slot_params + symexec.vcall). Also fixed: unrelated-class virtual-slot guessing (vslotN), skill recipes with the bogus set_DefaultMoveSpeed/get_IsDead names 44 -> 11 files. Pipeline rerun: validate_reference 17/17, selftest ok.

- 2026-10-01 residual-gap pass (symexec.py): generic virtual method calls via 0x165da60 resolved (14 sites), delegate invocation named invoke(...), isinst receivers typed, shared-generic static calls named from the MethodInfo, il2cpp class tests no longer assumed true unless the other side is cast scaffolding (fixes MobAttackBase.CalcBaseAttack losing GetAttackRate), receivers of unknown type no longer get a guessed class name (vslotN), postfix_stats resolves [arg+0xNN] / nested / Singleton<T> / unique-subclass field reads. Final: validate_reference 17/17, 1,164 stat functions decoded, Ghidra cross-check constants 0 differences, 925/1164 identical callee sets, core 15/18. Left: boss part sums (45 sites / 16 functions, element type lost through the enumerator), one delegate in get_GuardProbability, OnInvokeBonus event.
- 2026-10-02 executor fixes in D:\toram_re\symexec.py, pipeline rerun (validate 17/17, selftest ok): `mneg` handled (was `?mneg`, uid 1059/1062 MaxHpUpRate = -(maxHp * stack)); pre-index writeback on stores to `this` (`str x1,[x20,#0x30]!`, uid 1161 GodHand `?blr`); trailing unset arg register (hidden MethodInfo*) dropped from out-param nodes (`?x4`, uid 649/290-301/797); `UnityEngine.Object.op_Equality/op_Inequality` folded when both operands are constants (dead null branch, uid 553 `?blr`). unresolved.csv opaque_q 40 -> 26. Remaining `?blr` (10) are uid 0 and 17 only: their recipes are the frozen 80-path ones (path explosion, see above), not rerun by pipeline.sh (v2_ids.txt excludes them); a rerun with MergeEx would be needed. `get_Size()` (uid 0/17/619/651) is not a gap: glossary defines it (base 0.0, EnemyMobActionManagerBase = MobStatusMaster.size byte +0x60, Halloween mob 2.0, MobaOtherPlayer 4.0, pet field +0x21c). Backups: D:\toram_re\backup_20261002, b, c.
- 2026-10-02 (b) uid 0 / 17 recipes now come from the forward-merging executor (`SYM_MERGE=1 python run_skills.py 0 17`, wired into `pipeline.sh`; 4.7 MB / 2.1 MB, 0 truncated, 0 errors; old 80-path recipes kept in D:\toram_re\skillrecipes_old_oct2). Root cause of MergeEx losing code: `fork()` on a "boring" compare (class-hierarchy depth check `cmp w10,w9; b.lo`) took the forward target, which is the cast-failure throw stub `0x165df00` (missing from STUBS), so every path ended before `SkillRate` / `ExpRate` / `LastDamageRate` / ... Fix: `0x165df00` added to STUBS and `fork()` stays on the success side when the target is scaffolding. calcPlayerToMobDamage: 25 distinct template steps (old Ex 24 + 1), 6 merged paths. Effect on skills/damage: uid 0 calc_spec 29 -> 43 terms (adds SkillRate, ExpRate, LastDamageRate, GemDamageRate, DistanceResistRate, AbnormalDamageIncreaseRate); 22 specs differ only in condition text; uid 150 Senfutsu gains 2 terms with a junk formula (`fixAddDamage[vtab(0x165da70(Enum.GetValues(...)))]`, static enum-array index not decoded). unresolved.csv opaque_q 40 -> 22, `?blr` 0. Caveat found: stats/decoded/normal/NormalAttackAction$$calcPlayerToMobDamage.json was produced with MergeEx before this fix and is missing those calls (Ghidra crosscheck lists AddRate, CalcDistanceResistRate, CalcGemLastDamageRate, GetDamage, CheckDamageLimit as call_only_ghidra); the function returns void so no formula depends on it, but the stats layer (1,164 functions) should be regenerated with the fixed symexec.py.

## Overview tab "คำอธิบายโดยรวม" (2026-10-02, `scripts/build_overview.py`, `skills/damage/overview/`, `skills/damage/overview_th/`)
Request: one place that says where each skill's damage multiplier comes from, splits values by weapon (MeteorBreaker 1H vs 2H), lists what happens while the skill runs (invincibility, damage cut such as GodHand), links buffs that other skills add (GodRigidBody -> GodHand), and shows pattern skills (Ichijhinnokaze -> four seasons). All Code unless stated.
- Generator reads `calc_spec/`, `skill_reference.json`, `skillrecipes/`, `variables.json`, `buff_owner_index.json`, `coverage.csv`; writes `overview/overview.json` (viewer) and one markdown page per tree in `overview_th/` + `README.md` (coverage, cross-check, open items) + `ENGINE.md` (rough formula, how to read an entry). Wired into `pipeline.sh` after `calc_engine.py --coverage`; `python build_overview.py --selftest` asserts MeteorBreaker weapon split + invincibility, GodHand defensive buff, GodRigidBody -> GodHand link, Ichijhinnokaze pattern.
- Weapon splits: every `when` is evaluated against a grid of main/sub weapons (main = the skill's equip limit or every weapon named in its conditions; sub = none / other / the sub weapons named). Understands `mainWeapon != X`, `(mainWeapon==X & 1) ne 0`, `ExistWeaponType`, `get_SubWeaponItemType`, `mainWeaponType & 0xfffffffe` ... through `calc_engine.Evaluator`. Per-hit variables (`isFirstAttack`, `nowAttackCount`, `damageCount` ...) are never substituted; a ternary on one of them is split into two hits; array fields show `[index]`. 67 skills split by weapon (the earlier simple matcher found 40: the `(mainWeapon==Rod & 1)` form and the numeric forms were missed, e.g. MagicBlast Rod/Magictool).
- MeteorBreaker (44): first hit 400 + 20 Lv (1H) vs 600 + 20 Lv + STR/10 (2H); range hit 100 + 50 Lv (2H, dual 1H+1H) vs 100 + 50 Lv + DEX/2 (1H, sub not 1H); Dizzy chance int(0.5 Lv) + 2 Lv (+75 with 1H); `AddInvincibilityTemporarilyInAction(2)` in ActionStart, removed at the end of the action (the argument is the cap in seconds).
- Invincibility family decoded from the recipes: `AddInvincibilityTemporarilyInAction(t)`, `AddTimeInvincibility(t, ...)`, `AddSkillMotionInvincibility` / `AddMotionInvincibility`, `IllusionarySceneBuf` super armor, `IsSkillGuard`. 20 skills. Cross-check with in-game text: 11 skills say invincible, 8 have the call; Shift (1039) and ImprovisationSong (773) are applied by engine hooks that read the buff (`PlayerActionManager.Damaged`, `MobAttackBase.CalcLastDamage`); GodSpearHandling (978) was found outside its own action: `HandlingerOfGodspeedBuf.DamageFunction` -> `GodSpearHandlingMastary.CheckEffectiveIveinvincible` (chance = int(AGI / 3.5) + 2 Lv + 10 %, Halberd main weapon, once per 10 s) -> `AddTimeInvincibility(2)`.
- Action flags `IsInterruptable`, `IsHitRigidity`, `IsMoveAssistContinue` decoded for all 468 action classes with `D:\toram_re\harvest_action_flags.py` (-> `overview/action_flags.json`; "inherit" = no override). Meaning is read from the names only (Inferred).
- GodHand (1158) / GodRigidBody (1161): GodRigidBody is read by `GodHandBuf..Initalize` / `DeathExemption` (one survive-lethal-hit charge per buff), `GoliathTakeShotAction.EnemyDamage`; its mastery gives `CutDmgRate` 90 (`MobLastDamageRateBuf` of GodHandBuf while `isSkillEnd = 0`) and `Value` = 5 Lv (AbnormalRegist). GodHandBuf `damageDownRate` (-> `MobLastDamageRateUnique`): lv 7 -> 45, 8 -> 57, 9 -> 72, others 90 (non-monotonic, kept as decoded). `MobAttackBase.CalcLastDamage` keeps the larger of several cut sources (`a >= b ? a : b`), Inferred.
- Ichijhinnokaze (629 -> action 637): modes A/B/C (NowAttackMode 0/1/2); five moves Nagi / Kariwatashi / Hibari / Ibuki / Arahae with rates 500 + 50 Lv, 400 + 20 Lv + max(300 - 150 mode, 0), 600 + 30 Lv + 100 mode, 300 + 60 Lv + 50 mode, 500 + 20 Lv + 150 mode (+ Aratame 631: 50 / 30 / 45 / 45 / 35 per Lv); Setsunakenran (= "four seasons", name match Inferred) adds +1200 / +1550 / +1450 / +1350 to moves 2-5 and needs a katana, `UnannouncedDestination` active and `activeSkill == 3`. The key sequence that sets `activeSkill = 3` is not decoded.
- Viewer: new top-level tab "คำอธิบายโดยรวม" (search, tree filter, flags W weapon split / I invincible / D damage cut / L link / P variants / T damage terms, "ไปแท็บ Skills", ENGINE.md button); `--selftest` checks MeteorBreaker text and the weapon filter.
- Stats layer regenerated with the fixed executor (see 2026-10-02 (b)): `calcPlayerToMobDamage` now has AddRate / CalcDistanceResistRate / CalcGemLastDamageRate / CheckDamageLimit; GetDamage stays hand-verified in `engine.json`; 1,164 functions, 0 truncated, crosscheck 15/18 identical callee sets, validate 17/17; backup `D:\toram_re\stats_decoded_backup_oct2`.
- Residual (README of `overview_th`): raw `+0x..` offsets in 4 skills' buff formulas (89, 158, 773 ...), `?x` markers (865), name variants other than Ichijhinnokaze not split, meaning of `IsInterruptable` / `IsHitRigidity` / `MobLastDamageRate*` units not verified in game.
- Lesson: the Bash tool collapses `\\` to `\` even inside quoted heredocs; Python patch scripts that held regexes produced `\x01` / `\x08` (in names_th and a `\bLv\b`). Patch scripts are written with the Write tool; a repair script uses `chr(92)`; control characters are scanned after every patch.

## Buff values followed to the end (2026-10-02, `scripts/build_buff_values.py`, `skills/damage/buff_values.json`, `BUFF_VALUES.md`)
Request: buff parameters and durations shown only as a field name (`criticalDamage`, `time`, `equip`) had to be resolved from the source, not left as "not found". All Code unless stated.
- Where the numbers live: a buff class constructor stores its arguments and computes fields from them (class, then base classes: `CircleBufferBase` LeftTime = 900 if self else `time`, `CountBufferBase` stack cap, `SongBufferBase` has none); the skill's own action and other classes pass the arguments (`XBuf..ctor(Lv, WeaponType)`, `AddSelfBuffer(id, lv, time, val, localId)` - with three arguments the third is the local id); runtime fields are assigned in the buff's own methods (`Active...`, `OnDamage`) and are alternatives "@Method". Call sites: skill_reference methods + variables.json skill hooks.
- The script substitutes those definitions into each formula and decides per (skill, buff class, parameter) and per duration: table (Lv only), cases (one table per caster weapon type / sub weapon / yes-no flag / stack count / an argument compared with constants), formula (needs the caster's stats or the skill's state: expanded, variables listed), none (timer: no LeftTime in the class chain; the buff ends by an event), open. `LeftTime = time` is taken from the creating call (calls that pass 0 or the old LeftTime are refreshes). Equipment reads are normalised: `get_WeaponItemType`, `[WeaponTypeCalculatorBase.item+0x38]`, `TryGetValue(equipItem, 1|2).Type` = main / sub weapon type (slot numbering Inferred from the types compared: Magictool, Shield).
- Coverage (tree skills, 166 buff skills): parameters 474 = table 119 + cases 130 + formula 225; timers 250 = none 136, table 64, cases 12, formula 32, open 6. GodHand `damageDownRate` is a table by skill level: 7 -> 45, 8 -> 57, 9 -> 72, otherwise 90 (`ls` in the decoder text is "less or same"; an earlier note here that the conditions could never hold was wrong). What the number means in game is not confirmed.
- Residual, by reason: formulas that need the caster's stats / equipment refine / skill levels / bonuses (PlayerStatusBase, EquipItemData, SkillMasteryBase ~ 100 parameters, genuinely player-dependent); fields assigned through a raw object offset the decoder cannot name (`[buf+0x20]`, e.g. KnifeCombatBuf.crtUp; offsets are in `D:\toram_re\dump_android\dump.cs`, a class-offset map is the next step); timers handed in by the song / dance / circle system (6 buffs, Fairy/Passion/Sharp/Enchanted Dance, StoneSkin).
- Run: `cd D:\toram_re && python "D:\toram reverse data\scripts\build_buff_values.py"` (25 s, `--selftest`). `scripts/pipeline.sh` does not call it yet.

## Buff calculator form (2026-10-02, `scripts/build_buff_values.py`, website `db.skillCalc`)
Request: a buff value that depends on the caster's stats (`max(int(STR / 50 x Lv), Lv)`, Arrow Sharpening) should come out as a number, automatically, not stay a formula. Done as a calculator: every `formula` record of `buff_values.json` now carries `calc` = per alternative the expanded expression `e` and its conditions `w` with variables renamed to canonical inputs (`STR_base` allocated, `STR_total` incl. gear/buffs, `PlayerLv`, `Refine_main|sub`, `SkillLv_<uid>`, `Mastery_<id>`, `Bonus_<name>`, `WeaponType`/`SubWeaponType` item type, flags `is*`/`self`, plain runtime numbers as `state` inputs), plus `inputs` {kind, th}. A condition made of buff-method plumbing (`@Method`, instance checks) is kept as text (`wt`) beside the value; an expression with a decoder residual (`[x+0x24]`, `?sbfx`, `(0).field`) or an engine call stays formula-only (`unsupported`).
- Coverage: 256 formula records (parameters + timers) -> 227 have a machine form (20 of them for only some alternatives), 29 do not: decoder residue 14, helper functions not inlined (`ParryingSwordBuf.calcDmgCut`, `HandlingerOfGodspeedBuf.GetGodSpearHandlingParam`, `ParalysisShotAction.CalcBufferTime`, `SkillBufferDataBase.GetParam`), `KnightPledgeBuf.EffectiveBufData`.
- The website evaluates them server-side (`vercel/src/skillExpr.js`, same semantics as `calc_engine.py`: `//` truncates, `hi/ls` are > and <=). `python build_buff_values.py --golden <file>` records reference answers from `calc_engine.Evaluator`; the website test compares its own results with them (80 cases).
- Equipment reads normalised: `EquipItemData.get_Weapon(...).Type`, `subWeapon.Type`, `get_(Sub)WeaponItemType`, `[WeaponTypeCalculatorBase.item+0x38]`, `TryGetValue(equipItem, 1|2).Type` -> main / sub weapon type (slot numbering Inferred). `status.Atk/Matk/MaxHp...` -> `<NAME>_total` inputs.

## Status -> Details window (player_status/)

What the in-game "Status -> Details" window shows, evaluated for a character. Code (libil2cpp), not checked against an in-game screen.

- `scripts/decode_status_panel.py` -> `player_status/detail_panel.json`: `UIPlayerStatusDetailPanel.Add*Status` decoded; 194 rows (`DetailStatusType`, the expression, `DisplayFormatType`) plus the panel's own `Calc*Value` helpers. Labels: `StatusDetailType<Name>` in System_th / System_us.
- `scripts/player_status.py`: reference evaluator. `Character(lv, stats, bonus, weapon, sub, body)`; gear is `item(type, atk_or_def, stable, refine)`. Runs the rows with `calc_engine.Evaluator` over the 1,164 decoded stat functions. A character has no buffs, masteries, gem-cart buffers, server bonuses or equipment buffers: the code reads those as "absent" = 0 (rules `ABSENT`, `OBJECT_GETTERS`, `BARRIER`, `ABSENT_BUFFER`). `python player_status.py` prints a sample; `--coverage` is the old name for the same listing.
- Weapon calculators: `createWeaponCalculator`'s jump table is not decoded, so the type -> class map is `CALC_OF_TYPE` (ItemType 8 Katana, 9 Halberd, 10 OneHandSword, 11 TwoHandSword, 12 Bow, 13 Bowgun, 14 Rod, 15 Magictool, 16 Knuckle, 17 Shield, 18 ShortSword, 19 Arrow, 23 NinjutsuBook, anything else = bare hands). A virtual call `WeaponTypeCalculatorBase.X(calc)` runs the concrete class's own `X` with `item` bound to that weapon.
- Decoder residue handled in `clean()`: the float 1.0 printed as `0x3f800000`; `[[WeaponTypeCalculatorBase.item+0x28]+0x40]` = `item.dbData.Stable` (dump.cs: ItemData.dbData 0x28, ItemDBData.Stable 0x40); `SkillMasteryList[..].skillData.Level` of an unlearned mastery = 0; `fcvt(x)` = x; any other raw `[..+0x..]` load is taken as 0 and the row is flagged `assumed0` (they are all lookups into skill / bonus lists the character does not carry).
- Result: 198 rows (194 + CRT/LUK/MEN/TEC totals), 187 evaluate. Def / Mdef / Flee are now computed from `scripts/armour_overrides.py` (hand-decoded from the disassembly; symexec cannot follow the jump table of `switch (body.BattleCustomize)`, BattleCustomize = ability & 3: 0 normal, 1 light, 2 heavy, 3 none = an empty body slot; CheckArmorAbility(item, t) = ((ability & 3) eq t)). Never evaluate: Exp / AtkMpRecovery (decoder residue `?ccmp`), Drop (helper path lost), FirstAttackRate (`GodspeedLocus.CalcFirstAttackRate` undecoded), AvoidStack (`AvoidActionManager.get_MaxAvoidCount` undecoded), PhysicalPursuit / MagicPursuit (helpers null).
- `scripts/export_status_spec.py` -> `player_status/status_spec.json` (155 functions, cleaned, 277 KB) and, with `--golden FILE`, 8 sample characters with the reference rows. The web backend (toram-tools-MAIN `vercel/src/statusEval.js`) is a JS port tested against that golden file (1,584 rows).
- "Add stats" window (`UIBuildPanel`, decoded with decode_fn.py): it previews a build. Rows: STR INT VIT AGI DEX + Personality (UIBuildPanel.Status 0..5; CRT / LUK / MEN / TEC come from the personality, there is no bar for them). `PlayerPrimaryStatus.GetAllStatusPoint` = str + vit + int + agi + dex + unspent statusPoint - 9 (the 9 is the 5 stats' starting points... not verified; the decoder shows `?addv` residue). `GetOverBuildPoint` = max(dex - UIBuildPanel.DefaultMaxPoint, 0) (soft cap; its value is set in the static constructor, not read). The preview calls the same `IPlayerStatusCalculator` as the Details window (`BuildPlayerStatus`), so the secondary stats shown while allocating are the ones player_status.py computes. Points granted per level and the cost per point are not in the decoded client (the allocation goes to the server: `PlayerDataManager.StatusUp` / `StatusUpResponse`) - not found, so not documented.

## 2026-10-02 update-readiness refactor (no new game build involved)
- New `scripts/il2.py` (ELF facts, name/signature lookups, il2cpp stub discovery), `fingerprint.py`, `build_factory_maps.py`, `update_game.py`, `scripts/README.md`; `pipeline.sh` rewritten (runs from `scripts/`, `--derived` mode, `PYTHONHASHSEED=0`).
- All scripts are now in `scripts/`; `sys.path` inserts point at the script directory; generated maps live in `<work>/state/`.
- Verified: factory/mastery/buffer maps and the GemCart inputs regenerate byte-identically; `skill_reference.json` equals the previous one modulo the order of OR-alternatives (now sorted); a second derived run is identical except a timestamp; `validate_reference` 17/17; viewer selftest ok.
- Fixed: registlet id 44 display used one decimal instead of two (`{0:F2}`).

### Item stat lines: Limit markers (BonusType 96-120)

Item lines are (BonusType id, value) pairs in `ItemProperties`. The ids 96-120 are bonus-script commands, not stats: `BonusScriptManager.funcEquipTypeLimit` handles them (its per-type test sits behind a jump table symexec cannot follow). The in-game wording (ItemProperty_th/us) gives the condition; a marker is a header, the lines after it belong to it (tooltip order, e.g. crystal 9617). Inferred, not decoded: With X = the main or the sub weapon is of that type.
96 Ninjutsu scroll (23) · 97 One-handed (10) · 98 Two-handed (11) · 99 Bow (12) · 100 Bowgun (13) · 101 Rod (14) · 102 Magic tool (15) · 103 Knuckle (16) · 108 Dual swords (main 10 and sub 10) · 109 Shield (17) · 115 Halberd (9) · 116 Katana (8) · 117 Arrow (19) · 118 Dagger (18) · 119 Light armour (ability 1) · 120 Heavy armour (ability 2) · 114 bEventCheck (event period; treated as off) · 193 bDamageLimit (no text; kept as an unknown marker). 104-107, 110-113 are ordinary stats that sit in the same id range.

### Gear catalogue export (`scripts/export_gear.py`)

Run from `D:\toram_re` with Bash: `python "D:\toram reverse data\scripts\export_gear.py" [--selftest]`; writes `gear/gear.json` = `{ items, bonuses, limitRules, bonusById }`. Every equippable item and crysta with its stat lines as `(BonusType, value)` pairs from `ItemMaster` / `ItemProperties`; names and icons from `items/items.csv`, Thai bonus labels from `skills/damage/variables.json`. A `{ limit }` entry is a Limit marker (see above): the `{ b, v }` lines after it only count while its rule holds (`any` = main or sub weapon type in the list, `both` = both hands that type, `armour` = armour ability). The web repo copies it to `vercel/private/gear.json` with `scripts/build-gear-db.mjs` (private data, never in the bundle). Label: Code (decoded) for the lines, Inferred for the Limit rules.

## Missing-data requests from the calculator backend (2026-10-03, `WORK PROMPT/missing-data/` 01-06 in toram-tools-MAIN)
Inbox of 6 gap files (52 item stat lines that moved no Details row). All answered in the files themselves (Status + Result sections); this is the RE-side record. Code unless marked.
- Result: of the 115 stat lines on items, 108 now move a Details row (`player_status/bonus_reach.json`, `scripts/measure_bonus_reach.py`; method = add `<bonus> +7`, retry `+1000`, 1H sword and Rod). The 7 left are explained in 01 / 04 (3 combat-time barriers, per-slot element, 2 combat-only buffers, 1 line with no client reader). Rows: 201 (was 198), 0 null, 8 approximate for named lookups (skill levels, weapon element, registlet 70 / 72).
- Equipment buffers: `EquipBuffManager` (BonusType 135..165, 20 `EquipBuffDataBase` classes, combined by `SumValue`) decoded by `scripts/build_equip_buffers.py` -> `player_status/equip_buffers.json`; the Details rows read `TryGetEquipBuffer(...).Value / .CalcValue` and `EquipBuffManager.GetParam`.
- CORRECTION: the request named `ConversionAction.CheckApplicationConversion` as the owner of `bStrToAtk` ... `bDexToMAtk`. It is the Conversion skill's weapon-type mask. The real readers are `BonusManager.CulcConvertAtk` / `CulcConvertMAtk` (per mille of the allocated stat, added before the ATK% multiplier). The old decoder returned 0 for them (enumerator loop).
- Decoder / exporter defects found (each changed values): (1) float-returning panel helpers were read from the integer return register (`ret[0]`), losing `bonus + 100` and returning stray weapon types: fixed in `decode_status_panel.py` (float -> `ret[1]`, detected from `dump.cs`), 9 helpers re-decoded; (2) the "absent" rule held the unanchored word `GetBonusValue`, which swallowed `GetBonusValueWithBuf` (six element shields, Physical / Magic Resist never moved); (3) `CalcHpRecovery` / `CalcMpRecovery` returned 0 for every character (the `isBattle` branches merged, multiplier start 1.0 lost), `GetCalcBonusValue` and `GetMaxBonusConstant_Rate` (`...To10` lines) were loops reduced to nothing; (4) the panel section `AddGrantStopStatus` (3 rows) was missing from the method list. Hand-decoded bodies live in `scripts/bonus_overrides.py` with an evidence assert (`check()`, run by `export_status_spec.py`).
- Lesson (again): a Bash heredoc turned `\b` into a backspace byte in `decode_status_panel.py` and `bonus_overrides.py` (the regex silently never matched). Control-character scan after every patch found both; patch with `chr(92)` or the Edit tool.
- `export_status_spec.py`: `bonusRead` is now measured (119 names with the rows each moves), new key `equipBuffers`, `rules.tryEquipBuffer`; `status_golden.json` has 14 characters. The JS port (`vercel/src/statusEval.js`) must follow the "Port delta" in the missing-data README.
- Open: nothing is checked in game (acceptance numbers are listed per file); `AvoidStack` assumes the system option `Avoid` = 0 (Inferred default).

## Skills / masteries / weapon element for the Details calculator (2026-10-03, `WORK PROMPT/missing-data/07-skills-masteries-weapon-element.md`)
Request: Atk Matk MaxMP MpRecovery AtkMpRecovery EqDef stayed assumed0 until RE exported the mastery table and recovered `GetEquipElement`. Done; Code unless marked.
- `GetEquipElement(type)` = `equipBonusList[type].bonusList.FirstOrDefault(Type == 65).Value` (lambda `cmp w8, #0x41`, `Value` +0x14), 0 without the line. Input per slot (`weaponElement`, `subWeaponElement`); only reader: `CalcBaseMaxMp` (element 8 Mana: + int(INT / 2.5)).
- `symexec.MASTERY_RECV` (opt-in): `SkillMasteryBase.GetMasteryParam` keeps its receiver `SkillMasteryList[uid]`; abstract weapon-calculator calls from outside the class keep the receiver too. `redecode_stats_receivers.py` upgraded 46 stat functions (idempotent, md5-identical on rerun), `harvest_stats.py` and `decode_status_panel.py` set the flag. `STATS.md` regenerated. 116/116 mastery call sites resolved.
- `build_mastery_table.py` -> `player_status/mastery_table.json`: 128 masteries / 170 params by level (recipes in `D:\toram_re\masteryrecipes`); residue fixed: double literal `vec(lo, hi)`, `Math.Max` stray arguments; open: DoubleThrow (293) `Trigger` `?addv` (no Details row reads it). `measure_mastery_reach.py` -> `mastery_reach.json` (which skill moves which row; idle-but-referenced: 199 / 201 battle only, 525 needs a running buffer).
- Defects found (values changed): raw `item+0x42` (ItemData.Function) / `item+0x38` (Type) read 0; `this.calc*Param` inside calculator methods and `get_Stable` -> `CalcStable` ran `OneHundSwordCalculator` for every weapon (ASPD / Stable of 2H, bow, rod ... wrong); `CheckApplicationConversion` sat in the `absent` rule (types 10 11 13 16, mask 0x4b); `.dbData.Stable` after a call is one dotted field. Abstract base entries are no longer exported.
- Gotchas: `D:\toram_re` still holds older copies of `symexec.py` etc. and several scripts insert it first on `sys.path` (a flag set on the wrong module is silently ignored): pre-import from `scripts/`. Bash heredoc collapsed `\t` of a path into a TAB again (found by scanning control characters; Edit tool fixes).
- Open: Cast Mastery equip limit (`CheckSkillMainEquipLimit` mask table) blocks Cspd when 1033 is learned; `KnightWill.GetParam` (520, Hate row); `equipSkillList`; nothing checked in game (acceptance in the missing-data file).

### Follow-up, same day: everything else that was approximate (missing-data 07, final)
- Closed: Cspd with Cast Mastery (`SkillUtil.CheckSkillMainEquipLimit` hand-decoded: test `(EqLimit & flag) != 0`, mask per main weapon type, evidence-asserted), Hate with Knight's Will (`KnightWill.GetParam`: byte table at rodata 0x949a9f, Lv x 30 / 1 / 25 / 20 / 50 / 1, `<< shield`), gear-side skill levels (`SkillManager.GetSkillLv` 0x2391784: learned -> max(own, equip), only equip -> equip, none -> -1, Flag 3 NinjaSkill -> skill 1218; `CreateMasteryList` adds equip masteries without a max; `GetAllSkillLvInTree` / `GetSkillNumInTree` loop `GetSkillLv`), registlets 26 / 37 / 50 / 70 / 72 / 216 (inputs `registlet`, `partyMembers`), `OptionsSystem.Avoid` (`optionAvoid`, the ctor never writes +0x54 so 0), DoubleThrow `Trigger` (`50 + sum(i & 0x7ffffffe)`, NEON loop emulated from rodata 0x945480 / 0x946360 and asserted at every level).
- SkillMaster record fix: `EqLimit` is Int32 (CreateSkillData: Int16 Int16 Byte Int16 Byte Int16 Int32, then 8 bytes SkillType AssistFlag PremisePosId ConnectPosId TreePosX TreePosY SkillFlag EventId, Int16 SortId). The old `SkillType` column (`raw_flags`) was the high half of EqLimit; the real SkillType enum was exported under `TargetType` (already known); `TargetType` itself is not in the record. `export_skills_full.py` writes full `eq_limit` / `eq_limit_mask`.
- `sweep_virtual_receivers.py` (434 stat functions): receiver-less virtual calls on `WeaponTypeCalculatorBase` (`CalcStable`, `CalcSub*`, `SubCalc*`, `CorrectHit`) re-decoded with the receiver (`symexec.MASTERY_RECV` covers every method of that class); `_tN` numbering of re-decoded files differs from before (a counter shared by the process), values are the same: the 18 older golden characters stayed identical. A shadowed variable (`equip` = equipment buffers vs equip skills) briefly zeroed BarrierSpeed in one golden sample: caught by diffing the old golden against the new one; always diff the old golden after touching the evaluator.
- Final: 201 rows, 0 assumed0, 0 failed, 0 raw loads, 156 functions, 24 golden characters, 1404-combination sweep with 0 null rows, `bonus_reach` 108 / 115, `mastery_reach.json` regenerated.

## Skill icon gaps (2026-10-03, `WORK PROMPT/missing-data/10-skill-icons-missing.md`)
- 57 tree entries without icon classified: `skills_full.json|csv` new column `icon_reason` (`export_skills_full.py`): 1 `tree_header`, 46 `unreleased` (`CanNotUse`), 10 `no_sprite_shipped`. Cause for all: `UIIconBase.SkillIcon` -> `sk_<SkillId:D3>` absent from the atlas -> `CheckSprite` fails -> `mapMarker_2` (Code). `icon_map` unchanged (520/577).
- `runn_*` sprites: string-literal xref (NEON-free adrp+ldr scan over .text, slots = RELA sources) shows effect-type / buff-arrow consumers, not skills. 10 `sk_*` atlas sprites (167 168 202 271 289 397 399 456-458) have no SkillMaster record.
- Gotcha: `export_skills_full.py` first saves raw atlas sprites as `icons/sk_<spriteId>.png`, then overwrites `sk_<uid>` with the mapped sprite, so a file name is a uid copy whenever a record with that uid exists (639 / 799 are copies of sk_612 / sk_777).

## Skills 417-425 (Phalanx tree, `#ファランクススキル`, tree type 13): damage code check (2026-10-03)
Result: no damage / buff / mastery code exists in the client for any of the nine (Code).
- Records only (`SkillMaster`): 417 Shield Lancer (Buffer, root), 418 Guard Pierce (Attack, prem 417), 419 Assault Lance (Attack, prem 417), 420 Dragon Leap (Attack, prem 417), 421 Revolver Shield (Buffer, prem 418), 422 Powered Charge (Attack, prem 419), 423 Survive Armor (Mastery, root), 424 Rampart (Circle, prem 423), 425 Fatum (Buffer, prem 424). `SkillFlag` = NoMarketSearch | CanNotUse for all; description is the placeholder "No Info Data...", no level notes. Names are JP only (`Skill_*` text has no translation). Tree layout (TreePosX/Y) and premise links are the only usable data.
- `SkillId` enum: no constant between 406 (ColorSynthesisGuide3) and 449 (Taming); `SkillFactory` jump table (emulated, `state/_factory_map.json`, 398 ids) has no entry in 380-470 except 449 / 452 / 455; `_mastery_map.json` and `_buffer_map.json` have none of 417-425.
- Immediate-constant scan (`scan_const.py 417..425`, whole .text): every hit is unrelated (GameReturnCode / KeyCode / HttpStatusCode values, UI layout offsets, `MagicStormAction` / `MagicFallAction` literals, `EquipBuffAttack` and `ExSkillManager.OnSkillNotAllowed` using 424/425 as GameReturnCode-style codes); no SkillId compare, no `GetParam`/`CreateMasterySkill` case.
- Conclusion: the skills are unreleased placeholders; multipliers, MP cost and effects are not in this client build (not even server-fed at runtime, since `CanNotUse` blocks use). Re-check on a game update: if the tree gets released the factory map / enum will gain entries (`update_game.py plan` flags new `SkillFactory` ids).

## Calculator gaps 08 + 09 (2026-10-03, `WORK PROMPT/missing-data/08-*.md`, `09-*.md`)
- 08: `build_overview.py` now writes `alts[].calc` (machine form, weapon scenario folded into `w`) for 1,279 of 1,465 damage alternatives; rules in `damage_calc_rules.py`; `validate_damage_calc.py` (node parse with the site's `skillExpr.js`, numeric re-check, residual csv). Display output byte-identical except 3 ailment rows (skills 81 / 1027 / 1221: `parse_args` counted `<<` as a bracket and showed `, playerAction`; fixed, `overview_th` regenerated).
- 09 item 2: measuring masteries at the top level (not Lv 10) shows DefUp 483, KnowledgeOfDefense 492, FleeUp 486 and OneChance 133 DO move Details rows; the hand-decoded `CalcDef/CalcMdef/CalcFlee/get_AtkMpRecovery` had dropped every skill term. Fixed (`armour_overrides.py` now reuses the decoded lets, `bonus_overrides._atkmp` reuses the decoded body with its single `?ccmp` residue replaced), new env `GemCartBufferManager.GetBufferValue`; golden 24 -> 29 characters (among the old 24 only case 18 changed: Flee 85 -> 86, the new ShinobiWay 1217 `Flee` term).
- Verdicts for the 81 remaining: 65 combat only, 6 read by Details through a running buff / battle branch / scroll sub weapon, 10 never read (8 dead data, 2 read only as a buffer). A `TryGetBuf(uid)` of the same id is a buffer lookup, not a mastery read.
- `calc_engine.Evaluator` built `a << b` for every bit operator (MemoryError / 0.33 s per character); now one operation. The copy in `D:\toram_re` was synced.
- Scripts run from `D:\toram_re` must append it to `sys.path` after the scripts dir: it holds stale `dis_android`, `symexec`, `build_variables`, `run_skills`.

## Tooling de-duplication (2026-10-04, `TORAM ONLINE BIGDATA/tools/`)
- New `tools/common.py`: single copy of `decode` / `fast_decode`, `read7bit` / `read_str`, `parse_text_table` (formats A-D) and repo-relative `ROOT`. `s1`..`s6` use it (no `D:\` paths; `s1`/`s2` still need the game cache / network). `legacy_scripts/decode.py` and `scan_mobs.py` import it instead of keeping copies. Checked: the new parser equals the old `s5` parser on all 9,818 `.dec` files (6,816 parses, 0 differences); varint round-trip ok. `fast_decode` not run here (numpy not installed).
- BUG fixed (`Code`): `s5_text_readable.py` escape was a no-op (`.replace("\r","\r")`), so 4,392 text rows with newline/tab broke line-based readers (e.g. `System_th.tsv` had 12,518 lines for 10,358 rows). Now written as `\\r` `\\n` `\\t`; the 41 affected TSVs under `readable/text` were rewritten in place from the existing files (csv round-trip asserted byte-exact for unaffected content; lines == rows in every file afterwards). Anything that read those TSVs by splitting lines saw broken rows before.
- Retired to `legacy_scripts/_retired/` (nothing imports them, README there): `export_skills`, `skill_table`, `extract_all`, `decode_all`, `extract_text`, `hexview`, `intview`, `meta_header`, `meta_search`, `meta_strings`.
- Not done: the repo-root `scripts/` tree (123 files) still has its own `decode.py` and copies of the text parsers (`cache.py`, `revision.py` are byte-identical to `tools/legacy_scripts`); `export_items` / `export_trophies` / `export_quests` private text parsers are still separate (they differ in duplicate-row handling). `s6` and the full `s5` rerun need the original cache mtimes and were not run here.
- Correction to the review: `s1` imported `../../scripts` which IS in the repo (root `scripts/`), not outside it.

## `toramre` package, phase 1: change alerts (2026-10-04, `toramre/`, `tests/test_watch.py`)
- `python -m toramre watch [--since VER] [--out DIR] [--fail-on low|medium|high]`: snapshots every table hash of every kept version (`BynaryData`, `GameScene_<lang>`; `state/snapshot_latest.json`, git-ignored), compares consecutive versions and writes `CHANGES.md` + `changes.json` with tags NEW / REMOVED / CHANGED / TEXT_CHANGED / LAYOUT_BROKEN / BINARY_CHANGED (severity high-medium-low, exit code 1 at `--fail-on`). Row-level detail: text tables by (id, kind, no), fixed-width masters by record index.
- Check (`Code`): the CHANGED + LAYOUT_BROKEN events on the 20 real BynaryData versions equal the 50 `changed` rows of `_history.csv` table by table; the 3 NEW events are WarpListMaster, WarpList_th, WarpList_us.
- FINDING: the numeric version (LE hex) is not a release order. `a7e43f32` (newest, channels A/D) has a smaller number than `6f304932`; ordering by number mis-counted MissionSkipMaster (1 change instead of 2). `versions.list_versions` therefore follows `_history.csv` for BynaryData and falls back to the number only for versions it does not list (GameScene_<lang> still use the number: check once a real update arrives).
- Framing width changes of heuristic-framed tables (EquipModelProperty ...) are tagged CHANGED with a note, not LAYOUT_BROKEN: a different count can shift the guessed width. LAYOUT_BROKEN = a text table that parsed before no longer consumes to the last byte, or a fixed-width framing that disappeared (1 on real data: HighRaidBossMaster 6f8b1932 -> 49dc2132, 689 -> 710 bytes; heuristic, the table has its own parser).
- Not built yet (plan order): IL2CPP unit tags (`UNIT_CHANGED`, needs `scripts/fingerprint.py` + the binary), `STALE_DOC`, phases 2-6 (pipeline wrappers, update runbook, schema inference, IL2CPP front end, CI). `BINARY_CHANGED` works from `snapshot["extra"]["so_sha256"]` but nothing fills it here (no `libil2cpp.so` in the repo).

## `toramre` phase 2: CLI stages + dashboard UI (2026-10-04, `toramre/cli.py`, `toramre/data/stages.py`, `toramre/ui/`)
- Commands: `watch` (phase 1), `ui [--out FILE] [--serve [PORT]] [--fragment]`, `versions`, `stage [extract cdn code masters text history]` (runs `tools/s1..s6` in order, stops at the first failure). `pip install -e .` gives the `toramre` entry point; `python -m toramre` works without installing.
- Dashboard (`state/dashboard.html`, one self-contained page, data embedded, no server or network needed; fonts fall back offline): summary strip (bundles, master versions, alerts per severity), Alerts (grouped by version pair, newest first; filters: severity, tag, bundle, search), Change matrix (table x version grid; click a changed cell to open its alerts), Versions (changed tables per version). Test: changed cells in the matrix = CHANGED + LAYOUT_BROKEN events (`tests/test_ui.py`).
- `s4_masters.py`: `_framing.json` was written with a Windows-only `out + r"\_framing.json"` path; now `os.path.join`.
- Seen in the report (`Inferred`, heuristic framing): MissionSkipMaster in `6f304932` shows "records 135 -> 129, 0 records differ" because the guessed record width changes with the size; the table needs its own parser before record-level diffs mean anything.

## `toramre brain`: chain engine for master-table layouts (2026-10-04, `toramre/brain/`, `tests/test_brain.py`)
- Grammar (`grammar.py`): schemas as JSON (raw / typed fields / counted lists / strings / tagged-union `switch`), one parser, exact-EOF or `ParseError` with the offset.
- Strategies (`synth.py`, `hints.py`): code-hint (owner class from name tokens in `readable/code/cs/Assembly-CSharp`, 9,391 classes indexed to `state/class_index.json`), anchor-fit (+ tag, tag+count, two-count fits), small-search. Acceptance (`confidence`): fits every distinct version, null test 0/48 byte-shuffled copies, >= 16 records, no raw block > 64 bytes, switch cases x 8 <= records, and records-until-EOF schemas need >= 2 file sizes. `refine` splits raw blocks into typed fields (Inferred).
- Results on the newest data (25 frontier tables): learned 3 - RecipeMaster `count u32 x [recipeId i32, type u8, releaseLv i16, price i32, difficulty i16, createId i32, createVal i16, category u8, materialDatas list(u32)[u8 recipeNo, u8 lv, i32 id, i16 val]]` (Code: `RecipeDBData` ctor + exact-EOF on 9 distinct versions; 2,079 records = `items/item_recipes.csv`), GuildQuestMaster (u32 count 1,181 after one prefix byte; `[i32 id, i32, switch(type u8 1..4)]`; types Inferred), RegistletMaster (u32 = 1, u16 count 159, `{i16 id, i16 levelCap, i32 enhancePowder}`: the same layout as the hand decode in PROJECT backlog 13, found independently). 22 open (reasons in `toramre brain status`).
- Pitfalls met and fixed while building: (1) an id byte also explains record lengths when id ranges coincide with record types (GuildQuestMaster tag at offset 1 with 11 cases vs the real type byte with 4) -> ranking prefers fewer switch cases; (2) small single-version files fit many grammars by chance (AvatarColorPallet `list(u8)[raw3]` is plausible but unprovable) -> they stay weak; (3) the candidate cap filled with weak code-hint results before anchor-fit reached the right one -> per-strategy caps.
- `watch` uses learned schemas: e.g. RecipeMaster dad0fc31 -> 0b170732 = recipes 638-643 added, `releaseLv` changed on 20 recipes.
- `guard.py`: `Boundary` on xigncode / appsign / GameAssembly.dll paths, entropy > 7.6 bits/byte over >= 4 KB, any host other than toram-jp.akamaized.net.
- Sources consulted for the design (web, 2026-10-04): format-inference research (BinPRE, BinStruct, BIEBER) for field-inference ideas; Cpp2IL (ISIL / CFG analysis of IL2CPP method bodies) as a possible route to the loader bodies; Kaitai Struct as a possible export format for learned schemas.

## `toramre fetch`: CDN downloader in the program (2026-10-04, `toramre/net/`, `tests/test_fetch.py`)
- Replaces the sequential `scripts/cdn_fetch.py` (now a wrapper; `tools/s2_cdn_catalog.py` too, which also fixes its Windows-only `\` paths). One parser copy: `toramre/net/revision.py` (`scripts/revision.py` and the legacy copy re-export it).
- Observed on the live CDN (2026-10-04, label Code/observed): HTTP/2, `Accept-Ranges: bytes` (206 on Range), ETag = `"<md5 of the body>:<timestamp>"` (BynaryData a7e43f32: md5 557a4c21... equals the ETag), Last-Modified present. The catalog `size` field is not bytes: BynaryData 50 vs 529,279 B, Motion90 2,187 vs 22,936,768 B (~10.4 KB per unit, Inferred).
- Features: categories / regex / delta (manifest), threads + token bucket, retries with exponential backoff + jitter and `Retry-After`, `.part` + Range resume (restart when the server ignores Range), UnityFS + Content-Length + ETag-MD5 checks before an fsync + atomic rename, `--revalidate` (304), disk check, report `state/fetch_report.json`, `verify` (md5 of every file on disk), `--then extract,watch`; every URL through `guard.check_url`.
- Tests: local fake CDN (ThreadingHTTPServer): plan filters + delta, parallel fetch, 503/429 retry, Range resume, server ignoring Range, bad MD5 / non-UnityFS bodies never reach the cache, 304 revalidation, guard; plus stored `RevisionInfoBinary_A.bytes` == `catalog_A.csv` (5,089 keys). Live: `fetch catalog` + `fetch get --only data` (3 bundles, 0.9 MB) into a scratch folder, second run = 3 current, `verify` 3/3.
- FINDING (rule 8, PROJECT "Findings" updated): channels C and D now carry BynaryData `012b5132`, not decoded here; D changed 4 bundles since the stored tables, C 37 changed + 13 new. `data/cdn/` refreshed. Next step on the user's machine: `toramre fetch get --only data,text --channel D --then extract,watch`.
