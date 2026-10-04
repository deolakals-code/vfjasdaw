# Trophies (เหรียญตรา)

Made by `scripts/export_trophies.py` from the newest cached `BynaryData/TrophyMaster` and `GameScene_th`
(`Trophy_th`, `System_th`). Output: `trophies.csv`, `trophies.json` (754 rows).

## Data

| Source | Content |
|---|---|
| `TrophyMaster` | `<i32 ver=2><u32 count=653>` + 653 × `<i32 Id><i32 BinaryId><u8 Type>` (ver ≠ 2: first int is the count, no Type). Parses to the exact end (5885 bytes). |
| `Trophy_th` | `<u32 count>` + `<u32 trophy id><u8 kind><varint len><utf8>`; kind 0 name, 1 reward text, 2 condition text. 754 ids × 3 kinds. |
| `System_th` | `TrophyListLabel<Type>` = tab name (e.g. 8 จำนวนเพื่อน, 255 เหรียญตราประจำวัน, 253 ประจำสัปดาห์). |

Columns: `id`, `binary_id`, `type`, `category`, `source`, `name`, `condition`, `reward`.
`？？？` names and `???` rewards are the game's own hidden entries (the text file stores them that way).

- 653 permanent trophies come from the master (tabs 1–24, 254).
- 101 daily (ids 10000+, 67) and weekly (ids 20000+, 34) trophies exist **only** in `Trophy_th`. The server assigns
  them (`InitializeDaily` / `InitializeWeekly`). Daily vs weekly is **inferred** from the id range and the texts
  ("ในวันนี้" / weekly event wording).
- High Raid trophies are a separate table (`HighRaidTrophyMaster`), already exported in `monsters/high_raid.json`.

## System (client code, libil2cpp S1)

| Item | Where | Behaviour |
|---|---|---|
| Load | `TrophyManager.ReadMasterData` 0x175EFB8 | fills `trophyList[Id] = {Id, BinaryId, State = 0, Type}` |
| Player state | `TrophyManager.Initialize(byte[])` 0x175F2DC | the server sends one byte per trophy; `State = bytes[BinaryId]` (0x175F3C4..0x175F3CC) |
| States | enum `TrophyFlagType` | 0 None, 1 Check (in progress), 2 Complete (reward waiting), 3 Acquired (claimed) |
| Live update | `Initialize(Dictionary<int,byte>)` 0x175FC0C | state 1 → 2 posts a system chat message (trophy done) |
| Claim | `TrophyCheckReward` 0x1760DE8 → server `TrophyCheckReward` packet; `RecevieTrophyCheckReward` 0x1760EAC | on success sets state 3 and removes the announcement (daily 255 / weekly 252 / normal) |
| Red dot | `CompleteTrophyCheck` 0x1760950 / 0x1760AB8 | any trophy with state 2 |
| Tabs | `GetActiveTrophyTypeList` 0x1760B48 | distinct `Type` values, sorted; 252..255 hidden except 254 |
| Progress | `GetTrophyProgressResponse` → `TrophyProgressData {TrophyId, TrophyType, ProgressList[ConditionType, OptionalConditionList, TargetValue, CurrentValue]}` | counters come from the server |
| Condition kinds | enum `Toram.Common.Trophies.TrophyConditionType` | 43 kinds: Level, SubdueMob, SubdueMobUuid, MissionClear, SmithProf, TotalTime, Running, RareDrop, FirstAid, DeadCount, Friend, BlackKnightScore, FishId, PetRace, … |

Not in the client: the numeric condition/reward tables (only the texts above), progress counters, the roll of
daily/weekly trophies. Getting them would need server responses (out of scope).
