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
- Base skill multipliers are NOT in client data (only bonus notes text); likely in packed code or server.

## Metadata (meta_dump.py: custom v31 parser, metadata only)
- 20631 types, 99438 fields, 160321 methods, 25401 constants (enum values + consts), all decoded.
- SkillMasterData declared field order = record layout `<HHBHBHHHBBBBBBBBH` (17 fields, skill_table.py).
- Every skill has a `*Action` class with instance field `skillRate` (HardHitAction.skillRate, ...):
  no metadata default value, so multipliers are set in packed code. Not recoverable from metadata.
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
- Icons: UIIconAtlas in sharedassets0 has 459 `sk_<uid:03d>` (441 of 577 skills; missing = pet/smith/alchemy/newer trees)
  + 17 `runn_*` buff icons. export_skills_full.py writes skills/icons/.
- Not in client data: base MP cost, cast time, range, cooldown, multipliers (SkillActionBase.CastTime/ActionRange,
  *Action.skillRate, SkillPopUpWindow.mpCost are runtime fields set in packed code).

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
