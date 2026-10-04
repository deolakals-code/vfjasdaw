# Level and EXP — evidence

Sources: S1 (`libil2cpp.so`), D1 (`dump.cs`), D4 (`meta_android/constants.tsv`). RVA = file offset + 0x4000 for code; `.rodata` VA = file offset.

## 1. `PlayerStatusBase.GetNextExp` — RVA 0x20575B0 (virtual slot 27)

```
0x20575b8  ldp  x9, x1, [x8, #0x188]     ; vslot 5 get_PrimaryStatus
0x20575c4  ldr  s0, [x0, #0x10]          ; PlayerPrimaryStatus.lv
0x20575cc  ldr  s2, [0x946d88]           ; 0.05f
0x20575d0  fmov s1, #0.5
0x20575d4  scvtf s0, s0                  ; L
0x20575d8  fmul s3, s0, s0 ; fmul s3, s3, s0   ; L^3
0x20575e0  fmul s2, s3, s2               ; L^3 * 0.05
0x20575e4  fmul s1, s0, s1               ; L * 0.5
0x20575ec  fadd s0, s0, s0               ; 2L
0x20575f0  fmul s1, s1, s2
0x20575f8  fadd s0, s0, s1
0x20575fc  fcvtzs x8, s0                 ; (long), +inf -> long.MinValue
```

Only override: `MobaPlayerStatus.GetNextExp` 0x203EC28 (`lv>100 → 0, >75 → 800, >50 → 400, >=26 → 200, else 100`).

## 2. `UIMobDropPanel` (TypeDefIndex 7382)

Fields: `expPenalty byte[] @0x60`, `expBonus short[] @0x68`, `expBonusLevel @0x70`, `expPenaltyLevel @0x74`.

`.ctor` 0x1B32A14:
- `expPenalty = new byte[40]` InitializeArray blob `5FAB447F…C5E3DA0F`.
- `expBonus = new short[11]` blob `237B846B…E6FBB1FD`.
- `{expBonusLevel, expPenaltyLevel} = {9, 20}` loaded as one 8-byte constant at VA 0x92C5B8.

| Blob (D4) | Raw | Decoded |
|---|---|---|
| `237B846B3352C2492CAA576BDB60657F54A308B4A99633ECA20BFE87E6FBB1FD` (blob22) | `e803e803e803e803e803e803840320035802c8000000` | int16: 1000,1000,1000,1000,1000,1000,900,800,600,200,0 |
| `5FAB447F60C426075B043AE939684C11F1BC00BDA315E15CB8947D53C5E3DA0F` (blob40) | `0102030405060708090a0c0e10121416181a1c1e2124272a2d303336393c4044484c5054585a5a5a` | uint8: 1..10, 12..30 step 2, 33..60 step 3, 64..88 step 4, 90,90,90 |

`GetDiffLevelExp(exp, diffLevel)` 0x1B32858:
```
0x1b32860  tbnz w2, #31 -> penalty path        ; negative never happens (caller passes |d|)
0x1b32864  cmp expBonusLevel(9), d ; b.ge bonus
0x1b32870  cmp expPenaltyLevel(20), d ; b.gt return exp unchanged
0x1b3287c  GetExpPenalty(d - 20) ; exp * (100 - p) / 100 ; max(.,1)
0x1b328d0  GetExpBonus(d)       ; exp * (100 + b) / 100 ; max(.,1)
```
`GetExpBonus` 0x1B3291C / `GetExpPenalty` 0x1B32998: `index < Length ? array[index] : array.Last()`.

Caller `UIMobDropPanel.Initialize` 0x1B31D2C:
```
0x1b324f4  ldr w21, [mobMaster, #0x2c]     ; MobStatusMaster.exp
0x1b32558  IPlayerStatusCalculator slot 0 (get_Lv)
0x1b325c4  ldr w20, [mobMaster, #0x28]     ; MobStatusMaster.lv
0x1b325ec  sub w20, w20, w22               ; mobLv - playerLv
0x1b32604  cneg w2, w20, mi                ; abs
0x1b32610  bl GetDiffLevelExp
0x1b32638  SystemTextManager.Get("MapPanelMobDropExpLabel") -> label text
```

## 3. `MobMaster.CheckMobLevelExpWarning(playerLevel, mobId)` 0x1F29E8C

`(mobLv − playerLv)^2 >= 0x190 (400)` → chat system message 0x1C, once (`isLevelWarning`).

## 4. `GameEventManager.GetExpBonusRate(lv, isParty)` 0x20EDF2C

Loop over `termEventDataList` entries of type `ExpBonusTermEventData`:
```
0x20edfd4  ldrsh BonusLevelLimit (+0x30) ; if >=1 and >= lv: sum += LevelBonus (+0x34)
0x20edff0  ldr   PartyBonus (+0x38)      ; if isParty and >=1: sum += PartyBonus
```

## Reproduce

```
python D:\toram_re\dis2.py 0x20575B0 0x203EC28 0x1B32858 0x1B3291C 0x1B32998 0x1B32A14 0x1F29E8C 0x20EDF2C
grep -E "5FAB447F|237B846B" D:\toram_re\meta_android\constants.tsv
```
